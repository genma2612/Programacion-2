using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Ejercicio_Classe_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el nombre...");
            Sello.mensaje = Console.ReadLine();
            Console.WriteLine(Sello.Imprimir());
            Console.ReadKey();
            Sello.ImprimirEnColor();
            Console.ReadKey();
            Sello.Borrar();
            Console.WriteLine(Sello.Imprimir());
            Console.ReadKey();
        }
    }
}
