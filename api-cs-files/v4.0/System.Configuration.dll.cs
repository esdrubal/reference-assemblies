namespace System.Configuration {
  public sealed partial class AppSettingsSection : System.Configuration.ConfigurationSection {
    public AppSettingsSection() { }
    [System.Configuration.ConfigurationPropertyAttribute("file", DefaultValue="")]
    public string File { get { return default(string); } set { } }
    protected internal override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
    [System.Configuration.ConfigurationPropertyAttribute("", Options=(System.Configuration.ConfigurationPropertyOptions)(1))]
    public System.Configuration.KeyValueConfigurationCollection Settings { get { return default(System.Configuration.KeyValueConfigurationCollection); } }
    [System.MonoInternalNoteAttribute("file path?  do we use a System.Configuration api for opening it?  do we keep it open?  do we open it writable?")]
    protected internal override void DeserializeElement(System.Xml.XmlReader reader, bool serializeCollectionKey) { }
    protected internal override object GetRuntimeObject() { return default(object); }
    protected internal override bool IsModified() { return default(bool); }
    protected internal override void Reset(System.Configuration.ConfigurationElement parentSection) { }
    [System.MonoTODOAttribute]
    protected internal override string SerializeSection(System.Configuration.ConfigurationElement parent, string name, System.Configuration.ConfigurationSaveMode mode) { return default(string); }
  }
  public sealed partial class CallbackValidator : System.Configuration.ConfigurationValidatorBase {
    public CallbackValidator(System.Type type, System.Configuration.ValidatorCallback callback) { }
    public override bool CanValidate(System.Type type) { return default(bool); }
    public override void Validate(object value) { }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(128))]
  public sealed partial class CallbackValidatorAttribute : System.Configuration.ConfigurationValidatorAttribute {
    public CallbackValidatorAttribute() { }
    public string CallbackMethodName { get { return default(string); } set { } }
    public System.Type Type { get { return default(System.Type); } set { } }
    public override System.Configuration.ConfigurationValidatorBase ValidatorInstance { get { return default(System.Configuration.ConfigurationValidatorBase); } }
  }
  public sealed partial class CommaDelimitedStringCollection : System.Collections.Specialized.StringCollection {
    public CommaDelimitedStringCollection() { }
    public bool IsModified { get { return default(bool); } }
    public new bool IsReadOnly { get { return default(bool); } }
    public new string this[int index] { get { return default(string); } set { } }
    public new void Add(string value) { }
    public new void AddRange(System.String[] range) { }
    public new void Clear() { }
    public System.Configuration.CommaDelimitedStringCollection Clone() { return default(System.Configuration.CommaDelimitedStringCollection); }
    public new void Insert(int index, string value) { }
    public new void Remove(string value) { }
    public void SetReadOnly() { }
    public override string ToString() { return default(string); }
  }
  public sealed partial class CommaDelimitedStringCollectionConverter : System.Configuration.ConfigurationConverterBase {
    public CommaDelimitedStringCollectionConverter() { }
    public override object ConvertFrom(System.ComponentModel.ITypeDescriptorContext ctx, System.Globalization.CultureInfo ci, object data) { return default(object); }
    public override object ConvertTo(System.ComponentModel.ITypeDescriptorContext ctx, System.Globalization.CultureInfo ci, object value, System.Type type) { return default(object); }
  }
  public sealed partial class Configuration {
    internal Configuration() { }
    public System.Configuration.AppSettingsSection AppSettings { get { return default(System.Configuration.AppSettingsSection); } }
    public System.Configuration.ConnectionStringsSection ConnectionStrings { get { return default(System.Configuration.ConnectionStringsSection); } }
    public System.Configuration.ContextInformation EvaluationContext { get { return default(System.Configuration.ContextInformation); } }
    public string FilePath { get { return default(string); } }
    public bool HasFile { get { return default(bool); } }
    public System.Configuration.ConfigurationLocationCollection Locations { get { return default(System.Configuration.ConfigurationLocationCollection); } }
    public bool NamespaceDeclared { get { return default(bool); } set { } }
    public System.Configuration.ConfigurationSectionGroup RootSectionGroup { get { return default(System.Configuration.ConfigurationSectionGroup); } }
    public System.Configuration.ConfigurationSectionGroupCollection SectionGroups { get { return default(System.Configuration.ConfigurationSectionGroupCollection); } }
    public System.Configuration.ConfigurationSectionCollection Sections { get { return default(System.Configuration.ConfigurationSectionCollection); } }
    public System.Configuration.ConfigurationSection GetSection(string path) { return default(System.Configuration.ConfigurationSection); }
    public System.Configuration.ConfigurationSectionGroup GetSectionGroup(string path) { return default(System.Configuration.ConfigurationSectionGroup); }
    public void Save() { }
    public void Save(System.Configuration.ConfigurationSaveMode mode) { }
    public void Save(System.Configuration.ConfigurationSaveMode mode, bool forceUpdateAll) { }
    public void SaveAs(string filename) { }
    public void SaveAs(string filename, System.Configuration.ConfigurationSaveMode mode) { }
    [System.MonoInternalNoteAttribute("Detect if file has changed")]
    public void SaveAs(string filename, System.Configuration.ConfigurationSaveMode mode, bool forceUpdateAll) { }
  }
  public enum ConfigurationAllowDefinition {
    Everywhere = 300,
    MachineOnly = 0,
    MachineToApplication = 200,
    MachineToWebRoot = 100,
  }
  public enum ConfigurationAllowExeDefinition {
    MachineOnly = 0,
    MachineToApplication = 100,
    MachineToLocalUser = 300,
    MachineToRoamingUser = 200,
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(132))]
  public sealed partial class ConfigurationCollectionAttribute : System.Attribute {
    public ConfigurationCollectionAttribute(System.Type itemType) { }
    public string AddItemName { get { return default(string); } set { } }
    public string ClearItemsName { get { return default(string); } set { } }
    public System.Configuration.ConfigurationElementCollectionType CollectionType { get { return default(System.Configuration.ConfigurationElementCollectionType); } set { } }
    [System.MonoInternalNoteAttribute("Do something with this in ConfigurationElementCollection")]
    public System.Type ItemType { get { return default(System.Type); } }
    public string RemoveItemName { get { return default(string); } set { } }
  }
  public abstract partial class ConfigurationConverterBase : System.ComponentModel.TypeConverter {
    protected ConfigurationConverterBase() { }
    public override bool CanConvertFrom(System.ComponentModel.ITypeDescriptorContext ctx, System.Type type) { return default(bool); }
    public override bool CanConvertTo(System.ComponentModel.ITypeDescriptorContext ctx, System.Type type) { return default(bool); }
  }
  public abstract partial class ConfigurationElement {
    protected ConfigurationElement() { }
    public System.Configuration.ElementInformation ElementInformation { get { return default(System.Configuration.ElementInformation); } }
    protected internal virtual System.Configuration.ConfigurationElementProperty ElementProperty { get { return default(System.Configuration.ConfigurationElementProperty); } }
    protected System.Configuration.ContextInformation EvaluationContext { get { return default(System.Configuration.ContextInformation); } }
    protected internal object this[System.Configuration.ConfigurationProperty property] { get { return default(object); } set { } }
    protected internal object this[string property_name] { get { return default(object); } set { } }
    public System.Configuration.ConfigurationLockCollection LockAllAttributesExcept { get { return default(System.Configuration.ConfigurationLockCollection); } }
    public System.Configuration.ConfigurationLockCollection LockAllElementsExcept { get { return default(System.Configuration.ConfigurationLockCollection); } }
    public System.Configuration.ConfigurationLockCollection LockAttributes { get { return default(System.Configuration.ConfigurationLockCollection); } }
    public System.Configuration.ConfigurationLockCollection LockElements { get { return default(System.Configuration.ConfigurationLockCollection); } }
    public bool LockItem { get { return default(bool); } set { } }
    protected internal virtual System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
    protected internal virtual void DeserializeElement(System.Xml.XmlReader reader, bool serializeCollectionKey) { }
    public override bool Equals(object compareTo) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    protected internal virtual void Init() { }
    protected internal virtual void InitializeDefault() { }
    protected internal virtual bool IsModified() { return default(bool); }
    public virtual bool IsReadOnly() { return default(bool); }
    [System.MonoTODOAttribute]
    protected virtual void ListErrors(System.Collections.IList list) { }
    protected virtual bool OnDeserializeUnrecognizedAttribute(string name, string value) { return default(bool); }
    protected virtual bool OnDeserializeUnrecognizedElement(string element, System.Xml.XmlReader reader) { return default(bool); }
    protected virtual object OnRequiredPropertyNotFound(string name) { return default(object); }
    protected virtual void PostDeserialize() { }
    protected virtual void PreSerialize(System.Xml.XmlWriter writer) { }
    protected internal virtual void Reset(System.Configuration.ConfigurationElement parentElement) { }
    protected internal virtual void ResetModified() { }
    protected internal virtual bool SerializeElement(System.Xml.XmlWriter writer, bool serializeCollectionKey) { return default(bool); }
    protected internal virtual bool SerializeToXmlElement(System.Xml.XmlWriter writer, string elementName) { return default(bool); }
    [System.MonoTODOAttribute]
    protected void SetPropertyValue(System.Configuration.ConfigurationProperty prop, object value, bool ignoreLocks) { }
    protected internal virtual void SetReadOnly() { }
    protected internal virtual void Unmerge(System.Configuration.ConfigurationElement source, System.Configuration.ConfigurationElement parent, System.Configuration.ConfigurationSaveMode updateMode) { }
  }
  [System.Diagnostics.DebuggerDisplayAttribute("Count = {Count}")]
  public abstract partial class ConfigurationElementCollection : System.Configuration.ConfigurationElement, System.Collections.ICollection, System.Collections.IEnumerable {
    protected ConfigurationElementCollection() { }
    protected ConfigurationElementCollection(System.Collections.IComparer comparer) { }
    protected internal string AddElementName { get { return default(string); } set { } }
    protected internal string ClearElementName { get { return default(string); } set { } }
    public virtual System.Configuration.ConfigurationElementCollectionType CollectionType { get { return default(System.Configuration.ConfigurationElementCollectionType); } }
    public int Count { get { return default(int); } }
    protected virtual string ElementName { get { return default(string); } }
    public bool EmitClear { get { return default(bool); } set { } }
    public bool IsSynchronized { get { return default(bool); } }
    protected internal string RemoveElementName { get { return default(string); } set { } }
    public object SyncRoot { get { return default(object); } }
    protected virtual bool ThrowOnDuplicate { get { return default(bool); } }
    protected virtual void BaseAdd(System.Configuration.ConfigurationElement element) { }
    protected void BaseAdd(System.Configuration.ConfigurationElement element, bool throwIfExists) { }
    protected virtual void BaseAdd(int index, System.Configuration.ConfigurationElement element) { }
    protected internal void BaseClear() { }
    protected internal System.Configuration.ConfigurationElement BaseGet(int index) { return default(System.Configuration.ConfigurationElement); }
    protected internal System.Configuration.ConfigurationElement BaseGet(object key) { return default(System.Configuration.ConfigurationElement); }
    protected internal System.Object[] BaseGetAllKeys() { return default(System.Object[]); }
    protected internal object BaseGetKey(int index) { return default(object); }
    protected int BaseIndexOf(System.Configuration.ConfigurationElement element) { return default(int); }
    protected internal bool BaseIsRemoved(object key) { return default(bool); }
    protected internal void BaseRemove(object key) { }
    protected internal void BaseRemoveAt(int index) { }
    public void CopyTo(System.Configuration.ConfigurationElement[] array, int index) { }
    protected abstract System.Configuration.ConfigurationElement CreateNewElement();
    protected virtual System.Configuration.ConfigurationElement CreateNewElement(string elementName) { return default(System.Configuration.ConfigurationElement); }
    public override bool Equals(object compareTo) { return default(bool); }
    protected abstract object GetElementKey(System.Configuration.ConfigurationElement element);
    public System.Collections.IEnumerator GetEnumerator() { return default(System.Collections.IEnumerator); }
    public override int GetHashCode() { return default(int); }
    protected virtual bool IsElementName(string elementName) { return default(bool); }
    protected virtual bool IsElementRemovable(System.Configuration.ConfigurationElement element) { return default(bool); }
    protected internal override bool IsModified() { return default(bool); }
    [System.MonoTODOAttribute]
    public override bool IsReadOnly() { return default(bool); }
    protected override bool OnDeserializeUnrecognizedElement(string elementName, System.Xml.XmlReader reader) { return default(bool); }
    protected internal override void Reset(System.Configuration.ConfigurationElement parentElement) { }
    protected internal override void ResetModified() { }
    protected internal override bool SerializeElement(System.Xml.XmlWriter writer, bool serializeCollectionKey) { return default(bool); }
    [System.MonoTODOAttribute]
    protected internal override void SetReadOnly() { }
    void System.Collections.ICollection.CopyTo(System.Array arr, int index) { }
    protected internal override void Unmerge(System.Configuration.ConfigurationElement sourceElement, System.Configuration.ConfigurationElement parentElement, System.Configuration.ConfigurationSaveMode updateMode) { }
  }
  public enum ConfigurationElementCollectionType {
    AddRemoveClearMap = 1,
    AddRemoveClearMapAlternate = 3,
    BasicMap = 0,
    BasicMapAlternate = 2,
  }
  public sealed partial class ConfigurationElementProperty {
    public ConfigurationElementProperty(System.Configuration.ConfigurationValidatorBase validator) { }
    public System.Configuration.ConfigurationValidatorBase Validator { get { return default(System.Configuration.ConfigurationValidatorBase); } }
  }
  public partial class ConfigurationErrorsException : System.Configuration.ConfigurationException {
    public ConfigurationErrorsException() { }
    protected ConfigurationErrorsException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public ConfigurationErrorsException(string message) { }
    public ConfigurationErrorsException(string message, System.Exception inner) { }
    public ConfigurationErrorsException(string message, System.Exception inner, string filename, int line) { }
    public ConfigurationErrorsException(string message, System.Exception inner, System.Xml.XmlNode node) { }
    public ConfigurationErrorsException(string message, System.Exception inner, System.Xml.XmlReader reader) { }
    public ConfigurationErrorsException(string message, string filename, int line) { }
    public ConfigurationErrorsException(string message, System.Xml.XmlNode node) { }
    public ConfigurationErrorsException(string message, System.Xml.XmlReader reader) { }
    public override string BareMessage { get { return default(string); } }
    public System.Collections.ICollection Errors { get { return default(System.Collections.ICollection); } }
    public override string Filename { get { return default(string); } }
    public override int Line { get { return default(int); } }
    public override string Message { get { return default(string); } }
    public static string GetFilename(System.Xml.XmlNode node) { return default(string); }
    public static string GetFilename(System.Xml.XmlReader reader) { return default(string); }
    public static int GetLineNumber(System.Xml.XmlNode node) { return default(int); }
    public static int GetLineNumber(System.Xml.XmlReader reader) { return default(int); }
    public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
  }
  public partial class ConfigurationFileMap : System.ICloneable {
    public ConfigurationFileMap() { }
    public ConfigurationFileMap(string machineConfigFilename) { }
    public string MachineConfigFilename { get { return default(string); } set { } }
    public virtual object Clone() { return default(object); }
  }
  public partial class ConfigurationLocation {
    internal ConfigurationLocation() { }
    public string Path { get { return default(string); } }
    public System.Configuration.Configuration OpenConfiguration() { return default(System.Configuration.Configuration); }
  }
  public partial class ConfigurationLocationCollection : System.Collections.ReadOnlyCollectionBase {
    internal ConfigurationLocationCollection() { }
    public System.Configuration.ConfigurationLocation this[int index] { get { return default(System.Configuration.ConfigurationLocation); } }
  }
  public sealed partial class ConfigurationLockCollection : System.Collections.ICollection, System.Collections.IEnumerable {
    internal ConfigurationLockCollection() { }
    public string AttributeList { get { return default(string); } }
    public int Count { get { return default(int); } }
    [System.MonoTODOAttribute]
    public bool HasParentElements { get { return default(bool); } }
    [System.MonoTODOAttribute]
    public bool IsModified { get { return default(bool); } }
    [System.MonoTODOAttribute]
    public bool IsSynchronized { get { return default(bool); } }
    [System.MonoTODOAttribute]
    public object SyncRoot { get { return default(object); } }
    public void Add(string name) { }
    public void Clear() { }
    public bool Contains(string name) { return default(bool); }
    public void CopyTo(System.String[] array, int index) { }
    public System.Collections.IEnumerator GetEnumerator() { return default(System.Collections.IEnumerator); }
    [System.MonoInternalNoteAttribute("we can't possibly *always* return false here...")]
    public bool IsReadOnly(string name) { return default(bool); }
    public void Remove(string name) { }
    public void SetFromList(string attributeList) { }
    void System.Collections.ICollection.CopyTo(System.Array array, int index) { }
  }
  public static partial class ConfigurationManager {
    public static System.Collections.Specialized.NameValueCollection AppSettings { get { return default(System.Collections.Specialized.NameValueCollection); } }
    public static System.Configuration.ConnectionStringSettingsCollection ConnectionStrings { get { return default(System.Configuration.ConnectionStringSettingsCollection); } }
    public static object GetSection(string sectionName) { return default(object); }
    public static System.Configuration.Configuration OpenExeConfiguration(System.Configuration.ConfigurationUserLevel userLevel) { return default(System.Configuration.Configuration); }
    public static System.Configuration.Configuration OpenExeConfiguration(string exePath) { return default(System.Configuration.Configuration); }
    public static System.Configuration.Configuration OpenMachineConfiguration() { return default(System.Configuration.Configuration); }
    [System.MonoLimitationAttribute("ConfigurationUserLevel parameter is not supported.")]
    public static System.Configuration.Configuration OpenMappedExeConfiguration(System.Configuration.ExeConfigurationFileMap fileMap, System.Configuration.ConfigurationUserLevel userLevel) { return default(System.Configuration.Configuration); }
    public static System.Configuration.Configuration OpenMappedMachineConfiguration(System.Configuration.ConfigurationFileMap fileMap) { return default(System.Configuration.Configuration); }
    public static void RefreshSection(string sectionName) { }
  }
  public sealed partial class ConfigurationPermission : System.Security.CodeAccessPermission, System.Security.Permissions.IUnrestrictedPermission {
    public ConfigurationPermission(System.Security.Permissions.PermissionState state) { }
    public override System.Security.IPermission Copy() { return default(System.Security.IPermission); }
    public override void FromXml(System.Security.SecurityElement securityElement) { }
    public override System.Security.IPermission Intersect(System.Security.IPermission target) { return default(System.Security.IPermission); }
    public override bool IsSubsetOf(System.Security.IPermission target) { return default(bool); }
    public bool IsUnrestricted() { return default(bool); }
    public override System.Security.SecurityElement ToXml() { return default(System.Security.SecurityElement); }
    public override System.Security.IPermission Union(System.Security.IPermission target) { return default(System.Security.IPermission); }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(32767), AllowMultiple=true, Inherited=false)]
  public sealed partial class ConfigurationPermissionAttribute : System.Security.Permissions.CodeAccessSecurityAttribute {
    public ConfigurationPermissionAttribute(System.Security.Permissions.SecurityAction action) : base (default(System.Security.Permissions.SecurityAction)) { }
    public override System.Security.IPermission CreatePermission() { return default(System.Security.IPermission); }
  }
  public sealed partial class ConfigurationProperty {
    public ConfigurationProperty(string name, System.Type type) { }
    public ConfigurationProperty(string name, System.Type type, object default_value) { }
    public ConfigurationProperty(string name, System.Type type, object default_value, System.ComponentModel.TypeConverter converter, System.Configuration.ConfigurationValidatorBase validation, System.Configuration.ConfigurationPropertyOptions flags) { }
    public ConfigurationProperty(string name, System.Type type, object default_value, System.ComponentModel.TypeConverter converter, System.Configuration.ConfigurationValidatorBase validation, System.Configuration.ConfigurationPropertyOptions flags, string description) { }
    public ConfigurationProperty(string name, System.Type type, object default_value, System.Configuration.ConfigurationPropertyOptions flags) { }
    public System.ComponentModel.TypeConverter Converter { get { return default(System.ComponentModel.TypeConverter); } }
    public object DefaultValue { get { return default(object); } }
    public string Description { get { return default(string); } }
    public bool IsDefaultCollection { get { return default(bool); } }
    public bool IsKey { get { return default(bool); } }
    public bool IsRequired { get { return default(bool); } }
    public string Name { get { return default(string); } }
    public System.Type Type { get { return default(System.Type); } }
    public System.Configuration.ConfigurationValidatorBase Validator { get { return default(System.Configuration.ConfigurationValidatorBase); } }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(128))]
  public sealed partial class ConfigurationPropertyAttribute : System.Attribute {
    public ConfigurationPropertyAttribute(string name) { }
    public object DefaultValue { get { return default(object); } set { } }
    public bool IsDefaultCollection { get { return default(bool); } set { } }
    public bool IsKey { get { return default(bool); } set { } }
    public bool IsRequired { get { return default(bool); } set { } }
    public string Name { get { return default(string); } }
    public System.Configuration.ConfigurationPropertyOptions Options { get { return default(System.Configuration.ConfigurationPropertyOptions); } set { } }
  }
  public partial class ConfigurationPropertyCollection : System.Collections.ICollection, System.Collections.IEnumerable {
    public ConfigurationPropertyCollection() { }
    public int Count { get { return default(int); } }
    public bool IsSynchronized { get { return default(bool); } }
    public System.Configuration.ConfigurationProperty this[string name] { get { return default(System.Configuration.ConfigurationProperty); } }
    public object SyncRoot { get { return default(object); } }
    public void Add(System.Configuration.ConfigurationProperty property) { }
    public void Clear() { }
    public bool Contains(string name) { return default(bool); }
    public void CopyTo(System.Configuration.ConfigurationProperty[] array, int index) { }
    public System.Collections.IEnumerator GetEnumerator() { return default(System.Collections.IEnumerator); }
    public bool Remove(string name) { return default(bool); }
    void System.Collections.ICollection.CopyTo(System.Array array, int index) { }
  }
  [System.FlagsAttribute]
  public enum ConfigurationPropertyOptions {
    IsDefaultCollection = 1,
    IsKey = 4,
    IsRequired = 2,
    None = 0,
  }
  public enum ConfigurationSaveMode {
    Full = 2,
    Minimal = 1,
    Modified = 0,
  }
  public abstract partial class ConfigurationSection : System.Configuration.ConfigurationElement {
    protected ConfigurationSection() { }
    [System.MonoTODOAttribute]
    public System.Configuration.SectionInformation SectionInformation { get { return default(System.Configuration.SectionInformation); } }
    [System.MonoInternalNoteAttribute("find the proper location for the decryption stuff")]
    protected internal virtual void DeserializeSection(System.Xml.XmlReader reader) { }
    [System.MonoTODOAttribute("Provide ConfigContext. Likely the culprit of bug #322493")]
    protected internal virtual object GetRuntimeObject() { return default(object); }
    [System.MonoTODOAttribute]
    protected internal override bool IsModified() { return default(bool); }
    [System.MonoTODOAttribute]
    protected internal override void ResetModified() { }
    protected internal virtual string SerializeSection(System.Configuration.ConfigurationElement parentElement, string name, System.Configuration.ConfigurationSaveMode saveMode) { return default(string); }
  }
  public sealed partial class ConfigurationSectionCollection : System.Collections.Specialized.NameObjectCollectionBase {
    internal ConfigurationSectionCollection() { }
    public override int Count { get { return default(int); } }
    public System.Configuration.ConfigurationSection this[int index] { get { return default(System.Configuration.ConfigurationSection); } }
    public System.Configuration.ConfigurationSection this[string name] { get { return default(System.Configuration.ConfigurationSection); } }
    public override System.Collections.Specialized.NameObjectCollectionBase.KeysCollection Keys { get { return default(System.Collections.Specialized.NameObjectCollectionBase.KeysCollection); } }
    public void Add(string name, System.Configuration.ConfigurationSection section) { }
    public void Clear() { }
    public void CopyTo(System.Configuration.ConfigurationSection[] array, int index) { }
    public System.Configuration.ConfigurationSection Get(int index) { return default(System.Configuration.ConfigurationSection); }
    public System.Configuration.ConfigurationSection Get(string name) { return default(System.Configuration.ConfigurationSection); }
    [System.Diagnostics.DebuggerHiddenAttribute]
    public override System.Collections.IEnumerator GetEnumerator() { return default(System.Collections.IEnumerator); }
    public string GetKey(int index) { return default(string); }
    [System.MonoTODOAttribute]
    public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public void Remove(string name) { }
    public void RemoveAt(int index) { }
  }
  public partial class ConfigurationSectionGroup {
    public ConfigurationSectionGroup() { }
    [System.MonoTODOAttribute]
    public bool IsDeclarationRequired { get { return default(bool); } }
    [System.MonoTODOAttribute]
    public bool IsDeclared { get { return default(bool); } }
    public string Name { get { return default(string); } }
    [System.MonoInternalNoteAttribute("Check if this is correct")]
    public string SectionGroupName { get { return default(string); } }
    public System.Configuration.ConfigurationSectionGroupCollection SectionGroups { get { return default(System.Configuration.ConfigurationSectionGroupCollection); } }
    public System.Configuration.ConfigurationSectionCollection Sections { get { return default(System.Configuration.ConfigurationSectionCollection); } }
    public string Type { get { return default(string); } set { } }
    public void ForceDeclaration() { }
    [System.MonoTODOAttribute]
    public void ForceDeclaration(bool require) { }
  }
  public sealed partial class ConfigurationSectionGroupCollection : System.Collections.Specialized.NameObjectCollectionBase {
    internal ConfigurationSectionGroupCollection() { }
    public override int Count { get { return default(int); } }
    public System.Configuration.ConfigurationSectionGroup this[int index] { get { return default(System.Configuration.ConfigurationSectionGroup); } }
    public System.Configuration.ConfigurationSectionGroup this[string name] { get { return default(System.Configuration.ConfigurationSectionGroup); } }
    public override System.Collections.Specialized.NameObjectCollectionBase.KeysCollection Keys { get { return default(System.Collections.Specialized.NameObjectCollectionBase.KeysCollection); } }
    public void Add(string name, System.Configuration.ConfigurationSectionGroup sectionGroup) { }
    public void Clear() { }
    public void CopyTo(System.Configuration.ConfigurationSectionGroup[] array, int index) { }
    public System.Configuration.ConfigurationSectionGroup Get(int index) { return default(System.Configuration.ConfigurationSectionGroup); }
    public System.Configuration.ConfigurationSectionGroup Get(string name) { return default(System.Configuration.ConfigurationSectionGroup); }
    public override System.Collections.IEnumerator GetEnumerator() { return default(System.Collections.IEnumerator); }
    public string GetKey(int index) { return default(string); }
    [System.MonoTODOAttribute]
    public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public void Remove(string name) { }
    public void RemoveAt(int index) { }
  }
  public enum ConfigurationUserLevel {
    None = 0,
    PerUserRoaming = 10,
    PerUserRoamingAndLocal = 20,
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(128))]
  public partial class ConfigurationValidatorAttribute : System.Attribute {
    protected ConfigurationValidatorAttribute() { }
    public ConfigurationValidatorAttribute(System.Type validator) { }
    public virtual System.Configuration.ConfigurationValidatorBase ValidatorInstance { get { return default(System.Configuration.ConfigurationValidatorBase); } }
    public System.Type ValidatorType { get { return default(System.Type); } }
  }
  public abstract partial class ConfigurationValidatorBase {
    protected ConfigurationValidatorBase() { }
    public virtual bool CanValidate(System.Type type) { return default(bool); }
    public abstract void Validate(object value);
  }
  public sealed partial class ConnectionStringSettings : System.Configuration.ConfigurationElement {
    public ConnectionStringSettings() { }
    public ConnectionStringSettings(string name, string connectionString) { }
    public ConnectionStringSettings(string name, string connectionString, string providerName) { }
    [System.Configuration.ConfigurationPropertyAttribute("connectionString", DefaultValue="", Options=(System.Configuration.ConfigurationPropertyOptions)(2))]
    public string ConnectionString { get { return default(string); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("name", DefaultValue="", Options=(System.Configuration.ConfigurationPropertyOptions)(6))]
    public string Name { get { return default(string); } set { } }
    protected internal override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
    [System.Configuration.ConfigurationPropertyAttribute("providerName", DefaultValue="System.Data.SqlClient")]
    public string ProviderName { get { return default(string); } set { } }
    public override string ToString() { return default(string); }
  }
  [System.Configuration.ConfigurationCollectionAttribute(typeof(System.Configuration.ConnectionStringSettings), CollectionType=(System.Configuration.ConfigurationElementCollectionType)(1))]
  public sealed partial class ConnectionStringSettingsCollection : System.Configuration.ConfigurationElementCollection {
    public ConnectionStringSettingsCollection() { }
    public System.Configuration.ConnectionStringSettings this[int index] { get { return default(System.Configuration.ConnectionStringSettings); } set { } }
    public new System.Configuration.ConnectionStringSettings this[string Name] { get { return default(System.Configuration.ConnectionStringSettings); } }
    [System.MonoTODOAttribute]
    protected internal override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
    public void Add(System.Configuration.ConnectionStringSettings settings) { }
    protected override void BaseAdd(int index, System.Configuration.ConfigurationElement element) { }
    public void Clear() { }
    protected override System.Configuration.ConfigurationElement CreateNewElement() { return default(System.Configuration.ConfigurationElement); }
    protected override object GetElementKey(System.Configuration.ConfigurationElement element) { return default(object); }
    public int IndexOf(System.Configuration.ConnectionStringSettings settings) { return default(int); }
    public void Remove(System.Configuration.ConnectionStringSettings settings) { }
    public void Remove(string name) { }
    public void RemoveAt(int index) { }
  }
  public sealed partial class ConnectionStringsSection : System.Configuration.ConfigurationSection {
    public ConnectionStringsSection() { }
    [System.Configuration.ConfigurationPropertyAttribute("", Options=(System.Configuration.ConfigurationPropertyOptions)(1))]
    public System.Configuration.ConnectionStringSettingsCollection ConnectionStrings { get { return default(System.Configuration.ConnectionStringSettingsCollection); } }
    protected internal override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
    protected internal override object GetRuntimeObject() { return default(object); }
  }
  public sealed partial class ContextInformation {
    internal ContextInformation() { }
    public object HostingContext { get { return default(object); } }
    [System.MonoInternalNoteAttribute("should this use HostingContext instead?")]
    public bool IsMachineLevel { get { return default(bool); } }
    public object GetSection(string sectionName) { return default(object); }
  }
  public sealed partial class DefaultSection : System.Configuration.ConfigurationSection {
    public DefaultSection() { }
    protected internal override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
    protected internal override void DeserializeSection(System.Xml.XmlReader xmlReader) { }
    [System.MonoTODOAttribute]
    protected internal override bool IsModified() { return default(bool); }
    [System.MonoTODOAttribute]
    protected internal override void Reset(System.Configuration.ConfigurationElement parentSection) { }
    [System.MonoTODOAttribute]
    protected internal override void ResetModified() { }
    [System.MonoTODOAttribute]
    protected internal override string SerializeSection(System.Configuration.ConfigurationElement parentSection, string name, System.Configuration.ConfigurationSaveMode saveMode) { return default(string); }
  }
  public sealed partial class DefaultValidator : System.Configuration.ConfigurationValidatorBase {
    public DefaultValidator() { }
    public override bool CanValidate(System.Type type) { return default(bool); }
    public override void Validate(object value) { }
  }
  public sealed partial class DpapiProtectedConfigurationProvider : System.Configuration.ProtectedConfigurationProvider {
    public DpapiProtectedConfigurationProvider() { }
    public bool UseMachineProtection { get { return default(bool); } }
    [System.MonoNotSupportedAttribute("DpapiProtectedConfigurationProvider depends on the Microsoft Data\nProtection API, and is unimplemented in Mono.  For portability's sake,\nit is suggested that you use the RsaProtectedConfigurationProvider.")]
    public override System.Xml.XmlNode Decrypt(System.Xml.XmlNode encrypted_node) { return default(System.Xml.XmlNode); }
    [System.MonoNotSupportedAttribute("DpapiProtectedConfigurationProvider depends on the Microsoft Data\nProtection API, and is unimplemented in Mono.  For portability's sake,\nit is suggested that you use the RsaProtectedConfigurationProvider.")]
    public override System.Xml.XmlNode Encrypt(System.Xml.XmlNode node) { return default(System.Xml.XmlNode); }
    [System.MonoTODOAttribute]
    public override void Initialize(string name, System.Collections.Specialized.NameValueCollection configurationValues) { }
  }
  public sealed partial class ElementInformation {
    internal ElementInformation() { }
    [System.MonoTODOAttribute]
    public System.Collections.ICollection Errors { get { return default(System.Collections.ICollection); } }
    public bool IsCollection { get { return default(bool); } }
    public bool IsLocked { get { return default(bool); } }
    [System.MonoTODOAttribute("Support multiple levels of inheritance")]
    public bool IsPresent { get { return default(bool); } }
    public int LineNumber { get { return default(int); } }
    public System.Configuration.PropertyInformationCollection Properties { get { return default(System.Configuration.PropertyInformationCollection); } }
    public string Source { get { return default(string); } }
    public System.Type Type { get { return default(System.Type); } }
    public System.Configuration.ConfigurationValidatorBase Validator { get { return default(System.Configuration.ConfigurationValidatorBase); } }
  }
  public sealed partial class ExeConfigurationFileMap : System.Configuration.ConfigurationFileMap {
    public ExeConfigurationFileMap() { }
    public string ExeConfigFilename { get { return default(string); } set { } }
    public string LocalUserConfigFilename { get { return default(string); } set { } }
    public string RoamingUserConfigFilename { get { return default(string); } set { } }
    public override object Clone() { return default(object); }
  }
  public sealed partial class ExeContext {
    internal ExeContext() { }
    public string ExePath { get { return default(string); } }
    public System.Configuration.ConfigurationUserLevel UserLevel { get { return default(System.Configuration.ConfigurationUserLevel); } }
  }
  public sealed partial class GenericEnumConverter : System.Configuration.ConfigurationConverterBase {
    public GenericEnumConverter(System.Type typeEnum) { }
    public override object ConvertFrom(System.ComponentModel.ITypeDescriptorContext ctx, System.Globalization.CultureInfo ci, object data) { return default(object); }
    public override object ConvertTo(System.ComponentModel.ITypeDescriptorContext ctx, System.Globalization.CultureInfo ci, object value, System.Type type) { return default(object); }
  }
  public sealed partial class IgnoreSection : System.Configuration.ConfigurationSection {
    public IgnoreSection() { }
    protected internal override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
    protected internal override void DeserializeSection(System.Xml.XmlReader reader) { }
    protected internal override bool IsModified() { return default(bool); }
    [System.MonoTODOAttribute]
    protected internal override void Reset(System.Configuration.ConfigurationElement parentElement) { }
    [System.MonoTODOAttribute]
    protected internal override void ResetModified() { }
    protected internal override string SerializeSection(System.Configuration.ConfigurationElement parentElement, string name, System.Configuration.ConfigurationSaveMode saveMode) { return default(string); }
  }
  public sealed partial class InfiniteIntConverter : System.Configuration.ConfigurationConverterBase {
    public InfiniteIntConverter() { }
    public override object ConvertFrom(System.ComponentModel.ITypeDescriptorContext ctx, System.Globalization.CultureInfo ci, object data) { return default(object); }
    public override object ConvertTo(System.ComponentModel.ITypeDescriptorContext ctx, System.Globalization.CultureInfo ci, object value, System.Type type) { return default(object); }
  }
  public sealed partial class InfiniteTimeSpanConverter : System.Configuration.ConfigurationConverterBase {
    public InfiniteTimeSpanConverter() { }
    public override object ConvertFrom(System.ComponentModel.ITypeDescriptorContext ctx, System.Globalization.CultureInfo ci, object data) { return default(object); }
    public override object ConvertTo(System.ComponentModel.ITypeDescriptorContext ctx, System.Globalization.CultureInfo ci, object value, System.Type type) { return default(object); }
  }
  public partial class IntegerValidator : System.Configuration.ConfigurationValidatorBase {
    public IntegerValidator(int minValue, int maxValue) { }
    public IntegerValidator(int minValue, int maxValue, bool rangeIsExclusive) { }
    public IntegerValidator(int minValue, int maxValue, bool rangeIsExclusive, int resolution) { }
    public override bool CanValidate(System.Type type) { return default(bool); }
    public override void Validate(object value) { }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(128))]
  public sealed partial class IntegerValidatorAttribute : System.Configuration.ConfigurationValidatorAttribute {
    public IntegerValidatorAttribute() { }
    public bool ExcludeRange { get { return default(bool); } set { } }
    public int MaxValue { get { return default(int); } set { } }
    public int MinValue { get { return default(int); } set { } }
    public override System.Configuration.ConfigurationValidatorBase ValidatorInstance { get { return default(System.Configuration.ConfigurationValidatorBase); } }
  }
  [System.Configuration.ConfigurationCollectionAttribute(typeof(System.Configuration.KeyValueConfigurationElement), CollectionType=(System.Configuration.ConfigurationElementCollectionType)(1))]
  public partial class KeyValueConfigurationCollection : System.Configuration.ConfigurationElementCollection {
    public KeyValueConfigurationCollection() { }
    public System.String[] AllKeys { get { return default(System.String[]); } }
    public new System.Configuration.KeyValueConfigurationElement this[string key] { get { return default(System.Configuration.KeyValueConfigurationElement); } }
    protected internal override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
    protected override bool ThrowOnDuplicate { get { return default(bool); } }
    public void Add(System.Configuration.KeyValueConfigurationElement keyValue) { }
    public void Add(string key, string value) { }
    public void Clear() { }
    protected override System.Configuration.ConfigurationElement CreateNewElement() { return default(System.Configuration.ConfigurationElement); }
    protected override object GetElementKey(System.Configuration.ConfigurationElement element) { return default(object); }
    public void Remove(string key) { }
  }
  public partial class KeyValueConfigurationElement : System.Configuration.ConfigurationElement {
    public KeyValueConfigurationElement(string key, string value) { }
    [System.Configuration.ConfigurationPropertyAttribute("key", DefaultValue="", Options=(System.Configuration.ConfigurationPropertyOptions)(4))]
    public string Key { get { return default(string); } }
    protected internal override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
    [System.Configuration.ConfigurationPropertyAttribute("value", DefaultValue="")]
    public string Value { get { return default(string); } set { } }
    [System.MonoTODOAttribute]
    protected internal override void Init() { }
  }
  public partial class LongValidator : System.Configuration.ConfigurationValidatorBase {
    public LongValidator(long minValue, long maxValue) { }
    public LongValidator(long minValue, long maxValue, bool rangeIsExclusive) { }
    public LongValidator(long minValue, long maxValue, bool rangeIsExclusive, long resolution) { }
    public override bool CanValidate(System.Type type) { return default(bool); }
    public override void Validate(object value) { }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(128))]
  public sealed partial class LongValidatorAttribute : System.Configuration.ConfigurationValidatorAttribute {
    public LongValidatorAttribute() { }
    public bool ExcludeRange { get { return default(bool); } set { } }
    public long MaxValue { get { return default(long); } set { } }
    public long MinValue { get { return default(long); } set { } }
    public override System.Configuration.ConfigurationValidatorBase ValidatorInstance { get { return default(System.Configuration.ConfigurationValidatorBase); } }
  }
  [System.Configuration.ConfigurationCollectionAttribute(typeof(System.Configuration.NameValueConfigurationElement), AddItemName="add", RemoveItemName="remove", ClearItemsName="clear", CollectionType=(System.Configuration.ConfigurationElementCollectionType)(1))]
  public sealed partial class NameValueConfigurationCollection : System.Configuration.ConfigurationElementCollection {
    public NameValueConfigurationCollection() { }
    public System.String[] AllKeys { get { return default(System.String[]); } }
    public new System.Configuration.NameValueConfigurationElement this[string name] { get { return default(System.Configuration.NameValueConfigurationElement); } set { } }
    protected internal override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
    public void Add(System.Configuration.NameValueConfigurationElement nameValue) { }
    public void Clear() { }
    protected override System.Configuration.ConfigurationElement CreateNewElement() { return default(System.Configuration.ConfigurationElement); }
    protected override object GetElementKey(System.Configuration.ConfigurationElement element) { return default(object); }
    public void Remove(System.Configuration.NameValueConfigurationElement nameValue) { }
    public void Remove(string name) { }
  }
  public sealed partial class NameValueConfigurationElement : System.Configuration.ConfigurationElement {
    public NameValueConfigurationElement(string name, string value) { }
    [System.Configuration.ConfigurationPropertyAttribute("name", DefaultValue="", Options=(System.Configuration.ConfigurationPropertyOptions)(4))]
    public string Name { get { return default(string); } }
    protected internal override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
    [System.Configuration.ConfigurationPropertyAttribute("value", DefaultValue="", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    public string Value { get { return default(string); } set { } }
  }
  public partial class PositiveTimeSpanValidator : System.Configuration.ConfigurationValidatorBase {
    public PositiveTimeSpanValidator() { }
    public override bool CanValidate(System.Type type) { return default(bool); }
    public override void Validate(object value) { }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(128))]
  public sealed partial class PositiveTimeSpanValidatorAttribute : System.Configuration.ConfigurationValidatorAttribute {
    public PositiveTimeSpanValidatorAttribute() { }
    public override System.Configuration.ConfigurationValidatorBase ValidatorInstance { get { return default(System.Configuration.ConfigurationValidatorBase); } }
  }
  public sealed partial class PropertyInformation {
    internal PropertyInformation() { }
    public System.ComponentModel.TypeConverter Converter { get { return default(System.ComponentModel.TypeConverter); } }
    public object DefaultValue { get { return default(object); } }
    public string Description { get { return default(string); } }
    public bool IsKey { get { return default(bool); } }
    [System.MonoTODOAttribute]
    public bool IsLocked { get { return default(bool); } }
    public bool IsModified { get { return default(bool); } }
    public bool IsRequired { get { return default(bool); } }
    public int LineNumber { get { return default(int); } }
    public string Name { get { return default(string); } }
    public string Source { get { return default(string); } }
    public System.Type Type { get { return default(System.Type); } }
    public System.Configuration.ConfigurationValidatorBase Validator { get { return default(System.Configuration.ConfigurationValidatorBase); } }
    public object Value { get { return default(object); } set { } }
    public System.Configuration.PropertyValueOrigin ValueOrigin { get { return default(System.Configuration.PropertyValueOrigin); } }
  }
  public sealed partial class PropertyInformationCollection : System.Collections.Specialized.NameObjectCollectionBase {
    internal PropertyInformationCollection() { }
    public System.Configuration.PropertyInformation this[string propertyName] { get { return default(System.Configuration.PropertyInformation); } }
    public void CopyTo(System.Configuration.PropertyInformation[] array, int index) { }
    public override System.Collections.IEnumerator GetEnumerator() { return default(System.Collections.IEnumerator); }
    [System.MonoTODOAttribute]
    public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
  }
  public enum PropertyValueOrigin {
    Default = 0,
    Inherited = 1,
    SetHere = 2,
  }
  public static partial class ProtectedConfiguration {
    public const string DataProtectionProviderName = "DataProtectionConfigurationProvider";
    public const string ProtectedDataSectionName = "configProtectedData";
    public const string RsaProviderName = "RsaProtectedConfigurationProvider";
    public static string DefaultProvider { get { return default(string); } }
    public static System.Configuration.ProtectedConfigurationProviderCollection Providers { get { return default(System.Configuration.ProtectedConfigurationProviderCollection); } }
  }
  public abstract partial class ProtectedConfigurationProvider : System.Configuration.Provider.ProviderBase {
    protected ProtectedConfigurationProvider() { }
    public abstract System.Xml.XmlNode Decrypt(System.Xml.XmlNode encrypted_node);
    public abstract System.Xml.XmlNode Encrypt(System.Xml.XmlNode node);
  }
  public partial class ProtectedConfigurationProviderCollection : System.Configuration.Provider.ProviderCollection {
    public ProtectedConfigurationProviderCollection() { }
    [System.MonoTODOAttribute]
    public new System.Configuration.ProtectedConfigurationProvider this[string name] { get { return default(System.Configuration.ProtectedConfigurationProvider); } }
    [System.MonoTODOAttribute]
    public override void Add(System.Configuration.Provider.ProviderBase provider) { }
  }
  public sealed partial class ProtectedConfigurationSection : System.Configuration.ConfigurationSection {
    public ProtectedConfigurationSection() { }
    [System.Configuration.ConfigurationPropertyAttribute("defaultProvider", DefaultValue="RsaProtectedConfigurationProvider")]
    public string DefaultProvider { get { return default(string); } set { } }
    protected internal override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
    [System.Configuration.ConfigurationPropertyAttribute("providers")]
    public System.Configuration.ProviderSettingsCollection Providers { get { return default(System.Configuration.ProviderSettingsCollection); } }
  }
  public partial class ProtectedProviderSettings : System.Configuration.ConfigurationElement {
    public ProtectedProviderSettings() { }
    protected internal override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
    [System.Configuration.ConfigurationPropertyAttribute("", Options=(System.Configuration.ConfigurationPropertyOptions)(1))]
    public System.Configuration.ProviderSettingsCollection Providers { get { return default(System.Configuration.ProviderSettingsCollection); } }
  }
  public sealed partial class ProviderSettings : System.Configuration.ConfigurationElement {
    public ProviderSettings() { }
    public ProviderSettings(string name, string type) { }
    [System.Configuration.ConfigurationPropertyAttribute("name", Options=(System.Configuration.ConfigurationPropertyOptions)(6))]
    public string Name { get { return default(string); } set { } }
    public System.Collections.Specialized.NameValueCollection Parameters { get { return default(System.Collections.Specialized.NameValueCollection); } }
    protected internal override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
    [System.Configuration.ConfigurationPropertyAttribute("type", Options=(System.Configuration.ConfigurationPropertyOptions)(2))]
    public string Type { get { return default(string); } set { } }
    protected internal override bool IsModified() { return default(bool); }
    protected override bool OnDeserializeUnrecognizedAttribute(string name, string value) { return default(bool); }
    protected internal override void Reset(System.Configuration.ConfigurationElement parentElement) { }
    [System.MonoTODOAttribute]
    protected internal override void Unmerge(System.Configuration.ConfigurationElement source, System.Configuration.ConfigurationElement parent, System.Configuration.ConfigurationSaveMode updateMode) { }
  }
  [System.Configuration.ConfigurationCollectionAttribute(typeof(System.Configuration.ProviderSettings), CollectionType=(System.Configuration.ConfigurationElementCollectionType)(1))]
  public sealed partial class ProviderSettingsCollection : System.Configuration.ConfigurationElementCollection {
    public ProviderSettingsCollection() { }
    public System.Configuration.ProviderSettings this[int n] { get { return default(System.Configuration.ProviderSettings); } set { } }
    public new System.Configuration.ProviderSettings this[string key] { get { return default(System.Configuration.ProviderSettings); } }
    protected internal override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
    public void Add(System.Configuration.ProviderSettings provider) { }
    public void Clear() { }
    protected override System.Configuration.ConfigurationElement CreateNewElement() { return default(System.Configuration.ConfigurationElement); }
    protected override object GetElementKey(System.Configuration.ConfigurationElement element) { return default(object); }
    public void Remove(string key) { }
  }
  public partial class RegexStringValidator : System.Configuration.ConfigurationValidatorBase {
    public RegexStringValidator(string regex) { }
    public override bool CanValidate(System.Type type) { return default(bool); }
    public override void Validate(object value) { }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(128))]
  public sealed partial class RegexStringValidatorAttribute : System.Configuration.ConfigurationValidatorAttribute {
    public RegexStringValidatorAttribute(string regex) { }
    public string Regex { get { return default(string); } }
    public override System.Configuration.ConfigurationValidatorBase ValidatorInstance { get { return default(System.Configuration.ConfigurationValidatorBase); } }
  }
  public sealed partial class RsaProtectedConfigurationProvider : System.Configuration.ProtectedConfigurationProvider {
    public RsaProtectedConfigurationProvider() { }
    public string CspProviderName { get { return default(string); } }
    public string KeyContainerName { get { return default(string); } }
    public System.Security.Cryptography.RSAParameters RsaPublicKey { get { return default(System.Security.Cryptography.RSAParameters); } }
    public bool UseMachineContainer { get { return default(bool); } }
    public bool UseOAEP { get { return default(bool); } }
    [System.MonoTODOAttribute]
    public void AddKey(int keySize, bool exportable) { }
    [System.MonoTODOAttribute]
    public override System.Xml.XmlNode Decrypt(System.Xml.XmlNode encrypted_node) { return default(System.Xml.XmlNode); }
    [System.MonoTODOAttribute]
    public void DeleteKey() { }
    [System.MonoTODOAttribute]
    public override System.Xml.XmlNode Encrypt(System.Xml.XmlNode node) { return default(System.Xml.XmlNode); }
    [System.MonoTODOAttribute]
    public void ExportKey(string xmlFileName, bool includePrivateParameters) { }
    [System.MonoTODOAttribute]
    public void ImportKey(string xmlFileName, bool exportable) { }
    [System.MonoTODOAttribute]
    public override void Initialize(string name, System.Collections.Specialized.NameValueCollection configurationValues) { }
  }
  public sealed partial class SectionInformation {
    internal SectionInformation() { }
    public System.Configuration.ConfigurationAllowDefinition AllowDefinition { get { return default(System.Configuration.ConfigurationAllowDefinition); } set { } }
    public System.Configuration.ConfigurationAllowExeDefinition AllowExeDefinition { get { return default(System.Configuration.ConfigurationAllowExeDefinition); } set { } }
    public bool AllowLocation { get { return default(bool); } set { } }
    public bool AllowOverride { get { return default(bool); } set { } }
    public string ConfigSource { get { return default(string); } set { } }
    public bool ForceSave { get { return default(bool); } set { } }
    public bool InheritInChildApplications { get { return default(bool); } set { } }
    [System.MonoTODOAttribute]
    public bool IsDeclarationRequired { get { return default(bool); } }
    [System.MonoTODOAttribute]
    public bool IsDeclared { get { return default(bool); } }
    [System.MonoTODOAttribute]
    public bool IsLocked { get { return default(bool); } }
    public bool IsProtected { get { return default(bool); } }
    public string Name { get { return default(string); } }
    public System.Configuration.ProtectedConfigurationProvider ProtectionProvider { get { return default(System.Configuration.ProtectedConfigurationProvider); } }
    [System.MonoTODOAttribute]
    public bool RequirePermission { get { return default(bool); } set { } }
    [System.MonoTODOAttribute]
    public bool RestartOnExternalChanges { get { return default(bool); } set { } }
    [System.MonoTODOAttribute]
    public string SectionName { get { return default(string); } }
    public string Type { get { return default(string); } set { } }
    public void ForceDeclaration() { }
    [System.MonoTODOAttribute]
    public void ForceDeclaration(bool require) { }
    public System.Configuration.ConfigurationSection GetParentSection() { return default(System.Configuration.ConfigurationSection); }
    public string GetRawXml() { return default(string); }
    public void ProtectSection(string provider) { }
    [System.MonoTODOAttribute]
    public void RevertToParent() { }
    public void SetRawXml(string xml) { }
    public void UnprotectSection() { }
  }
  public partial class StringValidator : System.Configuration.ConfigurationValidatorBase {
    public StringValidator(int minLength) { }
    public StringValidator(int minLength, int maxLength) { }
    public StringValidator(int minLength, int maxLength, string invalidCharacters) { }
    public override bool CanValidate(System.Type type) { return default(bool); }
    public override void Validate(object value) { }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(128))]
  public sealed partial class StringValidatorAttribute : System.Configuration.ConfigurationValidatorAttribute {
    public StringValidatorAttribute() { }
    public string InvalidCharacters { get { return default(string); } set { } }
    public int MaxLength { get { return default(int); } set { } }
    public int MinLength { get { return default(int); } set { } }
    public override System.Configuration.ConfigurationValidatorBase ValidatorInstance { get { return default(System.Configuration.ConfigurationValidatorBase); } }
  }
  public sealed partial class SubclassTypeValidator : System.Configuration.ConfigurationValidatorBase {
    public SubclassTypeValidator(System.Type baseClass) { }
    public override bool CanValidate(System.Type type) { return default(bool); }
    public override void Validate(object value) { }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(128))]
  public sealed partial class SubclassTypeValidatorAttribute : System.Configuration.ConfigurationValidatorAttribute {
    public SubclassTypeValidatorAttribute(System.Type baseClass) { }
    public System.Type BaseClass { get { return default(System.Type); } }
    public override System.Configuration.ConfigurationValidatorBase ValidatorInstance { get { return default(System.Configuration.ConfigurationValidatorBase); } }
  }
  public partial class TimeSpanMinutesConverter : System.Configuration.ConfigurationConverterBase {
    public TimeSpanMinutesConverter() { }
    public override object ConvertFrom(System.ComponentModel.ITypeDescriptorContext ctx, System.Globalization.CultureInfo ci, object data) { return default(object); }
    public override object ConvertTo(System.ComponentModel.ITypeDescriptorContext ctx, System.Globalization.CultureInfo ci, object value, System.Type type) { return default(object); }
  }
  public sealed partial class TimeSpanMinutesOrInfiniteConverter : System.Configuration.TimeSpanMinutesConverter {
    public TimeSpanMinutesOrInfiniteConverter() { }
    public override object ConvertFrom(System.ComponentModel.ITypeDescriptorContext ctx, System.Globalization.CultureInfo ci, object data) { return default(object); }
    public override object ConvertTo(System.ComponentModel.ITypeDescriptorContext ctx, System.Globalization.CultureInfo ci, object value, System.Type type) { return default(object); }
  }
  public partial class TimeSpanSecondsConverter : System.Configuration.ConfigurationConverterBase {
    public TimeSpanSecondsConverter() { }
    public override object ConvertFrom(System.ComponentModel.ITypeDescriptorContext ctx, System.Globalization.CultureInfo ci, object data) { return default(object); }
    public override object ConvertTo(System.ComponentModel.ITypeDescriptorContext ctx, System.Globalization.CultureInfo ci, object value, System.Type type) { return default(object); }
  }
  public sealed partial class TimeSpanSecondsOrInfiniteConverter : System.Configuration.TimeSpanSecondsConverter {
    public TimeSpanSecondsOrInfiniteConverter() { }
    public override object ConvertFrom(System.ComponentModel.ITypeDescriptorContext ctx, System.Globalization.CultureInfo ci, object data) { return default(object); }
    public override object ConvertTo(System.ComponentModel.ITypeDescriptorContext ctx, System.Globalization.CultureInfo ci, object value, System.Type type) { return default(object); }
  }
  public partial class TimeSpanValidator : System.Configuration.ConfigurationValidatorBase {
    public TimeSpanValidator(System.TimeSpan minValue, System.TimeSpan maxValue) { }
    public TimeSpanValidator(System.TimeSpan minValue, System.TimeSpan maxValue, bool rangeIsExclusive) { }
    public TimeSpanValidator(System.TimeSpan minValue, System.TimeSpan maxValue, bool rangeIsExclusive, long resolutionInSeconds) { }
    public override bool CanValidate(System.Type type) { return default(bool); }
    public override void Validate(object value) { }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(128))]
  public sealed partial class TimeSpanValidatorAttribute : System.Configuration.ConfigurationValidatorAttribute {
    public const string TimeSpanMaxValue = "10675199.02:48:05.4775807";
    public const string TimeSpanMinValue = "-10675199.02:48:05.4775808";
    public TimeSpanValidatorAttribute() { }
    public bool ExcludeRange { get { return default(bool); } set { } }
    public System.TimeSpan MaxValue { get { return default(System.TimeSpan); } }
    public string MaxValueString { get { return default(string); } set { } }
    public System.TimeSpan MinValue { get { return default(System.TimeSpan); } }
    public string MinValueString { get { return default(string); } set { } }
    public override System.Configuration.ConfigurationValidatorBase ValidatorInstance { get { return default(System.Configuration.ConfigurationValidatorBase); } }
  }
  public sealed partial class TypeNameConverter : System.Configuration.ConfigurationConverterBase {
    public TypeNameConverter() { }
    public override object ConvertFrom(System.ComponentModel.ITypeDescriptorContext ctx, System.Globalization.CultureInfo ci, object data) { return default(object); }
    public override object ConvertTo(System.ComponentModel.ITypeDescriptorContext ctx, System.Globalization.CultureInfo ci, object value, System.Type type) { return default(object); }
  }
  public delegate void ValidatorCallback(object o);
  public sealed partial class WhiteSpaceTrimStringConverter : System.Configuration.ConfigurationConverterBase {
    public WhiteSpaceTrimStringConverter() { }
    public override object ConvertFrom(System.ComponentModel.ITypeDescriptorContext ctx, System.Globalization.CultureInfo ci, object data) { return default(object); }
    public override object ConvertTo(System.ComponentModel.ITypeDescriptorContext ctx, System.Globalization.CultureInfo ci, object value, System.Type type) { return default(object); }
  }
}
namespace System.Configuration.Internal {
  public partial class DelegatingConfigHost : System.Configuration.Internal.IInternalConfigHost {
    protected DelegatingConfigHost() { }
    protected System.Configuration.Internal.IInternalConfigHost Host { get { return default(System.Configuration.Internal.IInternalConfigHost); } set { } }
    public virtual bool IsRemote { get { return default(bool); } }
    public virtual bool SupportsChangeNotifications { get { return default(bool); } }
    public virtual bool SupportsLocation { get { return default(bool); } }
    public virtual bool SupportsPath { get { return default(bool); } }
    public virtual bool SupportsRefresh { get { return default(bool); } }
    public virtual object CreateConfigurationContext(string configPath, string locationSubPath) { return default(object); }
    public virtual object CreateDeprecatedConfigContext(string configPath) { return default(object); }
    public virtual string DecryptSection(string encryptedXml, System.Configuration.ProtectedConfigurationProvider protectionProvider, System.Configuration.ProtectedConfigurationSection protectedSection) { return default(string); }
    public virtual void DeleteStream(string streamName) { }
    public virtual string EncryptSection(string encryptedXml, System.Configuration.ProtectedConfigurationProvider protectionProvider, System.Configuration.ProtectedConfigurationSection protectedSection) { return default(string); }
    public virtual string GetConfigPathFromLocationSubPath(string configPath, string locatinSubPath) { return default(string); }
    public virtual System.Type GetConfigType(string typeName, bool throwOnError) { return default(System.Type); }
    public virtual string GetConfigTypeName(System.Type t) { return default(string); }
    public virtual void GetRestrictedPermissions(System.Configuration.Internal.IInternalConfigRecord configRecord, out System.Security.PermissionSet permissionSet, out bool isHostReady) { permissionSet = default(System.Security.PermissionSet); isHostReady = default(bool); }
    public virtual string GetStreamName(string configPath) { return default(string); }
    public virtual string GetStreamNameForConfigSource(string streamName, string configSource) { return default(string); }
    public virtual object GetStreamVersion(string streamName) { return default(object); }
    public virtual System.IDisposable Impersonate() { return default(System.IDisposable); }
    public virtual void Init(System.Configuration.Internal.IInternalConfigRoot root, params System.Object[] hostInitParams) { }
    public virtual void InitForConfiguration(ref string locationSubPath, out string configPath, out string locationConfigPath, System.Configuration.Internal.IInternalConfigRoot root, params System.Object[] hostInitConfigurationParams) { configPath = default(string); locationConfigPath = default(string); }
    public virtual bool IsAboveApplication(string configPath) { return default(bool); }
    public virtual bool IsConfigRecordRequired(string configPath) { return default(bool); }
    public virtual bool IsDefinitionAllowed(string configPath, System.Configuration.ConfigurationAllowDefinition allowDefinition, System.Configuration.ConfigurationAllowExeDefinition allowExeDefinition) { return default(bool); }
    public virtual bool IsFile(string streamName) { return default(bool); }
    public virtual bool IsFullTrustSectionWithoutAptcaAllowed(System.Configuration.Internal.IInternalConfigRecord configRecord) { return default(bool); }
    public virtual bool IsInitDelayed(System.Configuration.Internal.IInternalConfigRecord configRecord) { return default(bool); }
    public virtual bool IsLocationApplicable(string configPath) { return default(bool); }
    public virtual bool IsSecondaryRoot(string configPath) { return default(bool); }
    public virtual bool IsTrustedConfigPath(string configPath) { return default(bool); }
    public virtual System.IO.Stream OpenStreamForRead(string streamName) { return default(System.IO.Stream); }
    public virtual System.IO.Stream OpenStreamForRead(string streamName, bool assertPermissions) { return default(System.IO.Stream); }
    public virtual System.IO.Stream OpenStreamForWrite(string streamName, string templateStreamName, ref object writeContext) { return default(System.IO.Stream); }
    public virtual System.IO.Stream OpenStreamForWrite(string streamName, string templateStreamName, ref object writeContext, bool assertPermissions) { return default(System.IO.Stream); }
    public virtual bool PrefetchAll(string configPath, string streamName) { return default(bool); }
    public virtual bool PrefetchSection(string sectionGroupName, string sectionName) { return default(bool); }
    public virtual void RequireCompleteInit(System.Configuration.Internal.IInternalConfigRecord configRecord) { }
    public virtual object StartMonitoringStreamForChanges(string streamName, System.Configuration.Internal.StreamChangeCallback callback) { return default(object); }
    public virtual void StopMonitoringStreamForChanges(string streamName, System.Configuration.Internal.StreamChangeCallback callback) { }
    public virtual void VerifyDefinitionAllowed(string configPath, System.Configuration.ConfigurationAllowDefinition allowDefinition, System.Configuration.ConfigurationAllowExeDefinition allowExeDefinition, System.Configuration.Internal.IConfigErrorInfo errorInfo) { }
    public virtual void WriteCompleted(string streamName, bool success, object writeContext) { }
    public virtual void WriteCompleted(string streamName, bool success, object writeContext, bool assertPermissions) { }
  }
  public partial interface IConfigErrorInfo {
    string Filename { get; }
    int LineNumber { get; }
  }
  public partial interface IConfigSystem {
    System.Configuration.Internal.IInternalConfigHost Host { get; }
    System.Configuration.Internal.IInternalConfigRoot Root { get; }
    void Init(System.Type typeConfigHost, params System.Object[] hostInitParams);
  }
  [System.Runtime.InteropServices.ComVisibleAttribute(false)]
  public partial interface IConfigurationManagerHelper {
    void EnsureNetConfigLoaded();
  }
  [System.Runtime.InteropServices.ComVisibleAttribute(false)]
  public partial interface IConfigurationManagerInternal {
    string ApplicationConfigUri { get; }
    string ExeLocalConfigDirectory { get; }
    string ExeLocalConfigPath { get; }
    string ExeProductName { get; }
    string ExeProductVersion { get; }
    string ExeRoamingConfigDirectory { get; }
    string ExeRoamingConfigPath { get; }
    string MachineConfigPath { get; }
    bool SetConfigurationSystemInProgress { get; }
    bool SupportsUserConfig { get; }
    string UserConfigFilename { get; }
  }
  [System.Runtime.InteropServices.ComVisibleAttribute(false)]
  public partial interface IInternalConfigClientHost {
    string GetExeConfigPath();
    string GetLocalUserConfigPath();
    string GetRoamingUserConfigPath();
    bool IsExeConfig(string configPath);
    bool IsLocalUserConfig(string configPath);
    bool IsRoamingUserConfig(string configPath);
  }
  [System.Runtime.InteropServices.ComVisibleAttribute(false)]
  public partial interface IInternalConfigConfigurationFactory {
    System.Configuration.Configuration Create(System.Type typeConfigHost, params System.Object[] hostInitConfigurationParams);
    string NormalizeLocationSubPath(string subPath, System.Configuration.Internal.IConfigErrorInfo errorInfo);
  }
  [System.Runtime.InteropServices.ComVisibleAttribute(false)]
  public partial interface IInternalConfigHost {
    bool IsRemote { get; }
    bool SupportsChangeNotifications { get; }
    bool SupportsLocation { get; }
    bool SupportsPath { get; }
    bool SupportsRefresh { get; }
    object CreateConfigurationContext(string configPath, string locationSubPath);
    object CreateDeprecatedConfigContext(string configPath);
    string DecryptSection(string encryptedXml, System.Configuration.ProtectedConfigurationProvider protectionProvider, System.Configuration.ProtectedConfigurationSection protectedSection);
    void DeleteStream(string streamName);
    string EncryptSection(string encryptedXml, System.Configuration.ProtectedConfigurationProvider protectionProvider, System.Configuration.ProtectedConfigurationSection protectedSection);
    string GetConfigPathFromLocationSubPath(string configPath, string locatinSubPath);
    System.Type GetConfigType(string typeName, bool throwOnError);
    string GetConfigTypeName(System.Type t);
    void GetRestrictedPermissions(System.Configuration.Internal.IInternalConfigRecord configRecord, out System.Security.PermissionSet permissionSet, out bool isHostReady);
    string GetStreamName(string configPath);
    string GetStreamNameForConfigSource(string streamName, string configSource);
    object GetStreamVersion(string streamName);
    System.IDisposable Impersonate();
    void Init(System.Configuration.Internal.IInternalConfigRoot root, params System.Object[] hostInitParams);
    void InitForConfiguration(ref string locationSubPath, out string configPath, out string locationConfigPath, System.Configuration.Internal.IInternalConfigRoot root, params System.Object[] hostInitConfigurationParams);
    bool IsAboveApplication(string configPath);
    bool IsConfigRecordRequired(string configPath);
    bool IsDefinitionAllowed(string configPath, System.Configuration.ConfigurationAllowDefinition allowDefinition, System.Configuration.ConfigurationAllowExeDefinition allowExeDefinition);
    bool IsFile(string streamName);
    bool IsFullTrustSectionWithoutAptcaAllowed(System.Configuration.Internal.IInternalConfigRecord configRecord);
    bool IsInitDelayed(System.Configuration.Internal.IInternalConfigRecord configRecord);
    bool IsLocationApplicable(string configPath);
    bool IsSecondaryRoot(string configPath);
    bool IsTrustedConfigPath(string configPath);
    System.IO.Stream OpenStreamForRead(string streamName);
    System.IO.Stream OpenStreamForRead(string streamName, bool assertPermissions);
    System.IO.Stream OpenStreamForWrite(string streamName, string templateStreamName, ref object writeContext);
    System.IO.Stream OpenStreamForWrite(string streamName, string templateStreamName, ref object writeContext, bool assertPermissions);
    bool PrefetchAll(string configPath, string streamName);
    bool PrefetchSection(string sectionGroupName, string sectionName);
    void RequireCompleteInit(System.Configuration.Internal.IInternalConfigRecord configRecord);
    object StartMonitoringStreamForChanges(string streamName, System.Configuration.Internal.StreamChangeCallback callback);
    void StopMonitoringStreamForChanges(string streamName, System.Configuration.Internal.StreamChangeCallback callback);
    void VerifyDefinitionAllowed(string configPath, System.Configuration.ConfigurationAllowDefinition allowDefinition, System.Configuration.ConfigurationAllowExeDefinition allowExeDefinition, System.Configuration.Internal.IConfigErrorInfo errorInfo);
    void WriteCompleted(string streamName, bool success, object writeContext);
    void WriteCompleted(string streamName, bool success, object writeContext, bool assertPermissions);
  }
  [System.Runtime.InteropServices.ComVisibleAttribute(false)]
  public partial interface IInternalConfigRecord {
    string ConfigPath { get; }
    bool HasInitErrors { get; }
    string StreamName { get; }
    object GetLkgSection(string configKey);
    object GetSection(string configKey);
    void RefreshSection(string configKey);
    void Remove();
    void ThrowIfInitErrors();
  }
  [System.Runtime.InteropServices.ComVisibleAttribute(false)]
  public partial interface IInternalConfigRoot {
    bool IsDesignTime { get; }
    event System.Configuration.Internal.InternalConfigEventHandler ConfigChanged;
    event System.Configuration.Internal.InternalConfigEventHandler ConfigRemoved;
    System.Configuration.Internal.IInternalConfigRecord GetConfigRecord(string configPath);
    object GetSection(string section, string configPath);
    string GetUniqueConfigPath(string configPath);
    System.Configuration.Internal.IInternalConfigRecord GetUniqueConfigRecord(string configPath);
    void Init(System.Configuration.Internal.IInternalConfigHost host, bool isDesignTime);
    void RemoveConfig(string configPath);
  }
  [System.Runtime.InteropServices.ComVisibleAttribute(false)]
  public partial interface IInternalConfigSettingsFactory {
    void CompleteInit();
    void SetConfigurationSystem(System.Configuration.Internal.IInternalConfigSystem internalConfigSystem, bool initComplete);
  }
  [System.Runtime.InteropServices.ComVisibleAttribute(false)]
  public partial interface IInternalConfigSystem {
    bool SupportsUserConfig { get; }
    object GetSection(string configKey);
    void RefreshConfig(string sectionName);
  }
  public sealed partial class InternalConfigEventArgs : System.EventArgs {
    public InternalConfigEventArgs(string configPath) { }
    public string ConfigPath { get { return default(string); } set { } }
  }
  public delegate void InternalConfigEventHandler(object sender, System.Configuration.Internal.InternalConfigEventArgs e);
  public delegate void StreamChangeCallback(string streamName);
}
namespace System.Configuration.Provider {
  public abstract partial class ProviderBase {
    protected ProviderBase() { }
    public virtual string Description { get { return default(string); } }
    public virtual string Name { get { return default(string); } }
    public virtual void Initialize(string name, System.Collections.Specialized.NameValueCollection config) { }
  }
  public partial class ProviderCollection : System.Collections.ICollection, System.Collections.IEnumerable {
    public ProviderCollection() { }
    public int Count { get { return default(int); } }
    public bool IsSynchronized { get { return default(bool); } }
    public System.Configuration.Provider.ProviderBase this[string name] { get { return default(System.Configuration.Provider.ProviderBase); } }
    public object SyncRoot { get { return default(object); } }
    public virtual void Add(System.Configuration.Provider.ProviderBase provider) { }
    public void Clear() { }
    public void CopyTo(System.Configuration.Provider.ProviderBase[] array, int index) { }
    public System.Collections.IEnumerator GetEnumerator() { return default(System.Collections.IEnumerator); }
    public void Remove(string name) { }
    public void SetReadOnly() { }
    void System.Collections.ICollection.CopyTo(System.Array array, int index) { }
  }
  public partial class ProviderException : System.Exception {
    public ProviderException() { }
    protected ProviderException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public ProviderException(string message) { }
    public ProviderException(string message, System.Exception innerException) { }
  }
}
