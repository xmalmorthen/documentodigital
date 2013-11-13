﻿using System;
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
