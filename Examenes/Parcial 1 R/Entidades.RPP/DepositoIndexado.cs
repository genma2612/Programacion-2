using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.RPP
{
    public class DepositoIndexado
    {
        private List<Producto> productos;

        public Producto this[int indice]
        {
            get
            {
                if (indice >= this.productos.Capacity || indice < 0)
                    return null;
                else
                    return this.productos[indice];
            }
            
            set
            {
                if (indice >= 0 && indice < this.productos.Capacity)
                    this.productos[indice] = value;
                /*
                else if (indice == this.productos.Capacity)
                {
                    //this.productos = this + indice;
                    this[indice] = value;
                }
                */
                else
                {
                    Console.WriteLine("No se puede asignar a este elemento");
                    Console.ReadLine();
                }
            }
            
        }

        public DepositoIndexado() : this(3)
        {
        }

        public DepositoIndexado(int espacio)
        {
            this.productos = new List<Producto>(espacio);
        }

    }
}
