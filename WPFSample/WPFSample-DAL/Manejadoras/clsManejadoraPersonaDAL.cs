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

        public clsMyConnection miconexion()
        {
            return this.miConexion = new clsMyConnection();
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
               conexion = miConexion.getConnection();
                miComando.CommandText = "INSERT INTO personas(nombre, apellidos, fechaNac, direccion, telefono) VALUES (@nombre, @apellidos, @fechanac, @direcion, @telefono)";
                miComando.Connection = conexion;
                resultado = miComando.ExecuteNonQuery();
                return resultado;
            } catch (Exception)
            {
                return resultado;
            }
        }

        public int borrarPersonaDAL(clsPersona persona)
        {
            SqlConnection conexion = new SqlConnection();
            return 0;
        }
    }
}
