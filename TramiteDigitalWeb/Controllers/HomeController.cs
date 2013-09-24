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
            CatalogsModel catalogos = new CatalogsModel();
            List<data_members.vw_ListaExpedientes> lista = catalogos.ca_expedientes().ToList();
            lista.Insert(0, new data_members.vw_ListaExpedientes() { id = 0, Descripcion = "Todos los Expedientes" });
            ViewBag.Expedientes = lista as IEnumerable<data_members.vw_ListaExpedientes>;
            return View();
        }

        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(Models.ConsultasViewModels Form) {

            if (!ModelState.IsValid)
            {
                CatalogsModel catalogos = new CatalogsModel();
                ViewBag.Expedientes = catalogos.ca_expedientes();
                return View(Form);
            }

            if (Form.ExpedienteSeleccionado == 0)
            {
                return View("TramitesporValorTrazable",ConsultaModels.ConsultaTramitesporValorTrazable(Form.Valor_Trazable));
            }
            else
            {
                //cambiar esta vista
                return View("TramitesporValorTrazable", ConsultaModels.ConsultaTramitesporExpedienteyValorTrazable(Form.ExpedienteSeleccionado,Form.Valor_Trazable));
            }
        }

        public ActionResult About()
        {
            ViewBag.Message = "Acerca de...";

            return View();
        }

    }
}
