using PracticaFormulario.Models;
using PracticaFormulario.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PracticaFormulario.Controllers
{
    public class FormularioController : Controller
    {
        //
        // GET: /Formulario/
        public ActionResult ViewFormulario()
        {
            return View();
        }

    [HttpPost]
        public ActionResult ViewFormulario(FormViewModel formul)
        {
            DbConnection conn = new DbConnection();
            conn.RegistrarFormulario(formul);
            ViewBag.message = "Correctamente";
            return View();
        }
	}
}