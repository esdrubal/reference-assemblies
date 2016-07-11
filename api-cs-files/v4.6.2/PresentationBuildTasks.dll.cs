namespace Microsoft.Build.Tasks.Windows {
  public sealed partial class FileClassifier : Microsoft.Build.Utilities.Task {
    public FileClassifier() { }
    [Microsoft.Build.Framework.OutputAttribute]
    public Microsoft.Build.Framework.ITaskItem[] CLREmbeddedResource { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(Microsoft.Build.Framework.ITaskItem[]); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public Microsoft.Build.Framework.ITaskItem[] CLRResourceFiles { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(Microsoft.Build.Framework.ITaskItem[]); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [Microsoft.Build.Framework.OutputAttribute]
    public Microsoft.Build.Framework.ITaskItem[] CLRSatelliteEmbeddedResource { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(Microsoft.Build.Framework.ITaskItem[]); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public string Culture { get { return default(string); } set { } }
    [Microsoft.Build.Framework.OutputAttribute]
    public Microsoft.Build.Framework.ITaskItem[] MainEmbeddedFiles { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(Microsoft.Build.Framework.ITaskItem[]); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [Microsoft.Build.Framework.RequiredAttribute]
    public string OutputType { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [Microsoft.Build.Framework.OutputAttribute]
    public Microsoft.Build.Framework.ITaskItem[] SatelliteEmbeddedFiles { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(Microsoft.Build.Framework.ITaskItem[]); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [Microsoft.Build.Framework.RequiredAttribute]
    public Microsoft.Build.Framework.ITaskItem[] SourceFiles { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(Microsoft.Build.Framework.ITaskItem[]); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public override bool Execute() { return default(bool); }
  }
  public sealed partial class GenerateTemporaryTargetAssembly : Microsoft.Build.Utilities.Task {
    public GenerateTemporaryTargetAssembly() { }
    [Microsoft.Build.Framework.RequiredAttribute]
    public string AssemblyName { get { return default(string); } set { } }
    [Microsoft.Build.Framework.RequiredAttribute]
    public string CompileTargetName { get { return default(string); } set { } }
    [Microsoft.Build.Framework.RequiredAttribute]
    public string CompileTypeName { get { return default(string); } set { } }
    [Microsoft.Build.Framework.RequiredAttribute]
    public string CurrentProject { get { return default(string); } set { } }
    public Microsoft.Build.Framework.ITaskItem[] GeneratedCodeFiles { get { return default(Microsoft.Build.Framework.ITaskItem[]); } set { } }
    [Microsoft.Build.Framework.RequiredAttribute]
    public string IntermediateOutputPath { get { return default(string); } set { } }
    [Microsoft.Build.Framework.RequiredAttribute]
    public string MSBuildBinPath { get { return default(string); } set { } }
    public Microsoft.Build.Framework.ITaskItem[] ReferencePath { get { return default(Microsoft.Build.Framework.ITaskItem[]); } set { } }
    [Microsoft.Build.Framework.RequiredAttribute]
    public string ReferencePathTypeName { get { return default(string); } set { } }
    public override bool Execute() { return default(bool); }
  }
  public sealed partial class GetWinFXPath : Microsoft.Build.Utilities.Task {
    public GetWinFXPath() { }
    [Microsoft.Build.Framework.RequiredAttribute]
    public string WinFXNativePath { get { return default(string); } set { } }
    [Microsoft.Build.Framework.OutputAttribute]
    public string WinFXPath { get { return default(string); } set { } }
    [Microsoft.Build.Framework.RequiredAttribute]
    public string WinFXWowPath { get { return default(string); } set { } }
    public override bool Execute() { return default(bool); }
  }
  public sealed partial class MarkupCompilePass1 : Microsoft.Build.Utilities.Task {
    public MarkupCompilePass1() { }
    [Microsoft.Build.Framework.OutputAttribute]
    public Microsoft.Build.Framework.ITaskItem[] AllGeneratedFiles { get { return default(Microsoft.Build.Framework.ITaskItem[]); } set { } }
    public bool AlwaysCompileMarkupFilesInSeparateDomain { get { return default(bool); } set { } }
    public Microsoft.Build.Framework.ITaskItem[] ApplicationMarkup { get { return default(Microsoft.Build.Framework.ITaskItem[]); } set { } }
    public System.String[] AssembliesGeneratedDuringBuild { get { return default(System.String[]); } set { } }
    [Microsoft.Build.Framework.RequiredAttribute]
    public string AssemblyName { get { return default(string); } set { } }
    public string AssemblyPublicKeyToken { get { return default(string); } set { } }
    public string AssemblyVersion { get { return default(string); } set { } }
    public Microsoft.Build.Framework.ITaskItem[] ContentFiles { get { return default(Microsoft.Build.Framework.ITaskItem[]); } set { } }
    public string DefineConstants { get { return default(string); } set { } }
    public Microsoft.Build.Framework.ITaskItem[] ExtraBuildControlFiles { get { return default(Microsoft.Build.Framework.ITaskItem[]); } set { } }
    [Microsoft.Build.Framework.OutputAttribute]
    public Microsoft.Build.Framework.ITaskItem[] GeneratedBamlFiles { get { return default(Microsoft.Build.Framework.ITaskItem[]); } set { } }
    [Microsoft.Build.Framework.OutputAttribute]
    public Microsoft.Build.Framework.ITaskItem[] GeneratedCodeFiles { get { return default(Microsoft.Build.Framework.ITaskItem[]); } set { } }
    [Microsoft.Build.Framework.OutputAttribute]
    public Microsoft.Build.Framework.ITaskItem[] GeneratedLocalizationFiles { get { return default(Microsoft.Build.Framework.ITaskItem[]); } set { } }
    public string HostInBrowser { get { return default(string); } set { } }
    public bool IsRunningInVisualStudio { get { return default(bool); } set { } }
    public System.String[] KnownReferencePaths { get { return default(System.String[]); } set { } }
    [Microsoft.Build.Framework.RequiredAttribute]
    public string Language { get { return default(string); } set { } }
    public string LanguageSourceExtension { get { return default(string); } set { } }
    public string LocalizationDirectivesToLocFile { get { return default(string); } set { } }
    [Microsoft.Build.Framework.RequiredAttribute]
    public string OutputPath { get { return default(string); } set { } }
    [Microsoft.Build.Framework.RequiredAttribute]
    public string OutputType { get { return default(string); } set { } }
    public Microsoft.Build.Framework.ITaskItem[] PageMarkup { get { return default(Microsoft.Build.Framework.ITaskItem[]); } set { } }
    public Microsoft.Build.Framework.ITaskItem[] References { get { return default(Microsoft.Build.Framework.ITaskItem[]); } set { } }
    [Microsoft.Build.Framework.OutputAttribute]
    public bool RequirePass2ForMainAssembly { get { return default(bool); } set { } }
    [Microsoft.Build.Framework.OutputAttribute]
    public bool RequirePass2ForSatelliteAssembly { get { return default(bool); } set { } }
    public string RootNamespace { get { return default(string); } set { } }
    public Microsoft.Build.Framework.ITaskItem[] SourceCodeFiles { get { return default(Microsoft.Build.Framework.ITaskItem[]); } set { } }
    public Microsoft.Build.Framework.ITaskItem[] SplashScreen { get { return default(Microsoft.Build.Framework.ITaskItem[]); } set { } }
    public string UICulture { get { return default(string); } set { } }
    public bool XamlDebuggingInformation { get { return default(bool); } set { } }
    public override bool Execute() { return default(bool); }
  }
  public sealed partial class MarkupCompilePass2 : Microsoft.Build.Utilities.Task {
    public MarkupCompilePass2() { }
    public bool AlwaysCompileMarkupFilesInSeparateDomain { get { return default(bool); } set { } }
    public System.String[] AssembliesGeneratedDuringBuild { get { return default(System.String[]); } set { } }
    [Microsoft.Build.Framework.RequiredAttribute]
    public string AssemblyName { get { return default(string); } set { } }
    [Microsoft.Build.Framework.OutputAttribute]
    public Microsoft.Build.Framework.ITaskItem[] GeneratedBaml { get { return default(Microsoft.Build.Framework.ITaskItem[]); } set { } }
    public System.String[] KnownReferencePaths { get { return default(System.String[]); } set { } }
    [Microsoft.Build.Framework.RequiredAttribute]
    public string Language { get { return default(string); } set { } }
    public string LocalizationDirectivesToLocFile { get { return default(string); } set { } }
    [Microsoft.Build.Framework.RequiredAttribute]
    public string OutputPath { get { return default(string); } set { } }
    [Microsoft.Build.Framework.RequiredAttribute]
    public string OutputType { get { return default(string); } set { } }
    public Microsoft.Build.Framework.ITaskItem[] References { get { return default(Microsoft.Build.Framework.ITaskItem[]); } set { } }
    public string RootNamespace { get { return default(string); } set { } }
    public bool XamlDebuggingInformation { get { return default(bool); } set { } }
    public override bool Execute() { return default(bool); }
  }
  public sealed partial class MergeLocalizationDirectives : Microsoft.Build.Utilities.Task {
    public MergeLocalizationDirectives() { }
    [Microsoft.Build.Framework.RequiredAttribute]
    public Microsoft.Build.Framework.ITaskItem[] GeneratedLocalizationFiles { get { return default(Microsoft.Build.Framework.ITaskItem[]); } set { } }
    [Microsoft.Build.Framework.OutputAttribute]
    [Microsoft.Build.Framework.RequiredAttribute]
    public string OutputFile { get { return default(string); } set { } }
    public override bool Execute() { return default(bool); }
  }
  public sealed partial class ResourcesGenerator : Microsoft.Build.Utilities.Task {
    public ResourcesGenerator() { }
    [Microsoft.Build.Framework.RequiredAttribute]
    public string OutputPath { get { return default(string); } set { } }
    [Microsoft.Build.Framework.OutputAttribute]
    [Microsoft.Build.Framework.RequiredAttribute]
    public Microsoft.Build.Framework.ITaskItem[] OutputResourcesFile { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(Microsoft.Build.Framework.ITaskItem[]); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [Microsoft.Build.Framework.RequiredAttribute]
    public Microsoft.Build.Framework.ITaskItem[] ResourceFiles { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(Microsoft.Build.Framework.ITaskItem[]); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public override bool Execute() { return default(bool); }
  }
  public sealed partial class UidManager : Microsoft.Build.Utilities.Task {
    public UidManager() { }
    public string IntermediateDirectory { get { return default(string); } set { } }
    [Microsoft.Build.Framework.RequiredAttribute]
    public Microsoft.Build.Framework.ITaskItem[] MarkupFiles { get { return default(Microsoft.Build.Framework.ITaskItem[]); } set { } }
    [Microsoft.Build.Framework.RequiredAttribute]
    public string Task { get { return default(string); } set { } }
    public override bool Execute() { return default(bool); }
  }
  public sealed partial class UpdateManifestForBrowserApplication : Microsoft.Build.Utilities.Task {
    public UpdateManifestForBrowserApplication() { }
    [Microsoft.Build.Framework.RequiredAttribute]
    public Microsoft.Build.Framework.ITaskItem[] ApplicationManifest { get { return default(Microsoft.Build.Framework.ITaskItem[]); } set { } }
    [Microsoft.Build.Framework.RequiredAttribute]
    public bool HostInBrowser { get { return default(bool); } set { } }
    public override bool Execute() { return default(bool); }
  }
}
