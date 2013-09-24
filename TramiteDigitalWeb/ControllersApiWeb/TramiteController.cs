using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Newtonsoft.Json;

namespace TramiteDigitalWeb.Controllers
{
    public class tramiteController : ApiController
    {
        ModelsApiWeb.ConsultasApiWeb consulta = new ModelsApiWeb.ConsultasApiWeb();

        // POST consulta/tramite/asd
        public IEnumerable<data_members.pa_ConsultaTramitesporValorTrazableResult> Post(string campo_trazable)
        {            
            return consulta.ConsultaTramitesporValorTrazable(campo_trazable);
        }

        // POST consulta/tramite/1/asd
        public IEnumerable<data_members.pa_ConsultaTramitesporExpedienteyValorTrazableResult> Post(int id_expediente, string campo_trazable)
        {

            return consulta.ConsultaTramitesporExpedienteyValorTrazable(id_expediente, campo_trazable);
        }
       
    }
}