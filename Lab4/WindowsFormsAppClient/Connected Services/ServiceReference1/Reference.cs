﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsAppClient.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.CollectionDataContractAttribute(Name="ArrayOfString", Namespace="http://tempuri.org/", ItemName="string")]
    [System.SerializableAttribute()]
    public class ArrayOfString : System.Collections.Generic.List<string> {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.WebService1Soap")]
    public interface WebService1Soap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/CelsiusToFahrenheit", ReplyAction="*")]
        float CelsiusToFahrenheit(float celcius);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/CelsiusToFahrenheit", ReplyAction="*")]
        System.Threading.Tasks.Task<float> CelsiusToFahrenheitAsync(float celcius);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/FahrenheitToCelsius", ReplyAction="*")]
        float FahrenheitToCelsius(float fahrenheit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/FahrenheitToCelsius", ReplyAction="*")]
        System.Threading.Tasks.Task<float> FahrenheitToCelsiusAsync(float fahrenheit);
        
        // CODEGEN: Generating message contract since element name CurrentDateAndTimeResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/CurrentDateAndTime", ReplyAction="*")]
        WindowsFormsAppClient.ServiceReference1.CurrentDateAndTimeResponse CurrentDateAndTime(WindowsFormsAppClient.ServiceReference1.CurrentDateAndTimeRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/CurrentDateAndTime", ReplyAction="*")]
        System.Threading.Tasks.Task<WindowsFormsAppClient.ServiceReference1.CurrentDateAndTimeResponse> CurrentDateAndTimeAsync(WindowsFormsAppClient.ServiceReference1.CurrentDateAndTimeRequest request);
        
        // CODEGEN: Generating message contract since element name GetShoppingListResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetShoppingList", ReplyAction="*")]
        WindowsFormsAppClient.ServiceReference1.GetShoppingListResponse GetShoppingList(WindowsFormsAppClient.ServiceReference1.GetShoppingListRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetShoppingList", ReplyAction="*")]
        System.Threading.Tasks.Task<WindowsFormsAppClient.ServiceReference1.GetShoppingListResponse> GetShoppingListAsync(WindowsFormsAppClient.ServiceReference1.GetShoppingListRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/EuroToRon", ReplyAction="*")]
        float EuroToRon(float euro);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/EuroToRon", ReplyAction="*")]
        System.Threading.Tasks.Task<float> EuroToRonAsync(float euro);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/RonToEuro", ReplyAction="*")]
        float RonToEuro(float ron);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/RonToEuro", ReplyAction="*")]
        System.Threading.Tasks.Task<float> RonToEuroAsync(float ron);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class CurrentDateAndTimeRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="CurrentDateAndTime", Namespace="http://tempuri.org/", Order=0)]
        public WindowsFormsAppClient.ServiceReference1.CurrentDateAndTimeRequestBody Body;
        
        public CurrentDateAndTimeRequest() {
        }
        
        public CurrentDateAndTimeRequest(WindowsFormsAppClient.ServiceReference1.CurrentDateAndTimeRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class CurrentDateAndTimeRequestBody {
        
        public CurrentDateAndTimeRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class CurrentDateAndTimeResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="CurrentDateAndTimeResponse", Namespace="http://tempuri.org/", Order=0)]
        public WindowsFormsAppClient.ServiceReference1.CurrentDateAndTimeResponseBody Body;
        
        public CurrentDateAndTimeResponse() {
        }
        
        public CurrentDateAndTimeResponse(WindowsFormsAppClient.ServiceReference1.CurrentDateAndTimeResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class CurrentDateAndTimeResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string CurrentDateAndTimeResult;
        
        public CurrentDateAndTimeResponseBody() {
        }
        
        public CurrentDateAndTimeResponseBody(string CurrentDateAndTimeResult) {
            this.CurrentDateAndTimeResult = CurrentDateAndTimeResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetShoppingListRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetShoppingList", Namespace="http://tempuri.org/", Order=0)]
        public WindowsFormsAppClient.ServiceReference1.GetShoppingListRequestBody Body;
        
        public GetShoppingListRequest() {
        }
        
        public GetShoppingListRequest(WindowsFormsAppClient.ServiceReference1.GetShoppingListRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class GetShoppingListRequestBody {
        
        public GetShoppingListRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetShoppingListResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetShoppingListResponse", Namespace="http://tempuri.org/", Order=0)]
        public WindowsFormsAppClient.ServiceReference1.GetShoppingListResponseBody Body;
        
        public GetShoppingListResponse() {
        }
        
        public GetShoppingListResponse(WindowsFormsAppClient.ServiceReference1.GetShoppingListResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetShoppingListResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public WindowsFormsAppClient.ServiceReference1.ArrayOfString GetShoppingListResult;
        
        public GetShoppingListResponseBody() {
        }
        
        public GetShoppingListResponseBody(WindowsFormsAppClient.ServiceReference1.ArrayOfString GetShoppingListResult) {
            this.GetShoppingListResult = GetShoppingListResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WebService1SoapChannel : WindowsFormsAppClient.ServiceReference1.WebService1Soap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebService1SoapClient : System.ServiceModel.ClientBase<WindowsFormsAppClient.ServiceReference1.WebService1Soap>, WindowsFormsAppClient.ServiceReference1.WebService1Soap {
        
        public WebService1SoapClient() {
        }
        
        public WebService1SoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WebService1SoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebService1SoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebService1SoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public float CelsiusToFahrenheit(float celcius) {
            return base.Channel.CelsiusToFahrenheit(celcius);
        }
        
        public System.Threading.Tasks.Task<float> CelsiusToFahrenheitAsync(float celcius) {
            return base.Channel.CelsiusToFahrenheitAsync(celcius);
        }
        
        public float FahrenheitToCelsius(float fahrenheit) {
            return base.Channel.FahrenheitToCelsius(fahrenheit);
        }
        
        public System.Threading.Tasks.Task<float> FahrenheitToCelsiusAsync(float fahrenheit) {
            return base.Channel.FahrenheitToCelsiusAsync(fahrenheit);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WindowsFormsAppClient.ServiceReference1.CurrentDateAndTimeResponse WindowsFormsAppClient.ServiceReference1.WebService1Soap.CurrentDateAndTime(WindowsFormsAppClient.ServiceReference1.CurrentDateAndTimeRequest request) {
            return base.Channel.CurrentDateAndTime(request);
        }
        
        public string CurrentDateAndTime() {
            WindowsFormsAppClient.ServiceReference1.CurrentDateAndTimeRequest inValue = new WindowsFormsAppClient.ServiceReference1.CurrentDateAndTimeRequest();
            inValue.Body = new WindowsFormsAppClient.ServiceReference1.CurrentDateAndTimeRequestBody();
            WindowsFormsAppClient.ServiceReference1.CurrentDateAndTimeResponse retVal = ((WindowsFormsAppClient.ServiceReference1.WebService1Soap)(this)).CurrentDateAndTime(inValue);
            return retVal.Body.CurrentDateAndTimeResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WindowsFormsAppClient.ServiceReference1.CurrentDateAndTimeResponse> WindowsFormsAppClient.ServiceReference1.WebService1Soap.CurrentDateAndTimeAsync(WindowsFormsAppClient.ServiceReference1.CurrentDateAndTimeRequest request) {
            return base.Channel.CurrentDateAndTimeAsync(request);
        }
        
        public System.Threading.Tasks.Task<WindowsFormsAppClient.ServiceReference1.CurrentDateAndTimeResponse> CurrentDateAndTimeAsync() {
            WindowsFormsAppClient.ServiceReference1.CurrentDateAndTimeRequest inValue = new WindowsFormsAppClient.ServiceReference1.CurrentDateAndTimeRequest();
            inValue.Body = new WindowsFormsAppClient.ServiceReference1.CurrentDateAndTimeRequestBody();
            return ((WindowsFormsAppClient.ServiceReference1.WebService1Soap)(this)).CurrentDateAndTimeAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WindowsFormsAppClient.ServiceReference1.GetShoppingListResponse WindowsFormsAppClient.ServiceReference1.WebService1Soap.GetShoppingList(WindowsFormsAppClient.ServiceReference1.GetShoppingListRequest request) {
            return base.Channel.GetShoppingList(request);
        }
        
        public WindowsFormsAppClient.ServiceReference1.ArrayOfString GetShoppingList() {
            WindowsFormsAppClient.ServiceReference1.GetShoppingListRequest inValue = new WindowsFormsAppClient.ServiceReference1.GetShoppingListRequest();
            inValue.Body = new WindowsFormsAppClient.ServiceReference1.GetShoppingListRequestBody();
            WindowsFormsAppClient.ServiceReference1.GetShoppingListResponse retVal = ((WindowsFormsAppClient.ServiceReference1.WebService1Soap)(this)).GetShoppingList(inValue);
            return retVal.Body.GetShoppingListResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WindowsFormsAppClient.ServiceReference1.GetShoppingListResponse> WindowsFormsAppClient.ServiceReference1.WebService1Soap.GetShoppingListAsync(WindowsFormsAppClient.ServiceReference1.GetShoppingListRequest request) {
            return base.Channel.GetShoppingListAsync(request);
        }
        
        public System.Threading.Tasks.Task<WindowsFormsAppClient.ServiceReference1.GetShoppingListResponse> GetShoppingListAsync() {
            WindowsFormsAppClient.ServiceReference1.GetShoppingListRequest inValue = new WindowsFormsAppClient.ServiceReference1.GetShoppingListRequest();
            inValue.Body = new WindowsFormsAppClient.ServiceReference1.GetShoppingListRequestBody();
            return ((WindowsFormsAppClient.ServiceReference1.WebService1Soap)(this)).GetShoppingListAsync(inValue);
        }
        
        public float EuroToRon(float euro) {
            return base.Channel.EuroToRon(euro);
        }
        
        public System.Threading.Tasks.Task<float> EuroToRonAsync(float euro) {
            return base.Channel.EuroToRonAsync(euro);
        }
        
        public float RonToEuro(float ron) {
            return base.Channel.RonToEuro(ron);
        }
        
        public System.Threading.Tasks.Task<float> RonToEuroAsync(float ron) {
            return base.Channel.RonToEuroAsync(ron);
        }
    }
}
