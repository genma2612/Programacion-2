using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.RPP
{
    public class BancoMunicipal : BancoProvincial
    {
        public string municipio;

        public BancoMunicipal(BancoProvincial bp, string municipio) :base(bp, bp.provincia)
        {
            this.municipio = municipio;
        }

        public static implicit operator string(BancoMunicipal b)
        {
            return b.ToString();
        }

        public override string ToString()
        {
            return this.Mostrar(this);
        }

        public override string Mostrar()
        {
            return base.Mostrar();
        }

        public override string Mostrar(Banco b)
        {
            return base.Mostrar(b) + "MUNICIPIO: " + this.municipio + ".";
        }
    }
}
