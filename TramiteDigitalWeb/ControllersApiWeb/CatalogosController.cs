using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Newtonsoft.Json;

namespace TramiteDigitalWeb.Controllers
{
    public class expedientesController : ApiController
    {
        ModelsApiWeb.CatalogosApiWeb catalogos = new ModelsApiWeb.CatalogosApiWeb();

        // GET catalogos//asd
        public IEnumerable<data_members.vw_ListaExpedientes> Get()
        {
            return catalogos.ca_expedientes();
        }       
    }
}