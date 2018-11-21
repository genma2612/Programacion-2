using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Externa;

namespace Entidades.Clase23
{
    public class PersonaHerencia : PersonaExterna
    {

        // Propiedades
        public string Nombre { get { return this._nombre; } }
        public string Apellido { get { return this._apellido; } }
        public int Edad { get { return this._edad; } }
        public Externa.ESexo Sexo { get { return this._sexo; } }

        public string ObtenerDatos() // No uso el toString() porque sòlo necesito estos 4 elementos.
        {                            // ToString() podrìa incluir datos de una posible clase Base.
            return this.Nombre + " " + this.Apellido + " " + "EDAD:" + this.Edad + " SEXO:" + this.Sexo;
        }

        public PersonaHerencia(string nombre, string apellido, int edad, Externa.ESexo sexo) 
                         :base(nombre, apellido, edad, sexo)
        {
        }
    }
}
