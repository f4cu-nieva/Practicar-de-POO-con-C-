using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
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

        //evento de cuando se selecciona una una fila de la tabla y se inserta los datos en los textboxs  
        private void dataProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dataProductos.CurrentRow != null)
            {
                txtNombre.Text = dataProductos.CurrentRow.Cells["NOMBRE"].Value.ToString();
                txtPrecio.Text = dataProductos.CurrentRow.Cells["PRECIO"].Value.ToString();
                txtStock.Text = dataProductos.CurrentRow.Cells["STOCK"].Value.ToString();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dataProductos.CurrentRow == null)//condicion si no se selecciono ninguna fila de la tabla
            {
                MessageBox.Show("Selecciona un producto de la lista");
                return;
            }

            Producto p = new Producto();//instancio un producto nuevo 

            //les cargo los datos capturados desde los textboxs 
            p.Nombre = txtNombre.Text;
            p.Precio = Convert.ToInt32(txtPrecio.Text);
            p.Stock = Convert.ToInt32(txtStock.Text);
            p.Id = Convert.ToInt32(dataProductos.CurrentRow.Cells["ID"].Value);

            repo.Actualizar(p);//le mando el objecto producto como parametro para que lo actualice en la BBDD

            ActualizarLista();//invoco el metodo Actualizarlista para que se vea los cambios reflejados
        }
    }
}
