using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TramiteDigitalWeb.Models;
using TramiteDigitalWeb.Models.classes;
using TramiteDigitalWeb.data_members;

namespace TramiteDigitalWeb.Controllers
{
    public class AdministracionController : Controller
    {
        private Boolean ValidaAcceso() {
            if (!AdministracionModel.ValidaPermisodeUsuario(int.Parse(User.Identity.Name.Split('~')[1])))
            {
                TempData["NoAdminPermissions"] = "Permisos insuficientes, favor de iniciar sesión con un usuario válido";
                return false;
            }
            return true;        
        }

        private void InicializaVars(){
        }

        [Authorize]
        [HttpGet]
        public ActionResult Usuarios()
        {
            if (!ValidaAcceso()) return RedirectToAction("KillSession", "Account"); 

            InicializaVars();
            return View(AdministracionModel.ListadeUsuarios());
        }

        [Authorize]
        [HttpGet]
        public ActionResult Create()
        {
            InicializaVars();
            return View();
        }

        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ca_usuarios Form)
        {
            InicializaVars();
            if (ModelState.IsValid)
            {
                if (AdministracionModel.CrearUsuario(Form))
                    return RedirectToAction("Usuarios");
                else
                    ModelState.AddModelError("", "Ocurrió un error al intentar agregar el usuario, favor de intentarlo de nuevo");
            }
            
            return View(Form);
        }


        [Authorize]
        [HttpGet]
        public ActionResult Nodos()
        {
            if (!ValidaAcceso()) return RedirectToAction("KillSession", "Account"); 

            InicializaVars();
            return View();
        }

        [Authorize]
        [HttpGet]
        public ActionResult usuarios_nodos()
        {
            if (!ValidaAcceso()) return RedirectToAction("KillSession", "Account");

            InicializaVars();
            return View();
        }

    }
}
