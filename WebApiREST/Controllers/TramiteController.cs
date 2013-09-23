using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Newtonsoft.Json;

namespace WebApiREST.Controllers
{
    public class tramiteController : ApiController
    {
        // POST consulta/tramite/asd
        public IEnumerable<string> Post(string campo_trazable)
        {
            return new string[] { campo_trazable, campo_trazable };
        }

        // POST consulta/tramite/1/asd
        public IEnumerable<string> Post(int id_expediente, string campo_trazable)
        {
            return new string[] { id_expediente.ToString(), campo_trazable };
        }
       
    }
}