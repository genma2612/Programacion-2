using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio17_Boligrafo
{
    class Boligrafo
    {
        public const short cantidadTintaMaxima = 100;
        private ConsoleColor _color;
        private short _tinta;


        public ConsoleColor GetColor()
        {
            return this._color;
        }

        public short GetTinta()
        {
            return this._tinta;
        }

        private void SetTinta(short tinta)
        {
            this._tinta += tinta;
            if (this.GetTinta() > 100)
                this._tinta = 100;
            if (this.GetTinta() < 0)
                this._tinta = 0;
        }

        public void Recargar()
        {
            this.SetTinta(100);
        }

        public bool Pintar(int gasto, out string dibujo)
        {
            dibujo = "";
            bool retorno = false;
            if(gasto > 0 && this.GetTinta() > 0)
            {
                retorno = true;
                if (gasto > this.GetTinta())
                    gasto = this.GetTinta();
                this.SetTinta((short)(gasto * -1));
                for (int i = gasto; i > 0; i--)
                {
                    dibujo += "*";
                }
                Console.ForegroundColor = this.GetColor();
                Console.WriteLine(dibujo);
                Console.ForegroundColor = ConsoleColor.Gray;
            }
            return retorno;
        }

        public Boligrafo() : this(ConsoleColor.Black, 0)
        {

        }

        public Boligrafo(ConsoleColor color, short cantidad)
        {
            this._color = color;
            this._tinta = cantidad;
        }

    }
}
