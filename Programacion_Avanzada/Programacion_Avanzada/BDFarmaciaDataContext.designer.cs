﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Programacion_Avanzada
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Farmacia")]
	public partial class BDFarmaciaDataContextDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Definiciones de métodos de extensibilidad
    partial void OnCreated();
    #endregion
		
		public BDFarmaciaDataContextDataContext() : 
				base(global::Programacion_Avanzada.Properties.Settings.Default.Conexion, mappingSource)
		{
			OnCreated();
		}
		
		public BDFarmaciaDataContextDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}

        internal void AgregarEmpleados(int idEmpleado, string nombre, int edad, string domicilio, decimal sueldo, DateTime horarioEntrada, DateTime horarioSalida, string puesto)
        {
            throw new NotImplementedException();
        }

        internal void AgregarEmpleados(int idEmpleado, string nombre, int edad, string domicilio, decimal sueldo, DateTime horarioEntrada, string puesto)
        {
            throw new NotImplementedException();
        }

        public BDFarmaciaDataContextDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public BDFarmaciaDataContextDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public BDFarmaciaDataContextDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.Agregar")]
		public int Agregar([global::System.Data.Linq.Mapping.ParameterAttribute(Name="IdProducto", DbType="Int")] System.Nullable<int> idProducto, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Nombre", DbType="VarChar(80)")] string nombre, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Tipo", DbType="VarChar(80)")] string tipo, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Descripcion", DbType="Text")] string descripcion, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Precio", DbType="Float")] System.Nullable<double> precio, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Cantidad", DbType="Int")] System.Nullable<int> cantidad, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="IdFarmacia", DbType="Int")] System.Nullable<int> idFarmacia)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), idProducto, nombre, tipo, descripcion, precio, cantidad, idFarmacia);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.Modificar")]
		public int Modificar([global::System.Data.Linq.Mapping.ParameterAttribute(Name="IdProducto", DbType="Int")] System.Nullable<int> idProducto, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Nombre", DbType="VarChar(80)")] string nombre, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Tipo", DbType="VarChar(80)")] string tipo, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Descripcion", DbType="Text")] string descripcion, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Precio", DbType="Float")] System.Nullable<double> precio, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Cantidad", DbType="Int")] System.Nullable<int> cantidad, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="IdFarmacia", DbType="Int")] System.Nullable<int> idFarmacia)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), idProducto, nombre, tipo, descripcion, precio, cantidad, idFarmacia);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.Mostrar")]
		public ISingleResult<MostrarResult> Mostrar()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((ISingleResult<MostrarResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.AgregarEmpleados")]
		public int AgregarEmpleados([global::System.Data.Linq.Mapping.ParameterAttribute(Name="IdEmpleado", DbType="Int")] System.Nullable<int> idEmpleado, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Nombre", DbType="VarChar(80)")] string nombre, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Edad", DbType="Int")] System.Nullable<int> edad, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Domicilio", DbType="VarChar(100)")] string domicilio, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Sueldo", DbType="Decimal(5,2)")] System.Nullable<decimal> sueldo, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="HorarioEntrada", DbType="Time")] System.Nullable<System.TimeSpan> horarioEntrada, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="HorarioSalida", DbType="Time")] System.Nullable<System.TimeSpan> horarioSalida, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Puesto", DbType="VarChar(80)")] string puesto)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), idEmpleado, nombre, edad, domicilio, sueldo, horarioEntrada, horarioSalida, puesto);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.ModificarEmpleados")]
		public int ModificarEmpleados([global::System.Data.Linq.Mapping.ParameterAttribute(Name="IdEmpleado", DbType="Int")] System.Nullable<int> idEmpleado, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Nombre", DbType="VarChar(80)")] string nombre, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Edad", DbType="Int")] System.Nullable<int> edad, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Domicilio", DbType="VarChar(100)")] string domicilio, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Sueldo", DbType="Decimal(5,2)")] System.Nullable<decimal> sueldo, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="HorarioEntrada", DbType="Time")] System.Nullable<System.TimeSpan> horarioEntrada, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="HorarioSalida", DbType="Time")] System.Nullable<System.TimeSpan> horarioSalida, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Puesto", DbType="VarChar(80)")] string puesto)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), idEmpleado, nombre, edad, domicilio, sueldo, horarioEntrada, horarioSalida, puesto);
			return ((int)(result.ReturnValue));
		}
	}
	
	public partial class MostrarResult
	{
		
		private int _IdProducto;
		
		private string _Nombre;
		
		private string _Tipo;
		
		private string _Descripcion;
		
		private System.Nullable<double> _Precio;
		
		private System.Nullable<int> _Cantidad;
		
		private System.Nullable<int> _IdFarmacia;
		
		public MostrarResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdProducto", DbType="Int NOT NULL")]
		public int IdProducto
		{
			get
			{
				return this._IdProducto;
			}
			set
			{
				if ((this._IdProducto != value))
				{
					this._IdProducto = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nombre", DbType="VarChar(80)")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Tipo", DbType="VarChar(80)")]
		public string Tipo
		{
			get
			{
				return this._Tipo;
			}
			set
			{
				if ((this._Tipo != value))
				{
					this._Tipo = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Descripcion", DbType="Text", UpdateCheck=UpdateCheck.Never)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Precio", DbType="Float")]
		public System.Nullable<double> Precio
		{
			get
			{
				return this._Precio;
			}
			set
			{
				if ((this._Precio != value))
				{
					this._Precio = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Cantidad", DbType="Int")]
		public System.Nullable<int> Cantidad
		{
			get
			{
				return this._Cantidad;
			}
			set
			{
				if ((this._Cantidad != value))
				{
					this._Cantidad = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdFarmacia", DbType="Int")]
		public System.Nullable<int> IdFarmacia
		{
			get
			{
				return this._IdFarmacia;
			}
			set
			{
				if ((this._IdFarmacia != value))
				{
					this._IdFarmacia = value;
				}
			}
		}
	}
}
#pragma warning restore 1591
