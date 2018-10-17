using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio42
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Metodo();
            }
            catch (MiException e)
            {
                Console.WriteLine(e);
            }
            Console.ReadLine();
        }

        static void Metodo()
        {
            try
            {
                throw new DivideByZeroException();
            }
            catch (DivideByZeroException e)
            {
                throw new UnaException(e.InnerException);
            }
        }
    }
}
