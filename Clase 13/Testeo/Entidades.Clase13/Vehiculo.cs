using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Clase13
{
    public class Vehiculo
    {
        protected string _patente;
        protected byte _ruedas;
        protected EMarcas _marca;

        public string Patente
        {
            get
            {
                return this._patente;
            }
                
        }

        public byte Ruedas
        {
            get { return this._ruedas; }
            set { this._ruedas = value; }
        }

        public EMarcas Marca
        {
            get
            {
                return this._marca;
            }
                
        }

        protected virtual string Mostrar()
        {
            StringBuilder retorno = new StringBuilder();
            retorno.AppendFormat(" PATENTE: {0} RUEDAS: {1} MARCA: {2} ", this.Patente, this.Ruedas, this.Marca);
            return retorno.ToString();
        }

        public override string ToString()
        {
            return this.Mostrar();
        }

        public static bool operator ==(Vehiculo v1, Vehiculo v2)
        {
            return (v1.Patente == v2.Patente && v1.Marca == v2.Marca);
        }

        public static bool operator !=(Vehiculo v1, Vehiculo v2)
        {
            return !(v1 == v2);
        }

        public Vehiculo(string patente, byte ruedas, EMarcas marca)
        {
            this._patente = patente;
            this._ruedas = ruedas;
            this._marca = marca;
        }

    }
}
