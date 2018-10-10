using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 14";
            int opcion;
            bool flag;
            bool val;
            double input;
            double input2;
            double result;
            do
            {
                Console.WriteLine("1-Calcular area de un cuadrado.\n2-Calcular area de un triangulo.\n3-Calcular area de un circulo.\n4-Salir");
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Ingrese la longitud de los lados del cuadrado: ");
                        val = double.TryParse(Console.ReadLine(), out input);
                        if (val)
                        {
                            result = CalculoDeArea.CalcularCuadrado(input);
                            Console.WriteLine("El area de un cuadrado cuyos lados miden {0} es: {1:#,###.00}\nPresione enter para continuar...", input, result);
                        }
                        else
                            Console.WriteLine("El dato ingresado no es válido.\nPresione enter para continuar...");
                        Console.ReadLine();
                        break;
                    case 2:
                        flag = true;
                        Console.WriteLine("Ingrese la base del triangulo: ");
                        val = double.TryParse(Console.ReadLine(), out input);
                        if(val)
                        {
                            Console.WriteLine("Ingrese la altura del triangulo: ");
                            val = double.TryParse(Console.ReadLine(), out input2);
                            if(val)
                            {
                                flag = false;
                                result = CalculoDeArea.CalcularTriangulo(input, input2);
                                Console.WriteLine("El area de un triangulo cuya base y altura miden {0} y {1} respectivamente es: {2:#,###.00}\nPresione enter para continuar...", input, input2, result);
                            }
                        }                         
                        if(flag)
                            Console.WriteLine("El dato ingresado no es válido.\nPresione enter para continuar...");
                        Console.ReadLine();
                        break;
                    case 3:
                        Console.WriteLine("Ingrese el radio del circulo: ");
                        val = double.TryParse(Console.ReadLine(), out input);
                        if (val)
                        {
                            result = CalculoDeArea.CalcularCirculo(input);
                            Console.WriteLine("El area de un circulo cuyo radio mide {0} es: {1:#,###.00}\nPresione enter para continuar...", input, result);
                        }
                        else
                            Console.WriteLine("El dato ingresado no es válido.\nPresione enter para continuar...");
                        Console.ReadLine();
                        break;
                    default:
                        break;
                }
                Console.Clear();
            } while (opcion != 4);
        }
    }
}
