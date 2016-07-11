namespace System.Data.Services {
  [System.AttributeUsageAttribute((System.AttributeTargets)(64), AllowMultiple=true, Inherited=true)]
  public sealed partial class ChangeInterceptorAttribute : System.Attribute {
    public ChangeInterceptorAttribute(string entitySetName) { }
    public string EntitySetName { [System.Diagnostics.DebuggerStepThroughAttribute]get { return default(string); } }
  }
  [System.ServiceModel.Activation.AspNetCompatibilityRequirementsAttribute(RequirementsMode=(System.ServiceModel.Activation.AspNetCompatibilityRequirementsMode)(1))]
  [System.ServiceModel.ServiceBehaviorAttribute(InstanceContextMode=(System.ServiceModel.InstanceContextMode)(1))]
  public partial class DataService<T> : System.Data.Services.IRequestHandler {
    public DataService() { }
    protected T CurrentDataSource { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(T); } }
    public System.Data.Services.DataServiceProcessingPipeline ProcessingPipeline { get { return default(System.Data.Services.DataServiceProcessingPipeline); } }
    public void AttachHost(System.Data.Services.IDataServiceHost host) { }
    protected virtual T CreateDataSource() { return default(T); }
    protected virtual void HandleException(System.Data.Services.HandleExceptionArgs args) { }
    protected virtual void OnStartProcessingRequest(System.Data.Services.ProcessRequestArgs args) { }
    public void ProcessRequest() { }
    public System.ServiceModel.Channels.Message ProcessRequestForMessage(System.IO.Stream messageBody) { return default(System.ServiceModel.Channels.Message); }
  }
  public sealed partial class DataServiceBehavior {
    public DataServiceBehavior() { }
    public bool AcceptCountRequests { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public bool AcceptProjectionRequests { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public bool InvokeInterceptorsOnLinkDelete { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Data.Services.Common.DataServiceProtocolVersion MaxProtocolVersion { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Data.Services.Common.DataServiceProtocolVersion); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
  }
  public sealed partial class DataServiceConfiguration : System.Data.Services.IDataServiceConfiguration {
    public DataServiceConfiguration() { }
    public System.Data.Services.DataServiceBehavior DataServiceBehavior { get { return default(System.Data.Services.DataServiceBehavior); } }
    public bool EnableTypeConversion { get { return default(bool); } set { } }
    public int MaxBatchCount { get { return default(int); } set { } }
    public int MaxChangesetCount { get { return default(int); } set { } }
    public int MaxExpandCount { get { return default(int); } set { } }
    public int MaxExpandDepth { get { return default(int); } set { } }
    public int MaxObjectCountOnInsert { get { return default(int); } set { } }
    public int MaxResultsPerCollection { get { return default(int); } set { } }
    public bool UseVerboseErrors { get { return default(bool); } set { } }
    public void EnableTypeAccess(string typeName) { }
    public void RegisterKnownType(System.Type type) { }
    public void SetEntitySetAccessRule(string name, System.Data.Services.EntitySetRights rights) { }
    public void SetEntitySetPageSize(string name, int size) { }
    public void SetServiceOperationAccessRule(string name, System.Data.Services.ServiceOperationRights rights) { }
  }
  [System.Diagnostics.DebuggerDisplayAttribute("{statusCode}: {Message}")]
  public sealed partial class DataServiceException : System.InvalidOperationException {
    public DataServiceException() { }
    public DataServiceException(int statusCode, string message) { }
    public DataServiceException(int statusCode, string errorCode, string message, string messageXmlLang, System.Exception innerException) { }
    protected DataServiceException(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
    public DataServiceException(string message) { }
    public DataServiceException(string message, System.Exception innerException) { }
    public string ErrorCode { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
    public string MessageLanguage { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
    public int StatusCode { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(int); } }
    [System.Security.SecurityCriticalAttribute]
    public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
  }
  [System.CLSCompliantAttribute(false)]
  public partial class DataServiceHost : System.ServiceModel.Web.WebServiceHost {
    public DataServiceHost(System.Type serviceType, System.Uri[] baseAddresses) { }
  }
  public partial class DataServiceHostFactory : System.ServiceModel.Activation.ServiceHostFactory {
    public DataServiceHostFactory() { }
    protected override System.ServiceModel.ServiceHost CreateServiceHost(System.Type serviceType, System.Uri[] baseAddresses) { return default(System.ServiceModel.ServiceHost); }
  }
  public sealed partial class DataServiceOperationContext {
    public DataServiceOperationContext() { }
    public System.Uri AbsoluteRequestUri { get { return default(System.Uri); } }
    public System.Uri AbsoluteServiceUri { get { return default(System.Uri); } }
    public bool IsBatchRequest { get { return default(bool); } }
    public System.Net.WebHeaderCollection RequestHeaders { get { return default(System.Net.WebHeaderCollection); } }
    public string RequestMethod { get { return default(string); } }
    public System.Net.WebHeaderCollection ResponseHeaders { get { return default(System.Net.WebHeaderCollection); } }
    public int ResponseStatusCode { get { return default(int); } set { } }
  }
  public sealed partial class DataServiceProcessingPipeline {
    public DataServiceProcessingPipeline() { }
    public event System.EventHandler<System.EventArgs> ProcessedChangeset { add { } remove { } }
    public event System.EventHandler<System.Data.Services.DataServiceProcessingPipelineEventArgs> ProcessedRequest { add { } remove { } }
    public event System.EventHandler<System.EventArgs> ProcessingChangeset { add { } remove { } }
    public event System.EventHandler<System.Data.Services.DataServiceProcessingPipelineEventArgs> ProcessingRequest { add { } remove { } }
  }
  public sealed partial class DataServiceProcessingPipelineEventArgs : System.EventArgs {
    public DataServiceProcessingPipelineEventArgs() { }
    public System.Data.Services.DataServiceOperationContext OperationContext { get { return default(System.Data.Services.DataServiceOperationContext); } }
  }
  [System.FlagsAttribute]
  public enum EntitySetRights {
    All = 63,
    AllRead = 3,
    AllWrite = 60,
    None = 0,
    ReadMultiple = 2,
    ReadSingle = 1,
    WriteAppend = 4,
    WriteDelete = 16,
    WriteMerge = 32,
    WriteReplace = 8,
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(4), AllowMultiple=false, Inherited=true)]
  public sealed partial class ETagAttribute : System.Attribute {
    public ETagAttribute(string propertyName) { }
    public ETagAttribute(params System.String[] propertyNames) { }
    public System.Collections.ObjectModel.ReadOnlyCollection<System.String> PropertyNames { get { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.String>); } }
  }
  [System.Diagnostics.DebuggerDisplayAttribute("ExpandSegment ({name},Filter={filter})]")]
  public partial class ExpandSegment {
    public ExpandSegment(string name, System.Linq.Expressions.Expression filter) { }
    public System.Data.Services.Providers.ResourceProperty ExpandedProperty { get { return default(System.Data.Services.Providers.ResourceProperty); } }
    public System.Linq.Expressions.Expression Filter { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Linq.Expressions.Expression); } }
    public bool HasFilter { get { return default(bool); } }
    public int MaxResultsExpected { get { return default(int); } }
    public string Name { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
    public static bool PathHasFilter(System.Collections.Generic.IEnumerable<System.Data.Services.ExpandSegment> path) { return default(bool); }
  }
  public partial class ExpandSegmentCollection : System.Collections.Generic.List<System.Data.Services.ExpandSegment> {
    public ExpandSegmentCollection() { }
    public ExpandSegmentCollection(int capacity) { }
    public bool HasFilter { get { return default(bool); } }
  }
  public partial class HandleExceptionArgs {
    public HandleExceptionArgs() { }
    public System.Exception Exception { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Exception); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public string ResponseContentType { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
    public int ResponseStatusCode { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(int); } }
    public bool ResponseWritten { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } }
    public bool UseVerboseErrors { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
  }
  public partial interface IDataServiceConfiguration {
    int MaxBatchCount { get; set; }
    int MaxChangesetCount { get; set; }
    int MaxExpandCount { get; set; }
    int MaxExpandDepth { get; set; }
    int MaxObjectCountOnInsert { get; set; }
    int MaxResultsPerCollection { get; set; }
    bool UseVerboseErrors { get; set; }
    void RegisterKnownType(System.Type type);
    void SetEntitySetAccessRule(string name, System.Data.Services.EntitySetRights rights);
    void SetServiceOperationAccessRule(string name, System.Data.Services.ServiceOperationRights rights);
  }
  public partial interface IDataServiceHost {
    System.Uri AbsoluteRequestUri { get; }
    System.Uri AbsoluteServiceUri { get; }
    string RequestAccept { get; }
    string RequestAcceptCharSet { get; }
    string RequestContentType { get; }
    string RequestHttpMethod { get; }
    string RequestIfMatch { get; }
    string RequestIfNoneMatch { get; }
    string RequestMaxVersion { get; }
    System.IO.Stream RequestStream { get; }
    string RequestVersion { get; }
    string ResponseCacheControl { get; set; }
    string ResponseContentType { get; set; }
    string ResponseETag { get; set; }
    string ResponseLocation { get; set; }
    int ResponseStatusCode { get; set; }
    System.IO.Stream ResponseStream { get; }
    string ResponseVersion { get; set; }
    string GetQueryStringItem(string item);
    void ProcessException(System.Data.Services.HandleExceptionArgs args);
  }
  public partial interface IDataServiceHost2 : System.Data.Services.IDataServiceHost {
    System.Net.WebHeaderCollection RequestHeaders { get; }
    System.Net.WebHeaderCollection ResponseHeaders { get; }
  }
  public partial interface IExpandedResult {
    object ExpandedElement { get; }
    object GetExpandedPropertyValue(string name);
  }
  public partial interface IExpandProvider {
    System.Collections.IEnumerable ApplyExpansions(System.Linq.IQueryable queryable, System.Collections.Generic.ICollection<System.Data.Services.ExpandSegmentCollection> expandPaths);
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(4), AllowMultiple=false, Inherited=true)]
  public sealed partial class IgnorePropertiesAttribute : System.Attribute {
    public IgnorePropertiesAttribute(string propertyName) { }
    public IgnorePropertiesAttribute(params System.String[] propertyNames) { }
    public System.Collections.ObjectModel.ReadOnlyCollection<System.String> PropertyNames { get { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.String>); } }
  }
  [System.ServiceModel.ServiceContractAttribute]
  public partial interface IRequestHandler {
    [System.ServiceModel.OperationContractAttribute]
    [System.ServiceModel.Web.WebInvokeAttribute(UriTemplate="*", Method="*")]
    System.ServiceModel.Channels.Message ProcessRequestForMessage(System.IO.Stream messageBody);
  }
  public partial interface IUpdatable {
    void AddReferenceToCollection(object targetResource, string propertyName, object resourceToBeAdded);
    void ClearChanges();
    object CreateResource(string containerName, string fullTypeName);
    void DeleteResource(object targetResource);
    object GetResource(System.Linq.IQueryable query, string fullTypeName);
    object GetValue(object targetResource, string propertyName);
    void RemoveReferenceFromCollection(object targetResource, string propertyName, object resourceToBeRemoved);
    object ResetResource(object resource);
    object ResolveResource(object resource);
    void SaveChanges();
    void SetReference(object targetResource, string propertyName, object propertyValue);
    void SetValue(object targetResource, string propertyName, object propertyValue);
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(4), AllowMultiple=false, Inherited=true)]
  public sealed partial class MimeTypeAttribute : System.Attribute {
    public MimeTypeAttribute(string memberName, string mimeType) { }
    public string MemberName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
    public string MimeType { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
  }
  public sealed partial class ProcessRequestArgs {
    public ProcessRequestArgs() { }
    public bool IsBatchOperation { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } }
    public System.Data.Services.DataServiceOperationContext OperationContext { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Data.Services.DataServiceOperationContext); } }
    public System.Uri RequestUri { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Uri); } }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(64), AllowMultiple=true, Inherited=true)]
  public sealed partial class QueryInterceptorAttribute : System.Attribute {
    public QueryInterceptorAttribute(string entitySetName) { }
    public string EntitySetName { [System.Diagnostics.DebuggerStepThroughAttribute]get { return default(string); } }
  }
  [System.FlagsAttribute]
  public enum ServiceOperationRights {
    All = 3,
    AllRead = 3,
    None = 0,
    OverrideEntitySetRights = 4,
    ReadMultiple = 2,
    ReadSingle = 1,
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(64), AllowMultiple=false, Inherited=true)]
  public sealed partial class SingleResultAttribute : System.Attribute {
    public SingleResultAttribute() { }
  }
  [System.FlagsAttribute]
  public enum UpdateOperations {
    Add = 1,
    Change = 2,
    Delete = 4,
    None = 0,
  }
}
namespace System.Data.Services.Internal {
  [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
  public abstract partial class ExpandedWrapper<TExpandedElement> : System.Data.Services.IExpandedResult {
    protected ExpandedWrapper() { }
    public string Description { get { return default(string); } set { } }
    public TExpandedElement ExpandedElement { get { return default(TExpandedElement); } set { } }
    object System.Data.Services.IExpandedResult.ExpandedElement { get { return default(object); } }
    public object GetExpandedPropertyValue(string name) { return default(object); }
    protected abstract object InternalGetExpandedPropertyValue(int nameIndex);
  }
  [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
  public sealed partial class ExpandedWrapper<TExpandedElement, TProperty0, TProperty1, TProperty2, TProperty3, TProperty4, TProperty5, TProperty6, TProperty7, TProperty8> : System.Data.Services.Internal.ExpandedWrapper<TExpandedElement> {
    public ExpandedWrapper() { }
    public TProperty0 ProjectedProperty0 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(TProperty0); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public TProperty1 ProjectedProperty1 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(TProperty1); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public TProperty2 ProjectedProperty2 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(TProperty2); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public TProperty3 ProjectedProperty3 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(TProperty3); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public TProperty4 ProjectedProperty4 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(TProperty4); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public TProperty5 ProjectedProperty5 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(TProperty5); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public TProperty6 ProjectedProperty6 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(TProperty6); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public TProperty7 ProjectedProperty7 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(TProperty7); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public TProperty8 ProjectedProperty8 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(TProperty8); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    protected override object InternalGetExpandedPropertyValue(int nameIndex) { return default(object); }
  }
  [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
  public sealed partial class ExpandedWrapper<TExpandedElement, TProperty0, TProperty1, TProperty2, TProperty3, TProperty4, TProperty5, TProperty6, TProperty7, TProperty8, TProperty9> : System.Data.Services.Internal.ExpandedWrapper<TExpandedElement> {
    public ExpandedWrapper() { }
    public TProperty0 ProjectedProperty0 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(TProperty0); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public TProperty1 ProjectedProperty1 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(TProperty1); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public TProperty2 ProjectedProperty2 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(TProperty2); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public TProperty3 ProjectedProperty3 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(TProperty3); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public TProperty4 ProjectedProperty4 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(TProperty4); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public TProperty5 ProjectedProperty5 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(TProperty5); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public TProperty6 ProjectedProperty6 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(TProperty6); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public TProperty7 ProjectedProperty7 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(TProperty7); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public TProperty8 ProjectedProperty8 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(TProperty8); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public TProperty9 ProjectedProperty9 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(TProperty9); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    protected override object InternalGetExpandedPropertyValue(int nameIndex) { return default(object); }
  }
  [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
  public sealed partial class ExpandedWrapper<TExpandedElement, TProperty0, TProperty1, TProperty2, TProperty3, TProperty4, TProperty5, TProperty6, TProperty7, TProperty8, TProperty9, TProperty10> : System.Data.Services.Internal.ExpandedWrapper<TExpandedElement> {
    public ExpandedWrapper() { }
    public TProperty0 ProjectedProperty0 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(TProperty0); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public TProperty1 ProjectedProperty1 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(TProperty1); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public TProperty10 ProjectedProperty10 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(TProperty10); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public TProperty2 ProjectedProperty2 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(TProperty2); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public TProperty3 ProjectedProperty3 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(TProperty3); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public TProperty4 ProjectedProperty4 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(TProperty4); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public TProperty5 ProjectedProperty5 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(TProperty5); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public TProperty6 ProjectedProperty6 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(TProperty6); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public TProperty7 ProjectedProperty7 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(TProperty7); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public TProperty8 ProjectedProperty8 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(TProperty8); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public TProperty9 ProjectedProperty9 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(TProperty9); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    protected override object InternalGetExpandedPropertyValue(int nameIndex) { return default(object); }
  }
  [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
  public sealed partial class ExpandedWrapper<TExpandedElement, TProperty0, TProperty1, TProperty2, TProperty3, TProperty4, TProperty5, TProperty6, TProperty7, TProperty8, TProperty9, TProperty10, TProperty11> : System.Data.Services.Internal.ExpandedWrapper<TExpandedElement> {
    public ExpandedWrapper() { }
    public TProperty0 ProjectedProperty0 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(TProperty0); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public TProperty1 ProjectedProperty1 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(TProperty1); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public TProperty10 ProjectedProperty10 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(TProperty10); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public TProperty11 ProjectedProperty11 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(TProperty11); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public TProperty2 ProjectedProperty2 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(TProperty2); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public TProperty3 ProjectedProperty3 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(TProperty3); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public TProperty4 ProjectedProperty4 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(TProperty4); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public TProperty5 ProjectedProperty5 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(TProperty5); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public TProperty6 ProjectedProperty6 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(TProperty6); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public TProperty7 ProjectedProperty7 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(TProperty7); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public TProperty8 ProjectedProperty8 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(TProperty8); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public TProperty9 ProjectedProperty9 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(TProperty9); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    protected override object InternalGetExpandedPropertyValue(int nameIndex) { return default(object); }
  }
  [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
  public sealed partial class ExpandedWrapper<TExpandedElement, TProperty0> : System.Data.Services.Internal.ExpandedWrapper<TExpandedElement> {
    public ExpandedWrapper() { }
    public TProperty0 ProjectedProperty0 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(TProperty0); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    protected override object InternalGetExpandedPropertyValue(int nameIndex) { return default(object); }
  }
  [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
  public sealed partial class ExpandedWrapper<TExpandedElement, TProperty0, TProperty1> : System.Data.Services.Internal.ExpandedWrapper<TExpandedElement> {
    public ExpandedWrapper() { }
    public TProperty0 ProjectedProperty0 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(TProperty0); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public TProperty1 ProjectedProperty1 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(TProperty1); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    protected override object InternalGetExpandedPropertyValue(int nameIndex) { return default(object); }
  }
  [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
  public sealed partial class ExpandedWrapper<TExpandedElement, TProperty0, TProperty1, TProperty2> : System.Data.Services.Internal.ExpandedWrapper<TExpandedElement> {
    public ExpandedWrapper() { }
    public TProperty0 ProjectedProperty0 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(TProperty0); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public TProperty1 ProjectedProperty1 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(TProperty1); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public TProperty2 ProjectedProperty2 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(TProperty2); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    protected override object InternalGetExpandedPropertyValue(int nameIndex) { return default(object); }
  }
  [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
  public sealed partial class ExpandedWrapper<TExpandedElement, TProperty0, TProperty1, TProperty2, TProperty3> : System.Data.Services.Internal.ExpandedWrapper<TExpandedElement> {
    public ExpandedWrapper() { }
    public TProperty0 ProjectedProperty0 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(TProperty0); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public TProperty1 ProjectedProperty1 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(TProperty1); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public TProperty2 ProjectedProperty2 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(TProperty2); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public TProperty3 ProjectedProperty3 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(TProperty3); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    protected override object InternalGetExpandedPropertyValue(int nameIndex) { return default(object); }
  }
  [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
  public sealed partial class ExpandedWrapper<TExpandedElement, TProperty0, TProperty1, TProperty2, TProperty3, TProperty4> : System.Data.Services.Internal.ExpandedWrapper<TExpandedElement> {
    public ExpandedWrapper() { }
    public TProperty0 ProjectedProperty0 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(TProperty0); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public TProperty1 ProjectedProperty1 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(TProperty1); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public TProperty2 ProjectedProperty2 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(TProperty2); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public TProperty3 ProjectedProperty3 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(TProperty3); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public TProperty4 ProjectedProperty4 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(TProperty4); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    protected override object InternalGetExpandedPropertyValue(int nameIndex) { return default(object); }
  }
  [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
  public sealed partial class ExpandedWrapper<TExpandedElement, TProperty0, TProperty1, TProperty2, TProperty3, TProperty4, TProperty5> : System.Data.Services.Internal.ExpandedWrapper<TExpandedElement> {
    public ExpandedWrapper() { }
    public TProperty0 ProjectedProperty0 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(TProperty0); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public TProperty1 ProjectedProperty1 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(TProperty1); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public TProperty2 ProjectedProperty2 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(TProperty2); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public TProperty3 ProjectedProperty3 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(TProperty3); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public TProperty4 ProjectedProperty4 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(TProperty4); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public TProperty5 ProjectedProperty5 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(TProperty5); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    protected override object InternalGetExpandedPropertyValue(int nameIndex) { return default(object); }
  }
  [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
  public sealed partial class ExpandedWrapper<TExpandedElement, TProperty0, TProperty1, TProperty2, TProperty3, TProperty4, TProperty5, TProperty6> : System.Data.Services.Internal.ExpandedWrapper<TExpandedElement> {
    public ExpandedWrapper() { }
    public TProperty0 ProjectedProperty0 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(TProperty0); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public TProperty1 ProjectedProperty1 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(TProperty1); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public TProperty2 ProjectedProperty2 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(TProperty2); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public TProperty3 ProjectedProperty3 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(TProperty3); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public TProperty4 ProjectedProperty4 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(TProperty4); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public TProperty5 ProjectedProperty5 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(TProperty5); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public TProperty6 ProjectedProperty6 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(TProperty6); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    protected override object InternalGetExpandedPropertyValue(int nameIndex) { return default(object); }
  }
  [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
  public sealed partial class ExpandedWrapper<TExpandedElement, TProperty0, TProperty1, TProperty2, TProperty3, TProperty4, TProperty5, TProperty6, TProperty7> : System.Data.Services.Internal.ExpandedWrapper<TExpandedElement> {
    public ExpandedWrapper() { }
    public TProperty0 ProjectedProperty0 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(TProperty0); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public TProperty1 ProjectedProperty1 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(TProperty1); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public TProperty2 ProjectedProperty2 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(TProperty2); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public TProperty3 ProjectedProperty3 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(TProperty3); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public TProperty4 ProjectedProperty4 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(TProperty4); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public TProperty5 ProjectedProperty5 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(TProperty5); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public TProperty6 ProjectedProperty6 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(TProperty6); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public TProperty7 ProjectedProperty7 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(TProperty7); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    protected override object InternalGetExpandedPropertyValue(int nameIndex) { return default(object); }
  }
  [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
  public abstract partial class ProjectedWrapper {
    protected ProjectedWrapper() { }
    public string PropertyNameList { get { return default(string); } set { } }
    public string ResourceTypeName { get { return default(string); } set { } }
    public object GetProjectedPropertyValue(string propertyName) { return default(object); }
    protected abstract object InternalGetProjectedPropertyValue(int propertyIndex);
  }
  [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
  public sealed partial class ProjectedWrapper0 : System.Data.Services.Internal.ProjectedWrapper {
    [System.Runtime.TargetedPatchingOptOutAttribute("Performance critical to inline this type of method across NGen image boundaries")]
    public ProjectedWrapper0() { }
    protected override object InternalGetProjectedPropertyValue(int propertyIndex) { return default(object); }
  }
  [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
  public sealed partial class ProjectedWrapper1 : System.Data.Services.Internal.ProjectedWrapper {
    public ProjectedWrapper1() { }
    public object ProjectedProperty0 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(object); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    protected override object InternalGetProjectedPropertyValue(int propertyIndex) { return default(object); }
  }
  [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
  public sealed partial class ProjectedWrapper2 : System.Data.Services.Internal.ProjectedWrapper {
    public ProjectedWrapper2() { }
    public object ProjectedProperty0 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(object); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public object ProjectedProperty1 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(object); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    protected override object InternalGetProjectedPropertyValue(int propertyIndex) { return default(object); }
  }
  [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
  public sealed partial class ProjectedWrapper3 : System.Data.Services.Internal.ProjectedWrapper {
    public ProjectedWrapper3() { }
    public object ProjectedProperty0 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(object); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public object ProjectedProperty1 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(object); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public object ProjectedProperty2 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(object); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    protected override object InternalGetProjectedPropertyValue(int propertyIndex) { return default(object); }
  }
  [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
  public sealed partial class ProjectedWrapper4 : System.Data.Services.Internal.ProjectedWrapper {
    public ProjectedWrapper4() { }
    public object ProjectedProperty0 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(object); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public object ProjectedProperty1 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(object); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public object ProjectedProperty2 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(object); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public object ProjectedProperty3 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(object); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    protected override object InternalGetProjectedPropertyValue(int propertyIndex) { return default(object); }
  }
  [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
  public sealed partial class ProjectedWrapper5 : System.Data.Services.Internal.ProjectedWrapper {
    public ProjectedWrapper5() { }
    public object ProjectedProperty0 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(object); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public object ProjectedProperty1 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(object); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public object ProjectedProperty2 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(object); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public object ProjectedProperty3 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(object); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public object ProjectedProperty4 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(object); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    protected override object InternalGetProjectedPropertyValue(int propertyIndex) { return default(object); }
  }
  [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
  public sealed partial class ProjectedWrapper6 : System.Data.Services.Internal.ProjectedWrapper {
    public ProjectedWrapper6() { }
    public object ProjectedProperty0 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(object); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public object ProjectedProperty1 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(object); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public object ProjectedProperty2 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(object); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public object ProjectedProperty3 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(object); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public object ProjectedProperty4 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(object); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public object ProjectedProperty5 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(object); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    protected override object InternalGetProjectedPropertyValue(int propertyIndex) { return default(object); }
  }
  [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
  public sealed partial class ProjectedWrapper7 : System.Data.Services.Internal.ProjectedWrapper {
    public ProjectedWrapper7() { }
    public object ProjectedProperty0 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(object); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public object ProjectedProperty1 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(object); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public object ProjectedProperty2 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(object); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public object ProjectedProperty3 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(object); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public object ProjectedProperty4 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(object); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public object ProjectedProperty5 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(object); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public object ProjectedProperty6 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(object); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    protected override object InternalGetProjectedPropertyValue(int propertyIndex) { return default(object); }
  }
  [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
  public sealed partial class ProjectedWrapper8 : System.Data.Services.Internal.ProjectedWrapper {
    public ProjectedWrapper8() { }
    public object ProjectedProperty0 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(object); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public object ProjectedProperty1 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(object); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public object ProjectedProperty2 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(object); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public object ProjectedProperty3 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(object); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public object ProjectedProperty4 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(object); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public object ProjectedProperty5 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(object); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public object ProjectedProperty6 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(object); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public object ProjectedProperty7 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(object); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    protected override object InternalGetProjectedPropertyValue(int propertyIndex) { return default(object); }
  }
  [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
  public partial class ProjectedWrapperMany : System.Data.Services.Internal.ProjectedWrapper {
    public ProjectedWrapperMany() { }
    public System.Data.Services.Internal.ProjectedWrapperMany Next { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Data.Services.Internal.ProjectedWrapperMany); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public object ProjectedProperty0 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(object); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public object ProjectedProperty1 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(object); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public object ProjectedProperty2 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(object); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public object ProjectedProperty3 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(object); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public object ProjectedProperty4 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(object); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public object ProjectedProperty5 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(object); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public object ProjectedProperty6 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(object); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public object ProjectedProperty7 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(object); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    protected override object InternalGetProjectedPropertyValue(int propertyIndex) { return default(object); }
  }
  [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
  public sealed partial class ProjectedWrapperManyEnd : System.Data.Services.Internal.ProjectedWrapperMany {
    public ProjectedWrapperManyEnd() { }
    protected override object InternalGetProjectedPropertyValue(int propertyIndex) { return default(object); }
  }
}
namespace System.Data.Services.Providers {
  public static partial class DataServiceProviderMethods {
    public static int Compare(bool left, bool right) { return default(int); }
    public static int Compare(System.Guid left, System.Guid right) { return default(int); }
    public static int Compare(System.Nullable<System.Boolean> left, System.Nullable<System.Boolean> right) { return default(int); }
    public static int Compare(System.Nullable<System.Guid> left, System.Nullable<System.Guid> right) { return default(int); }
    public static int Compare(string left, string right) { return default(int); }
    public static object Convert(object value, System.Data.Services.Providers.ResourceType type) { return default(object); }
    public static System.Collections.Generic.IEnumerable<T> GetSequenceValue<T>(object value, System.Data.Services.Providers.ResourceProperty property) { return default(System.Collections.Generic.IEnumerable<T>); }
    public static object GetValue(object value, System.Data.Services.Providers.ResourceProperty property) { return default(object); }
    public static bool TypeIs(object value, System.Data.Services.Providers.ResourceType type) { return default(bool); }
  }
  public partial interface IDataServiceMetadataProvider {
    string ContainerName { get; }
    string ContainerNamespace { get; }
    System.Collections.Generic.IEnumerable<System.Data.Services.Providers.ResourceSet> ResourceSets { get; }
    System.Collections.Generic.IEnumerable<System.Data.Services.Providers.ServiceOperation> ServiceOperations { get; }
    System.Collections.Generic.IEnumerable<System.Data.Services.Providers.ResourceType> Types { get; }
    System.Collections.Generic.IEnumerable<System.Data.Services.Providers.ResourceType> GetDerivedTypes(System.Data.Services.Providers.ResourceType resourceType);
    System.Data.Services.Providers.ResourceAssociationSet GetResourceAssociationSet(System.Data.Services.Providers.ResourceSet resourceSet, System.Data.Services.Providers.ResourceType resourceType, System.Data.Services.Providers.ResourceProperty resourceProperty);
    bool HasDerivedTypes(System.Data.Services.Providers.ResourceType resourceType);
    bool TryResolveResourceSet(string name, out System.Data.Services.Providers.ResourceSet resourceSet);
    bool TryResolveResourceType(string name, out System.Data.Services.Providers.ResourceType resourceType);
    bool TryResolveServiceOperation(string name, out System.Data.Services.Providers.ServiceOperation serviceOperation);
  }
  public partial interface IDataServicePagingProvider {
    System.Object[] GetContinuationToken(System.Collections.IEnumerator enumerator);
    void SetContinuationToken(System.Linq.IQueryable query, System.Data.Services.Providers.ResourceType resourceType, System.Object[] continuationToken);
  }
  public partial interface IDataServiceQueryProvider {
    object CurrentDataSource { get; set; }
    bool IsNullPropagationRequired { get; }
    object GetOpenPropertyValue(object target, string propertyName);
    System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>> GetOpenPropertyValues(object target);
    object GetPropertyValue(object target, System.Data.Services.Providers.ResourceProperty resourceProperty);
    System.Linq.IQueryable GetQueryRootForResourceSet(System.Data.Services.Providers.ResourceSet resourceSet);
    System.Data.Services.Providers.ResourceType GetResourceType(object target);
    object InvokeServiceOperation(System.Data.Services.Providers.ServiceOperation serviceOperation, System.Object[] parameters);
  }
  public partial interface IDataServiceStreamProvider {
    int StreamBufferSize { get; }
    void DeleteStream(object entity, System.Data.Services.DataServiceOperationContext operationContext);
    System.IO.Stream GetReadStream(object entity, string etag, System.Nullable<System.Boolean> checkETagForEquality, System.Data.Services.DataServiceOperationContext operationContext);
    System.Uri GetReadStreamUri(object entity, System.Data.Services.DataServiceOperationContext operationContext);
    string GetStreamContentType(object entity, System.Data.Services.DataServiceOperationContext operationContext);
    string GetStreamETag(object entity, System.Data.Services.DataServiceOperationContext operationContext);
    System.IO.Stream GetWriteStream(object entity, string etag, System.Nullable<System.Boolean> checkETagForEquality, System.Data.Services.DataServiceOperationContext operationContext);
    string ResolveType(string entitySetName, System.Data.Services.DataServiceOperationContext operationContext);
  }
  public partial interface IDataServiceUpdateProvider : System.Data.Services.IUpdatable {
    void SetConcurrencyValues(object resourceCookie, System.Nullable<System.Boolean> checkForEquality, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>> concurrencyValues);
  }
  public static partial class OpenTypeMethods {
    public static object Add(object left, object right) { return default(object); }
    public static object AndAlso(object left, object right) { return default(object); }
    public static object Ceiling(object value) { return default(object); }
    public static object Concat(object first, object second) { return default(object); }
    public static object Convert(object value, System.Data.Services.Providers.ResourceType type) { return default(object); }
    public static object Day(object dateTime) { return default(object); }
    public static object Divide(object left, object right) { return default(object); }
    public static object EndsWith(object targetString, object substring) { return default(object); }
    public static object Equal(object left, object right) { return default(object); }
    public static object Floor(object value) { return default(object); }
    public static object GetValue(object value, string propertyName) { return default(object); }
    public static object GreaterThan(object left, object right) { return default(object); }
    public static object GreaterThanOrEqual(object left, object right) { return default(object); }
    public static object Hour(object dateTime) { return default(object); }
    public static object IndexOf(object targetString, object substring) { return default(object); }
    public static object Length(object value) { return default(object); }
    public static object LessThan(object left, object right) { return default(object); }
    public static object LessThanOrEqual(object left, object right) { return default(object); }
    public static object Minute(object dateTime) { return default(object); }
    public static object Modulo(object left, object right) { return default(object); }
    public static object Month(object dateTime) { return default(object); }
    public static object Multiply(object left, object right) { return default(object); }
    public static object Negate(object value) { return default(object); }
    public static object Not(object value) { return default(object); }
    public static object NotEqual(object left, object right) { return default(object); }
    public static object OrElse(object left, object right) { return default(object); }
    public static object Replace(object targetString, object substring, object newString) { return default(object); }
    public static object Round(object value) { return default(object); }
    public static object Second(object dateTime) { return default(object); }
    public static object StartsWith(object targetString, object substring) { return default(object); }
    public static object Substring(object targetString, object startIndex) { return default(object); }
    public static object Substring(object targetString, object startIndex, object length) { return default(object); }
    public static object SubstringOf(object substring, object targetString) { return default(object); }
    public static object Subtract(object left, object right) { return default(object); }
    public static object ToLower(object targetString) { return default(object); }
    public static object ToUpper(object targetString) { return default(object); }
    public static object Trim(object targetString) { return default(object); }
    public static object TypeIs(object value, System.Data.Services.Providers.ResourceType type) { return default(object); }
    public static object Year(object dateTime) { return default(object); }
  }
  [System.Diagnostics.DebuggerDisplayAttribute("ResourceAssociationSet: ({End1.ResourceSet.Name}, {End1.ResourceType.Name}, {End1.ResourceProperty.Name}) <-> ({End2.ResourceSet.Name}, {End2.ResourceType.Name}, {End2.ResourceProperty.Name})")]
  public sealed partial class ResourceAssociationSet {
    public ResourceAssociationSet(string name, System.Data.Services.Providers.ResourceAssociationSetEnd end1, System.Data.Services.Providers.ResourceAssociationSetEnd end2) { }
    public System.Data.Services.Providers.ResourceAssociationSetEnd End1 { get { return default(System.Data.Services.Providers.ResourceAssociationSetEnd); } }
    public System.Data.Services.Providers.ResourceAssociationSetEnd End2 { get { return default(System.Data.Services.Providers.ResourceAssociationSetEnd); } }
    public string Name { get { return default(string); } }
  }
  [System.Diagnostics.DebuggerDisplayAttribute("ResourceAssociationSetEnd: {Name}: ({ResourceSet.Name}, {ResourceType.Name}, {ResourceProperty.Name})")]
  public sealed partial class ResourceAssociationSetEnd {
    public ResourceAssociationSetEnd(System.Data.Services.Providers.ResourceSet resourceSet, System.Data.Services.Providers.ResourceType resourceType, System.Data.Services.Providers.ResourceProperty resourceProperty) { }
    public System.Data.Services.Providers.ResourceProperty ResourceProperty { get { return default(System.Data.Services.Providers.ResourceProperty); } }
    public System.Data.Services.Providers.ResourceSet ResourceSet { get { return default(System.Data.Services.Providers.ResourceSet); } }
    public System.Data.Services.Providers.ResourceType ResourceType { get { return default(System.Data.Services.Providers.ResourceType); } }
  }
  [System.Diagnostics.DebuggerDisplayAttribute("{kind}: {name}")]
  public partial class ResourceProperty {
    public ResourceProperty(string name, System.Data.Services.Providers.ResourcePropertyKind kind, System.Data.Services.Providers.ResourceType propertyResourceType) { }
    public bool CanReflectOnInstanceTypeProperty { get { return default(bool); } set { } }
    public object CustomState { get { return default(object); } set { } }
    public bool IsReadOnly { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } }
    public System.Data.Services.Providers.ResourcePropertyKind Kind { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Data.Services.Providers.ResourcePropertyKind); } }
    public string MimeType { get { return default(string); } set { } }
    public string Name { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
    public System.Data.Services.Providers.ResourceType ResourceType { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Data.Services.Providers.ResourceType); } }
    public void SetReadOnly() { }
  }
  [System.FlagsAttribute]
  public enum ResourcePropertyKind {
    ComplexType = 4,
    ETag = 32,
    Key = 2,
    Primitive = 1,
    ResourceReference = 8,
    ResourceSetReference = 16,
  }
  [System.Diagnostics.DebuggerDisplayAttribute("{Name}: {ResourceType}")]
  public partial class ResourceSet {
    public ResourceSet(string name, System.Data.Services.Providers.ResourceType elementType) { }
    public object CustomState { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(object); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public bool IsReadOnly { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } }
    public string Name { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
    public System.Data.Services.Providers.ResourceType ResourceType { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Data.Services.Providers.ResourceType); } }
    public void SetReadOnly() { }
  }
  [System.Diagnostics.DebuggerDisplayAttribute("{Name}: {InstanceType}, {ResourceTypeKind}")]
  public partial class ResourceType {
    public ResourceType(System.Type instanceType, System.Data.Services.Providers.ResourceTypeKind resourceTypeKind, System.Data.Services.Providers.ResourceType baseType, string namespaceName, string name, bool isAbstract) { }
    public System.Data.Services.Providers.ResourceType BaseType { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Data.Services.Providers.ResourceType); } }
    public bool CanReflectOnInstanceType { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public object CustomState { get { return default(object); } set { } }
    public System.Collections.ObjectModel.ReadOnlyCollection<System.Data.Services.Providers.ResourceProperty> ETagProperties { get { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.Data.Services.Providers.ResourceProperty>); } }
    public string FullName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
    public System.Type InstanceType { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Type); } }
    public bool IsAbstract { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } }
    public bool IsMediaLinkEntry { get { return default(bool); } set { } }
    public bool IsOpenType { get { return default(bool); } set { } }
    public bool IsReadOnly { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } }
    public System.Collections.ObjectModel.ReadOnlyCollection<System.Data.Services.Providers.ResourceProperty> KeyProperties { get { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.Data.Services.Providers.ResourceProperty>); } }
    public string Name { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
    public string Namespace { get { return default(string); } }
    public System.Collections.ObjectModel.ReadOnlyCollection<System.Data.Services.Providers.ResourceProperty> Properties { get { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.Data.Services.Providers.ResourceProperty>); } }
    public System.Collections.ObjectModel.ReadOnlyCollection<System.Data.Services.Providers.ResourceProperty> PropertiesDeclaredOnThisType { get { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.Data.Services.Providers.ResourceProperty>); } }
    public System.Data.Services.Providers.ResourceTypeKind ResourceTypeKind { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Data.Services.Providers.ResourceTypeKind); } }
    public void AddEntityPropertyMappingAttribute(System.Data.Services.Common.EntityPropertyMappingAttribute attribute) { }
    public void AddProperty(System.Data.Services.Providers.ResourceProperty property) { }
    public static System.Data.Services.Providers.ResourceType GetPrimitiveResourceType(System.Type type) { return default(System.Data.Services.Providers.ResourceType); }
    protected virtual System.Collections.Generic.IEnumerable<System.Data.Services.Providers.ResourceProperty> LoadPropertiesDeclaredOnThisType() { return default(System.Collections.Generic.IEnumerable<System.Data.Services.Providers.ResourceProperty>); }
    public void SetReadOnly() { }
  }
  public enum ResourceTypeKind {
    ComplexType = 1,
    EntityType = 0,
    Primitive = 2,
  }
  [System.Diagnostics.DebuggerVisualizerAttribute("ServiceOperation={Name}")]
  public partial class ServiceOperation {
    public ServiceOperation(string name, System.Data.Services.Providers.ServiceOperationResultKind resultKind, System.Data.Services.Providers.ResourceType resultType, System.Data.Services.Providers.ResourceSet resultSet, string method, System.Collections.Generic.IEnumerable<System.Data.Services.Providers.ServiceOperationParameter> parameters) { }
    public object CustomState { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(object); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public bool IsReadOnly { get { return default(bool); } }
    public string Method { get { return default(string); } }
    public string MimeType { get { return default(string); } set { } }
    public string Name { get { return default(string); } }
    public System.Collections.ObjectModel.ReadOnlyCollection<System.Data.Services.Providers.ServiceOperationParameter> Parameters { get { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.Data.Services.Providers.ServiceOperationParameter>); } }
    public System.Data.Services.Providers.ResourceSet ResourceSet { get { return default(System.Data.Services.Providers.ResourceSet); } }
    public System.Data.Services.Providers.ServiceOperationResultKind ResultKind { get { return default(System.Data.Services.Providers.ServiceOperationResultKind); } }
    public System.Data.Services.Providers.ResourceType ResultType { get { return default(System.Data.Services.Providers.ResourceType); } }
    public void SetReadOnly() { }
  }
  [System.Diagnostics.DebuggerVisualizerAttribute("ServiceOperationParameter={Name}")]
  public partial class ServiceOperationParameter {
    public ServiceOperationParameter(string name, System.Data.Services.Providers.ResourceType parameterType) { }
    public object CustomState { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(object); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public bool IsReadOnly { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } }
    public string Name { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
    public System.Data.Services.Providers.ResourceType ParameterType { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Data.Services.Providers.ResourceType); } }
    public void SetReadOnly() { }
  }
  public enum ServiceOperationResultKind {
    DirectValue = 0,
    Enumeration = 1,
    QueryWithMultipleResults = 2,
    QueryWithSingleResult = 3,
    Void = 4,
  }
}
