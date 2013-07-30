using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace thumbnail.models
{

    public class de_expedientestrazables {
        private int _id_campotrazable;
        public int id_campotrazable
        {
            get
            {
                return _id_campotrazable;
            }
            set
            {
                _id_campotrazable = value;
            }
        }

        private string _campotrazable;
        public string campotrazable
        {
            get
            {
                return _campotrazable;
            }
            set
            {
                _campotrazable = value;
            }
        }

        private string _mask;
        public string mask
        {
            get
            {
                return _mask;
            }
            set
            {
                _mask = value;
            }
        }


        private int _numcaracteres;
        public int numcaracteres
        {
            get
            {
                return _numcaracteres;
            }
            set
            {
                _numcaracteres = value;
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

        private DateTime _fecha_creacion;
        public DateTime fecha_creacion
        {
            get
            {
                return _fecha_creacion;
            }
            set
            {
                _fecha_creacion = value;
            }
        }

        private Boolean _es_principal;
        public Boolean es_principal
        {
            get
            {
                return _es_principal;
            }
            set
            {
                _es_principal = value;
            }
        }
    } 

    public class expediente_model
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

        private int _id_resguardo;
        public int id_resguardo
        {
            get
            {
                return _id_resguardo;
            }
            set
            {
                _id_resguardo = value;
            }
        }

        private DateTime _fecha_creacion;
        public DateTime fecha_creacion
        {
            get
            {
                return _fecha_creacion;
            }
            set
            {
                _fecha_creacion = value;
            }
        }

        private List<de_expedientestrazables> _expedientetrazable = new List<de_expedientestrazables>();
        public List<de_expedientestrazables> expedientetrazable
        {
            get
            {
                return _expedientetrazable;
            }
            set
            {
                _expedientetrazable = value;
            }
        }

    }
}
