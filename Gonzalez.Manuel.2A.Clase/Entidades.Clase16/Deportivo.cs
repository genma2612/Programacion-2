using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Clase16
{
    public class Deportivo : Auto, IAFIP, IARBA
    {
        protected int _caballosFuerza;

        public double PorcentajeAFIP
        {
            get
            {
                return 0.28;
            }
        }

        public double PorcentajeARBA
        {
            get
            {
                return 0.23;
            }
        }

        public override string Informacion
        {
            get
            {
                return "Patente: " + this._patente + "- Tipo: Deportivo - HP: " + this._caballosFuerza;
            }
        }

        double IAFIP.CalcularImpuesto()
        {
            return this._precio * this.PorcentajeAFIP;
        }

        double IARBA.CalcularImpuesto()
        {
            return this._precio * this.PorcentajeARBA;
        }

        public Deportivo(double precio, string patente, int hp) : base(precio, patente)
        {
            this._caballosFuerza = hp;
        }
    }
}
