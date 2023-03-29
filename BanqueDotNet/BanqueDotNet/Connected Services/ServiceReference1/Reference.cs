﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//
//     Les changements apportés à ce fichier peuvent provoquer un comportement incorrect et seront perdus si
//     le code est regénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServiceReference1
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://sid.org/", ConfigurationName="ServiceReference1.BanqueService")]
    public interface BanqueService
    {
        
        // CODEGEN : Le paramètre 'return' nécessite des informations de schéma supplémentaires qui ne peuvent pas être capturées en utilisant le mode du paramètre. L'attribut spécifique est 'Microsoft.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://sid.org/BanqueService/ConvertRequest", ReplyAction="http://sid.org/BanqueService/ConvertResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        ServiceReference1.ConvertResponse Convert(ServiceReference1.ConvertRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://sid.org/BanqueService/ConvertRequest", ReplyAction="http://sid.org/BanqueService/ConvertResponse")]
        System.Threading.Tasks.Task<ServiceReference1.ConvertResponse> ConvertAsync(ServiceReference1.ConvertRequest request);
        
        // CODEGEN : Le paramètre 'return' nécessite des informations de schéma supplémentaires qui ne peuvent pas être capturées en utilisant le mode du paramètre. L'attribut spécifique est 'Microsoft.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://sid.org/BanqueService/getCompteRequest", ReplyAction="http://sid.org/BanqueService/getCompteResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        ServiceReference1.getCompteResponse getCompte(ServiceReference1.getCompteRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://sid.org/BanqueService/getCompteRequest", ReplyAction="http://sid.org/BanqueService/getCompteResponse")]
        System.Threading.Tasks.Task<ServiceReference1.getCompteResponse> getCompteAsync(ServiceReference1.getCompteRequest request);
        
        // CODEGEN : Le paramètre 'return' nécessite des informations de schéma supplémentaires qui ne peuvent pas être capturées en utilisant le mode du paramètre. L'attribut spécifique est 'Microsoft.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://sid.org/BanqueService/listComptesRequest", ReplyAction="http://sid.org/BanqueService/listComptesResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        ServiceReference1.listComptesResponse listComptes(ServiceReference1.listComptesRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://sid.org/BanqueService/listComptesRequest", ReplyAction="http://sid.org/BanqueService/listComptesResponse")]
        System.Threading.Tasks.Task<ServiceReference1.listComptesResponse> listComptesAsync(ServiceReference1.listComptesRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="Convert", WrapperNamespace="http://sid.org/", IsWrapped=true)]
    public partial class ConvertRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://sid.org/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public double montant;
        
        public ConvertRequest()
        {
        }
        
        public ConvertRequest(double montant)
        {
            this.montant = montant;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ConvertResponse", WrapperNamespace="http://sid.org/", IsWrapped=true)]
    public partial class ConvertResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://sid.org/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public double @return;
        
        public ConvertResponse()
        {
        }
        
        public ConvertResponse(double @return)
        {
            this.@return = @return;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://sid.org/")]
    public partial class compte
    {
        
        private int codeField;
        
        private double soldeField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public int code
        {
            get
            {
                return this.codeField;
            }
            set
            {
                this.codeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public double solde
        {
            get
            {
                return this.soldeField;
            }
            set
            {
                this.soldeField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getCompte", WrapperNamespace="http://sid.org/", IsWrapped=true)]
    public partial class getCompteRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://sid.org/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int code;
        
        public getCompteRequest()
        {
        }
        
        public getCompteRequest(int code)
        {
            this.code = code;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getCompteResponse", WrapperNamespace="http://sid.org/", IsWrapped=true)]
    public partial class getCompteResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://sid.org/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ServiceReference1.compte @return;
        
        public getCompteResponse()
        {
        }
        
        public getCompteResponse(ServiceReference1.compte @return)
        {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="listComptes", WrapperNamespace="http://sid.org/", IsWrapped=true)]
    public partial class listComptesRequest
    {
        
        public listComptesRequest()
        {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="listComptesResponse", WrapperNamespace="http://sid.org/", IsWrapped=true)]
    public partial class listComptesResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://sid.org/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("return", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ServiceReference1.compte[] @return;
        
        public listComptesResponse()
        {
        }
        
        public listComptesResponse(ServiceReference1.compte[] @return)
        {
            this.@return = @return;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    public interface BanqueServiceChannel : ServiceReference1.BanqueService, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    public partial class BanqueServiceClient : System.ServiceModel.ClientBase<ServiceReference1.BanqueService>, ServiceReference1.BanqueService
    {
        
        /// <summary>
        /// Implémentez cette méthode partielle pour configurer le point de terminaison de service.
        /// </summary>
        /// <param name="serviceEndpoint">Point de terminaison à configurer</param>
        /// <param name="clientCredentials">Informations d'identification du client</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public BanqueServiceClient() : 
                base(BanqueServiceClient.GetDefaultBinding(), BanqueServiceClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.BanqueServicePort.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public BanqueServiceClient(EndpointConfiguration endpointConfiguration) : 
                base(BanqueServiceClient.GetBindingForEndpoint(endpointConfiguration), BanqueServiceClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public BanqueServiceClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(BanqueServiceClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public BanqueServiceClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(BanqueServiceClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public BanqueServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ServiceReference1.ConvertResponse ServiceReference1.BanqueService.Convert(ServiceReference1.ConvertRequest request)
        {
            return base.Channel.Convert(request);
        }
        
        public double Convert(double montant)
        {
            ServiceReference1.ConvertRequest inValue = new ServiceReference1.ConvertRequest();
            inValue.montant = montant;
            ServiceReference1.ConvertResponse retVal = ((ServiceReference1.BanqueService)(this)).Convert(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ServiceReference1.ConvertResponse> ServiceReference1.BanqueService.ConvertAsync(ServiceReference1.ConvertRequest request)
        {
            return base.Channel.ConvertAsync(request);
        }
        
        public System.Threading.Tasks.Task<ServiceReference1.ConvertResponse> ConvertAsync(double montant)
        {
            ServiceReference1.ConvertRequest inValue = new ServiceReference1.ConvertRequest();
            inValue.montant = montant;
            return ((ServiceReference1.BanqueService)(this)).ConvertAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ServiceReference1.getCompteResponse ServiceReference1.BanqueService.getCompte(ServiceReference1.getCompteRequest request)
        {
            return base.Channel.getCompte(request);
        }
        
        public ServiceReference1.compte getCompte(int code)
        {
            ServiceReference1.getCompteRequest inValue = new ServiceReference1.getCompteRequest();
            inValue.code = code;
            ServiceReference1.getCompteResponse retVal = ((ServiceReference1.BanqueService)(this)).getCompte(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ServiceReference1.getCompteResponse> ServiceReference1.BanqueService.getCompteAsync(ServiceReference1.getCompteRequest request)
        {
            return base.Channel.getCompteAsync(request);
        }
        
        public System.Threading.Tasks.Task<ServiceReference1.getCompteResponse> getCompteAsync(int code)
        {
            ServiceReference1.getCompteRequest inValue = new ServiceReference1.getCompteRequest();
            inValue.code = code;
            return ((ServiceReference1.BanqueService)(this)).getCompteAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ServiceReference1.listComptesResponse ServiceReference1.BanqueService.listComptes(ServiceReference1.listComptesRequest request)
        {
            return base.Channel.listComptes(request);
        }
        
        public ServiceReference1.compte[] listComptes()
        {
            ServiceReference1.listComptesRequest inValue = new ServiceReference1.listComptesRequest();
            ServiceReference1.listComptesResponse retVal = ((ServiceReference1.BanqueService)(this)).listComptes(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ServiceReference1.listComptesResponse> ServiceReference1.BanqueService.listComptesAsync(ServiceReference1.listComptesRequest request)
        {
            return base.Channel.listComptesAsync(request);
        }
        
        public System.Threading.Tasks.Task<ServiceReference1.listComptesResponse> listComptesAsync()
        {
            ServiceReference1.listComptesRequest inValue = new ServiceReference1.listComptesRequest();
            return ((ServiceReference1.BanqueService)(this)).listComptesAsync(inValue);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BanqueServicePort))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Le point de terminaison nommé \'{0}\' est introuvable.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BanqueServicePort))
            {
                return new System.ServiceModel.EndpointAddress("http://localhost:9191/");
            }
            throw new System.InvalidOperationException(string.Format("Le point de terminaison nommé \'{0}\' est introuvable.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return BanqueServiceClient.GetBindingForEndpoint(EndpointConfiguration.BanqueServicePort);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return BanqueServiceClient.GetEndpointAddress(EndpointConfiguration.BanqueServicePort);
        }
        
        public enum EndpointConfiguration
        {
            
            BanqueServicePort,
        }
    }
}
