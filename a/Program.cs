using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double precio, total, descuento, pagar;
            int cantidad;

            Console.Write("Digite el precio del producto: ");
            precio = double.Parse(Console.ReadLine());

            Console.Write("Digite la cantidad de productos: ");
            cantidad = int.Parse(Console.ReadLine());

            if (precio > 0 && cantidad > 0)
            {
                total = precio * cantidad;

                if (total > 25000)
                {
                    descuento = total * 0.10;
                }
                else
                {
                    descuento = 0;
                }

                pagar = total - descuento;

                Console.WriteLine("Total de la compra: " + total);
                Console.WriteLine("Descuento: " + descuento);
                Console.WriteLine("Total a pagar: " + pagar);
            }
            else
            {
                Console.WriteLine("Los datos no son validos");
            }

            Console.ReadKey();
        }
    }
}