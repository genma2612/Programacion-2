using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 15";

            double num1;
            double num2;
            char operation;
            do
            {
                Console.Clear();
                Console.WriteLine("Ingrese la operación que desea realizar (X +,-,*,/ Y):");
                num1 = double.Parse(Console.ReadLine());
                Console.SetCursorPosition((num1.ToString().Length + 1), 1);
                operation = char.ToLower(Console.ReadKey().KeyChar);
                Console.SetCursorPosition((num1.ToString().Length + 3), 1);
                num2 = double.Parse(Console.ReadLine());
                Console.SetCursorPosition(num1.ToString().Length + num1.ToString().Length + 4, 1);
                Console.WriteLine("= {0}", Calculadora.Calcular(num1, num2, operation));
                Console.Write("Continuar? (s/n): ");
            } while (Console.ReadKey().KeyChar != 'n');




        }
    }
}
