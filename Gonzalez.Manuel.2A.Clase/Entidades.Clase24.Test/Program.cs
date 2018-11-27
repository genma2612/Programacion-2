using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Clase24;

namespace Entidades.Clase24.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Cartuchera<Utiles> cartuchera = 4;
            Lapicera L1 = new Lapicera(23.10, "Parker", "Negra", "Fino");
            Lapicera L2 = new Lapicera(3.10, "Bic", "Azul", "Fino");
            Lapicera L3 = new Lapicera(10.10, "Faber Castell", "Verde", "Grueso");
            Goma G1 = new Goma(3.10, "Faber Castell", true);
            Goma G2 = new Goma(0.69, "Maped", false);

            cartuchera.Add(L1);
            cartuchera.Add(L2);
            cartuchera.Add(L3);
            cartuchera.Add(G1);
            try
            {
                cartuchera.Add(G2);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            cartuchera.SerializarXml("");

            Console.Write(cartuchera.ToString());


            Console.ReadKey();
        }
    }
}
