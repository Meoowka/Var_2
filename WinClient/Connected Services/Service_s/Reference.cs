﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WinClient.Service_s {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="Service_s.IVar_2_sp")]
    public interface IVar_2_sp {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IVar_2_sp/GetMessage", ReplyAction="http://tempuri.org/IVar_2_sp/GetMessageResponse")]
        string GetMessage(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IVar_2_sp/GetMessage", ReplyAction="http://tempuri.org/IVar_2_sp/GetMessageResponse")]
        System.Threading.Tasks.Task<string> GetMessageAsync(string name);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IVar_2_spChannel : WinClient.Service_s.IVar_2_sp, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Var_2_spClient : System.ServiceModel.ClientBase<WinClient.Service_s.IVar_2_sp>, WinClient.Service_s.IVar_2_sp {
        
        public Var_2_spClient() {
        }
        
        public Var_2_spClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Var_2_spClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Var_2_spClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Var_2_spClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetMessage(string name) {
            return base.Channel.GetMessage(name);
        }
        
        public System.Threading.Tasks.Task<string> GetMessageAsync(string name) {
            return base.Channel.GetMessageAsync(name);
        }
    }
}