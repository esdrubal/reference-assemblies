namespace IBM.Data.DB2 {
  public partial class DB2ClientUtils {
    public DB2ClientUtils() { }
    public static void DB2CheckReturn(short sqlRet, short handleType, System.IntPtr handle, string message) { }
    public static void DB2CheckReturn(short sqlRet, short handleType, System.IntPtr handle, string message, IBM.Data.DB2.DB2Connection connection) { }
  }
  public partial class DB2Command : System.ComponentModel.Component, System.Data.IDbCommand, System.ICloneable, System.IDisposable {
    public DB2Command() { }
    public DB2Command(string commandStr) { }
    public DB2Command(string commandStr, IBM.Data.DB2.DB2Connection con) { }
    public DB2Command(string commandStr, IBM.Data.DB2.DB2Connection con, IBM.Data.DB2.DB2Transaction trans) { }
    public string CommandText { get { return default(string); } set { } }
    public int CommandTimeout { get { return default(int); } set { } }
    public System.Data.CommandType CommandType { get { return default(System.Data.CommandType); } set { } }
    public IBM.Data.DB2.DB2Connection Connection { get { return default(IBM.Data.DB2.DB2Connection); } set { } }
    public IBM.Data.DB2.DB2ParameterCollection Parameters { get { return default(IBM.Data.DB2.DB2ParameterCollection); } }
    public bool SelfDescribe { get { return default(bool); } set { } }
    public System.IntPtr statementHandle { get { return default(System.IntPtr); } }
    System.Data.IDbConnection System.Data.IDbCommand.Connection { get { return default(System.Data.IDbConnection); } set { } }
    System.Data.IDataParameterCollection System.Data.IDbCommand.Parameters { get { return default(System.Data.IDataParameterCollection); } }
    System.Data.IDbTransaction System.Data.IDbCommand.Transaction { get { return default(System.Data.IDbTransaction); } set { } }
    public IBM.Data.DB2.DB2Transaction Transaction { get { return default(IBM.Data.DB2.DB2Transaction); } set { } }
    public System.Data.UpdateRowSource UpdatedRowSource { get { return default(System.Data.UpdateRowSource); } set { } }
    public void Cancel() { }
    public System.Data.IDbDataParameter CreateParameter() { return default(System.Data.IDbDataParameter); }
    public new void Dispose() { }
    protected override void Dispose(bool disposing) { }
    public int ExecuteNonQuery() { return default(int); }
    public void ExecuteNonQueryInternal(System.Data.CommandBehavior behavior) { }
    public IBM.Data.DB2.DB2DataReader ExecuteReader() { return default(IBM.Data.DB2.DB2DataReader); }
    public IBM.Data.DB2.DB2DataReader ExecuteReader(System.Data.CommandBehavior behavior) { return default(IBM.Data.DB2.DB2DataReader); }
    public object ExecuteScalar() { return default(object); }
    ~DB2Command() { }
    public void Prepare() { }
    System.Data.IDataReader System.Data.IDbCommand.ExecuteReader() { return default(System.Data.IDataReader); }
    System.Data.IDataReader System.Data.IDbCommand.ExecuteReader(System.Data.CommandBehavior behavior) { return default(System.Data.IDataReader); }
    object System.ICloneable.Clone() { return default(object); }
  }
  public sealed partial class DB2CommandBuilder : System.ComponentModel.Component {
    public DB2CommandBuilder() { }
    public DB2CommandBuilder(IBM.Data.DB2.DB2DataAdapter adapter) { }
    public IBM.Data.DB2.DB2DataAdapter DataAdapter { get { return default(IBM.Data.DB2.DB2DataAdapter); } set { } }
    public string QuotePrefix { get { return default(string); } set { } }
    public string QuoteSuffix { get { return default(string); } set { } }
    public static void DeriveParameters(IBM.Data.DB2.DB2Command command) { }
    protected override void Dispose(bool disposing) { }
    public IBM.Data.DB2.DB2Command GetDeleteCommand() { return default(IBM.Data.DB2.DB2Command); }
    public IBM.Data.DB2.DB2Command GetInsertCommand() { return default(IBM.Data.DB2.DB2Command); }
    public IBM.Data.DB2.DB2Command GetUpdateCommand() { return default(IBM.Data.DB2.DB2Command); }
    public void RefreshSchema() { }
  }
  public partial class DB2Connection : System.ComponentModel.Component, System.Data.IDbConnection, System.ICloneable, System.IDisposable {
    public DB2Connection() { }
    public DB2Connection(string conString) { }
    public string ConnectionString { get { return default(string); } set { } }
    public int ConnectionTimeout { get { return default(int); } set { } }
    public string Database { get { return default(string); } }
    public System.Data.ConnectionState State { get { return default(System.Data.ConnectionState); } }
    public event IBM.Data.DB2.DB2InfoMessageEventHandler InfoMessage { add { } remove { } }
    public event System.Data.StateChangeEventHandler StateChange { add { } remove { } }
    public IBM.Data.DB2.DB2Transaction BeginTransaction() { return default(IBM.Data.DB2.DB2Transaction); }
    public IBM.Data.DB2.DB2Transaction BeginTransaction(System.Data.IsolationLevel isolationL) { return default(IBM.Data.DB2.DB2Transaction); }
    public void ChangeDatabase(string newDBName) { }
    public void Close() { }
    public IBM.Data.DB2.DB2Command CreateCommand() { return default(IBM.Data.DB2.DB2Command); }
    public new void Dispose() { }
    protected override void Dispose(bool disposing) { }
    ~DB2Connection() { }
    public void Open() { }
    public static void ReleaseObjectPool() { }
    System.Data.IDbTransaction System.Data.IDbConnection.BeginTransaction() { return default(System.Data.IDbTransaction); }
    System.Data.IDbTransaction System.Data.IDbConnection.BeginTransaction(System.Data.IsolationLevel isolationL) { return default(System.Data.IDbTransaction); }
    System.Data.IDbCommand System.Data.IDbConnection.CreateCommand() { return default(System.Data.IDbCommand); }
    object System.ICloneable.Clone() { return default(object); }
  }
  public sealed partial class DB2DataAdapter : System.Data.Common.DbDataAdapter, System.Data.IDataAdapter, System.Data.IDbDataAdapter {
    public DB2DataAdapter() { }
    public DB2DataAdapter(IBM.Data.DB2.DB2Command selectCommand) { }
    public DB2DataAdapter(string selectCommandText, IBM.Data.DB2.DB2Connection selectConnection) { }
    public DB2DataAdapter(string selectCommandText, string selectConnectionString) { }
    public new IBM.Data.DB2.DB2Command DeleteCommand { get { return default(IBM.Data.DB2.DB2Command); } set { } }
    public new IBM.Data.DB2.DB2Command InsertCommand { get { return default(IBM.Data.DB2.DB2Command); } set { } }
    public new IBM.Data.DB2.DB2Command SelectCommand { get { return default(IBM.Data.DB2.DB2Command); } set { } }
    System.Data.ITableMappingCollection System.Data.IDataAdapter.TableMappings { get { return default(System.Data.ITableMappingCollection); } }
    System.Data.IDbCommand System.Data.IDbDataAdapter.DeleteCommand { get { return default(System.Data.IDbCommand); } set { } }
    System.Data.IDbCommand System.Data.IDbDataAdapter.InsertCommand { get { return default(System.Data.IDbCommand); } set { } }
    System.Data.IDbCommand System.Data.IDbDataAdapter.SelectCommand { get { return default(System.Data.IDbCommand); } set { } }
    System.Data.IDbCommand System.Data.IDbDataAdapter.UpdateCommand { get { return default(System.Data.IDbCommand); } set { } }
    public new IBM.Data.DB2.DB2Command UpdateCommand { get { return default(IBM.Data.DB2.DB2Command); } set { } }
    public event IBM.Data.DB2.DB2RowUpdatedEventHandler RowUpdated { add { } remove { } }
    public event IBM.Data.DB2.DB2RowUpdatingEventHandler RowUpdating { add { } remove { } }
    protected override System.Data.Common.RowUpdatedEventArgs CreateRowUpdatedEvent(System.Data.DataRow dataRow, System.Data.IDbCommand command, System.Data.StatementType statementType, System.Data.Common.DataTableMapping tableMapping) { return default(System.Data.Common.RowUpdatedEventArgs); }
    protected override System.Data.Common.RowUpdatingEventArgs CreateRowUpdatingEvent(System.Data.DataRow dataRow, System.Data.IDbCommand command, System.Data.StatementType statementType, System.Data.Common.DataTableMapping tableMapping) { return default(System.Data.Common.RowUpdatingEventArgs); }
    protected override void Dispose(bool disposing) { }
    protected override void OnRowUpdated(System.Data.Common.RowUpdatedEventArgs value) { }
    protected override void OnRowUpdating(System.Data.Common.RowUpdatingEventArgs value) { }
  }
  public sealed partial class DB2DataReader : System.MarshalByRefObject, System.Data.IDataReader, System.Data.IDataRecord, System.IDisposable {
    internal DB2DataReader() { }
    public int Depth { get { return default(int); } }
    public int FieldCount { get { return default(int); } }
    public bool HasRows { get { return default(bool); } }
    public bool IsClosed { get { return default(bool); } }
    public object this[int col] { get { return default(object); } }
    public object this[string name] { get { return default(object); } }
    public int RecordsAffected { get { return default(int); } }
    public void Close() { }
    public void Dispose() { }
    ~DB2DataReader() { }
    public bool GetBoolean(int col) { return default(bool); }
    public byte GetByte(int col) { return default(byte); }
    public long GetBytes(int col, long fieldOffset, System.Byte[] buffer, int bufferOffset, int length) { return default(long); }
    public char GetChar(int col) { return default(char); }
    public long GetChars(int col, long fieldOffset, System.Char[] buffer, int bufferOffset, int length) { return default(long); }
    public System.Data.IDataReader GetData(int col) { return default(System.Data.IDataReader); }
    public string GetDataTypeName(int col) { return default(string); }
    public System.DateTime GetDate(int col) { return default(System.DateTime); }
    public System.DateTime GetDateTime(int col) { return default(System.DateTime); }
    public decimal GetDecimal(int col) { return default(decimal); }
    public double GetDouble(int col) { return default(double); }
    public System.Type GetFieldType(int col) { return default(System.Type); }
    public float GetFloat(int col) { return default(float); }
    public System.Guid GetGuid(int col) { return default(System.Guid); }
    public short GetInt16(int col) { return default(short); }
    public int GetInt32(int col) { return default(int); }
    public long GetInt64(int col) { return default(long); }
    public string GetName(int col) { return default(string); }
    public int GetOrdinal(string name) { return default(int); }
    public System.Data.DataTable GetSchemaTable() { return default(System.Data.DataTable); }
    public string GetString(int col) { return default(string); }
    public object GetStringInternal(int col) { return default(object); }
    public System.TimeSpan GetTime(int col) { return default(System.TimeSpan); }
    public System.TimeSpan GetTimeSpan(int col) { return default(System.TimeSpan); }
    public object GetValue(int col) { return default(object); }
    public int GetValues(System.Object[] values) { return default(int); }
    public bool IsDBNull(int col) { return default(bool); }
    public bool NextResult() { return default(bool); }
    public bool Read() { return default(bool); }
  }
  public sealed partial class DB2Error {
    internal DB2Error() { }
    public string Message { get { return default(string); } }
    public int NativeError { get { return default(int); } }
    public string Source { get { return default(string); } }
    public string SQLState { get { return default(string); } }
    public override string ToString() { return default(string); }
  }
  public partial class DB2ErrorCollection : System.Collections.CollectionBase {
    public DB2ErrorCollection(short sqlHandleType, System.IntPtr sqlHandle) { }
    public IBM.Data.DB2.DB2Error this[int index] { get { return default(IBM.Data.DB2.DB2Error); } }
    public void CopyTo(IBM.Data.DB2.DB2Error[] array, int index) { }
    public new IBM.Data.DB2.DB2ErrorCollection.DB2ErrorEnumerator GetEnumerator() { return default(IBM.Data.DB2.DB2ErrorCollection.DB2ErrorEnumerator); }
    public partial class DB2ErrorEnumerator : System.Collections.IEnumerator {
      public DB2ErrorEnumerator(IBM.Data.DB2.DB2ErrorCollection mappings) { }
      public IBM.Data.DB2.DB2Error Current { get { return default(IBM.Data.DB2.DB2Error); } }
      object System.Collections.IEnumerator.Current { get { return default(object); } }
      public bool MoveNext() { return default(bool); }
      public void Reset() { }
      bool System.Collections.IEnumerator.MoveNext() { return default(bool); }
      void System.Collections.IEnumerator.Reset() { }
    }
  }
  public sealed partial class DB2Exception : System.Exception {
    internal DB2Exception() { }
    public IBM.Data.DB2.DB2ErrorCollection Errors { get { return default(IBM.Data.DB2.DB2ErrorCollection); } }
    public override string Message { get { return default(string); } }
    public override void GetObjectData(System.Runtime.Serialization.SerializationInfo si, System.Runtime.Serialization.StreamingContext context) { }
  }
  public sealed partial class DB2InfoMessageEventArgs : System.EventArgs {
    public DB2InfoMessageEventArgs(IBM.Data.DB2.DB2ErrorCollection errors) { }
    public IBM.Data.DB2.DB2ErrorCollection Errors { get { return default(IBM.Data.DB2.DB2ErrorCollection); } }
    public string Message { get { return default(string); } }
  }
  public delegate void DB2InfoMessageEventHandler(object sender, IBM.Data.DB2.DB2InfoMessageEventArgs e);
  public sealed partial class DB2Parameter : System.MarshalByRefObject, System.Data.IDataParameter, System.Data.IDbDataParameter, System.ICloneable {
    public DB2Parameter() { }
    public DB2Parameter(string name, IBM.Data.DB2.DB2Type type) { }
    public DB2Parameter(string name, IBM.Data.DB2.DB2Type type, int size) { }
    public DB2Parameter(string parameterName, IBM.Data.DB2.DB2Type db2Type, int size, System.Data.ParameterDirection parameterDirection, bool isNullable, byte precision, byte scale, string srcColumn, System.Data.DataRowVersion srcVersion, object value) { }
    public DB2Parameter(string name, IBM.Data.DB2.DB2Type type, int size, string sourceColumn) { }
    public DB2Parameter(string parameterName, object value) { }
    public IBM.Data.DB2.DB2Type DB2Type { get { return default(IBM.Data.DB2.DB2Type); } set { } }
    public System.Data.DbType DbType { get { return default(System.Data.DbType); } set { } }
    public System.Data.ParameterDirection Direction { get { return default(System.Data.ParameterDirection); } set { } }
    public bool IsNullable { get { return default(bool); } set { } }
    public string ParameterName { get { return default(string); } set { } }
    public byte Precision { get { return default(byte); } set { } }
    public byte Scale { get { return default(byte); } set { } }
    public int Size { get { return default(int); } set { } }
    public string SourceColumn { get { return default(string); } set { } }
    public System.Data.DataRowVersion SourceVersion { get { return default(System.Data.DataRowVersion); } set { } }
    public object Value { get { return default(object); } set { } }
    object System.ICloneable.Clone() { return default(object); }
  }
  public partial class DB2ParameterCollection : System.Collections.ArrayList, System.Collections.ICollection, System.Collections.IEnumerable, System.Collections.IList, System.Data.IDataParameterCollection {
    public DB2ParameterCollection() { }
    public new IBM.Data.DB2.DB2Parameter this[int index] { get { return default(IBM.Data.DB2.DB2Parameter); } set { } }
    public IBM.Data.DB2.DB2Parameter this[string index] { get { return default(IBM.Data.DB2.DB2Parameter); } set { } }
    object System.Data.IDataParameterCollection.this[string index] { get { return default(object); } set { } }
    public IBM.Data.DB2.DB2Parameter Add(IBM.Data.DB2.DB2Parameter value) { return default(IBM.Data.DB2.DB2Parameter); }
    public override int Add(object obj) { return default(int); }
    public IBM.Data.DB2.DB2Parameter Add(string paramName, IBM.Data.DB2.DB2Type type) { return default(IBM.Data.DB2.DB2Parameter); }
    public IBM.Data.DB2.DB2Parameter Add(string paramName, IBM.Data.DB2.DB2Type dbType, int size) { return default(IBM.Data.DB2.DB2Parameter); }
    public IBM.Data.DB2.DB2Parameter Add(string paramName, IBM.Data.DB2.DB2Type dbType, int size, string sourceColumn) { return default(IBM.Data.DB2.DB2Parameter); }
    public IBM.Data.DB2.DB2Parameter Add(string paramName, object value) { return default(IBM.Data.DB2.DB2Parameter); }
    public bool Contains(string paramName) { return default(bool); }
    public int IndexOf(string paramName) { return default(int); }
    public void RemoveAt(string paramName) { }
  }
  public sealed partial class DB2RowUpdatedEventArgs : System.Data.Common.RowUpdatedEventArgs {
    public DB2RowUpdatedEventArgs(System.Data.DataRow row, System.Data.IDbCommand command, System.Data.StatementType statementType, System.Data.Common.DataTableMapping tableMapping) : base (default(System.Data.DataRow), default(System.Data.IDbCommand), default(System.Data.StatementType), default(System.Data.Common.DataTableMapping)) { }
    public new IBM.Data.DB2.DB2Command Command { get { return default(IBM.Data.DB2.DB2Command); } }
  }
  public delegate void DB2RowUpdatedEventHandler(object sender, IBM.Data.DB2.DB2RowUpdatedEventArgs e);
  public sealed partial class DB2RowUpdatingEventArgs : System.Data.Common.RowUpdatingEventArgs {
    public DB2RowUpdatingEventArgs(System.Data.DataRow row, System.Data.IDbCommand command, System.Data.StatementType statementType, System.Data.Common.DataTableMapping tableMapping) : base (default(System.Data.DataRow), default(System.Data.IDbCommand), default(System.Data.StatementType), default(System.Data.Common.DataTableMapping)) { }
    public new IBM.Data.DB2.DB2Command Command { get { return default(IBM.Data.DB2.DB2Command); } set { } }
  }
  public delegate void DB2RowUpdatingEventHandler(object sender, IBM.Data.DB2.DB2RowUpdatingEventArgs e);
  public sealed partial class DB2Transaction : System.MarshalByRefObject, System.Data.IDbTransaction, System.IDisposable {
    internal DB2Transaction() { }
    public System.Data.IDbConnection Connection { get { return default(System.Data.IDbConnection); } }
    public System.Data.IsolationLevel IsolationLevel { get { return default(System.Data.IsolationLevel); } }
    public void Commit() { }
    public void Dispose() { }
    public void Rollback() { }
  }
  public enum DB2Type {
    BigInt = 3,
    Binary = 15,
    Blob = 22,
    Char = 12,
    Clob = 21,
    Datalink = 24,
    Date = 9,
    DbClob = 23,
    Decimal = 7,
    Double = 5,
    Float = 6,
    Graphic = 18,
    Integer = 2,
    Invalid = 0,
    LongVarBinary = 17,
    LongVarChar = 14,
    LongVarGraphic = 20,
    Numeric = 8,
    Real = 4,
    RowId = 25,
    SmallInt = 1,
    Time = 10,
    Timestamp = 11,
    VarBinary = 16,
    VarChar = 13,
    VarGraphic = 19,
    XmlReader = 26,
  }
  public partial class DB2TypeConverter {
    public DB2TypeConverter() { }
    public static System.Type GetManagedType(int sql_type) { return default(System.Type); }
  }
}
