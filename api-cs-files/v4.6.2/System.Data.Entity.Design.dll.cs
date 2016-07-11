namespace System.Data.Entity.Design {
  public partial class EdmToObjectNamespaceMap {
    internal EdmToObjectNamespaceMap() { }
    public int Count { get { return default(int); } }
    public System.Collections.Generic.ICollection<System.String> EdmNamespaces { get { return default(System.Collections.Generic.ICollection<System.String>); } }
    public string this[string edmNamespace] { get { return default(string); } set { } }
    public void Add(string edmNamespace, string objectNamespace) { }
    public void Clear() { }
    public bool Contains(string edmNamespace) { return default(bool); }
    public bool Remove(string edmNamespace) { return default(bool); }
    public bool TryGetObjectNamespace(string edmNamespace, out string objectNamespace) { objectNamespace = default(string); return default(bool); }
  }
  public sealed partial class EntityClassGenerator {
    public EntityClassGenerator() { }
    public EntityClassGenerator(System.Data.Entity.Design.LanguageOption languageOption) { }
    public System.Data.Entity.Design.EdmToObjectNamespaceMap EdmToObjectNamespaceMap { get { return default(System.Data.Entity.Design.EdmToObjectNamespaceMap); } }
    public System.Data.Entity.Design.LanguageOption LanguageOption { get { return default(System.Data.Entity.Design.LanguageOption); } set { } }
    public event System.Data.Entity.Design.PropertyGeneratedEventHandler OnPropertyGenerated { add { } remove { } }
    public event System.Data.Entity.Design.TypeGeneratedEventHandler OnTypeGenerated { add { } remove { } }
    public System.Collections.Generic.IList<System.Data.Metadata.Edm.EdmSchemaError> GenerateCode(string sourceEdmSchemaFilePath, string targetFilePath) { return default(System.Collections.Generic.IList<System.Data.Metadata.Edm.EdmSchemaError>); }
    public System.Collections.Generic.IList<System.Data.Metadata.Edm.EdmSchemaError> GenerateCode(string sourceEdmSchemaFilePath, string targetPath, System.Collections.Generic.IEnumerable<System.String> additionalEdmSchemaFilePaths) { return default(System.Collections.Generic.IList<System.Data.Metadata.Edm.EdmSchemaError>); }
    public System.Collections.Generic.IList<System.Data.Metadata.Edm.EdmSchemaError> GenerateCode(System.Xml.XmlReader sourceEdmSchema, System.IO.TextWriter target) { return default(System.Collections.Generic.IList<System.Data.Metadata.Edm.EdmSchemaError>); }
    public System.Collections.Generic.IList<System.Data.Metadata.Edm.EdmSchemaError> GenerateCode(System.Xml.XmlReader sourceEdmSchema, System.IO.TextWriter target, System.Collections.Generic.IEnumerable<System.Xml.XmlReader> additionalEdmSchemas) { return default(System.Collections.Generic.IList<System.Data.Metadata.Edm.EdmSchemaError>); }
  }
  public partial class EntityCodeGenerator {
    public EntityCodeGenerator(System.Data.Entity.Design.LanguageOption languageOption) { }
    public System.Data.Entity.Design.EdmToObjectNamespaceMap EdmToObjectNamespaceMap { get { return default(System.Data.Entity.Design.EdmToObjectNamespaceMap); } }
    public System.Data.Entity.Design.LanguageOption LanguageOption { get { return default(System.Data.Entity.Design.LanguageOption); } set { } }
    public System.Collections.Generic.IList<System.Data.Metadata.Edm.EdmSchemaError> GenerateCode(string sourceEdmSchemaFilePath, string targetPath) { return default(System.Collections.Generic.IList<System.Data.Metadata.Edm.EdmSchemaError>); }
    public System.Collections.Generic.IList<System.Data.Metadata.Edm.EdmSchemaError> GenerateCode(string sourceEdmSchemaFilePath, string targetPath, System.Collections.Generic.IEnumerable<System.String> additionalEdmSchemaFilePaths) { return default(System.Collections.Generic.IList<System.Data.Metadata.Edm.EdmSchemaError>); }
    public System.Collections.Generic.IList<System.Data.Metadata.Edm.EdmSchemaError> GenerateCode(string sourceEdmSchemaFilePath, string targetPath, System.Collections.Generic.IEnumerable<System.String> additionalEdmSchemaFilePaths, System.Version targetEntityFrameworkVersion) { return default(System.Collections.Generic.IList<System.Data.Metadata.Edm.EdmSchemaError>); }
    public System.Collections.Generic.IList<System.Data.Metadata.Edm.EdmSchemaError> GenerateCode(string sourceEdmSchemaFilePath, string targetPath, System.Version targetEntityFrameworkVersion) { return default(System.Collections.Generic.IList<System.Data.Metadata.Edm.EdmSchemaError>); }
    public System.Collections.Generic.IList<System.Data.Metadata.Edm.EdmSchemaError> GenerateCode(System.Xml.XmlReader sourceEdmSchema, System.IO.TextWriter target) { return default(System.Collections.Generic.IList<System.Data.Metadata.Edm.EdmSchemaError>); }
    public System.Collections.Generic.IList<System.Data.Metadata.Edm.EdmSchemaError> GenerateCode(System.Xml.XmlReader sourceEdmSchema, System.IO.TextWriter target, System.Collections.Generic.IEnumerable<System.Xml.XmlReader> additionalEdmSchemas) { return default(System.Collections.Generic.IList<System.Data.Metadata.Edm.EdmSchemaError>); }
    public System.Collections.Generic.IList<System.Data.Metadata.Edm.EdmSchemaError> GenerateCode(System.Xml.XmlReader sourceEdmSchema, System.IO.TextWriter target, System.Collections.Generic.IEnumerable<System.Xml.XmlReader> additionalEdmSchemas, System.Version targetEntityFrameworkVersion) { return default(System.Collections.Generic.IList<System.Data.Metadata.Edm.EdmSchemaError>); }
    public System.Collections.Generic.IList<System.Data.Metadata.Edm.EdmSchemaError> GenerateCode(System.Xml.XmlReader sourceEdmSchema, System.IO.TextWriter target, System.Version targetEntityFrameworkVersion) { return default(System.Collections.Generic.IList<System.Data.Metadata.Edm.EdmSchemaError>); }
  }
  public static partial class EntityFrameworkVersions {
    public static readonly System.Version Version1;
    public static readonly System.Version Version2;
    public static readonly System.Version Version3;
    public static System.IO.Stream GetSchemaXsd(System.Version entityFrameworkVersion, System.Data.Metadata.Edm.DataSpace dataSpace) { return default(System.IO.Stream); }
  }
  public sealed partial class EntityModelSchemaGenerator {
    public EntityModelSchemaGenerator(System.Data.Metadata.Edm.EntityContainer storeEntityContainer) { }
    public EntityModelSchemaGenerator(System.Data.Metadata.Edm.EntityContainer storeEntityContainer, string namespaceName, string modelEntityContainerName) { }
    [System.CLSCompliantAttribute(false)]
    public EntityModelSchemaGenerator(System.Data.Metadata.Edm.StoreItemCollection storeItemCollection, string namespaceName, string modelEntityContainerName) { }
    [System.CLSCompliantAttribute(false)]
    public System.Data.Metadata.Edm.EdmItemCollection EdmItemCollection { get { return default(System.Data.Metadata.Edm.EdmItemCollection); } }
    public System.Data.Metadata.Edm.EntityContainer EntityContainer { get { return default(System.Data.Metadata.Edm.EntityContainer); } }
    public bool GenerateForeignKeyProperties { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Data.Entity.Design.PluralizationServices.PluralizationService PluralizationService { get { return default(System.Data.Entity.Design.PluralizationServices.PluralizationService); } set { } }
    public System.Collections.Generic.IList<System.Data.Metadata.Edm.EdmSchemaError> GenerateMetadata() { return default(System.Collections.Generic.IList<System.Data.Metadata.Edm.EdmSchemaError>); }
    public System.Collections.Generic.IList<System.Data.Metadata.Edm.EdmSchemaError> GenerateMetadata(System.Version targetEntityFrameworkVersion) { return default(System.Collections.Generic.IList<System.Data.Metadata.Edm.EdmSchemaError>); }
    public void WriteModelSchema(string outputFileName) { }
    public void WriteModelSchema(System.Xml.XmlWriter writer) { }
    public void WriteStorageMapping(string outputFileName) { }
    public void WriteStorageMapping(System.Xml.XmlWriter writer) { }
  }
  public enum EntityStoreSchemaFilterEffect {
    Allow = 0,
    Exclude = 1,
  }
  public partial class EntityStoreSchemaFilterEntry {
    public EntityStoreSchemaFilterEntry(string catalog, string schema, string name) { }
    public EntityStoreSchemaFilterEntry(string catalog, string schema, string name, System.Data.Entity.Design.EntityStoreSchemaFilterObjectTypes types, System.Data.Entity.Design.EntityStoreSchemaFilterEffect effect) { }
    public string Catalog { [System.Diagnostics.DebuggerStepThroughAttribute]get { return default(string); } }
    public System.Data.Entity.Design.EntityStoreSchemaFilterEffect Effect { [System.Diagnostics.DebuggerStepThroughAttribute]get { return default(System.Data.Entity.Design.EntityStoreSchemaFilterEffect); } }
    public string Name { [System.Diagnostics.DebuggerStepThroughAttribute]get { return default(string); } }
    public string Schema { [System.Diagnostics.DebuggerStepThroughAttribute]get { return default(string); } }
    public System.Data.Entity.Design.EntityStoreSchemaFilterObjectTypes Types { [System.Diagnostics.DebuggerStepThroughAttribute]get { return default(System.Data.Entity.Design.EntityStoreSchemaFilterObjectTypes); } }
  }
  [System.FlagsAttribute]
  public enum EntityStoreSchemaFilterObjectTypes {
    All = 7,
    Function = 4,
    None = 0,
    Table = 1,
    View = 2,
  }
  public sealed partial class EntityStoreSchemaGenerator {
    public EntityStoreSchemaGenerator(string providerInvariantName, string connectionString, string namespaceName) { }
    public System.Data.Metadata.Edm.EntityContainer EntityContainer { get { return default(System.Data.Metadata.Edm.EntityContainer); } }
    public bool GenerateForeignKeyProperties { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.CLSCompliantAttribute(false)]
    public System.Data.Metadata.Edm.StoreItemCollection StoreItemCollection { get { return default(System.Data.Metadata.Edm.StoreItemCollection); } }
    public static System.Data.EntityClient.EntityConnection CreateStoreSchemaConnection(string providerInvariantName, string connectionString) { return default(System.Data.EntityClient.EntityConnection); }
    public static System.Data.EntityClient.EntityConnection CreateStoreSchemaConnection(string providerInvariantName, string connectionString, System.Version targetEntityFrameworkVersion) { return default(System.Data.EntityClient.EntityConnection); }
    public System.Collections.Generic.IList<System.Data.Metadata.Edm.EdmSchemaError> GenerateStoreMetadata() { return default(System.Collections.Generic.IList<System.Data.Metadata.Edm.EdmSchemaError>); }
    public System.Collections.Generic.IList<System.Data.Metadata.Edm.EdmSchemaError> GenerateStoreMetadata(System.Collections.Generic.IEnumerable<System.Data.Entity.Design.EntityStoreSchemaFilterEntry> filters) { return default(System.Collections.Generic.IList<System.Data.Metadata.Edm.EdmSchemaError>); }
    public System.Collections.Generic.IList<System.Data.Metadata.Edm.EdmSchemaError> GenerateStoreMetadata(System.Collections.Generic.IEnumerable<System.Data.Entity.Design.EntityStoreSchemaFilterEntry> filters, System.Version targetEntityFrameworkVersion) { return default(System.Collections.Generic.IList<System.Data.Metadata.Edm.EdmSchemaError>); }
    public void WriteStoreSchema(string outputFileName) { }
    public void WriteStoreSchema(System.Xml.XmlWriter writer) { }
  }
  public partial class EntityViewGenerator {
    public EntityViewGenerator() { }
    public EntityViewGenerator(System.Data.Entity.Design.LanguageOption languageOption) { }
    public System.Data.Entity.Design.LanguageOption LanguageOption { get { return default(System.Data.Entity.Design.LanguageOption); } set { } }
    [System.CLSCompliantAttribute(false)]
    public System.Collections.Generic.IList<System.Data.Metadata.Edm.EdmSchemaError> GenerateViews(System.Data.Mapping.StorageMappingItemCollection mappingCollection, System.IO.TextWriter outputWriter) { return default(System.Collections.Generic.IList<System.Data.Metadata.Edm.EdmSchemaError>); }
    [System.CLSCompliantAttribute(false)]
    public System.Collections.Generic.IList<System.Data.Metadata.Edm.EdmSchemaError> GenerateViews(System.Data.Mapping.StorageMappingItemCollection mappingCollection, System.IO.TextWriter outputWriter, System.Version targetEntityFrameworkVersion) { return default(System.Collections.Generic.IList<System.Data.Metadata.Edm.EdmSchemaError>); }
    [System.CLSCompliantAttribute(false)]
    public System.Collections.Generic.IList<System.Data.Metadata.Edm.EdmSchemaError> GenerateViews(System.Data.Mapping.StorageMappingItemCollection mappingCollection, string outputPath) { return default(System.Collections.Generic.IList<System.Data.Metadata.Edm.EdmSchemaError>); }
    [System.CLSCompliantAttribute(false)]
    public static System.Collections.Generic.IList<System.Data.Metadata.Edm.EdmSchemaError> Validate(System.Data.Mapping.StorageMappingItemCollection mappingCollection) { return default(System.Collections.Generic.IList<System.Data.Metadata.Edm.EdmSchemaError>); }
    [System.CLSCompliantAttribute(false)]
    public static System.Collections.Generic.IList<System.Data.Metadata.Edm.EdmSchemaError> Validate(System.Data.Mapping.StorageMappingItemCollection mappingCollection, System.Version targetEntityFrameworkVersion) { return default(System.Collections.Generic.IList<System.Data.Metadata.Edm.EdmSchemaError>); }
  }
  public enum LanguageOption {
    GenerateCSharpCode = 0,
    GenerateVBCode = 1,
  }
  [System.CLSCompliantAttribute(false)]
  public static partial class MetadataExtensionMethods {
    public static System.Collections.ObjectModel.ReadOnlyCollection<System.Data.Metadata.Edm.PrimitiveType> GetPrimitiveTypes(this System.Data.Metadata.Edm.EdmItemCollection itemCollection, System.Version edmVersion) { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.Data.Metadata.Edm.PrimitiveType>); }
  }
  [System.CLSCompliantAttribute(false)]
  public static partial class MetadataItemCollectionFactory {
    public static System.Data.Metadata.Edm.EdmItemCollection CreateEdmItemCollection(System.Collections.Generic.IEnumerable<System.Xml.XmlReader> readers, out System.Collections.Generic.IList<System.Data.Metadata.Edm.EdmSchemaError> errors) { errors = default(System.Collections.Generic.IList<System.Data.Metadata.Edm.EdmSchemaError>); return default(System.Data.Metadata.Edm.EdmItemCollection); }
    public static System.Data.Metadata.Edm.EdmItemCollection CreateEdmItemCollection(System.Collections.Generic.IEnumerable<System.Xml.XmlReader> readers, System.Version targetEntityFrameworkVersion, out System.Collections.Generic.IList<System.Data.Metadata.Edm.EdmSchemaError> errors) { errors = default(System.Collections.Generic.IList<System.Data.Metadata.Edm.EdmSchemaError>); return default(System.Data.Metadata.Edm.EdmItemCollection); }
    public static System.Data.Mapping.StorageMappingItemCollection CreateStorageMappingItemCollection(System.Data.Metadata.Edm.EdmItemCollection edmCollection, System.Data.Metadata.Edm.StoreItemCollection storeCollection, System.Collections.Generic.IEnumerable<System.Xml.XmlReader> readers, out System.Collections.Generic.IList<System.Data.Metadata.Edm.EdmSchemaError> errors) { errors = default(System.Collections.Generic.IList<System.Data.Metadata.Edm.EdmSchemaError>); return default(System.Data.Mapping.StorageMappingItemCollection); }
    public static System.Data.Mapping.StorageMappingItemCollection CreateStorageMappingItemCollection(System.Data.Metadata.Edm.EdmItemCollection edmCollection, System.Data.Metadata.Edm.StoreItemCollection storeCollection, System.Collections.Generic.IEnumerable<System.Xml.XmlReader> readers, System.Version targetEntityFrameworkVersion, out System.Collections.Generic.IList<System.Data.Metadata.Edm.EdmSchemaError> errors) { errors = default(System.Collections.Generic.IList<System.Data.Metadata.Edm.EdmSchemaError>); return default(System.Data.Mapping.StorageMappingItemCollection); }
    public static System.Data.Metadata.Edm.StoreItemCollection CreateStoreItemCollection(System.Collections.Generic.IEnumerable<System.Xml.XmlReader> readers, out System.Collections.Generic.IList<System.Data.Metadata.Edm.EdmSchemaError> errors) { errors = default(System.Collections.Generic.IList<System.Data.Metadata.Edm.EdmSchemaError>); return default(System.Data.Metadata.Edm.StoreItemCollection); }
    public static System.Data.Metadata.Edm.StoreItemCollection CreateStoreItemCollection(System.Collections.Generic.IEnumerable<System.Xml.XmlReader> readers, System.Version targetEntityFrameworkVersion, out System.Collections.Generic.IList<System.Data.Metadata.Edm.EdmSchemaError> errors) { errors = default(System.Collections.Generic.IList<System.Data.Metadata.Edm.EdmSchemaError>); return default(System.Data.Metadata.Edm.StoreItemCollection); }
  }
  public sealed partial class PropertyGeneratedEventArgs : System.EventArgs {
    public PropertyGeneratedEventArgs() { }
    public PropertyGeneratedEventArgs(System.Data.Metadata.Edm.MetadataItem propertySource, string backingFieldName, System.CodeDom.CodeTypeReference returnType) { }
    public System.Collections.Generic.List<System.CodeDom.CodeAttributeDeclaration> AdditionalAttributes { get { return default(System.Collections.Generic.List<System.CodeDom.CodeAttributeDeclaration>); } }
    public System.Collections.Generic.List<System.CodeDom.CodeStatement> AdditionalGetStatements { get { return default(System.Collections.Generic.List<System.CodeDom.CodeStatement>); } }
    public System.Collections.Generic.List<System.CodeDom.CodeStatement> AdditionalSetStatements { get { return default(System.Collections.Generic.List<System.CodeDom.CodeStatement>); } }
    public string BackingFieldName { get { return default(string); } }
    public System.Data.Metadata.Edm.MetadataItem PropertySource { get { return default(System.Data.Metadata.Edm.MetadataItem); } }
    public System.CodeDom.CodeTypeReference ReturnType { get { return default(System.CodeDom.CodeTypeReference); } set { } }
  }
  public delegate void PropertyGeneratedEventHandler(object sender, System.Data.Entity.Design.PropertyGeneratedEventArgs e);
  public sealed partial class TypeGeneratedEventArgs : System.EventArgs {
    public TypeGeneratedEventArgs() { }
    public TypeGeneratedEventArgs(System.Data.Metadata.Edm.GlobalItem typeSource, System.CodeDom.CodeTypeReference baseType) { }
    public System.Collections.Generic.List<System.CodeDom.CodeAttributeDeclaration> AdditionalAttributes { get { return default(System.Collections.Generic.List<System.CodeDom.CodeAttributeDeclaration>); } }
    public System.Collections.Generic.List<System.Type> AdditionalInterfaces { get { return default(System.Collections.Generic.List<System.Type>); } }
    public System.Collections.Generic.List<System.CodeDom.CodeTypeMember> AdditionalMembers { get { return default(System.Collections.Generic.List<System.CodeDom.CodeTypeMember>); } }
    public System.CodeDom.CodeTypeReference BaseType { get { return default(System.CodeDom.CodeTypeReference); } set { } }
    public System.Data.Metadata.Edm.GlobalItem TypeSource { get { return default(System.Data.Metadata.Edm.GlobalItem); } }
  }
  public delegate void TypeGeneratedEventHandler(object sender, System.Data.Entity.Design.TypeGeneratedEventArgs e);
}
namespace System.Data.Entity.Design.AspNet {
  [System.Web.Compilation.BuildProviderAppliesToAttribute((System.Web.Compilation.BuildProviderAppliesTo)(2))]
  public partial class EntityDesignerBuildProvider : System.Web.Compilation.BuildProvider {
    public EntityDesignerBuildProvider() { }
    public override void GenerateCode(System.Web.Compilation.AssemblyBuilder assemblyBuilder) { }
    public override System.Web.Compilation.BuildProviderResultFlags GetResultFlags(System.CodeDom.Compiler.CompilerResults results) { return default(System.Web.Compilation.BuildProviderResultFlags); }
  }
  [System.Web.Compilation.BuildProviderAppliesToAttribute((System.Web.Compilation.BuildProviderAppliesTo)(2))]
  public partial class EntityModelBuildProvider : System.Web.Compilation.BuildProvider {
    public EntityModelBuildProvider() { }
    public override void GenerateCode(System.Web.Compilation.AssemblyBuilder assemblyBuilder) { }
    public override System.Web.Compilation.BuildProviderResultFlags GetResultFlags(System.CodeDom.Compiler.CompilerResults results) { return default(System.Web.Compilation.BuildProviderResultFlags); }
  }
  [System.Web.Compilation.BuildProviderAppliesToAttribute((System.Web.Compilation.BuildProviderAppliesTo)(2))]
  public partial class MappingModelBuildProvider : System.Web.Compilation.BuildProvider {
    public MappingModelBuildProvider() { }
    public override void GenerateCode(System.Web.Compilation.AssemblyBuilder assemblyBuilder) { }
    public override System.Web.Compilation.BuildProviderResultFlags GetResultFlags(System.CodeDom.Compiler.CompilerResults results) { return default(System.Web.Compilation.BuildProviderResultFlags); }
  }
  [System.Web.Compilation.BuildProviderAppliesToAttribute((System.Web.Compilation.BuildProviderAppliesTo)(2))]
  public partial class StorageModelBuildProvider : System.Web.Compilation.BuildProvider {
    public StorageModelBuildProvider() { }
    public override void GenerateCode(System.Web.Compilation.AssemblyBuilder assemblyBuilder) { }
    public override System.Web.Compilation.BuildProviderResultFlags GetResultFlags(System.CodeDom.Compiler.CompilerResults results) { return default(System.Web.Compilation.BuildProviderResultFlags); }
  }
}
namespace System.Data.Entity.Design.PluralizationServices {
  public partial interface ICustomPluralizationMapping {
    void AddWord(string singular, string plural);
  }
  public abstract partial class PluralizationService {
    protected PluralizationService() { }
    public System.Globalization.CultureInfo Culture { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Globalization.CultureInfo); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]protected set { } }
    public static System.Data.Entity.Design.PluralizationServices.PluralizationService CreateService(System.Globalization.CultureInfo culture) { return default(System.Data.Entity.Design.PluralizationServices.PluralizationService); }
    public abstract bool IsPlural(string word);
    public abstract bool IsSingular(string word);
    public abstract string Pluralize(string word);
    public abstract string Singularize(string word);
  }
}
