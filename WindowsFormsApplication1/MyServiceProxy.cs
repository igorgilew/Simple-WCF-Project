﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:2.0.50727.5420
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServiceReference1
{
    using System.Runtime.Serialization;
    using System;
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName = "IMyService")]
    public interface IMyService
    {

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IMyService/Method1", ReplyAction = "http://tempuri.org/IMyService/Method1Response")]
        string Method1(string x);

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IMyService/Method2", ReplyAction = "http://tempuri.org/IMyService/Method2Response")]
        string Method2(string x);
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public interface IMyServiceChannel : IMyService, System.ServiceModel.IClientChannel
    {
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public partial class MyServiceClient : System.ServiceModel.ClientBase<IMyService>, IMyService
    {

        public MyServiceClient()
        {
        }

        public MyServiceClient(string endpointConfigurationName) :
                base(endpointConfigurationName)
        {
        }

        public MyServiceClient(string endpointConfigurationName, string remoteAddress) :
                base(endpointConfigurationName, remoteAddress)
        {
        }

        public MyServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) :
                base(endpointConfigurationName, remoteAddress)
        {
        }

        public MyServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) :
                base(binding, remoteAddress)
        {
        }

        public string Method1(string x)
        {
            return base.Channel.Method1(x);
        }

        public string Method2(string x)
        {
            return base.Channel.Method2(x);
        }
    }
}