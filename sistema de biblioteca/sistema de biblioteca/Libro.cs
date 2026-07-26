using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistema_de_biblioteca
{
    internal class Libro
    {
        //Propiedades
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public bool Prestado { get; set; }

        public Libro(string _titulo, string _autor, bool _prestado)
        {
            this.Titulo = _titulo;
            this.Autor = _autor;
            this.Prestado = _prestado;
        }


    }
}
