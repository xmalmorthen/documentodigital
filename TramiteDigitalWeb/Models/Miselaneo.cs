using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using scanndoc.classes;
using TramiteDigitalWeb.data_members;

namespace TramiteDigitalWeb.Models
{
    public static class Miselaneo
    {
        public static string Fecha { get { 
                Bd_Expedientes_WebDataContext bd = new Bd_Expedientes_WebDataContext();

                pa_FechaResult result = bd.pa_Fecha().SingleOrDefault();
                if (result != null)
                {
                    return result.Fecha;
                }
                else
                {
                    return "<< NO ESPECIFICADA >>";
                }
            } 
        }

        public static string Hora
        {
            get
            {
                Bd_Expedientes_WebDataContext bd = new Bd_Expedientes_WebDataContext();

                pa_HoraResult result = bd.pa_Hora().SingleOrDefault();
                if (result != null)
                {
                    return result.Hora;
                }
                else
                {
                    return "<< NO ESPECIFICADA >>";
                }
            }
        }
    }

}