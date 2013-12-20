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
                    TempData["NoAdminPermissions"] = response[1];
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
        public ActionResult Busqueda(int nodo, int expediente, string valor_trazable, string formato = "PDF", string returnUrl = null)
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
            parameters.Add(new ReportParameter("ValorTrazable", valor_trazable));
            
            lr.SetParameters(parameters);

            string reportType = formato;
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

        [HttpGet]
        [Authorize]
        public ActionResult Tramite(int id_ma_digital, int id_nodo, string formato = "PDF", string returnUrl = null)
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

            List<pa_CampostrazablesRegistradosporId_ma_digitalResult> CamposTrazables = new List<pa_CampostrazablesRegistradosporId_ma_digitalResult>();
            CamposTrazables.AddRange(ObtencionCamposTrazablesModels.CamposTrazables(int.Parse(User.Identity.Name.Split('~')[1]), id_nodo, id_ma_digital));

            List<ErrorConsulta> CamposTrazablesErrors = new List<ErrorConsulta>();
            CamposTrazablesErrors.AddRange(ObtencionCamposTrazablesModels.ResponseErrors);

            List<pa_RegistrosDigitalesRegistradosporId_ma_digitalResult> RegistrosDigital = new List<pa_RegistrosDigitalesRegistradosporId_ma_digitalResult>();
            RegistrosDigital.AddRange (ObtencionRegistroDigitalModels.RegistroDigital(int.Parse(User.Identity.Name.Split('~')[1]), id_nodo, id_ma_digital));

            List<ErrorConsulta> RegistrosDigitalErrors = new List<ErrorConsulta>();
            RegistrosDigitalErrors.AddRange(ObtencionRegistroDigitalModels.ResponseErrors);

            ReportDataSource rdCamposTrazables = new ReportDataSource("CamposTrazables", CamposTrazables);
            ReportDataSource rdCamposTrazablesErrors = new ReportDataSource("CamposTrazablesErrors", CamposTrazablesErrors);
            ReportDataSource rdRegistrosDigital = new ReportDataSource("RegistrosDigital", RegistrosDigital);
            ReportDataSource rdRegistrosDigitalErrors = new ReportDataSource("RegistrosDigitalErrors", RegistrosDigitalErrors);

            lr.DataSources.Add(rdCamposTrazables);
            lr.DataSources.Add(rdCamposTrazablesErrors);
            lr.DataSources.Add(rdRegistrosDigital);
            lr.DataSources.Add(rdRegistrosDigitalErrors);

            List<ReportParameter> parameters = new List<ReportParameter>();
            parameters.Add(new ReportParameter("TotalRegistrosCamposTrazables", CamposTrazables.Count().ToString()));
            parameters.Add(new ReportParameter("TotalRegistrosErrorCamposTrazables", CamposTrazablesErrors.Count().ToString()));
            parameters.Add(new ReportParameter("TotalRegistrosDigitales", RegistrosDigital.Count().ToString()));
            parameters.Add(new ReportParameter("TotalRegistrosErrorDigitales", RegistrosDigitalErrors.Count().ToString()));
            parameters.Add(new ReportParameter("FechaHora", "Reporte elaborado el " + Miselaneo.Fecha.ToString().Trim() + " a las " + Miselaneo.Hora.ToString().Trim()));
            parameters.Add(new ReportParameter("Autor", "por " + User.Identity.Name.Split('~')[0]));

            lr.SetParameters(parameters);

            string reportType = formato;
            string mimeType;
            string encoding;
            string fileNameExtension;

            string deviceInfo =
            "<DeviceInfo>" +
            "  <OutputFormat>" + reportType + "</OutputFormat>" +
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
