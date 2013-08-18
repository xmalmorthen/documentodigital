using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using thumbnail.data_members;

namespace thumbnail.classes
{
    public static class obtener
    {
        private static Bd_Exp_TransportesDataContext Bd_Exp_Transportes = new Bd_Exp_TransportesDataContext();

        public static string fecha (){
            pa_obtener_fechaResult obj = Bd_Exp_Transportes.pa_obtener_fecha().SingleOrDefault();
            return obj.Fecha.ToString();
        }

        public static string hora (){
            pa_obtener_horaResult obj = Bd_Exp_Transportes.pa_obtener_hora().SingleOrDefault();
            return obj.Hora.ToString();
        }
        
    }
}
