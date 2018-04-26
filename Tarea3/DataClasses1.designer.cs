﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Tarea3
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="tareaCorta3")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertEstudiante(Estudiante instance);
    partial void UpdateEstudiante(Estudiante instance);
    partial void DeleteEstudiante(Estudiante instance);
    partial void InsertCarrera(Carrera instance);
    partial void UpdateCarrera(Carrera instance);
    partial void DeleteCarrera(Carrera instance);
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["tareaCorta3ConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Estudiante> Estudiantes
		{
			get
			{
				return this.GetTable<Estudiante>();
			}
		}
		
		public System.Data.Linq.Table<Carrera> Carreras
		{
			get
			{
				return this.GetTable<Carrera>();
			}
		}
		
		public System.Data.Linq.Table<EstudiantesIngresadosCarreraAno> EstudiantesIngresadosCarreraAnos
		{
			get
			{
				return this.GetTable<EstudiantesIngresadosCarreraAno>();
			}
		}
		
		public System.Data.Linq.Table<TotalEstudiantes> TotalEstudiantes
		{
			get
			{
				return this.GetTable<TotalEstudiantes>();
			}
		}
		
		public System.Data.Linq.Table<TotalEstudiantesCarrera> TotalEstudiantesCarreras
		{
			get
			{
				return this.GetTable<TotalEstudiantesCarrera>();
			}
		}
		
		public System.Data.Linq.Table<TotalEstudiantesPorAno> TotalEstudiantesPorAnos
		{
			get
			{
				return this.GetTable<TotalEstudiantesPorAno>();
			}
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.estudiantesDeCarrera")]
		public ISingleResult<estudiantesDeCarreraResult> estudiantesDeCarrera([global::System.Data.Linq.Mapping.ParameterAttribute(Name="Id_Carrera", DbType="VarChar(10)")] string id_Carrera)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), id_Carrera);
			return ((ISingleResult<estudiantesDeCarreraResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.estudiantesIngresadosCarreraAno")]
		public ISingleResult<EstudiantesIngresadosCarreraAno> estudiantesIngresadosCarreraAno()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((ISingleResult<EstudiantesIngresadosCarreraAno>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.totalEstudiantes")]
		public ISingleResult<TotalEstudiantes> totalEstudiantes()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((ISingleResult<TotalEstudiantes>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.totalEstudiantesCarrera")]
		public ISingleResult<TotalEstudiantesCarrera> totalEstudiantesCarrera()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((ISingleResult<TotalEstudiantesCarrera>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.totalEstudiantesPorAno")]
		public ISingleResult<TotalEstudiantesPorAno> totalEstudiantesPorAno()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((ISingleResult<TotalEstudiantesPorAno>)(result.ReturnValue));
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Estudiantes")]
	public partial class Estudiante : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private decimal _cedula;
		
		private decimal _carnet;
		
		private string _nombre;
		
		private string _id_carrera;
		
		private System.DateTime _fecha_ingreso;
		
		private System.Data.Linq.Binary _foto;
		
		private System.Data.Linq.Binary _curriculum_vitae;
		
		private EntityRef<Carrera> _Carrera;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OncedulaChanging(decimal value);
    partial void OncedulaChanged();
    partial void OncarnetChanging(decimal value);
    partial void OncarnetChanged();
    partial void OnnombreChanging(string value);
    partial void OnnombreChanged();
    partial void Onid_carreraChanging(string value);
    partial void Onid_carreraChanged();
    partial void Onfecha_ingresoChanging(System.DateTime value);
    partial void Onfecha_ingresoChanged();
    partial void OnfotoChanging(System.Data.Linq.Binary value);
    partial void OnfotoChanged();
    partial void Oncurriculum_vitaeChanging(System.Data.Linq.Binary value);
    partial void Oncurriculum_vitaeChanged();
    #endregion
		
		public Estudiante()
		{
			this._Carrera = default(EntityRef<Carrera>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_cedula", DbType="Decimal(9,0) NOT NULL", IsPrimaryKey=true)]
		public decimal cedula
		{
			get
			{
				return this._cedula;
			}
			set
			{
				if ((this._cedula != value))
				{
					this.OncedulaChanging(value);
					this.SendPropertyChanging();
					this._cedula = value;
					this.SendPropertyChanged("cedula");
					this.OncedulaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_carnet", DbType="Decimal(10,0) NOT NULL")]
		public decimal carnet
		{
			get
			{
				return this._carnet;
			}
			set
			{
				if ((this._carnet != value))
				{
					this.OncarnetChanging(value);
					this.SendPropertyChanging();
					this._carnet = value;
					this.SendPropertyChanged("carnet");
					this.OncarnetChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nombre", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string nombre
		{
			get
			{
				return this._nombre;
			}
			set
			{
				if ((this._nombre != value))
				{
					this.OnnombreChanging(value);
					this.SendPropertyChanging();
					this._nombre = value;
					this.SendPropertyChanged("nombre");
					this.OnnombreChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_carrera", DbType="VarChar(10)")]
		public string id_carrera
		{
			get
			{
				return this._id_carrera;
			}
			set
			{
				if ((this._id_carrera != value))
				{
					if (this._Carrera.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.Onid_carreraChanging(value);
					this.SendPropertyChanging();
					this._id_carrera = value;
					this.SendPropertyChanged("id_carrera");
					this.Onid_carreraChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_fecha_ingreso", DbType="Date NOT NULL")]
		public System.DateTime fecha_ingreso
		{
			get
			{
				return this._fecha_ingreso;
			}
			set
			{
				if ((this._fecha_ingreso != value))
				{
					this.Onfecha_ingresoChanging(value);
					this.SendPropertyChanging();
					this._fecha_ingreso = value;
					this.SendPropertyChanged("fecha_ingreso");
					this.Onfecha_ingresoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_foto", DbType="VarBinary(MAX) NOT NULL", CanBeNull=false, UpdateCheck=UpdateCheck.Never)]
		public System.Data.Linq.Binary foto
		{
			get
			{
				return this._foto;
			}
			set
			{
				if ((this._foto != value))
				{
					this.OnfotoChanging(value);
					this.SendPropertyChanging();
					this._foto = value;
					this.SendPropertyChanged("foto");
					this.OnfotoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_curriculum_vitae", DbType="VarBinary(MAX) NOT NULL", CanBeNull=false, UpdateCheck=UpdateCheck.Never)]
		public System.Data.Linq.Binary curriculum_vitae
		{
			get
			{
				return this._curriculum_vitae;
			}
			set
			{
				if ((this._curriculum_vitae != value))
				{
					this.Oncurriculum_vitaeChanging(value);
					this.SendPropertyChanging();
					this._curriculum_vitae = value;
					this.SendPropertyChanged("curriculum_vitae");
					this.Oncurriculum_vitaeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Carrera_Estudiante", Storage="_Carrera", ThisKey="id_carrera", OtherKey="id_carrera", IsForeignKey=true, DeleteRule="SET NULL")]
		public Carrera Carrera
		{
			get
			{
				return this._Carrera.Entity;
			}
			set
			{
				Carrera previousValue = this._Carrera.Entity;
				if (((previousValue != value) 
							|| (this._Carrera.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Carrera.Entity = null;
						previousValue.Estudiantes.Remove(this);
					}
					this._Carrera.Entity = value;
					if ((value != null))
					{
						value.Estudiantes.Add(this);
						this._id_carrera = value.id_carrera;
					}
					else
					{
						this._id_carrera = default(string);
					}
					this.SendPropertyChanged("Carrera");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Carrera")]
	public partial class Carrera : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _id_carrera;
		
		private string _nombre;
		
		private string _encargado;
		
		private string _ubicacion;
		
		private EntitySet<Estudiante> _Estudiantes;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onid_carreraChanging(string value);
    partial void Onid_carreraChanged();
    partial void OnnombreChanging(string value);
    partial void OnnombreChanged();
    partial void OnencargadoChanging(string value);
    partial void OnencargadoChanged();
    partial void OnubicacionChanging(string value);
    partial void OnubicacionChanged();
    #endregion
		
		public Carrera()
		{
			this._Estudiantes = new EntitySet<Estudiante>(new Action<Estudiante>(this.attach_Estudiantes), new Action<Estudiante>(this.detach_Estudiantes));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_carrera", DbType="VarChar(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string id_carrera
		{
			get
			{
				return this._id_carrera;
			}
			set
			{
				if ((this._id_carrera != value))
				{
					this.Onid_carreraChanging(value);
					this.SendPropertyChanging();
					this._id_carrera = value;
					this.SendPropertyChanged("id_carrera");
					this.Onid_carreraChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nombre", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string nombre
		{
			get
			{
				return this._nombre;
			}
			set
			{
				if ((this._nombre != value))
				{
					this.OnnombreChanging(value);
					this.SendPropertyChanging();
					this._nombre = value;
					this.SendPropertyChanged("nombre");
					this.OnnombreChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_encargado", DbType="NVarChar(10) NOT NULL", CanBeNull=false)]
		public string encargado
		{
			get
			{
				return this._encargado;
			}
			set
			{
				if ((this._encargado != value))
				{
					this.OnencargadoChanging(value);
					this.SendPropertyChanging();
					this._encargado = value;
					this.SendPropertyChanged("encargado");
					this.OnencargadoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ubicacion", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
		public string ubicacion
		{
			get
			{
				return this._ubicacion;
			}
			set
			{
				if ((this._ubicacion != value))
				{
					this.OnubicacionChanging(value);
					this.SendPropertyChanging();
					this._ubicacion = value;
					this.SendPropertyChanged("ubicacion");
					this.OnubicacionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Carrera_Estudiante", Storage="_Estudiantes", ThisKey="id_carrera", OtherKey="id_carrera")]
		public EntitySet<Estudiante> Estudiantes
		{
			get
			{
				return this._Estudiantes;
			}
			set
			{
				this._Estudiantes.Assign(value);
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
		
		private void attach_Estudiantes(Estudiante entity)
		{
			this.SendPropertyChanging();
			entity.Carrera = this;
		}
		
		private void detach_Estudiantes(Estudiante entity)
		{
			this.SendPropertyChanging();
			entity.Carrera = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="")]
	public partial class EstudiantesIngresadosCarreraAno
	{
		
		private string _id_carrera;
		
		private string _Nombre;
		
		private int _Año;
		
		private int _Estudiantes_Ingresados;
		
		public EstudiantesIngresadosCarreraAno()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_carrera", CanBeNull=false)]
		public string id_carrera
		{
			get
			{
				return this._id_carrera;
			}
			set
			{
				if ((this._id_carrera != value))
				{
					this._id_carrera = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nombre", CanBeNull=false)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Año")]
		public int Año
		{
			get
			{
				return this._Año;
			}
			set
			{
				if ((this._Año != value))
				{
					this._Año = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Estudiantes_Ingresados")]
		public int Estudiantes_Ingresados
		{
			get
			{
				return this._Estudiantes_Ingresados;
			}
			set
			{
				if ((this._Estudiantes_Ingresados != value))
				{
					this._Estudiantes_Ingresados = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="")]
	public partial class TotalEstudiantes
	{
		
		private int _Total_Estudiantes;
		
		public TotalEstudiantes()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Total_Estudiantes")]
		public int Total_Estudiantes
		{
			get
			{
				return this._Total_Estudiantes;
			}
			set
			{
				if ((this._Total_Estudiantes != value))
				{
					this._Total_Estudiantes = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="")]
	public partial class TotalEstudiantesCarrera
	{
		
		private string _id_carrera;
		
		private string _nombre;
		
		private int _Total_Estudiantes;
		
		public TotalEstudiantesCarrera()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_carrera", CanBeNull=false)]
		public string id_carrera
		{
			get
			{
				return this._id_carrera;
			}
			set
			{
				if ((this._id_carrera != value))
				{
					this._id_carrera = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nombre", CanBeNull=false)]
		public string nombre
		{
			get
			{
				return this._nombre;
			}
			set
			{
				if ((this._nombre != value))
				{
					this._nombre = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Total_Estudiantes")]
		public int Total_Estudiantes
		{
			get
			{
				return this._Total_Estudiantes;
			}
			set
			{
				if ((this._Total_Estudiantes != value))
				{
					this._Total_Estudiantes = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="")]
	public partial class TotalEstudiantesPorAno
	{
		
		private int _Año;
		
		private int _Total_Estudiantes;
		
		public TotalEstudiantesPorAno()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Año")]
		public int Año
		{
			get
			{
				return this._Año;
			}
			set
			{
				if ((this._Año != value))
				{
					this._Año = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Total_Estudiantes")]
		public int Total_Estudiantes
		{
			get
			{
				return this._Total_Estudiantes;
			}
			set
			{
				if ((this._Total_Estudiantes != value))
				{
					this._Total_Estudiantes = value;
				}
			}
		}
	}
	
	public partial class estudiantesDeCarreraResult
	{
		
		private decimal _cedula;
		
		private decimal _carnet;
		
		private string _nombre;
		
		private string _id_carrera;
		
		private System.DateTime _fecha_ingreso;
		
		private System.Data.Linq.Binary _foto;
		
		private System.Data.Linq.Binary _curriculum_vitae;
		
		public estudiantesDeCarreraResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_cedula", DbType="Decimal(9,0) NOT NULL")]
		public decimal cedula
		{
			get
			{
				return this._cedula;
			}
			set
			{
				if ((this._cedula != value))
				{
					this._cedula = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_carnet", DbType="Decimal(10,0) NOT NULL")]
		public decimal carnet
		{
			get
			{
				return this._carnet;
			}
			set
			{
				if ((this._carnet != value))
				{
					this._carnet = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nombre", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string nombre
		{
			get
			{
				return this._nombre;
			}
			set
			{
				if ((this._nombre != value))
				{
					this._nombre = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_carrera", DbType="VarChar(10)")]
		public string id_carrera
		{
			get
			{
				return this._id_carrera;
			}
			set
			{
				if ((this._id_carrera != value))
				{
					this._id_carrera = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_fecha_ingreso", DbType="Date NOT NULL")]
		public System.DateTime fecha_ingreso
		{
			get
			{
				return this._fecha_ingreso;
			}
			set
			{
				if ((this._fecha_ingreso != value))
				{
					this._fecha_ingreso = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_foto", DbType="VarBinary(MAX) NOT NULL", CanBeNull=false)]
		public System.Data.Linq.Binary foto
		{
			get
			{
				return this._foto;
			}
			set
			{
				if ((this._foto != value))
				{
					this._foto = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_curriculum_vitae", DbType="VarBinary(MAX) NOT NULL", CanBeNull=false)]
		public System.Data.Linq.Binary curriculum_vitae
		{
			get
			{
				return this._curriculum_vitae;
			}
			set
			{
				if ((this._curriculum_vitae != value))
				{
					this._curriculum_vitae = value;
				}
			}
		}
	}
}
#pragma warning restore 1591
