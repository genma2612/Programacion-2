using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Entidades.Clase15_Parte3
{
    public class Deposito<T>
    {
        private int _capacidadMaxima;
        private List<T> _lista;

        public bool Guardar(string path)
        {
            bool retorno = false;
            try
            {
                StreamWriter sw;
                //StreamWriter sw = new StreamWriter(path, false); //true agrega màs info, false sobreescribe todo el contenido.
                using (sw = new StreamWriter(path, false))
                {
                    sw.Write(this.ToString());
                }
                //sw.Close(); // cerrado automaticamente por las llaves del using
                retorno = true;
            }
            catch (Exception)
            {
                throw;
            }
            return retorno;
        }

        public bool Recuperar(string path)
        {
            bool retorno = false;
            try
            {
                StreamReader sr;
                using (sr = new StreamReader(path, false))
                {
                    Console.WriteLine(sr.ReadToEnd());
                }
                retorno = true;
            }
            catch (Exception)
            {
                throw;
            }
            return retorno;
        }

        public bool Agregar(T a)
        {
            bool retorno = false;
            if (this + a)
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator +(Deposito<T> d, T a)
        {
            bool retorno = false;
            if (d._lista.Count < d._capacidadMaxima)
            {
                foreach (T item in d._lista)
                {
                    if (item.Equals(a))
                        return retorno;
                }
                d._lista.Add(a);
                retorno = true;
            }
            return retorno;
        }

        private int GetIndice(T a)
        {
            int retorno = -1;
            for (int i = 0; i < this._lista.Count; i++)
            {
                if (this._lista[i].Equals(a))
                {
                    retorno = i;
                    break;
                }
            }
            return retorno;
        }

        public bool Remover(T a)
        {
            bool retorno = false;
            if (this._lista.Count > 0)
            {
                if (this - a)
                {
                    retorno = true;
                }
            }
            return retorno;
        }

        public static bool operator -(Deposito<T> d, T a)
        {
            bool retorno = false;
            int index = d.GetIndice(a);
            if (index > -1)
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
            retorno.AppendFormat("Listado de {0}:\r\n", typeof(T).Name);
            foreach (T item in this._lista)
            {
                retorno.AppendLine(item.ToString());
            }
            return retorno.ToString();
        }

        public Deposito(int capacidad)
        {
            this._lista = new List<T>();
            this._capacidadMaxima = capacidad;
        }





    }
}
