namespace System {
  [System.Runtime.CompilerServices.TypeForwardedFromAttribute("System.ServiceModel.Web, Version=3.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35")]
  public partial class UriTemplate {
    public UriTemplate(string template) { }
    public UriTemplate(string template, bool ignoreTrailingSlash) { }
    public UriTemplate(string template, bool ignoreTrailingSlash, System.Collections.Generic.IDictionary<System.String, System.String> additionalDefaults) { }
    public UriTemplate(string template, System.Collections.Generic.IDictionary<System.String, System.String> additionalDefaults) { }
    public System.Collections.Generic.IDictionary<System.String, System.String> Defaults { get { return default(System.Collections.Generic.IDictionary<System.String, System.String>); } }
    public bool IgnoreTrailingSlash { get { return default(bool); } }
    public System.Collections.ObjectModel.ReadOnlyCollection<System.String> PathSegmentVariableNames { get { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.String>); } }
    public System.Collections.ObjectModel.ReadOnlyCollection<System.String> QueryValueVariableNames { get { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.String>); } }
    public System.Uri BindByName(System.Uri baseAddress, System.Collections.Generic.IDictionary<System.String, System.String> parameters) { return default(System.Uri); }
    public System.Uri BindByName(System.Uri baseAddress, System.Collections.Generic.IDictionary<System.String, System.String> parameters, bool omitDefaults) { return default(System.Uri); }
    public System.Uri BindByName(System.Uri baseAddress, System.Collections.Specialized.NameValueCollection parameters) { return default(System.Uri); }
    public System.Uri BindByName(System.Uri baseAddress, System.Collections.Specialized.NameValueCollection parameters, bool omitDefaults) { return default(System.Uri); }
    public System.Uri BindByPosition(System.Uri baseAddress, params System.String[] values) { return default(System.Uri); }
    public bool IsEquivalentTo(System.UriTemplate other) { return default(bool); }
    public System.UriTemplateMatch Match(System.Uri baseAddress, System.Uri candidate) { return default(System.UriTemplateMatch); }
    public override string ToString() { return default(string); }
  }
  [System.Runtime.CompilerServices.TypeForwardedFromAttribute("System.ServiceModel.Web, Version=3.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35")]
  public partial class UriTemplateEquivalenceComparer : System.Collections.Generic.IEqualityComparer<System.UriTemplate> {
    public UriTemplateEquivalenceComparer() { }
    public bool Equals(System.UriTemplate x, System.UriTemplate y) { return default(bool); }
    public int GetHashCode(System.UriTemplate obj) { return default(int); }
  }
  [System.Runtime.CompilerServices.TypeForwardedFromAttribute("System.ServiceModel.Web, Version=3.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35")]
  public partial class UriTemplateMatch {
    public UriTemplateMatch() { }
    public System.Uri BaseUri { get { return default(System.Uri); } set { } }
    public System.Collections.Specialized.NameValueCollection BoundVariables { get { return default(System.Collections.Specialized.NameValueCollection); } }
    public object Data { get { return default(object); } set { } }
    public System.Collections.Specialized.NameValueCollection QueryParameters { get { return default(System.Collections.Specialized.NameValueCollection); } }
    public System.Collections.ObjectModel.Collection<System.String> RelativePathSegments { get { return default(System.Collections.ObjectModel.Collection<System.String>); } }
    public System.Uri RequestUri { get { return default(System.Uri); } set { } }
    public System.UriTemplate Template { get { return default(System.UriTemplate); } set { } }
    public System.Collections.ObjectModel.Collection<System.String> WildcardPathSegments { get { return default(System.Collections.ObjectModel.Collection<System.String>); } }
  }
  [System.Runtime.CompilerServices.TypeForwardedFromAttribute("System.ServiceModel.Web, Version=3.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35")]
  public partial class UriTemplateMatchException : System.SystemException {
    public UriTemplateMatchException() { }
    protected UriTemplateMatchException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public UriTemplateMatchException(string message) { }
    public UriTemplateMatchException(string message, System.Exception innerException) { }
  }
  [System.Runtime.CompilerServices.TypeForwardedFromAttribute("System.ServiceModel.Web, Version=3.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35")]
  public partial class UriTemplateTable {
    public UriTemplateTable() { }
    public UriTemplateTable(System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.UriTemplate, System.Object>> keyValuePairs) { }
    public UriTemplateTable(System.Uri baseAddress) { }
    public UriTemplateTable(System.Uri baseAddress, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.UriTemplate, System.Object>> keyValuePairs) { }
    public System.Uri BaseAddress { get { return default(System.Uri); } set { } }
    public bool IsReadOnly { get { return default(bool); } }
    public System.Collections.Generic.IList<System.Collections.Generic.KeyValuePair<System.UriTemplate, System.Object>> KeyValuePairs { get { return default(System.Collections.Generic.IList<System.Collections.Generic.KeyValuePair<System.UriTemplate, System.Object>>); } }
    public System.Uri OriginalBaseAddress { get { return default(System.Uri); } }
    public void MakeReadOnly(bool allowDuplicateEquivalentUriTemplates) { }
    public System.Collections.ObjectModel.Collection<System.UriTemplateMatch> Match(System.Uri uri) { return default(System.Collections.ObjectModel.Collection<System.UriTemplateMatch>); }
    public System.UriTemplateMatch MatchSingle(System.Uri uri) { return default(System.UriTemplateMatch); }
  }
}
namespace System.Collections.Generic {
  public partial class KeyedByTypeCollection<TItem> : System.Collections.ObjectModel.KeyedCollection<System.Type, TItem> {
    public KeyedByTypeCollection() { }
    public KeyedByTypeCollection(System.Collections.Generic.IEnumerable<TItem> items) { }
    public T Find<T>() { return default(T); }
    public System.Collections.ObjectModel.Collection<T> FindAll<T>() { return default(System.Collections.ObjectModel.Collection<T>); }
    protected override System.Type GetKeyForItem(TItem item) { return default(System.Type); }
    protected override void InsertItem(int index, TItem item) { }
    public T Remove<T>() { return default(T); }
    public System.Collections.ObjectModel.Collection<T> RemoveAll<T>() { return default(System.Collections.ObjectModel.Collection<T>); }
    protected override void SetItem(int index, TItem item) { }
  }
  [System.Runtime.InteropServices.ComVisibleAttribute(false)]
  public partial class SynchronizedCollection<T> : System.Collections.Generic.ICollection<T>, System.Collections.Generic.IEnumerable<T>, System.Collections.Generic.IList<T>, System.Collections.ICollection, System.Collections.IEnumerable, System.Collections.IList {
    public SynchronizedCollection() { }
    public SynchronizedCollection(object syncRoot) { }
    public SynchronizedCollection(object syncRoot, params T[] list) { }
    public SynchronizedCollection(object syncRoot, System.Collections.Generic.IEnumerable<T> list) { }
    public int Count { get { return default(int); } }
    public T this[int index] { get { return default(T); } set { } }
    protected System.Collections.Generic.List<T> Items { get { return default(System.Collections.Generic.List<T>); } }
    public object SyncRoot { get { return default(object); } }
    bool System.Collections.Generic.ICollection<T>.IsReadOnly { get { return default(bool); } }
    bool System.Collections.ICollection.IsSynchronized { get { return default(bool); } }
    object System.Collections.ICollection.SyncRoot { get { return default(object); } }
    bool System.Collections.IList.IsFixedSize { get { return default(bool); } }
    bool System.Collections.IList.IsReadOnly { get { return default(bool); } }
    object System.Collections.IList.this[int index] { get { return default(object); } set { } }
    public void Add(T item) { }
    public void Clear() { }
    protected virtual void ClearItems() { }
    public bool Contains(T item) { return default(bool); }
    public void CopyTo(T[] array, int index) { }
    public System.Collections.Generic.IEnumerator<T> GetEnumerator() { return default(System.Collections.Generic.IEnumerator<T>); }
    public int IndexOf(T item) { return default(int); }
    public void Insert(int index, T item) { }
    protected virtual void InsertItem(int index, T item) { }
    public bool Remove(T item) { return default(bool); }
    public void RemoveAt(int index) { }
    protected virtual void RemoveItem(int index) { }
    protected virtual void SetItem(int index, T item) { }
    void System.Collections.ICollection.CopyTo(System.Array array, int index) { }
    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { return default(System.Collections.IEnumerator); }
    int System.Collections.IList.Add(object value) { return default(int); }
    bool System.Collections.IList.Contains(object value) { return default(bool); }
    int System.Collections.IList.IndexOf(object value) { return default(int); }
    void System.Collections.IList.Insert(int index, object value) { }
    void System.Collections.IList.Remove(object value) { }
  }
  [System.Runtime.InteropServices.ComVisibleAttribute(false)]
  public abstract partial class SynchronizedKeyedCollection<K, T> : System.Collections.Generic.SynchronizedCollection<T> {
    protected SynchronizedKeyedCollection() { }
    protected SynchronizedKeyedCollection(object syncRoot) { }
    protected SynchronizedKeyedCollection(object syncRoot, System.Collections.Generic.IEqualityComparer<K> comparer) { }
    protected SynchronizedKeyedCollection(object syncRoot, System.Collections.Generic.IEqualityComparer<K> comparer, int dictionaryCreationThreshold) { }
    protected System.Collections.Generic.IDictionary<K, T> Dictionary { get { return default(System.Collections.Generic.IDictionary<K, T>); } }
    public T this[K key] { get { return default(T); } }
    protected void ChangeItemKey(T item, K newKey) { }
    protected override void ClearItems() { }
    public bool Contains(K key) { return default(bool); }
    protected abstract K GetKeyForItem(T item);
    protected override void InsertItem(int index, T item) { }
    public bool Remove(K key) { return default(bool); }
    protected override void RemoveItem(int index) { }
    protected override void SetItem(int index, T item) { }
  }
  [System.Runtime.InteropServices.ComVisibleAttribute(false)]
  public partial class SynchronizedReadOnlyCollection<T> : System.Collections.Generic.ICollection<T>, System.Collections.Generic.IEnumerable<T>, System.Collections.Generic.IList<T>, System.Collections.ICollection, System.Collections.IEnumerable, System.Collections.IList {
    public SynchronizedReadOnlyCollection() { }
    public SynchronizedReadOnlyCollection(object syncRoot) { }
    public SynchronizedReadOnlyCollection(object syncRoot, params T[] list) { }
    public SynchronizedReadOnlyCollection(object syncRoot, System.Collections.Generic.IEnumerable<T> list) { }
    public int Count { get { return default(int); } }
    public T this[int index] { get { return default(T); } }
    protected System.Collections.Generic.IList<T> Items { get { return default(System.Collections.Generic.IList<T>); } }
    bool System.Collections.Generic.ICollection<T>.IsReadOnly { get { return default(bool); } }
    T System.Collections.Generic.IList<T>.this[int index] { get { return default(T); } set { } }
    bool System.Collections.ICollection.IsSynchronized { get { return default(bool); } }
    object System.Collections.ICollection.SyncRoot { get { return default(object); } }
    bool System.Collections.IList.IsFixedSize { get { return default(bool); } }
    bool System.Collections.IList.IsReadOnly { get { return default(bool); } }
    object System.Collections.IList.this[int index] { get { return default(object); } set { } }
    public bool Contains(T value) { return default(bool); }
    public void CopyTo(T[] array, int index) { }
    public System.Collections.Generic.IEnumerator<T> GetEnumerator() { return default(System.Collections.Generic.IEnumerator<T>); }
    public int IndexOf(T value) { return default(int); }
    void System.Collections.Generic.ICollection<T>.Add(T value) { }
    void System.Collections.Generic.ICollection<T>.Clear() { }
    bool System.Collections.Generic.ICollection<T>.Remove(T value) { return default(bool); }
    void System.Collections.Generic.IList<T>.Insert(int index, T value) { }
    void System.Collections.Generic.IList<T>.RemoveAt(int index) { }
    void System.Collections.ICollection.CopyTo(System.Array array, int index) { }
    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { return default(System.Collections.IEnumerator); }
    int System.Collections.IList.Add(object value) { return default(int); }
    void System.Collections.IList.Clear() { }
    bool System.Collections.IList.Contains(object value) { return default(bool); }
    int System.Collections.IList.IndexOf(object value) { return default(int); }
    void System.Collections.IList.Insert(int index, object value) { }
    void System.Collections.IList.Remove(object value) { }
    void System.Collections.IList.RemoveAt(int index) { }
  }
}
namespace System.IO {
  public partial class PipeException : System.IO.IOException {
    public PipeException() { }
    protected PipeException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public PipeException(string message) { }
    public PipeException(string message, System.Exception inner) { }
    public PipeException(string message, int errorCode) { }
    public virtual int ErrorCode { get { return default(int); } }
  }
}
namespace System.ServiceModel {
  public partial class ActionNotSupportedException : System.ServiceModel.CommunicationException {
    public ActionNotSupportedException() { }
    protected ActionNotSupportedException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public ActionNotSupportedException(string message) { }
    public ActionNotSupportedException(string message, System.Exception innerException) { }
  }
  public partial class AddressAccessDeniedException : System.ServiceModel.CommunicationException {
    public AddressAccessDeniedException() { }
    protected AddressAccessDeniedException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public AddressAccessDeniedException(string message) { }
    public AddressAccessDeniedException(string message, System.Exception innerException) { }
  }
  public partial class AddressAlreadyInUseException : System.ServiceModel.CommunicationException {
    public AddressAlreadyInUseException() { }
    protected AddressAlreadyInUseException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public AddressAlreadyInUseException(string message) { }
    public AddressAlreadyInUseException(string message, System.Exception innerException) { }
  }
  public enum AddressFilterMode {
    Any = 2,
    Exact = 0,
    Prefix = 1,
  }
  public enum AuditLevel {
    Failure = 2,
    None = 0,
    Success = 1,
    SuccessOrFailure = 3,
  }
  public enum AuditLogLocation {
    Application = 1,
    Default = 0,
    Security = 2,
  }
  public partial class BasicHttpBinding : System.ServiceModel.HttpBindingBase {
    public BasicHttpBinding() { }
    public BasicHttpBinding(System.ServiceModel.BasicHttpSecurityMode securityMode) { }
    public BasicHttpBinding(string configurationName) { }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.ObsoleteAttribute("This property is obsolete. To enable Http CookieContainer, use the AllowCookies property instead.", false)]
    public bool EnableHttpCookieContainer { get { return default(bool); } set { } }
    [System.ComponentModel.DefaultValueAttribute((System.ServiceModel.WSMessageEncoding)(0))]
    public System.ServiceModel.WSMessageEncoding MessageEncoding { get { return default(System.ServiceModel.WSMessageEncoding); } set { } }
    public System.ServiceModel.BasicHttpSecurity Security { get { return default(System.ServiceModel.BasicHttpSecurity); } set { } }
    public override System.ServiceModel.Channels.IChannelFactory<TChannel> BuildChannelFactory<TChannel>(System.ServiceModel.Channels.BindingParameterCollection parameters) { return default(System.ServiceModel.Channels.IChannelFactory<TChannel>); }
    public override System.ServiceModel.Channels.BindingElementCollection CreateBindingElements() { return default(System.ServiceModel.Channels.BindingElementCollection); }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public bool ShouldSerializeEnableHttpCookieContainer() { return default(bool); }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public bool ShouldSerializeSecurity() { return default(bool); }
  }
  [System.Runtime.CompilerServices.TypeForwardedFromAttribute("System.WorkflowServices, Version=3.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35")]
  public partial class BasicHttpContextBinding : System.ServiceModel.BasicHttpBinding {
    public BasicHttpContextBinding() { }
    public BasicHttpContextBinding(System.ServiceModel.BasicHttpSecurityMode securityMode) { }
    public BasicHttpContextBinding(string configName) { }
    [System.ComponentModel.DefaultValueAttribute(true)]
    public bool ContextManagementEnabled { get { return default(bool); } set { } }
    public override System.ServiceModel.Channels.BindingElementCollection CreateBindingElements() { return default(System.ServiceModel.Channels.BindingElementCollection); }
  }
  public enum BasicHttpMessageCredentialType {
    Certificate = 1,
    UserName = 0,
  }
  public sealed partial class BasicHttpMessageSecurity {
    public BasicHttpMessageSecurity() { }
    public System.ServiceModel.Security.SecurityAlgorithmSuite AlgorithmSuite { get { return default(System.ServiceModel.Security.SecurityAlgorithmSuite); } set { } }
    public System.ServiceModel.BasicHttpMessageCredentialType ClientCredentialType { get { return default(System.ServiceModel.BasicHttpMessageCredentialType); } set { } }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public bool ShouldSerializeAlgorithmSuite() { return default(bool); }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public bool ShouldSerializeClientCredentialType() { return default(bool); }
  }
  public partial class BasicHttpsBinding : System.ServiceModel.HttpBindingBase {
    public BasicHttpsBinding() { }
    public BasicHttpsBinding(System.ServiceModel.BasicHttpsSecurityMode securityMode) { }
    public BasicHttpsBinding(string configurationName) { }
    [System.ComponentModel.DefaultValueAttribute((System.ServiceModel.WSMessageEncoding)(0))]
    public System.ServiceModel.WSMessageEncoding MessageEncoding { get { return default(System.ServiceModel.WSMessageEncoding); } set { } }
    public System.ServiceModel.BasicHttpsSecurity Security { get { return default(System.ServiceModel.BasicHttpsSecurity); } set { } }
    public override System.ServiceModel.Channels.IChannelFactory<TChannel> BuildChannelFactory<TChannel>(System.ServiceModel.Channels.BindingParameterCollection parameters) { return default(System.ServiceModel.Channels.IChannelFactory<TChannel>); }
    public override System.ServiceModel.Channels.BindingElementCollection CreateBindingElements() { return default(System.ServiceModel.Channels.BindingElementCollection); }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public bool ShouldSerializeSecurity() { return default(bool); }
  }
  public sealed partial class BasicHttpSecurity {
    public BasicHttpSecurity() { }
    public System.ServiceModel.BasicHttpMessageSecurity Message { get { return default(System.ServiceModel.BasicHttpMessageSecurity); } set { } }
    public System.ServiceModel.BasicHttpSecurityMode Mode { get { return default(System.ServiceModel.BasicHttpSecurityMode); } set { } }
    public System.ServiceModel.HttpTransportSecurity Transport { get { return default(System.ServiceModel.HttpTransportSecurity); } set { } }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public bool ShouldSerializeMessage() { return default(bool); }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public bool ShouldSerializeTransport() { return default(bool); }
  }
  public enum BasicHttpSecurityMode {
    Message = 2,
    None = 0,
    Transport = 1,
    TransportCredentialOnly = 4,
    TransportWithMessageCredential = 3,
  }
  public sealed partial class BasicHttpsSecurity {
    public BasicHttpsSecurity() { }
    public System.ServiceModel.BasicHttpMessageSecurity Message { get { return default(System.ServiceModel.BasicHttpMessageSecurity); } set { } }
    public System.ServiceModel.BasicHttpsSecurityMode Mode { get { return default(System.ServiceModel.BasicHttpsSecurityMode); } set { } }
    public System.ServiceModel.HttpTransportSecurity Transport { get { return default(System.ServiceModel.HttpTransportSecurity); } set { } }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public bool ShouldSerializeMessage() { return default(bool); }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public bool ShouldSerializeTransport() { return default(bool); }
  }
  public enum BasicHttpsSecurityMode {
    Transport = 0,
    TransportWithMessageCredential = 1,
  }
  public enum CacheSetting {
    AlwaysOff = 2,
    AlwaysOn = 1,
    Default = 0,
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(4))]
  public sealed partial class CallbackBehaviorAttribute : System.Attribute, System.ServiceModel.Description.IEndpointBehavior {
    public CallbackBehaviorAttribute() { }
    public bool AutomaticSessionShutdown { get { return default(bool); } set { } }
    public System.ServiceModel.ConcurrencyMode ConcurrencyMode { get { return default(System.ServiceModel.ConcurrencyMode); } set { } }
    public bool IgnoreExtensionDataObject { get { return default(bool); } set { } }
    public bool IncludeExceptionDetailInFaults { get { return default(bool); } set { } }
    public int MaxItemsInObjectGraph { get { return default(int); } set { } }
    public System.Transactions.IsolationLevel TransactionIsolationLevel { get { return default(System.Transactions.IsolationLevel); } set { } }
    public string TransactionTimeout { get { return default(string); } set { } }
    public bool UseSynchronizationContext { get { return default(bool); } set { } }
    public bool ValidateMustUnderstand { get { return default(bool); } set { } }
    void System.ServiceModel.Description.IEndpointBehavior.AddBindingParameters(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Channels.BindingParameterCollection parameters) { }
    void System.ServiceModel.Description.IEndpointBehavior.ApplyClientBehavior(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Dispatcher.ClientRuntime clientRuntime) { }
    void System.ServiceModel.Description.IEndpointBehavior.ApplyDispatchBehavior(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Dispatcher.EndpointDispatcher endpointDispatcher) { }
    void System.ServiceModel.Description.IEndpointBehavior.Validate(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint) { }
  }
  public abstract partial class ChannelFactory : System.ServiceModel.Channels.CommunicationObject, System.IDisposable, System.ServiceModel.Channels.IChannelFactory, System.ServiceModel.ICommunicationObject {
    protected ChannelFactory() { }
    public System.ServiceModel.Description.ClientCredentials Credentials { get { return default(System.ServiceModel.Description.ClientCredentials); } }
    protected override System.TimeSpan DefaultCloseTimeout { get { return default(System.TimeSpan); } }
    protected override System.TimeSpan DefaultOpenTimeout { get { return default(System.TimeSpan); } }
    public System.ServiceModel.Description.ServiceEndpoint Endpoint { get { return default(System.ServiceModel.Description.ServiceEndpoint); } }
    protected virtual void ApplyConfiguration(string configurationName) { }
    protected abstract System.ServiceModel.Description.ServiceEndpoint CreateDescription();
    protected virtual System.ServiceModel.Channels.IChannelFactory CreateFactory() { return default(System.ServiceModel.Channels.IChannelFactory); }
    protected internal void EnsureOpened() { }
    public T GetProperty<T>() where T : class { return default(T); }
    protected void InitializeEndpoint(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress address) { }
    protected void InitializeEndpoint(System.ServiceModel.Description.ServiceEndpoint endpoint) { }
    protected void InitializeEndpoint(string configurationName, System.ServiceModel.EndpointAddress address) { }
    protected override void OnAbort() { }
    protected override System.IAsyncResult OnBeginClose(System.TimeSpan timeout, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    protected override System.IAsyncResult OnBeginOpen(System.TimeSpan timeout, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    protected override void OnClose(System.TimeSpan timeout) { }
    protected override void OnEndClose(System.IAsyncResult result) { }
    protected override void OnEndOpen(System.IAsyncResult result) { }
    protected override void OnOpen(System.TimeSpan timeout) { }
    protected override void OnOpened() { }
    protected override void OnOpening() { }
    void System.IDisposable.Dispose() { }
  }
  public partial class ChannelFactory<TChannel> : System.ServiceModel.ChannelFactory, System.ServiceModel.Channels.IChannelFactory, System.ServiceModel.Channels.IChannelFactory<TChannel>, System.ServiceModel.ICommunicationObject {
    public ChannelFactory() { }
    public ChannelFactory(System.ServiceModel.Channels.Binding binding) { }
    public ChannelFactory(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) { }
    public ChannelFactory(System.ServiceModel.Channels.Binding binding, string remoteAddress) { }
    public ChannelFactory(System.ServiceModel.Description.ServiceEndpoint endpoint) { }
    public ChannelFactory(string endpointConfigurationName) { }
    public ChannelFactory(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) { }
    protected ChannelFactory(System.Type channelType) { }
    public TChannel CreateChannel() { return default(TChannel); }
    public static TChannel CreateChannel(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress endpointAddress) { return default(TChannel); }
    public static TChannel CreateChannel(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress endpointAddress, System.Uri via) { return default(TChannel); }
    public TChannel CreateChannel(System.ServiceModel.EndpointAddress address) { return default(TChannel); }
    public virtual TChannel CreateChannel(System.ServiceModel.EndpointAddress address, System.Uri via) { return default(TChannel); }
    protected static TChannel CreateChannel(string endpointConfigurationName) { return default(TChannel); }
    public TChannel CreateChannelWithActAsToken(System.IdentityModel.Tokens.SecurityToken actAsToken) { return default(TChannel); }
    public TChannel CreateChannelWithActAsToken(System.IdentityModel.Tokens.SecurityToken actAsToken, System.ServiceModel.EndpointAddress address) { return default(TChannel); }
    public TChannel CreateChannelWithActAsToken(System.IdentityModel.Tokens.SecurityToken actAsToken, System.ServiceModel.EndpointAddress address, System.Uri via) { return default(TChannel); }
    public TChannel CreateChannelWithIssuedToken(System.IdentityModel.Tokens.SecurityToken issuedToken) { return default(TChannel); }
    public TChannel CreateChannelWithIssuedToken(System.IdentityModel.Tokens.SecurityToken issuedToken, System.ServiceModel.EndpointAddress address) { return default(TChannel); }
    public TChannel CreateChannelWithIssuedToken(System.IdentityModel.Tokens.SecurityToken issuedToken, System.ServiceModel.EndpointAddress address, System.Uri via) { return default(TChannel); }
    public TChannel CreateChannelWithOnBehalfOfToken(System.IdentityModel.Tokens.SecurityToken onBehalfOf) { return default(TChannel); }
    public TChannel CreateChannelWithOnBehalfOfToken(System.IdentityModel.Tokens.SecurityToken onBehalfOf, System.ServiceModel.EndpointAddress address) { return default(TChannel); }
    public TChannel CreateChannelWithOnBehalfOfToken(System.IdentityModel.Tokens.SecurityToken onBehalfOf, System.ServiceModel.EndpointAddress address, System.Uri via) { return default(TChannel); }
    protected override System.ServiceModel.Description.ServiceEndpoint CreateDescription() { return default(System.ServiceModel.Description.ServiceEndpoint); }
  }
  public partial class ChannelTerminatedException : System.ServiceModel.CommunicationException {
    public ChannelTerminatedException() { }
    protected ChannelTerminatedException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public ChannelTerminatedException(string message) { }
    public ChannelTerminatedException(string message, System.Exception innerException) { }
  }
  public abstract partial class ClientBase<TChannel> : System.IDisposable, System.ServiceModel.ICommunicationObject where TChannel : class {
    protected ClientBase() { }
    protected ClientBase(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) { }
    protected ClientBase(System.ServiceModel.Description.ServiceEndpoint endpoint) { }
    protected ClientBase(System.ServiceModel.InstanceContext callbackInstance) { }
    protected ClientBase(System.ServiceModel.InstanceContext callbackInstance, System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) { }
    protected ClientBase(System.ServiceModel.InstanceContext callbackInstance, System.ServiceModel.Description.ServiceEndpoint endpoint) { }
    protected ClientBase(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName) { }
    protected ClientBase(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) { }
    protected ClientBase(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, string remoteAddress) { }
    protected ClientBase(string endpointConfigurationName) { }
    protected ClientBase(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) { }
    protected ClientBase(string endpointConfigurationName, string remoteAddress) { }
    public static System.ServiceModel.CacheSetting CacheSetting { get { return default(System.ServiceModel.CacheSetting); } set { } }
    protected TChannel Channel { get { return default(TChannel); } }
    public System.ServiceModel.ChannelFactory<TChannel> ChannelFactory { get { return default(System.ServiceModel.ChannelFactory<TChannel>); } }
    public System.ServiceModel.Description.ClientCredentials ClientCredentials { get { return default(System.ServiceModel.Description.ClientCredentials); } }
    public System.ServiceModel.Description.ServiceEndpoint Endpoint { get { return default(System.ServiceModel.Description.ServiceEndpoint); } }
    public System.ServiceModel.IClientChannel InnerChannel { get { return default(System.ServiceModel.IClientChannel); } }
    public System.ServiceModel.CommunicationState State { get { return default(System.ServiceModel.CommunicationState); } }
    event System.EventHandler System.ServiceModel.ICommunicationObject.Closed { add { } remove { } }
    event System.EventHandler System.ServiceModel.ICommunicationObject.Closing { add { } remove { } }
    event System.EventHandler System.ServiceModel.ICommunicationObject.Faulted { add { } remove { } }
    event System.EventHandler System.ServiceModel.ICommunicationObject.Opened { add { } remove { } }
    event System.EventHandler System.ServiceModel.ICommunicationObject.Opening { add { } remove { } }
    public void Abort() { }
    public void Close() { }
    protected virtual TChannel CreateChannel() { return default(TChannel); }
    public void DisplayInitializationUI() { }
    protected T GetDefaultValueForInitialization<T>() { return default(T); }
    protected void InvokeAsync(System.ServiceModel.ClientBase<TChannel>.BeginOperationDelegate beginOperationDelegate, System.Object[] inValues, System.ServiceModel.ClientBase<TChannel>.EndOperationDelegate endOperationDelegate, System.Threading.SendOrPostCallback operationCompletedCallback, object userState) { }
    public void Open() { }
    void System.IDisposable.Dispose() { }
    System.IAsyncResult System.ServiceModel.ICommunicationObject.BeginClose(System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    System.IAsyncResult System.ServiceModel.ICommunicationObject.BeginClose(System.TimeSpan timeout, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    System.IAsyncResult System.ServiceModel.ICommunicationObject.BeginOpen(System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    System.IAsyncResult System.ServiceModel.ICommunicationObject.BeginOpen(System.TimeSpan timeout, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    void System.ServiceModel.ICommunicationObject.Close(System.TimeSpan timeout) { }
    void System.ServiceModel.ICommunicationObject.EndClose(System.IAsyncResult result) { }
    void System.ServiceModel.ICommunicationObject.EndOpen(System.IAsyncResult result) { }
    void System.ServiceModel.ICommunicationObject.Open(System.TimeSpan timeout) { }
    protected delegate System.IAsyncResult BeginOperationDelegate(System.Object[] inValues, System.AsyncCallback asyncCallback, object state);
    protected partial class ChannelBase<T> : System.IDisposable, System.ServiceModel.Channels.IChannel, System.ServiceModel.Channels.IOutputChannel, System.ServiceModel.Channels.IRequestChannel, System.ServiceModel.IClientChannel, System.ServiceModel.ICommunicationObject, System.ServiceModel.IContextChannel, System.ServiceModel.IExtensibleObject<System.ServiceModel.IContextChannel> where T : class {
      protected ChannelBase(System.ServiceModel.ClientBase<T> client) { }
      System.ServiceModel.EndpointAddress System.ServiceModel.Channels.IOutputChannel.RemoteAddress { get { return default(System.ServiceModel.EndpointAddress); } }
      System.Uri System.ServiceModel.Channels.IOutputChannel.Via { get { return default(System.Uri); } }
      System.ServiceModel.EndpointAddress System.ServiceModel.Channels.IRequestChannel.RemoteAddress { get { return default(System.ServiceModel.EndpointAddress); } }
      System.Uri System.ServiceModel.Channels.IRequestChannel.Via { get { return default(System.Uri); } }
      bool System.ServiceModel.IClientChannel.AllowInitializationUI { get { return default(bool); } set { } }
      bool System.ServiceModel.IClientChannel.DidInteractiveInitialization { get { return default(bool); } }
      System.Uri System.ServiceModel.IClientChannel.Via { get { return default(System.Uri); } }
      System.ServiceModel.CommunicationState System.ServiceModel.ICommunicationObject.State { get { return default(System.ServiceModel.CommunicationState); } }
      bool System.ServiceModel.IContextChannel.AllowOutputBatching { get { return default(bool); } set { } }
      System.ServiceModel.Channels.IInputSession System.ServiceModel.IContextChannel.InputSession { get { return default(System.ServiceModel.Channels.IInputSession); } }
      System.ServiceModel.EndpointAddress System.ServiceModel.IContextChannel.LocalAddress { get { return default(System.ServiceModel.EndpointAddress); } }
      System.TimeSpan System.ServiceModel.IContextChannel.OperationTimeout { get { return default(System.TimeSpan); } set { } }
      System.ServiceModel.Channels.IOutputSession System.ServiceModel.IContextChannel.OutputSession { get { return default(System.ServiceModel.Channels.IOutputSession); } }
      System.ServiceModel.EndpointAddress System.ServiceModel.IContextChannel.RemoteAddress { get { return default(System.ServiceModel.EndpointAddress); } }
      string System.ServiceModel.IContextChannel.SessionId { get { return default(string); } }
      System.ServiceModel.IExtensionCollection<System.ServiceModel.IContextChannel> System.ServiceModel.IExtensibleObject<System.ServiceModel.IContextChannel>.Extensions { get { return default(System.ServiceModel.IExtensionCollection<System.ServiceModel.IContextChannel>); } }
      event System.EventHandler<System.ServiceModel.UnknownMessageReceivedEventArgs> System.ServiceModel.IClientChannel.UnknownMessageReceived { add { } remove { } }
      event System.EventHandler System.ServiceModel.ICommunicationObject.Closed { add { } remove { } }
      event System.EventHandler System.ServiceModel.ICommunicationObject.Closing { add { } remove { } }
      event System.EventHandler System.ServiceModel.ICommunicationObject.Faulted { add { } remove { } }
      event System.EventHandler System.ServiceModel.ICommunicationObject.Opened { add { } remove { } }
      event System.EventHandler System.ServiceModel.ICommunicationObject.Opening { add { } remove { } }
      [System.Security.SecuritySafeCriticalAttribute]
      protected System.IAsyncResult BeginInvoke(string methodName, System.Object[] args, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
      [System.Security.SecuritySafeCriticalAttribute]
      protected object EndInvoke(string methodName, System.Object[] args, System.IAsyncResult result) { return default(object); }
      void System.IDisposable.Dispose() { }
      TProperty System.ServiceModel.Channels.IChannel.GetProperty<TProperty>() { return default(TProperty); }
      System.IAsyncResult System.ServiceModel.Channels.IOutputChannel.BeginSend(System.ServiceModel.Channels.Message message, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
      System.IAsyncResult System.ServiceModel.Channels.IOutputChannel.BeginSend(System.ServiceModel.Channels.Message message, System.TimeSpan timeout, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
      void System.ServiceModel.Channels.IOutputChannel.EndSend(System.IAsyncResult result) { }
      void System.ServiceModel.Channels.IOutputChannel.Send(System.ServiceModel.Channels.Message message) { }
      void System.ServiceModel.Channels.IOutputChannel.Send(System.ServiceModel.Channels.Message message, System.TimeSpan timeout) { }
      System.IAsyncResult System.ServiceModel.Channels.IRequestChannel.BeginRequest(System.ServiceModel.Channels.Message message, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
      System.IAsyncResult System.ServiceModel.Channels.IRequestChannel.BeginRequest(System.ServiceModel.Channels.Message message, System.TimeSpan timeout, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
      System.ServiceModel.Channels.Message System.ServiceModel.Channels.IRequestChannel.EndRequest(System.IAsyncResult result) { return default(System.ServiceModel.Channels.Message); }
      System.ServiceModel.Channels.Message System.ServiceModel.Channels.IRequestChannel.Request(System.ServiceModel.Channels.Message message) { return default(System.ServiceModel.Channels.Message); }
      System.ServiceModel.Channels.Message System.ServiceModel.Channels.IRequestChannel.Request(System.ServiceModel.Channels.Message message, System.TimeSpan timeout) { return default(System.ServiceModel.Channels.Message); }
      System.IAsyncResult System.ServiceModel.IClientChannel.BeginDisplayInitializationUI(System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
      void System.ServiceModel.IClientChannel.DisplayInitializationUI() { }
      void System.ServiceModel.IClientChannel.EndDisplayInitializationUI(System.IAsyncResult result) { }
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
    protected delegate System.Object[] EndOperationDelegate(System.IAsyncResult result);
    protected partial class InvokeAsyncCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
      internal InvokeAsyncCompletedEventArgs() { }
      public System.Object[] Results { get { return default(System.Object[]); } }
    }
  }
  public partial class ClientCredentialsSecurityTokenManager : System.IdentityModel.Selectors.SecurityTokenManager {
    public ClientCredentialsSecurityTokenManager(System.ServiceModel.Description.ClientCredentials clientCredentials) { }
    public System.ServiceModel.Description.ClientCredentials ClientCredentials { get { return default(System.ServiceModel.Description.ClientCredentials); } }
    public override System.IdentityModel.Selectors.SecurityTokenAuthenticator CreateSecurityTokenAuthenticator(System.IdentityModel.Selectors.SecurityTokenRequirement tokenRequirement, out System.IdentityModel.Selectors.SecurityTokenResolver outOfBandTokenResolver) { outOfBandTokenResolver = default(System.IdentityModel.Selectors.SecurityTokenResolver); return default(System.IdentityModel.Selectors.SecurityTokenAuthenticator); }
    public override System.IdentityModel.Selectors.SecurityTokenProvider CreateSecurityTokenProvider(System.IdentityModel.Selectors.SecurityTokenRequirement tokenRequirement) { return default(System.IdentityModel.Selectors.SecurityTokenProvider); }
    public override System.IdentityModel.Selectors.SecurityTokenSerializer CreateSecurityTokenSerializer(System.IdentityModel.Selectors.SecurityTokenVersion version) { return default(System.IdentityModel.Selectors.SecurityTokenSerializer); }
    protected System.IdentityModel.Selectors.SecurityTokenSerializer CreateSecurityTokenSerializer(System.ServiceModel.Security.SecurityVersion version) { return default(System.IdentityModel.Selectors.SecurityTokenSerializer); }
    protected internal bool IsIssuedSecurityTokenRequirement(System.IdentityModel.Selectors.SecurityTokenRequirement requirement) { return default(bool); }
  }
  public partial class CommunicationException : System.SystemException {
    public CommunicationException() { }
    protected CommunicationException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public CommunicationException(string message) { }
    public CommunicationException(string message, System.Exception innerException) { }
  }
  public partial class CommunicationObjectAbortedException : System.ServiceModel.CommunicationException {
    public CommunicationObjectAbortedException() { }
    protected CommunicationObjectAbortedException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public CommunicationObjectAbortedException(string message) { }
    public CommunicationObjectAbortedException(string message, System.Exception innerException) { }
  }
  public partial class CommunicationObjectFaultedException : System.ServiceModel.CommunicationException {
    public CommunicationObjectFaultedException() { }
    protected CommunicationObjectFaultedException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public CommunicationObjectFaultedException(string message) { }
    public CommunicationObjectFaultedException(string message, System.Exception innerException) { }
  }
  public enum CommunicationState {
    Closed = 4,
    Closing = 3,
    Created = 0,
    Faulted = 5,
    Opened = 2,
    Opening = 1,
  }
  public enum ConcurrencyMode {
    Multiple = 2,
    Reentrant = 1,
    Single = 0,
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(1092), Inherited=false, AllowMultiple=false)]
  public sealed partial class DataContractFormatAttribute : System.Attribute {
    public DataContractFormatAttribute() { }
    public System.ServiceModel.OperationFormatStyle Style { get { return default(System.ServiceModel.OperationFormatStyle); } set { } }
  }
  public enum DeadLetterQueue {
    Custom = 2,
    None = 0,
    System = 1,
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(1028), AllowMultiple=true)]
  public sealed partial class DeliveryRequirementsAttribute : System.Attribute, System.ServiceModel.Description.IContractBehavior, System.ServiceModel.Description.IContractBehaviorAttribute {
    public DeliveryRequirementsAttribute() { }
    public System.ServiceModel.QueuedDeliveryRequirementsMode QueuedDeliveryRequirements { get { return default(System.ServiceModel.QueuedDeliveryRequirementsMode); } set { } }
    public bool RequireOrderedDelivery { get { return default(bool); } set { } }
    public System.Type TargetContract { get { return default(System.Type); } set { } }
    void System.ServiceModel.Description.IContractBehavior.AddBindingParameters(System.ServiceModel.Description.ContractDescription description, System.ServiceModel.Description.ServiceEndpoint endpoint, System.ServiceModel.Channels.BindingParameterCollection parameters) { }
    void System.ServiceModel.Description.IContractBehavior.ApplyClientBehavior(System.ServiceModel.Description.ContractDescription description, System.ServiceModel.Description.ServiceEndpoint endpoint, System.ServiceModel.Dispatcher.ClientRuntime proxy) { }
    void System.ServiceModel.Description.IContractBehavior.ApplyDispatchBehavior(System.ServiceModel.Description.ContractDescription description, System.ServiceModel.Description.ServiceEndpoint endpoint, System.ServiceModel.Dispatcher.DispatchRuntime dispatch) { }
    void System.ServiceModel.Description.IContractBehavior.Validate(System.ServiceModel.Description.ContractDescription description, System.ServiceModel.Description.ServiceEndpoint endpoint) { }
  }
  public partial class DnsEndpointIdentity : System.ServiceModel.EndpointIdentity {
    public DnsEndpointIdentity(System.IdentityModel.Claims.Claim identity) { }
    public DnsEndpointIdentity(string dnsName) { }
  }
  public partial class DuplexChannelFactory<TChannel> : System.ServiceModel.ChannelFactory<TChannel> {
    public DuplexChannelFactory(object callbackObject) { }
    public DuplexChannelFactory(object callbackObject, System.ServiceModel.Channels.Binding binding) { }
    public DuplexChannelFactory(object callbackObject, System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) { }
    public DuplexChannelFactory(object callbackObject, System.ServiceModel.Channels.Binding binding, string remoteAddress) { }
    public DuplexChannelFactory(object callbackObject, System.ServiceModel.Description.ServiceEndpoint endpoint) { }
    public DuplexChannelFactory(object callbackObject, string endpointConfigurationName) { }
    public DuplexChannelFactory(object callbackObject, string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) { }
    public DuplexChannelFactory(System.ServiceModel.InstanceContext callbackInstance) { }
    public DuplexChannelFactory(System.ServiceModel.InstanceContext callbackInstance, System.ServiceModel.Channels.Binding binding) { }
    public DuplexChannelFactory(System.ServiceModel.InstanceContext callbackInstance, System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) { }
    public DuplexChannelFactory(System.ServiceModel.InstanceContext callbackInstance, System.ServiceModel.Channels.Binding binding, string remoteAddress) { }
    public DuplexChannelFactory(System.ServiceModel.InstanceContext callbackInstance, System.ServiceModel.Description.ServiceEndpoint endpoint) { }
    public DuplexChannelFactory(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName) { }
    public DuplexChannelFactory(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) { }
    public DuplexChannelFactory(System.Type callbackInstanceType) { }
    public DuplexChannelFactory(System.Type callbackInstanceType, System.ServiceModel.Channels.Binding binding) { }
    public DuplexChannelFactory(System.Type callbackInstanceType, System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) { }
    public DuplexChannelFactory(System.Type callbackInstanceType, System.ServiceModel.Channels.Binding binding, string remoteAddress) { }
    public DuplexChannelFactory(System.Type callbackInstanceType, System.ServiceModel.Description.ServiceEndpoint endpoint) { }
    public DuplexChannelFactory(System.Type callbackInstanceType, string endpointConfigurationName) { }
    public DuplexChannelFactory(System.Type callbackInstanceType, string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) { }
    public static TChannel CreateChannel(object callbackObject, System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress endpointAddress) { return default(TChannel); }
    public static TChannel CreateChannel(object callbackObject, System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress endpointAddress, System.Uri via) { return default(TChannel); }
    public static TChannel CreateChannel(object callbackObject, string endpointConfigurationName) { return default(TChannel); }
    public override TChannel CreateChannel(System.ServiceModel.EndpointAddress address, System.Uri via) { return default(TChannel); }
    public TChannel CreateChannel(System.ServiceModel.InstanceContext callbackInstance) { return default(TChannel); }
    public static TChannel CreateChannel(System.ServiceModel.InstanceContext callbackInstance, System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress endpointAddress) { return default(TChannel); }
    public static TChannel CreateChannel(System.ServiceModel.InstanceContext callbackInstance, System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress endpointAddress, System.Uri via) { return default(TChannel); }
    public TChannel CreateChannel(System.ServiceModel.InstanceContext callbackInstance, System.ServiceModel.EndpointAddress address) { return default(TChannel); }
    public virtual TChannel CreateChannel(System.ServiceModel.InstanceContext callbackInstance, System.ServiceModel.EndpointAddress address, System.Uri via) { return default(TChannel); }
    public static TChannel CreateChannel(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName) { return default(TChannel); }
  }
  public abstract partial class DuplexClientBase<TChannel> : System.ServiceModel.ClientBase<TChannel> where TChannel : class {
    protected DuplexClientBase(object callbackInstance) { }
    protected DuplexClientBase(object callbackInstance, System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) { }
    protected DuplexClientBase(object callbackInstance, System.ServiceModel.Description.ServiceEndpoint endpoint) { }
    protected DuplexClientBase(object callbackInstance, string endpointConfigurationName) { }
    protected DuplexClientBase(object callbackInstance, string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) { }
    protected DuplexClientBase(object callbackInstance, string endpointConfigurationName, string remoteAddress) { }
    protected DuplexClientBase(System.ServiceModel.InstanceContext callbackInstance) { }
    protected DuplexClientBase(System.ServiceModel.InstanceContext callbackInstance, System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) { }
    protected DuplexClientBase(System.ServiceModel.InstanceContext callbackInstance, System.ServiceModel.Description.ServiceEndpoint endpoint) { }
    protected DuplexClientBase(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName) { }
    protected DuplexClientBase(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) { }
    protected DuplexClientBase(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, string remoteAddress) { }
    public System.ServiceModel.IDuplexContextChannel InnerDuplexChannel { get { return default(System.ServiceModel.IDuplexContextChannel); } }
  }
  public partial class EndpointAddress {
    public EndpointAddress(string uri) { }
    public EndpointAddress(System.Uri uri, params System.ServiceModel.Channels.AddressHeader[] addressHeaders) { }
    public EndpointAddress(System.Uri uri, System.ServiceModel.EndpointIdentity identity, params System.ServiceModel.Channels.AddressHeader[] addressHeaders) { }
    public EndpointAddress(System.Uri uri, System.ServiceModel.EndpointIdentity identity, System.ServiceModel.Channels.AddressHeaderCollection headers) { }
    public EndpointAddress(System.Uri uri, System.ServiceModel.EndpointIdentity identity, System.ServiceModel.Channels.AddressHeaderCollection headers, System.Xml.XmlDictionaryReader metadataReader, System.Xml.XmlDictionaryReader extensionReader) { }
    public static System.Uri AnonymousUri { get { return default(System.Uri); } }
    public System.ServiceModel.Channels.AddressHeaderCollection Headers { get { return default(System.ServiceModel.Channels.AddressHeaderCollection); } }
    public System.ServiceModel.EndpointIdentity Identity { get { return default(System.ServiceModel.EndpointIdentity); } }
    public bool IsAnonymous { get { return default(bool); } }
    public bool IsNone { get { return default(bool); } }
    public static System.Uri NoneUri { get { return default(System.Uri); } }
    [System.ComponentModel.TypeConverterAttribute(typeof(System.UriTypeConverter))]
    public System.Uri Uri { get { return default(System.Uri); } }
    public void ApplyTo(System.ServiceModel.Channels.Message message) { }
    public override bool Equals(object obj) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public System.Xml.XmlDictionaryReader GetReaderAtExtensions() { return default(System.Xml.XmlDictionaryReader); }
    public System.Xml.XmlDictionaryReader GetReaderAtMetadata() { return default(System.Xml.XmlDictionaryReader); }
    public static bool operator ==(System.ServiceModel.EndpointAddress address1, System.ServiceModel.EndpointAddress address2) { return default(bool); }
    public static bool operator !=(System.ServiceModel.EndpointAddress address1, System.ServiceModel.EndpointAddress address2) { return default(bool); }
    public static System.ServiceModel.EndpointAddress ReadFrom(System.ServiceModel.Channels.AddressingVersion addressingVersion, System.Xml.XmlDictionaryReader reader) { return default(System.ServiceModel.EndpointAddress); }
    public static System.ServiceModel.EndpointAddress ReadFrom(System.ServiceModel.Channels.AddressingVersion addressingVersion, System.Xml.XmlDictionaryReader reader, System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString ns) { return default(System.ServiceModel.EndpointAddress); }
    public static System.ServiceModel.EndpointAddress ReadFrom(System.ServiceModel.Channels.AddressingVersion addressingVersion, System.Xml.XmlReader reader) { return default(System.ServiceModel.EndpointAddress); }
    public static System.ServiceModel.EndpointAddress ReadFrom(System.ServiceModel.Channels.AddressingVersion addressingVersion, System.Xml.XmlReader reader, string localName, string ns) { return default(System.ServiceModel.EndpointAddress); }
    public static System.ServiceModel.EndpointAddress ReadFrom(System.Xml.XmlDictionaryReader reader) { return default(System.ServiceModel.EndpointAddress); }
    public static System.ServiceModel.EndpointAddress ReadFrom(System.Xml.XmlDictionaryReader reader, System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString ns) { return default(System.ServiceModel.EndpointAddress); }
    public override string ToString() { return default(string); }
    public void WriteContentsTo(System.ServiceModel.Channels.AddressingVersion addressingVersion, System.Xml.XmlDictionaryWriter writer) { }
    public void WriteContentsTo(System.ServiceModel.Channels.AddressingVersion addressingVersion, System.Xml.XmlWriter writer) { }
    public void WriteTo(System.ServiceModel.Channels.AddressingVersion addressingVersion, System.Xml.XmlDictionaryWriter writer) { }
    public void WriteTo(System.ServiceModel.Channels.AddressingVersion addressingVersion, System.Xml.XmlDictionaryWriter writer, System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString ns) { }
    public void WriteTo(System.ServiceModel.Channels.AddressingVersion addressingVersion, System.Xml.XmlWriter writer) { }
    public void WriteTo(System.ServiceModel.Channels.AddressingVersion addressingVersion, System.Xml.XmlWriter writer, string localName, string ns) { }
  }
  [System.Xml.Serialization.XmlRootAttribute("EndpointReference", Namespace="http://www.w3.org/2005/08/addressing")]
  [System.Xml.Serialization.XmlSchemaProviderAttribute("GetSchema")]
  public partial class EndpointAddress10 : System.Xml.Serialization.IXmlSerializable {
    internal EndpointAddress10() { }
    public static System.ServiceModel.EndpointAddress10 FromEndpointAddress(System.ServiceModel.EndpointAddress address) { return default(System.ServiceModel.EndpointAddress10); }
    public static System.Xml.XmlQualifiedName GetSchema(System.Xml.Schema.XmlSchemaSet xmlSchemaSet) { return default(System.Xml.XmlQualifiedName); }
    System.Xml.Schema.XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { return default(System.Xml.Schema.XmlSchema); }
    void System.Xml.Serialization.IXmlSerializable.ReadXml(System.Xml.XmlReader reader) { }
    void System.Xml.Serialization.IXmlSerializable.WriteXml(System.Xml.XmlWriter writer) { }
    public System.ServiceModel.EndpointAddress ToEndpointAddress() { return default(System.ServiceModel.EndpointAddress); }
  }
  [System.Xml.Serialization.XmlRootAttribute("EndpointReference", Namespace="http://schemas.xmlsoap.org/ws/2004/08/addressing")]
  [System.Xml.Serialization.XmlSchemaProviderAttribute("GetSchema")]
  public partial class EndpointAddressAugust2004 : System.Xml.Serialization.IXmlSerializable {
    internal EndpointAddressAugust2004() { }
    public static System.ServiceModel.EndpointAddressAugust2004 FromEndpointAddress(System.ServiceModel.EndpointAddress address) { return default(System.ServiceModel.EndpointAddressAugust2004); }
    public static System.Xml.XmlQualifiedName GetSchema(System.Xml.Schema.XmlSchemaSet xmlSchemaSet) { return default(System.Xml.XmlQualifiedName); }
    System.Xml.Schema.XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { return default(System.Xml.Schema.XmlSchema); }
    void System.Xml.Serialization.IXmlSerializable.ReadXml(System.Xml.XmlReader reader) { }
    void System.Xml.Serialization.IXmlSerializable.WriteXml(System.Xml.XmlWriter writer) { }
    public System.ServiceModel.EndpointAddress ToEndpointAddress() { return default(System.ServiceModel.EndpointAddress); }
  }
  public partial class EndpointAddressBuilder {
    public EndpointAddressBuilder() { }
    public EndpointAddressBuilder(System.ServiceModel.EndpointAddress address) { }
    public System.Collections.ObjectModel.Collection<System.ServiceModel.Channels.AddressHeader> Headers { get { return default(System.Collections.ObjectModel.Collection<System.ServiceModel.Channels.AddressHeader>); } }
    public System.ServiceModel.EndpointIdentity Identity { get { return default(System.ServiceModel.EndpointIdentity); } set { } }
    public System.Uri Uri { get { return default(System.Uri); } set { } }
    public System.Xml.XmlDictionaryReader GetReaderAtExtensions() { return default(System.Xml.XmlDictionaryReader); }
    public System.Xml.XmlDictionaryReader GetReaderAtMetadata() { return default(System.Xml.XmlDictionaryReader); }
    public void SetExtensionReader(System.Xml.XmlDictionaryReader reader) { }
    public void SetMetadataReader(System.Xml.XmlDictionaryReader reader) { }
    public System.ServiceModel.EndpointAddress ToEndpointAddress() { return default(System.ServiceModel.EndpointAddress); }
  }
  public abstract partial class EndpointIdentity {
    protected EndpointIdentity() { }
    public System.IdentityModel.Claims.Claim IdentityClaim { get { return default(System.IdentityModel.Claims.Claim); } }
    public static System.ServiceModel.EndpointIdentity CreateDnsIdentity(string dnsName) { return default(System.ServiceModel.EndpointIdentity); }
    public static System.ServiceModel.EndpointIdentity CreateIdentity(System.IdentityModel.Claims.Claim identity) { return default(System.ServiceModel.EndpointIdentity); }
    public static System.ServiceModel.EndpointIdentity CreateRsaIdentity(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate) { return default(System.ServiceModel.EndpointIdentity); }
    public static System.ServiceModel.EndpointIdentity CreateRsaIdentity(string publicKey) { return default(System.ServiceModel.EndpointIdentity); }
    public static System.ServiceModel.EndpointIdentity CreateSpnIdentity(string spnName) { return default(System.ServiceModel.EndpointIdentity); }
    public static System.ServiceModel.EndpointIdentity CreateUpnIdentity(string upnName) { return default(System.ServiceModel.EndpointIdentity); }
    public static System.ServiceModel.EndpointIdentity CreateX509CertificateIdentity(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate) { return default(System.ServiceModel.EndpointIdentity); }
    public static System.ServiceModel.EndpointIdentity CreateX509CertificateIdentity(System.Security.Cryptography.X509Certificates.X509Certificate2 primaryCertificate, System.Security.Cryptography.X509Certificates.X509Certificate2Collection supportingCertificates) { return default(System.ServiceModel.EndpointIdentity); }
    public override bool Equals(object obj) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    protected void Initialize(System.IdentityModel.Claims.Claim identityClaim) { }
    protected void Initialize(System.IdentityModel.Claims.Claim identityClaim, System.Collections.Generic.IEqualityComparer<System.IdentityModel.Claims.Claim> claimComparer) { }
    public override string ToString() { return default(string); }
  }
  public partial class EndpointNotFoundException : System.ServiceModel.CommunicationException {
    public EndpointNotFoundException() { }
    protected EndpointNotFoundException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public EndpointNotFoundException(string message) { }
    public EndpointNotFoundException(string message, System.Exception innerException) { }
  }
  public sealed partial class EnvelopeVersion {
    internal EnvelopeVersion() { }
    public string NextDestinationActorValue { get { return default(string); } }
    public static System.ServiceModel.EnvelopeVersion None { get { return default(System.ServiceModel.EnvelopeVersion); } }
    public static System.ServiceModel.EnvelopeVersion Soap11 { get { return default(System.ServiceModel.EnvelopeVersion); } }
    public static System.ServiceModel.EnvelopeVersion Soap12 { get { return default(System.ServiceModel.EnvelopeVersion); } }
    public System.String[] GetUltimateDestinationActorValues() { return default(System.String[]); }
    public override string ToString() { return default(string); }
  }
  [System.Runtime.Serialization.DataContractAttribute]
  public partial class ExceptionDetail {
    public ExceptionDetail(System.Exception exception) { }
    [System.Runtime.Serialization.DataMemberAttribute]
    public string HelpLink { get { return default(string); } set { } }
    [System.Runtime.Serialization.DataMemberAttribute]
    public System.ServiceModel.ExceptionDetail InnerException { get { return default(System.ServiceModel.ExceptionDetail); } set { } }
    [System.Runtime.Serialization.DataMemberAttribute]
    public string Message { get { return default(string); } set { } }
    [System.Runtime.Serialization.DataMemberAttribute]
    public string StackTrace { get { return default(string); } set { } }
    [System.Runtime.Serialization.DataMemberAttribute]
    public string Type { get { return default(string); } set { } }
    public override string ToString() { return default(string); }
  }
  public partial class ExceptionMapper {
    public ExceptionMapper() { }
    public virtual System.ServiceModel.FaultException FromException(System.Exception ex) { return default(System.ServiceModel.FaultException); }
    public virtual System.ServiceModel.FaultException FromException(System.Exception ex, string soapNamespace, string trustNamespace) { return default(System.ServiceModel.FaultException); }
    public virtual bool HandleSecurityTokenProcessingException(System.Exception ex) { return default(bool); }
  }
  public sealed partial class ExtensionCollection<T> : System.Collections.Generic.SynchronizedCollection<System.ServiceModel.IExtension<T>>, System.Collections.Generic.ICollection<System.ServiceModel.IExtension<T>>, System.Collections.Generic.IEnumerable<System.ServiceModel.IExtension<T>>, System.Collections.IEnumerable, System.ServiceModel.IExtensionCollection<T> where T : System.ServiceModel.IExtensibleObject<T> {
    public ExtensionCollection(T owner) { }
    public ExtensionCollection(T owner, object syncRoot) { }
    bool System.Collections.Generic.ICollection<System.ServiceModel.IExtension<T>>.IsReadOnly { get { return default(bool); } }
    protected override void ClearItems() { }
    public E Find<E>() { return default(E); }
    public System.Collections.ObjectModel.Collection<E> FindAll<E>() { return default(System.Collections.ObjectModel.Collection<E>); }
    protected override void InsertItem(int index, System.ServiceModel.IExtension<T> item) { }
    protected override void RemoveItem(int index) { }
    protected override void SetItem(int index, System.ServiceModel.IExtension<T> item) { }
  }
  public partial class FaultCode {
    public FaultCode(string name) { }
    public FaultCode(string name, System.ServiceModel.FaultCode subCode) { }
    public FaultCode(string name, string ns) { }
    public FaultCode(string name, string ns, System.ServiceModel.FaultCode subCode) { }
    public bool IsPredefinedFault { get { return default(bool); } }
    public bool IsReceiverFault { get { return default(bool); } }
    public bool IsSenderFault { get { return default(bool); } }
    public string Name { get { return default(string); } }
    public string Namespace { get { return default(string); } }
    public System.ServiceModel.FaultCode SubCode { get { return default(System.ServiceModel.FaultCode); } }
    public static System.ServiceModel.FaultCode CreateReceiverFaultCode(System.ServiceModel.FaultCode subCode) { return default(System.ServiceModel.FaultCode); }
    public static System.ServiceModel.FaultCode CreateReceiverFaultCode(string name, string ns) { return default(System.ServiceModel.FaultCode); }
    public static System.ServiceModel.FaultCode CreateSenderFaultCode(System.ServiceModel.FaultCode subCode) { return default(System.ServiceModel.FaultCode); }
    public static System.ServiceModel.FaultCode CreateSenderFaultCode(string name, string ns) { return default(System.ServiceModel.FaultCode); }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(64), AllowMultiple=true, Inherited=false)]
  public sealed partial class FaultContractAttribute : System.Attribute {
    public FaultContractAttribute(System.Type detailType) { }
    public string Action { get { return default(string); } set { } }
    public System.Type DetailType { get { return default(System.Type); } }
    public bool HasProtectionLevel { get { return default(bool); } }
    public string Name { get { return default(string); } set { } }
    public string Namespace { get { return default(string); } set { } }
    public System.Net.Security.ProtectionLevel ProtectionLevel { get { return default(System.Net.Security.ProtectionLevel); } set { } }
  }
  [System.Runtime.Serialization.KnownTypeAttribute(typeof(System.ServiceModel.FaultException.FaultCodeData))]
  [System.Runtime.Serialization.KnownTypeAttribute(typeof(System.ServiceModel.FaultException.FaultCodeData[]))]
  [System.Runtime.Serialization.KnownTypeAttribute(typeof(System.ServiceModel.FaultException.FaultReasonData))]
  [System.Runtime.Serialization.KnownTypeAttribute(typeof(System.ServiceModel.FaultException.FaultReasonData[]))]
  public partial class FaultException : System.ServiceModel.CommunicationException {
    public FaultException() { }
    protected FaultException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public FaultException(System.ServiceModel.Channels.MessageFault fault) { }
    public FaultException(System.ServiceModel.Channels.MessageFault fault, string action) { }
    public FaultException(System.ServiceModel.FaultReason reason) { }
    public FaultException(System.ServiceModel.FaultReason reason, System.ServiceModel.FaultCode code) { }
    public FaultException(System.ServiceModel.FaultReason reason, System.ServiceModel.FaultCode code, string action) { }
    public FaultException(string reason) { }
    public FaultException(string reason, System.ServiceModel.FaultCode code) { }
    public FaultException(string reason, System.ServiceModel.FaultCode code, string action) { }
    public string Action { get { return default(string); } }
    public System.ServiceModel.FaultCode Code { get { return default(System.ServiceModel.FaultCode); } }
    public override string Message { get { return default(string); } }
    public System.ServiceModel.FaultReason Reason { get { return default(System.ServiceModel.FaultReason); } }
    public static System.ServiceModel.FaultException CreateFault(System.ServiceModel.Channels.MessageFault messageFault, string action, params System.Type[] faultDetailTypes) { return default(System.ServiceModel.FaultException); }
    public static System.ServiceModel.FaultException CreateFault(System.ServiceModel.Channels.MessageFault messageFault, params System.Type[] faultDetailTypes) { return default(System.ServiceModel.FaultException); }
    public virtual System.ServiceModel.Channels.MessageFault CreateMessageFault() { return default(System.ServiceModel.Channels.MessageFault); }
    [System.Security.SecurityCriticalAttribute]
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, SerializationFormatter=true)]
    public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
  }
  public partial class FaultException<TDetail> : System.ServiceModel.FaultException {
    public FaultException(TDetail detail) { }
    public FaultException(TDetail detail, System.ServiceModel.FaultReason reason) { }
    public FaultException(TDetail detail, System.ServiceModel.FaultReason reason, System.ServiceModel.FaultCode code) { }
    public FaultException(TDetail detail, System.ServiceModel.FaultReason reason, System.ServiceModel.FaultCode code, string action) { }
    public FaultException(TDetail detail, string reason) { }
    public FaultException(TDetail detail, string reason, System.ServiceModel.FaultCode code) { }
    public FaultException(TDetail detail, string reason, System.ServiceModel.FaultCode code, string action) { }
    protected FaultException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public TDetail Detail { get { return default(TDetail); } }
    public override System.ServiceModel.Channels.MessageFault CreateMessageFault() { return default(System.ServiceModel.Channels.MessageFault); }
    [System.Security.SecurityCriticalAttribute]
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, SerializationFormatter=true)]
    public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public override string ToString() { return default(string); }
  }
  public partial class FaultImportOptions {
    public FaultImportOptions() { }
    public bool UseMessageFormat { get { return default(bool); } set { } }
  }
  public partial class FaultReason {
    public FaultReason(System.Collections.Generic.IEnumerable<System.ServiceModel.FaultReasonText> translations) { }
    public FaultReason(System.ServiceModel.FaultReasonText translation) { }
    public FaultReason(string text) { }
    public System.Collections.Generic.SynchronizedReadOnlyCollection<System.ServiceModel.FaultReasonText> Translations { get { return default(System.Collections.Generic.SynchronizedReadOnlyCollection<System.ServiceModel.FaultReasonText>); } }
    public System.ServiceModel.FaultReasonText GetMatchingTranslation() { return default(System.ServiceModel.FaultReasonText); }
    public System.ServiceModel.FaultReasonText GetMatchingTranslation(System.Globalization.CultureInfo cultureInfo) { return default(System.ServiceModel.FaultReasonText); }
    public override string ToString() { return default(string); }
  }
  public partial class FaultReasonText {
    public FaultReasonText(string text) { }
    public FaultReasonText(string text, System.Globalization.CultureInfo cultureInfo) { }
    public FaultReasonText(string text, string xmlLang) { }
    public string Text { get { return default(string); } }
    public string XmlLang { get { return default(string); } }
    public bool Matches(System.Globalization.CultureInfo cultureInfo) { return default(bool); }
  }
  public sealed partial class FederatedMessageSecurityOverHttp {
    public FederatedMessageSecurityOverHttp() { }
    public System.ServiceModel.Security.SecurityAlgorithmSuite AlgorithmSuite { get { return default(System.ServiceModel.Security.SecurityAlgorithmSuite); } set { } }
    public System.Collections.ObjectModel.Collection<System.ServiceModel.Security.Tokens.ClaimTypeRequirement> ClaimTypeRequirements { get { return default(System.Collections.ObjectModel.Collection<System.ServiceModel.Security.Tokens.ClaimTypeRequirement>); } }
    public bool EstablishSecurityContext { get { return default(bool); } set { } }
    public System.IdentityModel.Tokens.SecurityKeyType IssuedKeyType { get { return default(System.IdentityModel.Tokens.SecurityKeyType); } set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public string IssuedTokenType { get { return default(string); } set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.ServiceModel.EndpointAddress IssuerAddress { get { return default(System.ServiceModel.EndpointAddress); } set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.ServiceModel.Channels.Binding IssuerBinding { get { return default(System.ServiceModel.Channels.Binding); } set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.ServiceModel.EndpointAddress IssuerMetadataAddress { get { return default(System.ServiceModel.EndpointAddress); } set { } }
    public bool NegotiateServiceCredential { get { return default(bool); } set { } }
    public System.Collections.ObjectModel.Collection<System.Xml.XmlElement> TokenRequestParameters { get { return default(System.Collections.ObjectModel.Collection<System.Xml.XmlElement>); } }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public bool ShouldSerializeAlgorithmSuite() { return default(bool); }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public bool ShouldSerializeClaimTypeRequirements() { return default(bool); }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public bool ShouldSerializeEstablishSecurityContext() { return default(bool); }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public bool ShouldSerializeIssuedKeyType() { return default(bool); }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public bool ShouldSerializeNegotiateServiceCredential() { return default(bool); }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public bool ShouldSerializeTokenRequestParameters() { return default(bool); }
  }
  public enum HostNameComparisonMode {
    Exact = 1,
    StrongWildcard = 0,
    WeakWildcard = 2,
  }
  public abstract partial class HttpBindingBase : System.ServiceModel.Channels.Binding, System.ServiceModel.Channels.IBindingRuntimePreferences {
    internal HttpBindingBase() { }
    [System.ComponentModel.DefaultValueAttribute(false)]
    public bool AllowCookies { get { return default(bool); } set { } }
    [System.ComponentModel.DefaultValueAttribute(false)]
    public bool BypassProxyOnLocal { get { return default(bool); } set { } }
    public System.ServiceModel.EnvelopeVersion EnvelopeVersion { get { return default(System.ServiceModel.EnvelopeVersion); } }
    [System.ComponentModel.DefaultValueAttribute((System.ServiceModel.HostNameComparisonMode)(0))]
    public System.ServiceModel.HostNameComparisonMode HostNameComparisonMode { get { return default(System.ServiceModel.HostNameComparisonMode); } set { } }
    [System.ComponentModel.DefaultValueAttribute((long)524288)]
    public long MaxBufferPoolSize { get { return default(long); } set { } }
    [System.ComponentModel.DefaultValueAttribute(65536)]
    public int MaxBufferSize { get { return default(int); } set { } }
    [System.ComponentModel.DefaultValueAttribute((long)65536)]
    public long MaxReceivedMessageSize { get { return default(long); } set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.UriTypeConverter))]
    public System.Uri ProxyAddress { get { return default(System.Uri); } set { } }
    public System.Xml.XmlDictionaryReaderQuotas ReaderQuotas { get { return default(System.Xml.XmlDictionaryReaderQuotas); } set { } }
    public override string Scheme { get { return default(string); } }
    bool System.ServiceModel.Channels.IBindingRuntimePreferences.ReceiveSynchronously { get { return default(bool); } }
    [System.ComponentModel.TypeConverterAttribute(typeof(System.ServiceModel.Configuration.EncodingConverter))]
    public System.Text.Encoding TextEncoding { get { return default(System.Text.Encoding); } set { } }
    [System.ComponentModel.DefaultValueAttribute((System.ServiceModel.TransferMode)(0))]
    public System.ServiceModel.TransferMode TransferMode { get { return default(System.ServiceModel.TransferMode); } set { } }
    [System.ComponentModel.DefaultValueAttribute(true)]
    public bool UseDefaultWebProxy { get { return default(bool); } set { } }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public bool ShouldSerializeReaderQuotas() { return default(bool); }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public bool ShouldSerializeTextEncoding() { return default(bool); }
  }
  public enum HttpClientCredentialType {
    Basic = 1,
    Certificate = 5,
    Digest = 2,
    InheritedFromHost = 6,
    None = 0,
    Ntlm = 3,
    Windows = 4,
  }
  public enum HttpProxyCredentialType {
    Basic = 1,
    Digest = 2,
    None = 0,
    Ntlm = 3,
    Windows = 4,
  }
  public sealed partial class HttpTransportSecurity {
    public HttpTransportSecurity() { }
    public System.ServiceModel.HttpClientCredentialType ClientCredentialType { get { return default(System.ServiceModel.HttpClientCredentialType); } set { } }
    public System.Security.Authentication.ExtendedProtection.ExtendedProtectionPolicy ExtendedProtectionPolicy { get { return default(System.Security.Authentication.ExtendedProtection.ExtendedProtectionPolicy); } set { } }
    public System.ServiceModel.HttpProxyCredentialType ProxyCredentialType { get { return default(System.ServiceModel.HttpProxyCredentialType); } set { } }
    public string Realm { get { return default(string); } set { } }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public bool ShouldSerializeClientCredentialType() { return default(bool); }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public bool ShouldSerializeExtendedProtectionPolicy() { return default(bool); }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public bool ShouldSerializeProxyCredentialType() { return default(bool); }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public bool ShouldSerializeRealm() { return default(bool); }
  }
  public partial interface IClientChannel : System.IDisposable, System.ServiceModel.Channels.IChannel, System.ServiceModel.ICommunicationObject, System.ServiceModel.IContextChannel, System.ServiceModel.IExtensibleObject<System.ServiceModel.IContextChannel> {
    bool AllowInitializationUI { get; set; }
    bool DidInteractiveInitialization { get; }
    System.Uri Via { get; }
    event System.EventHandler<System.ServiceModel.UnknownMessageReceivedEventArgs> UnknownMessageReceived;
    System.IAsyncResult BeginDisplayInitializationUI(System.AsyncCallback callback, object state);
    void DisplayInitializationUI();
    void EndDisplayInitializationUI(System.IAsyncResult result);
  }
  public partial interface ICommunicationObject {
    System.ServiceModel.CommunicationState State { get; }
    event System.EventHandler Closed;
    event System.EventHandler Closing;
    event System.EventHandler Faulted;
    event System.EventHandler Opened;
    event System.EventHandler Opening;
    void Abort();
    System.IAsyncResult BeginClose(System.AsyncCallback callback, object state);
    System.IAsyncResult BeginClose(System.TimeSpan timeout, System.AsyncCallback callback, object state);
    System.IAsyncResult BeginOpen(System.AsyncCallback callback, object state);
    System.IAsyncResult BeginOpen(System.TimeSpan timeout, System.AsyncCallback callback, object state);
    void Close();
    void Close(System.TimeSpan timeout);
    void EndClose(System.IAsyncResult result);
    void EndOpen(System.IAsyncResult result);
    void Open();
    void Open(System.TimeSpan timeout);
  }
  public partial interface IContextChannel : System.ServiceModel.Channels.IChannel, System.ServiceModel.ICommunicationObject, System.ServiceModel.IExtensibleObject<System.ServiceModel.IContextChannel> {
    bool AllowOutputBatching { get; set; }
    System.ServiceModel.Channels.IInputSession InputSession { get; }
    System.ServiceModel.EndpointAddress LocalAddress { get; }
    System.TimeSpan OperationTimeout { get; set; }
    System.ServiceModel.Channels.IOutputSession OutputSession { get; }
    System.ServiceModel.EndpointAddress RemoteAddress { get; }
    string SessionId { get; }
  }
  public partial interface IDefaultCommunicationTimeouts {
    System.TimeSpan CloseTimeout { get; }
    System.TimeSpan OpenTimeout { get; }
    System.TimeSpan ReceiveTimeout { get; }
    System.TimeSpan SendTimeout { get; }
  }
  public partial interface IDuplexContextChannel : System.ServiceModel.Channels.IChannel, System.ServiceModel.ICommunicationObject, System.ServiceModel.IContextChannel, System.ServiceModel.IExtensibleObject<System.ServiceModel.IContextChannel> {
    bool AutomaticInputSessionShutdown { get; set; }
    System.ServiceModel.InstanceContext CallbackInstance { get; set; }
    System.IAsyncResult BeginCloseOutputSession(System.TimeSpan timeout, System.AsyncCallback callback, object state);
    void CloseOutputSession(System.TimeSpan timeout);
    void EndCloseOutputSession(System.IAsyncResult result);
  }
  public partial interface IExtensibleObject<T> where T : System.ServiceModel.IExtensibleObject<T> {
    System.ServiceModel.IExtensionCollection<T> Extensions { get; }
  }
  public partial interface IExtension<T> where T : System.ServiceModel.IExtensibleObject<T> {
    void Attach(T owner);
    void Detach(T owner);
  }
  public partial interface IExtensionCollection<T> : System.Collections.Generic.ICollection<System.ServiceModel.IExtension<T>>, System.Collections.Generic.IEnumerable<System.ServiceModel.IExtension<T>>, System.Collections.IEnumerable where T : System.ServiceModel.IExtensibleObject<T> {
    E Find<E>();
    System.Collections.ObjectModel.Collection<E> FindAll<E>();
  }
  public enum ImpersonationOption {
    Allowed = 1,
    NotAllowed = 0,
    Required = 2,
  }
  public sealed partial class InstanceContext : System.ServiceModel.Channels.CommunicationObject, System.ServiceModel.IExtensibleObject<System.ServiceModel.InstanceContext> {
    public InstanceContext(object implementation) { }
    public InstanceContext(System.ServiceModel.ServiceHostBase host) { }
    public InstanceContext(System.ServiceModel.ServiceHostBase host, object implementation) { }
    protected override System.TimeSpan DefaultCloseTimeout { get { return default(System.TimeSpan); } }
    protected override System.TimeSpan DefaultOpenTimeout { get { return default(System.TimeSpan); } }
    public System.ServiceModel.IExtensionCollection<System.ServiceModel.InstanceContext> Extensions { get { return default(System.ServiceModel.IExtensionCollection<System.ServiceModel.InstanceContext>); } }
    public System.ServiceModel.ServiceHostBase Host { get { return default(System.ServiceModel.ServiceHostBase); } }
    public System.Collections.Generic.ICollection<System.ServiceModel.Channels.IChannel> IncomingChannels { get { return default(System.Collections.Generic.ICollection<System.ServiceModel.Channels.IChannel>); } }
    public int ManualFlowControlLimit { get { return default(int); } set { } }
    public System.Collections.Generic.ICollection<System.ServiceModel.Channels.IChannel> OutgoingChannels { get { return default(System.Collections.Generic.ICollection<System.ServiceModel.Channels.IChannel>); } }
    public System.Threading.SynchronizationContext SynchronizationContext { get { return default(System.Threading.SynchronizationContext); } set { } }
    public object GetServiceInstance() { return default(object); }
    public object GetServiceInstance(System.ServiceModel.Channels.Message message) { return default(object); }
    public int IncrementManualFlowControlLimit(int incrementBy) { return default(int); }
    protected override void OnAbort() { }
    protected override System.IAsyncResult OnBeginClose(System.TimeSpan timeout, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    protected override System.IAsyncResult OnBeginOpen(System.TimeSpan timeout, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    protected override void OnClose(System.TimeSpan timeout) { }
    protected override void OnClosed() { }
    protected override void OnEndClose(System.IAsyncResult result) { }
    protected override void OnEndOpen(System.IAsyncResult result) { }
    protected override void OnFaulted() { }
    protected override void OnOpen(System.TimeSpan timeout) { }
    protected override void OnOpened() { }
    protected override void OnOpening() { }
    public void ReleaseServiceInstance() { }
  }
  public enum InstanceContextMode {
    PerCall = 1,
    PerSession = 0,
    Single = 2,
  }
  public partial class InvalidMessageContractException : System.SystemException {
    public InvalidMessageContractException() { }
    protected InvalidMessageContractException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public InvalidMessageContractException(string message) { }
    public InvalidMessageContractException(string message, System.Exception innerException) { }
  }
  public partial interface IOnlineStatus {
    bool IsOnline { get; }
    event System.EventHandler Offline;
    event System.EventHandler Online;
  }
  public partial interface IServiceChannel : System.ServiceModel.Channels.IChannel, System.ServiceModel.ICommunicationObject, System.ServiceModel.IContextChannel, System.ServiceModel.IExtensibleObject<System.ServiceModel.IContextChannel> {
    System.Uri ListenUri { get; }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(384), Inherited=false)]
  public partial class MessageBodyMemberAttribute : System.ServiceModel.MessageContractMemberAttribute {
    public MessageBodyMemberAttribute() { }
    public int Order { get { return default(int); } set { } }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(12), AllowMultiple=false)]
  public sealed partial class MessageContractAttribute : System.Attribute {
    public MessageContractAttribute() { }
    public bool HasProtectionLevel { get { return default(bool); } }
    public bool IsWrapped { get { return default(bool); } set { } }
    public System.Net.Security.ProtectionLevel ProtectionLevel { get { return default(System.Net.Security.ProtectionLevel); } set { } }
    public string WrapperName { get { return default(string); } set { } }
    public string WrapperNamespace { get { return default(string); } set { } }
  }
  public abstract partial class MessageContractMemberAttribute : System.Attribute {
    protected MessageContractMemberAttribute() { }
    public bool HasProtectionLevel { get { return default(bool); } }
    public string Name { get { return default(string); } set { } }
    public string Namespace { get { return default(string); } set { } }
    public System.Net.Security.ProtectionLevel ProtectionLevel { get { return default(System.Net.Security.ProtectionLevel); } set { } }
  }
  public enum MessageCredentialType {
    Certificate = 3,
    IssuedToken = 4,
    None = 0,
    UserName = 2,
    Windows = 1,
  }
  public partial class MessageHeader<T> {
    public MessageHeader() { }
    public MessageHeader(T content) { }
    public MessageHeader(T content, bool mustUnderstand, string actor, bool relay) { }
    public string Actor { get { return default(string); } set { } }
    public T Content { get { return default(T); } set { } }
    public bool MustUnderstand { get { return default(bool); } set { } }
    public bool Relay { get { return default(bool); } set { } }
    public System.ServiceModel.Channels.MessageHeader GetUntypedHeader(string name, string ns) { return default(System.ServiceModel.Channels.MessageHeader); }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(384), AllowMultiple=false, Inherited=false)]
  public sealed partial class MessageHeaderArrayAttribute : System.ServiceModel.MessageHeaderAttribute {
    public MessageHeaderArrayAttribute() { }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(384), AllowMultiple=false, Inherited=false)]
  public partial class MessageHeaderAttribute : System.ServiceModel.MessageContractMemberAttribute {
    public MessageHeaderAttribute() { }
    public string Actor { get { return default(string); } set { } }
    public bool MustUnderstand { get { return default(bool); } set { } }
    public bool Relay { get { return default(bool); } set { } }
  }
  public partial class MessageHeaderException : System.ServiceModel.ProtocolException {
    public MessageHeaderException() { }
    protected MessageHeaderException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public MessageHeaderException(string message) { }
    public MessageHeaderException(string message, bool isDuplicate) { }
    public MessageHeaderException(string message, System.Exception innerException) { }
    public MessageHeaderException(string message, string headerName, string ns) { }
    public MessageHeaderException(string message, string headerName, string ns, bool isDuplicate) { }
    public MessageHeaderException(string message, string headerName, string ns, bool isDuplicate, System.Exception innerException) { }
    public MessageHeaderException(string message, string headerName, string ns, System.Exception innerException) { }
    public string HeaderName { get { return default(string); } }
    public string HeaderNamespace { get { return default(string); } }
    public bool IsDuplicate { get { return default(bool); } }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(10240), Inherited=false)]
  public sealed partial class MessageParameterAttribute : System.Attribute {
    public MessageParameterAttribute() { }
    public string Name { get { return default(string); } set { } }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(384), Inherited=false)]
  public sealed partial class MessagePropertyAttribute : System.Attribute {
    public MessagePropertyAttribute() { }
    public string Name { get { return default(string); } set { } }
  }
  public partial class MessageSecurityOverHttp {
    public MessageSecurityOverHttp() { }
    public System.ServiceModel.Security.SecurityAlgorithmSuite AlgorithmSuite { get { return default(System.ServiceModel.Security.SecurityAlgorithmSuite); } set { } }
    public System.ServiceModel.MessageCredentialType ClientCredentialType { get { return default(System.ServiceModel.MessageCredentialType); } set { } }
    public bool NegotiateServiceCredential { get { return default(bool); } set { } }
    protected virtual bool IsSecureConversationEnabled() { return default(bool); }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public bool ShouldSerializeAlgorithmSuite() { return default(bool); }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public bool ShouldSerializeClientCredentialType() { return default(bool); }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public bool ShouldSerializeNegotiateServiceCredential() { return default(bool); }
  }
  public sealed partial class MessageSecurityOverMsmq {
    public MessageSecurityOverMsmq() { }
    [System.ComponentModel.DefaultValueAttribute(typeof(System.ServiceModel.Security.SecurityAlgorithmSuite), "Default")]
    public System.ServiceModel.Security.SecurityAlgorithmSuite AlgorithmSuite { get { return default(System.ServiceModel.Security.SecurityAlgorithmSuite); } set { } }
    [System.ComponentModel.DefaultValueAttribute((System.ServiceModel.MessageCredentialType)(1))]
    public System.ServiceModel.MessageCredentialType ClientCredentialType { get { return default(System.ServiceModel.MessageCredentialType); } set { } }
  }
  public sealed partial class MessageSecurityOverTcp {
    public MessageSecurityOverTcp() { }
    [System.ComponentModel.DefaultValueAttribute(typeof(System.ServiceModel.Security.SecurityAlgorithmSuite), "Default")]
    public System.ServiceModel.Security.SecurityAlgorithmSuite AlgorithmSuite { get { return default(System.ServiceModel.Security.SecurityAlgorithmSuite); } set { } }
    [System.ComponentModel.DefaultValueAttribute((System.ServiceModel.MessageCredentialType)(1))]
    public System.ServiceModel.MessageCredentialType ClientCredentialType { get { return default(System.ServiceModel.MessageCredentialType); } set { } }
  }
  public abstract partial class MessageSecurityVersion {
    internal MessageSecurityVersion() { }
    public abstract System.ServiceModel.Security.BasicSecurityProfileVersion BasicSecurityProfileVersion { get; }
    public static System.ServiceModel.MessageSecurityVersion Default { get { return default(System.ServiceModel.MessageSecurityVersion); } }
    public System.ServiceModel.Security.SecureConversationVersion SecureConversationVersion { get { return default(System.ServiceModel.Security.SecureConversationVersion); } }
    public abstract System.ServiceModel.Security.SecurityPolicyVersion SecurityPolicyVersion { get; }
    public System.IdentityModel.Selectors.SecurityTokenVersion SecurityTokenVersion { get { return default(System.IdentityModel.Selectors.SecurityTokenVersion); } }
    public System.ServiceModel.Security.SecurityVersion SecurityVersion { get { return default(System.ServiceModel.Security.SecurityVersion); } }
    public System.ServiceModel.Security.TrustVersion TrustVersion { get { return default(System.ServiceModel.Security.TrustVersion); } }
    public static System.ServiceModel.MessageSecurityVersion WSSecurity10WSTrust13WSSecureConversation13WSSecurityPolicy12BasicSecurityProfile10 { get { return default(System.ServiceModel.MessageSecurityVersion); } }
    public static System.ServiceModel.MessageSecurityVersion WSSecurity10WSTrustFebruary2005WSSecureConversationFebruary2005WSSecurityPolicy11BasicSecurityProfile10 { get { return default(System.ServiceModel.MessageSecurityVersion); } }
    public static System.ServiceModel.MessageSecurityVersion WSSecurity11WSTrust13WSSecureConversation13WSSecurityPolicy12 { get { return default(System.ServiceModel.MessageSecurityVersion); } }
    public static System.ServiceModel.MessageSecurityVersion WSSecurity11WSTrust13WSSecureConversation13WSSecurityPolicy12BasicSecurityProfile10 { get { return default(System.ServiceModel.MessageSecurityVersion); } }
    public static System.ServiceModel.MessageSecurityVersion WSSecurity11WSTrustFebruary2005WSSecureConversationFebruary2005WSSecurityPolicy11 { get { return default(System.ServiceModel.MessageSecurityVersion); } }
    public static System.ServiceModel.MessageSecurityVersion WSSecurity11WSTrustFebruary2005WSSecureConversationFebruary2005WSSecurityPolicy11BasicSecurityProfile10 { get { return default(System.ServiceModel.MessageSecurityVersion); } }
  }
  public enum MsmqAuthenticationMode {
    Certificate = 2,
    None = 0,
    WindowsDomain = 1,
  }
  public abstract partial class MsmqBindingBase : System.ServiceModel.Channels.Binding, System.ServiceModel.Channels.IBindingRuntimePreferences {
    protected MsmqBindingBase() { }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Uri CustomDeadLetterQueue { get { return default(System.Uri); } set { } }
    [System.ComponentModel.DefaultValueAttribute((System.ServiceModel.DeadLetterQueue)(1))]
    public System.ServiceModel.DeadLetterQueue DeadLetterQueue { get { return default(System.ServiceModel.DeadLetterQueue); } set { } }
    [System.ComponentModel.DefaultValueAttribute(true)]
    public bool Durable { get { return default(bool); } set { } }
    [System.ComponentModel.DefaultValueAttribute(true)]
    public bool ExactlyOnce { get { return default(bool); } set { } }
    [System.ComponentModel.DefaultValueAttribute((long)65536)]
    public long MaxReceivedMessageSize { get { return default(long); } set { } }
    [System.ComponentModel.DefaultValueAttribute(2)]
    public int MaxRetryCycles { get { return default(int); } set { } }
    [System.ComponentModel.DefaultValueAttribute(true)]
    public bool ReceiveContextEnabled { get { return default(bool); } set { } }
    [System.ComponentModel.DefaultValueAttribute((System.ServiceModel.ReceiveErrorHandling)(0))]
    public System.ServiceModel.ReceiveErrorHandling ReceiveErrorHandling { get { return default(System.ServiceModel.ReceiveErrorHandling); } set { } }
    [System.ComponentModel.DefaultValueAttribute(5)]
    public int ReceiveRetryCount { get { return default(int); } set { } }
    [System.ComponentModel.DefaultValueAttribute(typeof(System.TimeSpan), "00:30:00")]
    public System.TimeSpan RetryCycleDelay { get { return default(System.TimeSpan); } set { } }
    public override string Scheme { get { return default(string); } }
    bool System.ServiceModel.Channels.IBindingRuntimePreferences.ReceiveSynchronously { get { return default(bool); } }
    [System.ComponentModel.DefaultValueAttribute(typeof(System.TimeSpan), "1.00:00:00")]
    public System.TimeSpan TimeToLive { get { return default(System.TimeSpan); } set { } }
    [System.ComponentModel.DefaultValueAttribute(false)]
    public bool UseMsmqTracing { get { return default(bool); } set { } }
    [System.ComponentModel.DefaultValueAttribute(false)]
    public bool UseSourceJournal { get { return default(bool); } set { } }
    [System.ComponentModel.DefaultValueAttribute(typeof(System.TimeSpan), "00:05:00")]
    public System.TimeSpan ValidityDuration { get { return default(System.TimeSpan); } set { } }
  }
  public enum MsmqEncryptionAlgorithm {
    Aes = 1,
    RC4Stream = 0,
  }
  public partial class MsmqException : System.Runtime.InteropServices.ExternalException {
    public MsmqException() { }
    protected MsmqException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public MsmqException(string message) { }
    public MsmqException(string message, System.Exception inner) { }
    public MsmqException(string message, int error) { }
  }
  public partial class MsmqPoisonMessageException : System.ServiceModel.PoisonMessageException {
    public MsmqPoisonMessageException() { }
    public MsmqPoisonMessageException(long messageLookupId) { }
    public MsmqPoisonMessageException(long messageLookupId, System.Exception innerException) { }
    protected MsmqPoisonMessageException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public MsmqPoisonMessageException(string message) { }
    public MsmqPoisonMessageException(string message, System.Exception innerException) { }
    public long MessageLookupId { get { return default(long); } }
    [System.Security.SecurityCriticalAttribute]
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, SerializationFormatter=true)]
    public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
  }
  public enum MsmqSecureHashAlgorithm {
    MD5 = 0,
    Sha1 = 1,
    Sha256 = 2,
    Sha512 = 3,
  }
  public sealed partial class MsmqTransportSecurity {
    public MsmqTransportSecurity() { }
    public MsmqTransportSecurity(System.ServiceModel.MsmqTransportSecurity other) { }
    [System.ComponentModel.DefaultValueAttribute((System.ServiceModel.MsmqAuthenticationMode)(1))]
    public System.ServiceModel.MsmqAuthenticationMode MsmqAuthenticationMode { get { return default(System.ServiceModel.MsmqAuthenticationMode); } set { } }
    [System.ComponentModel.DefaultValueAttribute((System.ServiceModel.MsmqEncryptionAlgorithm)(0))]
    public System.ServiceModel.MsmqEncryptionAlgorithm MsmqEncryptionAlgorithm { get { return default(System.ServiceModel.MsmqEncryptionAlgorithm); } set { } }
    [System.ComponentModel.DefaultValueAttribute((System.Net.Security.ProtectionLevel)(1))]
    public System.Net.Security.ProtectionLevel MsmqProtectionLevel { get { return default(System.Net.Security.ProtectionLevel); } set { } }
    [System.ComponentModel.DefaultValueAttribute((System.ServiceModel.MsmqSecureHashAlgorithm)(1))]
    public System.ServiceModel.MsmqSecureHashAlgorithm MsmqSecureHashAlgorithm { get { return default(System.ServiceModel.MsmqSecureHashAlgorithm); } set { } }
  }
  public sealed partial class NamedPipeTransportSecurity {
    public NamedPipeTransportSecurity() { }
    [System.ComponentModel.DefaultValueAttribute((System.Net.Security.ProtectionLevel)(2))]
    public System.Net.Security.ProtectionLevel ProtectionLevel { get { return default(System.Net.Security.ProtectionLevel); } set { } }
  }
  public partial class NetHttpBinding : System.ServiceModel.HttpBindingBase {
    public NetHttpBinding() { }
    public NetHttpBinding(System.ServiceModel.BasicHttpSecurityMode securityMode) { }
    public NetHttpBinding(System.ServiceModel.BasicHttpSecurityMode securityMode, bool reliableSessionEnabled) { }
    public NetHttpBinding(string configurationName) { }
    [System.ComponentModel.DefaultValueAttribute((System.ServiceModel.NetHttpMessageEncoding)(0))]
    public System.ServiceModel.NetHttpMessageEncoding MessageEncoding { get { return default(System.ServiceModel.NetHttpMessageEncoding); } set { } }
    public System.ServiceModel.OptionalReliableSession ReliableSession { get { return default(System.ServiceModel.OptionalReliableSession); } set { } }
    public System.ServiceModel.BasicHttpSecurity Security { get { return default(System.ServiceModel.BasicHttpSecurity); } set { } }
    public System.ServiceModel.Channels.WebSocketTransportSettings WebSocketSettings { get { return default(System.ServiceModel.Channels.WebSocketTransportSettings); } }
    public override System.ServiceModel.Channels.IChannelFactory<TChannel> BuildChannelFactory<TChannel>(System.ServiceModel.Channels.BindingParameterCollection parameters) { return default(System.ServiceModel.Channels.IChannelFactory<TChannel>); }
    public override System.ServiceModel.Channels.BindingElementCollection CreateBindingElements() { return default(System.ServiceModel.Channels.BindingElementCollection); }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public bool ShouldSerializeReliableSession() { return default(bool); }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public bool ShouldSerializeSecurity() { return default(bool); }
  }
  public enum NetHttpMessageEncoding {
    Binary = 0,
    Mtom = 2,
    Text = 1,
  }
  public partial class NetHttpsBinding : System.ServiceModel.HttpBindingBase {
    public NetHttpsBinding() { }
    public NetHttpsBinding(System.ServiceModel.BasicHttpsSecurityMode securityMode) { }
    public NetHttpsBinding(System.ServiceModel.BasicHttpsSecurityMode securityMode, bool reliableSessionEnabled) { }
    public NetHttpsBinding(string configurationName) { }
    [System.ComponentModel.DefaultValueAttribute((System.ServiceModel.NetHttpMessageEncoding)(0))]
    public System.ServiceModel.NetHttpMessageEncoding MessageEncoding { get { return default(System.ServiceModel.NetHttpMessageEncoding); } set { } }
    public System.ServiceModel.OptionalReliableSession ReliableSession { get { return default(System.ServiceModel.OptionalReliableSession); } set { } }
    public System.ServiceModel.BasicHttpsSecurity Security { get { return default(System.ServiceModel.BasicHttpsSecurity); } set { } }
    public System.ServiceModel.Channels.WebSocketTransportSettings WebSocketSettings { get { return default(System.ServiceModel.Channels.WebSocketTransportSettings); } }
    public override System.ServiceModel.Channels.IChannelFactory<TChannel> BuildChannelFactory<TChannel>(System.ServiceModel.Channels.BindingParameterCollection parameters) { return default(System.ServiceModel.Channels.IChannelFactory<TChannel>); }
    public override System.ServiceModel.Channels.BindingElementCollection CreateBindingElements() { return default(System.ServiceModel.Channels.BindingElementCollection); }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public bool ShouldSerializeReliableSession() { return default(bool); }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public bool ShouldSerializeSecurity() { return default(bool); }
  }
  public partial class NetMsmqBinding : System.ServiceModel.MsmqBindingBase {
    public NetMsmqBinding() { }
    public NetMsmqBinding(System.ServiceModel.NetMsmqSecurityMode securityMode) { }
    public NetMsmqBinding(string configurationName) { }
    public System.ServiceModel.EnvelopeVersion EnvelopeVersion { get { return default(System.ServiceModel.EnvelopeVersion); } }
    [System.ComponentModel.DefaultValueAttribute((long)524288)]
    public long MaxBufferPoolSize { get { return default(long); } set { } }
    [System.ComponentModel.DefaultValueAttribute((System.ServiceModel.QueueTransferProtocol)(0))]
    public System.ServiceModel.QueueTransferProtocol QueueTransferProtocol { get { return default(System.ServiceModel.QueueTransferProtocol); } set { } }
    public System.Xml.XmlDictionaryReaderQuotas ReaderQuotas { get { return default(System.Xml.XmlDictionaryReaderQuotas); } set { } }
    public System.ServiceModel.NetMsmqSecurity Security { get { return default(System.ServiceModel.NetMsmqSecurity); } set { } }
    [System.ComponentModel.DefaultValueAttribute(false)]
    public bool UseActiveDirectory { get { return default(bool); } set { } }
    public override System.ServiceModel.Channels.BindingElementCollection CreateBindingElements() { return default(System.ServiceModel.Channels.BindingElementCollection); }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public bool ShouldSerializeReaderQuotas() { return default(bool); }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public bool ShouldSerializeSecurity() { return default(bool); }
  }
  public sealed partial class NetMsmqSecurity {
    public NetMsmqSecurity() { }
    public System.ServiceModel.MessageSecurityOverMsmq Message { get { return default(System.ServiceModel.MessageSecurityOverMsmq); } set { } }
    [System.ComponentModel.DefaultValueAttribute((System.ServiceModel.NetMsmqSecurityMode)(1))]
    public System.ServiceModel.NetMsmqSecurityMode Mode { get { return default(System.ServiceModel.NetMsmqSecurityMode); } set { } }
    public System.ServiceModel.MsmqTransportSecurity Transport { get { return default(System.ServiceModel.MsmqTransportSecurity); } set { } }
  }
  public enum NetMsmqSecurityMode {
    Both = 3,
    Message = 2,
    None = 0,
    Transport = 1,
  }
  public partial class NetNamedPipeBinding : System.ServiceModel.Channels.Binding, System.ServiceModel.Channels.IBindingRuntimePreferences {
    public NetNamedPipeBinding() { }
    public NetNamedPipeBinding(System.ServiceModel.NetNamedPipeSecurityMode securityMode) { }
    public NetNamedPipeBinding(string configurationName) { }
    public System.ServiceModel.EnvelopeVersion EnvelopeVersion { get { return default(System.ServiceModel.EnvelopeVersion); } }
    [System.ComponentModel.DefaultValueAttribute((System.ServiceModel.HostNameComparisonMode)(0))]
    public System.ServiceModel.HostNameComparisonMode HostNameComparisonMode { get { return default(System.ServiceModel.HostNameComparisonMode); } set { } }
    [System.ComponentModel.DefaultValueAttribute((long)524288)]
    public long MaxBufferPoolSize { get { return default(long); } set { } }
    [System.ComponentModel.DefaultValueAttribute(65536)]
    public int MaxBufferSize { get { return default(int); } set { } }
    public int MaxConnections { get { return default(int); } set { } }
    [System.ComponentModel.DefaultValueAttribute((long)65536)]
    public long MaxReceivedMessageSize { get { return default(long); } set { } }
    public System.Xml.XmlDictionaryReaderQuotas ReaderQuotas { get { return default(System.Xml.XmlDictionaryReaderQuotas); } set { } }
    public override string Scheme { get { return default(string); } }
    public System.ServiceModel.NetNamedPipeSecurity Security { get { return default(System.ServiceModel.NetNamedPipeSecurity); } set { } }
    bool System.ServiceModel.Channels.IBindingRuntimePreferences.ReceiveSynchronously { get { return default(bool); } }
    [System.ComponentModel.DefaultValueAttribute(false)]
    public bool TransactionFlow { get { return default(bool); } set { } }
    public System.ServiceModel.TransactionProtocol TransactionProtocol { get { return default(System.ServiceModel.TransactionProtocol); } set { } }
    [System.ComponentModel.DefaultValueAttribute((System.ServiceModel.TransferMode)(0))]
    public System.ServiceModel.TransferMode TransferMode { get { return default(System.ServiceModel.TransferMode); } set { } }
    public override System.ServiceModel.Channels.BindingElementCollection CreateBindingElements() { return default(System.ServiceModel.Channels.BindingElementCollection); }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public bool ShouldSerializeMaxConnections() { return default(bool); }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public bool ShouldSerializeReaderQuotas() { return default(bool); }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public bool ShouldSerializeSecurity() { return default(bool); }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public bool ShouldSerializeTransactionProtocol() { return default(bool); }
  }
  public sealed partial class NetNamedPipeSecurity {
    public NetNamedPipeSecurity() { }
    [System.ComponentModel.DefaultValueAttribute((System.ServiceModel.NetNamedPipeSecurityMode)(1))]
    public System.ServiceModel.NetNamedPipeSecurityMode Mode { get { return default(System.ServiceModel.NetNamedPipeSecurityMode); } set { } }
    public System.ServiceModel.NamedPipeTransportSecurity Transport { get { return default(System.ServiceModel.NamedPipeTransportSecurity); } set { } }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public bool ShouldSerializeTransport() { return default(bool); }
  }
  public enum NetNamedPipeSecurityMode {
    None = 0,
    Transport = 1,
  }
  [System.ObsoleteAttribute("PeerChannel feature is obsolete and will be removed in the future.", false)]
  public partial class NetPeerTcpBinding : System.ServiceModel.Channels.Binding, System.ServiceModel.Channels.IBindingRuntimePreferences {
    public NetPeerTcpBinding() { }
    public NetPeerTcpBinding(string configurationName) { }
    public System.ServiceModel.EnvelopeVersion EnvelopeVersion { get { return default(System.ServiceModel.EnvelopeVersion); } }
    public static bool IsPnrpAvailable { get { return default(bool); } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.ServiceModel.Configuration.PeerTransportListenAddressConverter))]
    public System.Net.IPAddress ListenIPAddress { get { return default(System.Net.IPAddress); } set { } }
    [System.ComponentModel.DefaultValueAttribute((long)524288)]
    public long MaxBufferPoolSize { get { return default(long); } set { } }
    [System.ComponentModel.DefaultValueAttribute((long)65536)]
    public long MaxReceivedMessageSize { get { return default(long); } set { } }
    [System.ComponentModel.DefaultValueAttribute(0)]
    public int Port { get { return default(int); } set { } }
    public System.Xml.XmlDictionaryReaderQuotas ReaderQuotas { get { return default(System.Xml.XmlDictionaryReaderQuotas); } set { } }
    public System.ServiceModel.PeerResolvers.PeerResolverSettings Resolver { get { return default(System.ServiceModel.PeerResolvers.PeerResolverSettings); } }
    public override string Scheme { get { return default(string); } }
    public System.ServiceModel.PeerSecuritySettings Security { get { return default(System.ServiceModel.PeerSecuritySettings); } set { } }
    bool System.ServiceModel.Channels.IBindingRuntimePreferences.ReceiveSynchronously { get { return default(bool); } }
    public override System.ServiceModel.Channels.BindingElementCollection CreateBindingElements() { return default(System.ServiceModel.Channels.BindingElementCollection); }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public bool ShouldSerializeReaderQuotas() { return default(bool); }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public bool ShouldSerializeSecurity() { return default(bool); }
  }
  public partial class NetTcpBinding : System.ServiceModel.Channels.Binding, System.ServiceModel.Channels.IBindingRuntimePreferences {
    public NetTcpBinding() { }
    public NetTcpBinding(System.ServiceModel.SecurityMode securityMode) { }
    public NetTcpBinding(System.ServiceModel.SecurityMode securityMode, bool reliableSessionEnabled) { }
    public NetTcpBinding(string configurationName) { }
    public System.ServiceModel.EnvelopeVersion EnvelopeVersion { get { return default(System.ServiceModel.EnvelopeVersion); } }
    [System.ComponentModel.DefaultValueAttribute((System.ServiceModel.HostNameComparisonMode)(0))]
    public System.ServiceModel.HostNameComparisonMode HostNameComparisonMode { get { return default(System.ServiceModel.HostNameComparisonMode); } set { } }
    public int ListenBacklog { get { return default(int); } set { } }
    [System.ComponentModel.DefaultValueAttribute((long)524288)]
    public long MaxBufferPoolSize { get { return default(long); } set { } }
    [System.ComponentModel.DefaultValueAttribute(65536)]
    public int MaxBufferSize { get { return default(int); } set { } }
    public int MaxConnections { get { return default(int); } set { } }
    [System.ComponentModel.DefaultValueAttribute((long)65536)]
    public long MaxReceivedMessageSize { get { return default(long); } set { } }
    [System.ComponentModel.DefaultValueAttribute(false)]
    public bool PortSharingEnabled { get { return default(bool); } set { } }
    public System.Xml.XmlDictionaryReaderQuotas ReaderQuotas { get { return default(System.Xml.XmlDictionaryReaderQuotas); } set { } }
    public System.ServiceModel.OptionalReliableSession ReliableSession { get { return default(System.ServiceModel.OptionalReliableSession); } set { } }
    public override string Scheme { get { return default(string); } }
    public System.ServiceModel.NetTcpSecurity Security { get { return default(System.ServiceModel.NetTcpSecurity); } set { } }
    bool System.ServiceModel.Channels.IBindingRuntimePreferences.ReceiveSynchronously { get { return default(bool); } }
    [System.ComponentModel.DefaultValueAttribute(false)]
    public bool TransactionFlow { get { return default(bool); } set { } }
    public System.ServiceModel.TransactionProtocol TransactionProtocol { get { return default(System.ServiceModel.TransactionProtocol); } set { } }
    [System.ComponentModel.DefaultValueAttribute((System.ServiceModel.TransferMode)(0))]
    public System.ServiceModel.TransferMode TransferMode { get { return default(System.ServiceModel.TransferMode); } set { } }
    public override System.ServiceModel.Channels.BindingElementCollection CreateBindingElements() { return default(System.ServiceModel.Channels.BindingElementCollection); }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public bool ShouldSerializeListenBacklog() { return default(bool); }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public bool ShouldSerializeMaxConnections() { return default(bool); }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public bool ShouldSerializeReaderQuotas() { return default(bool); }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public bool ShouldSerializeReliableSession() { return default(bool); }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public bool ShouldSerializeSecurity() { return default(bool); }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public bool ShouldSerializeTransactionProtocol() { return default(bool); }
  }
  [System.Runtime.CompilerServices.TypeForwardedFromAttribute("System.WorkflowServices, Version=3.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35")]
  public partial class NetTcpContextBinding : System.ServiceModel.NetTcpBinding {
    public NetTcpContextBinding() { }
    public NetTcpContextBinding(System.ServiceModel.SecurityMode securityMode) { }
    public NetTcpContextBinding(System.ServiceModel.SecurityMode securityMode, bool reliableSessionEnabled) { }
    public NetTcpContextBinding(string configName) { }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Uri ClientCallbackAddress { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Uri); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(true)]
    public bool ContextManagementEnabled { get { return default(bool); } set { } }
    [System.ComponentModel.DefaultValueAttribute((System.Net.Security.ProtectionLevel)(1))]
    public System.Net.Security.ProtectionLevel ContextProtectionLevel { get { return default(System.Net.Security.ProtectionLevel); } set { } }
    public override System.ServiceModel.Channels.BindingElementCollection CreateBindingElements() { return default(System.ServiceModel.Channels.BindingElementCollection); }
  }
  public sealed partial class NetTcpSecurity {
    public NetTcpSecurity() { }
    public System.ServiceModel.MessageSecurityOverTcp Message { get { return default(System.ServiceModel.MessageSecurityOverTcp); } set { } }
    [System.ComponentModel.DefaultValueAttribute((System.ServiceModel.SecurityMode)(1))]
    public System.ServiceModel.SecurityMode Mode { get { return default(System.ServiceModel.SecurityMode); } set { } }
    public System.ServiceModel.TcpTransportSecurity Transport { get { return default(System.ServiceModel.TcpTransportSecurity); } set { } }
  }
  public sealed partial class NonDualMessageSecurityOverHttp : System.ServiceModel.MessageSecurityOverHttp {
    public NonDualMessageSecurityOverHttp() { }
    public bool EstablishSecurityContext { get { return default(bool); } set { } }
    protected override bool IsSecureConversationEnabled() { return default(bool); }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(64))]
  public sealed partial class OperationBehaviorAttribute : System.Attribute, System.ServiceModel.Description.IOperationBehavior {
    public OperationBehaviorAttribute() { }
    public bool AutoDisposeParameters { get { return default(bool); } set { } }
    public System.ServiceModel.ImpersonationOption Impersonation { get { return default(System.ServiceModel.ImpersonationOption); } set { } }
    public System.ServiceModel.ReleaseInstanceMode ReleaseInstanceMode { get { return default(System.ServiceModel.ReleaseInstanceMode); } set { } }
    public bool TransactionAutoComplete { get { return default(bool); } set { } }
    public bool TransactionScopeRequired { get { return default(bool); } set { } }
    void System.ServiceModel.Description.IOperationBehavior.AddBindingParameters(System.ServiceModel.Description.OperationDescription description, System.ServiceModel.Channels.BindingParameterCollection parameters) { }
    void System.ServiceModel.Description.IOperationBehavior.ApplyClientBehavior(System.ServiceModel.Description.OperationDescription description, System.ServiceModel.Dispatcher.ClientOperation proxy) { }
    void System.ServiceModel.Description.IOperationBehavior.ApplyDispatchBehavior(System.ServiceModel.Description.OperationDescription description, System.ServiceModel.Dispatcher.DispatchOperation dispatch) { }
    void System.ServiceModel.Description.IOperationBehavior.Validate(System.ServiceModel.Description.OperationDescription description) { }
  }
  public sealed partial class OperationContext : System.ServiceModel.IExtensibleObject<System.ServiceModel.OperationContext> {
    public OperationContext(System.ServiceModel.IContextChannel channel) { }
    public System.ServiceModel.IContextChannel Channel { get { return default(System.ServiceModel.IContextChannel); } }
    public System.Security.Claims.ClaimsPrincipal ClaimsPrincipal { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Security.Claims.ClaimsPrincipal); } }
    public static System.ServiceModel.OperationContext Current { get { return default(System.ServiceModel.OperationContext); } set { } }
    public System.ServiceModel.Dispatcher.EndpointDispatcher EndpointDispatcher { get { return default(System.ServiceModel.Dispatcher.EndpointDispatcher); } set { } }
    public System.ServiceModel.IExtensionCollection<System.ServiceModel.OperationContext> Extensions { get { return default(System.ServiceModel.IExtensionCollection<System.ServiceModel.OperationContext>); } }
    public bool HasSupportingTokens { get { return default(bool); } }
    public System.ServiceModel.ServiceHostBase Host { get { return default(System.ServiceModel.ServiceHostBase); } }
    public System.ServiceModel.Channels.MessageHeaders IncomingMessageHeaders { get { return default(System.ServiceModel.Channels.MessageHeaders); } }
    public System.ServiceModel.Channels.MessageProperties IncomingMessageProperties { get { return default(System.ServiceModel.Channels.MessageProperties); } }
    public System.ServiceModel.Channels.MessageVersion IncomingMessageVersion { get { return default(System.ServiceModel.Channels.MessageVersion); } }
    public System.ServiceModel.InstanceContext InstanceContext { get { return default(System.ServiceModel.InstanceContext); } }
    public bool IsUserContext { get { return default(bool); } }
    public System.ServiceModel.Channels.MessageHeaders OutgoingMessageHeaders { get { return default(System.ServiceModel.Channels.MessageHeaders); } }
    public System.ServiceModel.Channels.MessageProperties OutgoingMessageProperties { get { return default(System.ServiceModel.Channels.MessageProperties); } }
    public System.ServiceModel.Channels.RequestContext RequestContext { get { return default(System.ServiceModel.Channels.RequestContext); } set { } }
    public System.ServiceModel.ServiceSecurityContext ServiceSecurityContext { get { return default(System.ServiceModel.ServiceSecurityContext); } }
    public string SessionId { get { return default(string); } }
    public System.Collections.Generic.ICollection<System.ServiceModel.Security.SupportingTokenSpecification> SupportingTokens { get { return default(System.Collections.Generic.ICollection<System.ServiceModel.Security.SupportingTokenSpecification>); } }
    public event System.EventHandler OperationCompleted { add { } remove { } }
    public T GetCallbackChannel<T>() { return default(T); }
    public void SetTransactionComplete() { }
  }
  public sealed partial class OperationContextScope : System.IDisposable {
    public OperationContextScope(System.ServiceModel.IContextChannel channel) { }
    public OperationContextScope(System.ServiceModel.OperationContext context) { }
    public void Dispose() { }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(64))]
  public sealed partial class OperationContractAttribute : System.Attribute {
    public OperationContractAttribute() { }
    public string Action { get { return default(string); } set { } }
    public bool AsyncPattern { get { return default(bool); } set { } }
    public bool HasProtectionLevel { get { return default(bool); } }
    public bool IsInitiating { get { return default(bool); } set { } }
    public bool IsOneWay { get { return default(bool); } set { } }
    public bool IsTerminating { get { return default(bool); } set { } }
    public string Name { get { return default(string); } set { } }
    public System.Net.Security.ProtectionLevel ProtectionLevel { get { return default(System.Net.Security.ProtectionLevel); } set { } }
    public string ReplyAction { get { return default(string); } set { } }
  }
  public enum OperationFormatStyle {
    Document = 0,
    Rpc = 1,
  }
  public enum OperationFormatUse {
    Encoded = 1,
    Literal = 0,
  }
  public partial class OptionalReliableSession : System.ServiceModel.ReliableSession {
    public OptionalReliableSession() { }
    public OptionalReliableSession(System.ServiceModel.Channels.ReliableSessionBindingElement reliableSessionBindingElement) { }
    public bool Enabled { get { return default(bool); } set { } }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(384), AllowMultiple=false, Inherited=false)]
  public sealed partial class PeerHopCountAttribute : System.ServiceModel.MessageHeaderAttribute {
    public PeerHopCountAttribute() { }
    public new string Actor { get { return default(string); } }
    public new bool MustUnderstand { get { return default(bool); } }
    public new string Name { get { return default(string); } }
    public new string Namespace { get { return default(string); } }
    public new System.Net.Security.ProtectionLevel ProtectionLevel { get { return default(System.Net.Security.ProtectionLevel); } }
    public new bool Relay { get { return default(bool); } }
  }
  public enum PeerMessageOrigination {
    Local = 0,
    Remote = 1,
  }
  public enum PeerMessagePropagation {
    Local = 1,
    LocalAndRemote = 3,
    None = 0,
    Remote = 2,
  }
  public abstract partial class PeerMessagePropagationFilter {
    protected PeerMessagePropagationFilter() { }
    public abstract System.ServiceModel.PeerMessagePropagation ShouldMessagePropagate(System.ServiceModel.Channels.Message message, System.ServiceModel.PeerMessageOrigination origination);
  }
  public sealed partial class PeerNode : System.ServiceModel.IOnlineStatus {
    internal PeerNode() { }
    public bool IsOnline { get { return default(bool); } }
    public System.ServiceModel.PeerMessagePropagationFilter MessagePropagationFilter { get { return default(System.ServiceModel.PeerMessagePropagationFilter); } set { } }
    public int Port { get { return default(int); } }
    public event System.EventHandler Offline { add { } remove { } }
    public event System.EventHandler Online { add { } remove { } }
    public void RefreshConnection() { }
    public override string ToString() { return default(string); }
  }
  [System.Runtime.Serialization.DataContractAttribute(Name="PeerNodeAddress", Namespace="http://schemas.microsoft.com/net/2006/05/peer")]
  [System.Runtime.Serialization.KnownTypeAttribute(typeof(System.Net.IPAddress[]))]
  public sealed partial class PeerNodeAddress {
    public PeerNodeAddress(System.ServiceModel.EndpointAddress endpointAddress, System.Collections.ObjectModel.ReadOnlyCollection<System.Net.IPAddress> ipAddresses) { }
    public System.ServiceModel.EndpointAddress EndpointAddress { get { return default(System.ServiceModel.EndpointAddress); } }
    public System.Collections.ObjectModel.ReadOnlyCollection<System.Net.IPAddress> IPAddresses { get { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.Net.IPAddress>); } }
  }
  public abstract partial class PeerResolver {
    protected PeerResolver() { }
    public abstract bool CanShareReferrals { get; }
    public virtual void Initialize(System.ServiceModel.EndpointAddress address, System.ServiceModel.Channels.Binding binding, System.ServiceModel.Description.ClientCredentials credentials, System.ServiceModel.PeerResolvers.PeerReferralPolicy referralPolicy) { }
    public abstract object Register(string meshId, System.ServiceModel.PeerNodeAddress nodeAddress, System.TimeSpan timeout);
    public abstract System.Collections.ObjectModel.ReadOnlyCollection<System.ServiceModel.PeerNodeAddress> Resolve(string meshId, int maxAddresses, System.TimeSpan timeout);
    public abstract void Unregister(object registrationId, System.TimeSpan timeout);
    public abstract void Update(object registrationId, System.ServiceModel.PeerNodeAddress updatedNodeAddress, System.TimeSpan timeout);
  }
  public sealed partial class PeerSecuritySettings {
    public PeerSecuritySettings() { }
    public System.ServiceModel.SecurityMode Mode { get { return default(System.ServiceModel.SecurityMode); } set { } }
    public System.ServiceModel.PeerTransportSecuritySettings Transport { get { return default(System.ServiceModel.PeerTransportSecuritySettings); } set { } }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public bool ShouldSerializeMode() { return default(bool); }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public bool ShouldSerializeTransport() { return default(bool); }
  }
  public enum PeerTransportCredentialType {
    Certificate = 1,
    Password = 0,
  }
  public sealed partial class PeerTransportSecuritySettings {
    public PeerTransportSecuritySettings() { }
    public System.ServiceModel.PeerTransportCredentialType CredentialType { get { return default(System.ServiceModel.PeerTransportCredentialType); } set { } }
  }
  public partial class PoisonMessageException : System.ServiceModel.CommunicationException {
    public PoisonMessageException() { }
    protected PoisonMessageException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public PoisonMessageException(string message) { }
    public PoisonMessageException(string message, System.Exception innerException) { }
  }
  public partial class ProtocolException : System.ServiceModel.CommunicationException {
    public ProtocolException() { }
    protected ProtocolException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public ProtocolException(string message) { }
    public ProtocolException(string message, System.Exception innerException) { }
  }
  public enum QueuedDeliveryRequirementsMode {
    Allowed = 0,
    NotAllowed = 2,
    Required = 1,
  }
  public enum QueueTransferProtocol {
    Native = 0,
    Srmp = 1,
    SrmpSecure = 2,
  }
  public partial class QuotaExceededException : System.SystemException {
    public QuotaExceededException() { }
    protected QuotaExceededException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public QuotaExceededException(string message) { }
    public QuotaExceededException(string message, System.Exception innerException) { }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(64))]
  public sealed partial class ReceiveContextEnabledAttribute : System.Attribute, System.ServiceModel.Description.IOperationBehavior {
    public ReceiveContextEnabledAttribute() { }
    public bool ManualControl { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public void AddBindingParameters(System.ServiceModel.Description.OperationDescription operationDescription, System.ServiceModel.Channels.BindingParameterCollection bindingParameters) { }
    public void ApplyClientBehavior(System.ServiceModel.Description.OperationDescription operationDescription, System.ServiceModel.Dispatcher.ClientOperation clientOperation) { }
    public void ApplyDispatchBehavior(System.ServiceModel.Description.OperationDescription operationDescription, System.ServiceModel.Dispatcher.DispatchOperation dispatchOperation) { }
    public void Validate(System.ServiceModel.Description.OperationDescription operationDescription) { }
  }
  public enum ReceiveErrorHandling {
    Drop = 1,
    Fault = 0,
    Move = 3,
    Reject = 2,
  }
  public enum ReleaseInstanceMode {
    AfterCall = 2,
    BeforeAndAfterCall = 3,
    BeforeCall = 1,
    None = 0,
  }
  [System.ComponentModel.TypeConverterAttribute(typeof(System.ServiceModel.Configuration.ReliableMessagingVersionConverter))]
  public abstract partial class ReliableMessagingVersion {
    internal ReliableMessagingVersion() { }
    public static System.ServiceModel.ReliableMessagingVersion Default { get { return default(System.ServiceModel.ReliableMessagingVersion); } }
    public static System.ServiceModel.ReliableMessagingVersion WSReliableMessaging11 { get { return default(System.ServiceModel.ReliableMessagingVersion); } }
    public static System.ServiceModel.ReliableMessagingVersion WSReliableMessagingFebruary2005 { get { return default(System.ServiceModel.ReliableMessagingVersion); } }
  }
  public partial class ReliableSession {
    public ReliableSession() { }
    public ReliableSession(System.ServiceModel.Channels.ReliableSessionBindingElement reliableSessionBindingElement) { }
    public System.TimeSpan InactivityTimeout { get { return default(System.TimeSpan); } set { } }
    [System.ComponentModel.DefaultValueAttribute(true)]
    public bool Ordered { get { return default(bool); } set { } }
  }
  public partial class RsaEndpointIdentity : System.ServiceModel.EndpointIdentity {
    public RsaEndpointIdentity(System.IdentityModel.Claims.Claim identity) { }
    public RsaEndpointIdentity(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate) { }
    public RsaEndpointIdentity(string publicKey) { }
  }
  public enum SecurityMode {
    Message = 2,
    None = 0,
    Transport = 1,
    TransportWithMessageCredential = 3,
  }
  public partial class ServerTooBusyException : System.ServiceModel.CommunicationException {
    public ServerTooBusyException() { }
    protected ServerTooBusyException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public ServerTooBusyException(string message) { }
    public ServerTooBusyException(string message, System.Exception innerException) { }
  }
  public partial class ServiceActivationException : System.ServiceModel.CommunicationException {
    public ServiceActivationException() { }
    protected ServiceActivationException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public ServiceActivationException(string message) { }
    public ServiceActivationException(string message, System.Exception innerException) { }
  }
  public partial class ServiceAuthenticationManager {
    public ServiceAuthenticationManager() { }
    public virtual System.Collections.ObjectModel.ReadOnlyCollection<System.IdentityModel.Policy.IAuthorizationPolicy> Authenticate(System.Collections.ObjectModel.ReadOnlyCollection<System.IdentityModel.Policy.IAuthorizationPolicy> authPolicy, System.Uri listenUri, ref System.ServiceModel.Channels.Message message) { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.IdentityModel.Policy.IAuthorizationPolicy>); }
  }
  public partial class ServiceAuthorizationManager {
    public ServiceAuthorizationManager() { }
    public virtual bool CheckAccess(System.ServiceModel.OperationContext operationContext) { return default(bool); }
    public virtual bool CheckAccess(System.ServiceModel.OperationContext operationContext, ref System.ServiceModel.Channels.Message message) { return default(bool); }
    protected virtual bool CheckAccessCore(System.ServiceModel.OperationContext operationContext) { return default(bool); }
    protected virtual System.Collections.ObjectModel.ReadOnlyCollection<System.IdentityModel.Policy.IAuthorizationPolicy> GetAuthorizationPolicies(System.ServiceModel.OperationContext operationContext) { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.IdentityModel.Policy.IAuthorizationPolicy>); }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(4))]
  public sealed partial class ServiceBehaviorAttribute : System.Attribute, System.ServiceModel.Description.IServiceBehavior {
    public ServiceBehaviorAttribute() { }
    [System.ComponentModel.DefaultValueAttribute((System.ServiceModel.AddressFilterMode)(0))]
    public System.ServiceModel.AddressFilterMode AddressFilterMode { get { return default(System.ServiceModel.AddressFilterMode); } set { } }
    [System.ComponentModel.DefaultValueAttribute(true)]
    public bool AutomaticSessionShutdown { get { return default(bool); } set { } }
    [System.ComponentModel.DefaultValueAttribute((System.ServiceModel.ConcurrencyMode)(0))]
    public System.ServiceModel.ConcurrencyMode ConcurrencyMode { get { return default(System.ServiceModel.ConcurrencyMode); } set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public string ConfigurationName { get { return default(string); } set { } }
    [System.ComponentModel.DefaultValueAttribute(false)]
    public bool EnsureOrderedDispatch { get { return default(bool); } set { } }
    [System.ComponentModel.DefaultValueAttribute(false)]
    public bool IgnoreExtensionDataObject { get { return default(bool); } set { } }
    [System.ComponentModel.DefaultValueAttribute(false)]
    public bool IncludeExceptionDetailInFaults { get { return default(bool); } set { } }
    [System.ComponentModel.DefaultValueAttribute((System.ServiceModel.InstanceContextMode)(0))]
    public System.ServiceModel.InstanceContextMode InstanceContextMode { get { return default(System.ServiceModel.InstanceContextMode); } set { } }
    [System.ComponentModel.DefaultValueAttribute(2147483647)]
    public int MaxItemsInObjectGraph { get { return default(int); } set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public string Name { get { return default(string); } set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public string Namespace { get { return default(string); } set { } }
    public bool ReleaseServiceInstanceOnTransactionComplete { get { return default(bool); } set { } }
    public bool TransactionAutoCompleteOnSessionClose { get { return default(bool); } set { } }
    public System.Transactions.IsolationLevel TransactionIsolationLevel { get { return default(System.Transactions.IsolationLevel); } set { } }
    public string TransactionTimeout { get { return default(string); } set { } }
    [System.ComponentModel.DefaultValueAttribute(true)]
    public bool UseSynchronizationContext { get { return default(bool); } set { } }
    [System.ComponentModel.DefaultValueAttribute(true)]
    public bool ValidateMustUnderstand { get { return default(bool); } set { } }
    public object GetWellKnownSingleton() { return default(object); }
    public void SetWellKnownSingleton(object value) { }
    public bool ShouldSerializeConfigurationName() { return default(bool); }
    public bool ShouldSerializeReleaseServiceInstanceOnTransactionComplete() { return default(bool); }
    public bool ShouldSerializeTransactionAutoCompleteOnSessionClose() { return default(bool); }
    public bool ShouldSerializeTransactionIsolationLevel() { return default(bool); }
    public bool ShouldSerializeTransactionTimeout() { return default(bool); }
    void System.ServiceModel.Description.IServiceBehavior.AddBindingParameters(System.ServiceModel.Description.ServiceDescription description, System.ServiceModel.ServiceHostBase serviceHostBase, System.Collections.ObjectModel.Collection<System.ServiceModel.Description.ServiceEndpoint> endpoints, System.ServiceModel.Channels.BindingParameterCollection parameters) { }
    void System.ServiceModel.Description.IServiceBehavior.ApplyDispatchBehavior(System.ServiceModel.Description.ServiceDescription description, System.ServiceModel.ServiceHostBase serviceHostBase) { }
    void System.ServiceModel.Description.IServiceBehavior.Validate(System.ServiceModel.Description.ServiceDescription description, System.ServiceModel.ServiceHostBase serviceHostBase) { }
  }
  public partial class ServiceConfiguration {
    internal ServiceConfiguration() { }
    public System.ServiceModel.Description.ServiceAuthenticationBehavior Authentication { get { return default(System.ServiceModel.Description.ServiceAuthenticationBehavior); } }
    public System.ServiceModel.Description.ServiceAuthorizationBehavior Authorization { get { return default(System.ServiceModel.Description.ServiceAuthorizationBehavior); } }
    public System.Collections.ObjectModel.ReadOnlyCollection<System.Uri> BaseAddresses { get { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.Uri>); } }
    public System.TimeSpan CloseTimeout { get { return default(System.TimeSpan); } set { } }
    public System.ServiceModel.Description.ServiceCredentials Credentials { get { return default(System.ServiceModel.Description.ServiceCredentials); } }
    public System.ServiceModel.Description.ServiceDescription Description { get { return default(System.ServiceModel.Description.ServiceDescription); } }
    public System.IdentityModel.Configuration.IdentityConfiguration IdentityConfiguration { get { return default(System.IdentityModel.Configuration.IdentityConfiguration); } set { } }
    public System.TimeSpan OpenTimeout { get { return default(System.TimeSpan); } set { } }
    public bool UseIdentityConfiguration { get { return default(bool); } set { } }
    public void AddServiceEndpoint(System.ServiceModel.Description.ServiceEndpoint endpoint) { }
    public System.ServiceModel.Description.ServiceEndpoint AddServiceEndpoint(System.Type contractType, System.ServiceModel.Channels.Binding binding, string address) { return default(System.ServiceModel.Description.ServiceEndpoint); }
    public System.ServiceModel.Description.ServiceEndpoint AddServiceEndpoint(System.Type contractType, System.ServiceModel.Channels.Binding binding, string address, System.Uri listenUri) { return default(System.ServiceModel.Description.ServiceEndpoint); }
    public System.ServiceModel.Description.ServiceEndpoint AddServiceEndpoint(System.Type contractType, System.ServiceModel.Channels.Binding binding, System.Uri address) { return default(System.ServiceModel.Description.ServiceEndpoint); }
    public System.ServiceModel.Description.ServiceEndpoint AddServiceEndpoint(System.Type contractType, System.ServiceModel.Channels.Binding binding, System.Uri address, System.Uri listenUri) { return default(System.ServiceModel.Description.ServiceEndpoint); }
    public System.Collections.ObjectModel.Collection<System.ServiceModel.Description.ServiceEndpoint> EnableProtocol(System.ServiceModel.Channels.Binding protocol) { return default(System.Collections.ObjectModel.Collection<System.ServiceModel.Description.ServiceEndpoint>); }
    public void LoadFromConfiguration() { }
    public void LoadFromConfiguration(System.Configuration.Configuration configuration) { }
    public void SetEndpointAddress(System.ServiceModel.Description.ServiceEndpoint endpoint, string relativeAddress) { }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(1028), Inherited=false, AllowMultiple=false)]
  public sealed partial class ServiceContractAttribute : System.Attribute {
    public ServiceContractAttribute() { }
    public System.Type CallbackContract { get { return default(System.Type); } set { } }
    public string ConfigurationName { get { return default(string); } set { } }
    public bool HasProtectionLevel { get { return default(bool); } }
    public string Name { get { return default(string); } set { } }
    public string Namespace { get { return default(string); } set { } }
    public System.Net.Security.ProtectionLevel ProtectionLevel { get { return default(System.Net.Security.ProtectionLevel); } set { } }
    public System.ServiceModel.SessionMode SessionMode { get { return default(System.ServiceModel.SessionMode); } set { } }
  }
  public partial class ServiceHost : System.ServiceModel.ServiceHostBase {
    protected ServiceHost() { }
    public ServiceHost(object singletonInstance, params System.Uri[] baseAddresses) { }
    public ServiceHost(System.Type serviceType, params System.Uri[] baseAddresses) { }
    public object SingletonInstance { get { return default(object); } }
    public System.ServiceModel.Description.ServiceEndpoint AddServiceEndpoint(System.Type implementedContract, System.ServiceModel.Channels.Binding binding, string address) { return default(System.ServiceModel.Description.ServiceEndpoint); }
    public System.ServiceModel.Description.ServiceEndpoint AddServiceEndpoint(System.Type implementedContract, System.ServiceModel.Channels.Binding binding, string address, System.Uri listenUri) { return default(System.ServiceModel.Description.ServiceEndpoint); }
    public System.ServiceModel.Description.ServiceEndpoint AddServiceEndpoint(System.Type implementedContract, System.ServiceModel.Channels.Binding binding, System.Uri address) { return default(System.ServiceModel.Description.ServiceEndpoint); }
    public System.ServiceModel.Description.ServiceEndpoint AddServiceEndpoint(System.Type implementedContract, System.ServiceModel.Channels.Binding binding, System.Uri address, System.Uri listenUri) { return default(System.ServiceModel.Description.ServiceEndpoint); }
    protected override void ApplyConfiguration() { }
    protected override System.ServiceModel.Description.ServiceDescription CreateDescription(out System.Collections.Generic.IDictionary<System.String, System.ServiceModel.Description.ContractDescription> implementedContracts) { implementedContracts = default(System.Collections.Generic.IDictionary<System.String, System.ServiceModel.Description.ContractDescription>); return default(System.ServiceModel.Description.ServiceDescription); }
    protected void InitializeDescription(object singletonInstance, System.ServiceModel.UriSchemeKeyedCollection baseAddresses) { }
    protected void InitializeDescription(System.Type serviceType, System.ServiceModel.UriSchemeKeyedCollection baseAddresses) { }
    protected override void OnClosed() { }
  }
  public abstract partial class ServiceHostBase : System.ServiceModel.Channels.CommunicationObject, System.IDisposable, System.ServiceModel.IExtensibleObject<System.ServiceModel.ServiceHostBase> {
    protected ServiceHostBase() { }
    public System.ServiceModel.Description.ServiceAuthenticationBehavior Authentication { get { return default(System.ServiceModel.Description.ServiceAuthenticationBehavior); } }
    public System.ServiceModel.Description.ServiceAuthorizationBehavior Authorization { get { return default(System.ServiceModel.Description.ServiceAuthorizationBehavior); } }
    public System.Collections.ObjectModel.ReadOnlyCollection<System.Uri> BaseAddresses { get { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.Uri>); } }
    public System.ServiceModel.Dispatcher.ChannelDispatcherCollection ChannelDispatchers { get { return default(System.ServiceModel.Dispatcher.ChannelDispatcherCollection); } }
    public System.TimeSpan CloseTimeout { get { return default(System.TimeSpan); } set { } }
    public System.ServiceModel.Description.ServiceCredentials Credentials { get { return default(System.ServiceModel.Description.ServiceCredentials); } }
    protected override System.TimeSpan DefaultCloseTimeout { get { return default(System.TimeSpan); } }
    protected override System.TimeSpan DefaultOpenTimeout { get { return default(System.TimeSpan); } }
    public System.ServiceModel.Description.ServiceDescription Description { get { return default(System.ServiceModel.Description.ServiceDescription); } }
    public System.ServiceModel.IExtensionCollection<System.ServiceModel.ServiceHostBase> Extensions { get { return default(System.ServiceModel.IExtensionCollection<System.ServiceModel.ServiceHostBase>); } }
    protected internal System.Collections.Generic.IDictionary<System.String, System.ServiceModel.Description.ContractDescription> ImplementedContracts { get { return default(System.Collections.Generic.IDictionary<System.String, System.ServiceModel.Description.ContractDescription>); } }
    public int ManualFlowControlLimit { get { return default(int); } set { } }
    public System.TimeSpan OpenTimeout { get { return default(System.TimeSpan); } set { } }
    public event System.EventHandler<System.ServiceModel.UnknownMessageReceivedEventArgs> UnknownMessageReceived { add { } remove { } }
    protected void AddBaseAddress(System.Uri baseAddress) { }
    public virtual System.Collections.ObjectModel.ReadOnlyCollection<System.ServiceModel.Description.ServiceEndpoint> AddDefaultEndpoints() { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.ServiceModel.Description.ServiceEndpoint>); }
    public virtual void AddServiceEndpoint(System.ServiceModel.Description.ServiceEndpoint endpoint) { }
    public System.ServiceModel.Description.ServiceEndpoint AddServiceEndpoint(string implementedContract, System.ServiceModel.Channels.Binding binding, string address) { return default(System.ServiceModel.Description.ServiceEndpoint); }
    public System.ServiceModel.Description.ServiceEndpoint AddServiceEndpoint(string implementedContract, System.ServiceModel.Channels.Binding binding, string address, System.Uri listenUri) { return default(System.ServiceModel.Description.ServiceEndpoint); }
    public System.ServiceModel.Description.ServiceEndpoint AddServiceEndpoint(string implementedContract, System.ServiceModel.Channels.Binding binding, System.Uri address) { return default(System.ServiceModel.Description.ServiceEndpoint); }
    public System.ServiceModel.Description.ServiceEndpoint AddServiceEndpoint(string implementedContract, System.ServiceModel.Channels.Binding binding, System.Uri address, System.Uri listenUri) { return default(System.ServiceModel.Description.ServiceEndpoint); }
    protected virtual void ApplyConfiguration() { }
    protected abstract System.ServiceModel.Description.ServiceDescription CreateDescription(out System.Collections.Generic.IDictionary<System.String, System.ServiceModel.Description.ContractDescription> implementedContracts);
    public int IncrementManualFlowControlLimit(int incrementBy) { return default(int); }
    protected void InitializeDescription(System.ServiceModel.UriSchemeKeyedCollection baseAddresses) { }
    protected virtual void InitializeRuntime() { }
    protected void LoadConfigurationSection(System.ServiceModel.Configuration.ServiceElement serviceSection) { }
    protected override void OnAbort() { }
    protected override System.IAsyncResult OnBeginClose(System.TimeSpan timeout, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    protected override System.IAsyncResult OnBeginOpen(System.TimeSpan timeout, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    protected override void OnClose(System.TimeSpan timeout) { }
    protected override void OnClosed() { }
    protected override void OnEndClose(System.IAsyncResult result) { }
    protected override void OnEndOpen(System.IAsyncResult result) { }
    protected override void OnOpen(System.TimeSpan timeout) { }
    protected override void OnOpened() { }
    protected void ReleasePerformanceCounters() { }
    public void SetEndpointAddress(System.ServiceModel.Description.ServiceEndpoint endpoint, string relativeAddress) { }
    void System.IDisposable.Dispose() { }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(1092), Inherited=true, AllowMultiple=true)]
  public sealed partial class ServiceKnownTypeAttribute : System.Attribute {
    public ServiceKnownTypeAttribute(string methodName) { }
    public ServiceKnownTypeAttribute(string methodName, System.Type declaringType) { }
    public ServiceKnownTypeAttribute(System.Type type) { }
    public System.Type DeclaringType { get { return default(System.Type); } }
    public string MethodName { get { return default(string); } }
    public System.Type Type { get { return default(System.Type); } }
  }
  public partial class ServiceSecurityContext {
    public ServiceSecurityContext(System.Collections.ObjectModel.ReadOnlyCollection<System.IdentityModel.Policy.IAuthorizationPolicy> authorizationPolicies) { }
    public ServiceSecurityContext(System.IdentityModel.Policy.AuthorizationContext authorizationContext) { }
    public ServiceSecurityContext(System.IdentityModel.Policy.AuthorizationContext authorizationContext, System.Collections.ObjectModel.ReadOnlyCollection<System.IdentityModel.Policy.IAuthorizationPolicy> authorizationPolicies) { }
    public static System.ServiceModel.ServiceSecurityContext Anonymous { get { return default(System.ServiceModel.ServiceSecurityContext); } }
    public System.IdentityModel.Policy.AuthorizationContext AuthorizationContext { get { return default(System.IdentityModel.Policy.AuthorizationContext); } }
    public System.Collections.ObjectModel.ReadOnlyCollection<System.IdentityModel.Policy.IAuthorizationPolicy> AuthorizationPolicies { get { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.IdentityModel.Policy.IAuthorizationPolicy>); } set { } }
    public static System.ServiceModel.ServiceSecurityContext Current { get { return default(System.ServiceModel.ServiceSecurityContext); } }
    public bool IsAnonymous { get { return default(bool); } }
    public System.Security.Principal.IIdentity PrimaryIdentity { get { return default(System.Security.Principal.IIdentity); } }
    public System.Security.Principal.WindowsIdentity WindowsIdentity { get { return default(System.Security.Principal.WindowsIdentity); } }
  }
  public enum SessionMode {
    Allowed = 0,
    NotAllowed = 2,
    Required = 1,
  }
  public partial class SpnEndpointIdentity : System.ServiceModel.EndpointIdentity {
    public SpnEndpointIdentity(System.IdentityModel.Claims.Claim identity) { }
    public SpnEndpointIdentity(string spnName) { }
    public static System.TimeSpan SpnLookupTime { get { return default(System.TimeSpan); } set { } }
  }
  public enum TcpClientCredentialType {
    Certificate = 2,
    None = 0,
    Windows = 1,
  }
  public sealed partial class TcpTransportSecurity {
    public TcpTransportSecurity() { }
    [System.ComponentModel.DefaultValueAttribute((System.ServiceModel.TcpClientCredentialType)(1))]
    public System.ServiceModel.TcpClientCredentialType ClientCredentialType { get { return default(System.ServiceModel.TcpClientCredentialType); } set { } }
    public System.Security.Authentication.ExtendedProtection.ExtendedProtectionPolicy ExtendedProtectionPolicy { get { return default(System.Security.Authentication.ExtendedProtection.ExtendedProtectionPolicy); } set { } }
    [System.ComponentModel.DefaultValueAttribute((System.Net.Security.ProtectionLevel)(2))]
    public System.Net.Security.ProtectionLevel ProtectionLevel { get { return default(System.Net.Security.ProtectionLevel); } set { } }
    [System.ComponentModel.DefaultValueAttribute((System.Security.Authentication.SslProtocols)(4080))]
    public System.Security.Authentication.SslProtocols SslProtocols { get { return default(System.Security.Authentication.SslProtocols); } set { } }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public bool ShouldSerializeExtendedProtectionPolicy() { return default(bool); }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(64))]
  public sealed partial class TransactionFlowAttribute : System.Attribute, System.ServiceModel.Description.IOperationBehavior {
    public TransactionFlowAttribute(System.ServiceModel.TransactionFlowOption transactions) { }
    public System.ServiceModel.TransactionFlowOption Transactions { get { return default(System.ServiceModel.TransactionFlowOption); } }
    void System.ServiceModel.Description.IOperationBehavior.AddBindingParameters(System.ServiceModel.Description.OperationDescription description, System.ServiceModel.Channels.BindingParameterCollection parameters) { }
    void System.ServiceModel.Description.IOperationBehavior.ApplyClientBehavior(System.ServiceModel.Description.OperationDescription description, System.ServiceModel.Dispatcher.ClientOperation proxy) { }
    void System.ServiceModel.Description.IOperationBehavior.ApplyDispatchBehavior(System.ServiceModel.Description.OperationDescription description, System.ServiceModel.Dispatcher.DispatchOperation dispatch) { }
    void System.ServiceModel.Description.IOperationBehavior.Validate(System.ServiceModel.Description.OperationDescription description) { }
  }
  public enum TransactionFlowOption {
    Allowed = 1,
    Mandatory = 2,
    NotAllowed = 0,
  }
  [System.ComponentModel.TypeConverterAttribute(typeof(System.ServiceModel.Configuration.TransactionProtocolConverter))]
  public abstract partial class TransactionProtocol {
    protected TransactionProtocol() { }
    public static System.ServiceModel.TransactionProtocol Default { get { return default(System.ServiceModel.TransactionProtocol); } }
    public static System.ServiceModel.TransactionProtocol OleTransactions { get { return default(System.ServiceModel.TransactionProtocol); } }
    public static System.ServiceModel.TransactionProtocol WSAtomicTransaction11 { get { return default(System.ServiceModel.TransactionProtocol); } }
    public static System.ServiceModel.TransactionProtocol WSAtomicTransactionOctober2004 { get { return default(System.ServiceModel.TransactionProtocol); } }
  }
  public enum TransferMode {
    Buffered = 0,
    Streamed = 1,
    StreamedRequest = 2,
    StreamedResponse = 3,
  }
  public sealed partial class UnknownMessageReceivedEventArgs : System.EventArgs {
    internal UnknownMessageReceivedEventArgs() { }
    public System.ServiceModel.Channels.Message Message { get { return default(System.ServiceModel.Channels.Message); } }
  }
  public partial class UpnEndpointIdentity : System.ServiceModel.EndpointIdentity {
    public UpnEndpointIdentity(System.IdentityModel.Claims.Claim identity) { }
    public UpnEndpointIdentity(string upnName) { }
  }
  public partial class UriSchemeKeyedCollection : System.Collections.Generic.SynchronizedKeyedCollection<System.String, System.Uri> {
    public UriSchemeKeyedCollection(params System.Uri[] addresses) { }
    protected override string GetKeyForItem(System.Uri item) { return default(string); }
    protected override void InsertItem(int index, System.Uri item) { }
    protected override void SetItem(int index, System.Uri item) { }
  }
  public partial class WS2007FederationHttpBinding : System.ServiceModel.WSFederationHttpBinding {
    public WS2007FederationHttpBinding() { }
    public WS2007FederationHttpBinding(System.ServiceModel.WSFederationHttpSecurityMode securityMode) { }
    public WS2007FederationHttpBinding(System.ServiceModel.WSFederationHttpSecurityMode securityMode, bool reliableSessionEnabled) { }
    public WS2007FederationHttpBinding(string configName) { }
    protected override System.ServiceModel.Channels.SecurityBindingElement CreateMessageSecurity() { return default(System.ServiceModel.Channels.SecurityBindingElement); }
  }
  public partial class WS2007HttpBinding : System.ServiceModel.WSHttpBinding {
    public WS2007HttpBinding() { }
    public WS2007HttpBinding(System.ServiceModel.SecurityMode securityMode) { }
    public WS2007HttpBinding(System.ServiceModel.SecurityMode securityMode, bool reliableSessionEnabled) { }
    public WS2007HttpBinding(string configName) { }
    protected override System.ServiceModel.Channels.SecurityBindingElement CreateMessageSecurity() { return default(System.ServiceModel.Channels.SecurityBindingElement); }
  }
  public partial class WSDualHttpBinding : System.ServiceModel.Channels.Binding, System.ServiceModel.Channels.IBindingRuntimePreferences {
    public WSDualHttpBinding() { }
    public WSDualHttpBinding(System.ServiceModel.WSDualHttpSecurityMode securityMode) { }
    public WSDualHttpBinding(string configName) { }
    [System.ComponentModel.DefaultValueAttribute(false)]
    public bool BypassProxyOnLocal { get { return default(bool); } set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Uri ClientBaseAddress { get { return default(System.Uri); } set { } }
    public System.ServiceModel.EnvelopeVersion EnvelopeVersion { get { return default(System.ServiceModel.EnvelopeVersion); } }
    [System.ComponentModel.DefaultValueAttribute((System.ServiceModel.HostNameComparisonMode)(0))]
    public System.ServiceModel.HostNameComparisonMode HostNameComparisonMode { get { return default(System.ServiceModel.HostNameComparisonMode); } set { } }
    [System.ComponentModel.DefaultValueAttribute((long)524288)]
    public long MaxBufferPoolSize { get { return default(long); } set { } }
    [System.ComponentModel.DefaultValueAttribute((long)65536)]
    public long MaxReceivedMessageSize { get { return default(long); } set { } }
    [System.ComponentModel.DefaultValueAttribute((System.ServiceModel.WSMessageEncoding)(0))]
    public System.ServiceModel.WSMessageEncoding MessageEncoding { get { return default(System.ServiceModel.WSMessageEncoding); } set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Uri ProxyAddress { get { return default(System.Uri); } set { } }
    public System.Xml.XmlDictionaryReaderQuotas ReaderQuotas { get { return default(System.Xml.XmlDictionaryReaderQuotas); } set { } }
    public System.ServiceModel.ReliableSession ReliableSession { get { return default(System.ServiceModel.ReliableSession); } set { } }
    public override string Scheme { get { return default(string); } }
    public System.ServiceModel.WSDualHttpSecurity Security { get { return default(System.ServiceModel.WSDualHttpSecurity); } set { } }
    bool System.ServiceModel.Channels.IBindingRuntimePreferences.ReceiveSynchronously { get { return default(bool); } }
    [System.ComponentModel.TypeConverterAttribute(typeof(System.ServiceModel.Configuration.EncodingConverter))]
    public System.Text.Encoding TextEncoding { get { return default(System.Text.Encoding); } set { } }
    [System.ComponentModel.DefaultValueAttribute(false)]
    public bool TransactionFlow { get { return default(bool); } set { } }
    [System.ComponentModel.DefaultValueAttribute(true)]
    public bool UseDefaultWebProxy { get { return default(bool); } set { } }
    public override System.ServiceModel.Channels.BindingElementCollection CreateBindingElements() { return default(System.ServiceModel.Channels.BindingElementCollection); }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public bool ShouldSerializeReaderQuotas() { return default(bool); }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public bool ShouldSerializeReliableSession() { return default(bool); }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public bool ShouldSerializeSecurity() { return default(bool); }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public bool ShouldSerializeTextEncoding() { return default(bool); }
  }
  public sealed partial class WSDualHttpSecurity {
    public WSDualHttpSecurity() { }
    public System.ServiceModel.MessageSecurityOverHttp Message { get { return default(System.ServiceModel.MessageSecurityOverHttp); } set { } }
    public System.ServiceModel.WSDualHttpSecurityMode Mode { get { return default(System.ServiceModel.WSDualHttpSecurityMode); } set { } }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public bool ShouldSerializeMessage() { return default(bool); }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public bool ShouldSerializeMode() { return default(bool); }
  }
  public enum WSDualHttpSecurityMode {
    Message = 1,
    None = 0,
  }
  public partial class WSFederationHttpBinding : System.ServiceModel.WSHttpBindingBase {
    public WSFederationHttpBinding() { }
    public WSFederationHttpBinding(System.ServiceModel.WSFederationHttpSecurityMode securityMode) { }
    public WSFederationHttpBinding(System.ServiceModel.WSFederationHttpSecurityMode securityMode, bool reliableSessionEnabled) { }
    public WSFederationHttpBinding(string configName) { }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Uri PrivacyNoticeAt { get { return default(System.Uri); } set { } }
    [System.ComponentModel.DefaultValueAttribute(0)]
    public int PrivacyNoticeVersion { get { return default(int); } set { } }
    public System.ServiceModel.WSFederationHttpSecurity Security { get { return default(System.ServiceModel.WSFederationHttpSecurity); } set { } }
    public override System.ServiceModel.Channels.BindingElementCollection CreateBindingElements() { return default(System.ServiceModel.Channels.BindingElementCollection); }
    protected override System.ServiceModel.Channels.SecurityBindingElement CreateMessageSecurity() { return default(System.ServiceModel.Channels.SecurityBindingElement); }
    protected override System.ServiceModel.Channels.TransportBindingElement GetTransport() { return default(System.ServiceModel.Channels.TransportBindingElement); }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public bool ShouldSerializeSecurity() { return default(bool); }
  }
  public sealed partial class WSFederationHttpSecurity {
    public WSFederationHttpSecurity() { }
    public System.ServiceModel.FederatedMessageSecurityOverHttp Message { get { return default(System.ServiceModel.FederatedMessageSecurityOverHttp); } set { } }
    public System.ServiceModel.WSFederationHttpSecurityMode Mode { get { return default(System.ServiceModel.WSFederationHttpSecurityMode); } set { } }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public bool ShouldSerializeMessage() { return default(bool); }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public bool ShouldSerializeMode() { return default(bool); }
  }
  public enum WSFederationHttpSecurityMode {
    Message = 1,
    None = 0,
    TransportWithMessageCredential = 2,
  }
  public partial class WSHttpBinding : System.ServiceModel.WSHttpBindingBase {
    public WSHttpBinding() { }
    public WSHttpBinding(System.ServiceModel.SecurityMode securityMode) { }
    public WSHttpBinding(System.ServiceModel.SecurityMode securityMode, bool reliableSessionEnabled) { }
    public WSHttpBinding(string configName) { }
    [System.ComponentModel.DefaultValueAttribute(false)]
    public bool AllowCookies { get { return default(bool); } set { } }
    public System.ServiceModel.WSHttpSecurity Security { get { return default(System.ServiceModel.WSHttpSecurity); } set { } }
    public override System.ServiceModel.Channels.IChannelFactory<TChannel> BuildChannelFactory<TChannel>(System.ServiceModel.Channels.BindingParameterCollection parameters) { return default(System.ServiceModel.Channels.IChannelFactory<TChannel>); }
    public override System.ServiceModel.Channels.BindingElementCollection CreateBindingElements() { return default(System.ServiceModel.Channels.BindingElementCollection); }
    protected override System.ServiceModel.Channels.SecurityBindingElement CreateMessageSecurity() { return default(System.ServiceModel.Channels.SecurityBindingElement); }
    protected override System.ServiceModel.Channels.TransportBindingElement GetTransport() { return default(System.ServiceModel.Channels.TransportBindingElement); }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public bool ShouldSerializeSecurity() { return default(bool); }
  }
  public abstract partial class WSHttpBindingBase : System.ServiceModel.Channels.Binding, System.ServiceModel.Channels.IBindingRuntimePreferences {
    protected WSHttpBindingBase() { }
    protected WSHttpBindingBase(bool reliableSessionEnabled) { }
    [System.ComponentModel.DefaultValueAttribute(false)]
    public bool BypassProxyOnLocal { get { return default(bool); } set { } }
    public System.ServiceModel.EnvelopeVersion EnvelopeVersion { get { return default(System.ServiceModel.EnvelopeVersion); } }
    [System.ComponentModel.DefaultValueAttribute((System.ServiceModel.HostNameComparisonMode)(0))]
    public System.ServiceModel.HostNameComparisonMode HostNameComparisonMode { get { return default(System.ServiceModel.HostNameComparisonMode); } set { } }
    [System.ComponentModel.DefaultValueAttribute((long)524288)]
    public long MaxBufferPoolSize { get { return default(long); } set { } }
    [System.ComponentModel.DefaultValueAttribute((long)65536)]
    public long MaxReceivedMessageSize { get { return default(long); } set { } }
    [System.ComponentModel.DefaultValueAttribute((System.ServiceModel.WSMessageEncoding)(0))]
    public System.ServiceModel.WSMessageEncoding MessageEncoding { get { return default(System.ServiceModel.WSMessageEncoding); } set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.UriTypeConverter))]
    public System.Uri ProxyAddress { get { return default(System.Uri); } set { } }
    public System.Xml.XmlDictionaryReaderQuotas ReaderQuotas { get { return default(System.Xml.XmlDictionaryReaderQuotas); } set { } }
    public System.ServiceModel.OptionalReliableSession ReliableSession { get { return default(System.ServiceModel.OptionalReliableSession); } set { } }
    public override string Scheme { get { return default(string); } }
    bool System.ServiceModel.Channels.IBindingRuntimePreferences.ReceiveSynchronously { get { return default(bool); } }
    [System.ComponentModel.TypeConverterAttribute(typeof(System.ServiceModel.Configuration.EncodingConverter))]
    public System.Text.Encoding TextEncoding { get { return default(System.Text.Encoding); } set { } }
    [System.ComponentModel.DefaultValueAttribute(false)]
    public bool TransactionFlow { get { return default(bool); } set { } }
    [System.ComponentModel.DefaultValueAttribute(true)]
    public bool UseDefaultWebProxy { get { return default(bool); } set { } }
    public override System.ServiceModel.Channels.BindingElementCollection CreateBindingElements() { return default(System.ServiceModel.Channels.BindingElementCollection); }
    protected abstract System.ServiceModel.Channels.SecurityBindingElement CreateMessageSecurity();
    protected abstract System.ServiceModel.Channels.TransportBindingElement GetTransport();
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public bool ShouldSerializeReaderQuotas() { return default(bool); }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public bool ShouldSerializeReliableSession() { return default(bool); }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public bool ShouldSerializeTextEncoding() { return default(bool); }
  }
  [System.Runtime.CompilerServices.TypeForwardedFromAttribute("System.WorkflowServices, Version=3.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35")]
  public partial class WSHttpContextBinding : System.ServiceModel.WSHttpBinding {
    public WSHttpContextBinding() { }
    public WSHttpContextBinding(System.ServiceModel.SecurityMode securityMode) { }
    public WSHttpContextBinding(System.ServiceModel.SecurityMode securityMode, bool reliableSessionEnabled) { }
    public WSHttpContextBinding(string configName) { }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Uri ClientCallbackAddress { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Uri); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(true)]
    public bool ContextManagementEnabled { get { return default(bool); } set { } }
    [System.ComponentModel.DefaultValueAttribute((System.Net.Security.ProtectionLevel)(1))]
    public System.Net.Security.ProtectionLevel ContextProtectionLevel { get { return default(System.Net.Security.ProtectionLevel); } set { } }
    public override System.ServiceModel.Channels.BindingElementCollection CreateBindingElements() { return default(System.ServiceModel.Channels.BindingElementCollection); }
  }
  public sealed partial class WSHttpSecurity {
    public WSHttpSecurity() { }
    public System.ServiceModel.NonDualMessageSecurityOverHttp Message { get { return default(System.ServiceModel.NonDualMessageSecurityOverHttp); } set { } }
    public System.ServiceModel.SecurityMode Mode { get { return default(System.ServiceModel.SecurityMode); } set { } }
    public System.ServiceModel.HttpTransportSecurity Transport { get { return default(System.ServiceModel.HttpTransportSecurity); } set { } }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public bool ShouldSerializeMessage() { return default(bool); }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public bool ShouldSerializeMode() { return default(bool); }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public bool ShouldSerializeTransport() { return default(bool); }
  }
  public enum WSMessageEncoding {
    Mtom = 1,
    Text = 0,
  }
  public partial class X509CertificateEndpointIdentity : System.ServiceModel.EndpointIdentity {
    public X509CertificateEndpointIdentity(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate) { }
    public X509CertificateEndpointIdentity(System.Security.Cryptography.X509Certificates.X509Certificate2 primaryCertificate, System.Security.Cryptography.X509Certificates.X509Certificate2Collection supportingCertificates) { }
    public System.Security.Cryptography.X509Certificates.X509Certificate2Collection Certificates { get { return default(System.Security.Cryptography.X509Certificates.X509Certificate2Collection); } }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(1092), Inherited=false, AllowMultiple=false)]
  public sealed partial class XmlSerializerFormatAttribute : System.Attribute {
    public XmlSerializerFormatAttribute() { }
    public System.ServiceModel.OperationFormatStyle Style { get { return default(System.ServiceModel.OperationFormatStyle); } set { } }
    public bool SupportFaults { get { return default(bool); } set { } }
    public System.ServiceModel.OperationFormatUse Use { get { return default(System.ServiceModel.OperationFormatUse); } set { } }
  }
  [System.Windows.Markup.ContentPropertyAttribute("Expression")]
  public partial class XPathMessageQuery : System.ServiceModel.Dispatcher.MessageQuery {
    public XPathMessageQuery() { }
    public XPathMessageQuery(string expression) { }
    public XPathMessageQuery(string expression, System.Xml.XmlNamespaceManager namespaces) { }
    public XPathMessageQuery(string expression, System.Xml.Xsl.XsltContext context) { }
    [System.ComponentModel.DefaultValueAttribute("")]
    public string Expression { get { return default(string); } set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Xml.XmlNamespaceManager Namespaces { get { return default(System.Xml.XmlNamespaceManager); } set { } }
    public override System.ServiceModel.Dispatcher.MessageQueryCollection CreateMessageQueryCollection() { return default(System.ServiceModel.Dispatcher.MessageQueryCollection); }
    public override TResult Evaluate<TResult>(System.ServiceModel.Channels.Message message) { return default(TResult); }
    public override TResult Evaluate<TResult>(System.ServiceModel.Channels.MessageBuffer buffer) { return default(TResult); }
  }
}
namespace System.ServiceModel.Activation {
  [System.AttributeUsageAttribute((System.AttributeTargets)(4))]
  public sealed partial class AspNetCompatibilityRequirementsAttribute : System.Attribute, System.ServiceModel.Description.IServiceBehavior {
    public AspNetCompatibilityRequirementsAttribute() { }
    public System.ServiceModel.Activation.AspNetCompatibilityRequirementsMode RequirementsMode { get { return default(System.ServiceModel.Activation.AspNetCompatibilityRequirementsMode); } set { } }
    void System.ServiceModel.Description.IServiceBehavior.AddBindingParameters(System.ServiceModel.Description.ServiceDescription description, System.ServiceModel.ServiceHostBase serviceHostBase, System.Collections.ObjectModel.Collection<System.ServiceModel.Description.ServiceEndpoint> endpoints, System.ServiceModel.Channels.BindingParameterCollection parameters) { }
    void System.ServiceModel.Description.IServiceBehavior.ApplyDispatchBehavior(System.ServiceModel.Description.ServiceDescription description, System.ServiceModel.ServiceHostBase serviceHostBase) { }
    void System.ServiceModel.Description.IServiceBehavior.Validate(System.ServiceModel.Description.ServiceDescription description, System.ServiceModel.ServiceHostBase serviceHostBase) { }
  }
  public enum AspNetCompatibilityRequirementsMode {
    Allowed = 1,
    NotAllowed = 0,
    Required = 2,
  }
  public abstract partial class ServiceHostFactoryBase {
    protected ServiceHostFactoryBase() { }
    public abstract System.ServiceModel.ServiceHostBase CreateServiceHost(string constructorString, System.Uri[] baseAddresses);
  }
  public sealed partial class VirtualPathExtension : System.ServiceModel.IExtension<System.ServiceModel.ServiceHostBase> {
    internal VirtualPathExtension() { }
    public string ApplicationVirtualPath { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
    public string SiteName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
    public string VirtualPath { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
    public void Attach(System.ServiceModel.ServiceHostBase owner) { }
    public void Detach(System.ServiceModel.ServiceHostBase owner) { }
  }
}
namespace System.ServiceModel.Activation.Configuration {
  public sealed partial class DiagnosticSection : System.Configuration.ConfigurationSection {
    public DiagnosticSection() { }
    [System.Configuration.ConfigurationPropertyAttribute("performanceCountersEnabled", DefaultValue=true)]
    public bool PerformanceCountersEnabled { get { return default(bool); } set { } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
  }
  public sealed partial class NetPipeSection : System.Configuration.ConfigurationSection {
    public NetPipeSection() { }
    [System.Configuration.ConfigurationPropertyAttribute("allowAccounts")]
    public System.ServiceModel.Activation.Configuration.SecurityIdentifierElementCollection AllowAccounts { get { return default(System.ServiceModel.Activation.Configuration.SecurityIdentifierElementCollection); } }
    [System.Configuration.ConfigurationPropertyAttribute("maxPendingAccepts", DefaultValue=0)]
    [System.Configuration.IntegerValidatorAttribute(MinValue=0)]
    public int MaxPendingAccepts { get { return default(int); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("maxPendingConnections", DefaultValue=100)]
    [System.Configuration.IntegerValidatorAttribute(MinValue=0)]
    public int MaxPendingConnections { get { return default(int); } set { } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
    [System.ComponentModel.TypeConverterAttribute(typeof(System.ServiceModel.Configuration.TimeSpanOrInfiniteConverter))]
    [System.Configuration.ConfigurationPropertyAttribute("receiveTimeout", DefaultValue="00:00:30")]
    [System.ServiceModel.Configuration.ServiceModelTimeSpanValidatorAttribute(MinValueString="00:00:00")]
    public System.TimeSpan ReceiveTimeout { get { return default(System.TimeSpan); } set { } }
    protected override void InitializeDefault() { }
  }
  public sealed partial class NetTcpSection : System.Configuration.ConfigurationSection {
    public NetTcpSection() { }
    [System.Configuration.ConfigurationPropertyAttribute("allowAccounts")]
    public System.ServiceModel.Activation.Configuration.SecurityIdentifierElementCollection AllowAccounts { get { return default(System.ServiceModel.Activation.Configuration.SecurityIdentifierElementCollection); } }
    [System.Configuration.ConfigurationPropertyAttribute("listenBacklog", DefaultValue=0)]
    [System.Configuration.IntegerValidatorAttribute(MinValue=0)]
    public int ListenBacklog { get { return default(int); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("maxPendingAccepts", DefaultValue=0)]
    [System.Configuration.IntegerValidatorAttribute(MinValue=0)]
    public int MaxPendingAccepts { get { return default(int); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("maxPendingConnections", DefaultValue=100)]
    [System.Configuration.IntegerValidatorAttribute(MinValue=0)]
    public int MaxPendingConnections { get { return default(int); } set { } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
    [System.ComponentModel.TypeConverterAttribute(typeof(System.ServiceModel.Configuration.TimeSpanOrInfiniteConverter))]
    [System.Configuration.ConfigurationPropertyAttribute("receiveTimeout", DefaultValue="00:00:30")]
    [System.ServiceModel.Configuration.ServiceModelTimeSpanValidatorAttribute(MinValueString="00:00:00")]
    public System.TimeSpan ReceiveTimeout { get { return default(System.TimeSpan); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("teredoEnabled", DefaultValue=false)]
    public bool TeredoEnabled { get { return default(bool); } set { } }
    protected override void InitializeDefault() { }
  }
  public sealed partial class SecurityIdentifierElement : System.Configuration.ConfigurationElement {
    public SecurityIdentifierElement() { }
    public SecurityIdentifierElement(System.Security.Principal.SecurityIdentifier sid) { }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
    [System.ComponentModel.TypeConverterAttribute(typeof(System.ServiceModel.Activation.Configuration.SecurityIdentifierConverter))]
    [System.Configuration.ConfigurationPropertyAttribute("securityIdentifier", DefaultValue=null, Options=(System.Configuration.ConfigurationPropertyOptions)(4))]
    public System.Security.Principal.SecurityIdentifier SecurityIdentifier { get { return default(System.Security.Principal.SecurityIdentifier); } set { } }
  }
  [System.Configuration.ConfigurationCollectionAttribute(typeof(System.ServiceModel.Activation.Configuration.SecurityIdentifierElement))]
  public sealed partial class SecurityIdentifierElementCollection : System.ServiceModel.Configuration.ServiceModelConfigurationElementCollection<System.ServiceModel.Activation.Configuration.SecurityIdentifierElement> {
    public SecurityIdentifierElementCollection() { }
    protected override object GetElementKey(System.Configuration.ConfigurationElement element) { return default(object); }
  }
  public sealed partial class ServiceModelActivationSectionGroup : System.Configuration.ConfigurationSectionGroup {
    public ServiceModelActivationSectionGroup() { }
    public System.ServiceModel.Activation.Configuration.DiagnosticSection Diagnostics { get { return default(System.ServiceModel.Activation.Configuration.DiagnosticSection); } }
    public System.ServiceModel.Activation.Configuration.NetPipeSection NetPipe { get { return default(System.ServiceModel.Activation.Configuration.NetPipeSection); } }
    public System.ServiceModel.Activation.Configuration.NetTcpSection NetTcp { get { return default(System.ServiceModel.Activation.Configuration.NetTcpSection); } }
    public static System.ServiceModel.Activation.Configuration.ServiceModelActivationSectionGroup GetSectionGroup(System.Configuration.Configuration config) { return default(System.ServiceModel.Activation.Configuration.ServiceModelActivationSectionGroup); }
  }
}
namespace System.ServiceModel.Channels {
  public abstract partial class AddressHeader {
    protected AddressHeader() { }
    public abstract string Name { get; }
    public abstract string Namespace { get; }
    public static System.ServiceModel.Channels.AddressHeader CreateAddressHeader(object value) { return default(System.ServiceModel.Channels.AddressHeader); }
    public static System.ServiceModel.Channels.AddressHeader CreateAddressHeader(object value, System.Runtime.Serialization.XmlObjectSerializer serializer) { return default(System.ServiceModel.Channels.AddressHeader); }
    public static System.ServiceModel.Channels.AddressHeader CreateAddressHeader(string name, string ns, object value) { return default(System.ServiceModel.Channels.AddressHeader); }
    public static System.ServiceModel.Channels.AddressHeader CreateAddressHeader(string name, string ns, object value, System.Runtime.Serialization.XmlObjectSerializer serializer) { return default(System.ServiceModel.Channels.AddressHeader); }
    public override bool Equals(object obj) { return default(bool); }
    public virtual System.Xml.XmlDictionaryReader GetAddressHeaderReader() { return default(System.Xml.XmlDictionaryReader); }
    public override int GetHashCode() { return default(int); }
    public T GetValue<T>() { return default(T); }
    public T GetValue<T>(System.Runtime.Serialization.XmlObjectSerializer serializer) { return default(T); }
    protected abstract void OnWriteAddressHeaderContents(System.Xml.XmlDictionaryWriter writer);
    protected virtual void OnWriteStartAddressHeader(System.Xml.XmlDictionaryWriter writer) { }
    public System.ServiceModel.Channels.MessageHeader ToMessageHeader() { return default(System.ServiceModel.Channels.MessageHeader); }
    public void WriteAddressHeader(System.Xml.XmlDictionaryWriter writer) { }
    public void WriteAddressHeader(System.Xml.XmlWriter writer) { }
    public void WriteAddressHeaderContents(System.Xml.XmlDictionaryWriter writer) { }
    public void WriteStartAddressHeader(System.Xml.XmlDictionaryWriter writer) { }
  }
  public sealed partial class AddressHeaderCollection : System.Collections.ObjectModel.ReadOnlyCollection<System.ServiceModel.Channels.AddressHeader> {
    public AddressHeaderCollection() : base (default(System.Collections.Generic.IList<System.ServiceModel.Channels.AddressHeader>)) { }
    public AddressHeaderCollection(System.Collections.Generic.IEnumerable<System.ServiceModel.Channels.AddressHeader> addressHeaders) : base (default(System.Collections.Generic.IList<System.ServiceModel.Channels.AddressHeader>)) { }
    public void AddHeadersTo(System.ServiceModel.Channels.Message message) { }
    public System.ServiceModel.Channels.AddressHeader[] FindAll(string name, string ns) { return default(System.ServiceModel.Channels.AddressHeader[]); }
    public System.ServiceModel.Channels.AddressHeader FindHeader(string name, string ns) { return default(System.ServiceModel.Channels.AddressHeader); }
  }
  public sealed partial class AddressingVersion {
    internal AddressingVersion() { }
    public static System.ServiceModel.Channels.AddressingVersion None { get { return default(System.ServiceModel.Channels.AddressingVersion); } }
    public static System.ServiceModel.Channels.AddressingVersion WSAddressing10 { get { return default(System.ServiceModel.Channels.AddressingVersion); } }
    public static System.ServiceModel.Channels.AddressingVersion WSAddressingAugust2004 { get { return default(System.ServiceModel.Channels.AddressingVersion); } }
    public override string ToString() { return default(string); }
  }
  public sealed partial class ApplicationContainerSettings {
    internal ApplicationContainerSettings() { }
    public const int CurrentSession = -1;
    public const int ServiceSession = 0;
    public string PackageFullName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public int SessionId { get { return default(int); } set { } }
  }
  public sealed partial class AsymmetricSecurityBindingElement : System.ServiceModel.Channels.SecurityBindingElement, System.ServiceModel.Description.IPolicyExportExtension {
    public AsymmetricSecurityBindingElement() { }
    public AsymmetricSecurityBindingElement(System.ServiceModel.Security.Tokens.SecurityTokenParameters recipientTokenParameters) { }
    public AsymmetricSecurityBindingElement(System.ServiceModel.Security.Tokens.SecurityTokenParameters recipientTokenParameters, System.ServiceModel.Security.Tokens.SecurityTokenParameters initiatorTokenParameters) { }
    public bool AllowSerializedSigningTokenOnReply { get { return default(bool); } set { } }
    public System.ServiceModel.Security.Tokens.SecurityTokenParameters InitiatorTokenParameters { get { return default(System.ServiceModel.Security.Tokens.SecurityTokenParameters); } set { } }
    public System.ServiceModel.Security.MessageProtectionOrder MessageProtectionOrder { get { return default(System.ServiceModel.Security.MessageProtectionOrder); } set { } }
    public System.ServiceModel.Security.Tokens.SecurityTokenParameters RecipientTokenParameters { get { return default(System.ServiceModel.Security.Tokens.SecurityTokenParameters); } set { } }
    public bool RequireSignatureConfirmation { get { return default(bool); } set { } }
    protected override System.ServiceModel.Channels.IChannelFactory<TChannel> BuildChannelFactoryCore<TChannel>(System.ServiceModel.Channels.BindingContext context) { return default(System.ServiceModel.Channels.IChannelFactory<TChannel>); }
    protected override System.ServiceModel.Channels.IChannelListener<TChannel> BuildChannelListenerCore<TChannel>(System.ServiceModel.Channels.BindingContext context) { return default(System.ServiceModel.Channels.IChannelListener<TChannel>); }
    public override System.ServiceModel.Channels.BindingElement Clone() { return default(System.ServiceModel.Channels.BindingElement); }
    public override T GetProperty<T>(System.ServiceModel.Channels.BindingContext context) { return default(T); }
    public override void SetKeyDerivation(bool requireDerivedKeys) { }
    void System.ServiceModel.Description.IPolicyExportExtension.ExportPolicy(System.ServiceModel.Description.MetadataExporter exporter, System.ServiceModel.Description.PolicyConversionContext context) { }
    public override string ToString() { return default(string); }
  }
  public sealed partial class BinaryMessageEncodingBindingElement : System.ServiceModel.Channels.MessageEncodingBindingElement, System.ServiceModel.Description.IPolicyExportExtension, System.ServiceModel.Description.IWsdlExportExtension {
    public BinaryMessageEncodingBindingElement() { }
    [System.ComponentModel.DefaultValueAttribute((System.ServiceModel.Channels.CompressionFormat)(0))]
    public System.ServiceModel.Channels.CompressionFormat CompressionFormat { get { return default(System.ServiceModel.Channels.CompressionFormat); } set { } }
    [System.ComponentModel.DefaultValueAttribute(64)]
    public int MaxReadPoolSize { get { return default(int); } set { } }
    [System.ComponentModel.DefaultValueAttribute(2048)]
    public int MaxSessionSize { get { return default(int); } set { } }
    [System.ComponentModel.DefaultValueAttribute(16)]
    public int MaxWritePoolSize { get { return default(int); } set { } }
    public override System.ServiceModel.Channels.MessageVersion MessageVersion { get { return default(System.ServiceModel.Channels.MessageVersion); } set { } }
    public System.Xml.XmlDictionaryReaderQuotas ReaderQuotas { get { return default(System.Xml.XmlDictionaryReaderQuotas); } set { } }
    public override System.ServiceModel.Channels.IChannelFactory<TChannel> BuildChannelFactory<TChannel>(System.ServiceModel.Channels.BindingContext context) { return default(System.ServiceModel.Channels.IChannelFactory<TChannel>); }
    public override System.ServiceModel.Channels.IChannelListener<TChannel> BuildChannelListener<TChannel>(System.ServiceModel.Channels.BindingContext context) { return default(System.ServiceModel.Channels.IChannelListener<TChannel>); }
    public override bool CanBuildChannelListener<TChannel>(System.ServiceModel.Channels.BindingContext context) { return default(bool); }
    public override System.ServiceModel.Channels.BindingElement Clone() { return default(System.ServiceModel.Channels.BindingElement); }
    public override System.ServiceModel.Channels.MessageEncoderFactory CreateMessageEncoderFactory() { return default(System.ServiceModel.Channels.MessageEncoderFactory); }
    public override T GetProperty<T>(System.ServiceModel.Channels.BindingContext context) { return default(T); }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public bool ShouldSerializeMessageVersion() { return default(bool); }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public bool ShouldSerializeReaderQuotas() { return default(bool); }
    void System.ServiceModel.Description.IPolicyExportExtension.ExportPolicy(System.ServiceModel.Description.MetadataExporter exporter, System.ServiceModel.Description.PolicyConversionContext policyContext) { }
    void System.ServiceModel.Description.IWsdlExportExtension.ExportContract(System.ServiceModel.Description.WsdlExporter exporter, System.ServiceModel.Description.WsdlContractConversionContext context) { }
    void System.ServiceModel.Description.IWsdlExportExtension.ExportEndpoint(System.ServiceModel.Description.WsdlExporter exporter, System.ServiceModel.Description.WsdlEndpointConversionContext context) { }
  }
  public abstract partial class Binding : System.ServiceModel.IDefaultCommunicationTimeouts {
    protected Binding() { }
    protected Binding(string name, string ns) { }
    [System.ComponentModel.DefaultValueAttribute(typeof(System.TimeSpan), "00:01:00")]
    public System.TimeSpan CloseTimeout { get { return default(System.TimeSpan); } set { } }
    public System.ServiceModel.Channels.MessageVersion MessageVersion { get { return default(System.ServiceModel.Channels.MessageVersion); } }
    public string Name { get { return default(string); } set { } }
    public string Namespace { get { return default(string); } set { } }
    [System.ComponentModel.DefaultValueAttribute(typeof(System.TimeSpan), "00:01:00")]
    public System.TimeSpan OpenTimeout { get { return default(System.TimeSpan); } set { } }
    [System.ComponentModel.DefaultValueAttribute(typeof(System.TimeSpan), "00:10:00")]
    public System.TimeSpan ReceiveTimeout { get { return default(System.TimeSpan); } set { } }
    public abstract string Scheme { get; }
    [System.ComponentModel.DefaultValueAttribute(typeof(System.TimeSpan), "00:01:00")]
    public System.TimeSpan SendTimeout { get { return default(System.TimeSpan); } set { } }
    public System.ServiceModel.Channels.IChannelFactory<TChannel> BuildChannelFactory<TChannel>(params System.Object[] parameters) { return default(System.ServiceModel.Channels.IChannelFactory<TChannel>); }
    public virtual System.ServiceModel.Channels.IChannelFactory<TChannel> BuildChannelFactory<TChannel>(System.ServiceModel.Channels.BindingParameterCollection parameters) { return default(System.ServiceModel.Channels.IChannelFactory<TChannel>); }
    public virtual System.ServiceModel.Channels.IChannelListener<TChannel> BuildChannelListener<TChannel>(params System.Object[] parameters) where TChannel : class, System.ServiceModel.Channels.IChannel { return default(System.ServiceModel.Channels.IChannelListener<TChannel>); }
    public virtual System.ServiceModel.Channels.IChannelListener<TChannel> BuildChannelListener<TChannel>(System.ServiceModel.Channels.BindingParameterCollection parameters) where TChannel : class, System.ServiceModel.Channels.IChannel { return default(System.ServiceModel.Channels.IChannelListener<TChannel>); }
    public virtual System.ServiceModel.Channels.IChannelListener<TChannel> BuildChannelListener<TChannel>(System.Uri listenUriBaseAddress, params System.Object[] parameters) where TChannel : class, System.ServiceModel.Channels.IChannel { return default(System.ServiceModel.Channels.IChannelListener<TChannel>); }
    public virtual System.ServiceModel.Channels.IChannelListener<TChannel> BuildChannelListener<TChannel>(System.Uri listenUriBaseAddress, System.ServiceModel.Channels.BindingParameterCollection parameters) where TChannel : class, System.ServiceModel.Channels.IChannel { return default(System.ServiceModel.Channels.IChannelListener<TChannel>); }
    public virtual System.ServiceModel.Channels.IChannelListener<TChannel> BuildChannelListener<TChannel>(System.Uri listenUriBaseAddress, string listenUriRelativeAddress, params System.Object[] parameters) where TChannel : class, System.ServiceModel.Channels.IChannel { return default(System.ServiceModel.Channels.IChannelListener<TChannel>); }
    public virtual System.ServiceModel.Channels.IChannelListener<TChannel> BuildChannelListener<TChannel>(System.Uri listenUriBaseAddress, string listenUriRelativeAddress, System.ServiceModel.Channels.BindingParameterCollection parameters) where TChannel : class, System.ServiceModel.Channels.IChannel { return default(System.ServiceModel.Channels.IChannelListener<TChannel>); }
    public virtual System.ServiceModel.Channels.IChannelListener<TChannel> BuildChannelListener<TChannel>(System.Uri listenUriBaseAddress, string listenUriRelativeAddress, System.ServiceModel.Description.ListenUriMode listenUriMode, params System.Object[] parameters) where TChannel : class, System.ServiceModel.Channels.IChannel { return default(System.ServiceModel.Channels.IChannelListener<TChannel>); }
    public virtual System.ServiceModel.Channels.IChannelListener<TChannel> BuildChannelListener<TChannel>(System.Uri listenUriBaseAddress, string listenUriRelativeAddress, System.ServiceModel.Description.ListenUriMode listenUriMode, System.ServiceModel.Channels.BindingParameterCollection parameters) where TChannel : class, System.ServiceModel.Channels.IChannel { return default(System.ServiceModel.Channels.IChannelListener<TChannel>); }
    public bool CanBuildChannelFactory<TChannel>(params System.Object[] parameters) { return default(bool); }
    public virtual bool CanBuildChannelFactory<TChannel>(System.ServiceModel.Channels.BindingParameterCollection parameters) { return default(bool); }
    public bool CanBuildChannelListener<TChannel>(params System.Object[] parameters) where TChannel : class, System.ServiceModel.Channels.IChannel { return default(bool); }
    public virtual bool CanBuildChannelListener<TChannel>(System.ServiceModel.Channels.BindingParameterCollection parameters) where TChannel : class, System.ServiceModel.Channels.IChannel { return default(bool); }
    public abstract System.ServiceModel.Channels.BindingElementCollection CreateBindingElements();
    public T GetProperty<T>(System.ServiceModel.Channels.BindingParameterCollection parameters) where T : class { return default(T); }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public bool ShouldSerializeName() { return default(bool); }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public bool ShouldSerializeNamespace() { return default(bool); }
  }
  public partial class BindingContext {
    public BindingContext(System.ServiceModel.Channels.CustomBinding binding, System.ServiceModel.Channels.BindingParameterCollection parameters) { }
    public BindingContext(System.ServiceModel.Channels.CustomBinding binding, System.ServiceModel.Channels.BindingParameterCollection parameters, System.Uri listenUriBaseAddress, string listenUriRelativeAddress, System.ServiceModel.Description.ListenUriMode listenUriMode) { }
    public System.ServiceModel.Channels.CustomBinding Binding { get { return default(System.ServiceModel.Channels.CustomBinding); } }
    public System.ServiceModel.Channels.BindingParameterCollection BindingParameters { get { return default(System.ServiceModel.Channels.BindingParameterCollection); } }
    public System.Uri ListenUriBaseAddress { get { return default(System.Uri); } set { } }
    public System.ServiceModel.Description.ListenUriMode ListenUriMode { get { return default(System.ServiceModel.Description.ListenUriMode); } set { } }
    public string ListenUriRelativeAddress { get { return default(string); } set { } }
    public System.ServiceModel.Channels.BindingElementCollection RemainingBindingElements { get { return default(System.ServiceModel.Channels.BindingElementCollection); } }
    public System.ServiceModel.Channels.IChannelFactory<TChannel> BuildInnerChannelFactory<TChannel>() { return default(System.ServiceModel.Channels.IChannelFactory<TChannel>); }
    public System.ServiceModel.Channels.IChannelListener<TChannel> BuildInnerChannelListener<TChannel>() where TChannel : class, System.ServiceModel.Channels.IChannel { return default(System.ServiceModel.Channels.IChannelListener<TChannel>); }
    public bool CanBuildInnerChannelFactory<TChannel>() { return default(bool); }
    public bool CanBuildInnerChannelListener<TChannel>() where TChannel : class, System.ServiceModel.Channels.IChannel { return default(bool); }
    public System.ServiceModel.Channels.BindingContext Clone() { return default(System.ServiceModel.Channels.BindingContext); }
    public T GetInnerProperty<T>() where T : class { return default(T); }
  }
  public abstract partial class BindingElement {
    protected BindingElement() { }
    protected BindingElement(System.ServiceModel.Channels.BindingElement elementToBeCloned) { }
    public virtual System.ServiceModel.Channels.IChannelFactory<TChannel> BuildChannelFactory<TChannel>(System.ServiceModel.Channels.BindingContext context) { return default(System.ServiceModel.Channels.IChannelFactory<TChannel>); }
    public virtual System.ServiceModel.Channels.IChannelListener<TChannel> BuildChannelListener<TChannel>(System.ServiceModel.Channels.BindingContext context) where TChannel : class, System.ServiceModel.Channels.IChannel { return default(System.ServiceModel.Channels.IChannelListener<TChannel>); }
    public virtual bool CanBuildChannelFactory<TChannel>(System.ServiceModel.Channels.BindingContext context) { return default(bool); }
    public virtual bool CanBuildChannelListener<TChannel>(System.ServiceModel.Channels.BindingContext context) where TChannel : class, System.ServiceModel.Channels.IChannel { return default(bool); }
    public abstract System.ServiceModel.Channels.BindingElement Clone();
    public abstract T GetProperty<T>(System.ServiceModel.Channels.BindingContext context) where T : class;
  }
  public partial class BindingElementCollection : System.Collections.ObjectModel.Collection<System.ServiceModel.Channels.BindingElement> {
    public BindingElementCollection() { }
    public BindingElementCollection(System.Collections.Generic.IEnumerable<System.ServiceModel.Channels.BindingElement> elements) { }
    public BindingElementCollection(System.ServiceModel.Channels.BindingElement[] elements) { }
    public void AddRange(params System.ServiceModel.Channels.BindingElement[] elements) { }
    public System.ServiceModel.Channels.BindingElementCollection Clone() { return default(System.ServiceModel.Channels.BindingElementCollection); }
    public bool Contains(System.Type bindingElementType) { return default(bool); }
    public T Find<T>() { return default(T); }
    public System.Collections.ObjectModel.Collection<T> FindAll<T>() { return default(System.Collections.ObjectModel.Collection<T>); }
    protected override void InsertItem(int index, System.ServiceModel.Channels.BindingElement item) { }
    public T Remove<T>() { return default(T); }
    public System.Collections.ObjectModel.Collection<T> RemoveAll<T>() { return default(System.Collections.ObjectModel.Collection<T>); }
    protected override void SetItem(int index, System.ServiceModel.Channels.BindingElement item) { }
  }
  public partial class BindingParameterCollection : System.Collections.Generic.KeyedByTypeCollection<System.Object> {
    public BindingParameterCollection() { }
  }
  public abstract partial class BodyWriter {
    protected BodyWriter(bool isBuffered) { }
    public bool IsBuffered { get { return default(bool); } }
    public System.IAsyncResult BeginWriteBodyContents(System.Xml.XmlDictionaryWriter writer, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    public System.ServiceModel.Channels.BodyWriter CreateBufferedCopy(int maxBufferSize) { return default(System.ServiceModel.Channels.BodyWriter); }
    public void EndWriteBodyContents(System.IAsyncResult result) { }
    protected virtual System.IAsyncResult OnBeginWriteBodyContents(System.Xml.XmlDictionaryWriter writer, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    protected virtual System.ServiceModel.Channels.BodyWriter OnCreateBufferedCopy(int maxBufferSize) { return default(System.ServiceModel.Channels.BodyWriter); }
    protected virtual void OnEndWriteBodyContents(System.IAsyncResult result) { }
    protected abstract void OnWriteBodyContents(System.Xml.XmlDictionaryWriter writer);
    public void WriteBodyContents(System.Xml.XmlDictionaryWriter writer) { }
  }
  public abstract partial class BufferManager {
    protected BufferManager() { }
    public abstract void Clear();
    public static System.ServiceModel.Channels.BufferManager CreateBufferManager(long maxBufferPoolSize, int maxBufferSize) { return default(System.ServiceModel.Channels.BufferManager); }
    public abstract void ReturnBuffer(System.Byte[] buffer);
    public abstract System.Byte[] TakeBuffer(int bufferSize);
  }
  public partial class CallbackContextMessageProperty : System.ServiceModel.Channels.IMessageProperty {
    public CallbackContextMessageProperty(System.Collections.Generic.IDictionary<System.String, System.String> context) { }
    public CallbackContextMessageProperty(System.ServiceModel.EndpointAddress callbackAddress) { }
    public CallbackContextMessageProperty(System.ServiceModel.EndpointAddress listenAddress, System.Collections.Generic.IDictionary<System.String, System.String> context) { }
    public CallbackContextMessageProperty(string listenAddress, System.Collections.Generic.IDictionary<System.String, System.String> context) { }
    public CallbackContextMessageProperty(System.Uri listenAddress, System.Collections.Generic.IDictionary<System.String, System.String> context) { }
    public System.ServiceModel.EndpointAddress CallbackAddress { get { return default(System.ServiceModel.EndpointAddress); } }
    public System.Collections.Generic.IDictionary<System.String, System.String> Context { get { return default(System.Collections.Generic.IDictionary<System.String, System.String>); } }
    public static string Name { get { return default(string); } }
    public void AddOrReplaceInMessage(System.ServiceModel.Channels.Message message) { }
    public void AddOrReplaceInMessageProperties(System.ServiceModel.Channels.MessageProperties properties) { }
    public System.ServiceModel.EndpointAddress CreateCallbackAddress(System.Uri listenAddress) { return default(System.ServiceModel.EndpointAddress); }
    public System.ServiceModel.Channels.IMessageProperty CreateCopy() { return default(System.ServiceModel.Channels.IMessageProperty); }
    public void GetListenAddressAndContext(out System.ServiceModel.EndpointAddress listenAddress, out System.Collections.Generic.IDictionary<System.String, System.String> context) { listenAddress = default(System.ServiceModel.EndpointAddress); context = default(System.Collections.Generic.IDictionary<System.String, System.String>); }
    public static bool TryGet(System.ServiceModel.Channels.Message message, out System.ServiceModel.Channels.CallbackContextMessageProperty contextMessageProperty) { contextMessageProperty = default(System.ServiceModel.Channels.CallbackContextMessageProperty); return default(bool); }
    public static bool TryGet(System.ServiceModel.Channels.MessageProperties properties, out System.ServiceModel.Channels.CallbackContextMessageProperty contextMessageProperty) { contextMessageProperty = default(System.ServiceModel.Channels.CallbackContextMessageProperty); return default(bool); }
  }
  public abstract partial class ChannelBase : System.ServiceModel.Channels.CommunicationObject, System.ServiceModel.Channels.IChannel, System.ServiceModel.ICommunicationObject, System.ServiceModel.IDefaultCommunicationTimeouts {
    protected ChannelBase(System.ServiceModel.Channels.ChannelManagerBase channelManager) { }
    protected override System.TimeSpan DefaultCloseTimeout { get { return default(System.TimeSpan); } }
    protected override System.TimeSpan DefaultOpenTimeout { get { return default(System.TimeSpan); } }
    protected System.TimeSpan DefaultReceiveTimeout { get { return default(System.TimeSpan); } }
    protected System.TimeSpan DefaultSendTimeout { get { return default(System.TimeSpan); } }
    protected System.ServiceModel.Channels.ChannelManagerBase Manager { get { return default(System.ServiceModel.Channels.ChannelManagerBase); } }
    System.TimeSpan System.ServiceModel.IDefaultCommunicationTimeouts.CloseTimeout { get { return default(System.TimeSpan); } }
    System.TimeSpan System.ServiceModel.IDefaultCommunicationTimeouts.OpenTimeout { get { return default(System.TimeSpan); } }
    System.TimeSpan System.ServiceModel.IDefaultCommunicationTimeouts.ReceiveTimeout { get { return default(System.TimeSpan); } }
    System.TimeSpan System.ServiceModel.IDefaultCommunicationTimeouts.SendTimeout { get { return default(System.TimeSpan); } }
    public virtual T GetProperty<T>() where T : class { return default(T); }
    protected override void OnClosed() { }
  }
  public abstract partial class ChannelFactoryBase : System.ServiceModel.Channels.ChannelManagerBase, System.ServiceModel.Channels.IChannelFactory, System.ServiceModel.ICommunicationObject {
    protected ChannelFactoryBase() { }
    protected ChannelFactoryBase(System.ServiceModel.IDefaultCommunicationTimeouts timeouts) { }
    protected override System.TimeSpan DefaultCloseTimeout { get { return default(System.TimeSpan); } }
    protected override System.TimeSpan DefaultOpenTimeout { get { return default(System.TimeSpan); } }
    protected override System.TimeSpan DefaultReceiveTimeout { get { return default(System.TimeSpan); } }
    protected override System.TimeSpan DefaultSendTimeout { get { return default(System.TimeSpan); } }
    public virtual T GetProperty<T>() where T : class { return default(T); }
    protected override void OnAbort() { }
    protected override System.IAsyncResult OnBeginClose(System.TimeSpan timeout, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    protected override void OnClose(System.TimeSpan timeout) { }
    protected override void OnEndClose(System.IAsyncResult result) { }
  }
  public abstract partial class ChannelFactoryBase<TChannel> : System.ServiceModel.Channels.ChannelFactoryBase, System.ServiceModel.Channels.IChannelFactory, System.ServiceModel.Channels.IChannelFactory<TChannel>, System.ServiceModel.ICommunicationObject {
    protected ChannelFactoryBase() { }
    protected ChannelFactoryBase(System.ServiceModel.IDefaultCommunicationTimeouts timeouts) { }
    public TChannel CreateChannel(System.ServiceModel.EndpointAddress address) { return default(TChannel); }
    public TChannel CreateChannel(System.ServiceModel.EndpointAddress address, System.Uri via) { return default(TChannel); }
    protected override void OnAbort() { }
    protected override System.IAsyncResult OnBeginClose(System.TimeSpan timeout, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    protected override void OnClose(System.TimeSpan timeout) { }
    protected abstract TChannel OnCreateChannel(System.ServiceModel.EndpointAddress address, System.Uri via);
    protected override void OnEndClose(System.IAsyncResult result) { }
    protected void ValidateCreateChannel() { }
  }
  public abstract partial class ChannelListenerBase : System.ServiceModel.Channels.ChannelManagerBase, System.ServiceModel.Channels.IChannelListener, System.ServiceModel.ICommunicationObject {
    protected ChannelListenerBase() { }
    protected ChannelListenerBase(System.ServiceModel.IDefaultCommunicationTimeouts timeouts) { }
    protected override System.TimeSpan DefaultCloseTimeout { get { return default(System.TimeSpan); } }
    protected override System.TimeSpan DefaultOpenTimeout { get { return default(System.TimeSpan); } }
    protected override System.TimeSpan DefaultReceiveTimeout { get { return default(System.TimeSpan); } }
    protected override System.TimeSpan DefaultSendTimeout { get { return default(System.TimeSpan); } }
    public abstract System.Uri Uri { get; }
    public System.IAsyncResult BeginWaitForChannel(System.TimeSpan timeout, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    public bool EndWaitForChannel(System.IAsyncResult result) { return default(bool); }
    public virtual T GetProperty<T>() where T : class { return default(T); }
    protected abstract System.IAsyncResult OnBeginWaitForChannel(System.TimeSpan timeout, System.AsyncCallback callback, object state);
    protected abstract bool OnEndWaitForChannel(System.IAsyncResult result);
    protected abstract bool OnWaitForChannel(System.TimeSpan timeout);
    public bool WaitForChannel(System.TimeSpan timeout) { return default(bool); }
  }
  public abstract partial class ChannelListenerBase<TChannel> : System.ServiceModel.Channels.ChannelListenerBase, System.ServiceModel.Channels.IChannelListener, System.ServiceModel.Channels.IChannelListener<TChannel>, System.ServiceModel.ICommunicationObject where TChannel : class, System.ServiceModel.Channels.IChannel {
    protected ChannelListenerBase() { }
    protected ChannelListenerBase(System.ServiceModel.IDefaultCommunicationTimeouts timeouts) { }
    public TChannel AcceptChannel() { return default(TChannel); }
    public TChannel AcceptChannel(System.TimeSpan timeout) { return default(TChannel); }
    public System.IAsyncResult BeginAcceptChannel(System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    public System.IAsyncResult BeginAcceptChannel(System.TimeSpan timeout, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    public TChannel EndAcceptChannel(System.IAsyncResult result) { return default(TChannel); }
    protected abstract TChannel OnAcceptChannel(System.TimeSpan timeout);
    protected abstract System.IAsyncResult OnBeginAcceptChannel(System.TimeSpan timeout, System.AsyncCallback callback, object state);
    protected abstract TChannel OnEndAcceptChannel(System.IAsyncResult result);
  }
  public abstract partial class ChannelManagerBase : System.ServiceModel.Channels.CommunicationObject, System.ServiceModel.IDefaultCommunicationTimeouts {
    protected ChannelManagerBase() { }
    protected abstract System.TimeSpan DefaultReceiveTimeout { get; }
    protected abstract System.TimeSpan DefaultSendTimeout { get; }
    System.TimeSpan System.ServiceModel.IDefaultCommunicationTimeouts.CloseTimeout { get { return default(System.TimeSpan); } }
    System.TimeSpan System.ServiceModel.IDefaultCommunicationTimeouts.OpenTimeout { get { return default(System.TimeSpan); } }
    System.TimeSpan System.ServiceModel.IDefaultCommunicationTimeouts.ReceiveTimeout { get { return default(System.TimeSpan); } }
    System.TimeSpan System.ServiceModel.IDefaultCommunicationTimeouts.SendTimeout { get { return default(System.TimeSpan); } }
  }
  public partial class ChannelParameterCollection : System.Collections.ObjectModel.Collection<System.Object> {
    public ChannelParameterCollection() { }
    public ChannelParameterCollection(System.ServiceModel.Channels.IChannel channel) { }
    protected virtual System.ServiceModel.Channels.IChannel Channel { get { return default(System.ServiceModel.Channels.IChannel); } }
    protected override void ClearItems() { }
    protected override void InsertItem(int index, object item) { }
    public void PropagateChannelParameters(System.ServiceModel.Channels.IChannel innerChannel) { }
    protected override void RemoveItem(int index) { }
    protected override void SetItem(int index, object item) { }
  }
  public partial class ChannelPoolSettings {
    public ChannelPoolSettings() { }
    [System.ComponentModel.DefaultValueAttribute(typeof(System.TimeSpan), "00:02:00")]
    public System.TimeSpan IdleTimeout { get { return default(System.TimeSpan); } set { } }
    [System.ComponentModel.DefaultValueAttribute(typeof(System.TimeSpan), "00:10:00")]
    public System.TimeSpan LeaseTimeout { get { return default(System.TimeSpan); } set { } }
    [System.ComponentModel.DefaultValueAttribute(10)]
    public int MaxOutboundChannelsPerEndpoint { get { return default(int); } set { } }
  }
  public abstract partial class ClientWebSocketFactory {
    protected ClientWebSocketFactory() { }
    public abstract string WebSocketVersion { get; }
    public abstract System.Net.WebSockets.WebSocket CreateWebSocket(System.IO.Stream connection, System.ServiceModel.Channels.WebSocketTransportSettings settings);
  }
  public abstract partial class CommunicationObject : System.ServiceModel.ICommunicationObject {
    protected CommunicationObject() { }
    protected CommunicationObject(object mutex) { }
    protected abstract System.TimeSpan DefaultCloseTimeout { get; }
    protected abstract System.TimeSpan DefaultOpenTimeout { get; }
    protected bool IsDisposed { get { return default(bool); } }
    public System.ServiceModel.CommunicationState State { get { return default(System.ServiceModel.CommunicationState); } }
    protected object ThisLock { get { return default(object); } }
    public event System.EventHandler Closed { add { } remove { } }
    public event System.EventHandler Closing { add { } remove { } }
    public event System.EventHandler Faulted { add { } remove { } }
    public event System.EventHandler Opened { add { } remove { } }
    public event System.EventHandler Opening { add { } remove { } }
    public void Abort() { }
    public System.IAsyncResult BeginClose(System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    public System.IAsyncResult BeginClose(System.TimeSpan timeout, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    public System.IAsyncResult BeginOpen(System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    public System.IAsyncResult BeginOpen(System.TimeSpan timeout, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    public void Close() { }
    public void Close(System.TimeSpan timeout) { }
    public void EndClose(System.IAsyncResult result) { }
    public void EndOpen(System.IAsyncResult result) { }
    protected void Fault() { }
    protected virtual System.Type GetCommunicationObjectType() { return default(System.Type); }
    protected abstract void OnAbort();
    protected abstract System.IAsyncResult OnBeginClose(System.TimeSpan timeout, System.AsyncCallback callback, object state);
    protected abstract System.IAsyncResult OnBeginOpen(System.TimeSpan timeout, System.AsyncCallback callback, object state);
    protected abstract void OnClose(System.TimeSpan timeout);
    protected virtual void OnClosed() { }
    protected virtual void OnClosing() { }
    protected abstract void OnEndClose(System.IAsyncResult result);
    protected abstract void OnEndOpen(System.IAsyncResult result);
    protected virtual void OnFaulted() { }
    protected abstract void OnOpen(System.TimeSpan timeout);
    protected virtual void OnOpened() { }
    protected virtual void OnOpening() { }
    public void Open() { }
    public void Open(System.TimeSpan timeout) { }
    protected internal void ThrowIfDisposed() { }
    protected internal void ThrowIfDisposedOrImmutable() { }
    protected internal void ThrowIfDisposedOrNotOpen() { }
  }
  public sealed partial class CompositeDuplexBindingElement : System.ServiceModel.Channels.BindingElement, System.ServiceModel.Description.IPolicyExportExtension {
    public CompositeDuplexBindingElement() { }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Uri ClientBaseAddress { get { return default(System.Uri); } set { } }
    public override System.ServiceModel.Channels.IChannelFactory<TChannel> BuildChannelFactory<TChannel>(System.ServiceModel.Channels.BindingContext context) { return default(System.ServiceModel.Channels.IChannelFactory<TChannel>); }
    public override System.ServiceModel.Channels.IChannelListener<TChannel> BuildChannelListener<TChannel>(System.ServiceModel.Channels.BindingContext context) { return default(System.ServiceModel.Channels.IChannelListener<TChannel>); }
    public override bool CanBuildChannelFactory<TChannel>(System.ServiceModel.Channels.BindingContext context) { return default(bool); }
    public override bool CanBuildChannelListener<TChannel>(System.ServiceModel.Channels.BindingContext context) { return default(bool); }
    public override System.ServiceModel.Channels.BindingElement Clone() { return default(System.ServiceModel.Channels.BindingElement); }
    public override T GetProperty<T>(System.ServiceModel.Channels.BindingContext context) { return default(T); }
    void System.ServiceModel.Description.IPolicyExportExtension.ExportPolicy(System.ServiceModel.Description.MetadataExporter exporter, System.ServiceModel.Description.PolicyConversionContext context) { }
  }
  public partial class CompositeDuplexBindingElementImporter : System.ServiceModel.Description.IPolicyImportExtension {
    public CompositeDuplexBindingElementImporter() { }
    void System.ServiceModel.Description.IPolicyImportExtension.ImportPolicy(System.ServiceModel.Description.MetadataImporter importer, System.ServiceModel.Description.PolicyConversionContext context) { }
  }
  public enum CompressionFormat {
    Deflate = 2,
    GZip = 1,
    None = 0,
  }
  public abstract partial class ConnectionOrientedTransportBindingElement : System.ServiceModel.Channels.TransportBindingElement, System.ServiceModel.Description.IPolicyExportExtension, System.ServiceModel.Description.IWsdlExportExtension {
    internal ConnectionOrientedTransportBindingElement() { }
    [System.ComponentModel.DefaultValueAttribute(typeof(System.TimeSpan), "00:00:30")]
    public System.TimeSpan ChannelInitializationTimeout { get { return default(System.TimeSpan); } set { } }
    [System.ComponentModel.DefaultValueAttribute(8192)]
    public int ConnectionBufferSize { get { return default(int); } set { } }
    [System.ComponentModel.DefaultValueAttribute((System.ServiceModel.HostNameComparisonMode)(0))]
    public System.ServiceModel.HostNameComparisonMode HostNameComparisonMode { get { return default(System.ServiceModel.HostNameComparisonMode); } set { } }
    [System.ComponentModel.DefaultValueAttribute(65536)]
    public int MaxBufferSize { get { return default(int); } set { } }
    [System.ComponentModel.DefaultValueAttribute(typeof(System.TimeSpan), "00:00:00.2")]
    public System.TimeSpan MaxOutputDelay { get { return default(System.TimeSpan); } set { } }
    public int MaxPendingAccepts { get { return default(int); } set { } }
    public int MaxPendingConnections { get { return default(int); } set { } }
    [System.ComponentModel.DefaultValueAttribute((System.ServiceModel.TransferMode)(0))]
    public System.ServiceModel.TransferMode TransferMode { get { return default(System.ServiceModel.TransferMode); } set { } }
    public override bool CanBuildChannelFactory<TChannel>(System.ServiceModel.Channels.BindingContext context) { return default(bool); }
    public override bool CanBuildChannelListener<TChannel>(System.ServiceModel.Channels.BindingContext context) { return default(bool); }
    public override T GetProperty<T>(System.ServiceModel.Channels.BindingContext context) { return default(T); }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public bool ShouldSerializeMaxPendingAccepts() { return default(bool); }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public bool ShouldSerializeMaxPendingConnections() { return default(bool); }
    void System.ServiceModel.Description.IPolicyExportExtension.ExportPolicy(System.ServiceModel.Description.MetadataExporter exporter, System.ServiceModel.Description.PolicyConversionContext context) { }
    void System.ServiceModel.Description.IWsdlExportExtension.ExportContract(System.ServiceModel.Description.WsdlExporter exporter, System.ServiceModel.Description.WsdlContractConversionContext context) { }
    void System.ServiceModel.Description.IWsdlExportExtension.ExportEndpoint(System.ServiceModel.Description.WsdlExporter exporter, System.ServiceModel.Description.WsdlEndpointConversionContext endpointContext) { }
  }
  [System.Runtime.CompilerServices.TypeForwardedFromAttribute("System.WorkflowServices, Version=3.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35")]
  public partial class ContextBindingElement : System.ServiceModel.Channels.BindingElement, System.ServiceModel.Channels.IContextBindingElement, System.ServiceModel.Description.IPolicyExportExtension {
    public ContextBindingElement() { }
    public ContextBindingElement(System.Net.Security.ProtectionLevel protectionLevel) { }
    public ContextBindingElement(System.Net.Security.ProtectionLevel protectionLevel, System.ServiceModel.Channels.ContextExchangeMechanism contextExchangeMechanism) { }
    public ContextBindingElement(System.Net.Security.ProtectionLevel protectionLevel, System.ServiceModel.Channels.ContextExchangeMechanism contextExchangeMechanism, System.Uri clientCallbackAddress) { }
    public ContextBindingElement(System.Net.Security.ProtectionLevel protectionLevel, System.ServiceModel.Channels.ContextExchangeMechanism contextExchangeMechanism, System.Uri clientCallbackAddress, bool contextManagementEnabled) { }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Uri ClientCallbackAddress { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Uri); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute((System.ServiceModel.Channels.ContextExchangeMechanism)(0))]
    public System.ServiceModel.Channels.ContextExchangeMechanism ContextExchangeMechanism { get { return default(System.ServiceModel.Channels.ContextExchangeMechanism); } set { } }
    [System.ComponentModel.DefaultValueAttribute(true)]
    public bool ContextManagementEnabled { get { return default(bool); } set { } }
    [System.ComponentModel.DefaultValueAttribute((System.Net.Security.ProtectionLevel)(1))]
    public System.Net.Security.ProtectionLevel ProtectionLevel { get { return default(System.Net.Security.ProtectionLevel); } set { } }
    public override System.ServiceModel.Channels.IChannelFactory<TChannel> BuildChannelFactory<TChannel>(System.ServiceModel.Channels.BindingContext context) { return default(System.ServiceModel.Channels.IChannelFactory<TChannel>); }
    public override System.ServiceModel.Channels.IChannelListener<TChannel> BuildChannelListener<TChannel>(System.ServiceModel.Channels.BindingContext context) { return default(System.ServiceModel.Channels.IChannelListener<TChannel>); }
    public override bool CanBuildChannelFactory<TChannel>(System.ServiceModel.Channels.BindingContext context) { return default(bool); }
    public override bool CanBuildChannelListener<TChannel>(System.ServiceModel.Channels.BindingContext context) { return default(bool); }
    public override System.ServiceModel.Channels.BindingElement Clone() { return default(System.ServiceModel.Channels.BindingElement); }
    public virtual void ExportPolicy(System.ServiceModel.Description.MetadataExporter exporter, System.ServiceModel.Description.PolicyConversionContext context) { }
    public override T GetProperty<T>(System.ServiceModel.Channels.BindingContext context) { return default(T); }
  }
  [System.Runtime.CompilerServices.TypeForwardedFromAttribute("System.WorkflowServices, Version=3.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35")]
  public partial class ContextBindingElementImporter : System.ServiceModel.Description.IPolicyImportExtension, System.ServiceModel.Description.IWsdlImportExtension {
    public ContextBindingElementImporter() { }
    public void BeforeImport(System.Web.Services.Description.ServiceDescriptionCollection wsdlDocuments, System.Xml.Schema.XmlSchemaSet xmlSchemas, System.Collections.Generic.ICollection<System.Xml.XmlElement> policy) { }
    public void ImportContract(System.ServiceModel.Description.WsdlImporter importer, System.ServiceModel.Description.WsdlContractConversionContext context) { }
    public void ImportEndpoint(System.ServiceModel.Description.WsdlImporter importer, System.ServiceModel.Description.WsdlEndpointConversionContext context) { }
    public virtual void ImportPolicy(System.ServiceModel.Description.MetadataImporter importer, System.ServiceModel.Description.PolicyConversionContext context) { }
  }
  [System.Runtime.CompilerServices.TypeForwardedFromAttribute("System.WorkflowServices, Version=3.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35")]
  public enum ContextExchangeMechanism {
    ContextSoapHeader = 0,
    HttpCookie = 1,
  }
  [System.Runtime.CompilerServices.TypeForwardedFromAttribute("System.WorkflowServices, Version=3.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35")]
  public partial class ContextMessageProperty : System.ServiceModel.Channels.IMessageProperty {
    public ContextMessageProperty() { }
    public ContextMessageProperty(System.Collections.Generic.IDictionary<System.String, System.String> context) { }
    public System.Collections.Generic.IDictionary<System.String, System.String> Context { get { return default(System.Collections.Generic.IDictionary<System.String, System.String>); } }
    public static string Name { get { return default(string); } }
    public void AddOrReplaceInMessage(System.ServiceModel.Channels.Message message) { }
    public void AddOrReplaceInMessageProperties(System.ServiceModel.Channels.MessageProperties properties) { }
    public System.ServiceModel.Channels.IMessageProperty CreateCopy() { return default(System.ServiceModel.Channels.IMessageProperty); }
    public static bool TryCreateFromHttpCookieHeader(string httpCookieHeader, out System.ServiceModel.Channels.ContextMessageProperty context) { context = default(System.ServiceModel.Channels.ContextMessageProperty); return default(bool); }
    public static bool TryGet(System.ServiceModel.Channels.Message message, out System.ServiceModel.Channels.ContextMessageProperty contextMessageProperty) { contextMessageProperty = default(System.ServiceModel.Channels.ContextMessageProperty); return default(bool); }
    public static bool TryGet(System.ServiceModel.Channels.MessageProperties properties, out System.ServiceModel.Channels.ContextMessageProperty contextMessageProperty) { contextMessageProperty = default(System.ServiceModel.Channels.ContextMessageProperty); return default(bool); }
  }
  public abstract partial class CorrelationCallbackMessageProperty : System.ServiceModel.Channels.IMessageProperty {
    protected CorrelationCallbackMessageProperty(System.Collections.Generic.ICollection<System.String> neededData) { }
    protected CorrelationCallbackMessageProperty(System.ServiceModel.Channels.CorrelationCallbackMessageProperty callback) { }
    public bool IsFullyDefined { get { return default(bool); } }
    public static string Name { get { return default(string); } }
    public System.Collections.Generic.IEnumerable<System.String> NeededData { get { return default(System.Collections.Generic.IEnumerable<System.String>); } }
    public void AddData(string name, System.Func<System.String> value) { }
    public System.IAsyncResult BeginFinalizeCorrelation(System.ServiceModel.Channels.Message message, System.TimeSpan timeout, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    public abstract System.ServiceModel.Channels.IMessageProperty CreateCopy();
    public System.ServiceModel.Channels.Message EndFinalizeCorrelation(System.IAsyncResult result) { return default(System.ServiceModel.Channels.Message); }
    public System.ServiceModel.Channels.Message FinalizeCorrelation(System.ServiceModel.Channels.Message message, System.TimeSpan timeout) { return default(System.ServiceModel.Channels.Message); }
    protected abstract System.IAsyncResult OnBeginFinalizeCorrelation(System.ServiceModel.Channels.Message message, System.TimeSpan timeout, System.AsyncCallback callback, object state);
    protected abstract System.ServiceModel.Channels.Message OnEndFinalizeCorrelation(System.IAsyncResult result);
    protected abstract System.ServiceModel.Channels.Message OnFinalizeCorrelation(System.ServiceModel.Channels.Message message, System.TimeSpan timeout);
    public static bool TryGet(System.ServiceModel.Channels.Message message, out System.ServiceModel.Channels.CorrelationCallbackMessageProperty property) { property = default(System.ServiceModel.Channels.CorrelationCallbackMessageProperty); return default(bool); }
    public static bool TryGet(System.ServiceModel.Channels.MessageProperties properties, out System.ServiceModel.Channels.CorrelationCallbackMessageProperty property) { property = default(System.ServiceModel.Channels.CorrelationCallbackMessageProperty); return default(bool); }
  }
  public abstract partial class CorrelationDataDescription {
    protected CorrelationDataDescription() { }
    public abstract bool IsDefault { get; }
    public abstract bool IsOptional { get; }
    public abstract bool KnownBeforeSend { get; }
    public abstract string Name { get; }
    public abstract bool ReceiveValue { get; }
    public abstract bool SendValue { get; }
  }
  public partial class CorrelationDataMessageProperty : System.ServiceModel.Channels.IMessageProperty {
    public CorrelationDataMessageProperty() { }
    public static string Name { get { return default(string); } }
    public void Add(string name, System.Func<System.String> dataProvider) { }
    public static void AddData(System.ServiceModel.Channels.Message message, string name, System.Func<System.String> dataProvider) { }
    public System.ServiceModel.Channels.IMessageProperty CreateCopy() { return default(System.ServiceModel.Channels.IMessageProperty); }
    public bool Remove(string name) { return default(bool); }
    public static bool TryGet(System.ServiceModel.Channels.Message message, out System.ServiceModel.Channels.CorrelationDataMessageProperty property) { property = default(System.ServiceModel.Channels.CorrelationDataMessageProperty); return default(bool); }
    public static bool TryGet(System.ServiceModel.Channels.MessageProperties properties, out System.ServiceModel.Channels.CorrelationDataMessageProperty property) { property = default(System.ServiceModel.Channels.CorrelationDataMessageProperty); return default(bool); }
    public bool TryGetValue(string name, out string value) { value = default(string); return default(bool); }
  }
  public sealed partial class CorrelationKey : System.Runtime.DurableInstancing.InstanceKey {
    public CorrelationKey(System.Collections.Generic.IDictionary<System.String, System.String> keyData, System.Xml.Linq.XName scopeName, System.Xml.Linq.XNamespace provider) : base (default(System.Guid)) { }
    public System.Collections.Generic.IDictionary<System.String, System.String> KeyData { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Collections.Generic.IDictionary<System.String, System.String>); } }
    public string KeyString { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
    public string Name { get { return default(string); } set { } }
    public System.Xml.Linq.XNamespace Provider { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Xml.Linq.XNamespace); } }
    public System.Xml.Linq.XName ScopeName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Xml.Linq.XName); } }
  }
  [System.Runtime.Serialization.DataContractAttribute]
  public partial class CorrelationMessageProperty {
    public CorrelationMessageProperty(System.Runtime.DurableInstancing.InstanceKey correlationKey, System.Collections.Generic.IEnumerable<System.Runtime.DurableInstancing.InstanceKey> additionalKeys) { }
    public CorrelationMessageProperty(System.Runtime.DurableInstancing.InstanceKey correlationKey, System.Collections.Generic.IEnumerable<System.Runtime.DurableInstancing.InstanceKey> additionalKeys, System.Collections.Generic.IEnumerable<System.Runtime.DurableInstancing.InstanceKey> transientCorrelations) { }
    public System.Collections.ObjectModel.ReadOnlyCollection<System.Runtime.DurableInstancing.InstanceKey> AdditionalKeys { get { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.Runtime.DurableInstancing.InstanceKey>); } }
    public System.Runtime.DurableInstancing.InstanceKey CorrelationKey { get { return default(System.Runtime.DurableInstancing.InstanceKey); } }
    public static string Name { get { return default(string); } }
    public System.Collections.ObjectModel.ReadOnlyCollection<System.Runtime.DurableInstancing.InstanceKey> TransientCorrelations { get { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.Runtime.DurableInstancing.InstanceKey>); } }
    public static bool TryGet(System.ServiceModel.Channels.Message message, out System.ServiceModel.Channels.CorrelationMessageProperty property) { property = default(System.ServiceModel.Channels.CorrelationMessageProperty); return default(bool); }
    public static bool TryGet(System.ServiceModel.Channels.MessageProperties properties, out System.ServiceModel.Channels.CorrelationMessageProperty property) { property = default(System.ServiceModel.Channels.CorrelationMessageProperty); return default(bool); }
  }
  [System.Windows.Markup.ContentPropertyAttribute("Elements")]
  public partial class CustomBinding : System.ServiceModel.Channels.Binding {
    public CustomBinding() { }
    public CustomBinding(System.Collections.Generic.IEnumerable<System.ServiceModel.Channels.BindingElement> bindingElementsInTopDownChannelStackOrder) { }
    public CustomBinding(System.ServiceModel.Channels.Binding binding) { }
    public CustomBinding(params System.ServiceModel.Channels.BindingElement[] bindingElementsInTopDownChannelStackOrder) { }
    public CustomBinding(string configurationName) { }
    public CustomBinding(string name, string ns, params System.ServiceModel.Channels.BindingElement[] bindingElementsInTopDownChannelStackOrder) { }
    public System.ServiceModel.Channels.BindingElementCollection Elements { get { return default(System.ServiceModel.Channels.BindingElementCollection); } }
    public override string Scheme { get { return default(string); } }
    public override System.ServiceModel.Channels.BindingElementCollection CreateBindingElements() { return default(System.ServiceModel.Channels.BindingElementCollection); }
  }
  public enum DeliveryFailure {
    AccessDenied = 32772,
    BadDestinationQueue = 32768,
    BadEncryption = 32775,
    BadSignature = 32774,
    CouldNotEncrypt = 32776,
    HopCountExceeded = 32773,
    NotTransactionalMessage = 32778,
    NotTransactionalQueue = 32777,
    Purged = 32769,
    QueueDeleted = 49152,
    QueueExceedMaximumSize = 32771,
    QueuePurged = 49153,
    ReachQueueTimeout = 32770,
    ReceiveTimeout = 49154,
    Unknown = 0,
  }
  public enum DeliveryStatus {
    InDoubt = 0,
    NotDelivered = 1,
  }
  public abstract partial class FaultConverter {
    protected FaultConverter() { }
    public static System.ServiceModel.Channels.FaultConverter GetDefaultFaultConverter(System.ServiceModel.Channels.MessageVersion version) { return default(System.ServiceModel.Channels.FaultConverter); }
    protected abstract bool OnTryCreateException(System.ServiceModel.Channels.Message message, System.ServiceModel.Channels.MessageFault fault, out System.Exception exception);
    protected abstract bool OnTryCreateFaultMessage(System.Exception exception, out System.ServiceModel.Channels.Message message);
    public bool TryCreateException(System.ServiceModel.Channels.Message message, System.ServiceModel.Channels.MessageFault fault, out System.Exception exception) { exception = default(System.Exception); return default(bool); }
    public bool TryCreateFaultMessage(System.Exception exception, out System.ServiceModel.Channels.Message message) { message = default(System.ServiceModel.Channels.Message); return default(bool); }
  }
  [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
  [System.ObsoleteAttribute("This type is obsolete. To enable the Http CookieContainer, use the AllowCookies property on the http binding or on the HttpTransportBindingElement.", false)]
  public partial class HttpCookieContainerBindingElement : System.ServiceModel.Channels.BindingElement {
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.ObsoleteAttribute("This type is obsolete. To enable the Http CookieContainer, use the AllowCookies property on the http binding or on the HttpTransportBindingElement.", false)]
    public HttpCookieContainerBindingElement() { }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.ObsoleteAttribute("This type is obsolete. To enable the Http CookieContainer, use the AllowCookies property on the http binding or on the HttpTransportBindingElement.", false)]
    protected HttpCookieContainerBindingElement(System.ServiceModel.Channels.HttpCookieContainerBindingElement elementToBeCloned) { }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public override System.ServiceModel.Channels.IChannelFactory<TChannel> BuildChannelFactory<TChannel>(System.ServiceModel.Channels.BindingContext context) { return default(System.ServiceModel.Channels.IChannelFactory<TChannel>); }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public override System.ServiceModel.Channels.BindingElement Clone() { return default(System.ServiceModel.Channels.BindingElement); }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public override T GetProperty<T>(System.ServiceModel.Channels.BindingContext context) { return default(T); }
  }
  public partial class HttpMessageHandlerFactory {
    [System.Security.SecuritySafeCriticalAttribute]
    [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.Demand, Unrestricted=true)]
    protected HttpMessageHandlerFactory() { }
    [System.Security.SecuritySafeCriticalAttribute]
    [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.Demand, Unrestricted=true)]
    public HttpMessageHandlerFactory(System.Func<System.Collections.Generic.IEnumerable<System.Net.Http.DelegatingHandler>> handlers) { }
    [System.Security.SecuritySafeCriticalAttribute]
    [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.Demand, Unrestricted=true)]
    public HttpMessageHandlerFactory(params System.Type[] handlers) { }
    [System.Security.SecuritySafeCriticalAttribute]
    [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.Demand, Unrestricted=true)]
    public System.Net.Http.HttpMessageHandler Create(System.Net.Http.HttpMessageHandler innerChannel) { return default(System.Net.Http.HttpMessageHandler); }
    protected virtual System.Net.Http.HttpMessageHandler OnCreate(System.Net.Http.HttpMessageHandler innerChannel) { return default(System.Net.Http.HttpMessageHandler); }
  }
  public sealed partial class HttpMessageSettings : System.IEquatable<System.ServiceModel.Channels.HttpMessageSettings> {
    public HttpMessageSettings() { }
    public bool HttpMessagesSupported { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public bool Equals(System.ServiceModel.Channels.HttpMessageSettings other) { return default(bool); }
  }
  public static partial class HttpRequestMessageExtensionMethods {
    public static System.Security.Principal.IPrincipal GetUserPrincipal(this System.Net.Http.HttpRequestMessage httpRequestMessage) { return default(System.Security.Principal.IPrincipal); }
    public static void SetUserPrincipal(this System.Net.Http.HttpRequestMessage httpRequestMessage, System.Security.Principal.IPrincipal user) { }
  }
  public sealed partial class HttpRequestMessageProperty : System.ServiceModel.Channels.IMessageProperty {
    public HttpRequestMessageProperty() { }
    public System.Net.WebHeaderCollection Headers { get { return default(System.Net.WebHeaderCollection); } }
    public string Method { get { return default(string); } set { } }
    public static string Name { get { return default(string); } }
    public string QueryString { get { return default(string); } set { } }
    public bool SuppressEntityBody { get { return default(bool); } set { } }
    System.ServiceModel.Channels.IMessageProperty System.ServiceModel.Channels.IMessageProperty.CreateCopy() { return default(System.ServiceModel.Channels.IMessageProperty); }
  }
  public sealed partial class HttpResponseMessageProperty : System.ServiceModel.Channels.IMessageProperty {
    public HttpResponseMessageProperty() { }
    public System.Net.WebHeaderCollection Headers { get { return default(System.Net.WebHeaderCollection); } }
    public static string Name { get { return default(string); } }
    public System.Net.HttpStatusCode StatusCode { get { return default(System.Net.HttpStatusCode); } set { } }
    public string StatusDescription { get { return default(string); } set { } }
    public bool SuppressEntityBody { get { return default(bool); } set { } }
    public bool SuppressPreamble { get { return default(bool); } set { } }
    System.ServiceModel.Channels.IMessageProperty System.ServiceModel.Channels.IMessageProperty.CreateCopy() { return default(System.ServiceModel.Channels.IMessageProperty); }
  }
  public partial class HttpsTransportBindingElement : System.ServiceModel.Channels.HttpTransportBindingElement, System.ServiceModel.Channels.ITransportTokenAssertionProvider {
    public HttpsTransportBindingElement() { }
    protected HttpsTransportBindingElement(System.ServiceModel.Channels.HttpsTransportBindingElement elementToBeCloned) { }
    [System.ComponentModel.DefaultValueAttribute(false)]
    public bool RequireClientCertificate { get { return default(bool); } set { } }
    public override string Scheme { get { return default(string); } }
    public override System.ServiceModel.Channels.IChannelFactory<TChannel> BuildChannelFactory<TChannel>(System.ServiceModel.Channels.BindingContext context) { return default(System.ServiceModel.Channels.IChannelFactory<TChannel>); }
    public override System.ServiceModel.Channels.IChannelListener<TChannel> BuildChannelListener<TChannel>(System.ServiceModel.Channels.BindingContext context) { return default(System.ServiceModel.Channels.IChannelListener<TChannel>); }
    public override System.ServiceModel.Channels.BindingElement Clone() { return default(System.ServiceModel.Channels.BindingElement); }
    public override T GetProperty<T>(System.ServiceModel.Channels.BindingContext context) { return default(T); }
    public System.Xml.XmlElement GetTransportTokenAssertion() { return default(System.Xml.XmlElement); }
  }
  public partial class HttpTransportBindingElement : System.ServiceModel.Channels.TransportBindingElement, System.ServiceModel.Description.IPolicyExportExtension, System.ServiceModel.Description.IWsdlExportExtension {
    public HttpTransportBindingElement() { }
    protected HttpTransportBindingElement(System.ServiceModel.Channels.HttpTransportBindingElement elementToBeCloned) { }
    [System.ComponentModel.DefaultValueAttribute(false)]
    public bool AllowCookies { get { return default(bool); } set { } }
    [System.ComponentModel.DefaultValueAttribute((System.Net.AuthenticationSchemes)(32768))]
    public System.Net.AuthenticationSchemes AuthenticationScheme { get { return default(System.Net.AuthenticationSchemes); } set { } }
    [System.ComponentModel.DefaultValueAttribute(false)]
    public bool BypassProxyOnLocal { get { return default(bool); } set { } }
    [System.ComponentModel.DefaultValueAttribute(true)]
    public bool DecompressionEnabled { get { return default(bool); } set { } }
    public System.Security.Authentication.ExtendedProtection.ExtendedProtectionPolicy ExtendedProtectionPolicy { get { return default(System.Security.Authentication.ExtendedProtection.ExtendedProtectionPolicy); } set { } }
    [System.ComponentModel.DefaultValueAttribute((System.ServiceModel.HostNameComparisonMode)(0))]
    public System.ServiceModel.HostNameComparisonMode HostNameComparisonMode { get { return default(System.ServiceModel.HostNameComparisonMode); } set { } }
    [System.ComponentModel.DefaultValueAttribute(true)]
    public bool KeepAliveEnabled { get { return default(bool); } set { } }
    [System.ComponentModel.DefaultValueAttribute(65536)]
    public int MaxBufferSize { get { return default(int); } set { } }
    [System.ComponentModel.DefaultValueAttribute(0)]
    public int MaxPendingAccepts { get { return default(int); } set { } }
    public System.ServiceModel.Channels.HttpMessageHandlerFactory MessageHandlerFactory { get { return default(System.ServiceModel.Channels.HttpMessageHandlerFactory); } set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.UriTypeConverter))]
    public System.Uri ProxyAddress { get { return default(System.Uri); } set { } }
    [System.ComponentModel.DefaultValueAttribute((System.Net.AuthenticationSchemes)(32768))]
    public System.Net.AuthenticationSchemes ProxyAuthenticationScheme { get { return default(System.Net.AuthenticationSchemes); } set { } }
    [System.ComponentModel.DefaultValueAttribute("")]
    public string Realm { get { return default(string); } set { } }
    [System.ComponentModel.DefaultValueAttribute(typeof(System.TimeSpan), "00:00:00")]
    public System.TimeSpan RequestInitializationTimeout { get { return default(System.TimeSpan); } set { } }
    public override string Scheme { get { return default(string); } }
    [System.ComponentModel.DefaultValueAttribute((System.ServiceModel.TransferMode)(0))]
    public System.ServiceModel.TransferMode TransferMode { get { return default(System.ServiceModel.TransferMode); } set { } }
    [System.ComponentModel.DefaultValueAttribute(false)]
    public bool UnsafeConnectionNtlmAuthentication { get { return default(bool); } set { } }
    [System.ComponentModel.DefaultValueAttribute(true)]
    public bool UseDefaultWebProxy { get { return default(bool); } set { } }
    public System.ServiceModel.Channels.WebSocketTransportSettings WebSocketSettings { get { return default(System.ServiceModel.Channels.WebSocketTransportSettings); } set { } }
    public override System.ServiceModel.Channels.IChannelFactory<TChannel> BuildChannelFactory<TChannel>(System.ServiceModel.Channels.BindingContext context) { return default(System.ServiceModel.Channels.IChannelFactory<TChannel>); }
    public override System.ServiceModel.Channels.IChannelListener<TChannel> BuildChannelListener<TChannel>(System.ServiceModel.Channels.BindingContext context) { return default(System.ServiceModel.Channels.IChannelListener<TChannel>); }
    public override bool CanBuildChannelFactory<TChannel>(System.ServiceModel.Channels.BindingContext context) { return default(bool); }
    public override bool CanBuildChannelListener<TChannel>(System.ServiceModel.Channels.BindingContext context) { return default(bool); }
    public override System.ServiceModel.Channels.BindingElement Clone() { return default(System.ServiceModel.Channels.BindingElement); }
    public override T GetProperty<T>(System.ServiceModel.Channels.BindingContext context) { return default(T); }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public bool ShouldSerializeExtendedProtectionPolicy() { return default(bool); }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public bool ShouldSerializeMessageHandlerFactory() { return default(bool); }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public bool ShouldSerializeWebSocketSettings() { return default(bool); }
    void System.ServiceModel.Description.IPolicyExportExtension.ExportPolicy(System.ServiceModel.Description.MetadataExporter exporter, System.ServiceModel.Description.PolicyConversionContext context) { }
    void System.ServiceModel.Description.IWsdlExportExtension.ExportContract(System.ServiceModel.Description.WsdlExporter exporter, System.ServiceModel.Description.WsdlContractConversionContext context) { }
    void System.ServiceModel.Description.IWsdlExportExtension.ExportEndpoint(System.ServiceModel.Description.WsdlExporter exporter, System.ServiceModel.Description.WsdlEndpointConversionContext endpointContext) { }
    protected void UpdateAuthenticationSchemes(System.ServiceModel.Channels.BindingContext context) { }
  }
  public partial interface IAnonymousUriPrefixMatcher {
    void Register(System.Uri anonymousUriPrefix);
  }
  public partial interface IBindingDeliveryCapabilities {
    bool AssuresOrderedDelivery { get; }
    bool QueuedDelivery { get; }
  }
  public partial interface IBindingMulticastCapabilities {
    bool IsMulticast { get; }
  }
  public partial interface IBindingRuntimePreferences {
    bool ReceiveSynchronously { get; }
  }
  public partial interface IChannel : System.ServiceModel.ICommunicationObject {
    T GetProperty<T>() where T : class;
  }
  public partial interface IChannelFactory : System.ServiceModel.ICommunicationObject {
    T GetProperty<T>() where T : class;
  }
  public partial interface IChannelFactory<TChannel> : System.ServiceModel.Channels.IChannelFactory, System.ServiceModel.ICommunicationObject {
    TChannel CreateChannel(System.ServiceModel.EndpointAddress to);
    TChannel CreateChannel(System.ServiceModel.EndpointAddress to, System.Uri via);
  }
  public partial interface IChannelListener : System.ServiceModel.ICommunicationObject {
    System.Uri Uri { get; }
    System.IAsyncResult BeginWaitForChannel(System.TimeSpan timeout, System.AsyncCallback callback, object state);
    bool EndWaitForChannel(System.IAsyncResult result);
    T GetProperty<T>() where T : class;
    bool WaitForChannel(System.TimeSpan timeout);
  }
  public partial interface IChannelListener<TChannel> : System.ServiceModel.Channels.IChannelListener, System.ServiceModel.ICommunicationObject where TChannel : class, System.ServiceModel.Channels.IChannel {
    TChannel AcceptChannel();
    TChannel AcceptChannel(System.TimeSpan timeout);
    System.IAsyncResult BeginAcceptChannel(System.AsyncCallback callback, object state);
    System.IAsyncResult BeginAcceptChannel(System.TimeSpan timeout, System.AsyncCallback callback, object state);
    TChannel EndAcceptChannel(System.IAsyncResult result);
  }
  [System.Runtime.CompilerServices.TypeForwardedFromAttribute("System.WorkflowServices, Version=3.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35")]
  public partial interface IContextBindingElement {
  }
  [System.Runtime.CompilerServices.TypeForwardedFromAttribute("System.WorkflowServices, Version=3.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35")]
  public partial interface IContextManager {
    bool Enabled { get; set; }
    System.Collections.Generic.IDictionary<System.String, System.String> GetContext();
    void SetContext(System.Collections.Generic.IDictionary<System.String, System.String> context);
  }
  public partial interface ICorrelationDataSource {
    System.Collections.Generic.ICollection<System.ServiceModel.Channels.CorrelationDataDescription> DataSources { get; }
  }
  public partial interface IDuplexChannel : System.ServiceModel.Channels.IChannel, System.ServiceModel.Channels.IInputChannel, System.ServiceModel.Channels.IOutputChannel, System.ServiceModel.ICommunicationObject {
  }
  public partial interface IDuplexSession : System.ServiceModel.Channels.IInputSession, System.ServiceModel.Channels.IOutputSession, System.ServiceModel.Channels.ISession {
    System.IAsyncResult BeginCloseOutputSession(System.AsyncCallback callback, object state);
    System.IAsyncResult BeginCloseOutputSession(System.TimeSpan timeout, System.AsyncCallback callback, object state);
    void CloseOutputSession();
    void CloseOutputSession(System.TimeSpan timeout);
    void EndCloseOutputSession(System.IAsyncResult result);
  }
  public partial interface IDuplexSessionChannel : System.ServiceModel.Channels.IChannel, System.ServiceModel.Channels.IDuplexChannel, System.ServiceModel.Channels.IInputChannel, System.ServiceModel.Channels.IOutputChannel, System.ServiceModel.Channels.ISessionChannel<System.ServiceModel.Channels.IDuplexSession>, System.ServiceModel.ICommunicationObject {
  }
  public partial interface IHttpCookieContainerManager {
    System.Net.CookieContainer CookieContainer { get; set; }
  }
  public partial interface IInputChannel : System.ServiceModel.Channels.IChannel, System.ServiceModel.ICommunicationObject {
    System.ServiceModel.EndpointAddress LocalAddress { get; }
    System.IAsyncResult BeginReceive(System.AsyncCallback callback, object state);
    System.IAsyncResult BeginReceive(System.TimeSpan timeout, System.AsyncCallback callback, object state);
    System.IAsyncResult BeginTryReceive(System.TimeSpan timeout, System.AsyncCallback callback, object state);
    System.IAsyncResult BeginWaitForMessage(System.TimeSpan timeout, System.AsyncCallback callback, object state);
    System.ServiceModel.Channels.Message EndReceive(System.IAsyncResult result);
    bool EndTryReceive(System.IAsyncResult result, out System.ServiceModel.Channels.Message message);
    bool EndWaitForMessage(System.IAsyncResult result);
    System.ServiceModel.Channels.Message Receive();
    System.ServiceModel.Channels.Message Receive(System.TimeSpan timeout);
    bool TryReceive(System.TimeSpan timeout, out System.ServiceModel.Channels.Message message);
    bool WaitForMessage(System.TimeSpan timeout);
  }
  public partial interface IInputSession : System.ServiceModel.Channels.ISession {
  }
  public partial interface IInputSessionChannel : System.ServiceModel.Channels.IChannel, System.ServiceModel.Channels.IInputChannel, System.ServiceModel.Channels.ISessionChannel<System.ServiceModel.Channels.IInputSession>, System.ServiceModel.ICommunicationObject {
  }
  public partial interface IMessageProperty {
    System.ServiceModel.Channels.IMessageProperty CreateCopy();
  }
  public partial class InvalidChannelBindingException : System.Exception {
    public InvalidChannelBindingException() { }
    protected InvalidChannelBindingException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public InvalidChannelBindingException(string message) { }
    public InvalidChannelBindingException(string message, System.Exception innerException) { }
  }
  public partial interface IOutputChannel : System.ServiceModel.Channels.IChannel, System.ServiceModel.ICommunicationObject {
    System.ServiceModel.EndpointAddress RemoteAddress { get; }
    System.Uri Via { get; }
    System.IAsyncResult BeginSend(System.ServiceModel.Channels.Message message, System.AsyncCallback callback, object state);
    System.IAsyncResult BeginSend(System.ServiceModel.Channels.Message message, System.TimeSpan timeout, System.AsyncCallback callback, object state);
    void EndSend(System.IAsyncResult result);
    void Send(System.ServiceModel.Channels.Message message);
    void Send(System.ServiceModel.Channels.Message message, System.TimeSpan timeout);
  }
  public partial interface IOutputSession : System.ServiceModel.Channels.ISession {
  }
  public partial interface IOutputSessionChannel : System.ServiceModel.Channels.IChannel, System.ServiceModel.Channels.IOutputChannel, System.ServiceModel.Channels.ISessionChannel<System.ServiceModel.Channels.IOutputSession>, System.ServiceModel.ICommunicationObject {
  }
  public partial interface IReceiveContextSettings {
    bool Enabled { get; set; }
    System.TimeSpan ValidityDuration { get; }
  }
  public partial interface IReplyChannel : System.ServiceModel.Channels.IChannel, System.ServiceModel.ICommunicationObject {
    System.ServiceModel.EndpointAddress LocalAddress { get; }
    System.IAsyncResult BeginReceiveRequest(System.AsyncCallback callback, object state);
    System.IAsyncResult BeginReceiveRequest(System.TimeSpan timeout, System.AsyncCallback callback, object state);
    System.IAsyncResult BeginTryReceiveRequest(System.TimeSpan timeout, System.AsyncCallback callback, object state);
    System.IAsyncResult BeginWaitForRequest(System.TimeSpan timeout, System.AsyncCallback callback, object state);
    System.ServiceModel.Channels.RequestContext EndReceiveRequest(System.IAsyncResult result);
    bool EndTryReceiveRequest(System.IAsyncResult result, out System.ServiceModel.Channels.RequestContext context);
    bool EndWaitForRequest(System.IAsyncResult result);
    System.ServiceModel.Channels.RequestContext ReceiveRequest();
    System.ServiceModel.Channels.RequestContext ReceiveRequest(System.TimeSpan timeout);
    bool TryReceiveRequest(System.TimeSpan timeout, out System.ServiceModel.Channels.RequestContext context);
    bool WaitForRequest(System.TimeSpan timeout);
  }
  public partial interface IReplySessionChannel : System.ServiceModel.Channels.IChannel, System.ServiceModel.Channels.IReplyChannel, System.ServiceModel.Channels.ISessionChannel<System.ServiceModel.Channels.IInputSession>, System.ServiceModel.ICommunicationObject {
  }
  public partial interface IRequestChannel : System.ServiceModel.Channels.IChannel, System.ServiceModel.ICommunicationObject {
    System.ServiceModel.EndpointAddress RemoteAddress { get; }
    System.Uri Via { get; }
    System.IAsyncResult BeginRequest(System.ServiceModel.Channels.Message message, System.AsyncCallback callback, object state);
    System.IAsyncResult BeginRequest(System.ServiceModel.Channels.Message message, System.TimeSpan timeout, System.AsyncCallback callback, object state);
    System.ServiceModel.Channels.Message EndRequest(System.IAsyncResult result);
    System.ServiceModel.Channels.Message Request(System.ServiceModel.Channels.Message message);
    System.ServiceModel.Channels.Message Request(System.ServiceModel.Channels.Message message, System.TimeSpan timeout);
  }
  public partial interface IRequestSessionChannel : System.ServiceModel.Channels.IChannel, System.ServiceModel.Channels.IRequestChannel, System.ServiceModel.Channels.ISessionChannel<System.ServiceModel.Channels.IOutputSession>, System.ServiceModel.ICommunicationObject {
  }
  public partial interface ISecurityCapabilities {
    System.Net.Security.ProtectionLevel SupportedRequestProtectionLevel { get; }
    System.Net.Security.ProtectionLevel SupportedResponseProtectionLevel { get; }
    bool SupportsClientAuthentication { get; }
    bool SupportsClientWindowsIdentity { get; }
    bool SupportsServerAuthentication { get; }
  }
  public partial interface ISession {
    string Id { get; }
  }
  public partial interface ISessionChannel<TSession> where TSession : System.ServiceModel.Channels.ISession {
    TSession Session { get; }
  }
  public partial interface ITransactedBindingElement {
    bool TransactedReceiveEnabled { get; }
  }
  public partial interface ITransportTokenAssertionProvider {
    System.Xml.XmlElement GetTransportTokenAssertion();
  }
  public partial interface IWebSocketCloseDetails {
    System.Nullable<System.Net.WebSockets.WebSocketCloseStatus> InputCloseStatus { get; }
    string InputCloseStatusDescription { get; }
    void SetOutputCloseStatus(System.Net.WebSockets.WebSocketCloseStatus closeStatus, string closeStatusDescription);
  }
  public sealed partial class LocalClientSecuritySettings {
    public LocalClientSecuritySettings() { }
    public bool CacheCookies { get { return default(bool); } set { } }
    public int CookieRenewalThresholdPercentage { get { return default(int); } set { } }
    public bool DetectReplays { get { return default(bool); } set { } }
    public System.ServiceModel.Security.IdentityVerifier IdentityVerifier { get { return default(System.ServiceModel.Security.IdentityVerifier); } set { } }
    public System.TimeSpan MaxClockSkew { get { return default(System.TimeSpan); } set { } }
    public System.TimeSpan MaxCookieCachingTime { get { return default(System.TimeSpan); } set { } }
    public System.ServiceModel.Security.NonceCache NonceCache { get { return default(System.ServiceModel.Security.NonceCache); } set { } }
    public bool ReconnectTransportOnFailure { get { return default(bool); } set { } }
    public int ReplayCacheSize { get { return default(int); } set { } }
    public System.TimeSpan ReplayWindow { get { return default(System.TimeSpan); } set { } }
    public System.TimeSpan SessionKeyRenewalInterval { get { return default(System.TimeSpan); } set { } }
    public System.TimeSpan SessionKeyRolloverInterval { get { return default(System.TimeSpan); } set { } }
    public System.TimeSpan TimestampValidityDuration { get { return default(System.TimeSpan); } set { } }
    public System.ServiceModel.Channels.LocalClientSecuritySettings Clone() { return default(System.ServiceModel.Channels.LocalClientSecuritySettings); }
  }
  public sealed partial class LocalServiceSecuritySettings {
    public LocalServiceSecuritySettings() { }
    public bool DetectReplays { get { return default(bool); } set { } }
    public System.TimeSpan InactivityTimeout { get { return default(System.TimeSpan); } set { } }
    public System.TimeSpan IssuedCookieLifetime { get { return default(System.TimeSpan); } set { } }
    public int MaxCachedCookies { get { return default(int); } set { } }
    public System.TimeSpan MaxClockSkew { get { return default(System.TimeSpan); } set { } }
    public int MaxPendingSessions { get { return default(int); } set { } }
    public int MaxStatefulNegotiations { get { return default(int); } set { } }
    public System.TimeSpan NegotiationTimeout { get { return default(System.TimeSpan); } set { } }
    public System.ServiceModel.Security.NonceCache NonceCache { get { return default(System.ServiceModel.Security.NonceCache); } set { } }
    public bool ReconnectTransportOnFailure { get { return default(bool); } set { } }
    public int ReplayCacheSize { get { return default(int); } set { } }
    public System.TimeSpan ReplayWindow { get { return default(System.TimeSpan); } set { } }
    public System.TimeSpan SessionKeyRenewalInterval { get { return default(System.TimeSpan); } set { } }
    public System.TimeSpan SessionKeyRolloverInterval { get { return default(System.TimeSpan); } set { } }
    public System.TimeSpan TimestampValidityDuration { get { return default(System.TimeSpan); } set { } }
    public System.ServiceModel.Channels.LocalServiceSecuritySettings Clone() { return default(System.ServiceModel.Channels.LocalServiceSecuritySettings); }
  }
  public abstract partial class Message : System.IDisposable {
    protected Message() { }
    public abstract System.ServiceModel.Channels.MessageHeaders Headers { get; }
    protected bool IsDisposed { get { return default(bool); } }
    public virtual bool IsEmpty { get { return default(bool); } }
    public virtual bool IsFault { get { return default(bool); } }
    public abstract System.ServiceModel.Channels.MessageProperties Properties { get; }
    public System.ServiceModel.Channels.MessageState State { get { return default(System.ServiceModel.Channels.MessageState); } }
    public abstract System.ServiceModel.Channels.MessageVersion Version { get; }
    public System.IAsyncResult BeginWriteBodyContents(System.Xml.XmlDictionaryWriter writer, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    public System.IAsyncResult BeginWriteMessage(System.Xml.XmlDictionaryWriter writer, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    public void Close() { }
    public System.ServiceModel.Channels.MessageBuffer CreateBufferedCopy(int maxBufferSize) { return default(System.ServiceModel.Channels.MessageBuffer); }
    public static System.ServiceModel.Channels.Message CreateMessage(System.ServiceModel.Channels.MessageVersion version, System.ServiceModel.Channels.MessageFault fault, string action) { return default(System.ServiceModel.Channels.Message); }
    public static System.ServiceModel.Channels.Message CreateMessage(System.ServiceModel.Channels.MessageVersion version, System.ServiceModel.FaultCode faultCode, string reason, object detail, string action) { return default(System.ServiceModel.Channels.Message); }
    public static System.ServiceModel.Channels.Message CreateMessage(System.ServiceModel.Channels.MessageVersion version, System.ServiceModel.FaultCode faultCode, string reason, string action) { return default(System.ServiceModel.Channels.Message); }
    public static System.ServiceModel.Channels.Message CreateMessage(System.ServiceModel.Channels.MessageVersion version, string action) { return default(System.ServiceModel.Channels.Message); }
    public static System.ServiceModel.Channels.Message CreateMessage(System.ServiceModel.Channels.MessageVersion version, string action, object body) { return default(System.ServiceModel.Channels.Message); }
    public static System.ServiceModel.Channels.Message CreateMessage(System.ServiceModel.Channels.MessageVersion version, string action, object body, System.Runtime.Serialization.XmlObjectSerializer serializer) { return default(System.ServiceModel.Channels.Message); }
    public static System.ServiceModel.Channels.Message CreateMessage(System.ServiceModel.Channels.MessageVersion version, string action, System.ServiceModel.Channels.BodyWriter body) { return default(System.ServiceModel.Channels.Message); }
    public static System.ServiceModel.Channels.Message CreateMessage(System.ServiceModel.Channels.MessageVersion version, string action, System.Xml.XmlDictionaryReader body) { return default(System.ServiceModel.Channels.Message); }
    public static System.ServiceModel.Channels.Message CreateMessage(System.ServiceModel.Channels.MessageVersion version, string action, System.Xml.XmlReader body) { return default(System.ServiceModel.Channels.Message); }
    public static System.ServiceModel.Channels.Message CreateMessage(System.Xml.XmlDictionaryReader envelopeReader, int maxSizeOfHeaders, System.ServiceModel.Channels.MessageVersion version) { return default(System.ServiceModel.Channels.Message); }
    public static System.ServiceModel.Channels.Message CreateMessage(System.Xml.XmlReader envelopeReader, int maxSizeOfHeaders, System.ServiceModel.Channels.MessageVersion version) { return default(System.ServiceModel.Channels.Message); }
    public void EndWriteBodyContents(System.IAsyncResult result) { }
    public void EndWriteMessage(System.IAsyncResult result) { }
    public T GetBody<T>() { return default(T); }
    public T GetBody<T>(System.Runtime.Serialization.XmlObjectSerializer serializer) { return default(T); }
    public string GetBodyAttribute(string localName, string ns) { return default(string); }
    public System.Xml.XmlDictionaryReader GetReaderAtBodyContents() { return default(System.Xml.XmlDictionaryReader); }
    protected virtual System.IAsyncResult OnBeginWriteBodyContents(System.Xml.XmlDictionaryWriter writer, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    protected virtual System.IAsyncResult OnBeginWriteMessage(System.Xml.XmlDictionaryWriter writer, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    protected virtual void OnBodyToString(System.Xml.XmlDictionaryWriter writer) { }
    protected virtual void OnClose() { }
    protected virtual System.ServiceModel.Channels.MessageBuffer OnCreateBufferedCopy(int maxBufferSize) { return default(System.ServiceModel.Channels.MessageBuffer); }
    protected virtual void OnEndWriteBodyContents(System.IAsyncResult result) { }
    protected virtual void OnEndWriteMessage(System.IAsyncResult result) { }
    protected virtual T OnGetBody<T>(System.Xml.XmlDictionaryReader reader) { return default(T); }
    protected virtual string OnGetBodyAttribute(string localName, string ns) { return default(string); }
    protected virtual System.Xml.XmlDictionaryReader OnGetReaderAtBodyContents() { return default(System.Xml.XmlDictionaryReader); }
    protected abstract void OnWriteBodyContents(System.Xml.XmlDictionaryWriter writer);
    protected virtual void OnWriteMessage(System.Xml.XmlDictionaryWriter writer) { }
    protected virtual void OnWriteStartBody(System.Xml.XmlDictionaryWriter writer) { }
    protected virtual void OnWriteStartEnvelope(System.Xml.XmlDictionaryWriter writer) { }
    protected virtual void OnWriteStartHeaders(System.Xml.XmlDictionaryWriter writer) { }
    void System.IDisposable.Dispose() { }
    public override string ToString() { return default(string); }
    public void WriteBody(System.Xml.XmlDictionaryWriter writer) { }
    public void WriteBody(System.Xml.XmlWriter writer) { }
    public void WriteBodyContents(System.Xml.XmlDictionaryWriter writer) { }
    public void WriteMessage(System.Xml.XmlDictionaryWriter writer) { }
    public void WriteMessage(System.Xml.XmlWriter writer) { }
    public void WriteStartBody(System.Xml.XmlDictionaryWriter writer) { }
    public void WriteStartBody(System.Xml.XmlWriter writer) { }
    public void WriteStartEnvelope(System.Xml.XmlDictionaryWriter writer) { }
  }
  public abstract partial class MessageBuffer : System.IDisposable, System.Xml.XPath.IXPathNavigable {
    protected MessageBuffer() { }
    public abstract int BufferSize { get; }
    public virtual string MessageContentType { get { return default(string); } }
    public abstract void Close();
    public abstract System.ServiceModel.Channels.Message CreateMessage();
    public System.Xml.XPath.XPathNavigator CreateNavigator() { return default(System.Xml.XPath.XPathNavigator); }
    public System.Xml.XPath.XPathNavigator CreateNavigator(int nodeQuota) { return default(System.Xml.XPath.XPathNavigator); }
    public System.Xml.XPath.XPathNavigator CreateNavigator(int nodeQuota, System.Xml.XmlSpace space) { return default(System.Xml.XPath.XPathNavigator); }
    public System.Xml.XPath.XPathNavigator CreateNavigator(System.Xml.XmlSpace space) { return default(System.Xml.XPath.XPathNavigator); }
    void System.IDisposable.Dispose() { }
    public virtual void WriteMessage(System.IO.Stream stream) { }
  }
  public abstract partial class MessageEncoder {
    protected MessageEncoder() { }
    public abstract string ContentType { get; }
    public abstract string MediaType { get; }
    public abstract System.ServiceModel.Channels.MessageVersion MessageVersion { get; }
    public virtual System.IAsyncResult BeginWriteMessage(System.ServiceModel.Channels.Message message, System.IO.Stream stream, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    public virtual void EndWriteMessage(System.IAsyncResult result) { }
    public virtual T GetProperty<T>() where T : class { return default(T); }
    public virtual bool IsContentTypeSupported(string contentType) { return default(bool); }
    public System.ServiceModel.Channels.Message ReadMessage(System.ArraySegment<System.Byte> buffer, System.ServiceModel.Channels.BufferManager bufferManager) { return default(System.ServiceModel.Channels.Message); }
    public abstract System.ServiceModel.Channels.Message ReadMessage(System.ArraySegment<System.Byte> buffer, System.ServiceModel.Channels.BufferManager bufferManager, string contentType);
    public System.ServiceModel.Channels.Message ReadMessage(System.IO.Stream stream, int maxSizeOfHeaders) { return default(System.ServiceModel.Channels.Message); }
    public abstract System.ServiceModel.Channels.Message ReadMessage(System.IO.Stream stream, int maxSizeOfHeaders, string contentType);
    public override string ToString() { return default(string); }
    public System.ArraySegment<System.Byte> WriteMessage(System.ServiceModel.Channels.Message message, int maxMessageSize, System.ServiceModel.Channels.BufferManager bufferManager) { return default(System.ArraySegment<System.Byte>); }
    public abstract System.ArraySegment<System.Byte> WriteMessage(System.ServiceModel.Channels.Message message, int maxMessageSize, System.ServiceModel.Channels.BufferManager bufferManager, int messageOffset);
    public abstract void WriteMessage(System.ServiceModel.Channels.Message message, System.IO.Stream stream);
  }
  public abstract partial class MessageEncoderFactory {
    protected MessageEncoderFactory() { }
    public abstract System.ServiceModel.Channels.MessageEncoder Encoder { get; }
    public abstract System.ServiceModel.Channels.MessageVersion MessageVersion { get; }
    public virtual System.ServiceModel.Channels.MessageEncoder CreateSessionEncoder() { return default(System.ServiceModel.Channels.MessageEncoder); }
  }
  public abstract partial class MessageEncodingBindingElement : System.ServiceModel.Channels.BindingElement {
    protected MessageEncodingBindingElement() { }
    protected MessageEncodingBindingElement(System.ServiceModel.Channels.MessageEncodingBindingElement elementToBeCloned) { }
    public abstract System.ServiceModel.Channels.MessageVersion MessageVersion { get; set; }
    public abstract System.ServiceModel.Channels.MessageEncoderFactory CreateMessageEncoderFactory();
    public override T GetProperty<T>(System.ServiceModel.Channels.BindingContext context) { return default(T); }
  }
  public partial class MessageEncodingBindingElementImporter : System.ServiceModel.Description.IPolicyImportExtension, System.ServiceModel.Description.IWsdlImportExtension {
    public MessageEncodingBindingElementImporter() { }
    void System.ServiceModel.Description.IPolicyImportExtension.ImportPolicy(System.ServiceModel.Description.MetadataImporter importer, System.ServiceModel.Description.PolicyConversionContext context) { }
    void System.ServiceModel.Description.IWsdlImportExtension.BeforeImport(System.Web.Services.Description.ServiceDescriptionCollection wsdlDocuments, System.Xml.Schema.XmlSchemaSet xmlSchemas, System.Collections.Generic.ICollection<System.Xml.XmlElement> policy) { }
    void System.ServiceModel.Description.IWsdlImportExtension.ImportContract(System.ServiceModel.Description.WsdlImporter importer, System.ServiceModel.Description.WsdlContractConversionContext context) { }
    void System.ServiceModel.Description.IWsdlImportExtension.ImportEndpoint(System.ServiceModel.Description.WsdlImporter importer, System.ServiceModel.Description.WsdlEndpointConversionContext context) { }
  }
  public abstract partial class MessageFault {
    protected MessageFault() { }
    public virtual string Actor { get { return default(string); } }
    public abstract System.ServiceModel.FaultCode Code { get; }
    public abstract bool HasDetail { get; }
    public bool IsMustUnderstandFault { get { return default(bool); } }
    public virtual string Node { get { return default(string); } }
    public abstract System.ServiceModel.FaultReason Reason { get; }
    public static System.ServiceModel.Channels.MessageFault CreateFault(System.ServiceModel.Channels.Message message, int maxBufferSize) { return default(System.ServiceModel.Channels.MessageFault); }
    public static System.ServiceModel.Channels.MessageFault CreateFault(System.ServiceModel.FaultCode code, System.ServiceModel.FaultReason reason) { return default(System.ServiceModel.Channels.MessageFault); }
    public static System.ServiceModel.Channels.MessageFault CreateFault(System.ServiceModel.FaultCode code, System.ServiceModel.FaultReason reason, object detail) { return default(System.ServiceModel.Channels.MessageFault); }
    public static System.ServiceModel.Channels.MessageFault CreateFault(System.ServiceModel.FaultCode code, System.ServiceModel.FaultReason reason, object detail, System.Runtime.Serialization.XmlObjectSerializer serializer) { return default(System.ServiceModel.Channels.MessageFault); }
    public static System.ServiceModel.Channels.MessageFault CreateFault(System.ServiceModel.FaultCode code, System.ServiceModel.FaultReason reason, object detail, System.Runtime.Serialization.XmlObjectSerializer serializer, string actor) { return default(System.ServiceModel.Channels.MessageFault); }
    public static System.ServiceModel.Channels.MessageFault CreateFault(System.ServiceModel.FaultCode code, System.ServiceModel.FaultReason reason, object detail, System.Runtime.Serialization.XmlObjectSerializer serializer, string actor, string node) { return default(System.ServiceModel.Channels.MessageFault); }
    public static System.ServiceModel.Channels.MessageFault CreateFault(System.ServiceModel.FaultCode code, string reason) { return default(System.ServiceModel.Channels.MessageFault); }
    public T GetDetail<T>() { return default(T); }
    public T GetDetail<T>(System.Runtime.Serialization.XmlObjectSerializer serializer) { return default(T); }
    public System.Xml.XmlDictionaryReader GetReaderAtDetailContents() { return default(System.Xml.XmlDictionaryReader); }
    protected virtual System.Xml.XmlDictionaryReader OnGetReaderAtDetailContents() { return default(System.Xml.XmlDictionaryReader); }
    protected virtual void OnWriteDetail(System.Xml.XmlDictionaryWriter writer, System.ServiceModel.EnvelopeVersion version) { }
    protected abstract void OnWriteDetailContents(System.Xml.XmlDictionaryWriter writer);
    protected virtual void OnWriteStartDetail(System.Xml.XmlDictionaryWriter writer, System.ServiceModel.EnvelopeVersion version) { }
    public static bool WasHeaderNotUnderstood(System.ServiceModel.Channels.MessageHeaders headers, string name, string ns) { return default(bool); }
    public void WriteTo(System.Xml.XmlDictionaryWriter writer, System.ServiceModel.EnvelopeVersion version) { }
    public void WriteTo(System.Xml.XmlWriter writer, System.ServiceModel.EnvelopeVersion version) { }
  }
  public abstract partial class MessageHeader : System.ServiceModel.Channels.MessageHeaderInfo {
    protected MessageHeader() { }
    public override string Actor { get { return default(string); } }
    public override bool IsReferenceParameter { get { return default(bool); } }
    public override bool MustUnderstand { get { return default(bool); } }
    public override bool Relay { get { return default(bool); } }
    public static System.ServiceModel.Channels.MessageHeader CreateHeader(string name, string ns, object value) { return default(System.ServiceModel.Channels.MessageHeader); }
    public static System.ServiceModel.Channels.MessageHeader CreateHeader(string name, string ns, object value, bool mustUnderstand) { return default(System.ServiceModel.Channels.MessageHeader); }
    public static System.ServiceModel.Channels.MessageHeader CreateHeader(string name, string ns, object value, bool mustUnderstand, string actor) { return default(System.ServiceModel.Channels.MessageHeader); }
    public static System.ServiceModel.Channels.MessageHeader CreateHeader(string name, string ns, object value, bool mustUnderstand, string actor, bool relay) { return default(System.ServiceModel.Channels.MessageHeader); }
    public static System.ServiceModel.Channels.MessageHeader CreateHeader(string name, string ns, object value, System.Runtime.Serialization.XmlObjectSerializer serializer) { return default(System.ServiceModel.Channels.MessageHeader); }
    public static System.ServiceModel.Channels.MessageHeader CreateHeader(string name, string ns, object value, System.Runtime.Serialization.XmlObjectSerializer serializer, bool mustUnderstand) { return default(System.ServiceModel.Channels.MessageHeader); }
    public static System.ServiceModel.Channels.MessageHeader CreateHeader(string name, string ns, object value, System.Runtime.Serialization.XmlObjectSerializer serializer, bool mustUnderstand, string actor) { return default(System.ServiceModel.Channels.MessageHeader); }
    public static System.ServiceModel.Channels.MessageHeader CreateHeader(string name, string ns, object value, System.Runtime.Serialization.XmlObjectSerializer serializer, bool mustUnderstand, string actor, bool relay) { return default(System.ServiceModel.Channels.MessageHeader); }
    public virtual bool IsMessageVersionSupported(System.ServiceModel.Channels.MessageVersion messageVersion) { return default(bool); }
    protected abstract void OnWriteHeaderContents(System.Xml.XmlDictionaryWriter writer, System.ServiceModel.Channels.MessageVersion messageVersion);
    protected virtual void OnWriteStartHeader(System.Xml.XmlDictionaryWriter writer, System.ServiceModel.Channels.MessageVersion messageVersion) { }
    public override string ToString() { return default(string); }
    public void WriteHeader(System.Xml.XmlDictionaryWriter writer, System.ServiceModel.Channels.MessageVersion messageVersion) { }
    public void WriteHeader(System.Xml.XmlWriter writer, System.ServiceModel.Channels.MessageVersion messageVersion) { }
    protected void WriteHeaderAttributes(System.Xml.XmlDictionaryWriter writer, System.ServiceModel.Channels.MessageVersion messageVersion) { }
    public void WriteHeaderContents(System.Xml.XmlDictionaryWriter writer, System.ServiceModel.Channels.MessageVersion messageVersion) { }
    public void WriteStartHeader(System.Xml.XmlDictionaryWriter writer, System.ServiceModel.Channels.MessageVersion messageVersion) { }
  }
  public abstract partial class MessageHeaderInfo {
    protected MessageHeaderInfo() { }
    public abstract string Actor { get; }
    public abstract bool IsReferenceParameter { get; }
    public abstract bool MustUnderstand { get; }
    public abstract string Name { get; }
    public abstract string Namespace { get; }
    public abstract bool Relay { get; }
  }
  public sealed partial class MessageHeaders : System.Collections.Generic.IEnumerable<System.ServiceModel.Channels.MessageHeaderInfo>, System.Collections.IEnumerable {
    public MessageHeaders(System.ServiceModel.Channels.MessageHeaders collection) { }
    public MessageHeaders(System.ServiceModel.Channels.MessageVersion version) { }
    public MessageHeaders(System.ServiceModel.Channels.MessageVersion version, int initialSize) { }
    public string Action { get { return default(string); } set { } }
    public int Count { get { return default(int); } }
    public System.ServiceModel.EndpointAddress FaultTo { get { return default(System.ServiceModel.EndpointAddress); } set { } }
    public System.ServiceModel.EndpointAddress From { get { return default(System.ServiceModel.EndpointAddress); } set { } }
    public System.ServiceModel.Channels.MessageHeaderInfo this[int index] { get { return default(System.ServiceModel.Channels.MessageHeaderInfo); } }
    public System.Xml.UniqueId MessageId { get { return default(System.Xml.UniqueId); } set { } }
    public System.ServiceModel.Channels.MessageVersion MessageVersion { get { return default(System.ServiceModel.Channels.MessageVersion); } }
    public System.Xml.UniqueId RelatesTo { get { return default(System.Xml.UniqueId); } set { } }
    public System.ServiceModel.EndpointAddress ReplyTo { get { return default(System.ServiceModel.EndpointAddress); } set { } }
    public System.Uri To { get { return default(System.Uri); } set { } }
    public System.ServiceModel.Channels.UnderstoodHeaders UnderstoodHeaders { get { return default(System.ServiceModel.Channels.UnderstoodHeaders); } }
    public void Add(System.ServiceModel.Channels.MessageHeader header) { }
    public void Clear() { }
    public void CopyHeaderFrom(System.ServiceModel.Channels.Message message, int headerIndex) { }
    public void CopyHeaderFrom(System.ServiceModel.Channels.MessageHeaders collection, int headerIndex) { }
    public void CopyHeadersFrom(System.ServiceModel.Channels.Message message) { }
    public void CopyHeadersFrom(System.ServiceModel.Channels.MessageHeaders collection) { }
    public void CopyTo(System.ServiceModel.Channels.MessageHeaderInfo[] array, int index) { }
    public int FindHeader(string name, string ns) { return default(int); }
    public int FindHeader(string name, string ns, params System.String[] actors) { return default(int); }
    public System.Collections.Generic.IEnumerator<System.ServiceModel.Channels.MessageHeaderInfo> GetEnumerator() { return default(System.Collections.Generic.IEnumerator<System.ServiceModel.Channels.MessageHeaderInfo>); }
    public T GetHeader<T>(int index) { return default(T); }
    public T GetHeader<T>(int index, System.Runtime.Serialization.XmlObjectSerializer serializer) { return default(T); }
    public T GetHeader<T>(string name, string ns) { return default(T); }
    public T GetHeader<T>(string name, string ns, System.Runtime.Serialization.XmlObjectSerializer serializer) { return default(T); }
    public T GetHeader<T>(string name, string ns, params System.String[] actors) { return default(T); }
    public System.Xml.XmlDictionaryReader GetReaderAtHeader(int headerIndex) { return default(System.Xml.XmlDictionaryReader); }
    public bool HaveMandatoryHeadersBeenUnderstood() { return default(bool); }
    public bool HaveMandatoryHeadersBeenUnderstood(params System.String[] actors) { return default(bool); }
    public void Insert(int headerIndex, System.ServiceModel.Channels.MessageHeader header) { }
    public void RemoveAll(string name, string ns) { }
    public void RemoveAt(int headerIndex) { }
    public void SetAction(System.Xml.XmlDictionaryString action) { }
    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { return default(System.Collections.IEnumerator); }
    public void WriteHeader(int headerIndex, System.Xml.XmlDictionaryWriter writer) { }
    public void WriteHeader(int headerIndex, System.Xml.XmlWriter writer) { }
    public void WriteHeaderContents(int headerIndex, System.Xml.XmlDictionaryWriter writer) { }
    public void WriteHeaderContents(int headerIndex, System.Xml.XmlWriter writer) { }
    public void WriteStartHeader(int headerIndex, System.Xml.XmlDictionaryWriter writer) { }
    public void WriteStartHeader(int headerIndex, System.Xml.XmlWriter writer) { }
  }
  public sealed partial class MessageProperties : System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String, System.Object>>, System.Collections.Generic.IDictionary<System.String, System.Object>, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>, System.Collections.IEnumerable, System.IDisposable {
    public MessageProperties() { }
    public MessageProperties(System.ServiceModel.Channels.MessageProperties properties) { }
    public bool AllowOutputBatching { get { return default(bool); } set { } }
    public int Count { get { return default(int); } }
    public System.ServiceModel.Channels.MessageEncoder Encoder { get { return default(System.ServiceModel.Channels.MessageEncoder); } set { } }
    public bool IsFixedSize { get { return default(bool); } }
    public bool IsReadOnly { get { return default(bool); } }
    public object this[string name] { get { return default(object); } set { } }
    public System.Collections.Generic.ICollection<System.String> Keys { get { return default(System.Collections.Generic.ICollection<System.String>); } }
    public System.ServiceModel.Security.SecurityMessageProperty Security { get { return default(System.ServiceModel.Security.SecurityMessageProperty); } set { } }
    public System.Collections.Generic.ICollection<System.Object> Values { get { return default(System.Collections.Generic.ICollection<System.Object>); } }
    public System.Uri Via { get { return default(System.Uri); } set { } }
    public void Add(string name, object property) { }
    public void Clear() { }
    public bool ContainsKey(string name) { return default(bool); }
    public void CopyProperties(System.ServiceModel.Channels.MessageProperties properties) { }
    public void Dispose() { }
    public bool Remove(string name) { return default(bool); }
    void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.Add(System.Collections.Generic.KeyValuePair<System.String, System.Object> pair) { }
    bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.Contains(System.Collections.Generic.KeyValuePair<System.String, System.Object> pair) { return default(bool); }
    void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.CopyTo(System.Collections.Generic.KeyValuePair<System.String, System.Object>[] array, int index) { }
    bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.Remove(System.Collections.Generic.KeyValuePair<System.String, System.Object> pair) { return default(bool); }
    System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String, System.Object>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.GetEnumerator() { return default(System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String, System.Object>>); }
    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { return default(System.Collections.IEnumerator); }
    public bool TryGetValue(string name, out object value) { value = default(object); return default(bool); }
  }
  public enum MessageState {
    Closed = 4,
    Copied = 3,
    Created = 0,
    Read = 1,
    Written = 2,
  }
  [System.ComponentModel.TypeConverterAttribute(typeof(System.ServiceModel.Configuration.MessageVersionConverter))]
  public sealed partial class MessageVersion {
    internal MessageVersion() { }
    public System.ServiceModel.Channels.AddressingVersion Addressing { get { return default(System.ServiceModel.Channels.AddressingVersion); } }
    public static System.ServiceModel.Channels.MessageVersion Default { get { return default(System.ServiceModel.Channels.MessageVersion); } }
    public System.ServiceModel.EnvelopeVersion Envelope { get { return default(System.ServiceModel.EnvelopeVersion); } }
    public static System.ServiceModel.Channels.MessageVersion None { get { return default(System.ServiceModel.Channels.MessageVersion); } }
    public static System.ServiceModel.Channels.MessageVersion Soap11 { get { return default(System.ServiceModel.Channels.MessageVersion); } }
    public static System.ServiceModel.Channels.MessageVersion Soap11WSAddressing10 { get { return default(System.ServiceModel.Channels.MessageVersion); } }
    public static System.ServiceModel.Channels.MessageVersion Soap11WSAddressingAugust2004 { get { return default(System.ServiceModel.Channels.MessageVersion); } }
    public static System.ServiceModel.Channels.MessageVersion Soap12 { get { return default(System.ServiceModel.Channels.MessageVersion); } }
    public static System.ServiceModel.Channels.MessageVersion Soap12WSAddressing10 { get { return default(System.ServiceModel.Channels.MessageVersion); } }
    public static System.ServiceModel.Channels.MessageVersion Soap12WSAddressingAugust2004 { get { return default(System.ServiceModel.Channels.MessageVersion); } }
    public static System.ServiceModel.Channels.MessageVersion CreateVersion(System.ServiceModel.EnvelopeVersion envelopeVersion) { return default(System.ServiceModel.Channels.MessageVersion); }
    public static System.ServiceModel.Channels.MessageVersion CreateVersion(System.ServiceModel.EnvelopeVersion envelopeVersion, System.ServiceModel.Channels.AddressingVersion addressingVersion) { return default(System.ServiceModel.Channels.MessageVersion); }
    public override bool Equals(object obj) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public override string ToString() { return default(string); }
  }
  public abstract partial class MsmqBindingElementBase : System.ServiceModel.Channels.TransportBindingElement, System.ServiceModel.Channels.ITransactedBindingElement, System.ServiceModel.Description.IPolicyExportExtension, System.ServiceModel.Description.IWsdlExportExtension {
    internal MsmqBindingElementBase() { }
    public System.Uri CustomDeadLetterQueue { get { return default(System.Uri); } set { } }
    public System.ServiceModel.DeadLetterQueue DeadLetterQueue { get { return default(System.ServiceModel.DeadLetterQueue); } set { } }
    public bool Durable { get { return default(bool); } set { } }
    public bool ExactlyOnce { get { return default(bool); } set { } }
    public int MaxRetryCycles { get { return default(int); } set { } }
    public System.ServiceModel.MsmqTransportSecurity MsmqTransportSecurity { get { return default(System.ServiceModel.MsmqTransportSecurity); } }
    public bool ReceiveContextEnabled { get { return default(bool); } set { } }
    public System.ServiceModel.ReceiveErrorHandling ReceiveErrorHandling { get { return default(System.ServiceModel.ReceiveErrorHandling); } set { } }
    public int ReceiveRetryCount { get { return default(int); } set { } }
    public System.TimeSpan RetryCycleDelay { get { return default(System.TimeSpan); } set { } }
    public System.TimeSpan TimeToLive { get { return default(System.TimeSpan); } set { } }
    public bool TransactedReceiveEnabled { get { return default(bool); } }
    public bool UseMsmqTracing { get { return default(bool); } set { } }
    public bool UseSourceJournal { get { return default(bool); } set { } }
    public System.TimeSpan ValidityDuration { get { return default(System.TimeSpan); } set { } }
    public override T GetProperty<T>(System.ServiceModel.Channels.BindingContext context) { return default(T); }
    void System.ServiceModel.Description.IPolicyExportExtension.ExportPolicy(System.ServiceModel.Description.MetadataExporter exporter, System.ServiceModel.Description.PolicyConversionContext context) { }
    void System.ServiceModel.Description.IWsdlExportExtension.ExportContract(System.ServiceModel.Description.WsdlExporter exporter, System.ServiceModel.Description.WsdlContractConversionContext context) { }
    void System.ServiceModel.Description.IWsdlExportExtension.ExportEndpoint(System.ServiceModel.Description.WsdlExporter exporter, System.ServiceModel.Description.WsdlEndpointConversionContext endpointContext) { }
  }
  public sealed partial class MsmqMessageProperty {
    internal MsmqMessageProperty() { }
    public const string Name = "MsmqMessageProperty";
    public int AbortCount { get { return default(int); } }
    public System.Nullable<System.ServiceModel.Channels.DeliveryFailure> DeliveryFailure { get { return default(System.Nullable<System.ServiceModel.Channels.DeliveryFailure>); } }
    public System.Nullable<System.ServiceModel.Channels.DeliveryStatus> DeliveryStatus { get { return default(System.Nullable<System.ServiceModel.Channels.DeliveryStatus>); } }
    public int MoveCount { get { return default(int); } }
    public static System.ServiceModel.Channels.MsmqMessageProperty Get(System.ServiceModel.Channels.Message message) { return default(System.ServiceModel.Channels.MsmqMessageProperty); }
  }
  public sealed partial class MsmqTransportBindingElement : System.ServiceModel.Channels.MsmqBindingElementBase {
    public MsmqTransportBindingElement() { }
    public int MaxPoolSize { get { return default(int); } set { } }
    public System.ServiceModel.QueueTransferProtocol QueueTransferProtocol { get { return default(System.ServiceModel.QueueTransferProtocol); } set { } }
    public override string Scheme { get { return default(string); } }
    public bool UseActiveDirectory { get { return default(bool); } set { } }
    public override System.ServiceModel.Channels.IChannelFactory<TChannel> BuildChannelFactory<TChannel>(System.ServiceModel.Channels.BindingContext context) { return default(System.ServiceModel.Channels.IChannelFactory<TChannel>); }
    public override System.ServiceModel.Channels.IChannelListener<TChannel> BuildChannelListener<TChannel>(System.ServiceModel.Channels.BindingContext context) { return default(System.ServiceModel.Channels.IChannelListener<TChannel>); }
    public override bool CanBuildChannelFactory<TChannel>(System.ServiceModel.Channels.BindingContext context) { return default(bool); }
    public override bool CanBuildChannelListener<TChannel>(System.ServiceModel.Channels.BindingContext context) { return default(bool); }
    public override System.ServiceModel.Channels.BindingElement Clone() { return default(System.ServiceModel.Channels.BindingElement); }
  }
  public sealed partial class MtomMessageEncodingBindingElement : System.ServiceModel.Channels.MessageEncodingBindingElement, System.ServiceModel.Description.IPolicyExportExtension, System.ServiceModel.Description.IWsdlExportExtension {
    public MtomMessageEncodingBindingElement() { }
    public MtomMessageEncodingBindingElement(System.ServiceModel.Channels.MessageVersion messageVersion, System.Text.Encoding writeEncoding) { }
    [System.ComponentModel.DefaultValueAttribute(65536)]
    public int MaxBufferSize { get { return default(int); } set { } }
    [System.ComponentModel.DefaultValueAttribute(64)]
    public int MaxReadPoolSize { get { return default(int); } set { } }
    [System.ComponentModel.DefaultValueAttribute(16)]
    public int MaxWritePoolSize { get { return default(int); } set { } }
    public override System.ServiceModel.Channels.MessageVersion MessageVersion { get { return default(System.ServiceModel.Channels.MessageVersion); } set { } }
    public System.Xml.XmlDictionaryReaderQuotas ReaderQuotas { get { return default(System.Xml.XmlDictionaryReaderQuotas); } }
    [System.ComponentModel.TypeConverterAttribute(typeof(System.ServiceModel.Configuration.EncodingConverter))]
    public System.Text.Encoding WriteEncoding { get { return default(System.Text.Encoding); } set { } }
    public override System.ServiceModel.Channels.IChannelFactory<TChannel> BuildChannelFactory<TChannel>(System.ServiceModel.Channels.BindingContext context) { return default(System.ServiceModel.Channels.IChannelFactory<TChannel>); }
    public override System.ServiceModel.Channels.IChannelListener<TChannel> BuildChannelListener<TChannel>(System.ServiceModel.Channels.BindingContext context) { return default(System.ServiceModel.Channels.IChannelListener<TChannel>); }
    public override bool CanBuildChannelFactory<TChannel>(System.ServiceModel.Channels.BindingContext context) { return default(bool); }
    public override bool CanBuildChannelListener<TChannel>(System.ServiceModel.Channels.BindingContext context) { return default(bool); }
    public override System.ServiceModel.Channels.BindingElement Clone() { return default(System.ServiceModel.Channels.BindingElement); }
    public override System.ServiceModel.Channels.MessageEncoderFactory CreateMessageEncoderFactory() { return default(System.ServiceModel.Channels.MessageEncoderFactory); }
    public override T GetProperty<T>(System.ServiceModel.Channels.BindingContext context) { return default(T); }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public bool ShouldSerializeMessageVersion() { return default(bool); }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public bool ShouldSerializeReaderQuotas() { return default(bool); }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public bool ShouldSerializeWriteEncoding() { return default(bool); }
    void System.ServiceModel.Description.IPolicyExportExtension.ExportPolicy(System.ServiceModel.Description.MetadataExporter exporter, System.ServiceModel.Description.PolicyConversionContext policyContext) { }
    void System.ServiceModel.Description.IWsdlExportExtension.ExportContract(System.ServiceModel.Description.WsdlExporter exporter, System.ServiceModel.Description.WsdlContractConversionContext context) { }
    void System.ServiceModel.Description.IWsdlExportExtension.ExportEndpoint(System.ServiceModel.Description.WsdlExporter exporter, System.ServiceModel.Description.WsdlEndpointConversionContext context) { }
  }
  public sealed partial class NamedPipeConnectionPoolSettings {
    internal NamedPipeConnectionPoolSettings() { }
    public string GroupName { get { return default(string); } set { } }
    public System.TimeSpan IdleTimeout { get { return default(System.TimeSpan); } set { } }
    public int MaxOutboundConnectionsPerEndpoint { get { return default(int); } set { } }
  }
  public sealed partial class NamedPipeSettings {
    internal NamedPipeSettings() { }
    public System.ServiceModel.Channels.ApplicationContainerSettings ApplicationContainerSettings { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.ServiceModel.Channels.ApplicationContainerSettings); } }
  }
  public partial class NamedPipeTransportBindingElement : System.ServiceModel.Channels.ConnectionOrientedTransportBindingElement {
    public NamedPipeTransportBindingElement() { }
    protected NamedPipeTransportBindingElement(System.ServiceModel.Channels.NamedPipeTransportBindingElement elementToBeCloned) { }
    public System.ServiceModel.Channels.NamedPipeConnectionPoolSettings ConnectionPoolSettings { get { return default(System.ServiceModel.Channels.NamedPipeConnectionPoolSettings); } }
    public System.ServiceModel.Channels.NamedPipeSettings PipeSettings { get { return default(System.ServiceModel.Channels.NamedPipeSettings); } }
    public override string Scheme { get { return default(string); } }
    public override System.ServiceModel.Channels.IChannelFactory<TChannel> BuildChannelFactory<TChannel>(System.ServiceModel.Channels.BindingContext context) { return default(System.ServiceModel.Channels.IChannelFactory<TChannel>); }
    public override System.ServiceModel.Channels.IChannelListener<TChannel> BuildChannelListener<TChannel>(System.ServiceModel.Channels.BindingContext context) { return default(System.ServiceModel.Channels.IChannelListener<TChannel>); }
    public override System.ServiceModel.Channels.BindingElement Clone() { return default(System.ServiceModel.Channels.BindingElement); }
    public override T GetProperty<T>(System.ServiceModel.Channels.BindingContext context) { return default(T); }
  }
  public sealed partial class OneWayBindingElement : System.ServiceModel.Channels.BindingElement, System.ServiceModel.Description.IPolicyExportExtension {
    public OneWayBindingElement() { }
    public System.ServiceModel.Channels.ChannelPoolSettings ChannelPoolSettings { get { return default(System.ServiceModel.Channels.ChannelPoolSettings); } set { } }
    [System.ComponentModel.DefaultValueAttribute(10)]
    public int MaxAcceptedChannels { get { return default(int); } set { } }
    [System.ComponentModel.DefaultValueAttribute(false)]
    public bool PacketRoutable { get { return default(bool); } set { } }
    public override System.ServiceModel.Channels.IChannelFactory<TChannel> BuildChannelFactory<TChannel>(System.ServiceModel.Channels.BindingContext context) { return default(System.ServiceModel.Channels.IChannelFactory<TChannel>); }
    public override System.ServiceModel.Channels.IChannelListener<TChannel> BuildChannelListener<TChannel>(System.ServiceModel.Channels.BindingContext context) { return default(System.ServiceModel.Channels.IChannelListener<TChannel>); }
    public override bool CanBuildChannelFactory<TChannel>(System.ServiceModel.Channels.BindingContext context) { return default(bool); }
    public override bool CanBuildChannelListener<TChannel>(System.ServiceModel.Channels.BindingContext context) { return default(bool); }
    public override System.ServiceModel.Channels.BindingElement Clone() { return default(System.ServiceModel.Channels.BindingElement); }
    public override T GetProperty<T>(System.ServiceModel.Channels.BindingContext context) { return default(T); }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public bool ShouldSerializeChannelPoolSettings() { return default(bool); }
    void System.ServiceModel.Description.IPolicyExportExtension.ExportPolicy(System.ServiceModel.Description.MetadataExporter exporter, System.ServiceModel.Description.PolicyConversionContext context) { }
  }
  public partial class OneWayBindingElementImporter : System.ServiceModel.Description.IPolicyImportExtension {
    public OneWayBindingElementImporter() { }
    void System.ServiceModel.Description.IPolicyImportExtension.ImportPolicy(System.ServiceModel.Description.MetadataImporter importer, System.ServiceModel.Description.PolicyConversionContext context) { }
  }
  [System.ObsoleteAttribute("PeerChannel feature is obsolete and will be removed in the future.", false)]
  public sealed partial class PeerCustomResolverBindingElement : System.ServiceModel.Channels.PeerResolverBindingElement {
    public PeerCustomResolverBindingElement() { }
    public PeerCustomResolverBindingElement(System.ServiceModel.Channels.BindingContext context, System.ServiceModel.PeerResolvers.PeerCustomResolverSettings settings) { }
    public PeerCustomResolverBindingElement(System.ServiceModel.Channels.PeerCustomResolverBindingElement other) { }
    public PeerCustomResolverBindingElement(System.ServiceModel.PeerResolvers.PeerCustomResolverSettings settings) { }
    public System.ServiceModel.EndpointAddress Address { get { return default(System.ServiceModel.EndpointAddress); } set { } }
    public System.ServiceModel.Channels.Binding Binding { get { return default(System.ServiceModel.Channels.Binding); } set { } }
    public override System.ServiceModel.PeerResolvers.PeerReferralPolicy ReferralPolicy { get { return default(System.ServiceModel.PeerResolvers.PeerReferralPolicy); } set { } }
    public override System.ServiceModel.Channels.IChannelFactory<TChannel> BuildChannelFactory<TChannel>(System.ServiceModel.Channels.BindingContext context) { return default(System.ServiceModel.Channels.IChannelFactory<TChannel>); }
    public override System.ServiceModel.Channels.IChannelListener<TChannel> BuildChannelListener<TChannel>(System.ServiceModel.Channels.BindingContext context) { return default(System.ServiceModel.Channels.IChannelListener<TChannel>); }
    public override bool CanBuildChannelFactory<TChannel>(System.ServiceModel.Channels.BindingContext context) { return default(bool); }
    public override bool CanBuildChannelListener<TChannel>(System.ServiceModel.Channels.BindingContext context) { return default(bool); }
    public override System.ServiceModel.Channels.BindingElement Clone() { return default(System.ServiceModel.Channels.BindingElement); }
    public override System.ServiceModel.PeerResolver CreatePeerResolver() { return default(System.ServiceModel.PeerResolver); }
    public override T GetProperty<T>(System.ServiceModel.Channels.BindingContext context) { return default(T); }
  }
  public abstract partial class PeerResolverBindingElement : System.ServiceModel.Channels.BindingElement {
    protected PeerResolverBindingElement() { }
    protected PeerResolverBindingElement(System.ServiceModel.Channels.PeerResolverBindingElement other) { }
    public abstract System.ServiceModel.PeerResolvers.PeerReferralPolicy ReferralPolicy { get; set; }
    public abstract System.ServiceModel.PeerResolver CreatePeerResolver();
  }
  [System.ObsoleteAttribute("PeerChannel feature is obsolete and will be removed in the future.", false)]
  public sealed partial class PeerTransportBindingElement : System.ServiceModel.Channels.TransportBindingElement, System.ServiceModel.Description.IPolicyExportExtension, System.ServiceModel.Description.IWsdlExportExtension {
    public PeerTransportBindingElement() { }
    public System.Net.IPAddress ListenIPAddress { get { return default(System.Net.IPAddress); } set { } }
    public override long MaxReceivedMessageSize { get { return default(long); } set { } }
    public int Port { get { return default(int); } set { } }
    public override string Scheme { get { return default(string); } }
    public System.ServiceModel.PeerSecuritySettings Security { get { return default(System.ServiceModel.PeerSecuritySettings); } }
    public override System.ServiceModel.Channels.IChannelFactory<TChannel> BuildChannelFactory<TChannel>(System.ServiceModel.Channels.BindingContext context) { return default(System.ServiceModel.Channels.IChannelFactory<TChannel>); }
    public override System.ServiceModel.Channels.IChannelListener<TChannel> BuildChannelListener<TChannel>(System.ServiceModel.Channels.BindingContext context) { return default(System.ServiceModel.Channels.IChannelListener<TChannel>); }
    public override bool CanBuildChannelFactory<TChannel>(System.ServiceModel.Channels.BindingContext context) { return default(bool); }
    public override bool CanBuildChannelListener<TChannel>(System.ServiceModel.Channels.BindingContext context) { return default(bool); }
    public override System.ServiceModel.Channels.BindingElement Clone() { return default(System.ServiceModel.Channels.BindingElement); }
    public override T GetProperty<T>(System.ServiceModel.Channels.BindingContext context) { return default(T); }
    void System.ServiceModel.Description.IPolicyExportExtension.ExportPolicy(System.ServiceModel.Description.MetadataExporter exporter, System.ServiceModel.Description.PolicyConversionContext context) { }
    void System.ServiceModel.Description.IWsdlExportExtension.ExportContract(System.ServiceModel.Description.WsdlExporter exporter, System.ServiceModel.Description.WsdlContractConversionContext context) { }
    void System.ServiceModel.Description.IWsdlExportExtension.ExportEndpoint(System.ServiceModel.Description.WsdlExporter exporter, System.ServiceModel.Description.WsdlEndpointConversionContext endpointContext) { }
  }
  public sealed partial class PnrpPeerResolverBindingElement : System.ServiceModel.Channels.PeerResolverBindingElement {
    public PnrpPeerResolverBindingElement() { }
    public PnrpPeerResolverBindingElement(System.ServiceModel.PeerResolvers.PeerReferralPolicy referralPolicy) { }
    public override System.ServiceModel.PeerResolvers.PeerReferralPolicy ReferralPolicy { get { return default(System.ServiceModel.PeerResolvers.PeerReferralPolicy); } set { } }
    public override System.ServiceModel.Channels.IChannelFactory<TChannel> BuildChannelFactory<TChannel>(System.ServiceModel.Channels.BindingContext context) { return default(System.ServiceModel.Channels.IChannelFactory<TChannel>); }
    public override System.ServiceModel.Channels.IChannelListener<TChannel> BuildChannelListener<TChannel>(System.ServiceModel.Channels.BindingContext context) { return default(System.ServiceModel.Channels.IChannelListener<TChannel>); }
    public override bool CanBuildChannelFactory<TChannel>(System.ServiceModel.Channels.BindingContext context) { return default(bool); }
    public override bool CanBuildChannelListener<TChannel>(System.ServiceModel.Channels.BindingContext context) { return default(bool); }
    public override System.ServiceModel.Channels.BindingElement Clone() { return default(System.ServiceModel.Channels.BindingElement); }
    public override System.ServiceModel.PeerResolver CreatePeerResolver() { return default(System.ServiceModel.PeerResolver); }
    public override T GetProperty<T>(System.ServiceModel.Channels.BindingContext context) { return default(T); }
  }
  public sealed partial class PrivacyNoticeBindingElement : System.ServiceModel.Channels.BindingElement, System.ServiceModel.Description.IPolicyExportExtension {
    public PrivacyNoticeBindingElement() { }
    public PrivacyNoticeBindingElement(System.ServiceModel.Channels.PrivacyNoticeBindingElement elementToBeCloned) { }
    public System.Uri Url { get { return default(System.Uri); } set { } }
    public int Version { get { return default(int); } set { } }
    public override System.ServiceModel.Channels.BindingElement Clone() { return default(System.ServiceModel.Channels.BindingElement); }
    public override T GetProperty<T>(System.ServiceModel.Channels.BindingContext context) { return default(T); }
    void System.ServiceModel.Description.IPolicyExportExtension.ExportPolicy(System.ServiceModel.Description.MetadataExporter exporter, System.ServiceModel.Description.PolicyConversionContext context) { }
  }
  public sealed partial class PrivacyNoticeBindingElementImporter : System.ServiceModel.Description.IPolicyImportExtension {
    public PrivacyNoticeBindingElementImporter() { }
    void System.ServiceModel.Description.IPolicyImportExtension.ImportPolicy(System.ServiceModel.Description.MetadataImporter importer, System.ServiceModel.Description.PolicyConversionContext policyContext) { }
  }
  public abstract partial class ReceiveContext {
    public static readonly string Name;
    protected ReceiveContext() { }
    public System.ServiceModel.Channels.ReceiveContextState State { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.ServiceModel.Channels.ReceiveContextState); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]protected set { } }
    protected object ThisLock { get { return default(object); } }
    public event System.EventHandler Faulted { add { } remove { } }
    public virtual void Abandon(System.Exception exception, System.TimeSpan timeout) { }
    public virtual void Abandon(System.TimeSpan timeout) { }
    public virtual System.IAsyncResult BeginAbandon(System.Exception exception, System.TimeSpan timeout, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    public virtual System.IAsyncResult BeginAbandon(System.TimeSpan timeout, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    public virtual System.IAsyncResult BeginComplete(System.TimeSpan timeout, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    public virtual void Complete(System.TimeSpan timeout) { }
    public virtual void EndAbandon(System.IAsyncResult result) { }
    public virtual void EndComplete(System.IAsyncResult result) { }
    protected internal virtual void Fault() { }
    protected virtual void OnAbandon(System.Exception exception, System.TimeSpan timeout) { }
    protected abstract void OnAbandon(System.TimeSpan timeout);
    protected virtual System.IAsyncResult OnBeginAbandon(System.Exception exception, System.TimeSpan timeout, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    protected abstract System.IAsyncResult OnBeginAbandon(System.TimeSpan timeout, System.AsyncCallback callback, object state);
    protected abstract System.IAsyncResult OnBeginComplete(System.TimeSpan timeout, System.AsyncCallback callback, object state);
    protected abstract void OnComplete(System.TimeSpan timeout);
    protected abstract void OnEndAbandon(System.IAsyncResult result);
    protected abstract void OnEndComplete(System.IAsyncResult result);
    protected virtual void OnFaulted() { }
    public static bool TryGet(System.ServiceModel.Channels.Message message, out System.ServiceModel.Channels.ReceiveContext property) { property = default(System.ServiceModel.Channels.ReceiveContext); return default(bool); }
    public static bool TryGet(System.ServiceModel.Channels.MessageProperties properties, out System.ServiceModel.Channels.ReceiveContext property) { property = default(System.ServiceModel.Channels.ReceiveContext); return default(bool); }
  }
  public enum ReceiveContextState {
    Abandoned = 4,
    Abandoning = 3,
    Completed = 2,
    Completing = 1,
    Faulted = 5,
    Received = 0,
  }
  public partial class RedirectionDuration {
    internal RedirectionDuration() { }
    public string Namespace { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
    public static System.ServiceModel.Channels.RedirectionDuration Permanent { get { return default(System.ServiceModel.Channels.RedirectionDuration); } }
    public static System.ServiceModel.Channels.RedirectionDuration Temporary { get { return default(System.ServiceModel.Channels.RedirectionDuration); } }
    public string Value { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
    public static System.ServiceModel.Channels.RedirectionDuration Create(string duration, string ns) { return default(System.ServiceModel.Channels.RedirectionDuration); }
    public override bool Equals(object obj) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public static bool operator ==(System.ServiceModel.Channels.RedirectionDuration left, System.ServiceModel.Channels.RedirectionDuration right) { return default(bool); }
    public static bool operator !=(System.ServiceModel.Channels.RedirectionDuration left, System.ServiceModel.Channels.RedirectionDuration right) { return default(bool); }
    public override string ToString() { return default(string); }
  }
  public partial class RedirectionException : System.ServiceModel.CommunicationException {
    protected RedirectionException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public RedirectionException(System.ServiceModel.Channels.RedirectionType type, System.ServiceModel.Channels.RedirectionDuration duration, System.ServiceModel.Channels.RedirectionScope scope, System.Exception innerException, params System.ServiceModel.Channels.RedirectionLocation[] locations) { }
    public RedirectionException(System.ServiceModel.Channels.RedirectionType type, System.ServiceModel.Channels.RedirectionDuration duration, System.ServiceModel.Channels.RedirectionScope scope, params System.ServiceModel.Channels.RedirectionLocation[] locations) { }
    public RedirectionException(string message, System.ServiceModel.Channels.RedirectionType type, System.ServiceModel.Channels.RedirectionDuration duration, System.ServiceModel.Channels.RedirectionScope scope, System.Exception innerException, params System.ServiceModel.Channels.RedirectionLocation[] locations) { }
    public RedirectionException(string message, System.ServiceModel.Channels.RedirectionType type, System.ServiceModel.Channels.RedirectionDuration duration, System.ServiceModel.Channels.RedirectionScope scope, params System.ServiceModel.Channels.RedirectionLocation[] locations) { }
    public System.ServiceModel.Channels.RedirectionDuration Duration { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.ServiceModel.Channels.RedirectionDuration); } }
    public System.Collections.Generic.IEnumerable<System.ServiceModel.Channels.RedirectionLocation> Locations { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Collections.Generic.IEnumerable<System.ServiceModel.Channels.RedirectionLocation>); } }
    public System.ServiceModel.Channels.RedirectionScope Scope { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.ServiceModel.Channels.RedirectionScope); } }
    public System.ServiceModel.Channels.RedirectionType Type { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.ServiceModel.Channels.RedirectionType); } }
    [System.Security.SecurityCriticalAttribute]
    public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
  }
  public partial class RedirectionLocation {
    public RedirectionLocation(System.Uri address) { }
    public System.Uri Address { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Uri); } }
  }
  public partial class RedirectionScope {
    internal RedirectionScope() { }
    public static System.ServiceModel.Channels.RedirectionScope Endpoint { get { return default(System.ServiceModel.Channels.RedirectionScope); } }
    public static System.ServiceModel.Channels.RedirectionScope Message { get { return default(System.ServiceModel.Channels.RedirectionScope); } }
    public string Namespace { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
    public static System.ServiceModel.Channels.RedirectionScope Session { get { return default(System.ServiceModel.Channels.RedirectionScope); } }
    public string Value { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
    public static System.ServiceModel.Channels.RedirectionScope Create(string scope, string ns) { return default(System.ServiceModel.Channels.RedirectionScope); }
    public override bool Equals(object obj) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public static bool operator ==(System.ServiceModel.Channels.RedirectionScope left, System.ServiceModel.Channels.RedirectionScope right) { return default(bool); }
    public static bool operator !=(System.ServiceModel.Channels.RedirectionScope left, System.ServiceModel.Channels.RedirectionScope right) { return default(bool); }
    public override string ToString() { return default(string); }
  }
  public sealed partial class RedirectionType {
    internal RedirectionType() { }
    public static System.ServiceModel.Channels.RedirectionType Cache { get { return default(System.ServiceModel.Channels.RedirectionType); } }
    public string Namespace { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
    public static System.ServiceModel.Channels.RedirectionType Resource { get { return default(System.ServiceModel.Channels.RedirectionType); } }
    public static System.ServiceModel.Channels.RedirectionType UseIntermediary { get { return default(System.ServiceModel.Channels.RedirectionType); } }
    public string Value { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
    public static System.ServiceModel.Channels.RedirectionType Create(string type, string ns) { return default(System.ServiceModel.Channels.RedirectionType); }
    public override bool Equals(object obj) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public static bool operator ==(System.ServiceModel.Channels.RedirectionType left, System.ServiceModel.Channels.RedirectionType right) { return default(bool); }
    public static bool operator !=(System.ServiceModel.Channels.RedirectionType left, System.ServiceModel.Channels.RedirectionType right) { return default(bool); }
    public override string ToString() { return default(string); }
  }
  public sealed partial class ReliableSessionBindingElement : System.ServiceModel.Channels.BindingElement, System.ServiceModel.Description.IPolicyExportExtension {
    public ReliableSessionBindingElement() { }
    public ReliableSessionBindingElement(bool ordered) { }
    [System.ComponentModel.DefaultValueAttribute(typeof(System.TimeSpan), "00:00:00.2")]
    public System.TimeSpan AcknowledgementInterval { get { return default(System.TimeSpan); } set { } }
    [System.ComponentModel.DefaultValueAttribute(true)]
    public bool FlowControlEnabled { get { return default(bool); } set { } }
    [System.ComponentModel.DefaultValueAttribute(typeof(System.TimeSpan), "00:10:00")]
    public System.TimeSpan InactivityTimeout { get { return default(System.TimeSpan); } set { } }
    [System.ComponentModel.DefaultValueAttribute(4)]
    public int MaxPendingChannels { get { return default(int); } set { } }
    [System.ComponentModel.DefaultValueAttribute(8)]
    public int MaxRetryCount { get { return default(int); } set { } }
    [System.ComponentModel.DefaultValueAttribute(8)]
    public int MaxTransferWindowSize { get { return default(int); } set { } }
    [System.ComponentModel.DefaultValueAttribute(true)]
    public bool Ordered { get { return default(bool); } set { } }
    [System.ComponentModel.DefaultValueAttribute(typeof(System.ServiceModel.ReliableMessagingVersion), "WSReliableMessagingFebruary2005")]
    public System.ServiceModel.ReliableMessagingVersion ReliableMessagingVersion { get { return default(System.ServiceModel.ReliableMessagingVersion); } set { } }
    public override System.ServiceModel.Channels.IChannelFactory<TChannel> BuildChannelFactory<TChannel>(System.ServiceModel.Channels.BindingContext context) { return default(System.ServiceModel.Channels.IChannelFactory<TChannel>); }
    public override System.ServiceModel.Channels.IChannelListener<TChannel> BuildChannelListener<TChannel>(System.ServiceModel.Channels.BindingContext context) { return default(System.ServiceModel.Channels.IChannelListener<TChannel>); }
    public override bool CanBuildChannelFactory<TChannel>(System.ServiceModel.Channels.BindingContext context) { return default(bool); }
    public override bool CanBuildChannelListener<TChannel>(System.ServiceModel.Channels.BindingContext context) { return default(bool); }
    public override System.ServiceModel.Channels.BindingElement Clone() { return default(System.ServiceModel.Channels.BindingElement); }
    public override T GetProperty<T>(System.ServiceModel.Channels.BindingContext context) { return default(T); }
    void System.ServiceModel.Description.IPolicyExportExtension.ExportPolicy(System.ServiceModel.Description.MetadataExporter exporter, System.ServiceModel.Description.PolicyConversionContext context) { }
  }
  public sealed partial class ReliableSessionBindingElementImporter : System.ServiceModel.Description.IPolicyImportExtension {
    public ReliableSessionBindingElementImporter() { }
    void System.ServiceModel.Description.IPolicyImportExtension.ImportPolicy(System.ServiceModel.Description.MetadataImporter importer, System.ServiceModel.Description.PolicyConversionContext context) { }
  }
  public sealed partial class RemoteEndpointMessageProperty {
    public RemoteEndpointMessageProperty(string address, int port) { }
    public string Address { get { return default(string); } }
    public static string Name { get { return default(string); } }
    public int Port { get { return default(int); } }
  }
  public abstract partial class RequestContext : System.IDisposable {
    protected RequestContext() { }
    public abstract System.ServiceModel.Channels.Message RequestMessage { get; }
    public abstract void Abort();
    public abstract System.IAsyncResult BeginReply(System.ServiceModel.Channels.Message message, System.AsyncCallback callback, object state);
    public abstract System.IAsyncResult BeginReply(System.ServiceModel.Channels.Message message, System.TimeSpan timeout, System.AsyncCallback callback, object state);
    public abstract void Close();
    public abstract void Close(System.TimeSpan timeout);
    protected virtual void Dispose(bool disposing) { }
    public abstract void EndReply(System.IAsyncResult result);
    public abstract void Reply(System.ServiceModel.Channels.Message message);
    public abstract void Reply(System.ServiceModel.Channels.Message message, System.TimeSpan timeout);
    void System.IDisposable.Dispose() { }
  }
  public partial class RetryException : System.ServiceModel.CommunicationException {
    public RetryException() { }
    [System.Security.SecurityCriticalAttribute]
    protected RetryException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public RetryException(string message) { }
    public RetryException(string message, System.Exception innerException) { }
  }
  public abstract partial class SecurityBindingElement : System.ServiceModel.Channels.BindingElement {
    internal SecurityBindingElement() { }
    public bool AllowInsecureTransport { get { return default(bool); } set { } }
    public System.ServiceModel.Security.SecurityAlgorithmSuite DefaultAlgorithmSuite { get { return default(System.ServiceModel.Security.SecurityAlgorithmSuite); } set { } }
    public bool EnableUnsecuredResponse { get { return default(bool); } set { } }
    public System.ServiceModel.Security.Tokens.SupportingTokenParameters EndpointSupportingTokenParameters { get { return default(System.ServiceModel.Security.Tokens.SupportingTokenParameters); } }
    public bool IncludeTimestamp { get { return default(bool); } set { } }
    public System.ServiceModel.Security.SecurityKeyEntropyMode KeyEntropyMode { get { return default(System.ServiceModel.Security.SecurityKeyEntropyMode); } set { } }
    public System.ServiceModel.Channels.LocalClientSecuritySettings LocalClientSettings { get { return default(System.ServiceModel.Channels.LocalClientSecuritySettings); } }
    public System.ServiceModel.Channels.LocalServiceSecuritySettings LocalServiceSettings { get { return default(System.ServiceModel.Channels.LocalServiceSecuritySettings); } }
    public System.ServiceModel.MessageSecurityVersion MessageSecurityVersion { get { return default(System.ServiceModel.MessageSecurityVersion); } set { } }
    public System.Collections.Generic.IDictionary<System.String, System.ServiceModel.Security.Tokens.SupportingTokenParameters> OperationSupportingTokenParameters { get { return default(System.Collections.Generic.IDictionary<System.String, System.ServiceModel.Security.Tokens.SupportingTokenParameters>); } }
    public System.ServiceModel.Security.Tokens.SupportingTokenParameters OptionalEndpointSupportingTokenParameters { get { return default(System.ServiceModel.Security.Tokens.SupportingTokenParameters); } }
    public System.Collections.Generic.IDictionary<System.String, System.ServiceModel.Security.Tokens.SupportingTokenParameters> OptionalOperationSupportingTokenParameters { get { return default(System.Collections.Generic.IDictionary<System.String, System.ServiceModel.Security.Tokens.SupportingTokenParameters>); } }
    public bool ProtectTokens { get { return default(bool); } set { } }
    public System.ServiceModel.Channels.SecurityHeaderLayout SecurityHeaderLayout { get { return default(System.ServiceModel.Channels.SecurityHeaderLayout); } set { } }
    public override System.ServiceModel.Channels.IChannelFactory<TChannel> BuildChannelFactory<TChannel>(System.ServiceModel.Channels.BindingContext context) { return default(System.ServiceModel.Channels.IChannelFactory<TChannel>); }
    protected abstract System.ServiceModel.Channels.IChannelFactory<TChannel> BuildChannelFactoryCore<TChannel>(System.ServiceModel.Channels.BindingContext context);
    public override System.ServiceModel.Channels.IChannelListener<TChannel> BuildChannelListener<TChannel>(System.ServiceModel.Channels.BindingContext context) { return default(System.ServiceModel.Channels.IChannelListener<TChannel>); }
    protected abstract System.ServiceModel.Channels.IChannelListener<TChannel> BuildChannelListenerCore<TChannel>(System.ServiceModel.Channels.BindingContext context) where TChannel : class, System.ServiceModel.Channels.IChannel;
    public override bool CanBuildChannelFactory<TChannel>(System.ServiceModel.Channels.BindingContext context) { return default(bool); }
    public override bool CanBuildChannelListener<TChannel>(System.ServiceModel.Channels.BindingContext context) { return default(bool); }
    public static System.ServiceModel.Channels.SymmetricSecurityBindingElement CreateAnonymousForCertificateBindingElement() { return default(System.ServiceModel.Channels.SymmetricSecurityBindingElement); }
    public static System.ServiceModel.Channels.TransportSecurityBindingElement CreateCertificateOverTransportBindingElement() { return default(System.ServiceModel.Channels.TransportSecurityBindingElement); }
    public static System.ServiceModel.Channels.TransportSecurityBindingElement CreateCertificateOverTransportBindingElement(System.ServiceModel.MessageSecurityVersion version) { return default(System.ServiceModel.Channels.TransportSecurityBindingElement); }
    public static System.ServiceModel.Channels.AsymmetricSecurityBindingElement CreateCertificateSignatureBindingElement() { return default(System.ServiceModel.Channels.AsymmetricSecurityBindingElement); }
    public static System.ServiceModel.Channels.SymmetricSecurityBindingElement CreateIssuedTokenBindingElement(System.ServiceModel.Security.Tokens.IssuedSecurityTokenParameters issuedTokenParameters) { return default(System.ServiceModel.Channels.SymmetricSecurityBindingElement); }
    public static System.ServiceModel.Channels.SymmetricSecurityBindingElement CreateIssuedTokenForCertificateBindingElement(System.ServiceModel.Security.Tokens.IssuedSecurityTokenParameters issuedTokenParameters) { return default(System.ServiceModel.Channels.SymmetricSecurityBindingElement); }
    public static System.ServiceModel.Channels.SymmetricSecurityBindingElement CreateIssuedTokenForSslBindingElement(System.ServiceModel.Security.Tokens.IssuedSecurityTokenParameters issuedTokenParameters) { return default(System.ServiceModel.Channels.SymmetricSecurityBindingElement); }
    public static System.ServiceModel.Channels.SymmetricSecurityBindingElement CreateIssuedTokenForSslBindingElement(System.ServiceModel.Security.Tokens.IssuedSecurityTokenParameters issuedTokenParameters, bool requireCancellation) { return default(System.ServiceModel.Channels.SymmetricSecurityBindingElement); }
    public static System.ServiceModel.Channels.TransportSecurityBindingElement CreateIssuedTokenOverTransportBindingElement(System.ServiceModel.Security.Tokens.IssuedSecurityTokenParameters issuedTokenParameters) { return default(System.ServiceModel.Channels.TransportSecurityBindingElement); }
    public static System.ServiceModel.Channels.SymmetricSecurityBindingElement CreateKerberosBindingElement() { return default(System.ServiceModel.Channels.SymmetricSecurityBindingElement); }
    public static System.ServiceModel.Channels.TransportSecurityBindingElement CreateKerberosOverTransportBindingElement() { return default(System.ServiceModel.Channels.TransportSecurityBindingElement); }
    public static System.ServiceModel.Channels.SecurityBindingElement CreateMutualCertificateBindingElement() { return default(System.ServiceModel.Channels.SecurityBindingElement); }
    public static System.ServiceModel.Channels.SecurityBindingElement CreateMutualCertificateBindingElement(System.ServiceModel.MessageSecurityVersion version) { return default(System.ServiceModel.Channels.SecurityBindingElement); }
    public static System.ServiceModel.Channels.SecurityBindingElement CreateMutualCertificateBindingElement(System.ServiceModel.MessageSecurityVersion version, bool allowSerializedSigningTokenOnReply) { return default(System.ServiceModel.Channels.SecurityBindingElement); }
    public static System.ServiceModel.Channels.AsymmetricSecurityBindingElement CreateMutualCertificateDuplexBindingElement() { return default(System.ServiceModel.Channels.AsymmetricSecurityBindingElement); }
    public static System.ServiceModel.Channels.AsymmetricSecurityBindingElement CreateMutualCertificateDuplexBindingElement(System.ServiceModel.MessageSecurityVersion version) { return default(System.ServiceModel.Channels.AsymmetricSecurityBindingElement); }
    public static System.ServiceModel.Channels.SecurityBindingElement CreateSecureConversationBindingElement(System.ServiceModel.Channels.SecurityBindingElement bootstrapSecurity) { return default(System.ServiceModel.Channels.SecurityBindingElement); }
    public static System.ServiceModel.Channels.SecurityBindingElement CreateSecureConversationBindingElement(System.ServiceModel.Channels.SecurityBindingElement bootstrapSecurity, bool requireCancellation) { return default(System.ServiceModel.Channels.SecurityBindingElement); }
    public static System.ServiceModel.Channels.SecurityBindingElement CreateSecureConversationBindingElement(System.ServiceModel.Channels.SecurityBindingElement bootstrapSecurity, bool requireCancellation, System.ServiceModel.Security.ChannelProtectionRequirements bootstrapProtectionRequirements) { return default(System.ServiceModel.Channels.SecurityBindingElement); }
    public static System.ServiceModel.Channels.SymmetricSecurityBindingElement CreateSslNegotiationBindingElement(bool requireClientCertificate) { return default(System.ServiceModel.Channels.SymmetricSecurityBindingElement); }
    public static System.ServiceModel.Channels.SymmetricSecurityBindingElement CreateSslNegotiationBindingElement(bool requireClientCertificate, bool requireCancellation) { return default(System.ServiceModel.Channels.SymmetricSecurityBindingElement); }
    public static System.ServiceModel.Channels.SymmetricSecurityBindingElement CreateSspiNegotiationBindingElement() { return default(System.ServiceModel.Channels.SymmetricSecurityBindingElement); }
    public static System.ServiceModel.Channels.SymmetricSecurityBindingElement CreateSspiNegotiationBindingElement(bool requireCancellation) { return default(System.ServiceModel.Channels.SymmetricSecurityBindingElement); }
    public static System.ServiceModel.Channels.TransportSecurityBindingElement CreateSspiNegotiationOverTransportBindingElement() { return default(System.ServiceModel.Channels.TransportSecurityBindingElement); }
    public static System.ServiceModel.Channels.TransportSecurityBindingElement CreateSspiNegotiationOverTransportBindingElement(bool requireCancellation) { return default(System.ServiceModel.Channels.TransportSecurityBindingElement); }
    public static System.ServiceModel.Channels.SymmetricSecurityBindingElement CreateUserNameForCertificateBindingElement() { return default(System.ServiceModel.Channels.SymmetricSecurityBindingElement); }
    public static System.ServiceModel.Channels.SymmetricSecurityBindingElement CreateUserNameForSslBindingElement() { return default(System.ServiceModel.Channels.SymmetricSecurityBindingElement); }
    public static System.ServiceModel.Channels.SymmetricSecurityBindingElement CreateUserNameForSslBindingElement(bool requireCancellation) { return default(System.ServiceModel.Channels.SymmetricSecurityBindingElement); }
    public static System.ServiceModel.Channels.TransportSecurityBindingElement CreateUserNameOverTransportBindingElement() { return default(System.ServiceModel.Channels.TransportSecurityBindingElement); }
    public override T GetProperty<T>(System.ServiceModel.Channels.BindingContext context) { return default(T); }
    protected static void SetIssuerBindingContextIfRequired(System.ServiceModel.Security.Tokens.SecurityTokenParameters parameters, System.ServiceModel.Channels.BindingContext issuerBindingContext) { }
    public virtual void SetKeyDerivation(bool requireDerivedKeys) { }
    public override string ToString() { return default(string); }
  }
  public partial class SecurityBindingElementImporter : System.ServiceModel.Description.IPolicyImportExtension {
    public SecurityBindingElementImporter() { }
    public int MaxPolicyRedirections { get { return default(int); } }
    void System.ServiceModel.Description.IPolicyImportExtension.ImportPolicy(System.ServiceModel.Description.MetadataImporter importer, System.ServiceModel.Description.PolicyConversionContext policyContext) { }
  }
  public enum SecurityHeaderLayout {
    Lax = 1,
    LaxTimestampFirst = 2,
    LaxTimestampLast = 3,
    Strict = 0,
  }
  public abstract partial class SessionOpenNotification {
    protected SessionOpenNotification() { }
    public abstract bool IsEnabled { get; }
    public abstract void UpdateMessageProperties(System.ServiceModel.Channels.MessageProperties inboundMessageProperties);
  }
  public partial class SslStreamSecurityBindingElement : System.ServiceModel.Channels.StreamUpgradeBindingElement, System.ServiceModel.Channels.ITransportTokenAssertionProvider, System.ServiceModel.Description.IPolicyExportExtension {
    public SslStreamSecurityBindingElement() { }
    protected SslStreamSecurityBindingElement(System.ServiceModel.Channels.SslStreamSecurityBindingElement elementToBeCloned) { }
    public System.ServiceModel.Security.IdentityVerifier IdentityVerifier { get { return default(System.ServiceModel.Security.IdentityVerifier); } set { } }
    [System.ComponentModel.DefaultValueAttribute(false)]
    public bool RequireClientCertificate { get { return default(bool); } set { } }
    [System.ComponentModel.DefaultValueAttribute((System.Security.Authentication.SslProtocols)(4080))]
    public System.Security.Authentication.SslProtocols SslProtocols { get { return default(System.Security.Authentication.SslProtocols); } set { } }
    public override System.ServiceModel.Channels.IChannelFactory<TChannel> BuildChannelFactory<TChannel>(System.ServiceModel.Channels.BindingContext context) { return default(System.ServiceModel.Channels.IChannelFactory<TChannel>); }
    public override System.ServiceModel.Channels.IChannelListener<TChannel> BuildChannelListener<TChannel>(System.ServiceModel.Channels.BindingContext context) { return default(System.ServiceModel.Channels.IChannelListener<TChannel>); }
    public override System.ServiceModel.Channels.StreamUpgradeProvider BuildClientStreamUpgradeProvider(System.ServiceModel.Channels.BindingContext context) { return default(System.ServiceModel.Channels.StreamUpgradeProvider); }
    public override System.ServiceModel.Channels.StreamUpgradeProvider BuildServerStreamUpgradeProvider(System.ServiceModel.Channels.BindingContext context) { return default(System.ServiceModel.Channels.StreamUpgradeProvider); }
    public override bool CanBuildChannelFactory<TChannel>(System.ServiceModel.Channels.BindingContext context) { return default(bool); }
    public override bool CanBuildChannelListener<TChannel>(System.ServiceModel.Channels.BindingContext context) { return default(bool); }
    public override System.ServiceModel.Channels.BindingElement Clone() { return default(System.ServiceModel.Channels.BindingElement); }
    public override T GetProperty<T>(System.ServiceModel.Channels.BindingContext context) { return default(T); }
    public System.Xml.XmlElement GetTransportTokenAssertion() { return default(System.Xml.XmlElement); }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public bool ShouldSerializeIdentityVerifier() { return default(bool); }
    void System.ServiceModel.Description.IPolicyExportExtension.ExportPolicy(System.ServiceModel.Description.MetadataExporter exporter, System.ServiceModel.Description.PolicyConversionContext context) { }
  }
  public partial class StandardBindingImporter : System.ServiceModel.Description.IWsdlImportExtension {
    public StandardBindingImporter() { }
    void System.ServiceModel.Description.IWsdlImportExtension.BeforeImport(System.Web.Services.Description.ServiceDescriptionCollection wsdlDocuments, System.Xml.Schema.XmlSchemaSet xmlSchemas, System.Collections.Generic.ICollection<System.Xml.XmlElement> policy) { }
    void System.ServiceModel.Description.IWsdlImportExtension.ImportContract(System.ServiceModel.Description.WsdlImporter importer, System.ServiceModel.Description.WsdlContractConversionContext context) { }
    void System.ServiceModel.Description.IWsdlImportExtension.ImportEndpoint(System.ServiceModel.Description.WsdlImporter importer, System.ServiceModel.Description.WsdlEndpointConversionContext endpointContext) { }
  }
  public abstract partial class StreamSecurityUpgradeAcceptor : System.ServiceModel.Channels.StreamUpgradeAcceptor {
    protected StreamSecurityUpgradeAcceptor() { }
    public abstract System.ServiceModel.Security.SecurityMessageProperty GetRemoteSecurity();
  }
  public abstract partial class StreamSecurityUpgradeInitiator : System.ServiceModel.Channels.StreamUpgradeInitiator {
    protected StreamSecurityUpgradeInitiator() { }
    public abstract System.ServiceModel.Security.SecurityMessageProperty GetRemoteSecurity();
  }
  public abstract partial class StreamSecurityUpgradeProvider : System.ServiceModel.Channels.StreamUpgradeProvider {
    protected StreamSecurityUpgradeProvider() { }
    protected StreamSecurityUpgradeProvider(System.ServiceModel.IDefaultCommunicationTimeouts timeouts) { }
    public abstract System.ServiceModel.EndpointIdentity Identity { get; }
  }
  public abstract partial class StreamUpgradeAcceptor {
    protected StreamUpgradeAcceptor() { }
    public virtual System.IO.Stream AcceptUpgrade(System.IO.Stream stream) { return default(System.IO.Stream); }
    public abstract System.IAsyncResult BeginAcceptUpgrade(System.IO.Stream stream, System.AsyncCallback callback, object state);
    public abstract bool CanUpgrade(string contentType);
    public abstract System.IO.Stream EndAcceptUpgrade(System.IAsyncResult result);
  }
  public abstract partial class StreamUpgradeBindingElement : System.ServiceModel.Channels.BindingElement {
    protected StreamUpgradeBindingElement() { }
    protected StreamUpgradeBindingElement(System.ServiceModel.Channels.StreamUpgradeBindingElement elementToBeCloned) { }
    public abstract System.ServiceModel.Channels.StreamUpgradeProvider BuildClientStreamUpgradeProvider(System.ServiceModel.Channels.BindingContext context);
    public abstract System.ServiceModel.Channels.StreamUpgradeProvider BuildServerStreamUpgradeProvider(System.ServiceModel.Channels.BindingContext context);
  }
  public abstract partial class StreamUpgradeInitiator {
    protected StreamUpgradeInitiator() { }
    public abstract System.IAsyncResult BeginInitiateUpgrade(System.IO.Stream stream, System.AsyncCallback callback, object state);
    public abstract System.IO.Stream EndInitiateUpgrade(System.IAsyncResult result);
    public abstract string GetNextUpgrade();
    public abstract System.IO.Stream InitiateUpgrade(System.IO.Stream stream);
  }
  public abstract partial class StreamUpgradeProvider : System.ServiceModel.Channels.CommunicationObject {
    protected StreamUpgradeProvider() { }
    protected StreamUpgradeProvider(System.ServiceModel.IDefaultCommunicationTimeouts timeouts) { }
    protected override System.TimeSpan DefaultCloseTimeout { get { return default(System.TimeSpan); } }
    protected override System.TimeSpan DefaultOpenTimeout { get { return default(System.TimeSpan); } }
    public abstract System.ServiceModel.Channels.StreamUpgradeAcceptor CreateUpgradeAcceptor();
    public abstract System.ServiceModel.Channels.StreamUpgradeInitiator CreateUpgradeInitiator(System.ServiceModel.EndpointAddress remoteAddress, System.Uri via);
    public virtual T GetProperty<T>() where T : class { return default(T); }
  }
  public enum SupportedAddressingMode {
    Anonymous = 0,
    Mixed = 2,
    NonAnonymous = 1,
  }
  public sealed partial class SymmetricSecurityBindingElement : System.ServiceModel.Channels.SecurityBindingElement, System.ServiceModel.Description.IPolicyExportExtension {
    public SymmetricSecurityBindingElement() { }
    public SymmetricSecurityBindingElement(System.ServiceModel.Security.Tokens.SecurityTokenParameters protectionTokenParameters) { }
    public System.ServiceModel.Security.MessageProtectionOrder MessageProtectionOrder { get { return default(System.ServiceModel.Security.MessageProtectionOrder); } set { } }
    public System.ServiceModel.Security.Tokens.SecurityTokenParameters ProtectionTokenParameters { get { return default(System.ServiceModel.Security.Tokens.SecurityTokenParameters); } set { } }
    public bool RequireSignatureConfirmation { get { return default(bool); } set { } }
    protected override System.ServiceModel.Channels.IChannelFactory<TChannel> BuildChannelFactoryCore<TChannel>(System.ServiceModel.Channels.BindingContext context) { return default(System.ServiceModel.Channels.IChannelFactory<TChannel>); }
    protected override System.ServiceModel.Channels.IChannelListener<TChannel> BuildChannelListenerCore<TChannel>(System.ServiceModel.Channels.BindingContext context) { return default(System.ServiceModel.Channels.IChannelListener<TChannel>); }
    public override System.ServiceModel.Channels.BindingElement Clone() { return default(System.ServiceModel.Channels.BindingElement); }
    public override T GetProperty<T>(System.ServiceModel.Channels.BindingContext context) { return default(T); }
    public override void SetKeyDerivation(bool requireDerivedKeys) { }
    void System.ServiceModel.Description.IPolicyExportExtension.ExportPolicy(System.ServiceModel.Description.MetadataExporter exporter, System.ServiceModel.Description.PolicyConversionContext context) { }
    public override string ToString() { return default(string); }
  }
  public sealed partial class TcpConnectionPoolSettings {
    internal TcpConnectionPoolSettings() { }
    public string GroupName { get { return default(string); } set { } }
    public System.TimeSpan IdleTimeout { get { return default(System.TimeSpan); } set { } }
    public System.TimeSpan LeaseTimeout { get { return default(System.TimeSpan); } set { } }
    public int MaxOutboundConnectionsPerEndpoint { get { return default(int); } set { } }
  }
  public partial class TcpTransportBindingElement : System.ServiceModel.Channels.ConnectionOrientedTransportBindingElement {
    public TcpTransportBindingElement() { }
    protected TcpTransportBindingElement(System.ServiceModel.Channels.TcpTransportBindingElement elementToBeCloned) { }
    public System.ServiceModel.Channels.TcpConnectionPoolSettings ConnectionPoolSettings { get { return default(System.ServiceModel.Channels.TcpConnectionPoolSettings); } }
    public System.Security.Authentication.ExtendedProtection.ExtendedProtectionPolicy ExtendedProtectionPolicy { get { return default(System.Security.Authentication.ExtendedProtection.ExtendedProtectionPolicy); } set { } }
    public int ListenBacklog { get { return default(int); } set { } }
    [System.ComponentModel.DefaultValueAttribute(false)]
    public bool PortSharingEnabled { get { return default(bool); } set { } }
    public override string Scheme { get { return default(string); } }
    [System.ComponentModel.DefaultValueAttribute(false)]
    public bool TeredoEnabled { get { return default(bool); } set { } }
    public override System.ServiceModel.Channels.IChannelFactory<TChannel> BuildChannelFactory<TChannel>(System.ServiceModel.Channels.BindingContext context) { return default(System.ServiceModel.Channels.IChannelFactory<TChannel>); }
    public override System.ServiceModel.Channels.IChannelListener<TChannel> BuildChannelListener<TChannel>(System.ServiceModel.Channels.BindingContext context) { return default(System.ServiceModel.Channels.IChannelListener<TChannel>); }
    public override System.ServiceModel.Channels.BindingElement Clone() { return default(System.ServiceModel.Channels.BindingElement); }
    public override T GetProperty<T>(System.ServiceModel.Channels.BindingContext context) { return default(T); }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public bool ShouldSerializeExtendedProtectionPolicy() { return default(bool); }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public bool ShouldSerializeListenBacklog() { return default(bool); }
  }
  public sealed partial class TextMessageEncodingBindingElement : System.ServiceModel.Channels.MessageEncodingBindingElement, System.ServiceModel.Description.IPolicyExportExtension, System.ServiceModel.Description.IWsdlExportExtension {
    public TextMessageEncodingBindingElement() { }
    public TextMessageEncodingBindingElement(System.ServiceModel.Channels.MessageVersion messageVersion, System.Text.Encoding writeEncoding) { }
    [System.ComponentModel.DefaultValueAttribute(64)]
    public int MaxReadPoolSize { get { return default(int); } set { } }
    [System.ComponentModel.DefaultValueAttribute(16)]
    public int MaxWritePoolSize { get { return default(int); } set { } }
    public override System.ServiceModel.Channels.MessageVersion MessageVersion { get { return default(System.ServiceModel.Channels.MessageVersion); } set { } }
    public System.Xml.XmlDictionaryReaderQuotas ReaderQuotas { get { return default(System.Xml.XmlDictionaryReaderQuotas); } set { } }
    [System.ComponentModel.TypeConverterAttribute(typeof(System.ServiceModel.Configuration.EncodingConverter))]
    public System.Text.Encoding WriteEncoding { get { return default(System.Text.Encoding); } set { } }
    public override System.ServiceModel.Channels.IChannelFactory<TChannel> BuildChannelFactory<TChannel>(System.ServiceModel.Channels.BindingContext context) { return default(System.ServiceModel.Channels.IChannelFactory<TChannel>); }
    public override System.ServiceModel.Channels.IChannelListener<TChannel> BuildChannelListener<TChannel>(System.ServiceModel.Channels.BindingContext context) { return default(System.ServiceModel.Channels.IChannelListener<TChannel>); }
    public override bool CanBuildChannelListener<TChannel>(System.ServiceModel.Channels.BindingContext context) { return default(bool); }
    public override System.ServiceModel.Channels.BindingElement Clone() { return default(System.ServiceModel.Channels.BindingElement); }
    public override System.ServiceModel.Channels.MessageEncoderFactory CreateMessageEncoderFactory() { return default(System.ServiceModel.Channels.MessageEncoderFactory); }
    public override T GetProperty<T>(System.ServiceModel.Channels.BindingContext context) { return default(T); }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public bool ShouldSerializeReaderQuotas() { return default(bool); }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public bool ShouldSerializeWriteEncoding() { return default(bool); }
    void System.ServiceModel.Description.IPolicyExportExtension.ExportPolicy(System.ServiceModel.Description.MetadataExporter exporter, System.ServiceModel.Description.PolicyConversionContext context) { }
    void System.ServiceModel.Description.IWsdlExportExtension.ExportContract(System.ServiceModel.Description.WsdlExporter exporter, System.ServiceModel.Description.WsdlContractConversionContext context) { }
    void System.ServiceModel.Description.IWsdlExportExtension.ExportEndpoint(System.ServiceModel.Description.WsdlExporter exporter, System.ServiceModel.Description.WsdlEndpointConversionContext context) { }
  }
  public sealed partial class TransactionFlowBindingElement : System.ServiceModel.Channels.BindingElement, System.ServiceModel.Description.IPolicyExportExtension {
    public TransactionFlowBindingElement() { }
    public TransactionFlowBindingElement(System.ServiceModel.TransactionProtocol transactionProtocol) { }
    [System.ComponentModel.DefaultValueAttribute(false)]
    public bool AllowWildcardAction { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.ServiceModel.TransactionProtocol TransactionProtocol { get { return default(System.ServiceModel.TransactionProtocol); } set { } }
    public override System.ServiceModel.Channels.IChannelFactory<TChannel> BuildChannelFactory<TChannel>(System.ServiceModel.Channels.BindingContext context) { return default(System.ServiceModel.Channels.IChannelFactory<TChannel>); }
    public override System.ServiceModel.Channels.IChannelListener<TChannel> BuildChannelListener<TChannel>(System.ServiceModel.Channels.BindingContext context) { return default(System.ServiceModel.Channels.IChannelListener<TChannel>); }
    public override bool CanBuildChannelFactory<TChannel>(System.ServiceModel.Channels.BindingContext context) { return default(bool); }
    public override bool CanBuildChannelListener<TChannel>(System.ServiceModel.Channels.BindingContext context) { return default(bool); }
    public override System.ServiceModel.Channels.BindingElement Clone() { return default(System.ServiceModel.Channels.BindingElement); }
    public override T GetProperty<T>(System.ServiceModel.Channels.BindingContext context) { return default(T); }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public bool ShouldSerializeTransactionProtocol() { return default(bool); }
    void System.ServiceModel.Description.IPolicyExportExtension.ExportPolicy(System.ServiceModel.Description.MetadataExporter exporter, System.ServiceModel.Description.PolicyConversionContext context) { }
  }
  public sealed partial class TransactionFlowBindingElementImporter : System.ServiceModel.Description.IPolicyImportExtension {
    public TransactionFlowBindingElementImporter() { }
    void System.ServiceModel.Description.IPolicyImportExtension.ImportPolicy(System.ServiceModel.Description.MetadataImporter importer, System.ServiceModel.Description.PolicyConversionContext context) { }
  }
  public sealed partial class TransactionMessageProperty {
    internal TransactionMessageProperty() { }
    public System.Transactions.Transaction Transaction { get { return default(System.Transactions.Transaction); } }
    public static void Set(System.Transactions.Transaction transaction, System.ServiceModel.Channels.Message message) { }
  }
  public enum TransferSession {
    None = 0,
    Ordered = 1,
    Unordered = 2,
  }
  public abstract partial class TransportBindingElement : System.ServiceModel.Channels.BindingElement {
    protected TransportBindingElement() { }
    protected TransportBindingElement(System.ServiceModel.Channels.TransportBindingElement elementToBeCloned) { }
    [System.ComponentModel.DefaultValueAttribute(false)]
    public virtual bool ManualAddressing { get { return default(bool); } set { } }
    [System.ComponentModel.DefaultValueAttribute((long)524288)]
    public virtual long MaxBufferPoolSize { get { return default(long); } set { } }
    [System.ComponentModel.DefaultValueAttribute((long)65536)]
    public virtual long MaxReceivedMessageSize { get { return default(long); } set { } }
    public abstract string Scheme { get; }
    public override T GetProperty<T>(System.ServiceModel.Channels.BindingContext context) { return default(T); }
  }
  public partial class TransportBindingElementImporter : System.ServiceModel.Description.IPolicyImportExtension, System.ServiceModel.Description.IWsdlImportExtension {
    public TransportBindingElementImporter() { }
    void System.ServiceModel.Description.IPolicyImportExtension.ImportPolicy(System.ServiceModel.Description.MetadataImporter importer, System.ServiceModel.Description.PolicyConversionContext policyContext) { }
    void System.ServiceModel.Description.IWsdlImportExtension.BeforeImport(System.Web.Services.Description.ServiceDescriptionCollection wsdlDocuments, System.Xml.Schema.XmlSchemaSet xmlSchemas, System.Collections.Generic.ICollection<System.Xml.XmlElement> policy) { }
    void System.ServiceModel.Description.IWsdlImportExtension.ImportContract(System.ServiceModel.Description.WsdlImporter importer, System.ServiceModel.Description.WsdlContractConversionContext context) { }
    void System.ServiceModel.Description.IWsdlImportExtension.ImportEndpoint(System.ServiceModel.Description.WsdlImporter importer, System.ServiceModel.Description.WsdlEndpointConversionContext context) { }
  }
  public sealed partial class TransportSecurityBindingElement : System.ServiceModel.Channels.SecurityBindingElement, System.ServiceModel.Description.IPolicyExportExtension {
    public TransportSecurityBindingElement() { }
    protected override System.ServiceModel.Channels.IChannelFactory<TChannel> BuildChannelFactoryCore<TChannel>(System.ServiceModel.Channels.BindingContext context) { return default(System.ServiceModel.Channels.IChannelFactory<TChannel>); }
    protected override System.ServiceModel.Channels.IChannelListener<TChannel> BuildChannelListenerCore<TChannel>(System.ServiceModel.Channels.BindingContext context) { return default(System.ServiceModel.Channels.IChannelListener<TChannel>); }
    public override System.ServiceModel.Channels.BindingElement Clone() { return default(System.ServiceModel.Channels.BindingElement); }
    public override T GetProperty<T>(System.ServiceModel.Channels.BindingContext context) { return default(T); }
    void System.ServiceModel.Description.IPolicyExportExtension.ExportPolicy(System.ServiceModel.Description.MetadataExporter exporter, System.ServiceModel.Description.PolicyConversionContext policyContext) { }
  }
  public sealed partial class UnderstoodHeaders : System.Collections.Generic.IEnumerable<System.ServiceModel.Channels.MessageHeaderInfo>, System.Collections.IEnumerable {
    internal UnderstoodHeaders() { }
    public void Add(System.ServiceModel.Channels.MessageHeaderInfo headerInfo) { }
    public bool Contains(System.ServiceModel.Channels.MessageHeaderInfo headerInfo) { return default(bool); }
    public System.Collections.Generic.IEnumerator<System.ServiceModel.Channels.MessageHeaderInfo> GetEnumerator() { return default(System.Collections.Generic.IEnumerator<System.ServiceModel.Channels.MessageHeaderInfo>); }
    public void Remove(System.ServiceModel.Channels.MessageHeaderInfo headerInfo) { }
    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { return default(System.Collections.IEnumerator); }
  }
  public sealed partial class UseManagedPresentationBindingElement : System.ServiceModel.Channels.BindingElement, System.ServiceModel.Description.IPolicyExportExtension {
    public UseManagedPresentationBindingElement() { }
    public override System.ServiceModel.Channels.BindingElement Clone() { return default(System.ServiceModel.Channels.BindingElement); }
    public override T GetProperty<T>(System.ServiceModel.Channels.BindingContext context) { return default(T); }
    void System.ServiceModel.Description.IPolicyExportExtension.ExportPolicy(System.ServiceModel.Description.MetadataExporter exporter, System.ServiceModel.Description.PolicyConversionContext context) { }
  }
  public sealed partial class UseManagedPresentationBindingElementImporter : System.ServiceModel.Description.IPolicyImportExtension {
    public UseManagedPresentationBindingElementImporter() { }
    void System.ServiceModel.Description.IPolicyImportExtension.ImportPolicy(System.ServiceModel.Description.MetadataImporter importer, System.ServiceModel.Description.PolicyConversionContext policyContext) { }
  }
  public sealed partial class WebSocketMessageProperty {
    public const string Name = "WebSocketMessageProperty";
    public WebSocketMessageProperty() { }
    public System.Net.WebSockets.WebSocketMessageType MessageType { get { return default(System.Net.WebSockets.WebSocketMessageType); } set { } }
    public System.Collections.ObjectModel.ReadOnlyDictionary<System.String, System.Object> OpeningHandshakeProperties { get { return default(System.Collections.ObjectModel.ReadOnlyDictionary<System.String, System.Object>); } }
    public string SubProtocol { get { return default(string); } }
    public System.Net.WebSockets.WebSocketContext WebSocketContext { get { return default(System.Net.WebSockets.WebSocketContext); } }
  }
  public sealed partial class WebSocketTransportSettings : System.IEquatable<System.ServiceModel.Channels.WebSocketTransportSettings> {
    public const string BinaryEncoderTransferModeHeader = "microsoft-binary-transfer-mode";
    public const string BinaryMessageReceivedAction = "http://schemas.microsoft.com/2011/02/websockets/onbinarymessage";
    public const string ConnectionOpenedAction = "http://schemas.microsoft.com/2011/02/session/onopen";
    public const string SoapContentTypeHeader = "soap-content-type";
    public const string TextMessageReceivedAction = "http://schemas.microsoft.com/2011/02/websockets/ontextmessage";
    public WebSocketTransportSettings() { }
    [System.ComponentModel.DefaultValueAttribute(false)]
    public bool CreateNotificationOnConnection { get { return default(bool); } set { } }
    [System.ComponentModel.DefaultValueAttribute(false)]
    public bool DisablePayloadMasking { get { return default(bool); } set { } }
    [System.ComponentModel.DefaultValueAttribute(typeof(System.TimeSpan), "00:00:00")]
    public System.TimeSpan KeepAliveInterval { get { return default(System.TimeSpan); } set { } }
    [System.ComponentModel.DefaultValueAttribute(0)]
    public int MaxPendingConnections { get { return default(int); } set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public string SubProtocol { get { return default(string); } set { } }
    [System.ComponentModel.DefaultValueAttribute((System.ServiceModel.Channels.WebSocketTransportUsage)(2))]
    public System.ServiceModel.Channels.WebSocketTransportUsage TransportUsage { get { return default(System.ServiceModel.Channels.WebSocketTransportUsage); } set { } }
    public override bool Equals(object obj) { return default(bool); }
    public bool Equals(System.ServiceModel.Channels.WebSocketTransportSettings other) { return default(bool); }
    public override int GetHashCode() { return default(int); }
  }
  public enum WebSocketTransportUsage {
    Always = 1,
    Never = 2,
    WhenDuplex = 0,
  }
  public partial class WindowsStreamSecurityBindingElement : System.ServiceModel.Channels.StreamUpgradeBindingElement, System.ServiceModel.Channels.ITransportTokenAssertionProvider, System.ServiceModel.Description.IPolicyExportExtension {
    public WindowsStreamSecurityBindingElement() { }
    protected WindowsStreamSecurityBindingElement(System.ServiceModel.Channels.WindowsStreamSecurityBindingElement elementToBeCloned) { }
    [System.ComponentModel.DefaultValueAttribute((System.Net.Security.ProtectionLevel)(2))]
    public System.Net.Security.ProtectionLevel ProtectionLevel { get { return default(System.Net.Security.ProtectionLevel); } set { } }
    public override System.ServiceModel.Channels.IChannelFactory<TChannel> BuildChannelFactory<TChannel>(System.ServiceModel.Channels.BindingContext context) { return default(System.ServiceModel.Channels.IChannelFactory<TChannel>); }
    public override System.ServiceModel.Channels.IChannelListener<TChannel> BuildChannelListener<TChannel>(System.ServiceModel.Channels.BindingContext context) { return default(System.ServiceModel.Channels.IChannelListener<TChannel>); }
    public override System.ServiceModel.Channels.StreamUpgradeProvider BuildClientStreamUpgradeProvider(System.ServiceModel.Channels.BindingContext context) { return default(System.ServiceModel.Channels.StreamUpgradeProvider); }
    public override System.ServiceModel.Channels.StreamUpgradeProvider BuildServerStreamUpgradeProvider(System.ServiceModel.Channels.BindingContext context) { return default(System.ServiceModel.Channels.StreamUpgradeProvider); }
    public override bool CanBuildChannelFactory<TChannel>(System.ServiceModel.Channels.BindingContext context) { return default(bool); }
    public override bool CanBuildChannelListener<TChannel>(System.ServiceModel.Channels.BindingContext context) { return default(bool); }
    public override System.ServiceModel.Channels.BindingElement Clone() { return default(System.ServiceModel.Channels.BindingElement); }
    public override T GetProperty<T>(System.ServiceModel.Channels.BindingContext context) { return default(T); }
    public System.Xml.XmlElement GetTransportTokenAssertion() { return default(System.Xml.XmlElement); }
    void System.ServiceModel.Description.IPolicyExportExtension.ExportPolicy(System.ServiceModel.Description.MetadataExporter exporter, System.ServiceModel.Description.PolicyConversionContext context) { }
  }
  public partial class WrappedOptions {
    public WrappedOptions() { }
    public bool WrappedFlag { get { return default(bool); } set { } }
  }
  public partial class XmlSerializerImportOptions {
    public XmlSerializerImportOptions() { }
    public XmlSerializerImportOptions(System.CodeDom.CodeCompileUnit codeCompileUnit) { }
    public string ClrNamespace { get { return default(string); } set { } }
    public System.CodeDom.CodeCompileUnit CodeCompileUnit { get { return default(System.CodeDom.CodeCompileUnit); } }
    public System.CodeDom.Compiler.CodeDomProvider CodeProvider { get { return default(System.CodeDom.Compiler.CodeDomProvider); } set { } }
    public System.Web.Services.Description.WebReferenceOptions WebReferenceOptions { get { return default(System.Web.Services.Description.WebReferenceOptions); } set { } }
  }
}
namespace System.ServiceModel.ComIntegration {
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  [System.Runtime.InteropServices.GuidAttribute("59856830-3ECB-4D29-9CFE-DDD0F74B96A2")]
  public partial class DllHostInitializer}
