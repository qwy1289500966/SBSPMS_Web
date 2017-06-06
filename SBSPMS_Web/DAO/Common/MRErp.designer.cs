﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace SBSPMS_Web.DAO.Common
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="MRErp")]
	public partial class MRErpDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region 可扩展性方法定义
    partial void OnCreated();
    partial void InsertMenuInfo(MenuInfo instance);
    partial void UpdateMenuInfo(MenuInfo instance);
    partial void DeleteMenuInfo(MenuInfo instance);
    #endregion
		
		public MRErpDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["MRErpConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public MRErpDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public MRErpDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public MRErpDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public MRErpDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<MenuInfo> MenuInfo
		{
			get
			{
				return this.GetTable<MenuInfo>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.MenuInfo")]
	public partial class MenuInfo : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _MenuCode;
		
		private string _Url;
		
		private string _Title;
		
		private string _Description;
		
		private string _Target;
		
		private string _ImgUrl;
		
		private System.Nullable<int> _MenuLevel;
		
		private string _ParentNode;
		
		private System.Nullable<bool> _IsLeaf;
		
		private string _MenuOrder;
		
    #region 可扩展性方法定义
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnMenuCodeChanging(string value);
    partial void OnMenuCodeChanged();
    partial void OnUrlChanging(string value);
    partial void OnUrlChanged();
    partial void OnTitleChanging(string value);
    partial void OnTitleChanged();
    partial void OnDescriptionChanging(string value);
    partial void OnDescriptionChanged();
    partial void OnTargetChanging(string value);
    partial void OnTargetChanged();
    partial void OnImgUrlChanging(string value);
    partial void OnImgUrlChanged();
    partial void OnMenuLevelChanging(System.Nullable<int> value);
    partial void OnMenuLevelChanged();
    partial void OnParentNodeChanging(string value);
    partial void OnParentNodeChanged();
    partial void OnIsLeafChanging(System.Nullable<bool> value);
    partial void OnIsLeafChanged();
    partial void OnMenuOrderChanging(string value);
    partial void OnMenuOrderChanged();
    #endregion
		
		public MenuInfo()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MenuCode", DbType="VarChar(20)")]
		public string MenuCode
		{
			get
			{
				return this._MenuCode;
			}
			set
			{
				if ((this._MenuCode != value))
				{
					this.OnMenuCodeChanging(value);
					this.SendPropertyChanging();
					this._MenuCode = value;
					this.SendPropertyChanged("MenuCode");
					this.OnMenuCodeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Url", DbType="VarChar(100)")]
		public string Url
		{
			get
			{
				return this._Url;
			}
			set
			{
				if ((this._Url != value))
				{
					this.OnUrlChanging(value);
					this.SendPropertyChanging();
					this._Url = value;
					this.SendPropertyChanged("Url");
					this.OnUrlChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Title", DbType="VarChar(100)")]
		public string Title
		{
			get
			{
				return this._Title;
			}
			set
			{
				if ((this._Title != value))
				{
					this.OnTitleChanging(value);
					this.SendPropertyChanging();
					this._Title = value;
					this.SendPropertyChanged("Title");
					this.OnTitleChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Description", DbType="VarChar(100)")]
		public string Description
		{
			get
			{
				return this._Description;
			}
			set
			{
				if ((this._Description != value))
				{
					this.OnDescriptionChanging(value);
					this.SendPropertyChanging();
					this._Description = value;
					this.SendPropertyChanged("Description");
					this.OnDescriptionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Target", DbType="VarChar(50)")]
		public string Target
		{
			get
			{
				return this._Target;
			}
			set
			{
				if ((this._Target != value))
				{
					this.OnTargetChanging(value);
					this.SendPropertyChanging();
					this._Target = value;
					this.SendPropertyChanged("Target");
					this.OnTargetChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ImgUrl", DbType="VarChar(100)")]
		public string ImgUrl
		{
			get
			{
				return this._ImgUrl;
			}
			set
			{
				if ((this._ImgUrl != value))
				{
					this.OnImgUrlChanging(value);
					this.SendPropertyChanging();
					this._ImgUrl = value;
					this.SendPropertyChanged("ImgUrl");
					this.OnImgUrlChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MenuLevel", DbType="Int")]
		public System.Nullable<int> MenuLevel
		{
			get
			{
				return this._MenuLevel;
			}
			set
			{
				if ((this._MenuLevel != value))
				{
					this.OnMenuLevelChanging(value);
					this.SendPropertyChanging();
					this._MenuLevel = value;
					this.SendPropertyChanged("MenuLevel");
					this.OnMenuLevelChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ParentNode", DbType="VarChar(20)")]
		public string ParentNode
		{
			get
			{
				return this._ParentNode;
			}
			set
			{
				if ((this._ParentNode != value))
				{
					this.OnParentNodeChanging(value);
					this.SendPropertyChanging();
					this._ParentNode = value;
					this.SendPropertyChanged("ParentNode");
					this.OnParentNodeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IsLeaf", DbType="Bit")]
		public System.Nullable<bool> IsLeaf
		{
			get
			{
				return this._IsLeaf;
			}
			set
			{
				if ((this._IsLeaf != value))
				{
					this.OnIsLeafChanging(value);
					this.SendPropertyChanging();
					this._IsLeaf = value;
					this.SendPropertyChanged("IsLeaf");
					this.OnIsLeafChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MenuOrder", DbType="VarChar(20)")]
		public string MenuOrder
		{
			get
			{
				return this._MenuOrder;
			}
			set
			{
				if ((this._MenuOrder != value))
				{
					this.OnMenuOrderChanging(value);
					this.SendPropertyChanging();
					this._MenuOrder = value;
					this.SendPropertyChanged("MenuOrder");
					this.OnMenuOrderChanged();
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
}
#pragma warning restore 1591
