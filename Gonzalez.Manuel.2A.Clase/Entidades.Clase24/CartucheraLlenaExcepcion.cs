using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Clase24
{
    class CartucheraLlenaExcepcion :Exception
    {
        public CartucheraLlenaExcepcion() :base("La cartuchera està llena.")
        {
        }
    }
}
