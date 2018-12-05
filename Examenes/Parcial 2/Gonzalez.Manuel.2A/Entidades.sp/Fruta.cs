using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.sp
{
    public abstract class Fruta
    {
        private string _color;
        private double _peso;

        public string Color { get { return this._color; } set { this._color = value; } } //necesarias para serializar miembros privados.
        public double Peso { get { return this._peso; } set { this._peso = value; } }

        public abstract bool TieneCarozo { get; }

        protected virtual string FrutaToString()
        {
            return string.Format("Color: {0} Peso: {1}", this.Color, this.Peso);
        }

        public Fruta()
        {
        }

        public Fruta(string color, double peso)
        {
            this.Color = color;
            this.Peso = peso;
        }
    }
}
