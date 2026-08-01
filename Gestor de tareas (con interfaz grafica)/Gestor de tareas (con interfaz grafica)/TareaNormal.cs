using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestor_de_tareas
{
    internal class TareaNormal : Tarea
    {
        public TareaNormal(string titulo) : base(titulo) { }
        public override string MostrarPrioridad()
        {

            
           return "NORMAL";
        }
    }
}
