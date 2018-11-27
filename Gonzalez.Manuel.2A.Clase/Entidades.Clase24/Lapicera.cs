using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Clase24
{
    public class Lapicera : Utiles, IInterface
    {
        protected string _color;
        protected string _trazo;

        protected override double Precio { get { return this._precio; } set { this._precio = value; } }
        protected override string Marca { get { return this._marca; } set { this._marca = value; } }

        public override string ToString()
        {
            return string.Format(base.utilesToString() + " Color: {0} Trazo: {1}\n", this._color, this._trazo);
        }

        public void SerializarXml(string path)
        {
            throw new NotImplementedException();
        }

        public void DeserializarXml(string path)
        {
            throw new NotImplementedException();
        }

        public Lapicera(double precio, string marca, string color, string trazo)
        {
            this.Marca = marca;
            this.Precio = precio;
            this._color = color;
            this._trazo = trazo;
        }
    }
}
