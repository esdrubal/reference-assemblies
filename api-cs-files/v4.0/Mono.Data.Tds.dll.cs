namespace Mono.Data.Tds {
  public delegate object FrameworkValueGetter(object rawValue, ref bool updated);
  public partial class TdsMetaParameter {
    public const int maxNVarCharCharacters = 1073741823;
    public const int maxVarCharCharacters = 2147483647;
    public TdsMetaParameter(string name, Mono.Data.Tds.FrameworkValueGetter valueGetter) { }
    public TdsMetaParameter(string name, int size, bool isNullable, byte precision, byte scale, Mono.Data.Tds.FrameworkValueGetter valueGetter) { }
    public TdsMetaParameter(string name, int size, bool isNullable, byte precision, byte scale, object value) { }
    public TdsMetaParameter(string name, object value) { }
    public TdsMetaParameter(string name, string typeName, object value) { }
    public Mono.Data.Tds.TdsParameterDirection Direction { get { return default(Mono.Data.Tds.TdsParameterDirection); } set { } }
    public bool IsAnyVarCharMax { get { return default(bool); } }
    public bool IsDateTimeType { get { return default(bool); } }
    public bool IsDecimalType { get { return default(bool); } }
    public bool IsMoneyType { get { return default(bool); } }
    public bool IsNonUnicodeText { get { return default(bool); } }
    public bool IsNullable { get { return default(bool); } set { } }
    public bool IsTextType { get { return default(bool); } }
    public bool IsVarCharMax { get { return default(bool); } }
    public bool IsVariableSizeType { get { return default(bool); } set { } }
    public bool IsVarNVarCharMax { get { return default(bool); } }
    public string ParameterName { get { return default(string); } set { } }
    public byte Precision { get { return default(byte); } set { } }
    public object RawValue { get { return default(object); } set { } }
    public byte Scale { get { return default(byte); } set { } }
    public int Size { get { return default(int); } set { } }
    public string TypeName { get { return default(string); } set { } }
    public object Value { get { return default(object); } set { } }
    public void CalculateIsVariableType() { }
    public void Validate(int index) { }
  }
  public partial class TdsMetaParameterCollection : System.Collections.ICollection, System.Collections.IEnumerable {
    public TdsMetaParameterCollection() { }
    public int Count { get { return default(int); } }
    public bool IsSynchronized { get { return default(bool); } }
    public Mono.Data.Tds.TdsMetaParameter this[int index] { get { return default(Mono.Data.Tds.TdsMetaParameter); } }
    public Mono.Data.Tds.TdsMetaParameter this[string name] { get { return default(Mono.Data.Tds.TdsMetaParameter); } }
    public object SyncRoot { get { return default(object); } }
    public int Add(Mono.Data.Tds.TdsMetaParameter value) { return default(int); }
    public void Clear() { }
    public bool Contains(Mono.Data.Tds.TdsMetaParameter value) { return default(bool); }
    public void CopyTo(System.Array array, int index) { }
    public int IndexOf(Mono.Data.Tds.TdsMetaParameter value) { return default(int); }
    public int IndexOf(string name) { return default(int); }
    public void Insert(int index, Mono.Data.Tds.TdsMetaParameter value) { }
    public void Remove(Mono.Data.Tds.TdsMetaParameter value) { }
    public void Remove(string name) { }
    public void RemoveAt(int index) { }
    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { return default(System.Collections.IEnumerator); }
  }
  public enum TdsParameterDirection {
    Input = 0,
    InputOutput = 2,
    Output = 1,
    ReturnValue = 3,
  }
}
namespace Mono.Data.Tds.Protocol {
  public abstract partial class Tds {
    protected internal Mono.Data.Tds.Protocol.TdsConnectionParameters connectionParms;
    protected Mono.Data.Tds.Protocol.TdsInternalErrorCollection messages;
    protected readonly System.Byte[] NTLMSSP_ID;
    public Tds(string dataSource, int port, int packetSize, int timeout, Mono.Data.Tds.Protocol.TdsVersion tdsVersion) { }
    public Tds(string dataSource, int port, int packetSize, int timeout, int lifeTime, Mono.Data.Tds.Protocol.TdsVersion tdsVersion) { }
    protected string Charset { get { return default(string); } }
    public System.Byte[] Collation { get { return default(System.Byte[]); } }
    protected System.Collections.ArrayList ColumnNames { get { return default(System.Collections.ArrayList); } }
    public Mono.Data.Tds.Protocol.TdsDataColumnCollection Columns { get { return default(Mono.Data.Tds.Protocol.TdsDataColumnCollection); } }
    public Mono.Data.Tds.Protocol.TdsDataRow ColumnValues { get { return default(Mono.Data.Tds.Protocol.TdsDataRow); } }
    public string Database { get { return default(string); } }
    public string DataSource { get { return default(string); } }
    public bool DoneProc { get { return default(bool); } }
    public virtual bool IsConnected { get { return default(bool); } set { } }
    protected string Language { get { return default(string); } }
    protected System.Globalization.CultureInfo Locale { get { return default(System.Globalization.CultureInfo); } }
    public bool MoreResults { get { return default(bool); } set { } }
    public System.Collections.ArrayList OutputParameters { get { return default(System.Collections.ArrayList); } set { } }
    public int PacketSize { get { return default(int); } }
    protected Mono.Data.Tds.TdsMetaParameterCollection Parameters { get { return default(Mono.Data.Tds.TdsMetaParameterCollection); } set { } }
    public bool Pooling { get { return default(bool); } set { } }
    public int RecordsAffected { get { return default(int); } set { } }
    public bool SequentialAccess { get { return default(bool); } set { } }
    public Mono.Data.Tds.Protocol.TdsVersion ServerTdsVersion { get { return default(Mono.Data.Tds.Protocol.TdsVersion); } }
    public string ServerVersion { get { return default(string); } }
    public Mono.Data.Tds.Protocol.TdsVersion TdsVersion { get { return default(Mono.Data.Tds.Protocol.TdsVersion); } }
    public event Mono.Data.Tds.Protocol.TdsInternalErrorMessageEventHandler TdsErrorMessage { add { } remove { } }
    public event Mono.Data.Tds.Protocol.TdsInternalInfoMessageEventHandler TdsInfoMessage { add { } remove { } }
    public virtual System.IAsyncResult BeginExecuteNonQuery(string sql, Mono.Data.Tds.TdsMetaParameterCollection parameters, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    public virtual System.IAsyncResult BeginExecuteProcedure(string prolog, string epilog, string cmdText, bool IsNonQuery, Mono.Data.Tds.TdsMetaParameterCollection parameters, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    public virtual System.IAsyncResult BeginExecuteQuery(string sql, Mono.Data.Tds.TdsMetaParameterCollection parameters, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    protected System.IAsyncResult BeginExecuteQueryInternal(string sql, bool wantResults, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    public void Cancel() { }
    public void CheckAndThrowException(System.IAsyncResult ar) { }
    [System.MonoTODOAttribute("Is cancel enough, or do we need to drop the connection?")]
    protected void CheckForData(int timeout) { }
    public abstract bool Connect(Mono.Data.Tds.Protocol.TdsConnectionParameters connectionParameters);
    protected Mono.Data.Tds.Protocol.TdsInternalErrorMessageEventArgs CreateTdsErrorMessageEvent(byte theClass, int lineNumber, string message, int number, string procedure, string server, string source, byte state) { return default(Mono.Data.Tds.Protocol.TdsInternalErrorMessageEventArgs); }
    protected Mono.Data.Tds.Protocol.TdsInternalInfoMessageEventArgs CreateTdsInfoMessageEvent(Mono.Data.Tds.Protocol.TdsInternalErrorCollection errors) { return default(Mono.Data.Tds.Protocol.TdsInternalInfoMessageEventArgs); }
    public static Mono.Data.Tds.Protocol.TdsTimeoutException CreateTimeoutException(string dataSource, string method) { return default(Mono.Data.Tds.Protocol.TdsTimeoutException); }
    public virtual void Disconnect() { }
    public virtual void EndExecuteNonQuery(System.IAsyncResult ar) { }
    public virtual void EndExecuteProcedure(System.IAsyncResult ar) { }
    public virtual void EndExecuteQuery(System.IAsyncResult ar) { }
    protected void EndExecuteQueryInternal(System.IAsyncResult ar) { }
    public virtual void ExecPrepared(string sql, Mono.Data.Tds.TdsMetaParameterCollection parameters, int timeout, bool wantResults) { }
    public void ExecProc(string sql) { }
    public virtual void ExecProc(string sql, Mono.Data.Tds.TdsMetaParameterCollection parameters, int timeout, bool wantResults) { }
    protected virtual void ExecRPC(string rpcName, Mono.Data.Tds.TdsMetaParameterCollection parameters, int timeout, bool wantResults) { }
    public void Execute(string sql) { }
    public virtual void Execute(string sql, Mono.Data.Tds.TdsMetaParameterCollection parameters, int timeout, bool wantResults) { }
    protected void ExecuteQuery(string sql, int timeout, bool wantResults) { }
    protected object GetColumnValue(System.Nullable<Mono.Data.Tds.Protocol.TdsColumnType> colType, bool outParam) { return default(object); }
    public object GetSequentialColumnValue(int colIndex) { return default(object); }
    public long GetSequentialColumnValue(int colIndex, long fieldIndex, System.Byte[] buffer, int bufferIndex, int size) { return default(long); }
    protected object GetStringValue(bool wideChars, int len, System.Text.Encoding enc) { return default(object); }
    protected object GetStringValue(System.Nullable<Mono.Data.Tds.Protocol.TdsColumnType> colType, bool wideChars, bool outputParam, System.Text.Encoding encoder) { return default(object); }
    protected int GetSubPacketLength() { return default(int); }
    protected virtual void InitComm(int port, int timeout) { }
    protected internal void InitExec() { }
    protected virtual bool IsValidRowCount(byte status, byte op) { return default(bool); }
    protected bool IsWideType(Mono.Data.Tds.Protocol.TdsColumnType columnType) { return default(bool); }
    protected void LoadRow() { }
    public bool NextResult() { return default(bool); }
    public bool NextRow() { return default(bool); }
    protected void OnBeginExecuteQueryCallback(System.IAsyncResult ar) { }
    protected void OnTdsErrorMessage(Mono.Data.Tds.Protocol.TdsInternalErrorMessageEventArgs e) { }
    protected void OnTdsInfoMessage(Mono.Data.Tds.Protocol.TdsInternalInfoMessageEventArgs e) { }
    public virtual string Prepare(string sql, Mono.Data.Tds.TdsMetaParameterCollection parameters) { return default(string); }
    protected internal int ProcessAuthentication() { return default(int); }
    protected void ProcessColumnDetail() { }
    protected abstract void ProcessColumnInfo();
    protected void ProcessColumnNames() { }
    protected void ProcessDynamic() { }
    [System.MonoTODOAttribute("Make sure counting works right, especially with multiple resultsets.")]
    protected void ProcessEndToken(Mono.Data.Tds.Protocol.TdsPacketSubType type) { }
    protected void ProcessEnvironmentChange() { }
    protected void ProcessLoginAck() { }
    protected void ProcessMessage(Mono.Data.Tds.Protocol.TdsPacketSubType subType) { }
    protected virtual void ProcessOutputParam() { }
    protected virtual void ProcessReturnStatus() { }
    protected virtual Mono.Data.Tds.Protocol.TdsPacketSubType ProcessSubPacket() { return default(Mono.Data.Tds.Protocol.TdsPacketSubType); }
    protected void ProcessTableName() { }
    public virtual bool Reset() { return default(bool); }
    protected void SetCharset(string charset) { }
    protected void SetCharset(System.Text.Encoding encoder) { }
    protected void SetLanguage(string language) { }
    public void SkipToEnd() { }
    public virtual void Unprepare(string statementId) { }
    public void WaitFor(System.IAsyncResult ar) { }
  }
  public sealed partial class Tds42 : Mono.Data.Tds.Protocol.Tds {
    public static readonly Mono.Data.Tds.Protocol.TdsVersion Version;
    public Tds42(string server, int port) : base (default(string), default(int), default(int), default(int), default(Mono.Data.Tds.Protocol.TdsVersion)) { }
    public Tds42(string server, int port, int packetSize, int timeout) : base (default(string), default(int), default(int), default(int), default(Mono.Data.Tds.Protocol.TdsVersion)) { }
    public override bool Connect(Mono.Data.Tds.Protocol.TdsConnectionParameters connectionParameters) { return default(bool); }
    protected override void ProcessColumnInfo() { }
  }
  [System.MonoTODOAttribute("FIXME: Can packetsize be anything other than 512?")]
  public sealed partial class Tds50 : Mono.Data.Tds.Protocol.Tds {
    public static readonly Mono.Data.Tds.Protocol.TdsVersion Version;
    public Tds50(string server, int port) : base (default(string), default(int), default(int), default(int), default(Mono.Data.Tds.Protocol.TdsVersion)) { }
    public Tds50(string server, int port, int packetSize, int timeout) : base (default(string), default(int), default(int), default(int), default(Mono.Data.Tds.Protocol.TdsVersion)) { }
    public string BuildExec(string sql) { return default(string); }
    public override bool Connect(Mono.Data.Tds.Protocol.TdsConnectionParameters connectionParameters) { return default(bool); }
    public override void ExecPrepared(string id, Mono.Data.Tds.TdsMetaParameterCollection parameters, int timeout, bool wantResults) { }
    public override void ExecProc(string commandText, Mono.Data.Tds.TdsMetaParameterCollection parameters, int timeout, bool wantResults) { }
    public override void Execute(string sql, Mono.Data.Tds.TdsMetaParameterCollection parameters, int timeout, bool wantResults) { }
    protected override bool IsValidRowCount(byte status, byte op) { return default(bool); }
    public override string Prepare(string sql, Mono.Data.Tds.TdsMetaParameterCollection parameters) { return default(string); }
    protected override void ProcessColumnInfo() { }
    public override void Unprepare(string statementId) { }
  }
  public partial class Tds70 : Mono.Data.Tds.Protocol.Tds {
    [System.ObsoleteAttribute("Use the constructor that receives a lifetime parameter")]
    public Tds70(string server, int port) : base (default(string), default(int), default(int), default(int), default(Mono.Data.Tds.Protocol.TdsVersion)) { }
    public Tds70(string server, int port, int lifetime) : base (default(string), default(int), default(int), default(int), default(Mono.Data.Tds.Protocol.TdsVersion)) { }
    [System.ObsoleteAttribute("Use the constructor that receives a lifetime parameter")]
    public Tds70(string server, int port, int packetSize, int timeout) : base (default(string), default(int), default(int), default(int), default(Mono.Data.Tds.Protocol.TdsVersion)) { }
    [System.ObsoleteAttribute("Use the constructor that receives a lifetime parameter")]
    public Tds70(string server, int port, int packetSize, int timeout, Mono.Data.Tds.Protocol.TdsVersion version) : base (default(string), default(int), default(int), default(int), default(Mono.Data.Tds.Protocol.TdsVersion)) { }
    public Tds70(string server, int port, int packetSize, int timeout, int lifeTime) : base (default(string), default(int), default(int), default(int), default(Mono.Data.Tds.Protocol.TdsVersion)) { }
    public Tds70(string server, int port, int packetSize, int timeout, int lifeTime, Mono.Data.Tds.Protocol.TdsVersion version) : base (default(string), default(int), default(int), default(int), default(Mono.Data.Tds.Protocol.TdsVersion)) { }
    protected virtual System.Byte[] ClientVersion { get { return default(System.Byte[]); } }
    protected virtual byte Precision { get { return default(byte); } }
    public override System.IAsyncResult BeginExecuteNonQuery(string cmdText, Mono.Data.Tds.TdsMetaParameterCollection parameters, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    public override System.IAsyncResult BeginExecuteProcedure(string prolog, string epilog, string cmdText, bool IsNonQuery, Mono.Data.Tds.TdsMetaParameterCollection parameters, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    public override System.IAsyncResult BeginExecuteQuery(string cmdText, Mono.Data.Tds.TdsMetaParameterCollection parameters, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    protected string BuildExec(string sql) { return default(string); }
    public override bool Connect(Mono.Data.Tds.Protocol.TdsConnectionParameters connectionParameters) { return default(bool); }
    public override void EndExecuteNonQuery(System.IAsyncResult ar) { }
    public override void EndExecuteProcedure(System.IAsyncResult ar) { }
    public override void EndExecuteQuery(System.IAsyncResult ar) { }
    public override void ExecPrepared(string commandText, Mono.Data.Tds.TdsMetaParameterCollection parameters, int timeout, bool wantResults) { }
    public override void ExecProc(string commandText, Mono.Data.Tds.TdsMetaParameterCollection parameters, int timeout, bool wantResults) { }
    protected void ExecRPC(Mono.Data.Tds.Protocol.TdsRpcProcId rpcId, string sql, Mono.Data.Tds.TdsMetaParameterCollection parameters, int timeout, bool wantResults) { }
    protected override void ExecRPC(string rpcName, Mono.Data.Tds.TdsMetaParameterCollection parameters, int timeout, bool wantResults) { }
    public override void Execute(string commandText, Mono.Data.Tds.TdsMetaParameterCollection parameters, int timeout, bool wantResults) { }
    protected override bool IsValidRowCount(byte status, byte op) { return default(bool); }
    public override string Prepare(string commandText, Mono.Data.Tds.TdsMetaParameterCollection parameters) { return default(string); }
    protected override void ProcessColumnInfo() { }
    protected override void ProcessReturnStatus() { }
    public override bool Reset() { return default(bool); }
    public override void Unprepare(string statementId) { }
  }
  public partial class Tds80 : Mono.Data.Tds.Protocol.Tds70 {
    public static readonly Mono.Data.Tds.Protocol.TdsVersion Version;
    [System.ObsoleteAttribute("Use the constructor that receives a lifetime parameter")]
    public Tds80(string server, int port) : base (default(string), default(int)) { }
    public Tds80(string server, int port, int lifetime) : base (default(string), default(int)) { }
    [System.ObsoleteAttribute("Use the constructor that receives a lifetime parameter")]
    public Tds80(string server, int port, int packetSize, int timeout) : base (default(string), default(int)) { }
    public Tds80(string server, int port, int packetSize, int timeout, int lifeTime) : base (default(string), default(int)) { }
    protected override System.Byte[] ClientVersion { get { return default(System.Byte[]); } }
    protected override byte Precision { get { return default(byte); } }
    public override bool Connect(Mono.Data.Tds.Protocol.TdsConnectionParameters connectionParameters) { return default(bool); }
    public override void ExecPrepared(string commandText, Mono.Data.Tds.TdsMetaParameterCollection parameters, int timeout, bool wantResults) { }
    public override void Execute(string commandText, Mono.Data.Tds.TdsMetaParameterCollection parameters, int timeout, bool wantResults) { }
    protected override void ProcessColumnInfo() { }
    protected override void ProcessOutputParam() { }
  }
  public partial class TdsBigDecimal {
    public TdsBigDecimal(byte precision, byte scale, bool isNegative, System.Int32[] data) { }
    public System.Int32[] Data { get { return default(System.Int32[]); } }
    public bool IsNegative { get { return default(bool); } }
    public byte Precision { get { return default(byte); } }
    public byte Scale { get { return default(byte); } }
  }
  public partial class TdsBulkCopy {
    public TdsBulkCopy(Mono.Data.Tds.Protocol.Tds tds) { }
    public bool BulkCopyData(object o, bool isNewRow, int size, Mono.Data.Tds.TdsMetaParameter parameter) { return default(bool); }
    public bool BulkCopyEnd() { return default(bool); }
    public bool BulkCopyStart(Mono.Data.Tds.TdsMetaParameterCollection parameters) { return default(bool); }
    public bool SendColumnMetaData(string colMetaData) { return default(bool); }
  }
  public enum TdsColumnStatus {
    Hidden = 16,
    IsExpression = 4,
    IsKey = 8,
    Rename = 32,
  }
  public enum TdsColumnType {
    BigBinary = 173,
    BigChar = 175,
    BigInt = 127,
    BigNVarChar = 231,
    BigVarBinary = 165,
    BigVarChar = 167,
    Binary = 45,
    Bit = 50,
    BitN = 104,
    Char = 47,
    DateTime = 61,
    DateTime4 = 58,
    DateTimeN = 111,
    Decimal = 106,
    Float8 = 62,
    FloatN = 109,
    Image = 34,
    Int1 = 48,
    Int2 = 52,
    Int4 = 56,
    IntN = 38,
    Money = 60,
    Money4 = 112,
    MoneyN = 110,
    NChar = 239,
    NText = 99,
    Numeric = 108,
    NVarChar = 103,
    Real = 59,
    SmallMoney = 122,
    Text = 35,
    UniqueIdentifier = 36,
    VarBinary = 37,
    VarChar = 39,
    Variant = 98,
    Void = 31,
  }
  public partial class TdsConnectionInfo {
    public string DataSource;
    public int LifeTime;
    public int PacketSize;
    public int PoolMaxSize;
    public int PoolMinSize;
    public int Port;
    public int Timeout;
    [System.ObsoleteAttribute("Use the constructor that receives a lifetime parameter")]
    public TdsConnectionInfo(string dataSource, int port, int packetSize, int timeout, int minSize, int maxSize) { }
    public TdsConnectionInfo(string dataSource, int port, int packetSize, int timeout, int minSize, int maxSize, int lifeTime) { }
    public override string ToString() { return default(string); }
  }
  public partial class TdsConnectionParameters {
    public string ApplicationName;
    public string AttachDBFileName;
    public string Charset;
    public string Database;
    public string DefaultDomain;
    public bool DomainLogin;
    public string Hostname;
    public string Language;
    public string LibraryName;
    public string Password;
    public string ProgName;
    public string User;
    public TdsConnectionParameters() { }
    public void Reset() { }
  }
  public partial class TdsConnectionPool {
    public TdsConnectionPool(Mono.Data.Tds.Protocol.TdsConnectionPoolManager manager, Mono.Data.Tds.Protocol.TdsConnectionInfo info) { }
    public bool Pooling { get { return default(bool); } set { } }
    public Mono.Data.Tds.Protocol.Tds GetConnection() { return default(Mono.Data.Tds.Protocol.Tds); }
    public void ReleaseConnection(Mono.Data.Tds.Protocol.Tds connection) { }
    public void ResetConnectionPool() { }
  }
  public partial class TdsConnectionPoolManager {
    public TdsConnectionPoolManager(Mono.Data.Tds.Protocol.TdsVersion version) { }
    public virtual Mono.Data.Tds.Protocol.Tds CreateConnection(Mono.Data.Tds.Protocol.TdsConnectionInfo info) { return default(Mono.Data.Tds.Protocol.Tds); }
    public System.Collections.IDictionary GetConnectionPool() { return default(System.Collections.IDictionary); }
    public Mono.Data.Tds.Protocol.TdsConnectionPool GetConnectionPool(string connectionString) { return default(Mono.Data.Tds.Protocol.TdsConnectionPool); }
    public Mono.Data.Tds.Protocol.TdsConnectionPool GetConnectionPool(string connectionString, Mono.Data.Tds.Protocol.TdsConnectionInfo info) { return default(Mono.Data.Tds.Protocol.TdsConnectionPool); }
  }
  public partial class TdsDataColumn {
    public TdsDataColumn() { }
    public System.Nullable<System.Boolean> AllowDBNull { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Nullable<System.Boolean>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public string BaseCatalogName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public string BaseColumnName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public string BaseSchemaName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public string BaseServerName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public string BaseTableName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public string ColumnName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Nullable<System.Int32> ColumnOrdinal { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Nullable<System.Int32>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Nullable<System.Int32> ColumnSize { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Nullable<System.Int32>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Nullable<Mono.Data.Tds.Protocol.TdsColumnType> ColumnType { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Nullable<Mono.Data.Tds.Protocol.TdsColumnType>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public string DataTypeName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Nullable<System.Boolean> IsAliased { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Nullable<System.Boolean>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Nullable<System.Boolean> IsAutoIncrement { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Nullable<System.Boolean>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Nullable<System.Boolean> IsExpression { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Nullable<System.Boolean>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Nullable<System.Boolean> IsHidden { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Nullable<System.Boolean>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Nullable<System.Boolean> IsIdentity { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Nullable<System.Boolean>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Nullable<System.Boolean> IsKey { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Nullable<System.Boolean>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Nullable<System.Boolean> IsReadOnly { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Nullable<System.Boolean>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Nullable<System.Boolean> IsRowVersion { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Nullable<System.Boolean>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Nullable<System.Boolean> IsUnique { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Nullable<System.Boolean>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public object this[string key] { get { return default(object); } set { } }
    public System.Nullable<System.Int32> LCID { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Nullable<System.Int32>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Nullable<System.Int16> NumericPrecision { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Nullable<System.Int16>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Nullable<System.Int16> NumericScale { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Nullable<System.Int16>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Nullable<System.Int32> SortOrder { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Nullable<System.Int32>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
  }
  public partial class TdsDataColumnCollection : System.Collections.IEnumerable {
    public TdsDataColumnCollection() { }
    public int Count { get { return default(int); } }
    public Mono.Data.Tds.Protocol.TdsDataColumn this[int index] { get { return default(Mono.Data.Tds.Protocol.TdsDataColumn); } set { } }
    public int Add(Mono.Data.Tds.Protocol.TdsDataColumn schema) { return default(int); }
    public void Add(Mono.Data.Tds.Protocol.TdsDataColumnCollection columns) { }
    public void Clear() { }
    public System.Collections.IEnumerator GetEnumerator() { return default(System.Collections.IEnumerator); }
  }
  public partial class TdsDataRow : System.Collections.ICollection, System.Collections.IEnumerable, System.Collections.IList {
    public TdsDataRow() { }
    public int BigDecimalIndex { get { return default(int); } set { } }
    public int Count { get { return default(int); } }
    public bool IsFixedSize { get { return default(bool); } }
    public bool IsReadOnly { get { return default(bool); } }
    public bool IsSynchronized { get { return default(bool); } }
    public object this[int index] { get { return default(object); } set { } }
    public object SyncRoot { get { return default(object); } }
    public int Add(object value) { return default(int); }
    public void Clear() { }
    public bool Contains(object value) { return default(bool); }
    public void CopyTo(System.Array array, int index) { }
    public void CopyTo(int index, System.Array array, int arrayIndex, int count) { }
    public System.Collections.IEnumerator GetEnumerator() { return default(System.Collections.IEnumerator); }
    public int IndexOf(object value) { return default(int); }
    public void Insert(int index, object value) { }
    public void Remove(object value) { }
    public void RemoveAt(int index) { }
  }
  public enum TdsEnvPacketSubType {
    BlockSize = 4,
    CharSet = 3,
    CollationInfo = 7,
    Database = 1,
    Locale = 5,
  }
  public sealed partial class TdsInternalError {
    public TdsInternalError(byte theClass, int lineNumber, string message, int number, string procedure, string server, string source, byte state) { }
    public byte Class { get { return default(byte); } set { } }
    public int LineNumber { get { return default(int); } set { } }
    public string Message { get { return default(string); } set { } }
    public int Number { get { return default(int); } set { } }
    public string Procedure { get { return default(string); } set { } }
    public string Server { get { return default(string); } set { } }
    public string Source { get { return default(string); } set { } }
    public byte State { get { return default(byte); } set { } }
  }
  public sealed partial class TdsInternalErrorCollection : System.Collections.IEnumerable {
    public TdsInternalErrorCollection() { }
    public int Count { get { return default(int); } }
    public Mono.Data.Tds.Protocol.TdsInternalError this[int index] { get { return default(Mono.Data.Tds.Protocol.TdsInternalError); } set { } }
    public int Add(Mono.Data.Tds.Protocol.TdsInternalError error) { return default(int); }
    public void Clear() { }
    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { return default(System.Collections.IEnumerator); }
  }
  public sealed partial class TdsInternalErrorMessageEventArgs : Mono.Data.Tds.Protocol.TdsInternalInfoMessageEventArgs {
    public TdsInternalErrorMessageEventArgs(Mono.Data.Tds.Protocol.TdsInternalError error) : base (default(Mono.Data.Tds.Protocol.TdsInternalErrorCollection)) { }
  }
  public delegate void TdsInternalErrorMessageEventHandler(object sender, Mono.Data.Tds.Protocol.TdsInternalErrorMessageEventArgs e);
  public partial class TdsInternalException : System.SystemException {
    internal TdsInternalException() { }
    public byte Class { get { return default(byte); } }
    public int LineNumber { get { return default(int); } }
    public override string Message { get { return default(string); } }
    public int Number { get { return default(int); } }
    public string Procedure { get { return default(string); } }
    public string Server { get { return default(string); } }
    public override string Source { get { return default(string); } }
    public byte State { get { return default(byte); } }
    [System.MonoTODOAttribute]
    public override void GetObjectData(System.Runtime.Serialization.SerializationInfo si, System.Runtime.Serialization.StreamingContext context) { }
  }
  public partial class TdsInternalInfoMessageEventArgs : System.EventArgs {
    public TdsInternalInfoMessageEventArgs(Mono.Data.Tds.Protocol.TdsInternalError error) { }
    public TdsInternalInfoMessageEventArgs(Mono.Data.Tds.Protocol.TdsInternalErrorCollection errors) { }
    public byte Class { get { return default(byte); } }
    public Mono.Data.Tds.Protocol.TdsInternalErrorCollection Errors { get { return default(Mono.Data.Tds.Protocol.TdsInternalErrorCollection); } }
    public int LineNumber { get { return default(int); } }
    public string Message { get { return default(string); } }
    public int Number { get { return default(int); } }
    public string Procedure { get { return default(string); } }
    public string Server { get { return default(string); } }
    public string Source { get { return default(string); } }
    public byte State { get { return default(byte); } }
    public int Add(byte theClass, int lineNumber, string message, int number, string procedure, string server, string source, byte state) { return default(int); }
  }
  public delegate void TdsInternalInfoMessageEventHandler(object sender, Mono.Data.Tds.Protocol.TdsInternalInfoMessageEventArgs e);
  public enum TdsPacketSubType {
    AltFormat = 168,
    AltName = 167,
    Authentication = 237,
    Capability = 226,
    ColumnDetail = 165,
    ColumnInfo = 161,
    ColumnMetadata = 129,
    ColumnName = 160,
    ColumnOrder = 169,
    Control = 174,
    Done = 253,
    DoneInProc = 255,
    DoneProc = 254,
    Dynamic = 231,
    Dynamic2 = 163,
    EED = 229,
    EnvironmentChange = 227,
    Error = 170,
    Info = 171,
    LoginAck = 173,
    Param = 172,
    Parameters = 215,
    ParamFormat = 236,
    ProcId = 124,
    ReturnStatus = 121,
    Row = 209,
    RowFormat = 238,
    TableName = 164,
  }
  public enum TdsPacketType {
    Bulk = 7,
    Cancel = 6,
    DBRPC = 230,
    Logoff = 113,
    Logon = 2,
    Logon70 = 16,
    None = 0,
    Normal = 15,
    Proc = 3,
    Query = 1,
    Reply = 4,
    RPC = 3,
    SspAuth = 17,
  }
  public enum TdsRpcProcId {
    Cursor = 1,
    CursorClose = 9,
    CursorExecute = 4,
    CursorFetch = 7,
    CursorOpen = 2,
    CursorOption = 8,
    CursorPrepare = 3,
    CursorPrepExec = 5,
    CursorUnprepare = 6,
    Execute = 12,
    ExecuteSql = 10,
    Prepare = 11,
    PrepExec = 13,
    PrepExecRpc = 14,
    Unprepare = 15,
  }
  public partial class TdsTimeoutException : Mono.Data.Tds.Protocol.TdsInternalException {
    internal TdsTimeoutException() { }
  }
  public enum TdsVersion {
    tds100 = 100,
    tds42 = 42,
    tds50 = 50,
    tds70 = 70,
    tds80 = 80,
    tds81 = 81,
    tds90 = 90,
  }
}
