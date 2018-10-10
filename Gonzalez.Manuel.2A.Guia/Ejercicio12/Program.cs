using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 12";
            int suma=0;
            do
            {
                Console.Clear();
                Console.WriteLine("Ingrese numeros para que sean sumados. Suma parcial: {0}", suma);
                suma += int.Parse(Console.ReadLine());    
                Console.WriteLine("Continuar? (S/N)");
            } while (ValidarRespuesta.ValidaS_N(char.Parse(Console.ReadLine())));
            Console.WriteLine("Ha finalizado. La suma total es de: {0}", suma);
            Console.ReadLine();
        }
    }
}
