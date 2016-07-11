namespace Microsoft.Win32.SafeHandles {
  [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, MayLeakOnAbort=true)]
  [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, UnmanagedCode=true)]
  public sealed partial class SafePipeHandle : Microsoft.Win32.SafeHandles.SafeHandleZeroOrMinusOneIsInvalid {
    public SafePipeHandle(System.IntPtr preexistingHandle, bool ownsHandle) : base (default(bool)) { }
    protected override bool ReleaseHandle() { return default(bool); }
  }
}
namespace System {
  public delegate void Action();
  public delegate void Action<T1, T2>(T1 arg1, T2 arg2);
  public delegate void Action<T1, T2, T3>(T1 arg1, T2 arg2, T3 arg3);
  public delegate void Action<T1, T2, T3, T4>(T1 arg1, T2 arg2, T3 arg3, T4 arg4);
  public delegate TResult Func<TResult>();
  public delegate TResult Func<T, TResult>(T arg);
  public delegate TResult Func<T1, T2, TResult>(T1 arg1, T2 arg2);
  public delegate TResult Func<T1, T2, T3, TResult>(T1 arg1, T2 arg2, T3 arg3);
  public delegate TResult Func<T1, T2, T3, T4, TResult>(T1 arg1, T2 arg2, T3 arg3, T4 arg4);
  public partial class InvalidTimeZoneException : System.Exception {
    public InvalidTimeZoneException() { }
    protected InvalidTimeZoneException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext sc) { }
    public InvalidTimeZoneException(string message) { }
    public InvalidTimeZoneException(string message, System.Exception e) { }
  }
  public sealed partial class TimeZoneInfo : System.IEquatable<System.TimeZoneInfo>, System.Runtime.Serialization.IDeserializationCallback, System.Runtime.Serialization.ISerializable {
    internal TimeZoneInfo() { }
    public System.TimeSpan BaseUtcOffset { get { return default(System.TimeSpan); } }
    public string DaylightName { get { return default(string); } }
    public string DisplayName { get { return default(string); } }
    public string Id { get { return default(string); } }
    public static System.TimeZoneInfo Local { get { return default(System.TimeZoneInfo); } }
    public string StandardName { get { return default(string); } }
    public bool SupportsDaylightSavingTime { get { return default(bool); } }
    public static System.TimeZoneInfo Utc { get { return default(System.TimeZoneInfo); } }
    public static void ClearCachedData() { }
    public static System.DateTime ConvertTime(System.DateTime dateTime, System.TimeZoneInfo destinationTimeZone) { return default(System.DateTime); }
    public static System.DateTime ConvertTime(System.DateTime dateTime, System.TimeZoneInfo sourceTimeZone, System.TimeZoneInfo destinationTimeZone) { return default(System.DateTime); }
    public static System.DateTimeOffset ConvertTime(System.DateTimeOffset dateTimeOffset, System.TimeZoneInfo destinationTimeZone) { return default(System.DateTimeOffset); }
    public static System.DateTime ConvertTimeBySystemTimeZoneId(System.DateTime dateTime, string destinationTimeZoneId) { return default(System.DateTime); }
    public static System.DateTime ConvertTimeBySystemTimeZoneId(System.DateTime dateTime, string sourceTimeZoneId, string destinationTimeZoneId) { return default(System.DateTime); }
    public static System.DateTimeOffset ConvertTimeBySystemTimeZoneId(System.DateTimeOffset dateTimeOffset, string destinationTimeZoneId) { return default(System.DateTimeOffset); }
    public static System.DateTime ConvertTimeFromUtc(System.DateTime dateTime, System.TimeZoneInfo destinationTimeZone) { return default(System.DateTime); }
    public static System.DateTime ConvertTimeToUtc(System.DateTime dateTime) { return default(System.DateTime); }
    public static System.DateTime ConvertTimeToUtc(System.DateTime dateTime, System.TimeZoneInfo sourceTimeZone) { return default(System.DateTime); }
    public static System.TimeZoneInfo CreateCustomTimeZone(string id, System.TimeSpan baseUtcOffset, string displayName, string standardDisplayName) { return default(System.TimeZoneInfo); }
    public static System.TimeZoneInfo CreateCustomTimeZone(string id, System.TimeSpan baseUtcOffset, string displayName, string standardDisplayName, string daylightDisplayName, System.TimeZoneInfo.AdjustmentRule[] adjustmentRules) { return default(System.TimeZoneInfo); }
    public static System.TimeZoneInfo CreateCustomTimeZone(string id, System.TimeSpan baseUtcOffset, string displayName, string standardDisplayName, string daylightDisplayName, System.TimeZoneInfo.AdjustmentRule[] adjustmentRules, bool disableDaylightSavingTime) { return default(System.TimeZoneInfo); }
    public bool Equals(System.TimeZoneInfo other) { return default(bool); }
    public static System.TimeZoneInfo FindSystemTimeZoneById(string id) { return default(System.TimeZoneInfo); }
    public static System.TimeZoneInfo FromSerializedString(string source) { return default(System.TimeZoneInfo); }
    public System.TimeZoneInfo.AdjustmentRule[] GetAdjustmentRules() { return default(System.TimeZoneInfo.AdjustmentRule[]); }
    public System.TimeSpan[] GetAmbiguousTimeOffsets(System.DateTime dateTime) { return default(System.TimeSpan[]); }
    public System.TimeSpan[] GetAmbiguousTimeOffsets(System.DateTimeOffset dateTimeOffset) { return default(System.TimeSpan[]); }
    public override int GetHashCode() { return default(int); }
    public void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public static System.Collections.ObjectModel.ReadOnlyCollection<System.TimeZoneInfo> GetSystemTimeZones() { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.TimeZoneInfo>); }
    public System.TimeSpan GetUtcOffset(System.DateTime dateTime) { return default(System.TimeSpan); }
    public System.TimeSpan GetUtcOffset(System.DateTimeOffset dateTimeOffset) { return default(System.TimeSpan); }
    public bool HasSameRules(System.TimeZoneInfo other) { return default(bool); }
    public bool IsAmbiguousTime(System.DateTime dateTime) { return default(bool); }
    public bool IsAmbiguousTime(System.DateTimeOffset dateTimeOffset) { return default(bool); }
    public bool IsDaylightSavingTime(System.DateTime dateTime) { return default(bool); }
    public bool IsDaylightSavingTime(System.DateTimeOffset dateTimeOffset) { return default(bool); }
    public bool IsInvalidTime(System.DateTime dateTime) { return default(bool); }
    public void OnDeserialization(object sender) { }
    public string ToSerializedString() { return default(string); }
    public override string ToString() { return default(string); }
    public sealed partial class AdjustmentRule : System.IEquatable<System.TimeZoneInfo.AdjustmentRule>, System.Runtime.Serialization.IDeserializationCallback, System.Runtime.Serialization.ISerializable {
      internal AdjustmentRule() { }
      public System.DateTime DateEnd { get { return default(System.DateTime); } }
      public System.DateTime DateStart { get { return default(System.DateTime); } }
      public System.TimeSpan DaylightDelta { get { return default(System.TimeSpan); } }
      public System.TimeZoneInfo.TransitionTime DaylightTransitionEnd { get { return default(System.TimeZoneInfo.TransitionTime); } }
      public System.TimeZoneInfo.TransitionTime DaylightTransitionStart { get { return default(System.TimeZoneInfo.TransitionTime); } }
      public static System.TimeZoneInfo.AdjustmentRule CreateAdjustmentRule(System.DateTime dateStart, System.DateTime dateEnd, System.TimeSpan daylightDelta, System.TimeZoneInfo.TransitionTime daylightTransitionStart, System.TimeZoneInfo.TransitionTime daylightTransitionEnd) { return default(System.TimeZoneInfo.AdjustmentRule); }
      public bool Equals(System.TimeZoneInfo.AdjustmentRule other) { return default(bool); }
      public override int GetHashCode() { return default(int); }
      public void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
      public void OnDeserialization(object sender) { }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct TransitionTime : System.IEquatable<System.TimeZoneInfo.TransitionTime>, System.Runtime.Serialization.IDeserializationCallback, System.Runtime.Serialization.ISerializable {
      public int Day { get { return default(int); } }
      public System.DayOfWeek DayOfWeek { get { return default(System.DayOfWeek); } }
      public bool IsFixedDateRule { get { return default(bool); } }
      public int Month { get { return default(int); } }
      public System.DateTime TimeOfDay { get { return default(System.DateTime); } }
      public int Week { get { return default(int); } }
      public static System.TimeZoneInfo.TransitionTime CreateFixedDateRule(System.DateTime timeOfDay, int month, int day) { return default(System.TimeZoneInfo.TransitionTime); }
      public static System.TimeZoneInfo.TransitionTime CreateFloatingDateRule(System.DateTime timeOfDay, int month, int week, System.DayOfWeek dayOfWeek) { return default(System.TimeZoneInfo.TransitionTime); }
      public override bool Equals(object obj) { return default(bool); }
      public bool Equals(System.TimeZoneInfo.TransitionTime other) { return default(bool); }
      public override int GetHashCode() { return default(int); }
      public void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
      public void OnDeserialization(object sender) { }
      public static bool operator ==(System.TimeZoneInfo.TransitionTime t1, System.TimeZoneInfo.TransitionTime t2) { return default(bool); }
      public static bool operator !=(System.TimeZoneInfo.TransitionTime t1, System.TimeZoneInfo.TransitionTime t2) { return default(bool); }
    }
  }
  public partial class TimeZoneNotFoundException : System.Exception {
    public TimeZoneNotFoundException() { }
    protected TimeZoneNotFoundException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext sc) { }
    public TimeZoneNotFoundException(string message) { }
    public TimeZoneNotFoundException(string message, System.Exception e) { }
  }
}
namespace System.Collections.Generic {
  [System.Diagnostics.DebuggerDisplayAttribute("Count={Count}")]
  [System.Diagnostics.DebuggerTypeProxyAttribute(typeof(System.Collections.Generic.CollectionDebuggerView<T, U>))]
  public partial class HashSet<T> : System.Collections.Generic.ICollection<T>, System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable, System.Runtime.Serialization.IDeserializationCallback, System.Runtime.Serialization.ISerializable {
    public HashSet() { }
    public HashSet(System.Collections.Generic.IEnumerable<T> collection) { }
    public HashSet(System.Collections.Generic.IEnumerable<T> collection, System.Collections.Generic.IEqualityComparer<T> comparer) { }
    public HashSet(System.Collections.Generic.IEqualityComparer<T> comparer) { }
    protected HashSet(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public System.Collections.Generic.IEqualityComparer<T> Comparer { get { return default(System.Collections.Generic.IEqualityComparer<T>); } }
    public int Count { get { return default(int); } }
    bool System.Collections.Generic.ICollection<T>.IsReadOnly { get { return default(bool); } }
    public bool Add(T item) { return default(bool); }
    public void Clear() { }
    public bool Contains(T item) { return default(bool); }
    public void CopyTo(T[] array) { }
    public void CopyTo(T[] array, int arrayIndex) { }
    public void CopyTo(T[] array, int arrayIndex, int count) { }
    public static System.Collections.Generic.IEqualityComparer<System.Collections.Generic.HashSet<T>> CreateSetComparer() { return default(System.Collections.Generic.IEqualityComparer<System.Collections.Generic.HashSet<T>>); }
    public void ExceptWith(System.Collections.Generic.IEnumerable<T> other) { }
    public System.Collections.Generic.HashSet<T>.Enumerator GetEnumerator() { return default(System.Collections.Generic.HashSet<T>.Enumerator); }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(128))]
    public virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public void IntersectWith(System.Collections.Generic.IEnumerable<T> other) { }
    public bool IsProperSubsetOf(System.Collections.Generic.IEnumerable<T> other) { return default(bool); }
    public bool IsProperSupersetOf(System.Collections.Generic.IEnumerable<T> other) { return default(bool); }
    public bool IsSubsetOf(System.Collections.Generic.IEnumerable<T> other) { return default(bool); }
    public bool IsSupersetOf(System.Collections.Generic.IEnumerable<T> other) { return default(bool); }
    public virtual void OnDeserialization(object sender) { }
    public bool Overlaps(System.Collections.Generic.IEnumerable<T> other) { return default(bool); }
    public bool Remove(T item) { return default(bool); }
    public int RemoveWhere(System.Predicate<T> match) { return default(int); }
    public bool SetEquals(System.Collections.Generic.IEnumerable<T> other) { return default(bool); }
    public void SymmetricExceptWith(System.Collections.Generic.IEnumerable<T> other) { }
    void System.Collections.Generic.ICollection<T>.Add(T item) { }
    System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { return default(System.Collections.Generic.IEnumerator<T>); }
    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { return default(System.Collections.IEnumerator); }
    public void TrimExcess() { }
    public void UnionWith(System.Collections.Generic.IEnumerable<T> other) { }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct Enumerator : System.Collections.Generic.IEnumerator<T>, System.Collections.IEnumerator, System.IDisposable {
      public T Current { get { return default(T); } }
      object System.Collections.IEnumerator.Current { get { return default(object); } }
      public void Dispose() { }
      public bool MoveNext() { return default(bool); }
      void System.Collections.IEnumerator.Reset() { }
    }
  }
}
namespace System.IO {
  public enum HandleInheritability {
    Inheritable = 1,
    None = 0,
  }
}
namespace System.IO.Pipes {
  [System.MonoTODOAttribute("Anonymous pipes are not working even on win32, due to some access authorization issue")]
  [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, MayLeakOnAbort=true)]
  public sealed partial class AnonymousPipeClientStream : System.IO.Pipes.PipeStream {
    public AnonymousPipeClientStream(System.IO.Pipes.PipeDirection direction, Microsoft.Win32.SafeHandles.SafePipeHandle safePipeHandle) : base (default(System.IO.Pipes.PipeDirection), default(int)) { }
    public AnonymousPipeClientStream(System.IO.Pipes.PipeDirection direction, string pipeHandleAsString) : base (default(System.IO.Pipes.PipeDirection), default(int)) { }
    public AnonymousPipeClientStream(string pipeHandleAsString) : base (default(System.IO.Pipes.PipeDirection), default(int)) { }
    public override System.IO.Pipes.PipeTransmissionMode ReadMode { set { } }
    public override System.IO.Pipes.PipeTransmissionMode TransmissionMode { get { return default(System.IO.Pipes.PipeTransmissionMode); } }
    ~AnonymousPipeClientStream() { }
  }
  [System.MonoTODOAttribute("Anonymous pipes are not working even on win32, due to some access authorization issue")]
  [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, MayLeakOnAbort=true)]
  public sealed partial class AnonymousPipeServerStream : System.IO.Pipes.PipeStream {
    public AnonymousPipeServerStream() : base (default(System.IO.Pipes.PipeDirection), default(int)) { }
    public AnonymousPipeServerStream(System.IO.Pipes.PipeDirection direction) : base (default(System.IO.Pipes.PipeDirection), default(int)) { }
    [System.MonoTODOAttribute]
    public AnonymousPipeServerStream(System.IO.Pipes.PipeDirection direction, Microsoft.Win32.SafeHandles.SafePipeHandle serverSafePipeHandle, Microsoft.Win32.SafeHandles.SafePipeHandle clientSafePipeHandle) : base (default(System.IO.Pipes.PipeDirection), default(int)) { }
    public AnonymousPipeServerStream(System.IO.Pipes.PipeDirection direction, System.IO.HandleInheritability inheritability) : base (default(System.IO.Pipes.PipeDirection), default(int)) { }
    public AnonymousPipeServerStream(System.IO.Pipes.PipeDirection direction, System.IO.HandleInheritability inheritability, int bufferSize) : base (default(System.IO.Pipes.PipeDirection), default(int)) { }
    public AnonymousPipeServerStream(System.IO.Pipes.PipeDirection direction, System.IO.HandleInheritability inheritability, int bufferSize, System.IO.Pipes.PipeSecurity pipeSecurity) : base (default(System.IO.Pipes.PipeDirection), default(int)) { }
    [System.MonoTODOAttribute]
    public Microsoft.Win32.SafeHandles.SafePipeHandle ClientSafePipeHandle { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(Microsoft.Win32.SafeHandles.SafePipeHandle); } }
    public override System.IO.Pipes.PipeTransmissionMode ReadMode { set { } }
    public override System.IO.Pipes.PipeTransmissionMode TransmissionMode { get { return default(System.IO.Pipes.PipeTransmissionMode); } }
    [System.MonoTODOAttribute]
    public void DisposeLocalCopyOfClientHandle() { }
    public string GetClientHandleAsString() { return default(string); }
  }
  [System.MonoTODOAttribute("working only on win32 right now")]
  [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, MayLeakOnAbort=true)]
  public sealed partial class NamedPipeClientStream : System.IO.Pipes.PipeStream {
    public NamedPipeClientStream(System.IO.Pipes.PipeDirection direction, bool isAsync, bool isConnected, Microsoft.Win32.SafeHandles.SafePipeHandle safePipeHandle) : base (default(System.IO.Pipes.PipeDirection), default(int)) { }
    public NamedPipeClientStream(string pipeName) : base (default(System.IO.Pipes.PipeDirection), default(int)) { }
    public NamedPipeClientStream(string serverName, string pipeName) : base (default(System.IO.Pipes.PipeDirection), default(int)) { }
    public NamedPipeClientStream(string serverName, string pipeName, System.IO.Pipes.PipeAccessRights desiredAccessRights, System.IO.Pipes.PipeOptions options, System.Security.Principal.TokenImpersonationLevel impersonationLevel, System.IO.HandleInheritability inheritability) : base (default(System.IO.Pipes.PipeDirection), default(int)) { }
    public NamedPipeClientStream(string serverName, string pipeName, System.IO.Pipes.PipeDirection direction) : base (default(System.IO.Pipes.PipeDirection), default(int)) { }
    public NamedPipeClientStream(string serverName, string pipeName, System.IO.Pipes.PipeDirection direction, System.IO.Pipes.PipeOptions options) : base (default(System.IO.Pipes.PipeDirection), default(int)) { }
    public NamedPipeClientStream(string serverName, string pipeName, System.IO.Pipes.PipeDirection direction, System.IO.Pipes.PipeOptions options, System.Security.Principal.TokenImpersonationLevel impersonationLevel) : base (default(System.IO.Pipes.PipeDirection), default(int)) { }
    public NamedPipeClientStream(string serverName, string pipeName, System.IO.Pipes.PipeDirection direction, System.IO.Pipes.PipeOptions options, System.Security.Principal.TokenImpersonationLevel impersonationLevel, System.IO.HandleInheritability inheritability) : base (default(System.IO.Pipes.PipeDirection), default(int)) { }
    public int NumberOfServerInstances { get { return default(int); } }
    public void Connect() { }
    public void Connect(int timeout) { }
  }
  [System.MonoTODOAttribute("working only on win32 right now")]
  [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, MayLeakOnAbort=true)]
  public sealed partial class NamedPipeServerStream : System.IO.Pipes.PipeStream {
    public const int MaxAllowedServerInstances = -1;
    public NamedPipeServerStream(System.IO.Pipes.PipeDirection direction, bool isAsync, bool isConnected, Microsoft.Win32.SafeHandles.SafePipeHandle safePipeHandle) : base (default(System.IO.Pipes.PipeDirection), default(int)) { }
    public NamedPipeServerStream(string pipeName) : base (default(System.IO.Pipes.PipeDirection), default(int)) { }
    public NamedPipeServerStream(string pipeName, System.IO.Pipes.PipeDirection direction) : base (default(System.IO.Pipes.PipeDirection), default(int)) { }
    public NamedPipeServerStream(string pipeName, System.IO.Pipes.PipeDirection direction, int maxNumberOfServerInstances) : base (default(System.IO.Pipes.PipeDirection), default(int)) { }
    public NamedPipeServerStream(string pipeName, System.IO.Pipes.PipeDirection direction, int maxNumberOfServerInstances, System.IO.Pipes.PipeTransmissionMode transmissionMode) : base (default(System.IO.Pipes.PipeDirection), default(int)) { }
    public NamedPipeServerStream(string pipeName, System.IO.Pipes.PipeDirection direction, int maxNumberOfServerInstances, System.IO.Pipes.PipeTransmissionMode transmissionMode, System.IO.Pipes.PipeOptions options) : base (default(System.IO.Pipes.PipeDirection), default(int)) { }
    public NamedPipeServerStream(string pipeName, System.IO.Pipes.PipeDirection direction, int maxNumberOfServerInstances, System.IO.Pipes.PipeTransmissionMode transmissionMode, System.IO.Pipes.PipeOptions options, int inBufferSize, int outBufferSize) : base (default(System.IO.Pipes.PipeDirection), default(int)) { }
    public NamedPipeServerStream(string pipeName, System.IO.Pipes.PipeDirection direction, int maxNumberOfServerInstances, System.IO.Pipes.PipeTransmissionMode transmissionMode, System.IO.Pipes.PipeOptions options, int inBufferSize, int outBufferSize, System.IO.Pipes.PipeSecurity pipeSecurity) : base (default(System.IO.Pipes.PipeDirection), default(int)) { }
    public NamedPipeServerStream(string pipeName, System.IO.Pipes.PipeDirection direction, int maxNumberOfServerInstances, System.IO.Pipes.PipeTransmissionMode transmissionMode, System.IO.Pipes.PipeOptions options, int inBufferSize, int outBufferSize, System.IO.Pipes.PipeSecurity pipeSecurity, System.IO.HandleInheritability inheritability) : base (default(System.IO.Pipes.PipeDirection), default(int)) { }
    [System.MonoTODOAttribute]
    public NamedPipeServerStream(string pipeName, System.IO.Pipes.PipeDirection direction, int maxNumberOfServerInstances, System.IO.Pipes.PipeTransmissionMode transmissionMode, System.IO.Pipes.PipeOptions options, int inBufferSize, int outBufferSize, System.IO.Pipes.PipeSecurity pipeSecurity, System.IO.HandleInheritability inheritability, System.IO.Pipes.PipeAccessRights additionalAccessRights) : base (default(System.IO.Pipes.PipeDirection), default(int)) { }
    [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, ExternalThreading=true)]
    public System.IAsyncResult BeginWaitForConnection(System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    public void Disconnect() { }
    public void EndWaitForConnection(System.IAsyncResult asyncResult) { }
    [System.MonoTODOAttribute]
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(512))]
    public string GetImpersonationUserName() { return default(string); }
    [System.MonoTODOAttribute]
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(512))]
    public void RunAsClient(System.IO.Pipes.PipeStreamImpersonationWorker impersonationWorker) { }
    public void WaitForConnection() { }
  }
  [System.FlagsAttribute]
  public enum PipeAccessRights {
    AccessSystemSecurity = 16777216,
    ChangePermissions = 262144,
    CreateNewInstance = 4,
    Delete = 65536,
    FullControl = 2032031,
    Read = 131209,
    ReadAttributes = 128,
    ReadData = 1,
    ReadExtendedAttributes = 8,
    ReadPermissions = 131072,
    ReadWrite = 131483,
    Synchronize = 1048576,
    TakeOwnership = 524288,
    Write = 274,
    WriteAttributes = 256,
    WriteData = 2,
    WriteExtendedAttributes = 16,
  }
  [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, MayLeakOnAbort=true)]
  public sealed partial class PipeAccessRule : System.Security.AccessControl.AccessRule {
    public PipeAccessRule(System.Security.Principal.IdentityReference identity, System.IO.Pipes.PipeAccessRights rights, System.Security.AccessControl.AccessControlType type) : base (default(System.Security.Principal.IdentityReference), default(int), default(bool), default(System.Security.AccessControl.InheritanceFlags), default(System.Security.AccessControl.PropagationFlags), default(System.Security.AccessControl.AccessControlType)) { }
    public PipeAccessRule(string identity, System.IO.Pipes.PipeAccessRights rights, System.Security.AccessControl.AccessControlType type) : base (default(System.Security.Principal.IdentityReference), default(int), default(bool), default(System.Security.AccessControl.InheritanceFlags), default(System.Security.AccessControl.PropagationFlags), default(System.Security.AccessControl.AccessControlType)) { }
    public System.IO.Pipes.PipeAccessRights PipeAccessRights { get { return default(System.IO.Pipes.PipeAccessRights); } }
  }
  [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, MayLeakOnAbort=true)]
  public sealed partial class PipeAuditRule : System.Security.AccessControl.AuditRule {
    public PipeAuditRule(System.Security.Principal.IdentityReference identity, System.IO.Pipes.PipeAccessRights rights, System.Security.AccessControl.AuditFlags flags) : base (default(System.Security.Principal.IdentityReference), default(int), default(bool), default(System.Security.AccessControl.InheritanceFlags), default(System.Security.AccessControl.PropagationFlags), default(System.Security.AccessControl.AuditFlags)) { }
    public PipeAuditRule(string identity, System.IO.Pipes.PipeAccessRights rights, System.Security.AccessControl.AuditFlags flags) : base (default(System.Security.Principal.IdentityReference), default(int), default(bool), default(System.Security.AccessControl.InheritanceFlags), default(System.Security.AccessControl.PropagationFlags), default(System.Security.AccessControl.AuditFlags)) { }
    public System.IO.Pipes.PipeAccessRights PipeAccessRights { get { return default(System.IO.Pipes.PipeAccessRights); } }
  }
  public enum PipeDirection {
    In = 1,
    InOut = 3,
    Out = 2,
  }
  [System.FlagsAttribute]
  public enum PipeOptions {
    Asynchronous = 1073741824,
    None = 0,
    WriteThrough = -2147483648,
  }
  [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, MayLeakOnAbort=true)]
  public partial class PipeSecurity : System.Security.AccessControl.NativeObjectSecurity {
    public PipeSecurity() : base (default(bool), default(System.Security.AccessControl.ResourceType)) { }
    public override System.Type AccessRightType { get { return default(System.Type); } }
    public override System.Type AccessRuleType { get { return default(System.Type); } }
    public override System.Type AuditRuleType { get { return default(System.Type); } }
    public override System.Security.AccessControl.AccessRule AccessRuleFactory(System.Security.Principal.IdentityReference identityReference, int accessMask, bool isInherited, System.Security.AccessControl.InheritanceFlags inheritanceFlags, System.Security.AccessControl.PropagationFlags propagationFlags, System.Security.AccessControl.AccessControlType type) { return default(System.Security.AccessControl.AccessRule); }
    public void AddAccessRule(System.IO.Pipes.PipeAccessRule rule) { }
    public void AddAuditRule(System.IO.Pipes.PipeAuditRule rule) { }
    public sealed override System.Security.AccessControl.AuditRule AuditRuleFactory(System.Security.Principal.IdentityReference identityReference, int accessMask, bool isInherited, System.Security.AccessControl.InheritanceFlags inheritanceFlags, System.Security.AccessControl.PropagationFlags propagationFlags, System.Security.AccessControl.AuditFlags flags) { return default(System.Security.AccessControl.AuditRule); }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Assert, UnmanagedCode=true)]
    protected internal void Persist(System.Runtime.InteropServices.SafeHandle handle) { }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Assert, UnmanagedCode=true)]
    protected internal void Persist(string name) { }
    public bool RemoveAccessRule(System.IO.Pipes.PipeAccessRule rule) { return default(bool); }
    public void RemoveAccessRuleSpecific(System.IO.Pipes.PipeAccessRule rule) { }
    public bool RemoveAuditRule(System.IO.Pipes.PipeAuditRule rule) { return default(bool); }
    public void RemoveAuditRuleAll(System.IO.Pipes.PipeAuditRule rule) { }
    public void RemoveAuditRuleSpecific(System.IO.Pipes.PipeAuditRule rule) { }
    public void ResetAccessRule(System.IO.Pipes.PipeAccessRule rule) { }
    public void SetAccessRule(System.IO.Pipes.PipeAccessRule rule) { }
    public void SetAuditRule(System.IO.Pipes.PipeAuditRule rule) { }
  }
  [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Name="FullTrust")]
  [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, MayLeakOnAbort=true)]
  public abstract partial class PipeStream : System.IO.Stream {
    protected PipeStream(System.IO.Pipes.PipeDirection direction, int bufferSize) { }
    protected PipeStream(System.IO.Pipes.PipeDirection direction, System.IO.Pipes.PipeTransmissionMode transmissionMode, int outBufferSize) { }
    public override bool CanRead { get { return default(bool); } }
    public override bool CanSeek { get { return default(bool); } }
    public override bool CanWrite { get { return default(bool); } }
    public virtual int InBufferSize { get { return default(int); } }
    public bool IsAsync { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } }
    public bool IsConnected { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]protected set { } }
    protected bool IsHandleExposed { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } }
    [System.MonoTODOAttribute]
    public bool IsMessageComplete { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } }
    public override long Length { get { return default(long); } }
    [System.MonoTODOAttribute]
    public virtual int OutBufferSize { get { return default(int); } }
    public override long Position { get { return default(long); } set { } }
    public virtual System.IO.Pipes.PipeTransmissionMode ReadMode { get { return default(System.IO.Pipes.PipeTransmissionMode); } set { } }
    public Microsoft.Win32.SafeHandles.SafePipeHandle SafePipeHandle { get { return default(Microsoft.Win32.SafeHandles.SafePipeHandle); } }
    public virtual System.IO.Pipes.PipeTransmissionMode TransmissionMode { get { return default(System.IO.Pipes.PipeTransmissionMode); } }
    [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, ExternalThreading=true)]
    public override System.IAsyncResult BeginRead(System.Byte[] buffer, int offset, int count, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, ExternalThreading=true)]
    public override System.IAsyncResult BeginWrite(System.Byte[] buffer, int offset, int count, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    [System.MonoTODOAttribute]
    protected internal virtual void CheckPipePropertyOperations() { }
    [System.MonoTODOAttribute]
    protected internal void CheckReadOperations() { }
    [System.MonoTODOAttribute]
    protected internal void CheckWriteOperations() { }
    protected override void Dispose(bool disposing) { }
    public override int EndRead(System.IAsyncResult asyncResult) { return default(int); }
    public override void EndWrite(System.IAsyncResult asyncResult) { }
    [System.MonoTODOAttribute]
    public override void Flush() { }
    public System.IO.Pipes.PipeSecurity GetAccessControl() { return default(System.IO.Pipes.PipeSecurity); }
    protected void InitializeHandle(Microsoft.Win32.SafeHandles.SafePipeHandle handle, bool isExposed, bool isAsync) { }
    [System.MonoTODOAttribute]
    public override int Read(System.Byte[] buffer, int offset, int count) { return default(int); }
    [System.MonoTODOAttribute]
    public override int ReadByte() { return default(int); }
    public override long Seek(long offset, System.IO.SeekOrigin origin) { return default(long); }
    public void SetAccessControl(System.IO.Pipes.PipeSecurity pipeSecurity) { }
    public override void SetLength(long value) { }
    public void WaitForPipeDrain() { }
    [System.MonoTODOAttribute]
    public override void Write(System.Byte[] buffer, int offset, int count) { }
    [System.MonoTODOAttribute]
    public override void WriteByte(byte value) { }
  }
  public delegate void PipeStreamImpersonationWorker();
  public enum PipeTransmissionMode {
    Byte = 0,
    Message = 1,
  }
}
namespace System.Linq {
  public static partial class Enumerable {
    public static TSource Aggregate<TSource>(this System.Collections.Generic.IEnumerable<TSource> source, System.Func<TSource, TSource, TSource> func) { return default(TSource); }
    public static TAccumulate Aggregate<TSource, TAccumulate>(this System.Collections.Generic.IEnumerable<TSource> source, TAccumulate seed, System.Func<TAccumulate, TSource, TAccumulate> func) { return default(TAccumulate); }
    public static TResult Aggregate<TSource, TAccumulate, TResult>(this System.Collections.Generic.IEnumerable<TSource> source, TAccumulate seed, System.Func<TAccumulate, TSource, TAccumulate> func, System.Func<TAccumulate, TResult> resultSelector) { return default(TResult); }
    public static bool All<TSource>(this System.Collections.Generic.IEnumerable<TSource> source, System.Func<TSource, System.Boolean> predicate) { return default(bool); }
    public static bool Any<TSource>(this System.Collections.Generic.IEnumerable<TSource> source) { return default(bool); }
    public static bool Any<TSource>(this System.Collections.Generic.IEnumerable<TSource> source, System.Func<TSource, System.Boolean> predicate) { return default(bool); }
    public static System.Collections.Generic.IEnumerable<TSource> AsEnumerable<TSource>(this System.Collections.Generic.IEnumerable<TSource> source) { return default(System.Collections.Generic.IEnumerable<TSource>); }
    public static decimal Average(this System.Collections.Generic.IEnumerable<System.Decimal> source) { return default(decimal); }
    public static double Average(this System.Collections.Generic.IEnumerable<System.Double> source) { return default(double); }
    public static double Average(this System.Collections.Generic.IEnumerable<System.Int32> source) { return default(double); }
    public static double Average(this System.Collections.Generic.IEnumerable<System.Int64> source) { return default(double); }
    public static System.Nullable<System.Decimal> Average(this System.Collections.Generic.IEnumerable<System.Nullable<System.Decimal>> source) { return default(System.Nullable<System.Decimal>); }
    public static System.Nullable<System.Double> Average(this System.Collections.Generic.IEnumerable<System.Nullable<System.Double>> source) { return default(System.Nullable<System.Double>); }
    public static System.Nullable<System.Double> Average(this System.Collections.Generic.IEnumerable<System.Nullable<System.Int32>> source) { return default(System.Nullable<System.Double>); }
    public static System.Nullable<System.Double> Average(this System.Collections.Generic.IEnumerable<System.Nullable<System.Int64>> source) { return default(System.Nullable<System.Double>); }
    public static System.Nullable<System.Single> Average(this System.Collections.Generic.IEnumerable<System.Nullable<System.Single>> source) { return default(System.Nullable<System.Single>); }
    public static float Average(this System.Collections.Generic.IEnumerable<System.Single> source) { return default(float); }
    public static decimal Average<TSource>(this System.Collections.Generic.IEnumerable<TSource> source, System.Func<TSource, System.Decimal> selector) { return default(decimal); }
    public static double Average<TSource>(this System.Collections.Generic.IEnumerable<TSource> source, System.Func<TSource, System.Double> selector) { return default(double); }
    public static double Average<TSource>(this System.Collections.Generic.IEnumerable<TSource> source, System.Func<TSource, System.Int32> selector) { return default(double); }
    public static double Average<TSource>(this System.Collections.Generic.IEnumerable<TSource> source, System.Func<TSource, System.Int64> selector) { return default(double); }
    public static System.Nullable<System.Decimal> Average<TSource>(this System.Collections.Generic.IEnumerable<TSource> source, System.Func<TSource, System.Nullable<System.Decimal>> selector) { return default(System.Nullable<System.Decimal>); }
    public static System.Nullable<System.Double> Average<TSource>(this System.Collections.Generic.IEnumerable<TSource> source, System.Func<TSource, System.Nullable<System.Double>> selector) { return default(System.Nullable<System.Double>); }
    public static System.Nullable<System.Double> Average<TSource>(this System.Collections.Generic.IEnumerable<TSource> source, System.Func<TSource, System.Nullable<System.Int32>> selector) { return default(System.Nullable<System.Double>); }
    public static System.Nullable<System.Double> Average<TSource>(this System.Collections.Generic.IEnumerable<TSource> source, System.Func<TSource, System.Nullable<System.Int64>> selector) { return default(System.Nullable<System.Double>); }
    public static System.Nullable<System.Single> Average<TSource>(this System.Collections.Generic.IEnumerable<TSource> source, System.Func<TSource, System.Nullable<System.Single>> selector) { return default(System.Nullable<System.Single>); }
    public static float Average<TSource>(this System.Collections.Generic.IEnumerable<TSource> source, System.Func<TSource, System.Single> selector) { return default(float); }
    public static System.Collections.Generic.IEnumerable<TResult> Cast<TResult>(this System.Collections.IEnumerable source) { return default(System.Collections.Generic.IEnumerable<TResult>); }
    public static System.Collections.Generic.IEnumerable<TSource> Concat<TSource>(this System.Collections.Generic.IEnumerable<TSource> first, System.Collections.Generic.IEnumerable<TSource> second) { return default(System.Collections.Generic.IEnumerable<TSource>); }
    public static bool Contains<TSource>(this System.Collections.Generic.IEnumerable<TSource> source, TSource value) { return default(bool); }
    public static bool Contains<TSource>(this System.Collections.Generic.IEnumerable<TSource> source, TSource value, System.Collections.Generic.IEqualityComparer<TSource> comparer) { return default(bool); }
    public static int Count<TSource>(this System.Collections.Generic.IEnumerable<TSource> source) { return default(int); }
    public static int Count<TSource>(this System.Collections.Generic.IEnumerable<TSource> source, System.Func<TSource, System.Boolean> predicate) { return default(int); }
    public static System.Collections.Generic.IEnumerable<TSource> DefaultIfEmpty<TSource>(this System.Collections.Generic.IEnumerable<TSource> source) { return default(System.Collections.Generic.IEnumerable<TSource>); }
    public static System.Collections.Generic.IEnumerable<TSource> DefaultIfEmpty<TSource>(this System.Collections.Generic.IEnumerable<TSource> source, TSource defaultValue) { return default(System.Collections.Generic.IEnumerable<TSource>); }
    public static System.Collections.Generic.IEnumerable<TSource> Distinct<TSource>(this System.Collections.Generic.IEnumerable<TSource> source) { return default(System.Collections.Generic.IEnumerable<TSource>); }
    public static System.Collections.Generic.IEnumerable<TSource> Distinct<TSource>(this System.Collections.Generic.IEnumerable<TSource> source, System.Collections.Generic.IEqualityComparer<TSource> comparer) { return default(System.Collections.Generic.IEnumerable<TSource>); }
    public static TSource ElementAt<TSource>(this System.Collections.Generic.IEnumerable<TSource> source, int index) { return default(TSource); }
    public static TSource ElementAtOrDefault<TSource>(this System.Collections.Generic.IEnumerable<TSource> source, int index) { return default(TSource); }
    public static System.Collections.Generic.IEnumerable<TResult> Empty<TResult>() { return default(System.Collections.Generic.IEnumerable<TResult>); }
    public static System.Collections.Generic.IEnumerable<TSource> Except<TSource>(this System.Collections.Generic.IEnumerable<TSource> first, System.Collections.Generic.IEnumerable<TSource> second) { return default(System.Collections.Generic.IEnumerable<TSource>); }
    public static System.Collections.Generic.IEnumerable<TSource> Except<TSource>(this System.Collections.Generic.IEnumerable<TSource> first, System.Collections.Generic.IEnumerable<TSource> second, System.Collections.Generic.IEqualityComparer<TSource> comparer) { return default(System.Collections.Generic.IEnumerable<TSource>); }
    public static TSource First<TSource>(this System.Collections.Generic.IEnumerable<TSource> source) { return default(TSource); }
    public static TSource First<TSource>(this System.Collections.Generic.IEnumerable<TSource> source, System.Func<TSource, System.Boolean> predicate) { return default(TSource); }
    public static TSource FirstOrDefault<TSource>(this System.Collections.Generic.IEnumerable<TSource> source) { return default(TSource); }
    public static TSource FirstOrDefault<TSource>(this System.Collections.Generic.IEnumerable<TSource> source, System.Func<TSource, System.Boolean> predicate) { return default(TSource); }
    public static System.Collections.Generic.IEnumerable<System.Linq.IGrouping<TKey, TSource>> GroupBy<TSource, TKey>(this System.Collections.Generic.IEnumerable<TSource> source, System.Func<TSource, TKey> keySelector) { return default(System.Collections.Generic.IEnumerable<System.Linq.IGrouping<TKey, TSource>>); }
    public static System.Collections.Generic.IEnumerable<System.Linq.IGrouping<TKey, TSource>> GroupBy<TSource, TKey>(this System.Collections.Generic.IEnumerable<TSource> source, System.Func<TSource, TKey> keySelector, System.Collections.Generic.IEqualityComparer<TKey> comparer) { return default(System.Collections.Generic.IEnumerable<System.Linq.IGrouping<TKey, TSource>>); }
    public static System.Collections.Generic.IEnumerable<System.Linq.IGrouping<TKey, TElement>> GroupBy<TSource, TKey, TElement>(this System.Collections.Generic.IEnumerable<TSource> source, System.Func<TSource, TKey> keySelector, System.Func<TSource, TElement> elementSelector) { return default(System.Collections.Generic.IEnumerable<System.Linq.IGrouping<TKey, TElement>>); }
    public static System.Collections.Generic.IEnumerable<System.Linq.IGrouping<TKey, TElement>> GroupBy<TSource, TKey, TElement>(this System.Collections.Generic.IEnumerable<TSource> source, System.Func<TSource, TKey> keySelector, System.Func<TSource, TElement> elementSelector, System.Collections.Generic.IEqualityComparer<TKey> comparer) { return default(System.Collections.Generic.IEnumerable<System.Linq.IGrouping<TKey, TElement>>); }
    public static System.Collections.Generic.IEnumerable<TResult> GroupBy<TSource, TKey, TResult>(this System.Collections.Generic.IEnumerable<TSource> source, System.Func<TSource, TKey> keySelector, System.Func<TKey, System.Collections.Generic.IEnumerable<TSource>, TResult> resultSelector) { return default(System.Collections.Generic.IEnumerable<TResult>); }
    public static System.Collections.Generic.IEnumerable<TResult> GroupBy<TSource, TKey, TResult>(this System.Collections.Generic.IEnumerable<TSource> source, System.Func<TSource, TKey> keySelector, System.Func<TKey, System.Collections.Generic.IEnumerable<TSource>, TResult> resultSelector, System.Collections.Generic.IEqualityComparer<TKey> comparer) { return default(System.Collections.Generic.IEnumerable<TResult>); }
    public static System.Collections.Generic.IEnumerable<TResult> GroupBy<TSource, TKey, TElement, TResult>(this System.Collections.Generic.IEnumerable<TSource> source, System.Func<TSource, TKey> keySelector, System.Func<TSource, TElement> elementSelector, System.Func<TKey, System.Collections.Generic.IEnumerable<TElement>, TResult> resultSelector) { return default(System.Collections.Generic.IEnumerable<TResult>); }
    public static System.Collections.Generic.IEnumerable<TResult> GroupBy<TSource, TKey, TElement, TResult>(this System.Collections.Generic.IEnumerable<TSource> source, System.Func<TSource, TKey> keySelector, System.Func<TSource, TElement> elementSelector, System.Func<TKey, System.Collections.Generic.IEnumerable<TElement>, TResult> resultSelector, System.Collections.Generic.IEqualityComparer<TKey> comparer) { return default(System.Collections.Generic.IEnumerable<TResult>); }
    public static System.Collections.Generic.IEnumerable<TResult> GroupJoin<TOuter, TInner, TKey, TResult>(this System.Collections.Generic.IEnumerable<TOuter> outer, System.Collections.Generic.IEnumerable<TInner> inner, System.Func<TOuter, TKey> outerKeySelector, System.Func<TInner, TKey> innerKeySelector, System.Func<TOuter, System.Collections.Generic.IEnumerable<TInner>, TResult> resultSelector) { return default(System.Collections.Generic.IEnumerable<TResult>); }
    public static System.Collections.Generic.IEnumerable<TResult> GroupJoin<TOuter, TInner, TKey, TResult>(this System.Collections.Generic.IEnumerable<TOuter> outer, System.Collections.Generic.IEnumerable<TInner> inner, System.Func<TOuter, TKey> outerKeySelector, System.Func<TInner, TKey> innerKeySelector, System.Func<TOuter, System.Collections.Generic.IEnumerable<TInner>, TResult> resultSelector, System.Collections.Generic.IEqualityComparer<TKey> comparer) { return default(System.Collections.Generic.IEnumerable<TResult>); }
    public static System.Collections.Generic.IEnumerable<TSource> Intersect<TSource>(this System.Collections.Generic.IEnumerable<TSource> first, System.Collections.Generic.IEnumerable<TSource> second) { return default(System.Collections.Generic.IEnumerable<TSource>); }
    public static System.Collections.Generic.IEnumerable<TSource> Intersect<TSource>(this System.Collections.Generic.IEnumerable<TSource> first, System.Collections.Generic.IEnumerable<TSource> second, System.Collections.Generic.IEqualityComparer<TSource> comparer) { return default(System.Collections.Generic.IEnumerable<TSource>); }
    public static System.Collections.Generic.IEnumerable<TResult> Join<TOuter, TInner, TKey, TResult>(this System.Collections.Generic.IEnumerable<TOuter> outer, System.Collections.Generic.IEnumerable<TInner> inner, System.Func<TOuter, TKey> outerKeySelector, System.Func<TInner, TKey> innerKeySelector, System.Func<TOuter, TInner, TResult> resultSelector) { return default(System.Collections.Generic.IEnumerable<TResult>); }
    public static System.Collections.Generic.IEnumerable<TResult> Join<TOuter, TInner, TKey, TResult>(this System.Collections.Generic.IEnumerable<TOuter> outer, System.Collections.Generic.IEnumerable<TInner> inner, System.Func<TOuter, TKey> outerKeySelector, System.Func<TInner, TKey> innerKeySelector, System.Func<TOuter, TInner, TResult> resultSelector, System.Collections.Generic.IEqualityComparer<TKey> comparer) { return default(System.Collections.Generic.IEnumerable<TResult>); }
    public static TSource Last<TSource>(this System.Collections.Generic.IEnumerable<TSource> source) { return default(TSource); }
    public static TSource Last<TSource>(this System.Collections.Generic.IEnumerable<TSource> source, System.Func<TSource, System.Boolean> predicate) { return default(TSource); }
    public static TSource LastOrDefault<TSource>(this System.Collections.Generic.IEnumerable<TSource> source) { return default(TSource); }
    public static TSource LastOrDefault<TSource>(this System.Collections.Generic.IEnumerable<TSource> source, System.Func<TSource, System.Boolean> predicate) { return default(TSource); }
    public static long LongCount<TSource>(this System.Collections.Generic.IEnumerable<TSource> source) { return default(long); }
    public static long LongCount<TSource>(this System.Collections.Generic.IEnumerable<TSource> source, System.Func<TSource, System.Boolean> predicate) { return default(long); }
    public static decimal Max(this System.Collections.Generic.IEnumerable<System.Decimal> source) { return default(decimal); }
    public static double Max(this System.Collections.Generic.IEnumerable<System.Double> source) { return default(double); }
    public static int Max(this System.Collections.Generic.IEnumerable<System.Int32> source) { return default(int); }
    public static long Max(this System.Collections.Generic.IEnumerable<System.Int64> source) { return default(long); }
    public static System.Nullable<System.Decimal> Max(this System.Collections.Generic.IEnumerable<System.Nullable<System.Decimal>> source) { return default(System.Nullable<System.Decimal>); }
    public static System.Nullable<System.Double> Max(this System.Collections.Generic.IEnumerable<System.Nullable<System.Double>> source) { return default(System.Nullable<System.Double>); }
    public static System.Nullable<System.Int32> Max(this System.Collections.Generic.IEnumerable<System.Nullable<System.Int32>> source) { return default(System.Nullable<System.Int32>); }
    public static System.Nullable<System.Int64> Max(this System.Collections.Generic.IEnumerable<System.Nullable<System.Int64>> source) { return default(System.Nullable<System.Int64>); }
    public static System.Nullable<System.Single> Max(this System.Collections.Generic.IEnumerable<System.Nullable<System.Single>> source) { return default(System.Nullable<System.Single>); }
    public static float Max(this System.Collections.Generic.IEnumerable<System.Single> source) { return default(float); }
    public static TSource Max<TSource>(this System.Collections.Generic.IEnumerable<TSource> source) { return default(TSource); }
    public static decimal Max<TSource>(this System.Collections.Generic.IEnumerable<TSource> source, System.Func<TSource, System.Decimal> selector) { return default(decimal); }
    public static double Max<TSource>(this System.Collections.Generic.IEnumerable<TSource> source, System.Func<TSource, System.Double> selector) { return default(double); }
    public static int Max<TSource>(this System.Collections.Generic.IEnumerable<TSource> source, System.Func<TSource, System.Int32> selector) { return default(int); }
    public static long Max<TSource>(this System.Collections.Generic.IEnumerable<TSource> source, System.Func<TSource, System.Int64> selector) { return default(long); }
    public static System.Nullable<System.Decimal> Max<TSource>(this System.Collections.Generic.IEnumerable<TSource> source, System.Func<TSource, System.Nullable<System.Decimal>> selector) { return default(System.Nullable<System.Decimal>); }
    public static System.Nullable<System.Double> Max<TSource>(this System.Collections.Generic.IEnumerable<TSource> source, System.Func<TSource, System.Nullable<System.Double>> selector) { return default(System.Nullable<System.Double>); }
    public static System.Nullable<System.Int32> Max<TSource>(this System.Collections.Generic.IEnumerable<TSource> source, System.Func<TSource, System.Nullable<System.Int32>> selector) { return default(System.Nullable<System.Int32>); }
    public static System.Nullable<System.Int64> Max<TSource>(this System.Collections.Generic.IEnumerable<TSource> source, System.Func<TSource, System.Nullable<System.Int64>> selector) { return default(System.Nullable<System.Int64>); }
    public static System.Nullable<System.Single> Max<TSource>(this System.Collections.Generic.IEnumerable<TSource> source, System.Func<TSource, System.Nullable<System.Single>> selector) { return default(System.Nullable<System.Single>); }
    public static float Max<TSource>(this System.Collections.Generic.IEnumerable<TSource> source, System.Func<TSource, System.Single> selector) { return default(float); }
    public static TResult Max<TSource, TResult>(this System.Collections.Generic.IEnumerable<TSource> source, System.Func<TSource, TResult> selector) { return default(TResult); }
    public static decimal Min(this System.Collections.Generic.IEnumerable<System.Decimal> source) { return default(decimal); }
    public static double Min(this System.Collections.Generic.IEnumerable<System.Double> source) { return default(double); }
    public static int Min(this System.Collections.Generic.IEnumerable<System.Int32> source) { return default(int); }
    public static long Min(this System.Collections.Generic.IEnumerable<System.Int64> source) { return default(long); }
    public static System.Nullable<System.Decimal> Min(this System.Collections.Generic.IEnumerable<System.Nullable<System.Decimal>> source) { return default(System.Nullable<System.Decimal>); }
    public static System.Nullable<System.Double> Min(this System.Collections.Generic.IEnumerable<System.Nullable<System.Double>> source) { return default(System.Nullable<System.Double>); }
    public static System.Nullable<System.Int32> Min(this System.Collections.Generic.IEnumerable<System.Nullable<System.Int32>> source) { return default(System.Nullable<System.Int32>); }
    public static System.Nullable<System.Int64> Min(this System.Collections.Generic.IEnumerable<System.Nullable<System.Int64>> source) { return default(System.Nullable<System.Int64>); }
    public static System.Nullable<System.Single> Min(this System.Collections.Generic.IEnumerable<System.Nullable<System.Single>> source) { return default(System.Nullable<System.Single>); }
    public static float Min(this System.Collections.Generic.IEnumerable<System.Single> source) { return default(float); }
    public static TSource Min<TSource>(this System.Collections.Generic.IEnumerable<TSource> source) { return default(TSource); }
    public static decimal Min<TSource>(this System.Collections.Generic.IEnumerable<TSource> source, System.Func<TSource, System.Decimal> selector) { return default(decimal); }
    public static double Min<TSource>(this System.Collections.Generic.IEnumerable<TSource> source, System.Func<TSource, System.Double> selector) { return default(double); }
    public static int Min<TSource>(this System.Collections.Generic.IEnumerable<TSource> source, System.Func<TSource, System.Int32> selector) { return default(int); }
    public static long Min<TSource>(this System.Collections.Generic.IEnumerable<TSource> source, System.Func<TSource, System.Int64> selector) { return default(long); }
    public static System.Nullable<System.Decimal> Min<TSource>(this System.Collections.Generic.IEnumerable<TSource> source, System.Func<TSource, System.Nullable<System.Decimal>> selector) { return default(System.Nullable<System.Decimal>); }
    public static System.Nullable<System.Double> Min<TSource>(this System.Collections.Generic.IEnumerable<TSource> source, System.Func<TSource, System.Nullable<System.Double>> selector) { return default(System.Nullable<System.Double>); }
    public static System.Nullable<System.Int32> Min<TSource>(this System.Collections.Generic.IEnumerable<TSource> source, System.Func<TSource, System.Nullable<System.Int32>> selector) { return default(System.Nullable<System.Int32>); }
    public static System.Nullable<System.Int64> Min<TSource>(this System.Collections.Generic.IEnumerable<TSource> source, System.Func<TSource, System.Nullable<System.Int64>> selector) { return default(System.Nullable<System.Int64>); }
    public static System.Nullable<System.Single> Min<TSource>(this System.Collections.Generic.IEnumerable<TSource> source, System.Func<TSource, System.Nullable<System.Single>> selector) { return default(System.Nullable<System.Single>); }
    public static float Min<TSource>(this System.Collections.Generic.IEnumerable<TSource> source, System.Func<TSource, System.Single> selector) { return default(float); }
    public static TResult Min<TSource, TResult>(this System.Collections.Generic.IEnumerable<TSource> source, System.Func<TSource, TResult> selector) { return default(TResult); }
    public static System.Collections.Generic.IEnumerable<TResult> OfType<TResult>(this System.Collections.IEnumerable source) { return default(System.Collections.Generic.IEnumerable<TResult>); }
    public static System.Linq.IOrderedEnumerable<TSource> OrderBy<TSource, TKey>(this System.Collections.Generic.IEnumerable<TSource> source, System.Func<TSource, TKey> keySelector) { return default(System.Linq.IOrderedEnumerable<TSource>); }
    public static System.Linq.IOrderedEnumerable<TSource> OrderBy<TSource, TKey>(this System.Collections.Generic.IEnumerable<TSource> source, System.Func<TSource, TKey> keySelector, System.Collections.Generic.IComparer<TKey> comparer) { return default(System.Linq.IOrderedEnumerable<TSource>); }
    public static System.Linq.IOrderedEnumerable<TSource> OrderByDescending<TSource, TKey>(this System.Collections.Generic.IEnumerable<TSource> source, System.Func<TSource, TKey> keySelector) { return default(System.Linq.IOrderedEnumerable<TSource>); }
    public static System.Linq.IOrderedEnumerable<TSource> OrderByDescending<TSource, TKey>(this System.Collections.Generic.IEnumerable<TSource> source, System.Func<TSource, TKey> keySelector, System.Collections.Generic.IComparer<TKey> comparer) { return default(System.Linq.IOrderedEnumerable<TSource>); }
    public static System.Collections.Generic.IEnumerable<System.Int32> Range(int start, int count) { return default(System.Collections.Generic.IEnumerable<System.Int32>); }
    public static System.Collections.Generic.IEnumerable<TResult> Repeat<TResult>(TResult element, int count) { return default(System.Collections.Generic.IEnumerable<TResult>); }
    public static System.Collections.Generic.IEnumerable<TSource> Reverse<TSource>(this System.Collections.Generic.IEnumerable<TSource> source) { return default(System.Collections.Generic.IEnumerable<TSource>); }
    public static System.Collections.Generic.IEnumerable<TResult> Select<TSource, TResult>(this System.Collections.Generic.IEnumerable<TSource> source, System.Func<TSource, TResult> selector) { return default(System.Collections.Generic.IEnumerable<TResult>); }
    public static System.Collections.Generic.IEnumerable<TResult> Select<TSource, TResult>(this System.Collections.Generic.IEnumerable<TSource> source, System.Func<TSource, System.Int32, TResult> selector) { return default(System.Collections.Generic.IEnumerable<TResult>); }
    public static System.Collections.Generic.IEnumerable<TResult> SelectMany<TSource, TResult>(this System.Collections.Generic.IEnumerable<TSource> source, System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>> selector) { return default(System.Collections.Generic.IEnumerable<TResult>); }
    public static System.Collections.Generic.IEnumerable<TResult> SelectMany<TSource, TResult>(this System.Collections.Generic.IEnumerable<TSource> source, System.Func<TSource, System.Int32, System.Collections.Generic.IEnumerable<TResult>> selector) { return default(System.Collections.Generic.IEnumerable<TResult>); }
    public static System.Collections.Generic.IEnumerable<TResult> SelectMany<TSource, TCollection, TResult>(this System.Collections.Generic.IEnumerable<TSource> source, System.Func<TSource, System.Collections.Generic.IEnumerable<TCollection>> collectionSelector, System.Func<TSource, TCollection, TResult> resultSelector) { return default(System.Collections.Generic.IEnumerable<TResult>); }
    public static System.Collections.Generic.IEnumerable<TResult> SelectMany<TSource, TCollection, TResult>(this System.Collections.Generic.IEnumerable<TSource> source, System.Func<TSource, System.Int32, System.Collections.Generic.IEnumerable<TCollection>> collectionSelector, System.Func<TSource, TCollection, TResult> resultSelector) { return default(System.Collections.Generic.IEnumerable<TResult>); }
    public static bool SequenceEqual<TSource>(this System.Collections.Generic.IEnumerable<TSource> first, System.Collections.Generic.IEnumerable<TSource> second) { return default(bool); }
    public static bool SequenceEqual<TSource>(this System.Collections.Generic.IEnumerable<TSource> first, System.Collections.Generic.IEnumerable<TSource> second, System.Collections.Generic.IEqualityComparer<TSource> comparer) { return default(bool); }
    public static TSource Single<TSource>(this System.Collections.Generic.IEnumerable<TSource> source) { return default(TSource); }
    public static TSource Single<TSource>(this System.Collections.Generic.IEnumerable<TSource> source, System.Func<TSource, System.Boolean> predicate) { return default(TSource); }
    public static TSource SingleOrDefault<TSource>(this System.Collections.Generic.IEnumerable<TSource> source) { return default(TSource); }
    public static TSource SingleOrDefault<TSource>(this System.Collections.Generic.IEnumerable<TSource> source, System.Func<TSource, System.Boolean> predicate) { return default(TSource); }
    public static System.Collections.Generic.IEnumerable<TSource> Skip<TSource>(this System.Collections.Generic.IEnumerable<TSource> source, int count) { return default(System.Collections.Generic.IEnumerable<TSource>); }
    public static System.Collections.Generic.IEnumerable<TSource> SkipWhile<TSource>(this System.Collections.Generic.IEnumerable<TSource> source, System.Func<TSource, System.Boolean> predicate) { return default(System.Collections.Generic.IEnumerable<TSource>); }
    public static System.Collections.Generic.IEnumerable<TSource> SkipWhile<TSource>(this System.Collections.Generic.IEnumerable<TSource> source, System.Func<TSource, System.Int32, System.Boolean> predicate) { return default(System.Collections.Generic.IEnumerable<TSource>); }
    public static decimal Sum(this System.Collections.Generic.IEnumerable<System.Decimal> source) { return default(decimal); }
    public static double Sum(this System.Collections.Generic.IEnumerable<System.Double> source) { return default(double); }
    public static int Sum(this System.Collections.Generic.IEnumerable<System.Int32> source) { return default(int); }
    public static long Sum(this System.Collections.Generic.IEnumerable<System.Int64> source) { return default(long); }
    public static System.Nullable<System.Decimal> Sum(this System.Collections.Generic.IEnumerable<System.Nullable<System.Decimal>> source) { return default(System.Nullable<System.Decimal>); }
    public static System.Nullable<System.Double> Sum(this System.Collections.Generic.IEnumerable<System.Nullable<System.Double>> source) { return default(System.Nullable<System.Double>); }
    public static System.Nullable<System.Int32> Sum(this System.Collections.Generic.IEnumerable<System.Nullable<System.Int32>> source) { return default(System.Nullable<System.Int32>); }
    public static System.Nullable<System.Int64> Sum(this System.Collections.Generic.IEnumerable<System.Nullable<System.Int64>> source) { return default(System.Nullable<System.Int64>); }
    public static System.Nullable<System.Single> Sum(this System.Collections.Generic.IEnumerable<System.Nullable<System.Single>> source) { return default(System.Nullable<System.Single>); }
    public static float Sum(this System.Collections.Generic.IEnumerable<System.Single> source) { return default(float); }
    public static decimal Sum<TSource>(this System.Collections.Generic.IEnumerable<TSource> source, System.Func<TSource, System.Decimal> selector) { return default(decimal); }
    public static double Sum<TSource>(this System.Collections.Generic.IEnumerable<TSource> source, System.Func<TSource, System.Double> selector) { return default(double); }
    public static int Sum<TSource>(this System.Collections.Generic.IEnumerable<TSource> source, System.Func<TSource, System.Int32> selector) { return default(int); }
    public static long Sum<TSource>(this System.Collections.Generic.IEnumerable<TSource> source, System.Func<TSource, System.Int64> selector) { return default(long); }
    public static System.Nullable<System.Decimal> Sum<TSource>(this System.Collections.Generic.IEnumerable<TSource> source, System.Func<TSource, System.Nullable<System.Decimal>> selector) { return default(System.Nullable<System.Decimal>); }
    public static System.Nullable<System.Double> Sum<TSource>(this System.Collections.Generic.IEnumerable<TSource> source, System.Func<TSource, System.Nullable<System.Double>> selector) { return default(System.Nullable<System.Double>); }
    public static System.Nullable<System.Int32> Sum<TSource>(this System.Collections.Generic.IEnumerable<TSource> source, System.Func<TSource, System.Nullable<System.Int32>> selector) { return default(System.Nullable<System.Int32>); }
    public static System.Nullable<System.Int64> Sum<TSource>(this System.Collections.Generic.IEnumerable<TSource> source, System.Func<TSource, System.Nullable<System.Int64>> selector) { return default(System.Nullable<System.Int64>); }
    public static System.Nullable<System.Single> Sum<TSource>(this System.Collections.Generic.IEnumerable<TSource> source, System.Func<TSource, System.Nullable<System.Single>> selector) { return default(System.Nullable<System.Single>); }
    public static float Sum<TSource>(this System.Collections.Generic.IEnumerable<TSource> source, System.Func<TSource, System.Single> selector) { return default(float); }
    public static System.Collections.Generic.IEnumerable<TSource> Take<TSource>(this System.Collections.Generic.IEnumerable<TSource> source, int count) { return default(System.Collections.Generic.IEnumerable<TSource>); }
    public static System.Collections.Generic.IEnumerable<TSource> TakeWhile<TSource>(this System.Collections.Generic.IEnumerable<TSource> source, System.Func<TSource, System.Boolean> predicate) { return default(System.Collections.Generic.IEnumerable<TSource>); }
    public static System.Collections.Generic.IEnumerable<TSource> TakeWhile<TSource>(this System.Collections.Generic.IEnumerable<TSource> source, System.Func<TSource, System.Int32, System.Boolean> predicate) { return default(System.Collections.Generic.IEnumerable<TSource>); }
    public static System.Linq.IOrderedEnumerable<TSource> ThenBy<TSource, TKey>(this System.Linq.IOrderedEnumerable<TSource> source, System.Func<TSource, TKey> keySelector) { return default(System.Linq.IOrderedEnumerable<TSource>); }
    public static System.Linq.IOrderedEnumerable<TSource> ThenBy<TSource, TKey>(this System.Linq.IOrderedEnumerable<TSource> source, System.Func<TSource, TKey> keySelector, System.Collections.Generic.IComparer<TKey> comparer) { return default(System.Linq.IOrderedEnumerable<TSource>); }
    public static System.Linq.IOrderedEnumerable<TSource> ThenByDescending<TSource, TKey>(this System.Linq.IOrderedEnumerable<TSource> source, System.Func<TSource, TKey> keySelector) { return default(System.Linq.IOrderedEnumerable<TSource>); }
    public static System.Linq.IOrderedEnumerable<TSource> ThenByDescending<TSource, TKey>(this System.Linq.IOrderedEnumerable<TSource> source, System.Func<TSource, TKey> keySelector, System.Collections.Generic.IComparer<TKey> comparer) { return default(System.Linq.IOrderedEnumerable<TSource>); }
    public static TSource[] ToArray<TSource>(this System.Collections.Generic.IEnumerable<TSource> source) { return default(TSource[]); }
    public static System.Collections.Generic.Dictionary<TKey, TSource> ToDictionary<TSource, TKey>(this System.Collections.Generic.IEnumerable<TSource> source, System.Func<TSource, TKey> keySelector) { return default(System.Collections.Generic.Dictionary<TKey, TSource>); }
    public static System.Collections.Generic.Dictionary<TKey, TSource> ToDictionary<TSource, TKey>(this System.Collections.Generic.IEnumerable<TSource> source, System.Func<TSource, TKey> keySelector, System.Collections.Generic.IEqualityComparer<TKey> comparer) { return default(System.Collections.Generic.Dictionary<TKey, TSource>); }
    public static System.Collections.Generic.Dictionary<TKey, TElement> ToDictionary<TSource, TKey, TElement>(this System.Collections.Generic.IEnumerable<TSource> source, System.Func<TSource, TKey> keySelector, System.Func<TSource, TElement> elementSelector) { return default(System.Collections.Generic.Dictionary<TKey, TElement>); }
    public static System.Collections.Generic.Dictionary<TKey, TElement> ToDictionary<TSource, TKey, TElement>(this System.Collections.Generic.IEnumerable<TSource> source, System.Func<TSource, TKey> keySelector, System.Func<TSource, TElement> elementSelector, System.Collections.Generic.IEqualityComparer<TKey> comparer) { return default(System.Collections.Generic.Dictionary<TKey, TElement>); }
    public static System.Collections.Generic.List<TSource> ToList<TSource>(this System.Collections.Generic.IEnumerable<TSource> source) { return default(System.Collections.Generic.List<TSource>); }
    public static System.Linq.ILookup<TKey, TSource> ToLookup<TSource, TKey>(this System.Collections.Generic.IEnumerable<TSource> source, System.Func<TSource, TKey> keySelector) { return default(System.Linq.ILookup<TKey, TSource>); }
    public static System.Linq.ILookup<TKey, TSource> ToLookup<TSource, TKey>(this System.Collections.Generic.IEnumerable<TSource> source, System.Func<TSource, TKey> keySelector, System.Collections.Generic.IEqualityComparer<TKey> comparer) { return default(System.Linq.ILookup<TKey, TSource>); }
    public static System.Linq.ILookup<TKey, TElement> ToLookup<TSource, TKey, TElement>(this System.Collections.Generic.IEnumerable<TSource> source, System.Func<TSource, TKey> keySelector, System.Func<TSource, TElement> elementSelector) { return default(System.Linq.ILookup<TKey, TElement>); }
    public static System.Linq.ILookup<TKey, TElement> ToLookup<TSource, TKey, TElement>(this System.Collections.Generic.IEnumerable<TSource> source, System.Func<TSource, TKey> keySelector, System.Func<TSource, TElement> elementSelector, System.Collections.Generic.IEqualityComparer<TKey> comparer) { return default(System.Linq.ILookup<TKey, TElement>); }
    public static System.Collections.Generic.IEnumerable<TSource> Union<TSource>(this System.Collections.Generic.IEnumerable<TSource> first, System.Collections.Generic.IEnumerable<TSource> second) { return default(System.Collections.Generic.IEnumerable<TSource>); }
    public static System.Collections.Generic.IEnumerable<TSource> Union<TSource>(this System.Collections.Generic.IEnumerable<TSource> first, System.Collections.Generic.IEnumerable<TSource> second, System.Collections.Generic.IEqualityComparer<TSource> comparer) { return default(System.Collections.Generic.IEnumerable<TSource>); }
    public static System.Collections.Generic.IEnumerable<TSource> Where<TSource>(this System.Collections.Generic.IEnumerable<TSource> source, System.Func<TSource, System.Boolean> predicate) { return default(System.Collections.Generic.IEnumerable<TSource>); }
    public static System.Collections.Generic.IEnumerable<TSource> Where<TSource>(this System.Collections.Generic.IEnumerable<TSource> source, System.Func<TSource, System.Int32, System.Boolean> predicate) { return default(System.Collections.Generic.IEnumerable<TSource>); }
  }
  public partial interface IGrouping<TKey, TElement> : System.Collections.Generic.IEnumerable<TElement>, System.Collections.IEnumerable {
    TKey Key { get; }
  }
  public partial interface ILookup<TKey, TElement> : System.Collections.Generic.IEnumerable<System.Linq.IGrouping<TKey, TElement>>, System.Collections.IEnumerable {
    int Count { get; }
    System.Collections.Generic.IEnumerable<TElement> this[TKey key] { get; }
    bool Contains(TKey key);
  }
  public partial interface IOrderedEnumerable<TElement> : System.Collections.Generic.IEnumerable<TElement>, System.Collections.IEnumerable {
    System.Linq.IOrderedEnumerable<TElement> CreateOrderedEnumerable<TKey>(System.Func<TElement, TKey> keySelector, System.Collections.Generic.IComparer<TKey> comparer, bool descending);
  }
  public partial interface IOrderedQueryable : System.Collections.IEnumerable, System.Linq.IQueryable {
  }
  public partial interface IOrderedQueryable<T> : System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable, System.Linq.IOrderedQueryable, System.Linq.IQueryable, System.Linq.IQueryable<T> {
  }
  public partial interface IQueryable : System.Collections.IEnumerable {
    System.Type ElementType { get; }
    System.Linq.Expressions.Expression Expression { get; }
    System.Linq.IQueryProvider Provider { get; }
  }
  public partial interface IQueryable<T> : System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable, System.Linq.IQueryable {
  }
  public partial interface IQueryProvider {
    System.Linq.IQueryable CreateQuery(System.Linq.Expressions.Expression expression);
    System.Linq.IQueryable<TElement> CreateQuery<TElement>(System.Linq.Expressions.Expression expression);
    object Execute(System.Linq.Expressions.Expression expression);
    TResult Execute<TResult>(System.Linq.Expressions.Expression expression);
  }
  public partial class Lookup<TKey, TElement> : System.Collections.Generic.IEnumerable<System.Linq.IGrouping<TKey, TElement>>, System.Collections.IEnumerable, System.Linq.ILookup<TKey, TElement> {
    internal Lookup() { }
    public int Count { get { return default(int); } }
    public System.Collections.Generic.IEnumerable<TElement> this[TKey key] { get { return default(System.Collections.Generic.IEnumerable<TElement>); } }
    [System.Diagnostics.DebuggerHiddenAttribute]
    public System.Collections.Generic.IEnumerable<TResult> ApplyResultSelector<TResult>(System.Func<TKey, System.Collections.Generic.IEnumerable<TElement>, TResult> resultSelector) { return default(System.Collections.Generic.IEnumerable<TResult>); }
    public bool Contains(TKey key) { return default(bool); }
    [System.Diagnostics.DebuggerHiddenAttribute]
    public System.Collections.Generic.IEnumerator<System.Linq.IGrouping<TKey, TElement>> GetEnumerator() { return default(System.Collections.Generic.IEnumerator<System.Linq.IGrouping<TKey, TElement>>); }
    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { return default(System.Collections.IEnumerator); }
  }
  public static partial class Queryable {
    public static TSource Aggregate<TSource>(this System.Linq.IQueryable<TSource> source, System.Linq.Expressions.Expression<System.Func<TSource, TSource, TSource>> func) { return default(TSource); }
    public static TAccumulate Aggregate<TSource, TAccumulate>(this System.Linq.IQueryable<TSource> source, TAccumulate seed, System.Linq.Expressions.Expression<System.Func<TAccumulate, TSource, TAccumulate>> func) { return default(TAccumulate); }
    public static TResult Aggregate<TSource, TAccumulate, TResult>(this System.Linq.IQueryable<TSource> source, TAccumulate seed, System.Linq.Expressions.Expression<System.Func<TAccumulate, TSource, TAccumulate>> func, System.Linq.Expressions.Expression<System.Func<TAccumulate, TResult>> selector) { return default(TResult); }
    public static bool All<TSource>(this System.Linq.IQueryable<TSource> source, System.Linq.Expressions.Expression<System.Func<TSource, System.Boolean>> predicate) { return default(bool); }
    public static bool Any<TSource>(this System.Linq.IQueryable<TSource> source) { return default(bool); }
    public static bool Any<TSource>(this System.Linq.IQueryable<TSource> source, System.Linq.Expressions.Expression<System.Func<TSource, System.Boolean>> predicate) { return default(bool); }
    public static System.Linq.IQueryable AsQueryable(this System.Collections.IEnumerable source) { return default(System.Linq.IQueryable); }
    public static System.Linq.IQueryable<TElement> AsQueryable<TElement>(this System.Collections.Generic.IEnumerable<TElement> source) { return default(System.Linq.IQueryable<TElement>); }
    public static decimal Average(this System.Linq.IQueryable<System.Decimal> source) { return default(decimal); }
    public static double Average(this System.Linq.IQueryable<System.Double> source) { return default(double); }
    public static double Average(this System.Linq.IQueryable<System.Int32> source) { return default(double); }
    public static double Average(this System.Linq.IQueryable<System.Int64> source) { return default(double); }
    public static System.Nullable<System.Decimal> Average(this System.Linq.IQueryable<System.Nullable<System.Decimal>> source) { return default(System.Nullable<System.Decimal>); }
    public static System.Nullable<System.Double> Average(this System.Linq.IQueryable<System.Nullable<System.Double>> source) { return default(System.Nullable<System.Double>); }
    public static System.Nullable<System.Double> Average(this System.Linq.IQueryable<System.Nullable<System.Int32>> source) { return default(System.Nullable<System.Double>); }
    public static System.Nullable<System.Double> Average(this System.Linq.IQueryable<System.Nullable<System.Int64>> source) { return default(System.Nullable<System.Double>); }
    public static System.Nullable<System.Single> Average(this System.Linq.IQueryable<System.Nullable<System.Single>> source) { return default(System.Nullable<System.Single>); }
    public static float Average(this System.Linq.IQueryable<System.Single> source) { return default(float); }
    public static decimal Average<TSource>(this System.Linq.IQueryable<TSource> source, System.Linq.Expressions.Expression<System.Func<TSource, System.Decimal>> selector) { return default(decimal); }
    public static double Average<TSource>(this System.Linq.IQueryable<TSource> source, System.Linq.Expressions.Expression<System.Func<TSource, System.Double>> selector) { return default(double); }
    public static double Average<TSource>(this System.Linq.IQueryable<TSource> source, System.Linq.Expressions.Expression<System.Func<TSource, System.Int32>> selector) { return default(double); }
    public static double Average<TSource>(this System.Linq.IQueryable<TSource> source, System.Linq.Expressions.Expression<System.Func<TSource, System.Int64>> selector) { return default(double); }
    public static System.Nullable<System.Decimal> Average<TSource>(this System.Linq.IQueryable<TSource> source, System.Linq.Expressions.Expression<System.Func<TSource, System.Nullable<System.Decimal>>> selector) { return default(System.Nullable<System.Decimal>); }
    public static System.Nullable<System.Double> Average<TSource>(this System.Linq.IQueryable<TSource> source, System.Linq.Expressions.Expression<System.Func<TSource, System.Nullable<System.Double>>> selector) { return default(System.Nullable<System.Double>); }
    public static System.Nullable<System.Double> Average<TSource>(this System.Linq.IQueryable<TSource> source, System.Linq.Expressions.Expression<System.Func<TSource, System.Nullable<System.Int32>>> selector) { return default(System.Nullable<System.Double>); }
    public static System.Nullable<System.Double> Average<TSource>(this System.Linq.IQueryable<TSource> source, System.Linq.Expressions.Expression<System.Func<TSource, System.Nullable<System.Int64>>> selector) { return default(System.Nullable<System.Double>); }
    public static System.Nullable<System.Single> Average<TSource>(this System.Linq.IQueryable<TSource> source, System.Linq.Expressions.Expression<System.Func<TSource, System.Nullable<System.Single>>> selector) { return default(System.Nullable<System.Single>); }
    public static float Average<TSource>(this System.Linq.IQueryable<TSource> source, System.Linq.Expressions.Expression<System.Func<TSource, System.Single>> selector) { return default(float); }
    public static System.Linq.IQueryable<TResult> Cast<TResult>(this System.Linq.IQueryable source) { return default(System.Linq.IQueryable<TResult>); }
    public static System.Linq.IQueryable<TSource> Concat<TSource>(this System.Linq.IQueryable<TSource> source1, System.Collections.Generic.IEnumerable<TSource> source2) { return default(System.Linq.IQueryable<TSource>); }
    public static bool Contains<TSource>(this System.Linq.IQueryable<TSource> source, TSource item) { return default(bool); }
    public static bool Contains<TSource>(this System.Linq.IQueryable<TSource> source, TSource item, System.Collections.Generic.IEqualityComparer<TSource> comparer) { return default(bool); }
    public static int Count<TSource>(this System.Linq.IQueryable<TSource> source) { return default(int); }
    public static int Count<TSource>(this System.Linq.IQueryable<TSource> source, System.Linq.Expressions.Expression<System.Func<TSource, System.Boolean>> predicate) { return default(int); }
    public static System.Linq.IQueryable<TSource> DefaultIfEmpty<TSource>(this System.Linq.IQueryable<TSource> source) { return default(System.Linq.IQueryable<TSource>); }
    public static System.Linq.IQueryable<TSource> DefaultIfEmpty<TSource>(this System.Linq.IQueryable<TSource> source, TSource defaultValue) { return default(System.Linq.IQueryable<TSource>); }
    public static System.Linq.IQueryable<TSource> Distinct<TSource>(this System.Linq.IQueryable<TSource> source) { return default(System.Linq.IQueryable<TSource>); }
    public static System.Linq.IQueryable<TSource> Distinct<TSource>(this System.Linq.IQueryable<TSource> source, System.Collections.Generic.IEqualityComparer<TSource> comparer) { return default(System.Linq.IQueryable<TSource>); }
    public static TSource ElementAt<TSource>(this System.Linq.IQueryable<TSource> source, int index) { return default(TSource); }
    public static TSource ElementAtOrDefault<TSource>(this System.Linq.IQueryable<TSource> source, int index) { return default(TSource); }
    public static System.Linq.IQueryable<TSource> Except<TSource>(this System.Linq.IQueryable<TSource> source1, System.Collections.Generic.IEnumerable<TSource> source2) { return default(System.Linq.IQueryable<TSource>); }
    public static System.Linq.IQueryable<TSource> Except<TSource>(this System.Linq.IQueryable<TSource> source1, System.Collections.Generic.IEnumerable<TSource> source2, System.Collections.Generic.IEqualityComparer<TSource> comparer) { return default(System.Linq.IQueryable<TSource>); }
    public static TSource First<TSource>(this System.Linq.IQueryable<TSource> source) { return default(TSource); }
    public static TSource First<TSource>(this System.Linq.IQueryable<TSource> source, System.Linq.Expressions.Expression<System.Func<TSource, System.Boolean>> predicate) { return default(TSource); }
    public static TSource FirstOrDefault<TSource>(this System.Linq.IQueryable<TSource> source) { return default(TSource); }
    public static TSource FirstOrDefault<TSource>(this System.Linq.IQueryable<TSource> source, System.Linq.Expressions.Expression<System.Func<TSource, System.Boolean>> predicate) { return default(TSource); }
    public static System.Linq.IQueryable<System.Linq.IGrouping<TKey, TSource>> GroupBy<TSource, TKey>(this System.Linq.IQueryable<TSource> source, System.Linq.Expressions.Expression<System.Func<TSource, TKey>> keySelector) { return default(System.Linq.IQueryable<System.Linq.IGrouping<TKey, TSource>>); }
    public static System.Linq.IQueryable<System.Linq.IGrouping<TKey, TSource>> GroupBy<TSource, TKey>(this System.Linq.IQueryable<TSource> source, System.Linq.Expressions.Expression<System.Func<TSource, TKey>> keySelector, System.Collections.Generic.IEqualityComparer<TKey> comparer) { return default(System.Linq.IQueryable<System.Linq.IGrouping<TKey, TSource>>); }
    public static System.Linq.IQueryable<System.Linq.IGrouping<TKey, TElement>> GroupBy<TSource, TKey, TElement>(this System.Linq.IQueryable<TSource> source, System.Linq.Expressions.Expression<System.Func<TSource, TKey>> keySelector, System.Linq.Expressions.Expression<System.Func<TSource, TElement>> elementSelector) { return default(System.Linq.IQueryable<System.Linq.IGrouping<TKey, TElement>>); }
    public static System.Linq.IQueryable<System.Linq.IGrouping<TKey, TElement>> GroupBy<TSource, TKey, TElement>(this System.Linq.IQueryable<TSource> source, System.Linq.Expressions.Expression<System.Func<TSource, TKey>> keySelector, System.Linq.Expressions.Expression<System.Func<TSource, TElement>> elementSelector, System.Collections.Generic.IEqualityComparer<TKey> comparer) { return default(System.Linq.IQueryable<System.Linq.IGrouping<TKey, TElement>>); }
    public static System.Linq.IQueryable<TResult> GroupBy<TSource, TKey, TResult>(this System.Linq.IQueryable<TSource> source, System.Linq.Expressions.Expression<System.Func<TSource, TKey>> keySelector, System.Linq.Expressions.Expression<System.Func<TKey, System.Collections.Generic.IEnumerable<TSource>, TResult>> resultSelector) { return default(System.Linq.IQueryable<TResult>); }
    public static System.Linq.IQueryable<TResult> GroupBy<TSource, TKey, TResult>(this System.Linq.IQueryable<TSource> source, System.Linq.Expressions.Expression<System.Func<TSource, TKey>> keySelector, System.Linq.Expressions.Expression<System.Func<TKey, System.Collections.Generic.IEnumerable<TSource>, TResult>> resultSelector, System.Collections.Generic.IEqualityComparer<TKey> comparer) { return default(System.Linq.IQueryable<TResult>); }
    public static System.Linq.IQueryable<TResult> GroupBy<TSource, TKey, TElement, TResult>(this System.Linq.IQueryable<TSource> source, System.Linq.Expressions.Expression<System.Func<TSource, TKey>> keySelector, System.Linq.Expressions.Expression<System.Func<TSource, TElement>> elementSelector, System.Linq.Expressions.Expression<System.Func<TKey, System.Collections.Generic.IEnumerable<TElement>, TResult>> resultSelector) { return default(System.Linq.IQueryable<TResult>); }
    public static System.Linq.IQueryable<TResult> GroupBy<TSource, TKey, TElement, TResult>(this System.Linq.IQueryable<TSource> source, System.Linq.Expressions.Expression<System.Func<TSource, TKey>> keySelector, System.Linq.Expressions.Expression<System.Func<TSource, TElement>> elementSelector, System.Linq.Expressions.Expression<System.Func<TKey, System.Collections.Generic.IEnumerable<TElement>, TResult>> resultSelector, System.Collections.Generic.IEqualityComparer<TKey> comparer) { return default(System.Linq.IQueryable<TResult>); }
    public static System.Linq.IQueryable<TResult> GroupJoin<TOuter, TInner, TKey, TResult>(this System.Linq.IQueryable<TOuter> outer, System.Collections.Generic.IEnumerable<TInner> inner, System.Linq.Expressions.Expression<System.Func<TOuter, TKey>> outerKeySelector, System.Linq.Expressions.Expression<System.Func<TInner, TKey>> innerKeySelector, System.Linq.Expressions.Expression<System.Func<TOuter, System.Collections.Generic.IEnumerable<TInner>, TResult>> resultSelector) { return default(System.Linq.IQueryable<TResult>); }
    public static System.Linq.IQueryable<TResult> GroupJoin<TOuter, TInner, TKey, TResult>(this System.Linq.IQueryable<TOuter> outer, System.Collections.Generic.IEnumerable<TInner> inner, System.Linq.Expressions.Expression<System.Func<TOuter, TKey>> outerKeySelector, System.Linq.Expressions.Expression<System.Func<TInner, TKey>> innerKeySelector, System.Linq.Expressions.Expression<System.Func<TOuter, System.Collections.Generic.IEnumerable<TInner>, TResult>> resultSelector, System.Collections.Generic.IEqualityComparer<TKey> comparer) { return default(System.Linq.IQueryable<TResult>); }
    public static System.Linq.IQueryable<TSource> Intersect<TSource>(this System.Linq.IQueryable<TSource> source1, System.Collections.Generic.IEnumerable<TSource> source2) { return default(System.Linq.IQueryable<TSource>); }
    public static System.Linq.IQueryable<TSource> Intersect<TSource>(this System.Linq.IQueryable<TSource> source1, System.Collections.Generic.IEnumerable<TSource> source2, System.Collections.Generic.IEqualityComparer<TSource> comparer) { return default(System.Linq.IQueryable<TSource>); }
    public static System.Linq.IQueryable<TResult> Join<TOuter, TInner, TKey, TResult>(this System.Linq.IQueryable<TOuter> outer, System.Collections.Generic.IEnumerable<TInner> inner, System.Linq.Expressions.Expression<System.Func<TOuter, TKey>> outerKeySelector, System.Linq.Expressions.Expression<System.Func<TInner, TKey>> innerKeySelector, System.Linq.Expressions.Expression<System.Func<TOuter, TInner, TResult>> resultSelector) { return default(System.Linq.IQueryable<TResult>); }
    public static System.Linq.IQueryable<TResult> Join<TOuter, TInner, TKey, TResult>(this System.Linq.IQueryable<TOuter> outer, System.Collections.Generic.IEnumerable<TInner> inner, System.Linq.Expressions.Expression<System.Func<TOuter, TKey>> outerKeySelector, System.Linq.Expressions.Expression<System.Func<TInner, TKey>> innerKeySelector, System.Linq.Expressions.Expression<System.Func<TOuter, TInner, TResult>> resultSelector, System.Collections.Generic.IEqualityComparer<TKey> comparer) { return default(System.Linq.IQueryable<TResult>); }
    public static TSource Last<TSource>(this System.Linq.IQueryable<TSource> source) { return default(TSource); }
    public static TSource Last<TSource>(this System.Linq.IQueryable<TSource> source, System.Linq.Expressions.Expression<System.Func<TSource, System.Boolean>> predicate) { return default(TSource); }
    public static TSource LastOrDefault<TSource>(this System.Linq.IQueryable<TSource> source) { return default(TSource); }
    public static TSource LastOrDefault<TSource>(this System.Linq.IQueryable<TSource> source, System.Linq.Expressions.Expression<System.Func<TSource, System.Boolean>> predicate) { return default(TSource); }
    public static long LongCount<TSource>(this System.Linq.IQueryable<TSource> source) { return default(long); }
    public static long LongCount<TSource>(this System.Linq.IQueryable<TSource> source, System.Linq.Expressions.Expression<System.Func<TSource, System.Boolean>> predicate) { return default(long); }
    public static TSource Max<TSource>(this System.Linq.IQueryable<TSource> source) { return default(TSource); }
    public static TResult Max<TSource, TResult>(this System.Linq.IQueryable<TSource> source, System.Linq.Expressions.Expression<System.Func<TSource, TResult>> selector) { return default(TResult); }
    public static TSource Min<TSource>(this System.Linq.IQueryable<TSource> source) { return default(TSource); }
    public static TResult Min<TSource, TResult>(this System.Linq.IQueryable<TSource> source, System.Linq.Expressions.Expression<System.Func<TSource, TResult>> selector) { return default(TResult); }
    public static System.Linq.IQueryable<TResult> OfType<TResult>(this System.Linq.IQueryable source) { return default(System.Linq.IQueryable<TResult>); }
    public static System.Linq.IOrderedQueryable<TSource> OrderBy<TSource, TKey>(this System.Linq.IQueryable<TSource> source, System.Linq.Expressions.Expression<System.Func<TSource, TKey>> keySelector) { return default(System.Linq.IOrderedQueryable<TSource>); }
    public static System.Linq.IOrderedQueryable<TSource> OrderBy<TSource, TKey>(this System.Linq.IQueryable<TSource> source, System.Linq.Expressions.Expression<System.Func<TSource, TKey>> keySelector, System.Collections.Generic.IComparer<TKey> comparer) { return default(System.Linq.IOrderedQueryable<TSource>); }
    public static System.Linq.IOrderedQueryable<TSource> OrderByDescending<TSource, TKey>(this System.Linq.IQueryable<TSource> source, System.Linq.Expressions.Expression<System.Func<TSource, TKey>> keySelector) { return default(System.Linq.IOrderedQueryable<TSource>); }
    public static System.Linq.IOrderedQueryable<TSource> OrderByDescending<TSource, TKey>(this System.Linq.IQueryable<TSource> source, System.Linq.Expressions.Expression<System.Func<TSource, TKey>> keySelector, System.Collections.Generic.IComparer<TKey> comparer) { return default(System.Linq.IOrderedQueryable<TSource>); }
    public static System.Linq.IQueryable<TSource> Reverse<TSource>(this System.Linq.IQueryable<TSource> source) { return default(System.Linq.IQueryable<TSource>); }
    public static System.Linq.IQueryable<TResult> Select<TSource, TResult>(this System.Linq.IQueryable<TSource> source, System.Linq.Expressions.Expression<System.Func<TSource, TResult>> selector) { return default(System.Linq.IQueryable<TResult>); }
    public static System.Linq.IQueryable<TResult> Select<TSource, TResult>(this System.Linq.IQueryable<TSource> source, System.Linq.Expressions.Expression<System.Func<TSource, System.Int32, TResult>> selector) { return default(System.Linq.IQueryable<TResult>); }
    public static System.Linq.IQueryable<TResult> SelectMany<TSource, TResult>(this System.Linq.IQueryable<TSource> source, System.Linq.Expressions.Expression<System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>> selector) { return default(System.Linq.IQueryable<TResult>); }
    public static System.Linq.IQueryable<TResult> SelectMany<TSource, TResult>(this System.Linq.IQueryable<TSource> source, System.Linq.Expressions.Expression<System.Func<TSource, System.Int32, System.Collections.Generic.IEnumerable<TResult>>> selector) { return default(System.Linq.IQueryable<TResult>); }
    public static System.Linq.IQueryable<TResult> SelectMany<TSource, TCollection, TResult>(this System.Linq.IQueryable<TSource> source, System.Linq.Expressions.Expression<System.Func<TSource, System.Collections.Generic.IEnumerable<TCollection>>> collectionSelector, System.Linq.Expressions.Expression<System.Func<TSource, TCollection, TResult>> resultSelector) { return default(System.Linq.IQueryable<TResult>); }
    public static System.Linq.IQueryable<TResult> SelectMany<TSource, TCollection, TResult>(this System.Linq.IQueryable<TSource> source, System.Linq.Expressions.Expression<System.Func<TSource, System.Int32, System.Collections.Generic.IEnumerable<TCollection>>> collectionSelector, System.Linq.Expressions.Expression<System.Func<TSource, TCollection, TResult>> resultSelector) { return default(System.Linq.IQueryable<TResult>); }
    public static bool SequenceEqual<TSource>(this System.Linq.IQueryable<TSource> source1, System.Collections.Generic.IEnumerable<TSource> source2) { return default(bool); }
    public static bool SequenceEqual<TSource>(this System.Linq.IQueryable<TSource> source1, System.Collections.Generic.IEnumerable<TSource> source2, System.Collections.Generic.IEqualityComparer<TSource> comparer) { return default(bool); }
    public static TSource Single<TSource>(this System.Linq.IQueryable<TSource> source) { return default(TSource); }
    public static TSource Single<TSource>(this System.Linq.IQueryable<TSource> source, System.Linq.Expressions.Expression<System.Func<TSource, System.Boolean>> predicate) { return default(TSource); }
    public static TSource SingleOrDefault<TSource>(this System.Linq.IQueryable<TSource> source) { return default(TSource); }
    public static TSource SingleOrDefault<TSource>(this System.Linq.IQueryable<TSource> source, System.Linq.Expressions.Expression<System.Func<TSource, System.Boolean>> predicate) { return default(TSource); }
    public static System.Linq.IQueryable<TSource> Skip<TSource>(this System.Linq.IQueryable<TSource> source, int count) { return default(System.Linq.IQueryable<TSource>); }
    public static System.Linq.IQueryable<TSource> SkipWhile<TSource>(this System.Linq.IQueryable<TSource> source, System.Linq.Expressions.Expression<System.Func<TSource, System.Boolean>> predicate) { return default(System.Linq.IQueryable<TSource>); }
    public static System.Linq.IQueryable<TSource> SkipWhile<TSource>(this System.Linq.IQueryable<TSource> source, System.Linq.Expressions.Expression<System.Func<TSource, System.Int32, System.Boolean>> predicate) { return default(System.Linq.IQueryable<TSource>); }
    public static decimal Sum(this System.Linq.IQueryable<System.Decimal> source) { return default(decimal); }
    public static double Sum(this System.Linq.IQueryable<System.Double> source) { return default(double); }
    public static int Sum(this System.Linq.IQueryable<System.Int32> source) { return default(int); }
    public static long Sum(this System.Linq.IQueryable<System.Int64> source) { return default(long); }
    public static System.Nullable<System.Decimal> Sum(this System.Linq.IQueryable<System.Nullable<System.Decimal>> source) { return default(System.Nullable<System.Decimal>); }
    public static System.Nullable<System.Double> Sum(this System.Linq.IQueryable<System.Nullable<System.Double>> source) { return default(System.Nullable<System.Double>); }
    public static System.Nullable<System.Int32> Sum(this System.Linq.IQueryable<System.Nullable<System.Int32>> source) { return default(System.Nullable<System.Int32>); }
    public static System.Nullable<System.Int64> Sum(this System.Linq.IQueryable<System.Nullable<System.Int64>> source) { return default(System.Nullable<System.Int64>); }
    public static System.Nullable<System.Single> Sum(this System.Linq.IQueryable<System.Nullable<System.Single>> source) { return default(System.Nullable<System.Single>); }
    public static float Sum(this System.Linq.IQueryable<System.Single> source) { return default(float); }
    public static decimal Sum<TSource>(this System.Linq.IQueryable<TSource> source, System.Linq.Expressions.Expression<System.Func<TSource, System.Decimal>> selector) { return default(decimal); }
    public static double Sum<TSource>(this System.Linq.IQueryable<TSource> source, System.Linq.Expressions.Expression<System.Func<TSource, System.Double>> selector) { return default(double); }
    public static int Sum<TSource>(this System.Linq.IQueryable<TSource> source, System.Linq.Expressions.Expression<System.Func<TSource, System.Int32>> selector) { return default(int); }
    public static long Sum<TSource>(this System.Linq.IQueryable<TSource> source, System.Linq.Expressions.Expression<System.Func<TSource, System.Int64>> selector) { return default(long); }
    public static System.Nullable<System.Decimal> Sum<TSource>(this System.Linq.IQueryable<TSource> source, System.Linq.Expressions.Expression<System.Func<TSource, System.Nullable<System.Decimal>>> selector) { return default(System.Nullable<System.Decimal>); }
    public static System.Nullable<System.Double> Sum<TSource>(this System.Linq.IQueryable<TSource> source, System.Linq.Expressions.Expression<System.Func<TSource, System.Nullable<System.Double>>> selector) { return default(System.Nullable<System.Double>); }
    public static System.Nullable<System.Int32> Sum<TSource>(this System.Linq.IQueryable<TSource> source, System.Linq.Expressions.Expression<System.Func<TSource, System.Nullable<System.Int32>>> selector) { return default(System.Nullable<System.Int32>); }
    public static System.Nullable<System.Int64> Sum<TSource>(this System.Linq.IQueryable<TSource> source, System.Linq.Expressions.Expression<System.Func<TSource, System.Nullable<System.Int64>>> selector) { return default(System.Nullable<System.Int64>); }
    public static System.Nullable<System.Single> Sum<TSource>(this System.Linq.IQueryable<TSource> source, System.Linq.Expressions.Expression<System.Func<TSource, System.Nullable<System.Single>>> selector) { return default(System.Nullable<System.Single>); }
    public static float Sum<TSource>(this System.Linq.IQueryable<TSource> source, System.Linq.Expressions.Expression<System.Func<TSource, System.Single>> selector) { return default(float); }
    public static System.Linq.IQueryable<TSource> Take<TSource>(this System.Linq.IQueryable<TSource> source, int count) { return default(System.Linq.IQueryable<TSource>); }
    public static System.Linq.IQueryable<TSource> TakeWhile<TSource>(this System.Linq.IQueryable<TSource> source, System.Linq.Expressions.Expression<System.Func<TSource, System.Boolean>> predicate) { return default(System.Linq.IQueryable<TSource>); }
    public static System.Linq.IQueryable<TSource> TakeWhile<TSource>(this System.Linq.IQueryable<TSource> source, System.Linq.Expressions.Expression<System.Func<TSource, System.Int32, System.Boolean>> predicate) { return default(System.Linq.IQueryable<TSource>); }
    public static System.Linq.IOrderedQueryable<TSource> ThenBy<TSource, TKey>(this System.Linq.IOrderedQueryable<TSource> source, System.Linq.Expressions.Expression<System.Func<TSource, TKey>> keySelector) { return default(System.Linq.IOrderedQueryable<TSource>); }
    public static System.Linq.IOrderedQueryable<TSource> ThenBy<TSource, TKey>(this System.Linq.IOrderedQueryable<TSource> source, System.Linq.Expressions.Expression<System.Func<TSource, TKey>> keySelector, System.Collections.Generic.IComparer<TKey> comparer) { return default(System.Linq.IOrderedQueryable<TSource>); }
    public static System.Linq.IOrderedQueryable<TSource> ThenByDescending<TSource, TKey>(this System.Linq.IOrderedQueryable<TSource> source, System.Linq.Expressions.Expression<System.Func<TSource, TKey>> keySelector) { return default(System.Linq.IOrderedQueryable<TSource>); }
    public static System.Linq.IOrderedQueryable<TSource> ThenByDescending<TSource, TKey>(this System.Linq.IOrderedQueryable<TSource> source, System.Linq.Expressions.Expression<System.Func<TSource, TKey>> keySelector, System.Collections.Generic.IComparer<TKey> comparer) { return default(System.Linq.IOrderedQueryable<TSource>); }
    public static System.Linq.IQueryable<TSource> Union<TSource>(this System.Linq.IQueryable<TSource> source1, System.Collections.Generic.IEnumerable<TSource> source2) { return default(System.Linq.IQueryable<TSource>); }
    public static System.Linq.IQueryable<TSource> Union<TSource>(this System.Linq.IQueryable<TSource> source1, System.Collections.Generic.IEnumerable<TSource> source2, System.Collections.Generic.IEqualityComparer<TSource> comparer) { return default(System.Linq.IQueryable<TSource>); }
    public static System.Linq.IQueryable<TSource> Where<TSource>(this System.Linq.IQueryable<TSource> source, System.Linq.Expressions.Expression<System.Func<TSource, System.Boolean>> predicate) { return default(System.Linq.IQueryable<TSource>); }
    public static System.Linq.IQueryable<TSource> Where<TSource>(this System.Linq.IQueryable<TSource> source, System.Linq.Expressions.Expression<System.Func<TSource, System.Int32, System.Boolean>> predicate) { return default(System.Linq.IQueryable<TSource>); }
  }
}
namespace System.Linq.Expressions {
  public sealed partial class BinaryExpression : System.Linq.Expressions.Expression {
    internal BinaryExpression() : base (default(System.Linq.Expressions.ExpressionType), default(System.Type)) { }
    public System.Linq.Expressions.LambdaExpression Conversion { get { return default(System.Linq.Expressions.LambdaExpression); } }
    public bool IsLifted { get { return default(bool); } }
    public bool IsLiftedToNull { get { return default(bool); } }
    public System.Linq.Expressions.Expression Left { get { return default(System.Linq.Expressions.Expression); } }
    public System.Reflection.MethodInfo Method { get { return default(System.Reflection.MethodInfo); } }
    public System.Linq.Expressions.Expression Right { get { return default(System.Linq.Expressions.Expression); } }
  }
  public sealed partial class ConditionalExpression : System.Linq.Expressions.Expression {
    internal ConditionalExpression() : base (default(System.Linq.Expressions.ExpressionType), default(System.Type)) { }
    public System.Linq.Expressions.Expression IfFalse { get { return default(System.Linq.Expressions.Expression); } }
    public System.Linq.Expressions.Expression IfTrue { get { return default(System.Linq.Expressions.Expression); } }
    public System.Linq.Expressions.Expression Test { get { return default(System.Linq.Expressions.Expression); } }
  }
  public sealed partial class ConstantExpression : System.Linq.Expressions.Expression {
    internal ConstantExpression() : base (default(System.Linq.Expressions.ExpressionType), default(System.Type)) { }
    public object Value { get { return default(object); } }
  }
  public sealed partial class ElementInit {
    internal ElementInit() { }
    public System.Reflection.MethodInfo AddMethod { get { return default(System.Reflection.MethodInfo); } }
    public System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.Expression> Arguments { get { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.Expression>); } }
    public override string ToString() { return default(string); }
  }
  public abstract partial class Expression {
    protected Expression(System.Linq.Expressions.ExpressionType node_type, System.Type type) { }
    public virtual System.Linq.Expressions.ExpressionType NodeType { get { return default(System.Linq.Expressions.ExpressionType); } }
    public virtual System.Type Type { get { return default(System.Type); } }
    public static System.Linq.Expressions.BinaryExpression Add(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right) { return default(System.Linq.Expressions.BinaryExpression); }
    public static System.Linq.Expressions.BinaryExpression Add(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right, System.Reflection.MethodInfo method) { return default(System.Linq.Expressions.BinaryExpression); }
    public static System.Linq.Expressions.BinaryExpression AddChecked(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right) { return default(System.Linq.Expressions.BinaryExpression); }
    public static System.Linq.Expressions.BinaryExpression AddChecked(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right, System.Reflection.MethodInfo method) { return default(System.Linq.Expressions.BinaryExpression); }
    public static System.Linq.Expressions.BinaryExpression And(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right) { return default(System.Linq.Expressions.BinaryExpression); }
    public static System.Linq.Expressions.BinaryExpression And(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right, System.Reflection.MethodInfo method) { return default(System.Linq.Expressions.BinaryExpression); }
    public static System.Linq.Expressions.BinaryExpression AndAlso(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right) { return default(System.Linq.Expressions.BinaryExpression); }
    public static System.Linq.Expressions.BinaryExpression AndAlso(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right, System.Reflection.MethodInfo method) { return default(System.Linq.Expressions.BinaryExpression); }
    public static System.Linq.Expressions.MethodCallExpression ArrayIndex(System.Linq.Expressions.Expression array, System.Collections.Generic.IEnumerable<System.Linq.Expressions.Expression> indexes) { return default(System.Linq.Expressions.MethodCallExpression); }
    public static System.Linq.Expressions.BinaryExpression ArrayIndex(System.Linq.Expressions.Expression array, System.Linq.Expressions.Expression index) { return default(System.Linq.Expressions.BinaryExpression); }
    public static System.Linq.Expressions.MethodCallExpression ArrayIndex(System.Linq.Expressions.Expression array, params System.Linq.Expressions.Expression[] indexes) { return default(System.Linq.Expressions.MethodCallExpression); }
    public static System.Linq.Expressions.UnaryExpression ArrayLength(System.Linq.Expressions.Expression array) { return default(System.Linq.Expressions.UnaryExpression); }
    public static System.Linq.Expressions.MemberAssignment Bind(System.Reflection.MemberInfo member, System.Linq.Expressions.Expression expression) { return default(System.Linq.Expressions.MemberAssignment); }
    public static System.Linq.Expressions.MemberAssignment Bind(System.Reflection.MethodInfo propertyAccessor, System.Linq.Expressions.Expression expression) { return default(System.Linq.Expressions.MemberAssignment); }
    public static System.Linq.Expressions.MethodCallExpression Call(System.Linq.Expressions.Expression instance, System.Reflection.MethodInfo method) { return default(System.Linq.Expressions.MethodCallExpression); }
    public static System.Linq.Expressions.MethodCallExpression Call(System.Linq.Expressions.Expression instance, System.Reflection.MethodInfo method, System.Collections.Generic.IEnumerable<System.Linq.Expressions.Expression> arguments) { return default(System.Linq.Expressions.MethodCallExpression); }
    public static System.Linq.Expressions.MethodCallExpression Call(System.Linq.Expressions.Expression instance, System.Reflection.MethodInfo method, params System.Linq.Expressions.Expression[] arguments) { return default(System.Linq.Expressions.MethodCallExpression); }
    public static System.Linq.Expressions.MethodCallExpression Call(System.Linq.Expressions.Expression instance, string methodName, System.Type[] typeArguments, params System.Linq.Expressions.Expression[] arguments) { return default(System.Linq.Expressions.MethodCallExpression); }
    public static System.Linq.Expressions.MethodCallExpression Call(System.Reflection.MethodInfo method, params System.Linq.Expressions.Expression[] arguments) { return default(System.Linq.Expressions.MethodCallExpression); }
    public static System.Linq.Expressions.MethodCallExpression Call(System.Type type, string methodName, System.Type[] typeArguments, params System.Linq.Expressions.Expression[] arguments) { return default(System.Linq.Expressions.MethodCallExpression); }
    public static System.Linq.Expressions.BinaryExpression Coalesce(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right) { return default(System.Linq.Expressions.BinaryExpression); }
    public static System.Linq.Expressions.BinaryExpression Coalesce(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right, System.Linq.Expressions.LambdaExpression conversion) { return default(System.Linq.Expressions.BinaryExpression); }
    public static System.Linq.Expressions.ConditionalExpression Condition(System.Linq.Expressions.Expression test, System.Linq.Expressions.Expression ifTrue, System.Linq.Expressions.Expression ifFalse) { return default(System.Linq.Expressions.ConditionalExpression); }
    public static System.Linq.Expressions.ConstantExpression Constant(object value) { return default(System.Linq.Expressions.ConstantExpression); }
    public static System.Linq.Expressions.ConstantExpression Constant(object value, System.Type type) { return default(System.Linq.Expressions.ConstantExpression); }
    public static System.Linq.Expressions.UnaryExpression Convert(System.Linq.Expressions.Expression expression, System.Type type) { return default(System.Linq.Expressions.UnaryExpression); }
    public static System.Linq.Expressions.UnaryExpression Convert(System.Linq.Expressions.Expression expression, System.Type type, System.Reflection.MethodInfo method) { return default(System.Linq.Expressions.UnaryExpression); }
    public static System.Linq.Expressions.UnaryExpression ConvertChecked(System.Linq.Expressions.Expression expression, System.Type type) { return default(System.Linq.Expressions.UnaryExpression); }
    public static System.Linq.Expressions.UnaryExpression ConvertChecked(System.Linq.Expressions.Expression expression, System.Type type, System.Reflection.MethodInfo method) { return default(System.Linq.Expressions.UnaryExpression); }
    public static System.Linq.Expressions.BinaryExpression Divide(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right) { return default(System.Linq.Expressions.BinaryExpression); }
    public static System.Linq.Expressions.BinaryExpression Divide(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right, System.Reflection.MethodInfo method) { return default(System.Linq.Expressions.BinaryExpression); }
    public static System.Linq.Expressions.ElementInit ElementInit(System.Reflection.MethodInfo addMethod, System.Collections.Generic.IEnumerable<System.Linq.Expressions.Expression> arguments) { return default(System.Linq.Expressions.ElementInit); }
    public static System.Linq.Expressions.ElementInit ElementInit(System.Reflection.MethodInfo addMethod, params System.Linq.Expressions.Expression[] arguments) { return default(System.Linq.Expressions.ElementInit); }
    public static System.Linq.Expressions.BinaryExpression Equal(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right) { return default(System.Linq.Expressions.BinaryExpression); }
    public static System.Linq.Expressions.BinaryExpression Equal(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right, bool liftToNull, System.Reflection.MethodInfo method) { return default(System.Linq.Expressions.BinaryExpression); }
    public static System.Linq.Expressions.BinaryExpression ExclusiveOr(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right) { return default(System.Linq.Expressions.BinaryExpression); }
    public static System.Linq.Expressions.BinaryExpression ExclusiveOr(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right, System.Reflection.MethodInfo method) { return default(System.Linq.Expressions.BinaryExpression); }
    public static System.Linq.Expressions.MemberExpression Field(System.Linq.Expressions.Expression expression, System.Reflection.FieldInfo field) { return default(System.Linq.Expressions.MemberExpression); }
    public static System.Linq.Expressions.MemberExpression Field(System.Linq.Expressions.Expression expression, string fieldName) { return default(System.Linq.Expressions.MemberExpression); }
    public static System.Type GetActionType(params System.Type[] typeArgs) { return default(System.Type); }
    public static System.Type GetFuncType(params System.Type[] typeArgs) { return default(System.Type); }
    public static System.Linq.Expressions.BinaryExpression GreaterThan(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right) { return default(System.Linq.Expressions.BinaryExpression); }
    public static System.Linq.Expressions.BinaryExpression GreaterThan(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right, bool liftToNull, System.Reflection.MethodInfo method) { return default(System.Linq.Expressions.BinaryExpression); }
    public static System.Linq.Expressions.BinaryExpression GreaterThanOrEqual(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right) { return default(System.Linq.Expressions.BinaryExpression); }
    public static System.Linq.Expressions.BinaryExpression GreaterThanOrEqual(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right, bool liftToNull, System.Reflection.MethodInfo method) { return default(System.Linq.Expressions.BinaryExpression); }
    public static System.Linq.Expressions.InvocationExpression Invoke(System.Linq.Expressions.Expression expression, System.Collections.Generic.IEnumerable<System.Linq.Expressions.Expression> arguments) { return default(System.Linq.Expressions.InvocationExpression); }
    public static System.Linq.Expressions.InvocationExpression Invoke(System.Linq.Expressions.Expression expression, params System.Linq.Expressions.Expression[] arguments) { return default(System.Linq.Expressions.InvocationExpression); }
    public static System.Linq.Expressions.LambdaExpression Lambda(System.Linq.Expressions.Expression body, params System.Linq.Expressions.ParameterExpression[] parameters) { return default(System.Linq.Expressions.LambdaExpression); }
    public static System.Linq.Expressions.LambdaExpression Lambda(System.Type delegateType, System.Linq.Expressions.Expression body, System.Collections.Generic.IEnumerable<System.Linq.Expressions.ParameterExpression> parameters) { return default(System.Linq.Expressions.LambdaExpression); }
    public static System.Linq.Expressions.LambdaExpression Lambda(System.Type delegateType, System.Linq.Expressions.Expression body, params System.Linq.Expressions.ParameterExpression[] parameters) { return default(System.Linq.Expressions.LambdaExpression); }
    public static System.Linq.Expressions.Expression<TDelegate> Lambda<TDelegate>(System.Linq.Expressions.Expression body, System.Collections.Generic.IEnumerable<System.Linq.Expressions.ParameterExpression> parameters) { return default(System.Linq.Expressions.Expression<TDelegate>); }
    public static System.Linq.Expressions.Expression<TDelegate> Lambda<TDelegate>(System.Linq.Expressions.Expression body, params System.Linq.Expressions.ParameterExpression[] parameters) { return default(System.Linq.Expressions.Expression<TDelegate>); }
    public static System.Linq.Expressions.BinaryExpression LeftShift(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right) { return default(System.Linq.Expressions.BinaryExpression); }
    public static System.Linq.Expressions.BinaryExpression LeftShift(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right, System.Reflection.MethodInfo method) { return default(System.Linq.Expressions.BinaryExpression); }
    public static System.Linq.Expressions.BinaryExpression LessThan(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right) { return default(System.Linq.Expressions.BinaryExpression); }
    public static System.Linq.Expressions.BinaryExpression LessThan(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right, bool liftToNull, System.Reflection.MethodInfo method) { return default(System.Linq.Expressions.BinaryExpression); }
    public static System.Linq.Expressions.BinaryExpression LessThanOrEqual(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right) { return default(System.Linq.Expressions.BinaryExpression); }
    public static System.Linq.Expressions.BinaryExpression LessThanOrEqual(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right, bool liftToNull, System.Reflection.MethodInfo method) { return default(System.Linq.Expressions.BinaryExpression); }
    public static System.Linq.Expressions.MemberListBinding ListBind(System.Reflection.MemberInfo member, System.Collections.Generic.IEnumerable<System.Linq.Expressions.ElementInit> initializers) { return default(System.Linq.Expressions.MemberListBinding); }
    public static System.Linq.Expressions.MemberListBinding ListBind(System.Reflection.MemberInfo member, params System.Linq.Expressions.ElementInit[] initializers) { return default(System.Linq.Expressions.MemberListBinding); }
    public static System.Linq.Expressions.MemberListBinding ListBind(System.Reflection.MethodInfo propertyAccessor, System.Collections.Generic.IEnumerable<System.Linq.Expressions.ElementInit> initializers) { return default(System.Linq.Expressions.MemberListBinding); }
    public static System.Linq.Expressions.MemberListBinding ListBind(System.Reflection.MethodInfo propertyAccessor, params System.Linq.Expressions.ElementInit[] initializers) { return default(System.Linq.Expressions.MemberListBinding); }
    public static System.Linq.Expressions.ListInitExpression ListInit(System.Linq.Expressions.NewExpression newExpression, System.Collections.Generic.IEnumerable<System.Linq.Expressions.ElementInit> initializers) { return default(System.Linq.Expressions.ListInitExpression); }
    public static System.Linq.Expressions.ListInitExpression ListInit(System.Linq.Expressions.NewExpression newExpression, System.Collections.Generic.IEnumerable<System.Linq.Expressions.Expression> initializers) { return default(System.Linq.Expressions.ListInitExpression); }
    public static System.Linq.Expressions.ListInitExpression ListInit(System.Linq.Expressions.NewExpression newExpression, params System.Linq.Expressions.ElementInit[] initializers) { return default(System.Linq.Expressions.ListInitExpression); }
    public static System.Linq.Expressions.ListInitExpression ListInit(System.Linq.Expressions.NewExpression newExpression, params System.Linq.Expressions.Expression[] initializers) { return default(System.Linq.Expressions.ListInitExpression); }
    public static System.Linq.Expressions.ListInitExpression ListInit(System.Linq.Expressions.NewExpression newExpression, System.Reflection.MethodInfo addMethod, System.Collections.Generic.IEnumerable<System.Linq.Expressions.Expression> initializers) { return default(System.Linq.Expressions.ListInitExpression); }
    public static System.Linq.Expressions.ListInitExpression ListInit(System.Linq.Expressions.NewExpression newExpression, System.Reflection.MethodInfo addMethod, params System.Linq.Expressions.Expression[] initializers) { return default(System.Linq.Expressions.ListInitExpression); }
    public static System.Linq.Expressions.BinaryExpression MakeBinary(System.Linq.Expressions.ExpressionType binaryType, System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right) { return default(System.Linq.Expressions.BinaryExpression); }
    public static System.Linq.Expressions.BinaryExpression MakeBinary(System.Linq.Expressions.ExpressionType binaryType, System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right, bool liftToNull, System.Reflection.MethodInfo method) { return default(System.Linq.Expressions.BinaryExpression); }
    public static System.Linq.Expressions.BinaryExpression MakeBinary(System.Linq.Expressions.ExpressionType binaryType, System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right, bool liftToNull, System.Reflection.MethodInfo method, System.Linq.Expressions.LambdaExpression conversion) { return default(System.Linq.Expressions.BinaryExpression); }
    public static System.Linq.Expressions.MemberExpression MakeMemberAccess(System.Linq.Expressions.Expression expression, System.Reflection.MemberInfo member) { return default(System.Linq.Expressions.MemberExpression); }
    public static System.Linq.Expressions.UnaryExpression MakeUnary(System.Linq.Expressions.ExpressionType unaryType, System.Linq.Expressions.Expression operand, System.Type type) { return default(System.Linq.Expressions.UnaryExpression); }
    public static System.Linq.Expressions.UnaryExpression MakeUnary(System.Linq.Expressions.ExpressionType unaryType, System.Linq.Expressions.Expression operand, System.Type type, System.Reflection.MethodInfo method) { return default(System.Linq.Expressions.UnaryExpression); }
    public static System.Linq.Expressions.MemberMemberBinding MemberBind(System.Reflection.MemberInfo member, System.Collections.Generic.IEnumerable<System.Linq.Expressions.MemberBinding> bindings) { return default(System.Linq.Expressions.MemberMemberBinding); }
    public static System.Linq.Expressions.MemberMemberBinding MemberBind(System.Reflection.MemberInfo member, params System.Linq.Expressions.MemberBinding[] bindings) { return default(System.Linq.Expressions.MemberMemberBinding); }
    public static System.Linq.Expressions.MemberMemberBinding MemberBind(System.Reflection.MethodInfo propertyAccessor, System.Collections.Generic.IEnumerable<System.Linq.Expressions.MemberBinding> bindings) { return default(System.Linq.Expressions.MemberMemberBinding); }
    public static System.Linq.Expressions.MemberMemberBinding MemberBind(System.Reflection.MethodInfo propertyAccessor, params System.Linq.Expressions.MemberBinding[] bindings) { return default(System.Linq.Expressions.MemberMemberBinding); }
    public static System.Linq.Expressions.MemberInitExpression MemberInit(System.Linq.Expressions.NewExpression newExpression, System.Collections.Generic.IEnumerable<System.Linq.Expressions.MemberBinding> bindings) { return default(System.Linq.Expressions.MemberInitExpression); }
    public static System.Linq.Expressions.MemberInitExpression MemberInit(System.Linq.Expressions.NewExpression newExpression, params System.Linq.Expressions.MemberBinding[] bindings) { return default(System.Linq.Expressions.MemberInitExpression); }
    public static System.Linq.Expressions.BinaryExpression Modulo(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right) { return default(System.Linq.Expressions.BinaryExpression); }
    public static System.Linq.Expressions.BinaryExpression Modulo(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right, System.Reflection.MethodInfo method) { return default(System.Linq.Expressions.BinaryExpression); }
    public static System.Linq.Expressions.BinaryExpression Multiply(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right) { return default(System.Linq.Expressions.BinaryExpression); }
    public static System.Linq.Expressions.BinaryExpression Multiply(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right, System.Reflection.MethodInfo method) { return default(System.Linq.Expressions.BinaryExpression); }
    public static System.Linq.Expressions.BinaryExpression MultiplyChecked(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right) { return default(System.Linq.Expressions.BinaryExpression); }
    public static System.Linq.Expressions.BinaryExpression MultiplyChecked(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right, System.Reflection.MethodInfo method) { return default(System.Linq.Expressions.BinaryExpression); }
    public static System.Linq.Expressions.UnaryExpression Negate(System.Linq.Expressions.Expression expression) { return default(System.Linq.Expressions.UnaryExpression); }
    public static System.Linq.Expressions.UnaryExpression Negate(System.Linq.Expressions.Expression expression, System.Reflection.MethodInfo method) { return default(System.Linq.Expressions.UnaryExpression); }
    public static System.Linq.Expressions.UnaryExpression NegateChecked(System.Linq.Expressions.Expression expression) { return default(System.Linq.Expressions.UnaryExpression); }
    public static System.Linq.Expressions.UnaryExpression NegateChecked(System.Linq.Expressions.Expression expression, System.Reflection.MethodInfo method) { return default(System.Linq.Expressions.UnaryExpression); }
    public static System.Linq.Expressions.NewExpression New(System.Reflection.ConstructorInfo constructor) { return default(System.Linq.Expressions.NewExpression); }
    public static System.Linq.Expressions.NewExpression New(System.Reflection.ConstructorInfo constructor, System.Collections.Generic.IEnumerable<System.Linq.Expressions.Expression> arguments) { return default(System.Linq.Expressions.NewExpression); }
    public static System.Linq.Expressions.NewExpression New(System.Reflection.ConstructorInfo constructor, System.Collections.Generic.IEnumerable<System.Linq.Expressions.Expression> arguments, System.Collections.Generic.IEnumerable<System.Reflection.MemberInfo> members) { return default(System.Linq.Expressions.NewExpression); }
    public static System.Linq.Expressions.NewExpression New(System.Reflection.ConstructorInfo constructor, System.Collections.Generic.IEnumerable<System.Linq.Expressions.Expression> arguments, params System.Reflection.MemberInfo[] members) { return default(System.Linq.Expressions.NewExpression); }
    public static System.Linq.Expressions.NewExpression New(System.Reflection.ConstructorInfo constructor, params System.Linq.Expressions.Expression[] arguments) { return default(System.Linq.Expressions.NewExpression); }
    public static System.Linq.Expressions.NewExpression New(System.Type type) { return default(System.Linq.Expressions.NewExpression); }
    public static System.Linq.Expressions.NewArrayExpression NewArrayBounds(System.Type type, System.Collections.Generic.IEnumerable<System.Linq.Expressions.Expression> bounds) { return default(System.Linq.Expressions.NewArrayExpression); }
    public static System.Linq.Expressions.NewArrayExpression NewArrayBounds(System.Type type, params System.Linq.Expressions.Expression[] bounds) { return default(System.Linq.Expressions.NewArrayExpression); }
    public static System.Linq.Expressions.NewArrayExpression NewArrayInit(System.Type type, System.Collections.Generic.IEnumerable<System.Linq.Expressions.Expression> initializers) { return default(System.Linq.Expressions.NewArrayExpression); }
    public static System.Linq.Expressions.NewArrayExpression NewArrayInit(System.Type type, params System.Linq.Expressions.Expression[] initializers) { return default(System.Linq.Expressions.NewArrayExpression); }
    public static System.Linq.Expressions.UnaryExpression Not(System.Linq.Expressions.Expression expression) { return default(System.Linq.Expressions.UnaryExpression); }
    public static System.Linq.Expressions.UnaryExpression Not(System.Linq.Expressions.Expression expression, System.Reflection.MethodInfo method) { return default(System.Linq.Expressions.UnaryExpression); }
    public static System.Linq.Expressions.BinaryExpression NotEqual(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right) { return default(System.Linq.Expressions.BinaryExpression); }
    public static System.Linq.Expressions.BinaryExpression NotEqual(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right, bool liftToNull, System.Reflection.MethodInfo method) { return default(System.Linq.Expressions.BinaryExpression); }
    public static System.Linq.Expressions.BinaryExpression Or(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right) { return default(System.Linq.Expressions.BinaryExpression); }
    public static System.Linq.Expressions.BinaryExpression Or(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right, System.Reflection.MethodInfo method) { return default(System.Linq.Expressions.BinaryExpression); }
    public static System.Linq.Expressions.BinaryExpression OrElse(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right) { return default(System.Linq.Expressions.BinaryExpression); }
    public static System.Linq.Expressions.BinaryExpression OrElse(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right, System.Reflection.MethodInfo method) { return default(System.Linq.Expressions.BinaryExpression); }
    public static System.Linq.Expressions.ParameterExpression Parameter(System.Type type, string name) { return default(System.Linq.Expressions.ParameterExpression); }
    public static System.Linq.Expressions.BinaryExpression Power(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right) { return default(System.Linq.Expressions.BinaryExpression); }
    public static System.Linq.Expressions.BinaryExpression Power(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right, System.Reflection.MethodInfo method) { return default(System.Linq.Expressions.BinaryExpression); }
    public static System.Linq.Expressions.MemberExpression Property(System.Linq.Expressions.Expression expression, System.Reflection.MethodInfo propertyAccessor) { return default(System.Linq.Expressions.MemberExpression); }
    public static System.Linq.Expressions.MemberExpression Property(System.Linq.Expressions.Expression expression, System.Reflection.PropertyInfo property) { return default(System.Linq.Expressions.MemberExpression); }
    public static System.Linq.Expressions.MemberExpression Property(System.Linq.Expressions.Expression expression, string propertyName) { return default(System.Linq.Expressions.MemberExpression); }
    public static System.Linq.Expressions.MemberExpression PropertyOrField(System.Linq.Expressions.Expression expression, string propertyOrFieldName) { return default(System.Linq.Expressions.MemberExpression); }
    public static System.Linq.Expressions.UnaryExpression Quote(System.Linq.Expressions.Expression expression) { return default(System.Linq.Expressions.UnaryExpression); }
    public static System.Linq.Expressions.BinaryExpression RightShift(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right) { return default(System.Linq.Expressions.BinaryExpression); }
    public static System.Linq.Expressions.BinaryExpression RightShift(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right, System.Reflection.MethodInfo method) { return default(System.Linq.Expressions.BinaryExpression); }
    public static System.Linq.Expressions.BinaryExpression Subtract(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right) { return default(System.Linq.Expressions.BinaryExpression); }
    public static System.Linq.Expressions.BinaryExpression Subtract(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right, System.Reflection.MethodInfo method) { return default(System.Linq.Expressions.BinaryExpression); }
    public static System.Linq.Expressions.BinaryExpression SubtractChecked(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right) { return default(System.Linq.Expressions.BinaryExpression); }
    public static System.Linq.Expressions.BinaryExpression SubtractChecked(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right, System.Reflection.MethodInfo method) { return default(System.Linq.Expressions.BinaryExpression); }
    public override string ToString() { return default(string); }
    public static System.Linq.Expressions.UnaryExpression TypeAs(System.Linq.Expressions.Expression expression, System.Type type) { return default(System.Linq.Expressions.UnaryExpression); }
    public static System.Linq.Expressions.TypeBinaryExpression TypeIs(System.Linq.Expressions.Expression expression, System.Type type) { return default(System.Linq.Expressions.TypeBinaryExpression); }
    public static System.Linq.Expressions.UnaryExpression UnaryPlus(System.Linq.Expressions.Expression expression) { return default(System.Linq.Expressions.UnaryExpression); }
    public static System.Linq.Expressions.UnaryExpression UnaryPlus(System.Linq.Expressions.Expression expression, System.Reflection.MethodInfo method) { return default(System.Linq.Expressions.UnaryExpression); }
  }
  public sealed partial class Expression<TDelegate> : System.Linq.Expressions.LambdaExpression {
    internal Expression() { }
    public new TDelegate Compile() { return default(TDelegate); }
  }
  public enum ExpressionType {
    Add = 0,
    AddChecked = 1,
    And = 2,
    AndAlso = 3,
    ArrayIndex = 5,
    ArrayLength = 4,
    Call = 6,
    Coalesce = 7,
    Conditional = 8,
    Constant = 9,
    Convert = 10,
    ConvertChecked = 11,
    Divide = 12,
    Equal = 13,
    ExclusiveOr = 14,
    GreaterThan = 15,
    GreaterThanOrEqual = 16,
    Invoke = 17,
    Lambda = 18,
    LeftShift = 19,
    LessThan = 20,
    LessThanOrEqual = 21,
    ListInit = 22,
    MemberAccess = 23,
    MemberInit = 24,
    Modulo = 25,
    Multiply = 26,
    MultiplyChecked = 27,
    Negate = 28,
    NegateChecked = 30,
    New = 31,
    NewArrayBounds = 33,
    NewArrayInit = 32,
    Not = 34,
    NotEqual = 35,
    Or = 36,
    OrElse = 37,
    Parameter = 38,
    Power = 39,
    Quote = 40,
    RightShift = 41,
    Subtract = 42,
    SubtractChecked = 43,
    TypeAs = 44,
    TypeIs = 45,
    UnaryPlus = 29,
  }
  public sealed partial class InvocationExpression : System.Linq.Expressions.Expression {
    internal InvocationExpression() : base (default(System.Linq.Expressions.ExpressionType), default(System.Type)) { }
    public System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.Expression> Arguments { get { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.Expression>); } }
    public System.Linq.Expressions.Expression Expression { get { return default(System.Linq.Expressions.Expression); } }
  }
  public partial class LambdaExpression : System.Linq.Expressions.Expression {
    internal LambdaExpression() : base (default(System.Linq.Expressions.ExpressionType), default(System.Type)) { }
    public System.Linq.Expressions.Expression Body { get { return default(System.Linq.Expressions.Expression); } }
    public System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.ParameterExpression> Parameters { get { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.ParameterExpression>); } }
    public System.Delegate Compile() { return default(System.Delegate); }
  }
  public sealed partial class ListInitExpression : System.Linq.Expressions.Expression {
    internal ListInitExpression() : base (default(System.Linq.Expressions.ExpressionType), default(System.Type)) { }
    public System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.ElementInit> Initializers { get { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.ElementInit>); } }
    public System.Linq.Expressions.NewExpression NewExpression { get { return default(System.Linq.Expressions.NewExpression); } }
  }
  public sealed partial class MemberAssignment : System.Linq.Expressions.MemberBinding {
    internal MemberAssignment() : base (default(System.Linq.Expressions.MemberBindingType), default(System.Reflection.MemberInfo)) { }
    public System.Linq.Expressions.Expression Expression { get { return default(System.Linq.Expressions.Expression); } }
  }
  public abstract partial class MemberBinding {
    protected MemberBinding(System.Linq.Expressions.MemberBindingType binding_type, System.Reflection.MemberInfo member) { }
    public System.Linq.Expressions.MemberBindingType BindingType { get { return default(System.Linq.Expressions.MemberBindingType); } }
    public System.Reflection.MemberInfo Member { get { return default(System.Reflection.MemberInfo); } }
    public override string ToString() { return default(string); }
  }
  public enum MemberBindingType {
    Assignment = 0,
    ListBinding = 2,
    MemberBinding = 1,
  }
  public sealed partial class MemberExpression : System.Linq.Expressions.Expression {
    internal MemberExpression() : base (default(System.Linq.Expressions.ExpressionType), default(System.Type)) { }
    public System.Linq.Expressions.Expression Expression { get { return default(System.Linq.Expressions.Expression); } }
    public System.Reflection.MemberInfo Member { get { return default(System.Reflection.MemberInfo); } }
  }
  public sealed partial class MemberInitExpression : System.Linq.Expressions.Expression {
    internal MemberInitExpression() : base (default(System.Linq.Expressions.ExpressionType), default(System.Type)) { }
    public System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.MemberBinding> Bindings { get { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.MemberBinding>); } }
    public System.Linq.Expressions.NewExpression NewExpression { get { return default(System.Linq.Expressions.NewExpression); } }
  }
  public sealed partial class MemberListBinding : System.Linq.Expressions.MemberBinding {
    internal MemberListBinding() : base (default(System.Linq.Expressions.MemberBindingType), default(System.Reflection.MemberInfo)) { }
    public System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.ElementInit> Initializers { get { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.ElementInit>); } }
  }
  public sealed partial class MemberMemberBinding : System.Linq.Expressions.MemberBinding {
    internal MemberMemberBinding() : base (default(System.Linq.Expressions.MemberBindingType), default(System.Reflection.MemberInfo)) { }
    public System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.MemberBinding> Bindings { get { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.MemberBinding>); } }
  }
  public sealed partial class MethodCallExpression : System.Linq.Expressions.Expression {
    internal MethodCallExpression() : base (default(System.Linq.Expressions.ExpressionType), default(System.Type)) { }
    public System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.Expression> Arguments { get { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.Expression>); } }
    public System.Reflection.MethodInfo Method { get { return default(System.Reflection.MethodInfo); } }
    public System.Linq.Expressions.Expression Object { get { return default(System.Linq.Expressions.Expression); } }
  }
  public sealed partial class NewArrayExpression : System.Linq.Expressions.Expression {
    internal NewArrayExpression() : base (default(System.Linq.Expressions.ExpressionType), default(System.Type)) { }
    public System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.Expression> Expressions { get { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.Expression>); } }
  }
  public sealed partial class NewExpression : System.Linq.Expressions.Expression {
    internal NewExpression() : base (default(System.Linq.Expressions.ExpressionType), default(System.Type)) { }
    public System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.Expression> Arguments { get { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.Expression>); } }
    public System.Reflection.ConstructorInfo Constructor { get { return default(System.Reflection.ConstructorInfo); } }
    public System.Collections.ObjectModel.ReadOnlyCollection<System.Reflection.MemberInfo> Members { get { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.Reflection.MemberInfo>); } }
  }
  public sealed partial class ParameterExpression : System.Linq.Expressions.Expression {
    internal ParameterExpression() : base (default(System.Linq.Expressions.ExpressionType), default(System.Type)) { }
    public string Name { get { return default(string); } }
  }
  public sealed partial class TypeBinaryExpression : System.Linq.Expressions.Expression {
    internal TypeBinaryExpression() : base (default(System.Linq.Expressions.ExpressionType), default(System.Type)) { }
    public System.Linq.Expressions.Expression Expression { get { return default(System.Linq.Expressions.Expression); } }
    public System.Type TypeOperand { get { return default(System.Type); } }
  }
  public sealed partial class UnaryExpression : System.Linq.Expressions.Expression {
    internal UnaryExpression() : base (default(System.Linq.Expressions.ExpressionType), default(System.Type)) { }
    public bool IsLifted { get { return default(bool); } }
    public bool IsLiftedToNull { get { return default(bool); } }
    public System.Reflection.MethodInfo Method { get { return default(System.Reflection.MethodInfo); } }
    public System.Linq.Expressions.Expression Operand { get { return default(System.Linq.Expressions.Expression); } }
  }
}
namespace System.Runtime.CompilerServices {
  public partial class ExecutionScope {
    internal ExecutionScope() { }
    public System.Object[] Globals;
    public System.Object[] Locals;
    public System.Runtime.CompilerServices.ExecutionScope Parent;
    public System.Delegate CreateDelegate(int indexLambda, System.Object[] locals) { return default(System.Delegate); }
    public System.Object[] CreateHoistedLocals() { return default(System.Object[]); }
    public System.Linq.Expressions.Expression IsolateExpression(System.Linq.Expressions.Expression expression, System.Object[] locals) { return default(System.Linq.Expressions.Expression); }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(69))]
  public sealed partial class ExtensionAttribute : System.Attribute {
    public ExtensionAttribute() { }
  }
  public partial interface IStrongBox {
    object Value { get; set; }
  }
  public partial class StrongBox<T> : System.Runtime.CompilerServices.IStrongBox {
    public T Value;
    public StrongBox(T value) { }
    object System.Runtime.CompilerServices.IStrongBox.Value { get { return default(object); } set { } }
  }
}
namespace System.Security.Cryptography {
  public abstract partial class Aes : System.Security.Cryptography.SymmetricAlgorithm {
    protected Aes() { }
    public static new System.Security.Cryptography.Aes Create() { return default(System.Security.Cryptography.Aes); }
    public static new System.Security.Cryptography.Aes Create(string algorithmName) { return default(System.Security.Cryptography.Aes); }
  }
  [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, MayLeakOnAbort=true)]
  public sealed partial class AesCryptoServiceProvider : System.Security.Cryptography.Aes {
    public AesCryptoServiceProvider() { }
    public override int FeedbackSize { get { return default(int); } set { } }
    public override System.Byte[] IV { get { return default(System.Byte[]); } set { } }
    public override System.Byte[] Key { get { return default(System.Byte[]); } set { } }
    public override int KeySize { get { return default(int); } set { } }
    public override System.Security.Cryptography.CipherMode Mode { get { return default(System.Security.Cryptography.CipherMode); } set { } }
    public override System.Security.Cryptography.PaddingMode Padding { get { return default(System.Security.Cryptography.PaddingMode); } set { } }
    public override System.Security.Cryptography.ICryptoTransform CreateDecryptor() { return default(System.Security.Cryptography.ICryptoTransform); }
    public override System.Security.Cryptography.ICryptoTransform CreateDecryptor(System.Byte[] rgbKey, System.Byte[] rgbIV) { return default(System.Security.Cryptography.ICryptoTransform); }
    public override System.Security.Cryptography.ICryptoTransform CreateEncryptor() { return default(System.Security.Cryptography.ICryptoTransform); }
    public override System.Security.Cryptography.ICryptoTransform CreateEncryptor(System.Byte[] rgbKey, System.Byte[] rgbIV) { return default(System.Security.Cryptography.ICryptoTransform); }
    protected override void Dispose(bool disposing) { }
    public override void GenerateIV() { }
    public override void GenerateKey() { }
  }
  [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, MayLeakOnAbort=true)]
  public sealed partial class AesManaged : System.Security.Cryptography.Aes {
    public AesManaged() { }
    public override int FeedbackSize { get { return default(int); } set { } }
    public override System.Byte[] IV { get { return default(System.Byte[]); } set { } }
    public override System.Byte[] Key { get { return default(System.Byte[]); } set { } }
    public override int KeySize { get { return default(int); } set { } }
    public override System.Security.Cryptography.CipherMode Mode { get { return default(System.Security.Cryptography.CipherMode); } set { } }
    public override System.Security.Cryptography.PaddingMode Padding { get { return default(System.Security.Cryptography.PaddingMode); } set { } }
    public override System.Security.Cryptography.ICryptoTransform CreateDecryptor() { return default(System.Security.Cryptography.ICryptoTransform); }
    public override System.Security.Cryptography.ICryptoTransform CreateDecryptor(System.Byte[] key, System.Byte[] iv) { return default(System.Security.Cryptography.ICryptoTransform); }
    public override System.Security.Cryptography.ICryptoTransform CreateEncryptor() { return default(System.Security.Cryptography.ICryptoTransform); }
    public override System.Security.Cryptography.ICryptoTransform CreateEncryptor(System.Byte[] key, System.Byte[] iv) { return default(System.Security.Cryptography.ICryptoTransform); }
    protected override void Dispose(bool disposing) { }
    public override void GenerateIV() { }
    public override void GenerateKey() { }
  }
  public sealed partial class CngAlgorithm : System.IEquatable<System.Security.Cryptography.CngAlgorithm> {
    public CngAlgorithm(string algorithm) { }
    public string Algorithm { get { return default(string); } }
    public static System.Security.Cryptography.CngAlgorithm ECDiffieHellmanP256 { get { return default(System.Security.Cryptography.CngAlgorithm); } }
    public static System.Security.Cryptography.CngAlgorithm ECDiffieHellmanP384 { get { return default(System.Security.Cryptography.CngAlgorithm); } }
    public static System.Security.Cryptography.CngAlgorithm ECDiffieHellmanP521 { get { return default(System.Security.Cryptography.CngAlgorithm); } }
    public static System.Security.Cryptography.CngAlgorithm ECDsaP256 { get { return default(System.Security.Cryptography.CngAlgorithm); } }
    public static System.Security.Cryptography.CngAlgorithm ECDsaP384 { get { return default(System.Security.Cryptography.CngAlgorithm); } }
    public static System.Security.Cryptography.CngAlgorithm ECDsaP521 { get { return default(System.Security.Cryptography.CngAlgorithm); } }
    public static System.Security.Cryptography.CngAlgorithm MD5 { get { return default(System.Security.Cryptography.CngAlgorithm); } }
    public static System.Security.Cryptography.CngAlgorithm Sha1 { get { return default(System.Security.Cryptography.CngAlgorithm); } }
    public static System.Security.Cryptography.CngAlgorithm Sha256 { get { return default(System.Security.Cryptography.CngAlgorithm); } }
    public static System.Security.Cryptography.CngAlgorithm Sha384 { get { return default(System.Security.Cryptography.CngAlgorithm); } }
    public static System.Security.Cryptography.CngAlgorithm Sha512 { get { return default(System.Security.Cryptography.CngAlgorithm); } }
    public override bool Equals(object obj) { return default(bool); }
    public bool Equals(System.Security.Cryptography.CngAlgorithm other) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public static bool operator ==(System.Security.Cryptography.CngAlgorithm left, System.Security.Cryptography.CngAlgorithm right) { return default(bool); }
    public static bool operator !=(System.Security.Cryptography.CngAlgorithm left, System.Security.Cryptography.CngAlgorithm right) { return default(bool); }
    public override string ToString() { return default(string); }
  }
  public sealed partial class CngAlgorithmGroup : System.IEquatable<System.Security.Cryptography.CngAlgorithmGroup> {
    public CngAlgorithmGroup(string algorithmGroup) { }
    public string AlgorithmGroup { get { return default(string); } }
    public static System.Security.Cryptography.CngAlgorithmGroup DiffieHellman { get { return default(System.Security.Cryptography.CngAlgorithmGroup); } }
    public static System.Security.Cryptography.CngAlgorithmGroup Dsa { get { return default(System.Security.Cryptography.CngAlgorithmGroup); } }
    public static System.Security.Cryptography.CngAlgorithmGroup ECDiffieHellman { get { return default(System.Security.Cryptography.CngAlgorithmGroup); } }
    public static System.Security.Cryptography.CngAlgorithmGroup ECDsa { get { return default(System.Security.Cryptography.CngAlgorithmGroup); } }
    public static System.Security.Cryptography.CngAlgorithmGroup Rsa { get { return default(System.Security.Cryptography.CngAlgorithmGroup); } }
    public override bool Equals(object obj) { return default(bool); }
    public bool Equals(System.Security.Cryptography.CngAlgorithmGroup other) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public static bool operator ==(System.Security.Cryptography.CngAlgorithmGroup left, System.Security.Cryptography.CngAlgorithmGroup right) { return default(bool); }
    public static bool operator !=(System.Security.Cryptography.CngAlgorithmGroup left, System.Security.Cryptography.CngAlgorithmGroup right) { return default(bool); }
    public override string ToString() { return default(string); }
  }
  public sealed partial class MD5Cng : System.Security.Cryptography.MD5 {
    [System.Security.SecurityCriticalAttribute]
    public MD5Cng() { }
    [System.Security.SecurityCriticalAttribute]
    protected override void Dispose(bool disposing) { }
    [System.Security.SecurityCriticalAttribute]
    protected override void HashCore(System.Byte[] array, int ibStart, int cbSize) { }
    [System.Security.SecurityCriticalAttribute]
    protected override System.Byte[] HashFinal() { return default(System.Byte[]); }
    [System.Security.SecurityCriticalAttribute]
    public override void Initialize() { }
  }
  public sealed partial class SHA1Cng : System.Security.Cryptography.SHA1 {
    [System.Security.SecurityCriticalAttribute]
    public SHA1Cng() { }
    [System.Security.SecurityCriticalAttribute]
    protected override void Dispose(bool disposing) { }
    [System.Security.SecurityCriticalAttribute]
    protected override void HashCore(System.Byte[] array, int ibStart, int cbSize) { }
    [System.Security.SecurityCriticalAttribute]
    protected override System.Byte[] HashFinal() { return default(System.Byte[]); }
    [System.Security.SecurityCriticalAttribute]
    public override void Initialize() { }
  }
  public sealed partial class SHA256Cng : System.Security.Cryptography.SHA256 {
    [System.Security.SecurityCriticalAttribute]
    public SHA256Cng() { }
    [System.Security.SecurityCriticalAttribute]
    protected override void Dispose(bool disposing) { }
    [System.Security.SecurityCriticalAttribute]
    protected override void HashCore(System.Byte[] array, int ibStart, int cbSize) { }
    [System.Security.SecurityCriticalAttribute]
    protected override System.Byte[] HashFinal() { return default(System.Byte[]); }
    [System.Security.SecurityCriticalAttribute]
    public override void Initialize() { }
  }
  public sealed partial class SHA256CryptoServiceProvider : System.Security.Cryptography.SHA256 {
    [System.Security.SecurityCriticalAttribute]
    public SHA256CryptoServiceProvider() { }
    [System.Security.SecurityCriticalAttribute]
    protected override void Dispose(bool disposing) { }
    [System.Security.SecurityCriticalAttribute]
    protected override void HashCore(System.Byte[] array, int ibStart, int cbSize) { }
    [System.Security.SecurityCriticalAttribute]
    protected override System.Byte[] HashFinal() { return default(System.Byte[]); }
    [System.Security.SecurityCriticalAttribute]
    public override void Initialize() { }
  }
  public sealed partial class SHA384Cng : System.Security.Cryptography.SHA384 {
    [System.Security.SecurityCriticalAttribute]
    public SHA384Cng() { }
    [System.Security.SecurityCriticalAttribute]
    protected override void Dispose(bool disposing) { }
    [System.Security.SecurityCriticalAttribute]
    protected override void HashCore(System.Byte[] array, int ibStart, int cbSize) { }
    [System.Security.SecurityCriticalAttribute]
    protected override System.Byte[] HashFinal() { return default(System.Byte[]); }
    [System.Security.SecurityCriticalAttribute]
    public override void Initialize() { }
  }
  public sealed partial class SHA384CryptoServiceProvider : System.Security.Cryptography.SHA384 {
    [System.Security.SecurityCriticalAttribute]
    public SHA384CryptoServiceProvider() { }
    [System.Security.SecurityCriticalAttribute]
    protected override void Dispose(bool disposing) { }
    [System.Security.SecurityCriticalAttribute]
    protected override void HashCore(System.Byte[] array, int ibStart, int cbSize) { }
    [System.Security.SecurityCriticalAttribute]
    protected override System.Byte[] HashFinal() { return default(System.Byte[]); }
    [System.Security.SecurityCriticalAttribute]
    public override void Initialize() { }
  }
  public sealed partial class SHA512Cng : System.Security.Cryptography.SHA512 {
    [System.Security.SecurityCriticalAttribute]
    public SHA512Cng() { }
    [System.Security.SecurityCriticalAttribute]
    protected override void Dispose(bool disposing) { }
    [System.Security.SecurityCriticalAttribute]
    protected override void HashCore(System.Byte[] array, int ibStart, int cbSize) { }
    [System.Security.SecurityCriticalAttribute]
    protected override System.Byte[] HashFinal() { return default(System.Byte[]); }
    [System.Security.SecurityCriticalAttribute]
    public override void Initialize() { }
  }
  public sealed partial class SHA512CryptoServiceProvider : System.Security.Cryptography.SHA512 {
    [System.Security.SecurityCriticalAttribute]
    public SHA512CryptoServiceProvider() { }
    [System.Security.SecurityCriticalAttribute]
    protected override void Dispose(bool disposing) { }
    [System.Security.SecurityCriticalAttribute]
    protected override void HashCore(System.Byte[] array, int ibStart, int cbSize) { }
    [System.Security.SecurityCriticalAttribute]
    protected override System.Byte[] HashFinal() { return default(System.Byte[]); }
    [System.Security.SecurityCriticalAttribute]
    public override void Initialize() { }
  }
}
namespace System.Threading {
  public partial class LockRecursionException : System.Exception {
    public LockRecursionException() { }
    protected LockRecursionException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext sc) { }
    public LockRecursionException(string message) { }
    public LockRecursionException(string message, System.Exception e) { }
  }
  public enum LockRecursionPolicy {
    NoRecursion = 0,
    SupportsRecursion = 1,
  }
  [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, MayLeakOnAbort=true)]
  [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Synchronization=true, ExternalThreading=true)]
  public partial class ReaderWriterLockSlim : System.IDisposable {
    public ReaderWriterLockSlim() { }
    public ReaderWriterLockSlim(System.Threading.LockRecursionPolicy recursionPolicy) { }
    public int CurrentReadCount { get { return default(int); } }
    public bool IsReadLockHeld { get { return default(bool); } }
    public bool IsUpgradeableReadLockHeld { get { return default(bool); } }
    public bool IsWriteLockHeld { get { return default(bool); } }
    public System.Threading.LockRecursionPolicy RecursionPolicy { get { return default(System.Threading.LockRecursionPolicy); } }
    public int RecursiveReadCount { get { return default(int); } }
    public int RecursiveUpgradeCount { get { return default(int); } }
    public int RecursiveWriteCount { get { return default(int); } }
    public int WaitingReadCount { get { return default(int); } }
    public int WaitingUpgradeCount { get { return default(int); } }
    public int WaitingWriteCount { get { return default(int); } }
    public void Dispose() { }
    public void EnterReadLock() { }
    public void EnterUpgradeableReadLock() { }
    public void EnterWriteLock() { }
    public void ExitReadLock() { }
    public void ExitUpgradeableReadLock() { }
    public void ExitWriteLock() { }
    public bool TryEnterReadLock(int millisecondsTimeout) { return default(bool); }
    public bool TryEnterReadLock(System.TimeSpan timeout) { return default(bool); }
    public bool TryEnterUpgradeableReadLock(int millisecondsTimeout) { return default(bool); }
    public bool TryEnterUpgradeableReadLock(System.TimeSpan timeout) { return default(bool); }
    public bool TryEnterWriteLock(int millisecondsTimeout) { return default(bool); }
    public bool TryEnterWriteLock(System.TimeSpan timeout) { return default(bool); }
  }
}
