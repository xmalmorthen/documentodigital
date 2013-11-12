using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RestSharp;
using System.Configuration;
using Newtonsoft.Json;

namespace TramiteDigitalWeb.Models
{
    public static class ConsultaModels
    {
       /* //public IEnumerable<data_members.pa_ConsultaTramitesporValorTrazableResult> ConsultaTramitesporValorTrazable(string valor_trazable)
        public static List<data_members.pa_ConsultaTramitesporValorTrazableResult> ConsultaTramitesporValorTrazable(string valor_trazable)
        {            
            try
            {
                string RESTWebApiUrl = TramiteDigitalWeb.Properties.Settings.Default.RESTApiWeb;

                var client = new RestClient(RESTWebApiUrl);
                // client.Authenticator = new HttpBasicAuthenticator(username, password);

                var request = new RestRequest("consulta/tramite/{valor_trazable}", Method.POST);
                //request.AddParameter("name", "value"); // adds to POST or URL querystring based on Method
                request.AddUrlSegment("valor_trazable", valor_trazable); // replaces matching token in request.Resource
                request.RequestFormat = DataFormat.Xml;

                // easily add HTTP Headers
                request.AddHeader("Content-Type", "application/json; charset=utf-8");
                request.AddHeader("Accept", "application/json");

                // execute the request
                IRestResponse response = client.Execute(request);
                var content = response.Content; // raw content as string

                List<data_members.pa_ConsultaTramitesporValorTrazableResult> items =
                    JsonConvert.DeserializeObject<List<data_members.pa_ConsultaTramitesporValorTrazableResult>>(content);

                return items;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static List<data_members.pa_ConsultaTramitesporExpedienteyValorTrazableResult> ConsultaTramitesporExpedienteyValorTrazable(int id_Expediente, string valor_trazable)
        {
            try
            {
                string RESTWebApiUrl = TramiteDigitalWeb.Properties.Settings.Default.RESTApiWeb;

                var client = new RestClient(RESTWebApiUrl);
                // client.Authenticator = new HttpBasicAuthenticator(username, password);

                var request = new RestRequest("consulta/tramite/{id_expediente}/{valor_trazable}", Method.POST);
                request.AddUrlSegment("id_expediente", id_Expediente.ToString()); // replaces matching token in request.Resource
                request.AddUrlSegment("valor_trazable", valor_trazable); // replaces matching token in request.Resource
                request.RequestFormat = DataFormat.Xml;

                // easily add HTTP Headers
                request.AddHeader("Content-Type", "application/json; charset=utf-8");
                request.AddHeader("Accept", "application/json");

                // execute the request
                IRestResponse response = client.Execute(request);
                var content = response.Content; // raw content as string

                List<data_members.pa_ConsultaTramitesporExpedienteyValorTrazableResult> items =
                    JsonConvert.DeserializeObject<List<data_members.pa_ConsultaTramitesporExpedienteyValorTrazableResult>>(content);

                return items;
            }
            catch (Exception)
            {
                throw;
            }
        }*/
    }
}