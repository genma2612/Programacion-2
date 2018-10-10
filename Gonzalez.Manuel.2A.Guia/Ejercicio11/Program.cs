using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 11";
            int num = 0;
            int min=0;
            int max=0;
            float suma=0;
            bool flag = true;
            bool valid;
            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine("Ingrese 10 numeros enteros (-100 / 100) {0}/10. Minimo actual: {1}. Máximo actual: {2}.", i,min,max);
                do
                {
                    num = int.Parse(Console.ReadLine());
                    valid = Validacion.Validar(num, -100, 100);
                    if (!valid)
                    {
                        Console.Clear();
                        Console.WriteLine("ERROR: El rango permitido es de -100 a 100. Reingrese un numero:");
                    }   
                } while (!valid);
                if(flag)
                {
                    min = max = num;
                    flag = false;
                }
                suma += num;
                if (num < min)
                    min = num;
                if (num > max)
                    max = num;
                Console.Clear();
            }
            Console.WriteLine("Valor minimo ingresado: {0}. Valor máximo ingresado: {1}. Promedio: {2:#,###.#}", min, max, suma / 10);
            Console.ReadLine();
        }
    }
}
