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

namespace TrangTinTucDonGian
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="TrangTinTuc")]
	public partial class WebTinTucDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InserttblUser(tblUser instance);
    partial void UpdatetblUser(tblUser instance);
    partial void DeletetblUser(tblUser instance);
    partial void InserttblCategory(tblCategory instance);
    partial void UpdatetblCategory(tblCategory instance);
    partial void DeletetblCategory(tblCategory instance);
    partial void InserttblNew(tblNew instance);
    partial void UpdatetblNew(tblNew instance);
    partial void DeletetblNew(tblNew instance);
    #endregion
		
		public WebTinTucDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["TrangTinTucConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public WebTinTucDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public WebTinTucDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public WebTinTucDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public WebTinTucDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<tblUser> tblUsers
		{
			get
			{
				return this.GetTable<tblUser>();
			}
		}
		
		public System.Data.Linq.Table<tblCategory> tblCategories
		{
			get
			{
				return this.GetTable<tblCategory>();
			}
		}
		
		public System.Data.Linq.Table<tblNew> tblNews
		{
			get
			{
				return this.GetTable<tblNew>();
			}
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.tblNews_view")]
		public int tblNews_view([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> views, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> news_ID)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), views, news_ID);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.tblNews_Update")]
		public int tblNews_Update([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(500)")] string title, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(MAX)")] string body, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="DateTime")] System.Nullable<System.DateTime> date, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> news_ID)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), title, body, date, news_ID);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.tblNews_SelectID")]
		public ISingleResult<tblNews_SelectIDResult> tblNews_SelectID([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> category_ID)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), category_ID);
			return ((ISingleResult<tblNews_SelectIDResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.tblNews_SelectAll")]
		public ISingleResult<tblNews_SelectAllResult> tblNews_SelectAll()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((ISingleResult<tblNews_SelectAllResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.tblNews_Select")]
		public ISingleResult<tblNews_SelectResult> tblNews_Select([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> news_ID)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), news_ID);
			return ((ISingleResult<tblNews_SelectResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.tblNews_Insert")]
		public int tblNews_Insert([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(500)")] string title, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(MAX)")] string body, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="DateTime")] System.Nullable<System.DateTime> date, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> category_ID)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), title, body, date, category_ID);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.tblCategory_Update")]
		public int tblCategory_Update([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(50)")] string title, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> category_ID)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), title, category_ID);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.tblCategory_SelectAll")]
		public ISingleResult<tblCategory_SelectAllResult> tblCategory_SelectAll()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((ISingleResult<tblCategory_SelectAllResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.tblCategory_Insert")]
		public int tblCategory_Insert([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(50)")] string title)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), title);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.tblCategory_Delete")]
		public int tblCategory_Delete([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> category_ID)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), category_ID);
			return ((int)(result.ReturnValue));
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tblUser")]
	public partial class tblUser : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _user_ID;
		
		private string _username;
		
		private string _password;
		
		private int _power;
		
		private string _fullname;
		
		private string _address;
		
		private string _email;
		
		private string _phone;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onuser_IDChanging(int value);
    partial void Onuser_IDChanged();
    partial void OnusernameChanging(string value);
    partial void OnusernameChanged();
    partial void OnpasswordChanging(string value);
    partial void OnpasswordChanged();
    partial void OnpowerChanging(int value);
    partial void OnpowerChanged();
    partial void OnfullnameChanging(string value);
    partial void OnfullnameChanged();
    partial void OnaddressChanging(string value);
    partial void OnaddressChanged();
    partial void OnemailChanging(string value);
    partial void OnemailChanged();
    partial void OnphoneChanging(string value);
    partial void OnphoneChanged();
    #endregion
		
		public tblUser()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_user_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int user_ID
		{
			get
			{
				return this._user_ID;
			}
			set
			{
				if ((this._user_ID != value))
				{
					this.Onuser_IDChanging(value);
					this.SendPropertyChanging();
					this._user_ID = value;
					this.SendPropertyChanged("user_ID");
					this.Onuser_IDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_username", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string username
		{
			get
			{
				return this._username;
			}
			set
			{
				if ((this._username != value))
				{
					this.OnusernameChanging(value);
					this.SendPropertyChanging();
					this._username = value;
					this.SendPropertyChanged("username");
					this.OnusernameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_password", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string password
		{
			get
			{
				return this._password;
			}
			set
			{
				if ((this._password != value))
				{
					this.OnpasswordChanging(value);
					this.SendPropertyChanging();
					this._password = value;
					this.SendPropertyChanged("password");
					this.OnpasswordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_power", DbType="Int NOT NULL")]
		public int power
		{
			get
			{
				return this._power;
			}
			set
			{
				if ((this._power != value))
				{
					this.OnpowerChanging(value);
					this.SendPropertyChanging();
					this._power = value;
					this.SendPropertyChanged("power");
					this.OnpowerChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_fullname", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string fullname
		{
			get
			{
				return this._fullname;
			}
			set
			{
				if ((this._fullname != value))
				{
					this.OnfullnameChanging(value);
					this.SendPropertyChanging();
					this._fullname = value;
					this.SendPropertyChanged("fullname");
					this.OnfullnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_address", DbType="NVarChar(150) NOT NULL", CanBeNull=false)]
		public string address
		{
			get
			{
				return this._address;
			}
			set
			{
				if ((this._address != value))
				{
					this.OnaddressChanging(value);
					this.SendPropertyChanging();
					this._address = value;
					this.SendPropertyChanged("address");
					this.OnaddressChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_email", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string email
		{
			get
			{
				return this._email;
			}
			set
			{
				if ((this._email != value))
				{
					this.OnemailChanging(value);
					this.SendPropertyChanging();
					this._email = value;
					this.SendPropertyChanged("email");
					this.OnemailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_phone", DbType="VarChar(15) NOT NULL", CanBeNull=false)]
		public string phone
		{
			get
			{
				return this._phone;
			}
			set
			{
				if ((this._phone != value))
				{
					this.OnphoneChanging(value);
					this.SendPropertyChanging();
					this._phone = value;
					this.SendPropertyChanged("phone");
					this.OnphoneChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tblCategory")]
	public partial class tblCategory : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _category_ID;
		
		private string _title;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Oncategory_IDChanging(int value);
    partial void Oncategory_IDChanged();
    partial void OntitleChanging(string value);
    partial void OntitleChanged();
    #endregion
		
		public tblCategory()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_category_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int category_ID
		{
			get
			{
				return this._category_ID;
			}
			set
			{
				if ((this._category_ID != value))
				{
					this.Oncategory_IDChanging(value);
					this.SendPropertyChanging();
					this._category_ID = value;
					this.SendPropertyChanged("category_ID");
					this.Oncategory_IDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_title", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string title
		{
			get
			{
				return this._title;
			}
			set
			{
				if ((this._title != value))
				{
					this.OntitleChanging(value);
					this.SendPropertyChanging();
					this._title = value;
					this.SendPropertyChanged("title");
					this.OntitleChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tblNews")]
	public partial class tblNew : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _news_ID;
		
		private int _category_ID;
		
		private string _author_ID;
		
		private string _title;
		
		private string _body;
		
		private string _picture;
		
		private System.DateTime _date;
		
		private System.Nullable<int> _views;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onnews_IDChanging(int value);
    partial void Onnews_IDChanged();
    partial void Oncategory_IDChanging(int value);
    partial void Oncategory_IDChanged();
    partial void Onauthor_IDChanging(string value);
    partial void Onauthor_IDChanged();
    partial void OntitleChanging(string value);
    partial void OntitleChanged();
    partial void OnbodyChanging(string value);
    partial void OnbodyChanged();
    partial void OnpictureChanging(string value);
    partial void OnpictureChanged();
    partial void OndateChanging(System.DateTime value);
    partial void OndateChanged();
    partial void OnviewsChanging(System.Nullable<int> value);
    partial void OnviewsChanged();
    #endregion
		
		public tblNew()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_news_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int news_ID
		{
			get
			{
				return this._news_ID;
			}
			set
			{
				if ((this._news_ID != value))
				{
					this.Onnews_IDChanging(value);
					this.SendPropertyChanging();
					this._news_ID = value;
					this.SendPropertyChanged("news_ID");
					this.Onnews_IDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_category_ID", DbType="Int NOT NULL")]
		public int category_ID
		{
			get
			{
				return this._category_ID;
			}
			set
			{
				if ((this._category_ID != value))
				{
					this.Oncategory_IDChanging(value);
					this.SendPropertyChanging();
					this._category_ID = value;
					this.SendPropertyChanged("category_ID");
					this.Oncategory_IDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_author_ID", DbType="NChar(10) NOT NULL", CanBeNull=false)]
		public string author_ID
		{
			get
			{
				return this._author_ID;
			}
			set
			{
				if ((this._author_ID != value))
				{
					this.Onauthor_IDChanging(value);
					this.SendPropertyChanging();
					this._author_ID = value;
					this.SendPropertyChanged("author_ID");
					this.Onauthor_IDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_title", DbType="NVarChar(500) NOT NULL", CanBeNull=false)]
		public string title
		{
			get
			{
				return this._title;
			}
			set
			{
				if ((this._title != value))
				{
					this.OntitleChanging(value);
					this.SendPropertyChanging();
					this._title = value;
					this.SendPropertyChanged("title");
					this.OntitleChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_body", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string body
		{
			get
			{
				return this._body;
			}
			set
			{
				if ((this._body != value))
				{
					this.OnbodyChanging(value);
					this.SendPropertyChanging();
					this._body = value;
					this.SendPropertyChanged("body");
					this.OnbodyChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_picture", DbType="VarChar(200)")]
		public string picture
		{
			get
			{
				return this._picture;
			}
			set
			{
				if ((this._picture != value))
				{
					this.OnpictureChanging(value);
					this.SendPropertyChanging();
					this._picture = value;
					this.SendPropertyChanged("picture");
					this.OnpictureChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_date", DbType="DateTime NOT NULL")]
		public System.DateTime date
		{
			get
			{
				return this._date;
			}
			set
			{
				if ((this._date != value))
				{
					this.OndateChanging(value);
					this.SendPropertyChanging();
					this._date = value;
					this.SendPropertyChanged("date");
					this.OndateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_views", DbType="Int")]
		public System.Nullable<int> views
		{
			get
			{
				return this._views;
			}
			set
			{
				if ((this._views != value))
				{
					this.OnviewsChanging(value);
					this.SendPropertyChanging();
					this._views = value;
					this.SendPropertyChanged("views");
					this.OnviewsChanged();
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
	
	public partial class tblNews_SelectIDResult
	{
		
		private int _news_ID;
		
		private int _category_ID;
		
		private string _author_ID;
		
		private string _title;
		
		private string _body;
		
		private string _picture;
		
		private System.DateTime _date;
		
		private System.Nullable<int> _views;
		
		public tblNews_SelectIDResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_news_ID", DbType="Int NOT NULL")]
		public int news_ID
		{
			get
			{
				return this._news_ID;
			}
			set
			{
				if ((this._news_ID != value))
				{
					this._news_ID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_category_ID", DbType="Int NOT NULL")]
		public int category_ID
		{
			get
			{
				return this._category_ID;
			}
			set
			{
				if ((this._category_ID != value))
				{
					this._category_ID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_author_ID", DbType="NChar(10) NOT NULL", CanBeNull=false)]
		public string author_ID
		{
			get
			{
				return this._author_ID;
			}
			set
			{
				if ((this._author_ID != value))
				{
					this._author_ID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_title", DbType="NVarChar(500) NOT NULL", CanBeNull=false)]
		public string title
		{
			get
			{
				return this._title;
			}
			set
			{
				if ((this._title != value))
				{
					this._title = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_body", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string body
		{
			get
			{
				return this._body;
			}
			set
			{
				if ((this._body != value))
				{
					this._body = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_picture", DbType="VarChar(200)")]
		public string picture
		{
			get
			{
				return this._picture;
			}
			set
			{
				if ((this._picture != value))
				{
					this._picture = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_date", DbType="DateTime NOT NULL")]
		public System.DateTime date
		{
			get
			{
				return this._date;
			}
			set
			{
				if ((this._date != value))
				{
					this._date = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_views", DbType="Int")]
		public System.Nullable<int> views
		{
			get
			{
				return this._views;
			}
			set
			{
				if ((this._views != value))
				{
					this._views = value;
				}
			}
		}
	}
	
	public partial class tblNews_SelectAllResult
	{
		
		private int _news_ID;
		
		private int _category_ID;
		
		private string _author_ID;
		
		private string _title;
		
		private string _body;
		
		private string _picture;
		
		private System.DateTime _date;
		
		private System.Nullable<int> _views;
		
		public tblNews_SelectAllResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_news_ID", DbType="Int NOT NULL")]
		public int news_ID
		{
			get
			{
				return this._news_ID;
			}
			set
			{
				if ((this._news_ID != value))
				{
					this._news_ID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_category_ID", DbType="Int NOT NULL")]
		public int category_ID
		{
			get
			{
				return this._category_ID;
			}
			set
			{
				if ((this._category_ID != value))
				{
					this._category_ID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_author_ID", DbType="NChar(10) NOT NULL", CanBeNull=false)]
		public string author_ID
		{
			get
			{
				return this._author_ID;
			}
			set
			{
				if ((this._author_ID != value))
				{
					this._author_ID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_title", DbType="NVarChar(500) NOT NULL", CanBeNull=false)]
		public string title
		{
			get
			{
				return this._title;
			}
			set
			{
				if ((this._title != value))
				{
					this._title = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_body", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string body
		{
			get
			{
				return this._body;
			}
			set
			{
				if ((this._body != value))
				{
					this._body = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_picture", DbType="VarChar(200)")]
		public string picture
		{
			get
			{
				return this._picture;
			}
			set
			{
				if ((this._picture != value))
				{
					this._picture = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_date", DbType="DateTime NOT NULL")]
		public System.DateTime date
		{
			get
			{
				return this._date;
			}
			set
			{
				if ((this._date != value))
				{
					this._date = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_views", DbType="Int")]
		public System.Nullable<int> views
		{
			get
			{
				return this._views;
			}
			set
			{
				if ((this._views != value))
				{
					this._views = value;
				}
			}
		}
	}
	
	public partial class tblNews_SelectResult
	{
		
		private int _news_ID;
		
		private int _category_ID;
		
		private string _author_ID;
		
		private string _title;
		
		private string _body;
		
		private string _picture;
		
		private System.DateTime _date;
		
		private System.Nullable<int> _views;
		
		public tblNews_SelectResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_news_ID", DbType="Int NOT NULL")]
		public int news_ID
		{
			get
			{
				return this._news_ID;
			}
			set
			{
				if ((this._news_ID != value))
				{
					this._news_ID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_category_ID", DbType="Int NOT NULL")]
		public int category_ID
		{
			get
			{
				return this._category_ID;
			}
			set
			{
				if ((this._category_ID != value))
				{
					this._category_ID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_author_ID", DbType="NChar(10) NOT NULL", CanBeNull=false)]
		public string author_ID
		{
			get
			{
				return this._author_ID;
			}
			set
			{
				if ((this._author_ID != value))
				{
					this._author_ID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_title", DbType="NVarChar(500) NOT NULL", CanBeNull=false)]
		public string title
		{
			get
			{
				return this._title;
			}
			set
			{
				if ((this._title != value))
				{
					this._title = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_body", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string body
		{
			get
			{
				return this._body;
			}
			set
			{
				if ((this._body != value))
				{
					this._body = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_picture", DbType="VarChar(200)")]
		public string picture
		{
			get
			{
				return this._picture;
			}
			set
			{
				if ((this._picture != value))
				{
					this._picture = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_date", DbType="DateTime NOT NULL")]
		public System.DateTime date
		{
			get
			{
				return this._date;
			}
			set
			{
				if ((this._date != value))
				{
					this._date = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_views", DbType="Int")]
		public System.Nullable<int> views
		{
			get
			{
				return this._views;
			}
			set
			{
				if ((this._views != value))
				{
					this._views = value;
				}
			}
		}
	}
	
	public partial class tblCategory_SelectAllResult
	{
		
		private int _category_ID;
		
		private string _title;
		
		public tblCategory_SelectAllResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_category_ID", DbType="Int NOT NULL")]
		public int category_ID
		{
			get
			{
				return this._category_ID;
			}
			set
			{
				if ((this._category_ID != value))
				{
					this._category_ID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_title", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string title
		{
			get
			{
				return this._title;
			}
			set
			{
				if ((this._title != value))
				{
					this._title = value;
				}
			}
		}
	}
}
#pragma warning restore 1591
