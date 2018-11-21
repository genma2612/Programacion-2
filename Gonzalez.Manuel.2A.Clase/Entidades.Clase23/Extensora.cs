using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Entidades.Clase23
{
    public static class Extensora
    {
        public static string ObtenerDatos(this Entidades.Externa.Sellada.PersonaExternaSellada persona)
        {
            return persona.Nombre + " " + persona.Apellido + " " + "EDAD:" + persona.Edad + " SEXO:" + persona.Sexo;
        }

        public static bool EsNulo(this object obj)
        {
            if (obj is null)
                return true;
            else
                return false;
        }

        public static Int32 CantidadDigitos(this Int32 n)
        {
            try
            {
                return (n.ToString()).Length;
            }
            catch (Exception)
            {
                return 0;
            }  
        }

        public static bool TieneLaMismaCantidad(this Int32 n1, Int32 n2)
        {
            return n1.CantidadDigitos() == n2.CantidadDigitos();
        }

        public static List<Persona> TraerDB(this Persona persona)
        {
            SqlConnection conexion = new SqlConnection(Properties.Settings.Default.conexion);
            SqlCommand comando = new SqlCommand();
            comando.CommandText = "SELECT * FROM Personas";
            comando.CommandType = System.Data.CommandType.Text;
            comando.Connection = conexion;
            conexion.Open();
            SqlDataReader lector = comando.ExecuteReader();
            List<Persona> lista = new List<Persona>();
            while (lector.Read())
            {
                lista.Add(new Persona(lector.GetString(1), lector.GetString(2), lector.GetInt32(3),(ESexo)lector.GetInt32(4)));
                // No agrego Get...(0) porque no hay campo ID en Persona.
            }
            conexion.Close();
            return lista;
        }

        public static bool AgregarDB(this Persona persona)
        {
            bool retorno = false;
            SqlConnection conexion = new SqlConnection(Properties.Settings.Default.conexion);
            SqlCommand comando = new SqlCommand();
            comando.CommandText = string.Format("INSERT INTO Personas (nombre,apellido,edad,sexo) values ('{0}','{1}',{2},{3})", persona.Nombre, persona.Apellido, persona.Edad,((int)persona.Sexo));
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

        public static bool QuitarDB(this Persona persona, int id)
        {
            bool retorno = false;
            SqlConnection conexion = new SqlConnection(Properties.Settings.Default.conexion);
            SqlCommand comando = new SqlCommand();
            //comando.CommandText = string.Format("DELETE FROM Personas WHERE id={0}", id);
            comando.CommandText = string.Format("DELETE FROM Personas WHERE nombre='Manuel'");
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

        public static bool ModificarDB(this Persona persona, int id)
        {
            bool retorno = false;
            SqlConnection conexion = new SqlConnection(Properties.Settings.Default.conexion);
            SqlCommand comando = new SqlCommand();
            //comando.CommandText = string.Format("UPDATE Personas SET nombre='{0}',apellido={1},edad={2},sexo='{3}' WHERE id={4};", persona.Nombre, persona.Apellido, persona.Edad, ((int)persona.Sexo), id);
            comando.CommandText = string.Format("UPDATE Personas SET nombre='{0}',apellido={1},edad={2},sexo='{3}' WHERE nombre='Manuel';", persona.Nombre, persona.Apellido, persona.Edad, ((int)persona.Sexo), id);

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
    }
}
