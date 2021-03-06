namespace System.ServiceModel.Dispatcher {
  public partial class EndpointNameMessageFilter : System.ServiceModel.Dispatcher.MessageFilter {
    public EndpointNameMessageFilter(string endpointName) { }
    [System.MonoTODOAttribute]
    public override bool Match(System.ServiceModel.Channels.Message message) { return default(bool); }
    [System.MonoTODOAttribute]
    public override bool Match(System.ServiceModel.Channels.MessageBuffer buffer) { return default(bool); }
  }
  public partial class StrictAndMessageFilter : System.ServiceModel.Dispatcher.MessageFilter {
    public StrictAndMessageFilter(System.ServiceModel.Dispatcher.MessageFilter filter1, System.ServiceModel.Dispatcher.MessageFilter filter2) { }
    public override bool Match(System.ServiceModel.Channels.Message message) { return default(bool); }
    public override bool Match(System.ServiceModel.Channels.MessageBuffer buffer) { return default(bool); }
  }
}
namespace System.ServiceModel.Routing {
  [System.ServiceModel.ServiceContractAttribute(Namespace="http://schemas.microsoft.com/netfx/2009/05/routing", SessionMode=(System.ServiceModel.SessionMode)(1))]
  public partial interface IDuplexSessionRouter {
    [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, IsOneWay=true, Action="*")]
    System.IAsyncResult BeginProcessMessage(System.ServiceModel.Channels.Message message, System.AsyncCallback callback, object state);
    void EndProcessMessage(System.IAsyncResult result);
  }
  [System.ServiceModel.ServiceContractAttribute(Namespace="http://schemas.microsoft.com/netfx/2009/05/routing", SessionMode=(System.ServiceModel.SessionMode)(0))]
  public partial interface IRequestReplyRouter {
    [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, IsOneWay=false, Action="*", ReplyAction="*")]
    System.IAsyncResult BeginProcessRequest(System.ServiceModel.Channels.Message message, System.AsyncCallback callback, object state);
    System.ServiceModel.Channels.Message EndProcessRequest(System.IAsyncResult result);
  }
  [System.ServiceModel.ServiceContractAttribute(Namespace="http://schemas.microsoft.com/netfx/2009/05/routing", SessionMode=(System.ServiceModel.SessionMode)(0))]
  public partial interface ISimplexDatagramRouter {
    [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, IsOneWay=true, Action="*")]
    System.IAsyncResult BeginProcessMessage(System.ServiceModel.Channels.Message message, System.AsyncCallback callback, object state);
    void EndProcessMessage(System.IAsyncResult result);
  }
  [System.ServiceModel.ServiceContractAttribute(Namespace="http://schemas.microsoft.com/netfx/2009/05/routing", SessionMode=(System.ServiceModel.SessionMode)(1))]
  public partial interface ISimplexSessionRouter {
    [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, IsOneWay=true, Action="*")]
    System.IAsyncResult BeginProcessMessage(System.ServiceModel.Channels.Message message, System.AsyncCallback callback, object state);
    void EndProcessMessage(System.IAsyncResult result);
  }
  public sealed partial class RoutingBehavior : System.ServiceModel.Description.IServiceBehavior {
    public RoutingBehavior(System.ServiceModel.Routing.RoutingConfiguration routingConfiguration) { }
    [System.MonoTODOAttribute]
    public static System.Type GetContractForDescription(System.ServiceModel.Description.ContractDescription description) { return default(System.Type); }
    void System.ServiceModel.Description.IServiceBehavior.AddBindingParameters(System.ServiceModel.Description.ServiceDescription serviceDescription, System.ServiceModel.ServiceHostBase serviceHostBase, System.Collections.ObjectModel.Collection<System.ServiceModel.Description.ServiceEndpoint> endpoints, System.ServiceModel.Channels.BindingParameterCollection bindingParameters) { }
    void System.ServiceModel.Description.IServiceBehavior.ApplyDispatchBehavior(System.ServiceModel.Description.ServiceDescription serviceDescription, System.ServiceModel.ServiceHostBase serviceHostBase) { }
    void System.ServiceModel.Description.IServiceBehavior.Validate(System.ServiceModel.Description.ServiceDescription serviceDescription, System.ServiceModel.ServiceHostBase serviceHostBase) { }
  }
  public sealed partial class RoutingConfiguration {
    public RoutingConfiguration() { }
    public RoutingConfiguration(System.ServiceModel.Dispatcher.MessageFilterTable<System.Collections.Generic.IEnumerable<System.ServiceModel.Description.ServiceEndpoint>> filterTable, bool routeOnHeadersOnly) { }
    public System.ServiceModel.Dispatcher.MessageFilterTable<System.Collections.Generic.IEnumerable<System.ServiceModel.Description.ServiceEndpoint>> FilterTable { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.ServiceModel.Dispatcher.MessageFilterTable<System.Collections.Generic.IEnumerable<System.ServiceModel.Description.ServiceEndpoint>>); } }
    public bool RouteOnHeadersOnly { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public bool SoapProcessingEnabled { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
  }
  public sealed partial class RoutingExtension : System.ServiceModel.IExtension<System.ServiceModel.ServiceHostBase> {
    internal RoutingExtension() { }
    public void ApplyConfiguration(System.ServiceModel.Routing.RoutingConfiguration routingConfiguration) { }
    void System.ServiceModel.IExtension<System.ServiceModel.ServiceHostBase>.Attach(System.ServiceModel.ServiceHostBase owner) { }
    void System.ServiceModel.IExtension<System.ServiceModel.ServiceHostBase>.Detach(System.ServiceModel.ServiceHostBase owner) { }
  }
  [System.ServiceModel.ServiceBehaviorAttribute(AddressFilterMode=(System.ServiceModel.AddressFilterMode)(2), InstanceContextMode=(System.ServiceModel.InstanceContextMode)(0), UseSynchronizationContext=false, ValidateMustUnderstand=false)]
  public sealed partial class RoutingService : System.ServiceModel.Routing.IDuplexSessionRouter, System.ServiceModel.Routing.IRequestReplyRouter, System.ServiceModel.Routing.ISimplexDatagramRouter, System.ServiceModel.Routing.ISimplexSessionRouter {
    internal RoutingService() { }
    System.IAsyncResult System.ServiceModel.Routing.IDuplexSessionRouter.BeginProcessMessage(System.ServiceModel.Channels.Message message, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    void System.ServiceModel.Routing.IDuplexSessionRouter.EndProcessMessage(System.IAsyncResult result) { }
    System.IAsyncResult System.ServiceModel.Routing.IRequestReplyRouter.BeginProcessRequest(System.ServiceModel.Channels.Message message, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    System.ServiceModel.Channels.Message System.ServiceModel.Routing.IRequestReplyRouter.EndProcessRequest(System.IAsyncResult result) { return default(System.ServiceModel.Channels.Message); }
    System.IAsyncResult System.ServiceModel.Routing.ISimplexDatagramRouter.BeginProcessMessage(System.ServiceModel.Channels.Message message, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    void System.ServiceModel.Routing.ISimplexDatagramRouter.EndProcessMessage(System.IAsyncResult result) { }
    System.IAsyncResult System.ServiceModel.Routing.ISimplexSessionRouter.BeginProcessMessage(System.ServiceModel.Channels.Message message, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    void System.ServiceModel.Routing.ISimplexSessionRouter.EndProcessMessage(System.IAsyncResult result) { }
  }
  public partial class SoapProcessingBehavior : System.ServiceModel.Description.IEndpointBehavior {
    public SoapProcessingBehavior() { }
    public bool ProcessMessages { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public void AddBindingParameters(System.ServiceModel.Description.ServiceEndpoint endpoint, System.ServiceModel.Channels.BindingParameterCollection bindingParameters) { }
    public void ApplyClientBehavior(System.ServiceModel.Description.ServiceEndpoint endpoint, System.ServiceModel.Dispatcher.ClientRuntime clientRuntime) { }
    public void ApplyDispatchBehavior(System.ServiceModel.Description.ServiceEndpoint endpoint, System.ServiceModel.Dispatcher.EndpointDispatcher endpointDispatcher) { }
    public void Validate(System.ServiceModel.Description.ServiceEndpoint endpoint) { }
  }
}
namespace System.ServiceModel.Routing.Configuration {
  [System.Configuration.ConfigurationCollectionAttribute(typeof(System.ServiceModel.Routing.Configuration.BackupEndpointElement))]
  public partial class BackupEndpointCollection : System.Configuration.ConfigurationElementCollection {
    public BackupEndpointCollection() { }
    [System.Configuration.ConfigurationPropertyAttribute("name", DefaultValue=null, Options=(System.Configuration.ConfigurationPropertyOptions)(2))]
    public string Name { get { return default(string); } set { } }
    public void Add(System.ServiceModel.Routing.Configuration.BackupEndpointElement element) { }
    public void Clear() { }
    protected override System.Configuration.ConfigurationElement CreateNewElement() { return default(System.Configuration.ConfigurationElement); }
    protected override object GetElementKey(System.Configuration.ConfigurationElement element) { return default(object); }
    public void Remove(System.ServiceModel.Routing.Configuration.BackupEndpointElement element) { }
  }
  public partial class BackupEndpointElement : System.Configuration.ConfigurationElement {
    public BackupEndpointElement() { }
    [System.Configuration.ConfigurationPropertyAttribute("endpointName", DefaultValue=null, Options=(System.Configuration.ConfigurationPropertyOptions)(2))]
    public string EndpointName { get { return default(string); } set { } }
  }
  [System.Configuration.ConfigurationCollectionAttribute(typeof(System.ServiceModel.Routing.Configuration.BackupEndpointCollection), AddItemName="backupList")]
  public partial class BackupListCollection : System.Configuration.ConfigurationElementCollection {
    public BackupListCollection() { }
    public new System.ServiceModel.Routing.Configuration.BackupEndpointCollection this[string name] { get { return default(System.ServiceModel.Routing.Configuration.BackupEndpointCollection); } }
    public void Add(System.ServiceModel.Routing.Configuration.BackupEndpointCollection element) { }
    public void Clear() { }
    protected override System.Configuration.ConfigurationElement CreateNewElement() { return default(System.Configuration.ConfigurationElement); }
    protected override object GetElementKey(System.Configuration.ConfigurationElement element) { return default(object); }
    public void Remove(System.ServiceModel.Routing.Configuration.BackupEndpointCollection element) { }
  }
  public partial class FilterElement : System.Configuration.ConfigurationElement {
    public FilterElement() { }
    [System.Configuration.ConfigurationPropertyAttribute("customType", DefaultValue=null, Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    public string CustomType { get { return default(string); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("filter1", DefaultValue=null, Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    public string Filter1 { get { return default(string); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("filter2", DefaultValue=null, Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    public string Filter2 { get { return default(string); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("filterData", DefaultValue=null, Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    public string FilterData { get { return default(string); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("filterType", DefaultValue=null, Options=(System.Configuration.ConfigurationPropertyOptions)(2))]
    public System.ServiceModel.Routing.Configuration.FilterType FilterType { get { return default(System.ServiceModel.Routing.Configuration.FilterType); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("name", DefaultValue=null, Options=(System.Configuration.ConfigurationPropertyOptions)(6))]
    public string Name { get { return default(string); } set { } }
  }
  [System.Configuration.ConfigurationCollectionAttribute(typeof(System.ServiceModel.Routing.Configuration.FilterElement), AddItemName="filter")]
  public partial class FilterElementCollection : System.Configuration.ConfigurationElementCollection {
    public FilterElementCollection() { }
    public System.ServiceModel.Routing.Configuration.FilterElement this[int index] { get { return default(System.ServiceModel.Routing.Configuration.FilterElement); } }
    public new System.ServiceModel.Routing.Configuration.FilterElement this[string name] { get { return default(System.ServiceModel.Routing.Configuration.FilterElement); } }
    public void Add(System.ServiceModel.Routing.Configuration.FilterElement element) { }
    public void Clear() { }
    protected override System.Configuration.ConfigurationElement CreateNewElement() { return default(System.Configuration.ConfigurationElement); }
    protected override object GetElementKey(System.Configuration.ConfigurationElement element) { return default(object); }
    public override bool IsReadOnly() { return default(bool); }
    public void Remove(System.ServiceModel.Routing.Configuration.FilterElement element) { }
  }
  [System.Configuration.ConfigurationCollectionAttribute(typeof(System.ServiceModel.Routing.Configuration.FilterTableEntryCollection), AddItemName="filterTable")]
  public partial class FilterTableCollection : System.Configuration.ConfigurationElementCollection {
    public FilterTableCollection() { }
    public new System.ServiceModel.Routing.Configuration.FilterTableEntryCollection this[string name] { get { return default(System.ServiceModel.Routing.Configuration.FilterTableEntryCollection); } }
    public void Add(System.ServiceModel.Routing.Configuration.FilterTableEntryCollection element) { }
    public void Clear() { }
    protected override System.Configuration.ConfigurationElement CreateNewElement() { return default(System.Configuration.ConfigurationElement); }
    protected override object GetElementKey(System.Configuration.ConfigurationElement element) { return default(object); }
    public void Remove(System.ServiceModel.Routing.Configuration.FilterTableEntryCollection element) { }
  }
  [System.Configuration.ConfigurationCollectionAttribute(typeof(System.ServiceModel.Routing.Configuration.FilterTableEntryElement))]
  public partial class FilterTableEntryCollection : System.Configuration.ConfigurationElementCollection {
    public FilterTableEntryCollection() { }
    [System.Configuration.ConfigurationPropertyAttribute("name", DefaultValue=null, Options=(System.Configuration.ConfigurationPropertyOptions)(6))]
    public string Name { get { return default(string); } set { } }
    public void Add(System.ServiceModel.Routing.Configuration.FilterTableEntryElement element) { }
    public void Clear() { }
    protected override System.Configuration.ConfigurationElement CreateNewElement() { return default(System.Configuration.ConfigurationElement); }
    protected override object GetElementKey(System.Configuration.ConfigurationElement element) { return default(object); }
    public void Remove(System.ServiceModel.Routing.Configuration.FilterTableEntryElement element) { }
  }
  public partial class FilterTableEntryElement : System.Configuration.ConfigurationElement {
    public FilterTableEntryElement() { }
    [System.Configuration.ConfigurationPropertyAttribute("backupList", DefaultValue=null, Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    public string BackupList { get { return default(string); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("endpointName", DefaultValue=null, Options=(System.Configuration.ConfigurationPropertyOptions)(6))]
    public string EndpointName { get { return default(string); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("filterName", DefaultValue=null, Options=(System.Configuration.ConfigurationPropertyOptions)(6))]
    public string FilterName { get { return default(string); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("priority", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    public int Priority { get { return default(int); } set { } }
  }
  public enum FilterType {
    Action = 0,
    And = 3,
    Custom = 4,
    EndpointAddress = 1,
    EndpointName = 5,
    MatchAll = 6,
    PrefixEndpointAddress = 2,
    XPath = 7,
  }
  public partial class NamespaceElement : System.Configuration.ConfigurationElement {
    public NamespaceElement() { }
    [System.Configuration.ConfigurationPropertyAttribute("namespace", DefaultValue=null, Options=(System.Configuration.ConfigurationPropertyOptions)(2))]
    public string Namespace { get { return default(string); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("prefix", DefaultValue=null, Options=(System.Configuration.ConfigurationPropertyOptions)(6))]
    public string Prefix { get { return default(string); } set { } }
  }
  [System.Configuration.ConfigurationCollectionAttribute(typeof(System.ServiceModel.Routing.Configuration.NamespaceElement))]
  public partial class NamespaceElementCollection : System.Configuration.ConfigurationElementCollection {
    public NamespaceElementCollection() { }
    public System.ServiceModel.Routing.Configuration.NamespaceElement this[int index] { get { return default(System.ServiceModel.Routing.Configuration.NamespaceElement); } }
    public new System.ServiceModel.Routing.Configuration.NamespaceElement this[string name] { get { return default(System.ServiceModel.Routing.Configuration.NamespaceElement); } }
    public void Add(System.ServiceModel.Routing.Configuration.NamespaceElement element) { }
    public void Clear() { }
    protected override System.Configuration.ConfigurationElement CreateNewElement() { return default(System.Configuration.ConfigurationElement); }
    protected override object GetElementKey(System.Configuration.ConfigurationElement element) { return default(object); }
    public override bool IsReadOnly() { return default(bool); }
    public void Remove(System.ServiceModel.Routing.Configuration.NamespaceElement element) { }
  }
  public sealed partial class RoutingExtensionElement : System.ServiceModel.Configuration.BehaviorExtensionElement {
    public RoutingExtensionElement() { }
    public override System.Type BehaviorType { get { return default(System.Type); } }
    [System.Configuration.ConfigurationPropertyAttribute("filterTableName", DefaultValue=null)]
    public string FilterTableName { get { return default(string); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("routeOnHeadersOnly", DefaultValue=true, Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    public bool RouteOnHeadersOnly { get { return default(bool); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("soapProcessingEnabled", DefaultValue=true)]
    public bool SoapProcessingEnabled { get { return default(bool); } set { } }
    protected internal override object CreateBehavior() { return default(object); }
  }
  public partial class RoutingSection : System.Configuration.ConfigurationSection {
    public RoutingSection() { }
    [System.Configuration.ConfigurationPropertyAttribute("backupLists", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    public System.ServiceModel.Routing.Configuration.BackupListCollection BackupLists { get { return default(System.ServiceModel.Routing.Configuration.BackupListCollection); } }
    [System.Configuration.ConfigurationPropertyAttribute("filters", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    public System.ServiceModel.Routing.Configuration.FilterElementCollection Filters { get { return default(System.ServiceModel.Routing.Configuration.FilterElementCollection); } }
    [System.Configuration.ConfigurationPropertyAttribute("filterTables", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    public System.ServiceModel.Routing.Configuration.FilterTableCollection FilterTables { get { return default(System.ServiceModel.Routing.Configuration.FilterTableCollection); } }
    [System.Configuration.ConfigurationPropertyAttribute("namespaceTable", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    public System.ServiceModel.Routing.Configuration.NamespaceElementCollection NamespaceTable { get { return default(System.ServiceModel.Routing.Configuration.NamespaceElementCollection); } }
    [System.MonoTODOAttribute]
    public static System.ServiceModel.Dispatcher.MessageFilterTable<System.Collections.Generic.IEnumerable<System.ServiceModel.Description.ServiceEndpoint>> CreateFilterTable(string name) { return default(System.ServiceModel.Dispatcher.MessageFilterTable<System.Collections.Generic.IEnumerable<System.ServiceModel.Description.ServiceEndpoint>>); }
  }
  public partial class SoapProcessingExtensionElement : System.ServiceModel.Configuration.BehaviorExtensionElement {
    public SoapProcessingExtensionElement() { }
    public override System.Type BehaviorType { get { return default(System.Type); } }
    [System.Configuration.ConfigurationPropertyAttribute("processMessages", DefaultValue=true, Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    public bool ProcessMessages { get { return default(bool); } set { } }
    protected internal override object CreateBehavior() { return default(object); }
  }
}
