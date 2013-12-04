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
using scanndoc.classes;

namespace TramiteDigitalWeb.Models
{
    public static class AdministracionModel { 
        
        private static Bd_Expedientes_WebDataContext bd = new Bd_Expedientes_WebDataContext();

#region Usuarios

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
                        data.contrasenia = convert_md5.generate(data.contrasenia);
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
            return true;
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
                usuario.contrasenia = data.contrasenia = convert_md5.generate(data.contrasenia);
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

#endregion Usuarios

#region Nodos
        public static List<ca_nodos> ListadeNodos()
        {
            return bd.GetTable<ca_nodos>().ToList();
        }

        public static Boolean? CrearNodo(ca_nodos data)
        {
            try
            {
                Boolean? verificacion = verifica_nodo(data.nodo);
                if (verificacion != null)
                {
                    if (verificacion == false)
                    {
                        data.contrasenia = !String.IsNullOrEmpty(data.contrasenia) ? convert_md5.generate(data.contrasenia) : null;
                        bd.ca_nodos.InsertOnSubmit(data);
                        bd.SubmitChanges();
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (Exception)
            {
                return null;
            }
            return true;
        }

        private static bool? verifica_nodo(string nodo)
        {
            try
            {
                if (bd.ca_nodos.Count(query => query.nodo == nodo) > 0)
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

        public static ca_nodos Get_Nodo(int id)
        {
            try
            {
                return bd.ca_nodos.SingleOrDefault(query => query.id == id);
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static Boolean Edita_Nodo(ca_nodos data)
        {
            try
            {
                ca_nodos nodo = bd.ca_nodos.SingleOrDefault(query => query.id == data.id);
                nodo.activo = data.activo;
                nodo.contrasenia = nodo.contrasenia != data.contrasenia ? convert_md5.generate(data.contrasenia) : nodo.contrasenia;
                nodo.url_servicio_rest = data.url_servicio_rest;
                nodo.usuario = data.usuario;
                bd.SubmitChanges();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public static Boolean Elimina_Nodo(int id_nodo)
        {
            try
            {
                ca_nodos usuario = bd.ca_nodos.SingleOrDefault(query => query.id == id_nodo);
                bd.ca_nodos.DeleteOnSubmit(usuario);
                bd.SubmitChanges();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

#endregion Nodos

        public static List<pa_obtener_nodos_no_enlazadosResult> Lista_de_Nodos_No_Enlazados(int id_usuario) {
            return bd.pa_obtener_nodos_no_enlazados(id_usuario).ToList();
        }
    }    
}