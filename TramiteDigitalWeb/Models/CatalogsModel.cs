using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RestSharp;
using Newtonsoft.Json;
using TramiteDigitalWeb.Models.classes;
using System.Security.Principal;
using System.Threading;
using TramiteDigitalWeb.data_members;

namespace TramiteDigitalWeb.Models
{
    public delegate void FncCallback(List<vw_ListaExpedientes> result);

    public class rest_expedientes
    {
        protected string _usuario;
        protected string _contrasenia;
        protected string _url_servicio_rest;

        protected FncCallback _callback = null;

        public rest_expedientes( string usuario, string contrasenia, string url_servicio_rest, FncCallback callback)
        {
            this._usuario = usuario;
            this._contrasenia = contrasenia;
            this._url_servicio_rest = url_servicio_rest;
            this._callback = callback;
        }

        public void EjecutaRest_Expedientes()
        {
            try
            {
                string RESTWebApiUrl = this._url_servicio_rest;

                var client = new RestClient(RESTWebApiUrl);
                //client.Authenticator = new HttpBasicAuthenticator(this._usuario, this._contrasenia);
                var request = new RestRequest("catalogo/expedientes", Method.GET);
                request.AddHeader("Accept", "application/json");

                // execute the request
                IRestResponse response = client.Execute(request);
                var content = response.Content; // raw content as string

                List<vw_ListaExpedientes> items = JsonConvert.DeserializeObject<List<vw_ListaExpedientes>>(content);

                if (_callback != null) _callback(items);    
            }
            catch (Exception)
            {
                throw;
            }
        }
    }

    public class CatalogsModel
    {
        public IEnumerable<data_members.pa_obtener_nodosResult> nodos(int id_usuario) {
            try
            {
                data_members.Bd_Expedientes_WebDataContext bd = new data_members.Bd_Expedientes_WebDataContext();
                List<pa_obtener_nodosResult> nodos = new List<pa_obtener_nodosResult>();
                nodos.AddRange(bd.pa_obtener_nodos(id_usuario).ToList());
                bd.Dispose();
                return nodos;
            }
            catch (Exception)
            {                
                throw;
            }
        }

        public data_members.pa_obtener_nodoResult nodo(int id_usuario, int id_nodo)
        {
            try
            {
                data_members.Bd_Expedientes_WebDataContext bd = new data_members.Bd_Expedientes_WebDataContext();
                pa_obtener_nodoResult nodo = new pa_obtener_nodoResult();
                
                pa_obtener_nodoResult tmp = bd.pa_obtener_nodo(id_usuario, id_nodo).SingleOrDefault();

                nodo.activo = tmp.activo;
                nodo.contrasenia = tmp.contrasenia;
                nodo.id = tmp.id;
                nodo.nodo = tmp.nodo;
                nodo.url_servicio_rest = tmp.url_servicio_rest;
                nodo.usuario = tmp.usuario;

                bd.Dispose();
                tmp = null;

                return nodo;
            }
            catch (Exception)
            {
                 throw;
            }
        }

        public List<vw_ListaExpedientes> obtenerExpedientes(int id_nodo, List<data_members.pa_obtener_nodosResult> nodos)
        {
            if (id_nodo == 0)
            {
                //buscar en todos los nodos
                foreach (data_members.pa_obtener_nodosResult item in nodos)
                {
                    rest_expedientes rest_cnfg = new rest_expedientes(item.usuario, item.contrasenia, item.url_servicio_rest, new FncCallback(ResultCallback));
                    Thread th = new Thread(new ThreadStart(rest_cnfg.EjecutaRest_Expedientes));
                    th.Start();
                    th.Join();
                }
            }
            else
            {
                //buscar en nodo determinado            
                data_members.pa_obtener_nodosResult item = nodos.Single(query => query.id == id_nodo);
                rest_expedientes rest_cnfg = new rest_expedientes(item.usuario, item.contrasenia, item.url_servicio_rest, new FncCallback(ResultCallback));
                Thread th = new Thread(new ThreadStart(rest_cnfg.EjecutaRest_Expedientes));
                th.Start();
                th.Join();

            }

            return lista_expedientes;
        }

        private List<vw_ListaExpedientes> lista_expedientes = new List<vw_ListaExpedientes>();
        private void ResultCallback(List<vw_ListaExpedientes> result)
        {
            this.lista_expedientes.AddRange(result);
        }

    }
}