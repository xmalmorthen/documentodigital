using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using apiRest.data_members;
using apiRest.ModelsApiWeb;

namespace apiRest.Controllers
{
    public class ExpedienteController : ApiController
    {
        /*
         * Tabla de tipos de busqueda
         * 
         * Por campo trazable principal                                                                                 = 1
         * Por campos trazables del expediente                                                                          = 2
         * Por campos trazables de los documentos                                                                       = 3
         * Por campo trazable principal + Por campos trazables del expediente                                           = 4
         * Por campo trazable principal + Por campos trazables de los documentos                                        = 5
         * Por campos trazables del expediente + Por campos trazables de los documentos                                 = 6
         * Por campo trazable principal + Por campos trazables del expediente + Por campos trazables de los documentos  = 7         
         */

        ConsultasApiWeb consulta = new ConsultasApiWeb();

        // POST consulta/Expediente/tipo_busqueda/base64
        // Obtiene expediente a partir de campo trazable, busca dentro de todos los expedientes
        public IEnumerable<pa_ConsultaTramitesResult> Post(int tipo_busqueda, string campo_trazable)
        {
            try
            {
                if (!string.IsNullOrEmpty(campo_trazable))
                {
                    byte[] data = System.Convert.FromBase64String(campo_trazable);
                    string base64decode = System.Text.ASCIIEncoding.ASCII.GetString(data);

                    return consulta.ConsultaTramites(tipo_busqueda, base64decode);
                }
                return null;
            }
            catch (Exception e)
            {
                return null;
            }            
        }

        // POST consulta/Expediente/1/tipo_busqueda/base64
        // Obtiene expediente a partir de campo trazable y el id del expediente, busca dentro del expediente especificado
        public IEnumerable<pa_ConsultaTramitesResult> Post(int tipo_busqueda, int id_expediente, string campo_trazable)
        {
            try
            {
                if (!string.IsNullOrEmpty(campo_trazable))
                {
                    byte[] data = System.Convert.FromBase64String(campo_trazable);
                    string base64decode = System.Text.ASCIIEncoding.ASCII.GetString(data);

                    return consulta.ConsultaTramites(tipo_busqueda, base64decode, id_expediente);
                }
                return null;
            }
            catch (Exception e)
            {
                return null;
            }  
        }
            
    }
}