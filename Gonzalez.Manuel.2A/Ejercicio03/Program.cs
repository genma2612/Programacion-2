using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 03";
            int numero = 0;
            char opcion;
            do
            {
                Console.WriteLine("Ingrese un numero...");
                numero = int.Parse(Console.ReadLine());
                Console.WriteLine("Listado de numeros primos hasta {0}:", numero);
                Class1.ImprimirPrimos(numero);
                Console.WriteLine("\nSeguir? (s/n)...", numero);
                opcion = Console.ReadKey().KeyChar;
                Console.Clear();
            } while (opcion != 'n');      
        }
    }
}
