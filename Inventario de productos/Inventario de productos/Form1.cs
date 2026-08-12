using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Inventario_de_productos
{
    public partial class Form1 : Form
    {
        ProductoRepositorio repo = new ProductoRepositorio ();//instancio el objecto apenas comienza el programa
        public Form1()
        {
            InitializeComponent();
            ActualizarLista();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            decimal precio = decimal.Parse(txtPrecio.Text);
            int stock = int.Parse(txtStock.Text);

            repo.Agregar(nombre, precio, stock);

            ActualizarLista();

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //verificacion del seleccionamiento si esta vacio o no
            if(dataProductos.CurrentCell == null)
            {
                MessageBox.Show("Seleccione un producto primero");
                return;
            }

            //capturo lo que contiene en la celda id de la tabla, lo convierto a int y lo guardo en la variable id
            int id =  Convert.ToInt32(dataProductos.CurrentRow.Cells["id"].Value);

            //CurrentRow -> entro a la fila donde esta parado el cursor en ese mismo momento
            //Cells[]-> selecciona toda la fila con las celdas una por cada columna, [] le indico que celda seleccionar exactamente 
            //valie -> me devuelve el contenido de esa celda

            repo.Eliminar(id);

            ActualizarLista();

        }

        private void ActualizarLista()
        {
            dataProductos.DataSource = null;                 // limpio lo que había
            dataProductos.DataSource = repo.ObtenerTodos();  // le paso la lista
        }

    }
}
