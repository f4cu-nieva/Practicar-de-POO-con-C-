using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Reprodutor_de_musica
{
    internal class Curso
    {
        public string Nombre { get; set; }
        public Profesor Profesor { get; set; }
        public List<Alumno> Alumnos { get; set; } = new List<Alumno>();

        public Curso(string nombre, Profesor profesor)
        {
            this.Nombre = nombre;
            this.Profesor = profesor;

            Console.WriteLine("Nombre del curso: " + Nombre);
            Console.WriteLine("Profesor: " + Profesor.Nombre);
            Console.WriteLine("Materia que se va a dictar: " + Profesor.Materia);
        }

        public void AgregarAlumno()
        {
            string nombre;
            int edad = 0;
            double nota = 0;
            List<double> notas = new List<double>();

            Console.WriteLine("Ingrese el nombre del alumno: ");
            nombre = Console.ReadLine();

            Console.WriteLine("Ingrese la edad del alumno: ");
            edad = int.Parse(Console.ReadLine());

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Nota #" + (i + 1));
                Console.WriteLine("Ingrese la nota del alumno: ");
                nota = double.Parse(Console.ReadLine());
               
                notas.Add(nota);

            }

            Alumnos.Add(new Alumno(nombre, edad, notas));

            Console.WriteLine("\nAlumno " + nombre + " agregado correctamente a la lista!\n");
            
        }


        public void MostrarBoletines()
        {
            double promedio = 0;
            bool aprobacion = false;

            Console.WriteLine("\nLista de alumnos: ");

            foreach (Alumno item in Alumnos)//for para recorrer la lista de alumnos
            {
                Console.WriteLine("Nombre: " + item.Nombre + " \nEdad: " + item.Edad);

                for (int i = 0; i < 2; i++)//for para recorrer la lista de las notas
                {
                    Console.WriteLine("Nota #" + (i + 1) + ": " + item.Notas[i]);
                }

                promedio = item.Promedio();
                Console.WriteLine("Promedio: " + promedio);

                aprobacion = item.EstaAprobado(promedio);

                if (aprobacion)//en caso de true
                {
                    Console.WriteLine("APROBADO");
                }
                else//en caso de false
                {
                    Console.WriteLine("DESAPROBADO");
                }

                Console.WriteLine("\n");

            }
        }

        public int CantidadAprobado()
        {
            int ContadorAprobados = 0;
            double promedio = 0;
            foreach (Alumno item in Alumnos)
            {

                promedio = item.Promedio();

                if (item.EstaAprobado(promedio))
                {
                    ContadorAprobados++;
                }

            }
            return ContadorAprobados;
        }

        
    }
}
