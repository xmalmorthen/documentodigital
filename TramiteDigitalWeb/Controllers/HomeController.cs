using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TramiteDigitalWeb.Models;

namespace TramiteDigitalWeb.Controllers
{
    public class HomeController : Controller
    {
        [Authorize]
        public ActionResult Index()
        {
            UsuarioLogeado usuario = new UsuarioLogeado();
            string[] UserParts = User.Identity.Name.Split('~');
            DatosdeUsuario datos = usuario.ObtenDatosdeUsuarioLogeado(Convert.ToInt32(UserParts[1]));
            return View(datos.Modulos);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Acerca de...";

            return View();
        }

    }
}
