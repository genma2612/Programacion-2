using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.sp
{
    public class Durazno : Fruta
    {
        protected int _cantPelusa;

        public string Nombre { get { return "Durazno"; } }

        public override bool TieneCarozo { get { return true; } }

        public override string ToString()
        {
            return string.Format("Nombre: {0} Cant.Pelusa: {1} {2}", this.Nombre, this._cantPelusa, base.FrutaToString());
        }

        public Durazno(string color, double peso, int pelusa) : base(color, peso)
        {
            this._cantPelusa = pelusa;
        }
    }
}
