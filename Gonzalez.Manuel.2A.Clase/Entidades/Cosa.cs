using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Cosa
    {
        #region Atributos

        public string cadena;
        public double numero;
        public DateTime fecha;

        #endregion

        #region Mètodos

        public static string Mostrar(Cosa elemento)
        {
            return elemento.Mostrar();
        }

        private string Mostrar()
        {
            return this.cadena + " " + this.numero.ToString() + " " + this.fecha.ToShortDateString();
        }

        public void EstablecerValor(string c)
        {
            this.cadena = c;
        }

        public void EstablecerValor(double n)
        {
            this.numero = n;
        }

        public void EstablecerValor(DateTime f)
        {
            this.fecha = f;
        }

        #endregion

        #region Constructor
        /// <summary>
        /// Constructor por defecto con valores inicializados.
        /// </summary>
        public Cosa()
        {
            this.cadena = "Sin valor";
            this.numero = 1.9;
            this.fecha = DateTime.Now;
        }

        /// <summary>
        /// Constructor con ingreso de cadena.
        /// </summary>
        /// <param name="c">Cadena a ingresar.</param>
        public Cosa(string c) : this() //invoco al constructor por defecto y luego cambio el valor de la cadena.
        {
            this.cadena = c;
            //this.numero = 1.9;
            //this.fecha = DateTime.Now;
        }

        /// <summary>
        /// Constructor con ingreso de cadena y numero
        /// </summary>
        /// <param name="c">Cadena a ingresar.</param>
        /// <param name="n">Numero a ingresar.</param>
        public Cosa(string c, double n) :this(c)
        {
            //this.cadena = "Sin valor";
            this.numero = n;
            //this.fecha = DateTime.Now;
        }

        /// <summary>
        /// Constructor con ingreso de cadena, numero y fecha
        /// </summary>
        /// <param name="c">Cadena a ingresar.</param>
        /// <param name="n">Numero a ingresar.</param>
        /// <param name="f">Fecha a ingresar.</param>
        public Cosa(string c, double n, DateTime f) :this(c,n)
        {
            //this.cadena = "Sin valor";
            //this.numero = 1.9;
            this.fecha = f;
        }

        #endregion
    }
}
