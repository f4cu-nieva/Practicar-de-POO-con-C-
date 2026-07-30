using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_composicion
{
    internal class Carrito
    {
        List<Producto> Productos = new List<Producto>();//Carrito va a contener una lista de productos 

        public void AgregarProducto()
        {
            string nombre;
            float precio = 0f;

            Console.WriteLine("Ingrese el nombre del producto: ");
            nombre = Console.ReadLine();

            Console.WriteLine("Ingrese el precio del producto: ");
            precio = float.Parse(Console.ReadLine());

            Productos.Add(new Producto(nombre, precio));
        }

        public float CalcularPrecioTotal()
        {
            float PrecioTotal = 0f;

            Console.WriteLine("Calculando el precio total de los productos...");
            foreach (Producto item in Productos)
            {
                PrecioTotal += item.Precio;
            }

            return PrecioTotal;
        }

        public void MostrarLista()
        {
            
            foreach (Producto item in Productos)
            {
                Console.WriteLine("Nombre: " + item.Nombre + " -  Precio: " + item.Precio);
            }

        }
    }
}
