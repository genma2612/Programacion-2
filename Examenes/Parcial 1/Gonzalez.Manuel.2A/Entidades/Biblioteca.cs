using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Biblioteca
    {
        private int _capacidad;
        private List<Libro> _libros;

        public double PrecioDeManuales
        {
            get
            {
                return ObtenerPrecio(ELibro.Manual);
            }
                
        }

        public double PrecioDeNovelas
        {
            get
            {
                return ObtenerPrecio(ELibro.Novela);
            }

        }

        public double PrecioTotal
        {
            get
            {
                return ObtenerPrecio(ELibro.Ambos);
            }

        }

        public static string Mostrar(Biblioteca e)
        {
            StringBuilder retorno = new StringBuilder();
            retorno.AppendFormat("Capacidad de la biblioteca: {0}\n", e._capacidad);
            retorno.AppendFormat("Total por Manuales: ${0:0.##}\n", e.PrecioDeManuales);
            retorno.AppendFormat("Total por Novelas: ${0:0.##}\n", e.PrecioDeNovelas);
            retorno.AppendFormat("Total: ${0:0.##}\n", e.PrecioTotal);
            retorno.AppendLine("**************************************************");
            retorno.AppendLine("Listado de Libros");
            retorno.AppendLine("**************************************************");
            foreach (Libro item in e._libros)
            {
                if (item is Manual)
                    retorno.AppendLine(((Manual)item).Mostrar());
                if (item is Novela)
                    retorno.AppendLine(((Novela)item).Mostrar());
            }
            return retorno.ToString();
        }

        public static implicit operator Biblioteca(int capacidad)
        {
            return new Biblioteca(capacidad);
        }

        public static bool operator ==(Biblioteca e, Libro l)
        {
            bool retorno = false;
            foreach (Libro item in e._libros)
            {
                if(item == l)
                {
                    retorno = true;
                    break;
                }
            }
            return retorno;
        }

        public static bool operator !=(Biblioteca e, Libro l)
        {
            return !(e == l);
        }

        public static Biblioteca operator +(Biblioteca e, Libro l)
        {
            if(e._libros.Count < e._capacidad)
            {
                foreach (Libro item in e._libros)
                {
                    if (l is Manual && item is Manual)
                    {
                        if((Manual) item == (Manual) l)
                        {
                            Console.WriteLine("El libro ya está en la bibliteca!!!");
                            return e;
                        }
                    }
                    if (l is Novela && item is Novela)
                    {
                        if ((Novela) item == (Novela)l)
                        {
                            Console.WriteLine("El libro ya está en la bibliteca!!!");
                            return e;
                        }
                    }              
                }
                e._libros.Add(l);
            }
            else
            {
                Console.WriteLine("No hay más lugar en la bibliteca!!!");
            }
            return e;
        }

        private double ObtenerPrecio(ELibro tipo)
        {
            double retorno = 0;
            double sumaManuales = 0;
            double sumaNovelas = 0;
            foreach (Libro item in this._libros)
            {
                if (item is Manual)
                    sumaManuales += (Manual)item;
                if (item is Novela)
                    sumaNovelas += (Novela)item;
            }
            switch (tipo)
            {
                case ELibro.Manual:
                    retorno = sumaManuales;
                    break;
                case ELibro.Novela:
                    retorno =  sumaNovelas;
                    break;
                case ELibro.Ambos:
                    retorno = sumaManuales + sumaNovelas;
                    break;
                default:
                    break;
            }
            return retorno;
        }


        private Biblioteca()
        {
            _libros = new List<Libro>();
        }

        private Biblioteca(int capacidad) : this()
        {
            this._capacidad = capacidad;
        }
    }
}
