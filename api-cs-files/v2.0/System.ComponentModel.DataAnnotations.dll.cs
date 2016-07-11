namespace System.ComponentModel.DataAnnotations {
  public partial class AssociatedMetadataTypeTypeDescriptionProvider : System.ComponentModel.TypeDescriptionProvider {
    public AssociatedMetadataTypeTypeDescriptionProvider(System.Type type) { }
    public AssociatedMetadataTypeTypeDescriptionProvider(System.Type type, System.Type associatedMetadataType) { }
    public override System.ComponentModel.ICustomTypeDescriptor GetTypeDescriptor(System.Type objectType, object instance) { return default(System.ComponentModel.ICustomTypeDescriptor); }
  }
  public enum DataType {
    Currency = 6,
    Custom = 0,
    Date = 2,
    DateTime = 1,
    Duration = 4,
    EmailAddress = 10,
    Html = 8,
    MultilineText = 9,
    Password = 11,
    PhoneNumber = 5,
    Text = 7,
    Time = 3,
    Url = 12,
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(384), AllowMultiple=false)]
  public partial class DataTypeAttribute : System.ComponentModel.DataAnnotations.ValidationAttribute {
    public DataTypeAttribute(System.ComponentModel.DataAnnotations.DataType dataType) { }
    public DataTypeAttribute(string customDataType) { }
    public string CustomDataType { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
    public System.ComponentModel.DataAnnotations.DataType DataType { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.ComponentModel.DataAnnotations.DataType); } }
    public System.ComponentModel.DataAnnotations.DisplayFormatAttribute DisplayFormat { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.ComponentModel.DataAnnotations.DisplayFormatAttribute); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]protected set { } }
    public virtual string GetDataTypeName() { return default(string); }
    public override bool IsValid(object value) { return default(bool); }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(4), Inherited=true, AllowMultiple=false)]
  public partial class DisplayColumnAttribute : System.Attribute {
    public DisplayColumnAttribute(string displayColumn) { }
    public DisplayColumnAttribute(string displayColumn, string sortColumn) { }
    public DisplayColumnAttribute(string displayColumn, string sortColumn, bool sortDescending) { }
    public string DisplayColumn { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
    public string SortColumn { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
    public bool SortDescending { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(384), AllowMultiple=false)]
  public partial class DisplayFormatAttribute : System.Attribute {
    public DisplayFormatAttribute() { }
    public bool ApplyFormatInEditMode { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public bool ConvertEmptyStringToNull { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public string DataFormatString { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public string NullDisplayText { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(4), AllowMultiple=false)]
  public sealed partial class MetadataTypeAttribute : System.Attribute {
    public MetadataTypeAttribute(System.Type metadataClassType) { }
    public System.Type MetadataClassType { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Type); } }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(384), AllowMultiple=false)]
  public partial class RangeAttribute : System.ComponentModel.DataAnnotations.ValidationAttribute {
    public RangeAttribute(double minimum, double maximum) { }
    public RangeAttribute(int minimum, int maximum) { }
    public RangeAttribute(System.Type type, string minimum, string maximum) { }
    public object Maximum { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(object); } }
    public object Minimum { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(object); } }
    public System.Type OperandType { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Type); } }
    public override string FormatErrorMessage(string name) { return default(string); }
    public override bool IsValid(object value) { return default(bool); }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(384), AllowMultiple=false)]
  public partial class RegularExpressionAttribute : System.ComponentModel.DataAnnotations.ValidationAttribute {
    public RegularExpressionAttribute(string pattern) { }
    public string Pattern { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
    public override string FormatErrorMessage(string name) { return default(string); }
    public override bool IsValid(object value) { return default(bool); }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(384), AllowMultiple=false)]
  public partial class RequiredAttribute : System.ComponentModel.DataAnnotations.ValidationAttribute {
    public RequiredAttribute() { }
    public override bool IsValid(object value) { return default(bool); }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(384), AllowMultiple=false)]
  public partial class ScaffoldColumnAttribute : System.Attribute {
    public ScaffoldColumnAttribute(bool scaffold) { }
    [System.MonoTODOAttribute]
    public bool Scaffold { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(4), AllowMultiple=false)]
  public partial class ScaffoldTableAttribute : System.Attribute {
    public ScaffoldTableAttribute(bool scaffold) { }
    [System.MonoTODOAttribute]
    public bool Scaffold { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(384), AllowMultiple=false)]
  public partial class StringLengthAttribute : System.ComponentModel.DataAnnotations.ValidationAttribute {
    public StringLengthAttribute(int maximumLength) { }
    public int MaximumLength { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(int); } }
    public override string FormatErrorMessage(string name) { return default(string); }
    public override bool IsValid(object value) { return default(bool); }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(384), AllowMultiple=true)]
  public partial class UIHintAttribute : System.Attribute {
    public UIHintAttribute(string uiHint) { }
    public UIHintAttribute(string uiHint, string presentationLayer) { }
    public UIHintAttribute(string uiHint, string presentationLayer, params System.Object[] controlParameters) { }
    public System.Collections.Generic.IDictionary<System.String, System.Object> ControlParameters { get { return default(System.Collections.Generic.IDictionary<System.String, System.Object>); } }
    public string PresentationLayer { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
    public string UIHint { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
    public override bool Equals(object obj) { return default(bool); }
    public override int GetHashCode() { return default(int); }
  }
  public abstract partial class ValidationAttribute : System.Attribute {
    protected ValidationAttribute() { }
    protected ValidationAttribute(System.Func<System.String> errorMessageAccessor) { }
    protected ValidationAttribute(string errorMessage) { }
    public string ErrorMessage { get { return default(string); } set { } }
    public string ErrorMessageResourceName { get { return default(string); } set { } }
    public System.Type ErrorMessageResourceType { get { return default(System.Type); } set { } }
    protected string ErrorMessageString { get { return default(string); } }
    public virtual string FormatErrorMessage(string name) { return default(string); }
    public abstract bool IsValid(object value);
    public void Validate(object value, string name) { }
  }
  public partial class ValidationException : System.Exception {
    public ValidationException() { }
    protected ValidationException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public ValidationException(string message) { }
    public ValidationException(string errorMessage, System.ComponentModel.DataAnnotations.ValidationAttribute validatingAttribute, object value) { }
    public ValidationException(string message, System.Exception innerException) { }
    public System.ComponentModel.DataAnnotations.ValidationAttribute ValidationAttribute { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.ComponentModel.DataAnnotations.ValidationAttribute); } }
    public object Value { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(object); } }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(128))]
    public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
  }
}
