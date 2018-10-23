using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Entidades.Clase15_Parte2
{
    public class DepositoDeCocinas
    {
        private int _capacidadMaxima;
        private List<Cocina> _lista;

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

        public bool Agregar(Cocina a)
        {
            bool retorno = false;
            if (this + a)
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator +(DepositoDeCocinas d, Cocina a)
        {
            bool retorno = false;
            if (d._lista.Count < d._capacidadMaxima)
            {
                foreach (Cocina item in d._lista)
                {
                    if (item.Equals(a))
                        return retorno;
                }
                d._lista.Add(a);
                retorno = true;
            }
            return retorno;
        }

        private int GetIndice(Cocina a)
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

        public bool Remover(Cocina a)
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

        public static bool operator -(DepositoDeCocinas d, Cocina a)
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
            retorno.AppendFormat("Capacidad màxima: {0}\r\n", this._capacidadMaxima);
            retorno.AppendLine("Listado de Cocinas:");
            foreach (Cocina item in this._lista)
            {
                retorno.AppendLine(item.ToString());
            }
            return retorno.ToString();
        }

        public DepositoDeCocinas(int capacidad)
        {
            this._lista = new List<Cocina>();
            this._capacidadMaxima = capacidad;
        }



    }
}
