using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Clase_09_10
{
    class Auto : Vehiculo
    {
        protected int _cantidadAsientos;

        protected int CantidadAsientos
        {
            get { return this._cantidadAsientos; }
        }

        protected override string Mostrar()
        {
            return base.ToString() + "ASIENTOS: {0}\n" + this.CantidadAsientos;
        }

        public override string ToString()
        {
            return this.Mostrar();
        }

        public Auto(string patente, byte ruedas, EMarcas marca, int asientos) : base (patente, ruedas, marca)
        {
            this._cantidadAsientos = asientos;
        }

        public Auto(string patente, EMarcas marca, int asientos) : this (patente, 4, marca, asientos)
        {
        }





    }
}
