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
                return true;

            }
            catch (Exception)
            {
                return false;
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
            return datos;
        } 
    
        
    }
}