using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Clase13
{
    public class Auto : Vehiculo
    {
        protected int _cantidadAsientos;

        protected int CantidadAsientos
        {
            get { return this._cantidadAsientos; }
        }

        protected override string Mostrar()
        {
            StringBuilder retorno = new StringBuilder();
            retorno.Append("AUTO" + base.Mostrar());
            retorno.AppendFormat("ASIENTOS: {0}\n", this.CantidadAsientos);
            return retorno.ToString();
        }

        public override string ToString()
        {
            return this.Mostrar();
        }

        public Auto(string patente, byte ruedas, EMarcas marca, int asientos) : base(patente, ruedas, marca)
        {
            this._cantidadAsientos = asientos;
        }

        public Auto(string patente, EMarcas marca, int asientos) : this(patente, 4, marca, asientos)
        {
        }





    }
}
