using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio13
{
    class Conversor
    {
        public static string DecimalBinario(double num)       //Convierte un número de decimal a binario
        {
            string retorno = "";
            int i;
            if (num > 0)
            {
                for (i = 0; ; i++)
                {
                    if ((Math.Pow(2, i)) > num)
                        break;
                }
                for (int j = i - 1; j >= 0; j--)
                {
                    if (num >= Math.Pow(2, j))
                    {
                        retorno += 1;
                        num -= Math.Pow(2, j);
                    }
                    else
                        retorno += 0;
                }
            }
            else
                retorno += 0;
            return retorno;
        }

        public static double BinarioDecimal(string numBin)       //Convierte un número binario a decimal
        {
            double retorno = 0;
            int lenght = numBin.Length;
            int potencia = lenght - 1;
            for (int i = 0; i < lenght; i++)
            {
                if(numBin[i] == '1')
                {
                    retorno += Math.Pow(2, potencia);
                }
                potencia--;
            }
            return retorno;
        }
    }
}
