using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TramiteDigitalWeb.Models.classes
{
    public partial class ConsultaStructure
    {
        private int _id_ma_digital;
		
		private System.Nullable<int> _id_estatus;
		
		private System.DateTime _fecha_hora_creacion;
		
		private string _nota;
		
		private string _tramite;
		
		private string _expediente;
		
		private int _id_tramite;

        public ConsultaStructure()
		{
		}
		
		public int id_ma_digital
		{
			get
			{
				return this._id_ma_digital;
			}
			set
			{
				if ((this._id_ma_digital != value))
				{
					this._id_ma_digital = value;
				}
			}
		}
		
		public System.Nullable<int> id_estatus
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
		
		public string nota
		{
			get
			{
				return this._nota;
			}
			set
			{
				if ((this._nota != value))
				{
					this._nota = value;
				}
			}
		}
		
		public string tramite
		{
			get
			{
				return this._tramite;
			}
			set
			{
				if ((this._tramite != value))
				{
					this._tramite = value;
				}
			}
		}
		
		public string expediente
		{
			get
			{
				return this._expediente;
			}
			set
			{
				if ((this._expediente != value))
				{
					this._expediente = value;
				}
			}
		}
		
		public int id_tramite
		{
			get
			{
				return this._id_tramite;
			}
			set
			{
				if ((this._id_tramite != value))
				{
					this._id_tramite = value;
				}
			}
		}
        
    }
}