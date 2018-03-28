﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     //
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Evolution.Textkernel.Extract
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://home.textkernel.nl/sourcebox/soap/extract")]
    public partial class ExtractException
    {
        
        private string descriptionField;
        
        private int idField;
        
        private bool idFieldSpecified;
        
        private string outputStatusNameField;
        
        private string severityField;
        
        private string solutionField;
        
        private string tkURLField;
        
        private string messageField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public int id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool idSpecified
        {
            get
            {
                return this.idFieldSpecified;
            }
            set
            {
                this.idFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public string outputStatusName
        {
            get
            {
                return this.outputStatusNameField;
            }
            set
            {
                this.outputStatusNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public string severity
        {
            get
            {
                return this.severityField;
            }
            set
            {
                this.severityField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public string solution
        {
            get
            {
                return this.solutionField;
            }
            set
            {
                this.solutionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=5)]
        public string tkURL
        {
            get
            {
                return this.tkURLField;
            }
            set
            {
                this.tkURLField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=6)]
        public string message
        {
            get
            {
                return this.messageField;
            }
            set
            {
                this.messageField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://home.textkernel.nl/sourcebox/soap/extract")]
    public partial class entry
    {
        
        private string keyField;
        
        private string valueField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string key
        {
            get
            {
                return this.keyField;
            }
            set
            {
                this.keyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://home.textkernel.nl/sourcebox/soap/extract", ConfigurationName="Evolution.Textkernel.Extract.ExtractInterface")]
    internal interface ExtractInterface
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://home.textkernel.nl/sourcebox/soap/extract/ExtractInterface/extractRequest", ReplyAction="http://home.textkernel.nl/sourcebox/soap/extract/ExtractInterface/extractResponse" +
            "")]
        [System.ServiceModel.FaultContractAttribute(typeof(Evolution.Textkernel.Extract.ExtractException), Action="http://home.textkernel.nl/sourcebox/soap/extract/ExtractInterface/extract/Fault/E" +
            "xtractException", Name="ExtractException")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<Evolution.Textkernel.Extract.extractResponse> extractAsync(Evolution.Textkernel.Extract.extractRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://home.textkernel.nl/sourcebox/soap/extract/ExtractInterface/extractAdvanced" +
            "Request", ReplyAction="http://home.textkernel.nl/sourcebox/soap/extract/ExtractInterface/extractAdvanced" +
            "Response")]
        [System.ServiceModel.FaultContractAttribute(typeof(Evolution.Textkernel.Extract.ExtractException), Action="http://home.textkernel.nl/sourcebox/soap/extract/ExtractInterface/extractAdvanced" +
            "/Fault/ExtractException", Name="ExtractException")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<Evolution.Textkernel.Extract.extractAdvancedResponse> extractAdvancedAsync(Evolution.Textkernel.Extract.extractAdvancedRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://home.textkernel.nl/sourcebox/soap/extract/ExtractInterface/extractURLReque" +
            "st", ReplyAction="http://home.textkernel.nl/sourcebox/soap/extract/ExtractInterface/extractURLRespo" +
            "nse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Evolution.Textkernel.Extract.ExtractException), Action="http://home.textkernel.nl/sourcebox/soap/extract/ExtractInterface/extractURL/Faul" +
            "t/ExtractException", Name="ExtractException")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<Evolution.Textkernel.Extract.extractURLResponse> extractURLAsync(Evolution.Textkernel.Extract.extractURLRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="extract", WrapperNamespace="http://home.textkernel.nl/sourcebox/soap/extract", IsWrapped=true)]
    internal partial class extractRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://home.textkernel.nl/sourcebox/soap/extract", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string account;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://home.textkernel.nl/sourcebox/soap/extract", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string username;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://home.textkernel.nl/sourcebox/soap/extract", Order=2)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string password;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://home.textkernel.nl/sourcebox/soap/extract", Order=3)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string fileName;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://home.textkernel.nl/sourcebox/soap/extract", Order=4)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="base64Binary", IsNullable=true)]
        public byte[] fileContent;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://home.textkernel.nl/sourcebox/soap/extract", Order=5)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="base64Binary", IsNullable=true)]
        public byte[] tmfFileContent;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://home.textkernel.nl/sourcebox/soap/extract", Order=6)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="base64Binary", IsNullable=true)]
        public byte[] apimap;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://home.textkernel.nl/sourcebox/soap/extract", Order=7)]
        [System.Xml.Serialization.XmlElementAttribute("options", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)]
        public Evolution.Textkernel.Extract.entry[] options;
        
        public extractRequest()
        {
        }
        
        public extractRequest(string account, string username, string password, string fileName, byte[] fileContent, byte[] tmfFileContent, byte[] apimap, Evolution.Textkernel.Extract.entry[] options)
        {
            this.account = account;
            this.username = username;
            this.password = password;
            this.fileName = fileName;
            this.fileContent = fileContent;
            this.tmfFileContent = tmfFileContent;
            this.apimap = apimap;
            this.options = options;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="extractResponse", WrapperNamespace="http://home.textkernel.nl/sourcebox/soap/extract", IsWrapped=true)]
    internal partial class extractResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://home.textkernel.nl/sourcebox/soap/extract", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string @return;
        
        public extractResponse()
        {
        }
        
        public extractResponse(string @return)
        {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="extractAdvanced", WrapperNamespace="http://home.textkernel.nl/sourcebox/soap/extract", IsWrapped=true)]
    internal partial class extractAdvancedRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://home.textkernel.nl/sourcebox/soap/extract", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string account;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://home.textkernel.nl/sourcebox/soap/extract", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string username;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://home.textkernel.nl/sourcebox/soap/extract", Order=2)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string password;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://home.textkernel.nl/sourcebox/soap/extract", Order=3)]
        [System.Xml.Serialization.XmlElementAttribute("clientSpecificArguments", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)]
        public Evolution.Textkernel.Extract.entry[] clientSpecificArguments;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://home.textkernel.nl/sourcebox/soap/extract", Order=4)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string fileName;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://home.textkernel.nl/sourcebox/soap/extract", Order=5)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="base64Binary", IsNullable=true)]
        public byte[] fileContent;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://home.textkernel.nl/sourcebox/soap/extract", Order=6)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="base64Binary", IsNullable=true)]
        public byte[] tmfFileContent;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://home.textkernel.nl/sourcebox/soap/extract", Order=7)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="base64Binary", IsNullable=true)]
        public byte[] apimap;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://home.textkernel.nl/sourcebox/soap/extract", Order=8)]
        [System.Xml.Serialization.XmlElementAttribute("options", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)]
        public Evolution.Textkernel.Extract.entry[] options;
        
        public extractAdvancedRequest()
        {
        }
        
        public extractAdvancedRequest(string account, string username, string password, Evolution.Textkernel.Extract.entry[] clientSpecificArguments, string fileName, byte[] fileContent, byte[] tmfFileContent, byte[] apimap, Evolution.Textkernel.Extract.entry[] options)
        {
            this.account = account;
            this.username = username;
            this.password = password;
            this.clientSpecificArguments = clientSpecificArguments;
            this.fileName = fileName;
            this.fileContent = fileContent;
            this.tmfFileContent = tmfFileContent;
            this.apimap = apimap;
            this.options = options;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="extractAdvancedResponse", WrapperNamespace="http://home.textkernel.nl/sourcebox/soap/extract", IsWrapped=true)]
    internal partial class extractAdvancedResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://home.textkernel.nl/sourcebox/soap/extract", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string @return;
        
        public extractAdvancedResponse()
        {
        }
        
        public extractAdvancedResponse(string @return)
        {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="extractURL", WrapperNamespace="http://home.textkernel.nl/sourcebox/soap/extract", IsWrapped=true)]
    internal partial class extractURLRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://home.textkernel.nl/sourcebox/soap/extract", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string account;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://home.textkernel.nl/sourcebox/soap/extract", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string username;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://home.textkernel.nl/sourcebox/soap/extract", Order=2)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string password;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://home.textkernel.nl/sourcebox/soap/extract", Order=3)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string publicURL;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://home.textkernel.nl/sourcebox/soap/extract", Order=4)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string outputType;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://home.textkernel.nl/sourcebox/soap/extract", Order=5)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string customQueryString;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://home.textkernel.nl/sourcebox/soap/extract", Order=6)]
        [System.Xml.Serialization.XmlElementAttribute("options", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)]
        public Evolution.Textkernel.Extract.entry[] options;
        
        public extractURLRequest()
        {
        }
        
        public extractURLRequest(string account, string username, string password, string publicURL, string outputType, string customQueryString, Evolution.Textkernel.Extract.entry[] options)
        {
            this.account = account;
            this.username = username;
            this.password = password;
            this.publicURL = publicURL;
            this.outputType = outputType;
            this.customQueryString = customQueryString;
            this.options = options;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="extractURLResponse", WrapperNamespace="http://home.textkernel.nl/sourcebox/soap/extract", IsWrapped=true)]
    internal partial class extractURLResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://home.textkernel.nl/sourcebox/soap/extract", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="base64Binary", IsNullable=true)]
        public byte[] @return;
        
        public extractURLResponse()
        {
        }
        
        public extractURLResponse(byte[] @return)
        {
            this.@return = @return;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    internal interface ExtractInterfaceChannel : Evolution.Textkernel.Extract.ExtractInterface, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    internal partial class ExtractInterfaceClient : System.ServiceModel.ClientBase<Evolution.Textkernel.Extract.ExtractInterface>, Evolution.Textkernel.Extract.ExtractInterface
    {
        
    /// <summary>
    /// Implement this partial method to configure the service endpoint.
    /// </summary>
    /// <param name="serviceEndpoint">The endpoint to configure</param>
    /// <param name="clientCredentials">The client credentials</param>
    static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public ExtractInterfaceClient() : 
                base(ExtractInterfaceClient.GetDefaultBinding(), ExtractInterfaceClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.ExtractImplPort.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ExtractInterfaceClient(EndpointConfiguration endpointConfiguration) : 
                base(ExtractInterfaceClient.GetBindingForEndpoint(endpointConfiguration), ExtractInterfaceClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ExtractInterfaceClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(ExtractInterfaceClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ExtractInterfaceClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(ExtractInterfaceClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ExtractInterfaceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Evolution.Textkernel.Extract.extractResponse> Evolution.Textkernel.Extract.ExtractInterface.extractAsync(Evolution.Textkernel.Extract.extractRequest request)
        {
            return base.Channel.extractAsync(request);
        }
        
        public System.Threading.Tasks.Task<Evolution.Textkernel.Extract.extractResponse> extractAsync(string account, string username, string password, string fileName, byte[] fileContent, byte[] tmfFileContent, byte[] apimap, Evolution.Textkernel.Extract.entry[] options)
        {
            Evolution.Textkernel.Extract.extractRequest inValue = new Evolution.Textkernel.Extract.extractRequest();
            inValue.account = account;
            inValue.username = username;
            inValue.password = password;
            inValue.fileName = fileName;
            inValue.fileContent = fileContent;
            inValue.tmfFileContent = tmfFileContent;
            inValue.apimap = apimap;
            inValue.options = options;
            return ((Evolution.Textkernel.Extract.ExtractInterface)(this)).extractAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Evolution.Textkernel.Extract.extractAdvancedResponse> Evolution.Textkernel.Extract.ExtractInterface.extractAdvancedAsync(Evolution.Textkernel.Extract.extractAdvancedRequest request)
        {
            return base.Channel.extractAdvancedAsync(request);
        }
        
        public System.Threading.Tasks.Task<Evolution.Textkernel.Extract.extractAdvancedResponse> extractAdvancedAsync(string account, string username, string password, Evolution.Textkernel.Extract.entry[] clientSpecificArguments, string fileName, byte[] fileContent, byte[] tmfFileContent, byte[] apimap, Evolution.Textkernel.Extract.entry[] options)
        {
            Evolution.Textkernel.Extract.extractAdvancedRequest inValue = new Evolution.Textkernel.Extract.extractAdvancedRequest();
            inValue.account = account;
            inValue.username = username;
            inValue.password = password;
            inValue.clientSpecificArguments = clientSpecificArguments;
            inValue.fileName = fileName;
            inValue.fileContent = fileContent;
            inValue.tmfFileContent = tmfFileContent;
            inValue.apimap = apimap;
            inValue.options = options;
            return ((Evolution.Textkernel.Extract.ExtractInterface)(this)).extractAdvancedAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Evolution.Textkernel.Extract.extractURLResponse> Evolution.Textkernel.Extract.ExtractInterface.extractURLAsync(Evolution.Textkernel.Extract.extractURLRequest request)
        {
            return base.Channel.extractURLAsync(request);
        }
        
        public System.Threading.Tasks.Task<Evolution.Textkernel.Extract.extractURLResponse> extractURLAsync(string account, string username, string password, string publicURL, string outputType, string customQueryString, Evolution.Textkernel.Extract.entry[] options)
        {
            Evolution.Textkernel.Extract.extractURLRequest inValue = new Evolution.Textkernel.Extract.extractURLRequest();
            inValue.account = account;
            inValue.username = username;
            inValue.password = password;
            inValue.publicURL = publicURL;
            inValue.outputType = outputType;
            inValue.customQueryString = customQueryString;
            inValue.options = options;
            return ((Evolution.Textkernel.Extract.ExtractInterface)(this)).extractURLAsync(inValue);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.ExtractImplPort))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                result.Security.Mode = System.ServiceModel.BasicHttpSecurityMode.Transport;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.ExtractImplPort))
            {
                return new System.ServiceModel.EndpointAddress("https://staging.textkernel.nl/match/soap/extract");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return ExtractInterfaceClient.GetBindingForEndpoint(EndpointConfiguration.ExtractImplPort);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return ExtractInterfaceClient.GetEndpointAddress(EndpointConfiguration.ExtractImplPort);
        }
        
        public enum EndpointConfiguration
        {
            
            ExtractImplPort,
        }
    }
}
