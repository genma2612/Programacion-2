using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 10";
            int altura;
            int dot = 1;
            Console.Write("Ingrese la altura de la piramide: ");
            do
            {
                altura = int.Parse(Console.ReadLine());
                if (altura < 1)
                {
                    Console.WriteLine("ERROR: El numero debe ser un entero positivo");
                }
            } while (altura < 1);
            Console.WriteLine();
            for (int i = 0; i < altura; i++)
            {
                for (int j = 0; j < dot; j++)
                {
                    Console.Write("*");
                }
                dot += 2;
                Console.WriteLine();
            }
            Console.Write("\nPresione enter para salir...");
            Console.ReadLine();

        }
    }
}
