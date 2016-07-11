namespace System.Net {
  [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
  [System.ObsoleteAttribute("This API supports the .NET Framework infrastructure and is not intended to be used directly from your code.", true)]
  public partial interface INetworkProgress {
    event System.EventHandler<System.Net.NetworkProgressChangedEventArgs> ProgressChanged;
    event System.EventHandler<System.Net.NetworkProgressChangedEventArgs> ProgressCompleted;
    event System.EventHandler<System.Net.NetworkProgressChangedEventArgs> ProgressFailed;
  }
  public partial class IPEndPointCollection : System.Collections.ObjectModel.Collection<System.Net.IPEndPoint> {
    public IPEndPointCollection() { }
    protected override void InsertItem(int index, System.Net.IPEndPoint item) { }
    protected override void SetItem(int index, System.Net.IPEndPoint item) { }
  }
  [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
  [System.ObsoleteAttribute("This API supports the .NET Framework infrastructure and is not intended to be used directly from your code.", true)]
  public partial interface IUnsafeWebRequestCreate {
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.ObsoleteAttribute("This API supports the .NET Framework infrastructure and is not intended to be used directly from your code.", true)]
    System.Net.WebRequest Create(System.Uri uri);
  }
  [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
  [System.ObsoleteAttribute("This API supports the .NET Framework infrastructure and is not intended to be used directly from your code.", true)]
  public partial class NetworkProgressChangedEventArgs : System.ComponentModel.ProgressChangedEventArgs {
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.ObsoleteAttribute("This API supports the .NET Framework infrastructure and is not intended to be used directly from your code.", true)]
    public NetworkProgressChangedEventArgs(int percentage, int processedBytes, int totalBytes, object userState) : base (default(int), default(object)) { }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.ObsoleteAttribute("This API supports the .NET Framework infrastructure and is not intended to be used directly from your code.", true)]
    public int ProcessedBytes { get { return default(int); } }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.ObsoleteAttribute("This API supports the .NET Framework infrastructure and is not intended to be used directly from your code.", true)]
    public int TotalBytes { get { return default(int); } }
  }
  [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
  [System.ObsoleteAttribute("This API supports the .NET Framework infrastructure and is not intended to be used directly from your code.", true)]
  public static partial class UiSynchronizationContext {
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.ObsoleteAttribute("This API supports the .NET Framework infrastructure and is not intended to be used directly from your code.", true)]
    public static System.Threading.SynchronizationContext Current { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Threading.SynchronizationContext); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.ObsoleteAttribute("This API supports the .NET Framework infrastructure and is not intended to be used directly from your code.", true)]
    public static int ManagedUiThreadId { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(int); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
  }
}
namespace System.Net.PeerToPeer {
  public partial class Cloud : System.IEquatable<System.Net.PeerToPeer.Cloud>, System.Runtime.Serialization.ISerializable {
    public static readonly System.Net.PeerToPeer.Cloud AllLinkLocal;
    public static readonly System.Net.PeerToPeer.Cloud Available;
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(128))]
    protected Cloud(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public static System.Net.PeerToPeer.Cloud Global { get { return default(System.Net.PeerToPeer.Cloud); } }
    public string Name { get { return default(string); } }
    public System.Net.PeerToPeer.PnrpScope Scope { get { return default(System.Net.PeerToPeer.PnrpScope); } }
    public int ScopeId { get { return default(int); } }
    public bool Equals(System.Net.PeerToPeer.Cloud other) { return default(bool); }
    public override bool Equals(object obj) { return default(bool); }
    public static System.Net.PeerToPeer.CloudCollection GetAvailableClouds() { return default(System.Net.PeerToPeer.CloudCollection); }
    public static System.Net.PeerToPeer.Cloud GetCloudByName(string cloudName) { return default(System.Net.PeerToPeer.Cloud); }
    public override int GetHashCode() { return default(int); }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, SerializationFormatter=true)]
    protected virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    [System.Security.SecurityCriticalAttribute]
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(128), SerializationFormatter=true)]
    void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public override string ToString() { return default(string); }
  }
  public partial class CloudCollection : System.Collections.ObjectModel.Collection<System.Net.PeerToPeer.Cloud> {
    public CloudCollection() { }
    protected override void InsertItem(int index, System.Net.PeerToPeer.Cloud item) { }
    protected override void SetItem(int index, System.Net.PeerToPeer.Cloud item) { }
  }
  public partial class PeerName : System.IEquatable<System.Net.PeerToPeer.PeerName>, System.Runtime.Serialization.ISerializable {
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(128))]
    protected PeerName(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public PeerName(string remotePeerName) { }
    [System.Security.SecurityCriticalAttribute]
    public PeerName(string classifier, System.Net.PeerToPeer.PeerNameType peerNameType) { }
    public string Authority { get { return default(string); } }
    public string Classifier { get { return default(string); } }
    public bool IsSecured { get { return default(bool); } }
    public string PeerHostName { [System.Security.SecurityCriticalAttribute]get { return default(string); } }
    [System.Security.SecurityCriticalAttribute]
    public static System.Net.PeerToPeer.PeerName CreateFromPeerHostName(string peerHostName) { return default(System.Net.PeerToPeer.PeerName); }
    [System.Security.SecurityCriticalAttribute]
    public static System.Net.PeerToPeer.PeerName CreateRelativePeerName(System.Net.PeerToPeer.PeerName peerName, string classifier) { return default(System.Net.PeerToPeer.PeerName); }
    public bool Equals(System.Net.PeerToPeer.PeerName other) { return default(bool); }
    public override bool Equals(object obj) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, SerializationFormatter=true)]
    protected virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    [System.Security.SecurityCriticalAttribute]
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(128), SerializationFormatter=true)]
    void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public override string ToString() { return default(string); }
  }
  public partial class PeerNameRecord : System.Runtime.Serialization.ISerializable {
    public PeerNameRecord() { }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(128))]
    protected PeerNameRecord(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public string Comment { get { return default(string); } set { } }
    public System.Byte[] Data { get { return default(System.Byte[]); } set { } }
    public System.Net.IPEndPointCollection EndPointCollection { get { return default(System.Net.IPEndPointCollection); } }
    public System.Net.PeerToPeer.PeerName PeerName { get { return default(System.Net.PeerToPeer.PeerName); } set { } }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, SerializationFormatter=true)]
    protected virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    [System.Security.SecurityCriticalAttribute]
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(128), SerializationFormatter=true)]
    void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
  }
  public partial class PeerNameRecordCollection : System.Collections.ObjectModel.Collection<System.Net.PeerToPeer.PeerNameRecord> {
    public PeerNameRecordCollection() { }
    protected override void InsertItem(int index, System.Net.PeerToPeer.PeerNameRecord item) { }
    protected override void SetItem(int index, System.Net.PeerToPeer.PeerNameRecord item) { }
  }
  public partial class PeerNameRegistration : System.IDisposable, System.Runtime.Serialization.ISerializable {
    public PeerNameRegistration() { }
    public PeerNameRegistration(System.Net.PeerToPeer.PeerName name, int port) { }
    public PeerNameRegistration(System.Net.PeerToPeer.PeerName name, int port, System.Net.PeerToPeer.Cloud cloud) { }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(128))]
    protected PeerNameRegistration(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public System.Net.PeerToPeer.Cloud Cloud { get { return default(System.Net.PeerToPeer.Cloud); } set { } }
    public string Comment { get { return default(string); } set { } }
    public System.Byte[] Data { get { return default(System.Byte[]); } set { } }
    public System.Net.IPEndPointCollection EndPointCollection { get { return default(System.Net.IPEndPointCollection); } }
    public System.Net.PeerToPeer.PeerName PeerName { get { return default(System.Net.PeerToPeer.PeerName); } set { } }
    public int Port { get { return default(int); } set { } }
    public bool UseAutoEndPointSelection { get { return default(bool); } set { } }
    public void Dispose() { }
    protected virtual void Dispose(bool disposing) { }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, SerializationFormatter=true)]
    protected virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public bool IsRegistered() { return default(bool); }
    [System.Security.SecurityCriticalAttribute]
    public void Start() { }
    [System.Security.SecurityCriticalAttribute]
    public void Stop() { }
    [System.Security.SecurityCriticalAttribute]
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(128), SerializationFormatter=true)]
    void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    [System.Security.SecurityCriticalAttribute]
    public void Update() { }
  }
  public partial class PeerNameResolver {
    public PeerNameResolver() { }
    public event System.EventHandler<System.Net.PeerToPeer.ResolveCompletedEventArgs> ResolveCompleted { add { } remove { } }
    public event System.EventHandler<System.Net.PeerToPeer.ResolveProgressChangedEventArgs> ResolveProgressChanged { add { } remove { } }
    protected void OnResolveCompleted(System.Net.PeerToPeer.ResolveCompletedEventArgs e) { }
    protected void OnResolveProgressChanged(System.Net.PeerToPeer.ResolveProgressChangedEventArgs e) { }
    public System.Net.PeerToPeer.PeerNameRecordCollection Resolve(System.Net.PeerToPeer.PeerName peerName) { return default(System.Net.PeerToPeer.PeerNameRecordCollection); }
    public System.Net.PeerToPeer.PeerNameRecordCollection Resolve(System.Net.PeerToPeer.PeerName peerName, int maxRecords) { return default(System.Net.PeerToPeer.PeerNameRecordCollection); }
    public System.Net.PeerToPeer.PeerNameRecordCollection Resolve(System.Net.PeerToPeer.PeerName peerName, System.Net.PeerToPeer.Cloud cloud) { return default(System.Net.PeerToPeer.PeerNameRecordCollection); }
    [System.Security.SecurityCriticalAttribute]
    public System.Net.PeerToPeer.PeerNameRecordCollection Resolve(System.Net.PeerToPeer.PeerName peerName, System.Net.PeerToPeer.Cloud cloud, int maxRecords) { return default(System.Net.PeerToPeer.PeerNameRecordCollection); }
    [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, ExternalThreading=true)]
    public void ResolveAsync(System.Net.PeerToPeer.PeerName peerName, int maxRecords, object userState) { }
    [System.Security.SecurityCriticalAttribute]
    [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, ExternalThreading=true)]
    public void ResolveAsync(System.Net.PeerToPeer.PeerName peerName, System.Net.PeerToPeer.Cloud cloud, int maxRecords, object userState) { }
    [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, ExternalThreading=true)]
    public void ResolveAsync(System.Net.PeerToPeer.PeerName peerName, System.Net.PeerToPeer.Cloud cloud, object userState) { }
    [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, ExternalThreading=true)]
    public void ResolveAsync(System.Net.PeerToPeer.PeerName peerName, object userState) { }
    [System.Security.SecurityCriticalAttribute]
    public void ResolveAsyncCancel(object userState) { }
  }
  public enum PeerNameType {
    Secured = 0,
    Unsecured = 1,
  }
  public partial class PeerToPeerException : System.Exception, System.Runtime.Serialization.ISerializable {
    public PeerToPeerException() { }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(128))]
    protected PeerToPeerException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public PeerToPeerException(string message) { }
    public PeerToPeerException(string message, System.Exception innerException) { }
    [System.Security.SecurityCriticalAttribute]
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(128))]
    public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    [System.Security.SecurityCriticalAttribute]
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(128))]
    void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
  }
  public sealed partial class PnrpPermission : System.Security.CodeAccessPermission, System.Security.Permissions.IUnrestrictedPermission {
    public PnrpPermission(System.Security.Permissions.PermissionState state) { }
    public override System.Security.IPermission Copy() { return default(System.Security.IPermission); }
    public override void FromXml(System.Security.SecurityElement e) { }
    public override System.Security.IPermission Intersect(System.Security.IPermission target) { return default(System.Security.IPermission); }
    public override bool IsSubsetOf(System.Security.IPermission target) { return default(bool); }
    public bool IsUnrestricted() { return default(bool); }
    public override System.Security.SecurityElement ToXml() { return default(System.Security.SecurityElement); }
    public override System.Security.IPermission Union(System.Security.IPermission target) { return default(System.Security.IPermission); }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(109), AllowMultiple=true, Inherited=false)]
  public sealed partial class PnrpPermissionAttribute : System.Security.Permissions.CodeAccessSecurityAttribute {
    public PnrpPermissionAttribute(System.Security.Permissions.SecurityAction action) : base (default(System.Security.Permissions.SecurityAction)) { }
    public override System.Security.IPermission CreatePermission() { return default(System.Security.IPermission); }
  }
  public enum PnrpScope {
    All = 0,
    Global = 1,
    LinkLocal = 3,
    SiteLocal = 2,
  }
  public partial class ResolveCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
    public ResolveCompletedEventArgs(System.Net.PeerToPeer.PeerNameRecordCollection peerNameRecordCollection, System.Exception error, bool canceled, object userToken) { }
    public System.Net.PeerToPeer.PeerNameRecordCollection PeerNameRecordCollection { get { return default(System.Net.PeerToPeer.PeerNameRecordCollection); } }
  }
  public partial class ResolveProgressChangedEventArgs : System.ComponentModel.ProgressChangedEventArgs {
    public ResolveProgressChangedEventArgs(System.Net.PeerToPeer.PeerNameRecord peerNameRecord, object userToken) : base (default(int), default(object)) { }
    public System.Net.PeerToPeer.PeerNameRecord PeerNameRecord { get { return default(System.Net.PeerToPeer.PeerNameRecord); } }
  }
}
namespace System.Net.PeerToPeer.Collaboration {
  public partial class ApplicationChangedEventArgs : System.EventArgs {
    internal ApplicationChangedEventArgs() { }
    public System.Net.PeerToPeer.Collaboration.PeerApplication PeerApplication { get { return default(System.Net.PeerToPeer.Collaboration.PeerApplication); } }
    public System.Net.PeerToPeer.Collaboration.PeerChangeType PeerChangeType { get { return default(System.Net.PeerToPeer.Collaboration.PeerChangeType); } }
    public System.Net.PeerToPeer.Collaboration.PeerContact PeerContact { get { return default(System.Net.PeerToPeer.Collaboration.PeerContact); } }
    public System.Net.PeerToPeer.Collaboration.PeerEndPoint PeerEndPoint { get { return default(System.Net.PeerToPeer.Collaboration.PeerEndPoint); } }
  }
  public sealed partial class ContactManager : System.IDisposable {
    internal ContactManager() { }
    public static System.Net.PeerToPeer.Collaboration.PeerContact LocalContact { [System.Security.SecurityCriticalAttribute]get { return default(System.Net.PeerToPeer.Collaboration.PeerContact); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute(null)]
    [System.ComponentModel.DescriptionAttribute("SynchronizingObject")]
    public System.ComponentModel.ISynchronizeInvoke SynchronizingObject { get { return default(System.ComponentModel.ISynchronizeInvoke); } set { } }
    public event System.EventHandler<System.Net.PeerToPeer.Collaboration.ApplicationChangedEventArgs> ApplicationChanged { add { } remove { } }
    public event System.EventHandler<System.Net.PeerToPeer.Collaboration.CreateContactCompletedEventArgs> CreateContactCompleted { add { } remove { } }
    public event System.EventHandler<System.Net.PeerToPeer.Collaboration.NameChangedEventArgs> NameChanged { add { } remove { } }
    public event System.EventHandler<System.Net.PeerToPeer.Collaboration.ObjectChangedEventArgs> ObjectChanged { add { } remove { } }
    public event System.EventHandler<System.Net.PeerToPeer.Collaboration.PresenceChangedEventArgs> PresenceChanged { add { } remove { } }
    public event System.EventHandler<System.Net.PeerToPeer.Collaboration.SubscriptionListChangedEventArgs> SubscriptionListChanged { add { } remove { } }
    [System.Security.SecurityCriticalAttribute]
    public void AddContact(System.Net.PeerToPeer.Collaboration.PeerContact peerContact) { }
    [System.Security.SecurityCriticalAttribute]
    public System.Net.PeerToPeer.Collaboration.PeerContact CreateContact(System.Net.PeerToPeer.Collaboration.PeerNearMe peerNearMe) { return default(System.Net.PeerToPeer.Collaboration.PeerContact); }
    public void CreateContactAsync(System.Net.PeerToPeer.Collaboration.PeerNearMe peerNearMe, object userToken) { }
    public void DeleteContact(System.Net.PeerToPeer.Collaboration.PeerContact peerContact) { }
    [System.Security.SecurityCriticalAttribute]
    public void DeleteContact(System.Net.PeerToPeer.PeerName peerName) { }
    [System.Security.SecurityCriticalAttribute]
    public void Dispose() { }
    [System.Security.SecurityCriticalAttribute]
    public System.Net.PeerToPeer.Collaboration.PeerContact GetContact(System.Net.PeerToPeer.PeerName peerName) { return default(System.Net.PeerToPeer.Collaboration.PeerContact); }
    [System.Security.SecurityCriticalAttribute]
    public System.Net.PeerToPeer.Collaboration.PeerContactCollection GetContacts() { return default(System.Net.PeerToPeer.Collaboration.PeerContactCollection); }
    [System.Security.SecurityCriticalAttribute]
    public void UpdateContact(System.Net.PeerToPeer.Collaboration.PeerContact peerContact) { }
  }
  public partial class CreateContactCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
    internal CreateContactCompletedEventArgs() { }
    public System.Net.PeerToPeer.Collaboration.PeerContact PeerContact { get { return default(System.Net.PeerToPeer.Collaboration.PeerContact); } }
  }
  public partial class InviteCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
    internal InviteCompletedEventArgs() { }
    public System.Net.PeerToPeer.Collaboration.PeerInvitationResponse InviteResponse { get { return default(System.Net.PeerToPeer.Collaboration.PeerInvitationResponse); } }
  }
  public partial class NameChangedEventArgs : System.EventArgs {
    internal NameChangedEventArgs() { }
    public string Name { get { return default(string); } }
    public System.Net.PeerToPeer.Collaboration.PeerContact PeerContact { get { return default(System.Net.PeerToPeer.Collaboration.PeerContact); } }
    public System.Net.PeerToPeer.Collaboration.PeerEndPoint PeerEndPoint { get { return default(System.Net.PeerToPeer.Collaboration.PeerEndPoint); } }
  }
  public partial class ObjectChangedEventArgs : System.EventArgs {
    internal ObjectChangedEventArgs() { }
    public System.Net.PeerToPeer.Collaboration.PeerChangeType PeerChangeType { get { return default(System.Net.PeerToPeer.Collaboration.PeerChangeType); } }
    public System.Net.PeerToPeer.Collaboration.PeerContact PeerContact { get { return default(System.Net.PeerToPeer.Collaboration.PeerContact); } }
    public System.Net.PeerToPeer.Collaboration.PeerEndPoint PeerEndPoint { get { return default(System.Net.PeerToPeer.Collaboration.PeerEndPoint); } }
    public System.Net.PeerToPeer.Collaboration.PeerObject PeerObject { get { return default(System.Net.PeerToPeer.Collaboration.PeerObject); } }
  }
  public abstract partial class Peer : System.IDisposable, System.IEquatable<System.Net.PeerToPeer.Collaboration.Peer>, System.Runtime.Serialization.ISerializable {
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(128))]
    protected Peer(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
    public bool IsOnline { get { return default(bool); } }
    public virtual System.Net.PeerToPeer.Collaboration.PeerEndPointCollection PeerEndPoints { get { return default(System.Net.PeerToPeer.Collaboration.PeerEndPointCollection); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute(null)]
    [System.ComponentModel.DescriptionAttribute("SynchronizingObject")]
    public System.ComponentModel.ISynchronizeInvoke SynchronizingObject { get { return default(System.ComponentModel.ISynchronizeInvoke); } set { } }
    public event System.EventHandler<System.Net.PeerToPeer.Collaboration.InviteCompletedEventArgs> InviteCompleted { add { } remove { } }
    public void Dispose() { }
    protected virtual void Dispose(bool disposing) { }
    public bool Equals(System.Net.PeerToPeer.Collaboration.Peer other) { return default(bool); }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, SerializationFormatter=true)]
    protected virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    [System.Security.SecurityCriticalAttribute]
    public System.Net.PeerToPeer.Collaboration.PeerObjectCollection GetObjects() { return default(System.Net.PeerToPeer.Collaboration.PeerObjectCollection); }
    [System.Security.SecurityCriticalAttribute]
    public System.Net.PeerToPeer.Collaboration.PeerObjectCollection GetObjects(System.Guid objectId) { return default(System.Net.PeerToPeer.Collaboration.PeerObjectCollection); }
    [System.Security.SecurityCriticalAttribute]
    public System.Net.PeerToPeer.Collaboration.PeerPresenceInfo GetPresenceInfo(System.Net.PeerToPeer.Collaboration.PeerEndPoint peerEndPoint) { return default(System.Net.PeerToPeer.Collaboration.PeerPresenceInfo); }
    public abstract System.Net.PeerToPeer.Collaboration.PeerInvitationResponse Invite();
    public abstract System.Net.PeerToPeer.Collaboration.PeerInvitationResponse Invite(System.Net.PeerToPeer.Collaboration.PeerApplication applicationToInvite, string message, System.Byte[] invitationData);
    public abstract void InviteAsync(System.Net.PeerToPeer.Collaboration.PeerApplication applicationToInvite, string message, System.Byte[] invitationData, object userToken);
    public abstract void InviteAsync(object userToken);
    [System.Security.SecurityCriticalAttribute]
    public void InviteAsyncCancel(object userToken) { }
    protected virtual void OnInviteCompleted(System.Net.PeerToPeer.Collaboration.InviteCompletedEventArgs e) { }
    [System.Security.SecurityCriticalAttribute]
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(128), SerializationFormatter=true)]
    void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public override string ToString() { return default(string); }
  }
  public partial class PeerApplication : System.IDisposable, System.IEquatable<System.Net.PeerToPeer.Collaboration.PeerApplication>, System.Runtime.Serialization.ISerializable {
    public PeerApplication() { }
    public PeerApplication(System.Guid id, string description, System.Byte[] data, string path, string commandLineArgs, System.Net.PeerToPeer.Collaboration.PeerScope peerScope) { }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(128))]
    protected PeerApplication(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
    public string CommandLineArgs { get { return default(string); } set { } }
    public System.Byte[] Data { get { return default(System.Byte[]); } set { } }
    public string Description { get { return default(string); } set { } }
    public System.Guid Id { get { return default(System.Guid); } set { } }
    public string Path { get { return default(string); } set { } }
    public System.Net.PeerToPeer.Collaboration.PeerScope PeerScope { get { return default(System.Net.PeerToPeer.Collaboration.PeerScope); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute(null)]
    [System.ComponentModel.DescriptionAttribute("SynchronizingObject")]
    public System.ComponentModel.ISynchronizeInvoke SynchronizingObject { get { return default(System.ComponentModel.ISynchronizeInvoke); } set { } }
    public event System.EventHandler<System.Net.PeerToPeer.Collaboration.ApplicationChangedEventArgs> ApplicationChanged { add { } remove { } }
    [System.Security.SecurityCriticalAttribute]
    public void Dispose() { }
    [System.Security.SecurityCriticalAttribute]
    protected virtual void Dispose(bool disposing) { }
    public bool Equals(System.Net.PeerToPeer.Collaboration.PeerApplication other) { return default(bool); }
    public override bool Equals(object obj) { return default(bool); }
    public static new bool Equals(object objA, object objB) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, SerializationFormatter=true)]
    protected virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    protected virtual void OnApplicationChanged(System.Net.PeerToPeer.Collaboration.ApplicationChangedEventArgs appChangedArgs) { }
    [System.Security.SecurityCriticalAttribute]
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(128), SerializationFormatter=true)]
    void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public override string ToString() { return default(string); }
  }
  public partial class PeerApplicationCollection : System.Collections.ObjectModel.Collection<System.Net.PeerToPeer.Collaboration.PeerApplication> {
    internal PeerApplicationCollection() { }
    protected override void InsertItem(int index, System.Net.PeerToPeer.Collaboration.PeerApplication item) { }
    protected override void SetItem(int index, System.Net.PeerToPeer.Collaboration.PeerApplication item) { }
    public override string ToString() { return default(string); }
  }
  public partial class PeerApplicationLaunchInfo {
    internal PeerApplicationLaunchInfo() { }
    public System.Byte[] Data { get { return default(System.Byte[]); } }
    public string Message { get { return default(string); } }
    public System.Net.PeerToPeer.Collaboration.PeerApplication PeerApplication { get { return default(System.Net.PeerToPeer.Collaboration.PeerApplication); } }
    public System.Net.PeerToPeer.Collaboration.PeerContact PeerContact { get { return default(System.Net.PeerToPeer.Collaboration.PeerContact); } }
    public System.Net.PeerToPeer.Collaboration.PeerEndPoint PeerEndPoint { get { return default(System.Net.PeerToPeer.Collaboration.PeerEndPoint); } }
  }
  public enum PeerApplicationRegistrationType {
    AllUsers = 1,
    CurrentUser = 0,
  }
  public enum PeerChangeType {
    Added = 0,
    Deleted = 1,
    Updated = 2,
  }
  public static partial class PeerCollaboration {
    public static System.Net.PeerToPeer.Collaboration.PeerApplicationLaunchInfo ApplicationLaunchInfo { [System.Security.SecurityCriticalAttribute]get { return default(System.Net.PeerToPeer.Collaboration.PeerApplicationLaunchInfo); } }
    public static System.Net.PeerToPeer.Collaboration.ContactManager ContactManager { [System.Security.SecurityCriticalAttribute]get { return default(System.Net.PeerToPeer.Collaboration.ContactManager); } }
    public static string LocalEndPointName { [System.Security.SecurityCriticalAttribute]get { return default(string); } [System.Security.SecurityCriticalAttribute]set { } }
    public static System.Net.PeerToPeer.Collaboration.PeerPresenceInfo LocalPresenceInfo { [System.Security.SecurityCriticalAttribute]get { return default(System.Net.PeerToPeer.Collaboration.PeerPresenceInfo); } [System.Security.SecurityCriticalAttribute]set { } }
    public static System.Net.PeerToPeer.Collaboration.PeerScope SignInScope { [System.Security.SecurityCriticalAttribute]get { return default(System.Net.PeerToPeer.Collaboration.PeerScope); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute(null)]
    [System.ComponentModel.DescriptionAttribute("SynchronizingObject")]
    public static System.ComponentModel.ISynchronizeInvoke SynchronizingObject { get { return default(System.ComponentModel.ISynchronizeInvoke); } set { } }
    public static event System.EventHandler<System.Net.PeerToPeer.Collaboration.ApplicationChangedEventArgs> LocalApplicationChanged { add { } remove { } }
    public static event System.EventHandler<System.Net.PeerToPeer.Collaboration.NameChangedEventArgs> LocalNameChanged { add { } remove { } }
    public static event System.EventHandler<System.Net.PeerToPeer.Collaboration.ObjectChangedEventArgs> LocalObjectChanged { add { } remove { } }
    public static event System.EventHandler<System.Net.PeerToPeer.Collaboration.PresenceChangedEventArgs> LocalPresenceChanged { add { } remove { } }
    [System.Security.SecurityCriticalAttribute]
    public static void DeleteObject(System.Net.PeerToPeer.Collaboration.PeerObject peerObject) { }
    public static System.Net.PeerToPeer.Collaboration.PeerApplicationCollection GetLocalRegisteredApplications() { return default(System.Net.PeerToPeer.Collaboration.PeerApplicationCollection); }
    [System.Security.SecurityCriticalAttribute]
    public static System.Net.PeerToPeer.Collaboration.PeerApplicationCollection GetLocalRegisteredApplications(System.Net.PeerToPeer.Collaboration.PeerApplicationRegistrationType type) { return default(System.Net.PeerToPeer.Collaboration.PeerApplicationCollection); }
    [System.Security.SecurityCriticalAttribute]
    public static System.Net.PeerToPeer.Collaboration.PeerObjectCollection GetLocalSetObjects() { return default(System.Net.PeerToPeer.Collaboration.PeerObjectCollection); }
    [System.Security.SecurityCriticalAttribute]
    public static System.Net.PeerToPeer.Collaboration.PeerNearMeCollection GetPeersNearMe() { return default(System.Net.PeerToPeer.Collaboration.PeerNearMeCollection); }
    [System.Security.SecurityCriticalAttribute]
    public static void RegisterApplication(System.Net.PeerToPeer.Collaboration.PeerApplication application, System.Net.PeerToPeer.Collaboration.PeerApplicationRegistrationType type) { }
    [System.Security.SecurityCriticalAttribute]
    public static void SetObject(System.Net.PeerToPeer.Collaboration.PeerObject peerObject) { }
    [System.Security.SecurityCriticalAttribute]
    public static void SignIn(System.Net.PeerToPeer.Collaboration.PeerScope peerScope) { }
    [System.Security.SecurityCriticalAttribute]
    public static void SignOut(System.Net.PeerToPeer.Collaboration.PeerScope peerScope) { }
    [System.Security.SecurityCriticalAttribute]
    public static void UnregisterApplication(System.Net.PeerToPeer.Collaboration.PeerApplication application, System.Net.PeerToPeer.Collaboration.PeerApplicationRegistrationType type) { }
  }
  public sealed partial class PeerCollaborationPermission : System.Security.CodeAccessPermission, System.Security.Permissions.IUnrestrictedPermission {
    public PeerCollaborationPermission(System.Security.Permissions.PermissionState state) { }
    public override System.Security.IPermission Copy() { return default(System.Security.IPermission); }
    public override void FromXml(System.Security.SecurityElement e) { }
    public override System.Security.IPermission Intersect(System.Security.IPermission target) { return default(System.Security.IPermission); }
    public override bool IsSubsetOf(System.Security.IPermission target) { return default(bool); }
    public bool IsUnrestricted() { return default(bool); }
    public override System.Security.SecurityElement ToXml() { return default(System.Security.SecurityElement); }
    public override System.Security.IPermission Union(System.Security.IPermission target) { return default(System.Security.IPermission); }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(109), AllowMultiple=true, Inherited=false)]
  public sealed partial class PeerCollaborationPermissionAttribute : System.Security.Permissions.CodeAccessSecurityAttribute {
    public PeerCollaborationPermissionAttribute(System.Security.Permissions.SecurityAction action) : base (default(System.Security.Permissions.SecurityAction)) { }
    public override System.Security.IPermission CreatePermission() { return default(System.Security.IPermission); }
  }
  public partial class PeerContact : System.Net.PeerToPeer.Collaboration.Peer, System.IEquatable<System.Net.PeerToPeer.Collaboration.PeerContact>, System.Runtime.Serialization.ISerializable {
    [System.Security.SecurityCriticalAttribute]
    protected PeerContact(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) : base (default(System.Runtime.Serialization.SerializationInfo), default(System.Runtime.Serialization.StreamingContext)) { }
    public System.Security.Cryptography.X509Certificates.X509Certificate2 Credentials { get { return default(System.Security.Cryptography.X509Certificates.X509Certificate2); } }
    public string DisplayName { get { return default(string); } set { } }
    public System.Net.Mail.MailAddress EmailAddress { get { return default(System.Net.Mail.MailAddress); } set { } }
    public bool IsSubscribed { get { return default(bool); } }
    public string Nickname { get { return default(string); } set { } }
    public override System.Net.PeerToPeer.Collaboration.PeerEndPointCollection PeerEndPoints { [System.Security.SecurityCriticalAttribute]get { return default(System.Net.PeerToPeer.Collaboration.PeerEndPointCollection); } }
    public System.Net.PeerToPeer.PeerName PeerName { get { return default(System.Net.PeerToPeer.PeerName); } }
    public System.Net.PeerToPeer.Collaboration.SubscriptionType SubscribeAllowed { get { return default(System.Net.PeerToPeer.Collaboration.SubscriptionType); } set { } }
    public event System.EventHandler<System.Net.PeerToPeer.Collaboration.ApplicationChangedEventArgs> ApplicationChanged { add { } remove { } }
    public event System.EventHandler<System.Net.PeerToPeer.Collaboration.ObjectChangedEventArgs> ObjectChanged { add { } remove { } }
    public event System.EventHandler<System.Net.PeerToPeer.Collaboration.PresenceChangedEventArgs> PresenceChanged { add { } remove { } }
    public event System.EventHandler<System.Net.PeerToPeer.Collaboration.SubscribeCompletedEventArgs> SubscribeCompleted { add { } remove { } }
    [System.Security.SecurityCriticalAttribute]
    protected override void Dispose(bool disposing) { }
    public bool Equals(System.Net.PeerToPeer.Collaboration.PeerContact other) { return default(bool); }
    public override bool Equals(object obj) { return default(bool); }
    public static new bool Equals(object objA, object objB) { return default(bool); }
    [System.Security.SecurityCriticalAttribute]
    public static System.Net.PeerToPeer.Collaboration.PeerContact FromXml(string peerContactXml) { return default(System.Net.PeerToPeer.Collaboration.PeerContact); }
    [System.Security.SecurityCriticalAttribute]
    public System.Net.PeerToPeer.Collaboration.PeerApplicationCollection GetApplications() { return default(System.Net.PeerToPeer.Collaboration.PeerApplicationCollection); }
    [System.Security.SecurityCriticalAttribute]
    public System.Net.PeerToPeer.Collaboration.PeerApplicationCollection GetApplications(System.Guid applicationId) { return default(System.Net.PeerToPeer.Collaboration.PeerApplicationCollection); }
    [System.Security.SecurityCriticalAttribute]
    public System.Net.PeerToPeer.Collaboration.PeerApplicationCollection GetApplications(System.Net.PeerToPeer.Collaboration.PeerEndPoint peerEndPoint) { return default(System.Net.PeerToPeer.Collaboration.PeerApplicationCollection); }
    [System.Security.SecurityCriticalAttribute]
    public System.Net.PeerToPeer.Collaboration.PeerApplicationCollection GetApplications(System.Net.PeerToPeer.Collaboration.PeerEndPoint peerEndPoint, System.Guid applicationId) { return default(System.Net.PeerToPeer.Collaboration.PeerApplicationCollection); }
    public override int GetHashCode() { return default(int); }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, SerializationFormatter=true)]
    protected override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    [System.Security.SecurityCriticalAttribute]
    public System.Net.PeerToPeer.Collaboration.PeerObjectCollection GetObjects(System.Net.PeerToPeer.Collaboration.PeerEndPoint peerEndPoint) { return default(System.Net.PeerToPeer.Collaboration.PeerObjectCollection); }
    [System.Security.SecurityCriticalAttribute]
    public System.Net.PeerToPeer.Collaboration.PeerObjectCollection GetObjects(System.Net.PeerToPeer.Collaboration.PeerEndPoint peerEndPoint, System.Guid objectId) { return default(System.Net.PeerToPeer.Collaboration.PeerObjectCollection); }
    [System.Security.SecurityCriticalAttribute]
    public override System.Net.PeerToPeer.Collaboration.PeerInvitationResponse Invite() { return default(System.Net.PeerToPeer.Collaboration.PeerInvitationResponse); }
    [System.Security.SecurityCriticalAttribute]
    public override System.Net.PeerToPeer.Collaboration.PeerInvitationResponse Invite(System.Net.PeerToPeer.Collaboration.PeerApplication applicationToInvite, string message, System.Byte[] invitationData) { return default(System.Net.PeerToPeer.Collaboration.PeerInvitationResponse); }
    [System.Security.SecurityCriticalAttribute]
    public System.Net.PeerToPeer.Collaboration.PeerInvitationResponse Invite(System.Net.PeerToPeer.Collaboration.PeerEndPoint peerEndPoint) { return default(System.Net.PeerToPeer.Collaboration.PeerInvitationResponse); }
    [System.Security.SecurityCriticalAttribute]
    public System.Net.PeerToPeer.Collaboration.PeerInvitationResponse Invite(System.Net.PeerToPeer.Collaboration.PeerEndPoint peerEndPoint, System.Net.PeerToPeer.Collaboration.PeerApplication applicationToInvite, string message, System.Byte[] invitationData) { return default(System.Net.PeerToPeer.Collaboration.PeerInvitationResponse); }
    [System.Security.SecurityCriticalAttribute]
    public override void InviteAsync(System.Net.PeerToPeer.Collaboration.PeerApplication applicationToInvite, string message, System.Byte[] invitationData, object userToken) { }
    [System.Security.SecurityCriticalAttribute]
    public void InviteAsync(System.Net.PeerToPeer.Collaboration.PeerEndPoint peerEndPoint, object userToken) { }
    [System.Security.SecurityCriticalAttribute]
    public void InviteAsync(System.Net.PeerToPeer.Collaboration.PeerEndPoint peerEndPoint, string message, System.Byte[] invitationData, System.Net.PeerToPeer.Collaboration.PeerApplication applicationToInvite, object userToken) { }
    [System.Security.SecurityCriticalAttribute]
    public override void InviteAsync(object userToken) { }
    protected virtual void OnApplicationChanged(System.Net.PeerToPeer.Collaboration.ApplicationChangedEventArgs appChangedArgs) { }
    protected virtual void OnObjectChanged(System.Net.PeerToPeer.Collaboration.ObjectChangedEventArgs objChangedArgs) { }
    protected virtual void OnPresenceChanged(System.Net.PeerToPeer.Collaboration.PresenceChangedEventArgs presenceChangedArgs) { }
    protected void OnSubscribeCompleted(System.Net.PeerToPeer.Collaboration.SubscribeCompletedEventArgs e) { }
    public virtual void Subscribe() { }
    public virtual void SubscribeAsync(object userToken) { }
    [System.Security.SecurityCriticalAttribute]
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(128), SerializationFormatter=true)]
    void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public override string ToString() { return default(string); }
    [System.Security.SecurityCriticalAttribute]
    public string ToXml() { return default(string); }
    public virtual void Unsubscribe() { }
  }
  public partial class PeerContactCollection : System.Collections.ObjectModel.Collection<System.Net.PeerToPeer.Collaboration.PeerContact> {
    internal PeerContactCollection() { }
    protected override void InsertItem(int index, System.Net.PeerToPeer.Collaboration.PeerContact item) { }
    protected override void SetItem(int index, System.Net.PeerToPeer.Collaboration.PeerContact item) { }
    public override string ToString() { return default(string); }
  }
  public partial class PeerEndPoint : System.IDisposable, System.IEquatable<System.Net.PeerToPeer.Collaboration.PeerEndPoint>, System.Runtime.Serialization.ISerializable {
    public PeerEndPoint() { }
    public PeerEndPoint(System.Net.IPEndPoint endPoint) { }
    public PeerEndPoint(System.Net.IPEndPoint endPoint, string endPointName) { }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(128))]
    protected PeerEndPoint(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
    public System.Net.IPEndPoint EndPoint { get { return default(System.Net.IPEndPoint); } set { } }
    public string Name { get { return default(string); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute(null)]
    [System.ComponentModel.DescriptionAttribute("SynchronizingObject")]
    public System.ComponentModel.ISynchronizeInvoke SynchronizingObject { get { return default(System.ComponentModel.ISynchronizeInvoke); } set { } }
    public event System.EventHandler<System.Net.PeerToPeer.Collaboration.NameChangedEventArgs> NameChanged { add { } remove { } }
    [System.Security.SecurityCriticalAttribute]
    public void Dispose() { }
    [System.Security.SecurityCriticalAttribute]
    protected virtual void Dispose(bool disposing) { }
    public bool Equals(System.Net.PeerToPeer.Collaboration.PeerEndPoint other) { return default(bool); }
    public override bool Equals(object obj) { return default(bool); }
    public static new bool Equals(object objA, object objB) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, SerializationFormatter=true)]
    protected virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    protected void OnNameChanged(System.Net.PeerToPeer.Collaboration.NameChangedEventArgs nameChangedArgs) { }
    [System.Security.SecurityCriticalAttribute]
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(128), SerializationFormatter=true)]
    void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public override string ToString() { return default(string); }
  }
  public partial class PeerEndPointCollection : System.Collections.ObjectModel.Collection<System.Net.PeerToPeer.Collaboration.PeerEndPoint>, System.IEquatable<System.Net.PeerToPeer.Collaboration.PeerEndPointCollection> {
    internal PeerEndPointCollection() { }
    public bool Equals(System.Net.PeerToPeer.Collaboration.PeerEndPointCollection other) { return default(bool); }
    protected override void InsertItem(int index, System.Net.PeerToPeer.Collaboration.PeerEndPoint item) { }
    protected override void SetItem(int index, System.Net.PeerToPeer.Collaboration.PeerEndPoint item) { }
    public override string ToString() { return default(string); }
  }
  public partial class PeerInvitationResponse {
    internal PeerInvitationResponse() { }
    public System.Net.PeerToPeer.Collaboration.PeerInvitationResponseType PeerInvitationResponseType { get { return default(System.Net.PeerToPeer.Collaboration.PeerInvitationResponseType); } }
  }
  public enum PeerInvitationResponseType {
    Accepted = 1,
    Declined = 0,
    Expired = 2,
  }
  public partial class PeerNearMe : System.Net.PeerToPeer.Collaboration.Peer, System.IEquatable<System.Net.PeerToPeer.Collaboration.PeerNearMe>, System.Runtime.Serialization.ISerializable {
    public PeerNearMe() : base (default(System.Runtime.Serialization.SerializationInfo), default(System.Runtime.Serialization.StreamingContext)) { }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(128))]
    protected PeerNearMe(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) : base (default(System.Runtime.Serialization.SerializationInfo), default(System.Runtime.Serialization.StreamingContext)) { }
    public string Nickname { get { return default(string); } }
    public static event System.EventHandler<System.Net.PeerToPeer.Collaboration.PeerNearMeChangedEventArgs> PeerNearMeChanged { add { } remove { } }
    public event System.EventHandler<System.Net.PeerToPeer.Collaboration.RefreshDataCompletedEventArgs> RefreshDataCompleted { add { } remove { } }
    public System.Net.PeerToPeer.Collaboration.PeerContact AddToContactManager() { return default(System.Net.PeerToPeer.Collaboration.PeerContact); }
    public System.Net.PeerToPeer.Collaboration.PeerContact AddToContactManager(string displayName, string nickname, System.Net.Mail.MailAddress emailAddress) { return default(System.Net.PeerToPeer.Collaboration.PeerContact); }
    [System.Security.SecurityCriticalAttribute]
    public static System.Net.PeerToPeer.Collaboration.PeerNearMe CreateFromPeerEndPoint(System.Net.PeerToPeer.Collaboration.PeerEndPoint peerEndPoint) { return default(System.Net.PeerToPeer.Collaboration.PeerNearMe); }
    protected override void Dispose(bool disposing) { }
    public bool Equals(System.Net.PeerToPeer.Collaboration.PeerNearMe other) { return default(bool); }
    public override bool Equals(object obj) { return default(bool); }
    public static new bool Equals(object objA, object objB) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    [System.Security.SecurityCriticalAttribute]
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, SerializationFormatter=true)]
    protected override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    [System.Security.SecurityCriticalAttribute]
    protected internal void InternalRefreshData(object state) { }
    [System.Security.SecurityCriticalAttribute]
    public override System.Net.PeerToPeer.Collaboration.PeerInvitationResponse Invite() { return default(System.Net.PeerToPeer.Collaboration.PeerInvitationResponse); }
    [System.Security.SecurityCriticalAttribute]
    public override System.Net.PeerToPeer.Collaboration.PeerInvitationResponse Invite(System.Net.PeerToPeer.Collaboration.PeerApplication applicationToInvite, string message, System.Byte[] invitationData) { return default(System.Net.PeerToPeer.Collaboration.PeerInvitationResponse); }
    [System.Security.SecurityCriticalAttribute]
    public override void InviteAsync(System.Net.PeerToPeer.Collaboration.PeerApplication applicationToInvite, string message, System.Byte[] invitationData, object userToken) { }
    [System.Security.SecurityCriticalAttribute]
    public override void InviteAsync(object userToken) { }
    protected void OnRefreshDataCompleted(System.Net.PeerToPeer.Collaboration.RefreshDataCompletedEventArgs e) { }
    [System.Security.SecurityCriticalAttribute]
    public void RefreshData() { }
    [System.Security.SecurityCriticalAttribute]
    public void RefreshDataAsync(object userToken) { }
    [System.Security.SecurityCriticalAttribute]
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(128), SerializationFormatter=true)]
    void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public override string ToString() { return default(string); }
  }
  public partial class PeerNearMeChangedEventArgs : System.EventArgs {
    internal PeerNearMeChangedEventArgs() { }
    public System.Net.PeerToPeer.Collaboration.PeerChangeType PeerChangeType { get { return default(System.Net.PeerToPeer.Collaboration.PeerChangeType); } }
    public System.Net.PeerToPeer.Collaboration.PeerNearMe PeerNearMe { get { return default(System.Net.PeerToPeer.Collaboration.PeerNearMe); } }
  }
  public partial class PeerNearMeCollection : System.Collections.ObjectModel.Collection<System.Net.PeerToPeer.Collaboration.PeerNearMe> {
    internal PeerNearMeCollection() { }
    protected override void InsertItem(int index, System.Net.PeerToPeer.Collaboration.PeerNearMe item) { }
    protected override void SetItem(int index, System.Net.PeerToPeer.Collaboration.PeerNearMe item) { }
    public override string ToString() { return default(string); }
  }
  public partial class PeerObject : System.IDisposable, System.IEquatable<System.Net.PeerToPeer.Collaboration.PeerObject>, System.Runtime.Serialization.ISerializable {
    public PeerObject() { }
    public PeerObject(System.Guid Id, System.Byte[] data, System.Net.PeerToPeer.Collaboration.PeerScope peerScope) { }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(128))]
    protected PeerObject(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
    public System.Byte[] Data { get { return default(System.Byte[]); } set { } }
    public System.Guid Id { get { return default(System.Guid); } set { } }
    public System.Net.PeerToPeer.Collaboration.PeerScope PeerScope { get { return default(System.Net.PeerToPeer.Collaboration.PeerScope); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute(null)]
    [System.ComponentModel.DescriptionAttribute("SynchronizingObject")]
    public System.ComponentModel.ISynchronizeInvoke SynchronizingObject { get { return default(System.ComponentModel.ISynchronizeInvoke); } set { } }
    public event System.EventHandler<System.Net.PeerToPeer.Collaboration.ObjectChangedEventArgs> ObjectChanged { add { } remove { } }
    [System.Security.SecurityCriticalAttribute]
    public void Dispose() { }
    [System.Security.SecurityCriticalAttribute]
    protected virtual void Dispose(bool disposing) { }
    public bool Equals(System.Net.PeerToPeer.Collaboration.PeerObject other) { return default(bool); }
    public override bool Equals(object obj) { return default(bool); }
    public static new bool Equals(object objA, object objB) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, SerializationFormatter=true)]
    protected virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    protected virtual void OnObjectChanged(System.Net.PeerToPeer.Collaboration.ObjectChangedEventArgs objChangedArgs) { }
    [System.Security.SecurityCriticalAttribute]
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(128), SerializationFormatter=true)]
    void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public override string ToString() { return default(string); }
  }
  public partial class PeerObjectCollection : System.Collections.ObjectModel.Collection<System.Net.PeerToPeer.Collaboration.PeerObject> {
    internal PeerObjectCollection() { }
    protected override void InsertItem(int index, System.Net.PeerToPeer.Collaboration.PeerObject item) { }
    protected override void SetItem(int index, System.Net.PeerToPeer.Collaboration.PeerObject item) { }
    public override string ToString() { return default(string); }
  }
  public partial class PeerPresenceInfo {
    public PeerPresenceInfo() { }
    public PeerPresenceInfo(System.Net.PeerToPeer.Collaboration.PeerPresenceStatus presenceStatus, string description) { }
    public string DescriptiveText { get { return default(string); } set { } }
    public System.Net.PeerToPeer.Collaboration.PeerPresenceStatus PresenceStatus { get { return default(System.Net.PeerToPeer.Collaboration.PeerPresenceStatus); } set { } }
  }
  public enum PeerPresenceStatus {
    Away = 2,
    BeRightBack = 3,
    Busy = 5,
    Idle = 4,
    Offline = 0,
    Online = 7,
    OnThePhone = 6,
    OutToLunch = 1,
  }
  public enum PeerScope {
    All = 3,
    Internet = 2,
    NearMe = 1,
    None = 0,
  }
  public partial class PresenceChangedEventArgs : System.EventArgs {
    internal PresenceChangedEventArgs() { }
    public System.Net.PeerToPeer.Collaboration.PeerChangeType PeerChangeType { get { return default(System.Net.PeerToPeer.Collaboration.PeerChangeType); } }
    public System.Net.PeerToPeer.Collaboration.PeerContact PeerContact { get { return default(System.Net.PeerToPeer.Collaboration.PeerContact); } }
    public System.Net.PeerToPeer.Collaboration.PeerEndPoint PeerEndPoint { get { return default(System.Net.PeerToPeer.Collaboration.PeerEndPoint); } }
    public System.Net.PeerToPeer.Collaboration.PeerPresenceInfo PeerPresenceInfo { get { return default(System.Net.PeerToPeer.Collaboration.PeerPresenceInfo); } }
  }
  public partial class RefreshDataCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
    internal RefreshDataCompletedEventArgs() { }
    public System.Net.PeerToPeer.Collaboration.PeerEndPoint PeerEndPoint { get { return default(System.Net.PeerToPeer.Collaboration.PeerEndPoint); } }
  }
  public partial class SubscribeCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
    internal SubscribeCompletedEventArgs() { }
    public System.Net.PeerToPeer.Collaboration.PeerContact PeerContact { get { return default(System.Net.PeerToPeer.Collaboration.PeerContact); } }
    public System.Net.PeerToPeer.Collaboration.PeerNearMe PeerNearMe { get { return default(System.Net.PeerToPeer.Collaboration.PeerNearMe); } }
  }
  public partial class SubscriptionListChangedEventArgs : System.EventArgs {
    internal SubscriptionListChangedEventArgs() { }
    public System.Net.PeerToPeer.Collaboration.PeerChangeType PeerChangeType { get { return default(System.Net.PeerToPeer.Collaboration.PeerChangeType); } }
    public System.Net.PeerToPeer.Collaboration.PeerContact PeerContact { get { return default(System.Net.PeerToPeer.Collaboration.PeerContact); } }
    public System.Net.PeerToPeer.Collaboration.PeerEndPoint PeerEndPoint { get { return default(System.Net.PeerToPeer.Collaboration.PeerEndPoint); } }
  }
  public enum SubscriptionType {
    Allowed = 1,
    Blocked = 0,
  }
}
namespace System.Net.Sockets {
  [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
  [System.ObsoleteAttribute("This API supports the .NET Framework infrastructure and is not intended to be used directly from your code.", true)]
  public partial class HttpPolicyDownloaderProtocol {
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.ObsoleteAttribute("This API supports the .NET Framework infrastructure and is not intended to be used directly from your code.", true)]
    public HttpPolicyDownloaderProtocol(System.Uri appUri, System.Net.IPAddress address) { }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.ObsoleteAttribute("This API supports the .NET Framework infrastructure and is not intended to be used directly from your code.", true)]
    public System.Net.Sockets.SocketPolicy Result { get { return default(System.Net.Sockets.SocketPolicy); } }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.ObsoleteAttribute("This API supports the .NET Framework infrastructure and is not intended to be used directly from your code.", true)]
    public void Abort() { }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.ObsoleteAttribute("This API supports the .NET Framework infrastructure and is not intended to be used directly from your code.", true)]
    public void BeginDownload(System.Net.Sockets.SecurityCriticalAction callback) { }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.ObsoleteAttribute("This API supports the .NET Framework infrastructure and is not intended to be used directly from your code.", true)]
    public void DownloadCallback(System.IAsyncResult ar) { }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.ObsoleteAttribute("This API supports the .NET Framework infrastructure and is not intended to be used directly from your code.", true)]
    public void ReadCallback(System.IAsyncResult ar) { }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.ObsoleteAttribute("This API supports the .NET Framework infrastructure and is not intended to be used directly from your code.", true)]
    public static void RegisterUnsafeWebRequestCreator(System.Net.IUnsafeWebRequestCreate creator) { }
  }
  [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
  [System.ObsoleteAttribute("This API supports the .NET Framework infrastructure and is not intended to be used directly from your code.", true)]
  public delegate void SecurityCriticalAction();
  [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
  [System.ObsoleteAttribute("This API supports the .NET Framework infrastructure and is not intended to be used directly from your code.", true)]
  public partial class SocketPolicy {
    public SocketPolicy() { }
  }
  [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
  [System.ObsoleteAttribute("This API supports the .NET Framework infrastructure and is not intended to be used directly from your code.", true)]
  public partial class UdpAnySourceMulticastClient : System.IDisposable {
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.ObsoleteAttribute("This API supports the .NET Framework infrastructure and is not intended to be used directly from your code.", true)]
    public UdpAnySourceMulticastClient(System.Net.IPAddress groupAddress, int localPort) { }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.ObsoleteAttribute("This API supports the .NET Framework infrastructure and is not intended to be used directly from your code.", true)]
    public bool MulticastLoopback { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.ObsoleteAttribute("This API supports the .NET Framework infrastructure and is not intended to be used directly from your code.", true)]
    public int ReceiveBufferSize { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(int); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.ObsoleteAttribute("This API supports the .NET Framework infrastructure and is not intended to be used directly from your code.", true)]
    public int SendBufferSize { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(int); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.ObsoleteAttribute("This API supports the .NET Framework infrastructure and is not intended to be used directly from your code.", true)]
    public System.IAsyncResult BeginJoinGroup(System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.ObsoleteAttribute("This API supports the .NET Framework infrastructure and is not intended to be used directly from your code.", true)]
    public System.IAsyncResult BeginReceiveFromGroup(System.Byte[] buffer, int offset, int count, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.ObsoleteAttribute("This API supports the .NET Framework infrastructure and is not intended to be used directly from your code.", true)]
    public System.IAsyncResult BeginSendTo(System.Byte[] buffer, int offset, int count, System.Net.IPEndPoint remoteEndPoint, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.ObsoleteAttribute("This API supports the .NET Framework infrastructure and is not intended to be used directly from your code.", true)]
    public System.IAsyncResult BeginSendToGroup(System.Byte[] buffer, int offset, int count, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.ObsoleteAttribute("This API supports the .NET Framework infrastructure and is not intended to be used directly from your code.", true)]
    public void BlockSource(System.Net.IPAddress sourceAddress) { }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.ObsoleteAttribute("This API supports the .NET Framework infrastructure and is not intended to be used directly from your code.", true)]
    public void Dispose() { }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.ObsoleteAttribute("This API supports the .NET Framework infrastructure and is not intended to be used directly from your code.", true)]
    public void EndJoinGroup(System.IAsyncResult result) { }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.ObsoleteAttribute("This API supports the .NET Framework infrastructure and is not intended to be used directly from your code.", true)]
    public int EndReceiveFromGroup(System.IAsyncResult result, out System.Net.IPEndPoint source) { source = default(System.Net.IPEndPoint); return default(int); }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.ObsoleteAttribute("This API supports the .NET Framework infrastructure and is not intended to be used directly from your code.", true)]
    public void EndSendTo(System.IAsyncResult result) { }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.ObsoleteAttribute("This API supports the .NET Framework infrastructure and is not intended to be used directly from your code.", true)]
    public void EndSendToGroup(System.IAsyncResult result) { }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.ObsoleteAttribute("This API supports the .NET Framework infrastructure and is not intended to be used directly from your code.", true)]
    public void UnblockSource(System.Net.IPAddress sourceAddress) { }
  }
  [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
  [System.ObsoleteAttribute("This API supports the .NET Framework infrastructure and is not intended to be used directly from your code.", true)]
  public partial class UdpSingleSourceMulticastClient : System.IDisposable {
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.ObsoleteAttribute("This API supports the .NET Framework infrastructure and is not intended to be used directly from your code.", true)]
    public UdpSingleSourceMulticastClient(System.Net.IPAddress sourceAddress, System.Net.IPAddress groupAddress, int localPort) { }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.ObsoleteAttribute("This API supports the .NET Framework infrastructure and is not intended to be used directly from your code.", true)]
    public int ReceiveBufferSize { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(int); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.ObsoleteAttribute("This API supports the .NET Framework infrastructure and is not intended to be used directly from your code.", true)]
    public int SendBufferSize { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(int); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.ObsoleteAttribute("This API supports the .NET Framework infrastructure and is not intended to be used directly from your code.", true)]
    public System.IAsyncResult BeginJoinGroup(System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.ObsoleteAttribute("This API supports the .NET Framework infrastructure and is not intended to be used directly from your code.", true)]
    public System.IAsyncResult BeginReceiveFromSource(System.Byte[] buffer, int offset, int count, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.ObsoleteAttribute("This API supports the .NET Framework infrastructure and is not intended to be used directly from your code.", true)]
    public System.IAsyncResult BeginSendToSource(System.Byte[] buffer, int offset, int count, int remotePort, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.ObsoleteAttribute("This API supports the .NET Framework infrastructure and is not intended to be used directly from your code.", true)]
    public void Dispose() { }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.ObsoleteAttribute("This API supports the .NET Framework infrastructure and is not intended to be used directly from your code.", true)]
    public void EndJoinGroup(System.IAsyncResult result) { }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.ObsoleteAttribute("This API supports the .NET Framework infrastructure and is not intended to be used directly from your code.", true)]
    public int EndReceiveFromSource(System.IAsyncResult result, out int sourcePort) { sourcePort = default(int); return default(int); }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.ObsoleteAttribute("This API supports the .NET Framework infrastructure and is not intended to be used directly from your code.", true)]
    public void EndSendToSource(System.IAsyncResult result) { }
  }
}
