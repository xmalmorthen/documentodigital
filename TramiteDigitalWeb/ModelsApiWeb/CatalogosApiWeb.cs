using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TramiteDigitalWeb.ModelsApiWeb
{
    public class CatalogosApiWeb
    {
        private data_members.Bd_Exp_TransportesDataContext bd = new data_members.Bd_Exp_TransportesDataContext();

        public IEnumerable<data_members.vw_ListaExpedientes> ca_expedientes()
        {
            try
            {
                IEnumerable<data_members.vw_ListaExpedientes> response = bd.GetTable<data_members.vw_ListaExpedientes>().ToList();
                return response;
            }
            catch (Exception)
            {                
                throw;
            }        
        }
    }
}