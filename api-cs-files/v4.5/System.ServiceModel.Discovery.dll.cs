namespace System.ServiceModel.Discovery {
  public sealed partial class AnnouncementClient : System.IDisposable, System.ServiceModel.ICommunicationObject {
    public AnnouncementClient() { }
    public AnnouncementClient(System.ServiceModel.Discovery.AnnouncementEndpoint announcementEndpoint) { }
    public AnnouncementClient(string endpointConfigurationName) { }
    public System.ServiceModel.ChannelFactory ChannelFactory { get { return default(System.ServiceModel.ChannelFactory); } }
    public System.ServiceModel.Description.ClientCredentials ClientCredentials { get { return default(System.ServiceModel.Description.ClientCredentials); } }
    public System.ServiceModel.Description.ServiceEndpoint Endpoint { get { return default(System.ServiceModel.Description.ServiceEndpoint); } }
    public System.ServiceModel.IClientChannel InnerChannel { get { return default(System.ServiceModel.IClientChannel); } }
    public System.ServiceModel.Discovery.DiscoveryMessageSequenceGenerator MessageSequenceGenerator { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.ServiceModel.Discovery.DiscoveryMessageSequenceGenerator); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    System.ServiceModel.CommunicationState System.ServiceModel.ICommunicationObject.State { get { return default(System.ServiceModel.CommunicationState); } }
    public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> AnnounceOfflineCompleted { add { } remove { } }
    public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> AnnounceOnlineCompleted { add { } remove { } }
    event System.EventHandler System.ServiceModel.ICommunicationObject.Closed { add { } remove { } }
    event System.EventHandler System.ServiceModel.ICommunicationObject.Closing { add { } remove { } }
    event System.EventHandler System.ServiceModel.ICommunicationObject.Faulted { add { } remove { } }
    event System.EventHandler System.ServiceModel.ICommunicationObject.Opened { add { } remove { } }
    event System.EventHandler System.ServiceModel.ICommunicationObject.Opening { add { } remove { } }
    public void AnnounceOffline(System.ServiceModel.Discovery.EndpointDiscoveryMetadata discoveryMetadata) { }
    public void AnnounceOfflineAsync(System.ServiceModel.Discovery.EndpointDiscoveryMetadata discoveryMetadata) { }
    public void AnnounceOfflineAsync(System.ServiceModel.Discovery.EndpointDiscoveryMetadata discoveryMetadata, object userState) { }
    public void AnnounceOnline(System.ServiceModel.Discovery.EndpointDiscoveryMetadata discoveryMetadata) { }
    public void AnnounceOnlineAsync(System.ServiceModel.Discovery.EndpointDiscoveryMetadata discoveryMetadata) { }
    public void AnnounceOnlineAsync(System.ServiceModel.Discovery.EndpointDiscoveryMetadata discoveryMetadata, object userState) { }
    public System.IAsyncResult BeginAnnounceOffline(System.ServiceModel.Discovery.EndpointDiscoveryMetadata discoveryMetadata, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    public System.IAsyncResult BeginAnnounceOnline(System.ServiceModel.Discovery.EndpointDiscoveryMetadata discoveryMetadata, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    public void Close() { }
    public void EndAnnounceOffline(System.IAsyncResult result) { }
    public void EndAnnounceOnline(System.IAsyncResult result) { }
    public void Open() { }
    void System.IDisposable.Dispose() { }
    void System.ServiceModel.ICommunicationObject.Abort() { }
    System.IAsyncResult System.ServiceModel.ICommunicationObject.BeginClose(System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    System.IAsyncResult System.ServiceModel.ICommunicationObject.BeginClose(System.TimeSpan timeout, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    System.IAsyncResult System.ServiceModel.ICommunicationObject.BeginOpen(System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    System.IAsyncResult System.ServiceModel.ICommunicationObject.BeginOpen(System.TimeSpan timeout, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    void System.ServiceModel.ICommunicationObject.Close() { }
    void System.ServiceModel.ICommunicationObject.Close(System.TimeSpan timeout) { }
    void System.ServiceModel.ICommunicationObject.EndClose(System.IAsyncResult result) { }
    void System.ServiceModel.ICommunicationObject.EndOpen(System.IAsyncResult result) { }
    void System.ServiceModel.ICommunicationObject.Open() { }
    void System.ServiceModel.ICommunicationObject.Open(System.TimeSpan timeout) { }
  }
  public partial class AnnouncementEndpoint : System.ServiceModel.Description.ServiceEndpoint {
    public AnnouncementEndpoint() : base (default(System.ServiceModel.Description.ContractDescription)) { }
    public AnnouncementEndpoint(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress address) : base (default(System.ServiceModel.Description.ContractDescription)) { }
    public AnnouncementEndpoint(System.ServiceModel.Discovery.DiscoveryVersion discoveryVersion) : base (default(System.ServiceModel.Description.ContractDescription)) { }
    public AnnouncementEndpoint(System.ServiceModel.Discovery.DiscoveryVersion discoveryVersion, System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress address) : base (default(System.ServiceModel.Description.ContractDescription)) { }
    public System.ServiceModel.Discovery.DiscoveryVersion DiscoveryVersion { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.ServiceModel.Discovery.DiscoveryVersion); } }
    public System.TimeSpan MaxAnnouncementDelay { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.TimeSpan); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
  }
  public partial class AnnouncementEventArgs : System.EventArgs {
    internal AnnouncementEventArgs() { }
    public System.ServiceModel.Discovery.EndpointDiscoveryMetadata EndpointDiscoveryMetadata { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.ServiceModel.Discovery.EndpointDiscoveryMetadata); } }
    public System.ServiceModel.Discovery.DiscoveryMessageSequence MessageSequence { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.ServiceModel.Discovery.DiscoveryMessageSequence); } }
  }
  [System.ServiceModel.ServiceBehaviorAttribute(InstanceContextMode=(System.ServiceModel.InstanceContextMode)(2), ConcurrencyMode=(System.ServiceModel.ConcurrencyMode)(2))]
  public partial class AnnouncementService {
    public AnnouncementService() { }
    public AnnouncementService(int duplicateMessageHistoryLength) { }
    public event System.EventHandler<System.ServiceModel.Discovery.AnnouncementEventArgs> OfflineAnnouncementReceived { add { } remove { } }
    public event System.EventHandler<System.ServiceModel.Discovery.AnnouncementEventArgs> OnlineAnnouncementReceived { add { } remove { } }
    protected virtual System.IAsyncResult OnBeginOfflineAnnouncement(System.ServiceModel.Discovery.DiscoveryMessageSequence messageSequence, System.ServiceModel.Discovery.EndpointDiscoveryMetadata endpointDiscoveryMetadata, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    protected virtual System.IAsyncResult OnBeginOnlineAnnouncement(System.ServiceModel.Discovery.DiscoveryMessageSequence messageSequence, System.ServiceModel.Discovery.EndpointDiscoveryMetadata endpointDiscoveryMetadata, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    protected virtual void OnEndOfflineAnnouncement(System.IAsyncResult result) { }
    protected virtual void OnEndOnlineAnnouncement(System.IAsyncResult result) { }
  }
  public sealed partial class DiscoveryClient : System.IDisposable, System.ServiceModel.ICommunicationObject {
    public DiscoveryClient() { }
    public DiscoveryClient(System.ServiceModel.Discovery.DiscoveryEndpoint discoveryEndpoint) { }
    public DiscoveryClient(string endpointConfigurationName) { }
    public System.ServiceModel.ChannelFactory ChannelFactory { get { return default(System.ServiceModel.ChannelFactory); } }
    public System.ServiceModel.Description.ClientCredentials ClientCredentials { get { return default(System.ServiceModel.Description.ClientCredentials); } }
    public System.ServiceModel.Description.ServiceEndpoint Endpoint { get { return default(System.ServiceModel.Description.ServiceEndpoint); } }
    public System.ServiceModel.IClientChannel InnerChannel { get { return default(System.ServiceModel.IClientChannel); } }
    System.ServiceModel.CommunicationState System.ServiceModel.ICommunicationObject.State { get { return default(System.ServiceModel.CommunicationState); } }
    public event System.EventHandler<System.ServiceModel.Discovery.FindCompletedEventArgs> FindCompleted { add { } remove { } }
    public event System.EventHandler<System.ServiceModel.Discovery.FindProgressChangedEventArgs> FindProgressChanged { add { } remove { } }
    public event System.EventHandler<System.ServiceModel.Discovery.AnnouncementEventArgs> ProxyAvailable { add { } remove { } }
    public event System.EventHandler<System.ServiceModel.Discovery.ResolveCompletedEventArgs> ResolveCompleted { add { } remove { } }
    event System.EventHandler System.ServiceModel.ICommunicationObject.Closed { add { } remove { } }
    event System.EventHandler System.ServiceModel.ICommunicationObject.Closing { add { } remove { } }
    event System.EventHandler System.ServiceModel.ICommunicationObject.Faulted { add { } remove { } }
    event System.EventHandler System.ServiceModel.ICommunicationObject.Opened { add { } remove { } }
    event System.EventHandler System.ServiceModel.ICommunicationObject.Opening { add { } remove { } }
    public void CancelAsync(object userState) { }
    public void Close() { }
    public System.ServiceModel.Discovery.FindResponse Find(System.ServiceModel.Discovery.FindCriteria criteria) { return default(System.ServiceModel.Discovery.FindResponse); }
    public void FindAsync(System.ServiceModel.Discovery.FindCriteria criteria) { }
    public void FindAsync(System.ServiceModel.Discovery.FindCriteria criteria, object userState) { }
    public void Open() { }
    public System.ServiceModel.Discovery.ResolveResponse Resolve(System.ServiceModel.Discovery.ResolveCriteria criteria) { return default(System.ServiceModel.Discovery.ResolveResponse); }
    public void ResolveAsync(System.ServiceModel.Discovery.ResolveCriteria criteria) { }
    public void ResolveAsync(System.ServiceModel.Discovery.ResolveCriteria criteria, object userState) { }
    void System.IDisposable.Dispose() { }
    void System.ServiceModel.ICommunicationObject.Abort() { }
    System.IAsyncResult System.ServiceModel.ICommunicationObject.BeginClose(System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    System.IAsyncResult System.ServiceModel.ICommunicationObject.BeginClose(System.TimeSpan timeout, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    System.IAsyncResult System.ServiceModel.ICommunicationObject.BeginOpen(System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    System.IAsyncResult System.ServiceModel.ICommunicationObject.BeginOpen(System.TimeSpan timeout, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    void System.ServiceModel.ICommunicationObject.Close() { }
    void System.ServiceModel.ICommunicationObject.Close(System.TimeSpan timeout) { }
    void System.ServiceModel.ICommunicationObject.EndClose(System.IAsyncResult result) { }
    void System.ServiceModel.ICommunicationObject.EndOpen(System.IAsyncResult result) { }
    void System.ServiceModel.ICommunicationObject.Open() { }
    void System.ServiceModel.ICommunicationObject.Open(System.TimeSpan timeout) { }
  }
  public sealed partial class DiscoveryClientBindingElement : System.ServiceModel.Channels.BindingElement {
    public static readonly System.ServiceModel.EndpointAddress DiscoveryEndpointAddress;
    public DiscoveryClientBindingElement() { }
    public DiscoveryClientBindingElement(System.ServiceModel.Discovery.DiscoveryEndpointProvider discoveryEndpointProvider, System.ServiceModel.Discovery.FindCriteria findCriteria) { }
    public System.ServiceModel.Discovery.DiscoveryEndpointProvider DiscoveryEndpointProvider { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.ServiceModel.Discovery.DiscoveryEndpointProvider); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.ServiceModel.Discovery.FindCriteria FindCriteria { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.ServiceModel.Discovery.FindCriteria); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public override System.ServiceModel.Channels.IChannelFactory<TChannel> BuildChannelFactory<TChannel>(System.ServiceModel.Channels.BindingContext context) { return default(System.ServiceModel.Channels.IChannelFactory<TChannel>); }
    public override System.ServiceModel.Channels.IChannelListener<TChannel> BuildChannelListener<TChannel>(System.ServiceModel.Channels.BindingContext context) { return default(System.ServiceModel.Channels.IChannelListener<TChannel>); }
    public override bool CanBuildChannelFactory<TChannel>(System.ServiceModel.Channels.BindingContext context) { return default(bool); }
    public override bool CanBuildChannelListener<TChannel>(System.ServiceModel.Channels.BindingContext context) { return default(bool); }
    public override System.ServiceModel.Channels.BindingElement Clone() { return default(System.ServiceModel.Channels.BindingElement); }
    public override T GetProperty<T>(System.ServiceModel.Channels.BindingContext context) { return default(T); }
  }
  public partial class DiscoveryEndpoint : System.ServiceModel.Description.ServiceEndpoint {
    public DiscoveryEndpoint() : base (default(System.ServiceModel.Description.ContractDescription)) { }
    public DiscoveryEndpoint(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress endpointAddress) : base (default(System.ServiceModel.Description.ContractDescription)) { }
    public DiscoveryEndpoint(System.ServiceModel.Discovery.DiscoveryVersion discoveryVersion, System.ServiceModel.Discovery.ServiceDiscoveryMode discoveryMode) : base (default(System.ServiceModel.Description.ContractDescription)) { }
    public DiscoveryEndpoint(System.ServiceModel.Discovery.DiscoveryVersion discoveryVersion, System.ServiceModel.Discovery.ServiceDiscoveryMode discoveryMode, System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress endpointAddress) : base (default(System.ServiceModel.Description.ContractDescription)) { }
    public System.ServiceModel.Discovery.ServiceDiscoveryMode DiscoveryMode { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.ServiceModel.Discovery.ServiceDiscoveryMode); } }
    public System.ServiceModel.Discovery.DiscoveryVersion DiscoveryVersion { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.ServiceModel.Discovery.DiscoveryVersion); } }
    public System.TimeSpan MaxResponseDelay { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.TimeSpan); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
  }
  public abstract partial class DiscoveryEndpointProvider {
    protected DiscoveryEndpointProvider() { }
    public abstract System.ServiceModel.Discovery.DiscoveryEndpoint GetDiscoveryEndpoint();
  }
  public partial class DiscoveryMessageSequence : System.IComparable<System.ServiceModel.Discovery.DiscoveryMessageSequence>, System.IEquatable<System.ServiceModel.Discovery.DiscoveryMessageSequence> {
    internal DiscoveryMessageSequence() { }
    public long InstanceId { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(long); } }
    public long MessageNumber { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(long); } }
    public System.Uri SequenceId { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Uri); } }
    public bool CanCompareTo(System.ServiceModel.Discovery.DiscoveryMessageSequence other) { return default(bool); }
    public int CompareTo(System.ServiceModel.Discovery.DiscoveryMessageSequence other) { return default(int); }
    public override bool Equals(object obj) { return default(bool); }
    public bool Equals(System.ServiceModel.Discovery.DiscoveryMessageSequence other) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public static bool operator ==(System.ServiceModel.Discovery.DiscoveryMessageSequence messageSequence1, System.ServiceModel.Discovery.DiscoveryMessageSequence messageSequence2) { return default(bool); }
    public static bool operator !=(System.ServiceModel.Discovery.DiscoveryMessageSequence messageSequence1, System.ServiceModel.Discovery.DiscoveryMessageSequence messageSequence2) { return default(bool); }
    public override string ToString() { return default(string); }
  }
  public partial class DiscoveryMessageSequenceGenerator {
    public DiscoveryMessageSequenceGenerator() { }
    public DiscoveryMessageSequenceGenerator(long instanceId, System.Uri sequenceId) { }
    public System.ServiceModel.Discovery.DiscoveryMessageSequence Next() { return default(System.ServiceModel.Discovery.DiscoveryMessageSequence); }
  }
  [System.MonoTODOAttribute]
  public partial class DiscoveryOperationContextExtension : System.ServiceModel.IExtension<System.ServiceModel.OperationContext> {
    internal DiscoveryOperationContextExtension() { }
    public System.ServiceModel.Discovery.ServiceDiscoveryMode DiscoveryMode { get { return default(System.ServiceModel.Discovery.ServiceDiscoveryMode); } }
    public System.ServiceModel.Discovery.DiscoveryVersion DiscoveryVersion { get { return default(System.ServiceModel.Discovery.DiscoveryVersion); } }
    public System.TimeSpan MaxResponseDelay { get { return default(System.TimeSpan); } }
    void System.ServiceModel.IExtension<System.ServiceModel.OperationContext>.Attach(System.ServiceModel.OperationContext owner) { }
    void System.ServiceModel.IExtension<System.ServiceModel.OperationContext>.Detach(System.ServiceModel.OperationContext owner) { }
  }
  [System.MonoTODOAttribute]
  public abstract partial class DiscoveryProxy {
    protected DiscoveryProxy() { }
    protected DiscoveryProxy(System.ServiceModel.Discovery.DiscoveryMessageSequenceGenerator messageSequenceGenerator) { }
    protected DiscoveryProxy(System.ServiceModel.Discovery.DiscoveryMessageSequenceGenerator messageSequenceGenerator, int duplicateMessageHistoryLength) { }
    protected virtual System.IAsyncResult BeginShouldRedirectFind(System.ServiceModel.Discovery.FindCriteria resolveCriteria, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    protected virtual System.IAsyncResult BeginShouldRedirectResolve(System.ServiceModel.Discovery.ResolveCriteria findCriteria, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    protected virtual bool EndShouldRedirectFind(System.IAsyncResult result, out System.Collections.ObjectModel.Collection<System.ServiceModel.Discovery.EndpointDiscoveryMetadata> redirectionEndpoints) { redirectionEndpoints = default(System.Collections.ObjectModel.Collection<System.ServiceModel.Discovery.EndpointDiscoveryMetadata>); return default(bool); }
    protected virtual bool EndShouldRedirectResolve(System.IAsyncResult result, out System.Collections.ObjectModel.Collection<System.ServiceModel.Discovery.EndpointDiscoveryMetadata> redirectionEndpoints) { redirectionEndpoints = default(System.Collections.ObjectModel.Collection<System.ServiceModel.Discovery.EndpointDiscoveryMetadata>); return default(bool); }
    protected abstract System.IAsyncResult OnBeginFind(System.ServiceModel.Discovery.FindRequestContext findRequestContext, System.AsyncCallback callback, object state);
    protected abstract System.IAsyncResult OnBeginOfflineAnnouncement(System.ServiceModel.Discovery.DiscoveryMessageSequence messageSequence, System.ServiceModel.Discovery.EndpointDiscoveryMetadata endpointDiscoveryMetadata, System.AsyncCallback callback, object state);
    protected abstract System.IAsyncResult OnBeginOnlineAnnouncement(System.ServiceModel.Discovery.DiscoveryMessageSequence messageSequence, System.ServiceModel.Discovery.EndpointDiscoveryMetadata endpointDiscoveryMetadata, System.AsyncCallback callback, object state);
    protected abstract System.IAsyncResult OnBeginResolve(System.ServiceModel.Discovery.ResolveCriteria resolveCriteria, System.AsyncCallback callback, object state);
    protected abstract void OnEndFind(System.IAsyncResult result);
    protected abstract void OnEndOfflineAnnouncement(System.IAsyncResult result);
    protected abstract void OnEndOnlineAnnouncement(System.IAsyncResult result);
    protected abstract System.ServiceModel.Discovery.EndpointDiscoveryMetadata OnEndResolve(System.IAsyncResult result);
  }
  public abstract partial class DiscoveryService {
    protected DiscoveryService() { }
    protected DiscoveryService(System.ServiceModel.Discovery.DiscoveryMessageSequenceGenerator discoveryMessageSequenceGenerator) { }
    protected DiscoveryService(System.ServiceModel.Discovery.DiscoveryMessageSequenceGenerator discoveryMessageSequenceGenerator, int duplicateMessageHistoryLength) { }
    protected abstract System.IAsyncResult OnBeginFind(System.ServiceModel.Discovery.FindRequestContext findRequestContext, System.AsyncCallback callback, object state);
    protected abstract System.IAsyncResult OnBeginResolve(System.ServiceModel.Discovery.ResolveCriteria resolveCriteria, System.AsyncCallback callback, object state);
    protected abstract void OnEndFind(System.IAsyncResult result);
    protected abstract System.ServiceModel.Discovery.EndpointDiscoveryMetadata OnEndResolve(System.IAsyncResult result);
  }
  public abstract partial class DiscoveryServiceExtension : System.ServiceModel.IExtension<System.ServiceModel.ServiceHostBase> {
    protected DiscoveryServiceExtension() { }
    public System.Collections.ObjectModel.ReadOnlyCollection<System.ServiceModel.Discovery.EndpointDiscoveryMetadata> PublishedEndpoints { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.ServiceModel.Discovery.EndpointDiscoveryMetadata>); } }
    protected abstract System.ServiceModel.Discovery.DiscoveryService GetDiscoveryService();
    void System.ServiceModel.IExtension<System.ServiceModel.ServiceHostBase>.Attach(System.ServiceModel.ServiceHostBase owner) { }
    void System.ServiceModel.IExtension<System.ServiceModel.ServiceHostBase>.Detach(System.ServiceModel.ServiceHostBase owner) { }
  }
  public sealed partial class DiscoveryVersion {
    internal DiscoveryVersion() { }
    public System.Uri AdhocAddress { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Uri); } }
    public System.ServiceModel.Channels.MessageVersion MessageVersion { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.ServiceModel.Channels.MessageVersion); } }
    public string Name { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
    public string Namespace { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
    public static System.ServiceModel.Discovery.DiscoveryVersion WSDiscovery11 { get { return default(System.ServiceModel.Discovery.DiscoveryVersion); } }
    public static System.ServiceModel.Discovery.DiscoveryVersion WSDiscoveryApril2005 { get { return default(System.ServiceModel.Discovery.DiscoveryVersion); } }
    public static System.ServiceModel.Discovery.DiscoveryVersion WSDiscoveryCD1 { get { return default(System.ServiceModel.Discovery.DiscoveryVersion); } }
    public static System.ServiceModel.Discovery.DiscoveryVersion FromName(string name) { return default(System.ServiceModel.Discovery.DiscoveryVersion); }
    public override string ToString() { return default(string); }
  }
  public partial class DynamicEndpoint : System.ServiceModel.Description.ServiceEndpoint {
    public DynamicEndpoint(System.ServiceModel.Description.ContractDescription contract, System.ServiceModel.Channels.Binding binding) : base (default(System.ServiceModel.Description.ContractDescription)) { }
    public System.ServiceModel.Discovery.DiscoveryEndpointProvider DiscoveryEndpointProvider { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.ServiceModel.Discovery.DiscoveryEndpointProvider); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.ServiceModel.Discovery.FindCriteria FindCriteria { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.ServiceModel.Discovery.FindCriteria); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
  }
  public partial class EndpointDiscoveryBehavior : System.ServiceModel.Description.IEndpointBehavior {
    public EndpointDiscoveryBehavior() { }
    public System.Collections.ObjectModel.Collection<System.Xml.XmlQualifiedName> ContractTypeNames { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Collections.ObjectModel.Collection<System.Xml.XmlQualifiedName>); } }
    public bool Enabled { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Collections.ObjectModel.Collection<System.Xml.Linq.XElement> Extensions { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Collections.ObjectModel.Collection<System.Xml.Linq.XElement>); } }
    public System.Collections.ObjectModel.Collection<System.Uri> Scopes { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Collections.ObjectModel.Collection<System.Uri>); } }
    void System.ServiceModel.Description.IEndpointBehavior.AddBindingParameters(System.ServiceModel.Description.ServiceEndpoint endpoint, System.ServiceModel.Channels.BindingParameterCollection bindingParameters) { }
    void System.ServiceModel.Description.IEndpointBehavior.ApplyClientBehavior(System.ServiceModel.Description.ServiceEndpoint endpoint, System.ServiceModel.Dispatcher.ClientRuntime clientRuntime) { }
    void System.ServiceModel.Description.IEndpointBehavior.ApplyDispatchBehavior(System.ServiceModel.Description.ServiceEndpoint endpoint, System.ServiceModel.Dispatcher.EndpointDispatcher endpointDispatcher) { }
    void System.ServiceModel.Description.IEndpointBehavior.Validate(System.ServiceModel.Description.ServiceEndpoint endpoint) { }
  }
  public partial class EndpointDiscoveryMetadata {
    public EndpointDiscoveryMetadata() { }
    public System.ServiceModel.EndpointAddress Address { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.ServiceModel.EndpointAddress); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Collections.ObjectModel.Collection<System.Xml.XmlQualifiedName> ContractTypeNames { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Collections.ObjectModel.Collection<System.Xml.XmlQualifiedName>); } }
    public System.Collections.ObjectModel.Collection<System.Xml.Linq.XElement> Extensions { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Collections.ObjectModel.Collection<System.Xml.Linq.XElement>); } }
    public System.Collections.ObjectModel.Collection<System.Uri> ListenUris { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Collections.ObjectModel.Collection<System.Uri>); } }
    public System.Collections.ObjectModel.Collection<System.Uri> Scopes { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Collections.ObjectModel.Collection<System.Uri>); } }
    public int Version { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(int); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public static System.ServiceModel.Discovery.EndpointDiscoveryMetadata FromServiceEndpoint(System.ServiceModel.Description.ServiceEndpoint endpoint) { return default(System.ServiceModel.Discovery.EndpointDiscoveryMetadata); }
    public static System.ServiceModel.Discovery.EndpointDiscoveryMetadata FromServiceEndpoint(System.ServiceModel.Description.ServiceEndpoint endpoint, System.ServiceModel.Dispatcher.EndpointDispatcher endpointDispatcher) { return default(System.ServiceModel.Discovery.EndpointDiscoveryMetadata); }
  }
  public partial class FindCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
    internal FindCompletedEventArgs() { }
    public System.ServiceModel.Discovery.FindResponse Result { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.ServiceModel.Discovery.FindResponse); } }
  }
  public partial class FindCriteria {
    public static readonly System.Uri ScopeMatchByExact;
    public static readonly System.Uri ScopeMatchByLdap;
    public static readonly System.Uri ScopeMatchByNone;
    public static readonly System.Uri ScopeMatchByPrefix;
    public static readonly System.Uri ScopeMatchByUuid;
    public FindCriteria() { }
    public FindCriteria(System.Type contractType) { }
    public System.Collections.ObjectModel.Collection<System.Xml.XmlQualifiedName> ContractTypeNames { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Collections.ObjectModel.Collection<System.Xml.XmlQualifiedName>); } }
    public System.TimeSpan Duration { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.TimeSpan); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Collections.ObjectModel.Collection<System.Xml.Linq.XElement> Extensions { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Collections.ObjectModel.Collection<System.Xml.Linq.XElement>); } }
    public int MaxResults { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(int); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Uri ScopeMatchBy { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Uri); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Collections.ObjectModel.Collection<System.Uri> Scopes { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Collections.ObjectModel.Collection<System.Uri>); } }
    public static System.ServiceModel.Discovery.FindCriteria CreateMetadataExchangeEndpointCriteria() { return default(System.ServiceModel.Discovery.FindCriteria); }
    public static System.ServiceModel.Discovery.FindCriteria CreateMetadataExchangeEndpointCriteria(System.Collections.Generic.IEnumerable<System.Xml.XmlQualifiedName> contractTypeNames) { return default(System.ServiceModel.Discovery.FindCriteria); }
    public static System.ServiceModel.Discovery.FindCriteria CreateMetadataExchangeEndpointCriteria(System.Type contractType) { return default(System.ServiceModel.Discovery.FindCriteria); }
    [System.MonoTODOAttribute("find out conformant behavior, and implement remaining bits")]
    public bool IsMatch(System.ServiceModel.Discovery.EndpointDiscoveryMetadata endpointDiscoveryMetadata) { return default(bool); }
  }
  public partial class FindProgressChangedEventArgs : System.ComponentModel.ProgressChangedEventArgs {
    internal FindProgressChangedEventArgs() : base (default(int), default(object)) { }
    public System.ServiceModel.Discovery.EndpointDiscoveryMetadata EndpointDiscoveryMetadata { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.ServiceModel.Discovery.EndpointDiscoveryMetadata); } }
    public System.ServiceModel.Discovery.DiscoveryMessageSequence MessageSequence { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.ServiceModel.Discovery.DiscoveryMessageSequence); } }
  }
  public partial class FindRequestContext {
    protected FindRequestContext(System.ServiceModel.Discovery.FindCriteria criteria) { }
    public System.ServiceModel.Discovery.FindCriteria Criteria { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.ServiceModel.Discovery.FindCriteria); } }
    public void AddMatchingEndpoint(System.ServiceModel.Discovery.EndpointDiscoveryMetadata matchingEndpoint) { }
    protected virtual void OnAddMatchingEndpoint(System.ServiceModel.Discovery.EndpointDiscoveryMetadata matchingEndpoint) { }
  }
  public partial class FindResponse {
    internal FindResponse() { }
    public System.Collections.ObjectModel.Collection<System.ServiceModel.Discovery.EndpointDiscoveryMetadata> Endpoints { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Collections.ObjectModel.Collection<System.ServiceModel.Discovery.EndpointDiscoveryMetadata>); } }
    [System.MonoTODOAttribute]
    public System.ServiceModel.Discovery.DiscoveryMessageSequence GetMessageSequence(System.ServiceModel.Discovery.EndpointDiscoveryMetadata endpointDiscoveryMetadata) { return default(System.ServiceModel.Discovery.DiscoveryMessageSequence); }
  }
  public partial class ResolveCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
    internal ResolveCompletedEventArgs() { }
    public System.ServiceModel.Discovery.ResolveResponse Result { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.ServiceModel.Discovery.ResolveResponse); } }
  }
  public partial class ResolveCriteria {
    public ResolveCriteria() { }
    public ResolveCriteria(System.ServiceModel.EndpointAddress address) { }
    public System.ServiceModel.EndpointAddress Address { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.ServiceModel.EndpointAddress); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.TimeSpan Duration { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.TimeSpan); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Collections.ObjectModel.Collection<System.Xml.Linq.XElement> Extensions { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Collections.ObjectModel.Collection<System.Xml.Linq.XElement>); } }
  }
  public partial class ResolveResponse {
    internal ResolveResponse() { }
    public System.ServiceModel.Discovery.EndpointDiscoveryMetadata EndpointDiscoveryMetadata { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.ServiceModel.Discovery.EndpointDiscoveryMetadata); } }
    public System.ServiceModel.Discovery.DiscoveryMessageSequence MessageSequence { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.ServiceModel.Discovery.DiscoveryMessageSequence); } }
  }
  public partial class ServiceDiscoveryBehavior : System.ServiceModel.Description.IServiceBehavior {
    public ServiceDiscoveryBehavior() { }
    public System.Collections.ObjectModel.Collection<System.ServiceModel.Discovery.AnnouncementEndpoint> AnnouncementEndpoints { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Collections.ObjectModel.Collection<System.ServiceModel.Discovery.AnnouncementEndpoint>); } }
    void System.ServiceModel.Description.IServiceBehavior.AddBindingParameters(System.ServiceModel.Description.ServiceDescription serviceDescription, System.ServiceModel.ServiceHostBase serviceHostBase, System.Collections.ObjectModel.Collection<System.ServiceModel.Description.ServiceEndpoint> endpoints, System.ServiceModel.Channels.BindingParameterCollection bindingParameters) { }
    void System.ServiceModel.Description.IServiceBehavior.ApplyDispatchBehavior(System.ServiceModel.Description.ServiceDescription serviceDescription, System.ServiceModel.ServiceHostBase serviceHostBase) { }
    void System.ServiceModel.Description.IServiceBehavior.Validate(System.ServiceModel.Description.ServiceDescription serviceDescription, System.ServiceModel.ServiceHostBase serviceHostBase) { }
  }
  public enum ServiceDiscoveryMode {
    Adhoc = 0,
    Managed = 1,
  }
  public partial class UdpAnnouncementEndpoint : System.ServiceModel.Discovery.AnnouncementEndpoint {
    public static readonly System.Uri DefaultIPv4MulticastAddress;
    public static readonly System.Uri DefaultIPv6MulticastAddress;
    public UdpAnnouncementEndpoint() { }
    public UdpAnnouncementEndpoint(System.ServiceModel.Discovery.DiscoveryVersion discoveryVersion) { }
    public UdpAnnouncementEndpoint(System.ServiceModel.Discovery.DiscoveryVersion discoveryVersion, string multicastAddress) { }
    public UdpAnnouncementEndpoint(System.ServiceModel.Discovery.DiscoveryVersion discoveryVersion, System.Uri multicastAddress) { }
    public UdpAnnouncementEndpoint(string multicastAddress) { }
    public UdpAnnouncementEndpoint(System.Uri multicastAddress) { }
    public System.Uri MulticastAddress { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Uri); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.ServiceModel.Discovery.UdpTransportSettings TransportSettings { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.ServiceModel.Discovery.UdpTransportSettings); } }
  }
  public partial class UdpDiscoveryEndpoint : System.ServiceModel.Discovery.DiscoveryEndpoint {
    public static readonly System.Uri DefaultIPv4MulticastAddress;
    public static readonly System.Uri DefaultIPv6MulticastAddress;
    public UdpDiscoveryEndpoint() { }
    public UdpDiscoveryEndpoint(System.ServiceModel.Discovery.DiscoveryVersion discoveryVersion) { }
    public UdpDiscoveryEndpoint(System.ServiceModel.Discovery.DiscoveryVersion discoveryVersion, string multicastAddress) { }
    public UdpDiscoveryEndpoint(System.ServiceModel.Discovery.DiscoveryVersion discoveryVersion, System.Uri multicastAddress) { }
    public UdpDiscoveryEndpoint(string multicastAddress) { }
    public UdpDiscoveryEndpoint(System.Uri multicastAddress) { }
    public System.Uri MulticastAddress { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Uri); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.ServiceModel.Discovery.UdpTransportSettings TransportSettings { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.ServiceModel.Discovery.UdpTransportSettings); } }
  }
  public partial class UdpTransportSettings {
    internal UdpTransportSettings() { }
    public int DuplicateMessageHistoryLength { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(int); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public long MaxBufferPoolSize { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(long); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public int MaxMulticastRetransmitCount { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(int); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public int MaxPendingMessageCount { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(int); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public long MaxReceivedMessageSize { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(long); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public int MaxUnicastRetransmitCount { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(int); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public string MulticastInterfaceId { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public int SocketReceiveBufferSize { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(int); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public int TimeToLive { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(int); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
  }
}
namespace System.ServiceModel.Discovery.Configuration {
  [System.Configuration.ConfigurationCollectionAttribute(typeof(System.ServiceModel.Configuration.ChannelEndpointElement), AddItemName="endpoint")]
  public sealed partial class AnnouncementChannelEndpointElementCollection : System.ServiceModel.Configuration.ServiceModelConfigurationElementCollection<System.ServiceModel.Configuration.ChannelEndpointElement> {
    public AnnouncementChannelEndpointElementCollection() { }
    protected override object GetElementKey(System.Configuration.ConfigurationElement element) { return default(object); }
  }
  public partial class AnnouncementEndpointCollectionElement : System.ServiceModel.Configuration.StandardEndpointCollectionElement<System.ServiceModel.Discovery.AnnouncementEndpoint, System.ServiceModel.Discovery.Configuration.AnnouncementEndpointElement> {
    public AnnouncementEndpointCollectionElement() { }
  }
  public partial class AnnouncementEndpointElement : System.ServiceModel.Configuration.StandardEndpointElement {
    public AnnouncementEndpointElement() { }
    [System.ComponentModel.TypeConverterAttribute(typeof(System.ServiceModel.Discovery.Configuration.DiscoveryVersionConverter))]
    [System.Configuration.ConfigurationPropertyAttribute("discoveryVersion", DefaultValue="WSDiscovery11")]
    public System.ServiceModel.Discovery.DiscoveryVersion DiscoveryVersion { get { return default(System.ServiceModel.Discovery.DiscoveryVersion); } set { } }
    protected internal override System.Type EndpointType { get { return default(System.Type); } }
    [System.ComponentModel.TypeConverterAttribute(typeof(System.ComponentModel.TimeSpanConverter))]
    [System.Configuration.ConfigurationPropertyAttribute("maxAnnouncementDelay", DefaultValue="00:00:00")]
    public System.TimeSpan MaxAnnouncementDelay { get { return default(System.TimeSpan); } set { } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
    protected internal override System.ServiceModel.Description.ServiceEndpoint CreateServiceEndpoint(System.ServiceModel.Description.ContractDescription contractDescription) { return default(System.ServiceModel.Description.ServiceEndpoint); }
    protected internal override void InitializeFrom(System.ServiceModel.Description.ServiceEndpoint endpoint) { }
    protected override void OnApplyConfiguration(System.ServiceModel.Description.ServiceEndpoint endpoint, System.ServiceModel.Configuration.ChannelEndpointElement serviceEndpointElement) { }
    protected override void OnApplyConfiguration(System.ServiceModel.Description.ServiceEndpoint endpoint, System.ServiceModel.Configuration.ServiceEndpointElement serviceEndpointElement) { }
    protected override void OnInitializeAndValidate(System.ServiceModel.Configuration.ChannelEndpointElement channelEndpointElement) { }
    protected override void OnInitializeAndValidate(System.ServiceModel.Configuration.ServiceEndpointElement serviceEndpointElement) { }
  }
  public sealed partial class ContractTypeNameElement : System.Configuration.ConfigurationElement {
    public ContractTypeNameElement() { }
    public ContractTypeNameElement(string name, string ns) { }
    [System.Configuration.ConfigurationPropertyAttribute("name", Options=(System.Configuration.ConfigurationPropertyOptions)(6))]
    [System.Configuration.StringValidatorAttribute(MinLength=0)]
    public string Name { get { return default(string); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("namespace", DefaultValue="http://tempuri.org/", Options=(System.Configuration.ConfigurationPropertyOptions)(4))]
    public string Namespace { get { return default(string); } set { } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
  }
  [System.Configuration.ConfigurationCollectionAttribute(typeof(System.ServiceModel.Discovery.Configuration.ContractTypeNameElement))]
  public sealed partial class ContractTypeNameElementCollection : System.ServiceModel.Configuration.ServiceModelConfigurationElementCollection<System.ServiceModel.Discovery.Configuration.ContractTypeNameElement> {
    public ContractTypeNameElementCollection() { }
    protected override object GetElementKey(System.Configuration.ConfigurationElement element) { return default(object); }
  }
  public sealed partial class DiscoveryClientElement : System.ServiceModel.Configuration.BindingElementExtensionElement {
    public DiscoveryClientElement() { }
    public override System.Type BindingElementType { get { return default(System.Type); } }
    [System.Configuration.ConfigurationPropertyAttribute("endpoint")]
    public System.ServiceModel.Configuration.ChannelEndpointElement DiscoveryEndpoint { get { return default(System.ServiceModel.Configuration.ChannelEndpointElement); } }
    [System.Configuration.ConfigurationPropertyAttribute("findCriteria")]
    public System.ServiceModel.Discovery.Configuration.FindCriteriaElement FindCriteria { get { return default(System.ServiceModel.Discovery.Configuration.FindCriteriaElement); } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
    public override void ApplyConfiguration(System.ServiceModel.Channels.BindingElement bindingElement) { }
    public override void CopyFrom(System.ServiceModel.Configuration.ServiceModelExtensionElement from) { }
    protected internal override System.ServiceModel.Channels.BindingElement CreateBindingElement() { return default(System.ServiceModel.Channels.BindingElement); }
    protected internal override void InitializeFrom(System.ServiceModel.Channels.BindingElement bindingElement) { }
  }
  public sealed partial class DiscoveryClientSettingsElement : System.Configuration.ConfigurationElement {
    public DiscoveryClientSettingsElement() { }
    [System.Configuration.ConfigurationPropertyAttribute("endpoint")]
    public System.ServiceModel.Configuration.ChannelEndpointElement DiscoveryEndpoint { get { return default(System.ServiceModel.Configuration.ChannelEndpointElement); } }
    [System.Configuration.ConfigurationPropertyAttribute("findCriteria")]
    public System.ServiceModel.Discovery.Configuration.FindCriteriaElement FindCriteria { get { return default(System.ServiceModel.Discovery.Configuration.FindCriteriaElement); } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
  }
  public partial class DiscoveryEndpointCollectionElement : System.ServiceModel.Configuration.StandardEndpointCollectionElement<System.ServiceModel.Discovery.DiscoveryEndpoint, System.ServiceModel.Discovery.Configuration.DiscoveryEndpointElement> {
    public DiscoveryEndpointCollectionElement() { }
  }
  public partial class DiscoveryEndpointElement : System.ServiceModel.Configuration.StandardEndpointElement {
    public DiscoveryEndpointElement() { }
    [System.Configuration.ConfigurationPropertyAttribute("discoveryMode", DefaultValue=(System.ServiceModel.Discovery.ServiceDiscoveryMode)(1))]
    public System.ServiceModel.Discovery.ServiceDiscoveryMode DiscoveryMode { get { return default(System.ServiceModel.Discovery.ServiceDiscoveryMode); } set { } }
    [System.ComponentModel.TypeConverterAttribute(typeof(System.ServiceModel.Discovery.Configuration.DiscoveryVersionConverter))]
    [System.Configuration.ConfigurationPropertyAttribute("discoveryVersion", DefaultValue="WSDiscovery11")]
    public System.ServiceModel.Discovery.DiscoveryVersion DiscoveryVersion { get { return default(System.ServiceModel.Discovery.DiscoveryVersion); } set { } }
    protected internal override System.Type EndpointType { get { return default(System.Type); } }
    [System.ComponentModel.TypeConverterAttribute(typeof(System.ComponentModel.TimeSpanConverter))]
    [System.Configuration.ConfigurationPropertyAttribute("maxResponseDelay", DefaultValue="00:00:00")]
    public System.TimeSpan MaxResponseDelay { get { return default(System.TimeSpan); } set { } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
    protected internal override System.ServiceModel.Description.ServiceEndpoint CreateServiceEndpoint(System.ServiceModel.Description.ContractDescription contractDescription) { return default(System.ServiceModel.Description.ServiceEndpoint); }
    protected internal override void InitializeFrom(System.ServiceModel.Description.ServiceEndpoint endpoint) { }
    protected override void OnApplyConfiguration(System.ServiceModel.Description.ServiceEndpoint endpoint, System.ServiceModel.Configuration.ChannelEndpointElement serviceEndpointElement) { }
    protected override void OnApplyConfiguration(System.ServiceModel.Description.ServiceEndpoint endpoint, System.ServiceModel.Configuration.ServiceEndpointElement serviceEndpointElement) { }
    protected override void OnInitializeAndValidate(System.ServiceModel.Configuration.ChannelEndpointElement channelEndpointElement) { }
    protected override void OnInitializeAndValidate(System.ServiceModel.Configuration.ServiceEndpointElement channelEndpointElement) { }
  }
  public partial class DiscoveryVersionConverter : System.ComponentModel.TypeConverter {
    public DiscoveryVersionConverter() { }
    public override bool CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType) { return default(bool); }
    public override bool CanConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Type destinationType) { return default(bool); }
    public override object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value) { return default(object); }
    public override object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType) { return default(object); }
  }
  public partial class DynamicEndpointCollectionElement : System.ServiceModel.Configuration.StandardEndpointCollectionElement<System.ServiceModel.Discovery.DynamicEndpoint, System.ServiceModel.Discovery.Configuration.DynamicEndpointElement> {
    public DynamicEndpointCollectionElement() { }
  }
  public sealed partial class DynamicEndpointElement : System.ServiceModel.Configuration.StandardEndpointElement {
    public DynamicEndpointElement() { }
    [System.Configuration.ConfigurationPropertyAttribute("discoveryClientSettings")]
    public System.ServiceModel.Discovery.Configuration.DiscoveryClientSettingsElement DiscoveryClientSettings { get { return default(System.ServiceModel.Discovery.Configuration.DiscoveryClientSettingsElement); } }
    protected internal override System.Type EndpointType { get { return default(System.Type); } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
    protected internal override System.ServiceModel.Description.ServiceEndpoint CreateServiceEndpoint(System.ServiceModel.Description.ContractDescription contractDescription) { return default(System.ServiceModel.Description.ServiceEndpoint); }
    protected override void OnApplyConfiguration(System.ServiceModel.Description.ServiceEndpoint endpoint, System.ServiceModel.Configuration.ChannelEndpointElement serviceEndpointElement) { }
    protected override void OnApplyConfiguration(System.ServiceModel.Description.ServiceEndpoint endpoint, System.ServiceModel.Configuration.ServiceEndpointElement serviceEndpointElement) { }
    protected override void OnInitializeAndValidate(System.ServiceModel.Configuration.ChannelEndpointElement channelEndpointElement) { }
    protected override void OnInitializeAndValidate(System.ServiceModel.Configuration.ServiceEndpointElement serviceEndpointElement) { }
  }
  public sealed partial class EndpointDiscoveryElement : System.ServiceModel.Configuration.BehaviorExtensionElement {
    public EndpointDiscoveryElement() { }
    public override System.Type BehaviorType { get { return default(System.Type); } }
    [System.Configuration.ConfigurationPropertyAttribute("types")]
    public System.ServiceModel.Discovery.Configuration.ContractTypeNameElementCollection ContractTypeNames { get { return default(System.ServiceModel.Discovery.Configuration.ContractTypeNameElementCollection); } }
    [System.Configuration.ConfigurationPropertyAttribute("enabled", DefaultValue=true)]
    public bool Enabled { get { return default(bool); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("extensions")]
    public System.ServiceModel.Configuration.XmlElementElementCollection Extensions { get { return default(System.ServiceModel.Configuration.XmlElementElementCollection); } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
    [System.Configuration.ConfigurationPropertyAttribute("scopes")]
    public System.ServiceModel.Discovery.Configuration.ScopeElementCollection Scopes { get { return default(System.ServiceModel.Discovery.Configuration.ScopeElementCollection); } }
    protected internal override object CreateBehavior() { return default(object); }
  }
  public sealed partial class FindCriteriaElement : System.Configuration.ConfigurationElement {
    public FindCriteriaElement() { }
    [System.Configuration.ConfigurationPropertyAttribute("types")]
    public System.ServiceModel.Discovery.Configuration.ContractTypeNameElementCollection ContractTypeNames { get { return default(System.ServiceModel.Discovery.Configuration.ContractTypeNameElementCollection); } }
    [System.ComponentModel.TypeConverterAttribute(typeof(System.ComponentModel.TimeSpanConverter))]
    [System.Configuration.ConfigurationPropertyAttribute("duration", DefaultValue="00:00:20")]
    public System.TimeSpan Duration { get { return default(System.TimeSpan); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("extensions")]
    public System.ServiceModel.Configuration.XmlElementElementCollection Extensions { get { return default(System.ServiceModel.Configuration.XmlElementElementCollection); } }
    [System.Configuration.ConfigurationPropertyAttribute("maxResults", DefaultValue=0)]
    [System.Configuration.IntegerValidatorAttribute(MinValue=0, MaxValue=2147483647)]
    public int MaxResults { get { return default(int); } set { } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
    [System.Configuration.ConfigurationPropertyAttribute("scopeMatchBy")]
    public System.Uri ScopeMatchBy { get { return default(System.Uri); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("scopes")]
    public System.ServiceModel.Discovery.Configuration.ScopeElementCollection Scopes { get { return default(System.ServiceModel.Discovery.Configuration.ScopeElementCollection); } }
  }
  public sealed partial class ScopeElement : System.Configuration.ConfigurationElement {
    public ScopeElement() { }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
    [System.Configuration.CallbackValidatorAttribute(CallbackMethodName="ScopeValidatorCallback", Type=typeof(System.ServiceModel.Discovery.Configuration.ScopeElement))]
    [System.Configuration.ConfigurationPropertyAttribute("scope", Options=(System.Configuration.ConfigurationPropertyOptions)(6))]
    [System.MonoTODOAttribute]
    public System.Uri Scope { get { return default(System.Uri); } set { } }
  }
  [System.Configuration.ConfigurationCollectionAttribute(typeof(System.ServiceModel.Discovery.Configuration.ScopeElement))]
  public sealed partial class ScopeElementCollection : System.ServiceModel.Configuration.ServiceModelConfigurationElementCollection<System.ServiceModel.Discovery.Configuration.ScopeElement> {
    public ScopeElementCollection() { }
    protected override object GetElementKey(System.Configuration.ConfigurationElement element) { return default(object); }
  }
  public sealed partial class ServiceDiscoveryElement : System.ServiceModel.Configuration.BehaviorExtensionElement {
    public ServiceDiscoveryElement() { }
    [System.Configuration.ConfigurationPropertyAttribute("announcementEndpoints")]
    public System.ServiceModel.Discovery.Configuration.AnnouncementChannelEndpointElementCollection AnnouncementEndpoints { get { return default(System.ServiceModel.Discovery.Configuration.AnnouncementChannelEndpointElementCollection); } }
    public override System.Type BehaviorType { get { return default(System.Type); } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
    protected internal override object CreateBehavior() { return default(object); }
  }
  public partial class UdpAnnouncementEndpointCollectionElement : System.ServiceModel.Configuration.StandardEndpointCollectionElement<System.ServiceModel.Discovery.UdpAnnouncementEndpoint, System.ServiceModel.Discovery.Configuration.UdpAnnouncementEndpointElement> {
    public UdpAnnouncementEndpointCollectionElement() { }
  }
  public partial class UdpAnnouncementEndpointElement : System.ServiceModel.Discovery.Configuration.AnnouncementEndpointElement {
    public UdpAnnouncementEndpointElement() { }
    protected internal override System.Type EndpointType { get { return default(System.Type); } }
    [System.ComponentModel.TypeConverterAttribute(typeof(System.ComponentModel.TimeSpanConverter))]
    [System.Configuration.ConfigurationPropertyAttribute("maxAnnouncementDelay", DefaultValue="00:00:00.500")]
    public new System.TimeSpan MaxAnnouncementDelay { get { return default(System.TimeSpan); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("multicastAddress", DefaultValue="soap.udp://239.255.255.250:3702")]
    public System.Uri MulticastAddress { get { return default(System.Uri); } set { } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
    [System.Configuration.ConfigurationPropertyAttribute("transportSettings")]
    public System.ServiceModel.Discovery.Configuration.UdpTransportSettingsElement TransportSettings { get { return default(System.ServiceModel.Discovery.Configuration.UdpTransportSettingsElement); } }
    protected internal override System.ServiceModel.Description.ServiceEndpoint CreateServiceEndpoint(System.ServiceModel.Description.ContractDescription contractDescription) { return default(System.ServiceModel.Description.ServiceEndpoint); }
    protected internal override void InitializeFrom(System.ServiceModel.Description.ServiceEndpoint endpoint) { }
    protected override void OnApplyConfiguration(System.ServiceModel.Description.ServiceEndpoint endpoint, System.ServiceModel.Configuration.ChannelEndpointElement serviceEndpointElement) { }
    protected override void OnApplyConfiguration(System.ServiceModel.Description.ServiceEndpoint endpoint, System.ServiceModel.Configuration.ServiceEndpointElement serviceEndpointElement) { }
    protected override void OnInitializeAndValidate(System.ServiceModel.Configuration.ChannelEndpointElement channelEndpointElement) { }
    protected override void OnInitializeAndValidate(System.ServiceModel.Configuration.ServiceEndpointElement channelEndpointElement) { }
  }
  public partial class UdpDiscoveryEndpointCollectionElement : System.ServiceModel.Configuration.StandardEndpointCollectionElement<System.ServiceModel.Discovery.UdpDiscoveryEndpoint, System.ServiceModel.Discovery.Configuration.UdpDiscoveryEndpointElement> {
    public UdpDiscoveryEndpointCollectionElement() { }
  }
  public partial class UdpDiscoveryEndpointElement : System.ServiceModel.Discovery.Configuration.DiscoveryEndpointElement {
    public UdpDiscoveryEndpointElement() { }
    [System.Configuration.ConfigurationPropertyAttribute("discoveryMode", DefaultValue=(System.ServiceModel.Discovery.ServiceDiscoveryMode)(0))]
    public new System.ServiceModel.Discovery.ServiceDiscoveryMode DiscoveryMode { get { return default(System.ServiceModel.Discovery.ServiceDiscoveryMode); } set { } }
    protected internal override System.Type EndpointType { get { return default(System.Type); } }
    [System.ComponentModel.TypeConverterAttribute(typeof(System.ComponentModel.TimeSpanConverter))]
    [System.Configuration.ConfigurationPropertyAttribute("maxResponseDelay", DefaultValue="00:00:00.500")]
    public new System.TimeSpan MaxResponseDelay { get { return default(System.TimeSpan); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("multicastAddress", DefaultValue="soap.udp://239.255.255.250:3702")]
    public System.Uri MulticastAddress { get { return default(System.Uri); } set { } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
    [System.Configuration.ConfigurationPropertyAttribute("transportSettings")]
    public System.ServiceModel.Discovery.Configuration.UdpTransportSettingsElement TransportSettings { get { return default(System.ServiceModel.Discovery.Configuration.UdpTransportSettingsElement); } }
    protected internal override System.ServiceModel.Description.ServiceEndpoint CreateServiceEndpoint(System.ServiceModel.Description.ContractDescription contractDescription) { return default(System.ServiceModel.Description.ServiceEndpoint); }
    protected internal override void InitializeFrom(System.ServiceModel.Description.ServiceEndpoint endpoint) { }
    protected override void OnApplyConfiguration(System.ServiceModel.Description.ServiceEndpoint endpoint, System.ServiceModel.Configuration.ChannelEndpointElement serviceEndpointElement) { }
    protected override void OnApplyConfiguration(System.ServiceModel.Description.ServiceEndpoint endpoint, System.ServiceModel.Configuration.ServiceEndpointElement serviceEndpointElement) { }
    protected override void OnInitializeAndValidate(System.ServiceModel.Configuration.ChannelEndpointElement channelEndpointElement) { }
    protected override void OnInitializeAndValidate(System.ServiceModel.Configuration.ServiceEndpointElement channelEndpointElement) { }
  }
  public sealed partial class UdpTransportSettingsElement : System.Configuration.ConfigurationElement {
    public UdpTransportSettingsElement() { }
    [System.Configuration.ConfigurationPropertyAttribute("duplicateMessageHistoryLength", DefaultValue=4112)]
    [System.Configuration.IntegerValidatorAttribute(MinValue=0, MaxValue=2147483647)]
    public int DuplicateMessageHistoryLength { get { return default(int); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("maxBufferPoolSize", DefaultValue=524288)]
    [System.Configuration.LongValidatorAttribute(MinValue=(long)0, MaxValue=(long)9223372036854775807)]
    public long MaxBufferPoolSize { get { return default(long); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("maxMulticastRetransmitCount", DefaultValue=2)]
    [System.Configuration.IntegerValidatorAttribute(MinValue=0, MaxValue=2147483647)]
    public int MaxMulticastRetransmitCount { get { return default(int); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("maxPendingMessageCount", DefaultValue=32)]
    [System.Configuration.IntegerValidatorAttribute(MinValue=0, MaxValue=2147483647)]
    public int MaxPendingMessageCount { get { return default(int); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("maxReceivedMessageSize", DefaultValue=65511)]
    [System.Configuration.LongValidatorAttribute(MinValue=(long)0, MaxValue=(long)9223372036854775807)]
    public long MaxReceivedMessageSize { get { return default(long); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("maxUnicastRetransmitCount", DefaultValue=1)]
    [System.Configuration.IntegerValidatorAttribute(MinValue=0, MaxValue=2147483647)]
    public int MaxUnicastRetransmitCount { get { return default(int); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("multicastInterfaceId")]
    public string MulticastInterfaceId { get { return default(string); } set { } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
    [System.Configuration.ConfigurationPropertyAttribute("socketReceiveBufferSize", DefaultValue=65536)]
    [System.Configuration.IntegerValidatorAttribute(MinValue=0, MaxValue=2147483647)]
    public int SocketReceiveBufferSize { get { return default(int); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("timeToLive", DefaultValue=1)]
    [System.Configuration.IntegerValidatorAttribute(MinValue=0, MaxValue=2147483647)]
    public int TimeToLive { get { return default(int); } set { } }
  }
}
namespace System.ServiceModel.Discovery.Version11 {
  [System.Xml.Serialization.XmlSchemaProviderAttribute("GetSchema")]
  public partial class DiscoveryMessageSequence11 : System.Xml.Serialization.IXmlSerializable {
    internal DiscoveryMessageSequence11() { }
    public static System.ServiceModel.Discovery.Version11.DiscoveryMessageSequence11 FromDiscoveryMessageSequence(System.ServiceModel.Discovery.DiscoveryMessageSequence discoveryMessageSequence) { return default(System.ServiceModel.Discovery.Version11.DiscoveryMessageSequence11); }
    public System.Xml.Schema.XmlSchema GetSchema() { return default(System.Xml.Schema.XmlSchema); }
    public static System.Xml.XmlQualifiedName GetSchema(System.Xml.Schema.XmlSchemaSet schemaSet) { return default(System.Xml.XmlQualifiedName); }
    public void ReadXml(System.Xml.XmlReader reader) { }
    public System.ServiceModel.Discovery.DiscoveryMessageSequence ToDiscoveryMessageSequence() { return default(System.ServiceModel.Discovery.DiscoveryMessageSequence); }
    public void WriteXml(System.Xml.XmlWriter writer) { }
  }
  [System.Xml.Serialization.XmlSchemaProviderAttribute("GetSchema")]
  public partial class EndpointDiscoveryMetadata11 : System.Xml.Serialization.IXmlSerializable {
    internal EndpointDiscoveryMetadata11() { }
    public static System.ServiceModel.Discovery.Version11.EndpointDiscoveryMetadata11 FromEndpointDiscoveryMetadata(System.ServiceModel.Discovery.EndpointDiscoveryMetadata endpointDiscoveryMetadata) { return default(System.ServiceModel.Discovery.Version11.EndpointDiscoveryMetadata11); }
    public System.Xml.Schema.XmlSchema GetSchema() { return default(System.Xml.Schema.XmlSchema); }
    public static System.Xml.XmlQualifiedName GetSchema(System.Xml.Schema.XmlSchemaSet schemaSet) { return default(System.Xml.XmlQualifiedName); }
    public void ReadXml(System.Xml.XmlReader reader) { }
    public System.ServiceModel.Discovery.EndpointDiscoveryMetadata ToEndpointDiscoveryMetadata() { return default(System.ServiceModel.Discovery.EndpointDiscoveryMetadata); }
    public void WriteXml(System.Xml.XmlWriter writer) { }
  }
  [System.Xml.Serialization.XmlSchemaProviderAttribute("GetSchema")]
  public partial class FindCriteria11 : System.Xml.Serialization.IXmlSerializable {
    internal FindCriteria11() { }
    public static System.ServiceModel.Discovery.Version11.FindCriteria11 FromFindCriteria(System.ServiceModel.Discovery.FindCriteria findCriteria) { return default(System.ServiceModel.Discovery.Version11.FindCriteria11); }
    public System.Xml.Schema.XmlSchema GetSchema() { return default(System.Xml.Schema.XmlSchema); }
    public static System.Xml.XmlQualifiedName GetSchema(System.Xml.Schema.XmlSchemaSet schemaSet) { return default(System.Xml.XmlQualifiedName); }
    public void ReadXml(System.Xml.XmlReader reader) { }
    public System.ServiceModel.Discovery.FindCriteria ToFindCriteria() { return default(System.ServiceModel.Discovery.FindCriteria); }
    public void WriteXml(System.Xml.XmlWriter writer) { }
  }
  [System.Xml.Serialization.XmlSchemaProviderAttribute("GetSchema")]
  public partial class ResolveCriteria11 : System.Xml.Serialization.IXmlSerializable {
    internal ResolveCriteria11() { }
    public static System.ServiceModel.Discovery.Version11.ResolveCriteria11 FromResolveCriteria(System.ServiceModel.Discovery.ResolveCriteria resolveCriteria) { return default(System.ServiceModel.Discovery.Version11.ResolveCriteria11); }
    public System.Xml.Schema.XmlSchema GetSchema() { return default(System.Xml.Schema.XmlSchema); }
    public static System.Xml.XmlQualifiedName GetSchema(System.Xml.Schema.XmlSchemaSet schemaSet) { return default(System.Xml.XmlQualifiedName); }
    public void ReadXml(System.Xml.XmlReader reader) { }
    public System.ServiceModel.Discovery.ResolveCriteria ToResolveCriteria() { return default(System.ServiceModel.Discovery.ResolveCriteria); }
    public void WriteXml(System.Xml.XmlWriter writer) { }
  }
}
namespace System.ServiceModel.Discovery.VersionApril2005 {
  [System.Xml.Serialization.XmlSchemaProviderAttribute("GetSchema")]
  public partial class DiscoveryMessageSequenceApril2005 : System.Xml.Serialization.IXmlSerializable {
    internal DiscoveryMessageSequenceApril2005() { }
    public static System.ServiceModel.Discovery.VersionApril2005.DiscoveryMessageSequenceApril2005 FromDiscoveryMessageSequence(System.ServiceModel.Discovery.DiscoveryMessageSequence discoveryMessageSequence) { return default(System.ServiceModel.Discovery.VersionApril2005.DiscoveryMessageSequenceApril2005); }
    public System.Xml.Schema.XmlSchema GetSchema() { return default(System.Xml.Schema.XmlSchema); }
    public static System.Xml.XmlQualifiedName GetSchema(System.Xml.Schema.XmlSchemaSet schemaSet) { return default(System.Xml.XmlQualifiedName); }
    public void ReadXml(System.Xml.XmlReader reader) { }
    public System.ServiceModel.Discovery.DiscoveryMessageSequence ToDiscoveryMessageSequence() { return default(System.ServiceModel.Discovery.DiscoveryMessageSequence); }
    public void WriteXml(System.Xml.XmlWriter writer) { }
  }
  [System.Xml.Serialization.XmlSchemaProviderAttribute("GetSchema")]
  public partial class EndpointDiscoveryMetadataApril2005 : System.Xml.Serialization.IXmlSerializable {
    internal EndpointDiscoveryMetadataApril2005() { }
    public static System.ServiceModel.Discovery.VersionApril2005.EndpointDiscoveryMetadataApril2005 FromEndpointDiscoveryMetadata(System.ServiceModel.Discovery.EndpointDiscoveryMetadata endpointDiscoveryMetadata) { return default(System.ServiceModel.Discovery.VersionApril2005.EndpointDiscoveryMetadataApril2005); }
    public System.Xml.Schema.XmlSchema GetSchema() { return default(System.Xml.Schema.XmlSchema); }
    public static System.Xml.XmlQualifiedName GetSchema(System.Xml.Schema.XmlSchemaSet schemaSet) { return default(System.Xml.XmlQualifiedName); }
    public void ReadXml(System.Xml.XmlReader reader) { }
    public System.ServiceModel.Discovery.EndpointDiscoveryMetadata ToEndpointDiscoveryMetadata() { return default(System.ServiceModel.Discovery.EndpointDiscoveryMetadata); }
    public void WriteXml(System.Xml.XmlWriter writer) { }
  }
  [System.Xml.Serialization.XmlSchemaProviderAttribute("GetSchema")]
  public partial class FindCriteriaApril2005 : System.Xml.Serialization.IXmlSerializable {
    internal FindCriteriaApril2005() { }
    public static System.ServiceModel.Discovery.VersionApril2005.FindCriteriaApril2005 FromFindCriteria(System.ServiceModel.Discovery.FindCriteria findCriteria) { return default(System.ServiceModel.Discovery.VersionApril2005.FindCriteriaApril2005); }
    public System.Xml.Schema.XmlSchema GetSchema() { return default(System.Xml.Schema.XmlSchema); }
    public static System.Xml.XmlQualifiedName GetSchema(System.Xml.Schema.XmlSchemaSet schemaSet) { return default(System.Xml.XmlQualifiedName); }
    public void ReadXml(System.Xml.XmlReader reader) { }
    public System.ServiceModel.Discovery.FindCriteria ToFindCriteria() { return default(System.ServiceModel.Discovery.FindCriteria); }
    public void WriteXml(System.Xml.XmlWriter writer) { }
  }
  [System.Xml.Serialization.XmlSchemaProviderAttribute("GetSchema")]
  public partial class ResolveCriteriaApril2005 : System.Xml.Serialization.IXmlSerializable {
    internal ResolveCriteriaApril2005() { }
    public static System.ServiceModel.Discovery.VersionApril2005.ResolveCriteriaApril2005 FromResolveCriteria(System.ServiceModel.Discovery.ResolveCriteria resolveCriteria) { return default(System.ServiceModel.Discovery.VersionApril2005.ResolveCriteriaApril2005); }
    public System.Xml.Schema.XmlSchema GetSchema() { return default(System.Xml.Schema.XmlSchema); }
    public static System.Xml.XmlQualifiedName GetSchema(System.Xml.Schema.XmlSchemaSet schemaSet) { return default(System.Xml.XmlQualifiedName); }
    public void ReadXml(System.Xml.XmlReader reader) { }
    public System.ServiceModel.Discovery.ResolveCriteria ToResolveCriteria() { return default(System.ServiceModel.Discovery.ResolveCriteria); }
    public void WriteXml(System.Xml.XmlWriter writer) { }
  }
}
namespace System.ServiceModel.Discovery.VersionCD1 {
  [System.Xml.Serialization.XmlSchemaProviderAttribute("GetSchema")]
  public partial class DiscoveryMessageSequenceCD1 : System.Xml.Serialization.IXmlSerializable {
    internal DiscoveryMessageSequenceCD1() { }
    public static System.ServiceModel.Discovery.VersionCD1.DiscoveryMessageSequenceCD1 FromDiscoveryMessageSequence(System.ServiceModel.Discovery.DiscoveryMessageSequence discoveryMessageSequence) { return default(System.ServiceModel.Discovery.VersionCD1.DiscoveryMessageSequenceCD1); }
    public System.Xml.Schema.XmlSchema GetSchema() { return default(System.Xml.Schema.XmlSchema); }
    public static System.Xml.XmlQualifiedName GetSchema(System.Xml.Schema.XmlSchemaSet schemaSet) { return default(System.Xml.XmlQualifiedName); }
    public void ReadXml(System.Xml.XmlReader reader) { }
    public System.ServiceModel.Discovery.DiscoveryMessageSequence ToDiscoveryMessageSequence() { return default(System.ServiceModel.Discovery.DiscoveryMessageSequence); }
    public void WriteXml(System.Xml.XmlWriter writer) { }
  }
  [System.Xml.Serialization.XmlSchemaProviderAttribute("GetSchema")]
  public partial class EndpointDiscoveryMetadataCD1 : System.Xml.Serialization.IXmlSerializable {
    internal EndpointDiscoveryMetadataCD1() { }
    public static System.ServiceModel.Discovery.VersionCD1.EndpointDiscoveryMetadataCD1 FromEndpointDiscoveryMetadata(System.ServiceModel.Discovery.EndpointDiscoveryMetadata endpointDiscoveryMetadata) { return default(System.ServiceModel.Discovery.VersionCD1.EndpointDiscoveryMetadataCD1); }
    public System.Xml.Schema.XmlSchema GetSchema() { return default(System.Xml.Schema.XmlSchema); }
    public static System.Xml.XmlQualifiedName GetSchema(System.Xml.Schema.XmlSchemaSet schemaSet) { return default(System.Xml.XmlQualifiedName); }
    public void ReadXml(System.Xml.XmlReader reader) { }
    public System.ServiceModel.Discovery.EndpointDiscoveryMetadata ToEndpointDiscoveryMetadata() { return default(System.ServiceModel.Discovery.EndpointDiscoveryMetadata); }
    public void WriteXml(System.Xml.XmlWriter writer) { }
  }
  [System.Xml.Serialization.XmlSchemaProviderAttribute("GetSchema")]
  public partial class FindCriteriaCD1 : System.Xml.Serialization.IXmlSerializable {
    internal FindCriteriaCD1() { }
    public static System.ServiceModel.Discovery.VersionCD1.FindCriteriaCD1 FromFindCriteria(System.ServiceModel.Discovery.FindCriteria findCriteria) { return default(System.ServiceModel.Discovery.VersionCD1.FindCriteriaCD1); }
    public System.Xml.Schema.XmlSchema GetSchema() { return default(System.Xml.Schema.XmlSchema); }
    public static System.Xml.XmlQualifiedName GetSchema(System.Xml.Schema.XmlSchemaSet schemaSet) { return default(System.Xml.XmlQualifiedName); }
    public void ReadXml(System.Xml.XmlReader reader) { }
    public System.ServiceModel.Discovery.FindCriteria ToFindCriteria() { return default(System.ServiceModel.Discovery.FindCriteria); }
    public void WriteXml(System.Xml.XmlWriter writer) { }
  }
  [System.Xml.Serialization.XmlSchemaProviderAttribute("GetSchema")]
  public partial class ResolveCriteriaCD1 : System.Xml.Serialization.IXmlSerializable {
    internal ResolveCriteriaCD1() { }
    public static System.ServiceModel.Discovery.VersionCD1.ResolveCriteriaCD1 FromResolveCriteria(System.ServiceModel.Discovery.ResolveCriteria resolveCriteria) { return default(System.ServiceModel.Discovery.VersionCD1.ResolveCriteriaCD1); }
    public System.Xml.Schema.XmlSchema GetSchema() { return default(System.Xml.Schema.XmlSchema); }
    public static System.Xml.XmlQualifiedName GetSchema(System.Xml.Schema.XmlSchemaSet schemaSet) { return default(System.Xml.XmlQualifiedName); }
    public void ReadXml(System.Xml.XmlReader reader) { }
    public System.ServiceModel.Discovery.ResolveCriteria ToResolveCriteria() { return default(System.ServiceModel.Discovery.ResolveCriteria); }
    public void WriteXml(System.Xml.XmlWriter writer) { }
  }
}
