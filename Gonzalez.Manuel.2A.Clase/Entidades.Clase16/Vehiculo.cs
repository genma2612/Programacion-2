using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Clase16
{
    public abstract class Vehiculo
    {
        protected double _precio;

        public double Precio { get {return this._precio; } }

        public void MostrarPrecio()
        {
            Console.WriteLine("Precio: {0}", this._precio);
        }

        public Vehiculo(double precio)
        {
            this._precio = precio;
        }

    }
}
