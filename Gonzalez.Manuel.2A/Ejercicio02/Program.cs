using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02
{
    class Ejercicio02
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 02";
            int numero;
            //int cuadrado;
            //int cubo;
            do
            {
                Console.WriteLine("Ingrese un nùmero:");
                numero = int.Parse(Console.ReadLine());
                if(numero < 1)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("ERROR. Reingresar numero!");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            } while (numero < 1);
            //cuadrado = (int) (Math.Pow(numero, 2));
            //cubo = (int)(Math.Pow(numero, 3));
            //Console.WriteLine("El numero ingresado es: {0}. Su cuadrado es {1} y el cubo es {2}", numero, cuadrado, cubo);
            Console.WriteLine("El numero ingresado es: {0}. Su cuadrado es {1} y el cubo es {2}", numero, Math.Pow(numero, 2), Math.Pow(numero, 3));
            Console.WriteLine("Presione una tecla para salir...");
            Console.ReadKey();
        }
    }
}
