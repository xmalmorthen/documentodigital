using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using apiRest.data_members;

namespace TramiteDigitalWeb.ModelsApiWeb
{
    public class ConsultasApiWeb
    {
        private Bd_Expedientes_DigitalesDataContext bd = new Bd_Expedientes_DigitalesDataContext();

        public IEnumerable<pa_ConsultaTramitesporValorTrazableResult> ConsultaTramitesporValorTrazable(string valor_trazable) {
            try
            {
                List<pa_ConsultaTramitesporValorTrazableResult> response = bd.pa_ConsultaTramitesporValorTrazable(valor_trazable).ToList();

                //datos aleatorios de prueba                
                Random bucle = new Random();
                for (int i = 0; i <= bucle.Next(10000); i++)
                {
                    DateTime start = new DateTime(1995, 1, 1);
                    Random gen = new Random();
                    int range = (DateTime.Today - start).Days;
                    response.Add(new pa_ConsultaTramitesporValorTrazableResult() { expediente = "prueba " + i.ToString(), id_estatus = i, id_ma_digital = i, nota = "prueba " + i.ToString(), id_tramite = i, tramite = "prueba " + i.ToString(), fecha_hora_creacion = start.AddDays(gen.Next(range)) });
                }
                //*******************************

                return response;
            }
            catch (Exception)
            {                
                throw;
            }        
        }

        public IEnumerable<pa_ConsultaTramitesporExpedienteyValorTrazableResult> ConsultaTramitesporExpedienteyValorTrazable(int id_Expediente,string valor_trazable)
        {
            try
            {
                List<pa_ConsultaTramitesporExpedienteyValorTrazableResult> response = bd.pa_ConsultaTramitesporExpedienteyValorTrazable(id_Expediente,valor_trazable).ToList();
                
                //datos aleatorios de prueba
                Random bucle = new Random();
                for (int i = 0; i <= bucle.Next(10000); i++)
                {
                    DateTime start = new DateTime(1995, 1, 1);
                    Random gen = new Random();
                    int range = (DateTime.Today - start).Days;
                    response.Add(new pa_ConsultaTramitesporExpedienteyValorTrazableResult() { expediente = "prueba " + i.ToString(), id_estatus = i, id_ma_digital = i, nota = "prueba " + i.ToString(), id_tramite = i, tramite = "prueba " + i.ToString(), fecha_hora_creacion = start.AddDays(gen.Next(range)) });
                }
                //*******************************

                return response;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}