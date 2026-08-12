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


            /*
             //codigo para probar la conexion a la base de datos
            bool estado = false;
            estado = repo.ProbarConexion();

            if (estado)
            {
                MessageBox.Show("Conexion a la base de datos exitosa!!!");
            }
            else
            {
                MessageBox.Show("ERROR!!!");
            }
             */
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            
            repo.Eliminar(1);
        }

        private void ActualizarLista()
        {
            dataProductos.DataSource = null;                 // limpio lo que había
            dataProductos.DataSource = repo.ObtenerTodos();  // le paso la lista
        }

    }
}
