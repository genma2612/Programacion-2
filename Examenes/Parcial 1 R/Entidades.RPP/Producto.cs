using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.RPP
{
    public class Producto
    {
        public string nombre;
        public int stock;

        public static bool operator ==(Producto p1, Producto p2)
        {
            bool retorno = false;
            if (p1.nombre == p2.nombre)
                retorno = true;
            return retorno;
        }

        public static bool operator !=(Producto p1, Producto p2)
        {
            return !(p1 == p2);
        }

        public static Producto operator +(Producto p1, Producto p2)
        {
            if (p1 == p2)
                p1.stock += p2.stock;
            return p1;
        }

        public Producto(string nombre, int stock)
        {
            this.nombre = nombre;
            this.stock = stock;
        }
    }
}
