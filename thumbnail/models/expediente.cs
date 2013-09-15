using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace scanndoc.models
{
    public class tramite_model {

        private int _id_re_expediente_tramite;
        public int id_re_expediente_tramite { get { return _id_re_expediente_tramite; } set { _id_re_expediente_tramite = value; } }

        private string _nota;
        public string nota { get { return _nota; } set { _nota = value; } }

        private DateTime _fecha_hora_bloqueo;
        public DateTime fecha_hora_bloqueo { get { return _fecha_hora_bloqueo; } set { _fecha_hora_bloqueo = value; } }

        private int _id_estatus;
        public int id_estatus { get { return _id_estatus; } set { _id_estatus = value; } }

        private List<trazabilidad_tramite> _trazabilidad = new List<trazabilidad_tramite>();
        public List<trazabilidad_tramite> trazabilidad
        {
            get
            {
                return _trazabilidad;
            }
            set
            {
                _trazabilidad = value;
            }
        }

        private List<digital> _imagenes_digital = new List<digital>();
        public List<digital> imagenes_digital
        {
            get
            {
                return _imagenes_digital;
            }
            set
            {
                _imagenes_digital = value;
            }
        }
    }


    public class trazabilidad_tramite {
        private int _id_re_expediente_campotrazable;
        public int id_re_expediente_campotrazable
        {
            get
            {
                return _id_re_expediente_campotrazable;
            }
            set
            {
                _id_re_expediente_campotrazable = value;
            }
        }

        private string _valor_trazable;
        public string valor_trazable
        {
            get
            {
                return _valor_trazable;
            }
            set
            {
                _valor_trazable = value;
            }
        }
    }

    public class digital
    {
        private string _guid;
        public string guid
        {
            get
            {
                return _guid;
            }
            set
            {
                _guid = value;
            }
        }

        private int _id_re_clasificaciondocumento_documento;
        public int id_re_clasificaciondocumento_documento
        {
            get
            {
                return _id_re_clasificaciondocumento_documento;
            }
            set
            {
                _id_re_clasificaciondocumento_documento = value;
            }
        }

        private byte[] _thumbnail;
        public byte[] thumbnail
        {
            get
            {
                return _thumbnail;
            }
            set
            {
                _thumbnail = value;
            }
        }

        private byte[] _imagen;
        public byte[] imagen
        {
            get
            {
                return _imagen;
            }
            set
            {
                _imagen = value;
            }
        }

        private string _valor_trazable;
        public string valor_trazable
        {
            get
            {
                return _valor_trazable;
            }
            set
            {
                _valor_trazable = value;
            }
        }

        //otras propertys necesarias para el flujo de representacion de informacion
        private string _clasificaciondocumento;
        public string clasificaciondocumento
        {
            get
            {
                return _clasificaciondocumento;
            }
            set
            {
                _clasificaciondocumento = value;
            }
        }

        private string _documento;
        public string documento
        {
            get
            {
                return _documento;
            }
            set
            {
                _documento = value;
            }
        }

        private Boolean _enlazado;
        public Boolean enlazado
        {
            get
            {
                return _enlazado;
            }
            set
            {
                _enlazado = value;
            }
        }

        private Boolean _editado;
        public Boolean editado
        {
            get
            {
                return _editado;
            }
            set
            {
                _editado = value;
            }
        }

        //utilizado para indicar si el documento fue añadido en tiempo de edicion
        private Boolean _aniadido;
        public Boolean aniadido
        {
            get
            {
                return _aniadido;
            }
            set
            {
                _aniadido = value;
            }
        }

        private int _id_de_digital;
        public int id_de_digital
        {
            get
            {
                return _id_de_digital;
            }
            set
            {
                _id_de_digital = value;
            }
        }
    }
}
