using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TramiteDigitalWeb.Models.classes
{
    public partial class vw_ListaExpedientes
    {

        private int _id;
        private string _Descripcion;

        public vw_ListaExpedientes()
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

        public string Descripcion
        {
            get
            {
                return this._Descripcion;
            }
            set
            {
                if ((this._Descripcion != value))
                {
                    this._Descripcion = value;
                }
            }
        }
    }
}