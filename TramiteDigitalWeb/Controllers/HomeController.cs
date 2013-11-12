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

        private void InicializaVars(){            
            string[] UserParts = User.Identity.Name.Split('~');
            List<data_members.pa_obtener_nodosResult> nodos = null;
            nodos = catalogos.nodos(int.Parse(UserParts[1])).ToList();
            nodos.Insert(0, new data_members.pa_obtener_nodosResult() { id= -1, nodo = "-- Seleccione un nodo --"});
            nodos.Insert(1, new data_members.pa_obtener_nodosResult() { id= 0, nodo = "Todos los Nodos" });
            ViewBag.Nodos = nodos as IEnumerable<data_members.pa_obtener_nodosResult>;            
            ViewBag.Expedientes = null;
            ViewBag.Response = null;
        }

        [Authorize]
        public ActionResult Index()
        {
            InicializaVars();
            return View();
        }

        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(Models.ConsultasViewModels Form) {

            InicializaVars();
            if (ModelState.IsValid)
            {
                if (Form.ExpedienteSeleccionado == 0)
                {
                    //ViewBag.Response = ConsultaModels.ConsultaTramitesporValorTrazable(Form.Valor_Trazable);
                }
                else
                {
                    //ViewBag.Response = ConsultaModels.ConsultaTramitesporExpedienteyValorTrazable(Form.ExpedienteSeleccionado, Form.Valor_Trazable);
                }
            }
            return View(Form);
        }

        [Authorize]
        [HttpGet]
        public ActionResult ObtenExpedientes(int id_nodo) {
            string[] UserParts = User.Identity.Name.Split('~');
            List<vw_ListaExpedientes> lista_expedientes = catalogos.obtenerExpedientes(id_nodo,catalogos.nodos(int.Parse(UserParts[1])).ToList());
            return Json( lista_expedientes, JsonRequestBehavior.AllowGet);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Acerca de...";

            return View();
        }

    }
}
