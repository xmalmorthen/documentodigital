using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using apiRest.data_members;

namespace TramiteDigitalWeb.ModelsApiWeb
{
    public class ConsultasApiWeb
    {
        private Bd_Expedientes_DigitalesDataContext bd = new Bd_Expedientes_DigitalesDataContext();

        public IEnumerable<pa_ConsultaTramitesporValorTrazableResult> ConsultaTramitesporValorTrazable(string valor_trazable) {
            try
            {
                List<pa_ConsultaTramitesporValorTrazableResult> response = bd.pa_ConsultaTramitesporValorTrazable(valor_trazable).ToList();
                //response.Add(new pa_ConsultaTramitesporValorTrazableResult() { expediente = "prueba", id_estatus = 666, id_ma_digital = 666, nota = "prueba", id_tramite = 666, tramite = "prueba" });
                return response;
            }
            catch (Exception)
            {                
                throw;
            }        
        }

        public IEnumerable<pa_ConsultaTramitesporExpedienteyValorTrazableResult> ConsultaTramitesporExpedienteyValorTrazable(int id_Expediente,string valor_trazable)
        {
            try
            {
                List<pa_ConsultaTramitesporExpedienteyValorTrazableResult> response = bd.pa_ConsultaTramitesporExpedienteyValorTrazable(id_Expediente,valor_trazable).ToList();
                //response.Add(new pa_ConsultaTramitesporExpedienteyValorTrazableResult() { expediente = "prueba", id_estatus = 666, id_ma_digital = 666, nota = "prueba", id_tramite = 666, tramite = "prueba" });
                return response;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}