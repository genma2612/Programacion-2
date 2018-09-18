using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Clase07
{
    public class Paleta
    {
        private Tempera[] _colores;
        private int _cantMaximaElementos;

        public int CantMaximaElementos
        {
            get
            {
                return this._cantMaximaElementos;
            }
        }

        private string Mostrar()
        {
            string retorno = "Cant. de espacios: " + this._cantMaximaElementos;
            for (int i = 0; i < this._cantMaximaElementos; i++)
            {
                if ( (object) this._colores[i] != null)
                {
                    retorno += " Colores:\r\n";
                    foreach (Tempera T in this._colores)
                    {
                        retorno += T;
                        retorno += "\r\n";
                    }
                    return retorno;
                }
            }
            return retorno;
        }

        private int ObtenerIndice()
        {
            int indice = -1;
            for (int i = 0; i < this._cantMaximaElementos; i++)
            {
                if (this._colores.GetValue(i) == null)
                {
                    indice = i;
                    break;
                }
            }
            return indice;
        }

        private int ObtenerIndice(Tempera Temp)
        {
            int indice = -1;
            for (int i = 0; i < this._cantMaximaElementos; i++)
            {
                if (this._colores[i] == Temp)
                {
                    indice = i;
                }
            }
            return indice;
        }

        public static explicit operator string(Paleta elemento)
        {
            return elemento.Mostrar();
        }

        public static implicit operator Paleta(int cant)
        {
            Paleta P = new Paleta(cant);
            return P;
            // return new Paleta(cant); tambien es valido
        }

        public static bool operator ==(Paleta PAL, Tempera TEMP)
        {
            bool retorno = false;
            for (int i = 0; i < PAL._cantMaximaElementos; i++)
            {
                if (PAL._colores.GetValue(i) != null)
                {
                    if (PAL._colores[i] == TEMP)
                    {
                        retorno = true;
                        break;
                    }
                }
            }
            return retorno;
        }

        public static bool operator !=(Paleta PAL, Tempera TEMP)
        {
            return !(PAL == TEMP);
        }

        public static Paleta operator +(Paleta PAL, Tempera TEMP)
        {
            int indice = PAL.ObtenerIndice(TEMP);
            if (indice > -1)
            {
                PAL._colores[indice] += TEMP;
            }
            else
            {
                indice = PAL.ObtenerIndice();
                if (indice > -1)
                {
                    PAL._colores[indice] = TEMP;
                }
            }
            return PAL;
        }

        public static Paleta operator -(Paleta PAL, Tempera TEMP)
        {
            int indice = PAL.ObtenerIndice(TEMP);
            if (indice > -1)
            {
                //sbyte aux = (sbyte)TEMP;
                //sbyte aux2 = (sbyte)PAL._colores[indice];
                //if (aux2 - aux < 1)
                if ((sbyte)PAL._colores[indice] - (sbyte)TEMP < 1)
                    PAL._colores[indice] = null;
                else
                    PAL._colores[indice] += (sbyte)((sbyte)TEMP * -1);
                //PAL._colores[indice] += ((sbyte) (aux * -1));
            }
            return PAL;
        }

        private Paleta() : this(5)
        {

        }

        private Paleta(int cantidad)
        {
            this._cantMaximaElementos = cantidad;
            this._colores = new Tempera[_cantMaximaElementos];
        }


        #region Indexador
        public Tempera this[int indice]
        {
            get
            {
                if (indice >= this._cantMaximaElementos || indice < 0)
                    return null;
                else
                    return this._colores[indice];
            }
            /*
            set
            {
                if (indice >= 0 && indice < this._cantMaximaElementos)
                    this._colores[indice] = value;
                else if (indice == this._cantMaximaElementos)
                {
                    this._colores = this + indice;
                    this[indice] = value;
                }
                else
                {
                    Console.WriteLine("No se puede asignar a este elemento");
                    Console.ReadLine();
                }
            }
            */
        }
        /*
        public static Tempera[] operator +(Paleta pal, int indice)
        {
            int i = indice >= pal._cantMaximaElementos ? ++indice : --indice;
            Tempera[] aux = new Tempera[i];
            pal._colores.CopyTo(aux, 0);
            return aux;
        }
        */
        #endregion

    }
}
