namespace System.Management {
  public enum AuthenticationLevel {
    Call = 3,
    Connect = 2,
    Default = 0,
    None = 1,
    Packet = 4,
    PacketIntegrity = 5,
    PacketPrivacy = 6,
    Unchanged = -1,
  }
  public enum CimType {
    Boolean = 11,
    Char16 = 103,
    DateTime = 101,
    None = 0,
    Object = 13,
    Real32 = 4,
    Real64 = 5,
    Reference = 102,
    SInt16 = 2,
    SInt32 = 3,
    SInt64 = 20,
    SInt8 = 16,
    String = 8,
    UInt16 = 18,
    UInt32 = 19,
    UInt64 = 21,
    UInt8 = 17,
  }
  public enum CodeLanguage {
    CSharp = 0,
    JScript = 1,
    Mcpp = 4,
    VB = 2,
    VJSharp = 3,
  }
  [System.FlagsAttribute]
  public enum ComparisonSettings {
    IgnoreCase = 16,
    IgnoreClass = 8,
    IgnoreDefaultValues = 4,
    IgnoreFlavor = 32,
    IgnoreObjectSource = 2,
    IgnoreQualifiers = 1,
    IncludeAll = 0,
  }
  public partial class CompletedEventArgs : System.Management.ManagementEventArgs {
    internal CompletedEventArgs() { }
    public System.Management.ManagementStatus Status { get { return default(System.Management.ManagementStatus); } }
    public System.Management.ManagementBaseObject StatusObject { get { return default(System.Management.ManagementBaseObject); } }
  }
  public delegate void CompletedEventHandler(object sender, System.Management.CompletedEventArgs e);
  public partial class ConnectionOptions : System.Management.ManagementOptions {
    public ConnectionOptions() { }
    public ConnectionOptions(string locale, string username, System.Security.SecureString password, string authority, System.Management.ImpersonationLevel impersonation, System.Management.AuthenticationLevel authentication, bool enablePrivileges, System.Management.ManagementNamedValueCollection context, System.TimeSpan timeout) { }
    public ConnectionOptions(string locale, string username, string password, string authority, System.Management.ImpersonationLevel impersonation, System.Management.AuthenticationLevel authentication, bool enablePrivileges, System.Management.ManagementNamedValueCollection context, System.TimeSpan timeout) { }
    public System.Management.AuthenticationLevel Authentication { get { return default(System.Management.AuthenticationLevel); } set { } }
    public string Authority { get { return default(string); } set { } }
    public bool EnablePrivileges { get { return default(bool); } set { } }
    public System.Management.ImpersonationLevel Impersonation { get { return default(System.Management.ImpersonationLevel); } set { } }
    public string Locale { get { return default(string); } set { } }
    public string Password { set { } }
    public System.Security.SecureString SecurePassword { set { } }
    public string Username { get { return default(string); } set { } }
    public override object Clone() { return default(object); }
  }
  public partial class DeleteOptions : System.Management.ManagementOptions {
    public DeleteOptions() { }
    public DeleteOptions(System.Management.ManagementNamedValueCollection context, System.TimeSpan timeout) { }
    public override object Clone() { return default(object); }
  }
  public partial class EnumerationOptions : System.Management.ManagementOptions {
    public EnumerationOptions() { }
    public EnumerationOptions(System.Management.ManagementNamedValueCollection context, System.TimeSpan timeout, int blockSize, bool rewindable, bool returnImmediatley, bool useAmendedQualifiers, bool ensureLocatable, bool prototypeOnly, bool directRead, bool enumerateDeep) { }
    public int BlockSize { get { return default(int); } set { } }
    public bool DirectRead { get { return default(bool); } set { } }
    public bool EnsureLocatable { get { return default(bool); } set { } }
    public bool EnumerateDeep { get { return default(bool); } set { } }
    public bool PrototypeOnly { get { return default(bool); } set { } }
    public bool ReturnImmediately { get { return default(bool); } set { } }
    public bool Rewindable { get { return default(bool); } set { } }
    public bool UseAmendedQualifiers { get { return default(bool); } set { } }
    public override object Clone() { return default(object); }
  }
  public partial class EventArrivedEventArgs : System.Management.ManagementEventArgs {
    internal EventArrivedEventArgs() { }
    public System.Management.ManagementBaseObject NewEvent { get { return default(System.Management.ManagementBaseObject); } }
  }
  public delegate void EventArrivedEventHandler(object sender, System.Management.EventArrivedEventArgs e);
  public partial class EventQuery : System.Management.ManagementQuery {
    public EventQuery() { }
    public EventQuery(string query) { }
    public EventQuery(string language, string query) { }
    public override object Clone() { return default(object); }
  }
  public partial class EventWatcherOptions : System.Management.ManagementOptions {
    public EventWatcherOptions() { }
    public EventWatcherOptions(System.Management.ManagementNamedValueCollection context, System.TimeSpan timeout, int blockSize) { }
    public int BlockSize { get { return default(int); } set { } }
    public override object Clone() { return default(object); }
  }
  public enum ImpersonationLevel {
    Anonymous = 1,
    Default = 0,
    Delegate = 4,
    Identify = 2,
    Impersonate = 3,
  }
  public partial class InvokeMethodOptions : System.Management.ManagementOptions {
    public InvokeMethodOptions() { }
    public InvokeMethodOptions(System.Management.ManagementNamedValueCollection context, System.TimeSpan timeout) { }
    public override object Clone() { return default(object); }
  }
  [System.ComponentModel.ToolboxItemAttribute(false)]
  public partial class ManagementBaseObject : System.ComponentModel.Component, System.ICloneable, System.Runtime.Serialization.ISerializable {
    protected ManagementBaseObject(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public virtual System.Management.ManagementPath ClassPath { get { return default(System.Management.ManagementPath); } }
    public object this[string propertyName] { get { return default(object); } set { } }
    public virtual System.Management.PropertyDataCollection Properties { get { return default(System.Management.PropertyDataCollection); } }
    public virtual System.Management.QualifierDataCollection Qualifiers { get { return default(System.Management.QualifierDataCollection); } }
    public virtual System.Management.PropertyDataCollection SystemProperties { get { return default(System.Management.PropertyDataCollection); } }
    public virtual object Clone() { return default(object); }
    public bool CompareTo(System.Management.ManagementBaseObject otherObject, System.Management.ComparisonSettings settings) { return default(bool); }
    public new void Dispose() { }
    public override bool Equals(object obj) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    protected virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public object GetPropertyQualifierValue(string propertyName, string qualifierName) { return default(object); }
    public object GetPropertyValue(string propertyName) { return default(object); }
    public object GetQualifierValue(string qualifierName) { return default(object); }
    public string GetText(System.Management.TextFormat format) { return default(string); }
    public static explicit operator System.IntPtr (System.Management.ManagementBaseObject managementObject) { return default(System.IntPtr); }
    public void SetPropertyQualifierValue(string propertyName, string qualifierName, object qualifierValue) { }
    public void SetPropertyValue(string propertyName, object propertyValue) { }
    public void SetQualifierValue(string qualifierName, object qualifierValue) { }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, SerializationFormatter=true)]
    void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
  }
  public partial class ManagementClass : System.Management.ManagementObject {
    public ManagementClass() { }
    public ManagementClass(System.Management.ManagementPath path) { }
    public ManagementClass(System.Management.ManagementPath path, System.Management.ObjectGetOptions options) { }
    public ManagementClass(System.Management.ManagementScope scope, System.Management.ManagementPath path, System.Management.ObjectGetOptions options) { }
    protected ManagementClass(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public ManagementClass(string path) { }
    public ManagementClass(string path, System.Management.ObjectGetOptions options) { }
    public ManagementClass(string scope, string path, System.Management.ObjectGetOptions options) { }
    public System.Collections.Specialized.StringCollection Derivation { get { return default(System.Collections.Specialized.StringCollection); } }
    public System.Management.MethodDataCollection Methods { get { return default(System.Management.MethodDataCollection); } }
    public override System.Management.ManagementPath Path { get { return default(System.Management.ManagementPath); } set { } }
    public override object Clone() { return default(object); }
    public System.Management.ManagementObject CreateInstance() { return default(System.Management.ManagementObject); }
    public System.Management.ManagementClass Derive(string newClassName) { return default(System.Management.ManagementClass); }
    public System.Management.ManagementObjectCollection GetInstances() { return default(System.Management.ManagementObjectCollection); }
    public System.Management.ManagementObjectCollection GetInstances(System.Management.EnumerationOptions options) { return default(System.Management.ManagementObjectCollection); }
    public void GetInstances(System.Management.ManagementOperationObserver watcher) { }
    public void GetInstances(System.Management.ManagementOperationObserver watcher, System.Management.EnumerationOptions options) { }
    protected override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public System.Management.ManagementObjectCollection GetRelatedClasses() { return default(System.Management.ManagementObjectCollection); }
    public void GetRelatedClasses(System.Management.ManagementOperationObserver watcher) { }
    public void GetRelatedClasses(System.Management.ManagementOperationObserver watcher, string relatedClass) { }
    public void GetRelatedClasses(System.Management.ManagementOperationObserver watcher, string relatedClass, string relationshipClass, string relationshipQualifier, string relatedQualifier, string relatedRole, string thisRole, System.Management.EnumerationOptions options) { }
    public System.Management.ManagementObjectCollection GetRelatedClasses(string relatedClass) { return default(System.Management.ManagementObjectCollection); }
    public System.Management.ManagementObjectCollection GetRelatedClasses(string relatedClass, string relationshipClass, string relationshipQualifier, string relatedQualifier, string relatedRole, string thisRole, System.Management.EnumerationOptions options) { return default(System.Management.ManagementObjectCollection); }
    public System.Management.ManagementObjectCollection GetRelationshipClasses() { return default(System.Management.ManagementObjectCollection); }
    public void GetRelationshipClasses(System.Management.ManagementOperationObserver watcher) { }
    public void GetRelationshipClasses(System.Management.ManagementOperationObserver watcher, string relationshipClass) { }
    public void GetRelationshipClasses(System.Management.ManagementOperationObserver watcher, string relationshipClass, string relationshipQualifier, string thisRole, System.Management.EnumerationOptions options) { }
    public System.Management.ManagementObjectCollection GetRelationshipClasses(string relationshipClass) { return default(System.Management.ManagementObjectCollection); }
    public System.Management.ManagementObjectCollection GetRelationshipClasses(string relationshipClass, string relationshipQualifier, string thisRole, System.Management.EnumerationOptions options) { return default(System.Management.ManagementObjectCollection); }
    public System.CodeDom.CodeTypeDeclaration GetStronglyTypedClassCode(bool includeSystemClassInClassDef, bool systemPropertyClass) { return default(System.CodeDom.CodeTypeDeclaration); }
    public bool GetStronglyTypedClassCode(System.Management.CodeLanguage lang, string filePath, string classNamespace) { return default(bool); }
    public System.Management.ManagementObjectCollection GetSubclasses() { return default(System.Management.ManagementObjectCollection); }
    public System.Management.ManagementObjectCollection GetSubclasses(System.Management.EnumerationOptions options) { return default(System.Management.ManagementObjectCollection); }
    public void GetSubclasses(System.Management.ManagementOperationObserver watcher) { }
    public void GetSubclasses(System.Management.ManagementOperationObserver watcher, System.Management.EnumerationOptions options) { }
  }
  public sealed partial class ManagementDateTimeConverter {
    internal ManagementDateTimeConverter() { }
    public static System.DateTime ToDateTime(string dmtfDate) { return default(System.DateTime); }
    public static string ToDmtfDateTime(System.DateTime date) { return default(string); }
    public static string ToDmtfTimeInterval(System.TimeSpan timespan) { return default(string); }
    public static System.TimeSpan ToTimeSpan(string dmtfTimespan) { return default(System.TimeSpan); }
  }
  public abstract partial class ManagementEventArgs : System.EventArgs {
    internal ManagementEventArgs() { }
    public object Context { get { return default(object); } }
  }
  [System.ComponentModel.ToolboxItemAttribute(false)]
  public partial class ManagementEventWatcher : System.ComponentModel.Component {
    public ManagementEventWatcher() { }
    public ManagementEventWatcher(System.Management.EventQuery query) { }
    public ManagementEventWatcher(System.Management.ManagementScope scope, System.Management.EventQuery query) { }
    public ManagementEventWatcher(System.Management.ManagementScope scope, System.Management.EventQuery query, System.Management.EventWatcherOptions options) { }
    public ManagementEventWatcher(string query) { }
    public ManagementEventWatcher(string scope, string query) { }
    public ManagementEventWatcher(string scope, string query, System.Management.EventWatcherOptions options) { }
    public System.Management.EventWatcherOptions Options { get { return default(System.Management.EventWatcherOptions); } set { } }
    public System.Management.EventQuery Query { get { return default(System.Management.EventQuery); } set { } }
    public System.Management.ManagementScope Scope { get { return default(System.Management.ManagementScope); } set { } }
    public event System.Management.EventArrivedEventHandler EventArrived { add { } remove { } }
    public event System.Management.StoppedEventHandler Stopped { add { } remove { } }
    ~ManagementEventWatcher() { }
    public void Start() { }
    public void Stop() { }
    public System.Management.ManagementBaseObject WaitForNextEvent() { return default(System.Management.ManagementBaseObject); }
  }
  public partial class ManagementException : System.SystemException {
    public ManagementException() { }
    protected ManagementException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public ManagementException(string message) { }
    public ManagementException(string message, System.Exception innerException) { }
    public System.Management.ManagementStatus ErrorCode { get { return default(System.Management.ManagementStatus); } }
    public System.Management.ManagementBaseObject ErrorInformation { get { return default(System.Management.ManagementBaseObject); } }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, SerializationFormatter=true)]
    public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
  }
  public partial class ManagementNamedValueCollection : System.Collections.Specialized.NameObjectCollectionBase {
    public ManagementNamedValueCollection() { }
    protected ManagementNamedValueCollection(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public object this[string name] { get { return default(object); } }
    public void Add(string name, object value) { }
    public System.Management.ManagementNamedValueCollection Clone() { return default(System.Management.ManagementNamedValueCollection); }
    public void Remove(string name) { }
    public void RemoveAll() { }
  }
  public partial class ManagementObject : System.Management.ManagementBaseObject, System.ICloneable {
    public ManagementObject() : base (default(System.Runtime.Serialization.SerializationInfo), default(System.Runtime.Serialization.StreamingContext)) { }
    public ManagementObject(System.Management.ManagementPath path) : base (default(System.Runtime.Serialization.SerializationInfo), default(System.Runtime.Serialization.StreamingContext)) { }
    public ManagementObject(System.Management.ManagementPath path, System.Management.ObjectGetOptions options) : base (default(System.Runtime.Serialization.SerializationInfo), default(System.Runtime.Serialization.StreamingContext)) { }
    public ManagementObject(System.Management.ManagementScope scope, System.Management.ManagementPath path, System.Management.ObjectGetOptions options) : base (default(System.Runtime.Serialization.SerializationInfo), default(System.Runtime.Serialization.StreamingContext)) { }
    protected ManagementObject(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) : base (default(System.Runtime.Serialization.SerializationInfo), default(System.Runtime.Serialization.StreamingContext)) { }
    public ManagementObject(string path) : base (default(System.Runtime.Serialization.SerializationInfo), default(System.Runtime.Serialization.StreamingContext)) { }
    public ManagementObject(string path, System.Management.ObjectGetOptions options) : base (default(System.Runtime.Serialization.SerializationInfo), default(System.Runtime.Serialization.StreamingContext)) { }
    public ManagementObject(string scopeString, string pathString, System.Management.ObjectGetOptions options) : base (default(System.Runtime.Serialization.SerializationInfo), default(System.Runtime.Serialization.StreamingContext)) { }
    public override System.Management.ManagementPath ClassPath { get { return default(System.Management.ManagementPath); } }
    public System.Management.ObjectGetOptions Options { get { return default(System.Management.ObjectGetOptions); } set { } }
    public virtual System.Management.ManagementPath Path { get { return default(System.Management.ManagementPath); } set { } }
    public System.Management.ManagementScope Scope { get { return default(System.Management.ManagementScope); } set { } }
    public override object Clone() { return default(object); }
    public void CopyTo(System.Management.ManagementOperationObserver watcher, System.Management.ManagementPath path) { }
    public void CopyTo(System.Management.ManagementOperationObserver watcher, System.Management.ManagementPath path, System.Management.PutOptions options) { }
    public void CopyTo(System.Management.ManagementOperationObserver watcher, string path) { }
    public void CopyTo(System.Management.ManagementOperationObserver watcher, string path, System.Management.PutOptions options) { }
    public System.Management.ManagementPath CopyTo(System.Management.ManagementPath path) { return default(System.Management.ManagementPath); }
    public System.Management.ManagementPath CopyTo(System.Management.ManagementPath path, System.Management.PutOptions options) { return default(System.Management.ManagementPath); }
    public System.Management.ManagementPath CopyTo(string path) { return default(System.Management.ManagementPath); }
    public System.Management.ManagementPath CopyTo(string path, System.Management.PutOptions options) { return default(System.Management.ManagementPath); }
    public void Delete() { }
    public void Delete(System.Management.DeleteOptions options) { }
    public void Delete(System.Management.ManagementOperationObserver watcher) { }
    public void Delete(System.Management.ManagementOperationObserver watcher, System.Management.DeleteOptions options) { }
    public new void Dispose() { }
    public void Get() { }
    public void Get(System.Management.ManagementOperationObserver watcher) { }
    public System.Management.ManagementBaseObject GetMethodParameters(string methodName) { return default(System.Management.ManagementBaseObject); }
    protected override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public System.Management.ManagementObjectCollection GetRelated() { return default(System.Management.ManagementObjectCollection); }
    public void GetRelated(System.Management.ManagementOperationObserver watcher) { }
    public void GetRelated(System.Management.ManagementOperationObserver watcher, string relatedClass) { }
    public void GetRelated(System.Management.ManagementOperationObserver watcher, string relatedClass, string relationshipClass, string relationshipQualifier, string relatedQualifier, string relatedRole, string thisRole, bool classDefinitionsOnly, System.Management.EnumerationOptions options) { }
    public System.Management.ManagementObjectCollection GetRelated(string relatedClass) { return default(System.Management.ManagementObjectCollection); }
    public System.Management.ManagementObjectCollection GetRelated(string relatedClass, string relationshipClass, string relationshipQualifier, string relatedQualifier, string relatedRole, string thisRole, bool classDefinitionsOnly, System.Management.EnumerationOptions options) { return default(System.Management.ManagementObjectCollection); }
    public System.Management.ManagementObjectCollection GetRelationships() { return default(System.Management.ManagementObjectCollection); }
    public void GetRelationships(System.Management.ManagementOperationObserver watcher) { }
    public void GetRelationships(System.Management.ManagementOperationObserver watcher, string relationshipClass) { }
    public void GetRelationships(System.Management.ManagementOperationObserver watcher, string relationshipClass, string relationshipQualifier, string thisRole, bool classDefinitionsOnly, System.Management.EnumerationOptions options) { }
    public System.Management.ManagementObjectCollection GetRelationships(string relationshipClass) { return default(System.Management.ManagementObjectCollection); }
    public System.Management.ManagementObjectCollection GetRelationships(string relationshipClass, string relationshipQualifier, string thisRole, bool classDefinitionsOnly, System.Management.EnumerationOptions options) { return default(System.Management.ManagementObjectCollection); }
    public void InvokeMethod(System.Management.ManagementOperationObserver watcher, string methodName, System.Management.ManagementBaseObject inParameters, System.Management.InvokeMethodOptions options) { }
    public void InvokeMethod(System.Management.ManagementOperationObserver watcher, string methodName, System.Object[] args) { }
    public System.Management.ManagementBaseObject InvokeMethod(string methodName, System.Management.ManagementBaseObject inParameters, System.Management.InvokeMethodOptions options) { return default(System.Management.ManagementBaseObject); }
    public object InvokeMethod(string methodName, System.Object[] args) { return default(object); }
    public System.Management.ManagementPath Put() { return default(System.Management.ManagementPath); }
    public void Put(System.Management.ManagementOperationObserver watcher) { }
    public void Put(System.Management.ManagementOperationObserver watcher, System.Management.PutOptions options) { }
    public System.Management.ManagementPath Put(System.Management.PutOptions options) { return default(System.Management.ManagementPath); }
    public override string ToString() { return default(string); }
  }
  public partial class ManagementObjectCollection : System.Collections.ICollection, System.Collections.IEnumerable, System.IDisposable {
    internal ManagementObjectCollection() { }
    public int Count { get { return default(int); } }
    public bool IsSynchronized { get { return default(bool); } }
    public object SyncRoot { get { return default(object); } }
    public void CopyTo(System.Array array, int index) { }
    public void CopyTo(System.Management.ManagementBaseObject[] objectCollection, int index) { }
    public void Dispose() { }
    ~ManagementObjectCollection() { }
    public System.Management.ManagementObjectCollection.ManagementObjectEnumerator GetEnumerator() { return default(System.Management.ManagementObjectCollection.ManagementObjectEnumerator); }
    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { return default(System.Collections.IEnumerator); }
    public partial class ManagementObjectEnumerator : System.Collections.IEnumerator, System.IDisposable {
      internal ManagementObjectEnumerator() { }
      public System.Management.ManagementBaseObject Current { get { return default(System.Management.ManagementBaseObject); } }
      object System.Collections.IEnumerator.Current { get { return default(object); } }
      public void Dispose() { }
      ~ManagementObjectEnumerator() { }
      public bool MoveNext() { return default(bool); }
      public void Reset() { }
    }
  }
  [System.ComponentModel.ToolboxItemAttribute(false)]
  public partial class ManagementObjectSearcher : System.ComponentModel.Component {
    public ManagementObjectSearcher() { }
    public ManagementObjectSearcher(System.Management.ManagementScope scope, System.Management.ObjectQuery query) { }
    public ManagementObjectSearcher(System.Management.ManagementScope scope, System.Management.ObjectQuery query, System.Management.EnumerationOptions options) { }
    public ManagementObjectSearcher(System.Management.ObjectQuery query) { }
    public ManagementObjectSearcher(string queryString) { }
    public ManagementObjectSearcher(string scope, string queryString) { }
    public ManagementObjectSearcher(string scope, string queryString, System.Management.EnumerationOptions options) { }
    public System.Management.EnumerationOptions Options { get { return default(System.Management.EnumerationOptions); } set { } }
    public System.Management.ObjectQuery Query { get { return default(System.Management.ObjectQuery); } set { } }
    public System.Management.ManagementScope Scope { get { return default(System.Management.ManagementScope); } set { } }
    public System.Management.ManagementObjectCollection Get() { return default(System.Management.ManagementObjectCollection); }
    public void Get(System.Management.ManagementOperationObserver watcher) { }
  }
  public partial class ManagementOperationObserver {
    public ManagementOperationObserver() { }
    public event System.Management.CompletedEventHandler Completed { add { } remove { } }
    public event System.Management.ObjectPutEventHandler ObjectPut { add { } remove { } }
    public event System.Management.ObjectReadyEventHandler ObjectReady { add { } remove { } }
    public event System.Management.ProgressEventHandler Progress { add { } remove { } }
    public void Cancel() { }
  }
  [System.ComponentModel.TypeConverterAttribute(typeof(System.ComponentModel.ExpandableObjectConverter))]
  public abstract partial class ManagementOptions : System.ICloneable {
    internal ManagementOptions() { }
    public static readonly System.TimeSpan InfiniteTimeout;
    public System.Management.ManagementNamedValueCollection Context { get { return default(System.Management.ManagementNamedValueCollection); } set { } }
    public System.TimeSpan Timeout { get { return default(System.TimeSpan); } set { } }
    public abstract object Clone();
  }
  [System.ComponentModel.TypeConverterAttribute(typeof(System.Management.ManagementPathConverter))]
  public partial class ManagementPath : System.ICloneable {
    public ManagementPath() { }
    public ManagementPath(string path) { }
    [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
    public string ClassName { get { return default(string); } set { } }
    public static System.Management.ManagementPath DefaultPath { get { return default(System.Management.ManagementPath); } set { } }
    public bool IsClass { get { return default(bool); } }
    public bool IsInstance { get { return default(bool); } }
    public bool IsSingleton { get { return default(bool); } }
    [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
    public string NamespacePath { get { return default(string); } set { } }
    [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
    public string Path { get { return default(string); } set { } }
    [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
    public string RelativePath { get { return default(string); } set { } }
    [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
    public string Server { get { return default(string); } set { } }
    public System.Management.ManagementPath Clone() { return default(System.Management.ManagementPath); }
    public void SetAsClass() { }
    public void SetAsSingleton() { }
    object System.ICloneable.Clone() { return default(object); }
    public override string ToString() { return default(string); }
  }
  [System.ComponentModel.TypeConverterAttribute(typeof(System.Management.ManagementQueryConverter))]
  public abstract partial class ManagementQuery : System.ICloneable {
    internal ManagementQuery() { }
    public virtual string QueryLanguage { get { return default(string); } set { } }
    public virtual string QueryString { get { return default(string); } set { } }
    public abstract object Clone();
    protected internal virtual void ParseQuery(string query) { }
  }
  [System.ComponentModel.TypeConverterAttribute(typeof(System.Management.ManagementScopeConverter))]
  public partial class ManagementScope : System.ICloneable {
    public ManagementScope() { }
    public ManagementScope(System.Management.ManagementPath path) { }
    public ManagementScope(System.Management.ManagementPath path, System.Management.ConnectionOptions options) { }
    public ManagementScope(string path) { }
    public ManagementScope(string path, System.Management.ConnectionOptions options) { }
    public bool IsConnected { get { return default(bool); } }
    public System.Management.ConnectionOptions Options { get { return default(System.Management.ConnectionOptions); } set { } }
    public System.Management.ManagementPath Path { get { return default(System.Management.ManagementPath); } set { } }
    public System.Management.ManagementScope Clone() { return default(System.Management.ManagementScope); }
    public void Connect() { }
    object System.ICloneable.Clone() { return default(object); }
  }
  public enum ManagementStatus {
    AccessDenied = -2147217405,
    AggregatingByObject = -2147217315,
    AlreadyExists = -2147217383,
    AmendedObject = -2147217306,
    BackupRestoreWinmgmtRunning = -2147217312,
    BufferTooSmall = -2147217348,
    CallCanceled = -2147217358,
    CannotBeAbstract = -2147217307,
    CannotBeKey = -2147217377,
    CannotBeSingleton = -2147217364,
    CannotChangeIndexInheritance = -2147217328,
    CannotChangeKeyInheritance = -2147217335,
    CircularReference = -2147217337,
    ClassHasChildren = -2147217371,
    ClassHasInstances = -2147217370,
    ClientTooSlow = -2147217305,
    CriticalError = -2147217398,
    Different = 262147,
    DuplicateObjects = 262152,
    Failed = -2147217407,
    False = 1,
    IllegalNull = -2147217368,
    IllegalOperation = -2147217378,
    IncompleteClass = -2147217376,
    InitializationFailure = -2147217388,
    InvalidCimType = -2147217363,
    InvalidClass = -2147217392,
    InvalidContext = -2147217401,
    InvalidDuplicateParameter = -2147217341,
    InvalidFlavor = -2147217338,
    InvalidMethod = -2147217362,
    InvalidMethodParameters = -2147217361,
    InvalidNamespace = -2147217394,
    InvalidObject = -2147217393,
    InvalidObjectPath = -2147217350,
    InvalidOperation = -2147217386,
    InvalidOperator = -2147217309,
    InvalidParameter = -2147217400,
    InvalidParameterID = -2147217353,
    InvalidProperty = -2147217359,
    InvalidPropertyType = -2147217366,
    InvalidProviderRegistration = -2147217390,
    InvalidQualifier = -2147217342,
    InvalidQualifierType = -2147217367,
    InvalidQuery = -2147217385,
    InvalidQueryType = -2147217384,
    InvalidStream = -2147217397,
    InvalidSuperclass = -2147217395,
    InvalidSyntax = -2147217375,
    LocalCredentials = -2147217308,
    MarshalInvalidSignature = -2147217343,
    MarshalVersionMismatch = -2147217344,
    MethodDisabled = -2147217322,
    MethodNotImplemented = -2147217323,
    MissingAggregationList = -2147217317,
    MissingGroupWithin = -2147217318,
    MissingParameterID = -2147217354,
    NoError = 0,
    NoMoreData = 262149,
    NonconsecutiveParameterIDs = -2147217352,
    NondecoratedObject = -2147217374,
    NotAvailable = -2147217399,
    NotEventClass = -2147217319,
    NotFound = -2147217406,
    NotSupported = -2147217396,
    OperationCanceled = 262150,
    OutOfDiskSpace = -2147217349,
    OutOfMemory = -2147217402,
    OverrideNotAllowed = -2147217382,
    ParameterIDOnRetval = -2147217351,
    PartialResults = 262160,
    Pending = 262151,
    PrivilegeNotHeld = -2147217310,
    PropagatedMethod = -2147217356,
    PropagatedProperty = -2147217380,
    PropagatedQualifier = -2147217381,
    PropertyNotAnObject = -2147217316,
    ProviderFailure = -2147217404,
    ProviderLoadFailure = -2147217389,
    ProviderNotCapable = -2147217372,
    ProviderNotFound = -2147217391,
    QueryNotImplemented = -2147217369,
    QueueOverflow = -2147217311,
    ReadOnly = -2147217373,
    RefresherBusy = -2147217321,
    RegistrationTooBroad = -2147213311,
    RegistrationTooPrecise = -2147213310,
    ResetToDefault = 262146,
    ServerTooBusy = -2147217339,
    ShuttingDown = -2147217357,
    SystemProperty = -2147217360,
    Timedout = 262148,
    TooManyProperties = -2147217327,
    TooMuchData = -2147217340,
    TransportFailure = -2147217387,
    TypeMismatch = -2147217403,
    Unexpected = -2147217379,
    UninterpretableProviderQuery = -2147217313,
    UnknownObjectType = -2147217346,
    UnknownPacketType = -2147217345,
    UnparsableQuery = -2147217320,
    UnsupportedClassUpdate = -2147217336,
    UnsupportedParameter = -2147217355,
    UnsupportedPutExtension = -2147217347,
    UpdateOverrideNotAllowed = -2147217325,
    UpdatePropagatedMethod = -2147217324,
    UpdateTypeMismatch = -2147217326,
    ValueOutOfRange = -2147217365,
  }
  public partial class MethodData {
    internal MethodData() { }
    public System.Management.ManagementBaseObject InParameters { get { return default(System.Management.ManagementBaseObject); } }
    public string Name { get { return default(string); } }
    public string Origin { get { return default(string); } }
    public System.Management.ManagementBaseObject OutParameters { get { return default(System.Management.ManagementBaseObject); } }
    public System.Management.QualifierDataCollection Qualifiers { get { return default(System.Management.QualifierDataCollection); } }
  }
  public partial class MethodDataCollection : System.Collections.ICollection, System.Collections.IEnumerable {
    internal MethodDataCollection() { }
    public int Count { get { return default(int); } }
    public bool IsSynchronized { get { return default(bool); } }
    public virtual System.Management.MethodData this[string methodName] { get { return default(System.Management.MethodData); } }
    public object SyncRoot { get { return default(object); } }
    public virtual void Add(string methodName) { }
    public virtual void Add(string methodName, System.Management.ManagementBaseObject inParameters, System.Management.ManagementBaseObject outParameters) { }
    public void CopyTo(System.Array array, int index) { }
    public void CopyTo(System.Management.MethodData[] methodArray, int index) { }
    public System.Management.MethodDataCollection.MethodDataEnumerator GetEnumerator() { return default(System.Management.MethodDataCollection.MethodDataEnumerator); }
    public virtual void Remove(string methodName) { }
    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { return default(System.Collections.IEnumerator); }
    public partial class MethodDataEnumerator : System.Collections.IEnumerator {
      internal MethodDataEnumerator() { }
      public System.Management.MethodData Current { get { return default(System.Management.MethodData); } }
      object System.Collections.IEnumerator.Current { get { return default(object); } }
      public bool MoveNext() { return default(bool); }
      public void Reset() { }
    }
  }
  public partial class ObjectGetOptions : System.Management.ManagementOptions {
    public ObjectGetOptions() { }
    public ObjectGetOptions(System.Management.ManagementNamedValueCollection context) { }
    public ObjectGetOptions(System.Management.ManagementNamedValueCollection context, System.TimeSpan timeout, bool useAmendedQualifiers) { }
    public bool UseAmendedQualifiers { get { return default(bool); } set { } }
    public override object Clone() { return default(object); }
  }
  public partial class ObjectPutEventArgs : System.Management.ManagementEventArgs {
    internal ObjectPutEventArgs() { }
    public System.Management.ManagementPath Path { get { return default(System.Management.ManagementPath); } }
  }
  public delegate void ObjectPutEventHandler(object sender, System.Management.ObjectPutEventArgs e);
  public partial class ObjectQuery : System.Management.ManagementQuery {
    public ObjectQuery() { }
    public ObjectQuery(string query) { }
    public ObjectQuery(string language, string query) { }
    public override object Clone() { return default(object); }
  }
  public partial class ObjectReadyEventArgs : System.Management.ManagementEventArgs {
    internal ObjectReadyEventArgs() { }
    public System.Management.ManagementBaseObject NewObject { get { return default(System.Management.ManagementBaseObject); } }
  }
  public delegate void ObjectReadyEventHandler(object sender, System.Management.ObjectReadyEventArgs e);
  public partial class ProgressEventArgs : System.Management.ManagementEventArgs {
    internal ProgressEventArgs() { }
    public int Current { get { return default(int); } }
    public string Message { get { return default(string); } }
    public int UpperBound { get { return default(int); } }
  }
  public delegate void ProgressEventHandler(object sender, System.Management.ProgressEventArgs e);
  public partial class PropertyData {
    internal PropertyData() { }
    public bool IsArray { get { return default(bool); } }
    public bool IsLocal { get { return default(bool); } }
    public string Name { get { return default(string); } }
    public string Origin { get { return default(string); } }
    public System.Management.QualifierDataCollection Qualifiers { get { return default(System.Management.QualifierDataCollection); } }
    public System.Management.CimType Type { get { return default(System.Management.CimType); } }
    public object Value { get { return default(object); } set { } }
  }
  public partial class PropertyDataCollection : System.Collections.ICollection, System.Collections.IEnumerable {
    internal PropertyDataCollection() { }
    public int Count { get { return default(int); } }
    public bool IsSynchronized { get { return default(bool); } }
    public virtual System.Management.PropertyData this[string propertyName] { get { return default(System.Management.PropertyData); } }
    public object SyncRoot { get { return default(object); } }
    public void Add(string propertyName, System.Management.CimType propertyType, bool isArray) { }
    public virtual void Add(string propertyName, object propertyValue) { }
    public void Add(string propertyName, object propertyValue, System.Management.CimType propertyType) { }
    public void CopyTo(System.Array array, int index) { }
    public void CopyTo(System.Management.PropertyData[] propertyArray, int index) { }
    public System.Management.PropertyDataCollection.PropertyDataEnumerator GetEnumerator() { return default(System.Management.PropertyDataCollection.PropertyDataEnumerator); }
    public virtual void Remove(string propertyName) { }
    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { return default(System.Collections.IEnumerator); }
    public partial class PropertyDataEnumerator : System.Collections.IEnumerator {
      internal PropertyDataEnumerator() { }
      public System.Management.PropertyData Current { get { return default(System.Management.PropertyData); } }
      object System.Collections.IEnumerator.Current { get { return default(object); } }
      public bool MoveNext() { return default(bool); }
      public void Reset() { }
    }
  }
  public partial class PutOptions : System.Management.ManagementOptions {
    public PutOptions() { }
    public PutOptions(System.Management.ManagementNamedValueCollection context) { }
    public PutOptions(System.Management.ManagementNamedValueCollection context, System.TimeSpan timeout, bool useAmendedQualifiers, System.Management.PutType putType) { }
    public System.Management.PutType Type { get { return default(System.Management.PutType); } set { } }
    public bool UseAmendedQualifiers { get { return default(bool); } set { } }
    public override object Clone() { return default(object); }
  }
  public enum PutType {
    CreateOnly = 2,
    None = 0,
    UpdateOnly = 1,
    UpdateOrCreate = 3,
  }
  public partial class QualifierData {
    internal QualifierData() { }
    public bool IsAmended { get { return default(bool); } set { } }
    public bool IsLocal { get { return default(bool); } }
    public bool IsOverridable { get { return default(bool); } set { } }
    public string Name { get { return default(string); } }
    public bool PropagatesToInstance { get { return default(bool); } set { } }
    public bool PropagatesToSubclass { get { return default(bool); } set { } }
    public object Value { get { return default(object); } set { } }
  }
  public partial class QualifierDataCollection : System.Collections.ICollection, System.Collections.IEnumerable {
    internal QualifierDataCollection() { }
    public int Count { get { return default(int); } }
    public bool IsSynchronized { get { return default(bool); } }
    public virtual System.Management.QualifierData this[string qualifierName] { get { return default(System.Management.QualifierData); } }
    public object SyncRoot { get { return default(object); } }
    public virtual void Add(string qualifierName, object qualifierValue) { }
    public virtual void Add(string qualifierName, object qualifierValue, bool isAmended, bool propagatesToInstance, bool propagatesToSubclass, bool isOverridable) { }
    public void CopyTo(System.Array array, int index) { }
    public void CopyTo(System.Management.QualifierData[] qualifierArray, int index) { }
    public System.Management.QualifierDataCollection.QualifierDataEnumerator GetEnumerator() { return default(System.Management.QualifierDataCollection.QualifierDataEnumerator); }
    public virtual void Remove(string qualifierName) { }
    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { return default(System.Collections.IEnumerator); }
    public partial class QualifierDataEnumerator : System.Collections.IEnumerator {
      internal QualifierDataEnumerator() { }
      public System.Management.QualifierData Current { get { return default(System.Management.QualifierData); } }
      object System.Collections.IEnumerator.Current { get { return default(object); } }
      public bool MoveNext() { return default(bool); }
      public void Reset() { }
    }
  }
  public partial class RelatedObjectQuery : System.Management.WqlObjectQuery {
    public RelatedObjectQuery() { }
    public RelatedObjectQuery(bool isSchemaQuery, string sourceObject, string relatedClass, string relationshipClass, string relatedQualifier, string relationshipQualifier, string relatedRole, string thisRole) { }
    public RelatedObjectQuery(string queryOrSourceObject) { }
    public RelatedObjectQuery(string sourceObject, string relatedClass) { }
    public RelatedObjectQuery(string sourceObject, string relatedClass, string relationshipClass, string relatedQualifier, string relationshipQualifier, string relatedRole, string thisRole, bool classDefinitionsOnly) { }
    public bool ClassDefinitionsOnly { get { return default(bool); } set { } }
    public bool IsSchemaQuery { get { return default(bool); } set { } }
    public string RelatedClass { get { return default(string); } set { } }
    public string RelatedQualifier { get { return default(string); } set { } }
    public string RelatedRole { get { return default(string); } set { } }
    public string RelationshipClass { get { return default(string); } set { } }
    public string RelationshipQualifier { get { return default(string); } set { } }
    public string SourceObject { get { return default(string); } set { } }
    public string ThisRole { get { return default(string); } set { } }
    protected internal void BuildQuery() { }
    public override object Clone() { return default(object); }
    protected internal override void ParseQuery(string query) { }
  }
  public partial class RelationshipQuery : System.Management.WqlObjectQuery {
    public RelationshipQuery() { }
    public RelationshipQuery(bool isSchemaQuery, string sourceObject, string relationshipClass, string relationshipQualifier, string thisRole) { }
    public RelationshipQuery(string queryOrSourceObject) { }
    public RelationshipQuery(string sourceObject, string relationshipClass) { }
    public RelationshipQuery(string sourceObject, string relationshipClass, string relationshipQualifier, string thisRole, bool classDefinitionsOnly) { }
    public bool ClassDefinitionsOnly { get { return default(bool); } set { } }
    public bool IsSchemaQuery { get { return default(bool); } set { } }
    public string RelationshipClass { get { return default(string); } set { } }
    public string RelationshipQualifier { get { return default(string); } set { } }
    public string SourceObject { get { return default(string); } set { } }
    public string ThisRole { get { return default(string); } set { } }
    protected internal void BuildQuery() { }
    public override object Clone() { return default(object); }
    protected internal override void ParseQuery(string query) { }
  }
  public partial class SelectQuery : System.Management.WqlObjectQuery {
    public SelectQuery() { }
    public SelectQuery(bool isSchemaQuery, string condition) { }
    public SelectQuery(string queryOrClassName) { }
    public SelectQuery(string className, string condition) { }
    public SelectQuery(string className, string condition, System.String[] selectedProperties) { }
    public string ClassName { get { return default(string); } set { } }
    public string Condition { get { return default(string); } set { } }
    public bool IsSchemaQuery { get { return default(bool); } set { } }
    public override string QueryString { get { return default(string); } set { } }
    public System.Collections.Specialized.StringCollection SelectedProperties { get { return default(System.Collections.Specialized.StringCollection); } set { } }
    protected internal void BuildQuery() { }
    public override object Clone() { return default(object); }
    protected internal override void ParseQuery(string query) { }
  }
  public partial class StoppedEventArgs : System.Management.ManagementEventArgs {
    internal StoppedEventArgs() { }
    public System.Management.ManagementStatus Status { get { return default(System.Management.ManagementStatus); } }
  }
  public delegate void StoppedEventHandler(object sender, System.Management.StoppedEventArgs e);
  public enum TextFormat {
    CimDtd20 = 1,
    Mof = 0,
    WmiDtd20 = 2,
  }
  public partial class WqlEventQuery : System.Management.EventQuery {
    public WqlEventQuery() { }
    public WqlEventQuery(string queryOrEventClassName) { }
    public WqlEventQuery(string eventClassName, string condition) { }
    public WqlEventQuery(string eventClassName, string condition, System.TimeSpan groupWithinInterval) { }
    public WqlEventQuery(string eventClassName, string condition, System.TimeSpan groupWithinInterval, System.String[] groupByPropertyList) { }
    public WqlEventQuery(string eventClassName, System.TimeSpan withinInterval) { }
    public WqlEventQuery(string eventClassName, System.TimeSpan withinInterval, string condition) { }
    public WqlEventQuery(string eventClassName, System.TimeSpan withinInterval, string condition, System.TimeSpan groupWithinInterval, System.String[] groupByPropertyList, string havingCondition) { }
    public string Condition { get { return default(string); } set { } }
    public string EventClassName { get { return default(string); } set { } }
    public System.Collections.Specialized.StringCollection GroupByPropertyList { get { return default(System.Collections.Specialized.StringCollection); } set { } }
    public System.TimeSpan GroupWithinInterval { get { return default(System.TimeSpan); } set { } }
    public string HavingCondition { get { return default(string); } set { } }
    public override string QueryLanguage { get { return default(string); } }
    public override string QueryString { get { return default(string); } set { } }
    public System.TimeSpan WithinInterval { get { return default(System.TimeSpan); } set { } }
    protected internal void BuildQuery() { }
    public override object Clone() { return default(object); }
    protected internal override void ParseQuery(string query) { }
  }
  public partial class WqlObjectQuery : System.Management.ObjectQuery {
    public WqlObjectQuery() { }
    public WqlObjectQuery(string query) { }
    public override string QueryLanguage { get { return default(string); } }
    public override object Clone() { return default(object); }
  }
}
namespace System.Management.Instrumentation {
  [System.Management.Instrumentation.InstrumentationClassAttribute((System.Management.Instrumentation.InstrumentationType)(1))]
  public abstract partial class BaseEvent : System.Management.Instrumentation.IEvent {
    protected BaseEvent() { }
    public void Fire() { }
  }
  public partial class DefaultManagementProjectInstaller : System.Configuration.Install.Installer {
    public DefaultManagementProjectInstaller() { }
  }
  public partial interface IEvent {
    void Fire();
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(448))]
  public partial class IgnoreMemberAttribute : System.Attribute {
    public IgnoreMemberAttribute() { }
  }
  public partial interface IInstance {
    bool Published { get; set; }
  }
  [System.Management.Instrumentation.InstrumentationClassAttribute((System.Management.Instrumentation.InstrumentationType)(0))]
  public abstract partial class Instance : System.Management.Instrumentation.IInstance {
    protected Instance() { }
    [System.Management.Instrumentation.IgnoreMemberAttribute]
    public bool Published { get { return default(bool); } set { } }
  }
  public partial class Instrumentation {
    public Instrumentation() { }
    public static void Fire(object eventData) { }
    public static bool IsAssemblyRegistered(System.Reflection.Assembly assemblyToRegister) { return default(bool); }
    public static void Publish(object instanceData) { }
    public static void RegisterAssembly(System.Reflection.Assembly assemblyToRegister) { }
    public static void Revoke(object instanceData) { }
    public static void SetBatchSize(System.Type instrumentationClass, int batchSize) { }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(12))]
  public partial class InstrumentationClassAttribute : System.Attribute {
    public InstrumentationClassAttribute(System.Management.Instrumentation.InstrumentationType instrumentationType) { }
    public InstrumentationClassAttribute(System.Management.Instrumentation.InstrumentationType instrumentationType, string managedBaseClassName) { }
    public System.Management.Instrumentation.InstrumentationType InstrumentationType { get { return default(System.Management.Instrumentation.InstrumentationType); } }
    public string ManagedBaseClassName { get { return default(string); } }
  }
  public enum InstrumentationType {
    Abstract = 2,
    Event = 1,
    Instance = 0,
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(1))]
  public partial class InstrumentedAttribute : System.Attribute {
    public InstrumentedAttribute() { }
    public InstrumentedAttribute(string namespaceName) { }
    public InstrumentedAttribute(string namespaceName, string securityDescriptor) { }
    public string NamespaceName { get { return default(string); } }
    public string SecurityDescriptor { get { return default(string); } }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(460))]
  public partial class ManagedNameAttribute : System.Attribute {
    public ManagedNameAttribute(string name) { }
    public string Name { get { return default(string); } }
  }
  public partial class ManagementInstaller : System.Configuration.Install.Installer {
    public ManagementInstaller() { }
    public override string HelpText { get { return default(string); } }
    public override void Commit(System.Collections.IDictionary savedState) { }
    public override void Install(System.Collections.IDictionary savedState) { }
    public override void Rollback(System.Collections.IDictionary savedState) { }
    public override void Uninstall(System.Collections.IDictionary savedState) { }
  }
}
