﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18010
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This code was auto-generated by Microsoft.Silverlight.ServiceReference, version 5.0.61118.0
// 
namespace ApprovalTests.Silverlight.ServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference.IApprovalService")]
    public interface IApprovalService {
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/IApprovalService/Approve", ReplyAction="http://tempuri.org/IApprovalService/ApproveResponse")]
        System.IAsyncResult BeginApprove(string path, string testName, byte[] content, System.AsyncCallback callback, object asyncState);
        
        void EndApprove(System.IAsyncResult result);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IApprovalServiceChannel : ApprovalTests.Silverlight.ServiceReference.IApprovalService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ApprovalServiceClient : System.ServiceModel.ClientBase<ApprovalTests.Silverlight.ServiceReference.IApprovalService>, ApprovalTests.Silverlight.ServiceReference.IApprovalService {
        
        private BeginOperationDelegate onBeginApproveDelegate;
        
        private EndOperationDelegate onEndApproveDelegate;
        
        private System.Threading.SendOrPostCallback onApproveCompletedDelegate;
        
        private BeginOperationDelegate onBeginOpenDelegate;
        
        private EndOperationDelegate onEndOpenDelegate;
        
        private System.Threading.SendOrPostCallback onOpenCompletedDelegate;
        
        private BeginOperationDelegate onBeginCloseDelegate;
        
        private EndOperationDelegate onEndCloseDelegate;
        
        private System.Threading.SendOrPostCallback onCloseCompletedDelegate;
        
        public ApprovalServiceClient() {
        }
        
        public ApprovalServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ApprovalServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ApprovalServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ApprovalServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Net.CookieContainer CookieContainer {
            get {
                System.ServiceModel.Channels.IHttpCookieContainerManager httpCookieContainerManager = this.InnerChannel.GetProperty<System.ServiceModel.Channels.IHttpCookieContainerManager>();
                if ((httpCookieContainerManager != null)) {
                    return httpCookieContainerManager.CookieContainer;
                }
                else {
                    return null;
                }
            }
            set {
                System.ServiceModel.Channels.IHttpCookieContainerManager httpCookieContainerManager = this.InnerChannel.GetProperty<System.ServiceModel.Channels.IHttpCookieContainerManager>();
                if ((httpCookieContainerManager != null)) {
                    httpCookieContainerManager.CookieContainer = value;
                }
                else {
                    throw new System.InvalidOperationException("Unable to set the CookieContainer. Please make sure the binding contains an HttpC" +
                            "ookieContainerBindingElement.");
                }
            }
        }
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> ApproveCompleted;
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> OpenCompleted;
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> CloseCompleted;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult ApprovalTests.Silverlight.ServiceReference.IApprovalService.BeginApprove(string path, string testName, byte[] content, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginApprove(path, testName, content, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        void ApprovalTests.Silverlight.ServiceReference.IApprovalService.EndApprove(System.IAsyncResult result) {
            base.Channel.EndApprove(result);
        }
        
        private System.IAsyncResult OnBeginApprove(object[] inValues, System.AsyncCallback callback, object asyncState) {
            string path = ((string)(inValues[0]));
            string testName = ((string)(inValues[1]));
            byte[] content = ((byte[])(inValues[2]));
            return ((ApprovalTests.Silverlight.ServiceReference.IApprovalService)(this)).BeginApprove(path, testName, content, callback, asyncState);
        }
        
        private object[] OnEndApprove(System.IAsyncResult result) {
            ((ApprovalTests.Silverlight.ServiceReference.IApprovalService)(this)).EndApprove(result);
            return null;
        }
        
        private void OnApproveCompleted(object state) {
            if ((this.ApproveCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.ApproveCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void ApproveAsync(string path, string testName, byte[] content) {
            this.ApproveAsync(path, testName, content, null);
        }
        
        public void ApproveAsync(string path, string testName, byte[] content, object userState) {
            if ((this.onBeginApproveDelegate == null)) {
                this.onBeginApproveDelegate = new BeginOperationDelegate(this.OnBeginApprove);
            }
            if ((this.onEndApproveDelegate == null)) {
                this.onEndApproveDelegate = new EndOperationDelegate(this.OnEndApprove);
            }
            if ((this.onApproveCompletedDelegate == null)) {
                this.onApproveCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnApproveCompleted);
            }
            base.InvokeAsync(this.onBeginApproveDelegate, new object[] {
                        path,
                        testName,
                        content}, this.onEndApproveDelegate, this.onApproveCompletedDelegate, userState);
        }
        
        private System.IAsyncResult OnBeginOpen(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return ((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(callback, asyncState);
        }
        
        private object[] OnEndOpen(System.IAsyncResult result) {
            ((System.ServiceModel.ICommunicationObject)(this)).EndOpen(result);
            return null;
        }
        
        private void OnOpenCompleted(object state) {
            if ((this.OpenCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.OpenCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void OpenAsync() {
            this.OpenAsync(null);
        }
        
        public void OpenAsync(object userState) {
            if ((this.onBeginOpenDelegate == null)) {
                this.onBeginOpenDelegate = new BeginOperationDelegate(this.OnBeginOpen);
            }
            if ((this.onEndOpenDelegate == null)) {
                this.onEndOpenDelegate = new EndOperationDelegate(this.OnEndOpen);
            }
            if ((this.onOpenCompletedDelegate == null)) {
                this.onOpenCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnOpenCompleted);
            }
            base.InvokeAsync(this.onBeginOpenDelegate, null, this.onEndOpenDelegate, this.onOpenCompletedDelegate, userState);
        }
        
        private System.IAsyncResult OnBeginClose(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return ((System.ServiceModel.ICommunicationObject)(this)).BeginClose(callback, asyncState);
        }
        
        private object[] OnEndClose(System.IAsyncResult result) {
            ((System.ServiceModel.ICommunicationObject)(this)).EndClose(result);
            return null;
        }
        
        private void OnCloseCompleted(object state) {
            if ((this.CloseCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.CloseCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void CloseAsync() {
            this.CloseAsync(null);
        }
        
        public void CloseAsync(object userState) {
            if ((this.onBeginCloseDelegate == null)) {
                this.onBeginCloseDelegate = new BeginOperationDelegate(this.OnBeginClose);
            }
            if ((this.onEndCloseDelegate == null)) {
                this.onEndCloseDelegate = new EndOperationDelegate(this.OnEndClose);
            }
            if ((this.onCloseCompletedDelegate == null)) {
                this.onCloseCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnCloseCompleted);
            }
            base.InvokeAsync(this.onBeginCloseDelegate, null, this.onEndCloseDelegate, this.onCloseCompletedDelegate, userState);
        }
        
        protected override ApprovalTests.Silverlight.ServiceReference.IApprovalService CreateChannel() {
            return new ApprovalServiceClientChannel(this);
        }
        
        private class ApprovalServiceClientChannel : ChannelBase<ApprovalTests.Silverlight.ServiceReference.IApprovalService>, ApprovalTests.Silverlight.ServiceReference.IApprovalService {
            
            public ApprovalServiceClientChannel(System.ServiceModel.ClientBase<ApprovalTests.Silverlight.ServiceReference.IApprovalService> client) : 
                    base(client) {
            }
            
            public System.IAsyncResult BeginApprove(string path, string testName, byte[] content, System.AsyncCallback callback, object asyncState) {
                object[] _args = new object[3];
                _args[0] = path;
                _args[1] = testName;
                _args[2] = content;
                System.IAsyncResult _result = base.BeginInvoke("Approve", _args, callback, asyncState);
                return _result;
            }
            
            public void EndApprove(System.IAsyncResult result) {
                object[] _args = new object[0];
                base.EndInvoke("Approve", _args, result);
            }
        }
    }
}
