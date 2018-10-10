using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio04
{
    class NumeroPerfecto
    {
        public static void EncontrarNumerosPerfectos()
        {
            // Formula "2 elevado a n–1 * (2n – 1)" ¿Aplicar?
            //Método step by step:
            int cont = 0;
            int suma = 0;
            for (int i = 1; i < int.MaxValue; i++)
            {
                for (int j = 1; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        suma = suma + j;
                    }
                }
                if (suma == i)
                {
                    Console.Write("{0} ", i);
                    cont++;
                }
                suma = 0;
                if (cont == 5)
                {
                    break;
                }
            }
        }
    }
}