using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio05
{
    class CentroNumerico
    {
        public static void EncontrarCentrosNumericos(int num)
        {
            //Método step by step:
            int sumaMenor = 0;
            int sumaMayor = 0;
            int i, j, k;
            if (num > 7)
            {
                Console.Clear();
                Console.WriteLine("Centros numéricos: ");
                Console.ForegroundColor = ConsoleColor.Magenta;
                for (i = 6; i < num; i++)
                {
                    for (j = 1; j < i; j++)
                    {
                        sumaMenor = sumaMenor + j;
                    }
                    for (k = i + 1; ; k++)
                    {
                        sumaMayor = sumaMayor + k;
                        if (sumaMayor >= sumaMenor)
                            break;
                    }
                    if (sumaMayor == sumaMenor)
                    {
                        Console.WriteLine("  {0,-10} (1 a {1} = {2} | {3} a {4} = {2}) ", i,j-1,sumaMayor,i+1,k);
                    }
                    sumaMayor = sumaMenor = 0;
                }
                Console.ForegroundColor = ConsoleColor.Gray;
            }
            else
                Console.WriteLine("No existe un centro numérico en ese rango.");       
        }
    }
}
