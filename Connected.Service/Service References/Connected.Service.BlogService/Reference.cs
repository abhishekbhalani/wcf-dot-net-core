﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     //
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Connected.Service.BlogService
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.4.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Blog", Namespace="http://www.chsakell.com/dotnetcorewcfproxies")]
    public partial class Blog : object
    {
        
        private int IDField;
        
        private string NameField;
        
        private string OwnerField;
        
        private string URLField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ID
        {
            get
            {
                return this.IDField;
            }
            set
            {
                this.IDField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name
        {
            get
            {
                return this.NameField;
            }
            set
            {
                this.NameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Owner
        {
            get
            {
                return this.OwnerField;
            }
            set
            {
                this.OwnerField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string URL
        {
            get
            {
                return this.URLField;
            }
            set
            {
                this.URLField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.4.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://www.chsakell.com/dotnetcorewcfproxies", ConfigurationName="Connected.Service.BlogService.IBlogService")]
    public interface IBlogService
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.chsakell.com/dotnetcorewcfproxies/IBlogService/Add", ReplyAction="http://www.chsakell.com/dotnetcorewcfproxies/IBlogService/AddResponse")]
        System.Threading.Tasks.Task AddAsync(Connected.Service.BlogService.Blog blog);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.chsakell.com/dotnetcorewcfproxies/IBlogService/Update", ReplyAction="http://www.chsakell.com/dotnetcorewcfproxies/IBlogService/UpdateResponse")]
        System.Threading.Tasks.Task UpdateAsync(Connected.Service.BlogService.Blog blog);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.chsakell.com/dotnetcorewcfproxies/IBlogService/Delete", ReplyAction="http://www.chsakell.com/dotnetcorewcfproxies/IBlogService/DeleteResponse")]
        System.Threading.Tasks.Task DeleteAsync(Connected.Service.BlogService.Blog blog);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.chsakell.com/dotnetcorewcfproxies/IBlogService/GetById", ReplyAction="http://www.chsakell.com/dotnetcorewcfproxies/IBlogService/GetByIdResponse")]
        System.Threading.Tasks.Task<Connected.Service.BlogService.Blog> GetByIdAsync(int id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.4.0.0")]
    public interface IBlogServiceChannel : Connected.Service.BlogService.IBlogService, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.4.0.0")]
    public partial class BlogServiceClient : System.ServiceModel.ClientBase<Connected.Service.BlogService.IBlogService>, Connected.Service.BlogService.IBlogService
    {
        
    /// <summary>
    /// Implement this partial method to configure the service endpoint.
    /// </summary>
    /// <param name="serviceEndpoint">The endpoint to configure</param>
    /// <param name="clientCredentials">The client credentials</param>
    static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public BlogServiceClient() : 
                base(BlogServiceClient.GetDefaultBinding(), BlogServiceClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.BasicHttpBinding_IBlogService.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public BlogServiceClient(EndpointConfiguration endpointConfiguration) : 
                base(BlogServiceClient.GetBindingForEndpoint(endpointConfiguration), BlogServiceClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public BlogServiceClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(BlogServiceClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public BlogServiceClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(BlogServiceClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public BlogServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public System.Threading.Tasks.Task AddAsync(Connected.Service.BlogService.Blog blog)
        {
            return base.Channel.AddAsync(blog);
        }
        
        public System.Threading.Tasks.Task UpdateAsync(Connected.Service.BlogService.Blog blog)
        {
            return base.Channel.UpdateAsync(blog);
        }
        
        public System.Threading.Tasks.Task DeleteAsync(Connected.Service.BlogService.Blog blog)
        {
            return base.Channel.DeleteAsync(blog);
        }
        
        public System.Threading.Tasks.Task<Connected.Service.BlogService.Blog> GetByIdAsync(int id)
        {
            return base.Channel.GetByIdAsync(id);
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
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IBlogService))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IBlogService))
            {
                return new System.ServiceModel.EndpointAddress("http://localhost:8090/BlogHttpService");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return BlogServiceClient.GetBindingForEndpoint(EndpointConfiguration.BasicHttpBinding_IBlogService);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return BlogServiceClient.GetEndpointAddress(EndpointConfiguration.BasicHttpBinding_IBlogService);
        }
        
        public enum EndpointConfiguration
        {
            
            BasicHttpBinding_IBlogService,
        }
    }
}
