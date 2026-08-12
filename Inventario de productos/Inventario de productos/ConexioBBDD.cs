using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Inventario_de_productos
{
    internal class ConexioBBDD
    {

        //guardo en la variable conexion el texto de a que base de datos me quiero conectar
        private static string conexionDB = "Server=localhost;Database=inventario;Uid=appinventario;Pwd=inventario123;";

        //static para usar el metodo de forma general ya que no guarda valores propios de un objecto y sin la necesidad de instanciarlo con new
        public static MySqlConnection ConexionBBDD()
        {

            MySqlConnection conexion = new MySqlConnection(conexionDB);

            return conexion;
    }

    }
}
