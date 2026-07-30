using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_composicion
{
    internal class Producto
    {
        public string Nombre { get; set; }
        public float Precio { get; set; }

        public Producto(string nombre, float precio)
        {
            this.Nombre = nombre;
            this.Precio = precio;
        }
        public string MostrarInfo()
        {

            return ("Nombre: " + Nombre + " -  Precio: $" + Precio);
        }

    }
}
