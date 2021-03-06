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
    public void AttachHost(System.Data.Services.IDataServiceHost host) { }
    protected virtual T CreateDataSource() { return default(T); }
    protected virtual void HandleException(System.Data.Services.HandleExceptionArgs args) { }
    protected virtual void OnStartProcessingRequest(System.Data.Services.ProcessRequestArgs args) { }
    public void ProcessRequest() { }
    public System.ServiceModel.Channels.Message ProcessRequestForMessage(System.IO.Stream messageBody) { return default(System.ServiceModel.Channels.Message); }
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
