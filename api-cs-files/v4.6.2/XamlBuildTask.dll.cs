namespace Microsoft.Build.Tasks.Xaml {
  public sealed partial class AttributeData {
    public AttributeData() { }
    public System.Collections.Generic.IList<Microsoft.Build.Tasks.Xaml.AttributeParameterData> Parameters { get { return default(System.Collections.Generic.IList<Microsoft.Build.Tasks.Xaml.AttributeParameterData>); } }
    public System.Collections.Generic.IDictionary<System.String, Microsoft.Build.Tasks.Xaml.AttributeParameterData> Properties { get { return default(System.Collections.Generic.IDictionary<System.String, Microsoft.Build.Tasks.Xaml.AttributeParameterData>); } }
    public System.Xaml.XamlType Type { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Xaml.XamlType); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
  }
  public sealed partial class AttributeParameterData {
    public AttributeParameterData(System.Xaml.XamlType type, System.Collections.Generic.IEnumerable<Microsoft.Build.Tasks.Xaml.AttributeParameterData> arrayContents) { }
    public AttributeParameterData(System.Xaml.XamlType type, object value) { }
    public AttributeParameterData(System.Xaml.XamlType type, string textValue) { }
    public System.Collections.ObjectModel.ReadOnlyCollection<Microsoft.Build.Tasks.Xaml.AttributeParameterData> ArrayContents { get { return default(System.Collections.ObjectModel.ReadOnlyCollection<Microsoft.Build.Tasks.Xaml.AttributeParameterData>); } }
    public string TextValue { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
    public System.Xaml.XamlType Type { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Xaml.XamlType); } }
    public object Value { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(object); } }
  }
  public partial class BuildExtensionContext {
    internal BuildExtensionContext() { }
    public string AssemblyName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
    public System.Collections.ObjectModel.ReadOnlyCollection<System.String> GeneratedFiles { get { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.String>); } }
    public System.Collections.ObjectModel.ReadOnlyCollection<System.String> GeneratedResourceFiles { get { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.String>); } }
    public bool IsInProcessXamlMarkupCompile { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } }
    public string Language { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
    public string LocalAssembly { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
    public string OutputPath { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
    public System.Collections.ObjectModel.ReadOnlyCollection<System.String> References { get { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.String>); } }
    public string RootNamespace { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
    public System.Collections.ObjectModel.ReadOnlyCollection<System.String> SourceCodeFiles { get { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.String>); } }
    public Microsoft.Build.Utilities.TaskLoggingHelper XamlBuildLogger { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(Microsoft.Build.Utilities.TaskLoggingHelper); } }
    public void AddGeneratedFile(string fileName) { }
    public void AddGeneratedResourceFile(string fileName) { }
  }
  public partial class ClassData {
    public ClassData() { }
    public System.Collections.Generic.IList<Microsoft.Build.Tasks.Xaml.AttributeData> Attributes { get { return default(System.Collections.Generic.IList<Microsoft.Build.Tasks.Xaml.AttributeData>); } }
    public System.Xaml.XamlType BaseType { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Xaml.XamlType); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Collections.Generic.IList<System.String> CodeSnippets { get { return default(System.Collections.Generic.IList<System.String>); } }
    public string EmbeddedResourceFileName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
    public System.Xaml.XamlNodeList EmbeddedResourceXaml { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Xaml.XamlNodeList); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public string FileName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
    public string HelperClassFullName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
    public bool IsPublic { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public string Name { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
    public System.Collections.Generic.IList<Microsoft.Build.Tasks.Xaml.NamedObject> NamedObjects { get { return default(System.Collections.Generic.IList<Microsoft.Build.Tasks.Xaml.NamedObject>); } }
    public string Namespace { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
    public System.Collections.ObjectModel.KeyedCollection<System.String, Microsoft.Build.Tasks.Xaml.PropertyData> Properties { get { return default(System.Collections.ObjectModel.KeyedCollection<System.String, Microsoft.Build.Tasks.Xaml.PropertyData>); } }
  }
  public partial class CompilationPass2Task : Microsoft.Build.Utilities.Task {
    public CompilationPass2Task() { }
    public Microsoft.Build.Framework.ITaskItem[] ApplicationMarkup { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(Microsoft.Build.Framework.ITaskItem[]); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public Microsoft.Build.Framework.ITaskItem[] ApplicationMarkupWithTypeName { get { return default(Microsoft.Build.Framework.ITaskItem[]); } set { } }
    public string AssemblyName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public string BuildTaskPath { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [Microsoft.Build.Framework.OutputAttribute]
    public Microsoft.Build.Framework.ITaskItem[] ExtensionGeneratedCodeFiles { get { return default(Microsoft.Build.Framework.ITaskItem[]); } set { } }
    public bool IsInProcessXamlMarkupCompile { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public string Language { get { return default(string); } set { } }
    public string LocalAssemblyReference { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public string MSBuildProjectDirectory { get { return default(string); } set { } }
    public string OutputPath { get { return default(string); } set { } }
    public Microsoft.Build.Framework.ITaskItem[] References { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(Microsoft.Build.Framework.ITaskItem[]); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public string RootNamespace { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public Microsoft.Build.Framework.ITaskItem[] SourceCodeFiles { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(Microsoft.Build.Framework.ITaskItem[]); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public Microsoft.Build.Framework.ITaskItem[] XamlBuildTypeInspectionExtensionNames { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(Microsoft.Build.Framework.ITaskItem[]); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public override bool Execute() { return default(bool); }
  }
  public partial class GenerateTemporaryAssemblyTask : Microsoft.Build.Utilities.Task {
    public GenerateTemporaryAssemblyTask() { }
    [Microsoft.Build.Framework.RequiredAttribute]
    public string ApplicationMarkupTypeName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [Microsoft.Build.Framework.RequiredAttribute]
    public string AssemblyName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [Microsoft.Build.Framework.RequiredAttribute]
    public string CompileTargetName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [Microsoft.Build.Framework.RequiredAttribute]
    public string CurrentProject { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public Microsoft.Build.Framework.ITaskItem[] GeneratedResourcesFiles { get { return default(Microsoft.Build.Framework.ITaskItem[]); } set { } }
    [Microsoft.Build.Framework.RequiredAttribute]
    public string OutputPath { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public Microsoft.Build.Framework.ITaskItem[] ReferencePaths { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(Microsoft.Build.Framework.ITaskItem[]); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [Microsoft.Build.Framework.RequiredAttribute]
    public Microsoft.Build.Framework.ITaskItem[] SourceCodeFiles { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(Microsoft.Build.Framework.ITaskItem[]); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public override bool Execute() { return default(bool); }
  }
  public partial interface IXamlBuildTypeGenerationExtension {
    bool Execute(Microsoft.Build.Tasks.Xaml.ClassData classData, Microsoft.Build.Tasks.Xaml.XamlBuildTypeGenerationExtensionContext buildContext);
  }
  public partial interface IXamlBuildTypeInspectionExtension {
    bool Execute(Microsoft.Build.Tasks.Xaml.XamlBuildTypeInspectionExtensionContext buildContext);
  }
  public enum MemberVisibility {
    Assembly = 3,
    Family = 2,
    FamilyAndAssembly = 5,
    FamilyOrAssembly = 4,
    Private = 1,
    Public = 0,
  }
  public partial class NamedObject {
    public NamedObject() { }
    public string Name { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Xaml.XamlType Type { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Xaml.XamlType); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public Microsoft.Build.Tasks.Xaml.MemberVisibility Visibility { get { return default(Microsoft.Build.Tasks.Xaml.MemberVisibility); } set { } }
  }
  public partial class PartialClassGenerationTask : Microsoft.Build.Utilities.Task {
    public PartialClassGenerationTask() { }
    [Microsoft.Build.Framework.OutputAttribute]
    public Microsoft.Build.Framework.ITaskItem[] ApplicationMarkup { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(Microsoft.Build.Framework.ITaskItem[]); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public string AssemblyName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public string BuildTaskPath { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [Microsoft.Build.Framework.OutputAttribute]
    public Microsoft.Build.Framework.ITaskItem[] GeneratedCodeFiles { get { return default(Microsoft.Build.Framework.ITaskItem[]); } set { } }
    [Microsoft.Build.Framework.OutputAttribute]
    public Microsoft.Build.Framework.ITaskItem[] GeneratedResources { get { return default(Microsoft.Build.Framework.ITaskItem[]); } set { } }
    public string GeneratedSourceExtension { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public bool IsInProcessXamlMarkupCompile { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.String[] KnownReferencePaths { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.String[]); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [Microsoft.Build.Framework.RequiredAttribute]
    public string Language { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public string MSBuildProjectDirectory { get { return default(string); } set { } }
    [Microsoft.Build.Framework.RequiredAttribute]
    public string OutputPath { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public Microsoft.Build.Framework.ITaskItem[] References { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(Microsoft.Build.Framework.ITaskItem[]); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [Microsoft.Build.Framework.OutputAttribute]
    public bool RequiresCompilationPass2 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public string RootNamespace { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public Microsoft.Build.Framework.ITaskItem[] SourceCodeFiles { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(Microsoft.Build.Framework.ITaskItem[]); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public Microsoft.Build.Framework.ITaskItem[] XamlBuildTypeGenerationExtensionNames { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(Microsoft.Build.Framework.ITaskItem[]); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public Microsoft.Build.Framework.ITaskItem[] XamlBuildTypeInspectionExtensionNames { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(Microsoft.Build.Framework.ITaskItem[]); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public override bool Execute() { return default(bool); }
  }
  public sealed partial class PropertyData {
    public PropertyData() { }
    public System.Collections.Generic.IList<Microsoft.Build.Tasks.Xaml.AttributeData> Attributes { get { return default(System.Collections.Generic.IList<Microsoft.Build.Tasks.Xaml.AttributeData>); } }
    public string Name { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Xaml.XamlType Type { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Xaml.XamlType); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute("")]
    public Microsoft.Build.Tasks.Xaml.MemberVisibility Visibility { get { return default(Microsoft.Build.Tasks.Xaml.MemberVisibility); } set { } }
  }
  public sealed partial class XamlBuildTypeGenerationExtensionContext : Microsoft.Build.Tasks.Xaml.BuildExtensionContext {
    public XamlBuildTypeGenerationExtensionContext() { }
    public Microsoft.Build.Framework.ITaskItem InputTaskItem { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(Microsoft.Build.Framework.ITaskItem); } }
  }
  public sealed partial class XamlBuildTypeInspectionExtensionContext : Microsoft.Build.Tasks.Xaml.BuildExtensionContext {
    public XamlBuildTypeInspectionExtensionContext() { }
    public System.Collections.Generic.IDictionary<System.String, Microsoft.Build.Framework.ITaskItem> MarkupItemsByTypeName { get { return default(System.Collections.Generic.IDictionary<System.String, Microsoft.Build.Framework.ITaskItem>); } }
  }
}
