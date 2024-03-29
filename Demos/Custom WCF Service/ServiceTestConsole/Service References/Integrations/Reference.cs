﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.269
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServiceTestConsole.Integrations {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="SecurityInfo", Namespace="http://schemas.datacontract.org/2004/07/PermissionServiceWCF")]
    [System.SerializableAttribute()]
    public partial class SecurityInfo : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PermissionLevelField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string RessourceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SecurityPrincipalField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PermissionLevel {
            get {
                return this.PermissionLevelField;
            }
            set {
                if ((object.ReferenceEquals(this.PermissionLevelField, value) != true)) {
                    this.PermissionLevelField = value;
                    this.RaisePropertyChanged("PermissionLevel");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Ressource {
            get {
                return this.RessourceField;
            }
            set {
                if ((object.ReferenceEquals(this.RessourceField, value) != true)) {
                    this.RessourceField = value;
                    this.RaisePropertyChanged("Ressource");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string SecurityPrincipal {
            get {
                return this.SecurityPrincipalField;
            }
            set {
                if ((object.ReferenceEquals(this.SecurityPrincipalField, value) != true)) {
                    this.SecurityPrincipalField = value;
                    this.RaisePropertyChanged("SecurityPrincipal");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="Integrations.IPermissionService")]
    public interface IPermissionService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPermissionService/GetPermissions", ReplyAction="http://tempuri.org/IPermissionService/GetPermissionsResponse")]
        ServiceTestConsole.Integrations.SecurityInfo[] GetPermissions(string SiteURL, string Web);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IPermissionServiceChannel : ServiceTestConsole.Integrations.IPermissionService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class PermissionServiceClient : System.ServiceModel.ClientBase<ServiceTestConsole.Integrations.IPermissionService>, ServiceTestConsole.Integrations.IPermissionService {
        
        public PermissionServiceClient() {
        }
        
        public PermissionServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public PermissionServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PermissionServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PermissionServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public ServiceTestConsole.Integrations.SecurityInfo[] GetPermissions(string SiteURL, string Web) {
            return base.Channel.GetPermissions(SiteURL, Web);
        }
    }
}
