namespace System.Runtime.DurableInstancing {
  public partial class InstanceCollisionException : System.Runtime.DurableInstancing.InstancePersistenceCommandException {
    public InstanceCollisionException() { }
    [System.Security.SecurityCriticalAttribute]
    protected InstanceCollisionException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public InstanceCollisionException(string message) { }
    public InstanceCollisionException(string message, System.Exception innerException) { }
    public InstanceCollisionException(System.Xml.Linq.XName commandName, System.Guid instanceId) { }
    public InstanceCollisionException(System.Xml.Linq.XName commandName, System.Guid instanceId, System.Exception innerException) { }
    public InstanceCollisionException(System.Xml.Linq.XName commandName, System.Guid instanceId, string message, System.Exception innerException) { }
  }
  public partial class InstanceCompleteException : System.Runtime.DurableInstancing.InstancePersistenceCommandException {
    public InstanceCompleteException() { }
    [System.Security.SecurityCriticalAttribute]
    protected InstanceCompleteException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public InstanceCompleteException(string message) { }
    public InstanceCompleteException(string message, System.Exception innerException) { }
    public InstanceCompleteException(System.Xml.Linq.XName commandName, System.Guid instanceId) { }
    public InstanceCompleteException(System.Xml.Linq.XName commandName, System.Guid instanceId, System.Exception innerException) { }
    public InstanceCompleteException(System.Xml.Linq.XName commandName, System.Guid instanceId, string message, System.Exception innerException) { }
  }
  public sealed partial class InstanceHandle {
    internal InstanceHandle() { }
    public bool IsValid { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } }
    public void Free() { }
  }
  public partial class InstanceHandleConflictException : System.Runtime.DurableInstancing.InstancePersistenceCommandException {
    public InstanceHandleConflictException() { }
    [System.Security.SecurityCriticalAttribute]
    protected InstanceHandleConflictException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public InstanceHandleConflictException(string message) { }
    public InstanceHandleConflictException(string message, System.Exception innerException) { }
    public InstanceHandleConflictException(System.Xml.Linq.XName commandName, System.Guid instanceId) { }
    public InstanceHandleConflictException(System.Xml.Linq.XName commandName, System.Guid instanceId, System.Exception innerException) { }
    public InstanceHandleConflictException(System.Xml.Linq.XName commandName, System.Guid instanceId, string message, System.Exception innerException) { }
  }
  [System.Runtime.Serialization.DataContractAttribute]
  public partial class InstanceKey {
    public InstanceKey(System.Guid value) { }
    public InstanceKey(System.Guid value, System.Collections.Generic.IDictionary<System.Xml.Linq.XName, System.Runtime.DurableInstancing.InstanceValue> metadata) { }
    public static System.Runtime.DurableInstancing.InstanceKey InvalidKey { get { return default(System.Runtime.DurableInstancing.InstanceKey); } }
    public bool IsValid { get { return default(bool); } }
    public System.Collections.Generic.IDictionary<System.Xml.Linq.XName, System.Runtime.DurableInstancing.InstanceValue> Metadata { get { return default(System.Collections.Generic.IDictionary<System.Xml.Linq.XName, System.Runtime.DurableInstancing.InstanceValue>); } }
    public System.Guid Value { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Guid); } }
    public override bool Equals(object obj) { return default(bool); }
    public override int GetHashCode() { return default(int); }
  }
  public partial class InstanceKeyCollisionException : System.Runtime.DurableInstancing.InstancePersistenceCommandException {
    public InstanceKeyCollisionException() { }
    [System.Security.SecurityCriticalAttribute]
    protected InstanceKeyCollisionException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public InstanceKeyCollisionException(string message) { }
    public InstanceKeyCollisionException(string message, System.Exception innerException) { }
    public InstanceKeyCollisionException(System.Xml.Linq.XName commandName, System.Guid instanceId, System.Runtime.DurableInstancing.InstanceKey instanceKey, System.Guid conflictingInstanceId) { }
    public InstanceKeyCollisionException(System.Xml.Linq.XName commandName, System.Guid instanceId, System.Runtime.DurableInstancing.InstanceKey instanceKey, System.Guid conflictingInstanceId, System.Exception innerException) { }
    public InstanceKeyCollisionException(System.Xml.Linq.XName commandName, System.Guid instanceId, System.Runtime.DurableInstancing.InstanceKey instanceKey, System.Guid conflictingInstanceId, string message, System.Exception innerException) { }
    public System.Guid ConflictingInstanceId { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Guid); } }
    public System.Runtime.DurableInstancing.InstanceKey InstanceKey { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Runtime.DurableInstancing.InstanceKey); } }
    [System.Security.SecurityCriticalAttribute]
    public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
  }
  public partial class InstanceKeyCompleteException : System.Runtime.DurableInstancing.InstancePersistenceCommandException {
    public InstanceKeyCompleteException() { }
    [System.Security.SecurityCriticalAttribute]
    protected InstanceKeyCompleteException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public InstanceKeyCompleteException(string message) { }
    public InstanceKeyCompleteException(string message, System.Exception innerException) { }
    public InstanceKeyCompleteException(System.Xml.Linq.XName commandName, System.Guid instanceId, System.Runtime.DurableInstancing.InstanceKey instanceKey, string message, System.Exception innerException) { }
    public InstanceKeyCompleteException(System.Xml.Linq.XName commandName, System.Runtime.DurableInstancing.InstanceKey instanceKey) { }
    public InstanceKeyCompleteException(System.Xml.Linq.XName commandName, System.Runtime.DurableInstancing.InstanceKey instanceKey, System.Exception innerException) { }
    public System.Runtime.DurableInstancing.InstanceKey InstanceKey { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Runtime.DurableInstancing.InstanceKey); } }
    [System.Security.SecurityCriticalAttribute]
    public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
  }
  public partial class InstanceKeyNotReadyException : System.Runtime.DurableInstancing.InstancePersistenceCommandException {
    public InstanceKeyNotReadyException() { }
    [System.Security.SecurityCriticalAttribute]
    protected InstanceKeyNotReadyException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public InstanceKeyNotReadyException(string message) { }
    public InstanceKeyNotReadyException(string message, System.Exception innerException) { }
    public InstanceKeyNotReadyException(System.Xml.Linq.XName commandName, System.Guid instanceId, System.Runtime.DurableInstancing.InstanceKey instanceKey, string message, System.Exception innerException) { }
    public InstanceKeyNotReadyException(System.Xml.Linq.XName commandName, System.Runtime.DurableInstancing.InstanceKey instanceKey) { }
    public InstanceKeyNotReadyException(System.Xml.Linq.XName commandName, System.Runtime.DurableInstancing.InstanceKey instanceKey, System.Exception innerException) { }
    public System.Runtime.DurableInstancing.InstanceKey InstanceKey { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Runtime.DurableInstancing.InstanceKey); } }
    [System.Security.SecurityCriticalAttribute]
    public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
  }
  public enum InstanceKeyState {
    Associated = 1,
    Completed = 2,
    Unknown = 0,
  }
  public sealed partial class InstanceKeyView {
    internal InstanceKeyView() { }
    public System.Guid InstanceKey { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Guid); } }
    public System.Collections.Generic.IDictionary<System.Xml.Linq.XName, System.Runtime.DurableInstancing.InstanceValue> InstanceKeyMetadata { get { return default(System.Collections.Generic.IDictionary<System.Xml.Linq.XName, System.Runtime.DurableInstancing.InstanceValue>); } }
    public System.Runtime.DurableInstancing.InstanceValueConsistency InstanceKeyMetadataConsistency { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Runtime.DurableInstancing.InstanceValueConsistency); } }
    public System.Runtime.DurableInstancing.InstanceKeyState InstanceKeyState { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Runtime.DurableInstancing.InstanceKeyState); } }
  }
  public partial class InstanceLockedException : System.Runtime.DurableInstancing.InstancePersistenceCommandException {
    public InstanceLockedException() { }
    [System.Security.SecurityCriticalAttribute]
    protected InstanceLockedException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public InstanceLockedException(string message) { }
    public InstanceLockedException(string message, System.Exception innerException) { }
    public InstanceLockedException(System.Xml.Linq.XName commandName, System.Guid instanceId) { }
    public InstanceLockedException(System.Xml.Linq.XName commandName, System.Guid instanceId, System.Exception innerException) { }
    public InstanceLockedException(System.Xml.Linq.XName commandName, System.Guid instanceId, System.Guid instanceOwnerId, System.Collections.Generic.IDictionary<System.Xml.Linq.XName, System.Object> serializableInstanceOwnerMetadata) { }
    public InstanceLockedException(System.Xml.Linq.XName commandName, System.Guid instanceId, System.Guid instanceOwnerId, System.Collections.Generic.IDictionary<System.Xml.Linq.XName, System.Object> serializableInstanceOwnerMetadata, System.Exception innerException) { }
    public InstanceLockedException(System.Xml.Linq.XName commandName, System.Guid instanceId, System.Guid instanceOwnerId, System.Collections.Generic.IDictionary<System.Xml.Linq.XName, System.Object> serializableInstanceOwnerMetadata, string message, System.Exception innerException) { }
    public InstanceLockedException(System.Xml.Linq.XName commandName, System.Guid instanceId, string message, System.Exception innerException) { }
    public System.Guid InstanceOwnerId { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Guid); } }
    public System.Collections.Generic.IDictionary<System.Xml.Linq.XName, System.Object> SerializableInstanceOwnerMetadata { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Collections.Generic.IDictionary<System.Xml.Linq.XName, System.Object>); } }
    [System.Security.SecurityCriticalAttribute]
    public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
  }
  public partial class InstanceLockLostException : System.Runtime.DurableInstancing.InstancePersistenceCommandException {
    public InstanceLockLostException() { }
    [System.Security.SecurityCriticalAttribute]
    protected InstanceLockLostException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public InstanceLockLostException(string message) { }
    public InstanceLockLostException(string message, System.Exception innerException) { }
    public InstanceLockLostException(System.Xml.Linq.XName commandName, System.Guid instanceId) { }
    public InstanceLockLostException(System.Xml.Linq.XName commandName, System.Guid instanceId, System.Exception innerException) { }
    public InstanceLockLostException(System.Xml.Linq.XName commandName, System.Guid instanceId, string message, System.Exception innerException) { }
  }
  public sealed partial class InstanceLockQueryResult : System.Runtime.DurableInstancing.InstanceStoreQueryResult {
    public InstanceLockQueryResult() { }
    public InstanceLockQueryResult(System.Collections.Generic.IDictionary<System.Guid, System.Guid> instanceOwnerIds) { }
    public InstanceLockQueryResult(System.Guid instanceId, System.Guid instanceOwnerId) { }
    public System.Collections.Generic.IDictionary<System.Guid, System.Guid> InstanceOwnerIds { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Collections.Generic.IDictionary<System.Guid, System.Guid>); } }
  }
  public partial class InstanceNotReadyException : System.Runtime.DurableInstancing.InstancePersistenceCommandException {
    public InstanceNotReadyException() { }
    [System.Security.SecurityCriticalAttribute]
    protected InstanceNotReadyException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public InstanceNotReadyException(string message) { }
    public InstanceNotReadyException(string message, System.Exception innerException) { }
    public InstanceNotReadyException(System.Xml.Linq.XName commandName, System.Guid instanceId) { }
    public InstanceNotReadyException(System.Xml.Linq.XName commandName, System.Guid instanceId, System.Exception innerException) { }
    public InstanceNotReadyException(System.Xml.Linq.XName commandName, System.Guid instanceId, string message, System.Exception innerException) { }
  }
  public sealed partial class InstanceOwner {
    internal InstanceOwner() { }
    public System.Guid InstanceOwnerId { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Guid); } }
  }
  public partial class InstanceOwnerException : System.Runtime.DurableInstancing.InstancePersistenceException {
    public InstanceOwnerException() { }
    [System.Security.SecurityCriticalAttribute]
    protected InstanceOwnerException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public InstanceOwnerException(string message) { }
    public InstanceOwnerException(string message, System.Exception innerException) { }
    public InstanceOwnerException(System.Xml.Linq.XName commandName, System.Guid instanceOwnerId) { }
    public InstanceOwnerException(System.Xml.Linq.XName commandName, System.Guid instanceOwnerId, System.Exception innerException) { }
    public InstanceOwnerException(System.Xml.Linq.XName commandName, System.Guid instanceOwnerId, string message, System.Exception innerException) { }
    public System.Guid InstanceOwnerId { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Guid); } }
    [System.Security.SecurityCriticalAttribute]
    public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
  }
  public sealed partial class InstanceOwnerQueryResult : System.Runtime.DurableInstancing.InstanceStoreQueryResult {
    public InstanceOwnerQueryResult() { }
    public InstanceOwnerQueryResult(System.Collections.Generic.IDictionary<System.Guid, System.Collections.Generic.IDictionary<System.Xml.Linq.XName, System.Runtime.DurableInstancing.InstanceValue>> instanceOwners) { }
    public InstanceOwnerQueryResult(System.Guid instanceOwnerId, System.Collections.Generic.IDictionary<System.Xml.Linq.XName, System.Runtime.DurableInstancing.InstanceValue> metadata) { }
    public System.Collections.Generic.IDictionary<System.Guid, System.Collections.Generic.IDictionary<System.Xml.Linq.XName, System.Runtime.DurableInstancing.InstanceValue>> InstanceOwners { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Collections.Generic.IDictionary<System.Guid, System.Collections.Generic.IDictionary<System.Xml.Linq.XName, System.Runtime.DurableInstancing.InstanceValue>>); } }
  }
  public abstract partial class InstancePersistenceCommand {
    protected InstancePersistenceCommand(System.Xml.Linq.XName name) { }
    protected internal virtual bool AutomaticallyAcquiringLock { get { return default(bool); } }
    protected internal virtual bool IsTransactionEnlistmentOptional { get { return default(bool); } }
    public System.Xml.Linq.XName Name { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Xml.Linq.XName); } }
    protected internal virtual void Validate(System.Runtime.DurableInstancing.InstanceView view) { }
  }
  public partial class InstancePersistenceCommandException : System.Runtime.DurableInstancing.InstancePersistenceException {
    public InstancePersistenceCommandException() { }
    [System.Security.SecurityCriticalAttribute]
    protected InstancePersistenceCommandException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public InstancePersistenceCommandException(string message) { }
    public InstancePersistenceCommandException(string message, System.Exception innerException) { }
    public InstancePersistenceCommandException(System.Xml.Linq.XName commandName) { }
    public InstancePersistenceCommandException(System.Xml.Linq.XName commandName, System.Exception innerException) { }
    public InstancePersistenceCommandException(System.Xml.Linq.XName commandName, System.Guid instanceId) { }
    public InstancePersistenceCommandException(System.Xml.Linq.XName commandName, System.Guid instanceId, System.Exception innerException) { }
    public InstancePersistenceCommandException(System.Xml.Linq.XName commandName, System.Guid instanceId, string message, System.Exception innerException) { }
    public InstancePersistenceCommandException(System.Xml.Linq.XName commandName, string message, System.Exception innerException) { }
    public System.Guid InstanceId { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Guid); } }
    [System.Security.SecurityCriticalAttribute]
    public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
  }
  public sealed partial class InstancePersistenceContext {
    internal InstancePersistenceContext() { }
    public System.Runtime.DurableInstancing.InstanceHandle InstanceHandle { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Runtime.DurableInstancing.InstanceHandle); } }
    public long InstanceVersion { get { return default(long); } }
    public System.Runtime.DurableInstancing.InstanceView InstanceView { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Runtime.DurableInstancing.InstanceView); } }
    public System.Guid LockToken { get { return default(System.Guid); } }
    public object UserContext { get { return default(object); } }
    public void AssociatedInstanceKey(System.Guid key) { }
    public System.IAsyncResult BeginBindReclaimedLock(long instanceVersion, System.TimeSpan timeout, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    public System.IAsyncResult BeginExecute(System.Runtime.DurableInstancing.InstancePersistenceCommand command, System.TimeSpan timeout, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    public void BindAcquiredLock(long instanceVersion) { }
    public void BindEvent(System.Runtime.DurableInstancing.InstancePersistenceEvent persistenceEvent) { }
    public void BindInstance(System.Guid instanceId) { }
    public void BindInstanceOwner(System.Guid instanceOwnerId, System.Guid lockToken) { }
    public void BindReclaimedLock(long instanceVersion, System.TimeSpan timeout) { }
    public void CompletedInstance() { }
    public void CompletedInstanceKey(System.Guid key) { }
    public System.Exception CreateBindReclaimedLockException(long instanceVersion) { return default(System.Exception); }
    public void EndBindReclaimedLock(System.IAsyncResult result) { }
    public void EndExecute(System.IAsyncResult result) { }
    public void Execute(System.Runtime.DurableInstancing.InstancePersistenceCommand command, System.TimeSpan timeout) { }
    public void LoadedInstance(System.Runtime.DurableInstancing.InstanceState state, System.Collections.Generic.IDictionary<System.Xml.Linq.XName, System.Runtime.DurableInstancing.InstanceValue> instanceData, System.Collections.Generic.IDictionary<System.Xml.Linq.XName, System.Runtime.DurableInstancing.InstanceValue> instanceMetadata, System.Collections.Generic.IDictionary<System.Guid, System.Collections.Generic.IDictionary<System.Xml.Linq.XName, System.Runtime.DurableInstancing.InstanceValue>> associatedInstanceKeyMetadata, System.Collections.Generic.IDictionary<System.Guid, System.Collections.Generic.IDictionary<System.Xml.Linq.XName, System.Runtime.DurableInstancing.InstanceValue>> completedInstanceKeyMetadata) { }
    public void PersistedInstance(System.Collections.Generic.IDictionary<System.Xml.Linq.XName, System.Runtime.DurableInstancing.InstanceValue> data) { }
    public void QueriedInstanceStore(System.Runtime.DurableInstancing.InstanceStoreQueryResult queryResult) { }
    public void ReadInstanceKeyMetadata(System.Guid key, System.Collections.Generic.IDictionary<System.Xml.Linq.XName, System.Runtime.DurableInstancing.InstanceValue> metadata, bool complete) { }
    public void ReadInstanceMetadata(System.Collections.Generic.IDictionary<System.Xml.Linq.XName, System.Runtime.DurableInstancing.InstanceValue> metadata, bool complete) { }
    public void ReadInstanceOwnerMetadata(System.Collections.Generic.IDictionary<System.Xml.Linq.XName, System.Runtime.DurableInstancing.InstanceValue> metadata, bool complete) { }
    public void SetCancellationHandler(System.Action<System.Runtime.DurableInstancing.InstancePersistenceContext> cancellationHandler) { }
    public void UnassociatedInstanceKey(System.Guid key) { }
    public void WroteInstanceKeyMetadataValue(System.Guid key, System.Xml.Linq.XName name, System.Runtime.DurableInstancing.InstanceValue value) { }
    public void WroteInstanceMetadataValue(System.Xml.Linq.XName name, System.Runtime.DurableInstancing.InstanceValue value) { }
    public void WroteInstanceOwnerMetadataValue(System.Xml.Linq.XName name, System.Runtime.DurableInstancing.InstanceValue value) { }
  }
  public abstract partial class InstancePersistenceEvent : System.IEquatable<System.Runtime.DurableInstancing.InstancePersistenceEvent> {
    internal InstancePersistenceEvent() { }
    public System.Xml.Linq.XName Name { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Xml.Linq.XName); } }
    public override bool Equals(object obj) { return default(bool); }
    public bool Equals(System.Runtime.DurableInstancing.InstancePersistenceEvent persistenceEvent) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public static bool operator ==(System.Runtime.DurableInstancing.InstancePersistenceEvent left, System.Runtime.DurableInstancing.InstancePersistenceEvent right) { return default(bool); }
    public static bool operator !=(System.Runtime.DurableInstancing.InstancePersistenceEvent left, System.Runtime.DurableInstancing.InstancePersistenceEvent right) { return default(bool); }
  }
  public abstract partial class InstancePersistenceEvent<T> : System.Runtime.DurableInstancing.InstancePersistenceEvent where T : System.Runtime.DurableInstancing.InstancePersistenceEvent<T>, new() {
    protected InstancePersistenceEvent(System.Xml.Linq.XName name) { }
    public static T Value { get { return default(T); } }
  }
  public partial class InstancePersistenceException : System.Exception {
    public InstancePersistenceException() { }
    [System.Security.SecurityCriticalAttribute]
    protected InstancePersistenceException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public InstancePersistenceException(string message) { }
    public InstancePersistenceException(string message, System.Exception innerException) { }
    public InstancePersistenceException(System.Xml.Linq.XName commandName) { }
    public InstancePersistenceException(System.Xml.Linq.XName commandName, System.Exception innerException) { }
    public InstancePersistenceException(System.Xml.Linq.XName commandName, string message) { }
    public InstancePersistenceException(System.Xml.Linq.XName commandName, string message, System.Exception innerException) { }
    public System.Xml.Linq.XName CommandName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Xml.Linq.XName); } }
    [System.Security.SecurityCriticalAttribute]
    public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
  }
  public enum InstanceState {
    Completed = 3,
    Initialized = 2,
    Uninitialized = 1,
    Unknown = 0,
  }
  public abstract partial class InstanceStore {
    protected InstanceStore() { }
    public System.Runtime.DurableInstancing.InstanceOwner DefaultInstanceOwner { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Runtime.DurableInstancing.InstanceOwner); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.IAsyncResult BeginExecute(System.Runtime.DurableInstancing.InstanceHandle handle, System.Runtime.DurableInstancing.InstancePersistenceCommand command, System.TimeSpan timeout, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    protected internal virtual System.IAsyncResult BeginTryCommand(System.Runtime.DurableInstancing.InstancePersistenceContext context, System.Runtime.DurableInstancing.InstancePersistenceCommand command, System.TimeSpan timeout, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    public System.IAsyncResult BeginWaitForEvents(System.Runtime.DurableInstancing.InstanceHandle handle, System.TimeSpan timeout, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    public System.Runtime.DurableInstancing.InstanceHandle CreateInstanceHandle() { return default(System.Runtime.DurableInstancing.InstanceHandle); }
    public System.Runtime.DurableInstancing.InstanceHandle CreateInstanceHandle(System.Guid instanceId) { return default(System.Runtime.DurableInstancing.InstanceHandle); }
    public System.Runtime.DurableInstancing.InstanceHandle CreateInstanceHandle(System.Runtime.DurableInstancing.InstanceOwner owner) { return default(System.Runtime.DurableInstancing.InstanceHandle); }
    public System.Runtime.DurableInstancing.InstanceHandle CreateInstanceHandle(System.Runtime.DurableInstancing.InstanceOwner owner, System.Guid instanceId) { return default(System.Runtime.DurableInstancing.InstanceHandle); }
    public System.Runtime.DurableInstancing.InstanceView EndExecute(System.IAsyncResult result) { return default(System.Runtime.DurableInstancing.InstanceView); }
    protected internal virtual bool EndTryCommand(System.IAsyncResult result) { return default(bool); }
    public System.Collections.Generic.List<System.Runtime.DurableInstancing.InstancePersistenceEvent> EndWaitForEvents(System.IAsyncResult result) { return default(System.Collections.Generic.List<System.Runtime.DurableInstancing.InstancePersistenceEvent>); }
    public System.Runtime.DurableInstancing.InstanceView Execute(System.Runtime.DurableInstancing.InstanceHandle handle, System.Runtime.DurableInstancing.InstancePersistenceCommand command, System.TimeSpan timeout) { return default(System.Runtime.DurableInstancing.InstanceView); }
    protected System.Runtime.DurableInstancing.InstancePersistenceEvent[] GetEvents(System.Runtime.DurableInstancing.InstanceOwner owner) { return default(System.Runtime.DurableInstancing.InstancePersistenceEvent[]); }
    protected System.Runtime.DurableInstancing.InstanceOwner[] GetInstanceOwners() { return default(System.Runtime.DurableInstancing.InstanceOwner[]); }
    protected virtual void OnFreeInstanceHandle(System.Runtime.DurableInstancing.InstanceHandle instanceHandle, object userContext) { }
    protected virtual object OnNewInstanceHandle(System.Runtime.DurableInstancing.InstanceHandle instanceHandle) { return default(object); }
    protected void ResetEvent(System.Runtime.DurableInstancing.InstancePersistenceEvent persistenceEvent, System.Runtime.DurableInstancing.InstanceOwner owner) { }
    protected void SignalEvent(System.Runtime.DurableInstancing.InstancePersistenceEvent persistenceEvent, System.Runtime.DurableInstancing.InstanceOwner owner) { }
    protected internal virtual bool TryCommand(System.Runtime.DurableInstancing.InstancePersistenceContext context, System.Runtime.DurableInstancing.InstancePersistenceCommand command, System.TimeSpan timeout) { return default(bool); }
    public System.Collections.Generic.List<System.Runtime.DurableInstancing.InstancePersistenceEvent> WaitForEvents(System.Runtime.DurableInstancing.InstanceHandle handle, System.TimeSpan timeout) { return default(System.Collections.Generic.List<System.Runtime.DurableInstancing.InstancePersistenceEvent>); }
  }
  public abstract partial class InstanceStoreQueryResult {
    protected InstanceStoreQueryResult() { }
  }
  [System.Runtime.Serialization.DataContractAttribute]
  public sealed partial class InstanceValue {
    public InstanceValue(object value) { }
    public InstanceValue(object value, System.Runtime.DurableInstancing.InstanceValueOptions options) { }
    public static System.Runtime.DurableInstancing.InstanceValue DeletedValue { get { return default(System.Runtime.DurableInstancing.InstanceValue); } }
    public bool IsDeletedValue { get { return default(bool); } }
    public System.Runtime.DurableInstancing.InstanceValueOptions Options { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Runtime.DurableInstancing.InstanceValueOptions); } }
    public object Value { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(object); } }
  }
  [System.FlagsAttribute]
  public enum InstanceValueConsistency {
    InDoubt = 1,
    None = 0,
    Partial = 2,
  }
  [System.FlagsAttribute]
  [System.Runtime.Serialization.DataContractAttribute]
  public enum InstanceValueOptions {
    [System.Runtime.Serialization.EnumMemberAttribute]
    None = 0,
    [System.Runtime.Serialization.EnumMemberAttribute]
    Optional = 1,
    [System.Runtime.Serialization.EnumMemberAttribute]
    WriteOnly = 2,
  }
  public sealed partial class InstanceView {
    internal InstanceView() { }
    public System.Collections.Generic.IDictionary<System.Xml.Linq.XName, System.Runtime.DurableInstancing.InstanceValue> InstanceData { get { return default(System.Collections.Generic.IDictionary<System.Xml.Linq.XName, System.Runtime.DurableInstancing.InstanceValue>); } }
    public System.Runtime.DurableInstancing.InstanceValueConsistency InstanceDataConsistency { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Runtime.DurableInstancing.InstanceValueConsistency); } }
    public System.Guid InstanceId { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Guid); } }
    public System.Collections.Generic.IDictionary<System.Guid, System.Runtime.DurableInstancing.InstanceKeyView> InstanceKeys { get { return default(System.Collections.Generic.IDictionary<System.Guid, System.Runtime.DurableInstancing.InstanceKeyView>); } }
    public System.Runtime.DurableInstancing.InstanceValueConsistency InstanceKeysConsistency { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Runtime.DurableInstancing.InstanceValueConsistency); } }
    public System.Collections.Generic.IDictionary<System.Xml.Linq.XName, System.Runtime.DurableInstancing.InstanceValue> InstanceMetadata { get { return default(System.Collections.Generic.IDictionary<System.Xml.Linq.XName, System.Runtime.DurableInstancing.InstanceValue>); } }
    public System.Runtime.DurableInstancing.InstanceValueConsistency InstanceMetadataConsistency { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Runtime.DurableInstancing.InstanceValueConsistency); } }
    public System.Runtime.DurableInstancing.InstanceOwner InstanceOwner { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Runtime.DurableInstancing.InstanceOwner); } }
    public System.Collections.Generic.IDictionary<System.Xml.Linq.XName, System.Runtime.DurableInstancing.InstanceValue> InstanceOwnerMetadata { get { return default(System.Collections.Generic.IDictionary<System.Xml.Linq.XName, System.Runtime.DurableInstancing.InstanceValue>); } }
    public System.Runtime.DurableInstancing.InstanceValueConsistency InstanceOwnerMetadataConsistency { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Runtime.DurableInstancing.InstanceValueConsistency); } }
    public System.Runtime.DurableInstancing.InstanceState InstanceState { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Runtime.DurableInstancing.InstanceState); } }
    public System.Collections.ObjectModel.ReadOnlyCollection<System.Runtime.DurableInstancing.InstanceStoreQueryResult> InstanceStoreQueryResults { get { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.Runtime.DurableInstancing.InstanceStoreQueryResult>); } }
    public bool IsBoundToInstance { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } }
    public bool IsBoundToInstanceOwner { get { return default(bool); } }
    public bool IsBoundToLock { get { return default(bool); } }
  }
}
