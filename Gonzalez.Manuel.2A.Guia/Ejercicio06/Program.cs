using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio06
{
    class Program
    {
        static void Main(string[] args)
        {
            int year;
            int cont = 0;
            Console.Title = "Ejercicio 06";
            Console.WriteLine("Ingrese el año que desea verificar:");
            year = int.Parse(Console.ReadLine());
            if (year % 4 == 0 && year > 0)
                cont++;
            if (year % 100 == 0 && year % 400 != 0)
                cont--;
            if(cont == 1)
                Console.WriteLine("El año {0} es bisiestro", year);
            else
                Console.WriteLine("El año {0} no es bisiestro", year);
            Console.Write("Presione enter para salir...");
            Console.ReadKey();
        }
    }
}