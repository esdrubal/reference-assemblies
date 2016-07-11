namespace DbLinq.Util {
  public abstract partial class BaseLock : System.IDisposable {
    protected System.Threading.ReaderWriterLockSlim _Locks;
    public BaseLock(System.Threading.ReaderWriterLockSlim locks) { }
    public abstract void Dispose();
  }
  public static partial class Locks {
    public static System.Threading.ReaderWriterLockSlim GetLockInstance() { return default(System.Threading.ReaderWriterLockSlim); }
    public static System.Threading.ReaderWriterLockSlim GetLockInstance(System.Threading.LockRecursionPolicy recursionPolicy) { return default(System.Threading.ReaderWriterLockSlim); }
    public static void GetReadLock(System.Threading.ReaderWriterLockSlim locks) { }
    public static void GetReadOnlyLock(System.Threading.ReaderWriterLockSlim locks) { }
    public static void GetWriteLock(System.Threading.ReaderWriterLockSlim locks) { }
    public static void ReleaseLock(System.Threading.ReaderWriterLockSlim locks) { }
    public static void ReleaseReadLock(System.Threading.ReaderWriterLockSlim locks) { }
    public static void ReleaseReadOnlyLock(System.Threading.ReaderWriterLockSlim locks) { }
    public static void ReleaseWriteLock(System.Threading.ReaderWriterLockSlim locks) { }
  }
  public partial class ReadLock : DbLinq.Util.BaseLock {
    public ReadLock(System.Threading.ReaderWriterLockSlim locks) : base (default(System.Threading.ReaderWriterLockSlim)) { }
    public override void Dispose() { }
  }
  public partial class ReadOnlyLock : DbLinq.Util.BaseLock {
    public ReadOnlyLock(System.Threading.ReaderWriterLockSlim locks) : base (default(System.Threading.ReaderWriterLockSlim)) { }
    public override void Dispose() { }
  }
  public partial class WriteLock : DbLinq.Util.BaseLock {
    public WriteLock(System.Threading.ReaderWriterLockSlim locks) : base (default(System.Threading.ReaderWriterLockSlim)) { }
    public override void Dispose() { }
  }
}
namespace System.Data.Linq {
  [System.Runtime.Serialization.DataContractAttribute]
  public sealed partial class Binary : System.IEquatable<System.Data.Linq.Binary> {
    public Binary(System.Byte[] value) { }
    public int Length { get { return default(int); } }
    public bool Equals(System.Data.Linq.Binary other) { return default(bool); }
    public override bool Equals(object obj) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public static bool operator ==(System.Data.Linq.Binary binary1, System.Data.Linq.Binary binary2) { return default(bool); }
    public static implicit operator System.Data.Linq.Binary (System.Byte[] value) { return default(System.Data.Linq.Binary); }
    public static bool operator !=(System.Data.Linq.Binary binary1, System.Data.Linq.Binary binary2) { return default(bool); }
    public System.Byte[] ToArray() { return default(System.Byte[]); }
    public override string ToString() { return default(string); }
  }
  public enum ChangeAction {
    Delete = 1,
    Insert = 2,
    None = 0,
    Update = 3,
  }
  public sealed partial class ChangeConflictCollection : System.Collections.Generic.ICollection<System.Data.Linq.ObjectChangeConflict>, System.Collections.Generic.IEnumerable<System.Data.Linq.ObjectChangeConflict>, System.Collections.ICollection, System.Collections.IEnumerable {
    internal ChangeConflictCollection() { }
    [System.MonoTODOAttribute]
    public int Count { get { return default(int); } }
    [System.MonoTODOAttribute]
    public System.Data.Linq.ObjectChangeConflict this[int index] { get { return default(System.Data.Linq.ObjectChangeConflict); } }
    [System.MonoTODOAttribute]
    bool System.Collections.Generic.ICollection<System.Data.Linq.ObjectChangeConflict>.IsReadOnly { get { return default(bool); } }
    [System.MonoTODOAttribute]
    bool System.Collections.ICollection.IsSynchronized { get { return default(bool); } }
    [System.MonoTODOAttribute]
    object System.Collections.ICollection.SyncRoot { get { return default(object); } }
    [System.MonoTODOAttribute]
    public void Clear() { }
    [System.MonoTODOAttribute]
    public bool Contains(System.Data.Linq.ObjectChangeConflict item) { return default(bool); }
    [System.MonoTODOAttribute]
    public void CopyTo(System.Data.Linq.ObjectChangeConflict[] array, int arrayIndex) { }
    [System.MonoTODOAttribute]
    public System.Collections.Generic.IEnumerator<System.Data.Linq.ObjectChangeConflict> GetEnumerator() { return default(System.Collections.Generic.IEnumerator<System.Data.Linq.ObjectChangeConflict>); }
    [System.MonoTODOAttribute]
    public bool Remove(System.Data.Linq.ObjectChangeConflict item) { return default(bool); }
    [System.MonoTODOAttribute]
    public void ResolveAll(System.Data.Linq.RefreshMode mode) { }
    [System.MonoTODOAttribute]
    public void ResolveAll(System.Data.Linq.RefreshMode mode, bool autoResolveDeletes) { }
    [System.MonoTODOAttribute]
    void System.Collections.Generic.ICollection<System.Data.Linq.ObjectChangeConflict>.Add(System.Data.Linq.ObjectChangeConflict item) { }
    [System.MonoTODOAttribute]
    void System.Collections.ICollection.CopyTo(System.Array array, int index) { }
    [System.MonoTODOAttribute]
    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { return default(System.Collections.IEnumerator); }
  }
  public partial class ChangeConflictException : System.Exception {
    public ChangeConflictException() { }
    public ChangeConflictException(string message) { }
    public ChangeConflictException(string message, System.Exception innerException) { }
  }
  public sealed partial class ChangeSet {
    internal ChangeSet() { }
    public System.Collections.Generic.IList<System.Object> Deletes { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Collections.Generic.IList<System.Object>); } }
    public System.Collections.Generic.IList<System.Object> Inserts { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Collections.Generic.IList<System.Object>); } }
    public System.Collections.Generic.IList<System.Object> Updates { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Collections.Generic.IList<System.Object>); } }
    public override string ToString() { return default(string); }
  }
  public sealed partial class CompiledQuery {
    internal CompiledQuery() { }
    [System.MonoTODOAttribute]
    public System.Linq.Expressions.LambdaExpression Expression { get { return default(System.Linq.Expressions.LambdaExpression); } }
    [System.MonoTODOAttribute]
    public static System.Func<TArg0, TResult> Compile<TArg0, TResult>(System.Linq.Expressions.Expression<System.Func<TArg0, TResult>> query) where TArg0 : System.Data.Linq.DataContext { return default(System.Func<TArg0, TResult>); }
    [System.MonoTODOAttribute]
    public static System.Func<TArg0, TArg1, TResult> Compile<TArg0, TArg1, TResult>(System.Linq.Expressions.Expression<System.Func<TArg0, TArg1, TResult>> query) where TArg0 : System.Data.Linq.DataContext { return default(System.Func<TArg0, TArg1, TResult>); }
    [System.MonoTODOAttribute]
    public static System.Func<TArg0, TArg1, TArg2, TResult> Compile<TArg0, TArg1, TArg2, TResult>(System.Linq.Expressions.Expression<System.Func<TArg0, TArg1, TArg2, TResult>> query) where TArg0 : System.Data.Linq.DataContext { return default(System.Func<TArg0, TArg1, TArg2, TResult>); }
    [System.MonoTODOAttribute]
    public static System.Func<TArg0, TArg1, TArg2, TArg3, TResult> Compile<TArg0, TArg1, TArg2, TArg3, TResult>(System.Linq.Expressions.Expression<System.Func<TArg0, TArg1, TArg2, TArg3, TResult>> query) where TArg0 : System.Data.Linq.DataContext { return default(System.Func<TArg0, TArg1, TArg2, TArg3, TResult>); }
  }
  public enum ConflictMode {
    ContinueOnConflict = 1,
    FailOnFirstConflict = 0,
  }
  public partial class DataContext : System.IDisposable {
    public DataContext(System.Data.IDbConnection connection) { }
    public DataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mapping) { }
    [DbLinq.DbLinqToDoAttribute]
    public DataContext(string connectionString) { }
    [DbLinq.DbLinqToDoAttribute]
    public DataContext(string fileOrServerOrConnection, System.Data.Linq.Mapping.MappingSource mapping) { }
    [DbLinq.DbLinqToDoAttribute]
    public System.Data.Linq.ChangeConflictCollection ChangeConflicts { get { return default(System.Data.Linq.ChangeConflictCollection); } }
    [DbLinq.DbLinqToDoAttribute]
    public int CommandTimeout { get { return default(int); } set { } }
    public System.Data.Common.DbConnection Connection { get { return default(System.Data.Common.DbConnection); } }
    public bool DeferredLoadingEnabled { get { return default(bool); } set { } }
    [DbLinq.DbLinqToDoAttribute]
    public System.Data.Linq.DataLoadOptions LoadOptions { get { return default(System.Data.Linq.DataLoadOptions); } set { } }
    public System.IO.TextWriter Log { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.IO.TextWriter); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Data.Linq.Mapping.MetaModel Mapping { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Data.Linq.Mapping.MetaModel); } }
    public bool ObjectTrackingEnabled { get { return default(bool); } set { } }
    [System.Data.Linq.DBLinqExtendedAttribute]
    public bool QueryCacheEnabled { get { return default(bool); } set { } }
    public System.Data.Common.DbTransaction Transaction { get { return default(System.Data.Common.DbTransaction); } set { } }
    [DbLinq.DbLinqToDoAttribute]
    public void CreateDatabase() { }
    [DbLinq.DbLinqToDoAttribute]
    protected internal System.Linq.IQueryable<TResult> CreateMethodCallQuery<TResult>(object instance, System.Reflection.MethodInfo methodInfo, params System.Object[] parameters) { return default(System.Linq.IQueryable<TResult>); }
    public bool DatabaseExists() { return default(bool); }
    [DbLinq.DbLinqToDoAttribute]
    public void DeleteDatabase() { }
    public void Dispose() { }
    [DbLinq.DbLinqToDoAttribute]
    protected virtual void Dispose(bool disposing) { }
    public int ExecuteCommand(string command, params System.Object[] parameters) { return default(int); }
    [DbLinq.DbLinqToDoAttribute]
    protected internal void ExecuteDynamicDelete(object entity) { }
    [DbLinq.DbLinqToDoAttribute]
    protected internal void ExecuteDynamicInsert(object entity) { }
    [DbLinq.DbLinqToDoAttribute]
    protected internal void ExecuteDynamicUpdate(object entity) { }
    [DbLinq.DbLinqToDoAttribute]
    protected System.Data.Linq.IExecuteResult ExecuteMethodCall(object instance, System.Reflection.MethodInfo methodInfo, params System.Object[] parameters) { return default(System.Data.Linq.IExecuteResult); }
    public System.Collections.IEnumerable ExecuteQuery(System.Type elementType, string query, params System.Object[] parameters) { return default(System.Collections.IEnumerable); }
    public System.Collections.Generic.IEnumerable<TResult> ExecuteQuery<TResult>(string query, params System.Object[] parameters) where TResult : new() { return default(System.Collections.Generic.IEnumerable<TResult>); }
    public System.Data.Linq.ChangeSet GetChangeSet() { return default(System.Data.Linq.ChangeSet); }
    [DbLinq.DbLinqToDoAttribute]
    public System.Data.Common.DbCommand GetCommand(System.Linq.IQueryable query) { return default(System.Data.Common.DbCommand); }
    [System.Data.Linq.DBLinqExtendedAttribute]
    public System.Data.IDbCommand GetIDbCommand(System.Linq.IQueryable query) { return default(System.Data.IDbCommand); }
    public System.Data.Linq.ITable GetTable(System.Type type) { return default(System.Data.Linq.ITable); }
    public System.Data.Linq.Table<TEntity> GetTable<TEntity>() where TEntity : class { return default(System.Data.Linq.Table<TEntity>); }
    [DbLinq.DbLinqToDoAttribute]
    public void Refresh(System.Data.Linq.RefreshMode mode, System.Collections.IEnumerable entities) { }
    [DbLinq.DbLinqToDoAttribute]
    public void Refresh(System.Data.Linq.RefreshMode mode, object entity) { }
    [DbLinq.DbLinqToDoAttribute]
    public void Refresh(System.Data.Linq.RefreshMode mode, params System.Object[] entities) { }
    public void SubmitChanges() { }
    public virtual void SubmitChanges(System.Data.Linq.ConflictMode failureMode) { }
    public System.Data.Linq.IMultipleResults Translate(System.Data.Common.DbDataReader reader) { return default(System.Data.Linq.IMultipleResults); }
    public System.Collections.IEnumerable Translate(System.Type elementType, System.Data.Common.DbDataReader reader) { return default(System.Collections.IEnumerable); }
    public System.Collections.Generic.IEnumerable<TResult> Translate<TResult>(System.Data.Common.DbDataReader reader) { return default(System.Collections.Generic.IEnumerable<TResult>); }
  }
  public sealed partial class DataLoadOptions {
    public DataLoadOptions() { }
    public void AssociateWith(System.Linq.Expressions.LambdaExpression expression) { }
    public void AssociateWith<T>(System.Linq.Expressions.Expression<System.Func<T, System.Object>> expression) { }
    public bool GetAssociationCriteria(System.Reflection.MemberInfo memberInfo, out System.Linq.Expressions.LambdaExpression associationCriteria) { associationCriteria = default(System.Linq.Expressions.LambdaExpression); return default(bool); }
    public bool IsImmediate(System.Reflection.MemberInfo memberInfo) { return default(bool); }
    public void LoadWith(System.Linq.Expressions.LambdaExpression expression) { }
    public void LoadWith<T>(System.Linq.Expressions.Expression<System.Func<T, System.Object>> expression) { }
  }
  public static partial class DBConvert {
    [System.MonoTODOAttribute]
    public static object ChangeType(object value, System.Type type) { return default(object); }
    [System.MonoTODOAttribute]
    public static T ChangeType<T>(object value) { return default(T); }
  }
  public partial class DuplicateKeyException : System.InvalidOperationException {
    public DuplicateKeyException(object duplicate) { }
    public DuplicateKeyException(object duplicate, string message) { }
    public DuplicateKeyException(object duplicate, string message, System.Exception innerException) { }
    public object Object { get { return default(object); } }
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct EntityRef<TEntity> where TEntity : class {
    public EntityRef(TEntity entity) { throw new System.NotImplementedException(); }
    public EntityRef(System.Collections.Generic.IEnumerable<TEntity> source) { throw new System.NotImplementedException(); }
    public EntityRef(System.Data.Linq.EntityRef<TEntity> entityRef) { throw new System.NotImplementedException(); }
    public TEntity Entity { get { return default(TEntity); } set { } }
    public bool HasLoadedOrAssignedValue { get { return default(bool); } }
  }
  public sealed partial class EntitySet<TEntity> : System.Collections.Generic.ICollection<TEntity>, System.Collections.Generic.IEnumerable<TEntity>, System.Collections.Generic.IList<TEntity>, System.Collections.ICollection, System.Collections.IEnumerable, System.Collections.IList, System.ComponentModel.IListSource where TEntity : class {
    public EntitySet() { }
    [DbLinq.DbLinqToDoAttribute]
    public EntitySet(System.Action<TEntity> onAdd, System.Action<TEntity> onRemove) { }
    public int Count { get { return default(int); } }
    public bool HasAssignedValues { get { return default(bool); } }
    public bool HasLoadedOrAssignedValues { get { return default(bool); } }
    public bool HasLoadedValues { get { return default(bool); } }
    public bool IsDeferred { get { return default(bool); } }
    public TEntity this[int index] { get { return default(TEntity); } set { } }
    bool System.Collections.Generic.ICollection<TEntity>.IsReadOnly { get { return default(bool); } }
    int System.Collections.ICollection.Count { get { return default(int); } }
    [DbLinq.DbLinqToDoAttribute]
    bool System.Collections.ICollection.IsSynchronized { get { return default(bool); } }
    [DbLinq.DbLinqToDoAttribute]
    object System.Collections.ICollection.SyncRoot { get { return default(object); } }
    bool System.Collections.IList.IsFixedSize { get { return default(bool); } }
    bool System.Collections.IList.IsReadOnly { get { return default(bool); } }
    object System.Collections.IList.this[int index] { get { return default(object); } set { } }
    [DbLinq.DbLinqToDoAttribute]
    bool System.ComponentModel.IListSource.ContainsListCollection { get { return default(bool); } }
    public event System.ComponentModel.ListChangedEventHandler ListChanged { add { } remove { } }
    public void Add(TEntity entity) { }
    public void AddRange(System.Collections.Generic.IEnumerable<TEntity> collection) { }
    public void Assign(System.Collections.Generic.IEnumerable<TEntity> entitySource) { }
    public void Clear() { }
    [DbLinq.DbLinqToDoAttribute]
    public bool Contains(TEntity entity) { return default(bool); }
    public void CopyTo(TEntity[] array, int arrayIndex) { }
    public System.Collections.Generic.IEnumerator<TEntity> GetEnumerator() { return default(System.Collections.Generic.IEnumerator<TEntity>); }
    public System.ComponentModel.IBindingList GetNewBindingList() { return default(System.ComponentModel.IBindingList); }
    public int IndexOf(TEntity entity) { return default(int); }
    public void Insert(int index, TEntity entity) { }
    public void Load() { }
    public bool Remove(TEntity entity) { return default(bool); }
    public void RemoveAt(int index) { }
    public void SetSource(System.Collections.Generic.IEnumerable<TEntity> entitySource) { }
    void System.Collections.ICollection.CopyTo(System.Array array, int index) { }
    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { return default(System.Collections.IEnumerator); }
    int System.Collections.IList.Add(object value) { return default(int); }
    void System.Collections.IList.Clear() { }
    bool System.Collections.IList.Contains(object value) { return default(bool); }
    int System.Collections.IList.IndexOf(object value) { return default(int); }
    void System.Collections.IList.Insert(int index, object value) { }
    void System.Collections.IList.Remove(object value) { }
    void System.Collections.IList.RemoveAt(int index) { }
    System.Collections.IList System.ComponentModel.IListSource.GetList() { return default(System.Collections.IList); }
  }
  public partial class ForeignKeyReferenceAlreadyHasValueException : System.InvalidOperationException {
    public ForeignKeyReferenceAlreadyHasValueException() { }
    public ForeignKeyReferenceAlreadyHasValueException(string message) { }
    public ForeignKeyReferenceAlreadyHasValueException(string message, System.Exception innerException) { }
  }
  public partial interface IExecuteResult : System.IDisposable {
    object ReturnValue { get; }
    object GetParameterValue(int parameterIndex);
  }
  public partial interface IFunctionResult {
    object ReturnValue { get; }
  }
  public partial interface IMultipleResults : System.Data.Linq.IFunctionResult, System.IDisposable {
    System.Collections.Generic.IEnumerable<TElement> GetResult<TElement>();
  }
  public partial interface ISingleResult<T> : System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable, System.Data.Linq.IFunctionResult, System.IDisposable {
  }
  public partial interface ITable : System.Collections.IEnumerable, System.Linq.IQueryable {
    System.Data.Linq.DataContext Context { get; }
    bool IsReadOnly { get; }
    void Attach(object entity);
    void Attach(object entity, bool asModified);
    void Attach(object entity, object original);
    void AttachAll(System.Collections.IEnumerable entities);
    void AttachAll(System.Collections.IEnumerable entities, bool asModified);
    void DeleteAllOnSubmit(System.Collections.IEnumerable entities);
    void DeleteOnSubmit(object entity);
    System.Data.Linq.ModifiedMemberInfo[] GetModifiedMembers(object entity);
    object GetOriginalEntityState(object entity);
    void InsertAllOnSubmit(System.Collections.IEnumerable entities);
    void InsertOnSubmit(object entity);
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential, Size=1)]
  public partial struct Link<T> {
    [System.MonoTODOAttribute]
    public Link(T value) { throw new System.NotImplementedException(); }
    [System.MonoTODOAttribute]
    public Link(System.Collections.Generic.IEnumerable<T> source) { throw new System.NotImplementedException(); }
    [System.MonoTODOAttribute]
    public Link(System.Data.Linq.Link<T> link) { throw new System.NotImplementedException(); }
    [System.MonoTODOAttribute]
    public bool HasLoadedOrAssignedValue { get { return default(bool); } }
    [System.MonoTODOAttribute]
    public bool HasValue { get { return default(bool); } }
    [System.MonoTODOAttribute]
    public T Value { get { return default(T); } set { } }
  }
  public sealed partial class MemberChangeConflict {
    internal MemberChangeConflict() { }
    [System.MonoTODOAttribute]
    public object CurrentValue { get { return default(object); } }
    [System.MonoTODOAttribute]
    public object DatabaseValue { get { return default(object); } }
    [System.MonoTODOAttribute]
    public bool IsModified { get { return default(bool); } }
    [System.MonoTODOAttribute]
    public bool IsResolved { get { return default(bool); } }
    [System.MonoTODOAttribute]
    public System.Reflection.MemberInfo Member { get { return default(System.Reflection.MemberInfo); } }
    [System.MonoTODOAttribute]
    public object OriginalValue { get { return default(object); } }
    [System.MonoTODOAttribute]
    public void Resolve(System.Data.Linq.RefreshMode refreshMode) { }
    [System.MonoTODOAttribute]
    public void Resolve(object value) { }
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential, Size=1)]
  public partial struct ModifiedMemberInfo {
    [System.MonoTODOAttribute]
    public object CurrentValue { get { return default(object); } }
    [System.MonoTODOAttribute]
    public System.Reflection.MemberInfo Member { get { return default(System.Reflection.MemberInfo); } }
    [System.MonoTODOAttribute]
    public object OriginalValue { get { return default(object); } }
  }
  public sealed partial class ObjectChangeConflict {
    internal ObjectChangeConflict() { }
    [System.MonoTODOAttribute]
    public bool IsDeleted { get { return default(bool); } }
    [System.MonoTODOAttribute]
    public bool IsResolved { get { return default(bool); } }
    [System.MonoTODOAttribute]
    public System.Collections.ObjectModel.ReadOnlyCollection<System.Data.Linq.MemberChangeConflict> MemberConflicts { get { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.Data.Linq.MemberChangeConflict>); } }
    [System.MonoTODOAttribute]
    public object Object { get { return default(object); } }
    [System.MonoTODOAttribute]
    public void Resolve() { }
    [System.MonoTODOAttribute]
    public void Resolve(System.Data.Linq.RefreshMode refreshMode) { }
    [System.MonoTODOAttribute]
    public void Resolve(System.Data.Linq.RefreshMode refreshMode, bool autoResolveDeletes) { }
  }
  public enum RefreshMode {
    KeepChanges = 1,
    KeepCurrentValues = 0,
    OverwriteCurrentValues = 2,
  }
  public sealed partial class Table<TEntity> : System.Collections.Generic.IEnumerable<TEntity>, System.Collections.IEnumerable, System.ComponentModel.IListSource, System.Data.Linq.ITable, System.Linq.IQueryable, System.Linq.IQueryable<TEntity>, System.Linq.IQueryProvider where TEntity : class {
    internal Table() { }
    public System.Data.Linq.DataContext Context { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Data.Linq.DataContext); } }
    public bool IsReadOnly { get { return default(bool); } }
    bool System.ComponentModel.IListSource.ContainsListCollection { get { return default(bool); } }
    System.Type System.Linq.IQueryable.ElementType { get { return default(System.Type); } }
    System.Linq.Expressions.Expression System.Linq.IQueryable.Expression { get { return default(System.Linq.Expressions.Expression); } }
    System.Linq.IQueryProvider System.Linq.IQueryable.Provider { get { return default(System.Linq.IQueryProvider); } }
    public void Attach(TEntity entity) { }
    public void Attach(TEntity entity, TEntity original) { }
    [DbLinq.DbLinqToDoAttribute]
    public void Attach(TEntity entity, bool asModified) { }
    public void AttachAll<TSubEntity>(System.Collections.Generic.IEnumerable<TSubEntity> entities) where TSubEntity : TEntity { }
    [DbLinq.DbLinqToDoAttribute]
    public void AttachAll<TSubEntity>(System.Collections.Generic.IEnumerable<TSubEntity> entities, bool asModified) where TSubEntity : TEntity { }
    public void DeleteAllOnSubmit<TSubEntity>(System.Collections.Generic.IEnumerable<TSubEntity> entities) where TSubEntity : TEntity { }
    public void DeleteOnSubmit(TEntity entity) { }
    public System.Collections.Generic.IEnumerator<TEntity> GetEnumerator() { return default(System.Collections.Generic.IEnumerator<TEntity>); }
    [DbLinq.DbLinqToDoAttribute]
    public System.Data.Linq.ModifiedMemberInfo[] GetModifiedMembers(TEntity entity) { return default(System.Data.Linq.ModifiedMemberInfo[]); }
    [DbLinq.DbLinqToDoAttribute]
    public System.ComponentModel.IBindingList GetNewBindingList() { return default(System.ComponentModel.IBindingList); }
    [DbLinq.DbLinqToDoAttribute]
    public TEntity GetOriginalEntityState(TEntity entity) { return default(TEntity); }
    public void InsertAllOnSubmit<TSubEntity>(System.Collections.Generic.IEnumerable<TSubEntity> entities) where TSubEntity : TEntity { }
    public void InsertOnSubmit(TEntity entity) { }
    System.Collections.Generic.IEnumerator<TEntity> System.Collections.Generic.IEnumerable<TEntity>.GetEnumerator() { return default(System.Collections.Generic.IEnumerator<TEntity>); }
    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { return default(System.Collections.IEnumerator); }
    System.Collections.IList System.ComponentModel.IListSource.GetList() { return default(System.Collections.IList); }
    void System.Data.Linq.ITable.Attach(object entity) { }
    void System.Data.Linq.ITable.Attach(object entity, bool asModified) { }
    void System.Data.Linq.ITable.Attach(object entity, object original) { }
    void System.Data.Linq.ITable.AttachAll(System.Collections.IEnumerable entities) { }
    void System.Data.Linq.ITable.AttachAll(System.Collections.IEnumerable entities, bool asModified) { }
    void System.Data.Linq.ITable.DeleteAllOnSubmit(System.Collections.IEnumerable entities) { }
    void System.Data.Linq.ITable.DeleteOnSubmit(object entity) { }
    [DbLinq.DbLinqToDoAttribute]
    [System.ObsoleteAttribute("NOT IMPLEMENTED YET")]
    System.Data.Linq.ModifiedMemberInfo[] System.Data.Linq.ITable.GetModifiedMembers(object entity) { return default(System.Data.Linq.ModifiedMemberInfo[]); }
    [DbLinq.DbLinqToDoAttribute]
    [System.ObsoleteAttribute("NOT IMPLEMENTED YET")]
    object System.Data.Linq.ITable.GetOriginalEntityState(object entity) { return default(object); }
    void System.Data.Linq.ITable.InsertAllOnSubmit(System.Collections.IEnumerable entities) { }
    void System.Data.Linq.ITable.InsertOnSubmit(object entity) { }
    System.Linq.IQueryable System.Linq.IQueryProvider.CreateQuery(System.Linq.Expressions.Expression expression) { return default(System.Linq.IQueryable); }
    System.Linq.IQueryable<S> System.Linq.IQueryProvider.CreateQuery<S>(System.Linq.Expressions.Expression expr) { return default(System.Linq.IQueryable<S>); }
    object System.Linq.IQueryProvider.Execute(System.Linq.Expressions.Expression expression) { return default(object); }
    S System.Linq.IQueryProvider.Execute<S>(System.Linq.Expressions.Expression expression) { return default(S); }
    public override string ToString() { return default(string); }
  }
}
namespace System.Data.Linq.Mapping {
  [System.AttributeUsageAttribute((System.AttributeTargets)(384), AllowMultiple=false)]
  public sealed partial class AssociationAttribute : System.Data.Linq.Mapping.DataAttribute {
    public AssociationAttribute() { }
    public bool DeleteOnNull { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public string DeleteRule { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public bool IsForeignKey { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public bool IsUnique { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public string OtherKey { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public string ThisKey { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
  }
  public sealed partial class AttributeMappingSource : System.Data.Linq.Mapping.MappingSource {
    public AttributeMappingSource() { }
    protected override System.Data.Linq.Mapping.MetaModel CreateModel(System.Type dataContextType) { return default(System.Data.Linq.Mapping.MetaModel); }
  }
  public enum AutoSync {
    Always = 1,
    Default = 0,
    Never = 2,
    OnInsert = 3,
    OnUpdate = 4,
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(384), AllowMultiple=false)]
  public sealed partial class ColumnAttribute : System.Data.Linq.Mapping.DataAttribute {
    public ColumnAttribute() { }
    public System.Data.Linq.Mapping.AutoSync AutoSync { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Data.Linq.Mapping.AutoSync); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public bool CanBeNull { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public string DbType { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public string Expression { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public bool IsDbGenerated { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public bool IsDiscriminator { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public bool IsPrimaryKey { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public bool IsVersion { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Data.Linq.Mapping.UpdateCheck UpdateCheck { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Data.Linq.Mapping.UpdateCheck); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
  }
  public abstract partial class DataAttribute : System.Attribute {
    protected DataAttribute() { }
    public string Name { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public string Storage { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(4), AllowMultiple=false)]
  public sealed partial class DatabaseAttribute : System.Attribute {
    public DatabaseAttribute() { }
    public string Name { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(64), AllowMultiple=false)]
  public sealed partial class FunctionAttribute : System.Attribute {
    public FunctionAttribute() { }
    public bool IsComposable { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public string Name { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(4), AllowMultiple=true, Inherited=false)]
  public sealed partial class InheritanceMappingAttribute : System.Attribute {
    public InheritanceMappingAttribute() { }
    public object Code { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(object); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public bool IsDefault { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Type Type { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Type); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
  }
  public abstract partial class MappingSource {
    protected MappingSource() { }
    protected abstract System.Data.Linq.Mapping.MetaModel CreateModel(System.Type dataContextType);
    public System.Data.Linq.Mapping.MetaModel GetModel(System.Type dataContextType) { return default(System.Data.Linq.Mapping.MetaModel); }
  }
  public abstract partial class MetaAccessor {
    protected MetaAccessor() { }
    public abstract System.Type Type { get; }
    public abstract object GetBoxedValue(object instance);
    [System.MonoTODOAttribute]
    public virtual bool HasAssignedValue(object instance) { return default(bool); }
    [System.MonoTODOAttribute]
    public virtual bool HasLoadedValue(object instance) { return default(bool); }
    [System.MonoTODOAttribute]
    public virtual bool HasValue(object instance) { return default(bool); }
    public abstract void SetBoxedValue(ref object instance, object value);
  }
  public abstract partial class MetaAccessor<TEntity, TMember> : System.Data.Linq.Mapping.MetaAccessor {
    protected MetaAccessor() { }
    public override System.Type Type { get { return default(System.Type); } }
    public override object GetBoxedValue(object instance) { return default(object); }
    public abstract TMember GetValue(TEntity instance);
    public override void SetBoxedValue(ref object instance, object value) { }
    public abstract void SetValue(ref TEntity instance, TMember value);
  }
  public abstract partial class MetaAssociation {
    protected MetaAssociation() { }
    public abstract bool DeleteOnNull { get; }
    public abstract string DeleteRule { get; }
    public abstract bool IsForeignKey { get; }
    public abstract bool IsMany { get; }
    public abstract bool IsNullable { get; }
    public abstract bool IsUnique { get; }
    public abstract System.Collections.ObjectModel.ReadOnlyCollection<System.Data.Linq.Mapping.MetaDataMember> OtherKey { get; }
    public abstract bool OtherKeyIsPrimaryKey { get; }
    public abstract System.Data.Linq.Mapping.MetaDataMember OtherMember { get; }
    public abstract System.Data.Linq.Mapping.MetaType OtherType { get; }
    public abstract System.Collections.ObjectModel.ReadOnlyCollection<System.Data.Linq.Mapping.MetaDataMember> ThisKey { get; }
    public abstract bool ThisKeyIsPrimaryKey { get; }
    public abstract System.Data.Linq.Mapping.MetaDataMember ThisMember { get; }
  }
  public abstract partial class MetaDataMember {
    protected MetaDataMember() { }
    public abstract System.Data.Linq.Mapping.MetaAssociation Association { get; }
    public abstract System.Data.Linq.Mapping.AutoSync AutoSync { get; }
    public abstract bool CanBeNull { get; }
    public abstract string DbType { get; }
    public abstract System.Data.Linq.Mapping.MetaType DeclaringType { get; }
    public abstract System.Data.Linq.Mapping.MetaAccessor DeferredSourceAccessor { get; }
    public abstract System.Data.Linq.Mapping.MetaAccessor DeferredValueAccessor { get; }
    public abstract string Expression { get; }
    public abstract bool IsAssociation { get; }
    public abstract bool IsDbGenerated { get; }
    public abstract bool IsDeferred { get; }
    public abstract bool IsDiscriminator { get; }
    public abstract bool IsPersistent { get; }
    public abstract bool IsPrimaryKey { get; }
    public abstract bool IsVersion { get; }
    public abstract System.Reflection.MethodInfo LoadMethod { get; }
    public abstract string MappedName { get; }
    public abstract System.Reflection.MemberInfo Member { get; }
    public abstract System.Data.Linq.Mapping.MetaAccessor MemberAccessor { get; }
    public abstract string Name { get; }
    public abstract int Ordinal { get; }
    public abstract System.Data.Linq.Mapping.MetaAccessor StorageAccessor { get; }
    public abstract System.Reflection.MemberInfo StorageMember { get; }
    public abstract System.Type Type { get; }
    public abstract System.Data.Linq.Mapping.UpdateCheck UpdateCheck { get; }
    public abstract bool IsDeclaredBy(System.Data.Linq.Mapping.MetaType type);
  }
  public abstract partial class MetaFunction {
    protected MetaFunction() { }
    public abstract bool HasMultipleResults { get; }
    public abstract bool IsComposable { get; }
    public abstract string MappedName { get; }
    public abstract System.Reflection.MethodInfo Method { get; }
    public abstract System.Data.Linq.Mapping.MetaModel Model { get; }
    public abstract string Name { get; }
    public abstract System.Collections.ObjectModel.ReadOnlyCollection<System.Data.Linq.Mapping.MetaParameter> Parameters { get; }
    public abstract System.Collections.ObjectModel.ReadOnlyCollection<System.Data.Linq.Mapping.MetaType> ResultRowTypes { get; }
    public abstract System.Data.Linq.Mapping.MetaParameter ReturnParameter { get; }
  }
  public abstract partial class MetaModel {
    protected MetaModel() { }
    public abstract System.Type ContextType { get; }
    public abstract string DatabaseName { get; }
    public abstract System.Data.Linq.Mapping.MappingSource MappingSource { get; }
    public abstract System.Type ProviderType { get; }
    public abstract System.Data.Linq.Mapping.MetaFunction GetFunction(System.Reflection.MethodInfo method);
    public abstract System.Collections.Generic.IEnumerable<System.Data.Linq.Mapping.MetaFunction> GetFunctions();
    public abstract System.Data.Linq.Mapping.MetaType GetMetaType(System.Type type);
    public abstract System.Data.Linq.Mapping.MetaTable GetTable(System.Type rowType);
    public abstract System.Collections.Generic.IEnumerable<System.Data.Linq.Mapping.MetaTable> GetTables();
  }
  public abstract partial class MetaParameter {
    protected MetaParameter() { }
    public abstract string DbType { get; }
    public abstract string MappedName { get; }
    public abstract string Name { get; }
    public abstract System.Reflection.ParameterInfo Parameter { get; }
    public abstract System.Type ParameterType { get; }
  }
  public abstract partial class MetaTable {
    protected MetaTable() { }
    public abstract System.Reflection.MethodInfo DeleteMethod { get; }
    public abstract System.Reflection.MethodInfo InsertMethod { get; }
    public abstract System.Data.Linq.Mapping.MetaModel Model { get; }
    public abstract System.Data.Linq.Mapping.MetaType RowType { get; }
    public abstract string TableName { get; }
    public abstract System.Reflection.MethodInfo UpdateMethod { get; }
  }
  public abstract partial class MetaType {
    protected MetaType() { }
    public abstract System.Collections.ObjectModel.ReadOnlyCollection<System.Data.Linq.Mapping.MetaAssociation> Associations { get; }
    public abstract bool CanInstantiate { get; }
    public abstract System.Collections.ObjectModel.ReadOnlyCollection<System.Data.Linq.Mapping.MetaDataMember> DataMembers { get; }
    public abstract System.Data.Linq.Mapping.MetaDataMember DBGeneratedIdentityMember { get; }
    public abstract System.Collections.ObjectModel.ReadOnlyCollection<System.Data.Linq.Mapping.MetaType> DerivedTypes { get; }
    public abstract System.Data.Linq.Mapping.MetaDataMember Discriminator { get; }
    public abstract bool HasAnyLoadMethod { get; }
    public abstract bool HasAnyValidateMethod { get; }
    public abstract bool HasInheritance { get; }
    public abstract bool HasInheritanceCode { get; }
    public abstract bool HasUpdateCheck { get; }
    public abstract System.Collections.ObjectModel.ReadOnlyCollection<System.Data.Linq.Mapping.MetaDataMember> IdentityMembers { get; }
    public abstract System.Data.Linq.Mapping.MetaType InheritanceBase { get; }
    public abstract object InheritanceCode { get; }
    public abstract System.Data.Linq.Mapping.MetaType InheritanceDefault { get; }
    public abstract System.Data.Linq.Mapping.MetaType InheritanceRoot { get; }
    public abstract System.Collections.ObjectModel.ReadOnlyCollection<System.Data.Linq.Mapping.MetaType> InheritanceTypes { get; }
    public abstract bool IsEntity { get; }
    public abstract bool IsInheritanceDefault { get; }
    public abstract System.Data.Linq.Mapping.MetaModel Model { get; }
    public abstract string Name { get; }
    public abstract System.Reflection.MethodInfo OnLoadedMethod { get; }
    public abstract System.Reflection.MethodInfo OnValidateMethod { get; }
    public abstract System.Collections.ObjectModel.ReadOnlyCollection<System.Data.Linq.Mapping.MetaDataMember> PersistentDataMembers { get; }
    public abstract System.Data.Linq.Mapping.MetaTable Table { get; }
    public abstract System.Type Type { get; }
    public abstract System.Data.Linq.Mapping.MetaDataMember VersionMember { get; }
    public abstract System.Data.Linq.Mapping.MetaDataMember GetDataMember(System.Reflection.MemberInfo member);
    public abstract System.Data.Linq.Mapping.MetaType GetInheritanceType(System.Type type);
    public abstract System.Data.Linq.Mapping.MetaType GetTypeForInheritanceCode(object code);
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(10240), AllowMultiple=false)]
  public sealed partial class ParameterAttribute : System.Attribute {
    public ParameterAttribute() { }
    public string DbType { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public string Name { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(4), AllowMultiple=false)]
  public sealed partial class ProviderAttribute : System.Attribute {
    public ProviderAttribute() { }
    public ProviderAttribute(System.Type type) { }
    public System.Type Type { get { return default(System.Type); } }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(64), AllowMultiple=true)]
  public sealed partial class ResultTypeAttribute : System.Attribute {
    public ResultTypeAttribute(System.Type type) { }
    public System.Type Type { get { return default(System.Type); } }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(4), AllowMultiple=false, Inherited=false)]
  public sealed partial class TableAttribute : System.Attribute {
    public TableAttribute() { }
    public string Name { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
  }
  public enum UpdateCheck {
    Always = 0,
    Never = 1,
    WhenChanged = 2,
  }
  public sealed partial class XmlMappingSource : System.Data.Linq.Mapping.MappingSource {
    internal XmlMappingSource() { }
    protected override System.Data.Linq.Mapping.MetaModel CreateModel(System.Type dataContextType) { return default(System.Data.Linq.Mapping.MetaModel); }
    public static System.Data.Linq.Mapping.XmlMappingSource FromReader(System.Xml.XmlReader reader) { return default(System.Data.Linq.Mapping.XmlMappingSource); }
    public static System.Data.Linq.Mapping.XmlMappingSource FromStream(System.IO.Stream stream) { return default(System.Data.Linq.Mapping.XmlMappingSource); }
    public static System.Data.Linq.Mapping.XmlMappingSource FromUrl(string url) { return default(System.Data.Linq.Mapping.XmlMappingSource); }
    public static System.Data.Linq.Mapping.XmlMappingSource FromXml(string xml) { return default(System.Data.Linq.Mapping.XmlMappingSource); }
  }
}
namespace System.Data.Linq.SqlClient {
  public partial class Sql2000Provider : System.Data.Linq.SqlClient.SqlProvider {
    public Sql2000Provider() { }
  }
  public partial class Sql2005Provider : System.Data.Linq.SqlClient.SqlProvider {
    public Sql2005Provider() { }
  }
  public partial class Sql2008Provider : System.Data.Linq.SqlClient.SqlProvider {
    public Sql2008Provider() { }
  }
  public static partial class SqlHelpers {
    [System.MonoTODOAttribute]
    public static string GetStringContainsPattern(string text, char escape) { return default(string); }
    [System.MonoTODOAttribute]
    public static string GetStringEndsWithPattern(string text, char escape) { return default(string); }
    [System.MonoTODOAttribute]
    public static string GetStringStartsWithPattern(string text, char escape) { return default(string); }
    [System.MonoTODOAttribute]
    public static string TranslateVBLikePattern(string pattern, char escape) { return default(string); }
  }
  public static partial class SqlMethods {
    [System.MonoTODOAttribute]
    public static int DateDiffDay(System.DateTime startDate, System.DateTime endDate) { return default(int); }
    [System.MonoTODOAttribute]
    public static int DateDiffDay(System.DateTimeOffset startDate, System.DateTimeOffset endDate) { return default(int); }
    [System.MonoTODOAttribute]
    public static System.Nullable<System.Int32> DateDiffDay(System.Nullable<System.DateTime> startDate, System.Nullable<System.DateTime> endDate) { return default(System.Nullable<System.Int32>); }
    [System.MonoTODOAttribute]
    public static System.Nullable<System.Int32> DateDiffDay(System.Nullable<System.DateTimeOffset> startDate, System.Nullable<System.DateTimeOffset> endDate) { return default(System.Nullable<System.Int32>); }
    [System.MonoTODOAttribute]
    public static int DateDiffHour(System.DateTime startDate, System.DateTime endDate) { return default(int); }
    [System.MonoTODOAttribute]
    public static int DateDiffHour(System.DateTimeOffset startDate, System.DateTimeOffset endDate) { return default(int); }
    [System.MonoTODOAttribute]
    public static System.Nullable<System.Int32> DateDiffHour(System.Nullable<System.DateTime> startDate, System.Nullable<System.DateTime> endDate) { return default(System.Nullable<System.Int32>); }
    [System.MonoTODOAttribute]
    public static System.Nullable<System.Int32> DateDiffHour(System.Nullable<System.DateTimeOffset> startDate, System.Nullable<System.DateTimeOffset> endDate) { return default(System.Nullable<System.Int32>); }
    [System.MonoTODOAttribute]
    public static int DateDiffMicrosecond(System.DateTime startDate, System.DateTime endDate) { return default(int); }
    [System.MonoTODOAttribute]
    public static int DateDiffMicrosecond(System.DateTimeOffset startDate, System.DateTimeOffset endDate) { return default(int); }
    [System.MonoTODOAttribute]
    public static System.Nullable<System.Int32> DateDiffMicrosecond(System.Nullable<System.DateTime> startDate, System.Nullable<System.DateTime> endDate) { return default(System.Nullable<System.Int32>); }
    [System.MonoTODOAttribute]
    public static System.Nullable<System.Int32> DateDiffMicrosecond(System.Nullable<System.DateTimeOffset> startDate, System.Nullable<System.DateTimeOffset> endDate) { return default(System.Nullable<System.Int32>); }
    [System.MonoTODOAttribute]
    public static int DateDiffMillisecond(System.DateTime startDate, System.DateTime endDate) { return default(int); }
    [System.MonoTODOAttribute]
    public static int DateDiffMillisecond(System.DateTimeOffset startDate, System.DateTimeOffset endDate) { return default(int); }
    [System.MonoTODOAttribute]
    public static System.Nullable<System.Int32> DateDiffMillisecond(System.Nullable<System.DateTime> startDate, System.Nullable<System.DateTime> endDate) { return default(System.Nullable<System.Int32>); }
    [System.MonoTODOAttribute]
    public static System.Nullable<System.Int32> DateDiffMillisecond(System.Nullable<System.DateTimeOffset> startDate, System.Nullable<System.DateTimeOffset> endDate) { return default(System.Nullable<System.Int32>); }
    [System.MonoTODOAttribute]
    public static int DateDiffMinute(System.DateTime startDate, System.DateTime endDate) { return default(int); }
    [System.MonoTODOAttribute]
    public static int DateDiffMinute(System.DateTimeOffset startDate, System.DateTimeOffset endDate) { return default(int); }
    [System.MonoTODOAttribute]
    public static System.Nullable<System.Int32> DateDiffMinute(System.Nullable<System.DateTime> startDate, System.Nullable<System.DateTime> endDate) { return default(System.Nullable<System.Int32>); }
    [System.MonoTODOAttribute]
    public static System.Nullable<System.Int32> DateDiffMinute(System.Nullable<System.DateTimeOffset> startDate, System.Nullable<System.DateTimeOffset> endDate) { return default(System.Nullable<System.Int32>); }
    [System.MonoTODOAttribute]
    public static int DateDiffMonth(System.DateTime startDate, System.DateTime endDate) { return default(int); }
    [System.MonoTODOAttribute]
    public static int DateDiffMonth(System.DateTimeOffset startDate, System.DateTimeOffset endDate) { return default(int); }
    [System.MonoTODOAttribute]
    public static System.Nullable<System.Int32> DateDiffMonth(System.Nullable<System.DateTime> startDate, System.Nullable<System.DateTime> endDate) { return default(System.Nullable<System.Int32>); }
    [System.MonoTODOAttribute]
    public static System.Nullable<System.Int32> DateDiffMonth(System.Nullable<System.DateTimeOffset> startDate, System.Nullable<System.DateTimeOffset> endDate) { return default(System.Nullable<System.Int32>); }
    [System.MonoTODOAttribute]
    public static int DateDiffNanosecond(System.DateTime startDate, System.DateTime endDate) { return default(int); }
    [System.MonoTODOAttribute]
    public static int DateDiffNanosecond(System.DateTimeOffset startDate, System.DateTimeOffset endDate) { return default(int); }
    [System.MonoTODOAttribute]
    public static System.Nullable<System.Int32> DateDiffNanosecond(System.Nullable<System.DateTime> startDate, System.Nullable<System.DateTime> endDate) { return default(System.Nullable<System.Int32>); }
    [System.MonoTODOAttribute]
    public static System.Nullable<System.Int32> DateDiffNanosecond(System.Nullable<System.DateTimeOffset> startDate, System.Nullable<System.DateTimeOffset> endDate) { return default(System.Nullable<System.Int32>); }
    [System.MonoTODOAttribute]
    public static int DateDiffSecond(System.DateTime startDate, System.DateTime endDate) { return default(int); }
    [System.MonoTODOAttribute]
    public static int DateDiffSecond(System.DateTimeOffset startDate, System.DateTimeOffset endDate) { return default(int); }
    [System.MonoTODOAttribute]
    public static System.Nullable<System.Int32> DateDiffSecond(System.Nullable<System.DateTime> startDate, System.Nullable<System.DateTime> endDate) { return default(System.Nullable<System.Int32>); }
    [System.MonoTODOAttribute]
    public static System.Nullable<System.Int32> DateDiffSecond(System.Nullable<System.DateTimeOffset> startDate, System.Nullable<System.DateTimeOffset> endDate) { return default(System.Nullable<System.Int32>); }
    [System.MonoTODOAttribute]
    public static int DateDiffYear(System.DateTime startDate, System.DateTime endDate) { return default(int); }
    [System.MonoTODOAttribute]
    public static int DateDiffYear(System.DateTimeOffset startDate, System.DateTimeOffset endDate) { return default(int); }
    [System.MonoTODOAttribute]
    public static System.Nullable<System.Int32> DateDiffYear(System.Nullable<System.DateTime> startDate, System.Nullable<System.DateTime> endDate) { return default(System.Nullable<System.Int32>); }
    [System.MonoTODOAttribute]
    public static System.Nullable<System.Int32> DateDiffYear(System.Nullable<System.DateTimeOffset> startDate, System.Nullable<System.DateTimeOffset> endDate) { return default(System.Nullable<System.Int32>); }
    [System.MonoTODOAttribute]
    public static bool Like(string matchExpression, string pattern) { return default(bool); }
    [System.MonoTODOAttribute]
    public static bool Like(string matchExpression, string pattern, char escapeCharacter) { return default(bool); }
  }
  [System.MonoTODOAttribute]
  public partial class SqlProvider : System.IDisposable {
    public SqlProvider() { }
    public void Dispose() { }
    protected virtual void Dispose(bool disposing) { }
  }
}
namespace System.Data.Linq.SqlClient.Implementation {
  public abstract partial class ObjectMaterializer<TDataReader> where TDataReader : System.Data.Common.DbDataReader {
    [System.MonoTODOAttribute]
    public System.Object[] Arguments;
    [System.MonoTODOAttribute]
    public System.Data.Common.DbDataReader BufferReader;
    [System.MonoTODOAttribute]
    public TDataReader DataReader;
    [System.MonoTODOAttribute]
    public System.Object[] Globals;
    [System.MonoTODOAttribute]
    public System.Object[] Locals;
    [System.MonoTODOAttribute]
    public System.Int32[] Ordinals;
    [System.MonoTODOAttribute]
    public ObjectMaterializer() { }
    [System.MonoTODOAttribute]
    public abstract bool CanDeferLoad { get; }
    [System.MonoTODOAttribute]
    public static System.Collections.Generic.IEnumerable<TOutput> Convert<TOutput>(System.Collections.IEnumerable source) { return default(System.Collections.Generic.IEnumerable<TOutput>); }
    [System.MonoTODOAttribute]
    public static System.Linq.IGrouping<TKey, TElement> CreateGroup<TKey, TElement>(TKey key, System.Collections.Generic.IEnumerable<TElement> items) { return default(System.Linq.IGrouping<TKey, TElement>); }
    [System.MonoTODOAttribute]
    public static System.Linq.IOrderedEnumerable<TElement> CreateOrderedEnumerable<TElement>(System.Collections.Generic.IEnumerable<TElement> items) { return default(System.Linq.IOrderedEnumerable<TElement>); }
    [System.MonoTODOAttribute]
    public static System.Exception ErrorAssignmentToNull(System.Type type) { return default(System.Exception); }
    public abstract System.Collections.IEnumerable ExecuteSubQuery(int iSubQuery, System.Object[] args);
    public abstract System.Collections.Generic.IEnumerable<T> GetLinkSource<T>(int globalLink, int localFactory, System.Object[] keyValues);
    public abstract System.Collections.Generic.IEnumerable<T> GetNestedLinkSource<T>(int globalLink, int localFactory, object instance);
    public abstract object InsertLookup(int globalMetaType, object instance);
    public abstract bool Read();
    public abstract void SendEntityMaterialized(int globalMetaType, object instance);
  }
}
