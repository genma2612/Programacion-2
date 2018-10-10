using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Clase_06_Forms
{
    class Pluma
    {
        #region Propiedades

        private string _marca;
        private int _cantidad;
        private Tinta _tinta;

        #endregion

        #region Mètodos

        public string Mostrar()
        {
            string retorno;
            retorno = "MARCA: " + this._marca + " CANTIDAD: " + this._cantidad;
            if((object)this._tinta != null)
                retorno += " " + Tinta.Mostrar(this._tinta);
            return retorno;
        }

        public static implicit operator string(Pluma elemento)
        {
            return elemento.Mostrar();
        }

        #region Sobrecargas de operador

        public static bool operator ==(Pluma pluma, Tinta tinta)
        {
            return pluma._tinta == tinta;
        }

        public static bool operator !=(Pluma pluma, Tinta tinta)
        {
            return !(pluma._tinta == tinta);
        }

        public static Pluma operator +(Pluma pluma, Tinta tinta)
        {
            if( (pluma == tinta && pluma._cantidad < 100) || (object)pluma._tinta == null )
            {
                pluma._tinta = tinta;
                pluma._cantidad += 10;
                if (pluma._cantidad > 100)
                    pluma._cantidad = 100;
            }
            return pluma;
        }

        public static Pluma operator -(Pluma pluma, Tinta tinta)
        {
            if ((pluma == tinta && pluma._cantidad > 0)) 
            {
                pluma._cantidad -= 20;
                if (pluma._cantidad < 0)
                    pluma._cantidad = 0;
            }
            return pluma;
        }

        #endregion



        #endregion

        #region Constructor

        public Pluma()
        {
            this._marca = "Sin marca";
            this._cantidad = 0;
            this._tinta = null;
        }

        public Pluma(string marca) : this()
        {
            this._marca = marca;
        }

        public Pluma(string marca, int cant) : this(marca)
        {
            this._cantidad = cant;
        }

        public Pluma(string marca, int cant, Tinta tipoTinta) : this(marca, cant)
        {
            this._tinta = tipoTinta;
        }

        #endregion


    }
}
