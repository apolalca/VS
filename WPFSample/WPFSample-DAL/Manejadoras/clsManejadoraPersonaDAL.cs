using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFSample;
using WPFSample_Ent;

namespace WPFSample_DAL.Manejadoras
{
    public class clsManejadoraPersonaDAL
    {
        private clsMyConnection miConexion;

        public clsMyConnection conectar()
        {
            return this.miConexion = new clsMyConnection("iesnervion.database.windows.net", "WPFSample", "prueba", "iesnervion123.");
        }


        public int insertarPersonaDAL(clsPersona persona)
        {
            int resultado = 0;

            SqlConnection conexion = new SqlConnection();
            SqlCommand miComando = new SqlCommand();


            miComando.Parameters.Add("@nombre", System.Data.SqlDbType.VarChar).Value = persona.Nombre;
            miComando.Parameters.Add("@apellidos", System.Data.SqlDbType.VarChar).Value = persona.Apellidos;
            miComando.Parameters.Add("@fechaNac", System.Data.SqlDbType.Date).Value = persona.FechaNac;
            miComando.Parameters.Add("@direccion", System.Data.SqlDbType.VarChar).Value = persona.Direccion;
            miComando.Parameters.Add("@telefono", System.Data.SqlDbType.VarChar).Value = persona.Telefono;

            try
            {
                conectar();
                conexion = miConexion.getConnection();
                miComando.CommandText = "INSERT INTO personas(nombre, apellidos, fechaNac, direccion, telefono) VALUES (@nombre, @apellidos, @fechanac, @direccion, @telefono)";
                miComando.Connection = conexion;
                resultado = miComando.ExecuteNonQuery();
                return resultado;
            } catch (Exception e)
            {
                throw e;
            } finally
            {
                conexion.Close();
                miConexion.closeConnection(ref conexion);
            }
        }

        public int borrarPersonaDAL(int id)
        {
            int resultado = 0;
            SqlConnection conexion = new SqlConnection();
            SqlCommand miComando = new SqlCommand();

            miComando.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = id;


            try
            {
                conectar();
                conexion = miConexion.getConnection();
                miComando.CommandText = "DELETE FROM personas WHERE IDPersona = @id";
                miComando.Connection = conexion;
                // TODO
                resultado = miComando.ExecuteNonQuery();
            } catch(Exception) {
                throw;
            } finally
            {
                conexion.Close();
                miConexion.closeConnection(ref conexion);
            }

            return resultado;
        }

        public clsPersona getPersona(int id)
        {
            clsPersona person = new clsPersona();
            SqlDataReader reader;

            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();

            comando.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = id;

            try
            {
                conectar();
                conexion = miConexion.getConnection();
                comando.CommandText = "SELECT * FROM personas WHERE IDPersona = @id";
                comando.Connection = conexion;
                reader = comando.ExecuteReader();

                reader.Read();
                person.Nombre = (String)reader["nombre"];
                person.Apellidos = (String)reader["apellidos"];
                person.FechaNac = (DateTime)reader["fechaNac"];
                person.Direccion = (String)reader["direccion"];
                person.Telefono = (String)reader["telefono"];


            } catch (Exception)
            {
                throw;
            } finally
            {
                conexion.Close();
                miConexion.closeConnection(ref conexion);
            }

            return person;
        }
        
        public int actualizarPersona(clsPersona persona)
        {
            int resultado = 0;

            SqlConnection conexion = new SqlConnection();
            SqlCommand miComando = new SqlCommand();

            miComando.Parameters.Add("@id", System.Data.SqlDbType.VarChar).Value = persona.ID;
            miComando.Parameters.Add("@nombre", System.Data.SqlDbType.VarChar).Value = persona.Nombre;
            miComando.Parameters.Add("@apellidos", System.Data.SqlDbType.VarChar).Value = persona.Apellidos;
            miComando.Parameters.Add("@fechaNac", System.Data.SqlDbType.Date).Value = persona.FechaNac;
            miComando.Parameters.Add("@direccion", System.Data.SqlDbType.VarChar).Value = persona.Direccion;
            miComando.Parameters.Add("@telefono", System.Data.SqlDbType.VarChar).Value = persona.Telefono;

            try
            {
                conectar();
                conexion = miConexion.getConnection();
                miComando.CommandText = "UPDATE personas set nombre=@nombre, apellidos=@apellidos, fechaNac=@fechaNac,direccion=@direccion, telefono=@telefono WHERE IDPersona=@id" ;
                miComando.Connection = conexion;
                resultado = miComando.ExecuteNonQuery();
            } catch (Exception)
            {
                throw;
            } finally
            {
                conexion.Close();
                miConexion.closeConnection(ref conexion);
            }

            return resultado;
        }
    }
}
