using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using scanndoc.classes;

namespace TramiteDigitalWeb.Models
{
    public class ModulodeAcceso
    {
        private int _id;
        public int Id {get {return _id;} set{_id = value;}}

        private string _modulo;
        public string Modulo { get { return _modulo; } set { _modulo = value; } }
    }

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

        private List<ModulodeAcceso> _modulos = new List<ModulodeAcceso>();
        public List<ModulodeAcceso> Modulos {get {return _modulos;} set{_modulos = value;}}
    }

    public class UsuarioLogeado
    {
        private data_members.Bd_Exp_TransportesDataContext bd = new data_members.Bd_Exp_TransportesDataContext();
        private data_members.ca_usuarios usuario = null;

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

        public DatosdeUsuario ObtenDatosdeUsuarioLogeado() {
            DatosdeUsuario datos = new DatosdeUsuario();
            datos.Id = usuario.id;
            datos.Usuario = usuario.usuario;
            datos.Nombres = usuario.Nombres;
            datos.Apellido1 = usuario.Apellido1;
            datos.Apellido2 = usuario.Apellido2;
            datos.Cargo = usuario.ca_cargo_puesto.Descripcion;

            foreach (data_members.re_usuarios_roles_permisos item in usuario.re_usuarios_roles_permisos)
	        {
                foreach (data_members.re_roles_modulos modulo in item.ca_roles.re_roles_modulos)
                { 
                    ModulodeAcceso mod = new ModulodeAcceso();
                    mod.Id = modulo.ca_modulos.id;
                    mod.Modulo = modulo.ca_modulos.Modulo;
                    datos.Modulos.Add(mod);
                }
	        }
            return datos;
        } 
    }
}