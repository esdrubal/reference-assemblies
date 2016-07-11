namespace System.AddIn {
  [System.AttributeUsageAttribute((System.AttributeTargets)(4))]
  public sealed partial class AddInAttribute : System.Attribute {
    public AddInAttribute(string name) { }
    public string Description { get { return default(string); } set { } }
    public string Name { get { return default(string); } }
    public string Publisher { get { return default(string); } set { } }
    public string Version { get { return default(string); } set { } }
  }
}
namespace System.AddIn.Hosting {
  public sealed partial class AddInController {
    internal AddInController() { }
    public System.AddIn.Hosting.AddInEnvironment AddInEnvironment { get { return default(System.AddIn.Hosting.AddInEnvironment); } }
    public System.AppDomain AppDomain { get { return default(System.AppDomain); } }
    public System.AddIn.Hosting.AddInToken Token { get { return default(System.AddIn.Hosting.AddInToken); } }
    public static System.AddIn.Hosting.AddInController GetAddInController(object addIn) { return default(System.AddIn.Hosting.AddInController); }
    [System.Runtime.ConstrainedExecution.ReliabilityContractAttribute((System.Runtime.ConstrainedExecution.Consistency)(3), (System.Runtime.ConstrainedExecution.Cer)(1))]
    public void Shutdown() { }
  }
  public sealed partial class AddInEnvironment {
    public AddInEnvironment(System.AppDomain appDomain) { }
    public System.AddIn.Hosting.AddInProcess Process { get { return default(System.AddIn.Hosting.AddInProcess); } }
  }
  public sealed partial class AddInProcess {
    [System.Security.SecurityCriticalAttribute]
    [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.Demand, Name="FullTrust")]
    public AddInProcess() { }
    [System.Security.SecurityCriticalAttribute]
    [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.Demand, Name="FullTrust")]
    public AddInProcess(System.AddIn.Hosting.Platform platform) { }
    public bool IsCurrentProcess { get { return default(bool); } }
    public bool KeepAlive { get { return default(bool); } set { } }
    public System.AddIn.Hosting.Platform Platform { get { return default(System.AddIn.Hosting.Platform); } }
    public int ProcessId { get { return default(int); } }
    public System.TimeSpan StartupTimeout { get { return default(System.TimeSpan); } set { } }
    public event System.EventHandler<System.ComponentModel.CancelEventArgs> ShuttingDown { add { } remove { } }
    public bool Shutdown() { return default(bool); }
    [System.Security.SecurityCriticalAttribute]
    public bool Start() { return default(bool); }
  }
  public enum AddInSecurityLevel {
    FullTrust = 2,
    Host = 3,
    Internet = 0,
    Intranet = 1,
  }
  public partial class AddInSegmentDirectoryNotFoundException : System.Exception {
    public AddInSegmentDirectoryNotFoundException() { }
    protected AddInSegmentDirectoryNotFoundException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public AddInSegmentDirectoryNotFoundException(string message) { }
    public AddInSegmentDirectoryNotFoundException(string message, System.Exception innerException) { }
  }
  public enum AddInSegmentType {
    AddIn = 5,
    AddInSideAdapter = 3,
    AddInView = 4,
    Contract = 2,
    HostSideAdapter = 1,
    HostViewOfAddIn = 0,
  }
  public static partial class AddInStore {
    [System.Security.SecurityCriticalAttribute]
    public static System.Collections.ObjectModel.Collection<System.AddIn.Hosting.AddInToken> FindAddIn(System.Type hostViewOfAddIn, string pipelineRootFolderPath, string addInFilePath, string addInTypeName) { return default(System.Collections.ObjectModel.Collection<System.AddIn.Hosting.AddInToken>); }
    [System.Security.SecuritySafeCriticalAttribute]
    public static System.Collections.ObjectModel.Collection<System.AddIn.Hosting.AddInToken> FindAddIns(System.Type hostViewOfAddIn, System.AddIn.Hosting.PipelineStoreLocation location) { return default(System.Collections.ObjectModel.Collection<System.AddIn.Hosting.AddInToken>); }
    [System.Security.SecurityCriticalAttribute]
    public static System.Collections.ObjectModel.Collection<System.AddIn.Hosting.AddInToken> FindAddIns(System.Type hostViewOfAddIn, System.AddIn.Hosting.PipelineStoreLocation location, params System.String[] addInFolderPaths) { return default(System.Collections.ObjectModel.Collection<System.AddIn.Hosting.AddInToken>); }
    [System.Security.SecurityCriticalAttribute]
    public static System.Collections.ObjectModel.Collection<System.AddIn.Hosting.AddInToken> FindAddIns(System.Type hostViewOfAddIn, string pipelineRootFolderPath, params System.String[] addInFolderPaths) { return default(System.Collections.ObjectModel.Collection<System.AddIn.Hosting.AddInToken>); }
    [System.Security.SecuritySafeCriticalAttribute]
    public static System.String[] Rebuild(System.AddIn.Hosting.PipelineStoreLocation location) { return default(System.String[]); }
    [System.Security.SecurityCriticalAttribute]
    public static System.String[] Rebuild(string pipelineRootFolderPath) { return default(System.String[]); }
    [System.Security.SecurityCriticalAttribute]
    public static System.String[] RebuildAddIns(string addInsFolderPath) { return default(System.String[]); }
    [System.Security.SecuritySafeCriticalAttribute]
    public static System.String[] Update(System.AddIn.Hosting.PipelineStoreLocation location) { return default(System.String[]); }
    [System.Security.SecurityCriticalAttribute]
    public static System.String[] Update(string pipelineRootFolderPath) { return default(System.String[]); }
    [System.Security.SecurityCriticalAttribute]
    public static System.String[] UpdateAddIns(string addInsFolderPath) { return default(System.String[]); }
  }
  public sealed partial class AddInToken : System.Collections.Generic.IEnumerable<System.AddIn.Hosting.QualificationDataItem>, System.Collections.IEnumerable {
    internal AddInToken() { }
    public string AddInFullName { get { return default(string); } }
    public System.Reflection.AssemblyName AssemblyName { get { return default(System.Reflection.AssemblyName); } }
    public string Description { get { return default(string); } }
    public static bool EnableDirectConnect { get { return default(bool); } set { } }
    public string Name { get { return default(string); } }
    public string Publisher { get { return default(string); } }
    public System.Collections.Generic.IDictionary<System.AddIn.Hosting.AddInSegmentType, System.Collections.Generic.IDictionary<System.String, System.String>> QualificationData { get { return default(System.Collections.Generic.IDictionary<System.AddIn.Hosting.AddInSegmentType, System.Collections.Generic.IDictionary<System.String, System.String>>); } }
    public string Version { get { return default(string); } }
    public T Activate<T>(System.AddIn.Hosting.AddInEnvironment environment) { return default(T); }
    [System.Security.SecuritySafeCriticalAttribute]
    [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.Demand, Name="FullTrust")]
    public T Activate<T>(System.AddIn.Hosting.AddInProcess process, System.AddIn.Hosting.AddInSecurityLevel level) { return default(T); }
    [System.Security.SecuritySafeCriticalAttribute]
    [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.Demand, Name="FullTrust")]
    public T Activate<T>(System.AddIn.Hosting.AddInProcess process, System.Security.PermissionSet permissionSet) { return default(T); }
    public T Activate<T>(System.AddIn.Hosting.AddInSecurityLevel trustLevel) { return default(T); }
    public T Activate<T>(System.AddIn.Hosting.AddInSecurityLevel trustLevel, string appDomainName) { return default(T); }
    public T Activate<T>(System.AppDomain target) { return default(T); }
    public T Activate<T>(System.Security.PermissionSet permissions) { return default(T); }
    public override bool Equals(object obj) { return default(bool); }
    public System.Collections.Generic.IEnumerator<System.AddIn.Hosting.QualificationDataItem> GetEnumerator() { return default(System.Collections.Generic.IEnumerator<System.AddIn.Hosting.QualificationDataItem>); }
    public override int GetHashCode() { return default(int); }
    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { return default(System.Collections.IEnumerator); }
    public override string ToString() { return default(string); }
  }
  public partial class InvalidPipelineStoreException : System.Exception {
    public InvalidPipelineStoreException() { }
    protected InvalidPipelineStoreException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public InvalidPipelineStoreException(string message) { }
    public InvalidPipelineStoreException(string message, System.Exception innerException) { }
  }
  public enum PipelineStoreLocation {
    ApplicationBase = 0,
  }
  public enum Platform {
    AnyCpu = 1,
    ARM = 4,
    Host = 0,
    X64 = 3,
    X86 = 2,
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct QualificationDataItem {
    public string Name { get { return default(string); } }
    public System.AddIn.Hosting.AddInSegmentType Segment { get { return default(System.AddIn.Hosting.AddInSegmentType); } }
    public string Value { get { return default(string); } }
    public override bool Equals(object obj) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public static bool operator ==(System.AddIn.Hosting.QualificationDataItem item1, System.AddIn.Hosting.QualificationDataItem item2) { return default(bool); }
    public static bool operator !=(System.AddIn.Hosting.QualificationDataItem item1, System.AddIn.Hosting.QualificationDataItem item2) { return default(bool); }
  }
}
namespace System.AddIn.Pipeline {
  [System.AttributeUsageAttribute((System.AttributeTargets)(4))]
  public sealed partial class AddInAdapterAttribute : System.Attribute {
    public AddInAdapterAttribute() { }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(1028))]
  public sealed partial class AddInBaseAttribute : System.Attribute {
    public AddInBaseAttribute() { }
    public System.Type[] ActivatableAs { get { return default(System.Type[]); } set { } }
  }
  public static partial class CollectionAdapters {
    public static System.Collections.Generic.IList<T> ToIList<T>(System.AddIn.Contract.IListContract<T> collection) { return default(System.Collections.Generic.IList<T>); }
    public static System.Collections.Generic.IList<TView> ToIList<TContract, TView>(System.AddIn.Contract.IListContract<TContract> collection, System.Converter<TContract, TView> contractViewAdapter, System.Converter<TView, TContract> viewContractAdapter) { return default(System.Collections.Generic.IList<TView>); }
    public static System.AddIn.Contract.IListContract<T> ToIListContract<T>(System.Collections.Generic.IList<T> collection) { return default(System.AddIn.Contract.IListContract<T>); }
    public static System.AddIn.Contract.IListContract<TContract> ToIListContract<TView, TContract>(System.Collections.Generic.IList<TView> collection, System.Converter<TView, TContract> viewContractAdapter, System.Converter<TContract, TView> contractViewAdapter) { return default(System.AddIn.Contract.IListContract<TContract>); }
  }
  public static partial class ContractAdapter {
    [System.Security.SecuritySafeCriticalAttribute]
    public static TView ContractToViewAdapter<TView>(System.AddIn.Pipeline.ContractHandle contract, System.AddIn.Hosting.PipelineStoreLocation location) { return default(TView); }
    [System.Security.SecuritySafeCriticalAttribute]
    public static TView ContractToViewAdapter<TView>(System.AddIn.Pipeline.ContractHandle contract, string pipelineRoot) { return default(TView); }
    public static System.AddIn.Pipeline.ContractHandle ViewToContractAdapter(object view) { return default(System.AddIn.Pipeline.ContractHandle); }
  }
  public partial class ContractBase : System.MarshalByRefObject, System.AddIn.Contract.IContract, System.Runtime.Remoting.Lifetime.ISponsor {
    public ContractBase() { }
    public int AcquireLifetimeToken() { return default(int); }
    public virtual int GetRemoteHashCode() { return default(int); }
    protected virtual void OnFinalRevoke() { }
    public virtual System.AddIn.Contract.IContract QueryContract(string contractIdentifier) { return default(System.AddIn.Contract.IContract); }
    public virtual bool RemoteEquals(System.AddIn.Contract.IContract contract) { return default(bool); }
    public virtual string RemoteToString() { return default(string); }
    [System.Security.SecurityCriticalAttribute]
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(4096))]
    public System.TimeSpan Renewal(System.Runtime.Remoting.Lifetime.ILease lease) { return default(System.TimeSpan); }
    [System.Security.SecuritySafeCriticalAttribute]
    public void RevokeLifetimeToken(int token) { }
  }
  public partial class ContractHandle : System.IDisposable {
    public ContractHandle(System.AddIn.Contract.IContract contract) { }
    public System.AddIn.Contract.IContract Contract { get { return default(System.AddIn.Contract.IContract); } }
    public static System.AddIn.Contract.IContract AppDomainOwner(System.AppDomain domain) { return default(System.AddIn.Contract.IContract); }
    public static bool ContractOwnsAppDomain(System.AddIn.Contract.IContract contract, System.AppDomain domain) { return default(bool); }
    public void Dispose() { }
    protected virtual void Dispose(bool disposing) { }
    ~ContractHandle() { }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(4))]
  public sealed partial class HostAdapterAttribute : System.Attribute {
    public HostAdapterAttribute() { }
  }
}
