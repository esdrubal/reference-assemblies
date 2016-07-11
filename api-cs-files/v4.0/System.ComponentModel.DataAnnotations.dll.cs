namespace System.ComponentModel.DataAnnotations {
  public partial class AssociatedMetadataTypeTypeDescriptionProvider : System.ComponentModel.TypeDescriptionProvider {
    public AssociatedMetadataTypeTypeDescriptionProvider(System.Type type) { }
    public AssociatedMetadataTypeTypeDescriptionProvider(System.Type type, System.Type associatedMetadataType) { }
    public override System.ComponentModel.ICustomTypeDescriptor GetTypeDescriptor(System.Type objectType, object instance) { return default(System.ComponentModel.ICustomTypeDescriptor); }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(384), AllowMultiple=false, Inherited=true)]
  public sealed partial class AssociationAttribute : System.Attribute {
    public AssociationAttribute(string name, string thisKey, string otherKey) { }
    public bool IsForeignKey { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public string Name { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
    public string OtherKey { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
    public System.Collections.Generic.IEnumerable<System.String> OtherKeyMembers { get { return default(System.Collections.Generic.IEnumerable<System.String>); } }
    public string ThisKey { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
    public System.Collections.Generic.IEnumerable<System.String> ThisKeyMembers { get { return default(System.Collections.Generic.IEnumerable<System.String>); } }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(384), AllowMultiple=false, Inherited=true)]
  public sealed partial class ConcurrencyCheckAttribute : System.Attribute {
    public ConcurrencyCheckAttribute() { }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(2500), AllowMultiple=true)]
  public sealed partial class CustomValidationAttribute : System.ComponentModel.DataAnnotations.ValidationAttribute {
    public CustomValidationAttribute(System.Type validatorType, string method) { }
    public string Method { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
    public override object TypeId { get { return default(object); } }
    public System.Type ValidatorType { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Type); } }
    public override string FormatErrorMessage(string name) { return default(string); }
    protected override System.ComponentModel.DataAnnotations.ValidationResult IsValid(object value, System.ComponentModel.DataAnnotations.ValidationContext validationContext) { return default(System.ComponentModel.DataAnnotations.ValidationResult); }
  }
  public enum DataType {
    Currency = 6,
    Custom = 0,
    Date = 2,
    DateTime = 1,
    Duration = 4,
    EmailAddress = 10,
    Html = 8,
    ImageUrl = 13,
    MultilineText = 9,
    Password = 11,
    PhoneNumber = 5,
    Text = 7,
    Time = 3,
    Url = 12,
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(2496), AllowMultiple=false)]
  public partial class DataTypeAttribute : System.ComponentModel.DataAnnotations.ValidationAttribute {
    public DataTypeAttribute(System.ComponentModel.DataAnnotations.DataType dataType) { }
    public DataTypeAttribute(string customDataType) { }
    public string CustomDataType { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
    public System.ComponentModel.DataAnnotations.DataType DataType { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.ComponentModel.DataAnnotations.DataType); } }
    public System.ComponentModel.DataAnnotations.DisplayFormatAttribute DisplayFormat { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.ComponentModel.DataAnnotations.DisplayFormatAttribute); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]protected set { } }
    public virtual string GetDataTypeName() { return default(string); }
    public override bool IsValid(object value) { return default(bool); }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(2496), AllowMultiple=false)]
  public sealed partial class DisplayAttribute : System.Attribute {
    public DisplayAttribute() { }
    public bool AutoGenerateField { get { return default(bool); } set { } }
    public bool AutoGenerateFilter { get { return default(bool); } set { } }
    public string Description { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public string GroupName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public string Name { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public int Order { get { return default(int); } set { } }
    public string Prompt { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Type ResourceType { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Type); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public string ShortName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Nullable<System.Boolean> GetAutoGenerateField() { return default(System.Nullable<System.Boolean>); }
    public System.Nullable<System.Boolean> GetAutoGenerateFilter() { return default(System.Nullable<System.Boolean>); }
    public string GetDescription() { return default(string); }
    public string GetGroupName() { return default(string); }
    public string GetName() { return default(string); }
    public System.Nullable<System.Int32> GetOrder() { return default(System.Nullable<System.Int32>); }
    public string GetPrompt() { return default(string); }
    public string GetShortName() { return default(string); }
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
    public bool HtmlEncode { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public string NullDisplayText { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(384), AllowMultiple=false, Inherited=true)]
  public sealed partial class EditableAttribute : System.Attribute {
    public EditableAttribute(bool allowEdit) { }
    public bool AllowEdit { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } }
    public bool AllowInitialValue { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(2496), AllowMultiple=false)]
  public sealed partial class EnumDataTypeAttribute : System.ComponentModel.DataAnnotations.DataTypeAttribute {
    public EnumDataTypeAttribute(System.Type enumType) : base (default(System.ComponentModel.DataAnnotations.DataType)) { }
    public System.Type EnumType { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Type); } }
    public override bool IsValid(object value) { return default(bool); }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(384), AllowMultiple=false)]
  public sealed partial class FilterUIHintAttribute : System.Attribute {
    public FilterUIHintAttribute(string filterUIHint) { }
    public FilterUIHintAttribute(string filterUIHint, string presentationLayer) { }
    public FilterUIHintAttribute(string filterUIHint, string presentationLayer, params System.Object[] controlParameters) { }
    public System.Collections.Generic.IDictionary<System.String, System.Object> ControlParameters { get { return default(System.Collections.Generic.IDictionary<System.String, System.Object>); } }
    public string FilterUIHint { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
    public string PresentationLayer { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
    public override object TypeId { get { return default(object); } }
    public override bool Equals(object obj) { return default(bool); }
    public override int GetHashCode() { return default(int); }
  }
  public partial interface IValidatableObject {
    System.Collections.Generic.IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(System.ComponentModel.DataAnnotations.ValidationContext validationContext);
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(384), AllowMultiple=false, Inherited=true)]
  public sealed partial class KeyAttribute : System.Attribute {
    public KeyAttribute() { }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(4), AllowMultiple=false)]
  public sealed partial class MetadataTypeAttribute : System.Attribute {
    public MetadataTypeAttribute(System.Type metadataClassType) { }
    public System.Type MetadataClassType { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Type); } }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(2432), AllowMultiple=false)]
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
  [System.AttributeUsageAttribute((System.AttributeTargets)(2432), AllowMultiple=false)]
  public partial class RegularExpressionAttribute : System.ComponentModel.DataAnnotations.ValidationAttribute {
    public RegularExpressionAttribute(string pattern) { }
    public string Pattern { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
    public override string FormatErrorMessage(string name) { return default(string); }
    public override bool IsValid(object value) { return default(bool); }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(2432), AllowMultiple=false)]
  public partial class RequiredAttribute : System.ComponentModel.DataAnnotations.ValidationAttribute {
    public RequiredAttribute() { }
    public bool AllowEmptyStrings { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
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
  [System.AttributeUsageAttribute((System.AttributeTargets)(2432), AllowMultiple=false)]
  public partial class StringLengthAttribute : System.ComponentModel.DataAnnotations.ValidationAttribute {
    public StringLengthAttribute(int maximumLength) { }
    public int MaximumLength { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(int); } }
    public int MinimumLength { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(int); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public override string FormatErrorMessage(string name) { return default(string); }
    public override bool IsValid(object value) { return default(bool); }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(2432), AllowMultiple=false)]
  public partial class TimestampAttribute : System.Attribute {
    public TimestampAttribute() { }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(384), AllowMultiple=true)]
  public partial class UIHintAttribute : System.Attribute {
    public UIHintAttribute(string uiHint) { }
    public UIHintAttribute(string uiHint, string presentationLayer) { }
    public UIHintAttribute(string uiHint, string presentationLayer, params System.Object[] controlParameters) { }
    public System.Collections.Generic.IDictionary<System.String, System.Object> ControlParameters { get { return default(System.Collections.Generic.IDictionary<System.String, System.Object>); } }
    public string PresentationLayer { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
    public override object TypeId { get { return default(object); } }
    public string UIHint { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
    public override bool Equals(object obj) { return default(bool); }
    public override int GetHashCode() { return default(int); }
  }
  public abstract partial class ValidationAttribute : System.Attribute {
    protected ValidationAttribute() { }
    protected ValidationAttribute(System.Func<System.String> errorMessageAccessor) { }
    protected ValidationAttribute(string errorMessage) { }
    public string ErrorMessage { get { return default(string); } set { } }
    public string ErrorMessageResourceName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Type ErrorMessageResourceType { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Type); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    protected string ErrorMessageString { get { return default(string); } }
    public virtual string FormatErrorMessage(string name) { return default(string); }
    public System.ComponentModel.DataAnnotations.ValidationResult GetValidationResult(object value, System.ComponentModel.DataAnnotations.ValidationContext validationContext) { return default(System.ComponentModel.DataAnnotations.ValidationResult); }
    public virtual bool IsValid(object value) { return default(bool); }
    protected virtual System.ComponentModel.DataAnnotations.ValidationResult IsValid(object value, System.ComponentModel.DataAnnotations.ValidationContext validationContext) { return default(System.ComponentModel.DataAnnotations.ValidationResult); }
    public void Validate(object value, System.ComponentModel.DataAnnotations.ValidationContext validationContext) { }
    public void Validate(object value, string name) { }
  }
  public sealed partial class ValidationContext : System.IServiceProvider {
    public ValidationContext(object instance, System.IServiceProvider serviceProvider, System.Collections.Generic.IDictionary<System.Object, System.Object> items) { }
    public string DisplayName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Collections.Generic.IDictionary<System.Object, System.Object> Items { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Collections.Generic.IDictionary<System.Object, System.Object>); } }
    public string MemberName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public object ObjectInstance { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(object); } }
    public System.Type ObjectType { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Type); } }
    public System.ComponentModel.Design.IServiceContainer ServiceContainer { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.ComponentModel.Design.IServiceContainer); } }
    public object GetService(System.Type serviceType) { return default(object); }
  }
  public partial class ValidationException : System.Exception {
    public ValidationException() { }
    public ValidationException(System.ComponentModel.DataAnnotations.ValidationResult validationResult, System.ComponentModel.DataAnnotations.ValidationAttribute validatingAttribute, object value) { }
    protected ValidationException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public ValidationException(string message) { }
    public ValidationException(string errorMessage, System.ComponentModel.DataAnnotations.ValidationAttribute validatingAttribute, object value) { }
    public ValidationException(string message, System.Exception innerException) { }
    public System.ComponentModel.DataAnnotations.ValidationAttribute ValidationAttribute { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.ComponentModel.DataAnnotations.ValidationAttribute); } }
    public System.ComponentModel.DataAnnotations.ValidationResult ValidationResult { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.ComponentModel.DataAnnotations.ValidationResult); } }
    public object Value { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(object); } }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(128))]
    public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
  }
  public partial class ValidationResult {
    public static readonly System.ComponentModel.DataAnnotations.ValidationResult Success;
    protected ValidationResult(System.ComponentModel.DataAnnotations.ValidationResult validationResult) { }
    public ValidationResult(string errorMessage) { }
    public ValidationResult(string errorMessage, System.Collections.Generic.IEnumerable<System.String> memberNames) { }
    public string ErrorMessage { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Collections.Generic.IEnumerable<System.String> MemberNames { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Collections.Generic.IEnumerable<System.String>); } }
  }
  public static partial class Validator {
    public static bool TryValidateObject(object instance, System.ComponentModel.DataAnnotations.ValidationContext validationContext, System.Collections.Generic.ICollection<System.ComponentModel.DataAnnotations.ValidationResult> validationResults) { return default(bool); }
    public static bool TryValidateObject(object instance, System.ComponentModel.DataAnnotations.ValidationContext validationContext, System.Collections.Generic.ICollection<System.ComponentModel.DataAnnotations.ValidationResult> validationResults, bool validateAllProperties) { return default(bool); }
    public static bool TryValidateProperty(object value, System.ComponentModel.DataAnnotations.ValidationContext validationContext, System.Collections.Generic.ICollection<System.ComponentModel.DataAnnotations.ValidationResult> validationResults) { return default(bool); }
    public static bool TryValidateValue(object value, System.ComponentModel.DataAnnotations.ValidationContext validationContext, System.Collections.Generic.ICollection<System.ComponentModel.DataAnnotations.ValidationResult> validationResults, System.Collections.Generic.IEnumerable<System.ComponentModel.DataAnnotations.ValidationAttribute> validationAttributes) { return default(bool); }
    public static void ValidateObject(object instance, System.ComponentModel.DataAnnotations.ValidationContext validationContext) { }
    public static void ValidateObject(object instance, System.ComponentModel.DataAnnotations.ValidationContext validationContext, bool validateAllProperties) { }
    public static void ValidateProperty(object value, System.ComponentModel.DataAnnotations.ValidationContext validationContext) { }
    public static void ValidateValue(object value, System.ComponentModel.DataAnnotations.ValidationContext validationContext, System.Collections.Generic.IEnumerable<System.ComponentModel.DataAnnotations.ValidationAttribute> validationAttributes) { }
  }
}
