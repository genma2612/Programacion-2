using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Clase24
{
    public class Goma : Utiles
    {
        protected bool _soloLapiz;

        protected override double Precio { get { return this._precio; } set { this._precio = value; } }
        protected override string Marca { get { return this._marca; } set { this._marca = value; } }

        public override string ToString()
        {
            return string.Format(base.utilesToString() + " Sòlo Lapiz?: {0}\n", this._soloLapiz);
        }

        public Goma(double precio, string marca, bool soloLapiz)
        {
            this.Marca = marca;
            this.Precio = precio;
            this._soloLapiz = soloLapiz;
        }
    }
}
