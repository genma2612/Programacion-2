using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio16
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno A1 = new Alumno();
            Alumno A2 = new Alumno();
            Alumno A3 = new Alumno();

            A1.nombre = "Josue";
            A1.apellido = "Perez";
            A1.legajo = 166;
            A1.Estudiar(3, 4);
            A2.nombre = "Pedro";
            A2.apellido = "Lopez";
            A2.legajo = 154;
            A2.Estudiar(5, 4);
            A3.nombre = "Juan";
            A3.apellido = "Garcia";
            A3.legajo = 123;
            A3.Estudiar(9, 8);

            A1.Mostrar();
            A2.Mostrar();
            A3.Mostrar();

            Console.ReadLine();



        }
    }
}
