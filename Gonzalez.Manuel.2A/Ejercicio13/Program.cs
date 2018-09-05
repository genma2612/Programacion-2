using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 13";
            int opcion;
            double decim;
            string binario;
            do
            {
                Console.WriteLine("1-Decimal a binario.\n2-Binario a decimal.\n3-Salir");
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Ingrese el número a convertir a binario: ");
                        decim = double.Parse(Console.ReadLine());
                        binario = Conversor.DecimalBinario(decim);
                        Console.WriteLine("El número {0} en binario es: {1}\nPresione enter para continuar...", decim, binario);
                        Console.ReadLine();
                        break;
                    case 2:
                        Console.WriteLine("Ingrese el binario a convertir a decimal: ");
                        binario = Console.ReadLine();
                        decim = Conversor.BinarioDecimal(binario);
                        Console.WriteLine("El binario {0} en decimal es: {1}\nPresione enter para continuar...", binario, decim);
                        Console.ReadLine();
                        break;
                    default:
                        break;
                }
                Console.Clear();
            } while (opcion != 3);






        }
    }
}
