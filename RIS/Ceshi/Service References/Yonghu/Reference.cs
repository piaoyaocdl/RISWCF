﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Ceshi.Yonghu {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="Yonghu.IYonghuService")]
    public interface IYonghuService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IYonghuService/yonghu_denglu", ReplyAction="http://tempuri.org/IYonghuService/yonghu_dengluResponse")]
        bool yonghu_denglu(string zhanghao, string mima);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IYonghuService/yonghu_denglu", ReplyAction="http://tempuri.org/IYonghuService/yonghu_dengluResponse")]
        System.Threading.Tasks.Task<bool> yonghu_dengluAsync(string zhanghao, string mima);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IYonghuServiceChannel : Ceshi.Yonghu.IYonghuService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class YonghuServiceClient : System.ServiceModel.ClientBase<Ceshi.Yonghu.IYonghuService>, Ceshi.Yonghu.IYonghuService {
        
        public YonghuServiceClient() {
        }
        
        public YonghuServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public YonghuServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public YonghuServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public YonghuServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool yonghu_denglu(string zhanghao, string mima) {
            return base.Channel.yonghu_denglu(zhanghao, mima);
        }
        
        public System.Threading.Tasks.Task<bool> yonghu_dengluAsync(string zhanghao, string mima) {
            return base.Channel.yonghu_dengluAsync(zhanghao, mima);
        }
    }
}
