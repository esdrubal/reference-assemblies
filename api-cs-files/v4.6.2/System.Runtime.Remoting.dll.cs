namespace System.Runtime.Remoting.Channels {
  public partial class BinaryClientFormatterSink : System.Runtime.Remoting.Channels.IChannelSinkBase, System.Runtime.Remoting.Channels.IClientChannelSink, System.Runtime.Remoting.Channels.IClientFormatterSink, System.Runtime.Remoting.Messaging.IMessageSink {
    public BinaryClientFormatterSink(System.Runtime.Remoting.Channels.IClientChannelSink nextSink) { }
    public System.Runtime.Remoting.Channels.IClientChannelSink NextChannelSink { get { return default(System.Runtime.Remoting.Channels.IClientChannelSink); } }
    public System.Runtime.Remoting.Messaging.IMessageSink NextSink { get { return default(System.Runtime.Remoting.Messaging.IMessageSink); } }
    public System.Collections.IDictionary Properties { get { return default(System.Collections.IDictionary); } }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(4096), Infrastructure=true)]
    public System.Runtime.Remoting.Messaging.IMessageCtrl AsyncProcessMessage(System.Runtime.Remoting.Messaging.IMessage msg, System.Runtime.Remoting.Messaging.IMessageSink replySink) { return default(System.Runtime.Remoting.Messaging.IMessageCtrl); }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(4096), Infrastructure=true)]
    public void AsyncProcessRequest(System.Runtime.Remoting.Channels.IClientChannelSinkStack sinkStack, System.Runtime.Remoting.Messaging.IMessage msg, System.Runtime.Remoting.Channels.ITransportHeaders headers, System.IO.Stream stream) { }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(4096), Infrastructure=true)]
    public void AsyncProcessResponse(System.Runtime.Remoting.Channels.IClientResponseChannelSinkStack sinkStack, object state, System.Runtime.Remoting.Channels.ITransportHeaders headers, System.IO.Stream stream) { }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(4096), Infrastructure=true)]
    public System.IO.Stream GetRequestStream(System.Runtime.Remoting.Messaging.IMessage msg, System.Runtime.Remoting.Channels.ITransportHeaders headers) { return default(System.IO.Stream); }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(4096), Infrastructure=true)]
    public void ProcessMessage(System.Runtime.Remoting.Messaging.IMessage msg, System.Runtime.Remoting.Channels.ITransportHeaders requestHeaders, System.IO.Stream requestStream, out System.Runtime.Remoting.Channels.ITransportHeaders responseHeaders, out System.IO.Stream responseStream) { responseHeaders = default(System.Runtime.Remoting.Channels.ITransportHeaders); responseStream = default(System.IO.Stream); }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(4096), Infrastructure=true)]
    public System.Runtime.Remoting.Messaging.IMessage SyncProcessMessage(System.Runtime.Remoting.Messaging.IMessage msg) { return default(System.Runtime.Remoting.Messaging.IMessage); }
  }
  public partial class BinaryClientFormatterSinkProvider : System.Runtime.Remoting.Channels.IClientChannelSinkProvider, System.Runtime.Remoting.Channels.IClientFormatterSinkProvider {
    public BinaryClientFormatterSinkProvider() { }
    public BinaryClientFormatterSinkProvider(System.Collections.IDictionary properties, System.Collections.ICollection providerData) { }
    public System.Runtime.Remoting.Channels.IClientChannelSinkProvider Next { get { return default(System.Runtime.Remoting.Channels.IClientChannelSinkProvider); } set { } }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(4096), Infrastructure=true)]
    public System.Runtime.Remoting.Channels.IClientChannelSink CreateSink(System.Runtime.Remoting.Channels.IChannelSender channel, string url, object remoteChannelData) { return default(System.Runtime.Remoting.Channels.IClientChannelSink); }
  }
  public partial class BinaryServerFormatterSink : System.Runtime.Remoting.Channels.IChannelSinkBase, System.Runtime.Remoting.Channels.IServerChannelSink {
    public BinaryServerFormatterSink(System.Runtime.Remoting.Channels.BinaryServerFormatterSink.Protocol protocol, System.Runtime.Remoting.Channels.IServerChannelSink nextSink, System.Runtime.Remoting.Channels.IChannelReceiver receiver) { }
    public System.Runtime.Remoting.Channels.IServerChannelSink NextChannelSink { get { return default(System.Runtime.Remoting.Channels.IServerChannelSink); } }
    public System.Collections.IDictionary Properties { get { return default(System.Collections.IDictionary); } }
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public System.Runtime.Serialization.Formatters.TypeFilterLevel TypeFilterLevel { get { return default(System.Runtime.Serialization.Formatters.TypeFilterLevel); } set { } }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(4096), Infrastructure=true)]
    public void AsyncProcessResponse(System.Runtime.Remoting.Channels.IServerResponseChannelSinkStack sinkStack, object state, System.Runtime.Remoting.Messaging.IMessage msg, System.Runtime.Remoting.Channels.ITransportHeaders headers, System.IO.Stream stream) { }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(4096), Infrastructure=true)]
    public System.IO.Stream GetResponseStream(System.Runtime.Remoting.Channels.IServerResponseChannelSinkStack sinkStack, object state, System.Runtime.Remoting.Messaging.IMessage msg, System.Runtime.Remoting.Channels.ITransportHeaders headers) { return default(System.IO.Stream); }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(4096), Infrastructure=true)]
    public System.Runtime.Remoting.Channels.ServerProcessing ProcessMessage(System.Runtime.Remoting.Channels.IServerChannelSinkStack sinkStack, System.Runtime.Remoting.Messaging.IMessage requestMsg, System.Runtime.Remoting.Channels.ITransportHeaders requestHeaders, System.IO.Stream requestStream, out System.Runtime.Remoting.Messaging.IMessage responseMsg, out System.Runtime.Remoting.Channels.ITransportHeaders responseHeaders, out System.IO.Stream responseStream) { responseMsg = default(System.Runtime.Remoting.Messaging.IMessage); responseHeaders = default(System.Runtime.Remoting.Channels.ITransportHeaders); responseStream = default(System.IO.Stream); return default(System.Runtime.Remoting.Channels.ServerProcessing); }
    public enum Protocol {
      Http = 0,
      Other = 1,
    }
  }
  public partial class BinaryServerFormatterSinkProvider : System.Runtime.Remoting.Channels.IServerChannelSinkProvider, System.Runtime.Remoting.Channels.IServerFormatterSinkProvider {
    public BinaryServerFormatterSinkProvider() { }
    public BinaryServerFormatterSinkProvider(System.Collections.IDictionary properties, System.Collections.ICollection providerData) { }
    public System.Runtime.Remoting.Channels.IServerChannelSinkProvider Next { get { return default(System.Runtime.Remoting.Channels.IServerChannelSinkProvider); } set { } }
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public System.Runtime.Serialization.Formatters.TypeFilterLevel TypeFilterLevel { get { return default(System.Runtime.Serialization.Formatters.TypeFilterLevel); } set { } }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(4096), Infrastructure=true)]
    public System.Runtime.Remoting.Channels.IServerChannelSink CreateSink(System.Runtime.Remoting.Channels.IChannelReceiver channel) { return default(System.Runtime.Remoting.Channels.IServerChannelSink); }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(4096), Infrastructure=true)]
    public void GetChannelData(System.Runtime.Remoting.Channels.IChannelDataStore channelData) { }
  }
  public partial class CommonTransportKeys {
    public const string ConnectionId = "__ConnectionId";
    public const string IPAddress = "__IPAddress";
    public const string RequestUri = "__RequestUri";
    public CommonTransportKeys() { }
  }
  public partial interface IAuthorizeRemotingConnection {
    bool IsConnectingEndPointAuthorized(System.Net.EndPoint endPoint);
    bool IsConnectingIdentityAuthorized(System.Security.Principal.IIdentity identity);
  }
  public partial class SoapClientFormatterSink : System.Runtime.Remoting.Channels.IChannelSinkBase, System.Runtime.Remoting.Channels.IClientChannelSink, System.Runtime.Remoting.Channels.IClientFormatterSink, System.Runtime.Remoting.Messaging.IMessageSink {
    public SoapClientFormatterSink(System.Runtime.Remoting.Channels.IClientChannelSink nextSink) { }
    public System.Runtime.Remoting.Channels.IClientChannelSink NextChannelSink { get { return default(System.Runtime.Remoting.Channels.IClientChannelSink); } }
    public System.Runtime.Remoting.Messaging.IMessageSink NextSink { get { return default(System.Runtime.Remoting.Messaging.IMessageSink); } }
    public System.Collections.IDictionary Properties { get { return default(System.Collections.IDictionary); } }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(4096), Infrastructure=true)]
    public System.Runtime.Remoting.Messaging.IMessageCtrl AsyncProcessMessage(System.Runtime.Remoting.Messaging.IMessage msg, System.Runtime.Remoting.Messaging.IMessageSink replySink) { return default(System.Runtime.Remoting.Messaging.IMessageCtrl); }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(4096), Infrastructure=true)]
    public void AsyncProcessRequest(System.Runtime.Remoting.Channels.IClientChannelSinkStack sinkStack, System.Runtime.Remoting.Messaging.IMessage msg, System.Runtime.Remoting.Channels.ITransportHeaders headers, System.IO.Stream stream) { }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(4096), Infrastructure=true)]
    public void AsyncProcessResponse(System.Runtime.Remoting.Channels.IClientResponseChannelSinkStack sinkStack, object state, System.Runtime.Remoting.Channels.ITransportHeaders headers, System.IO.Stream stream) { }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(4096), Infrastructure=true)]
    public System.IO.Stream GetRequestStream(System.Runtime.Remoting.Messaging.IMessage msg, System.Runtime.Remoting.Channels.ITransportHeaders headers) { return default(System.IO.Stream); }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(4096), Infrastructure=true)]
    public void ProcessMessage(System.Runtime.Remoting.Messaging.IMessage msg, System.Runtime.Remoting.Channels.ITransportHeaders requestHeaders, System.IO.Stream requestStream, out System.Runtime.Remoting.Channels.ITransportHeaders responseHeaders, out System.IO.Stream responseStream) { responseHeaders = default(System.Runtime.Remoting.Channels.ITransportHeaders); responseStream = default(System.IO.Stream); }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(4096), Infrastructure=true)]
    public System.Runtime.Remoting.Messaging.IMessage SyncProcessMessage(System.Runtime.Remoting.Messaging.IMessage msg) { return default(System.Runtime.Remoting.Messaging.IMessage); }
  }
  public partial class SoapClientFormatterSinkProvider : System.Runtime.Remoting.Channels.IClientChannelSinkProvider, System.Runtime.Remoting.Channels.IClientFormatterSinkProvider {
    public SoapClientFormatterSinkProvider() { }
    public SoapClientFormatterSinkProvider(System.Collections.IDictionary properties, System.Collections.ICollection providerData) { }
    public System.Runtime.Remoting.Channels.IClientChannelSinkProvider Next { get { return default(System.Runtime.Remoting.Channels.IClientChannelSinkProvider); } set { } }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(4096), Infrastructure=true)]
    public System.Runtime.Remoting.Channels.IClientChannelSink CreateSink(System.Runtime.Remoting.Channels.IChannelSender channel, string url, object remoteChannelData) { return default(System.Runtime.Remoting.Channels.IClientChannelSink); }
  }
  public partial class SoapServerFormatterSink : System.Runtime.Remoting.Channels.IChannelSinkBase, System.Runtime.Remoting.Channels.IServerChannelSink {
    public SoapServerFormatterSink(System.Runtime.Remoting.Channels.SoapServerFormatterSink.Protocol protocol, System.Runtime.Remoting.Channels.IServerChannelSink nextSink, System.Runtime.Remoting.Channels.IChannelReceiver receiver) { }
    public System.Runtime.Remoting.Channels.IServerChannelSink NextChannelSink { get { return default(System.Runtime.Remoting.Channels.IServerChannelSink); } }
    public System.Collections.IDictionary Properties { get { return default(System.Collections.IDictionary); } }
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public System.Runtime.Serialization.Formatters.TypeFilterLevel TypeFilterLevel { get { return default(System.Runtime.Serialization.Formatters.TypeFilterLevel); } set { } }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(4096), Infrastructure=true)]
    public void AsyncProcessResponse(System.Runtime.Remoting.Channels.IServerResponseChannelSinkStack sinkStack, object state, System.Runtime.Remoting.Messaging.IMessage msg, System.Runtime.Remoting.Channels.ITransportHeaders headers, System.IO.Stream stream) { }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(4096), Infrastructure=true)]
    public System.IO.Stream GetResponseStream(System.Runtime.Remoting.Channels.IServerResponseChannelSinkStack sinkStack, object state, System.Runtime.Remoting.Messaging.IMessage msg, System.Runtime.Remoting.Channels.ITransportHeaders headers) { return default(System.IO.Stream); }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(4096), Infrastructure=true)]
    public System.Runtime.Remoting.Channels.ServerProcessing ProcessMessage(System.Runtime.Remoting.Channels.IServerChannelSinkStack sinkStack, System.Runtime.Remoting.Messaging.IMessage requestMsg, System.Runtime.Remoting.Channels.ITransportHeaders requestHeaders, System.IO.Stream requestStream, out System.Runtime.Remoting.Messaging.IMessage responseMsg, out System.Runtime.Remoting.Channels.ITransportHeaders responseHeaders, out System.IO.Stream responseStream) { responseMsg = default(System.Runtime.Remoting.Messaging.IMessage); responseHeaders = default(System.Runtime.Remoting.Channels.ITransportHeaders); responseStream = default(System.IO.Stream); return default(System.Runtime.Remoting.Channels.ServerProcessing); }
    public enum Protocol {
      Http = 0,
      Other = 1,
    }
  }
  public partial class SoapServerFormatterSinkProvider : System.Runtime.Remoting.Channels.IServerChannelSinkProvider, System.Runtime.Remoting.Channels.IServerFormatterSinkProvider {
    public SoapServerFormatterSinkProvider() { }
    public SoapServerFormatterSinkProvider(System.Collections.IDictionary properties, System.Collections.ICollection providerData) { }
    public System.Runtime.Remoting.Channels.IServerChannelSinkProvider Next { get { return default(System.Runtime.Remoting.Channels.IServerChannelSinkProvider); } set { } }
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public System.Runtime.Serialization.Formatters.TypeFilterLevel TypeFilterLevel { get { return default(System.Runtime.Serialization.Formatters.TypeFilterLevel); } set { } }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(4096), Infrastructure=true)]
    public System.Runtime.Remoting.Channels.IServerChannelSink CreateSink(System.Runtime.Remoting.Channels.IChannelReceiver channel) { return default(System.Runtime.Remoting.Channels.IServerChannelSink); }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(4096), Infrastructure=true)]
    public void GetChannelData(System.Runtime.Remoting.Channels.IChannelDataStore channelData) { }
  }
  public enum SocketCachePolicy {
    AbsoluteTimeout = 1,
    Default = 0,
  }
}
namespace System.Runtime.Remoting.Channels.Http {
  public partial class HttpChannel : System.Runtime.Remoting.Channels.BaseChannelWithProperties, System.Runtime.Remoting.Channels.IChannel, System.Runtime.Remoting.Channels.IChannelReceiver, System.Runtime.Remoting.Channels.IChannelReceiverHook, System.Runtime.Remoting.Channels.IChannelSender, System.Runtime.Remoting.Channels.ISecurableChannel {
    public HttpChannel() { }
    public HttpChannel(System.Collections.IDictionary properties, System.Runtime.Remoting.Channels.IClientChannelSinkProvider clientSinkProvider, System.Runtime.Remoting.Channels.IServerChannelSinkProvider serverSinkProvider) { }
    public HttpChannel(int port) { }
    public object ChannelData { get { return default(object); } }
    public string ChannelName { get { return default(string); } }
    public int ChannelPriority { get { return default(int); } }
    public string ChannelScheme { get { return default(string); } }
    public System.Runtime.Remoting.Channels.IServerChannelSink ChannelSinkChain { get { return default(System.Runtime.Remoting.Channels.IServerChannelSink); } }
    public bool IsSecured { get { return default(bool); } set { } }
    public override object this[object key] { get { return default(object); } set { } }
    public override System.Collections.ICollection Keys { get { return default(System.Collections.ICollection); } }
    public override System.Collections.IDictionary Properties { get { return default(System.Collections.IDictionary); } }
    public bool WantsToListen { get { return default(bool); } set { } }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(4096), Infrastructure=true)]
    public void AddHookChannelUri(string channelUri) { }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(4096), Infrastructure=true)]
    public System.Runtime.Remoting.Messaging.IMessageSink CreateMessageSink(string url, object remoteChannelData, out string objectURI) { objectURI = default(string); return default(System.Runtime.Remoting.Messaging.IMessageSink); }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(4096), Infrastructure=true)]
    public System.String[] GetUrlsForUri(string objectURI) { return default(System.String[]); }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(4096), Infrastructure=true)]
    public string Parse(string url, out string objectURI) { objectURI = default(string); return default(string); }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(4096), Infrastructure=true)]
    public void StartListening(object data) { }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(4096), Infrastructure=true)]
    public void StopListening(object data) { }
  }
  public partial class HttpClientChannel : System.Runtime.Remoting.Channels.BaseChannelWithProperties, System.Runtime.Remoting.Channels.IChannel, System.Runtime.Remoting.Channels.IChannelSender, System.Runtime.Remoting.Channels.ISecurableChannel {
    public HttpClientChannel() { }
    public HttpClientChannel(System.Collections.IDictionary properties, System.Runtime.Remoting.Channels.IClientChannelSinkProvider sinkProvider) { }
    public HttpClientChannel(string name, System.Runtime.Remoting.Channels.IClientChannelSinkProvider sinkProvider) { }
    public string ChannelName { get { return default(string); } }
    public int ChannelPriority { get { return default(int); } }
    public bool IsSecured { get { return default(bool); } set { } }
    public override object this[object key] { get { return default(object); } set { } }
    public override System.Collections.ICollection Keys { get { return default(System.Collections.ICollection); } }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(4096), Infrastructure=true)]
    public virtual System.Runtime.Remoting.Messaging.IMessageSink CreateMessageSink(string url, object remoteChannelData, out string objectURI) { objectURI = default(string); return default(System.Runtime.Remoting.Messaging.IMessageSink); }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(4096), Infrastructure=true)]
    public string Parse(string url, out string objectURI) { objectURI = default(string); return default(string); }
  }
  public partial class HttpRemotingHandler : System.Web.IHttpHandler {
    public HttpRemotingHandler() { }
    public HttpRemotingHandler(System.Type type, object srvID) { }
    public bool IsReusable { get { return default(bool); } }
    public void ProcessRequest(System.Web.HttpContext context) { }
  }
  public partial class HttpRemotingHandlerFactory : System.Web.IHttpHandlerFactory {
    public HttpRemotingHandlerFactory() { }
    public System.Web.IHttpHandler GetHandler(System.Web.HttpContext context, string verb, string url, string filePath) { return default(System.Web.IHttpHandler); }
    public void ReleaseHandler(System.Web.IHttpHandler handler) { }
  }
  public partial class HttpServerChannel : System.Runtime.Remoting.Channels.BaseChannelWithProperties, System.Runtime.Remoting.Channels.IChannel, System.Runtime.Remoting.Channels.IChannelReceiver, System.Runtime.Remoting.Channels.IChannelReceiverHook {
    public HttpServerChannel() { }
    public HttpServerChannel(System.Collections.IDictionary properties, System.Runtime.Remoting.Channels.IServerChannelSinkProvider sinkProvider) { }
    public HttpServerChannel(int port) { }
    public HttpServerChannel(string name, int port) { }
    public HttpServerChannel(string name, int port, System.Runtime.Remoting.Channels.IServerChannelSinkProvider sinkProvider) { }
    public object ChannelData { get { return default(object); } }
    public string ChannelName { get { return default(string); } }
    public int ChannelPriority { get { return default(int); } }
    public string ChannelScheme { get { return default(string); } }
    public System.Runtime.Remoting.Channels.IServerChannelSink ChannelSinkChain { get { return default(System.Runtime.Remoting.Channels.IServerChannelSink); } }
    public override object this[object key] { get { return default(object); } set { } }
    public override System.Collections.ICollection Keys { get { return default(System.Collections.ICollection); } }
    public bool WantsToListen { get { return default(bool); } set { } }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(4096), Infrastructure=true)]
    public void AddHookChannelUri(string channelUri) { }
    public string GetChannelUri() { return default(string); }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(4096), Infrastructure=true)]
    public virtual System.String[] GetUrlsForUri(string objectUri) { return default(System.String[]); }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(4096), Infrastructure=true)]
    public string Parse(string url, out string objectURI) { objectURI = default(string); return default(string); }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(4096), Infrastructure=true)]
    public void StartListening(object data) { }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(4096), Infrastructure=true)]
    public void StopListening(object data) { }
  }
}
namespace System.Runtime.Remoting.Channels.Ipc {
  public partial class IpcChannel : System.Runtime.Remoting.Channels.IChannel, System.Runtime.Remoting.Channels.IChannelReceiver, System.Runtime.Remoting.Channels.IChannelSender, System.Runtime.Remoting.Channels.ISecurableChannel {
    public IpcChannel() { }
    public IpcChannel(System.Collections.IDictionary properties, System.Runtime.Remoting.Channels.IClientChannelSinkProvider clientSinkProvider, System.Runtime.Remoting.Channels.IServerChannelSinkProvider serverSinkProvider) { }
    public IpcChannel(System.Collections.IDictionary properties, System.Runtime.Remoting.Channels.IClientChannelSinkProvider clientSinkProvider, System.Runtime.Remoting.Channels.IServerChannelSinkProvider serverSinkProvider, System.Security.AccessControl.CommonSecurityDescriptor securityDescriptor) { }
    public IpcChannel(string portName) { }
    public object ChannelData { get { return default(object); } }
    public string ChannelName { get { return default(string); } }
    public int ChannelPriority { get { return default(int); } }
    public bool IsSecured { get { return default(bool); } set { } }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(4096), Infrastructure=true)]
    public System.Runtime.Remoting.Messaging.IMessageSink CreateMessageSink(string url, object remoteChannelData, out string objectURI) { objectURI = default(string); return default(System.Runtime.Remoting.Messaging.IMessageSink); }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(4096), Infrastructure=true)]
    public System.String[] GetUrlsForUri(string objectURI) { return default(System.String[]); }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(4096), Infrastructure=true)]
    public string Parse(string url, out string objectURI) { objectURI = default(string); return default(string); }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(4096), Infrastructure=true)]
    public void StartListening(object data) { }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(4096), Infrastructure=true)]
    public void StopListening(object data) { }
  }
  public partial class IpcClientChannel : System.Runtime.Remoting.Channels.IChannel, System.Runtime.Remoting.Channels.IChannelSender, System.Runtime.Remoting.Channels.ISecurableChannel {
    public IpcClientChannel() { }
    public IpcClientChannel(System.Collections.IDictionary properties, System.Runtime.Remoting.Channels.IClientChannelSinkProvider sinkProvider) { }
    public IpcClientChannel(string name, System.Runtime.Remoting.Channels.IClientChannelSinkProvider sinkProvider) { }
    public string ChannelName { get { return default(string); } }
    public int ChannelPriority { get { return default(int); } }
    public bool IsSecured { get { return default(bool); } set { } }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(4096), Infrastructure=true)]
    public virtual System.Runtime.Remoting.Messaging.IMessageSink CreateMessageSink(string url, object remoteChannelData, out string objectURI) { objectURI = default(string); return default(System.Runtime.Remoting.Messaging.IMessageSink); }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(4096), Infrastructure=true)]
    public string Parse(string url, out string objectURI) { objectURI = default(string); return default(string); }
  }
  public partial class IpcServerChannel : System.Runtime.Remoting.Channels.IChannel, System.Runtime.Remoting.Channels.IChannelReceiver, System.Runtime.Remoting.Channels.ISecurableChannel {
    public IpcServerChannel(System.Collections.IDictionary properties, System.Runtime.Remoting.Channels.IServerChannelSinkProvider sinkProvider) { }
    public IpcServerChannel(System.Collections.IDictionary properties, System.Runtime.Remoting.Channels.IServerChannelSinkProvider sinkProvider, System.Security.AccessControl.CommonSecurityDescriptor securityDescriptor) { }
    public IpcServerChannel(string portName) { }
    public IpcServerChannel(string name, string portName) { }
    public IpcServerChannel(string name, string portName, System.Runtime.Remoting.Channels.IServerChannelSinkProvider sinkProvider) { }
    public object ChannelData { get { return default(object); } }
    public string ChannelName { get { return default(string); } }
    public int ChannelPriority { get { return default(int); } }
    public bool IsSecured { get { return default(bool); } set { } }
    public string GetChannelUri() { return default(string); }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(4096), Infrastructure=true)]
    public virtual System.String[] GetUrlsForUri(string objectUri) { return default(System.String[]); }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(4096), Infrastructure=true)]
    public string Parse(string url, out string objectURI) { objectURI = default(string); return default(string); }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(4096), Infrastructure=true)]
    public void StartListening(object data) { }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(4096), Infrastructure=true)]
    public void StopListening(object data) { }
  }
}
namespace System.Runtime.Remoting.Channels.Tcp {
  public partial class TcpChannel : System.Runtime.Remoting.Channels.IChannel, System.Runtime.Remoting.Channels.IChannelReceiver, System.Runtime.Remoting.Channels.IChannelSender, System.Runtime.Remoting.Channels.ISecurableChannel {
    public TcpChannel() { }
    public TcpChannel(System.Collections.IDictionary properties, System.Runtime.Remoting.Channels.IClientChannelSinkProvider clientSinkProvider, System.Runtime.Remoting.Channels.IServerChannelSinkProvider serverSinkProvider) { }
    public TcpChannel(int port) { }
    public object ChannelData { get { return default(object); } }
    public string ChannelName { get { return default(string); } }
    public int ChannelPriority { get { return default(int); } }
    public bool IsSecured { get { return default(bool); } set { } }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(4096), Infrastructure=true)]
    public System.Runtime.Remoting.Messaging.IMessageSink CreateMessageSink(string url, object remoteChannelData, out string objectURI) { objectURI = default(string); return default(System.Runtime.Remoting.Messaging.IMessageSink); }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(4096), Infrastructure=true)]
    public System.String[] GetUrlsForUri(string objectURI) { return default(System.String[]); }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(4096), Infrastructure=true)]
    public string Parse(string url, out string objectURI) { objectURI = default(string); return default(string); }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(4096), Infrastructure=true)]
    public void StartListening(object data) { }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(4096), Infrastructure=true)]
    public void StopListening(object data) { }
  }
  public partial class TcpClientChannel : System.Runtime.Remoting.Channels.IChannel, System.Runtime.Remoting.Channels.IChannelSender, System.Runtime.Remoting.Channels.ISecurableChannel {
    public TcpClientChannel() { }
    public TcpClientChannel(System.Collections.IDictionary properties, System.Runtime.Remoting.Channels.IClientChannelSinkProvider sinkProvider) { }
    public TcpClientChannel(string name, System.Runtime.Remoting.Channels.IClientChannelSinkProvider sinkProvider) { }
    public string ChannelName { get { return default(string); } }
    public int ChannelPriority { get { return default(int); } }
    public bool IsSecured { get { return default(bool); } set { } }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(4096), Infrastructure=true)]
    public virtual System.Runtime.Remoting.Messaging.IMessageSink CreateMessageSink(string url, object remoteChannelData, out string objectURI) { objectURI = default(string); return default(System.Runtime.Remoting.Messaging.IMessageSink); }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(4096), Infrastructure=true)]
    public string Parse(string url, out string objectURI) { objectURI = default(string); return default(string); }
  }
  public partial class TcpServerChannel : System.Runtime.Remoting.Channels.IChannel, System.Runtime.Remoting.Channels.IChannelReceiver, System.Runtime.Remoting.Channels.ISecurableChannel {
    public TcpServerChannel(System.Collections.IDictionary properties, System.Runtime.Remoting.Channels.IServerChannelSinkProvider sinkProvider) { }
    public TcpServerChannel(System.Collections.IDictionary properties, System.Runtime.Remoting.Channels.IServerChannelSinkProvider sinkProvider, System.Runtime.Remoting.Channels.IAuthorizeRemotingConnection authorizeCallback) { }
    public TcpServerChannel(int port) { }
    public TcpServerChannel(string name, int port) { }
    public TcpServerChannel(string name, int port, System.Runtime.Remoting.Channels.IServerChannelSinkProvider sinkProvider) { }
    public object ChannelData { get { return default(object); } }
    public string ChannelName { get { return default(string); } }
    public int ChannelPriority { get { return default(int); } }
    public bool IsSecured { get { return default(bool); } set { } }
    public string GetChannelUri() { return default(string); }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(4096), Infrastructure=true)]
    public virtual System.String[] GetUrlsForUri(string objectUri) { return default(System.String[]); }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(4096), Infrastructure=true)]
    public string Parse(string url, out string objectURI) { objectURI = default(string); return default(string); }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(4096), Infrastructure=true)]
    public void StartListening(object data) { }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(4096), Infrastructure=true)]
    public void StopListening(object data) { }
  }
}
namespace System.Runtime.Remoting.MetadataServices {
  public partial class MetaData {
    public MetaData() { }
    public static void ConvertCodeSourceFileToAssemblyFile(string codePath, string assemblyPath, string strongNameFilename) { }
    public static void ConvertCodeSourceStreamToAssemblyFile(System.Collections.ArrayList outCodeStreamList, string assemblyPath, string strongNameFilename) { }
    public static void ConvertSchemaStreamToCodeSourceStream(bool clientProxy, string outputDirectory, System.IO.Stream inputStream, System.Collections.ArrayList outCodeStreamList) { }
    public static void ConvertSchemaStreamToCodeSourceStream(bool clientProxy, string outputDirectory, System.IO.Stream inputStream, System.Collections.ArrayList outCodeStreamList, string proxyUrl) { }
    public static void ConvertSchemaStreamToCodeSourceStream(bool clientProxy, string outputDirectory, System.IO.Stream inputStream, System.Collections.ArrayList outCodeStreamList, string proxyUrl, string proxyNamespace) { }
    public static void ConvertTypesToSchemaToFile(System.Runtime.Remoting.MetadataServices.ServiceType[] types, System.Runtime.Remoting.MetadataServices.SdlType sdlType, string path) { }
    public static void ConvertTypesToSchemaToFile(System.Type[] types, System.Runtime.Remoting.MetadataServices.SdlType sdlType, string path) { }
    public static void ConvertTypesToSchemaToStream(System.Runtime.Remoting.MetadataServices.ServiceType[] serviceTypes, System.Runtime.Remoting.MetadataServices.SdlType sdlType, System.IO.Stream outputStream) { }
    public static void ConvertTypesToSchemaToStream(System.Type[] types, System.Runtime.Remoting.MetadataServices.SdlType sdlType, System.IO.Stream outputStream) { }
    public static void RetrieveSchemaFromUrlToFile(string url, string path) { }
    public static void RetrieveSchemaFromUrlToStream(string url, System.IO.Stream outputStream) { }
    public static void SaveStreamToFile(System.IO.Stream inputStream, string path) { }
  }
  public partial class SdlChannelSink : System.Runtime.Remoting.Channels.IChannelSinkBase, System.Runtime.Remoting.Channels.IServerChannelSink {
    public SdlChannelSink(System.Runtime.Remoting.Channels.IChannelReceiver receiver, System.Runtime.Remoting.Channels.IServerChannelSink nextSink) { }
    public System.Runtime.Remoting.Channels.IServerChannelSink NextChannelSink { get { return default(System.Runtime.Remoting.Channels.IServerChannelSink); } }
    public System.Collections.IDictionary Properties { get { return default(System.Collections.IDictionary); } }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(4096), Infrastructure=true)]
    public void AsyncProcessResponse(System.Runtime.Remoting.Channels.IServerResponseChannelSinkStack sinkStack, object state, System.Runtime.Remoting.Messaging.IMessage msg, System.Runtime.Remoting.Channels.ITransportHeaders headers, System.IO.Stream stream) { }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(4096), Infrastructure=true)]
    public System.IO.Stream GetResponseStream(System.Runtime.Remoting.Channels.IServerResponseChannelSinkStack sinkStack, object state, System.Runtime.Remoting.Messaging.IMessage msg, System.Runtime.Remoting.Channels.ITransportHeaders headers) { return default(System.IO.Stream); }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(4096), Infrastructure=true)]
    public System.Runtime.Remoting.Channels.ServerProcessing ProcessMessage(System.Runtime.Remoting.Channels.IServerChannelSinkStack sinkStack, System.Runtime.Remoting.Messaging.IMessage requestMsg, System.Runtime.Remoting.Channels.ITransportHeaders requestHeaders, System.IO.Stream requestStream, out System.Runtime.Remoting.Messaging.IMessage responseMsg, out System.Runtime.Remoting.Channels.ITransportHeaders responseHeaders, out System.IO.Stream responseStream) { responseMsg = default(System.Runtime.Remoting.Messaging.IMessage); responseHeaders = default(System.Runtime.Remoting.Channels.ITransportHeaders); responseStream = default(System.IO.Stream); return default(System.Runtime.Remoting.Channels.ServerProcessing); }
  }
  public partial class SdlChannelSinkProvider : System.Runtime.Remoting.Channels.IServerChannelSinkProvider {
    public SdlChannelSinkProvider() { }
    public SdlChannelSinkProvider(System.Collections.IDictionary properties, System.Collections.ICollection providerData) { }
    public System.Runtime.Remoting.Channels.IServerChannelSinkProvider Next { get { return default(System.Runtime.Remoting.Channels.IServerChannelSinkProvider); } set { } }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(4096), Infrastructure=true)]
    public System.Runtime.Remoting.Channels.IServerChannelSink CreateSink(System.Runtime.Remoting.Channels.IChannelReceiver channel) { return default(System.Runtime.Remoting.Channels.IServerChannelSink); }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(4096), Infrastructure=true)]
    public void GetChannelData(System.Runtime.Remoting.Channels.IChannelDataStore localChannelData) { }
  }
  public enum SdlType {
    Sdl = 0,
    Wsdl = 1,
  }
  public partial class ServiceType {
    public ServiceType(System.Type type) { }
    public ServiceType(System.Type type, string url) { }
    public System.Type ObjectType { get { return default(System.Type); } }
    public string Url { get { return default(string); } }
  }
  public partial class SUDSGeneratorException : System.Exception {
    protected SUDSGeneratorException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
  }
  public partial class SUDSParserException : System.Exception {
    protected SUDSParserException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
  }
}
namespace System.Runtime.Remoting.Services {
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public abstract partial class RemotingClientProxy : System.ComponentModel.Component {
    protected object _tp;
    protected System.Type _type;
    protected string _url;
    protected RemotingClientProxy() { }
    public bool AllowAutoRedirect { get { return default(bool); } set { } }
    public object Cookies { get { return default(object); } }
    public string Domain { get { return default(string); } set { } }
    public bool EnableCookies { get { return default(bool); } set { } }
    public string Password { get { return default(string); } set { } }
    public string Path { get { return default(string); } set { } }
    public bool PreAuthenticate { get { return default(bool); } set { } }
    public string ProxyName { get { return default(string); } set { } }
    public int ProxyPort { get { return default(int); } set { } }
    public int Timeout { get { return default(int); } set { } }
    public string Url { get { return default(string); } set { } }
    public string UserAgent { get { return default(string); } set { } }
    public string Username { get { return default(string); } set { } }
    protected void ConfigureProxy(System.Type type, string url) { }
    protected void ConnectProxy() { }
  }
  public partial class RemotingService : System.ComponentModel.Component {
    public RemotingService() { }
    public System.Web.HttpApplicationState Application { get { return default(System.Web.HttpApplicationState); } }
    public System.Web.HttpContext Context { get { return default(System.Web.HttpContext); } }
    public System.Web.HttpServerUtility Server { get { return default(System.Web.HttpServerUtility); } }
    public System.Web.SessionState.HttpSessionState Session { get { return default(System.Web.SessionState.HttpSessionState); } }
    public System.Security.Principal.IPrincipal User { get { return default(System.Security.Principal.IPrincipal); } }
  }
}
