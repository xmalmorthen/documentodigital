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
        private void InicializaVars(){
            CatalogsModel catalogos = new CatalogsModel();
            List<data_members.vw_ListaExpedientes> lista = catalogos.ca_expedientes().ToList();
            lista.Insert(0, new data_members.vw_ListaExpedientes() { id = 0, Descripcion = "Todos los Expedientes" });
            ViewBag.Expedientes = lista as IEnumerable<data_members.vw_ListaExpedientes>;
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
                    ViewBag.Response = ConsultaModels.ConsultaTramitesporValorTrazable(Form.Valor_Trazable);
                }
                else
                {
                    ViewBag.Response = ConsultaModels.ConsultaTramitesporExpedienteyValorTrazable(Form.ExpedienteSeleccionado, Form.Valor_Trazable);
                }
            }
            return View(Form);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Acerca de...";

            return View();
        }

    }
}
