using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio11
{
    class Validacion
    {
        public static bool Validar(int valor, int min, int max)
        {
            if (valor < 101 && valor > -101)
                return true;
            else
                return false;
        }
    }
}
