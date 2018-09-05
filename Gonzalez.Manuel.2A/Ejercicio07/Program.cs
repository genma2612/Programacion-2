using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 07";
            int year;
            int month;
            int day;
            int total = 0;
            Console.WriteLine("Ingrese el dia: XX/XX/XXXX");
            day = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el mes: {0}/XX/XXXX", day);
            month = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el año: {0}/{1}/XXXX", day, month);
            year = int.Parse(Console.ReadLine());
            Console.WriteLine("Fecha ingresada: {0}/{1}/{2}", day, month,year);
            total = Calculos.CompletarAñoIngresado(year, month, day);
            total = total + Calculos.CompletarAños(year);
            total = total + Calculos.CompletarAñoActual(year, month, day);
            Console.WriteLine("Ud. ha vivido {0} dias.\nPresione enter para salir...", total);
            Console.ReadLine();
        }
    }
}
