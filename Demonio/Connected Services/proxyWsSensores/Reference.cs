﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Demonio.proxyWsSensores {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="RegistroSensoresEntidad", Namespace="http://tempuri.org/")]
    [System.SerializableAttribute()]
    public partial class RegistroSensoresEntidad : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private int IdField;
        
        private System.DateTime FechaRegistroField;
        
        private float TemperaturaField;
        
        private float HumedadField;
        
        private float CO2Field;
        
        private float PresionAtmosfericaField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=1)]
        public System.DateTime FechaRegistro {
            get {
                return this.FechaRegistroField;
            }
            set {
                if ((this.FechaRegistroField.Equals(value) != true)) {
                    this.FechaRegistroField = value;
                    this.RaisePropertyChanged("FechaRegistro");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=2)]
        public float Temperatura {
            get {
                return this.TemperaturaField;
            }
            set {
                if ((this.TemperaturaField.Equals(value) != true)) {
                    this.TemperaturaField = value;
                    this.RaisePropertyChanged("Temperatura");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=3)]
        public float Humedad {
            get {
                return this.HumedadField;
            }
            set {
                if ((this.HumedadField.Equals(value) != true)) {
                    this.HumedadField = value;
                    this.RaisePropertyChanged("Humedad");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=4)]
        public float CO2 {
            get {
                return this.CO2Field;
            }
            set {
                if ((this.CO2Field.Equals(value) != true)) {
                    this.CO2Field = value;
                    this.RaisePropertyChanged("CO2");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=5)]
        public float PresionAtmosferica {
            get {
                return this.PresionAtmosfericaField;
            }
            set {
                if ((this.PresionAtmosfericaField.Equals(value) != true)) {
                    this.PresionAtmosfericaField = value;
                    this.RaisePropertyChanged("PresionAtmosferica");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="proxyWsSensores.ServicioSensoresSoap")]
    public interface ServicioSensoresSoap {
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento HelloWorldResult del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        Demonio.proxyWsSensores.HelloWorldResponse HelloWorld(Demonio.proxyWsSensores.HelloWorldRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        System.Threading.Tasks.Task<Demonio.proxyWsSensores.HelloWorldResponse> HelloWorldAsync(Demonio.proxyWsSensores.HelloWorldRequest request);
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento registroSensoresEntidad del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Guardar", ReplyAction="*")]
        Demonio.proxyWsSensores.GuardarResponse Guardar(Demonio.proxyWsSensores.GuardarRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Guardar", ReplyAction="*")]
        System.Threading.Tasks.Task<Demonio.proxyWsSensores.GuardarResponse> GuardarAsync(Demonio.proxyWsSensores.GuardarRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorld", Namespace="http://tempuri.org/", Order=0)]
        public Demonio.proxyWsSensores.HelloWorldRequestBody Body;
        
        public HelloWorldRequest() {
        }
        
        public HelloWorldRequest(Demonio.proxyWsSensores.HelloWorldRequestBody Body) {
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
        public Demonio.proxyWsSensores.HelloWorldResponseBody Body;
        
        public HelloWorldResponse() {
        }
        
        public HelloWorldResponse(Demonio.proxyWsSensores.HelloWorldResponseBody Body) {
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
    public partial class GuardarRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Guardar", Namespace="http://tempuri.org/", Order=0)]
        public Demonio.proxyWsSensores.GuardarRequestBody Body;
        
        public GuardarRequest() {
        }
        
        public GuardarRequest(Demonio.proxyWsSensores.GuardarRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GuardarRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public Demonio.proxyWsSensores.RegistroSensoresEntidad registroSensoresEntidad;
        
        public GuardarRequestBody() {
        }
        
        public GuardarRequestBody(Demonio.proxyWsSensores.RegistroSensoresEntidad registroSensoresEntidad) {
            this.registroSensoresEntidad = registroSensoresEntidad;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GuardarResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GuardarResponse", Namespace="http://tempuri.org/", Order=0)]
        public Demonio.proxyWsSensores.GuardarResponseBody Body;
        
        public GuardarResponse() {
        }
        
        public GuardarResponse(Demonio.proxyWsSensores.GuardarResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GuardarResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public Demonio.proxyWsSensores.RegistroSensoresEntidad GuardarResult;
        
        public GuardarResponseBody() {
        }
        
        public GuardarResponseBody(Demonio.proxyWsSensores.RegistroSensoresEntidad GuardarResult) {
            this.GuardarResult = GuardarResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ServicioSensoresSoapChannel : Demonio.proxyWsSensores.ServicioSensoresSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServicioSensoresSoapClient : System.ServiceModel.ClientBase<Demonio.proxyWsSensores.ServicioSensoresSoap>, Demonio.proxyWsSensores.ServicioSensoresSoap {
        
        public ServicioSensoresSoapClient() {
        }
        
        public ServicioSensoresSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServicioSensoresSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicioSensoresSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicioSensoresSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Demonio.proxyWsSensores.HelloWorldResponse Demonio.proxyWsSensores.ServicioSensoresSoap.HelloWorld(Demonio.proxyWsSensores.HelloWorldRequest request) {
            return base.Channel.HelloWorld(request);
        }
        
        public string HelloWorld() {
            Demonio.proxyWsSensores.HelloWorldRequest inValue = new Demonio.proxyWsSensores.HelloWorldRequest();
            inValue.Body = new Demonio.proxyWsSensores.HelloWorldRequestBody();
            Demonio.proxyWsSensores.HelloWorldResponse retVal = ((Demonio.proxyWsSensores.ServicioSensoresSoap)(this)).HelloWorld(inValue);
            return retVal.Body.HelloWorldResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Demonio.proxyWsSensores.HelloWorldResponse> Demonio.proxyWsSensores.ServicioSensoresSoap.HelloWorldAsync(Demonio.proxyWsSensores.HelloWorldRequest request) {
            return base.Channel.HelloWorldAsync(request);
        }
        
        public System.Threading.Tasks.Task<Demonio.proxyWsSensores.HelloWorldResponse> HelloWorldAsync() {
            Demonio.proxyWsSensores.HelloWorldRequest inValue = new Demonio.proxyWsSensores.HelloWorldRequest();
            inValue.Body = new Demonio.proxyWsSensores.HelloWorldRequestBody();
            return ((Demonio.proxyWsSensores.ServicioSensoresSoap)(this)).HelloWorldAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Demonio.proxyWsSensores.GuardarResponse Demonio.proxyWsSensores.ServicioSensoresSoap.Guardar(Demonio.proxyWsSensores.GuardarRequest request) {
            return base.Channel.Guardar(request);
        }
        
        public Demonio.proxyWsSensores.RegistroSensoresEntidad Guardar(Demonio.proxyWsSensores.RegistroSensoresEntidad registroSensoresEntidad) {
            Demonio.proxyWsSensores.GuardarRequest inValue = new Demonio.proxyWsSensores.GuardarRequest();
            inValue.Body = new Demonio.proxyWsSensores.GuardarRequestBody();
            inValue.Body.registroSensoresEntidad = registroSensoresEntidad;
            Demonio.proxyWsSensores.GuardarResponse retVal = ((Demonio.proxyWsSensores.ServicioSensoresSoap)(this)).Guardar(inValue);
            return retVal.Body.GuardarResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Demonio.proxyWsSensores.GuardarResponse> Demonio.proxyWsSensores.ServicioSensoresSoap.GuardarAsync(Demonio.proxyWsSensores.GuardarRequest request) {
            return base.Channel.GuardarAsync(request);
        }
        
        public System.Threading.Tasks.Task<Demonio.proxyWsSensores.GuardarResponse> GuardarAsync(Demonio.proxyWsSensores.RegistroSensoresEntidad registroSensoresEntidad) {
            Demonio.proxyWsSensores.GuardarRequest inValue = new Demonio.proxyWsSensores.GuardarRequest();
            inValue.Body = new Demonio.proxyWsSensores.GuardarRequestBody();
            inValue.Body.registroSensoresEntidad = registroSensoresEntidad;
            return ((Demonio.proxyWsSensores.ServicioSensoresSoap)(this)).GuardarAsync(inValue);
        }
    }
}
