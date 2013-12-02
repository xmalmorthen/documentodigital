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

        public static Boolean? CrearUsuario(ca_usuarios data) {
            try
            {
                Boolean? verificacion = verifica_usuario(data.usuario);
                if (verificacion != null ) {
                    if (verificacion == false)
                    {
                        bd.ca_usuarios.InsertOnSubmit(data);
                        bd.SubmitChanges();
                    }
                    else {
                        return false;
                    }
                }
            }
            catch (Exception)
            {
                return null;
            }
            return null;
        }

        private static bool? verifica_usuario(string usuario)
        {
            try
            {
                if (bd.ca_usuarios.Count(query => query.usuario == usuario) > 0)
                {
                    return true;
                }
                else 
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return null;
            }    
        }

        public static ca_usuarios Get_Usuario(int id) {
            try
            {
                return bd.ca_usuarios.SingleOrDefault(query => query.id == id);
            }
            catch (Exception)
            {
                return null;
            }            
        }

        public static Boolean Edita_Usuario(ca_usuarios data) {
            try
            {
                ca_usuarios usuario = bd.ca_usuarios.SingleOrDefault(query => query.id == data.id);
                usuario.activo = data.activo;
                usuario.apellido1 = data.apellido1;
                usuario.apellido2 = data.apellido2;
                usuario.cargo = data.cargo;
                usuario.contrasenia = data.contrasenia;
                usuario.curp = data.curp;
                usuario.es_administrador = data.es_administrador;
                usuario.nombres = data.nombres;
                usuario.telefono = data.telefono;
                bd.SubmitChanges();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public static Boolean Cambia_Contrasenia(ca_usuarios data)
        {
            try
            {
                ca_usuarios usuario = bd.ca_usuarios.SingleOrDefault(query => query.id == data.id);
                usuario.contrasenia = data.contrasenia;
                bd.SubmitChanges();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }


        public static Boolean Elimina_Usuario(int id_usuario)
        {
            try
            {
                ca_usuarios usuario = bd.ca_usuarios.SingleOrDefault(query => query.id == id_usuario);
                bd.ca_usuarios.DeleteOnSubmit(usuario);
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