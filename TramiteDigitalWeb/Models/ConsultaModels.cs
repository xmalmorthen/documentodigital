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
    public delegate void FncConsultaCallback(List<ConsultaStructure> result);

    public class rest_consulta
    {
        protected string _usuario;
        protected string _contrasenia;
        protected string _url_servicio_rest;
        protected string _campo_trazable;
        protected int? _expediente = null;

        protected FncConsultaCallback _callback = null;

        public rest_consulta(string usuario, string contrasenia, string url_servicio_rest, int? expediente, string campo_trazable, FncConsultaCallback callback)
        {
            this._usuario = usuario;
            this._contrasenia = contrasenia;
            this._url_servicio_rest = url_servicio_rest;
            this._expediente = expediente;
            byte[] toEncodeAsBytes = System.Text.ASCIIEncoding.ASCII.GetBytes(campo_trazable);
            this._campo_trazable =  System.Convert.ToBase64String(toEncodeAsBytes);
            this._callback = callback;
        }

        public void EjecutaRest_Consulta()
        {
            try
            {
                string RESTWebApiUrl = this._url_servicio_rest;
                //string RESTWebApiUrl = @"http://localhost:4334"; //url de servicio de prueba

                string segments = "consulta/expediente" + (_expediente != null ? "/" + _expediente : string.Empty) + "/" + _campo_trazable;

                var client = new RestClient(RESTWebApiUrl);
                //client.Authenticator = new HttpBasicAuthenticator(this._usuario, this._contrasenia);
                var request = new RestRequest(segments, Method.POST);
                request.AddHeader("Accept", "application/json");                
                // execute the request
                IRestResponse response = client.Execute(request);
                var content = response.Content; // raw content as string

                List<ConsultaStructure> items = JsonConvert.DeserializeObject<List<ConsultaStructure>>(content);

                if (_callback != null) _callback(items);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }

    public static class ConsultaModels
    {
        private static CatalogsModel catalogos = new CatalogsModel();

        public static List<ConsultaStructure> ConsultaTodosNodos(int id_usuario, string valor_trazable)
        {
            response.Clear();

            List<data_members.pa_obtener_nodosResult> nodos = new List<data_members.pa_obtener_nodosResult>(catalogos.nodos(id_usuario).ToList());
            foreach (data_members.pa_obtener_nodosResult item in nodos)
            {
                rest_consulta rest_cnfg = new rest_consulta(item.usuario, item.contrasenia, item.url_servicio_rest, null, valor_trazable, new FncConsultaCallback(ResultCallback));
                Thread th = new Thread(new ThreadStart(rest_cnfg.EjecutaRest_Consulta));
                th.Start();
                th.Join();
            }

            return response;
        }

        internal static dynamic ConsultaTodosExpedientes(int id_usuario, int id_nodo, string valor_trazable)
        {
            response.Clear();

            data_members.pa_obtener_nodoResult nodo = catalogos.nodo(id_usuario,id_nodo);

            rest_consulta rest_cnfg = new rest_consulta(nodo.usuario, nodo.contrasenia, nodo.url_servicio_rest, null, valor_trazable, new FncConsultaCallback(ResultCallback));
            Thread th = new Thread(new ThreadStart(rest_cnfg.EjecutaRest_Consulta));
            th.Start();
            th.Join();
            
            return response;
        }

        internal static dynamic ConsultaExpediente(int id_usuario, int id_nodo, int expediente, string valor_trazable)
        {
            response.Clear();

            data_members.pa_obtener_nodoResult nodo = catalogos.nodo(id_usuario, id_nodo);

            rest_consulta rest_cnfg = new rest_consulta(nodo.usuario, nodo.contrasenia, nodo.url_servicio_rest, expediente, valor_trazable, new FncConsultaCallback(ResultCallback));
            Thread th = new Thread(new ThreadStart(rest_cnfg.EjecutaRest_Consulta));
            th.Start();
            th.Join();

            return response;
        }

        private static List<ConsultaStructure> response = new List<ConsultaStructure>();
        private static void ResultCallback(List<ConsultaStructure> result)
        {
            response.AddRange(result);
        }
    }
}