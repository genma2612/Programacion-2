using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Xml;
using System.Xml.Serialization;

namespace Ejercicio_Clase_18_SQL
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Primero se debe establecer una conexiòn con la base de datos.
             * Click derecho en el proyecto->Propiedades->Configuraciòn->Preparar configuraciòn.
             * Agregar un tipo (cadena de conexciòn) y en Valor, agrego Microsoft SQL Server, el nombre del servidor
             * EJ: LAB5PC09\SQLEXPRESS y la base de datos, en este caso, Productos.
             * Luego, generar una conexiòn entre la aplicaciòn y la base de datos con un using a System.Data.SqlClient.
             * (Si se cambia el cliente de la base de datos, debe cambiarse system.Data.clienteDeBaseDeDatos, ejemplo, Oracle)
             * Objeto SqlConnection depende del proveedor de datos. En este caso, la base de datos de tipo SQL server. 
             */
           
            SqlConnection conexiòn = new SqlConnection(Properties.Settings.Default.Conexiòn); //la cadena de conexiòn creada en configuraciòn.
            // Configuraciones.
            SqlCommand comando = new SqlCommand(); //Permite trabajar con la base de datos.
            comando.CommandText = "SELECT * FROM Televisores"; //Segùn commandType.
            comando.CommandType = System.Data.CommandType.Text; // Que espera recibir CommandText
            comando.Connection = conexiòn; // 

            conexiòn.Open(); //Abre la conexiòn entre la aplicaciòn y la base de datos. Sòlo se encarga de eso.
                             //Es conveniente hacerlo a lo ùltimo. Lo màs tarde posible y que se cierre lo màs pronto posible.

            SqlDataReader lector = comando.ExecuteReader(); // SqlDataReader tiene sus constructores privados.
                                                            // obj de sòlo lectura y sòlo avance.
            List<Televisor> lista = new List<Televisor>();
            while (lector.Read())
            {
                Console.WriteLine(lector["codigo"] + " - " + lector[1] + " - " + lector[2] + " - " + lector[3] + " - " + lector[4]);
                lista.Add(new Televisor((int)lector[0], (string)lector[1], (double) lector[2], (int)lector[3], (string)lector[4]));
                //lista.Add(new Televisor(lector.GetInt32(0), lector.GetString(1), lector.GetDouble(2), lector.GetInt32(3), lector.GetString(4)));
            }
            conexiòn.Close(); //Cierra la conexiòn entre la aplicaciòn y la base de datos.

            // Serializacion XML

            XmlSerializer serializer = new XmlSerializer(typeof(Televisor));
            XmlTextWriter writer = new XmlTextWriter("Televisores.xml", Encoding.UTF8);
            serializer.Serialize(writer, lista);
            writer.Close();


            XmlTextReader reader = new XmlTextReader("Televisores.xml");
            reader.Close();

            List<Televisor> L = (List<Televisor>) serializer.Deserialize(reader);


            conexiòn.Open();
            DataTable tabla = new DataTable("Televisores");
            tabla.Load(lector);
            conexiòn.Close();
            tabla.WriteXmlSchema("Televisores_Esquema.xml");
            tabla.WriteXml("Televisores_DT.xml");

            DataTable tabla2 = new DataTable();
            tabla2.Load(lector);
            tabla2.ReadXmlSchema("Televisores_Esquema.xml");
            tabla2.ReadXml("Televisores_Esquema.xml");



            Console.ReadKey();
        }
    }
}
