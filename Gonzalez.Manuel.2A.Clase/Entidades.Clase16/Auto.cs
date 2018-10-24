using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Clase16
{
    public abstract class Auto : Vehiculo
    {
        protected string _patente;

        public abstract string Informacion { get; }

        public void MostrarPatente()
        {
            Console.WriteLine("Patente: {0}", this._patente);
        }

        public Auto(double precio, string patente) : base(precio)
        {
            this._patente = patente;
        }
    }
}
