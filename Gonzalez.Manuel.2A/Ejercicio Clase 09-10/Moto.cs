using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Clase_09_10
{
    class Moto : Vehiculo
    {
        protected float _cilindrada;

        protected float Cilindrada
        {
            get { return this._cilindrada; }
        }

        protected override string Mostrar()
        {
            return base.ToString() + "CILINDRADA: {0}\n" + this.Cilindrada;
        }

        public override string ToString()
        {
            return this.Mostrar();
        }

        public Moto(string patente, byte ruedas, EMarcas marca, float cilindrada) : base(patente, ruedas, marca)
        {
            this._cilindrada = cilindrada;
        }

        public Moto(EMarcas marca, float cilindrada, string patente, byte ruedas) : this(patente, ruedas, marca, cilindrada)
        {
        }



    }
}
