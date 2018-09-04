using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Clase_05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Clase 05";


            ConsoleColor red = ConsoleColor.Red;
            ETipoTinta tipo = ETipoTinta.China;
            Tinta T1 = new Tinta();
            Tinta T2 = new Tinta(red);
            Tinta T3 = new Tinta(red, tipo);
            Tinta T4 = new Tinta();

            Console.WriteLine(Tinta.Mostrar(T1));
            Console.WriteLine(Tinta.Mostrar(T2));
            Console.WriteLine(Tinta.Mostrar(T3));
            if (T1 == T4)
                Console.WriteLine(Tinta.Mostrar(T4));
            Console.ReadLine();

        }
    }
}
