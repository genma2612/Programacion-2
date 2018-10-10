using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Clase_06_Forms
{
    class Tinta
    {
        private ConsoleColor _color;
        private ETipoTinta _tipo;

        #region Mètodos

        public static string Mostrar(Tinta elemento)
        {
            if (!object.Equals(elemento, null))
                return elemento.Mostrar();
            else
                return "";
        }

        private string Mostrar()
        {
            string retorno;
            retorno = "TINTA: " + this._tipo + " COLOR: " + this._color + ".";
            return retorno;
        }

        #region Sobrecarga de operador "=="

        public static bool operator ==(Tinta t1,Tinta t2)
        {
            bool retorno = false;
            if((object) t1 != null && (object) t2 != null) //Casteo a object para comparar mediante el == de object y no la sobrecarga realizada.
            //if(object.Equals(t1, null) && object.Equals(t2, null))
            {
                if (t1._color == t2._color && t1._tipo == t2._tipo)
                    retorno = true;
            }
            return retorno;
        }

        public static bool operator !=(Tinta t1, Tinta t2)
        {
            return !(t1 == t2);
        }

        #endregion

        #endregion

        #region Constuctor

        public Tinta()
        {
            this._color = ConsoleColor.Blue;
            this._tipo = ETipoTinta.ConBrillito;
        }

        public Tinta(ConsoleColor color) : this()
        {
            this._color =color;
        }

        public Tinta(ConsoleColor color, ETipoTinta tipo) : this(color)
        {
            this._tipo = tipo;
        }

        #endregion
    }
}
