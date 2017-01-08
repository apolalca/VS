using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Windows.Web.Http;
using Newtonsoft.Json;
using Windows.Web.Http.Filters;

namespace UWPPruebas.Model
{
    public class Listado
    {
        Conexion con;

        public Listado()
        {
            con = new Conexion();
        }

        /// <summary>
        /// Devuelve una lista, es necesario Newtonsoft Package.
        /// <seealso cref="Conexion"/>
        /// </summary>
        /// <returns></returns>
        public async Task<ObservableCollection<Persona>> getList()
        {
            
            ObservableCollection<Persona> listado = new ObservableCollection<Persona>();
            HttpBaseProtocolFilter filtro = new HttpBaseProtocolFilter();
            filtro.CacheControl.ReadBehavior = HttpCacheReadBehavior.MostRecent;
            //Esto evita que cuando cambiamos algo en la base de datos no se quede en cache y por tanto quede reflejado al
            // instante en el listado.
            filtro.CacheControl.WriteBehavior = HttpCacheWriteBehavior.NoCache;
            HttpClient httpClient = new HttpClient(filtro);

            try
            {
                string res = await httpClient.GetStringAsync(con.uri);
                httpClient.Dispose();
                //Newtonsoft Package.
                listado = JsonConvert.DeserializeObject<ObservableCollection<Persona>>(res);
            } catch (Exception)
            {
                throw;
            }

            return listado;
        }
    }
}
