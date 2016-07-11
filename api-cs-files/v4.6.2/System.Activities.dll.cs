namespace Microsoft.CSharp.Activities {
  [System.Diagnostics.DebuggerStepThroughAttribute]
  [System.Windows.Markup.ContentPropertyAttribute("ExpressionText")]
  public partial class CSharpReference<TResult> : System.Activities.CodeActivity<System.Activities.Location<TResult>>, System.Activities.Expressions.ITextExpression {
    public CSharpReference() { }
    public CSharpReference(string expressionText) { }
    public string ExpressionText { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    public string Language { get { return default(string); } }
    public bool RequiresCompilation { get { return default(bool); } }
    protected override void CacheMetadata(System.Activities.CodeActivityMetadata metadata) { }
    protected override System.Activities.Location<TResult> Execute(System.Activities.CodeActivityContext context) { return default(System.Activities.Location<TResult>); }
    public System.Linq.Expressions.Expression GetExpressionTree() { return default(System.Linq.Expressions.Expression); }
  }
  [System.Diagnostics.DebuggerStepThroughAttribute]
  [System.Windows.Markup.ContentPropertyAttribute("ExpressionText")]
  public partial class CSharpValue<TResult> : System.Activities.CodeActivity<TResult>, System.Activities.Expressions.ITextExpression {
    public CSharpValue() { }
    public CSharpValue(string expressionText) { }
    public string ExpressionText { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    public string Language { get { return default(string); } }
    public bool RequiresCompilation { get { return default(bool); } }
    protected override void CacheMetadata(System.Activities.CodeActivityMetadata metadata) { }
    protected override TResult Execute(System.Activities.CodeActivityContext context) { return default(TResult); }
    public System.Linq.Expressions.Expression GetExpressionTree() { return default(System.Linq.Expressions.Expression); }
  }
}
namespace Microsoft.VisualBasic.Activities {
  public static partial class VisualBasic {
    public static Microsoft.VisualBasic.Activities.VisualBasicSettings GetSettings(object target) { return default(Microsoft.VisualBasic.Activities.VisualBasicSettings); }
    public static void SetSettings(object target, Microsoft.VisualBasic.Activities.VisualBasicSettings value) { }
    public static void SetSettingsForImplementation(object target, Microsoft.VisualBasic.Activities.VisualBasicSettings value) { }
    public static bool ShouldSerializeSettings(object target) { return default(bool); }
  }
  public static partial class VisualBasicDesignerHelper {
    public static System.Activities.Validation.Constraint NameShadowingConstraint { get { return default(System.Activities.Validation.Constraint); } }
    public static System.Activities.Activity CreatePrecompiledVisualBasicReference(System.Type targetType, string expressionText, System.Collections.Generic.IEnumerable<System.String> namespaces, System.Collections.Generic.IEnumerable<System.String> referencedAssemblies, System.Activities.LocationReferenceEnvironment environment, out System.Type returnType, out System.Activities.ExpressionParser.SourceExpressionException compileError, out Microsoft.VisualBasic.Activities.VisualBasicSettings vbSettings) { returnType = default(System.Type); compileError = default(System.Activities.ExpressionParser.SourceExpressionException); vbSettings = default(Microsoft.VisualBasic.Activities.VisualBasicSettings); return default(System.Activities.Activity); }
    public static System.Activities.Activity CreatePrecompiledVisualBasicValue(System.Type targetType, string expressionText, System.Collections.Generic.IEnumerable<System.String> namespaces, System.Collections.Generic.IEnumerable<System.String> referencedAssemblies, System.Activities.LocationReferenceEnvironment environment, out System.Type returnType, out System.Activities.ExpressionParser.SourceExpressionException compileError, out Microsoft.VisualBasic.Activities.VisualBasicSettings vbSettings) { returnType = default(System.Type); compileError = default(System.Activities.ExpressionParser.SourceExpressionException); vbSettings = default(Microsoft.VisualBasic.Activities.VisualBasicSettings); return default(System.Activities.Activity); }
    public static System.Activities.Activity RecompileVisualBasicReference(System.Activities.ActivityWithResult visualBasicReference, out System.Type returnType, out System.Activities.ExpressionParser.SourceExpressionException compileError, out Microsoft.VisualBasic.Activities.VisualBasicSettings vbSettings) { returnType = default(System.Type); compileError = default(System.Activities.ExpressionParser.SourceExpressionException); vbSettings = default(Microsoft.VisualBasic.Activities.VisualBasicSettings); return default(System.Activities.Activity); }
    public static System.Activities.Activity RecompileVisualBasicValue(System.Activities.ActivityWithResult visualBasicValue, out System.Type returnType, out System.Activities.ExpressionParser.SourceExpressionException compileError, out Microsoft.VisualBasic.Activities.VisualBasicSettings vbSettings) { returnType = default(System.Type); compileError = default(System.Activities.ExpressionParser.SourceExpressionException); vbSettings = default(Microsoft.VisualBasic.Activities.VisualBasicSettings); return default(System.Activities.Activity); }
  }
  public partial class VisualBasicImportReference : System.IEquatable<Microsoft.VisualBasic.Activities.VisualBasicImportReference> {
    public VisualBasicImportReference() { }
    public string Assembly { get { return default(string); } set { } }
    public string Import { get { return default(string); } set { } }
    public bool Equals(Microsoft.VisualBasic.Activities.VisualBasicImportReference other) { return default(bool); }
    public override int GetHashCode() { return default(int); }
  }
  [System.Diagnostics.DebuggerStepThroughAttribute]
  public sealed partial class VisualBasicReference<TResult> : System.Activities.CodeActivity<System.Activities.Location<TResult>>, System.Activities.Expressions.ITextExpression, System.Activities.XamlIntegration.IValueSerializableExpression {
    public VisualBasicReference() { }
    public VisualBasicReference(string expressionText) { }
    public string ExpressionText { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    public string Language { get { return default(string); } }
    public bool RequiresCompilation { get { return default(bool); } }
    protected override void CacheMetadata(System.Activities.CodeActivityMetadata metadata) { }
    public bool CanConvertToString(System.Windows.Markup.IValueSerializerContext context) { return default(bool); }
    public string ConvertToString(System.Windows.Markup.IValueSerializerContext context) { return default(string); }
    protected override System.Activities.Location<TResult> Execute(System.Activities.CodeActivityContext context) { return default(System.Activities.Location<TResult>); }
    public System.Linq.Expressions.Expression GetExpressionTree() { return default(System.Linq.Expressions.Expression); }
  }
  [System.ComponentModel.TypeConverterAttribute(typeof(Microsoft.VisualBasic.Activities.XamlIntegration.VisualBasicSettingsConverter))]
  [System.Windows.Markup.ValueSerializerAttribute(typeof(Microsoft.VisualBasic.Activities.XamlIntegration.VisualBasicSettingsValueSerializer))]
  public partial class VisualBasicSettings {
    public VisualBasicSettings() { }
    public static Microsoft.VisualBasic.Activities.VisualBasicSettings Default { get { return default(Microsoft.VisualBasic.Activities.VisualBasicSettings); } }
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    public System.Collections.Generic.ISet<Microsoft.VisualBasic.Activities.VisualBasicImportReference> ImportReferences { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Collections.Generic.ISet<Microsoft.VisualBasic.Activities.VisualBasicImportReference>); } }
  }
  [System.Diagnostics.DebuggerStepThroughAttribute]
  public sealed partial class VisualBasicValue<TResult> : System.Activities.CodeActivity<TResult>, System.Activities.Expressions.ITextExpression, System.Activities.XamlIntegration.IValueSerializableExpression {
    public VisualBasicValue() { }
    public VisualBasicValue(string expressionText) { }
    public string ExpressionText { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    public string Language { get { return default(string); } }
    public bool RequiresCompilation { get { return default(bool); } }
    protected override void CacheMetadata(System.Activities.CodeActivityMetadata metadata) { }
    public bool CanConvertToString(System.Windows.Markup.IValueSerializerContext context) { return default(bool); }
    public string ConvertToString(System.Windows.Markup.IValueSerializerContext context) { return default(string); }
    protected override TResult Execute(System.Activities.CodeActivityContext context) { return default(TResult); }
    public System.Linq.Expressions.Expression GetExpressionTree() { return default(System.Linq.Expressions.Expression); }
  }
}
namespace Microsoft.VisualBasic.Activities.XamlIntegration {
  public sealed partial class VisualBasicSettingsConverter : System.ComponentModel.TypeConverter {
    public VisualBasicSettingsConverter() { }
    public override bool CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType) { return default(bool); }
    public override bool CanConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Type destinationType) { return default(bool); }
    public override object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value) { return default(object); }
    public override object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType) { return default(object); }
  }
  public sealed partial class VisualBasicSettingsValueSerializer : System.Windows.Markup.ValueSerializer {
    public VisualBasicSettingsValueSerializer() { }
    public override bool CanConvertToString(object value, System.Windows.Markup.IValueSerializerContext context) { return default(bool); }
    public override string ConvertToString(object value, System.Windows.Markup.IValueSerializerContext context) { return default(string); }
  }
}
namespace System.Activities {
  [System.Windows.Markup.ContentPropertyAttribute("Implementation")]
  public abstract partial class Activity {
    protected Activity() { }
    protected internal int CacheId { get { return default(int); } }
    protected System.Collections.ObjectModel.Collection<System.Activities.Validation.Constraint> Constraints { get { return default(System.Collections.ObjectModel.Collection<System.Activities.Validation.Constraint>); } }
    public string DisplayName { get { return default(string); } set { } }
    public string Id { get { return default(string); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute(null)]
    [System.Windows.Markup.AmbientAttribute]
    [System.Windows.Markup.XamlDeferLoadAttribute(typeof(System.Activities.XamlIntegration.FuncDeferringLoader), typeof(System.Activities.Activity))]
    protected virtual System.Func<System.Activities.Activity> Implementation { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Func<System.Activities.Activity>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Activities.XamlIntegration.ImplementationVersionConverter))]
    protected internal virtual System.Version ImplementationVersion { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Version); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    protected virtual void CacheMetadata(System.Activities.ActivityMetadata metadata) { }
    protected virtual void OnCreateDynamicUpdateMap(System.Activities.DynamicUpdate.UpdateMapMetadata metadata, System.Activities.Activity originalActivity) { }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public bool ShouldSerializeDisplayName() { return default(bool); }
    public override string ToString() { return default(string); }
  }
  [System.ComponentModel.TypeConverterAttribute(typeof(System.Activities.XamlIntegration.ActivityWithResultConverter))]
  [System.Windows.Markup.ValueSerializerAttribute(typeof(System.Activities.XamlIntegration.ActivityWithResultValueSerializer))]
  public abstract partial class Activity<TResult> : System.Activities.ActivityWithResult {
    protected Activity() { }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public new System.Activities.OutArgument<TResult> Result { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.OutArgument<TResult>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public static System.Activities.Activity<TResult> FromValue(TResult constValue) { return default(System.Activities.Activity<TResult>); }
    public static System.Activities.Activity<TResult> FromVariable(System.Activities.Variable variable) { return default(System.Activities.Activity<TResult>); }
    public static System.Activities.Activity<TResult> FromVariable(System.Activities.Variable<TResult> variable) { return default(System.Activities.Activity<TResult>); }
    public static implicit operator System.Activities.Activity<TResult> (TResult constValue) { return default(System.Activities.Activity<TResult>); }
    public static implicit operator System.Activities.Activity<TResult> (System.Activities.Variable variable) { return default(System.Activities.Activity<TResult>); }
    public static implicit operator System.Activities.Activity<TResult> (System.Activities.Variable<TResult> variable) { return default(System.Activities.Activity<TResult>); }
  }
  public sealed partial class ActivityAction : System.Activities.ActivityDelegate {
    public ActivityAction() { }
  }
  public sealed partial class ActivityAction<T> : System.Activities.ActivityDelegate {
    public ActivityAction() { }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T> Argument { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
  }
  public sealed partial class ActivityAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> : System.Activities.ActivityDelegate {
    public ActivityAction() { }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T1> Argument1 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T1>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T10> Argument10 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T10>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T2> Argument2 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T2>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T3> Argument3 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T3>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T4> Argument4 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T4>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T5> Argument5 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T5>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T6> Argument6 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T6>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T7> Argument7 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T7>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T8> Argument8 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T8>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T9> Argument9 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T9>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
  }
  public sealed partial class ActivityAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> : System.Activities.ActivityDelegate {
    public ActivityAction() { }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T1> Argument1 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T1>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T10> Argument10 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T10>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T11> Argument11 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T11>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T2> Argument2 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T2>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T3> Argument3 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T3>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T4> Argument4 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T4>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T5> Argument5 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T5>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T6> Argument6 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T6>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T7> Argument7 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T7>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T8> Argument8 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T8>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T9> Argument9 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T9>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
  }
  public sealed partial class ActivityAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> : System.Activities.ActivityDelegate {
    public ActivityAction() { }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T1> Argument1 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T1>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T10> Argument10 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T10>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T11> Argument11 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T11>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T12> Argument12 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T12>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T2> Argument2 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T2>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T3> Argument3 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T3>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T4> Argument4 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T4>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T5> Argument5 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T5>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T6> Argument6 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T6>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T7> Argument7 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T7>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T8> Argument8 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T8>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T9> Argument9 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T9>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
  }
  public sealed partial class ActivityAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> : System.Activities.ActivityDelegate {
    public ActivityAction() { }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T1> Argument1 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T1>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T10> Argument10 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T10>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T11> Argument11 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T11>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T12> Argument12 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T12>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T13> Argument13 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T13>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T2> Argument2 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T2>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T3> Argument3 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T3>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T4> Argument4 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T4>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T5> Argument5 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T5>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T6> Argument6 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T6>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T7> Argument7 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T7>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T8> Argument8 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T8>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T9> Argument9 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T9>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
  }
  public sealed partial class ActivityAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> : System.Activities.ActivityDelegate {
    public ActivityAction() { }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T1> Argument1 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T1>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T10> Argument10 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T10>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T11> Argument11 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T11>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T12> Argument12 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T12>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T13> Argument13 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T13>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T14> Argument14 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T14>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T2> Argument2 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T2>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T3> Argument3 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T3>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T4> Argument4 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T4>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T5> Argument5 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T5>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T6> Argument6 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T6>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T7> Argument7 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T7>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T8> Argument8 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T8>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T9> Argument9 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T9>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
  }
  public sealed partial class ActivityAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> : System.Activities.ActivityDelegate {
    public ActivityAction() { }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T1> Argument1 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T1>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T10> Argument10 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T10>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T11> Argument11 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T11>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T12> Argument12 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T12>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T13> Argument13 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T13>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T14> Argument14 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T14>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T15> Argument15 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T15>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T2> Argument2 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T2>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T3> Argument3 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T3>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T4> Argument4 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T4>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T5> Argument5 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T5>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T6> Argument6 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T6>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T7> Argument7 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T7>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T8> Argument8 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T8>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T9> Argument9 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T9>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
  }
  public sealed partial class ActivityAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> : System.Activities.ActivityDelegate {
    public ActivityAction() { }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T1> Argument1 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T1>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T10> Argument10 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T10>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T11> Argument11 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T11>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T12> Argument12 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T12>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T13> Argument13 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T13>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T14> Argument14 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T14>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T15> Argument15 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T15>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T16> Argument16 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T16>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T2> Argument2 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T2>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T3> Argument3 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T3>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T4> Argument4 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T4>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T5> Argument5 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T5>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T6> Argument6 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T6>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T7> Argument7 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T7>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T8> Argument8 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T8>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T9> Argument9 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T9>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
  }
  public sealed partial class ActivityAction<T1, T2> : System.Activities.ActivityDelegate {
    public ActivityAction() { }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T1> Argument1 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T1>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T2> Argument2 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T2>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
  }
  public sealed partial class ActivityAction<T1, T2, T3> : System.Activities.ActivityDelegate {
    public ActivityAction() { }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T1> Argument1 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T1>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T2> Argument2 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T2>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T3> Argument3 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T3>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
  }
  public sealed partial class ActivityAction<T1, T2, T3, T4> : System.Activities.ActivityDelegate {
    public ActivityAction() { }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T1> Argument1 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T1>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T2> Argument2 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T2>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T3> Argument3 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T3>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T4> Argument4 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T4>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
  }
  public sealed partial class ActivityAction<T1, T2, T3, T4, T5> : System.Activities.ActivityDelegate {
    public ActivityAction() { }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T1> Argument1 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T1>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T2> Argument2 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T2>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T3> Argument3 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T3>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T4> Argument4 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T4>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T5> Argument5 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T5>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
  }
  public sealed partial class ActivityAction<T1, T2, T3, T4, T5, T6> : System.Activities.ActivityDelegate {
    public ActivityAction() { }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T1> Argument1 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T1>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T2> Argument2 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T2>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T3> Argument3 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T3>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T4> Argument4 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T4>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T5> Argument5 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T5>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T6> Argument6 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T6>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
  }
  public sealed partial class ActivityAction<T1, T2, T3, T4, T5, T6, T7> : System.Activities.ActivityDelegate {
    public ActivityAction() { }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T1> Argument1 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T1>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T2> Argument2 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T2>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T3> Argument3 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T3>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T4> Argument4 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T4>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T5> Argument5 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T5>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T6> Argument6 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T6>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T7> Argument7 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T7>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
  }
  public sealed partial class ActivityAction<T1, T2, T3, T4, T5, T6, T7, T8> : System.Activities.ActivityDelegate {
    public ActivityAction() { }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T1> Argument1 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T1>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T2> Argument2 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T2>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T3> Argument3 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T3>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T4> Argument4 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T4>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T5> Argument5 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T5>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T6> Argument6 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T6>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T7> Argument7 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T7>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T8> Argument8 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T8>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
  }
  public sealed partial class ActivityAction<T1, T2, T3, T4, T5, T6, T7, T8, T9> : System.Activities.ActivityDelegate {
    public ActivityAction() { }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T1> Argument1 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T1>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T2> Argument2 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T2>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T3> Argument3 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T3>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T4> Argument4 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T4>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T5> Argument5 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T5>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T6> Argument6 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T6>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T7> Argument7 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T7>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T8> Argument8 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T8>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T9> Argument9 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T9>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
  }
  [System.Windows.Markup.ContentPropertyAttribute("Implementation")]
  public sealed partial class ActivityBuilder : System.Activities.Debugger.IDebuggableWorkflowTree {
    public ActivityBuilder() { }
    [System.Windows.Markup.DependsOnAttribute("Name")]
    public System.Collections.ObjectModel.Collection<System.Attribute> Attributes { get { return default(System.Collections.ObjectModel.Collection<System.Attribute>); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.Windows.Markup.DependsOnAttribute("Properties")]
    public System.Collections.ObjectModel.Collection<System.Activities.Validation.Constraint> Constraints { get { return default(System.Collections.ObjectModel.Collection<System.Activities.Validation.Constraint>); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute(null)]
    [System.Windows.Markup.DependsOnAttribute("Constraints")]
    public System.Activities.Activity Implementation { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.Activity); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Activities.XamlIntegration.ImplementationVersionConverter))]
    [System.Windows.Markup.DependsOnAttribute("Name")]
    public System.Version ImplementationVersion { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Version); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public string Name { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.Windows.Markup.DependsOnAttribute("Attributes")]
    public System.Collections.ObjectModel.KeyedCollection<System.String, System.Activities.DynamicActivityProperty> Properties { get { return default(System.Collections.ObjectModel.KeyedCollection<System.String, System.Activities.DynamicActivityProperty>); } }
    public static System.Activities.ActivityPropertyReference GetPropertyReference(object target) { return default(System.Activities.ActivityPropertyReference); }
    public static System.Collections.Generic.IList<System.Activities.ActivityPropertyReference> GetPropertyReferences(object target) { return default(System.Collections.Generic.IList<System.Activities.ActivityPropertyReference>); }
    public static void SetPropertyReference(object target, System.Activities.ActivityPropertyReference value) { }
    public static bool ShouldSerializePropertyReference(object target) { return default(bool); }
    public static bool ShouldSerializePropertyReferences(object target) { return default(bool); }
    System.Activities.Activity System.Activities.Debugger.IDebuggableWorkflowTree.GetWorkflowRoot() { return default(System.Activities.Activity); }
  }
  [System.Windows.Markup.ContentPropertyAttribute("Implementation")]
  public sealed partial class ActivityBuilder<TResult> : System.Activities.Debugger.IDebuggableWorkflowTree {
    public ActivityBuilder() { }
    [System.Windows.Markup.DependsOnAttribute("Name")]
    public System.Collections.ObjectModel.Collection<System.Attribute> Attributes { get { return default(System.Collections.ObjectModel.Collection<System.Attribute>); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.Windows.Markup.DependsOnAttribute("Properties")]
    public System.Collections.ObjectModel.Collection<System.Activities.Validation.Constraint> Constraints { get { return default(System.Collections.ObjectModel.Collection<System.Activities.Validation.Constraint>); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute(null)]
    [System.Windows.Markup.DependsOnAttribute("Constraints")]
    public System.Activities.Activity Implementation { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.Activity); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Activities.XamlIntegration.ImplementationVersionConverter))]
    [System.Windows.Markup.DependsOnAttribute("Name")]
    public System.Version ImplementationVersion { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Version); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public string Name { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.Windows.Markup.DependsOnAttribute("Attributes")]
    public System.Collections.ObjectModel.KeyedCollection<System.String, System.Activities.DynamicActivityProperty> Properties { get { return default(System.Collections.ObjectModel.KeyedCollection<System.String, System.Activities.DynamicActivityProperty>); } }
    System.Activities.Activity System.Activities.Debugger.IDebuggableWorkflowTree.GetWorkflowRoot() { return default(System.Activities.Activity); }
  }
  public partial class ActivityContext {
    internal ActivityContext() { }
    public string ActivityInstanceId { get { return default(string); } }
    public System.Activities.WorkflowDataContext DataContext { get { return default(System.Activities.WorkflowDataContext); } }
    public System.Guid WorkflowInstanceId { get { return default(System.Guid); } }
    public T GetExtension<T>() where T : class { return default(T); }
    public System.Activities.Location<T> GetLocation<T>(System.Activities.LocationReference locationReference) { return default(System.Activities.Location<T>); }
    public object GetValue(System.Activities.Argument argument) { return default(object); }
    public object GetValue(System.Activities.RuntimeArgument runtimeArgument) { return default(object); }
    public T GetValue<T>(System.Activities.InArgument<T> argument) { return default(T); }
    public T GetValue<T>(System.Activities.InOutArgument<T> argument) { return default(T); }
    public T GetValue<T>(System.Activities.LocationReference locationReference) { return default(T); }
    public T GetValue<T>(System.Activities.OutArgument<T> argument) { return default(T); }
    public void SetValue(System.Activities.Argument argument, object value) { }
    public void SetValue<T>(System.Activities.InArgument<T> argument, T value) { }
    public void SetValue<T>(System.Activities.InOutArgument<T> argument, T value) { }
    public void SetValue<T>(System.Activities.LocationReference locationReference, T value) { }
    public void SetValue<T>(System.Activities.OutArgument<T> argument, T value) { }
  }
  [System.Windows.Markup.ContentPropertyAttribute("Handler")]
  public abstract partial class ActivityDelegate {
    protected ActivityDelegate() { }
    public string DisplayName { get { return default(string); } set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.Activity Handler { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.Activity); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    protected internal virtual System.Activities.DelegateOutArgument GetResultArgument() { return default(System.Activities.DelegateOutArgument); }
    protected virtual void OnGetRuntimeDelegateArguments(System.Collections.Generic.IList<System.Activities.RuntimeDelegateArgument> runtimeDelegateArguments) { }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public bool ShouldSerializeDisplayName() { return default(bool); }
    public override string ToString() { return default(string); }
  }
  public sealed partial class ActivityFunc<TResult> : System.Activities.ActivityDelegate {
    public ActivityFunc() { }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateOutArgument<TResult> Result { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateOutArgument<TResult>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    protected internal override System.Activities.DelegateOutArgument GetResultArgument() { return default(System.Activities.DelegateOutArgument); }
  }
  public sealed partial class ActivityFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> : System.Activities.ActivityDelegate {
    public ActivityFunc() { }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T1> Argument1 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T1>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T2> Argument2 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T2>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T3> Argument3 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T3>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T4> Argument4 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T4>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T5> Argument5 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T5>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T6> Argument6 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T6>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T7> Argument7 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T7>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T8> Argument8 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T8>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T9> Argument9 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T9>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateOutArgument<TResult> Result { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateOutArgument<TResult>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    protected internal override System.Activities.DelegateOutArgument GetResultArgument() { return default(System.Activities.DelegateOutArgument); }
  }
  public sealed partial class ActivityFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> : System.Activities.ActivityDelegate {
    public ActivityFunc() { }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T1> Argument1 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T1>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T10> Argument10 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T10>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T2> Argument2 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T2>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T3> Argument3 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T3>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T4> Argument4 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T4>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T5> Argument5 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T5>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T6> Argument6 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T6>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T7> Argument7 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T7>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T8> Argument8 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T8>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T9> Argument9 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T9>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateOutArgument<TResult> Result { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateOutArgument<TResult>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    protected internal override System.Activities.DelegateOutArgument GetResultArgument() { return default(System.Activities.DelegateOutArgument); }
  }
  public sealed partial class ActivityFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> : System.Activities.ActivityDelegate {
    public ActivityFunc() { }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T1> Argument1 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T1>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T10> Argument10 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T10>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T11> Argument11 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T11>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T2> Argument2 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T2>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T3> Argument3 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T3>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T4> Argument4 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T4>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T5> Argument5 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T5>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T6> Argument6 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T6>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T7> Argument7 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T7>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T8> Argument8 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T8>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T9> Argument9 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T9>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateOutArgument<TResult> Result { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateOutArgument<TResult>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    protected internal override System.Activities.DelegateOutArgument GetResultArgument() { return default(System.Activities.DelegateOutArgument); }
  }
  public sealed partial class ActivityFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> : System.Activities.ActivityDelegate {
    public ActivityFunc() { }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T1> Argument1 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T1>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T10> Argument10 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T10>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T11> Argument11 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T11>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T12> Argument12 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T12>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T2> Argument2 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T2>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T3> Argument3 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T3>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T4> Argument4 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T4>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T5> Argument5 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T5>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T6> Argument6 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T6>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T7> Argument7 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T7>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T8> Argument8 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T8>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T9> Argument9 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T9>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateOutArgument<TResult> Result { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateOutArgument<TResult>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    protected internal override System.Activities.DelegateOutArgument GetResultArgument() { return default(System.Activities.DelegateOutArgument); }
  }
  public sealed partial class ActivityFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> : System.Activities.ActivityDelegate {
    public ActivityFunc() { }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T1> Argument1 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T1>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T10> Argument10 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T10>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T11> Argument11 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T11>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T12> Argument12 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T12>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T13> Argument13 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T13>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T2> Argument2 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T2>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T3> Argument3 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T3>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T4> Argument4 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T4>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T5> Argument5 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T5>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T6> Argument6 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T6>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T7> Argument7 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T7>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T8> Argument8 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T8>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T9> Argument9 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T9>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateOutArgument<TResult> Result { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateOutArgument<TResult>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    protected internal override System.Activities.DelegateOutArgument GetResultArgument() { return default(System.Activities.DelegateOutArgument); }
  }
  public sealed partial class ActivityFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> : System.Activities.ActivityDelegate {
    public ActivityFunc() { }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T1> Argument1 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T1>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T10> Argument10 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T10>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T11> Argument11 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T11>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T12> Argument12 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T12>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T13> Argument13 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T13>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T14> Argument14 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T14>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T2> Argument2 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T2>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T3> Argument3 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T3>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T4> Argument4 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T4>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T5> Argument5 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T5>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T6> Argument6 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T6>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T7> Argument7 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T7>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T8> Argument8 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T8>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T9> Argument9 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T9>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateOutArgument<TResult> Result { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateOutArgument<TResult>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    protected internal override System.Activities.DelegateOutArgument GetResultArgument() { return default(System.Activities.DelegateOutArgument); }
  }
  public sealed partial class ActivityFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> : System.Activities.ActivityDelegate {
    public ActivityFunc() { }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T1> Argument1 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T1>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T10> Argument10 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T10>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T11> Argument11 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T11>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T12> Argument12 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T12>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T13> Argument13 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T13>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T14> Argument14 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T14>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T15> Argument15 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T15>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T2> Argument2 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T2>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T3> Argument3 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T3>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T4> Argument4 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T4>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T5> Argument5 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T5>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T6> Argument6 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T6>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T7> Argument7 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T7>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T8> Argument8 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T8>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T9> Argument9 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T9>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateOutArgument<TResult> Result { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateOutArgument<TResult>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    protected internal override System.Activities.DelegateOutArgument GetResultArgument() { return default(System.Activities.DelegateOutArgument); }
  }
  public sealed partial class ActivityFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> : System.Activities.ActivityDelegate {
    public ActivityFunc() { }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T1> Argument1 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T1>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T10> Argument10 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T10>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T11> Argument11 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T11>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T12> Argument12 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T12>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T13> Argument13 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T13>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T14> Argument14 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T14>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T15> Argument15 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T15>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T16> Argument16 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T16>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T2> Argument2 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T2>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T3> Argument3 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T3>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T4> Argument4 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T4>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T5> Argument5 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T5>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T6> Argument6 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T6>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T7> Argument7 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T7>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T8> Argument8 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T8>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T9> Argument9 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T9>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateOutArgument<TResult> Result { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateOutArgument<TResult>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    protected internal override System.Activities.DelegateOutArgument GetResultArgument() { return default(System.Activities.DelegateOutArgument); }
  }
  public sealed partial class ActivityFunc<T, TResult> : System.Activities.ActivityDelegate {
    public ActivityFunc() { }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T> Argument { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateOutArgument<TResult> Result { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateOutArgument<TResult>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    protected internal override System.Activities.DelegateOutArgument GetResultArgument() { return default(System.Activities.DelegateOutArgument); }
  }
  public sealed partial class ActivityFunc<T1, T2, TResult> : System.Activities.ActivityDelegate {
    public ActivityFunc() { }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T1> Argument1 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T1>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T2> Argument2 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T2>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateOutArgument<TResult> Result { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateOutArgument<TResult>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    protected internal override System.Activities.DelegateOutArgument GetResultArgument() { return default(System.Activities.DelegateOutArgument); }
  }
  public sealed partial class ActivityFunc<T1, T2, T3, TResult> : System.Activities.ActivityDelegate {
    public ActivityFunc() { }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T1> Argument1 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T1>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T2> Argument2 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T2>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T3> Argument3 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T3>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateOutArgument<TResult> Result { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateOutArgument<TResult>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    protected internal override System.Activities.DelegateOutArgument GetResultArgument() { return default(System.Activities.DelegateOutArgument); }
  }
  public sealed partial class ActivityFunc<T1, T2, T3, T4, TResult> : System.Activities.ActivityDelegate {
    public ActivityFunc() { }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T1> Argument1 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T1>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T2> Argument2 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T2>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T3> Argument3 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T3>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T4> Argument4 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T4>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateOutArgument<TResult> Result { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateOutArgument<TResult>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    protected internal override System.Activities.DelegateOutArgument GetResultArgument() { return default(System.Activities.DelegateOutArgument); }
  }
  public sealed partial class ActivityFunc<T1, T2, T3, T4, T5, TResult> : System.Activities.ActivityDelegate {
    public ActivityFunc() { }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T1> Argument1 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T1>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T2> Argument2 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T2>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T3> Argument3 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T3>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T4> Argument4 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T4>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T5> Argument5 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T5>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateOutArgument<TResult> Result { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateOutArgument<TResult>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    protected internal override System.Activities.DelegateOutArgument GetResultArgument() { return default(System.Activities.DelegateOutArgument); }
  }
  public sealed partial class ActivityFunc<T1, T2, T3, T4, T5, T6, TResult> : System.Activities.ActivityDelegate {
    public ActivityFunc() { }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T1> Argument1 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T1>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T2> Argument2 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T2>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T3> Argument3 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T3>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T4> Argument4 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T4>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T5> Argument5 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T5>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T6> Argument6 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T6>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateOutArgument<TResult> Result { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateOutArgument<TResult>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    protected internal override System.Activities.DelegateOutArgument GetResultArgument() { return default(System.Activities.DelegateOutArgument); }
  }
  public sealed partial class ActivityFunc<T1, T2, T3, T4, T5, T6, T7, TResult> : System.Activities.ActivityDelegate {
    public ActivityFunc() { }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T1> Argument1 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T1>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T2> Argument2 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T2>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T3> Argument3 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T3>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T4> Argument4 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T4>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T5> Argument5 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T5>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T6> Argument6 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T6>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T7> Argument7 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T7>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateOutArgument<TResult> Result { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateOutArgument<TResult>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    protected internal override System.Activities.DelegateOutArgument GetResultArgument() { return default(System.Activities.DelegateOutArgument); }
  }
  public sealed partial class ActivityFunc<T1, T2, T3, T4, T5, T6, T7, T8, TResult> : System.Activities.ActivityDelegate {
    public ActivityFunc() { }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T1> Argument1 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T1>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T2> Argument2 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T2>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T3> Argument3 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T3>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T4> Argument4 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T4>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T5> Argument5 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T5>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T6> Argument6 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T6>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T7> Argument7 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T7>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateInArgument<T8> Argument8 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateInArgument<T8>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.DelegateOutArgument<TResult> Result { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateOutArgument<TResult>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    protected internal override System.Activities.DelegateOutArgument GetResultArgument() { return default(System.Activities.DelegateOutArgument); }
  }
  [System.Runtime.Serialization.DataContractAttribute(Name="ActivityInstance", Namespace="http://schemas.datacontract.org/2010/02/System.Activities")]
  public sealed partial class ActivityInstance {
    internal ActivityInstance() { }
    public System.Activities.Activity Activity { get { return default(System.Activities.Activity); } }
    public string Id { get { return default(string); } }
    [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
    public System.Version ImplementationVersion { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Version); } }
    public bool IsCompleted { get { return default(bool); } }
    public System.Activities.ActivityInstanceState State { get { return default(System.Activities.ActivityInstanceState); } }
  }
  [System.Runtime.Serialization.DataContractAttribute]
  public enum ActivityInstanceState {
    [System.Runtime.Serialization.EnumMemberAttribute]
    Canceled = 2,
    [System.Runtime.Serialization.EnumMemberAttribute]
    Closed = 1,
    [System.Runtime.Serialization.EnumMemberAttribute]
    Executing = 0,
    [System.Runtime.Serialization.EnumMemberAttribute]
    Faulted = 3,
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct ActivityMetadata {
    public System.Activities.LocationReferenceEnvironment Environment { get { return default(System.Activities.LocationReferenceEnvironment); } }
    public bool HasViolations { get { return default(bool); } }
    public void AddArgument(System.Activities.RuntimeArgument argument) { }
    public void AddDefaultExtensionProvider<T>(System.Func<T> extensionProvider) where T : class { }
    public void AddImportedChild(System.Activities.Activity importedChild) { }
    public void AddImportedChild(System.Activities.Activity importedChild, object origin) { }
    public void AddImportedDelegate(System.Activities.ActivityDelegate importedDelegate) { }
    public void AddImportedDelegate(System.Activities.ActivityDelegate importedDelegate, object origin) { }
    public void AddValidationError(System.Activities.Validation.ValidationError validationError) { }
    public void AddValidationError(string validationErrorMessage) { }
    public void AddVariable(System.Activities.Variable variable) { }
    public void AddVariable(System.Activities.Variable variable, object origin) { }
    public void Bind(System.Activities.Argument binding, System.Activities.RuntimeArgument argument) { }
    public override bool Equals(object obj) { return default(bool); }
    public System.Collections.ObjectModel.Collection<System.Activities.RuntimeArgument> GetArgumentsWithReflection() { return default(System.Collections.ObjectModel.Collection<System.Activities.RuntimeArgument>); }
    public override int GetHashCode() { return default(int); }
    public System.Collections.ObjectModel.Collection<System.Activities.Activity> GetImportedChildrenWithReflection() { return default(System.Collections.ObjectModel.Collection<System.Activities.Activity>); }
    public System.Collections.ObjectModel.Collection<System.Activities.ActivityDelegate> GetImportedDelegatesWithReflection() { return default(System.Collections.ObjectModel.Collection<System.Activities.ActivityDelegate>); }
    public System.Collections.ObjectModel.Collection<System.Activities.Variable> GetVariablesWithReflection() { return default(System.Collections.ObjectModel.Collection<System.Activities.Variable>); }
    public static bool operator ==(System.Activities.ActivityMetadata left, System.Activities.ActivityMetadata right) { return default(bool); }
    public static bool operator !=(System.Activities.ActivityMetadata left, System.Activities.ActivityMetadata right) { return default(bool); }
    public void RequireExtension(System.Type extensionType) { }
    public void RequireExtension<T>() where T : class { }
    public void SetArgumentsCollection(System.Collections.ObjectModel.Collection<System.Activities.RuntimeArgument> arguments) { }
    public void SetImportedChildrenCollection(System.Collections.ObjectModel.Collection<System.Activities.Activity> importedChildren) { }
    public void SetImportedDelegatesCollection(System.Collections.ObjectModel.Collection<System.Activities.ActivityDelegate> importedDelegates) { }
    public void SetValidationErrorsCollection(System.Collections.ObjectModel.Collection<System.Activities.Validation.ValidationError> validationErrors) { }
    public void SetVariablesCollection(System.Collections.ObjectModel.Collection<System.Activities.Variable> variables) { }
  }
  public partial class ActivityPropertyReference {
    public ActivityPropertyReference() { }
    public string SourceProperty { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public string TargetProperty { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
  }
  public abstract partial class ActivityWithResult : System.Activities.Activity {
    internal ActivityWithResult() { }
    [System.Runtime.Serialization.IgnoreDataMemberAttribute]
    public System.Activities.OutArgument Result { get { return default(System.Activities.OutArgument); } set { } }
    public System.Type ResultType { get { return default(System.Type); } }
  }
  public abstract partial class Argument {
    internal Argument() { }
    public const string ResultValue = "Result";
    public static readonly int UnspecifiedEvaluationOrder;
    public System.Type ArgumentType { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Type); } }
    public System.Activities.ArgumentDirection Direction { get { return default(System.Activities.ArgumentDirection); } }
    [System.ComponentModel.DefaultValueAttribute(-1)]
    public int EvaluationOrder { get { return default(int); } set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    [System.Runtime.Serialization.IgnoreDataMemberAttribute]
    public System.Activities.ActivityWithResult Expression { get { return default(System.Activities.ActivityWithResult); } set { } }
    public static System.Activities.Argument Create(System.Type type, System.Activities.ArgumentDirection direction) { return default(System.Activities.Argument); }
    public static System.Activities.Argument CreateReference(System.Activities.Argument argumentToReference, string referencedArgumentName) { return default(System.Activities.Argument); }
    public object Get(System.Activities.ActivityContext context) { return default(object); }
    public T Get<T>(System.Activities.ActivityContext context) { return default(T); }
    public System.Activities.Location GetLocation(System.Activities.ActivityContext context) { return default(System.Activities.Location); }
    public void Set(System.Activities.ActivityContext context, object value) { }
  }
  public enum ArgumentDirection {
    In = 0,
    InOut = 2,
    Out = 1,
  }
  public abstract partial class AsyncCodeActivity : System.Activities.Activity {
    protected AsyncCodeActivity() { }
    [System.Runtime.Serialization.IgnoreDataMemberAttribute]
    protected sealed override System.Func<System.Activities.Activity> Implementation { get { return default(System.Func<System.Activities.Activity>); } set { } }
    protected internal sealed override System.Version ImplementationVersion { get { return default(System.Version); } set { } }
    protected abstract System.IAsyncResult BeginExecute(System.Activities.AsyncCodeActivityContext context, System.AsyncCallback callback, object state);
    protected sealed override void CacheMetadata(System.Activities.ActivityMetadata metadata) { }
    protected virtual void CacheMetadata(System.Activities.CodeActivityMetadata metadata) { }
    protected virtual void Cancel(System.Activities.AsyncCodeActivityContext context) { }
    protected abstract void EndExecute(System.Activities.AsyncCodeActivityContext context, System.IAsyncResult result);
    protected sealed override void OnCreateDynamicUpdateMap(System.Activities.DynamicUpdate.UpdateMapMetadata metadata, System.Activities.Activity originalActivity) { }
  }
  public abstract partial class AsyncCodeActivity<TResult> : System.Activities.Activity<TResult> {
    protected AsyncCodeActivity() { }
    [System.Runtime.Serialization.IgnoreDataMemberAttribute]
    protected sealed override System.Func<System.Activities.Activity> Implementation { get { return default(System.Func<System.Activities.Activity>); } set { } }
    protected internal sealed override System.Version ImplementationVersion { get { return default(System.Version); } set { } }
    protected abstract System.IAsyncResult BeginExecute(System.Activities.AsyncCodeActivityContext context, System.AsyncCallback callback, object state);
    protected sealed override void CacheMetadata(System.Activities.ActivityMetadata metadata) { }
    protected virtual void CacheMetadata(System.Activities.CodeActivityMetadata metadata) { }
    protected virtual void Cancel(System.Activities.AsyncCodeActivityContext context) { }
    protected abstract TResult EndExecute(System.Activities.AsyncCodeActivityContext context, System.IAsyncResult result);
    protected sealed override void OnCreateDynamicUpdateMap(System.Activities.DynamicUpdate.UpdateMapMetadata metadata, System.Activities.Activity originalActivity) { }
  }
  public sealed partial class AsyncCodeActivityContext : System.Activities.CodeActivityContext {
    internal AsyncCodeActivityContext() { }
    public bool IsCancellationRequested { get { return default(bool); } }
    public object UserState { get { return default(object); } set { } }
    public void MarkCanceled() { }
  }
  [System.Runtime.Serialization.DataContractAttribute]
  public partial class Bookmark : System.IEquatable<System.Activities.Bookmark> {
    public Bookmark(string name) { }
    public string Name { get { return default(string); } }
    public bool Equals(System.Activities.Bookmark other) { return default(bool); }
    public override bool Equals(object obj) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public override string ToString() { return default(string); }
  }
  public delegate void BookmarkCallback(System.Activities.NativeActivityContext context, System.Activities.Bookmark bookmark, object value);
  [System.FlagsAttribute]
  public enum BookmarkOptions {
    MultipleResume = 1,
    NonBlocking = 2,
    None = 0,
  }
  public enum BookmarkResumptionResult {
    NotFound = 1,
    NotReady = 2,
    Success = 0,
  }
  [System.Runtime.Serialization.DataContractAttribute]
  public sealed partial class BookmarkScope : System.IEquatable<System.Activities.BookmarkScope> {
    public BookmarkScope(System.Guid id) { }
    public static System.Activities.BookmarkScope Default { get { return default(System.Activities.BookmarkScope); } }
    public System.Guid Id { get { return default(System.Guid); } }
    public bool IsInitialized { get { return default(bool); } }
    public bool Equals(System.Activities.BookmarkScope other) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public void Initialize(System.Activities.NativeActivityContext context, System.Guid id) { }
  }
  [System.Runtime.Serialization.DataContractAttribute]
  public sealed partial class BookmarkScopeHandle : System.Activities.Handle {
    public BookmarkScopeHandle() { }
    public System.Activities.BookmarkScope BookmarkScope { get { return default(System.Activities.BookmarkScope); } }
    public static System.Activities.BookmarkScopeHandle Default { get { return default(System.Activities.BookmarkScopeHandle); } }
    public void CreateBookmarkScope(System.Activities.NativeActivityContext context) { }
    public void CreateBookmarkScope(System.Activities.NativeActivityContext context, System.Guid scopeId) { }
    public void Initialize(System.Activities.NativeActivityContext context, System.Guid scope) { }
    protected override void OnUninitialize(System.Activities.HandleInitializationContext context) { }
  }
  public abstract partial class CodeActivity : System.Activities.Activity {
    protected CodeActivity() { }
    [System.Runtime.Serialization.IgnoreDataMemberAttribute]
    protected sealed override System.Func<System.Activities.Activity> Implementation { get { return default(System.Func<System.Activities.Activity>); } set { } }
    protected internal sealed override System.Version ImplementationVersion { get { return default(System.Version); } set { } }
    protected sealed override void CacheMetadata(System.Activities.ActivityMetadata metadata) { }
    protected virtual void CacheMetadata(System.Activities.CodeActivityMetadata metadata) { }
    protected abstract void Execute(System.Activities.CodeActivityContext context);
    protected sealed override void OnCreateDynamicUpdateMap(System.Activities.DynamicUpdate.UpdateMapMetadata metadata, System.Activities.Activity originalActivity) { }
  }
  public abstract partial class CodeActivity<TResult> : System.Activities.Activity<TResult> {
    protected CodeActivity() { }
    [System.Runtime.Serialization.IgnoreDataMemberAttribute]
    protected sealed override System.Func<System.Activities.Activity> Implementation { get { return default(System.Func<System.Activities.Activity>); } set { } }
    protected internal sealed override System.Version ImplementationVersion { get { return default(System.Version); } set { } }
    protected sealed override void CacheMetadata(System.Activities.ActivityMetadata metadata) { }
    protected virtual void CacheMetadata(System.Activities.CodeActivityMetadata metadata) { }
    protected abstract TResult Execute(System.Activities.CodeActivityContext context);
    protected sealed override void OnCreateDynamicUpdateMap(System.Activities.DynamicUpdate.UpdateMapMetadata metadata, System.Activities.Activity originalActivity) { }
  }
  public partial class CodeActivityContext : System.Activities.ActivityContext {
    internal CodeActivityContext() { }
    public THandle GetProperty<THandle>() where THandle : System.Activities.Handle { return default(THandle); }
    public void Track(System.Activities.Tracking.CustomTrackingRecord record) { }
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct CodeActivityMetadata {
    public System.Activities.LocationReferenceEnvironment Environment { get { return default(System.Activities.LocationReferenceEnvironment); } }
    public bool HasViolations { get { return default(bool); } }
    public void AddArgument(System.Activities.RuntimeArgument argument) { }
    public void AddDefaultExtensionProvider<T>(System.Func<T> extensionProvider) where T : class { }
    public void AddValidationError(System.Activities.Validation.ValidationError validationError) { }
    public void AddValidationError(string validationErrorMessage) { }
    public void Bind(System.Activities.Argument binding, System.Activities.RuntimeArgument argument) { }
    public override bool Equals(object obj) { return default(bool); }
    public System.Collections.ObjectModel.Collection<System.Activities.RuntimeArgument> GetArgumentsWithReflection() { return default(System.Collections.ObjectModel.Collection<System.Activities.RuntimeArgument>); }
    public override int GetHashCode() { return default(int); }
    public static bool operator ==(System.Activities.CodeActivityMetadata left, System.Activities.CodeActivityMetadata right) { return default(bool); }
    public static bool operator !=(System.Activities.CodeActivityMetadata left, System.Activities.CodeActivityMetadata right) { return default(bool); }
    public void RequireExtension(System.Type extensionType) { }
    public void RequireExtension<T>() where T : class { }
    public void SetArgumentsCollection(System.Collections.ObjectModel.Collection<System.Activities.RuntimeArgument> arguments) { }
    public void SetValidationErrorsCollection(System.Collections.ObjectModel.Collection<System.Activities.Validation.ValidationError> validationErrors) { }
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct CodeActivityPublicEnvironmentAccessor {
    public System.Activities.CodeActivityMetadata ActivityMetadata { get { return default(System.Activities.CodeActivityMetadata); } }
    public static System.Activities.CodeActivityPublicEnvironmentAccessor Create(System.Activities.CodeActivityMetadata metadata) { return default(System.Activities.CodeActivityPublicEnvironmentAccessor); }
    public override bool Equals(object obj) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public static bool operator ==(System.Activities.CodeActivityPublicEnvironmentAccessor left, System.Activities.CodeActivityPublicEnvironmentAccessor right) { return default(bool); }
    public static bool operator !=(System.Activities.CodeActivityPublicEnvironmentAccessor left, System.Activities.CodeActivityPublicEnvironmentAccessor right) { return default(bool); }
    public bool TryGetAccessToPublicLocation(System.Activities.LocationReference publicLocation, System.Activities.ArgumentDirection accessDirection, out System.Activities.LocationReference equivalentLocation) { equivalentLocation = default(System.Activities.LocationReference); return default(bool); }
    public bool TryGetReferenceToPublicLocation(System.Activities.LocationReference publicReference, out System.Activities.LocationReference equivalentReference) { equivalentReference = default(System.Activities.LocationReference); return default(bool); }
  }
  public delegate void CompletionCallback(System.Activities.NativeActivityContext context, System.Activities.ActivityInstance completedInstance);
  public delegate void CompletionCallback<TResult>(System.Activities.NativeActivityContext context, System.Activities.ActivityInstance completedInstance, TResult result);
  public abstract partial class DelegateArgument : System.Activities.LocationReference {
    internal DelegateArgument() { }
    public System.Activities.ArgumentDirection Direction { get { return default(System.Activities.ArgumentDirection); } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public new string Name { get { return default(string); } set { } }
    protected override string NameCore { get { return default(string); } }
    public object Get(System.Activities.ActivityContext context) { return default(object); }
    public override System.Activities.Location GetLocation(System.Activities.ActivityContext context) { return default(System.Activities.Location); }
  }
  public delegate void DelegateCompletionCallback(System.Activities.NativeActivityContext context, System.Activities.ActivityInstance completedInstance, System.Collections.Generic.IDictionary<System.String, System.Object> outArguments);
  public abstract partial class DelegateInArgument : System.Activities.DelegateArgument {
    internal DelegateInArgument() { }
  }
  public sealed partial class DelegateInArgument<T> : System.Activities.DelegateInArgument {
    public DelegateInArgument() { }
    public DelegateInArgument(string name) { }
    protected override System.Type TypeCore { get { return default(System.Type); } }
    public new T Get(System.Activities.ActivityContext context) { return default(T); }
    public void Set(System.Activities.ActivityContext context, T value) { }
  }
  public abstract partial class DelegateOutArgument : System.Activities.DelegateArgument {
    internal DelegateOutArgument() { }
  }
  public sealed partial class DelegateOutArgument<T> : System.Activities.DelegateOutArgument {
    public DelegateOutArgument() { }
    public DelegateOutArgument(string name) { }
    protected override System.Type TypeCore { get { return default(System.Type); } }
    public new T Get(System.Activities.ActivityContext context) { return default(T); }
    public new System.Activities.Location<T> GetLocation(System.Activities.ActivityContext context) { return default(System.Activities.Location<T>); }
    public void Set(System.Activities.ActivityContext context, T value) { }
  }
  [System.Windows.Markup.ContentPropertyAttribute("Implementation")]
  public sealed partial class DynamicActivity : System.Activities.Activity, System.ComponentModel.ICustomTypeDescriptor {
    public DynamicActivity() { }
    [System.Windows.Markup.DependsOnAttribute("Name")]
    public System.Collections.ObjectModel.Collection<System.Attribute> Attributes { get { return default(System.Collections.ObjectModel.Collection<System.Attribute>); } }
    [System.Windows.Markup.DependsOnAttribute("Properties")]
    public new System.Collections.ObjectModel.Collection<System.Activities.Validation.Constraint> Constraints { get { return default(System.Collections.ObjectModel.Collection<System.Activities.Validation.Constraint>); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute(null)]
    [System.Windows.Markup.AmbientAttribute]
    [System.Windows.Markup.XamlDeferLoadAttribute(typeof(System.Activities.XamlIntegration.FuncDeferringLoader), typeof(System.Activities.Activity))]
    public new System.Func<System.Activities.Activity> Implementation { get { return default(System.Func<System.Activities.Activity>); } set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Activities.XamlIntegration.ImplementationVersionConverter))]
    public new System.Version ImplementationVersion { get { return default(System.Version); } set { } }
    public string Name { get { return default(string); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.Windows.Markup.DependsOnAttribute("Attributes")]
    public System.Collections.ObjectModel.KeyedCollection<System.String, System.Activities.DynamicActivityProperty> Properties { get { return default(System.Collections.ObjectModel.KeyedCollection<System.String, System.Activities.DynamicActivityProperty>); } }
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
  [System.Windows.Markup.ContentPropertyAttribute("Implementation")]
  public sealed partial class DynamicActivity<TResult> : System.Activities.Activity<TResult>, System.ComponentModel.ICustomTypeDescriptor {
    public DynamicActivity() { }
    [System.Windows.Markup.DependsOnAttribute("Name")]
    public System.Collections.ObjectModel.Collection<System.Attribute> Attributes { get { return default(System.Collections.ObjectModel.Collection<System.Attribute>); } }
    [System.Windows.Markup.DependsOnAttribute("Properties")]
    public new System.Collections.ObjectModel.Collection<System.Activities.Validation.Constraint> Constraints { get { return default(System.Collections.ObjectModel.Collection<System.Activities.Validation.Constraint>); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute(null)]
    [System.Windows.Markup.AmbientAttribute]
    [System.Windows.Markup.XamlDeferLoadAttribute(typeof(System.Activities.XamlIntegration.FuncDeferringLoader), typeof(System.Activities.Activity))]
    public new System.Func<System.Activities.Activity> Implementation { get { return default(System.Func<System.Activities.Activity>); } set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Activities.XamlIntegration.ImplementationVersionConverter))]
    public new System.Version ImplementationVersion { get { return default(System.Version); } set { } }
    public string Name { get { return default(string); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.Windows.Markup.DependsOnAttribute("Attributes")]
    public System.Collections.ObjectModel.KeyedCollection<System.String, System.Activities.DynamicActivityProperty> Properties { get { return default(System.Collections.ObjectModel.KeyedCollection<System.String, System.Activities.DynamicActivityProperty>); } }
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
  public partial class DynamicActivityProperty {
    public DynamicActivityProperty() { }
    public System.Collections.ObjectModel.Collection<System.Attribute> Attributes { get { return default(System.Collections.ObjectModel.Collection<System.Attribute>); } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public string Name { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Type Type { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Type); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public object Value { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(object); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public override string ToString() { return default(string); }
  }
  public partial class ExceptionPersistenceExtension {
    public ExceptionPersistenceExtension() { }
    public bool PersistExceptions { get { return default(bool); } set { } }
  }
  [System.Runtime.Serialization.DataContractAttribute]
  public partial class ExclusiveHandle : System.Activities.Handle {
    public ExclusiveHandle() { }
    public System.Collections.ObjectModel.ReadOnlyCollection<System.Activities.BookmarkScopeHandle> RegisteredBookmarkScopes { get { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.Activities.BookmarkScopeHandle>); } }
    protected override void OnInitialize(System.Activities.HandleInitializationContext context) { }
    public void RegisterBookmarkScope(System.Activities.NativeActivityContext context, System.Activities.BookmarkScopeHandle bookmarkScopeHandle) { }
    public void Reinitialize(System.Activities.NativeActivityContext context) { }
  }
  public sealed partial class ExecutionProperties : System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>, System.Collections.IEnumerable {
    internal ExecutionProperties() { }
    public bool IsEmpty { get { return default(bool); } }
    public void Add(string name, object property) { }
    public void Add(string name, object property, bool onlyVisibleToPublicChildren) { }
    public object Find(string name) { return default(object); }
    public System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String, System.Object>> GetEnumerator() { return default(System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String, System.Object>>); }
    public bool Remove(string name) { return default(bool); }
    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { return default(System.Collections.IEnumerator); }
  }
  public delegate void FaultCallback(System.Activities.NativeActivityFaultContext faultContext, System.Exception propagatedException, System.Activities.ActivityInstance propagatedFrom);
  [System.Runtime.Serialization.DataContractAttribute]
  public abstract partial class Handle {
    protected Handle() { }
    public string ExecutionPropertyName { get { return default(string); } }
    public System.Activities.ActivityInstance Owner { get { return default(System.Activities.ActivityInstance); } }
    protected virtual void OnInitialize(System.Activities.HandleInitializationContext context) { }
    protected virtual void OnUninitialize(System.Activities.HandleInitializationContext context) { }
    protected void ThrowIfUninitialized() { }
  }
  public sealed partial class HandleInitializationContext {
    internal HandleInitializationContext() { }
    public THandle CreateAndInitializeHandle<THandle>() where THandle : System.Activities.Handle { return default(THandle); }
    public T GetExtension<T>() where T : class { return default(T); }
    public void UninitializeHandle(System.Activities.Handle handle) { }
  }
  public partial interface IExecutionProperty {
    void CleanupWorkflowThread();
    void SetupWorkflowThread();
  }
  public abstract partial class InArgument : System.Activities.Argument {
    internal InArgument() { }
    public static System.Activities.InArgument CreateReference(System.Activities.InArgument argumentToReference, string referencedArgumentName) { return default(System.Activities.InArgument); }
    public static System.Activities.InArgument CreateReference(System.Activities.InOutArgument argumentToReference, string referencedArgumentName) { return default(System.Activities.InArgument); }
  }
  [System.ComponentModel.TypeConverterAttribute(typeof(System.Activities.XamlIntegration.InArgumentConverter))]
  [System.Windows.Markup.ContentPropertyAttribute("Expression")]
  [System.Windows.Markup.ValueSerializerAttribute(typeof(System.Activities.XamlIntegration.ArgumentValueSerializer))]
  public sealed partial class InArgument<T> : System.Activities.InArgument {
    public InArgument() { }
    public InArgument(T constValue) { }
    public InArgument(System.Activities.Activity<T> expression) { }
    public InArgument(System.Activities.DelegateArgument delegateArgument) { }
    public InArgument(System.Activities.Variable variable) { }
    public InArgument(System.Linq.Expressions.Expression<System.Func<System.Activities.ActivityContext, T>> expression) { }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public new System.Activities.Activity<T> Expression { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.Activity<T>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public static System.Activities.InArgument<T> FromDelegateArgument(System.Activities.DelegateArgument delegateArgument) { return default(System.Activities.InArgument<T>); }
    public static System.Activities.InArgument<T> FromExpression(System.Activities.Activity<T> expression) { return default(System.Activities.InArgument<T>); }
    public static System.Activities.InArgument<T> FromValue(T constValue) { return default(System.Activities.InArgument<T>); }
    public static System.Activities.InArgument<T> FromVariable(System.Activities.Variable variable) { return default(System.Activities.InArgument<T>); }
    public new T Get(System.Activities.ActivityContext context) { return default(T); }
    public static implicit operator System.Activities.InArgument<T> (T constValue) { return default(System.Activities.InArgument<T>); }
    public static implicit operator System.Activities.InArgument<T> (System.Activities.Activity<T> expression) { return default(System.Activities.InArgument<T>); }
    public static implicit operator System.Activities.InArgument<T> (System.Activities.DelegateArgument delegateArgument) { return default(System.Activities.InArgument<T>); }
    public static implicit operator System.Activities.InArgument<T> (System.Activities.Variable variable) { return default(System.Activities.InArgument<T>); }
    public void Set(System.Activities.ActivityContext context, T value) { }
  }
  public abstract partial class InOutArgument : System.Activities.Argument {
    internal InOutArgument() { }
    public static System.Activities.InOutArgument CreateReference(System.Activities.InOutArgument argumentToReference, string referencedArgumentName) { return default(System.Activities.InOutArgument); }
  }
  [System.ComponentModel.TypeConverterAttribute(typeof(System.Activities.XamlIntegration.InOutArgumentConverter))]
  [System.Windows.Markup.ContentPropertyAttribute("Expression")]
  [System.Windows.Markup.ValueSerializerAttribute(typeof(System.Activities.XamlIntegration.ArgumentValueSerializer))]
  public sealed partial class InOutArgument<T> : System.Activities.InOutArgument {
    public InOutArgument() { }
    public InOutArgument(System.Activities.Activity<System.Activities.Location<T>> expression) { }
    public InOutArgument(System.Activities.Variable variable) { }
    public InOutArgument(System.Activities.Variable<T> variable) { }
    public InOutArgument(System.Linq.Expressions.Expression<System.Func<System.Activities.ActivityContext, T>> expression) { }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public new System.Activities.Activity<System.Activities.Location<T>> Expression { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.Activity<System.Activities.Location<T>>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public static System.Activities.InOutArgument<T> FromExpression(System.Activities.Activity<System.Activities.Location<T>> expression) { return default(System.Activities.InOutArgument<T>); }
    public static System.Activities.InOutArgument<T> FromVariable(System.Activities.Variable<T> variable) { return default(System.Activities.InOutArgument<T>); }
    public new T Get(System.Activities.ActivityContext context) { return default(T); }
    public new System.Activities.Location<T> GetLocation(System.Activities.ActivityContext context) { return default(System.Activities.Location<T>); }
    public static implicit operator System.Activities.InOutArgument<T> (System.Activities.Activity<System.Activities.Location<T>> expression) { return default(System.Activities.InOutArgument<T>); }
    public static implicit operator System.Activities.InOutArgument<T> (System.Activities.Variable<T> variable) { return default(System.Activities.InOutArgument<T>); }
    public void Set(System.Activities.ActivityContext context, T value) { }
  }
  public partial class InvalidWorkflowException : System.Exception {
    public InvalidWorkflowException() { }
    protected InvalidWorkflowException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public InvalidWorkflowException(string message) { }
    public InvalidWorkflowException(string message, System.Exception innerException) { }
  }
  public partial class InvokeCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
    internal InvokeCompletedEventArgs() { }
    public System.Collections.Generic.IDictionary<System.String, System.Object> Outputs { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Collections.Generic.IDictionary<System.String, System.Object>); } }
  }
  public partial interface IPropertyRegistrationCallback {
    void Register(System.Activities.RegistrationContext context);
    void Unregister(System.Activities.RegistrationContext context);
  }
  [System.Diagnostics.DebuggerDisplayAttribute("{Value}")]
  [System.Runtime.Serialization.DataContractAttribute]
  public abstract partial class Location {
    protected Location() { }
    public abstract System.Type LocationType { get; }
    public object Value { get { return default(object); } set { } }
    protected abstract object ValueCore { get; set; }
  }
  [System.Runtime.Serialization.DataContractAttribute]
  public partial class Location<T> : System.Activities.Location {
    public Location() { }
    public override System.Type LocationType { get { return default(System.Type); } }
    public virtual new T Value { get { return default(T); } set { } }
    protected sealed override object ValueCore { get { return default(object); } set { } }
    public override string ToString() { return default(string); }
  }
  public abstract partial class LocationReference {
    protected LocationReference() { }
    public string Name { get { return default(string); } }
    protected abstract string NameCore { get; }
    public System.Type Type { get { return default(System.Type); } }
    protected abstract System.Type TypeCore { get; }
    public abstract System.Activities.Location GetLocation(System.Activities.ActivityContext context);
  }
  public abstract partial class LocationReferenceEnvironment {
    protected LocationReferenceEnvironment() { }
    public System.Activities.LocationReferenceEnvironment Parent { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.LocationReferenceEnvironment); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]protected set { } }
    public abstract System.Activities.Activity Root { get; }
    public abstract System.Collections.Generic.IEnumerable<System.Activities.LocationReference> GetLocationReferences();
    public abstract bool IsVisible(System.Activities.LocationReference locationReference);
    public abstract bool TryGetLocationReference(string name, out System.Activities.LocationReference result);
  }
  public abstract partial class NativeActivity : System.Activities.Activity {
    protected NativeActivity() { }
    protected virtual bool CanInduceIdle { get { return default(bool); } }
    [System.Runtime.Serialization.IgnoreDataMemberAttribute]
    protected sealed override System.Func<System.Activities.Activity> Implementation { get { return default(System.Func<System.Activities.Activity>); } set { } }
    protected internal sealed override System.Version ImplementationVersion { get { return default(System.Version); } set { } }
    protected virtual void Abort(System.Activities.NativeActivityAbortContext context) { }
    protected sealed override void CacheMetadata(System.Activities.ActivityMetadata metadata) { }
    protected virtual void CacheMetadata(System.Activities.NativeActivityMetadata metadata) { }
    protected virtual void Cancel(System.Activities.NativeActivityContext context) { }
    protected abstract void Execute(System.Activities.NativeActivityContext context);
    protected virtual void OnCreateDynamicUpdateMap(System.Activities.DynamicUpdate.NativeActivityUpdateMapMetadata metadata, System.Activities.Activity originalActivity) { }
    protected sealed override void OnCreateDynamicUpdateMap(System.Activities.DynamicUpdate.UpdateMapMetadata metadata, System.Activities.Activity originalActivity) { }
    protected virtual void UpdateInstance(System.Activities.DynamicUpdate.NativeActivityUpdateContext updateContext) { }
  }
  public abstract partial class NativeActivity<TResult> : System.Activities.Activity<TResult> {
    protected NativeActivity() { }
    protected virtual bool CanInduceIdle { get { return default(bool); } }
    [System.Runtime.Serialization.IgnoreDataMemberAttribute]
    protected sealed override System.Func<System.Activities.Activity> Implementation { get { return default(System.Func<System.Activities.Activity>); } set { } }
    protected internal sealed override System.Version ImplementationVersion { get { return default(System.Version); } set { } }
    protected virtual void Abort(System.Activities.NativeActivityAbortContext context) { }
    protected sealed override void CacheMetadata(System.Activities.ActivityMetadata metadata) { }
    protected virtual void CacheMetadata(System.Activities.NativeActivityMetadata metadata) { }
    protected virtual void Cancel(System.Activities.NativeActivityContext context) { }
    protected abstract void Execute(System.Activities.NativeActivityContext context);
    protected virtual void OnCreateDynamicUpdateMap(System.Activities.DynamicUpdate.NativeActivityUpdateMapMetadata metadata, System.Activities.Activity originalActivity) { }
    protected sealed override void OnCreateDynamicUpdateMap(System.Activities.DynamicUpdate.UpdateMapMetadata metadata, System.Activities.Activity originalActivity) { }
    protected virtual void UpdateInstance(System.Activities.DynamicUpdate.NativeActivityUpdateContext updateContext) { }
  }
  public sealed partial class NativeActivityAbortContext : System.Activities.ActivityContext {
    internal NativeActivityAbortContext() { }
    public System.Exception Reason { get { return default(System.Exception); } }
  }
  public partial class NativeActivityContext : System.Activities.ActivityContext {
    internal NativeActivityContext() { }
    public System.Activities.BookmarkScope DefaultBookmarkScope { get { return default(System.Activities.BookmarkScope); } }
    public bool IsCancellationRequested { get { return default(bool); } }
    public System.Activities.ExecutionProperties Properties { get { return default(System.Activities.ExecutionProperties); } }
    public void Abort() { }
    public void Abort(System.Exception reason) { }
    public void AbortChildInstance(System.Activities.ActivityInstance activity) { }
    public void AbortChildInstance(System.Activities.ActivityInstance activity, System.Exception reason) { }
    public void CancelChild(System.Activities.ActivityInstance activityInstance) { }
    public void CancelChildren() { }
    public System.Activities.Bookmark CreateBookmark() { return default(System.Activities.Bookmark); }
    public System.Activities.Bookmark CreateBookmark(System.Activities.BookmarkCallback callback) { return default(System.Activities.Bookmark); }
    public System.Activities.Bookmark CreateBookmark(System.Activities.BookmarkCallback callback, System.Activities.BookmarkOptions options) { return default(System.Activities.Bookmark); }
    public System.Activities.Bookmark CreateBookmark(string name) { return default(System.Activities.Bookmark); }
    public System.Activities.Bookmark CreateBookmark(string name, System.Activities.BookmarkCallback callback) { return default(System.Activities.Bookmark); }
    public System.Activities.Bookmark CreateBookmark(string name, System.Activities.BookmarkCallback callback, System.Activities.BookmarkOptions options) { return default(System.Activities.Bookmark); }
    public System.Activities.Bookmark CreateBookmark(string name, System.Activities.BookmarkCallback callback, System.Activities.BookmarkScope scope) { return default(System.Activities.Bookmark); }
    public System.Activities.Bookmark CreateBookmark(string name, System.Activities.BookmarkCallback callback, System.Activities.BookmarkScope scope, System.Activities.BookmarkOptions options) { return default(System.Activities.Bookmark); }
    public System.Collections.ObjectModel.ReadOnlyCollection<System.Activities.ActivityInstance> GetChildren() { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.Activities.ActivityInstance>); }
    public object GetValue(System.Activities.Variable variable) { return default(object); }
    public T GetValue<T>(System.Activities.Variable<T> variable) { return default(T); }
    public void MarkCanceled() { }
    public void RemoveAllBookmarks() { }
    public bool RemoveBookmark(System.Activities.Bookmark bookmark) { return default(bool); }
    public bool RemoveBookmark(string name) { return default(bool); }
    public bool RemoveBookmark(string name, System.Activities.BookmarkScope scope) { return default(bool); }
    public System.Activities.BookmarkResumptionResult ResumeBookmark(System.Activities.Bookmark bookmark, object value) { return default(System.Activities.BookmarkResumptionResult); }
    public System.Activities.ActivityInstance ScheduleAction(System.Activities.ActivityAction activityAction, System.Activities.CompletionCallback onCompleted=null, System.Activities.FaultCallback onFaulted=null) { return default(System.Activities.ActivityInstance); }
    public System.Activities.ActivityInstance ScheduleAction<T>(System.Activities.ActivityAction<T> activityAction, T argument, System.Activities.CompletionCallback onCompleted=null, System.Activities.FaultCallback onFaulted=null) { return default(System.Activities.ActivityInstance); }
    public System.Activities.ActivityInstance ScheduleAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(System.Activities.ActivityAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> activityAction, T1 argument1, T2 argument2, T3 argument3, T4 argument4, T5 argument5, T6 argument6, T7 argument7, T8 argument8, T9 argument9, T10 argument10, System.Activities.CompletionCallback onCompleted=null, System.Activities.FaultCallback onFaulted=null) { return default(System.Activities.ActivityInstance); }
    public System.Activities.ActivityInstance ScheduleAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(System.Activities.ActivityAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> activityAction, T1 argument1, T2 argument2, T3 argument3, T4 argument4, T5 argument5, T6 argument6, T7 argument7, T8 argument8, T9 argument9, T10 argument10, T11 argument11, System.Activities.CompletionCallback onCompleted=null, System.Activities.FaultCallback onFaulted=null) { return default(System.Activities.ActivityInstance); }
    public System.Activities.ActivityInstance ScheduleAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(System.Activities.ActivityAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> activityAction, T1 argument1, T2 argument2, T3 argument3, T4 argument4, T5 argument5, T6 argument6, T7 argument7, T8 argument8, T9 argument9, T10 argument10, T11 argument11, T12 argument12, System.Activities.CompletionCallback onCompleted=null, System.Activities.FaultCallback onFaulted=null) { return default(System.Activities.ActivityInstance); }
    public System.Activities.ActivityInstance ScheduleAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(System.Activities.ActivityAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> activityAction, T1 argument1, T2 argument2, T3 argument3, T4 argument4, T5 argument5, T6 argument6, T7 argument7, T8 argument8, T9 argument9, T10 argument10, T11 argument11, T12 argument12, T13 argument13, System.Activities.CompletionCallback onCompleted=null, System.Activities.FaultCallback onFaulted=null) { return default(System.Activities.ActivityInstance); }
    public System.Activities.ActivityInstance ScheduleAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(System.Activities.ActivityAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> activityAction, T1 argument1, T2 argument2, T3 argument3, T4 argument4, T5 argument5, T6 argument6, T7 argument7, T8 argument8, T9 argument9, T10 argument10, T11 argument11, T12 argument12, T13 argument13, T14 argument14, System.Activities.CompletionCallback onCompleted=null, System.Activities.FaultCallback onFaulted=null) { return default(System.Activities.ActivityInstance); }
    public System.Activities.ActivityInstance ScheduleAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(System.Activities.ActivityAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> activityAction, T1 argument1, T2 argument2, T3 argument3, T4 argument4, T5 argument5, T6 argument6, T7 argument7, T8 argument8, T9 argument9, T10 argument10, T11 argument11, T12 argument12, T13 argument13, T14 argument14, T15 argument15, System.Activities.CompletionCallback onCompleted=null, System.Activities.FaultCallback onFaulted=null) { return default(System.Activities.ActivityInstance); }
    public System.Activities.ActivityInstance ScheduleAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(System.Activities.ActivityAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> activityAction, T1 argument1, T2 argument2, T3 argument3, T4 argument4, T5 argument5, T6 argument6, T7 argument7, T8 argument8, T9 argument9, T10 argument10, T11 argument11, T12 argument12, T13 argument13, T14 argument14, T15 argument15, T16 argument16, System.Activities.CompletionCallback onCompleted=null, System.Activities.FaultCallback onFaulted=null) { return default(System.Activities.ActivityInstance); }
    public System.Activities.ActivityInstance ScheduleAction<T1, T2>(System.Activities.ActivityAction<T1, T2> activityAction, T1 argument1, T2 argument2, System.Activities.CompletionCallback onCompleted=null, System.Activities.FaultCallback onFaulted=null) { return default(System.Activities.ActivityInstance); }
    public System.Activities.ActivityInstance ScheduleAction<T1, T2, T3>(System.Activities.ActivityAction<T1, T2, T3> activityAction, T1 argument1, T2 argument2, T3 argument3, System.Activities.CompletionCallback onCompleted=null, System.Activities.FaultCallback onFaulted=null) { return default(System.Activities.ActivityInstance); }
    public System.Activities.ActivityInstance ScheduleAction<T1, T2, T3, T4>(System.Activities.ActivityAction<T1, T2, T3, T4> activityAction, T1 argument1, T2 argument2, T3 argument3, T4 argument4, System.Activities.CompletionCallback onCompleted=null, System.Activities.FaultCallback onFaulted=null) { return default(System.Activities.ActivityInstance); }
    public System.Activities.ActivityInstance ScheduleAction<T1, T2, T3, T4, T5>(System.Activities.ActivityAction<T1, T2, T3, T4, T5> activityAction, T1 argument1, T2 argument2, T3 argument3, T4 argument4, T5 argument5, System.Activities.CompletionCallback onCompleted=null, System.Activities.FaultCallback onFaulted=null) { return default(System.Activities.ActivityInstance); }
    public System.Activities.ActivityInstance ScheduleAction<T1, T2, T3, T4, T5, T6>(System.Activities.ActivityAction<T1, T2, T3, T4, T5, T6> activityAction, T1 argument1, T2 argument2, T3 argument3, T4 argument4, T5 argument5, T6 argument6, System.Activities.CompletionCallback onCompleted=null, System.Activities.FaultCallback onFaulted=null) { return default(System.Activities.ActivityInstance); }
    public System.Activities.ActivityInstance ScheduleAction<T1, T2, T3, T4, T5, T6, T7>(System.Activities.ActivityAction<T1, T2, T3, T4, T5, T6, T7> activityAction, T1 argument1, T2 argument2, T3 argument3, T4 argument4, T5 argument5, T6 argument6, T7 argument7, System.Activities.CompletionCallback onCompleted=null, System.Activities.FaultCallback onFaulted=null) { return default(System.Activities.ActivityInstance); }
    public System.Activities.ActivityInstance ScheduleAction<T1, T2, T3, T4, T5, T6, T7, T8>(System.Activities.ActivityAction<T1, T2, T3, T4, T5, T6, T7, T8> activityAction, T1 argument1, T2 argument2, T3 argument3, T4 argument4, T5 argument5, T6 argument6, T7 argument7, T8 argument8, System.Activities.CompletionCallback onCompleted=null, System.Activities.FaultCallback onFaulted=null) { return default(System.Activities.ActivityInstance); }
    public System.Activities.ActivityInstance ScheduleAction<T1, T2, T3, T4, T5, T6, T7, T8, T9>(System.Activities.ActivityAction<T1, T2, T3, T4, T5, T6, T7, T8, T9> activityAction, T1 argument1, T2 argument2, T3 argument3, T4 argument4, T5 argument5, T6 argument6, T7 argument7, T8 argument8, T9 argument9, System.Activities.CompletionCallback onCompleted=null, System.Activities.FaultCallback onFaulted=null) { return default(System.Activities.ActivityInstance); }
    public System.Activities.ActivityInstance ScheduleActivity(System.Activities.Activity activity) { return default(System.Activities.ActivityInstance); }
    public System.Activities.ActivityInstance ScheduleActivity(System.Activities.Activity activity, System.Activities.CompletionCallback onCompleted) { return default(System.Activities.ActivityInstance); }
    public System.Activities.ActivityInstance ScheduleActivity(System.Activities.Activity activity, System.Activities.CompletionCallback onCompleted, System.Activities.FaultCallback onFaulted) { return default(System.Activities.ActivityInstance); }
    public System.Activities.ActivityInstance ScheduleActivity(System.Activities.Activity activity, System.Activities.FaultCallback onFaulted) { return default(System.Activities.ActivityInstance); }
    public System.Activities.ActivityInstance ScheduleActivity<TResult>(System.Activities.Activity<TResult> activity, System.Activities.CompletionCallback<TResult> onCompleted=null, System.Activities.FaultCallback onFaulted=null) { return default(System.Activities.ActivityInstance); }
    public System.Activities.ActivityInstance ScheduleDelegate(System.Activities.ActivityDelegate activityDelegate, System.Collections.Generic.IDictionary<System.String, System.Object> inputParameters, System.Activities.DelegateCompletionCallback onCompleted=null, System.Activities.FaultCallback onFaulted=null) { return default(System.Activities.ActivityInstance); }
    public System.Activities.ActivityInstance ScheduleFunc<TResult>(System.Activities.ActivityFunc<TResult> activityFunc, System.Activities.CompletionCallback<TResult> onCompleted=null, System.Activities.FaultCallback onFaulted=null) { return default(System.Activities.ActivityInstance); }
    public System.Activities.ActivityInstance ScheduleFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(System.Activities.ActivityFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> activityFunc, T1 argument1, T2 argument2, T3 argument3, T4 argument4, T5 argument5, T6 argument6, T7 argument7, T8 argument8, T9 argument9, System.Activities.CompletionCallback<TResult> onCompleted=null, System.Activities.FaultCallback onFaulted=null) { return default(System.Activities.ActivityInstance); }
    public System.Activities.ActivityInstance ScheduleFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(System.Activities.ActivityFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> activityFunc, T1 argument1, T2 argument2, T3 argument3, T4 argument4, T5 argument5, T6 argument6, T7 argument7, T8 argument8, T9 argument9, T10 argument10, System.Activities.CompletionCallback<TResult> onCompleted=null, System.Activities.FaultCallback onFaulted=null) { return default(System.Activities.ActivityInstance); }
    public System.Activities.ActivityInstance ScheduleFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(System.Activities.ActivityFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> activityFunc, T1 argument1, T2 argument2, T3 argument3, T4 argument4, T5 argument5, T6 argument6, T7 argument7, T8 argument8, T9 argument9, T10 argument10, T11 argument11, System.Activities.CompletionCallback<TResult> onCompleted=null, System.Activities.FaultCallback onFaulted=null) { return default(System.Activities.ActivityInstance); }
    public System.Activities.ActivityInstance ScheduleFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(System.Activities.ActivityFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> activityFunc, T1 argument1, T2 argument2, T3 argument3, T4 argument4, T5 argument5, T6 argument6, T7 argument7, T8 argument8, T9 argument9, T10 argument10, T11 argument11, T12 argument12, System.Activities.CompletionCallback<TResult> onCompleted=null, System.Activities.FaultCallback onFaulted=null) { return default(System.Activities.ActivityInstance); }
    public System.Activities.ActivityInstance ScheduleFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(System.Activities.ActivityFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> activityFunc, T1 argument1, T2 argument2, T3 argument3, T4 argument4, T5 argument5, T6 argument6, T7 argument7, T8 argument8, T9 argument9, T10 argument10, T11 argument11, T12 argument12, T13 argument13, System.Activities.CompletionCallback<TResult> onCompleted=null, System.Activities.FaultCallback onFaulted=null) { return default(System.Activities.ActivityInstance); }
    public System.Activities.ActivityInstance ScheduleFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(System.Activities.ActivityFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> activityFunc, T1 argument1, T2 argument2, T3 argument3, T4 argument4, T5 argument5, T6 argument6, T7 argument7, T8 argument8, T9 argument9, T10 argument10, T11 argument11, T12 argument12, T13 argument13, T14 argument14, System.Activities.CompletionCallback<TResult> onCompleted=null, System.Activities.FaultCallback onFaulted=null) { return default(System.Activities.ActivityInstance); }
    public System.Activities.ActivityInstance ScheduleFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(System.Activities.ActivityFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> activityFunc, T1 argument1, T2 argument2, T3 argument3, T4 argument4, T5 argument5, T6 argument6, T7 argument7, T8 argument8, T9 argument9, T10 argument10, T11 argument11, T12 argument12, T13 argument13, T14 argument14, T15 argument15, System.Activities.CompletionCallback<TResult> onCompleted=null, System.Activities.FaultCallback onFaulted=null) { return default(System.Activities.ActivityInstance); }
    public System.Activities.ActivityInstance ScheduleFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(System.Activities.ActivityFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> activityFunc, T1 argument1, T2 argument2, T3 argument3, T4 argument4, T5 argument5, T6 argument6, T7 argument7, T8 argument8, T9 argument9, T10 argument10, T11 argument11, T12 argument12, T13 argument13, T14 argument14, T15 argument15, T16 argument16, System.Activities.CompletionCallback<TResult> onCompleted=null, System.Activities.FaultCallback onFaulted=null) { return default(System.Activities.ActivityInstance); }
    public System.Activities.ActivityInstance ScheduleFunc<T, TResult>(System.Activities.ActivityFunc<T, TResult> activityFunc, T argument, System.Activities.CompletionCallback<TResult> onCompleted=null, System.Activities.FaultCallback onFaulted=null) { return default(System.Activities.ActivityInstance); }
    public System.Activities.ActivityInstance ScheduleFunc<T1, T2, TResult>(System.Activities.ActivityFunc<T1, T2, TResult> activityFunc, T1 argument1, T2 argument2, System.Activities.CompletionCallback<TResult> onCompleted=null, System.Activities.FaultCallback onFaulted=null) { return default(System.Activities.ActivityInstance); }
    public System.Activities.ActivityInstance ScheduleFunc<T1, T2, T3, TResult>(System.Activities.ActivityFunc<T1, T2, T3, TResult> activityFunc, T1 argument1, T2 argument2, T3 argument3, System.Activities.CompletionCallback<TResult> onCompleted=null, System.Activities.FaultCallback onFaulted=null) { return default(System.Activities.ActivityInstance); }
    public System.Activities.ActivityInstance ScheduleFunc<T1, T2, T3, T4, TResult>(System.Activities.ActivityFunc<T1, T2, T3, T4, TResult> activityFunc, T1 argument1, T2 argument2, T3 argument3, T4 argument4, System.Activities.CompletionCallback<TResult> onCompleted=null, System.Activities.FaultCallback onFaulted=null) { return default(System.Activities.ActivityInstance); }
    public System.Activities.ActivityInstance ScheduleFunc<T1, T2, T3, T4, T5, TResult>(System.Activities.ActivityFunc<T1, T2, T3, T4, T5, TResult> activityFunc, T1 argument1, T2 argument2, T3 argument3, T4 argument4, T5 argument5, System.Activities.CompletionCallback<TResult> onCompleted=null, System.Activities.FaultCallback onFaulted=null) { return default(System.Activities.ActivityInstance); }
    public System.Activities.ActivityInstance ScheduleFunc<T1, T2, T3, T4, T5, T6, TResult>(System.Activities.ActivityFunc<T1, T2, T3, T4, T5, T6, TResult> activityFunc, T1 argument1, T2 argument2, T3 argument3, T4 argument4, T5 argument5, T6 argument6, System.Activities.CompletionCallback<TResult> onCompleted=null, System.Activities.FaultCallback onFaulted=null) { return default(System.Activities.ActivityInstance); }
    public System.Activities.ActivityInstance ScheduleFunc<T1, T2, T3, T4, T5, T6, T7, TResult>(System.Activities.ActivityFunc<T1, T2, T3, T4, T5, T6, T7, TResult> activityFunc, T1 argument1, T2 argument2, T3 argument3, T4 argument4, T5 argument5, T6 argument6, T7 argument7, System.Activities.CompletionCallback<TResult> onCompleted=null, System.Activities.FaultCallback onFaulted=null) { return default(System.Activities.ActivityInstance); }
    public System.Activities.ActivityInstance ScheduleFunc<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(System.Activities.ActivityFunc<T1, T2, T3, T4, T5, T6, T7, T8, TResult> activityFunc, T1 argument1, T2 argument2, T3 argument3, T4 argument4, T5 argument5, T6 argument6, T7 argument7, T8 argument8, System.Activities.CompletionCallback<TResult> onCompleted=null, System.Activities.FaultCallback onFaulted=null) { return default(System.Activities.ActivityInstance); }
    public void SetValue(System.Activities.Variable variable, object value) { }
    public void SetValue<T>(System.Activities.Variable<T> variable, T value) { }
    public void Track(System.Activities.Tracking.CustomTrackingRecord record) { }
  }
  public sealed partial class NativeActivityFaultContext : System.Activities.NativeActivityContext {
    internal NativeActivityFaultContext() { }
    public void HandleFault() { }
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct NativeActivityMetadata {
    public System.Activities.LocationReferenceEnvironment Environment { get { return default(System.Activities.LocationReferenceEnvironment); } }
    public bool HasViolations { get { return default(bool); } }
    public void AddArgument(System.Activities.RuntimeArgument argument) { }
    public void AddChild(System.Activities.Activity child) { }
    public void AddChild(System.Activities.Activity child, object origin) { }
    public void AddDefaultExtensionProvider<T>(System.Func<T> extensionProvider) where T : class { }
    public void AddDelegate(System.Activities.ActivityDelegate activityDelegate) { }
    public void AddDelegate(System.Activities.ActivityDelegate activityDelegate, object origin) { }
    public void AddImplementationChild(System.Activities.Activity implementationChild) { }
    public void AddImplementationDelegate(System.Activities.ActivityDelegate implementationDelegate) { }
    public void AddImplementationVariable(System.Activities.Variable implementationVariable) { }
    public void AddImportedChild(System.Activities.Activity importedChild) { }
    public void AddImportedChild(System.Activities.Activity importedChild, object origin) { }
    public void AddImportedDelegate(System.Activities.ActivityDelegate importedDelegate) { }
    public void AddImportedDelegate(System.Activities.ActivityDelegate importedDelegate, object origin) { }
    public void AddValidationError(System.Activities.Validation.ValidationError validationError) { }
    public void AddValidationError(string validationErrorMessage) { }
    public void AddVariable(System.Activities.Variable variable) { }
    public void AddVariable(System.Activities.Variable variable, object origin) { }
    public void Bind(System.Activities.Argument binding, System.Activities.RuntimeArgument argument) { }
    public override bool Equals(object obj) { return default(bool); }
    public System.Collections.ObjectModel.Collection<System.Activities.RuntimeArgument> GetArgumentsWithReflection() { return default(System.Collections.ObjectModel.Collection<System.Activities.RuntimeArgument>); }
    public System.Collections.ObjectModel.Collection<System.Activities.Activity> GetChildrenWithReflection() { return default(System.Collections.ObjectModel.Collection<System.Activities.Activity>); }
    public System.Collections.ObjectModel.Collection<System.Activities.ActivityDelegate> GetDelegatesWithReflection() { return default(System.Collections.ObjectModel.Collection<System.Activities.ActivityDelegate>); }
    public override int GetHashCode() { return default(int); }
    public System.Collections.ObjectModel.Collection<System.Activities.Variable> GetVariablesWithReflection() { return default(System.Collections.ObjectModel.Collection<System.Activities.Variable>); }
    public static bool operator ==(System.Activities.NativeActivityMetadata left, System.Activities.NativeActivityMetadata right) { return default(bool); }
    public static bool operator !=(System.Activities.NativeActivityMetadata left, System.Activities.NativeActivityMetadata right) { return default(bool); }
    public void RequireExtension(System.Type extensionType) { }
    public void RequireExtension<T>() where T : class { }
    public void SetArgumentsCollection(System.Collections.ObjectModel.Collection<System.Activities.RuntimeArgument> arguments) { }
    public void SetChildrenCollection(System.Collections.ObjectModel.Collection<System.Activities.Activity> children) { }
    public void SetDelegatesCollection(System.Collections.ObjectModel.Collection<System.Activities.ActivityDelegate> delegates) { }
    public void SetImplementationChildrenCollection(System.Collections.ObjectModel.Collection<System.Activities.Activity> implementationChildren) { }
    public void SetImplementationDelegatesCollection(System.Collections.ObjectModel.Collection<System.Activities.ActivityDelegate> implementationDelegates) { }
    public void SetImplementationVariablesCollection(System.Collections.ObjectModel.Collection<System.Activities.Variable> implementationVariables) { }
    public void SetImportedChildrenCollection(System.Collections.ObjectModel.Collection<System.Activities.Activity> importedChildren) { }
    public void SetImportedDelegatesCollection(System.Collections.ObjectModel.Collection<System.Activities.ActivityDelegate> importedDelegates) { }
    public void SetValidationErrorsCollection(System.Collections.ObjectModel.Collection<System.Activities.Validation.ValidationError> validationErrors) { }
    public void SetVariablesCollection(System.Collections.ObjectModel.Collection<System.Activities.Variable> variables) { }
  }
  public sealed partial class NativeActivityTransactionContext : System.Activities.NativeActivityContext {
    internal NativeActivityTransactionContext() { }
    public void SetRuntimeTransaction(System.Transactions.Transaction transaction) { }
  }
  [System.Runtime.Serialization.DataContractAttribute]
  public partial class NoPersistHandle : System.Activities.Handle {
    public NoPersistHandle() { }
    public void Enter(System.Activities.NativeActivityContext context) { }
    public void Exit(System.Activities.NativeActivityContext context) { }
  }
  public abstract partial class OutArgument : System.Activities.Argument {
    internal OutArgument() { }
    public static System.Activities.OutArgument CreateReference(System.Activities.InOutArgument argumentToReference, string referencedArgumentName) { return default(System.Activities.OutArgument); }
    public static System.Activities.OutArgument CreateReference(System.Activities.OutArgument argumentToReference, string referencedArgumentName) { return default(System.Activities.OutArgument); }
  }
  [System.ComponentModel.TypeConverterAttribute(typeof(System.Activities.XamlIntegration.OutArgumentConverter))]
  [System.Windows.Markup.ContentPropertyAttribute("Expression")]
  [System.Windows.Markup.ValueSerializerAttribute(typeof(System.Activities.XamlIntegration.ArgumentValueSerializer))]
  public sealed partial class OutArgument<T> : System.Activities.OutArgument {
    public OutArgument() { }
    public OutArgument(System.Activities.Activity<System.Activities.Location<T>> expression) { }
    public OutArgument(System.Activities.DelegateArgument delegateArgument) { }
    public OutArgument(System.Activities.Variable variable) { }
    public OutArgument(System.Linq.Expressions.Expression<System.Func<System.Activities.ActivityContext, T>> expression) { }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public new System.Activities.Activity<System.Activities.Location<T>> Expression { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.Activity<System.Activities.Location<T>>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public static System.Activities.OutArgument<T> FromDelegateArgument(System.Activities.DelegateArgument delegateArgument) { return default(System.Activities.OutArgument<T>); }
    public static System.Activities.OutArgument<T> FromExpression(System.Activities.Activity<System.Activities.Location<T>> expression) { return default(System.Activities.OutArgument<T>); }
    public static System.Activities.OutArgument<T> FromVariable(System.Activities.Variable variable) { return default(System.Activities.OutArgument<T>); }
    public new T Get(System.Activities.ActivityContext context) { return default(T); }
    public new System.Activities.Location<T> GetLocation(System.Activities.ActivityContext context) { return default(System.Activities.Location<T>); }
    public static implicit operator System.Activities.OutArgument<T> (System.Activities.Activity<System.Activities.Location<T>> expression) { return default(System.Activities.OutArgument<T>); }
    public static implicit operator System.Activities.OutArgument<T> (System.Activities.DelegateArgument delegateArgument) { return default(System.Activities.OutArgument<T>); }
    public static implicit operator System.Activities.OutArgument<T> (System.Activities.Variable variable) { return default(System.Activities.OutArgument<T>); }
    public void Set(System.Activities.ActivityContext context, T value) { }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(128), AllowMultiple=true)]
  public sealed partial class OverloadGroupAttribute : System.Attribute {
    public OverloadGroupAttribute() { }
    public OverloadGroupAttribute(string groupName) { }
    public string GroupName { get { return default(string); } set { } }
    public override object TypeId { get { return default(object); } }
  }
  public enum PersistableIdleAction {
    None = 0,
    Persist = 2,
    Unload = 1,
  }
  public sealed partial class RegistrationContext {
    internal RegistrationContext() { }
    public object FindProperty(string name) { return default(object); }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(128))]
  public sealed partial class RequiredArgumentAttribute : System.Attribute {
    public RequiredArgumentAttribute() { }
    public override object TypeId { get { return default(object); } }
  }
  public sealed partial class RuntimeArgument : System.Activities.LocationReference {
    public RuntimeArgument(string name, System.Type argumentType, System.Activities.ArgumentDirection direction) { }
    public RuntimeArgument(string name, System.Type argumentType, System.Activities.ArgumentDirection direction, bool isRequired) { }
    public RuntimeArgument(string name, System.Type argumentType, System.Activities.ArgumentDirection direction, bool isRequired, System.Collections.Generic.List<System.String> overloadGroupNames) { }
    public RuntimeArgument(string name, System.Type argumentType, System.Activities.ArgumentDirection direction, System.Collections.Generic.List<System.String> overloadGroupNames) { }
    public System.Activities.ArgumentDirection Direction { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.ArgumentDirection); } }
    public bool IsRequired { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } }
    protected override string NameCore { get { return default(string); } }
    public System.Collections.ObjectModel.ReadOnlyCollection<System.String> OverloadGroupNames { get { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.String>); } }
    protected override System.Type TypeCore { get { return default(System.Type); } }
    public object Get(System.Activities.ActivityContext context) { return default(object); }
    public T Get<T>(System.Activities.ActivityContext context) { return default(T); }
    public override System.Activities.Location GetLocation(System.Activities.ActivityContext context) { return default(System.Activities.Location); }
    public void Set(System.Activities.ActivityContext context, object value) { }
  }
  public sealed partial class RuntimeDelegateArgument {
    public RuntimeDelegateArgument(string name, System.Type type, System.Activities.ArgumentDirection direction, System.Activities.DelegateArgument boundArgument) { }
    public System.Activities.DelegateArgument BoundArgument { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateArgument); } }
    public System.Activities.ArgumentDirection Direction { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.ArgumentDirection); } }
    public string Name { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
    public System.Type Type { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Type); } }
  }
  [System.Runtime.Serialization.DataContractAttribute]
  public sealed partial class RuntimeTransactionHandle : System.Activities.Handle, System.Activities.IExecutionProperty, System.Activities.IPropertyRegistrationCallback {
    public RuntimeTransactionHandle() { }
    public RuntimeTransactionHandle(System.Transactions.Transaction rootTransaction) { }
    public bool AbortInstanceOnTransactionFailure { get { return default(bool); } set { } }
    public bool SuppressTransaction { get { return default(bool); } set { } }
    public void CompleteTransaction(System.Activities.NativeActivityContext context) { }
    public void CompleteTransaction(System.Activities.NativeActivityContext context, System.Activities.BookmarkCallback callback) { }
    public System.Transactions.Transaction GetCurrentTransaction(System.Activities.AsyncCodeActivityContext context) { return default(System.Transactions.Transaction); }
    public System.Transactions.Transaction GetCurrentTransaction(System.Activities.CodeActivityContext context) { return default(System.Transactions.Transaction); }
    public System.Transactions.Transaction GetCurrentTransaction(System.Activities.NativeActivityContext context) { return default(System.Transactions.Transaction); }
    protected override void OnInitialize(System.Activities.HandleInitializationContext context) { }
    protected override void OnUninitialize(System.Activities.HandleInitializationContext context) { }
    public void RequestTransactionContext(System.Activities.NativeActivityContext context, System.Action<System.Activities.NativeActivityTransactionContext, System.Object> callback, object state) { }
    public void RequireTransactionContext(System.Activities.NativeActivityContext context, System.Action<System.Activities.NativeActivityTransactionContext, System.Object> callback, object state) { }
    void System.Activities.IExecutionProperty.CleanupWorkflowThread() { }
    void System.Activities.IExecutionProperty.SetupWorkflowThread() { }
    void System.Activities.IPropertyRegistrationCallback.Register(System.Activities.RegistrationContext context) { }
    void System.Activities.IPropertyRegistrationCallback.Unregister(System.Activities.RegistrationContext context) { }
  }
  public enum UnhandledExceptionAction {
    Abort = 0,
    Cancel = 1,
    Terminate = 2,
  }
  public partial class ValidationException : System.SystemException {
    public ValidationException() { }
    protected ValidationException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public ValidationException(string message) { }
    public ValidationException(string message, System.Exception innerException) { }
  }
  [System.Diagnostics.DebuggerDisplayAttribute("Name = {Name}, Type = {Type}")]
  public abstract partial class Variable : System.Activities.LocationReference {
    internal Variable() { }
    [System.ComponentModel.DefaultValueAttribute(null)]
    [System.Runtime.Serialization.IgnoreDataMemberAttribute]
    public System.Activities.ActivityWithResult Default { get { return default(System.Activities.ActivityWithResult); } set { } }
    [System.ComponentModel.DefaultValueAttribute((System.Activities.VariableModifiers)(0))]
    public System.Activities.VariableModifiers Modifiers { get { return default(System.Activities.VariableModifiers); } set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public new string Name { get { return default(string); } set { } }
    protected override string NameCore { get { return default(string); } }
    public static System.Activities.Variable Create(string name, System.Type type, System.Activities.VariableModifiers modifiers) { return default(System.Activities.Variable); }
    public object Get(System.Activities.ActivityContext context) { return default(object); }
    public override System.Activities.Location GetLocation(System.Activities.ActivityContext context) { return default(System.Activities.Location); }
    public void Set(System.Activities.ActivityContext context, object value) { }
  }
  public sealed partial class Variable<T> : System.Activities.Variable {
    public Variable() { }
    public Variable(System.Linq.Expressions.Expression<System.Func<System.Activities.ActivityContext, T>> defaultExpression) { }
    public Variable(string name) { }
    public Variable(string name, T defaultValue) { }
    public Variable(string name, System.Linq.Expressions.Expression<System.Func<System.Activities.ActivityContext, T>> defaultExpression) { }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public new System.Activities.Activity<T> Default { get { return default(System.Activities.Activity<T>); } set { } }
    protected override System.Type TypeCore { get { return default(System.Type); } }
    public new T Get(System.Activities.ActivityContext context) { return default(T); }
    public new System.Activities.Location<T> GetLocation(System.Activities.ActivityContext context) { return default(System.Activities.Location<T>); }
    public void Set(System.Activities.ActivityContext context, T value) { }
  }
  [System.FlagsAttribute]
  public enum VariableModifiers {
    Mapped = 2,
    None = 0,
    ReadOnly = 1,
  }
  public partial class VersionMismatchException : System.Exception {
    public VersionMismatchException() { }
    public VersionMismatchException(System.Activities.WorkflowIdentity expectedVersion, System.Activities.WorkflowIdentity actualVersion) { }
    protected VersionMismatchException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public VersionMismatchException(string message) { }
    public VersionMismatchException(string message, System.Activities.WorkflowIdentity expectedVersion, System.Activities.WorkflowIdentity actualVersion) { }
    public VersionMismatchException(string message, System.Activities.WorkflowIdentity expectedVersion, System.Activities.WorkflowIdentity actualVersion, System.Exception innerException) { }
    public VersionMismatchException(string message, System.Exception innerException) { }
    public System.Activities.WorkflowIdentity ActualVersion { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.WorkflowIdentity); } }
    public System.Activities.WorkflowIdentity ExpectedVersion { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.WorkflowIdentity); } }
    [System.Security.SecurityCriticalAttribute]
    public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
  }
  public sealed partial class WorkflowApplication : System.Activities.Hosting.WorkflowInstance {
    public WorkflowApplication(System.Activities.Activity workflowDefinition) : base (default(System.Activities.Activity)) { }
    public WorkflowApplication(System.Activities.Activity workflowDefinition, System.Activities.WorkflowIdentity definitionIdentity) : base (default(System.Activities.Activity)) { }
    public WorkflowApplication(System.Activities.Activity workflowDefinition, System.Collections.Generic.IDictionary<System.String, System.Object> inputs) : base (default(System.Activities.Activity)) { }
    public WorkflowApplication(System.Activities.Activity workflowDefinition, System.Collections.Generic.IDictionary<System.String, System.Object> inputs, System.Activities.WorkflowIdentity definitionIdentity) : base (default(System.Activities.Activity)) { }
    public System.Action<System.Activities.WorkflowApplicationAbortedEventArgs> Aborted { get { return default(System.Action<System.Activities.WorkflowApplicationAbortedEventArgs>); } set { } }
    public System.Action<System.Activities.WorkflowApplicationCompletedEventArgs> Completed { get { return default(System.Action<System.Activities.WorkflowApplicationCompletedEventArgs>); } set { } }
    public System.Activities.Hosting.WorkflowInstanceExtensionManager Extensions { get { return default(System.Activities.Hosting.WorkflowInstanceExtensionManager); } }
    public override System.Guid Id { get { return default(System.Guid); } }
    public System.Action<System.Activities.WorkflowApplicationIdleEventArgs> Idle { get { return default(System.Action<System.Activities.WorkflowApplicationIdleEventArgs>); } set { } }
    public System.Runtime.DurableInstancing.InstanceStore InstanceStore { get { return default(System.Runtime.DurableInstancing.InstanceStore); } set { } }
    public System.Func<System.Activities.WorkflowApplicationUnhandledExceptionEventArgs, System.Activities.UnhandledExceptionAction> OnUnhandledException { get { return default(System.Func<System.Activities.WorkflowApplicationUnhandledExceptionEventArgs, System.Activities.UnhandledExceptionAction>); } set { } }
    public System.Func<System.Activities.WorkflowApplicationIdleEventArgs, System.Activities.PersistableIdleAction> PersistableIdle { get { return default(System.Func<System.Activities.WorkflowApplicationIdleEventArgs, System.Activities.PersistableIdleAction>); } set { } }
    protected internal override bool SupportsInstanceKeys { get { return default(bool); } }
    public System.Action<System.Activities.WorkflowApplicationEventArgs> Unloaded { get { return default(System.Action<System.Activities.WorkflowApplicationEventArgs>); } set { } }
    public void Abort() { }
    public void Abort(string reason) { }
    public void AddInitialInstanceValues(System.Collections.Generic.IDictionary<System.Xml.Linq.XName, System.Object> writeOnlyValues) { }
    public System.IAsyncResult BeginCancel(System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    public System.IAsyncResult BeginCancel(System.TimeSpan timeout, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    public static System.IAsyncResult BeginCreateDefaultInstanceOwner(System.Runtime.DurableInstancing.InstanceStore instanceStore, System.Activities.WorkflowIdentity definitionIdentity, System.Activities.WorkflowIdentityFilter identityFilter, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    public static System.IAsyncResult BeginCreateDefaultInstanceOwner(System.Runtime.DurableInstancing.InstanceStore instanceStore, System.Activities.WorkflowIdentity definitionIdentity, System.Activities.WorkflowIdentityFilter identityFilter, System.TimeSpan timeout, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    public static System.IAsyncResult BeginDeleteDefaultInstanceOwner(System.Runtime.DurableInstancing.InstanceStore instanceStore, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    public static System.IAsyncResult BeginDeleteDefaultInstanceOwner(System.Runtime.DurableInstancing.InstanceStore instanceStore, System.TimeSpan timeout, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    public static System.IAsyncResult BeginGetInstance(System.Guid instanceId, System.Runtime.DurableInstancing.InstanceStore instanceStore, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    public static System.IAsyncResult BeginGetInstance(System.Guid instanceId, System.Runtime.DurableInstancing.InstanceStore instanceStore, System.TimeSpan timeout, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    public static System.IAsyncResult BeginGetRunnableInstance(System.Runtime.DurableInstancing.InstanceStore instanceStore, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    public static System.IAsyncResult BeginGetRunnableInstance(System.Runtime.DurableInstancing.InstanceStore instanceStore, System.TimeSpan timeout, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    public System.IAsyncResult BeginLoad(System.Activities.WorkflowApplicationInstance instance, System.Activities.DynamicUpdate.DynamicUpdateMap updateMap, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    public System.IAsyncResult BeginLoad(System.Activities.WorkflowApplicationInstance instance, System.Activities.DynamicUpdate.DynamicUpdateMap updateMap, System.TimeSpan timeout, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    public System.IAsyncResult BeginLoad(System.Activities.WorkflowApplicationInstance instance, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    public System.IAsyncResult BeginLoad(System.Activities.WorkflowApplicationInstance instance, System.TimeSpan timeout, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    public System.IAsyncResult BeginLoad(System.Guid instanceId, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    public System.IAsyncResult BeginLoad(System.Guid instanceId, System.TimeSpan timeout, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    public System.IAsyncResult BeginLoadRunnableInstance(System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    public System.IAsyncResult BeginLoadRunnableInstance(System.TimeSpan timeout, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    public System.IAsyncResult BeginPersist(System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    public System.IAsyncResult BeginPersist(System.TimeSpan timeout, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    public System.IAsyncResult BeginResumeBookmark(System.Activities.Bookmark bookmark, object value, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    public System.IAsyncResult BeginResumeBookmark(System.Activities.Bookmark bookmark, object value, System.TimeSpan timeout, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    public System.IAsyncResult BeginResumeBookmark(string bookmarkName, object value, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    public System.IAsyncResult BeginResumeBookmark(string bookmarkName, object value, System.TimeSpan timeout, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    public System.IAsyncResult BeginRun(System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    public System.IAsyncResult BeginRun(System.TimeSpan timeout, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    public System.IAsyncResult BeginTerminate(System.Exception reason, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    public System.IAsyncResult BeginTerminate(System.Exception reason, System.TimeSpan timeout, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    public System.IAsyncResult BeginTerminate(string reason, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    public System.IAsyncResult BeginTerminate(string reason, System.TimeSpan timeout, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    public System.IAsyncResult BeginUnload(System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    public System.IAsyncResult BeginUnload(System.TimeSpan timeout, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    public void Cancel() { }
    public void Cancel(System.TimeSpan timeout) { }
    public static void CreateDefaultInstanceOwner(System.Runtime.DurableInstancing.InstanceStore instanceStore, System.Activities.WorkflowIdentity definitionIdentity, System.Activities.WorkflowIdentityFilter identityFilter) { }
    public static void CreateDefaultInstanceOwner(System.Runtime.DurableInstancing.InstanceStore instanceStore, System.Activities.WorkflowIdentity definitionIdentity, System.Activities.WorkflowIdentityFilter identityFilter, System.TimeSpan timeout) { }
    public static void DeleteDefaultInstanceOwner(System.Runtime.DurableInstancing.InstanceStore instanceStore) { }
    public static void DeleteDefaultInstanceOwner(System.Runtime.DurableInstancing.InstanceStore instanceStore, System.TimeSpan timeout) { }
    public void EndCancel(System.IAsyncResult result) { }
    public static void EndCreateDefaultInstanceOwner(System.IAsyncResult asyncResult) { }
    public static void EndDeleteDefaultInstanceOwner(System.IAsyncResult asyncResult) { }
    public static System.Activities.WorkflowApplicationInstance EndGetInstance(System.IAsyncResult asyncResult) { return default(System.Activities.WorkflowApplicationInstance); }
    public static System.Activities.WorkflowApplicationInstance EndGetRunnableInstance(System.IAsyncResult asyncResult) { return default(System.Activities.WorkflowApplicationInstance); }
    public void EndLoad(System.IAsyncResult result) { }
    public void EndLoadRunnableInstance(System.IAsyncResult result) { }
    public void EndPersist(System.IAsyncResult result) { }
    public System.Activities.BookmarkResumptionResult EndResumeBookmark(System.IAsyncResult result) { return default(System.Activities.BookmarkResumptionResult); }
    public void EndRun(System.IAsyncResult result) { }
    public void EndTerminate(System.IAsyncResult result) { }
    public void EndUnload(System.IAsyncResult result) { }
    public System.Collections.ObjectModel.ReadOnlyCollection<System.Activities.Hosting.BookmarkInfo> GetBookmarks() { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.Activities.Hosting.BookmarkInfo>); }
    public System.Collections.ObjectModel.ReadOnlyCollection<System.Activities.Hosting.BookmarkInfo> GetBookmarks(System.TimeSpan timeout) { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.Activities.Hosting.BookmarkInfo>); }
    public static System.Activities.WorkflowApplicationInstance GetInstance(System.Guid instanceId, System.Runtime.DurableInstancing.InstanceStore instanceStore) { return default(System.Activities.WorkflowApplicationInstance); }
    public static System.Activities.WorkflowApplicationInstance GetInstance(System.Guid instanceId, System.Runtime.DurableInstancing.InstanceStore instanceStore, System.TimeSpan timeout) { return default(System.Activities.WorkflowApplicationInstance); }
    public static System.Activities.WorkflowApplicationInstance GetRunnableInstance(System.Runtime.DurableInstancing.InstanceStore instanceStore) { return default(System.Activities.WorkflowApplicationInstance); }
    public static System.Activities.WorkflowApplicationInstance GetRunnableInstance(System.Runtime.DurableInstancing.InstanceStore instanceStore, System.TimeSpan timeout) { return default(System.Activities.WorkflowApplicationInstance); }
    public void Load(System.Activities.WorkflowApplicationInstance instance) { }
    public void Load(System.Activities.WorkflowApplicationInstance instance, System.Activities.DynamicUpdate.DynamicUpdateMap updateMap) { }
    public void Load(System.Activities.WorkflowApplicationInstance instance, System.Activities.DynamicUpdate.DynamicUpdateMap updateMap, System.TimeSpan timeout) { }
    public void Load(System.Activities.WorkflowApplicationInstance instance, System.TimeSpan timeout) { }
    public void Load(System.Guid instanceId) { }
    public void Load(System.Guid instanceId, System.TimeSpan timeout) { }
    public void LoadRunnableInstance() { }
    public void LoadRunnableInstance(System.TimeSpan timeout) { }
    protected internal override System.IAsyncResult OnBeginAssociateKeys(System.Collections.Generic.ICollection<System.Runtime.DurableInstancing.InstanceKey> keys, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    protected internal override System.IAsyncResult OnBeginPersist(System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    protected internal override System.IAsyncResult OnBeginResumeBookmark(System.Activities.Bookmark bookmark, object value, System.TimeSpan timeout, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    protected internal override void OnDisassociateKeys(System.Collections.Generic.ICollection<System.Runtime.DurableInstancing.InstanceKey> keys) { }
    protected internal override void OnEndAssociateKeys(System.IAsyncResult result) { }
    protected internal override void OnEndPersist(System.IAsyncResult result) { }
    protected internal override System.Activities.BookmarkResumptionResult OnEndResumeBookmark(System.IAsyncResult result) { return default(System.Activities.BookmarkResumptionResult); }
    protected override void OnNotifyPaused() { }
    protected override void OnNotifyUnhandledException(System.Exception exception, System.Activities.Activity exceptionSource, string exceptionSourceInstanceId) { }
    protected internal override void OnRequestAbort(System.Exception reason) { }
    public void Persist() { }
    public void Persist(System.TimeSpan timeout) { }
    public System.Activities.BookmarkResumptionResult ResumeBookmark(System.Activities.Bookmark bookmark, object value) { return default(System.Activities.BookmarkResumptionResult); }
    public System.Activities.BookmarkResumptionResult ResumeBookmark(System.Activities.Bookmark bookmark, object value, System.TimeSpan timeout) { return default(System.Activities.BookmarkResumptionResult); }
    public System.Activities.BookmarkResumptionResult ResumeBookmark(string bookmarkName, object value) { return default(System.Activities.BookmarkResumptionResult); }
    public System.Activities.BookmarkResumptionResult ResumeBookmark(string bookmarkName, object value, System.TimeSpan timeout) { return default(System.Activities.BookmarkResumptionResult); }
    public void Run() { }
    public void Run(System.TimeSpan timeout) { }
    public void Terminate(System.Exception reason) { }
    public void Terminate(System.Exception reason, System.TimeSpan timeout) { }
    public void Terminate(string reason) { }
    public void Terminate(string reason, System.TimeSpan timeout) { }
    public void Unload() { }
    public void Unload(System.TimeSpan timeout) { }
  }
  public partial class WorkflowApplicationAbortedEventArgs : System.Activities.WorkflowApplicationEventArgs {
    internal WorkflowApplicationAbortedEventArgs() { }
    public System.Exception Reason { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Exception); } }
  }
  public partial class WorkflowApplicationAbortedException : System.Activities.WorkflowApplicationException {
    public WorkflowApplicationAbortedException() { }
    protected WorkflowApplicationAbortedException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public WorkflowApplicationAbortedException(string message) { }
    public WorkflowApplicationAbortedException(string message, System.Exception innerException) { }
    public WorkflowApplicationAbortedException(string message, System.Guid instanceId) { }
    public WorkflowApplicationAbortedException(string message, System.Guid instanceId, System.Exception innerException) { }
  }
  public partial class WorkflowApplicationCompletedEventArgs : System.Activities.WorkflowApplicationEventArgs {
    internal WorkflowApplicationCompletedEventArgs() { }
    public System.Activities.ActivityInstanceState CompletionState { get { return default(System.Activities.ActivityInstanceState); } }
    public System.Collections.Generic.IDictionary<System.String, System.Object> Outputs { get { return default(System.Collections.Generic.IDictionary<System.String, System.Object>); } }
    public System.Exception TerminationException { get { return default(System.Exception); } }
  }
  public partial class WorkflowApplicationCompletedException : System.Activities.WorkflowApplicationException {
    public WorkflowApplicationCompletedException() { }
    protected WorkflowApplicationCompletedException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public WorkflowApplicationCompletedException(string message) { }
    public WorkflowApplicationCompletedException(string message, System.Exception innerException) { }
    public WorkflowApplicationCompletedException(string message, System.Guid instanceId) { }
    public WorkflowApplicationCompletedException(string message, System.Guid instanceId, System.Exception innerException) { }
  }
  public partial class WorkflowApplicationEventArgs : System.EventArgs {
    internal WorkflowApplicationEventArgs() { }
    public System.Guid InstanceId { get { return default(System.Guid); } }
    public System.Collections.Generic.IEnumerable<T> GetInstanceExtensions<T>() where T : class { return default(System.Collections.Generic.IEnumerable<T>); }
  }
  public partial class WorkflowApplicationException : System.Exception {
    public WorkflowApplicationException() { }
    protected WorkflowApplicationException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public WorkflowApplicationException(string message) { }
    public WorkflowApplicationException(string message, System.Exception innerException) { }
    public WorkflowApplicationException(string message, System.Guid instanceId) { }
    public WorkflowApplicationException(string message, System.Guid instanceId, System.Exception innerException) { }
    public System.Guid InstanceId { get { return default(System.Guid); } }
    [System.Security.SecurityCriticalAttribute]
    public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
  }
  public partial class WorkflowApplicationIdleEventArgs : System.Activities.WorkflowApplicationEventArgs {
    internal WorkflowApplicationIdleEventArgs() { }
    public System.Collections.ObjectModel.ReadOnlyCollection<System.Activities.Hosting.BookmarkInfo> Bookmarks { get { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.Activities.Hosting.BookmarkInfo>); } }
  }
  public partial class WorkflowApplicationInstance {
    internal WorkflowApplicationInstance() { }
    public System.Activities.WorkflowIdentity DefinitionIdentity { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.WorkflowIdentity); } }
    public System.Guid InstanceId { get { return default(System.Guid); } }
    public System.Runtime.DurableInstancing.InstanceStore InstanceStore { get { return default(System.Runtime.DurableInstancing.InstanceStore); } }
    public void Abandon() { }
    public void Abandon(System.TimeSpan timeout) { }
    public System.IAsyncResult BeginAbandon(System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    public System.IAsyncResult BeginAbandon(System.TimeSpan timeout, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    public bool CanApplyUpdate(System.Activities.DynamicUpdate.DynamicUpdateMap updateMap, out System.Collections.Generic.IList<System.Activities.DynamicUpdate.ActivityBlockingUpdate> activitiesBlockingUpdate) { activitiesBlockingUpdate = default(System.Collections.Generic.IList<System.Activities.DynamicUpdate.ActivityBlockingUpdate>); return default(bool); }
    public void EndAbandon(System.IAsyncResult asyncResult) { }
  }
  public partial class WorkflowApplicationTerminatedException : System.Activities.WorkflowApplicationCompletedException {
    public WorkflowApplicationTerminatedException() { }
    protected WorkflowApplicationTerminatedException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public WorkflowApplicationTerminatedException(string message) { }
    public WorkflowApplicationTerminatedException(string message, System.Exception innerException) { }
    public WorkflowApplicationTerminatedException(string message, System.Guid instanceId) { }
    public WorkflowApplicationTerminatedException(string message, System.Guid instanceId, System.Exception innerException) { }
  }
  public partial class WorkflowApplicationUnhandledExceptionEventArgs : System.Activities.WorkflowApplicationEventArgs {
    internal WorkflowApplicationUnhandledExceptionEventArgs() { }
    public System.Activities.Activity ExceptionSource { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.Activity); } }
    public string ExceptionSourceInstanceId { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
    public System.Exception UnhandledException { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Exception); } }
  }
  public partial class WorkflowApplicationUnloadedException : System.Activities.WorkflowApplicationException {
    public WorkflowApplicationUnloadedException() { }
    protected WorkflowApplicationUnloadedException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public WorkflowApplicationUnloadedException(string message) { }
    public WorkflowApplicationUnloadedException(string message, System.Exception innerException) { }
    public WorkflowApplicationUnloadedException(string message, System.Guid instanceId) { }
    public WorkflowApplicationUnloadedException(string message, System.Guid instanceId, System.Exception innerException) { }
  }
  public sealed partial class WorkflowDataContext : System.ComponentModel.CustomTypeDescriptor, System.ComponentModel.INotifyPropertyChanged, System.IDisposable {
    internal WorkflowDataContext() { }
    public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged { add { } remove { } }
    public void Dispose() { }
    public override System.ComponentModel.PropertyDescriptorCollection GetProperties() { return default(System.ComponentModel.PropertyDescriptorCollection); }
  }
  [System.ComponentModel.TypeConverterAttribute(typeof(System.Activities.XamlIntegration.WorkflowIdentityConverter))]
  [System.Runtime.Serialization.DataContractAttribute]
  public partial class WorkflowIdentity : System.IEquatable<System.Activities.WorkflowIdentity> {
    public WorkflowIdentity() { }
    public WorkflowIdentity(string name, System.Version version, string package) { }
    public string Name { get { return default(string); } set { } }
    public string Package { get { return default(string); } set { } }
    public System.Version Version { get { return default(System.Version); } set { } }
    public bool Equals(System.Activities.WorkflowIdentity other) { return default(bool); }
    public override bool Equals(object obj) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public static System.Activities.WorkflowIdentity Parse(string identity) { return default(System.Activities.WorkflowIdentity); }
    public override string ToString() { return default(string); }
    public static bool TryParse(string identity, out System.Activities.WorkflowIdentity result) { result = default(System.Activities.WorkflowIdentity); return default(bool); }
  }
  public enum WorkflowIdentityFilter {
    Any = 1,
    AnyRevision = 2,
    Exact = 0,
  }
  public static partial class WorkflowInspectionServices {
    public static void CacheMetadata(System.Activities.Activity rootActivity) { }
    public static void CacheMetadata(System.Activities.Activity rootActivity, System.Activities.LocationReferenceEnvironment hostEnvironment) { }
    public static bool CanInduceIdle(System.Activities.Activity activity) { return default(bool); }
    [System.Runtime.CompilerServices.IteratorStateMachineAttribute(typeof(System.Activities.WorkflowInspectionServices.<GetActivities>d__3))]
    public static System.Collections.Generic.IEnumerable<System.Activities.Activity> GetActivities(System.Activities.Activity activity) { return default(System.Collections.Generic.IEnumerable<System.Activities.Activity>); }
    public static System.Version GetImplementationVersion(System.Activities.Activity activity) { return default(System.Version); }
    public static System.Activities.Activity Resolve(System.Activities.Activity root, string id) { return default(System.Activities.Activity); }
  }
  public sealed partial class WorkflowInvoker {
    public WorkflowInvoker(System.Activities.Activity workflow) { }
    public System.Activities.Hosting.WorkflowInstanceExtensionManager Extensions { get { return default(System.Activities.Hosting.WorkflowInstanceExtensionManager); } }
    public event System.EventHandler<System.Activities.InvokeCompletedEventArgs> InvokeCompleted { add { } remove { } }
    public System.IAsyncResult BeginInvoke(System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    public System.IAsyncResult BeginInvoke(System.Collections.Generic.IDictionary<System.String, System.Object> inputs, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    public System.IAsyncResult BeginInvoke(System.Collections.Generic.IDictionary<System.String, System.Object> inputs, System.TimeSpan timeout, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    public System.IAsyncResult BeginInvoke(System.TimeSpan timeout, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    public void CancelAsync(object userState) { }
    public System.Collections.Generic.IDictionary<System.String, System.Object> EndInvoke(System.IAsyncResult result) { return default(System.Collections.Generic.IDictionary<System.String, System.Object>); }
    public System.Collections.Generic.IDictionary<System.String, System.Object> Invoke() { return default(System.Collections.Generic.IDictionary<System.String, System.Object>); }
    public static System.Collections.Generic.IDictionary<System.String, System.Object> Invoke(System.Activities.Activity workflow) { return default(System.Collections.Generic.IDictionary<System.String, System.Object>); }
    public static System.Collections.Generic.IDictionary<System.String, System.Object> Invoke(System.Activities.Activity workflow, System.Collections.Generic.IDictionary<System.String, System.Object> inputs) { return default(System.Collections.Generic.IDictionary<System.String, System.Object>); }
    public static System.Collections.Generic.IDictionary<System.String, System.Object> Invoke(System.Activities.Activity workflow, System.Collections.Generic.IDictionary<System.String, System.Object> inputs, System.TimeSpan timeout) { return default(System.Collections.Generic.IDictionary<System.String, System.Object>); }
    public static System.Collections.Generic.IDictionary<System.String, System.Object> Invoke(System.Activities.Activity workflow, System.TimeSpan timeout) { return default(System.Collections.Generic.IDictionary<System.String, System.Object>); }
    public System.Collections.Generic.IDictionary<System.String, System.Object> Invoke(System.Collections.Generic.IDictionary<System.String, System.Object> inputs) { return default(System.Collections.Generic.IDictionary<System.String, System.Object>); }
    public System.Collections.Generic.IDictionary<System.String, System.Object> Invoke(System.Collections.Generic.IDictionary<System.String, System.Object> inputs, System.TimeSpan timeout) { return default(System.Collections.Generic.IDictionary<System.String, System.Object>); }
    public System.Collections.Generic.IDictionary<System.String, System.Object> Invoke(System.TimeSpan timeout) { return default(System.Collections.Generic.IDictionary<System.String, System.Object>); }
    public static TResult Invoke<TResult>(System.Activities.Activity<TResult> workflow) { return default(TResult); }
    public static TResult Invoke<TResult>(System.Activities.Activity<TResult> workflow, System.Collections.Generic.IDictionary<System.String, System.Object> inputs) { return default(TResult); }
    public static TResult Invoke<TResult>(System.Activities.Activity<TResult> workflow, System.Collections.Generic.IDictionary<System.String, System.Object> inputs, out System.Collections.Generic.IDictionary<System.String, System.Object> additionalOutputs, System.TimeSpan timeout) { additionalOutputs = default(System.Collections.Generic.IDictionary<System.String, System.Object>); return default(TResult); }
    public static TResult Invoke<TResult>(System.Activities.Activity<TResult> workflow, System.Collections.Generic.IDictionary<System.String, System.Object> inputs, System.TimeSpan timeout) { return default(TResult); }
    public void InvokeAsync() { }
    public void InvokeAsync(System.Collections.Generic.IDictionary<System.String, System.Object> inputs) { }
    public void InvokeAsync(System.Collections.Generic.IDictionary<System.String, System.Object> inputs, object userState) { }
    public void InvokeAsync(System.Collections.Generic.IDictionary<System.String, System.Object> inputs, System.TimeSpan timeout) { }
    public void InvokeAsync(System.Collections.Generic.IDictionary<System.String, System.Object> inputs, System.TimeSpan timeout, object userState) { }
    public void InvokeAsync(object userState) { }
    public void InvokeAsync(System.TimeSpan timeout) { }
    public void InvokeAsync(System.TimeSpan timeout, object userState) { }
  }
}
namespace System.Activities.Debugger {
  public partial class DebugInfo {
    internal DebugInfo() { }
  }
  public partial interface IDebuggableWorkflowTree {
    System.Activities.Activity GetWorkflowRoot();
  }
  [System.Diagnostics.DebuggerNonUserCodeAttribute]
  public partial class LocalsItemDescription {
    public LocalsItemDescription(string name, System.Type type) { }
    public string Name { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
    public System.Type Type { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Type); } }
    public override string ToString() { return default(string); }
  }
  [System.Diagnostics.DebuggerNonUserCodeAttribute]
  public partial class SourceLocation {
    public SourceLocation(string fileName, int line) { }
    public SourceLocation(string fileName, int startLine, int startColumn, int endLine, int endColumn) { }
    public int EndColumn { get { return default(int); } }
    public int EndLine { get { return default(int); } }
    public string FileName { get { return default(string); } }
    public bool IsSingleWholeLine { get { return default(bool); } }
    public int StartColumn { get { return default(int); } }
    public int StartLine { get { return default(int); } }
    public override bool Equals(object obj) { return default(bool); }
    public override int GetHashCode() { return default(int); }
  }
  public sealed partial class SourceLocationFoundEventArgs : System.EventArgs {
    public SourceLocationFoundEventArgs(object target, System.Activities.Debugger.SourceLocation sourceLocation) { }
    public System.Activities.Debugger.SourceLocation SourceLocation { get { return default(System.Activities.Debugger.SourceLocation); } }
    public object Target { get { return default(object); } }
  }
  [System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static partial class SourceLocationProvider {
    public static void CollectMapping(System.Activities.Activity rootActivity1, System.Activities.Activity rootActivity2, System.Collections.Generic.Dictionary<System.Object, System.Activities.Debugger.SourceLocation> mapping, string path) { }
    public static System.Collections.Generic.Dictionary<System.Object, System.Activities.Debugger.SourceLocation> GetSourceLocations(System.Activities.Activity rootActivity, System.Activities.Debugger.Symbol.WorkflowSymbol symbol) { return default(System.Collections.Generic.Dictionary<System.Object, System.Activities.Debugger.SourceLocation>); }
    public static System.Collections.Generic.ICollection<System.Activities.Debugger.Symbol.ActivitySymbol> GetSymbols(System.Activities.Activity rootActivity, System.Collections.Generic.Dictionary<System.Object, System.Activities.Debugger.SourceLocation> sourceLocations) { return default(System.Collections.Generic.ICollection<System.Activities.Debugger.Symbol.ActivitySymbol>); }
  }
  [System.Diagnostics.DebuggerNonUserCodeAttribute]
  public partial class State {
    internal State() { }
  }
  [System.Diagnostics.DebuggerNonUserCodeAttribute]
  public sealed partial class StateManager : System.IDisposable {
    internal StateManager() { }
    public void Dispose() { }
    public void Exit(int threadIndex) { }
  }
  [System.Diagnostics.DebuggerNonUserCodeAttribute]
  public partial class ThreadWorkerController {
    public ThreadWorkerController() { }
    [System.Diagnostics.DebuggerHiddenAttribute]
    public static void IslandWorker(System.Activities.Debugger.ThreadWorkerController controller) { }
  }
  [System.Diagnostics.DebuggerNonUserCodeAttribute]
  public partial class VirtualStackFrame {
    public VirtualStackFrame(System.Activities.Debugger.State state) { }
    public VirtualStackFrame(System.Activities.Debugger.State state, System.Collections.Generic.IDictionary<System.String, System.Object> locals) { }
    public System.Collections.Generic.IDictionary<System.String, System.Object> Locals { get { return default(System.Collections.Generic.IDictionary<System.String, System.Object>); } }
    public System.Activities.Debugger.State State { get { return default(System.Activities.Debugger.State); } }
    public override string ToString() { return default(string); }
  }
  public partial class XamlDebuggerXmlReader : System.Xaml.XamlReader, System.Xaml.IXamlLineInfo {
    public static readonly System.Xaml.AttachableMemberIdentifier EndColumnName;
    public static readonly System.Xaml.AttachableMemberIdentifier EndLineName;
    public static readonly System.Xaml.AttachableMemberIdentifier FileNameName;
    public static readonly System.Xaml.AttachableMemberIdentifier StartColumnName;
    public static readonly System.Xaml.AttachableMemberIdentifier StartLineName;
    public XamlDebuggerXmlReader(System.IO.TextReader underlyingTextReader) { }
    public XamlDebuggerXmlReader(System.IO.TextReader underlyingTextReader, System.Xaml.XamlSchemaContext schemaContext) { }
    [System.ObsoleteAttribute("Don't use this constructor. Use \"public XamlDebuggerXmlReader(TextReader underlyingTextReader)\" or \"public XamlDebuggerXmlReader(TextReader underlyingTextReader, XamlSchemaContext schemaContext)\" instead.")]
    public XamlDebuggerXmlReader(System.Xaml.XamlReader underlyingReader, System.IO.TextReader textReader) { }
    [System.ObsoleteAttribute("Don't use this constructor. Use \"public XamlDebuggerXmlReader(TextReader underlyingTextReader)\" or \"public XamlDebuggerXmlReader(TextReader underlyingTextReader, XamlSchemaContext schemaContext)\" instead.")]
    public XamlDebuggerXmlReader(System.Xaml.XamlReader underlyingReader, System.Xaml.IXamlLineInfo xamlLineInfo, System.IO.TextReader textReader) { }
    public bool CollectNonActivitySourceLocation { get { return default(bool); } set { } }
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
    public event System.EventHandler<System.Activities.Debugger.SourceLocationFoundEventArgs> SourceLocationFound { add { } remove { } }
    public static void CopyAttachedSourceLocation(object source, object destination) { }
    protected override void Dispose(bool disposing) { }
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    public static object GetEndColumn(object instance) { return default(object); }
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    public static object GetEndLine(object instance) { return default(object); }
    public static object GetFileName(object instance) { return default(object); }
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    public static object GetStartColumn(object instance) { return default(object); }
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    public static object GetStartLine(object instance) { return default(object); }
    public override bool Read() { return default(bool); }
    public static void SetEndColumn(object instance, object value) { }
    public static void SetEndLine(object instance, object value) { }
    public static void SetFileName(object instance, object value) { }
    public static void SetStartColumn(object instance, object value) { }
    public static void SetStartLine(object instance, object value) { }
  }
}
namespace System.Activities.Debugger.Symbol {
  public partial class ActivitySymbol {
    internal ActivitySymbol() { }
    public int EndColumn { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(int); } }
    public int EndLine { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(int); } }
    public string Id { get { return default(string); } }
    public int StartColumn { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(int); } }
    public int StartLine { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(int); } }
    public override string ToString() { return default(string); }
  }
  public static partial class DebugSymbol {
    public static readonly System.Xaml.AttachableMemberIdentifier SymbolName;
    public static object GetSymbol(object instance) { return default(object); }
    public static void SetSymbol(object instance, object value) { }
  }
  public partial class WorkflowSymbol {
    public WorkflowSymbol() { }
    public string FileName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Collections.Generic.ICollection<System.Activities.Debugger.Symbol.ActivitySymbol> Symbols { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Collections.Generic.ICollection<System.Activities.Debugger.Symbol.ActivitySymbol>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public bool CalculateChecksum() { return default(bool); }
    public static System.Activities.Debugger.Symbol.WorkflowSymbol Decode(string symbolString) { return default(System.Activities.Debugger.Symbol.WorkflowSymbol); }
    public string Encode() { return default(string); }
    public System.Byte[] GetChecksum() { return default(System.Byte[]); }
    public override string ToString() { return default(string); }
  }
}
namespace System.Activities.DurableInstancing {
  public sealed partial class ActivatableWorkflowsQueryResult : System.Runtime.DurableInstancing.InstanceStoreQueryResult {
    public ActivatableWorkflowsQueryResult() { }
    public ActivatableWorkflowsQueryResult(System.Collections.Generic.IDictionary<System.Xml.Linq.XName, System.Object> parameters) { }
    public ActivatableWorkflowsQueryResult(System.Collections.Generic.IEnumerable<System.Collections.Generic.IDictionary<System.Xml.Linq.XName, System.Object>> parameters) { }
    public System.Collections.Generic.List<System.Collections.Generic.IDictionary<System.Xml.Linq.XName, System.Object>> ActivationParameters { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Collections.Generic.List<System.Collections.Generic.IDictionary<System.Xml.Linq.XName, System.Object>>); } }
  }
  public sealed partial class CreateWorkflowOwnerCommand : System.Runtime.DurableInstancing.InstancePersistenceCommand {
    public CreateWorkflowOwnerCommand() : base (default(System.Xml.Linq.XName)) { }
    public System.Collections.Generic.IDictionary<System.Xml.Linq.XName, System.Runtime.DurableInstancing.InstanceValue> InstanceOwnerMetadata { get { return default(System.Collections.Generic.IDictionary<System.Xml.Linq.XName, System.Runtime.DurableInstancing.InstanceValue>); } }
    protected internal override bool IsTransactionEnlistmentOptional { get { return default(bool); } }
    protected internal override void Validate(System.Runtime.DurableInstancing.InstanceView view) { }
  }
  public sealed partial class CreateWorkflowOwnerWithIdentityCommand : System.Runtime.DurableInstancing.InstancePersistenceCommand {
    public CreateWorkflowOwnerWithIdentityCommand() : base (default(System.Xml.Linq.XName)) { }
    public System.Collections.Generic.IDictionary<System.Xml.Linq.XName, System.Runtime.DurableInstancing.InstanceValue> InstanceOwnerMetadata { get { return default(System.Collections.Generic.IDictionary<System.Xml.Linq.XName, System.Runtime.DurableInstancing.InstanceValue>); } }
    protected internal override bool IsTransactionEnlistmentOptional { get { return default(bool); } }
    protected internal override void Validate(System.Runtime.DurableInstancing.InstanceView view) { }
  }
  public sealed partial class DeleteWorkflowOwnerCommand : System.Runtime.DurableInstancing.InstancePersistenceCommand {
    public DeleteWorkflowOwnerCommand() : base (default(System.Xml.Linq.XName)) { }
    protected internal override bool IsTransactionEnlistmentOptional { get { return default(bool); } }
    protected internal override void Validate(System.Runtime.DurableInstancing.InstanceView view) { }
  }
  public sealed partial class HasActivatableWorkflowEvent : System.Runtime.DurableInstancing.InstancePersistenceEvent<System.Activities.DurableInstancing.HasActivatableWorkflowEvent> {
    public HasActivatableWorkflowEvent() : base (default(System.Xml.Linq.XName)) { }
  }
  public sealed partial class HasRunnableWorkflowEvent : System.Runtime.DurableInstancing.InstancePersistenceEvent<System.Activities.DurableInstancing.HasRunnableWorkflowEvent> {
    public HasRunnableWorkflowEvent() : base (default(System.Xml.Linq.XName)) { }
  }
  public sealed partial class LoadWorkflowByInstanceKeyCommand : System.Runtime.DurableInstancing.InstancePersistenceCommand {
    public LoadWorkflowByInstanceKeyCommand() : base (default(System.Xml.Linq.XName)) { }
    public bool AcceptUninitializedInstance { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Guid AssociateInstanceKeyToInstanceId { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Guid); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    protected internal override bool AutomaticallyAcquiringLock { get { return default(bool); } }
    public System.Collections.Generic.IDictionary<System.Guid, System.Collections.Generic.IDictionary<System.Xml.Linq.XName, System.Runtime.DurableInstancing.InstanceValue>> InstanceKeysToAssociate { get { return default(System.Collections.Generic.IDictionary<System.Guid, System.Collections.Generic.IDictionary<System.Xml.Linq.XName, System.Runtime.DurableInstancing.InstanceValue>>); } }
    protected internal override bool IsTransactionEnlistmentOptional { get { return default(bool); } }
    public System.Guid LookupInstanceKey { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Guid); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    protected internal override void Validate(System.Runtime.DurableInstancing.InstanceView view) { }
  }
  public sealed partial class LoadWorkflowCommand : System.Runtime.DurableInstancing.InstancePersistenceCommand {
    public LoadWorkflowCommand() : base (default(System.Xml.Linq.XName)) { }
    public bool AcceptUninitializedInstance { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    protected internal override bool AutomaticallyAcquiringLock { get { return default(bool); } }
    protected internal override bool IsTransactionEnlistmentOptional { get { return default(bool); } }
    protected internal override void Validate(System.Runtime.DurableInstancing.InstanceView view) { }
  }
  public sealed partial class QueryActivatableWorkflowsCommand : System.Runtime.DurableInstancing.InstancePersistenceCommand {
    public QueryActivatableWorkflowsCommand() : base (default(System.Xml.Linq.XName)) { }
    protected internal override bool IsTransactionEnlistmentOptional { get { return default(bool); } }
    protected internal override void Validate(System.Runtime.DurableInstancing.InstanceView view) { }
  }
  public sealed partial class SaveWorkflowCommand : System.Runtime.DurableInstancing.InstancePersistenceCommand {
    public SaveWorkflowCommand() : base (default(System.Xml.Linq.XName)) { }
    protected internal override bool AutomaticallyAcquiringLock { get { return default(bool); } }
    public bool CompleteInstance { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Collections.Generic.IDictionary<System.Xml.Linq.XName, System.Runtime.DurableInstancing.InstanceValue> InstanceData { get { return default(System.Collections.Generic.IDictionary<System.Xml.Linq.XName, System.Runtime.DurableInstancing.InstanceValue>); } }
    public System.Collections.Generic.IDictionary<System.Guid, System.Collections.Generic.IDictionary<System.Xml.Linq.XName, System.Runtime.DurableInstancing.InstanceValue>> InstanceKeyMetadataChanges { get { return default(System.Collections.Generic.IDictionary<System.Guid, System.Collections.Generic.IDictionary<System.Xml.Linq.XName, System.Runtime.DurableInstancing.InstanceValue>>); } }
    public System.Collections.Generic.IDictionary<System.Guid, System.Collections.Generic.IDictionary<System.Xml.Linq.XName, System.Runtime.DurableInstancing.InstanceValue>> InstanceKeysToAssociate { get { return default(System.Collections.Generic.IDictionary<System.Guid, System.Collections.Generic.IDictionary<System.Xml.Linq.XName, System.Runtime.DurableInstancing.InstanceValue>>); } }
    public System.Collections.Generic.ICollection<System.Guid> InstanceKeysToComplete { get { return default(System.Collections.Generic.ICollection<System.Guid>); } }
    public System.Collections.Generic.ICollection<System.Guid> InstanceKeysToFree { get { return default(System.Collections.Generic.ICollection<System.Guid>); } }
    public System.Collections.Generic.IDictionary<System.Xml.Linq.XName, System.Runtime.DurableInstancing.InstanceValue> InstanceMetadataChanges { get { return default(System.Collections.Generic.IDictionary<System.Xml.Linq.XName, System.Runtime.DurableInstancing.InstanceValue>); } }
    protected internal override bool IsTransactionEnlistmentOptional { get { return default(bool); } }
    public bool UnlockInstance { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    protected internal override void Validate(System.Runtime.DurableInstancing.InstanceView view) { }
  }
  public sealed partial class TryLoadRunnableWorkflowCommand : System.Runtime.DurableInstancing.InstancePersistenceCommand {
    public TryLoadRunnableWorkflowCommand() : base (default(System.Xml.Linq.XName)) { }
    protected internal override bool AutomaticallyAcquiringLock { get { return default(bool); } }
    protected internal override bool IsTransactionEnlistmentOptional { get { return default(bool); } }
    protected internal override void Validate(System.Runtime.DurableInstancing.InstanceView view) { }
  }
}
namespace System.Activities.DynamicUpdate {
  [System.Runtime.Serialization.DataContractAttribute]
  public partial class ActivityBlockingUpdate {
    public ActivityBlockingUpdate(System.Activities.Activity activity, string originalActivityId, string reason) { }
    public ActivityBlockingUpdate(System.Activities.Activity activity, string originalActivityId, string reason, string activityInstanceId) { }
    public ActivityBlockingUpdate(string updatedActivityId, string originalActivityId, string reason) { }
    public ActivityBlockingUpdate(string updatedActivityId, string originalActivityId, string reason, string activityInstanceId) { }
    public System.Activities.Activity Activity { get { return default(System.Activities.Activity); } }
    public string ActivityInstanceId { get { return default(string); } }
    public string OriginalActivityId { get { return default(string); } }
    public string Reason { get { return default(string); } }
    public string UpdatedActivityId { get { return default(string); } }
  }
  public static partial class DynamicUpdateInfo {
    public static System.Activities.DynamicUpdate.DynamicUpdateMapItem GetMapItem(object instance) { return default(System.Activities.DynamicUpdate.DynamicUpdateMapItem); }
    public static System.Activities.ActivityBuilder GetOriginalActivityBuilder(object instance) { return default(System.Activities.ActivityBuilder); }
    public static System.Activities.Activity GetOriginalDefinition(object instance) { return default(System.Activities.Activity); }
    public static void SetMapItem(object instance, System.Activities.DynamicUpdate.DynamicUpdateMapItem mapItem) { }
    public static void SetOriginalActivityBuilder(object instance, System.Activities.ActivityBuilder originalActivityBuilder) { }
    public static void SetOriginalDefinition(object instance, System.Activities.Activity originalDefinition) { }
  }
  [System.ComponentModel.TypeConverterAttribute(typeof(System.Activities.XamlIntegration.DynamicUpdateMapConverter))]
  [System.Runtime.Serialization.DataContractAttribute]
  public partial class DynamicUpdateMap {
    internal DynamicUpdateMap() { }
    public static System.Activities.DynamicUpdate.DynamicUpdateMap NoChanges { get { return default(System.Activities.DynamicUpdate.DynamicUpdateMap); } }
    public static System.Collections.Generic.IDictionary<System.Object, System.Activities.DynamicUpdate.DynamicUpdateMapItem> CalculateImplementationMapItems(System.Activities.Activity activityDefinitionToBeUpdated) { return default(System.Collections.Generic.IDictionary<System.Object, System.Activities.DynamicUpdate.DynamicUpdateMapItem>); }
    public static System.Collections.Generic.IDictionary<System.Object, System.Activities.DynamicUpdate.DynamicUpdateMapItem> CalculateImplementationMapItems(System.Activities.Activity activityDefinitionToBeUpdated, System.Activities.LocationReferenceEnvironment environment) { return default(System.Collections.Generic.IDictionary<System.Object, System.Activities.DynamicUpdate.DynamicUpdateMapItem>); }
    public static System.Collections.Generic.IDictionary<System.Object, System.Activities.DynamicUpdate.DynamicUpdateMapItem> CalculateMapItems(System.Activities.Activity workflowDefinitionToBeUpdated) { return default(System.Collections.Generic.IDictionary<System.Object, System.Activities.DynamicUpdate.DynamicUpdateMapItem>); }
    public static System.Collections.Generic.IDictionary<System.Object, System.Activities.DynamicUpdate.DynamicUpdateMapItem> CalculateMapItems(System.Activities.Activity workflowDefinitionToBeUpdated, System.Activities.LocationReferenceEnvironment environment) { return default(System.Collections.Generic.IDictionary<System.Object, System.Activities.DynamicUpdate.DynamicUpdateMapItem>); }
    public static System.Activities.DynamicUpdate.DynamicUpdateMap Merge(params System.Activities.DynamicUpdate.DynamicUpdateMap[] maps) { return default(System.Activities.DynamicUpdate.DynamicUpdateMap); }
    public static System.Activities.DynamicUpdate.DynamicUpdateMap Merge(System.Collections.Generic.IEnumerable<System.Activities.DynamicUpdate.DynamicUpdateMap> maps) { return default(System.Activities.DynamicUpdate.DynamicUpdateMap); }
    public System.Activities.DynamicUpdate.DynamicUpdateMapQuery Query(System.Activities.Activity updatedWorkflowDefinition, System.Activities.Activity originalWorkflowDefinition) { return default(System.Activities.DynamicUpdate.DynamicUpdateMapQuery); }
  }
  public partial class DynamicUpdateMapBuilder {
    public DynamicUpdateMapBuilder() { }
    public System.Collections.Generic.ISet<System.Activities.Activity> DisallowUpdateInside { get { return default(System.Collections.Generic.ISet<System.Activities.Activity>); } }
    public bool ForImplementation { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Func<System.Activities.Activity, System.Activities.DynamicUpdate.DynamicUpdateMap> LookupImplementationMap { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Func<System.Activities.Activity, System.Activities.DynamicUpdate.DynamicUpdateMap>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Func<System.Object, System.Activities.DynamicUpdate.DynamicUpdateMapItem> LookupMapItem { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Func<System.Object, System.Activities.DynamicUpdate.DynamicUpdateMapItem>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Activities.LocationReferenceEnvironment OriginalEnvironment { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.LocationReferenceEnvironment); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Activities.Activity OriginalWorkflowDefinition { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.Activity); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Activities.LocationReferenceEnvironment UpdatedEnvironment { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.LocationReferenceEnvironment); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Activities.Activity UpdatedWorkflowDefinition { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.Activity); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Activities.DynamicUpdate.DynamicUpdateMap CreateMap() { return default(System.Activities.DynamicUpdate.DynamicUpdateMap); }
    public System.Activities.DynamicUpdate.DynamicUpdateMap CreateMap(out System.Collections.Generic.IList<System.Activities.DynamicUpdate.ActivityBlockingUpdate> activitiesBlockingUpdate) { activitiesBlockingUpdate = default(System.Collections.Generic.IList<System.Activities.DynamicUpdate.ActivityBlockingUpdate>); return default(System.Activities.DynamicUpdate.DynamicUpdateMap); }
  }
  [System.ComponentModel.TypeConverterAttribute(typeof(System.Activities.XamlIntegration.DynamicUpdateMapItemConverter))]
  [System.Runtime.Serialization.DataContractAttribute]
  public partial class DynamicUpdateMapItem {
    internal DynamicUpdateMapItem() { }
  }
  public partial class DynamicUpdateMapQuery {
    internal DynamicUpdateMapQuery() { }
    public bool CanApplyUpdateWhileRunning(System.Activities.Activity activity) { return default(bool); }
    public System.Activities.Activity FindMatch(System.Activities.Activity activity) { return default(System.Activities.Activity); }
    public System.Activities.Variable FindMatch(System.Activities.Variable variable) { return default(System.Activities.Variable); }
  }
  public static partial class DynamicUpdateServices {
    public static System.Activities.DynamicUpdate.DynamicUpdateMap CreateUpdateMap(System.Activities.Activity updatedWorkflowDefinition) { return default(System.Activities.DynamicUpdate.DynamicUpdateMap); }
    public static System.Activities.DynamicUpdate.DynamicUpdateMap CreateUpdateMap(System.Activities.Activity updatedWorkflowDefinition, System.Collections.Generic.IEnumerable<System.Activities.Activity> disallowUpdateInsideActivities) { return default(System.Activities.DynamicUpdate.DynamicUpdateMap); }
    public static System.Activities.DynamicUpdate.DynamicUpdateMap CreateUpdateMap(System.Activities.Activity updatedWorkflowDefinition, System.Collections.Generic.IEnumerable<System.Activities.Activity> disallowUpdateInsideActivities, out System.Collections.Generic.IList<System.Activities.DynamicUpdate.ActivityBlockingUpdate> activitiesBlockingUpdate) { activitiesBlockingUpdate = default(System.Collections.Generic.IList<System.Activities.DynamicUpdate.ActivityBlockingUpdate>); return default(System.Activities.DynamicUpdate.DynamicUpdateMap); }
    public static System.Activities.DynamicUpdate.DynamicUpdateMap CreateUpdateMap(System.Activities.ActivityBuilder updatedActivityDefinition) { return default(System.Activities.DynamicUpdate.DynamicUpdateMap); }
    public static System.Activities.DynamicUpdate.DynamicUpdateMap CreateUpdateMap(System.Activities.ActivityBuilder updatedActivityDefinition, System.Collections.Generic.IEnumerable<System.Activities.Activity> disallowUpdateInsideActivities) { return default(System.Activities.DynamicUpdate.DynamicUpdateMap); }
    public static System.Activities.DynamicUpdate.DynamicUpdateMap CreateUpdateMap(System.Activities.ActivityBuilder updatedActivityDefinition, System.Collections.Generic.IEnumerable<System.Activities.Activity> disallowUpdateInsideActivities, out System.Collections.Generic.IList<System.Activities.DynamicUpdate.ActivityBlockingUpdate> activitiesBlockingUpdate) { activitiesBlockingUpdate = default(System.Collections.Generic.IList<System.Activities.DynamicUpdate.ActivityBlockingUpdate>); return default(System.Activities.DynamicUpdate.DynamicUpdateMap); }
    public static System.Activities.DynamicUpdate.DynamicUpdateMap GetImplementationMap(System.Activities.Activity targetActivity) { return default(System.Activities.DynamicUpdate.DynamicUpdateMap); }
    public static void PrepareForUpdate(System.Activities.Activity workflowDefinitionToBeUpdated) { }
    public static void PrepareForUpdate(System.Activities.ActivityBuilder activityDefinitionToBeUpdated) { }
    public static void SetImplementationMap(System.Activities.Activity targetActivity, System.Activities.DynamicUpdate.DynamicUpdateMap implementationMap) { }
  }
  public partial class InstanceUpdateException : System.Exception {
    public InstanceUpdateException() { }
    public InstanceUpdateException(System.Collections.Generic.IList<System.Activities.DynamicUpdate.ActivityBlockingUpdate> blockingActivities) { }
    protected InstanceUpdateException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public InstanceUpdateException(string message) { }
    public InstanceUpdateException(string message, System.Collections.Generic.IList<System.Activities.DynamicUpdate.ActivityBlockingUpdate> blockingActivities) { }
    public InstanceUpdateException(string message, System.Collections.Generic.IList<System.Activities.DynamicUpdate.ActivityBlockingUpdate> blockingActivities, System.Exception innerException) { }
    public InstanceUpdateException(string message, System.Exception innerException) { }
    public System.Collections.Generic.IList<System.Activities.DynamicUpdate.ActivityBlockingUpdate> BlockingActivities { get { return default(System.Collections.Generic.IList<System.Activities.DynamicUpdate.ActivityBlockingUpdate>); } }
    [System.Security.SecurityCriticalAttribute]
    public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
  }
  public partial class NativeActivityUpdateContext {
    internal NativeActivityUpdateContext() { }
    public string ActivityInstanceId { get { return default(string); } }
    public System.Activities.BookmarkScope DefaultBookmarkScope { get { return default(System.Activities.BookmarkScope); } }
    public bool IsCancellationRequested { get { return default(bool); } }
    public System.Activities.Bookmark CreateBookmark() { return default(System.Activities.Bookmark); }
    public System.Activities.Bookmark CreateBookmark(System.Activities.BookmarkCallback callback) { return default(System.Activities.Bookmark); }
    public System.Activities.Bookmark CreateBookmark(System.Activities.BookmarkCallback callback, System.Activities.BookmarkOptions options) { return default(System.Activities.Bookmark); }
    public System.Activities.Bookmark CreateBookmark(string name) { return default(System.Activities.Bookmark); }
    public System.Activities.Bookmark CreateBookmark(string name, System.Activities.BookmarkCallback callback) { return default(System.Activities.Bookmark); }
    public System.Activities.Bookmark CreateBookmark(string name, System.Activities.BookmarkCallback callback, System.Activities.BookmarkOptions options) { return default(System.Activities.Bookmark); }
    public System.Activities.Bookmark CreateBookmark(string name, System.Activities.BookmarkCallback callback, System.Activities.BookmarkScope scope) { return default(System.Activities.Bookmark); }
    public System.Activities.Bookmark CreateBookmark(string name, System.Activities.BookmarkCallback callback, System.Activities.BookmarkScope scope, System.Activities.BookmarkOptions options) { return default(System.Activities.Bookmark); }
    public void DisallowUpdate(string reason) { }
    public object FindExecutionProperty(string name) { return default(object); }
    public System.Activities.Location<T> GetLocation<T>(System.Activities.Variable variable) { return default(System.Activities.Location<T>); }
    public object GetSavedOriginalValue(System.Activities.Activity childActivity) { return default(object); }
    public object GetSavedOriginalValue(string propertyName) { return default(object); }
    public object GetValue(System.Activities.Argument argument) { return default(object); }
    public object GetValue(System.Activities.RuntimeArgument runtimeArgument) { return default(object); }
    public object GetValue(System.Activities.Variable variable) { return default(object); }
    public T GetValue<T>(System.Activities.Variable<T> variable) { return default(T); }
    public bool IsNewlyAdded(System.Activities.Activity childActivity) { return default(bool); }
    public void RemoveAllBookmarks() { }
    public bool RemoveBookmark(System.Activities.Bookmark bookmark) { return default(bool); }
    public bool RemoveBookmark(string name) { return default(bool); }
    public bool RemoveBookmark(string name, System.Activities.BookmarkScope scope) { return default(bool); }
    public void ScheduleAction(System.Activities.ActivityAction activityAction, System.Activities.CompletionCallback onCompleted=null, System.Activities.FaultCallback onFaulted=null) { }
    public void ScheduleAction<T>(System.Activities.ActivityAction<T> activityAction, T argument, System.Activities.CompletionCallback onCompleted=null, System.Activities.FaultCallback onFaulted=null) { }
    public void ScheduleAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(System.Activities.ActivityAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> activityAction, T1 argument1, T2 argument2, T3 argument3, T4 argument4, T5 argument5, T6 argument6, T7 argument7, T8 argument8, T9 argument9, T10 argument10, System.Activities.CompletionCallback onCompleted=null, System.Activities.FaultCallback onFaulted=null) { }
    public void ScheduleAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(System.Activities.ActivityAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> activityAction, T1 argument1, T2 argument2, T3 argument3, T4 argument4, T5 argument5, T6 argument6, T7 argument7, T8 argument8, T9 argument9, T10 argument10, T11 argument11, System.Activities.CompletionCallback onCompleted=null, System.Activities.FaultCallback onFaulted=null) { }
    public void ScheduleAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(System.Activities.ActivityAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> activityAction, T1 argument1, T2 argument2, T3 argument3, T4 argument4, T5 argument5, T6 argument6, T7 argument7, T8 argument8, T9 argument9, T10 argument10, T11 argument11, T12 argument12, System.Activities.CompletionCallback onCompleted=null, System.Activities.FaultCallback onFaulted=null) { }
    public void ScheduleAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(System.Activities.ActivityAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> activityAction, T1 argument1, T2 argument2, T3 argument3, T4 argument4, T5 argument5, T6 argument6, T7 argument7, T8 argument8, T9 argument9, T10 argument10, T11 argument11, T12 argument12, T13 argument13, System.Activities.CompletionCallback onCompleted=null, System.Activities.FaultCallback onFaulted=null) { }
    public void ScheduleAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(System.Activities.ActivityAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> activityAction, T1 argument1, T2 argument2, T3 argument3, T4 argument4, T5 argument5, T6 argument6, T7 argument7, T8 argument8, T9 argument9, T10 argument10, T11 argument11, T12 argument12, T13 argument13, T14 argument14, System.Activities.CompletionCallback onCompleted=null, System.Activities.FaultCallback onFaulted=null) { }
    public void ScheduleAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(System.Activities.ActivityAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> activityAction, T1 argument1, T2 argument2, T3 argument3, T4 argument4, T5 argument5, T6 argument6, T7 argument7, T8 argument8, T9 argument9, T10 argument10, T11 argument11, T12 argument12, T13 argument13, T14 argument14, T15 argument15, System.Activities.CompletionCallback onCompleted=null, System.Activities.FaultCallback onFaulted=null) { }
    public void ScheduleAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(System.Activities.ActivityAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> activityAction, T1 argument1, T2 argument2, T3 argument3, T4 argument4, T5 argument5, T6 argument6, T7 argument7, T8 argument8, T9 argument9, T10 argument10, T11 argument11, T12 argument12, T13 argument13, T14 argument14, T15 argument15, T16 argument16, System.Activities.CompletionCallback onCompleted=null, System.Activities.FaultCallback onFaulted=null) { }
    public void ScheduleAction<T1, T2>(System.Activities.ActivityAction<T1, T2> activityAction, T1 argument1, T2 argument2, System.Activities.CompletionCallback onCompleted=null, System.Activities.FaultCallback onFaulted=null) { }
    public void ScheduleAction<T1, T2, T3>(System.Activities.ActivityAction<T1, T2, T3> activityAction, T1 argument1, T2 argument2, T3 argument3, System.Activities.CompletionCallback onCompleted=null, System.Activities.FaultCallback onFaulted=null) { }
    public void ScheduleAction<T1, T2, T3, T4>(System.Activities.ActivityAction<T1, T2, T3, T4> activityAction, T1 argument1, T2 argument2, T3 argument3, T4 argument4, System.Activities.CompletionCallback onCompleted=null, System.Activities.FaultCallback onFaulted=null) { }
    public void ScheduleAction<T1, T2, T3, T4, T5>(System.Activities.ActivityAction<T1, T2, T3, T4, T5> activityAction, T1 argument1, T2 argument2, T3 argument3, T4 argument4, T5 argument5, System.Activities.CompletionCallback onCompleted=null, System.Activities.FaultCallback onFaulted=null) { }
    public void ScheduleAction<T1, T2, T3, T4, T5, T6>(System.Activities.ActivityAction<T1, T2, T3, T4, T5, T6> activityAction, T1 argument1, T2 argument2, T3 argument3, T4 argument4, T5 argument5, T6 argument6, System.Activities.CompletionCallback onCompleted=null, System.Activities.FaultCallback onFaulted=null) { }
    public void ScheduleAction<T1, T2, T3, T4, T5, T6, T7>(System.Activities.ActivityAction<T1, T2, T3, T4, T5, T6, T7> activityAction, T1 argument1, T2 argument2, T3 argument3, T4 argument4, T5 argument5, T6 argument6, T7 argument7, System.Activities.CompletionCallback onCompleted=null, System.Activities.FaultCallback onFaulted=null) { }
    public void ScheduleAction<T1, T2, T3, T4, T5, T6, T7, T8>(System.Activities.ActivityAction<T1, T2, T3, T4, T5, T6, T7, T8> activityAction, T1 argument1, T2 argument2, T3 argument3, T4 argument4, T5 argument5, T6 argument6, T7 argument7, T8 argument8, System.Activities.CompletionCallback onCompleted=null, System.Activities.FaultCallback onFaulted=null) { }
    public void ScheduleAction<T1, T2, T3, T4, T5, T6, T7, T8, T9>(System.Activities.ActivityAction<T1, T2, T3, T4, T5, T6, T7, T8, T9> activityAction, T1 argument1, T2 argument2, T3 argument3, T4 argument4, T5 argument5, T6 argument6, T7 argument7, T8 argument8, T9 argument9, System.Activities.CompletionCallback onCompleted=null, System.Activities.FaultCallback onFaulted=null) { }
    public void ScheduleActivity(System.Activities.Activity activity) { }
    public void ScheduleActivity(System.Activities.Activity activity, System.Activities.CompletionCallback onCompleted) { }
    public void ScheduleActivity(System.Activities.Activity activity, System.Activities.CompletionCallback onCompleted, System.Activities.FaultCallback onFaulted) { }
    public void ScheduleActivity(System.Activities.Activity activity, System.Activities.FaultCallback onFaulted) { }
    public void ScheduleActivity<TResult>(System.Activities.Activity<TResult> activity, System.Activities.CompletionCallback<TResult> onCompleted=null, System.Activities.FaultCallback onFaulted=null) { }
    public void ScheduleDelegate(System.Activities.ActivityDelegate activityDelegate, System.Collections.Generic.IDictionary<System.String, System.Object> inputParameters, System.Activities.DelegateCompletionCallback onCompleted=null, System.Activities.FaultCallback onFaulted=null) { }
    public void ScheduleFunc<TResult>(System.Activities.ActivityFunc<TResult> activityFunc, System.Activities.CompletionCallback<TResult> onCompleted=null, System.Activities.FaultCallback onFaulted=null) { }
    public void ScheduleFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(System.Activities.ActivityFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> activityFunc, T1 argument1, T2 argument2, T3 argument3, T4 argument4, T5 argument5, T6 argument6, T7 argument7, T8 argument8, T9 argument9, System.Activities.CompletionCallback<TResult> onCompleted=null, System.Activities.FaultCallback onFaulted=null) { }
    public void ScheduleFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(System.Activities.ActivityFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> activityFunc, T1 argument1, T2 argument2, T3 argument3, T4 argument4, T5 argument5, T6 argument6, T7 argument7, T8 argument8, T9 argument9, T10 argument10, System.Activities.CompletionCallback<TResult> onCompleted=null, System.Activities.FaultCallback onFaulted=null) { }
    public void ScheduleFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(System.Activities.ActivityFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> activityFunc, T1 argument1, T2 argument2, T3 argument3, T4 argument4, T5 argument5, T6 argument6, T7 argument7, T8 argument8, T9 argument9, T10 argument10, T11 argument11, System.Activities.CompletionCallback<TResult> onCompleted=null, System.Activities.FaultCallback onFaulted=null) { }
    public void ScheduleFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(System.Activities.ActivityFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> activityFunc, T1 argument1, T2 argument2, T3 argument3, T4 argument4, T5 argument5, T6 argument6, T7 argument7, T8 argument8, T9 argument9, T10 argument10, T11 argument11, T12 argument12, System.Activities.CompletionCallback<TResult> onCompleted=null, System.Activities.FaultCallback onFaulted=null) { }
    public void ScheduleFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(System.Activities.ActivityFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> activityFunc, T1 argument1, T2 argument2, T3 argument3, T4 argument4, T5 argument5, T6 argument6, T7 argument7, T8 argument8, T9 argument9, T10 argument10, T11 argument11, T12 argument12, T13 argument13, System.Activities.CompletionCallback<TResult> onCompleted=null, System.Activities.FaultCallback onFaulted=null) { }
    public void ScheduleFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(System.Activities.ActivityFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> activityFunc, T1 argument1, T2 argument2, T3 argument3, T4 argument4, T5 argument5, T6 argument6, T7 argument7, T8 argument8, T9 argument9, T10 argument10, T11 argument11, T12 argument12, T13 argument13, T14 argument14, System.Activities.CompletionCallback<TResult> onCompleted=null, System.Activities.FaultCallback onFaulted=null) { }
    public void ScheduleFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(System.Activities.ActivityFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> activityFunc, T1 argument1, T2 argument2, T3 argument3, T4 argument4, T5 argument5, T6 argument6, T7 argument7, T8 argument8, T9 argument9, T10 argument10, T11 argument11, T12 argument12, T13 argument13, T14 argument14, T15 argument15, System.Activities.CompletionCallback<TResult> onCompleted=null, System.Activities.FaultCallback onFaulted=null) { }
    public void ScheduleFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(System.Activities.ActivityFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> activityFunc, T1 argument1, T2 argument2, T3 argument3, T4 argument4, T5 argument5, T6 argument6, T7 argument7, T8 argument8, T9 argument9, T10 argument10, T11 argument11, T12 argument12, T13 argument13, T14 argument14, T15 argument15, T16 argument16, System.Activities.CompletionCallback<TResult> onCompleted=null, System.Activities.FaultCallback onFaulted=null) { }
    public void ScheduleFunc<T, TResult>(System.Activities.ActivityFunc<T, TResult> activityFunc, T argument, System.Activities.CompletionCallback<TResult> onCompleted=null, System.Activities.FaultCallback onFaulted=null) { }
    public void ScheduleFunc<T1, T2, TResult>(System.Activities.ActivityFunc<T1, T2, TResult> activityFunc, T1 argument1, T2 argument2, System.Activities.CompletionCallback<TResult> onCompleted=null, System.Activities.FaultCallback onFaulted=null) { }
    public void ScheduleFunc<T1, T2, T3, TResult>(System.Activities.ActivityFunc<T1, T2, T3, TResult> activityFunc, T1 argument1, T2 argument2, T3 argument3, System.Activities.CompletionCallback<TResult> onCompleted=null, System.Activities.FaultCallback onFaulted=null) { }
    public void ScheduleFunc<T1, T2, T3, T4, TResult>(System.Activities.ActivityFunc<T1, T2, T3, T4, TResult> activityFunc, T1 argument1, T2 argument2, T3 argument3, T4 argument4, System.Activities.CompletionCallback<TResult> onCompleted=null, System.Activities.FaultCallback onFaulted=null) { }
    public void ScheduleFunc<T1, T2, T3, T4, T5, TResult>(System.Activities.ActivityFunc<T1, T2, T3, T4, T5, TResult> activityFunc, T1 argument1, T2 argument2, T3 argument3, T4 argument4, T5 argument5, System.Activities.CompletionCallback<TResult> onCompleted=null, System.Activities.FaultCallback onFaulted=null) { }
    public void ScheduleFunc<T1, T2, T3, T4, T5, T6, TResult>(System.Activities.ActivityFunc<T1, T2, T3, T4, T5, T6, TResult> activityFunc, T1 argument1, T2 argument2, T3 argument3, T4 argument4, T5 argument5, T6 argument6, System.Activities.CompletionCallback<TResult> onCompleted=null, System.Activities.FaultCallback onFaulted=null) { }
    public void ScheduleFunc<T1, T2, T3, T4, T5, T6, T7, TResult>(System.Activities.ActivityFunc<T1, T2, T3, T4, T5, T6, T7, TResult> activityFunc, T1 argument1, T2 argument2, T3 argument3, T4 argument4, T5 argument5, T6 argument6, T7 argument7, System.Activities.CompletionCallback<TResult> onCompleted=null, System.Activities.FaultCallback onFaulted=null) { }
    public void ScheduleFunc<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(System.Activities.ActivityFunc<T1, T2, T3, T4, T5, T6, T7, T8, TResult> activityFunc, T1 argument1, T2 argument2, T3 argument3, T4 argument4, T5 argument5, T6 argument6, T7 argument7, T8 argument8, System.Activities.CompletionCallback<TResult> onCompleted=null, System.Activities.FaultCallback onFaulted=null) { }
    public void SetValue(System.Activities.Argument argument, object value) { }
    public void SetValue(System.Activities.Variable variable, object value) { }
    public void SetValue<T>(System.Activities.Variable<T> variable, T value) { }
  }
  public partial class NativeActivityUpdateMapMetadata : System.Activities.DynamicUpdate.UpdateMapMetadata {
    internal NativeActivityUpdateMapMetadata() { }
    public void SaveOriginalValue(System.Activities.Activity updatedChildActivity, object originalValue) { }
    public void SaveOriginalValue(string propertyName, object originalValue) { }
  }
  public partial class UpdateMapMetadata {
    internal UpdateMapMetadata() { }
    public void AddMatch(System.Activities.Activity updatedChild, System.Activities.Activity originalChild) { }
    public void AddMatch(System.Activities.Variable updatedVariable, System.Activities.Variable originalVariable) { }
    public void AllowUpdateInsideThisActivity() { }
    public void DisallowUpdateInsideThisActivity(string reason) { }
    public System.Activities.Activity GetMatch(System.Activities.Activity updatedChild) { return default(System.Activities.Activity); }
    public System.Activities.Variable GetMatch(System.Activities.Variable updatedVariable) { return default(System.Activities.Variable); }
    public bool IsReferenceToImportedChild(System.Activities.Activity childActivity) { return default(bool); }
  }
}
namespace System.Activities.ExpressionParser {
  public partial class SourceExpressionException : System.Exception, System.Runtime.Serialization.ISerializable {
    public SourceExpressionException() { }
    protected SourceExpressionException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public SourceExpressionException(string message) { }
    public SourceExpressionException(string message, System.CodeDom.Compiler.CompilerErrorCollection errors) { }
    public SourceExpressionException(string message, System.Exception innerException) { }
    public System.Collections.Generic.IEnumerable<System.CodeDom.Compiler.CompilerError> Errors { get { return default(System.Collections.Generic.IEnumerable<System.CodeDom.Compiler.CompilerError>); } }
    [System.Security.SecurityCriticalAttribute]
    public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
  }
}
namespace System.Activities.Expressions {
  public sealed partial class Add<TLeft, TRight, TResult> : System.Activities.CodeActivity<TResult> {
    public Add() { }
    [System.ComponentModel.DefaultValueAttribute(true)]
    public bool Checked { get { return default(bool); } set { } }
    [System.Activities.RequiredArgumentAttribute]
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.InArgument<TLeft> Left { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<TLeft>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.InArgument<TRight> Right { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<TRight>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    protected override void CacheMetadata(System.Activities.CodeActivityMetadata metadata) { }
    protected override TResult Execute(System.Activities.CodeActivityContext context) { return default(TResult); }
  }
  public sealed partial class And<TLeft, TRight, TResult> : System.Activities.CodeActivity<TResult> {
    public And() { }
    [System.Activities.RequiredArgumentAttribute]
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.InArgument<TLeft> Left { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<TLeft>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.InArgument<TRight> Right { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<TRight>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    protected override void CacheMetadata(System.Activities.CodeActivityMetadata metadata) { }
    protected override TResult Execute(System.Activities.CodeActivityContext context) { return default(TResult); }
  }
  public sealed partial class AndAlso : System.Activities.Activity<System.Boolean> {
    public AndAlso() { }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.Activity<System.Boolean> Left { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.Activity<System.Boolean>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.Activity<System.Boolean> Right { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.Activity<System.Boolean>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    protected override void CacheMetadata(System.Activities.ActivityMetadata metadata) { }
    protected override void OnCreateDynamicUpdateMap(System.Activities.DynamicUpdate.UpdateMapMetadata metadata, System.Activities.Activity originalActivity) { }
  }
  public sealed partial class ArgumentReference<T> : System.Activities.Expressions.EnvironmentLocationReference<T> {
    public ArgumentReference() { }
    public ArgumentReference(string argumentName) { }
    public string ArgumentName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public override System.Activities.LocationReference LocationReference { get { return default(System.Activities.LocationReference); } }
    protected override void CacheMetadata(System.Activities.CodeActivityMetadata metadata) { }
    public override string ToString() { return default(string); }
  }
  public sealed partial class ArgumentValue<T> : System.Activities.Expressions.EnvironmentLocationValue<T> {
    public ArgumentValue() { }
    public ArgumentValue(string argumentName) { }
    public string ArgumentName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public override System.Activities.LocationReference LocationReference { get { return default(System.Activities.LocationReference); } }
    protected override void CacheMetadata(System.Activities.CodeActivityMetadata metadata) { }
    public override string ToString() { return default(string); }
  }
  public sealed partial class ArrayItemReference<TItem> : System.Activities.CodeActivity<System.Activities.Location<TItem>> {
    public ArrayItemReference() { }
    [System.Activities.RequiredArgumentAttribute]
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.InArgument<TItem[]> Array { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<TItem[]>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.InArgument<System.Int32> Index { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<System.Int32>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    protected override void CacheMetadata(System.Activities.CodeActivityMetadata metadata) { }
    protected override System.Activities.Location<TItem> Execute(System.Activities.CodeActivityContext context) { return default(System.Activities.Location<TItem>); }
  }
  public sealed partial class ArrayItemValue<TItem> : System.Activities.CodeActivity<TItem> {
    public ArrayItemValue() { }
    [System.Activities.RequiredArgumentAttribute]
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.InArgument<TItem[]> Array { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<TItem[]>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.InArgument<System.Int32> Index { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<System.Int32>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    protected override void CacheMetadata(System.Activities.CodeActivityMetadata metadata) { }
    protected override TItem Execute(System.Activities.CodeActivityContext context) { return default(TItem); }
  }
  public sealed partial class As<TOperand, TResult> : System.Activities.CodeActivity<TResult> {
    public As() { }
    [System.Activities.RequiredArgumentAttribute]
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.InArgument<TOperand> Operand { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<TOperand>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    protected override void CacheMetadata(System.Activities.CodeActivityMetadata metadata) { }
    protected override TResult Execute(System.Activities.CodeActivityContext context) { return default(TResult); }
  }
  [System.ComponentModel.TypeConverterAttribute(typeof(System.Activities.XamlIntegration.AssemblyReferenceConverter))]
  public partial class AssemblyReference {
    public AssemblyReference() { }
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    public System.Reflection.Assembly Assembly { get { return default(System.Reflection.Assembly); } set { } }
    public System.Reflection.AssemblyName AssemblyName { get { return default(System.Reflection.AssemblyName); } set { } }
    public void LoadAssembly() { }
    public static implicit operator System.Activities.Expressions.AssemblyReference (System.Reflection.Assembly assembly) { return default(System.Activities.Expressions.AssemblyReference); }
    public static implicit operator System.Activities.Expressions.AssemblyReference (System.Reflection.AssemblyName assemblyName) { return default(System.Activities.Expressions.AssemblyReference); }
  }
  public sealed partial class Cast<TOperand, TResult> : System.Activities.CodeActivity<TResult> {
    public Cast() { }
    [System.ComponentModel.DefaultValueAttribute(true)]
    public bool Checked { get { return default(bool); } set { } }
    [System.Activities.RequiredArgumentAttribute]
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.InArgument<TOperand> Operand { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<TOperand>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    protected override void CacheMetadata(System.Activities.CodeActivityMetadata metadata) { }
    protected override TResult Execute(System.Activities.CodeActivityContext context) { return default(TResult); }
  }
  public partial class CompiledExpressionInvoker {
    public CompiledExpressionInvoker(System.Activities.Expressions.ITextExpression expression, bool isReference, System.Activities.CodeActivityMetadata metadata) { }
    public bool IsStaticallyCompiled { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } }
    public static object GetCompiledExpressionRoot(object target) { return default(object); }
    public static object GetCompiledExpressionRootForImplementation(object target) { return default(object); }
    public object InvokeExpression(System.Activities.ActivityContext activityContext) { return default(object); }
    public static void SetCompiledExpressionRoot(object target, System.Activities.XamlIntegration.ICompiledExpressionRoot compiledExpressionRoot) { }
    public static void SetCompiledExpressionRootForImplementation(object target, System.Activities.XamlIntegration.ICompiledExpressionRoot compiledExpressionRoot) { }
  }
  [System.Windows.Markup.ContentPropertyAttribute("DelegateArgument")]
  public sealed partial class DelegateArgumentReference<T> : System.Activities.Expressions.EnvironmentLocationReference<T> {
    public DelegateArgumentReference() { }
    public DelegateArgumentReference(System.Activities.DelegateArgument delegateArgument) { }
    public System.Activities.DelegateArgument DelegateArgument { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateArgument); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public override System.Activities.LocationReference LocationReference { get { return default(System.Activities.LocationReference); } }
    protected override void CacheMetadata(System.Activities.CodeActivityMetadata metadata) { }
  }
  [System.Windows.Markup.ContentPropertyAttribute("DelegateArgument")]
  public sealed partial class DelegateArgumentValue<T> : System.Activities.Expressions.EnvironmentLocationValue<T> {
    public DelegateArgumentValue() { }
    public DelegateArgumentValue(System.Activities.DelegateArgument delegateArgument) { }
    public System.Activities.DelegateArgument DelegateArgument { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.DelegateArgument); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public override System.Activities.LocationReference LocationReference { get { return default(System.Activities.LocationReference); } }
    protected override void CacheMetadata(System.Activities.CodeActivityMetadata metadata) { }
  }
  public sealed partial class Divide<TLeft, TRight, TResult> : System.Activities.CodeActivity<TResult> {
    public Divide() { }
    [System.Activities.RequiredArgumentAttribute]
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.InArgument<TLeft> Left { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<TLeft>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.InArgument<TRight> Right { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<TRight>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    protected override void CacheMetadata(System.Activities.CodeActivityMetadata metadata) { }
    protected override TResult Execute(System.Activities.CodeActivityContext context) { return default(TResult); }
  }
  public partial class EnvironmentLocationReference<T> : System.Activities.CodeActivity<System.Activities.Location<T>> {
    internal EnvironmentLocationReference() { }
    public virtual System.Activities.LocationReference LocationReference { get { return default(System.Activities.LocationReference); } }
    protected override void CacheMetadata(System.Activities.CodeActivityMetadata metadata) { }
    protected sealed override System.Activities.Location<T> Execute(System.Activities.CodeActivityContext context) { return default(System.Activities.Location<T>); }
  }
  public partial class EnvironmentLocationValue<T> : System.Activities.CodeActivity<T> {
    internal EnvironmentLocationValue() { }
    public virtual System.Activities.LocationReference LocationReference { get { return default(System.Activities.LocationReference); } }
    protected override void CacheMetadata(System.Activities.CodeActivityMetadata metadata) { }
    protected override T Execute(System.Activities.CodeActivityContext context) { return default(T); }
  }
  public sealed partial class Equal<TLeft, TRight, TResult> : System.Activities.CodeActivity<TResult> {
    public Equal() { }
    [System.Activities.RequiredArgumentAttribute]
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.InArgument<TLeft> Left { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<TLeft>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.InArgument<TRight> Right { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<TRight>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    protected override void CacheMetadata(System.Activities.CodeActivityMetadata metadata) { }
    protected override TResult Execute(System.Activities.CodeActivityContext context) { return default(TResult); }
  }
  public static partial class ExpressionServices {
    public static System.Activities.Activity<TResult> Convert<TResult>(System.Linq.Expressions.Expression<System.Func<System.Activities.ActivityContext, TResult>> expression) { return default(System.Activities.Activity<TResult>); }
    public static System.Activities.Activity<System.Activities.Location<TResult>> ConvertReference<TResult>(System.Linq.Expressions.Expression<System.Func<System.Activities.ActivityContext, TResult>> expression) { return default(System.Activities.Activity<System.Activities.Location<TResult>>); }
    public static bool TryConvert<TResult>(System.Linq.Expressions.Expression<System.Func<System.Activities.ActivityContext, TResult>> expression, out System.Activities.Activity<TResult> result) { result = default(System.Activities.Activity<TResult>); return default(bool); }
    public static bool TryConvertReference<TResult>(System.Linq.Expressions.Expression<System.Func<System.Activities.ActivityContext, TResult>> expression, out System.Activities.Activity<System.Activities.Location<TResult>> result) { result = default(System.Activities.Activity<System.Activities.Location<TResult>>); return default(bool); }
  }
  public sealed partial class FieldReference<TOperand, TResult> : System.Activities.CodeActivity<System.Activities.Location<TResult>> {
    public FieldReference() { }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public string FieldName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.InArgument<TOperand> Operand { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<TOperand>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    protected override void CacheMetadata(System.Activities.CodeActivityMetadata metadata) { }
    protected override System.Activities.Location<TResult> Execute(System.Activities.CodeActivityContext context) { return default(System.Activities.Location<TResult>); }
  }
  public sealed partial class FieldValue<TOperand, TResult> : System.Activities.CodeActivity<TResult> {
    public FieldValue() { }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public string FieldName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.InArgument<TOperand> Operand { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<TOperand>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    protected override void CacheMetadata(System.Activities.CodeActivityMetadata metadata) { }
    protected override TResult Execute(System.Activities.CodeActivityContext context) { return default(TResult); }
  }
  public sealed partial class GreaterThan<TLeft, TRight, TResult> : System.Activities.CodeActivity<TResult> {
    public GreaterThan() { }
    [System.Activities.RequiredArgumentAttribute]
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.InArgument<TLeft> Left { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<TLeft>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.InArgument<TRight> Right { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<TRight>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    protected override void CacheMetadata(System.Activities.CodeActivityMetadata metadata) { }
    protected override TResult Execute(System.Activities.CodeActivityContext context) { return default(TResult); }
  }
  public sealed partial class GreaterThanOrEqual<TLeft, TRight, TResult> : System.Activities.CodeActivity<TResult> {
    public GreaterThanOrEqual() { }
    [System.Activities.RequiredArgumentAttribute]
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.InArgument<TLeft> Left { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<TLeft>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.InArgument<TRight> Right { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<TRight>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    protected override void CacheMetadata(System.Activities.CodeActivityMetadata metadata) { }
    protected override TResult Execute(System.Activities.CodeActivityContext context) { return default(TResult); }
  }
  [System.Windows.Markup.ContentPropertyAttribute("Indices")]
  public sealed partial class IndexerReference<TOperand, TItem> : System.Activities.CodeActivity<System.Activities.Location<TItem>> {
    public IndexerReference() { }
    [System.Activities.RequiredArgumentAttribute]
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Collections.ObjectModel.Collection<System.Activities.InArgument> Indices { get { return default(System.Collections.ObjectModel.Collection<System.Activities.InArgument>); } }
    [System.Activities.RequiredArgumentAttribute]
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.InArgument<TOperand> Operand { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<TOperand>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    protected override void CacheMetadata(System.Activities.CodeActivityMetadata metadata) { }
    protected override System.Activities.Location<TItem> Execute(System.Activities.CodeActivityContext context) { return default(System.Activities.Location<TItem>); }
  }
  [System.Windows.Markup.ContentPropertyAttribute("Func")]
  public sealed partial class InvokeFunc<TResult> : System.Activities.NativeActivity<TResult> {
    public InvokeFunc() { }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.ActivityFunc<TResult> Func { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.ActivityFunc<TResult>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    protected override void Execute(System.Activities.NativeActivityContext context) { }
  }
  [System.Windows.Markup.ContentPropertyAttribute("Func")]
  public sealed partial class InvokeFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> : System.Activities.NativeActivity<TResult> {
    public InvokeFunc() { }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T1> Argument1 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T1>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T2> Argument2 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T2>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T3> Argument3 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T3>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T4> Argument4 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T4>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T5> Argument5 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T5>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T6> Argument6 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T6>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T7> Argument7 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T7>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T8> Argument8 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T8>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T9> Argument9 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T9>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.ActivityFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> Func { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.ActivityFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    protected override void Execute(System.Activities.NativeActivityContext context) { }
    protected override void OnCreateDynamicUpdateMap(System.Activities.DynamicUpdate.NativeActivityUpdateMapMetadata metadata, System.Activities.Activity originalActivity) { }
  }
  [System.Windows.Markup.ContentPropertyAttribute("Func")]
  public sealed partial class InvokeFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> : System.Activities.NativeActivity<TResult> {
    public InvokeFunc() { }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T1> Argument1 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T1>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T10> Argument10 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T10>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T2> Argument2 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T2>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T3> Argument3 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T3>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T4> Argument4 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T4>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T5> Argument5 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T5>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T6> Argument6 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T6>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T7> Argument7 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T7>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T8> Argument8 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T8>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T9> Argument9 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T9>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.ActivityFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> Func { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.ActivityFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    protected override void Execute(System.Activities.NativeActivityContext context) { }
    protected override void OnCreateDynamicUpdateMap(System.Activities.DynamicUpdate.NativeActivityUpdateMapMetadata metadata, System.Activities.Activity originalActivity) { }
  }
  [System.Windows.Markup.ContentPropertyAttribute("Func")]
  public sealed partial class InvokeFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> : System.Activities.NativeActivity<TResult> {
    public InvokeFunc() { }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T1> Argument1 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T1>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T10> Argument10 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T10>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T11> Argument11 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T11>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T2> Argument2 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T2>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T3> Argument3 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T3>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T4> Argument4 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T4>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T5> Argument5 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T5>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T6> Argument6 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T6>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T7> Argument7 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T7>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T8> Argument8 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T8>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T9> Argument9 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T9>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.ActivityFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> Func { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.ActivityFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    protected override void Execute(System.Activities.NativeActivityContext context) { }
    protected override void OnCreateDynamicUpdateMap(System.Activities.DynamicUpdate.NativeActivityUpdateMapMetadata metadata, System.Activities.Activity originalActivity) { }
  }
  [System.Windows.Markup.ContentPropertyAttribute("Func")]
  public sealed partial class InvokeFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> : System.Activities.NativeActivity<TResult> {
    public InvokeFunc() { }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T1> Argument1 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T1>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T10> Argument10 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T10>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T11> Argument11 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T11>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T12> Argument12 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T12>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T2> Argument2 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T2>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T3> Argument3 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T3>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T4> Argument4 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T4>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T5> Argument5 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T5>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T6> Argument6 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T6>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T7> Argument7 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T7>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T8> Argument8 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T8>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T9> Argument9 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T9>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.ActivityFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> Func { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.ActivityFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    protected override void Execute(System.Activities.NativeActivityContext context) { }
    protected override void OnCreateDynamicUpdateMap(System.Activities.DynamicUpdate.NativeActivityUpdateMapMetadata metadata, System.Activities.Activity originalActivity) { }
  }
  [System.Windows.Markup.ContentPropertyAttribute("Func")]
  public sealed partial class InvokeFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> : System.Activities.NativeActivity<TResult> {
    public InvokeFunc() { }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T1> Argument1 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T1>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T10> Argument10 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T10>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T11> Argument11 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T11>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T12> Argument12 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T12>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T13> Argument13 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T13>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T2> Argument2 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T2>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T3> Argument3 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T3>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T4> Argument4 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T4>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T5> Argument5 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T5>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T6> Argument6 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T6>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T7> Argument7 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T7>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T8> Argument8 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T8>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T9> Argument9 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T9>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.ActivityFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> Func { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.ActivityFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    protected override void Execute(System.Activities.NativeActivityContext context) { }
    protected override void OnCreateDynamicUpdateMap(System.Activities.DynamicUpdate.NativeActivityUpdateMapMetadata metadata, System.Activities.Activity originalActivity) { }
  }
  [System.Windows.Markup.ContentPropertyAttribute("Func")]
  public sealed partial class InvokeFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> : System.Activities.NativeActivity<TResult> {
    public InvokeFunc() { }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T1> Argument1 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T1>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T10> Argument10 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T10>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T11> Argument11 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T11>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T12> Argument12 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T12>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T13> Argument13 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T13>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T14> Argument14 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T14>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T2> Argument2 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T2>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T3> Argument3 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T3>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T4> Argument4 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T4>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T5> Argument5 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T5>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T6> Argument6 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T6>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T7> Argument7 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T7>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T8> Argument8 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T8>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T9> Argument9 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T9>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.ActivityFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> Func { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.ActivityFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    protected override void Execute(System.Activities.NativeActivityContext context) { }
    protected override void OnCreateDynamicUpdateMap(System.Activities.DynamicUpdate.NativeActivityUpdateMapMetadata metadata, System.Activities.Activity originalActivity) { }
  }
  [System.Windows.Markup.ContentPropertyAttribute("Func")]
  public sealed partial class InvokeFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> : System.Activities.NativeActivity<TResult> {
    public InvokeFunc() { }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T1> Argument1 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T1>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T10> Argument10 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T10>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T11> Argument11 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T11>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T12> Argument12 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T12>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T13> Argument13 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T13>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T14> Argument14 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T14>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T15> Argument15 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T15>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T2> Argument2 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T2>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T3> Argument3 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T3>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T4> Argument4 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T4>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T5> Argument5 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T5>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T6> Argument6 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T6>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T7> Argument7 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T7>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T8> Argument8 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T8>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T9> Argument9 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T9>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.ActivityFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> Func { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.ActivityFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    protected override void Execute(System.Activities.NativeActivityContext context) { }
    protected override void OnCreateDynamicUpdateMap(System.Activities.DynamicUpdate.NativeActivityUpdateMapMetadata metadata, System.Activities.Activity originalActivity) { }
  }
  [System.Windows.Markup.ContentPropertyAttribute("Func")]
  public sealed partial class InvokeFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> : System.Activities.NativeActivity<TResult> {
    public InvokeFunc() { }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T1> Argument1 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T1>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T10> Argument10 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T10>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T11> Argument11 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T11>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T12> Argument12 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T12>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T13> Argument13 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T13>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T14> Argument14 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T14>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T15> Argument15 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T15>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T16> Argument16 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T16>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T2> Argument2 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T2>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T3> Argument3 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T3>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T4> Argument4 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T4>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T5> Argument5 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T5>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T6> Argument6 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T6>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T7> Argument7 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T7>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T8> Argument8 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T8>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T9> Argument9 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T9>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.ActivityFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> Func { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.ActivityFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    protected override void Execute(System.Activities.NativeActivityContext context) { }
    protected override void OnCreateDynamicUpdateMap(System.Activities.DynamicUpdate.NativeActivityUpdateMapMetadata metadata, System.Activities.Activity originalActivity) { }
  }
  [System.Windows.Markup.ContentPropertyAttribute("Func")]
  public sealed partial class InvokeFunc<T, TResult> : System.Activities.NativeActivity<TResult> {
    public InvokeFunc() { }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T> Argument { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Activities.ActivityFunc<T, TResult> Func { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.ActivityFunc<T, TResult>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    protected override void Execute(System.Activities.NativeActivityContext context) { }
    protected override void OnCreateDynamicUpdateMap(System.Activities.DynamicUpdate.NativeActivityUpdateMapMetadata metadata, System.Activities.Activity originalActivity) { }
  }
  [System.Windows.Markup.ContentPropertyAttribute("Func")]
  public sealed partial class InvokeFunc<T1, T2, TResult> : System.Activities.NativeActivity<TResult> {
    public InvokeFunc() { }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T1> Argument1 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T1>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T2> Argument2 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T2>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.ActivityFunc<T1, T2, TResult> Func { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.ActivityFunc<T1, T2, TResult>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    protected override void Execute(System.Activities.NativeActivityContext context) { }
    protected override void OnCreateDynamicUpdateMap(System.Activities.DynamicUpdate.NativeActivityUpdateMapMetadata metadata, System.Activities.Activity originalActivity) { }
  }
  [System.Windows.Markup.ContentPropertyAttribute("Func")]
  public sealed partial class InvokeFunc<T1, T2, T3, TResult> : System.Activities.NativeActivity<TResult> {
    public InvokeFunc() { }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T1> Argument1 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T1>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T2> Argument2 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T2>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T3> Argument3 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T3>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.ActivityFunc<T1, T2, T3, TResult> Func { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.ActivityFunc<T1, T2, T3, TResult>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    protected override void Execute(System.Activities.NativeActivityContext context) { }
    protected override void OnCreateDynamicUpdateMap(System.Activities.DynamicUpdate.NativeActivityUpdateMapMetadata metadata, System.Activities.Activity originalActivity) { }
  }
  [System.Windows.Markup.ContentPropertyAttribute("Func")]
  public sealed partial class InvokeFunc<T1, T2, T3, T4, TResult> : System.Activities.NativeActivity<TResult> {
    public InvokeFunc() { }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T1> Argument1 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T1>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T2> Argument2 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T2>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T3> Argument3 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T3>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T4> Argument4 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T4>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.ActivityFunc<T1, T2, T3, T4, TResult> Func { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.ActivityFunc<T1, T2, T3, T4, TResult>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    protected override void Execute(System.Activities.NativeActivityContext context) { }
    protected override void OnCreateDynamicUpdateMap(System.Activities.DynamicUpdate.NativeActivityUpdateMapMetadata metadata, System.Activities.Activity originalActivity) { }
  }
  [System.Windows.Markup.ContentPropertyAttribute("Func")]
  public sealed partial class InvokeFunc<T1, T2, T3, T4, T5, TResult> : System.Activities.NativeActivity<TResult> {
    public InvokeFunc() { }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T1> Argument1 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T1>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T2> Argument2 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T2>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T3> Argument3 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T3>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T4> Argument4 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T4>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T5> Argument5 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T5>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.ActivityFunc<T1, T2, T3, T4, T5, TResult> Func { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.ActivityFunc<T1, T2, T3, T4, T5, TResult>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    protected override void Execute(System.Activities.NativeActivityContext context) { }
    protected override void OnCreateDynamicUpdateMap(System.Activities.DynamicUpdate.NativeActivityUpdateMapMetadata metadata, System.Activities.Activity originalActivity) { }
  }
  [System.Windows.Markup.ContentPropertyAttribute("Func")]
  public sealed partial class InvokeFunc<T1, T2, T3, T4, T5, T6, TResult> : System.Activities.NativeActivity<TResult> {
    public InvokeFunc() { }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T1> Argument1 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T1>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T2> Argument2 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T2>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T3> Argument3 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T3>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T4> Argument4 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T4>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T5> Argument5 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T5>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T6> Argument6 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T6>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.ActivityFunc<T1, T2, T3, T4, T5, T6, TResult> Func { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.ActivityFunc<T1, T2, T3, T4, T5, T6, TResult>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    protected override void Execute(System.Activities.NativeActivityContext context) { }
    protected override void OnCreateDynamicUpdateMap(System.Activities.DynamicUpdate.NativeActivityUpdateMapMetadata metadata, System.Activities.Activity originalActivity) { }
  }
  [System.Windows.Markup.ContentPropertyAttribute("Func")]
  public sealed partial class InvokeFunc<T1, T2, T3, T4, T5, T6, T7, TResult> : System.Activities.NativeActivity<TResult> {
    public InvokeFunc() { }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T1> Argument1 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T1>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T2> Argument2 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T2>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T3> Argument3 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T3>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T4> Argument4 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T4>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T5> Argument5 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T5>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T6> Argument6 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T6>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T7> Argument7 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T7>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.ActivityFunc<T1, T2, T3, T4, T5, T6, T7, TResult> Func { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.ActivityFunc<T1, T2, T3, T4, T5, T6, T7, TResult>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    protected override void Execute(System.Activities.NativeActivityContext context) { }
    protected override void OnCreateDynamicUpdateMap(System.Activities.DynamicUpdate.NativeActivityUpdateMapMetadata metadata, System.Activities.Activity originalActivity) { }
  }
  [System.Windows.Markup.ContentPropertyAttribute("Func")]
  public sealed partial class InvokeFunc<T1, T2, T3, T4, T5, T6, T7, T8, TResult> : System.Activities.NativeActivity<TResult> {
    public InvokeFunc() { }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T1> Argument1 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T1>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T2> Argument2 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T2>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T3> Argument3 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T3>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T4> Argument4 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T4>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T5> Argument5 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T5>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T6> Argument6 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T6>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T7> Argument7 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T7>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T8> Argument8 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T8>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.ActivityFunc<T1, T2, T3, T4, T5, T6, T7, T8, TResult> Func { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.ActivityFunc<T1, T2, T3, T4, T5, T6, T7, T8, TResult>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    protected override void Execute(System.Activities.NativeActivityContext context) { }
    protected override void OnCreateDynamicUpdateMap(System.Activities.DynamicUpdate.NativeActivityUpdateMapMetadata metadata, System.Activities.Activity originalActivity) { }
  }
  [System.Windows.Markup.ContentPropertyAttribute("Parameters")]
  public sealed partial class InvokeMethod<TResult> : System.Activities.AsyncCodeActivity<TResult> {
    public InvokeMethod() { }
    public System.Collections.ObjectModel.Collection<System.Type> GenericTypeArguments { get { return default(System.Collections.ObjectModel.Collection<System.Type>); } }
    public string MethodName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Collections.ObjectModel.Collection<System.Activities.Argument> Parameters { get { return default(System.Collections.ObjectModel.Collection<System.Activities.Argument>); } }
    [System.ComponentModel.DefaultValueAttribute(false)]
    public bool RunAsynchronously { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.InArgument TargetObject { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Type TargetType { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Type); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    protected override System.IAsyncResult BeginExecute(System.Activities.AsyncCodeActivityContext context, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    protected override void CacheMetadata(System.Activities.CodeActivityMetadata metadata) { }
    protected override TResult EndExecute(System.Activities.AsyncCodeActivityContext context, System.IAsyncResult result) { return default(TResult); }
  }
  public partial interface ITextExpression {
    string ExpressionText { get; }
    string Language { get; }
    bool RequiresCompilation { get; }
    System.Linq.Expressions.Expression GetExpressionTree();
  }
  [System.Diagnostics.DebuggerStepThroughAttribute]
  public sealed partial class LambdaReference<T> : System.Activities.CodeActivity<System.Activities.Location<T>>, System.Activities.XamlIntegration.IValueSerializableExpression {
    public LambdaReference(System.Linq.Expressions.Expression<System.Func<System.Activities.ActivityContext, T>> locationExpression) { }
    protected override void CacheMetadata(System.Activities.CodeActivityMetadata metadata) { }
    public bool CanConvertToString(System.Windows.Markup.IValueSerializerContext context) { return default(bool); }
    public string ConvertToString(System.Windows.Markup.IValueSerializerContext context) { return default(string); }
    protected override System.Activities.Location<T> Execute(System.Activities.CodeActivityContext context) { return default(System.Activities.Location<T>); }
  }
  public partial class LambdaSerializationException : System.Exception {
    public LambdaSerializationException() { }
    protected LambdaSerializationException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public LambdaSerializationException(string message) { }
    public LambdaSerializationException(string message, System.Exception innerException) { }
  }
  [System.Diagnostics.DebuggerStepThroughAttribute]
  public sealed partial class LambdaValue<TResult> : System.Activities.CodeActivity<TResult>, System.Activities.XamlIntegration.IValueSerializableExpression {
    public LambdaValue(System.Linq.Expressions.Expression<System.Func<System.Activities.ActivityContext, TResult>> lambdaValue) { }
    protected override void CacheMetadata(System.Activities.CodeActivityMetadata metadata) { }
    public bool CanConvertToString(System.Windows.Markup.IValueSerializerContext context) { return default(bool); }
    public string ConvertToString(System.Windows.Markup.IValueSerializerContext context) { return default(string); }
    protected override TResult Execute(System.Activities.CodeActivityContext context) { return default(TResult); }
  }
  public sealed partial class LessThan<TLeft, TRight, TResult> : System.Activities.CodeActivity<TResult> {
    public LessThan() { }
    [System.Activities.RequiredArgumentAttribute]
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.InArgument<TLeft> Left { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<TLeft>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.InArgument<TRight> Right { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<TRight>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    protected override void CacheMetadata(System.Activities.CodeActivityMetadata metadata) { }
    protected override TResult Execute(System.Activities.CodeActivityContext context) { return default(TResult); }
  }
  public sealed partial class LessThanOrEqual<TLeft, TRight, TResult> : System.Activities.CodeActivity<TResult> {
    public LessThanOrEqual() { }
    [System.Activities.RequiredArgumentAttribute]
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.InArgument<TLeft> Left { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<TLeft>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.InArgument<TRight> Right { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<TRight>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    protected override void CacheMetadata(System.Activities.CodeActivityMetadata metadata) { }
    protected override TResult Execute(System.Activities.CodeActivityContext context) { return default(TResult); }
  }
  [System.Diagnostics.DebuggerStepThroughAttribute]
  [System.Windows.Markup.ContentPropertyAttribute("Value")]
  public sealed partial class Literal<T> : System.Activities.CodeActivity<T>, System.Activities.XamlIntegration.IValueSerializableExpression {
    public Literal() { }
    public Literal(T value) { }
    public T Value { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(T); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    protected override void CacheMetadata(System.Activities.CodeActivityMetadata metadata) { }
    public bool CanConvertToString(System.Windows.Markup.IValueSerializerContext context) { return default(bool); }
    public string ConvertToString(System.Windows.Markup.IValueSerializerContext context) { return default(string); }
    protected override T Execute(System.Activities.CodeActivityContext context) { return default(T); }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public bool ShouldSerializeValue() { return default(bool); }
    public override string ToString() { return default(string); }
  }
  [System.Windows.Markup.ContentPropertyAttribute("Indices")]
  public sealed partial class MultidimensionalArrayItemReference<TItem> : System.Activities.CodeActivity<System.Activities.Location<TItem>> {
    public MultidimensionalArrayItemReference() { }
    [System.Activities.RequiredArgumentAttribute]
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.InArgument<System.Array> Array { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<System.Array>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Collections.ObjectModel.Collection<System.Activities.InArgument<System.Int32>> Indices { get { return default(System.Collections.ObjectModel.Collection<System.Activities.InArgument<System.Int32>>); } }
    protected override void CacheMetadata(System.Activities.CodeActivityMetadata metadata) { }
    protected override System.Activities.Location<TItem> Execute(System.Activities.CodeActivityContext context) { return default(System.Activities.Location<TItem>); }
  }
  public sealed partial class Multiply<TLeft, TRight, TResult> : System.Activities.CodeActivity<TResult> {
    public Multiply() { }
    [System.ComponentModel.DefaultValueAttribute(true)]
    public bool Checked { get { return default(bool); } set { } }
    [System.Activities.RequiredArgumentAttribute]
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.InArgument<TLeft> Left { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<TLeft>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.InArgument<TRight> Right { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<TRight>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    protected override void CacheMetadata(System.Activities.CodeActivityMetadata metadata) { }
    protected override TResult Execute(System.Activities.CodeActivityContext context) { return default(TResult); }
  }
  [System.Windows.Markup.ContentPropertyAttribute("Arguments")]
  public sealed partial class New<TResult> : System.Activities.CodeActivity<TResult> {
    public New() { }
    public System.Collections.ObjectModel.Collection<System.Activities.Argument> Arguments { get { return default(System.Collections.ObjectModel.Collection<System.Activities.Argument>); } }
    protected override void CacheMetadata(System.Activities.CodeActivityMetadata metadata) { }
    protected override TResult Execute(System.Activities.CodeActivityContext context) { return default(TResult); }
  }
  [System.Windows.Markup.ContentPropertyAttribute("Bounds")]
  public sealed partial class NewArray<TResult> : System.Activities.CodeActivity<TResult> {
    public NewArray() { }
    public System.Collections.ObjectModel.Collection<System.Activities.Argument> Bounds { get { return default(System.Collections.ObjectModel.Collection<System.Activities.Argument>); } }
    protected override void CacheMetadata(System.Activities.CodeActivityMetadata metadata) { }
    protected override TResult Execute(System.Activities.CodeActivityContext context) { return default(TResult); }
  }
  public sealed partial class Not<TOperand, TResult> : System.Activities.CodeActivity<TResult> {
    public Not() { }
    [System.Activities.RequiredArgumentAttribute]
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.InArgument<TOperand> Operand { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<TOperand>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    protected override void CacheMetadata(System.Activities.CodeActivityMetadata metadata) { }
    protected override TResult Execute(System.Activities.CodeActivityContext context) { return default(TResult); }
  }
  public sealed partial class NotEqual<TLeft, TRight, TResult> : System.Activities.CodeActivity<TResult> {
    public NotEqual() { }
    [System.Activities.RequiredArgumentAttribute]
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.InArgument<TLeft> Left { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<TLeft>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.InArgument<TRight> Right { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<TRight>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    protected override void CacheMetadata(System.Activities.CodeActivityMetadata metadata) { }
    protected override TResult Execute(System.Activities.CodeActivityContext context) { return default(TResult); }
  }
  public sealed partial class Or<TLeft, TRight, TResult> : System.Activities.CodeActivity<TResult> {
    public Or() { }
    [System.Activities.RequiredArgumentAttribute]
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.InArgument<TLeft> Left { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<TLeft>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.InArgument<TRight> Right { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<TRight>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    protected override void CacheMetadata(System.Activities.CodeActivityMetadata metadata) { }
    protected override TResult Execute(System.Activities.CodeActivityContext context) { return default(TResult); }
  }
  public sealed partial class OrElse : System.Activities.Activity<System.Boolean> {
    public OrElse() { }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.Activity<System.Boolean> Left { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.Activity<System.Boolean>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.Activity<System.Boolean> Right { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.Activity<System.Boolean>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    protected override void CacheMetadata(System.Activities.ActivityMetadata metadata) { }
    protected override void OnCreateDynamicUpdateMap(System.Activities.DynamicUpdate.UpdateMapMetadata metadata, System.Activities.Activity originalActivity) { }
  }
  public sealed partial class PropertyReference<TOperand, TResult> : System.Activities.CodeActivity<System.Activities.Location<TResult>> {
    public PropertyReference() { }
    public System.Activities.InArgument<TOperand> Operand { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<TOperand>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public string PropertyName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    protected override void CacheMetadata(System.Activities.CodeActivityMetadata metadata) { }
    protected override System.Activities.Location<TResult> Execute(System.Activities.CodeActivityContext context) { return default(System.Activities.Location<TResult>); }
  }
  public sealed partial class PropertyValue<TOperand, TResult> : System.Activities.CodeActivity<TResult> {
    public PropertyValue() { }
    public System.Activities.InArgument<TOperand> Operand { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<TOperand>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public string PropertyName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    protected override void CacheMetadata(System.Activities.CodeActivityMetadata metadata) { }
    protected override TResult Execute(System.Activities.CodeActivityContext context) { return default(TResult); }
  }
  public sealed partial class Subtract<TLeft, TRight, TResult> : System.Activities.CodeActivity<TResult> {
    public Subtract() { }
    [System.ComponentModel.DefaultValueAttribute(true)]
    public bool Checked { get { return default(bool); } set { } }
    [System.Activities.RequiredArgumentAttribute]
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.InArgument<TLeft> Left { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<TLeft>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.InArgument<TRight> Right { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<TRight>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    protected override void CacheMetadata(System.Activities.CodeActivityMetadata metadata) { }
    protected override TResult Execute(System.Activities.CodeActivityContext context) { return default(TResult); }
  }
  public static partial class TextExpression {
    public static System.Collections.Generic.IList<System.String> DefaultNamespaces { get { return default(System.Collections.Generic.IList<System.String>); } }
    public static System.Collections.Generic.IList<System.Activities.Expressions.AssemblyReference> DefaultReferences { get { return default(System.Collections.Generic.IList<System.Activities.Expressions.AssemblyReference>); } }
    public static System.Collections.Generic.IList<System.String> GetNamespaces(object target) { return default(System.Collections.Generic.IList<System.String>); }
    public static System.Collections.Generic.IList<System.String> GetNamespacesForImplementation(object target) { return default(System.Collections.Generic.IList<System.String>); }
    public static System.Collections.Generic.IList<System.String> GetNamespacesInScope(System.Activities.Activity activity) { return default(System.Collections.Generic.IList<System.String>); }
    public static System.Collections.Generic.IList<System.Activities.Expressions.AssemblyReference> GetReferences(object target) { return default(System.Collections.Generic.IList<System.Activities.Expressions.AssemblyReference>); }
    public static System.Collections.Generic.IList<System.Activities.Expressions.AssemblyReference> GetReferencesForImplementation(object target) { return default(System.Collections.Generic.IList<System.Activities.Expressions.AssemblyReference>); }
    public static System.Collections.Generic.IList<System.Activities.Expressions.AssemblyReference> GetReferencesInScope(System.Activities.Activity activity) { return default(System.Collections.Generic.IList<System.Activities.Expressions.AssemblyReference>); }
    public static void SetNamespaces(object target, System.Collections.Generic.IList<System.String> namespaces) { }
    public static void SetNamespaces(object target, params System.String[] namespaces) { }
    public static void SetNamespacesForImplementation(object target, System.Collections.Generic.IList<System.String> namespaces) { }
    public static void SetNamespacesForImplementation(object target, params System.String[] namespaces) { }
    public static void SetReferences(object target, params System.Activities.Expressions.AssemblyReference[] references) { }
    public static void SetReferences(object target, System.Collections.Generic.IList<System.Activities.Expressions.AssemblyReference> references) { }
    public static void SetReferencesForImplementation(object target, params System.Activities.Expressions.AssemblyReference[] references) { }
    public static void SetReferencesForImplementation(object target, System.Collections.Generic.IList<System.Activities.Expressions.AssemblyReference> references) { }
    public static bool ShouldSerializeNamespaces(object target) { return default(bool); }
    public static bool ShouldSerializeNamespacesForImplementation(object target) { return default(bool); }
    public static bool ShouldSerializeReferences(object target) { return default(bool); }
    public static bool ShouldSerializeReferencesForImplementation(object target) { return default(bool); }
  }
  public sealed partial class ValueTypeFieldReference<TOperand, TResult> : System.Activities.CodeActivity<System.Activities.Location<TResult>> {
    public ValueTypeFieldReference() { }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public string FieldName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.InOutArgument<TOperand> OperandLocation { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InOutArgument<TOperand>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    protected override void CacheMetadata(System.Activities.CodeActivityMetadata metadata) { }
    protected override System.Activities.Location<TResult> Execute(System.Activities.CodeActivityContext context) { return default(System.Activities.Location<TResult>); }
  }
  [System.Windows.Markup.ContentPropertyAttribute("Indices")]
  public sealed partial class ValueTypeIndexerReference<TOperand, TItem> : System.Activities.CodeActivity<System.Activities.Location<TItem>> {
    public ValueTypeIndexerReference() { }
    [System.Activities.RequiredArgumentAttribute]
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Collections.ObjectModel.Collection<System.Activities.InArgument> Indices { get { return default(System.Collections.ObjectModel.Collection<System.Activities.InArgument>); } }
    [System.Activities.RequiredArgumentAttribute]
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.InOutArgument<TOperand> OperandLocation { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InOutArgument<TOperand>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    protected override void CacheMetadata(System.Activities.CodeActivityMetadata metadata) { }
    protected override System.Activities.Location<TItem> Execute(System.Activities.CodeActivityContext context) { return default(System.Activities.Location<TItem>); }
  }
  public sealed partial class ValueTypePropertyReference<TOperand, TResult> : System.Activities.CodeActivity<System.Activities.Location<TResult>> {
    public ValueTypePropertyReference() { }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.InOutArgument<TOperand> OperandLocation { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InOutArgument<TOperand>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public string PropertyName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    protected override void CacheMetadata(System.Activities.CodeActivityMetadata metadata) { }
    protected override System.Activities.Location<TResult> Execute(System.Activities.CodeActivityContext context) { return default(System.Activities.Location<TResult>); }
  }
  public sealed partial class VariableReference<T> : System.Activities.Expressions.EnvironmentLocationReference<T> {
    public VariableReference() { }
    public VariableReference(System.Activities.Variable variable) { }
    public override System.Activities.LocationReference LocationReference { get { return default(System.Activities.LocationReference); } }
    public System.Activities.Variable Variable { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.Variable); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    protected override void CacheMetadata(System.Activities.CodeActivityMetadata metadata) { }
    public override string ToString() { return default(string); }
  }
  public sealed partial class VariableValue<T> : System.Activities.Expressions.EnvironmentLocationValue<T> {
    public VariableValue() { }
    public VariableValue(System.Activities.Variable variable) { }
    public override System.Activities.LocationReference LocationReference { get { return default(System.Activities.LocationReference); } }
    public System.Activities.Variable Variable { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.Variable); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    protected override void CacheMetadata(System.Activities.CodeActivityMetadata metadata) { }
    public override string ToString() { return default(string); }
  }
}
namespace System.Activities.Hosting {
  [System.Runtime.Serialization.DataContractAttribute]
  public sealed partial class BookmarkInfo {
    internal BookmarkInfo() { }
    public string BookmarkName { get { return default(string); } }
    public string OwnerDisplayName { get { return default(string); } }
    public System.Activities.Hosting.BookmarkScopeInfo ScopeInfo { get { return default(System.Activities.Hosting.BookmarkScopeInfo); } }
  }
  [System.Runtime.Serialization.DataContractAttribute]
  public sealed partial class BookmarkScopeInfo {
    internal BookmarkScopeInfo() { }
    public System.Guid Id { get { return default(System.Guid); } }
    public bool IsInitialized { get { return default(bool); } }
    public string TemporaryId { get { return default(string); } }
  }
  public partial interface IWorkflowInstanceExtension {
    System.Collections.Generic.IEnumerable<System.Object> GetAdditionalExtensions();
    void SetInstance(System.Activities.Hosting.WorkflowInstanceProxy instance);
  }
  [System.Runtime.Serialization.DataContractAttribute]
  public sealed partial class LocationInfo {
    internal LocationInfo() { }
    public string Name { get { return default(string); } }
    public string OwnerDisplayName { get { return default(string); } }
    public object Value { get { return default(object); } }
  }
  public sealed partial class SymbolResolver : System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String, System.Object>>, System.Collections.Generic.IDictionary<System.String, System.Object>, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>, System.Collections.IEnumerable {
    public SymbolResolver() { }
    public int Count { get { return default(int); } }
    public bool IsReadOnly { get { return default(bool); } }
    public object this[string key] { get { return default(object); } set { } }
    public System.Collections.Generic.ICollection<System.String> Keys { get { return default(System.Collections.Generic.ICollection<System.String>); } }
    public System.Collections.Generic.ICollection<System.Object> Values { get { return default(System.Collections.Generic.ICollection<System.Object>); } }
    public void Add(System.Collections.Generic.KeyValuePair<System.String, System.Object> item) { }
    public void Add(string key, object value) { }
    public void Add(string key, object value, System.Type type) { }
    public void Add(string key, System.Type type) { }
    public System.Activities.LocationReferenceEnvironment AsLocationReferenceEnvironment() { return default(System.Activities.LocationReferenceEnvironment); }
    public void Clear() { }
    public bool Contains(System.Collections.Generic.KeyValuePair<System.String, System.Object> item) { return default(bool); }
    public bool ContainsKey(string key) { return default(bool); }
    public void CopyTo(System.Collections.Generic.KeyValuePair<System.String, System.Object>[] array, int arrayIndex) { }
    [System.Runtime.CompilerServices.IteratorStateMachineAttribute(typeof(System.Activities.Hosting.SymbolResolver.<GetEnumerator>d__22))]
    public System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String, System.Object>> GetEnumerator() { return default(System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String, System.Object>>); }
    public bool Remove(System.Collections.Generic.KeyValuePair<System.String, System.Object> item) { return default(bool); }
    public bool Remove(string key) { return default(bool); }
    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { return default(System.Collections.IEnumerator); }
    public bool TryGetValue(string key, out object value) { value = default(object); return default(bool); }
  }
  public abstract partial class WorkflowInstance {
    protected WorkflowInstance(System.Activities.Activity workflowDefinition) { }
    protected WorkflowInstance(System.Activities.Activity workflowDefinition, System.Activities.WorkflowIdentity definitionIdentity) { }
    protected System.Activities.Hosting.WorkflowInstance.WorkflowInstanceControl Controller { get { return default(System.Activities.Hosting.WorkflowInstance.WorkflowInstanceControl); } }
    public System.Activities.WorkflowIdentity DefinitionIdentity { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.WorkflowIdentity); } }
    public System.Activities.LocationReferenceEnvironment HostEnvironment { get { return default(System.Activities.LocationReferenceEnvironment); } set { } }
    public abstract System.Guid Id { get; }
    protected bool IsReadOnly { get { return default(bool); } }
    protected internal abstract bool SupportsInstanceKeys { get; }
    public System.Threading.SynchronizationContext SynchronizationContext { get { return default(System.Threading.SynchronizationContext); } set { } }
    public System.Activities.Activity WorkflowDefinition { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.Activity); } }
    protected System.IAsyncResult BeginFlushTrackingRecords(System.TimeSpan timeout, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    protected void DisposeExtensions() { }
    protected void EndFlushTrackingRecords(System.IAsyncResult result) { }
    protected void FlushTrackingRecords(System.TimeSpan timeout) { }
    protected static System.Collections.Generic.IList<System.Activities.DynamicUpdate.ActivityBlockingUpdate> GetActivitiesBlockingUpdate(object deserializedRuntimeState, System.Activities.DynamicUpdate.DynamicUpdateMap updateMap) { return default(System.Collections.Generic.IList<System.Activities.DynamicUpdate.ActivityBlockingUpdate>); }
    protected internal T GetExtension<T>() where T : class { return default(T); }
    protected internal System.Collections.Generic.IEnumerable<T> GetExtensions<T>() where T : class { return default(System.Collections.Generic.IEnumerable<T>); }
    protected void Initialize(System.Collections.Generic.IDictionary<System.String, System.Object> workflowArgumentValues, System.Collections.Generic.IList<System.Activities.Handle> workflowExecutionProperties) { }
    protected void Initialize(object deserializedRuntimeState) { }
    protected void Initialize(object deserializedRuntimeState, System.Activities.DynamicUpdate.DynamicUpdateMap updateMap) { }
    protected internal abstract System.IAsyncResult OnBeginAssociateKeys(System.Collections.Generic.ICollection<System.Runtime.DurableInstancing.InstanceKey> keys, System.AsyncCallback callback, object state);
    protected virtual System.IAsyncResult OnBeginFlushTrackingRecords(System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    protected internal abstract System.IAsyncResult OnBeginPersist(System.AsyncCallback callback, object state);
    protected internal abstract System.IAsyncResult OnBeginResumeBookmark(System.Activities.Bookmark bookmark, object value, System.TimeSpan timeout, System.AsyncCallback callback, object state);
    protected internal abstract void OnDisassociateKeys(System.Collections.Generic.ICollection<System.Runtime.DurableInstancing.InstanceKey> keys);
    protected internal abstract void OnEndAssociateKeys(System.IAsyncResult result);
    protected virtual void OnEndFlushTrackingRecords(System.IAsyncResult result) { }
    protected internal abstract void OnEndPersist(System.IAsyncResult result);
    protected internal abstract System.Activities.BookmarkResumptionResult OnEndResumeBookmark(System.IAsyncResult result);
    protected abstract void OnNotifyPaused();
    protected abstract void OnNotifyUnhandledException(System.Exception exception, System.Activities.Activity source, string sourceInstanceId);
    protected internal abstract void OnRequestAbort(System.Exception reason);
    protected void RegisterExtensionManager(System.Activities.Hosting.WorkflowInstanceExtensionManager extensionManager) { }
    protected void ThrowIfReadOnly() { }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    protected partial struct WorkflowInstanceControl {
      public bool HasPendingTrackingRecords { get { return default(bool); } }
      public bool IsPersistable { get { return default(bool); } }
      public System.Activities.Hosting.WorkflowInstanceState State { get { return default(System.Activities.Hosting.WorkflowInstanceState); } }
      public bool TrackingEnabled { get { return default(bool); } }
      public void Abort() { }
      public void Abort(System.Exception reason) { }
      public System.IAsyncResult BeginFlushTrackingRecords(System.TimeSpan timeout, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
      public void EndFlushTrackingRecords(System.IAsyncResult result) { }
      public override bool Equals(object obj) { return default(bool); }
      public void FlushTrackingRecords(System.TimeSpan timeout) { }
      public System.Exception GetAbortReason() { return default(System.Exception); }
      public System.Collections.ObjectModel.ReadOnlyCollection<System.Activities.Hosting.BookmarkInfo> GetBookmarks() { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.Activities.Hosting.BookmarkInfo>); }
      public System.Collections.ObjectModel.ReadOnlyCollection<System.Activities.Hosting.BookmarkInfo> GetBookmarks(System.Activities.BookmarkScope scope) { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.Activities.Hosting.BookmarkInfo>); }
      public System.Activities.ActivityInstanceState GetCompletionState() { return default(System.Activities.ActivityInstanceState); }
      public System.Activities.ActivityInstanceState GetCompletionState(out System.Collections.Generic.IDictionary<System.String, System.Object> outputs, out System.Exception terminationException) { outputs = default(System.Collections.Generic.IDictionary<System.String, System.Object>); terminationException = default(System.Exception); return default(System.Activities.ActivityInstanceState); }
      public System.Activities.ActivityInstanceState GetCompletionState(out System.Exception terminationException) { terminationException = default(System.Exception); return default(System.Activities.ActivityInstanceState); }
      public override int GetHashCode() { return default(int); }
      public System.Collections.Generic.IDictionary<System.String, System.Activities.Hosting.LocationInfo> GetMappedVariables() { return default(System.Collections.Generic.IDictionary<System.String, System.Activities.Hosting.LocationInfo>); }
      public static bool operator ==(System.Activities.Hosting.WorkflowInstance.WorkflowInstanceControl left, System.Activities.Hosting.WorkflowInstance.WorkflowInstanceControl right) { return default(bool); }
      public static bool operator !=(System.Activities.Hosting.WorkflowInstance.WorkflowInstanceControl left, System.Activities.Hosting.WorkflowInstance.WorkflowInstanceControl right) { return default(bool); }
      public void PauseWhenPersistable() { }
      public object PrepareForSerialization() { return default(object); }
      public void RequestPause() { }
      public void Run() { }
      public System.Activities.BookmarkResumptionResult ScheduleBookmarkResumption(System.Activities.Bookmark bookmark, object value) { return default(System.Activities.BookmarkResumptionResult); }
      public System.Activities.BookmarkResumptionResult ScheduleBookmarkResumption(System.Activities.Bookmark bookmark, object value, System.Activities.BookmarkScope scope) { return default(System.Activities.BookmarkResumptionResult); }
      public void ScheduleCancel() { }
      public void Terminate(System.Exception reason) { }
      public void Track(System.Activities.Tracking.WorkflowInstanceRecord instanceRecord) { }
    }
  }
  public partial class WorkflowInstanceExtensionManager {
    public WorkflowInstanceExtensionManager() { }
    public virtual void Add(object singletonExtension) { }
    public virtual void Add<T>(System.Func<T> extensionCreationFunction) where T : class { }
    public void MakeReadOnly() { }
  }
  public sealed partial class WorkflowInstanceProxy {
    internal WorkflowInstanceProxy() { }
    public System.Guid Id { get { return default(System.Guid); } }
    public System.Activities.Activity WorkflowDefinition { get { return default(System.Activities.Activity); } }
    public System.IAsyncResult BeginResumeBookmark(System.Activities.Bookmark bookmark, object value, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    public System.IAsyncResult BeginResumeBookmark(System.Activities.Bookmark bookmark, object value, System.TimeSpan timeout, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    public System.Activities.BookmarkResumptionResult EndResumeBookmark(System.IAsyncResult result) { return default(System.Activities.BookmarkResumptionResult); }
  }
  public enum WorkflowInstanceState {
    Aborted = 3,
    Complete = 2,
    Idle = 0,
    Runnable = 1,
  }
}
namespace System.Activities.Persistence {
  public abstract partial class PersistenceIOParticipant : System.Activities.Persistence.PersistenceParticipant {
    protected PersistenceIOParticipant(bool isSaveTransactionRequired, bool isLoadTransactionRequired) { }
    protected abstract void Abort();
    protected virtual System.IAsyncResult BeginOnLoad(System.Collections.Generic.IDictionary<System.Xml.Linq.XName, System.Object> readWriteValues, System.TimeSpan timeout, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    protected virtual System.IAsyncResult BeginOnSave(System.Collections.Generic.IDictionary<System.Xml.Linq.XName, System.Object> readWriteValues, System.Collections.Generic.IDictionary<System.Xml.Linq.XName, System.Object> writeOnlyValues, System.TimeSpan timeout, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    protected virtual void EndOnLoad(System.IAsyncResult result) { }
    protected virtual void EndOnSave(System.IAsyncResult result) { }
  }
  public abstract partial class PersistenceParticipant {
    protected PersistenceParticipant() { }
    protected virtual void CollectValues(out System.Collections.Generic.IDictionary<System.Xml.Linq.XName, System.Object> readWriteValues, out System.Collections.Generic.IDictionary<System.Xml.Linq.XName, System.Object> writeOnlyValues) { readWriteValues = default(System.Collections.Generic.IDictionary<System.Xml.Linq.XName, System.Object>); writeOnlyValues = default(System.Collections.Generic.IDictionary<System.Xml.Linq.XName, System.Object>); }
    protected virtual System.Collections.Generic.IDictionary<System.Xml.Linq.XName, System.Object> MapValues(System.Collections.Generic.IDictionary<System.Xml.Linq.XName, System.Object> readWriteValues, System.Collections.Generic.IDictionary<System.Xml.Linq.XName, System.Object> writeOnlyValues) { return default(System.Collections.Generic.IDictionary<System.Xml.Linq.XName, System.Object>); }
    protected virtual void PublishValues(System.Collections.Generic.IDictionary<System.Xml.Linq.XName, System.Object> readWriteValues) { }
  }
}
namespace System.Activities.Statements {
  [System.Windows.Markup.ContentPropertyAttribute("Collection")]
  public sealed partial class AddToCollection<T> : System.Activities.CodeActivity {
    public AddToCollection() { }
    [System.Activities.RequiredArgumentAttribute]
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.InArgument<System.Collections.Generic.ICollection<T>> Collection { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<System.Collections.Generic.ICollection<T>>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.InArgument<T> Item { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    protected override void CacheMetadata(System.Activities.CodeActivityMetadata metadata) { }
    protected override void Execute(System.Activities.CodeActivityContext context) { }
  }
  public sealed partial class Assign : System.Activities.CodeActivity {
    public Assign() { }
    [System.Activities.RequiredArgumentAttribute]
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.OutArgument To { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.OutArgument); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.InArgument Value { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    protected override void CacheMetadata(System.Activities.CodeActivityMetadata metadata) { }
    protected override void Execute(System.Activities.CodeActivityContext context) { }
  }
  public sealed partial class Assign<T> : System.Activities.CodeActivity {
    public Assign() { }
    [System.Activities.RequiredArgumentAttribute]
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.OutArgument<T> To { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.OutArgument<T>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.InArgument<T> Value { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    protected override void CacheMetadata(System.Activities.CodeActivityMetadata metadata) { }
    protected override void Execute(System.Activities.CodeActivityContext context) { }
  }
  [System.Windows.Markup.ContentPropertyAttribute("Body")]
  public sealed partial class CancellationScope : System.Activities.NativeActivity {
    public CancellationScope() { }
    [System.ComponentModel.DefaultValueAttribute(null)]
    [System.Windows.Markup.DependsOnAttribute("Variables")]
    public System.Activities.Activity Body { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.Activity); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    [System.Windows.Markup.DependsOnAttribute("Body")]
    public System.Activities.Activity CancellationHandler { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.Activity); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Collections.ObjectModel.Collection<System.Activities.Variable> Variables { get { return default(System.Collections.ObjectModel.Collection<System.Activities.Variable>); } }
    protected override void CacheMetadata(System.Activities.NativeActivityMetadata metadata) { }
    protected override void Cancel(System.Activities.NativeActivityContext context) { }
    protected override void Execute(System.Activities.NativeActivityContext context) { }
    protected override void OnCreateDynamicUpdateMap(System.Activities.DynamicUpdate.NativeActivityUpdateMapMetadata metadata, System.Activities.Activity originalActivity) { }
  }
  public abstract partial class Catch {
    internal Catch() { }
    public abstract System.Type ExceptionType { get; }
  }
  [System.Windows.Markup.ContentPropertyAttribute("Action")]
  public sealed partial class Catch<TException> : System.Activities.Statements.Catch where TException : System.Exception {
    public Catch() { }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.ActivityAction<TException> Action { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.ActivityAction<TException>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public override System.Type ExceptionType { get { return default(System.Type); } }
  }
  [System.Windows.Markup.ContentPropertyAttribute("Collection")]
  public sealed partial class ClearCollection<T> : System.Activities.CodeActivity {
    public ClearCollection() { }
    [System.Activities.RequiredArgumentAttribute]
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.InArgument<System.Collections.Generic.ICollection<T>> Collection { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<System.Collections.Generic.ICollection<T>>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    protected override void CacheMetadata(System.Activities.CodeActivityMetadata metadata) { }
    protected override void Execute(System.Activities.CodeActivityContext context) { }
  }
  [System.Windows.Markup.ContentPropertyAttribute("Body")]
  public sealed partial class CompensableActivity : System.Activities.NativeActivity<System.Activities.Statements.CompensationToken> {
    public CompensableActivity() { }
    [System.ComponentModel.DefaultValueAttribute(null)]
    [System.Windows.Markup.DependsOnAttribute("Variables")]
    public System.Activities.Activity Body { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.Activity); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    [System.Windows.Markup.DependsOnAttribute("Body")]
    public System.Activities.Activity CancellationHandler { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.Activity); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    protected override bool CanInduceIdle { get { return default(bool); } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    [System.Windows.Markup.DependsOnAttribute("CancellationHandler")]
    public System.Activities.Activity CompensationHandler { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.Activity); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    [System.Windows.Markup.DependsOnAttribute("CompensationHandler")]
    public System.Activities.Activity ConfirmationHandler { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.Activity); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Collections.ObjectModel.Collection<System.Activities.Variable> Variables { get { return default(System.Collections.ObjectModel.Collection<System.Activities.Variable>); } }
    protected override void CacheMetadata(System.Activities.NativeActivityMetadata metadata) { }
    protected override void Cancel(System.Activities.NativeActivityContext context) { }
    protected override void Execute(System.Activities.NativeActivityContext context) { }
    protected override void OnCreateDynamicUpdateMap(System.Activities.DynamicUpdate.NativeActivityUpdateMapMetadata metadata, System.Activities.Activity originalActivity) { }
  }
  public sealed partial class Compensate : System.Activities.NativeActivity {
    public Compensate() { }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.InArgument<System.Activities.Statements.CompensationToken> Target { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<System.Activities.Statements.CompensationToken>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    protected override void CacheMetadata(System.Activities.NativeActivityMetadata metadata) { }
    protected override void Cancel(System.Activities.NativeActivityContext context) { }
    protected override void Execute(System.Activities.NativeActivityContext context) { }
  }
  public partial class CompensationExtension : System.Activities.Persistence.PersistenceParticipant, System.Activities.Hosting.IWorkflowInstanceExtension {
    public CompensationExtension() { }
    protected override void CollectValues(out System.Collections.Generic.IDictionary<System.Xml.Linq.XName, System.Object> readWriteValues, out System.Collections.Generic.IDictionary<System.Xml.Linq.XName, System.Object> writeOnlyValues) { readWriteValues = default(System.Collections.Generic.IDictionary<System.Xml.Linq.XName, System.Object>); writeOnlyValues = default(System.Collections.Generic.IDictionary<System.Xml.Linq.XName, System.Object>); }
    protected override void PublishValues(System.Collections.Generic.IDictionary<System.Xml.Linq.XName, System.Object> readWriteValues) { }
    System.Collections.Generic.IEnumerable<System.Object> System.Activities.Hosting.IWorkflowInstanceExtension.GetAdditionalExtensions() { return default(System.Collections.Generic.IEnumerable<System.Object>); }
    void System.Activities.Hosting.IWorkflowInstanceExtension.SetInstance(System.Activities.Hosting.WorkflowInstanceProxy instance) { }
  }
  [System.Runtime.Serialization.DataContractAttribute]
  public sealed partial class CompensationToken {
    internal CompensationToken() { }
  }
  public sealed partial class Confirm : System.Activities.NativeActivity {
    public Confirm() { }
    public System.Activities.InArgument<System.Activities.Statements.CompensationToken> Target { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<System.Activities.Statements.CompensationToken>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    protected override void CacheMetadata(System.Activities.NativeActivityMetadata metadata) { }
    protected override void Cancel(System.Activities.NativeActivityContext context) { }
    protected override void Execute(System.Activities.NativeActivityContext context) { }
  }
  public sealed partial class CreateBookmarkScope : System.Activities.NativeActivity<System.Activities.BookmarkScope> {
    public CreateBookmarkScope() { }
    protected override void CacheMetadata(System.Activities.NativeActivityMetadata metadata) { }
    protected override void Execute(System.Activities.NativeActivityContext context) { }
  }
  [System.Windows.Markup.ContentPropertyAttribute("Duration")]
  public sealed partial class Delay : System.Activities.NativeActivity {
    public Delay() { }
    protected override bool CanInduceIdle { get { return default(bool); } }
    [System.Activities.RequiredArgumentAttribute]
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.InArgument<System.TimeSpan> Duration { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<System.TimeSpan>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    protected override void Abort(System.Activities.NativeActivityAbortContext context) { }
    protected override void CacheMetadata(System.Activities.NativeActivityMetadata metadata) { }
    protected override void Cancel(System.Activities.NativeActivityContext context) { }
    protected override void Execute(System.Activities.NativeActivityContext context) { }
  }
  public sealed partial class DeleteBookmarkScope : System.Activities.NativeActivity {
    public DeleteBookmarkScope() { }
    public System.Activities.InArgument<System.Activities.BookmarkScope> Scope { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<System.Activities.BookmarkScope>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    protected override void CacheMetadata(System.Activities.NativeActivityMetadata metadata) { }
    protected override void Execute(System.Activities.NativeActivityContext context) { }
  }
  [System.Windows.Markup.ContentPropertyAttribute("Body")]
  public sealed partial class DoWhile : System.Activities.NativeActivity {
    public DoWhile() { }
    public DoWhile(System.Activities.Activity<System.Boolean> condition) { }
    public DoWhile(System.Linq.Expressions.Expression<System.Func<System.Activities.ActivityContext, System.Boolean>> condition) { }
    [System.ComponentModel.DefaultValueAttribute(null)]
    [System.Windows.Markup.DependsOnAttribute("Condition")]
    public System.Activities.Activity Body { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.Activity); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    [System.Windows.Markup.DependsOnAttribute("Variables")]
    public System.Activities.Activity<System.Boolean> Condition { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.Activity<System.Boolean>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Collections.ObjectModel.Collection<System.Activities.Variable> Variables { get { return default(System.Collections.ObjectModel.Collection<System.Activities.Variable>); } }
    protected override void CacheMetadata(System.Activities.NativeActivityMetadata metadata) { }
    protected override void Execute(System.Activities.NativeActivityContext context) { }
    protected override void OnCreateDynamicUpdateMap(System.Activities.DynamicUpdate.NativeActivityUpdateMapMetadata metadata, System.Activities.Activity originalActivity) { }
  }
  public partial class DurableTimerExtension : System.Activities.Statements.TimerExtension, System.Activities.Hosting.IWorkflowInstanceExtension, System.IDisposable {
    public DurableTimerExtension() { }
    public void Dispose() { }
    [System.Runtime.CompilerServices.IteratorStateMachineAttribute(typeof(System.Activities.Statements.DurableTimerExtension.<GetAdditionalExtensions>d__16))]
    public virtual System.Collections.Generic.IEnumerable<System.Object> GetAdditionalExtensions() { return default(System.Collections.Generic.IEnumerable<System.Object>); }
    protected override void OnCancelTimer(System.Activities.Bookmark bookmark) { }
    protected override void OnRegisterTimer(System.TimeSpan timeout, System.Activities.Bookmark bookmark) { }
    public virtual void SetInstance(System.Activities.Hosting.WorkflowInstanceProxy instance) { }
  }
  [System.Windows.Markup.ContentPropertyAttribute("Collection")]
  public sealed partial class ExistsInCollection<T> : System.Activities.CodeActivity<System.Boolean> {
    public ExistsInCollection() { }
    [System.Activities.RequiredArgumentAttribute]
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.InArgument<System.Collections.Generic.ICollection<T>> Collection { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<System.Collections.Generic.ICollection<T>>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.InArgument<T> Item { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    protected override void CacheMetadata(System.Activities.CodeActivityMetadata metadata) { }
    protected override bool Execute(System.Activities.CodeActivityContext context) { return default(bool); }
  }
  [System.Windows.Markup.ContentPropertyAttribute("Nodes")]
  public sealed partial class Flowchart : System.Activities.NativeActivity {
    public Flowchart() { }
    [System.Windows.Markup.DependsOnAttribute("StartNode")]
    public System.Collections.ObjectModel.Collection<System.Activities.Statements.FlowNode> Nodes { get { return default(System.Collections.ObjectModel.Collection<System.Activities.Statements.FlowNode>); } }
    [System.Windows.Markup.DependsOnAttribute("Variables")]
    public System.Activities.Statements.FlowNode StartNode { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.Statements.FlowNode); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(false)]
    public bool ValidateUnconnectedNodes { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Collections.ObjectModel.Collection<System.Activities.Variable> Variables { get { return default(System.Collections.ObjectModel.Collection<System.Activities.Variable>); } }
    protected override void CacheMetadata(System.Activities.NativeActivityMetadata metadata) { }
    protected override void Execute(System.Activities.NativeActivityContext context) { }
    protected override void OnCreateDynamicUpdateMap(System.Activities.DynamicUpdate.NativeActivityUpdateMapMetadata metadata, System.Activities.Activity originalActivity) { }
    protected override void UpdateInstance(System.Activities.DynamicUpdate.NativeActivityUpdateContext updateContext) { }
  }
  public sealed partial class FlowDecision : System.Activities.Statements.FlowNode {
    public FlowDecision() { }
    public FlowDecision(System.Activities.Activity<System.Boolean> condition) { }
    public FlowDecision(System.Linq.Expressions.Expression<System.Func<System.Activities.ActivityContext, System.Boolean>> condition) { }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.Activity<System.Boolean> Condition { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.Activity<System.Boolean>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute("Decision")]
    public string DisplayName { get { return default(string); } set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    [System.Windows.Markup.DependsOnAttribute("True")]
    public System.Activities.Statements.FlowNode False { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.Statements.FlowNode); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    [System.Windows.Markup.DependsOnAttribute("Condition")]
    public System.Activities.Statements.FlowNode True { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.Statements.FlowNode); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
  }
  public abstract partial class FlowNode {
    internal FlowNode() { }
  }
  [System.Windows.Markup.ContentPropertyAttribute("Action")]
  public sealed partial class FlowStep : System.Activities.Statements.FlowNode {
    public FlowStep() { }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.Activity Action { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.Activity); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    [System.Windows.Markup.DependsOnAttribute("Action")]
    public System.Activities.Statements.FlowNode Next { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.Statements.FlowNode); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
  }
  [System.Windows.Markup.ContentPropertyAttribute("Cases")]
  public sealed partial class FlowSwitch<T> : System.Activities.Statements.FlowNode {
    public FlowSwitch() { }
    public System.Collections.Generic.IDictionary<T, System.Activities.Statements.FlowNode> Cases { get { return default(System.Collections.Generic.IDictionary<T, System.Activities.Statements.FlowNode>); } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.Statements.FlowNode Default { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.Statements.FlowNode); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute("Switch")]
    public string DisplayName { get { return default(string); } set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.Activity<T> Expression { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.Activity<T>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
  }
  [System.Windows.Markup.ContentPropertyAttribute("Body")]
  public sealed partial class ForEach<T> : System.Activities.NativeActivity {
    public ForEach() { }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.ActivityAction<T> Body { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.ActivityAction<T>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.InArgument<System.Collections.Generic.IEnumerable<T>> Values { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<System.Collections.Generic.IEnumerable<T>>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    protected override void CacheMetadata(System.Activities.NativeActivityMetadata metadata) { }
    protected override void Execute(System.Activities.NativeActivityContext context) { }
    protected override void OnCreateDynamicUpdateMap(System.Activities.DynamicUpdate.NativeActivityUpdateMapMetadata metadata, System.Activities.Activity originalActivity) { }
  }
  [System.Windows.Markup.ContentPropertyAttribute("Body")]
  public sealed partial class HandleScope<THandle> : System.Activities.NativeActivity where THandle : System.Activities.Handle {
    public HandleScope() { }
    public System.Activities.Activity Body { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.Activity); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Activities.InArgument<THandle> Handle { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<THandle>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    protected override void CacheMetadata(System.Activities.NativeActivityMetadata metadata) { }
    protected override void Execute(System.Activities.NativeActivityContext context) { }
  }
  public sealed partial class If : System.Activities.NativeActivity {
    public If() { }
    public If(System.Activities.Activity<System.Boolean> condition) { }
    public If(System.Activities.InArgument<System.Boolean> condition) { }
    public If(System.Linq.Expressions.Expression<System.Func<System.Activities.ActivityContext, System.Boolean>> condition) { }
    [System.Activities.RequiredArgumentAttribute]
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.InArgument<System.Boolean> Condition { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<System.Boolean>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    [System.Windows.Markup.DependsOnAttribute("Then")]
    public System.Activities.Activity Else { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.Activity); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    [System.Windows.Markup.DependsOnAttribute("Condition")]
    public System.Activities.Activity Then { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.Activity); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    protected override void CacheMetadata(System.Activities.NativeActivityMetadata metadata) { }
    protected override void Execute(System.Activities.NativeActivityContext context) { }
    protected override void OnCreateDynamicUpdateMap(System.Activities.DynamicUpdate.NativeActivityUpdateMapMetadata metadata, System.Activities.Activity originalActivity) { }
  }
  [System.Windows.Markup.ContentPropertyAttribute("Action")]
  public sealed partial class InvokeAction : System.Activities.NativeActivity {
    public InvokeAction() { }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.ActivityAction Action { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.ActivityAction); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    protected override void CacheMetadata(System.Activities.NativeActivityMetadata metadata) { }
    protected override void Execute(System.Activities.NativeActivityContext context) { }
  }
  [System.Windows.Markup.ContentPropertyAttribute("Action")]
  public sealed partial class InvokeAction<T> : System.Activities.NativeActivity {
    public InvokeAction() { }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.ActivityAction<T> Action { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.ActivityAction<T>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T> Argument { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    protected override void CacheMetadata(System.Activities.NativeActivityMetadata metadata) { }
    protected override void Execute(System.Activities.NativeActivityContext context) { }
    protected override void OnCreateDynamicUpdateMap(System.Activities.DynamicUpdate.NativeActivityUpdateMapMetadata metadata, System.Activities.Activity originalActivity) { }
  }
  [System.Windows.Markup.ContentPropertyAttribute("Action")]
  public sealed partial class InvokeAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> : System.Activities.NativeActivity {
    public InvokeAction() { }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.ActivityAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> Action { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.ActivityAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T1> Argument1 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T1>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T10> Argument10 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T10>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T2> Argument2 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T2>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T3> Argument3 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T3>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T4> Argument4 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T4>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T5> Argument5 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T5>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T6> Argument6 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T6>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T7> Argument7 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T7>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T8> Argument8 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T8>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T9> Argument9 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T9>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    protected override void Execute(System.Activities.NativeActivityContext context) { }
    protected override void OnCreateDynamicUpdateMap(System.Activities.DynamicUpdate.NativeActivityUpdateMapMetadata metadata, System.Activities.Activity originalActivity) { }
  }
  [System.Windows.Markup.ContentPropertyAttribute("Action")]
  public sealed partial class InvokeAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> : System.Activities.NativeActivity {
    public InvokeAction() { }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.ActivityAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> Action { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.ActivityAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T1> Argument1 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T1>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T10> Argument10 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T10>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T11> Argument11 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T11>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T2> Argument2 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T2>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T3> Argument3 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T3>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T4> Argument4 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T4>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T5> Argument5 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T5>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T6> Argument6 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T6>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T7> Argument7 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T7>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T8> Argument8 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T8>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T9> Argument9 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T9>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    protected override void Execute(System.Activities.NativeActivityContext context) { }
    protected override void OnCreateDynamicUpdateMap(System.Activities.DynamicUpdate.NativeActivityUpdateMapMetadata metadata, System.Activities.Activity originalActivity) { }
  }
  [System.Windows.Markup.ContentPropertyAttribute("Action")]
  public sealed partial class InvokeAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> : System.Activities.NativeActivity {
    public InvokeAction() { }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.ActivityAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Action { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.ActivityAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T1> Argument1 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T1>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T10> Argument10 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T10>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T11> Argument11 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T11>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T12> Argument12 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T12>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T2> Argument2 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T2>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T3> Argument3 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T3>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T4> Argument4 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T4>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T5> Argument5 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T5>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T6> Argument6 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T6>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T7> Argument7 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T7>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T8> Argument8 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T8>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T9> Argument9 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T9>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    protected override void Execute(System.Activities.NativeActivityContext context) { }
    protected override void OnCreateDynamicUpdateMap(System.Activities.DynamicUpdate.NativeActivityUpdateMapMetadata metadata, System.Activities.Activity originalActivity) { }
  }
  [System.Windows.Markup.ContentPropertyAttribute("Action")]
  public sealed partial class InvokeAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> : System.Activities.NativeActivity {
    public InvokeAction() { }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.ActivityAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> Action { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.ActivityAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T1> Argument1 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T1>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T10> Argument10 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T10>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T11> Argument11 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T11>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T12> Argument12 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T12>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T13> Argument13 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T13>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T2> Argument2 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T2>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T3> Argument3 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T3>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T4> Argument4 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T4>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T5> Argument5 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T5>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T6> Argument6 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T6>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T7> Argument7 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T7>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T8> Argument8 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T8>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T9> Argument9 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T9>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    protected override void Execute(System.Activities.NativeActivityContext context) { }
    protected override void OnCreateDynamicUpdateMap(System.Activities.DynamicUpdate.NativeActivityUpdateMapMetadata metadata, System.Activities.Activity originalActivity) { }
  }
  [System.Windows.Markup.ContentPropertyAttribute("Action")]
  public sealed partial class InvokeAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> : System.Activities.NativeActivity {
    public InvokeAction() { }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.ActivityAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> Action { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.ActivityAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T1> Argument1 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T1>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T10> Argument10 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T10>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T11> Argument11 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T11>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T12> Argument12 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T12>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T13> Argument13 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T13>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T14> Argument14 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T14>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T2> Argument2 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T2>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T3> Argument3 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T3>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T4> Argument4 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T4>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T5> Argument5 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T5>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T6> Argument6 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T6>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T7> Argument7 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T7>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T8> Argument8 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T8>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T9> Argument9 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T9>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    protected override void Execute(System.Activities.NativeActivityContext context) { }
    protected override void OnCreateDynamicUpdateMap(System.Activities.DynamicUpdate.NativeActivityUpdateMapMetadata metadata, System.Activities.Activity originalActivity) { }
  }
  [System.Windows.Markup.ContentPropertyAttribute("Action")]
  public sealed partial class InvokeAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> : System.Activities.NativeActivity {
    public InvokeAction() { }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.ActivityAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> Action { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.ActivityAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T1> Argument1 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T1>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T10> Argument10 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T10>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T11> Argument11 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T11>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T12> Argument12 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T12>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T13> Argument13 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T13>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T14> Argument14 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T14>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T15> Argument15 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T15>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T2> Argument2 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T2>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T3> Argument3 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T3>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T4> Argument4 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T4>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T5> Argument5 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T5>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T6> Argument6 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T6>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T7> Argument7 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T7>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T8> Argument8 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T8>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T9> Argument9 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T9>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    protected override void Execute(System.Activities.NativeActivityContext context) { }
    protected override void OnCreateDynamicUpdateMap(System.Activities.DynamicUpdate.NativeActivityUpdateMapMetadata metadata, System.Activities.Activity originalActivity) { }
  }
  [System.Windows.Markup.ContentPropertyAttribute("Action")]
  public sealed partial class InvokeAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> : System.Activities.NativeActivity {
    public InvokeAction() { }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.ActivityAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> Action { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.ActivityAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T1> Argument1 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T1>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T10> Argument10 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T10>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T11> Argument11 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T11>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T12> Argument12 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T12>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T13> Argument13 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T13>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T14> Argument14 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T14>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T15> Argument15 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T15>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T16> Argument16 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T16>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T2> Argument2 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T2>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T3> Argument3 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T3>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T4> Argument4 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T4>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T5> Argument5 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T5>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T6> Argument6 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T6>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T7> Argument7 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T7>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T8> Argument8 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T8>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T9> Argument9 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T9>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    protected override void Execute(System.Activities.NativeActivityContext context) { }
    protected override void OnCreateDynamicUpdateMap(System.Activities.DynamicUpdate.NativeActivityUpdateMapMetadata metadata, System.Activities.Activity originalActivity) { }
  }
  [System.Windows.Markup.ContentPropertyAttribute("Action")]
  public sealed partial class InvokeAction<T1, T2> : System.Activities.NativeActivity {
    public InvokeAction() { }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.ActivityAction<T1, T2> Action { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.ActivityAction<T1, T2>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T1> Argument1 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T1>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T2> Argument2 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T2>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    protected override void Execute(System.Activities.NativeActivityContext context) { }
    protected override void OnCreateDynamicUpdateMap(System.Activities.DynamicUpdate.NativeActivityUpdateMapMetadata metadata, System.Activities.Activity originalActivity) { }
  }
  [System.Windows.Markup.ContentPropertyAttribute("Action")]
  public sealed partial class InvokeAction<T1, T2, T3> : System.Activities.NativeActivity {
    public InvokeAction() { }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.ActivityAction<T1, T2, T3> Action { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.ActivityAction<T1, T2, T3>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T1> Argument1 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T1>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T2> Argument2 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T2>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T3> Argument3 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T3>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    protected override void Execute(System.Activities.NativeActivityContext context) { }
    protected override void OnCreateDynamicUpdateMap(System.Activities.DynamicUpdate.NativeActivityUpdateMapMetadata metadata, System.Activities.Activity originalActivity) { }
  }
  [System.Windows.Markup.ContentPropertyAttribute("Action")]
  public sealed partial class InvokeAction<T1, T2, T3, T4> : System.Activities.NativeActivity {
    public InvokeAction() { }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.ActivityAction<T1, T2, T3, T4> Action { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.ActivityAction<T1, T2, T3, T4>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T1> Argument1 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T1>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T2> Argument2 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T2>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T3> Argument3 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T3>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T4> Argument4 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T4>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    protected override void Execute(System.Activities.NativeActivityContext context) { }
    protected override void OnCreateDynamicUpdateMap(System.Activities.DynamicUpdate.NativeActivityUpdateMapMetadata metadata, System.Activities.Activity originalActivity) { }
  }
  [System.Windows.Markup.ContentPropertyAttribute("Action")]
  public sealed partial class InvokeAction<T1, T2, T3, T4, T5> : System.Activities.NativeActivity {
    public InvokeAction() { }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.ActivityAction<T1, T2, T3, T4, T5> Action { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.ActivityAction<T1, T2, T3, T4, T5>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T1> Argument1 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T1>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T2> Argument2 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T2>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T3> Argument3 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T3>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T4> Argument4 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T4>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T5> Argument5 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T5>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    protected override void Execute(System.Activities.NativeActivityContext context) { }
    protected override void OnCreateDynamicUpdateMap(System.Activities.DynamicUpdate.NativeActivityUpdateMapMetadata metadata, System.Activities.Activity originalActivity) { }
  }
  [System.Windows.Markup.ContentPropertyAttribute("Action")]
  public sealed partial class InvokeAction<T1, T2, T3, T4, T5, T6> : System.Activities.NativeActivity {
    public InvokeAction() { }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.ActivityAction<T1, T2, T3, T4, T5, T6> Action { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.ActivityAction<T1, T2, T3, T4, T5, T6>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T1> Argument1 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T1>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T2> Argument2 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T2>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T3> Argument3 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T3>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T4> Argument4 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T4>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T5> Argument5 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T5>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T6> Argument6 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T6>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    protected override void Execute(System.Activities.NativeActivityContext context) { }
    protected override void OnCreateDynamicUpdateMap(System.Activities.DynamicUpdate.NativeActivityUpdateMapMetadata metadata, System.Activities.Activity originalActivity) { }
  }
  [System.Windows.Markup.ContentPropertyAttribute("Action")]
  public sealed partial class InvokeAction<T1, T2, T3, T4, T5, T6, T7> : System.Activities.NativeActivity {
    public InvokeAction() { }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.ActivityAction<T1, T2, T3, T4, T5, T6, T7> Action { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.ActivityAction<T1, T2, T3, T4, T5, T6, T7>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T1> Argument1 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T1>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T2> Argument2 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T2>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T3> Argument3 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T3>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T4> Argument4 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T4>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T5> Argument5 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T5>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T6> Argument6 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T6>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T7> Argument7 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T7>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    protected override void Execute(System.Activities.NativeActivityContext context) { }
    protected override void OnCreateDynamicUpdateMap(System.Activities.DynamicUpdate.NativeActivityUpdateMapMetadata metadata, System.Activities.Activity originalActivity) { }
  }
  [System.Windows.Markup.ContentPropertyAttribute("Action")]
  public sealed partial class InvokeAction<T1, T2, T3, T4, T5, T6, T7, T8> : System.Activities.NativeActivity {
    public InvokeAction() { }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.ActivityAction<T1, T2, T3, T4, T5, T6, T7, T8> Action { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.ActivityAction<T1, T2, T3, T4, T5, T6, T7, T8>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T1> Argument1 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T1>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T2> Argument2 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T2>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T3> Argument3 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T3>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T4> Argument4 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T4>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T5> Argument5 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T5>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T6> Argument6 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T6>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T7> Argument7 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T7>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T8> Argument8 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T8>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    protected override void Execute(System.Activities.NativeActivityContext context) { }
    protected override void OnCreateDynamicUpdateMap(System.Activities.DynamicUpdate.NativeActivityUpdateMapMetadata metadata, System.Activities.Activity originalActivity) { }
  }
  [System.Windows.Markup.ContentPropertyAttribute("Action")]
  public sealed partial class InvokeAction<T1, T2, T3, T4, T5, T6, T7, T8, T9> : System.Activities.NativeActivity {
    public InvokeAction() { }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.ActivityAction<T1, T2, T3, T4, T5, T6, T7, T8, T9> Action { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.ActivityAction<T1, T2, T3, T4, T5, T6, T7, T8, T9>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T1> Argument1 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T1>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T2> Argument2 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T2>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T3> Argument3 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T3>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T4> Argument4 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T4>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T5> Argument5 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T5>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T6> Argument6 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T6>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T7> Argument7 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T7>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T8> Argument8 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T8>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    public System.Activities.InArgument<T9> Argument9 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T9>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    protected override void Execute(System.Activities.NativeActivityContext context) { }
    protected override void OnCreateDynamicUpdateMap(System.Activities.DynamicUpdate.NativeActivityUpdateMapMetadata metadata, System.Activities.Activity originalActivity) { }
  }
  [System.Windows.Markup.ContentPropertyAttribute("Delegate")]
  public sealed partial class InvokeDelegate : System.Activities.NativeActivity {
    public InvokeDelegate() { }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.Activity Default { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.Activity); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.ActivityDelegate Delegate { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.ActivityDelegate); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Collections.Generic.IDictionary<System.String, System.Activities.Argument> DelegateArguments { get { return default(System.Collections.Generic.IDictionary<System.String, System.Activities.Argument>); } }
    protected override void CacheMetadata(System.Activities.NativeActivityMetadata metadata) { }
    protected override void Execute(System.Activities.NativeActivityContext context) { }
    protected override void OnCreateDynamicUpdateMap(System.Activities.DynamicUpdate.NativeActivityUpdateMapMetadata metadata, System.Activities.Activity originalActivity) { }
  }
  [System.Windows.Markup.ContentPropertyAttribute("Parameters")]
  public sealed partial class InvokeMethod : System.Activities.AsyncCodeActivity {
    public InvokeMethod() { }
    public System.Collections.ObjectModel.Collection<System.Type> GenericTypeArguments { get { return default(System.Collections.ObjectModel.Collection<System.Type>); } }
    public string MethodName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Collections.ObjectModel.Collection<System.Activities.Argument> Parameters { get { return default(System.Collections.ObjectModel.Collection<System.Activities.Argument>); } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.OutArgument Result { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.OutArgument); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(false)]
    public bool RunAsynchronously { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.InArgument TargetObject { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Type TargetType { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Type); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    protected override System.IAsyncResult BeginExecute(System.Activities.AsyncCodeActivityContext context, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    protected override void CacheMetadata(System.Activities.CodeActivityMetadata metadata) { }
    protected override void EndExecute(System.Activities.AsyncCodeActivityContext context, System.IAsyncResult result) { }
  }
  [System.Windows.Markup.ContentPropertyAttribute("Body")]
  public sealed partial class NoPersistScope : System.Activities.NativeActivity {
    public NoPersistScope() { }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.Activity Body { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.Activity); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    protected override void CacheMetadata(System.Activities.NativeActivityMetadata metadata) { }
    protected override void Execute(System.Activities.NativeActivityContext context) { }
  }
  [System.Windows.Markup.ContentPropertyAttribute("Branches")]
  public sealed partial class Parallel : System.Activities.NativeActivity {
    public Parallel() { }
    [System.Windows.Markup.DependsOnAttribute("CompletionCondition")]
    public System.Collections.ObjectModel.Collection<System.Activities.Activity> Branches { get { return default(System.Collections.ObjectModel.Collection<System.Activities.Activity>); } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    [System.Windows.Markup.DependsOnAttribute("Variables")]
    public System.Activities.Activity<System.Boolean> CompletionCondition { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.Activity<System.Boolean>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Collections.ObjectModel.Collection<System.Activities.Variable> Variables { get { return default(System.Collections.ObjectModel.Collection<System.Activities.Variable>); } }
    protected override void CacheMetadata(System.Activities.NativeActivityMetadata metadata) { }
    protected override void Cancel(System.Activities.NativeActivityContext context) { }
    protected override void Execute(System.Activities.NativeActivityContext context) { }
    protected override void OnCreateDynamicUpdateMap(System.Activities.DynamicUpdate.NativeActivityUpdateMapMetadata metadata, System.Activities.Activity originalActivity) { }
    protected override void UpdateInstance(System.Activities.DynamicUpdate.NativeActivityUpdateContext updateContext) { }
  }
  [System.Windows.Markup.ContentPropertyAttribute("Body")]
  public sealed partial class ParallelForEach<T> : System.Activities.NativeActivity {
    public ParallelForEach() { }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.ActivityAction<T> Body { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.ActivityAction<T>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.Activity<System.Boolean> CompletionCondition { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.Activity<System.Boolean>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.InArgument<System.Collections.Generic.IEnumerable<T>> Values { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<System.Collections.Generic.IEnumerable<T>>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    protected override void CacheMetadata(System.Activities.NativeActivityMetadata metadata) { }
    protected override void Execute(System.Activities.NativeActivityContext context) { }
    protected override void OnCreateDynamicUpdateMap(System.Activities.DynamicUpdate.NativeActivityUpdateMapMetadata metadata, System.Activities.Activity originalActivity) { }
  }
  public sealed partial class Persist : System.Activities.NativeActivity {
    public Persist() { }
    protected override bool CanInduceIdle { get { return default(bool); } }
    protected override void CacheMetadata(System.Activities.NativeActivityMetadata metadata) { }
    protected override void Execute(System.Activities.NativeActivityContext context) { }
  }
  [System.Windows.Markup.ContentPropertyAttribute("Branches")]
  public sealed partial class Pick : System.Activities.NativeActivity {
    public Pick() { }
    public System.Collections.ObjectModel.Collection<System.Activities.Statements.PickBranch> Branches { get { return default(System.Collections.ObjectModel.Collection<System.Activities.Statements.PickBranch>); } }
    protected override bool CanInduceIdle { get { return default(bool); } }
    protected override void CacheMetadata(System.Activities.NativeActivityMetadata metadata) { }
    protected override void Cancel(System.Activities.NativeActivityContext context) { }
    protected override void Execute(System.Activities.NativeActivityContext context) { }
    protected override void OnCreateDynamicUpdateMap(System.Activities.DynamicUpdate.NativeActivityUpdateMapMetadata metadata, System.Activities.Activity originalActivity) { }
    protected override void UpdateInstance(System.Activities.DynamicUpdate.NativeActivityUpdateContext updateContext) { }
  }
  [System.Windows.Markup.ContentPropertyAttribute("Action")]
  public sealed partial class PickBranch {
    public PickBranch() { }
    [System.ComponentModel.DefaultValueAttribute(null)]
    [System.Windows.Markup.DependsOnAttribute("Trigger")]
    public System.Activities.Activity Action { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.Activity); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute("PickBranch")]
    public string DisplayName { get { return default(string); } set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    [System.Windows.Markup.DependsOnAttribute("Variables")]
    public System.Activities.Activity Trigger { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.Activity); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Collections.ObjectModel.Collection<System.Activities.Variable> Variables { get { return default(System.Collections.ObjectModel.Collection<System.Activities.Variable>); } }
  }
  [System.Windows.Markup.ContentPropertyAttribute("Collection")]
  public sealed partial class RemoveFromCollection<T> : System.Activities.CodeActivity<System.Boolean> {
    public RemoveFromCollection() { }
    [System.Activities.RequiredArgumentAttribute]
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.InArgument<System.Collections.Generic.ICollection<T>> Collection { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<System.Collections.Generic.ICollection<T>>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.InArgument<T> Item { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    protected override void CacheMetadata(System.Activities.CodeActivityMetadata metadata) { }
    protected override bool Execute(System.Activities.CodeActivityContext context) { return default(bool); }
  }
  public sealed partial class Rethrow : System.Activities.NativeActivity {
    public Rethrow() { }
    protected override void CacheMetadata(System.Activities.NativeActivityMetadata metadata) { }
    protected override void Execute(System.Activities.NativeActivityContext context) { }
  }
  [System.Windows.Markup.ContentPropertyAttribute("Activities")]
  public sealed partial class Sequence : System.Activities.NativeActivity {
    public Sequence() { }
    [System.Windows.Markup.DependsOnAttribute("Variables")]
    public System.Collections.ObjectModel.Collection<System.Activities.Activity> Activities { get { return default(System.Collections.ObjectModel.Collection<System.Activities.Activity>); } }
    public System.Collections.ObjectModel.Collection<System.Activities.Variable> Variables { get { return default(System.Collections.ObjectModel.Collection<System.Activities.Variable>); } }
    protected override void CacheMetadata(System.Activities.NativeActivityMetadata metadata) { }
    protected override void Execute(System.Activities.NativeActivityContext context) { }
    protected override void OnCreateDynamicUpdateMap(System.Activities.DynamicUpdate.NativeActivityUpdateMapMetadata metadata, System.Activities.Activity originalActivity) { }
  }
  public sealed partial class State {
    public State() { }
    public string DisplayName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.Activity Entry { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.Activity); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    [System.Windows.Markup.DependsOnAttribute("Entry")]
    public System.Activities.Activity Exit { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.Activity); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(false)]
    public bool IsFinal { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Windows.Markup.DependsOnAttribute("Exit")]
    public System.Collections.ObjectModel.Collection<System.Activities.Statements.Transition> Transitions { get { return default(System.Collections.ObjectModel.Collection<System.Activities.Statements.Transition>); } }
    [System.Windows.Markup.DependsOnAttribute("Transitions")]
    public System.Collections.ObjectModel.Collection<System.Activities.Variable> Variables { get { return default(System.Collections.ObjectModel.Collection<System.Activities.Variable>); } }
  }
  [System.Windows.Markup.ContentPropertyAttribute("States")]
  public sealed partial class StateMachine : System.Activities.NativeActivity {
    public StateMachine() { }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.Statements.State InitialState { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.Statements.State); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Windows.Markup.DependsOnAttribute("InitialState")]
    public System.Collections.ObjectModel.Collection<System.Activities.Statements.State> States { get { return default(System.Collections.ObjectModel.Collection<System.Activities.Statements.State>); } }
    [System.Windows.Markup.DependsOnAttribute("States")]
    public System.Collections.ObjectModel.Collection<System.Activities.Variable> Variables { get { return default(System.Collections.ObjectModel.Collection<System.Activities.Variable>); } }
    protected override void CacheMetadata(System.Activities.NativeActivityMetadata metadata) { }
    protected override void Execute(System.Activities.NativeActivityContext context) { }
    protected override void OnCreateDynamicUpdateMap(System.Activities.DynamicUpdate.NativeActivityUpdateMapMetadata metadata, System.Activities.Activity originalActivity) { }
  }
  [System.Windows.Markup.ContentPropertyAttribute("Cases")]
  public sealed partial class Switch<T> : System.Activities.NativeActivity {
    public Switch() { }
    public Switch(System.Activities.Activity<T> expression) { }
    public Switch(System.Activities.InArgument<T> expression) { }
    public Switch(System.Linq.Expressions.Expression<System.Func<System.Activities.ActivityContext, T>> expression) { }
    public System.Collections.Generic.IDictionary<T, System.Activities.Activity> Cases { get { return default(System.Collections.Generic.IDictionary<T, System.Activities.Activity>); } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.Activity Default { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.Activity); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Activities.RequiredArgumentAttribute]
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.InArgument<T> Expression { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<T>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    protected override void CacheMetadata(System.Activities.NativeActivityMetadata metadata) { }
    protected override void Execute(System.Activities.NativeActivityContext context) { }
    protected override void OnCreateDynamicUpdateMap(System.Activities.DynamicUpdate.NativeActivityUpdateMapMetadata metadata, System.Activities.Activity originalActivity) { }
  }
  public sealed partial class TerminateWorkflow : System.Activities.NativeActivity {
    public TerminateWorkflow() { }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.InArgument<System.Exception> Exception { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<System.Exception>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.InArgument<System.String> Reason { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<System.String>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    protected override void CacheMetadata(System.Activities.NativeActivityMetadata metadata) { }
    protected override void Execute(System.Activities.NativeActivityContext context) { }
  }
  [System.Windows.Markup.ContentPropertyAttribute("Exception")]
  public sealed partial class Throw : System.Activities.CodeActivity {
    public Throw() { }
    [System.Activities.RequiredArgumentAttribute]
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.InArgument<System.Exception> Exception { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<System.Exception>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    protected override void CacheMetadata(System.Activities.CodeActivityMetadata metadata) { }
    protected override void Execute(System.Activities.CodeActivityContext context) { }
  }
  public abstract partial class TimerExtension {
    protected TimerExtension() { }
    public void CancelTimer(System.Activities.Bookmark bookmark) { }
    protected abstract void OnCancelTimer(System.Activities.Bookmark bookmark);
    protected abstract void OnRegisterTimer(System.TimeSpan timeout, System.Activities.Bookmark bookmark);
    public void RegisterTimer(System.TimeSpan timeout, System.Activities.Bookmark bookmark) { }
  }
  [System.Windows.Markup.ContentPropertyAttribute("Body")]
  public sealed partial class TransactionScope : System.Activities.NativeActivity {
    public TransactionScope() { }
    [System.ComponentModel.DefaultValueAttribute(true)]
    public bool AbortInstanceOnTransactionFailure { get { return default(bool); } set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.Activity Body { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.Activity); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    protected override bool CanInduceIdle { get { return default(bool); } }
    public System.Transactions.IsolationLevel IsolationLevel { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Transactions.IsolationLevel); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Activities.InArgument<System.TimeSpan> Timeout { get { return default(System.Activities.InArgument<System.TimeSpan>); } set { } }
    protected override void CacheMetadata(System.Activities.NativeActivityMetadata metadata) { }
    protected override void Execute(System.Activities.NativeActivityContext context) { }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public bool ShouldSerializeIsolationLevel() { return default(bool); }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public bool ShouldSerializeTimeout() { return default(bool); }
  }
  public sealed partial class Transition {
    public Transition() { }
    [System.ComponentModel.DefaultValueAttribute(null)]
    [System.Windows.Markup.DependsOnAttribute("To")]
    public System.Activities.Activity Action { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.Activity); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    [System.Windows.Markup.DependsOnAttribute("Action")]
    public System.Activities.Activity<System.Boolean> Condition { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.Activity<System.Boolean>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public string DisplayName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    [System.Windows.Markup.DependsOnAttribute("Trigger")]
    public System.Activities.Statements.State To { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.Statements.State); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.Activity Trigger { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.Activity); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
  }
  public sealed partial class TryCatch : System.Activities.NativeActivity {
    public TryCatch() { }
    [System.Windows.Markup.DependsOnAttribute("Try")]
    public System.Collections.ObjectModel.Collection<System.Activities.Statements.Catch> Catches { get { return default(System.Collections.ObjectModel.Collection<System.Activities.Statements.Catch>); } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    [System.Windows.Markup.DependsOnAttribute("Catches")]
    public System.Activities.Activity Finally { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.Activity); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    [System.Windows.Markup.DependsOnAttribute("Variables")]
    public System.Activities.Activity Try { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.Activity); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Collections.ObjectModel.Collection<System.Activities.Variable> Variables { get { return default(System.Collections.ObjectModel.Collection<System.Activities.Variable>); } }
    protected override void CacheMetadata(System.Activities.NativeActivityMetadata metadata) { }
    protected override void Cancel(System.Activities.NativeActivityContext context) { }
    protected override void Execute(System.Activities.NativeActivityContext context) { }
    protected override void OnCreateDynamicUpdateMap(System.Activities.DynamicUpdate.NativeActivityUpdateMapMetadata metadata, System.Activities.Activity originalActivity) { }
    protected override void UpdateInstance(System.Activities.DynamicUpdate.NativeActivityUpdateContext updateContext) { }
  }
  [System.Windows.Markup.ContentPropertyAttribute("Body")]
  public sealed partial class While : System.Activities.NativeActivity {
    public While() { }
    public While(System.Activities.Activity<System.Boolean> condition) { }
    public While(System.Linq.Expressions.Expression<System.Func<System.Activities.ActivityContext, System.Boolean>> condition) { }
    [System.ComponentModel.DefaultValueAttribute(null)]
    [System.Windows.Markup.DependsOnAttribute("Condition")]
    public System.Activities.Activity Body { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.Activity); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    [System.Windows.Markup.DependsOnAttribute("Variables")]
    public System.Activities.Activity<System.Boolean> Condition { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.Activity<System.Boolean>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Collections.ObjectModel.Collection<System.Activities.Variable> Variables { get { return default(System.Collections.ObjectModel.Collection<System.Activities.Variable>); } }
    protected override void CacheMetadata(System.Activities.NativeActivityMetadata metadata) { }
    protected override void Execute(System.Activities.NativeActivityContext context) { }
    protected override void OnCreateDynamicUpdateMap(System.Activities.DynamicUpdate.NativeActivityUpdateMapMetadata metadata, System.Activities.Activity originalActivity) { }
  }
  public partial class WorkflowTerminatedException : System.Exception {
    public WorkflowTerminatedException() { }
    protected WorkflowTerminatedException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public WorkflowTerminatedException(string message) { }
    public WorkflowTerminatedException(string message, System.Exception innerException) { }
  }
  [System.Windows.Markup.ContentPropertyAttribute("Text")]
  public sealed partial class WriteLine : System.Activities.CodeActivity {
    public WriteLine() { }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.InArgument<System.String> Text { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<System.String>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.InArgument<System.IO.TextWriter> TextWriter { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<System.IO.TextWriter>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    protected override void CacheMetadata(System.Activities.CodeActivityMetadata metadata) { }
    protected override void Execute(System.Activities.CodeActivityContext context) { }
  }
}
namespace System.Activities.Statements.Tracking {
  public sealed partial class StateMachineStateQuery : System.Activities.Tracking.CustomTrackingQuery {
    public StateMachineStateQuery() { }
    public new string Name { get { return default(string); } }
  }
  [System.Runtime.Serialization.DataContractAttribute]
  public sealed partial class StateMachineStateRecord : System.Activities.Tracking.CustomTrackingRecord {
    public StateMachineStateRecord() : base (default(string)) { }
    public string StateMachineName { get { return default(string); } }
    [System.Runtime.Serialization.DataMemberAttribute]
    public string StateName { get { return default(string); } }
    protected internal override System.Activities.Tracking.TrackingRecord Clone() { return default(System.Activities.Tracking.TrackingRecord); }
  }
}
namespace System.Activities.Tracking {
  [System.Runtime.Serialization.DataContractAttribute]
  public sealed partial class ActivityInfo {
    public ActivityInfo(string name, string id, string instanceId, string typeName) { }
    [System.Runtime.Serialization.DataMemberAttribute]
    public string Id { get { return default(string); } }
    [System.Runtime.Serialization.DataMemberAttribute]
    public string InstanceId { get { return default(string); } }
    [System.Runtime.Serialization.DataMemberAttribute]
    public string Name { get { return default(string); } }
    [System.Runtime.Serialization.DataMemberAttribute]
    public string TypeName { get { return default(string); } }
    public override string ToString() { return default(string); }
  }
  public sealed partial class ActivityScheduledQuery : System.Activities.Tracking.TrackingQuery {
    public ActivityScheduledQuery() { }
    public string ActivityName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public string ChildActivityName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
  }
  [System.Runtime.Serialization.DataContractAttribute]
  public sealed partial class ActivityScheduledRecord : System.Activities.Tracking.TrackingRecord {
    public ActivityScheduledRecord(System.Guid instanceId, long recordNumber, System.Activities.Tracking.ActivityInfo activity, System.Activities.Tracking.ActivityInfo child) : base (default(System.Guid)) { }
    public System.Activities.Tracking.ActivityInfo Activity { get { return default(System.Activities.Tracking.ActivityInfo); } }
    public System.Activities.Tracking.ActivityInfo Child { get { return default(System.Activities.Tracking.ActivityInfo); } }
    protected internal override System.Activities.Tracking.TrackingRecord Clone() { return default(System.Activities.Tracking.TrackingRecord); }
    public override string ToString() { return default(string); }
  }
  public partial class ActivityStateQuery : System.Activities.Tracking.TrackingQuery {
    public ActivityStateQuery() { }
    public string ActivityName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Collections.ObjectModel.Collection<System.String> Arguments { get { return default(System.Collections.ObjectModel.Collection<System.String>); } }
    public System.Collections.ObjectModel.Collection<System.String> States { get { return default(System.Collections.ObjectModel.Collection<System.String>); } }
    public System.Collections.ObjectModel.Collection<System.String> Variables { get { return default(System.Collections.ObjectModel.Collection<System.String>); } }
  }
  [System.Runtime.Serialization.DataContractAttribute]
  public sealed partial class ActivityStateRecord : System.Activities.Tracking.TrackingRecord {
    public ActivityStateRecord(System.Guid instanceId, long recordNumber, System.Activities.Tracking.ActivityInfo activity, string state) : base (default(System.Guid)) { }
    public System.Activities.Tracking.ActivityInfo Activity { get { return default(System.Activities.Tracking.ActivityInfo); } }
    public System.Collections.Generic.IDictionary<System.String, System.Object> Arguments { get { return default(System.Collections.Generic.IDictionary<System.String, System.Object>); } }
    public string State { get { return default(string); } }
    public System.Collections.Generic.IDictionary<System.String, System.Object> Variables { get { return default(System.Collections.Generic.IDictionary<System.String, System.Object>); } }
    protected internal override System.Activities.Tracking.TrackingRecord Clone() { return default(System.Activities.Tracking.TrackingRecord); }
    public override string ToString() { return default(string); }
  }
  public static partial class ActivityStates {
    public const string Canceled = "Canceled";
    public const string Closed = "Closed";
    public const string Executing = "Executing";
    public const string Faulted = "Faulted";
  }
  public sealed partial class BookmarkResumptionQuery : System.Activities.Tracking.TrackingQuery {
    public BookmarkResumptionQuery() { }
    public string Name { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
  }
  [System.Runtime.Serialization.DataContractAttribute]
  public sealed partial class BookmarkResumptionRecord : System.Activities.Tracking.TrackingRecord {
    public BookmarkResumptionRecord(System.Guid instanceId, long recordNumber, System.Guid bookmarkScope, string bookmarkName, System.Activities.Tracking.ActivityInfo owner) : base (default(System.Guid)) { }
    public string BookmarkName { get { return default(string); } }
    public System.Guid BookmarkScope { get { return default(System.Guid); } }
    public System.Activities.Tracking.ActivityInfo Owner { get { return default(System.Activities.Tracking.ActivityInfo); } }
    public object Payload { get { return default(object); } }
    protected internal override System.Activities.Tracking.TrackingRecord Clone() { return default(System.Activities.Tracking.TrackingRecord); }
    public override string ToString() { return default(string); }
  }
  public sealed partial class CancelRequestedQuery : System.Activities.Tracking.TrackingQuery {
    public CancelRequestedQuery() { }
    public string ActivityName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public string ChildActivityName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
  }
  [System.Runtime.Serialization.DataContractAttribute]
  public sealed partial class CancelRequestedRecord : System.Activities.Tracking.TrackingRecord {
    public CancelRequestedRecord(System.Guid instanceId, long recordNumber, System.Activities.Tracking.ActivityInfo activity, System.Activities.Tracking.ActivityInfo child) : base (default(System.Guid)) { }
    public System.Activities.Tracking.ActivityInfo Activity { get { return default(System.Activities.Tracking.ActivityInfo); } }
    public System.Activities.Tracking.ActivityInfo Child { get { return default(System.Activities.Tracking.ActivityInfo); } }
    protected internal override System.Activities.Tracking.TrackingRecord Clone() { return default(System.Activities.Tracking.TrackingRecord); }
    public override string ToString() { return default(string); }
  }
  public partial class CustomTrackingQuery : System.Activities.Tracking.TrackingQuery {
    public CustomTrackingQuery() { }
    public string ActivityName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public string Name { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
  }
  [System.Runtime.Serialization.DataContractAttribute]
  public partial class CustomTrackingRecord : System.Activities.Tracking.TrackingRecord {
    protected CustomTrackingRecord(System.Activities.Tracking.CustomTrackingRecord record) : base (default(System.Guid)) { }
    public CustomTrackingRecord(System.Guid instanceId, string name, System.Diagnostics.TraceLevel level) : base (default(System.Guid)) { }
    public CustomTrackingRecord(string name) : base (default(System.Guid)) { }
    public CustomTrackingRecord(string name, System.Diagnostics.TraceLevel level) : base (default(System.Guid)) { }
    public System.Activities.Tracking.ActivityInfo Activity { get { return default(System.Activities.Tracking.ActivityInfo); } }
    public System.Collections.Generic.IDictionary<System.String, System.Object> Data { get { return default(System.Collections.Generic.IDictionary<System.String, System.Object>); } }
    public string Name { get { return default(string); } }
    protected internal override System.Activities.Tracking.TrackingRecord Clone() { return default(System.Activities.Tracking.TrackingRecord); }
    public override string ToString() { return default(string); }
  }
  public sealed partial class EtwTrackingParticipant : System.Activities.Tracking.TrackingParticipant {
    public EtwTrackingParticipant() { }
    public string ApplicationReference { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Guid EtwProviderId { get { return default(System.Guid); } set { } }
    protected internal override System.IAsyncResult BeginTrack(System.Activities.Tracking.TrackingRecord record, System.TimeSpan timeout, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    protected internal override void EndTrack(System.IAsyncResult result) { }
    protected internal override void Track(System.Activities.Tracking.TrackingRecord record, System.TimeSpan timeout) { }
  }
  public sealed partial class FaultPropagationQuery : System.Activities.Tracking.TrackingQuery {
    public FaultPropagationQuery() { }
    public string FaultHandlerActivityName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public string FaultSourceActivityName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
  }
  [System.Runtime.Serialization.DataContractAttribute]
  public sealed partial class FaultPropagationRecord : System.Activities.Tracking.TrackingRecord {
    public FaultPropagationRecord(System.Guid instanceId, long recordNumber, System.Activities.Tracking.ActivityInfo faultSource, System.Activities.Tracking.ActivityInfo faultHandler, bool isFaultSource, System.Exception fault) : base (default(System.Guid)) { }
    public System.Exception Fault { get { return default(System.Exception); } }
    public System.Activities.Tracking.ActivityInfo FaultHandler { get { return default(System.Activities.Tracking.ActivityInfo); } }
    public System.Activities.Tracking.ActivityInfo FaultSource { get { return default(System.Activities.Tracking.ActivityInfo); } }
    public bool IsFaultSource { get { return default(bool); } }
    protected internal override System.Activities.Tracking.TrackingRecord Clone() { return default(System.Activities.Tracking.TrackingRecord); }
    public override string ToString() { return default(string); }
  }
  public enum ImplementationVisibility {
    All = 1,
    RootScope = 0,
  }
  public abstract partial class TrackingParticipant {
    protected TrackingParticipant() { }
    public virtual System.Activities.Tracking.TrackingProfile TrackingProfile { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.Tracking.TrackingProfile); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    protected internal virtual System.IAsyncResult BeginTrack(System.Activities.Tracking.TrackingRecord record, System.TimeSpan timeout, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    protected internal virtual void EndTrack(System.IAsyncResult result) { }
    protected internal abstract void Track(System.Activities.Tracking.TrackingRecord record, System.TimeSpan timeout);
  }
  [System.Windows.Markup.ContentPropertyAttribute("Queries")]
  public partial class TrackingProfile {
    public TrackingProfile() { }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public string ActivityDefinitionId { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute((System.Activities.Tracking.ImplementationVisibility)(0))]
    public System.Activities.Tracking.ImplementationVisibility ImplementationVisibility { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.Tracking.ImplementationVisibility); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public string Name { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Collections.ObjectModel.Collection<System.Activities.Tracking.TrackingQuery> Queries { get { return default(System.Collections.ObjectModel.Collection<System.Activities.Tracking.TrackingQuery>); } }
  }
  public abstract partial class TrackingQuery {
    protected TrackingQuery() { }
    public System.Collections.Generic.IDictionary<System.String, System.String> QueryAnnotations { get { return default(System.Collections.Generic.IDictionary<System.String, System.String>); } }
  }
  [System.Runtime.Serialization.DataContractAttribute]
  public abstract partial class TrackingRecord {
    protected TrackingRecord(System.Activities.Tracking.TrackingRecord record) { }
    protected TrackingRecord(System.Guid instanceId) { }
    protected TrackingRecord(System.Guid instanceId, long recordNumber) { }
    public System.Collections.Generic.IDictionary<System.String, System.String> Annotations { get { return default(System.Collections.Generic.IDictionary<System.String, System.String>); } }
    public System.DateTime EventTime { get { return default(System.DateTime); } }
    [System.Runtime.Serialization.DataMemberAttribute]
    public System.Guid InstanceId { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Guid); } }
    public System.Diagnostics.TraceLevel Level { get { return default(System.Diagnostics.TraceLevel); } protected set { } }
    [System.Runtime.Serialization.DataMemberAttribute]
    public long RecordNumber { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(long); } }
    protected internal abstract System.Activities.Tracking.TrackingRecord Clone();
    public override string ToString() { return default(string); }
  }
  [System.Runtime.Serialization.DataContractAttribute]
  public sealed partial class WorkflowInstanceAbortedRecord : System.Activities.Tracking.WorkflowInstanceRecord {
    public WorkflowInstanceAbortedRecord(System.Guid instanceId, long recordNumber, string activityDefinitionId, string reason) : base (default(System.Guid), default(string), default(string)) { }
    public WorkflowInstanceAbortedRecord(System.Guid instanceId, long recordNumber, string activityDefinitionId, string reason, System.Activities.WorkflowIdentity workflowDefinitionIdentity) : base (default(System.Guid), default(string), default(string)) { }
    public WorkflowInstanceAbortedRecord(System.Guid instanceId, string activityDefinitionId, string reason) : base (default(System.Guid), default(string), default(string)) { }
    public WorkflowInstanceAbortedRecord(System.Guid instanceId, string activityDefinitionId, string reason, System.Activities.WorkflowIdentity workflowDefinitionIdentity) : base (default(System.Guid), default(string), default(string)) { }
    public string Reason { get { return default(string); } }
    protected internal override System.Activities.Tracking.TrackingRecord Clone() { return default(System.Activities.Tracking.TrackingRecord); }
    public override string ToString() { return default(string); }
  }
  public partial class WorkflowInstanceQuery : System.Activities.Tracking.TrackingQuery {
    public WorkflowInstanceQuery() { }
    public System.Collections.ObjectModel.Collection<System.String> States { get { return default(System.Collections.ObjectModel.Collection<System.String>); } }
  }
  [System.Runtime.Serialization.DataContractAttribute]
  public partial class WorkflowInstanceRecord : System.Activities.Tracking.TrackingRecord {
    protected WorkflowInstanceRecord(System.Activities.Tracking.WorkflowInstanceRecord record) : base (default(System.Guid)) { }
    public WorkflowInstanceRecord(System.Guid instanceId, long recordNumber, string activityDefinitionId, string state) : base (default(System.Guid)) { }
    public WorkflowInstanceRecord(System.Guid instanceId, long recordNumber, string activityDefinitionId, string state, System.Activities.WorkflowIdentity workflowDefinitionIdentity) : base (default(System.Guid)) { }
    public WorkflowInstanceRecord(System.Guid instanceId, string activityDefinitionId, string state) : base (default(System.Guid)) { }
    public WorkflowInstanceRecord(System.Guid instanceId, string activityDefinitionId, string state, System.Activities.WorkflowIdentity workflowDefinitionIdentity) : base (default(System.Guid)) { }
    public string ActivityDefinitionId { get { return default(string); } }
    public string State { get { return default(string); } }
    public System.Activities.WorkflowIdentity WorkflowDefinitionIdentity { get { return default(System.Activities.WorkflowIdentity); } protected set { } }
    protected internal override System.Activities.Tracking.TrackingRecord Clone() { return default(System.Activities.Tracking.TrackingRecord); }
    public override string ToString() { return default(string); }
  }
  public static partial class WorkflowInstanceStates {
    public const string Aborted = "Aborted";
    public const string Canceled = "Canceled";
    public const string Completed = "Completed";
    public const string Deleted = "Deleted";
    public const string Idle = "Idle";
    public const string Persisted = "Persisted";
    public const string Resumed = "Resumed";
    public const string Started = "Started";
    public const string Suspended = "Suspended";
    public const string Terminated = "Terminated";
    public const string UnhandledException = "UnhandledException";
    public const string Unloaded = "Unloaded";
    public const string Unsuspended = "Unsuspended";
    public const string Updated = "Updated";
    public const string UpdateFailed = "UpdateFailed";
  }
  [System.Runtime.Serialization.DataContractAttribute]
  public sealed partial class WorkflowInstanceSuspendedRecord : System.Activities.Tracking.WorkflowInstanceRecord {
    public WorkflowInstanceSuspendedRecord(System.Guid instanceId, long recordNumber, string activityDefinitionId, string reason) : base (default(System.Guid), default(string), default(string)) { }
    public WorkflowInstanceSuspendedRecord(System.Guid instanceId, long recordNumber, string activityDefinitionId, string reason, System.Activities.WorkflowIdentity workflowDefinitionIdentity) : base (default(System.Guid), default(string), default(string)) { }
    public WorkflowInstanceSuspendedRecord(System.Guid instanceId, string activityDefinitionId, string reason) : base (default(System.Guid), default(string), default(string)) { }
    public WorkflowInstanceSuspendedRecord(System.Guid instanceId, string activityDefinitionId, string reason, System.Activities.WorkflowIdentity workflowDefinitionIdentity) : base (default(System.Guid), default(string), default(string)) { }
    public string Reason { get { return default(string); } }
    protected internal override System.Activities.Tracking.TrackingRecord Clone() { return default(System.Activities.Tracking.TrackingRecord); }
    public override string ToString() { return default(string); }
  }
  [System.Runtime.Serialization.DataContractAttribute]
  public sealed partial class WorkflowInstanceTerminatedRecord : System.Activities.Tracking.WorkflowInstanceRecord {
    public WorkflowInstanceTerminatedRecord(System.Guid instanceId, long recordNumber, string activityDefinitionId, string reason) : base (default(System.Guid), default(string), default(string)) { }
    public WorkflowInstanceTerminatedRecord(System.Guid instanceId, long recordNumber, string activityDefinitionId, string reason, System.Activities.WorkflowIdentity workflowDefinitionIdentity) : base (default(System.Guid), default(string), default(string)) { }
    public WorkflowInstanceTerminatedRecord(System.Guid instanceId, string activityDefinitionId, string reason) : base (default(System.Guid), default(string), default(string)) { }
    public WorkflowInstanceTerminatedRecord(System.Guid instanceId, string activityDefinitionId, string reason, System.Activities.WorkflowIdentity workflowDefinitionIdentity) : base (default(System.Guid), default(string), default(string)) { }
    public string Reason { get { return default(string); } }
    protected internal override System.Activities.Tracking.TrackingRecord Clone() { return default(System.Activities.Tracking.TrackingRecord); }
    public override string ToString() { return default(string); }
  }
  [System.Runtime.Serialization.DataContractAttribute]
  public sealed partial class WorkflowInstanceUnhandledExceptionRecord : System.Activities.Tracking.WorkflowInstanceRecord {
    public WorkflowInstanceUnhandledExceptionRecord(System.Guid instanceId, long recordNumber, string activityDefinitionId, System.Activities.Tracking.ActivityInfo faultSource, System.Exception exception) : base (default(System.Guid), default(string), default(string)) { }
    public WorkflowInstanceUnhandledExceptionRecord(System.Guid instanceId, long recordNumber, string activityDefinitionId, System.Activities.Tracking.ActivityInfo faultSource, System.Exception exception, System.Activities.WorkflowIdentity workflowDefinitionIdentity) : base (default(System.Guid), default(string), default(string)) { }
    public WorkflowInstanceUnhandledExceptionRecord(System.Guid instanceId, string activityDefinitionId, System.Activities.Tracking.ActivityInfo faultSource, System.Exception exception) : base (default(System.Guid), default(string), default(string)) { }
    public WorkflowInstanceUnhandledExceptionRecord(System.Guid instanceId, string activityDefinitionId, System.Activities.Tracking.ActivityInfo faultSource, System.Exception exception, System.Activities.WorkflowIdentity workflowDefinitionIdentity) : base (default(System.Guid), default(string), default(string)) { }
    public System.Activities.Tracking.ActivityInfo FaultSource { get { return default(System.Activities.Tracking.ActivityInfo); } }
    public System.Exception UnhandledException { get { return default(System.Exception); } }
    protected internal override System.Activities.Tracking.TrackingRecord Clone() { return default(System.Activities.Tracking.TrackingRecord); }
    public override string ToString() { return default(string); }
  }
  [System.Runtime.Serialization.DataContractAttribute]
  public sealed partial class WorkflowInstanceUpdatedRecord : System.Activities.Tracking.WorkflowInstanceRecord {
    public WorkflowInstanceUpdatedRecord(System.Guid instanceId, long recordNumber, string activityDefinitionId, System.Activities.WorkflowIdentity originalDefinitionIdentity, System.Activities.WorkflowIdentity updatedDefinitionIdentity) : base (default(System.Guid), default(string), default(string)) { }
    public WorkflowInstanceUpdatedRecord(System.Guid instanceId, long recordNumber, string activityDefinitionId, System.Activities.WorkflowIdentity originalDefinitionIdentity, System.Activities.WorkflowIdentity updatedDefinitionIdentity, System.Collections.Generic.IList<System.Activities.DynamicUpdate.ActivityBlockingUpdate> blockingActivities) : base (default(System.Guid), default(string), default(string)) { }
    public WorkflowInstanceUpdatedRecord(System.Guid instanceId, string activityDefinitionId, System.Activities.WorkflowIdentity originalDefinitionIdentity, System.Activities.WorkflowIdentity updatedDefinitionIdentity) : base (default(System.Guid), default(string), default(string)) { }
    public WorkflowInstanceUpdatedRecord(System.Guid instanceId, string activityDefinitionId, System.Activities.WorkflowIdentity originalDefinitionIdentity, System.Activities.WorkflowIdentity updatedDefinitionIdentity, System.Collections.Generic.IList<System.Activities.DynamicUpdate.ActivityBlockingUpdate> blockingActivities) : base (default(System.Guid), default(string), default(string)) { }
    public System.Collections.Generic.IList<System.Activities.DynamicUpdate.ActivityBlockingUpdate> BlockingActivities { get { return default(System.Collections.Generic.IList<System.Activities.DynamicUpdate.ActivityBlockingUpdate>); } }
    public bool IsSuccessful { get { return default(bool); } }
    public System.Activities.WorkflowIdentity OriginalDefinitionIdentity { get { return default(System.Activities.WorkflowIdentity); } }
    protected internal override System.Activities.Tracking.TrackingRecord Clone() { return default(System.Activities.Tracking.TrackingRecord); }
    public override string ToString() { return default(string); }
  }
}
namespace System.Activities.Validation {
  public static partial class ActivityValidationServices {
    public static System.Activities.Activity Resolve(System.Activities.Activity root, string id) { return default(System.Activities.Activity); }
    public static System.Activities.Validation.ValidationResults Validate(System.Activities.Activity toValidate) { return default(System.Activities.Validation.ValidationResults); }
    public static System.Activities.Validation.ValidationResults Validate(System.Activities.Activity toValidate, System.Activities.Validation.ValidationSettings settings) { return default(System.Activities.Validation.ValidationResults); }
  }
  public sealed partial class AddValidationError : System.Activities.NativeActivity {
    public AddValidationError() { }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.InArgument<System.Boolean> IsWarning { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<System.Boolean>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Activities.InArgument<System.String> Message { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<System.String>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.InArgument<System.String> PropertyName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<System.String>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    protected override void CacheMetadata(System.Activities.NativeActivityMetadata metadata) { }
    protected override void Execute(System.Activities.NativeActivityContext context) { }
  }
  public sealed partial class AssertValidation : System.Activities.NativeActivity {
    public AssertValidation() { }
    public System.Activities.InArgument<System.Boolean> Assertion { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<System.Boolean>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.InArgument<System.Boolean> IsWarning { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<System.Boolean>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Activities.InArgument<System.String> Message { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<System.String>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.InArgument<System.String> PropertyName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<System.String>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    protected override void CacheMetadata(System.Activities.NativeActivityMetadata metadata) { }
    protected override void Execute(System.Activities.NativeActivityContext context) { }
  }
  public abstract partial class Constraint : System.Activities.NativeActivity {
    internal Constraint() { }
    public const string ValidationErrorListPropertyName = "System.Activities.Validation.Constraint.ValidationErrorList";
    public static void AddValidationError(System.Activities.NativeActivityContext context, System.Activities.Validation.ValidationError error) { }
    protected override void CacheMetadata(System.Activities.NativeActivityMetadata metadata) { }
    protected override void Execute(System.Activities.NativeActivityContext context) { }
    protected abstract void OnExecute(System.Activities.NativeActivityContext context, object objectToValidate, System.Activities.Validation.ValidationContext objectToValidateContext);
  }
  [System.Windows.Markup.ContentPropertyAttribute("Body")]
  public sealed partial class Constraint<T> : System.Activities.Validation.Constraint {
    public Constraint() { }
    public System.Activities.ActivityAction<T, System.Activities.Validation.ValidationContext> Body { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.ActivityAction<T, System.Activities.Validation.ValidationContext>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    protected override void CacheMetadata(System.Activities.NativeActivityMetadata metadata) { }
    protected override void OnExecute(System.Activities.NativeActivityContext context, object objectToValidate, System.Activities.Validation.ValidationContext objectToValidateContext) { }
  }
  public sealed partial class GetChildSubtree : System.Activities.CodeActivity<System.Collections.Generic.IEnumerable<System.Activities.Activity>> {
    public GetChildSubtree() { }
    public System.Activities.InArgument<System.Activities.Validation.ValidationContext> ValidationContext { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<System.Activities.Validation.ValidationContext>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    protected override System.Collections.Generic.IEnumerable<System.Activities.Activity> Execute(System.Activities.CodeActivityContext context) { return default(System.Collections.Generic.IEnumerable<System.Activities.Activity>); }
  }
  public sealed partial class GetParentChain : System.Activities.CodeActivity<System.Collections.Generic.IEnumerable<System.Activities.Activity>> {
    public GetParentChain() { }
    public System.Activities.InArgument<System.Activities.Validation.ValidationContext> ValidationContext { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<System.Activities.Validation.ValidationContext>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    protected override System.Collections.Generic.IEnumerable<System.Activities.Activity> Execute(System.Activities.CodeActivityContext context) { return default(System.Collections.Generic.IEnumerable<System.Activities.Activity>); }
  }
  public sealed partial class GetWorkflowTree : System.Activities.CodeActivity<System.Collections.Generic.IEnumerable<System.Activities.Activity>> {
    public GetWorkflowTree() { }
    public System.Activities.InArgument<System.Activities.Validation.ValidationContext> ValidationContext { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<System.Activities.Validation.ValidationContext>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    protected override System.Collections.Generic.IEnumerable<System.Activities.Activity> Execute(System.Activities.CodeActivityContext context) { return default(System.Collections.Generic.IEnumerable<System.Activities.Activity>); }
  }
  public sealed partial class ValidationContext {
    internal ValidationContext() { }
  }
  public partial class ValidationError {
    public ValidationError(string message) { }
    public ValidationError(string message, bool isWarning) { }
    public ValidationError(string message, bool isWarning, string propertyName) { }
    public ValidationError(string message, bool isWarning, string propertyName, object sourceDetail) { }
    public string Id { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
    public bool IsWarning { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } }
    public string Message { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
    public string PropertyName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
    public System.Activities.Activity Source { get { return default(System.Activities.Activity); } }
    public object SourceDetail { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(object); } }
    public override string ToString() { return default(string); }
  }
  public partial class ValidationResults {
    public ValidationResults(System.Collections.Generic.IList<System.Activities.Validation.ValidationError> allValidationErrors) { }
    public System.Collections.ObjectModel.ReadOnlyCollection<System.Activities.Validation.ValidationError> Errors { get { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.Activities.Validation.ValidationError>); } }
    public System.Collections.ObjectModel.ReadOnlyCollection<System.Activities.Validation.ValidationError> Warnings { get { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.Activities.Validation.ValidationError>); } }
  }
  public partial class ValidationSettings {
    public ValidationSettings() { }
    public System.Collections.Generic.IDictionary<System.Type, System.Collections.Generic.IList<System.Activities.Validation.Constraint>> AdditionalConstraints { get { return default(System.Collections.Generic.IDictionary<System.Type, System.Collections.Generic.IList<System.Activities.Validation.Constraint>>); } }
    public System.Threading.CancellationToken CancellationToken { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Threading.CancellationToken); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Activities.LocationReferenceEnvironment Environment { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.LocationReferenceEnvironment); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public bool OnlyUseAdditionalConstraints { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public bool PrepareForRuntime { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public bool SingleLevel { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public bool SkipValidatingRootConfiguration { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
  }
}
namespace System.Activities.XamlIntegration {
  public sealed partial class ActivityWithResultConverter : System.Activities.XamlIntegration.TypeConverterBase {
    public ActivityWithResultConverter() { }
    public ActivityWithResultConverter(System.Type type) { }
  }
  public sealed partial class ActivityWithResultValueSerializer : System.Windows.Markup.ValueSerializer {
    public ActivityWithResultValueSerializer() { }
    public override bool CanConvertToString(object value, System.Windows.Markup.IValueSerializerContext context) { return default(bool); }
    public override string ConvertToString(object value, System.Windows.Markup.IValueSerializerContext context) { return default(string); }
  }
  public static partial class ActivityXamlServices {
    public static System.Xaml.XamlReader CreateBuilderReader(System.Xaml.XamlReader innerReader) { return default(System.Xaml.XamlReader); }
    public static System.Xaml.XamlReader CreateBuilderReader(System.Xaml.XamlReader innerReader, System.Xaml.XamlSchemaContext schemaContext) { return default(System.Xaml.XamlReader); }
    public static System.Xaml.XamlWriter CreateBuilderWriter(System.Xaml.XamlWriter innerWriter) { return default(System.Xaml.XamlWriter); }
    public static System.Func<System.Object> CreateFactory(System.Xaml.XamlReader reader, System.Type resultType) { return default(System.Func<System.Object>); }
    public static System.Func<T> CreateFactory<T>(System.Xaml.XamlReader reader) where T : class { return default(System.Func<T>); }
    public static System.Xaml.XamlReader CreateReader(System.IO.Stream stream) { return default(System.Xaml.XamlReader); }
    public static System.Xaml.XamlReader CreateReader(System.Xaml.XamlReader innerReader) { return default(System.Xaml.XamlReader); }
    public static System.Xaml.XamlReader CreateReader(System.Xaml.XamlReader innerReader, System.Xaml.XamlSchemaContext schemaContext) { return default(System.Xaml.XamlReader); }
    [System.Security.SecuritySafeCriticalAttribute]
    public static void InitializeComponent(System.Type componentType, object componentInstance) { }
    public static System.Activities.Activity Load(System.IO.Stream stream) { return default(System.Activities.Activity); }
    public static System.Activities.Activity Load(System.IO.Stream stream, System.Activities.XamlIntegration.ActivityXamlServicesSettings settings) { return default(System.Activities.Activity); }
    public static System.Activities.Activity Load(System.IO.TextReader textReader) { return default(System.Activities.Activity); }
    public static System.Activities.Activity Load(System.IO.TextReader textReader, System.Activities.XamlIntegration.ActivityXamlServicesSettings settings) { return default(System.Activities.Activity); }
    public static System.Activities.Activity Load(string fileName) { return default(System.Activities.Activity); }
    public static System.Activities.Activity Load(string fileName, System.Activities.XamlIntegration.ActivityXamlServicesSettings settings) { return default(System.Activities.Activity); }
    public static System.Activities.Activity Load(System.Xaml.XamlReader xamlReader) { return default(System.Activities.Activity); }
    public static System.Activities.Activity Load(System.Xaml.XamlReader xamlReader, System.Activities.XamlIntegration.ActivityXamlServicesSettings settings) { return default(System.Activities.Activity); }
    public static System.Activities.Activity Load(System.Xml.XmlReader xmlReader) { return default(System.Activities.Activity); }
    public static System.Activities.Activity Load(System.Xml.XmlReader xmlReader, System.Activities.XamlIntegration.ActivityXamlServicesSettings settings) { return default(System.Activities.Activity); }
  }
  public partial class ActivityXamlServicesSettings {
    public ActivityXamlServicesSettings() { }
    public bool CompileExpressions { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Activities.LocationReferenceEnvironment LocationReferenceEnvironment { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.LocationReferenceEnvironment); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
  }
  public partial class ArgumentValueSerializer : System.Windows.Markup.ValueSerializer {
    public ArgumentValueSerializer() { }
    public override bool CanConvertToString(object value, System.Windows.Markup.IValueSerializerContext context) { return default(bool); }
    public override string ConvertToString(object value, System.Windows.Markup.IValueSerializerContext context) { return default(string); }
  }
  public partial class AssemblyReferenceConverter : System.ComponentModel.TypeConverter {
    public AssemblyReferenceConverter() { }
    public override bool CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType) { return default(bool); }
    public override bool CanConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Type destinationType) { return default(bool); }
    public override object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value) { return default(object); }
    public override object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType) { return default(object); }
  }
  public abstract partial class CompiledDataContext {
    protected CompiledDataContext(System.Collections.Generic.IList<System.Activities.Location> locations) { }
    protected CompiledDataContext(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) { }
    protected CompiledDataContext(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, System.Activities.ActivityContext activityContext) { }
    protected static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCache(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) { return default(System.Activities.XamlIntegration.CompiledDataContext[]); }
    protected static object GetDataContextActivities(System.Activities.Activity compiledRoot, bool forImplementation) { return default(object); }
    public System.Activities.Location<T> GetLocation<T>(System.Func<T> getMethod, System.Action<T> setMethod) { return default(System.Activities.Location<T>); }
    public System.Activities.Location<T> GetLocation<T>(System.Func<T> getMethod, System.Action<T> setMethod, int expressionId, System.Activities.Activity compiledRootActivity, System.Activities.ActivityContext activityContext) { return default(System.Activities.Location<T>); }
    protected virtual void GetValueTypeValues() { }
    protected object GetVariableValue(int index) { return default(object); }
    protected System.Linq.Expressions.Expression RewriteExpressionTree(System.Linq.Expressions.Expression originalExpression) { return default(System.Linq.Expressions.Expression); }
    protected virtual void SetValueTypeValues() { }
    protected void SetVariableValue(int index, object value) { }
  }
  public partial class DynamicUpdateMapConverter : System.ComponentModel.TypeConverter {
    public DynamicUpdateMapConverter() { }
    public override bool CanConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Type destinationType) { return default(bool); }
    public override object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType) { return default(object); }
  }
  [System.Windows.Markup.ContentPropertyAttribute("XmlContent")]
  public partial class DynamicUpdateMapExtension : System.Windows.Markup.MarkupExtension {
    public DynamicUpdateMapExtension() { }
    public DynamicUpdateMapExtension(System.Activities.DynamicUpdate.DynamicUpdateMap updateMap) { }
    public System.Activities.DynamicUpdate.DynamicUpdateMap UpdateMap { get { return default(System.Activities.DynamicUpdate.DynamicUpdateMap); } }
    public System.Xml.Serialization.IXmlSerializable XmlContent { get { return default(System.Xml.Serialization.IXmlSerializable); } }
    public override object ProvideValue(System.IServiceProvider serviceProvider) { return default(object); }
  }
  public partial class DynamicUpdateMapItemConverter : System.ComponentModel.TypeConverter {
    public DynamicUpdateMapItemConverter() { }
    public override bool CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType) { return default(bool); }
    public override bool CanConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Type destinationType) { return default(bool); }
    public override object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value) { return default(object); }
    public override object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType) { return default(object); }
  }
  public partial class FuncDeferringLoader : System.Xaml.XamlDeferringLoader {
    public FuncDeferringLoader() { }
    public override object Load(System.Xaml.XamlReader xamlReader, System.IServiceProvider context) { return default(object); }
    public override System.Xaml.XamlReader Save(object value, System.IServiceProvider serviceProvider) { return default(System.Xaml.XamlReader); }
  }
  public partial interface ICompiledExpressionRoot {
    bool CanExecuteExpression(string expressionText, bool isReference, System.Collections.Generic.IList<System.Activities.LocationReference> locations, out int expressionId);
    System.Linq.Expressions.Expression GetExpressionTreeForExpression(int expressionId, System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences);
    string GetLanguage();
    System.Collections.Generic.IList<System.String> GetRequiredLocations(int expressionId);
    object InvokeExpression(int expressionId, System.Collections.Generic.IList<System.Activities.Location> locations);
    object InvokeExpression(int expressionId, System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext);
  }
  public partial class ImplementationVersionConverter : System.ComponentModel.TypeConverter {
    public ImplementationVersionConverter() { }
    public override bool CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType) { return default(bool); }
    public override bool CanConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Type destinationType) { return default(bool); }
    public override object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value) { return default(object); }
    public override object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType) { return default(object); }
  }
  public sealed partial class InArgumentConverter : System.Activities.XamlIntegration.TypeConverterBase {
    public InArgumentConverter() { }
    public InArgumentConverter(System.Type type) { }
  }
  public sealed partial class InOutArgumentConverter : System.Activities.XamlIntegration.TypeConverterBase {
    public InOutArgumentConverter() { }
    public InOutArgumentConverter(System.Type type) { }
  }
  public partial interface IValueSerializableExpression {
    bool CanConvertToString(System.Windows.Markup.IValueSerializerContext context);
    string ConvertToString(System.Windows.Markup.IValueSerializerContext context);
  }
  public sealed partial class OutArgumentConverter : System.Activities.XamlIntegration.TypeConverterBase {
    public OutArgumentConverter() { }
    public OutArgumentConverter(System.Type type) { }
  }
  [System.Windows.Markup.MarkupExtensionReturnTypeAttribute(typeof(object))]
  public sealed partial class PropertyReferenceExtension<T> : System.Windows.Markup.MarkupExtension {
    public PropertyReferenceExtension() { }
    public string PropertyName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public override object ProvideValue(System.IServiceProvider serviceProvider) { return default(object); }
  }
  public partial class SerializableFuncDeferringLoader : System.Xaml.XamlDeferringLoader {
    public SerializableFuncDeferringLoader() { }
    public override object Load(System.Xaml.XamlReader xamlReader, System.IServiceProvider context) { return default(object); }
    public override System.Xaml.XamlReader Save(object value, System.IServiceProvider serviceProvider) { return default(System.Xaml.XamlReader); }
  }
  public partial class TextExpressionCompiler {
    public TextExpressionCompiler(System.Activities.XamlIntegration.TextExpressionCompilerSettings settings) { }
    public System.Activities.XamlIntegration.TextExpressionCompilerResults Compile() { return default(System.Activities.XamlIntegration.TextExpressionCompilerResults); }
    public bool GenerateSource(System.IO.TextWriter textWriter) { return default(bool); }
  }
  public partial class TextExpressionCompilerError {
    internal TextExpressionCompilerError() { }
    public bool IsWarning { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } }
    public string Message { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
    public string Number { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
    public int SourceLineNumber { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(int); } }
  }
  public partial class TextExpressionCompilerResults {
    internal TextExpressionCompilerResults() { }
    public System.Collections.ObjectModel.ReadOnlyCollection<System.Activities.XamlIntegration.TextExpressionCompilerError> CompilerMessages { get { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.Activities.XamlIntegration.TextExpressionCompilerError>); } }
    public bool HasErrors { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } }
    public bool HasSourceInfo { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } }
    public System.Type ResultType { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Type); } }
  }
  public partial class TextExpressionCompilerSettings {
    public TextExpressionCompilerSettings() { }
    public System.Activities.Activity Activity { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.Activity); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public string ActivityName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public string ActivityNamespace { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public bool AlwaysGenerateSource { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public bool ForImplementation { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public bool GenerateAsPartialClass { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public string Language { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Action<System.String> LogSourceGenerationMessage { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Action<System.String>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public string RootNamespace { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
  }
  public abstract partial class TypeConverterBase : System.ComponentModel.TypeConverter {
    internal TypeConverterBase() { }
    public override bool CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType) { return default(bool); }
    public override bool CanConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Type destinationType) { return default(bool); }
    public override object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value) { return default(object); }
    public override object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType) { return default(object); }
  }
  public partial class WorkflowIdentityConverter : System.ComponentModel.TypeConverter {
    public WorkflowIdentityConverter() { }
    public override bool CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType) { return default(bool); }
    public override object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value) { return default(object); }
  }
}
