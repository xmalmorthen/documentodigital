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
#region Usuarios
        
        public static List<ca_usuarios> ListadeUsuarios() {
            Bd_Expedientes_WebDataContext bd = new Bd_Expedientes_WebDataContext();
            List<ca_usuarios> usuarios = bd.GetTable<ca_usuarios>().ToList();
            bd.Dispose();
            return usuarios;
        }

        public static Boolean? CrearUsuario(ca_usuarios data) {
            try
            {
                Boolean? verificacion = verifica_usuario(data.usuario);
                if (verificacion != null ) {
                    if (verificacion == false)
                    {
                        data.contrasenia = convert_md5.generate(data.contrasenia);
                        Bd_Expedientes_WebDataContext bd = new Bd_Expedientes_WebDataContext();
                        bd.ca_usuarios.InsertOnSubmit(data);
                        bd.SubmitChanges();
                        bd.Dispose();
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
            Boolean? response = null;
            Bd_Expedientes_WebDataContext bd = new Bd_Expedientes_WebDataContext();
            try
            {                
                if (bd.ca_usuarios.Count(query => query.usuario == usuario) > 0)
                {
                    response = true;
                }
                else 
                {
                    response =  false;
                }
            }
            catch (Exception)
            {
                response = null;
            }
            bd.Dispose();
            return response;
        }

        public static ca_usuarios Get_Usuario(int id) {
            try
            {
                Bd_Expedientes_WebDataContext bd = new Bd_Expedientes_WebDataContext();
                ca_usuarios usuario = bd.ca_usuarios.SingleOrDefault(query => query.id == id);
                bd.Dispose();
                return usuario;
            }
            catch (Exception)
            {
                return null;
            }            
        }

        public static List<Nodo_Structure> Get_NodosUsuario(int id_usuario)
        {
            try
            {
                Bd_Expedientes_WebDataContext bd = new Bd_Expedientes_WebDataContext();
                List<re_nodos_usuarios> nodos_usuarios = (from query in bd.re_nodos_usuarios
                                                         where query.id_usuario == id_usuario && query.activo == true
                                                         select query).ToList();

                List<Nodo_Structure> nodos = new List<Nodo_Structure>();
                foreach (re_nodos_usuarios item in nodos_usuarios)
                {
                    nodos.Add(new Nodo_Structure()
                    {
                        activo = item.ca_nodos.activo,
                        contrasenia = item.ca_nodos.contrasenia,
                        fecha_registro = item.ca_nodos.fecha_registro.ToString(),
                        id = item.ca_nodos.id,
                        nodo = item.ca_nodos.nodo,
                        url_servicio_rest = item.ca_nodos.url_servicio_rest,
                        usuario = item.ca_nodos.usuario
                    });
                };

                bd.Dispose();
                return nodos;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static Boolean Edita_Usuario(ca_usuarios data) {
            try
            {
                Bd_Expedientes_WebDataContext bd = new Bd_Expedientes_WebDataContext();
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
                bd.Dispose();
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
                Bd_Expedientes_WebDataContext bd = new Bd_Expedientes_WebDataContext();
                ca_usuarios usuario = bd.ca_usuarios.SingleOrDefault(query => query.id == data.id);
                usuario.contrasenia = data.contrasenia = convert_md5.generate(data.contrasenia);
                bd.SubmitChanges();
                bd.Dispose();
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
                Bd_Expedientes_WebDataContext bd = new Bd_Expedientes_WebDataContext();
                ca_usuarios usuario = bd.ca_usuarios.SingleOrDefault(query => query.id == id_usuario);
                bd.ca_usuarios.DeleteOnSubmit(usuario);
                bd.SubmitChanges();
                bd.Dispose();
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
            Bd_Expedientes_WebDataContext bd = new Bd_Expedientes_WebDataContext();
            List<ca_nodos> nodos = bd.GetTable<ca_nodos>().ToList();
            bd.Dispose();
            return nodos;
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
                        Bd_Expedientes_WebDataContext bd = new Bd_Expedientes_WebDataContext();
                        bd.ca_nodos.InsertOnSubmit(data);
                        bd.SubmitChanges();
                        bd.Dispose();
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
            Boolean? response = null;
            Bd_Expedientes_WebDataContext bd = new Bd_Expedientes_WebDataContext();
            try
            {
                
                if (bd.ca_nodos.Count(query => query.nodo == nodo) > 0)
                {
                    response = true;
                }
                else
                {
                    response = false;
                }
            }
            catch (Exception)
            {
                response = null;
            }
            bd.Dispose();
            return response;
        }

        public static ca_nodos Get_Nodo(int id)
        {
            try
            {
                Bd_Expedientes_WebDataContext bd = new Bd_Expedientes_WebDataContext();
                ca_nodos nodo = bd.ca_nodos.SingleOrDefault(query => query.id == id);
                bd.Dispose();
                return nodo;
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
                Bd_Expedientes_WebDataContext bd = new Bd_Expedientes_WebDataContext();
                ca_nodos nodo = bd.ca_nodos.SingleOrDefault(query => query.id == data.id);
                nodo.activo = data.activo;
                nodo.contrasenia = nodo.contrasenia != data.contrasenia ? convert_md5.generate(data.contrasenia) : nodo.contrasenia;
                nodo.url_servicio_rest = data.url_servicio_rest;
                nodo.usuario = data.usuario;
                bd.SubmitChanges();
                bd.Dispose();
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
                Bd_Expedientes_WebDataContext bd = new Bd_Expedientes_WebDataContext();
                ca_nodos usuario = bd.ca_nodos.SingleOrDefault(query => query.id == id_nodo);
                bd.ca_nodos.DeleteOnSubmit(usuario);
                bd.SubmitChanges();
                bd.Dispose();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public static List<pa_obtener_nodos_no_enlazadosResult> Lista_de_Nodos_No_Enlazados(int id_usuario) {
            Bd_Expedientes_WebDataContext bd = new Bd_Expedientes_WebDataContext();
            List<pa_obtener_nodos_no_enlazadosResult> nodos = bd.pa_obtener_nodos_no_enlazados(id_usuario).ToList();
            bd.Dispose();
            return nodos;
        }

        public static Boolean Asocia_Nodo(int id_usuario, int id_nodo)
        {
            try
            {
                re_nodos_usuarios asocia = new re_nodos_usuarios();
                asocia.activo = true;
                asocia.id_nodo = id_nodo;
                asocia.id_usuario = id_usuario;
                Bd_Expedientes_WebDataContext bd = new Bd_Expedientes_WebDataContext();
                bd.re_nodos_usuarios.InsertOnSubmit(asocia);
                bd.SubmitChanges();
                bd.Dispose();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public static Boolean Desasocia_Nodo_Ajax(int id_usuario, int id_nodo)
        {
            try
            {
                re_nodos_usuarios asocia = new re_nodos_usuarios();
                Bd_Expedientes_WebDataContext bd = new Bd_Expedientes_WebDataContext();
                asocia = bd.re_nodos_usuarios.SingleOrDefault(query => query.id_usuario == id_usuario && query.id_nodo == id_nodo && query.activo == true);
                asocia.activo = false;
                bd.SubmitChanges();
                bd.Dispose();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

#endregion Nodos

    }    
}