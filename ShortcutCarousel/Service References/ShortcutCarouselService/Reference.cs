﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ShortcutCarousel.UI.ShortcutCarouselService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ShortcutCarouselService.IShortcutCarouselService")]
    public interface IShortcutCarouselService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IShortcutCarouselService/GetUser", ReplyAction="http://tempuri.org/IShortcutCarouselService/GetUserResponse")]
        ShortcutCarousel.Model.CarouselUser GetUser(string osuser);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IShortcutCarouselService/GetUser", ReplyAction="http://tempuri.org/IShortcutCarouselService/GetUserResponse")]
        System.Threading.Tasks.Task<ShortcutCarousel.Model.CarouselUser> GetUserAsync(string osuser);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IShortcutCarouselService/GetOSUserList", ReplyAction="http://tempuri.org/IShortcutCarouselService/GetOSUserListResponse")]
        string[] GetOSUserList();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IShortcutCarouselService/GetOSUserList", ReplyAction="http://tempuri.org/IShortcutCarouselService/GetOSUserListResponse")]
        System.Threading.Tasks.Task<string[]> GetOSUserListAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IShortcutCarouselServiceChannel : ShortcutCarousel.UI.ShortcutCarouselService.IShortcutCarouselService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ShortcutCarouselServiceClient : System.ServiceModel.ClientBase<ShortcutCarousel.UI.ShortcutCarouselService.IShortcutCarouselService>, ShortcutCarousel.UI.ShortcutCarouselService.IShortcutCarouselService {
        
        public ShortcutCarouselServiceClient() {
        }
        
        public ShortcutCarouselServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ShortcutCarouselServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ShortcutCarouselServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ShortcutCarouselServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public ShortcutCarousel.Model.CarouselUser GetUser(string osuser) {
            return base.Channel.GetUser(osuser);
        }
        
        public System.Threading.Tasks.Task<ShortcutCarousel.Model.CarouselUser> GetUserAsync(string osuser) {
            return base.Channel.GetUserAsync(osuser);
        }
        
        public string[] GetOSUserList() {
            return base.Channel.GetOSUserList();
        }
        
        public System.Threading.Tasks.Task<string[]> GetOSUserListAsync() {
            return base.Channel.GetOSUserListAsync();
        }
    }
}
