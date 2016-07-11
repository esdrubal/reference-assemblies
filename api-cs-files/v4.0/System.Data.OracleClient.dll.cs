namespace System.Data.OracleClient {
  public sealed partial class OracleBFile : System.IO.Stream, System.Data.SqlTypes.INullable, System.ICloneable, System.IDisposable {
    internal OracleBFile() { }
    public static readonly new System.Data.OracleClient.OracleBFile Null;
    public override bool CanRead { get { return default(bool); } }
    public override bool CanSeek { get { return default(bool); } }
    public override bool CanWrite { get { return default(bool); } }
    public System.Data.OracleClient.OracleConnection Connection { get { return default(System.Data.OracleClient.OracleConnection); } }
    public string DirectoryName { [System.MonoTODOAttribute]get { return default(string); } }
    public bool FileExists { [System.MonoTODOAttribute]get { return default(bool); } }
    public string FileName { [System.MonoTODOAttribute]get { return default(string); } }
    public bool IsNull { get { return default(bool); } }
    public override long Length { [System.MonoTODOAttribute]get { return default(long); } }
    public override long Position { [System.MonoTODOAttribute]get { return default(long); } [System.MonoTODOAttribute]set { } }
    public object Value { [System.MonoTODOAttribute]get { return default(object); } }
    [System.MonoTODOAttribute]
    public object Clone() { return default(object); }
    [System.MonoTODOAttribute]
    public long CopyTo(System.Data.OracleClient.OracleLob destination) { return default(long); }
    [System.MonoTODOAttribute]
    public long CopyTo(System.Data.OracleClient.OracleLob destination, long destinationOffset) { return default(long); }
    [System.MonoTODOAttribute]
    public long CopyTo(long sourceOffset, System.Data.OracleClient.OracleLob destination, long destinationOffset, long amount) { return default(long); }
    protected override void Dispose(bool disposing) { }
    [System.MonoTODOAttribute]
    public override void Flush() { }
    [System.MonoTODOAttribute]
    public override int Read(System.Byte[] buffer, int offset, int count) { return default(int); }
    [System.MonoTODOAttribute]
    public override long Seek(long offset, System.IO.SeekOrigin origin) { return default(long); }
    [System.MonoTODOAttribute]
    public void SetFileName(string directory, string file) { }
    [System.MonoTODOAttribute]
    public override void SetLength(long value) { }
    [System.MonoTODOAttribute]
    public override void Write(System.Byte[] buffer, int offset, int count) { }
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct OracleBinary : System.Data.SqlTypes.INullable, System.IComparable {
    public static readonly System.Data.OracleClient.OracleBinary Null;
    public OracleBinary(System.Byte[] b) { throw new System.NotImplementedException(); }
    public bool IsNull { get { return default(bool); } }
    public byte this[int index] { get { return default(byte); } }
    public int Length { get { return default(int); } }
    public System.Byte[] Value { get { return default(System.Byte[]); } }
    [System.MonoTODOAttribute]
    public int CompareTo(object obj) { return default(int); }
    [System.MonoTODOAttribute]
    public static System.Data.OracleClient.OracleBinary Concat(System.Data.OracleClient.OracleBinary x, System.Data.OracleClient.OracleBinary y) { return default(System.Data.OracleClient.OracleBinary); }
    public static System.Data.OracleClient.OracleBoolean Equals(System.Data.OracleClient.OracleBinary x, System.Data.OracleClient.OracleBinary y) { return default(System.Data.OracleClient.OracleBoolean); }
    [System.MonoTODOAttribute]
    public override bool Equals(object value) { return default(bool); }
    [System.MonoTODOAttribute]
    public override int GetHashCode() { return default(int); }
    [System.MonoTODOAttribute]
    public static System.Data.OracleClient.OracleBoolean GreaterThan(System.Data.OracleClient.OracleBinary x, System.Data.OracleClient.OracleBinary y) { return default(System.Data.OracleClient.OracleBoolean); }
    [System.MonoTODOAttribute]
    public static System.Data.OracleClient.OracleBoolean GreaterThanOrEqual(System.Data.OracleClient.OracleBinary x, System.Data.OracleClient.OracleBinary y) { return default(System.Data.OracleClient.OracleBoolean); }
    [System.MonoTODOAttribute]
    public static System.Data.OracleClient.OracleBoolean LessThan(System.Data.OracleClient.OracleBinary x, System.Data.OracleClient.OracleBinary y) { return default(System.Data.OracleClient.OracleBoolean); }
    [System.MonoTODOAttribute]
    public static System.Data.OracleClient.OracleBoolean LessThanOrEqual(System.Data.OracleClient.OracleBinary x, System.Data.OracleClient.OracleBinary y) { return default(System.Data.OracleClient.OracleBoolean); }
    [System.MonoTODOAttribute]
    public static System.Data.OracleClient.OracleBoolean NotEquals(System.Data.OracleClient.OracleBinary x, System.Data.OracleClient.OracleBinary y) { return default(System.Data.OracleClient.OracleBoolean); }
    public static System.Data.OracleClient.OracleBinary operator +(System.Data.OracleClient.OracleBinary x, System.Data.OracleClient.OracleBinary y) { return default(System.Data.OracleClient.OracleBinary); }
    public static System.Data.OracleClient.OracleBoolean operator ==(System.Data.OracleClient.OracleBinary x, System.Data.OracleClient.OracleBinary y) { return default(System.Data.OracleClient.OracleBoolean); }
    public static explicit operator System.Byte[] (System.Data.OracleClient.OracleBinary x) { return default(System.Byte[]); }
    public static System.Data.OracleClient.OracleBoolean operator >(System.Data.OracleClient.OracleBinary x, System.Data.OracleClient.OracleBinary y) { return default(System.Data.OracleClient.OracleBoolean); }
    public static System.Data.OracleClient.OracleBoolean operator >=(System.Data.OracleClient.OracleBinary x, System.Data.OracleClient.OracleBinary y) { return default(System.Data.OracleClient.OracleBoolean); }
    public static implicit operator System.Data.OracleClient.OracleBinary (System.Byte[] b) { return default(System.Data.OracleClient.OracleBinary); }
    public static System.Data.OracleClient.OracleBoolean operator !=(System.Data.OracleClient.OracleBinary x, System.Data.OracleClient.OracleBinary y) { return default(System.Data.OracleClient.OracleBoolean); }
    public static System.Data.OracleClient.OracleBoolean operator <(System.Data.OracleClient.OracleBinary x, System.Data.OracleClient.OracleBinary y) { return default(System.Data.OracleClient.OracleBoolean); }
    public static System.Data.OracleClient.OracleBoolean operator <=(System.Data.OracleClient.OracleBinary x, System.Data.OracleClient.OracleBinary y) { return default(System.Data.OracleClient.OracleBoolean); }
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct OracleBoolean : System.IComparable {
    public static readonly System.Data.OracleClient.OracleBoolean False;
    public static readonly System.Data.OracleClient.OracleBoolean Null;
    public static readonly System.Data.OracleClient.OracleBoolean One;
    public static readonly System.Data.OracleClient.OracleBoolean True;
    public static readonly System.Data.OracleClient.OracleBoolean Zero;
    public OracleBoolean(bool value) { throw new System.NotImplementedException(); }
    public OracleBoolean(int value) { throw new System.NotImplementedException(); }
    public bool IsFalse { get { return default(bool); } }
    public bool IsNull { get { return default(bool); } }
    public bool IsTrue { get { return default(bool); } }
    public bool Value { get { return default(bool); } }
    public static System.Data.OracleClient.OracleBoolean And(System.Data.OracleClient.OracleBoolean x, System.Data.OracleClient.OracleBoolean y) { return default(System.Data.OracleClient.OracleBoolean); }
    [System.MonoTODOAttribute]
    public int CompareTo(object obj) { return default(int); }
    public static System.Data.OracleClient.OracleBoolean Equals(System.Data.OracleClient.OracleBoolean x, System.Data.OracleClient.OracleBoolean y) { return default(System.Data.OracleClient.OracleBoolean); }
    [System.MonoTODOAttribute]
    public override bool Equals(object value) { return default(bool); }
    [System.MonoTODOAttribute]
    public override int GetHashCode() { return default(int); }
    public static System.Data.OracleClient.OracleBoolean NotEquals(System.Data.OracleClient.OracleBoolean x, System.Data.OracleClient.OracleBoolean y) { return default(System.Data.OracleClient.OracleBoolean); }
    public static System.Data.OracleClient.OracleBoolean OnesComplement(System.Data.OracleClient.OracleBoolean x) { return default(System.Data.OracleClient.OracleBoolean); }
    public static System.Data.OracleClient.OracleBoolean operator &(System.Data.OracleClient.OracleBoolean x, System.Data.OracleClient.OracleBoolean y) { return default(System.Data.OracleClient.OracleBoolean); }
    public static System.Data.OracleClient.OracleBoolean operator |(System.Data.OracleClient.OracleBoolean x, System.Data.OracleClient.OracleBoolean y) { return default(System.Data.OracleClient.OracleBoolean); }
    public static System.Data.OracleClient.OracleBoolean operator ==(System.Data.OracleClient.OracleBoolean x, System.Data.OracleClient.OracleBoolean y) { return default(System.Data.OracleClient.OracleBoolean); }
    public static System.Data.OracleClient.OracleBoolean operator ^(System.Data.OracleClient.OracleBoolean x, System.Data.OracleClient.OracleBoolean y) { return default(System.Data.OracleClient.OracleBoolean); }
    public static explicit operator bool (System.Data.OracleClient.OracleBoolean x) { return default(bool); }
    public static explicit operator System.Data.OracleClient.OracleBoolean (System.Data.OracleClient.OracleNumber x) { return default(System.Data.OracleClient.OracleBoolean); }
    public static explicit operator System.Data.OracleClient.OracleBoolean (string x) { return default(System.Data.OracleClient.OracleBoolean); }
    public static bool operator false(System.Data.OracleClient.OracleBoolean x) { return default(bool); }
    public static implicit operator System.Data.OracleClient.OracleBoolean (bool x) { return default(System.Data.OracleClient.OracleBoolean); }
    public static System.Data.OracleClient.OracleBoolean operator !=(System.Data.OracleClient.OracleBoolean x, System.Data.OracleClient.OracleBoolean y) { return default(System.Data.OracleClient.OracleBoolean); }
    public static System.Data.OracleClient.OracleBoolean operator !(System.Data.OracleClient.OracleBoolean x) { return default(System.Data.OracleClient.OracleBoolean); }
    public static System.Data.OracleClient.OracleBoolean operator ~(System.Data.OracleClient.OracleBoolean x) { return default(System.Data.OracleClient.OracleBoolean); }
    public static bool operator true(System.Data.OracleClient.OracleBoolean x) { return default(bool); }
    public static System.Data.OracleClient.OracleBoolean Or(System.Data.OracleClient.OracleBoolean x, System.Data.OracleClient.OracleBoolean y) { return default(System.Data.OracleClient.OracleBoolean); }
    [System.MonoTODOAttribute]
    public static System.Data.OracleClient.OracleBoolean Parse(string s) { return default(System.Data.OracleClient.OracleBoolean); }
    public override string ToString() { return default(string); }
    public static System.Data.OracleClient.OracleBoolean Xor(System.Data.OracleClient.OracleBoolean x, System.Data.OracleClient.OracleBoolean y) { return default(System.Data.OracleClient.OracleBoolean); }
  }
  public sealed partial class OracleClientFactory : System.Data.Common.DbProviderFactory {
    internal OracleClientFactory() { }
    public static readonly System.Data.OracleClient.OracleClientFactory Instance;
    [System.MonoTODOAttribute]
    public override bool CanCreateDataSourceEnumerator { get { return default(bool); } }
    public override System.Data.Common.DbCommand CreateCommand() { return default(System.Data.Common.DbCommand); }
    public override System.Data.Common.DbCommandBuilder CreateCommandBuilder() { return default(System.Data.Common.DbCommandBuilder); }
    public override System.Data.Common.DbConnection CreateConnection() { return default(System.Data.Common.DbConnection); }
    public override System.Data.Common.DbConnectionStringBuilder CreateConnectionStringBuilder() { return default(System.Data.Common.DbConnectionStringBuilder); }
    public override System.Data.Common.DbDataAdapter CreateDataAdapter() { return default(System.Data.Common.DbDataAdapter); }
    public override System.Data.Common.DbDataSourceEnumerator CreateDataSourceEnumerator() { return default(System.Data.Common.DbDataSourceEnumerator); }
    public override System.Data.Common.DbParameter CreateParameter() { return default(System.Data.Common.DbParameter); }
    public override System.Security.CodeAccessPermission CreatePermission(System.Security.Permissions.PermissionState state) { return default(System.Security.CodeAccessPermission); }
  }
  [System.ComponentModel.DefaultEventAttribute("RecordsAffected")]
  [System.ComponentModel.DesignerAttribute("Microsoft.VSDesigner.Data.VS.OracleCommandDesigner, Microsoft.VSDesigner, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
  [System.ComponentModel.ToolboxItemAttribute(true)]
  public sealed partial class OracleCommand : System.Data.Common.DbCommand, System.ICloneable {
    public OracleCommand() { }
    public OracleCommand(string commandText) { }
    public OracleCommand(string commandText, System.Data.OracleClient.OracleConnection connection) { }
    public OracleCommand(string commandText, System.Data.OracleClient.OracleConnection connection, System.Data.OracleClient.OracleTransaction tx) { }
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.ComponentModel.EditorAttribute("Microsoft.VSDesigner.Data.Oracle.Design.OracleCommandTextEditor, Microsoft.VSDesigner, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(System.Drawing.Design.UITypeEditor))]
    [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
    public override string CommandText { get { return default(string); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public override int CommandTimeout { get { return default(int); } set { } }
    [System.ComponentModel.DefaultValueAttribute((System.Data.CommandType)(1))]
    [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
    public override System.Data.CommandType CommandType { get { return default(System.Data.CommandType); } set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    [System.ComponentModel.EditorAttribute("Microsoft.VSDesigner.Data.Design.DbConnectionEditor, Microsoft.VSDesigner, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(System.Drawing.Design.UITypeEditor))]
    public new System.Data.OracleClient.OracleConnection Connection { get { return default(System.Data.OracleClient.OracleConnection); } set { } }
    [System.MonoTODOAttribute]
    protected override System.Data.Common.DbConnection DbConnection { get { return default(System.Data.Common.DbConnection); } set { } }
    [System.MonoTODOAttribute]
    protected override System.Data.Common.DbParameterCollection DbParameterCollection { get { return default(System.Data.Common.DbParameterCollection); } }
    [System.MonoTODOAttribute]
    protected override System.Data.Common.DbTransaction DbTransaction { get { return default(System.Data.Common.DbTransaction); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute(true)]
    [System.ComponentModel.DesignOnlyAttribute(true)]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public override bool DesignTimeVisible { get { return default(bool); } set { } }
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(2))]
    public new System.Data.OracleClient.OracleParameterCollection Parameters { get { return default(System.Data.OracleClient.OracleParameterCollection); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    public new System.Data.OracleClient.OracleTransaction Transaction { get { return default(System.Data.OracleClient.OracleTransaction); } set { } }
    [System.ComponentModel.DefaultValueAttribute((System.Data.UpdateRowSource)(3))]
    public override System.Data.UpdateRowSource UpdatedRowSource { get { return default(System.Data.UpdateRowSource); } set { } }
    [System.MonoTODOAttribute]
    public override void Cancel() { }
    [System.MonoTODOAttribute]
    public object Clone() { return default(object); }
    protected override System.Data.Common.DbParameter CreateDbParameter() { return default(System.Data.Common.DbParameter); }
    public new System.Data.OracleClient.OracleParameter CreateParameter() { return default(System.Data.OracleClient.OracleParameter); }
    protected override void Dispose(bool disposing) { }
    protected override System.Data.Common.DbDataReader ExecuteDbDataReader(System.Data.CommandBehavior behavior) { return default(System.Data.Common.DbDataReader); }
    public override int ExecuteNonQuery() { return default(int); }
    public int ExecuteOracleNonQuery(out System.Data.OracleClient.OracleString rowid) { rowid = default(System.Data.OracleClient.OracleString); return default(int); }
    public object ExecuteOracleScalar() { return default(object); }
    public new System.Data.OracleClient.OracleDataReader ExecuteReader() { return default(System.Data.OracleClient.OracleDataReader); }
    public new System.Data.OracleClient.OracleDataReader ExecuteReader(System.Data.CommandBehavior behavior) { return default(System.Data.OracleClient.OracleDataReader); }
    public override object ExecuteScalar() { return default(object); }
    public override void Prepare() { }
  }
  public sealed partial class OracleCommandBuilder : System.Data.Common.DbCommandBuilder {
    public OracleCommandBuilder() { }
    public OracleCommandBuilder(System.Data.OracleClient.OracleDataAdapter adapter) { }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public new System.Data.OracleClient.OracleDataAdapter DataAdapter { get { return default(System.Data.OracleClient.OracleDataAdapter); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    public override string QuotePrefix { get { return default(string); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    public override string QuoteSuffix { get { return default(string); } set { } }
    [System.MonoTODOAttribute]
    protected override void ApplyParameterInfo(System.Data.Common.DbParameter dbParameter, System.Data.DataRow row, System.Data.StatementType statementType, bool whereClause) { }
    public static void DeriveParameters(System.Data.OracleClient.OracleCommand command) { }
    protected override void Dispose(bool disposing) { }
    public new System.Data.OracleClient.OracleCommand GetDeleteCommand() { return default(System.Data.OracleClient.OracleCommand); }
    public new System.Data.OracleClient.OracleCommand GetInsertCommand() { return default(System.Data.OracleClient.OracleCommand); }
    [System.MonoTODOAttribute]
    protected override string GetParameterName(int position) { return default(string); }
    [System.MonoTODOAttribute]
    protected override string GetParameterName(string parameterName) { return default(string); }
    [System.MonoTODOAttribute]
    protected override string GetParameterPlaceholder(int position) { return default(string); }
    public new System.Data.OracleClient.OracleCommand GetUpdateCommand() { return default(System.Data.OracleClient.OracleCommand); }
    [System.MonoTODOAttribute("Figure out what else needs to be cleaned up when we refresh.")]
    public override void RefreshSchema() { }
    [System.MonoTODOAttribute]
    protected override void SetRowUpdatingHandler(System.Data.Common.DbDataAdapter adapter) { }
  }
  [System.ComponentModel.DefaultEventAttribute("InfoMessage")]
  public sealed partial class OracleConnection : System.Data.Common.DbConnection, System.ICloneable {
    public OracleConnection() { }
    public OracleConnection(string connectionString) { }
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.ComponentModel.EditorAttribute("Microsoft.VSDesigner.Data.Oracle.Design.OracleConnectionStringEditor, Microsoft.VSDesigner, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(System.Drawing.Design.UITypeEditor))]
    [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
    [System.ComponentModel.SettingsBindableAttribute(true)]
    public override string ConnectionString { get { return default(string); } set { } }
    [System.MonoTODOAttribute("Currently not respected.")]
    public override int ConnectionTimeout { get { return default(int); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public override string Database { [System.MonoTODOAttribute]get { return default(string); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.MonoTODOAttribute]
    public override string DataSource { get { return default(string); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.MonoTODOAttribute]
    public override string ServerVersion { get { return default(string); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    public override System.Data.ConnectionState State { get { return default(System.Data.ConnectionState); } }
    public event System.Data.OracleClient.OracleInfoMessageEventHandler InfoMessage { add { } remove { } }
    protected override System.Data.Common.DbTransaction BeginDbTransaction(System.Data.IsolationLevel isolationLevel) { return default(System.Data.Common.DbTransaction); }
    public new System.Data.OracleClient.OracleTransaction BeginTransaction() { return default(System.Data.OracleClient.OracleTransaction); }
    public new System.Data.OracleClient.OracleTransaction BeginTransaction(System.Data.IsolationLevel il) { return default(System.Data.OracleClient.OracleTransaction); }
    [System.MonoTODOAttribute]
    public override void ChangeDatabase(string value) { }
    public override void Close() { }
    public new System.Data.OracleClient.OracleCommand CreateCommand() { return default(System.Data.OracleClient.OracleCommand); }
    protected override System.Data.Common.DbCommand CreateDbCommand() { return default(System.Data.Common.DbCommand); }
    [System.MonoTODOAttribute]
    protected override void Dispose(bool disposing) { }
    [System.MonoTODOAttribute]
    public void EnlistDistributedTransaction(System.EnterpriseServices.ITransaction distributedTransaction) { }
    public override System.Data.DataTable GetSchema() { return default(System.Data.DataTable); }
    public override System.Data.DataTable GetSchema(string collectionName) { return default(System.Data.DataTable); }
    public override System.Data.DataTable GetSchema(string collectionName, System.String[] restrictionValues) { return default(System.Data.DataTable); }
    public override void Open() { }
    [System.MonoTODOAttribute]
    object System.ICloneable.Clone() { return default(object); }
  }
  [System.ComponentModel.DefaultPropertyAttribute("DataSource")]
  public sealed partial class OracleConnectionStringBuilder : System.Data.Common.DbConnectionStringBuilder {
    public OracleConnectionStringBuilder() { }
    public OracleConnectionStringBuilder(string connectionString) { }
    [System.ComponentModel.DisplayNameAttribute("Data Source")]
    [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
    public string DataSource { get { return default(string); } set { } }
    [System.ComponentModel.DisplayNameAttribute("Enlist")]
    [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
    public bool Enlist { get { return default(bool); } set { } }
    [System.ComponentModel.DisplayNameAttribute("Integrated Security")]
    [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
    public bool IntegratedSecurity { get { return default(bool); } set { } }
    public override bool IsFixedSize { get { return default(bool); } }
    public override object this[string keyword] { get { return default(object); } set { } }
    public override System.Collections.ICollection Keys { get { return default(System.Collections.ICollection); } }
    [System.ComponentModel.DisplayNameAttribute("Load Balance Timeout")]
    [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
    public int LoadBalanceTimeout { get { return default(int); } set { } }
    [System.ComponentModel.DisplayNameAttribute("Max Pool Size")]
    [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
    public int MaxPoolSize { get { return default(int); } set { } }
    [System.ComponentModel.DisplayNameAttribute("Min Pool Size")]
    [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
    public int MinPoolSize { get { return default(int); } set { } }
    [System.ComponentModel.DisplayNameAttribute("Omit Oracle Connection Name")]
    [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
    public bool OmitOracleConnectionName { get { return default(bool); } set { } }
    [System.ComponentModel.DisplayNameAttribute("Password")]
    [System.ComponentModel.PasswordPropertyTextAttribute(true)]
    [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
    public string Password { get { return default(string); } set { } }
    [System.ComponentModel.DisplayNameAttribute("Persist Security Info")]
    [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
    public bool PersistSecurityInfo { get { return default(bool); } set { } }
    [System.ComponentModel.DisplayNameAttribute("Pooling")]
    [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
    public bool Pooling { get { return default(bool); } set { } }
    [System.ComponentModel.DisplayNameAttribute("Unicode")]
    [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
    public bool Unicode { get { return default(bool); } set { } }
    [System.ComponentModel.DisplayNameAttribute("User ID")]
    [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
    public string UserID { get { return default(string); } set { } }
    public override System.Collections.ICollection Values { get { return default(System.Collections.ICollection); } }
    public override void Clear() { }
    public override bool ContainsKey(string keyword) { return default(bool); }
    public override bool Remove(string keyword) { return default(bool); }
    [System.MonoNotSupportedAttribute("")]
    public override bool ShouldSerialize(string keyword) { return default(bool); }
    public override bool TryGetValue(string keyword, out object value) { value = default(object); return default(bool); }
  }
  [System.ComponentModel.DefaultEventAttribute("RowUpdated")]
  [System.ComponentModel.DesignerAttribute("Microsoft.VSDesigner.Data.VS.OracleDataAdapterDesigner, Microsoft.VSDesigner, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
  [System.ComponentModel.ToolboxItemAttribute("Microsoft.VSDesigner.Data.VS.OracleDataAdapterToolboxItem, Microsoft.VSDesigner, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
  public sealed partial class OracleDataAdapter : System.Data.Common.DbDataAdapter, System.Data.IDataAdapter, System.Data.IDbDataAdapter {
    public OracleDataAdapter() { }
    public OracleDataAdapter(System.Data.OracleClient.OracleCommand selectCommand) { }
    public OracleDataAdapter(string selectCommandText, System.Data.OracleClient.OracleConnection selectConnection) { }
    public OracleDataAdapter(string selectCommandText, string selectConnectionString) { }
    [System.ComponentModel.DefaultValueAttribute(null)]
    [System.ComponentModel.EditorAttribute("Microsoft.VSDesigner.Data.Design.DBCommandEditor, Microsoft.VSDesigner, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(System.Drawing.Design.UITypeEditor))]
    public new System.Data.OracleClient.OracleCommand DeleteCommand { get { return default(System.Data.OracleClient.OracleCommand); } set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    [System.ComponentModel.EditorAttribute("Microsoft.VSDesigner.Data.Design.DBCommandEditor, Microsoft.VSDesigner, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(System.Drawing.Design.UITypeEditor))]
    public new System.Data.OracleClient.OracleCommand InsertCommand { get { return default(System.Data.OracleClient.OracleCommand); } set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    [System.ComponentModel.EditorAttribute("Microsoft.VSDesigner.Data.Design.DBCommandEditor, Microsoft.VSDesigner, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(System.Drawing.Design.UITypeEditor))]
    public new System.Data.OracleClient.OracleCommand SelectCommand { get { return default(System.Data.OracleClient.OracleCommand); } set { } }
    System.Data.IDbCommand System.Data.IDbDataAdapter.DeleteCommand { get { return default(System.Data.IDbCommand); } set { } }
    System.Data.IDbCommand System.Data.IDbDataAdapter.InsertCommand { get { return default(System.Data.IDbCommand); } set { } }
    System.Data.IDbCommand System.Data.IDbDataAdapter.SelectCommand { get { return default(System.Data.IDbCommand); } set { } }
    System.Data.IDbCommand System.Data.IDbDataAdapter.UpdateCommand { get { return default(System.Data.IDbCommand); } set { } }
    public override int UpdateBatchSize { get { return default(int); } set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    [System.ComponentModel.EditorAttribute("Microsoft.VSDesigner.Data.Design.DBCommandEditor, Microsoft.VSDesigner, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(System.Drawing.Design.UITypeEditor))]
    public new System.Data.OracleClient.OracleCommand UpdateCommand { get { return default(System.Data.OracleClient.OracleCommand); } set { } }
    public event System.Data.OracleClient.OracleRowUpdatedEventHandler RowUpdated { add { } remove { } }
    public event System.Data.OracleClient.OracleRowUpdatingEventHandler RowUpdating { add { } remove { } }
    protected override System.Data.Common.RowUpdatedEventArgs CreateRowUpdatedEvent(System.Data.DataRow dataRow, System.Data.IDbCommand command, System.Data.StatementType statementType, System.Data.Common.DataTableMapping tableMapping) { return default(System.Data.Common.RowUpdatedEventArgs); }
    protected override System.Data.Common.RowUpdatingEventArgs CreateRowUpdatingEvent(System.Data.DataRow dataRow, System.Data.IDbCommand command, System.Data.StatementType statementType, System.Data.Common.DataTableMapping tableMapping) { return default(System.Data.Common.RowUpdatingEventArgs); }
    protected override void OnRowUpdated(System.Data.Common.RowUpdatedEventArgs value) { }
    protected override void OnRowUpdating(System.Data.Common.RowUpdatingEventArgs value) { }
  }
  public sealed partial class OracleDataReader : System.Data.Common.DbDataReader {
    internal OracleDataReader() { }
    public override int Depth { get { return default(int); } }
    public override int FieldCount { get { return default(int); } }
    public override bool HasRows { get { return default(bool); } }
    public override bool IsClosed { get { return default(bool); } }
    public override object this[int i] { get { return default(object); } }
    public override object this[string name] { get { return default(object); } }
    public override int RecordsAffected { get { return default(int); } }
    public override void Close() { }
    ~OracleDataReader() { }
    public override bool GetBoolean(int i) { return default(bool); }
    public override byte GetByte(int i) { return default(byte); }
    public override long GetBytes(int i, long fieldOffset, System.Byte[] buffer2, int bufferoffset, int length) { return default(long); }
    public override char GetChar(int i) { return default(char); }
    public override long GetChars(int i, long fieldOffset, System.Char[] buffer2, int bufferoffset, int length) { return default(long); }
    public override string GetDataTypeName(int i) { return default(string); }
    public override System.DateTime GetDateTime(int i) { return default(System.DateTime); }
    public override decimal GetDecimal(int i) { return default(decimal); }
    public override double GetDouble(int i) { return default(double); }
    public override System.Collections.IEnumerator GetEnumerator() { return default(System.Collections.IEnumerator); }
    public override System.Type GetFieldType(int i) { return default(System.Type); }
    public override float GetFloat(int i) { return default(float); }
    public override System.Guid GetGuid(int i) { return default(System.Guid); }
    public override short GetInt16(int i) { return default(short); }
    public override int GetInt32(int i) { return default(int); }
    public override long GetInt64(int i) { return default(long); }
    public override string GetName(int i) { return default(string); }
    [System.MonoTODOAttribute]
    public System.Data.OracleClient.OracleBFile GetOracleBFile(int i) { return default(System.Data.OracleClient.OracleBFile); }
    [System.MonoTODOAttribute]
    public System.Data.OracleClient.OracleBinary GetOracleBinary(int i) { return default(System.Data.OracleClient.OracleBinary); }
    public System.Data.OracleClient.OracleDateTime GetOracleDateTime(int i) { return default(System.Data.OracleClient.OracleDateTime); }
    public System.Data.OracleClient.OracleLob GetOracleLob(int i) { return default(System.Data.OracleClient.OracleLob); }
    public System.Data.OracleClient.OracleMonthSpan GetOracleMonthSpan(int i) { return default(System.Data.OracleClient.OracleMonthSpan); }
    public System.Data.OracleClient.OracleNumber GetOracleNumber(int i) { return default(System.Data.OracleClient.OracleNumber); }
    public System.Data.OracleClient.OracleString GetOracleString(int i) { return default(System.Data.OracleClient.OracleString); }
    public System.Data.OracleClient.OracleTimeSpan GetOracleTimeSpan(int i) { return default(System.Data.OracleClient.OracleTimeSpan); }
    public object GetOracleValue(int i) { return default(object); }
    public int GetOracleValues(System.Object[] values) { return default(int); }
    public override int GetOrdinal(string name) { return default(int); }
    [System.MonoTODOAttribute]
    public override System.Type GetProviderSpecificFieldType(int i) { return default(System.Type); }
    [System.MonoTODOAttribute]
    public override object GetProviderSpecificValue(int i) { return default(object); }
    [System.MonoTODOAttribute]
    public override int GetProviderSpecificValues(System.Object[] values) { return default(int); }
    [System.MonoTODOAttribute("Implement this properly, with all needed information.")]
    public override System.Data.DataTable GetSchemaTable() { return default(System.Data.DataTable); }
    public override string GetString(int i) { return default(string); }
    public System.TimeSpan GetTimeSpan(int i) { return default(System.TimeSpan); }
    public override object GetValue(int i) { return default(object); }
    public override int GetValues(System.Object[] values) { return default(int); }
    public override bool IsDBNull(int i) { return default(bool); }
    public override bool NextResult() { return default(bool); }
    public override bool Read() { return default(bool); }
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct OracleDateTime : System.Data.SqlTypes.INullable, System.IComparable {
    public static readonly System.Data.OracleClient.OracleDateTime MaxValue;
    public static readonly System.Data.OracleClient.OracleDateTime MinValue;
    public static readonly System.Data.OracleClient.OracleDateTime Null;
    public OracleDateTime(System.Data.OracleClient.OracleDateTime from) { throw new System.NotImplementedException(); }
    public OracleDateTime(System.DateTime dt) { throw new System.NotImplementedException(); }
    public OracleDateTime(int year, int month, int day) { throw new System.NotImplementedException(); }
    public OracleDateTime(int year, int month, int day, System.Globalization.Calendar calendar) { throw new System.NotImplementedException(); }
    public OracleDateTime(int year, int month, int day, int hour, int minute, int second) { throw new System.NotImplementedException(); }
    public OracleDateTime(int year, int month, int day, int hour, int minute, int second, System.Globalization.Calendar calendar) { throw new System.NotImplementedException(); }
    public OracleDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond) { throw new System.NotImplementedException(); }
    public OracleDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, System.Globalization.Calendar calendar) { throw new System.NotImplementedException(); }
    public OracleDateTime(long ticks) { throw new System.NotImplementedException(); }
    public int Day { get { return default(int); } }
    public int Hour { get { return default(int); } }
    public bool IsNull { get { return default(bool); } }
    public int Millisecond { get { return default(int); } }
    public int Minute { get { return default(int); } }
    public int Month { get { return default(int); } }
    public int Second { get { return default(int); } }
    public System.DateTime Value { get { return default(System.DateTime); } }
    public int Year { get { return default(int); } }
    public int CompareTo(object obj) { return default(int); }
    public static System.Data.OracleClient.OracleBoolean Equals(System.Data.OracleClient.OracleDateTime x, System.Data.OracleClient.OracleDateTime y) { return default(System.Data.OracleClient.OracleBoolean); }
    public override bool Equals(object value) { return default(bool); }
    [System.MonoTODOAttribute]
    public override int GetHashCode() { return default(int); }
    public static System.Data.OracleClient.OracleBoolean GreaterThan(System.Data.OracleClient.OracleDateTime x, System.Data.OracleClient.OracleDateTime y) { return default(System.Data.OracleClient.OracleBoolean); }
    public static System.Data.OracleClient.OracleBoolean GreaterThanOrEqual(System.Data.OracleClient.OracleDateTime x, System.Data.OracleClient.OracleDateTime y) { return default(System.Data.OracleClient.OracleBoolean); }
    public static System.Data.OracleClient.OracleBoolean LessThan(System.Data.OracleClient.OracleDateTime x, System.Data.OracleClient.OracleDateTime y) { return default(System.Data.OracleClient.OracleBoolean); }
    public static System.Data.OracleClient.OracleBoolean LessThanOrEqual(System.Data.OracleClient.OracleDateTime x, System.Data.OracleClient.OracleDateTime y) { return default(System.Data.OracleClient.OracleBoolean); }
    public static System.Data.OracleClient.OracleBoolean NotEquals(System.Data.OracleClient.OracleDateTime x, System.Data.OracleClient.OracleDateTime y) { return default(System.Data.OracleClient.OracleBoolean); }
    public static System.Data.OracleClient.OracleBoolean operator ==(System.Data.OracleClient.OracleDateTime x, System.Data.OracleClient.OracleDateTime y) { return default(System.Data.OracleClient.OracleBoolean); }
    public static explicit operator System.DateTime (System.Data.OracleClient.OracleDateTime x) { return default(System.DateTime); }
    public static explicit operator System.Data.OracleClient.OracleDateTime (string x) { return default(System.Data.OracleClient.OracleDateTime); }
    public static System.Data.OracleClient.OracleBoolean operator >(System.Data.OracleClient.OracleDateTime x, System.Data.OracleClient.OracleDateTime y) { return default(System.Data.OracleClient.OracleBoolean); }
    public static System.Data.OracleClient.OracleBoolean operator >=(System.Data.OracleClient.OracleDateTime x, System.Data.OracleClient.OracleDateTime y) { return default(System.Data.OracleClient.OracleBoolean); }
    public static System.Data.OracleClient.OracleBoolean operator !=(System.Data.OracleClient.OracleDateTime x, System.Data.OracleClient.OracleDateTime y) { return default(System.Data.OracleClient.OracleBoolean); }
    public static System.Data.OracleClient.OracleBoolean operator <(System.Data.OracleClient.OracleDateTime x, System.Data.OracleClient.OracleDateTime y) { return default(System.Data.OracleClient.OracleBoolean); }
    public static System.Data.OracleClient.OracleBoolean operator <=(System.Data.OracleClient.OracleDateTime x, System.Data.OracleClient.OracleDateTime y) { return default(System.Data.OracleClient.OracleBoolean); }
    public static System.Data.OracleClient.OracleDateTime Parse(string s) { return default(System.Data.OracleClient.OracleDateTime); }
    public override string ToString() { return default(string); }
  }
  public sealed partial class OracleException : System.Data.Common.DbException {
    internal OracleException() { }
    public int Code { get { return default(int); } }
    public override void GetObjectData(System.Runtime.Serialization.SerializationInfo si, System.Runtime.Serialization.StreamingContext context) { }
  }
  public sealed partial class OracleInfoMessageEventArgs : System.EventArgs {
    internal OracleInfoMessageEventArgs() { }
    public int Code { get { return default(int); } }
    public string Message { get { return default(string); } }
    public string Source { [System.MonoTODOAttribute]get { return default(string); } }
    public override string ToString() { return default(string); }
  }
  public delegate void OracleInfoMessageEventHandler(object sender, System.Data.OracleClient.OracleInfoMessageEventArgs e);
  public sealed partial class OracleLob : System.IO.Stream, System.Data.SqlTypes.INullable, System.ICloneable, System.IDisposable {
    internal OracleLob() { }
    public static readonly new System.Data.OracleClient.OracleLob Null;
    public override bool CanRead { get { return default(bool); } }
    public override bool CanSeek { get { return default(bool); } }
    public override bool CanWrite { get { return default(bool); } }
    public int ChunkSize { [System.MonoTODOAttribute]get { return default(int); } }
    public System.Data.OracleClient.OracleConnection Connection { get { return default(System.Data.OracleClient.OracleConnection); } }
    public bool IsBatched { get { return default(bool); } }
    public bool IsNull { get { return default(bool); } }
    public bool IsTemporary { get { return default(bool); } }
    public override long Length { get { return default(long); } }
    public System.Data.OracleClient.OracleType LobType { get { return default(System.Data.OracleClient.OracleType); } }
    public override long Position { get { return default(long); } set { } }
    public object Value { get { return default(object); } }
    [System.MonoTODOAttribute]
    public void Append(System.Data.OracleClient.OracleLob source) { }
    public void BeginBatch() { }
    public void BeginBatch(System.Data.OracleClient.OracleLobOpenMode mode) { }
    [System.MonoTODOAttribute]
    public object Clone() { return default(object); }
    public long CopyTo(System.Data.OracleClient.OracleLob destination) { return default(long); }
    public long CopyTo(System.Data.OracleClient.OracleLob destination, long destinationOffset) { return default(long); }
    public long CopyTo(long sourceOffset, System.Data.OracleClient.OracleLob destination, long destinationOffset, long amount) { return default(long); }
    protected override void Dispose(bool disposing) { }
    public void EndBatch() { }
    public long Erase() { return default(long); }
    public long Erase(long offset, long amount) { return default(long); }
    public override void Flush() { }
    public override int Read(System.Byte[] buffer, int offset, int count) { return default(int); }
    [System.MonoTODOAttribute]
    public override long Seek(long offset, System.IO.SeekOrigin origin) { return default(long); }
    [System.MonoTODOAttribute]
    public override void SetLength(long value) { }
    public override void Write(System.Byte[] buffer, int offset, int count) { }
  }
  public enum OracleLobOpenMode {
    ReadOnly = 1,
    ReadWrite = 2,
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct OracleMonthSpan : System.Data.SqlTypes.INullable, System.IComparable {
    public static readonly System.Data.OracleClient.OracleMonthSpan MaxValue;
    public static readonly System.Data.OracleClient.OracleMonthSpan MinValue;
    public static readonly System.Data.OracleClient.OracleMonthSpan Null;
    public OracleMonthSpan(System.Data.OracleClient.OracleMonthSpan from) { throw new System.NotImplementedException(); }
    public OracleMonthSpan(int months) { throw new System.NotImplementedException(); }
    public OracleMonthSpan(int years, int months) { throw new System.NotImplementedException(); }
    public bool IsNull { get { return default(bool); } }
    public int Value { get { return default(int); } }
    public int CompareTo(object obj) { return default(int); }
    public static System.Data.OracleClient.OracleBoolean Equals(System.Data.OracleClient.OracleMonthSpan x, System.Data.OracleClient.OracleMonthSpan y) { return default(System.Data.OracleClient.OracleBoolean); }
    public override bool Equals(object value) { return default(bool); }
    [System.MonoTODOAttribute]
    public override int GetHashCode() { return default(int); }
    public static System.Data.OracleClient.OracleBoolean GreaterThan(System.Data.OracleClient.OracleMonthSpan x, System.Data.OracleClient.OracleMonthSpan y) { return default(System.Data.OracleClient.OracleBoolean); }
    public static System.Data.OracleClient.OracleBoolean GreaterThanOrEqual(System.Data.OracleClient.OracleMonthSpan x, System.Data.OracleClient.OracleMonthSpan y) { return default(System.Data.OracleClient.OracleBoolean); }
    public static System.Data.OracleClient.OracleBoolean LessThan(System.Data.OracleClient.OracleMonthSpan x, System.Data.OracleClient.OracleMonthSpan y) { return default(System.Data.OracleClient.OracleBoolean); }
    public static System.Data.OracleClient.OracleBoolean LessThanOrEqual(System.Data.OracleClient.OracleMonthSpan x, System.Data.OracleClient.OracleMonthSpan y) { return default(System.Data.OracleClient.OracleBoolean); }
    public static System.Data.OracleClient.OracleBoolean NotEquals(System.Data.OracleClient.OracleMonthSpan x, System.Data.OracleClient.OracleMonthSpan y) { return default(System.Data.OracleClient.OracleBoolean); }
    public static System.Data.OracleClient.OracleBoolean operator ==(System.Data.OracleClient.OracleMonthSpan x, System.Data.OracleClient.OracleMonthSpan y) { return default(System.Data.OracleClient.OracleBoolean); }
    public static explicit operator int (System.Data.OracleClient.OracleMonthSpan x) { return default(int); }
    public static explicit operator System.Data.OracleClient.OracleMonthSpan (string x) { return default(System.Data.OracleClient.OracleMonthSpan); }
    public static System.Data.OracleClient.OracleBoolean operator >(System.Data.OracleClient.OracleMonthSpan x, System.Data.OracleClient.OracleMonthSpan y) { return default(System.Data.OracleClient.OracleBoolean); }
    public static System.Data.OracleClient.OracleBoolean operator >=(System.Data.OracleClient.OracleMonthSpan x, System.Data.OracleClient.OracleMonthSpan y) { return default(System.Data.OracleClient.OracleBoolean); }
    public static System.Data.OracleClient.OracleBoolean operator !=(System.Data.OracleClient.OracleMonthSpan x, System.Data.OracleClient.OracleMonthSpan y) { return default(System.Data.OracleClient.OracleBoolean); }
    public static System.Data.OracleClient.OracleBoolean operator <(System.Data.OracleClient.OracleMonthSpan x, System.Data.OracleClient.OracleMonthSpan y) { return default(System.Data.OracleClient.OracleBoolean); }
    public static System.Data.OracleClient.OracleBoolean operator <=(System.Data.OracleClient.OracleMonthSpan x, System.Data.OracleClient.OracleMonthSpan y) { return default(System.Data.OracleClient.OracleBoolean); }
    public static System.Data.OracleClient.OracleMonthSpan Parse(string s) { return default(System.Data.OracleClient.OracleMonthSpan); }
    public override string ToString() { return default(string); }
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct OracleNumber : System.Data.SqlTypes.INullable, System.IComparable {
    public static readonly System.Data.OracleClient.OracleNumber E;
    public static readonly int MaxPrecision;
    public static readonly int MaxScale;
    public static readonly System.Data.OracleClient.OracleNumber MaxValue;
    public static readonly int MinScale;
    public static readonly System.Data.OracleClient.OracleNumber MinusOne;
    public static readonly System.Data.OracleClient.OracleNumber MinValue;
    public static readonly System.Data.OracleClient.OracleNumber Null;
    public static readonly System.Data.OracleClient.OracleNumber One;
    public static readonly System.Data.OracleClient.OracleNumber PI;
    public static readonly System.Data.OracleClient.OracleNumber Zero;
    public OracleNumber(System.Data.OracleClient.OracleNumber from) { throw new System.NotImplementedException(); }
    public OracleNumber(decimal decValue) { throw new System.NotImplementedException(); }
    public OracleNumber(double dblValue) { throw new System.NotImplementedException(); }
    public OracleNumber(int intValue) { throw new System.NotImplementedException(); }
    public OracleNumber(long longValue) { throw new System.NotImplementedException(); }
    public bool IsNull { get { return default(bool); } }
    public decimal Value { get { return default(decimal); } }
    public static System.Data.OracleClient.OracleNumber Abs(System.Data.OracleClient.OracleNumber n) { return default(System.Data.OracleClient.OracleNumber); }
    public static System.Data.OracleClient.OracleNumber Acos(System.Data.OracleClient.OracleNumber n) { return default(System.Data.OracleClient.OracleNumber); }
    public static System.Data.OracleClient.OracleNumber Add(System.Data.OracleClient.OracleNumber x, System.Data.OracleClient.OracleNumber y) { return default(System.Data.OracleClient.OracleNumber); }
    public static System.Data.OracleClient.OracleNumber Asin(System.Data.OracleClient.OracleNumber n) { return default(System.Data.OracleClient.OracleNumber); }
    public static System.Data.OracleClient.OracleNumber Atan(System.Data.OracleClient.OracleNumber n) { return default(System.Data.OracleClient.OracleNumber); }
    public static System.Data.OracleClient.OracleNumber Atan2(System.Data.OracleClient.OracleNumber y, System.Data.OracleClient.OracleNumber x) { return default(System.Data.OracleClient.OracleNumber); }
    public static System.Data.OracleClient.OracleNumber Ceiling(System.Data.OracleClient.OracleNumber n) { return default(System.Data.OracleClient.OracleNumber); }
    [System.MonoTODOAttribute]
    public int CompareTo(object obj) { return default(int); }
    public static System.Data.OracleClient.OracleNumber Cos(System.Data.OracleClient.OracleNumber n) { return default(System.Data.OracleClient.OracleNumber); }
    public static System.Data.OracleClient.OracleNumber Cosh(System.Data.OracleClient.OracleNumber n) { return default(System.Data.OracleClient.OracleNumber); }
    public static System.Data.OracleClient.OracleNumber Divide(System.Data.OracleClient.OracleNumber x, System.Data.OracleClient.OracleNumber y) { return default(System.Data.OracleClient.OracleNumber); }
    public static System.Data.OracleClient.OracleBoolean Equals(System.Data.OracleClient.OracleNumber x, System.Data.OracleClient.OracleNumber y) { return default(System.Data.OracleClient.OracleBoolean); }
    [System.MonoTODOAttribute]
    public override bool Equals(object value) { return default(bool); }
    public static System.Data.OracleClient.OracleNumber Exp(System.Data.OracleClient.OracleNumber p) { return default(System.Data.OracleClient.OracleNumber); }
    public static System.Data.OracleClient.OracleNumber Floor(System.Data.OracleClient.OracleNumber n) { return default(System.Data.OracleClient.OracleNumber); }
    [System.MonoTODOAttribute]
    public override int GetHashCode() { return default(int); }
    public static System.Data.OracleClient.OracleBoolean GreaterThan(System.Data.OracleClient.OracleNumber x, System.Data.OracleClient.OracleNumber y) { return default(System.Data.OracleClient.OracleBoolean); }
    public static System.Data.OracleClient.OracleBoolean GreaterThanOrEqual(System.Data.OracleClient.OracleNumber x, System.Data.OracleClient.OracleNumber y) { return default(System.Data.OracleClient.OracleBoolean); }
    public static System.Data.OracleClient.OracleBoolean LessThan(System.Data.OracleClient.OracleNumber x, System.Data.OracleClient.OracleNumber y) { return default(System.Data.OracleClient.OracleBoolean); }
    public static System.Data.OracleClient.OracleBoolean LessThanOrEqual(System.Data.OracleClient.OracleNumber x, System.Data.OracleClient.OracleNumber y) { return default(System.Data.OracleClient.OracleBoolean); }
    public static System.Data.OracleClient.OracleNumber Log(System.Data.OracleClient.OracleNumber n) { return default(System.Data.OracleClient.OracleNumber); }
    public static System.Data.OracleClient.OracleNumber Log(System.Data.OracleClient.OracleNumber n, System.Data.OracleClient.OracleNumber newBase) { return default(System.Data.OracleClient.OracleNumber); }
    public static System.Data.OracleClient.OracleNumber Log(System.Data.OracleClient.OracleNumber n, int newBase) { return default(System.Data.OracleClient.OracleNumber); }
    public static System.Data.OracleClient.OracleNumber Log10(System.Data.OracleClient.OracleNumber n) { return default(System.Data.OracleClient.OracleNumber); }
    public static System.Data.OracleClient.OracleNumber Max(System.Data.OracleClient.OracleNumber x, System.Data.OracleClient.OracleNumber y) { return default(System.Data.OracleClient.OracleNumber); }
    public static System.Data.OracleClient.OracleNumber Min(System.Data.OracleClient.OracleNumber x, System.Data.OracleClient.OracleNumber y) { return default(System.Data.OracleClient.OracleNumber); }
    public static System.Data.OracleClient.OracleNumber Modulo(System.Data.OracleClient.OracleNumber x, System.Data.OracleClient.OracleNumber y) { return default(System.Data.OracleClient.OracleNumber); }
    public static System.Data.OracleClient.OracleNumber Multiply(System.Data.OracleClient.OracleNumber x, System.Data.OracleClient.OracleNumber y) { return default(System.Data.OracleClient.OracleNumber); }
    public static System.Data.OracleClient.OracleNumber Negate(System.Data.OracleClient.OracleNumber x) { return default(System.Data.OracleClient.OracleNumber); }
    public static System.Data.OracleClient.OracleBoolean NotEquals(System.Data.OracleClient.OracleNumber x, System.Data.OracleClient.OracleNumber y) { return default(System.Data.OracleClient.OracleBoolean); }
    public static System.Data.OracleClient.OracleNumber operator +(System.Data.OracleClient.OracleNumber x, System.Data.OracleClient.OracleNumber y) { return default(System.Data.OracleClient.OracleNumber); }
    public static System.Data.OracleClient.OracleNumber operator /(System.Data.OracleClient.OracleNumber x, System.Data.OracleClient.OracleNumber y) { return default(System.Data.OracleClient.OracleNumber); }
    public static System.Data.OracleClient.OracleBoolean operator ==(System.Data.OracleClient.OracleNumber x, System.Data.OracleClient.OracleNumber y) { return default(System.Data.OracleClient.OracleBoolean); }
    public static explicit operator decimal (System.Data.OracleClient.OracleNumber x) { return default(decimal); }
    public static explicit operator double (System.Data.OracleClient.OracleNumber x) { return default(double); }
    public static explicit operator int (System.Data.OracleClient.OracleNumber x) { return default(int); }
    public static explicit operator long (System.Data.OracleClient.OracleNumber x) { return default(long); }
    public static explicit operator System.Data.OracleClient.OracleNumber (decimal x) { return default(System.Data.OracleClient.OracleNumber); }
    public static explicit operator System.Data.OracleClient.OracleNumber (double x) { return default(System.Data.OracleClient.OracleNumber); }
    public static explicit operator System.Data.OracleClient.OracleNumber (int x) { return default(System.Data.OracleClient.OracleNumber); }
    public static explicit operator System.Data.OracleClient.OracleNumber (long x) { return default(System.Data.OracleClient.OracleNumber); }
    public static explicit operator System.Data.OracleClient.OracleNumber (string x) { return default(System.Data.OracleClient.OracleNumber); }
    public static System.Data.OracleClient.OracleBoolean operator >(System.Data.OracleClient.OracleNumber x, System.Data.OracleClient.OracleNumber y) { return default(System.Data.OracleClient.OracleBoolean); }
    public static System.Data.OracleClient.OracleBoolean operator >=(System.Data.OracleClient.OracleNumber x, System.Data.OracleClient.OracleNumber y) { return default(System.Data.OracleClient.OracleBoolean); }
    public static System.Data.OracleClient.OracleBoolean operator !=(System.Data.OracleClient.OracleNumber x, System.Data.OracleClient.OracleNumber y) { return default(System.Data.OracleClient.OracleBoolean); }
    public static System.Data.OracleClient.OracleBoolean operator <(System.Data.OracleClient.OracleNumber x, System.Data.OracleClient.OracleNumber y) { return default(System.Data.OracleClient.OracleBoolean); }
    public static System.Data.OracleClient.OracleBoolean operator <=(System.Data.OracleClient.OracleNumber x, System.Data.OracleClient.OracleNumber y) { return default(System.Data.OracleClient.OracleBoolean); }
    public static System.Data.OracleClient.OracleNumber operator %(System.Data.OracleClient.OracleNumber x, System.Data.OracleClient.OracleNumber y) { return default(System.Data.OracleClient.OracleNumber); }
    public static System.Data.OracleClient.OracleNumber operator *(System.Data.OracleClient.OracleNumber x, System.Data.OracleClient.OracleNumber y) { return default(System.Data.OracleClient.OracleNumber); }
    public static System.Data.OracleClient.OracleNumber operator -(System.Data.OracleClient.OracleNumber x, System.Data.OracleClient.OracleNumber y) { return default(System.Data.OracleClient.OracleNumber); }
    public static System.Data.OracleClient.OracleNumber operator -(System.Data.OracleClient.OracleNumber x) { return default(System.Data.OracleClient.OracleNumber); }
    public static System.Data.OracleClient.OracleNumber Parse(string s) { return default(System.Data.OracleClient.OracleNumber); }
    public static System.Data.OracleClient.OracleNumber Pow(System.Data.OracleClient.OracleNumber x, System.Data.OracleClient.OracleNumber y) { return default(System.Data.OracleClient.OracleNumber); }
    public static System.Data.OracleClient.OracleNumber Pow(System.Data.OracleClient.OracleNumber x, int y) { return default(System.Data.OracleClient.OracleNumber); }
    public static System.Data.OracleClient.OracleNumber Round(System.Data.OracleClient.OracleNumber n, int position) { return default(System.Data.OracleClient.OracleNumber); }
    public static System.Data.OracleClient.OracleNumber Shift(System.Data.OracleClient.OracleNumber n, int digits) { return default(System.Data.OracleClient.OracleNumber); }
    public static System.Data.OracleClient.OracleNumber Sign(System.Data.OracleClient.OracleNumber n) { return default(System.Data.OracleClient.OracleNumber); }
    public static System.Data.OracleClient.OracleNumber Sin(System.Data.OracleClient.OracleNumber n) { return default(System.Data.OracleClient.OracleNumber); }
    public static System.Data.OracleClient.OracleNumber Sinh(System.Data.OracleClient.OracleNumber n) { return default(System.Data.OracleClient.OracleNumber); }
    public static System.Data.OracleClient.OracleNumber Sqrt(System.Data.OracleClient.OracleNumber n) { return default(System.Data.OracleClient.OracleNumber); }
    public static System.Data.OracleClient.OracleNumber Subtract(System.Data.OracleClient.OracleNumber x, System.Data.OracleClient.OracleNumber y) { return default(System.Data.OracleClient.OracleNumber); }
    public static System.Data.OracleClient.OracleNumber Tan(System.Data.OracleClient.OracleNumber n) { return default(System.Data.OracleClient.OracleNumber); }
    public static System.Data.OracleClient.OracleNumber Tanh(System.Data.OracleClient.OracleNumber n) { return default(System.Data.OracleClient.OracleNumber); }
    public override string ToString() { return default(string); }
    [System.MonoTODOAttribute]
    public static System.Data.OracleClient.OracleNumber Truncate(System.Data.OracleClient.OracleNumber n, int position) { return default(System.Data.OracleClient.OracleNumber); }
  }
  [System.ComponentModel.TypeConverterAttribute(typeof(System.Data.OracleClient.OracleParameter.OracleParameterConverter))]
  public sealed partial class OracleParameter : System.Data.Common.DbParameter, System.Data.IDataParameter, System.Data.IDbDataParameter, System.ICloneable {
    public OracleParameter() { }
    public OracleParameter(string name, System.Data.OracleClient.OracleType oracleType) { }
    public OracleParameter(string name, System.Data.OracleClient.OracleType oracleType, int size) { }
    public OracleParameter(string name, System.Data.OracleClient.OracleType oracleType, int size, System.Data.ParameterDirection direction, bool isNullable, byte precision, byte scale, string srcColumn, System.Data.DataRowVersion srcVersion, object value) { }
    public OracleParameter(string name, System.Data.OracleClient.OracleType oracleType, int size, System.Data.ParameterDirection direction, string sourceColumn, System.Data.DataRowVersion sourceVersion, bool sourceColumnNullMapping, object value) { }
    public OracleParameter(string name, System.Data.OracleClient.OracleType oracleType, int size, string srcColumn) { }
    public OracleParameter(string name, object value) { }
    public override System.Data.DbType DbType { get { return default(System.Data.DbType); } set { } }
    [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
    public override System.Data.ParameterDirection Direction { get { return default(System.Data.ParameterDirection); } set { } }
    public override bool IsNullable { get { return default(bool); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
    public int Offset { get { return default(int); } set { } }
    [System.ComponentModel.DefaultValueAttribute((System.Data.OracleClient.OracleType)(22))]
    [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
    [System.Data.Common.DbProviderSpecificTypePropertyAttribute(true)]
    public System.Data.OracleClient.OracleType OracleType { get { return default(System.Data.OracleClient.OracleType); } set { } }
    public override string ParameterName { get { return default(string); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.ObsoleteAttribute("Set the precision of a decimal use the Math classes.")]
    public byte Precision { get { return default(byte); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.ObsoleteAttribute("Set the precision of a decimal use the Math classes.")]
    public byte Scale { get { return default(byte); } set { } }
    public override int Size { get { return default(int); } set { } }
    public override string SourceColumn { get { return default(string); } set { } }
    [System.MonoTODOAttribute]
    public override bool SourceColumnNullMapping { get { return default(bool); } set { } }
    public override System.Data.DataRowVersion SourceVersion { get { return default(System.Data.DataRowVersion); } set { } }
    [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.ComponentModel.StringConverter))]
    public override object Value { get { return default(object); } set { } }
    public override void ResetDbType() { }
    public void ResetOracleType() { }
    object System.ICloneable.Clone() { return default(object); }
    public override string ToString() { return default(string); }
  }
  [System.ComponentModel.EditorAttribute("Microsoft.VSDesigner.Data.Design.DBParametersEditor, Microsoft.VSDesigner, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(System.Drawing.Design.UITypeEditor))]
  [System.ComponentModel.ListBindableAttribute(false)]
  public sealed partial class OracleParameterCollection : System.Data.Common.DbParameterCollection {
    public OracleParameterCollection() { }
    public override int Count { get { return default(int); } }
    public override bool IsFixedSize { get { return default(bool); } }
    public override bool IsReadOnly { get { return default(bool); } }
    public override bool IsSynchronized { get { return default(bool); } }
    public new System.Data.OracleClient.OracleParameter this[int index] { get { return default(System.Data.OracleClient.OracleParameter); } set { } }
    public new System.Data.OracleClient.OracleParameter this[string parameterName] { get { return default(System.Data.OracleClient.OracleParameter); } set { } }
    public override object SyncRoot { get { return default(object); } }
    public System.Data.OracleClient.OracleParameter Add(System.Data.OracleClient.OracleParameter value) { return default(System.Data.OracleClient.OracleParameter); }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public override int Add(object value) { return default(int); }
    public System.Data.OracleClient.OracleParameter Add(string parameterName, System.Data.OracleClient.OracleType dataType) { return default(System.Data.OracleClient.OracleParameter); }
    public System.Data.OracleClient.OracleParameter Add(string parameterName, System.Data.OracleClient.OracleType dataType, int size) { return default(System.Data.OracleClient.OracleParameter); }
    public System.Data.OracleClient.OracleParameter Add(string parameterName, System.Data.OracleClient.OracleType dataType, int size, string srcColumn) { return default(System.Data.OracleClient.OracleParameter); }
    public System.Data.OracleClient.OracleParameter Add(string parameterName, object value) { return default(System.Data.OracleClient.OracleParameter); }
    public override void AddRange(System.Array values) { }
    public void AddRange(System.Data.OracleClient.OracleParameter[] values) { }
    public override void Clear() { }
    public bool Contains(System.Data.OracleClient.OracleParameter value) { return default(bool); }
    public override bool Contains(object value) { return default(bool); }
    public override bool Contains(string parameterName) { return default(bool); }
    public override void CopyTo(System.Array array, int index) { }
    public override System.Collections.IEnumerator GetEnumerator() { return default(System.Collections.IEnumerator); }
    protected override System.Data.Common.DbParameter GetParameter(int index) { return default(System.Data.Common.DbParameter); }
    protected override System.Data.Common.DbParameter GetParameter(string parameterName) { return default(System.Data.Common.DbParameter); }
    public int IndexOf(System.Data.OracleClient.OracleParameter value) { return default(int); }
    public override int IndexOf(object value) { return default(int); }
    public override int IndexOf(string parameterName) { return default(int); }
    public void Insert(int index, System.Data.OracleClient.OracleParameter value) { }
    public override void Insert(int index, object value) { }
    public void Remove(System.Data.OracleClient.OracleParameter value) { }
    public override void Remove(object value) { }
    public override void RemoveAt(int index) { }
    public override void RemoveAt(string parameterName) { }
    protected override void SetParameter(int index, System.Data.Common.DbParameter value) { }
    protected override void SetParameter(string parameterName, System.Data.Common.DbParameter value) { }
  }
  [System.MonoTODOAttribute("Current MS implementation of Data Provider requires FullTrust")]
  public sealed partial class OraclePermission : System.Data.Common.DBDataPermission {
    public OraclePermission(System.Security.Permissions.PermissionState state) { }
    public override System.Security.IPermission Copy() { return default(System.Security.IPermission); }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(109), AllowMultiple=true, Inherited=false)]
  public sealed partial class OraclePermissionAttribute : System.Data.Common.DBDataPermissionAttribute {
    public OraclePermissionAttribute(System.Security.Permissions.SecurityAction action) : base (default(System.Security.Permissions.SecurityAction)) { }
    public override System.Security.IPermission CreatePermission() { return default(System.Security.IPermission); }
  }
  public sealed partial class OracleRowUpdatedEventArgs : System.Data.Common.RowUpdatedEventArgs {
    public OracleRowUpdatedEventArgs(System.Data.DataRow row, System.Data.IDbCommand command, System.Data.StatementType statementType, System.Data.Common.DataTableMapping tableMapping) : base (default(System.Data.DataRow), default(System.Data.IDbCommand), default(System.Data.StatementType), default(System.Data.Common.DataTableMapping)) { }
    public new System.Data.OracleClient.OracleCommand Command { get { return default(System.Data.OracleClient.OracleCommand); } }
  }
  public delegate void OracleRowUpdatedEventHandler(object sender, System.Data.OracleClient.OracleRowUpdatedEventArgs e);
  public sealed partial class OracleRowUpdatingEventArgs : System.Data.Common.RowUpdatingEventArgs {
    public OracleRowUpdatingEventArgs(System.Data.DataRow row, System.Data.IDbCommand command, System.Data.StatementType statementType, System.Data.Common.DataTableMapping tableMapping) : base (default(System.Data.DataRow), default(System.Data.IDbCommand), default(System.Data.StatementType), default(System.Data.Common.DataTableMapping)) { }
    protected override System.Data.IDbCommand BaseCommand { get { return default(System.Data.IDbCommand); } set { } }
    public new System.Data.OracleClient.OracleCommand Command { get { return default(System.Data.OracleClient.OracleCommand); } set { } }
  }
  public delegate void OracleRowUpdatingEventHandler(object sender, System.Data.OracleClient.OracleRowUpdatingEventArgs e);
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct OracleString : System.Data.SqlTypes.INullable, System.IComparable {
    public static readonly System.Data.OracleClient.OracleString Empty;
    public static readonly System.Data.OracleClient.OracleString Null;
    public OracleString(string s) { throw new System.NotImplementedException(); }
    public bool IsNull { get { return default(bool); } }
    public char this[int index] { get { return default(char); } }
    public int Length { get { return default(int); } }
    public string Value { get { return default(string); } }
    public int CompareTo(object obj) { return default(int); }
    public static System.Data.OracleClient.OracleString Concat(System.Data.OracleClient.OracleString x, System.Data.OracleClient.OracleString y) { return default(System.Data.OracleClient.OracleString); }
    public static System.Data.OracleClient.OracleBoolean Equals(System.Data.OracleClient.OracleString x, System.Data.OracleClient.OracleString y) { return default(System.Data.OracleClient.OracleBoolean); }
    public override bool Equals(object value) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public static System.Data.OracleClient.OracleBoolean GreaterThan(System.Data.OracleClient.OracleString x, System.Data.OracleClient.OracleString y) { return default(System.Data.OracleClient.OracleBoolean); }
    public static System.Data.OracleClient.OracleBoolean GreaterThanOrEqual(System.Data.OracleClient.OracleString x, System.Data.OracleClient.OracleString y) { return default(System.Data.OracleClient.OracleBoolean); }
    public static System.Data.OracleClient.OracleBoolean LessThan(System.Data.OracleClient.OracleString x, System.Data.OracleClient.OracleString y) { return default(System.Data.OracleClient.OracleBoolean); }
    public static System.Data.OracleClient.OracleBoolean LessThanOrEqual(System.Data.OracleClient.OracleString x, System.Data.OracleClient.OracleString y) { return default(System.Data.OracleClient.OracleBoolean); }
    public static System.Data.OracleClient.OracleBoolean NotEquals(System.Data.OracleClient.OracleString x, System.Data.OracleClient.OracleString y) { return default(System.Data.OracleClient.OracleBoolean); }
    public static System.Data.OracleClient.OracleString operator +(System.Data.OracleClient.OracleString x, System.Data.OracleClient.OracleString y) { return default(System.Data.OracleClient.OracleString); }
    public static System.Data.OracleClient.OracleBoolean operator ==(System.Data.OracleClient.OracleString x, System.Data.OracleClient.OracleString y) { return default(System.Data.OracleClient.OracleBoolean); }
    public static explicit operator string (System.Data.OracleClient.OracleString x) { return default(string); }
    [System.MonoTODOAttribute]
    public static System.Data.OracleClient.OracleBoolean operator >(System.Data.OracleClient.OracleString x, System.Data.OracleClient.OracleString y) { return default(System.Data.OracleClient.OracleBoolean); }
    [System.MonoTODOAttribute]
    public static System.Data.OracleClient.OracleBoolean operator >=(System.Data.OracleClient.OracleString x, System.Data.OracleClient.OracleString y) { return default(System.Data.OracleClient.OracleBoolean); }
    public static implicit operator System.Data.OracleClient.OracleString (string s) { return default(System.Data.OracleClient.OracleString); }
    public static System.Data.OracleClient.OracleBoolean operator !=(System.Data.OracleClient.OracleString x, System.Data.OracleClient.OracleString y) { return default(System.Data.OracleClient.OracleBoolean); }
    public static System.Data.OracleClient.OracleBoolean operator <(System.Data.OracleClient.OracleString x, System.Data.OracleClient.OracleString y) { return default(System.Data.OracleClient.OracleBoolean); }
    public static System.Data.OracleClient.OracleBoolean operator <=(System.Data.OracleClient.OracleString x, System.Data.OracleClient.OracleString y) { return default(System.Data.OracleClient.OracleBoolean); }
    public override string ToString() { return default(string); }
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct OracleTimeSpan : System.Data.SqlTypes.INullable, System.IComparable {
    public static readonly System.Data.OracleClient.OracleTimeSpan MaxValue;
    public static readonly System.Data.OracleClient.OracleTimeSpan MinValue;
    public static readonly System.Data.OracleClient.OracleTimeSpan Null;
    public OracleTimeSpan(System.Data.OracleClient.OracleTimeSpan from) { throw new System.NotImplementedException(); }
    public OracleTimeSpan(int hours, int minutes, int seconds) { throw new System.NotImplementedException(); }
    public OracleTimeSpan(int days, int hours, int minutes, int seconds) { throw new System.NotImplementedException(); }
    public OracleTimeSpan(int days, int hours, int minutes, int seconds, int milliseconds) { throw new System.NotImplementedException(); }
    public OracleTimeSpan(long ticks) { throw new System.NotImplementedException(); }
    public OracleTimeSpan(System.TimeSpan ts) { throw new System.NotImplementedException(); }
    public int Days { get { return default(int); } }
    public int Hours { get { return default(int); } }
    public bool IsNull { get { return default(bool); } }
    public int Milliseconds { get { return default(int); } }
    public int Minutes { get { return default(int); } }
    public int Seconds { get { return default(int); } }
    public System.TimeSpan Value { get { return default(System.TimeSpan); } }
    public int CompareTo(object obj) { return default(int); }
    public static System.Data.OracleClient.OracleBoolean Equals(System.Data.OracleClient.OracleTimeSpan x, System.Data.OracleClient.OracleTimeSpan y) { return default(System.Data.OracleClient.OracleBoolean); }
    public override bool Equals(object value) { return default(bool); }
    [System.MonoTODOAttribute]
    public override int GetHashCode() { return default(int); }
    public static System.Data.OracleClient.OracleBoolean GreaterThan(System.Data.OracleClient.OracleTimeSpan x, System.Data.OracleClient.OracleTimeSpan y) { return default(System.Data.OracleClient.OracleBoolean); }
    public static System.Data.OracleClient.OracleBoolean GreaterThanOrEqual(System.Data.OracleClient.OracleTimeSpan x, System.Data.OracleClient.OracleTimeSpan y) { return default(System.Data.OracleClient.OracleBoolean); }
    public static System.Data.OracleClient.OracleBoolean LessThan(System.Data.OracleClient.OracleTimeSpan x, System.Data.OracleClient.OracleTimeSpan y) { return default(System.Data.OracleClient.OracleBoolean); }
    public static System.Data.OracleClient.OracleBoolean LessThanOrEqual(System.Data.OracleClient.OracleTimeSpan x, System.Data.OracleClient.OracleTimeSpan y) { return default(System.Data.OracleClient.OracleBoolean); }
    public static System.Data.OracleClient.OracleBoolean NotEquals(System.Data.OracleClient.OracleTimeSpan x, System.Data.OracleClient.OracleTimeSpan y) { return default(System.Data.OracleClient.OracleBoolean); }
    public static System.Data.OracleClient.OracleBoolean operator ==(System.Data.OracleClient.OracleTimeSpan x, System.Data.OracleClient.OracleTimeSpan y) { return default(System.Data.OracleClient.OracleBoolean); }
    public static explicit operator System.TimeSpan (System.Data.OracleClient.OracleTimeSpan x) { return default(System.TimeSpan); }
    public static explicit operator System.Data.OracleClient.OracleTimeSpan (string x) { return default(System.Data.OracleClient.OracleTimeSpan); }
    public static System.Data.OracleClient.OracleBoolean operator >(System.Data.OracleClient.OracleTimeSpan x, System.Data.OracleClient.OracleTimeSpan y) { return default(System.Data.OracleClient.OracleBoolean); }
    public static System.Data.OracleClient.OracleBoolean operator >=(System.Data.OracleClient.OracleTimeSpan x, System.Data.OracleClient.OracleTimeSpan y) { return default(System.Data.OracleClient.OracleBoolean); }
    public static System.Data.OracleClient.OracleBoolean operator !=(System.Data.OracleClient.OracleTimeSpan x, System.Data.OracleClient.OracleTimeSpan y) { return default(System.Data.OracleClient.OracleBoolean); }
    public static System.Data.OracleClient.OracleBoolean operator <(System.Data.OracleClient.OracleTimeSpan x, System.Data.OracleClient.OracleTimeSpan y) { return default(System.Data.OracleClient.OracleBoolean); }
    public static System.Data.OracleClient.OracleBoolean operator <=(System.Data.OracleClient.OracleTimeSpan x, System.Data.OracleClient.OracleTimeSpan y) { return default(System.Data.OracleClient.OracleBoolean); }
    public static System.Data.OracleClient.OracleTimeSpan Parse(string s) { return default(System.Data.OracleClient.OracleTimeSpan); }
    public override string ToString() { return default(string); }
  }
  public sealed partial class OracleTransaction : System.Data.Common.DbTransaction {
    internal OracleTransaction() { }
    public new System.Data.OracleClient.OracleConnection Connection { get { return default(System.Data.OracleClient.OracleConnection); } }
    [System.MonoTODOAttribute]
    protected override System.Data.Common.DbConnection DbConnection { get { return default(System.Data.Common.DbConnection); } }
    public override System.Data.IsolationLevel IsolationLevel { get { return default(System.Data.IsolationLevel); } }
    public override void Commit() { }
    protected override void Dispose(bool disposing) { }
    public override void Rollback() { }
  }
  public enum OracleType {
    BFile = 1,
    Blob = 2,
    Byte = 23,
    Char = 3,
    Clob = 4,
    Cursor = 5,
    DateTime = 6,
    Double = 30,
    Float = 29,
    Int16 = 27,
    Int32 = 28,
    IntervalDayToSecond = 7,
    IntervalYearToMonth = 8,
    LongRaw = 9,
    LongVarChar = 10,
    NChar = 11,
    NClob = 12,
    Number = 13,
    NVarChar = 14,
    Raw = 15,
    RowId = 16,
    SByte = 26,
    Timestamp = 18,
    TimestampLocal = 19,
    TimestampWithTZ = 20,
    UInt16 = 24,
    UInt32 = 25,
    VarChar = 22,
  }
}
