namespace  {
  public partial class NpgsqlRowUpdatedEventArgs : System.Data.Common.RowUpdatedEventArgs {
    public NpgsqlRowUpdatedEventArgs(System.Data.DataRow dataRow, System.Data.IDbCommand command, System.Data.StatementType statementType, System.Data.Common.DataTableMapping tableMapping) : base (default(System.Data.DataRow), default(System.Data.IDbCommand), default(System.Data.StatementType), default(System.Data.Common.DataTableMapping)) { }
  }
  public partial class NpgsqlRowUpdatingEventArgs : System.Data.Common.RowUpdatingEventArgs {
    public NpgsqlRowUpdatingEventArgs(System.Data.DataRow dataRow, System.Data.IDbCommand command, System.Data.StatementType statementType, System.Data.Common.DataTableMapping tableMapping) : base (default(System.Data.DataRow), default(System.Data.IDbCommand), default(System.Data.StatementType), default(System.Data.Common.DataTableMapping)) { }
  }
}
namespace Npgsql {
  public enum Keywords {
    CommandTimeout = 16,
    ConnectionLifeTime = 12,
    Database = 3,
    [System.ObsoleteAttribute("UTF-8 is always used regardless of this setting.")]
    Encoding = 8,
    Enlist = 17,
    Host = 0,
    IntegratedSecurity = 20,
    MaxPoolSize = 14,
    MinPoolSize = 13,
    Password = 5,
    Pooling = 11,
    Port = 1,
    PreloadReader = 18,
    Protocol = 2,
    SearchPath = 10,
    SSL = 6,
    SslMode = 7,
    SyncNotification = 15,
    Timeout = 9,
    UseExtendedTypes = 19,
    UserName = 4,
  }
  public enum LogLevel {
    Debug = 2,
    None = 0,
    Normal = 1,
  }
  public delegate void NoticeEventHandler(object sender, Npgsql.NpgsqlNoticeEventArgs e);
  public delegate void NotificationEventHandler(object sender, Npgsql.NpgsqlNotificationEventArgs e);
  public sealed partial class NpgsqlCommand : System.ComponentModel.Component, System.Data.IDbCommand, System.ICloneable, System.IDisposable {
    public NpgsqlCommand() { }
    public NpgsqlCommand(string cmdText) { }
    public NpgsqlCommand(string cmdText, Npgsql.NpgsqlConnection connection) { }
    public NpgsqlCommand(string cmdText, Npgsql.NpgsqlConnection connection, Npgsql.NpgsqlTransaction transaction) { }
    [System.ComponentModel.CategoryAttribute("Data")]
    [System.ComponentModel.DefaultValueAttribute("")]
    public string CommandText { get { return default(string); } set { } }
    [System.ComponentModel.DefaultValueAttribute(20)]
    public int CommandTimeout { get { return default(int); } set { } }
    [System.ComponentModel.CategoryAttribute("Data")]
    [System.ComponentModel.DefaultValueAttribute((System.Data.CommandType)(1))]
    public System.Data.CommandType CommandType { get { return default(System.Data.CommandType); } set { } }
    [System.ComponentModel.CategoryAttribute("Behavior")]
    [System.ComponentModel.DefaultValueAttribute(null)]
    public Npgsql.NpgsqlConnection Connection { get { return default(Npgsql.NpgsqlConnection); } set { } }
    public long LastInsertedOID { get { return default(long); } }
    public Npgsql.NpgsqlParameterCollection Parameters { get { return default(Npgsql.NpgsqlParameterCollection); } }
    System.Data.IDbConnection System.Data.IDbCommand.Connection { get { return default(System.Data.IDbConnection); } set { } }
    System.Data.IDataParameterCollection System.Data.IDbCommand.Parameters { get { return default(System.Data.IDataParameterCollection); } }
    System.Data.IDbTransaction System.Data.IDbCommand.Transaction { get { return default(System.Data.IDbTransaction); } set { } }
    public Npgsql.NpgsqlTransaction Transaction { get { return default(Npgsql.NpgsqlTransaction); } set { } }
    public System.Data.UpdateRowSource UpdatedRowSource { get { return default(System.Data.UpdateRowSource); } set { } }
    public void Cancel() { }
    public Npgsql.NpgsqlCommand Clone() { return default(Npgsql.NpgsqlCommand); }
    public Npgsql.NpgsqlParameter CreateParameter() { return default(Npgsql.NpgsqlParameter); }
    public int ExecuteNonQuery() { return default(int); }
    public Npgsql.NpgsqlDataReader ExecuteReader() { return default(Npgsql.NpgsqlDataReader); }
    public Npgsql.NpgsqlDataReader ExecuteReader(System.Data.CommandBehavior cb) { return default(Npgsql.NpgsqlDataReader); }
    public object ExecuteScalar() { return default(object); }
    public void Prepare() { }
    System.Data.IDbDataParameter System.Data.IDbCommand.CreateParameter() { return default(System.Data.IDbDataParameter); }
    System.Data.IDataReader System.Data.IDbCommand.ExecuteReader() { return default(System.Data.IDataReader); }
    System.Data.IDataReader System.Data.IDbCommand.ExecuteReader(System.Data.CommandBehavior cb) { return default(System.Data.IDataReader); }
    object System.ICloneable.Clone() { return default(object); }
  }
  public sealed partial class NpgsqlCommandBuilder : System.ComponentModel.Component {
    public NpgsqlCommandBuilder() { }
    public NpgsqlCommandBuilder(Npgsql.NpgsqlDataAdapter adapter) { }
    public Npgsql.NpgsqlDataAdapter DataAdapter { get { return default(Npgsql.NpgsqlDataAdapter); } set { } }
    public string QuotePrefix { get { return default(string); } set { } }
    public string QuoteSuffix { get { return default(string); } set { } }
    public static void DeriveParameters(Npgsql.NpgsqlCommand command) { }
    protected override void Dispose(bool disposing) { }
    public Npgsql.NpgsqlCommand GetDeleteCommand(System.Data.DataRow row) { return default(Npgsql.NpgsqlCommand); }
    public Npgsql.NpgsqlCommand GetInsertCommand(System.Data.DataRow row) { return default(Npgsql.NpgsqlCommand); }
    public Npgsql.NpgsqlCommand GetUpdateCommand(System.Data.DataRow row) { return default(Npgsql.NpgsqlCommand); }
    public void RefreshSchema() { }
  }
  public sealed partial class NpgsqlConnection : System.ComponentModel.Component, System.Data.IDbConnection, System.ICloneable, System.IDisposable {
    public NpgsqlConnection() { }
    public NpgsqlConnection(string ConnectionString) { }
    [System.ComponentModel.BrowsableAttribute(false)]
    public Npgsql.ProtocolVersion BackendProtocolVersion { get { return default(Npgsql.ProtocolVersion); } }
    public int ConnectionLifeTime { get { return default(int); } }
    public string ConnectionString { get { return default(string); } set { } }
    public int ConnectionTimeout { get { return default(int); } }
    public string Database { get { return default(string); } }
    [System.ComponentModel.BrowsableAttribute(true)]
    public string Host { get { return default(string); } }
    [System.ComponentModel.BrowsableAttribute(true)]
    public int Port { get { return default(int); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    public Npgsql.ServerVersion ServerVersion { get { return default(Npgsql.ServerVersion); } }
    [System.ComponentModel.BrowsableAttribute(true)]
    public bool SSL { get { return default(bool); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    public System.Data.ConnectionState State { get { return default(System.Data.ConnectionState); } }
    public bool SyncNotification { get { return default(bool); } }
    public event Mono.Security.Protocol.Tls.CertificateSelectionCallback CertificateSelectionCallback { add { } remove { } }
    public event Mono.Security.Protocol.Tls.CertificateValidationCallback CertificateValidationCallback { add { } remove { } }
    public event Npgsql.NoticeEventHandler Notice { add { } remove { } }
    public event Npgsql.NotificationEventHandler Notification { add { } remove { } }
    public event Mono.Security.Protocol.Tls.PrivateKeySelectionCallback PrivateKeySelectionCallback { add { } remove { } }
    public Npgsql.NpgsqlTransaction BeginTransaction() { return default(Npgsql.NpgsqlTransaction); }
    public Npgsql.NpgsqlTransaction BeginTransaction(System.Data.IsolationLevel level) { return default(Npgsql.NpgsqlTransaction); }
    public void ChangeDatabase(string dbName) { }
    public void ClearAllPools() { }
    public void ClearPool() { }
    public Npgsql.NpgsqlConnection Clone() { return default(Npgsql.NpgsqlConnection); }
    public void Close() { }
    public Npgsql.NpgsqlCommand CreateCommand() { return default(Npgsql.NpgsqlCommand); }
    protected override void Dispose(bool disposing) { }
    public System.Data.DataTable GetSchema() { return default(System.Data.DataTable); }
    public System.Data.DataTable GetSchema(string collectionName) { return default(System.Data.DataTable); }
    public System.Data.DataTable GetSchema(string collectionName, System.String[] restrictions) { return default(System.Data.DataTable); }
    public void Open() { }
    System.Data.IDbTransaction System.Data.IDbConnection.BeginTransaction() { return default(System.Data.IDbTransaction); }
    System.Data.IDbTransaction System.Data.IDbConnection.BeginTransaction(System.Data.IsolationLevel level) { return default(System.Data.IDbTransaction); }
    System.Data.IDbCommand System.Data.IDbConnection.CreateCommand() { return default(System.Data.IDbCommand); }
    object System.ICloneable.Clone() { return default(object); }
  }
  public sealed partial class NpgsqlConnectionStringBuilder : System.Data.Common.DbConnectionStringBuilder {
    public NpgsqlConnectionStringBuilder() { }
    public NpgsqlConnectionStringBuilder(string connectionString) { }
    public int CommandTimeout { get { return default(int); } set { } }
    public int ConnectionLifeTime { get { return default(int); } set { } }
    public string Database { get { return default(string); } set { } }
    [System.ObsoleteAttribute("UTF-8 is always used regardless of this setting.")]
    public string Encoding { get { return default(string); } }
    public bool Enlist { get { return default(bool); } set { } }
    public string Host { get { return default(string); } set { } }
    public bool IntegratedSecurity { get { return default(bool); } set { } }
    public object this[Npgsql.Keywords keyword] { get { return default(object); } set { } }
    public override object this[string keyword] { get { return default(object); } set { } }
    public int MaxPoolSize { get { return default(int); } set { } }
    public int MinPoolSize { get { return default(int); } set { } }
    public string Password { get { return default(string); } set { } }
    public bool Pooling { get { return default(bool); } set { } }
    public int Port { get { return default(int); } set { } }
    public bool PreloadReader { get { return default(bool); } set { } }
    public Npgsql.ProtocolVersion Protocol { get { return default(Npgsql.ProtocolVersion); } set { } }
    public string SearchPath { get { return default(string); } set { } }
    public bool SSL { get { return default(bool); } set { } }
    public Npgsql.SslMode SslMode { get { return default(Npgsql.SslMode); } set { } }
    public bool SyncNotification { get { return default(bool); } set { } }
    public int Timeout { get { return default(int); } set { } }
    public bool UseExtendedTypes { get { return default(bool); } set { } }
    public string UserName { get { return default(string); } set { } }
    public override void Clear() { }
    public Npgsql.NpgsqlConnectionStringBuilder Clone() { return default(Npgsql.NpgsqlConnectionStringBuilder); }
    public bool ContainsKey(Npgsql.Keywords keyword) { return default(bool); }
    public override bool Remove(string keyword) { return default(bool); }
  }
  public sealed partial class NpgsqlDataAdapter : System.Data.Common.DbDataAdapter, System.Data.IDataAdapter, System.Data.IDbDataAdapter {
    public NpgsqlDataAdapter() { }
    public NpgsqlDataAdapter(Npgsql.NpgsqlCommand selectCommand) { }
    public NpgsqlDataAdapter(string selectCommandText, Npgsql.NpgsqlConnection selectConnection) { }
    public NpgsqlDataAdapter(string selectCommandText, string selectConnectionString) { }
    public new Npgsql.NpgsqlCommand DeleteCommand { get { return default(Npgsql.NpgsqlCommand); } set { } }
    public new Npgsql.NpgsqlCommand InsertCommand { get { return default(Npgsql.NpgsqlCommand); } set { } }
    public new Npgsql.NpgsqlCommand SelectCommand { get { return default(Npgsql.NpgsqlCommand); } set { } }
    System.Data.ITableMappingCollection System.Data.IDataAdapter.TableMappings { get { return default(System.Data.ITableMappingCollection); } }
    System.Data.IDbCommand System.Data.IDbDataAdapter.DeleteCommand { get { return default(System.Data.IDbCommand); } set { } }
    System.Data.IDbCommand System.Data.IDbDataAdapter.InsertCommand { get { return default(System.Data.IDbCommand); } set { } }
    System.Data.IDbCommand System.Data.IDbDataAdapter.SelectCommand { get { return default(System.Data.IDbCommand); } set { } }
    System.Data.IDbCommand System.Data.IDbDataAdapter.UpdateCommand { get { return default(System.Data.IDbCommand); } set { } }
    public new Npgsql.NpgsqlCommand UpdateCommand { get { return default(Npgsql.NpgsqlCommand); } set { } }
    public event Npgsql.NpgsqlRowUpdatedEventHandler RowUpdated { add { } remove { } }
    public event Npgsql.NpgsqlRowUpdatingEventHandler RowUpdating { add { } remove { } }
    protected override System.Data.Common.RowUpdatedEventArgs CreateRowUpdatedEvent(System.Data.DataRow dataRow, System.Data.IDbCommand command, System.Data.StatementType statementType, System.Data.Common.DataTableMapping tableMapping) { return default(System.Data.Common.RowUpdatedEventArgs); }
    protected override System.Data.Common.RowUpdatingEventArgs CreateRowUpdatingEvent(System.Data.DataRow dataRow, System.Data.IDbCommand command, System.Data.StatementType statementType, System.Data.Common.DataTableMapping tableMapping) { return default(System.Data.Common.RowUpdatingEventArgs); }
    protected override void OnRowUpdated(System.Data.Common.RowUpdatedEventArgs value) { }
    protected override void OnRowUpdating(System.Data.Common.RowUpdatingEventArgs value) { }
  }
  public sealed partial class NpgsqlDataReader : System.Collections.IEnumerable, System.Data.IDataReader, System.Data.IDataRecord, System.IDisposable {
    internal NpgsqlDataReader() { }
    public int Depth { get { return default(int); } }
    public int FieldCount { get { return default(int); } }
    public bool HasRows { get { return default(bool); } }
    public bool IsClosed { get { return default(bool); } }
    public object this[int i] { get { return default(object); } }
    public object this[string name] { get { return default(object); } }
    public int RecordsAffected { get { return default(int); } }
    public event System.EventHandler ReaderClosed { add { } remove { } }
    public void Close() { }
    public void Dispose() { }
    protected void Dispose(bool disposing) { }
    public bool GetBoolean(int i) { return default(bool); }
    public byte GetByte(int i) { return default(byte); }
    public long GetBytes(int i, long fieldOffset, System.Byte[] buffer, int bufferoffset, int length) { return default(long); }
    public char GetChar(int i) { return default(char); }
    public long GetChars(int i, long fieldoffset, System.Char[] buffer, int bufferoffset, int length) { return default(long); }
    public System.Data.IDataReader GetData(int i) { return default(System.Data.IDataReader); }
    public string GetDataTypeName(int Index) { return default(string); }
    public string GetDataTypeOID(int Index) { return default(string); }
    public System.DateTime GetDateTime(int i) { return default(System.DateTime); }
    public decimal GetDecimal(int i) { return default(decimal); }
    public double GetDouble(int i) { return default(double); }
    public System.Data.DbType GetFieldDbType(int Index) { return default(System.Data.DbType); }
    public NpgsqlTypes.NpgsqlDbType GetFieldNpgsqlDbType(int Index) { return default(NpgsqlTypes.NpgsqlDbType); }
    public System.Type GetFieldType(int Index) { return default(System.Type); }
    public float GetFloat(int i) { return default(float); }
    public System.Guid GetGuid(int i) { return default(System.Guid); }
    public short GetInt16(int i) { return default(short); }
    public int GetInt32(int i) { return default(int); }
    public long GetInt64(int i) { return default(long); }
    public string GetName(int Index) { return default(string); }
    public int GetOrdinal(string Name) { return default(int); }
    public System.Data.DataTable GetSchemaTable() { return default(System.Data.DataTable); }
    public string GetString(int i) { return default(string); }
    public object GetValue(int Index) { return default(object); }
    public int GetValues(System.Object[] Values) { return default(int); }
    public bool IsDBNull(int i) { return default(bool); }
    public bool NextResult() { return default(bool); }
    public bool Read() { return default(bool); }
    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { return default(System.Collections.IEnumerator); }
  }
  public sealed partial class NpgsqlError {
    internal NpgsqlError() { }
    public string Code { get { return default(string); } }
    public string Detail { get { return default(string); } }
    public string ErrorSql { get { return default(string); } set { } }
    public string File { get { return default(string); } }
    public string Hint { get { return default(string); } }
    public string Line { get { return default(string); } }
    public string Message { get { return default(string); } }
    public string Position { get { return default(string); } }
    public string Routine { get { return default(string); } }
    public string Severity { get { return default(string); } }
    public string Where { get { return default(string); } }
    public override string ToString() { return default(string); }
  }
  public partial class NpgsqlEventLog {
    internal NpgsqlEventLog() { }
    public static bool EchoMessages { get { return default(bool); } set { } }
    public static Npgsql.LogLevel Level { get { return default(Npgsql.LogLevel); } set { } }
    public static string LogName { get { return default(string); } set { } }
  }
  public sealed partial class NpgsqlException : System.ApplicationException {
    internal NpgsqlException() { }
    public string BaseMessage { get { return default(string); } }
    public string Code { get { return default(string); } }
    public string Detail { get { return default(string); } }
    public System.Collections.IList Errors { get { return default(System.Collections.IList); } }
    public string ErrorSql { get { return default(string); } }
    public string File { get { return default(string); } }
    public string Hint { get { return default(string); } }
    public Npgsql.NpgsqlError this[int Index] { get { return default(Npgsql.NpgsqlError); } }
    public string Line { get { return default(string); } }
    public string Position { get { return default(string); } }
    public string Routine { get { return default(string); } }
    public string Severity { get { return default(string); } }
    public string Where { get { return default(string); } }
    public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public override string ToString() { return default(string); }
  }
  public sealed partial class NpgsqlFactory : System.Data.Common.DbProviderFactory, System.IServiceProvider {
    internal NpgsqlFactory() { }
    public static Npgsql.NpgsqlFactory Instance;
    public override System.Data.Common.DbCommand CreateCommand() { return default(System.Data.Common.DbCommand); }
    public override System.Data.Common.DbCommandBuilder CreateCommandBuilder() { return default(System.Data.Common.DbCommandBuilder); }
    public override System.Data.Common.DbConnection CreateConnection() { return default(System.Data.Common.DbConnection); }
    public override System.Data.Common.DbConnectionStringBuilder CreateConnectionStringBuilder() { return default(System.Data.Common.DbConnectionStringBuilder); }
    public override System.Data.Common.DbDataAdapter CreateDataAdapter() { return default(System.Data.Common.DbDataAdapter); }
    public override System.Data.Common.DbParameter CreateParameter() { return default(System.Data.Common.DbParameter); }
    public object GetService(System.Type serviceType) { return default(object); }
  }
  public partial class NpgsqlNoticeEventArgs : System.EventArgs {
    internal NpgsqlNoticeEventArgs() { }
    public Npgsql.NpgsqlError Notice;
  }
  public partial class NpgsqlNotificationEventArgs : System.EventArgs {
    internal NpgsqlNotificationEventArgs() { }
    public string Condition;
    public int PID;
  }
  public sealed partial class NpgsqlParameter : System.MarshalByRefObject, System.Data.IDataParameter, System.Data.IDbDataParameter, System.ICloneable {
    public NpgsqlParameter() { }
    public NpgsqlParameter(string parameterName, NpgsqlTypes.NpgsqlDbType parameterType) { }
    public NpgsqlParameter(string parameterName, NpgsqlTypes.NpgsqlDbType parameterType, int size) { }
    public NpgsqlParameter(string parameterName, NpgsqlTypes.NpgsqlDbType parameterType, int size, string sourceColumn) { }
    public NpgsqlParameter(string parameterName, NpgsqlTypes.NpgsqlDbType parameterType, int size, string sourceColumn, System.Data.ParameterDirection direction, bool isNullable, byte precision, byte scale, System.Data.DataRowVersion sourceVersion, object value) { }
    public NpgsqlParameter(string parameterName, System.Data.DbType parameterType) { }
    public NpgsqlParameter(string parameterName, System.Data.DbType parameterType, int size) { }
    public NpgsqlParameter(string parameterName, System.Data.DbType parameterType, int size, string sourceColumn) { }
    public NpgsqlParameter(string parameterName, System.Data.DbType parameterType, int size, string sourceColumn, System.Data.ParameterDirection direction, bool isNullable, byte precision, byte scale, System.Data.DataRowVersion sourceVersion, object value) { }
    public NpgsqlParameter(string parameterName, object value) { }
    [System.ComponentModel.CategoryAttribute("Data")]
    [System.ComponentModel.DefaultValueAttribute((System.Data.DbType)(16))]
    [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
    public System.Data.DbType DbType { get { return default(System.Data.DbType); } set { } }
    [System.ComponentModel.CategoryAttribute("Data")]
    [System.ComponentModel.DefaultValueAttribute((System.Data.ParameterDirection)(1))]
    public System.Data.ParameterDirection Direction { get { return default(System.Data.ParameterDirection); } set { } }
    public bool IsNullable { get { return default(bool); } set { } }
    [System.ComponentModel.CategoryAttribute("Data")]
    [System.ComponentModel.DefaultValueAttribute((NpgsqlTypes.NpgsqlDbType)(18))]
    [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
    public NpgsqlTypes.NpgsqlDbType NpgsqlDbType { get { return default(NpgsqlTypes.NpgsqlDbType); } set { } }
    [System.ComponentModel.DefaultValueAttribute("")]
    public string ParameterName { get { return default(string); } set { } }
    [System.ComponentModel.CategoryAttribute("Data")]
    [System.ComponentModel.DefaultValueAttribute((byte)0)]
    public byte Precision { get { return default(byte); } set { } }
    [System.ComponentModel.CategoryAttribute("Data")]
    [System.ComponentModel.DefaultValueAttribute((byte)0)]
    public byte Scale { get { return default(byte); } set { } }
    [System.ComponentModel.CategoryAttribute("Data")]
    [System.ComponentModel.DefaultValueAttribute(0)]
    public int Size { get { return default(int); } set { } }
    [System.ComponentModel.CategoryAttribute("Data")]
    [System.ComponentModel.DefaultValueAttribute("")]
    public string SourceColumn { get { return default(string); } set { } }
    [System.ComponentModel.CategoryAttribute("Data")]
    [System.ComponentModel.DefaultValueAttribute((System.Data.DataRowVersion)(512))]
    public System.Data.DataRowVersion SourceVersion { get { return default(System.Data.DataRowVersion); } set { } }
    [System.ComponentModel.CategoryAttribute("Data")]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.ComponentModel.StringConverter))]
    public object Value { get { return default(object); } set { } }
    object System.ICloneable.Clone() { return default(object); }
  }
  public sealed partial class NpgsqlParameterCollection : System.MarshalByRefObject, System.Collections.ICollection, System.Collections.IEnumerable, System.Collections.IList, System.Data.IDataParameterCollection {
    internal NpgsqlParameterCollection() { }
    public int Count { get { return default(int); } }
    public Npgsql.NpgsqlParameter this[int index] { get { return default(Npgsql.NpgsqlParameter); } set { } }
    public Npgsql.NpgsqlParameter this[string parameterName] { get { return default(Npgsql.NpgsqlParameter); } set { } }
    bool System.Collections.ICollection.IsSynchronized { get { return default(bool); } }
    object System.Collections.ICollection.SyncRoot { get { return default(object); } }
    bool System.Collections.IList.IsFixedSize { get { return default(bool); } }
    bool System.Collections.IList.IsReadOnly { get { return default(bool); } }
    object System.Collections.IList.this[int index] { get { return default(object); } set { } }
    object System.Data.IDataParameterCollection.this[string parameterName] { get { return default(object); } set { } }
    public Npgsql.NpgsqlParameter Add(Npgsql.NpgsqlParameter value) { return default(Npgsql.NpgsqlParameter); }
    public int Add(object value) { return default(int); }
    public Npgsql.NpgsqlParameter Add(string parameterName, NpgsqlTypes.NpgsqlDbType parameterType) { return default(Npgsql.NpgsqlParameter); }
    public Npgsql.NpgsqlParameter Add(string parameterName, NpgsqlTypes.NpgsqlDbType parameterType, int size) { return default(Npgsql.NpgsqlParameter); }
    public Npgsql.NpgsqlParameter Add(string parameterName, NpgsqlTypes.NpgsqlDbType parameterType, int size, string sourceColumn) { return default(Npgsql.NpgsqlParameter); }
    public Npgsql.NpgsqlParameter Add(string parameterName, object value) { return default(Npgsql.NpgsqlParameter); }
    public void Clear() { }
    public bool Contains(object value) { return default(bool); }
    public bool Contains(string parameterName) { return default(bool); }
    public void CopyTo(System.Array array, int index) { }
    public int IndexOf(object value) { return default(int); }
    public int IndexOf(string parameterName) { return default(int); }
    public void Insert(int index, object value) { }
    public void Remove(object value) { }
    public void RemoveAt(int index) { }
    public void RemoveAt(string parameterName) { }
    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { return default(System.Collections.IEnumerator); }
    public bool TryGetValue(string parameterName, out Npgsql.NpgsqlParameter parameter) { parameter = default(Npgsql.NpgsqlParameter); return default(bool); }
  }
  public delegate void NpgsqlRowUpdatedEventHandler(object sender, NpgsqlRowUpdatedEventArgs e);
  public delegate void NpgsqlRowUpdatingEventHandler(object sender, NpgsqlRowUpdatingEventArgs e);
  public sealed partial class NpgsqlTransaction : System.MarshalByRefObject, System.Data.IDbTransaction, System.IDisposable {
    internal NpgsqlTransaction() { }
    public Npgsql.NpgsqlConnection Connection { get { return default(Npgsql.NpgsqlConnection); } }
    public System.Data.IsolationLevel IsolationLevel { get { return default(System.Data.IsolationLevel); } }
    System.Data.IDbConnection System.Data.IDbTransaction.Connection { get { return default(System.Data.IDbConnection); } }
    public void Commit() { }
    public void Dispose() { }
    ~NpgsqlTransaction() { }
    public void Rollback() { }
  }
  public enum ProtocolVersion {
    Unknown = 0,
    Version2 = 1,
    Version3 = 2,
  }
  public sealed partial class ServerVersion {
    internal ServerVersion() { }
    public static readonly int ProtocolVersion2;
    public static readonly int ProtocolVersion3;
    public int Major { get { return default(int); } }
    public int Minor { get { return default(int); } }
    public int Patch { get { return default(int); } }
    public override bool Equals(object O) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public static bool operator ==(Npgsql.ServerVersion One, Npgsql.ServerVersion TheOther) { return default(bool); }
    public static bool operator >(Npgsql.ServerVersion One, Npgsql.ServerVersion TheOther) { return default(bool); }
    public static bool operator >=(Npgsql.ServerVersion One, Npgsql.ServerVersion TheOther) { return default(bool); }
    public static bool operator !=(Npgsql.ServerVersion One, Npgsql.ServerVersion TheOther) { return default(bool); }
    public static bool operator <(Npgsql.ServerVersion One, Npgsql.ServerVersion TheOther) { return default(bool); }
    public static bool operator <=(Npgsql.ServerVersion One, Npgsql.ServerVersion TheOther) { return default(bool); }
    public override string ToString() { return default(string); }
  }
  public enum SslMode {
    Allow = 2,
    Disable = 1,
    Prefer = 4,
    Require = 8,
  }
}
namespace NpgsqlTypes {
  public partial class Fastpath {
    protected Npgsql.NpgsqlConnection conn;
    protected System.Collections.Hashtable func;
    protected System.IO.Stream stream;
    public Fastpath(Npgsql.NpgsqlConnection conn) { }
    public Fastpath(Npgsql.NpgsqlConnection conn, System.IO.Stream stream) { }
    public void AddFunction(string name, int fnid) { }
    public void AddFunctions(System.Data.IDataReader rs) { }
    public object FastpathCall(int fnid, bool resulttype, NpgsqlTypes.FastpathArg[] args) { return default(object); }
    public object FastpathCall(string name, bool resulttype, NpgsqlTypes.FastpathArg[] args) { return default(object); }
    public System.Byte[] GetData(string name, NpgsqlTypes.FastpathArg[] args) { return default(System.Byte[]); }
    public int GetID(string name) { return default(int); }
    public int GetInteger(string name, NpgsqlTypes.FastpathArg[] args) { return default(int); }
  }
  public partial class FastpathArg {
    public System.Byte[] bytes;
    public bool type;
    public int value;
    public FastpathArg(System.Byte[] bytes) { }
    public FastpathArg(System.Byte[] buf, int off, int len) { }
    public FastpathArg(int value) { }
    public FastpathArg(string s) { }
    public void Send(System.IO.Stream s) { }
    public int SendSize() { return default(int); }
  }
  public partial class LargeObject {
    public const int SEEK_CUR = 1;
    public const int SEEK_END = 2;
    public const int SEEK_SET = 0;
    public LargeObject(NpgsqlTypes.Fastpath fp, int oid, int mode) { }
    public void Close() { }
    public int GetOID() { return default(int); }
    public int Read(System.Byte[] buf, int off, int len) { return default(int); }
    public System.Byte[] Read(int len) { return default(System.Byte[]); }
    public void Seek(int pos) { }
    public void Seek(int pos, int refi) { }
    public int Size() { return default(int); }
    public int Tell() { return default(int); }
    public void Write(System.Byte[] buf) { }
    public void Write(System.Byte[] buf, int off, int len) { }
  }
  public partial class LargeObjectManager {
    public static int READ;
    public static int READWRITE;
    public const int WRITE = 131072;
    public LargeObjectManager(Npgsql.NpgsqlConnection conn) { }
    public int Create() { return default(int); }
    public int Create(int mode) { return default(int); }
    public void Delete(int oid) { }
    public NpgsqlTypes.LargeObject Open(int oid) { return default(NpgsqlTypes.LargeObject); }
    public NpgsqlTypes.LargeObject Open(int oid, int mode) { return default(NpgsqlTypes.LargeObject); }
    public void Unlink(int oid) { }
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct NpgsqlBox {
    public NpgsqlBox(NpgsqlTypes.NpgsqlPoint UpperRight, NpgsqlTypes.NpgsqlPoint LowerLeft) { throw new System.NotImplementedException(); }
    public NpgsqlTypes.NpgsqlPoint LowerLeft { get { return default(NpgsqlTypes.NpgsqlPoint); } set { } }
    public NpgsqlTypes.NpgsqlPoint UpperRight { get { return default(NpgsqlTypes.NpgsqlPoint); } set { } }
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct NpgsqlCircle {
    public NpgsqlTypes.NpgsqlPoint Center;
    public double Radius;
    public NpgsqlCircle(NpgsqlTypes.NpgsqlPoint Center, double Radius) { throw new System.NotImplementedException(); }
    public override string ToString() { return default(string); }
  }
  public enum NpgsqlDbType {
    Bigint = 0,
    Bit = 24,
    Boolean = 1,
    Box = 2,
    Bytea = 3,
    Char = 5,
    Circle = 4,
    Date = 6,
    Double = 7,
    Inet = 23,
    Integer = 8,
    Line = 9,
    LSeg = 10,
    Money = 11,
    Numeric = 12,
    Path = 13,
    Point = 14,
    Polygon = 15,
    Real = 16,
    Refcursor = 22,
    Smallint = 17,
    Text = 18,
    Time = 19,
    Timestamp = 20,
    TimestampTZ = 25,
    Varchar = 21,
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct NpgsqlInet {
    public System.Net.IPAddress addr;
    public int mask;
    public NpgsqlInet(System.Net.IPAddress addr) { throw new System.NotImplementedException(); }
    public NpgsqlInet(System.Net.IPAddress addr, int mask) { throw new System.NotImplementedException(); }
    public NpgsqlInet(string addr) { throw new System.NotImplementedException(); }
    public static implicit operator System.Net.IPAddress (NpgsqlTypes.NpgsqlInet x) { return default(System.Net.IPAddress); }
    public override string ToString() { return default(string); }
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct NpgsqlLSeg {
    public NpgsqlTypes.NpgsqlPoint End;
    public NpgsqlTypes.NpgsqlPoint Start;
    public NpgsqlLSeg(NpgsqlTypes.NpgsqlPoint Start, NpgsqlTypes.NpgsqlPoint End) { throw new System.NotImplementedException(); }
    public override string ToString() { return default(string); }
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct NpgsqlPath {
    public NpgsqlPath(NpgsqlTypes.NpgsqlPoint[] Points) { throw new System.NotImplementedException(); }
    public int Count { get { return default(int); } }
    public NpgsqlTypes.NpgsqlPoint this[int Index] { get { return default(NpgsqlTypes.NpgsqlPoint); } }
    public bool Open { get { return default(bool); } }
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct NpgsqlPoint {
    public NpgsqlPoint(float X, float Y) { throw new System.NotImplementedException(); }
    public float X { get { return default(float); } set { } }
    public float Y { get { return default(float); } set { } }
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct NpgsqlPolygon {
    public NpgsqlPolygon(NpgsqlTypes.NpgsqlPoint[] Points) { throw new System.NotImplementedException(); }
    public int Count { get { return default(int); } }
    public NpgsqlTypes.NpgsqlPoint this[int Index] { get { return default(NpgsqlTypes.NpgsqlPoint); } }
  }
}
