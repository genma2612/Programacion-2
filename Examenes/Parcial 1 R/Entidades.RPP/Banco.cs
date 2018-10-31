using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.RPP
{
    public abstract class Banco
    {
        public string nombre;

        public abstract string Mostrar();

        public abstract string Mostrar(Banco b);

        public Banco(string nombre)
        {
            this.nombre = nombre;
        }
    }
}
