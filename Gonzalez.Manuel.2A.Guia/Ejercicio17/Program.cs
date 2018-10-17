using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio17_Boligrafo;

namespace Ejercicio17
{
    class Program
    {
        static void Main(string[] args)
        {
            string pintura;
            Boligrafo bAzul = new Boligrafo(ConsoleColor.Blue, 100);
            Boligrafo bRojo = new Boligrafo(ConsoleColor.Red, 50);
            Console.WriteLine("Test:");
            bAzul.Pintar(10, out pintura);
            bRojo.Pintar(20, out pintura);
            bRojo.Pintar(20, out pintura);
            bRojo.Pintar(20, out pintura);
            Console.WriteLine("Presione enter...");
            Console.ReadLine();




        }
    }
}
