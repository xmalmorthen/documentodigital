using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using scanndoc.data_members;

namespace scanndoc.classes
{
    public static class obtener
    {
        private static Bd_Expedientes_DigitalesDataContext Bd_Expedientes_Digitales = new Bd_Expedientes_DigitalesDataContext();

        public static string fecha (){
            try
            {
                pa_obtener_fechaResult obj = Bd_Expedientes_Digitales.pa_obtener_fecha().SingleOrDefault();
                return obj.Fecha.ToString();
            }
            catch (Exception e)
            {
                scanndoc.classes.errorlogs.seterror(e);
            }
            return null;
        }

        public static string hora (){
            try
            {
                pa_obtener_horaResult obj = Bd_Expedientes_Digitales.pa_obtener_hora().SingleOrDefault();
                return obj.Hora.ToString();
            }
            catch (Exception e)
            {
                scanndoc.classes.errorlogs.seterror(e);
            }
            return null;
        }
        
    }
}
