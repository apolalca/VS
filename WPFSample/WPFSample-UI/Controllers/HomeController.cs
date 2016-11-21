using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using WPFSample_BL.Listados;
using WPFSample_Ent;
using WPFSample_BL.Manejadoras;

namespace WPFSample_UI.Controllers
{
    public class HomeController : Controller
    {
        /// <summary>
        /// lista las personas de la base de datos llamando a Business Logic
        /// </summary>
        /// <returns>Devuelt eun listado o reenvia a una paguina de error</returns>
        public ActionResult Index()
        {
            clsListados_BL oListadoBL = new clsListados_BL();
            try
            {
                return View(oListadoBL.getListadoPersonasBL());

            } catch (Exception)
            {
                return View("PagError");
            }
        }

        /// <summary>
        /// Compurbe si el ModelState es invalido de no ser así retorna a la vista DeleteConfirm.
        /// </summary>
        /// <param name="id"> Recoge el Id de la url del usuario seleccionado</param>
        /// <returns></returns>
        public ActionResult Delete(int id)
        {

            if (!ModelState.IsValid)
                return View();

            return View("Delete");

        }

        /// <summary>
        /// ActionName Delete, cuando llamamos a este metodo responderá por Delete no por DeleteConfirm, este metodo será el encargado de
        /// la vista "Confirmar borrar la persona". Llama a la Business Logic borrar persona para borrar dicha persona.
        /// </summary>
        /// <param name="id">Recoge el id enviado por la URL en la vista</param>
        /// <returnsCrea una vista para devolverla al index></returns>
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirm(int id)
        {
            int i;
            clsListados_BL lista = new clsListados_BL();
            clsManejadoraPersonaBL manejadora = new clsManejadoraPersonaBL();
            i = manejadora.borrarPersona(id);
            return View("Index", lista.getListadoPersonasBL());
        }



        // TODO
        public ActionResult Create()
        {
            return View();
        }

        /// <summary>
        /// Crea una persona y comprueba que el estado del modelo sea valido, de ser así volveremos a llamar a Business Logic
        /// y y le pasaremos el objeto persona para crearlo.
        /// </summary>
        /// <param name="persona">Objeto persona, recoge los parametros enviados por la URL</param>
        /// <returns>Devuelve una lista y llama a Index</returns>
        [HttpPost]
        public ActionResult Create(clsPersona persona)
        {
            int i;
            clsListados_BL lista = new clsListados_BL();

            if (!ModelState.IsValid)
            {
                return View(persona);
            }
            else
            {
                try
                {
                    clsManejadoraPersonaBL manejarPersona = new clsManejadoraPersonaBL();
                    i = manejarPersona.insertPersona(persona);
                    return View("Index", lista.getListadoPersonasBL());
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        /// <summary>
        /// Muestra un detalle de las personas en lista, simplemente llama a la Business Logic con el id para recoger la persona
        /// </summary>
        /// <param name="id">Recoge un id enviado por parametro -URL- (Id de la persona)</param>
        /// <returns>Devuelve la misma vista solo que con el objeto persona</returns>
        public ActionResult Details(int id)
        {
            clsPersona p;
            clsManejadoraPersonaBL manejadora = new clsManejadoraPersonaBL();
            p = manejadora.getPersona(id);
            return View(p);
        }

        /// <summary>
        /// Responsable de editar la persona, llama a la Business Logic y obtiene la persona gracias al id.
        /// </summary>
        /// <param name="id">Id de persona enviada por parametro -URL-</param>
        /// <returns>Vuelve a llamar al metodo Edit pero pasando el parametro persona y retorna un objeto para la vista persona</returns>
        public ActionResult Edit(int id)
        {
            clsManejadoraPersonaBL manejadora = new clsManejadoraPersonaBL();
            clsPersona p = manejadora.getPersona(id);

            return View("Edit", p);
        }

        /// <summary>
        /// Recoge a la persona, comprueba que que el modelo es valido y llama para actualizar la persona
        /// </summary>
        /// <param name="persona"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Edit(clsPersona persona)
        {
            int i;
            clsListados_BL lista = new clsListados_BL();

            if (!ModelState.IsValid)
            {
                return View();
            } else {
                clsManejadoraPersonaBL manejadora = new clsManejadoraPersonaBL();
                i = manejadora.actualizarPersona(persona);
                return View("Index", lista.getListadoPersonasBL());
            }
        }

    }
}