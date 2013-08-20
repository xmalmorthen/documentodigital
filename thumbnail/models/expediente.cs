using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace thumbnail.models
{
    public class tramite_model {
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

        private string _fecha;
        public string fecha
        {
            get
            {
                return _fecha;
            }
            set
            {
                _fecha = value;
            }
        }

        private string _hora;
        public string hora
        {
            get
            {
                return _hora;
            }
            set
            {
                _hora = value;
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

        private Image _imagen;
        public Image imagen
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

        private string _fecha;
        public string fecha
        {
            get
            {
                return _fecha;
            }
            set
            {
                _fecha = value;
            }
        }

        private string _hora;
        public string hora
        {
            get
            {
                return _hora;
            }
            set
            {
                _hora = value;
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
        
    }
}
