using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RestSharp;
using System.Configuration;

namespace TramiteDigitalWeb.Models
{
    public static class ConsultaModels
    {
        //public IEnumerable<data_members.pa_ConsultaTramitesporValorTrazableResult> ConsultaTramitesporValorTrazable(string valor_trazable)
        public static void ConsultaTramitesporValorTrazable(string valor_trazable)
        {
            try
            {
                string RESTWebApiUrl = TramiteDigitalWeb.Properties.Settings.Default.RESTApiWeb;

                var client = new RestClient(RESTWebApiUrl);
                // client.Authenticator = new HttpBasicAuthenticator(username, password);

                var request = new RestRequest("consulta/tramite/{valor_trazable}", Method.POST);
                //request.AddParameter("name", "value"); // adds to POST or URL querystring based on Method
                request.AddUrlSegment("valor_trazable", valor_trazable); // replaces matching token in request.Resource

                // easily add HTTP Headers
                request.AddHeader("Content-Type", "application/json");

                // add files to upload (works with compatible verbs)
                //request.AddFile(path);

                // execute the request
                RestResponse response = client.Execute(request) as RestResponse;
                var content = response.Content; // raw content as string

                

                // or automatically deserialize result
                // return content type is sniffed but can be explicitly set via RestClient.AddHandler();
                //RestResponse<data_members.pa_ConsultaTramitesporValorTrazableResult> response = client.Execute<data_members.pa_ConsultaTramitesporValorTrazableResult>(request) as RestResponse<data_members.pa_ConsultaTramitesporValorTrazableResult>;
                
                //return response;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /*public static IEnumerable<data_members.pa_ConsultaTramitesporExpedienteyValorTrazableResult> ConsultaTramitesporExpedienteyValorTrazable(int id_Expediente, string valor_trazable)
        {
            try
            {
                //IEnumerable<data_members.pa_ConsultaTramitesporExpedienteyValorTrazableResult> response = bd.pa_ConsultaTramitesporExpedienteyValorTrazable(id_Expediente, valor_trazable).ToList();
                return response;
            }
            catch (Exception)
            {
                throw;
            }
        }*/
    }
}