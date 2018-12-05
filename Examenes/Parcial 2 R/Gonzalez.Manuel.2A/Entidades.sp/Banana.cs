using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.sp
{
    public class Banana : Fruta
    {
        private string _paisOrigen;

        public string Nombre { get { return "Banana"; } }

        public override bool TieneCarozo { get { return false; } }

        public override string ToString()
        {
            return string.Format("Nombre: {0} Pais: {1} {2} Tiene Carozo: {3}", this.Nombre, this._paisOrigen, base.FrutaToString(), this.TieneCarozo);
        }

        public Banana(string color, double peso, string pais) : base(color, peso)
        {
            this._paisOrigen = pais;
        }
    }
}
