using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace TramiteDigitalWeb
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.Routes.MapHttpRoute(
                name: "Bucar en cualquier Expediente",
                routeTemplate: "consulta/{controller}/{campo_trazable}",
                defaults: null,
                constraints: new { campo_trazable = @"^[a-z]+$" }
            );

            config.Routes.MapHttpRoute(
                name: "Bucar en un Expediente",
                routeTemplate: "consulta/{controller}/{id_expediente}/{campo_trazable}",
                defaults: null,
                constraints: new { id_expediente = @"^[0-9]+$", campo_trazable = @"^[a-z]+$" }
            );

        }
    }
}
