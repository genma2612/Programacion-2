﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Sello
    {
        public static string mensaje;
        public static ConsoleColor color = ConsoleColor.Red;
        public static string Imprimir()
        {
            return Sello.mensaje;
        }
        public static void Borrar()
        {
            Sello.mensaje = "...";
        }
        public static void ImprimirEnColor()
        {
            Console.ForegroundColor = Sello.color;
            Console.WriteLine(Sello.Imprimir());
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
