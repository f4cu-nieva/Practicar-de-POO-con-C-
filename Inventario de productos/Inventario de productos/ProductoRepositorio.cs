using MySql.Data.MySqlClient;//libreria para usar funciones de mysql
using Org.BouncyCastle.Asn1.IsisMtt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventario_de_productos
{
    internal class ProductoRepositorio
    {
        List<Producto> Productos = new List<Producto>();//instancio una lista de productos
      
        public void Agregar(string nombre, decimal precio, int stock)//funcion para agregar un producto
        {
            //var => el compilador deduce que tipo de dato se devuelve y el var se lo puede interpretar como int, float, objecto, etc
            var conexion = ConexioBBDD.ConexionBBDD();//llamo directamente el metodo sin instanciarlo con new gracias al static 

            try
            {

                conexion.Open();//abro la base de datos
                
                //guardo la instruccion como string en la variable sql
                string sqlComando = "INSERT INTO Productos (Nombre, Precio, Stock) VALUES (@nombre, @precio, @stock)";
                //                                      instruccion, referencia a la base de datos
                MySqlCommand comando = new MySqlCommand(sqlComando, conexion);

                // Le paso los valores a los @parametros
                comando.Parameters.AddWithValue("@nombre", nombre);
                comando.Parameters.AddWithValue("@precio", precio);
                comando.Parameters.AddWithValue("@stock", stock);

                comando.ExecuteNonQuery();   // ejecuta el INSERT
                MessageBox.Show("Se agrego el producto con exito!");

            }
            catch(Exception ex)
            {

                MessageBox.Show("No se pudo agregar el producto, ERROR: " + ex);

            }
            finally
            {
                conexion.Close();
            }


        }
        
        public List<Producto> ObtenerTodos()
        {

            Productos.Clear();

            var conexion = ConexioBBDD.ConexionBBDD();

            try
            {
                conexion.Open();

                //instruccion para seleccionar todas las filas de la base de datos
                string comando = "SELECT ID, NOMBRE, PRECIO, STOCK FROM Productos;";

                MySqlCommand sql_comando = new MySqlCommand(comando, conexion);

                MySqlDataReader leer = sql_comando.ExecuteReader();

                while (leer.Read())
                {
                    Producto p = new Producto();

                    p.Nombre = leer.GetString("NOMBRE");
                    p.Precio = leer.GetDecimal("PRECIO");
                    p.Stock = leer.GetInt32("STOCK");
                    p.Id = leer.GetInt32("ID");

                    Productos.Add(p);
                }

                
            }
            catch(Exception ex)
            {
                MessageBox.Show("No se pudo abrir la base de datos, ERROR: " + ex);
            }
            finally
            {
                conexion.Close();
            }
            
            return Productos;
        }
         

        public void Actualizar()
        {
           
        }

        public void Eliminar(int id)
        {
            var conexion = ConexioBBDD.ConexionBBDD();

            try
            {

                conexion.Open();

                string sql_eliminacion = "DELETE FROM Productos WHERE ID = @id";


                MySqlCommand comando = new MySqlCommand(sql_eliminacion, conexion);

                comando.Parameters.AddWithValue("@id" , id);

                comando.ExecuteNonQuery();

                MessageBox.Show("Se elimino el producto correctamente!");

                //MessageBox.Show(sql_eliminacion);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex);
            }
            finally
            {
                conexion.Close();
            }
        }

    }
}
