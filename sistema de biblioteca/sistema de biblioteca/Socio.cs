using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace sistema_de_biblioteca
{
    internal class Socio
    {
        //Propiedades
        public string Nombre { get; set; }
        public int NumeroSocio { get; set; }

        public Socio(string nombre, int numero_socio)
        {
            this.Nombre = nombre;
            this.NumeroSocio = numero_socio;
        }
    }
}
