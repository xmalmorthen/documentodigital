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
    public class ImagenDigitalController : ApiController
    {
        ConsultasApiWeb consulta = new ConsultasApiWeb();

        // POST obten/ImagenDigital/id
        // Obtiene los registros digitales a travez del id maestro de digitalizacion
        public pa_ImagenDigitalporId_de_digitalResult Post(int id_ma_digital)
        {
            try
            {
                return consulta.ImagenDigital(id_ma_digital);
            }
            catch (Exception e)
            {
                return null;
            }            
        }
    }
}