using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace apiRest
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            /*
             * Catalogos
             */
            config.Routes.MapHttpRoute(
                name: "Catálogo",
                routeTemplate: "catalogo/{controller}",
                defaults: null
            );

            /*
             * Consultas
             */
            config.Routes.MapHttpRoute(
                name: "Bucar en cualquier Expediente",
                routeTemplate: "consulta/{controller}/{campo_trazable}",
                defaults: null
                //constraints: new { campo_trazable = @"^[a-z]+$" }
            );

            config.Routes.MapHttpRoute(
                name: "Bucar en un Expediente",
                routeTemplate: "obten/{controller}/{id_ma_digital}",
                defaults: null,
                constraints: new { id_ma_digital = @"^[0-9]+$" }
            );

            config.Routes.MapHttpRoute(
                name: "Obtener datos",
                routeTemplate: "obten/{controller}/{id_ma_digital}",
                defaults: null,
                constraints: new { id_ma_digital = @"^[0-9]+$" }
            );


        }
    }
}
