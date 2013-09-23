using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TramiteDigitalWeb.Controllers
{
    public class ConsultasController : Controller
    {
        [HttpPost]
        [Authorize]
        public ActionResult Consulta()
        {


            return View();
        }

    }
}
