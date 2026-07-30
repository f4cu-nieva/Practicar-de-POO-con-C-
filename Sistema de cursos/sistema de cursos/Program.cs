using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reprodutor_de_musica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Profesor profesor = new Profesor("Matematica", "Juliano", 35);
            Curso curso = new Curso("Ingenieria", profesor);
            int cant_aprobados = 0;

            for( int i = 0 ; i < 3 ; i++ )
            {
                curso.AgregarAlumno();
            }

            curso.MostrarBoletines();

            cant_aprobados = curso.CantidadAprobado();

            if(cant_aprobados == 0)
            {
                Console.WriteLine("No hay alumnos aprobados en este curso");
            }
            else
            {
                Console.WriteLine("Cantidad de alumnos aprobados: " + cant_aprobados);
            }
        }
    }
}
