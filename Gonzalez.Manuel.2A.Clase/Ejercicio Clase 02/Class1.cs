using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Sello
    {
        public static string mensaje;
        public static ConsoleColor color = ConsoleColor.Red;

        public static string Imprimir()
        {
            if (Sello.TryParse(Sello.mensaje, out string cadena))
            {
                cadena = ArmarMensajeConFormato();
            }
            else
                cadena = "El mensaje està vacio.";
            return cadena;
        }

        public static void Borrar()
        {
            Sello.mensaje = "";
        }

        public static void ImprimirEnColor()
        {
            Console.ForegroundColor = Sello.color;
            Console.WriteLine(Sello.Imprimir());
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        private static string ArmarMensajeConFormato()
        {
            int largo = Sello.mensaje.Length;
            string mensajeFormateado;
            string asteriscos = ""; //Inicializar la string que serà acumulada
            for (int i = 0; i < largo+2; i++)
            {
                asteriscos += "*";
            }
            mensajeFormateado = asteriscos + "\n*" + Sello.mensaje + "*\n" + asteriscos;
            return mensajeFormateado;
        }

        private static bool TryParse(string cadena, out string CadenaParsed)
        {
            bool retorno = false;
            CadenaParsed = "";
            if (cadena.Length > 0)
            {
                CadenaParsed = cadena;
                retorno = true;
            }
            return retorno;
        }
    }
}
