using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Clase16
{
    public class Avion : Vehiculo, IAFIP, IARBA
    {
        private double _velocidadMaxima;

        public virtual string Informacion
        {
            get
            {
                return "Precio: " + this._precio + " - Velocidad Maxima: " + this._velocidadMaxima;
            }
        }

        public virtual double PorcentajeAFIP
        {
            get
            {
                return 0.33; 
            }
        }

        public virtual double PorcentajeARBA
        {
            get
            {
                return 0.27;
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

        public Avion(double precio, double velMax) : base(precio)
        {
            this._velocidadMaxima = velMax;
        }
    }
}
