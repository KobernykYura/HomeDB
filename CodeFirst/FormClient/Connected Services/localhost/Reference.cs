﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FormClient.localhost {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="localhost.WebServiceAccessSoap")]
    public interface WebServiceAccessSoap {
        
        // CODEGEN: Контракт генерации сообщений с именем HelloWorldResult из пространства имен http://tempuri.org/ не отмечен как обнуляемый
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        FormClient.localhost.HelloWorldResponse HelloWorld(FormClient.localhost.HelloWorldRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        System.Threading.Tasks.Task<FormClient.localhost.HelloWorldResponse> HelloWorldAsync(FormClient.localhost.HelloWorldRequest request);
        
        // CODEGEN: Контракт генерации сообщений с именем GetSoursResult из пространства имен http://tempuri.org/ не отмечен как обнуляемый
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetSours", ReplyAction="*")]
        FormClient.localhost.GetSoursResponse GetSours(FormClient.localhost.GetSoursRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetSours", ReplyAction="*")]
        System.Threading.Tasks.Task<FormClient.localhost.GetSoursResponse> GetSoursAsync(FormClient.localhost.GetSoursRequest request);
        
        // CODEGEN: Контракт генерации сообщений с именем GetResult из пространства имен http://tempuri.org/ не отмечен как обнуляемый
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Get", ReplyAction="*")]
        FormClient.localhost.GetResponse Get(FormClient.localhost.GetRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Get", ReplyAction="*")]
        System.Threading.Tasks.Task<FormClient.localhost.GetResponse> GetAsync(FormClient.localhost.GetRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorld", Namespace="http://tempuri.org/", Order=0)]
        public FormClient.localhost.HelloWorldRequestBody Body;
        
        public HelloWorldRequest() {
        }
        
        public HelloWorldRequest(FormClient.localhost.HelloWorldRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class HelloWorldRequestBody {
        
        public HelloWorldRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorldResponse", Namespace="http://tempuri.org/", Order=0)]
        public FormClient.localhost.HelloWorldResponseBody Body;
        
        public HelloWorldResponse() {
        }
        
        public HelloWorldResponse(FormClient.localhost.HelloWorldResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class HelloWorldResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string HelloWorldResult;
        
        public HelloWorldResponseBody() {
        }
        
        public HelloWorldResponseBody(string HelloWorldResult) {
            this.HelloWorldResult = HelloWorldResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetSoursRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetSours", Namespace="http://tempuri.org/", Order=0)]
        public FormClient.localhost.GetSoursRequestBody Body;
        
        public GetSoursRequest() {
        }
        
        public GetSoursRequest(FormClient.localhost.GetSoursRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class GetSoursRequestBody {
        
        public GetSoursRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetSoursResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetSoursResponse", Namespace="http://tempuri.org/", Order=0)]
        public FormClient.localhost.GetSoursResponseBody Body;
        
        public GetSoursResponse() {
        }
        
        public GetSoursResponse(FormClient.localhost.GetSoursResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetSoursResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string GetSoursResult;
        
        public GetSoursResponseBody() {
        }
        
        public GetSoursResponseBody(string GetSoursResult) {
            this.GetSoursResult = GetSoursResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Get", Namespace="http://tempuri.org/", Order=0)]
        public FormClient.localhost.GetRequestBody Body;
        
        public GetRequest() {
        }
        
        public GetRequest(FormClient.localhost.GetRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class GetRequestBody {
        
        public GetRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetResponse", Namespace="http://tempuri.org/", Order=0)]
        public FormClient.localhost.GetResponseBody Body;
        
        public GetResponse() {
        }
        
        public GetResponse(FormClient.localhost.GetResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string GetResult;
        
        public GetResponseBody() {
        }
        
        public GetResponseBody(string GetResult) {
            this.GetResult = GetResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WebServiceAccessSoapChannel : FormClient.localhost.WebServiceAccessSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebServiceAccessSoapClient : System.ServiceModel.ClientBase<FormClient.localhost.WebServiceAccessSoap>, FormClient.localhost.WebServiceAccessSoap {
        
        public WebServiceAccessSoapClient() {
        }
        
        public WebServiceAccessSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WebServiceAccessSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebServiceAccessSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebServiceAccessSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        FormClient.localhost.HelloWorldResponse FormClient.localhost.WebServiceAccessSoap.HelloWorld(FormClient.localhost.HelloWorldRequest request) {
            return base.Channel.HelloWorld(request);
        }
        
        public string HelloWorld() {
            FormClient.localhost.HelloWorldRequest inValue = new FormClient.localhost.HelloWorldRequest();
            inValue.Body = new FormClient.localhost.HelloWorldRequestBody();
            FormClient.localhost.HelloWorldResponse retVal = ((FormClient.localhost.WebServiceAccessSoap)(this)).HelloWorld(inValue);
            return retVal.Body.HelloWorldResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<FormClient.localhost.HelloWorldResponse> FormClient.localhost.WebServiceAccessSoap.HelloWorldAsync(FormClient.localhost.HelloWorldRequest request) {
            return base.Channel.HelloWorldAsync(request);
        }
        
        public System.Threading.Tasks.Task<FormClient.localhost.HelloWorldResponse> HelloWorldAsync() {
            FormClient.localhost.HelloWorldRequest inValue = new FormClient.localhost.HelloWorldRequest();
            inValue.Body = new FormClient.localhost.HelloWorldRequestBody();
            return ((FormClient.localhost.WebServiceAccessSoap)(this)).HelloWorldAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        FormClient.localhost.GetSoursResponse FormClient.localhost.WebServiceAccessSoap.GetSours(FormClient.localhost.GetSoursRequest request) {
            return base.Channel.GetSours(request);
        }
        
        public string GetSours() {
            FormClient.localhost.GetSoursRequest inValue = new FormClient.localhost.GetSoursRequest();
            inValue.Body = new FormClient.localhost.GetSoursRequestBody();
            FormClient.localhost.GetSoursResponse retVal = ((FormClient.localhost.WebServiceAccessSoap)(this)).GetSours(inValue);
            return retVal.Body.GetSoursResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<FormClient.localhost.GetSoursResponse> FormClient.localhost.WebServiceAccessSoap.GetSoursAsync(FormClient.localhost.GetSoursRequest request) {
            return base.Channel.GetSoursAsync(request);
        }
        
        public System.Threading.Tasks.Task<FormClient.localhost.GetSoursResponse> GetSoursAsync() {
            FormClient.localhost.GetSoursRequest inValue = new FormClient.localhost.GetSoursRequest();
            inValue.Body = new FormClient.localhost.GetSoursRequestBody();
            return ((FormClient.localhost.WebServiceAccessSoap)(this)).GetSoursAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        FormClient.localhost.GetResponse FormClient.localhost.WebServiceAccessSoap.Get(FormClient.localhost.GetRequest request) {
            return base.Channel.Get(request);
        }
        
        public string Get() {
            FormClient.localhost.GetRequest inValue = new FormClient.localhost.GetRequest();
            inValue.Body = new FormClient.localhost.GetRequestBody();
            FormClient.localhost.GetResponse retVal = ((FormClient.localhost.WebServiceAccessSoap)(this)).Get(inValue);
            return retVal.Body.GetResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<FormClient.localhost.GetResponse> FormClient.localhost.WebServiceAccessSoap.GetAsync(FormClient.localhost.GetRequest request) {
            return base.Channel.GetAsync(request);
        }
        
        public System.Threading.Tasks.Task<FormClient.localhost.GetResponse> GetAsync() {
            FormClient.localhost.GetRequest inValue = new FormClient.localhost.GetRequest();
            inValue.Body = new FormClient.localhost.GetRequestBody();
            return ((FormClient.localhost.WebServiceAccessSoap)(this)).GetAsync(inValue);
        }
    }
}