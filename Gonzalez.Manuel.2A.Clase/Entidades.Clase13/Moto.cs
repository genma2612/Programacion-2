using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Clase13
{
    public class Moto : Vehiculo
    {
        protected float _cilindrada;

        protected float Cilindrada
        {
            get { return this._cilindrada; }
        }

        protected override string Mostrar()
        {
            StringBuilder retorno = new StringBuilder();
            retorno.Append("MOTO" + base.Mostrar());
            retorno.AppendFormat("CILINDRADA: {0}\n", this.Cilindrada);
            return retorno.ToString();
        }

        public override string ToString()
        {
            return this.Mostrar();
        }

        public Moto(string patente, byte ruedas, EMarcas marca, float cilindrada) : base(patente, ruedas, marca)
        {
            this._cilindrada = cilindrada;
        }

        public Moto(EMarcas marca, float cilindrada, string patente, byte ruedas) : this(patente, ruedas, marca, cilindrada)
        {
        }



    }
}
