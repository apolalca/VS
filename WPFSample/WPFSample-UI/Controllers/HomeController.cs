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
        // GET: Home
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

        public ActionResult Delete(int id)
        {

            if (!ModelState.IsValid)
            {
                return View();
            }
            else
            {
                return View("Delete");
            }
        }

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

        // GET: Create
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

        public ActionResult Details(int id)
        {
            clsPersona p;
            clsManejadoraPersonaBL manejadora = new clsManejadoraPersonaBL();
            p = manejadora.getPersona(id);
            return View(p);
        }

        public ActionResult Edit(int id)
        {
            clsManejadoraPersonaBL manejadora = new clsManejadoraPersonaBL();
            clsPersona p = manejadora.getPersona(id);

            return View("Edit", p);
        }

        //GET: Edit
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