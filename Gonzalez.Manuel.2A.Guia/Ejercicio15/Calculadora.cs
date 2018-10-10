using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio15
{
    class Calculadora
    {
        public static double Calcular(double N1, double N2, char operation)
        {
            double result = 0;
            switch (operation)
            {
                case '+':
                    result = N1 + N2;
                break;
                case '-':
                    result = N1 - N2;
                    break;
                case '*':
                    result = N1 * N2;
                    break;
                case '/':
                    result = N1 / N2;
                    break;
                default:
                    break;
            }
            return result;
        }


        /*
        private static bool Validar(double N2)
        {
            bool retorno;


            return retorno;
        }

        public static void Mostrar(double result)
        {



        }
        */
    }
}
