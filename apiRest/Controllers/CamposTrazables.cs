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
    public class CamposTrazablesController : ApiController
    {
        ConsultasApiWeb consulta = new ConsultasApiWeb();

        // POST obten/CamposTrazables/id
        // Obtiene los campos trazables a travez del id maestro de digitalizacion
        public IEnumerable<pa_CampostrazablesRegistradosporId_ma_digitalResult> Post(int id_ma_digital)
        {
            try
            {
                return consulta.CamposTrazables(id_ma_digital);
            }
            catch (Exception e)
            {
                return null;
            }            
        }
    }
}