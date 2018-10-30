using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Entidades.Clase17;

namespace Entidades.Clase17.test
{
    class Program
    {
        static void Main(string[] args)
        {
            //AdministradorArchivos.Escribir(@"C:\Users\alumno\Desktop\Escritorio.txt", "Escritorio"); //Clase Enviorenment para rutas predefinidas
            AdministradorArchivos.Escribir(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Escritorio.txt" , "Escritorio");
            if (AdministradorArchivos.Leer(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Escritorio.txt", out string e))
                Console.WriteLine(e);
            AdministradorArchivos.Escribir(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Documentos.txt", "Documentos");
            if (AdministradorArchivos.Leer(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Documentos.txt", out string d))
                Console.WriteLine(d);
            AdministradorArchivos.Escribir(Environment.GetFolderPath(Environment.SpecialFolder.MyPictures) + "\\Imagenes.txt", "Imagenes");
            if(AdministradorArchivos.Leer(Environment.GetFolderPath(Environment.SpecialFolder.MyPictures) + "\\Imagenes.txt", out string i))
                Console.WriteLine(i);
            AdministradorArchivos.Escribir(AppDomain.CurrentDomain.BaseDirectory + "\\Base.txt", "Base"); //Clase AppDomain ruta del .exe
            if (AdministradorArchivos.Leer(AppDomain.CurrentDomain.BaseDirectory + "\\Base.txt", out string b))
                Console.WriteLine(b);
            Console.ReadLine();
        }
    }
}
