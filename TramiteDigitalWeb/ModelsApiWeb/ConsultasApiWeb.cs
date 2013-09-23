using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TramiteDigitalWeb.ModelsApiWeb
{
    public class ConsultasApiWeb
    {
        private data_members.Bd_Exp_TransportesDataContext bd = new data_members.Bd_Exp_TransportesDataContext();

        public IEnumerable<data_members.pa_ConsultaTramitesporValorTrazableResult> ConsultaTramitesporValorTrazable(string valor_trazable) {
            try
            {
                IEnumerable<data_members.pa_ConsultaTramitesporValorTrazableResult> response = bd.pa_ConsultaTramitesporValorTrazable(valor_trazable).ToList();
                return response;
            }
            catch (Exception)
            {                
                throw;
            }        
        }

        public IEnumerable<data_members.pa_ConsultaTramitesporExpedienteyValorTrazableResult> ConsultaTramitesporExpedienteyValorTrazable(int id_Expediente,string valor_trazable)
        {
            try
            {
                IEnumerable<data_members.pa_ConsultaTramitesporExpedienteyValorTrazableResult> response = bd.pa_ConsultaTramitesporExpedienteyValorTrazable(id_Expediente,valor_trazable).ToList();
                return response;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}