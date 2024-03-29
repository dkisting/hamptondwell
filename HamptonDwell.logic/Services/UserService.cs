﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.4963
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EBS.HamptonDwell.Web.Logic.Services.Users
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="UserRequest", Namespace="http://schemas.datacontract.org/2004/07/EBS.HamptonDwell.Services.Users")]
    public partial class UserRequest : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private bool ActiveField;
        
        private int CreatedByField;
        
        private string EmailField;
        
        private string FirstLetterField;
        
        private string FirstNameField;
        
        private string LastNameField;
        
        private int MaximumRowsField;
        
        private int ModifiedByField;
        
        private string PasswordField;
        
        private EBS.HamptonDwell.Web.Logic.Services.Users.SortBy SortByField;
        
        private EBS.HamptonDwell.Web.Logic.Services.Users.SortDirection SortDirectionField;
        
        private int StartRowIndexField;
        
        private int UserIdField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool Active
        {
            get
            {
                return this.ActiveField;
            }
            set
            {
                this.ActiveField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int CreatedBy
        {
            get
            {
                return this.CreatedByField;
            }
            set
            {
                this.CreatedByField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Email
        {
            get
            {
                return this.EmailField;
            }
            set
            {
                this.EmailField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FirstLetter
        {
            get
            {
                return this.FirstLetterField;
            }
            set
            {
                this.FirstLetterField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FirstName
        {
            get
            {
                return this.FirstNameField;
            }
            set
            {
                this.FirstNameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string LastName
        {
            get
            {
                return this.LastNameField;
            }
            set
            {
                this.LastNameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int MaximumRows
        {
            get
            {
                return this.MaximumRowsField;
            }
            set
            {
                this.MaximumRowsField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ModifiedBy
        {
            get
            {
                return this.ModifiedByField;
            }
            set
            {
                this.ModifiedByField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Password
        {
            get
            {
                return this.PasswordField;
            }
            set
            {
                this.PasswordField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public EBS.HamptonDwell.Web.Logic.Services.Users.SortBy SortBy
        {
            get
            {
                return this.SortByField;
            }
            set
            {
                this.SortByField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public EBS.HamptonDwell.Web.Logic.Services.Users.SortDirection SortDirection
        {
            get
            {
                return this.SortDirectionField;
            }
            set
            {
                this.SortDirectionField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int StartRowIndex
        {
            get
            {
                return this.StartRowIndexField;
            }
            set
            {
                this.StartRowIndexField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int UserId
        {
            get
            {
                return this.UserIdField;
            }
            set
            {
                this.UserIdField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="SortBy", Namespace="Services.Users")]
    public enum SortBy : int
    {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        LastName = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        FirstName = 2,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Email = 3,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="SortDirection", Namespace="Services.Users")]
    public enum SortDirection : int
    {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        ASC = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        DESC = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        NONE = 2,
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="UserResponse", Namespace="Services.Users")]
    public partial class UserResponse : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private int ResultSetCountField;
        
        private EBS.HamptonDwell.Web.Logic.Services.Users.UserObject UserField;
        
        private System.Collections.Generic.List<EBS.HamptonDwell.Web.Logic.Services.Users.UserObject> UserListField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ResultSetCount
        {
            get
            {
                return this.ResultSetCountField;
            }
            set
            {
                this.ResultSetCountField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public EBS.HamptonDwell.Web.Logic.Services.Users.UserObject User
        {
            get
            {
                return this.UserField;
            }
            set
            {
                this.UserField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Collections.Generic.List<EBS.HamptonDwell.Web.Logic.Services.Users.UserObject> UserList
        {
            get
            {
                return this.UserListField;
            }
            set
            {
                this.UserListField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="UserObject", Namespace="http://schemas.datacontract.org/2004/07/EBS.HamptonDwell.Services.Users")]
    public partial class UserObject : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private bool ActiveField;
        
        private int CreatedByUserIdField;
        
        private System.DateTime CreatedOnField;
        
        private string EmailField;
        
        private string FirstNameField;
        
        private string LastNameField;
        
        private int ModifiedByUserIdField;
        
        private System.DateTime ModifiedOnField;
        
        private string PasswordField;
        
        private int UserIdField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool Active
        {
            get
            {
                return this.ActiveField;
            }
            set
            {
                this.ActiveField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int CreatedByUserId
        {
            get
            {
                return this.CreatedByUserIdField;
            }
            set
            {
                this.CreatedByUserIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime CreatedOn
        {
            get
            {
                return this.CreatedOnField;
            }
            set
            {
                this.CreatedOnField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Email
        {
            get
            {
                return this.EmailField;
            }
            set
            {
                this.EmailField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FirstName
        {
            get
            {
                return this.FirstNameField;
            }
            set
            {
                this.FirstNameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string LastName
        {
            get
            {
                return this.LastNameField;
            }
            set
            {
                this.LastNameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ModifiedByUserId
        {
            get
            {
                return this.ModifiedByUserIdField;
            }
            set
            {
                this.ModifiedByUserIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime ModifiedOn
        {
            get
            {
                return this.ModifiedOnField;
            }
            set
            {
                this.ModifiedOnField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Password
        {
            get
            {
                return this.PasswordField;
            }
            set
            {
                this.PasswordField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int UserId
        {
            get
            {
                return this.UserIdField;
            }
            set
            {
                this.UserIdField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="UserFault", Namespace="http://schemas.datacontract.org/2004/07/EBS.HamptonDwell.Services.Users")]
    public partial class UserFault : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="urn:localhost/Users", ConfigurationName="EBS.HamptonDwell.Web.Logic.Services.Users.UserService")]
    public interface UserService
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="GetUserById", ReplyAction="GetUserResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(EBS.HamptonDwell.Web.Logic.Services.Users.UserFault), Action="", Name="UserFault", Namespace="UserFault")]
        EBS.HamptonDwell.Web.Logic.Services.Users.UserResponse GetUserById(EBS.HamptonDwell.Web.Logic.Services.Users.UserRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="GetUser", ReplyAction="GetUserResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(EBS.HamptonDwell.Web.Logic.Services.Users.UserFault), Action="", Name="UserFault", Namespace="UserFault")]
        EBS.HamptonDwell.Web.Logic.Services.Users.UserResponse GetUser(EBS.HamptonDwell.Web.Logic.Services.Users.UserRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="GetUserList", ReplyAction="GetUserResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(EBS.HamptonDwell.Web.Logic.Services.Users.UserFault), Action="", Name="UserFault", Namespace="UserFault")]
        EBS.HamptonDwell.Web.Logic.Services.Users.UserResponse GetUserList(EBS.HamptonDwell.Web.Logic.Services.Users.UserRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="SaveUser", ReplyAction="SaveUser")]
        [System.ServiceModel.FaultContractAttribute(typeof(EBS.HamptonDwell.Web.Logic.Services.Users.UserFault), Action="", Name="UserFault", Namespace="UserFault")]
        EBS.HamptonDwell.Web.Logic.Services.Users.UserResponse Save(EBS.HamptonDwell.Web.Logic.Services.Users.UserRequest request);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public interface UserServiceChannel : EBS.HamptonDwell.Web.Logic.Services.Users.UserService, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public partial class UserServiceClient : System.ServiceModel.ClientBase<EBS.HamptonDwell.Web.Logic.Services.Users.UserService>, EBS.HamptonDwell.Web.Logic.Services.Users.UserService
    {
        
        public UserServiceClient()
        {
        }
        
        public UserServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName)
        {
        }
        
        public UserServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress)
        {
        }
        
        public UserServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress)
        {
        }
        
        public UserServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public EBS.HamptonDwell.Web.Logic.Services.Users.UserResponse GetUserById(EBS.HamptonDwell.Web.Logic.Services.Users.UserRequest request)
        {
            return base.Channel.GetUserById(request);
        }
        
        public EBS.HamptonDwell.Web.Logic.Services.Users.UserResponse GetUser(EBS.HamptonDwell.Web.Logic.Services.Users.UserRequest request)
        {
            return base.Channel.GetUser(request);
        }
        
        public EBS.HamptonDwell.Web.Logic.Services.Users.UserResponse GetUserList(EBS.HamptonDwell.Web.Logic.Services.Users.UserRequest request)
        {
            return base.Channel.GetUserList(request);
        }
        
        public EBS.HamptonDwell.Web.Logic.Services.Users.UserResponse Save(EBS.HamptonDwell.Web.Logic.Services.Users.UserRequest request)
        {
            return base.Channel.Save(request);
        }
    }
}
