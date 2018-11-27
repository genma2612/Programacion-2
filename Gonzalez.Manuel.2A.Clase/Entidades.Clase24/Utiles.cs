using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Clase24
{
    public abstract class Utiles
    {
        string conexion = Properties.Settings.Default.conexion;

        protected double _precio;
        protected string _marca;

        protected abstract double Precio{ get; set; }
        protected abstract string Marca { get; set; }

        public virtual string utilesToString()
        {
            return string.Format("Marca: {0} Precio: {1}", this._marca, this._precio);
        }
    }
}
