using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Clase_04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Clase 04";

            DateTime fecha = new DateTime(1993,09,03);

            Cosa primerCosa  = new Cosa();
            Cosa segundaCosa = new Cosa("Cadena añadida 1");
            Cosa terceraCosa = new Cosa("Cadena añadida 2", 24);
            Cosa cuartaCosa  = new Cosa("Cadena añadida 3", 24, fecha);

            Console.WriteLine(Cosa.Mostrar(primerCosa));
            Console.WriteLine(Cosa.Mostrar(segundaCosa));
            Console.WriteLine(Cosa.Mostrar(terceraCosa));
            Console.WriteLine(Cosa.Mostrar(cuartaCosa));

            Console.ReadLine();
        }
    }
}
