using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio07
{
    class Calculos
    {
        static public int CompletarAñoActual(int year, int month, int day)
        {
            int dias = 0;
            if(month > 1)
            {
                for (int i = 1; i < DateTime.Now.Month; i++)
                {
                    dias += DateTime.DaysInMonth(year, i);
                }
            }
            dias += DateTime.Now.Day;
            return dias;
        }

        static public int CompletarAños(int year)
        {
            int dias = 0;
            for (int i = year + 1; i < DateTime.Now.Year; i++)
            {
                if (BisCheck(i)) //Puede usarse DateTime.IsLeapYear();
                    dias += 366;
                else
                    dias += 365;
            }
            return dias;
        }

        static public int CompletarAñoIngresado(int year, int month, int day)
        {
            int dias = 0;
            dias = DateTime.DaysInMonth(year, month) - day;
            for (int i = month+1; i < 13; i++)
            {
                dias += DateTime.DaysInMonth(year, i);
            }
            return dias;

        }
        
        static public bool BisCheck(int year) //Puede usarse DateTime.IsLeapYear();
        {
            int cont = 0;
            if (year % 4 == 0 && year > 0)
                cont++;
            if (year % 100 == 0 && year % 400 != 0)
                cont--;
            if (cont == 1)
                return true;
            else
                return false;
        }
    }
}
