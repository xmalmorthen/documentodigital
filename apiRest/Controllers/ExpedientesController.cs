using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TramiteDigitalWeb.ModelsApiWeb;
using apiRest.data_members;

namespace apiRest.Controllers
{
    public class ExpedientesController : ApiController
    {
        CatalogosApiWeb catalogos = new CatalogosApiWeb();

        // GET catalogo/Expedientes
        public IEnumerable<vw_ListaExpedientes> Get()
        {
            return catalogos.ca_expedientes();
        }

    }
}