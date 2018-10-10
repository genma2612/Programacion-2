using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Clase07
{
    public class PaletaColeccion
    {
        private List<Tempera> _colores = new List<Tempera>();
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
            string retorno = "Cant. de espacios: " + this._cantMaximaElementos + " -- Colores:\r\n";
            int cant = this._colores.Count;
            for (int i = 0; i < cant; i++)
            {
                retorno += this._colores[i] + "\r\n";
            }
            return retorno;
        }

        public static explicit operator string(PaletaColeccion elemento)
        {
            return elemento.Mostrar();
        }

        public static implicit operator PaletaColeccion(int cant)
        {
            PaletaColeccion P = new PaletaColeccion(cant);
            return P;
        }

        public static bool operator ==(PaletaColeccion PAL, Tempera TEMP)
        {
            bool retorno = false;
            for (int i = 0; i < PAL._cantMaximaElementos; i++)
            {
                if (PAL._colores[i] != null)
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

        public static bool operator !=(PaletaColeccion PAL, Tempera TEMP)
        {
            return !(PAL == TEMP);
        }

        public static int operator ==(Tempera TEMP, PaletaColeccion PAL)
        {
            int retorno = -1;
            for (int i = 0; i < PAL._colores.Count; i++)
            {
                //if (PAL._colores[i] != null)
                //{
                    if (PAL._colores[i] == TEMP)
                    {
                        retorno = i;
                        break;
                    }
                //}
            }
            return retorno;
        }

        public static int operator !=(Tempera TEMP, PaletaColeccion PAL)
        {
            return TEMP == PAL;
        }

        public static PaletaColeccion operator +(PaletaColeccion PAL, Tempera TEMP)
        {
            int indice = TEMP == PAL;
            if (indice > -1)
            {
                PAL._colores[indice] += TEMP;
            }
            else
            {
                if (PAL._colores.Count < PAL._cantMaximaElementos)
                {
                    PAL._colores.Add(TEMP);
                }
            }
            return PAL;
        }

        public static PaletaColeccion operator -(PaletaColeccion PAL, Tempera TEMP)
        {
            int indice = TEMP == PAL;
            if (indice > -1)
            {
                if ((sbyte)PAL._colores[indice] - (sbyte)TEMP < 1)
                    PAL._colores.RemoveAt(indice);
                else
                    PAL._colores[indice] += (sbyte)((sbyte)TEMP * -1);
            }
            return PAL;
        }

        private PaletaColeccion() : this(5)
        {

        }

        private PaletaColeccion(int cantidad)
        {
            this._cantMaximaElementos = cantidad;
            //this._colores = new Tempera[_cantMaximaElementos];
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
        }
        #endregion

    }
}
