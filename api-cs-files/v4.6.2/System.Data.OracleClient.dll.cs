namespace System.Data.OracleClient {
  public sealed partial class OracleBFile : System.IO.Stream, System.Data.SqlTypes.INullable, System.ICloneable, System.IDisposable {
    internal OracleBFile() { }
    public static readonly new System.Data.OracleClient.OracleBFile Null;
    public override bool CanRead { get { return default(bool); } }
    public override bool CanSeek { get { return default(bool); } }
    public override bool CanWrite { get { return default(bool); } }
    public System.Data.OracleClient.OracleConnection Connection { get { return default(System.Data.OracleClient.OracleConnection); } }
    public string DirectoryName { get { return default(string); } }
    public bool FileExists { get { return default(bool); } }
    public string FileName { get { return default(string); } }
    public bool IsNull { get { return default(bool); } }
    public override long Length { get { return default(long); } }
    public override long Position { get { return default(long); } set { } }
    public object Value { get { return default(object); } }
    public object Clone() { return default(object); }
    public long CopyTo(System.Data.OracleClient.OracleLob destination) { return default(long); }
    public long CopyTo(System.Data.OracleClient.OracleLob destination, long destinationOffset) { return default(long); }
    public long CopyTo(long sourceOffset, System.Data.OracleClient.OracleLob destination, long destinationOffset, long amount) { return default(long); }
    protected override void Dispose(bool disposing) { }
    public override void Flush() { }
    public override int Read(System.Byte[] buffer, int offset, int count) { return default(int); }
    public override long Seek(long offset, System.IO.SeekOrigin origin) { return default(long); }
    public void SetFileName(string directory, string file) { }
    public override void SetLength(long value) { }
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
    public int CompareTo(object obj) { return default(int); }
    public static System.Data.OracleClient.OracleBinary Concat(System.Data.OracleClient.OracleBinary x, System.Data.OracleClient.OracleBinary y) { return default(System.Data.OracleClient.OracleBinary); }
    public static System.Data.OracleClient.OracleBoolean Equals(System.Data.OracleClient.OracleBinary x, System.Data.OracleClient.OracleBinary y) { return default(System.Data.OracleClient.OracleBoolean); }
    public override bool Equals(object value) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public static System.Data.OracleClient.OracleBoolean GreaterThan(System.Data.OracleClient.OracleBinary x, System.Data.OracleClient.OracleBinary y) { return default(System.Data.OracleClient.OracleBoolean); }
    public static System.Data.OracleClient.OracleBoolean GreaterThanOrEqual(System.Data.OracleClient.OracleBinary x, System.Data.OracleClient.OracleBinary y) { return default(System.Data.OracleClient.OracleBoolean); }
    public static System.Data.OracleClient.OracleBoolean LessThan(System.Data.OracleClient.OracleBinary x, System.Data.OracleClient.OracleBinary y) { return default(System.Data.OracleClient.OracleBoolean); }
    public static System.Data.OracleClient.OracleBoolean LessThanOrEqual(System.Data.OracleClient.OracleBinary x, System.Data.OracleClient.OracleBinary y) { return default(System.Data.OracleClient.OracleBoolean); }
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
    public int CompareTo(object obj) { return default(int); }
    public static System.Data.OracleClient.OracleBoolean Equals(System.Data.OracleClient.OracleBoolean x, System.Data.OracleClient.OracleBoolean y) { return default(System.Data.OracleClient.OracleBoolean); }
    public override bool Equals(object value) { return default(bool); }
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
    public static System.Data.OracleClient.OracleBoolean Parse(string s) { return default(System.Data.OracleClient.OracleBoolean); }
    public override string ToString() { return default(string); }
    public static System.Data.OracleClient.OracleBoolean Xor(System.Data.OracleClient.OracleBoolean x, System.Data.OracleClient.OracleBoolean y) { return default(System.Data.OracleClient.OracleBoolean); }
  }
  [System.ObsoleteAttribute("OracleClientFactory has been deprecated. http://go.microsoft.com/fwlink/?LinkID=144260", false)]
  public sealed partial class OracleClientFactory : System.Data.Common.DbProviderFactory {
    internal OracleClientFactory() { }
    public static readonly System.Data.OracleClient.OracleClientFactory Instance;
    public override System.Data.Common.DbCommand CreateCommand() { return default(System.Data.Common.DbCommand); }
    public override System.Data.Common.DbCommandBuilder CreateCommandBuilder() { return default(System.Data.Common.DbCommandBuilder); }
    public override System.Data.Common.DbConnection CreateConnection() { return default(System.Data.Common.DbConnection); }
    public override System.Data.Common.DbConnectionStringBuilder CreateConnectionStringBuilder() { return default(System.Data.Common.DbConnectionStringBuilder); }
    public override System.Data.Common.DbDataAdapter CreateDataAdapter() { return default(System.Data.Common.DbDataAdapter); }
    public override System.Data.Common.DbParameter CreateParameter() { return default(System.Data.Common.DbParameter); }
    public override System.Security.CodeAccessPermission CreatePermission(System.Security.Permissions.PermissionState state) { return default(System.Security.CodeAccessPermission); }
  }
  [System.ComponentModel.DefaultEventAttribute("RecordsAffected")]
  [System.ComponentModel.DesignerAttribute("Microsoft.VSDesigner.Data.VS.OracleCommandDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
  [System.ComponentModel.ToolboxItemAttribute(true)]
  [System.ObsoleteAttribute("OracleCommand has been deprecated. http://go.microsoft.com/fwlink/?LinkID=144260", false)]
  public sealed partial class OracleCommand : System.Data.Common.DbCommand, System.ICloneable {
    public OracleCommand() { }
    public OracleCommand(string commandText) { }
    public OracleCommand(string commandText, System.Data.OracleClient.OracleConnection connection) { }
    public OracleCommand(string commandText, System.Data.OracleClient.OracleConnection connection, System.Data.OracleClient.OracleTransaction tx) { }
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.ComponentModel.EditorAttribute("Microsoft.VSDesigner.Data.Oracle.Design.OracleCommandTextEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
    [System.Data.OracleClient.ResCategoryAttribute("OracleCategory_Data")]
    [System.Data.OracleClient.ResDescriptionAttribute("DbCommand_CommandText")]
    public override string CommandText { get { return default(string); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.Data.OracleClient.ResCategoryAttribute("OracleCategory_Data")]
    [System.Data.OracleClient.ResDescriptionAttribute("DbCommand_CommandTimeout")]
    public override int CommandTimeout { get { return default(int); } set { } }
    [System.ComponentModel.DefaultValueAttribute((System.Data.CommandType)(1))]
    [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
    [System.Data.OracleClient.ResCategoryAttribute("OracleCategory_Data")]
    [System.Data.OracleClient.ResDescriptionAttribute("DbCommand_CommandType")]
    public override System.Data.CommandType CommandType { get { return default(System.Data.CommandType); } set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    [System.ComponentModel.EditorAttribute("Microsoft.VSDesigner.Data.Design.DbConnectionEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.Data.OracleClient.ResCategoryAttribute("OracleCategory_Behavior")]
    [System.Data.OracleClient.ResDescriptionAttribute("DbCommand_Connection")]
    public new System.Data.OracleClient.OracleConnection Connection { get { return default(System.Data.OracleClient.OracleConnection); } set { } }
    protected override System.Data.Common.DbConnection DbConnection { get { return default(System.Data.Common.DbConnection); } set { } }
    protected override System.Data.Common.DbParameterCollection DbParameterCollection { get { return default(System.Data.Common.DbParameterCollection); } }
    protected override System.Data.Common.DbTransaction DbTransaction { get { return default(System.Data.Common.DbTransaction); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute(true)]
    [System.ComponentModel.DesignOnlyAttribute(true)]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public override bool DesignTimeVisible { get { return default(bool); } set { } }
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(2))]
    [System.Data.OracleClient.ResCategoryAttribute("OracleCategory_Data")]
    [System.Data.OracleClient.ResDescriptionAttribute("DbCommand_Parameters")]
    public new System.Data.OracleClient.OracleParameterCollection Parameters { get { return default(System.Data.OracleClient.OracleParameterCollection); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.Data.OracleClient.ResDescriptionAttribute("DbCommand_Transaction")]
    public new System.Data.OracleClient.OracleTransaction Transaction { get { return default(System.Data.OracleClient.OracleTransaction); } set { } }
    [System.ComponentModel.DefaultValueAttribute((System.Data.UpdateRowSource)(3))]
    [System.Data.OracleClient.ResCategoryAttribute("DataCategory_Update")]
    [System.Data.OracleClient.ResDescriptionAttribute("DbCommand_UpdatedRowSource")]
    public override System.Data.UpdateRowSource UpdatedRowSource { get { return default(System.Data.UpdateRowSource); } set { } }
    public override void Cancel() { }
    public object Clone() { return default(object); }
    protected override System.Data.Common.DbParameter CreateDbParameter() { return default(System.Data.Common.DbParameter); }
    public new System.Data.OracleClient.OracleParameter CreateParameter() { return default(System.Data.OracleClient.OracleParameter); }
    protected override System.Data.Common.DbDataReader ExecuteDbDataReader(System.Data.CommandBehavior behavior) { return default(System.Data.Common.DbDataReader); }
    public override int ExecuteNonQuery() { return default(int); }
    public int ExecuteOracleNonQuery(out System.Data.OracleClient.OracleString rowid) { rowid = default(System.Data.OracleClient.OracleString); return default(int); }
    public object ExecuteOracleScalar() { return default(object); }
    public new System.Data.OracleClient.OracleDataReader ExecuteReader() { return default(System.Data.OracleClient.OracleDataReader); }
    public new System.Data.OracleClient.OracleDataReader ExecuteReader(System.Data.CommandBehavior behavior) { return default(System.Data.OracleClient.OracleDataReader); }
    public override object ExecuteScalar() { return default(object); }
    public override void Prepare() { }
    public void ResetCommandTimeout() { }
  }
  [System.ObsoleteAttribute("OracleCommandBuilder has been deprecated. http://go.microsoft.com/fwlink/?LinkID=144260", false)]
  public sealed partial class OracleCommandBuilder : System.Data.Common.DbCommandBuilder {
    public OracleCommandBuilder() { }
    public OracleCommandBuilder(System.Data.OracleClient.OracleDataAdapter adapter) { }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public override System.Data.Common.CatalogLocation CatalogLocation { get { return default(System.Data.Common.CatalogLocation); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public override string CatalogSeparator { get { return default(string); } set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    [System.Data.OracleClient.ResCategoryAttribute("OracleCategory_Update")]
    [System.Data.OracleClient.ResDescriptionAttribute("OracleCommandBuilder_DataAdapter")]
    public new System.Data.OracleClient.OracleDataAdapter DataAdapter { get { return default(System.Data.OracleClient.OracleDataAdapter); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public override string SchemaSeparator { get { return default(string); } set { } }
    protected override void ApplyParameterInfo(System.Data.Common.DbParameter parameter, System.Data.DataRow datarow, System.Data.StatementType statementType, bool whereClause) { }
    public static void DeriveParameters(System.Data.OracleClient.OracleCommand command) { }
    public new System.Data.OracleClient.OracleCommand GetDeleteCommand() { return default(System.Data.OracleClient.OracleCommand); }
    public new System.Data.OracleClient.OracleCommand GetDeleteCommand(bool useColumnsForParameterNames) { return default(System.Data.OracleClient.OracleCommand); }
    public new System.Data.OracleClient.OracleCommand GetInsertCommand() { return default(System.Data.OracleClient.OracleCommand); }
    public new System.Data.OracleClient.OracleCommand GetInsertCommand(bool useColumnsForParameterNames) { return default(System.Data.OracleClient.OracleCommand); }
    protected override string GetParameterName(int parameterOrdinal) { return default(string); }
    protected override string GetParameterName(string parameterName) { return default(string); }
    protected override string GetParameterPlaceholder(int parameterOrdinal) { return default(string); }
    public new System.Data.OracleClient.OracleCommand GetUpdateCommand() { return default(System.Data.OracleClient.OracleCommand); }
    public new System.Data.OracleClient.OracleCommand GetUpdateCommand(bool useColumnsForParameterNames) { return default(System.Data.OracleClient.OracleCommand); }
    public override string QuoteIdentifier(string unquotedIdentifier) { return default(string); }
    protected override void SetRowUpdatingHandler(System.Data.Common.DbDataAdapter adapter) { }
    public override string UnquoteIdentifier(string quotedIdentifier) { return default(string); }
  }
  [System.ComponentModel.DefaultEventAttribute("InfoMessage")]
  [System.ObsoleteAttribute("OracleConnection has been deprecated. http://go.microsoft.com/fwlink/?LinkID=144260", false)]
  public sealed partial class OracleConnection : System.Data.Common.DbConnection, System.ICloneable {
    public OracleConnection() { }
    public OracleConnection(string connectionString) { }
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.ComponentModel.EditorAttribute("Microsoft.VSDesigner.Data.Oracle.Design.OracleConnectionStringEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.RecommendedAsConfigurableAttribute(true)]
    [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
    [System.ComponentModel.SettingsBindableAttribute(true)]
    [System.Data.OracleClient.ResCategoryAttribute("OracleCategory_Data")]
    [System.Data.OracleClient.ResDescriptionAttribute("OracleConnection_ConnectionString")]
    public override string ConnectionString { get { return default(string); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public override int ConnectionTimeout { get { return default(int); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public override string Database { get { return default(string); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.Data.OracleClient.ResDescriptionAttribute("OracleConnection_DataSource")]
    public override string DataSource { get { return default(string); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.Data.OracleClient.ResDescriptionAttribute("OracleConnection_ServerVersion")]
    public override string ServerVersion { get { return default(string); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.Data.OracleClient.ResDescriptionAttribute("DbConnection_State")]
    public override System.Data.ConnectionState State { get { return default(System.Data.ConnectionState); } }
    [System.Data.OracleClient.ResCategoryAttribute("OracleCategory_InfoMessage")]
    [System.Data.OracleClient.ResDescriptionAttribute("OracleConnection_InfoMessage")]
    public event System.Data.OracleClient.OracleInfoMessageEventHandler InfoMessage { add { } remove { } }
  }
}
