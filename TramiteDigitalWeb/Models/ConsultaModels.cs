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
    public delegate void FncConsultaCallbackOk(List<ConsultaStructure> result);
    public delegate void FncConsultaCallbackError(ErrorConsulta result);

    public class rest_consulta
    {
        protected string _usuario;
        protected string _contrasenia;
        protected string _url_servicio_rest;
        protected string _campo_trazable;
        protected int? _tipo_consulta = null;
        protected int? _expediente = null;
        protected int? _id_nodo = null;
        protected string _nodo;
        protected FncConsultaCallbackOk _callbackok = null;
        protected FncConsultaCallbackError _error = null;

        public rest_consulta(string usuario, string contrasenia, string url_servicio_rest, int id_nodo, string nodo, int tipo_consulta, int? expediente, string campo_trazable, FncConsultaCallbackOk callback, FncConsultaCallbackError error)
        {
            this._usuario = usuario;
            this._contrasenia = contrasenia;
            this._url_servicio_rest = url_servicio_rest;
            this._id_nodo = id_nodo;
            this._nodo = nodo;
            this._tipo_consulta = tipo_consulta;
            this._expediente = expediente;
            byte[] toEncodeAsBytes = System.Text.ASCIIEncoding.ASCII.GetBytes(campo_trazable);
            this._campo_trazable =  System.Convert.ToBase64String(toEncodeAsBytes);
            this._callbackok = callback;
            this._error = error;
        }

        public void EjecutaRest_Consulta()
        {
            try
            {                
                string RESTWebApiUrl = this._url_servicio_rest;
                //string RESTWebApiUrl = @"http://localhost:8081"; //url de servicio de prueba
                //string RESTWebApiUrl = @"http://localhost/ExpWeb"; //url de servicio de prueba

                string segments = "consulta/Expediente/" + _tipo_consulta + (_expediente != null ? "/" + _expediente : string.Empty) + "/" + _campo_trazable;

                var client = new RestClient(RESTWebApiUrl);
                //client.Authenticator = new HttpBasicAuthenticator(this._usuario, this._contrasenia);
                var request = new RestRequest(segments, Method.POST);
                request.AddHeader("Accept", "application/json");                
                // execute the request
                IRestResponse response = client.Execute(request);
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    var content = response.Content; // raw content as string

                    List<ConsultaStructure> items = JsonConvert.DeserializeObject<List<ConsultaStructure>>(content);
                    foreach (ConsultaStructure item in items)
                    {
                        item.id_nodo = (int)_id_nodo;
                        item.nodo = _nodo;
                    }

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

    public static class ConsultaModels
    {
        private static CatalogsModel catalogos = new CatalogsModel();

        private static int EvaluaTipodeConsulta(bool[] opcionesdebusqueda = null) {
            int tipoconsulta = 0;

            if (opcionesdebusqueda.Length == 3) {
                tipoconsulta = (tipoconsulta == 0) ? (opcionesdebusqueda[0] && !opcionesdebusqueda[1] && !opcionesdebusqueda[2]) ? 1 : 0 : tipoconsulta;
                tipoconsulta = (tipoconsulta == 0) ? (!opcionesdebusqueda[0] && opcionesdebusqueda[1] && !opcionesdebusqueda[2]) ? 2 : 0 : tipoconsulta;
                tipoconsulta = (tipoconsulta == 0) ? (!opcionesdebusqueda[0] && !opcionesdebusqueda[1] && opcionesdebusqueda[2]) ? 3 : 0 : tipoconsulta;
                tipoconsulta = (tipoconsulta == 0) ? (opcionesdebusqueda[0] && opcionesdebusqueda[1] && !opcionesdebusqueda[2]) ? 4 : 0 : tipoconsulta;
                tipoconsulta = (tipoconsulta == 0) ? (opcionesdebusqueda[0] && !opcionesdebusqueda[1] && opcionesdebusqueda[2]) ? 5 : 0 : tipoconsulta;
                tipoconsulta = (tipoconsulta == 0) ? (!opcionesdebusqueda[0] && opcionesdebusqueda[1] && opcionesdebusqueda[2]) ? 6 : 0 : tipoconsulta;
                tipoconsulta = (tipoconsulta == 0) ? (opcionesdebusqueda[0] && opcionesdebusqueda[1] && opcionesdebusqueda[2]) ? 7 : 0 : tipoconsulta;
            }
            return tipoconsulta;
        }

        public static List<ConsultaStructure> ConsultaTodosNodos(int id_usuario, string valor_trazable, bool[] opcionesdebusqueda)
        {
            response.Clear();
            responseerrors.Clear();

            int tipo_consulta = EvaluaTipodeConsulta(opcionesdebusqueda);
            if (tipo_consulta != 0)
            {
                List<data_members.pa_obtener_nodosResult> nodos = new List<data_members.pa_obtener_nodosResult>(catalogos.nodos(id_usuario).ToList());
                foreach (data_members.pa_obtener_nodosResult item in nodos)
                {
                    rest_consulta rest_cnfg = new rest_consulta(item.usuario, item.contrasenia, item.url_servicio_rest, item.id, item.nodo, tipo_consulta, null, valor_trazable, new FncConsultaCallbackOk(ResultCallback), new FncConsultaCallbackError(ErrorResult));
                    Thread th = new Thread(new ThreadStart(rest_cnfg.EjecutaRest_Consulta));
                    th.Start();
                    th.Join();
                }
            }
            return response;
        }

        internal static dynamic ConsultaTodosExpedientes(int id_usuario, int id_nodo, string valor_trazable, bool[] opcionesdebusqueda = null)
        {
            response.Clear();
            responseerrors.Clear();

            int tipo_consulta = EvaluaTipodeConsulta(opcionesdebusqueda);
            if (tipo_consulta != 0)
            {
                data_members.pa_obtener_nodoResult nodo = catalogos.nodo(id_usuario, id_nodo);

                rest_consulta rest_cnfg = new rest_consulta(nodo.usuario, nodo.contrasenia, nodo.url_servicio_rest, nodo.id, nodo.nodo, tipo_consulta, null, valor_trazable, new FncConsultaCallbackOk(ResultCallback), new FncConsultaCallbackError(ErrorResult));
                Thread th = new Thread(new ThreadStart(rest_cnfg.EjecutaRest_Consulta));
                th.Start();
                th.Join();
            }
            return response;
        }

        internal static dynamic ConsultaExpediente(int id_usuario, int id_nodo, int expediente, string valor_trazable, bool[] opcionesdebusqueda = null)
        {
            response.Clear();
            responseerrors.Clear();

            int tipo_consulta = EvaluaTipodeConsulta(opcionesdebusqueda);
            if (tipo_consulta != 0)
            {
                data_members.pa_obtener_nodoResult nodo = catalogos.nodo(id_usuario, id_nodo);

                rest_consulta rest_cnfg = new rest_consulta(nodo.usuario, nodo.contrasenia, nodo.url_servicio_rest, nodo.id, nodo.nodo, tipo_consulta, expediente, valor_trazable, new FncConsultaCallbackOk(ResultCallback), new FncConsultaCallbackError(ErrorResult));
                Thread th = new Thread(new ThreadStart(rest_cnfg.EjecutaRest_Consulta));
                th.Start();
                th.Join();
            }
            return response;
        }

        private static List<ConsultaStructure> response = new List<ConsultaStructure>();
        private static void ResultCallback(List<ConsultaStructure> result)
        {
            response.AddRange(result);
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