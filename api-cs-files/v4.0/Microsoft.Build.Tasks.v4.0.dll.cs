namespace Microsoft.Build.Tasks {
  public partial class AL : Microsoft.Build.Tasks.ToolTaskExtension {
    public AL() { }
    public string AlgorithmId { get { return default(string); } set { } }
    public string BaseAddress { get { return default(string); } set { } }
    public string CompanyName { get { return default(string); } set { } }
    public string Configuration { get { return default(string); } set { } }
    public string Copyright { get { return default(string); } set { } }
    public string Culture { get { return default(string); } set { } }
    public bool DelaySign { get { return default(bool); } set { } }
    public string Description { get { return default(string); } set { } }
    public Microsoft.Build.Framework.ITaskItem[] EmbedResources { get { return default(Microsoft.Build.Framework.ITaskItem[]); } set { } }
    public string EvidenceFile { get { return default(string); } set { } }
    public string FileVersion { get { return default(string); } set { } }
    public string Flags { get { return default(string); } set { } }
    public bool GenerateFullPaths { get { return default(bool); } set { } }
    public string KeyContainer { get { return default(string); } set { } }
    public string KeyFile { get { return default(string); } set { } }
    public Microsoft.Build.Framework.ITaskItem[] LinkResources { get { return default(Microsoft.Build.Framework.ITaskItem[]); } set { } }
    public string MainEntryPoint { get { return default(string); } set { } }
    [Microsoft.Build.Framework.OutputAttribute]
    [Microsoft.Build.Framework.RequiredAttribute]
    public Microsoft.Build.Framework.ITaskItem OutputAssembly { get { return default(Microsoft.Build.Framework.ITaskItem); } set { } }
    public string Platform { get { return default(string); } set { } }
    public string ProductName { get { return default(string); } set { } }
    public string ProductVersion { get { return default(string); } set { } }
    public System.String[] ResponseFiles { get { return default(System.String[]); } set { } }
    public Microsoft.Build.Framework.ITaskItem[] SourceModules { get { return default(Microsoft.Build.Framework.ITaskItem[]); } set { } }
    public string TargetType { get { return default(string); } set { } }
    public string TemplateFile { get { return default(string); } set { } }
    public string Title { get { return default(string); } set { } }
    protected override string ToolName { get { return default(string); } }
    public string Trademark { get { return default(string); } set { } }
    public string Version { get { return default(string); } set { } }
    public string Win32Icon { get { return default(string); } set { } }
    public string Win32Resource { get { return default(string); } set { } }
    [System.MonoTODOAttribute]
    protected internal override void AddResponseFileCommands(Microsoft.Build.Tasks.CommandLineBuilderExtension commandLine) { }
    public override bool Execute() { return default(bool); }
    protected override string GenerateFullPathToTool() { return default(string); }
  }
  [Microsoft.Build.Framework.LoadInSeparateAppDomainAttribute]
  public abstract partial class AppDomainIsolatedTaskExtension : Microsoft.Build.Utilities.AppDomainIsolatedTask {
    internal AppDomainIsolatedTaskExtension() { }
    public new Microsoft.Build.Utilities.TaskLoggingHelper Log { get { return default(Microsoft.Build.Utilities.TaskLoggingHelper); } }
  }
  public partial class AspNetCompiler : Microsoft.Build.Tasks.ToolTaskExtension {
    public AspNetCompiler() { }
    public bool AllowPartiallyTrustedCallers { get { return default(bool); } set { } }
    public bool Clean { get { return default(bool); } set { } }
    public bool Debug { get { return default(bool); } set { } }
    public bool DelaySign { get { return default(bool); } set { } }
    public bool FixedNames { get { return default(bool); } set { } }
    public bool Force { get { return default(bool); } set { } }
    public string KeyContainer { get { return default(string); } set { } }
    public string KeyFile { get { return default(string); } set { } }
    public string MetabasePath { get { return default(string); } set { } }
    public string PhysicalPath { get { return default(string); } set { } }
    public string TargetPath { get { return default(string); } set { } }
    protected override string ToolName { get { return default(string); } }
    public bool Updateable { get { return default(bool); } set { } }
    public string VirtualPath { get { return default(string); } set { } }
    [System.MonoTODOAttribute]
    protected internal override void AddCommandLineCommands(Microsoft.Build.Tasks.CommandLineBuilderExtension commandLine) { }
    [System.MonoTODOAttribute]
    public override bool Execute() { return default(bool); }
    [System.MonoTODOAttribute]
    protected override string GenerateFullPathToTool() { return default(string); }
    [System.MonoTODOAttribute]
    protected override bool ValidateParameters() { return default(bool); }
  }
  public partial class AssignCulture : Microsoft.Build.Tasks.TaskExtension {
    public AssignCulture() { }
    [Microsoft.Build.Framework.OutputAttribute]
    public Microsoft.Build.Framework.ITaskItem[] AssignedFiles { get { return default(Microsoft.Build.Framework.ITaskItem[]); } }
    [Microsoft.Build.Framework.OutputAttribute]
    public Microsoft.Build.Framework.ITaskItem[] AssignedFilesWithCulture { get { return default(Microsoft.Build.Framework.ITaskItem[]); } }
    [Microsoft.Build.Framework.OutputAttribute]
    public Microsoft.Build.Framework.ITaskItem[] AssignedFilesWithNoCulture { get { return default(Microsoft.Build.Framework.ITaskItem[]); } }
    [Microsoft.Build.Framework.OutputAttribute]
    public Microsoft.Build.Framework.ITaskItem[] CultureNeutralAssignedFiles { get { return default(Microsoft.Build.Framework.ITaskItem[]); } }
    [Microsoft.Build.Framework.RequiredAttribute]
    public Microsoft.Build.Framework.ITaskItem[] Files { get { return default(Microsoft.Build.Framework.ITaskItem[]); } set { } }
    public override bool Execute() { return default(bool); }
  }
  public partial class AssignProjectConfiguration : Microsoft.Build.Tasks.ResolveProjectBase {
    public AssignProjectConfiguration() { }
    [Microsoft.Build.Framework.OutputAttribute]
    public Microsoft.Build.Framework.ITaskItem[] AssignedProjects { get { return default(Microsoft.Build.Framework.ITaskItem[]); } set { } }
    public string SolutionConfigurationContents { get { return default(string); } set { } }
    [Microsoft.Build.Framework.OutputAttribute]
    public Microsoft.Build.Framework.ITaskItem[] UnassignedProjects { get { return default(Microsoft.Build.Framework.ITaskItem[]); } set { } }
    [System.MonoTODOAttribute]
    public override bool Execute() { return default(bool); }
  }
  public partial class AssignTargetPath : Microsoft.Build.Tasks.TaskExtension {
    public AssignTargetPath() { }
    [Microsoft.Build.Framework.OutputAttribute]
    public Microsoft.Build.Framework.ITaskItem[] AssignedFiles { get { return default(Microsoft.Build.Framework.ITaskItem[]); } }
    public Microsoft.Build.Framework.ITaskItem[] Files { get { return default(Microsoft.Build.Framework.ITaskItem[]); } set { } }
    [Microsoft.Build.Framework.RequiredAttribute]
    public string RootFolder { get { return default(string); } set { } }
    public override bool Execute() { return default(bool); }
  }
  public partial class CallTarget : Microsoft.Build.Tasks.TaskExtension {
    public CallTarget() { }
    public bool RunEachTargetSeparately { get { return default(bool); } set { } }
    [Microsoft.Build.Framework.OutputAttribute]
    public Microsoft.Build.Framework.ITaskItem[] TargetOutputs { get { return default(Microsoft.Build.Framework.ITaskItem[]); } }
    public System.String[] Targets { get { return default(System.String[]); } set { } }
    public override bool Execute() { return default(bool); }
  }
  public partial class CodeTaskFactory : Microsoft.Build.Framework.ITaskFactory {
    public CodeTaskFactory() { }
    public string FactoryName { get { return default(string); } }
    public System.Type TaskType { get { return default(System.Type); } }
    public void CleanupTask(Microsoft.Build.Framework.ITask task) { }
    public Microsoft.Build.Framework.ITask CreateTask(Microsoft.Build.Framework.IBuildEngine loggingHost) { return default(Microsoft.Build.Framework.ITask); }
    public Microsoft.Build.Framework.TaskPropertyInfo[] GetTaskParameters() { return default(Microsoft.Build.Framework.TaskPropertyInfo[]); }
    public bool Initialize(string taskName, System.Collections.Generic.IDictionary<System.String, Microsoft.Build.Framework.TaskPropertyInfo> taskParameters, string taskElementContents, Microsoft.Build.Framework.IBuildEngine taskFactoryLoggingHost) { return default(bool); }
  }
  [System.MonoTODOAttribute]
  public partial class CombinePath : Microsoft.Build.Tasks.TaskExtension {
    public CombinePath() { }
    public string BasePath { get { return default(string); } set { } }
    [Microsoft.Build.Framework.OutputAttribute]
    public Microsoft.Build.Framework.ITaskItem[] CombinedPaths { get { return default(Microsoft.Build.Framework.ITaskItem[]); } set { } }
    [Microsoft.Build.Framework.RequiredAttribute]
    public Microsoft.Build.Framework.ITaskItem[] Paths { get { return default(Microsoft.Build.Framework.ITaskItem[]); } set { } }
    public override bool Execute() { return default(bool); }
  }
  public partial class CommandLineBuilderExtension : Microsoft.Build.Utilities.CommandLineBuilder {
    public CommandLineBuilderExtension() { }
  }
  public partial class Copy : Microsoft.Build.Tasks.TaskExtension {
    public Copy() { }
    [Microsoft.Build.Framework.OutputAttribute]
    public Microsoft.Build.Framework.ITaskItem[] CopiedFiles { get { return default(Microsoft.Build.Framework.ITaskItem[]); } }
    [Microsoft.Build.Framework.OutputAttribute]
    public Microsoft.Build.Framework.ITaskItem[] DestinationFiles { get { return default(Microsoft.Build.Framework.ITaskItem[]); } set { } }
    public Microsoft.Build.Framework.ITaskItem DestinationFolder { get { return default(Microsoft.Build.Framework.ITaskItem); } set { } }
    public bool OverwriteReadOnlyFiles { get { return default(bool); } set { } }
    public bool SkipUnchangedFiles { get { return default(bool); } set { } }
    [Microsoft.Build.Framework.RequiredAttribute]
    public Microsoft.Build.Framework.ITaskItem[] SourceFiles { get { return default(Microsoft.Build.Framework.ITaskItem[]); } set { } }
    public override bool Execute() { return default(bool); }
  }
  public partial class CreateCSharpManifestResourceName : Microsoft.Build.Tasks.CreateManifestResourceName {
    public CreateCSharpManifestResourceName() { }
    protected override string CreateManifestName(string fileName, string linkFileName, string rootNamespace, string dependentUponFileName, System.IO.Stream binaryStream) { return default(string); }
    protected override bool IsSourceFile(string fileName) { return default(bool); }
  }
  public partial class CreateItem : Microsoft.Build.Tasks.TaskExtension {
    public CreateItem() { }
    public System.String[] AdditionalMetadata { get { return default(System.String[]); } set { } }
    public Microsoft.Build.Framework.ITaskItem[] Exclude { get { return default(Microsoft.Build.Framework.ITaskItem[]); } set { } }
    [Microsoft.Build.Framework.OutputAttribute]
    public Microsoft.Build.Framework.ITaskItem[] Include { get { return default(Microsoft.Build.Framework.ITaskItem[]); } set { } }
    public bool PreserveExistingMetadata { get { return default(bool); } set { } }
    public override bool Execute() { return default(bool); }
  }
  public abstract partial class CreateManifestResourceName : Microsoft.Build.Tasks.TaskExtension {
    protected CreateManifestResourceName() { }
    [Microsoft.Build.Framework.OutputAttribute]
    public Microsoft.Build.Framework.ITaskItem[] ManifestResourceNames { get { return default(Microsoft.Build.Framework.ITaskItem[]); } }
    [Microsoft.Build.Framework.RequiredAttribute]
    public Microsoft.Build.Framework.ITaskItem[] ResourceFiles { get { return default(Microsoft.Build.Framework.ITaskItem[]); } set { } }
    public string RootNamespace { get { return default(string); } set { } }
    protected abstract string CreateManifestName(string fileName, string linkFileName, string rootNamespaceName, string dependentUponFileName, System.IO.Stream binaryStream);
    public override bool Execute() { return default(bool); }
    protected abstract bool IsSourceFile(string fileName);
    [System.MonoTODOAttribute]
    public static string MakeValidEverettIdentifier(string name) { return default(string); }
  }
  public partial class CreateProperty : Microsoft.Build.Tasks.TaskExtension {
    public CreateProperty() { }
    [Microsoft.Build.Framework.OutputAttribute]
    public System.String[] Value { get { return default(System.String[]); } set { } }
    [Microsoft.Build.Framework.OutputAttribute]
    [System.MonoTODOAttribute]
    public System.String[] ValueSetByTask { get { return default(System.String[]); } }
    public override bool Execute() { return default(bool); }
  }
  public partial class CreateVisualBasicManifestResourceName : Microsoft.Build.Tasks.CreateManifestResourceName {
    public CreateVisualBasicManifestResourceName() { }
    protected override string CreateManifestName(string fileName, string linkFileName, string rootNamespace, string dependentUponFileName, System.IO.Stream binaryStream) { return default(string); }
    protected override bool IsSourceFile(string fileName) { return default(bool); }
  }
  public partial class Csc : Microsoft.Build.Tasks.ManagedCompiler {
    public Csc() { }
    public bool AllowUnsafeBlocks { get { return default(bool); } set { } }
    public string BaseAddress { get { return default(string); } set { } }
    public bool CheckForOverflowUnderflow { get { return default(bool); } set { } }
    public string DisabledWarnings { get { return default(string); } set { } }
    public string DocumentationFile { get { return default(string); } set { } }
    public string ErrorReport { get { return default(string); } set { } }
    public bool GenerateFullPaths { get { return default(bool); } set { } }
    public string LangVersion { get { return default(string); } set { } }
    public string ModuleAssemblyName { get { return default(string); } set { } }
    public bool NoStandardLib { get { return default(bool); } set { } }
    public string PdbFile { get { return default(string); } set { } }
    public string Platform { get { return default(string); } set { } }
    protected override string ToolName { get { return default(string); } }
    public bool UseHostCompilerIfAvailable { get { return default(bool); } set { } }
    public int WarningLevel { get { return default(int); } set { } }
    public string WarningsAsErrors { get { return default(string); } set { } }
    public string WarningsNotAsErrors { get { return default(string); } set { } }
    protected internal override void AddResponseFileCommands(Microsoft.Build.Tasks.CommandLineBuilderExtension commandLine) { }
    [System.MonoTODOAttribute]
    protected override bool CallHostObjectToExecute() { return default(bool); }
    protected override string GenerateFullPathToTool() { return default(string); }
    [System.MonoTODOAttribute]
    protected override Microsoft.Build.Utilities.HostObjectInitializationStatus InitializeHostObject() { return default(Microsoft.Build.Utilities.HostObjectInitializationStatus); }
  }
  public sealed partial class Delete : Microsoft.Build.Tasks.TaskExtension {
    public Delete() { }
    [Microsoft.Build.Framework.OutputAttribute]
    public Microsoft.Build.Framework.ITaskItem[] DeletedFiles { get { return default(Microsoft.Build.Framework.ITaskItem[]); } set { } }
    [Microsoft.Build.Framework.RequiredAttribute]
    public Microsoft.Build.Framework.ITaskItem[] Files { get { return default(Microsoft.Build.Framework.ITaskItem[]); } set { } }
    public bool TreatErrorsAsWarnings { get { return default(bool); } set { } }
    public override bool Execute() { return default(bool); }
  }
  public sealed partial class Error : Microsoft.Build.Tasks.TaskExtension {
    public Error() { }
    public string Code { get { return default(string); } set { } }
    public string File { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public string HelpKeyword { get { return default(string); } set { } }
    public string Text { get { return default(string); } set { } }
    public override bool Execute() { return default(bool); }
  }
  public partial class Exec : Microsoft.Build.Tasks.ToolTaskExtension {
    public Exec() { }
    [Microsoft.Build.Framework.RequiredAttribute]
    public string Command { get { return default(string); } set { } }
    public string CustomErrorRegularExpression { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public string CustomWarningRegularExpression { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public bool IgnoreExitCode { get { return default(bool); } set { } }
    public bool IgnoreStandardErrorWarningFormat { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [Microsoft.Build.Framework.OutputAttribute]
    public Microsoft.Build.Framework.ITaskItem[] Outputs { get { return default(Microsoft.Build.Framework.ITaskItem[]); } set { } }
    protected override System.Text.Encoding StandardErrorEncoding { get { return default(System.Text.Encoding); } }
    protected override Microsoft.Build.Framework.MessageImportance StandardErrorLoggingImportance { get { return default(Microsoft.Build.Framework.MessageImportance); } }
    protected override System.Text.Encoding StandardOutputEncoding { get { return default(System.Text.Encoding); } }
    protected override Microsoft.Build.Framework.MessageImportance StandardOutputLoggingImportance { get { return default(Microsoft.Build.Framework.MessageImportance); } }
    [Microsoft.Build.Framework.OutputAttribute]
    [System.MonoTODOAttribute]
    public string StdErrEncoding { get { return default(string); } set { } }
    [Microsoft.Build.Framework.OutputAttribute]
    [System.MonoTODOAttribute]
    public string StdOutEncoding { get { return default(string); } set { } }
    [System.MonoTODOAttribute]
    protected override string ToolName { get { return default(string); } }
    public string WorkingDirectory { get { return default(string); } set { } }
    protected internal override void AddCommandLineCommands(Microsoft.Build.Tasks.CommandLineBuilderExtension commandLine) { }
    protected override int ExecuteTool(string pathToTool, string responseFileCommands, string commandLineCommands) { return default(int); }
    [System.MonoTODOAttribute]
    protected override string GenerateFullPathToTool() { return default(string); }
    protected override string GetWorkingDirectory() { return default(string); }
    protected override bool HandleTaskExecutionErrors() { return default(bool); }
    protected override void LogEventsFromTextOutput(string singleLine, Microsoft.Build.Framework.MessageImportance messageImportance) { }
    [System.MonoTODOAttribute]
    protected override void LogPathToTool(string toolName, string pathToTool) { }
    [System.MonoTODOAttribute]
    protected override void LogToolCommand(string message) { }
    [System.MonoTODOAttribute]
    protected override bool ValidateParameters() { return default(bool); }
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct ExtractedClassName {
    public bool IsInsideConditionalBlock { get { return default(bool); } set { } }
    public string Name { get { return default(string); } set { } }
  }
  public partial class FindAppConfigFile : Microsoft.Build.Tasks.TaskExtension {
    public FindAppConfigFile() { }
    [Microsoft.Build.Framework.OutputAttribute]
    public Microsoft.Build.Framework.ITaskItem AppConfigFile { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(Microsoft.Build.Framework.ITaskItem); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [Microsoft.Build.Framework.RequiredAttribute]
    public Microsoft.Build.Framework.ITaskItem[] PrimaryList { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(Microsoft.Build.Framework.ITaskItem[]); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [Microsoft.Build.Framework.RequiredAttribute]
    public Microsoft.Build.Framework.ITaskItem[] SecondaryList { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(Microsoft.Build.Framework.ITaskItem[]); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [Microsoft.Build.Framework.RequiredAttribute]
    public string TargetPath { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public override bool Execute() { return default(bool); }
  }
  public partial class FindUnderPath : Microsoft.Build.Tasks.TaskExtension {
    public FindUnderPath() { }
    public Microsoft.Build.Framework.ITaskItem[] Files { get { return default(Microsoft.Build.Framework.ITaskItem[]); } set { } }
    [Microsoft.Build.Framework.OutputAttribute]
    public Microsoft.Build.Framework.ITaskItem[] InPath { get { return default(Microsoft.Build.Framework.ITaskItem[]); } set { } }
    [Microsoft.Build.Framework.OutputAttribute]
    public Microsoft.Build.Framework.ITaskItem[] OutOfPath { get { return default(Microsoft.Build.Framework.ITaskItem[]); } set { } }
    [Microsoft.Build.Framework.RequiredAttribute]
    public Microsoft.Build.Framework.ITaskItem Path { get { return default(Microsoft.Build.Framework.ITaskItem); } set { } }
    public override bool Execute() { return default(bool); }
  }
  public sealed partial class FormatUrl : Microsoft.Build.Tasks.TaskExtension {
    public FormatUrl() { }
    public string InputUrl { get { return default(string); } set { } }
    [Microsoft.Build.Framework.OutputAttribute]
    public string OutputUrl { get { return default(string); } set { } }
    [System.MonoTODOAttribute]
    public override bool Execute() { return default(bool); }
  }
  public sealed partial class FormatVersion : Microsoft.Build.Tasks.TaskExtension {
    public FormatVersion() { }
    public string FormatType { get { return default(string); } set { } }
    [Microsoft.Build.Framework.OutputAttribute]
    public string OutputVersion { get { return default(string); } set { } }
    public int Revision { get { return default(int); } set { } }
    public string Version { get { return default(string); } set { } }
    public override bool Execute() { return default(bool); }
  }
  public sealed partial class GenerateApplicationManifest : Microsoft.Build.Tasks.GenerateManifestBase {
    public GenerateApplicationManifest() { }
    public string ClrVersion { get { return default(string); } set { } }
    public Microsoft.Build.Framework.ITaskItem ConfigFile { get { return default(Microsoft.Build.Framework.ITaskItem); } set { } }
    public Microsoft.Build.Framework.ITaskItem[] Dependencies { get { return default(Microsoft.Build.Framework.ITaskItem[]); } set { } }
    public Microsoft.Build.Framework.ITaskItem[] Files { get { return default(Microsoft.Build.Framework.ITaskItem[]); } set { } }
    public Microsoft.Build.Framework.ITaskItem IconFile { get { return default(Microsoft.Build.Framework.ITaskItem); } set { } }
    public Microsoft.Build.Framework.ITaskItem[] IsolatedComReferences { get { return default(Microsoft.Build.Framework.ITaskItem[]); } set { } }
    public string ManifestType { get { return default(string); } set { } }
    public string OSVersion { get { return default(string); } set { } }
    public Microsoft.Build.Framework.ITaskItem TrustInfoFile { get { return default(Microsoft.Build.Framework.ITaskItem); } set { } }
    [System.MonoTODOAttribute]
    protected override System.Type GetObjectType() { return default(System.Type); }
    [System.MonoTODOAttribute]
    protected override bool OnManifestLoaded(Microsoft.Build.Tasks.Deployment.ManifestUtilities.Manifest manifest) { return default(bool); }
    [System.MonoTODOAttribute]
    protected override bool OnManifestResolved(Microsoft.Build.Tasks.Deployment.ManifestUtilities.Manifest manifest) { return default(bool); }
    [System.MonoTODOAttribute]
    protected internal override bool ValidateInputs() { return default(bool); }
  }
  public sealed partial class GenerateBootstrapper : Microsoft.Build.Tasks.TaskExtension {
    public GenerateBootstrapper() { }
    public string ApplicationFile { get { return default(string); } set { } }
    public string ApplicationName { get { return default(string); } set { } }
    public string ApplicationUrl { get { return default(string); } set { } }
    [Microsoft.Build.Framework.OutputAttribute]
    public System.String[] BootstrapperComponentFiles { get { return default(System.String[]); } set { } }
    public Microsoft.Build.Framework.ITaskItem[] BootstrapperItems { get { return default(Microsoft.Build.Framework.ITaskItem[]); } set { } }
    [Microsoft.Build.Framework.OutputAttribute]
    public string BootstrapperKeyFile { get { return default(string); } set { } }
    public string ComponentsLocation { get { return default(string); } set { } }
    public string ComponentsUrl { get { return default(string); } set { } }
    public bool CopyComponents { get { return default(bool); } set { } }
    public string Culture { get { return default(string); } set { } }
    public string FallbackCulture { get { return default(string); } set { } }
    public string OutputPath { get { return default(string); } set { } }
    public string Path { get { return default(string); } set { } }
    public string SupportUrl { get { return default(string); } set { } }
    public bool Validate { get { return default(bool); } set { } }
    public override bool Execute() { return default(bool); }
  }
  public sealed partial class GenerateDeploymentManifest : Microsoft.Build.Tasks.GenerateManifestBase {
    [System.MonoTODOAttribute]
    public GenerateDeploymentManifest() { }
    [System.MonoTODOAttribute]
    public string DeploymentUrl { get { return default(string); } set { } }
    [System.MonoTODOAttribute]
    public bool DisallowUrlActivation { get { return default(bool); } set { } }
    [System.MonoTODOAttribute]
    public bool Install { get { return default(bool); } set { } }
    [System.MonoTODOAttribute]
    public bool MapFileExtensions { get { return default(bool); } set { } }
    [System.MonoTODOAttribute]
    public string MinimumRequiredVersion { get { return default(string); } set { } }
    [System.MonoTODOAttribute]
    public string Product { get { return default(string); } set { } }
    [System.MonoTODOAttribute]
    public string Publisher { get { return default(string); } set { } }
    [System.MonoTODOAttribute]
    public string SupportUrl { get { return default(string); } set { } }
    [System.MonoTODOAttribute]
    public bool TrustUrlParameters { get { return default(bool); } set { } }
    [System.MonoTODOAttribute]
    public bool UpdateEnabled { get { return default(bool); } set { } }
    [System.MonoTODOAttribute]
    public int UpdateInterval { get { return default(int); } set { } }
    [System.MonoTODOAttribute]
    public string UpdateMode { get { return default(string); } set { } }
    [System.MonoTODOAttribute]
    public string UpdateUnit { get { return default(string); } set { } }
    protected override System.Type GetObjectType() { return default(System.Type); }
    protected override bool OnManifestLoaded(Microsoft.Build.Tasks.Deployment.ManifestUtilities.Manifest manifest) { return default(bool); }
    protected override bool OnManifestResolved(Microsoft.Build.Tasks.Deployment.ManifestUtilities.Manifest manifest) { return default(bool); }
    protected internal override bool ValidateInputs() { return default(bool); }
  }
  public abstract partial class GenerateManifestBase : Microsoft.Build.Utilities.Task {
    protected GenerateManifestBase() { }
    public string AssemblyName { get { return default(string); } set { } }
    public string AssemblyVersion { get { return default(string); } set { } }
    public string Description { get { return default(string); } set { } }
    public Microsoft.Build.Framework.ITaskItem EntryPoint { get { return default(Microsoft.Build.Framework.ITaskItem); } set { } }
    public Microsoft.Build.Framework.ITaskItem InputManifest { get { return default(Microsoft.Build.Framework.ITaskItem); } set { } }
    public int MaxTargetPath { get { return default(int); } set { } }
    [Microsoft.Build.Framework.OutputAttribute]
    public Microsoft.Build.Framework.ITaskItem OutputManifest { get { return default(Microsoft.Build.Framework.ITaskItem); } set { } }
    public string Platform { get { return default(string); } set { } }
    public string TargetCulture { get { return default(string); } set { } }
    [System.MonoTODOAttribute]
    protected internal Microsoft.Build.Tasks.Deployment.ManifestUtilities.AssemblyReference AddAssemblyFromItem(Microsoft.Build.Framework.ITaskItem item) { return default(Microsoft.Build.Tasks.Deployment.ManifestUtilities.AssemblyReference); }
    [System.MonoTODOAttribute]
    protected internal Microsoft.Build.Tasks.Deployment.ManifestUtilities.AssemblyReference AddAssemblyNameFromItem(Microsoft.Build.Framework.ITaskItem item, Microsoft.Build.Tasks.Deployment.ManifestUtilities.AssemblyReferenceType referenceType) { return default(Microsoft.Build.Tasks.Deployment.ManifestUtilities.AssemblyReference); }
    [System.MonoTODOAttribute]
    protected internal Microsoft.Build.Tasks.Deployment.ManifestUtilities.AssemblyReference AddEntryPointFromItem(Microsoft.Build.Framework.ITaskItem item, Microsoft.Build.Tasks.Deployment.ManifestUtilities.AssemblyReferenceType referenceType) { return default(Microsoft.Build.Tasks.Deployment.ManifestUtilities.AssemblyReference); }
    [System.MonoTODOAttribute]
    protected internal Microsoft.Build.Tasks.Deployment.ManifestUtilities.FileReference AddFileFromItem(Microsoft.Build.Framework.ITaskItem item) { return default(Microsoft.Build.Tasks.Deployment.ManifestUtilities.FileReference); }
    [System.MonoTODOAttribute]
    public override bool Execute() { return default(bool); }
    [System.MonoTODOAttribute]
    protected internal Microsoft.Build.Tasks.Deployment.ManifestUtilities.FileReference FindFileFromItem(Microsoft.Build.Framework.ITaskItem item) { return default(Microsoft.Build.Tasks.Deployment.ManifestUtilities.FileReference); }
    [System.MonoTODOAttribute]
    protected abstract System.Type GetObjectType();
    [System.MonoTODOAttribute]
    protected abstract bool OnManifestLoaded(Microsoft.Build.Tasks.Deployment.ManifestUtilities.Manifest manifest);
    [System.MonoTODOAttribute]
    protected abstract bool OnManifestResolved(Microsoft.Build.Tasks.Deployment.ManifestUtilities.Manifest manifest);
    [System.MonoTODOAttribute]
    protected internal virtual bool ValidateInputs() { return default(bool); }
    [System.MonoTODOAttribute]
    protected internal virtual bool ValidateOutput() { return default(bool); }
  }
  public sealed partial class GenerateResource : Microsoft.Build.Tasks.TaskExtension {
    public GenerateResource() { }
    [Microsoft.Build.Framework.OutputAttribute]
    public Microsoft.Build.Framework.ITaskItem[] FilesWritten { get { return default(Microsoft.Build.Framework.ITaskItem[]); } }
    [System.MonoTODOAttribute]
    public bool NeverLockTypeAssemblies { get { return default(bool); } set { } }
    [Microsoft.Build.Framework.OutputAttribute]
    public Microsoft.Build.Framework.ITaskItem[] OutputResources { get { return default(Microsoft.Build.Framework.ITaskItem[]); } set { } }
    public bool PublicClass { get { return default(bool); } set { } }
    public Microsoft.Build.Framework.ITaskItem[] References { get { return default(Microsoft.Build.Framework.ITaskItem[]); } set { } }
    [Microsoft.Build.Framework.RequiredAttribute]
    public Microsoft.Build.Framework.ITaskItem[] Sources { get { return default(Microsoft.Build.Framework.ITaskItem[]); } set { } }
    public Microsoft.Build.Framework.ITaskItem StateFile { get { return default(Microsoft.Build.Framework.ITaskItem); } set { } }
    [Microsoft.Build.Framework.OutputAttribute]
    public string StronglyTypedClassName { get { return default(string); } set { } }
    [Microsoft.Build.Framework.OutputAttribute]
    public string StronglyTypedFileName { get { return default(string); } set { } }
    public string StronglyTypedLanguage { get { return default(string); } set { } }
    public string StronglyTypedNamespace { get { return default(string); } set { } }
    public bool UseSourcePath { get { return default(bool); } set { } }
    public override bool Execute() { return default(bool); }
  }
  public sealed partial class GenerateTrustInfo : Microsoft.Build.Tasks.TaskExtension {
    public GenerateTrustInfo() { }
    public Microsoft.Build.Framework.ITaskItem BaseManifest { get { return default(Microsoft.Build.Framework.ITaskItem); } set { } }
    public string ExcludedPermissions { get { return default(string); } set { } }
    public string TargetZone { get { return default(string); } set { } }
    [Microsoft.Build.Framework.OutputAttribute]
    [Microsoft.Build.Framework.RequiredAttribute]
    public Microsoft.Build.Framework.ITaskItem TrustInfoFile { get { return default(Microsoft.Build.Framework.ITaskItem); } set { } }
    public override bool Execute() { return default(bool); }
  }
  public partial class GetAssemblyIdentity : Microsoft.Build.Tasks.TaskExtension {
    public GetAssemblyIdentity() { }
    [Microsoft.Build.Framework.OutputAttribute]
    public Microsoft.Build.Framework.ITaskItem[] Assemblies { get { return default(Microsoft.Build.Framework.ITaskItem[]); } set { } }
    [Microsoft.Build.Framework.RequiredAttribute]
    public Microsoft.Build.Framework.ITaskItem[] AssemblyFiles { get { return default(Microsoft.Build.Framework.ITaskItem[]); } set { } }
    [System.MonoTODOAttribute("Error handling")]
    public override bool Execute() { return default(bool); }
  }
  public partial class GetFrameworkPath : Microsoft.Build.Tasks.TaskExtension {
    public GetFrameworkPath() { }
    [Microsoft.Build.Framework.OutputAttribute]
    public string FrameworkVersion11Path { get { return default(string); } }
    [Microsoft.Build.Framework.OutputAttribute]
    public string FrameworkVersion20Path { get { return default(string); } }
    [Microsoft.Build.Framework.OutputAttribute]
    public string FrameworkVersion30Path { get { return default(string); } }
    [Microsoft.Build.Framework.OutputAttribute]
    public string FrameworkVersion35Path { get { return default(string); } }
    [Microsoft.Build.Framework.OutputAttribute]
    public string FrameworkVersion40Path { get { return default(string); } }
    [Microsoft.Build.Framework.OutputAttribute]
    public string Path { get { return default(string); } set { } }
    public override bool Execute() { return default(bool); }
  }
  public partial class GetFrameworkSdkPath : Microsoft.Build.Tasks.TaskExtension {
    public GetFrameworkSdkPath() { }
    [Microsoft.Build.Framework.OutputAttribute]
    public string Path { get { return default(string); } set { } }
    public override bool Execute() { return default(bool); }
  }
  public partial class GetReferenceAssemblyPaths : Microsoft.Build.Tasks.TaskExtension {
    public GetReferenceAssemblyPaths() { }
    public bool BypassFrameworkInstallChecks { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [Microsoft.Build.Framework.OutputAttribute]
    public System.String[] FullFrameworkReferenceAssemblyPaths { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.String[]); } }
    [Microsoft.Build.Framework.OutputAttribute]
    public System.String[] ReferenceAssemblyPaths { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.String[]); } }
    public string RootPath { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public string TargetFrameworkMoniker { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [Microsoft.Build.Framework.OutputAttribute]
    public string TargetFrameworkMonikerDisplayName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public override bool Execute() { return default(bool); }
  }
  public partial class LC : Microsoft.Build.Tasks.ToolTaskExtension {
    public LC() { }
    [Microsoft.Build.Framework.RequiredAttribute]
    public Microsoft.Build.Framework.ITaskItem LicenseTarget { get { return default(Microsoft.Build.Framework.ITaskItem); } set { } }
    public bool NoLogo { get { return default(bool); } set { } }
    public string OutputDirectory { get { return default(string); } set { } }
    [Microsoft.Build.Framework.OutputAttribute]
    public Microsoft.Build.Framework.ITaskItem OutputLicense { get { return default(Microsoft.Build.Framework.ITaskItem); } set { } }
    public Microsoft.Build.Framework.ITaskItem[] ReferencedAssemblies { get { return default(Microsoft.Build.Framework.ITaskItem[]); } set { } }
    [Microsoft.Build.Framework.RequiredAttribute]
    public Microsoft.Build.Framework.ITaskItem[] Sources { get { return default(Microsoft.Build.Framework.ITaskItem[]); } set { } }
    protected override string ToolName { get { return default(string); } }
    protected internal override void AddCommandLineCommands(Microsoft.Build.Tasks.CommandLineBuilderExtension commandLine) { }
    protected override string GenerateFullPathToTool() { return default(string); }
    protected override bool ValidateParameters() { return default(bool); }
  }
  public partial class MakeDir : Microsoft.Build.Tasks.TaskExtension {
    public MakeDir() { }
    [Microsoft.Build.Framework.RequiredAttribute]
    public Microsoft.Build.Framework.ITaskItem[] Directories { get { return default(Microsoft.Build.Framework.ITaskItem[]); } set { } }
    [Microsoft.Build.Framework.OutputAttribute]
    public Microsoft.Build.Framework.ITaskItem[] DirectoriesCreated { get { return default(Microsoft.Build.Framework.ITaskItem[]); } }
    public override bool Execute() { return default(bool); }
  }
  public abstract partial class ManagedCompiler : Microsoft.Build.Tasks.ToolTaskExtension {
    protected ManagedCompiler() { }
    public System.String[] AdditionalLibPaths { get { return default(System.String[]); } set { } }
    public System.String[] AddModules { get { return default(System.String[]); } set { } }
    public int CodePage { get { return default(int); } set { } }
    public string DebugType { get { return default(string); } set { } }
    public string DefineConstants { get { return default(string); } set { } }
    public bool DelaySign { get { return default(bool); } set { } }
    public bool EmitDebugInformation { get { return default(bool); } set { } }
    public int FileAlignment { get { return default(int); } set { } }
    protected bool HostCompilerSupportsAllParameters { get { return default(bool); } set { } }
    public string KeyContainer { get { return default(string); } set { } }
    public string KeyFile { get { return default(string); } set { } }
    public Microsoft.Build.Framework.ITaskItem[] LinkResources { get { return default(Microsoft.Build.Framework.ITaskItem[]); } set { } }
    public string MainEntryPoint { get { return default(string); } set { } }
    public bool NoConfig { get { return default(bool); } set { } }
    public bool NoLogo { get { return default(bool); } set { } }
    public bool Optimize { get { return default(bool); } set { } }
    [Microsoft.Build.Framework.OutputAttribute]
    public Microsoft.Build.Framework.ITaskItem OutputAssembly { get { return default(Microsoft.Build.Framework.ITaskItem); } set { } }
    public Microsoft.Build.Framework.ITaskItem[] References { get { return default(Microsoft.Build.Framework.ITaskItem[]); } set { } }
    public Microsoft.Build.Framework.ITaskItem[] Resources { get { return default(Microsoft.Build.Framework.ITaskItem[]); } set { } }
    public Microsoft.Build.Framework.ITaskItem[] ResponseFiles { get { return default(Microsoft.Build.Framework.ITaskItem[]); } set { } }
    public Microsoft.Build.Framework.ITaskItem[] Sources { get { return default(Microsoft.Build.Framework.ITaskItem[]); } set { } }
    protected override System.Text.Encoding StandardOutputEncoding { get { return default(System.Text.Encoding); } }
    public string TargetType { get { return default(string); } set { } }
    public bool TreatWarningsAsErrors { get { return default(bool); } set { } }
    public bool Utf8Output { get { return default(bool); } set { } }
    public string Win32Icon { get { return default(string); } set { } }
    public string Win32Resource { get { return default(string); } set { } }
    [System.MonoTODOAttribute]
    protected internal override void AddCommandLineCommands(Microsoft.Build.Tasks.CommandLineBuilderExtension commandLine) { }
    [System.MonoTODOAttribute]
    protected internal override void AddResponseFileCommands(Microsoft.Build.Tasks.CommandLineBuilderExtension commandLine) { }
    [System.MonoTODOAttribute]
    protected bool CheckAllReferencesExistOnDisk() { return default(bool); }
    [System.MonoTODOAttribute]
    protected void CheckHostObjectSupport(string parameterName, bool resultFromHostObjectSetOperation) { }
    [System.MonoTODOAttribute]
    protected override bool HandleTaskExecutionErrors() { return default(bool); }
    [System.MonoTODOAttribute]
    protected bool ListHasNoDuplicateItems(Microsoft.Build.Framework.ITaskItem[] itemList, string parameterName) { return default(bool); }
    protected internal virtual bool UseAlternateCommandLineToolToExecute() { return default(bool); }
    [System.MonoTODOAttribute]
    protected override bool ValidateParameters() { return default(bool); }
  }
  public sealed partial class Message : Microsoft.Build.Tasks.TaskExtension {
    public Message() { }
    public string Importance { get { return default(string); } set { } }
    public string Text { get { return default(string); } set { } }
    public override bool Execute() { return default(bool); }
  }
  [System.MonoTODOAttribute]
  public partial class MSBuild : Microsoft.Build.Tasks.TaskExtension {
    public MSBuild() { }
    public bool BuildInParallel { get { return default(bool); } set { } }
    [Microsoft.Build.Framework.RequiredAttribute]
    public Microsoft.Build.Framework.ITaskItem[] Projects { get { return default(Microsoft.Build.Framework.ITaskItem[]); } set { } }
    [System.MonoTODOAttribute]
    public System.String[] Properties { get { return default(System.String[]); } set { } }
    public bool RebaseOutputs { get { return default(bool); } set { } }
    [System.MonoTODOAttribute]
    public bool RunEachTargetSeparately { get { return default(bool); } set { } }
    public bool StopOnFirstFailure { get { return default(bool); } set { } }
    [Microsoft.Build.Framework.OutputAttribute]
    public Microsoft.Build.Framework.ITaskItem[] TargetOutputs { get { return default(Microsoft.Build.Framework.ITaskItem[]); } }
    public System.String[] Targets { get { return default(System.String[]); } set { } }
    public string ToolsVersion { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public override bool Execute() { return default(bool); }
  }
  public partial class ReadLinesFromFile : Microsoft.Build.Tasks.TaskExtension {
    public ReadLinesFromFile() { }
    [Microsoft.Build.Framework.RequiredAttribute]
    public Microsoft.Build.Framework.ITaskItem File { get { return default(Microsoft.Build.Framework.ITaskItem); } set { } }
    [Microsoft.Build.Framework.OutputAttribute]
    public Microsoft.Build.Framework.ITaskItem[] Lines { get { return default(Microsoft.Build.Framework.ITaskItem[]); } set { } }
    public override bool Execute() { return default(bool); }
  }
  public partial class RegisterAssembly : Microsoft.Build.Tasks.AppDomainIsolatedTaskExtension, System.Runtime.InteropServices.ITypeLibExporterNotifySink {
    public RegisterAssembly() { }
    [Microsoft.Build.Framework.RequiredAttribute]
    public Microsoft.Build.Framework.ITaskItem[] Assemblies { get { return default(Microsoft.Build.Framework.ITaskItem[]); } set { } }
    public Microsoft.Build.Framework.ITaskItem AssemblyListFile { get { return default(Microsoft.Build.Framework.ITaskItem); } set { } }
    public bool CreateCodeBase { get { return default(bool); } set { } }
    [Microsoft.Build.Framework.OutputAttribute]
    public Microsoft.Build.Framework.ITaskItem[] TypeLibFiles { get { return default(Microsoft.Build.Framework.ITaskItem[]); } set { } }
    public override bool Execute() { return default(bool); }
    public void ReportEvent(System.Runtime.InteropServices.ExporterEventKind kind, int code, string msg) { }
    public object ResolveRef(System.Reflection.Assembly assemblyToResolve) { return default(object); }
  }
  public partial class RemoveDir : Microsoft.Build.Tasks.TaskExtension {
    public RemoveDir() { }
    [Microsoft.Build.Framework.RequiredAttribute]
    public Microsoft.Build.Framework.ITaskItem[] Directories { get { return default(Microsoft.Build.Framework.ITaskItem[]); } set { } }
    [Microsoft.Build.Framework.OutputAttribute]
    public Microsoft.Build.Framework.ITaskItem[] RemovedDirectories { get { return default(Microsoft.Build.Framework.ITaskItem[]); } set { } }
    public override bool Execute() { return default(bool); }
  }
  public partial class RemoveDuplicates : Microsoft.Build.Tasks.TaskExtension {
    public RemoveDuplicates() { }
    [Microsoft.Build.Framework.OutputAttribute]
    public Microsoft.Build.Framework.ITaskItem[] Filtered { get { return default(Microsoft.Build.Framework.ITaskItem[]); } set { } }
    public Microsoft.Build.Framework.ITaskItem[] Inputs { get { return default(Microsoft.Build.Framework.ITaskItem[]); } set { } }
    [System.MonoTODOAttribute]
    public override bool Execute() { return default(bool); }
  }
  public partial class ResolveAssemblyReference : Microsoft.Build.Tasks.TaskExtension {
    public ResolveAssemblyReference() { }
    public System.String[] AllowedAssemblyExtensions { get { return default(System.String[]); } set { } }
    public System.String[] AllowedRelatedFileExtensions { get { return default(System.String[]); } set { } }
    public string AppConfigFile { get { return default(string); } set { } }
    public Microsoft.Build.Framework.ITaskItem[] Assemblies { get { return default(Microsoft.Build.Framework.ITaskItem[]); } set { } }
    public Microsoft.Build.Framework.ITaskItem[] AssemblyFiles { get { return default(Microsoft.Build.Framework.ITaskItem[]); } set { } }
    public bool AutoUnify { get { return default(bool); } set { } }
    public System.String[] CandidateAssemblyFiles { get { return default(System.String[]); } set { } }
    [Microsoft.Build.Framework.OutputAttribute]
    public Microsoft.Build.Framework.ITaskItem[] CopyLocalFiles { get { return default(Microsoft.Build.Framework.ITaskItem[]); } }
    [Microsoft.Build.Framework.OutputAttribute]
    public Microsoft.Build.Framework.ITaskItem[] FilesWritten { get { return default(Microsoft.Build.Framework.ITaskItem[]); } set { } }
    public bool FindDependencies { get { return default(bool); } set { } }
    public bool FindRelatedFiles { get { return default(bool); } set { } }
    public bool FindSatellites { get { return default(bool); } set { } }
    public bool FindSerializationAssemblies { get { return default(bool); } set { } }
    public Microsoft.Build.Framework.ITaskItem[] InstalledAssemblyTables { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(Microsoft.Build.Framework.ITaskItem[]); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [Microsoft.Build.Framework.OutputAttribute]
    public Microsoft.Build.Framework.ITaskItem[] RelatedFiles { get { return default(Microsoft.Build.Framework.ITaskItem[]); } }
    [Microsoft.Build.Framework.OutputAttribute]
    public Microsoft.Build.Framework.ITaskItem[] ResolvedDependencyFiles { get { return default(Microsoft.Build.Framework.ITaskItem[]); } }
    [Microsoft.Build.Framework.OutputAttribute]
    public Microsoft.Build.Framework.ITaskItem[] ResolvedFiles { get { return default(Microsoft.Build.Framework.ITaskItem[]); } }
    [Microsoft.Build.Framework.OutputAttribute]
    public Microsoft.Build.Framework.ITaskItem[] SatelliteFiles { get { return default(Microsoft.Build.Framework.ITaskItem[]); } }
    [Microsoft.Build.Framework.OutputAttribute]
    public Microsoft.Build.Framework.ITaskItem[] ScatterFiles { get { return default(Microsoft.Build.Framework.ITaskItem[]); } }
    [Microsoft.Build.Framework.RequiredAttribute]
    public System.String[] SearchPaths { get { return default(System.String[]); } set { } }
    [Microsoft.Build.Framework.OutputAttribute]
    public Microsoft.Build.Framework.ITaskItem[] SerializationAssemblyFiles { get { return default(Microsoft.Build.Framework.ITaskItem[]); } }
    public bool Silent { get { return default(bool); } set { } }
    public string StateFile { get { return default(string); } set { } }
    [Microsoft.Build.Framework.OutputAttribute]
    public Microsoft.Build.Framework.ITaskItem[] SuggestedRedirects { get { return default(Microsoft.Build.Framework.ITaskItem[]); } }
    public System.String[] TargetFrameworkDirectories { get { return default(System.String[]); } set { } }
    public string TargetFrameworkMoniker { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public string TargetFrameworkMonikerDisplayName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public string TargetFrameworkVersion { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public string TargetProcessorArchitecture { get { return default(string); } set { } }
    public override bool Execute() { return default(bool); }
  }
  public sealed partial class ResolveManifestFiles : Microsoft.Build.Tasks.TaskExtension {
    public ResolveManifestFiles() { }
    public Microsoft.Build.Framework.ITaskItem EntryPoint { get { return default(Microsoft.Build.Framework.ITaskItem); } set { } }
    public Microsoft.Build.Framework.ITaskItem[] ExtraFiles { get { return default(Microsoft.Build.Framework.ITaskItem[]); } set { } }
    public Microsoft.Build.Framework.ITaskItem[] Files { get { return default(Microsoft.Build.Framework.ITaskItem[]); } set { } }
    public Microsoft.Build.Framework.ITaskItem[] ManagedAssemblies { get { return default(Microsoft.Build.Framework.ITaskItem[]); } set { } }
    public Microsoft.Build.Framework.ITaskItem[] NativeAssemblies { get { return default(Microsoft.Build.Framework.ITaskItem[]); } set { } }
    public Microsoft.Build.Framework.ITaskItem[] OutputAssemblies { get { return default(Microsoft.Build.Framework.ITaskItem[]); } set { } }
    public Microsoft.Build.Framework.ITaskItem[] OutputFiles { get { return default(Microsoft.Build.Framework.ITaskItem[]); } set { } }
    public Microsoft.Build.Framework.ITaskItem[] PublishFiles { get { return default(Microsoft.Build.Framework.ITaskItem[]); } set { } }
    public Microsoft.Build.Framework.ITaskItem[] SatelliteAssemblies { get { return default(Microsoft.Build.Framework.ITaskItem[]); } set { } }
    public string TargetCulture { get { return default(string); } set { } }
    [System.MonoTODOAttribute]
    public override bool Execute() { return default(bool); }
  }
  public abstract partial class ResolveProjectBase : Microsoft.Build.Tasks.TaskExtension {
    [System.MonoTODOAttribute]
    protected ResolveProjectBase() { }
    [Microsoft.Build.Framework.RequiredAttribute]
    public Microsoft.Build.Framework.ITaskItem[] ProjectReferences { get { return default(Microsoft.Build.Framework.ITaskItem[]); } set { } }
    [System.MonoTODOAttribute]
    protected string GetProjectItem(Microsoft.Build.Framework.ITaskItem projectRef) { return default(string); }
  }
  public partial class SGen : Microsoft.Build.Tasks.ToolTaskExtension {
    public SGen() { }
    [Microsoft.Build.Framework.RequiredAttribute]
    [System.MonoTODOAttribute]
    public string BuildAssemblyName { get { return default(string); } set { } }
    [Microsoft.Build.Framework.RequiredAttribute]
    [System.MonoTODOAttribute]
    public string BuildAssemblyPath { get { return default(string); } set { } }
    [System.MonoTODOAttribute]
    public bool DelaySign { get { return default(bool); } set { } }
    [System.MonoTODOAttribute]
    public string KeyContainer { get { return default(string); } set { } }
    [System.MonoTODOAttribute]
    public string KeyFile { get { return default(string); } set { } }
    [System.MonoTODOAttribute]
    public System.String[] References { get { return default(System.String[]); } set { } }
    [Microsoft.Build.Framework.OutputAttribute]
    [System.MonoTODOAttribute]
    public Microsoft.Build.Framework.ITaskItem[] SerializationAssembly { get { return default(Microsoft.Build.Framework.ITaskItem[]); } set { } }
    [System.MonoTODOAttribute]
    public string SerializationAssemblyName { get { return default(string); } }
    [Microsoft.Build.Framework.RequiredAttribute]
    [System.MonoTODOAttribute]
    public bool ShouldGenerateSerializer { get { return default(bool); } set { } }
    [System.MonoTODOAttribute]
    protected override string ToolName { get { return default(string); } }
    [Microsoft.Build.Framework.RequiredAttribute]
    [System.MonoTODOAttribute]
    public bool UseProxyTypes { get { return default(bool); } set { } }
    [System.MonoTODOAttribute]
    protected override string GenerateCommandLineCommands() { return default(string); }
    [System.MonoTODOAttribute]
    protected override string GenerateFullPathToTool() { return default(string); }
    [System.MonoTODOAttribute]
    protected override bool SkipTaskExecution() { return default(bool); }
    [System.MonoTODOAttribute]
    protected override bool ValidateParameters() { return default(bool); }
  }
  public sealed partial class SignFile : Microsoft.Build.Utilities.Task {
    public SignFile() { }
    [Microsoft.Build.Framework.RequiredAttribute]
    public string CertificateThumbprint { get { return default(string); } set { } }
    [Microsoft.Build.Framework.RequiredAttribute]
    public Microsoft.Build.Framework.ITaskItem SigningTarget { get { return default(Microsoft.Build.Framework.ITaskItem); } set { } }
    public string TimestampUrl { get { return default(string); } set { } }
    [System.MonoTODOAttribute]
    public override bool Execute() { return default(bool); }
  }
  public abstract partial class TaskExtension : Microsoft.Build.Utilities.Task {
    internal TaskExtension() { }
    public new Microsoft.Build.Utilities.TaskLoggingHelper Log { get { return default(Microsoft.Build.Utilities.TaskLoggingHelper); } }
  }
  public partial class TaskLoggingHelperExtension : Microsoft.Build.Utilities.TaskLoggingHelper {
    internal TaskLoggingHelperExtension() : base (default(Microsoft.Build.Framework.ITask)) { }
    [System.MonoTODOAttribute]
    public System.Resources.ResourceManager TaskSharedResources { get { return default(System.Resources.ResourceManager); } set { } }
    [System.MonoTODOAttribute]
    public override string FormatResourceString(string resourceName, params System.Object[] args) { return default(string); }
  }
  public abstract partial class ToolTaskExtension : Microsoft.Build.Utilities.ToolTask {
    internal ToolTaskExtension() { }
    protected internal System.Collections.Hashtable Bag { get { return default(System.Collections.Hashtable); } }
    protected override bool HasLoggedErrors { get { return default(bool); } }
    public new Microsoft.Build.Utilities.TaskLoggingHelper Log { get { return default(Microsoft.Build.Utilities.TaskLoggingHelper); } }
    protected internal virtual void AddCommandLineCommands(Microsoft.Build.Tasks.CommandLineBuilderExtension commandLine) { }
    protected internal virtual void AddResponseFileCommands(Microsoft.Build.Tasks.CommandLineBuilderExtension commandLine) { }
    protected override string GenerateCommandLineCommands() { return default(string); }
    protected override string GenerateResponseFileCommands() { return default(string); }
    protected internal bool GetBoolParameterWithDefault(string parameterName, bool defaultValue) { return default(bool); }
    protected internal int GetIntParameterWithDefault(string parameterName, int defaultValue) { return default(int); }
  }
  public partial class Touch : Microsoft.Build.Tasks.TaskExtension {
    public Touch() { }
    public bool AlwaysCreate { get { return default(bool); } set { } }
    [Microsoft.Build.Framework.RequiredAttribute]
    public Microsoft.Build.Framework.ITaskItem[] Files { get { return default(Microsoft.Build.Framework.ITaskItem[]); } set { } }
    public bool ForceTouch { get { return default(bool); } set { } }
    public string Time { get { return default(string); } set { } }
    [Microsoft.Build.Framework.OutputAttribute]
    public Microsoft.Build.Framework.ITaskItem[] TouchedFiles { get { return default(Microsoft.Build.Framework.ITaskItem[]); } set { } }
    public override bool Execute() { return default(bool); }
  }
  public partial class UnregisterAssembly : Microsoft.Build.Tasks.AppDomainIsolatedTaskExtension {
    public UnregisterAssembly() { }
    public Microsoft.Build.Framework.ITaskItem[] Assemblies { get { return default(Microsoft.Build.Framework.ITaskItem[]); } set { } }
    public Microsoft.Build.Framework.ITaskItem AssemblyListFile { get { return default(Microsoft.Build.Framework.ITaskItem); } set { } }
    public Microsoft.Build.Framework.ITaskItem[] TypeLibFiles { get { return default(Microsoft.Build.Framework.ITaskItem[]); } set { } }
    public override bool Execute() { return default(bool); }
  }
  public partial class UpdateManifest : Microsoft.Build.Utilities.Task {
    [System.MonoTODOAttribute]
    public UpdateManifest() { }
    [Microsoft.Build.Framework.RequiredAttribute]
    [System.MonoTODOAttribute]
    public Microsoft.Build.Framework.ITaskItem ApplicationManifest { get { return default(Microsoft.Build.Framework.ITaskItem); } set { } }
    [Microsoft.Build.Framework.RequiredAttribute]
    [System.MonoTODOAttribute]
    public string ApplicationPath { get { return default(string); } set { } }
    [Microsoft.Build.Framework.RequiredAttribute]
    [System.MonoTODOAttribute]
    public Microsoft.Build.Framework.ITaskItem InputManifest { get { return default(Microsoft.Build.Framework.ITaskItem); } set { } }
    [Microsoft.Build.Framework.OutputAttribute]
    [System.MonoTODOAttribute]
    public Microsoft.Build.Framework.ITaskItem OutputManifest { get { return default(Microsoft.Build.Framework.ITaskItem); } set { } }
    [System.MonoTODOAttribute]
    public override bool Execute() { return default(bool); }
  }
  public partial class Vbc : Microsoft.Build.Tasks.ManagedCompiler {
    public Vbc() { }
    [System.MonoTODOAttribute]
    public string BaseAddress { get { return default(string); } set { } }
    [System.MonoTODOAttribute]
    public string DisabledWarnings { get { return default(string); } set { } }
    [System.MonoTODOAttribute]
    public string DocumentationFile { get { return default(string); } set { } }
    [System.MonoTODOAttribute]
    public string ErrorReport { get { return default(string); } set { } }
    [System.MonoTODOAttribute]
    public bool GenerateDocumentation { get { return default(bool); } set { } }
    [System.MonoTODOAttribute]
    public Microsoft.Build.Framework.ITaskItem[] Imports { get { return default(Microsoft.Build.Framework.ITaskItem[]); } set { } }
    [System.MonoTODOAttribute]
    public bool NoStandardLib { get { return default(bool); } set { } }
    [System.MonoTODOAttribute]
    public bool NoWarnings { get { return default(bool); } set { } }
    [System.MonoTODOAttribute]
    public string OptionCompare { get { return default(string); } set { } }
    [System.MonoTODOAttribute]
    public bool OptionExplicit { get { return default(bool); } set { } }
    [System.MonoTODOAttribute]
    public bool OptionStrict { get { return default(bool); } set { } }
    [System.MonoTODOAttribute]
    public string OptionStrictType { get { return default(string); } set { } }
    [System.MonoTODOAttribute]
    public string Platform { get { return default(string); } set { } }
    [System.MonoTODOAttribute]
    public bool RemoveIntegerChecks { get { return default(bool); } set { } }
    [System.MonoTODOAttribute]
    public string RootNamespace { get { return default(string); } set { } }
    [System.MonoTODOAttribute]
    public string SdkPath { get { return default(string); } set { } }
    [System.MonoTODOAttribute]
    public bool TargetCompactFramework { get { return default(bool); } set { } }
    [System.MonoTODOAttribute]
    protected override string ToolName { get { return default(string); } }
    [System.MonoTODOAttribute]
    public bool UseHostCompilerIfAvailable { get { return default(bool); } set { } }
    [System.MonoTODOAttribute]
    public string Verbosity { get { return default(string); } set { } }
    [System.MonoTODOAttribute]
    public string WarningsAsErrors { get { return default(string); } set { } }
    [System.MonoTODOAttribute]
    public string WarningsNotAsErrors { get { return default(string); } set { } }
    [System.MonoTODOAttribute]
    protected internal override void AddResponseFileCommands(Microsoft.Build.Tasks.CommandLineBuilderExtension commandLine) { }
    [System.MonoTODOAttribute]
    protected override bool CallHostObjectToExecute() { return default(bool); }
    [System.MonoTODOAttribute]
    protected override string GenerateFullPathToTool() { return default(string); }
    [System.MonoTODOAttribute]
    protected override Microsoft.Build.Utilities.HostObjectInitializationStatus InitializeHostObject() { return default(Microsoft.Build.Utilities.HostObjectInitializationStatus); }
    protected override void LogEventsFromTextOutput(string singleLine, Microsoft.Build.Framework.MessageImportance messageImportance) { }
    [System.MonoTODOAttribute]
    protected override bool ValidateParameters() { return default(bool); }
  }
  public sealed partial class Warning : Microsoft.Build.Tasks.TaskExtension {
    public Warning() { }
    public string Code { get { return default(string); } set { } }
    public string File { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public string HelpKeyword { get { return default(string); } set { } }
    public string Text { get { return default(string); } set { } }
    public override bool Execute() { return default(bool); }
  }
  public partial class WriteCodeFragment : Microsoft.Build.Tasks.TaskExtension {
    public WriteCodeFragment() { }
    public Microsoft.Build.Framework.ITaskItem[] AssemblyAttributes { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(Microsoft.Build.Framework.ITaskItem[]); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [Microsoft.Build.Framework.RequiredAttribute]
    public string Language { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public Microsoft.Build.Framework.ITaskItem OutputDirectory { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(Microsoft.Build.Framework.ITaskItem); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [Microsoft.Build.Framework.OutputAttribute]
    public Microsoft.Build.Framework.ITaskItem OutputFile { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(Microsoft.Build.Framework.ITaskItem); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public override bool Execute() { return default(bool); }
  }
  public partial class WriteLinesToFile : Microsoft.Build.Tasks.TaskExtension {
    public WriteLinesToFile() { }
    [Microsoft.Build.Framework.RequiredAttribute]
    public Microsoft.Build.Framework.ITaskItem File { get { return default(Microsoft.Build.Framework.ITaskItem); } set { } }
    public Microsoft.Build.Framework.ITaskItem[] Lines { get { return default(Microsoft.Build.Framework.ITaskItem[]); } set { } }
    public bool Overwrite { get { return default(bool); } set { } }
    public override bool Execute() { return default(bool); }
  }
}
namespace Microsoft.Build.Tasks.Deployment.Bootstrapper {
  [System.Runtime.InteropServices.ClassInterfaceAttribute((System.Runtime.InteropServices.ClassInterfaceType)(0))]
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  [System.Runtime.InteropServices.GuidAttribute("1D9FE38A-0226-4b95-9C6B-6DFFA2236270")]
  public partial class BootstrapperBuilder : Microsoft.Build.Tasks.Deployment.Bootstrapper.IBootstrapperBuilder {
    public BootstrapperBuilder() { }
    public string Path { get { return default(string); } set { } }
    public Microsoft.Build.Tasks.Deployment.Bootstrapper.ProductCollection Products { get { return default(Microsoft.Build.Tasks.Deployment.Bootstrapper.ProductCollection); } }
    [System.MonoTODOAttribute]
    public Microsoft.Build.Tasks.Deployment.Bootstrapper.BuildResults Build(Microsoft.Build.Tasks.Deployment.Bootstrapper.BuildSettings settings) { return default(Microsoft.Build.Tasks.Deployment.Bootstrapper.BuildResults); }
    [System.MonoTODOAttribute]
    public System.String[] GetOutputFolders(System.String[] productCodes, string culture, string fallbackCulture, Microsoft.Build.Tasks.Deployment.Bootstrapper.ComponentsLocation componentsLocation) { return default(System.String[]); }
  }
  public partial class BuildMessage : Microsoft.Build.Tasks.Deployment.Bootstrapper.IBuildMessage {
    internal BuildMessage() { }
    public int HelpId { get { return default(int); } }
    public string HelpKeyword { get { return default(string); } }
    public string Message { get { return default(string); } }
    public Microsoft.Build.Tasks.Deployment.Bootstrapper.BuildMessageSeverity Severity { get { return default(Microsoft.Build.Tasks.Deployment.Bootstrapper.BuildMessageSeverity); } }
  }
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  [System.Runtime.InteropServices.GuidAttribute("936D32F9-1A68-4d5e-98EA-044AC9A1AADA")]
  public enum BuildMessageSeverity {
    Error = 2,
    Info = 0,
    Warning = 1,
  }
  [System.Runtime.InteropServices.ClassInterfaceAttribute((System.Runtime.InteropServices.ClassInterfaceType)(0))]
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  [System.Runtime.InteropServices.GuidAttribute("FAD7BA7C-CA00-41e0-A5EF-2DA9A74E58E6")]
  public partial class BuildResults : Microsoft.Build.Tasks.Deployment.Bootstrapper.IBuildResults {
    internal BuildResults() { }
    public System.String[] ComponentFiles { get { return default(System.String[]); } }
    public string KeyFile { get { return default(string); } }
    public Microsoft.Build.Tasks.Deployment.Bootstrapper.BuildMessage[] Messages { get { return default(Microsoft.Build.Tasks.Deployment.Bootstrapper.BuildMessage[]); } }
    public bool Succeeded { get { return default(bool); } }
  }
  [System.Runtime.InteropServices.ClassInterfaceAttribute((System.Runtime.InteropServices.ClassInterfaceType)(0))]
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  [System.Runtime.InteropServices.GuidAttribute("5D13802C-C830-4b41-8E7A-F69D9DD6A095")]
  public partial class BuildSettings : Microsoft.Build.Tasks.Deployment.Bootstrapper.IBuildSettings {
    public BuildSettings() { }
    public string ApplicationFile { get { return default(string); } set { } }
    public string ApplicationName { get { return default(string); } set { } }
    public string ApplicationUrl { get { return default(string); } set { } }
    public Microsoft.Build.Tasks.Deployment.Bootstrapper.ComponentsLocation ComponentsLocation { get { return default(Microsoft.Build.Tasks.Deployment.Bootstrapper.ComponentsLocation); } set { } }
    public string ComponentsUrl { get { return default(string); } set { } }
    public bool CopyComponents { get { return default(bool); } set { } }
    public int FallbackLCID { get { return default(int); } set { } }
    public int LCID { get { return default(int); } set { } }
    public string OutputPath { get { return default(string); } set { } }
    public Microsoft.Build.Tasks.Deployment.Bootstrapper.ProductBuilderCollection ProductBuilders { get { return default(Microsoft.Build.Tasks.Deployment.Bootstrapper.ProductBuilderCollection); } }
    public string SupportUrl { get { return default(string); } set { } }
    public bool Validate { get { return default(bool); } set { } }
  }
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  [System.Runtime.InteropServices.GuidAttribute("12F49949-7B60-49CD-B6A0-2B5E4A638AAF")]
  public enum ComponentsLocation {
    Absolute = 2,
    HomeSite = 0,
    Relative = 1,
  }
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  [System.Runtime.InteropServices.GuidAttribute("1D202366-5EEA-4379-9255-6F8CDB8587C9")]
  [System.Runtime.InteropServices.InterfaceTypeAttribute((System.Runtime.InteropServices.ComInterfaceType)(0))]
  public partial interface IBootstrapperBuilder {
    string Path { get; set; }
    Microsoft.Build.Tasks.Deployment.Bootstrapper.ProductCollection Products { get; }
    Microsoft.Build.Tasks.Deployment.Bootstrapper.BuildResults Build(Microsoft.Build.Tasks.Deployment.Bootstrapper.BuildSettings settings);
  }
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  [System.Runtime.InteropServices.GuidAttribute("E3C981EA-99E6-4f48-8955-1AAFDFB5ACE4")]
  [System.Runtime.InteropServices.InterfaceTypeAttribute((System.Runtime.InteropServices.ComInterfaceType)(0))]
  public partial interface IBuildMessage {
    int HelpId { get; }
    string HelpKeyword { get; }
    string Message { get; }
    Microsoft.Build.Tasks.Deployment.Bootstrapper.BuildMessageSeverity Severity { get; }
  }
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  [System.Runtime.InteropServices.GuidAttribute("586B842C-D9C7-43b8-84E4-9CFC3AF9F13B")]
  [System.Runtime.InteropServices.InterfaceTypeAttribute((System.Runtime.InteropServices.ComInterfaceType)(0))]
  public partial interface IBuildResults {
    System.String[] ComponentFiles { get; }
    string KeyFile { get; }
    Microsoft.Build.Tasks.Deployment.Bootstrapper.BuildMessage[] Messages { get; }
    bool Succeeded { get; }
  }
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  [System.Runtime.InteropServices.GuidAttribute("87EEBC69-0948-4ce6-A2DE-819162B87CC6")]
  [System.Runtime.InteropServices.InterfaceTypeAttribute((System.Runtime.InteropServices.ComInterfaceType)(0))]
  public partial interface IBuildSettings {
    string ApplicationFile { get; set; }
    string ApplicationName { get; set; }
    string ApplicationUrl { get; set; }
    Microsoft.Build.Tasks.Deployment.Bootstrapper.ComponentsLocation ComponentsLocation { get; set; }
    string ComponentsUrl { get; set; }
    bool CopyComponents { get; set; }
    int FallbackLCID { get; set; }
    int LCID { get; set; }
    string OutputPath { get; set; }
    Microsoft.Build.Tasks.Deployment.Bootstrapper.ProductBuilderCollection ProductBuilders { get; }
    string SupportUrl { get; set; }
    bool Validate { get; set; }
  }
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  [System.Runtime.InteropServices.GuidAttribute("9E81BE3D-530F-4a10-8349-5D5947BA59AD")]
  [System.Runtime.InteropServices.InterfaceTypeAttribute((System.Runtime.InteropServices.ComInterfaceType)(0))]
  public partial interface IProduct {
    Microsoft.Build.Tasks.Deployment.Bootstrapper.ProductCollection Includes { get; }
    string Name { get; }
    Microsoft.Build.Tasks.Deployment.Bootstrapper.ProductBuilder ProductBuilder { get; }
    string ProductCode { get; }
  }
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  [System.Runtime.InteropServices.GuidAttribute("0777432F-A60D-48b3-83DB-90326FE8C96E")]
  [System.Runtime.InteropServices.InterfaceTypeAttribute((System.Runtime.InteropServices.ComInterfaceType)(0))]
  public partial interface IProductBuilder {
    Microsoft.Build.Tasks.Deployment.Bootstrapper.Product Product { get; }
  }
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  [System.Runtime.InteropServices.GuidAttribute("0D593FC0-E3F1-4dad-A674-7EA4D327F79B")]
  [System.Runtime.InteropServices.InterfaceTypeAttribute((System.Runtime.InteropServices.ComInterfaceType)(0))]
  public partial interface IProductBuilderCollection {
    void Add(Microsoft.Build.Tasks.Deployment.Bootstrapper.ProductBuilder builder);
  }
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  [System.Runtime.InteropServices.GuidAttribute("63F63663-8503-4875-814C-09168E595367")]
  [System.Runtime.InteropServices.InterfaceTypeAttribute((System.Runtime.InteropServices.ComInterfaceType)(0))]
  public partial interface IProductCollection {
    int Count { get; }
    Microsoft.Build.Tasks.Deployment.Bootstrapper.Product Item(int index);
    Microsoft.Build.Tasks.Deployment.Bootstrapper.Product Product(string productCode);
  }
  [System.Runtime.InteropServices.ClassInterfaceAttribute((System.Runtime.InteropServices.ClassInterfaceType)(0))]
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  [System.Runtime.InteropServices.GuidAttribute("532BF563-A85D-4088-8048-41F51AC5239F")]
  public partial class Product : Microsoft.Build.Tasks.Deployment.Bootstrapper.IProduct {
    public Product() { }
    public Microsoft.Build.Tasks.Deployment.Bootstrapper.ProductCollection Includes { get { return default(Microsoft.Build.Tasks.Deployment.Bootstrapper.ProductCollection); } }
    public string Name { get { return default(string); } }
    public Microsoft.Build.Tasks.Deployment.Bootstrapper.ProductBuilder ProductBuilder { get { return default(Microsoft.Build.Tasks.Deployment.Bootstrapper.ProductBuilder); } }
    public string ProductCode { get { return default(string); } }
  }
  public partial class ProductBuilder : Microsoft.Build.Tasks.Deployment.Bootstrapper.IProductBuilder {
    internal ProductBuilder() { }
    public Microsoft.Build.Tasks.Deployment.Bootstrapper.Product Product { get { return default(Microsoft.Build.Tasks.Deployment.Bootstrapper.Product); } }
  }
  [System.Runtime.InteropServices.ClassInterfaceAttribute((System.Runtime.InteropServices.ClassInterfaceType)(0))]
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  [System.Runtime.InteropServices.GuidAttribute("D25C0741-99CA-49f7-9460-95E5F25EEF43")]
  public partial class ProductBuilderCollection : Microsoft.Build.Tasks.Deployment.Bootstrapper.IProductBuilderCollection, System.Collections.IEnumerable {
    internal ProductBuilderCollection() { }
    [System.MonoTODOAttribute]
    public void Add(Microsoft.Build.Tasks.Deployment.Bootstrapper.ProductBuilder builder) { }
    [System.MonoTODOAttribute]
    public System.Collections.IEnumerator GetEnumerator() { return default(System.Collections.IEnumerator); }
  }
  [System.Runtime.InteropServices.ClassInterfaceAttribute((System.Runtime.InteropServices.ClassInterfaceType)(0))]
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  [System.Runtime.InteropServices.GuidAttribute("EFFA164B-3E87-4195-88DB-8AC004DDFE2A")]
  public partial class ProductCollection : Microsoft.Build.Tasks.Deployment.Bootstrapper.IProductCollection, System.Collections.IEnumerable {
    internal ProductCollection() { }
    [System.MonoTODOAttribute]
    public int Count { get { return default(int); } }
    [System.MonoTODOAttribute]
    public System.Collections.IEnumerator GetEnumerator() { return default(System.Collections.IEnumerator); }
    [System.MonoTODOAttribute]
    public Microsoft.Build.Tasks.Deployment.Bootstrapper.Product Item(int index) { return default(Microsoft.Build.Tasks.Deployment.Bootstrapper.Product); }
    [System.MonoTODOAttribute]
    public Microsoft.Build.Tasks.Deployment.Bootstrapper.Product Product(string productCode) { return default(Microsoft.Build.Tasks.Deployment.Bootstrapper.Product); }
  }
}
namespace Microsoft.Build.Tasks.Deployment.ManifestUtilities {
  [System.Runtime.InteropServices.ComVisibleAttribute(false)]
  public sealed partial class ApplicationIdentity {
    public ApplicationIdentity(string url, Microsoft.Build.Tasks.Deployment.ManifestUtilities.AssemblyIdentity deployManifestIdentity, Microsoft.Build.Tasks.Deployment.ManifestUtilities.AssemblyIdentity applicationManifestIdentity) { }
    public ApplicationIdentity(string url, string deployManifestPath, string applicationManifestPath) { }
    public override string ToString() { return default(string); }
  }
  [System.Runtime.InteropServices.ComVisibleAttribute(false)]
  public sealed partial class ApplicationManifest : Microsoft.Build.Tasks.Deployment.ManifestUtilities.AssemblyManifest {
    [System.MonoTODOAttribute]
    public ApplicationManifest() { }
    [System.MonoTODOAttribute]
    public string ConfigFile { get { return default(string); } set { } }
    [System.MonoTODOAttribute]
    public override Microsoft.Build.Tasks.Deployment.ManifestUtilities.AssemblyReference EntryPoint { get { return default(Microsoft.Build.Tasks.Deployment.ManifestUtilities.AssemblyReference); } set { } }
    [System.MonoTODOAttribute]
    public string IconFile { get { return default(string); } set { } }
    [System.MonoTODOAttribute]
    public bool IsClickOnceManifest { get { return default(bool); } set { } }
    [System.MonoTODOAttribute]
    public int MaxTargetPath { get { return default(int); } set { } }
    [System.MonoTODOAttribute]
    public string OSDescription { get { return default(string); } set { } }
    [System.MonoTODOAttribute]
    public string OSSupportUrl { get { return default(string); } set { } }
    [System.MonoTODOAttribute]
    public string OSVersion { get { return default(string); } set { } }
    [System.MonoTODOAttribute]
    public Microsoft.Build.Tasks.Deployment.ManifestUtilities.TrustInfo TrustInfo { get { return default(Microsoft.Build.Tasks.Deployment.ManifestUtilities.TrustInfo); } set { } }
    [System.MonoTODOAttribute]
    public string XmlConfigFile { get { return default(string); } set { } }
    [System.MonoTODOAttribute]
    public Microsoft.Build.Tasks.Deployment.ManifestUtilities.AssemblyIdentity XmlEntryPointIdentity { get { return default(Microsoft.Build.Tasks.Deployment.ManifestUtilities.AssemblyIdentity); } set { } }
    [System.MonoTODOAttribute]
    public string XmlEntryPointParameters { get { return default(string); } set { } }
    [System.MonoTODOAttribute]
    public string XmlEntryPointPath { get { return default(string); } set { } }
    [System.MonoTODOAttribute]
    public string XmlIconFile { get { return default(string); } set { } }
    [System.MonoTODOAttribute]
    public string XmlIsClickOnceManifest { get { return default(string); } set { } }
    [System.MonoTODOAttribute]
    public string XmlOSBuild { get { return default(string); } set { } }
    [System.MonoTODOAttribute]
    public string XmlOSDescription { get { return default(string); } set { } }
    [System.MonoTODOAttribute]
    public string XmlOSMajor { get { return default(string); } set { } }
    [System.MonoTODOAttribute]
    public string XmlOSMinor { get { return default(string); } set { } }
    [System.MonoTODOAttribute]
    public string XmlOSRevision { get { return default(string); } set { } }
    [System.MonoTODOAttribute]
    public string XmlOSSupportUrl { get { return default(string); } set { } }
  }
  [System.Runtime.InteropServices.ComVisibleAttribute(false)]
  public sealed partial class AssemblyIdentity {
    [System.MonoTODOAttribute]
    public AssemblyIdentity() { }
    [System.MonoTODOAttribute]
    public AssemblyIdentity(Microsoft.Build.Tasks.Deployment.ManifestUtilities.AssemblyIdentity identity) { }
    [System.MonoTODOAttribute]
    public AssemblyIdentity(string name) { }
    [System.MonoTODOAttribute]
    public AssemblyIdentity(string name, string version) { }
    [System.MonoTODOAttribute]
    public AssemblyIdentity(string name, string version, string publicKeyToken, string culture) { }
    [System.MonoTODOAttribute]
    public AssemblyIdentity(string name, string version, string publicKeyToken, string culture, string processorArchitecture) { }
    [System.MonoTODOAttribute]
    public AssemblyIdentity(string name, string version, string publicKeyToken, string culture, string processorArchitecture, string type) { }
    [System.MonoTODOAttribute]
    public string Culture { get { return default(string); } set { } }
    [System.MonoTODOAttribute]
    public bool IsFrameworkAssembly { get { return default(bool); } }
    [System.MonoTODOAttribute]
    public bool IsNeutralPlatform { get { return default(bool); } }
    [System.MonoTODOAttribute]
    public bool IsStrongName { get { return default(bool); } }
    [System.MonoTODOAttribute]
    public string Name { get { return default(string); } set { } }
    [System.MonoTODOAttribute]
    public string ProcessorArchitecture { get { return default(string); } set { } }
    [System.MonoTODOAttribute]
    public string PublicKeyToken { get { return default(string); } set { } }
    [System.MonoTODOAttribute]
    public string Type { get { return default(string); } set { } }
    [System.MonoTODOAttribute]
    public string Version { get { return default(string); } set { } }
    [System.MonoTODOAttribute]
    public string XmlCulture { get { return default(string); } set { } }
    [System.MonoTODOAttribute]
    public string XmlName { get { return default(string); } set { } }
    [System.MonoTODOAttribute]
    public string XmlProcessorArchitecture { get { return default(string); } set { } }
    [System.MonoTODOAttribute]
    public string XmlPublicKeyToken { get { return default(string); } set { } }
    [System.MonoTODOAttribute]
    public string XmlType { get { return default(string); } set { } }
    [System.MonoTODOAttribute]
    public string XmlVersion { get { return default(string); } set { } }
    [System.MonoTODOAttribute]
    public static Microsoft.Build.Tasks.Deployment.ManifestUtilities.AssemblyIdentity FromAssemblyName(string assemblyName) { return default(Microsoft.Build.Tasks.Deployment.ManifestUtilities.AssemblyIdentity); }
    [System.MonoTODOAttribute]
    public static Microsoft.Build.Tasks.Deployment.ManifestUtilities.AssemblyIdentity FromFile(string path) { return default(Microsoft.Build.Tasks.Deployment.ManifestUtilities.AssemblyIdentity); }
    [System.MonoTODOAttribute]
    public static Microsoft.Build.Tasks.Deployment.ManifestUtilities.AssemblyIdentity FromManagedAssembly(string path) { return default(Microsoft.Build.Tasks.Deployment.ManifestUtilities.AssemblyIdentity); }
    [System.MonoTODOAttribute]
    public static Microsoft.Build.Tasks.Deployment.ManifestUtilities.AssemblyIdentity FromManifest(string path) { return default(Microsoft.Build.Tasks.Deployment.ManifestUtilities.AssemblyIdentity); }
    [System.MonoTODOAttribute]
    public static Microsoft.Build.Tasks.Deployment.ManifestUtilities.AssemblyIdentity FromNativeAssembly(string path) { return default(Microsoft.Build.Tasks.Deployment.ManifestUtilities.AssemblyIdentity); }
    [System.MonoTODOAttribute]
    public string GetFullName(Microsoft.Build.Tasks.Deployment.ManifestUtilities.AssemblyIdentity.FullNameFlags flags) { return default(string); }
    [System.MonoTODOAttribute]
    public override string ToString() { return default(string); }
    [System.FlagsAttribute]
    public enum FullNameFlags {
      All = 3,
      Default = 0,
      ProcessorArchitecture = 1,
      Type = 2,
    }
  }
  [System.Runtime.InteropServices.ComVisibleAttribute(false)]
  public partial class AssemblyManifest : Microsoft.Build.Tasks.Deployment.ManifestUtilities.Manifest {
    [System.MonoTODOAttribute]
    public AssemblyManifest() { }
    public Microsoft.Build.Tasks.Deployment.ManifestUtilities.ProxyStub[] ExternalProxyStubs { get { return default(Microsoft.Build.Tasks.Deployment.ManifestUtilities.ProxyStub[]); } }
    public Microsoft.Build.Tasks.Deployment.ManifestUtilities.ProxyStub[] XmlExternalProxyStubs { get { return default(Microsoft.Build.Tasks.Deployment.ManifestUtilities.ProxyStub[]); } set { } }
  }
  [System.Runtime.InteropServices.ComVisibleAttribute(false)]
  public sealed partial class AssemblyReference : Microsoft.Build.Tasks.Deployment.ManifestUtilities.BaseReference {
    [System.MonoTODOAttribute]
    public AssemblyReference() { }
    [System.MonoTODOAttribute]
    public AssemblyReference(string path) { }
    public Microsoft.Build.Tasks.Deployment.ManifestUtilities.AssemblyIdentity AssemblyIdentity { get { return default(Microsoft.Build.Tasks.Deployment.ManifestUtilities.AssemblyIdentity); } set { } }
    public bool IsPrerequisite { get { return default(bool); } set { } }
    public Microsoft.Build.Tasks.Deployment.ManifestUtilities.AssemblyReferenceType ReferenceType { get { return default(Microsoft.Build.Tasks.Deployment.ManifestUtilities.AssemblyReferenceType); } set { } }
    protected internal override string SortName { get { return default(string); } }
    public Microsoft.Build.Tasks.Deployment.ManifestUtilities.AssemblyIdentity XmlAssemblyIdentity { get { return default(Microsoft.Build.Tasks.Deployment.ManifestUtilities.AssemblyIdentity); } set { } }
    public string XmlIsNative { get { return default(string); } set { } }
    public string XmlIsPrerequisite { get { return default(string); } set { } }
    public override string ToString() { return default(string); }
  }
  [System.Runtime.InteropServices.ComVisibleAttribute(false)]
  public sealed partial class AssemblyReferenceCollection : System.Collections.IEnumerable {
    internal AssemblyReferenceCollection() { }
    public int Count { get { return default(int); } }
    public Microsoft.Build.Tasks.Deployment.ManifestUtilities.AssemblyReference this[int index] { get { return default(Microsoft.Build.Tasks.Deployment.ManifestUtilities.AssemblyReference); } }
    public Microsoft.Build.Tasks.Deployment.ManifestUtilities.AssemblyReference Add(Microsoft.Build.Tasks.Deployment.ManifestUtilities.AssemblyReference assembly) { return default(Microsoft.Build.Tasks.Deployment.ManifestUtilities.AssemblyReference); }
    public Microsoft.Build.Tasks.Deployment.ManifestUtilities.AssemblyReference Add(string path) { return default(Microsoft.Build.Tasks.Deployment.ManifestUtilities.AssemblyReference); }
    public void Clear() { }
    public Microsoft.Build.Tasks.Deployment.ManifestUtilities.AssemblyReference Find(Microsoft.Build.Tasks.Deployment.ManifestUtilities.AssemblyIdentity identity) { return default(Microsoft.Build.Tasks.Deployment.ManifestUtilities.AssemblyReference); }
    public Microsoft.Build.Tasks.Deployment.ManifestUtilities.AssemblyReference Find(string name) { return default(Microsoft.Build.Tasks.Deployment.ManifestUtilities.AssemblyReference); }
    public Microsoft.Build.Tasks.Deployment.ManifestUtilities.AssemblyReference FindTargetPath(string targetPath) { return default(Microsoft.Build.Tasks.Deployment.ManifestUtilities.AssemblyReference); }
    public System.Collections.IEnumerator GetEnumerator() { return default(System.Collections.IEnumerator); }
    public void Remove(Microsoft.Build.Tasks.Deployment.ManifestUtilities.AssemblyReference assemblyReference) { }
  }
  public enum AssemblyReferenceType {
    ClickOnceManifest = 1,
    ManagedAssembly = 2,
    NativeAssembly = 3,
    Unspecified = 0,
  }
  [System.Runtime.InteropServices.ComVisibleAttribute(false)]
  public abstract partial class BaseReference {
    [System.MonoTODOAttribute]
    protected internal BaseReference() { }
    [System.MonoTODOAttribute]
    protected internal BaseReference(string path) { }
    [System.MonoTODOAttribute]
    public string Group { get { return default(string); } set { } }
    [System.MonoTODOAttribute]
    public string Hash { get { return default(string); } set { } }
    [System.MonoTODOAttribute]
    public bool IsOptional { get { return default(bool); } set { } }
    [System.MonoTODOAttribute]
    public string ResolvedPath { get { return default(string); } set { } }
    [System.MonoTODOAttribute]
    public long Size { get { return default(long); } set { } }
    [System.MonoTODOAttribute]
    protected internal abstract string SortName { get; }
    [System.MonoTODOAttribute]
    public string SourcePath { get { return default(string); } set { } }
    [System.MonoTODOAttribute]
    public string TargetPath { get { return default(string); } set { } }
    [System.MonoTODOAttribute]
    public string XmlGroup { get { return default(string); } set { } }
    [System.MonoTODOAttribute]
    public string XmlHash { get { return default(string); } set { } }
    [System.MonoTODOAttribute]
    public string XmlHashAlgorithm { get { return default(string); } set { } }
    [System.MonoTODOAttribute]
    public string XmlIsOptional { get { return default(string); } set { } }
    [System.MonoTODOAttribute]
    public string XmlPath { get { return default(string); } set { } }
    [System.MonoTODOAttribute]
    public string XmlSize { get { return default(string); } set { } }
    [System.MonoTODOAttribute]
    public override string ToString() { return default(string); }
  }
  [System.Runtime.InteropServices.ComVisibleAttribute(false)]
  public partial class ComClass {
    [System.MonoTODOAttribute]
    public ComClass() { }
    [System.MonoTODOAttribute]
    public string ClsId { get { return default(string); } }
    [System.MonoTODOAttribute]
    public string Description { get { return default(string); } }
    [System.MonoTODOAttribute]
    public string ProgId { get { return default(string); } }
    [System.MonoTODOAttribute]
    public string ThreadingModel { get { return default(string); } }
    [System.MonoTODOAttribute]
    public string TlbId { get { return default(string); } }
    [System.MonoTODOAttribute]
    public string XmlClsId { get { return default(string); } set { } }
    [System.MonoTODOAttribute]
    public string XmlDescription { get { return default(string); } set { } }
    [System.MonoTODOAttribute]
    public string XmlProgId { get { return default(string); } set { } }
    [System.MonoTODOAttribute]
    public string XmlThreadingModel { get { return default(string); } set { } }
    [System.MonoTODOAttribute]
    public string XmlTlbId { get { return default(string); } set { } }
  }
  [System.Runtime.InteropServices.ComVisibleAttribute(false)]
  public sealed partial class DeployManifest : Microsoft.Build.Tasks.Deployment.ManifestUtilities.Manifest {
    [System.MonoTODOAttribute]
    public DeployManifest() { }
    [System.MonoTODOAttribute]
    public string DeploymentUrl { get { return default(string); } set { } }
    [System.MonoTODOAttribute]
    public bool DisallowUrlActivation { get { return default(bool); } set { } }
    [System.MonoTODOAttribute]
    public override Microsoft.Build.Tasks.Deployment.ManifestUtilities.AssemblyReference EntryPoint { get { return default(Microsoft.Build.Tasks.Deployment.ManifestUtilities.AssemblyReference); } set { } }
    [System.MonoTODOAttribute]
    public bool Install { get { return default(bool); } set { } }
    [System.MonoTODOAttribute]
    public bool MapFileExtensions { get { return default(bool); } set { } }
    [System.MonoTODOAttribute]
    public string MinimumRequiredVersion { get { return default(string); } set { } }
    [System.MonoTODOAttribute]
    public string Product { get { return default(string); } set { } }
    [System.MonoTODOAttribute]
    public string Publisher { get { return default(string); } set { } }
    [System.MonoTODOAttribute]
    public string SupportUrl { get { return default(string); } set { } }
    [System.MonoTODOAttribute]
    public bool TrustUrlParameters { get { return default(bool); } set { } }
    [System.MonoTODOAttribute]
    public bool UpdateEnabled { get { return default(bool); } set { } }
    [System.MonoTODOAttribute]
    public int UpdateInterval { get { return default(int); } set { } }
    [System.MonoTODOAttribute]
    public Microsoft.Build.Tasks.Deployment.ManifestUtilities.UpdateMode UpdateMode { get { return default(Microsoft.Build.Tasks.Deployment.ManifestUtilities.UpdateMode); } set { } }
    [System.MonoTODOAttribute]
    public Microsoft.Build.Tasks.Deployment.ManifestUtilities.UpdateUnit UpdateUnit { get { return default(Microsoft.Build.Tasks.Deployment.ManifestUtilities.UpdateUnit); } set { } }
    [System.MonoTODOAttribute]
    public string XmlDeploymentUrl { get { return default(string); } set { } }
    [System.MonoTODOAttribute]
    public string XmlDisallowUrlActivation { get { return default(string); } set { } }
    [System.MonoTODOAttribute]
    public string XmlInstall { get { return default(string); } set { } }
    [System.MonoTODOAttribute]
    public string XmlMapFileExtensions { get { return default(string); } set { } }
    [System.MonoTODOAttribute]
    public string XmlMinimumRequiredVersion { get { return default(string); } set { } }
    [System.MonoTODOAttribute]
    public string XmlProduct { get { return default(string); } set { } }
    [System.MonoTODOAttribute]
    public string XmlPublisher { get { return default(string); } set { } }
    [System.MonoTODOAttribute]
    public string XmlSupportUrl { get { return default(string); } set { } }
    [System.MonoTODOAttribute]
    public string XmlTrustUrlParameters { get { return default(string); } set { } }
    [System.MonoTODOAttribute]
    public string XmlUpdateEnabled { get { return default(string); } set { } }
    [System.MonoTODOAttribute]
    public string XmlUpdateInterval { get { return default(string); } set { } }
    [System.MonoTODOAttribute]
    public string XmlUpdateMode { get { return default(string); } set { } }
    [System.MonoTODOAttribute]
    public string XmlUpdateUnit { get { return default(string); } set { } }
    [System.MonoTODOAttribute]
    public override void Validate() { }
  }
  [System.Runtime.InteropServices.ComVisibleAttribute(false)]
  public sealed partial class FileReference : Microsoft.Build.Tasks.Deployment.ManifestUtilities.BaseReference {
    [System.MonoTODOAttribute]
    public FileReference() { }
    [System.MonoTODOAttribute]
    public FileReference(string path) { }
    public Microsoft.Build.Tasks.Deployment.ManifestUtilities.ComClass[] ComClasses { get { return default(Microsoft.Build.Tasks.Deployment.ManifestUtilities.ComClass[]); } }
    public bool IsDataFile { get { return default(bool); } set { } }
    public Microsoft.Build.Tasks.Deployment.ManifestUtilities.ProxyStub[] ProxyStubs { get { return default(Microsoft.Build.Tasks.Deployment.ManifestUtilities.ProxyStub[]); } }
    protected internal override string SortName { get { return default(string); } }
    public Microsoft.Build.Tasks.Deployment.ManifestUtilities.TypeLib[] TypeLibs { get { return default(Microsoft.Build.Tasks.Deployment.ManifestUtilities.TypeLib[]); } }
    public Microsoft.Build.Tasks.Deployment.ManifestUtilities.ComClass[] XmlComClasses { get { return default(Microsoft.Build.Tasks.Deployment.ManifestUtilities.ComClass[]); } set { } }
    public Microsoft.Build.Tasks.Deployment.ManifestUtilities.ProxyStub[] XmlProxyStubs { get { return default(Microsoft.Build.Tasks.Deployment.ManifestUtilities.ProxyStub[]); } set { } }
    public Microsoft.Build.Tasks.Deployment.ManifestUtilities.TypeLib[] XmlTypeLibs { get { return default(Microsoft.Build.Tasks.Deployment.ManifestUtilities.TypeLib[]); } set { } }
    public string XmlWriteableType { get { return default(string); } set { } }
  }
  [System.Runtime.InteropServices.ComVisibleAttribute(false)]
  public sealed partial class FileReferenceCollection : System.Collections.IEnumerable {
    internal FileReferenceCollection() { }
    [System.MonoTODOAttribute]
    public int Count { get { return default(int); } }
    [System.MonoTODOAttribute]
    public Microsoft.Build.Tasks.Deployment.ManifestUtilities.FileReference this[int index] { get { return default(Microsoft.Build.Tasks.Deployment.ManifestUtilities.FileReference); } }
    [System.MonoTODOAttribute]
    public Microsoft.Build.Tasks.Deployment.ManifestUtilities.FileReference Add(Microsoft.Build.Tasks.Deployment.ManifestUtilities.FileReference file) { return default(Microsoft.Build.Tasks.Deployment.ManifestUtilities.FileReference); }
    [System.MonoTODOAttribute]
    public Microsoft.Build.Tasks.Deployment.ManifestUtilities.FileReference Add(string path) { return default(Microsoft.Build.Tasks.Deployment.ManifestUtilities.FileReference); }
    [System.MonoTODOAttribute]
    public void Clear() { }
    [System.MonoTODOAttribute]
    public Microsoft.Build.Tasks.Deployment.ManifestUtilities.FileReference FindTargetPath(string targetPath) { return default(Microsoft.Build.Tasks.Deployment.ManifestUtilities.FileReference); }
    [System.MonoTODOAttribute]
    public System.Collections.IEnumerator GetEnumerator() { return default(System.Collections.IEnumerator); }
    [System.MonoTODOAttribute]
    public void Remove(Microsoft.Build.Tasks.Deployment.ManifestUtilities.FileReference file) { }
  }
  [System.Runtime.InteropServices.ComVisibleAttribute(false)]
  public abstract partial class Manifest {
    [System.MonoTODOAttribute]
    protected internal Manifest() { }
    [System.MonoTODOAttribute]
    public Microsoft.Build.Tasks.Deployment.ManifestUtilities.AssemblyIdentity AssemblyIdentity { get { return default(Microsoft.Build.Tasks.Deployment.ManifestUtilities.AssemblyIdentity); } set { } }
    [System.MonoTODOAttribute]
    public Microsoft.Build.Tasks.Deployment.ManifestUtilities.AssemblyReferenceCollection AssemblyReferences { get { return default(Microsoft.Build.Tasks.Deployment.ManifestUtilities.AssemblyReferenceCollection); } }
    [System.MonoTODOAttribute]
    public string Description { get { return default(string); } set { } }
    [System.MonoTODOAttribute]
    public virtual Microsoft.Build.Tasks.Deployment.ManifestUtilities.AssemblyReference EntryPoint { get { return default(Microsoft.Build.Tasks.Deployment.ManifestUtilities.AssemblyReference); } set { } }
    [System.MonoTODOAttribute]
    public Microsoft.Build.Tasks.Deployment.ManifestUtilities.FileReferenceCollection FileReferences { get { return default(Microsoft.Build.Tasks.Deployment.ManifestUtilities.FileReferenceCollection); } }
    [System.MonoTODOAttribute]
    public System.IO.Stream InputStream { get { return default(System.IO.Stream); } set { } }
    [System.MonoTODOAttribute]
    public Microsoft.Build.Tasks.Deployment.ManifestUtilities.OutputMessageCollection OutputMessages { get { return default(Microsoft.Build.Tasks.Deployment.ManifestUtilities.OutputMessageCollection); } }
    [System.MonoTODOAttribute]
    public bool ReadOnly { get { return default(bool); } set { } }
    [System.MonoTODOAttribute]
    public string SourcePath { get { return default(string); } set { } }
    [System.MonoTODOAttribute]
    public Microsoft.Build.Tasks.Deployment.ManifestUtilities.AssemblyIdentity XmlAssemblyIdentity { get { return default(Microsoft.Build.Tasks.Deployment.ManifestUtilities.AssemblyIdentity); } set { } }
    [System.MonoTODOAttribute]
    public Microsoft.Build.Tasks.Deployment.ManifestUtilities.AssemblyReference[] XmlAssemblyReferences { get { return default(Microsoft.Build.Tasks.Deployment.ManifestUtilities.AssemblyReference[]); } set { } }
    [System.MonoTODOAttribute]
    public string XmlDescription { get { return default(string); } set { } }
    [System.MonoTODOAttribute]
    public Microsoft.Build.Tasks.Deployment.ManifestUtilities.FileReference[] XmlFileReferences { get { return default(Microsoft.Build.Tasks.Deployment.ManifestUtilities.FileReference[]); } set { } }
    [System.MonoTODOAttribute]
    public string XmlSchema { get { return default(string); } set { } }
    [System.MonoTODOAttribute]
    public void ResolveFiles() { }
    [System.MonoTODOAttribute]
    public void ResolveFiles(System.String[] searchPaths) { }
    [System.MonoTODOAttribute]
    public override string ToString() { return default(string); }
    [System.MonoTODOAttribute]
    public void UpdateFileInfo() { }
    [System.MonoTODOAttribute]
    public virtual void Validate() { }
    [System.MonoTODOAttribute]
    protected void ValidatePlatform() { }
  }
  [System.Runtime.InteropServices.ComVisibleAttribute(false)]
  public static partial class ManifestReader {
    [System.MonoTODOAttribute]
    public static Microsoft.Build.Tasks.Deployment.ManifestUtilities.Manifest ReadManifest(System.IO.Stream input, bool preserveStream) { return default(Microsoft.Build.Tasks.Deployment.ManifestUtilities.Manifest); }
    [System.MonoTODOAttribute]
    public static Microsoft.Build.Tasks.Deployment.ManifestUtilities.Manifest ReadManifest(string path, bool preserveStream) { return default(Microsoft.Build.Tasks.Deployment.ManifestUtilities.Manifest); }
    [System.MonoTODOAttribute]
    public static Microsoft.Build.Tasks.Deployment.ManifestUtilities.Manifest ReadManifest(string manifestType, System.IO.Stream input, bool preserveStream) { return default(Microsoft.Build.Tasks.Deployment.ManifestUtilities.Manifest); }
    [System.MonoTODOAttribute]
    public static Microsoft.Build.Tasks.Deployment.ManifestUtilities.Manifest ReadManifest(string manifestType, string path, bool preserveStream) { return default(Microsoft.Build.Tasks.Deployment.ManifestUtilities.Manifest); }
  }
  [System.Runtime.InteropServices.ComVisibleAttribute(false)]
  public static partial class ManifestWriter {
    [System.MonoTODOAttribute]
    public static void WriteManifest(Microsoft.Build.Tasks.Deployment.ManifestUtilities.Manifest manifest) { }
    [System.MonoTODOAttribute]
    public static void WriteManifest(Microsoft.Build.Tasks.Deployment.ManifestUtilities.Manifest manifest, System.IO.Stream output) { }
    [System.MonoTODOAttribute]
    public static void WriteManifest(Microsoft.Build.Tasks.Deployment.ManifestUtilities.Manifest manifest, string path) { }
  }
  [System.Runtime.InteropServices.ComVisibleAttribute(false)]
  public sealed partial class OutputMessage {
    internal OutputMessage() { }
    public string Name { get { return default(string); } }
    public string Text { get { return default(string); } }
    public Microsoft.Build.Tasks.Deployment.ManifestUtilities.OutputMessageType Type { get { return default(Microsoft.Build.Tasks.Deployment.ManifestUtilities.OutputMessageType); } }
    [System.MonoTODOAttribute]
    public System.String[] GetArguments() { return default(System.String[]); }
  }
  [System.Runtime.InteropServices.ComVisibleAttribute(false)]
  public sealed partial class OutputMessageCollection : System.Collections.IEnumerable {
    internal OutputMessageCollection() { }
    [System.MonoTODOAttribute]
    public int ErrorCount { get { return default(int); } }
    [System.MonoTODOAttribute]
    public Microsoft.Build.Tasks.Deployment.ManifestUtilities.OutputMessage this[int index] { get { return default(Microsoft.Build.Tasks.Deployment.ManifestUtilities.OutputMessage); } }
    [System.MonoTODOAttribute]
    public int WarningCount { get { return default(int); } }
    [System.MonoTODOAttribute]
    public void Clear() { }
    [System.MonoTODOAttribute]
    public System.Collections.IEnumerator GetEnumerator() { return default(System.Collections.IEnumerator); }
  }
  [System.Runtime.InteropServices.ComVisibleAttribute(false)]
  public enum OutputMessageType {
    Error = 2,
    Info = 0,
    Warning = 1,
  }
  [System.Runtime.InteropServices.ComVisibleAttribute(false)]
  public partial class ProxyStub {
    [System.MonoTODOAttribute]
    public ProxyStub() { }
    public string BaseInterface { get { return default(string); } }
    public string IID { get { return default(string); } }
    public string Name { get { return default(string); } }
    public string NumMethods { get { return default(string); } }
    public string TlbId { get { return default(string); } }
    public string XmlBaseInterface { get { return default(string); } set { } }
    public string XmlIID { get { return default(string); } set { } }
    public string XmlName { get { return default(string); } set { } }
    public string XmlNumMethods { get { return default(string); } set { } }
    public string XmlTlbId { get { return default(string); } set { } }
  }
  [System.Runtime.InteropServices.ComVisibleAttribute(false)]
  public static partial class SecurityUtilities {
    [System.MonoTODOAttribute]
    public static System.Security.PermissionSet ComputeZonePermissionSet(string targetZone, System.Security.PermissionSet includedPermissionSet, System.String[] excludedPermissions) { return default(System.Security.PermissionSet); }
    [System.MonoTODOAttribute]
    public static System.Security.PermissionSet IdentityListToPermissionSet(System.String[] ids) { return default(System.Security.PermissionSet); }
    [System.MonoTODOAttribute]
    public static System.String[] PermissionSetToIdentityList(System.Security.PermissionSet permissionSet) { return default(System.String[]); }
    [System.MonoTODOAttribute]
    public static void SignFile(System.Security.Cryptography.X509Certificates.X509Certificate2 cert, System.Uri timestampUrl, string path) { }
    [System.MonoTODOAttribute]
    public static void SignFile(string certPath, System.Security.SecureString certPassword, System.Uri timestampUrl, string path) { }
    [System.MonoTODOAttribute]
    public static void SignFile(string certThumbprint, System.Uri timestampUrl, string path) { }
    [System.MonoTODOAttribute]
    public static System.Security.PermissionSet XmlToPermissionSet(System.Xml.XmlElement element) { return default(System.Security.PermissionSet); }
  }
  [System.Runtime.InteropServices.ComVisibleAttribute(false)]
  public sealed partial class TrustInfo {
    [System.MonoTODOAttribute]
    public TrustInfo() { }
    [System.MonoTODOAttribute]
    public bool HasUnmanagedCodePermission { get { return default(bool); } }
    [System.MonoTODOAttribute]
    public bool IsFullTrust { get { return default(bool); } set { } }
    [System.MonoTODOAttribute]
    public System.Security.PermissionSet PermissionSet { get { return default(System.Security.PermissionSet); } set { } }
    [System.MonoTODOAttribute]
    public bool PreserveFullTrustPermissionSet { get { return default(bool); } set { } }
    [System.MonoTODOAttribute]
    public string SameSiteAccess { get { return default(string); } set { } }
    [System.MonoTODOAttribute]
    public void Clear() { }
    [System.MonoTODOAttribute]
    public void Read(System.IO.Stream input) { }
    [System.MonoTODOAttribute]
    public void Read(string path) { }
    [System.MonoTODOAttribute]
    public void ReadManifest(System.IO.Stream input) { }
    [System.MonoTODOAttribute]
    public void ReadManifest(string path) { }
    [System.MonoTODOAttribute]
    public override string ToString() { return default(string); }
    [System.MonoTODOAttribute]
    public void Write(System.IO.Stream output) { }
    [System.MonoTODOAttribute]
    public void Write(string path) { }
    [System.MonoTODOAttribute]
    public void WriteManifest(System.IO.Stream output) { }
    [System.MonoTODOAttribute]
    public void WriteManifest(System.IO.Stream input, System.IO.Stream output) { }
    [System.MonoTODOAttribute]
    public void WriteManifest(string path) { }
  }
  [System.Runtime.InteropServices.ComVisibleAttribute(false)]
  public partial class TypeLib {
    [System.MonoTODOAttribute]
    public TypeLib() { }
    public string Flags { get { return default(string); } }
    public string HelpDirectory { get { return default(string); } }
    public string ResourceId { get { return default(string); } }
    public string TlbId { get { return default(string); } }
    public string Version { get { return default(string); } }
    public string XmlFlags { get { return default(string); } set { } }
    public string XmlHelpDirectory { get { return default(string); } set { } }
    public string XmlResourceId { get { return default(string); } set { } }
    public string XmlTlbId { get { return default(string); } set { } }
    public string XmlVersion { get { return default(string); } set { } }
  }
  [System.Runtime.InteropServices.ComVisibleAttribute(false)]
  public enum UpdateMode {
    Background = 0,
    Foreground = 1,
  }
  [System.Runtime.InteropServices.ComVisibleAttribute(false)]
  public enum UpdateUnit {
    Days = 1,
    Hours = 0,
    Weeks = 2,
  }
  [System.Runtime.InteropServices.ComVisibleAttribute(false)]
  public partial class WindowClass {
    [System.MonoTODOAttribute]
    public WindowClass() { }
    [System.MonoTODOAttribute]
    public WindowClass(string name, bool versioned) { }
    public string Name { get { return default(string); } }
    public bool Versioned { get { return default(bool); } }
    public string XmlName { get { return default(string); } set { } }
    public string XmlVersioned { get { return default(string); } set { } }
  }
}
namespace Microsoft.Build.Tasks.Hosting {
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  [System.Runtime.InteropServices.GuidAttribute("8520CC4D-64DC-4855-BE3F-4C28CCE048EE")]
  [System.Runtime.InteropServices.InterfaceTypeAttribute((System.Runtime.InteropServices.ComInterfaceType)(1))]
  public partial interface ICscHostObject : Microsoft.Build.Framework.ITaskHost {
    void BeginInitialization();
    bool Compile();
    bool EndInitialization(out string errorMessage, out int errorCode);
    bool IsDesignTime();
    bool IsUpToDate();
    bool SetAdditionalLibPaths(System.String[] additionalLibPaths);
    bool SetAddModules(System.String[] addModules);
    bool SetAllowUnsafeBlocks(bool allowUnsafeBlocks);
    bool SetBaseAddress(string baseAddress);
    bool SetCheckForOverflowUnderflow(bool checkForOverflowUnderflow);
    bool SetCodePage(int codePage);
    bool SetDebugType(string debugType);
    bool SetDefineConstants(string defineConstants);
    bool SetDelaySign(bool delaySignExplicitlySet, bool delaySign);
    bool SetDisabledWarnings(string disabledWarnings);
    bool SetDocumentationFile(string documentationFile);
    bool SetEmitDebugInformation(bool emitDebugInformation);
    bool SetErrorReport(string errorReport);
    bool SetFileAlignment(int fileAlignment);
    bool SetGenerateFullPaths(bool generateFullPaths);
    bool SetKeyContainer(string keyContainer);
    bool SetKeyFile(string keyFile);
    bool SetLangVersion(string langVersion);
    bool SetLinkResources(Microsoft.Build.Framework.ITaskItem[] linkResources);
    bool SetMainEntryPoint(string targetType, string mainEntryPoint);
    bool SetModuleAssemblyName(string moduleAssemblyName);
    bool SetNoConfig(bool noConfig);
    bool SetNoStandardLib(bool noStandardLib);
    bool SetOptimize(bool optimize);
    bool SetOutputAssembly(string outputAssembly);
    bool SetPdbFile(string pdbFile);
    bool SetPlatform(string platform);
    bool SetReferences(Microsoft.Build.Framework.ITaskItem[] references);
    bool SetResources(Microsoft.Build.Framework.ITaskItem[] resources);
    bool SetResponseFiles(Microsoft.Build.Framework.ITaskItem[] responseFiles);
    bool SetSources(Microsoft.Build.Framework.ITaskItem[] sources);
    bool SetTargetType(string targetType);
    bool SetTreatWarningsAsErrors(bool treatWarningsAsErrors);
    bool SetWarningLevel(int warningLevel);
    bool SetWarningsAsErrors(string warningsAsErrors);
    bool SetWarningsNotAsErrors(string warningsNotAsErrors);
    bool SetWin32Icon(string win32Icon);
    bool SetWin32Resource(string win32Resource);
  }
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  [System.Runtime.InteropServices.GuidAttribute("7D7AC3BE-253A-40e8-A3FF-357D0DA7C47A")]
  [System.Runtime.InteropServices.InterfaceTypeAttribute((System.Runtime.InteropServices.ComInterfaceType)(1))]
  public partial interface IVbcHostObject : Microsoft.Build.Framework.ITaskHost {
    void BeginInitialization();
    bool Compile();
    void EndInitialization();
    bool IsDesignTime();
    bool IsUpToDate();
    bool SetAdditionalLibPaths(System.String[] additionalLibPaths);
    bool SetAddModules(System.String[] addModules);
    bool SetBaseAddress(string targetType, string baseAddress);
    bool SetCodePage(int codePage);
    bool SetDebugType(bool emitDebugInformation, string debugType);
    bool SetDefineConstants(string defineConstants);
    bool SetDelaySign(bool delaySign);
    bool SetDisabledWarnings(string disabledWarnings);
    bool SetDocumentationFile(string documentationFile);
    bool SetErrorReport(string errorReport);
    bool SetFileAlignment(int fileAlignment);
    bool SetGenerateDocumentation(bool generateDocumentation);
    bool SetImports(Microsoft.Build.Framework.ITaskItem[] importsList);
    bool SetKeyContainer(string keyContainer);
    bool SetKeyFile(string keyFile);
    bool SetLinkResources(Microsoft.Build.Framework.ITaskItem[] linkResources);
    bool SetMainEntryPoint(string mainEntryPoint);
    bool SetNoConfig(bool noConfig);
    bool SetNoStandardLib(bool noStandardLib);
    bool SetNoWarnings(bool noWarnings);
    bool SetOptimize(bool optimize);
    bool SetOptionCompare(string optionCompare);
    bool SetOptionExplicit(bool optionExplicit);
    bool SetOptionStrict(bool optionStrict);
    bool SetOptionStrictType(string optionStrictType);
    bool SetOutputAssembly(string outputAssembly);
    bool SetPlatform(string platform);
    bool SetReferences(Microsoft.Build.Framework.ITaskItem[] references);
    bool SetRemoveIntegerChecks(bool removeIntegerChecks);
    bool SetResources(Microsoft.Build.Framework.ITaskItem[] resources);
    bool SetResponseFiles(Microsoft.Build.Framework.ITaskItem[] responseFiles);
    bool SetRootNamespace(string rootNamespace);
    bool SetSdkPath(string sdkPath);
    bool SetSources(Microsoft.Build.Framework.ITaskItem[] sources);
    bool SetTargetCompactFramework(bool targetCompactFramework);
    bool SetTargetType(string targetType);
    bool SetTreatWarningsAsErrors(bool treatWarningsAsErrors);
    bool SetWarningsAsErrors(string warningsAsErrors);
    bool SetWarningsNotAsErrors(string warningsNotAsErrors);
    bool SetWin32Icon(string win32Icon);
    bool SetWin32Resource(string win32Resource);
  }
}
