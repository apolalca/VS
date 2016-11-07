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
    public class HomeController:Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            //View vista = new View();

            //try
            //{
            //    clsListadosBL misListados = new clsListadosBL();

            //    vista.ClientID (misListados.listadoPersonasBL());

            //}
            //catch(Exception e) { throw e; }


            //return View(misListados.listadoPersonasBL());

            clsListados_BL oListadoBL = new clsListados_BL();
            return View(oListadoBL.getListadoPersonasBL());
        }

        [HttpPost]
        public ActionResult Create(clsPersona persona)
        {
            int i;

            if (!ModelState.IsValid)
            {
                return View(persona);
            } else
            {
                clsManejadoraPersonaBL manejarPersona = new clsManejadoraPersonaBL();
                i = manejarPersona.insertPersona(persona);
                return View("Index");
            }
        }
    }
}