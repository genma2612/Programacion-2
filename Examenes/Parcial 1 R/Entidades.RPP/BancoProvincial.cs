using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.RPP
{
    public class BancoProvincial : BancoNacional
    {
        public string provincia;

        public BancoProvincial(BancoNacional bn, string provincia) :base(bn.nombre, bn.pais)
        {
            this.provincia = provincia;
        }

        public override string Mostrar()
        {
            return base.Mostrar();
        }

        public override string Mostrar(Banco b)
        {
            return base.Mostrar(b) + "PROVINCIA: " + this.provincia + " - ";
        }
    }
}
