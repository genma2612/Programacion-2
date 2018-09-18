using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Clase07
{
    public class Tempera
    {
        #region Parametros

        private sbyte _cantidad;
        private ConsoleColor _color;
        private string _marca;

        #endregion

        #region Mètodos

        private string Mostrar()
        {
            return "Marca: " + this._marca + " Color: " + this._color + " Cantidad: " + this._cantidad + ".";
        }

        #endregion

        #region Sobrecargas

        public static implicit operator string(Tempera elemento) //retorna marca color cant.
        {
            string retorno = "";
            if ((object) elemento != null)
                retorno += elemento.Mostrar();
            return retorno;
        }

        public static explicit operator sbyte(Tempera elemento) //retorna cant.
        {
            return elemento._cantidad;
        }

        public static bool operator ==(Tempera t1, Tempera t2)
        {
            bool retorno = false;
            if ((object)t1 != null && (object)t2 != null)
            { 
                if (t1._color == t2._color && t1._marca == t2._marca)
                    retorno = true;
            }
            return retorno;
        }

        public static bool operator !=(Tempera t1, Tempera t2)
        {
            return !(t1 == t2);
        }

        public static Tempera operator +(Tempera t1, sbyte cant)
        {
            t1._cantidad += cant;
            return t1;
        }

        public static Tempera operator +(Tempera t1, Tempera t2)
        {
            Tempera retorno = new Tempera(t1._marca, t1._color, t1._cantidad);
            if (t1 == t2)
            {
                retorno += t2._cantidad;
            }
            return retorno;
        }

        /*
        public static Tempera operator -(Tempera t1, sbyte cant)
        {
            t1._cantidad -= cant;
            if (t1._cantidad < 0)
                t1._cantidad = 0;
            return t1;
        }

        public static Tempera operator -(Tempera t1, Tempera t2)
        {
            Tempera retorno = new Tempera(t1._marca, t1._color, t1._cantidad);
            if (t1 == t2)
            {
                retorno -= t2._cantidad;
            }
            return retorno;
        }
        */

        #endregion

        #region Constructor

        public Tempera(string marca, ConsoleColor color, sbyte cantidad)
        {
            this._marca = marca;
            this._color = color;
            this._cantidad = cantidad;
        }

        #endregion

    }
}
