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

        private void InicializaVars(string returnUrl = null){
            ViewBag.ReturnUrl = returnUrl;
        }

#region Usuarios

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
        public ActionResult Crear_Usuario()
        {
            if (!ValidaAcceso()) return RedirectToAction("KillSession", "Account"); 

            InicializaVars();
            return View(new ca_usuarios() { activo = true });
        }

        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Crear_Usuario(ca_usuarios Form)
        {
            if (!ValidaAcceso()) return RedirectToAction("KillSession", "Account"); 

            InicializaVars();
            if (ModelState.IsValid)
            {
                Boolean? response = AdministracionModel.CrearUsuario(Form);
                if (response != null) {
                    if (response == true) {
                        return RedirectToAction("Usuarios");
                    } else {
                        ModelState.AddModelError("", "El usuario ya se encuentra registrado, favor de revisar");
                    }
                }
                else
                    ModelState.AddModelError("", "Ocurrió un error al intentar agregar el usuario, favor de intentarlo de nuevo");
            }
            
            return View(Form);
        }

        [Authorize]
        [HttpGet]
        public ActionResult Detalle_Usuario(int id_usuario)
        {
            if (!ValidaAcceso()) return RedirectToAction("KillSession", "Account"); 

            InicializaVars();

            ca_usuarios usuario = AdministracionModel.Get_Usuario(id_usuario);
            ViewBag.nodos_usuario = usuario.re_nodos_usuarios.ToList();

            return View(usuario);
        }

        [Authorize]
        [HttpGet]
        public ActionResult Edita_Usuario(int id_usuario, string returnUrl)
        {
            if (!ValidaAcceso()) return RedirectToAction("KillSession", "Account");

            InicializaVars(returnUrl);

            ca_usuarios usuario = AdministracionModel.Get_Usuario(id_usuario);
            usuario.repetircontrasenia = usuario.contrasenia;
            return View(usuario);
        }

        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edita_Usuario(ca_usuarios Form, string returnUrl)
        {
            if (!ValidaAcceso()) return RedirectToAction("KillSession", "Account"); 

            InicializaVars();
            if (ModelState.IsValid)
            {
                if (AdministracionModel.Edita_Usuario(Form))
                {
                    if (returnUrl != null)
                    {
                        return RedirectToLocal(returnUrl);
                    }
                    else
                    {
                        return RedirectToAction("Usuarios");
                    }                    
                }
                else
                    ModelState.AddModelError("", "Ocurrió un error al intentar editar el usuario, favor de intentarlo de nuevo");
            }
            return View(Form);
        }

        [Authorize]
        [HttpGet]
        public ActionResult Cambia_Contrasenia_Usuario(int id_usuario)
        {
            if (!ValidaAcceso()) return RedirectToAction("KillSession", "Account"); 

            InicializaVars();

            ca_usuarios usuario = AdministracionModel.Get_Usuario(id_usuario);
            usuario.contrasenia = null;
            usuario.repetircontrasenia = null;
            return View(usuario);
        }

        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Cambia_Contrasenia_Usuario(ca_usuarios Form)
        {
            if (!ValidaAcceso()) return RedirectToAction("KillSession", "Account"); 

            InicializaVars();
            if (ModelState.IsValid)
            {
                if (AdministracionModel.Cambia_Contrasenia(Form))
                    return RedirectToAction("Usuarios");
                else
                    ModelState.AddModelError("", "Ocurrió un error al intentar cambiar contraseña del usuario, favor de intentarlo de nuevo");
            }
            return View(Form);
        }

        [Authorize]
        [HttpGet]
        public ActionResult Eliminar_usuario(int id_usuario)
        {
            if (!ValidaAcceso()) return RedirectToAction("KillSession", "Account"); 

            InicializaVars();

            if (AdministracionModel.Elimina_Usuario(id_usuario))
            {
                ViewBag.Response = "Usuario eliminado con éxito";
                if (!ValidaAcceso()) return RedirectToAction("KillSession", "Account"); 
            }
            else
                ViewBag.Response = "Ocurrió un error al intentar eliminar el usuario, favor de intentarlo de nuevo";

            return RedirectToAction("Usuarios");
        }

#endregion Usuarios

#region Nodos
        [Authorize]
        [HttpGet]
        public ActionResult Nodos()
        {
            if (!ValidaAcceso()) return RedirectToAction("KillSession", "Account"); 

            InicializaVars();
            return View(AdministracionModel.ListadeNodos());
        }

        [Authorize]
        [HttpGet]
        public ActionResult Crear_Nodo()
        {
            if (!ValidaAcceso()) return RedirectToAction("KillSession", "Account"); 

            InicializaVars();
            return View(new ca_nodos() { activo = true });
        }

        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Crear_Nodo(ca_nodos Form)
        {
            if (!ValidaAcceso()) return RedirectToAction("KillSession", "Account"); 

            InicializaVars();
            if (ModelState.IsValid)
            {
                Boolean? response = AdministracionModel.CrearNodo(Form);
                if (response != null)
                {
                    if (response == true)
                    {
                        return RedirectToAction("Nodos");
                    }
                    else
                    {
                        ModelState.AddModelError("", "El nodo ya se encuentra registrado, favor de revisar");
                    }
                }
                else
                    ModelState.AddModelError("", "Ocurrió un error al intentar agregar el nodo, favor de intentarlo de nuevo");
            }

            return View(Form);
        }

        [Authorize]
        [HttpGet]
        public ActionResult Detalle_Nodo(int id_nodo)
        {
            if (!ValidaAcceso()) return RedirectToAction("KillSession", "Account"); 

            InicializaVars();
            return View(AdministracionModel.Get_Nodo(id_nodo));
        }

        [Authorize]
        [HttpGet]
        public ActionResult Edita_Nodo(int id_nodo, string returnUrl)
        {
            if (!ValidaAcceso()) return RedirectToAction("KillSession", "Account");

            InicializaVars(returnUrl);
            return View(AdministracionModel.Get_Nodo(id_nodo));
        }

        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edita_Nodo(ca_nodos Form, string returnUrl)
        {
            if (!ValidaAcceso()) return RedirectToAction("KillSession", "Account"); 

            InicializaVars();
            if (ModelState.IsValid)
            {
                if (AdministracionModel.Edita_Nodo(Form))
                {
                    if (returnUrl != null)
                    {
                        return RedirectToLocal(returnUrl);
                    }
                    else
                    {
                        return RedirectToAction("Nodos");
                    }                    
                }                    
                else
                    ModelState.AddModelError("", "Ocurrió un error al intentar editar el nodo, favor de intentarlo de nuevo");
            }
            return View(Form);
        }

        [Authorize]
        [HttpGet]
        public ActionResult Eliminar_nodo(int id_nodo)
        {
            if (!ValidaAcceso()) return RedirectToAction("KillSession", "Account"); 

            InicializaVars();

            if (AdministracionModel.Elimina_Nodo(id_nodo))
            {
                ViewBag.Response = "Nodo eliminado con éxito";
            }
            else
                ViewBag.Response = "Ocurrió un error al intentar eliminar el nodo, favor de intentarlo de nuevo";

            return RedirectToAction("Nodos");
        }

#endregion Nodos


#region usuarios_nodos
        [Authorize]
        [HttpGet]
        public ActionResult usuarios_nodos()
        {
            if (!ValidaAcceso()) return RedirectToAction("KillSession", "Account");

            InicializaVars();
            return View();
        }
#endregion usuarios_nodos


#region Aplicaciones auxiliares
        private ActionResult RedirectToLocal(string returnUrl)
        {
            if (Url.IsLocalUrl(returnUrl))
            {
                return Redirect(returnUrl);
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }
#endregion Aplicaciones auxiliares
    }
}
