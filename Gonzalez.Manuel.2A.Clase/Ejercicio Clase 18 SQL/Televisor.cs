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
    public class Televisor
    {
        public int codigo;
        public string marca;
        public double precio;
        public int pulgadas;
        public string pais;



        public bool Insertar()
        {
            bool retorno = false;
            SqlConnection conexion = new SqlConnection(Properties.Settings.Default.Conexión_Casa);
            //SqlConnection conexion = new SqlConnection(Properties.Settings.Default.Conexiòn);
            SqlCommand comando = new SqlCommand();
            comando.CommandText = string.Format("INSERT INTO Televisores values ({0},'{1}',{2},{3},'{4}')", this.codigo, this.marca, this.precio, this.pulgadas, this.pais);
            /*comando.CommandText = "INSERT INTO Televisores (codigo,marca,precio,pulgadas,pais) " +
                "values (" + this.codigo + "," + this.marca + "," + this.precio + "," + this.pulgadas + 
                "," + this.pais + ")"; //si dejo vacio los campos, por defecto toma todos los valores.*/
            comando.CommandType = System.Data.CommandType.Text;
            comando.Connection = conexion;
            try
            {
                conexion.Open();
                comando.ExecuteNonQuery();
                conexion.Close();
                retorno = true;
            }
            catch (Exception)
            {
            }
            return retorno;
        }


        public Televisor()
        {

        }

        public Televisor(int codigo, string marca, double precio, int pulgadas, string pais)
        {
            this.codigo = codigo;
            this.marca = marca;
            this.precio = precio;
            this.pulgadas = pulgadas;
            this.pais = pais;
        }
    }
}
