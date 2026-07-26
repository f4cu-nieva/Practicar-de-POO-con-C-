using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace sistema_de_biblioteca
{
    internal class Libreria
    {

        public void MostrarLibros(List<Libro> Libros)
        {
            Console.WriteLine("Lista de libros:");
            foreach (var item in Libros)
            {
                string prestado;

                if(item.Prestado == true)
                {
                    prestado = "Ocupado";
                }
                else
                {
                    prestado = "Disponible";
                }

                Console.WriteLine(item.Titulo + "  " + prestado );
            }
        }
        public void MostarSocios(List<Socio> Socios)
        {
            Console.WriteLine("Lista de socios:");
            foreach (var item in Socios)
            {
                Console.WriteLine(item.Nombre);
            }
        }

        public void PrestarLibro(List<Libro> Libros, List<Socio> Socios, string TituloLibro, string nombre_socio)
        {
            bool vali_socio = false;
            bool vali_libro = false;

            Console.WriteLine("Buscando el nombre en la lista de socio...");
            foreach (var item in Socios)
            {
                if (item.Nombre == nombre_socio)
                {
                    vali_socio = true;
                    Console.WriteLine(nombre_socio + " esta en la lista de socios");
                }
            }

            if (vali_socio == false)
            {
                Console.WriteLine(nombre_socio + " no esta en la lista de socios");
            }
            else
            {

                Console.WriteLine("Buscando el libro en la lista...");

                foreach (var item in Libros)
                {
                    if (item.Titulo == TituloLibro)
                    {
                        vali_libro = true;
                        Console.WriteLine(TituloLibro + " esta en la lista de libros");

                        if (item.Prestado == false)
                        {
                            Console.WriteLine("El libro esta disponible :)");

                            Console.WriteLine("\nLibro prestado: " + TituloLibro);
                            Console.WriteLine("Nombre del socio: " + nombre_socio);

                            item.Prestado = true;
                        }
                        else
                        {
                            Console.WriteLine("El libro no esta disponible para prestar:(");
                        }
                    }
                }

                if (vali_libro == false)
                {
                    Console.WriteLine("El libro " + TituloLibro + " no se encontro en la lista de libros");
                }

            }

        }
        public void DevolverLibro(List<Libro> Libros , string TituloLibro)
        {
            bool encontrado = false;
            Console.WriteLine("Buscando el libro en la lista...");

            foreach (var item in Libros)
            {
                if(item.Titulo == TituloLibro)
                {
                    encontrado = true;

                    Console.WriteLine("Se encontro el libro en la lista");

                    if(item.Prestado == true)
                    {
                        Console.WriteLine("Libro devuelto correctamente :)");
                        item.Prestado = false;
                    }
                    else
                    {
                        Console.WriteLine("El libro no se puede devolver porque no fue prestado aun");
                    }

                }
            }

            if(encontrado == false)
            {
                Console.WriteLine("Libro inexistente");
            }
        }

    }
}
