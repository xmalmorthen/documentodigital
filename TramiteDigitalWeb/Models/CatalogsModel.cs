using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RestSharp;
using Newtonsoft.Json;

namespace TramiteDigitalWeb.Models
{
    public class CatalogsModel
    {
        public IEnumerable<data_members.vw_ListaExpedientes> ca_expedientes() {
            try
            {
                string RESTWebApiUrl = TramiteDigitalWeb.Properties.Settings.Default.RESTApiWeb;

                var client = new RestClient(RESTWebApiUrl);
                // client.Authenticator = new HttpBasicAuthenticator(username, password);

                var request = new RestRequest("catalogo/expedientes", Method.GET);

                // easily add HTTP Headers
                request.AddHeader("Content-Type", "application/json; charset=utf-8");
                request.AddHeader("Accept", "application/json");

                // execute the request
                IRestResponse response = client.Execute(request);
                var content = response.Content; // raw content as string

                List<data_members.vw_ListaExpedientes> items =
                    JsonConvert.DeserializeObject<List<data_members.vw_ListaExpedientes>>(content);

                return items;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}