using PracticaFormulario.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PracticaFormulario.Controllers
{
    public class MostrarDatosUsuariosController : Controller
    {
        //
        // GET: /MostrarDatosUsuarios/
      
        public ActionResult ViewMostrarUsuarios()
        {
            DbConnection conn = new DbConnection();
          //  ViewBag.Nombre = ((UsuarioModel)Request.RequestContext.HttpContext.Session["user"]).Nombre;
            var listacomentarios = conn.TablaFormulario;
            return View(listacomentarios);
        }


	}
}