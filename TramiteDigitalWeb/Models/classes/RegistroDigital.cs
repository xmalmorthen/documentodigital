using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TramiteDigitalWeb.Models.classes
{
    public partial class RegistrosDigital
    {

        private int _id;

        private System.Data.Linq.Binary _thumbnail;

        private int _id_re_clasificaciondocumento_documento;

        private System.DateTime _fecha_hora_creacion;

        private string _valor_trazable;

        private string _clasificaciondocumento;

        private string _Documento;

        private System.Nullable<int> _id_origen;

        private string _Origen;

        public RegistrosDigital()
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

        public System.Data.Linq.Binary thumbnail
        {
            get
            {
                return this._thumbnail;
            }
            set
            {
                if ((this._thumbnail != value))
                {
                    this._thumbnail = value;
                }
            }
        }

        public int id_re_clasificaciondocumento_documento
        {
            get
            {
                return this._id_re_clasificaciondocumento_documento;
            }
            set
            {
                if ((this._id_re_clasificaciondocumento_documento != value))
                {
                    this._id_re_clasificaciondocumento_documento = value;
                }
            }
        }

        public System.DateTime fecha_hora_creacion
        {
            get
            {
                return this._fecha_hora_creacion;
            }
            set
            {
                if ((this._fecha_hora_creacion != value))
                {
                    this._fecha_hora_creacion = value;
                }
            }
        }

        public string valor_trazable
        {
            get
            {
                return this._valor_trazable;
            }
            set
            {
                if ((this._valor_trazable != value))
                {
                    this._valor_trazable = value;
                }
            }
        }

        public string clasificaciondocumento
        {
            get
            {
                return this._clasificaciondocumento;
            }
            set
            {
                if ((this._clasificaciondocumento != value))
                {
                    this._clasificaciondocumento = value;
                }
            }
        }

        public string Documento
        {
            get
            {
                return this._Documento;
            }
            set
            {
                if ((this._Documento != value))
                {
                    this._Documento = value;
                }
            }
        }

        public System.Nullable<int> id_origen
        {
            get
            {
                return this._id_origen;
            }
            set
            {
                if ((this._id_origen != value))
                {
                    this._id_origen = value;
                }
            }
        }

        public string Origen
        {
            get
            {
                return this._Origen;
            }
            set
            {
                if ((this._Origen != value))
                {
                    this._Origen = value;
                }
            }
        }
    }
	
}