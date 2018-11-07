using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Xml;
using System.Xml.Serialization;

namespace Entidades.Clase19
{
    public delegate void MiDelegado();
    public delegate void MiDelegadoTV(Televisor t, TVEventsArgs e);

    public class Televisor
    {
        public int codigo;
        public string marca;
        public double precio;
        public int pulgadas;
        public string pais;
        // Atributo evento
        public event MiDelegado MiEvento;
        public event MiDelegadoTV MiEventoTV;

        // String con la direcciòn del servidor:
        //public static string conexion = Properties.Settings.Default.Conexión_Casa;
        public static string conexion = Properties.Settings.Default.conexión;



        public bool Insertar()
        {
            bool retorno = false;
            SqlConnection conexion = new SqlConnection(Televisor.conexion);
            SqlCommand comando = new SqlCommand();
            comando.CommandText = string.Format("INSERT INTO Televisores values ({0},'{1}',{2},{3},'{4}')", this.codigo, this.marca, this.precio, this.pulgadas, this.pais);
            comando.CommandType = System.Data.CommandType.Text;
            comando.Connection = conexion;
            try
            {
                conexion.Open();
                comando.ExecuteNonQuery();
                conexion.Close();
                this.MiEvento();
                TVEventsArgs e = new TVEventsArgs();
                e.Fecha = DateTime.Now;
                this.MiEventoTV(this, e);
                retorno = true;
            }
            catch (Exception)
            {
            }
            return retorno;
        }

        public static bool Modificar(Televisor t)
        {
            bool retorno = false;
            SqlConnection conexion = new SqlConnection(Televisor.conexion);
            SqlCommand comando = new SqlCommand();
            comando.CommandText = string.Format("UPDATE Televisores SET marca='{0}',precio={1},pulgadas={2},pais='{3}' WHERE codigo={4}", t.marca, t.precio, t.pulgadas, t.pais, t.codigo);
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

        public static bool Borrar(Televisor t)
        {
            bool retorno = false;
            SqlConnection conexion = new SqlConnection(Televisor.conexion);
            SqlCommand comando = new SqlCommand();
            comando.CommandText = string.Format("DELETE FROM Televisores WHERE codigo={0}", t.codigo);
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

        
        public static List<Televisor> TraerTodos()
        {
            List<Televisor> lista = new List<Televisor>();
            SqlConnection conexion = new SqlConnection(Televisor.conexion);
            SqlCommand comando = new SqlCommand();
            comando.CommandText = "SELECT * FROM Televisores";
            comando.CommandType = System.Data.CommandType.Text;
            comando.Connection = conexion;
            try
            {
                conexion.Open();
                SqlDataReader lector = comando.ExecuteReader();
                while (lector.Read())
                {
                    lista.Add(new Televisor(lector.GetInt32(0), lector.GetString(1), lector.GetDouble(2), lector.GetInt32(3), lector.GetString(4)));
                }
                conexion.Close();
            }
            catch (Exception)
            {
            }
            return lista;
        }

        public static Televisor TraerUno(int codigo)
        {
            Televisor retorno = null;
            SqlConnection conexion = new SqlConnection(Televisor.conexion);
            SqlCommand comando = new SqlCommand();
            comando.CommandText = string.Format("SELECT * FROM Televisores WHERE codigo={0}", codigo);
            comando.CommandType = System.Data.CommandType.Text;
            comando.Connection = conexion;
            try
            {
                conexion.Open();
                SqlDataReader lector = comando.ExecuteReader();
                //if(lector.HasRows)
                if(lector.Read())
                {
                    //lector.Read();
                    retorno = new Televisor(lector.GetInt32(0), lector.GetString(1), lector.GetDouble(2), lector.GetInt32(3), lector.GetString(4));
                }
                conexion.Close();
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
