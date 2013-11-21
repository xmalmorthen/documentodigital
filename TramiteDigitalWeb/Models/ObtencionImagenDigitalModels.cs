using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RestSharp;
using System.Configuration;
using Newtonsoft.Json;
using TramiteDigitalWeb.Models.classes;
using System.Threading;

namespace TramiteDigitalWeb.Models
{
    public delegate void FncObtencionCallbackimagendigitalOk(pa_ImagenDigitalporId_de_digitalResult result);
    public delegate void FncObtencionCallbackimagendigitalError(ErrorConsulta result);

    public class rest_obtencion_imagendigital
    {
        protected string _usuario;
        protected string _contrasenia;
        protected string _url_servicio_rest;
        protected int? _id_de_digital = null;
        protected int? _id_nodo = null;
        protected string _nodo;
        protected FncObtencionCallbackimagendigitalOk _callbackok = null;
        protected FncObtencionCallbackimagendigitalError _error = null;

        public rest_obtencion_imagendigital(string usuario, string contrasenia, string url_servicio_rest, int id_nodo, string nodo, int? id_de_digital, FncObtencionCallbackimagendigitalOk callback, FncObtencionCallbackimagendigitalError error)
        {
            this._usuario = usuario;
            this._contrasenia = contrasenia;
            this._url_servicio_rest = url_servicio_rest;
            this._id_de_digital = id_de_digital;
            this._id_nodo = id_nodo;
            this._nodo = nodo;
            this._callbackok = callback;
            this._error = error;
        }

        public void EjecutaRest_Consulta()
        {
            try
            {                
                string RESTWebApiUrl = this._url_servicio_rest;
                //string RESTWebApiUrl = @"http://localhost:32091"; //url de servicio de prueba

                string segments = "obten/imagendigital/" + _id_de_digital;

                var client = new RestClient(RESTWebApiUrl);
                //client.Authenticator = new HttpBasicAuthenticator(this._usuario, this._contrasenia);
                var request = new RestRequest(segments, Method.POST);
                request.AddHeader("Accept", "application/json");                
                // execute the request
                IRestResponse response = client.Execute(request);
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    var content = response.Content; // raw content as string

                    pa_ImagenDigitalporId_de_digitalResult items = JsonConvert.DeserializeObject<pa_ImagenDigitalporId_de_digitalResult>(content);
                    if (_callbackok != null) _callbackok(items);
                }
                else {
                    if (_error != null) _error(new ErrorConsulta(_id_nodo, _nodo, response.StatusDescription.ToString(), response.StatusCode.ToString()));
                }                
            }
            catch (Exception)
            {
                throw;
            }
        }
    }

    public static class ObtencionimagendigitalModels
    {
        private static CatalogsModel catalogos = new CatalogsModel();

        public static pa_ImagenDigitalporId_de_digitalResult imagendigital(int id_usuario, int id_nodo, int id_de_digital)
        {
            response = null;
            responseerrors.Clear();

            data_members.pa_obtener_nodoResult nodo = catalogos.nodo(id_usuario, id_nodo);

            rest_obtencion_imagendigital rest_cnfg = new rest_obtencion_imagendigital(nodo.usuario, 
                                                          nodo.contrasenia, 
                                                          nodo.url_servicio_rest,                                                          
                                                          nodo.id,
                                                          nodo.nodo,
                                                          id_de_digital,
                                                          new FncObtencionCallbackimagendigitalOk(ResultCallback), 
                                                          new FncObtencionCallbackimagendigitalError(ErrorResult));
            Thread th = new Thread(new ThreadStart(rest_cnfg.EjecutaRest_Consulta));
            th.Start();
            th.Join();

            return response;
        }

        private static pa_ImagenDigitalporId_de_digitalResult response = new pa_ImagenDigitalporId_de_digitalResult();
        private static void ResultCallback(pa_ImagenDigitalporId_de_digitalResult result)
        {
            response = result;
        }

        private static List<ErrorConsulta> responseerrors = new List<ErrorConsulta>();
        public static List<ErrorConsulta> ResponseErrors
        {
            get
            {
                return responseerrors;
            }
        }
        private static void ErrorResult(ErrorConsulta result)
        {
            responseerrors.Add(result);
        }
    }
}