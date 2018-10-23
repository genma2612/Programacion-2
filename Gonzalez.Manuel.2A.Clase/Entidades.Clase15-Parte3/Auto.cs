using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Clase15_Parte3
{
    public class Auto
    {
        private string _color;
        private string _marca;

        public string Color { get { return this._color; } }

        public string Marca { get { return this._marca; } }

        public override bool Equals(object obj)
        {
            bool retorno = false;
            if (obj is Auto && this == (Auto)obj)
                retorno = true;
            return retorno;
        }

        public override string ToString()
        {
            return "Marca: " + this.Marca + " - Color: " + this.Color;
        }

        public static bool operator ==(Auto a, Auto b)
        {
            return a._color == b._color && a._marca == b._marca;
        }

        public static bool operator !=(Auto a, Auto b)
        {
            return !(a == b);
        }

        public Auto(string color, string marca)
        {
            this._color = color;
            this._marca = marca;
        }
    }
}
