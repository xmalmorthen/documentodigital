using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TramiteDigitalWeb.Models.classes
{
    public partial class pa_CampostrazablesRegistradosporId_ma_digitalResult
    {

        private int _id_re_expediente_campotrazable;

        private int _id_campotrazable;

        private string _Nombre;

        private int _Tamanio_Caracteres;

        private int _id_estatus;

        private string _Mascara;

        private bool _es_principal;

        private string _valor_trazable;

        public pa_CampostrazablesRegistradosporId_ma_digitalResult()
        {
        }

        public int id_re_expediente_campotrazable
        {
            get
            {
                return this._id_re_expediente_campotrazable;
            }
            set
            {
                if ((this._id_re_expediente_campotrazable != value))
                {
                    this._id_re_expediente_campotrazable = value;
                }
            }
        }

        public int id_campotrazable
        {
            get
            {
                return this._id_campotrazable;
            }
            set
            {
                if ((this._id_campotrazable != value))
                {
                    this._id_campotrazable = value;
                }
            }
        }

        public string Nombre
        {
            get
            {
                return this._Nombre;
            }
            set
            {
                if ((this._Nombre != value))
                {
                    this._Nombre = value;
                }
            }
        }

        public int Tamanio_Caracteres
        {
            get
            {
                return this._Tamanio_Caracteres;
            }
            set
            {
                if ((this._Tamanio_Caracteres != value))
                {
                    this._Tamanio_Caracteres = value;
                }
            }
        }

        public int id_estatus
        {
            get
            {
                return this._id_estatus;
            }
            set
            {
                if ((this._id_estatus != value))
                {
                    this._id_estatus = value;
                }
            }
        }

        public string Mascara
        {
            get
            {
                return this._Mascara;
            }
            set
            {
                if ((this._Mascara != value))
                {
                    this._Mascara = value;
                }
            }
        }

        public bool es_principal
        {
            get
            {
                return this._es_principal;
            }
            set
            {
                if ((this._es_principal != value))
                {
                    this._es_principal = value;
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
    }

    public partial class pa_RegistrosDigitalesRegistradosporId_ma_digitalResult
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

        public pa_RegistrosDigitalesRegistradosporId_ma_digitalResult()
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