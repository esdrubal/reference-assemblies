namespace System.Data.Services.BuildProvider {
  [System.Security.SecurityCriticalAttribute]
  [System.Web.Compilation.FolderLevelBuildProviderAppliesToAttribute((System.Web.Compilation.FolderLevelBuildProviderAppliesTo)(2))]
  public partial class DataServiceBuildProvider : System.Web.Compilation.BuildProvider {
    public DataServiceBuildProvider() { }
    [System.Security.SecuritySafeCriticalAttribute]
    public override void GenerateCode(System.Web.Compilation.AssemblyBuilder assemblyBuilder) { }
  }
}
namespace System.Data.Services.Design {
  public enum DataServiceCodeVersion {
    V1 = 0,
    V2 = 1,
  }
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
    public EntityClassGenerator(System.Data.Services.Design.LanguageOption languageOption) { }
    public System.Data.Services.Design.EdmToObjectNamespaceMap EdmToObjectNamespaceMap { get { return default(System.Data.Services.Design.EdmToObjectNamespaceMap); } }
    public System.Data.Services.Design.LanguageOption LanguageOption { get { return default(System.Data.Services.Design.LanguageOption); } set { } }
    public bool UseDataServiceCollection { get { return default(bool); } set { } }
    public System.Data.Services.Design.DataServiceCodeVersion Version { get { return default(System.Data.Services.Design.DataServiceCodeVersion); } set { } }
    public event System.EventHandler<System.Data.Services.Design.PropertyGeneratedEventArgs> OnPropertyGenerated { add { } remove { } }
    public event System.EventHandler<System.Data.Services.Design.TypeGeneratedEventArgs> OnTypeGenerated { add { } remove { } }
    public System.Collections.Generic.IList<System.Data.Metadata.Edm.EdmSchemaError> GenerateCode(System.Xml.XmlReader sourceReader, System.IO.TextWriter targetWriter, string namespacePrefix) { return default(System.Collections.Generic.IList<System.Data.Metadata.Edm.EdmSchemaError>); }
    public System.Collections.Generic.IList<System.Data.Metadata.Edm.EdmSchemaError> GenerateCode(System.Xml.XmlReader sourceReader, string targetFilePath) { return default(System.Collections.Generic.IList<System.Data.Metadata.Edm.EdmSchemaError>); }
  }
  public enum LanguageOption {
    GenerateCSharpCode = 0,
    GenerateVBCode = 1,
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
  public sealed partial class TypeGeneratedEventArgs : System.EventArgs {
    public TypeGeneratedEventArgs() { }
    public TypeGeneratedEventArgs(System.Data.Metadata.Edm.GlobalItem typeSource, System.CodeDom.CodeTypeReference baseType) { }
    public System.Collections.Generic.List<System.CodeDom.CodeAttributeDeclaration> AdditionalAttributes { get { return default(System.Collections.Generic.List<System.CodeDom.CodeAttributeDeclaration>); } }
    public System.Collections.Generic.List<System.Type> AdditionalInterfaces { get { return default(System.Collections.Generic.List<System.Type>); } }
    public System.Collections.Generic.List<System.CodeDom.CodeTypeMember> AdditionalMembers { get { return default(System.Collections.Generic.List<System.CodeDom.CodeTypeMember>); } }
    public System.CodeDom.CodeTypeReference BaseType { get { return default(System.CodeDom.CodeTypeReference); } set { } }
    public System.Data.Metadata.Edm.GlobalItem TypeSource { get { return default(System.Data.Metadata.Edm.GlobalItem); } }
  }
}
