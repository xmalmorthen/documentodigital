﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.18052
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace apiRest.data_members
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Bd_Expedientes_Digitales")]
	public partial class Bd_Expedientes_DigitalesDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Definiciones de métodos de extensibilidad
    partial void OnCreated();
    #endregion
		
		public Bd_Expedientes_DigitalesDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["Bd_Expedientes_DigitalesConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public Bd_Expedientes_DigitalesDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public Bd_Expedientes_DigitalesDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public Bd_Expedientes_DigitalesDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public Bd_Expedientes_DigitalesDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<vw_ListaExpedientes> vw_ListaExpedientes
		{
			get
			{
				return this.GetTable<vw_ListaExpedientes>();
			}
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.pa_ConsultaTramitesporValorTrazable")]
		public ISingleResult<pa_ConsultaTramitesporValorTrazableResult> pa_ConsultaTramitesporValorTrazable([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(200)")] string valor_trazable)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), valor_trazable);
			return ((ISingleResult<pa_ConsultaTramitesporValorTrazableResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.pa_ConsultaTramitesporExpedienteyValorTrazable")]
		public ISingleResult<pa_ConsultaTramitesporExpedienteyValorTrazableResult> pa_ConsultaTramitesporExpedienteyValorTrazable([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> id_expediente, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(200)")] string valor_trazable)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), id_expediente, valor_trazable);
			return ((ISingleResult<pa_ConsultaTramitesporExpedienteyValorTrazableResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.pa_CampostrazablesRegistradosporId_ma_digital")]
		public ISingleResult<pa_CampostrazablesRegistradosporId_ma_digitalResult> pa_CampostrazablesRegistradosporId_ma_digital([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> id_ma_digital)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), id_ma_digital);
			return ((ISingleResult<pa_CampostrazablesRegistradosporId_ma_digitalResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.pa_RegistrosDigitalesRegistradosporId_ma_digital")]
		public ISingleResult<pa_RegistrosDigitalesRegistradosporId_ma_digitalResult> pa_RegistrosDigitalesRegistradosporId_ma_digital([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> id_ma_digital)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), id_ma_digital);
			return ((ISingleResult<pa_RegistrosDigitalesRegistradosporId_ma_digitalResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.pa_ImagenDigitalporId_de_digital")]
		public ISingleResult<pa_ImagenDigitalporId_de_digitalResult> pa_ImagenDigitalporId_de_digital([global::System.Data.Linq.Mapping.ParameterAttribute(Name="Id_de_digital", DbType="Int")] System.Nullable<int> id_de_digital)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), id_de_digital);
			return ((ISingleResult<pa_ImagenDigitalporId_de_digitalResult>)(result.ReturnValue));
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.vw_ListaExpedientes")]
	public partial class vw_ListaExpedientes
	{
		
		private int _id;
		
		private string _Descripcion;
		
		public vw_ListaExpedientes()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", AutoSync=AutoSync.Always, DbType="Int NOT NULL IDENTITY", IsDbGenerated=true)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Descripcion", DbType="VarChar(500) NOT NULL", CanBeNull=false)]
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
	
	public partial class pa_ConsultaTramitesporValorTrazableResult
	{
		
		private int _id_ma_digital;
		
		private System.Nullable<int> _id_estatus;
		
		private System.DateTime _fecha_hora_creacion;
		
		private string _nota;
		
		private string _tramite;
		
		private string _expediente;
		
		private int _id_tramite;
		
		public pa_ConsultaTramitesporValorTrazableResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_ma_digital", DbType="Int NOT NULL")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_estatus", DbType="Int")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_fecha_hora_creacion", DbType="DateTime NOT NULL")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nota", DbType="Text", UpdateCheck=UpdateCheck.Never)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_tramite", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_expediente", DbType="VarChar(500) NOT NULL", CanBeNull=false)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_tramite", DbType="Int NOT NULL")]
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
	
	public partial class pa_ConsultaTramitesporExpedienteyValorTrazableResult
	{
		
		private int _id_ma_digital;
		
		private System.Nullable<int> _id_estatus;
		
		private System.DateTime _fecha_hora_creacion;
		
		private string _nota;
		
		private string _tramite;
		
		private string _expediente;
		
		private int _id_tramite;
		
		public pa_ConsultaTramitesporExpedienteyValorTrazableResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_ma_digital", DbType="Int NOT NULL")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_estatus", DbType="Int")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_fecha_hora_creacion", DbType="DateTime NOT NULL")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nota", DbType="Text", UpdateCheck=UpdateCheck.Never)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_tramite", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_expediente", DbType="VarChar(500) NOT NULL", CanBeNull=false)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_tramite", DbType="Int NOT NULL")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_re_expediente_campotrazable", DbType="Int NOT NULL")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_campotrazable", DbType="Int NOT NULL")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nombre", DbType="VarChar(200) NOT NULL", CanBeNull=false)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Tamanio_Caracteres", DbType="Int NOT NULL")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_estatus", DbType="Int NOT NULL")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Mascara", DbType="VarChar(200)")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_es_principal", DbType="Bit NOT NULL")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_valor_trazable", DbType="VarChar(200) NOT NULL", CanBeNull=false)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", DbType="Int NOT NULL")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_thumbnail", DbType="Image NOT NULL", CanBeNull=false)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_re_clasificaciondocumento_documento", DbType="Int NOT NULL")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_fecha_hora_creacion", DbType="DateTime NOT NULL")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_valor_trazable", DbType="VarChar(200)")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_clasificaciondocumento", DbType="VarChar(500) NOT NULL", CanBeNull=false)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Documento", DbType="VarChar(500) NOT NULL", CanBeNull=false)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_origen", DbType="Int")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Origen", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
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
	
	public partial class pa_ImagenDigitalporId_de_digitalResult
	{
		
		private int _id_re_clasificaciondocumento_documento;
		
		private System.DateTime _fecha_hora_creacion;
		
		private string _valor_trazable;
		
		private string _clasificaciondocumento;
		
		private string _Documento;
		
		private System.Nullable<int> _id_origen;
		
		private string _Origen;
		
		private System.Data.Linq.Binary _imagen;
		
		public pa_ImagenDigitalporId_de_digitalResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_re_clasificaciondocumento_documento", DbType="Int NOT NULL")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_fecha_hora_creacion", DbType="DateTime NOT NULL")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_valor_trazable", DbType="VarChar(200)")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_clasificaciondocumento", DbType="VarChar(500) NOT NULL", CanBeNull=false)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Documento", DbType="VarChar(500) NOT NULL", CanBeNull=false)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_origen", DbType="Int")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Origen", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_imagen", DbType="Image NOT NULL", CanBeNull=false)]
		public System.Data.Linq.Binary imagen
		{
			get
			{
				return this._imagen;
			}
			set
			{
				if ((this._imagen != value))
				{
					this._imagen = value;
				}
			}
		}
	}
}
#pragma warning restore 1591
