using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.sp
{
    public class Banana : Fruta
    {
        protected string _paisOrigen;

        public string Nombre { get { return "Banana"; } }

        public override bool TieneCarozo { get { return false; } }

        public override string ToString()
        {
            return string.Format("Nombre: {0} Pais: {1} {2}", this.Nombre, this._paisOrigen, base.FrutaToString());
        }

        public Banana(string color, double peso, string pais) : base(color, peso)
        {
            this._paisOrigen = pais;
        }
    }
}
