using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Entidades.Clase17
{
    public static class AdministradorArchivos
    {
        public static bool Escribir(string path, string cadena)
        {
            bool retorno = false;
            try
            {
                StreamWriter sw;
                using (sw = new StreamWriter(path, false))
                {
                    sw.Write(cadena);
                    retorno = true;
                }
            }
            catch (Exception c)
            {
            }
            return retorno;
        }

        public static bool Leer(string path, out string cadena)
        {
            bool retorno = false;
            cadena = "";
            try
            {
                StreamReader sr;
                using (sr = new StreamReader(path, false))
                {
                    cadena = sr.ReadToEnd();
                    retorno = true;
                }
            }
            catch (Exception)
            {
            }
            return retorno;
        }
    }
}
