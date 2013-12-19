using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TramiteDigitalWeb.Models;
using TramiteDigitalWeb.Models.classes;

namespace TramiteDigitalWeb.Controllers
{
    public class HomeController : Controller
    {        
        CatalogsModel catalogos = new CatalogsModel();

        private Boolean ValidaAcceso()
        {
            if (!string.IsNullOrEmpty(User.Identity.Name))
            {
                string[] response = Acceso.Valida(User.Identity.Name, true);
                if (Boolean.Parse(response[0]) == false)
                {
                    TempData["NoAdminPermissions"] = response[1];
                    return false;
                }
                return true;
            }
            return false;
        }

        private void InicializaVars(int? nodoseleccionado = null){
            string[] UserParts = User.Identity.Name.Split('~');
            List<data_members.pa_obtener_nodosResult> nodos = new List<data_members.pa_obtener_nodosResult>();            
            nodos.AddRange (catalogos.nodos(int.Parse(UserParts[1])).ToList());
            nodos.Add(new data_members.pa_obtener_nodosResult() { id=1000,  nodo = "Todos los Nodos" });
            ViewBag.Nodos = nodos;
            
            ViewBag.Expedientes = null;
            List<vw_ListaExpedientes> lista = new List<vw_ListaExpedientes>();
            if (nodoseleccionado != null ) {
                if (nodoseleccionado != 0 && nodoseleccionado != 1000)
                    lista.AddRange(catalogos.obtenerExpedientes((int)nodoseleccionado, catalogos.nodos(int.Parse(UserParts[1])).ToList()));
                if (nodoseleccionado != 0 )
                    lista.Add(new vw_ListaExpedientes(){ id=1000, Descripcion="Todos los expedientes"});
                if (lista.Count > 0)
                    ViewBag.Expedientes = lista;
            }       

            ViewBag.Response = null;
            ViewBag.ResponseErrors = null;
        }

        [Authorize]
        [HttpGet]
        public ActionResult ObtenExpedientes(int id_nodo)
        {
            if (!ValidaAcceso()) return RedirectToAction("KillSession", "Account");

            string[] UserParts = User.Identity.Name.Split('~');
            List<vw_ListaExpedientes> lista_expedientes = catalogos.obtenerExpedientes(id_nodo, catalogos.nodos(int.Parse(UserParts[1])).ToList());
            return Json(lista_expedientes, JsonRequestBehavior.AllowGet);
        }

        [Authorize]
        public ActionResult Index()
        {
            if (!ValidaAcceso()) return RedirectToAction("KillSession", "Account");

            InicializaVars();
            return View();
        }

        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(Models.ConsultasViewModels Form) {
            if (!ValidaAcceso()) return RedirectToAction("KillSession", "Account");

            InicializaVars(Form.NodoSeleccionado);
            if (ModelState.IsValid)
            {
                if (Form.NodoSeleccionado == 1000)
                {                    
                    ViewBag.Response = ConsultaModels.ConsultaTodosNodos(int.Parse(User.Identity.Name.Split('~')[1]), Form.Valor_Trazable);
                }
                else
                {
                    if (Form.ExpedienteSeleccionado == 1000)
                    {
                        ViewBag.Response = ConsultaModels.ConsultaTodosExpedientes(int.Parse(User.Identity.Name.Split('~')[1]),Form.NodoSeleccionado,Form.Valor_Trazable);
                    }
                    else
                    {
                        ViewBag.Response = ConsultaModels.ConsultaExpediente(int.Parse(User.Identity.Name.Split('~')[1]),Form.NodoSeleccionado,Form.ExpedienteSeleccionado, Form.Valor_Trazable);
                    }
                }

                ViewBag.ResponseErrors = ConsultaModels.ResponseErrors.Count() > 0 ? ConsultaModels.ResponseErrors : null;
            }
            
            return View(Form);
        }

        [Authorize]
        [HttpGet]
        public ActionResult Details(int id_ma_digital, int id_nodo) {
            if (!ValidaAcceso()) return RedirectToAction("KillSession", "Account");

            ViewBag.CamposTrazables = ObtencionCamposTrazablesModels.CamposTrazables(int.Parse(User.Identity.Name.Split('~')[1]), id_nodo, id_ma_digital);
            ViewBag.CamposTrazablesErrors = ObtencionCamposTrazablesModels.ResponseErrors.Count() > 0 ? ObtencionCamposTrazablesModels.ResponseErrors : null;

            ViewBag.RegistrosDigital = ObtencionRegistroDigitalModels.RegistroDigital(int.Parse(User.Identity.Name.Split('~')[1]), id_nodo, id_ma_digital);
            ViewBag.RegistrosDigitalErrors = ObtencionRegistroDigitalModels.ResponseErrors.Count() > 0 ? ObtencionRegistroDigitalModels.ResponseErrors : null;

            ViewBag.IdNodo = id_nodo;

            return View();
        }

        [Authorize]
        [HttpGet]
        public void OpenImage(int id_de_digital, int id_nodo)
        {
            pa_ImagenDigitalporId_de_digitalResult imagendigital = ObtencionimagendigitalModels.imagendigital(int.Parse(User.Identity.Name.Split('~')[1]), id_nodo, id_de_digital);

            Response.Clear();
            Response.BinaryWrite(imagendigital.imagen);
            Response.ContentType = "image/jpeg";
            Response.End();
        }

        [Authorize]
        [HttpGet]
        public ActionResult OpenImageAjax(int id_de_digital, int id_nodo)
        {
            pa_ImagenDigitalporId_de_digitalResult imagendigital = ObtencionimagendigitalModels.imagendigital(int.Parse(User.Identity.Name.Split('~')[1]), id_nodo, id_de_digital);
            return Json(Convert.ToBase64String(imagendigital.imagen), JsonRequestBehavior.AllowGet);
        }

        [Authorize]
        [HttpGet]
        public ActionResult Gallery(int id_ma_digital, int id_nodo)
        {
            if (!ValidaAcceso()) return RedirectToAction("KillSession", "Account");

            ViewBag.CamposTrazables = ObtencionCamposTrazablesModels.CamposTrazables(int.Parse(User.Identity.Name.Split('~')[1]), id_nodo, id_ma_digital);
            ViewBag.CamposTrazablesErrors = ObtencionCamposTrazablesModels.ResponseErrors.Count() > 0 ? ObtencionCamposTrazablesModels.ResponseErrors : null;

            ViewBag.RegistrosDigital = ObtencionRegistroDigitalModels.RegistroDigital(int.Parse(User.Identity.Name.Split('~')[1]), id_nodo, id_ma_digital);
            ViewBag.RegistrosDigitalErrors = ObtencionRegistroDigitalModels.ResponseErrors.Count() > 0 ? ObtencionRegistroDigitalModels.ResponseErrors : null;

            ViewBag.IdNodo = id_nodo;

            return View();
        }

        [Authorize]
        [HttpGet]
        public ActionResult Menu()
        {
            if (!ValidaAcceso()) return RedirectToAction("KillSession", "Account");

            return View();
        }
    }
}
