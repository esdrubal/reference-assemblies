namespace Microsoft.SqlServer.Server {
  public enum DataAccessKind {
    None = 0,
    Read = 1,
  }
  public enum Format {
    Native = 1,
    Unknown = 0,
    UserDefined = 2,
  }
  public partial interface IBinarySerialize {
    void Read(System.IO.BinaryReader r);
    void Write(System.IO.BinaryWriter w);
  }
  public sealed partial class InvalidUdtException : System.SystemException {
    internal InvalidUdtException() { }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(128))]
    public override void GetObjectData(System.Runtime.Serialization.SerializationInfo si, System.Runtime.Serialization.StreamingContext context) { }
  }
  public sealed partial class SqlContext {
    internal SqlContext() { }
    public static bool IsAvailable { get { return default(bool); } }
    public static Microsoft.SqlServer.Server.SqlPipe Pipe { get { return default(Microsoft.SqlServer.Server.SqlPipe); } }
    public static Microsoft.SqlServer.Server.SqlTriggerContext TriggerContext { get { return default(Microsoft.SqlServer.Server.SqlTriggerContext); } }
    public static System.Security.Principal.WindowsIdentity WindowsIdentity { get { return default(System.Security.Principal.WindowsIdentity); } }
  }
  public partial class SqlDataRecord : System.Data.IDataRecord {
    public SqlDataRecord(params Microsoft.SqlServer.Server.SqlMetaData[] metaData) { }
    public virtual int FieldCount { get { return default(int); } }
    public virtual object this[int ordinal] { get { return default(object); } }
    public virtual object this[string name] { get { return default(object); } }
    public virtual bool GetBoolean(int ordinal) { return default(bool); }
    public virtual byte GetByte(int ordinal) { return default(byte); }
    public virtual long GetBytes(int ordinal, long fieldOffset, System.Byte[] buffer, int bufferOffset, int length) { return default(long); }
    public virtual char GetChar(int ordinal) { return default(char); }
    public virtual long GetChars(int ordinal, long fieldOffset, System.Char[] buffer, int bufferOffset, int length) { return default(long); }
    public virtual string GetDataTypeName(int ordinal) { return default(string); }
    public virtual System.DateTime GetDateTime(int ordinal) { return default(System.DateTime); }
    public virtual System.DateTimeOffset GetDateTimeOffset(int ordinal) { return default(System.DateTimeOffset); }
    public virtual decimal GetDecimal(int ordinal) { return default(decimal); }
    public virtual double GetDouble(int ordinal) { return default(double); }
    public virtual System.Type GetFieldType(int ordinal) { return default(System.Type); }
    public virtual float GetFloat(int ordinal) { return default(float); }
    public virtual System.Guid GetGuid(int ordinal) { return default(System.Guid); }
    public virtual short GetInt16(int ordinal) { return default(short); }
    public virtual int GetInt32(int ordinal) { return default(int); }
    public virtual long GetInt64(int ordinal) { return default(long); }
    public virtual string GetName(int ordinal) { return default(string); }
    public virtual int GetOrdinal(string name) { return default(int); }
    public virtual System.Data.SqlTypes.SqlBinary GetSqlBinary(int ordinal) { return default(System.Data.SqlTypes.SqlBinary); }
    public virtual System.Data.SqlTypes.SqlBoolean GetSqlBoolean(int ordinal) { return default(System.Data.SqlTypes.SqlBoolean); }
    public virtual System.Data.SqlTypes.SqlByte GetSqlByte(int ordinal) { return default(System.Data.SqlTypes.SqlByte); }
    public virtual System.Data.SqlTypes.SqlBytes GetSqlBytes(int ordinal) { return default(System.Data.SqlTypes.SqlBytes); }
    public virtual System.Data.SqlTypes.SqlChars GetSqlChars(int ordinal) { return default(System.Data.SqlTypes.SqlChars); }
    public virtual System.Data.SqlTypes.SqlDateTime GetSqlDateTime(int ordinal) { return default(System.Data.SqlTypes.SqlDateTime); }
    public virtual System.Data.SqlTypes.SqlDecimal GetSqlDecimal(int ordinal) { return default(System.Data.SqlTypes.SqlDecimal); }
    public virtual System.Data.SqlTypes.SqlDouble GetSqlDouble(int ordinal) { return default(System.Data.SqlTypes.SqlDouble); }
    public virtual System.Type GetSqlFieldType(int ordinal) { return default(System.Type); }
    public virtual System.Data.SqlTypes.SqlGuid GetSqlGuid(int ordinal) { return default(System.Data.SqlTypes.SqlGuid); }
    public virtual System.Data.SqlTypes.SqlInt16 GetSqlInt16(int ordinal) { return default(System.Data.SqlTypes.SqlInt16); }
    public virtual System.Data.SqlTypes.SqlInt32 GetSqlInt32(int ordinal) { return default(System.Data.SqlTypes.SqlInt32); }
    public virtual System.Data.SqlTypes.SqlInt64 GetSqlInt64(int ordinal) { return default(System.Data.SqlTypes.SqlInt64); }
    public virtual Microsoft.SqlServer.Server.SqlMetaData GetSqlMetaData(int ordinal) { return default(Microsoft.SqlServer.Server.SqlMetaData); }
    public virtual System.Data.SqlTypes.SqlMoney GetSqlMoney(int ordinal) { return default(System.Data.SqlTypes.SqlMoney); }
    public virtual System.Data.SqlTypes.SqlSingle GetSqlSingle(int ordinal) { return default(System.Data.SqlTypes.SqlSingle); }
    public virtual System.Data.SqlTypes.SqlString GetSqlString(int ordinal) { return default(System.Data.SqlTypes.SqlString); }
    public virtual object GetSqlValue(int ordinal) { return default(object); }
    public virtual int GetSqlValues(System.Object[] values) { return default(int); }
    public virtual System.Data.SqlTypes.SqlXml GetSqlXml(int ordinal) { return default(System.Data.SqlTypes.SqlXml); }
    public virtual string GetString(int ordinal) { return default(string); }
    public virtual System.TimeSpan GetTimeSpan(int ordinal) { return default(System.TimeSpan); }
    public virtual object GetValue(int ordinal) { return default(object); }
    public virtual int GetValues(System.Object[] values) { return default(int); }
    public virtual bool IsDBNull(int ordinal) { return default(bool); }
    public virtual void SetBoolean(int ordinal, bool value) { }
    public virtual void SetByte(int ordinal, byte value) { }
    public virtual void SetBytes(int ordinal, long fieldOffset, System.Byte[] buffer, int bufferOffset, int length) { }
    public virtual void SetChar(int ordinal, char value) { }
    public virtual void SetChars(int ordinal, long fieldOffset, System.Char[] buffer, int bufferOffset, int length) { }
    public virtual void SetDateTime(int ordinal, System.DateTime value) { }
    public virtual void SetDateTimeOffset(int ordinal, System.DateTimeOffset value) { }
    public virtual void SetDBNull(int ordinal) { }
    public virtual void SetDecimal(int ordinal, decimal value) { }
    public virtual void SetDouble(int ordinal, double value) { }
    public virtual void SetFloat(int ordinal, float value) { }
    public virtual void SetGuid(int ordinal, System.Guid value) { }
    public virtual void SetInt16(int ordinal, short value) { }
    public virtual void SetInt32(int ordinal, int value) { }
    public virtual void SetInt64(int ordinal, long value) { }
    public virtual void SetSqlBinary(int ordinal, System.Data.SqlTypes.SqlBinary value) { }
    public virtual void SetSqlBoolean(int ordinal, System.Data.SqlTypes.SqlBoolean value) { }
    public virtual void SetSqlByte(int ordinal, System.Data.SqlTypes.SqlByte value) { }
    public virtual void SetSqlBytes(int ordinal, System.Data.SqlTypes.SqlBytes value) { }
    public virtual void SetSqlChars(int ordinal, System.Data.SqlTypes.SqlChars value) { }
    public virtual void SetSqlDateTime(int ordinal, System.Data.SqlTypes.SqlDateTime value) { }
    public virtual void SetSqlDecimal(int ordinal, System.Data.SqlTypes.SqlDecimal value) { }
    public virtual void SetSqlDouble(int ordinal, System.Data.SqlTypes.SqlDouble value) { }
    public virtual void SetSqlGuid(int ordinal, System.Data.SqlTypes.SqlGuid value) { }
    public virtual void SetSqlInt16(int ordinal, System.Data.SqlTypes.SqlInt16 value) { }
    public virtual void SetSqlInt32(int ordinal, System.Data.SqlTypes.SqlInt32 value) { }
    public virtual void SetSqlInt64(int ordinal, System.Data.SqlTypes.SqlInt64 value) { }
    public virtual void SetSqlMoney(int ordinal, System.Data.SqlTypes.SqlMoney value) { }
    public virtual void SetSqlSingle(int ordinal, System.Data.SqlTypes.SqlSingle value) { }
    public virtual void SetSqlString(int ordinal, System.Data.SqlTypes.SqlString value) { }
    public virtual void SetSqlXml(int ordinal, System.Data.SqlTypes.SqlXml value) { }
    public virtual void SetString(int ordinal, string value) { }
    public virtual void SetTimeSpan(int ordinal, System.TimeSpan value) { }
    public virtual void SetValue(int ordinal, object value) { }
    public virtual int SetValues(params System.Object[] values) { return default(int); }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    System.Data.IDataReader System.Data.IDataRecord.GetData(int ordinal) { return default(System.Data.IDataReader); }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(10624), AllowMultiple=false, Inherited=false)]
  public partial class SqlFacetAttribute : System.Attribute {
    public SqlFacetAttribute() { }
    public bool IsFixedLength { get { return default(bool); } set { } }
    public bool IsNullable { get { return default(bool); } set { } }
    public int MaxSize { get { return default(int); } set { } }
    public int Precision { get { return default(int); } set { } }
    public int Scale { get { return default(int); } set { } }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(64), AllowMultiple=false, Inherited=false)]
  public partial class SqlFunctionAttribute : System.Attribute {
    public SqlFunctionAttribute() { }
    public Microsoft.SqlServer.Server.DataAccessKind DataAccess { get { return default(Microsoft.SqlServer.Server.DataAccessKind); } set { } }
    public string FillRowMethodName { get { return default(string); } set { } }
    public bool IsDeterministic { get { return default(bool); } set { } }
    public bool IsPrecise { get { return default(bool); } set { } }
    public string Name { get { return default(string); } set { } }
    public Microsoft.SqlServer.Server.SystemDataAccessKind SystemDataAccess { get { return default(Microsoft.SqlServer.Server.SystemDataAccessKind); } set { } }
    public string TableDefinition { get { return default(string); } set { } }
  }
  public sealed partial class SqlMetaData {
    public SqlMetaData(string name, System.Data.SqlDbType dbType) { }
    public SqlMetaData(string name, System.Data.SqlDbType dbType, bool useServerDefault, bool isUniqueKey, System.Data.SqlClient.SortOrder columnSortOrder, int sortOrdinal) { }
    public SqlMetaData(string name, System.Data.SqlDbType dbType, byte precision, byte scale) { }
    public SqlMetaData(string name, System.Data.SqlDbType dbType, byte precision, byte scale, bool useServerDefault, bool isUniqueKey, System.Data.SqlClient.SortOrder columnSortOrder, int sortOrdinal) { }
    public SqlMetaData(string name, System.Data.SqlDbType dbType, long maxLength) { }
    public SqlMetaData(string name, System.Data.SqlDbType dbType, long maxLength, bool useServerDefault, bool isUniqueKey, System.Data.SqlClient.SortOrder columnSortOrder, int sortOrdinal) { }
    public SqlMetaData(string name, System.Data.SqlDbType dbType, long maxLength, byte precision, byte scale, long locale, System.Data.SqlTypes.SqlCompareOptions compareOptions, System.Type userDefinedType) { }
    public SqlMetaData(string name, System.Data.SqlDbType dbType, long maxLength, byte precision, byte scale, long localeId, System.Data.SqlTypes.SqlCompareOptions compareOptions, System.Type userDefinedType, bool useServerDefault, bool isUniqueKey, System.Data.SqlClient.SortOrder columnSortOrder, int sortOrdinal) { }
    public SqlMetaData(string name, System.Data.SqlDbType dbType, long maxLength, long locale, System.Data.SqlTypes.SqlCompareOptions compareOptions) { }
    public SqlMetaData(string name, System.Data.SqlDbType dbType, long maxLength, long locale, System.Data.SqlTypes.SqlCompareOptions compareOptions, bool useServerDefault, bool isUniqueKey, System.Data.SqlClient.SortOrder columnSortOrder, int sortOrdinal) { }
    public SqlMetaData(string name, System.Data.SqlDbType dbType, string database, string owningSchema, string objectName) { }
    public SqlMetaData(string name, System.Data.SqlDbType dbType, string database, string owningSchema, string objectName, bool useServerDefault, bool isUniqueKey, System.Data.SqlClient.SortOrder columnSortOrder, int sortOrdinal) { }
    public SqlMetaData(string name, System.Data.SqlDbType dbType, System.Type userDefinedType) { }
    public SqlMetaData(string name, System.Data.SqlDbType dbType, System.Type userDefinedType, string serverTypeName) { }
    public SqlMetaData(string name, System.Data.SqlDbType dbType, System.Type userDefinedType, string serverTypeName, bool useServerDefault, bool isUniqueKey, System.Data.SqlClient.SortOrder columnSortOrder, int sortOrdinal) { }
    public System.Data.SqlTypes.SqlCompareOptions CompareOptions { get { return default(System.Data.SqlTypes.SqlCompareOptions); } }
    public System.Data.DbType DbType { get { return default(System.Data.DbType); } }
    public bool IsUniqueKey { get { return default(bool); } }
    public long LocaleId { get { return default(long); } }
    public static long Max { get { return default(long); } }
    public long MaxLength { get { return default(long); } }
    public string Name { get { return default(string); } }
    public byte Precision { get { return default(byte); } }
    public byte Scale { get { return default(byte); } }
    public System.Data.SqlClient.SortOrder SortOrder { get { return default(System.Data.SqlClient.SortOrder); } }
    public int SortOrdinal { get { return default(int); } }
    public System.Data.SqlDbType SqlDbType { get { return default(System.Data.SqlDbType); } }
    public System.Type Type { get { return default(System.Type); } }
    public string TypeName { get { return default(string); } }
    public bool UseServerDefault { get { return default(bool); } }
    public string XmlSchemaCollectionDatabase { get { return default(string); } }
    public string XmlSchemaCollectionName { get { return default(string); } }
    public string XmlSchemaCollectionOwningSchema { get { return default(string); } }
    public bool Adjust(bool value) { return default(bool); }
    public byte Adjust(byte value) { return default(byte); }
    public System.Byte[] Adjust(System.Byte[] value) { return default(System.Byte[]); }
    public char Adjust(char value) { return default(char); }
    public System.Char[] Adjust(System.Char[] value) { return default(System.Char[]); }
    public System.Data.SqlTypes.SqlBinary Adjust(System.Data.SqlTypes.SqlBinary value) { return default(System.Data.SqlTypes.SqlBinary); }
    public System.Data.SqlTypes.SqlBoolean Adjust(System.Data.SqlTypes.SqlBoolean value) { return default(System.Data.SqlTypes.SqlBoolean); }
    public System.Data.SqlTypes.SqlByte Adjust(System.Data.SqlTypes.SqlByte value) { return default(System.Data.SqlTypes.SqlByte); }
    public System.Data.SqlTypes.SqlBytes Adjust(System.Data.SqlTypes.SqlBytes value) { return default(System.Data.SqlTypes.SqlBytes); }
    public System.Data.SqlTypes.SqlChars Adjust(System.Data.SqlTypes.SqlChars value) { return default(System.Data.SqlTypes.SqlChars); }
    public System.Data.SqlTypes.SqlDateTime Adjust(System.Data.SqlTypes.SqlDateTime value) { return default(System.Data.SqlTypes.SqlDateTime); }
    public System.Data.SqlTypes.SqlDecimal Adjust(System.Data.SqlTypes.SqlDecimal value) { return default(System.Data.SqlTypes.SqlDecimal); }
    public System.Data.SqlTypes.SqlDouble Adjust(System.Data.SqlTypes.SqlDouble value) { return default(System.Data.SqlTypes.SqlDouble); }
    public System.Data.SqlTypes.SqlGuid Adjust(System.Data.SqlTypes.SqlGuid value) { return default(System.Data.SqlTypes.SqlGuid); }
    public System.Data.SqlTypes.SqlInt16 Adjust(System.Data.SqlTypes.SqlInt16 value) { return default(System.Data.SqlTypes.SqlInt16); }
    public System.Data.SqlTypes.SqlInt32 Adjust(System.Data.SqlTypes.SqlInt32 value) { return default(System.Data.SqlTypes.SqlInt32); }
    public System.Data.SqlTypes.SqlInt64 Adjust(System.Data.SqlTypes.SqlInt64 value) { return default(System.Data.SqlTypes.SqlInt64); }
    public System.Data.SqlTypes.SqlMoney Adjust(System.Data.SqlTypes.SqlMoney value) { return default(System.Data.SqlTypes.SqlMoney); }
    public System.Data.SqlTypes.SqlSingle Adjust(System.Data.SqlTypes.SqlSingle value) { return default(System.Data.SqlTypes.SqlSingle); }
    public System.Data.SqlTypes.SqlString Adjust(System.Data.SqlTypes.SqlString value) { return default(System.Data.SqlTypes.SqlString); }
    public System.Data.SqlTypes.SqlXml Adjust(System.Data.SqlTypes.SqlXml value) { return default(System.Data.SqlTypes.SqlXml); }
    public System.DateTime Adjust(System.DateTime value) { return default(System.DateTime); }
    public System.DateTimeOffset Adjust(System.DateTimeOffset value) { return default(System.DateTimeOffset); }
    public decimal Adjust(decimal value) { return default(decimal); }
    public double Adjust(double value) { return default(double); }
    public System.Guid Adjust(System.Guid value) { return default(System.Guid); }
    public short Adjust(short value) { return default(short); }
    public int Adjust(int value) { return default(int); }
    public long Adjust(long value) { return default(long); }
    public object Adjust(object value) { return default(object); }
    public float Adjust(float value) { return default(float); }
    public string Adjust(string value) { return default(string); }
    public System.TimeSpan Adjust(System.TimeSpan value) { return default(System.TimeSpan); }
    public static Microsoft.SqlServer.Server.SqlMetaData InferFromValue(object value, string name) { return default(Microsoft.SqlServer.Server.SqlMetaData); }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(64), AllowMultiple=false, Inherited=false)]
  public sealed partial class SqlMethodAttribute : Microsoft.SqlServer.Server.SqlFunctionAttribute {
    public SqlMethodAttribute() { }
    public bool InvokeIfReceiverIsNull { get { return default(bool); } set { } }
    public bool IsMutator { get { return default(bool); } set { } }
    public bool OnNullCall { get { return default(bool); } set { } }
  }
  public sealed partial class SqlPipe {
    internal SqlPipe() { }
    public bool IsSendingResults { get { return default(bool); } }
    public void ExecuteAndSend(System.Data.SqlClient.SqlCommand command) { }
    public void Send(Microsoft.SqlServer.Server.SqlDataRecord record) { }
    public void Send(System.Data.SqlClient.SqlDataReader reader) { }
    public void Send(string message) { }
    public void SendResultsEnd() { }
    public void SendResultsRow(Microsoft.SqlServer.Server.SqlDataRecord record) { }
    public void SendResultsStart(Microsoft.SqlServer.Server.SqlDataRecord record) { }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(64), AllowMultiple=false, Inherited=false)]
  public sealed partial class SqlProcedureAttribute : System.Attribute {
    public SqlProcedureAttribute() { }
    public string Name { get { return default(string); } set { } }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(64), AllowMultiple=false, Inherited=false)]
  public sealed partial class SqlTriggerAttribute : System.Attribute {
    public SqlTriggerAttribute() { }
    public string Event { get { return default(string); } set { } }
    public string Name { get { return default(string); } set { } }
    public string Target { get { return default(string); } set { } }
  }
  public sealed partial class SqlTriggerContext {
    internal SqlTriggerContext() { }
    public int ColumnCount { get { return default(int); } }
    public System.Data.SqlTypes.SqlXml EventData { get { return default(System.Data.SqlTypes.SqlXml); } }
    public Microsoft.SqlServer.Server.TriggerAction TriggerAction { get { return default(Microsoft.SqlServer.Server.TriggerAction); } }
    public bool IsUpdatedColumn(int columnOrdinal) { return default(bool); }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(12), AllowMultiple=false, Inherited=false)]
  public sealed partial class SqlUserDefinedAggregateAttribute : System.Attribute {
    public const int MaxByteSizeValue = 8000;
    public SqlUserDefinedAggregateAttribute(Microsoft.SqlServer.Server.Format format) { }
    public Microsoft.SqlServer.Server.Format Format { get { return default(Microsoft.SqlServer.Server.Format); } }
    public bool IsInvariantToDuplicates { get { return default(bool); } set { } }
    public bool IsInvariantToNulls { get { return default(bool); } set { } }
    public bool IsInvariantToOrder { get { return default(bool); } set { } }
    public bool IsNullIfEmpty { get { return default(bool); } set { } }
    public int MaxByteSize { get { return default(int); } set { } }
    public string Name { get { return default(string); } set { } }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(12), AllowMultiple=false, Inherited=true)]
  public sealed partial class SqlUserDefinedTypeAttribute : System.Attribute {
    public SqlUserDefinedTypeAttribute(Microsoft.SqlServer.Server.Format format) { }
    public Microsoft.SqlServer.Server.Format Format { get { return default(Microsoft.SqlServer.Server.Format); } }
    public bool IsByteOrdered { get { return default(bool); } set { } }
    public bool IsFixedLength { get { return default(bool); } set { } }
    public int MaxByteSize { get { return default(int); } set { } }
    public string Name { get { return default(string); } set { } }
    public string ValidationMethodName { get { return default(string); } set { } }
  }
  public enum SystemDataAccessKind {
    None = 0,
    Read = 1,
  }
  public enum TriggerAction {
    AlterAppRole = 138,
    AlterAssembly = 102,
    AlterBinding = 175,
    AlterFunction = 62,
    AlterIndex = 25,
    AlterLogin = 145,
    AlterPartitionFunction = 192,
    AlterPartitionScheme = 195,
    AlterProcedure = 52,
    AlterQueue = 158,
    AlterRole = 135,
    AlterRoute = 165,
    AlterSchema = 142,
    AlterService = 162,
    AlterTable = 22,
    AlterTrigger = 72,
    AlterUser = 132,
    AlterView = 42,
    CreateAppRole = 137,
    CreateAssembly = 101,
    CreateBinding = 174,
    CreateContract = 154,
    CreateEventNotification = 74,
    CreateFunction = 61,
    CreateIndex = 24,
    CreateLogin = 144,
    CreateMsgType = 151,
    CreatePartitionFunction = 191,
    CreatePartitionScheme = 194,
    CreateProcedure = 51,
    CreateQueue = 157,
    CreateRole = 134,
    CreateRoute = 164,
    CreateSchema = 141,
    CreateSecurityExpression = 31,
    CreateService = 161,
    CreateSynonym = 34,
    CreateTable = 21,
    CreateTrigger = 71,
    CreateType = 91,
    CreateUser = 131,
    CreateView = 41,
    Delete = 3,
    DenyObject = 171,
    DenyStatement = 168,
    DropAppRole = 139,
    DropAssembly = 103,
    DropBinding = 176,
    DropContract = 156,
    DropEventNotification = 76,
    DropFunction = 63,
    DropIndex = 26,
    DropLogin = 146,
    DropMsgType = 153,
    DropPartitionFunction = 193,
    DropPartitionScheme = 196,
    DropProcedure = 53,
    DropQueue = 159,
    DropRole = 136,
    DropRoute = 166,
    DropSchema = 143,
    DropSecurityExpression = 33,
    DropService = 163,
    DropSynonym = 36,
    DropTable = 23,
    DropTrigger = 73,
    DropType = 93,
    DropUser = 133,
    DropView = 43,
    GrantObject = 170,
    GrantStatement = 167,
    Insert = 1,
    Invalid = 0,
    RevokeObject = 172,
    RevokeStatement = 169,
    Update = 2,
  }
}
namespace System.Data {
  public enum AcceptRejectRule {
    Cascade = 1,
    None = 0,
  }
  [System.FlagsAttribute]
  public enum CommandBehavior {
    CloseConnection = 32,
    Default = 0,
    KeyInfo = 4,
    SchemaOnly = 2,
    SequentialAccess = 16,
    SingleResult = 1,
    SingleRow = 8,
  }
  public enum CommandType {
    StoredProcedure = 4,
    TableDirect = 512,
    Text = 1,
  }
  public enum ConflictOption {
    CompareAllSearchableValues = 1,
    CompareRowVersion = 2,
    OverwriteChanges = 3,
  }
  [System.FlagsAttribute]
  public enum ConnectionState {
    Broken = 16,
    Closed = 0,
    Connecting = 2,
    Executing = 4,
    Fetching = 8,
    Open = 1,
  }
  [System.ComponentModel.DefaultPropertyAttribute("ConstraintName")]
  [System.ComponentModel.TypeConverterAttribute(typeof(System.Data.ConstraintConverter))]
  public abstract partial class Constraint {
    protected Constraint() { }
    [System.CLSCompliantAttribute(false)]
    protected virtual System.Data.DataSet _DataSet { get { return default(System.Data.DataSet); } }
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.Data.ResCategoryAttribute("DataCategory_Data")]
    [System.Data.ResDescriptionAttribute("ConstraintNameDescr")]
    public virtual string ConstraintName { get { return default(string); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.Data.ResCategoryAttribute("DataCategory_Data")]
    [System.Data.ResDescriptionAttribute("ExtendedPropertiesDescr")]
    public System.Data.PropertyCollection ExtendedProperties { get { return default(System.Data.PropertyCollection); } }
    [System.Data.ResDescriptionAttribute("ConstraintTableDescr")]
    public abstract System.Data.DataTable Table { get; }
    protected void CheckStateForProperty() { }
    protected internal void SetDataSet(System.Data.DataSet dataSet) { }
    public override string ToString() { return default(string); }
  }
  [System.ComponentModel.DefaultEventAttribute("CollectionChanged")]
  [System.ComponentModel.EditorAttribute("Microsoft.VSDesigner.Data.Design.ConstraintsCollectionEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
  public sealed partial class ConstraintCollection : System.Data.InternalDataCollectionBase {
    internal ConstraintCollection() { }
    public System.Data.Constraint this[int index] { get { return default(System.Data.Constraint); } }
    public System.Data.Constraint this[string name] { get { return default(System.Data.Constraint); } }
    protected override System.Collections.ArrayList List { get { return default(System.Collections.ArrayList); } }
    public event System.ComponentModel.CollectionChangeEventHandler CollectionChanged { add { } remove { } }
    public void Add(System.Data.Constraint constraint) { }
    public System.Data.Constraint Add(string name, System.Data.DataColumn column, bool primaryKey) { return default(System.Data.Constraint); }
    public System.Data.Constraint Add(string name, System.Data.DataColumn primaryKeyColumn, System.Data.DataColumn foreignKeyColumn) { return default(System.Data.Constraint); }
    public System.Data.Constraint Add(string name, System.Data.DataColumn[] columns, bool primaryKey) { return default(System.Data.Constraint); }
    public System.Data.Constraint Add(string name, System.Data.DataColumn[] primaryKeyColumns, System.Data.DataColumn[] foreignKeyColumns) { return default(System.Data.Constraint); }
    public void AddRange(System.Data.Constraint[] constraints) { }
    public bool CanRemove(System.Data.Constraint constraint) { return default(bool); }
    public void Clear() { }
    public bool Contains(string name) { return default(bool); }
    public void CopyTo(System.Data.Constraint[] array, int index) { }
    public int IndexOf(System.Data.Constraint constraint) { return default(int); }
    public int IndexOf(string constraintName) { return default(int); }
    public void Remove(System.Data.Constraint constraint) { }
    public void Remove(string name) { }
    public void RemoveAt(int index) { }
  }
  public partial class ConstraintException : System.Data.DataException {
    public ConstraintException() { }
    protected ConstraintException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public ConstraintException(string s) { }
    public ConstraintException(string message, System.Exception innerException) { }
  }
  [System.ComponentModel.DefaultPropertyAttribute("ColumnName")]
  [System.ComponentModel.DesignTimeVisibleAttribute(false)]
  [System.ComponentModel.EditorAttribute("Microsoft.VSDesigner.Data.Design.DataColumnEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
  [System.ComponentModel.ToolboxItemAttribute(false)]
  public partial class DataColumn : System.ComponentModel.MarshalByValueComponent {
    public DataColumn() { }
    public DataColumn(string columnName) { }
    public DataColumn(string columnName, System.Type dataType) { }
    public DataColumn(string columnName, System.Type dataType, string expr) { }
    public DataColumn(string columnName, System.Type dataType, string expr, System.Data.MappingType type) { }
    [System.ComponentModel.DefaultValueAttribute(true)]
    [System.Data.ResCategoryAttribute("DataCategory_Data")]
    [System.Data.ResDescriptionAttribute("DataColumnAllowNullDescr")]
    public bool AllowDBNull { get { return default(bool); } set { } }
    [System.ComponentModel.DefaultValueAttribute(false)]
    [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
    [System.Data.ResCategoryAttribute("DataCategory_Data")]
    [System.Data.ResDescriptionAttribute("DataColumnAutoIncrementDescr")]
    public bool AutoIncrement { get { return default(bool); } set { } }
    [System.ComponentModel.DefaultValueAttribute((long)0)]
    [System.Data.ResCategoryAttribute("DataCategory_Data")]
    [System.Data.ResDescriptionAttribute("DataColumnAutoIncrementSeedDescr")]
    public long AutoIncrementSeed { get { return default(long); } set { } }
    [System.ComponentModel.DefaultValueAttribute((long)1)]
    [System.Data.ResCategoryAttribute("DataCategory_Data")]
    [System.Data.ResDescriptionAttribute("DataColumnAutoIncrementStepDescr")]
    public long AutoIncrementStep { get { return default(long); } set { } }
    [System.Data.ResCategoryAttribute("DataCategory_Data")]
    [System.Data.ResDescriptionAttribute("DataColumnCaptionDescr")]
    public string Caption { get { return default(string); } set { } }
    [System.ComponentModel.DefaultValueAttribute((System.Data.MappingType)(1))]
    [System.Data.ResDescriptionAttribute("DataColumnMappingDescr")]
    public virtual System.Data.MappingType ColumnMapping { get { return default(System.Data.MappingType); } set { } }
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
    [System.Data.ResCategoryAttribute("DataCategory_Data")]
    [System.Data.ResDescriptionAttribute("DataColumnColumnNameDescr")]
    public string ColumnName { get { return default(string); } set { } }
    [System.ComponentModel.DefaultValueAttribute(typeof(string))]
    [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Data.ColumnTypeConverter))]
    [System.Data.ResCategoryAttribute("DataCategory_Data")]
    [System.Data.ResDescriptionAttribute("DataColumnDataTypeDescr")]
    public System.Type DataType { get { return default(System.Type); } set { } }
    [System.ComponentModel.DefaultValueAttribute((System.Data.DataSetDateTime)(3))]
    [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
    [System.Data.ResCategoryAttribute("DataCategory_Data")]
    [System.Data.ResDescriptionAttribute("DataColumnDateTimeModeDescr")]
    public System.Data.DataSetDateTime DateTimeMode { get { return default(System.Data.DataSetDateTime); } set { } }
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Data.DefaultValueTypeConverter))]
    [System.Data.ResCategoryAttribute("DataCategory_Data")]
    [System.Data.ResDescriptionAttribute("DataColumnDefaultValueDescr")]
    public object DefaultValue { get { return default(object); } set { } }
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
    [System.Data.ResCategoryAttribute("DataCategory_Data")]
    [System.Data.ResDescriptionAttribute("DataColumnExpressionDescr")]
    public string Expression { get { return default(string); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.Data.ResCategoryAttribute("DataCategory_Data")]
    [System.Data.ResDescriptionAttribute("ExtendedPropertiesDescr")]
    public System.Data.PropertyCollection ExtendedProperties { get { return default(System.Data.PropertyCollection); } }
    [System.ComponentModel.DefaultValueAttribute(-1)]
    [System.Data.ResCategoryAttribute("DataCategory_Data")]
    [System.Data.ResDescriptionAttribute("DataColumnMaxLengthDescr")]
    public int MaxLength { get { return default(int); } set { } }
    [System.Data.ResCategoryAttribute("DataCategory_Data")]
    [System.Data.ResDescriptionAttribute("DataColumnNamespaceDescr")]
    public string Namespace { get { return default(string); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.Data.ResCategoryAttribute("DataCategory_Data")]
    [System.Data.ResDescriptionAttribute("DataColumnOrdinalDescr")]
    public int Ordinal { get { return default(int); } }
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.Data.ResCategoryAttribute("DataCategory_Data")]
    [System.Data.ResDescriptionAttribute("DataColumnPrefixDescr")]
    public string Prefix { get { return default(string); } set { } }
    [System.ComponentModel.DefaultValueAttribute(false)]
    [System.Data.ResCategoryAttribute("DataCategory_Data")]
    [System.Data.ResDescriptionAttribute("DataColumnReadOnlyDescr")]
    public bool ReadOnly { get { return default(bool); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.Data.ResCategoryAttribute("DataCategory_Data")]
    [System.Data.ResDescriptionAttribute("DataColumnDataTableDescr")]
    public System.Data.DataTable Table { get { return default(System.Data.DataTable); } }
    [System.ComponentModel.DefaultValueAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.Data.ResCategoryAttribute("DataCategory_Data")]
    [System.Data.ResDescriptionAttribute("DataColumnUniqueDescr")]
    public bool Unique { get { return default(bool); } set { } }
    protected internal void CheckNotAllowNull() { }
    protected void CheckUnique() { }
    protected virtual void OnPropertyChanging(System.ComponentModel.PropertyChangedEventArgs pcevent) { }
    protected internal void RaisePropertyChanging(string name) { }
    public void SetOrdinal(int ordinal) { }
    public override string ToString() { return default(string); }
  }
  public partial class DataColumnChangeEventArgs : System.EventArgs {
    public DataColumnChangeEventArgs(System.Data.DataRow row, System.Data.DataColumn column, object value) { }
    public System.Data.DataColumn Column { get { return default(System.Data.DataColumn); } }
    public object ProposedValue { get { return default(object); } set { } }
    public System.Data.DataRow Row { get { return default(System.Data.DataRow); } }
  }
  public delegate void DataColumnChangeEventHandler(object sender, System.Data.DataColumnChangeEventArgs e);
  [System.ComponentModel.DefaultEventAttribute("CollectionChanged")]
  [System.ComponentModel.EditorAttribute("Microsoft.VSDesigner.Data.Design.ColumnsCollectionEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
  public sealed partial class DataColumnCollection : System.Data.InternalDataCollectionBase {
    internal DataColumnCollection() { }
    public System.Data.DataColumn this[int index] { get { return default(System.Data.DataColumn); } }
    public System.Data.DataColumn this[string name] { get { return default(System.Data.DataColumn); } }
    protected override System.Collections.ArrayList List { get { return default(System.Collections.ArrayList); } }
    [System.Data.ResDescriptionAttribute("collectionChangedEventDescr")]
    public event System.ComponentModel.CollectionChangeEventHandler CollectionChanged { add { } remove { } }
    public System.Data.DataColumn Add() { return default(System.Data.DataColumn); }
    public void Add(System.Data.DataColumn column) { }
    public System.Data.DataColumn Add(string columnName) { return default(System.Data.DataColumn); }
    public System.Data.DataColumn Add(string columnName, System.Type type) { return default(System.Data.DataColumn); }
    public System.Data.DataColumn Add(string columnName, System.Type type, string expression) { return default(System.Data.DataColumn); }
    public void AddRange(System.Data.DataColumn[] columns) { }
    public bool CanRemove(System.Data.DataColumn column) { return default(bool); }
    public void Clear() { }
    public bool Contains(string name) { return default(bool); }
    public void CopyTo(System.Data.DataColumn[] array, int index) { }
    public int IndexOf(System.Data.DataColumn column) { return default(int); }
    public int IndexOf(string columnName) { return default(int); }
    public void Remove(System.Data.DataColumn column) { }
    public void Remove(string name) { }
    public void RemoveAt(int index) { }
  }
  public partial class DataException : System.SystemException {
    public DataException() { }
    protected DataException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public DataException(string s) { }
    public DataException(string s, System.Exception innerException) { }
  }
  [System.ComponentModel.DefaultPropertyAttribute("RelationName")]
  [System.ComponentModel.EditorAttribute("Microsoft.VSDesigner.Data.Design.DataRelationEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
  [System.ComponentModel.TypeConverterAttribute(typeof(System.Data.RelationshipConverter))]
  public partial class DataRelation {
    public DataRelation(string relationName, System.Data.DataColumn parentColumn, System.Data.DataColumn childColumn) { }
    public DataRelation(string relationName, System.Data.DataColumn parentColumn, System.Data.DataColumn childColumn, bool createConstraints) { }
    public DataRelation(string relationName, System.Data.DataColumn[] parentColumns, System.Data.DataColumn[] childColumns) { }
    public DataRelation(string relationName, System.Data.DataColumn[] parentColumns, System.Data.DataColumn[] childColumns, bool createConstraints) { }
    [System.ComponentModel.BrowsableAttribute(false)]
    public DataRelation(string relationName, string parentTableName, string parentTableNamespace, string childTableName, string childTableNamespace, System.String[] parentColumnNames, System.String[] childColumnNames, bool nested) { }
    [System.ComponentModel.BrowsableAttribute(false)]
    public DataRelation(string relationName, string parentTableName, string childTableName, System.String[] parentColumnNames, System.String[] childColumnNames, bool nested) { }
    [System.Data.ResCategoryAttribute("DataCategory_Data")]
    [System.Data.ResDescriptionAttribute("DataRelationChildColumnsDescr")]
    public virtual System.Data.DataColumn[] ChildColumns { get { return default(System.Data.DataColumn[]); } }
    public virtual System.Data.ForeignKeyConstraint ChildKeyConstraint { get { return default(System.Data.ForeignKeyConstraint); } }
    public virtual System.Data.DataTable ChildTable { get { return default(System.Data.DataTable); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    public virtual System.Data.DataSet DataSet { get { return default(System.Data.DataSet); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.Data.ResCategoryAttribute("DataCategory_Data")]
    [System.Data.ResDescriptionAttribute("ExtendedPropertiesDescr")]
    public System.Data.PropertyCollection ExtendedProperties { get { return default(System.Data.PropertyCollection); } }
    [System.ComponentModel.DefaultValueAttribute(false)]
    [System.Data.ResCategoryAttribute("DataCategory_Data")]
    [System.Data.ResDescriptionAttribute("DataRelationNested")]
    public virtual bool Nested { get { return default(bool); } set { } }
    [System.Data.ResCategoryAttribute("DataCategory_Data")]
    [System.Data.ResDescriptionAttribute("DataRelationParentColumnsDescr")]
    public virtual System.Data.DataColumn[] ParentColumns { get { return default(System.Data.DataColumn[]); } }
    public virtual System.Data.UniqueConstraint ParentKeyConstraint { get { return default(System.Data.UniqueConstraint); } }
    public virtual System.Data.DataTable ParentTable { get { return default(System.Data.DataTable); } }
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.Data.ResCategoryAttribute("DataCategory_Data")]
    [System.Data.ResDescriptionAttribute("DataRelationRelationNameDescr")]
    public virtual string RelationName { get { return default(string); } set { } }
    protected void CheckStateForProperty() { }
    protected internal void OnPropertyChanging(System.ComponentModel.PropertyChangedEventArgs pcevent) { }
    protected internal void RaisePropertyChanging(string name) { }
    public override string ToString() { return default(string); }
  }
  [System.ComponentModel.DefaultEventAttribute("CollectionChanged")]
  [System.ComponentModel.DefaultPropertyAttribute("Table")]
  [System.ComponentModel.EditorAttribute("Microsoft.VSDesigner.Data.Design.DataRelationCollectionEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
  public abstract partial class DataRelationCollection : System.Data.InternalDataCollectionBase {
    protected DataRelationCollection() { }
    public abstract System.Data.DataRelation this[int index] { get; }
    public abstract System.Data.DataRelation this[string name] { get; }
    [System.Data.ResDescriptionAttribute("collectionChangedEventDescr")]
    public event System.ComponentModel.CollectionChangeEventHandler CollectionChanged { add { } remove { } }
    public virtual System.Data.DataRelation Add(System.Data.DataColumn parentColumn, System.Data.DataColumn childColumn) { return default(System.Data.DataRelation); }
    public virtual System.Data.DataRelation Add(System.Data.DataColumn[] parentColumns, System.Data.DataColumn[] childColumns) { return default(System.Data.DataRelation); }
    public void Add(System.Data.DataRelation relation) { }
    public virtual System.Data.DataRelation Add(string name, System.Data.DataColumn parentColumn, System.Data.DataColumn childColumn) { return default(System.Data.DataRelation); }
    public virtual System.Data.DataRelation Add(string name, System.Data.DataColumn parentColumn, System.Data.DataColumn childColumn, bool createConstraints) { return default(System.Data.DataRelation); }
    public virtual System.Data.DataRelation Add(string name, System.Data.DataColumn[] parentColumns, System.Data.DataColumn[] childColumns) { return default(System.Data.DataRelation); }
    public virtual System.Data.DataRelation Add(string name, System.Data.DataColumn[] parentColumns, System.Data.DataColumn[] childColumns, bool createConstraints) { return default(System.Data.DataRelation); }
    protected virtual void AddCore(System.Data.DataRelation relation) { }
    public virtual void AddRange(System.Data.DataRelation[] relations) { }
    public virtual bool CanRemove(System.Data.DataRelation relation) { return default(bool); }
    public virtual void Clear() { }
    public virtual bool Contains(string name) { return default(bool); }
    public void CopyTo(System.Data.DataRelation[] array, int index) { }
    protected abstract System.Data.DataSet GetDataSet();
    public virtual int IndexOf(System.Data.DataRelation relation) { return default(int); }
    public virtual int IndexOf(string relationName) { return default(int); }
    protected virtual void OnCollectionChanged(System.ComponentModel.CollectionChangeEventArgs ccevent) { }
    protected virtual void OnCollectionChanging(System.ComponentModel.CollectionChangeEventArgs ccevent) { }
    public void Remove(System.Data.DataRelation relation) { }
    public void Remove(string name) { }
    public void RemoveAt(int index) { }
    protected virtual void RemoveCore(System.Data.DataRelation relation) { }
  }
  public partial class DataRow {
    protected internal DataRow(System.Data.DataRowBuilder builder) { }
    public bool HasErrors { get { return default(bool); } }
    public object this[System.Data.DataColumn column] { get { return default(object); } set { } }
    public object this[System.Data.DataColumn column, System.Data.DataRowVersion version] { get { return default(object); } }
    public object this[int columnIndex] { get { return default(object); } set { } }
    public object this[int columnIndex, System.Data.DataRowVersion version] { get { return default(object); } }
    public object this[string columnName] { get { return default(object); } set { } }
    public object this[string columnName, System.Data.DataRowVersion version] { get { return default(object); } }
    public System.Object[] ItemArray { get { return default(System.Object[]); } set { } }
    public string RowError { get { return default(string); } set { } }
    public System.Data.DataRowState RowState { get { return default(System.Data.DataRowState); } }
    public System.Data.DataTable Table { get { return default(System.Data.DataTable); } }
    public void AcceptChanges() { }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
    public void BeginEdit() { }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
    public void CancelEdit() { }
    public void ClearErrors() { }
    public void Delete() { }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
    public void EndEdit() { }
    public System.Data.DataRow[] GetChildRows(System.Data.DataRelation relation) { return default(System.Data.DataRow[]); }
    public System.Data.DataRow[] GetChildRows(System.Data.DataRelation relation, System.Data.DataRowVersion version) { return default(System.Data.DataRow[]); }
    public System.Data.DataRow[] GetChildRows(string relationName) { return default(System.Data.DataRow[]); }
    public System.Data.DataRow[] GetChildRows(string relationName, System.Data.DataRowVersion version) { return default(System.Data.DataRow[]); }
    public string GetColumnError(System.Data.DataColumn column) { return default(string); }
    public string GetColumnError(int columnIndex) { return default(string); }
    public string GetColumnError(string columnName) { return default(string); }
    public System.Data.DataColumn[] GetColumnsInError() { return default(System.Data.DataColumn[]); }
    public System.Data.DataRow GetParentRow(System.Data.DataRelation relation) { return default(System.Data.DataRow); }
    public System.Data.DataRow GetParentRow(System.Data.DataRelation relation, System.Data.DataRowVersion version) { return default(System.Data.DataRow); }
    public System.Data.DataRow GetParentRow(string relationName) { return default(System.Data.DataRow); }
    public System.Data.DataRow GetParentRow(string relationName, System.Data.DataRowVersion version) { return default(System.Data.DataRow); }
    public System.Data.DataRow[] GetParentRows(System.Data.DataRelation relation) { return default(System.Data.DataRow[]); }
    public System.Data.DataRow[] GetParentRows(System.Data.DataRelation relation, System.Data.DataRowVersion version) { return default(System.Data.DataRow[]); }
    public System.Data.DataRow[] GetParentRows(string relationName) { return default(System.Data.DataRow[]); }
    public System.Data.DataRow[] GetParentRows(string relationName, System.Data.DataRowVersion version) { return default(System.Data.DataRow[]); }
    public bool HasVersion(System.Data.DataRowVersion version) { return default(bool); }
    public bool IsNull(System.Data.DataColumn column) { return default(bool); }
    public bool IsNull(System.Data.DataColumn column, System.Data.DataRowVersion version) { return default(bool); }
    public bool IsNull(int columnIndex) { return default(bool); }
    public bool IsNull(string columnName) { return default(bool); }
    public void RejectChanges() { }
    public void SetAdded() { }
    public void SetColumnError(System.Data.DataColumn column, string error) { }
    public void SetColumnError(int columnIndex, string error) { }
    public void SetColumnError(string columnName, string error) { }
    public void SetModified() { }
    protected void SetNull(System.Data.DataColumn column) { }
    public void SetParentRow(System.Data.DataRow parentRow) { }
    public void SetParentRow(System.Data.DataRow parentRow, System.Data.DataRelation relation) { }
  }
  [System.FlagsAttribute]
  public enum DataRowAction {
    Add = 16,
    Change = 2,
    ChangeCurrentAndOriginal = 64,
    ChangeOriginal = 32,
    Commit = 8,
    Delete = 1,
    Nothing = 0,
    Rollback = 4,
  }
  public sealed partial class DataRowBuilder {
    internal DataRowBuilder() { }
  }
  public partial class DataRowChangeEventArgs : System.EventArgs {
    public DataRowChangeEventArgs(System.Data.DataRow row, System.Data.DataRowAction action) { }
    public System.Data.DataRowAction Action { get { return default(System.Data.DataRowAction); } }
    public System.Data.DataRow Row { get { return default(System.Data.DataRow); } }
  }
  public delegate void DataRowChangeEventHandler(object sender, System.Data.DataRowChangeEventArgs e);
  public sealed partial class DataRowCollection : System.Data.InternalDataCollectionBase {
    internal DataRowCollection() { }
    public override int Count { get { return default(int); } }
    public System.Data.DataRow this[int index] { get { return default(System.Data.DataRow); } }
    public void Add(System.Data.DataRow row) { }
    public System.Data.DataRow Add(params System.Object[] values) { return default(System.Data.DataRow); }
    public void Clear() { }
    public bool Contains(object key) { return default(bool); }
    public bool Contains(System.Object[] keys) { return default(bool); }
    public override void CopyTo(System.Array ar, int index) { }
    public void CopyTo(System.Data.DataRow[] array, int index) { }
    public System.Data.DataRow Find(object key) { return default(System.Data.DataRow); }
    public System.Data.DataRow Find(System.Object[] keys) { return default(System.Data.DataRow); }
    public override System.Collections.IEnumerator GetEnumerator() { return default(System.Collections.IEnumerator); }
    public int IndexOf(System.Data.DataRow row) { return default(int); }
    public void InsertAt(System.Data.DataRow row, int pos) { }
    public void Remove(System.Data.DataRow row) { }
    public void RemoveAt(int index) { }
  }
  [System.FlagsAttribute]
  public enum DataRowState {
    Added = 4,
    Deleted = 8,
    Detached = 1,
    Modified = 16,
    Unchanged = 2,
  }
  public enum DataRowVersion {
    Current = 512,
    Default = 1536,
    Original = 256,
    Proposed = 1024,
  }
  public partial class DataRowView : System.ComponentModel.ICustomTypeDescriptor, System.ComponentModel.IDataErrorInfo, System.ComponentModel.IEditableObject, System.ComponentModel.INotifyPropertyChanged {
    internal DataRowView() { }
    public System.Data.DataView DataView { get { return default(System.Data.DataView); } }
    public bool IsEdit { get { return default(bool); } }
    public bool IsNew { get { return default(bool); } }
    public object this[int ndx] { get { return default(object); } set { } }
    public object this[string property] { get { return default(object); } set { } }
    public System.Data.DataRow Row { get { return default(System.Data.DataRow); } }
    public System.Data.DataRowVersion RowVersion { get { return default(System.Data.DataRowVersion); } }
    string System.ComponentModel.IDataErrorInfo.Error { get { return default(string); } }
    string System.ComponentModel.IDataErrorInfo.this[string colName] { get { return default(string); } }
    public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged { add { } remove { } }
    public void BeginEdit() { }
    public void CancelEdit() { }
    public System.Data.DataView CreateChildView(System.Data.DataRelation relation) { return default(System.Data.DataView); }
    public System.Data.DataView CreateChildView(System.Data.DataRelation relation, bool followParent) { return default(System.Data.DataView); }
    public System.Data.DataView CreateChildView(string relationName) { return default(System.Data.DataView); }
    public System.Data.DataView CreateChildView(string relationName, bool followParent) { return default(System.Data.DataView); }
    public void Delete() { }
    public void EndEdit() { }
    public override bool Equals(object other) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    System.ComponentModel.AttributeCollection System.ComponentModel.ICustomTypeDescriptor.GetAttributes() { return default(System.ComponentModel.AttributeCollection); }
    string System.ComponentModel.ICustomTypeDescriptor.GetClassName() { return default(string); }
    string System.ComponentModel.ICustomTypeDescriptor.GetComponentName() { return default(string); }
    System.ComponentModel.TypeConverter System.ComponentModel.ICustomTypeDescriptor.GetConverter() { return default(System.ComponentModel.TypeConverter); }
    System.ComponentModel.EventDescriptor System.ComponentModel.ICustomTypeDescriptor.GetDefaultEvent() { return default(System.ComponentModel.EventDescriptor); }
    System.ComponentModel.PropertyDescriptor System.ComponentModel.ICustomTypeDescriptor.GetDefaultProperty() { return default(System.ComponentModel.PropertyDescriptor); }
    object System.ComponentModel.ICustomTypeDescriptor.GetEditor(System.Type editorBaseType) { return default(object); }
    System.ComponentModel.EventDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetEvents() { return default(System.ComponentModel.EventDescriptorCollection); }
    System.ComponentModel.EventDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetEvents(System.Attribute[] attributes) { return default(System.ComponentModel.EventDescriptorCollection); }
    System.ComponentModel.PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties() { return default(System.ComponentModel.PropertyDescriptorCollection); }
    System.ComponentModel.PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties(System.Attribute[] attributes) { return default(System.ComponentModel.PropertyDescriptorCollection); }
    object System.ComponentModel.ICustomTypeDescriptor.GetPropertyOwner(System.ComponentModel.PropertyDescriptor pd) { return default(object); }
  }
  [System.ComponentModel.DefaultPropertyAttribute("DataSetName")]
  [System.ComponentModel.DesignerAttribute("Microsoft.VSDesigner.Data.VS.DataSetDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
  [System.ComponentModel.ToolboxItemAttribute("Microsoft.VSDesigner.Data.VS.DataSetToolboxItem, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
  [System.Data.ResDescriptionAttribute("DataSetDescr")]
  [System.Xml.Serialization.XmlRootAttribute("DataSet")]
  [System.Xml.Serialization.XmlSchemaProviderAttribute("GetDataSetSchema")]
  public partial class DataSet : System.ComponentModel.MarshalByValueComponent, System.ComponentModel.IListSource, System.ComponentModel.ISupportInitialize, System.ComponentModel.ISupportInitializeNotification, System.Runtime.Serialization.ISerializable, System.Xml.Serialization.IXmlSerializable {
    public DataSet() { }
    protected DataSet(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    protected DataSet(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context, bool ConstructSchema) { }
    public DataSet(string dataSetName) { }
    [System.ComponentModel.DefaultValueAttribute(false)]
    [System.Data.ResCategoryAttribute("DataCategory_Data")]
    [System.Data.ResDescriptionAttribute("DataSetCaseSensitiveDescr")]
    public bool CaseSensitive { get { return default(bool); } set { } }
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.Data.ResCategoryAttribute("DataCategory_Data")]
    [System.Data.ResDescriptionAttribute("DataSetDataSetNameDescr")]
    public string DataSetName { get { return default(string); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.Data.ResDescriptionAttribute("DataSetDefaultViewDescr")]
    public System.Data.DataViewManager DefaultViewManager { get { return default(System.Data.DataViewManager); } }
    [System.ComponentModel.DefaultValueAttribute(true)]
    [System.Data.ResDescriptionAttribute("DataSetEnforceConstraintsDescr")]
    public bool EnforceConstraints { get { return default(bool); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.Data.ResCategoryAttribute("DataCategory_Data")]
    [System.Data.ResDescriptionAttribute("ExtendedPropertiesDescr")]
    public System.Data.PropertyCollection ExtendedProperties { get { return default(System.Data.PropertyCollection); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.Data.ResDescriptionAttribute("DataSetHasErrorsDescr")]
    public bool HasErrors { get { return default(bool); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    public bool IsInitialized { get { return default(bool); } }
    [System.Data.ResCategoryAttribute("DataCategory_Data")]
    [System.Data.ResDescriptionAttribute("DataSetLocaleDescr")]
    public System.Globalization.CultureInfo Locale { get { return default(System.Globalization.CultureInfo); } set { } }
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.Data.ResCategoryAttribute("DataCategory_Data")]
    [System.Data.ResDescriptionAttribute("DataSetNamespaceDescr")]
    public string Namespace { get { return default(string); } set { } }
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.Data.ResCategoryAttribute("DataCategory_Data")]
    [System.Data.ResDescriptionAttribute("DataSetPrefixDescr")]
    public string Prefix { get { return default(string); } set { } }
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(2))]
    [System.Data.ResCategoryAttribute("DataCategory_Data")]
    [System.Data.ResDescriptionAttribute("DataSetRelationsDescr")]
    public System.Data.DataRelationCollection Relations { get { return default(System.Data.DataRelationCollection); } }
    [System.ComponentModel.DefaultValueAttribute((System.Data.SerializationFormat)(0))]
    public System.Data.SerializationFormat RemotingFormat { get { return default(System.Data.SerializationFormat); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    public virtual System.Data.SchemaSerializationMode SchemaSerializationMode { get { return default(System.Data.SchemaSerializationMode); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    public override System.ComponentModel.ISite Site { get { return default(System.ComponentModel.ISite); } set { } }
    bool System.ComponentModel.IListSource.ContainsListCollection { get { return default(bool); } }
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(2))]
    [System.Data.ResCategoryAttribute("DataCategory_Data")]
    [System.Data.ResDescriptionAttribute("DataSetTablesDescr")]
    public System.Data.DataTableCollection Tables { get { return default(System.Data.DataTableCollection); } }
    [System.Data.ResCategoryAttribute("DataCategory_Action")]
    [System.Data.ResDescriptionAttribute("DataSetInitializedDescr")]
    public event System.EventHandler Initialized { add { } remove { } }
    [System.Data.ResCategoryAttribute("DataCategory_Action")]
    [System.Data.ResDescriptionAttribute("DataSetMergeFailedDescr")]
    public event System.Data.MergeFailedEventHandler MergeFailed { add { } remove { } }
    public void AcceptChanges() { }
    public void BeginInit() { }
    public void Clear() { }
    public virtual System.Data.DataSet Clone() { return default(System.Data.DataSet); }
    public System.Data.DataSet Copy() { return default(System.Data.DataSet); }
    public System.Data.DataTableReader CreateDataReader() { return default(System.Data.DataTableReader); }
    public System.Data.DataTableReader CreateDataReader(params System.Data.DataTable[] dataTables) { return default(System.Data.DataTableReader); }
    protected System.Data.SchemaSerializationMode DetermineSchemaSerializationMode(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { return default(System.Data.SchemaSerializationMode); }
    protected System.Data.SchemaSerializationMode DetermineSchemaSerializationMode(System.Xml.XmlReader reader) { return default(System.Data.SchemaSerializationMode); }
    public void EndInit() { }
    public System.Data.DataSet GetChanges() { return default(System.Data.DataSet); }
    public System.Data.DataSet GetChanges(System.Data.DataRowState rowStates) { return default(System.Data.DataSet); }
    public static System.Xml.Schema.XmlSchemaComplexType GetDataSetSchema(System.Xml.Schema.XmlSchemaSet schemaSet) { return default(System.Xml.Schema.XmlSchemaComplexType); }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(128))]
    public virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    protected virtual System.Xml.Schema.XmlSchema GetSchemaSerializable() { return default(System.Xml.Schema.XmlSchema); }
    protected void GetSerializationData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public string GetXml() { return default(string); }
    public string GetXmlSchema() { return default(string); }
    public bool HasChanges() { return default(bool); }
    public bool HasChanges(System.Data.DataRowState rowStates) { return default(bool); }
    public void InferXmlSchema(System.IO.Stream stream, System.String[] nsArray) { }
    public void InferXmlSchema(System.IO.TextReader reader, System.String[] nsArray) { }
    public void InferXmlSchema(string fileName, System.String[] nsArray) { }
    public void InferXmlSchema(System.Xml.XmlReader reader, System.String[] nsArray) { }
    protected virtual void InitializeDerivedDataSet() { }
    protected bool IsBinarySerialized(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { return default(bool); }
    public void Load(System.Data.IDataReader reader, System.Data.LoadOption loadOption, params System.Data.DataTable[] tables) { }
    public virtual void Load(System.Data.IDataReader reader, System.Data.LoadOption loadOption, System.Data.FillErrorEventHandler errorHandler, params System.Data.DataTable[] tables) { }
    public void Load(System.Data.IDataReader reader, System.Data.LoadOption loadOption, params System.String[] tables) { }
    public void Merge(System.Data.DataRow[] rows) { }
    public void Merge(System.Data.DataRow[] rows, bool preserveChanges, System.Data.MissingSchemaAction missingSchemaAction) { }
    public void Merge(System.Data.DataSet dataSet) { }
    public void Merge(System.Data.DataSet dataSet, bool preserveChanges) { }
    public void Merge(System.Data.DataSet dataSet, bool preserveChanges, System.Data.MissingSchemaAction missingSchemaAction) { }
    public void Merge(System.Data.DataTable table) { }
    public void Merge(System.Data.DataTable table, bool preserveChanges, System.Data.MissingSchemaAction missingSchemaAction) { }
    protected virtual void OnPropertyChanging(System.ComponentModel.PropertyChangedEventArgs pcevent) { }
    protected virtual void OnRemoveRelation(System.Data.DataRelation relation) { }
    protected internal virtual void OnRemoveTable(System.Data.DataTable table) { }
    protected internal void RaisePropertyChanging(string name) { }
    public System.Data.XmlReadMode ReadXml(System.IO.Stream stream) { return default(System.Data.XmlReadMode); }
    public System.Data.XmlReadMode ReadXml(System.IO.Stream stream, System.Data.XmlReadMode mode) { return default(System.Data.XmlReadMode); }
    public System.Data.XmlReadMode ReadXml(System.IO.TextReader reader) { return default(System.Data.XmlReadMode); }
    public System.Data.XmlReadMode ReadXml(System.IO.TextReader reader, System.Data.XmlReadMode mode) { return default(System.Data.XmlReadMode); }
    public System.Data.XmlReadMode ReadXml(string fileName) { return default(System.Data.XmlReadMode); }
    public System.Data.XmlReadMode ReadXml(string fileName, System.Data.XmlReadMode mode) { return default(System.Data.XmlReadMode); }
    public System.Data.XmlReadMode ReadXml(System.Xml.XmlReader reader) { return default(System.Data.XmlReadMode); }
    public System.Data.XmlReadMode ReadXml(System.Xml.XmlReader reader, System.Data.XmlReadMode mode) { return default(System.Data.XmlReadMode); }
    public void ReadXmlSchema(System.IO.Stream stream) { }
    public void ReadXmlSchema(System.IO.TextReader reader) { }
    public void ReadXmlSchema(string fileName) { }
    public void ReadXmlSchema(System.Xml.XmlReader reader) { }
    protected virtual void ReadXmlSerializable(System.Xml.XmlReader reader) { }
    public virtual void RejectChanges() { }
    public virtual void Reset() { }
    protected virtual bool ShouldSerializeRelations() { return default(bool); }
    protected virtual bool ShouldSerializeTables() { return default(bool); }
    System.Collections.IList System.ComponentModel.IListSource.GetList() { return default(System.Collections.IList); }
    System.Xml.Schema.XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { return default(System.Xml.Schema.XmlSchema); }
    void System.Xml.Serialization.IXmlSerializable.ReadXml(System.Xml.XmlReader reader) { }
    void System.Xml.Serialization.IXmlSerializable.WriteXml(System.Xml.XmlWriter writer) { }
    public void WriteXml(System.IO.Stream stream) { }
    public void WriteXml(System.IO.Stream stream, System.Data.XmlWriteMode mode) { }
    public void WriteXml(System.IO.TextWriter writer) { }
    public void WriteXml(System.IO.TextWriter writer, System.Data.XmlWriteMode mode) { }
    public void WriteXml(string fileName) { }
    public void WriteXml(string fileName, System.Data.XmlWriteMode mode) { }
    public void WriteXml(System.Xml.XmlWriter writer) { }
    public void WriteXml(System.Xml.XmlWriter writer, System.Data.XmlWriteMode mode) { }
    public void WriteXmlSchema(System.IO.Stream stream) { }
    public void WriteXmlSchema(System.IO.Stream stream, System.Converter<System.Type, System.String> multipleTargetConverter) { }
    public void WriteXmlSchema(System.IO.TextWriter writer) { }
    public void WriteXmlSchema(System.IO.TextWriter writer, System.Converter<System.Type, System.String> multipleTargetConverter) { }
    public void WriteXmlSchema(string fileName) { }
    public void WriteXmlSchema(string fileName, System.Converter<System.Type, System.String> multipleTargetConverter) { }
    public void WriteXmlSchema(System.Xml.XmlWriter writer) { }
    public void WriteXmlSchema(System.Xml.XmlWriter writer, System.Converter<System.Type, System.String> multipleTargetConverter) { }
  }
  public enum DataSetDateTime {
    Local = 1,
    Unspecified = 2,
    UnspecifiedLocal = 3,
    Utc = 4,
  }
  public partial class DataSetSchemaImporterExtension : System.Xml.Serialization.Advanced.SchemaImporterExtension {
    public DataSetSchemaImporterExtension() { }
    public override string ImportSchemaType(string name, string schemaNamespace, System.Xml.Schema.XmlSchemaObject context, System.Xml.Serialization.XmlSchemas schemas, System.Xml.Serialization.XmlSchemaImporter importer, System.CodeDom.CodeCompileUnit compileUnit, System.CodeDom.CodeNamespace mainNamespace, System.Xml.Serialization.CodeGenerationOptions options, System.CodeDom.Compiler.CodeDomProvider codeProvider) { return default(string); }
    public override string ImportSchemaType(System.Xml.Schema.XmlSchemaType type, System.Xml.Schema.XmlSchemaObject context, System.Xml.Serialization.XmlSchemas schemas, System.Xml.Serialization.XmlSchemaImporter importer, System.CodeDom.CodeCompileUnit compileUnit, System.CodeDom.CodeNamespace mainNamespace, System.Xml.Serialization.CodeGenerationOptions options, System.CodeDom.Compiler.CodeDomProvider codeProvider) { return default(string); }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(32767))]
  [System.ObsoleteAttribute("DataSysDescriptionAttribute has been deprecated.  http://go.microsoft.com/fwlink/?linkid=14202", false)]
  public partial class DataSysDescriptionAttribute : System.ComponentModel.DescriptionAttribute {
    [System.ObsoleteAttribute("DataSysDescriptionAttribute has been deprecated.  http://go.microsoft.com/fwlink/?linkid=14202", false)]
    public DataSysDescriptionAttribute(string description) { }
    public override string Description { get { return default(string); } }
  }
  [System.ComponentModel.DefaultEventAttribute("RowChanging")]
  [System.ComponentModel.DefaultPropertyAttribute("TableName")]
  [System.ComponentModel.DesignTimeVisibleAttribute(false)]
  [System.ComponentModel.EditorAttribute("Microsoft.VSDesigner.Data.Design.DataTableEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
  [System.ComponentModel.ToolboxItemAttribute(false)]
  [System.Xml.Serialization.XmlSchemaProviderAttribute("GetDataTableSchema")]
  public partial class DataTable : System.ComponentModel.MarshalByValueComponent, System.ComponentModel.IListSource, System.ComponentModel.ISupportInitialize, System.ComponentModel.ISupportInitializeNotification, System.Runtime.Serialization.ISerializable, System.Xml.Serialization.IXmlSerializable {
    protected internal bool fInitInProgress;
    public DataTable() { }
    protected DataTable(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public DataTable(string tableName) { }
    public DataTable(string tableName, string tableNamespace) { }
    [System.Data.ResDescriptionAttribute("DataTableCaseSensitiveDescr")]
    public bool CaseSensitive { get { return default(bool); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.Data.ResDescriptionAttribute("DataTableChildRelationsDescr")]
    public System.Data.DataRelationCollection ChildRelations { get { return default(System.Data.DataRelationCollection); } }
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(2))]
    [System.Data.ResCategoryAttribute("DataCategory_Data")]
    [System.Data.ResDescriptionAttribute("DataTableColumnsDescr")]
    public System.Data.DataColumnCollection Columns { get { return default(System.Data.DataColumnCollection); } }
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(2))]
    [System.Data.ResCategoryAttribute("DataCategory_Data")]
    [System.Data.ResDescriptionAttribute("DataTableConstraintsDescr")]
    public System.Data.ConstraintCollection Constraints { get { return default(System.Data.ConstraintCollection); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.Data.ResDescriptionAttribute("DataTableDataSetDescr")]
    public System.Data.DataSet DataSet { get { return default(System.Data.DataSet); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.Data.ResDescriptionAttribute("DataTableDefaultViewDescr")]
    public System.Data.DataView DefaultView { get { return default(System.Data.DataView); } }
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.Data.ResCategoryAttribute("DataCategory_Data")]
    [System.Data.ResDescriptionAttribute("DataTableDisplayExpressionDescr")]
    public string DisplayExpression { get { return default(string); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.Data.ResCategoryAttribute("DataCategory_Data")]
    [System.Data.ResDescriptionAttribute("ExtendedPropertiesDescr")]
    public System.Data.PropertyCollection ExtendedProperties { get { return default(System.Data.PropertyCollection); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.Data.ResDescriptionAttribute("DataTableHasErrorsDescr")]
    public bool HasErrors { get { return default(bool); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    public bool IsInitialized { get { return default(bool); } }
    [System.Data.ResDescriptionAttribute("DataTableLocaleDescr")]
    public System.Globalization.CultureInfo Locale { get { return default(System.Globalization.CultureInfo); } set { } }
    [System.ComponentModel.DefaultValueAttribute(50)]
    [System.Data.ResCategoryAttribute("DataCategory_Data")]
    [System.Data.ResDescriptionAttribute("DataTableMinimumCapacityDescr")]
    public int MinimumCapacity { get { return default(int); } set { } }
    [System.Data.ResCategoryAttribute("DataCategory_Data")]
    [System.Data.ResDescriptionAttribute("DataTableNamespaceDescr")]
    public string Namespace { get { return default(string); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.Data.ResDescriptionAttribute("DataTableParentRelationsDescr")]
    public System.Data.DataRelationCollection ParentRelations { get { return default(System.Data.DataRelationCollection); } }
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.Data.ResCategoryAttribute("DataCategory_Data")]
    [System.Data.ResDescriptionAttribute("DataTablePrefixDescr")]
    public string Prefix { get { return default(string); } set { } }
    [System.ComponentModel.EditorAttribute("Microsoft.VSDesigner.Data.Design.PrimaryKeyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Data.PrimaryKeyTypeConverter))]
    [System.Data.ResCategoryAttribute("DataCategory_Data")]
    [System.Data.ResDescriptionAttribute("DataTablePrimaryKeyDescr")]
    public System.Data.DataColumn[] PrimaryKey { get { return default(System.Data.DataColumn[]); } set { } }
    [System.ComponentModel.DefaultValueAttribute((System.Data.SerializationFormat)(0))]
    public System.Data.SerializationFormat RemotingFormat { get { return default(System.Data.SerializationFormat); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.Data.ResDescriptionAttribute("DataTableRowsDescr")]
    public System.Data.DataRowCollection Rows { get { return default(System.Data.DataRowCollection); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    public override System.ComponentModel.ISite Site { get { return default(System.ComponentModel.ISite); } set { } }
    bool System.ComponentModel.IListSource.ContainsListCollection { get { return default(bool); } }
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
    [System.Data.ResCategoryAttribute("DataCategory_Data")]
    [System.Data.ResDescriptionAttribute("DataTableTableNameDescr")]
    public string TableName { get { return default(string); } set { } }
    [System.Data.ResCategoryAttribute("DataCategory_Data")]
    [System.Data.ResDescriptionAttribute("DataTableColumnChangedDescr")]
    public event System.Data.DataColumnChangeEventHandler ColumnChanged { add { } remove { } }
    [System.Data.ResCategoryAttribute("DataCategory_Data")]
    [System.Data.ResDescriptionAttribute("DataTableColumnChangingDescr")]
    public event System.Data.DataColumnChangeEventHandler ColumnChanging { add { } remove { } }
    [System.Data.ResCategoryAttribute("DataCategory_Action")]
    [System.Data.ResDescriptionAttribute("DataSetInitializedDescr")]
    public event System.EventHandler Initialized { add { } remove { } }
    [System.Data.ResCategoryAttribute("DataCategory_Data")]
    [System.Data.ResDescriptionAttribute("DataTableRowChangedDescr")]
    public event System.Data.DataRowChangeEventHandler RowChanged { add { } remove { } }
    [System.Data.ResCategoryAttribute("DataCategory_Data")]
    [System.Data.ResDescriptionAttribute("DataTableRowChangingDescr")]
    public event System.Data.DataRowChangeEventHandler RowChanging { add { } remove { } }
    [System.Data.ResCategoryAttribute("DataCategory_Data")]
    [System.Data.ResDescriptionAttribute("DataTableRowDeletedDescr")]
    public event System.Data.DataRowChangeEventHandler RowDeleted { add { } remove { } }
    [System.Data.ResCategoryAttribute("DataCategory_Data")]
    [System.Data.ResDescriptionAttribute("DataTableRowDeletingDescr")]
    public event System.Data.DataRowChangeEventHandler RowDeleting { add { } remove { } }
    [System.Data.ResCategoryAttribute("DataCategory_Data")]
    [System.Data.ResDescriptionAttribute("DataTableRowsClearedDescr")]
    public event System.Data.DataTableClearEventHandler TableCleared { add { } remove { } }
    [System.Data.ResCategoryAttribute("DataCategory_Data")]
    [System.Data.ResDescriptionAttribute("DataTableRowsClearingDescr")]
    public event System.Data.DataTableClearEventHandler TableClearing { add { } remove { } }
    [System.Data.ResCategoryAttribute("DataCategory_Data")]
    [System.Data.ResDescriptionAttribute("DataTableRowsNewRowDescr")]
    public event System.Data.DataTableNewRowEventHandler TableNewRow { add { } remove { } }
    public void AcceptChanges() { }
    public virtual void BeginInit() { }
    public void BeginLoadData() { }
    public void Clear() { }
    public virtual System.Data.DataTable Clone() { return default(System.Data.DataTable); }
    public object Compute(string expression, string filter) { return default(object); }
    public System.Data.DataTable Copy() { return default(System.Data.DataTable); }
    public System.Data.DataTableReader CreateDataReader() { return default(System.Data.DataTableReader); }
    protected virtual System.Data.DataTable CreateInstance() { return default(System.Data.DataTable); }
    public virtual void EndInit() { }
    public void EndLoadData() { }
    public System.Data.DataTable GetChanges() { return default(System.Data.DataTable); }
    public System.Data.DataTable GetChanges(System.Data.DataRowState rowStates) { return default(System.Data.DataTable); }
    public static System.Xml.Schema.XmlSchemaComplexType GetDataTableSchema(System.Xml.Schema.XmlSchemaSet schemaSet) { return default(System.Xml.Schema.XmlSchemaComplexType); }
    public System.Data.DataRow[] GetErrors() { return default(System.Data.DataRow[]); }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(128))]
    public virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    protected virtual System.Type GetRowType() { return default(System.Type); }
    protected virtual System.Xml.Schema.XmlSchema GetSchema() { return default(System.Xml.Schema.XmlSchema); }
    public void ImportRow(System.Data.DataRow row) { }
    public void Load(System.Data.IDataReader reader) { }
    public void Load(System.Data.IDataReader reader, System.Data.LoadOption loadOption) { }
    public virtual void Load(System.Data.IDataReader reader, System.Data.LoadOption loadOption, System.Data.FillErrorEventHandler errorHandler) { }
    public System.Data.DataRow LoadDataRow(System.Object[] values, bool fAcceptChanges) { return default(System.Data.DataRow); }
    public System.Data.DataRow LoadDataRow(System.Object[] values, System.Data.LoadOption loadOption) { return default(System.Data.DataRow); }
    public void Merge(System.Data.DataTable table) { }
    public void Merge(System.Data.DataTable table, bool preserveChanges) { }
    public void Merge(System.Data.DataTable table, bool preserveChanges, System.Data.MissingSchemaAction missingSchemaAction) { }
    public System.Data.DataRow NewRow() { return default(System.Data.DataRow); }
    protected internal System.Data.DataRow[] NewRowArray(int size) { return default(System.Data.DataRow[]); }
    protected virtual System.Data.DataRow NewRowFromBuilder(System.Data.DataRowBuilder builder) { return default(System.Data.DataRow); }
    protected internal virtual void OnColumnChanged(System.Data.DataColumnChangeEventArgs e) { }
    protected internal virtual void OnColumnChanging(System.Data.DataColumnChangeEventArgs e) { }
    protected virtual void OnPropertyChanging(System.ComponentModel.PropertyChangedEventArgs pcevent) { }
    protected virtual void OnRemoveColumn(System.Data.DataColumn column) { }
    protected virtual void OnRowChanged(System.Data.DataRowChangeEventArgs e) { }
    protected virtual void OnRowChanging(System.Data.DataRowChangeEventArgs e) { }
    protected virtual void OnRowDeleted(System.Data.DataRowChangeEventArgs e) { }
    protected virtual void OnRowDeleting(System.Data.DataRowChangeEventArgs e) { }
    protected virtual void OnTableCleared(System.Data.DataTableClearEventArgs e) { }
    protected virtual void OnTableClearing(System.Data.DataTableClearEventArgs e) { }
    protected virtual void OnTableNewRow(System.Data.DataTableNewRowEventArgs e) { }
    public System.Data.XmlReadMode ReadXml(System.IO.Stream stream) { return default(System.Data.XmlReadMode); }
    public System.Data.XmlReadMode ReadXml(System.IO.TextReader reader) { return default(System.Data.XmlReadMode); }
    public System.Data.XmlReadMode ReadXml(string fileName) { return default(System.Data.XmlReadMode); }
    public System.Data.XmlReadMode ReadXml(System.Xml.XmlReader reader) { return default(System.Data.XmlReadMode); }
    public void ReadXmlSchema(System.IO.Stream stream) { }
    public void ReadXmlSchema(System.IO.TextReader reader) { }
    public void ReadXmlSchema(string fileName) { }
    public void ReadXmlSchema(System.Xml.XmlReader reader) { }
    protected virtual void ReadXmlSerializable(System.Xml.XmlReader reader) { }
    public void RejectChanges() { }
    public virtual void Reset() { }
    public System.Data.DataRow[] Select() { return default(System.Data.DataRow[]); }
    public System.Data.DataRow[] Select(string filterExpression) { return default(System.Data.DataRow[]); }
    public System.Data.DataRow[] Select(string filterExpression, string sort) { return default(System.Data.DataRow[]); }
    public System.Data.DataRow[] Select(string filterExpression, string sort, System.Data.DataViewRowState recordStates) { return default(System.Data.DataRow[]); }
    System.Collections.IList System.ComponentModel.IListSource.GetList() { return default(System.Collections.IList); }
    System.Xml.Schema.XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { return default(System.Xml.Schema.XmlSchema); }
    void System.Xml.Serialization.IXmlSerializable.ReadXml(System.Xml.XmlReader reader) { }
    void System.Xml.Serialization.IXmlSerializable.WriteXml(System.Xml.XmlWriter writer) { }
    public override string ToString() { return default(string); }
    public void WriteXml(System.IO.Stream stream) { }
    public void WriteXml(System.IO.Stream stream, bool writeHierarchy) { }
    public void WriteXml(System.IO.Stream stream, System.Data.XmlWriteMode mode) { }
    public void WriteXml(System.IO.Stream stream, System.Data.XmlWriteMode mode, bool writeHierarchy) { }
    public void WriteXml(System.IO.TextWriter writer) { }
    public void WriteXml(System.IO.TextWriter writer, bool writeHierarchy) { }
    public void WriteXml(System.IO.TextWriter writer, System.Data.XmlWriteMode mode) { }
    public void WriteXml(System.IO.TextWriter writer, System.Data.XmlWriteMode mode, bool writeHierarchy) { }
    public void WriteXml(string fileName) { }
    public void WriteXml(string fileName, bool writeHierarchy) { }
    public void WriteXml(string fileName, System.Data.XmlWriteMode mode) { }
    public void WriteXml(string fileName, System.Data.XmlWriteMode mode, bool writeHierarchy) { }
    public void WriteXml(System.Xml.XmlWriter writer) { }
    public void WriteXml(System.Xml.XmlWriter writer, bool writeHierarchy) { }
    public void WriteXml(System.Xml.XmlWriter writer, System.Data.XmlWriteMode mode) { }
    public void WriteXml(System.Xml.XmlWriter writer, System.Data.XmlWriteMode mode, bool writeHierarchy) { }
    public void WriteXmlSchema(System.IO.Stream stream) { }
    public void WriteXmlSchema(System.IO.Stream stream, bool writeHierarchy) { }
    public void WriteXmlSchema(System.IO.TextWriter writer) { }
    public void WriteXmlSchema(System.IO.TextWriter writer, bool writeHierarchy) { }
    public void WriteXmlSchema(string fileName) { }
    public void WriteXmlSchema(string fileName, bool writeHierarchy) { }
    public void WriteXmlSchema(System.Xml.XmlWriter writer) { }
    public void WriteXmlSchema(System.Xml.XmlWriter writer, bool writeHierarchy) { }
  }
  public sealed partial class DataTableClearEventArgs : System.EventArgs {
    public DataTableClearEventArgs(System.Data.DataTable dataTable) { }
    public System.Data.DataTable Table { get { return default(System.Data.DataTable); } }
    public string TableName { get { return default(string); } }
    public string TableNamespace { get { return default(string); } }
  }
  public delegate void DataTableClearEventHandler(object sender, System.Data.DataTableClearEventArgs e);
  [System.ComponentModel.DefaultEventAttribute("CollectionChanged")]
  [System.ComponentModel.EditorAttribute("Microsoft.VSDesigner.Data.Design.TablesCollectionEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
  [System.ComponentModel.ListBindableAttribute(false)]
  public sealed partial class DataTableCollection : System.Data.InternalDataCollectionBase {
    internal DataTableCollection() { }
    public System.Data.DataTable this[int index] { get { return default(System.Data.DataTable); } }
    public System.Data.DataTable this[string name] { get { return default(System.Data.DataTable); } }
    public System.Data.DataTable this[string name, string tableNamespace] { get { return default(System.Data.DataTable); } }
    protected override System.Collections.ArrayList List { get { return default(System.Collections.ArrayList); } }
    [System.Data.ResDescriptionAttribute("collectionChangedEventDescr")]
    public event System.ComponentModel.CollectionChangeEventHandler CollectionChanged { add { } remove { } }
    public event System.ComponentModel.CollectionChangeEventHandler CollectionChanging { add { } remove { } }
    public System.Data.DataTable Add() { return default(System.Data.DataTable); }
    public void Add(System.Data.DataTable table) { }
    public System.Data.DataTable Add(string name) { return default(System.Data.DataTable); }
    public System.Data.DataTable Add(string name, string tableNamespace) { return default(System.Data.DataTable); }
    public void AddRange(System.Data.DataTable[] tables) { }
    public bool CanRemove(System.Data.DataTable table) { return default(bool); }
    public void Clear() { }
    public bool Contains(string name) { return default(bool); }
    public bool Contains(string name, string tableNamespace) { return default(bool); }
    public void CopyTo(System.Data.DataTable[] array, int index) { }
    public int IndexOf(System.Data.DataTable table) { return default(int); }
    public int IndexOf(string tableName) { return default(int); }
    public int IndexOf(string tableName, string tableNamespace) { return default(int); }
    public void Remove(System.Data.DataTable table) { }
    public void Remove(string name) { }
    public void Remove(string name, string tableNamespace) { }
    public void RemoveAt(int index) { }
  }
  public sealed partial class DataTableNewRowEventArgs : System.EventArgs {
    public DataTableNewRowEventArgs(System.Data.DataRow dataRow) { }
    public System.Data.DataRow Row { get { return default(System.Data.DataRow); } }
  }
  public delegate void DataTableNewRowEventHandler(object sender, System.Data.DataTableNewRowEventArgs e);
  public sealed partial class DataTableReader : System.Data.Common.DbDataReader {
    public DataTableReader(System.Data.DataTable dataTable) { }
    public DataTableReader(System.Data.DataTable[] dataTables) { }
    public override int Depth { get { return default(int); } }
    public override int FieldCount { get { return default(int); } }
    public override bool HasRows { get { return default(bool); } }
    public override bool IsClosed { get { return default(bool); } }
    public override object this[int ordinal] { get { return default(object); } }
    public override object this[string name] { get { return default(object); } }
    public override int RecordsAffected { get { return default(int); } }
    public override void Close() { }
    public override bool GetBoolean(int ordinal) { return default(bool); }
    public override byte GetByte(int ordinal) { return default(byte); }
    public override long GetBytes(int ordinal, long dataIndex, System.Byte[] buffer, int bufferIndex, int length) { return default(long); }
    public override char GetChar(int ordinal) { return default(char); }
    public override long GetChars(int ordinal, long dataIndex, System.Char[] buffer, int bufferIndex, int length) { return default(long); }
    public override string GetDataTypeName(int ordinal) { return default(string); }
    public override System.DateTime GetDateTime(int ordinal) { return default(System.DateTime); }
    public override decimal GetDecimal(int ordinal) { return default(decimal); }
    public override double GetDouble(int ordinal) { return default(double); }
    public override System.Collections.IEnumerator GetEnumerator() { return default(System.Collections.IEnumerator); }
    public override System.Type GetFieldType(int ordinal) { return default(System.Type); }
    public override float GetFloat(int ordinal) { return default(float); }
    public override System.Guid GetGuid(int ordinal) { return default(System.Guid); }
    public override short GetInt16(int ordinal) { return default(short); }
    public override int GetInt32(int ordinal) { return default(int); }
    public override long GetInt64(int ordinal) { return default(long); }
    public override string GetName(int ordinal) { return default(string); }
    public override int GetOrdinal(string name) { return default(int); }
    public override System.Type GetProviderSpecificFieldType(int ordinal) { return default(System.Type); }
    public override object GetProviderSpecificValue(int ordinal) { return default(object); }
    public override int GetProviderSpecificValues(System.Object[] values) { return default(int); }
    public override System.Data.DataTable GetSchemaTable() { return default(System.Data.DataTable); }
    public override string GetString(int ordinal) { return default(string); }
    public override object GetValue(int ordinal) { return default(object); }
    public override int GetValues(System.Object[] values) { return default(int); }
    public override bool IsDBNull(int ordinal) { return default(bool); }
    public override bool NextResult() { return default(bool); }
    public override bool Read() { return default(bool); }
  }
  [System.ComponentModel.DefaultEventAttribute("PositionChanged")]
  [System.ComponentModel.DefaultPropertyAttribute("Table")]
  [System.ComponentModel.DesignerAttribute("Microsoft.VSDesigner.Data.VS.DataViewDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
  [System.ComponentModel.EditorAttribute("Microsoft.VSDesigner.Data.Design.DataSourceEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
  public partial class DataView : System.ComponentModel.MarshalByValueComponent, System.Collections.ICollection, System.Collections.IEnumerable, System.Collections.IList, System.ComponentModel.IBindingList, System.ComponentModel.IBindingListView, System.ComponentModel.ISupportInitialize, System.ComponentModel.ISupportInitializeNotification, System.ComponentModel.ITypedList {
    public DataView() { }
    public DataView(System.Data.DataTable table) { }
    public DataView(System.Data.DataTable table, string RowFilter, string Sort, System.Data.DataViewRowState RowState) { }
    [System.ComponentModel.DefaultValueAttribute(true)]
    [System.Data.ResCategoryAttribute("DataCategory_Data")]
    [System.Data.ResDescriptionAttribute("DataViewAllowDeleteDescr")]
    public bool AllowDelete { get { return default(bool); } set { } }
    [System.ComponentModel.DefaultValueAttribute(true)]
    [System.Data.ResCategoryAttribute("DataCategory_Data")]
    [System.Data.ResDescriptionAttribute("DataViewAllowEditDescr")]
    public bool AllowEdit { get { return default(bool); } set { } }
    [System.ComponentModel.DefaultValueAttribute(true)]
    [System.Data.ResCategoryAttribute("DataCategory_Data")]
    [System.Data.ResDescriptionAttribute("DataViewAllowNewDescr")]
    public bool AllowNew { get { return default(bool); } set { } }
    [System.ComponentModel.DefaultValueAttribute(false)]
    [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
    [System.Data.ResCategoryAttribute("DataCategory_Data")]
    [System.Data.ResDescriptionAttribute("DataViewApplyDefaultSortDescr")]
    public bool ApplyDefaultSort { get { return default(bool); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.Data.ResDescriptionAttribute("DataViewCountDescr")]
    public int Count { get { return default(int); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.Data.ResDescriptionAttribute("DataViewDataViewManagerDescr")]
    public System.Data.DataViewManager DataViewManager { get { return default(System.Data.DataViewManager); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    public bool IsInitialized { get { return default(bool); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.Data.ResDescriptionAttribute("DataViewIsOpenDescr")]
    protected bool IsOpen { get { return default(bool); } }
    public System.Data.DataRowView this[int recordIndex] { get { return default(System.Data.DataRowView); } }
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.Data.ResCategoryAttribute("DataCategory_Data")]
    [System.Data.ResDescriptionAttribute("DataViewRowFilterDescr")]
    public virtual string RowFilter { get { return default(string); } set { } }
    [System.ComponentModel.DefaultValueAttribute((System.Data.DataViewRowState)(22))]
    [System.Data.ResCategoryAttribute("DataCategory_Data")]
    [System.Data.ResDescriptionAttribute("DataViewRowStateFilterDescr")]
    public System.Data.DataViewRowState RowStateFilter { get { return default(System.Data.DataViewRowState); } set { } }
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.Data.ResCategoryAttribute("DataCategory_Data")]
    [System.Data.ResDescriptionAttribute("DataViewSortDescr")]
    public string Sort { get { return default(string); } set { } }
    bool System.Collections.ICollection.IsSynchronized { get { return default(bool); } }
    object System.Collections.ICollection.SyncRoot { get { return default(object); } }
    bool System.Collections.IList.IsFixedSize { get { return default(bool); } }
    bool System.Collections.IList.IsReadOnly { get { return default(bool); } }
    object System.Collections.IList.this[int recordIndex] { get { return default(object); } set { } }
    bool System.ComponentModel.IBindingList.AllowEdit { get { return default(bool); } }
    bool System.ComponentModel.IBindingList.AllowNew { get { return default(bool); } }
    bool System.ComponentModel.IBindingList.AllowRemove { get { return default(bool); } }
    bool System.ComponentModel.IBindingList.IsSorted { get { return default(bool); } }
    System.ComponentModel.ListSortDirection System.ComponentModel.IBindingList.SortDirection { get { return default(System.ComponentModel.ListSortDirection); } }
    System.ComponentModel.PropertyDescriptor System.ComponentModel.IBindingList.SortProperty { get { return default(System.ComponentModel.PropertyDescriptor); } }
    bool System.ComponentModel.IBindingList.SupportsChangeNotification { get { return default(bool); } }
    bool System.ComponentModel.IBindingList.SupportsSearching { get { return default(bool); } }
    bool System.ComponentModel.IBindingList.SupportsSorting { get { return default(bool); } }
    string System.ComponentModel.IBindingListView.Filter { get { return default(string); } set { } }
    System.ComponentModel.ListSortDescriptionCollection System.ComponentModel.IBindingListView.SortDescriptions { get { return default(System.ComponentModel.ListSortDescriptionCollection); } }
    bool System.ComponentModel.IBindingListView.SupportsAdvancedSorting { get { return default(bool); } }
    bool System.ComponentModel.IBindingListView.SupportsFiltering { get { return default(bool); } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Data.DataTableTypeConverter))]
    [System.Data.ResCategoryAttribute("DataCategory_Data")]
    [System.Data.ResDescriptionAttribute("DataViewTableDescr")]
    public System.Data.DataTable Table { get { return default(System.Data.DataTable); } set { } }
    [System.Data.ResCategoryAttribute("DataCategory_Action")]
    [System.Data.ResDescriptionAttribute("DataSetInitializedDescr")]
    public event System.EventHandler Initialized { add { } remove { } }
    [System.Data.ResCategoryAttribute("DataCategory_Data")]
    [System.Data.ResDescriptionAttribute("DataViewListChangedDescr")]
    public event System.ComponentModel.ListChangedEventHandler ListChanged { add { } remove { } }
    public virtual System.Data.DataRowView AddNew() { return default(System.Data.DataRowView); }
    public void BeginInit() { }
    protected void Close() { }
    protected virtual void ColumnCollectionChanged(object sender, System.ComponentModel.CollectionChangeEventArgs e) { }
    public void CopyTo(System.Array array, int index) { }
    public void Delete(int index) { }
    protected override void Dispose(bool disposing) { }
    public void EndInit() { }
    public virtual bool Equals(System.Data.DataView view) { return default(bool); }
    public int Find(object key) { return default(int); }
    public int Find(System.Object[] key) { return default(int); }
    public System.Data.DataRowView[] FindRows(object key) { return default(System.Data.DataRowView[]); }
    public System.Data.DataRowView[] FindRows(System.Object[] key) { return default(System.Data.DataRowView[]); }
    public System.Collections.IEnumerator GetEnumerator() { return default(System.Collections.IEnumerator); }
    protected virtual void IndexListChanged(object sender, System.ComponentModel.ListChangedEventArgs e) { }
    protected virtual void OnListChanged(System.ComponentModel.ListChangedEventArgs e) { }
    protected void Open() { }
    protected void Reset() { }
    int System.Collections.IList.Add(object value) { return default(int); }
    void System.Collections.IList.Clear() { }
    bool System.Collections.IList.Contains(object value) { return default(bool); }
    int System.Collections.IList.IndexOf(object value) { return default(int); }
    void System.Collections.IList.Insert(int index, object value) { }
    void System.Collections.IList.Remove(object value) { }
    void System.Collections.IList.RemoveAt(int index) { }
    void System.ComponentModel.IBindingList.AddIndex(System.ComponentModel.PropertyDescriptor property) { }
    object System.ComponentModel.IBindingList.AddNew() { return default(object); }
    void System.ComponentModel.IBindingList.ApplySort(System.ComponentModel.PropertyDescriptor property, System.ComponentModel.ListSortDirection direction) { }
    int System.ComponentModel.IBindingList.Find(System.ComponentModel.PropertyDescriptor property, object key) { return default(int); }
    void System.ComponentModel.IBindingList.RemoveIndex(System.ComponentModel.PropertyDescriptor property) { }
    void System.ComponentModel.IBindingList.RemoveSort() { }
    void System.ComponentModel.IBindingListView.ApplySort(System.ComponentModel.ListSortDescriptionCollection sorts) { }
    void System.ComponentModel.IBindingListView.RemoveFilter() { }
    System.ComponentModel.PropertyDescriptorCollection System.ComponentModel.ITypedList.GetItemProperties(System.ComponentModel.PropertyDescriptor[] listAccessors) { return default(System.ComponentModel.PropertyDescriptorCollection); }
    string System.ComponentModel.ITypedList.GetListName(System.ComponentModel.PropertyDescriptor[] listAccessors) { return default(string); }
    public System.Data.DataTable ToTable() { return default(System.Data.DataTable); }
    public System.Data.DataTable ToTable(bool distinct, params System.String[] columnNames) { return default(System.Data.DataTable); }
    public System.Data.DataTable ToTable(string tableName) { return default(System.Data.DataTable); }
    public System.Data.DataTable ToTable(string tableName, bool distinct, params System.String[] columnNames) { return default(System.Data.DataTable); }
    protected void UpdateIndex() { }
    protected virtual void UpdateIndex(bool force) { }
  }
  [System.ComponentModel.DesignerAttribute("Microsoft.VSDesigner.Data.VS.DataViewManagerDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
  public partial class DataViewManager : System.ComponentModel.MarshalByValueComponent, System.Collections.ICollection, System.Collections.IEnumerable, System.Collections.IList, System.ComponentModel.IBindingList, System.ComponentModel.ITypedList {
    public DataViewManager() { }
    public DataViewManager(System.Data.DataSet dataSet) { }
    [System.ComponentModel.DefaultValueAttribute(null)]
    [System.Data.ResDescriptionAttribute("DataViewManagerDataSetDescr")]
    public System.Data.DataSet DataSet { get { return default(System.Data.DataSet); } set { } }
    public string DataViewSettingCollectionString { get { return default(string); } set { } }
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(2))]
    [System.Data.ResDescriptionAttribute("DataViewManagerTableSettingsDescr")]
    public System.Data.DataViewSettingCollection DataViewSettings { get { return default(System.Data.DataViewSettingCollection); } }
    int System.Collections.ICollection.Count { get { return default(int); } }
    bool System.Collections.ICollection.IsSynchronized { get { return default(bool); } }
    object System.Collections.ICollection.SyncRoot { get { return default(object); } }
    bool System.Collections.IList.IsFixedSize { get { return default(bool); } }
    bool System.Collections.IList.IsReadOnly { get { return default(bool); } }
    object System.Collections.IList.this[int index] { get { return default(object); } set { } }
    bool System.ComponentModel.IBindingList.AllowEdit { get { return default(bool); } }
    bool System.ComponentModel.IBindingList.AllowNew { get { return default(bool); } }
    bool System.ComponentModel.IBindingList.AllowRemove { get { return default(bool); } }
    bool System.ComponentModel.IBindingList.IsSorted { get { return default(bool); } }
    System.ComponentModel.ListSortDirection System.ComponentModel.IBindingList.SortDirection { get { return default(System.ComponentModel.ListSortDirection); } }
    System.ComponentModel.PropertyDescriptor System.ComponentModel.IBindingList.SortProperty { get { return default(System.ComponentModel.PropertyDescriptor); } }
    bool System.ComponentModel.IBindingList.SupportsChangeNotification { get { return default(bool); } }
    bool System.ComponentModel.IBindingList.SupportsSearching { get { return default(bool); } }
    bool System.ComponentModel.IBindingList.SupportsSorting { get { return default(bool); } }
    public event System.ComponentModel.ListChangedEventHandler ListChanged { add { } remove { } }
    public System.Data.DataView CreateDataView(System.Data.DataTable table) { return default(System.Data.DataView); }
    protected virtual void OnListChanged(System.ComponentModel.ListChangedEventArgs e) { }
    protected virtual void RelationCollectionChanged(object sender, System.ComponentModel.CollectionChangeEventArgs e) { }
    void System.Collections.ICollection.CopyTo(System.Array array, int index) { }
    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { return default(System.Collections.IEnumerator); }
    int System.Collections.IList.Add(object value) { return default(int); }
    void System.Collections.IList.Clear() { }
    bool System.Collections.IList.Contains(object value) { return default(bool); }
    int System.Collections.IList.IndexOf(object value) { return default(int); }
    void System.Collections.IList.Insert(int index, object value) { }
    void System.Collections.IList.Remove(object value) { }
    void System.Collections.IList.RemoveAt(int index) { }
    void System.ComponentModel.IBindingList.AddIndex(System.ComponentModel.PropertyDescriptor property) { }
    object System.ComponentModel.IBindingList.AddNew() { return default(object); }
    void System.ComponentModel.IBindingList.ApplySort(System.ComponentModel.PropertyDescriptor property, System.ComponentModel.ListSortDirection direction) { }
    int System.ComponentModel.IBindingList.Find(System.ComponentModel.PropertyDescriptor property, object key) { return default(int); }
    void System.ComponentModel.IBindingList.RemoveIndex(System.ComponentModel.PropertyDescriptor property) { }
    void System.ComponentModel.IBindingList.RemoveSort() { }
    System.ComponentModel.PropertyDescriptorCollection System.ComponentModel.ITypedList.GetItemProperties(System.ComponentModel.PropertyDescriptor[] listAccessors) { return default(System.ComponentModel.PropertyDescriptorCollection); }
    string System.ComponentModel.ITypedList.GetListName(System.ComponentModel.PropertyDescriptor[] listAccessors) { return default(string); }
    protected virtual void TableCollectionChanged(object sender, System.ComponentModel.CollectionChangeEventArgs e) { }
  }
  [System.ComponentModel.EditorAttribute("Microsoft.VSDesigner.Data.Design.DataViewRowStateEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
  [System.FlagsAttribute]
  public enum DataViewRowState {
    Added = 4,
    CurrentRows = 22,
    Deleted = 8,
    ModifiedCurrent = 16,
    ModifiedOriginal = 32,
    None = 0,
    OriginalRows = 42,
    Unchanged = 2,
  }
  [System.ComponentModel.TypeConverterAttribute(typeof(System.ComponentModel.ExpandableObjectConverter))]
  public partial class DataViewSetting {
    internal DataViewSetting() { }
    public bool ApplyDefaultSort { get { return default(bool); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    public System.Data.DataViewManager DataViewManager { get { return default(System.Data.DataViewManager); } }
    public string RowFilter { get { return default(string); } set { } }
    public System.Data.DataViewRowState RowStateFilter { get { return default(System.Data.DataViewRowState); } set { } }
    public string Sort { get { return default(string); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    public System.Data.DataTable Table { get { return default(System.Data.DataTable); } }
  }
  [System.ComponentModel.EditorAttribute("Microsoft.VSDesigner.Data.Design.DataViewSettingsCollectionEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
  public partial class DataViewSettingCollection : System.Collections.ICollection, System.Collections.IEnumerable {
    internal DataViewSettingCollection() { }
    [System.ComponentModel.BrowsableAttribute(false)]
    public virtual int Count { get { return default(int); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    public bool IsReadOnly { get { return default(bool); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    public bool IsSynchronized { get { return default(bool); } }
    public virtual System.Data.DataViewSetting this[System.Data.DataTable table] { get { return default(System.Data.DataViewSetting); } set { } }
    public virtual System.Data.DataViewSetting this[int index] { get { return default(System.Data.DataViewSetting); } set { } }
    public virtual System.Data.DataViewSetting this[string tableName] { get { return default(System.Data.DataViewSetting); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    public object SyncRoot { get { return default(object); } }
    public void CopyTo(System.Array ar, int index) { }
    public void CopyTo(System.Data.DataViewSetting[] ar, int index) { }
    public System.Collections.IEnumerator GetEnumerator() { return default(System.Collections.IEnumerator); }
  }
  public sealed partial class DBConcurrencyException : System.SystemException {
    public DBConcurrencyException() { }
    public DBConcurrencyException(string message) { }
    public DBConcurrencyException(string message, System.Exception inner) { }
    public DBConcurrencyException(string message, System.Exception inner, System.Data.DataRow[] dataRows) { }
    public System.Data.DataRow Row { get { return default(System.Data.DataRow); } set { } }
    public int RowCount { get { return default(int); } }
    public void CopyToRows(System.Data.DataRow[] array) { }
    public void CopyToRows(System.Data.DataRow[] array, int arrayIndex) { }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(128))]
    public override void GetObjectData(System.Runtime.Serialization.SerializationInfo si, System.Runtime.Serialization.StreamingContext context) { }
  }
  public enum DbType {
    AnsiString = 0,
    AnsiStringFixedLength = 22,
    Binary = 1,
    Boolean = 3,
    Byte = 2,
    Currency = 4,
    Date = 5,
    DateTime = 6,
    DateTime2 = 26,
    DateTimeOffset = 27,
    Decimal = 7,
    Double = 8,
    Guid = 9,
    Int16 = 10,
    Int32 = 11,
    Int64 = 12,
    Object = 13,
    SByte = 14,
    Single = 15,
    String = 16,
    StringFixedLength = 23,
    Time = 17,
    UInt16 = 18,
    UInt32 = 19,
    UInt64 = 20,
    VarNumeric = 21,
    Xml = 25,
  }
  public partial class DeletedRowInaccessibleException : System.Data.DataException {
    public DeletedRowInaccessibleException() { }
    protected DeletedRowInaccessibleException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public DeletedRowInaccessibleException(string s) { }
    public DeletedRowInaccessibleException(string message, System.Exception innerException) { }
  }
  public partial class DuplicateNameException : System.Data.DataException {
    public DuplicateNameException() { }
    protected DuplicateNameException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public DuplicateNameException(string s) { }
    public DuplicateNameException(string message, System.Exception innerException) { }
  }
  public partial class EvaluateException : System.Data.InvalidExpressionException {
    public EvaluateException() { }
    protected EvaluateException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public EvaluateException(string s) { }
    public EvaluateException(string message, System.Exception innerException) { }
  }
  public partial class FillErrorEventArgs : System.EventArgs {
    public FillErrorEventArgs(System.Data.DataTable dataTable, System.Object[] values) { }
    public bool Continue { get { return default(bool); } set { } }
    public System.Data.DataTable DataTable { get { return default(System.Data.DataTable); } }
    public System.Exception Errors { get { return default(System.Exception); } set { } }
    public System.Object[] Values { get { return default(System.Object[]); } }
  }
  public delegate void FillErrorEventHandler(object sender, System.Data.FillErrorEventArgs e);
  [System.ComponentModel.DefaultPropertyAttribute("ConstraintName")]
  [System.ComponentModel.EditorAttribute("Microsoft.VSDesigner.Data.Design.ForeignKeyConstraintEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
  public partial class ForeignKeyConstraint : System.Data.Constraint {
    public ForeignKeyConstraint(System.Data.DataColumn parentColumn, System.Data.DataColumn childColumn) { }
    public ForeignKeyConstraint(System.Data.DataColumn[] parentColumns, System.Data.DataColumn[] childColumns) { }
    public ForeignKeyConstraint(string constraintName, System.Data.DataColumn parentColumn, System.Data.DataColumn childColumn) { }
    public ForeignKeyConstraint(string constraintName, System.Data.DataColumn[] parentColumns, System.Data.DataColumn[] childColumns) { }
    [System.ComponentModel.BrowsableAttribute(false)]
    public ForeignKeyConstraint(string constraintName, string parentTableName, string parentTableNamespace, System.String[] parentColumnNames, System.String[] childColumnNames, System.Data.AcceptRejectRule acceptRejectRule, System.Data.Rule deleteRule, System.Data.Rule updateRule) { }
    [System.ComponentModel.BrowsableAttribute(false)]
    public ForeignKeyConstraint(string constraintName, string parentTableName, System.String[] parentColumnNames, System.String[] childColumnNames, System.Data.AcceptRejectRule acceptRejectRule, System.Data.Rule deleteRule, System.Data.Rule updateRule) { }
    [System.ComponentModel.DefaultValueAttribute((System.Data.AcceptRejectRule)(0))]
    [System.Data.ResCategoryAttribute("DataCategory_Data")]
    [System.Data.ResDescriptionAttribute("ForeignKeyConstraintAcceptRejectRuleDescr")]
    public virtual System.Data.AcceptRejectRule AcceptRejectRule { get { return default(System.Data.AcceptRejectRule); } set { } }
    [System.ComponentModel.ReadOnlyAttribute(true)]
    [System.Data.ResCategoryAttribute("DataCategory_Data")]
    [System.Data.ResDescriptionAttribute("ForeignKeyConstraintChildColumnsDescr")]
    public virtual System.Data.DataColumn[] Columns { get { return default(System.Data.DataColumn[]); } }
    [System.ComponentModel.DefaultValueAttribute((System.Data.Rule)(1))]
    [System.Data.ResCategoryAttribute("DataCategory_Data")]
    [System.Data.ResDescriptionAttribute("ForeignKeyConstraintDeleteRuleDescr")]
    public virtual System.Data.Rule DeleteRule { get { return default(System.Data.Rule); } set { } }
    [System.ComponentModel.ReadOnlyAttribute(true)]
    [System.Data.ResCategoryAttribute("DataCategory_Data")]
    [System.Data.ResDescriptionAttribute("ForeignKeyConstraintParentColumnsDescr")]
    public virtual System.Data.DataColumn[] RelatedColumns { get { return default(System.Data.DataColumn[]); } }
    [System.ComponentModel.ReadOnlyAttribute(true)]
    [System.Data.ResCategoryAttribute("DataCategory_Data")]
    [System.Data.ResDescriptionAttribute("ForeignKeyRelatedTableDescr")]
    public virtual System.Data.DataTable RelatedTable { get { return default(System.Data.DataTable); } }
    [System.ComponentModel.ReadOnlyAttribute(true)]
    [System.Data.ResCategoryAttribute("DataCategory_Data")]
    [System.Data.ResDescriptionAttribute("ConstraintTableDescr")]
    public override System.Data.DataTable Table { get { return default(System.Data.DataTable); } }
    [System.ComponentModel.DefaultValueAttribute((System.Data.Rule)(1))]
    [System.Data.ResCategoryAttribute("DataCategory_Data")]
    [System.Data.ResDescriptionAttribute("ForeignKeyConstraintUpdateRuleDescr")]
    public virtual System.Data.Rule UpdateRule { get { return default(System.Data.Rule); } set { } }
    public override bool Equals(object key) { return default(bool); }
    public override int GetHashCode() { return default(int); }
  }
  public partial interface IColumnMapping {
    string DataSetColumn { get; set; }
    string SourceColumn { get; set; }
  }
  public partial interface IColumnMappingCollection : System.Collections.ICollection, System.Collections.IEnumerable, System.Collections.IList {
    object this[string index] { get; set; }
    System.Data.IColumnMapping Add(string sourceColumnName, string dataSetColumnName);
    bool Contains(string sourceColumnName);
    System.Data.IColumnMapping GetByDataSetColumn(string dataSetColumnName);
    int IndexOf(string sourceColumnName);
    void RemoveAt(string sourceColumnName);
  }
  public partial interface IDataAdapter {
    System.Data.MissingMappingAction MissingMappingAction { get; set; }
    System.Data.MissingSchemaAction MissingSchemaAction { get; set; }
    System.Data.ITableMappingCollection TableMappings { get; }
    int Fill(System.Data.DataSet dataSet);
    System.Data.DataTable[] FillSchema(System.Data.DataSet dataSet, System.Data.SchemaType schemaType);
    System.Data.IDataParameter[] GetFillParameters();
    int Update(System.Data.DataSet dataSet);
  }
  public partial interface IDataParameter {
    System.Data.DbType DbType { get; set; }
    System.Data.ParameterDirection Direction { get; set; }
    bool IsNullable { get; }
    string ParameterName { get; set; }
    string SourceColumn { get; set; }
    System.Data.DataRowVersion SourceVersion { get; set; }
    object Value { get; set; }
  }
  public partial interface IDataParameterCollection : System.Collections.ICollection, System.Collections.IEnumerable, System.Collections.IList {
    object this[string parameterName] { get; set; }
    bool Contains(string parameterName);
    int IndexOf(string parameterName);
    void RemoveAt(string parameterName);
  }
  public partial interface IDataReader : System.Data.IDataRecord, System.IDisposable {
    int Depth { get; }
    bool IsClosed { get; }
    int RecordsAffected { get; }
    void Close();
    System.Data.DataTable GetSchemaTable();
    bool NextResult();
    bool Read();
  }
  public partial interface IDataRecord {
    int FieldCount { get; }
    object this[int i] { get; }
    object this[string name] { get; }
    bool GetBoolean(int i);
    byte GetByte(int i);
    long GetBytes(int i, long fieldOffset, System.Byte[] buffer, int bufferoffset, int length);
    char GetChar(int i);
    long GetChars(int i, long fieldoffset, System.Char[] buffer, int bufferoffset, int length);
    System.Data.IDataReader GetData(int i);
    string GetDataTypeName(int i);
    System.DateTime GetDateTime(int i);
    decimal GetDecimal(int i);
    double GetDouble(int i);
    System.Type GetFieldType(int i);
    float GetFloat(int i);
    System.Guid GetGuid(int i);
    short GetInt16(int i);
    int GetInt32(int i);
    long GetInt64(int i);
    string GetName(int i);
    int GetOrdinal(string name);
    string GetString(int i);
    object GetValue(int i);
    int GetValues(System.Object[] values);
    bool IsDBNull(int i);
  }
  public partial interface IDbCommand : System.IDisposable {
    string CommandText { get; set; }
    int CommandTimeout { get; set; }
    System.Data.CommandType CommandType { get; set; }
    System.Data.IDbConnection Connection { get; set; }
    System.Data.IDataParameterCollection Parameters { get; }
    System.Data.IDbTransaction Transaction { get; set; }
    System.Data.UpdateRowSource UpdatedRowSource { get; set; }
    void Cancel();
    System.Data.IDbDataParameter CreateParameter();
    int ExecuteNonQuery();
    System.Data.IDataReader ExecuteReader();
    System.Data.IDataReader ExecuteReader(System.Data.CommandBehavior behavior);
    object ExecuteScalar();
    void Prepare();
  }
  public partial interface IDbConnection : System.IDisposable {
    string ConnectionString { get; set; }
    int ConnectionTimeout { get; }
    string Database { get; }
    System.Data.ConnectionState State { get; }
    System.Data.IDbTransaction BeginTransaction();
    System.Data.IDbTransaction BeginTransaction(System.Data.IsolationLevel il);
    void ChangeDatabase(string databaseName);
    void Close();
    System.Data.IDbCommand CreateCommand();
    void Open();
  }
  public partial interface IDbDataAdapter : System.Data.IDataAdapter {
    System.Data.IDbCommand DeleteCommand { get; set; }
    System.Data.IDbCommand InsertCommand { get; set; }
    System.Data.IDbCommand SelectCommand { get; set; }
    System.Data.IDbCommand UpdateCommand { get; set; }
  }
  public partial interface IDbDataParameter : System.Data.IDataParameter {
    byte Precision { get; set; }
    byte Scale { get; set; }
    int Size { get; set; }
  }
  public partial interface IDbTransaction : System.IDisposable {
    System.Data.IDbConnection Connection { get; }
    System.Data.IsolationLevel IsolationLevel { get; }
    void Commit();
    void Rollback();
  }
  public partial class InRowChangingEventException : System.Data.DataException {
    public InRowChangingEventException() { }
    protected InRowChangingEventException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public InRowChangingEventException(string s) { }
    public InRowChangingEventException(string message, System.Exception innerException) { }
  }
  public partial class InternalDataCollectionBase : System.Collections.ICollection, System.Collections.IEnumerable {
    public InternalDataCollectionBase() { }
    [System.ComponentModel.BrowsableAttribute(false)]
    public virtual int Count { get { return default(int); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    public bool IsReadOnly { get { return default(bool); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    public bool IsSynchronized { get { return default(bool); } }
    protected virtual System.Collections.ArrayList List { get { return default(System.Collections.ArrayList); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    public object SyncRoot { get { return default(object); } }
    public virtual void CopyTo(System.Array ar, int index) { }
    public virtual System.Collections.IEnumerator GetEnumerator() { return default(System.Collections.IEnumerator); }
  }
  public partial class InvalidConstraintException : System.Data.DataException {
    public InvalidConstraintException() { }
    protected InvalidConstraintException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public InvalidConstraintException(string s) { }
    public InvalidConstraintException(string message, System.Exception innerException) { }
  }
  public partial class InvalidExpressionException : System.Data.DataException {
    public InvalidExpressionException() { }
    protected InvalidExpressionException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public InvalidExpressionException(string s) { }
    public InvalidExpressionException(string message, System.Exception innerException) { }
  }
  public enum IsolationLevel {
    Chaos = 16,
    ReadCommitted = 4096,
    ReadUncommitted = 256,
    RepeatableRead = 65536,
    Serializable = 1048576,
    Snapshot = 16777216,
    Unspecified = -1,
  }
  public partial interface ITableMapping {
    System.Data.IColumnMappingCollection ColumnMappings { get; }
    string DataSetTable { get; set; }
    string SourceTable { get; set; }
  }
  public partial interface ITableMappingCollection : System.Collections.ICollection, System.Collections.IEnumerable, System.Collections.IList {
    object this[string index] { get; set; }
    System.Data.ITableMapping Add(string sourceTableName, string dataSetTableName);
    bool Contains(string sourceTableName);
    System.Data.ITableMapping GetByDataSetTable(string dataSetTableName);
    int IndexOf(string sourceTableName);
    void RemoveAt(string sourceTableName);
  }
  public enum KeyRestrictionBehavior {
    AllowOnly = 0,
    PreventUsage = 1,
  }
  public enum LoadOption {
    OverwriteChanges = 1,
    PreserveChanges = 2,
    Upsert = 3,
  }
  public enum MappingType {
    Attribute = 2,
    Element = 1,
    Hidden = 4,
    SimpleContent = 3,
  }
  public partial class MergeFailedEventArgs : System.EventArgs {
    public MergeFailedEventArgs(System.Data.DataTable table, string conflict) { }
    public string Conflict { get { return default(string); } }
    public System.Data.DataTable Table { get { return default(System.Data.DataTable); } }
  }
  public delegate void MergeFailedEventHandler(object sender, System.Data.MergeFailedEventArgs e);
  public enum MissingMappingAction {
    Error = 3,
    Ignore = 2,
    Passthrough = 1,
  }
  public partial class MissingPrimaryKeyException : System.Data.DataException {
    public MissingPrimaryKeyException() { }
    protected MissingPrimaryKeyException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public MissingPrimaryKeyException(string s) { }
    public MissingPrimaryKeyException(string message, System.Exception innerException) { }
  }
  public enum MissingSchemaAction {
    Add = 1,
    AddWithKey = 4,
    Error = 3,
    Ignore = 2,
  }
  public partial class NoNullAllowedException : System.Data.DataException {
    public NoNullAllowedException() { }
    protected NoNullAllowedException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public NoNullAllowedException(string s) { }
    public NoNullAllowedException(string message, System.Exception innerException) { }
  }
  public sealed partial class OperationAbortedException : System.SystemException {
    internal OperationAbortedException() { }
  }
  public enum ParameterDirection {
    Input = 1,
    InputOutput = 3,
    Output = 2,
    ReturnValue = 6,
  }
  [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
  [System.FlagsAttribute]
  [System.ObsoleteAttribute("PropertyAttributes has been deprecated.  http://go.microsoft.com/fwlink/?linkid=14202")]
  public enum PropertyAttributes {
    NotSupported = 0,
    Optional = 2,
    Read = 512,
    Required = 1,
    Write = 1024,
  }
  public partial class PropertyCollection : System.Collections.Hashtable {
    public PropertyCollection() { }
    protected PropertyCollection(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public override object Clone() { return default(object); }
  }
  public partial class ReadOnlyException : System.Data.DataException {
    public ReadOnlyException() { }
    protected ReadOnlyException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public ReadOnlyException(string s) { }
    public ReadOnlyException(string message, System.Exception innerException) { }
  }
  public partial class RowNotInTableException : System.Data.DataException {
    public RowNotInTableException() { }
    protected RowNotInTableException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public RowNotInTableException(string s) { }
    public RowNotInTableException(string message, System.Exception innerException) { }
  }
  public enum Rule {
    Cascade = 1,
    None = 0,
    SetDefault = 3,
    SetNull = 2,
  }
  public enum SchemaSerializationMode {
    ExcludeSchema = 2,
    IncludeSchema = 1,
  }
  public enum SchemaType {
    Mapped = 2,
    Source = 1,
  }
  public enum SerializationFormat {
    Binary = 1,
    Xml = 0,
  }
  public enum SqlDbType {
    BigInt = 0,
    Binary = 1,
    Bit = 2,
    Char = 3,
    Date = 31,
    DateTime = 4,
    DateTime2 = 33,
    DateTimeOffset = 34,
    Decimal = 5,
    Float = 6,
    Image = 7,
    Int = 8,
    Money = 9,
    NChar = 10,
    NText = 11,
    NVarChar = 12,
    Real = 13,
    SmallDateTime = 15,
    SmallInt = 16,
    SmallMoney = 17,
    Structured = 30,
    Text = 18,
    Time = 32,
    Timestamp = 19,
    TinyInt = 20,
    Udt = 29,
    UniqueIdentifier = 14,
    VarBinary = 21,
    VarChar = 22,
    Variant = 23,
    Xml = 25,
  }
  public sealed partial class StateChangeEventArgs : System.EventArgs {
    public StateChangeEventArgs(System.Data.ConnectionState originalState, System.Data.ConnectionState currentState) { }
    public System.Data.ConnectionState CurrentState { get { return default(System.Data.ConnectionState); } }
    public System.Data.ConnectionState OriginalState { get { return default(System.Data.ConnectionState); } }
  }
  public delegate void StateChangeEventHandler(object sender, System.Data.StateChangeEventArgs e);
  public sealed partial class StatementCompletedEventArgs : System.EventArgs {
    public StatementCompletedEventArgs(int recordCount) { }
    public int RecordCount { get { return default(int); } }
  }
  public delegate void StatementCompletedEventHandler(object sender, System.Data.StatementCompletedEventArgs e);
  public enum StatementType {
    Batch = 4,
    Delete = 3,
    Insert = 1,
    Select = 0,
    Update = 2,
  }
  public partial class StrongTypingException : System.Data.DataException {
    public StrongTypingException() { }
    protected StrongTypingException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public StrongTypingException(string message) { }
    public StrongTypingException(string s, System.Exception innerException) { }
  }
  public partial class SyntaxErrorException : System.Data.InvalidExpressionException {
    public SyntaxErrorException() { }
    protected SyntaxErrorException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public SyntaxErrorException(string s) { }
    public SyntaxErrorException(string message, System.Exception innerException) { }
  }
  [System.ObsoleteAttribute("TypedDataSetGenerator class will be removed in a future release. Please use System.Data.Design.TypedDataSetGenerator in System.Design.dll.")]
  [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, SharedState=true, Synchronization=true)]
  public partial class TypedDataSetGenerator {
    public TypedDataSetGenerator() { }
    public static void Generate(System.Data.DataSet dataSet, System.CodeDom.CodeNamespace codeNamespace, System.CodeDom.Compiler.ICodeGenerator codeGen) { }
    public static string GenerateIdName(string name, System.CodeDom.Compiler.ICodeGenerator codeGen) { return default(string); }
  }
  public partial class TypedDataSetGeneratorException : System.Data.DataException {
    public TypedDataSetGeneratorException() { }
    public TypedDataSetGeneratorException(System.Collections.ArrayList list) { }
    protected TypedDataSetGeneratorException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public TypedDataSetGeneratorException(string message) { }
    public TypedDataSetGeneratorException(string message, System.Exception innerException) { }
    public System.Collections.ArrayList ErrorList { get { return default(System.Collections.ArrayList); } }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(128))]
    public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
  }
  [System.ComponentModel.DefaultPropertyAttribute("ConstraintName")]
  [System.ComponentModel.EditorAttribute("Microsoft.VSDesigner.Data.Design.UniqueConstraintEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
  public partial class UniqueConstraint : System.Data.Constraint {
    public UniqueConstraint(System.Data.DataColumn column) { }
    public UniqueConstraint(System.Data.DataColumn column, bool isPrimaryKey) { }
    public UniqueConstraint(System.Data.DataColumn[] columns) { }
    public UniqueConstraint(System.Data.DataColumn[] columns, bool isPrimaryKey) { }
    public UniqueConstraint(string name, System.Data.DataColumn column) { }
    public UniqueConstraint(string name, System.Data.DataColumn column, bool isPrimaryKey) { }
    public UniqueConstraint(string name, System.Data.DataColumn[] columns) { }
    public UniqueConstraint(string name, System.Data.DataColumn[] columns, bool isPrimaryKey) { }
    [System.ComponentModel.BrowsableAttribute(false)]
    public UniqueConstraint(string name, System.String[] columnNames, bool isPrimaryKey) { }
    [System.ComponentModel.ReadOnlyAttribute(true)]
    [System.Data.ResCategoryAttribute("DataCategory_Data")]
    [System.Data.ResDescriptionAttribute("KeyConstraintColumnsDescr")]
    public virtual System.Data.DataColumn[] Columns { get { return default(System.Data.DataColumn[]); } }
    [System.Data.ResCategoryAttribute("DataCategory_Data")]
    [System.Data.ResDescriptionAttribute("KeyConstraintIsPrimaryKeyDescr")]
    public bool IsPrimaryKey { get { return default(bool); } }
    [System.ComponentModel.ReadOnlyAttribute(true)]
    [System.Data.ResCategoryAttribute("DataCategory_Data")]
    [System.Data.ResDescriptionAttribute("ConstraintTableDescr")]
    public override System.Data.DataTable Table { get { return default(System.Data.DataTable); } }
    public override bool Equals(object key2) { return default(bool); }
    public override int GetHashCode() { return default(int); }
  }
  public enum UpdateRowSource {
    Both = 3,
    FirstReturnedRecord = 2,
    None = 0,
    OutputParameters = 1,
  }
  public enum UpdateStatus {
    Continue = 0,
    ErrorsOccurred = 1,
    SkipAllRemainingRows = 3,
    SkipCurrentRow = 2,
  }
  public partial class VersionNotFoundException : System.Data.DataException {
    public VersionNotFoundException() { }
    protected VersionNotFoundException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public VersionNotFoundException(string s) { }
    public VersionNotFoundException(string message, System.Exception innerException) { }
  }
  public enum XmlReadMode {
    Auto = 0,
    DiffGram = 4,
    Fragment = 5,
    IgnoreSchema = 2,
    InferSchema = 3,
    InferTypedSchema = 6,
    ReadSchema = 1,
  }
  public enum XmlWriteMode {
    DiffGram = 2,
    IgnoreSchema = 1,
    WriteSchema = 0,
  }
}
namespace System.Data.Common {
  public enum CatalogLocation {
    End = 2,
    Start = 1,
  }
  public partial class DataAdapter : System.ComponentModel.Component, System.Data.IDataAdapter {
    protected DataAdapter() { }
    protected DataAdapter(System.Data.Common.DataAdapter from) { }
    [System.ComponentModel.DefaultValueAttribute(true)]
    [System.Data.ResCategoryAttribute("DataCategory_Fill")]
    [System.Data.ResDescriptionAttribute("DataAdapter_AcceptChangesDuringFill")]
    public bool AcceptChangesDuringFill { get { return default(bool); } set { } }
    [System.ComponentModel.DefaultValueAttribute(true)]
    [System.Data.ResCategoryAttribute("DataCategory_Update")]
    [System.Data.ResDescriptionAttribute("DataAdapter_AcceptChangesDuringUpdate")]
    public bool AcceptChangesDuringUpdate { get { return default(bool); } set { } }
    [System.ComponentModel.DefaultValueAttribute(false)]
    [System.Data.ResCategoryAttribute("DataCategory_Update")]
    [System.Data.ResDescriptionAttribute("DataAdapter_ContinueUpdateOnError")]
    public bool ContinueUpdateOnError { get { return default(bool); } set { } }
    [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
    [System.Data.ResCategoryAttribute("DataCategory_Fill")]
    [System.Data.ResDescriptionAttribute("DataAdapter_FillLoadOption")]
    public System.Data.LoadOption FillLoadOption { get { return default(System.Data.LoadOption); } set { } }
    [System.ComponentModel.DefaultValueAttribute((System.Data.MissingMappingAction)(1))]
    [System.Data.ResCategoryAttribute("DataCategory_Mapping")]
    [System.Data.ResDescriptionAttribute("DataAdapter_MissingMappingAction")]
    public System.Data.MissingMappingAction MissingMappingAction { get { return default(System.Data.MissingMappingAction); } set { } }
    [System.ComponentModel.DefaultValueAttribute((System.Data.MissingSchemaAction)(1))]
    [System.Data.ResCategoryAttribute("DataCategory_Mapping")]
    [System.Data.ResDescriptionAttribute("DataAdapter_MissingSchemaAction")]
    public System.Data.MissingSchemaAction MissingSchemaAction { get { return default(System.Data.MissingSchemaAction); } set { } }
    [System.ComponentModel.DefaultValueAttribute(false)]
    [System.Data.ResCategoryAttribute("DataCategory_Fill")]
    [System.Data.ResDescriptionAttribute("DataAdapter_ReturnProviderSpecificTypes")]
    public virtual bool ReturnProviderSpecificTypes { get { return default(bool); } set { } }
    System.Data.ITableMappingCollection System.Data.IDataAdapter.TableMappings { get { return default(System.Data.ITableMappingCollection); } }
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(2))]
    [System.Data.ResCategoryAttribute("DataCategory_Mapping")]
    [System.Data.ResDescriptionAttribute("DataAdapter_TableMappings")]
    public System.Data.Common.DataTableMappingCollection TableMappings { get { return default(System.Data.Common.DataTableMappingCollection); } }
    [System.Data.ResCategoryAttribute("DataCategory_Fill")]
    [System.Data.ResDescriptionAttribute("DataAdapter_FillError")]
    public event System.Data.FillErrorEventHandler FillError { add { } remove { } }
    [System.ObsoleteAttribute("CloneInternals() has been deprecated.  Use the DataAdapter(DataAdapter from) constructor.  http://go.microsoft.com/fwlink/?linkid=14202")]
    [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.Demand, Name="FullTrust")]
    protected virtual System.Data.Common.DataAdapter CloneInternals() { return default(System.Data.Common.DataAdapter); }
    protected virtual System.Data.Common.DataTableMappingCollection CreateTableMappings() { return default(System.Data.Common.DataTableMappingCollection); }
    protected override void Dispose(bool disposing) { }
    public virtual int Fill(System.Data.DataSet dataSet) { return default(int); }
    protected virtual int Fill(System.Data.DataSet dataSet, string srcTable, System.Data.IDataReader dataReader, int startRecord, int maxRecords) { return default(int); }
    protected virtual int Fill(System.Data.DataTable dataTable, System.Data.IDataReader dataReader) { return default(int); }
    protected virtual int Fill(System.Data.DataTable[] dataTables, System.Data.IDataReader dataReader, int startRecord, int maxRecords) { return default(int); }
    public virtual System.Data.DataTable[] FillSchema(System.Data.DataSet dataSet, System.Data.SchemaType schemaType) { return default(System.Data.DataTable[]); }
    protected virtual System.Data.DataTable[] FillSchema(System.Data.DataSet dataSet, System.Data.SchemaType schemaType, string srcTable, System.Data.IDataReader dataReader) { return default(System.Data.DataTable[]); }
    protected virtual System.Data.DataTable FillSchema(System.Data.DataTable dataTable, System.Data.SchemaType schemaType, System.Data.IDataReader dataReader) { return default(System.Data.DataTable); }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
    public virtual System.Data.IDataParameter[] GetFillParameters() { return default(System.Data.IDataParameter[]); }
    protected bool HasTableMappings() { return default(bool); }
    protected virtual void OnFillError(System.Data.FillErrorEventArgs value) { }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public void ResetFillLoadOption() { }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public virtual bool ShouldSerializeAcceptChangesDuringFill() { return default(bool); }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public virtual bool ShouldSerializeFillLoadOption() { return default(bool); }
    protected virtual bool ShouldSerializeTableMappings() { return default(bool); }
    public virtual int Update(System.Data.DataSet dataSet) { return default(int); }
  }
  [System.ComponentModel.TypeConverterAttribute(typeof(System.Data.Common.DataColumnMapping.DataColumnMappingConverter))]
  public sealed partial class DataColumnMapping : System.MarshalByRefObject, System.Data.IColumnMapping, System.ICloneable {
    public DataColumnMapping() { }
    public DataColumnMapping(string sourceColumn, string dataSetColumn) { }
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.Data.ResCategoryAttribute("DataCategory_Mapping")]
    [System.Data.ResDescriptionAttribute("DataColumnMapping_DataSetColumn")]
    public string DataSetColumn { get { return default(string); } set { } }
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.Data.ResCategoryAttribute("DataCategory_Mapping")]
    [System.Data.ResDescriptionAttribute("DataColumnMapping_SourceColumn")]
    public string SourceColumn { get { return default(string); } set { } }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
    public System.Data.DataColumn GetDataColumnBySchemaAction(System.Data.DataTable dataTable, System.Type dataType, System.Data.MissingSchemaAction schemaAction) { return default(System.Data.DataColumn); }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
    public static System.Data.DataColumn GetDataColumnBySchemaAction(string sourceColumn, string dataSetColumn, System.Data.DataTable dataTable, System.Type dataType, System.Data.MissingSchemaAction schemaAction) { return default(System.Data.DataColumn); }
    object System.ICloneable.Clone() { return default(object); }
    public override string ToString() { return default(string); }
  }
  public sealed partial class DataColumnMappingCollection : System.MarshalByRefObject, System.Collections.ICollection, System.Collections.IEnumerable, System.Collections.IList, System.Data.IColumnMappingCollection {
    public DataColumnMappingCollection() { }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.Data.ResDescriptionAttribute("DataColumnMappings_Count")]
    public int Count { get { return default(int); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.Data.ResDescriptionAttribute("DataColumnMappings_Item")]
    public System.Data.Common.DataColumnMapping this[int index] { get { return default(System.Data.Common.DataColumnMapping); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.Data.ResDescriptionAttribute("DataColumnMappings_Item")]
    public System.Data.Common.DataColumnMapping this[string sourceColumn] { get { return default(System.Data.Common.DataColumnMapping); } set { } }
    bool System.Collections.ICollection.IsSynchronized { get { return default(bool); } }
    object System.Collections.ICollection.SyncRoot { get { return default(object); } }
    bool System.Collections.IList.IsFixedSize { get { return default(bool); } }
    bool System.Collections.IList.IsReadOnly { get { return default(bool); } }
    object System.Collections.IList.this[int index] { get { return default(object); } set { } }
    object System.Data.IColumnMappingCollection.this[string index] { get { return default(object); } set { } }
    public int Add(object value) { return default(int); }
    public System.Data.Common.DataColumnMapping Add(string sourceColumn, string dataSetColumn) { return default(System.Data.Common.DataColumnMapping); }
    public void AddRange(System.Array values) { }
    public void AddRange(System.Data.Common.DataColumnMapping[] values) { }
    public void Clear() { }
    public bool Contains(object value) { return default(bool); }
    public bool Contains(string value) { return default(bool); }
    public void CopyTo(System.Array array, int index) { }
    public void CopyTo(System.Data.Common.DataColumnMapping[] array, int index) { }
    public System.Data.Common.DataColumnMapping GetByDataSetColumn(string value) { return default(System.Data.Common.DataColumnMapping); }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
    public static System.Data.Common.DataColumnMapping GetColumnMappingBySchemaAction(System.Data.Common.DataColumnMappingCollection columnMappings, string sourceColumn, System.Data.MissingMappingAction mappingAction) { return default(System.Data.Common.DataColumnMapping); }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
    public static System.Data.DataColumn GetDataColumn(System.Data.Common.DataColumnMappingCollection columnMappings, string sourceColumn, System.Type dataType, System.Data.DataTable dataTable, System.Data.MissingMappingAction mappingAction, System.Data.MissingSchemaAction schemaAction) { return default(System.Data.DataColumn); }
    public System.Collections.IEnumerator GetEnumerator() { return default(System.Collections.IEnumerator); }
    public int IndexOf(object value) { return default(int); }
    public int IndexOf(string sourceColumn) { return default(int); }
    public int IndexOfDataSetColumn(string dataSetColumn) { return default(int); }
    public void Insert(int index, System.Data.Common.DataColumnMapping value) { }
    public void Insert(int index, object value) { }
    public void Remove(System.Data.Common.DataColumnMapping value) { }
    public void Remove(object value) { }
    public void RemoveAt(int index) { }
    public void RemoveAt(string sourceColumn) { }
    System.Data.IColumnMapping System.Data.IColumnMappingCollection.Add(string sourceColumnName, string dataSetColumnName) { return default(System.Data.IColumnMapping); }
    System.Data.IColumnMapping System.Data.IColumnMappingCollection.GetByDataSetColumn(string dataSetColumnName) { return default(System.Data.IColumnMapping); }
  }
  [System.ComponentModel.TypeConverterAttribute(typeof(System.Data.Common.DataTableMapping.DataTableMappingConverter))]
  public sealed partial class DataTableMapping : System.MarshalByRefObject, System.Data.ITableMapping, System.ICloneable {
    public DataTableMapping() { }
    public DataTableMapping(string sourceTable, string dataSetTable) { }
    public DataTableMapping(string sourceTable, string dataSetTable, System.Data.Common.DataColumnMapping[] columnMappings) { }
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(2))]
    [System.Data.ResCategoryAttribute("DataCategory_Mapping")]
    [System.Data.ResDescriptionAttribute("DataTableMapping_ColumnMappings")]
    public System.Data.Common.DataColumnMappingCollection ColumnMappings { get { return default(System.Data.Common.DataColumnMappingCollection); } }
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.Data.ResCategoryAttribute("DataCategory_Mapping")]
    [System.Data.ResDescriptionAttribute("DataTableMapping_DataSetTable")]
    public string DataSetTable { get { return default(string); } set { } }
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.Data.ResCategoryAttribute("DataCategory_Mapping")]
    [System.Data.ResDescriptionAttribute("DataTableMapping_SourceTable")]
    public string SourceTable { get { return default(string); } set { } }
    System.Data.IColumnMappingCollection System.Data.ITableMapping.ColumnMappings { get { return default(System.Data.IColumnMappingCollection); } }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
    public System.Data.Common.DataColumnMapping GetColumnMappingBySchemaAction(string sourceColumn, System.Data.MissingMappingAction mappingAction) { return default(System.Data.Common.DataColumnMapping); }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
    public System.Data.DataColumn GetDataColumn(string sourceColumn, System.Type dataType, System.Data.DataTable dataTable, System.Data.MissingMappingAction mappingAction, System.Data.MissingSchemaAction schemaAction) { return default(System.Data.DataColumn); }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
    public System.Data.DataTable GetDataTableBySchemaAction(System.Data.DataSet dataSet, System.Data.MissingSchemaAction schemaAction) { return default(System.Data.DataTable); }
    object System.ICloneable.Clone() { return default(object); }
    public override string ToString() { return default(string); }
  }
  [System.ComponentModel.EditorAttribute("Microsoft.VSDesigner.Data.Design.DataTableMappingCollectionEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
  [System.ComponentModel.ListBindableAttribute(false)]
  public sealed partial class DataTableMappingCollection : System.MarshalByRefObject, System.Collections.ICollection, System.Collections.IEnumerable, System.Collections.IList, System.Data.ITableMappingCollection {
    public DataTableMappingCollection() { }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.Data.ResDescriptionAttribute("DataTableMappings_Count")]
    public int Count { get { return default(int); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.Data.ResDescriptionAttribute("DataTableMappings_Item")]
    public System.Data.Common.DataTableMapping this[int index] { get { return default(System.Data.Common.DataTableMapping); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.Data.ResDescriptionAttribute("DataTableMappings_Item")]
    public System.Data.Common.DataTableMapping this[string sourceTable] { get { return default(System.Data.Common.DataTableMapping); } set { } }
    bool System.Collections.ICollection.IsSynchronized { get { return default(bool); } }
    object System.Collections.ICollection.SyncRoot { get { return default(object); } }
    bool System.Collections.IList.IsFixedSize { get { return default(bool); } }
    bool System.Collections.IList.IsReadOnly { get { return default(bool); } }
    object System.Collections.IList.this[int index] { get { return default(object); } set { } }
    object System.Data.ITableMappingCollection.this[string index] { get { return default(object); } set { } }
    public int Add(object value) { return default(int); }
    public System.Data.Common.DataTableMapping Add(string sourceTable, string dataSetTable) { return default(System.Data.Common.DataTableMapping); }
    public void AddRange(System.Array values) { }
    public void AddRange(System.Data.Common.DataTableMapping[] values) { }
    public void Clear() { }
    public bool Contains(object value) { return default(bool); }
    public bool Contains(string value) { return default(bool); }
    public void CopyTo(System.Array array, int index) { }
    public void CopyTo(System.Data.Common.DataTableMapping[] array, int index) { }
    public System.Data.Common.DataTableMapping GetByDataSetTable(string dataSetTable) { return default(System.Data.Common.DataTableMapping); }
    public System.Collections.IEnumerator GetEnumerator() { return default(System.Collections.IEnumerator); }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
    public static System.Data.Common.DataTableMapping GetTableMappingBySchemaAction(System.Data.Common.DataTableMappingCollection tableMappings, string sourceTable, string dataSetTable, System.Data.MissingMappingAction mappingAction) { return default(System.Data.Common.DataTableMapping); }
    public int IndexOf(object value) { return default(int); }
    public int IndexOf(string sourceTable) { return default(int); }
    public int IndexOfDataSetTable(string dataSetTable) { return default(int); }
    public void Insert(int index, System.Data.Common.DataTableMapping value) { }
    public void Insert(int index, object value) { }
    public void Remove(System.Data.Common.DataTableMapping value) { }
    public void Remove(object value) { }
    public void RemoveAt(int index) { }
    public void RemoveAt(string sourceTable) { }
    System.Data.ITableMapping System.Data.ITableMappingCollection.Add(string sourceTableName, string dataSetTableName) { return default(System.Data.ITableMapping); }
    System.Data.ITableMapping System.Data.ITableMappingCollection.GetByDataSetTable(string dataSetTableName) { return default(System.Data.ITableMapping); }
  }
  public abstract partial class DbCommand : System.ComponentModel.Component, System.Data.IDbCommand, System.IDisposable {
    protected DbCommand() { }
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
    [System.Data.ResCategoryAttribute("DataCategory_Data")]
    [System.Data.ResDescriptionAttribute("DbCommand_CommandText")]
    public abstract string CommandText { get; set; }
    [System.Data.ResCategoryAttribute("DataCategory_Data")]
    [System.Data.ResDescriptionAttribute("DbCommand_CommandTimeout")]
    public abstract int CommandTimeout { get; set; }
    [System.ComponentModel.DefaultValueAttribute((System.Data.CommandType)(1))]
    [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
    [System.Data.ResCategoryAttribute("DataCategory_Data")]
    [System.Data.ResDescriptionAttribute("DbCommand_CommandType")]
    public abstract System.Data.CommandType CommandType { get; set; }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute(null)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.Data.ResCategoryAttribute("DataCategory_Data")]
    [System.Data.ResDescriptionAttribute("DbCommand_Connection")]
    public System.Data.Common.DbConnection Connection { get { return default(System.Data.Common.DbConnection); } set { } }
    protected abstract System.Data.Common.DbConnection DbConnection { get; set; }
    protected abstract System.Data.Common.DbParameterCollection DbParameterCollection { get; }
    protected abstract System.Data.Common.DbTransaction DbTransaction { get; set; }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute(true)]
    [System.ComponentModel.DesignOnlyAttribute(true)]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public abstract bool DesignTimeVisible { get; set; }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.Data.ResCategoryAttribute("DataCategory_Data")]
    [System.Data.ResDescriptionAttribute("DbCommand_Parameters")]
    public System.Data.Common.DbParameterCollection Parameters { get { return default(System.Data.Common.DbParameterCollection); } }
    System.Data.IDbConnection System.Data.IDbCommand.Connection { get { return default(System.Data.IDbConnection); } set { } }
    System.Data.IDataParameterCollection System.Data.IDbCommand.Parameters { get { return default(System.Data.IDataParameterCollection); } }
    System.Data.IDbTransaction System.Data.IDbCommand.Transaction { get { return default(System.Data.IDbTransaction); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute(null)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.Data.ResDescriptionAttribute("DbCommand_Transaction")]
    public System.Data.Common.DbTransaction Transaction { get { return default(System.Data.Common.DbTransaction); } set { } }
    [System.ComponentModel.DefaultValueAttribute((System.Data.UpdateRowSource)(3))]
    [System.Data.ResCategoryAttribute("DataCategory_Update")]
    [System.Data.ResDescriptionAttribute("DbCommand_UpdatedRowSource")]
    public abstract System.Data.UpdateRowSource UpdatedRowSource { get; set; }
    public abstract void Cancel();
    protected abstract System.Data.Common.DbParameter CreateDbParameter();
    public System.Data.Common.DbParameter CreateParameter() { return default(System.Data.Common.DbParameter); }
    protected abstract System.Data.Common.DbDataReader ExecuteDbDataReader(System.Data.CommandBehavior behavior);
    protected virtual System.Threading.Tasks.Task<System.Data.Common.DbDataReader> ExecuteDbDataReaderAsync(System.Data.CommandBehavior behavior, System.Threading.CancellationToken cancellationToken) { return default(System.Threading.Tasks.Task<System.Data.Common.DbDataReader>); }
    public abstract int ExecuteNonQuery();
    public System.Threading.Tasks.Task<System.Int32> ExecuteNonQueryAsync() { return default(System.Threading.Tasks.Task<System.Int32>); }
    public virtual System.Threading.Tasks.Task<System.Int32> ExecuteNonQueryAsync(System.Threading.CancellationToken cancellationToken) { return default(System.Threading.Tasks.Task<System.Int32>); }
    public System.Data.Common.DbDataReader ExecuteReader() { return default(System.Data.Common.DbDataReader); }
    public System.Data.Common.DbDataReader ExecuteReader(System.Data.CommandBehavior behavior) { return default(System.Data.Common.DbDataReader); }
    public System.Threading.Tasks.Task<System.Data.Common.DbDataReader> ExecuteReaderAsync() { return default(System.Threading.Tasks.Task<System.Data.Common.DbDataReader>); }
    public System.Threading.Tasks.Task<System.Data.Common.DbDataReader> ExecuteReaderAsync(System.Data.CommandBehavior behavior) { return default(System.Threading.Tasks.Task<System.Data.Common.DbDataReader>); }
    public System.Threading.Tasks.Task<System.Data.Common.DbDataReader> ExecuteReaderAsync(System.Data.CommandBehavior behavior, System.Threading.CancellationToken cancellationToken) { return default(System.Threading.Tasks.Task<System.Data.Common.DbDataReader>); }
    public System.Threading.Tasks.Task<System.Data.Common.DbDataReader> ExecuteReaderAsync(System.Threading.CancellationToken cancellationToken) { return default(System.Threading.Tasks.Task<System.Data.Common.DbDataReader>); }
    public abstract object ExecuteScalar();
    public System.Threading.Tasks.Task<System.Object> ExecuteScalarAsync() { return default(System.Threading.Tasks.Task<System.Object>); }
    public virtual System.Threading.Tasks.Task<System.Object> ExecuteScalarAsync(System.Threading.CancellationToken cancellationToken) { return default(System.Threading.Tasks.Task<System.Object>); }
    public abstract void Prepare();
    System.Data.IDbDataParameter System.Data.IDbCommand.CreateParameter() { return default(System.Data.IDbDataParameter); }
    System.Data.IDataReader System.Data.IDbCommand.ExecuteReader() { return default(System.Data.IDataReader); }
    System.Data.IDataReader System.Data.IDbCommand.ExecuteReader(System.Data.CommandBehavior behavior) { return default(System.Data.IDataReader); }
  }
  public abstract partial class DbCommandBuilder : System.ComponentModel.Component {
    protected DbCommandBuilder() { }
    [System.ComponentModel.DefaultValueAttribute((System.Data.Common.CatalogLocation)(1))]
    [System.Data.ResCategoryAttribute("DataCategory_Schema")]
    [System.Data.ResDescriptionAttribute("DbCommandBuilder_CatalogLocation")]
    public virtual System.Data.Common.CatalogLocation CatalogLocation { get { return default(System.Data.Common.CatalogLocation); } set { } }
    [System.ComponentModel.DefaultValueAttribute(".")]
    [System.Data.ResCategoryAttribute("DataCategory_Schema")]
    [System.Data.ResDescriptionAttribute("DbCommandBuilder_CatalogSeparator")]
    public virtual string CatalogSeparator { get { return default(string); } set { } }
    [System.ComponentModel.DefaultValueAttribute((System.Data.ConflictOption)(1))]
    [System.Data.ResCategoryAttribute("DataCategory_Update")]
    [System.Data.ResDescriptionAttribute("DbCommandBuilder_ConflictOption")]
    public virtual System.Data.ConflictOption ConflictOption { get { return default(System.Data.ConflictOption); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.Data.ResDescriptionAttribute("DbCommandBuilder_DataAdapter")]
    public System.Data.Common.DbDataAdapter DataAdapter { get { return default(System.Data.Common.DbDataAdapter); } set { } }
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.Data.ResCategoryAttribute("DataCategory_Schema")]
    [System.Data.ResDescriptionAttribute("DbCommandBuilder_QuotePrefix")]
    public virtual string QuotePrefix { get { return default(string); } set { } }
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.Data.ResCategoryAttribute("DataCategory_Schema")]
    [System.Data.ResDescriptionAttribute("DbCommandBuilder_QuoteSuffix")]
    public virtual string QuoteSuffix { get { return default(string); } set { } }
    [System.ComponentModel.DefaultValueAttribute(".")]
    [System.Data.ResCategoryAttribute("DataCategory_Schema")]
    [System.Data.ResDescriptionAttribute("DbCommandBuilder_SchemaSeparator")]
    public virtual string SchemaSeparator { get { return default(string); } set { } }
    [System.ComponentModel.DefaultValueAttribute(false)]
    [System.Data.ResCategoryAttribute("DataCategory_Schema")]
    [System.Data.ResDescriptionAttribute("DbCommandBuilder_SetAllValues")]
    public bool SetAllValues { get { return default(bool); } set { } }
    protected abstract void ApplyParameterInfo(System.Data.Common.DbParameter parameter, System.Data.DataRow row, System.Data.StatementType statementType, bool whereClause);
    protected override void Dispose(bool disposing) { }
    public System.Data.Common.DbCommand GetDeleteCommand() { return default(System.Data.Common.DbCommand); }
    public System.Data.Common.DbCommand GetDeleteCommand(bool useColumnsForParameterNames) { return default(System.Data.Common.DbCommand); }
    public System.Data.Common.DbCommand GetInsertCommand() { return default(System.Data.Common.DbCommand); }
    public System.Data.Common.DbCommand GetInsertCommand(bool useColumnsForParameterNames) { return default(System.Data.Common.DbCommand); }
    protected abstract string GetParameterName(int parameterOrdinal);
    protected abstract string GetParameterName(string parameterName);
    protected abstract string GetParameterPlaceholder(int parameterOrdinal);
    protected virtual System.Data.DataTable GetSchemaTable(System.Data.Common.DbCommand sourceCommand) { return default(System.Data.DataTable); }
    public System.Data.Common.DbCommand GetUpdateCommand() { return default(System.Data.Common.DbCommand); }
    public System.Data.Common.DbCommand GetUpdateCommand(bool useColumnsForParameterNames) { return default(System.Data.Common.DbCommand); }
    protected virtual System.Data.Common.DbCommand InitializeCommand(System.Data.Common.DbCommand command) { return default(System.Data.Common.DbCommand); }
    public virtual string QuoteIdentifier(string unquotedIdentifier) { return default(string); }
    public virtual void RefreshSchema() { }
    protected void RowUpdatingHandler(System.Data.Common.RowUpdatingEventArgs rowUpdatingEvent) { }
    protected abstract void SetRowUpdatingHandler(System.Data.Common.DbDataAdapter adapter);
    public virtual string UnquoteIdentifier(string quotedIdentifier) { return default(string); }
  }
  public abstract partial class DbConnection : System.ComponentModel.Component, System.Data.IDbConnection, System.IDisposable {
    protected DbConnection() { }
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.ComponentModel.RecommendedAsConfigurableAttribute(true)]
    [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
    [System.ComponentModel.SettingsBindableAttribute(true)]
    [System.Data.ResCategoryAttribute("DataCategory_Data")]
    public abstract string ConnectionString { get; set; }
    [System.Data.ResCategoryAttribute("DataCategory_Data")]
    public virtual int ConnectionTimeout { get { return default(int); } }
    [System.Data.ResCategoryAttribute("DataCategory_Data")]
    public abstract string Database { get; }
    [System.Data.ResCategoryAttribute("DataCategory_Data")]
    public abstract string DataSource { get; }
    protected virtual System.Data.Common.DbProviderFactory DbProviderFactory { get { return default(System.Data.Common.DbProviderFactory); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    public abstract string ServerVersion { get; }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.Data.ResDescriptionAttribute("DbConnection_State")]
    public abstract System.Data.ConnectionState State { get; }
    [System.Data.ResCategoryAttribute("DataCategory_StateChange")]
    [System.Data.ResDescriptionAttribute("DbConnection_StateChange")]
    public virtual event System.Data.StateChangeEventHandler StateChange { add { } remove { } }
    protected abstract System.Data.Common.DbTransaction BeginDbTransaction(System.Data.IsolationLevel isolationLevel);
    public System.Data.Common.DbTransaction BeginTransaction() { return default(System.Data.Common.DbTransaction); }
    public System.Data.Common.DbTransaction BeginTransaction(System.Data.IsolationLevel isolationLevel) { return default(System.Data.Common.DbTransaction); }
    public abstract void ChangeDatabase(string databaseName);
    public abstract void Close();
    public System.Data.Common.DbCommand CreateCommand() { return default(System.Data.Common.DbCommand); }
    protected abstract System.Data.Common.DbCommand CreateDbCommand();
    public virtual void EnlistTransaction(System.Transactions.Transaction transaction) { }
    public virtual System.Data.DataTable GetSchema() { return default(System.Data.DataTable); }
    public virtual System.Data.DataTable GetSchema(string collectionName) { return default(System.Data.DataTable); }
    public virtual System.Data.DataTable GetSchema(string collectionName, System.String[] restrictionValues) { return default(System.Data.DataTable); }
    protected virtual void OnStateChange(System.Data.StateChangeEventArgs stateChange) { }
    public abstract void Open();
    public System.Threading.Tasks.Task OpenAsync() { return default(System.Threading.Tasks.Task); }
    public virtual System.Threading.Tasks.Task OpenAsync(System.Threading.CancellationToken cancellationToken) { return default(System.Threading.Tasks.Task); }
    System.Data.IDbTransaction System.Data.IDbConnection.BeginTransaction() { return default(System.Data.IDbTransaction); }
    System.Data.IDbTransaction System.Data.IDbConnection.BeginTransaction(System.Data.IsolationLevel isolationLevel) { return default(System.Data.IDbTransaction); }
    System.Data.IDbCommand System.Data.IDbConnection.CreateCommand() { return default(System.Data.IDbCommand); }
  }
  public partial class DbConnectionStringBuilder : System.Collections.ICollection, System.Collections.IDictionary, System.Collections.IEnumerable, System.ComponentModel.ICustomTypeDescriptor {
    public DbConnectionStringBuilder() { }
    public DbConnectionStringBuilder(bool useOdbcRules) { }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.ComponentModel.DesignOnlyAttribute(true)]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public bool BrowsableConnectionString { get { return default(bool); } set { } }
    [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
    [System.Data.ResCategoryAttribute("DataCategory_Data")]
    [System.Data.ResDescriptionAttribute("DbConnectionString_ConnectionString")]
    public string ConnectionString { get { return default(string); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    public virtual int Count { get { return default(int); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    public virtual bool IsFixedSize { get { return default(bool); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    public bool IsReadOnly { get { return default(bool); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    public virtual object this[string keyword] { get { return default(object); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    public virtual System.Collections.ICollection Keys { get { return default(System.Collections.ICollection); } }
    bool System.Collections.ICollection.IsSynchronized { get { return default(bool); } }
    object System.Collections.ICollection.SyncRoot { get { return default(object); } }
    object System.Collections.IDictionary.this[object keyword] { get { return default(object); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    public virtual System.Collections.ICollection Values { get { return default(System.Collections.ICollection); } }
    public void Add(string keyword, object value) { }
    public static void AppendKeyValuePair(System.Text.StringBuilder builder, string keyword, string value) { }
    public static void AppendKeyValuePair(System.Text.StringBuilder builder, string keyword, string value, bool useOdbcRules) { }
    public virtual void Clear() { }
    protected internal void ClearPropertyDescriptors() { }
    public virtual bool ContainsKey(string keyword) { return default(bool); }
    public virtual bool EquivalentTo(System.Data.Common.DbConnectionStringBuilder connectionStringBuilder) { return default(bool); }
    protected virtual void GetProperties(System.Collections.Hashtable propertyDescriptors) { }
    public virtual bool Remove(string keyword) { return default(bool); }
    public virtual bool ShouldSerialize(string keyword) { return default(bool); }
    void System.Collections.ICollection.CopyTo(System.Array array, int index) { }
    void System.Collections.IDictionary.Add(object keyword, object value) { }
    bool System.Collections.IDictionary.Contains(object keyword) { return default(bool); }
    System.Collections.IDictionaryEnumerator System.Collections.IDictionary.GetEnumerator() { return default(System.Collections.IDictionaryEnumerator); }
    void System.Collections.IDictionary.Remove(object keyword) { }
    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { return default(System.Collections.IEnumerator); }
    System.ComponentModel.AttributeCollection System.ComponentModel.ICustomTypeDescriptor.GetAttributes() { return default(System.ComponentModel.AttributeCollection); }
    string System.ComponentModel.ICustomTypeDescriptor.GetClassName() { return default(string); }
    string System.ComponentModel.ICustomTypeDescriptor.GetComponentName() { return default(string); }
    System.ComponentModel.TypeConverter System.ComponentModel.ICustomTypeDescriptor.GetConverter() { return default(System.ComponentModel.TypeConverter); }
    System.ComponentModel.EventDescriptor System.ComponentModel.ICustomTypeDescriptor.GetDefaultEvent() { return default(System.ComponentModel.EventDescriptor); }
    System.ComponentModel.PropertyDescriptor System.ComponentModel.ICustomTypeDescriptor.GetDefaultProperty() { return default(System.ComponentModel.PropertyDescriptor); }
    object System.ComponentModel.ICustomTypeDescriptor.GetEditor(System.Type editorBaseType) { return default(object); }
    System.ComponentModel.EventDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetEvents() { return default(System.ComponentModel.EventDescriptorCollection); }
    System.ComponentModel.EventDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetEvents(System.Attribute[] attributes) { return default(System.ComponentModel.EventDescriptorCollection); }
    System.ComponentModel.PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties() { return default(System.ComponentModel.PropertyDescriptorCollection); }
    System.ComponentModel.PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties(System.Attribute[] attributes) { return default(System.ComponentModel.PropertyDescriptorCollection); }
    object System.ComponentModel.ICustomTypeDescriptor.GetPropertyOwner(System.ComponentModel.PropertyDescriptor pd) { return default(object); }
    public override string ToString() { return default(string); }
    public virtual bool TryGetValue(string keyword, out object value) { value = default(object); return default(bool); }
  }
  public abstract partial class DbDataAdapter : System.Data.Common.DataAdapter, System.Data.IDataAdapter, System.Data.IDbDataAdapter, System.ICloneable {
    public const string DefaultSourceTableName = "Table";
    protected DbDataAdapter() { }
    protected DbDataAdapter(System.Data.Common.DbDataAdapter adapter) { }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    public System.Data.Common.DbCommand DeleteCommand { get { return default(System.Data.Common.DbCommand); } set { } }
    protected internal System.Data.CommandBehavior FillCommandBehavior { get { return default(System.Data.CommandBehavior); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    public System.Data.Common.DbCommand InsertCommand { get { return default(System.Data.Common.DbCommand); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    public System.Data.Common.DbCommand SelectCommand { get { return default(System.Data.Common.DbCommand); } set { } }
    System.Data.IDbCommand System.Data.IDbDataAdapter.DeleteCommand { get { return default(System.Data.IDbCommand); } set { } }
    System.Data.IDbCommand System.Data.IDbDataAdapter.InsertCommand { get { return default(System.Data.IDbCommand); } set { } }
    System.Data.IDbCommand System.Data.IDbDataAdapter.SelectCommand { get { return default(System.Data.IDbCommand); } set { } }
    System.Data.IDbCommand System.Data.IDbDataAdapter.UpdateCommand { get { return default(System.Data.IDbCommand); } set { } }
    [System.ComponentModel.DefaultValueAttribute(1)]
    [System.Data.ResCategoryAttribute("DataCategory_Update")]
    [System.Data.ResDescriptionAttribute("DbDataAdapter_UpdateBatchSize")]
    public virtual int UpdateBatchSize { get { return default(int); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    public System.Data.Common.DbCommand UpdateCommand { get { return default(System.Data.Common.DbCommand); } set { } }
    protected virtual int AddToBatch(System.Data.IDbCommand command) { return default(int); }
    protected virtual void ClearBatch() { }
    protected virtual System.Data.Common.RowUpdatedEventArgs CreateRowUpdatedEvent(System.Data.DataRow dataRow, System.Data.IDbCommand command, System.Data.StatementType statementType, System.Data.Common.DataTableMapping tableMapping) { return default(System.Data.Common.RowUpdatedEventArgs); }
    protected virtual System.Data.Common.RowUpdatingEventArgs CreateRowUpdatingEvent(System.Data.DataRow dataRow, System.Data.IDbCommand command, System.Data.StatementType statementType, System.Data.Common.DataTableMapping tableMapping) { return default(System.Data.Common.RowUpdatingEventArgs); }
    protected override void Dispose(bool disposing) { }
    protected virtual int ExecuteBatch() { return default(int); }
    public override int Fill(System.Data.DataSet dataSet) { return default(int); }
    public int Fill(System.Data.DataSet dataSet, int startRecord, int maxRecords, string srcTable) { return default(int); }
    protected virtual int Fill(System.Data.DataSet dataSet, int startRecord, int maxRecords, string srcTable, System.Data.IDbCommand command, System.Data.CommandBehavior behavior) { return default(int); }
    public int Fill(System.Data.DataSet dataSet, string srcTable) { return default(int); }
    public int Fill(System.Data.DataTable dataTable) { return default(int); }
    protected virtual int Fill(System.Data.DataTable dataTable, System.Data.IDbCommand command, System.Data.CommandBehavior behavior) { return default(int); }
    protected virtual int Fill(System.Data.DataTable[] dataTables, int startRecord, int maxRecords, System.Data.IDbCommand command, System.Data.CommandBehavior behavior) { return default(int); }
    public int Fill(int startRecord, int maxRecords, params System.Data.DataTable[] dataTables) { return default(int); }
    public override System.Data.DataTable[] FillSchema(System.Data.DataSet dataSet, System.Data.SchemaType schemaType) { return default(System.Data.DataTable[]); }
    protected virtual System.Data.DataTable[] FillSchema(System.Data.DataSet dataSet, System.Data.SchemaType schemaType, System.Data.IDbCommand command, string srcTable, System.Data.CommandBehavior behavior) { return default(System.Data.DataTable[]); }
    public System.Data.DataTable[] FillSchema(System.Data.DataSet dataSet, System.Data.SchemaType schemaType, string srcTable) { return default(System.Data.DataTable[]); }
    public System.Data.DataTable FillSchema(System.Data.DataTable dataTable, System.Data.SchemaType schemaType) { return default(System.Data.DataTable); }
    protected virtual System.Data.DataTable FillSchema(System.Data.DataTable dataTable, System.Data.SchemaType schemaType, System.Data.IDbCommand command, System.Data.CommandBehavior behavior) { return default(System.Data.DataTable); }
    protected virtual System.Data.IDataParameter GetBatchedParameter(int commandIdentifier, int parameterIndex) { return default(System.Data.IDataParameter); }
    protected virtual bool GetBatchedRecordsAffected(int commandIdentifier, out int recordsAffected, out System.Exception error) { recordsAffected = default(int); error = default(System.Exception); return default(bool); }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
    public override System.Data.IDataParameter[] GetFillParameters() { return default(System.Data.IDataParameter[]); }
    protected virtual void InitializeBatching() { }
    protected virtual void OnRowUpdated(System.Data.Common.RowUpdatedEventArgs value) { }
    protected virtual void OnRowUpdating(System.Data.Common.RowUpdatingEventArgs value) { }
    object System.ICloneable.Clone() { return default(object); }
    protected virtual void TerminateBatching() { }
    public int Update(System.Data.DataRow[] dataRows) { return default(int); }
    protected virtual int Update(System.Data.DataRow[] dataRows, System.Data.Common.DataTableMapping tableMapping) { return default(int); }
    public override int Update(System.Data.DataSet dataSet) { return default(int); }
    public int Update(System.Data.DataSet dataSet, string srcTable) { return default(int); }
    public int Update(System.Data.DataTable dataTable) { return default(int); }
  }
  [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, ControlEvidence=true, ControlPolicy=true)]
  public abstract partial class DBDataPermission : System.Security.CodeAccessPermission, System.Security.Permissions.IUnrestrictedPermission {
    [System.ObsoleteAttribute("DBDataPermission() has been deprecated.  Use the DBDataPermission(PermissionState.None) constructor.  http://go.microsoft.com/fwlink/?linkid=14202", true)]
    protected DBDataPermission() { }
    protected DBDataPermission(System.Data.Common.DBDataPermission permission) { }
    protected DBDataPermission(System.Data.Common.DBDataPermissionAttribute permissionAttribute) { }
    protected DBDataPermission(System.Security.Permissions.PermissionState state) { }
    [System.ObsoleteAttribute("DBDataPermission(PermissionState state,Boolean allowBlankPassword) has been deprecated.  Use the DBDataPermission(PermissionState.None) constructor.  http://go.microsoft.com/fwlink/?linkid=14202", true)]
    protected DBDataPermission(System.Security.Permissions.PermissionState state, bool allowBlankPassword) { }
    public bool AllowBlankPassword { get { return default(bool); } set { } }
    public virtual void Add(string connectionString, string restrictions, System.Data.KeyRestrictionBehavior behavior) { }
    protected void Clear() { }
    public override System.Security.IPermission Copy() { return default(System.Security.IPermission); }
    [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.Demand, Name="FullTrust")]
    protected virtual System.Data.Common.DBDataPermission CreateInstance() { return default(System.Data.Common.DBDataPermission); }
    public override void FromXml(System.Security.SecurityElement securityElement) { }
    public override System.Security.IPermission Intersect(System.Security.IPermission target) { return default(System.Security.IPermission); }
    public override bool IsSubsetOf(System.Security.IPermission target) { return default(bool); }
    public bool IsUnrestricted() { return default(bool); }
    public override System.Security.SecurityElement ToXml() { return default(System.Security.SecurityElement); }
    public override System.Security.IPermission Union(System.Security.IPermission target) { return default(System.Security.IPermission); }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(109), AllowMultiple=true, Inherited=false)]
  public abstract partial class DBDataPermissionAttribute : System.Security.Permissions.CodeAccessSecurityAttribute {
    protected DBDataPermissionAttribute(System.Security.Permissions.SecurityAction action) : base (default(System.Security.Permissions.SecurityAction)) { }
    public bool AllowBlankPassword { get { return default(bool); } set { } }
    public string ConnectionString { get { return default(string); } set { } }
    public System.Data.KeyRestrictionBehavior KeyRestrictionBehavior { get { return default(System.Data.KeyRestrictionBehavior); } set { } }
    public string KeyRestrictions { get { return default(string); } set { } }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public bool ShouldSerializeConnectionString() { return default(bool); }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public bool ShouldSerializeKeyRestrictions() { return default(bool); }
  }
  public abstract partial class DbDataReader : System.MarshalByRefObject, System.Collections.IEnumerable, System.Data.IDataReader, System.Data.IDataRecord, System.IDisposable {
    protected DbDataReader() { }
    public abstract int Depth { get; }
    public abstract int FieldCount { get; }
    public abstract bool HasRows { get; }
    public abstract bool IsClosed { get; }
    public abstract object this[int ordinal] { get; }
    public abstract object this[string name] { get; }
    public abstract int RecordsAffected { get; }
    public virtual int VisibleFieldCount { get { return default(int); } }
    public virtual void Close() { }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public void Dispose() { }
    protected virtual void Dispose(bool disposing) { }
    public abstract bool GetBoolean(int ordinal);
    public abstract byte GetByte(int ordinal);
    public abstract long GetBytes(int ordinal, long dataOffset, System.Byte[] buffer, int bufferOffset, int length);
    public abstract char GetChar(int ordinal);
    public abstract long GetChars(int ordinal, long dataOffset, System.Char[] buffer, int bufferOffset, int length);
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public System.Data.Common.DbDataReader GetData(int ordinal) { return default(System.Data.Common.DbDataReader); }
    public abstract string GetDataTypeName(int ordinal);
    public abstract System.DateTime GetDateTime(int ordinal);
    protected virtual System.Data.Common.DbDataReader GetDbDataReader(int ordinal) { return default(System.Data.Common.DbDataReader); }
    public abstract decimal GetDecimal(int ordinal);
    public abstract double GetDouble(int ordinal);
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public abstract System.Collections.IEnumerator GetEnumerator();
    public abstract System.Type GetFieldType(int ordinal);
    public virtual T GetFieldValue<T>(int ordinal) { return default(T); }
    public System.Threading.Tasks.Task<T> GetFieldValueAsync<T>(int ordinal) { return default(System.Threading.Tasks.Task<T>); }
    public virtual System.Threading.Tasks.Task<T> GetFieldValueAsync<T>(int ordinal, System.Threading.CancellationToken cancellationToken) { return default(System.Threading.Tasks.Task<T>); }
    public abstract float GetFloat(int ordinal);
    public abstract System.Guid GetGuid(int ordinal);
    public abstract short GetInt16(int ordinal);
    public abstract int GetInt32(int ordinal);
    public abstract long GetInt64(int ordinal);
    public abstract string GetName(int ordinal);
    public abstract int GetOrdinal(string name);
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public virtual System.Type GetProviderSpecificFieldType(int ordinal) { return default(System.Type); }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public virtual object GetProviderSpecificValue(int ordinal) { return default(object); }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public virtual int GetProviderSpecificValues(System.Object[] values) { return default(int); }
    public virtual System.Data.DataTable GetSchemaTable() { return default(System.Data.DataTable); }
    public virtual System.IO.Stream GetStream(int ordinal) { return default(System.IO.Stream); }
    public abstract string GetString(int ordinal);
    public virtual System.IO.TextReader GetTextReader(int ordinal) { return default(System.IO.TextReader); }
    public abstract object GetValue(int ordinal);
    public abstract int GetValues(System.Object[] values);
    public abstract bool IsDBNull(int ordinal);
    public System.Threading.Tasks.Task<System.Boolean> IsDBNullAsync(int ordinal) { return default(System.Threading.Tasks.Task<System.Boolean>); }
    public virtual System.Threading.Tasks.Task<System.Boolean> IsDBNullAsync(int ordinal, System.Threading.CancellationToken cancellationToken) { return default(System.Threading.Tasks.Task<System.Boolean>); }
    public abstract bool NextResult();
    public System.Threading.Tasks.Task<System.Boolean> NextResultAsync() { return default(System.Threading.Tasks.Task<System.Boolean>); }
    public virtual System.Threading.Tasks.Task<System.Boolean> NextResultAsync(System.Threading.CancellationToken cancellationToken) { return default(System.Threading.Tasks.Task<System.Boolean>); }
    public abstract bool Read();
    public System.Threading.Tasks.Task<System.Boolean> ReadAsync() { return default(System.Threading.Tasks.Task<System.Boolean>); }
    public virtual System.Threading.Tasks.Task<System.Boolean> ReadAsync(System.Threading.CancellationToken cancellationToken) { return default(System.Threading.Tasks.Task<System.Boolean>); }
    System.Data.IDataReader System.Data.IDataRecord.GetData(int ordinal) { return default(System.Data.IDataReader); }
  }
  public abstract partial class DbDataRecord : System.ComponentModel.ICustomTypeDescriptor, System.Data.IDataRecord {
    protected DbDataRecord() { }
    public abstract int FieldCount { get; }
    public abstract object this[int i] { get; }
    public abstract object this[string name] { get; }
    public abstract bool GetBoolean(int i);
    public abstract byte GetByte(int i);
    public abstract long GetBytes(int i, long dataIndex, System.Byte[] buffer, int bufferIndex, int length);
    public abstract char GetChar(int i);
    public abstract long GetChars(int i, long dataIndex, System.Char[] buffer, int bufferIndex, int length);
    public System.Data.IDataReader GetData(int i) { return default(System.Data.IDataReader); }
    public abstract string GetDataTypeName(int i);
    public abstract System.DateTime GetDateTime(int i);
    protected virtual System.Data.Common.DbDataReader GetDbDataReader(int i) { return default(System.Data.Common.DbDataReader); }
    public abstract decimal GetDecimal(int i);
    public abstract double GetDouble(int i);
    public abstract System.Type GetFieldType(int i);
    public abstract float GetFloat(int i);
    public abstract System.Guid GetGuid(int i);
    public abstract short GetInt16(int i);
    public abstract int GetInt32(int i);
    public abstract long GetInt64(int i);
    public abstract string GetName(int i);
    public abstract int GetOrdinal(string name);
    public abstract string GetString(int i);
    public abstract object GetValue(int i);
    public abstract int GetValues(System.Object[] values);
    public abstract bool IsDBNull(int i);
    System.ComponentModel.AttributeCollection System.ComponentModel.ICustomTypeDescriptor.GetAttributes() { return default(System.ComponentModel.AttributeCollection); }
    string System.ComponentModel.ICustomTypeDescriptor.GetClassName() { return default(string); }
    string System.ComponentModel.ICustomTypeDescriptor.GetComponentName() { return default(string); }
    System.ComponentModel.TypeConverter System.ComponentModel.ICustomTypeDescriptor.GetConverter() { return default(System.ComponentModel.TypeConverter); }
    System.ComponentModel.EventDescriptor System.ComponentModel.ICustomTypeDescriptor.GetDefaultEvent() { return default(System.ComponentModel.EventDescriptor); }
    System.ComponentModel.PropertyDescriptor System.ComponentModel.ICustomTypeDescriptor.GetDefaultProperty() { return default(System.ComponentModel.PropertyDescriptor); }
    object System.ComponentModel.ICustomTypeDescriptor.GetEditor(System.Type editorBaseType) { return default(object); }
    System.ComponentModel.EventDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetEvents() { return default(System.ComponentModel.EventDescriptorCollection); }
    System.ComponentModel.EventDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetEvents(System.Attribute[] attributes) { return default(System.ComponentModel.EventDescriptorCollection); }
    System.ComponentModel.PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties() { return default(System.ComponentModel.PropertyDescriptorCollection); }
    System.ComponentModel.PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties(System.Attribute[] attributes) { return default(System.ComponentModel.PropertyDescriptorCollection); }
    object System.ComponentModel.ICustomTypeDescriptor.GetPropertyOwner(System.ComponentModel.PropertyDescriptor pd) { return default(object); }
  }
  public abstract partial class DbDataSourceEnumerator {
    protected DbDataSourceEnumerator() { }
    public abstract System.Data.DataTable GetDataSources();
  }
  public partial class DbEnumerator : System.Collections.IEnumerator {
    public DbEnumerator(System.Data.Common.DbDataReader reader) { }
    public DbEnumerator(System.Data.Common.DbDataReader reader, bool closeReader) { }
    public DbEnumerator(System.Data.IDataReader reader) { }
    public DbEnumerator(System.Data.IDataReader reader, bool closeReader) { }
    public object Current { get { return default(object); } }
    public bool MoveNext() { return default(bool); }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public void Reset() { }
  }
  public abstract partial class DbException : System.Runtime.InteropServices.ExternalException {
    protected DbException() { }
    protected DbException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    protected DbException(string message) { }
    protected DbException(string message, System.Exception innerException) { }
    protected DbException(string message, int errorCode) { }
  }
  public static partial class DbMetaDataCollectionNames {
    public static readonly string DataSourceInformation;
    public static readonly string DataTypes;
    public static readonly string MetaDataCollections;
    public static readonly string ReservedWords;
    public static readonly string Restrictions;
  }
  public static partial class DbMetaDataColumnNames {
    public static readonly string CollectionName;
    public static readonly string ColumnSize;
    public static readonly string CompositeIdentifierSeparatorPattern;
    public static readonly string CreateFormat;
    public static readonly string CreateParameters;
    public static readonly string DataSourceProductName;
    public static readonly string DataSourceProductVersion;
    public static readonly string DataSourceProductVersionNormalized;
    public static readonly string DataType;
    public static readonly string GroupByBehavior;
    public static readonly string IdentifierCase;
    public static readonly string IdentifierPattern;
    public static readonly string IsAutoIncrementable;
    public static readonly string IsBestMatch;
    public static readonly string IsCaseSensitive;
    public static readonly string IsConcurrencyType;
    public static readonly string IsFixedLength;
    public static readonly string IsFixedPrecisionScale;
    public static readonly string IsLiteralSupported;
    public static readonly string IsLong;
    public static readonly string IsNullable;
    public static readonly string IsSearchable;
    public static readonly string IsSearchableWithLike;
    public static readonly string IsUnsigned;
    public static readonly string LiteralPrefix;
    public static readonly string LiteralSuffix;
    public static readonly string MaximumScale;
    public static readonly string MinimumScale;
    public static readonly string NumberOfIdentifierParts;
    public static readonly string NumberOfRestrictions;
    public static readonly string OrderByColumnsInSelect;
    public static readonly string ParameterMarkerFormat;
    public static readonly string ParameterMarkerPattern;
    public static readonly string ParameterNameMaxLength;
    public static readonly string ParameterNamePattern;
    public static readonly string ProviderDbType;
    public static readonly string QuotedIdentifierCase;
    public static readonly string QuotedIdentifierPattern;
    public static readonly string ReservedWord;
    public static readonly string StatementSeparatorPattern;
    public static readonly string StringLiteralPattern;
    public static readonly string SupportedJoinOperators;
    public static readonly string TypeName;
  }
  public abstract partial class DbParameter : System.MarshalByRefObject, System.Data.IDataParameter, System.Data.IDbDataParameter {
    protected DbParameter() { }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
    [System.Data.ResCategoryAttribute("DataCategory_Data")]
    [System.Data.ResDescriptionAttribute("DbParameter_DbType")]
    public abstract System.Data.DbType DbType { get; set; }
    [System.ComponentModel.DefaultValueAttribute((System.Data.ParameterDirection)(1))]
    [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
    [System.Data.ResCategoryAttribute("DataCategory_Data")]
    [System.Data.ResDescriptionAttribute("DbParameter_Direction")]
    public abstract System.Data.ParameterDirection Direction { get; set; }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignOnlyAttribute(true)]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public abstract bool IsNullable { get; set; }
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.Data.ResCategoryAttribute("DataCategory_Data")]
    [System.Data.ResDescriptionAttribute("DbParameter_ParameterName")]
    public abstract string ParameterName { get; set; }
    public virtual byte Precision { get { return default(byte); } set { } }
    public virtual byte Scale { get { return default(byte); } set { } }
    [System.Data.ResCategoryAttribute("DataCategory_Data")]
    [System.Data.ResDescriptionAttribute("DbParameter_Size")]
    public abstract int Size { get; set; }
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.Data.ResCategoryAttribute("DataCategory_Update")]
    [System.Data.ResDescriptionAttribute("DbParameter_SourceColumn")]
    public abstract string SourceColumn { get; set; }
    [System.ComponentModel.DefaultValueAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
    [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
    [System.Data.ResCategoryAttribute("DataCategory_Update")]
    [System.Data.ResDescriptionAttribute("DbParameter_SourceColumnNullMapping")]
    public abstract bool SourceColumnNullMapping { get; set; }
    [System.ComponentModel.DefaultValueAttribute((System.Data.DataRowVersion)(512))]
    [System.Data.ResCategoryAttribute("DataCategory_Update")]
    [System.Data.ResDescriptionAttribute("DbParameter_SourceVersion")]
    public virtual System.Data.DataRowVersion SourceVersion { get { return default(System.Data.DataRowVersion); } set { } }
    byte System.Data.IDbDataParameter.Precision { get { return default(byte); } set { } }
    byte System.Data.IDbDataParameter.Scale { get { return default(byte); } set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
    [System.Data.ResCategoryAttribute("DataCategory_Data")]
    [System.Data.ResDescriptionAttribute("DbParameter_Value")]
    public abstract object Value { get; set; }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
    public abstract void ResetDbType();
  }
  public abstract partial class DbParameterCollection : System.MarshalByRefObject, System.Collections.ICollection, System.Collections.IEnumerable, System.Collections.IList, System.Data.IDataParameterCollection {
    protected DbParameterCollection() { }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    public abstract int Count { get; }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public virtual bool IsFixedSize { get { return default(bool); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public virtual bool IsReadOnly { get { return default(bool); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public virtual bool IsSynchronized { get { return default(bool); } }
    public System.Data.Common.DbParameter this[int index] { get { return default(System.Data.Common.DbParameter); } set { } }
    public System.Data.Common.DbParameter this[string parameterName] { get { return default(System.Data.Common.DbParameter); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public abstract object SyncRoot { get; }
    object System.Collections.IList.this[int index] { get { return default(object); } set { } }
    object System.Data.IDataParameterCollection.this[string parameterName] { get { return default(object); } set { } }
    public abstract int Add(object value);
    public abstract void AddRange(System.Array values);
    public abstract void Clear();
    public abstract bool Contains(object value);
    public abstract bool Contains(string value);
    public abstract void CopyTo(System.Array array, int index);
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public abstract System.Collections.IEnumerator GetEnumerator();
    protected abstract System.Data.Common.DbParameter GetParameter(int index);
    protected abstract System.Data.Common.DbParameter GetParameter(string parameterName);
    public abstract int IndexOf(object value);
    public abstract int IndexOf(string parameterName);
    public abstract void Insert(int index, object value);
    public abstract void Remove(object value);
    public abstract void RemoveAt(int index);
    public abstract void RemoveAt(string parameterName);
    protected abstract void SetParameter(int index, System.Data.Common.DbParameter value);
    protected abstract void SetParameter(string parameterName, System.Data.Common.DbParameter value);
  }
  public partial class DbProviderConfigurationHandler : System.Configuration.IConfigurationSectionHandler {
    public DbProviderConfigurationHandler() { }
    public virtual object Create(object parent, object configContext, System.Xml.XmlNode section) { return default(object); }
  }
  public static partial class DbProviderFactories {
    public static System.Data.Common.DbProviderFactory GetFactory(System.Data.Common.DbConnection connection) { return default(System.Data.Common.DbProviderFactory); }
    public static System.Data.Common.DbProviderFactory GetFactory(System.Data.DataRow providerRow) { return default(System.Data.Common.DbProviderFactory); }
    public static System.Data.Common.DbProviderFactory GetFactory(string providerInvariantName) { return default(System.Data.Common.DbProviderFactory); }
    public static System.Data.DataTable GetFactoryClasses() { return default(System.Data.DataTable); }
  }
  public partial class DbProviderFactoriesConfigurationHandler : System.Configuration.IConfigurationSectionHandler {
    public DbProviderFactoriesConfigurationHandler() { }
    public virtual object Create(object parent, object configContext, System.Xml.XmlNode section) { return default(object); }
  }
  public abstract partial class DbProviderFactory {
    protected DbProviderFactory() { }
    public virtual bool CanCreateDataSourceEnumerator { get { return default(bool); } }
    public virtual System.Data.Common.DbCommand CreateCommand() { return default(System.Data.Common.DbCommand); }
    public virtual System.Data.Common.DbCommandBuilder CreateCommandBuilder() { return default(System.Data.Common.DbCommandBuilder); }
    public virtual System.Data.Common.DbConnection CreateConnection() { return default(System.Data.Common.DbConnection); }
    public virtual System.Data.Common.DbConnectionStringBuilder CreateConnectionStringBuilder() { return default(System.Data.Common.DbConnectionStringBuilder); }
    public virtual System.Data.Common.DbDataAdapter CreateDataAdapter() { return default(System.Data.Common.DbDataAdapter); }
    public virtual System.Data.Common.DbDataSourceEnumerator CreateDataSourceEnumerator() { return default(System.Data.Common.DbDataSourceEnumerator); }
    public virtual System.Data.Common.DbParameter CreateParameter() { return default(System.Data.Common.DbParameter); }
    public virtual System.Security.CodeAccessPermission CreatePermission(System.Security.Permissions.PermissionState state) { return default(System.Security.CodeAccessPermission); }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(128), AllowMultiple=false, Inherited=true)]
  public sealed partial class DbProviderSpecificTypePropertyAttribute : System.Attribute {
    public DbProviderSpecificTypePropertyAttribute(bool isProviderSpecificTypeProperty) { }
    public bool IsProviderSpecificTypeProperty { get { return default(bool); } }
  }
  public abstract partial class DbTransaction : System.MarshalByRefObject, System.Data.IDbTransaction, System.IDisposable {
    protected DbTransaction() { }
    public System.Data.Common.DbConnection Connection { get { return default(System.Data.Common.DbConnection); } }
    protected abstract System.Data.Common.DbConnection DbConnection { get; }
    public abstract System.Data.IsolationLevel IsolationLevel { get; }
    System.Data.IDbConnection System.Data.IDbTransaction.Connection { get { return default(System.Data.IDbConnection); } }
    public abstract void Commit();
    public void Dispose() { }
    protected virtual void Dispose(bool disposing) { }
    public abstract void Rollback();
  }
  public enum GroupByBehavior {
    ExactMatch = 4,
    MustContainAll = 3,
    NotSupported = 1,
    Unknown = 0,
    Unrelated = 2,
  }
  public enum IdentifierCase {
    Insensitive = 1,
    Sensitive = 2,
    Unknown = 0,
  }
  public partial class RowUpdatedEventArgs : System.EventArgs {
    public RowUpdatedEventArgs(System.Data.DataRow dataRow, System.Data.IDbCommand command, System.Data.StatementType statementType, System.Data.Common.DataTableMapping tableMapping) { }
    public System.Data.IDbCommand Command { get { return default(System.Data.IDbCommand); } }
    public System.Exception Errors { get { return default(System.Exception); } set { } }
    public int RecordsAffected { get { return default(int); } }
    public System.Data.DataRow Row { get { return default(System.Data.DataRow); } }
    public int RowCount { get { return default(int); } }
    public System.Data.StatementType StatementType { get { return default(System.Data.StatementType); } }
    public System.Data.UpdateStatus Status { get { return default(System.Data.UpdateStatus); } set { } }
    public System.Data.Common.DataTableMapping TableMapping { get { return default(System.Data.Common.DataTableMapping); } }
    public void CopyToRows(System.Data.DataRow[] array) { }
    public void CopyToRows(System.Data.DataRow[] array, int arrayIndex) { }
  }
  public partial class RowUpdatingEventArgs : System.EventArgs {
    public RowUpdatingEventArgs(System.Data.DataRow dataRow, System.Data.IDbCommand command, System.Data.StatementType statementType, System.Data.Common.DataTableMapping tableMapping) { }
    protected virtual System.Data.IDbCommand BaseCommand { get { return default(System.Data.IDbCommand); } set { } }
    public System.Data.IDbCommand Command { get { return default(System.Data.IDbCommand); } set { } }
    public System.Exception Errors { get { return default(System.Exception); } set { } }
    public System.Data.DataRow Row { get { return default(System.Data.DataRow); } }
    public System.Data.StatementType StatementType { get { return default(System.Data.StatementType); } }
    public System.Data.UpdateStatus Status { get { return default(System.Data.UpdateStatus); } set { } }
    public System.Data.Common.DataTableMapping TableMapping { get { return default(System.Data.Common.DataTableMapping); } }
  }
  public static partial class SchemaTableColumn {
    public static readonly string AllowDBNull;
    public static readonly string BaseColumnName;
    public static readonly string BaseSchemaName;
    public static readonly string BaseTableName;
    public static readonly string ColumnName;
    public static readonly string ColumnOrdinal;
    public static readonly string ColumnSize;
    public static readonly string DataType;
    public static readonly string IsAliased;
    public static readonly string IsExpression;
    public static readonly string IsKey;
    public static readonly string IsLong;
    public static readonly string IsUnique;
    public static readonly string NonVersionedProviderType;
    public static readonly string NumericPrecision;
    public static readonly string NumericScale;
    public static readonly string ProviderType;
  }
  public static partial class SchemaTableOptionalColumn {
    public static readonly string AutoIncrementSeed;
    public static readonly string AutoIncrementStep;
    public static readonly string BaseCatalogName;
    public static readonly string BaseColumnNamespace;
    public static readonly string BaseServerName;
    public static readonly string BaseTableNamespace;
    public static readonly string ColumnMapping;
    public static readonly string DefaultValue;
    public static readonly string Expression;
    public static readonly string IsAutoIncrement;
    public static readonly string IsHidden;
    public static readonly string IsReadOnly;
    public static readonly string IsRowVersion;
    public static readonly string ProviderSpecificDataType;
  }
  [System.FlagsAttribute]
  public enum SupportedJoinOperators {
    FullOuter = 8,
    Inner = 1,
    LeftOuter = 2,
    None = 0,
    RightOuter = 4,
  }
}
namespace System.Data.Odbc {
  [System.ComponentModel.DefaultEventAttribute("RecordsAffected")]
  [System.ComponentModel.DesignerAttribute("Microsoft.VSDesigner.Data.VS.OdbcCommandDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
  [System.ComponentModel.ToolboxItemAttribute(true)]
  public sealed partial class OdbcCommand : System.Data.Common.DbCommand, System.ICloneable {
    public OdbcCommand() { }
    public OdbcCommand(string cmdText) { }
    public OdbcCommand(string cmdText, System.Data.Odbc.OdbcConnection connection) { }
    public OdbcCommand(string cmdText, System.Data.Odbc.OdbcConnection connection, System.Data.Odbc.OdbcTransaction transaction) { }
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.ComponentModel.EditorAttribute("Microsoft.VSDesigner.Data.Odbc.Design.OdbcCommandTextEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
    [System.Data.ResCategoryAttribute("DataCategory_Data")]
    [System.Data.ResDescriptionAttribute("DbCommand_CommandText")]
    public override string CommandText { get { return default(string); } set { } }
    [System.Data.ResCategoryAttribute("DataCategory_Data")]
    [System.Data.ResDescriptionAttribute("DbCommand_CommandTimeout")]
    public override int CommandTimeout { get { return default(int); } set { } }
    [System.ComponentModel.DefaultValueAttribute((System.Data.CommandType)(1))]
    [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
    [System.Data.ResCategoryAttribute("DataCategory_Data")]
    [System.Data.ResDescriptionAttribute("DbCommand_CommandType")]
    public override System.Data.CommandType CommandType { get { return default(System.Data.CommandType); } set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    [System.ComponentModel.EditorAttribute("Microsoft.VSDesigner.Data.Design.DbConnectionEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.Data.ResCategoryAttribute("DataCategory_Behavior")]
    [System.Data.ResDescriptionAttribute("DbCommand_Connection")]
    public new System.Data.Odbc.OdbcConnection Connection { get { return default(System.Data.Odbc.OdbcConnection); } set { } }
    protected override System.Data.Common.DbConnection DbConnection { get { return default(System.Data.Common.DbConnection); } set { } }
    protected override System.Data.Common.DbParameterCollection DbParameterCollection { get { return default(System.Data.Common.DbParameterCollection); } }
    protected override System.Data.Common.DbTransaction DbTransaction { get { return default(System.Data.Common.DbTransaction); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute(true)]
    [System.ComponentModel.DesignOnlyAttribute(true)]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public override bool DesignTimeVisible { get { return default(bool); } set { } }
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(2))]
    [System.Data.ResCategoryAttribute("DataCategory_Data")]
    [System.Data.ResDescriptionAttribute("DbCommand_Parameters")]
    public new System.Data.Odbc.OdbcParameterCollection Parameters { get { return default(System.Data.Odbc.OdbcParameterCollection); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.Data.ResDescriptionAttribute("DbCommand_Transaction")]
    public new System.Data.Odbc.OdbcTransaction Transaction { get { return default(System.Data.Odbc.OdbcTransaction); } set { } }
    [System.ComponentModel.DefaultValueAttribute((System.Data.UpdateRowSource)(3))]
    [System.Data.ResCategoryAttribute("DataCategory_Update")]
    [System.Data.ResDescriptionAttribute("DbCommand_UpdatedRowSource")]
    public override System.Data.UpdateRowSource UpdatedRowSource { get { return default(System.Data.UpdateRowSource); } set { } }
    public override void Cancel() { }
    protected override System.Data.Common.DbParameter CreateDbParameter() { return default(System.Data.Common.DbParameter); }
    public new System.Data.Odbc.OdbcParameter CreateParameter() { return default(System.Data.Odbc.OdbcParameter); }
    protected override void Dispose(bool disposing) { }
    protected override System.Data.Common.DbDataReader ExecuteDbDataReader(System.Data.CommandBehavior behavior) { return default(System.Data.Common.DbDataReader); }
    public override int ExecuteNonQuery() { return default(int); }
    public new System.Data.Odbc.OdbcDataReader ExecuteReader() { return default(System.Data.Odbc.OdbcDataReader); }
    public new System.Data.Odbc.OdbcDataReader ExecuteReader(System.Data.CommandBehavior behavior) { return default(System.Data.Odbc.OdbcDataReader); }
    public override object ExecuteScalar() { return default(object); }
    public override void Prepare() { }
    public void ResetCommandTimeout() { }
    object System.ICloneable.Clone() { return default(object); }
  }
  public sealed partial class OdbcCommandBuilder : System.Data.Common.DbCommandBuilder {
    public OdbcCommandBuilder() { }
    public OdbcCommandBuilder(System.Data.Odbc.OdbcDataAdapter adapter) { }
    [System.ComponentModel.DefaultValueAttribute(null)]
    [System.Data.ResCategoryAttribute("DataCategory_Update")]
    [System.Data.ResDescriptionAttribute("OdbcCommandBuilder_DataAdapter")]
    public new System.Data.Odbc.OdbcDataAdapter DataAdapter { get { return default(System.Data.Odbc.OdbcDataAdapter); } set { } }
    protected override void ApplyParameterInfo(System.Data.Common.DbParameter parameter, System.Data.DataRow datarow, System.Data.StatementType statementType, bool whereClause) { }
    public static void DeriveParameters(System.Data.Odbc.OdbcCommand command) { }
    public new System.Data.Odbc.OdbcCommand GetDeleteCommand() { return default(System.Data.Odbc.OdbcCommand); }
    public new System.Data.Odbc.OdbcCommand GetDeleteCommand(bool useColumnsForParameterNames) { return default(System.Data.Odbc.OdbcCommand); }
    public new System.Data.Odbc.OdbcCommand GetInsertCommand() { return default(System.Data.Odbc.OdbcCommand); }
    public new System.Data.Odbc.OdbcCommand GetInsertCommand(bool useColumnsForParameterNames) { return default(System.Data.Odbc.OdbcCommand); }
    protected override string GetParameterName(int parameterOrdinal) { return default(string); }
    protected override string GetParameterName(string parameterName) { return default(string); }
    protected override string GetParameterPlaceholder(int parameterOrdinal) { return default(string); }
    public new System.Data.Odbc.OdbcCommand GetUpdateCommand() { return default(System.Data.Odbc.OdbcCommand); }
    public new System.Data.Odbc.OdbcCommand GetUpdateCommand(bool useColumnsForParameterNames) { return default(System.Data.Odbc.OdbcCommand); }
    public override string QuoteIdentifier(string unquotedIdentifier) { return default(string); }
    public string QuoteIdentifier(string unquotedIdentifier, System.Data.Odbc.OdbcConnection connection) { return default(string); }
    protected override void SetRowUpdatingHandler(System.Data.Common.DbDataAdapter adapter) { }
    public override string UnquoteIdentifier(string quotedIdentifier) { return default(string); }
    public string UnquoteIdentifier(string quotedIdentifier, System.Data.Odbc.OdbcConnection connection) { return default(string); }
  }
  [System.ComponentModel.DefaultEventAttribute("InfoMessage")]
  public sealed partial class OdbcConnection : System.Data.Common.DbConnection, System.ICloneable {
    public OdbcConnection() { }
    public OdbcConnection(string connectionString) { }
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.ComponentModel.EditorAttribute("Microsoft.VSDesigner.Data.Odbc.Design.OdbcConnectionStringEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.RecommendedAsConfigurableAttribute(true)]
    [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
    [System.ComponentModel.SettingsBindableAttribute(true)]
    [System.Data.ResCategoryAttribute("DataCategory_Data")]
    [System.Data.ResDescriptionAttribute("OdbcConnection_ConnectionString")]
    public override string ConnectionString { get { return default(string); } set { } }
    [System.ComponentModel.DefaultValueAttribute(15)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.Data.ResCategoryAttribute("DataCategory_Data")]
    [System.Data.ResDescriptionAttribute("OdbcConnection_ConnectionTimeout")]
    public new int ConnectionTimeout { get { return default(int); } set { } }
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.Data.ResDescriptionAttribute("OdbcConnection_Database")]
    public override string Database { get { return default(string); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.Data.ResDescriptionAttribute("OdbcConnection_DataSource")]
    public override string DataSource { get { return default(string); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.Data.ResDescriptionAttribute("OdbcConnection_Driver")]
    public string Driver { get { return default(string); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.Data.ResDescriptionAttribute("OdbcConnection_ServerVersion")]
    public override string ServerVersion { get { return default(string); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.Data.ResDescriptionAttribute("DbConnection_State")]
    public override System.Data.ConnectionState State { get { return default(System.Data.ConnectionState); } }
    [System.Data.ResCategoryAttribute("DataCategory_InfoMessage")]
    [System.Data.ResDescriptionAttribute("DbConnection_InfoMessage")]
    public event System.Data.Odbc.OdbcInfoMessageEventHandler InfoMessage { add { } remove { } }
  }
}
