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
    public int Count { get { return default(int); } }
    public System.Data.Linq.ObjectChangeConflict this[int index] { get { return default(System.Data.Linq.ObjectChangeConflict); } }
    bool System.Collections.Generic.ICollection<System.Data.Linq.ObjectChangeConflict>.IsReadOnly { get { return default(bool); } }
    bool System.Collections.ICollection.IsSynchronized { get { return default(bool); } }
    object System.Collections.ICollection.SyncRoot { get { return default(object); } }
    public void Clear() { }
    public bool Contains(System.Data.Linq.ObjectChangeConflict item) { return default(bool); }
    public void CopyTo(System.Data.Linq.ObjectChangeConflict[] array, int arrayIndex) { }
    public System.Collections.Generic.IEnumerator<System.Data.Linq.ObjectChangeConflict> GetEnumerator() { return default(System.Collections.Generic.IEnumerator<System.Data.Linq.ObjectChangeConflict>); }
    public bool Remove(System.Data.Linq.ObjectChangeConflict item) { return default(bool); }
    public void ResolveAll(System.Data.Linq.RefreshMode mode) { }
    public void ResolveAll(System.Data.Linq.RefreshMode mode, bool autoResolveDeletes) { }
    void System.Collections.Generic.ICollection<System.Data.Linq.ObjectChangeConflict>.Add(System.Data.Linq.ObjectChangeConflict item) { }
    void System.Collections.ICollection.CopyTo(System.Array array, int index) { }
    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { return default(System.Collections.IEnumerator); }
  }
  public partial class ChangeConflictException : System.Exception {
    public ChangeConflictException() { }
    public ChangeConflictException(string message) { }
    public ChangeConflictException(string message, System.Exception innerException) { }
  }
  public sealed partial class ChangeSet {
    internal ChangeSet() { }
    public System.Collections.Generic.IList<System.Object> Deletes { get { return default(System.Collections.Generic.IList<System.Object>); } }
    public System.Collections.Generic.IList<System.Object> Inserts { get { return default(System.Collections.Generic.IList<System.Object>); } }
    public System.Collections.Generic.IList<System.Object> Updates { get { return default(System.Collections.Generic.IList<System.Object>); } }
    public override string ToString() { return default(string); }
  }
  public sealed partial class CompiledQuery {
    internal CompiledQuery() { }
    public System.Linq.Expressions.LambdaExpression Expression { get { return default(System.Linq.Expressions.LambdaExpression); } }
    public static System.Func<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TResult> Compile<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TResult>(System.Linq.Expressions.Expression<System.Func<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TResult>> query) where TArg0 : System.Data.Linq.DataContext { return default(System.Func<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TResult>); }
    public static System.Func<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TResult> Compile<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TResult>(System.Linq.Expressions.Expression<System.Func<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TResult>> query) where TArg0 : System.Data.Linq.DataContext { return default(System.Func<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TResult>); }
    public static System.Func<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TResult> Compile<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TResult>(System.Linq.Expressions.Expression<System.Func<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TResult>> query) where TArg0 : System.Data.Linq.DataContext { return default(System.Func<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TResult>); }
    public static System.Func<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TResult> Compile<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TResult>(System.Linq.Expressions.Expression<System.Func<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TResult>> query) where TArg0 : System.Data.Linq.DataContext { return default(System.Func<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TResult>); }
    public static System.Func<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TResult> Compile<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TResult>(System.Linq.Expressions.Expression<System.Func<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TResult>> query) where TArg0 : System.Data.Linq.DataContext { return default(System.Func<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TResult>); }
    public static System.Func<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TResult> Compile<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TResult>(System.Linq.Expressions.Expression<System.Func<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TResult>> query) where TArg0 : System.Data.Linq.DataContext { return default(System.Func<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TResult>); }
    public static System.Func<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TResult> Compile<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TResult>(System.Linq.Expressions.Expression<System.Func<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TResult>> query) where TArg0 : System.Data.Linq.DataContext { return default(System.Func<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TResult>); }
    public static System.Func<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TResult> Compile<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TResult>(System.Linq.Expressions.Expression<System.Func<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TResult>> query) where TArg0 : System.Data.Linq.DataContext { return default(System.Func<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TResult>); }
    public static System.Func<TArg0, TResult> Compile<TArg0, TResult>(System.Linq.Expressions.Expression<System.Func<TArg0, TResult>> query) where TArg0 : System.Data.Linq.DataContext { return default(System.Func<TArg0, TResult>); }
    public static System.Func<TArg0, TArg1, TResult> Compile<TArg0, TArg1, TResult>(System.Linq.Expressions.Expression<System.Func<TArg0, TArg1, TResult>> query) where TArg0 : System.Data.Linq.DataContext { return default(System.Func<TArg0, TArg1, TResult>); }
    public static System.Func<TArg0, TArg1, TArg2, TResult> Compile<TArg0, TArg1, TArg2, TResult>(System.Linq.Expressions.Expression<System.Func<TArg0, TArg1, TArg2, TResult>> query) where TArg0 : System.Data.Linq.DataContext { return default(System.Func<TArg0, TArg1, TArg2, TResult>); }
    public static System.Func<TArg0, TArg1, TArg2, TArg3, TResult> Compile<TArg0, TArg1, TArg2, TArg3, TResult>(System.Linq.Expressions.Expression<System.Func<TArg0, TArg1, TArg2, TArg3, TResult>> query) where TArg0 : System.Data.Linq.DataContext { return default(System.Func<TArg0, TArg1, TArg2, TArg3, TResult>); }
    public static System.Func<TArg0, TArg1, TArg2, TArg3, TArg4, TResult> Compile<TArg0, TArg1, TArg2, TArg3, TArg4, TResult>(System.Linq.Expressions.Expression<System.Func<TArg0, TArg1, TArg2, TArg3, TArg4, TResult>> query) where TArg0 : System.Data.Linq.DataContext { return default(System.Func<TArg0, TArg1, TArg2, TArg3, TArg4, TResult>); }
    public static System.Func<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TResult> Compile<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TResult>(System.Linq.Expressions.Expression<System.Func<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TResult>> query) where TArg0 : System.Data.Linq.DataContext { return default(System.Func<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TResult>); }
    public static System.Func<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TResult> Compile<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TResult>(System.Linq.Expressions.Expression<System.Func<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TResult>> query) where TArg0 : System.Data.Linq.DataContext { return default(System.Func<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TResult>); }
    public static System.Func<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TResult> Compile<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TResult>(System.Linq.Expressions.Expression<System.Func<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TResult>> query) where TArg0 : System.Data.Linq.DataContext { return default(System.Func<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TResult>); }
  }
  public enum ConflictMode {
    ContinueOnConflict = 1,
    FailOnFirstConflict = 0,
  }
  public partial class DataContext : System.IDisposable {
    public DataContext(System.Data.IDbConnection connection) { }
    public DataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mapping) { }
    public DataContext(string fileOrServerOrConnection) { }
    public DataContext(string fileOrServerOrConnection, System.Data.Linq.Mapping.MappingSource mapping) { }
    public System.Data.Linq.ChangeConflictCollection ChangeConflicts { get { return default(System.Data.Linq.ChangeConflictCollection); } }
    public int CommandTimeout { get { return default(int); } set { } }
    public System.Data.Common.DbConnection Connection { get { return default(System.Data.Common.DbConnection); } }
    public bool DeferredLoadingEnabled { get { return default(bool); } set { } }
    public System.Data.Linq.DataLoadOptions LoadOptions { get { return default(System.Data.Linq.DataLoadOptions); } set { } }
    public System.IO.TextWriter Log { get { return default(System.IO.TextWriter); } set { } }
    public System.Data.Linq.Mapping.MetaModel Mapping { get { return default(System.Data.Linq.Mapping.MetaModel); } }
    public bool ObjectTrackingEnabled { get { return default(bool); } set { } }
    public System.Data.Common.DbTransaction Transaction { get { return default(System.Data.Common.DbTransaction); } set { } }
    public void CreateDatabase() { }
    protected internal System.Linq.IQueryable<TResult> CreateMethodCallQuery<TResult>(object instance, System.Reflection.MethodInfo methodInfo, params System.Object[] parameters) { return default(System.Linq.IQueryable<TResult>); }
    public bool DatabaseExists() { return default(bool); }
    public void DeleteDatabase() { }
    public void Dispose() { }
    protected virtual void Dispose(bool disposing) { }
    public int ExecuteCommand(string command, params System.Object[] parameters) { return default(int); }
    protected internal void ExecuteDynamicDelete(object entity) { }
    protected internal void ExecuteDynamicInsert(object entity) { }
    protected internal void ExecuteDynamicUpdate(object entity) { }
    protected internal System.Data.Linq.IExecuteResult ExecuteMethodCall(object instance, System.Reflection.MethodInfo methodInfo, params System.Object[] parameters) { return default(System.Data.Linq.IExecuteResult); }
    public System.Collections.IEnumerable ExecuteQuery(System.Type elementType, string query, params System.Object[] parameters) { return default(System.Collections.IEnumerable); }
    public System.Collections.Generic.IEnumerable<TResult> ExecuteQuery<TResult>(string query, params System.Object[] parameters) { return default(System.Collections.Generic.IEnumerable<TResult>); }
    public System.Data.Linq.ChangeSet GetChangeSet() { return default(System.Data.Linq.ChangeSet); }
    public System.Data.Common.DbCommand GetCommand(System.Linq.IQueryable query) { return default(System.Data.Common.DbCommand); }
    public System.Data.Linq.ITable GetTable(System.Type type) { return default(System.Data.Linq.ITable); }
    public System.Data.Linq.Table<TEntity> GetTable<TEntity>() where TEntity : class { return default(System.Data.Linq.Table<TEntity>); }
    public void Refresh(System.Data.Linq.RefreshMode mode, System.Collections.IEnumerable entities) { }
    public void Refresh(System.Data.Linq.RefreshMode mode, object entity) { }
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
    public void LoadWith(System.Linq.Expressions.LambdaExpression expression) { }
    public void LoadWith<T>(System.Linq.Expressions.Expression<System.Func<T, System.Object>> expression) { }
  }
  public static partial class DBConvert {
    public static object ChangeType(object value, System.Type type) { return default(object); }
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
    public EntitySet(System.Action<TEntity> onAdd, System.Action<TEntity> onRemove) { }
    public int Count { get { return default(int); } }
    public bool HasLoadedOrAssignedValues { get { return default(bool); } }
    public bool IsDeferred { get { return default(bool); } }
    public TEntity this[int index] { get { return default(TEntity); } set { } }
    bool System.Collections.Generic.ICollection<TEntity>.IsReadOnly { get { return default(bool); } }
    bool System.Collections.ICollection.IsSynchronized { get { return default(bool); } }
    object System.Collections.ICollection.SyncRoot { get { return default(object); } }
    bool System.Collections.IList.IsFixedSize { get { return default(bool); } }
    bool System.Collections.IList.IsReadOnly { get { return default(bool); } }
    object System.Collections.IList.this[int index] { get { return default(object); } set { } }
    bool System.ComponentModel.IListSource.ContainsListCollection { get { return default(bool); } }
    public event System.ComponentModel.ListChangedEventHandler ListChanged { add { } remove { } }
    public void Add(TEntity entity) { }
    public void AddRange(System.Collections.Generic.IEnumerable<TEntity> collection) { }
    public void Assign(System.Collections.Generic.IEnumerable<TEntity> entitySource) { }
    public void Clear() { }
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
    bool System.Collections.IList.Contains(object value) { return default(bool); }
    int System.Collections.IList.IndexOf(object value) { return default(int); }
    void System.Collections.IList.Insert(int index, object value) { }
    void System.Collections.IList.Remove(object value) { }
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
  public partial interface ITable<TEntity> : System.Collections.Generic.IEnumerable<TEntity>, System.Collections.IEnumerable, System.Linq.IQueryable, System.Linq.IQueryable<TEntity> where TEntity : class {
    void Attach(TEntity entity);
    void DeleteOnSubmit(TEntity entity);
    void InsertOnSubmit(TEntity entity);
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct Link<T> {
    public Link(T value) { throw new System.NotImplementedException(); }
    public Link(System.Collections.Generic.IEnumerable<T> source) { throw new System.NotImplementedException(); }
    public Link(System.Data.Linq.Link<T> link) { throw new System.NotImplementedException(); }
    public bool HasLoadedOrAssignedValue { get { return default(bool); } }
    public bool HasValue { get { return default(bool); } }
    public T Value { get { return default(T); } set { } }
  }
  public sealed partial class MemberChangeConflict {
    internal MemberChangeConflict() { }
    public object CurrentValue { get { return default(object); } }
    public object DatabaseValue { get { return default(object); } }
    public bool IsModified { get { return default(bool); } }
    public bool IsResolved { get { return default(bool); } }
    public System.Reflection.MemberInfo Member { get { return default(System.Reflection.MemberInfo); } }
    public object OriginalValue { get { return default(object); } }
    public void Resolve(System.Data.Linq.RefreshMode refreshMode) { }
    public void Resolve(object value) { }
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct ModifiedMemberInfo {
    public object CurrentValue { get { return default(object); } }
    public System.Reflection.MemberInfo Member { get { return default(System.Reflection.MemberInfo); } }
    public object OriginalValue { get { return default(object); } }
  }
  public sealed partial class ObjectChangeConflict {
    internal ObjectChangeConflict() { }
    public bool IsDeleted { get { return default(bool); } }
    public bool IsResolved { get { return default(bool); } }
    public System.Collections.ObjectModel.ReadOnlyCollection<System.Data.Linq.MemberChangeConflict> MemberConflicts { get { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.Data.Linq.MemberChangeConflict>); } }
    public object Object { get { return default(object); } }
    public void Resolve() { }
    public void Resolve(System.Data.Linq.RefreshMode refreshMode) { }
    public void Resolve(System.Data.Linq.RefreshMode refreshMode, bool autoResolveDeletes) { }
  }
  public enum RefreshMode {
    KeepChanges = 1,
    KeepCurrentValues = 0,
    OverwriteCurrentValues = 2,
  }
  public sealed partial class Table<TEntity> : System.Collections.Generic.IEnumerable<TEntity>, System.Collections.IEnumerable, System.ComponentModel.IListSource, System.Data.Linq.ITable, System.Data.Linq.ITable<TEntity>, System.Linq.IQueryable, System.Linq.IQueryable<TEntity>, System.Linq.IQueryProvider where TEntity : class {
    internal Table() { }
    public System.Data.Linq.DataContext Context { get { return default(System.Data.Linq.DataContext); } }
    public bool IsReadOnly { get { return default(bool); } }
    bool System.ComponentModel.IListSource.ContainsListCollection { get { return default(bool); } }
    System.Type System.Linq.IQueryable.ElementType { get { return default(System.Type); } }
    System.Linq.Expressions.Expression System.Linq.IQueryable.Expression { get { return default(System.Linq.Expressions.Expression); } }
    System.Linq.IQueryProvider System.Linq.IQueryable.Provider { get { return default(System.Linq.IQueryProvider); } }
    public void Attach(TEntity entity) { }
    public void Attach(TEntity entity, TEntity original) { }
    public void Attach(TEntity entity, bool asModified) { }
    public void AttachAll<TSubEntity>(System.Collections.Generic.IEnumerable<TSubEntity> entities) where TSubEntity : TEntity { }
    public void AttachAll<TSubEntity>(System.Collections.Generic.IEnumerable<TSubEntity> entities, bool asModified) where TSubEntity : TEntity { }
    public void DeleteAllOnSubmit<TSubEntity>(System.Collections.Generic.IEnumerable<TSubEntity> entities) where TSubEntity : TEntity { }
    public void DeleteOnSubmit(TEntity entity) { }
    public System.Collections.Generic.IEnumerator<TEntity> GetEnumerator() { return default(System.Collections.Generic.IEnumerator<TEntity>); }
    public System.Data.Linq.ModifiedMemberInfo[] GetModifiedMembers(TEntity entity) { return default(System.Data.Linq.ModifiedMemberInfo[]); }
    public System.ComponentModel.IBindingList GetNewBindingList() { return default(System.ComponentModel.IBindingList); }
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
    System.Data.Linq.ModifiedMemberInfo[] System.Data.Linq.ITable.GetModifiedMembers(object entity) { return default(System.Data.Linq.ModifiedMemberInfo[]); }
    object System.Data.Linq.ITable.GetOriginalEntityState(object entity) { return default(object); }
    void System.Data.Linq.ITable.InsertAllOnSubmit(System.Collections.IEnumerable entities) { }
    void System.Data.Linq.ITable.InsertOnSubmit(object entity) { }
    System.Linq.IQueryable System.Linq.IQueryProvider.CreateQuery(System.Linq.Expressions.Expression expression) { return default(System.Linq.IQueryable); }
    System.Linq.IQueryable<TResult> System.Linq.IQueryProvider.CreateQuery<TResult>(System.Linq.Expressions.Expression expression) { return default(System.Linq.IQueryable<TResult>); }
    object System.Linq.IQueryProvider.Execute(System.Linq.Expressions.Expression expression) { return default(object); }
    TResult System.Linq.IQueryProvider.Execute<TResult>(System.Linq.Expressions.Expression expression) { return default(TResult); }
    public override string ToString() { return default(string); }
  }
}
namespace System.Data.Linq.Mapping {
  [System.AttributeUsageAttribute((System.AttributeTargets)(384), AllowMultiple=false)]
  public sealed partial class AssociationAttribute : System.Data.Linq.Mapping.DataAttribute {
    public AssociationAttribute() { }
    public bool DeleteOnNull { get { return default(bool); } set { } }
    public string DeleteRule { get { return default(string); } set { } }
    public bool IsForeignKey { get { return default(bool); } set { } }
    public bool IsUnique { get { return default(bool); } set { } }
    public string OtherKey { get { return default(string); } set { } }
    public string ThisKey { get { return default(string); } set { } }
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
    public System.Data.Linq.Mapping.AutoSync AutoSync { get { return default(System.Data.Linq.Mapping.AutoSync); } set { } }
    public bool CanBeNull { get { return default(bool); } set { } }
    public string DbType { get { return default(string); } set { } }
    public string Expression { get { return default(string); } set { } }
    public bool IsDbGenerated { get { return default(bool); } set { } }
    public bool IsDiscriminator { get { return default(bool); } set { } }
    public bool IsPrimaryKey { get { return default(bool); } set { } }
    public bool IsVersion { get { return default(bool); } set { } }
    public System.Data.Linq.Mapping.UpdateCheck UpdateCheck { get { return default(System.Data.Linq.Mapping.UpdateCheck); } set { } }
  }
  public abstract partial class DataAttribute : System.Attribute {
    protected DataAttribute() { }
    public string Name { get { return default(string); } set { } }
    public string Storage { get { return default(string); } set { } }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(4), AllowMultiple=false)]
  public sealed partial class DatabaseAttribute : System.Attribute {
    public DatabaseAttribute() { }
    public string Name { get { return default(string); } set { } }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(64), AllowMultiple=false)]
  public sealed partial class FunctionAttribute : System.Attribute {
    public FunctionAttribute() { }
    public bool IsComposable { get { return default(bool); } set { } }
    public string Name { get { return default(string); } set { } }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(4), AllowMultiple=true, Inherited=false)]
  public sealed partial class InheritanceMappingAttribute : System.Attribute {
    public InheritanceMappingAttribute() { }
    public object Code { get { return default(object); } set { } }
    public bool IsDefault { get { return default(bool); } set { } }
    public System.Type Type { get { return default(System.Type); } set { } }
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
    public virtual bool HasAssignedValue(object instance) { return default(bool); }
    public virtual bool HasLoadedValue(object instance) { return default(bool); }
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
    public string DbType { get { return default(string); } set { } }
    public string Name { get { return default(string); } set { } }
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
    public string Name { get { return default(string); } set { } }
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
  public sealed partial class Sql2000Provider : System.Data.Linq.SqlClient.SqlProvider {
    public Sql2000Provider() { }
  }
  public sealed partial class Sql2005Provider : System.Data.Linq.SqlClient.SqlProvider {
    public Sql2005Provider() { }
  }
  public sealed partial class Sql2008Provider : System.Data.Linq.SqlClient.SqlProvider {
    public Sql2008Provider() { }
  }
  public static partial class SqlHelpers {
    public static string GetStringContainsPattern(string text, char escape) { return default(string); }
    public static string GetStringEndsWithPattern(string text, char escape) { return default(string); }
    public static string GetStringStartsWithPattern(string text, char escape) { return default(string); }
    public static string TranslateVBLikePattern(string pattern, char escape) { return default(string); }
  }
  public static partial class SqlMethods {
    public static int DateDiffDay(System.DateTime startDate, System.DateTime endDate) { return default(int); }
    public static int DateDiffDay(System.DateTimeOffset startDate, System.DateTimeOffset endDate) { return default(int); }
    public static System.Nullable<System.Int32> DateDiffDay(System.Nullable<System.DateTime> startDate, System.Nullable<System.DateTime> endDate) { return default(System.Nullable<System.Int32>); }
    public static System.Nullable<System.Int32> DateDiffDay(System.Nullable<System.DateTimeOffset> startDate, System.Nullable<System.DateTimeOffset> endDate) { return default(System.Nullable<System.Int32>); }
    public static int DateDiffHour(System.DateTime startDate, System.DateTime endDate) { return default(int); }
    public static int DateDiffHour(System.DateTimeOffset startDate, System.DateTimeOffset endDate) { return default(int); }
    public static System.Nullable<System.Int32> DateDiffHour(System.Nullable<System.DateTime> startDate, System.Nullable<System.DateTime> endDate) { return default(System.Nullable<System.Int32>); }
    public static System.Nullable<System.Int32> DateDiffHour(System.Nullable<System.DateTimeOffset> startDate, System.Nullable<System.DateTimeOffset> endDate) { return default(System.Nullable<System.Int32>); }
    public static int DateDiffMicrosecond(System.DateTime startDate, System.DateTime endDate) { return default(int); }
    public static int DateDiffMicrosecond(System.DateTimeOffset startDate, System.DateTimeOffset endDate) { return default(int); }
    public static System.Nullable<System.Int32> DateDiffMicrosecond(System.Nullable<System.DateTime> startDate, System.Nullable<System.DateTime> endDate) { return default(System.Nullable<System.Int32>); }
    public static System.Nullable<System.Int32> DateDiffMicrosecond(System.Nullable<System.DateTimeOffset> startDate, System.Nullable<System.DateTimeOffset> endDate) { return default(System.Nullable<System.Int32>); }
    public static int DateDiffMillisecond(System.DateTime startDate, System.DateTime endDate) { return default(int); }
    public static int DateDiffMillisecond(System.DateTimeOffset startDate, System.DateTimeOffset endDate) { return default(int); }
    public static System.Nullable<System.Int32> DateDiffMillisecond(System.Nullable<System.DateTime> startDate, System.Nullable<System.DateTime> endDate) { return default(System.Nullable<System.Int32>); }
    public static System.Nullable<System.Int32> DateDiffMillisecond(System.Nullable<System.DateTimeOffset> startDate, System.Nullable<System.DateTimeOffset> endDate) { return default(System.Nullable<System.Int32>); }
    public static int DateDiffMinute(System.DateTime startDate, System.DateTime endDate) { return default(int); }
    public static int DateDiffMinute(System.DateTimeOffset startDate, System.DateTimeOffset endDate) { return default(int); }
    public static System.Nullable<System.Int32> DateDiffMinute(System.Nullable<System.DateTime> startDate, System.Nullable<System.DateTime> endDate) { return default(System.Nullable<System.Int32>); }
    public static System.Nullable<System.Int32> DateDiffMinute(System.Nullable<System.DateTimeOffset> startDate, System.Nullable<System.DateTimeOffset> endDate) { return default(System.Nullable<System.Int32>); }
    public static int DateDiffMonth(System.DateTime startDate, System.DateTime endDate) { return default(int); }
    public static int DateDiffMonth(System.DateTimeOffset startDate, System.DateTimeOffset endDate) { return default(int); }
    public static System.Nullable<System.Int32> DateDiffMonth(System.Nullable<System.DateTime> startDate, System.Nullable<System.DateTime> endDate) { return default(System.Nullable<System.Int32>); }
    public static System.Nullable<System.Int32> DateDiffMonth(System.Nullable<System.DateTimeOffset> startDate, System.Nullable<System.DateTimeOffset> endDate) { return default(System.Nullable<System.Int32>); }
    public static int DateDiffNanosecond(System.DateTime startDate, System.DateTime endDate) { return default(int); }
    public static int DateDiffNanosecond(System.DateTimeOffset startDate, System.DateTimeOffset endDate) { return default(int); }
    public static System.Nullable<System.Int32> DateDiffNanosecond(System.Nullable<System.DateTime> startDate, System.Nullable<System.DateTime> endDate) { return default(System.Nullable<System.Int32>); }
    public static System.Nullable<System.Int32> DateDiffNanosecond(System.Nullable<System.DateTimeOffset> startDate, System.Nullable<System.DateTimeOffset> endDate) { return default(System.Nullable<System.Int32>); }
    public static int DateDiffSecond(System.DateTime startDate, System.DateTime endDate) { return default(int); }
    public static int DateDiffSecond(System.DateTimeOffset startDate, System.DateTimeOffset endDate) { return default(int); }
    public static System.Nullable<System.Int32> DateDiffSecond(System.Nullable<System.DateTime> startDate, System.Nullable<System.DateTime> endDate) { return default(System.Nullable<System.Int32>); }
    public static System.Nullable<System.Int32> DateDiffSecond(System.Nullable<System.DateTimeOffset> startDate, System.Nullable<System.DateTimeOffset> endDate) { return default(System.Nullable<System.Int32>); }
    public static int DateDiffYear(System.DateTime startDate, System.DateTime endDate) { return default(int); }
    public static int DateDiffYear(System.DateTimeOffset startDate, System.DateTimeOffset endDate) { return default(int); }
    public static System.Nullable<System.Int32> DateDiffYear(System.Nullable<System.DateTime> startDate, System.Nullable<System.DateTime> endDate) { return default(System.Nullable<System.Int32>); }
    public static System.Nullable<System.Int32> DateDiffYear(System.Nullable<System.DateTimeOffset> startDate, System.Nullable<System.DateTimeOffset> endDate) { return default(System.Nullable<System.Int32>); }
    public static bool Like(string matchExpression, string pattern) { return default(bool); }
    public static bool Like(string matchExpression, string pattern, char escapeCharacter) { return default(bool); }
  }
  public partial class SqlProvider : System.IDisposable {
    public SqlProvider() { }
    public void Dispose() { }
    protected virtual void Dispose(bool disposing) { }
  }
}
namespace System.Data.Linq.SqlClient.Implementation {
  public abstract partial class ObjectMaterializer<TDataReader> where TDataReader : System.Data.Common.DbDataReader {
    public System.Object[] Arguments;
    public System.Data.Common.DbDataReader BufferReader;
    public TDataReader DataReader;
    public System.Object[] Globals;
    public System.Object[] Locals;
    public System.Int32[] Ordinals;
    public ObjectMaterializer() { }
    public abstract bool CanDeferLoad { get; }
    [System.Runtime.CompilerServices.IteratorStateMachineAttribute(typeof(System.Data.Linq.SqlClient.Implementation.ObjectMaterializer<TDataReader>.<Convert>d__15<TOutput>))]
    public static System.Collections.Generic.IEnumerable<TOutput> Convert<TOutput>(System.Collections.IEnumerable source) { return default(System.Collections.Generic.IEnumerable<TOutput>); }
    public static System.Linq.IGrouping<TKey, TElement> CreateGroup<TKey, TElement>(TKey key, System.Collections.Generic.IEnumerable<TElement> items) { return default(System.Linq.IGrouping<TKey, TElement>); }
    public static System.Linq.IOrderedEnumerable<TElement> CreateOrderedEnumerable<TElement>(System.Collections.Generic.IEnumerable<TElement> items) { return default(System.Linq.IOrderedEnumerable<TElement>); }
    public static System.Exception ErrorAssignmentToNull(System.Type type) { return default(System.Exception); }
    public abstract System.Collections.IEnumerable ExecuteSubQuery(int iSubQuery, System.Object[] args);
    public abstract System.Collections.Generic.IEnumerable<T> GetLinkSource<T>(int globalLink, int localFactory, System.Object[] keyValues);
    public abstract System.Collections.Generic.IEnumerable<T> GetNestedLinkSource<T>(int globalLink, int localFactory, object instance);
    public abstract object InsertLookup(int globalMetaType, object instance);
    public abstract bool Read();
    public abstract void SendEntityMaterialized(int globalMetaType, object instance);
  }
}
