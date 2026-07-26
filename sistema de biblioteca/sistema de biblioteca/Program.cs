using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistema_de_biblioteca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Libreria libreri = new Libreria();
            List<Libro> libros = new List<Libro>();
            List<Socio> socios = new List<Socio>();
            string nombre_socio;
            string nombre_libro;

            libros.Add(new Libro("Heroes","Facundo",false));
            libros.Add(new Libro("Pinocho", "Florencia", false));
            libros.Add(new Libro("Principito", "Agustin", true));
            libros.Add(new Libro("Habitos atomicos", "Facundo", true));
            libros.Add(new Libro("Deep work", "Agustin", true));

            socios.Add(new Socio("Tomas",10));
            socios.Add(new Socio("Jose", 11));
            socios.Add(new Socio("Martin", 13));

            libreri.MostarSocios(socios);

            Console.WriteLine("\n");

            libreri.MostrarLibros(libros);

            Console.WriteLine("\n");
            Console.WriteLine("Ingrese el nombre del socio: ");
            nombre_socio = Console.ReadLine();

            Console.WriteLine("Por favor ingrese el nombre del libro: ");
            nombre_libro = Console.ReadLine();

            libreri.PrestarLibro(libros,socios,nombre_libro, nombre_socio);


            Console.WriteLine("Devolucion de un libro...");
            libreri.DevolverLibro(libros,nombre_libro);

            libreri.MostrarLibros(libros);

            //Modelá una biblioteca. Hay Libro (título, autor, ¿prestado?) y Socio (nombre, número de socio).
            //La biblioteca puede prestar un libro a un socio y devolverlo.
        }
    }
}
