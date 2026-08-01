using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestor_de_tareas
{
    internal class Tarea
    {
        public string Titulo { get; set; }
        public bool Completada { get; set; }

        public Tarea(string titulo)
        {

            this.Titulo = titulo;
            Completada = false;

        }

        public virtual string MostrarPrioridad()
        {
            return "";
        }

        public void MostrarCompletada()
        {
            Completada = true;
        }



    }
}
