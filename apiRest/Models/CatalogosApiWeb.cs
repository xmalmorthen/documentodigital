using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using apiRest.data_members;

namespace apiRest.ModelsApiWeb
{
    public class CatalogosApiWeb
    {
        private Bd_Expedientes_DigitalesDataContext bd = new Bd_Expedientes_DigitalesDataContext();

        public IEnumerable<vw_ListaExpedientes> ca_expedientes()
        {
            try
            {
                IEnumerable<vw_ListaExpedientes> response = bd.GetTable<vw_ListaExpedientes>().ToList();
                return response;
            }
            catch (Exception)
            {                
                throw;
            }        
        }
    }
}