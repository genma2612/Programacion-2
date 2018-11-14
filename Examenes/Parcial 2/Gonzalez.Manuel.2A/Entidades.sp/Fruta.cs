using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.sp
{
    public abstract class Fruta
    {
        protected string _color;
        protected double _peso;

        public abstract bool TieneCarozo { get; }

        protected virtual string FrutaToString()
        {
            return string.Format("Color: {0} Peso: {1}", this._color, this._peso);
        }

        public Fruta(string color, double peso)
        {
            this._color = color;
            this._peso = peso;
        }
    }
}
