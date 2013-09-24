using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TramiteDigitalWeb.Models;

namespace TramiteDigitalWeb.Controllers
{
    public class ConsultaController : Controller
    {        
        [Authorize]
        public ActionResult TramitesporValorTrazable()
        {
             
            return View(ConsultaModels.ConsultaTramitesporValorTrazable("asd"));
        }

    }
}
