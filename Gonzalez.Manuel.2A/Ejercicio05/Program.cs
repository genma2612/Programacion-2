using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 05";
            Console.WriteLine("Esta aplicación encontrará los centros numericos hasta el número que ud. elija.");
            Console.Write("Ingrese un número: ");
            CentroNumerico.EncontrarCentrosNumericos(int.Parse(Console.ReadLine()));
            Console.Write("Presione enter para salir...");
            Console.ReadKey();
        }
    }
}
