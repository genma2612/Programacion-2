using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio00
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 00";
            string nombre;
            int edad;
            Console.WriteLine("Ingresar nombre:");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingresar edad:");
            edad = int.Parse(Console.ReadLine()); //"." en tipo de dato "int" para metodos y atributos
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Su nombre es: {0} y su edad: {1}", nombre, edad); // Las "mascaras" se muestran como {0}, segùn cant. de parametros.
        }
    }
}
