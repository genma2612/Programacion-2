using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Clase13;

namespace Testeo
{
    class Program
    {
        static void Main(string[] args)
        {
            Lavadero L = new Lavadero("Lavadero Avellaneda");

            Auto A1 = new Auto("BB1", EMarcas.Fiat, 4);
            Auto A2 = new Auto("ZZ2", EMarcas.Ford, 4);
            Auto A3 = new Auto("MM3", EMarcas.Fiat, 4);
            Camion C1 = new Camion("CC1", 6, EMarcas.Honda, 5000);
            Camion C2 = new Camion("VV1", 6, EMarcas.Iveco, 7000);
            Camion C3 = new Camion("HH1", 6, EMarcas.Scania, 4000);
            Moto M1 = new Moto(EMarcas.Zanella, 250, "LL1", 2);
            Moto M2 = new Moto(EMarcas.Honda, 150, "GG1", 2);
            Moto M3 = new Moto(EMarcas.Zanella, 350, "EE1", 2);
            Moto M4 = new Moto(EMarcas.Zanella, 250, "LL1", 2);

            L += A1;
            L += A2;
            L += A3;
            L += A1;
            L += C1;
            L += C2;
            L += C3;
            L += C1;
            L += M1;
            L += M2;
            L += M3;
            L += M4;


            Console.WriteLine(L.LavaderoToString);
            Console.WriteLine("Facturacion\nAuto: {0} Camion: {1} Moto: {2} TOTAL: {3}", 
                               L.MostrarTotalFacturado(EVehiculos.Auto), 
                               L.MostrarTotalFacturado(EVehiculos.Camion), 
                               L.MostrarTotalFacturado(EVehiculos.Moto), 
                               L.MostrarTotalFacturado());

            Console.WriteLine("<-----------PRESIONE UNA TECLA PARA CONTINUAR----------->");
            Console.ReadKey();
            Console.Clear();

            L -= A3;
            L -= C3;
            L -= M3;

            Console.WriteLine(L.LavaderoToString);
            Console.WriteLine("<-----------PRESIONE UNA TECLA PARA CONTINUAR----------->");
            Console.ReadKey();
            Console.Clear();

            L.Vehiculos.Sort(Lavadero.OrdenarVehiculosPorPatente);

            Console.WriteLine(L.LavaderoToString);
            Console.WriteLine("<-----------PRESIONE UNA TECLA PARA CONTINUAR----------->");
            Console.ReadKey();
            Console.Clear();

            L.Vehiculos.Sort(L.OrdenarVehiculosPorMarca);

            Console.WriteLine(L.LavaderoToString);
            Console.WriteLine("<-----------PRESIONE UNA TECLA PARA CONTINUAR----------->");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
