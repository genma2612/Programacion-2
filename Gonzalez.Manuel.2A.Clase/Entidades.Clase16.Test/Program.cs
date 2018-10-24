using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Clase16;

namespace Entidades.Clase16.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Avion avion = new Avion(500000, 1500);
            Comercial comercial = new Comercial(500000, 1500, 150);
            Privado privado = new Privado(700000, 2000, 20);

            Console.WriteLine(avion.Informacion);
            Console.WriteLine(comercial.Informacion);
            Console.WriteLine(privado.Informacion);
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("Impuesto avion: " + ((IAFIP)avion).CalcularImpuesto());
            Console.WriteLine("Impuesto avion: " + ((IARBA)avion).CalcularImpuesto());
            Console.WriteLine("Impuesto comercial: " + ((IAFIP)comercial).CalcularImpuesto());
            Console.WriteLine("Impuesto comercial: " + ((IARBA)comercial).CalcularImpuesto());
            Console.WriteLine("Impuesto comercial no casteado: " + comercial.CalcularImpuesto());
            Console.WriteLine("Impuesto privado: " + ((IAFIP)privado).CalcularImpuesto());
            Console.WriteLine("Impuesto privado: " + ((IARBA)privado).CalcularImpuesto());
            Console.WriteLine("----------------------------------------------------");
            //Console.ReadLine();

            Familiar F = new Familiar(60000, "III111", 4);
            Deportivo D = new Deportivo(120000, "AAA222", 600);

            Console.WriteLine(F.Informacion);
            Console.WriteLine(D.Informacion);
            Console.WriteLine("----------------------------------------------------");

            IAFIP I1;
            IARBA I2;
            I1 = comercial;
            I2 = comercial;
            
            Console.WriteLine("Metodo MostrarImpuestoNacional: " + Gestion.MostrarImpuestoNacional(I1));
            Console.WriteLine("Metodo MostrarImpuestoProvincial: " + Gestion.MostrarImpuestoProvincial(I2));
            Console.WriteLine("Precio Total comercial: {0}", comercial.Precio + Gestion.MostrarImpuestoNacional(I1) + Gestion.MostrarImpuestoProvincial(I2));
            Console.WriteLine("----------------------------------------------------");
            Console.ReadLine();

        }
    }
}
