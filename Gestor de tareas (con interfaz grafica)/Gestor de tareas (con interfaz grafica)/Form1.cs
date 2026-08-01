using Gestor_de_tareas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestor_de_tareas__con_interfaz_grafica_
{
    public partial class Form1 : Form
    {
        GestorTareas Gestor = new GestorTareas();
        public Form1()//todo lo que esta aca dentro, se va a mostrar apenas de inicie la apliacion
        {
            InitializeComponent();

            cmbPrioridad.Items.Add("Opcional");
            cmbPrioridad.Items.Add("Normal");
            cmbPrioridad.Items.Add("Urgente");

            cmbPrioridad.SelectedIndex = 0;//selecciona como predeterminado el primer item en este caso Opcional
        }

        private void button1_Click(object sender, EventArgs e) //Agrego una tarea
        {
            string nombre;
            string propiedad;

            //capturo los datos ingresados por el usuario
            nombre = txtNombreTarea.Text;
            propiedad = cmbPrioridad.Text;

            switch (propiedad)
            {
                case "Opcional":
                    Gestor.Tareas.Add(new TareaOpcional(nombre));
                    break;

                case "Normal":
                    Gestor.Tareas.Add(new TareaNormal(nombre));
                    break;

                case "Urgente":
                    Gestor.Tareas.Add(new TareaUrgente(nombre));
                    break;
            }
            
            MessageBox.Show("Se agrego la tarea correctamente");

            txtNombreTarea.Clear();//limipio el textbox para cuando se agregue la tarea

            ActualizarLista();
            
        }

        private void ActualizarLista()
        {
           lstTareas.Items.Clear();   // vacío la lista visual

            foreach (Tarea item in Gestor.Tareas)   // recorro (¡el foreach de siempre!)
            {

                string tarea;

                if (item.Completada)
                {
                    tarea = item.Titulo + " - [✓]" + " - " + item.MostrarPrioridad() ;
                }
                else
                {
                    tarea = item.Titulo + " - [X]" + " - " + item.MostrarPrioridad();
                }

                lstTareas.Items.Add(tarea);
            }
        }

        private void btnCompletar_Click(object sender, EventArgs e)
        {

            if (lstTareas.SelectedIndex == -1)//si el usuario no eligue nada y presiona completar se laza lo siguiente
            {
                MessageBox.Show("Seleccione una tarea para completar por favor");
                return;//sale automaticamente de la funcion
            }

            int i = lstTareas.SelectedIndex;//capturo el indice seleccionado de la lista de tareas

            Gestor.Tareas[i].Completada = true;//selecciono esa tarea y lo marco como completada

            MessageBox.Show("Se completo la tarea correctamente");


            ActualizarLista();
        }

        private void btnContador_Click(object sender, EventArgs e)
        {
            int cantidad = 0;

            foreach (Tarea item in Gestor.Tareas)
            {
                if (item.Completada)
                {
                    cantidad++;
                }
            }

            lblContador.Text = "Tareas completadas: " + cantidad;
        }



        private void cmbPrioridad_SelectedIndexChanged(object sender, EventArgs e)//cada vez que selecciono un campo se cambia de color
        {

            switch (cmbPrioridad.Text) {//inspecciono el texo y deacuerdo al texto se selecciona un color 

                case "Opcional":
                    cmbPrioridad.BackColor = Color.GreenYellow;
                    break;

                case "Normal":
                    cmbPrioridad.BackColor = Color.LightBlue;
                    break;

                case "Urgente":
                    cmbPrioridad.BackColor = Color.Red;
                    break;

            }
        }
    }
}
