using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Aplicación de consola que acepta 10 números 
               e imprime el mayor y el menor de estos 10 números. */

            int[] num = new int[10];

            Console.WriteLine("Introduce 10 numeros \n");

            for (int i = 0; i < 10; i++)
            {
                Console.Write("Numero {0} >: ", (i + 1));
                num[i] = int.Parse(Console.ReadLine());

            }

            Console.WriteLine();
            Console.WriteLine("El mayor de los 10 numeros es: {0}", num.Max());
            Console.WriteLine("El menor de los 10 numeros es: {0}", num.Min());

            Console.ReadKey();
        }
    }
}
