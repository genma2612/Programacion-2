using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio09
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 09";
            int altura = 5;
            int dot = 1;
            for (int i = 0; i < altura; i++)
            {
                for (int j = 0; j < dot; j++)
                {
                    Console.Write("*");
                }
                dot += 2;
                Console.WriteLine();
            }
            Console.Write("Presione enter para salir...");
            Console.ReadLine();
        }
    }
}
