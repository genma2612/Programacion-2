using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Clase_07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Clase 07";

            Tempera T1 = new Tempera("Generica", ConsoleColor.Black, 10);
            Console.WriteLine(T1);
            Console.ReadLine();


        }
    }
}
