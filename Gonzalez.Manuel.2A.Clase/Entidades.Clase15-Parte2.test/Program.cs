﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Clase15_Parte2;

namespace Entidades.Clase15_Parte2.test
{
    class Program
    {
        static void Main(string[] args)
        {
            Cocina c1 = new Cocina(111, 12300, false);
            Cocina c2 = new Cocina(112, 15000, true);
            Cocina c3 = new Cocina(113, 5600, false);
            DepositoDeCocinas dc = new DepositoDeCocinas(5);
            dc.Agregar(c1);
            dc.Agregar(c2);
            if (!(dc + c3))
            {
                Console.WriteLine("No se pudo agregar el item!!!");
            }
            Console.WriteLine(dc);
            dc.Remover(c2);
            if (!(dc - c2))
            {
                Console.WriteLine("No se pudo remover el item!!!");
            }
            Console.WriteLine(dc);
            if(dc.Guardar(@"D:\Cocina.txt")); // agrego \\ para escapar en cada contrabarra o @ antes de la cadena (ignora secuencias de escape)
            Console.WriteLine("Se pudo guardar.\n");
            Console.ReadLine();
            dc.Recuperar(@"D:\Cocina.txt");
            Console.ReadLine();
        }
    }
}
