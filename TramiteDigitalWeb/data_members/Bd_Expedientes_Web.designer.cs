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

namespace TramiteDigitalWeb.data_members
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
    using System.ComponentModel.DataAnnotations;
    using System.Web.Mvc;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Bd_Expedientes_Web")]
	public partial class Bd_Expedientes_WebDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Definiciones de métodos de extensibilidad
    partial void OnCreated();
    partial void Insertca_nodos(ca_nodos instance);
    partial void Updateca_nodos(ca_nodos instance);
    partial void Deleteca_nodos(ca_nodos instance);
    partial void Insertre_nodos_usuarios(re_nodos_usuarios instance);
    partial void Updatere_nodos_usuarios(re_nodos_usuarios instance);
    partial void Deletere_nodos_usuarios(re_nodos_usuarios instance);
    partial void Insertca_usuarios(ca_usuarios instance);
    partial void Updateca_usuarios(ca_usuarios instance);
    partial void Deleteca_usuarios(ca_usuarios instance);
    #endregion
		
		public Bd_Expedientes_WebDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["Bd_Expedientes_WebConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public Bd_Expedientes_WebDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public Bd_Expedientes_WebDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public Bd_Expedientes_WebDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public Bd_Expedientes_WebDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<ca_nodos> ca_nodos
		{
			get
			{
				return this.GetTable<ca_nodos>();
			}
		}
		
		public System.Data.Linq.Table<re_nodos_usuarios> re_nodos_usuarios
		{
			get
			{
				return this.GetTable<re_nodos_usuarios>();
			}
		}
		
		public System.Data.Linq.Table<ca_usuarios> ca_usuarios
		{
			get
			{
				return this.GetTable<ca_usuarios>();
			}
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.pa_obtener_nodos")]
		public ISingleResult<pa_obtener_nodosResult> pa_obtener_nodos([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> id_usuario)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), id_usuario);
			return ((ISingleResult<pa_obtener_nodosResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.pa_obtener_nodo")]
		public ISingleResult<pa_obtener_nodoResult> pa_obtener_nodo([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> id_usuario, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> id_nodo)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), id_usuario, id_nodo);
			return ((ISingleResult<pa_obtener_nodoResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.pa_obtener_nodos_no_enlazados")]
		public ISingleResult<pa_obtener_nodos_no_enlazadosResult> pa_obtener_nodos_no_enlazados([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> id_usuario)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), id_usuario);
			return ((ISingleResult<pa_obtener_nodos_no_enlazadosResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.pa_Fecha")]
		public ISingleResult<pa_FechaResult> pa_Fecha()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((ISingleResult<pa_FechaResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.pa_Hora")]
		public ISingleResult<pa_HoraResult> pa_Hora()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((ISingleResult<pa_HoraResult>)(result.ReturnValue));
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.ca_nodos")]
	public partial class ca_nodos : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private string _nodo;
		
		private string _url_servicio_rest;
		
		private string _usuario;
		
		private string _contrasenia;
		
		private bool _activo;
		
        private System.DateTime _fecha_registro = default(System.DateTime);
		
		private EntitySet<re_nodos_usuarios> _re_nodos_usuarios;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OnnodoChanging(string value);
    partial void OnnodoChanged();
    partial void Onurl_servicio_restChanging(string value);
    partial void Onurl_servicio_restChanged();
    partial void OnusuarioChanging(string value);
    partial void OnusuarioChanged();
    partial void OncontraseniaChanging(string value);
    partial void OncontraseniaChanged();
    partial void OnactivoChanging(bool value);
    partial void OnactivoChanged();
    partial void Onfecha_registroChanging(System.DateTime value);
    partial void Onfecha_registroChanged();
    #endregion
		
		public ca_nodos()
		{
			this._re_nodos_usuarios = new EntitySet<re_nodos_usuarios>(new Action<re_nodos_usuarios>(this.attach_re_nodos_usuarios), new Action<re_nodos_usuarios>(this.detach_re_nodos_usuarios));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
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
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nodo", DbType="VarChar(200) NOT NULL", CanBeNull=false)]
        [Display(Name = "Nombre del nodo")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Campo requerido")]
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
					this.OnnodoChanging(value);
					this.SendPropertyChanging();
					this._nodo = value;
					this.SendPropertyChanged("nodo");
					this.OnnodoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_url_servicio_rest", DbType="VarChar(8000) NOT NULL", CanBeNull=false)]
        [Display(Name = "Ruta al servicio web del nodo")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Campo requerido")]
		public string url_servicio_rest
		{
			get
			{
				return this._url_servicio_rest;
			}
			set
			{
				if ((this._url_servicio_rest != value))
				{
					this.Onurl_servicio_restChanging(value);
					this.SendPropertyChanging();
					this._url_servicio_rest = value;
					this.SendPropertyChanged("url_servicio_rest");
					this.Onurl_servicio_restChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_usuario", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
        [Display(Name = "Nombre de usuario para ejecutar servicio web")]
		public string usuario
		{
			get
			{
				return this._usuario;
			}
			set
			{
				if ((this._usuario != value))
				{
					this.OnusuarioChanging(value);
					this.SendPropertyChanging();
					this._usuario = value;
					this.SendPropertyChanged("usuario");
					this.OnusuarioChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_contrasenia", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
        [Display(Name = "Contraseña para ejecutar servicio web")]
        [DataType(DataType.Password)]
		public string contrasenia
		{
			get
			{
				return this._contrasenia;
			}
			set
			{
				if ((this._contrasenia != value))
				{
					this.OncontraseniaChanging(value);
					this.SendPropertyChanging();
					this._contrasenia = value;
					this.SendPropertyChanged("contrasenia");
					this.OncontraseniaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_activo", DbType="Bit NOT NULL")]
        [Display(Name = "Nodo activo")]
		public bool activo
		{
			get
			{
				return this._activo;
			}
			set
			{
				if ((this._activo != value))
				{
					this.OnactivoChanging(value);
					this.SendPropertyChanging();
					this._activo = value;
					this.SendPropertyChanged("activo");
					this.OnactivoChanged();
				}
			}
		}
		
        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_fecha_registro", DbType = "DateTime NOT NULL", IsDbGenerated = true, UpdateCheck = UpdateCheck.Never)]
        [Display(Name = "Fecha/Hora de registro")]
		public System.DateTime fecha_registro
		{
			get
			{
				return this._fecha_registro;
			}
			set
			{
				if ((this._fecha_registro != value))
				{
					this.Onfecha_registroChanging(value);
					this.SendPropertyChanging();
					this._fecha_registro = value;
					this.SendPropertyChanged("fecha_registro");
					this.Onfecha_registroChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="ca_nodos_re_nodos_usuarios", Storage="_re_nodos_usuarios", ThisKey="id", OtherKey="id_nodo")]
		public EntitySet<re_nodos_usuarios> re_nodos_usuarios
		{
			get
			{
				return this._re_nodos_usuarios;
			}
			set
			{
				this._re_nodos_usuarios.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_re_nodos_usuarios(re_nodos_usuarios entity)
		{
			this.SendPropertyChanging();
			entity.ca_nodos = this;
		}
		
		private void detach_re_nodos_usuarios(re_nodos_usuarios entity)
		{
			this.SendPropertyChanging();
			entity.ca_nodos = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.re_nodos_usuarios")]
	public partial class re_nodos_usuarios : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private int _id_nodo;
		
		private int _id_usuario;
		
		private bool _activo;
		
        private System.DateTime _f_registro = default(System.DateTime);
		
		private EntityRef<ca_nodos> _ca_nodos;
		
		private EntityRef<ca_usuarios> _ca_usuarios;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void Onid_nodoChanging(int value);
    partial void Onid_nodoChanged();
    partial void Onid_usuarioChanging(int value);
    partial void Onid_usuarioChanged();
    partial void OnactivoChanging(bool value);
    partial void OnactivoChanged();
    partial void Onf_registroChanging(System.DateTime value);
    partial void Onf_registroChanged();
    #endregion
		
		public re_nodos_usuarios()
		{
			this._ca_nodos = default(EntityRef<ca_nodos>);
			this._ca_usuarios = default(EntityRef<ca_usuarios>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
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
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_nodo", DbType="Int NOT NULL")]
        [Display(Name = "Nodos")]
		public int id_nodo
		{
			get
			{
				return this._id_nodo;
			}
			set
			{
				if ((this._id_nodo != value))
				{
					if (this._ca_nodos.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.Onid_nodoChanging(value);
					this.SendPropertyChanging();
					this._id_nodo = value;
					this.SendPropertyChanged("id_nodo");
					this.Onid_nodoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_usuario", DbType="Int NOT NULL")]
        [Display(Name = "Usuarios")]
		public int id_usuario
		{
			get
			{
				return this._id_usuario;
			}
			set
			{
				if ((this._id_usuario != value))
				{
					if (this._ca_usuarios.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.Onid_usuarioChanging(value);
					this.SendPropertyChanging();
					this._id_usuario = value;
					this.SendPropertyChanged("id_usuario");
					this.Onid_usuarioChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_activo", DbType="Bit NOT NULL")]
		public bool activo
		{
			get
			{
				return this._activo;
			}
			set
			{
				if ((this._activo != value))
				{
					this.OnactivoChanging(value);
					this.SendPropertyChanging();
					this._activo = value;
					this.SendPropertyChanged("activo");
					this.OnactivoChanged();
				}
			}
		}
		
        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_f_registro", DbType = "DateTime NOT NULL", IsDbGenerated = true, UpdateCheck = UpdateCheck.Never)]
		public System.DateTime f_registro
		{
			get
			{
				return this._f_registro;
			}
			set
			{
				if ((this._f_registro != value))
				{
					this.Onf_registroChanging(value);
					this.SendPropertyChanging();
					this._f_registro = value;
					this.SendPropertyChanged("f_registro");
					this.Onf_registroChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="ca_nodos_re_nodos_usuarios", Storage="_ca_nodos", ThisKey="id_nodo", OtherKey="id", IsForeignKey=true)]
		public ca_nodos ca_nodos
		{
			get
			{
				return this._ca_nodos.Entity;
			}
			set
			{
				ca_nodos previousValue = this._ca_nodos.Entity;
				if (((previousValue != value) 
							|| (this._ca_nodos.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._ca_nodos.Entity = null;
						previousValue.re_nodos_usuarios.Remove(this);
					}
					this._ca_nodos.Entity = value;
					if ((value != null))
					{
						value.re_nodos_usuarios.Add(this);
						this._id_nodo = value.id;
					}
					else
					{
						this._id_nodo = default(int);
					}
					this.SendPropertyChanged("ca_nodos");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="ca_usuarios_re_nodos_usuarios", Storage="_ca_usuarios", ThisKey="id_usuario", OtherKey="id", IsForeignKey=true)]
		public ca_usuarios ca_usuarios
		{
			get
			{
				return this._ca_usuarios.Entity;
			}
			set
			{
				ca_usuarios previousValue = this._ca_usuarios.Entity;
				if (((previousValue != value) 
							|| (this._ca_usuarios.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._ca_usuarios.Entity = null;
						previousValue.re_nodos_usuarios.Remove(this);
					}
					this._ca_usuarios.Entity = value;
					if ((value != null))
					{
						value.re_nodos_usuarios.Add(this);
						this._id_usuario = value.id;
					}
					else
					{
						this._id_usuario = default(int);
					}
					this.SendPropertyChanged("ca_usuarios");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.ca_usuarios")]
	public partial class ca_usuarios : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private string _usuario;
		
		private string _contrasenia;
		
        private string _repetircontrasenia;

		private string _curp;
		
		private string _nombres;
		
		private string _apellido1;
		
		private string _apellido2;
		
		private string _telefono;
		
		private string _cargo;
		
		private bool _activo;
		
        private System.DateTime _f_registro = default(System.DateTime);
		
		private bool _es_administrador;
		
		private System.Nullable<System.Guid> _tocken;
		
		private EntitySet<re_nodos_usuarios> _re_nodos_usuarios;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OnusuarioChanging(string value);
    partial void OnusuarioChanged();
    partial void OncontraseniaChanging(string value);
    partial void OncontraseniaChanged();
    partial void OncurpChanging(string value);
    partial void OncurpChanged();
    partial void OnnombresChanging(string value);
    partial void OnnombresChanged();
    partial void Onapellido1Changing(string value);
    partial void Onapellido1Changed();
    partial void Onapellido2Changing(string value);
    partial void Onapellido2Changed();
    partial void OntelefonoChanging(string value);
    partial void OntelefonoChanged();
    partial void OncargoChanging(string value);
    partial void OncargoChanged();
    partial void OnactivoChanging(bool value);
    partial void OnactivoChanged();
    partial void Onf_registroChanging(System.DateTime value);
    partial void Onf_registroChanged();
    partial void Ones_administradorChanging(bool value);
    partial void Ones_administradorChanged();
    partial void OntockenChanging(System.Nullable<System.Guid> value);
    partial void OntockenChanged();
    #endregion
		
		public ca_usuarios()
		{
			this._re_nodos_usuarios = new EntitySet<re_nodos_usuarios>(new Action<re_nodos_usuarios>(this.attach_re_nodos_usuarios), new Action<re_nodos_usuarios>(this.detach_re_nodos_usuarios));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
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
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_usuario", DbType="VarChar(30) NOT NULL", CanBeNull=false)]
        [Display(Name = "Nombre de usuario")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Campo requerido")]
		public string usuario
		{
			get
			{
				return this._usuario;
			}
			set
			{
				if ((this._usuario != value))
				{
					this.OnusuarioChanging(value);
					this.SendPropertyChanging();
					this._usuario = value;
					this.SendPropertyChanged("usuario");
					this.OnusuarioChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_contrasenia", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
        [Display(Name = "Contraseña")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Campo requerido")]
        [DataType(DataType.Password)]
		public string contrasenia
		{
			get
			{
				return this._contrasenia;
			}
			set
			{
				if ((this._contrasenia != value))
				{
					this.OncontraseniaChanging(value);
					this.SendPropertyChanging();
					this._contrasenia = value;
					this.SendPropertyChanged("contrasenia");
					this.OncontraseniaChanged();
				}
			}
		}
		
        [Display(Name = "Repetir contraseña")]
        [DataType(DataType.Password)]
        [Compare("contrasenia", ErrorMessage = "Las contraseñas no coinciden")]
        public string repetircontrasenia
        {
            get
            {
                return this._repetircontrasenia;
            }
            set
            {
                if ((this._repetircontrasenia != value))
                {
                    this._repetircontrasenia = value;
                }
            }
        }

		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_curp", DbType="VarChar(18)")]
        [Display(Name = "CURP")]
		public string curp
		{
			get
			{
				return this._curp;
			}
			set
			{
				if ((this._curp != value))
				{
					this.OncurpChanging(value);
					this.SendPropertyChanging();
					this._curp = value;
					this.SendPropertyChanged("curp");
					this.OncurpChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nombres", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
        [Display(Name = "Nombre(s)")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Campo requerido")]
		public string nombres
		{
			get
			{
				return this._nombres;
			}
			set
			{
				if ((this._nombres != value))
				{
					this.OnnombresChanging(value);
					this.SendPropertyChanging();
					this._nombres = value;
					this.SendPropertyChanged("nombres");
					this.OnnombresChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_apellido1", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
        [Display(Name = "Primer apellido")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Campo requerido")]
		public string apellido1
		{
			get
			{
				return this._apellido1;
			}
			set
			{
				if ((this._apellido1 != value))
				{
					this.Onapellido1Changing(value);
					this.SendPropertyChanging();
					this._apellido1 = value;
					this.SendPropertyChanged("apellido1");
					this.Onapellido1Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_apellido2", DbType="VarChar(50)")]
        [Display(Name = "Segundo apellido")]
		public string apellido2
		{
			get
			{
				return this._apellido2;
			}
			set
			{
				if ((this._apellido2 != value))
				{
					this.Onapellido2Changing(value);
					this.SendPropertyChanging();
					this._apellido2 = value;
					this.SendPropertyChanged("apellido2");
					this.Onapellido2Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_telefono", DbType="VarChar(50)")]
        [Display(Name = "Teléfono")]
		public string telefono
		{
			get
			{
				return this._telefono;
			}
			set
			{
				if ((this._telefono != value))
				{
					this.OntelefonoChanging(value);
					this.SendPropertyChanging();
					this._telefono = value;
					this.SendPropertyChanged("telefono");
					this.OntelefonoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_cargo", DbType="VarChar(200)")]
        [Display(Name = "Cargo")]
		public string cargo
		{
			get
			{
				return this._cargo;
			}
			set
			{
				if ((this._cargo != value))
				{
					this.OncargoChanging(value);
					this.SendPropertyChanging();
					this._cargo = value;
					this.SendPropertyChanged("cargo");
					this.OncargoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_activo", DbType="Bit NOT NULL")]
        [Display(Name = "Usuario activo")]
		public bool activo
		{
			get
			{
				return this._activo;
			}
			set
			{
				if ((this._activo != value))
				{
					this.OnactivoChanging(value);
					this.SendPropertyChanging();
					this._activo = value;
					this.SendPropertyChanged("activo");
					this.OnactivoChanged();
				}
			}
		}
		
        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_f_registro", DbType = "DateTime NOT NULL", IsDbGenerated = true, UpdateCheck = UpdateCheck.Never)]
        [Display(Name = "Fecha/Hora de registro")]
		public System.DateTime f_registro
		{
			get
			{
				return this._f_registro;
			}
			set
			{
				if ((this._f_registro != value))
				{
					this.Onf_registroChanging(value);
					this.SendPropertyChanging();
					this._f_registro = value;
					this.SendPropertyChanged("f_registro");
					this.Onf_registroChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_es_administrador", DbType="Bit NOT NULL")]
        [Display(Name = "Es administrador")]
		public bool es_administrador
		{
			get
			{
				return this._es_administrador;
			}
			set
			{
				if ((this._es_administrador != value))
				{
					this.Ones_administradorChanging(value);
					this.SendPropertyChanging();
					this._es_administrador = value;
					this.SendPropertyChanged("es_administrador");
					this.Ones_administradorChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_tocken", DbType="UniqueIdentifier")]
		public System.Nullable<System.Guid> tocken
		{
			get
			{
				return this._tocken;
			}
			set
			{
				if ((this._tocken != value))
				{
					this.OntockenChanging(value);
					this.SendPropertyChanging();
					this._tocken = value;
					this.SendPropertyChanged("tocken");
					this.OntockenChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="ca_usuarios_re_nodos_usuarios", Storage="_re_nodos_usuarios", ThisKey="id", OtherKey="id_usuario")]
		public EntitySet<re_nodos_usuarios> re_nodos_usuarios
		{
			get
			{
				return this._re_nodos_usuarios;
			}
			set
			{
				this._re_nodos_usuarios.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_re_nodos_usuarios(re_nodos_usuarios entity)
		{
			this.SendPropertyChanging();
			entity.ca_usuarios = this;
		}
		
		private void detach_re_nodos_usuarios(re_nodos_usuarios entity)
		{
			this.SendPropertyChanging();
			entity.ca_usuarios = null;
		}
	}
	
	public partial class pa_obtener_nodosResult
	{
		
		private bool _activo;
		
		private int _id;
		
		private string _nodo;
		
		private string _url_servicio_rest;
		
		private string _usuario;
		
		private string _contrasenia;
		
		public pa_obtener_nodosResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_activo", DbType="Bit NOT NULL")]
		public bool activo
		{
			get
			{
				return this._activo;
			}
			set
			{
				if ((this._activo != value))
				{
					this._activo = value;
				}
			}
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nodo", DbType="VarChar(200) NOT NULL", CanBeNull=false)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_url_servicio_rest", DbType="VarChar(8000) NOT NULL", CanBeNull=false)]
		public string url_servicio_rest
		{
			get
			{
				return this._url_servicio_rest;
			}
			set
			{
				if ((this._url_servicio_rest != value))
				{
					this._url_servicio_rest = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_usuario", DbType="VarChar(100)")]
		public string usuario
		{
			get
			{
				return this._usuario;
			}
			set
			{
				if ((this._usuario != value))
				{
					this._usuario = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_contrasenia", DbType="VarChar(100)")]
		public string contrasenia
		{
			get
			{
				return this._contrasenia;
			}
			set
			{
				if ((this._contrasenia != value))
				{
					this._contrasenia = value;
				}
			}
		}
	}
	
	public partial class pa_obtener_nodoResult
	{
		
		private bool _activo;
		
		private int _id;
		
		private string _nodo;
		
		private string _url_servicio_rest;
		
		private string _usuario;
		
		private string _contrasenia;
		
		public pa_obtener_nodoResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_activo", DbType="Bit NOT NULL")]
		public bool activo
		{
			get
			{
				return this._activo;
			}
			set
			{
				if ((this._activo != value))
				{
					this._activo = value;
				}
			}
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nodo", DbType="VarChar(200) NOT NULL", CanBeNull=false)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_url_servicio_rest", DbType="VarChar(8000) NOT NULL", CanBeNull=false)]
		public string url_servicio_rest
		{
			get
			{
				return this._url_servicio_rest;
			}
			set
			{
				if ((this._url_servicio_rest != value))
				{
					this._url_servicio_rest = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_usuario", DbType="VarChar(100)")]
		public string usuario
		{
			get
			{
				return this._usuario;
			}
			set
			{
				if ((this._usuario != value))
				{
					this._usuario = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_contrasenia", DbType="VarChar(100)")]
		public string contrasenia
		{
			get
			{
				return this._contrasenia;
			}
			set
			{
				if ((this._contrasenia != value))
				{
					this._contrasenia = value;
				}
			}
		}
	}
	
	public partial class pa_obtener_nodos_no_enlazadosResult
	{
		
		private int _id;
		
		private string _nodo;
		
		private string _url_servicio_rest;
		
		private System.DateTime _fecha_registro;
		
		public pa_obtener_nodos_no_enlazadosResult()
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nodo", DbType="VarChar(200) NOT NULL", CanBeNull=false)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_url_servicio_rest", DbType="VarChar(8000) NOT NULL", CanBeNull=false)]
		public string url_servicio_rest
		{
			get
			{
				return this._url_servicio_rest;
			}
			set
			{
				if ((this._url_servicio_rest != value))
				{
					this._url_servicio_rest = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_fecha_registro", DbType="DateTime NOT NULL")]
		public System.DateTime fecha_registro
		{
			get
			{
				return this._fecha_registro;
			}
			set
			{
				if ((this._fecha_registro != value))
				{
					this._fecha_registro = value;
				}
			}
		}
	}
	
	public partial class pa_FechaResult
	{
		
		private string _Fecha;
		
		public pa_FechaResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Fecha", DbType="NVarChar(44)")]
		public string Fecha
		{
			get
			{
				return this._Fecha;
			}
			set
			{
				if ((this._Fecha != value))
				{
					this._Fecha = value;
				}
			}
		}
	}
	
	public partial class pa_HoraResult
	{
		
		private string _Hora;
		
		public pa_HoraResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Hora", DbType="VarChar(8)")]
		public string Hora
		{
			get
			{
				return this._Hora;
			}
			set
			{
				if ((this._Hora != value))
				{
					this._Hora = value;
				}
			}
		}
	}
}
#pragma warning restore 1591
