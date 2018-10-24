using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Clase16
{
    class Carreta : Vehiculo, IARBA
    {
        public double PorcentajeARBA
        {
            get
            {
                return 0.18;
            }
        }

        double IARBA.CalcularImpuesto()
        {
            return this._precio * this.PorcentajeARBA;
        }

        public Carreta(double precio): base(precio)
        {
        }
    }
}
