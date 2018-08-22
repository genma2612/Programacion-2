using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01
{
    class Ejercicio01
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 01";
            int numero;
            int max=0;
            int min=0;
            int cant = 5;
            float prom=0;
            for (int i = 0; i < cant; i++)
            {
                Console.WriteLine("Ingrese un nùmero: ({0}/{1})", i+1, cant);
                numero = int.Parse(Console.ReadLine());
                prom = prom + numero;
                if(i == 0)
                {
                    max = numero;
                    min = numero;
                }
                else if(numero > max)
                {
                    max = numero;
                }
                else if (numero < min)
                {
                    min = numero;
                }
            }
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("El valor màximo es: {0}. El minimo: {1} y el promedio es: {2:#,###.##}", max, min, prom / cant);
            Console.ReadLine();
        }
    }
}
