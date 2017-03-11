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
            return View();
        }
    }
}