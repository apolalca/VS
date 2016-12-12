using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.SqlClient;
using WPFPersonas_DAL.Conexion;
using WPFPersonas_Ent;

namespace WPFPersonas_DAL.Listados
{
    public class clsListados_DAL
    {
        clsPersona miPersona;

        /// <summary>
        /// Funcion que devuelve una lista de personas que obtiene de una conexion a la base de datos
        /// </summary>
        /// <returns> lista </returns>
        
        public ObservableCollection<clsPersona> getListadoPersonasDAL()
        {
            ObservableCollection<clsPersona> lista = new ObservableCollection<clsPersona>();

            clsMyConnection miConexion = new clsMyConnection("iesnervion.database.windows.net", "WPFSample", "prueba", "iesnervion123.");
            SqlConnection conexion = new SqlConnection();
            SqlCommand miComando = new SqlCommand();
            SqlDataReader miLector;
            clsPersona oPersona;

            try
            {
                conexion = miConexion.getConnection();
                miComando.CommandText = "SELECT * FROM personas";
                miComando.Connection = conexion;
                miLector = miComando.ExecuteReader();

                if (miLector.HasRows)
                {
                    while (miLector.Read())
                    {
                        oPersona = new clsPersona();
                        oPersona.ID = (int)miLector["IDPersona"];
                        oPersona.Nombre = (string)miLector["nombre"];
                        oPersona.Apellidos = (string)miLector["apellidos"];
                        oPersona.FechaNac = (DateTime)miLector["fechaNac"];
                        oPersona.Direccion = (string)miLector["direccion"];
                        oPersona.Telefono = (string)miLector["telefono"];
                        lista.Add(oPersona);
                    } //Fin while

                    miLector.Close();

                } //Fin if
            } //Fin try
            catch (Exception)
            {
                throw;
            }
            finally
            {
                miConexion.closeConnection(ref conexion);
            }
            return lista;
        } //Fin List
    } //Fin class clsListados_DAL
}
