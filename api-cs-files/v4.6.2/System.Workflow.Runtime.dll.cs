namespace System.Activities.Statements {
  [System.ObsoleteAttribute("The WF3 Types are deprecated. Instead, please use the new WF4 Types from System.Activities.*")]
  public sealed partial class Interop : System.Activities.NativeActivity, System.ComponentModel.ICustomTypeDescriptor {
    public Interop() { }
    [System.ComponentModel.BrowsableAttribute(false)]
    public System.Collections.Generic.IDictionary<System.String, System.Object> ActivityMetaProperties { get { return default(System.Collections.Generic.IDictionary<System.String, System.Object>); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    public System.Collections.Generic.IDictionary<System.String, System.Activities.Argument> ActivityProperties { get { return default(System.Collections.Generic.IDictionary<System.String, System.Activities.Argument>); } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Type ActivityType { get { return default(System.Type); } set { } }
    protected override bool CanInduceIdle { get { return default(bool); } }
    protected override void CacheMetadata(System.Activities.NativeActivityMetadata metadata) { }
    protected override void Cancel(System.Activities.NativeActivityContext context) { }
    protected override void Execute(System.Activities.NativeActivityContext context) { }
    System.ComponentModel.AttributeCollection System.ComponentModel.ICustomTypeDescriptor.GetAttributes() { return default(System.ComponentModel.AttributeCollection); }
    string System.ComponentModel.ICustomTypeDescriptor.GetClassName() { return default(string); }
    string System.ComponentModel.ICustomTypeDescriptor.GetComponentName() { return default(string); }
    System.ComponentModel.TypeConverter System.ComponentModel.ICustomTypeDescriptor.GetConverter() { return default(System.ComponentModel.TypeConverter); }
    System.ComponentModel.EventDescriptor System.ComponentModel.ICustomTypeDescriptor.GetDefaultEvent() { return default(System.ComponentModel.EventDescriptor); }
    System.ComponentModel.PropertyDescriptor System.ComponentModel.ICustomTypeDescriptor.GetDefaultProperty() { return default(System.ComponentModel.PropertyDescriptor); }
    object System.ComponentModel.ICustomTypeDescriptor.GetEditor(System.Type editorBaseType) { return default(object); }
    System.ComponentModel.EventDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetEvents() { return default(System.ComponentModel.EventDescriptorCollection); }
    System.ComponentModel.EventDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetEvents(System.Attribute[] attributes) { return default(System.ComponentModel.EventDescriptorCollection); }
    System.ComponentModel.PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties() { return default(System.ComponentModel.PropertyDescriptorCollection); }
    System.ComponentModel.PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties(System.Attribute[] attributes) { return default(System.ComponentModel.PropertyDescriptorCollection); }
    object System.ComponentModel.ICustomTypeDescriptor.GetPropertyOwner(System.ComponentModel.PropertyDescriptor pd) { return default(object); }
  }
}
namespace System.Activities.Tracking {
  [System.ObsoleteAttribute("The WF3 Types are deprecated. Instead, please use the new WF4 Types from System.Activities.*")]
  public partial class InteropTrackingRecord : System.Activities.Tracking.CustomTrackingRecord {
    protected InteropTrackingRecord(System.Activities.Tracking.InteropTrackingRecord record) : base (default(string)) { }
    public InteropTrackingRecord(string activityDisplayName, System.Workflow.Runtime.Tracking.TrackingRecord v1TrackingRecord) : base (default(string)) { }
    public System.Workflow.Runtime.Tracking.TrackingRecord TrackingRecord { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Workflow.Runtime.Tracking.TrackingRecord); } }
    protected override System.Activities.Tracking.TrackingRecord Clone() { return default(System.Activities.Tracking.TrackingRecord); }
  }
}
namespace System.Workflow.Runtime {
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public partial class CorrelationProperty {
    public CorrelationProperty(string name, object value) { }
    public string Name { get { return default(string); } }
    public object Value { get { return default(object); } }
  }
  [System.ComponentModel.Design.Serialization.DesignerSerializerAttribute(typeof(System.Workflow.ComponentModel.Serialization.DependencyObjectCodeDomSerializer), typeof(System.ComponentModel.Design.Serialization.CodeDomSerializer))]
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public sealed partial class CorrelationToken : System.Workflow.ComponentModel.DependencyObject {
    public CorrelationToken() { }
    public CorrelationToken(string name) { }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    public bool Initialized { get { return default(bool); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    public string Name { get { return default(string); } set { } }
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Workflow.ComponentModel.Design.PropertyValueProviderTypeConverter))]
    public string OwnerActivityName { get { return default(string); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    public System.Collections.Generic.ICollection<System.Workflow.Runtime.CorrelationProperty> Properties { get { return default(System.Collections.Generic.ICollection<System.Workflow.Runtime.CorrelationProperty>); } }
    public void Initialize(System.Workflow.ComponentModel.Activity activity, System.Collections.Generic.ICollection<System.Workflow.Runtime.CorrelationProperty> propertyValues) { }
    public void SubscribeForCorrelationTokenInitializedEvent(System.Workflow.ComponentModel.Activity activity, System.Workflow.ComponentModel.IActivityEventListener<System.Workflow.Runtime.CorrelationTokenEventArgs> dataChangeListener) { }
    public void UnsubscribeFromCorrelationTokenInitializedEvent(System.Workflow.ComponentModel.Activity activity, System.Workflow.ComponentModel.IActivityEventListener<System.Workflow.Runtime.CorrelationTokenEventArgs> dataChangeListener) { }
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public sealed partial class CorrelationTokenCollection : System.Collections.ObjectModel.KeyedCollection<System.String, System.Workflow.Runtime.CorrelationToken> {
    public static readonly System.Workflow.ComponentModel.DependencyProperty CorrelationTokenCollectionProperty;
    public CorrelationTokenCollection() { }
    protected override void ClearItems() { }
    public static System.Workflow.Runtime.CorrelationToken GetCorrelationToken(System.Workflow.ComponentModel.Activity activity, string correlationTokenName, string ownerActivityName) { return default(System.Workflow.Runtime.CorrelationToken); }
    public System.Workflow.Runtime.CorrelationToken GetItem(string key) { return default(System.Workflow.Runtime.CorrelationToken); }
    protected override string GetKeyForItem(System.Workflow.Runtime.CorrelationToken item) { return default(string); }
    protected override void InsertItem(int index, System.Workflow.Runtime.CorrelationToken item) { }
    protected override void RemoveItem(int index) { }
    protected override void SetItem(int index, System.Workflow.Runtime.CorrelationToken item) { }
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public sealed partial class CorrelationTokenEventArgs : System.EventArgs {
    internal CorrelationTokenEventArgs() { }
    public System.Workflow.Runtime.CorrelationToken CorrelationToken { get { return default(System.Workflow.Runtime.CorrelationToken); } }
    public bool IsInitializing { get { return default(bool); } }
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public partial interface IPendingWork {
    void Commit(System.Transactions.Transaction transaction, System.Collections.ICollection items);
    void Complete(bool succeeded, System.Collections.ICollection items);
    bool MustCommit(System.Collections.ICollection items);
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public partial interface IWorkBatch {
    void Add(System.Workflow.Runtime.IPendingWork work, object workItem);
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public sealed partial class ServicesExceptionNotHandledEventArgs : System.EventArgs {
    internal ServicesExceptionNotHandledEventArgs() { }
    public System.Exception Exception { get { return default(System.Exception); } }
    public System.Guid WorkflowInstanceId { get { return default(System.Guid); } }
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public partial class TimerEventSubscription {
    protected TimerEventSubscription() { }
    public TimerEventSubscription(System.Guid workflowInstanceId, System.DateTime expiresAt) { }
    public TimerEventSubscription(System.Guid timerId, System.Guid workflowInstanceId, System.DateTime expiresAt) { }
    public virtual System.DateTime ExpiresAt { get { return default(System.DateTime); } }
    public virtual System.IComparable QueueName { get { return default(System.IComparable); } protected set { } }
    public virtual System.Guid SubscriptionId { get { return default(System.Guid); } }
    public virtual System.Guid WorkflowInstanceId { get { return default(System.Guid); } }
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public partial class TimerEventSubscriptionCollection : System.Collections.ICollection, System.Collections.IEnumerable {
    internal TimerEventSubscriptionCollection() { }
    public static readonly System.Workflow.ComponentModel.DependencyProperty TimerCollectionProperty;
    public int Count { get { return default(int); } }
    public bool IsSynchronized { get { return default(bool); } }
    public object SyncRoot { get { return default(object); } }
    public void Add(System.Workflow.Runtime.TimerEventSubscription item) { }
    public void CopyTo(System.Array array, int index) { }
    public System.Collections.IEnumerator GetEnumerator() { return default(System.Collections.IEnumerator); }
    public System.Workflow.Runtime.TimerEventSubscription Peek() { return default(System.Workflow.Runtime.TimerEventSubscription); }
    public void Remove(System.Guid timerSubscriptionId) { }
    public void Remove(System.Workflow.Runtime.TimerEventSubscription item) { }
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public partial class WorkflowCompletedEventArgs : System.Workflow.Runtime.WorkflowEventArgs {
    internal WorkflowCompletedEventArgs() { }
    public System.Collections.Generic.Dictionary<System.String, System.Object> OutputParameters { get { return default(System.Collections.Generic.Dictionary<System.String, System.Object>); } }
    public System.Workflow.ComponentModel.Activity WorkflowDefinition { get { return default(System.Workflow.ComponentModel.Activity); } }
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public static partial class WorkflowEnvironment {
    public static System.Workflow.Runtime.IWorkBatch WorkBatch { get { return default(System.Workflow.Runtime.IWorkBatch); } }
    public static System.Guid WorkflowInstanceId { get { return default(System.Guid); } }
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public partial class WorkflowEventArgs : System.EventArgs {
    internal WorkflowEventArgs() { }
    public System.Workflow.Runtime.WorkflowInstance WorkflowInstance { get { return default(System.Workflow.Runtime.WorkflowInstance); } }
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public sealed partial class WorkflowInstance {
    internal WorkflowInstance() { }
    public System.Guid InstanceId { get { return default(System.Guid); } }
    public System.Workflow.Runtime.WorkflowRuntime WorkflowRuntime { get { return default(System.Workflow.Runtime.WorkflowRuntime); } }
    public void Abort() { }
    public void ApplyWorkflowChanges(System.Workflow.ComponentModel.WorkflowChanges workflowChanges) { }
    public void EnqueueItem(System.IComparable queueName, object item, System.Workflow.Runtime.IPendingWork pendingWork, object workItem) { }
    public void EnqueueItemOnIdle(System.IComparable queueName, object item, System.Workflow.Runtime.IPendingWork pendingWork, object workItem) { }
    public override bool Equals(object obj) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public System.Workflow.ComponentModel.Activity GetWorkflowDefinition() { return default(System.Workflow.ComponentModel.Activity); }
    public System.DateTime GetWorkflowNextTimerExpiration() { return default(System.DateTime); }
    public System.Collections.ObjectModel.ReadOnlyCollection<System.Workflow.Runtime.WorkflowQueueInfo> GetWorkflowQueueData() { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.Workflow.Runtime.WorkflowQueueInfo>); }
    public void Load() { }
    public void ReloadTrackingProfiles() { }
    public void Resume() { }
    public void Start() { }
    public void Suspend(string error) { }
    public void Terminate(string error) { }
    public bool TryUnload() { return default(bool); }
    public void Unload() { }
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public partial class WorkflowOwnershipException : System.Exception {
    public WorkflowOwnershipException() { }
    public WorkflowOwnershipException(System.Guid instanceId) { }
    public WorkflowOwnershipException(System.Guid instanceId, string message) { }
    public WorkflowOwnershipException(System.Guid instanceId, string message, System.Exception innerException) { }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, SerializationFormatter=true)]
    protected WorkflowOwnershipException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public WorkflowOwnershipException(string message) { }
    public WorkflowOwnershipException(string message, System.Exception innerException) { }
    public System.Guid InstanceId { get { return default(System.Guid); } set { } }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, SerializationFormatter=true)]
    public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public partial class WorkflowQueue {
    internal WorkflowQueue() { }
    public int Count { get { return default(int); } }
    public bool Enabled { get { return default(bool); } set { } }
    public System.IComparable QueueName { get { return default(System.IComparable); } }
    public System.Workflow.Runtime.WorkflowQueuingService QueuingService { get { return default(System.Workflow.Runtime.WorkflowQueuingService); } }
    public event System.EventHandler<System.Workflow.ComponentModel.QueueEventArgs> QueueItemArrived { add { } remove { } }
    public event System.EventHandler<System.Workflow.ComponentModel.QueueEventArgs> QueueItemAvailable { add { } remove { } }
    public object Dequeue() { return default(object); }
    public void Enqueue(object item) { }
    public object Peek() { return default(object); }
    public void RegisterForQueueItemArrived(System.Workflow.ComponentModel.IActivityEventListener<System.Workflow.ComponentModel.QueueEventArgs> eventListener) { }
    public void RegisterForQueueItemAvailable(System.Workflow.ComponentModel.IActivityEventListener<System.Workflow.ComponentModel.QueueEventArgs> eventListener) { }
    public void RegisterForQueueItemAvailable(System.Workflow.ComponentModel.IActivityEventListener<System.Workflow.ComponentModel.QueueEventArgs> eventListener, string subscriberQualifiedName) { }
    public void UnregisterForQueueItemArrived(System.Workflow.ComponentModel.IActivityEventListener<System.Workflow.ComponentModel.QueueEventArgs> eventListener) { }
    public void UnregisterForQueueItemAvailable(System.Workflow.ComponentModel.IActivityEventListener<System.Workflow.ComponentModel.QueueEventArgs> eventListener) { }
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public partial class WorkflowQueueInfo {
    internal WorkflowQueueInfo() { }
    public System.Collections.ICollection Items { get { return default(System.Collections.ICollection); } }
    public System.IComparable QueueName { get { return default(System.IComparable); } }
    public System.Collections.ObjectModel.ReadOnlyCollection<System.String> SubscribedActivityNames { get { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.String>); } }
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public partial class WorkflowQueuingService {
    internal WorkflowQueuingService() { }
    public static readonly System.Workflow.ComponentModel.DependencyProperty PendingMessagesProperty;
    public System.Workflow.Runtime.WorkflowQueue CreateWorkflowQueue(System.IComparable queueName, bool transactional) { return default(System.Workflow.Runtime.WorkflowQueue); }
    public void DeleteWorkflowQueue(System.IComparable queueName) { }
    public bool Exists(System.IComparable queueName) { return default(bool); }
    public System.Workflow.Runtime.WorkflowQueue GetWorkflowQueue(System.IComparable queueName) { return default(System.Workflow.Runtime.WorkflowQueue); }
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public partial class WorkflowRuntime : System.IDisposable, System.IServiceProvider {
    public WorkflowRuntime() { }
    public WorkflowRuntime(string configSectionName) { }
    public WorkflowRuntime(System.Workflow.Runtime.Configuration.WorkflowRuntimeSection settings) { }
    public bool IsStarted { get { return default(bool); } }
    public string Name { get { return default(string); } set { } }
    public event System.EventHandler<System.Workflow.Runtime.ServicesExceptionNotHandledEventArgs> ServicesExceptionNotHandled { add { } remove { } }
    public event System.EventHandler<System.Workflow.Runtime.WorkflowRuntimeEventArgs> Started { add { } remove { } }
    public event System.EventHandler<System.Workflow.Runtime.WorkflowRuntimeEventArgs> Stopped { add { } remove { } }
    public event System.EventHandler<System.Workflow.Runtime.WorkflowEventArgs> WorkflowAborted { add { } remove { } }
    public event System.EventHandler<System.Workflow.Runtime.WorkflowCompletedEventArgs> WorkflowCompleted { add { } remove { } }
    public event System.EventHandler<System.Workflow.Runtime.WorkflowEventArgs> WorkflowCreated { add { } remove { } }
    public event System.EventHandler<System.Workflow.Runtime.WorkflowEventArgs> WorkflowIdled { add { } remove { } }
    public event System.EventHandler<System.Workflow.Runtime.WorkflowEventArgs> WorkflowLoaded { add { } remove { } }
    public event System.EventHandler<System.Workflow.Runtime.WorkflowEventArgs> WorkflowPersisted { add { } remove { } }
    public event System.EventHandler<System.Workflow.Runtime.WorkflowEventArgs> WorkflowResumed { add { } remove { } }
    public event System.EventHandler<System.Workflow.Runtime.WorkflowEventArgs> WorkflowStarted { add { } remove { } }
    public event System.EventHandler<System.Workflow.Runtime.WorkflowSuspendedEventArgs> WorkflowSuspended { add { } remove { } }
    public event System.EventHandler<System.Workflow.Runtime.WorkflowTerminatedEventArgs> WorkflowTerminated { add { } remove { } }
    public event System.EventHandler<System.Workflow.Runtime.WorkflowEventArgs> WorkflowUnloaded { add { } remove { } }
    public void AddService(object service) { }
    public System.Workflow.Runtime.WorkflowInstance CreateWorkflow(System.Type workflowType) { return default(System.Workflow.Runtime.WorkflowInstance); }
    public System.Workflow.Runtime.WorkflowInstance CreateWorkflow(System.Type workflowType, System.Collections.Generic.Dictionary<System.String, System.Object> namedArgumentValues) { return default(System.Workflow.Runtime.WorkflowInstance); }
    public System.Workflow.Runtime.WorkflowInstance CreateWorkflow(System.Type workflowType, System.Collections.Generic.Dictionary<System.String, System.Object> namedArgumentValues, System.Guid instanceId) { return default(System.Workflow.Runtime.WorkflowInstance); }
    public System.Workflow.Runtime.WorkflowInstance CreateWorkflow(System.Xml.XmlReader workflowDefinitionReader) { return default(System.Workflow.Runtime.WorkflowInstance); }
    public System.Workflow.Runtime.WorkflowInstance CreateWorkflow(System.Xml.XmlReader workflowDefinitionReader, System.Xml.XmlReader rulesReader, System.Collections.Generic.Dictionary<System.String, System.Object> namedArgumentValues) { return default(System.Workflow.Runtime.WorkflowInstance); }
    public System.Workflow.Runtime.WorkflowInstance CreateWorkflow(System.Xml.XmlReader workflowDefinitionReader, System.Xml.XmlReader rulesReader, System.Collections.Generic.Dictionary<System.String, System.Object> namedArgumentValues, System.Guid instanceId) { return default(System.Workflow.Runtime.WorkflowInstance); }
    public void Dispose() { }
    public System.Collections.ObjectModel.ReadOnlyCollection<System.Object> GetAllServices(System.Type serviceType) { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.Object>); }
    public System.Collections.ObjectModel.ReadOnlyCollection<T> GetAllServices<T>() { return default(System.Collections.ObjectModel.ReadOnlyCollection<T>); }
    public System.Collections.ObjectModel.ReadOnlyCollection<System.Workflow.Runtime.WorkflowInstance> GetLoadedWorkflows() { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.Workflow.Runtime.WorkflowInstance>); }
    public object GetService(System.Type serviceType) { return default(object); }
    public T GetService<T>() { return default(T); }
    public System.Workflow.Runtime.WorkflowInstance GetWorkflow(System.Guid instanceId) { return default(System.Workflow.Runtime.WorkflowInstance); }
    public void RemoveService(object service) { }
    public void StartRuntime() { }
    public void StopRuntime() { }
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public sealed partial class WorkflowRuntimeEventArgs : System.EventArgs {
    internal WorkflowRuntimeEventArgs() { }
    public bool IsStarted { get { return default(bool); } }
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public enum WorkflowStatus {
    Completed = 1,
    Created = 4,
    Running = 0,
    Suspended = 2,
    Terminated = 3,
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public partial class WorkflowSuspendedEventArgs : System.Workflow.Runtime.WorkflowEventArgs {
    internal WorkflowSuspendedEventArgs() { }
    public string Error { get { return default(string); } }
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public partial class WorkflowTerminatedEventArgs : System.Workflow.Runtime.WorkflowEventArgs {
    internal WorkflowTerminatedEventArgs() { }
    public System.Exception Exception { get { return default(System.Exception); } }
  }
}
namespace System.Workflow.Runtime.Configuration {
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public partial class WorkflowRuntimeSection : System.Configuration.ConfigurationSection {
    public WorkflowRuntimeSection() { }
    [System.Configuration.ConfigurationPropertyAttribute("CommonParameters", DefaultValue=null)]
    public System.Configuration.NameValueConfigurationCollection CommonParameters { get { return default(System.Configuration.NameValueConfigurationCollection); } }
    [System.Configuration.ConfigurationPropertyAttribute("EnablePerformanceCounters", DefaultValue=true)]
    public bool EnablePerformanceCounters { get { return default(bool); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("Name", DefaultValue="")]
    public string Name { get { return default(string); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("Services", DefaultValue=null)]
    public System.Workflow.Runtime.Configuration.WorkflowRuntimeServiceElementCollection Services { get { return default(System.Workflow.Runtime.Configuration.WorkflowRuntimeServiceElementCollection); } }
    [System.Configuration.ConfigurationPropertyAttribute("ValidateOnCreate", DefaultValue=true)]
    public bool ValidateOnCreate { get { return default(bool); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("WorkflowDefinitionCacheCapacity", DefaultValue=0)]
    public int WorkflowDefinitionCacheCapacity { get { return default(int); } set { } }
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public partial class WorkflowRuntimeServiceElement : System.Configuration.ConfigurationElement {
    public WorkflowRuntimeServiceElement() { }
    public System.Collections.Specialized.NameValueCollection Parameters { get { return default(System.Collections.Specialized.NameValueCollection); } }
    [System.Configuration.ConfigurationPropertyAttribute("type", DefaultValue=null)]
    public string Type { get { return default(string); } set { } }
    protected override bool OnDeserializeUnrecognizedAttribute(string name, string value) { return default(bool); }
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public partial class WorkflowRuntimeServiceElementCollection : System.Configuration.ConfigurationElementCollection {
    public WorkflowRuntimeServiceElementCollection() { }
    public void Add(System.Workflow.Runtime.Configuration.WorkflowRuntimeServiceElement serviceSettings) { }
    protected override System.Configuration.ConfigurationElement CreateNewElement() { return default(System.Configuration.ConfigurationElement); }
    protected override object GetElementKey(System.Configuration.ConfigurationElement settings) { return default(object); }
  }
}
namespace System.Workflow.Runtime.DebugEngine {
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct ActivityHandlerDescriptor {
    public string Name;
    public int Token;
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public sealed partial class DebugController : System.MarshalByRefObject {
    internal DebugController() { }
    public void AttachToConduit(System.Uri url) { }
    public override object InitializeLifetimeService() { return default(object); }
  }
  public delegate void DebugEngineCallback();
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public partial interface IExpressionEvaluationFrame {
    void CreateEvaluationFrame(System.Workflow.Runtime.DebugEngine.IInstanceTable instanceTable, System.Workflow.Runtime.DebugEngine.DebugEngineCallback callback);
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public partial interface IInstanceTable {
    System.Workflow.ComponentModel.Activity GetActivity(string instanceId, string activityName);
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public partial interface IWorkflowDebugger {
    void ActivityStatusChanged(System.Guid programId, System.Guid scheduleTypeId, System.Guid instanceId, string activityQualifiedName, string hierarchicalActivityId, System.Workflow.ComponentModel.ActivityExecutionStatus status, int stateReaderId);
    void AssemblyLoaded(System.Guid programId, string assemblyPath, bool fromGlobalAssemblyCache);
    void BeforeActivityStatusChanged(System.Guid programId, System.Guid scheduleTypeId, System.Guid instanceId, string activityQualifiedName, string hierarchicalActivityId, System.Workflow.ComponentModel.ActivityExecutionStatus status, int stateReaderId);
    void BeforeHandlerInvoked(System.Guid programId, System.Guid scheduleTypeId, string activityQualifiedName, System.Workflow.Runtime.DebugEngine.ActivityHandlerDescriptor handlerMethod);
    void HandlerInvoked(System.Guid programId, System.Guid instanceId, int threadId, string activityQualifiedName);
    void InstanceCompleted(System.Guid programId, System.Guid instanceId);
    void InstanceCreated(System.Guid programId, System.Guid instanceId, System.Guid scheduleTypeId);
    void InstanceDynamicallyUpdated(System.Guid programId, System.Guid instanceId, System.Guid scheduleTypeId);
    void ScheduleTypeLoaded(System.Guid programId, System.Guid scheduleTypeId, string assemblyFullName, string fileName, string md5Digest, bool isDynamic, string scheduleNamespace, string scheduleName, string workflowMarkup);
    void SetInitialActivityStatus(System.Guid programId, System.Guid scheduleTypeId, System.Guid instanceId, string activityQualifiedName, string hierarchicalActivityId, System.Workflow.ComponentModel.ActivityExecutionStatus status, int stateReaderId);
    void UpdateHandlerMethodsForActivity(System.Guid programId, System.Guid scheduleTypeId, string activityQualifiedName, System.Collections.Generic.List<System.Workflow.Runtime.DebugEngine.ActivityHandlerDescriptor> handlerMethods);
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public partial interface IWorkflowDebuggerService {
    void NotifyHandlerInvoked();
    void NotifyHandlerInvoking(System.Delegate delegateHandler);
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(4), AllowMultiple=false, Inherited=true)]
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public sealed partial class WorkflowDebuggerSteppingAttribute : System.Attribute {
    public WorkflowDebuggerSteppingAttribute(System.Workflow.Runtime.DebugEngine.WorkflowDebuggerSteppingOption steppingOption) { }
    public System.Workflow.Runtime.DebugEngine.WorkflowDebuggerSteppingOption SteppingOption { get { return default(System.Workflow.Runtime.DebugEngine.WorkflowDebuggerSteppingOption); } }
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public enum WorkflowDebuggerSteppingOption {
    Concurrent = 1,
    Sequential = 0,
  }
}
namespace System.Workflow.Runtime.Hosting {
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public partial class DefaultWorkflowCommitWorkBatchService : System.Workflow.Runtime.Hosting.WorkflowCommitWorkBatchService {
    public DefaultWorkflowCommitWorkBatchService() { }
    public DefaultWorkflowCommitWorkBatchService(System.Collections.Specialized.NameValueCollection parameters) { }
    public bool EnableRetries { get { return default(bool); } set { } }
    protected internal override void CommitWorkBatch(System.Workflow.Runtime.Hosting.WorkflowCommitWorkBatchService.CommitWorkBatchCallback commitWorkBatchCallback) { }
    protected override void OnStopped() { }
    protected internal override void Start() { }
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public partial class DefaultWorkflowLoaderService : System.Workflow.Runtime.Hosting.WorkflowLoaderService {
    public DefaultWorkflowLoaderService() { }
    protected internal override System.Workflow.ComponentModel.Activity CreateInstance(System.Type workflowType) { return default(System.Workflow.ComponentModel.Activity); }
    protected internal override System.Workflow.ComponentModel.Activity CreateInstance(System.Xml.XmlReader workflowDefinitionReader, System.Xml.XmlReader rulesReader) { return default(System.Workflow.ComponentModel.Activity); }
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public partial class DefaultWorkflowSchedulerService : System.Workflow.Runtime.Hosting.WorkflowSchedulerService {
    public DefaultWorkflowSchedulerService() { }
    public DefaultWorkflowSchedulerService(System.Collections.Specialized.NameValueCollection parameters) { }
    public DefaultWorkflowSchedulerService(int maxSimultaneousWorkflows) { }
    public int MaxSimultaneousWorkflows { get { return default(int); } }
    protected internal override void Cancel(System.Guid timerId) { }
    protected override void OnStarted() { }
    protected internal override void Schedule(System.Threading.WaitCallback callback, System.Guid workflowInstanceId) { }
    protected internal override void Schedule(System.Threading.WaitCallback callback, System.Guid workflowInstanceId, System.DateTime whenUtc, System.Guid timerId) { }
    protected internal override void Stop() { }
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public partial class ManualWorkflowSchedulerService : System.Workflow.Runtime.Hosting.WorkflowSchedulerService {
    public ManualWorkflowSchedulerService() { }
    public ManualWorkflowSchedulerService(bool useActiveTimers) { }
    public ManualWorkflowSchedulerService(System.Collections.Specialized.NameValueCollection parameters) { }
    protected internal override void Cancel(System.Guid timerId) { }
    protected override void OnStarted() { }
    public bool RunWorkflow(System.Guid workflowInstanceId) { return default(bool); }
    protected internal override void Schedule(System.Threading.WaitCallback callback, System.Guid workflowInstanceId) { }
    protected internal override void Schedule(System.Threading.WaitCallback callback, System.Guid workflowInstanceId, System.DateTime whenUtc, System.Guid timerId) { }
    protected internal override void Stop() { }
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public partial class PersistenceException : System.SystemException {
    public PersistenceException() { }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, SerializationFormatter=true)]
    protected PersistenceException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public PersistenceException(string message) { }
    public PersistenceException(string message, System.Exception innerException) { }
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public partial class SharedConnectionWorkflowCommitWorkBatchService : System.Workflow.Runtime.Hosting.WorkflowCommitWorkBatchService {
    public SharedConnectionWorkflowCommitWorkBatchService(System.Collections.Specialized.NameValueCollection parameters) { }
    public SharedConnectionWorkflowCommitWorkBatchService(string connectionString) { }
    public bool EnableRetries { get { return default(bool); } set { } }
    protected internal override void CommitWorkBatch(System.Workflow.Runtime.Hosting.WorkflowCommitWorkBatchService.CommitWorkBatchCallback commitWorkBatchCallback) { }
    protected override void OnStopped() { }
    protected internal override void Start() { }
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public partial class SqlPersistenceWorkflowInstanceDescription {
    internal SqlPersistenceWorkflowInstanceDescription() { }
    public bool IsBlocked { get { return default(bool); } }
    public System.Data.SqlTypes.SqlDateTime NextTimerExpiration { get { return default(System.Data.SqlTypes.SqlDateTime); } }
    public System.Workflow.Runtime.WorkflowStatus Status { get { return default(System.Workflow.Runtime.WorkflowStatus); } }
    public string SuspendOrTerminateDescription { get { return default(string); } }
    public System.Guid WorkflowInstanceId { get { return default(System.Guid); } }
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public partial class SqlWorkflowPersistenceService : System.Workflow.Runtime.Hosting.WorkflowPersistenceService, System.Workflow.Runtime.IPendingWork {
    public SqlWorkflowPersistenceService(System.Collections.Specialized.NameValueCollection parameters) { }
    public SqlWorkflowPersistenceService(string connectionString) { }
    public SqlWorkflowPersistenceService(string connectionString, bool unloadOnIdle, System.TimeSpan instanceOwnershipDuration, System.TimeSpan loadingInterval) { }
    public bool EnableRetries { get { return default(bool); } set { } }
    public System.TimeSpan LoadingInterval { get { return default(System.TimeSpan); } }
    public System.Guid ServiceInstanceId { get { return default(System.Guid); } }
    public System.Collections.Generic.IEnumerable<System.Workflow.Runtime.Hosting.SqlPersistenceWorkflowInstanceDescription> GetAllWorkflows() { return default(System.Collections.Generic.IEnumerable<System.Workflow.Runtime.Hosting.SqlPersistenceWorkflowInstanceDescription>); }
    protected internal override System.Workflow.ComponentModel.Activity LoadCompletedContextActivity(System.Guid id, System.Workflow.ComponentModel.Activity outerActivity) { return default(System.Workflow.ComponentModel.Activity); }
    public System.Collections.Generic.IList<System.Guid> LoadExpiredTimerWorkflowIds() { return default(System.Collections.Generic.IList<System.Guid>); }
    protected internal override System.Workflow.ComponentModel.Activity LoadWorkflowInstanceState(System.Guid id) { return default(System.Workflow.ComponentModel.Activity); }
    protected override void OnStarted() { }
    protected internal override void SaveCompletedContextActivity(System.Workflow.ComponentModel.Activity completedScopeActivity) { }
    protected internal override void SaveWorkflowInstanceState(System.Workflow.ComponentModel.Activity rootActivity, bool unlock) { }
    protected internal override void Start() { }
    protected internal override void Stop() { }
    void System.Workflow.Runtime.IPendingWork.Commit(System.Transactions.Transaction transaction, System.Collections.ICollection items) { }
    void System.Workflow.Runtime.IPendingWork.Complete(bool succeeded, System.Collections.ICollection items) { }
    bool System.Workflow.Runtime.IPendingWork.MustCommit(System.Collections.ICollection items) { return default(bool); }
    protected internal override bool UnloadOnIdle(System.Workflow.ComponentModel.Activity activity) { return default(bool); }
    protected internal override void UnlockWorkflowInstanceState(System.Workflow.ComponentModel.Activity rootActivity) { }
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public abstract partial class WorkflowCommitWorkBatchService : System.Workflow.Runtime.Hosting.WorkflowRuntimeService {
    protected WorkflowCommitWorkBatchService() { }
    protected internal virtual void CommitWorkBatch(System.Workflow.Runtime.Hosting.WorkflowCommitWorkBatchService.CommitWorkBatchCallback commitWorkBatchCallback) { }
    public delegate void CommitWorkBatchCallback();
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public abstract partial class WorkflowLoaderService : System.Workflow.Runtime.Hosting.WorkflowRuntimeService {
    protected WorkflowLoaderService() { }
    protected internal abstract System.Workflow.ComponentModel.Activity CreateInstance(System.Type workflowType);
    protected internal abstract System.Workflow.ComponentModel.Activity CreateInstance(System.Xml.XmlReader workflowDefinitionReader, System.Xml.XmlReader rulesReader);
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public abstract partial class WorkflowPersistenceService : System.Workflow.Runtime.Hosting.WorkflowRuntimeService {
    protected WorkflowPersistenceService() { }
    protected static System.Byte[] GetDefaultSerializedForm(System.Workflow.ComponentModel.Activity activity) { return default(System.Byte[]); }
    protected internal static bool GetIsBlocked(System.Workflow.ComponentModel.Activity rootActivity) { return default(bool); }
    protected internal static string GetSuspendOrTerminateInfo(System.Workflow.ComponentModel.Activity rootActivity) { return default(string); }
    protected internal static System.Workflow.Runtime.WorkflowStatus GetWorkflowStatus(System.Workflow.ComponentModel.Activity rootActivity) { return default(System.Workflow.Runtime.WorkflowStatus); }
    protected internal abstract System.Workflow.ComponentModel.Activity LoadCompletedContextActivity(System.Guid scopeId, System.Workflow.ComponentModel.Activity outerActivity);
    protected internal abstract System.Workflow.ComponentModel.Activity LoadWorkflowInstanceState(System.Guid instanceId);
    protected static System.Workflow.ComponentModel.Activity RestoreFromDefaultSerializedForm(System.Byte[] activityBytes, System.Workflow.ComponentModel.Activity outerActivity) { return default(System.Workflow.ComponentModel.Activity); }
    protected internal abstract void SaveCompletedContextActivity(System.Workflow.ComponentModel.Activity activity);
    protected internal abstract void SaveWorkflowInstanceState(System.Workflow.ComponentModel.Activity rootActivity, bool unlock);
    protected internal abstract bool UnloadOnIdle(System.Workflow.ComponentModel.Activity activity);
    protected internal abstract void UnlockWorkflowInstanceState(System.Workflow.ComponentModel.Activity rootActivity);
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public abstract partial class WorkflowRuntimeService {
    protected WorkflowRuntimeService() { }
    protected System.Workflow.Runtime.WorkflowRuntime Runtime { get { return default(System.Workflow.Runtime.WorkflowRuntime); } }
    protected System.Workflow.Runtime.Hosting.WorkflowRuntimeServiceState State { get { return default(System.Workflow.Runtime.Hosting.WorkflowRuntimeServiceState); } }
    protected virtual void OnStarted() { }
    protected virtual void OnStopped() { }
    protected void RaiseServicesExceptionNotHandledEvent(System.Exception exception, System.Guid instanceId) { }
    protected internal virtual void Start() { }
    protected internal virtual void Stop() { }
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public enum WorkflowRuntimeServiceState {
    Started = 2,
    Starting = 1,
    Stopped = 0,
    Stopping = 3,
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public abstract partial class WorkflowSchedulerService : System.Workflow.Runtime.Hosting.WorkflowRuntimeService {
    protected WorkflowSchedulerService() { }
    protected internal abstract void Cancel(System.Guid timerId);
    protected internal abstract void Schedule(System.Threading.WaitCallback callback, System.Guid workflowInstanceId);
    protected internal abstract void Schedule(System.Threading.WaitCallback callback, System.Guid workflowInstanceId, System.DateTime whenUtc, System.Guid timerId);
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public sealed partial class WorkflowWebHostingModule : System.Web.IHttpModule {
    public WorkflowWebHostingModule() { }
    void System.Web.IHttpModule.Dispose() { }
    void System.Web.IHttpModule.Init(System.Web.HttpApplication application) { }
  }
}
namespace System.Workflow.Runtime.Tracking {
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public partial class ActivityDataTrackingExtract : System.Workflow.Runtime.Tracking.TrackingExtract {
    public ActivityDataTrackingExtract() { }
    public ActivityDataTrackingExtract(string member) { }
    public override System.Workflow.Runtime.Tracking.TrackingAnnotationCollection Annotations { get { return default(System.Workflow.Runtime.Tracking.TrackingAnnotationCollection); } }
    public override string Member { get { return default(string); } set { } }
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public partial class ActivityTrackingCondition : System.Workflow.Runtime.Tracking.TrackingCondition {
    public ActivityTrackingCondition() { }
    public ActivityTrackingCondition(string member, string value) { }
    public override string Member { get { return default(string); } set { } }
    public override System.Workflow.Runtime.Tracking.ComparisonOperator Operator { get { return default(System.Workflow.Runtime.Tracking.ComparisonOperator); } set { } }
    public override string Value { get { return default(string); } set { } }
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public sealed partial class ActivityTrackingLocation {
    public ActivityTrackingLocation() { }
    public ActivityTrackingLocation(string activityTypeName) { }
    public ActivityTrackingLocation(string activityTypeName, bool matchDerivedTypes, System.Collections.Generic.IEnumerable<System.Workflow.ComponentModel.ActivityExecutionStatus> executionStatusEvents) { }
    public ActivityTrackingLocation(string activityTypeName, System.Collections.Generic.IEnumerable<System.Workflow.ComponentModel.ActivityExecutionStatus> executionStatusEvents) { }
    public ActivityTrackingLocation(System.Type activityType) { }
    public ActivityTrackingLocation(System.Type activityType, bool matchDerivedTypes, System.Collections.Generic.IEnumerable<System.Workflow.ComponentModel.ActivityExecutionStatus> executionStatusEvents) { }
    public ActivityTrackingLocation(System.Type activityType, System.Collections.Generic.IEnumerable<System.Workflow.ComponentModel.ActivityExecutionStatus> executionStatusEvents) { }
    public System.Type ActivityType { get { return default(System.Type); } set { } }
    public string ActivityTypeName { get { return default(string); } set { } }
    public System.Workflow.Runtime.Tracking.TrackingConditionCollection Conditions { get { return default(System.Workflow.Runtime.Tracking.TrackingConditionCollection); } }
    public System.Collections.Generic.IList<System.Workflow.ComponentModel.ActivityExecutionStatus> ExecutionStatusEvents { get { return default(System.Collections.Generic.IList<System.Workflow.ComponentModel.ActivityExecutionStatus>); } }
    public bool MatchDerivedTypes { get { return default(bool); } set { } }
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public partial class ActivityTrackingLocationCollection : System.Collections.Generic.List<System.Workflow.Runtime.Tracking.ActivityTrackingLocation> {
    public ActivityTrackingLocationCollection() { }
    public ActivityTrackingLocationCollection(System.Collections.Generic.IEnumerable<System.Workflow.Runtime.Tracking.ActivityTrackingLocation> locations) { }
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public partial class ActivityTrackingRecord : System.Workflow.Runtime.Tracking.TrackingRecord {
    public ActivityTrackingRecord() { }
    public ActivityTrackingRecord(System.Type activityType, string qualifiedName, System.Guid contextGuid, System.Guid parentContextGuid, System.Workflow.ComponentModel.ActivityExecutionStatus executionStatus, System.DateTime eventDateTime, int eventOrder, System.EventArgs eventArgs) { }
    public System.Type ActivityType { get { return default(System.Type); } set { } }
    public override System.Workflow.Runtime.Tracking.TrackingAnnotationCollection Annotations { get { return default(System.Workflow.Runtime.Tracking.TrackingAnnotationCollection); } }
    public System.Collections.Generic.IList<System.Workflow.Runtime.Tracking.TrackingDataItem> Body { get { return default(System.Collections.Generic.IList<System.Workflow.Runtime.Tracking.TrackingDataItem>); } }
    public System.Guid ContextGuid { get { return default(System.Guid); } set { } }
    public override System.EventArgs EventArgs { get { return default(System.EventArgs); } set { } }
    public override System.DateTime EventDateTime { get { return default(System.DateTime); } set { } }
    public override int EventOrder { get { return default(int); } set { } }
    public System.Workflow.ComponentModel.ActivityExecutionStatus ExecutionStatus { get { return default(System.Workflow.ComponentModel.ActivityExecutionStatus); } set { } }
    public System.Guid ParentContextGuid { get { return default(System.Guid); } set { } }
    public string QualifiedName { get { return default(string); } set { } }
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public sealed partial class ActivityTrackPoint {
    public ActivityTrackPoint() { }
    public System.Workflow.Runtime.Tracking.TrackingAnnotationCollection Annotations { get { return default(System.Workflow.Runtime.Tracking.TrackingAnnotationCollection); } }
    public System.Workflow.Runtime.Tracking.ActivityTrackingLocationCollection ExcludedLocations { get { return default(System.Workflow.Runtime.Tracking.ActivityTrackingLocationCollection); } }
    public System.Workflow.Runtime.Tracking.ExtractCollection Extracts { get { return default(System.Workflow.Runtime.Tracking.ExtractCollection); } }
    public System.Workflow.Runtime.Tracking.ActivityTrackingLocationCollection MatchingLocations { get { return default(System.Workflow.Runtime.Tracking.ActivityTrackingLocationCollection); } }
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public partial class ActivityTrackPointCollection : System.Collections.Generic.List<System.Workflow.Runtime.Tracking.ActivityTrackPoint> {
    public ActivityTrackPointCollection() { }
    public ActivityTrackPointCollection(System.Collections.Generic.IEnumerable<System.Workflow.Runtime.Tracking.ActivityTrackPoint> points) { }
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public enum ComparisonOperator {
    Equals = 0,
    NotEquals = 1,
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public partial class ExtractCollection : System.Collections.Generic.List<System.Workflow.Runtime.Tracking.TrackingExtract> {
    public ExtractCollection() { }
    public ExtractCollection(System.Collections.Generic.IEnumerable<System.Workflow.Runtime.Tracking.TrackingExtract> extracts) { }
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public partial interface IProfileNotification {
    event System.EventHandler<System.Workflow.Runtime.Tracking.ProfileRemovedEventArgs> ProfileRemoved;
    event System.EventHandler<System.Workflow.Runtime.Tracking.ProfileUpdatedEventArgs> ProfileUpdated;
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(4), AllowMultiple=true)]
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public sealed partial class PreviousTrackingServiceAttribute : System.Attribute {
    public PreviousTrackingServiceAttribute(string assemblyQualifiedName) { }
    public string AssemblyQualifiedName { get { return default(string); } }
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public sealed partial class ProfileRemovedEventArgs : System.EventArgs {
    public ProfileRemovedEventArgs() { }
    public ProfileRemovedEventArgs(System.Type workflowType) { }
    public System.Type WorkflowType { get { return default(System.Type); } set { } }
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public sealed partial class ProfileUpdatedEventArgs : System.EventArgs {
    public ProfileUpdatedEventArgs() { }
    public ProfileUpdatedEventArgs(System.Type workflowType, System.Workflow.Runtime.Tracking.TrackingProfile profile) { }
    public System.Workflow.Runtime.Tracking.TrackingProfile TrackingProfile { get { return default(System.Workflow.Runtime.Tracking.TrackingProfile); } set { } }
    public System.Type WorkflowType { get { return default(System.Type); } set { } }
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public sealed partial class SqlTrackingQuery {
    public SqlTrackingQuery() { }
    public SqlTrackingQuery(string connectionString) { }
    public string ConnectionString { get { return default(string); } set { } }
    public System.Collections.Generic.IList<System.Workflow.Runtime.Tracking.SqlTrackingWorkflowInstance> GetWorkflows(System.Workflow.Runtime.Tracking.SqlTrackingQueryOptions options) { return default(System.Collections.Generic.IList<System.Workflow.Runtime.Tracking.SqlTrackingWorkflowInstance>); }
    public bool TryGetWorkflow(System.Guid workflowInstanceId, out System.Workflow.Runtime.Tracking.SqlTrackingWorkflowInstance workflowInstance) { workflowInstance = default(System.Workflow.Runtime.Tracking.SqlTrackingWorkflowInstance); return default(bool); }
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public partial class SqlTrackingQueryOptions {
    public SqlTrackingQueryOptions() { }
    public System.DateTime StatusMaxDateTime { get { return default(System.DateTime); } set { } }
    public System.DateTime StatusMinDateTime { get { return default(System.DateTime); } set { } }
    public System.Collections.Generic.IList<System.Workflow.Runtime.Tracking.TrackingDataItemValue> TrackingDataItems { get { return default(System.Collections.Generic.IList<System.Workflow.Runtime.Tracking.TrackingDataItemValue>); } }
    public System.Nullable<System.Workflow.Runtime.WorkflowStatus> WorkflowStatus { get { return default(System.Nullable<System.Workflow.Runtime.WorkflowStatus>); } set { } }
    public System.Type WorkflowType { get { return default(System.Type); } set { } }
    public void Clear() { }
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public sealed partial class SqlTrackingService : System.Workflow.Runtime.Tracking.TrackingService, System.Workflow.Runtime.Tracking.IProfileNotification {
    public SqlTrackingService(System.Collections.Specialized.NameValueCollection parameters) { }
    public SqlTrackingService(string connectionString) { }
    public string ConnectionString { get { return default(string); } }
    public bool EnableRetries { get { return default(bool); } set { } }
    public bool IsTransactional { get { return default(bool); } set { } }
    public bool PartitionOnCompletion { get { return default(bool); } set { } }
    public double ProfileChangeCheckInterval { get { return default(double); } set { } }
    public bool UseDefaultProfile { get { return default(bool); } set { } }
    public event System.EventHandler<System.Workflow.Runtime.Tracking.ProfileRemovedEventArgs> ProfileRemoved { add { } remove { } }
    public event System.EventHandler<System.Workflow.Runtime.Tracking.ProfileUpdatedEventArgs> ProfileUpdated { add { } remove { } }
    protected internal override System.Workflow.Runtime.Tracking.TrackingProfile GetProfile(System.Guid scheduleInstanceId) { return default(System.Workflow.Runtime.Tracking.TrackingProfile); }
    protected internal override System.Workflow.Runtime.Tracking.TrackingProfile GetProfile(System.Type workflowType, System.Version profileVersion) { return default(System.Workflow.Runtime.Tracking.TrackingProfile); }
    protected internal override System.Workflow.Runtime.Tracking.TrackingChannel GetTrackingChannel(System.Workflow.Runtime.Tracking.TrackingParameters parameters) { return default(System.Workflow.Runtime.Tracking.TrackingChannel); }
    protected internal override void Start() { }
    protected internal override bool TryGetProfile(System.Type workflowType, out System.Workflow.Runtime.Tracking.TrackingProfile profile) { profile = default(System.Workflow.Runtime.Tracking.TrackingProfile); return default(bool); }
    protected internal override bool TryReloadProfile(System.Type workflowType, System.Guid scheduleInstanceId, out System.Workflow.Runtime.Tracking.TrackingProfile profile) { profile = default(System.Workflow.Runtime.Tracking.TrackingProfile); return default(bool); }
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public partial class SqlTrackingWorkflowInstance {
    internal SqlTrackingWorkflowInstance() { }
    public System.Collections.Generic.IList<System.Workflow.Runtime.Tracking.ActivityTrackingRecord> ActivityEvents { get { return default(System.Collections.Generic.IList<System.Workflow.Runtime.Tracking.ActivityTrackingRecord>); } }
    public bool AutoRefresh { get { return default(bool); } set { } }
    public System.DateTime Initialized { get { return default(System.DateTime); } set { } }
    public System.Collections.Generic.IList<System.Workflow.Runtime.Tracking.SqlTrackingWorkflowInstance> InvokedWorkflows { get { return default(System.Collections.Generic.IList<System.Workflow.Runtime.Tracking.SqlTrackingWorkflowInstance>); } }
    public System.Guid InvokingWorkflowInstanceId { get { return default(System.Guid); } set { } }
    public System.Workflow.Runtime.WorkflowStatus Status { get { return default(System.Workflow.Runtime.WorkflowStatus); } set { } }
    public System.Collections.Generic.IList<System.Workflow.Runtime.Tracking.UserTrackingRecord> UserEvents { get { return default(System.Collections.Generic.IList<System.Workflow.Runtime.Tracking.UserTrackingRecord>); } }
    public System.Workflow.ComponentModel.Activity WorkflowDefinition { get { return default(System.Workflow.ComponentModel.Activity); } }
    public bool WorkflowDefinitionUpdated { get { return default(bool); } }
    public System.Collections.Generic.IList<System.Workflow.Runtime.Tracking.WorkflowTrackingRecord> WorkflowEvents { get { return default(System.Collections.Generic.IList<System.Workflow.Runtime.Tracking.WorkflowTrackingRecord>); } }
    public System.Guid WorkflowInstanceId { get { return default(System.Guid); } set { } }
    public long WorkflowInstanceInternalId { get { return default(long); } set { } }
    public System.Type WorkflowType { get { return default(System.Type); } set { } }
    public void Refresh() { }
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public partial class TrackingAnnotationCollection : System.Collections.Generic.List<System.String> {
    public TrackingAnnotationCollection() { }
    public TrackingAnnotationCollection(System.Collections.Generic.IEnumerable<System.String> annotations) { }
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public abstract partial class TrackingChannel {
    protected TrackingChannel() { }
    protected internal abstract void InstanceCompletedOrTerminated();
    protected internal abstract void Send(System.Workflow.Runtime.Tracking.TrackingRecord record);
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public abstract partial class TrackingCondition {
    protected TrackingCondition() { }
    public abstract string Member { get; set; }
    public abstract System.Workflow.Runtime.Tracking.ComparisonOperator Operator { get; set; }
    public abstract string Value { get; set; }
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public partial class TrackingConditionCollection : System.Collections.Generic.List<System.Workflow.Runtime.Tracking.TrackingCondition> {
    public TrackingConditionCollection() { }
    public TrackingConditionCollection(System.Collections.Generic.IEnumerable<System.Workflow.Runtime.Tracking.TrackingCondition> conditions) { }
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public partial class TrackingDataItem {
    public TrackingDataItem() { }
    public System.Workflow.Runtime.Tracking.TrackingAnnotationCollection Annotations { get { return default(System.Workflow.Runtime.Tracking.TrackingAnnotationCollection); } }
    public object Data { get { return default(object); } set { } }
    public string FieldName { get { return default(string); } set { } }
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public partial class TrackingDataItemValue {
    public TrackingDataItemValue() { }
    public TrackingDataItemValue(string qualifiedName, string fieldName, string dataValue) { }
    public string DataValue { get { return default(string); } set { } }
    public string FieldName { get { return default(string); } set { } }
    public string QualifiedName { get { return default(string); } set { } }
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public abstract partial class TrackingExtract {
    protected TrackingExtract() { }
    public abstract System.Workflow.Runtime.Tracking.TrackingAnnotationCollection Annotations { get; }
    public abstract string Member { get; set; }
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public sealed partial class TrackingParameters {
    public TrackingParameters(System.Guid instanceId, System.Type workflowType, System.Workflow.ComponentModel.Activity rootActivity, System.Collections.Generic.IList<System.String> callPath, System.Guid callerInstanceId, System.Guid contextGuid, System.Guid callerContextGuid, System.Guid callerParentContextGuid) { }
    public System.Guid CallerContextGuid { get { return default(System.Guid); } }
    public System.Guid CallerInstanceId { get { return default(System.Guid); } }
    public System.Guid CallerParentContextGuid { get { return default(System.Guid); } }
    public System.Collections.Generic.IList<System.String> CallPath { get { return default(System.Collections.Generic.IList<System.String>); } }
    public System.Guid ContextGuid { get { return default(System.Guid); } }
    public System.Guid InstanceId { get { return default(System.Guid); } }
    public System.Workflow.ComponentModel.Activity RootActivity { get { return default(System.Workflow.ComponentModel.Activity); } }
    public System.Type WorkflowType { get { return default(System.Type); } }
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public partial class TrackingProfile {
    public TrackingProfile() { }
    public System.Workflow.Runtime.Tracking.ActivityTrackPointCollection ActivityTrackPoints { get { return default(System.Workflow.Runtime.Tracking.ActivityTrackPointCollection); } }
    public System.Workflow.Runtime.Tracking.UserTrackPointCollection UserTrackPoints { get { return default(System.Workflow.Runtime.Tracking.UserTrackPointCollection); } }
    public System.Version Version { get { return default(System.Version); } set { } }
    public System.Workflow.Runtime.Tracking.WorkflowTrackPointCollection WorkflowTrackPoints { get { return default(System.Workflow.Runtime.Tracking.WorkflowTrackPointCollection); } }
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public static partial class TrackingProfileCache {
    public static void Clear() { }
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public sealed partial class TrackingProfileDeserializationException : System.SystemException {
    public TrackingProfileDeserializationException() { }
    public TrackingProfileDeserializationException(string message) { }
    public TrackingProfileDeserializationException(string message, System.Exception innerException) { }
    public System.Collections.Generic.IList<System.Xml.Schema.ValidationEventArgs> ValidationEventArgs { get { return default(System.Collections.Generic.IList<System.Xml.Schema.ValidationEventArgs>); } }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, SerializationFormatter=true)]
    public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public partial class TrackingProfileSerializer {
    public TrackingProfileSerializer() { }
    public System.Xml.Schema.XmlSchema Schema { get { return default(System.Xml.Schema.XmlSchema); } }
    public System.Workflow.Runtime.Tracking.TrackingProfile Deserialize(System.IO.TextReader reader) { return default(System.Workflow.Runtime.Tracking.TrackingProfile); }
    public void Serialize(System.IO.TextWriter writer, System.Workflow.Runtime.Tracking.TrackingProfile profile) { }
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public abstract partial class TrackingRecord {
    protected TrackingRecord() { }
    public abstract System.Workflow.Runtime.Tracking.TrackingAnnotationCollection Annotations { get; }
    public abstract System.EventArgs EventArgs { get; set; }
    public abstract System.DateTime EventDateTime { get; set; }
    public abstract int EventOrder { get; set; }
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public abstract partial class TrackingService : System.Workflow.Runtime.Hosting.WorkflowRuntimeService {
    protected TrackingService() { }
    protected internal abstract System.Workflow.Runtime.Tracking.TrackingProfile GetProfile(System.Guid workflowInstanceId);
    protected internal abstract System.Workflow.Runtime.Tracking.TrackingProfile GetProfile(System.Type workflowType, System.Version profileVersionId);
    protected internal abstract System.Workflow.Runtime.Tracking.TrackingChannel GetTrackingChannel(System.Workflow.Runtime.Tracking.TrackingParameters parameters);
    protected internal abstract bool TryGetProfile(System.Type workflowType, out System.Workflow.Runtime.Tracking.TrackingProfile profile);
    protected internal abstract bool TryReloadProfile(System.Type workflowType, System.Guid workflowInstanceId, out System.Workflow.Runtime.Tracking.TrackingProfile profile);
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public partial class TrackingWorkflowChangedEventArgs : System.EventArgs {
    internal TrackingWorkflowChangedEventArgs() { }
    public System.Collections.Generic.IList<System.Workflow.ComponentModel.WorkflowChangeAction> Changes { get { return default(System.Collections.Generic.IList<System.Workflow.ComponentModel.WorkflowChangeAction>); } }
    public System.Workflow.ComponentModel.Activity Definition { get { return default(System.Workflow.ComponentModel.Activity); } }
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public enum TrackingWorkflowEvent {
    Aborted = 10,
    Changed = 11,
    Completed = 1,
    Created = 0,
    Exception = 8,
    Idle = 2,
    Loaded = 7,
    Persisted = 5,
    Resumed = 4,
    Started = 12,
    Suspended = 3,
    Terminated = 9,
    Unloaded = 6,
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public partial class TrackingWorkflowExceptionEventArgs : System.EventArgs {
    internal TrackingWorkflowExceptionEventArgs() { }
    public System.Guid ContextGuid { get { return default(System.Guid); } }
    public string CurrentActivityPath { get { return default(string); } }
    public System.Exception Exception { get { return default(System.Exception); } }
    public string OriginalActivityPath { get { return default(string); } }
    public System.Guid ParentContextGuid { get { return default(System.Guid); } }
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public partial class TrackingWorkflowSuspendedEventArgs : System.EventArgs {
    internal TrackingWorkflowSuspendedEventArgs() { }
    public string Error { get { return default(string); } }
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public partial class TrackingWorkflowTerminatedEventArgs : System.EventArgs {
    internal TrackingWorkflowTerminatedEventArgs() { }
    public System.Exception Exception { get { return default(System.Exception); } }
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public sealed partial class UserTrackingLocation {
    public UserTrackingLocation() { }
    public UserTrackingLocation(string argumentTypeName) { }
    public UserTrackingLocation(string argumentTypeName, string activityTypeName) { }
    public UserTrackingLocation(string argumentTypeName, System.Type activityType) { }
    public UserTrackingLocation(System.Type argumentType) { }
    public UserTrackingLocation(System.Type argumentType, string activityTypeName) { }
    public UserTrackingLocation(System.Type argumentType, System.Type activityType) { }
    public System.Type ActivityType { get { return default(System.Type); } set { } }
    public string ActivityTypeName { get { return default(string); } set { } }
    public System.Type ArgumentType { get { return default(System.Type); } set { } }
    public string ArgumentTypeName { get { return default(string); } set { } }
    public System.Workflow.Runtime.Tracking.TrackingConditionCollection Conditions { get { return default(System.Workflow.Runtime.Tracking.TrackingConditionCollection); } }
    public string KeyName { get { return default(string); } set { } }
    public bool MatchDerivedActivityTypes { get { return default(bool); } set { } }
    public bool MatchDerivedArgumentTypes { get { return default(bool); } set { } }
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public partial class UserTrackingLocationCollection : System.Collections.Generic.List<System.Workflow.Runtime.Tracking.UserTrackingLocation> {
    public UserTrackingLocationCollection() { }
    public UserTrackingLocationCollection(System.Collections.Generic.IEnumerable<System.Workflow.Runtime.Tracking.UserTrackingLocation> locations) { }
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public partial class UserTrackingRecord : System.Workflow.Runtime.Tracking.TrackingRecord {
    public UserTrackingRecord() { }
    public UserTrackingRecord(System.Type activityType, string qualifiedName, System.Guid contextGuid, System.Guid parentContextGuid, System.DateTime eventDateTime, int eventOrder, string userDataKey, object userData) { }
    public System.Type ActivityType { get { return default(System.Type); } set { } }
    public override System.Workflow.Runtime.Tracking.TrackingAnnotationCollection Annotations { get { return default(System.Workflow.Runtime.Tracking.TrackingAnnotationCollection); } }
    public System.Collections.Generic.IList<System.Workflow.Runtime.Tracking.TrackingDataItem> Body { get { return default(System.Collections.Generic.IList<System.Workflow.Runtime.Tracking.TrackingDataItem>); } }
    public System.Guid ContextGuid { get { return default(System.Guid); } set { } }
    public override System.EventArgs EventArgs { get { return default(System.EventArgs); } set { } }
    public override System.DateTime EventDateTime { get { return default(System.DateTime); } set { } }
    public override int EventOrder { get { return default(int); } set { } }
    public System.Guid ParentContextGuid { get { return default(System.Guid); } set { } }
    public string QualifiedName { get { return default(string); } set { } }
    public object UserData { get { return default(object); } set { } }
    public string UserDataKey { get { return default(string); } set { } }
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public sealed partial class UserTrackPoint {
    public UserTrackPoint() { }
    public System.Workflow.Runtime.Tracking.TrackingAnnotationCollection Annotations { get { return default(System.Workflow.Runtime.Tracking.TrackingAnnotationCollection); } }
    public System.Workflow.Runtime.Tracking.UserTrackingLocationCollection ExcludedLocations { get { return default(System.Workflow.Runtime.Tracking.UserTrackingLocationCollection); } }
    public System.Workflow.Runtime.Tracking.ExtractCollection Extracts { get { return default(System.Workflow.Runtime.Tracking.ExtractCollection); } }
    public System.Workflow.Runtime.Tracking.UserTrackingLocationCollection MatchingLocations { get { return default(System.Workflow.Runtime.Tracking.UserTrackingLocationCollection); } }
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public partial class UserTrackPointCollection : System.Collections.Generic.List<System.Workflow.Runtime.Tracking.UserTrackPoint> {
    public UserTrackPointCollection() { }
    public UserTrackPointCollection(System.Collections.Generic.IEnumerable<System.Workflow.Runtime.Tracking.UserTrackPoint> points) { }
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public partial class WorkflowDataTrackingExtract : System.Workflow.Runtime.Tracking.TrackingExtract {
    public WorkflowDataTrackingExtract() { }
    public WorkflowDataTrackingExtract(string member) { }
    public override System.Workflow.Runtime.Tracking.TrackingAnnotationCollection Annotations { get { return default(System.Workflow.Runtime.Tracking.TrackingAnnotationCollection); } }
    public override string Member { get { return default(string); } set { } }
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public sealed partial class WorkflowTrackingLocation {
    public WorkflowTrackingLocation() { }
    public WorkflowTrackingLocation(System.Collections.Generic.IList<System.Workflow.Runtime.Tracking.TrackingWorkflowEvent> events) { }
    public System.Collections.Generic.IList<System.Workflow.Runtime.Tracking.TrackingWorkflowEvent> Events { get { return default(System.Collections.Generic.IList<System.Workflow.Runtime.Tracking.TrackingWorkflowEvent>); } }
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public partial class WorkflowTrackingRecord : System.Workflow.Runtime.Tracking.TrackingRecord {
    public WorkflowTrackingRecord() { }
    public WorkflowTrackingRecord(System.Workflow.Runtime.Tracking.TrackingWorkflowEvent trackingWorkflowEvent, System.DateTime eventDateTime, int eventOrder, System.EventArgs eventArgs) { }
    public override System.Workflow.Runtime.Tracking.TrackingAnnotationCollection Annotations { get { return default(System.Workflow.Runtime.Tracking.TrackingAnnotationCollection); } }
    public override System.EventArgs EventArgs { get { return default(System.EventArgs); } set { } }
    public override System.DateTime EventDateTime { get { return default(System.DateTime); } set { } }
    public override int EventOrder { get { return default(int); } set { } }
    public System.Workflow.Runtime.Tracking.TrackingWorkflowEvent TrackingWorkflowEvent { get { return default(System.Workflow.Runtime.Tracking.TrackingWorkflowEvent); } set { } }
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public sealed partial class WorkflowTrackPoint {
    public WorkflowTrackPoint() { }
    public System.Workflow.Runtime.Tracking.TrackingAnnotationCollection Annotations { get { return default(System.Workflow.Runtime.Tracking.TrackingAnnotationCollection); } }
    public System.Workflow.Runtime.Tracking.WorkflowTrackingLocation MatchingLocation { get { return default(System.Workflow.Runtime.Tracking.WorkflowTrackingLocation); } set { } }
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public partial class WorkflowTrackPointCollection : System.Collections.Generic.List<System.Workflow.Runtime.Tracking.WorkflowTrackPoint> {
    public WorkflowTrackPointCollection() { }
    public WorkflowTrackPointCollection(System.Collections.Generic.IEnumerable<System.Workflow.Runtime.Tracking.WorkflowTrackPoint> points) { }
  }
}
