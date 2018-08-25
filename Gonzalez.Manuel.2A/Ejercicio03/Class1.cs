using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio03
{
    class Class1
    {
        public static void ImprimirPrimos(int numero)
        {
            int cont = 0;
            int i;
            int j;
            for (i = 1; i < numero; i++)
            {
                for (j = 1; j <=i; j++)
                {
                    if(i % j == 0)
                    {
                        cont++;
                    }
                }
                if(cont == 2)
                {
                    Console.Write("{0} ", i);
                }
                cont = 0;
            }
            if(numero < 2)
            {
                Console.Write("No hay numeros primos menores a {0}", numero);
            }
        }
    }
}
