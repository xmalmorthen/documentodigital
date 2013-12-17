using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using scanndoc.classes;
using TramiteDigitalWeb.data_members;

namespace TramiteDigitalWeb.Models
{
    public class DatosdeUsuario
    {
        private int _id;
        public int Id {get {return _id;} set{_id = value;}}

        private string _usuario;
        public string Usuario {get {return _usuario;} set{_usuario = value;}}

        private string _apellido1;
        public string Apellido1 {get {return _apellido1;} set{_apellido1 = value;}}

        private string _apellido2;
        public string Apellido2 {get {return _apellido2;} set{_apellido2 = value;}}

        private string _nombres;
        public string Nombres {get {return _nombres;} set{_nombres = value;}}

        private string _cargo;
        public string Cargo { get { return _cargo; } set { _cargo = value; } }

        public string GetFullName {get {return Nombres + " " + Apellido1 + " " + Apellido2;}}

        private Boolean _activo;
        public Boolean Activo { get { return _activo; } set { _activo = value; } }

        private Boolean _esadministrador;
        public Boolean EsAdministrador { get { return _esadministrador; } set { _esadministrador = value; } }

        private System.Nullable<System.Guid> _tocken;
        public System.Nullable<System.Guid> tocken {get{return this._tocken;} set{this._tocken = value;} }
    }

    public class UsuarioLogeado
    {
        private Bd_Expedientes_WebDataContext bd = new Bd_Expedientes_WebDataContext();
        private ca_usuarios usuario = null;

        public Boolean Valida(string Usuario, string Contrasenia)
        {
            try
            {
                usuario = bd.ca_usuarios.SingleOrDefault(c => c.usuario.ToString().ToLower() == Usuario.ToString().ToLower());
                if (!convert_md5.verifyMd5Hash(Contrasenia, usuario.contrasenia))
                {
                    return false;
                }
                
                //asignar tocken
                usuario.tocken = Guid.NewGuid();
                bd.SubmitChanges();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public void EliminaTocken(int id_usuario) {
            try
            {
                usuario = bd.ca_usuarios.SingleOrDefault(c => c.id == id_usuario);
                if (usuario != null)
                {
                    usuario.tocken = null;
                    bd.SubmitChanges();
                }
                usuario = null;
            }
            catch (Exception)
            {             
            }
        }

        public DatosdeUsuario ObtenDatosdeUsuarioLogeado(int id_usuario)
        {
            usuario = bd.ca_usuarios.SingleOrDefault(c => c.id == id_usuario);
            return ObtenDatosdeUsuarioLogeado();
        }

        public DatosdeUsuario ObtenDatosdeUsuarioLogeado() {
            DatosdeUsuario datos = new DatosdeUsuario();
            datos.Id = usuario.id;
            datos.Usuario = usuario.usuario;
            datos.Nombres = usuario.nombres;
            datos.Apellido1 = usuario.apellido1;
            datos.Apellido2 = usuario.apellido2;
            datos.Cargo = usuario.cargo;
            datos.Activo = usuario.activo;
            datos.EsAdministrador = usuario.es_administrador;
            datos.tocken = usuario.tocken;
            return datos;
        } 
            
    }

    public static class Acceso {

        public static string[] Valida(string Data, Boolean TockenOnly = false)
        {
            string[] response = null;

            Bd_Expedientes_WebDataContext bd = new Bd_Expedientes_WebDataContext();
            int id_usuario = int.Parse(Data.Split('~')[1]);
            ca_usuarios usuario = bd.ca_usuarios.SingleOrDefault(query => query.id == id_usuario);

            if (!TockenOnly)
            {
                if (usuario.es_administrador != true)
                {
                    response = new string[] { "false", "Permisos insuficientes, favor de iniciar sesión con un usuario válido" };
                }
            }
            if (usuario.tocken.ToString() != Data.Split('~')[3]) {
                response = new string[] { "false", "Su vigencia ha expirado debido a que se ha iniciado sesión en otra ubicación con el mismo usuario" };
            }
            if (response == null) {
                response = new string[] { "true" };
            }
            usuario = null;
            bd.Dispose();

            return response;
        }    
    }
    
}