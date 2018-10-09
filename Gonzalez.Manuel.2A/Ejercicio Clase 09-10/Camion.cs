﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Clase_09_10
{
    class Camion : Vehiculo
    {
        protected float _tara;

        protected float Tara
        {
            get { return this._tara; }
        }

        protected override string Mostrar()
        {
            return base.ToString() + "TARA: {0}\n" + this.Tara;
        }

        public override string ToString()
        {
            return this.Mostrar();
        }

        public Camion(string patente, byte ruedas, EMarcas marca, float tara) : base(patente, ruedas, marca)
        {
            this._tara = tara;
        }

        public Camion(Vehiculo v, float tara) : this(v.Patente, v.Ruedas, v.Marca, tara)
        {
        }

    }
}
