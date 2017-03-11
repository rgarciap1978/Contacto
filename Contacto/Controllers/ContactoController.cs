using Contacto.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Contacto.Controllers
{
    public class ContactoController : Controller
    {
        // GET: Contacto
        [HttpGet]
        public ActionResult Index()
        {
            var model = new Persona();
            return View(model);
        }

        [HttpPost]
        public ActionResult Index(Persona model) {
            if (model == null)
                model = new Persona();

            if (ModelState.IsValid)
            {

            }
            return View(model);
        }

    }
}