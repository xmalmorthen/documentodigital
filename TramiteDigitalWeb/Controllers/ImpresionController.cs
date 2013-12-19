using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.Reporting.WebForms;
using TramiteDigitalWeb.Models;
using TramiteDigitalWeb.Models.classes;

namespace TramiteDigitalWeb.Controllers
{
    public class ImpresionController : Controller
    {        
        private Boolean ValidaAcceso()
        {
            if (!string.IsNullOrEmpty(User.Identity.Name))
            {
                string[] response = Acceso.Valida(User.Identity.Name, true);
                if (Boolean.Parse(response[0]) == false)
                {
                    return false;
                }
                return true;
            }
            return false;
        }

        private void InicializaVars(int? nodoseleccionado = null){
        }

        [HttpGet]
        [Authorize]
        public ActionResult Busqueda(int nodo, int expediente, string valor_trazable, string returnUrl = null)
        {
            if (!ValidaAcceso()) return RedirectToAction("KillSession", "Account");

            LocalReport lr = new LocalReport();
            string path = Path.Combine(Server.MapPath("~/Reportes"), "Busqueda.rdlc");
            if (System.IO.File.Exists(path))
            {
                lr.ReportPath = path;
            }
            else
            {
                throw new Exception("No se encontró el formato de reporte...");
            }

            List<ConsultaStructure> response;            
            if (nodo == 1000)
            {
                response = ConsultaModels.ConsultaTodosNodos(int.Parse(User.Identity.Name.Split('~')[1]), valor_trazable);
            }
            else
            {
                if (expediente == 1000)
                {
                    response = ConsultaModels.ConsultaTodosExpedientes(int.Parse(User.Identity.Name.Split('~')[1]), nodo, valor_trazable);
                }
                else
                {
                    response = ConsultaModels.ConsultaExpediente(int.Parse(User.Identity.Name.Split('~')[1]), nodo, expediente, valor_trazable);
                }
            }

            if (response.Count() == 0) {
                if (returnUrl != null)
                {
                    return RedirectToLocal(returnUrl);
                }
                else
                {
                    return RedirectToAction("Index","Home");
                } 
            }

            List<ErrorConsulta> responseErrors = new List<ErrorConsulta>();
            responseErrors.AddRange(ConsultaModels.ResponseErrors);

            ReportDataSource rdRespuestaConsulta = new ReportDataSource("RespuestaConsulta", response);
            ReportDataSource rdErrorConsulta = new ReportDataSource("ErrorConsulta", responseErrors);

            lr.DataSources.Add(rdRespuestaConsulta);
            lr.DataSources.Add(rdErrorConsulta);

            List<ReportParameter> parameters = new List<ReportParameter>();
            parameters.Add(new ReportParameter("TotalRegistrosRespuesta", response.Count().ToString()));
            parameters.Add(new ReportParameter("TotalRegistrosErrorConsulta", responseErrors.Count().ToString()));
            parameters.Add(new ReportParameter("FechaHora", "Reporte elaborado el " + Miselaneo.Fecha.ToString().Trim() + " a las " + Miselaneo.Hora.ToString().Trim()));
            parameters.Add(new ReportParameter("Autor", "por " + User.Identity.Name.Split('~')[0]));
            lr.SetParameters(parameters);

            string reportType = "PDF";
            string mimeType;
            string encoding;
            string fileNameExtension;

            string deviceInfo =

            "<DeviceInfo>" +
            "  <OutputFormat>" + reportType + "</OutputFormat>" +
/*            "  <PageWidth>8.5in</PageWidth>" +
            "  <PageHeight>11in</PageHeight>" +
            "  <MarginTop>0.5in</MarginTop>" +
            "  <MarginLeft>1in</MarginLeft>" +
            "  <MarginRight>1in</MarginRight>" +
            "  <MarginBottom>0.5in</MarginBottom>" +*/
            "</DeviceInfo>";

            Warning[] warnings;
            string[] streams;
            byte[] renderedBytes;

            renderedBytes = lr.Render(
                reportType,
                deviceInfo,
                out mimeType,
                out encoding,
                out fileNameExtension,
                out streams,
                out warnings);

            return File(renderedBytes, mimeType);
        }

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
