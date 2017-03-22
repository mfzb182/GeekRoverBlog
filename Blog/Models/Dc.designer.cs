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

namespace Blog.Models
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Blog")]
	public partial class DcDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    #endregion
		
		public DcDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["BlogConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DcDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DcDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DcDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DcDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Menu> Menus
		{
			get
			{
				return this.GetTable<Menu>();
			}
		}
		
		public System.Data.Linq.Table<File> Files
		{
			get
			{
				return this.GetTable<File>();
			}
		}
		
		public System.Data.Linq.Table<Group> Groups
		{
			get
			{
				return this.GetTable<Group>();
			}
		}
		
		public System.Data.Linq.Table<Post> Posts
		{
			get
			{
				return this.GetTable<Post>();
			}
		}
		
		public System.Data.Linq.Table<Image> Images
		{
			get
			{
				return this.GetTable<Image>();
			}
		}
		
		public System.Data.Linq.Table<Admin> Admins
		{
			get
			{
				return this.GetTable<Admin>();
			}
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.Admin_Delete")]
		public int Admin_Delete([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(15)")] string username)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), username);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.Admin_Insert")]
		public int Admin_Insert([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(15)")] string username, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(500)")] string fullname, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(600)")] string password)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), username, fullname, password);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.Admin_Login")]
		public ISingleResult<Admin_LoginResult> Admin_Login([global::System.Data.Linq.Mapping.ParameterAttribute(Name="Username", DbType="NVarChar(15)")] string username, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Password", DbType="NVarChar(500)")] string password)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), username, password);
			return ((ISingleResult<Admin_LoginResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.File_Delete")]
		public int File_Delete([global::System.Data.Linq.Mapping.ParameterAttribute(Name="Id", DbType="UniqueIdentifier")] System.Nullable<System.Guid> id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), id);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.File_Insert")]
		public int File_Insert([global::System.Data.Linq.Mapping.ParameterAttribute(Name="Name", DbType="NVarChar(300)")] string name, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Content", DbType="VarBinary(MAX)")] System.Data.Linq.Binary content, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Type", DbType="NVarChar(10)")] string type, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Admin_Username", DbType="NVarChar(15)")] string admin_Username)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), name, content, type, admin_Username);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.File_Update")]
		public int File_Update([global::System.Data.Linq.Mapping.ParameterAttribute(Name="Id", DbType="UniqueIdentifier")] System.Nullable<System.Guid> id, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Name", DbType="NVarChar(300)")] string name, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Content", DbType="VarBinary(MAX)")] System.Data.Linq.Binary content)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), id, name, content);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.Post_Delete")]
		public int Post_Delete([global::System.Data.Linq.Mapping.ParameterAttribute(Name="Id", DbType="UniqueIdentifier")] System.Nullable<System.Guid> id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), id);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.Post_Insert")]
		public int Post_Insert([global::System.Data.Linq.Mapping.ParameterAttribute(Name="Title", DbType="NVarChar(300)")] string title, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Abstract", DbType="NVarChar(3000)")] string @abstract, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Body", DbType="NVarChar(MAX)")] string body, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Group_Id", DbType="UniqueIdentifier")] System.Nullable<System.Guid> group_Id, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Admin_Username", DbType="NVarChar(15)")] string admin_Username)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), title, @abstract, body, group_Id, admin_Username);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.Post_Update")]
		public int Post_Update([global::System.Data.Linq.Mapping.ParameterAttribute(Name="Id", DbType="UniqueIdentifier")] System.Nullable<System.Guid> id, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Title", DbType="NVarChar(300)")] string title, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Abstract", DbType="NVarChar(3000)")] string @abstract, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Body", DbType="NVarChar(MAX)")] string body, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Group_Id", DbType="UniqueIdentifier")] System.Nullable<System.Guid> group_Id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), id, title, @abstract, body, group_Id);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.Group_Delete")]
		public int Group_Delete([global::System.Data.Linq.Mapping.ParameterAttribute(Name="Id", DbType="UniqueIdentifier")] System.Nullable<System.Guid> id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), id);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.Group_Insert")]
		public int Group_Insert([global::System.Data.Linq.Mapping.ParameterAttribute(Name="Name", DbType="NVarChar(150)")] string name)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), name);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.Group_Update")]
		public int Group_Update([global::System.Data.Linq.Mapping.ParameterAttribute(Name="Id", DbType="UniqueIdentifier")] System.Nullable<System.Guid> id, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Name", DbType="NVarChar(150)")] string name)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), id, name);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.Image_Delete")]
		public int Image_Delete([global::System.Data.Linq.Mapping.ParameterAttribute(Name="Id", DbType="UniqueIdentifier")] System.Nullable<System.Guid> id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), id);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.Image_Insert")]
		public int Image_Insert([global::System.Data.Linq.Mapping.ParameterAttribute(Name="Alt", DbType="NVarChar(100)")] string alt, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Description", DbType="NVarChar(1000)")] string description, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Url", DbType="NVarChar(500)")] string url, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Admin_Username", DbType="NVarChar(15)")] string admin_Username)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), alt, description, url, admin_Username);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.Image_Update")]
		public int Image_Update([global::System.Data.Linq.Mapping.ParameterAttribute(Name="Id", DbType="UniqueIdentifier")] System.Nullable<System.Guid> id, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Alt", DbType="NVarChar(100)")] string alt, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Description", DbType="NVarChar(1000)")] string description, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Url", DbType="NVarChar(500)")] string url)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), id, alt, description, url);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.Admin_UpdatePassword")]
		public int Admin_UpdatePassword([global::System.Data.Linq.Mapping.ParameterAttribute(Name="Username", DbType="NVarChar(15)")] string username, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Prev", DbType="NVarChar(600)")] string prev, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Password", DbType="NVarChar(600)")] string password)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), username, prev, password);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.Admin_UpdatePic")]
		public int Admin_UpdatePic([global::System.Data.Linq.Mapping.ParameterAttribute(Name="Username", DbType="NVarChar(15)")] string username, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="ProfilePic", DbType="VarBinary(MAX)")] System.Data.Linq.Binary profilePic)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), username, profilePic);
			return ((int)(result.ReturnValue));
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Menu")]
	public partial class Menu
	{
		
		private System.Guid _Id;
		
		private string _Name;
		
		public Menu()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", DbType="UniqueIdentifier NOT NULL")]
		public System.Guid Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this._Id = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(150) NOT NULL", CanBeNull=false)]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this._Name = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.[File]")]
	public partial class File
	{
		
		private System.Guid _Id;
		
		private string _Name;
		
		private string _Type;
		
		private int _Size;
		
		private System.Data.Linq.Binary _Content;
		
		private string _Admin_Username;
		
		public File()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", DbType="UniqueIdentifier NOT NULL")]
		public System.Guid Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this._Id = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(300) NOT NULL", CanBeNull=false)]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this._Name = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Type", DbType="NVarChar(10) NOT NULL", CanBeNull=false)]
		public string Type
		{
			get
			{
				return this._Type;
			}
			set
			{
				if ((this._Type != value))
				{
					this._Type = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Size", DbType="Int NOT NULL")]
		public int Size
		{
			get
			{
				return this._Size;
			}
			set
			{
				if ((this._Size != value))
				{
					this._Size = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Content", DbType="VarBinary(MAX) NOT NULL", CanBeNull=false, UpdateCheck=UpdateCheck.Never)]
		public System.Data.Linq.Binary Content
		{
			get
			{
				return this._Content;
			}
			set
			{
				if ((this._Content != value))
				{
					this._Content = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Admin_Username", DbType="NVarChar(15) NOT NULL", CanBeNull=false)]
		public string Admin_Username
		{
			get
			{
				return this._Admin_Username;
			}
			set
			{
				if ((this._Admin_Username != value))
				{
					this._Admin_Username = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.[Group]")]
	public partial class Group
	{
		
		private System.Guid _Id;
		
		private string _Name;
		
		public Group()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", DbType="UniqueIdentifier NOT NULL")]
		public System.Guid Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this._Id = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(150) NOT NULL", CanBeNull=false)]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this._Name = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Post")]
	public partial class Post
	{
		
		private System.Guid _Id;
		
		private string _Title;
		
		private string _Abstract;
		
		private string _Body;
		
		private System.DateTime _Date;
		
		private System.Guid _Group_Id;
		
		private string _Admin_Username;
		
		private string _Group_Name;
		
		public Post()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", DbType="UniqueIdentifier NOT NULL")]
		public System.Guid Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this._Id = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Title", DbType="NVarChar(300) NOT NULL", CanBeNull=false)]
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
					this._Title = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Abstract", DbType="NVarChar(3000)")]
		public string Abstract
		{
			get
			{
				return this._Abstract;
			}
			set
			{
				if ((this._Abstract != value))
				{
					this._Abstract = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Body", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string Body
		{
			get
			{
				return this._Body;
			}
			set
			{
				if ((this._Body != value))
				{
					this._Body = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Date", DbType="DateTime NOT NULL")]
		public System.DateTime Date
		{
			get
			{
				return this._Date;
			}
			set
			{
				if ((this._Date != value))
				{
					this._Date = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Group_Id", DbType="UniqueIdentifier NOT NULL")]
		public System.Guid Group_Id
		{
			get
			{
				return this._Group_Id;
			}
			set
			{
				if ((this._Group_Id != value))
				{
					this._Group_Id = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Admin_Username", DbType="NVarChar(15)")]
		public string Admin_Username
		{
			get
			{
				return this._Admin_Username;
			}
			set
			{
				if ((this._Admin_Username != value))
				{
					this._Admin_Username = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Group_Name", DbType="NVarChar(150) NOT NULL", CanBeNull=false)]
		public string Group_Name
		{
			get
			{
				return this._Group_Name;
			}
			set
			{
				if ((this._Group_Name != value))
				{
					this._Group_Name = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Image")]
	public partial class Image
	{
		
		private System.Guid _Id;
		
		private string _Alt;
		
		private string _Description;
		
		private string _Admin_Username;
		
		private string _Url;
		
		public Image()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", DbType="UniqueIdentifier NOT NULL")]
		public System.Guid Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this._Id = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Alt", DbType="NVarChar(100)")]
		public string Alt
		{
			get
			{
				return this._Alt;
			}
			set
			{
				if ((this._Alt != value))
				{
					this._Alt = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Description", DbType="NVarChar(1000)")]
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
					this._Description = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Admin_Username", DbType="NVarChar(15) NOT NULL", CanBeNull=false)]
		public string Admin_Username
		{
			get
			{
				return this._Admin_Username;
			}
			set
			{
				if ((this._Admin_Username != value))
				{
					this._Admin_Username = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Url", DbType="NVarChar(500) NOT NULL", CanBeNull=false)]
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
					this._Url = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Admin")]
	public partial class Admin
	{
		
		private string _Username;
		
		private string _Fullname;
		
		private System.Data.Linq.Binary _ProfilePic;
		
		public Admin()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Username", DbType="NVarChar(15) NOT NULL", CanBeNull=false)]
		public string Username
		{
			get
			{
				return this._Username;
			}
			set
			{
				if ((this._Username != value))
				{
					this._Username = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Fullname", DbType="NVarChar(500) NOT NULL", CanBeNull=false)]
		public string Fullname
		{
			get
			{
				return this._Fullname;
			}
			set
			{
				if ((this._Fullname != value))
				{
					this._Fullname = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProfilePic", DbType="VarBinary(MAX)", UpdateCheck=UpdateCheck.Never)]
		public System.Data.Linq.Binary ProfilePic
		{
			get
			{
				return this._ProfilePic;
			}
			set
			{
				if ((this._ProfilePic != value))
				{
					this._ProfilePic = value;
				}
			}
		}
	}
	
	public partial class Admin_LoginResult
	{
		
		private string _Username;
		
		public Admin_LoginResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Username", DbType="NVarChar(15) NOT NULL", CanBeNull=false)]
		public string Username
		{
			get
			{
				return this._Username;
			}
			set
			{
				if ((this._Username != value))
				{
					this._Username = value;
				}
			}
		}
	}
}
#pragma warning restore 1591