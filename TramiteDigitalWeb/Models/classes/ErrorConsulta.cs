using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TramiteDigitalWeb.Models.classes
{
    public partial class ErrorConsulta
    {
        private int? _id_nodo;
        private string _nodo;
        private string _StatusDescription;
        private string _StatusCode;

        public ErrorConsulta(int? _id_nodo, string _nodo, string _StatusDescription, string _StatusCode)
		{
            id_nodo = id_nodo;
            nodo = _nodo;
            StatusDescription = _StatusDescription;
            StatusCode = _StatusCode;
		}

        public int? id_nodo
        {
            get
            {
                return this._id_nodo;
            }
            set
            {
                if ((this._id_nodo != value))
                {
                    this._id_nodo = value;
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

        public string StatusDescription
        {
            get
            {
                return this._StatusDescription;
            }
            set
            {
                if ((this._StatusDescription != value))
                {
                    this._StatusDescription = value;
                }
            }
        }

        public string StatusCode
        {
            get
            {
                return this._StatusCode;
            }
            set
            {
                if ((this._StatusCode != value))
                {
                    this._StatusCode = value;
                }
            }
        }

    }
}