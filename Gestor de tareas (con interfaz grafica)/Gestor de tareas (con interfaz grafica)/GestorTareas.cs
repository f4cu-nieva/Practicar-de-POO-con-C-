using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Gestor_de_tareas
{
    internal class GestorTareas
    {
        public List<Tarea> Tareas { get; set; } = new List<Tarea>();

        public void AgregarTarea()
        {
            string nombre;
            int op;
            bool estado = false;
            Console.WriteLine("\nIngrese el nombre de la tarea: ");
            nombre = Console.ReadLine();

            while (estado == false)
            {
                Console.WriteLine("ingrese el estado de la tarea (1-3): ");
                Console.WriteLine("1- Urgente");
                Console.WriteLine("2- Normal");
                Console.WriteLine("3- Opcional");
                op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        Tareas.Add(new TareaUrgente(nombre));
                        estado = true;
                        break;

                    case 2:
                        Tareas.Add(new TareaNormal(nombre));
                        estado = true;
                        break;

                    case 3:
                        Tareas.Add(new TareaOpcional(nombre));
                        estado = true;
                        break;

                    default:
                        Console.WriteLine("Opcion invalida, vuelva a intentarlo");
                        break;
                }

            }
            Console.WriteLine("Tarea ingresada con exito!");


        }

        public void MostrarPendientes()
        {
            bool validacion = false;
            Console.WriteLine("\nLista de tareas que no estan completadas aun:");
            foreach (Tarea item in Tareas)
            {
                if (item.Completada == false)
                {
                    Console.WriteLine(item.Titulo + " - " + item.MostrarPrioridad());
                    validacion = true;
                }
            }

            if (!validacion)
            {
                Console.WriteLine("\nNo hay tareas pendientes");
            }
        }


        public void CantidadCompletadas()
        {
            int cantidad = 0;

            foreach (Tarea item in Tareas)
            {
                if (item.Completada == true)
                {
                    cantidad++;
                }
            }

            if (cantidad == 0)
            {
                Console.WriteLine("No se ha completado ninguna tarea aun");
            }
            else
            {
                Console.WriteLine("Cantidad de tareas completadas: " + cantidad);
            }
        }

        public void CompletarTarea()
        {
            string nombre;
            bool validacion = false;

            Console.WriteLine("Ingrese el nombre de la tarea que quiere completar: ");
            nombre = Console.ReadLine();

            foreach (Tarea item in Tareas)
            {
                if (item.Titulo == nombre)
                {
                    validacion = true;
                    item.Completada = true;
                    Console.WriteLine("Se ah completado la tarea correctamente!");
                }
            }

            if (validacion == false)
            {
                Console.WriteLine("No se ah encontrado la tarea en la lista");
            }
        }

    }
}
