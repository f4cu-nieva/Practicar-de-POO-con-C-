using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reprodutor_de_musica
{
    internal class Profesor : Persona
    {
        public string Materia { get; set; }

        public Profesor(string materia, string nombre, int edad)
        {
            this.Materia = materia;
            this.Nombre = nombre;
            this.Edad = edad;
        }
    }
}
