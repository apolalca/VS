using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Web.Http;
using Windows.Web.Http.Filters;

namespace UWPPruebas.Model
{
    class Conexion
    {
        public Uri uri { get; set; }

        /// <summary>
        /// Almacena una simple <see cref="Uri"/>
        /// </summary>
        public Conexion()
        {
            //Mi Api rest
            ///TODO Utilizar mi Api Rest - Tiene que arreglarse hay algo que no funciona #2 Bug
            uri = new Uri("http://webapirestdanileal.azurewebsites.net/api/personas/");
        }

        public Conexion(Uri uri)
        {
            this.uri = uri;
        }

    }
}
