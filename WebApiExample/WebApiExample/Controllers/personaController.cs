using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApiExample.Controllers
{
    public class personaController : Controller
    {
        // GET: persona
        public ActionResult Index()
        {
            return View();
        }
    }
}