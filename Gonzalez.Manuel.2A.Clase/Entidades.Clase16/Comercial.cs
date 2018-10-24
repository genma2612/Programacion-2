using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Clase16
{
    public class Comercial : Avion
    {
        protected int _capacidadPasajeros;

        public override double PorcentajeARBA
        {
            get
            {
                return 0.25;
            }
        }

        public override string Informacion
        {
            get
            {
                return base.Informacion + " - Capacidad de pasajeros: " + this._capacidadPasajeros;
            }
        }

        public double CalcularImpuesto()
        {
            return this._precio * this.PorcentajeARBA;
        }

        public Comercial(double precio, double velocidad, int pasajeros) : base(precio, velocidad)
        {
            this._capacidadPasajeros = pasajeros;
        }
    }
}
