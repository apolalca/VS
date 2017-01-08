using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Web.Http;

namespace UWP_Personas.Model
{
    class PersonaManager
    {
        Conexion con;

        public PersonaManager()
        {
            con = new Conexion();
        }

        /// <summary>
        /// Crea una persona.
        /// </summary>
        /// <param name="persona"></param>
        /// <returns>
        /// <see cref="HttpStatusCode.Created"/> si se ha creado el recurso con exito.
        /// <see cref="HttpStatusCode.BadRequest"/> si ha ocurrido cualquier problema.
        /// </returns>
        public async Task<HttpStatusCode> postPersona(Persona persona)
        {
            HttpClient httpClient = new HttpClient();
            HttpStatusCode status = new HttpStatusCode();

            try
            {
                string serializablePersona = JsonConvert.SerializeObject(persona);

                IHttpContent content = new HttpStringContent(serializablePersona, 
                    Windows.Storage.Streams.UnicodeEncoding.Utf8, "application/json");
                await httpClient.PostAsync(con.uri, content);
                status = HttpStatusCode.Created;
                httpClient.Dispose();
            } catch (Exception) {
                status = HttpStatusCode.BadRequest;
            }

            return status;
        }

        /// <summary>
        /// Actualiza a una persona.
        /// </summary>
        /// <returns>
        /// <see cref="HttpStatusCode.Accepted"/> si se ha podido introducir la persona.
        /// <see cref="HttpStatusCode.BadRequest"/> si ha ocurrido algun error de cualquier tipo.
        /// </returns>
        public async Task<HttpStatusCode> putPersona(Persona p)
        {
            HttpStatusCode status = new HttpStatusCode();
            HttpClient httpClient = new HttpClient();

            try
            {
                string serializablePersona = JsonConvert.SerializeObject(p);
                IHttpContent content = new HttpStringContent(serializablePersona,
                    Windows.Storage.Streams.UnicodeEncoding.Utf8, "application/json");
                await httpClient.PutAsync(con.uri, content);
                httpClient.Dispose();
                status = HttpStatusCode.Accepted;

            } catch (Exception)
            {
                status = HttpStatusCode.BadRequest;
            }

            return status;
        }

        /// <summary>
        /// Busca en la base de datos la persona pasado por la id, de no encontrarla delvolverá un objeto vacio.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<Persona> getPersona(int id)
        {
            Persona p;
            HttpClient httpClient = new HttpClient();

            try
            {
                string res = await httpClient.GetStringAsync(new Uri(con.uri + "/" + id));
                httpClient.Dispose();
                p = JsonConvert.DeserializeObject<Persona>(res);
            }
            catch (Exception)
            {
                p = new Persona();
            }

            return p;
        }

        /// <summary>
        /// Elimina una persona de la base de datos.
        /// </summary>
        /// <param name="id"></param>
        /// <returns>
        /// <see cref="HttpStatusCode.Accepted"/> si ha sido borrado con exito.
        /// <see cref="HttpStatusCode.BadRequest"/> si no ha sido borrado por algun error.
        /// </returns>
        public async Task<HttpStatusCode> deletePersona(int id)
        {
            HttpClient httpClient = new HttpClient();
            HttpStatusCode status = new HttpStatusCode();

            try
            {
                await httpClient.DeleteAsync(new Uri(con.uri + "/" + id));
                status = HttpStatusCode.Accepted;
                httpClient.Dispose();
            }
            catch (Exception)
            {
                status = HttpStatusCode.BadRequest;
            }

            return status;
        }

    }
}
