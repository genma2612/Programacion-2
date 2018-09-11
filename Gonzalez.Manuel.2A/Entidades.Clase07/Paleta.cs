using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Clase07
{
    class Paleta
    {
        private Tempera[] _colores;
        private int _cantMaximaElementos;

        private string Mostrar()
        {
            string retorno = "Cant. de colores: " + this._cantMaximaElementos;
            if( (object) this._colores[0] != null )
            {
                retorno += " Colores:\n";
                foreach (Tempera T in this._colores)
                {
                    retorno += T + "\n";
                }
                return retorno;
            }
            return retorno;
        }

        private int ObtenerIndice()
        {
            int indice=-1;
            for (int i = 0; i <this._cantMaximaElementos; i++)
            {
                if (this._colores.GetValue(i) != null)
                {
                    indice = i;
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
                if(PAL._colores.GetValue(i) != null)
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
                if(indice > -1)
                {
                    PAL._colores[indice] = TEMP;
                }
            }
            return PAL;
        }

        private Paleta() :this(5)
        {
        }

        private Paleta(int cantidad)
        {
            this._cantMaximaElementos = cantidad;
            this._colores = new Tempera[_cantMaximaElementos];
        }

    }
}
