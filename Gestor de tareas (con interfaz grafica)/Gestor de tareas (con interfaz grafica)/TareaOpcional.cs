using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestor_de_tareas
{
    internal class TareaOpcional : Tarea
    {
        public TareaOpcional(string titulo) : base(titulo) { }
        public override string MostrarPrioridad()
        {
          

            return "OPCIONAL";
        }

    }
}
