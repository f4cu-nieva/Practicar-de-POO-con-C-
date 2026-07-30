using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_composicion
{
    internal class Program
    {
static void Main(string[] args)
        {
            Carrito Carrito = new Carrito();
            int Cantidad = 0;
            float MontoTotal = 0;

            Console.WriteLine("Ingrese la cantidad de productos que quiera comprar: ");
            Cantidad = int.Parse(Console.ReadLine());

            for(int i = 0; i < Cantidad; i++)
            {
                Console.WriteLine("Producto #" + (i + 1));
                Carrito.AgregarProducto();
            }

            Console.WriteLine("Lista de los productos ingresados: ");
            Carrito.MostrarLista();

            MontoTotal = Carrito.CalcularPrecioTotal();

            Console.WriteLine("El monto total es: $" + MontoTotal);
        }
    }
}

/*
2. Composición: una clase con lista
Sumale al anterior una clase Carrito que tenga una lista de Producto, pueda agregar productos y calcular el precio total.
 */