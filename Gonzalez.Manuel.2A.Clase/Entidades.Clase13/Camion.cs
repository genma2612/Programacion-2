using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Clase13
{
    public class Camion : Vehiculo
    {
        protected float _tara;

        protected float Tara
        {
            get { return this._tara; }
        }

        protected override string Mostrar()
        {
            StringBuilder retorno = new StringBuilder();
            retorno.Append("CAMIÓN" + base.Mostrar());
            retorno.AppendFormat("TARA: {0}\n", this.Tara);
            return retorno.ToString();
        }

        public override string ToString()
        {
            return this.Mostrar();
        }

        public Camion(string patente, byte ruedas, EMarcas marca, float tara) : base(patente, ruedas, marca)
        {
            this._tara = tara;
        }

        public Camion(Vehiculo v, float tara) : this(v.Patente, v.Ruedas, v.Marca, tara)
        {
        }

    }
}
