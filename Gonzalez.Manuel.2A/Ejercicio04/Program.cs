using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 04";
            Console.WriteLine("Esta aplicación encontrará los 4 primeros números perfectos.");
            Console.ForegroundColor = ConsoleColor.Green;
            NumeroPerfecto.EncontrarNumerosPerfectos();
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("\nPresione enter para salir...");
            Console.ReadKey();
        }
    }
}
