using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Clase_05
{
    class Tinta
    {
        private ConsoleColor _color;
        private ETipoTinta _tipo;

        #region Mètodos

        public static string Mostrar(Tinta elemento)
        {
            return elemento.Mostrar();
        }

        private string Mostrar()
        {
            string retorno;
            retorno = "La tinta es " + this._tipo + " de color " + this._color + ".";
            return retorno;
        }

        #region Sobrecarga de operador "=="

        public static bool operator ==(Tinta t1,Tinta t2)
        {
            return t1._color == t2._color && t1._tipo == t2._tipo;
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
