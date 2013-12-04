using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TramiteDigitalWeb.Models.classes
{
    public partial class Nodo_Structure
    {
        private int _id;
        private string _nodo;
        private string _url_servicio_rest;
        private string _usuario;
        private string _contrasenia;
        private bool _activo;
        private string _fecha_registro;

        public Nodo_Structure()
        {
        }

        public int id
        {
            get
            {
                return this._id;
            }
            set
            {
                if ((this._id != value))
                {
                    this._id = value;
                }
            }
        }

        public string nodo
        {
            get
            {
                return this._nodo;
            }
            set
            {
                if ((this._nodo != value))
                {
                    this._nodo = value;
                }
            }
        }

        public string url_servicio_rest
        {
            get
            {
                return this._url_servicio_rest;
            }
            set
            {
                if ((this._url_servicio_rest != value))
                {
                    this._url_servicio_rest = value;
                }
            }
        }

        public string usuario
        {
            get
            {
                return this._usuario;
            }
            set
            {
                if ((this._usuario != value))
                {
                    this._usuario = value;
                }
            }
        }

        public string contrasenia
        {
            get
            {
                return this._contrasenia;
            }
            set
            {
                if ((this._contrasenia != value))
                {
                    this._contrasenia = value;
                }
            }
        }

        public bool activo
        {
            get
            {
                return this._activo;
            }
            set
            {
                if ((this._activo != value))
                {
                    this._activo = value;
                }
            }
        }

        public String fecha_registro
        {
            get
            {
                return this._fecha_registro;
            }
            set
            {
                if ((this._fecha_registro != value))
                {
                    this._fecha_registro = value;
                }
            }
        }

    }
}