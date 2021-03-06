namespace Microsoft.Win32.SafeHandles {
  public sealed partial class SafeMemoryMappedFileHandle : Microsoft.Win32.SafeHandles.SafeHandleZeroOrMinusOneIsInvalid {
    public SafeMemoryMappedFileHandle(System.IntPtr preexistingHandle, bool ownsHandle) : base (default(bool)) { }
    [System.MonoTODOAttribute]
    protected override bool ReleaseHandle() { return default(bool); }
  }
  public sealed partial class SafeMemoryMappedViewHandle : System.Runtime.InteropServices.SafeBuffer {
    internal SafeMemoryMappedViewHandle() : base (default(bool)) { }
    protected override bool ReleaseHandle() { return default(bool); }
  }
  [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, MayLeakOnAbort=true)]
  [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, UnmanagedCode=true)]
  public sealed partial class SafePipeHandle : Microsoft.Win32.SafeHandles.SafeHandleZeroOrMinusOneIsInvalid {
    public SafePipeHandle(System.IntPtr preexistingHandle, bool ownsHandle) : base (default(bool)) { }
    protected override bool ReleaseHandle() { return default(bool); }
  }
}
namespace System {
  public delegate void Action<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10);
  public delegate void Action<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11);
  public delegate void Action<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11, in T12>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12);
  public delegate void Action<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11, in T12, in T13>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13);
  public delegate void Action<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11, in T12, in T13, in T14>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14);
  public delegate void Action<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11, in T12, in T13, in T14, in T15>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15);
  public delegate void Action<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11, in T12, in T13, in T14, in T15, in T16>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15, T16 arg16);
  public delegate void Action<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9);
  public delegate TResult Func<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, out TResult>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9);
  public delegate TResult Func<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, out TResult>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10);
  public delegate TResult Func<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11, out TResult>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11);
  public delegate TResult Func<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11, in T12, out TResult>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12);
  public delegate TResult Func<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11, in T12, in T13, out TResult>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13);
  public delegate TResult Func<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11, in T12, in T13, in T14, out TResult>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14);
  public delegate TResult Func<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11, in T12, in T13, in T14, in T15, out TResult>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15);
  public delegate TResult Func<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11, in T12, in T13, in T14, in T15, in T16, out TResult>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15, T16 arg16);
}
namespace System.Collections.Generic {
  [System.Diagnostics.DebuggerDisplayAttribute("Count={Count}")]
  [System.Diagnostics.DebuggerTypeProxyAttribute(typeof(System.Collections.Generic.CollectionDebuggerView<T, U>))]
  public partial class HashSet<T> : System.Collections.Generic.ICollection<T>, System.Collections.Generic.IEnumerable<T>, System.Collections.Generic.ISet<T>, System.Collections.IEnumerable, System.Runtime.Serialization.IDeserializationCallback, System.Runtime.Serialization.ISerializable {
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
namespace System.Dynamic {
  public abstract partial class BinaryOperationBinder : System.Dynamic.DynamicMetaObjectBinder {
    protected BinaryOperationBinder(System.Linq.Expressions.ExpressionType operation) { }
    public System.Linq.Expressions.ExpressionType Operation { get { return default(System.Linq.Expressions.ExpressionType); } }
    public sealed override System.Type ReturnType { get { return default(System.Type); } }
    public sealed override System.Dynamic.DynamicMetaObject Bind(System.Dynamic.DynamicMetaObject target, System.Dynamic.DynamicMetaObject[] args) { return default(System.Dynamic.DynamicMetaObject); }
    public System.Dynamic.DynamicMetaObject FallbackBinaryOperation(System.Dynamic.DynamicMetaObject target, System.Dynamic.DynamicMetaObject arg) { return default(System.Dynamic.DynamicMetaObject); }
    public abstract System.Dynamic.DynamicMetaObject FallbackBinaryOperation(System.Dynamic.DynamicMetaObject target, System.Dynamic.DynamicMetaObject arg, System.Dynamic.DynamicMetaObject errorSuggestion);
  }
  [System.Diagnostics.DebuggerDisplayAttribute("{DebugView}")]
  [System.Diagnostics.DebuggerTypeProxyAttribute(typeof(System.Dynamic.BindingRestrictions.BindingRestrictionsProxy))]
  public abstract partial class BindingRestrictions {
    internal BindingRestrictions() { }
    public static readonly System.Dynamic.BindingRestrictions Empty;
    public static System.Dynamic.BindingRestrictions Combine(System.Collections.Generic.IList<System.Dynamic.DynamicMetaObject> contributingObjects) { return default(System.Dynamic.BindingRestrictions); }
    public static System.Dynamic.BindingRestrictions GetExpressionRestriction(System.Linq.Expressions.Expression expression) { return default(System.Dynamic.BindingRestrictions); }
    public static System.Dynamic.BindingRestrictions GetInstanceRestriction(System.Linq.Expressions.Expression expression, object instance) { return default(System.Dynamic.BindingRestrictions); }
    public static System.Dynamic.BindingRestrictions GetTypeRestriction(System.Linq.Expressions.Expression expression, System.Type type) { return default(System.Dynamic.BindingRestrictions); }
    public System.Dynamic.BindingRestrictions Merge(System.Dynamic.BindingRestrictions restrictions) { return default(System.Dynamic.BindingRestrictions); }
    public System.Linq.Expressions.Expression ToExpression() { return default(System.Linq.Expressions.Expression); }
  }
  public sealed partial class CallInfo {
    public CallInfo(int argCount, System.Collections.Generic.IEnumerable<System.String> argNames) { }
    public CallInfo(int argCount, params System.String[] argNames) { }
    public int ArgumentCount { get { return default(int); } }
    public System.Collections.ObjectModel.ReadOnlyCollection<System.String> ArgumentNames { get { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.String>); } }
    public override bool Equals(object obj) { return default(bool); }
    public override int GetHashCode() { return default(int); }
  }
  public abstract partial class ConvertBinder : System.Dynamic.DynamicMetaObjectBinder {
    protected ConvertBinder(System.Type type, bool @explicit) { }
    public bool Explicit { get { return default(bool); } }
    public sealed override System.Type ReturnType { get { return default(System.Type); } }
    public System.Type Type { get { return default(System.Type); } }
    public sealed override System.Dynamic.DynamicMetaObject Bind(System.Dynamic.DynamicMetaObject target, System.Dynamic.DynamicMetaObject[] args) { return default(System.Dynamic.DynamicMetaObject); }
    public System.Dynamic.DynamicMetaObject FallbackConvert(System.Dynamic.DynamicMetaObject target) { return default(System.Dynamic.DynamicMetaObject); }
    public abstract System.Dynamic.DynamicMetaObject FallbackConvert(System.Dynamic.DynamicMetaObject target, System.Dynamic.DynamicMetaObject errorSuggestion);
  }
  public abstract partial class CreateInstanceBinder : System.Dynamic.DynamicMetaObjectBinder {
    protected CreateInstanceBinder(System.Dynamic.CallInfo callInfo) { }
    public System.Dynamic.CallInfo CallInfo { get { return default(System.Dynamic.CallInfo); } }
    public sealed override System.Type ReturnType { get { return default(System.Type); } }
    public sealed override System.Dynamic.DynamicMetaObject Bind(System.Dynamic.DynamicMetaObject target, System.Dynamic.DynamicMetaObject[] args) { return default(System.Dynamic.DynamicMetaObject); }
    public System.Dynamic.DynamicMetaObject FallbackCreateInstance(System.Dynamic.DynamicMetaObject target, System.Dynamic.DynamicMetaObject[] args) { return default(System.Dynamic.DynamicMetaObject); }
    public abstract System.Dynamic.DynamicMetaObject FallbackCreateInstance(System.Dynamic.DynamicMetaObject target, System.Dynamic.DynamicMetaObject[] args, System.Dynamic.DynamicMetaObject errorSuggestion);
  }
  public abstract partial class DeleteIndexBinder : System.Dynamic.DynamicMetaObjectBinder {
    protected DeleteIndexBinder(System.Dynamic.CallInfo callInfo) { }
    public System.Dynamic.CallInfo CallInfo { get { return default(System.Dynamic.CallInfo); } }
    public sealed override System.Type ReturnType { get { return default(System.Type); } }
    public sealed override System.Dynamic.DynamicMetaObject Bind(System.Dynamic.DynamicMetaObject target, System.Dynamic.DynamicMetaObject[] args) { return default(System.Dynamic.DynamicMetaObject); }
    public System.Dynamic.DynamicMetaObject FallbackDeleteIndex(System.Dynamic.DynamicMetaObject target, System.Dynamic.DynamicMetaObject[] indexes) { return default(System.Dynamic.DynamicMetaObject); }
    public abstract System.Dynamic.DynamicMetaObject FallbackDeleteIndex(System.Dynamic.DynamicMetaObject target, System.Dynamic.DynamicMetaObject[] indexes, System.Dynamic.DynamicMetaObject errorSuggestion);
  }
  public abstract partial class DeleteMemberBinder : System.Dynamic.DynamicMetaObjectBinder {
    protected DeleteMemberBinder(string name, bool ignoreCase) { }
    public bool IgnoreCase { get { return default(bool); } }
    public string Name { get { return default(string); } }
    public sealed override System.Type ReturnType { get { return default(System.Type); } }
    public sealed override System.Dynamic.DynamicMetaObject Bind(System.Dynamic.DynamicMetaObject target, System.Dynamic.DynamicMetaObject[] args) { return default(System.Dynamic.DynamicMetaObject); }
    public System.Dynamic.DynamicMetaObject FallbackDeleteMember(System.Dynamic.DynamicMetaObject target) { return default(System.Dynamic.DynamicMetaObject); }
    public abstract System.Dynamic.DynamicMetaObject FallbackDeleteMember(System.Dynamic.DynamicMetaObject target, System.Dynamic.DynamicMetaObject errorSuggestion);
  }
  public partial class DynamicMetaObject {
    public static readonly System.Dynamic.DynamicMetaObject[] EmptyMetaObjects;
    public DynamicMetaObject(System.Linq.Expressions.Expression expression, System.Dynamic.BindingRestrictions restrictions) { }
    public DynamicMetaObject(System.Linq.Expressions.Expression expression, System.Dynamic.BindingRestrictions restrictions, object value) { }
    public System.Linq.Expressions.Expression Expression { get { return default(System.Linq.Expressions.Expression); } }
    public bool HasValue { get { return default(bool); } }
    public System.Type LimitType { get { return default(System.Type); } }
    public System.Dynamic.BindingRestrictions Restrictions { get { return default(System.Dynamic.BindingRestrictions); } }
    public System.Type RuntimeType { get { return default(System.Type); } }
    public object Value { get { return default(object); } }
    public virtual System.Dynamic.DynamicMetaObject BindBinaryOperation(System.Dynamic.BinaryOperationBinder binder, System.Dynamic.DynamicMetaObject arg) { return default(System.Dynamic.DynamicMetaObject); }
    public virtual System.Dynamic.DynamicMetaObject BindConvert(System.Dynamic.ConvertBinder binder) { return default(System.Dynamic.DynamicMetaObject); }
    public virtual System.Dynamic.DynamicMetaObject BindCreateInstance(System.Dynamic.CreateInstanceBinder binder, System.Dynamic.DynamicMetaObject[] args) { return default(System.Dynamic.DynamicMetaObject); }
    public virtual System.Dynamic.DynamicMetaObject BindDeleteIndex(System.Dynamic.DeleteIndexBinder binder, System.Dynamic.DynamicMetaObject[] indexes) { return default(System.Dynamic.DynamicMetaObject); }
    public virtual System.Dynamic.DynamicMetaObject BindDeleteMember(System.Dynamic.DeleteMemberBinder binder) { return default(System.Dynamic.DynamicMetaObject); }
    public virtual System.Dynamic.DynamicMetaObject BindGetIndex(System.Dynamic.GetIndexBinder binder, System.Dynamic.DynamicMetaObject[] indexes) { return default(System.Dynamic.DynamicMetaObject); }
    public virtual System.Dynamic.DynamicMetaObject BindGetMember(System.Dynamic.GetMemberBinder binder) { return default(System.Dynamic.DynamicMetaObject); }
    public virtual System.Dynamic.DynamicMetaObject BindInvoke(System.Dynamic.InvokeBinder binder, System.Dynamic.DynamicMetaObject[] args) { return default(System.Dynamic.DynamicMetaObject); }
    public virtual System.Dynamic.DynamicMetaObject BindInvokeMember(System.Dynamic.InvokeMemberBinder binder, System.Dynamic.DynamicMetaObject[] args) { return default(System.Dynamic.DynamicMetaObject); }
    public virtual System.Dynamic.DynamicMetaObject BindSetIndex(System.Dynamic.SetIndexBinder binder, System.Dynamic.DynamicMetaObject[] indexes, System.Dynamic.DynamicMetaObject value) { return default(System.Dynamic.DynamicMetaObject); }
    public virtual System.Dynamic.DynamicMetaObject BindSetMember(System.Dynamic.SetMemberBinder binder, System.Dynamic.DynamicMetaObject value) { return default(System.Dynamic.DynamicMetaObject); }
    public virtual System.Dynamic.DynamicMetaObject BindUnaryOperation(System.Dynamic.UnaryOperationBinder binder) { return default(System.Dynamic.DynamicMetaObject); }
    public static System.Dynamic.DynamicMetaObject Create(object value, System.Linq.Expressions.Expression expression) { return default(System.Dynamic.DynamicMetaObject); }
    public virtual System.Collections.Generic.IEnumerable<System.String> GetDynamicMemberNames() { return default(System.Collections.Generic.IEnumerable<System.String>); }
  }
  public abstract partial class DynamicMetaObjectBinder : System.Runtime.CompilerServices.CallSiteBinder {
    protected DynamicMetaObjectBinder() { }
    public virtual System.Type ReturnType { get { return default(System.Type); } }
    public abstract System.Dynamic.DynamicMetaObject Bind(System.Dynamic.DynamicMetaObject target, System.Dynamic.DynamicMetaObject[] args);
    public sealed override System.Linq.Expressions.Expression Bind(System.Object[] args, System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.ParameterExpression> parameters, System.Linq.Expressions.LabelTarget returnLabel) { return default(System.Linq.Expressions.Expression); }
    public System.Dynamic.DynamicMetaObject Defer(System.Dynamic.DynamicMetaObject target, params System.Dynamic.DynamicMetaObject[] args) { return default(System.Dynamic.DynamicMetaObject); }
    public System.Dynamic.DynamicMetaObject Defer(params System.Dynamic.DynamicMetaObject[] args) { return default(System.Dynamic.DynamicMetaObject); }
    public System.Linq.Expressions.Expression GetUpdateExpression(System.Type type) { return default(System.Linq.Expressions.Expression); }
  }
  public partial class DynamicObject : System.Dynamic.IDynamicMetaObjectProvider {
    protected DynamicObject() { }
    public virtual System.Collections.Generic.IEnumerable<System.String> GetDynamicMemberNames() { return default(System.Collections.Generic.IEnumerable<System.String>); }
    public virtual System.Dynamic.DynamicMetaObject GetMetaObject(System.Linq.Expressions.Expression parameter) { return default(System.Dynamic.DynamicMetaObject); }
    public virtual bool TryBinaryOperation(System.Dynamic.BinaryOperationBinder binder, object arg, out object result) { result = default(object); return default(bool); }
    public virtual bool TryConvert(System.Dynamic.ConvertBinder binder, out object result) { result = default(object); return default(bool); }
    public virtual bool TryCreateInstance(System.Dynamic.CreateInstanceBinder binder, System.Object[] args, out object result) { result = default(object); return default(bool); }
    public virtual bool TryDeleteIndex(System.Dynamic.DeleteIndexBinder binder, System.Object[] indexes) { return default(bool); }
    public virtual bool TryDeleteMember(System.Dynamic.DeleteMemberBinder binder) { return default(bool); }
    public virtual bool TryGetIndex(System.Dynamic.GetIndexBinder binder, System.Object[] indexes, out object result) { result = default(object); return default(bool); }
    public virtual bool TryGetMember(System.Dynamic.GetMemberBinder binder, out object result) { result = default(object); return default(bool); }
    public virtual bool TryInvoke(System.Dynamic.InvokeBinder binder, System.Object[] args, out object result) { result = default(object); return default(bool); }
    public virtual bool TryInvokeMember(System.Dynamic.InvokeMemberBinder binder, System.Object[] args, out object result) { result = default(object); return default(bool); }
    public virtual bool TrySetIndex(System.Dynamic.SetIndexBinder binder, System.Object[] indexes, object value) { return default(bool); }
    public virtual bool TrySetMember(System.Dynamic.SetMemberBinder binder, object value) { return default(bool); }
    public virtual bool TryUnaryOperation(System.Dynamic.UnaryOperationBinder binder, out object result) { result = default(object); return default(bool); }
  }
  public sealed partial class ExpandoObject : System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String, System.Object>>, System.Collections.Generic.IDictionary<System.String, System.Object>, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>, System.Collections.IEnumerable, System.ComponentModel.INotifyPropertyChanged, System.Dynamic.IDynamicMetaObjectProvider {
    public ExpandoObject() { }
    int System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<string,object>>.Count { get { return default(int); } }
    bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<string,object>>.IsReadOnly { get { return default(bool); } }
    object System.Collections.Generic.IDictionary<string,object>.this[string key] { get { return default(object); } set { } }
    System.Collections.Generic.ICollection<System.String> System.Collections.Generic.IDictionary<string,object>.Keys { get { return default(System.Collections.Generic.ICollection<System.String>); } }
    System.Collections.Generic.ICollection<System.Object> System.Collections.Generic.IDictionary<string,object>.Values { get { return default(System.Collections.Generic.ICollection<System.Object>); } }
    event System.ComponentModel.PropertyChangedEventHandler System.ComponentModel.INotifyPropertyChanged.PropertyChanged { add { } remove { } }
    void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<string,object>>.Add(System.Collections.Generic.KeyValuePair<System.String, System.Object> item) { }
    void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<string,object>>.Clear() { }
    bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<string,object>>.Contains(System.Collections.Generic.KeyValuePair<System.String, System.Object> item) { return default(bool); }
    void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<string,object>>.CopyTo(System.Collections.Generic.KeyValuePair<System.String, System.Object>[] array, int arrayIndex) { }
    bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<string,object>>.Remove(System.Collections.Generic.KeyValuePair<System.String, System.Object> item) { return default(bool); }
    void System.Collections.Generic.IDictionary<string,object>.Add(string key, object value) { }
    bool System.Collections.Generic.IDictionary<string,object>.ContainsKey(string key) { return default(bool); }
    bool System.Collections.Generic.IDictionary<string,object>.Remove(string key) { return default(bool); }
    bool System.Collections.Generic.IDictionary<string,object>.TryGetValue(string key, out object value) { value = default(object); return default(bool); }
    System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String, System.Object>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string,object>>.GetEnumerator() { return default(System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String, System.Object>>); }
    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { return default(System.Collections.IEnumerator); }
    System.Dynamic.DynamicMetaObject System.Dynamic.IDynamicMetaObjectProvider.GetMetaObject(System.Linq.Expressions.Expression parameter) { return default(System.Dynamic.DynamicMetaObject); }
  }
  public abstract partial class GetIndexBinder : System.Dynamic.DynamicMetaObjectBinder {
    protected GetIndexBinder(System.Dynamic.CallInfo callInfo) { }
    public System.Dynamic.CallInfo CallInfo { get { return default(System.Dynamic.CallInfo); } }
    public sealed override System.Type ReturnType { get { return default(System.Type); } }
    public sealed override System.Dynamic.DynamicMetaObject Bind(System.Dynamic.DynamicMetaObject target, System.Dynamic.DynamicMetaObject[] args) { return default(System.Dynamic.DynamicMetaObject); }
    public System.Dynamic.DynamicMetaObject FallbackGetIndex(System.Dynamic.DynamicMetaObject target, System.Dynamic.DynamicMetaObject[] indexes) { return default(System.Dynamic.DynamicMetaObject); }
    public abstract System.Dynamic.DynamicMetaObject FallbackGetIndex(System.Dynamic.DynamicMetaObject target, System.Dynamic.DynamicMetaObject[] indexes, System.Dynamic.DynamicMetaObject errorSuggestion);
  }
  public abstract partial class GetMemberBinder : System.Dynamic.DynamicMetaObjectBinder {
    protected GetMemberBinder(string name, bool ignoreCase) { }
    public bool IgnoreCase { get { return default(bool); } }
    public string Name { get { return default(string); } }
    public sealed override System.Type ReturnType { get { return default(System.Type); } }
    public sealed override System.Dynamic.DynamicMetaObject Bind(System.Dynamic.DynamicMetaObject target, params System.Dynamic.DynamicMetaObject[] args) { return default(System.Dynamic.DynamicMetaObject); }
    public System.Dynamic.DynamicMetaObject FallbackGetMember(System.Dynamic.DynamicMetaObject target) { return default(System.Dynamic.DynamicMetaObject); }
    public abstract System.Dynamic.DynamicMetaObject FallbackGetMember(System.Dynamic.DynamicMetaObject target, System.Dynamic.DynamicMetaObject errorSuggestion);
  }
  public partial interface IDynamicMetaObjectProvider {
    System.Dynamic.DynamicMetaObject GetMetaObject(System.Linq.Expressions.Expression parameter);
  }
  public partial interface IInvokeOnGetBinder {
    bool InvokeOnGet { get; }
  }
  public abstract partial class InvokeBinder : System.Dynamic.DynamicMetaObjectBinder {
    protected InvokeBinder(System.Dynamic.CallInfo callInfo) { }
    public System.Dynamic.CallInfo CallInfo { get { return default(System.Dynamic.CallInfo); } }
    public sealed override System.Type ReturnType { get { return default(System.Type); } }
    public sealed override System.Dynamic.DynamicMetaObject Bind(System.Dynamic.DynamicMetaObject target, System.Dynamic.DynamicMetaObject[] args) { return default(System.Dynamic.DynamicMetaObject); }
    public System.Dynamic.DynamicMetaObject FallbackInvoke(System.Dynamic.DynamicMetaObject target, System.Dynamic.DynamicMetaObject[] args) { return default(System.Dynamic.DynamicMetaObject); }
    public abstract System.Dynamic.DynamicMetaObject FallbackInvoke(System.Dynamic.DynamicMetaObject target, System.Dynamic.DynamicMetaObject[] args, System.Dynamic.DynamicMetaObject errorSuggestion);
  }
  public abstract partial class InvokeMemberBinder : System.Dynamic.DynamicMetaObjectBinder {
    protected InvokeMemberBinder(string name, bool ignoreCase, System.Dynamic.CallInfo callInfo) { }
    public System.Dynamic.CallInfo CallInfo { get { return default(System.Dynamic.CallInfo); } }
    public bool IgnoreCase { get { return default(bool); } }
    public string Name { get { return default(string); } }
    public sealed override System.Type ReturnType { get { return default(System.Type); } }
    public sealed override System.Dynamic.DynamicMetaObject Bind(System.Dynamic.DynamicMetaObject target, System.Dynamic.DynamicMetaObject[] args) { return default(System.Dynamic.DynamicMetaObject); }
    public abstract System.Dynamic.DynamicMetaObject FallbackInvoke(System.Dynamic.DynamicMetaObject target, System.Dynamic.DynamicMetaObject[] args, System.Dynamic.DynamicMetaObject errorSuggestion);
    public System.Dynamic.DynamicMetaObject FallbackInvokeMember(System.Dynamic.DynamicMetaObject target, System.Dynamic.DynamicMetaObject[] args) { return default(System.Dynamic.DynamicMetaObject); }
    public abstract System.Dynamic.DynamicMetaObject FallbackInvokeMember(System.Dynamic.DynamicMetaObject target, System.Dynamic.DynamicMetaObject[] args, System.Dynamic.DynamicMetaObject errorSuggestion);
  }
  public abstract partial class SetIndexBinder : System.Dynamic.DynamicMetaObjectBinder {
    protected SetIndexBinder(System.Dynamic.CallInfo callInfo) { }
    public System.Dynamic.CallInfo CallInfo { get { return default(System.Dynamic.CallInfo); } }
    public sealed override System.Type ReturnType { get { return default(System.Type); } }
    public sealed override System.Dynamic.DynamicMetaObject Bind(System.Dynamic.DynamicMetaObject target, System.Dynamic.DynamicMetaObject[] args) { return default(System.Dynamic.DynamicMetaObject); }
    public System.Dynamic.DynamicMetaObject FallbackSetIndex(System.Dynamic.DynamicMetaObject target, System.Dynamic.DynamicMetaObject[] indexes, System.Dynamic.DynamicMetaObject value) { return default(System.Dynamic.DynamicMetaObject); }
    public abstract System.Dynamic.DynamicMetaObject FallbackSetIndex(System.Dynamic.DynamicMetaObject target, System.Dynamic.DynamicMetaObject[] indexes, System.Dynamic.DynamicMetaObject value, System.Dynamic.DynamicMetaObject errorSuggestion);
  }
  public abstract partial class SetMemberBinder : System.Dynamic.DynamicMetaObjectBinder {
    protected SetMemberBinder(string name, bool ignoreCase) { }
    public bool IgnoreCase { get { return default(bool); } }
    public string Name { get { return default(string); } }
    public sealed override System.Type ReturnType { get { return default(System.Type); } }
    public sealed override System.Dynamic.DynamicMetaObject Bind(System.Dynamic.DynamicMetaObject target, System.Dynamic.DynamicMetaObject[] args) { return default(System.Dynamic.DynamicMetaObject); }
    public System.Dynamic.DynamicMetaObject FallbackSetMember(System.Dynamic.DynamicMetaObject target, System.Dynamic.DynamicMetaObject value) { return default(System.Dynamic.DynamicMetaObject); }
    public abstract System.Dynamic.DynamicMetaObject FallbackSetMember(System.Dynamic.DynamicMetaObject target, System.Dynamic.DynamicMetaObject value, System.Dynamic.DynamicMetaObject errorSuggestion);
  }
  public abstract partial class UnaryOperationBinder : System.Dynamic.DynamicMetaObjectBinder {
    protected UnaryOperationBinder(System.Linq.Expressions.ExpressionType operation) { }
    public System.Linq.Expressions.ExpressionType Operation { get { return default(System.Linq.Expressions.ExpressionType); } }
    public sealed override System.Type ReturnType { get { return default(System.Type); } }
    public sealed override System.Dynamic.DynamicMetaObject Bind(System.Dynamic.DynamicMetaObject target, System.Dynamic.DynamicMetaObject[] args) { return default(System.Dynamic.DynamicMetaObject); }
    public System.Dynamic.DynamicMetaObject FallbackUnaryOperation(System.Dynamic.DynamicMetaObject target) { return default(System.Dynamic.DynamicMetaObject); }
    public abstract System.Dynamic.DynamicMetaObject FallbackUnaryOperation(System.Dynamic.DynamicMetaObject target, System.Dynamic.DynamicMetaObject errorSuggestion);
  }
}
namespace System.IO {
  public enum HandleInheritability {
    Inheritable = 1,
    None = 0,
  }
}
namespace System.IO.MemoryMappedFiles {
  public partial class MemoryMappedFile : System.IDisposable {
    internal MemoryMappedFile() { }
    [System.MonoTODOAttribute]
    public Microsoft.Win32.SafeHandles.SafeMemoryMappedFileHandle SafeMemoryMappedFileHandle { get { return default(Microsoft.Win32.SafeHandles.SafeMemoryMappedFileHandle); } }
    [System.MonoLimitationAttribute("memoryMappedFileSecurity is currently ignored")]
    public static System.IO.MemoryMappedFiles.MemoryMappedFile CreateFromFile(System.IO.FileStream fileStream, string mapName, long capacity, System.IO.MemoryMappedFiles.MemoryMappedFileAccess access, System.IO.MemoryMappedFiles.MemoryMappedFileSecurity memoryMappedFileSecurity, System.IO.HandleInheritability inheritability, bool leaveOpen) { return default(System.IO.MemoryMappedFiles.MemoryMappedFile); }
    public static System.IO.MemoryMappedFiles.MemoryMappedFile CreateFromFile(string path) { return default(System.IO.MemoryMappedFiles.MemoryMappedFile); }
    public static System.IO.MemoryMappedFiles.MemoryMappedFile CreateFromFile(string path, System.IO.FileMode mode) { return default(System.IO.MemoryMappedFiles.MemoryMappedFile); }
    public static System.IO.MemoryMappedFiles.MemoryMappedFile CreateFromFile(string path, System.IO.FileMode mode, string mapName) { return default(System.IO.MemoryMappedFiles.MemoryMappedFile); }
    public static System.IO.MemoryMappedFiles.MemoryMappedFile CreateFromFile(string path, System.IO.FileMode mode, string mapName, long capacity) { return default(System.IO.MemoryMappedFiles.MemoryMappedFile); }
    public static System.IO.MemoryMappedFiles.MemoryMappedFile CreateFromFile(string path, System.IO.FileMode mode, string mapName, long capacity, System.IO.MemoryMappedFiles.MemoryMappedFileAccess access) { return default(System.IO.MemoryMappedFiles.MemoryMappedFile); }
    [System.MonoLimitationAttribute("Named mappings scope is process local")]
    public static System.IO.MemoryMappedFiles.MemoryMappedFile CreateNew(string mapName, long capacity) { return default(System.IO.MemoryMappedFiles.MemoryMappedFile); }
    [System.MonoLimitationAttribute("Named mappings scope is process local")]
    public static System.IO.MemoryMappedFiles.MemoryMappedFile CreateNew(string mapName, long capacity, System.IO.MemoryMappedFiles.MemoryMappedFileAccess access) { return default(System.IO.MemoryMappedFiles.MemoryMappedFile); }
    [System.MonoLimitationAttribute("Named mappings scope is process local; options and memoryMappedFileSecurity are ignored")]
    public static System.IO.MemoryMappedFiles.MemoryMappedFile CreateNew(string mapName, long capacity, System.IO.MemoryMappedFiles.MemoryMappedFileAccess access, System.IO.MemoryMappedFiles.MemoryMappedFileOptions options, System.IO.MemoryMappedFiles.MemoryMappedFileSecurity memoryMappedFileSecurity, System.IO.HandleInheritability inheritability) { return default(System.IO.MemoryMappedFiles.MemoryMappedFile); }
    [System.MonoLimitationAttribute("Named mappings scope is process local")]
    public static System.IO.MemoryMappedFiles.MemoryMappedFile CreateOrOpen(string mapName, long capacity) { return default(System.IO.MemoryMappedFiles.MemoryMappedFile); }
    [System.MonoLimitationAttribute("Named mappings scope is process local")]
    public static System.IO.MemoryMappedFiles.MemoryMappedFile CreateOrOpen(string mapName, long capacity, System.IO.MemoryMappedFiles.MemoryMappedFileAccess access) { return default(System.IO.MemoryMappedFiles.MemoryMappedFile); }
    [System.MonoLimitationAttribute("Named mappings scope is process local")]
    public static System.IO.MemoryMappedFiles.MemoryMappedFile CreateOrOpen(string mapName, long capacity, System.IO.MemoryMappedFiles.MemoryMappedFileAccess access, System.IO.MemoryMappedFiles.MemoryMappedFileOptions options, System.IO.MemoryMappedFiles.MemoryMappedFileSecurity memoryMappedFileSecurity, System.IO.HandleInheritability inheritability) { return default(System.IO.MemoryMappedFiles.MemoryMappedFile); }
    public System.IO.MemoryMappedFiles.MemoryMappedViewAccessor CreateViewAccessor() { return default(System.IO.MemoryMappedFiles.MemoryMappedViewAccessor); }
    public System.IO.MemoryMappedFiles.MemoryMappedViewAccessor CreateViewAccessor(long offset, long size) { return default(System.IO.MemoryMappedFiles.MemoryMappedViewAccessor); }
    public System.IO.MemoryMappedFiles.MemoryMappedViewAccessor CreateViewAccessor(long offset, long size, System.IO.MemoryMappedFiles.MemoryMappedFileAccess access) { return default(System.IO.MemoryMappedFiles.MemoryMappedViewAccessor); }
    public System.IO.MemoryMappedFiles.MemoryMappedViewStream CreateViewStream() { return default(System.IO.MemoryMappedFiles.MemoryMappedViewStream); }
    public System.IO.MemoryMappedFiles.MemoryMappedViewStream CreateViewStream(long offset, long size) { return default(System.IO.MemoryMappedFiles.MemoryMappedViewStream); }
    public System.IO.MemoryMappedFiles.MemoryMappedViewStream CreateViewStream(long offset, long size, System.IO.MemoryMappedFiles.MemoryMappedFileAccess access) { return default(System.IO.MemoryMappedFiles.MemoryMappedViewStream); }
    public void Dispose() { }
    protected virtual void Dispose(bool disposing) { }
    [System.MonoTODOAttribute]
    public System.IO.MemoryMappedFiles.MemoryMappedFileSecurity GetAccessControl() { return default(System.IO.MemoryMappedFiles.MemoryMappedFileSecurity); }
    [System.MonoLimitationAttribute("Named mappings scope is process local")]
    public static System.IO.MemoryMappedFiles.MemoryMappedFile OpenExisting(string mapName) { return default(System.IO.MemoryMappedFiles.MemoryMappedFile); }
    [System.MonoLimitationAttribute("Named mappings scope is process local")]
    public static System.IO.MemoryMappedFiles.MemoryMappedFile OpenExisting(string mapName, System.IO.MemoryMappedFiles.MemoryMappedFileRights desiredAccessRights) { return default(System.IO.MemoryMappedFiles.MemoryMappedFile); }
    [System.MonoLimitationAttribute("Named mappings scope is process local")]
    public static System.IO.MemoryMappedFiles.MemoryMappedFile OpenExisting(string mapName, System.IO.MemoryMappedFiles.MemoryMappedFileRights desiredAccessRights, System.IO.HandleInheritability inheritability) { return default(System.IO.MemoryMappedFiles.MemoryMappedFile); }
    [System.MonoTODOAttribute]
    public void SetAccessControl(System.IO.MemoryMappedFiles.MemoryMappedFileSecurity memoryMappedFileSecurity) { }
  }
  public enum MemoryMappedFileAccess {
    CopyOnWrite = 3,
    Read = 1,
    ReadExecute = 4,
    ReadWrite = 0,
    ReadWriteExecute = 5,
    Write = 2,
  }
  [System.FlagsAttribute]
  public enum MemoryMappedFileOptions {
    DelayAllocatePages = 67108864,
    None = 0,
  }
  [System.FlagsAttribute]
  public enum MemoryMappedFileRights {
    AccessSystemSecurity = 16777216,
    ChangePermissions = 262144,
    CopyOnWrite = 1,
    Delete = 65536,
    Execute = 8,
    FullControl = 983055,
    Read = 4,
    ReadExecute = 12,
    ReadPermissions = 131072,
    ReadWrite = 6,
    ReadWriteExecute = 14,
    TakeOwnership = 524288,
    Write = 2,
  }
  public partial class MemoryMappedFileSecurity : System.Security.AccessControl.ObjectSecurity<System.IO.MemoryMappedFiles.MemoryMappedFileRights> {
    public MemoryMappedFileSecurity() : base (default(bool), default(System.Security.AccessControl.ResourceType)) { }
  }
  public sealed partial class MemoryMappedViewAccessor : System.IO.UnmanagedMemoryAccessor, System.IDisposable {
    internal MemoryMappedViewAccessor() { }
    public Microsoft.Win32.SafeHandles.SafeMemoryMappedViewHandle SafeMemoryMappedViewHandle { get { return default(Microsoft.Win32.SafeHandles.SafeMemoryMappedViewHandle); } }
    protected override void Dispose(bool disposing) { }
    public void Flush() { }
    void System.IDisposable.Dispose() { }
  }
  public sealed partial class MemoryMappedViewStream : System.IO.UnmanagedMemoryStream {
    internal MemoryMappedViewStream() { }
    public Microsoft.Win32.SafeHandles.SafeMemoryMappedViewHandle SafeMemoryMappedViewHandle { get { return default(Microsoft.Win32.SafeHandles.SafeMemoryMappedViewHandle); } }
    protected override void Dispose(bool disposing) { }
    public override void Flush() { }
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
    public static System.Collections.Generic.IEnumerable<TResult> Zip<TFirst, TSecond, TResult>(this System.Collections.Generic.IEnumerable<TFirst> first, System.Collections.Generic.IEnumerable<TSecond> second, System.Func<TFirst, TSecond, TResult> resultSelector) { return default(System.Collections.Generic.IEnumerable<TResult>); }
  }
  public abstract partial class EnumerableExecutor {
    protected EnumerableExecutor() { }
  }
  public partial class EnumerableExecutor<T> : System.Linq.EnumerableExecutor {
    public EnumerableExecutor(System.Linq.Expressions.Expression expression) { }
  }
  public abstract partial class EnumerableQuery {
    protected EnumerableQuery() { }
  }
  public partial class EnumerableQuery<T> : System.Linq.EnumerableQuery, System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable, System.Linq.IOrderedQueryable, System.Linq.IOrderedQueryable<T>, System.Linq.IQueryable, System.Linq.IQueryable<T>, System.Linq.IQueryProvider {
    public EnumerableQuery(System.Collections.Generic.IEnumerable<T> enumerable) { }
    public EnumerableQuery(System.Linq.Expressions.Expression expression) { }
    System.Type System.Linq.IQueryable.ElementType { get { return default(System.Type); } }
    System.Linq.Expressions.Expression System.Linq.IQueryable.Expression { get { return default(System.Linq.Expressions.Expression); } }
    System.Linq.IQueryProvider System.Linq.IQueryable.Provider { get { return default(System.Linq.IQueryProvider); } }
    System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { return default(System.Collections.Generic.IEnumerator<T>); }
    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { return default(System.Collections.IEnumerator); }
    System.Linq.IQueryable System.Linq.IQueryProvider.CreateQuery(System.Linq.Expressions.Expression expression) { return default(System.Linq.IQueryable); }
    System.Linq.IQueryable<TElem> System.Linq.IQueryProvider.CreateQuery<TElem>(System.Linq.Expressions.Expression expression) { return default(System.Linq.IQueryable<TElem>); }
    object System.Linq.IQueryProvider.Execute(System.Linq.Expressions.Expression expression) { return default(object); }
    TResult System.Linq.IQueryProvider.Execute<TResult>(System.Linq.Expressions.Expression expression) { return default(TResult); }
    public override string ToString() { return default(string); }
  }
  public partial interface IGrouping<out TKey, out TElement> : System.Collections.Generic.IEnumerable<TElement>, System.Collections.IEnumerable {
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
  public partial interface IOrderedQueryable<out T> : System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable, System.Linq.IOrderedQueryable, System.Linq.IQueryable, System.Linq.IQueryable<T> {
  }
  public partial interface IQueryable : System.Collections.IEnumerable {
    System.Type ElementType { get; }
    System.Linq.Expressions.Expression Expression { get; }
    System.Linq.IQueryProvider Provider { get; }
  }
  public partial interface IQueryable<out T> : System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable, System.Linq.IQueryable {
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
  public partial class OrderedParallelQuery<TSource> : System.Linq.ParallelQuery<TSource> {
    internal OrderedParallelQuery() { }
    public override System.Collections.Generic.IEnumerator<TSource> GetEnumerator() { return default(System.Collections.Generic.IEnumerator<TSource>); }
  }
  public static partial class ParallelEnumerable {
    public static TSource Aggregate<TSource>(this System.Linq.ParallelQuery<TSource> source, System.Func<TSource, TSource, TSource> func) { return default(TSource); }
    public static TAccumulate Aggregate<TSource, TAccumulate>(this System.Linq.ParallelQuery<TSource> source, TAccumulate seed, System.Func<TAccumulate, TSource, TAccumulate> func) { return default(TAccumulate); }
    public static TResult Aggregate<TSource, TAccumulate, TResult>(this System.Linq.ParallelQuery<TSource> source, TAccumulate seed, System.Func<TAccumulate, TSource, TAccumulate> updateAccumulatorFunc, System.Func<TAccumulate, TAccumulate, TAccumulate> combineAccumulatorsFunc, System.Func<TAccumulate, TResult> resultSelector) { return default(TResult); }
    public static TResult Aggregate<TSource, TAccumulate, TResult>(this System.Linq.ParallelQuery<TSource> source, TAccumulate seed, System.Func<TAccumulate, TSource, TAccumulate> func, System.Func<TAccumulate, TResult> resultSelector) { return default(TResult); }
    public static TResult Aggregate<TSource, TAccumulate, TResult>(this System.Linq.ParallelQuery<TSource> source, System.Func<TAccumulate> seedFactory, System.Func<TAccumulate, TSource, TAccumulate> updateAccumulatorFunc, System.Func<TAccumulate, TAccumulate, TAccumulate> combineAccumulatorsFunc, System.Func<TAccumulate, TResult> resultSelector) { return default(TResult); }
    public static bool All<TSource>(this System.Linq.ParallelQuery<TSource> source, System.Func<TSource, System.Boolean> predicate) { return default(bool); }
    public static bool Any<TSource>(this System.Linq.ParallelQuery<TSource> source) { return default(bool); }
    public static bool Any<TSource>(this System.Linq.ParallelQuery<TSource> source, System.Func<TSource, System.Boolean> predicate) { return default(bool); }
    public static System.Collections.Generic.IEnumerable<TSource> AsEnumerable<TSource>(this System.Linq.ParallelQuery<TSource> source) { return default(System.Collections.Generic.IEnumerable<TSource>); }
    public static System.Linq.ParallelQuery AsOrdered(this System.Linq.ParallelQuery source) { return default(System.Linq.ParallelQuery); }
    public static System.Linq.ParallelQuery<TSource> AsOrdered<TSource>(this System.Linq.ParallelQuery<TSource> source) { return default(System.Linq.ParallelQuery<TSource>); }
    public static System.Linq.ParallelQuery AsParallel(this System.Collections.IEnumerable source) { return default(System.Linq.ParallelQuery); }
    public static System.Linq.ParallelQuery<TSource> AsParallel<TSource>(this System.Collections.Concurrent.Partitioner<TSource> source) { return default(System.Linq.ParallelQuery<TSource>); }
    public static System.Linq.ParallelQuery<TSource> AsParallel<TSource>(this System.Collections.Generic.IEnumerable<TSource> source) { return default(System.Linq.ParallelQuery<TSource>); }
    public static System.Collections.Generic.IEnumerable<TSource> AsSequential<TSource>(this System.Linq.ParallelQuery<TSource> source) { return default(System.Collections.Generic.IEnumerable<TSource>); }
    public static System.Linq.ParallelQuery<TSource> AsUnordered<TSource>(this System.Linq.ParallelQuery<TSource> source) { return default(System.Linq.ParallelQuery<TSource>); }
    public static decimal Average(this System.Linq.ParallelQuery<System.Decimal> source) { return default(decimal); }
    public static double Average(this System.Linq.ParallelQuery<System.Double> source) { return default(double); }
    public static double Average(this System.Linq.ParallelQuery<System.Int32> source) { return default(double); }
    public static double Average(this System.Linq.ParallelQuery<System.Int64> source) { return default(double); }
    public static System.Nullable<System.Decimal> Average(this System.Linq.ParallelQuery<System.Nullable<System.Decimal>> source) { return default(System.Nullable<System.Decimal>); }
    public static System.Nullable<System.Double> Average(this System.Linq.ParallelQuery<System.Nullable<System.Double>> source) { return default(System.Nullable<System.Double>); }
    public static System.Nullable<System.Double> Average(this System.Linq.ParallelQuery<System.Nullable<System.Int32>> source) { return default(System.Nullable<System.Double>); }
    public static System.Nullable<System.Double> Average(this System.Linq.ParallelQuery<System.Nullable<System.Int64>> source) { return default(System.Nullable<System.Double>); }
    public static System.Nullable<System.Single> Average(this System.Linq.ParallelQuery<System.Nullable<System.Single>> source) { return default(System.Nullable<System.Single>); }
    public static float Average(this System.Linq.ParallelQuery<System.Single> source) { return default(float); }
    public static decimal Average<TSource>(this System.Linq.ParallelQuery<TSource> source, System.Func<TSource, System.Decimal> selector) { return default(decimal); }
    public static double Average<TSource>(this System.Linq.ParallelQuery<TSource> source, System.Func<TSource, System.Double> selector) { return default(double); }
    public static double Average<TSource>(this System.Linq.ParallelQuery<TSource> source, System.Func<TSource, System.Int32> selector) { return default(double); }
    public static double Average<TSource>(this System.Linq.ParallelQuery<TSource> source, System.Func<TSource, System.Int64> selector) { return default(double); }
    public static System.Nullable<System.Decimal> Average<TSource>(this System.Linq.ParallelQuery<TSource> source, System.Func<TSource, System.Nullable<System.Decimal>> selector) { return default(System.Nullable<System.Decimal>); }
    public static System.Nullable<System.Double> Average<TSource>(this System.Linq.ParallelQuery<TSource> source, System.Func<TSource, System.Nullable<System.Double>> selector) { return default(System.Nullable<System.Double>); }
    public static System.Nullable<System.Double> Average<TSource>(this System.Linq.ParallelQuery<TSource> source, System.Func<TSource, System.Nullable<System.Int32>> selector) { return default(System.Nullable<System.Double>); }
    public static System.Nullable<System.Double> Average<TSource>(this System.Linq.ParallelQuery<TSource> source, System.Func<TSource, System.Nullable<System.Int64>> selector) { return default(System.Nullable<System.Double>); }
    public static System.Nullable<System.Single> Average<TSource>(this System.Linq.ParallelQuery<TSource> source, System.Func<TSource, System.Nullable<System.Single>> selector) { return default(System.Nullable<System.Single>); }
    public static float Average<TSource>(this System.Linq.ParallelQuery<TSource> source, System.Func<TSource, System.Single> selector) { return default(float); }
    public static System.Linq.ParallelQuery<TResult> Cast<TResult>(this System.Linq.ParallelQuery source) { return default(System.Linq.ParallelQuery<TResult>); }
    [System.ObsoleteAttribute("The second data source of a binary operator must be of type System.Linq.ParallelQuery<T> rather than System.Collections.Generic.IEnumerable<T>. To fix this problem, use the AsParallel() extension method to convert the right data source to System.Linq.ParallelQuery<T>.")]
    public static System.Linq.ParallelQuery<TSource> Concat<TSource>(this System.Linq.ParallelQuery<TSource> first, System.Collections.Generic.IEnumerable<TSource> second) { return default(System.Linq.ParallelQuery<TSource>); }
    public static System.Linq.ParallelQuery<TSource> Concat<TSource>(this System.Linq.ParallelQuery<TSource> first, System.Linq.ParallelQuery<TSource> second) { return default(System.Linq.ParallelQuery<TSource>); }
    public static bool Contains<TSource>(this System.Linq.ParallelQuery<TSource> source, TSource value) { return default(bool); }
    public static bool Contains<TSource>(this System.Linq.ParallelQuery<TSource> source, TSource value, System.Collections.Generic.IEqualityComparer<TSource> comparer) { return default(bool); }
    public static int Count<TSource>(this System.Linq.ParallelQuery<TSource> source) { return default(int); }
    public static int Count<TSource>(this System.Linq.ParallelQuery<TSource> source, System.Func<TSource, System.Boolean> predicate) { return default(int); }
    public static System.Linq.ParallelQuery<TSource> DefaultIfEmpty<TSource>(this System.Linq.ParallelQuery<TSource> source) { return default(System.Linq.ParallelQuery<TSource>); }
    public static System.Linq.ParallelQuery<TSource> DefaultIfEmpty<TSource>(this System.Linq.ParallelQuery<TSource> source, TSource defaultValue) { return default(System.Linq.ParallelQuery<TSource>); }
    public static System.Linq.ParallelQuery<TSource> Distinct<TSource>(this System.Linq.ParallelQuery<TSource> source) { return default(System.Linq.ParallelQuery<TSource>); }
    public static System.Linq.ParallelQuery<TSource> Distinct<TSource>(this System.Linq.ParallelQuery<TSource> source, System.Collections.Generic.IEqualityComparer<TSource> comparer) { return default(System.Linq.ParallelQuery<TSource>); }
    public static TSource ElementAt<TSource>(this System.Linq.ParallelQuery<TSource> source, int index) { return default(TSource); }
    public static TSource ElementAtOrDefault<TSource>(this System.Linq.ParallelQuery<TSource> source, int index) { return default(TSource); }
    public static System.Linq.ParallelQuery<TResult> Empty<TResult>() { return default(System.Linq.ParallelQuery<TResult>); }
    [System.ObsoleteAttribute("The second data source of a binary operator must be of type System.Linq.ParallelQuery<T> rather than System.Collections.Generic.IEnumerable<T>. To fix this problem, use the AsParallel() extension method to convert the right data source to System.Linq.ParallelQuery<T>.")]
    public static System.Linq.ParallelQuery<TSource> Except<TSource>(this System.Linq.ParallelQuery<TSource> first, System.Collections.Generic.IEnumerable<TSource> second) { return default(System.Linq.ParallelQuery<TSource>); }
    [System.ObsoleteAttribute("The second data source of a binary operator must be of type System.Linq.ParallelQuery<T> rather than System.Collections.Generic.IEnumerable<T>. To fix this problem, use the AsParallel() extension method to convert the right data source to System.Linq.ParallelQuery<T>.")]
    public static System.Linq.ParallelQuery<TSource> Except<TSource>(this System.Linq.ParallelQuery<TSource> first, System.Collections.Generic.IEnumerable<TSource> second, System.Collections.Generic.IEqualityComparer<TSource> comparer) { return default(System.Linq.ParallelQuery<TSource>); }
    public static System.Linq.ParallelQuery<TSource> Except<TSource>(this System.Linq.ParallelQuery<TSource> first, System.Linq.ParallelQuery<TSource> second) { return default(System.Linq.ParallelQuery<TSource>); }
    public static System.Linq.ParallelQuery<TSource> Except<TSource>(this System.Linq.ParallelQuery<TSource> first, System.Linq.ParallelQuery<TSource> second, System.Collections.Generic.IEqualityComparer<TSource> comparer) { return default(System.Linq.ParallelQuery<TSource>); }
    public static TSource First<TSource>(this System.Linq.ParallelQuery<TSource> source) { return default(TSource); }
    public static TSource First<TSource>(this System.Linq.ParallelQuery<TSource> source, System.Func<TSource, System.Boolean> predicate) { return default(TSource); }
    public static TSource FirstOrDefault<TSource>(this System.Linq.ParallelQuery<TSource> source) { return default(TSource); }
    public static TSource FirstOrDefault<TSource>(this System.Linq.ParallelQuery<TSource> source, System.Func<TSource, System.Boolean> predicate) { return default(TSource); }
    public static void ForAll<TSource>(this System.Linq.ParallelQuery<TSource> source, System.Action<TSource> action) { }
    public static System.Linq.ParallelQuery<System.Linq.IGrouping<TKey, TSource>> GroupBy<TSource, TKey>(this System.Linq.ParallelQuery<TSource> source, System.Func<TSource, TKey> keySelector) { return default(System.Linq.ParallelQuery<System.Linq.IGrouping<TKey, TSource>>); }
    public static System.Linq.ParallelQuery<System.Linq.IGrouping<TKey, TSource>> GroupBy<TSource, TKey>(this System.Linq.ParallelQuery<TSource> source, System.Func<TSource, TKey> keySelector, System.Collections.Generic.IEqualityComparer<TKey> comparer) { return default(System.Linq.ParallelQuery<System.Linq.IGrouping<TKey, TSource>>); }
    public static System.Linq.ParallelQuery<System.Linq.IGrouping<TKey, TElement>> GroupBy<TSource, TKey, TElement>(this System.Linq.ParallelQuery<TSource> source, System.Func<TSource, TKey> keySelector, System.Func<TSource, TElement> elementSelector) { return default(System.Linq.ParallelQuery<System.Linq.IGrouping<TKey, TElement>>); }
    public static System.Linq.ParallelQuery<System.Linq.IGrouping<TKey, TElement>> GroupBy<TSource, TKey, TElement>(this System.Linq.ParallelQuery<TSource> source, System.Func<TSource, TKey> keySelector, System.Func<TSource, TElement> elementSelector, System.Collections.Generic.IEqualityComparer<TKey> comparer) { return default(System.Linq.ParallelQuery<System.Linq.IGrouping<TKey, TElement>>); }
    public static System.Linq.ParallelQuery<TResult> GroupBy<TSource, TKey, TResult>(this System.Linq.ParallelQuery<TSource> source, System.Func<TSource, TKey> keySelector, System.Func<TKey, System.Collections.Generic.IEnumerable<TSource>, TResult> resultSelector) { return default(System.Linq.ParallelQuery<TResult>); }
    public static System.Linq.ParallelQuery<TResult> GroupBy<TSource, TKey, TResult>(this System.Linq.ParallelQuery<TSource> source, System.Func<TSource, TKey> keySelector, System.Func<TKey, System.Collections.Generic.IEnumerable<TSource>, TResult> resultSelector, System.Collections.Generic.IEqualityComparer<TKey> comparer) { return default(System.Linq.ParallelQuery<TResult>); }
    public static System.Linq.ParallelQuery<TResult> GroupBy<TSource, TKey, TElement, TResult>(this System.Linq.ParallelQuery<TSource> source, System.Func<TSource, TKey> keySelector, System.Func<TSource, TElement> elementSelector, System.Func<TKey, System.Collections.Generic.IEnumerable<TElement>, TResult> resultSelector) { return default(System.Linq.ParallelQuery<TResult>); }
    public static System.Linq.ParallelQuery<TResult> GroupBy<TSource, TKey, TElement, TResult>(this System.Linq.ParallelQuery<TSource> source, System.Func<TSource, TKey> keySelector, System.Func<TSource, TElement> elementSelector, System.Func<TKey, System.Collections.Generic.IEnumerable<TElement>, TResult> resultSelector, System.Collections.Generic.IEqualityComparer<TKey> comparer) { return default(System.Linq.ParallelQuery<TResult>); }
    [System.ObsoleteAttribute("The second data source of a binary operator must be of type System.Linq.ParallelQuery<T> rather than System.Collections.Generic.IEnumerable<T>. To fix this problem, use the AsParallel() extension method to convert the right data source to System.Linq.ParallelQuery<T>.")]
    public static System.Linq.ParallelQuery<TResult> GroupJoin<TOuter, TInner, TKey, TResult>(this System.Linq.ParallelQuery<TOuter> outer, System.Collections.Generic.IEnumerable<TInner> inner, System.Func<TOuter, TKey> outerKeySelector, System.Func<TInner, TKey> innerKeySelector, System.Func<TOuter, System.Collections.Generic.IEnumerable<TInner>, TResult> resultSelector) { return default(System.Linq.ParallelQuery<TResult>); }
    [System.ObsoleteAttribute("The second data source of a binary operator must be of type System.Linq.ParallelQuery<T> rather than System.Collections.Generic.IEnumerable<T>. To fix this problem, use the AsParallel() extension method to convert the right data source to System.Linq.ParallelQuery<T>.")]
    public static System.Linq.ParallelQuery<TResult> GroupJoin<TOuter, TInner, TKey, TResult>(this System.Linq.ParallelQuery<TOuter> outer, System.Collections.Generic.IEnumerable<TInner> inner, System.Func<TOuter, TKey> outerKeySelector, System.Func<TInner, TKey> innerKeySelector, System.Func<TOuter, System.Collections.Generic.IEnumerable<TInner>, TResult> resultSelector, System.Collections.Generic.IEqualityComparer<TKey> comparer) { return default(System.Linq.ParallelQuery<TResult>); }
    public static System.Linq.ParallelQuery<TResult> GroupJoin<TOuter, TInner, TKey, TResult>(this System.Linq.ParallelQuery<TOuter> outer, System.Linq.ParallelQuery<TInner> inner, System.Func<TOuter, TKey> outerKeySelector, System.Func<TInner, TKey> innerKeySelector, System.Func<TOuter, System.Collections.Generic.IEnumerable<TInner>, TResult> resultSelector) { return default(System.Linq.ParallelQuery<TResult>); }
    public static System.Linq.ParallelQuery<TResult> GroupJoin<TOuter, TInner, TKey, TResult>(this System.Linq.ParallelQuery<TOuter> outer, System.Linq.ParallelQuery<TInner> inner, System.Func<TOuter, TKey> outerKeySelector, System.Func<TInner, TKey> innerKeySelector, System.Func<TOuter, System.Collections.Generic.IEnumerable<TInner>, TResult> resultSelector, System.Collections.Generic.IEqualityComparer<TKey> comparer) { return default(System.Linq.ParallelQuery<TResult>); }
    [System.ObsoleteAttribute("The second data source of a binary operator must be of type System.Linq.ParallelQuery<T> rather than System.Collections.Generic.IEnumerable<T>. To fix this problem, use the AsParallel() extension method to convert the right data source to System.Linq.ParallelQuery<T>.")]
    public static System.Linq.ParallelQuery<TSource> Intersect<TSource>(this System.Linq.ParallelQuery<TSource> first, System.Collections.Generic.IEnumerable<TSource> second) { return default(System.Linq.ParallelQuery<TSource>); }
    [System.ObsoleteAttribute("The second data source of a binary operator must be of type System.Linq.ParallelQuery<T> rather than System.Collections.Generic.IEnumerable<T>. To fix this problem, use the AsParallel() extension method to convert the right data source to System.Linq.ParallelQuery<T>.")]
    public static System.Linq.ParallelQuery<TSource> Intersect<TSource>(this System.Linq.ParallelQuery<TSource> first, System.Collections.Generic.IEnumerable<TSource> second, System.Collections.Generic.IEqualityComparer<TSource> comparer) { return default(System.Linq.ParallelQuery<TSource>); }
    public static System.Linq.ParallelQuery<TSource> Intersect<TSource>(this System.Linq.ParallelQuery<TSource> first, System.Linq.ParallelQuery<TSource> second) { return default(System.Linq.ParallelQuery<TSource>); }
    public static System.Linq.ParallelQuery<TSource> Intersect<TSource>(this System.Linq.ParallelQuery<TSource> first, System.Linq.ParallelQuery<TSource> second, System.Collections.Generic.IEqualityComparer<TSource> comparer) { return default(System.Linq.ParallelQuery<TSource>); }
    [System.ObsoleteAttribute("The second data source of a binary operator must be of type System.Linq.ParallelQuery<T> rather than System.Collections.Generic.IEnumerable<T>. To fix this problem, use the AsParallel() extension method to convert the right data source to System.Linq.ParallelQuery<T>.")]
    public static System.Linq.ParallelQuery<TResult> Join<TOuter, TInner, TKey, TResult>(this System.Linq.ParallelQuery<TOuter> outer, System.Collections.Generic.IEnumerable<TInner> inner, System.Func<TOuter, TKey> outerKeySelector, System.Func<TInner, TKey> innerKeySelector, System.Func<TOuter, TInner, TResult> resultSelector) { return default(System.Linq.ParallelQuery<TResult>); }
    [System.ObsoleteAttribute("The second data source of a binary operator must be of type System.Linq.ParallelQuery<T> rather than System.Collections.Generic.IEnumerable<T>. To fix this problem, use the AsParallel() extension method to convert the right data source to System.Linq.ParallelQuery<T>.")]
    public static System.Linq.ParallelQuery<TResult> Join<TOuter, TInner, TKey, TResult>(this System.Linq.ParallelQuery<TOuter> outer, System.Collections.Generic.IEnumerable<TInner> inner, System.Func<TOuter, TKey> outerKeySelector, System.Func<TInner, TKey> innerKeySelector, System.Func<TOuter, TInner, TResult> resultSelector, System.Collections.Generic.IEqualityComparer<TKey> comparer) { return default(System.Linq.ParallelQuery<TResult>); }
    public static System.Linq.ParallelQuery<TResult> Join<TOuter, TInner, TKey, TResult>(this System.Linq.ParallelQuery<TOuter> outer, System.Linq.ParallelQuery<TInner> inner, System.Func<TOuter, TKey> outerKeySelector, System.Func<TInner, TKey> innerKeySelector, System.Func<TOuter, TInner, TResult> resultSelector) { return default(System.Linq.ParallelQuery<TResult>); }
    public static System.Linq.ParallelQuery<TResult> Join<TOuter, TInner, TKey, TResult>(this System.Linq.ParallelQuery<TOuter> outer, System.Linq.ParallelQuery<TInner> inner, System.Func<TOuter, TKey> outerKeySelector, System.Func<TInner, TKey> innerKeySelector, System.Func<TOuter, TInner, TResult> resultSelector, System.Collections.Generic.IEqualityComparer<TKey> comparer) { return default(System.Linq.ParallelQuery<TResult>); }
    public static TSource Last<TSource>(this System.Linq.ParallelQuery<TSource> source) { return default(TSource); }
    public static TSource Last<TSource>(this System.Linq.ParallelQuery<TSource> source, System.Func<TSource, System.Boolean> predicate) { return default(TSource); }
    public static TSource LastOrDefault<TSource>(this System.Linq.ParallelQuery<TSource> source) { return default(TSource); }
    public static TSource LastOrDefault<TSource>(this System.Linq.ParallelQuery<TSource> source, System.Func<TSource, System.Boolean> predicate) { return default(TSource); }
    public static long LongCount<TSource>(this System.Linq.ParallelQuery<TSource> source) { return default(long); }
    public static long LongCount<TSource>(this System.Linq.ParallelQuery<TSource> source, System.Func<TSource, System.Boolean> predicate) { return default(long); }
    public static decimal Max(this System.Linq.ParallelQuery<System.Decimal> source) { return default(decimal); }
    public static double Max(this System.Linq.ParallelQuery<System.Double> source) { return default(double); }
    public static int Max(this System.Linq.ParallelQuery<System.Int32> source) { return default(int); }
    public static long Max(this System.Linq.ParallelQuery<System.Int64> source) { return default(long); }
    public static System.Nullable<System.Decimal> Max(this System.Linq.ParallelQuery<System.Nullable<System.Decimal>> source) { return default(System.Nullable<System.Decimal>); }
    public static System.Nullable<System.Double> Max(this System.Linq.ParallelQuery<System.Nullable<System.Double>> source) { return default(System.Nullable<System.Double>); }
    public static System.Nullable<System.Int32> Max(this System.Linq.ParallelQuery<System.Nullable<System.Int32>> source) { return default(System.Nullable<System.Int32>); }
    public static System.Nullable<System.Int64> Max(this System.Linq.ParallelQuery<System.Nullable<System.Int64>> source) { return default(System.Nullable<System.Int64>); }
    public static System.Nullable<System.Single> Max(this System.Linq.ParallelQuery<System.Nullable<System.Single>> source) { return default(System.Nullable<System.Single>); }
    public static float Max(this System.Linq.ParallelQuery<System.Single> source) { return default(float); }
    public static TSource Max<TSource>(this System.Linq.ParallelQuery<TSource> source) { return default(TSource); }
    public static decimal Max<TSource>(this System.Linq.ParallelQuery<TSource> source, System.Func<TSource, System.Decimal> selector) { return default(decimal); }
    public static double Max<TSource>(this System.Linq.ParallelQuery<TSource> source, System.Func<TSource, System.Double> selector) { return default(double); }
    public static int Max<TSource>(this System.Linq.ParallelQuery<TSource> source, System.Func<TSource, System.Int32> selector) { return default(int); }
    public static long Max<TSource>(this System.Linq.ParallelQuery<TSource> source, System.Func<TSource, System.Int64> selector) { return default(long); }
    public static System.Nullable<System.Decimal> Max<TSource>(this System.Linq.ParallelQuery<TSource> source, System.Func<TSource, System.Nullable<System.Decimal>> selector) { return default(System.Nullable<System.Decimal>); }
    public static System.Nullable<System.Double> Max<TSource>(this System.Linq.ParallelQuery<TSource> source, System.Func<TSource, System.Nullable<System.Double>> selector) { return default(System.Nullable<System.Double>); }
    public static System.Nullable<System.Int32> Max<TSource>(this System.Linq.ParallelQuery<TSource> source, System.Func<TSource, System.Nullable<System.Int32>> selector) { return default(System.Nullable<System.Int32>); }
    public static System.Nullable<System.Int64> Max<TSource>(this System.Linq.ParallelQuery<TSource> source, System.Func<TSource, System.Nullable<System.Int64>> selector) { return default(System.Nullable<System.Int64>); }
    public static System.Nullable<System.Single> Max<TSource>(this System.Linq.ParallelQuery<TSource> source, System.Func<TSource, System.Nullable<System.Single>> selector) { return default(System.Nullable<System.Single>); }
    public static float Max<TSource>(this System.Linq.ParallelQuery<TSource> source, System.Func<TSource, System.Single> selector) { return default(float); }
    public static TResult Max<TSource, TResult>(this System.Linq.ParallelQuery<TSource> source, System.Func<TSource, TResult> selector) { return default(TResult); }
    public static decimal Min(this System.Linq.ParallelQuery<System.Decimal> source) { return default(decimal); }
    public static double Min(this System.Linq.ParallelQuery<System.Double> source) { return default(double); }
    public static int Min(this System.Linq.ParallelQuery<System.Int32> source) { return default(int); }
    public static long Min(this System.Linq.ParallelQuery<System.Int64> source) { return default(long); }
    public static System.Nullable<System.Decimal> Min(this System.Linq.ParallelQuery<System.Nullable<System.Decimal>> source) { return default(System.Nullable<System.Decimal>); }
    public static System.Nullable<System.Double> Min(this System.Linq.ParallelQuery<System.Nullable<System.Double>> source) { return default(System.Nullable<System.Double>); }
    public static System.Nullable<System.Int32> Min(this System.Linq.ParallelQuery<System.Nullable<System.Int32>> source) { return default(System.Nullable<System.Int32>); }
    public static System.Nullable<System.Int64> Min(this System.Linq.ParallelQuery<System.Nullable<System.Int64>> source) { return default(System.Nullable<System.Int64>); }
    public static System.Nullable<System.Single> Min(this System.Linq.ParallelQuery<System.Nullable<System.Single>> source) { return default(System.Nullable<System.Single>); }
    public static float Min(this System.Linq.ParallelQuery<System.Single> source) { return default(float); }
    public static TSource Min<TSource>(this System.Linq.ParallelQuery<TSource> source) { return default(TSource); }
    public static decimal Min<TSource>(this System.Linq.ParallelQuery<TSource> source, System.Func<TSource, System.Decimal> selector) { return default(decimal); }
    public static double Min<TSource>(this System.Linq.ParallelQuery<TSource> source, System.Func<TSource, System.Double> selector) { return default(double); }
    public static int Min<TSource>(this System.Linq.ParallelQuery<TSource> source, System.Func<TSource, System.Int32> selector) { return default(int); }
    public static long Min<TSource>(this System.Linq.ParallelQuery<TSource> source, System.Func<TSource, System.Int64> selector) { return default(long); }
    public static System.Nullable<System.Decimal> Min<TSource>(this System.Linq.ParallelQuery<TSource> source, System.Func<TSource, System.Nullable<System.Decimal>> selector) { return default(System.Nullable<System.Decimal>); }
    public static System.Nullable<System.Double> Min<TSource>(this System.Linq.ParallelQuery<TSource> source, System.Func<TSource, System.Nullable<System.Double>> selector) { return default(System.Nullable<System.Double>); }
    public static System.Nullable<System.Int32> Min<TSource>(this System.Linq.ParallelQuery<TSource> source, System.Func<TSource, System.Nullable<System.Int32>> selector) { return default(System.Nullable<System.Int32>); }
    public static System.Nullable<System.Int64> Min<TSource>(this System.Linq.ParallelQuery<TSource> source, System.Func<TSource, System.Nullable<System.Int64>> selector) { return default(System.Nullable<System.Int64>); }
    public static System.Nullable<System.Single> Min<TSource>(this System.Linq.ParallelQuery<TSource> source, System.Func<TSource, System.Nullable<System.Single>> selector) { return default(System.Nullable<System.Single>); }
    public static float Min<TSource>(this System.Linq.ParallelQuery<TSource> source, System.Func<TSource, System.Single> selector) { return default(float); }
    public static TResult Min<TSource, TResult>(this System.Linq.ParallelQuery<TSource> source, System.Func<TSource, TResult> selector) { return default(TResult); }
    public static System.Linq.ParallelQuery<TResult> OfType<TResult>(this System.Linq.ParallelQuery source) { return default(System.Linq.ParallelQuery<TResult>); }
    public static System.Linq.OrderedParallelQuery<TSource> OrderBy<TSource, TKey>(this System.Linq.ParallelQuery<TSource> source, System.Func<TSource, TKey> keySelector) { return default(System.Linq.OrderedParallelQuery<TSource>); }
    public static System.Linq.OrderedParallelQuery<TSource> OrderBy<TSource, TKey>(this System.Linq.ParallelQuery<TSource> source, System.Func<TSource, TKey> keySelector, System.Collections.Generic.IComparer<TKey> comparer) { return default(System.Linq.OrderedParallelQuery<TSource>); }
    public static System.Linq.OrderedParallelQuery<TSource> OrderByDescending<TSource, TKey>(this System.Linq.ParallelQuery<TSource> source, System.Func<TSource, TKey> keySelector) { return default(System.Linq.OrderedParallelQuery<TSource>); }
    public static System.Linq.OrderedParallelQuery<TSource> OrderByDescending<TSource, TKey>(this System.Linq.ParallelQuery<TSource> source, System.Func<TSource, TKey> keySelector, System.Collections.Generic.IComparer<TKey> comparer) { return default(System.Linq.OrderedParallelQuery<TSource>); }
    public static System.Linq.ParallelQuery<System.Int32> Range(int start, int count) { return default(System.Linq.ParallelQuery<System.Int32>); }
    public static System.Linq.ParallelQuery<TResult> Repeat<TResult>(TResult element, int count) { return default(System.Linq.ParallelQuery<TResult>); }
    public static System.Linq.ParallelQuery<TSource> Reverse<TSource>(this System.Linq.ParallelQuery<TSource> source) { return default(System.Linq.ParallelQuery<TSource>); }
    public static System.Linq.ParallelQuery<TResult> Select<TSource, TResult>(this System.Linq.ParallelQuery<TSource> source, System.Func<TSource, TResult> selector) { return default(System.Linq.ParallelQuery<TResult>); }
    public static System.Linq.ParallelQuery<TResult> Select<TSource, TResult>(this System.Linq.ParallelQuery<TSource> source, System.Func<TSource, System.Int32, TResult> selector) { return default(System.Linq.ParallelQuery<TResult>); }
    public static System.Linq.ParallelQuery<TResult> SelectMany<TSource, TResult>(this System.Linq.ParallelQuery<TSource> source, System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>> selector) { return default(System.Linq.ParallelQuery<TResult>); }
    public static System.Linq.ParallelQuery<TResult> SelectMany<TSource, TResult>(this System.Linq.ParallelQuery<TSource> source, System.Func<TSource, System.Int32, System.Collections.Generic.IEnumerable<TResult>> selector) { return default(System.Linq.ParallelQuery<TResult>); }
    public static System.Linq.ParallelQuery<TResult> SelectMany<TSource, TCollection, TResult>(this System.Linq.ParallelQuery<TSource> source, System.Func<TSource, System.Collections.Generic.IEnumerable<TCollection>> collectionSelector, System.Func<TSource, TCollection, TResult> resultSelector) { return default(System.Linq.ParallelQuery<TResult>); }
    public static System.Linq.ParallelQuery<TResult> SelectMany<TSource, TCollection, TResult>(this System.Linq.ParallelQuery<TSource> source, System.Func<TSource, System.Int32, System.Collections.Generic.IEnumerable<TCollection>> collectionSelector, System.Func<TSource, TCollection, TResult> resultSelector) { return default(System.Linq.ParallelQuery<TResult>); }
    [System.ObsoleteAttribute("The second data source of a binary operator must be of type System.Linq.ParallelQuery<T> rather than System.Collections.Generic.IEnumerable<T>. To fix this problem, use the AsParallel() extension method to convert the right data source to System.Linq.ParallelQuery<T>.")]
    public static bool SequenceEqual<TSource>(this System.Linq.ParallelQuery<TSource> first, System.Collections.Generic.IEnumerable<TSource> second) { return default(bool); }
    [System.ObsoleteAttribute("The second data source of a binary operator must be of type System.Linq.ParallelQuery<T> rather than System.Collections.Generic.IEnumerable<T>. To fix this problem, use the AsParallel() extension method to convert the right data source to System.Linq.ParallelQuery<T>.")]
    public static bool SequenceEqual<TSource>(this System.Linq.ParallelQuery<TSource> first, System.Collections.Generic.IEnumerable<TSource> second, System.Collections.Generic.IEqualityComparer<TSource> comparer) { return default(bool); }
    public static bool SequenceEqual<TSource>(this System.Linq.ParallelQuery<TSource> first, System.Linq.ParallelQuery<TSource> second) { return default(bool); }
    public static bool SequenceEqual<TSource>(this System.Linq.ParallelQuery<TSource> first, System.Linq.ParallelQuery<TSource> second, System.Collections.Generic.IEqualityComparer<TSource> comparer) { return default(bool); }
    public static TSource Single<TSource>(this System.Linq.ParallelQuery<TSource> source) { return default(TSource); }
    public static TSource Single<TSource>(this System.Linq.ParallelQuery<TSource> source, System.Func<TSource, System.Boolean> predicate) { return default(TSource); }
    public static TSource SingleOrDefault<TSource>(this System.Linq.ParallelQuery<TSource> source) { return default(TSource); }
    public static TSource SingleOrDefault<TSource>(this System.Linq.ParallelQuery<TSource> source, System.Func<TSource, System.Boolean> predicate) { return default(TSource); }
    public static System.Linq.ParallelQuery<TSource> Skip<TSource>(this System.Linq.ParallelQuery<TSource> source, int count) { return default(System.Linq.ParallelQuery<TSource>); }
    public static System.Linq.ParallelQuery<TSource> SkipWhile<TSource>(this System.Linq.ParallelQuery<TSource> source, System.Func<TSource, System.Boolean> predicate) { return default(System.Linq.ParallelQuery<TSource>); }
    public static System.Linq.ParallelQuery<TSource> SkipWhile<TSource>(this System.Linq.ParallelQuery<TSource> source, System.Func<TSource, System.Int32, System.Boolean> predicate) { return default(System.Linq.ParallelQuery<TSource>); }
    public static decimal Sum(this System.Linq.ParallelQuery<System.Decimal> source) { return default(decimal); }
    public static double Sum(this System.Linq.ParallelQuery<System.Double> source) { return default(double); }
    public static int Sum(this System.Linq.ParallelQuery<System.Int32> source) { return default(int); }
    public static long Sum(this System.Linq.ParallelQuery<System.Int64> source) { return default(long); }
    public static System.Nullable<System.Decimal> Sum(this System.Linq.ParallelQuery<System.Nullable<System.Decimal>> source) { return default(System.Nullable<System.Decimal>); }
    public static System.Nullable<System.Double> Sum(this System.Linq.ParallelQuery<System.Nullable<System.Double>> source) { return default(System.Nullable<System.Double>); }
    public static System.Nullable<System.Int32> Sum(this System.Linq.ParallelQuery<System.Nullable<System.Int32>> source) { return default(System.Nullable<System.Int32>); }
    public static System.Nullable<System.Int64> Sum(this System.Linq.ParallelQuery<System.Nullable<System.Int64>> source) { return default(System.Nullable<System.Int64>); }
    public static System.Nullable<System.Single> Sum(this System.Linq.ParallelQuery<System.Nullable<System.Single>> source) { return default(System.Nullable<System.Single>); }
    public static float Sum(this System.Linq.ParallelQuery<System.Single> source) { return default(float); }
    public static decimal Sum<TSource>(this System.Linq.ParallelQuery<TSource> source, System.Func<TSource, System.Decimal> selector) { return default(decimal); }
    public static double Sum<TSource>(this System.Linq.ParallelQuery<TSource> source, System.Func<TSource, System.Double> selector) { return default(double); }
    public static int Sum<TSource>(this System.Linq.ParallelQuery<TSource> source, System.Func<TSource, System.Int32> selector) { return default(int); }
    public static long Sum<TSource>(this System.Linq.ParallelQuery<TSource> source, System.Func<TSource, System.Int64> selector) { return default(long); }
    public static System.Nullable<System.Decimal> Sum<TSource>(this System.Linq.ParallelQuery<TSource> source, System.Func<TSource, System.Nullable<System.Decimal>> selector) { return default(System.Nullable<System.Decimal>); }
    public static System.Nullable<System.Double> Sum<TSource>(this System.Linq.ParallelQuery<TSource> source, System.Func<TSource, System.Nullable<System.Double>> selector) { return default(System.Nullable<System.Double>); }
    public static System.Nullable<System.Int32> Sum<TSource>(this System.Linq.ParallelQuery<TSource> source, System.Func<TSource, System.Nullable<System.Int32>> selector) { return default(System.Nullable<System.Int32>); }
    public static System.Nullable<System.Int64> Sum<TSource>(this System.Linq.ParallelQuery<TSource> source, System.Func<TSource, System.Nullable<System.Int64>> selector) { return default(System.Nullable<System.Int64>); }
    public static System.Nullable<System.Single> Sum<TSource>(this System.Linq.ParallelQuery<TSource> source, System.Func<TSource, System.Nullable<System.Single>> selector) { return default(System.Nullable<System.Single>); }
    public static float Sum<TSource>(this System.Linq.ParallelQuery<TSource> source, System.Func<TSource, System.Single> selector) { return default(float); }
    public static System.Linq.ParallelQuery<TSource> Take<TSource>(this System.Linq.ParallelQuery<TSource> source, int count) { return default(System.Linq.ParallelQuery<TSource>); }
    public static System.Linq.ParallelQuery<TSource> TakeWhile<TSource>(this System.Linq.ParallelQuery<TSource> source, System.Func<TSource, System.Boolean> predicate) { return default(System.Linq.ParallelQuery<TSource>); }
    public static System.Linq.ParallelQuery<TSource> TakeWhile<TSource>(this System.Linq.ParallelQuery<TSource> source, System.Func<TSource, System.Int32, System.Boolean> predicate) { return default(System.Linq.ParallelQuery<TSource>); }
    public static System.Linq.OrderedParallelQuery<TSource> ThenBy<TSource, TKey>(this System.Linq.OrderedParallelQuery<TSource> source, System.Func<TSource, TKey> keySelector) { return default(System.Linq.OrderedParallelQuery<TSource>); }
    public static System.Linq.OrderedParallelQuery<TSource> ThenBy<TSource, TKey>(this System.Linq.OrderedParallelQuery<TSource> source, System.Func<TSource, TKey> keySelector, System.Collections.Generic.IComparer<TKey> comparer) { return default(System.Linq.OrderedParallelQuery<TSource>); }
    public static System.Linq.OrderedParallelQuery<TSource> ThenByDescending<TSource, TKey>(this System.Linq.OrderedParallelQuery<TSource> source, System.Func<TSource, TKey> keySelector) { return default(System.Linq.OrderedParallelQuery<TSource>); }
    public static System.Linq.OrderedParallelQuery<TSource> ThenByDescending<TSource, TKey>(this System.Linq.OrderedParallelQuery<TSource> source, System.Func<TSource, TKey> keySelector, System.Collections.Generic.IComparer<TKey> comparer) { return default(System.Linq.OrderedParallelQuery<TSource>); }
    public static TSource[] ToArray<TSource>(this System.Linq.ParallelQuery<TSource> source) { return default(TSource[]); }
    public static System.Collections.Generic.Dictionary<TKey, TSource> ToDictionary<TSource, TKey>(this System.Linq.ParallelQuery<TSource> source, System.Func<TSource, TKey> keySelector) { return default(System.Collections.Generic.Dictionary<TKey, TSource>); }
    public static System.Collections.Generic.Dictionary<TKey, TSource> ToDictionary<TSource, TKey>(this System.Linq.ParallelQuery<TSource> source, System.Func<TSource, TKey> keySelector, System.Collections.Generic.IEqualityComparer<TKey> comparer) { return default(System.Collections.Generic.Dictionary<TKey, TSource>); }
    public static System.Collections.Generic.Dictionary<TKey, TElement> ToDictionary<TSource, TKey, TElement>(this System.Linq.ParallelQuery<TSource> source, System.Func<TSource, TKey> keySelector, System.Func<TSource, TElement> elementSelector) { return default(System.Collections.Generic.Dictionary<TKey, TElement>); }
    public static System.Collections.Generic.Dictionary<TKey, TElement> ToDictionary<TSource, TKey, TElement>(this System.Linq.ParallelQuery<TSource> source, System.Func<TSource, TKey> keySelector, System.Func<TSource, TElement> elementSelector, System.Collections.Generic.IEqualityComparer<TKey> comparer) { return default(System.Collections.Generic.Dictionary<TKey, TElement>); }
    public static System.Collections.Generic.List<TSource> ToList<TSource>(this System.Linq.ParallelQuery<TSource> source) { return default(System.Collections.Generic.List<TSource>); }
    public static System.Linq.ILookup<TKey, TSource> ToLookup<TSource, TKey>(this System.Linq.ParallelQuery<TSource> source, System.Func<TSource, TKey> keySelector) { return default(System.Linq.ILookup<TKey, TSource>); }
    public static System.Linq.ILookup<TKey, TSource> ToLookup<TSource, TKey>(this System.Linq.ParallelQuery<TSource> source, System.Func<TSource, TKey> keySelector, System.Collections.Generic.IEqualityComparer<TKey> comparer) { return default(System.Linq.ILookup<TKey, TSource>); }
    public static System.Linq.ILookup<TKey, TElement> ToLookup<TSource, TKey, TElement>(this System.Linq.ParallelQuery<TSource> source, System.Func<TSource, TKey> keySelector, System.Func<TSource, TElement> elementSelector) { return default(System.Linq.ILookup<TKey, TElement>); }
    public static System.Linq.ILookup<TKey, TElement> ToLookup<TSource, TKey, TElement>(this System.Linq.ParallelQuery<TSource> source, System.Func<TSource, TKey> keySelector, System.Func<TSource, TElement> elementSelector, System.Collections.Generic.IEqualityComparer<TKey> comparer) { return default(System.Linq.ILookup<TKey, TElement>); }
    [System.ObsoleteAttribute("The second data source of a binary operator must be of type System.Linq.ParallelQuery<T> rather than System.Collections.Generic.IEnumerable<T>. To fix this problem, use the AsParallel() extension method to convert the right data source to System.Linq.ParallelQuery<T>.")]
    public static System.Linq.ParallelQuery<TSource> Union<TSource>(this System.Linq.ParallelQuery<TSource> first, System.Collections.Generic.IEnumerable<TSource> second) { return default(System.Linq.ParallelQuery<TSource>); }
    [System.ObsoleteAttribute("The second data source of a binary operator must be of type System.Linq.ParallelQuery<T> rather than System.Collections.Generic.IEnumerable<T>. To fix this problem, use the AsParallel() extension method to convert the right data source to System.Linq.ParallelQuery<T>.")]
    public static System.Linq.ParallelQuery<TSource> Union<TSource>(this System.Linq.ParallelQuery<TSource> first, System.Collections.Generic.IEnumerable<TSource> second, System.Collections.Generic.IEqualityComparer<TSource> comparer) { return default(System.Linq.ParallelQuery<TSource>); }
    public static System.Linq.ParallelQuery<TSource> Union<TSource>(this System.Linq.ParallelQuery<TSource> first, System.Linq.ParallelQuery<TSource> second) { return default(System.Linq.ParallelQuery<TSource>); }
    public static System.Linq.ParallelQuery<TSource> Union<TSource>(this System.Linq.ParallelQuery<TSource> first, System.Linq.ParallelQuery<TSource> second, System.Collections.Generic.IEqualityComparer<TSource> comparer) { return default(System.Linq.ParallelQuery<TSource>); }
    public static System.Linq.ParallelQuery<TSource> Where<TSource>(this System.Linq.ParallelQuery<TSource> source, System.Func<TSource, System.Boolean> predicate) { return default(System.Linq.ParallelQuery<TSource>); }
    public static System.Linq.ParallelQuery<TSource> Where<TSource>(this System.Linq.ParallelQuery<TSource> source, System.Func<TSource, System.Int32, System.Boolean> predicate) { return default(System.Linq.ParallelQuery<TSource>); }
    public static System.Linq.ParallelQuery<TSource> WithCancellation<TSource>(this System.Linq.ParallelQuery<TSource> source, System.Threading.CancellationToken cancellationToken) { return default(System.Linq.ParallelQuery<TSource>); }
    public static System.Linq.ParallelQuery<TSource> WithDegreeOfParallelism<TSource>(this System.Linq.ParallelQuery<TSource> source, int degreeOfParallelism) { return default(System.Linq.ParallelQuery<TSource>); }
    public static System.Linq.ParallelQuery<TSource> WithExecutionMode<TSource>(this System.Linq.ParallelQuery<TSource> source, System.Linq.ParallelExecutionMode executionMode) { return default(System.Linq.ParallelQuery<TSource>); }
    public static System.Linq.ParallelQuery<TSource> WithMergeOptions<TSource>(this System.Linq.ParallelQuery<TSource> source, System.Linq.ParallelMergeOptions mergeOptions) { return default(System.Linq.ParallelQuery<TSource>); }
    [System.ObsoleteAttribute("The second data source of a binary operator must be of type System.Linq.ParallelQuery<T> rather than System.Collections.Generic.IEnumerable<T>. To fix this problem, use the AsParallel() extension method to convert the right data source to System.Linq.ParallelQuery<T>.")]
    public static System.Linq.ParallelQuery<TResult> Zip<TFirst, TSecond, TResult>(this System.Linq.ParallelQuery<TFirst> first, System.Collections.Generic.IEnumerable<TSecond> second, System.Func<TFirst, TSecond, TResult> resultSelector) { return default(System.Linq.ParallelQuery<TResult>); }
    public static System.Linq.ParallelQuery<TResult> Zip<TFirst, TSecond, TResult>(this System.Linq.ParallelQuery<TFirst> first, System.Linq.ParallelQuery<TSecond> second, System.Func<TFirst, TSecond, TResult> resultSelector) { return default(System.Linq.ParallelQuery<TResult>); }
  }
  public enum ParallelExecutionMode {
    Default = 0,
    ForceParallelism = 1,
  }
  public enum ParallelMergeOptions {
    AutoBuffered = 2,
    Default = 0,
    FullyBuffered = 3,
    NotBuffered = 1,
  }
  public partial class ParallelQuery : System.Collections.IEnumerable {
    internal ParallelQuery() { }
    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { return default(System.Collections.IEnumerator); }
  }
  public partial class ParallelQuery<TSource> : System.Linq.ParallelQuery, System.Collections.Generic.IEnumerable<TSource>, System.Collections.IEnumerable {
    internal ParallelQuery() { }
    public virtual System.Collections.Generic.IEnumerator<TSource> GetEnumerator() { return default(System.Collections.Generic.IEnumerator<TSource>); }
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
    public static System.Linq.IQueryable<TResult> Zip<TFirst, TSecond, TResult>(this System.Linq.IQueryable<TFirst> source1, System.Collections.Generic.IEnumerable<TSecond> source2, System.Linq.Expressions.Expression<System.Func<TFirst, TSecond, TResult>> resultSelector) { return default(System.Linq.IQueryable<TResult>); }
  }
}
namespace System.Linq.Expressions {
  [System.Diagnostics.DebuggerTypeProxyAttribute(typeof(System.Linq.Expressions.Expression.BinaryExpressionProxy))]
  public partial class BinaryExpression : System.Linq.Expressions.Expression {
    internal BinaryExpression() { }
    public override bool CanReduce { get { return default(bool); } }
    public System.Linq.Expressions.LambdaExpression Conversion { get { return default(System.Linq.Expressions.LambdaExpression); } }
    public bool IsLifted { get { return default(bool); } }
    public bool IsLiftedToNull { get { return default(bool); } }
    public System.Linq.Expressions.Expression Left { get { return default(System.Linq.Expressions.Expression); } }
    public System.Reflection.MethodInfo Method { get { return default(System.Reflection.MethodInfo); } }
    public System.Linq.Expressions.Expression Right { get { return default(System.Linq.Expressions.Expression); } }
    protected internal override System.Linq.Expressions.Expression Accept(System.Linq.Expressions.ExpressionVisitor visitor) { return default(System.Linq.Expressions.Expression); }
    public override System.Linq.Expressions.Expression Reduce() { return default(System.Linq.Expressions.Expression); }
    public System.Linq.Expressions.BinaryExpression Update(System.Linq.Expressions.Expression left, System.Linq.Expressions.LambdaExpression conversion, System.Linq.Expressions.Expression right) { return default(System.Linq.Expressions.BinaryExpression); }
  }
  [System.Diagnostics.DebuggerTypeProxyAttribute(typeof(System.Linq.Expressions.Expression.BlockExpressionProxy))]
  public partial class BlockExpression : System.Linq.Expressions.Expression {
    internal BlockExpression() { }
    public System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.Expression> Expressions { get { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.Expression>); } }
    public sealed override System.Linq.Expressions.ExpressionType NodeType { get { return default(System.Linq.Expressions.ExpressionType); } }
    public System.Linq.Expressions.Expression Result { get { return default(System.Linq.Expressions.Expression); } }
    public override System.Type Type { get { return default(System.Type); } }
    public System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.ParameterExpression> Variables { get { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.ParameterExpression>); } }
    protected internal override System.Linq.Expressions.Expression Accept(System.Linq.Expressions.ExpressionVisitor visitor) { return default(System.Linq.Expressions.Expression); }
    public System.Linq.Expressions.BlockExpression Update(System.Collections.Generic.IEnumerable<System.Linq.Expressions.ParameterExpression> variables, System.Collections.Generic.IEnumerable<System.Linq.Expressions.Expression> expressions) { return default(System.Linq.Expressions.BlockExpression); }
  }
  [System.Diagnostics.DebuggerTypeProxyAttribute(typeof(System.Linq.Expressions.Expression.CatchBlockProxy))]
  public sealed partial class CatchBlock {
    internal CatchBlock() { }
    public System.Linq.Expressions.Expression Body { get { return default(System.Linq.Expressions.Expression); } }
    public System.Linq.Expressions.Expression Filter { get { return default(System.Linq.Expressions.Expression); } }
    public System.Type Test { get { return default(System.Type); } }
    public System.Linq.Expressions.ParameterExpression Variable { get { return default(System.Linq.Expressions.ParameterExpression); } }
    public override string ToString() { return default(string); }
    public System.Linq.Expressions.CatchBlock Update(System.Linq.Expressions.ParameterExpression variable, System.Linq.Expressions.Expression filter, System.Linq.Expressions.Expression body) { return default(System.Linq.Expressions.CatchBlock); }
  }
  [System.Diagnostics.DebuggerTypeProxyAttribute(typeof(System.Linq.Expressions.Expression.ConditionalExpressionProxy))]
  public partial class ConditionalExpression : System.Linq.Expressions.Expression {
    internal ConditionalExpression() { }
    public System.Linq.Expressions.Expression IfFalse { get { return default(System.Linq.Expressions.Expression); } }
    public System.Linq.Expressions.Expression IfTrue { get { return default(System.Linq.Expressions.Expression); } }
    public sealed override System.Linq.Expressions.ExpressionType NodeType { get { return default(System.Linq.Expressions.ExpressionType); } }
    public System.Linq.Expressions.Expression Test { get { return default(System.Linq.Expressions.Expression); } }
    public override System.Type Type { get { return default(System.Type); } }
    protected internal override System.Linq.Expressions.Expression Accept(System.Linq.Expressions.ExpressionVisitor visitor) { return default(System.Linq.Expressions.Expression); }
    public System.Linq.Expressions.ConditionalExpression Update(System.Linq.Expressions.Expression test, System.Linq.Expressions.Expression ifTrue, System.Linq.Expressions.Expression ifFalse) { return default(System.Linq.Expressions.ConditionalExpression); }
  }
  [System.Diagnostics.DebuggerTypeProxyAttribute(typeof(System.Linq.Expressions.Expression.ConstantExpressionProxy))]
  public partial class ConstantExpression : System.Linq.Expressions.Expression {
    internal ConstantExpression() { }
    public sealed override System.Linq.Expressions.ExpressionType NodeType { get { return default(System.Linq.Expressions.ExpressionType); } }
    public override System.Type Type { get { return default(System.Type); } }
    public object Value { get { return default(object); } }
    protected internal override System.Linq.Expressions.Expression Accept(System.Linq.Expressions.ExpressionVisitor visitor) { return default(System.Linq.Expressions.Expression); }
  }
  [System.Diagnostics.DebuggerTypeProxyAttribute(typeof(System.Linq.Expressions.Expression.DebugInfoExpressionProxy))]
  public partial class DebugInfoExpression : System.Linq.Expressions.Expression {
    internal DebugInfoExpression() { }
    public System.Linq.Expressions.SymbolDocumentInfo Document { get { return default(System.Linq.Expressions.SymbolDocumentInfo); } }
    public virtual int EndColumn { get { return default(int); } }
    public virtual int EndLine { get { return default(int); } }
    public virtual bool IsClear { get { return default(bool); } }
    public sealed override System.Linq.Expressions.ExpressionType NodeType { get { return default(System.Linq.Expressions.ExpressionType); } }
    public virtual int StartColumn { get { return default(int); } }
    public virtual int StartLine { get { return default(int); } }
    public sealed override System.Type Type { get { return default(System.Type); } }
    protected internal override System.Linq.Expressions.Expression Accept(System.Linq.Expressions.ExpressionVisitor visitor) { return default(System.Linq.Expressions.Expression); }
  }
  [System.Diagnostics.DebuggerTypeProxyAttribute(typeof(System.Linq.Expressions.Expression.DefaultExpressionProxy))]
  public sealed partial class DefaultExpression : System.Linq.Expressions.Expression {
    internal DefaultExpression() { }
    public sealed override System.Linq.Expressions.ExpressionType NodeType { get { return default(System.Linq.Expressions.ExpressionType); } }
    public sealed override System.Type Type { get { return default(System.Type); } }
    protected internal override System.Linq.Expressions.Expression Accept(System.Linq.Expressions.ExpressionVisitor visitor) { return default(System.Linq.Expressions.Expression); }
  }
  [System.Diagnostics.DebuggerTypeProxyAttribute(typeof(System.Linq.Expressions.Expression.DynamicExpressionProxy))]
  public partial class DynamicExpression : System.Linq.Expressions.Expression {
    internal DynamicExpression() { }
    public System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.Expression> Arguments { get { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.Expression>); } }
    public System.Runtime.CompilerServices.CallSiteBinder Binder { get { return default(System.Runtime.CompilerServices.CallSiteBinder); } }
    public System.Type DelegateType { get { return default(System.Type); } }
    public sealed override System.Linq.Expressions.ExpressionType NodeType { get { return default(System.Linq.Expressions.ExpressionType); } }
    public override System.Type Type { get { return default(System.Type); } }
    protected internal override System.Linq.Expressions.Expression Accept(System.Linq.Expressions.ExpressionVisitor visitor) { return default(System.Linq.Expressions.Expression); }
    public System.Linq.Expressions.DynamicExpression Update(System.Collections.Generic.IEnumerable<System.Linq.Expressions.Expression> arguments) { return default(System.Linq.Expressions.DynamicExpression); }
  }
  public sealed partial class ElementInit {
    internal ElementInit() { }
    public System.Reflection.MethodInfo AddMethod { get { return default(System.Reflection.MethodInfo); } }
    public System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.Expression> Arguments { get { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.Expression>); } }
    public override string ToString() { return default(string); }
    public System.Linq.Expressions.ElementInit Update(System.Collections.Generic.IEnumerable<System.Linq.Expressions.Expression> arguments) { return default(System.Linq.Expressions.ElementInit); }
  }
  public abstract partial class Expression {
    protected Expression() { }
    [System.ObsoleteAttribute("use a different constructor that does not take ExpressionType. Then override NodeType and Type properties to provide the values that would be specified to this constructor.")]
    protected Expression(System.Linq.Expressions.ExpressionType nodeType, System.Type type) { }
    public virtual bool CanReduce { get { return default(bool); } }
    public virtual System.Linq.Expressions.ExpressionType NodeType { get { return default(System.Linq.Expressions.ExpressionType); } }
    public virtual System.Type Type { get { return default(System.Type); } }
    protected internal virtual System.Linq.Expressions.Expression Accept(System.Linq.Expressions.ExpressionVisitor visitor) { return default(System.Linq.Expressions.Expression); }
    public static System.Linq.Expressions.BinaryExpression Add(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right) { return default(System.Linq.Expressions.BinaryExpression); }
    public static System.Linq.Expressions.BinaryExpression Add(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right, System.Reflection.MethodInfo method) { return default(System.Linq.Expressions.BinaryExpression); }
    public static System.Linq.Expressions.BinaryExpression AddAssign(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right) { return default(System.Linq.Expressions.BinaryExpression); }
    public static System.Linq.Expressions.BinaryExpression AddAssign(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right, System.Reflection.MethodInfo method) { return default(System.Linq.Expressions.BinaryExpression); }
    public static System.Linq.Expressions.BinaryExpression AddAssign(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right, System.Reflection.MethodInfo method, System.Linq.Expressions.LambdaExpression conversion) { return default(System.Linq.Expressions.BinaryExpression); }
    public static System.Linq.Expressions.BinaryExpression AddAssignChecked(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right) { return default(System.Linq.Expressions.BinaryExpression); }
    public static System.Linq.Expressions.BinaryExpression AddAssignChecked(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right, System.Reflection.MethodInfo method) { return default(System.Linq.Expressions.BinaryExpression); }
    public static System.Linq.Expressions.BinaryExpression AddAssignChecked(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right, System.Reflection.MethodInfo method, System.Linq.Expressions.LambdaExpression conversion) { return default(System.Linq.Expressions.BinaryExpression); }
    public static System.Linq.Expressions.BinaryExpression AddChecked(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right) { return default(System.Linq.Expressions.BinaryExpression); }
    public static System.Linq.Expressions.BinaryExpression AddChecked(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right, System.Reflection.MethodInfo method) { return default(System.Linq.Expressions.BinaryExpression); }
    public static System.Linq.Expressions.BinaryExpression And(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right) { return default(System.Linq.Expressions.BinaryExpression); }
    public static System.Linq.Expressions.BinaryExpression And(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right, System.Reflection.MethodInfo method) { return default(System.Linq.Expressions.BinaryExpression); }
    public static System.Linq.Expressions.BinaryExpression AndAlso(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right) { return default(System.Linq.Expressions.BinaryExpression); }
    public static System.Linq.Expressions.BinaryExpression AndAlso(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right, System.Reflection.MethodInfo method) { return default(System.Linq.Expressions.BinaryExpression); }
    public static System.Linq.Expressions.BinaryExpression AndAssign(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right) { return default(System.Linq.Expressions.BinaryExpression); }
    public static System.Linq.Expressions.BinaryExpression AndAssign(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right, System.Reflection.MethodInfo method) { return default(System.Linq.Expressions.BinaryExpression); }
    public static System.Linq.Expressions.BinaryExpression AndAssign(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right, System.Reflection.MethodInfo method, System.Linq.Expressions.LambdaExpression conversion) { return default(System.Linq.Expressions.BinaryExpression); }
    public static System.Linq.Expressions.IndexExpression ArrayAccess(System.Linq.Expressions.Expression array, System.Collections.Generic.IEnumerable<System.Linq.Expressions.Expression> indexes) { return default(System.Linq.Expressions.IndexExpression); }
    public static System.Linq.Expressions.IndexExpression ArrayAccess(System.Linq.Expressions.Expression array, params System.Linq.Expressions.Expression[] indexes) { return default(System.Linq.Expressions.IndexExpression); }
    public static System.Linq.Expressions.MethodCallExpression ArrayIndex(System.Linq.Expressions.Expression array, System.Collections.Generic.IEnumerable<System.Linq.Expressions.Expression> indexes) { return default(System.Linq.Expressions.MethodCallExpression); }
    public static System.Linq.Expressions.BinaryExpression ArrayIndex(System.Linq.Expressions.Expression array, System.Linq.Expressions.Expression index) { return default(System.Linq.Expressions.BinaryExpression); }
    public static System.Linq.Expressions.MethodCallExpression ArrayIndex(System.Linq.Expressions.Expression array, params System.Linq.Expressions.Expression[] indexes) { return default(System.Linq.Expressions.MethodCallExpression); }
    public static System.Linq.Expressions.UnaryExpression ArrayLength(System.Linq.Expressions.Expression array) { return default(System.Linq.Expressions.UnaryExpression); }
    public static System.Linq.Expressions.BinaryExpression Assign(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right) { return default(System.Linq.Expressions.BinaryExpression); }
    public static System.Linq.Expressions.MemberAssignment Bind(System.Reflection.MemberInfo member, System.Linq.Expressions.Expression expression) { return default(System.Linq.Expressions.MemberAssignment); }
    public static System.Linq.Expressions.MemberAssignment Bind(System.Reflection.MethodInfo propertyAccessor, System.Linq.Expressions.Expression expression) { return default(System.Linq.Expressions.MemberAssignment); }
    public static System.Linq.Expressions.BlockExpression Block(System.Collections.Generic.IEnumerable<System.Linq.Expressions.Expression> expressions) { return default(System.Linq.Expressions.BlockExpression); }
    public static System.Linq.Expressions.BlockExpression Block(System.Collections.Generic.IEnumerable<System.Linq.Expressions.ParameterExpression> variables, System.Collections.Generic.IEnumerable<System.Linq.Expressions.Expression> expressions) { return default(System.Linq.Expressions.BlockExpression); }
    public static System.Linq.Expressions.BlockExpression Block(System.Collections.Generic.IEnumerable<System.Linq.Expressions.ParameterExpression> variables, params System.Linq.Expressions.Expression[] expressions) { return default(System.Linq.Expressions.BlockExpression); }
    public static System.Linq.Expressions.BlockExpression Block(System.Linq.Expressions.Expression arg0, System.Linq.Expressions.Expression arg1) { return default(System.Linq.Expressions.BlockExpression); }
    public static System.Linq.Expressions.BlockExpression Block(System.Linq.Expressions.Expression arg0, System.Linq.Expressions.Expression arg1, System.Linq.Expressions.Expression arg2) { return default(System.Linq.Expressions.BlockExpression); }
    public static System.Linq.Expressions.BlockExpression Block(System.Linq.Expressions.Expression arg0, System.Linq.Expressions.Expression arg1, System.Linq.Expressions.Expression arg2, System.Linq.Expressions.Expression arg3) { return default(System.Linq.Expressions.BlockExpression); }
    public static System.Linq.Expressions.BlockExpression Block(System.Linq.Expressions.Expression arg0, System.Linq.Expressions.Expression arg1, System.Linq.Expressions.Expression arg2, System.Linq.Expressions.Expression arg3, System.Linq.Expressions.Expression arg4) { return default(System.Linq.Expressions.BlockExpression); }
    public static System.Linq.Expressions.BlockExpression Block(params System.Linq.Expressions.Expression[] expressions) { return default(System.Linq.Expressions.BlockExpression); }
    public static System.Linq.Expressions.BlockExpression Block(System.Type type, System.Collections.Generic.IEnumerable<System.Linq.Expressions.Expression> expressions) { return default(System.Linq.Expressions.BlockExpression); }
    public static System.Linq.Expressions.BlockExpression Block(System.Type type, System.Collections.Generic.IEnumerable<System.Linq.Expressions.ParameterExpression> variables, System.Collections.Generic.IEnumerable<System.Linq.Expressions.Expression> expressions) { return default(System.Linq.Expressions.BlockExpression); }
    public static System.Linq.Expressions.BlockExpression Block(System.Type type, System.Collections.Generic.IEnumerable<System.Linq.Expressions.ParameterExpression> variables, params System.Linq.Expressions.Expression[] expressions) { return default(System.Linq.Expressions.BlockExpression); }
    public static System.Linq.Expressions.BlockExpression Block(System.Type type, params System.Linq.Expressions.Expression[] expressions) { return default(System.Linq.Expressions.BlockExpression); }
    public static System.Linq.Expressions.GotoExpression Break(System.Linq.Expressions.LabelTarget target) { return default(System.Linq.Expressions.GotoExpression); }
    public static System.Linq.Expressions.GotoExpression Break(System.Linq.Expressions.LabelTarget target, System.Linq.Expressions.Expression value) { return default(System.Linq.Expressions.GotoExpression); }
    public static System.Linq.Expressions.GotoExpression Break(System.Linq.Expressions.LabelTarget target, System.Linq.Expressions.Expression value, System.Type type) { return default(System.Linq.Expressions.GotoExpression); }
    public static System.Linq.Expressions.GotoExpression Break(System.Linq.Expressions.LabelTarget target, System.Type type) { return default(System.Linq.Expressions.GotoExpression); }
    public static System.Linq.Expressions.MethodCallExpression Call(System.Linq.Expressions.Expression instance, System.Reflection.MethodInfo method) { return default(System.Linq.Expressions.MethodCallExpression); }
    public static System.Linq.Expressions.MethodCallExpression Call(System.Linq.Expressions.Expression instance, System.Reflection.MethodInfo method, System.Collections.Generic.IEnumerable<System.Linq.Expressions.Expression> arguments) { return default(System.Linq.Expressions.MethodCallExpression); }
    public static System.Linq.Expressions.MethodCallExpression Call(System.Linq.Expressions.Expression instance, System.Reflection.MethodInfo method, System.Linq.Expressions.Expression arg0, System.Linq.Expressions.Expression arg1) { return default(System.Linq.Expressions.MethodCallExpression); }
    public static System.Linq.Expressions.MethodCallExpression Call(System.Linq.Expressions.Expression instance, System.Reflection.MethodInfo method, System.Linq.Expressions.Expression arg0, System.Linq.Expressions.Expression arg1, System.Linq.Expressions.Expression arg2) { return default(System.Linq.Expressions.MethodCallExpression); }
    public static System.Linq.Expressions.MethodCallExpression Call(System.Linq.Expressions.Expression instance, System.Reflection.MethodInfo method, params System.Linq.Expressions.Expression[] arguments) { return default(System.Linq.Expressions.MethodCallExpression); }
    public static System.Linq.Expressions.MethodCallExpression Call(System.Linq.Expressions.Expression instance, string methodName, System.Type[] typeArguments, params System.Linq.Expressions.Expression[] arguments) { return default(System.Linq.Expressions.MethodCallExpression); }
    public static System.Linq.Expressions.MethodCallExpression Call(System.Reflection.MethodInfo method, System.Collections.Generic.IEnumerable<System.Linq.Expressions.Expression> arguments) { return default(System.Linq.Expressions.MethodCallExpression); }
    public static System.Linq.Expressions.MethodCallExpression Call(System.Reflection.MethodInfo method, System.Linq.Expressions.Expression arg0) { return default(System.Linq.Expressions.MethodCallExpression); }
    public static System.Linq.Expressions.MethodCallExpression Call(System.Reflection.MethodInfo method, System.Linq.Expressions.Expression arg0, System.Linq.Expressions.Expression arg1) { return default(System.Linq.Expressions.MethodCallExpression); }
    public static System.Linq.Expressions.MethodCallExpression Call(System.Reflection.MethodInfo method, System.Linq.Expressions.Expression arg0, System.Linq.Expressions.Expression arg1, System.Linq.Expressions.Expression arg2) { return default(System.Linq.Expressions.MethodCallExpression); }
    public static System.Linq.Expressions.MethodCallExpression Call(System.Reflection.MethodInfo method, System.Linq.Expressions.Expression arg0, System.Linq.Expressions.Expression arg1, System.Linq.Expressions.Expression arg2, System.Linq.Expressions.Expression arg3) { return default(System.Linq.Expressions.MethodCallExpression); }
    public static System.Linq.Expressions.MethodCallExpression Call(System.Reflection.MethodInfo method, System.Linq.Expressions.Expression arg0, System.Linq.Expressions.Expression arg1, System.Linq.Expressions.Expression arg2, System.Linq.Expressions.Expression arg3, System.Linq.Expressions.Expression arg4) { return default(System.Linq.Expressions.MethodCallExpression); }
    public static System.Linq.Expressions.MethodCallExpression Call(System.Reflection.MethodInfo method, params System.Linq.Expressions.Expression[] arguments) { return default(System.Linq.Expressions.MethodCallExpression); }
    public static System.Linq.Expressions.MethodCallExpression Call(System.Type type, string methodName, System.Type[] typeArguments, params System.Linq.Expressions.Expression[] arguments) { return default(System.Linq.Expressions.MethodCallExpression); }
    public static System.Linq.Expressions.CatchBlock Catch(System.Linq.Expressions.ParameterExpression variable, System.Linq.Expressions.Expression body) { return default(System.Linq.Expressions.CatchBlock); }
    public static System.Linq.Expressions.CatchBlock Catch(System.Linq.Expressions.ParameterExpression variable, System.Linq.Expressions.Expression body, System.Linq.Expressions.Expression filter) { return default(System.Linq.Expressions.CatchBlock); }
    public static System.Linq.Expressions.CatchBlock Catch(System.Type type, System.Linq.Expressions.Expression body) { return default(System.Linq.Expressions.CatchBlock); }
    public static System.Linq.Expressions.CatchBlock Catch(System.Type type, System.Linq.Expressions.Expression body, System.Linq.Expressions.Expression filter) { return default(System.Linq.Expressions.CatchBlock); }
    public static System.Linq.Expressions.DebugInfoExpression ClearDebugInfo(System.Linq.Expressions.SymbolDocumentInfo document) { return default(System.Linq.Expressions.DebugInfoExpression); }
    public static System.Linq.Expressions.BinaryExpression Coalesce(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right) { return default(System.Linq.Expressions.BinaryExpression); }
    public static System.Linq.Expressions.BinaryExpression Coalesce(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right, System.Linq.Expressions.LambdaExpression conversion) { return default(System.Linq.Expressions.BinaryExpression); }
    public static System.Linq.Expressions.ConditionalExpression Condition(System.Linq.Expressions.Expression test, System.Linq.Expressions.Expression ifTrue, System.Linq.Expressions.Expression ifFalse) { return default(System.Linq.Expressions.ConditionalExpression); }
    public static System.Linq.Expressions.ConditionalExpression Condition(System.Linq.Expressions.Expression test, System.Linq.Expressions.Expression ifTrue, System.Linq.Expressions.Expression ifFalse, System.Type type) { return default(System.Linq.Expressions.ConditionalExpression); }
    public static System.Linq.Expressions.ConstantExpression Constant(object value) { return default(System.Linq.Expressions.ConstantExpression); }
    public static System.Linq.Expressions.ConstantExpression Constant(object value, System.Type type) { return default(System.Linq.Expressions.ConstantExpression); }
    public static System.Linq.Expressions.GotoExpression Continue(System.Linq.Expressions.LabelTarget target) { return default(System.Linq.Expressions.GotoExpression); }
    public static System.Linq.Expressions.GotoExpression Continue(System.Linq.Expressions.LabelTarget target, System.Type type) { return default(System.Linq.Expressions.GotoExpression); }
    public static System.Linq.Expressions.UnaryExpression Convert(System.Linq.Expressions.Expression expression, System.Type type) { return default(System.Linq.Expressions.UnaryExpression); }
    public static System.Linq.Expressions.UnaryExpression Convert(System.Linq.Expressions.Expression expression, System.Type type, System.Reflection.MethodInfo method) { return default(System.Linq.Expressions.UnaryExpression); }
    public static System.Linq.Expressions.UnaryExpression ConvertChecked(System.Linq.Expressions.Expression expression, System.Type type) { return default(System.Linq.Expressions.UnaryExpression); }
    public static System.Linq.Expressions.UnaryExpression ConvertChecked(System.Linq.Expressions.Expression expression, System.Type type, System.Reflection.MethodInfo method) { return default(System.Linq.Expressions.UnaryExpression); }
    public static System.Linq.Expressions.DebugInfoExpression DebugInfo(System.Linq.Expressions.SymbolDocumentInfo document, int startLine, int startColumn, int endLine, int endColumn) { return default(System.Linq.Expressions.DebugInfoExpression); }
    public static System.Linq.Expressions.UnaryExpression Decrement(System.Linq.Expressions.Expression expression) { return default(System.Linq.Expressions.UnaryExpression); }
    public static System.Linq.Expressions.UnaryExpression Decrement(System.Linq.Expressions.Expression expression, System.Reflection.MethodInfo method) { return default(System.Linq.Expressions.UnaryExpression); }
    public static System.Linq.Expressions.DefaultExpression Default(System.Type type) { return default(System.Linq.Expressions.DefaultExpression); }
    public static System.Linq.Expressions.BinaryExpression Divide(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right) { return default(System.Linq.Expressions.BinaryExpression); }
    public static System.Linq.Expressions.BinaryExpression Divide(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right, System.Reflection.MethodInfo method) { return default(System.Linq.Expressions.BinaryExpression); }
    public static System.Linq.Expressions.BinaryExpression DivideAssign(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right) { return default(System.Linq.Expressions.BinaryExpression); }
    public static System.Linq.Expressions.BinaryExpression DivideAssign(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right, System.Reflection.MethodInfo method) { return default(System.Linq.Expressions.BinaryExpression); }
    public static System.Linq.Expressions.BinaryExpression DivideAssign(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right, System.Reflection.MethodInfo method, System.Linq.Expressions.LambdaExpression conversion) { return default(System.Linq.Expressions.BinaryExpression); }
    public static System.Linq.Expressions.DynamicExpression Dynamic(System.Runtime.CompilerServices.CallSiteBinder binder, System.Type returnType, System.Collections.Generic.IEnumerable<System.Linq.Expressions.Expression> arguments) { return default(System.Linq.Expressions.DynamicExpression); }
    public static System.Linq.Expressions.DynamicExpression Dynamic(System.Runtime.CompilerServices.CallSiteBinder binder, System.Type returnType, System.Linq.Expressions.Expression arg0) { return default(System.Linq.Expressions.DynamicExpression); }
    public static System.Linq.Expressions.DynamicExpression Dynamic(System.Runtime.CompilerServices.CallSiteBinder binder, System.Type returnType, System.Linq.Expressions.Expression arg0, System.Linq.Expressions.Expression arg1) { return default(System.Linq.Expressions.DynamicExpression); }
    public static System.Linq.Expressions.DynamicExpression Dynamic(System.Runtime.CompilerServices.CallSiteBinder binder, System.Type returnType, System.Linq.Expressions.Expression arg0, System.Linq.Expressions.Expression arg1, System.Linq.Expressions.Expression arg2) { return default(System.Linq.Expressions.DynamicExpression); }
    public static System.Linq.Expressions.DynamicExpression Dynamic(System.Runtime.CompilerServices.CallSiteBinder binder, System.Type returnType, System.Linq.Expressions.Expression arg0, System.Linq.Expressions.Expression arg1, System.Linq.Expressions.Expression arg2, System.Linq.Expressions.Expression arg3) { return default(System.Linq.Expressions.DynamicExpression); }
    public static System.Linq.Expressions.DynamicExpression Dynamic(System.Runtime.CompilerServices.CallSiteBinder binder, System.Type returnType, params System.Linq.Expressions.Expression[] arguments) { return default(System.Linq.Expressions.DynamicExpression); }
    public static System.Linq.Expressions.ElementInit ElementInit(System.Reflection.MethodInfo addMethod, System.Collections.Generic.IEnumerable<System.Linq.Expressions.Expression> arguments) { return default(System.Linq.Expressions.ElementInit); }
    public static System.Linq.Expressions.ElementInit ElementInit(System.Reflection.MethodInfo addMethod, params System.Linq.Expressions.Expression[] arguments) { return default(System.Linq.Expressions.ElementInit); }
    public static System.Linq.Expressions.DefaultExpression Empty() { return default(System.Linq.Expressions.DefaultExpression); }
    public static System.Linq.Expressions.BinaryExpression Equal(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right) { return default(System.Linq.Expressions.BinaryExpression); }
    public static System.Linq.Expressions.BinaryExpression Equal(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right, bool liftToNull, System.Reflection.MethodInfo method) { return default(System.Linq.Expressions.BinaryExpression); }
    public static System.Linq.Expressions.BinaryExpression ExclusiveOr(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right) { return default(System.Linq.Expressions.BinaryExpression); }
    public static System.Linq.Expressions.BinaryExpression ExclusiveOr(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right, System.Reflection.MethodInfo method) { return default(System.Linq.Expressions.BinaryExpression); }
    public static System.Linq.Expressions.BinaryExpression ExclusiveOrAssign(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right) { return default(System.Linq.Expressions.BinaryExpression); }
    public static System.Linq.Expressions.BinaryExpression ExclusiveOrAssign(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right, System.Reflection.MethodInfo method) { return default(System.Linq.Expressions.BinaryExpression); }
    public static System.Linq.Expressions.BinaryExpression ExclusiveOrAssign(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right, System.Reflection.MethodInfo method, System.Linq.Expressions.LambdaExpression conversion) { return default(System.Linq.Expressions.BinaryExpression); }
    public static System.Linq.Expressions.MemberExpression Field(System.Linq.Expressions.Expression expression, System.Reflection.FieldInfo field) { return default(System.Linq.Expressions.MemberExpression); }
    public static System.Linq.Expressions.MemberExpression Field(System.Linq.Expressions.Expression expression, string fieldName) { return default(System.Linq.Expressions.MemberExpression); }
    public static System.Linq.Expressions.MemberExpression Field(System.Linq.Expressions.Expression expression, System.Type type, string fieldName) { return default(System.Linq.Expressions.MemberExpression); }
    public static System.Type GetActionType(params System.Type[] typeArgs) { return default(System.Type); }
    public static System.Type GetDelegateType(params System.Type[] typeArgs) { return default(System.Type); }
    public static System.Type GetFuncType(params System.Type[] typeArgs) { return default(System.Type); }
    public static System.Linq.Expressions.GotoExpression Goto(System.Linq.Expressions.LabelTarget target) { return default(System.Linq.Expressions.GotoExpression); }
    public static System.Linq.Expressions.GotoExpression Goto(System.Linq.Expressions.LabelTarget target, System.Linq.Expressions.Expression value) { return default(System.Linq.Expressions.GotoExpression); }
    public static System.Linq.Expressions.GotoExpression Goto(System.Linq.Expressions.LabelTarget target, System.Linq.Expressions.Expression value, System.Type type) { return default(System.Linq.Expressions.GotoExpression); }
    public static System.Linq.Expressions.GotoExpression Goto(System.Linq.Expressions.LabelTarget target, System.Type type) { return default(System.Linq.Expressions.GotoExpression); }
    public static System.Linq.Expressions.BinaryExpression GreaterThan(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right) { return default(System.Linq.Expressions.BinaryExpression); }
    public static System.Linq.Expressions.BinaryExpression GreaterThan(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right, bool liftToNull, System.Reflection.MethodInfo method) { return default(System.Linq.Expressions.BinaryExpression); }
    public static System.Linq.Expressions.BinaryExpression GreaterThanOrEqual(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right) { return default(System.Linq.Expressions.BinaryExpression); }
    public static System.Linq.Expressions.BinaryExpression GreaterThanOrEqual(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right, bool liftToNull, System.Reflection.MethodInfo method) { return default(System.Linq.Expressions.BinaryExpression); }
    public static System.Linq.Expressions.ConditionalExpression IfThen(System.Linq.Expressions.Expression test, System.Linq.Expressions.Expression ifTrue) { return default(System.Linq.Expressions.ConditionalExpression); }
    public static System.Linq.Expressions.ConditionalExpression IfThenElse(System.Linq.Expressions.Expression test, System.Linq.Expressions.Expression ifTrue, System.Linq.Expressions.Expression ifFalse) { return default(System.Linq.Expressions.ConditionalExpression); }
    public static System.Linq.Expressions.UnaryExpression Increment(System.Linq.Expressions.Expression expression) { return default(System.Linq.Expressions.UnaryExpression); }
    public static System.Linq.Expressions.UnaryExpression Increment(System.Linq.Expressions.Expression expression, System.Reflection.MethodInfo method) { return default(System.Linq.Expressions.UnaryExpression); }
    public static System.Linq.Expressions.InvocationExpression Invoke(System.Linq.Expressions.Expression expression, System.Collections.Generic.IEnumerable<System.Linq.Expressions.Expression> arguments) { return default(System.Linq.Expressions.InvocationExpression); }
    public static System.Linq.Expressions.InvocationExpression Invoke(System.Linq.Expressions.Expression expression, params System.Linq.Expressions.Expression[] arguments) { return default(System.Linq.Expressions.InvocationExpression); }
    public static System.Linq.Expressions.UnaryExpression IsFalse(System.Linq.Expressions.Expression expression) { return default(System.Linq.Expressions.UnaryExpression); }
    public static System.Linq.Expressions.UnaryExpression IsFalse(System.Linq.Expressions.Expression expression, System.Reflection.MethodInfo method) { return default(System.Linq.Expressions.UnaryExpression); }
    public static System.Linq.Expressions.UnaryExpression IsTrue(System.Linq.Expressions.Expression expression) { return default(System.Linq.Expressions.UnaryExpression); }
    public static System.Linq.Expressions.UnaryExpression IsTrue(System.Linq.Expressions.Expression expression, System.Reflection.MethodInfo method) { return default(System.Linq.Expressions.UnaryExpression); }
    public static System.Linq.Expressions.LabelTarget Label() { return default(System.Linq.Expressions.LabelTarget); }
    public static System.Linq.Expressions.LabelExpression Label(System.Linq.Expressions.LabelTarget target) { return default(System.Linq.Expressions.LabelExpression); }
    public static System.Linq.Expressions.LabelExpression Label(System.Linq.Expressions.LabelTarget target, System.Linq.Expressions.Expression defaultValue) { return default(System.Linq.Expressions.LabelExpression); }
    public static System.Linq.Expressions.LabelTarget Label(string name) { return default(System.Linq.Expressions.LabelTarget); }
    public static System.Linq.Expressions.LabelTarget Label(System.Type type) { return default(System.Linq.Expressions.LabelTarget); }
    public static System.Linq.Expressions.LabelTarget Label(System.Type type, string name) { return default(System.Linq.Expressions.LabelTarget); }
    public static System.Linq.Expressions.LambdaExpression Lambda(System.Linq.Expressions.Expression body, bool tailCall, System.Collections.Generic.IEnumerable<System.Linq.Expressions.ParameterExpression> parameters) { return default(System.Linq.Expressions.LambdaExpression); }
    public static System.Linq.Expressions.LambdaExpression Lambda(System.Linq.Expressions.Expression body, bool tailCall, params System.Linq.Expressions.ParameterExpression[] parameters) { return default(System.Linq.Expressions.LambdaExpression); }
    public static System.Linq.Expressions.LambdaExpression Lambda(System.Linq.Expressions.Expression body, System.Collections.Generic.IEnumerable<System.Linq.Expressions.ParameterExpression> parameters) { return default(System.Linq.Expressions.LambdaExpression); }
    public static System.Linq.Expressions.LambdaExpression Lambda(System.Linq.Expressions.Expression body, params System.Linq.Expressions.ParameterExpression[] parameters) { return default(System.Linq.Expressions.LambdaExpression); }
    public static System.Linq.Expressions.LambdaExpression Lambda(System.Linq.Expressions.Expression body, string name, bool tailCall, System.Collections.Generic.IEnumerable<System.Linq.Expressions.ParameterExpression> parameters) { return default(System.Linq.Expressions.LambdaExpression); }
    public static System.Linq.Expressions.LambdaExpression Lambda(System.Linq.Expressions.Expression body, string name, System.Collections.Generic.IEnumerable<System.Linq.Expressions.ParameterExpression> parameters) { return default(System.Linq.Expressions.LambdaExpression); }
    public static System.Linq.Expressions.LambdaExpression Lambda(System.Type delegateType, System.Linq.Expressions.Expression body, bool tailCall, System.Collections.Generic.IEnumerable<System.Linq.Expressions.ParameterExpression> parameters) { return default(System.Linq.Expressions.LambdaExpression); }
    public static System.Linq.Expressions.LambdaExpression Lambda(System.Type delegateType, System.Linq.Expressions.Expression body, bool tailCall, params System.Linq.Expressions.ParameterExpression[] parameters) { return default(System.Linq.Expressions.LambdaExpression); }
    public static System.Linq.Expressions.LambdaExpression Lambda(System.Type delegateType, System.Linq.Expressions.Expression body, System.Collections.Generic.IEnumerable<System.Linq.Expressions.ParameterExpression> parameters) { return default(System.Linq.Expressions.LambdaExpression); }
    public static System.Linq.Expressions.LambdaExpression Lambda(System.Type delegateType, System.Linq.Expressions.Expression body, params System.Linq.Expressions.ParameterExpression[] parameters) { return default(System.Linq.Expressions.LambdaExpression); }
    public static System.Linq.Expressions.LambdaExpression Lambda(System.Type delegateType, System.Linq.Expressions.Expression body, string name, bool tailCall, System.Collections.Generic.IEnumerable<System.Linq.Expressions.ParameterExpression> parameters) { return default(System.Linq.Expressions.LambdaExpression); }
    public static System.Linq.Expressions.LambdaExpression Lambda(System.Type delegateType, System.Linq.Expressions.Expression body, string name, System.Collections.Generic.IEnumerable<System.Linq.Expressions.ParameterExpression> parameters) { return default(System.Linq.Expressions.LambdaExpression); }
    public static System.Linq.Expressions.Expression<TDelegate> Lambda<TDelegate>(System.Linq.Expressions.Expression body, bool tailCall, System.Collections.Generic.IEnumerable<System.Linq.Expressions.ParameterExpression> parameters) { return default(System.Linq.Expressions.Expression<TDelegate>); }
    public static System.Linq.Expressions.Expression<TDelegate> Lambda<TDelegate>(System.Linq.Expressions.Expression body, bool tailCall, params System.Linq.Expressions.ParameterExpression[] parameters) { return default(System.Linq.Expressions.Expression<TDelegate>); }
    public static System.Linq.Expressions.Expression<TDelegate> Lambda<TDelegate>(System.Linq.Expressions.Expression body, System.Collections.Generic.IEnumerable<System.Linq.Expressions.ParameterExpression> parameters) { return default(System.Linq.Expressions.Expression<TDelegate>); }
    public static System.Linq.Expressions.Expression<TDelegate> Lambda<TDelegate>(System.Linq.Expressions.Expression body, params System.Linq.Expressions.ParameterExpression[] parameters) { return default(System.Linq.Expressions.Expression<TDelegate>); }
    public static System.Linq.Expressions.Expression<TDelegate> Lambda<TDelegate>(System.Linq.Expressions.Expression body, string name, bool tailCall, System.Collections.Generic.IEnumerable<System.Linq.Expressions.ParameterExpression> parameters) { return default(System.Linq.Expressions.Expression<TDelegate>); }
    public static System.Linq.Expressions.Expression<TDelegate> Lambda<TDelegate>(System.Linq.Expressions.Expression body, string name, System.Collections.Generic.IEnumerable<System.Linq.Expressions.ParameterExpression> parameters) { return default(System.Linq.Expressions.Expression<TDelegate>); }
    public static System.Linq.Expressions.BinaryExpression LeftShift(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right) { return default(System.Linq.Expressions.BinaryExpression); }
    public static System.Linq.Expressions.BinaryExpression LeftShift(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right, System.Reflection.MethodInfo method) { return default(System.Linq.Expressions.BinaryExpression); }
    public static System.Linq.Expressions.BinaryExpression LeftShiftAssign(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right) { return default(System.Linq.Expressions.BinaryExpression); }
    public static System.Linq.Expressions.BinaryExpression LeftShiftAssign(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right, System.Reflection.MethodInfo method) { return default(System.Linq.Expressions.BinaryExpression); }
    public static System.Linq.Expressions.BinaryExpression LeftShiftAssign(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right, System.Reflection.MethodInfo method, System.Linq.Expressions.LambdaExpression conversion) { return default(System.Linq.Expressions.BinaryExpression); }
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
    public static System.Linq.Expressions.LoopExpression Loop(System.Linq.Expressions.Expression body) { return default(System.Linq.Expressions.LoopExpression); }
    public static System.Linq.Expressions.LoopExpression Loop(System.Linq.Expressions.Expression body, System.Linq.Expressions.LabelTarget @break) { return default(System.Linq.Expressions.LoopExpression); }
    public static System.Linq.Expressions.LoopExpression Loop(System.Linq.Expressions.Expression body, System.Linq.Expressions.LabelTarget @break, System.Linq.Expressions.LabelTarget @continue) { return default(System.Linq.Expressions.LoopExpression); }
    public static System.Linq.Expressions.BinaryExpression MakeBinary(System.Linq.Expressions.ExpressionType binaryType, System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right) { return default(System.Linq.Expressions.BinaryExpression); }
    public static System.Linq.Expressions.BinaryExpression MakeBinary(System.Linq.Expressions.ExpressionType binaryType, System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right, bool liftToNull, System.Reflection.MethodInfo method) { return default(System.Linq.Expressions.BinaryExpression); }
    public static System.Linq.Expressions.BinaryExpression MakeBinary(System.Linq.Expressions.ExpressionType binaryType, System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right, bool liftToNull, System.Reflection.MethodInfo method, System.Linq.Expressions.LambdaExpression conversion) { return default(System.Linq.Expressions.BinaryExpression); }
    public static System.Linq.Expressions.CatchBlock MakeCatchBlock(System.Type type, System.Linq.Expressions.ParameterExpression variable, System.Linq.Expressions.Expression body, System.Linq.Expressions.Expression filter) { return default(System.Linq.Expressions.CatchBlock); }
    public static System.Linq.Expressions.DynamicExpression MakeDynamic(System.Type delegateType, System.Runtime.CompilerServices.CallSiteBinder binder, System.Collections.Generic.IEnumerable<System.Linq.Expressions.Expression> arguments) { return default(System.Linq.Expressions.DynamicExpression); }
    public static System.Linq.Expressions.DynamicExpression MakeDynamic(System.Type delegateType, System.Runtime.CompilerServices.CallSiteBinder binder, System.Linq.Expressions.Expression arg0) { return default(System.Linq.Expressions.DynamicExpression); }
    public static System.Linq.Expressions.DynamicExpression MakeDynamic(System.Type delegateType, System.Runtime.CompilerServices.CallSiteBinder binder, System.Linq.Expressions.Expression arg0, System.Linq.Expressions.Expression arg1) { return default(System.Linq.Expressions.DynamicExpression); }
    public static System.Linq.Expressions.DynamicExpression MakeDynamic(System.Type delegateType, System.Runtime.CompilerServices.CallSiteBinder binder, System.Linq.Expressions.Expression arg0, System.Linq.Expressions.Expression arg1, System.Linq.Expressions.Expression arg2) { return default(System.Linq.Expressions.DynamicExpression); }
    public static System.Linq.Expressions.DynamicExpression MakeDynamic(System.Type delegateType, System.Runtime.CompilerServices.CallSiteBinder binder, System.Linq.Expressions.Expression arg0, System.Linq.Expressions.Expression arg1, System.Linq.Expressions.Expression arg2, System.Linq.Expressions.Expression arg3) { return default(System.Linq.Expressions.DynamicExpression); }
    public static System.Linq.Expressions.DynamicExpression MakeDynamic(System.Type delegateType, System.Runtime.CompilerServices.CallSiteBinder binder, params System.Linq.Expressions.Expression[] arguments) { return default(System.Linq.Expressions.DynamicExpression); }
    public static System.Linq.Expressions.GotoExpression MakeGoto(System.Linq.Expressions.GotoExpressionKind kind, System.Linq.Expressions.LabelTarget target, System.Linq.Expressions.Expression value, System.Type type) { return default(System.Linq.Expressions.GotoExpression); }
    public static System.Linq.Expressions.IndexExpression MakeIndex(System.Linq.Expressions.Expression instance, System.Reflection.PropertyInfo indexer, System.Collections.Generic.IEnumerable<System.Linq.Expressions.Expression> arguments) { return default(System.Linq.Expressions.IndexExpression); }
    public static System.Linq.Expressions.MemberExpression MakeMemberAccess(System.Linq.Expressions.Expression expression, System.Reflection.MemberInfo member) { return default(System.Linq.Expressions.MemberExpression); }
    public static System.Linq.Expressions.TryExpression MakeTry(System.Type type, System.Linq.Expressions.Expression body, System.Linq.Expressions.Expression @finally, System.Linq.Expressions.Expression fault, System.Collections.Generic.IEnumerable<System.Linq.Expressions.CatchBlock> handlers) { return default(System.Linq.Expressions.TryExpression); }
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
    public static System.Linq.Expressions.BinaryExpression ModuloAssign(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right) { return default(System.Linq.Expressions.BinaryExpression); }
    public static System.Linq.Expressions.BinaryExpression ModuloAssign(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right, System.Reflection.MethodInfo method) { return default(System.Linq.Expressions.BinaryExpression); }
    public static System.Linq.Expressions.BinaryExpression ModuloAssign(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right, System.Reflection.MethodInfo method, System.Linq.Expressions.LambdaExpression conversion) { return default(System.Linq.Expressions.BinaryExpression); }
    public static System.Linq.Expressions.BinaryExpression Multiply(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right) { return default(System.Linq.Expressions.BinaryExpression); }
    public static System.Linq.Expressions.BinaryExpression Multiply(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right, System.Reflection.MethodInfo method) { return default(System.Linq.Expressions.BinaryExpression); }
    public static System.Linq.Expressions.BinaryExpression MultiplyAssign(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right) { return default(System.Linq.Expressions.BinaryExpression); }
    public static System.Linq.Expressions.BinaryExpression MultiplyAssign(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right, System.Reflection.MethodInfo method) { return default(System.Linq.Expressions.BinaryExpression); }
    public static System.Linq.Expressions.BinaryExpression MultiplyAssign(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right, System.Reflection.MethodInfo method, System.Linq.Expressions.LambdaExpression conversion) { return default(System.Linq.Expressions.BinaryExpression); }
    public static System.Linq.Expressions.BinaryExpression MultiplyAssignChecked(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right) { return default(System.Linq.Expressions.BinaryExpression); }
    public static System.Linq.Expressions.BinaryExpression MultiplyAssignChecked(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right, System.Reflection.MethodInfo method) { return default(System.Linq.Expressions.BinaryExpression); }
    public static System.Linq.Expressions.BinaryExpression MultiplyAssignChecked(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right, System.Reflection.MethodInfo method, System.Linq.Expressions.LambdaExpression conversion) { return default(System.Linq.Expressions.BinaryExpression); }
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
    public static System.Linq.Expressions.UnaryExpression OnesComplement(System.Linq.Expressions.Expression expression) { return default(System.Linq.Expressions.UnaryExpression); }
    public static System.Linq.Expressions.UnaryExpression OnesComplement(System.Linq.Expressions.Expression expression, System.Reflection.MethodInfo method) { return default(System.Linq.Expressions.UnaryExpression); }
    public static System.Linq.Expressions.BinaryExpression Or(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right) { return default(System.Linq.Expressions.BinaryExpression); }
    public static System.Linq.Expressions.BinaryExpression Or(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right, System.Reflection.MethodInfo method) { return default(System.Linq.Expressions.BinaryExpression); }
    public static System.Linq.Expressions.BinaryExpression OrAssign(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right) { return default(System.Linq.Expressions.BinaryExpression); }
    public static System.Linq.Expressions.BinaryExpression OrAssign(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right, System.Reflection.MethodInfo method) { return default(System.Linq.Expressions.BinaryExpression); }
    public static System.Linq.Expressions.BinaryExpression OrAssign(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right, System.Reflection.MethodInfo method, System.Linq.Expressions.LambdaExpression conversion) { return default(System.Linq.Expressions.BinaryExpression); }
    public static System.Linq.Expressions.BinaryExpression OrElse(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right) { return default(System.Linq.Expressions.BinaryExpression); }
    public static System.Linq.Expressions.BinaryExpression OrElse(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right, System.Reflection.MethodInfo method) { return default(System.Linq.Expressions.BinaryExpression); }
    public static System.Linq.Expressions.ParameterExpression Parameter(System.Type type) { return default(System.Linq.Expressions.ParameterExpression); }
    public static System.Linq.Expressions.ParameterExpression Parameter(System.Type type, string name) { return default(System.Linq.Expressions.ParameterExpression); }
    public static System.Linq.Expressions.UnaryExpression PostDecrementAssign(System.Linq.Expressions.Expression expression) { return default(System.Linq.Expressions.UnaryExpression); }
    public static System.Linq.Expressions.UnaryExpression PostDecrementAssign(System.Linq.Expressions.Expression expression, System.Reflection.MethodInfo method) { return default(System.Linq.Expressions.UnaryExpression); }
    public static System.Linq.Expressions.UnaryExpression PostIncrementAssign(System.Linq.Expressions.Expression expression) { return default(System.Linq.Expressions.UnaryExpression); }
    public static System.Linq.Expressions.UnaryExpression PostIncrementAssign(System.Linq.Expressions.Expression expression, System.Reflection.MethodInfo method) { return default(System.Linq.Expressions.UnaryExpression); }
    public static System.Linq.Expressions.BinaryExpression Power(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right) { return default(System.Linq.Expressions.BinaryExpression); }
    public static System.Linq.Expressions.BinaryExpression Power(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right, System.Reflection.MethodInfo method) { return default(System.Linq.Expressions.BinaryExpression); }
    public static System.Linq.Expressions.BinaryExpression PowerAssign(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right) { return default(System.Linq.Expressions.BinaryExpression); }
    public static System.Linq.Expressions.BinaryExpression PowerAssign(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right, System.Reflection.MethodInfo method) { return default(System.Linq.Expressions.BinaryExpression); }
    public static System.Linq.Expressions.BinaryExpression PowerAssign(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right, System.Reflection.MethodInfo method, System.Linq.Expressions.LambdaExpression conversion) { return default(System.Linq.Expressions.BinaryExpression); }
    public static System.Linq.Expressions.UnaryExpression PreDecrementAssign(System.Linq.Expressions.Expression expression) { return default(System.Linq.Expressions.UnaryExpression); }
    public static System.Linq.Expressions.UnaryExpression PreDecrementAssign(System.Linq.Expressions.Expression expression, System.Reflection.MethodInfo method) { return default(System.Linq.Expressions.UnaryExpression); }
    public static System.Linq.Expressions.UnaryExpression PreIncrementAssign(System.Linq.Expressions.Expression expression) { return default(System.Linq.Expressions.UnaryExpression); }
    public static System.Linq.Expressions.UnaryExpression PreIncrementAssign(System.Linq.Expressions.Expression expression, System.Reflection.MethodInfo method) { return default(System.Linq.Expressions.UnaryExpression); }
    public static System.Linq.Expressions.MemberExpression Property(System.Linq.Expressions.Expression expression, System.Reflection.MethodInfo propertyAccessor) { return default(System.Linq.Expressions.MemberExpression); }
    public static System.Linq.Expressions.MemberExpression Property(System.Linq.Expressions.Expression expression, System.Reflection.PropertyInfo property) { return default(System.Linq.Expressions.MemberExpression); }
    public static System.Linq.Expressions.IndexExpression Property(System.Linq.Expressions.Expression instance, System.Reflection.PropertyInfo indexer, System.Collections.Generic.IEnumerable<System.Linq.Expressions.Expression> arguments) { return default(System.Linq.Expressions.IndexExpression); }
    public static System.Linq.Expressions.IndexExpression Property(System.Linq.Expressions.Expression instance, System.Reflection.PropertyInfo indexer, params System.Linq.Expressions.Expression[] arguments) { return default(System.Linq.Expressions.IndexExpression); }
    public static System.Linq.Expressions.MemberExpression Property(System.Linq.Expressions.Expression expression, string propertyName) { return default(System.Linq.Expressions.MemberExpression); }
    public static System.Linq.Expressions.IndexExpression Property(System.Linq.Expressions.Expression instance, string propertyName, params System.Linq.Expressions.Expression[] arguments) { return default(System.Linq.Expressions.IndexExpression); }
    public static System.Linq.Expressions.MemberExpression Property(System.Linq.Expressions.Expression expression, System.Type type, string propertyName) { return default(System.Linq.Expressions.MemberExpression); }
    public static System.Linq.Expressions.MemberExpression PropertyOrField(System.Linq.Expressions.Expression expression, string propertyOrFieldName) { return default(System.Linq.Expressions.MemberExpression); }
    public static System.Linq.Expressions.UnaryExpression Quote(System.Linq.Expressions.Expression expression) { return default(System.Linq.Expressions.UnaryExpression); }
    public virtual System.Linq.Expressions.Expression Reduce() { return default(System.Linq.Expressions.Expression); }
    public System.Linq.Expressions.Expression ReduceAndCheck() { return default(System.Linq.Expressions.Expression); }
    public System.Linq.Expressions.Expression ReduceExtensions() { return default(System.Linq.Expressions.Expression); }
    public static System.Linq.Expressions.BinaryExpression ReferenceEqual(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right) { return default(System.Linq.Expressions.BinaryExpression); }
    public static System.Linq.Expressions.BinaryExpression ReferenceNotEqual(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right) { return default(System.Linq.Expressions.BinaryExpression); }
    public static System.Linq.Expressions.UnaryExpression Rethrow() { return default(System.Linq.Expressions.UnaryExpression); }
    public static System.Linq.Expressions.UnaryExpression Rethrow(System.Type type) { return default(System.Linq.Expressions.UnaryExpression); }
    public static System.Linq.Expressions.GotoExpression Return(System.Linq.Expressions.LabelTarget target) { return default(System.Linq.Expressions.GotoExpression); }
    public static System.Linq.Expressions.GotoExpression Return(System.Linq.Expressions.LabelTarget target, System.Linq.Expressions.Expression value) { return default(System.Linq.Expressions.GotoExpression); }
    public static System.Linq.Expressions.GotoExpression Return(System.Linq.Expressions.LabelTarget target, System.Linq.Expressions.Expression value, System.Type type) { return default(System.Linq.Expressions.GotoExpression); }
    public static System.Linq.Expressions.GotoExpression Return(System.Linq.Expressions.LabelTarget target, System.Type type) { return default(System.Linq.Expressions.GotoExpression); }
    public static System.Linq.Expressions.BinaryExpression RightShift(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right) { return default(System.Linq.Expressions.BinaryExpression); }
    public static System.Linq.Expressions.BinaryExpression RightShift(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right, System.Reflection.MethodInfo method) { return default(System.Linq.Expressions.BinaryExpression); }
    public static System.Linq.Expressions.BinaryExpression RightShiftAssign(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right) { return default(System.Linq.Expressions.BinaryExpression); }
    public static System.Linq.Expressions.BinaryExpression RightShiftAssign(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right, System.Reflection.MethodInfo method) { return default(System.Linq.Expressions.BinaryExpression); }
    public static System.Linq.Expressions.BinaryExpression RightShiftAssign(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right, System.Reflection.MethodInfo method, System.Linq.Expressions.LambdaExpression conversion) { return default(System.Linq.Expressions.BinaryExpression); }
    public static System.Linq.Expressions.RuntimeVariablesExpression RuntimeVariables(System.Collections.Generic.IEnumerable<System.Linq.Expressions.ParameterExpression> variables) { return default(System.Linq.Expressions.RuntimeVariablesExpression); }
    public static System.Linq.Expressions.RuntimeVariablesExpression RuntimeVariables(params System.Linq.Expressions.ParameterExpression[] variables) { return default(System.Linq.Expressions.RuntimeVariablesExpression); }
    public static System.Linq.Expressions.BinaryExpression Subtract(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right) { return default(System.Linq.Expressions.BinaryExpression); }
    public static System.Linq.Expressions.BinaryExpression Subtract(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right, System.Reflection.MethodInfo method) { return default(System.Linq.Expressions.BinaryExpression); }
    public static System.Linq.Expressions.BinaryExpression SubtractAssign(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right) { return default(System.Linq.Expressions.BinaryExpression); }
    public static System.Linq.Expressions.BinaryExpression SubtractAssign(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right, System.Reflection.MethodInfo method) { return default(System.Linq.Expressions.BinaryExpression); }
    public static System.Linq.Expressions.BinaryExpression SubtractAssign(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right, System.Reflection.MethodInfo method, System.Linq.Expressions.LambdaExpression conversion) { return default(System.Linq.Expressions.BinaryExpression); }
    public static System.Linq.Expressions.BinaryExpression SubtractAssignChecked(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right) { return default(System.Linq.Expressions.BinaryExpression); }
    public static System.Linq.Expressions.BinaryExpression SubtractAssignChecked(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right, System.Reflection.MethodInfo method) { return default(System.Linq.Expressions.BinaryExpression); }
    public static System.Linq.Expressions.BinaryExpression SubtractAssignChecked(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right, System.Reflection.MethodInfo method, System.Linq.Expressions.LambdaExpression conversion) { return default(System.Linq.Expressions.BinaryExpression); }
    public static System.Linq.Expressions.BinaryExpression SubtractChecked(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right) { return default(System.Linq.Expressions.BinaryExpression); }
    public static System.Linq.Expressions.BinaryExpression SubtractChecked(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right, System.Reflection.MethodInfo method) { return default(System.Linq.Expressions.BinaryExpression); }
    public static System.Linq.Expressions.SwitchExpression Switch(System.Linq.Expressions.Expression switchValue, System.Linq.Expressions.Expression defaultBody, params System.Linq.Expressions.SwitchCase[] cases) { return default(System.Linq.Expressions.SwitchExpression); }
    public static System.Linq.Expressions.SwitchExpression Switch(System.Linq.Expressions.Expression switchValue, System.Linq.Expressions.Expression defaultBody, System.Reflection.MethodInfo comparison, System.Collections.Generic.IEnumerable<System.Linq.Expressions.SwitchCase> cases) { return default(System.Linq.Expressions.SwitchExpression); }
    public static System.Linq.Expressions.SwitchExpression Switch(System.Linq.Expressions.Expression switchValue, System.Linq.Expressions.Expression defaultBody, System.Reflection.MethodInfo comparison, params System.Linq.Expressions.SwitchCase[] cases) { return default(System.Linq.Expressions.SwitchExpression); }
    public static System.Linq.Expressions.SwitchExpression Switch(System.Linq.Expressions.Expression switchValue, params System.Linq.Expressions.SwitchCase[] cases) { return default(System.Linq.Expressions.SwitchExpression); }
    public static System.Linq.Expressions.SwitchExpression Switch(System.Type type, System.Linq.Expressions.Expression switchValue, System.Linq.Expressions.Expression defaultBody, System.Reflection.MethodInfo comparison, System.Collections.Generic.IEnumerable<System.Linq.Expressions.SwitchCase> cases) { return default(System.Linq.Expressions.SwitchExpression); }
    public static System.Linq.Expressions.SwitchExpression Switch(System.Type type, System.Linq.Expressions.Expression switchValue, System.Linq.Expressions.Expression defaultBody, System.Reflection.MethodInfo comparison, params System.Linq.Expressions.SwitchCase[] cases) { return default(System.Linq.Expressions.SwitchExpression); }
    public static System.Linq.Expressions.SwitchCase SwitchCase(System.Linq.Expressions.Expression body, System.Collections.Generic.IEnumerable<System.Linq.Expressions.Expression> testValues) { return default(System.Linq.Expressions.SwitchCase); }
    public static System.Linq.Expressions.SwitchCase SwitchCase(System.Linq.Expressions.Expression body, params System.Linq.Expressions.Expression[] testValues) { return default(System.Linq.Expressions.SwitchCase); }
    public static System.Linq.Expressions.SymbolDocumentInfo SymbolDocument(string fileName) { return default(System.Linq.Expressions.SymbolDocumentInfo); }
    public static System.Linq.Expressions.SymbolDocumentInfo SymbolDocument(string fileName, System.Guid language) { return default(System.Linq.Expressions.SymbolDocumentInfo); }
    public static System.Linq.Expressions.SymbolDocumentInfo SymbolDocument(string fileName, System.Guid language, System.Guid languageVendor) { return default(System.Linq.Expressions.SymbolDocumentInfo); }
    public static System.Linq.Expressions.SymbolDocumentInfo SymbolDocument(string fileName, System.Guid language, System.Guid languageVendor, System.Guid documentType) { return default(System.Linq.Expressions.SymbolDocumentInfo); }
    public static System.Linq.Expressions.UnaryExpression Throw(System.Linq.Expressions.Expression value) { return default(System.Linq.Expressions.UnaryExpression); }
    public static System.Linq.Expressions.UnaryExpression Throw(System.Linq.Expressions.Expression value, System.Type type) { return default(System.Linq.Expressions.UnaryExpression); }
    public override string ToString() { return default(string); }
    public static System.Linq.Expressions.TryExpression TryCatch(System.Linq.Expressions.Expression body, params System.Linq.Expressions.CatchBlock[] handlers) { return default(System.Linq.Expressions.TryExpression); }
    public static System.Linq.Expressions.TryExpression TryCatchFinally(System.Linq.Expressions.Expression body, System.Linq.Expressions.Expression @finally, params System.Linq.Expressions.CatchBlock[] handlers) { return default(System.Linq.Expressions.TryExpression); }
    public static System.Linq.Expressions.TryExpression TryFault(System.Linq.Expressions.Expression body, System.Linq.Expressions.Expression fault) { return default(System.Linq.Expressions.TryExpression); }
    public static System.Linq.Expressions.TryExpression TryFinally(System.Linq.Expressions.Expression body, System.Linq.Expressions.Expression @finally) { return default(System.Linq.Expressions.TryExpression); }
    public static bool TryGetActionType(System.Type[] typeArgs, out System.Type actionType) { actionType = default(System.Type); return default(bool); }
    public static bool TryGetFuncType(System.Type[] typeArgs, out System.Type funcType) { funcType = default(System.Type); return default(bool); }
    public static System.Linq.Expressions.UnaryExpression TypeAs(System.Linq.Expressions.Expression expression, System.Type type) { return default(System.Linq.Expressions.UnaryExpression); }
    public static System.Linq.Expressions.TypeBinaryExpression TypeEqual(System.Linq.Expressions.Expression expression, System.Type type) { return default(System.Linq.Expressions.TypeBinaryExpression); }
    public static System.Linq.Expressions.TypeBinaryExpression TypeIs(System.Linq.Expressions.Expression expression, System.Type type) { return default(System.Linq.Expressions.TypeBinaryExpression); }
    public static System.Linq.Expressions.UnaryExpression UnaryPlus(System.Linq.Expressions.Expression expression) { return default(System.Linq.Expressions.UnaryExpression); }
    public static System.Linq.Expressions.UnaryExpression UnaryPlus(System.Linq.Expressions.Expression expression, System.Reflection.MethodInfo method) { return default(System.Linq.Expressions.UnaryExpression); }
    public static System.Linq.Expressions.UnaryExpression Unbox(System.Linq.Expressions.Expression expression, System.Type type) { return default(System.Linq.Expressions.UnaryExpression); }
    public static System.Linq.Expressions.ParameterExpression Variable(System.Type type) { return default(System.Linq.Expressions.ParameterExpression); }
    public static System.Linq.Expressions.ParameterExpression Variable(System.Type type, string name) { return default(System.Linq.Expressions.ParameterExpression); }
    protected internal virtual System.Linq.Expressions.Expression VisitChildren(System.Linq.Expressions.ExpressionVisitor visitor) { return default(System.Linq.Expressions.Expression); }
  }
  public sealed partial class Expression<TDelegate> : System.Linq.Expressions.LambdaExpression {
    internal Expression() { }
    protected internal override System.Linq.Expressions.Expression Accept(System.Linq.Expressions.ExpressionVisitor visitor) { return default(System.Linq.Expressions.Expression); }
    public new TDelegate Compile() { return default(TDelegate); }
    public new TDelegate Compile(System.Runtime.CompilerServices.DebugInfoGenerator debugInfoGenerator) { return default(TDelegate); }
    public System.Linq.Expressions.Expression<TDelegate> Update(System.Linq.Expressions.Expression body, System.Collections.Generic.IEnumerable<System.Linq.Expressions.ParameterExpression> parameters) { return default(System.Linq.Expressions.Expression<TDelegate>); }
  }
  public enum ExpressionType {
    Add = 0,
    AddAssign = 63,
    AddAssignChecked = 74,
    AddChecked = 1,
    And = 2,
    AndAlso = 3,
    AndAssign = 64,
    ArrayIndex = 5,
    ArrayLength = 4,
    Assign = 46,
    Block = 47,
    Call = 6,
    Coalesce = 7,
    Conditional = 8,
    Constant = 9,
    Convert = 10,
    ConvertChecked = 11,
    DebugInfo = 48,
    Decrement = 49,
    Default = 51,
    Divide = 12,
    DivideAssign = 65,
    Dynamic = 50,
    Equal = 13,
    ExclusiveOr = 14,
    ExclusiveOrAssign = 66,
    Extension = 52,
    Goto = 53,
    GreaterThan = 15,
    GreaterThanOrEqual = 16,
    Increment = 54,
    Index = 55,
    Invoke = 17,
    IsFalse = 84,
    IsTrue = 83,
    Label = 56,
    Lambda = 18,
    LeftShift = 19,
    LeftShiftAssign = 67,
    LessThan = 20,
    LessThanOrEqual = 21,
    ListInit = 22,
    Loop = 58,
    MemberAccess = 23,
    MemberInit = 24,
    Modulo = 25,
    ModuloAssign = 68,
    Multiply = 26,
    MultiplyAssign = 69,
    MultiplyAssignChecked = 75,
    MultiplyChecked = 27,
    Negate = 28,
    NegateChecked = 30,
    New = 31,
    NewArrayBounds = 33,
    NewArrayInit = 32,
    Not = 34,
    NotEqual = 35,
    OnesComplement = 82,
    Or = 36,
    OrAssign = 70,
    OrElse = 37,
    Parameter = 38,
    PostDecrementAssign = 80,
    PostIncrementAssign = 79,
    Power = 39,
    PowerAssign = 71,
    PreDecrementAssign = 78,
    PreIncrementAssign = 77,
    Quote = 40,
    RightShift = 41,
    RightShiftAssign = 72,
    RuntimeVariables = 57,
    Subtract = 42,
    SubtractAssign = 73,
    SubtractAssignChecked = 76,
    SubtractChecked = 43,
    Switch = 59,
    Throw = 60,
    Try = 61,
    TypeAs = 44,
    TypeEqual = 81,
    TypeIs = 45,
    UnaryPlus = 29,
    Unbox = 62,
  }
  public abstract partial class ExpressionVisitor {
    protected ExpressionVisitor() { }
    public System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.Expression> Visit(System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.Expression> nodes) { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.Expression>); }
    public virtual System.Linq.Expressions.Expression Visit(System.Linq.Expressions.Expression node) { return default(System.Linq.Expressions.Expression); }
    public static System.Collections.ObjectModel.ReadOnlyCollection<T> Visit<T>(System.Collections.ObjectModel.ReadOnlyCollection<T> nodes, System.Func<T, T> elementVisitor) { return default(System.Collections.ObjectModel.ReadOnlyCollection<T>); }
    public T VisitAndConvert<T>(T node, string callerName) where T : System.Linq.Expressions.Expression { return default(T); }
    public System.Collections.ObjectModel.ReadOnlyCollection<T> VisitAndConvert<T>(System.Collections.ObjectModel.ReadOnlyCollection<T> nodes, string callerName) where T : System.Linq.Expressions.Expression { return default(System.Collections.ObjectModel.ReadOnlyCollection<T>); }
    protected internal virtual System.Linq.Expressions.Expression VisitBinary(System.Linq.Expressions.BinaryExpression node) { return default(System.Linq.Expressions.Expression); }
    protected internal virtual System.Linq.Expressions.Expression VisitBlock(System.Linq.Expressions.BlockExpression node) { return default(System.Linq.Expressions.Expression); }
    protected virtual System.Linq.Expressions.CatchBlock VisitCatchBlock(System.Linq.Expressions.CatchBlock node) { return default(System.Linq.Expressions.CatchBlock); }
    protected internal virtual System.Linq.Expressions.Expression VisitConditional(System.Linq.Expressions.ConditionalExpression node) { return default(System.Linq.Expressions.Expression); }
    protected internal virtual System.Linq.Expressions.Expression VisitConstant(System.Linq.Expressions.ConstantExpression node) { return default(System.Linq.Expressions.Expression); }
    protected internal virtual System.Linq.Expressions.Expression VisitDebugInfo(System.Linq.Expressions.DebugInfoExpression node) { return default(System.Linq.Expressions.Expression); }
    protected internal virtual System.Linq.Expressions.Expression VisitDefault(System.Linq.Expressions.DefaultExpression node) { return default(System.Linq.Expressions.Expression); }
    protected internal virtual System.Linq.Expressions.Expression VisitDynamic(System.Linq.Expressions.DynamicExpression node) { return default(System.Linq.Expressions.Expression); }
    protected virtual System.Linq.Expressions.ElementInit VisitElementInit(System.Linq.Expressions.ElementInit node) { return default(System.Linq.Expressions.ElementInit); }
    protected internal virtual System.Linq.Expressions.Expression VisitExtension(System.Linq.Expressions.Expression node) { return default(System.Linq.Expressions.Expression); }
    protected internal virtual System.Linq.Expressions.Expression VisitGoto(System.Linq.Expressions.GotoExpression node) { return default(System.Linq.Expressions.Expression); }
    protected internal virtual System.Linq.Expressions.Expression VisitIndex(System.Linq.Expressions.IndexExpression node) { return default(System.Linq.Expressions.Expression); }
    protected internal virtual System.Linq.Expressions.Expression VisitInvocation(System.Linq.Expressions.InvocationExpression node) { return default(System.Linq.Expressions.Expression); }
    protected internal virtual System.Linq.Expressions.Expression VisitLabel(System.Linq.Expressions.LabelExpression node) { return default(System.Linq.Expressions.Expression); }
    protected virtual System.Linq.Expressions.LabelTarget VisitLabelTarget(System.Linq.Expressions.LabelTarget node) { return default(System.Linq.Expressions.LabelTarget); }
    protected internal virtual System.Linq.Expressions.Expression VisitLambda<T>(System.Linq.Expressions.Expression<T> node) { return default(System.Linq.Expressions.Expression); }
    protected internal virtual System.Linq.Expressions.Expression VisitListInit(System.Linq.Expressions.ListInitExpression node) { return default(System.Linq.Expressions.Expression); }
    protected internal virtual System.Linq.Expressions.Expression VisitLoop(System.Linq.Expressions.LoopExpression node) { return default(System.Linq.Expressions.Expression); }
    protected internal virtual System.Linq.Expressions.Expression VisitMember(System.Linq.Expressions.MemberExpression node) { return default(System.Linq.Expressions.Expression); }
    protected virtual System.Linq.Expressions.MemberAssignment VisitMemberAssignment(System.Linq.Expressions.MemberAssignment node) { return default(System.Linq.Expressions.MemberAssignment); }
    protected virtual System.Linq.Expressions.MemberBinding VisitMemberBinding(System.Linq.Expressions.MemberBinding node) { return default(System.Linq.Expressions.MemberBinding); }
    protected internal virtual System.Linq.Expressions.Expression VisitMemberInit(System.Linq.Expressions.MemberInitExpression node) { return default(System.Linq.Expressions.Expression); }
    protected virtual System.Linq.Expressions.MemberListBinding VisitMemberListBinding(System.Linq.Expressions.MemberListBinding node) { return default(System.Linq.Expressions.MemberListBinding); }
    protected virtual System.Linq.Expressions.MemberMemberBinding VisitMemberMemberBinding(System.Linq.Expressions.MemberMemberBinding node) { return default(System.Linq.Expressions.MemberMemberBinding); }
    protected internal virtual System.Linq.Expressions.Expression VisitMethodCall(System.Linq.Expressions.MethodCallExpression node) { return default(System.Linq.Expressions.Expression); }
    protected internal virtual System.Linq.Expressions.Expression VisitNew(System.Linq.Expressions.NewExpression node) { return default(System.Linq.Expressions.Expression); }
    protected internal virtual System.Linq.Expressions.Expression VisitNewArray(System.Linq.Expressions.NewArrayExpression node) { return default(System.Linq.Expressions.Expression); }
    protected internal virtual System.Linq.Expressions.Expression VisitParameter(System.Linq.Expressions.ParameterExpression node) { return default(System.Linq.Expressions.Expression); }
    protected internal virtual System.Linq.Expressions.Expression VisitRuntimeVariables(System.Linq.Expressions.RuntimeVariablesExpression node) { return default(System.Linq.Expressions.Expression); }
    protected internal virtual System.Linq.Expressions.Expression VisitSwitch(System.Linq.Expressions.SwitchExpression node) { return default(System.Linq.Expressions.Expression); }
    protected virtual System.Linq.Expressions.SwitchCase VisitSwitchCase(System.Linq.Expressions.SwitchCase node) { return default(System.Linq.Expressions.SwitchCase); }
    protected internal virtual System.Linq.Expressions.Expression VisitTry(System.Linq.Expressions.TryExpression node) { return default(System.Linq.Expressions.Expression); }
    protected internal virtual System.Linq.Expressions.Expression VisitTypeBinary(System.Linq.Expressions.TypeBinaryExpression node) { return default(System.Linq.Expressions.Expression); }
    protected internal virtual System.Linq.Expressions.Expression VisitUnary(System.Linq.Expressions.UnaryExpression node) { return default(System.Linq.Expressions.Expression); }
  }
  [System.Diagnostics.DebuggerTypeProxyAttribute(typeof(System.Linq.Expressions.Expression.GotoExpressionProxy))]
  public sealed partial class GotoExpression : System.Linq.Expressions.Expression {
    internal GotoExpression() { }
    public System.Linq.Expressions.GotoExpressionKind Kind { get { return default(System.Linq.Expressions.GotoExpressionKind); } }
    public sealed override System.Linq.Expressions.ExpressionType NodeType { get { return default(System.Linq.Expressions.ExpressionType); } }
    public System.Linq.Expressions.LabelTarget Target { get { return default(System.Linq.Expressions.LabelTarget); } }
    public sealed override System.Type Type { get { return default(System.Type); } }
    public System.Linq.Expressions.Expression Value { get { return default(System.Linq.Expressions.Expression); } }
    protected internal override System.Linq.Expressions.Expression Accept(System.Linq.Expressions.ExpressionVisitor visitor) { return default(System.Linq.Expressions.Expression); }
    public System.Linq.Expressions.GotoExpression Update(System.Linq.Expressions.LabelTarget target, System.Linq.Expressions.Expression value) { return default(System.Linq.Expressions.GotoExpression); }
  }
  public enum GotoExpressionKind {
    Break = 2,
    Continue = 3,
    Goto = 0,
    Return = 1,
  }
  [System.Diagnostics.DebuggerTypeProxyAttribute(typeof(System.Linq.Expressions.Expression.IndexExpressionProxy))]
  public sealed partial class IndexExpression : System.Linq.Expressions.Expression {
    internal IndexExpression() { }
    public System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.Expression> Arguments { get { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.Expression>); } }
    public System.Reflection.PropertyInfo Indexer { get { return default(System.Reflection.PropertyInfo); } }
    public sealed override System.Linq.Expressions.ExpressionType NodeType { get { return default(System.Linq.Expressions.ExpressionType); } }
    public System.Linq.Expressions.Expression Object { get { return default(System.Linq.Expressions.Expression); } }
    public sealed override System.Type Type { get { return default(System.Type); } }
    protected internal override System.Linq.Expressions.Expression Accept(System.Linq.Expressions.ExpressionVisitor visitor) { return default(System.Linq.Expressions.Expression); }
    public System.Linq.Expressions.IndexExpression Update(System.Linq.Expressions.Expression @object, System.Collections.Generic.IEnumerable<System.Linq.Expressions.Expression> arguments) { return default(System.Linq.Expressions.IndexExpression); }
  }
  [System.Diagnostics.DebuggerTypeProxyAttribute(typeof(System.Linq.Expressions.Expression.InvocationExpressionProxy))]
  public sealed partial class InvocationExpression : System.Linq.Expressions.Expression {
    internal InvocationExpression() { }
    public System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.Expression> Arguments { get { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.Expression>); } }
    public System.Linq.Expressions.Expression Expression { get { return default(System.Linq.Expressions.Expression); } }
    public sealed override System.Linq.Expressions.ExpressionType NodeType { get { return default(System.Linq.Expressions.ExpressionType); } }
    public sealed override System.Type Type { get { return default(System.Type); } }
    protected internal override System.Linq.Expressions.Expression Accept(System.Linq.Expressions.ExpressionVisitor visitor) { return default(System.Linq.Expressions.Expression); }
    public System.Linq.Expressions.InvocationExpression Update(System.Linq.Expressions.Expression expression, System.Collections.Generic.IEnumerable<System.Linq.Expressions.Expression> arguments) { return default(System.Linq.Expressions.InvocationExpression); }
  }
  [System.Diagnostics.DebuggerTypeProxyAttribute(typeof(System.Linq.Expressions.Expression.LabelExpressionProxy))]
  public sealed partial class LabelExpression : System.Linq.Expressions.Expression {
    internal LabelExpression() { }
    public System.Linq.Expressions.Expression DefaultValue { get { return default(System.Linq.Expressions.Expression); } }
    public sealed override System.Linq.Expressions.ExpressionType NodeType { get { return default(System.Linq.Expressions.ExpressionType); } }
    public System.Linq.Expressions.LabelTarget Target { get { return default(System.Linq.Expressions.LabelTarget); } }
    public sealed override System.Type Type { get { return default(System.Type); } }
    protected internal override System.Linq.Expressions.Expression Accept(System.Linq.Expressions.ExpressionVisitor visitor) { return default(System.Linq.Expressions.Expression); }
    public System.Linq.Expressions.LabelExpression Update(System.Linq.Expressions.LabelTarget target, System.Linq.Expressions.Expression defaultValue) { return default(System.Linq.Expressions.LabelExpression); }
  }
  public sealed partial class LabelTarget {
    internal LabelTarget() { }
    public string Name { get { return default(string); } }
    public System.Type Type { get { return default(System.Type); } }
    public override string ToString() { return default(string); }
  }
  [System.Diagnostics.DebuggerTypeProxyAttribute(typeof(System.Linq.Expressions.Expression.LambdaExpressionProxy))]
  public abstract partial class LambdaExpression : System.Linq.Expressions.Expression {
    internal LambdaExpression() { }
    public System.Linq.Expressions.Expression Body { get { return default(System.Linq.Expressions.Expression); } }
    public string Name { get { return default(string); } }
    public sealed override System.Linq.Expressions.ExpressionType NodeType { get { return default(System.Linq.Expressions.ExpressionType); } }
    public System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.ParameterExpression> Parameters { get { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.ParameterExpression>); } }
    public System.Type ReturnType { get { return default(System.Type); } }
    public bool TailCall { get { return default(bool); } }
    public sealed override System.Type Type { get { return default(System.Type); } }
    public System.Delegate Compile() { return default(System.Delegate); }
    public System.Delegate Compile(System.Runtime.CompilerServices.DebugInfoGenerator debugInfoGenerator) { return default(System.Delegate); }
    public void CompileToMethod(System.Reflection.Emit.MethodBuilder method) { }
    public void CompileToMethod(System.Reflection.Emit.MethodBuilder method, System.Runtime.CompilerServices.DebugInfoGenerator debugInfoGenerator) { }
  }
  [System.Diagnostics.DebuggerTypeProxyAttribute(typeof(System.Linq.Expressions.Expression.ListInitExpressionProxy))]
  public sealed partial class ListInitExpression : System.Linq.Expressions.Expression {
    internal ListInitExpression() { }
    public override bool CanReduce { get { return default(bool); } }
    public System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.ElementInit> Initializers { get { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.ElementInit>); } }
    public System.Linq.Expressions.NewExpression NewExpression { get { return default(System.Linq.Expressions.NewExpression); } }
    public sealed override System.Linq.Expressions.ExpressionType NodeType { get { return default(System.Linq.Expressions.ExpressionType); } }
    public sealed override System.Type Type { get { return default(System.Type); } }
    protected internal override System.Linq.Expressions.Expression Accept(System.Linq.Expressions.ExpressionVisitor visitor) { return default(System.Linq.Expressions.Expression); }
    public override System.Linq.Expressions.Expression Reduce() { return default(System.Linq.Expressions.Expression); }
    public System.Linq.Expressions.ListInitExpression Update(System.Linq.Expressions.NewExpression newExpression, System.Collections.Generic.IEnumerable<System.Linq.Expressions.ElementInit> initializers) { return default(System.Linq.Expressions.ListInitExpression); }
  }
  [System.Diagnostics.DebuggerTypeProxyAttribute(typeof(System.Linq.Expressions.Expression.LoopExpressionProxy))]
  public sealed partial class LoopExpression : System.Linq.Expressions.Expression {
    internal LoopExpression() { }
    public System.Linq.Expressions.Expression Body { get { return default(System.Linq.Expressions.Expression); } }
    public System.Linq.Expressions.LabelTarget BreakLabel { get { return default(System.Linq.Expressions.LabelTarget); } }
    public System.Linq.Expressions.LabelTarget ContinueLabel { get { return default(System.Linq.Expressions.LabelTarget); } }
    public sealed override System.Linq.Expressions.ExpressionType NodeType { get { return default(System.Linq.Expressions.ExpressionType); } }
    public sealed override System.Type Type { get { return default(System.Type); } }
    protected internal override System.Linq.Expressions.Expression Accept(System.Linq.Expressions.ExpressionVisitor visitor) { return default(System.Linq.Expressions.Expression); }
    public System.Linq.Expressions.LoopExpression Update(System.Linq.Expressions.LabelTarget breakLabel, System.Linq.Expressions.LabelTarget continueLabel, System.Linq.Expressions.Expression body) { return default(System.Linq.Expressions.LoopExpression); }
  }
  public sealed partial class MemberAssignment : System.Linq.Expressions.MemberBinding {
    internal MemberAssignment() : base (default(System.Linq.Expressions.MemberBindingType), default(System.Reflection.MemberInfo)) { }
    public System.Linq.Expressions.Expression Expression { get { return default(System.Linq.Expressions.Expression); } }
    public System.Linq.Expressions.MemberAssignment Update(System.Linq.Expressions.Expression expression) { return default(System.Linq.Expressions.MemberAssignment); }
  }
  public abstract partial class MemberBinding {
    [System.ObsoleteAttribute("Do not use this constructor. It will be removed in future releases.")]
    protected MemberBinding(System.Linq.Expressions.MemberBindingType type, System.Reflection.MemberInfo member) { }
    public System.Linq.Expressions.MemberBindingType BindingType { get { return default(System.Linq.Expressions.MemberBindingType); } }
    public System.Reflection.MemberInfo Member { get { return default(System.Reflection.MemberInfo); } }
    public override string ToString() { return default(string); }
  }
  public enum MemberBindingType {
    Assignment = 0,
    ListBinding = 2,
    MemberBinding = 1,
  }
  [System.Diagnostics.DebuggerTypeProxyAttribute(typeof(System.Linq.Expressions.Expression.MemberExpressionProxy))]
  public partial class MemberExpression : System.Linq.Expressions.Expression {
    internal MemberExpression() { }
    public System.Linq.Expressions.Expression Expression { get { return default(System.Linq.Expressions.Expression); } }
    public System.Reflection.MemberInfo Member { get { return default(System.Reflection.MemberInfo); } }
    public sealed override System.Linq.Expressions.ExpressionType NodeType { get { return default(System.Linq.Expressions.ExpressionType); } }
    protected internal override System.Linq.Expressions.Expression Accept(System.Linq.Expressions.ExpressionVisitor visitor) { return default(System.Linq.Expressions.Expression); }
    public System.Linq.Expressions.MemberExpression Update(System.Linq.Expressions.Expression expression) { return default(System.Linq.Expressions.MemberExpression); }
  }
  [System.Diagnostics.DebuggerTypeProxyAttribute(typeof(System.Linq.Expressions.Expression.MemberInitExpressionProxy))]
  public sealed partial class MemberInitExpression : System.Linq.Expressions.Expression {
    internal MemberInitExpression() { }
    public System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.MemberBinding> Bindings { get { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.MemberBinding>); } }
    public override bool CanReduce { get { return default(bool); } }
    public System.Linq.Expressions.NewExpression NewExpression { get { return default(System.Linq.Expressions.NewExpression); } }
    public sealed override System.Linq.Expressions.ExpressionType NodeType { get { return default(System.Linq.Expressions.ExpressionType); } }
    public sealed override System.Type Type { get { return default(System.Type); } }
    protected internal override System.Linq.Expressions.Expression Accept(System.Linq.Expressions.ExpressionVisitor visitor) { return default(System.Linq.Expressions.Expression); }
    public override System.Linq.Expressions.Expression Reduce() { return default(System.Linq.Expressions.Expression); }
    public System.Linq.Expressions.MemberInitExpression Update(System.Linq.Expressions.NewExpression newExpression, System.Collections.Generic.IEnumerable<System.Linq.Expressions.MemberBinding> bindings) { return default(System.Linq.Expressions.MemberInitExpression); }
  }
  public sealed partial class MemberListBinding : System.Linq.Expressions.MemberBinding {
    internal MemberListBinding() : base (default(System.Linq.Expressions.MemberBindingType), default(System.Reflection.MemberInfo)) { }
    public System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.ElementInit> Initializers { get { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.ElementInit>); } }
    public System.Linq.Expressions.MemberListBinding Update(System.Collections.Generic.IEnumerable<System.Linq.Expressions.ElementInit> initializers) { return default(System.Linq.Expressions.MemberListBinding); }
  }
  public sealed partial class MemberMemberBinding : System.Linq.Expressions.MemberBinding {
    internal MemberMemberBinding() : base (default(System.Linq.Expressions.MemberBindingType), default(System.Reflection.MemberInfo)) { }
    public System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.MemberBinding> Bindings { get { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.MemberBinding>); } }
    public System.Linq.Expressions.MemberMemberBinding Update(System.Collections.Generic.IEnumerable<System.Linq.Expressions.MemberBinding> bindings) { return default(System.Linq.Expressions.MemberMemberBinding); }
  }
  [System.Diagnostics.DebuggerTypeProxyAttribute(typeof(System.Linq.Expressions.Expression.MethodCallExpressionProxy))]
  public partial class MethodCallExpression : System.Linq.Expressions.Expression {
    internal MethodCallExpression() { }
    public System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.Expression> Arguments { get { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.Expression>); } }
    public System.Reflection.MethodInfo Method { get { return default(System.Reflection.MethodInfo); } }
    public sealed override System.Linq.Expressions.ExpressionType NodeType { get { return default(System.Linq.Expressions.ExpressionType); } }
    public System.Linq.Expressions.Expression Object { get { return default(System.Linq.Expressions.Expression); } }
    public sealed override System.Type Type { get { return default(System.Type); } }
    protected internal override System.Linq.Expressions.Expression Accept(System.Linq.Expressions.ExpressionVisitor visitor) { return default(System.Linq.Expressions.Expression); }
    public System.Linq.Expressions.MethodCallExpression Update(System.Linq.Expressions.Expression @object, System.Collections.Generic.IEnumerable<System.Linq.Expressions.Expression> arguments) { return default(System.Linq.Expressions.MethodCallExpression); }
  }
  [System.Diagnostics.DebuggerTypeProxyAttribute(typeof(System.Linq.Expressions.Expression.NewArrayExpressionProxy))]
  public partial class NewArrayExpression : System.Linq.Expressions.Expression {
    internal NewArrayExpression() { }
    public System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.Expression> Expressions { get { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.Expression>); } }
    public sealed override System.Type Type { get { return default(System.Type); } }
    protected internal override System.Linq.Expressions.Expression Accept(System.Linq.Expressions.ExpressionVisitor visitor) { return default(System.Linq.Expressions.Expression); }
    public System.Linq.Expressions.NewArrayExpression Update(System.Collections.Generic.IEnumerable<System.Linq.Expressions.Expression> expressions) { return default(System.Linq.Expressions.NewArrayExpression); }
  }
  [System.Diagnostics.DebuggerTypeProxyAttribute(typeof(System.Linq.Expressions.Expression.NewExpressionProxy))]
  public partial class NewExpression : System.Linq.Expressions.Expression {
    internal NewExpression() { }
    public System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.Expression> Arguments { get { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.Expression>); } }
    public System.Reflection.ConstructorInfo Constructor { get { return default(System.Reflection.ConstructorInfo); } }
    public System.Collections.ObjectModel.ReadOnlyCollection<System.Reflection.MemberInfo> Members { get { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.Reflection.MemberInfo>); } }
    public sealed override System.Linq.Expressions.ExpressionType NodeType { get { return default(System.Linq.Expressions.ExpressionType); } }
    public override System.Type Type { get { return default(System.Type); } }
    protected internal override System.Linq.Expressions.Expression Accept(System.Linq.Expressions.ExpressionVisitor visitor) { return default(System.Linq.Expressions.Expression); }
    public System.Linq.Expressions.NewExpression Update(System.Collections.Generic.IEnumerable<System.Linq.Expressions.Expression> arguments) { return default(System.Linq.Expressions.NewExpression); }
  }
  [System.Diagnostics.DebuggerTypeProxyAttribute(typeof(System.Linq.Expressions.Expression.ParameterExpressionProxy))]
  public partial class ParameterExpression : System.Linq.Expressions.Expression {
    internal ParameterExpression() { }
    public bool IsByRef { get { return default(bool); } }
    public string Name { get { return default(string); } }
    public sealed override System.Linq.Expressions.ExpressionType NodeType { get { return default(System.Linq.Expressions.ExpressionType); } }
    public override System.Type Type { get { return default(System.Type); } }
    protected internal override System.Linq.Expressions.Expression Accept(System.Linq.Expressions.ExpressionVisitor visitor) { return default(System.Linq.Expressions.Expression); }
  }
  [System.Diagnostics.DebuggerTypeProxyAttribute(typeof(System.Linq.Expressions.Expression.RuntimeVariablesExpressionProxy))]
  public sealed partial class RuntimeVariablesExpression : System.Linq.Expressions.Expression {
    internal RuntimeVariablesExpression() { }
    public sealed override System.Linq.Expressions.ExpressionType NodeType { get { return default(System.Linq.Expressions.ExpressionType); } }
    public sealed override System.Type Type { get { return default(System.Type); } }
    public System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.ParameterExpression> Variables { get { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.ParameterExpression>); } }
    protected internal override System.Linq.Expressions.Expression Accept(System.Linq.Expressions.ExpressionVisitor visitor) { return default(System.Linq.Expressions.Expression); }
    public System.Linq.Expressions.RuntimeVariablesExpression Update(System.Collections.Generic.IEnumerable<System.Linq.Expressions.ParameterExpression> variables) { return default(System.Linq.Expressions.RuntimeVariablesExpression); }
  }
  [System.Diagnostics.DebuggerTypeProxyAttribute(typeof(System.Linq.Expressions.Expression.SwitchCaseProxy))]
  public sealed partial class SwitchCase {
    internal SwitchCase() { }
    public System.Linq.Expressions.Expression Body { get { return default(System.Linq.Expressions.Expression); } }
    public System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.Expression> TestValues { get { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.Expression>); } }
    public override string ToString() { return default(string); }
    public System.Linq.Expressions.SwitchCase Update(System.Collections.Generic.IEnumerable<System.Linq.Expressions.Expression> testValues, System.Linq.Expressions.Expression body) { return default(System.Linq.Expressions.SwitchCase); }
  }
  [System.Diagnostics.DebuggerTypeProxyAttribute(typeof(System.Linq.Expressions.Expression.SwitchExpressionProxy))]
  public sealed partial class SwitchExpression : System.Linq.Expressions.Expression {
    internal SwitchExpression() { }
    public System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.SwitchCase> Cases { get { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.SwitchCase>); } }
    public System.Reflection.MethodInfo Comparison { get { return default(System.Reflection.MethodInfo); } }
    public System.Linq.Expressions.Expression DefaultBody { get { return default(System.Linq.Expressions.Expression); } }
    public sealed override System.Linq.Expressions.ExpressionType NodeType { get { return default(System.Linq.Expressions.ExpressionType); } }
    public System.Linq.Expressions.Expression SwitchValue { get { return default(System.Linq.Expressions.Expression); } }
    public sealed override System.Type Type { get { return default(System.Type); } }
    protected internal override System.Linq.Expressions.Expression Accept(System.Linq.Expressions.ExpressionVisitor visitor) { return default(System.Linq.Expressions.Expression); }
    public System.Linq.Expressions.SwitchExpression Update(System.Linq.Expressions.Expression switchValue, System.Collections.Generic.IEnumerable<System.Linq.Expressions.SwitchCase> cases, System.Linq.Expressions.Expression defaultBody) { return default(System.Linq.Expressions.SwitchExpression); }
  }
  public partial class SymbolDocumentInfo {
    internal SymbolDocumentInfo() { }
    public virtual System.Guid DocumentType { get { return default(System.Guid); } }
    public string FileName { get { return default(string); } }
    public virtual System.Guid Language { get { return default(System.Guid); } }
    public virtual System.Guid LanguageVendor { get { return default(System.Guid); } }
  }
  [System.Diagnostics.DebuggerTypeProxyAttribute(typeof(System.Linq.Expressions.Expression.TryExpressionProxy))]
  public sealed partial class TryExpression : System.Linq.Expressions.Expression {
    internal TryExpression() { }
    public System.Linq.Expressions.Expression Body { get { return default(System.Linq.Expressions.Expression); } }
    public System.Linq.Expressions.Expression Fault { get { return default(System.Linq.Expressions.Expression); } }
    public System.Linq.Expressions.Expression Finally { get { return default(System.Linq.Expressions.Expression); } }
    public System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.CatchBlock> Handlers { get { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.CatchBlock>); } }
    public sealed override System.Linq.Expressions.ExpressionType NodeType { get { return default(System.Linq.Expressions.ExpressionType); } }
    public sealed override System.Type Type { get { return default(System.Type); } }
    protected internal override System.Linq.Expressions.Expression Accept(System.Linq.Expressions.ExpressionVisitor visitor) { return default(System.Linq.Expressions.Expression); }
    public System.Linq.Expressions.TryExpression Update(System.Linq.Expressions.Expression body, System.Collections.Generic.IEnumerable<System.Linq.Expressions.CatchBlock> handlers, System.Linq.Expressions.Expression @finally, System.Linq.Expressions.Expression fault) { return default(System.Linq.Expressions.TryExpression); }
  }
  [System.Diagnostics.DebuggerTypeProxyAttribute(typeof(System.Linq.Expressions.Expression.TypeBinaryExpressionProxy))]
  public sealed partial class TypeBinaryExpression : System.Linq.Expressions.Expression {
    internal TypeBinaryExpression() { }
    public System.Linq.Expressions.Expression Expression { get { return default(System.Linq.Expressions.Expression); } }
    public sealed override System.Linq.Expressions.ExpressionType NodeType { get { return default(System.Linq.Expressions.ExpressionType); } }
    public sealed override System.Type Type { get { return default(System.Type); } }
    public System.Type TypeOperand { get { return default(System.Type); } }
    protected internal override System.Linq.Expressions.Expression Accept(System.Linq.Expressions.ExpressionVisitor visitor) { return default(System.Linq.Expressions.Expression); }
    public System.Linq.Expressions.TypeBinaryExpression Update(System.Linq.Expressions.Expression expression) { return default(System.Linq.Expressions.TypeBinaryExpression); }
  }
  [System.Diagnostics.DebuggerTypeProxyAttribute(typeof(System.Linq.Expressions.Expression.UnaryExpressionProxy))]
  public sealed partial class UnaryExpression : System.Linq.Expressions.Expression {
    internal UnaryExpression() { }
    public override bool CanReduce { get { return default(bool); } }
    public bool IsLifted { get { return default(bool); } }
    public bool IsLiftedToNull { get { return default(bool); } }
    public System.Reflection.MethodInfo Method { get { return default(System.Reflection.MethodInfo); } }
    public sealed override System.Linq.Expressions.ExpressionType NodeType { get { return default(System.Linq.Expressions.ExpressionType); } }
    public System.Linq.Expressions.Expression Operand { get { return default(System.Linq.Expressions.Expression); } }
    public sealed override System.Type Type { get { return default(System.Type); } }
    protected internal override System.Linq.Expressions.Expression Accept(System.Linq.Expressions.ExpressionVisitor visitor) { return default(System.Linq.Expressions.Expression); }
    public override System.Linq.Expressions.Expression Reduce() { return default(System.Linq.Expressions.Expression); }
    public System.Linq.Expressions.UnaryExpression Update(System.Linq.Expressions.Expression operand) { return default(System.Linq.Expressions.UnaryExpression); }
  }
}
namespace System.Runtime.CompilerServices {
  public partial class CallSite {
    internal CallSite() { }
    public System.Runtime.CompilerServices.CallSiteBinder Binder { get { return default(System.Runtime.CompilerServices.CallSiteBinder); } }
    public static System.Runtime.CompilerServices.CallSite Create(System.Type delegateType, System.Runtime.CompilerServices.CallSiteBinder binder) { return default(System.Runtime.CompilerServices.CallSite); }
  }
  public partial class CallSite<T> : System.Runtime.CompilerServices.CallSite where T : class {
    internal CallSite() { }
    public T Target;
    public T Update { get { return default(T); } }
    public static System.Runtime.CompilerServices.CallSite<T> Create(System.Runtime.CompilerServices.CallSiteBinder binder) { return default(System.Runtime.CompilerServices.CallSite<T>); }
  }
  public abstract partial class CallSiteBinder {
    protected CallSiteBinder() { }
    public static System.Linq.Expressions.LabelTarget UpdateLabel { get { return default(System.Linq.Expressions.LabelTarget); } }
    public abstract System.Linq.Expressions.Expression Bind(System.Object[] args, System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.ParameterExpression> parameters, System.Linq.Expressions.LabelTarget returnLabel);
    public virtual T BindDelegate<T>(System.Runtime.CompilerServices.CallSite<T> site, System.Object[] args) where T : class { return default(T); }
    protected void CacheTarget<T>(T target) where T : class { }
  }
  public static partial class CallSiteHelpers {
    public static bool IsInternalFrame(System.Reflection.MethodBase mb) { return default(bool); }
  }
  [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
  [System.Diagnostics.DebuggerStepThroughAttribute]
  public static partial class CallSiteOps {
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.ObsoleteAttribute("do not use this method", true)]
    public static void AddRule<T>(System.Runtime.CompilerServices.CallSite<T> site, T rule) where T : class { }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.ObsoleteAttribute("do not use this method", true)]
    public static T Bind<T>(System.Runtime.CompilerServices.CallSiteBinder binder, System.Runtime.CompilerServices.CallSite<T> site, System.Object[] args) where T : class { return default(T); }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.ObsoleteAttribute("do not use this method", true)]
    public static void ClearMatch(System.Runtime.CompilerServices.CallSite site) { }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.ObsoleteAttribute("do not use this method", true)]
    public static System.Runtime.CompilerServices.CallSite<T> CreateMatchmaker<T>(System.Runtime.CompilerServices.CallSite<T> site) where T : class { return default(System.Runtime.CompilerServices.CallSite<T>); }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.ObsoleteAttribute("do not use this method", true)]
    public static T[] GetCachedRules<T>(System.Runtime.CompilerServices.RuleCache<T> cache) where T : class { return default(T[]); }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.ObsoleteAttribute("do not use this method", true)]
    public static bool GetMatch(System.Runtime.CompilerServices.CallSite site) { return default(bool); }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.ObsoleteAttribute("do not use this method", true)]
    public static System.Runtime.CompilerServices.RuleCache<T> GetRuleCache<T>(System.Runtime.CompilerServices.CallSite<T> site) where T : class { return default(System.Runtime.CompilerServices.RuleCache<T>); }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.ObsoleteAttribute("do not use this method", true)]
    public static T[] GetRules<T>(System.Runtime.CompilerServices.CallSite<T> site) where T : class { return default(T[]); }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.ObsoleteAttribute("do not use this method", true)]
    public static void MoveRule<T>(System.Runtime.CompilerServices.RuleCache<T> cache, T rule, int i) where T : class { }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.ObsoleteAttribute("do not use this method", true)]
    public static bool SetNotMatched(System.Runtime.CompilerServices.CallSite site) { return default(bool); }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.ObsoleteAttribute("do not use this method", true)]
    public static void UpdateRules<T>(System.Runtime.CompilerServices.CallSite<T> @this, int matched) where T : class { }
  }
  [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
  [System.Diagnostics.DebuggerStepThroughAttribute]
  public sealed partial class Closure {
    public readonly System.Object[] Constants;
    public readonly System.Object[] Locals;
    public Closure(System.Object[] constants, System.Object[] locals) { }
  }
  public abstract partial class DebugInfoGenerator {
    protected DebugInfoGenerator() { }
    public static System.Runtime.CompilerServices.DebugInfoGenerator CreatePdbGenerator() { return default(System.Runtime.CompilerServices.DebugInfoGenerator); }
    public abstract void MarkSequencePoint(System.Linq.Expressions.LambdaExpression method, int ilOffset, System.Linq.Expressions.DebugInfoExpression sequencePoint);
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(10636))]
  public sealed partial class DynamicAttribute : System.Attribute {
    public DynamicAttribute() { }
    public DynamicAttribute(System.Boolean[] transformFlags) { }
    public System.Collections.Generic.IList<System.Boolean> TransformFlags { get { return default(System.Collections.Generic.IList<System.Boolean>); } }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(69))]
  public sealed partial class ExtensionAttribute : System.Attribute {
    public ExtensionAttribute() { }
  }
  public partial interface IRuntimeVariables {
    int Count { get; }
    object this[int index] { get; set; }
  }
  public partial interface IStrongBox {
    object Value { get; set; }
  }
  public sealed partial class ReadOnlyCollectionBuilder<T> : System.Collections.Generic.ICollection<T>, System.Collections.Generic.IEnumerable<T>, System.Collections.Generic.IList<T>, System.Collections.ICollection, System.Collections.IEnumerable, System.Collections.IList {
    public ReadOnlyCollectionBuilder() { }
    public ReadOnlyCollectionBuilder(System.Collections.Generic.IEnumerable<T> collection) { }
    public ReadOnlyCollectionBuilder(int capacity) { }
    public int Capacity { get { return default(int); } set { } }
    public int Count { get { return default(int); } }
    public T this[int index] { get { return default(T); } set { } }
    bool System.Collections.Generic.ICollection<T>.IsReadOnly { get { return default(bool); } }
    bool System.Collections.ICollection.IsSynchronized { get { return default(bool); } }
    object System.Collections.ICollection.SyncRoot { get { return default(object); } }
    bool System.Collections.IList.IsFixedSize { get { return default(bool); } }
    bool System.Collections.IList.IsReadOnly { get { return default(bool); } }
    object System.Collections.IList.this[int index] { get { return default(object); } set { } }
    public void Add(T item) { }
    public void Clear() { }
    public bool Contains(T item) { return default(bool); }
    public void CopyTo(T[] array, int arrayIndex) { }
    public System.Collections.Generic.IEnumerator<T> GetEnumerator() { return default(System.Collections.Generic.IEnumerator<T>); }
    public int IndexOf(T item) { return default(int); }
    public void Insert(int index, T item) { }
    public bool Remove(T item) { return default(bool); }
    public void RemoveAt(int index) { }
    public void Reverse() { }
    public void Reverse(int index, int count) { }
    void System.Collections.ICollection.CopyTo(System.Array array, int index) { }
    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { return default(System.Collections.IEnumerator); }
    int System.Collections.IList.Add(object value) { return default(int); }
    bool System.Collections.IList.Contains(object value) { return default(bool); }
    int System.Collections.IList.IndexOf(object value) { return default(int); }
    void System.Collections.IList.Insert(int index, object value) { }
    void System.Collections.IList.Remove(object value) { }
    public T[] ToArray() { return default(T[]); }
    public System.Collections.ObjectModel.ReadOnlyCollection<T> ToReadOnlyCollection() { return default(System.Collections.ObjectModel.ReadOnlyCollection<T>); }
  }
  [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
  [System.Diagnostics.DebuggerStepThroughAttribute]
  public partial class RuleCache<T> where T : class {
    internal RuleCache() { }
  }
  [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
  [System.Diagnostics.DebuggerStepThroughAttribute]
  public static partial class RuntimeOps {
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.ObsoleteAttribute("do not use this method", true)]
    public static System.Runtime.CompilerServices.IRuntimeVariables CreateRuntimeVariables() { return default(System.Runtime.CompilerServices.IRuntimeVariables); }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.ObsoleteAttribute("do not use this method", true)]
    public static System.Runtime.CompilerServices.IRuntimeVariables CreateRuntimeVariables(System.Object[] data, System.Int64[] indexes) { return default(System.Runtime.CompilerServices.IRuntimeVariables); }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.ObsoleteAttribute("do not use this method", true)]
    public static bool ExpandoCheckVersion(System.Dynamic.ExpandoObject expando, object version) { return default(bool); }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.ObsoleteAttribute("do not use this method", true)]
    public static void ExpandoPromoteClass(System.Dynamic.ExpandoObject expando, object oldClass, object newClass) { }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.ObsoleteAttribute("do not use this method", true)]
    public static bool ExpandoTryDeleteValue(System.Dynamic.ExpandoObject expando, object indexClass, int index, string name, bool ignoreCase) { return default(bool); }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.ObsoleteAttribute("do not use this method", true)]
    public static bool ExpandoTryGetValue(System.Dynamic.ExpandoObject expando, object indexClass, int index, string name, bool ignoreCase, out object value) { value = default(object); return default(bool); }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.ObsoleteAttribute("do not use this method", true)]
    public static object ExpandoTrySetValue(System.Dynamic.ExpandoObject expando, object indexClass, int index, object value, string name, bool ignoreCase) { return default(object); }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.ObsoleteAttribute("do not use this method", true)]
    public static System.Runtime.CompilerServices.IRuntimeVariables MergeRuntimeVariables(System.Runtime.CompilerServices.IRuntimeVariables first, System.Runtime.CompilerServices.IRuntimeVariables second, System.Int32[] indexes) { return default(System.Runtime.CompilerServices.IRuntimeVariables); }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.ObsoleteAttribute("do not use this method", true)]
    public static System.Linq.Expressions.Expression Quote(System.Linq.Expressions.Expression expression, object hoistedLocals, System.Object[] locals) { return default(System.Linq.Expressions.Expression); }
  }
  public partial class StrongBox<T> : System.Runtime.CompilerServices.IStrongBox {
    public T Value;
    public StrongBox() { }
    public StrongBox(T value) { }
    object System.Runtime.CompilerServices.IStrongBox.Value { get { return default(object); } set { } }
  }
}
namespace System.Security.Cryptography {
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
namespace System.Threading.Tasks {
  public static partial class TaskExtensions {
    public static System.Threading.Tasks.Task Unwrap(this System.Threading.Tasks.Task<System.Threading.Tasks.Task> task) { return default(System.Threading.Tasks.Task); }
    public static System.Threading.Tasks.Task<TResult> Unwrap<TResult>(this System.Threading.Tasks.Task<System.Threading.Tasks.Task<TResult>> task) { return default(System.Threading.Tasks.Task<TResult>); }
  }
}
