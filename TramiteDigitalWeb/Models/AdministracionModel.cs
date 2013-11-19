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
    public static class AdministracionModel { 
        
        private static Bd_Expedientes_WebDataContext bd = new Bd_Expedientes_WebDataContext();

        public static Boolean ValidaPermisodeUsuario(int id_usuario){
            ca_usuarios usuario = bd.ca_usuarios.SingleOrDefault(query => query.id == id_usuario && query.es_administrador == true);
            if (usuario != null)
                return true;
            else
                return false;
        }

        public static List<ca_usuarios> ListadeUsuarios() {
            return bd.GetTable<ca_usuarios>().ToList();
        }

        public static Boolean CrearUsuario(ca_usuarios data) {
            try
            {
                bd.ca_usuarios.InsertOnSubmit(data);
                bd.SubmitChanges();
            }
            catch (Exception)
            {
                return false;
            }
            return true;        
        }

    }    
}