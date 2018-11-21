using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Clase23
{
    public enum ESexo { Masculino, Femenino, Indeterminado}

    public class Persona
    {
        protected string _nombre;
        protected string _apellido;
        protected int _edad;
        protected ESexo _sexo;
        // Propiedades
        public string Nombre { get { return this._nombre; } }
        public string Apellido { get { return this._apellido; } }
        public int Edad { get { return this._edad; } }
        public ESexo Sexo { get { return this._sexo; }}

        public string ObtenerDatos() // No uso el toString() porque sòlo necesito estos 4 elementos.
        {                            // ToString() podrìa incluir datos de una posible clase Base.
            return this.Nombre + " " + this.Apellido + " " + "EDAD:" + this.Edad + " SEXO:" + this.Sexo;
        }

        // Constructor
        public Persona(string nombre, string apellido, int edad, ESexo sexo)
        {
            this._nombre = nombre;
            this._apellido = apellido;
            this._edad = edad;
            this._sexo = sexo;
        }



    }
}
