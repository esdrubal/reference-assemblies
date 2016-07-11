namespace System.Runtime.Serialization {
  [System.AttributeUsageAttribute((System.AttributeTargets)(12), Inherited=false, AllowMultiple=false)]
  public sealed partial class CollectionDataContractAttribute : System.Attribute {
    public CollectionDataContractAttribute() { }
    public bool IsReference { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public string ItemName { get { return default(string); } set { } }
    public string KeyName { get { return default(string); } set { } }
    public string Name { get { return default(string); } set { } }
    public string Namespace { get { return default(string); } set { } }
    public string ValueName { get { return default(string); } set { } }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(3), Inherited=false, AllowMultiple=true)]
  public sealed partial class ContractNamespaceAttribute : System.Attribute {
    public ContractNamespaceAttribute(string ns) { }
    public string ClrNamespace { get { return default(string); } set { } }
    public string ContractNamespace { get { return default(string); } }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(28), Inherited=false, AllowMultiple=false)]
  public sealed partial class DataContractAttribute : System.Attribute {
    public DataContractAttribute() { }
    public bool IsReference { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public string Name { get { return default(string); } set { } }
    public string Namespace { get { return default(string); } set { } }
  }
  public abstract partial class DataContractResolver {
    protected DataContractResolver() { }
    public abstract System.Type ResolveName(string typeName, string typeNamespace, System.Type declaredType, System.Runtime.Serialization.DataContractResolver knownTypeResolver);
    public abstract bool TryResolveType(System.Type type, System.Type declaredType, System.Runtime.Serialization.DataContractResolver knownTypeResolver, out System.Xml.XmlDictionaryString typeName, out System.Xml.XmlDictionaryString typeNamespace);
  }
  public sealed partial class DataContractSerializer : System.Runtime.Serialization.XmlObjectSerializer {
    public DataContractSerializer(System.Type type) { }
    public DataContractSerializer(System.Type type, System.Collections.Generic.IEnumerable<System.Type> knownTypes) { }
    public DataContractSerializer(System.Type type, System.Collections.Generic.IEnumerable<System.Type> knownTypes, int maxObjectsInGraph, bool ignoreExtensionDataObject, bool preserveObjectReferences, System.Runtime.Serialization.IDataContractSurrogate dataContractSurrogate) { }
    public DataContractSerializer(System.Type type, System.Collections.Generic.IEnumerable<System.Type> knownTypes, int maxObjectsInGraph, bool ignoreExtensionDataObject, bool preserveObjectReferences, System.Runtime.Serialization.IDataContractSurrogate dataContractSurrogate, System.Runtime.Serialization.DataContractResolver dataContractResolver) { }
    public DataContractSerializer(System.Type type, string rootName, string rootNamespace) { }
    public DataContractSerializer(System.Type type, string rootName, string rootNamespace, System.Collections.Generic.IEnumerable<System.Type> knownTypes) { }
    public DataContractSerializer(System.Type type, string rootName, string rootNamespace, System.Collections.Generic.IEnumerable<System.Type> knownTypes, int maxObjectsInGraph, bool ignoreExtensionDataObject, bool preserveObjectReferences, System.Runtime.Serialization.IDataContractSurrogate dataContractSurrogate) { }
    public DataContractSerializer(System.Type type, string rootName, string rootNamespace, System.Collections.Generic.IEnumerable<System.Type> knownTypes, int maxObjectsInGraph, bool ignoreExtensionDataObject, bool preserveObjectReferences, System.Runtime.Serialization.IDataContractSurrogate dataContractSurrogate, System.Runtime.Serialization.DataContractResolver dataContractResolver) { }
    public DataContractSerializer(System.Type type, System.Xml.XmlDictionaryString rootName, System.Xml.XmlDictionaryString rootNamespace) { }
    public DataContractSerializer(System.Type type, System.Xml.XmlDictionaryString rootName, System.Xml.XmlDictionaryString rootNamespace, System.Collections.Generic.IEnumerable<System.Type> knownTypes) { }
    public DataContractSerializer(System.Type type, System.Xml.XmlDictionaryString rootName, System.Xml.XmlDictionaryString rootNamespace, System.Collections.Generic.IEnumerable<System.Type> knownTypes, int maxObjectsInGraph, bool ignoreExtensionDataObject, bool preserveObjectReferences, System.Runtime.Serialization.IDataContractSurrogate dataContractSurrogate) { }
    public DataContractSerializer(System.Type type, System.Xml.XmlDictionaryString rootName, System.Xml.XmlDictionaryString rootNamespace, System.Collections.Generic.IEnumerable<System.Type> knownTypes, int maxObjectsInGraph, bool ignoreExtensionDataObject, bool preserveObjectReferences, System.Runtime.Serialization.IDataContractSurrogate dataContractSurrogate, System.Runtime.Serialization.DataContractResolver dataContractResolver) { }
    public System.Runtime.Serialization.DataContractResolver DataContractResolver { get { return default(System.Runtime.Serialization.DataContractResolver); } }
    public System.Runtime.Serialization.IDataContractSurrogate DataContractSurrogate { get { return default(System.Runtime.Serialization.IDataContractSurrogate); } }
    public bool IgnoreExtensionDataObject { get { return default(bool); } }
    public System.Collections.ObjectModel.ReadOnlyCollection<System.Type> KnownTypes { get { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.Type>); } }
    public int MaxItemsInObjectGraph { get { return default(int); } }
    public bool PreserveObjectReferences { get { return default(bool); } }
    public override bool IsStartObject(System.Xml.XmlDictionaryReader reader) { return default(bool); }
    public override bool IsStartObject(System.Xml.XmlReader reader) { return default(bool); }
    public override object ReadObject(System.Xml.XmlDictionaryReader reader, bool verifyObjectName) { return default(object); }
    public object ReadObject(System.Xml.XmlDictionaryReader reader, bool verifyObjectName, System.Runtime.Serialization.DataContractResolver resolver) { return default(object); }
    public override object ReadObject(System.Xml.XmlReader reader) { return default(object); }
    public override object ReadObject(System.Xml.XmlReader reader, bool verifyObjectName) { return default(object); }
    public override void WriteEndObject(System.Xml.XmlDictionaryWriter writer) { }
    public override void WriteEndObject(System.Xml.XmlWriter writer) { }
    public void WriteObject(System.Xml.XmlDictionaryWriter writer, object graph, System.Runtime.Serialization.DataContractResolver resolver) { }
    public override void WriteObject(System.Xml.XmlWriter writer, object graph) { }
    [System.MonoTODOAttribute("use DataContractSurrogate")]
    public override void WriteObjectContent(System.Xml.XmlDictionaryWriter writer, object graph) { }
    public override void WriteObjectContent(System.Xml.XmlWriter writer, object graph) { }
    public override void WriteStartObject(System.Xml.XmlDictionaryWriter writer, object graph) { }
    public override void WriteStartObject(System.Xml.XmlWriter writer, object graph) { }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(384), Inherited=false, AllowMultiple=false)]
  public sealed partial class DataMemberAttribute : System.Attribute {
    public DataMemberAttribute() { }
    public bool EmitDefaultValue { get { return default(bool); } set { } }
    public bool IsRequired { get { return default(bool); } set { } }
    public string Name { get { return default(string); } set { } }
    public int Order { get { return default(int); } set { } }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(256), Inherited=false, AllowMultiple=false)]
  public sealed partial class EnumMemberAttribute : System.Attribute {
    public EnumMemberAttribute() { }
    public string Value { get { return default(string); } set { } }
  }
  public partial class ExportOptions {
    public ExportOptions() { }
    public System.Runtime.Serialization.IDataContractSurrogate DataContractSurrogate { get { return default(System.Runtime.Serialization.IDataContractSurrogate); } set { } }
    [System.MonoTODOAttribute]
    public System.Collections.ObjectModel.Collection<System.Type> KnownTypes { get { return default(System.Collections.ObjectModel.Collection<System.Type>); } }
  }
  public sealed partial class ExtensionDataObject {
    internal ExtensionDataObject() { }
  }
  public partial interface IDataContractSurrogate {
    object GetCustomDataToExport(System.Reflection.MemberInfo memberInfo, System.Type dataContractType);
    object GetCustomDataToExport(System.Type clrType, System.Type dataContractType);
    System.Type GetDataContractType(System.Type type);
    object GetDeserializedObject(object obj, System.Type targetType);
    void GetKnownCustomDataTypes(System.Collections.ObjectModel.Collection<System.Type> customDataTypes);
    object GetObjectToSerialize(object obj, System.Type targetType);
    System.Type GetReferencedTypeOnImport(string typeName, string typeNamespace, object customData);
    System.CodeDom.CodeTypeDeclaration ProcessImportedType(System.CodeDom.CodeTypeDeclaration typeDeclaration, System.CodeDom.CodeCompileUnit compileUnit);
  }
  public partial interface IExtensibleDataObject {
    System.Runtime.Serialization.ExtensionDataObject ExtensionData { get; set; }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(384), Inherited=false, AllowMultiple=false)]
  public sealed partial class IgnoreDataMemberAttribute : System.Attribute {
    public IgnoreDataMemberAttribute() { }
  }
  public partial class ImportOptions {
    public ImportOptions() { }
    public System.CodeDom.Compiler.CodeDomProvider CodeProvider { get { return default(System.CodeDom.Compiler.CodeDomProvider); } set { } }
    [System.MonoTODOAttribute]
    public System.Runtime.Serialization.IDataContractSurrogate DataContractSurrogate { get { return default(System.Runtime.Serialization.IDataContractSurrogate); } set { } }
    [System.MonoTODOAttribute]
    public bool EnableDataBinding { get { return default(bool); } set { } }
    public bool GenerateInternal { get { return default(bool); } set { } }
    public bool GenerateSerializable { get { return default(bool); } set { } }
    [System.MonoTODOAttribute]
    public bool ImportXmlType { get { return default(bool); } set { } }
    public System.Collections.Generic.IDictionary<System.String, System.String> Namespaces { get { return default(System.Collections.Generic.IDictionary<System.String, System.String>); } }
    [System.MonoTODOAttribute]
    public System.Collections.Generic.ICollection<System.Type> ReferencedCollectionTypes { get { return default(System.Collections.Generic.ICollection<System.Type>); } }
    [System.MonoTODOAttribute]
    public System.Collections.Generic.ICollection<System.Type> ReferencedTypes { get { return default(System.Collections.Generic.ICollection<System.Type>); } }
  }
  public partial class InvalidDataContractException : System.Exception {
    public InvalidDataContractException() { }
    protected InvalidDataContractException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public InvalidDataContractException(string message) { }
    public InvalidDataContractException(string message, System.Exception innerException) { }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(12), Inherited=true, AllowMultiple=true)]
  public sealed partial class KnownTypeAttribute : System.Attribute {
    public KnownTypeAttribute(string methodName) { }
    public KnownTypeAttribute(System.Type type) { }
    public string MethodName { get { return default(string); } }
    public System.Type Type { get { return default(System.Type); } }
  }
  public sealed partial class NetDataContractSerializer : System.Runtime.Serialization.XmlObjectSerializer, System.Runtime.Serialization.IFormatter {
    public NetDataContractSerializer() { }
    public NetDataContractSerializer(System.Runtime.Serialization.StreamingContext context) { }
    public NetDataContractSerializer(System.Runtime.Serialization.StreamingContext context, int maxItemsInObjectGraph, bool ignoreExtensibleDataObject, System.Runtime.Serialization.Formatters.FormatterAssemblyStyle assemblyFormat, System.Runtime.Serialization.ISurrogateSelector surrogateSelector) { }
    public NetDataContractSerializer(string rootName, string rootNamespace) { }
    public NetDataContractSerializer(string rootName, string rootNamespace, System.Runtime.Serialization.StreamingContext context, int maxItemsInObjectGraph, bool ignoreExtensibleDataObject, System.Runtime.Serialization.Formatters.FormatterAssemblyStyle assemblyFormat, System.Runtime.Serialization.ISurrogateSelector surrogateSelector) { }
    public NetDataContractSerializer(System.Xml.XmlDictionaryString rootName, System.Xml.XmlDictionaryString rootNamespace) { }
    public NetDataContractSerializer(System.Xml.XmlDictionaryString rootName, System.Xml.XmlDictionaryString rootNamespace, System.Runtime.Serialization.StreamingContext context, int maxItemsInObjectGraph, bool ignoreExtensibleDataObject, System.Runtime.Serialization.Formatters.FormatterAssemblyStyle assemblyFormat, System.Runtime.Serialization.ISurrogateSelector surrogateSelector) { }
    public System.Runtime.Serialization.Formatters.FormatterAssemblyStyle AssemblyFormat { get { return default(System.Runtime.Serialization.Formatters.FormatterAssemblyStyle); } set { } }
    public System.Runtime.Serialization.SerializationBinder Binder { get { return default(System.Runtime.Serialization.SerializationBinder); } set { } }
    public System.Runtime.Serialization.StreamingContext Context { get { return default(System.Runtime.Serialization.StreamingContext); } set { } }
    public bool IgnoreExtensionDataObject { get { return default(bool); } }
    public int MaxItemsInObjectGraph { get { return default(int); } }
    public System.Runtime.Serialization.ISurrogateSelector SurrogateSelector { get { return default(System.Runtime.Serialization.ISurrogateSelector); } set { } }
    public object Deserialize(System.IO.Stream stream) { return default(object); }
    [System.MonoTODOAttribute]
    public override bool IsStartObject(System.Xml.XmlDictionaryReader reader) { return default(bool); }
    public override object ReadObject(System.Xml.XmlDictionaryReader reader, bool readContentOnly) { return default(object); }
    public void Serialize(System.IO.Stream stream, object graph) { }
    public override void WriteEndObject(System.Xml.XmlDictionaryWriter writer) { }
    [System.MonoTODOAttribute("support arrays; support Serializable; support SharedType; use DataContractSurrogate")]
    public override void WriteObjectContent(System.Xml.XmlDictionaryWriter writer, object graph) { }
    public override void WriteStartObject(System.Xml.XmlDictionaryWriter writer, object graph) { }
  }
  public abstract partial class XmlObjectSerializer {
    protected XmlObjectSerializer() { }
    public abstract bool IsStartObject(System.Xml.XmlDictionaryReader reader);
    public virtual bool IsStartObject(System.Xml.XmlReader reader) { return default(bool); }
    public virtual object ReadObject(System.IO.Stream stream) { return default(object); }
    public virtual object ReadObject(System.Xml.XmlDictionaryReader reader) { return default(object); }
    [System.MonoTODOAttribute]
    public abstract object ReadObject(System.Xml.XmlDictionaryReader reader, bool readContentOnly);
    public virtual object ReadObject(System.Xml.XmlReader reader) { return default(object); }
    public virtual object ReadObject(System.Xml.XmlReader reader, bool readContentOnly) { return default(object); }
    public abstract void WriteEndObject(System.Xml.XmlDictionaryWriter writer);
    public virtual void WriteEndObject(System.Xml.XmlWriter writer) { }
    public virtual void WriteObject(System.IO.Stream stream, object graph) { }
    public virtual void WriteObject(System.Xml.XmlDictionaryWriter writer, object graph) { }
    public virtual void WriteObject(System.Xml.XmlWriter writer, object graph) { }
    public abstract void WriteObjectContent(System.Xml.XmlDictionaryWriter writer, object graph);
    public virtual void WriteObjectContent(System.Xml.XmlWriter writer, object graph) { }
    public abstract void WriteStartObject(System.Xml.XmlDictionaryWriter writer, object graph);
    public virtual void WriteStartObject(System.Xml.XmlWriter writer, object graph) { }
  }
  public static partial class XmlSerializableServices {
    [System.MonoTODOAttribute]
    public static void AddDefaultSchema(System.Xml.Schema.XmlSchemaSet schemas, System.Xml.XmlQualifiedName typeQName) { }
    public static System.Xml.XmlNode[] ReadNodes(System.Xml.XmlReader xmlReader) { return default(System.Xml.XmlNode[]); }
    public static void WriteNodes(System.Xml.XmlWriter xmlWriter, System.Xml.XmlNode[] nodes) { }
  }
  public partial class XsdDataContractExporter {
    public XsdDataContractExporter() { }
    public XsdDataContractExporter(System.Xml.Schema.XmlSchemaSet schemas) { }
    public System.Runtime.Serialization.ExportOptions Options { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Runtime.Serialization.ExportOptions); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Xml.Schema.XmlSchemaSet Schemas { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Xml.Schema.XmlSchemaSet); } }
    public bool CanExport(System.Collections.Generic.ICollection<System.Reflection.Assembly> assemblies) { return default(bool); }
    public bool CanExport(System.Collections.Generic.ICollection<System.Type> types) { return default(bool); }
    public bool CanExport(System.Type type) { return default(bool); }
    public void Export(System.Collections.Generic.ICollection<System.Reflection.Assembly> assemblies) { }
    public void Export(System.Collections.Generic.ICollection<System.Type> types) { }
    public void Export(System.Type type) { }
    public System.Xml.XmlQualifiedName GetRootElementName(System.Type type) { return default(System.Xml.XmlQualifiedName); }
    public System.Xml.Schema.XmlSchemaType GetSchemaType(System.Type type) { return default(System.Xml.Schema.XmlSchemaType); }
    public System.Xml.XmlQualifiedName GetSchemaTypeName(System.Type type) { return default(System.Xml.XmlQualifiedName); }
  }
  [System.MonoTODOAttribute("support arrays")]
  public partial class XsdDataContractImporter {
    public XsdDataContractImporter() { }
    public XsdDataContractImporter(System.CodeDom.CodeCompileUnit codeCompileUnit) { }
    public System.CodeDom.CodeCompileUnit CodeCompileUnit { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.CodeDom.CodeCompileUnit); } }
    public System.Runtime.Serialization.ImportOptions Options { get { return default(System.Runtime.Serialization.ImportOptions); } set { } }
    public bool CanImport(System.Xml.Schema.XmlSchemaSet schemas) { return default(bool); }
    public bool CanImport(System.Xml.Schema.XmlSchemaSet schemas, System.Collections.Generic.ICollection<System.Xml.XmlQualifiedName> typeNames) { return default(bool); }
    public bool CanImport(System.Xml.Schema.XmlSchemaSet schemas, System.Xml.Schema.XmlSchemaElement element) { return default(bool); }
    public bool CanImport(System.Xml.Schema.XmlSchemaSet schemas, System.Xml.XmlQualifiedName typeName) { return default(bool); }
    public System.CodeDom.CodeTypeReference GetCodeTypeReference(System.Xml.XmlQualifiedName typeName) { return default(System.CodeDom.CodeTypeReference); }
    [System.MonoTODOAttribute("use element argument and fill Nullable etc.")]
    public System.CodeDom.CodeTypeReference GetCodeTypeReference(System.Xml.XmlQualifiedName typeName, System.Xml.Schema.XmlSchemaElement element) { return default(System.CodeDom.CodeTypeReference); }
    public System.Collections.Generic.ICollection<System.CodeDom.CodeTypeReference> GetKnownTypeReferences(System.Xml.XmlQualifiedName typeName) { return default(System.Collections.Generic.ICollection<System.CodeDom.CodeTypeReference>); }
    public void Import(System.Xml.Schema.XmlSchemaSet schemas) { }
    public void Import(System.Xml.Schema.XmlSchemaSet schemas, System.Collections.Generic.ICollection<System.Xml.XmlQualifiedName> typeNames) { }
    public System.Xml.XmlQualifiedName Import(System.Xml.Schema.XmlSchemaSet schemas, System.Xml.Schema.XmlSchemaElement element) { return default(System.Xml.XmlQualifiedName); }
    public void Import(System.Xml.Schema.XmlSchemaSet schemas, System.Xml.XmlQualifiedName typeName) { }
  }
}
namespace System.Runtime.Serialization.Configuration {
  public sealed partial class DataContractSerializerSection : System.Configuration.ConfigurationSection {
    public DataContractSerializerSection() { }
    [System.Configuration.ConfigurationPropertyAttribute("declaredTypes", DefaultValue=null)]
    public System.Runtime.Serialization.Configuration.DeclaredTypeElementCollection DeclaredTypes { get { return default(System.Runtime.Serialization.Configuration.DeclaredTypeElementCollection); } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
  }
  [System.MonoTODOAttribute]
  public sealed partial class DeclaredTypeElement : System.Configuration.ConfigurationElement {
    public DeclaredTypeElement() { }
    public DeclaredTypeElement(string typeName) { }
    [System.Configuration.ConfigurationPropertyAttribute("", DefaultValue=null, Options=(System.Configuration.ConfigurationPropertyOptions)(1))]
    public System.Runtime.Serialization.Configuration.TypeElementCollection KnownTypes { get { return default(System.Runtime.Serialization.Configuration.TypeElementCollection); } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
    [System.Configuration.ConfigurationPropertyAttribute("type", DefaultValue="", Options=(System.Configuration.ConfigurationPropertyOptions)(4))]
    public string Type { get { return default(string); } set { } }
    protected override void PostDeserialize() { }
  }
  [System.Configuration.ConfigurationCollectionAttribute(typeof(System.Runtime.Serialization.Configuration.DeclaredTypeElement))]
  public sealed partial class DeclaredTypeElementCollection : System.Configuration.ConfigurationElementCollection {
    public DeclaredTypeElementCollection() { }
    public System.Runtime.Serialization.Configuration.DeclaredTypeElement this[int index] { get { return default(System.Runtime.Serialization.Configuration.DeclaredTypeElement); } set { } }
    public new System.Runtime.Serialization.Configuration.DeclaredTypeElement this[string typeName] { get { return default(System.Runtime.Serialization.Configuration.DeclaredTypeElement); } set { } }
    public void Add(System.Runtime.Serialization.Configuration.DeclaredTypeElement element) { }
    public void Clear() { }
    public bool Contains(string typeName) { return default(bool); }
    protected override System.Configuration.ConfigurationElement CreateNewElement() { return default(System.Configuration.ConfigurationElement); }
    protected override object GetElementKey(System.Configuration.ConfigurationElement element) { return default(object); }
    public int IndexOf(System.Runtime.Serialization.Configuration.DeclaredTypeElement element) { return default(int); }
    public void Remove(System.Runtime.Serialization.Configuration.DeclaredTypeElement element) { }
    public void Remove(string typeName) { }
    public void RemoveAt(int index) { }
  }
  public sealed partial class ParameterElement : System.Configuration.ConfigurationElement {
    public ParameterElement() { }
    public ParameterElement(int index) { }
    public ParameterElement(string typeName) { }
    [System.Configuration.ConfigurationPropertyAttribute("index", DefaultValue=0)]
    [System.Configuration.IntegerValidatorAttribute(MinValue=0)]
    public int Index { get { return default(int); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("", DefaultValue=null, Options=(System.Configuration.ConfigurationPropertyOptions)(1))]
    public System.Runtime.Serialization.Configuration.ParameterElementCollection Parameters { get { return default(System.Runtime.Serialization.Configuration.ParameterElementCollection); } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
    [System.Configuration.ConfigurationPropertyAttribute("type", DefaultValue="")]
    [System.Configuration.StringValidatorAttribute(MinLength=0)]
    public string Type { get { return default(string); } set { } }
    protected override void PostDeserialize() { }
    protected override void PreSerialize(System.Xml.XmlWriter writer) { }
  }
  [System.Configuration.ConfigurationCollectionAttribute(typeof(System.Runtime.Serialization.Configuration.ParameterElement), AddItemName="parameter", CollectionType=(System.Configuration.ConfigurationElementCollectionType)(0))]
  public sealed partial class ParameterElementCollection : System.Configuration.ConfigurationElementCollection {
    public ParameterElementCollection() { }
    public override System.Configuration.ConfigurationElementCollectionType CollectionType { get { return default(System.Configuration.ConfigurationElementCollectionType); } }
    protected override string ElementName { get { return default(string); } }
    public System.Runtime.Serialization.Configuration.ParameterElement this[int index] { get { return default(System.Runtime.Serialization.Configuration.ParameterElement); } set { } }
    public void Add(System.Runtime.Serialization.Configuration.ParameterElement element) { }
    public void Clear() { }
    public bool Contains(string typeName) { return default(bool); }
    protected override System.Configuration.ConfigurationElement CreateNewElement() { return default(System.Configuration.ConfigurationElement); }
    protected override object GetElementKey(System.Configuration.ConfigurationElement element) { return default(object); }
    public int IndexOf(System.Runtime.Serialization.Configuration.ParameterElement element) { return default(int); }
    public void Remove(System.Runtime.Serialization.Configuration.ParameterElement element) { }
    public void RemoveAt(int index) { }
  }
  public sealed partial class SerializationSectionGroup : System.Configuration.ConfigurationSectionGroup {
    public SerializationSectionGroup() { }
    public System.Runtime.Serialization.Configuration.DataContractSerializerSection DataContractSerializer { get { return default(System.Runtime.Serialization.Configuration.DataContractSerializerSection); } }
    public static System.Runtime.Serialization.Configuration.SerializationSectionGroup GetSectionGroup(System.Configuration.Configuration config) { return default(System.Runtime.Serialization.Configuration.SerializationSectionGroup); }
  }
  public sealed partial class TypeElement : System.Configuration.ConfigurationElement {
    public TypeElement() { }
    public TypeElement(string typeName) { }
    [System.Configuration.ConfigurationPropertyAttribute("index", DefaultValue=0)]
    [System.Configuration.IntegerValidatorAttribute(MinValue=0)]
    public int Index { get { return default(int); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("", DefaultValue=null, Options=(System.Configuration.ConfigurationPropertyOptions)(1))]
    public System.Runtime.Serialization.Configuration.ParameterElementCollection Parameters { get { return default(System.Runtime.Serialization.Configuration.ParameterElementCollection); } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
    [System.Configuration.ConfigurationPropertyAttribute("type", DefaultValue="")]
    [System.Configuration.StringValidatorAttribute(MinLength=0)]
    public string Type { get { return default(string); } set { } }
    protected override void Reset(System.Configuration.ConfigurationElement parentElement) { }
  }
  [System.Configuration.ConfigurationCollectionAttribute(typeof(System.Runtime.Serialization.Configuration.TypeElement), CollectionType=(System.Configuration.ConfigurationElementCollectionType)(0))]
  public sealed partial class TypeElementCollection : System.Configuration.ConfigurationElementCollection {
    public TypeElementCollection() { }
    public override System.Configuration.ConfigurationElementCollectionType CollectionType { get { return default(System.Configuration.ConfigurationElementCollectionType); } }
    protected override string ElementName { get { return default(string); } }
    public System.Runtime.Serialization.Configuration.TypeElement this[int index] { get { return default(System.Runtime.Serialization.Configuration.TypeElement); } set { } }
    public void Add(System.Runtime.Serialization.Configuration.TypeElement element) { }
    public void Clear() { }
    protected override System.Configuration.ConfigurationElement CreateNewElement() { return default(System.Configuration.ConfigurationElement); }
    protected override object GetElementKey(System.Configuration.ConfigurationElement element) { return default(object); }
    public int IndexOf(System.Runtime.Serialization.Configuration.TypeElement element) { return default(int); }
    public void Remove(System.Runtime.Serialization.Configuration.TypeElement element) { }
    public void RemoveAt(int index) { }
  }
}
namespace System.Runtime.Serialization.Json {
  public sealed partial class DataContractJsonSerializer : System.Runtime.Serialization.XmlObjectSerializer {
    public DataContractJsonSerializer(System.Type type) { }
    public DataContractJsonSerializer(System.Type type, System.Collections.Generic.IEnumerable<System.Type> knownTypes) { }
    public DataContractJsonSerializer(System.Type type, System.Collections.Generic.IEnumerable<System.Type> knownTypes, int maxItemsInObjectGraph, bool ignoreExtensionDataObject, System.Runtime.Serialization.IDataContractSurrogate dataContractSurrogate, bool alwaysEmitTypeInformation) { }
    public DataContractJsonSerializer(System.Type type, string rootName) { }
    public DataContractJsonSerializer(System.Type type, string rootName, System.Collections.Generic.IEnumerable<System.Type> knownTypes) { }
    public DataContractJsonSerializer(System.Type type, string rootName, System.Collections.Generic.IEnumerable<System.Type> knownTypes, int maxItemsInObjectGraph, bool ignoreExtensionDataObject, System.Runtime.Serialization.IDataContractSurrogate dataContractSurrogate, bool alwaysEmitTypeInformation) { }
    public DataContractJsonSerializer(System.Type type, System.Xml.XmlDictionaryString rootName) { }
    public DataContractJsonSerializer(System.Type type, System.Xml.XmlDictionaryString rootName, System.Collections.Generic.IEnumerable<System.Type> knownTypes) { }
    public DataContractJsonSerializer(System.Type type, System.Xml.XmlDictionaryString rootName, System.Collections.Generic.IEnumerable<System.Type> knownTypes, int maxItemsInObjectGraph, bool ignoreExtensionDataObject, System.Runtime.Serialization.IDataContractSurrogate dataContractSurrogate, bool alwaysEmitTypeInformation) { }
    [System.MonoTODOAttribute]
    public System.Runtime.Serialization.IDataContractSurrogate DataContractSurrogate { get { return default(System.Runtime.Serialization.IDataContractSurrogate); } }
    [System.MonoTODOAttribute]
    public bool IgnoreExtensionDataObject { get { return default(bool); } }
    [System.MonoTODOAttribute]
    public System.Collections.ObjectModel.ReadOnlyCollection<System.Type> KnownTypes { get { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.Type>); } }
    public int MaxItemsInObjectGraph { get { return default(int); } }
    public override bool IsStartObject(System.Xml.XmlDictionaryReader reader) { return default(bool); }
    public override bool IsStartObject(System.Xml.XmlReader reader) { return default(bool); }
    public override object ReadObject(System.IO.Stream stream) { return default(object); }
    public override object ReadObject(System.Xml.XmlDictionaryReader reader) { return default(object); }
    public override object ReadObject(System.Xml.XmlDictionaryReader reader, bool verifyObjectName) { return default(object); }
    public override object ReadObject(System.Xml.XmlReader reader) { return default(object); }
    public override object ReadObject(System.Xml.XmlReader reader, bool verifyObjectName) { return default(object); }
    public override void WriteEndObject(System.Xml.XmlDictionaryWriter writer) { }
    public override void WriteEndObject(System.Xml.XmlWriter writer) { }
    public override void WriteObject(System.IO.Stream stream, object graph) { }
    public override void WriteObject(System.Xml.XmlDictionaryWriter writer, object graph) { }
    public override void WriteObject(System.Xml.XmlWriter writer, object graph) { }
    public override void WriteObjectContent(System.Xml.XmlDictionaryWriter writer, object graph) { }
    public override void WriteObjectContent(System.Xml.XmlWriter writer, object graph) { }
    public override void WriteStartObject(System.Xml.XmlDictionaryWriter writer, object graph) { }
    public override void WriteStartObject(System.Xml.XmlWriter writer, object graph) { }
  }
  public partial interface IXmlJsonReaderInitializer {
    void SetInput(System.Byte[] buffer, int offset, int count, System.Text.Encoding encoding, System.Xml.XmlDictionaryReaderQuotas quotas, System.Xml.OnXmlDictionaryReaderClose onClose);
    void SetInput(System.IO.Stream stream, System.Text.Encoding encoding, System.Xml.XmlDictionaryReaderQuotas quotas, System.Xml.OnXmlDictionaryReaderClose onClose);
  }
  public partial interface IXmlJsonWriterInitializer {
    void SetOutput(System.IO.Stream stream, System.Text.Encoding encoding, bool ownsStream);
  }
  public static partial class JsonReaderWriterFactory {
    public static System.Xml.XmlDictionaryReader CreateJsonReader(System.Byte[] buffer, int offset, int count, System.Text.Encoding encoding, System.Xml.XmlDictionaryReaderQuotas quotas, System.Xml.OnXmlDictionaryReaderClose onClose) { return default(System.Xml.XmlDictionaryReader); }
    public static System.Xml.XmlDictionaryReader CreateJsonReader(System.Byte[] buffer, int offset, int count, System.Xml.XmlDictionaryReaderQuotas quotas) { return default(System.Xml.XmlDictionaryReader); }
    public static System.Xml.XmlDictionaryReader CreateJsonReader(System.Byte[] buffer, System.Xml.XmlDictionaryReaderQuotas quotas) { return default(System.Xml.XmlDictionaryReader); }
    public static System.Xml.XmlDictionaryReader CreateJsonReader(System.IO.Stream stream, System.Text.Encoding encoding, System.Xml.XmlDictionaryReaderQuotas quotas, System.Xml.OnXmlDictionaryReaderClose onClose) { return default(System.Xml.XmlDictionaryReader); }
    public static System.Xml.XmlDictionaryReader CreateJsonReader(System.IO.Stream stream, System.Xml.XmlDictionaryReaderQuotas quotas) { return default(System.Xml.XmlDictionaryReader); }
    public static System.Xml.XmlDictionaryWriter CreateJsonWriter(System.IO.Stream stream) { return default(System.Xml.XmlDictionaryWriter); }
    public static System.Xml.XmlDictionaryWriter CreateJsonWriter(System.IO.Stream stream, System.Text.Encoding encoding) { return default(System.Xml.XmlDictionaryWriter); }
    public static System.Xml.XmlDictionaryWriter CreateJsonWriter(System.IO.Stream stream, System.Text.Encoding encoding, bool ownsStream) { return default(System.Xml.XmlDictionaryWriter); }
  }
}
namespace System.Xml {
  public partial interface IFragmentCapableXmlDictionaryWriter {
    bool CanFragment { get; }
    void EndFragment();
    void StartFragment(System.IO.Stream stream, bool generateSelfContainedTextFragment);
    void WriteFragment(System.Byte[] buffer, int offset, int count);
  }
  public partial interface IStreamProvider {
    System.IO.Stream GetStream();
    void ReleaseStream(System.IO.Stream stream);
  }
  public partial interface IXmlBinaryReaderInitializer {
    void SetInput(System.Byte[] buffer, int offset, int count, System.Xml.IXmlDictionary dictionary, System.Xml.XmlDictionaryReaderQuotas quota, System.Xml.XmlBinaryReaderSession session, System.Xml.OnXmlDictionaryReaderClose onClose);
    void SetInput(System.IO.Stream stream, System.Xml.IXmlDictionary dictionary, System.Xml.XmlDictionaryReaderQuotas quota, System.Xml.XmlBinaryReaderSession session, System.Xml.OnXmlDictionaryReaderClose onClose);
  }
  public partial interface IXmlBinaryWriterInitializer {
    void SetOutput(System.IO.Stream stream, System.Xml.IXmlDictionary dictionary, System.Xml.XmlBinaryWriterSession session, bool ownsStream);
  }
  public partial interface IXmlDictionary {
    bool TryLookup(int key, out System.Xml.XmlDictionaryString result);
    bool TryLookup(string value, out System.Xml.XmlDictionaryString result);
    bool TryLookup(System.Xml.XmlDictionaryString value, out System.Xml.XmlDictionaryString result);
  }
  public partial interface IXmlMtomReaderInitializer {
    void SetInput(System.Byte[] buffer, int offset, int count, System.Text.Encoding[] encodings, string contentType, System.Xml.XmlDictionaryReaderQuotas quotas, int maxBufferSize, System.Xml.OnXmlDictionaryReaderClose onClose);
    void SetInput(System.IO.Stream stream, System.Text.Encoding[] encodings, string contentType, System.Xml.XmlDictionaryReaderQuotas quotas, int maxBufferSize, System.Xml.OnXmlDictionaryReaderClose onClose);
  }
  public partial interface IXmlMtomWriterInitializer {
    void SetOutput(System.IO.Stream stream, System.Text.Encoding encoding, int maxSizeInBytes, string startInfo, string boundary, string startUri, bool writeMessageHeaders, bool ownsStream);
  }
  public partial interface IXmlTextReaderInitializer {
    void SetInput(System.Byte[] buffer, int offset, int count, System.Text.Encoding encoding, System.Xml.XmlDictionaryReaderQuotas quota, System.Xml.OnXmlDictionaryReaderClose onClose);
    void SetInput(System.IO.Stream stream, System.Text.Encoding encoding, System.Xml.XmlDictionaryReaderQuotas quota, System.Xml.OnXmlDictionaryReaderClose onClose);
  }
  public partial interface IXmlTextWriterInitializer {
    void SetOutput(System.IO.Stream stream, System.Text.Encoding encoding, bool ownsStream);
  }
  public delegate void OnXmlDictionaryReaderClose(System.Xml.XmlDictionaryReader reader);
  public partial class UniqueId {
    public UniqueId() { }
    public UniqueId(System.Byte[] id) { }
    [System.Security.SecurityCriticalAttribute]
    [System.Security.SecurityTreatAsSafeAttribute]
    public UniqueId(System.Byte[] id, int offset) { }
    [System.Security.SecurityCriticalAttribute]
    [System.Security.SecurityTreatAsSafeAttribute]
    public UniqueId(System.Char[] id, int offset, int count) { }
    public UniqueId(System.Guid id) { }
    [System.Security.SecurityCriticalAttribute]
    [System.Security.SecurityTreatAsSafeAttribute]
    public UniqueId(string value) { }
    public int CharArrayLength { [System.Security.SecurityCriticalAttribute, System.Security.SecurityTreatAsSafeAttribute]get { return default(int); } }
    public bool IsGuid { get { return default(bool); } }
    public override bool Equals(object obj) { return default(bool); }
    [System.MonoTODOAttribute("Determine semantics when IsGuid==true")]
    public override int GetHashCode() { return default(int); }
    public static bool operator ==(System.Xml.UniqueId id1, System.Xml.UniqueId id2) { return default(bool); }
    public static bool operator !=(System.Xml.UniqueId id1, System.Xml.UniqueId id2) { return default(bool); }
    [System.Security.SecurityCriticalAttribute]
    [System.Security.SecurityTreatAsSafeAttribute]
    public int ToCharArray(System.Char[] array, int offset) { return default(int); }
    [System.Security.SecurityCriticalAttribute]
    [System.Security.SecurityTreatAsSafeAttribute]
    public override string ToString() { return default(string); }
    [System.Security.SecurityCriticalAttribute]
    [System.Security.SecurityTreatAsSafeAttribute]
    public bool TryGetGuid(System.Byte[] buffer, int offset) { return default(bool); }
    public bool TryGetGuid(out System.Guid guid) { guid = default(System.Guid); return default(bool); }
  }
  public partial class XmlBinaryReaderSession : System.Xml.IXmlDictionary {
    public XmlBinaryReaderSession() { }
    public System.Xml.XmlDictionaryString Add(int id, string value) { return default(System.Xml.XmlDictionaryString); }
    public void Clear() { }
    public bool TryLookup(int key, out System.Xml.XmlDictionaryString result) { result = default(System.Xml.XmlDictionaryString); return default(bool); }
    public bool TryLookup(string value, out System.Xml.XmlDictionaryString result) { result = default(System.Xml.XmlDictionaryString); return default(bool); }
    public bool TryLookup(System.Xml.XmlDictionaryString value, out System.Xml.XmlDictionaryString result) { result = default(System.Xml.XmlDictionaryString); return default(bool); }
  }
  public partial class XmlBinaryWriterSession {
    public XmlBinaryWriterSession() { }
    public void Reset() { }
    public virtual bool TryAdd(System.Xml.XmlDictionaryString value, out int key) { key = default(int); return default(bool); }
  }
  public partial class XmlDictionary : System.Xml.IXmlDictionary {
    public XmlDictionary() { }
    public XmlDictionary(int capacity) { }
    public static System.Xml.IXmlDictionary Empty { get { return default(System.Xml.IXmlDictionary); } }
    public virtual System.Xml.XmlDictionaryString Add(string value) { return default(System.Xml.XmlDictionaryString); }
    public virtual bool TryLookup(int key, out System.Xml.XmlDictionaryString result) { result = default(System.Xml.XmlDictionaryString); return default(bool); }
    public virtual bool TryLookup(string value, out System.Xml.XmlDictionaryString result) { result = default(System.Xml.XmlDictionaryString); return default(bool); }
    public virtual bool TryLookup(System.Xml.XmlDictionaryString value, out System.Xml.XmlDictionaryString result) { result = default(System.Xml.XmlDictionaryString); return default(bool); }
  }
  public abstract partial class XmlDictionaryReader : System.Xml.XmlReader {
    protected XmlDictionaryReader() { }
    public virtual bool CanCanonicalize { get { return default(bool); } }
    public virtual System.Xml.XmlDictionaryReaderQuotas Quotas { get { return default(System.Xml.XmlDictionaryReaderQuotas); } }
    public static System.Xml.XmlDictionaryReader CreateBinaryReader(System.Byte[] buffer, int offset, int count, System.Xml.IXmlDictionary dictionary, System.Xml.XmlDictionaryReaderQuotas quotas) { return default(System.Xml.XmlDictionaryReader); }
    public static System.Xml.XmlDictionaryReader CreateBinaryReader(System.Byte[] buffer, int offset, int count, System.Xml.IXmlDictionary dictionary, System.Xml.XmlDictionaryReaderQuotas quotas, System.Xml.XmlBinaryReaderSession session) { return default(System.Xml.XmlDictionaryReader); }
    public static System.Xml.XmlDictionaryReader CreateBinaryReader(System.Byte[] buffer, int offset, int count, System.Xml.IXmlDictionary dictionary, System.Xml.XmlDictionaryReaderQuotas quotas, System.Xml.XmlBinaryReaderSession session, System.Xml.OnXmlDictionaryReaderClose onClose) { return default(System.Xml.XmlDictionaryReader); }
    public static System.Xml.XmlDictionaryReader CreateBinaryReader(System.Byte[] buffer, int offset, int count, System.Xml.XmlDictionaryReaderQuotas quotas) { return default(System.Xml.XmlDictionaryReader); }
    public static System.Xml.XmlDictionaryReader CreateBinaryReader(System.Byte[] buffer, System.Xml.XmlDictionaryReaderQuotas quotas) { return default(System.Xml.XmlDictionaryReader); }
    public static System.Xml.XmlDictionaryReader CreateBinaryReader(System.IO.Stream stream, System.Xml.IXmlDictionary dictionary, System.Xml.XmlDictionaryReaderQuotas quotas) { return default(System.Xml.XmlDictionaryReader); }
    public static System.Xml.XmlDictionaryReader CreateBinaryReader(System.IO.Stream stream, System.Xml.IXmlDictionary dictionary, System.Xml.XmlDictionaryReaderQuotas quotas, System.Xml.XmlBinaryReaderSession session) { return default(System.Xml.XmlDictionaryReader); }
    public static System.Xml.XmlDictionaryReader CreateBinaryReader(System.IO.Stream stream, System.Xml.IXmlDictionary dictionary, System.Xml.XmlDictionaryReaderQuotas quotas, System.Xml.XmlBinaryReaderSession session, System.Xml.OnXmlDictionaryReaderClose onClose) { return default(System.Xml.XmlDictionaryReader); }
    public static System.Xml.XmlDictionaryReader CreateBinaryReader(System.IO.Stream stream, System.Xml.XmlDictionaryReaderQuotas quotas) { return default(System.Xml.XmlDictionaryReader); }
    public static System.Xml.XmlDictionaryReader CreateDictionaryReader(System.Xml.XmlReader reader) { return default(System.Xml.XmlDictionaryReader); }
    public static System.Xml.XmlDictionaryReader CreateMtomReader(System.Byte[] buffer, int offset, int count, System.Text.Encoding encoding, System.Xml.XmlDictionaryReaderQuotas quotas) { return default(System.Xml.XmlDictionaryReader); }
    public static System.Xml.XmlDictionaryReader CreateMtomReader(System.Byte[] buffer, int offset, int count, System.Text.Encoding[] encodings, string contentType, System.Xml.XmlDictionaryReaderQuotas quotas) { return default(System.Xml.XmlDictionaryReader); }
    public static System.Xml.XmlDictionaryReader CreateMtomReader(System.Byte[] buffer, int offset, int count, System.Text.Encoding[] encodings, string contentType, System.Xml.XmlDictionaryReaderQuotas quotas, int maxBufferSize, System.Xml.OnXmlDictionaryReaderClose onClose) { return default(System.Xml.XmlDictionaryReader); }
    public static System.Xml.XmlDictionaryReader CreateMtomReader(System.Byte[] buffer, int offset, int count, System.Text.Encoding[] encodings, System.Xml.XmlDictionaryReaderQuotas quotas) { return default(System.Xml.XmlDictionaryReader); }
    public static System.Xml.XmlDictionaryReader CreateMtomReader(System.IO.Stream stream, System.Text.Encoding encoding, System.Xml.XmlDictionaryReaderQuotas quotas) { return default(System.Xml.XmlDictionaryReader); }
    public static System.Xml.XmlDictionaryReader CreateMtomReader(System.IO.Stream stream, System.Text.Encoding[] encodings, string contentType, System.Xml.XmlDictionaryReaderQuotas quotas) { return default(System.Xml.XmlDictionaryReader); }
    public static System.Xml.XmlDictionaryReader CreateMtomReader(System.IO.Stream stream, System.Text.Encoding[] encodings, string contentType, System.Xml.XmlDictionaryReaderQuotas quotas, int maxBufferSize, System.Xml.OnXmlDictionaryReaderClose onClose) { return default(System.Xml.XmlDictionaryReader); }
    public static System.Xml.XmlDictionaryReader CreateMtomReader(System.IO.Stream stream, System.Text.Encoding[] encodings, System.Xml.XmlDictionaryReaderQuotas quotas) { return default(System.Xml.XmlDictionaryReader); }
    public static System.Xml.XmlDictionaryReader CreateTextReader(System.Byte[] buffer, int offset, int count, System.Text.Encoding encoding, System.Xml.XmlDictionaryReaderQuotas quotas, System.Xml.OnXmlDictionaryReaderClose onClose) { return default(System.Xml.XmlDictionaryReader); }
    public static System.Xml.XmlDictionaryReader CreateTextReader(System.Byte[] buffer, int offset, int count, System.Xml.XmlDictionaryReaderQuotas quotas) { return default(System.Xml.XmlDictionaryReader); }
    public static System.Xml.XmlDictionaryReader CreateTextReader(System.Byte[] buffer, System.Xml.XmlDictionaryReaderQuotas quotas) { return default(System.Xml.XmlDictionaryReader); }
    public static System.Xml.XmlDictionaryReader CreateTextReader(System.IO.Stream stream, System.Text.Encoding encoding, System.Xml.XmlDictionaryReaderQuotas quotas, System.Xml.OnXmlDictionaryReaderClose onClose) { return default(System.Xml.XmlDictionaryReader); }
    public static System.Xml.XmlDictionaryReader CreateTextReader(System.IO.Stream stream, System.Xml.XmlDictionaryReaderQuotas quotas) { return default(System.Xml.XmlDictionaryReader); }
    public virtual void EndCanonicalization() { }
    public virtual string GetAttribute(System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri) { return default(string); }
    public virtual int IndexOfLocalName(System.String[] localNames, string namespaceUri) { return default(int); }
    public virtual int IndexOfLocalName(System.Xml.XmlDictionaryString[] localNames, System.Xml.XmlDictionaryString namespaceUri) { return default(int); }
    public virtual bool IsArray(out System.Type type) { type = default(System.Type); return default(bool); }
    public virtual bool IsLocalName(string localName) { return default(bool); }
    public virtual bool IsLocalName(System.Xml.XmlDictionaryString localName) { return default(bool); }
    public virtual bool IsNamespaceUri(string namespaceUri) { return default(bool); }
    public virtual bool IsNamespaceUri(System.Xml.XmlDictionaryString namespaceUri) { return default(bool); }
    public virtual bool IsStartArray(out System.Type type) { type = default(System.Type); return default(bool); }
    public virtual bool IsStartElement(System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri) { return default(bool); }
    protected bool IsTextNode(System.Xml.XmlNodeType nodeType) { return default(bool); }
    public virtual void MoveToStartElement() { }
    public virtual void MoveToStartElement(string name) { }
    public virtual void MoveToStartElement(string localName, string namespaceUri) { }
    public virtual void MoveToStartElement(System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri) { }
    public virtual int ReadArray(string localName, string namespaceUri, System.Boolean[] array, int offset, int length) { return default(int); }
    public virtual int ReadArray(string localName, string namespaceUri, System.DateTime[] array, int offset, int length) { return default(int); }
    public virtual int ReadArray(string localName, string namespaceUri, System.Decimal[] array, int offset, int length) { return default(int); }
    public virtual int ReadArray(string localName, string namespaceUri, System.Double[] array, int offset, int length) { return default(int); }
    public virtual int ReadArray(string localName, string namespaceUri, System.Guid[] array, int offset, int length) { return default(int); }
    public virtual int ReadArray(string localName, string namespaceUri, System.Int16[] array, int offset, int length) { return default(int); }
    public virtual int ReadArray(string localName, string namespaceUri, System.Int32[] array, int offset, int length) { return default(int); }
    public virtual int ReadArray(string localName, string namespaceUri, System.Int64[] array, int offset, int length) { return default(int); }
    public virtual int ReadArray(string localName, string namespaceUri, System.Single[] array, int offset, int length) { return default(int); }
    public virtual int ReadArray(string localName, string namespaceUri, System.TimeSpan[] array, int offset, int length) { return default(int); }
    public virtual int ReadArray(System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, System.Boolean[] array, int offset, int length) { return default(int); }
    public virtual int ReadArray(System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, System.DateTime[] array, int offset, int length) { return default(int); }
    public virtual int ReadArray(System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, System.Decimal[] array, int offset, int length) { return default(int); }
    public virtual int ReadArray(System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, System.Double[] array, int offset, int length) { return default(int); }
    public virtual int ReadArray(System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, System.Guid[] array, int offset, int length) { return default(int); }
    public virtual int ReadArray(System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, System.Int16[] array, int offset, int length) { return default(int); }
    public virtual int ReadArray(System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, System.Int32[] array, int offset, int length) { return default(int); }
    public virtual int ReadArray(System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, System.Int64[] array, int offset, int length) { return default(int); }
    public virtual int ReadArray(System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, System.Single[] array, int offset, int length) { return default(int); }
    public virtual int ReadArray(System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, System.TimeSpan[] array, int offset, int length) { return default(int); }
    public virtual System.Boolean[] ReadBooleanArray(string localName, string namespaceUri) { return default(System.Boolean[]); }
    public virtual System.Boolean[] ReadBooleanArray(System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri) { return default(System.Boolean[]); }
    public override object ReadContentAs(System.Type type, System.Xml.IXmlNamespaceResolver nsResolver) { return default(object); }
    public virtual System.Byte[] ReadContentAsBase64() { return default(System.Byte[]); }
    public virtual System.Byte[] ReadContentAsBinHex() { return default(System.Byte[]); }
    protected System.Byte[] ReadContentAsBinHex(int maxByteArrayContentLength) { return default(System.Byte[]); }
    [System.MonoTODOAttribute]
    public virtual int ReadContentAsChars(System.Char[] chars, int offset, int count) { return default(int); }
    public override decimal ReadContentAsDecimal() { return default(decimal); }
    public override float ReadContentAsFloat() { return default(float); }
    public virtual System.Guid ReadContentAsGuid() { return default(System.Guid); }
    public virtual void ReadContentAsQualifiedName(out string localName, out string namespaceUri) { localName = default(string); namespaceUri = default(string); }
    public override string ReadContentAsString() { return default(string); }
    [System.MonoTODOAttribute]
    protected string ReadContentAsString(int maxStringContentLength) { return default(string); }
    [System.MonoTODOAttribute("there is exactly no information on the web")]
    public virtual string ReadContentAsString(System.String[] strings, out int index) { index = default(int); return default(string); }
    [System.MonoTODOAttribute("there is exactly no information on the web")]
    public virtual string ReadContentAsString(System.Xml.XmlDictionaryString[] strings, out int index) { index = default(int); return default(string); }
    public virtual System.TimeSpan ReadContentAsTimeSpan() { return default(System.TimeSpan); }
    public virtual System.Xml.UniqueId ReadContentAsUniqueId() { return default(System.Xml.UniqueId); }
    public virtual System.DateTime[] ReadDateTimeArray(string localName, string namespaceUri) { return default(System.DateTime[]); }
    public virtual System.DateTime[] ReadDateTimeArray(System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri) { return default(System.DateTime[]); }
    public virtual System.Decimal[] ReadDecimalArray(string localName, string namespaceUri) { return default(System.Decimal[]); }
    public virtual System.Decimal[] ReadDecimalArray(System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri) { return default(System.Decimal[]); }
    public virtual System.Double[] ReadDoubleArray(string localName, string namespaceUri) { return default(System.Double[]); }
    public virtual System.Double[] ReadDoubleArray(System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri) { return default(System.Double[]); }
    public virtual System.Byte[] ReadElementContentAsBase64() { return default(System.Byte[]); }
    public virtual System.Byte[] ReadElementContentAsBinHex() { return default(System.Byte[]); }
    public override bool ReadElementContentAsBoolean() { return default(bool); }
    public override System.DateTime ReadElementContentAsDateTime() { return default(System.DateTime); }
    public override decimal ReadElementContentAsDecimal() { return default(decimal); }
    public override double ReadElementContentAsDouble() { return default(double); }
    public override float ReadElementContentAsFloat() { return default(float); }
    public virtual System.Guid ReadElementContentAsGuid() { return default(System.Guid); }
    public override int ReadElementContentAsInt() { return default(int); }
    public override long ReadElementContentAsLong() { return default(long); }
    public override string ReadElementContentAsString() { return default(string); }
    public virtual System.TimeSpan ReadElementContentAsTimeSpan() { return default(System.TimeSpan); }
    public virtual System.Xml.UniqueId ReadElementContentAsUniqueId() { return default(System.Xml.UniqueId); }
    public virtual void ReadFullStartElement() { }
    public virtual void ReadFullStartElement(string name) { }
    public virtual void ReadFullStartElement(string localName, string namespaceUri) { }
    public virtual void ReadFullStartElement(System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri) { }
    public virtual System.Guid[] ReadGuidArray(string localName, string namespaceUri) { return default(System.Guid[]); }
    public virtual System.Guid[] ReadGuidArray(System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri) { return default(System.Guid[]); }
    public virtual System.Int16[] ReadInt16Array(string localName, string namespaceUri) { return default(System.Int16[]); }
    public virtual System.Int16[] ReadInt16Array(System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri) { return default(System.Int16[]); }
    public virtual System.Int32[] ReadInt32Array(string localName, string namespaceUri) { return default(System.Int32[]); }
    public virtual System.Int32[] ReadInt32Array(System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri) { return default(System.Int32[]); }
    public virtual System.Int64[] ReadInt64Array(string localName, string namespaceUri) { return default(System.Int64[]); }
    public virtual System.Int64[] ReadInt64Array(System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri) { return default(System.Int64[]); }
    public virtual System.Single[] ReadSingleArray(string localName, string namespaceUri) { return default(System.Single[]); }
    public virtual System.Single[] ReadSingleArray(System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri) { return default(System.Single[]); }
    public virtual void ReadStartElement(System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri) { }
    public override string ReadString() { return default(string); }
    [System.MonoTODOAttribute]
    protected string ReadString(int maxStringContentLength) { return default(string); }
    public virtual System.TimeSpan[] ReadTimeSpanArray(string localName, string namespaceUri) { return default(System.TimeSpan[]); }
    public virtual System.TimeSpan[] ReadTimeSpanArray(System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri) { return default(System.TimeSpan[]); }
    public virtual int ReadValueAsBase64(System.Byte[] bytes, int start, int length) { return default(int); }
    public virtual void StartCanonicalization(System.IO.Stream stream, bool includeComments, System.String[] inclusivePrefixes) { }
    public virtual bool TryGetArrayLength(out int count) { count = default(int); return default(bool); }
    public virtual bool TryGetBase64ContentLength(out int count) { count = default(int); return default(bool); }
    public virtual bool TryGetLocalNameAsDictionaryString(out System.Xml.XmlDictionaryString localName) { localName = default(System.Xml.XmlDictionaryString); return default(bool); }
    public virtual bool TryGetNamespaceUriAsDictionaryString(out System.Xml.XmlDictionaryString namespaceUri) { namespaceUri = default(System.Xml.XmlDictionaryString); return default(bool); }
    public virtual bool TryGetValueAsDictionaryString(out System.Xml.XmlDictionaryString value) { value = default(System.Xml.XmlDictionaryString); return default(bool); }
  }
  public sealed partial class XmlDictionaryReaderQuotas {
    public XmlDictionaryReaderQuotas() { }
    public static System.Xml.XmlDictionaryReaderQuotas Max { get { return default(System.Xml.XmlDictionaryReaderQuotas); } }
    public int MaxArrayLength { get { return default(int); } set { } }
    public int MaxBytesPerRead { get { return default(int); } set { } }
    public int MaxDepth { get { return default(int); } set { } }
    public int MaxNameTableCharCount { get { return default(int); } set { } }
    public int MaxStringContentLength { get { return default(int); } set { } }
    public void CopyTo(System.Xml.XmlDictionaryReaderQuotas quota) { }
  }
  public partial class XmlDictionaryString {
    public XmlDictionaryString(System.Xml.IXmlDictionary dictionary, string value, int key) { }
    public System.Xml.IXmlDictionary Dictionary { get { return default(System.Xml.IXmlDictionary); } }
    public static System.Xml.XmlDictionaryString Empty { get { return default(System.Xml.XmlDictionaryString); } }
    public int Key { get { return default(int); } }
    public string Value { get { return default(string); } }
    public override string ToString() { return default(string); }
  }
  public abstract partial class XmlDictionaryWriter : System.Xml.XmlWriter {
    protected XmlDictionaryWriter() { }
    public virtual bool CanCanonicalize { get { return default(bool); } }
    public static System.Xml.XmlDictionaryWriter CreateBinaryWriter(System.IO.Stream stream) { return default(System.Xml.XmlDictionaryWriter); }
    public static System.Xml.XmlDictionaryWriter CreateBinaryWriter(System.IO.Stream stream, System.Xml.IXmlDictionary dictionary) { return default(System.Xml.XmlDictionaryWriter); }
    public static System.Xml.XmlDictionaryWriter CreateBinaryWriter(System.IO.Stream stream, System.Xml.IXmlDictionary dictionary, System.Xml.XmlBinaryWriterSession session) { return default(System.Xml.XmlDictionaryWriter); }
    public static System.Xml.XmlDictionaryWriter CreateBinaryWriter(System.IO.Stream stream, System.Xml.IXmlDictionary dictionary, System.Xml.XmlBinaryWriterSession session, bool ownsStream) { return default(System.Xml.XmlDictionaryWriter); }
    public static System.Xml.XmlDictionaryWriter CreateDictionaryWriter(System.Xml.XmlWriter writer) { return default(System.Xml.XmlDictionaryWriter); }
    public static System.Xml.XmlDictionaryWriter CreateMtomWriter(System.IO.Stream stream, System.Text.Encoding encoding, int maxSizeInBytes, string startInfo) { return default(System.Xml.XmlDictionaryWriter); }
    public static System.Xml.XmlDictionaryWriter CreateMtomWriter(System.IO.Stream stream, System.Text.Encoding encoding, int maxSizeInBytes, string startInfo, string boundary, string startUri, bool writeMessageHeaders, bool ownsStream) { return default(System.Xml.XmlDictionaryWriter); }
    public static System.Xml.XmlDictionaryWriter CreateTextWriter(System.IO.Stream stream) { return default(System.Xml.XmlDictionaryWriter); }
    public static System.Xml.XmlDictionaryWriter CreateTextWriter(System.IO.Stream stream, System.Text.Encoding encoding) { return default(System.Xml.XmlDictionaryWriter); }
    public static System.Xml.XmlDictionaryWriter CreateTextWriter(System.IO.Stream stream, System.Text.Encoding encoding, bool ownsStream) { return default(System.Xml.XmlDictionaryWriter); }
    public virtual void EndCanonicalization() { }
    public virtual void StartCanonicalization(System.IO.Stream stream, bool includeComments, System.String[] inclusivePrefixes) { }
    public virtual void WriteArray(string prefix, string localName, string namespaceUri, System.Boolean[] array, int offset, int length) { }
    public virtual void WriteArray(string prefix, string localName, string namespaceUri, System.DateTime[] array, int offset, int length) { }
    public virtual void WriteArray(string prefix, string localName, string namespaceUri, System.Decimal[] array, int offset, int length) { }
    public virtual void WriteArray(string prefix, string localName, string namespaceUri, System.Double[] array, int offset, int length) { }
    public virtual void WriteArray(string prefix, string localName, string namespaceUri, System.Guid[] array, int offset, int length) { }
    public virtual void WriteArray(string prefix, string localName, string namespaceUri, System.Int16[] array, int offset, int length) { }
    public virtual void WriteArray(string prefix, string localName, string namespaceUri, System.Int32[] array, int offset, int length) { }
    public virtual void WriteArray(string prefix, string localName, string namespaceUri, System.Int64[] array, int offset, int length) { }
    public virtual void WriteArray(string prefix, string localName, string namespaceUri, System.Single[] array, int offset, int length) { }
    public virtual void WriteArray(string prefix, string localName, string namespaceUri, System.TimeSpan[] array, int offset, int length) { }
    public virtual void WriteArray(string prefix, System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, System.Boolean[] array, int offset, int length) { }
    public virtual void WriteArray(string prefix, System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, System.DateTime[] array, int offset, int length) { }
    public virtual void WriteArray(string prefix, System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, System.Decimal[] array, int offset, int length) { }
    public virtual void WriteArray(string prefix, System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, System.Double[] array, int offset, int length) { }
    public virtual void WriteArray(string prefix, System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, System.Guid[] array, int offset, int length) { }
    public virtual void WriteArray(string prefix, System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, System.Int16[] array, int offset, int length) { }
    public virtual void WriteArray(string prefix, System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, System.Int32[] array, int offset, int length) { }
    public virtual void WriteArray(string prefix, System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, System.Int64[] array, int offset, int length) { }
    public virtual void WriteArray(string prefix, System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, System.Single[] array, int offset, int length) { }
    public virtual void WriteArray(string prefix, System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, System.TimeSpan[] array, int offset, int length) { }
    public void WriteAttributeString(string prefix, System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, string value) { }
    public void WriteAttributeString(System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, string value) { }
    public void WriteElementString(string prefix, System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, string value) { }
    public void WriteElementString(System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, string value) { }
    public virtual void WriteNode(System.Xml.XmlDictionaryReader reader, bool defattr) { }
    public override void WriteNode(System.Xml.XmlReader reader, bool defattr) { }
    public virtual void WriteQualifiedName(System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri) { }
    public virtual void WriteStartAttribute(string prefix, System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri) { }
    public void WriteStartAttribute(System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri) { }
    public virtual void WriteStartElement(string prefix, System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri) { }
    public void WriteStartElement(System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri) { }
    public virtual void WriteString(System.Xml.XmlDictionaryString value) { }
    protected virtual void WriteTextNode(System.Xml.XmlDictionaryReader reader, bool isAttribute) { }
    public virtual void WriteValue(System.Guid guid) { }
    public virtual void WriteValue(System.TimeSpan duration) { }
    public virtual void WriteValue(System.Xml.IStreamProvider value) { }
    public virtual void WriteValue(System.Xml.UniqueId id) { }
    public virtual void WriteValue(System.Xml.XmlDictionaryString value) { }
    public virtual void WriteXmlAttribute(string localName, string value) { }
    public virtual void WriteXmlAttribute(System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString value) { }
    public virtual void WriteXmlnsAttribute(string prefix, string namespaceUri) { }
    public virtual void WriteXmlnsAttribute(string prefix, System.Xml.XmlDictionaryString namespaceUri) { }
  }
}
