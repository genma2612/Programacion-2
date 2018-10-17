using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio42
{
    class UnaException : Exception
    {

        public void GenerarMiException(Exception A, Exception B)
        {
            throw new MiException(A,B);
        }

        public UnaException() : base()
        {

        }

        public UnaException(Exception inner) : this()
        {
            this.GenerarMiException(this.InnerException, inner);
        }
    }
}
