using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio16
{
    class Alumno
    {
        private byte _nota1;
        private byte _nota2;
        private float _notaFinal;
        public string apellido;
        public string nombre;
        public int legajo;

        public void Estudiar(byte nota1, byte nota2)
        {
            this._nota1 = nota1;
            this._nota2 = nota2;
            this.calcularFinal();
        }

        public void calcularFinal()
        {
            Random N = new Random();
            if (this._nota1 > 3 && this._nota2 > 3)
            {
                this._notaFinal = N.Next(1, 10);
            }
            else
                this._notaFinal = -1;
        }

        public void Mostrar()
        {
            Console.Write("Nombre: {0} {1} NOTA 1: {2} NOTA 2: {3} NOTA FINAL: ",
                                  this.nombre, this.apellido, this._nota1, this._nota2);
            if (this._notaFinal > 0)
            {
                Console.Write("{0}\n", this._notaFinal);
            }
            else
                Console.Write("Alumno Desaprobado\n");
                
        }

    }
}
