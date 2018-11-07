using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Clase19;

namespace Entidades.Clase19.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Televisor T1 = new Televisor(130, "Sony", 10000, 42, "China");
            Program P = new Program(); // Genero un obj Program para acceder al método estático.
            T1.MiEvento += new MiDelegado(PruebaEvento); // Agrego el método a la lista de métodos del Delegate.
            T1.MiEvento += new MiDelegado(P.PruebaEventoInstancia); // Agrego el método de instancia a la lista de métodos.
            T1.MiEventoTV += new MiDelegadoTV(PruebaEventoConParametro);

            //
            //T1.MiEvento += new MiDelegado(PruebaEvento); // Agrego el método a la lista de métodos del Delegate.
            //T1.MiEvento += new MiDelegado(P.PruebaEventoInstancia); // Agrego el método de instancia a la lista de métodos.
            //T1.MiEventoTV += new MiDelegadoTV(PruebaEventoConParametro);
            ////
            //T1.MiEvento += new MiDelegado(PruebaEvento); // Agrego el método a la lista de métodos del Delegate.
            //T1.MiEvento += new MiDelegado(P.PruebaEventoInstancia); // Agrego el método de instancia a la lista de métodos.
            //T1.MiEventoTV += new MiDelegadoTV(PruebaEventoConParametro);

            T1.Insertar();





            Console.ReadKey();
            Televisor.Borrar(T1);
        }

        public static void PruebaEvento()
        {
            Console.WriteLine("Se insertó un registro en la base de datos");
        }

        public void PruebaEventoInstancia()
        {
            Console.WriteLine("Mensaje desde el 2do método delegado, de instancia.");
        }

        public static void PruebaEventoConParametro(Televisor t, TVEventsArgs e)
        {
            string guiones = "------------------------------------------------------------";
            Console.WriteLine(guiones);
            Console.WriteLine("{0} | {1} | {2} | {3} | {4} a las {5}", t.codigo, t.marca, t.precio, t.pulgadas, t.pais, e.Fecha);
            Console.WriteLine(guiones);
        }
    }
}
