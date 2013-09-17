using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using scanndoc.data_members;

namespace scanndoc.classes
{
    public static class obtener
    {
        private static Bd_Exp_TransportesDataContext Bd_Exp_Transportes = new Bd_Exp_TransportesDataContext();

        public static string fecha (){
            try
            {
                pa_obtener_fechaResult obj = Bd_Exp_Transportes.pa_obtener_fecha().SingleOrDefault();
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
                pa_obtener_horaResult obj = Bd_Exp_Transportes.pa_obtener_hora().SingleOrDefault();
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
