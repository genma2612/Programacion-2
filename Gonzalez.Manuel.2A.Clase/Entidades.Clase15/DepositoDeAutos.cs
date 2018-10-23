using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Clase15
{
    public class DepositoDeAutos
    {
        private int _capacidadMaxima;
        private List<Auto> _lista;

        public bool Agregar(Auto a)
        {
            bool retorno = false;
            if(this + a)
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator +(DepositoDeAutos d, Auto a)
        {
            bool retorno = false;
            if(d._lista.Count < d._capacidadMaxima)
            {
                foreach (Auto item in d._lista)
                {
                    if (item.Equals(a))
                        return retorno;
                }
                d._lista.Add(a);
                retorno = true;
            }
            return retorno;
        }

        private int GetIndice(Auto a)
        {
            int retorno = -1;
            for (int i = 0; i < this._lista.Count; i++)
            {
                if(this._lista[i].Equals(a))
                {
                    retorno = i;
                    break;
                }
            }
            return retorno;
        }

        public bool Remover(Auto a)
        {
            bool retorno = false;
            if(this._lista.Count > 0)
            {
                if(this - a)
                {
                    retorno = true;
                }
            }
            return retorno;
        }

        public static bool operator -(DepositoDeAutos d, Auto a)
        {
            bool retorno = false;
            int index = d.GetIndice(a);
            if(index > -1)
            {
                d._lista.RemoveAt(index);
                retorno = true;
            }
            return retorno;
        }

        public override string ToString()
        {
            StringBuilder retorno = new StringBuilder();
            retorno.AppendFormat("Capacidad màxima: {0}\n", this._capacidadMaxima);
            retorno.AppendLine("Listado de Autos:");
            foreach (Auto item in this._lista)
            {
                retorno.AppendLine(item.ToString());
            }
            return retorno.ToString();
        }

        public DepositoDeAutos(int capacidad)
        {
            this._lista = new List<Auto>();
            this._capacidadMaxima = capacidad;
        }
    }
}
