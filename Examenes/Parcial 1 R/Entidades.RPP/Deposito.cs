using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.RPP
{
    public class Deposito
    {
        public Producto[] productos;

        public static Producto[] operator +(Deposito d1, Deposito d2)
        {
            Producto[] retorno = new Producto[d1.productos.Length + d2.productos.Length];
            retorno = d1.productos;
            for (int i = 0; i < retorno.Length; i++)
            {
                foreach (Producto item in d2.productos)
                {
                    if (retorno[i] == item)
                    {
                        retorno[i] += item;
                    }
                    else
                        retorno[i] = item;
                }
            }
            return retorno;
        }

        public Deposito() : this(3)
        {
        }

        public Deposito(int espacio)
        {
            this.productos = new Producto[espacio];
        }
    }
}
