namespace System.Windows.Markup {
  [System.AttributeUsageAttribute((System.AttributeTargets)(196), Inherited=true)]
  [System.Runtime.CompilerServices.TypeForwardedFromAttribute("WindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35")]
  public sealed partial class AmbientAttribute : System.Attribute {
    public AmbientAttribute() { }
  }
  [System.Runtime.CompilerServices.TypeForwardedFromAttribute("PresentationFramework, Version=3.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35")]
  [System.Windows.Markup.ContentPropertyAttribute("Items")]
  [System.Windows.Markup.MarkupExtensionReturnTypeAttribute(typeof(System.Array))]
  public partial class ArrayExtension : System.Windows.Markup.MarkupExtension {
    public ArrayExtension() { }
    public ArrayExtension(System.Array elements) { }
    public ArrayExtension(System.Type arrayType) { }
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(2))]
    public System.Collections.IList Items { get { return default(System.Collections.IList); } }
    [System.Windows.Markup.ConstructorArgumentAttribute("arrayType")]
    public System.Type Type { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Type); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public void AddChild(object value) { }
    public void AddText(string text) { }
    public override object ProvideValue(System.IServiceProvider serviceProvider) { return default(object); }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(128), AllowMultiple=false, Inherited=false)]
  [System.Runtime.CompilerServices.TypeForwardedFromAttribute("WindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35")]
  public sealed partial class ConstructorArgumentAttribute : System.Attribute {
    public ConstructorArgumentAttribute(string argumentName) { }
    public string ArgumentName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(4), AllowMultiple=false, Inherited=true)]
  [System.Runtime.CompilerServices.TypeForwardedFromAttribute("WindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35")]
  public sealed partial class ContentPropertyAttribute : System.Attribute {
    public ContentPropertyAttribute() { }
    public ContentPropertyAttribute(string name) { }
    public string Name { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(4), AllowMultiple=true, Inherited=true)]
  [System.Runtime.CompilerServices.TypeForwardedFromAttribute("WindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35")]
  public sealed partial class ContentWrapperAttribute : System.Attribute {
    public ContentWrapperAttribute(System.Type contentWrapper) { }
    public System.Type ContentWrapper { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Type); } }
    public override object TypeId { get { return default(object); } }
    public override bool Equals(object other) { return default(bool); }
    public override int GetHashCode() { return default(int); }
  }
  [System.Runtime.CompilerServices.TypeForwardedFromAttribute("WindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35")]
  public partial class DateTimeValueSerializer : System.Windows.Markup.ValueSerializer {
    public DateTimeValueSerializer() { }
    public override bool CanConvertFromString(string value, System.Windows.Markup.IValueSerializerContext context) { return default(bool); }
    public override bool CanConvertToString(object value, System.Windows.Markup.IValueSerializerContext context) { return default(bool); }
    public override object ConvertFromString(string value, System.Windows.Markup.IValueSerializerContext context) { return default(object); }
    public override string ConvertToString(object value, System.Windows.Markup.IValueSerializerContext context) { return default(string); }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(192), AllowMultiple=true)]
  [System.Runtime.CompilerServices.TypeForwardedFromAttribute("WindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35")]
  public sealed partial class DependsOnAttribute : System.Attribute {
    public DependsOnAttribute(string name) { }
    public string Name { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
    public override object TypeId { get { return default(object); } }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(4), AllowMultiple=false, Inherited=true)]
  [System.Runtime.CompilerServices.TypeForwardedFromAttribute("WindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35")]
  public sealed partial class DictionaryKeyPropertyAttribute : System.Attribute {
    public DictionaryKeyPropertyAttribute(string name) { }
    public string Name { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
  }
  [System.Runtime.CompilerServices.TypeForwardedFromAttribute("WindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35")]
  public partial interface IComponentConnector {
    void Connect(int connectionId, object target);
    void InitializeComponent();
  }
  [System.Runtime.CompilerServices.TypeForwardedFromAttribute("WindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35")]
  public partial interface INameScope {
    object FindName(string name);
    void RegisterName(string name, object scopedElement);
    void UnregisterName(string name);
  }
  public partial interface INameScopeDictionary : System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String, System.Object>>, System.Collections.Generic.IDictionary<System.String, System.Object>, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>, System.Collections.IEnumerable, System.Windows.Markup.INameScope {
  }
  [System.Runtime.CompilerServices.TypeForwardedFromAttribute("PresentationFramework, Version=3.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35")]
  public partial interface IProvideValueTarget {
    object TargetObject { get; }
    object TargetProperty { get; }
  }
  public partial interface IQueryAmbient {
    bool IsAmbientPropertyAvailable(string propertyName);
  }
  [System.Runtime.CompilerServices.TypeForwardedFromAttribute("PresentationCore, Version=3.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35")]
  public partial interface IUriContext {
    System.Uri BaseUri { get; set; }
  }
  [System.Runtime.CompilerServices.TypeForwardedFromAttribute("WindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35")]
  public partial interface IValueSerializerContext : System.ComponentModel.ITypeDescriptorContext, System.IServiceProvider {
    System.Windows.Markup.ValueSerializer GetValueSerializerFor(System.ComponentModel.PropertyDescriptor descriptor);
    System.Windows.Markup.ValueSerializer GetValueSerializerFor(System.Type type);
  }
  [System.Runtime.CompilerServices.TypeForwardedFromAttribute("WindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35")]
  public partial interface IXamlTypeResolver {
    System.Type Resolve(string qualifiedTypeName);
  }
  [System.Runtime.CompilerServices.TypeForwardedFromAttribute("WindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35")]
  public abstract partial class MarkupExtension {
    protected MarkupExtension() { }
    public abstract object ProvideValue(System.IServiceProvider serviceProvider);
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(4), AllowMultiple=false, Inherited=true)]
  public sealed partial class MarkupExtensionReturnTypeAttribute : System.Attribute {
    public MarkupExtensionReturnTypeAttribute() { }
    public MarkupExtensionReturnTypeAttribute(System.Type returnType) { }
    [System.ObsoleteAttribute("Unused. Use MarkupExtensionReturnTypeAttribute(Type) or XamlSetMarkupExtensionAttribute.")]
    public MarkupExtensionReturnTypeAttribute(System.Type returnType, System.Type expressionType) { }
    [System.ObsoleteAttribute("Unused. Use XamlSetMarkupExtensionAttribute functionality instead.")]
    public System.Type ExpressionType { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Type); } }
    public System.Type ReturnType { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Type); } }
  }
  public abstract partial class MemberDefinition {
    protected MemberDefinition() { }
    public abstract string Name { get; set; }
  }
  public partial class NameReferenceConverter : System.ComponentModel.TypeConverter {
    public NameReferenceConverter() { }
    public override bool CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType) { return default(bool); }
    public override bool CanConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Type destinationType) { return default(bool); }
    public override object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value) { return default(object); }
    public override object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType) { return default(object); }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(4), AllowMultiple=false, Inherited=true)]
  [System.Runtime.CompilerServices.TypeForwardedFromAttribute("WindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35")]
  public sealed partial class NameScopePropertyAttribute : System.Attribute {
    public NameScopePropertyAttribute(string name) { }
    public NameScopePropertyAttribute(string name, System.Type type) { }
    public string Name { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
    public System.Type Type { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Type); } }
  }
  [System.Runtime.CompilerServices.TypeForwardedFromAttribute("PresentationFramework, Version=3.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35")]
  [System.Windows.Markup.MarkupExtensionReturnTypeAttribute(typeof(object))]
  public partial class NullExtension : System.Windows.Markup.MarkupExtension {
    public NullExtension() { }
    public override object ProvideValue(System.IServiceProvider serviceProvider) { return default(object); }
  }
  public partial class PropertyDefinition : System.Windows.Markup.MemberDefinition {
    public PropertyDefinition() { }
    public System.Collections.Generic.IList<System.Attribute> Attributes { get { return default(System.Collections.Generic.IList<System.Attribute>); } }
    [System.ComponentModel.DefaultValueAttribute("public")]
    public string Modifier { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public override string Name { get { return default(string); } set { } }
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Xaml.Schema.XamlTypeTypeConverter))]
    public System.Xaml.XamlType Type { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Xaml.XamlType); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
  }
  [System.Windows.Markup.ContentPropertyAttribute("Name")]
  public partial class Reference : System.Windows.Markup.MarkupExtension {
    public Reference() { }
    public Reference(string name) { }
    [System.Windows.Markup.ConstructorArgumentAttribute("name")]
    public string Name { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public override object ProvideValue(System.IServiceProvider serviceProvider) { return default(object); }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(1))]
  [System.Runtime.CompilerServices.TypeForwardedFromAttribute("WindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35")]
  public sealed partial class RootNamespaceAttribute : System.Attribute {
    public RootNamespaceAttribute(string nameSpace) { }
    public string Namespace { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(4))]
  [System.Runtime.CompilerServices.TypeForwardedFromAttribute("WindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35")]
  public sealed partial class RuntimeNamePropertyAttribute : System.Attribute {
    public RuntimeNamePropertyAttribute(string name) { }
    public string Name { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
  }
  [System.ComponentModel.TypeConverterAttribute(typeof(System.Windows.Markup.StaticExtensionConverter))]
  [System.Runtime.CompilerServices.TypeForwardedFromAttribute("PresentationFramework, Version=3.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35")]
  [System.Windows.Markup.MarkupExtensionReturnTypeAttribute(typeof(object))]
  public partial class StaticExtension : System.Windows.Markup.MarkupExtension {
    public StaticExtension() { }
    public StaticExtension(string member) { }
    [System.Windows.Markup.ConstructorArgumentAttribute("member")]
    public string Member { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Type MemberType { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Type); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public override object ProvideValue(System.IServiceProvider serviceProvider) { return default(object); }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(4), AllowMultiple=false, Inherited=true)]
  [System.Runtime.CompilerServices.TypeForwardedFromAttribute("WindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35")]
  public sealed partial class TrimSurroundingWhitespaceAttribute : System.Attribute {
    public TrimSurroundingWhitespaceAttribute() { }
  }
  [System.ComponentModel.TypeConverterAttribute(typeof(System.Windows.Markup.TypeExtensionConverter))]
  [System.Runtime.CompilerServices.TypeForwardedFromAttribute("PresentationFramework, Version=3.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35")]
  [System.Windows.Markup.MarkupExtensionReturnTypeAttribute(typeof(System.Type))]
  public partial class TypeExtension : System.Windows.Markup.MarkupExtension {
    public TypeExtension() { }
    public TypeExtension(string typeName) { }
    public TypeExtension(System.Type type) { }
    [System.ComponentModel.DefaultValueAttribute(null)]
    [System.Windows.Markup.ConstructorArgumentAttribute("type")]
    public System.Type Type { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Type); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    public string TypeName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public override object ProvideValue(System.IServiceProvider serviceProvider) { return default(object); }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(4), AllowMultiple=false)]
  [System.Runtime.CompilerServices.TypeForwardedFromAttribute("WindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35")]
  public sealed partial class UidPropertyAttribute : System.Attribute {
    public UidPropertyAttribute(string name) { }
    public string Name { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(4), AllowMultiple=false, Inherited=true)]
  public sealed partial class UsableDuringInitializationAttribute : System.Attribute {
    public UsableDuringInitializationAttribute(bool usable) { }
    public bool Usable { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } }
  }
  [System.Runtime.CompilerServices.TypeForwardedFromAttribute("WindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35")]
  public abstract partial class ValueSerializer {
    protected ValueSerializer() { }
    public virtual bool CanConvertFromString(string value, System.Windows.Markup.IValueSerializerContext context) { return default(bool); }
    public virtual bool CanConvertToString(object value, System.Windows.Markup.IValueSerializerContext context) { return default(bool); }
    public virtual object ConvertFromString(string value, System.Windows.Markup.IValueSerializerContext context) { return default(object); }
    public virtual string ConvertToString(object value, System.Windows.Markup.IValueSerializerContext context) { return default(string); }
    protected System.Exception GetConvertFromException(object value) { return default(System.Exception); }
    protected System.Exception GetConvertToException(object value, System.Type destinationType) { return default(System.Exception); }
    public static System.Windows.Markup.ValueSerializer GetSerializerFor(System.ComponentModel.PropertyDescriptor descriptor) { return default(System.Windows.Markup.ValueSerializer); }
    public static System.Windows.Markup.ValueSerializer GetSerializerFor(System.ComponentModel.PropertyDescriptor descriptor, System.Windows.Markup.IValueSerializerContext context) { return default(System.Windows.Markup.ValueSerializer); }
    public static System.Windows.Markup.ValueSerializer GetSerializerFor(System.Type type) { return default(System.Windows.Markup.ValueSerializer); }
    public static System.Windows.Markup.ValueSerializer GetSerializerFor(System.Type type, System.Windows.Markup.IValueSerializerContext context) { return default(System.Windows.Markup.ValueSerializer); }
    [System.Diagnostics.DebuggerHiddenAttribute]
    public virtual System.Collections.Generic.IEnumerable<System.Type> TypeReferences(object value, System.Windows.Markup.IValueSerializerContext context) { return default(System.Collections.Generic.IEnumerable<System.Type>); }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(4), AllowMultiple=false, Inherited=true)]
  [System.Runtime.CompilerServices.TypeForwardedFromAttribute("WindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35")]
  public sealed partial class WhitespaceSignificantCollectionAttribute : System.Attribute {
    public WhitespaceSignificantCollectionAttribute() { }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(132), AllowMultiple=false, Inherited=true)]
  public sealed partial class XamlDeferLoadAttribute : System.Attribute {
    public XamlDeferLoadAttribute(string loaderType, string contentType) { }
    public XamlDeferLoadAttribute(System.Type loaderType, System.Type contentType) { }
    public System.Type ContentType { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Type); } }
    public string ContentTypeName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
    public System.Type LoaderType { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Type); } }
    public string LoaderTypeName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(4), Inherited=true, AllowMultiple=false)]
  public sealed partial class XamlSetMarkupExtensionAttribute : System.Attribute {
    public XamlSetMarkupExtensionAttribute(string xamlSetMarkupExtensionHandler) { }
    public string XamlSetMarkupExtensionHandler { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
  }
  public partial class XamlSetMarkupExtensionEventArgs : System.Windows.Markup.XamlSetValueEventArgs {
    public XamlSetMarkupExtensionEventArgs(System.Xaml.XamlMember member, System.Windows.Markup.MarkupExtension value, System.IServiceProvider serviceProvider) : base (default(System.Xaml.XamlMember), default(object)) { }
    public System.Windows.Markup.MarkupExtension MarkupExtension { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Windows.Markup.MarkupExtension); } }
    public System.IServiceProvider ServiceProvider { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.IServiceProvider); } }
    public override void CallBase() { }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(4), Inherited=true, AllowMultiple=false)]
  public sealed partial class XamlSetTypeConverterAttribute : System.Attribute {
    public XamlSetTypeConverterAttribute(string xamlSetTypeConverterHandler) { }
    public string XamlSetTypeConverterHandler { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
  }
  public partial class XamlSetTypeConverterEventArgs : System.Windows.Markup.XamlSetValueEventArgs {
    public XamlSetTypeConverterEventArgs(System.Xaml.XamlMember member, System.ComponentModel.TypeConverter typeConverter, object value, System.ComponentModel.ITypeDescriptorContext serviceProvider, System.Globalization.CultureInfo cultureInfo) : base (default(System.Xaml.XamlMember), default(object)) { }
    public System.Globalization.CultureInfo CultureInfo { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Globalization.CultureInfo); } }
    public System.ComponentModel.ITypeDescriptorContext ServiceProvider { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.ComponentModel.ITypeDescriptorContext); } }
    public System.ComponentModel.TypeConverter TypeConverter { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.ComponentModel.TypeConverter); } }
    public override void CallBase() { }
  }
  public partial class XamlSetValueEventArgs : System.EventArgs {
    public XamlSetValueEventArgs(System.Xaml.XamlMember member, object value) { }
    public bool Handled { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Xaml.XamlMember Member { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Xaml.XamlMember); } }
    public object Value { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(object); } }
    public virtual void CallBase() { }
  }
  [System.Windows.Markup.ContentPropertyAttribute("Text")]
  public sealed partial class XData {
    public XData() { }
    public string Text { get { return default(string); } set { } }
    public object XmlReader { get { return default(object); } set { } }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(4), AllowMultiple=false)]
  [System.Runtime.CompilerServices.TypeForwardedFromAttribute("WindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35")]
  public sealed partial class XmlLangPropertyAttribute : System.Attribute {
    public XmlLangPropertyAttribute(string name) { }
    public string Name { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(1), AllowMultiple=true)]
  [System.Runtime.CompilerServices.TypeForwardedFromAttribute("WindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35")]
  public sealed partial class XmlnsCompatibleWithAttribute : System.Attribute {
    public XmlnsCompatibleWithAttribute(string oldNamespace, string newNamespace) { }
    public string NewNamespace { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
    public string OldNamespace { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(1), AllowMultiple=true)]
  [System.Runtime.CompilerServices.TypeForwardedFromAttribute("WindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35")]
  public sealed partial class XmlnsDefinitionAttribute : System.Attribute {
    public XmlnsDefinitionAttribute(string xmlNamespace, string clrNamespace) { }
    public string AssemblyName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public string ClrNamespace { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
    public string XmlNamespace { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(1), AllowMultiple=true)]
  [System.Runtime.CompilerServices.TypeForwardedFromAttribute("WindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35")]
  public sealed partial class XmlnsPrefixAttribute : System.Attribute {
    public XmlnsPrefixAttribute(string xmlNamespace, string prefix) { }
    public string Prefix { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
    public string XmlNamespace { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
  }
}
namespace System.Xaml {
  public partial class AmbientPropertyValue {
    public AmbientPropertyValue(System.Xaml.XamlMember property, object value) { }
    public System.Xaml.XamlMember RetrievedProperty { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Xaml.XamlMember); } }
    public object Value { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(object); } }
  }
  public partial class AttachableMemberIdentifier : System.IEquatable<System.Xaml.AttachableMemberIdentifier> {
    public AttachableMemberIdentifier(System.Type declaringType, string memberName) { }
    public System.Type DeclaringType { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Type); } }
    public string MemberName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
    public override bool Equals(object obj) { return default(bool); }
    public bool Equals(System.Xaml.AttachableMemberIdentifier other) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public static bool operator ==(System.Xaml.AttachableMemberIdentifier left, System.Xaml.AttachableMemberIdentifier right) { return default(bool); }
    public static bool operator !=(System.Xaml.AttachableMemberIdentifier left, System.Xaml.AttachableMemberIdentifier right) { return default(bool); }
    public override string ToString() { return default(string); }
  }
  public static partial class AttachablePropertyServices {
    public static void CopyPropertiesTo(object instance, System.Collections.Generic.KeyValuePair<System.Xaml.AttachableMemberIdentifier, System.Object>[] array, int index) { }
    public static int GetAttachedPropertyCount(object instance) { return default(int); }
    public static bool RemoveProperty(object instance, System.Xaml.AttachableMemberIdentifier name) { return default(bool); }
    public static void SetProperty(object instance, System.Xaml.AttachableMemberIdentifier name, object value) { }
    public static bool TryGetProperty(object instance, System.Xaml.AttachableMemberIdentifier name, out object value) { value = default(object); return default(bool); }
    public static bool TryGetProperty<T>(object instance, System.Xaml.AttachableMemberIdentifier name, out T value) { value = default(T); return default(bool); }
  }
  public partial interface IAmbientProvider {
    System.Collections.Generic.IEnumerable<System.Xaml.AmbientPropertyValue> GetAllAmbientValues(System.Collections.Generic.IEnumerable<System.Xaml.XamlType> ceilingTypes, bool searchLiveStackOnly, System.Collections.Generic.IEnumerable<System.Xaml.XamlType> types, params System.Xaml.XamlMember[] properties);
    System.Collections.Generic.IEnumerable<System.Xaml.AmbientPropertyValue> GetAllAmbientValues(System.Collections.Generic.IEnumerable<System.Xaml.XamlType> ceilingTypes, params System.Xaml.XamlMember[] properties);
    System.Collections.Generic.IEnumerable<System.Object> GetAllAmbientValues(params System.Xaml.XamlType[] types);
    System.Xaml.AmbientPropertyValue GetFirstAmbientValue(System.Collections.Generic.IEnumerable<System.Xaml.XamlType> ceilingTypes, params System.Xaml.XamlMember[] properties);
    object GetFirstAmbientValue(params System.Xaml.XamlType[] types);
  }
  public partial interface IAttachedPropertyStore {
    int PropertyCount { get; }
    void CopyPropertiesTo(System.Collections.Generic.KeyValuePair<System.Xaml.AttachableMemberIdentifier, System.Object>[] array, int index);
    bool RemoveProperty(System.Xaml.AttachableMemberIdentifier attachableMemberIdentifier);
    void SetProperty(System.Xaml.AttachableMemberIdentifier attachableMemberIdentifier, object value);
    bool TryGetProperty(System.Xaml.AttachableMemberIdentifier attachableMemberIdentifier, out object value);
  }
  public partial interface IDestinationTypeProvider {
    System.Type GetDestinationType();
  }
  public partial interface INamespacePrefixLookup {
    string LookupPrefix(string ns);
  }
  public partial interface IRootObjectProvider {
    object RootObject { get; }
  }
  public partial interface IXamlIndexingReader {
    int Count { get; }
    int CurrentIndex { get; set; }
  }
  public partial interface IXamlLineInfo {
    bool HasLineInfo { get; }
    int LineNumber { get; }
    int LinePosition { get; }
  }
  public partial interface IXamlLineInfoConsumer {
    bool ShouldProvideLineInfo { get; }
    void SetLineInfo(int lineNumber, int linePosition);
  }
  public partial interface IXamlNameProvider {
    string GetName(object value);
  }
  public partial interface IXamlNameResolver {
    bool IsFixupTokenAvailable { get; }
    event System.EventHandler OnNameScopeInitializationComplete;
    System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>> GetAllNamesAndValuesInScope();
    object GetFixupToken(System.Collections.Generic.IEnumerable<System.String> names);
    object GetFixupToken(System.Collections.Generic.IEnumerable<System.String> names, bool canAssignDirectly);
    object Resolve(string name);
    object Resolve(string name, out bool isFullyInitialized);
  }
  public partial interface IXamlNamespaceResolver {
    string GetNamespace(string prefix);
    System.Collections.Generic.IEnumerable<System.Xaml.NamespaceDeclaration> GetNamespacePrefixes();
  }
  public partial interface IXamlObjectWriterFactory {
    System.Xaml.XamlObjectWriterSettings GetParentSettings();
    System.Xaml.XamlObjectWriter GetXamlObjectWriter(System.Xaml.XamlObjectWriterSettings settings);
  }
  public partial interface IXamlSchemaContextProvider {
    System.Xaml.XamlSchemaContext SchemaContext { get; }
  }
  public partial class NamespaceDeclaration {
    public NamespaceDeclaration(string ns, string prefix) { }
    public string Namespace { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
    public string Prefix { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
  }
  public partial class XamlBackgroundReader : System.Xaml.XamlReader, System.Xaml.IXamlLineInfo {
    public XamlBackgroundReader(System.Xaml.XamlReader wrappedReader) { }
    public bool HasLineInfo { get { return default(bool); } }
    public override bool IsEof { get { return default(bool); } }
    public int LineNumber { get { return default(int); } }
    [System.MonoTODOAttribute("always returns 0")]
    public int LinePosition { get { return default(int); } }
    public override System.Xaml.XamlMember Member { get { return default(System.Xaml.XamlMember); } }
    public override System.Xaml.NamespaceDeclaration Namespace { get { return default(System.Xaml.NamespaceDeclaration); } }
    public override System.Xaml.XamlNodeType NodeType { get { return default(System.Xaml.XamlNodeType); } }
    public override System.Xaml.XamlSchemaContext SchemaContext { get { return default(System.Xaml.XamlSchemaContext); } }
    public override System.Xaml.XamlType Type { get { return default(System.Xaml.XamlType); } }
    public override object Value { get { return default(object); } }
    protected override void Dispose(bool disposing) { }
    public override bool Read() { return default(bool); }
    public void StartThread() { }
    public void StartThread(string threadName) { }
  }
  public abstract partial class XamlDeferringLoader {
    protected XamlDeferringLoader() { }
    public abstract object Load(System.Xaml.XamlReader xamlReader, System.IServiceProvider serviceProvider);
    public abstract System.Xaml.XamlReader Save(object value, System.IServiceProvider serviceProvider);
  }
  public partial class XamlDirective : System.Xaml.XamlMember {
    public XamlDirective(System.Collections.Generic.IEnumerable<System.String> xamlNamespaces, string name, System.Xaml.XamlType xamlType, System.Xaml.Schema.XamlValueConverter<System.ComponentModel.TypeConverter> typeConverter, System.Xaml.Schema.AllowedMemberLocations allowedLocation) : base (default(System.Reflection.EventInfo), default(System.Xaml.XamlSchemaContext)) { }
    public XamlDirective(string xamlNamespace, string name) : base (default(System.Reflection.EventInfo), default(System.Xaml.XamlSchemaContext)) { }
    public System.Xaml.Schema.AllowedMemberLocations AllowedLocation { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Xaml.Schema.AllowedMemberLocations); } }
    public override int GetHashCode() { return default(int); }
    public override System.Collections.Generic.IList<System.String> GetXamlNamespaces() { return default(System.Collections.Generic.IList<System.String>); }
    protected sealed override System.Reflection.ICustomAttributeProvider LookupCustomAttributeProvider() { return default(System.Reflection.ICustomAttributeProvider); }
    protected sealed override System.Xaml.Schema.XamlValueConverter<System.Xaml.XamlDeferringLoader> LookupDeferringLoader() { return default(System.Xaml.Schema.XamlValueConverter<System.Xaml.XamlDeferringLoader>); }
    protected sealed override System.Collections.Generic.IList<System.Xaml.XamlMember> LookupDependsOn() { return default(System.Collections.Generic.IList<System.Xaml.XamlMember>); }
    protected sealed override System.Xaml.Schema.XamlMemberInvoker LookupInvoker() { return default(System.Xaml.Schema.XamlMemberInvoker); }
    protected sealed override bool LookupIsAmbient() { return default(bool); }
    protected sealed override bool LookupIsEvent() { return default(bool); }
    protected sealed override bool LookupIsReadOnly() { return default(bool); }
    protected sealed override bool LookupIsReadPublic() { return default(bool); }
    protected sealed override bool LookupIsUnknown() { return default(bool); }
    protected sealed override bool LookupIsWriteOnly() { return default(bool); }
    protected sealed override bool LookupIsWritePublic() { return default(bool); }
    protected sealed override System.Xaml.XamlType LookupTargetType() { return default(System.Xaml.XamlType); }
    protected sealed override System.Xaml.XamlType LookupType() { return default(System.Xaml.XamlType); }
    protected sealed override System.Xaml.Schema.XamlValueConverter<System.ComponentModel.TypeConverter> LookupTypeConverter() { return default(System.Xaml.Schema.XamlValueConverter<System.ComponentModel.TypeConverter>); }
    protected sealed override System.Reflection.MethodInfo LookupUnderlyingGetter() { return default(System.Reflection.MethodInfo); }
    protected sealed override System.Reflection.MemberInfo LookupUnderlyingMember() { return default(System.Reflection.MemberInfo); }
    protected sealed override System.Reflection.MethodInfo LookupUnderlyingSetter() { return default(System.Reflection.MethodInfo); }
    public override string ToString() { return default(string); }
  }
  public partial class XamlDuplicateMemberException : System.Xaml.XamlException {
    public XamlDuplicateMemberException() { }
    protected XamlDuplicateMemberException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public XamlDuplicateMemberException(string message) { }
    public XamlDuplicateMemberException(string message, System.Exception innerException) { }
    public XamlDuplicateMemberException(System.Xaml.XamlMember member, System.Xaml.XamlType type) { }
    public System.Xaml.XamlMember DuplicateMember { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Xaml.XamlMember); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Xaml.XamlType ParentType { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Xaml.XamlType); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
  }
  public partial class XamlException : System.Exception {
    public XamlException() { }
    protected XamlException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public XamlException(string message) { }
    public XamlException(string message, System.Exception innerException) { }
    public XamlException(string message, System.Exception innerException, int lineNumber, int linePosition) { }
    public int LineNumber { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(int); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]protected internal set { } }
    public int LinePosition { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(int); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]protected internal set { } }
    public override string Message { get { return default(string); } }
    public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
  }
  public partial class XamlInternalException : System.Xaml.XamlException {
    public XamlInternalException() { }
    protected XamlInternalException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public XamlInternalException(string message) { }
    public XamlInternalException(string message, System.Exception innerException) { }
  }
  public static partial class XamlLanguage {
    public const string Xaml2006Namespace = "http://schemas.microsoft.com/winfx/2006/xaml";
    public const string Xml1998Namespace = "http://www.w3.org/XML/1998/namespace";
    public static System.Collections.ObjectModel.ReadOnlyCollection<System.Xaml.XamlDirective> AllDirectives { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.Xaml.XamlDirective>); } }
    public static System.Collections.ObjectModel.ReadOnlyCollection<System.Xaml.XamlType> AllTypes { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.Xaml.XamlType>); } }
    public static System.Xaml.XamlDirective Arguments { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Xaml.XamlDirective); } }
    public static System.Xaml.XamlType Array { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Xaml.XamlType); } }
    public static System.Xaml.XamlDirective AsyncRecords { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Xaml.XamlDirective); } }
    public static System.Xaml.XamlDirective Base { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Xaml.XamlDirective); } }
    public static System.Xaml.XamlType Boolean { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Xaml.XamlType); } }
    public static System.Xaml.XamlType Byte { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Xaml.XamlType); } }
    public static System.Xaml.XamlType Char { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Xaml.XamlType); } }
    public static System.Xaml.XamlDirective Class { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Xaml.XamlDirective); } }
    public static System.Xaml.XamlDirective ClassAttributes { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Xaml.XamlDirective); } }
    public static System.Xaml.XamlDirective ClassModifier { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Xaml.XamlDirective); } }
    public static System.Xaml.XamlDirective Code { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Xaml.XamlDirective); } }
    public static System.Xaml.XamlDirective ConnectionId { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Xaml.XamlDirective); } }
    public static System.Xaml.XamlType Decimal { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Xaml.XamlType); } }
    public static System.Xaml.XamlType Double { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Xaml.XamlType); } }
    public static System.Xaml.XamlDirective FactoryMethod { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Xaml.XamlDirective); } }
    public static System.Xaml.XamlDirective FieldModifier { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Xaml.XamlDirective); } }
    public static System.Xaml.XamlDirective Initialization { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Xaml.XamlDirective); } }
    public static System.Xaml.XamlType Int16 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Xaml.XamlType); } }
    public static System.Xaml.XamlType Int32 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Xaml.XamlType); } }
    public static System.Xaml.XamlType Int64 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Xaml.XamlType); } }
    public static System.Xaml.XamlDirective Items { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Xaml.XamlDirective); } }
    public static System.Xaml.XamlDirective Key { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Xaml.XamlDirective); } }
    public static System.Xaml.XamlDirective Lang { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Xaml.XamlDirective); } }
    public static System.Xaml.XamlType Member { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Xaml.XamlType); } }
    public static System.Xaml.XamlDirective Members { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Xaml.XamlDirective); } }
    public static System.Xaml.XamlDirective Name { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Xaml.XamlDirective); } }
    public static System.Xaml.XamlType Null { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Xaml.XamlType); } }
    public static System.Xaml.XamlType Object { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Xaml.XamlType); } }
    public static System.Xaml.XamlDirective PositionalParameters { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Xaml.XamlDirective); } }
    public static System.Xaml.XamlType Property { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Xaml.XamlType); } }
    public static System.Xaml.XamlType Reference { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Xaml.XamlType); } }
    public static System.Xaml.XamlDirective Shared { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Xaml.XamlDirective); } }
    public static System.Xaml.XamlType Single { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Xaml.XamlType); } }
    public static System.Xaml.XamlDirective Space { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Xaml.XamlDirective); } }
    public static System.Xaml.XamlType Static { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Xaml.XamlType); } }
    public static System.Xaml.XamlType String { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Xaml.XamlType); } }
    public static System.Xaml.XamlDirective Subclass { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Xaml.XamlDirective); } }
    public static System.Xaml.XamlDirective SynchronousMode { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Xaml.XamlDirective); } }
    public static System.Xaml.XamlType TimeSpan { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Xaml.XamlType); } }
    public static System.Xaml.XamlType Type { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Xaml.XamlType); } }
    public static System.Xaml.XamlDirective TypeArguments { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Xaml.XamlDirective); } }
    public static System.Xaml.XamlDirective Uid { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Xaml.XamlDirective); } }
    public static System.Xaml.XamlDirective UnknownContent { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Xaml.XamlDirective); } }
    public static System.Xaml.XamlType Uri { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Xaml.XamlType); } }
    public static System.Collections.Generic.IList<System.String> XamlNamespaces { get { return default(System.Collections.Generic.IList<System.String>); } }
    public static System.Xaml.XamlType XData { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Xaml.XamlType); } }
    public static System.Collections.Generic.IList<System.String> XmlNamespaces { get { return default(System.Collections.Generic.IList<System.String>); } }
  }
  public partial class XamlMember : System.IEquatable<System.Xaml.XamlMember> {
    public XamlMember(System.Reflection.EventInfo eventInfo, System.Xaml.XamlSchemaContext schemaContext) { }
    public XamlMember(System.Reflection.EventInfo eventInfo, System.Xaml.XamlSchemaContext schemaContext, System.Xaml.Schema.XamlMemberInvoker invoker) { }
    public XamlMember(System.Reflection.PropertyInfo propertyInfo, System.Xaml.XamlSchemaContext schemaContext) { }
    public XamlMember(System.Reflection.PropertyInfo propertyInfo, System.Xaml.XamlSchemaContext schemaContext, System.Xaml.Schema.XamlMemberInvoker invoker) { }
    public XamlMember(string attachablePropertyName, System.Reflection.MethodInfo getter, System.Reflection.MethodInfo setter, System.Xaml.XamlSchemaContext schemaContext) { }
    public XamlMember(string attachablePropertyName, System.Reflection.MethodInfo getter, System.Reflection.MethodInfo setter, System.Xaml.XamlSchemaContext schemaContext, System.Xaml.Schema.XamlMemberInvoker invoker) { }
    public XamlMember(string attachableEventName, System.Reflection.MethodInfo adder, System.Xaml.XamlSchemaContext schemaContext) { }
    public XamlMember(string attachableEventName, System.Reflection.MethodInfo adder, System.Xaml.XamlSchemaContext schemaContext, System.Xaml.Schema.XamlMemberInvoker invoker) { }
    public XamlMember(string name, System.Xaml.XamlType declaringType, bool isAttachable) { }
    public System.Xaml.XamlType DeclaringType { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Xaml.XamlType); } }
    public System.Xaml.Schema.XamlValueConverter<System.Xaml.XamlDeferringLoader> DeferringLoader { get { return default(System.Xaml.Schema.XamlValueConverter<System.Xaml.XamlDeferringLoader>); } }
    public System.Collections.Generic.IList<System.Xaml.XamlMember> DependsOn { get { return default(System.Collections.Generic.IList<System.Xaml.XamlMember>); } }
    public System.Xaml.Schema.XamlMemberInvoker Invoker { get { return default(System.Xaml.Schema.XamlMemberInvoker); } }
    public bool IsAmbient { get { return default(bool); } }
    public bool IsAttachable { get { return default(bool); } }
    public bool IsDirective { get { return default(bool); } }
    public bool IsEvent { get { return default(bool); } }
    public bool IsNameValid { get { return default(bool); } }
    public bool IsReadOnly { get { return default(bool); } }
    public bool IsReadPublic { get { return default(bool); } }
    public bool IsUnknown { get { return default(bool); } }
    public bool IsWriteOnly { get { return default(bool); } }
    public bool IsWritePublic { get { return default(bool); } }
    public string Name { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
    public string PreferredXamlNamespace { get { return default(string); } }
    public System.ComponentModel.DesignerSerializationVisibility SerializationVisibility { get { return default(System.ComponentModel.DesignerSerializationVisibility); } }
    public System.Xaml.XamlType TargetType { get { return default(System.Xaml.XamlType); } }
    public System.Xaml.XamlType Type { get { return default(System.Xaml.XamlType); } }
    public System.Xaml.Schema.XamlValueConverter<System.ComponentModel.TypeConverter> TypeConverter { get { return default(System.Xaml.Schema.XamlValueConverter<System.ComponentModel.TypeConverter>); } }
    public System.Reflection.MemberInfo UnderlyingMember { get { return default(System.Reflection.MemberInfo); } }
    public System.Xaml.Schema.XamlValueConverter<System.Windows.Markup.ValueSerializer> ValueSerializer { get { return default(System.Xaml.Schema.XamlValueConverter<System.Windows.Markup.ValueSerializer>); } }
    public override bool Equals(object other) { return default(bool); }
    public bool Equals(System.Xaml.XamlMember other) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public virtual System.Collections.Generic.IList<System.String> GetXamlNamespaces() { return default(System.Collections.Generic.IList<System.String>); }
    protected virtual System.Reflection.ICustomAttributeProvider LookupCustomAttributeProvider() { return default(System.Reflection.ICustomAttributeProvider); }
    protected virtual System.Xaml.Schema.XamlValueConverter<System.Xaml.XamlDeferringLoader> LookupDeferringLoader() { return default(System.Xaml.Schema.XamlValueConverter<System.Xaml.XamlDeferringLoader>); }
    protected virtual System.Collections.Generic.IList<System.Xaml.XamlMember> LookupDependsOn() { return default(System.Collections.Generic.IList<System.Xaml.XamlMember>); }
    protected virtual System.Xaml.Schema.XamlMemberInvoker LookupInvoker() { return default(System.Xaml.Schema.XamlMemberInvoker); }
    protected virtual bool LookupIsAmbient() { return default(bool); }
    protected virtual bool LookupIsEvent() { return default(bool); }
    protected virtual bool LookupIsReadOnly() { return default(bool); }
    protected virtual bool LookupIsReadPublic() { return default(bool); }
    protected virtual bool LookupIsUnknown() { return default(bool); }
    protected virtual bool LookupIsWriteOnly() { return default(bool); }
    protected virtual bool LookupIsWritePublic() { return default(bool); }
    protected virtual System.Xaml.XamlType LookupTargetType() { return default(System.Xaml.XamlType); }
    protected virtual System.Xaml.XamlType LookupType() { return default(System.Xaml.XamlType); }
    protected virtual System.Xaml.Schema.XamlValueConverter<System.ComponentModel.TypeConverter> LookupTypeConverter() { return default(System.Xaml.Schema.XamlValueConverter<System.ComponentModel.TypeConverter>); }
    protected virtual System.Reflection.MethodInfo LookupUnderlyingGetter() { return default(System.Reflection.MethodInfo); }
    protected virtual System.Reflection.MemberInfo LookupUnderlyingMember() { return default(System.Reflection.MemberInfo); }
    protected virtual System.Reflection.MethodInfo LookupUnderlyingSetter() { return default(System.Reflection.MethodInfo); }
    protected virtual System.Xaml.Schema.XamlValueConverter<System.Windows.Markup.ValueSerializer> LookupValueSerializer() { return default(System.Xaml.Schema.XamlValueConverter<System.Windows.Markup.ValueSerializer>); }
    public static bool operator ==(System.Xaml.XamlMember left, System.Xaml.XamlMember right) { return default(bool); }
    public static bool operator !=(System.Xaml.XamlMember left, System.Xaml.XamlMember right) { return default(bool); }
    [System.MonoTODOAttribute("there are some patterns that return different kind of value: e.g. List<int>.Capacity")]
    public override string ToString() { return default(string); }
  }
  public partial class XamlNodeList {
    public XamlNodeList(System.Xaml.XamlSchemaContext schemaContext) { }
    public XamlNodeList(System.Xaml.XamlSchemaContext schemaContext, int size) { }
    public int Count { get { return default(int); } }
    public System.Xaml.XamlWriter Writer { get { return default(System.Xaml.XamlWriter); } }
    public void Clear() { }
    public System.Xaml.XamlReader GetReader() { return default(System.Xaml.XamlReader); }
  }
  public partial class XamlNodeQueue {
    public XamlNodeQueue(System.Xaml.XamlSchemaContext schemaContext) { }
    public int Count { get { return default(int); } }
    public bool IsEmpty { get { return default(bool); } }
    public System.Xaml.XamlReader Reader { get { return default(System.Xaml.XamlReader); } }
    public System.Xaml.XamlWriter Writer { get { return default(System.Xaml.XamlWriter); } }
  }
  public enum XamlNodeType {
    EndMember = 5,
    EndObject = 3,
    GetObject = 2,
    NamespaceDeclaration = 7,
    None = 0,
    StartMember = 4,
    StartObject = 1,
    Value = 6,
  }
  public partial class XamlObjectEventArgs : System.EventArgs {
    public XamlObjectEventArgs(object instance) { }
    public object Instance { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(object); } }
  }
  public partial class XamlObjectReader : System.Xaml.XamlReader {
    public XamlObjectReader(object instance) { }
    public XamlObjectReader(object instance, System.Xaml.XamlObjectReaderSettings settings) { }
    public XamlObjectReader(object instance, System.Xaml.XamlSchemaContext schemaContext) { }
    public XamlObjectReader(object instance, System.Xaml.XamlSchemaContext schemaContext, System.Xaml.XamlObjectReaderSettings settings) { }
    public virtual object Instance { get { return default(object); } }
    public override bool IsEof { get { return default(bool); } }
    public override System.Xaml.XamlMember Member { get { return default(System.Xaml.XamlMember); } }
    public override System.Xaml.NamespaceDeclaration Namespace { get { return default(System.Xaml.NamespaceDeclaration); } }
    public override System.Xaml.XamlNodeType NodeType { get { return default(System.Xaml.XamlNodeType); } }
    public override System.Xaml.XamlSchemaContext SchemaContext { get { return default(System.Xaml.XamlSchemaContext); } }
    public override System.Xaml.XamlType Type { get { return default(System.Xaml.XamlType); } }
    public override object Value { get { return default(object); } }
    public override bool Read() { return default(bool); }
  }
  public partial class XamlObjectReaderException : System.Xaml.XamlException {
    public XamlObjectReaderException() { }
    protected XamlObjectReaderException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public XamlObjectReaderException(string message) { }
    public XamlObjectReaderException(string message, System.Exception innerException) { }
  }
  public partial class XamlObjectReaderSettings : System.Xaml.XamlReaderSettings {
    public XamlObjectReaderSettings() { }
    public bool RequireExplicitContentVisibility { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
  }
  public partial class XamlObjectWriter : System.Xaml.XamlWriter, System.Xaml.IXamlLineInfoConsumer {
    public XamlObjectWriter(System.Xaml.XamlSchemaContext schemaContext) { }
    public XamlObjectWriter(System.Xaml.XamlSchemaContext schemaContext, System.Xaml.XamlObjectWriterSettings settings) { }
    public virtual object Result { get { return default(object); } }
    public System.Windows.Markup.INameScope RootNameScope { get { return default(System.Windows.Markup.INameScope); } }
    public override System.Xaml.XamlSchemaContext SchemaContext { get { return default(System.Xaml.XamlSchemaContext); } }
    public bool ShouldProvideLineInfo { get { return default(bool); } }
    public void Clear() { }
    protected override void Dispose(bool disposing) { }
    protected internal virtual void OnAfterBeginInit(object value) { }
    protected internal virtual void OnAfterEndInit(object value) { }
    protected internal virtual void OnAfterProperties(object value) { }
    protected internal virtual void OnBeforeProperties(object value) { }
    protected internal virtual bool OnSetValue(object eventSender, System.Xaml.XamlMember member, object value) { return default(bool); }
    public void SetLineInfo(int lineNumber, int linePosition) { }
    public override void WriteEndMember() { }
    public override void WriteEndObject() { }
    public override void WriteGetObject() { }
    public override void WriteNamespace(System.Xaml.NamespaceDeclaration namespaceDeclaration) { }
    public override void WriteStartMember(System.Xaml.XamlMember property) { }
    public override void WriteStartObject(System.Xaml.XamlType xamlType) { }
    public override void WriteValue(object value) { }
  }
  public partial class XamlObjectWriterException : System.Xaml.XamlException {
    public XamlObjectWriterException() { }
    protected XamlObjectWriterException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public XamlObjectWriterException(string message) { }
    public XamlObjectWriterException(string message, System.Exception innerException) { }
  }
  public partial class XamlObjectWriterSettings : System.Xaml.XamlWriterSettings {
    public XamlObjectWriterSettings() { }
    public XamlObjectWriterSettings(System.Xaml.XamlObjectWriterSettings settings) { }
    [System.MonoTODOAttribute("Ignored")]
    public System.Xaml.Permissions.XamlAccessLevel AccessLevel { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Xaml.Permissions.XamlAccessLevel); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.EventHandler<System.Xaml.XamlObjectEventArgs> AfterBeginInitHandler { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.EventHandler<System.Xaml.XamlObjectEventArgs>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.EventHandler<System.Xaml.XamlObjectEventArgs> AfterEndInitHandler { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.EventHandler<System.Xaml.XamlObjectEventArgs>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.EventHandler<System.Xaml.XamlObjectEventArgs> AfterPropertiesHandler { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.EventHandler<System.Xaml.XamlObjectEventArgs>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.EventHandler<System.Xaml.XamlObjectEventArgs> BeforePropertiesHandler { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.EventHandler<System.Xaml.XamlObjectEventArgs>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Windows.Markup.INameScope ExternalNameScope { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Windows.Markup.INameScope); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.MonoTODOAttribute("Ignored")]
    public bool IgnoreCanConvert { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.MonoTODOAttribute("Ignored")]
    public bool PreferUnconvertedDictionaryKeys { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public bool RegisterNamesOnExternalNamescope { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public object RootObjectInstance { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(object); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.MonoTODOAttribute("Ignored")]
    public bool SkipDuplicatePropertyCheck { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.MonoTODOAttribute("Ignored")]
    public bool SkipProvideValueOnRoot { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.EventHandler<System.Windows.Markup.XamlSetValueEventArgs> XamlSetValueHandler { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.EventHandler<System.Windows.Markup.XamlSetValueEventArgs>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
  }
  public partial class XamlParseException : System.Xaml.XamlException {
    public XamlParseException() { }
    protected XamlParseException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public XamlParseException(string message) { }
    public XamlParseException(string message, System.Exception innerException) { }
  }
  public abstract partial class XamlReader : System.IDisposable {
    protected XamlReader() { }
    protected bool IsDisposed { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } }
    public abstract bool IsEof { get; }
    public abstract System.Xaml.XamlMember Member { get; }
    public abstract System.Xaml.NamespaceDeclaration Namespace { get; }
    public abstract System.Xaml.XamlNodeType NodeType { get; }
    public abstract System.Xaml.XamlSchemaContext SchemaContext { get; }
    public abstract System.Xaml.XamlType Type { get; }
    public abstract object Value { get; }
    public void Close() { }
    protected virtual void Dispose(bool disposing) { }
    public abstract bool Read();
    public virtual System.Xaml.XamlReader ReadSubtree() { return default(System.Xaml.XamlReader); }
    public virtual void Skip() { }
    void System.IDisposable.Dispose() { }
  }
  public partial class XamlReaderSettings {
    public XamlReaderSettings() { }
    public XamlReaderSettings(System.Xaml.XamlReaderSettings settings) { }
    public bool AllowProtectedMembersOnRoot { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Uri BaseUri { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Uri); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public bool IgnoreUidsOnPropertyElements { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Reflection.Assembly LocalAssembly { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Reflection.Assembly); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public bool ProvideLineInfo { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public bool ValuesMustBeString { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
  }
  public partial class XamlSchemaContext {
    public XamlSchemaContext() { }
    public XamlSchemaContext(System.Collections.Generic.IEnumerable<System.Reflection.Assembly> referenceAssemblies) { }
    public XamlSchemaContext(System.Collections.Generic.IEnumerable<System.Reflection.Assembly> referenceAssemblies, System.Xaml.XamlSchemaContextSettings settings) { }
    public XamlSchemaContext(System.Xaml.XamlSchemaContextSettings settings) { }
    public bool FullyQualifyAssemblyNamesInClrNamespaces { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } }
    public System.Collections.Generic.IList<System.Reflection.Assembly> ReferenceAssemblies { get { return default(System.Collections.Generic.IList<System.Reflection.Assembly>); } }
    public bool SupportMarkupExtensionsWithDuplicateArity { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } }
    ~XamlSchemaContext() { }
    public virtual System.Collections.Generic.IEnumerable<System.String> GetAllXamlNamespaces() { return default(System.Collections.Generic.IEnumerable<System.String>); }
    public virtual System.Collections.Generic.ICollection<System.Xaml.XamlType> GetAllXamlTypes(string xamlNamespace) { return default(System.Collections.Generic.ICollection<System.Xaml.XamlType>); }
    public virtual string GetPreferredPrefix(string xmlns) { return default(string); }
    protected internal System.Xaml.Schema.XamlValueConverter<TConverterBase> GetValueConverter<TConverterBase>(System.Type converterType, System.Xaml.XamlType targetType) where TConverterBase : class { return default(System.Xaml.Schema.XamlValueConverter<TConverterBase>); }
    public virtual System.Xaml.XamlDirective GetXamlDirective(string xamlNamespace, string name) { return default(System.Xaml.XamlDirective); }
    protected internal virtual System.Xaml.XamlType GetXamlType(string xamlNamespace, string name, params System.Xaml.XamlType[] typeArguments) { return default(System.Xaml.XamlType); }
    public virtual System.Xaml.XamlType GetXamlType(System.Type type) { return default(System.Xaml.XamlType); }
    public System.Xaml.XamlType GetXamlType(System.Xaml.Schema.XamlTypeName xamlTypeName) { return default(System.Xaml.XamlType); }
    protected internal virtual System.Reflection.Assembly OnAssemblyResolve(string assemblyName) { return default(System.Reflection.Assembly); }
    public virtual bool TryGetCompatibleXamlNamespace(string xamlNamespace, out string compatibleNamespace) { compatibleNamespace = default(string); return default(bool); }
  }
  public partial class XamlSchemaContextSettings {
    public XamlSchemaContextSettings() { }
    public XamlSchemaContextSettings(System.Xaml.XamlSchemaContextSettings settings) { }
    public bool FullyQualifyAssemblyNamesInClrNamespaces { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public bool SupportMarkupExtensionsWithDuplicateArity { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
  }
  public partial class XamlSchemaException : System.Xaml.XamlException {
    public XamlSchemaException() { }
    protected XamlSchemaException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public XamlSchemaException(string message) { }
    public XamlSchemaException(string message, System.Exception innerException) { }
  }
  public static partial class XamlServices {
    public static object Load(System.IO.Stream stream) { return default(object); }
    public static object Load(System.IO.TextReader textReader) { return default(object); }
    public static object Load(string fileName) { return default(object); }
    public static object Load(System.Xaml.XamlReader xamlReader) { return default(object); }
    public static object Load(System.Xml.XmlReader xmlReader) { return default(object); }
    public static object Parse(string xaml) { return default(object); }
    public static void Save(System.IO.Stream stream, object instance) { }
    public static void Save(System.IO.TextWriter textWriter, object instance) { }
    public static string Save(object instance) { return default(string); }
    public static void Save(string fileName, object instance) { }
    public static void Save(System.Xaml.XamlWriter xamlWriter, object instance) { }
    public static void Save(System.Xml.XmlWriter xmlWriter, object instance) { }
    public static void Transform(System.Xaml.XamlReader xamlReader, System.Xaml.XamlWriter xamlWriter) { }
    public static void Transform(System.Xaml.XamlReader xamlReader, System.Xaml.XamlWriter xamlWriter, bool closeWriter) { }
  }
  public partial class XamlType : System.IEquatable<System.Xaml.XamlType> {
    protected XamlType(string typeName, System.Collections.Generic.IList<System.Xaml.XamlType> typeArguments, System.Xaml.XamlSchemaContext schemaContext) { }
    public XamlType(string unknownTypeNamespace, string unknownTypeName, System.Collections.Generic.IList<System.Xaml.XamlType> typeArguments, System.Xaml.XamlSchemaContext schemaContext) { }
    public XamlType(System.Type underlyingType, System.Xaml.XamlSchemaContext schemaContext) { }
    public XamlType(System.Type underlyingType, System.Xaml.XamlSchemaContext schemaContext, System.Xaml.Schema.XamlTypeInvoker invoker) { }
    public System.Collections.Generic.IList<System.Xaml.XamlType> AllowedContentTypes { get { return default(System.Collections.Generic.IList<System.Xaml.XamlType>); } }
    public System.Xaml.XamlType BaseType { get { return default(System.Xaml.XamlType); } }
    public bool ConstructionRequiresArguments { get { return default(bool); } }
    public System.Xaml.XamlMember ContentProperty { get { return default(System.Xaml.XamlMember); } }
    public System.Collections.Generic.IList<System.Xaml.XamlType> ContentWrappers { get { return default(System.Collections.Generic.IList<System.Xaml.XamlType>); } }
    public System.Xaml.Schema.XamlValueConverter<System.Xaml.XamlDeferringLoader> DeferringLoader { get { return default(System.Xaml.Schema.XamlValueConverter<System.Xaml.XamlDeferringLoader>); } }
    public System.Xaml.Schema.XamlTypeInvoker Invoker { get { return default(System.Xaml.Schema.XamlTypeInvoker); } }
    public bool IsAmbient { get { return default(bool); } }
    public bool IsArray { get { return default(bool); } }
    public bool IsCollection { get { return default(bool); } }
    public bool IsConstructible { get { return default(bool); } }
    public bool IsDictionary { get { return default(bool); } }
    public bool IsGeneric { get { return default(bool); } }
    public bool IsMarkupExtension { get { return default(bool); } }
    public bool IsNameScope { get { return default(bool); } }
    public bool IsNameValid { get { return default(bool); } }
    public bool IsNullable { get { return default(bool); } }
    public bool IsPublic { get { return default(bool); } }
    public bool IsUnknown { get { return default(bool); } }
    public bool IsUsableDuringInitialization { get { return default(bool); } }
    public bool IsWhitespaceSignificantCollection { get { return default(bool); } }
    public bool IsXData { get { return default(bool); } }
    public System.Xaml.XamlType ItemType { get { return default(System.Xaml.XamlType); } }
    public System.Xaml.XamlType KeyType { get { return default(System.Xaml.XamlType); } }
    public System.Xaml.XamlType MarkupExtensionReturnType { get { return default(System.Xaml.XamlType); } }
    public string Name { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
    public string PreferredXamlNamespace { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
    public System.Xaml.XamlSchemaContext SchemaContext { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Xaml.XamlSchemaContext); } }
    public bool TrimSurroundingWhitespace { get { return default(bool); } }
    public System.Collections.Generic.IList<System.Xaml.XamlType> TypeArguments { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Collections.Generic.IList<System.Xaml.XamlType>); } }
    public System.Xaml.Schema.XamlValueConverter<System.ComponentModel.TypeConverter> TypeConverter { get { return default(System.Xaml.Schema.XamlValueConverter<System.ComponentModel.TypeConverter>); } }
    public System.Type UnderlyingType { get { return default(System.Type); } }
    public System.Xaml.Schema.XamlValueConverter<System.Windows.Markup.ValueSerializer> ValueSerializer { get { return default(System.Xaml.Schema.XamlValueConverter<System.Windows.Markup.ValueSerializer>); } }
    public virtual bool CanAssignTo(System.Xaml.XamlType xamlType) { return default(bool); }
    public override bool Equals(object obj) { return default(bool); }
    public bool Equals(System.Xaml.XamlType other) { return default(bool); }
    public System.Xaml.XamlMember GetAliasedProperty(System.Xaml.XamlDirective directive) { return default(System.Xaml.XamlMember); }
    public System.Collections.Generic.ICollection<System.Xaml.XamlMember> GetAllAttachableMembers() { return default(System.Collections.Generic.ICollection<System.Xaml.XamlMember>); }
    public System.Collections.Generic.ICollection<System.Xaml.XamlMember> GetAllMembers() { return default(System.Collections.Generic.ICollection<System.Xaml.XamlMember>); }
    public System.Xaml.XamlMember GetAttachableMember(string name) { return default(System.Xaml.XamlMember); }
    public override int GetHashCode() { return default(int); }
    public System.Xaml.XamlMember GetMember(string name) { return default(System.Xaml.XamlMember); }
    public System.Collections.Generic.IList<System.Xaml.XamlType> GetPositionalParameters(int parameterCount) { return default(System.Collections.Generic.IList<System.Xaml.XamlType>); }
    public virtual System.Collections.Generic.IList<System.String> GetXamlNamespaces() { return default(System.Collections.Generic.IList<System.String>); }
    protected virtual System.Xaml.XamlMember LookupAliasedProperty(System.Xaml.XamlDirective directive) { return default(System.Xaml.XamlMember); }
    protected virtual System.Collections.Generic.IEnumerable<System.Xaml.XamlMember> LookupAllAttachableMembers() { return default(System.Collections.Generic.IEnumerable<System.Xaml.XamlMember>); }
    protected virtual System.Collections.Generic.IEnumerable<System.Xaml.XamlMember> LookupAllMembers() { return default(System.Collections.Generic.IEnumerable<System.Xaml.XamlMember>); }
    protected virtual System.Collections.Generic.IList<System.Xaml.XamlType> LookupAllowedContentTypes() { return default(System.Collections.Generic.IList<System.Xaml.XamlType>); }
    protected virtual System.Xaml.XamlMember LookupAttachableMember(string name) { return default(System.Xaml.XamlMember); }
    protected virtual System.Xaml.XamlType LookupBaseType() { return default(System.Xaml.XamlType); }
    protected internal virtual System.Xaml.Schema.XamlCollectionKind LookupCollectionKind() { return default(System.Xaml.Schema.XamlCollectionKind); }
    protected virtual bool LookupConstructionRequiresArguments() { return default(bool); }
    protected virtual System.Xaml.XamlMember LookupContentProperty() { return default(System.Xaml.XamlMember); }
    protected virtual System.Collections.Generic.IList<System.Xaml.XamlType> LookupContentWrappers() { return default(System.Collections.Generic.IList<System.Xaml.XamlType>); }
    protected internal virtual System.Reflection.ICustomAttributeProvider LookupCustomAttributeProvider() { return default(System.Reflection.ICustomAttributeProvider); }
    protected virtual System.Xaml.Schema.XamlValueConverter<System.Xaml.XamlDeferringLoader> LookupDeferringLoader() { return default(System.Xaml.Schema.XamlValueConverter<System.Xaml.XamlDeferringLoader>); }
    protected virtual System.Xaml.Schema.XamlTypeInvoker LookupInvoker() { return default(System.Xaml.Schema.XamlTypeInvoker); }
    protected virtual bool LookupIsAmbient() { return default(bool); }
    protected virtual bool LookupIsConstructible() { return default(bool); }
    protected virtual bool LookupIsMarkupExtension() { return default(bool); }
    protected virtual bool LookupIsNameScope() { return default(bool); }
    protected virtual bool LookupIsNullable() { return default(bool); }
    protected virtual bool LookupIsPublic() { return default(bool); }
    protected virtual bool LookupIsUnknown() { return default(bool); }
    protected virtual bool LookupIsWhitespaceSignificantCollection() { return default(bool); }
    protected virtual bool LookupIsXData() { return default(bool); }
    protected virtual System.Xaml.XamlType LookupItemType() { return default(System.Xaml.XamlType); }
    protected virtual System.Xaml.XamlType LookupKeyType() { return default(System.Xaml.XamlType); }
    protected virtual System.Xaml.XamlType LookupMarkupExtensionReturnType() { return default(System.Xaml.XamlType); }
    protected virtual System.Xaml.XamlMember LookupMember(string name, bool skipReadOnlyCheck) { return default(System.Xaml.XamlMember); }
    protected virtual System.Collections.Generic.IList<System.Xaml.XamlType> LookupPositionalParameters(int parameterCount) { return default(System.Collections.Generic.IList<System.Xaml.XamlType>); }
    protected virtual System.EventHandler<System.Windows.Markup.XamlSetMarkupExtensionEventArgs> LookupSetMarkupExtensionHandler() { return default(System.EventHandler<System.Windows.Markup.XamlSetMarkupExtensionEventArgs>); }
    protected virtual System.EventHandler<System.Windows.Markup.XamlSetTypeConverterEventArgs> LookupSetTypeConverterHandler() { return default(System.EventHandler<System.Windows.Markup.XamlSetTypeConverterEventArgs>); }
    protected virtual bool LookupTrimSurroundingWhitespace() { return default(bool); }
    protected virtual System.Xaml.Schema.XamlValueConverter<System.ComponentModel.TypeConverter> LookupTypeConverter() { return default(System.Xaml.Schema.XamlValueConverter<System.ComponentModel.TypeConverter>); }
    protected virtual System.Type LookupUnderlyingType() { return default(System.Type); }
    protected virtual bool LookupUsableDuringInitialization() { return default(bool); }
    protected virtual System.Xaml.Schema.XamlValueConverter<System.Windows.Markup.ValueSerializer> LookupValueSerializer() { return default(System.Xaml.Schema.XamlValueConverter<System.Windows.Markup.ValueSerializer>); }
    public static bool operator ==(System.Xaml.XamlType left, System.Xaml.XamlType right) { return default(bool); }
    public static bool operator !=(System.Xaml.XamlType left, System.Xaml.XamlType right) { return default(bool); }
    public override string ToString() { return default(string); }
  }
  public abstract partial class XamlWriter : System.IDisposable {
    protected XamlWriter() { }
    protected bool IsDisposed { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } }
    public abstract System.Xaml.XamlSchemaContext SchemaContext { get; }
    public void Close() { }
    protected virtual void Dispose(bool disposing) { }
    void System.IDisposable.Dispose() { }
    public abstract void WriteEndMember();
    public abstract void WriteEndObject();
    public abstract void WriteGetObject();
    public abstract void WriteNamespace(System.Xaml.NamespaceDeclaration namespaceDeclaration);
    public void WriteNode(System.Xaml.XamlReader reader) { }
    public abstract void WriteStartMember(System.Xaml.XamlMember xamlMember);
    public abstract void WriteStartObject(System.Xaml.XamlType type);
    public abstract void WriteValue(object value);
  }
  public partial class XamlWriterSettings {
    public XamlWriterSettings() { }
    public XamlWriterSettings(System.Xaml.XamlWriterSettings settings) { }
  }
  public partial class XamlXmlReader : System.Xaml.XamlReader, System.Xaml.IXamlLineInfo {
    public XamlXmlReader(System.IO.Stream stream) { }
    public XamlXmlReader(System.IO.Stream stream, System.Xaml.XamlSchemaContext schemaContext) { }
    public XamlXmlReader(System.IO.Stream stream, System.Xaml.XamlSchemaContext schemaContext, System.Xaml.XamlXmlReaderSettings settings) { }
    public XamlXmlReader(System.IO.Stream stream, System.Xaml.XamlXmlReaderSettings settings) { }
    public XamlXmlReader(System.IO.TextReader textReader) { }
    public XamlXmlReader(System.IO.TextReader textReader, System.Xaml.XamlSchemaContext schemaContext) { }
    public XamlXmlReader(System.IO.TextReader textReader, System.Xaml.XamlSchemaContext schemaContext, System.Xaml.XamlXmlReaderSettings settings) { }
    public XamlXmlReader(System.IO.TextReader textReader, System.Xaml.XamlXmlReaderSettings settings) { }
    public XamlXmlReader(string fileName) { }
    public XamlXmlReader(string fileName, System.Xaml.XamlSchemaContext schemaContext) { }
    public XamlXmlReader(string fileName, System.Xaml.XamlSchemaContext schemaContext, System.Xaml.XamlXmlReaderSettings settings) { }
    public XamlXmlReader(string fileName, System.Xaml.XamlXmlReaderSettings settings) { }
    public XamlXmlReader(System.Xml.XmlReader xmlReader) { }
    public XamlXmlReader(System.Xml.XmlReader xmlReader, System.Xaml.XamlSchemaContext schemaContext) { }
    public XamlXmlReader(System.Xml.XmlReader xmlReader, System.Xaml.XamlSchemaContext schemaContext, System.Xaml.XamlXmlReaderSettings settings) { }
    public XamlXmlReader(System.Xml.XmlReader xmlReader, System.Xaml.XamlXmlReaderSettings settings) { }
    public bool HasLineInfo { get { return default(bool); } }
    public override bool IsEof { get { return default(bool); } }
    public int LineNumber { get { return default(int); } }
    public int LinePosition { get { return default(int); } }
    public override System.Xaml.XamlMember Member { get { return default(System.Xaml.XamlMember); } }
    public override System.Xaml.NamespaceDeclaration Namespace { get { return default(System.Xaml.NamespaceDeclaration); } }
    public override System.Xaml.XamlNodeType NodeType { get { return default(System.Xaml.XamlNodeType); } }
    public override System.Xaml.XamlSchemaContext SchemaContext { get { return default(System.Xaml.XamlSchemaContext); } }
    public override System.Xaml.XamlType Type { get { return default(System.Xaml.XamlType); } }
    public override object Value { get { return default(object); } }
    public override bool Read() { return default(bool); }
  }
  public partial class XamlXmlReaderSettings : System.Xaml.XamlReaderSettings {
    public XamlXmlReaderSettings() { }
    public XamlXmlReaderSettings(System.Xaml.XamlXmlReaderSettings settings) { }
    public bool CloseInput { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public bool SkipXmlCompatibilityProcessing { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public string XmlLang { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public bool XmlSpacePreserve { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
  }
  public partial class XamlXmlWriter : System.Xaml.XamlWriter {
    public XamlXmlWriter(System.IO.Stream stream, System.Xaml.XamlSchemaContext schemaContext) { }
    public XamlXmlWriter(System.IO.Stream stream, System.Xaml.XamlSchemaContext schemaContext, System.Xaml.XamlXmlWriterSettings settings) { }
    public XamlXmlWriter(System.IO.TextWriter textWriter, System.Xaml.XamlSchemaContext schemaContext) { }
    public XamlXmlWriter(System.IO.TextWriter textWriter, System.Xaml.XamlSchemaContext schemaContext, System.Xaml.XamlXmlWriterSettings settings) { }
    public XamlXmlWriter(System.Xml.XmlWriter xmlWriter, System.Xaml.XamlSchemaContext schemaContext) { }
    public XamlXmlWriter(System.Xml.XmlWriter xmlWriter, System.Xaml.XamlSchemaContext schemaContext, System.Xaml.XamlXmlWriterSettings settings) { }
    public override System.Xaml.XamlSchemaContext SchemaContext { get { return default(System.Xaml.XamlSchemaContext); } }
    public System.Xaml.XamlXmlWriterSettings Settings { get { return default(System.Xaml.XamlXmlWriterSettings); } }
    protected override void Dispose(bool disposing) { }
    public void Flush() { }
    public override void WriteEndMember() { }
    public override void WriteEndObject() { }
    public override void WriteGetObject() { }
    public override void WriteNamespace(System.Xaml.NamespaceDeclaration namespaceDeclaration) { }
    public override void WriteStartMember(System.Xaml.XamlMember property) { }
    public override void WriteStartObject(System.Xaml.XamlType xamlType) { }
    public override void WriteValue(object value) { }
  }
  public partial class XamlXmlWriterException : System.Xaml.XamlException {
    public XamlXmlWriterException() { }
    protected XamlXmlWriterException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public XamlXmlWriterException(string message) { }
    public XamlXmlWriterException(string message, System.Exception innerException) { }
  }
  public partial class XamlXmlWriterSettings : System.Xaml.XamlWriterSettings {
    public XamlXmlWriterSettings() { }
    public bool AssumeValidInput { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public bool CloseOutput { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Xaml.XamlXmlWriterSettings Copy() { return default(System.Xaml.XamlXmlWriterSettings); }
  }
}
namespace System.Xaml.Permissions {
  public partial class XamlAccessLevel {
    internal XamlAccessLevel() { }
    public System.Reflection.AssemblyName AssemblyAccessToAssemblyName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Reflection.AssemblyName); } }
    public string PrivateAccessToTypeName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
    public static System.Xaml.Permissions.XamlAccessLevel AssemblyAccessTo(System.Reflection.Assembly assembly) { return default(System.Xaml.Permissions.XamlAccessLevel); }
    public static System.Xaml.Permissions.XamlAccessLevel AssemblyAccessTo(System.Reflection.AssemblyName assemblyName) { return default(System.Xaml.Permissions.XamlAccessLevel); }
    public static System.Xaml.Permissions.XamlAccessLevel PrivateAccessTo(string assemblyQualifiedTypeName) { return default(System.Xaml.Permissions.XamlAccessLevel); }
    public static System.Xaml.Permissions.XamlAccessLevel PrivateAccessTo(System.Type type) { return default(System.Xaml.Permissions.XamlAccessLevel); }
  }
  public sealed partial class XamlLoadPermission : System.Security.CodeAccessPermission, System.Security.Permissions.IUnrestrictedPermission {
    public XamlLoadPermission(System.Collections.Generic.IEnumerable<System.Xaml.Permissions.XamlAccessLevel> allowedAccess) { }
    public XamlLoadPermission(System.Security.Permissions.PermissionState state) { }
    public XamlLoadPermission(System.Xaml.Permissions.XamlAccessLevel allowedAccess) { }
    public System.Collections.Generic.IList<System.Xaml.Permissions.XamlAccessLevel> AllowedAccess { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Collections.Generic.IList<System.Xaml.Permissions.XamlAccessLevel>); } }
    public override System.Security.IPermission Copy() { return default(System.Security.IPermission); }
    public override void FromXml(System.Security.SecurityElement elem) { }
    public bool Includes(System.Xaml.Permissions.XamlAccessLevel requestedAccess) { return default(bool); }
    public override System.Security.IPermission Intersect(System.Security.IPermission target) { return default(System.Security.IPermission); }
    public override bool IsSubsetOf(System.Security.IPermission target) { return default(bool); }
    public bool IsUnrestricted() { return default(bool); }
    public override System.Security.SecurityElement ToXml() { return default(System.Security.SecurityElement); }
    public override System.Security.IPermission Union(System.Security.IPermission other) { return default(System.Security.IPermission); }
  }
}
namespace System.Xaml.Schema {
  [System.FlagsAttribute]
  public enum AllowedMemberLocations {
    Any = 3,
    Attribute = 1,
    MemberElement = 2,
    None = 0,
  }
  public enum ShouldSerializeResult {
    Default = 0,
    False = 2,
    True = 1,
  }
  public enum XamlCollectionKind {
    Array = 3,
    Collection = 1,
    Dictionary = 2,
    None = 0,
  }
  public partial class XamlMemberInvoker {
    protected XamlMemberInvoker() { }
    public XamlMemberInvoker(System.Xaml.XamlMember member) { }
    public System.Reflection.MethodInfo UnderlyingGetter { get { return default(System.Reflection.MethodInfo); } }
    public System.Reflection.MethodInfo UnderlyingSetter { get { return default(System.Reflection.MethodInfo); } }
    public static System.Xaml.Schema.XamlMemberInvoker UnknownInvoker { get { return default(System.Xaml.Schema.XamlMemberInvoker); } }
    public virtual object GetValue(object instance) { return default(object); }
    public virtual void SetValue(object instance, object value) { }
    public virtual System.Xaml.Schema.ShouldSerializeResult ShouldSerializeValue(object instance) { return default(System.Xaml.Schema.ShouldSerializeResult); }
  }
  public partial class XamlTypeInvoker {
    protected XamlTypeInvoker() { }
    public XamlTypeInvoker(System.Xaml.XamlType type) { }
    public System.EventHandler<System.Windows.Markup.XamlSetMarkupExtensionEventArgs> SetMarkupExtensionHandler { get { return default(System.EventHandler<System.Windows.Markup.XamlSetMarkupExtensionEventArgs>); } }
    public System.EventHandler<System.Windows.Markup.XamlSetTypeConverterEventArgs> SetTypeConverterHandler { get { return default(System.EventHandler<System.Windows.Markup.XamlSetTypeConverterEventArgs>); } }
    public static System.Xaml.Schema.XamlTypeInvoker UnknownInvoker { get { return default(System.Xaml.Schema.XamlTypeInvoker); } }
    public virtual void AddToCollection(object instance, object item) { }
    public virtual void AddToDictionary(object instance, object key, object item) { }
    public virtual object CreateInstance(System.Object[] arguments) { return default(object); }
    public virtual System.Reflection.MethodInfo GetAddMethod(System.Xaml.XamlType contentType) { return default(System.Reflection.MethodInfo); }
    public virtual System.Reflection.MethodInfo GetEnumeratorMethod() { return default(System.Reflection.MethodInfo); }
    public virtual System.Collections.IEnumerator GetItems(object instance) { return default(System.Collections.IEnumerator); }
  }
  public partial class XamlTypeName {
    public XamlTypeName() { }
    public XamlTypeName(string xamlNamespace, string name) { }
    public XamlTypeName(string xamlNamespace, string name, System.Collections.Generic.IEnumerable<System.Xaml.Schema.XamlTypeName> typeArguments) { }
    public XamlTypeName(System.Xaml.XamlType xamlType) { }
    public string Name { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public string Namespace { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Collections.Generic.IList<System.Xaml.Schema.XamlTypeName> TypeArguments { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Collections.Generic.IList<System.Xaml.Schema.XamlTypeName>); } }
    public static System.Xaml.Schema.XamlTypeName Parse(string typeName, System.Xaml.IXamlNamespaceResolver namespaceResolver) { return default(System.Xaml.Schema.XamlTypeName); }
    public static System.Collections.Generic.IList<System.Xaml.Schema.XamlTypeName> ParseList(string typeNameList, System.Xaml.IXamlNamespaceResolver namespaceResolver) { return default(System.Collections.Generic.IList<System.Xaml.Schema.XamlTypeName>); }
    public override string ToString() { return default(string); }
    public static string ToString(System.Collections.Generic.IList<System.Xaml.Schema.XamlTypeName> typeNameList, System.Xaml.INamespacePrefixLookup prefixLookup) { return default(string); }
    public string ToString(System.Xaml.INamespacePrefixLookup prefixLookup) { return default(string); }
    public static bool TryParse(string typeName, System.Xaml.IXamlNamespaceResolver namespaceResolver, out System.Xaml.Schema.XamlTypeName result) { result = default(System.Xaml.Schema.XamlTypeName); return default(bool); }
    public static bool TryParseList(string typeNameList, System.Xaml.IXamlNamespaceResolver namespaceResolver, out System.Collections.Generic.IList<System.Xaml.Schema.XamlTypeName> list) { list = default(System.Collections.Generic.IList<System.Xaml.Schema.XamlTypeName>); return default(bool); }
  }
  public partial class XamlTypeTypeConverter : System.ComponentModel.TypeConverter {
    public XamlTypeTypeConverter() { }
    public override bool CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType) { return default(bool); }
    public override bool CanConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Type destinationType) { return default(bool); }
    public override object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value) { return default(object); }
    public override object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType) { return default(object); }
  }
  public partial class XamlValueConverter<TConverterBase> : System.IEquatable<System.Xaml.Schema.XamlValueConverter<TConverterBase>> where TConverterBase : class {
    public XamlValueConverter(System.Type converterType, System.Xaml.XamlType targetType) { }
    public XamlValueConverter(System.Type converterType, System.Xaml.XamlType targetType, string name) { }
    public TConverterBase ConverterInstance { get { return default(TConverterBase); } }
    public System.Type ConverterType { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Type); } }
    public string Name { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
    public System.Xaml.XamlType TargetType { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Xaml.XamlType); } }
    protected virtual TConverterBase CreateInstance() { return default(TConverterBase); }
    public override bool Equals(object obj) { return default(bool); }
    public bool Equals(System.Xaml.Schema.XamlValueConverter<TConverterBase> other) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public static bool operator ==(System.Xaml.Schema.XamlValueConverter<TConverterBase> left, System.Xaml.Schema.XamlValueConverter<TConverterBase> right) { return default(bool); }
    public static bool operator !=(System.Xaml.Schema.XamlValueConverter<TConverterBase> left, System.Xaml.Schema.XamlValueConverter<TConverterBase> right) { return default(bool); }
    public override string ToString() { return default(string); }
  }
}
