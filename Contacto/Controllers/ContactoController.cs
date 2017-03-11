using Contacto.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Datos;

namespace Contacto.Controllers
{
    public class ContactoController : Controller
    {
        // GET: Contacto
        [HttpGet]
        public ActionResult Index()
        {
            var model = new PersonaModel();
            return View(model);
        }

        [HttpPost]
        public ActionResult Index(PersonaModel model) {
            if (model == null)
                model = new PersonaModel();

            if (ModelState.IsValid)
            {
                //Implementación de insert
                using(var db = new ContactoEntities())
                {
                    var entity = db.Persona.Create();
                    entity.Comentario = model.Comentario;
                    entity.Email = model.Email;
                    entity.Nombre = model.Nombre;
                    entity.Telefono = model.Telefono;

                    db.Persona.Add(entity);
                    var resultado = db.SaveChanges() == 1 ? true : false;
                }
            }
            return RedirectToAction("ListContacto");
        }

        public ActionResult ListContacto()
        {
            // Instanciamos una lista de PersonaModel para el modelo
            // que enviamos a la vista.
            IList<PersonaModel> model = new List<PersonaModel>();
            // Conectamos a la DB
            using (var db = new ContactoEntities())
            {
                // Buscamos la lista de todas las personas que se encuentren en la tabla Persona
                var entidad = db.Persona.ToList();
                // Implementamos este ciclo para asignar las entidades al modelo
                foreach (var item in entidad)
                {
                    var m = new PersonaModel();
                    m.Comentario = item.Comentario;
                    m.Email = item.Email;
                    m.Nombre = item.Nombre;
                    m.Telefono = item.Telefono;
                    model.Add(m);
                }
            }

            // Retornamos el resultado a la vista
            return View(model);
        }

    }

    
}