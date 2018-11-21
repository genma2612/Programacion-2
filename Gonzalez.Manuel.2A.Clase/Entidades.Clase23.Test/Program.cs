using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Clase23;
using Entidades.Externa;
using Entidades.Externa.Sellada;

namespace Entidades.Clase23.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona P1 = new Persona("Juan", "Perez", 25, ESexo.Masculino);
            //Console.WriteLine(P1.Nombre + " " + P1.Apellido + " " + "EDAD:" + P1.Edad + " SEXO:" + P1.Sexo);
            Console.WriteLine(P1.ObtenerDatos()); // Mètodo para no reutilizar muchas veces lo anterior.
            // PersonaExterna P2 = new PersonaExterna("Laura", "Garcia", 20, Externa.ESexo.Femenino);
            PersonaHerencia P2 = new PersonaHerencia("Laura", "Garcia", 20, Externa.ESexo.Femenino);
            Console.WriteLine(P2.ObtenerDatos());
            PersonaExternaSellada P3 = new PersonaExternaSellada("Marcianito", "", 150, Externa.Sellada.ESexo.Indefinido);
            Console.WriteLine(P3.ObtenerDatos() + " Es nulo?: " + P3.EsNulo());
            PersonaExternaSellada P4 = null;
            Console.WriteLine("P4 es null?: " + P4.EsNulo());
            int n = 2222;
            Console.WriteLine("\nDigitos de " + n + ": " + n.CantidadDigitos());
            Console.WriteLine("Tiene " + n + " la misma cant. de digitos que 1111?: " + n.TieneLaMismaCantidad(1111));

            List<Persona> lista = P1.TraerDB();
            Console.WriteLine("\nPersonas en DB:");
            foreach (Persona item in lista)
            {
                Console.WriteLine(item.ObtenerDatos());
            }

            Persona P5 = new Persona("Manuel", "Gonzales", 25, ESexo.Masculino);
            P5.AgregarDB();
            Console.ReadLine();
            P5 = new Persona("Manuel", "Gonzalez", 25, ESexo.Masculino);
            P5.ModificarDB(16);
            Console.ReadLine();
            P5.QuitarDB(16);






            Console.ReadLine();
        }
    }
}
