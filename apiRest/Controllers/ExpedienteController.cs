using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using apiRest.data_members;
using apiRest.ModelsApiWeb;

namespace apiRest.Controllers
{
    public class ExpedienteController : ApiController
    {
        ConsultasApiWeb consulta = new ConsultasApiWeb();

        // POST consulta/Expediente/base64
        // Obtiene expediente a partir de campo trazable, busca dentro de todos los expedientes
        public IEnumerable<pa_ConsultaTramitesporValorTrazableResult> Post(string campo_trazable)
        {
            try
            {
                if (!string.IsNullOrEmpty(campo_trazable))
                {
                    byte[] data = System.Convert.FromBase64String(campo_trazable);
                    string base64decode = System.Text.ASCIIEncoding.ASCII.GetString(data);

                    return consulta.ConsultaTramitesporValorTrazable(base64decode);
                }
                return null;
            }
            catch (Exception e)
            {
                return null;
            }            
        }

        // POST consulta/Expediente/1/base64
        // Obtiene expediente a partir de campo trazable y el id del expediente, busca dentro del expediente especificado
        public IEnumerable<pa_ConsultaTramitesporExpedienteyValorTrazableResult> Post(int id_expediente, string campo_trazable)
        {
            try
            {
                if (!string.IsNullOrEmpty(campo_trazable))
                {
                    byte[] data = System.Convert.FromBase64String(campo_trazable);
                    string base64decode = System.Text.ASCIIEncoding.ASCII.GetString(data);

                    return consulta.ConsultaTramitesporExpedienteyValorTrazable(id_expediente, base64decode);
                }
                return null;
            }
            catch (Exception e)
            {
                return null;
            }  
        }
            
    }
}