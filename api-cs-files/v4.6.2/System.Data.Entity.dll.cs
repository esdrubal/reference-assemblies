namespace System.Data {
  public sealed partial class EntityCommandCompilationException : System.Data.EntityException {
    public EntityCommandCompilationException() { }
    public EntityCommandCompilationException(string message) { }
    public EntityCommandCompilationException(string message, System.Exception innerException) { }
  }
  public sealed partial class EntityCommandExecutionException : System.Data.EntityException {
    public EntityCommandExecutionException() { }
    public EntityCommandExecutionException(string message) { }
    public EntityCommandExecutionException(string message, System.Exception innerException) { }
  }
  public partial class EntityException : System.Data.DataException {
    public EntityException() { }
    protected EntityException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public EntityException(string message) { }
    public EntityException(string message, System.Exception innerException) { }
  }
  [System.Diagnostics.DebuggerDisplayAttribute("{ConcatKeyValue()}")]
  [System.Runtime.Serialization.DataContractAttribute(IsReference=true)]
  public sealed partial class EntityKey : System.IEquatable<System.Data.EntityKey> {
    public static readonly System.Data.EntityKey EntityNotValidKey;
    public static readonly System.Data.EntityKey NoEntitySetKey;
    public EntityKey() { }
    public EntityKey(string qualifiedEntitySetName, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>> entityKeyValues) { }
    public EntityKey(string qualifiedEntitySetName, System.Collections.Generic.IEnumerable<System.Data.EntityKeyMember> entityKeyValues) { }
    public EntityKey(string qualifiedEntitySetName, string keyName, object keyValue) { }
    [System.Runtime.Serialization.DataMemberAttribute]
    public string EntityContainerName { get { return default(string); } set { } }
    [System.Runtime.Serialization.DataMemberAttribute]
    public System.Data.EntityKeyMember[] EntityKeyValues { get { return default(System.Data.EntityKeyMember[]); } set { } }
    [System.Runtime.Serialization.DataMemberAttribute]
    public string EntitySetName { get { return default(string); } set { } }
    public bool IsTemporary { get { return default(bool); } }
    public bool Equals(System.Data.EntityKey other) { return default(bool); }
    public override bool Equals(object obj) { return default(bool); }
    public System.Data.Metadata.Edm.EntitySet GetEntitySet(System.Data.Metadata.Edm.MetadataWorkspace metadataWorkspace) { return default(System.Data.Metadata.Edm.EntitySet); }
    public override int GetHashCode() { return default(int); }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.Runtime.Serialization.OnDeserializedAttribute]
    public void OnDeserialized(System.Runtime.Serialization.StreamingContext context) { }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.Runtime.Serialization.OnDeserializingAttribute]
    public void OnDeserializing(System.Runtime.Serialization.StreamingContext context) { }
    public static bool operator ==(System.Data.EntityKey key1, System.Data.EntityKey key2) { return default(bool); }
    public static bool operator !=(System.Data.EntityKey key1, System.Data.EntityKey key2) { return default(bool); }
  }
  [System.Runtime.Serialization.DataContractAttribute]
  public partial class EntityKeyMember {
    public EntityKeyMember() { }
    public EntityKeyMember(string keyName, object keyValue) { }
    [System.Runtime.Serialization.DataMemberAttribute]
    public string Key { get { return default(string); } set { } }
    [System.Runtime.Serialization.DataMemberAttribute]
    public object Value { get { return default(object); } set { } }
    public override string ToString() { return default(string); }
  }
  public sealed partial class EntitySqlException : System.Data.EntityException {
    public EntitySqlException() { }
    public EntitySqlException(string message) { }
    public EntitySqlException(string message, System.Exception innerException) { }
    public int Column { get { return default(int); } }
    public string ErrorContext { get { return default(string); } }
    public string ErrorDescription { get { return default(string); } }
    public int Line { get { return default(int); } }
    [System.Security.SecurityCriticalAttribute]
    [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Unrestricted=true)]
    public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
  }
  [System.ComponentModel.DataAnnotations.BindableTypeAttribute(IsBindable=false)]
  [System.FlagsAttribute]
  public enum EntityState {
    Added = 4,
    Deleted = 8,
    Detached = 1,
    Modified = 16,
    Unchanged = 2,
  }
  public partial interface IExtendedDataRecord : System.Data.IDataRecord {
    System.Data.Common.DataRecordInfo DataRecordInfo { get; }
    System.Data.Common.DbDataReader GetDataReader(int i);
    System.Data.Common.DbDataRecord GetDataRecord(int i);
  }
  public sealed partial class InvalidCommandTreeException : System.Data.DataException {
    public InvalidCommandTreeException() { }
    public InvalidCommandTreeException(string message) { }
    public InvalidCommandTreeException(string message, System.Exception innerException) { }
  }
  public sealed partial class MappingException : System.Data.EntityException {
    public MappingException() { }
    public MappingException(string message) { }
    public MappingException(string message, System.Exception innerException) { }
  }
  public sealed partial class MetadataException : System.Data.EntityException {
    public MetadataException() { }
    public MetadataException(string message) { }
    public MetadataException(string message, System.Exception innerException) { }
  }
  public sealed partial class ObjectNotFoundException : System.Data.DataException {
    public ObjectNotFoundException() { }
    public ObjectNotFoundException(string message) { }
    public ObjectNotFoundException(string message, System.Exception innerException) { }
  }
  public sealed partial class OptimisticConcurrencyException : System.Data.UpdateException {
    public OptimisticConcurrencyException() { }
    public OptimisticConcurrencyException(string message) { }
    public OptimisticConcurrencyException(string message, System.Exception innerException) { }
    public OptimisticConcurrencyException(string message, System.Exception innerException, System.Collections.Generic.IEnumerable<System.Data.Objects.ObjectStateEntry> stateEntries) { }
  }
  public sealed partial class PropertyConstraintException : System.Data.ConstraintException {
    public PropertyConstraintException() { }
    public PropertyConstraintException(string message) { }
    public PropertyConstraintException(string message, System.Exception innerException) { }
    public PropertyConstraintException(string message, string propertyName) { }
    public PropertyConstraintException(string message, string propertyName, System.Exception innerException) { }
    public string PropertyName { get { return default(string); } }
    [System.Security.SecurityCriticalAttribute]
    [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Unrestricted=true)]
    public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
  }
  public sealed partial class ProviderIncompatibleException : System.Data.EntityException {
    public ProviderIncompatibleException() { }
    public ProviderIncompatibleException(string message) { }
    public ProviderIncompatibleException(string message, System.Exception innerException) { }
  }
  public partial class UpdateException : System.Data.DataException {
    public UpdateException() { }
    protected UpdateException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public UpdateException(string message) { }
    public UpdateException(string message, System.Exception innerException) { }
    public UpdateException(string message, System.Exception innerException, System.Collections.Generic.IEnumerable<System.Data.Objects.ObjectStateEntry> stateEntries) { }
    public System.Collections.ObjectModel.ReadOnlyCollection<System.Data.Objects.ObjectStateEntry> StateEntries { get { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.Data.Objects.ObjectStateEntry>); } }
  }
}
namespace System.Data.Common {
  public partial class DataRecordInfo {
    public DataRecordInfo(System.Data.Metadata.Edm.TypeUsage metadata, System.Collections.Generic.IEnumerable<System.Data.Metadata.Edm.EdmMember> memberInfo) { }
    public System.Collections.ObjectModel.ReadOnlyCollection<System.Data.Common.FieldMetadata> FieldMetadata { get { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.Data.Common.FieldMetadata>); } }
    public System.Data.Metadata.Edm.TypeUsage RecordType { get { return default(System.Data.Metadata.Edm.TypeUsage); } }
  }
  public partial class DbCommandDefinition {
    protected DbCommandDefinition() { }
    protected DbCommandDefinition(System.Data.Common.DbCommand prototype) { }
    public virtual System.Data.Common.DbCommand CreateCommand() { return default(System.Data.Common.DbCommand); }
  }
  public abstract partial class DbProviderManifest {
    public static readonly string ConceptualSchemaDefinition;
    public static readonly string ConceptualSchemaDefinitionVersion3;
    public static readonly string StoreSchemaDefinition;
    public static readonly string StoreSchemaDefinitionVersion3;
    public static readonly string StoreSchemaMapping;
    public static readonly string StoreSchemaMappingVersion3;
    protected DbProviderManifest() { }
    public abstract string NamespaceName { get; }
    public virtual string EscapeLikeArgument(string argument) { return default(string); }
    protected abstract System.Xml.XmlReader GetDbInformation(string informationType);
    public abstract System.Data.Metadata.Edm.TypeUsage GetEdmType(System.Data.Metadata.Edm.TypeUsage storeType);
    public abstract System.Collections.ObjectModel.ReadOnlyCollection<System.Data.Metadata.Edm.FacetDescription> GetFacetDescriptions(System.Data.Metadata.Edm.EdmType edmType);
    public System.Xml.XmlReader GetInformation(string informationType) { return default(System.Xml.XmlReader); }
    public abstract System.Collections.ObjectModel.ReadOnlyCollection<System.Data.Metadata.Edm.EdmFunction> GetStoreFunctions();
    public abstract System.Data.Metadata.Edm.TypeUsage GetStoreType(System.Data.Metadata.Edm.TypeUsage edmType);
    public abstract System.Collections.ObjectModel.ReadOnlyCollection<System.Data.Metadata.Edm.PrimitiveType> GetStoreTypes();
    public virtual bool SupportsEscapingLikeArgument(out char escapeCharacter) { escapeCharacter = default(char); return default(bool); }
  }
  [System.CLSCompliantAttribute(false)]
  public abstract partial class DbProviderServices {
    protected DbProviderServices() { }
    public System.Data.Common.DbCommandDefinition CreateCommandDefinition(System.Data.Common.CommandTrees.DbCommandTree commandTree) { return default(System.Data.Common.DbCommandDefinition); }
    public virtual System.Data.Common.DbCommandDefinition CreateCommandDefinition(System.Data.Common.DbCommand prototype) { return default(System.Data.Common.DbCommandDefinition); }
    public System.Data.Common.DbCommandDefinition CreateCommandDefinition(System.Data.Common.DbProviderManifest providerManifest, System.Data.Common.CommandTrees.DbCommandTree commandTree) { return default(System.Data.Common.DbCommandDefinition); }
    public void CreateDatabase(System.Data.Common.DbConnection connection, System.Nullable<System.Int32> commandTimeout, System.Data.Metadata.Edm.StoreItemCollection storeItemCollection) { }
    public string CreateDatabaseScript(string providerManifestToken, System.Data.Metadata.Edm.StoreItemCollection storeItemCollection) { return default(string); }
    protected abstract System.Data.Common.DbCommandDefinition CreateDbCommandDefinition(System.Data.Common.DbProviderManifest providerManifest, System.Data.Common.CommandTrees.DbCommandTree commandTree);
    public bool DatabaseExists(System.Data.Common.DbConnection connection, System.Nullable<System.Int32> commandTimeout, System.Data.Metadata.Edm.StoreItemCollection storeItemCollection) { return default(bool); }
    protected virtual void DbCreateDatabase(System.Data.Common.DbConnection connection, System.Nullable<System.Int32> commandTimeout, System.Data.Metadata.Edm.StoreItemCollection storeItemCollection) { }
    protected virtual string DbCreateDatabaseScript(string providerManifestToken, System.Data.Metadata.Edm.StoreItemCollection storeItemCollection) { return default(string); }
    protected virtual bool DbDatabaseExists(System.Data.Common.DbConnection connection, System.Nullable<System.Int32> commandTimeout, System.Data.Metadata.Edm.StoreItemCollection storeItemCollection) { return default(bool); }
    protected virtual void DbDeleteDatabase(System.Data.Common.DbConnection connection, System.Nullable<System.Int32> commandTimeout, System.Data.Metadata.Edm.StoreItemCollection storeItemCollection) { }
    protected virtual System.Data.Spatial.DbSpatialServices DbGetSpatialServices(string manifestToken) { return default(System.Data.Spatial.DbSpatialServices); }
    public void DeleteDatabase(System.Data.Common.DbConnection connection, System.Nullable<System.Int32> commandTimeout, System.Data.Metadata.Edm.StoreItemCollection storeItemCollection) { }
    protected abstract System.Data.Common.DbProviderManifest GetDbProviderManifest(string manifestToken);
    protected abstract string GetDbProviderManifestToken(System.Data.Common.DbConnection connection);
    protected virtual System.Data.Spatial.DbSpatialDataReader GetDbSpatialDataReader(System.Data.Common.DbDataReader fromReader, string manifestToken) { return default(System.Data.Spatial.DbSpatialDataReader); }
    public static System.Data.Common.DbProviderFactory GetProviderFactory(System.Data.Common.DbConnection connection) { return default(System.Data.Common.DbProviderFactory); }
    public System.Data.Common.DbProviderManifest GetProviderManifest(string manifestToken) { return default(System.Data.Common.DbProviderManifest); }
    public string GetProviderManifestToken(System.Data.Common.DbConnection connection) { return default(string); }
    public static System.Data.Common.DbProviderServices GetProviderServices(System.Data.Common.DbConnection connection) { return default(System.Data.Common.DbProviderServices); }
    public System.Data.Spatial.DbSpatialDataReader GetSpatialDataReader(System.Data.Common.DbDataReader fromReader, string manifestToken) { return default(System.Data.Spatial.DbSpatialDataReader); }
    public System.Data.Spatial.DbSpatialServices GetSpatialServices(string manifestToken) { return default(System.Data.Spatial.DbSpatialServices); }
    protected virtual void SetDbParameterValue(System.Data.Common.DbParameter parameter, System.Data.Metadata.Edm.TypeUsage parameterType, object value) { }
  }
  public abstract partial class DbXmlEnabledProviderManifest : System.Data.Common.DbProviderManifest {
    protected DbXmlEnabledProviderManifest(System.Xml.XmlReader reader) { }
    public override string NamespaceName { get { return default(string); } }
    protected System.Collections.Generic.Dictionary<System.String, System.Data.Metadata.Edm.PrimitiveType> StoreTypeNameToEdmPrimitiveType { get { return default(System.Collections.Generic.Dictionary<System.String, System.Data.Metadata.Edm.PrimitiveType>); } }
    protected System.Collections.Generic.Dictionary<System.String, System.Data.Metadata.Edm.PrimitiveType> StoreTypeNameToStorePrimitiveType { get { return default(System.Collections.Generic.Dictionary<System.String, System.Data.Metadata.Edm.PrimitiveType>); } }
    public override System.Collections.ObjectModel.ReadOnlyCollection<System.Data.Metadata.Edm.FacetDescription> GetFacetDescriptions(System.Data.Metadata.Edm.EdmType type) { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.Data.Metadata.Edm.FacetDescription>); }
    public override System.Collections.ObjectModel.ReadOnlyCollection<System.Data.Metadata.Edm.EdmFunction> GetStoreFunctions() { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.Data.Metadata.Edm.EdmFunction>); }
    public override System.Collections.ObjectModel.ReadOnlyCollection<System.Data.Metadata.Edm.PrimitiveType> GetStoreTypes() { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.Data.Metadata.Edm.PrimitiveType>); }
  }
  public partial class EntityRecordInfo : System.Data.Common.DataRecordInfo {
    public EntityRecordInfo(System.Data.Metadata.Edm.EntityType metadata, System.Collections.Generic.IEnumerable<System.Data.Metadata.Edm.EdmMember> memberInfo, System.Data.EntityKey entityKey, System.Data.Metadata.Edm.EntitySet entitySet) : base (default(System.Data.Metadata.Edm.TypeUsage), default(System.Collections.Generic.IEnumerable<System.Data.Metadata.Edm.EdmMember>)) { }
    public System.Data.EntityKey EntityKey { get { return default(System.Data.EntityKey); } }
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct FieldMetadata {
    public FieldMetadata(int ordinal, System.Data.Metadata.Edm.EdmMember fieldType) { throw new System.NotImplementedException(); }
    public System.Data.Metadata.Edm.EdmMember FieldType { get { return default(System.Data.Metadata.Edm.EdmMember); } }
    public int Ordinal { get { return default(int); } }
  }
}
namespace System.Data.Common.CommandTrees {
  public abstract partial class DbAggregate {
    internal DbAggregate() { }
    public System.Collections.Generic.IList<System.Data.Common.CommandTrees.DbExpression> Arguments { get { return default(System.Collections.Generic.IList<System.Data.Common.CommandTrees.DbExpression>); } }
    public System.Data.Metadata.Edm.TypeUsage ResultType { get { return default(System.Data.Metadata.Edm.TypeUsage); } }
  }
  public sealed partial class DbAndExpression : System.Data.Common.CommandTrees.DbBinaryExpression {
    internal DbAndExpression() { }
    public override void Accept(System.Data.Common.CommandTrees.DbExpressionVisitor visitor) { }
    public override TResultType Accept<TResultType>(System.Data.Common.CommandTrees.DbExpressionVisitor<TResultType> visitor) { return default(TResultType); }
  }
  public sealed partial class DbApplyExpression : System.Data.Common.CommandTrees.DbExpression {
    internal DbApplyExpression() { }
    public System.Data.Common.CommandTrees.DbExpressionBinding Apply { get { return default(System.Data.Common.CommandTrees.DbExpressionBinding); } }
    public System.Data.Common.CommandTrees.DbExpressionBinding Input { get { return default(System.Data.Common.CommandTrees.DbExpressionBinding); } }
    public override void Accept(System.Data.Common.CommandTrees.DbExpressionVisitor visitor) { }
    public override TResultType Accept<TResultType>(System.Data.Common.CommandTrees.DbExpressionVisitor<TResultType> visitor) { return default(TResultType); }
  }
  public sealed partial class DbArithmeticExpression : System.Data.Common.CommandTrees.DbExpression {
    internal DbArithmeticExpression() { }
    public System.Collections.Generic.IList<System.Data.Common.CommandTrees.DbExpression> Arguments { get { return default(System.Collections.Generic.IList<System.Data.Common.CommandTrees.DbExpression>); } }
    public override void Accept(System.Data.Common.CommandTrees.DbExpressionVisitor visitor) { }
    public override TResultType Accept<TResultType>(System.Data.Common.CommandTrees.DbExpressionVisitor<TResultType> visitor) { return default(TResultType); }
  }
  public abstract partial class DbBinaryExpression : System.Data.Common.CommandTrees.DbExpression {
    internal DbBinaryExpression() { }
    public System.Data.Common.CommandTrees.DbExpression Left { get { return default(System.Data.Common.CommandTrees.DbExpression); } }
    public System.Data.Common.CommandTrees.DbExpression Right { get { return default(System.Data.Common.CommandTrees.DbExpression); } }
  }
  public sealed partial class DbCaseExpression : System.Data.Common.CommandTrees.DbExpression {
    internal DbCaseExpression() { }
    public System.Data.Common.CommandTrees.DbExpression Else { get { return default(System.Data.Common.CommandTrees.DbExpression); } }
    public System.Collections.Generic.IList<System.Data.Common.CommandTrees.DbExpression> Then { get { return default(System.Collections.Generic.IList<System.Data.Common.CommandTrees.DbExpression>); } }
    public System.Collections.Generic.IList<System.Data.Common.CommandTrees.DbExpression> When { get { return default(System.Collections.Generic.IList<System.Data.Common.CommandTrees.DbExpression>); } }
    public override void Accept(System.Data.Common.CommandTrees.DbExpressionVisitor visitor) { }
    public override TResultType Accept<TResultType>(System.Data.Common.CommandTrees.DbExpressionVisitor<TResultType> visitor) { return default(TResultType); }
  }
  public sealed partial class DbCastExpression : System.Data.Common.CommandTrees.DbUnaryExpression {
    internal DbCastExpression() { }
    public override void Accept(System.Data.Common.CommandTrees.DbExpressionVisitor visitor) { }
    public override TResultType Accept<TResultType>(System.Data.Common.CommandTrees.DbExpressionVisitor<TResultType> visitor) { return default(TResultType); }
  }
  public abstract partial class DbCommandTree {
    internal DbCommandTree() { }
    public System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Data.Metadata.Edm.TypeUsage>> Parameters { get { return default(System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Data.Metadata.Edm.TypeUsage>>); } }
  }
  public sealed partial class DbComparisonExpression : System.Data.Common.CommandTrees.DbBinaryExpression {
    internal DbComparisonExpression() { }
    public override void Accept(System.Data.Common.CommandTrees.DbExpressionVisitor visitor) { }
    public override TResultType Accept<TResultType>(System.Data.Common.CommandTrees.DbExpressionVisitor<TResultType> visitor) { return default(TResultType); }
  }
  public sealed partial class DbConstantExpression : System.Data.Common.CommandTrees.DbExpression {
    internal DbConstantExpression() { }
    public object Value { get { return default(object); } }
    public override void Accept(System.Data.Common.CommandTrees.DbExpressionVisitor visitor) { }
    public override TResultType Accept<TResultType>(System.Data.Common.CommandTrees.DbExpressionVisitor<TResultType> visitor) { return default(TResultType); }
  }
  public sealed partial class DbCrossJoinExpression : System.Data.Common.CommandTrees.DbExpression {
    internal DbCrossJoinExpression() { }
    public System.Collections.Generic.IList<System.Data.Common.CommandTrees.DbExpressionBinding> Inputs { get { return default(System.Collections.Generic.IList<System.Data.Common.CommandTrees.DbExpressionBinding>); } }
    public override void Accept(System.Data.Common.CommandTrees.DbExpressionVisitor visitor) { }
    public override TResultType Accept<TResultType>(System.Data.Common.CommandTrees.DbExpressionVisitor<TResultType> visitor) { return default(TResultType); }
  }
  public sealed partial class DbDeleteCommandTree : System.Data.Common.CommandTrees.DbModificationCommandTree {
    internal DbDeleteCommandTree() { }
    public System.Data.Common.CommandTrees.DbExpression Predicate { get { return default(System.Data.Common.CommandTrees.DbExpression); } }
  }
  public sealed partial class DbDerefExpression : System.Data.Common.CommandTrees.DbUnaryExpression {
    internal DbDerefExpression() { }
    public override void Accept(System.Data.Common.CommandTrees.DbExpressionVisitor visitor) { }
    public override TResultType Accept<TResultType>(System.Data.Common.CommandTrees.DbExpressionVisitor<TResultType> visitor) { return default(TResultType); }
  }
  public sealed partial class DbDistinctExpression : System.Data.Common.CommandTrees.DbUnaryExpression {
    internal DbDistinctExpression() { }
    public override void Accept(System.Data.Common.CommandTrees.DbExpressionVisitor visitor) { }
    public override TResultType Accept<TResultType>(System.Data.Common.CommandTrees.DbExpressionVisitor<TResultType> visitor) { return default(TResultType); }
  }
  public sealed partial class DbElementExpression : System.Data.Common.CommandTrees.DbUnaryExpression {
    internal DbElementExpression() { }
    public override void Accept(System.Data.Common.CommandTrees.DbExpressionVisitor visitor) { }
    public override TResultType Accept<TResultType>(System.Data.Common.CommandTrees.DbExpressionVisitor<TResultType> visitor) { return default(TResultType); }
  }
  public sealed partial class DbEntityRefExpression : System.Data.Common.CommandTrees.DbUnaryExpression {
    internal DbEntityRefExpression() { }
    public override void Accept(System.Data.Common.CommandTrees.DbExpressionVisitor visitor) { }
    public override TResultType Accept<TResultType>(System.Data.Common.CommandTrees.DbExpressionVisitor<TResultType> visitor) { return default(TResultType); }
  }
  public sealed partial class DbExceptExpression : System.Data.Common.CommandTrees.DbBinaryExpression {
    internal DbExceptExpression() { }
    public override void Accept(System.Data.Common.CommandTrees.DbExpressionVisitor visitor) { }
    public override TResultType Accept<TResultType>(System.Data.Common.CommandTrees.DbExpressionVisitor<TResultType> visitor) { return default(TResultType); }
  }
  public abstract partial class DbExpression {
    internal DbExpression() { }
    public System.Data.Common.CommandTrees.DbExpressionKind ExpressionKind { get { return default(System.Data.Common.CommandTrees.DbExpressionKind); } }
    public System.Data.Metadata.Edm.TypeUsage ResultType { get { return default(System.Data.Metadata.Edm.TypeUsage); } }
    public abstract void Accept(System.Data.Common.CommandTrees.DbExpressionVisitor visitor);
    public abstract TResultType Accept<TResultType>(System.Data.Common.CommandTrees.DbExpressionVisitor<TResultType> visitor);
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public override bool Equals(object obj) { return default(bool); }
    public static System.Data.Common.CommandTrees.DbExpression FromBinary(System.Byte[] value) { return default(System.Data.Common.CommandTrees.DbExpression); }
    public static System.Data.Common.CommandTrees.DbExpression FromBoolean(System.Nullable<System.Boolean> value) { return default(System.Data.Common.CommandTrees.DbExpression); }
    public static System.Data.Common.CommandTrees.DbExpression FromByte(System.Nullable<System.Byte> value) { return default(System.Data.Common.CommandTrees.DbExpression); }
    public static System.Data.Common.CommandTrees.DbExpression FromDateTime(System.Nullable<System.DateTime> value) { return default(System.Data.Common.CommandTrees.DbExpression); }
    public static System.Data.Common.CommandTrees.DbExpression FromDateTimeOffset(System.Nullable<System.DateTimeOffset> value) { return default(System.Data.Common.CommandTrees.DbExpression); }
    public static System.Data.Common.CommandTrees.DbExpression FromDecimal(System.Nullable<System.Decimal> value) { return default(System.Data.Common.CommandTrees.DbExpression); }
    public static System.Data.Common.CommandTrees.DbExpression FromDouble(System.Nullable<System.Double> value) { return default(System.Data.Common.CommandTrees.DbExpression); }
    public static System.Data.Common.CommandTrees.DbExpression FromGeography(System.Data.Spatial.DbGeography value) { return default(System.Data.Common.CommandTrees.DbExpression); }
    public static System.Data.Common.CommandTrees.DbExpression FromGeometry(System.Data.Spatial.DbGeometry value) { return default(System.Data.Common.CommandTrees.DbExpression); }
    public static System.Data.Common.CommandTrees.DbExpression FromGuid(System.Nullable<System.Guid> value) { return default(System.Data.Common.CommandTrees.DbExpression); }
    public static System.Data.Common.CommandTrees.DbExpression FromInt16(System.Nullable<System.Int16> value) { return default(System.Data.Common.CommandTrees.DbExpression); }
    public static System.Data.Common.CommandTrees.DbExpression FromInt32(System.Nullable<System.Int32> value) { return default(System.Data.Common.CommandTrees.DbExpression); }
    public static System.Data.Common.CommandTrees.DbExpression FromInt64(System.Nullable<System.Int64> value) { return default(System.Data.Common.CommandTrees.DbExpression); }
    public static System.Data.Common.CommandTrees.DbExpression FromSingle(System.Nullable<System.Single> value) { return default(System.Data.Common.CommandTrees.DbExpression); }
    public static System.Data.Common.CommandTrees.DbExpression FromString(string value) { return default(System.Data.Common.CommandTrees.DbExpression); }
    public override int GetHashCode() { return default(int); }
    public static implicit operator System.Data.Common.CommandTrees.DbExpression (System.Byte[] value) { return default(System.Data.Common.CommandTrees.DbExpression); }
    public static implicit operator System.Data.Common.CommandTrees.DbExpression (System.Data.Spatial.DbGeography value) { return default(System.Data.Common.CommandTrees.DbExpression); }
    public static implicit operator System.Data.Common.CommandTrees.DbExpression (System.Data.Spatial.DbGeometry value) { return default(System.Data.Common.CommandTrees.DbExpression); }
    public static implicit operator System.Data.Common.CommandTrees.DbExpression (System.Nullable<System.Boolean> value) { return default(System.Data.Common.CommandTrees.DbExpression); }
    public static implicit operator System.Data.Common.CommandTrees.DbExpression (System.Nullable<System.Byte> value) { return default(System.Data.Common.CommandTrees.DbExpression); }
    public static implicit operator System.Data.Common.CommandTrees.DbExpression (System.Nullable<System.DateTime> value) { return default(System.Data.Common.CommandTrees.DbExpression); }
    public static implicit operator System.Data.Common.CommandTrees.DbExpression (System.Nullable<System.DateTimeOffset> value) { return default(System.Data.Common.CommandTrees.DbExpression); }
    public static implicit operator System.Data.Common.CommandTrees.DbExpression (System.Nullable<System.Decimal> value) { return default(System.Data.Common.CommandTrees.DbExpression); }
    public static implicit operator System.Data.Common.CommandTrees.DbExpression (System.Nullable<System.Double> value) { return default(System.Data.Common.CommandTrees.DbExpression); }
    public static implicit operator System.Data.Common.CommandTrees.DbExpression (System.Nullable<System.Guid> value) { return default(System.Data.Common.CommandTrees.DbExpression); }
    public static implicit operator System.Data.Common.CommandTrees.DbExpression (System.Nullable<System.Int16> value) { return default(System.Data.Common.CommandTrees.DbExpression); }
    public static implicit operator System.Data.Common.CommandTrees.DbExpression (System.Nullable<System.Int32> value) { return default(System.Data.Common.CommandTrees.DbExpression); }
    public static implicit operator System.Data.Common.CommandTrees.DbExpression (System.Nullable<System.Int64> value) { return default(System.Data.Common.CommandTrees.DbExpression); }
    public static implicit operator System.Data.Common.CommandTrees.DbExpression (System.Nullable<System.Single> value) { return default(System.Data.Common.CommandTrees.DbExpression); }
    public static implicit operator System.Data.Common.CommandTrees.DbExpression (string value) { return default(System.Data.Common.CommandTrees.DbExpression); }
  }
  public sealed partial class DbExpressionBinding {
    internal DbExpressionBinding() { }
    public System.Data.Common.CommandTrees.DbExpression Expression { get { return default(System.Data.Common.CommandTrees.DbExpression); } }
    public System.Data.Common.CommandTrees.DbVariableReferenceExpression Variable { get { return default(System.Data.Common.CommandTrees.DbVariableReferenceExpression); } }
    public string VariableName { get { return default(string); } }
    public System.Data.Metadata.Edm.TypeUsage VariableType { get { return default(System.Data.Metadata.Edm.TypeUsage); } }
  }
  public enum DbExpressionKind {
    All = 0,
    And = 1,
    Any = 2,
    Case = 3,
    Cast = 4,
    Constant = 5,
    CrossApply = 6,
    CrossJoin = 7,
    Deref = 8,
    Distinct = 9,
    Divide = 10,
    Element = 11,
    EntityRef = 12,
    Equals = 13,
    Except = 14,
    Filter = 15,
    FullOuterJoin = 16,
    Function = 17,
    GreaterThan = 18,
    GreaterThanOrEquals = 19,
    GroupBy = 20,
    InnerJoin = 21,
    Intersect = 22,
    IsEmpty = 23,
    IsNull = 24,
    IsOf = 25,
    IsOfOnly = 26,
    Lambda = 57,
    LeftOuterJoin = 27,
    LessThan = 28,
    LessThanOrEquals = 29,
    Like = 30,
    Limit = 31,
    Minus = 32,
    Modulo = 33,
    Multiply = 34,
    NewInstance = 35,
    Not = 36,
    NotEquals = 37,
    Null = 38,
    OfType = 39,
    OfTypeOnly = 40,
    Or = 41,
    OuterApply = 42,
    ParameterReference = 43,
    Plus = 44,
    Project = 45,
    Property = 46,
    Ref = 47,
    RefKey = 48,
    RelationshipNavigation = 49,
    Scan = 50,
    Skip = 51,
    Sort = 52,
    Treat = 53,
    UnaryMinus = 54,
    UnionAll = 55,
    VariableReference = 56,
  }
  public abstract partial class DbExpressionVisitor {
    protected DbExpressionVisitor() { }
    public abstract void Visit(System.Data.Common.CommandTrees.DbAndExpression expression);
    public abstract void Visit(System.Data.Common.CommandTrees.DbApplyExpression expression);
    public abstract void Visit(System.Data.Common.CommandTrees.DbArithmeticExpression expression);
    public abstract void Visit(System.Data.Common.CommandTrees.DbCaseExpression expression);
    public abstract void Visit(System.Data.Common.CommandTrees.DbCastExpression expression);
    public abstract void Visit(System.Data.Common.CommandTrees.DbComparisonExpression expression);
    public abstract void Visit(System.Data.Common.CommandTrees.DbConstantExpression expression);
    public abstract void Visit(System.Data.Common.CommandTrees.DbCrossJoinExpression expression);
    public abstract void Visit(System.Data.Common.CommandTrees.DbDerefExpression expression);
    public abstract void Visit(System.Data.Common.CommandTrees.DbDistinctExpression expression);
    public abstract void Visit(System.Data.Common.CommandTrees.DbElementExpression expression);
    public abstract void Visit(System.Data.Common.CommandTrees.DbEntityRefExpression expression);
    public abstract void Visit(System.Data.Common.CommandTrees.DbExceptExpression expression);
    public abstract void Visit(System.Data.Common.CommandTrees.DbExpression expression);
    public abstract void Visit(System.Data.Common.CommandTrees.DbFilterExpression expression);
    public abstract void Visit(System.Data.Common.CommandTrees.DbFunctionExpression expression);
    public abstract void Visit(System.Data.Common.CommandTrees.DbGroupByExpression expression);
    public abstract void Visit(System.Data.Common.CommandTrees.DbIntersectExpression expression);
    public abstract void Visit(System.Data.Common.CommandTrees.DbIsEmptyExpression expression);
    public abstract void Visit(System.Data.Common.CommandTrees.DbIsNullExpression expression);
    public abstract void Visit(System.Data.Common.CommandTrees.DbIsOfExpression expression);
    public abstract void Visit(System.Data.Common.CommandTrees.DbJoinExpression expression);
    public virtual void Visit(System.Data.Common.CommandTrees.DbLambdaExpression expression) { }
    public abstract void Visit(System.Data.Common.CommandTrees.DbLikeExpression expression);
    public abstract void Visit(System.Data.Common.CommandTrees.DbLimitExpression expression);
    public abstract void Visit(System.Data.Common.CommandTrees.DbNewInstanceExpression expression);
    public abstract void Visit(System.Data.Common.CommandTrees.DbNotExpression expression);
    public abstract void Visit(System.Data.Common.CommandTrees.DbNullExpression expression);
    public abstract void Visit(System.Data.Common.CommandTrees.DbOfTypeExpression expression);
    public abstract void Visit(System.Data.Common.CommandTrees.DbOrExpression expression);
    public abstract void Visit(System.Data.Common.CommandTrees.DbParameterReferenceExpression expression);
    public abstract void Visit(System.Data.Common.CommandTrees.DbProjectExpression expression);
    public abstract void Visit(System.Data.Common.CommandTrees.DbPropertyExpression expression);
    public abstract void Visit(System.Data.Common.CommandTrees.DbQuantifierExpression expression);
    public abstract void Visit(System.Data.Common.CommandTrees.DbRefExpression expression);
    public abstract void Visit(System.Data.Common.CommandTrees.DbRefKeyExpression expression);
    public abstract void Visit(System.Data.Common.CommandTrees.DbRelationshipNavigationExpression expression);
    public abstract void Visit(System.Data.Common.CommandTrees.DbScanExpression expression);
    public abstract void Visit(System.Data.Common.CommandTrees.DbSkipExpression expression);
    public abstract void Visit(System.Data.Common.CommandTrees.DbSortExpression expression);
    public abstract void Visit(System.Data.Common.CommandTrees.DbTreatExpression expression);
    public abstract void Visit(System.Data.Common.CommandTrees.DbUnionAllExpression expression);
    public abstract void Visit(System.Data.Common.CommandTrees.DbVariableReferenceExpression expression);
  }
  public abstract partial class DbExpressionVisitor<TResultType> {
    protected DbExpressionVisitor() { }
    public abstract TResultType Visit(System.Data.Common.CommandTrees.DbAndExpression expression);
    public abstract TResultType Visit(System.Data.Common.CommandTrees.DbApplyExpression expression);
    public abstract TResultType Visit(System.Data.Common.CommandTrees.DbArithmeticExpression expression);
    public abstract TResultType Visit(System.Data.Common.CommandTrees.DbCaseExpression expression);
    public abstract TResultType Visit(System.Data.Common.CommandTrees.DbCastExpression expression);
    public abstract TResultType Visit(System.Data.Common.CommandTrees.DbComparisonExpression expression);
    public abstract TResultType Visit(System.Data.Common.CommandTrees.DbConstantExpression expression);
    public abstract TResultType Visit(System.Data.Common.CommandTrees.DbCrossJoinExpression expression);
    public abstract TResultType Visit(System.Data.Common.CommandTrees.DbDerefExpression expression);
    public abstract TResultType Visit(System.Data.Common.CommandTrees.DbDistinctExpression expression);
    public abstract TResultType Visit(System.Data.Common.CommandTrees.DbElementExpression expression);
    public abstract TResultType Visit(System.Data.Common.CommandTrees.DbEntityRefExpression expression);
    public abstract TResultType Visit(System.Data.Common.CommandTrees.DbExceptExpression expression);
    public abstract TResultType Visit(System.Data.Common.CommandTrees.DbExpression expression);
    public abstract TResultType Visit(System.Data.Common.CommandTrees.DbFilterExpression expression);
    public abstract TResultType Visit(System.Data.Common.CommandTrees.DbFunctionExpression expression);
    public abstract TResultType Visit(System.Data.Common.CommandTrees.DbGroupByExpression expression);
    public abstract TResultType Visit(System.Data.Common.CommandTrees.DbIntersectExpression expression);
    public abstract TResultType Visit(System.Data.Common.CommandTrees.DbIsEmptyExpression expression);
    public abstract TResultType Visit(System.Data.Common.CommandTrees.DbIsNullExpression expression);
    public abstract TResultType Visit(System.Data.Common.CommandTrees.DbIsOfExpression expression);
    public abstract TResultType Visit(System.Data.Common.CommandTrees.DbJoinExpression expression);
    public virtual TResultType Visit(System.Data.Common.CommandTrees.DbLambdaExpression expression) { return default(TResultType); }
    public abstract TResultType Visit(System.Data.Common.CommandTrees.DbLikeExpression expression);
    public abstract TResultType Visit(System.Data.Common.CommandTrees.DbLimitExpression expression);
    public abstract TResultType Visit(System.Data.Common.CommandTrees.DbNewInstanceExpression expression);
    public abstract TResultType Visit(System.Data.Common.CommandTrees.DbNotExpression expression);
    public abstract TResultType Visit(System.Data.Common.CommandTrees.DbNullExpression expression);
    public abstract TResultType Visit(System.Data.Common.CommandTrees.DbOfTypeExpression expression);
    public abstract TResultType Visit(System.Data.Common.CommandTrees.DbOrExpression expression);
    public abstract TResultType Visit(System.Data.Common.CommandTrees.DbParameterReferenceExpression expression);
    public abstract TResultType Visit(System.Data.Common.CommandTrees.DbProjectExpression expression);
    public abstract TResultType Visit(System.Data.Common.CommandTrees.DbPropertyExpression expression);
    public abstract TResultType Visit(System.Data.Common.CommandTrees.DbQuantifierExpression expression);
    public abstract TResultType Visit(System.Data.Common.CommandTrees.DbRefExpression expression);
    public abstract TResultType Visit(System.Data.Common.CommandTrees.DbRefKeyExpression expression);
    public abstract TResultType Visit(System.Data.Common.CommandTrees.DbRelationshipNavigationExpression expression);
    public abstract TResultType Visit(System.Data.Common.CommandTrees.DbScanExpression expression);
    public abstract TResultType Visit(System.Data.Common.CommandTrees.DbSkipExpression expression);
    public abstract TResultType Visit(System.Data.Common.CommandTrees.DbSortExpression expression);
    public abstract TResultType Visit(System.Data.Common.CommandTrees.DbTreatExpression expression);
    public abstract TResultType Visit(System.Data.Common.CommandTrees.DbUnionAllExpression expression);
    public abstract TResultType Visit(System.Data.Common.CommandTrees.DbVariableReferenceExpression expression);
  }
  public sealed partial class DbFilterExpression : System.Data.Common.CommandTrees.DbExpression {
    internal DbFilterExpression() { }
    public System.Data.Common.CommandTrees.DbExpressionBinding Input { get { return default(System.Data.Common.CommandTrees.DbExpressionBinding); } }
    public System.Data.Common.CommandTrees.DbExpression Predicate { get { return default(System.Data.Common.CommandTrees.DbExpression); } }
    public override void Accept(System.Data.Common.CommandTrees.DbExpressionVisitor visitor) { }
    public override TResultType Accept<TResultType>(System.Data.Common.CommandTrees.DbExpressionVisitor<TResultType> visitor) { return default(TResultType); }
  }
  public sealed partial class DbFunctionAggregate : System.Data.Common.CommandTrees.DbAggregate {
    internal DbFunctionAggregate() { }
    public bool Distinct { get { return default(bool); } }
    public System.Data.Metadata.Edm.EdmFunction Function { get { return default(System.Data.Metadata.Edm.EdmFunction); } }
  }
  public sealed partial class DbFunctionCommandTree : System.Data.Common.CommandTrees.DbCommandTree {
    internal DbFunctionCommandTree() { }
    public System.Data.Metadata.Edm.EdmFunction EdmFunction { get { return default(System.Data.Metadata.Edm.EdmFunction); } }
    public System.Data.Metadata.Edm.TypeUsage ResultType { get { return default(System.Data.Metadata.Edm.TypeUsage); } }
  }
  public sealed partial class DbFunctionExpression : System.Data.Common.CommandTrees.DbExpression {
    internal DbFunctionExpression() { }
    public System.Collections.Generic.IList<System.Data.Common.CommandTrees.DbExpression> Arguments { get { return default(System.Collections.Generic.IList<System.Data.Common.CommandTrees.DbExpression>); } }
    public System.Data.Metadata.Edm.EdmFunction Function { get { return default(System.Data.Metadata.Edm.EdmFunction); } }
    public override void Accept(System.Data.Common.CommandTrees.DbExpressionVisitor visitor) { }
    public override TResultType Accept<TResultType>(System.Data.Common.CommandTrees.DbExpressionVisitor<TResultType> visitor) { return default(TResultType); }
  }
  public sealed partial class DbGroupAggregate : System.Data.Common.CommandTrees.DbAggregate {
    internal DbGroupAggregate() { }
  }
  public sealed partial class DbGroupByExpression : System.Data.Common.CommandTrees.DbExpression {
    internal DbGroupByExpression() { }
    public System.Collections.Generic.IList<System.Data.Common.CommandTrees.DbAggregate> Aggregates { get { return default(System.Collections.Generic.IList<System.Data.Common.CommandTrees.DbAggregate>); } }
    public System.Data.Common.CommandTrees.DbGroupExpressionBinding Input { get { return default(System.Data.Common.CommandTrees.DbGroupExpressionBinding); } }
    public System.Collections.Generic.IList<System.Data.Common.CommandTrees.DbExpression> Keys { get { return default(System.Collections.Generic.IList<System.Data.Common.CommandTrees.DbExpression>); } }
    public override void Accept(System.Data.Common.CommandTrees.DbExpressionVisitor visitor) { }
    public override TResultType Accept<TResultType>(System.Data.Common.CommandTrees.DbExpressionVisitor<TResultType> visitor) { return default(TResultType); }
  }
  public sealed partial class DbGroupExpressionBinding {
    internal DbGroupExpressionBinding() { }
    public System.Data.Common.CommandTrees.DbExpression Expression { get { return default(System.Data.Common.CommandTrees.DbExpression); } }
    public System.Data.Common.CommandTrees.DbGroupAggregate GroupAggregate { get { return default(System.Data.Common.CommandTrees.DbGroupAggregate); } }
    public System.Data.Common.CommandTrees.DbVariableReferenceExpression GroupVariable { get { return default(System.Data.Common.CommandTrees.DbVariableReferenceExpression); } }
    public string GroupVariableName { get { return default(string); } }
    public System.Data.Metadata.Edm.TypeUsage GroupVariableType { get { return default(System.Data.Metadata.Edm.TypeUsage); } }
    public System.Data.Common.CommandTrees.DbVariableReferenceExpression Variable { get { return default(System.Data.Common.CommandTrees.DbVariableReferenceExpression); } }
    public string VariableName { get { return default(string); } }
    public System.Data.Metadata.Edm.TypeUsage VariableType { get { return default(System.Data.Metadata.Edm.TypeUsage); } }
  }
  public sealed partial class DbInsertCommandTree : System.Data.Common.CommandTrees.DbModificationCommandTree {
    internal DbInsertCommandTree() { }
    public System.Data.Common.CommandTrees.DbExpression Returning { get { return default(System.Data.Common.CommandTrees.DbExpression); } }
    public System.Collections.Generic.IList<System.Data.Common.CommandTrees.DbModificationClause> SetClauses { get { return default(System.Collections.Generic.IList<System.Data.Common.CommandTrees.DbModificationClause>); } }
  }
  public sealed partial class DbIntersectExpression : System.Data.Common.CommandTrees.DbBinaryExpression {
    internal DbIntersectExpression() { }
    public override void Accept(System.Data.Common.CommandTrees.DbExpressionVisitor visitor) { }
    public override TResultType Accept<TResultType>(System.Data.Common.CommandTrees.DbExpressionVisitor<TResultType> visitor) { return default(TResultType); }
  }
  public sealed partial class DbIsEmptyExpression : System.Data.Common.CommandTrees.DbUnaryExpression {
    internal DbIsEmptyExpression() { }
    public override void Accept(System.Data.Common.CommandTrees.DbExpressionVisitor visitor) { }
    public override TResultType Accept<TResultType>(System.Data.Common.CommandTrees.DbExpressionVisitor<TResultType> visitor) { return default(TResultType); }
  }
  public sealed partial class DbIsNullExpression : System.Data.Common.CommandTrees.DbUnaryExpression {
    internal DbIsNullExpression() { }
    public override void Accept(System.Data.Common.CommandTrees.DbExpressionVisitor visitor) { }
    public override TResultType Accept<TResultType>(System.Data.Common.CommandTrees.DbExpressionVisitor<TResultType> visitor) { return default(TResultType); }
  }
  public sealed partial class DbIsOfExpression : System.Data.Common.CommandTrees.DbUnaryExpression {
    internal DbIsOfExpression() { }
    public System.Data.Metadata.Edm.TypeUsage OfType { get { return default(System.Data.Metadata.Edm.TypeUsage); } }
    public override void Accept(System.Data.Common.CommandTrees.DbExpressionVisitor visitor) { }
    public override TResultType Accept<TResultType>(System.Data.Common.CommandTrees.DbExpressionVisitor<TResultType> visitor) { return default(TResultType); }
  }
  public sealed partial class DbJoinExpression : System.Data.Common.CommandTrees.DbExpression {
    internal DbJoinExpression() { }
    public System.Data.Common.CommandTrees.DbExpression JoinCondition { get { return default(System.Data.Common.CommandTrees.DbExpression); } }
    public System.Data.Common.CommandTrees.DbExpressionBinding Left { get { return default(System.Data.Common.CommandTrees.DbExpressionBinding); } }
    public System.Data.Common.CommandTrees.DbExpressionBinding Right { get { return default(System.Data.Common.CommandTrees.DbExpressionBinding); } }
    public override void Accept(System.Data.Common.CommandTrees.DbExpressionVisitor visitor) { }
    public override TResultType Accept<TResultType>(System.Data.Common.CommandTrees.DbExpressionVisitor<TResultType> visitor) { return default(TResultType); }
  }
  public sealed partial class DbLambda {
    internal DbLambda() { }
    public System.Data.Common.CommandTrees.DbExpression Body { get { return default(System.Data.Common.CommandTrees.DbExpression); } }
    public System.Collections.Generic.IList<System.Data.Common.CommandTrees.DbVariableReferenceExpression> Variables { get { return default(System.Collections.Generic.IList<System.Data.Common.CommandTrees.DbVariableReferenceExpression>); } }
    public static System.Data.Common.CommandTrees.DbLambda Create(System.Data.Common.CommandTrees.DbExpression body, System.Collections.Generic.IEnumerable<System.Data.Common.CommandTrees.DbVariableReferenceExpression> variables) { return default(System.Data.Common.CommandTrees.DbLambda); }
    public static System.Data.Common.CommandTrees.DbLambda Create(System.Data.Common.CommandTrees.DbExpression body, params System.Data.Common.CommandTrees.DbVariableReferenceExpression[] variables) { return default(System.Data.Common.CommandTrees.DbLambda); }
    public static System.Data.Common.CommandTrees.DbLambda Create(System.Data.Metadata.Edm.TypeUsage argument1Type, System.Data.Metadata.Edm.TypeUsage argument2Type, System.Data.Metadata.Edm.TypeUsage argument3Type, System.Data.Metadata.Edm.TypeUsage argument4Type, System.Data.Metadata.Edm.TypeUsage argument5Type, System.Data.Metadata.Edm.TypeUsage argument6Type, System.Data.Metadata.Edm.TypeUsage argument7Type, System.Data.Metadata.Edm.TypeUsage argument8Type, System.Data.Metadata.Edm.TypeUsage argument9Type, System.Data.Metadata.Edm.TypeUsage argument10Type, System.Data.Metadata.Edm.TypeUsage argument11Type, System.Data.Metadata.Edm.TypeUsage argument12Type, System.Data.Metadata.Edm.TypeUsage argument13Type, System.Data.Metadata.Edm.TypeUsage argument14Type, System.Data.Metadata.Edm.TypeUsage argument15Type, System.Data.Metadata.Edm.TypeUsage argument16Type, System.Func<System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression> lambdaFunction) { return default(System.Data.Common.CommandTrees.DbLambda); }
    public static System.Data.Common.CommandTrees.DbLambda Create(System.Data.Metadata.Edm.TypeUsage argument1Type, System.Data.Metadata.Edm.TypeUsage argument2Type, System.Data.Metadata.Edm.TypeUsage argument3Type, System.Data.Metadata.Edm.TypeUsage argument4Type, System.Data.Metadata.Edm.TypeUsage argument5Type, System.Data.Metadata.Edm.TypeUsage argument6Type, System.Data.Metadata.Edm.TypeUsage argument7Type, System.Data.Metadata.Edm.TypeUsage argument8Type, System.Data.Metadata.Edm.TypeUsage argument9Type, System.Data.Metadata.Edm.TypeUsage argument10Type, System.Data.Metadata.Edm.TypeUsage argument11Type, System.Data.Metadata.Edm.TypeUsage argument12Type, System.Data.Metadata.Edm.TypeUsage argument13Type, System.Data.Metadata.Edm.TypeUsage argument14Type, System.Data.Metadata.Edm.TypeUsage argument15Type, System.Func<System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression> lambdaFunction) { return default(System.Data.Common.CommandTrees.DbLambda); }
    public static System.Data.Common.CommandTrees.DbLambda Create(System.Data.Metadata.Edm.TypeUsage argument1Type, System.Data.Metadata.Edm.TypeUsage argument2Type, System.Data.Metadata.Edm.TypeUsage argument3Type, System.Data.Metadata.Edm.TypeUsage argument4Type, System.Data.Metadata.Edm.TypeUsage argument5Type, System.Data.Metadata.Edm.TypeUsage argument6Type, System.Data.Metadata.Edm.TypeUsage argument7Type, System.Data.Metadata.Edm.TypeUsage argument8Type, System.Data.Metadata.Edm.TypeUsage argument9Type, System.Data.Metadata.Edm.TypeUsage argument10Type, System.Data.Metadata.Edm.TypeUsage argument11Type, System.Data.Metadata.Edm.TypeUsage argument12Type, System.Data.Metadata.Edm.TypeUsage argument13Type, System.Data.Metadata.Edm.TypeUsage argument14Type, System.Func<System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression> lambdaFunction) { return default(System.Data.Common.CommandTrees.DbLambda); }
    public static System.Data.Common.CommandTrees.DbLambda Create(System.Data.Metadata.Edm.TypeUsage argument1Type, System.Data.Metadata.Edm.TypeUsage argument2Type, System.Data.Metadata.Edm.TypeUsage argument3Type, System.Data.Metadata.Edm.TypeUsage argument4Type, System.Data.Metadata.Edm.TypeUsage argument5Type, System.Data.Metadata.Edm.TypeUsage argument6Type, System.Data.Metadata.Edm.TypeUsage argument7Type, System.Data.Metadata.Edm.TypeUsage argument8Type, System.Data.Metadata.Edm.TypeUsage argument9Type, System.Data.Metadata.Edm.TypeUsage argument10Type, System.Data.Metadata.Edm.TypeUsage argument11Type, System.Data.Metadata.Edm.TypeUsage argument12Type, System.Data.Metadata.Edm.TypeUsage argument13Type, System.Func<System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression> lambdaFunction) { return default(System.Data.Common.CommandTrees.DbLambda); }
    public static System.Data.Common.CommandTrees.DbLambda Create(System.Data.Metadata.Edm.TypeUsage argument1Type, System.Data.Metadata.Edm.TypeUsage argument2Type, System.Data.Metadata.Edm.TypeUsage argument3Type, System.Data.Metadata.Edm.TypeUsage argument4Type, System.Data.Metadata.Edm.TypeUsage argument5Type, System.Data.Metadata.Edm.TypeUsage argument6Type, System.Data.Metadata.Edm.TypeUsage argument7Type, System.Data.Metadata.Edm.TypeUsage argument8Type, System.Data.Metadata.Edm.TypeUsage argument9Type, System.Data.Metadata.Edm.TypeUsage argument10Type, System.Data.Metadata.Edm.TypeUsage argument11Type, System.Data.Metadata.Edm.TypeUsage argument12Type, System.Func<System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression> lambdaFunction) { return default(System.Data.Common.CommandTrees.DbLambda); }
    public static System.Data.Common.CommandTrees.DbLambda Create(System.Data.Metadata.Edm.TypeUsage argument1Type, System.Data.Metadata.Edm.TypeUsage argument2Type, System.Data.Metadata.Edm.TypeUsage argument3Type, System.Data.Metadata.Edm.TypeUsage argument4Type, System.Data.Metadata.Edm.TypeUsage argument5Type, System.Data.Metadata.Edm.TypeUsage argument6Type, System.Data.Metadata.Edm.TypeUsage argument7Type, System.Data.Metadata.Edm.TypeUsage argument8Type, System.Data.Metadata.Edm.TypeUsage argument9Type, System.Data.Metadata.Edm.TypeUsage argument10Type, System.Data.Metadata.Edm.TypeUsage argument11Type, System.Func<System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression> lambdaFunction) { return default(System.Data.Common.CommandTrees.DbLambda); }
    public static System.Data.Common.CommandTrees.DbLambda Create(System.Data.Metadata.Edm.TypeUsage argument1Type, System.Data.Metadata.Edm.TypeUsage argument2Type, System.Data.Metadata.Edm.TypeUsage argument3Type, System.Data.Metadata.Edm.TypeUsage argument4Type, System.Data.Metadata.Edm.TypeUsage argument5Type, System.Data.Metadata.Edm.TypeUsage argument6Type, System.Data.Metadata.Edm.TypeUsage argument7Type, System.Data.Metadata.Edm.TypeUsage argument8Type, System.Data.Metadata.Edm.TypeUsage argument9Type, System.Data.Metadata.Edm.TypeUsage argument10Type, System.Func<System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression> lambdaFunction) { return default(System.Data.Common.CommandTrees.DbLambda); }
    public static System.Data.Common.CommandTrees.DbLambda Create(System.Data.Metadata.Edm.TypeUsage argument1Type, System.Data.Metadata.Edm.TypeUsage argument2Type, System.Data.Metadata.Edm.TypeUsage argument3Type, System.Data.Metadata.Edm.TypeUsage argument4Type, System.Data.Metadata.Edm.TypeUsage argument5Type, System.Data.Metadata.Edm.TypeUsage argument6Type, System.Data.Metadata.Edm.TypeUsage argument7Type, System.Data.Metadata.Edm.TypeUsage argument8Type, System.Data.Metadata.Edm.TypeUsage argument9Type, System.Func<System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression> lambdaFunction) { return default(System.Data.Common.CommandTrees.DbLambda); }
    public static System.Data.Common.CommandTrees.DbLambda Create(System.Data.Metadata.Edm.TypeUsage argument1Type, System.Data.Metadata.Edm.TypeUsage argument2Type, System.Data.Metadata.Edm.TypeUsage argument3Type, System.Data.Metadata.Edm.TypeUsage argument4Type, System.Data.Metadata.Edm.TypeUsage argument5Type, System.Data.Metadata.Edm.TypeUsage argument6Type, System.Data.Metadata.Edm.TypeUsage argument7Type, System.Data.Metadata.Edm.TypeUsage argument8Type, System.Func<System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression> lambdaFunction) { return default(System.Data.Common.CommandTrees.DbLambda); }
    public static System.Data.Common.CommandTrees.DbLambda Create(System.Data.Metadata.Edm.TypeUsage argument1Type, System.Data.Metadata.Edm.TypeUsage argument2Type, System.Data.Metadata.Edm.TypeUsage argument3Type, System.Data.Metadata.Edm.TypeUsage argument4Type, System.Data.Metadata.Edm.TypeUsage argument5Type, System.Data.Metadata.Edm.TypeUsage argument6Type, System.Data.Metadata.Edm.TypeUsage argument7Type, System.Func<System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression> lambdaFunction) { return default(System.Data.Common.CommandTrees.DbLambda); }
    public static System.Data.Common.CommandTrees.DbLambda Create(System.Data.Metadata.Edm.TypeUsage argument1Type, System.Data.Metadata.Edm.TypeUsage argument2Type, System.Data.Metadata.Edm.TypeUsage argument3Type, System.Data.Metadata.Edm.TypeUsage argument4Type, System.Data.Metadata.Edm.TypeUsage argument5Type, System.Data.Metadata.Edm.TypeUsage argument6Type, System.Func<System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression> lambdaFunction) { return default(System.Data.Common.CommandTrees.DbLambda); }
    public static System.Data.Common.CommandTrees.DbLambda Create(System.Data.Metadata.Edm.TypeUsage argument1Type, System.Data.Metadata.Edm.TypeUsage argument2Type, System.Data.Metadata.Edm.TypeUsage argument3Type, System.Data.Metadata.Edm.TypeUsage argument4Type, System.Data.Metadata.Edm.TypeUsage argument5Type, System.Func<System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression> lambdaFunction) { return default(System.Data.Common.CommandTrees.DbLambda); }
    public static System.Data.Common.CommandTrees.DbLambda Create(System.Data.Metadata.Edm.TypeUsage argument1Type, System.Data.Metadata.Edm.TypeUsage argument2Type, System.Data.Metadata.Edm.TypeUsage argument3Type, System.Data.Metadata.Edm.TypeUsage argument4Type, System.Func<System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression> lambdaFunction) { return default(System.Data.Common.CommandTrees.DbLambda); }
    public static System.Data.Common.CommandTrees.DbLambda Create(System.Data.Metadata.Edm.TypeUsage argument1Type, System.Data.Metadata.Edm.TypeUsage argument2Type, System.Data.Metadata.Edm.TypeUsage argument3Type, System.Func<System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression> lambdaFunction) { return default(System.Data.Common.CommandTrees.DbLambda); }
    public static System.Data.Common.CommandTrees.DbLambda Create(System.Data.Metadata.Edm.TypeUsage argument1Type, System.Data.Metadata.Edm.TypeUsage argument2Type, System.Func<System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression> lambdaFunction) { return default(System.Data.Common.CommandTrees.DbLambda); }
    public static System.Data.Common.CommandTrees.DbLambda Create(System.Data.Metadata.Edm.TypeUsage argument1Type, System.Func<System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression> lambdaFunction) { return default(System.Data.Common.CommandTrees.DbLambda); }
  }
  public sealed partial class DbLambdaExpression : System.Data.Common.CommandTrees.DbExpression {
    internal DbLambdaExpression() { }
    public System.Collections.Generic.IList<System.Data.Common.CommandTrees.DbExpression> Arguments { get { return default(System.Collections.Generic.IList<System.Data.Common.CommandTrees.DbExpression>); } }
    public System.Data.Common.CommandTrees.DbLambda Lambda { get { return default(System.Data.Common.CommandTrees.DbLambda); } }
    public override void Accept(System.Data.Common.CommandTrees.DbExpressionVisitor visitor) { }
    public override TResultType Accept<TResultType>(System.Data.Common.CommandTrees.DbExpressionVisitor<TResultType> visitor) { return default(TResultType); }
  }
  public sealed partial class DbLikeExpression : System.Data.Common.CommandTrees.DbExpression {
    internal DbLikeExpression() { }
    public System.Data.Common.CommandTrees.DbExpression Argument { get { return default(System.Data.Common.CommandTrees.DbExpression); } }
    public System.Data.Common.CommandTrees.DbExpression Escape { get { return default(System.Data.Common.CommandTrees.DbExpression); } }
    public System.Data.Common.CommandTrees.DbExpression Pattern { get { return default(System.Data.Common.CommandTrees.DbExpression); } }
    public override void Accept(System.Data.Common.CommandTrees.DbExpressionVisitor visitor) { }
    public override TResultType Accept<TResultType>(System.Data.Common.CommandTrees.DbExpressionVisitor<TResultType> visitor) { return default(TResultType); }
  }
  public sealed partial class DbLimitExpression : System.Data.Common.CommandTrees.DbExpression {
    internal DbLimitExpression() { }
    public System.Data.Common.CommandTrees.DbExpression Argument { get { return default(System.Data.Common.CommandTrees.DbExpression); } }
    public System.Data.Common.CommandTrees.DbExpression Limit { get { return default(System.Data.Common.CommandTrees.DbExpression); } }
    public bool WithTies { get { return default(bool); } }
    public override void Accept(System.Data.Common.CommandTrees.DbExpressionVisitor visitor) { }
    public override TResultType Accept<TResultType>(System.Data.Common.CommandTrees.DbExpressionVisitor<TResultType> visitor) { return default(TResultType); }
  }
  public abstract partial class DbModificationClause {
    internal DbModificationClause() { }
  }
  public abstract partial class DbModificationCommandTree : System.Data.Common.CommandTrees.DbCommandTree {
    internal DbModificationCommandTree() { }
    public System.Data.Common.CommandTrees.DbExpressionBinding Target { get { return default(System.Data.Common.CommandTrees.DbExpressionBinding); } }
  }
  public sealed partial class DbNewInstanceExpression : System.Data.Common.CommandTrees.DbExpression {
    internal DbNewInstanceExpression() { }
    public System.Collections.Generic.IList<System.Data.Common.CommandTrees.DbExpression> Arguments { get { return default(System.Collections.Generic.IList<System.Data.Common.CommandTrees.DbExpression>); } }
    public override void Accept(System.Data.Common.CommandTrees.DbExpressionVisitor visitor) { }
    public override TResultType Accept<TResultType>(System.Data.Common.CommandTrees.DbExpressionVisitor<TResultType> visitor) { return default(TResultType); }
  }
  public sealed partial class DbNotExpression : System.Data.Common.CommandTrees.DbUnaryExpression {
    internal DbNotExpression() { }
    public override void Accept(System.Data.Common.CommandTrees.DbExpressionVisitor visitor) { }
    public override TResultType Accept<TResultType>(System.Data.Common.CommandTrees.DbExpressionVisitor<TResultType> visitor) { return default(TResultType); }
  }
  public sealed partial class DbNullExpression : System.Data.Common.CommandTrees.DbExpression {
    internal DbNullExpression() { }
    public override void Accept(System.Data.Common.CommandTrees.DbExpressionVisitor visitor) { }
    public override TResultType Accept<TResultType>(System.Data.Common.CommandTrees.DbExpressionVisitor<TResultType> visitor) { return default(TResultType); }
  }
  public sealed partial class DbOfTypeExpression : System.Data.Common.CommandTrees.DbUnaryExpression {
    internal DbOfTypeExpression() { }
    public System.Data.Metadata.Edm.TypeUsage OfType { get { return default(System.Data.Metadata.Edm.TypeUsage); } }
    public override void Accept(System.Data.Common.CommandTrees.DbExpressionVisitor visitor) { }
    public override TResultType Accept<TResultType>(System.Data.Common.CommandTrees.DbExpressionVisitor<TResultType> visitor) { return default(TResultType); }
  }
  public sealed partial class DbOrExpression : System.Data.Common.CommandTrees.DbBinaryExpression {
    internal DbOrExpression() { }
    public override void Accept(System.Data.Common.CommandTrees.DbExpressionVisitor visitor) { }
    public override TResultType Accept<TResultType>(System.Data.Common.CommandTrees.DbExpressionVisitor<TResultType> visitor) { return default(TResultType); }
  }
  public sealed partial class DbParameterReferenceExpression : System.Data.Common.CommandTrees.DbExpression {
    internal DbParameterReferenceExpression() { }
    public string ParameterName { get { return default(string); } }
    public override void Accept(System.Data.Common.CommandTrees.DbExpressionVisitor visitor) { }
    public override TResultType Accept<TResultType>(System.Data.Common.CommandTrees.DbExpressionVisitor<TResultType> visitor) { return default(TResultType); }
  }
  public sealed partial class DbProjectExpression : System.Data.Common.CommandTrees.DbExpression {
    internal DbProjectExpression() { }
    public System.Data.Common.CommandTrees.DbExpressionBinding Input { get { return default(System.Data.Common.CommandTrees.DbExpressionBinding); } }
    public System.Data.Common.CommandTrees.DbExpression Projection { get { return default(System.Data.Common.CommandTrees.DbExpression); } }
    public override void Accept(System.Data.Common.CommandTrees.DbExpressionVisitor visitor) { }
    public override TResultType Accept<TResultType>(System.Data.Common.CommandTrees.DbExpressionVisitor<TResultType> visitor) { return default(TResultType); }
  }
  public sealed partial class DbPropertyExpression : System.Data.Common.CommandTrees.DbExpression {
    internal DbPropertyExpression() { }
    public System.Data.Common.CommandTrees.DbExpression Instance { get { return default(System.Data.Common.CommandTrees.DbExpression); } }
    public System.Data.Metadata.Edm.EdmMember Property { get { return default(System.Data.Metadata.Edm.EdmMember); } }
    public override void Accept(System.Data.Common.CommandTrees.DbExpressionVisitor visitor) { }
    public override TResultType Accept<TResultType>(System.Data.Common.CommandTrees.DbExpressionVisitor<TResultType> visitor) { return default(TResultType); }
    public static implicit operator System.Collections.Generic.KeyValuePair<System.String, System.Data.Common.CommandTrees.DbExpression> (System.Data.Common.CommandTrees.DbPropertyExpression value) { return default(System.Collections.Generic.KeyValuePair<System.String, System.Data.Common.CommandTrees.DbExpression>); }
    public System.Collections.Generic.KeyValuePair<System.String, System.Data.Common.CommandTrees.DbExpression> ToKeyValuePair() { return default(System.Collections.Generic.KeyValuePair<System.String, System.Data.Common.CommandTrees.DbExpression>); }
  }
  public sealed partial class DbQuantifierExpression : System.Data.Common.CommandTrees.DbExpression {
    internal DbQuantifierExpression() { }
    public System.Data.Common.CommandTrees.DbExpressionBinding Input { get { return default(System.Data.Common.CommandTrees.DbExpressionBinding); } }
    public System.Data.Common.CommandTrees.DbExpression Predicate { get { return default(System.Data.Common.CommandTrees.DbExpression); } }
    public override void Accept(System.Data.Common.CommandTrees.DbExpressionVisitor visitor) { }
    public override TResultType Accept<TResultType>(System.Data.Common.CommandTrees.DbExpressionVisitor<TResultType> visitor) { return default(TResultType); }
  }
  public sealed partial class DbQueryCommandTree : System.Data.Common.CommandTrees.DbCommandTree {
    internal DbQueryCommandTree() { }
    public System.Data.Common.CommandTrees.DbExpression Query { get { return default(System.Data.Common.CommandTrees.DbExpression); } }
  }
  public sealed partial class DbRefExpression : System.Data.Common.CommandTrees.DbUnaryExpression {
    internal DbRefExpression() { }
    public System.Data.Metadata.Edm.EntitySet EntitySet { get { return default(System.Data.Metadata.Edm.EntitySet); } }
    public override void Accept(System.Data.Common.CommandTrees.DbExpressionVisitor visitor) { }
    public override TResultType Accept<TResultType>(System.Data.Common.CommandTrees.DbExpressionVisitor<TResultType> visitor) { return default(TResultType); }
  }
  public sealed partial class DbRefKeyExpression : System.Data.Common.CommandTrees.DbUnaryExpression {
    internal DbRefKeyExpression() { }
    public override void Accept(System.Data.Common.CommandTrees.DbExpressionVisitor visitor) { }
    public override TResultType Accept<TResultType>(System.Data.Common.CommandTrees.DbExpressionVisitor<TResultType> visitor) { return default(TResultType); }
  }
  public sealed partial class DbRelationshipNavigationExpression : System.Data.Common.CommandTrees.DbExpression {
    internal DbRelationshipNavigationExpression() { }
    public System.Data.Metadata.Edm.RelationshipEndMember NavigateFrom { get { return default(System.Data.Metadata.Edm.RelationshipEndMember); } }
    public System.Data.Metadata.Edm.RelationshipEndMember NavigateTo { get { return default(System.Data.Metadata.Edm.RelationshipEndMember); } }
    public System.Data.Common.CommandTrees.DbExpression NavigationSource { get { return default(System.Data.Common.CommandTrees.DbExpression); } }
    public System.Data.Metadata.Edm.RelationshipType Relationship { get { return default(System.Data.Metadata.Edm.RelationshipType); } }
    public override void Accept(System.Data.Common.CommandTrees.DbExpressionVisitor visitor) { }
    public override TResultType Accept<TResultType>(System.Data.Common.CommandTrees.DbExpressionVisitor<TResultType> visitor) { return default(TResultType); }
  }
  public sealed partial class DbScanExpression : System.Data.Common.CommandTrees.DbExpression {
    internal DbScanExpression() { }
    public System.Data.Metadata.Edm.EntitySetBase Target { get { return default(System.Data.Metadata.Edm.EntitySetBase); } }
    public override void Accept(System.Data.Common.CommandTrees.DbExpressionVisitor visitor) { }
    public override TResultType Accept<TResultType>(System.Data.Common.CommandTrees.DbExpressionVisitor<TResultType> visitor) { return default(TResultType); }
  }
  public sealed partial class DbSetClause : System.Data.Common.CommandTrees.DbModificationClause {
    internal DbSetClause() { }
    public System.Data.Common.CommandTrees.DbExpression Property { get { return default(System.Data.Common.CommandTrees.DbExpression); } }
    public System.Data.Common.CommandTrees.DbExpression Value { get { return default(System.Data.Common.CommandTrees.DbExpression); } }
  }
  public sealed partial class DbSkipExpression : System.Data.Common.CommandTrees.DbExpression {
    internal DbSkipExpression() { }
    public System.Data.Common.CommandTrees.DbExpression Count { get { return default(System.Data.Common.CommandTrees.DbExpression); } }
    public System.Data.Common.CommandTrees.DbExpressionBinding Input { get { return default(System.Data.Common.CommandTrees.DbExpressionBinding); } }
    public System.Collections.Generic.IList<System.Data.Common.CommandTrees.DbSortClause> SortOrder { get { return default(System.Collections.Generic.IList<System.Data.Common.CommandTrees.DbSortClause>); } }
    public override void Accept(System.Data.Common.CommandTrees.DbExpressionVisitor visitor) { }
    public override TResultType Accept<TResultType>(System.Data.Common.CommandTrees.DbExpressionVisitor<TResultType> visitor) { return default(TResultType); }
  }
  public sealed partial class DbSortClause {
    internal DbSortClause() { }
    public bool Ascending { get { return default(bool); } }
    public string Collation { get { return default(string); } }
    public System.Data.Common.CommandTrees.DbExpression Expression { get { return default(System.Data.Common.CommandTrees.DbExpression); } }
  }
  public sealed partial class DbSortExpression : System.Data.Common.CommandTrees.DbExpression {
    internal DbSortExpression() { }
    public System.Data.Common.CommandTrees.DbExpressionBinding Input { get { return default(System.Data.Common.CommandTrees.DbExpressionBinding); } }
    public System.Collections.Generic.IList<System.Data.Common.CommandTrees.DbSortClause> SortOrder { get { return default(System.Collections.Generic.IList<System.Data.Common.CommandTrees.DbSortClause>); } }
    public override void Accept(System.Data.Common.CommandTrees.DbExpressionVisitor visitor) { }
    public override TResultType Accept<TResultType>(System.Data.Common.CommandTrees.DbExpressionVisitor<TResultType> visitor) { return default(TResultType); }
  }
  public sealed partial class DbTreatExpression : System.Data.Common.CommandTrees.DbUnaryExpression {
    internal DbTreatExpression() { }
    public override void Accept(System.Data.Common.CommandTrees.DbExpressionVisitor visitor) { }
    public override TResultType Accept<TResultType>(System.Data.Common.CommandTrees.DbExpressionVisitor<TResultType> visitor) { return default(TResultType); }
  }
  public abstract partial class DbUnaryExpression : System.Data.Common.CommandTrees.DbExpression {
    internal DbUnaryExpression() { }
    public System.Data.Common.CommandTrees.DbExpression Argument { get { return default(System.Data.Common.CommandTrees.DbExpression); } }
  }
  public sealed partial class DbUnionAllExpression : System.Data.Common.CommandTrees.DbBinaryExpression {
    internal DbUnionAllExpression() { }
    public override void Accept(System.Data.Common.CommandTrees.DbExpressionVisitor visitor) { }
    public override TResultType Accept<TResultType>(System.Data.Common.CommandTrees.DbExpressionVisitor<TResultType> visitor) { return default(TResultType); }
  }
  public sealed partial class DbUpdateCommandTree : System.Data.Common.CommandTrees.DbModificationCommandTree {
    internal DbUpdateCommandTree() { }
    public System.Data.Common.CommandTrees.DbExpression Predicate { get { return default(System.Data.Common.CommandTrees.DbExpression); } }
    public System.Data.Common.CommandTrees.DbExpression Returning { get { return default(System.Data.Common.CommandTrees.DbExpression); } }
    public System.Collections.Generic.IList<System.Data.Common.CommandTrees.DbModificationClause> SetClauses { get { return default(System.Collections.Generic.IList<System.Data.Common.CommandTrees.DbModificationClause>); } }
  }
  public sealed partial class DbVariableReferenceExpression : System.Data.Common.CommandTrees.DbExpression {
    internal DbVariableReferenceExpression() { }
    public string VariableName { get { return default(string); } }
    public override void Accept(System.Data.Common.CommandTrees.DbExpressionVisitor visitor) { }
    public override TResultType Accept<TResultType>(System.Data.Common.CommandTrees.DbExpressionVisitor<TResultType> visitor) { return default(TResultType); }
  }
  public partial class DefaultExpressionVisitor : System.Data.Common.CommandTrees.DbExpressionVisitor<System.Data.Common.CommandTrees.DbExpression> {
    protected DefaultExpressionVisitor() { }
    protected virtual void OnEnterScope(System.Collections.Generic.IEnumerable<System.Data.Common.CommandTrees.DbVariableReferenceExpression> scopeVariables) { }
    protected virtual void OnExitScope() { }
    protected virtual void OnExpressionReplaced(System.Data.Common.CommandTrees.DbExpression oldExpression, System.Data.Common.CommandTrees.DbExpression newExpression) { }
    protected virtual void OnVariableRebound(System.Data.Common.CommandTrees.DbVariableReferenceExpression fromVarRef, System.Data.Common.CommandTrees.DbVariableReferenceExpression toVarRef) { }
    public override System.Data.Common.CommandTrees.DbExpression Visit(System.Data.Common.CommandTrees.DbAndExpression expression) { return default(System.Data.Common.CommandTrees.DbExpression); }
    public override System.Data.Common.CommandTrees.DbExpression Visit(System.Data.Common.CommandTrees.DbApplyExpression expression) { return default(System.Data.Common.CommandTrees.DbExpression); }
    public override System.Data.Common.CommandTrees.DbExpression Visit(System.Data.Common.CommandTrees.DbArithmeticExpression expression) { return default(System.Data.Common.CommandTrees.DbExpression); }
    public override System.Data.Common.CommandTrees.DbExpression Visit(System.Data.Common.CommandTrees.DbCaseExpression expression) { return default(System.Data.Common.CommandTrees.DbExpression); }
    public override System.Data.Common.CommandTrees.DbExpression Visit(System.Data.Common.CommandTrees.DbCastExpression expression) { return default(System.Data.Common.CommandTrees.DbExpression); }
    public override System.Data.Common.CommandTrees.DbExpression Visit(System.Data.Common.CommandTrees.DbComparisonExpression expression) { return default(System.Data.Common.CommandTrees.DbExpression); }
    public override System.Data.Common.CommandTrees.DbExpression Visit(System.Data.Common.CommandTrees.DbConstantExpression expression) { return default(System.Data.Common.CommandTrees.DbExpression); }
    public override System.Data.Common.CommandTrees.DbExpression Visit(System.Data.Common.CommandTrees.DbCrossJoinExpression expression) { return default(System.Data.Common.CommandTrees.DbExpression); }
    public override System.Data.Common.CommandTrees.DbExpression Visit(System.Data.Common.CommandTrees.DbDerefExpression expression) { return default(System.Data.Common.CommandTrees.DbExpression); }
    public override System.Data.Common.CommandTrees.DbExpression Visit(System.Data.Common.CommandTrees.DbDistinctExpression expression) { return default(System.Data.Common.CommandTrees.DbExpression); }
    public override System.Data.Common.CommandTrees.DbExpression Visit(System.Data.Common.CommandTrees.DbElementExpression expression) { return default(System.Data.Common.CommandTrees.DbExpression); }
    public override System.Data.Common.CommandTrees.DbExpression Visit(System.Data.Common.CommandTrees.DbEntityRefExpression expression) { return default(System.Data.Common.CommandTrees.DbExpression); }
    public override System.Data.Common.CommandTrees.DbExpression Visit(System.Data.Common.CommandTrees.DbExceptExpression expression) { return default(System.Data.Common.CommandTrees.DbExpression); }
    public override System.Data.Common.CommandTrees.DbExpression Visit(System.Data.Common.CommandTrees.DbExpression expression) { return default(System.Data.Common.CommandTrees.DbExpression); }
    public override System.Data.Common.CommandTrees.DbExpression Visit(System.Data.Common.CommandTrees.DbFilterExpression expression) { return default(System.Data.Common.CommandTrees.DbExpression); }
    public override System.Data.Common.CommandTrees.DbExpression Visit(System.Data.Common.CommandTrees.DbFunctionExpression expression) { return default(System.Data.Common.CommandTrees.DbExpression); }
    public override System.Data.Common.CommandTrees.DbExpression Visit(System.Data.Common.CommandTrees.DbGroupByExpression expression) { return default(System.Data.Common.CommandTrees.DbExpression); }
    public override System.Data.Common.CommandTrees.DbExpression Visit(System.Data.Common.CommandTrees.DbIntersectExpression expression) { return default(System.Data.Common.CommandTrees.DbExpression); }
    public override System.Data.Common.CommandTrees.DbExpression Visit(System.Data.Common.CommandTrees.DbIsEmptyExpression expression) { return default(System.Data.Common.CommandTrees.DbExpression); }
    public override System.Data.Common.CommandTrees.DbExpression Visit(System.Data.Common.CommandTrees.DbIsNullExpression expression) { return default(System.Data.Common.CommandTrees.DbExpression); }
    public override System.Data.Common.CommandTrees.DbExpression Visit(System.Data.Common.CommandTrees.DbIsOfExpression expression) { return default(System.Data.Common.CommandTrees.DbExpression); }
    public override System.Data.Common.CommandTrees.DbExpression Visit(System.Data.Common.CommandTrees.DbJoinExpression expression) { return default(System.Data.Common.CommandTrees.DbExpression); }
    public override System.Data.Common.CommandTrees.DbExpression Visit(System.Data.Common.CommandTrees.DbLambdaExpression expression) { return default(System.Data.Common.CommandTrees.DbExpression); }
    public override System.Data.Common.CommandTrees.DbExpression Visit(System.Data.Common.CommandTrees.DbLikeExpression expression) { return default(System.Data.Common.CommandTrees.DbExpression); }
    public override System.Data.Common.CommandTrees.DbExpression Visit(System.Data.Common.CommandTrees.DbLimitExpression expression) { return default(System.Data.Common.CommandTrees.DbExpression); }
    public override System.Data.Common.CommandTrees.DbExpression Visit(System.Data.Common.CommandTrees.DbNewInstanceExpression expression) { return default(System.Data.Common.CommandTrees.DbExpression); }
    public override System.Data.Common.CommandTrees.DbExpression Visit(System.Data.Common.CommandTrees.DbNotExpression expression) { return default(System.Data.Common.CommandTrees.DbExpression); }
    public override System.Data.Common.CommandTrees.DbExpression Visit(System.Data.Common.CommandTrees.DbNullExpression expression) { return default(System.Data.Common.CommandTrees.DbExpression); }
    public override System.Data.Common.CommandTrees.DbExpression Visit(System.Data.Common.CommandTrees.DbOfTypeExpression expression) { return default(System.Data.Common.CommandTrees.DbExpression); }
    public override System.Data.Common.CommandTrees.DbExpression Visit(System.Data.Common.CommandTrees.DbOrExpression expression) { return default(System.Data.Common.CommandTrees.DbExpression); }
    public override System.Data.Common.CommandTrees.DbExpression Visit(System.Data.Common.CommandTrees.DbParameterReferenceExpression expression) { return default(System.Data.Common.CommandTrees.DbExpression); }
    public override System.Data.Common.CommandTrees.DbExpression Visit(System.Data.Common.CommandTrees.DbProjectExpression expression) { return default(System.Data.Common.CommandTrees.DbExpression); }
    public override System.Data.Common.CommandTrees.DbExpression Visit(System.Data.Common.CommandTrees.DbPropertyExpression expression) { return default(System.Data.Common.CommandTrees.DbExpression); }
    public override System.Data.Common.CommandTrees.DbExpression Visit(System.Data.Common.CommandTrees.DbQuantifierExpression expression) { return default(System.Data.Common.CommandTrees.DbExpression); }
    public override System.Data.Common.CommandTrees.DbExpression Visit(System.Data.Common.CommandTrees.DbRefExpression expression) { return default(System.Data.Common.CommandTrees.DbExpression); }
    public override System.Data.Common.CommandTrees.DbExpression Visit(System.Data.Common.CommandTrees.DbRefKeyExpression expression) { return default(System.Data.Common.CommandTrees.DbExpression); }
    public override System.Data.Common.CommandTrees.DbExpression Visit(System.Data.Common.CommandTrees.DbRelationshipNavigationExpression expression) { return default(System.Data.Common.CommandTrees.DbExpression); }
    public override System.Data.Common.CommandTrees.DbExpression Visit(System.Data.Common.CommandTrees.DbScanExpression expression) { return default(System.Data.Common.CommandTrees.DbExpression); }
    public override System.Data.Common.CommandTrees.DbExpression Visit(System.Data.Common.CommandTrees.DbSkipExpression expression) { return default(System.Data.Common.CommandTrees.DbExpression); }
    public override System.Data.Common.CommandTrees.DbExpression Visit(System.Data.Common.CommandTrees.DbSortExpression expression) { return default(System.Data.Common.CommandTrees.DbExpression); }
    public override System.Data.Common.CommandTrees.DbExpression Visit(System.Data.Common.CommandTrees.DbTreatExpression expression) { return default(System.Data.Common.CommandTrees.DbExpression); }
    public override System.Data.Common.CommandTrees.DbExpression Visit(System.Data.Common.CommandTrees.DbUnionAllExpression expression) { return default(System.Data.Common.CommandTrees.DbExpression); }
    public override System.Data.Common.CommandTrees.DbExpression Visit(System.Data.Common.CommandTrees.DbVariableReferenceExpression expression) { return default(System.Data.Common.CommandTrees.DbExpression); }
    protected virtual System.Data.Common.CommandTrees.DbAggregate VisitAggregate(System.Data.Common.CommandTrees.DbAggregate aggregate) { return default(System.Data.Common.CommandTrees.DbAggregate); }
    protected virtual System.Data.Metadata.Edm.EntitySetBase VisitEntitySet(System.Data.Metadata.Edm.EntitySetBase entitySet) { return default(System.Data.Metadata.Edm.EntitySetBase); }
    protected virtual System.Data.Common.CommandTrees.DbExpression VisitExpression(System.Data.Common.CommandTrees.DbExpression expression) { return default(System.Data.Common.CommandTrees.DbExpression); }
    protected virtual System.Data.Common.CommandTrees.DbExpressionBinding VisitExpressionBinding(System.Data.Common.CommandTrees.DbExpressionBinding binding) { return default(System.Data.Common.CommandTrees.DbExpressionBinding); }
    protected virtual System.Collections.Generic.IList<System.Data.Common.CommandTrees.DbExpressionBinding> VisitExpressionBindingList(System.Collections.Generic.IList<System.Data.Common.CommandTrees.DbExpressionBinding> list) { return default(System.Collections.Generic.IList<System.Data.Common.CommandTrees.DbExpressionBinding>); }
    protected virtual System.Collections.Generic.IList<System.Data.Common.CommandTrees.DbExpression> VisitExpressionList(System.Collections.Generic.IList<System.Data.Common.CommandTrees.DbExpression> list) { return default(System.Collections.Generic.IList<System.Data.Common.CommandTrees.DbExpression>); }
    protected virtual System.Data.Metadata.Edm.EdmFunction VisitFunction(System.Data.Metadata.Edm.EdmFunction functionMetadata) { return default(System.Data.Metadata.Edm.EdmFunction); }
    protected virtual System.Data.Common.CommandTrees.DbFunctionAggregate VisitFunctionAggregate(System.Data.Common.CommandTrees.DbFunctionAggregate aggregate) { return default(System.Data.Common.CommandTrees.DbFunctionAggregate); }
    protected virtual System.Data.Common.CommandTrees.DbGroupAggregate VisitGroupAggregate(System.Data.Common.CommandTrees.DbGroupAggregate aggregate) { return default(System.Data.Common.CommandTrees.DbGroupAggregate); }
    protected virtual System.Data.Common.CommandTrees.DbGroupExpressionBinding VisitGroupExpressionBinding(System.Data.Common.CommandTrees.DbGroupExpressionBinding binding) { return default(System.Data.Common.CommandTrees.DbGroupExpressionBinding); }
    protected virtual System.Data.Common.CommandTrees.DbLambda VisitLambda(System.Data.Common.CommandTrees.DbLambda lambda) { return default(System.Data.Common.CommandTrees.DbLambda); }
    protected virtual System.Data.Common.CommandTrees.DbSortClause VisitSortClause(System.Data.Common.CommandTrees.DbSortClause clause) { return default(System.Data.Common.CommandTrees.DbSortClause); }
    protected virtual System.Collections.Generic.IList<System.Data.Common.CommandTrees.DbSortClause> VisitSortOrder(System.Collections.Generic.IList<System.Data.Common.CommandTrees.DbSortClause> sortOrder) { return default(System.Collections.Generic.IList<System.Data.Common.CommandTrees.DbSortClause>); }
    protected virtual System.Data.Metadata.Edm.EdmType VisitType(System.Data.Metadata.Edm.EdmType type) { return default(System.Data.Metadata.Edm.EdmType); }
    protected virtual System.Data.Metadata.Edm.TypeUsage VisitTypeUsage(System.Data.Metadata.Edm.TypeUsage type) { return default(System.Data.Metadata.Edm.TypeUsage); }
  }
}
namespace System.Data.Common.CommandTrees.ExpressionBuilder {
  public static partial class DbExpressionBuilder {
    public static System.Data.Common.CommandTrees.DbConstantExpression False { get { return default(System.Data.Common.CommandTrees.DbConstantExpression); } }
    public static System.Data.Common.CommandTrees.DbConstantExpression True { get { return default(System.Data.Common.CommandTrees.DbConstantExpression); } }
    public static System.Data.Common.CommandTrees.DbFunctionAggregate Aggregate(this System.Data.Metadata.Edm.EdmFunction function, System.Data.Common.CommandTrees.DbExpression argument) { return default(System.Data.Common.CommandTrees.DbFunctionAggregate); }
    public static System.Data.Common.CommandTrees.DbFunctionAggregate AggregateDistinct(this System.Data.Metadata.Edm.EdmFunction function, System.Data.Common.CommandTrees.DbExpression argument) { return default(System.Data.Common.CommandTrees.DbFunctionAggregate); }
    public static System.Data.Common.CommandTrees.DbQuantifierExpression All(this System.Data.Common.CommandTrees.DbExpression source, System.Func<System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression> predicate) { return default(System.Data.Common.CommandTrees.DbQuantifierExpression); }
    public static System.Data.Common.CommandTrees.DbQuantifierExpression All(this System.Data.Common.CommandTrees.DbExpressionBinding input, System.Data.Common.CommandTrees.DbExpression predicate) { return default(System.Data.Common.CommandTrees.DbQuantifierExpression); }
    public static System.Data.Common.CommandTrees.DbAndExpression And(this System.Data.Common.CommandTrees.DbExpression left, System.Data.Common.CommandTrees.DbExpression right) { return default(System.Data.Common.CommandTrees.DbAndExpression); }
    public static System.Data.Common.CommandTrees.DbExpression Any(this System.Data.Common.CommandTrees.DbExpression source) { return default(System.Data.Common.CommandTrees.DbExpression); }
    public static System.Data.Common.CommandTrees.DbQuantifierExpression Any(this System.Data.Common.CommandTrees.DbExpression source, System.Func<System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression> predicate) { return default(System.Data.Common.CommandTrees.DbQuantifierExpression); }
    public static System.Data.Common.CommandTrees.DbQuantifierExpression Any(this System.Data.Common.CommandTrees.DbExpressionBinding input, System.Data.Common.CommandTrees.DbExpression predicate) { return default(System.Data.Common.CommandTrees.DbQuantifierExpression); }
    public static System.Collections.Generic.KeyValuePair<System.String, System.Data.Common.CommandTrees.DbAggregate> As(this System.Data.Common.CommandTrees.DbAggregate value, string alias) { return default(System.Collections.Generic.KeyValuePair<System.String, System.Data.Common.CommandTrees.DbAggregate>); }
    public static System.Collections.Generic.KeyValuePair<System.String, System.Data.Common.CommandTrees.DbExpression> As(this System.Data.Common.CommandTrees.DbExpression value, string alias) { return default(System.Collections.Generic.KeyValuePair<System.String, System.Data.Common.CommandTrees.DbExpression>); }
    public static System.Data.Common.CommandTrees.DbExpressionBinding Bind(this System.Data.Common.CommandTrees.DbExpression input) { return default(System.Data.Common.CommandTrees.DbExpressionBinding); }
    public static System.Data.Common.CommandTrees.DbExpressionBinding BindAs(this System.Data.Common.CommandTrees.DbExpression input, string varName) { return default(System.Data.Common.CommandTrees.DbExpressionBinding); }
    public static System.Data.Common.CommandTrees.DbCaseExpression Case(System.Collections.Generic.IEnumerable<System.Data.Common.CommandTrees.DbExpression> whenExpressions, System.Collections.Generic.IEnumerable<System.Data.Common.CommandTrees.DbExpression> thenExpressions, System.Data.Common.CommandTrees.DbExpression elseExpression) { return default(System.Data.Common.CommandTrees.DbCaseExpression); }
    public static System.Data.Common.CommandTrees.DbCastExpression CastTo(this System.Data.Common.CommandTrees.DbExpression argument, System.Data.Metadata.Edm.TypeUsage toType) { return default(System.Data.Common.CommandTrees.DbCastExpression); }
    public static System.Data.Common.CommandTrees.DbConstantExpression Constant(this System.Data.Metadata.Edm.TypeUsage constantType, object value) { return default(System.Data.Common.CommandTrees.DbConstantExpression); }
    public static System.Data.Common.CommandTrees.DbConstantExpression Constant(object value) { return default(System.Data.Common.CommandTrees.DbConstantExpression); }
    public static System.Data.Common.CommandTrees.DbRefExpression CreateRef(this System.Data.Metadata.Edm.EntitySet entitySet, System.Collections.Generic.IEnumerable<System.Data.Common.CommandTrees.DbExpression> keyValues) { return default(System.Data.Common.CommandTrees.DbRefExpression); }
    public static System.Data.Common.CommandTrees.DbRefExpression CreateRef(this System.Data.Metadata.Edm.EntitySet entitySet, params System.Data.Common.CommandTrees.DbExpression[] keyValues) { return default(System.Data.Common.CommandTrees.DbRefExpression); }
    public static System.Data.Common.CommandTrees.DbRefExpression CreateRef(this System.Data.Metadata.Edm.EntitySet entitySet, System.Data.Metadata.Edm.EntityType entityType, System.Collections.Generic.IEnumerable<System.Data.Common.CommandTrees.DbExpression> keyValues) { return default(System.Data.Common.CommandTrees.DbRefExpression); }
    public static System.Data.Common.CommandTrees.DbRefExpression CreateRef(this System.Data.Metadata.Edm.EntitySet entitySet, System.Data.Metadata.Edm.EntityType entityType, params System.Data.Common.CommandTrees.DbExpression[] keyValues) { return default(System.Data.Common.CommandTrees.DbRefExpression); }
    public static System.Data.Common.CommandTrees.DbApplyExpression CrossApply(this System.Data.Common.CommandTrees.DbExpression source, System.Func<System.Data.Common.CommandTrees.DbExpression, System.Collections.Generic.KeyValuePair<System.String, System.Data.Common.CommandTrees.DbExpression>> apply) { return default(System.Data.Common.CommandTrees.DbApplyExpression); }
    public static System.Data.Common.CommandTrees.DbApplyExpression CrossApply(this System.Data.Common.CommandTrees.DbExpressionBinding input, System.Data.Common.CommandTrees.DbExpressionBinding apply) { return default(System.Data.Common.CommandTrees.DbApplyExpression); }
    public static System.Data.Common.CommandTrees.DbCrossJoinExpression CrossJoin(System.Collections.Generic.IEnumerable<System.Data.Common.CommandTrees.DbExpressionBinding> inputs) { return default(System.Data.Common.CommandTrees.DbCrossJoinExpression); }
    public static System.Data.Common.CommandTrees.DbDerefExpression Deref(this System.Data.Common.CommandTrees.DbExpression argument) { return default(System.Data.Common.CommandTrees.DbDerefExpression); }
    public static System.Data.Common.CommandTrees.DbDistinctExpression Distinct(this System.Data.Common.CommandTrees.DbExpression argument) { return default(System.Data.Common.CommandTrees.DbDistinctExpression); }
    public static System.Data.Common.CommandTrees.DbArithmeticExpression Divide(this System.Data.Common.CommandTrees.DbExpression left, System.Data.Common.CommandTrees.DbExpression right) { return default(System.Data.Common.CommandTrees.DbArithmeticExpression); }
    public static System.Data.Common.CommandTrees.DbElementExpression Element(this System.Data.Common.CommandTrees.DbExpression argument) { return default(System.Data.Common.CommandTrees.DbElementExpression); }
    public static System.Data.Common.CommandTrees.DbComparisonExpression Equal(this System.Data.Common.CommandTrees.DbExpression left, System.Data.Common.CommandTrees.DbExpression right) { return default(System.Data.Common.CommandTrees.DbComparisonExpression); }
    public static System.Data.Common.CommandTrees.DbExceptExpression Except(this System.Data.Common.CommandTrees.DbExpression left, System.Data.Common.CommandTrees.DbExpression right) { return default(System.Data.Common.CommandTrees.DbExceptExpression); }
    public static System.Data.Common.CommandTrees.DbExpression Exists(this System.Data.Common.CommandTrees.DbExpression argument) { return default(System.Data.Common.CommandTrees.DbExpression); }
    public static System.Data.Common.CommandTrees.DbFilterExpression Filter(this System.Data.Common.CommandTrees.DbExpressionBinding input, System.Data.Common.CommandTrees.DbExpression predicate) { return default(System.Data.Common.CommandTrees.DbFilterExpression); }
    public static System.Data.Common.CommandTrees.DbJoinExpression FullOuterJoin(this System.Data.Common.CommandTrees.DbExpression left, System.Data.Common.CommandTrees.DbExpression right, System.Func<System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression> joinCondition) { return default(System.Data.Common.CommandTrees.DbJoinExpression); }
    public static System.Data.Common.CommandTrees.DbJoinExpression FullOuterJoin(this System.Data.Common.CommandTrees.DbExpressionBinding left, System.Data.Common.CommandTrees.DbExpressionBinding right, System.Data.Common.CommandTrees.DbExpression joinCondition) { return default(System.Data.Common.CommandTrees.DbJoinExpression); }
    public static System.Data.Common.CommandTrees.DbEntityRefExpression GetEntityRef(this System.Data.Common.CommandTrees.DbExpression argument) { return default(System.Data.Common.CommandTrees.DbEntityRefExpression); }
    public static System.Data.Common.CommandTrees.DbRefKeyExpression GetRefKey(this System.Data.Common.CommandTrees.DbExpression argument) { return default(System.Data.Common.CommandTrees.DbRefKeyExpression); }
    public static System.Data.Common.CommandTrees.DbComparisonExpression GreaterThan(this System.Data.Common.CommandTrees.DbExpression left, System.Data.Common.CommandTrees.DbExpression right) { return default(System.Data.Common.CommandTrees.DbComparisonExpression); }
    public static System.Data.Common.CommandTrees.DbComparisonExpression GreaterThanOrEqual(this System.Data.Common.CommandTrees.DbExpression left, System.Data.Common.CommandTrees.DbExpression right) { return default(System.Data.Common.CommandTrees.DbComparisonExpression); }
    public static System.Data.Common.CommandTrees.DbGroupExpressionBinding GroupBind(this System.Data.Common.CommandTrees.DbExpression input) { return default(System.Data.Common.CommandTrees.DbGroupExpressionBinding); }
    public static System.Data.Common.CommandTrees.DbGroupExpressionBinding GroupBindAs(this System.Data.Common.CommandTrees.DbExpression input, string varName, string groupVarName) { return default(System.Data.Common.CommandTrees.DbGroupExpressionBinding); }
    public static System.Data.Common.CommandTrees.DbGroupByExpression GroupBy(this System.Data.Common.CommandTrees.DbGroupExpressionBinding input, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Data.Common.CommandTrees.DbExpression>> keys, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Data.Common.CommandTrees.DbAggregate>> aggregates) { return default(System.Data.Common.CommandTrees.DbGroupByExpression); }
    public static System.Data.Common.CommandTrees.DbJoinExpression InnerJoin(this System.Data.Common.CommandTrees.DbExpression left, System.Data.Common.CommandTrees.DbExpression right, System.Func<System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression> joinCondition) { return default(System.Data.Common.CommandTrees.DbJoinExpression); }
    public static System.Data.Common.CommandTrees.DbJoinExpression InnerJoin(this System.Data.Common.CommandTrees.DbExpressionBinding left, System.Data.Common.CommandTrees.DbExpressionBinding right, System.Data.Common.CommandTrees.DbExpression joinCondition) { return default(System.Data.Common.CommandTrees.DbJoinExpression); }
    public static System.Data.Common.CommandTrees.DbIntersectExpression Intersect(this System.Data.Common.CommandTrees.DbExpression left, System.Data.Common.CommandTrees.DbExpression right) { return default(System.Data.Common.CommandTrees.DbIntersectExpression); }
    public static System.Data.Common.CommandTrees.DbLambdaExpression Invoke(this System.Data.Common.CommandTrees.DbLambda lambda, System.Collections.Generic.IEnumerable<System.Data.Common.CommandTrees.DbExpression> arguments) { return default(System.Data.Common.CommandTrees.DbLambdaExpression); }
    public static System.Data.Common.CommandTrees.DbLambdaExpression Invoke(this System.Data.Common.CommandTrees.DbLambda lambda, params System.Data.Common.CommandTrees.DbExpression[] arguments) { return default(System.Data.Common.CommandTrees.DbLambdaExpression); }
    public static System.Data.Common.CommandTrees.DbFunctionExpression Invoke(this System.Data.Metadata.Edm.EdmFunction function, System.Collections.Generic.IEnumerable<System.Data.Common.CommandTrees.DbExpression> arguments) { return default(System.Data.Common.CommandTrees.DbFunctionExpression); }
    public static System.Data.Common.CommandTrees.DbFunctionExpression Invoke(this System.Data.Metadata.Edm.EdmFunction function, params System.Data.Common.CommandTrees.DbExpression[] arguments) { return default(System.Data.Common.CommandTrees.DbFunctionExpression); }
    public static System.Data.Common.CommandTrees.DbIsEmptyExpression IsEmpty(this System.Data.Common.CommandTrees.DbExpression argument) { return default(System.Data.Common.CommandTrees.DbIsEmptyExpression); }
    public static System.Data.Common.CommandTrees.DbIsNullExpression IsNull(this System.Data.Common.CommandTrees.DbExpression argument) { return default(System.Data.Common.CommandTrees.DbIsNullExpression); }
    public static System.Data.Common.CommandTrees.DbIsOfExpression IsOf(this System.Data.Common.CommandTrees.DbExpression argument, System.Data.Metadata.Edm.TypeUsage type) { return default(System.Data.Common.CommandTrees.DbIsOfExpression); }
    public static System.Data.Common.CommandTrees.DbIsOfExpression IsOfOnly(this System.Data.Common.CommandTrees.DbExpression argument, System.Data.Metadata.Edm.TypeUsage type) { return default(System.Data.Common.CommandTrees.DbIsOfExpression); }
    public static System.Data.Common.CommandTrees.DbJoinExpression Join(this System.Data.Common.CommandTrees.DbExpression outer, System.Data.Common.CommandTrees.DbExpression inner, System.Func<System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression> outerKey, System.Func<System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression> innerKey) { return default(System.Data.Common.CommandTrees.DbJoinExpression); }
    public static System.Data.Common.CommandTrees.DbProjectExpression Join<TSelector>(this System.Data.Common.CommandTrees.DbExpression outer, System.Data.Common.CommandTrees.DbExpression inner, System.Func<System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression> outerKey, System.Func<System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression> innerKey, System.Func<System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, TSelector> selector) { return default(System.Data.Common.CommandTrees.DbProjectExpression); }
    public static System.Data.Common.CommandTrees.DbLambda Lambda(System.Data.Common.CommandTrees.DbExpression body, System.Collections.Generic.IEnumerable<System.Data.Common.CommandTrees.DbVariableReferenceExpression> variables) { return default(System.Data.Common.CommandTrees.DbLambda); }
    public static System.Data.Common.CommandTrees.DbLambda Lambda(System.Data.Common.CommandTrees.DbExpression body, params System.Data.Common.CommandTrees.DbVariableReferenceExpression[] variables) { return default(System.Data.Common.CommandTrees.DbLambda); }
    public static System.Data.Common.CommandTrees.DbJoinExpression LeftOuterJoin(this System.Data.Common.CommandTrees.DbExpression left, System.Data.Common.CommandTrees.DbExpression right, System.Func<System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression> joinCondition) { return default(System.Data.Common.CommandTrees.DbJoinExpression); }
    public static System.Data.Common.CommandTrees.DbJoinExpression LeftOuterJoin(this System.Data.Common.CommandTrees.DbExpressionBinding left, System.Data.Common.CommandTrees.DbExpressionBinding right, System.Data.Common.CommandTrees.DbExpression joinCondition) { return default(System.Data.Common.CommandTrees.DbJoinExpression); }
    public static System.Data.Common.CommandTrees.DbComparisonExpression LessThan(this System.Data.Common.CommandTrees.DbExpression left, System.Data.Common.CommandTrees.DbExpression right) { return default(System.Data.Common.CommandTrees.DbComparisonExpression); }
    public static System.Data.Common.CommandTrees.DbComparisonExpression LessThanOrEqual(this System.Data.Common.CommandTrees.DbExpression left, System.Data.Common.CommandTrees.DbExpression right) { return default(System.Data.Common.CommandTrees.DbComparisonExpression); }
    public static System.Data.Common.CommandTrees.DbLikeExpression Like(this System.Data.Common.CommandTrees.DbExpression argument, System.Data.Common.CommandTrees.DbExpression pattern) { return default(System.Data.Common.CommandTrees.DbLikeExpression); }
    public static System.Data.Common.CommandTrees.DbLikeExpression Like(this System.Data.Common.CommandTrees.DbExpression argument, System.Data.Common.CommandTrees.DbExpression pattern, System.Data.Common.CommandTrees.DbExpression escape) { return default(System.Data.Common.CommandTrees.DbLikeExpression); }
    public static System.Data.Common.CommandTrees.DbLimitExpression Limit(this System.Data.Common.CommandTrees.DbExpression argument, System.Data.Common.CommandTrees.DbExpression count) { return default(System.Data.Common.CommandTrees.DbLimitExpression); }
    public static System.Data.Common.CommandTrees.DbArithmeticExpression Minus(this System.Data.Common.CommandTrees.DbExpression left, System.Data.Common.CommandTrees.DbExpression right) { return default(System.Data.Common.CommandTrees.DbArithmeticExpression); }
    public static System.Data.Common.CommandTrees.DbArithmeticExpression Modulo(this System.Data.Common.CommandTrees.DbExpression left, System.Data.Common.CommandTrees.DbExpression right) { return default(System.Data.Common.CommandTrees.DbArithmeticExpression); }
    public static System.Data.Common.CommandTrees.DbArithmeticExpression Multiply(this System.Data.Common.CommandTrees.DbExpression left, System.Data.Common.CommandTrees.DbExpression right) { return default(System.Data.Common.CommandTrees.DbArithmeticExpression); }
    public static System.Data.Common.CommandTrees.DbRelationshipNavigationExpression Navigate(this System.Data.Common.CommandTrees.DbExpression navigateFrom, System.Data.Metadata.Edm.RelationshipEndMember fromEnd, System.Data.Metadata.Edm.RelationshipEndMember toEnd) { return default(System.Data.Common.CommandTrees.DbRelationshipNavigationExpression); }
    public static System.Data.Common.CommandTrees.DbRelationshipNavigationExpression Navigate(this System.Data.Metadata.Edm.RelationshipType type, string fromEndName, string toEndName, System.Data.Common.CommandTrees.DbExpression navigateFrom) { return default(System.Data.Common.CommandTrees.DbRelationshipNavigationExpression); }
    public static System.Data.Common.CommandTrees.DbArithmeticExpression Negate(this System.Data.Common.CommandTrees.DbExpression argument) { return default(System.Data.Common.CommandTrees.DbArithmeticExpression); }
    public static System.Data.Common.CommandTrees.DbNewInstanceExpression New(this System.Data.Metadata.Edm.TypeUsage instanceType, System.Collections.Generic.IEnumerable<System.Data.Common.CommandTrees.DbExpression> arguments) { return default(System.Data.Common.CommandTrees.DbNewInstanceExpression); }
    public static System.Data.Common.CommandTrees.DbNewInstanceExpression New(this System.Data.Metadata.Edm.TypeUsage instanceType, params System.Data.Common.CommandTrees.DbExpression[] arguments) { return default(System.Data.Common.CommandTrees.DbNewInstanceExpression); }
    public static System.Data.Common.CommandTrees.DbNewInstanceExpression NewCollection(System.Collections.Generic.IEnumerable<System.Data.Common.CommandTrees.DbExpression> elements) { return default(System.Data.Common.CommandTrees.DbNewInstanceExpression); }
    public static System.Data.Common.CommandTrees.DbNewInstanceExpression NewCollection(params System.Data.Common.CommandTrees.DbExpression[] elements) { return default(System.Data.Common.CommandTrees.DbNewInstanceExpression); }
    public static System.Data.Common.CommandTrees.DbNewInstanceExpression NewEmptyCollection(this System.Data.Metadata.Edm.TypeUsage collectionType) { return default(System.Data.Common.CommandTrees.DbNewInstanceExpression); }
    public static System.Data.Common.CommandTrees.DbNewInstanceExpression NewRow(System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Data.Common.CommandTrees.DbExpression>> columnValues) { return default(System.Data.Common.CommandTrees.DbNewInstanceExpression); }
    public static System.Data.Common.CommandTrees.DbNotExpression Not(this System.Data.Common.CommandTrees.DbExpression argument) { return default(System.Data.Common.CommandTrees.DbNotExpression); }
    public static System.Data.Common.CommandTrees.DbComparisonExpression NotEqual(this System.Data.Common.CommandTrees.DbExpression left, System.Data.Common.CommandTrees.DbExpression right) { return default(System.Data.Common.CommandTrees.DbComparisonExpression); }
    public static System.Data.Common.CommandTrees.DbNullExpression Null(this System.Data.Metadata.Edm.TypeUsage nullType) { return default(System.Data.Common.CommandTrees.DbNullExpression); }
    public static System.Data.Common.CommandTrees.DbOfTypeExpression OfType(this System.Data.Common.CommandTrees.DbExpression argument, System.Data.Metadata.Edm.TypeUsage type) { return default(System.Data.Common.CommandTrees.DbOfTypeExpression); }
    public static System.Data.Common.CommandTrees.DbOfTypeExpression OfTypeOnly(this System.Data.Common.CommandTrees.DbExpression argument, System.Data.Metadata.Edm.TypeUsage type) { return default(System.Data.Common.CommandTrees.DbOfTypeExpression); }
    public static System.Data.Common.CommandTrees.DbOrExpression Or(this System.Data.Common.CommandTrees.DbExpression left, System.Data.Common.CommandTrees.DbExpression right) { return default(System.Data.Common.CommandTrees.DbOrExpression); }
    public static System.Data.Common.CommandTrees.DbSortExpression OrderBy(this System.Data.Common.CommandTrees.DbExpression source, System.Func<System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression> sortKey) { return default(System.Data.Common.CommandTrees.DbSortExpression); }
    public static System.Data.Common.CommandTrees.DbSortExpression OrderBy(this System.Data.Common.CommandTrees.DbExpression source, System.Func<System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression> sortKey, string collation) { return default(System.Data.Common.CommandTrees.DbSortExpression); }
    public static System.Data.Common.CommandTrees.DbSortExpression OrderByDescending(this System.Data.Common.CommandTrees.DbExpression source, System.Func<System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression> sortKey) { return default(System.Data.Common.CommandTrees.DbSortExpression); }
    public static System.Data.Common.CommandTrees.DbSortExpression OrderByDescending(this System.Data.Common.CommandTrees.DbExpression source, System.Func<System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression> sortKey, string collation) { return default(System.Data.Common.CommandTrees.DbSortExpression); }
    public static System.Data.Common.CommandTrees.DbApplyExpression OuterApply(this System.Data.Common.CommandTrees.DbExpression source, System.Func<System.Data.Common.CommandTrees.DbExpression, System.Collections.Generic.KeyValuePair<System.String, System.Data.Common.CommandTrees.DbExpression>> apply) { return default(System.Data.Common.CommandTrees.DbApplyExpression); }
    public static System.Data.Common.CommandTrees.DbApplyExpression OuterApply(this System.Data.Common.CommandTrees.DbExpressionBinding input, System.Data.Common.CommandTrees.DbExpressionBinding apply) { return default(System.Data.Common.CommandTrees.DbApplyExpression); }
    public static System.Data.Common.CommandTrees.DbParameterReferenceExpression Parameter(this System.Data.Metadata.Edm.TypeUsage type, string name) { return default(System.Data.Common.CommandTrees.DbParameterReferenceExpression); }
    public static System.Data.Common.CommandTrees.DbArithmeticExpression Plus(this System.Data.Common.CommandTrees.DbExpression left, System.Data.Common.CommandTrees.DbExpression right) { return default(System.Data.Common.CommandTrees.DbArithmeticExpression); }
    public static System.Data.Common.CommandTrees.DbProjectExpression Project(this System.Data.Common.CommandTrees.DbExpressionBinding input, System.Data.Common.CommandTrees.DbExpression projection) { return default(System.Data.Common.CommandTrees.DbProjectExpression); }
    public static System.Data.Common.CommandTrees.DbPropertyExpression Property(this System.Data.Common.CommandTrees.DbExpression instance, System.Data.Metadata.Edm.EdmProperty propertyMetadata) { return default(System.Data.Common.CommandTrees.DbPropertyExpression); }
    public static System.Data.Common.CommandTrees.DbPropertyExpression Property(this System.Data.Common.CommandTrees.DbExpression instance, System.Data.Metadata.Edm.NavigationProperty navigationProperty) { return default(System.Data.Common.CommandTrees.DbPropertyExpression); }
    public static System.Data.Common.CommandTrees.DbPropertyExpression Property(this System.Data.Common.CommandTrees.DbExpression instance, System.Data.Metadata.Edm.RelationshipEndMember relationshipEnd) { return default(System.Data.Common.CommandTrees.DbPropertyExpression); }
    public static System.Data.Common.CommandTrees.DbPropertyExpression Property(this System.Data.Common.CommandTrees.DbExpression instance, string propertyName) { return default(System.Data.Common.CommandTrees.DbPropertyExpression); }
    public static System.Data.Common.CommandTrees.DbRefExpression RefFromKey(this System.Data.Metadata.Edm.EntitySet entitySet, System.Data.Common.CommandTrees.DbExpression keyRow) { return default(System.Data.Common.CommandTrees.DbRefExpression); }
    public static System.Data.Common.CommandTrees.DbRefExpression RefFromKey(this System.Data.Metadata.Edm.EntitySet entitySet, System.Data.Common.CommandTrees.DbExpression keyRow, System.Data.Metadata.Edm.EntityType entityType) { return default(System.Data.Common.CommandTrees.DbRefExpression); }
    public static System.Data.Common.CommandTrees.DbScanExpression Scan(this System.Data.Metadata.Edm.EntitySetBase targetSet) { return default(System.Data.Common.CommandTrees.DbScanExpression); }
    public static System.Data.Common.CommandTrees.DbProjectExpression Select<TProjection>(this System.Data.Common.CommandTrees.DbExpression source, System.Func<System.Data.Common.CommandTrees.DbExpression, TProjection> projection) { return default(System.Data.Common.CommandTrees.DbProjectExpression); }
    public static System.Data.Common.CommandTrees.DbProjectExpression SelectMany(this System.Data.Common.CommandTrees.DbExpression source, System.Func<System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression> apply) { return default(System.Data.Common.CommandTrees.DbProjectExpression); }
    public static System.Data.Common.CommandTrees.DbProjectExpression SelectMany<TSelector>(this System.Data.Common.CommandTrees.DbExpression source, System.Func<System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression> apply, System.Func<System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, TSelector> selector) { return default(System.Data.Common.CommandTrees.DbProjectExpression); }
    public static System.Data.Common.CommandTrees.DbSkipExpression Skip(this System.Data.Common.CommandTrees.DbExpressionBinding input, System.Collections.Generic.IEnumerable<System.Data.Common.CommandTrees.DbSortClause> sortOrder, System.Data.Common.CommandTrees.DbExpression count) { return default(System.Data.Common.CommandTrees.DbSkipExpression); }
    public static System.Data.Common.CommandTrees.DbSkipExpression Skip(this System.Data.Common.CommandTrees.DbSortExpression argument, System.Data.Common.CommandTrees.DbExpression count) { return default(System.Data.Common.CommandTrees.DbSkipExpression); }
    public static System.Data.Common.CommandTrees.DbSortExpression Sort(this System.Data.Common.CommandTrees.DbExpressionBinding input, System.Collections.Generic.IEnumerable<System.Data.Common.CommandTrees.DbSortClause> sortOrder) { return default(System.Data.Common.CommandTrees.DbSortExpression); }
    public static System.Data.Common.CommandTrees.DbLimitExpression Take(this System.Data.Common.CommandTrees.DbExpression argument, System.Data.Common.CommandTrees.DbExpression count) { return default(System.Data.Common.CommandTrees.DbLimitExpression); }
    public static System.Data.Common.CommandTrees.DbSortExpression ThenBy(this System.Data.Common.CommandTrees.DbSortExpression source, System.Func<System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression> sortKey) { return default(System.Data.Common.CommandTrees.DbSortExpression); }
    public static System.Data.Common.CommandTrees.DbSortExpression ThenBy(this System.Data.Common.CommandTrees.DbSortExpression source, System.Func<System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression> sortKey, string collation) { return default(System.Data.Common.CommandTrees.DbSortExpression); }
    public static System.Data.Common.CommandTrees.DbSortExpression ThenByDescending(this System.Data.Common.CommandTrees.DbSortExpression source, System.Func<System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression> sortKey) { return default(System.Data.Common.CommandTrees.DbSortExpression); }
    public static System.Data.Common.CommandTrees.DbSortExpression ThenByDescending(this System.Data.Common.CommandTrees.DbSortExpression source, System.Func<System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression> sortKey, string collation) { return default(System.Data.Common.CommandTrees.DbSortExpression); }
    public static System.Data.Common.CommandTrees.DbSortClause ToSortClause(this System.Data.Common.CommandTrees.DbExpression key) { return default(System.Data.Common.CommandTrees.DbSortClause); }
    public static System.Data.Common.CommandTrees.DbSortClause ToSortClause(this System.Data.Common.CommandTrees.DbExpression key, string collation) { return default(System.Data.Common.CommandTrees.DbSortClause); }
    public static System.Data.Common.CommandTrees.DbSortClause ToSortClauseDescending(this System.Data.Common.CommandTrees.DbExpression key) { return default(System.Data.Common.CommandTrees.DbSortClause); }
    public static System.Data.Common.CommandTrees.DbSortClause ToSortClauseDescending(this System.Data.Common.CommandTrees.DbExpression key, string collation) { return default(System.Data.Common.CommandTrees.DbSortClause); }
    public static System.Data.Common.CommandTrees.DbTreatExpression TreatAs(this System.Data.Common.CommandTrees.DbExpression argument, System.Data.Metadata.Edm.TypeUsage treatType) { return default(System.Data.Common.CommandTrees.DbTreatExpression); }
    public static System.Data.Common.CommandTrees.DbArithmeticExpression UnaryMinus(this System.Data.Common.CommandTrees.DbExpression argument) { return default(System.Data.Common.CommandTrees.DbArithmeticExpression); }
    public static System.Data.Common.CommandTrees.DbExpression Union(this System.Data.Common.CommandTrees.DbExpression left, System.Data.Common.CommandTrees.DbExpression right) { return default(System.Data.Common.CommandTrees.DbExpression); }
    public static System.Data.Common.CommandTrees.DbUnionAllExpression UnionAll(this System.Data.Common.CommandTrees.DbExpression left, System.Data.Common.CommandTrees.DbExpression right) { return default(System.Data.Common.CommandTrees.DbUnionAllExpression); }
    public static System.Data.Common.CommandTrees.DbVariableReferenceExpression Variable(this System.Data.Metadata.Edm.TypeUsage type, string name) { return default(System.Data.Common.CommandTrees.DbVariableReferenceExpression); }
    public static System.Data.Common.CommandTrees.DbFilterExpression Where(this System.Data.Common.CommandTrees.DbExpression source, System.Func<System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression> predicate) { return default(System.Data.Common.CommandTrees.DbFilterExpression); }
  }
  public static partial class EdmFunctions {
    public static System.Data.Common.CommandTrees.DbFunctionExpression Abs(this System.Data.Common.CommandTrees.DbExpression value) { return default(System.Data.Common.CommandTrees.DbFunctionExpression); }
    public static System.Data.Common.CommandTrees.DbFunctionExpression AddDays(this System.Data.Common.CommandTrees.DbExpression dateValue, System.Data.Common.CommandTrees.DbExpression addValue) { return default(System.Data.Common.CommandTrees.DbFunctionExpression); }
    public static System.Data.Common.CommandTrees.DbFunctionExpression AddHours(this System.Data.Common.CommandTrees.DbExpression timeValue, System.Data.Common.CommandTrees.DbExpression addValue) { return default(System.Data.Common.CommandTrees.DbFunctionExpression); }
    public static System.Data.Common.CommandTrees.DbFunctionExpression AddMicroseconds(this System.Data.Common.CommandTrees.DbExpression timeValue, System.Data.Common.CommandTrees.DbExpression addValue) { return default(System.Data.Common.CommandTrees.DbFunctionExpression); }
    public static System.Data.Common.CommandTrees.DbFunctionExpression AddMilliseconds(this System.Data.Common.CommandTrees.DbExpression timeValue, System.Data.Common.CommandTrees.DbExpression addValue) { return default(System.Data.Common.CommandTrees.DbFunctionExpression); }
    public static System.Data.Common.CommandTrees.DbFunctionExpression AddMinutes(this System.Data.Common.CommandTrees.DbExpression timeValue, System.Data.Common.CommandTrees.DbExpression addValue) { return default(System.Data.Common.CommandTrees.DbFunctionExpression); }
    public static System.Data.Common.CommandTrees.DbFunctionExpression AddMonths(this System.Data.Common.CommandTrees.DbExpression dateValue, System.Data.Common.CommandTrees.DbExpression addValue) { return default(System.Data.Common.CommandTrees.DbFunctionExpression); }
    public static System.Data.Common.CommandTrees.DbFunctionExpression AddNanoseconds(this System.Data.Common.CommandTrees.DbExpression timeValue, System.Data.Common.CommandTrees.DbExpression addValue) { return default(System.Data.Common.CommandTrees.DbFunctionExpression); }
    public static System.Data.Common.CommandTrees.DbFunctionExpression AddSeconds(this System.Data.Common.CommandTrees.DbExpression timeValue, System.Data.Common.CommandTrees.DbExpression addValue) { return default(System.Data.Common.CommandTrees.DbFunctionExpression); }
    public static System.Data.Common.CommandTrees.DbFunctionExpression AddYears(this System.Data.Common.CommandTrees.DbExpression dateValue, System.Data.Common.CommandTrees.DbExpression addValue) { return default(System.Data.Common.CommandTrees.DbFunctionExpression); }
    public static System.Data.Common.CommandTrees.DbFunctionExpression Average(this System.Data.Common.CommandTrees.DbExpression collection) { return default(System.Data.Common.CommandTrees.DbFunctionExpression); }
    public static System.Data.Common.CommandTrees.DbFunctionExpression BitwiseAnd(this System.Data.Common.CommandTrees.DbExpression value1, System.Data.Common.CommandTrees.DbExpression value2) { return default(System.Data.Common.CommandTrees.DbFunctionExpression); }
    public static System.Data.Common.CommandTrees.DbFunctionExpression BitwiseNot(this System.Data.Common.CommandTrees.DbExpression value) { return default(System.Data.Common.CommandTrees.DbFunctionExpression); }
    public static System.Data.Common.CommandTrees.DbFunctionExpression BitwiseOr(this System.Data.Common.CommandTrees.DbExpression value1, System.Data.Common.CommandTrees.DbExpression value2) { return default(System.Data.Common.CommandTrees.DbFunctionExpression); }
    public static System.Data.Common.CommandTrees.DbFunctionExpression BitwiseXor(this System.Data.Common.CommandTrees.DbExpression value1, System.Data.Common.CommandTrees.DbExpression value2) { return default(System.Data.Common.CommandTrees.DbFunctionExpression); }
    public static System.Data.Common.CommandTrees.DbFunctionExpression Ceiling(this System.Data.Common.CommandTrees.DbExpression value) { return default(System.Data.Common.CommandTrees.DbFunctionExpression); }
    public static System.Data.Common.CommandTrees.DbFunctionExpression Concat(this System.Data.Common.CommandTrees.DbExpression string1, System.Data.Common.CommandTrees.DbExpression string2) { return default(System.Data.Common.CommandTrees.DbFunctionExpression); }
    public static System.Data.Common.CommandTrees.DbExpression Contains(this System.Data.Common.CommandTrees.DbExpression searchedString, System.Data.Common.CommandTrees.DbExpression searchedForString) { return default(System.Data.Common.CommandTrees.DbExpression); }
    public static System.Data.Common.CommandTrees.DbFunctionExpression Count(this System.Data.Common.CommandTrees.DbExpression collection) { return default(System.Data.Common.CommandTrees.DbFunctionExpression); }
    public static System.Data.Common.CommandTrees.DbFunctionExpression CreateDateTime(System.Data.Common.CommandTrees.DbExpression year, System.Data.Common.CommandTrees.DbExpression month, System.Data.Common.CommandTrees.DbExpression day, System.Data.Common.CommandTrees.DbExpression hour, System.Data.Common.CommandTrees.DbExpression minute, System.Data.Common.CommandTrees.DbExpression second) { return default(System.Data.Common.CommandTrees.DbFunctionExpression); }
    public static System.Data.Common.CommandTrees.DbFunctionExpression CreateDateTimeOffset(System.Data.Common.CommandTrees.DbExpression year, System.Data.Common.CommandTrees.DbExpression month, System.Data.Common.CommandTrees.DbExpression day, System.Data.Common.CommandTrees.DbExpression hour, System.Data.Common.CommandTrees.DbExpression minute, System.Data.Common.CommandTrees.DbExpression second, System.Data.Common.CommandTrees.DbExpression timeZoneOffset) { return default(System.Data.Common.CommandTrees.DbFunctionExpression); }
    public static System.Data.Common.CommandTrees.DbFunctionExpression CreateTime(System.Data.Common.CommandTrees.DbExpression hour, System.Data.Common.CommandTrees.DbExpression minute, System.Data.Common.CommandTrees.DbExpression second) { return default(System.Data.Common.CommandTrees.DbFunctionExpression); }
    public static System.Data.Common.CommandTrees.DbFunctionExpression CurrentDateTime() { return default(System.Data.Common.CommandTrees.DbFunctionExpression); }
    public static System.Data.Common.CommandTrees.DbFunctionExpression CurrentDateTimeOffset() { return default(System.Data.Common.CommandTrees.DbFunctionExpression); }
    public static System.Data.Common.CommandTrees.DbFunctionExpression CurrentUtcDateTime() { return default(System.Data.Common.CommandTrees.DbFunctionExpression); }
    public static System.Data.Common.CommandTrees.DbFunctionExpression Day(this System.Data.Common.CommandTrees.DbExpression dateValue) { return default(System.Data.Common.CommandTrees.DbFunctionExpression); }
    public static System.Data.Common.CommandTrees.DbFunctionExpression DayOfYear(this System.Data.Common.CommandTrees.DbExpression dateValue) { return default(System.Data.Common.CommandTrees.DbFunctionExpression); }
    public static System.Data.Common.CommandTrees.DbFunctionExpression DiffDays(this System.Data.Common.CommandTrees.DbExpression dateValue1, System.Data.Common.CommandTrees.DbExpression dateValue2) { return default(System.Data.Common.CommandTrees.DbFunctionExpression); }
    public static System.Data.Common.CommandTrees.DbFunctionExpression DiffHours(this System.Data.Common.CommandTrees.DbExpression timeValue1, System.Data.Common.CommandTrees.DbExpression timeValue2) { return default(System.Data.Common.CommandTrees.DbFunctionExpression); }
    public static System.Data.Common.CommandTrees.DbFunctionExpression DiffMicroseconds(this System.Data.Common.CommandTrees.DbExpression timeValue1, System.Data.Common.CommandTrees.DbExpression timeValue2) { return default(System.Data.Common.CommandTrees.DbFunctionExpression); }
    public static System.Data.Common.CommandTrees.DbFunctionExpression DiffMilliseconds(this System.Data.Common.CommandTrees.DbExpression timeValue1, System.Data.Common.CommandTrees.DbExpression timeValue2) { return default(System.Data.Common.CommandTrees.DbFunctionExpression); }
    public static System.Data.Common.CommandTrees.DbFunctionExpression DiffMinutes(this System.Data.Common.CommandTrees.DbExpression timeValue1, System.Data.Common.CommandTrees.DbExpression timeValue2) { return default(System.Data.Common.CommandTrees.DbFunctionExpression); }
    public static System.Data.Common.CommandTrees.DbFunctionExpression DiffMonths(this System.Data.Common.CommandTrees.DbExpression dateValue1, System.Data.Common.CommandTrees.DbExpression dateValue2) { return default(System.Data.Common.CommandTrees.DbFunctionExpression); }
    public static System.Data.Common.CommandTrees.DbFunctionExpression DiffNanoseconds(this System.Data.Common.CommandTrees.DbExpression timeValue1, System.Data.Common.CommandTrees.DbExpression timeValue2) { return default(System.Data.Common.CommandTrees.DbFunctionExpression); }
    public static System.Data.Common.CommandTrees.DbFunctionExpression DiffSeconds(this System.Data.Common.CommandTrees.DbExpression timeValue1, System.Data.Common.CommandTrees.DbExpression timeValue2) { return default(System.Data.Common.CommandTrees.DbFunctionExpression); }
    public static System.Data.Common.CommandTrees.DbFunctionExpression DiffYears(this System.Data.Common.CommandTrees.DbExpression dateValue1, System.Data.Common.CommandTrees.DbExpression dateValue2) { return default(System.Data.Common.CommandTrees.DbFunctionExpression); }
    public static System.Data.Common.CommandTrees.DbFunctionExpression EndsWith(this System.Data.Common.CommandTrees.DbExpression stringArgument, System.Data.Common.CommandTrees.DbExpression suffix) { return default(System.Data.Common.CommandTrees.DbFunctionExpression); }
    public static System.Data.Common.CommandTrees.DbFunctionExpression Floor(this System.Data.Common.CommandTrees.DbExpression value) { return default(System.Data.Common.CommandTrees.DbFunctionExpression); }
    public static System.Data.Common.CommandTrees.DbFunctionExpression GetTotalOffsetMinutes(this System.Data.Common.CommandTrees.DbExpression dateTimeOffsetArgument) { return default(System.Data.Common.CommandTrees.DbFunctionExpression); }
    public static System.Data.Common.CommandTrees.DbFunctionExpression Hour(this System.Data.Common.CommandTrees.DbExpression timeValue) { return default(System.Data.Common.CommandTrees.DbFunctionExpression); }
    public static System.Data.Common.CommandTrees.DbFunctionExpression IndexOf(this System.Data.Common.CommandTrees.DbExpression searchString, System.Data.Common.CommandTrees.DbExpression stringToFind) { return default(System.Data.Common.CommandTrees.DbFunctionExpression); }
    public static System.Data.Common.CommandTrees.DbFunctionExpression Left(this System.Data.Common.CommandTrees.DbExpression stringArgument, System.Data.Common.CommandTrees.DbExpression length) { return default(System.Data.Common.CommandTrees.DbFunctionExpression); }
    public static System.Data.Common.CommandTrees.DbFunctionExpression Length(this System.Data.Common.CommandTrees.DbExpression stringArgument) { return default(System.Data.Common.CommandTrees.DbFunctionExpression); }
    public static System.Data.Common.CommandTrees.DbFunctionExpression LongCount(this System.Data.Common.CommandTrees.DbExpression collection) { return default(System.Data.Common.CommandTrees.DbFunctionExpression); }
    public static System.Data.Common.CommandTrees.DbFunctionExpression Max(this System.Data.Common.CommandTrees.DbExpression collection) { return default(System.Data.Common.CommandTrees.DbFunctionExpression); }
    public static System.Data.Common.CommandTrees.DbFunctionExpression Millisecond(this System.Data.Common.CommandTrees.DbExpression timeValue) { return default(System.Data.Common.CommandTrees.DbFunctionExpression); }
    public static System.Data.Common.CommandTrees.DbFunctionExpression Min(this System.Data.Common.CommandTrees.DbExpression collection) { return default(System.Data.Common.CommandTrees.DbFunctionExpression); }
    public static System.Data.Common.CommandTrees.DbFunctionExpression Minute(this System.Data.Common.CommandTrees.DbExpression timeValue) { return default(System.Data.Common.CommandTrees.DbFunctionExpression); }
    public static System.Data.Common.CommandTrees.DbFunctionExpression Month(this System.Data.Common.CommandTrees.DbExpression dateValue) { return default(System.Data.Common.CommandTrees.DbFunctionExpression); }
    public static System.Data.Common.CommandTrees.DbFunctionExpression NewGuid() { return default(System.Data.Common.CommandTrees.DbFunctionExpression); }
    public static System.Data.Common.CommandTrees.DbFunctionExpression Power(this System.Data.Common.CommandTrees.DbExpression baseArgument, System.Data.Common.CommandTrees.DbExpression exponent) { return default(System.Data.Common.CommandTrees.DbFunctionExpression); }
    public static System.Data.Common.CommandTrees.DbFunctionExpression Replace(this System.Data.Common.CommandTrees.DbExpression stringArgument, System.Data.Common.CommandTrees.DbExpression toReplace, System.Data.Common.CommandTrees.DbExpression replacement) { return default(System.Data.Common.CommandTrees.DbFunctionExpression); }
    public static System.Data.Common.CommandTrees.DbFunctionExpression Reverse(this System.Data.Common.CommandTrees.DbExpression stringArgument) { return default(System.Data.Common.CommandTrees.DbFunctionExpression); }
    public static System.Data.Common.CommandTrees.DbFunctionExpression Right(this System.Data.Common.CommandTrees.DbExpression stringArgument, System.Data.Common.CommandTrees.DbExpression length) { return default(System.Data.Common.CommandTrees.DbFunctionExpression); }
    public static System.Data.Common.CommandTrees.DbFunctionExpression Round(this System.Data.Common.CommandTrees.DbExpression value) { return default(System.Data.Common.CommandTrees.DbFunctionExpression); }
    public static System.Data.Common.CommandTrees.DbFunctionExpression Round(this System.Data.Common.CommandTrees.DbExpression value, System.Data.Common.CommandTrees.DbExpression digits) { return default(System.Data.Common.CommandTrees.DbFunctionExpression); }
    public static System.Data.Common.CommandTrees.DbFunctionExpression Second(this System.Data.Common.CommandTrees.DbExpression timeValue) { return default(System.Data.Common.CommandTrees.DbFunctionExpression); }
    public static System.Data.Common.CommandTrees.DbFunctionExpression StartsWith(this System.Data.Common.CommandTrees.DbExpression stringArgument, System.Data.Common.CommandTrees.DbExpression prefix) { return default(System.Data.Common.CommandTrees.DbFunctionExpression); }
    public static System.Data.Common.CommandTrees.DbFunctionExpression StDev(this System.Data.Common.CommandTrees.DbExpression collection) { return default(System.Data.Common.CommandTrees.DbFunctionExpression); }
    public static System.Data.Common.CommandTrees.DbFunctionExpression StDevP(this System.Data.Common.CommandTrees.DbExpression collection) { return default(System.Data.Common.CommandTrees.DbFunctionExpression); }
    public static System.Data.Common.CommandTrees.DbFunctionExpression Substring(this System.Data.Common.CommandTrees.DbExpression stringArgument, System.Data.Common.CommandTrees.DbExpression start, System.Data.Common.CommandTrees.DbExpression length) { return default(System.Data.Common.CommandTrees.DbFunctionExpression); }
    public static System.Data.Common.CommandTrees.DbFunctionExpression Sum(this System.Data.Common.CommandTrees.DbExpression collection) { return default(System.Data.Common.CommandTrees.DbFunctionExpression); }
    public static System.Data.Common.CommandTrees.DbFunctionExpression ToLower(this System.Data.Common.CommandTrees.DbExpression stringArgument) { return default(System.Data.Common.CommandTrees.DbFunctionExpression); }
    public static System.Data.Common.CommandTrees.DbFunctionExpression ToUpper(this System.Data.Common.CommandTrees.DbExpression stringArgument) { return default(System.Data.Common.CommandTrees.DbFunctionExpression); }
    public static System.Data.Common.CommandTrees.DbFunctionExpression Trim(this System.Data.Common.CommandTrees.DbExpression stringArgument) { return default(System.Data.Common.CommandTrees.DbFunctionExpression); }
    public static System.Data.Common.CommandTrees.DbFunctionExpression TrimEnd(this System.Data.Common.CommandTrees.DbExpression stringArgument) { return default(System.Data.Common.CommandTrees.DbFunctionExpression); }
    public static System.Data.Common.CommandTrees.DbFunctionExpression TrimStart(this System.Data.Common.CommandTrees.DbExpression stringArgument) { return default(System.Data.Common.CommandTrees.DbFunctionExpression); }
    public static System.Data.Common.CommandTrees.DbFunctionExpression Truncate(this System.Data.Common.CommandTrees.DbExpression value, System.Data.Common.CommandTrees.DbExpression digits) { return default(System.Data.Common.CommandTrees.DbFunctionExpression); }
    public static System.Data.Common.CommandTrees.DbFunctionExpression TruncateTime(this System.Data.Common.CommandTrees.DbExpression dateValue) { return default(System.Data.Common.CommandTrees.DbFunctionExpression); }
    public static System.Data.Common.CommandTrees.DbFunctionExpression Var(this System.Data.Common.CommandTrees.DbExpression collection) { return default(System.Data.Common.CommandTrees.DbFunctionExpression); }
    public static System.Data.Common.CommandTrees.DbFunctionExpression VarP(this System.Data.Common.CommandTrees.DbExpression collection) { return default(System.Data.Common.CommandTrees.DbFunctionExpression); }
    public static System.Data.Common.CommandTrees.DbFunctionExpression Year(this System.Data.Common.CommandTrees.DbExpression dateValue) { return default(System.Data.Common.CommandTrees.DbFunctionExpression); }
  }
  public sealed partial class Row {
    public Row(System.Collections.Generic.KeyValuePair<System.String, System.Data.Common.CommandTrees.DbExpression> columnValue, params System.Collections.Generic.KeyValuePair<System.String, System.Data.Common.CommandTrees.DbExpression>[] columnValues) { }
    public static implicit operator System.Data.Common.CommandTrees.DbExpression (System.Data.Common.CommandTrees.ExpressionBuilder.Row row) { return default(System.Data.Common.CommandTrees.DbExpression); }
    public System.Data.Common.CommandTrees.DbNewInstanceExpression ToExpression() { return default(System.Data.Common.CommandTrees.DbNewInstanceExpression); }
  }
}
namespace System.Data.Common.CommandTrees.ExpressionBuilder.Spatial {
  public static partial class SpatialEdmFunctions {
    public static System.Data.Common.CommandTrees.DbFunctionExpression Area(this System.Data.Common.CommandTrees.DbExpression spatialValue) { return default(System.Data.Common.CommandTrees.DbFunctionExpression); }
    public static System.Data.Common.CommandTrees.DbFunctionExpression AsBinary(this System.Data.Common.CommandTrees.DbExpression spatialValue) { return default(System.Data.Common.CommandTrees.DbFunctionExpression); }
    public static System.Data.Common.CommandTrees.DbFunctionExpression AsGml(this System.Data.Common.CommandTrees.DbExpression spatialValue) { return default(System.Data.Common.CommandTrees.DbFunctionExpression); }
    public static System.Data.Common.CommandTrees.DbFunctionExpression AsText(this System.Data.Common.CommandTrees.DbExpression spatialValue) { return default(System.Data.Common.CommandTrees.DbFunctionExpression); }
    public static System.Data.Common.CommandTrees.DbFunctionExpression Centroid(this System.Data.Common.CommandTrees.DbExpression geometryValue) { return default(System.Data.Common.CommandTrees.DbFunctionExpression); }
    public static System.Data.Common.CommandTrees.DbFunctionExpression CoordinateSystemId(this System.Data.Common.CommandTrees.DbExpression spatialValue) { return default(System.Data.Common.CommandTrees.DbFunctionExpression); }
    public static System.Data.Common.CommandTrees.DbFunctionExpression Distance(this System.Data.Common.CommandTrees.DbExpression spatialValue1, System.Data.Common.CommandTrees.DbExpression spatialValue2) { return default(System.Data.Common.CommandTrees.DbFunctionExpression); }
    public static System.Data.Common.CommandTrees.DbFunctionExpression Elevation(this System.Data.Common.CommandTrees.DbExpression spatialValue) { return default(System.Data.Common.CommandTrees.DbFunctionExpression); }
    public static System.Data.Common.CommandTrees.DbFunctionExpression EndPoint(this System.Data.Common.CommandTrees.DbExpression spatialValue) { return default(System.Data.Common.CommandTrees.DbFunctionExpression); }
    public static System.Data.Common.CommandTrees.DbFunctionExpression ExteriorRing(this System.Data.Common.CommandTrees.DbExpression geometryValue) { return default(System.Data.Common.CommandTrees.DbFunctionExpression); }
    public static System.Data.Common.CommandTrees.DbFunctionExpression GeographyCollectionFromBinary(System.Data.Common.CommandTrees.DbExpression geographyCollectionWellKnownBinaryValue, System.Data.Common.CommandTrees.DbExpression coordinateSystemId) { return default(System.Data.Common.CommandTrees.DbFunctionExpression); }
    public static System.Data.Common.CommandTrees.DbFunctionExpression GeographyCollectionFromText(System.Data.Common.CommandTrees.DbExpression geographyCollectionWellKnownText, System.Data.Common.CommandTrees.DbExpression coordinateSystemId) { return default(System.Data.Common.CommandTrees.DbFunctionExpression); }
    public static System.Data.Common.CommandTrees.DbFunctionExpression GeographyFromBinary(System.Data.Common.CommandTrees.DbExpression wellKnownBinaryValue) { return default(System.Data.Common.CommandTrees.DbFunctionExpression); }
    public static System.Data.Common.CommandTrees.DbFunctionExpression GeographyFromBinary(System.Data.Common.CommandTrees.DbExpression wellKnownBinaryValue, System.Data.Common.CommandTrees.DbExpression coordinateSystemId) { return default(System.Data.Common.CommandTrees.DbFunctionExpression); }
    public static System.Data.Common.CommandTrees.DbFunctionExpression GeographyFromGml(System.Data.Common.CommandTrees.DbExpression geographyMarkup) { return default(System.Data.Common.CommandTrees.DbFunctionExpression); }
    public static System.Data.Common.CommandTrees.DbFunctionExpression GeographyFromGml(System.Data.Common.CommandTrees.DbExpression geographyMarkup, System.Data.Common.CommandTrees.DbExpression coordinateSystemId) { return default(System.Data.Common.CommandTrees.DbFunctionExpression); }
    public static System.Data.Common.CommandTrees.DbFunctionExpression GeographyFromText(System.Data.Common.CommandTrees.DbExpression wellKnownText) { return default(System.Data.Common.CommandTrees.DbFunctionExpression); }
    public static System.Data.Common.CommandTrees.DbFunctionExpression GeographyFromText(System.Data.Common.CommandTrees.DbExpression wellKnownText, System.Data.Common.CommandTrees.DbExpression coordinateSystemId) { return default(System.Data.Common.CommandTrees.DbFunctionExpression); }
    public static System.Data.Common.CommandTrees.DbFunctionExpression GeographyLineFromBinary(System.Data.Common.CommandTrees.DbExpression lineWellKnownBinaryValue, System.Data.Common.CommandTrees.DbExpression coordinateSystemId) { return default(System.Data.Common.CommandTrees.DbFunctionExpression); }
    public static System.Data.Common.CommandTrees.DbFunctionExpression GeographyLineFromText(System.Data.Common.CommandTrees.DbExpression lineWellKnownText, System.Data.Common.CommandTrees.DbExpression coordinateSystemId) { return default(System.Data.Common.CommandTrees.DbFunctionExpression); }
    public static System.Data.Common.CommandTrees.DbFunctionExpression GeographyMultiLineFromBinary(System.Data.Common.CommandTrees.DbExpression multiLineWellKnownBinaryValue, System.Data.Common.CommandTrees.DbExpression coordinateSystemId) { return default(System.Data.Common.CommandTrees.DbFunctionExpression); }
    public static System.Data.Common.CommandTrees.DbFunctionExpression GeographyMultiLineFromText(System.Data.Common.CommandTrees.DbExpression multiLineWellKnownText, System.Data.Common.CommandTrees.DbExpression coordinateSystemId) { return default(System.Data.Common.CommandTrees.DbFunctionExpression); }
    public static System.Data.Common.CommandTrees.DbFunctionExpression GeographyMultiPointFromBinary(System.Data.Common.CommandTrees.DbExpression multiPointWellKnownBinaryValue, System.Data.Common.CommandTrees.DbExpression coordinateSystemId) { return default(System.Data.Common.CommandTrees.DbFunctionExpression); }
    public static System.Data.Common.CommandTrees.DbFunctionExpression GeographyMultiPointFromText(System.Data.Common.CommandTrees.DbExpression multiPointWellKnownText, System.Data.Common.CommandTrees.DbExpression coordinateSystemId) { return default(System.Data.Common.CommandTrees.DbFunctionExpression); }
    public static System.Data.Common.CommandTrees.DbFunctionExpression GeographyMultiPolygonFromBinary(System.Data.Common.CommandTrees.DbExpression multiPolygonWellKnownBinaryValue, System.Data.Common.CommandTrees.DbExpression coordinateSystemId) { return default(System.Data.Common.CommandTrees.DbFunctionExpression); }
    public static System.Data.Common.CommandTrees.DbFunctionExpression GeographyMultiPolygonFromText(System.Data.Common.CommandTrees.DbExpression multiPolygonWellKnownText, System.Data.Common.CommandTrees.DbExpression coordinateSystemId) { return default(System.Data.Common.CommandTrees.DbFunctionExpression); }
    public static System.Data.Common.CommandTrees.DbFunctionExpression GeographyPointFromBinary(System.Data.Common.CommandTrees.DbExpression pointWellKnownBinaryValue, System.Data.Common.CommandTrees.DbExpression coordinateSystemId) { return default(System.Data.Common.CommandTrees.DbFunctionExpression); }
    public static System.Data.Common.CommandTrees.DbFunctionExpression GeographyPointFromText(System.Data.Common.CommandTrees.DbExpression pointWellKnownText, System.Data.Common.CommandTrees.DbExpression coordinateSystemId) { return default(System.Data.Common.CommandTrees.DbFunctionExpression); }
    public static System.Data.Common.CommandTrees.DbFunctionExpression GeographyPolygonFromBinary(System.Data.Common.CommandTrees.DbExpression polygonWellKnownBinaryValue, System.Data.Common.CommandTrees.DbExpression coordinateSystemId) { return default(System.Data.Common.CommandTrees.DbFunctionExpression); }
    public static System.Data.Common.CommandTrees.DbFunctionExpression GeographyPolygonFromText(System.Data.Common.CommandTrees.DbExpression polygonWellKnownText, System.Data.Common.CommandTrees.DbExpression coordinateSystemId) { return default(System.Data.Common.CommandTrees.DbFunctionExpression); }
    public static System.Data.Common.CommandTrees.DbFunctionExpression GeometryCollectionFromBinary(System.Data.Common.CommandTrees.DbExpression geometryCollectionWellKnownBinaryValue, System.Data.Common.CommandTrees.DbExpression coordinateSystemId) { return default(System.Data.Common.CommandTrees.DbFunctionExpression); }
    public static System.Data.Common.CommandTrees.DbFunctionExpression GeometryCollectionFromText(System.Data.Common.CommandTrees.DbExpression geometryCollectionWellKnownText, System.Data.Common.CommandTrees.DbExpression coordinateSystemId) { return default(System.Data.Common.CommandTrees.DbFunctionExpression); }
    public static System.Data.Common.CommandTrees.DbFunctionExpression GeometryFromBinary(System.Data.Common.CommandTrees.DbExpression wellKnownBinaryValue) { return default(System.Data.Common.CommandTrees.DbFunctionExpression); }
    public static System.Data.Common.CommandTrees.DbFunctionExpression GeometryFromBinary(System.Data.Common.CommandTrees.DbExpression wellKnownBinaryValue, System.Data.Common.CommandTrees.DbExpression coordinateSystemId) { return default(System.Data.Common.CommandTrees.DbFunctionExpression); }
    public static System.Data.Common.CommandTrees.DbFunctionExpression GeometryFromGml(System.Data.Common.CommandTrees.DbExpression geometryMarkup) { return default(System.Data.Common.CommandTrees.DbFunctionExpression); }
    public static System.Data.Common.CommandTrees.DbFunctionExpression GeometryFromGml(System.Data.Common.CommandTrees.DbExpression geometryMarkup, System.Data.Common.CommandTrees.DbExpression coordinateSystemId) { return default(System.Data.Common.CommandTrees.DbFunctionExpression); }
    public static System.Data.Common.CommandTrees.DbFunctionExpression GeometryFromText(System.Data.Common.CommandTrees.DbExpression wellKnownText) { return default(System.Data.Common.CommandTrees.DbFunctionExpression); }
    public static System.Data.Common.CommandTrees.DbFunctionExpression GeometryFromText(System.Data.Common.CommandTrees.DbExpression wellKnownText, System.Data.Common.CommandTrees.DbExpression coordinateSystemId) { return default(System.Data.Common.CommandTrees.DbFunctionExpression); }
    public static System.Data.Common.CommandTrees.DbFunctionExpression GeometryLineFromBinary(System.Data.Common.CommandTrees.DbExpression lineWellKnownBinaryValue, System.Data.Common.CommandTrees.DbExpression coordinateSystemId) { return default(System.Data.Common.CommandTrees.DbFunctionExpression); }
    public static System.Data.Common.CommandTrees.DbFunctionExpression GeometryLineFromText(System.Data.Common.CommandTrees.DbExpression lineWellKnownText, System.Data.Common.CommandTrees.DbExpression coordinateSystemId) { return default(System.Data.Common.CommandTrees.DbFunctionExpression); }
    public static System.Data.Common.CommandTrees.DbFunctionExpression GeometryMultiLineFromBinary(System.Data.Common.CommandTrees.DbExpression multiLineWellKnownBinaryValue, System.Data.Common.CommandTrees.DbExpression coordinateSystemId) { return default(System.Data.Common.CommandTrees.DbFunctionExpression); }
    public static System.Data.Common.CommandTrees.DbFunctionExpression GeometryMultiLineFromText(System.Data.Common.CommandTrees.DbExpression multiLineWellKnownText, System.Data.Common.CommandTrees.DbExpression coordinateSystemId) { return default(System.Data.Common.CommandTrees.DbFunctionExpression); }
    public static System.Data.Common.CommandTrees.DbFunctionExpression GeometryMultiPointFromBinary(System.Data.Common.CommandTrees.DbExpression multiPointWellKnownBinaryValue, System.Data.Common.CommandTrees.DbExpression coordinateSystemId) { return default(System.Data.Common.CommandTrees.DbFunctionExpression); }
    public static System.Data.Common.CommandTrees.DbFunctionExpression GeometryMultiPointFromText(System.Data.Common.CommandTrees.DbExpression multiPointWellKnownText, System.Data.Common.CommandTrees.DbExpression coordinateSystemId) { return default(System.Data.Common.CommandTrees.DbFunctionExpression); }
    public static System.Data.Common.CommandTrees.DbFunctionExpression GeometryMultiPolygonFromBinary(System.Data.Common.CommandTrees.DbExpression multiPolygonWellKnownBinaryValue, System.Data.Common.CommandTrees.DbExpression coordinateSystemId) { return default(System.Data.Common.CommandTrees.DbFunctionExpression); }
    public static System.Data.Common.CommandTrees.DbFunctionExpression GeometryMultiPolygonFromText(System.Data.Common.CommandTrees.DbExpression multiPolygonWellKnownText, System.Data.Common.CommandTrees.DbExpression coordinateSystemId) { return default(System.Data.Common.CommandTrees.DbFunctionExpression); }
    public static System.Data.Common.CommandTrees.DbFunctionExpression GeometryPointFromBinary(System.Data.Common.CommandTrees.DbExpression pointWellKnownBinaryValue, System.Data.Common.CommandTrees.DbExpression coordinateSystemId) { return default(System.Data.Common.CommandTrees.DbFunctionExpression); }
    public static System.Data.Common.CommandTrees.DbFunctionExpression GeometryPointFromText(System.Data.Common.CommandTrees.DbExpression pointWellKnownText, System.Data.Common.CommandTrees.DbExpression coordinateSystemId) { return default(System.Data.Common.CommandTrees.DbFunctionExpression); }
    public static System.Data.Common.CommandTrees.DbFunctionExpression GeometryPolygonFromBinary(System.Data.Common.CommandTrees.DbExpression polygonWellKnownBinaryValue, System.Data.Common.CommandTrees.DbExpression coordinateSystemId) { return default(System.Data.Common.CommandTrees.DbFunctionExpression); }
    public static System.Data.Common.CommandTrees.DbFunctionExpression GeometryPolygonFromText(System.Data.Common.CommandTrees.DbExpression polygonWellKnownText, System.Data.Common.CommandTrees.DbExpression coordinateSystemId) { return default(System.Data.Common.CommandTrees.DbFunctionExpression); }
    public static System.Data.Common.CommandTrees.DbFunctionExpression InteriorRingAt(this System.Data.Common.CommandTrees.DbExpression geometryValue, System.Data.Common.CommandTrees.DbExpression indexValue) { return default(System.Data.Common.CommandTrees.DbFunctionExpression); }
    public static System.Data.Common.CommandTrees.DbFunctionExpression InteriorRingCount(this System.Data.Common.CommandTrees.DbExpression geometryValue) { return default(System.Data.Common.CommandTrees.DbFunctionExpression); }
    public static System.Data.Common.CommandTrees.DbFunctionExpression IsClosedSpatial(this System.Data.Common.CommandTrees.DbExpression spatialValue) { return default(System.Data.Common.CommandTrees.DbFunctionExpression); }
    public static System.Data.Common.CommandTrees.DbFunctionExpression IsEmptySpatial(this System.Data.Common.CommandTrees.DbExpression spatialValue) { return default(System.Data.Common.CommandTrees.DbFunctionExpression); }
    public static System.Data.Common.CommandTrees.DbFunctionExpression IsRing(this System.Data.Common.CommandTrees.DbExpression geometryValue) { return default(System.Data.Common.CommandTrees.DbFunctionExpression); }
    public static System.Data.Common.CommandTrees.DbFunctionExpression IsSimpleGeometry(this System.Data.Common.CommandTrees.DbExpression geometryValue) { return default(System.Data.Common.CommandTrees.DbFunctionExpression); }
    public static System.Data.Common.CommandTrees.DbFunctionExpression IsValidGeometry(this System.Data.Common.CommandTrees.DbExpression geometryValue) { return default(System.Data.Common.CommandTrees.DbFunctionExpression); }
    public static System.Data.Common.CommandTrees.DbFunctionExpression Latitude(this System.Data.Common.CommandTrees.DbExpression geographyValue) { return default(System.Data.Common.CommandTrees.DbFunctionExpression); }
    public static System.Data.Common.CommandTrees.DbFunctionExpression Longitude(this System.Data.Common.CommandTrees.DbExpression geographyValue) { return default(System.Data.Common.CommandTrees.DbFunctionExpression); }
    public static System.Data.Common.CommandTrees.DbFunctionExpression Measure(this System.Data.Common.CommandTrees.DbExpression spatialValue) { return default(System.Data.Common.CommandTrees.DbFunctionExpression); }
    public static System.Data.Common.CommandTrees.DbFunctionExpression PointAt(this System.Data.Common.CommandTrees.DbExpression spatialValue, System.Data.Common.CommandTrees.DbExpression indexValue) { return default(System.Data.Common.CommandTrees.DbFunctionExpression); }
    public static System.Data.Common.CommandTrees.DbFunctionExpression PointCount(this System.Data.Common.CommandTrees.DbExpression spatialValue) { return default(System.Data.Common.CommandTrees.DbFunctionExpression); }
    public static System.Data.Common.CommandTrees.DbFunctionExpression PointOnSurface(this System.Data.Common.CommandTrees.DbExpression geometryValue) { return default(System.Data.Common.CommandTrees.DbFunctionExpression); }
    public static System.Data.Common.CommandTrees.DbFunctionExpression SpatialBoundary(this System.Data.Common.CommandTrees.DbExpression geometryValue) { return default(System.Data.Common.CommandTrees.DbFunctionExpression); }
    public static System.Data.Common.CommandTrees.DbFunctionExpression SpatialBuffer(this System.Data.Common.CommandTrees.DbExpression spatialValue, System.Data.Common.CommandTrees.DbExpression distance) { return default(System.Data.Common.CommandTrees.DbFunctionExpression); }
    public static System.Data.Common.CommandTrees.DbFunctionExpression SpatialContains(this System.Data.Common.CommandTrees.DbExpression geometryValue1, System.Data.Common.CommandTrees.DbExpression geometryValue2) { return default(System.Data.Common.CommandTrees.DbFunctionExpression); }
    public static System.Data.Common.CommandTrees.DbFunctionExpression SpatialConvexHull(this System.Data.Common.CommandTrees.DbExpression geometryValue) { return default(System.Data.Common.CommandTrees.DbFunctionExpression); }
    public static System.Data.Common.CommandTrees.DbFunctionExpression SpatialCrosses(this System.Data.Common.CommandTrees.DbExpression geometryValue1, System.Data.Common.CommandTrees.DbExpression geometryValue2) { return default(System.Data.Common.CommandTrees.DbFunctionExpression); }
    public static System.Data.Common.CommandTrees.DbFunctionExpression SpatialDifference(this System.Data.Common.CommandTrees.DbExpression spatialValue1, System.Data.Common.CommandTrees.DbExpression spatialValue2) { return default(System.Data.Common.CommandTrees.DbFunctionExpression); }
    public static System.Data.Common.CommandTrees.DbFunctionExpression SpatialDimension(this System.Data.Common.CommandTrees.DbExpression spatialValue) { return default(System.Data.Common.CommandTrees.DbFunctionExpression); }
    public static System.Data.Common.CommandTrees.DbFunctionExpression SpatialDisjoint(this System.Data.Common.CommandTrees.DbExpression spatialValue1, System.Data.Common.CommandTrees.DbExpression spatialValue2) { return default(System.Data.Common.CommandTrees.DbFunctionExpression); }
    public static System.Data.Common.CommandTrees.DbFunctionExpression SpatialElementAt(this System.Data.Common.CommandTrees.DbExpression spatialValue, System.Data.Common.CommandTrees.DbExpression indexValue) { return default(System.Data.Common.CommandTrees.DbFunctionExpression); }
    public static System.Data.Common.CommandTrees.DbFunctionExpression SpatialElementCount(this System.Data.Common.CommandTrees.DbExpression spatialValue) { return default(System.Data.Common.CommandTrees.DbFunctionExpression); }
    public static System.Data.Common.CommandTrees.DbFunctionExpression SpatialEnvelope(this System.Data.Common.CommandTrees.DbExpression geometryValue) { return default(System.Data.Common.CommandTrees.DbFunctionExpression); }
    public static System.Data.Common.CommandTrees.DbFunctionExpression SpatialEquals(this System.Data.Common.CommandTrees.DbExpression spatialValue1, System.Data.Common.CommandTrees.DbExpression spatialValue2) { return default(System.Data.Common.CommandTrees.DbFunctionExpression); }
    public static System.Data.Common.CommandTrees.DbFunctionExpression SpatialIntersection(this System.Data.Common.CommandTrees.DbExpression spatialValue1, System.Data.Common.CommandTrees.DbExpression spatialValue2) { return default(System.Data.Common.CommandTrees.DbFunctionExpression); }
    public static System.Data.Common.CommandTrees.DbFunctionExpression SpatialIntersects(this System.Data.Common.CommandTrees.DbExpression spatialValue1, System.Data.Common.CommandTrees.DbExpression spatialValue2) { return default(System.Data.Common.CommandTrees.DbFunctionExpression); }
    public static System.Data.Common.CommandTrees.DbFunctionExpression SpatialLength(this System.Data.Common.CommandTrees.DbExpression spatialValue) { return default(System.Data.Common.CommandTrees.DbFunctionExpression); }
    public static System.Data.Common.CommandTrees.DbFunctionExpression SpatialOverlaps(this System.Data.Common.CommandTrees.DbExpression geometryValue1, System.Data.Common.CommandTrees.DbExpression geometryValue2) { return default(System.Data.Common.CommandTrees.DbFunctionExpression); }
    public static System.Data.Common.CommandTrees.DbFunctionExpression SpatialRelate(this System.Data.Common.CommandTrees.DbExpression geometryValue1, System.Data.Common.CommandTrees.DbExpression geometryValue2, System.Data.Common.CommandTrees.DbExpression intersectionPatternMatrix) { return default(System.Data.Common.CommandTrees.DbFunctionExpression); }
    public static System.Data.Common.CommandTrees.DbFunctionExpression SpatialSymmetricDifference(this System.Data.Common.CommandTrees.DbExpression spatialValue1, System.Data.Common.CommandTrees.DbExpression spatialValue2) { return default(System.Data.Common.CommandTrees.DbFunctionExpression); }
    public static System.Data.Common.CommandTrees.DbFunctionExpression SpatialTouches(this System.Data.Common.CommandTrees.DbExpression geometryValue1, System.Data.Common.CommandTrees.DbExpression geometryValue2) { return default(System.Data.Common.CommandTrees.DbFunctionExpression); }
    public static System.Data.Common.CommandTrees.DbFunctionExpression SpatialTypeName(this System.Data.Common.CommandTrees.DbExpression spatialValue) { return default(System.Data.Common.CommandTrees.DbFunctionExpression); }
    public static System.Data.Common.CommandTrees.DbFunctionExpression SpatialUnion(this System.Data.Common.CommandTrees.DbExpression spatialValue1, System.Data.Common.CommandTrees.DbExpression spatialValue2) { return default(System.Data.Common.CommandTrees.DbFunctionExpression); }
    public static System.Data.Common.CommandTrees.DbFunctionExpression SpatialWithin(this System.Data.Common.CommandTrees.DbExpression geometryValue1, System.Data.Common.CommandTrees.DbExpression geometryValue2) { return default(System.Data.Common.CommandTrees.DbFunctionExpression); }
    public static System.Data.Common.CommandTrees.DbFunctionExpression StartPoint(this System.Data.Common.CommandTrees.DbExpression spatialValue) { return default(System.Data.Common.CommandTrees.DbFunctionExpression); }
    public static System.Data.Common.CommandTrees.DbFunctionExpression XCoordinate(this System.Data.Common.CommandTrees.DbExpression geometryValue) { return default(System.Data.Common.CommandTrees.DbFunctionExpression); }
    public static System.Data.Common.CommandTrees.DbFunctionExpression YCoordinate(this System.Data.Common.CommandTrees.DbExpression geometryValue) { return default(System.Data.Common.CommandTrees.DbFunctionExpression); }
  }
}
namespace System.Data.Common.EntitySql {
  public sealed partial class EntitySqlParser {
    internal EntitySqlParser() { }
    public System.Data.Common.EntitySql.ParseResult Parse(string query, params System.Data.Common.CommandTrees.DbParameterReferenceExpression[] parameters) { return default(System.Data.Common.EntitySql.ParseResult); }
    public System.Data.Common.CommandTrees.DbLambda ParseLambda(string query, params System.Data.Common.CommandTrees.DbVariableReferenceExpression[] variables) { return default(System.Data.Common.CommandTrees.DbLambda); }
  }
  public sealed partial class FunctionDefinition {
    internal FunctionDefinition() { }
    public int EndPosition { get { return default(int); } }
    public System.Data.Common.CommandTrees.DbLambda Lambda { get { return default(System.Data.Common.CommandTrees.DbLambda); } }
    public string Name { get { return default(string); } }
    public int StartPosition { get { return default(int); } }
  }
  public sealed partial class ParseResult {
    internal ParseResult() { }
    public System.Data.Common.CommandTrees.DbCommandTree CommandTree { get { return default(System.Data.Common.CommandTrees.DbCommandTree); } }
    public System.Collections.ObjectModel.ReadOnlyCollection<System.Data.Common.EntitySql.FunctionDefinition> FunctionDefinitions { get { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.Data.Common.EntitySql.FunctionDefinition>); } }
  }
}
namespace System.Data.EntityClient {
  public sealed partial class EntityCommand : System.Data.Common.DbCommand {
    public EntityCommand() { }
    public EntityCommand(string statement) { }
    public EntityCommand(string statement, System.Data.EntityClient.EntityConnection connection) { }
    public EntityCommand(string statement, System.Data.EntityClient.EntityConnection connection, System.Data.EntityClient.EntityTransaction transaction) { }
    public override string CommandText { get { return default(string); } set { } }
    public override int CommandTimeout { get { return default(int); } set { } }
    public System.Data.Common.CommandTrees.DbCommandTree CommandTree { get { return default(System.Data.Common.CommandTrees.DbCommandTree); } set { } }
    public override System.Data.CommandType CommandType { get { return default(System.Data.CommandType); } set { } }
    public new System.Data.EntityClient.EntityConnection Connection { get { return default(System.Data.EntityClient.EntityConnection); } set { } }
    protected override System.Data.Common.DbConnection DbConnection { get { return default(System.Data.Common.DbConnection); } set { } }
    protected override System.Data.Common.DbParameterCollection DbParameterCollection { get { return default(System.Data.Common.DbParameterCollection); } }
    protected override System.Data.Common.DbTransaction DbTransaction { get { return default(System.Data.Common.DbTransaction); } set { } }
    public override bool DesignTimeVisible { get { return default(bool); } set { } }
    public bool EnablePlanCaching { get { return default(bool); } set { } }
    public new System.Data.EntityClient.EntityParameterCollection Parameters { get { return default(System.Data.EntityClient.EntityParameterCollection); } }
    public new System.Data.EntityClient.EntityTransaction Transaction { get { return default(System.Data.EntityClient.EntityTransaction); } set { } }
    public override System.Data.UpdateRowSource UpdatedRowSource { get { return default(System.Data.UpdateRowSource); } set { } }
    public override void Cancel() { }
    protected override System.Data.Common.DbParameter CreateDbParameter() { return default(System.Data.Common.DbParameter); }
    public new System.Data.EntityClient.EntityParameter CreateParameter() { return default(System.Data.EntityClient.EntityParameter); }
    protected override System.Data.Common.DbDataReader ExecuteDbDataReader(System.Data.CommandBehavior behavior) { return default(System.Data.Common.DbDataReader); }
    public override int ExecuteNonQuery() { return default(int); }
    public new System.Data.EntityClient.EntityDataReader ExecuteReader() { return default(System.Data.EntityClient.EntityDataReader); }
    public new System.Data.EntityClient.EntityDataReader ExecuteReader(System.Data.CommandBehavior behavior) { return default(System.Data.EntityClient.EntityDataReader); }
    public override object ExecuteScalar() { return default(object); }
    public override void Prepare() { }
    [System.ComponentModel.BrowsableAttribute(false)]
    public string ToTraceString() { return default(string); }
  }
  public sealed partial class EntityConnection : System.Data.Common.DbConnection {
    public EntityConnection() { }
    public EntityConnection(System.Data.Metadata.Edm.MetadataWorkspace workspace, System.Data.Common.DbConnection connection) { }
    public EntityConnection(string connectionString) { }
    public override string ConnectionString { get { return default(string); } set { } }
    public override int ConnectionTimeout { get { return default(int); } }
    public override string Database { get { return default(string); } }
    public override string DataSource { get { return default(string); } }
    protected override System.Data.Common.DbProviderFactory DbProviderFactory { get { return default(System.Data.Common.DbProviderFactory); } }
    public override string ServerVersion { get { return default(string); } }
    public override System.Data.ConnectionState State { get { return default(System.Data.ConnectionState); } }
    public System.Data.Common.DbConnection StoreConnection { get { return default(System.Data.Common.DbConnection); } }
    protected override System.Data.Common.DbTransaction BeginDbTransaction(System.Data.IsolationLevel isolationLevel) { return default(System.Data.Common.DbTransaction); }
    public new System.Data.EntityClient.EntityTransaction BeginTransaction() { return default(System.Data.EntityClient.EntityTransaction); }
    public new System.Data.EntityClient.EntityTransaction BeginTransaction(System.Data.IsolationLevel isolationLevel) { return default(System.Data.EntityClient.EntityTransaction); }
    public override void ChangeDatabase(string databaseName) { }
    public override void Close() { }
    public new System.Data.EntityClient.EntityCommand CreateCommand() { return default(System.Data.EntityClient.EntityCommand); }
    protected override System.Data.Common.DbCommand CreateDbCommand() { return default(System.Data.Common.DbCommand); }
    protected override void Dispose(bool disposing) { }
    public override void EnlistTransaction(System.Transactions.Transaction transaction) { }
    [System.CLSCompliantAttribute(false)]
    public System.Data.Metadata.Edm.MetadataWorkspace GetMetadataWorkspace() { return default(System.Data.Metadata.Edm.MetadataWorkspace); }
    public override void Open() { }
  }
  public sealed partial class EntityConnectionStringBuilder : System.Data.Common.DbConnectionStringBuilder {
    public EntityConnectionStringBuilder() { }
    public EntityConnectionStringBuilder(string connectionString) { }
    public override bool IsFixedSize { get { return default(bool); } }
    public override object this[string keyword] { get { return default(object); } set { } }
    public override System.Collections.ICollection Keys { get { return default(System.Collections.ICollection); } }
    [System.ComponentModel.DisplayNameAttribute("Metadata")]
    [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
    [System.Data.EntityResCategoryAttribute("EntityDataCategory_Context")]
    [System.Data.EntityResDescriptionAttribute("EntityConnectionString_Metadata")]
    public string Metadata { get { return default(string); } set { } }
    [System.ComponentModel.DisplayNameAttribute("Name")]
    [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
    [System.Data.EntityResCategoryAttribute("EntityDataCategory_NamedConnectionString")]
    [System.Data.EntityResDescriptionAttribute("EntityConnectionString_Name")]
    public string Name { get { return default(string); } set { } }
    [System.ComponentModel.DisplayNameAttribute("Provider")]
    [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
    [System.Data.EntityResCategoryAttribute("EntityDataCategory_Source")]
    [System.Data.EntityResDescriptionAttribute("EntityConnectionString_Provider")]
    public string Provider { get { return default(string); } set { } }
    [System.ComponentModel.DisplayNameAttribute("Provider Connection String")]
    [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
    [System.Data.EntityResCategoryAttribute("EntityDataCategory_Source")]
    [System.Data.EntityResDescriptionAttribute("EntityConnectionString_ProviderConnectionString")]
    public string ProviderConnectionString { get { return default(string); } set { } }
    public override void Clear() { }
    public override bool ContainsKey(string keyword) { return default(bool); }
    public override bool Remove(string keyword) { return default(bool); }
    public override bool TryGetValue(string keyword, out object value) { value = default(object); return default(bool); }
  }
  public partial class EntityDataReader : System.Data.Common.DbDataReader, System.Data.IDataRecord, System.Data.IExtendedDataRecord {
    internal EntityDataReader() { }
    public System.Data.Common.DataRecordInfo DataRecordInfo { get { return default(System.Data.Common.DataRecordInfo); } }
    public override int Depth { get { return default(int); } }
    public override int FieldCount { get { return default(int); } }
    public override bool HasRows { get { return default(bool); } }
    public override bool IsClosed { get { return default(bool); } }
    public override object this[int ordinal] { get { return default(object); } }
    public override object this[string name] { get { return default(object); } }
    public override int RecordsAffected { get { return default(int); } }
    public override int VisibleFieldCount { get { return default(int); } }
    public override void Close() { }
    protected override void Dispose(bool disposing) { }
    public override bool GetBoolean(int ordinal) { return default(bool); }
    public override byte GetByte(int ordinal) { return default(byte); }
    public override long GetBytes(int ordinal, long dataOffset, System.Byte[] buffer, int bufferOffset, int length) { return default(long); }
    public override char GetChar(int ordinal) { return default(char); }
    public override long GetChars(int ordinal, long dataOffset, System.Char[] buffer, int bufferOffset, int length) { return default(long); }
    public System.Data.Common.DbDataReader GetDataReader(int i) { return default(System.Data.Common.DbDataReader); }
    public System.Data.Common.DbDataRecord GetDataRecord(int i) { return default(System.Data.Common.DbDataRecord); }
    public override string GetDataTypeName(int ordinal) { return default(string); }
    public override System.DateTime GetDateTime(int ordinal) { return default(System.DateTime); }
    protected override System.Data.Common.DbDataReader GetDbDataReader(int ordinal) { return default(System.Data.Common.DbDataReader); }
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
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public override System.Type GetProviderSpecificFieldType(int ordinal) { return default(System.Type); }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public override object GetProviderSpecificValue(int ordinal) { return default(object); }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public override int GetProviderSpecificValues(System.Object[] values) { return default(int); }
    public override System.Data.DataTable GetSchemaTable() { return default(System.Data.DataTable); }
    public override string GetString(int ordinal) { return default(string); }
    public override object GetValue(int ordinal) { return default(object); }
    public override int GetValues(System.Object[] values) { return default(int); }
    public override bool IsDBNull(int ordinal) { return default(bool); }
    public override bool NextResult() { return default(bool); }
    public override bool Read() { return default(bool); }
  }
  public sealed partial class EntityParameter : System.Data.Common.DbParameter, System.Data.IDataParameter, System.Data.IDbDataParameter {
    public EntityParameter() { }
    public EntityParameter(string parameterName, System.Data.DbType dbType) { }
    public EntityParameter(string parameterName, System.Data.DbType dbType, int size) { }
    public EntityParameter(string parameterName, System.Data.DbType dbType, int size, System.Data.ParameterDirection direction, bool isNullable, byte precision, byte scale, string sourceColumn, System.Data.DataRowVersion sourceVersion, object value) { }
    public EntityParameter(string parameterName, System.Data.DbType dbType, int size, string sourceColumn) { }
    public override System.Data.DbType DbType { get { return default(System.Data.DbType); } set { } }
    [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
    [System.Data.EntityResCategoryAttribute("DataCategory_Data")]
    [System.Data.EntityResDescriptionAttribute("DbParameter_Direction")]
    public override System.Data.ParameterDirection Direction { get { return default(System.Data.ParameterDirection); } set { } }
    public System.Data.Metadata.Edm.EdmType EdmType { get { return default(System.Data.Metadata.Edm.EdmType); } set { } }
    public override bool IsNullable { get { return default(bool); } set { } }
    public override string ParameterName { get { return default(string); } set { } }
    public new byte Precision { get { return default(byte); } set { } }
    public new byte Scale { get { return default(byte); } set { } }
    [System.Data.EntityResCategoryAttribute("DataCategory_Data")]
    [System.Data.EntityResDescriptionAttribute("DbParameter_Size")]
    public override int Size { get { return default(int); } set { } }
    [System.Data.EntityResCategoryAttribute("DataCategory_Update")]
    [System.Data.EntityResDescriptionAttribute("DbParameter_SourceColumn")]
    public override string SourceColumn { get { return default(string); } set { } }
    public override bool SourceColumnNullMapping { get { return default(bool); } set { } }
    [System.Data.EntityResCategoryAttribute("DataCategory_Update")]
    [System.Data.EntityResDescriptionAttribute("DbParameter_SourceVersion")]
    public override System.Data.DataRowVersion SourceVersion { get { return default(System.Data.DataRowVersion); } set { } }
    public override object Value { get { return default(object); } set { } }
    public override void ResetDbType() { }
    public override string ToString() { return default(string); }
  }
  public sealed partial class EntityParameterCollection : System.Data.Common.DbParameterCollection {
    internal EntityParameterCollection() { }
    public override int Count { get { return default(int); } }
    public override bool IsFixedSize { get { return default(bool); } }
    public override bool IsReadOnly { get { return default(bool); } }
    public override bool IsSynchronized { get { return default(bool); } }
    public new System.Data.EntityClient.EntityParameter this[int index] { get { return default(System.Data.EntityClient.EntityParameter); } set { } }
    public new System.Data.EntityClient.EntityParameter this[string parameterName] { get { return default(System.Data.EntityClient.EntityParameter); } set { } }
    public override object SyncRoot { get { return default(object); } }
    public System.Data.EntityClient.EntityParameter Add(System.Data.EntityClient.EntityParameter value) { return default(System.Data.EntityClient.EntityParameter); }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public override int Add(object value) { return default(int); }
    public System.Data.EntityClient.EntityParameter Add(string parameterName, System.Data.DbType dbType) { return default(System.Data.EntityClient.EntityParameter); }
    public System.Data.EntityClient.EntityParameter Add(string parameterName, System.Data.DbType dbType, int size) { return default(System.Data.EntityClient.EntityParameter); }
    public override void AddRange(System.Array values) { }
    public void AddRange(System.Data.EntityClient.EntityParameter[] values) { }
    public System.Data.EntityClient.EntityParameter AddWithValue(string parameterName, object value) { return default(System.Data.EntityClient.EntityParameter); }
    public override void Clear() { }
    public override bool Contains(object value) { return default(bool); }
    public override bool Contains(string parameterName) { return default(bool); }
    public override void CopyTo(System.Array array, int index) { }
    public void CopyTo(System.Data.EntityClient.EntityParameter[] array, int index) { }
    public override System.Collections.IEnumerator GetEnumerator() { return default(System.Collections.IEnumerator); }
    protected override System.Data.Common.DbParameter GetParameter(int index) { return default(System.Data.Common.DbParameter); }
    protected override System.Data.Common.DbParameter GetParameter(string parameterName) { return default(System.Data.Common.DbParameter); }
    public int IndexOf(System.Data.EntityClient.EntityParameter value) { return default(int); }
    public override int IndexOf(object value) { return default(int); }
    public override int IndexOf(string parameterName) { return default(int); }
    public void Insert(int index, System.Data.EntityClient.EntityParameter value) { }
    public override void Insert(int index, object value) { }
    public void Remove(System.Data.EntityClient.EntityParameter value) { }
    public override void Remove(object value) { }
    public override void RemoveAt(int index) { }
    public override void RemoveAt(string parameterName) { }
    protected override void SetParameter(int index, System.Data.Common.DbParameter value) { }
    protected override void SetParameter(string parameterName, System.Data.Common.DbParameter value) { }
  }
  public sealed partial class EntityProviderFactory : System.Data.Common.DbProviderFactory, System.IServiceProvider {
    internal EntityProviderFactory() { }
    public static readonly System.Data.EntityClient.EntityProviderFactory Instance;
    public override System.Data.Common.DbCommand CreateCommand() { return default(System.Data.Common.DbCommand); }
    public override System.Data.Common.DbCommandBuilder CreateCommandBuilder() { return default(System.Data.Common.DbCommandBuilder); }
    public override System.Data.Common.DbConnection CreateConnection() { return default(System.Data.Common.DbConnection); }
    public override System.Data.Common.DbConnectionStringBuilder CreateConnectionStringBuilder() { return default(System.Data.Common.DbConnectionStringBuilder); }
    public override System.Data.Common.DbDataAdapter CreateDataAdapter() { return default(System.Data.Common.DbDataAdapter); }
    public override System.Data.Common.DbParameter CreateParameter() { return default(System.Data.Common.DbParameter); }
    public override System.Security.CodeAccessPermission CreatePermission(System.Security.Permissions.PermissionState state) { return default(System.Security.CodeAccessPermission); }
    object System.IServiceProvider.GetService(System.Type serviceType) { return default(object); }
  }
  public sealed partial class EntityTransaction : System.Data.Common.DbTransaction {
    internal EntityTransaction() { }
    public new System.Data.EntityClient.EntityConnection Connection { get { return default(System.Data.EntityClient.EntityConnection); } }
    protected override System.Data.Common.DbConnection DbConnection { get { return default(System.Data.Common.DbConnection); } }
    public override System.Data.IsolationLevel IsolationLevel { get { return default(System.Data.IsolationLevel); } }
    public override void Commit() { }
    protected override void Dispose(bool disposing) { }
    public override void Rollback() { }
  }
}
namespace System.Data.Mapping {
  public abstract partial class EntityViewContainer {
    protected EntityViewContainer() { }
    public string EdmEntityContainerName { get { return default(string); } set { } }
    public string HashOverAllExtentViews { get { return default(string); } set { } }
    public string HashOverMappingClosure { get { return default(string); } set { } }
    public string StoreEntityContainerName { get { return default(string); } set { } }
    public int ViewCount { get { return default(int); } protected set { } }
    protected abstract System.Collections.Generic.KeyValuePair<System.String, System.String> GetViewAt(int index);
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(1), AllowMultiple=true)]
  public sealed partial class EntityViewGenerationAttribute : System.Attribute {
    public EntityViewGenerationAttribute(System.Type viewGenerationType) { }
    public System.Type ViewGenerationType { get { return default(System.Type); } }
  }
  [System.CLSCompliantAttribute(false)]
  public abstract partial class MappingItemCollection : System.Data.Metadata.Edm.ItemCollection {
    internal MappingItemCollection() { }
  }
  [System.CLSCompliantAttribute(false)]
  public partial class StorageMappingItemCollection : System.Data.Mapping.MappingItemCollection {
    public StorageMappingItemCollection(System.Data.Metadata.Edm.EdmItemCollection edmCollection, System.Data.Metadata.Edm.StoreItemCollection storeCollection, System.Collections.Generic.IEnumerable<System.Xml.XmlReader> xmlReaders) { }
    public StorageMappingItemCollection(System.Data.Metadata.Edm.EdmItemCollection edmCollection, System.Data.Metadata.Edm.StoreItemCollection storeCollection, params System.String[] filePaths) { }
    public double MappingVersion { get { return default(double); } }
  }
}
namespace System.Data.Metadata.Edm {
  public sealed partial class AssociationEndMember : System.Data.Metadata.Edm.RelationshipEndMember {
    internal AssociationEndMember() { }
    public override System.Data.Metadata.Edm.BuiltInTypeKind BuiltInTypeKind { get { return default(System.Data.Metadata.Edm.BuiltInTypeKind); } }
  }
  public sealed partial class AssociationSet : System.Data.Metadata.Edm.RelationshipSet {
    internal AssociationSet() { }
    [System.Data.Metadata.Edm.MetadataPropertyAttribute((System.Data.Metadata.Edm.BuiltInTypeKind)(1), true)]
    public System.Data.Metadata.Edm.ReadOnlyMetadataCollection<System.Data.Metadata.Edm.AssociationSetEnd> AssociationSetEnds { get { return default(System.Data.Metadata.Edm.ReadOnlyMetadataCollection<System.Data.Metadata.Edm.AssociationSetEnd>); } }
    public override System.Data.Metadata.Edm.BuiltInTypeKind BuiltInTypeKind { get { return default(System.Data.Metadata.Edm.BuiltInTypeKind); } }
    public new System.Data.Metadata.Edm.AssociationType ElementType { get { return default(System.Data.Metadata.Edm.AssociationType); } }
  }
  public sealed partial class AssociationSetEnd : System.Data.Metadata.Edm.MetadataItem {
    internal AssociationSetEnd() { }
    public override System.Data.Metadata.Edm.BuiltInTypeKind BuiltInTypeKind { get { return default(System.Data.Metadata.Edm.BuiltInTypeKind); } }
    [System.Data.Metadata.Edm.MetadataPropertyAttribute((System.Data.Metadata.Edm.BuiltInTypeKind)(0), false)]
    public System.Data.Metadata.Edm.AssociationEndMember CorrespondingAssociationEndMember { get { return default(System.Data.Metadata.Edm.AssociationEndMember); } }
    [System.Data.Metadata.Edm.MetadataPropertyAttribute((System.Data.Metadata.Edm.BuiltInTypeKind)(13), false)]
    public System.Data.Metadata.Edm.EntitySet EntitySet { get { return default(System.Data.Metadata.Edm.EntitySet); } }
    [System.Data.Metadata.Edm.MetadataPropertyAttribute((System.Data.Metadata.Edm.PrimitiveTypeKind)(12), false)]
    public string Name { get { return default(string); } }
    [System.Data.Metadata.Edm.MetadataPropertyAttribute((System.Data.Metadata.Edm.BuiltInTypeKind)(2), false)]
    public System.Data.Metadata.Edm.AssociationSet ParentAssociationSet { get { return default(System.Data.Metadata.Edm.AssociationSet); } }
    [System.Data.Metadata.Edm.MetadataPropertyAttribute((System.Data.Metadata.Edm.PrimitiveTypeKind)(12), false)]
    [System.ObsoleteAttribute("This property is going away, please use the Name property instead")]
    public string Role { get { return default(string); } }
    public override string ToString() { return default(string); }
  }
  public sealed partial class AssociationType : System.Data.Metadata.Edm.RelationshipType {
    internal AssociationType() { }
    public System.Data.Metadata.Edm.ReadOnlyMetadataCollection<System.Data.Metadata.Edm.AssociationEndMember> AssociationEndMembers { get { return default(System.Data.Metadata.Edm.ReadOnlyMetadataCollection<System.Data.Metadata.Edm.AssociationEndMember>); } }
    public override System.Data.Metadata.Edm.BuiltInTypeKind BuiltInTypeKind { get { return default(System.Data.Metadata.Edm.BuiltInTypeKind); } }
    [System.Data.Metadata.Edm.MetadataPropertyAttribute((System.Data.Metadata.Edm.PrimitiveTypeKind)(1), false)]
    public bool IsForeignKey { get { return default(bool); } }
    [System.Data.Metadata.Edm.MetadataPropertyAttribute((System.Data.Metadata.Edm.BuiltInTypeKind)(30), true)]
    public System.Data.Metadata.Edm.ReadOnlyMetadataCollection<System.Data.Metadata.Edm.ReferentialConstraint> ReferentialConstraints { get { return default(System.Data.Metadata.Edm.ReadOnlyMetadataCollection<System.Data.Metadata.Edm.ReferentialConstraint>); } }
  }
  public enum BuiltInTypeKind {
    AssociationEndMember = 0,
    AssociationSet = 2,
    AssociationSetEnd = 1,
    AssociationType = 3,
    CollectionKind = 7,
    CollectionType = 6,
    ComplexType = 8,
    Documentation = 9,
    EdmFunction = 18,
    EdmMember = 24,
    EdmProperty = 28,
    EdmType = 11,
    EntityContainer = 12,
    EntitySet = 13,
    EntitySetBase = 4,
    EntityType = 14,
    EntityTypeBase = 5,
    EnumMember = 16,
    EnumType = 15,
    Facet = 17,
    FunctionParameter = 19,
    GlobalItem = 20,
    MetadataItem = 23,
    MetadataProperty = 21,
    NavigationProperty = 22,
    OperationAction = 10,
    ParameterMode = 25,
    PrimitiveType = 26,
    PrimitiveTypeKind = 27,
    ProviderManifest = 29,
    ReferentialConstraint = 30,
    RefType = 31,
    RelationshipEndMember = 32,
    RelationshipMultiplicity = 33,
    RelationshipSet = 34,
    RelationshipType = 35,
    RowType = 36,
    SimpleType = 37,
    StructuralType = 38,
    TypeUsage = 39,
  }
  public enum CollectionKind {
    Bag = 1,
    List = 2,
    None = 0,
  }
  public sealed partial class CollectionType : System.Data.Metadata.Edm.EdmType {
    internal CollectionType() { }
    public override System.Data.Metadata.Edm.BuiltInTypeKind BuiltInTypeKind { get { return default(System.Data.Metadata.Edm.BuiltInTypeKind); } }
    [System.Data.Metadata.Edm.MetadataPropertyAttribute((System.Data.Metadata.Edm.BuiltInTypeKind)(39), false)]
    public System.Data.Metadata.Edm.TypeUsage TypeUsage { get { return default(System.Data.Metadata.Edm.TypeUsage); } }
  }
  public partial class ComplexType : System.Data.Metadata.Edm.StructuralType {
    internal ComplexType() { }
    public override System.Data.Metadata.Edm.BuiltInTypeKind BuiltInTypeKind { get { return default(System.Data.Metadata.Edm.BuiltInTypeKind); } }
    public System.Data.Metadata.Edm.ReadOnlyMetadataCollection<System.Data.Metadata.Edm.EdmProperty> Properties { get { return default(System.Data.Metadata.Edm.ReadOnlyMetadataCollection<System.Data.Metadata.Edm.EdmProperty>); } }
  }
  public enum ConcurrencyMode {
    Fixed = 1,
    None = 0,
  }
  public enum DataSpace {
    CSpace = 1,
    CSSpace = 4,
    OCSpace = 3,
    OSpace = 0,
    SSpace = 2,
  }
  public sealed partial class Documentation : System.Data.Metadata.Edm.MetadataItem {
    internal Documentation() { }
    public override System.Data.Metadata.Edm.BuiltInTypeKind BuiltInTypeKind { get { return default(System.Data.Metadata.Edm.BuiltInTypeKind); } }
    public bool IsEmpty { get { return default(bool); } }
    public string LongDescription { get { return default(string); } }
    public string Summary { get { return default(string); } }
    public override string ToString() { return default(string); }
  }
  public abstract partial class EdmError {
    internal EdmError() { }
    public string Message { get { return default(string); } }
  }
  public sealed partial class EdmFunction : System.Data.Metadata.Edm.EdmType {
    internal EdmFunction() { }
    public override System.Data.Metadata.Edm.BuiltInTypeKind BuiltInTypeKind { get { return default(System.Data.Metadata.Edm.BuiltInTypeKind); } }
    [System.Data.Metadata.Edm.MetadataPropertyAttribute((System.Data.Metadata.Edm.PrimitiveTypeKind)(12), false)]
    public string CommandTextAttribute { get { return default(string); } }
    public override string FullName { get { return default(string); } }
    [System.Data.Metadata.Edm.MetadataPropertyAttribute((System.Data.Metadata.Edm.PrimitiveTypeKind)(1), false)]
    public bool IsComposableAttribute { get { return default(bool); } }
    public System.Data.Metadata.Edm.ReadOnlyMetadataCollection<System.Data.Metadata.Edm.FunctionParameter> Parameters { get { return default(System.Data.Metadata.Edm.ReadOnlyMetadataCollection<System.Data.Metadata.Edm.FunctionParameter>); } }
    [System.Data.Metadata.Edm.MetadataPropertyAttribute((System.Data.Metadata.Edm.BuiltInTypeKind)(19), false)]
    public System.Data.Metadata.Edm.FunctionParameter ReturnParameter { get { return default(System.Data.Metadata.Edm.FunctionParameter); } }
    [System.Data.Metadata.Edm.MetadataPropertyAttribute((System.Data.Metadata.Edm.BuiltInTypeKind)(19), true)]
    public System.Data.Metadata.Edm.ReadOnlyMetadataCollection<System.Data.Metadata.Edm.FunctionParameter> ReturnParameters { get { return default(System.Data.Metadata.Edm.ReadOnlyMetadataCollection<System.Data.Metadata.Edm.FunctionParameter>); } }
  }
  [System.CLSCompliantAttribute(false)]
  public sealed partial class EdmItemCollection : System.Data.Metadata.Edm.ItemCollection {
    public EdmItemCollection(System.Collections.Generic.IEnumerable<System.Xml.XmlReader> xmlReaders) { }
    public EdmItemCollection(params System.String[] filePaths) { }
    public double EdmVersion { get { return default(double); } }
    public System.Collections.ObjectModel.ReadOnlyCollection<System.Data.Metadata.Edm.PrimitiveType> GetPrimitiveTypes() { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.Data.Metadata.Edm.PrimitiveType>); }
    public System.Collections.ObjectModel.ReadOnlyCollection<System.Data.Metadata.Edm.PrimitiveType> GetPrimitiveTypes(double edmVersion) { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.Data.Metadata.Edm.PrimitiveType>); }
  }
  public abstract partial class EdmMember : System.Data.Metadata.Edm.MetadataItem {
    internal EdmMember() { }
    public System.Data.Metadata.Edm.StructuralType DeclaringType { get { return default(System.Data.Metadata.Edm.StructuralType); } }
    [System.Data.Metadata.Edm.MetadataPropertyAttribute((System.Data.Metadata.Edm.PrimitiveTypeKind)(12), false)]
    public string Name { get { return default(string); } }
    [System.Data.Metadata.Edm.MetadataPropertyAttribute((System.Data.Metadata.Edm.BuiltInTypeKind)(39), false)]
    public System.Data.Metadata.Edm.TypeUsage TypeUsage { get { return default(System.Data.Metadata.Edm.TypeUsage); } }
    public override string ToString() { return default(string); }
  }
  public sealed partial class EdmProperty : System.Data.Metadata.Edm.EdmMember {
    internal EdmProperty() { }
    public override System.Data.Metadata.Edm.BuiltInTypeKind BuiltInTypeKind { get { return default(System.Data.Metadata.Edm.BuiltInTypeKind); } }
    public object DefaultValue { get { return default(object); } }
    public bool Nullable { get { return default(bool); } }
  }
  public sealed partial class EdmSchemaError : System.Data.Metadata.Edm.EdmError {
    internal EdmSchemaError() { }
    public int Column { get { return default(int); } }
    public int ErrorCode { get { return default(int); } }
    public int Line { get { return default(int); } }
    public string SchemaLocation { get { return default(string); } }
    public string SchemaName { get { return default(string); } }
    public System.Data.Metadata.Edm.EdmSchemaErrorSeverity Severity { get { return default(System.Data.Metadata.Edm.EdmSchemaErrorSeverity); } set { } }
    public string StackTrace { get { return default(string); } }
    public override string ToString() { return default(string); }
  }
  public enum EdmSchemaErrorSeverity {
    Error = 1,
    Warning = 0,
  }
  public abstract partial class EdmType : System.Data.Metadata.Edm.GlobalItem {
    internal EdmType() { }
    [System.Data.Metadata.Edm.MetadataPropertyAttribute((System.Data.Metadata.Edm.PrimitiveTypeKind)(1), false)]
    public bool Abstract { get { return default(bool); } }
    [System.Data.Metadata.Edm.MetadataPropertyAttribute((System.Data.Metadata.Edm.BuiltInTypeKind)(11), false)]
    public System.Data.Metadata.Edm.EdmType BaseType { get { return default(System.Data.Metadata.Edm.EdmType); } }
    public virtual string FullName { get { return default(string); } }
    [System.Data.Metadata.Edm.MetadataPropertyAttribute((System.Data.Metadata.Edm.PrimitiveTypeKind)(12), false)]
    public string Name { get { return default(string); } }
    [System.Data.Metadata.Edm.MetadataPropertyAttribute((System.Data.Metadata.Edm.PrimitiveTypeKind)(12), false)]
    public string NamespaceName { get { return default(string); } }
    public System.Data.Metadata.Edm.CollectionType GetCollectionType() { return default(System.Data.Metadata.Edm.CollectionType); }
    public override string ToString() { return default(string); }
  }
  public sealed partial class EntityContainer : System.Data.Metadata.Edm.GlobalItem {
    internal EntityContainer() { }
    [System.Data.Metadata.Edm.MetadataPropertyAttribute((System.Data.Metadata.Edm.BuiltInTypeKind)(4), true)]
    public System.Data.Metadata.Edm.ReadOnlyMetadataCollection<System.Data.Metadata.Edm.EntitySetBase> BaseEntitySets { get { return default(System.Data.Metadata.Edm.ReadOnlyMetadataCollection<System.Data.Metadata.Edm.EntitySetBase>); } }
    public override System.Data.Metadata.Edm.BuiltInTypeKind BuiltInTypeKind { get { return default(System.Data.Metadata.Edm.BuiltInTypeKind); } }
    [System.Data.Metadata.Edm.MetadataPropertyAttribute((System.Data.Metadata.Edm.BuiltInTypeKind)(18), true)]
    public System.Data.Metadata.Edm.ReadOnlyMetadataCollection<System.Data.Metadata.Edm.EdmFunction> FunctionImports { get { return default(System.Data.Metadata.Edm.ReadOnlyMetadataCollection<System.Data.Metadata.Edm.EdmFunction>); } }
    [System.Data.Metadata.Edm.MetadataPropertyAttribute((System.Data.Metadata.Edm.PrimitiveTypeKind)(12), false)]
    public string Name { get { return default(string); } }
    public System.Data.Metadata.Edm.EntitySet GetEntitySetByName(string name, bool ignoreCase) { return default(System.Data.Metadata.Edm.EntitySet); }
    public System.Data.Metadata.Edm.RelationshipSet GetRelationshipSetByName(string name, bool ignoreCase) { return default(System.Data.Metadata.Edm.RelationshipSet); }
    public override string ToString() { return default(string); }
    public bool TryGetEntitySetByName(string name, bool ignoreCase, out System.Data.Metadata.Edm.EntitySet entitySet) { entitySet = default(System.Data.Metadata.Edm.EntitySet); return default(bool); }
    public bool TryGetRelationshipSetByName(string name, bool ignoreCase, out System.Data.Metadata.Edm.RelationshipSet relationshipSet) { relationshipSet = default(System.Data.Metadata.Edm.RelationshipSet); return default(bool); }
  }
  public partial class EntitySet : System.Data.Metadata.Edm.EntitySetBase {
    internal EntitySet() { }
    public override System.Data.Metadata.Edm.BuiltInTypeKind BuiltInTypeKind { get { return default(System.Data.Metadata.Edm.BuiltInTypeKind); } }
    public new System.Data.Metadata.Edm.EntityType ElementType { get { return default(System.Data.Metadata.Edm.EntityType); } }
  }
  public abstract partial class EntitySetBase : System.Data.Metadata.Edm.MetadataItem {
    internal EntitySetBase() { }
    public override System.Data.Metadata.Edm.BuiltInTypeKind BuiltInTypeKind { get { return default(System.Data.Metadata.Edm.BuiltInTypeKind); } }
    [System.Data.Metadata.Edm.MetadataPropertyAttribute((System.Data.Metadata.Edm.BuiltInTypeKind)(5), false)]
    public System.Data.Metadata.Edm.EntityTypeBase ElementType { get { return default(System.Data.Metadata.Edm.EntityTypeBase); } }
    public System.Data.Metadata.Edm.EntityContainer EntityContainer { get { return default(System.Data.Metadata.Edm.EntityContainer); } }
    [System.Data.Metadata.Edm.MetadataPropertyAttribute((System.Data.Metadata.Edm.PrimitiveTypeKind)(12), false)]
    public string Name { get { return default(string); } }
    public override string ToString() { return default(string); }
  }
  public partial class EntityType : System.Data.Metadata.Edm.EntityTypeBase {
    internal EntityType() { }
    public override System.Data.Metadata.Edm.BuiltInTypeKind BuiltInTypeKind { get { return default(System.Data.Metadata.Edm.BuiltInTypeKind); } }
    public System.Data.Metadata.Edm.ReadOnlyMetadataCollection<System.Data.Metadata.Edm.NavigationProperty> NavigationProperties { get { return default(System.Data.Metadata.Edm.ReadOnlyMetadataCollection<System.Data.Metadata.Edm.NavigationProperty>); } }
    public System.Data.Metadata.Edm.ReadOnlyMetadataCollection<System.Data.Metadata.Edm.EdmProperty> Properties { get { return default(System.Data.Metadata.Edm.ReadOnlyMetadataCollection<System.Data.Metadata.Edm.EdmProperty>); } }
    public System.Data.Metadata.Edm.RefType GetReferenceType() { return default(System.Data.Metadata.Edm.RefType); }
  }
  public abstract partial class EntityTypeBase : System.Data.Metadata.Edm.StructuralType {
    internal EntityTypeBase() { }
    [System.Data.Metadata.Edm.MetadataPropertyAttribute((System.Data.Metadata.Edm.BuiltInTypeKind)(24), true)]
    public System.Data.Metadata.Edm.ReadOnlyMetadataCollection<System.Data.Metadata.Edm.EdmMember> KeyMembers { get { return default(System.Data.Metadata.Edm.ReadOnlyMetadataCollection<System.Data.Metadata.Edm.EdmMember>); } }
  }
  public sealed partial class EnumMember : System.Data.Metadata.Edm.MetadataItem {
    internal EnumMember() { }
    public override System.Data.Metadata.Edm.BuiltInTypeKind BuiltInTypeKind { get { return default(System.Data.Metadata.Edm.BuiltInTypeKind); } }
    [System.Data.Metadata.Edm.MetadataPropertyAttribute((System.Data.Metadata.Edm.PrimitiveTypeKind)(12), false)]
    public string Name { get { return default(string); } }
    [System.Data.Metadata.Edm.MetadataPropertyAttribute((System.Data.Metadata.Edm.BuiltInTypeKind)(26), false)]
    public object Value { get { return default(object); } }
    public override string ToString() { return default(string); }
  }
  public partial class EnumType : System.Data.Metadata.Edm.SimpleType {
    internal EnumType() { }
    public override System.Data.Metadata.Edm.BuiltInTypeKind BuiltInTypeKind { get { return default(System.Data.Metadata.Edm.BuiltInTypeKind); } }
    [System.Data.Metadata.Edm.MetadataPropertyAttribute((System.Data.Metadata.Edm.PrimitiveTypeKind)(1), false)]
    public bool IsFlags { get { return default(bool); } }
    [System.Data.Metadata.Edm.MetadataPropertyAttribute((System.Data.Metadata.Edm.BuiltInTypeKind)(16), true)]
    public System.Data.Metadata.Edm.ReadOnlyMetadataCollection<System.Data.Metadata.Edm.EnumMember> Members { get { return default(System.Data.Metadata.Edm.ReadOnlyMetadataCollection<System.Data.Metadata.Edm.EnumMember>); } }
    [System.Data.Metadata.Edm.MetadataPropertyAttribute((System.Data.Metadata.Edm.BuiltInTypeKind)(26), false)]
    public System.Data.Metadata.Edm.PrimitiveType UnderlyingType { get { return default(System.Data.Metadata.Edm.PrimitiveType); } }
  }
  [System.Diagnostics.DebuggerDisplayAttribute("{Name,nq}={Value}")]
  public sealed partial class Facet : System.Data.Metadata.Edm.MetadataItem {
    internal Facet() { }
    public override System.Data.Metadata.Edm.BuiltInTypeKind BuiltInTypeKind { get { return default(System.Data.Metadata.Edm.BuiltInTypeKind); } }
    public System.Data.Metadata.Edm.FacetDescription Description { get { return default(System.Data.Metadata.Edm.FacetDescription); } }
    [System.Data.Metadata.Edm.MetadataPropertyAttribute((System.Data.Metadata.Edm.BuiltInTypeKind)(11), false)]
    public System.Data.Metadata.Edm.EdmType FacetType { get { return default(System.Data.Metadata.Edm.EdmType); } }
    public bool IsUnbounded { get { return default(bool); } }
    [System.Data.Metadata.Edm.MetadataPropertyAttribute((System.Data.Metadata.Edm.PrimitiveTypeKind)(12), false)]
    public string Name { get { return default(string); } }
    [System.Data.Metadata.Edm.MetadataPropertyAttribute(typeof(object), false)]
    public object Value { get { return default(object); } }
    public override string ToString() { return default(string); }
  }
  public sealed partial class FacetDescription {
    internal FacetDescription() { }
    public object DefaultValue { get { return default(object); } }
    public string FacetName { get { return default(string); } }
    public System.Data.Metadata.Edm.EdmType FacetType { get { return default(System.Data.Metadata.Edm.EdmType); } }
    public bool IsConstant { get { return default(bool); } }
    public bool IsRequired { get { return default(bool); } }
    public System.Nullable<System.Int32> MaxValue { get { return default(System.Nullable<System.Int32>); } }
    public System.Nullable<System.Int32> MinValue { get { return default(System.Nullable<System.Int32>); } }
    public override string ToString() { return default(string); }
  }
  public sealed partial class FunctionParameter : System.Data.Metadata.Edm.MetadataItem {
    internal FunctionParameter() { }
    public override System.Data.Metadata.Edm.BuiltInTypeKind BuiltInTypeKind { get { return default(System.Data.Metadata.Edm.BuiltInTypeKind); } }
    public System.Data.Metadata.Edm.EdmFunction DeclaringFunction { get { return default(System.Data.Metadata.Edm.EdmFunction); } }
    [System.Data.Metadata.Edm.MetadataPropertyAttribute((System.Data.Metadata.Edm.BuiltInTypeKind)(25), false)]
    public System.Data.Metadata.Edm.ParameterMode Mode { get { return default(System.Data.Metadata.Edm.ParameterMode); } }
    [System.Data.Metadata.Edm.MetadataPropertyAttribute((System.Data.Metadata.Edm.PrimitiveTypeKind)(12), false)]
    public string Name { get { return default(string); } }
    [System.Data.Metadata.Edm.MetadataPropertyAttribute((System.Data.Metadata.Edm.BuiltInTypeKind)(39), false)]
    public System.Data.Metadata.Edm.TypeUsage TypeUsage { get { return default(System.Data.Metadata.Edm.TypeUsage); } }
    public override string ToString() { return default(string); }
  }
  public abstract partial class GlobalItem : System.Data.Metadata.Edm.MetadataItem {
    internal GlobalItem() { }
  }
  [System.CLSCompliantAttribute(false)]
  public abstract partial class ItemCollection : System.Data.Metadata.Edm.ReadOnlyMetadataCollection<System.Data.Metadata.Edm.GlobalItem> {
    internal ItemCollection() { }
    public System.Data.Metadata.Edm.DataSpace DataSpace { get { return default(System.Data.Metadata.Edm.DataSpace); } }
    public System.Data.Metadata.Edm.EntityContainer GetEntityContainer(string name) { return default(System.Data.Metadata.Edm.EntityContainer); }
    public System.Data.Metadata.Edm.EntityContainer GetEntityContainer(string name, bool ignoreCase) { return default(System.Data.Metadata.Edm.EntityContainer); }
    protected static System.Collections.ObjectModel.ReadOnlyCollection<System.Data.Metadata.Edm.EdmFunction> GetFunctions(System.Collections.Generic.Dictionary<System.String, System.Collections.ObjectModel.ReadOnlyCollection<System.Data.Metadata.Edm.EdmFunction>> functionCollection, string functionName, bool ignoreCase) { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.Data.Metadata.Edm.EdmFunction>); }
    public System.Collections.ObjectModel.ReadOnlyCollection<System.Data.Metadata.Edm.EdmFunction> GetFunctions(string functionName) { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.Data.Metadata.Edm.EdmFunction>); }
    public System.Collections.ObjectModel.ReadOnlyCollection<System.Data.Metadata.Edm.EdmFunction> GetFunctions(string functionName, bool ignoreCase) { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.Data.Metadata.Edm.EdmFunction>); }
    public T GetItem<T>(string identity) where T : System.Data.Metadata.Edm.GlobalItem { return default(T); }
    public T GetItem<T>(string identity, bool ignoreCase) where T : System.Data.Metadata.Edm.GlobalItem { return default(T); }
    public virtual System.Collections.ObjectModel.ReadOnlyCollection<T> GetItems<T>() where T : System.Data.Metadata.Edm.GlobalItem { return default(System.Collections.ObjectModel.ReadOnlyCollection<T>); }
    public System.Data.Metadata.Edm.EdmType GetType(string name, string namespaceName) { return default(System.Data.Metadata.Edm.EdmType); }
    public System.Data.Metadata.Edm.EdmType GetType(string name, string namespaceName, bool ignoreCase) { return default(System.Data.Metadata.Edm.EdmType); }
    public bool TryGetEntityContainer(string name, bool ignoreCase, out System.Data.Metadata.Edm.EntityContainer entityContainer) { entityContainer = default(System.Data.Metadata.Edm.EntityContainer); return default(bool); }
    public bool TryGetEntityContainer(string name, out System.Data.Metadata.Edm.EntityContainer entityContainer) { entityContainer = default(System.Data.Metadata.Edm.EntityContainer); return default(bool); }
    public bool TryGetItem<T>(string identity, out T item) where T : System.Data.Metadata.Edm.GlobalItem { item = default(T); return default(bool); }
    public bool TryGetItem<T>(string identity, bool ignoreCase, out T item) where T : System.Data.Metadata.Edm.GlobalItem { item = default(T); return default(bool); }
    public bool TryGetType(string name, string namespaceName, bool ignoreCase, out System.Data.Metadata.Edm.EdmType type) { type = default(System.Data.Metadata.Edm.EdmType); return default(bool); }
    public bool TryGetType(string name, string namespaceName, out System.Data.Metadata.Edm.EdmType type) { type = default(System.Data.Metadata.Edm.EdmType); return default(bool); }
  }
  public abstract partial class MetadataItem {
    internal MetadataItem() { }
    public abstract System.Data.Metadata.Edm.BuiltInTypeKind BuiltInTypeKind { get; }
    public System.Data.Metadata.Edm.Documentation Documentation { get { return default(System.Data.Metadata.Edm.Documentation); } set { } }
    [System.Data.Metadata.Edm.MetadataPropertyAttribute((System.Data.Metadata.Edm.BuiltInTypeKind)(21), true)]
    public System.Data.Metadata.Edm.ReadOnlyMetadataCollection<System.Data.Metadata.Edm.MetadataProperty> MetadataProperties { get { return default(System.Data.Metadata.Edm.ReadOnlyMetadataCollection<System.Data.Metadata.Edm.MetadataProperty>); } }
    public static System.Data.Metadata.Edm.EdmType GetBuiltInType(System.Data.Metadata.Edm.BuiltInTypeKind builtInTypeKind) { return default(System.Data.Metadata.Edm.EdmType); }
    public static System.Collections.ObjectModel.ReadOnlyCollection<System.Data.Metadata.Edm.FacetDescription> GetGeneralFacetDescriptions() { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.Data.Metadata.Edm.FacetDescription>); }
  }
  public sealed partial class MetadataProperty : System.Data.Metadata.Edm.MetadataItem {
    internal MetadataProperty() { }
    public override System.Data.Metadata.Edm.BuiltInTypeKind BuiltInTypeKind { get { return default(System.Data.Metadata.Edm.BuiltInTypeKind); } }
    [System.Data.Metadata.Edm.MetadataPropertyAttribute((System.Data.Metadata.Edm.PrimitiveTypeKind)(12), false)]
    public string Name { get { return default(string); } }
    public System.Data.Metadata.Edm.PropertyKind PropertyKind { get { return default(System.Data.Metadata.Edm.PropertyKind); } }
    [System.Data.Metadata.Edm.MetadataPropertyAttribute((System.Data.Metadata.Edm.BuiltInTypeKind)(39), false)]
    public System.Data.Metadata.Edm.TypeUsage TypeUsage { get { return default(System.Data.Metadata.Edm.TypeUsage); } }
    [System.Data.Metadata.Edm.MetadataPropertyAttribute(typeof(object), false)]
    public object Value { get { return default(object); } }
  }
  public sealed partial class MetadataWorkspace {
    public static readonly double MaximumEdmVersionSupported;
    public MetadataWorkspace() { }
    public MetadataWorkspace(System.Collections.Generic.IEnumerable<System.String> paths, System.Collections.Generic.IEnumerable<System.Reflection.Assembly> assembliesToConsider) { }
    public static void ClearCache() { }
    public System.Data.Common.EntitySql.EntitySqlParser CreateEntitySqlParser() { return default(System.Data.Common.EntitySql.EntitySqlParser); }
    public System.Data.Common.CommandTrees.DbQueryCommandTree CreateQueryCommandTree(System.Data.Common.CommandTrees.DbExpression query) { return default(System.Data.Common.CommandTrees.DbQueryCommandTree); }
    public System.Data.Metadata.Edm.EnumType GetEdmSpaceType(System.Data.Metadata.Edm.EnumType objectSpaceType) { return default(System.Data.Metadata.Edm.EnumType); }
    public System.Data.Metadata.Edm.StructuralType GetEdmSpaceType(System.Data.Metadata.Edm.StructuralType objectSpaceType) { return default(System.Data.Metadata.Edm.StructuralType); }
    public System.Data.Metadata.Edm.EntityContainer GetEntityContainer(string name, bool ignoreCase, System.Data.Metadata.Edm.DataSpace dataSpace) { return default(System.Data.Metadata.Edm.EntityContainer); }
    public System.Data.Metadata.Edm.EntityContainer GetEntityContainer(string name, System.Data.Metadata.Edm.DataSpace dataSpace) { return default(System.Data.Metadata.Edm.EntityContainer); }
    public System.Collections.ObjectModel.ReadOnlyCollection<System.Data.Metadata.Edm.EdmFunction> GetFunctions(string name, string namespaceName, System.Data.Metadata.Edm.DataSpace dataSpace) { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.Data.Metadata.Edm.EdmFunction>); }
    public System.Collections.ObjectModel.ReadOnlyCollection<System.Data.Metadata.Edm.EdmFunction> GetFunctions(string name, string namespaceName, System.Data.Metadata.Edm.DataSpace dataSpace, bool ignoreCase) { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.Data.Metadata.Edm.EdmFunction>); }
    public T GetItem<T>(string identity, bool ignoreCase, System.Data.Metadata.Edm.DataSpace dataSpace) where T : System.Data.Metadata.Edm.GlobalItem { return default(T); }
    public T GetItem<T>(string identity, System.Data.Metadata.Edm.DataSpace dataSpace) where T : System.Data.Metadata.Edm.GlobalItem { return default(T); }
    [System.CLSCompliantAttribute(false)]
    public System.Data.Metadata.Edm.ItemCollection GetItemCollection(System.Data.Metadata.Edm.DataSpace dataSpace) { return default(System.Data.Metadata.Edm.ItemCollection); }
    public System.Collections.ObjectModel.ReadOnlyCollection<System.Data.Metadata.Edm.GlobalItem> GetItems(System.Data.Metadata.Edm.DataSpace dataSpace) { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.Data.Metadata.Edm.GlobalItem>); }
    public System.Collections.ObjectModel.ReadOnlyCollection<T> GetItems<T>(System.Data.Metadata.Edm.DataSpace dataSpace) where T : System.Data.Metadata.Edm.GlobalItem { return default(System.Collections.ObjectModel.ReadOnlyCollection<T>); }
    public System.Data.Metadata.Edm.EnumType GetObjectSpaceType(System.Data.Metadata.Edm.EnumType edmSpaceType) { return default(System.Data.Metadata.Edm.EnumType); }
    public System.Data.Metadata.Edm.StructuralType GetObjectSpaceType(System.Data.Metadata.Edm.StructuralType edmSpaceType) { return default(System.Data.Metadata.Edm.StructuralType); }
    public System.Collections.ObjectModel.ReadOnlyCollection<System.Data.Metadata.Edm.PrimitiveType> GetPrimitiveTypes(System.Data.Metadata.Edm.DataSpace dataSpace) { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.Data.Metadata.Edm.PrimitiveType>); }
    public System.Collections.ObjectModel.ReadOnlyCollection<System.Data.Metadata.Edm.EdmMember> GetRelevantMembersForUpdate(System.Data.Metadata.Edm.EntitySetBase entitySet, System.Data.Metadata.Edm.EntityTypeBase entityType, bool partialUpdateSupported) { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.Data.Metadata.Edm.EdmMember>); }
    [System.ObsoleteAttribute("Use MetadataWorkspace.GetRelevantMembersForUpdate(EntitySetBase, EntityTypeBase, bool) instead")]
    public System.Collections.Generic.IEnumerable<System.Data.Metadata.Edm.EdmMember> GetRequiredOriginalValueMembers(System.Data.Metadata.Edm.EntitySetBase entitySet, System.Data.Metadata.Edm.EntityTypeBase entityType) { return default(System.Collections.Generic.IEnumerable<System.Data.Metadata.Edm.EdmMember>); }
    public System.Data.Metadata.Edm.EdmType GetType(string name, string namespaceName, bool ignoreCase, System.Data.Metadata.Edm.DataSpace dataSpace) { return default(System.Data.Metadata.Edm.EdmType); }
    public System.Data.Metadata.Edm.EdmType GetType(string name, string namespaceName, System.Data.Metadata.Edm.DataSpace dataSpace) { return default(System.Data.Metadata.Edm.EdmType); }
    public void LoadFromAssembly(System.Reflection.Assembly assembly) { }
    public void LoadFromAssembly(System.Reflection.Assembly assembly, System.Action<System.String> logLoadMessage) { }
    [System.CLSCompliantAttribute(false)]
    public void RegisterItemCollection(System.Data.Metadata.Edm.ItemCollection collection) { }
    public bool TryGetEdmSpaceType(System.Data.Metadata.Edm.EnumType objectSpaceType, out System.Data.Metadata.Edm.EnumType edmSpaceType) { edmSpaceType = default(System.Data.Metadata.Edm.EnumType); return default(bool); }
    public bool TryGetEdmSpaceType(System.Data.Metadata.Edm.StructuralType objectSpaceType, out System.Data.Metadata.Edm.StructuralType edmSpaceType) { edmSpaceType = default(System.Data.Metadata.Edm.StructuralType); return default(bool); }
    public bool TryGetEntityContainer(string name, bool ignoreCase, System.Data.Metadata.Edm.DataSpace dataSpace, out System.Data.Metadata.Edm.EntityContainer entityContainer) { entityContainer = default(System.Data.Metadata.Edm.EntityContainer); return default(bool); }
    public bool TryGetEntityContainer(string name, System.Data.Metadata.Edm.DataSpace dataSpace, out System.Data.Metadata.Edm.EntityContainer entityContainer) { entityContainer = default(System.Data.Metadata.Edm.EntityContainer); return default(bool); }
    public bool TryGetItem<T>(string identity, bool ignoreCase, System.Data.Metadata.Edm.DataSpace dataSpace, out T item) where T : System.Data.Metadata.Edm.GlobalItem { item = default(T); return default(bool); }
    public bool TryGetItem<T>(string identity, System.Data.Metadata.Edm.DataSpace space, out T item) where T : System.Data.Metadata.Edm.GlobalItem { item = default(T); return default(bool); }
    [System.CLSCompliantAttribute(false)]
    public bool TryGetItemCollection(System.Data.Metadata.Edm.DataSpace dataSpace, out System.Data.Metadata.Edm.ItemCollection collection) { collection = default(System.Data.Metadata.Edm.ItemCollection); return default(bool); }
    public bool TryGetObjectSpaceType(System.Data.Metadata.Edm.EnumType edmSpaceType, out System.Data.Metadata.Edm.EnumType objectSpaceType) { objectSpaceType = default(System.Data.Metadata.Edm.EnumType); return default(bool); }
    public bool TryGetObjectSpaceType(System.Data.Metadata.Edm.StructuralType edmSpaceType, out System.Data.Metadata.Edm.StructuralType objectSpaceType) { objectSpaceType = default(System.Data.Metadata.Edm.StructuralType); return default(bool); }
    public bool TryGetType(string name, string namespaceName, bool ignoreCase, System.Data.Metadata.Edm.DataSpace dataSpace, out System.Data.Metadata.Edm.EdmType type) { type = default(System.Data.Metadata.Edm.EdmType); return default(bool); }
    public bool TryGetType(string name, string namespaceName, System.Data.Metadata.Edm.DataSpace dataSpace, out System.Data.Metadata.Edm.EdmType type) { type = default(System.Data.Metadata.Edm.EdmType); return default(bool); }
  }
  public sealed partial class NavigationProperty : System.Data.Metadata.Edm.EdmMember {
    internal NavigationProperty() { }
    public override System.Data.Metadata.Edm.BuiltInTypeKind BuiltInTypeKind { get { return default(System.Data.Metadata.Edm.BuiltInTypeKind); } }
    [System.Data.Metadata.Edm.MetadataPropertyAttribute((System.Data.Metadata.Edm.BuiltInTypeKind)(32), false)]
    public System.Data.Metadata.Edm.RelationshipEndMember FromEndMember { get { return default(System.Data.Metadata.Edm.RelationshipEndMember); } }
    [System.Data.Metadata.Edm.MetadataPropertyAttribute((System.Data.Metadata.Edm.BuiltInTypeKind)(35), false)]
    public System.Data.Metadata.Edm.RelationshipType RelationshipType { get { return default(System.Data.Metadata.Edm.RelationshipType); } }
    [System.Data.Metadata.Edm.MetadataPropertyAttribute((System.Data.Metadata.Edm.BuiltInTypeKind)(32), false)]
    public System.Data.Metadata.Edm.RelationshipEndMember ToEndMember { get { return default(System.Data.Metadata.Edm.RelationshipEndMember); } }
    public System.Collections.Generic.IEnumerable<System.Data.Metadata.Edm.EdmProperty> GetDependentProperties() { return default(System.Collections.Generic.IEnumerable<System.Data.Metadata.Edm.EdmProperty>); }
  }
  [System.CLSCompliantAttribute(false)]
  public sealed partial class ObjectItemCollection : System.Data.Metadata.Edm.ItemCollection {
    public ObjectItemCollection() { }
    public System.Type GetClrType(System.Data.Metadata.Edm.EnumType objectSpaceType) { return default(System.Type); }
    public System.Type GetClrType(System.Data.Metadata.Edm.StructuralType objectSpaceType) { return default(System.Type); }
    public override System.Collections.ObjectModel.ReadOnlyCollection<T> GetItems<T>() { return default(System.Collections.ObjectModel.ReadOnlyCollection<T>); }
    public System.Collections.Generic.IEnumerable<System.Data.Metadata.Edm.PrimitiveType> GetPrimitiveTypes() { return default(System.Collections.Generic.IEnumerable<System.Data.Metadata.Edm.PrimitiveType>); }
    public void LoadFromAssembly(System.Reflection.Assembly assembly) { }
    public void LoadFromAssembly(System.Reflection.Assembly assembly, System.Data.Metadata.Edm.EdmItemCollection edmItemCollection) { }
    public void LoadFromAssembly(System.Reflection.Assembly assembly, System.Data.Metadata.Edm.EdmItemCollection edmItemCollection, System.Action<System.String> logLoadMessage) { }
    public bool TryGetClrType(System.Data.Metadata.Edm.EnumType objectSpaceType, out System.Type clrType) { clrType = default(System.Type); return default(bool); }
    public bool TryGetClrType(System.Data.Metadata.Edm.StructuralType objectSpaceType, out System.Type clrType) { clrType = default(System.Type); return default(bool); }
  }
  public enum OperationAction {
    Cascade = 1,
    None = 0,
    Restrict = 2,
  }
  public enum ParameterMode {
    In = 0,
    InOut = 2,
    Out = 1,
    ReturnValue = 3,
  }
  public enum ParameterTypeSemantics {
    AllowImplicitConversion = 0,
    AllowImplicitPromotion = 1,
    ExactMatchOnly = 2,
  }
  public sealed partial class PrimitiveType : System.Data.Metadata.Edm.SimpleType {
    internal PrimitiveType() { }
    public override System.Data.Metadata.Edm.BuiltInTypeKind BuiltInTypeKind { get { return default(System.Data.Metadata.Edm.BuiltInTypeKind); } }
    public System.Type ClrEquivalentType { get { return default(System.Type); } }
    public System.Collections.ObjectModel.ReadOnlyCollection<System.Data.Metadata.Edm.FacetDescription> FacetDescriptions { get { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.Data.Metadata.Edm.FacetDescription>); } }
    [System.Data.Metadata.Edm.MetadataPropertyAttribute((System.Data.Metadata.Edm.BuiltInTypeKind)(27), false)]
    public System.Data.Metadata.Edm.PrimitiveTypeKind PrimitiveTypeKind { get { return default(System.Data.Metadata.Edm.PrimitiveTypeKind); } }
    public System.Data.Metadata.Edm.EdmType GetEdmPrimitiveType() { return default(System.Data.Metadata.Edm.EdmType); }
    public static System.Data.Metadata.Edm.PrimitiveType GetEdmPrimitiveType(System.Data.Metadata.Edm.PrimitiveTypeKind primitiveTypeKind) { return default(System.Data.Metadata.Edm.PrimitiveType); }
    public static System.Collections.ObjectModel.ReadOnlyCollection<System.Data.Metadata.Edm.PrimitiveType> GetEdmPrimitiveTypes() { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.Data.Metadata.Edm.PrimitiveType>); }
  }
  public enum PrimitiveTypeKind {
    Binary = 0,
    Boolean = 1,
    Byte = 2,
    DateTime = 3,
    DateTimeOffset = 14,
    Decimal = 4,
    Double = 5,
    Geography = 16,
    GeographyCollection = 30,
    GeographyLineString = 25,
    GeographyMultiLineString = 28,
    GeographyMultiPoint = 27,
    GeographyMultiPolygon = 29,
    GeographyPoint = 24,
    GeographyPolygon = 26,
    Geometry = 15,
    GeometryCollection = 23,
    GeometryLineString = 18,
    GeometryMultiLineString = 21,
    GeometryMultiPoint = 20,
    GeometryMultiPolygon = 22,
    GeometryPoint = 17,
    GeometryPolygon = 19,
    Guid = 6,
    Int16 = 9,
    Int32 = 10,
    Int64 = 11,
    SByte = 8,
    Single = 7,
    String = 12,
    Time = 13,
  }
  public enum PropertyKind {
    Extended = 1,
    System = 0,
  }
  public partial class ReadOnlyMetadataCollection<T> : System.Collections.ObjectModel.ReadOnlyCollection<T> where T : System.Data.Metadata.Edm.MetadataItem {
    internal ReadOnlyMetadataCollection() : base (default(System.Collections.Generic.IList<T>)) { }
    public bool IsReadOnly { get { return default(bool); } }
    public virtual T this[string identity] { get { return default(T); } }
    public virtual bool Contains(string identity) { return default(bool); }
    public new System.Data.Metadata.Edm.ReadOnlyMetadataCollection<T>.Enumerator GetEnumerator() { return default(System.Data.Metadata.Edm.ReadOnlyMetadataCollection<T>.Enumerator); }
    public virtual T GetValue(string identity, bool ignoreCase) { return default(T); }
    public virtual new int IndexOf(T value) { return default(int); }
    public virtual bool TryGetValue(string identity, bool ignoreCase, out T item) { item = default(T); return default(bool); }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct Enumerator : System.Collections.Generic.IEnumerator<T>, System.Collections.IEnumerator, System.IDisposable {
      public T Current { get { return default(T); } }
      object System.Collections.IEnumerator.Current { get { return default(object); } }
      public void Dispose() { }
      public bool MoveNext() { return default(bool); }
      public void Reset() { }
    }
  }
  public sealed partial class ReferentialConstraint : System.Data.Metadata.Edm.MetadataItem {
    internal ReferentialConstraint() { }
    public override System.Data.Metadata.Edm.BuiltInTypeKind BuiltInTypeKind { get { return default(System.Data.Metadata.Edm.BuiltInTypeKind); } }
    [System.Data.Metadata.Edm.MetadataPropertyAttribute((System.Data.Metadata.Edm.BuiltInTypeKind)(28), true)]
    public System.Data.Metadata.Edm.ReadOnlyMetadataCollection<System.Data.Metadata.Edm.EdmProperty> FromProperties { get { return default(System.Data.Metadata.Edm.ReadOnlyMetadataCollection<System.Data.Metadata.Edm.EdmProperty>); } }
    [System.Data.Metadata.Edm.MetadataPropertyAttribute((System.Data.Metadata.Edm.BuiltInTypeKind)(32), false)]
    public System.Data.Metadata.Edm.RelationshipEndMember FromRole { get { return default(System.Data.Metadata.Edm.RelationshipEndMember); } }
    [System.Data.Metadata.Edm.MetadataPropertyAttribute((System.Data.Metadata.Edm.BuiltInTypeKind)(28), true)]
    public System.Data.Metadata.Edm.ReadOnlyMetadataCollection<System.Data.Metadata.Edm.EdmProperty> ToProperties { get { return default(System.Data.Metadata.Edm.ReadOnlyMetadataCollection<System.Data.Metadata.Edm.EdmProperty>); } }
    [System.Data.Metadata.Edm.MetadataPropertyAttribute((System.Data.Metadata.Edm.BuiltInTypeKind)(32), false)]
    public System.Data.Metadata.Edm.RelationshipEndMember ToRole { get { return default(System.Data.Metadata.Edm.RelationshipEndMember); } }
    public override string ToString() { return default(string); }
  }
  public sealed partial class RefType : System.Data.Metadata.Edm.EdmType {
    internal RefType() { }
    public override System.Data.Metadata.Edm.BuiltInTypeKind BuiltInTypeKind { get { return default(System.Data.Metadata.Edm.BuiltInTypeKind); } }
    [System.Data.Metadata.Edm.MetadataPropertyAttribute((System.Data.Metadata.Edm.BuiltInTypeKind)(5), false)]
    public System.Data.Metadata.Edm.EntityTypeBase ElementType { get { return default(System.Data.Metadata.Edm.EntityTypeBase); } }
  }
  public abstract partial class RelationshipEndMember : System.Data.Metadata.Edm.EdmMember {
    internal RelationshipEndMember() { }
    [System.Data.Metadata.Edm.MetadataPropertyAttribute((System.Data.Metadata.Edm.BuiltInTypeKind)(10), true)]
    public System.Data.Metadata.Edm.OperationAction DeleteBehavior { get { return default(System.Data.Metadata.Edm.OperationAction); } }
    [System.Data.Metadata.Edm.MetadataPropertyAttribute((System.Data.Metadata.Edm.BuiltInTypeKind)(33), false)]
    public System.Data.Metadata.Edm.RelationshipMultiplicity RelationshipMultiplicity { get { return default(System.Data.Metadata.Edm.RelationshipMultiplicity); } }
    public System.Data.Metadata.Edm.EntityType GetEntityType() { return default(System.Data.Metadata.Edm.EntityType); }
  }
  public enum RelationshipMultiplicity {
    Many = 2,
    One = 1,
    ZeroOrOne = 0,
  }
  public abstract partial class RelationshipSet : System.Data.Metadata.Edm.EntitySetBase {
    internal RelationshipSet() { }
    public override System.Data.Metadata.Edm.BuiltInTypeKind BuiltInTypeKind { get { return default(System.Data.Metadata.Edm.BuiltInTypeKind); } }
    public new System.Data.Metadata.Edm.RelationshipType ElementType { get { return default(System.Data.Metadata.Edm.RelationshipType); } }
  }
  public abstract partial class RelationshipType : System.Data.Metadata.Edm.EntityTypeBase {
    internal RelationshipType() { }
    public System.Data.Metadata.Edm.ReadOnlyMetadataCollection<System.Data.Metadata.Edm.RelationshipEndMember> RelationshipEndMembers { get { return default(System.Data.Metadata.Edm.ReadOnlyMetadataCollection<System.Data.Metadata.Edm.RelationshipEndMember>); } }
  }
  public sealed partial class RowType : System.Data.Metadata.Edm.StructuralType {
    internal RowType() { }
    public override System.Data.Metadata.Edm.BuiltInTypeKind BuiltInTypeKind { get { return default(System.Data.Metadata.Edm.BuiltInTypeKind); } }
    public System.Data.Metadata.Edm.ReadOnlyMetadataCollection<System.Data.Metadata.Edm.EdmProperty> Properties { get { return default(System.Data.Metadata.Edm.ReadOnlyMetadataCollection<System.Data.Metadata.Edm.EdmProperty>); } }
  }
  public abstract partial class SimpleType : System.Data.Metadata.Edm.EdmType {
    internal SimpleType() { }
  }
  public enum StoreGeneratedPattern {
    Computed = 2,
    Identity = 1,
    None = 0,
  }
  [System.CLSCompliantAttribute(false)]
  public sealed partial class StoreItemCollection : System.Data.Metadata.Edm.ItemCollection {
    public StoreItemCollection(System.Collections.Generic.IEnumerable<System.Xml.XmlReader> xmlReaders) { }
    public StoreItemCollection(params System.String[] filePaths) { }
    public double StoreSchemaVersion { get { return default(double); } }
    public System.Collections.ObjectModel.ReadOnlyCollection<System.Data.Metadata.Edm.PrimitiveType> GetPrimitiveTypes() { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.Data.Metadata.Edm.PrimitiveType>); }
  }
  public abstract partial class StructuralType : System.Data.Metadata.Edm.EdmType {
    internal StructuralType() { }
    [System.Data.Metadata.Edm.MetadataPropertyAttribute((System.Data.Metadata.Edm.BuiltInTypeKind)(24), true)]
    public System.Data.Metadata.Edm.ReadOnlyMetadataCollection<System.Data.Metadata.Edm.EdmMember> Members { get { return default(System.Data.Metadata.Edm.ReadOnlyMetadataCollection<System.Data.Metadata.Edm.EdmMember>); } }
  }
  [System.Diagnostics.DebuggerDisplayAttribute("EdmType={EdmType}, Facets.Count={Facets.Count}")]
  public sealed partial class TypeUsage : System.Data.Metadata.Edm.MetadataItem {
    internal TypeUsage() { }
    public override System.Data.Metadata.Edm.BuiltInTypeKind BuiltInTypeKind { get { return default(System.Data.Metadata.Edm.BuiltInTypeKind); } }
    [System.Data.Metadata.Edm.MetadataPropertyAttribute((System.Data.Metadata.Edm.BuiltInTypeKind)(11), false)]
    public System.Data.Metadata.Edm.EdmType EdmType { get { return default(System.Data.Metadata.Edm.EdmType); } }
    [System.Data.Metadata.Edm.MetadataPropertyAttribute((System.Data.Metadata.Edm.BuiltInTypeKind)(17), true)]
    public System.Data.Metadata.Edm.ReadOnlyMetadataCollection<System.Data.Metadata.Edm.Facet> Facets { get { return default(System.Data.Metadata.Edm.ReadOnlyMetadataCollection<System.Data.Metadata.Edm.Facet>); } }
    public static System.Data.Metadata.Edm.TypeUsage CreateBinaryTypeUsage(System.Data.Metadata.Edm.PrimitiveType primitiveType, bool isFixedLength) { return default(System.Data.Metadata.Edm.TypeUsage); }
    public static System.Data.Metadata.Edm.TypeUsage CreateBinaryTypeUsage(System.Data.Metadata.Edm.PrimitiveType primitiveType, bool isFixedLength, int maxLength) { return default(System.Data.Metadata.Edm.TypeUsage); }
    public static System.Data.Metadata.Edm.TypeUsage CreateDateTimeOffsetTypeUsage(System.Data.Metadata.Edm.PrimitiveType primitiveType, System.Nullable<System.Byte> precision) { return default(System.Data.Metadata.Edm.TypeUsage); }
    public static System.Data.Metadata.Edm.TypeUsage CreateDateTimeTypeUsage(System.Data.Metadata.Edm.PrimitiveType primitiveType, System.Nullable<System.Byte> precision) { return default(System.Data.Metadata.Edm.TypeUsage); }
    public static System.Data.Metadata.Edm.TypeUsage CreateDecimalTypeUsage(System.Data.Metadata.Edm.PrimitiveType primitiveType) { return default(System.Data.Metadata.Edm.TypeUsage); }
    public static System.Data.Metadata.Edm.TypeUsage CreateDecimalTypeUsage(System.Data.Metadata.Edm.PrimitiveType primitiveType, byte precision, byte scale) { return default(System.Data.Metadata.Edm.TypeUsage); }
    public static System.Data.Metadata.Edm.TypeUsage CreateDefaultTypeUsage(System.Data.Metadata.Edm.EdmType edmType) { return default(System.Data.Metadata.Edm.TypeUsage); }
    public static System.Data.Metadata.Edm.TypeUsage CreateStringTypeUsage(System.Data.Metadata.Edm.PrimitiveType primitiveType, bool isUnicode, bool isFixedLength) { return default(System.Data.Metadata.Edm.TypeUsage); }
    public static System.Data.Metadata.Edm.TypeUsage CreateStringTypeUsage(System.Data.Metadata.Edm.PrimitiveType primitiveType, bool isUnicode, bool isFixedLength, int maxLength) { return default(System.Data.Metadata.Edm.TypeUsage); }
    public static System.Data.Metadata.Edm.TypeUsage CreateTimeTypeUsage(System.Data.Metadata.Edm.PrimitiveType primitiveType, System.Nullable<System.Byte> precision) { return default(System.Data.Metadata.Edm.TypeUsage); }
    public bool IsSubtypeOf(System.Data.Metadata.Edm.TypeUsage typeUsage) { return default(bool); }
    public override string ToString() { return default(string); }
  }
}
namespace System.Data.Objects {
  public sealed partial class CompiledQuery {
    internal CompiledQuery() { }
    public static System.Func<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TResult> Compile<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TResult>(System.Linq.Expressions.Expression<System.Func<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TResult>> query) where TArg0 : System.Data.Objects.ObjectContext { return default(System.Func<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TResult>); }
    public static System.Func<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TResult> Compile<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TResult>(System.Linq.Expressions.Expression<System.Func<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TResult>> query) where TArg0 : System.Data.Objects.ObjectContext { return default(System.Func<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TResult>); }
    public static System.Func<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TResult> Compile<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TResult>(System.Linq.Expressions.Expression<System.Func<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TResult>> query) where TArg0 : System.Data.Objects.ObjectContext { return default(System.Func<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TResult>); }
    public static System.Func<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TResult> Compile<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TResult>(System.Linq.Expressions.Expression<System.Func<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TResult>> query) where TArg0 : System.Data.Objects.ObjectContext { return default(System.Func<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TResult>); }
    public static System.Func<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TResult> Compile<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TResult>(System.Linq.Expressions.Expression<System.Func<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TResult>> query) where TArg0 : System.Data.Objects.ObjectContext { return default(System.Func<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TResult>); }
    public static System.Func<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TResult> Compile<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TResult>(System.Linq.Expressions.Expression<System.Func<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TResult>> query) where TArg0 : System.Data.Objects.ObjectContext { return default(System.Func<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TResult>); }
    public static System.Func<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TResult> Compile<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TResult>(System.Linq.Expressions.Expression<System.Func<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TResult>> query) where TArg0 : System.Data.Objects.ObjectContext { return default(System.Func<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TResult>); }
    public static System.Func<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TResult> Compile<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TResult>(System.Linq.Expressions.Expression<System.Func<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TResult>> query) where TArg0 : System.Data.Objects.ObjectContext { return default(System.Func<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TResult>); }
    public static System.Func<TArg0, TResult> Compile<TArg0, TResult>(System.Linq.Expressions.Expression<System.Func<TArg0, TResult>> query) where TArg0 : System.Data.Objects.ObjectContext { return default(System.Func<TArg0, TResult>); }
    public static System.Func<TArg0, TArg1, TResult> Compile<TArg0, TArg1, TResult>(System.Linq.Expressions.Expression<System.Func<TArg0, TArg1, TResult>> query) where TArg0 : System.Data.Objects.ObjectContext { return default(System.Func<TArg0, TArg1, TResult>); }
    public static System.Func<TArg0, TArg1, TArg2, TResult> Compile<TArg0, TArg1, TArg2, TResult>(System.Linq.Expressions.Expression<System.Func<TArg0, TArg1, TArg2, TResult>> query) where TArg0 : System.Data.Objects.ObjectContext { return default(System.Func<TArg0, TArg1, TArg2, TResult>); }
    public static System.Func<TArg0, TArg1, TArg2, TArg3, TResult> Compile<TArg0, TArg1, TArg2, TArg3, TResult>(System.Linq.Expressions.Expression<System.Func<TArg0, TArg1, TArg2, TArg3, TResult>> query) where TArg0 : System.Data.Objects.ObjectContext { return default(System.Func<TArg0, TArg1, TArg2, TArg3, TResult>); }
    public static System.Func<TArg0, TArg1, TArg2, TArg3, TArg4, TResult> Compile<TArg0, TArg1, TArg2, TArg3, TArg4, TResult>(System.Linq.Expressions.Expression<System.Func<TArg0, TArg1, TArg2, TArg3, TArg4, TResult>> query) where TArg0 : System.Data.Objects.ObjectContext { return default(System.Func<TArg0, TArg1, TArg2, TArg3, TArg4, TResult>); }
    public static System.Func<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TResult> Compile<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TResult>(System.Linq.Expressions.Expression<System.Func<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TResult>> query) where TArg0 : System.Data.Objects.ObjectContext { return default(System.Func<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TResult>); }
    public static System.Func<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TResult> Compile<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TResult>(System.Linq.Expressions.Expression<System.Func<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TResult>> query) where TArg0 : System.Data.Objects.ObjectContext { return default(System.Func<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TResult>); }
    public static System.Func<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TResult> Compile<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TResult>(System.Linq.Expressions.Expression<System.Func<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TResult>> query) where TArg0 : System.Data.Objects.ObjectContext { return default(System.Func<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TResult>); }
  }
  public abstract partial class CurrentValueRecord : System.Data.Objects.DbUpdatableDataRecord {
    internal CurrentValueRecord() { }
  }
  public abstract partial class DbUpdatableDataRecord : System.Data.Common.DbDataRecord, System.Data.IDataRecord, System.Data.IExtendedDataRecord {
    internal DbUpdatableDataRecord() { }
    public virtual System.Data.Common.DataRecordInfo DataRecordInfo { get { return default(System.Data.Common.DataRecordInfo); } }
    public override int FieldCount { get { return default(int); } }
    public override object this[int ordinal] { get { return default(object); } }
    public override object this[string name] { get { return default(object); } }
    public override bool GetBoolean(int ordinal) { return default(bool); }
    public override byte GetByte(int ordinal) { return default(byte); }
    public override long GetBytes(int ordinal, long dataIndex, System.Byte[] buffer, int bufferIndex, int length) { return default(long); }
    public override char GetChar(int ordinal) { return default(char); }
    public override long GetChars(int ordinal, long dataIndex, System.Char[] buffer, int bufferIndex, int length) { return default(long); }
    public System.Data.Common.DbDataReader GetDataReader(int i) { return default(System.Data.Common.DbDataReader); }
    public System.Data.Common.DbDataRecord GetDataRecord(int ordinal) { return default(System.Data.Common.DbDataRecord); }
    public override string GetDataTypeName(int ordinal) { return default(string); }
    public override System.DateTime GetDateTime(int ordinal) { return default(System.DateTime); }
    protected override System.Data.Common.DbDataReader GetDbDataReader(int ordinal) { return default(System.Data.Common.DbDataReader); }
    public override decimal GetDecimal(int ordinal) { return default(decimal); }
    public override double GetDouble(int ordinal) { return default(double); }
    public override System.Type GetFieldType(int ordinal) { return default(System.Type); }
    public override float GetFloat(int ordinal) { return default(float); }
    public override System.Guid GetGuid(int ordinal) { return default(System.Guid); }
    public override short GetInt16(int ordinal) { return default(short); }
    public override int GetInt32(int ordinal) { return default(int); }
    public override long GetInt64(int ordinal) { return default(long); }
    public override string GetName(int ordinal) { return default(string); }
    public override int GetOrdinal(string name) { return default(int); }
    protected abstract object GetRecordValue(int ordinal);
    public override string GetString(int ordinal) { return default(string); }
    public override object GetValue(int ordinal) { return default(object); }
    public override int GetValues(System.Object[] values) { return default(int); }
    public override bool IsDBNull(int ordinal) { return default(bool); }
    public void SetBoolean(int ordinal, bool value) { }
    public void SetByte(int ordinal, byte value) { }
    public void SetChar(int ordinal, char value) { }
    public void SetDataRecord(int ordinal, System.Data.IDataRecord value) { }
    public void SetDateTime(int ordinal, System.DateTime value) { }
    public void SetDBNull(int ordinal) { }
    public void SetDecimal(int ordinal, decimal value) { }
    public void SetDouble(int ordinal, double value) { }
    public void SetFloat(int ordinal, float value) { }
    public void SetGuid(int ordinal, System.Guid value) { }
    public void SetInt16(int ordinal, short value) { }
    public void SetInt32(int ordinal, int value) { }
    public void SetInt64(int ordinal, long value) { }
    protected abstract void SetRecordValue(int ordinal, object value);
    public void SetString(int ordinal, string value) { }
    public void SetValue(int ordinal, object value) { }
    public int SetValues(params System.Object[] values) { return default(int); }
    System.Data.IDataReader System.Data.IDataRecord.GetData(int ordinal) { return default(System.Data.IDataReader); }
  }
  public static partial class EntityFunctions {
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("Edm", "AddDays")]
    public static System.Nullable<System.DateTime> AddDays(System.Nullable<System.DateTime> dateValue, System.Nullable<System.Int32> addValue) { return default(System.Nullable<System.DateTime>); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("Edm", "AddDays")]
    public static System.Nullable<System.DateTimeOffset> AddDays(System.Nullable<System.DateTimeOffset> dateValue, System.Nullable<System.Int32> addValue) { return default(System.Nullable<System.DateTimeOffset>); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("Edm", "AddHours")]
    public static System.Nullable<System.DateTime> AddHours(System.Nullable<System.DateTime> timeValue, System.Nullable<System.Int32> addValue) { return default(System.Nullable<System.DateTime>); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("Edm", "AddHours")]
    public static System.Nullable<System.DateTimeOffset> AddHours(System.Nullable<System.DateTimeOffset> timeValue, System.Nullable<System.Int32> addValue) { return default(System.Nullable<System.DateTimeOffset>); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("Edm", "AddHours")]
    public static System.Nullable<System.TimeSpan> AddHours(System.Nullable<System.TimeSpan> timeValue, System.Nullable<System.Int32> addValue) { return default(System.Nullable<System.TimeSpan>); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("Edm", "AddMicroseconds")]
    public static System.Nullable<System.DateTime> AddMicroseconds(System.Nullable<System.DateTime> timeValue, System.Nullable<System.Int32> addValue) { return default(System.Nullable<System.DateTime>); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("Edm", "AddMicroseconds")]
    public static System.Nullable<System.DateTimeOffset> AddMicroseconds(System.Nullable<System.DateTimeOffset> timeValue, System.Nullable<System.Int32> addValue) { return default(System.Nullable<System.DateTimeOffset>); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("Edm", "AddMicroseconds")]
    public static System.Nullable<System.TimeSpan> AddMicroseconds(System.Nullable<System.TimeSpan> timeValue, System.Nullable<System.Int32> addValue) { return default(System.Nullable<System.TimeSpan>); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("Edm", "AddMilliseconds")]
    public static System.Nullable<System.DateTime> AddMilliseconds(System.Nullable<System.DateTime> timeValue, System.Nullable<System.Int32> addValue) { return default(System.Nullable<System.DateTime>); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("Edm", "AddMilliseconds")]
    public static System.Nullable<System.DateTimeOffset> AddMilliseconds(System.Nullable<System.DateTimeOffset> timeValue, System.Nullable<System.Int32> addValue) { return default(System.Nullable<System.DateTimeOffset>); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("Edm", "AddMilliseconds")]
    public static System.Nullable<System.TimeSpan> AddMilliseconds(System.Nullable<System.TimeSpan> timeValue, System.Nullable<System.Int32> addValue) { return default(System.Nullable<System.TimeSpan>); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("Edm", "AddMinutes")]
    public static System.Nullable<System.DateTime> AddMinutes(System.Nullable<System.DateTime> timeValue, System.Nullable<System.Int32> addValue) { return default(System.Nullable<System.DateTime>); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("Edm", "AddMinutes")]
    public static System.Nullable<System.DateTimeOffset> AddMinutes(System.Nullable<System.DateTimeOffset> timeValue, System.Nullable<System.Int32> addValue) { return default(System.Nullable<System.DateTimeOffset>); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("Edm", "AddMinutes")]
    public static System.Nullable<System.TimeSpan> AddMinutes(System.Nullable<System.TimeSpan> timeValue, System.Nullable<System.Int32> addValue) { return default(System.Nullable<System.TimeSpan>); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("Edm", "AddMonths")]
    public static System.Nullable<System.DateTime> AddMonths(System.Nullable<System.DateTime> dateValue, System.Nullable<System.Int32> addValue) { return default(System.Nullable<System.DateTime>); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("Edm", "AddMonths")]
    public static System.Nullable<System.DateTimeOffset> AddMonths(System.Nullable<System.DateTimeOffset> dateValue, System.Nullable<System.Int32> addValue) { return default(System.Nullable<System.DateTimeOffset>); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("Edm", "AddNanoseconds")]
    public static System.Nullable<System.DateTime> AddNanoseconds(System.Nullable<System.DateTime> timeValue, System.Nullable<System.Int32> addValue) { return default(System.Nullable<System.DateTime>); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("Edm", "AddNanoseconds")]
    public static System.Nullable<System.DateTimeOffset> AddNanoseconds(System.Nullable<System.DateTimeOffset> timeValue, System.Nullable<System.Int32> addValue) { return default(System.Nullable<System.DateTimeOffset>); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("Edm", "AddNanoseconds")]
    public static System.Nullable<System.TimeSpan> AddNanoseconds(System.Nullable<System.TimeSpan> timeValue, System.Nullable<System.Int32> addValue) { return default(System.Nullable<System.TimeSpan>); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("Edm", "AddSeconds")]
    public static System.Nullable<System.DateTime> AddSeconds(System.Nullable<System.DateTime> timeValue, System.Nullable<System.Int32> addValue) { return default(System.Nullable<System.DateTime>); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("Edm", "AddSeconds")]
    public static System.Nullable<System.DateTimeOffset> AddSeconds(System.Nullable<System.DateTimeOffset> timeValue, System.Nullable<System.Int32> addValue) { return default(System.Nullable<System.DateTimeOffset>); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("Edm", "AddSeconds")]
    public static System.Nullable<System.TimeSpan> AddSeconds(System.Nullable<System.TimeSpan> timeValue, System.Nullable<System.Int32> addValue) { return default(System.Nullable<System.TimeSpan>); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("Edm", "AddYears")]
    public static System.Nullable<System.DateTime> AddYears(System.Nullable<System.DateTime> dateValue, System.Nullable<System.Int32> addValue) { return default(System.Nullable<System.DateTime>); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("Edm", "AddYears")]
    public static System.Nullable<System.DateTimeOffset> AddYears(System.Nullable<System.DateTimeOffset> dateValue, System.Nullable<System.Int32> addValue) { return default(System.Nullable<System.DateTimeOffset>); }
    public static string AsNonUnicode(string value) { return default(string); }
    public static string AsUnicode(string value) { return default(string); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("Edm", "CreateDateTime")]
    public static System.Nullable<System.DateTime> CreateDateTime(System.Nullable<System.Int32> year, System.Nullable<System.Int32> month, System.Nullable<System.Int32> day, System.Nullable<System.Int32> hour, System.Nullable<System.Int32> minute, System.Nullable<System.Double> second) { return default(System.Nullable<System.DateTime>); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("Edm", "CreateDateTimeOffset")]
    public static System.Nullable<System.DateTimeOffset> CreateDateTimeOffset(System.Nullable<System.Int32> year, System.Nullable<System.Int32> month, System.Nullable<System.Int32> day, System.Nullable<System.Int32> hour, System.Nullable<System.Int32> minute, System.Nullable<System.Double> second, System.Nullable<System.Int32> timeZoneOffset) { return default(System.Nullable<System.DateTimeOffset>); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("Edm", "CreateTime")]
    public static System.Nullable<System.TimeSpan> CreateTime(System.Nullable<System.Int32> hour, System.Nullable<System.Int32> minute, System.Nullable<System.Double> second) { return default(System.Nullable<System.TimeSpan>); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("Edm", "DiffDays")]
    public static System.Nullable<System.Int32> DiffDays(System.Nullable<System.DateTime> dateValue1, System.Nullable<System.DateTime> dateValue2) { return default(System.Nullable<System.Int32>); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("Edm", "DiffDays")]
    public static System.Nullable<System.Int32> DiffDays(System.Nullable<System.DateTimeOffset> dateValue1, System.Nullable<System.DateTimeOffset> dateValue2) { return default(System.Nullable<System.Int32>); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("Edm", "DiffHours")]
    public static System.Nullable<System.Int32> DiffHours(System.Nullable<System.DateTime> timeValue1, System.Nullable<System.DateTime> timeValue2) { return default(System.Nullable<System.Int32>); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("Edm", "DiffHours")]
    public static System.Nullable<System.Int32> DiffHours(System.Nullable<System.DateTimeOffset> timeValue1, System.Nullable<System.DateTimeOffset> timeValue2) { return default(System.Nullable<System.Int32>); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("Edm", "DiffHours")]
    public static System.Nullable<System.Int32> DiffHours(System.Nullable<System.TimeSpan> timeValue1, System.Nullable<System.TimeSpan> timeValue2) { return default(System.Nullable<System.Int32>); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("Edm", "DiffMicroseconds")]
    public static System.Nullable<System.Int32> DiffMicroseconds(System.Nullable<System.DateTime> timeValue1, System.Nullable<System.DateTime> timeValue2) { return default(System.Nullable<System.Int32>); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("Edm", "DiffMicroseconds")]
    public static System.Nullable<System.Int32> DiffMicroseconds(System.Nullable<System.DateTimeOffset> timeValue1, System.Nullable<System.DateTimeOffset> timeValue2) { return default(System.Nullable<System.Int32>); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("Edm", "DiffMicroseconds")]
    public static System.Nullable<System.Int32> DiffMicroseconds(System.Nullable<System.TimeSpan> timeValue1, System.Nullable<System.TimeSpan> timeValue2) { return default(System.Nullable<System.Int32>); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("Edm", "DiffMilliseconds")]
    public static System.Nullable<System.Int32> DiffMilliseconds(System.Nullable<System.DateTime> timeValue1, System.Nullable<System.DateTime> timeValue2) { return default(System.Nullable<System.Int32>); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("Edm", "DiffMilliseconds")]
    public static System.Nullable<System.Int32> DiffMilliseconds(System.Nullable<System.DateTimeOffset> timeValue1, System.Nullable<System.DateTimeOffset> timeValue2) { return default(System.Nullable<System.Int32>); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("Edm", "DiffMilliseconds")]
    public static System.Nullable<System.Int32> DiffMilliseconds(System.Nullable<System.TimeSpan> timeValue1, System.Nullable<System.TimeSpan> timeValue2) { return default(System.Nullable<System.Int32>); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("Edm", "DiffMinutes")]
    public static System.Nullable<System.Int32> DiffMinutes(System.Nullable<System.DateTime> timeValue1, System.Nullable<System.DateTime> timeValue2) { return default(System.Nullable<System.Int32>); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("Edm", "DiffMinutes")]
    public static System.Nullable<System.Int32> DiffMinutes(System.Nullable<System.DateTimeOffset> timeValue1, System.Nullable<System.DateTimeOffset> timeValue2) { return default(System.Nullable<System.Int32>); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("Edm", "DiffMinutes")]
    public static System.Nullable<System.Int32> DiffMinutes(System.Nullable<System.TimeSpan> timeValue1, System.Nullable<System.TimeSpan> timeValue2) { return default(System.Nullable<System.Int32>); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("Edm", "DiffMonths")]
    public static System.Nullable<System.Int32> DiffMonths(System.Nullable<System.DateTime> dateValue1, System.Nullable<System.DateTime> dateValue2) { return default(System.Nullable<System.Int32>); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("Edm", "DiffMonths")]
    public static System.Nullable<System.Int32> DiffMonths(System.Nullable<System.DateTimeOffset> dateValue1, System.Nullable<System.DateTimeOffset> dateValue2) { return default(System.Nullable<System.Int32>); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("Edm", "DiffNanoseconds")]
    public static System.Nullable<System.Int32> DiffNanoseconds(System.Nullable<System.DateTime> timeValue1, System.Nullable<System.DateTime> timeValue2) { return default(System.Nullable<System.Int32>); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("Edm", "DiffNanoseconds")]
    public static System.Nullable<System.Int32> DiffNanoseconds(System.Nullable<System.DateTimeOffset> timeValue1, System.Nullable<System.DateTimeOffset> timeValue2) { return default(System.Nullable<System.Int32>); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("Edm", "DiffNanoseconds")]
    public static System.Nullable<System.Int32> DiffNanoseconds(System.Nullable<System.TimeSpan> timeValue1, System.Nullable<System.TimeSpan> timeValue2) { return default(System.Nullable<System.Int32>); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("Edm", "DiffSeconds")]
    public static System.Nullable<System.Int32> DiffSeconds(System.Nullable<System.DateTime> timeValue1, System.Nullable<System.DateTime> timeValue2) { return default(System.Nullable<System.Int32>); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("Edm", "DiffSeconds")]
    public static System.Nullable<System.Int32> DiffSeconds(System.Nullable<System.DateTimeOffset> timeValue1, System.Nullable<System.DateTimeOffset> timeValue2) { return default(System.Nullable<System.Int32>); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("Edm", "DiffSeconds")]
    public static System.Nullable<System.Int32> DiffSeconds(System.Nullable<System.TimeSpan> timeValue1, System.Nullable<System.TimeSpan> timeValue2) { return default(System.Nullable<System.Int32>); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("Edm", "DiffYears")]
    public static System.Nullable<System.Int32> DiffYears(System.Nullable<System.DateTime> dateValue1, System.Nullable<System.DateTime> dateValue2) { return default(System.Nullable<System.Int32>); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("Edm", "DiffYears")]
    public static System.Nullable<System.Int32> DiffYears(System.Nullable<System.DateTimeOffset> dateValue1, System.Nullable<System.DateTimeOffset> dateValue2) { return default(System.Nullable<System.Int32>); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("Edm", "GetTotalOffsetMinutes")]
    public static System.Nullable<System.Int32> GetTotalOffsetMinutes(System.Nullable<System.DateTimeOffset> dateTimeOffsetArgument) { return default(System.Nullable<System.Int32>); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("Edm", "Left")]
    public static string Left(string stringArgument, System.Nullable<System.Int64> length) { return default(string); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("Edm", "Reverse")]
    public static string Reverse(string stringArgument) { return default(string); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("Edm", "Right")]
    public static string Right(string stringArgument, System.Nullable<System.Int64> length) { return default(string); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("Edm", "StDev")]
    public static System.Nullable<System.Double> StandardDeviation(System.Collections.Generic.IEnumerable<System.Decimal> collection) { return default(System.Nullable<System.Double>); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("Edm", "StDev")]
    public static System.Nullable<System.Double> StandardDeviation(System.Collections.Generic.IEnumerable<System.Double> collection) { return default(System.Nullable<System.Double>); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("Edm", "StDev")]
    public static System.Nullable<System.Double> StandardDeviation(System.Collections.Generic.IEnumerable<System.Int32> collection) { return default(System.Nullable<System.Double>); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("Edm", "StDev")]
    public static System.Nullable<System.Double> StandardDeviation(System.Collections.Generic.IEnumerable<System.Int64> collection) { return default(System.Nullable<System.Double>); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("Edm", "StDev")]
    public static System.Nullable<System.Double> StandardDeviation(System.Collections.Generic.IEnumerable<System.Nullable<System.Decimal>> collection) { return default(System.Nullable<System.Double>); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("Edm", "StDev")]
    public static System.Nullable<System.Double> StandardDeviation(System.Collections.Generic.IEnumerable<System.Nullable<System.Double>> collection) { return default(System.Nullable<System.Double>); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("Edm", "StDev")]
    public static System.Nullable<System.Double> StandardDeviation(System.Collections.Generic.IEnumerable<System.Nullable<System.Int32>> collection) { return default(System.Nullable<System.Double>); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("Edm", "StDev")]
    public static System.Nullable<System.Double> StandardDeviation(System.Collections.Generic.IEnumerable<System.Nullable<System.Int64>> collection) { return default(System.Nullable<System.Double>); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("Edm", "StDevP")]
    public static System.Nullable<System.Double> StandardDeviationP(System.Collections.Generic.IEnumerable<System.Decimal> collection) { return default(System.Nullable<System.Double>); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("Edm", "StDevP")]
    public static System.Nullable<System.Double> StandardDeviationP(System.Collections.Generic.IEnumerable<System.Double> collection) { return default(System.Nullable<System.Double>); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("Edm", "StDevP")]
    public static System.Nullable<System.Double> StandardDeviationP(System.Collections.Generic.IEnumerable<System.Int32> collection) { return default(System.Nullable<System.Double>); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("Edm", "StDevP")]
    public static System.Nullable<System.Double> StandardDeviationP(System.Collections.Generic.IEnumerable<System.Int64> collection) { return default(System.Nullable<System.Double>); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("Edm", "StDevP")]
    public static System.Nullable<System.Double> StandardDeviationP(System.Collections.Generic.IEnumerable<System.Nullable<System.Decimal>> collection) { return default(System.Nullable<System.Double>); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("Edm", "StDevP")]
    public static System.Nullable<System.Double> StandardDeviationP(System.Collections.Generic.IEnumerable<System.Nullable<System.Double>> collection) { return default(System.Nullable<System.Double>); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("Edm", "StDevP")]
    public static System.Nullable<System.Double> StandardDeviationP(System.Collections.Generic.IEnumerable<System.Nullable<System.Int32>> collection) { return default(System.Nullable<System.Double>); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("Edm", "StDevP")]
    public static System.Nullable<System.Double> StandardDeviationP(System.Collections.Generic.IEnumerable<System.Nullable<System.Int64>> collection) { return default(System.Nullable<System.Double>); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("Edm", "Truncate")]
    public static System.Nullable<System.Decimal> Truncate(System.Nullable<System.Decimal> value, System.Nullable<System.Int32> digits) { return default(System.Nullable<System.Decimal>); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("Edm", "Truncate")]
    public static System.Nullable<System.Double> Truncate(System.Nullable<System.Double> value, System.Nullable<System.Int32> digits) { return default(System.Nullable<System.Double>); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("Edm", "TruncateTime")]
    public static System.Nullable<System.DateTime> TruncateTime(System.Nullable<System.DateTime> dateValue) { return default(System.Nullable<System.DateTime>); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("Edm", "TruncateTime")]
    public static System.Nullable<System.DateTimeOffset> TruncateTime(System.Nullable<System.DateTimeOffset> dateValue) { return default(System.Nullable<System.DateTimeOffset>); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("Edm", "Var")]
    public static System.Nullable<System.Double> Var(System.Collections.Generic.IEnumerable<System.Decimal> collection) { return default(System.Nullable<System.Double>); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("Edm", "Var")]
    public static System.Nullable<System.Double> Var(System.Collections.Generic.IEnumerable<System.Double> collection) { return default(System.Nullable<System.Double>); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("Edm", "Var")]
    public static System.Nullable<System.Double> Var(System.Collections.Generic.IEnumerable<System.Int32> collection) { return default(System.Nullable<System.Double>); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("Edm", "Var")]
    public static System.Nullable<System.Double> Var(System.Collections.Generic.IEnumerable<System.Int64> collection) { return default(System.Nullable<System.Double>); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("Edm", "Var")]
    public static System.Nullable<System.Double> Var(System.Collections.Generic.IEnumerable<System.Nullable<System.Decimal>> collection) { return default(System.Nullable<System.Double>); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("Edm", "Var")]
    public static System.Nullable<System.Double> Var(System.Collections.Generic.IEnumerable<System.Nullable<System.Double>> collection) { return default(System.Nullable<System.Double>); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("Edm", "Var")]
    public static System.Nullable<System.Double> Var(System.Collections.Generic.IEnumerable<System.Nullable<System.Int32>> collection) { return default(System.Nullable<System.Double>); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("Edm", "Var")]
    public static System.Nullable<System.Double> Var(System.Collections.Generic.IEnumerable<System.Nullable<System.Int64>> collection) { return default(System.Nullable<System.Double>); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("Edm", "VarP")]
    public static System.Nullable<System.Double> VarP(System.Collections.Generic.IEnumerable<System.Decimal> collection) { return default(System.Nullable<System.Double>); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("Edm", "VarP")]
    public static System.Nullable<System.Double> VarP(System.Collections.Generic.IEnumerable<System.Double> collection) { return default(System.Nullable<System.Double>); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("Edm", "VarP")]
    public static System.Nullable<System.Double> VarP(System.Collections.Generic.IEnumerable<System.Int32> collection) { return default(System.Nullable<System.Double>); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("Edm", "VarP")]
    public static System.Nullable<System.Double> VarP(System.Collections.Generic.IEnumerable<System.Int64> collection) { return default(System.Nullable<System.Double>); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("Edm", "VarP")]
    public static System.Nullable<System.Double> VarP(System.Collections.Generic.IEnumerable<System.Nullable<System.Decimal>> collection) { return default(System.Nullable<System.Double>); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("Edm", "VarP")]
    public static System.Nullable<System.Double> VarP(System.Collections.Generic.IEnumerable<System.Nullable<System.Double>> collection) { return default(System.Nullable<System.Double>); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("Edm", "VarP")]
    public static System.Nullable<System.Double> VarP(System.Collections.Generic.IEnumerable<System.Nullable<System.Int32>> collection) { return default(System.Nullable<System.Double>); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("Edm", "VarP")]
    public static System.Nullable<System.Double> VarP(System.Collections.Generic.IEnumerable<System.Nullable<System.Int64>> collection) { return default(System.Nullable<System.Double>); }
  }
  public partial interface IObjectSet<TEntity> : System.Collections.Generic.IEnumerable<TEntity>, System.Collections.IEnumerable, System.Linq.IQueryable, System.Linq.IQueryable<TEntity> where TEntity : class {
    void AddObject(TEntity entity);
    void Attach(TEntity entity);
    void DeleteObject(TEntity entity);
    void Detach(TEntity entity);
  }
  public enum MergeOption {
    AppendOnly = 0,
    NoTracking = 3,
    OverwriteChanges = 1,
    PreserveChanges = 2,
  }
  public partial class ObjectContext : System.IDisposable {
    public ObjectContext(System.Data.EntityClient.EntityConnection connection) { }
    protected ObjectContext(System.Data.EntityClient.EntityConnection connection, string defaultContainerName) { }
    public ObjectContext(string connectionString) { }
    protected ObjectContext(string connectionString, string defaultContainerName) { }
    public System.Nullable<System.Int32> CommandTimeout { get { return default(System.Nullable<System.Int32>); } set { } }
    public System.Data.Common.DbConnection Connection { get { return default(System.Data.Common.DbConnection); } }
    public System.Data.Objects.ObjectContextOptions ContextOptions { get { return default(System.Data.Objects.ObjectContextOptions); } }
    public string DefaultContainerName { get { return default(string); } set { } }
    [System.CLSCompliantAttribute(false)]
    public System.Data.Metadata.Edm.MetadataWorkspace MetadataWorkspace { get { return default(System.Data.Metadata.Edm.MetadataWorkspace); } }
    public System.Data.Objects.ObjectStateManager ObjectStateManager { get { return default(System.Data.Objects.ObjectStateManager); } }
    protected internal System.Linq.IQueryProvider QueryProvider { get { return default(System.Linq.IQueryProvider); } }
    public event System.Data.Objects.ObjectMaterializedEventHandler ObjectMaterialized { add { } remove { } }
    public event System.EventHandler SavingChanges { add { } remove { } }
    public void AcceptAllChanges() { }
    public void AddObject(string entitySetName, object entity) { }
    public TEntity ApplyCurrentValues<TEntity>(string entitySetName, TEntity currentEntity) where TEntity : class { return default(TEntity); }
    public TEntity ApplyOriginalValues<TEntity>(string entitySetName, TEntity originalEntity) where TEntity : class { return default(TEntity); }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.ObsoleteAttribute("Use ApplyCurrentValues instead")]
    public void ApplyPropertyChanges(string entitySetName, object changed) { }
    public void Attach(System.Data.Objects.DataClasses.IEntityWithKey entity) { }
    public void AttachTo(string entitySetName, object entity) { }
    public void CreateDatabase() { }
    public string CreateDatabaseScript() { return default(string); }
    public System.Data.EntityKey CreateEntityKey(string entitySetName, object entity) { return default(System.Data.EntityKey); }
    public T CreateObject<T>() where T : class { return default(T); }
    public System.Data.Objects.ObjectSet<TEntity> CreateObjectSet<TEntity>() where TEntity : class { return default(System.Data.Objects.ObjectSet<TEntity>); }
    public System.Data.Objects.ObjectSet<TEntity> CreateObjectSet<TEntity>(string entitySetName) where TEntity : class { return default(System.Data.Objects.ObjectSet<TEntity>); }
    public void CreateProxyTypes(System.Collections.Generic.IEnumerable<System.Type> types) { }
    public System.Data.Objects.ObjectQuery<T> CreateQuery<T>(string queryString, params System.Data.Objects.ObjectParameter[] parameters) { return default(System.Data.Objects.ObjectQuery<T>); }
    public bool DatabaseExists() { return default(bool); }
    public void DeleteDatabase() { }
    public void DeleteObject(object entity) { }
    public void Detach(object entity) { }
    public void DetectChanges() { }
    public void Dispose() { }
    protected virtual void Dispose(bool disposing) { }
    public int ExecuteFunction(string functionName, params System.Data.Objects.ObjectParameter[] parameters) { return default(int); }
    public System.Data.Objects.ObjectResult<TElement> ExecuteFunction<TElement>(string functionName, System.Data.Objects.MergeOption mergeOption, params System.Data.Objects.ObjectParameter[] parameters) { return default(System.Data.Objects.ObjectResult<TElement>); }
    public System.Data.Objects.ObjectResult<TElement> ExecuteFunction<TElement>(string functionName, params System.Data.Objects.ObjectParameter[] parameters) { return default(System.Data.Objects.ObjectResult<TElement>); }
    public int ExecuteStoreCommand(string commandText, params System.Object[] parameters) { return default(int); }
    public System.Data.Objects.ObjectResult<TElement> ExecuteStoreQuery<TElement>(string commandText, params System.Object[] parameters) { return default(System.Data.Objects.ObjectResult<TElement>); }
    public System.Data.Objects.ObjectResult<TEntity> ExecuteStoreQuery<TEntity>(string commandText, string entitySetName, System.Data.Objects.MergeOption mergeOption, params System.Object[] parameters) { return default(System.Data.Objects.ObjectResult<TEntity>); }
    public static System.Collections.Generic.IEnumerable<System.Type> GetKnownProxyTypes() { return default(System.Collections.Generic.IEnumerable<System.Type>); }
    public object GetObjectByKey(System.Data.EntityKey key) { return default(object); }
    public static System.Type GetObjectType(System.Type type) { return default(System.Type); }
    public void LoadProperty(object entity, string navigationProperty) { }
    public void LoadProperty(object entity, string navigationProperty, System.Data.Objects.MergeOption mergeOption) { }
    public void LoadProperty<TEntity>(TEntity entity, System.Linq.Expressions.Expression<System.Func<TEntity, System.Object>> selector) { }
    public void LoadProperty<TEntity>(TEntity entity, System.Linq.Expressions.Expression<System.Func<TEntity, System.Object>> selector, System.Data.Objects.MergeOption mergeOption) { }
    public void Refresh(System.Data.Objects.RefreshMode refreshMode, System.Collections.IEnumerable collection) { }
    public void Refresh(System.Data.Objects.RefreshMode refreshMode, object entity) { }
    public int SaveChanges() { return default(int); }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.ObsoleteAttribute("Use SaveChanges(SaveOptions options) instead.")]
    public int SaveChanges(bool acceptChangesDuringSave) { return default(int); }
    public virtual int SaveChanges(System.Data.Objects.SaveOptions options) { return default(int); }
    public System.Data.Objects.ObjectResult<TElement> Translate<TElement>(System.Data.Common.DbDataReader reader) { return default(System.Data.Objects.ObjectResult<TElement>); }
    public System.Data.Objects.ObjectResult<TEntity> Translate<TEntity>(System.Data.Common.DbDataReader reader, string entitySetName, System.Data.Objects.MergeOption mergeOption) { return default(System.Data.Objects.ObjectResult<TEntity>); }
    public bool TryGetObjectByKey(System.Data.EntityKey key, out object value) { value = default(object); return default(bool); }
  }
  public sealed partial class ObjectContextOptions {
    internal ObjectContextOptions() { }
    public bool LazyLoadingEnabled { get { return default(bool); } set { } }
    public bool ProxyCreationEnabled { get { return default(bool); } set { } }
    public bool UseConsistentNullReferenceBehavior { get { return default(bool); } set { } }
    public bool UseCSharpNullComparisonBehavior { get { return default(bool); } set { } }
    public bool UseLegacyPreserveChangesBehavior { get { return default(bool); } set { } }
  }
  public partial class ObjectMaterializedEventArgs : System.EventArgs {
    internal ObjectMaterializedEventArgs() { }
    public object Entity { get { return default(object); } }
  }
  public delegate void ObjectMaterializedEventHandler(object sender, System.Data.Objects.ObjectMaterializedEventArgs e);
  public sealed partial class ObjectParameter {
    public ObjectParameter(string name, object value) { }
    public ObjectParameter(string name, System.Type type) { }
    public string Name { get { return default(string); } }
    public System.Type ParameterType { get { return default(System.Type); } }
    public object Value { get { return default(object); } set { } }
  }
  public sealed partial class ObjectParameterCollection : System.Collections.Generic.ICollection<System.Data.Objects.ObjectParameter>, System.Collections.Generic.IEnumerable<System.Data.Objects.ObjectParameter>, System.Collections.IEnumerable {
    internal ObjectParameterCollection() { }
    public int Count { get { return default(int); } }
    public System.Data.Objects.ObjectParameter this[string name] { get { return default(System.Data.Objects.ObjectParameter); } }
    bool System.Collections.Generic.ICollection<System.Data.Objects.ObjectParameter>.IsReadOnly { get { return default(bool); } }
    public void Add(System.Data.Objects.ObjectParameter parameter) { }
    public void Clear() { }
    public bool Contains(System.Data.Objects.ObjectParameter parameter) { return default(bool); }
    public bool Contains(string name) { return default(bool); }
    public void CopyTo(System.Data.Objects.ObjectParameter[] array, int index) { }
    public bool Remove(System.Data.Objects.ObjectParameter parameter) { return default(bool); }
    System.Collections.Generic.IEnumerator<System.Data.Objects.ObjectParameter> System.Collections.Generic.IEnumerable<System.Data.Objects.ObjectParameter>.GetEnumerator() { return default(System.Collections.Generic.IEnumerator<System.Data.Objects.ObjectParameter>); }
    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { return default(System.Collections.IEnumerator); }
  }
  public abstract partial class ObjectQuery : System.Collections.IEnumerable, System.ComponentModel.IListSource, System.Linq.IOrderedQueryable, System.Linq.IQueryable {
    internal ObjectQuery() { }
    public string CommandText { get { return default(string); } }
    public System.Data.Objects.ObjectContext Context { get { return default(System.Data.Objects.ObjectContext); } }
    public bool EnablePlanCaching { get { return default(bool); } set { } }
    public System.Data.Objects.MergeOption MergeOption { get { return default(System.Data.Objects.MergeOption); } set { } }
    public System.Data.Objects.ObjectParameterCollection Parameters { get { return default(System.Data.Objects.ObjectParameterCollection); } }
    bool System.ComponentModel.IListSource.ContainsListCollection { get { return default(bool); } }
    System.Type System.Linq.IQueryable.ElementType { get { return default(System.Type); } }
    System.Linq.Expressions.Expression System.Linq.IQueryable.Expression { get { return default(System.Linq.Expressions.Expression); } }
    System.Linq.IQueryProvider System.Linq.IQueryable.Provider { get { return default(System.Linq.IQueryProvider); } }
    public System.Data.Objects.ObjectResult Execute(System.Data.Objects.MergeOption mergeOption) { return default(System.Data.Objects.ObjectResult); }
    public System.Data.Metadata.Edm.TypeUsage GetResultType() { return default(System.Data.Metadata.Edm.TypeUsage); }
    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { return default(System.Collections.IEnumerator); }
    System.Collections.IList System.ComponentModel.IListSource.GetList() { return default(System.Collections.IList); }
    [System.ComponentModel.BrowsableAttribute(false)]
    public string ToTraceString() { return default(string); }
  }
  public partial class ObjectQuery<T> : System.Data.Objects.ObjectQuery, System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable, System.ComponentModel.IListSource, System.Linq.IOrderedQueryable, System.Linq.IOrderedQueryable<T>, System.Linq.IQueryable, System.Linq.IQueryable<T> {
    public ObjectQuery(string commandText, System.Data.Objects.ObjectContext context) { }
    public ObjectQuery(string commandText, System.Data.Objects.ObjectContext context, System.Data.Objects.MergeOption mergeOption) { }
    public string Name { get { return default(string); } set { } }
    public System.Data.Objects.ObjectQuery<T> Distinct() { return default(System.Data.Objects.ObjectQuery<T>); }
    public System.Data.Objects.ObjectQuery<T> Except(System.Data.Objects.ObjectQuery<T> query) { return default(System.Data.Objects.ObjectQuery<T>); }
    public new System.Data.Objects.ObjectResult<T> Execute(System.Data.Objects.MergeOption mergeOption) { return default(System.Data.Objects.ObjectResult<T>); }
    public System.Data.Objects.ObjectQuery<System.Data.Common.DbDataRecord> GroupBy(string keys, string projection, params System.Data.Objects.ObjectParameter[] parameters) { return default(System.Data.Objects.ObjectQuery<System.Data.Common.DbDataRecord>); }
    public System.Data.Objects.ObjectQuery<T> Include(string path) { return default(System.Data.Objects.ObjectQuery<T>); }
    public System.Data.Objects.ObjectQuery<T> Intersect(System.Data.Objects.ObjectQuery<T> query) { return default(System.Data.Objects.ObjectQuery<T>); }
    public System.Data.Objects.ObjectQuery<TResultType> OfType<TResultType>() { return default(System.Data.Objects.ObjectQuery<TResultType>); }
    public System.Data.Objects.ObjectQuery<T> OrderBy(string keys, params System.Data.Objects.ObjectParameter[] parameters) { return default(System.Data.Objects.ObjectQuery<T>); }
    public System.Data.Objects.ObjectQuery<System.Data.Common.DbDataRecord> Select(string projection, params System.Data.Objects.ObjectParameter[] parameters) { return default(System.Data.Objects.ObjectQuery<System.Data.Common.DbDataRecord>); }
    public System.Data.Objects.ObjectQuery<TResultType> SelectValue<TResultType>(string projection, params System.Data.Objects.ObjectParameter[] parameters) { return default(System.Data.Objects.ObjectQuery<TResultType>); }
    public System.Data.Objects.ObjectQuery<T> Skip(string keys, string count, params System.Data.Objects.ObjectParameter[] parameters) { return default(System.Data.Objects.ObjectQuery<T>); }
    System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { return default(System.Collections.Generic.IEnumerator<T>); }
    public System.Data.Objects.ObjectQuery<T> Top(string count, params System.Data.Objects.ObjectParameter[] parameters) { return default(System.Data.Objects.ObjectQuery<T>); }
    public System.Data.Objects.ObjectQuery<T> Union(System.Data.Objects.ObjectQuery<T> query) { return default(System.Data.Objects.ObjectQuery<T>); }
    public System.Data.Objects.ObjectQuery<T> UnionAll(System.Data.Objects.ObjectQuery<T> query) { return default(System.Data.Objects.ObjectQuery<T>); }
    public System.Data.Objects.ObjectQuery<T> Where(string predicate, params System.Data.Objects.ObjectParameter[] parameters) { return default(System.Data.Objects.ObjectQuery<T>); }
  }
  public abstract partial class ObjectResult : System.Collections.IEnumerable, System.ComponentModel.IListSource, System.IDisposable {
    internal ObjectResult() { }
    public abstract System.Type ElementType { get; }
    bool System.ComponentModel.IListSource.ContainsListCollection { get { return default(bool); } }
    public abstract void Dispose();
    public System.Data.Objects.ObjectResult<TElement> GetNextResult<TElement>() { return default(System.Data.Objects.ObjectResult<TElement>); }
    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { return default(System.Collections.IEnumerator); }
    System.Collections.IList System.ComponentModel.IListSource.GetList() { return default(System.Collections.IList); }
  }
  public sealed partial class ObjectResult<T> : System.Data.Objects.ObjectResult, System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable {
    internal ObjectResult() { }
    public override System.Type ElementType { get { return default(System.Type); } }
    public override void Dispose() { }
    public System.Collections.Generic.IEnumerator<T> GetEnumerator() { return default(System.Collections.Generic.IEnumerator<T>); }
  }
  public partial class ObjectSet<TEntity> : System.Data.Objects.ObjectQuery<TEntity>, System.Collections.Generic.IEnumerable<TEntity>, System.Collections.IEnumerable, System.Data.Objects.IObjectSet<TEntity>, System.Linq.IQueryable, System.Linq.IQueryable<TEntity> where TEntity : class {
    internal ObjectSet() : base (default(string), default(System.Data.Objects.ObjectContext)) { }
    public System.Data.Metadata.Edm.EntitySet EntitySet { get { return default(System.Data.Metadata.Edm.EntitySet); } }
    public void AddObject(TEntity entity) { }
    public TEntity ApplyCurrentValues(TEntity currentEntity) { return default(TEntity); }
    public TEntity ApplyOriginalValues(TEntity originalEntity) { return default(TEntity); }
    public void Attach(TEntity entity) { }
    public TEntity CreateObject() { return default(TEntity); }
    public T CreateObject<T>() where T : class, TEntity { return default(T); }
    public void DeleteObject(TEntity entity) { }
    public void Detach(TEntity entity) { }
  }
  public abstract partial class ObjectStateEntry : System.Data.Objects.DataClasses.IEntityChangeTracker {
    internal ObjectStateEntry() { }
    [System.Diagnostics.DebuggerBrowsableAttribute((System.Diagnostics.DebuggerBrowsableState)(0))]
    public abstract System.Data.Objects.CurrentValueRecord CurrentValues { get; }
    public abstract object Entity { get; }
    public abstract System.Data.EntityKey EntityKey { get; }
    public System.Data.Metadata.Edm.EntitySetBase EntitySet { get { return default(System.Data.Metadata.Edm.EntitySetBase); } }
    public abstract bool IsRelationship { get; }
    public System.Data.Objects.ObjectStateManager ObjectStateManager { get { return default(System.Data.Objects.ObjectStateManager); } }
    [System.Diagnostics.DebuggerBrowsableAttribute((System.Diagnostics.DebuggerBrowsableState)(0))]
    public abstract System.Data.Common.DbDataRecord OriginalValues { get; }
    public abstract System.Data.Objects.DataClasses.RelationshipManager RelationshipManager { get; }
    public System.Data.EntityState State { get { return default(System.Data.EntityState); } }
    System.Data.EntityState System.Data.Objects.DataClasses.IEntityChangeTracker.EntityState { get { return default(System.Data.EntityState); } }
    public abstract void AcceptChanges();
    public abstract void ApplyCurrentValues(object currentEntity);
    public abstract void ApplyOriginalValues(object originalEntity);
    public abstract void ChangeState(System.Data.EntityState state);
    public abstract void Delete();
    public abstract System.Collections.Generic.IEnumerable<System.String> GetModifiedProperties();
    public abstract System.Data.Objects.OriginalValueRecord GetUpdatableOriginalValues();
    public abstract bool IsPropertyChanged(string propertyName);
    public abstract void RejectPropertyChanges(string propertyName);
    public abstract void SetModified();
    public abstract void SetModifiedProperty(string propertyName);
    void System.Data.Objects.DataClasses.IEntityChangeTracker.EntityComplexMemberChanged(string entityMemberName, object complexObject, string complexObjectMemberName) { }
    void System.Data.Objects.DataClasses.IEntityChangeTracker.EntityComplexMemberChanging(string entityMemberName, object complexObject, string complexObjectMemberName) { }
    void System.Data.Objects.DataClasses.IEntityChangeTracker.EntityMemberChanged(string entityMemberName) { }
    void System.Data.Objects.DataClasses.IEntityChangeTracker.EntityMemberChanging(string entityMemberName) { }
  }
  public partial class ObjectStateManager {
    [System.CLSCompliantAttribute(false)]
    public ObjectStateManager(System.Data.Metadata.Edm.MetadataWorkspace metadataWorkspace) { }
    [System.CLSCompliantAttribute(false)]
    public System.Data.Metadata.Edm.MetadataWorkspace MetadataWorkspace { get { return default(System.Data.Metadata.Edm.MetadataWorkspace); } }
    public event System.ComponentModel.CollectionChangeEventHandler ObjectStateManagerChanged { add { } remove { } }
    public System.Data.Objects.ObjectStateEntry ChangeObjectState(object entity, System.Data.EntityState entityState) { return default(System.Data.Objects.ObjectStateEntry); }
    public System.Data.Objects.ObjectStateEntry ChangeRelationshipState(object sourceEntity, object targetEntity, string navigationProperty, System.Data.EntityState relationshipState) { return default(System.Data.Objects.ObjectStateEntry); }
    public System.Data.Objects.ObjectStateEntry ChangeRelationshipState(object sourceEntity, object targetEntity, string relationshipName, string targetRoleName, System.Data.EntityState relationshipState) { return default(System.Data.Objects.ObjectStateEntry); }
    public System.Data.Objects.ObjectStateEntry ChangeRelationshipState<TEntity>(TEntity sourceEntity, object targetEntity, System.Linq.Expressions.Expression<System.Func<TEntity, System.Object>> navigationPropertySelector, System.Data.EntityState relationshipState) where TEntity : class { return default(System.Data.Objects.ObjectStateEntry); }
    public System.Collections.Generic.IEnumerable<System.Data.Objects.ObjectStateEntry> GetObjectStateEntries(System.Data.EntityState state) { return default(System.Collections.Generic.IEnumerable<System.Data.Objects.ObjectStateEntry>); }
    public System.Data.Objects.ObjectStateEntry GetObjectStateEntry(System.Data.EntityKey key) { return default(System.Data.Objects.ObjectStateEntry); }
    public System.Data.Objects.ObjectStateEntry GetObjectStateEntry(object entity) { return default(System.Data.Objects.ObjectStateEntry); }
    public System.Data.Objects.DataClasses.RelationshipManager GetRelationshipManager(object entity) { return default(System.Data.Objects.DataClasses.RelationshipManager); }
    public bool TryGetObjectStateEntry(System.Data.EntityKey key, out System.Data.Objects.ObjectStateEntry entry) { entry = default(System.Data.Objects.ObjectStateEntry); return default(bool); }
    public bool TryGetObjectStateEntry(object entity, out System.Data.Objects.ObjectStateEntry entry) { entry = default(System.Data.Objects.ObjectStateEntry); return default(bool); }
    public bool TryGetRelationshipManager(object entity, out System.Data.Objects.DataClasses.RelationshipManager relationshipManager) { relationshipManager = default(System.Data.Objects.DataClasses.RelationshipManager); return default(bool); }
  }
  public abstract partial class OriginalValueRecord : System.Data.Objects.DbUpdatableDataRecord {
    internal OriginalValueRecord() { }
  }
  public partial class ProxyDataContractResolver : System.Runtime.Serialization.DataContractResolver {
    public ProxyDataContractResolver() { }
    public override System.Type ResolveName(string typeName, string typeNamespace, System.Type declaredType, System.Runtime.Serialization.DataContractResolver knownTypeResolver) { return default(System.Type); }
    public override bool TryResolveType(System.Type dataContractType, System.Type declaredType, System.Runtime.Serialization.DataContractResolver knownTypeResolver, out System.Xml.XmlDictionaryString typeName, out System.Xml.XmlDictionaryString typeNamespace) { typeName = default(System.Xml.XmlDictionaryString); typeNamespace = default(System.Xml.XmlDictionaryString); return default(bool); }
  }
  public enum RefreshMode {
    ClientWins = 2,
    StoreWins = 1,
  }
  [System.FlagsAttribute]
  public enum SaveOptions {
    AcceptAllChangesAfterSave = 1,
    DetectChangesBeforeSave = 2,
    None = 0,
  }
}
namespace System.Data.Objects.DataClasses {
  [System.Runtime.Serialization.DataContractAttribute(IsReference=true)]
  public abstract partial class ComplexObject : System.Data.Objects.DataClasses.StructuralObject {
    protected ComplexObject() { }
    protected sealed override void ReportPropertyChanged(string property) { }
    protected sealed override void ReportPropertyChanging(string property) { }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(128))]
  public sealed partial class EdmComplexPropertyAttribute : System.Data.Objects.DataClasses.EdmPropertyAttribute {
    public EdmComplexPropertyAttribute() { }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(4))]
  public sealed partial class EdmComplexTypeAttribute : System.Data.Objects.DataClasses.EdmTypeAttribute {
    public EdmComplexTypeAttribute() { }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(4), AllowMultiple=false)]
  public sealed partial class EdmEntityTypeAttribute : System.Data.Objects.DataClasses.EdmTypeAttribute {
    public EdmEntityTypeAttribute() { }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(16))]
  public sealed partial class EdmEnumTypeAttribute : System.Data.Objects.DataClasses.EdmTypeAttribute {
    public EdmEnumTypeAttribute() { }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(64), Inherited=false, AllowMultiple=false)]
  public sealed partial class EdmFunctionAttribute : System.Attribute {
    public EdmFunctionAttribute(string namespaceName, string functionName) { }
    public string FunctionName { get { return default(string); } }
    public string NamespaceName { get { return default(string); } }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(128))]
  public abstract partial class EdmPropertyAttribute : System.Attribute {
    internal EdmPropertyAttribute() { }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(1), AllowMultiple=true)]
  public sealed partial class EdmRelationshipAttribute : System.Attribute {
    public EdmRelationshipAttribute(string relationshipNamespaceName, string relationshipName, string role1Name, System.Data.Metadata.Edm.RelationshipMultiplicity role1Multiplicity, System.Type role1Type, string role2Name, System.Data.Metadata.Edm.RelationshipMultiplicity role2Multiplicity, System.Type role2Type) { }
    public EdmRelationshipAttribute(string relationshipNamespaceName, string relationshipName, string role1Name, System.Data.Metadata.Edm.RelationshipMultiplicity role1Multiplicity, System.Type role1Type, string role2Name, System.Data.Metadata.Edm.RelationshipMultiplicity role2Multiplicity, System.Type role2Type, bool isForeignKey) { }
    public bool IsForeignKey { get { return default(bool); } }
    public string RelationshipName { get { return default(string); } }
    public string RelationshipNamespaceName { get { return default(string); } }
    public System.Data.Metadata.Edm.RelationshipMultiplicity Role1Multiplicity { get { return default(System.Data.Metadata.Edm.RelationshipMultiplicity); } }
    public string Role1Name { get { return default(string); } }
    public System.Type Role1Type { get { return default(System.Type); } }
    public System.Data.Metadata.Edm.RelationshipMultiplicity Role2Multiplicity { get { return default(System.Data.Metadata.Edm.RelationshipMultiplicity); } }
    public string Role2Name { get { return default(string); } }
    public System.Type Role2Type { get { return default(System.Type); } }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(128))]
  public sealed partial class EdmRelationshipNavigationPropertyAttribute : System.Data.Objects.DataClasses.EdmPropertyAttribute {
    public EdmRelationshipNavigationPropertyAttribute(string relationshipNamespaceName, string relationshipName, string targetRoleName) { }
    public string RelationshipName { get { return default(string); } }
    public string RelationshipNamespaceName { get { return default(string); } }
    public string TargetRoleName { get { return default(string); } }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(128))]
  public sealed partial class EdmScalarPropertyAttribute : System.Data.Objects.DataClasses.EdmPropertyAttribute {
    public EdmScalarPropertyAttribute() { }
    public bool EntityKeyProperty { get { return default(bool); } set { } }
    public bool IsNullable { get { return default(bool); } set { } }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(5), AllowMultiple=true)]
  public sealed partial class EdmSchemaAttribute : System.Attribute {
    public EdmSchemaAttribute() { }
    public EdmSchemaAttribute(string assemblyGuid) { }
  }
  public abstract partial class EdmTypeAttribute : System.Attribute {
    internal EdmTypeAttribute() { }
    public string Name { get { return default(string); } set { } }
    public string NamespaceName { get { return default(string); } set { } }
  }
  public sealed partial class EntityCollection<TEntity> : System.Data.Objects.DataClasses.RelatedEnd, System.Collections.Generic.ICollection<TEntity>, System.Collections.Generic.IEnumerable<TEntity>, System.Collections.IEnumerable, System.ComponentModel.IListSource where TEntity : class {
    public EntityCollection() { }
    public int Count { get { return default(int); } }
    public bool IsReadOnly { get { return default(bool); } }
    bool System.ComponentModel.IListSource.ContainsListCollection { get { return default(bool); } }
    public void Add(TEntity entity) { }
    public void Attach(TEntity entity) { }
    public void Attach(System.Collections.Generic.IEnumerable<TEntity> entities) { }
    public void Clear() { }
    public bool Contains(TEntity entity) { return default(bool); }
    public void CopyTo(TEntity[] array, int arrayIndex) { }
    public System.Data.Objects.ObjectQuery<TEntity> CreateSourceQuery() { return default(System.Data.Objects.ObjectQuery<TEntity>); }
    public new System.Collections.Generic.IEnumerator<TEntity> GetEnumerator() { return default(System.Collections.Generic.IEnumerator<TEntity>); }
    public override void Load(System.Data.Objects.MergeOption mergeOption) { }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.Runtime.Serialization.OnDeserializedAttribute]
    public void OnCollectionDeserialized(System.Runtime.Serialization.StreamingContext context) { }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.Runtime.Serialization.OnSerializingAttribute]
    public void OnSerializing(System.Runtime.Serialization.StreamingContext context) { }
    public bool Remove(TEntity entity) { return default(bool); }
    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { return default(System.Collections.IEnumerator); }
    System.Collections.IList System.ComponentModel.IListSource.GetList() { return default(System.Collections.IList); }
  }
  [System.Runtime.Serialization.DataContractAttribute(IsReference=true)]
  public abstract partial class EntityObject : System.Data.Objects.DataClasses.StructuralObject, System.Data.Objects.DataClasses.IEntityWithChangeTracker, System.Data.Objects.DataClasses.IEntityWithKey, System.Data.Objects.DataClasses.IEntityWithRelationships {
    protected EntityObject() { }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.Runtime.Serialization.DataMemberAttribute]
    public System.Data.EntityKey EntityKey { get { return default(System.Data.EntityKey); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Data.EntityState EntityState { get { return default(System.Data.EntityState); } }
    System.Data.Objects.DataClasses.RelationshipManager System.Data.Objects.DataClasses.IEntityWithRelationships.RelationshipManager { get { return default(System.Data.Objects.DataClasses.RelationshipManager); } }
    protected sealed override void ReportPropertyChanged(string property) { }
    protected sealed override void ReportPropertyChanging(string property) { }
    void System.Data.Objects.DataClasses.IEntityWithChangeTracker.SetChangeTracker(System.Data.Objects.DataClasses.IEntityChangeTracker changeTracker) { }
  }
  [System.Runtime.Serialization.DataContractAttribute]
  public abstract partial class EntityReference : System.Data.Objects.DataClasses.RelatedEnd {
    internal EntityReference() { }
    [System.Runtime.Serialization.DataMemberAttribute]
    public System.Data.EntityKey EntityKey { get { return default(System.Data.EntityKey); } set { } }
  }
  [System.Runtime.Serialization.DataContractAttribute]
  public sealed partial class EntityReference<TEntity> : System.Data.Objects.DataClasses.EntityReference where TEntity : class {
    public EntityReference() { }
    [System.Xml.Serialization.SoapIgnoreAttribute]
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public TEntity Value { get { return default(TEntity); } set { } }
    public void Attach(TEntity entity) { }
    public System.Data.Objects.ObjectQuery<TEntity> CreateSourceQuery() { return default(System.Data.Objects.ObjectQuery<TEntity>); }
    public override void Load(System.Data.Objects.MergeOption mergeOption) { }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.Runtime.Serialization.OnDeserializedAttribute]
    public void OnRefDeserialized(System.Runtime.Serialization.StreamingContext context) { }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.Runtime.Serialization.OnSerializingAttribute]
    public void OnSerializing(System.Runtime.Serialization.StreamingContext context) { }
  }
  public partial interface IEntityChangeTracker {
    System.Data.EntityState EntityState { get; }
    void EntityComplexMemberChanged(string entityMemberName, object complexObject, string complexObjectMemberName);
    void EntityComplexMemberChanging(string entityMemberName, object complexObject, string complexObjectMemberName);
    void EntityMemberChanged(string entityMemberName);
    void EntityMemberChanging(string entityMemberName);
  }
  public partial interface IEntityWithChangeTracker {
    void SetChangeTracker(System.Data.Objects.DataClasses.IEntityChangeTracker changeTracker);
  }
  public partial interface IEntityWithKey {
    System.Data.EntityKey EntityKey { get; set; }
  }
  public partial interface IEntityWithRelationships {
    System.Data.Objects.DataClasses.RelationshipManager RelationshipManager { get; }
  }
  public partial interface IRelatedEnd {
    bool IsLoaded { get; }
    string RelationshipName { get; }
    System.Data.Metadata.Edm.RelationshipSet RelationshipSet { get; }
    string SourceRoleName { get; }
    string TargetRoleName { get; }
    void Add(System.Data.Objects.DataClasses.IEntityWithRelationships entity);
    void Add(object entity);
    void Attach(System.Data.Objects.DataClasses.IEntityWithRelationships entity);
    void Attach(object entity);
    System.Collections.IEnumerable CreateSourceQuery();
    System.Collections.IEnumerator GetEnumerator();
    void Load();
    void Load(System.Data.Objects.MergeOption mergeOption);
    bool Remove(System.Data.Objects.DataClasses.IEntityWithRelationships entity);
    bool Remove(object entity);
  }
  [System.Runtime.Serialization.DataContractAttribute]
  public abstract partial class RelatedEnd : System.Data.Objects.DataClasses.IRelatedEnd {
    internal RelatedEnd() { }
    [System.Xml.Serialization.SoapIgnoreAttribute]
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public bool IsLoaded { get { return default(bool); } }
    [System.Xml.Serialization.SoapIgnoreAttribute]
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public string RelationshipName { get { return default(string); } }
    [System.Xml.Serialization.SoapIgnoreAttribute]
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Data.Metadata.Edm.RelationshipSet RelationshipSet { get { return default(System.Data.Metadata.Edm.RelationshipSet); } }
    [System.Xml.Serialization.SoapIgnoreAttribute]
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public string SourceRoleName { get { return default(string); } }
    [System.Xml.Serialization.SoapIgnoreAttribute]
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public string TargetRoleName { get { return default(string); } }
    public event System.ComponentModel.CollectionChangeEventHandler AssociationChanged { add { } remove { } }
    public System.Collections.IEnumerator GetEnumerator() { return default(System.Collections.IEnumerator); }
    public void Load() { }
    public abstract void Load(System.Data.Objects.MergeOption mergeOption);
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.Runtime.Serialization.OnDeserializedAttribute]
    public void OnDeserialized(System.Runtime.Serialization.StreamingContext context) { }
    void System.Data.Objects.DataClasses.IRelatedEnd.Add(System.Data.Objects.DataClasses.IEntityWithRelationships entity) { }
    void System.Data.Objects.DataClasses.IRelatedEnd.Add(object entity) { }
    void System.Data.Objects.DataClasses.IRelatedEnd.Attach(System.Data.Objects.DataClasses.IEntityWithRelationships entity) { }
    void System.Data.Objects.DataClasses.IRelatedEnd.Attach(object entity) { }
    System.Collections.IEnumerable System.Data.Objects.DataClasses.IRelatedEnd.CreateSourceQuery() { return default(System.Collections.IEnumerable); }
    bool System.Data.Objects.DataClasses.IRelatedEnd.Remove(System.Data.Objects.DataClasses.IEntityWithRelationships entity) { return default(bool); }
    bool System.Data.Objects.DataClasses.IRelatedEnd.Remove(object entity) { return default(bool); }
  }
  public enum RelationshipKind {
    Association = 0,
  }
  public partial class RelationshipManager {
    internal RelationshipManager() { }
    public static System.Data.Objects.DataClasses.RelationshipManager Create(System.Data.Objects.DataClasses.IEntityWithRelationships owner) { return default(System.Data.Objects.DataClasses.RelationshipManager); }
    [System.Runtime.CompilerServices.IteratorStateMachineAttribute(typeof(System.Data.Objects.DataClasses.RelationshipManager.<GetAllRelatedEnds>d__40))]
    public System.Collections.Generic.IEnumerable<System.Data.Objects.DataClasses.IRelatedEnd> GetAllRelatedEnds() { return default(System.Collections.Generic.IEnumerable<System.Data.Objects.DataClasses.IRelatedEnd>); }
    public System.Data.Objects.DataClasses.EntityCollection<TTargetEntity> GetRelatedCollection<TTargetEntity>(string relationshipName, string targetRoleName) where TTargetEntity : class { return default(System.Data.Objects.DataClasses.EntityCollection<TTargetEntity>); }
    public System.Data.Objects.DataClasses.IRelatedEnd GetRelatedEnd(string relationshipName, string targetRoleName) { return default(System.Data.Objects.DataClasses.IRelatedEnd); }
    public System.Data.Objects.DataClasses.EntityReference<TTargetEntity> GetRelatedReference<TTargetEntity>(string relationshipName, string targetRoleName) where TTargetEntity : class { return default(System.Data.Objects.DataClasses.EntityReference<TTargetEntity>); }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public void InitializeRelatedCollection<TTargetEntity>(string relationshipName, string targetRoleName, System.Data.Objects.DataClasses.EntityCollection<TTargetEntity> entityCollection) where TTargetEntity : class { }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public void InitializeRelatedReference<TTargetEntity>(string relationshipName, string targetRoleName, System.Data.Objects.DataClasses.EntityReference<TTargetEntity> entityReference) where TTargetEntity : class { }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.Runtime.Serialization.OnDeserializedAttribute]
    public void OnDeserialized(System.Runtime.Serialization.StreamingContext context) { }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.Runtime.Serialization.OnSerializingAttribute]
    public void OnSerializing(System.Runtime.Serialization.StreamingContext context) { }
  }
  [System.Runtime.Serialization.DataContractAttribute(IsReference=true)]
  public abstract partial class StructuralObject : System.ComponentModel.INotifyPropertyChanged, System.ComponentModel.INotifyPropertyChanging {
    public static readonly string EntityKeyPropertyName;
    protected StructuralObject() { }
    public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged { add { } remove { } }
    public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging { add { } remove { } }
    protected internal static bool BinaryEquals(System.Byte[] first, System.Byte[] second) { return default(bool); }
    protected static System.DateTime DefaultDateTimeValue() { return default(System.DateTime); }
    protected internal static System.Byte[] GetValidValue(System.Byte[] currentValue) { return default(System.Byte[]); }
    protected internal T GetValidValue<T>(T currentValue, string property, bool isNullable, bool isInitialized) where T : System.Data.Objects.DataClasses.ComplexObject, new() { return default(T); }
    protected virtual void OnPropertyChanged(string property) { }
    protected virtual void OnPropertyChanging(string property) { }
    protected virtual void ReportPropertyChanged(string property) { }
    protected virtual void ReportPropertyChanging(string property) { }
    protected internal static bool SetValidValue(bool value) { return default(bool); }
    protected internal static bool SetValidValue(bool value, string propertyName) { return default(bool); }
    protected internal static byte SetValidValue(byte value) { return default(byte); }
    protected internal static byte SetValidValue(byte value, string propertyName) { return default(byte); }
    protected internal static System.Byte[] SetValidValue(System.Byte[] value, bool isNullable) { return default(System.Byte[]); }
    protected internal static System.Byte[] SetValidValue(System.Byte[] value, bool isNullable, string propertyName) { return default(System.Byte[]); }
    protected internal static System.Data.Spatial.DbGeography SetValidValue(System.Data.Spatial.DbGeography value, bool isNullable) { return default(System.Data.Spatial.DbGeography); }
    protected internal static System.Data.Spatial.DbGeography SetValidValue(System.Data.Spatial.DbGeography value, bool isNullable, string propertyName) { return default(System.Data.Spatial.DbGeography); }
    protected internal static System.Data.Spatial.DbGeometry SetValidValue(System.Data.Spatial.DbGeometry value, bool isNullable) { return default(System.Data.Spatial.DbGeometry); }
    protected internal static System.Data.Spatial.DbGeometry SetValidValue(System.Data.Spatial.DbGeometry value, bool isNullable, string propertyName) { return default(System.Data.Spatial.DbGeometry); }
    protected internal static System.DateTime SetValidValue(System.DateTime value) { return default(System.DateTime); }
    protected internal static System.DateTime SetValidValue(System.DateTime value, string propertyName) { return default(System.DateTime); }
    protected internal static System.DateTimeOffset SetValidValue(System.DateTimeOffset value) { return default(System.DateTimeOffset); }
    protected internal static System.DateTimeOffset SetValidValue(System.DateTimeOffset value, string propertyName) { return default(System.DateTimeOffset); }
    protected internal static decimal SetValidValue(decimal value) { return default(decimal); }
    protected internal static decimal SetValidValue(decimal value, string propertyName) { return default(decimal); }
    protected internal static double SetValidValue(double value) { return default(double); }
    protected internal static double SetValidValue(double value, string propertyName) { return default(double); }
    protected internal static System.Guid SetValidValue(System.Guid value) { return default(System.Guid); }
    protected internal static System.Guid SetValidValue(System.Guid value, string propertyName) { return default(System.Guid); }
    protected internal static short SetValidValue(short value) { return default(short); }
    protected internal static short SetValidValue(short value, string propertyName) { return default(short); }
    protected internal static int SetValidValue(int value) { return default(int); }
    protected internal static int SetValidValue(int value, string propertyName) { return default(int); }
    protected internal static long SetValidValue(long value) { return default(long); }
    protected internal static long SetValidValue(long value, string propertyName) { return default(long); }
    protected internal static System.Nullable<System.Boolean> SetValidValue(System.Nullable<System.Boolean> value) { return default(System.Nullable<System.Boolean>); }
    protected internal static System.Nullable<System.Boolean> SetValidValue(System.Nullable<System.Boolean> value, string propertyName) { return default(System.Nullable<System.Boolean>); }
    protected internal static System.Nullable<System.Byte> SetValidValue(System.Nullable<System.Byte> value) { return default(System.Nullable<System.Byte>); }
    protected internal static System.Nullable<System.Byte> SetValidValue(System.Nullable<System.Byte> value, string propertyName) { return default(System.Nullable<System.Byte>); }
    protected internal static System.Nullable<System.DateTime> SetValidValue(System.Nullable<System.DateTime> value) { return default(System.Nullable<System.DateTime>); }
    protected internal static System.Nullable<System.DateTime> SetValidValue(System.Nullable<System.DateTime> value, string propertyName) { return default(System.Nullable<System.DateTime>); }
    protected internal static System.Nullable<System.DateTimeOffset> SetValidValue(System.Nullable<System.DateTimeOffset> value) { return default(System.Nullable<System.DateTimeOffset>); }
    protected internal static System.Nullable<System.DateTimeOffset> SetValidValue(System.Nullable<System.DateTimeOffset> value, string propertyName) { return default(System.Nullable<System.DateTimeOffset>); }
    protected internal static System.Nullable<System.Decimal> SetValidValue(System.Nullable<System.Decimal> value) { return default(System.Nullable<System.Decimal>); }
    protected internal static System.Nullable<System.Decimal> SetValidValue(System.Nullable<System.Decimal> value, string propertyName) { return default(System.Nullable<System.Decimal>); }
    protected internal static System.Nullable<System.Double> SetValidValue(System.Nullable<System.Double> value) { return default(System.Nullable<System.Double>); }
    protected internal static System.Nullable<System.Double> SetValidValue(System.Nullable<System.Double> value, string propertyName) { return default(System.Nullable<System.Double>); }
    protected internal static System.Nullable<System.Guid> SetValidValue(System.Nullable<System.Guid> value) { return default(System.Nullable<System.Guid>); }
    protected internal static System.Nullable<System.Guid> SetValidValue(System.Nullable<System.Guid> value, string propertyName) { return default(System.Nullable<System.Guid>); }
    protected internal static System.Nullable<System.Int16> SetValidValue(System.Nullable<System.Int16> value) { return default(System.Nullable<System.Int16>); }
    protected internal static System.Nullable<System.Int16> SetValidValue(System.Nullable<System.Int16> value, string propertyName) { return default(System.Nullable<System.Int16>); }
    protected internal static System.Nullable<System.Int32> SetValidValue(System.Nullable<System.Int32> value) { return default(System.Nullable<System.Int32>); }
    protected internal static System.Nullable<System.Int32> SetValidValue(System.Nullable<System.Int32> value, string propertyName) { return default(System.Nullable<System.Int32>); }
    protected internal static System.Nullable<System.Int64> SetValidValue(System.Nullable<System.Int64> value) { return default(System.Nullable<System.Int64>); }
    protected internal static System.Nullable<System.Int64> SetValidValue(System.Nullable<System.Int64> value, string propertyName) { return default(System.Nullable<System.Int64>); }
    [System.CLSCompliantAttribute(false)]
    protected internal static System.Nullable<System.SByte> SetValidValue(System.Nullable<System.SByte> value) { return default(System.Nullable<System.SByte>); }
    [System.CLSCompliantAttribute(false)]
    protected internal static System.Nullable<System.SByte> SetValidValue(System.Nullable<System.SByte> value, string propertyName) { return default(System.Nullable<System.SByte>); }
    protected internal static System.Nullable<System.Single> SetValidValue(System.Nullable<System.Single> value) { return default(System.Nullable<System.Single>); }
    protected internal static System.Nullable<System.Single> SetValidValue(System.Nullable<System.Single> value, string propertyName) { return default(System.Nullable<System.Single>); }
    protected internal static System.Nullable<System.TimeSpan> SetValidValue(System.Nullable<System.TimeSpan> value) { return default(System.Nullable<System.TimeSpan>); }
    protected internal static System.Nullable<System.TimeSpan> SetValidValue(System.Nullable<System.TimeSpan> value, string propertyName) { return default(System.Nullable<System.TimeSpan>); }
    [System.CLSCompliantAttribute(false)]
    protected internal static System.Nullable<System.UInt16> SetValidValue(System.Nullable<System.UInt16> value) { return default(System.Nullable<System.UInt16>); }
    [System.CLSCompliantAttribute(false)]
    protected internal static System.Nullable<System.UInt16> SetValidValue(System.Nullable<System.UInt16> value, string propertyName) { return default(System.Nullable<System.UInt16>); }
    [System.CLSCompliantAttribute(false)]
    protected internal static System.Nullable<System.UInt32> SetValidValue(System.Nullable<System.UInt32> value) { return default(System.Nullable<System.UInt32>); }
    [System.CLSCompliantAttribute(false)]
    protected internal static System.Nullable<System.UInt32> SetValidValue(System.Nullable<System.UInt32> value, string propertyName) { return default(System.Nullable<System.UInt32>); }
    [System.CLSCompliantAttribute(false)]
    protected internal static System.Nullable<System.UInt64> SetValidValue(System.Nullable<System.UInt64> value) { return default(System.Nullable<System.UInt64>); }
    [System.CLSCompliantAttribute(false)]
    protected internal static System.Nullable<System.UInt64> SetValidValue(System.Nullable<System.UInt64> value, string propertyName) { return default(System.Nullable<System.UInt64>); }
    [System.CLSCompliantAttribute(false)]
    protected internal static sbyte SetValidValue(sbyte value) { return default(sbyte); }
    [System.CLSCompliantAttribute(false)]
    protected internal static sbyte SetValidValue(sbyte value, string propertyName) { return default(sbyte); }
    protected internal static float SetValidValue(float value) { return default(float); }
    protected internal static float SetValidValue(float value, string propertyName) { return default(float); }
    protected internal static string SetValidValue(string value, bool isNullable) { return default(string); }
    protected internal static string SetValidValue(string value, bool isNullable, string propertyName) { return default(string); }
    protected internal static System.TimeSpan SetValidValue(System.TimeSpan value) { return default(System.TimeSpan); }
    protected internal static System.TimeSpan SetValidValue(System.TimeSpan value, string propertyName) { return default(System.TimeSpan); }
    [System.CLSCompliantAttribute(false)]
    protected internal static ushort SetValidValue(ushort value) { return default(ushort); }
    [System.CLSCompliantAttribute(false)]
    protected internal static ushort SetValidValue(ushort value, string propertyName) { return default(ushort); }
    [System.CLSCompliantAttribute(false)]
    protected internal static uint SetValidValue(uint value) { return default(uint); }
    [System.CLSCompliantAttribute(false)]
    protected internal static uint SetValidValue(uint value, string propertyName) { return default(uint); }
    [System.CLSCompliantAttribute(false)]
    protected internal static ulong SetValidValue(ulong value) { return default(ulong); }
    [System.CLSCompliantAttribute(false)]
    protected internal static ulong SetValidValue(ulong value, string propertyName) { return default(ulong); }
    protected internal T SetValidValue<T>(T oldValue, T newValue, string property) where T : System.Data.Objects.DataClasses.ComplexObject { return default(T); }
    protected internal static TComplex VerifyComplexObjectIsNotNull<TComplex>(TComplex complexObject, string propertyName) where TComplex : System.Data.Objects.DataClasses.ComplexObject { return default(TComplex); }
  }
}
namespace System.Data.Objects.SqlClient {
  public static partial class SqlFunctions {
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "ACOS")]
    public static System.Nullable<System.Double> Acos(System.Nullable<System.Decimal> arg1) { return default(System.Nullable<System.Double>); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "ACOS")]
    public static System.Nullable<System.Double> Acos(System.Nullable<System.Double> arg1) { return default(System.Nullable<System.Double>); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "ASCII")]
    public static System.Nullable<System.Int32> Ascii(string arg) { return default(System.Nullable<System.Int32>); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "ASIN")]
    public static System.Nullable<System.Double> Asin(System.Nullable<System.Decimal> arg) { return default(System.Nullable<System.Double>); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "ASIN")]
    public static System.Nullable<System.Double> Asin(System.Nullable<System.Double> arg) { return default(System.Nullable<System.Double>); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "ATAN")]
    public static System.Nullable<System.Double> Atan(System.Nullable<System.Decimal> arg) { return default(System.Nullable<System.Double>); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "ATAN")]
    public static System.Nullable<System.Double> Atan(System.Nullable<System.Double> arg) { return default(System.Nullable<System.Double>); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "ATN2")]
    public static System.Nullable<System.Double> Atan2(System.Nullable<System.Decimal> arg1, System.Nullable<System.Decimal> arg2) { return default(System.Nullable<System.Double>); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "ATN2")]
    public static System.Nullable<System.Double> Atan2(System.Nullable<System.Double> arg1, System.Nullable<System.Double> arg2) { return default(System.Nullable<System.Double>); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "CHAR")]
    public static string Char(System.Nullable<System.Int32> arg) { return default(string); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "CHARINDEX")]
    public static System.Nullable<System.Int32> CharIndex(System.Byte[] toSearch, System.Byte[] target) { return default(System.Nullable<System.Int32>); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "CHARINDEX")]
    public static System.Nullable<System.Int32> CharIndex(System.Byte[] toSearch, System.Byte[] target, System.Nullable<System.Int32> startLocation) { return default(System.Nullable<System.Int32>); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "CHARINDEX")]
    public static System.Nullable<System.Int64> CharIndex(System.Byte[] toSearch, System.Byte[] target, System.Nullable<System.Int64> startLocation) { return default(System.Nullable<System.Int64>); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "CHARINDEX")]
    public static System.Nullable<System.Int32> CharIndex(string toSearch, string target) { return default(System.Nullable<System.Int32>); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "CHARINDEX")]
    public static System.Nullable<System.Int32> CharIndex(string toSearch, string target, System.Nullable<System.Int32> startLocation) { return default(System.Nullable<System.Int32>); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "CHARINDEX")]
    public static System.Nullable<System.Int64> CharIndex(string toSearch, string target, System.Nullable<System.Int64> startLocation) { return default(System.Nullable<System.Int64>); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "CHECKSUM")]
    public static System.Nullable<System.Int32> Checksum(System.Byte[] arg1) { return default(System.Nullable<System.Int32>); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "CHECKSUM")]
    public static System.Nullable<System.Int32> Checksum(System.Byte[] arg1, System.Byte[] arg2) { return default(System.Nullable<System.Int32>); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "CHECKSUM")]
    public static System.Nullable<System.Int32> Checksum(System.Byte[] arg1, System.Byte[] arg2, System.Byte[] arg3) { return default(System.Nullable<System.Int32>); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "CHECKSUM")]
    public static System.Nullable<System.Int32> Checksum(System.Nullable<System.Boolean> arg1) { return default(System.Nullable<System.Int32>); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "CHECKSUM")]
    public static System.Nullable<System.Int32> Checksum(System.Nullable<System.Boolean> arg1, System.Nullable<System.Boolean> arg2) { return default(System.Nullable<System.Int32>); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "CHECKSUM")]
    public static System.Nullable<System.Int32> Checksum(System.Nullable<System.Boolean> arg1, System.Nullable<System.Boolean> arg2, System.Nullable<System.Boolean> arg3) { return default(System.Nullable<System.Int32>); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "CHECKSUM")]
    public static System.Nullable<System.Int32> Checksum(System.Nullable<System.DateTime> arg1) { return default(System.Nullable<System.Int32>); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "CHECKSUM")]
    public static System.Nullable<System.Int32> Checksum(System.Nullable<System.DateTime> arg1, System.Nullable<System.DateTime> arg2) { return default(System.Nullable<System.Int32>); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "CHECKSUM")]
    public static System.Nullable<System.Int32> Checksum(System.Nullable<System.DateTime> arg1, System.Nullable<System.DateTime> arg2, System.Nullable<System.DateTime> arg3) { return default(System.Nullable<System.Int32>); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "CHECKSUM")]
    public static System.Nullable<System.Int32> Checksum(System.Nullable<System.DateTimeOffset> arg1) { return default(System.Nullable<System.Int32>); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "CHECKSUM")]
    public static System.Nullable<System.Int32> Checksum(System.Nullable<System.DateTimeOffset> arg1, System.Nullable<System.DateTimeOffset> arg2) { return default(System.Nullable<System.Int32>); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "CHECKSUM")]
    public static System.Nullable<System.Int32> Checksum(System.Nullable<System.DateTimeOffset> arg1, System.Nullable<System.DateTimeOffset> arg2, System.Nullable<System.DateTimeOffset> arg3) { return default(System.Nullable<System.Int32>); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "CHECKSUM")]
    public static System.Nullable<System.Int32> Checksum(System.Nullable<System.Decimal> arg1) { return default(System.Nullable<System.Int32>); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "CHECKSUM")]
    public static System.Nullable<System.Int32> Checksum(System.Nullable<System.Decimal> arg1, System.Nullable<System.Decimal> arg2) { return default(System.Nullable<System.Int32>); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "CHECKSUM")]
    public static System.Nullable<System.Int32> Checksum(System.Nullable<System.Decimal> arg1, System.Nullable<System.Decimal> arg2, System.Nullable<System.Decimal> arg3) { return default(System.Nullable<System.Int32>); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "CHECKSUM")]
    public static System.Nullable<System.Int32> Checksum(System.Nullable<System.Double> arg1) { return default(System.Nullable<System.Int32>); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "CHECKSUM")]
    public static System.Nullable<System.Int32> Checksum(System.Nullable<System.Double> arg1, System.Nullable<System.Double> arg2) { return default(System.Nullable<System.Int32>); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "CHECKSUM")]
    public static System.Nullable<System.Int32> Checksum(System.Nullable<System.Double> arg1, System.Nullable<System.Double> arg2, System.Nullable<System.Double> arg3) { return default(System.Nullable<System.Int32>); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "CHECKSUM")]
    public static System.Nullable<System.Int32> Checksum(System.Nullable<System.Guid> arg1) { return default(System.Nullable<System.Int32>); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "CHECKSUM")]
    public static System.Nullable<System.Int32> Checksum(System.Nullable<System.Guid> arg1, System.Nullable<System.Guid> arg2) { return default(System.Nullable<System.Int32>); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "CHECKSUM")]
    public static System.Nullable<System.Int32> Checksum(System.Nullable<System.Guid> arg1, System.Nullable<System.Guid> arg2, System.Nullable<System.Guid> arg3) { return default(System.Nullable<System.Int32>); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "CHECKSUM")]
    public static System.Nullable<System.Int32> Checksum(System.Nullable<System.TimeSpan> arg1) { return default(System.Nullable<System.Int32>); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "CHECKSUM")]
    public static System.Nullable<System.Int32> Checksum(System.Nullable<System.TimeSpan> arg1, System.Nullable<System.TimeSpan> arg2) { return default(System.Nullable<System.Int32>); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "CHECKSUM")]
    public static System.Nullable<System.Int32> Checksum(System.Nullable<System.TimeSpan> arg1, System.Nullable<System.TimeSpan> arg2, System.Nullable<System.TimeSpan> arg3) { return default(System.Nullable<System.Int32>); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "CHECKSUM")]
    public static System.Nullable<System.Int32> Checksum(string arg1) { return default(System.Nullable<System.Int32>); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "CHECKSUM")]
    public static System.Nullable<System.Int32> Checksum(string arg1, string arg2) { return default(System.Nullable<System.Int32>); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "CHECKSUM")]
    public static System.Nullable<System.Int32> Checksum(string arg1, string arg2, string arg3) { return default(System.Nullable<System.Int32>); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "CHECKSUM_AGG")]
    public static System.Nullable<System.Int32> ChecksumAggregate(System.Collections.Generic.IEnumerable<System.Int32> arg) { return default(System.Nullable<System.Int32>); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "CHECKSUM_AGG")]
    public static System.Nullable<System.Int32> ChecksumAggregate(System.Collections.Generic.IEnumerable<System.Nullable<System.Int32>> arg) { return default(System.Nullable<System.Int32>); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "COS")]
    public static System.Nullable<System.Double> Cos(System.Nullable<System.Decimal> arg) { return default(System.Nullable<System.Double>); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "COS")]
    public static System.Nullable<System.Double> Cos(System.Nullable<System.Double> arg) { return default(System.Nullable<System.Double>); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "COT")]
    public static System.Nullable<System.Double> Cot(System.Nullable<System.Decimal> arg) { return default(System.Nullable<System.Double>); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "COT")]
    public static System.Nullable<System.Double> Cot(System.Nullable<System.Double> arg) { return default(System.Nullable<System.Double>); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "CURRENT_TIMESTAMP")]
    public static System.Nullable<System.DateTime> CurrentTimestamp() { return default(System.Nullable<System.DateTime>); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "CURRENT_USER")]
    public static string CurrentUser() { return default(string); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "DATALENGTH")]
    public static System.Nullable<System.Int32> DataLength(System.Byte[] arg) { return default(System.Nullable<System.Int32>); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "DATALENGTH")]
    public static System.Nullable<System.Int32> DataLength(System.Nullable<System.Boolean> arg) { return default(System.Nullable<System.Int32>); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "DATALENGTH")]
    public static System.Nullable<System.Int32> DataLength(System.Nullable<System.DateTime> arg) { return default(System.Nullable<System.Int32>); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "DATALENGTH")]
    public static System.Nullable<System.Int32> DataLength(System.Nullable<System.DateTimeOffset> arg) { return default(System.Nullable<System.Int32>); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "DATALENGTH")]
    public static System.Nullable<System.Int32> DataLength(System.Nullable<System.Decimal> arg) { return default(System.Nullable<System.Int32>); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "DATALENGTH")]
    public static System.Nullable<System.Int32> DataLength(System.Nullable<System.Double> arg) { return default(System.Nullable<System.Int32>); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "DATALENGTH")]
    public static System.Nullable<System.Int32> DataLength(System.Nullable<System.Guid> arg) { return default(System.Nullable<System.Int32>); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "DATALENGTH")]
    public static System.Nullable<System.Int32> DataLength(System.Nullable<System.TimeSpan> arg) { return default(System.Nullable<System.Int32>); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "DATALENGTH")]
    public static System.Nullable<System.Int32> DataLength(string arg) { return default(System.Nullable<System.Int32>); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "DATEADD")]
    public static System.Nullable<System.DateTime> DateAdd(string datePartArg, System.Nullable<System.Double> number, System.Nullable<System.DateTime> date) { return default(System.Nullable<System.DateTime>); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "DATEADD")]
    public static System.Nullable<System.DateTimeOffset> DateAdd(string datePartArg, System.Nullable<System.Double> number, System.Nullable<System.DateTimeOffset> dateTimeOffsetArg) { return default(System.Nullable<System.DateTimeOffset>); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "DATEADD")]
    public static System.Nullable<System.TimeSpan> DateAdd(string datePartArg, System.Nullable<System.Double> number, System.Nullable<System.TimeSpan> time) { return default(System.Nullable<System.TimeSpan>); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "DATEADD")]
    public static System.Nullable<System.DateTime> DateAdd(string datePartArg, System.Nullable<System.Double> number, string date) { return default(System.Nullable<System.DateTime>); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "DATEDIFF")]
    public static System.Nullable<System.Int32> DateDiff(string datePartArg, System.Nullable<System.DateTime> startDate, System.Nullable<System.DateTime> endDate) { return default(System.Nullable<System.Int32>); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "DATEDIFF")]
    public static System.Nullable<System.Int32> DateDiff(string datePartArg, System.Nullable<System.DateTime> startDate, System.Nullable<System.DateTimeOffset> endDate) { return default(System.Nullable<System.Int32>); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "DATEDIFF")]
    public static System.Nullable<System.Int32> DateDiff(string datePartArg, System.Nullable<System.DateTime> startDate, System.Nullable<System.TimeSpan> endDate) { return default(System.Nullable<System.Int32>); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "DATEDIFF")]
    public static System.Nullable<System.Int32> DateDiff(string datePartArg, System.Nullable<System.DateTime> startDate, string endDate) { return default(System.Nullable<System.Int32>); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "DATEDIFF")]
    public static System.Nullable<System.Int32> DateDiff(string datePartArg, System.Nullable<System.DateTimeOffset> startDate, System.Nullable<System.DateTime> endDate) { return default(System.Nullable<System.Int32>); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "DATEDIFF")]
    public static System.Nullable<System.Int32> DateDiff(string datePartArg, System.Nullable<System.DateTimeOffset> startDate, System.Nullable<System.DateTimeOffset> endDate) { return default(System.Nullable<System.Int32>); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "DATEDIFF")]
    public static System.Nullable<System.Int32> DateDiff(string datePartArg, System.Nullable<System.DateTimeOffset> startDate, System.Nullable<System.TimeSpan> endDate) { return default(System.Nullable<System.Int32>); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "DATEDIFF")]
    public static System.Nullable<System.Int32> DateDiff(string datePartArg, System.Nullable<System.DateTimeOffset> startDate, string endDate) { return default(System.Nullable<System.Int32>); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "DATEDIFF")]
    public static System.Nullable<System.Int32> DateDiff(string datePartArg, System.Nullable<System.TimeSpan> startDate, System.Nullable<System.DateTime> endDate) { return default(System.Nullable<System.Int32>); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "DATEDIFF")]
    public static System.Nullable<System.Int32> DateDiff(string datePartArg, System.Nullable<System.TimeSpan> startDate, System.Nullable<System.DateTimeOffset> endDate) { return default(System.Nullable<System.Int32>); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "DATEDIFF")]
    public static System.Nullable<System.Int32> DateDiff(string datePartArg, System.Nullable<System.TimeSpan> startDate, System.Nullable<System.TimeSpan> endDate) { return default(System.Nullable<System.Int32>); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "DATEDIFF")]
    public static System.Nullable<System.Int32> DateDiff(string datePartArg, System.Nullable<System.TimeSpan> startDate, string endDate) { return default(System.Nullable<System.Int32>); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "DATEDIFF")]
    public static System.Nullable<System.Int32> DateDiff(string datePartArg, string startDate, System.Nullable<System.DateTime> endDate) { return default(System.Nullable<System.Int32>); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "DATEDIFF")]
    public static System.Nullable<System.Int32> DateDiff(string datePartArg, string startDate, System.Nullable<System.DateTimeOffset> endDate) { return default(System.Nullable<System.Int32>); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "DATEDIFF")]
    public static System.Nullable<System.Int32> DateDiff(string datePartArg, string startDate, System.Nullable<System.TimeSpan> endDate) { return default(System.Nullable<System.Int32>); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "DATEDIFF")]
    public static System.Nullable<System.Int32> DateDiff(string datePartArg, string startDate, string endDate) { return default(System.Nullable<System.Int32>); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "DATENAME")]
    public static string DateName(string datePartArg, System.Nullable<System.DateTime> date) { return default(string); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "DATENAME")]
    public static string DateName(string datePartArg, System.Nullable<System.DateTimeOffset> date) { return default(string); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "DATENAME")]
    public static string DateName(string datePartArg, System.Nullable<System.TimeSpan> date) { return default(string); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "DATENAME")]
    public static string DateName(string datePartArg, string date) { return default(string); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "DATEPART")]
    public static System.Nullable<System.Int32> DatePart(string datePartArg, System.Nullable<System.DateTime> date) { return default(System.Nullable<System.Int32>); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "DATEPART")]
    public static System.Nullable<System.Int32> DatePart(string datePartArg, System.Nullable<System.DateTimeOffset> date) { return default(System.Nullable<System.Int32>); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "DATEPART")]
    public static System.Nullable<System.Int32> DatePart(string datePartArg, System.Nullable<System.TimeSpan> date) { return default(System.Nullable<System.Int32>); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "DATEPART")]
    public static System.Nullable<System.Int32> DatePart(string datePartArg, string date) { return default(System.Nullable<System.Int32>); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "DEGREES")]
    public static System.Nullable<System.Decimal> Degrees(System.Nullable<System.Decimal> arg1) { return default(System.Nullable<System.Decimal>); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "DEGREES")]
    public static System.Nullable<System.Double> Degrees(System.Nullable<System.Double> arg1) { return default(System.Nullable<System.Double>); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "DEGREES")]
    public static System.Nullable<System.Int32> Degrees(System.Nullable<System.Int32> arg1) { return default(System.Nullable<System.Int32>); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "DEGREES")]
    public static System.Nullable<System.Int64> Degrees(System.Nullable<System.Int64> arg1) { return default(System.Nullable<System.Int64>); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "DIFFERENCE")]
    public static System.Nullable<System.Int32> Difference(string string1, string string2) { return default(System.Nullable<System.Int32>); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "EXP")]
    public static System.Nullable<System.Double> Exp(System.Nullable<System.Decimal> arg) { return default(System.Nullable<System.Double>); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "EXP")]
    public static System.Nullable<System.Double> Exp(System.Nullable<System.Double> arg) { return default(System.Nullable<System.Double>); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "GETDATE")]
    public static System.Nullable<System.DateTime> GetDate() { return default(System.Nullable<System.DateTime>); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "GETUTCDATE")]
    public static System.Nullable<System.DateTime> GetUtcDate() { return default(System.Nullable<System.DateTime>); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "HOST_NAME")]
    public static string HostName() { return default(string); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "ISDATE")]
    public static System.Nullable<System.Int32> IsDate(string arg) { return default(System.Nullable<System.Int32>); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "ISNUMERIC")]
    public static System.Nullable<System.Int32> IsNumeric(string arg) { return default(System.Nullable<System.Int32>); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "LOG")]
    public static System.Nullable<System.Double> Log(System.Nullable<System.Decimal> arg) { return default(System.Nullable<System.Double>); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "LOG")]
    public static System.Nullable<System.Double> Log(System.Nullable<System.Double> arg) { return default(System.Nullable<System.Double>); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "LOG10")]
    public static System.Nullable<System.Double> Log10(System.Nullable<System.Decimal> arg) { return default(System.Nullable<System.Double>); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "LOG10")]
    public static System.Nullable<System.Double> Log10(System.Nullable<System.Double> arg) { return default(System.Nullable<System.Double>); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "NCHAR")]
    public static string NChar(System.Nullable<System.Int32> arg) { return default(string); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "PATINDEX")]
    public static System.Nullable<System.Int32> PatIndex(string stringPattern, string target) { return default(System.Nullable<System.Int32>); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "PI")]
    public static System.Nullable<System.Double> Pi() { return default(System.Nullable<System.Double>); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "QUOTENAME")]
    public static string QuoteName(string stringArg) { return default(string); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "QUOTENAME")]
    public static string QuoteName(string stringArg, string quoteCharacter) { return default(string); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "RADIANS")]
    public static System.Nullable<System.Decimal> Radians(System.Nullable<System.Decimal> arg) { return default(System.Nullable<System.Decimal>); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "RADIANS")]
    public static System.Nullable<System.Double> Radians(System.Nullable<System.Double> arg) { return default(System.Nullable<System.Double>); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "RADIANS")]
    public static System.Nullable<System.Int32> Radians(System.Nullable<System.Int32> arg) { return default(System.Nullable<System.Int32>); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "RADIANS")]
    public static System.Nullable<System.Int64> Radians(System.Nullable<System.Int64> arg) { return default(System.Nullable<System.Int64>); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "RAND")]
    public static System.Nullable<System.Double> Rand() { return default(System.Nullable<System.Double>); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "RAND")]
    public static System.Nullable<System.Double> Rand(System.Nullable<System.Int32> seed) { return default(System.Nullable<System.Double>); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "REPLICATE")]
    public static string Replicate(string target, System.Nullable<System.Int32> count) { return default(string); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "SIGN")]
    public static System.Nullable<System.Decimal> Sign(System.Nullable<System.Decimal> arg) { return default(System.Nullable<System.Decimal>); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "SIGN")]
    public static System.Nullable<System.Double> Sign(System.Nullable<System.Double> arg) { return default(System.Nullable<System.Double>); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "SIGN")]
    public static System.Nullable<System.Int32> Sign(System.Nullable<System.Int32> arg) { return default(System.Nullable<System.Int32>); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "SIGN")]
    public static System.Nullable<System.Int64> Sign(System.Nullable<System.Int64> arg) { return default(System.Nullable<System.Int64>); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "SIN")]
    public static System.Nullable<System.Double> Sin(System.Nullable<System.Decimal> arg) { return default(System.Nullable<System.Double>); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "SIN")]
    public static System.Nullable<System.Double> Sin(System.Nullable<System.Double> arg) { return default(System.Nullable<System.Double>); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "SOUNDEX")]
    public static string SoundCode(string arg) { return default(string); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "SPACE")]
    public static string Space(System.Nullable<System.Int32> arg1) { return default(string); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "SQUARE")]
    public static System.Nullable<System.Double> Square(System.Nullable<System.Decimal> arg1) { return default(System.Nullable<System.Double>); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "SQUARE")]
    public static System.Nullable<System.Double> Square(System.Nullable<System.Double> arg1) { return default(System.Nullable<System.Double>); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "SQRT")]
    public static System.Nullable<System.Double> SquareRoot(System.Nullable<System.Decimal> arg) { return default(System.Nullable<System.Double>); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "SQRT")]
    public static System.Nullable<System.Double> SquareRoot(System.Nullable<System.Double> arg) { return default(System.Nullable<System.Double>); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "STR")]
    public static string StringConvert(System.Nullable<System.Decimal> number) { return default(string); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "STR")]
    public static string StringConvert(System.Nullable<System.Decimal> number, System.Nullable<System.Int32> length) { return default(string); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "STR")]
    public static string StringConvert(System.Nullable<System.Decimal> number, System.Nullable<System.Int32> length, System.Nullable<System.Int32> decimalArg) { return default(string); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "STR")]
    public static string StringConvert(System.Nullable<System.Double> number) { return default(string); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "STR")]
    public static string StringConvert(System.Nullable<System.Double> number, System.Nullable<System.Int32> length) { return default(string); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "STR")]
    public static string StringConvert(System.Nullable<System.Double> number, System.Nullable<System.Int32> length, System.Nullable<System.Int32> decimalArg) { return default(string); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "STUFF")]
    public static string Stuff(string stringInput, System.Nullable<System.Int32> start, System.Nullable<System.Int32> length, string stringReplacement) { return default(string); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "TAN")]
    public static System.Nullable<System.Double> Tan(System.Nullable<System.Decimal> arg) { return default(System.Nullable<System.Double>); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "TAN")]
    public static System.Nullable<System.Double> Tan(System.Nullable<System.Double> arg) { return default(System.Nullable<System.Double>); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "UNICODE")]
    public static System.Nullable<System.Int32> Unicode(string arg) { return default(System.Nullable<System.Int32>); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "USER_NAME")]
    public static string UserName() { return default(string); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "USER_NAME")]
    public static string UserName(System.Nullable<System.Int32> arg) { return default(string); }
  }
  public static partial class SqlSpatialFunctions {
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "ASTEXTZM")]
    public static string AsTextZM(System.Data.Spatial.DbGeography geographyValue) { return default(string); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "ASTEXTZM")]
    public static string AsTextZM(System.Data.Spatial.DbGeometry geometryValue) { return default(string); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "BUFFERWITHTOLERANCE")]
    public static System.Data.Spatial.DbGeography BufferWithTolerance(System.Data.Spatial.DbGeography geographyValue, System.Nullable<System.Double> distance, System.Nullable<System.Double> tolerance, System.Nullable<System.Boolean> relative) { return default(System.Data.Spatial.DbGeography); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "BUFFERWITHTOLERANCE")]
    public static System.Data.Spatial.DbGeometry BufferWithTolerance(System.Data.Spatial.DbGeometry geometryValue, System.Nullable<System.Double> distance, System.Nullable<System.Double> tolerance, System.Nullable<System.Boolean> relative) { return default(System.Data.Spatial.DbGeometry); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "ENVELOPEANGLE")]
    public static System.Nullable<System.Double> EnvelopeAngle(System.Data.Spatial.DbGeography geographyValue) { return default(System.Nullable<System.Double>); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "ENVELOPECENTER")]
    public static System.Data.Spatial.DbGeography EnvelopeCenter(System.Data.Spatial.DbGeography geographyValue) { return default(System.Data.Spatial.DbGeography); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "FILTER")]
    public static System.Nullable<System.Boolean> Filter(System.Data.Spatial.DbGeography geographyValue, System.Data.Spatial.DbGeography geographyOther) { return default(System.Nullable<System.Boolean>); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "FILTER")]
    public static System.Nullable<System.Boolean> Filter(System.Data.Spatial.DbGeometry geometryValue, System.Data.Spatial.DbGeometry geometryOther) { return default(System.Nullable<System.Boolean>); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "INSTANCEOF")]
    public static System.Nullable<System.Boolean> InstanceOf(System.Data.Spatial.DbGeography geographyValue, string geometryTypeName) { return default(System.Nullable<System.Boolean>); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "INSTANCEOF")]
    public static System.Nullable<System.Boolean> InstanceOf(System.Data.Spatial.DbGeometry geometryValue, string geometryTypeName) { return default(System.Nullable<System.Boolean>); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "MAKEVALID")]
    public static System.Data.Spatial.DbGeometry MakeValid(System.Data.Spatial.DbGeometry geometryValue) { return default(System.Data.Spatial.DbGeometry); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "NUMRINGS")]
    public static System.Nullable<System.Int32> NumRings(System.Data.Spatial.DbGeography geographyValue) { return default(System.Nullable<System.Int32>); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "POINTGEOGRAPHY")]
    public static System.Data.Spatial.DbGeography PointGeography(System.Nullable<System.Double> latitude, System.Nullable<System.Double> longitude, System.Nullable<System.Int32> spatialReferenceId) { return default(System.Data.Spatial.DbGeography); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "POINTGEOMETRY")]
    public static System.Data.Spatial.DbGeometry PointGeometry(System.Nullable<System.Double> xCoordinate, System.Nullable<System.Double> yCoordinate, System.Nullable<System.Int32> spatialReferenceId) { return default(System.Data.Spatial.DbGeometry); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "REDUCE")]
    public static System.Data.Spatial.DbGeography Reduce(System.Data.Spatial.DbGeography geographyValue, System.Nullable<System.Double> tolerance) { return default(System.Data.Spatial.DbGeography); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "REDUCE")]
    public static System.Data.Spatial.DbGeometry Reduce(System.Data.Spatial.DbGeometry geometryValue, System.Nullable<System.Double> tolerance) { return default(System.Data.Spatial.DbGeometry); }
    [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "RINGN")]
    public static System.Data.Spatial.DbGeography RingN(System.Data.Spatial.DbGeography geographyValue, System.Nullable<System.Int32> index) { return default(System.Data.Spatial.DbGeography); }
  }
}
namespace System.Data.Spatial {
  [System.ComponentModel.DataAnnotations.BindableTypeAttribute]
  [System.Runtime.Serialization.DataContractAttribute]
  public partial class DbGeography {
    internal DbGeography() { }
    public System.Nullable<System.Double> Area { get { return default(System.Nullable<System.Double>); } }
    public int CoordinateSystemId { get { return default(int); } }
    public static int DefaultCoordinateSystemId { get { return default(int); } }
    public int Dimension { get { return default(int); } }
    public System.Nullable<System.Int32> ElementCount { get { return default(System.Nullable<System.Int32>); } }
    public System.Nullable<System.Double> Elevation { get { return default(System.Nullable<System.Double>); } }
    public System.Data.Spatial.DbGeography EndPoint { get { return default(System.Data.Spatial.DbGeography); } }
    public System.Nullable<System.Boolean> IsClosed { get { return default(System.Nullable<System.Boolean>); } }
    public bool IsEmpty { get { return default(bool); } }
    public System.Nullable<System.Double> Latitude { get { return default(System.Nullable<System.Double>); } }
    public System.Nullable<System.Double> Length { get { return default(System.Nullable<System.Double>); } }
    public System.Nullable<System.Double> Longitude { get { return default(System.Nullable<System.Double>); } }
    public System.Nullable<System.Double> Measure { get { return default(System.Nullable<System.Double>); } }
    public System.Nullable<System.Int32> PointCount { get { return default(System.Nullable<System.Int32>); } }
    public object ProviderValue { get { return default(object); } }
    public string SpatialTypeName { get { return default(string); } }
    public System.Data.Spatial.DbGeography StartPoint { get { return default(System.Data.Spatial.DbGeography); } }
    [System.Runtime.Serialization.DataMemberAttribute(Name="Geography")]
    public System.Data.Spatial.DbGeographyWellKnownValue WellKnownValue { get { return default(System.Data.Spatial.DbGeographyWellKnownValue); } set { } }
    public System.Byte[] AsBinary() { return default(System.Byte[]); }
    public string AsGml() { return default(string); }
    public string AsText() { return default(string); }
    public System.Data.Spatial.DbGeography Buffer(System.Nullable<System.Double> distance) { return default(System.Data.Spatial.DbGeography); }
    public System.Data.Spatial.DbGeography Difference(System.Data.Spatial.DbGeography other) { return default(System.Data.Spatial.DbGeography); }
    public bool Disjoint(System.Data.Spatial.DbGeography other) { return default(bool); }
    public System.Nullable<System.Double> Distance(System.Data.Spatial.DbGeography other) { return default(System.Nullable<System.Double>); }
    public System.Data.Spatial.DbGeography ElementAt(int index) { return default(System.Data.Spatial.DbGeography); }
    public static System.Data.Spatial.DbGeography FromBinary(System.Byte[] wellKnownBinary) { return default(System.Data.Spatial.DbGeography); }
    public static System.Data.Spatial.DbGeography FromBinary(System.Byte[] wellKnownBinary, int coordinateSystemId) { return default(System.Data.Spatial.DbGeography); }
    public static System.Data.Spatial.DbGeography FromGml(string geographyMarkup) { return default(System.Data.Spatial.DbGeography); }
    public static System.Data.Spatial.DbGeography FromGml(string geographyMarkup, int coordinateSystemId) { return default(System.Data.Spatial.DbGeography); }
    public static System.Data.Spatial.DbGeography FromText(string wellKnownText) { return default(System.Data.Spatial.DbGeography); }
    public static System.Data.Spatial.DbGeography FromText(string wellKnownText, int coordinateSystemId) { return default(System.Data.Spatial.DbGeography); }
    public static System.Data.Spatial.DbGeography GeographyCollectionFromBinary(System.Byte[] geographyCollectionWellKnownBinary, int coordinateSystemId) { return default(System.Data.Spatial.DbGeography); }
    public static System.Data.Spatial.DbGeography GeographyCollectionFromText(string geographyCollectionWellKnownText, int coordinateSystemId) { return default(System.Data.Spatial.DbGeography); }
    public System.Data.Spatial.DbGeography Intersection(System.Data.Spatial.DbGeography other) { return default(System.Data.Spatial.DbGeography); }
    public bool Intersects(System.Data.Spatial.DbGeography other) { return default(bool); }
    public static System.Data.Spatial.DbGeography LineFromBinary(System.Byte[] lineWellKnownBinary, int coordinateSystemId) { return default(System.Data.Spatial.DbGeography); }
    public static System.Data.Spatial.DbGeography LineFromText(string lineWellKnownText, int coordinateSystemId) { return default(System.Data.Spatial.DbGeography); }
    public static System.Data.Spatial.DbGeography MultiLineFromBinary(System.Byte[] multiLineWellKnownBinary, int coordinateSystemId) { return default(System.Data.Spatial.DbGeography); }
    public static System.Data.Spatial.DbGeography MultiLineFromText(string multiLineWellKnownText, int coordinateSystemId) { return default(System.Data.Spatial.DbGeography); }
    public static System.Data.Spatial.DbGeography MultiPointFromBinary(System.Byte[] multiPointWellKnownBinary, int coordinateSystemId) { return default(System.Data.Spatial.DbGeography); }
    public static System.Data.Spatial.DbGeography MultiPointFromText(string multiPointWellKnownText, int coordinateSystemId) { return default(System.Data.Spatial.DbGeography); }
    public static System.Data.Spatial.DbGeography MultiPolygonFromBinary(System.Byte[] multiPolygonWellKnownBinary, int coordinateSystemId) { return default(System.Data.Spatial.DbGeography); }
    public static System.Data.Spatial.DbGeography MultiPolygonFromText(string multiPolygonWellKnownText, int coordinateSystemId) { return default(System.Data.Spatial.DbGeography); }
    public System.Data.Spatial.DbGeography PointAt(int index) { return default(System.Data.Spatial.DbGeography); }
    public static System.Data.Spatial.DbGeography PointFromBinary(System.Byte[] pointWellKnownBinary, int coordinateSystemId) { return default(System.Data.Spatial.DbGeography); }
    public static System.Data.Spatial.DbGeography PointFromText(string pointWellKnownText, int coordinateSystemId) { return default(System.Data.Spatial.DbGeography); }
    public static System.Data.Spatial.DbGeography PolygonFromBinary(System.Byte[] polygonWellKnownBinary, int coordinateSystemId) { return default(System.Data.Spatial.DbGeography); }
    public static System.Data.Spatial.DbGeography PolygonFromText(string polygonWellKnownText, int coordinateSystemId) { return default(System.Data.Spatial.DbGeography); }
    public bool SpatialEquals(System.Data.Spatial.DbGeography other) { return default(bool); }
    public System.Data.Spatial.DbGeography SymmetricDifference(System.Data.Spatial.DbGeography other) { return default(System.Data.Spatial.DbGeography); }
    public override string ToString() { return default(string); }
    public System.Data.Spatial.DbGeography Union(System.Data.Spatial.DbGeography other) { return default(System.Data.Spatial.DbGeography); }
  }
  [System.Runtime.Serialization.DataContractAttribute]
  public sealed partial class DbGeographyWellKnownValue {
    public DbGeographyWellKnownValue() { }
    [System.Runtime.Serialization.DataMemberAttribute(Order=1, IsRequired=false, EmitDefaultValue=false)]
    public int CoordinateSystemId { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(int); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Runtime.Serialization.DataMemberAttribute(Order=3, IsRequired=false, EmitDefaultValue=false)]
    public System.Byte[] WellKnownBinary { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Byte[]); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Runtime.Serialization.DataMemberAttribute(Order=2, IsRequired=false, EmitDefaultValue=false)]
    public string WellKnownText { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
  }
  [System.ComponentModel.DataAnnotations.BindableTypeAttribute]
  [System.Runtime.Serialization.DataContractAttribute]
  public partial class DbGeometry {
    internal DbGeometry() { }
    public System.Nullable<System.Double> Area { get { return default(System.Nullable<System.Double>); } }
    public System.Data.Spatial.DbGeometry Boundary { get { return default(System.Data.Spatial.DbGeometry); } }
    public System.Data.Spatial.DbGeometry Centroid { get { return default(System.Data.Spatial.DbGeometry); } }
    public System.Data.Spatial.DbGeometry ConvexHull { get { return default(System.Data.Spatial.DbGeometry); } }
    public int CoordinateSystemId { get { return default(int); } }
    public static int DefaultCoordinateSystemId { get { return default(int); } }
    public int Dimension { get { return default(int); } }
    public System.Nullable<System.Int32> ElementCount { get { return default(System.Nullable<System.Int32>); } }
    public System.Nullable<System.Double> Elevation { get { return default(System.Nullable<System.Double>); } }
    public System.Data.Spatial.DbGeometry EndPoint { get { return default(System.Data.Spatial.DbGeometry); } }
    public System.Data.Spatial.DbGeometry Envelope { get { return default(System.Data.Spatial.DbGeometry); } }
    public System.Data.Spatial.DbGeometry ExteriorRing { get { return default(System.Data.Spatial.DbGeometry); } }
    public System.Nullable<System.Int32> InteriorRingCount { get { return default(System.Nullable<System.Int32>); } }
    public System.Nullable<System.Boolean> IsClosed { get { return default(System.Nullable<System.Boolean>); } }
    public bool IsEmpty { get { return default(bool); } }
    public System.Nullable<System.Boolean> IsRing { get { return default(System.Nullable<System.Boolean>); } }
    public bool IsSimple { get { return default(bool); } }
    public bool IsValid { get { return default(bool); } }
    public System.Nullable<System.Double> Length { get { return default(System.Nullable<System.Double>); } }
    public System.Nullable<System.Double> Measure { get { return default(System.Nullable<System.Double>); } }
    public System.Nullable<System.Int32> PointCount { get { return default(System.Nullable<System.Int32>); } }
    public System.Data.Spatial.DbGeometry PointOnSurface { get { return default(System.Data.Spatial.DbGeometry); } }
    public object ProviderValue { get { return default(object); } }
    public string SpatialTypeName { get { return default(string); } }
    public System.Data.Spatial.DbGeometry StartPoint { get { return default(System.Data.Spatial.DbGeometry); } }
    [System.Runtime.Serialization.DataMemberAttribute(Name="Geometry")]
    public System.Data.Spatial.DbGeometryWellKnownValue WellKnownValue { get { return default(System.Data.Spatial.DbGeometryWellKnownValue); } set { } }
    public System.Nullable<System.Double> XCoordinate { get { return default(System.Nullable<System.Double>); } }
    public System.Nullable<System.Double> YCoordinate { get { return default(System.Nullable<System.Double>); } }
    public System.Byte[] AsBinary() { return default(System.Byte[]); }
    public string AsGml() { return default(string); }
    public string AsText() { return default(string); }
    public System.Data.Spatial.DbGeometry Buffer(System.Nullable<System.Double> distance) { return default(System.Data.Spatial.DbGeometry); }
    public bool Contains(System.Data.Spatial.DbGeometry other) { return default(bool); }
    public bool Crosses(System.Data.Spatial.DbGeometry other) { return default(bool); }
    public System.Data.Spatial.DbGeometry Difference(System.Data.Spatial.DbGeometry other) { return default(System.Data.Spatial.DbGeometry); }
    public bool Disjoint(System.Data.Spatial.DbGeometry other) { return default(bool); }
    public System.Nullable<System.Double> Distance(System.Data.Spatial.DbGeometry other) { return default(System.Nullable<System.Double>); }
    public System.Data.Spatial.DbGeometry ElementAt(int index) { return default(System.Data.Spatial.DbGeometry); }
    public static System.Data.Spatial.DbGeometry FromBinary(System.Byte[] wellKnownBinary) { return default(System.Data.Spatial.DbGeometry); }
    public static System.Data.Spatial.DbGeometry FromBinary(System.Byte[] wellKnownBinary, int coordinateSystemId) { return default(System.Data.Spatial.DbGeometry); }
    public static System.Data.Spatial.DbGeometry FromGml(string geometryMarkup) { return default(System.Data.Spatial.DbGeometry); }
    public static System.Data.Spatial.DbGeometry FromGml(string geometryMarkup, int coordinateSystemId) { return default(System.Data.Spatial.DbGeometry); }
    public static System.Data.Spatial.DbGeometry FromText(string wellKnownText) { return default(System.Data.Spatial.DbGeometry); }
    public static System.Data.Spatial.DbGeometry FromText(string wellKnownText, int coordinateSystemId) { return default(System.Data.Spatial.DbGeometry); }
    public static System.Data.Spatial.DbGeometry GeometryCollectionFromBinary(System.Byte[] geometryCollectionWellKnownBinary, int coordinateSystemId) { return default(System.Data.Spatial.DbGeometry); }
    public static System.Data.Spatial.DbGeometry GeometryCollectionFromText(string geometryCollectionWellKnownText, int coordinateSystemId) { return default(System.Data.Spatial.DbGeometry); }
    public System.Data.Spatial.DbGeometry InteriorRingAt(int index) { return default(System.Data.Spatial.DbGeometry); }
    public System.Data.Spatial.DbGeometry Intersection(System.Data.Spatial.DbGeometry other) { return default(System.Data.Spatial.DbGeometry); }
    public bool Intersects(System.Data.Spatial.DbGeometry other) { return default(bool); }
    public static System.Data.Spatial.DbGeometry LineFromBinary(System.Byte[] lineWellKnownBinary, int coordinateSystemId) { return default(System.Data.Spatial.DbGeometry); }
    public static System.Data.Spatial.DbGeometry LineFromText(string lineWellKnownText, int coordinateSystemId) { return default(System.Data.Spatial.DbGeometry); }
    public static System.Data.Spatial.DbGeometry MultiLineFromBinary(System.Byte[] multiLineWellKnownBinary, int coordinateSystemId) { return default(System.Data.Spatial.DbGeometry); }
    public static System.Data.Spatial.DbGeometry MultiLineFromText(string multiLineWellKnownText, int coordinateSystemId) { return default(System.Data.Spatial.DbGeometry); }
    public static System.Data.Spatial.DbGeometry MultiPointFromBinary(System.Byte[] multiPointWellKnownBinary, int coordinateSystemId) { return default(System.Data.Spatial.DbGeometry); }
    public static System.Data.Spatial.DbGeometry MultiPointFromText(string multiPointWellKnownText, int coordinateSystemId) { return default(System.Data.Spatial.DbGeometry); }
    public static System.Data.Spatial.DbGeometry MultiPolygonFromBinary(System.Byte[] multiPolygonWellKnownBinary, int coordinateSystemId) { return default(System.Data.Spatial.DbGeometry); }
    public static System.Data.Spatial.DbGeometry MultiPolygonFromText(string multiPolygonWellKnownText, int coordinateSystemId) { return default(System.Data.Spatial.DbGeometry); }
    public bool Overlaps(System.Data.Spatial.DbGeometry other) { return default(bool); }
    public System.Data.Spatial.DbGeometry PointAt(int index) { return default(System.Data.Spatial.DbGeometry); }
    public static System.Data.Spatial.DbGeometry PointFromBinary(System.Byte[] pointWellKnownBinary, int coordinateSystemId) { return default(System.Data.Spatial.DbGeometry); }
    public static System.Data.Spatial.DbGeometry PointFromText(string pointWellKnownText, int coordinateSystemId) { return default(System.Data.Spatial.DbGeometry); }
    public static System.Data.Spatial.DbGeometry PolygonFromBinary(System.Byte[] polygonWellKnownBinary, int coordinateSystemId) { return default(System.Data.Spatial.DbGeometry); }
    public static System.Data.Spatial.DbGeometry PolygonFromText(string polygonWellKnownText, int coordinateSystemId) { return default(System.Data.Spatial.DbGeometry); }
    public bool Relate(System.Data.Spatial.DbGeometry other, string matrix) { return default(bool); }
    public bool SpatialEquals(System.Data.Spatial.DbGeometry other) { return default(bool); }
    public System.Data.Spatial.DbGeometry SymmetricDifference(System.Data.Spatial.DbGeometry other) { return default(System.Data.Spatial.DbGeometry); }
    public override string ToString() { return default(string); }
    public bool Touches(System.Data.Spatial.DbGeometry other) { return default(bool); }
    public System.Data.Spatial.DbGeometry Union(System.Data.Spatial.DbGeometry other) { return default(System.Data.Spatial.DbGeometry); }
    public bool Within(System.Data.Spatial.DbGeometry other) { return default(bool); }
  }
  [System.Runtime.Serialization.DataContractAttribute]
  public sealed partial class DbGeometryWellKnownValue {
    public DbGeometryWellKnownValue() { }
    [System.Runtime.Serialization.DataMemberAttribute(Order=1, IsRequired=false, EmitDefaultValue=false)]
    public int CoordinateSystemId { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(int); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Runtime.Serialization.DataMemberAttribute(Order=3, IsRequired=false, EmitDefaultValue=false)]
    public System.Byte[] WellKnownBinary { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Byte[]); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Runtime.Serialization.DataMemberAttribute(Order=2, IsRequired=false, EmitDefaultValue=false)]
    public string WellKnownText { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
  }
  public abstract partial class DbSpatialDataReader {
    protected DbSpatialDataReader() { }
    public abstract System.Data.Spatial.DbGeography GetGeography(int ordinal);
    public abstract System.Data.Spatial.DbGeometry GetGeometry(int ordinal);
  }
  public abstract partial class DbSpatialServices {
    protected DbSpatialServices() { }
    public static System.Data.Spatial.DbSpatialServices Default { get { return default(System.Data.Spatial.DbSpatialServices); } }
    public abstract System.Byte[] AsBinary(System.Data.Spatial.DbGeography geographyValue);
    public abstract System.Byte[] AsBinary(System.Data.Spatial.DbGeometry geometryValue);
    public abstract string AsGml(System.Data.Spatial.DbGeography geographyValue);
    public abstract string AsGml(System.Data.Spatial.DbGeometry geometryValue);
    public abstract string AsText(System.Data.Spatial.DbGeography geographyValue);
    public abstract string AsText(System.Data.Spatial.DbGeometry geometryValue);
    public virtual string AsTextIncludingElevationAndMeasure(System.Data.Spatial.DbGeography geographyValue) { return default(string); }
    public virtual string AsTextIncludingElevationAndMeasure(System.Data.Spatial.DbGeometry geometryValue) { return default(string); }
    public abstract System.Data.Spatial.DbGeography Buffer(System.Data.Spatial.DbGeography geographyValue, double distance);
    public abstract System.Data.Spatial.DbGeometry Buffer(System.Data.Spatial.DbGeometry geometryValue, double distance);
    public abstract bool Contains(System.Data.Spatial.DbGeometry geometryValue, System.Data.Spatial.DbGeometry otherGeometry);
    protected static System.Data.Spatial.DbGeography CreateGeography(System.Data.Spatial.DbSpatialServices spatialServices, object providerValue) { return default(System.Data.Spatial.DbGeography); }
    protected static System.Data.Spatial.DbGeometry CreateGeometry(System.Data.Spatial.DbSpatialServices spatialServices, object providerValue) { return default(System.Data.Spatial.DbGeometry); }
    public abstract object CreateProviderValue(System.Data.Spatial.DbGeographyWellKnownValue wellKnownValue);
    public abstract object CreateProviderValue(System.Data.Spatial.DbGeometryWellKnownValue wellKnownValue);
    public abstract System.Data.Spatial.DbGeographyWellKnownValue CreateWellKnownValue(System.Data.Spatial.DbGeography geographyValue);
    public abstract System.Data.Spatial.DbGeometryWellKnownValue CreateWellKnownValue(System.Data.Spatial.DbGeometry geometryValue);
    public abstract bool Crosses(System.Data.Spatial.DbGeometry geometryValue, System.Data.Spatial.DbGeometry otherGeometry);
    public abstract System.Data.Spatial.DbGeography Difference(System.Data.Spatial.DbGeography geographyValue, System.Data.Spatial.DbGeography otherGeography);
    public abstract System.Data.Spatial.DbGeometry Difference(System.Data.Spatial.DbGeometry geometryValue, System.Data.Spatial.DbGeometry otherGeometry);
    public abstract bool Disjoint(System.Data.Spatial.DbGeography geographyValue, System.Data.Spatial.DbGeography otherGeography);
    public abstract bool Disjoint(System.Data.Spatial.DbGeometry geometryValue, System.Data.Spatial.DbGeometry otherGeometry);
    public abstract double Distance(System.Data.Spatial.DbGeography geographyValue, System.Data.Spatial.DbGeography otherGeography);
    public abstract double Distance(System.Data.Spatial.DbGeometry geometryValue, System.Data.Spatial.DbGeometry otherGeometry);
    public abstract System.Data.Spatial.DbGeography ElementAt(System.Data.Spatial.DbGeography geographyValue, int index);
    public abstract System.Data.Spatial.DbGeometry ElementAt(System.Data.Spatial.DbGeometry geometryValue, int index);
    public abstract System.Data.Spatial.DbGeography GeographyCollectionFromBinary(System.Byte[] geographyCollectionWellKnownBinary, int coordinateSystemId);
    public abstract System.Data.Spatial.DbGeography GeographyCollectionFromText(string geographyCollectionWellKnownText, int coordinateSystemId);
    public abstract System.Data.Spatial.DbGeography GeographyFromBinary(System.Byte[] wellKnownBinary);
    public abstract System.Data.Spatial.DbGeography GeographyFromBinary(System.Byte[] wellKnownBinary, int coordinateSystemId);
    public abstract System.Data.Spatial.DbGeography GeographyFromGml(string geographyMarkup);
    public abstract System.Data.Spatial.DbGeography GeographyFromGml(string geographyMarkup, int coordinateSystemId);
    public abstract System.Data.Spatial.DbGeography GeographyFromProviderValue(object providerValue);
    public abstract System.Data.Spatial.DbGeography GeographyFromText(string wellKnownText);
    public abstract System.Data.Spatial.DbGeography GeographyFromText(string wellKnownText, int coordinateSystemId);
    public abstract System.Data.Spatial.DbGeography GeographyLineFromBinary(System.Byte[] lineWellKnownBinary, int coordinateSystemId);
    public abstract System.Data.Spatial.DbGeography GeographyLineFromText(string lineWellKnownText, int coordinateSystemId);
    public abstract System.Data.Spatial.DbGeography GeographyMultiLineFromBinary(System.Byte[] multiLineWellKnownBinary, int coordinateSystemId);
    public abstract System.Data.Spatial.DbGeography GeographyMultiLineFromText(string multiLineWellKnownText, int coordinateSystemId);
    public abstract System.Data.Spatial.DbGeography GeographyMultiPointFromBinary(System.Byte[] multiPointWellKnownBinary, int coordinateSystemId);
    public abstract System.Data.Spatial.DbGeography GeographyMultiPointFromText(string multiPointWellKnownText, int coordinateSystemId);
    public abstract System.Data.Spatial.DbGeography GeographyMultiPolygonFromBinary(System.Byte[] multiPolygonWellKnownBinary, int coordinateSystemId);
    public abstract System.Data.Spatial.DbGeography GeographyMultiPolygonFromText(string multiPolygonWellKnownText, int coordinateSystemId);
    public abstract System.Data.Spatial.DbGeography GeographyPointFromBinary(System.Byte[] pointWellKnownBinary, int coordinateSystemId);
    public abstract System.Data.Spatial.DbGeography GeographyPointFromText(string pointWellKnownText, int coordinateSystemId);
    public abstract System.Data.Spatial.DbGeography GeographyPolygonFromBinary(System.Byte[] polygonWellKnownBinary, int coordinateSystemId);
    public abstract System.Data.Spatial.DbGeography GeographyPolygonFromText(string polygonWellKnownText, int coordinateSystemId);
    public abstract System.Data.Spatial.DbGeometry GeometryCollectionFromBinary(System.Byte[] geometryCollectionWellKnownBinary, int coordinateSystemId);
    public abstract System.Data.Spatial.DbGeometry GeometryCollectionFromText(string geometryCollectionWellKnownText, int coordinateSystemId);
    public abstract System.Data.Spatial.DbGeometry GeometryFromBinary(System.Byte[] wellKnownBinary);
    public abstract System.Data.Spatial.DbGeometry GeometryFromBinary(System.Byte[] wellKnownBinary, int coordinateSystemId);
    public abstract System.Data.Spatial.DbGeometry GeometryFromGml(string geometryMarkup);
    public abstract System.Data.Spatial.DbGeometry GeometryFromGml(string geometryMarkup, int coordinateSystemId);
    public abstract System.Data.Spatial.DbGeometry GeometryFromProviderValue(object providerValue);
    public abstract System.Data.Spatial.DbGeometry GeometryFromText(string wellKnownText);
    public abstract System.Data.Spatial.DbGeometry GeometryFromText(string wellKnownText, int coordinateSystemId);
    public abstract System.Data.Spatial.DbGeometry GeometryLineFromBinary(System.Byte[] lineWellKnownBinary, int coordinateSystemId);
    public abstract System.Data.Spatial.DbGeometry GeometryLineFromText(string lineWellKnownText, int coordinateSystemId);
    public abstract System.Data.Spatial.DbGeometry GeometryMultiLineFromBinary(System.Byte[] multiLineWellKnownBinary, int coordinateSystemId);
    public abstract System.Data.Spatial.DbGeometry GeometryMultiLineFromText(string multiLineWellKnownText, int coordinateSystemId);
    public abstract System.Data.Spatial.DbGeometry GeometryMultiPointFromBinary(System.Byte[] multiPointWellKnownBinary, int coordinateSystemId);
    public abstract System.Data.Spatial.DbGeometry GeometryMultiPointFromText(string multiPointWellKnownText, int coordinateSystemId);
    public abstract System.Data.Spatial.DbGeometry GeometryMultiPolygonFromBinary(System.Byte[] multiPolygonWellKnownBinary, int coordinateSystemId);
    public abstract System.Data.Spatial.DbGeometry GeometryMultiPolygonFromText(string multiPolygonKnownText, int coordinateSystemId);
    public abstract System.Data.Spatial.DbGeometry GeometryPointFromBinary(System.Byte[] pointWellKnownBinary, int coordinateSystemId);
    public abstract System.Data.Spatial.DbGeometry GeometryPointFromText(string pointWellKnownText, int coordinateSystemId);
    public abstract System.Data.Spatial.DbGeometry GeometryPolygonFromBinary(System.Byte[] polygonWellKnownBinary, int coordinateSystemId);
    public abstract System.Data.Spatial.DbGeometry GeometryPolygonFromText(string polygonWellKnownText, int coordinateSystemId);
    public abstract System.Nullable<System.Double> GetArea(System.Data.Spatial.DbGeography geographyValue);
    public abstract System.Nullable<System.Double> GetArea(System.Data.Spatial.DbGeometry geometryValue);
    public abstract System.Data.Spatial.DbGeometry GetBoundary(System.Data.Spatial.DbGeometry geometryValue);
    public abstract System.Data.Spatial.DbGeometry GetCentroid(System.Data.Spatial.DbGeometry geometryValue);
    public abstract System.Data.Spatial.DbGeometry GetConvexHull(System.Data.Spatial.DbGeometry geometryValue);
    public abstract int GetCoordinateSystemId(System.Data.Spatial.DbGeography geographyValue);
    public abstract int GetCoordinateSystemId(System.Data.Spatial.DbGeometry geometryValue);
    public abstract int GetDimension(System.Data.Spatial.DbGeography geographyValue);
    public abstract int GetDimension(System.Data.Spatial.DbGeometry geometryValue);
    public abstract System.Nullable<System.Int32> GetElementCount(System.Data.Spatial.DbGeography geographyValue);
    public abstract System.Nullable<System.Int32> GetElementCount(System.Data.Spatial.DbGeometry geometryValue);
    public abstract System.Nullable<System.Double> GetElevation(System.Data.Spatial.DbGeography geographyValue);
    public abstract System.Nullable<System.Double> GetElevation(System.Data.Spatial.DbGeometry geometryValue);
    public abstract System.Data.Spatial.DbGeography GetEndPoint(System.Data.Spatial.DbGeography geographyValue);
    public abstract System.Data.Spatial.DbGeometry GetEndPoint(System.Data.Spatial.DbGeometry geometryValue);
    public abstract System.Data.Spatial.DbGeometry GetEnvelope(System.Data.Spatial.DbGeometry geometryValue);
    public abstract System.Data.Spatial.DbGeometry GetExteriorRing(System.Data.Spatial.DbGeometry geometryValue);
    public abstract System.Nullable<System.Int32> GetInteriorRingCount(System.Data.Spatial.DbGeometry geometryValue);
    public abstract System.Nullable<System.Boolean> GetIsClosed(System.Data.Spatial.DbGeography geographyValue);
    public abstract System.Nullable<System.Boolean> GetIsClosed(System.Data.Spatial.DbGeometry geometryValue);
    public abstract bool GetIsEmpty(System.Data.Spatial.DbGeography geographyValue);
    public abstract bool GetIsEmpty(System.Data.Spatial.DbGeometry geometryValue);
    public abstract System.Nullable<System.Boolean> GetIsRing(System.Data.Spatial.DbGeometry geometryValue);
    public abstract bool GetIsSimple(System.Data.Spatial.DbGeometry geometryValue);
    public abstract bool GetIsValid(System.Data.Spatial.DbGeometry geometryValue);
    public abstract System.Nullable<System.Double> GetLatitude(System.Data.Spatial.DbGeography geographyValue);
    public abstract System.Nullable<System.Double> GetLength(System.Data.Spatial.DbGeography geographyValue);
    public abstract System.Nullable<System.Double> GetLength(System.Data.Spatial.DbGeometry geometryValue);
    public abstract System.Nullable<System.Double> GetLongitude(System.Data.Spatial.DbGeography geographyValue);
    public abstract System.Nullable<System.Double> GetMeasure(System.Data.Spatial.DbGeography geographyValue);
    public abstract System.Nullable<System.Double> GetMeasure(System.Data.Spatial.DbGeometry geometryValue);
    public abstract System.Nullable<System.Int32> GetPointCount(System.Data.Spatial.DbGeography geographyValue);
    public abstract System.Nullable<System.Int32> GetPointCount(System.Data.Spatial.DbGeometry geometryValue);
    public abstract System.Data.Spatial.DbGeometry GetPointOnSurface(System.Data.Spatial.DbGeometry geometryValue);
    public abstract string GetSpatialTypeName(System.Data.Spatial.DbGeography geographyValue);
    public abstract string GetSpatialTypeName(System.Data.Spatial.DbGeometry geometryValue);
    public abstract System.Data.Spatial.DbGeography GetStartPoint(System.Data.Spatial.DbGeography geographyValue);
    public abstract System.Data.Spatial.DbGeometry GetStartPoint(System.Data.Spatial.DbGeometry geometryValue);
    public abstract System.Nullable<System.Double> GetXCoordinate(System.Data.Spatial.DbGeometry geometryValue);
    public abstract System.Nullable<System.Double> GetYCoordinate(System.Data.Spatial.DbGeometry geometryValue);
    public abstract System.Data.Spatial.DbGeometry InteriorRingAt(System.Data.Spatial.DbGeometry geometryValue, int index);
    public abstract System.Data.Spatial.DbGeography Intersection(System.Data.Spatial.DbGeography geographyValue, System.Data.Spatial.DbGeography otherGeography);
    public abstract System.Data.Spatial.DbGeometry Intersection(System.Data.Spatial.DbGeometry geometryValue, System.Data.Spatial.DbGeometry otherGeometry);
    public abstract bool Intersects(System.Data.Spatial.DbGeography geographyValue, System.Data.Spatial.DbGeography otherGeography);
    public abstract bool Intersects(System.Data.Spatial.DbGeometry geometryValue, System.Data.Spatial.DbGeometry otherGeometry);
    public abstract bool Overlaps(System.Data.Spatial.DbGeometry geometryValue, System.Data.Spatial.DbGeometry otherGeometry);
    public abstract System.Data.Spatial.DbGeography PointAt(System.Data.Spatial.DbGeography geographyValue, int index);
    public abstract System.Data.Spatial.DbGeometry PointAt(System.Data.Spatial.DbGeometry geometryValue, int index);
    public abstract bool Relate(System.Data.Spatial.DbGeometry geometryValue, System.Data.Spatial.DbGeometry otherGeometry, string matrix);
    public abstract bool SpatialEquals(System.Data.Spatial.DbGeography geographyValue, System.Data.Spatial.DbGeography otherGeography);
    public abstract bool SpatialEquals(System.Data.Spatial.DbGeometry geometryValue, System.Data.Spatial.DbGeometry otherGeometry);
    public abstract System.Data.Spatial.DbGeography SymmetricDifference(System.Data.Spatial.DbGeography geographyValue, System.Data.Spatial.DbGeography otherGeography);
    public abstract System.Data.Spatial.DbGeometry SymmetricDifference(System.Data.Spatial.DbGeometry geometryValue, System.Data.Spatial.DbGeometry otherGeometry);
    public abstract bool Touches(System.Data.Spatial.DbGeometry geometryValue, System.Data.Spatial.DbGeometry otherGeometry);
    public abstract System.Data.Spatial.DbGeography Union(System.Data.Spatial.DbGeography geographyValue, System.Data.Spatial.DbGeography otherGeography);
    public abstract System.Data.Spatial.DbGeometry Union(System.Data.Spatial.DbGeometry geometryValue, System.Data.Spatial.DbGeometry otherGeometry);
    public abstract bool Within(System.Data.Spatial.DbGeometry geometryValue, System.Data.Spatial.DbGeometry otherGeometry);
  }
}
namespace System.Data.SqlClient {
  [System.CLSCompliantAttribute(false)]
  public sealed partial class SqlProviderServices : System.Data.Common.DbProviderServices {
    internal SqlProviderServices() { }
    public static System.Data.SqlClient.SqlProviderServices SingletonInstance { get { return default(System.Data.SqlClient.SqlProviderServices); } }
    protected override System.Data.Common.DbCommandDefinition CreateDbCommandDefinition(System.Data.Common.DbProviderManifest providerManifest, System.Data.Common.CommandTrees.DbCommandTree commandTree) { return default(System.Data.Common.DbCommandDefinition); }
    protected override void DbCreateDatabase(System.Data.Common.DbConnection connection, System.Nullable<System.Int32> commandTimeout, System.Data.Metadata.Edm.StoreItemCollection storeItemCollection) { }
    protected override string DbCreateDatabaseScript(string providerManifestToken, System.Data.Metadata.Edm.StoreItemCollection storeItemCollection) { return default(string); }
    protected override bool DbDatabaseExists(System.Data.Common.DbConnection connection, System.Nullable<System.Int32> commandTimeout, System.Data.Metadata.Edm.StoreItemCollection storeItemCollection) { return default(bool); }
    protected override void DbDeleteDatabase(System.Data.Common.DbConnection connection, System.Nullable<System.Int32> commandTimeout, System.Data.Metadata.Edm.StoreItemCollection storeItemCollection) { }
    protected override System.Data.Spatial.DbSpatialServices DbGetSpatialServices(string versionHint) { return default(System.Data.Spatial.DbSpatialServices); }
    protected override System.Data.Common.DbProviderManifest GetDbProviderManifest(string versionHint) { return default(System.Data.Common.DbProviderManifest); }
    protected override string GetDbProviderManifestToken(System.Data.Common.DbConnection connection) { return default(string); }
    protected override System.Data.Spatial.DbSpatialDataReader GetDbSpatialDataReader(System.Data.Common.DbDataReader fromReader, string versionHint) { return default(System.Data.Spatial.DbSpatialDataReader); }
    protected override void SetDbParameterValue(System.Data.Common.DbParameter parameter, System.Data.Metadata.Edm.TypeUsage parameterType, object value) { }
  }
}
