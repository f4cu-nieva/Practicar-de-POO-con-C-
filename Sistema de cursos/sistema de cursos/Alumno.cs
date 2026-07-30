using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reprodutor_de_musica
{
    internal class Alumno : Persona
    {
        public List<double> Notas { get; set; } = new List<double>();

        public Alumno(string nombre, int edad, List<double> notas)
        {
            this.Nombre = nombre;
            this.Edad = edad;
            this.Notas = notas;

        }
        public double Promedio()
        {
            double promedio = 0;

            promedio = (this.Notas[0] + this.Notas[1]) / this.Notas.Count;

            return promedio;
        }

        public bool EstaAprobado(double prom)
        {
            bool aprobacion = false;

            if (prom >= 6)
            {
                aprobacion = true;
            }

            return aprobacion;
        }
    }
}
