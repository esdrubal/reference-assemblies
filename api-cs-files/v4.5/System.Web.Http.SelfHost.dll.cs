namespace System.Net.Http {
  [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
  public static partial class HttpRequestMessageExtensions {
    public static System.ServiceModel.Security.SecurityMessageProperty GetSecurityMessageProperty(this System.Net.Http.HttpRequestMessage request) { return default(System.ServiceModel.Security.SecurityMessageProperty); }
  }
}
namespace System.Web.Http.SelfHost {
  public partial class HttpSelfHostConfiguration : System.Web.Http.HttpConfiguration {
    public HttpSelfHostConfiguration(string baseAddress) { }
    public HttpSelfHostConfiguration(System.Uri baseAddress) { }
    public System.Uri BaseAddress { get { return default(System.Uri); } }
    public System.ServiceModel.HostNameComparisonMode HostNameComparisonMode { get { return default(System.ServiceModel.HostNameComparisonMode); } set { } }
    public int MaxBufferSize { get { return default(int); } set { } }
    public int MaxConcurrentRequests { get { return default(int); } set { } }
    public long MaxReceivedMessageSize { get { return default(long); } set { } }
    public System.ServiceModel.TransferMode TransferMode { get { return default(System.ServiceModel.TransferMode); } set { } }
    public System.IdentityModel.Selectors.UserNamePasswordValidator UserNamePasswordValidator { get { return default(System.IdentityModel.Selectors.UserNamePasswordValidator); } set { } }
    public bool UseWindowsAuthentication { get { return default(bool); } set { } }
    protected virtual System.ServiceModel.Channels.BindingParameterCollection OnConfigureBinding(System.Web.Http.SelfHost.Channels.HttpBinding httpBinding) { return default(System.ServiceModel.Channels.BindingParameterCollection); }
  }
  public sealed partial class HttpSelfHostServer : System.Web.Http.HttpServer {
    public HttpSelfHostServer(System.Web.Http.SelfHost.HttpSelfHostConfiguration configuration) { }
    public HttpSelfHostServer(System.Web.Http.SelfHost.HttpSelfHostConfiguration configuration, System.Net.Http.HttpMessageHandler dispatcher) { }
    public System.Threading.Tasks.Task CloseAsync() { return default(System.Threading.Tasks.Task); }
    protected override void Dispose(bool disposing) { }
    public System.Threading.Tasks.Task OpenAsync() { return default(System.Threading.Tasks.Task); }
  }
}
namespace System.Web.Http.SelfHost.Channels {
  public partial class HttpBinding : System.ServiceModel.Channels.Binding, System.ServiceModel.Channels.IBindingRuntimePreferences {
    public HttpBinding() { }
    public HttpBinding(System.Web.Http.SelfHost.Channels.HttpBindingSecurityMode securityMode) { }
    public System.ServiceModel.EnvelopeVersion EnvelopeVersion { get { return default(System.ServiceModel.EnvelopeVersion); } }
    [System.ComponentModel.DefaultValueAttribute((System.ServiceModel.HostNameComparisonMode)(0))]
    public System.ServiceModel.HostNameComparisonMode HostNameComparisonMode { get { return default(System.ServiceModel.HostNameComparisonMode); } set { } }
    [System.ComponentModel.DefaultValueAttribute((long)524288)]
    public long MaxBufferPoolSize { get { return default(long); } set { } }
    [System.ComponentModel.DefaultValueAttribute(65536)]
    public int MaxBufferSize { get { return default(int); } set { } }
    [System.ComponentModel.DefaultValueAttribute((long)65536)]
    public long MaxReceivedMessageSize { get { return default(long); } set { } }
    public override string Scheme { get { return default(string); } }
    public System.Web.Http.SelfHost.Channels.HttpBindingSecurity Security { get { return default(System.Web.Http.SelfHost.Channels.HttpBindingSecurity); } set { } }
    bool System.ServiceModel.Channels.IBindingRuntimePreferences.ReceiveSynchronously { get { return default(bool); } }
    [System.ComponentModel.DefaultValueAttribute((System.ServiceModel.TransferMode)(0))]
    public System.ServiceModel.TransferMode TransferMode { get { return default(System.ServiceModel.TransferMode); } set { } }
    public override System.ServiceModel.Channels.BindingElementCollection CreateBindingElements() { return default(System.ServiceModel.Channels.BindingElementCollection); }
  }
  public sealed partial class HttpBindingSecurity {
    public HttpBindingSecurity() { }
    public System.Web.Http.SelfHost.Channels.HttpBindingSecurityMode Mode { get { return default(System.Web.Http.SelfHost.Channels.HttpBindingSecurityMode); } set { } }
    public System.ServiceModel.HttpTransportSecurity Transport { get { return default(System.ServiceModel.HttpTransportSecurity); } set { } }
  }
  public enum HttpBindingSecurityMode {
    None = 0,
    Transport = 1,
    TransportCredentialOnly = 2,
  }
}
