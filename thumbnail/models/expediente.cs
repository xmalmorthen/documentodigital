using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace thumbnail.models
{

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
        private int _id_tramite;
        public int idtramite {
            get {
                return _id_tramite;
            }
            set {
                _id_tramite = value;
            }
        }

        private int _id_documento;
        public int id_documento
        {
            get
            {
                return _id_documento;
            }
            set
            {
                _id_documento = value;
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

        private List<trazabilidad_tramite> _trazabilidad_tramite = new List<trazabilidad_tramite>();
        public List<trazabilidad_tramite> trazabilidad_tramite
        {
            get
            {
                return _trazabilidad_tramite;
            }
            set
            {
                _trazabilidad_tramite = value;
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
