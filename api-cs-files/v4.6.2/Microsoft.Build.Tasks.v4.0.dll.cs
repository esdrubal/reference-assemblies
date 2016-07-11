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
    public bool Prefer32Bit { get { return default(bool); } set { } }
    public string ProductName { get { return default(string); } set { } }
    public string ProductVersion { get { return default(string); } set { } }
    public System.String[] ResponseFiles { get { return default(System.String[]); } set { } }
    public string SdkToolsPath { get { return default(string); } set { } }
    public Microsoft.Build.Framework.ITaskItem[] SourceModules { get { return default(Microsoft.Build.Framework.ITaskItem[]); } set { } }
    public string TargetType { get { return default(string); } set { } }
    public string TemplateFile { get { return default(string); } set { } }
    public string Title { get { return default(string); } set { } }
    protected override string ToolName { get { return default(string); } }
    public string Trademark { get { return default(string); } set { } }
    public string Version { get { return default(string); } set { } }
    public string Win32Icon { get { return default(string); } set { } }
    public string Win32Resource { get { return default(string); } set { } }
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
    public string TargetFrameworkMoniker { get { return default(string); } set { } }
    public string TargetPath { get { return default(string); } set { } }
    protected override string ToolName { get { return default(string); } }
    public bool Updateable { get { return default(bool); } set { } }
    public string VirtualPath { get { return default(string); } set { } }
    protected internal override void AddCommandLineCommands(Microsoft.Build.Tasks.CommandLineBuilderExtension commandLine) { }
    public override bool Execute() { return default(bool); }
    protected override string GenerateFullPathToTool() { return default(string); }
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
    public bool AddSyntheticProjectReferencesForSolutionDependencies { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [Microsoft.Build.Framework.OutputAttribute]
    public Microsoft.Build.Framework.ITaskItem[] AssignedProjects { get { return default(Microsoft.Build.Framework.ITaskItem[]); } set { } }
    public string CurrentProject { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public string CurrentProjectConfiguration { get { return default(string); } set { } }
    public string CurrentProjectPlatform { get { return default(string); } set { } }
    public string DefaultToVcxPlatformMapping { get { return default(string); } set { } }
    public bool OnlyReferenceAndBuildProjectsEnabledInSolutionConfiguration { get { return default(bool); } set { } }
    public string OutputType { get { return default(string); } set { } }
    public bool ResolveConfigurationPlatformUsingMappings { get { return default(bool); } set { } }
    public bool ShouldUnsetParentConfigurationAndPlatform { get { return default(bool); } set { } }
    public string SolutionConfigurationContents { get { return default(string); } set { } }
    [Microsoft.Build.Framework.OutputAttribute]
    public Microsoft.Build.Framework.ITaskItem[] UnassignedProjects { get { return default(Microsoft.Build.Framework.ITaskItem[]); } set { } }
    public string VcxToDefaultPlatformMapping { get { return default(string); } set { } }
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
  [Microsoft.Build.Framework.RunInMTAAttribute]
  public partial class CallTarget : Microsoft.Build.Tasks.TaskExtension {
    public CallTarget() { }
    public bool RunEachTargetSeparately { get { return default(bool); } set { } }
    [Microsoft.Build.Framework.OutputAttribute]
    public Microsoft.Build.Framework.ITaskItem[] TargetOutputs { get { return default(Microsoft.Build.Framework.ITaskItem[]); } }
    public System.String[] Targets { get { return default(System.String[]); } set { } }
    public bool UseResultsCache { get { return default(bool); } set { } }
    public override bool Execute() { return default(bool); }
  }
  public partial class CodeTaskFactory : Microsoft.Build.Framework.ITaskFactory {
    public CodeTaskFactory() { }
    public string FactoryName { get { return default(string); } }
    public System.Type TaskType { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Type); } }
    public void CleanupTask(Microsoft.Build.Framework.ITask task) { }
    public Microsoft.Build.Framework.ITask CreateTask(Microsoft.Build.Framework.IBuildEngine loggingHost) { return default(Microsoft.Build.Framework.ITask); }
    public Microsoft.Build.Framework.TaskPropertyInfo[] GetTaskParameters() { return default(Microsoft.Build.Framework.TaskPropertyInfo[]); }
    public bool Initialize(string taskName, System.Collections.Generic.IDictionary<System.String, Microsoft.Build.Framework.TaskPropertyInfo> taskParameters, string taskElementContents, Microsoft.Build.Framework.IBuildEngine taskFactoryLoggingHost) { return default(bool); }
  }
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
    protected string GetQuotedText(string unquotedText) { return default(string); }
  }
  public partial class ConvertToAbsolutePath : Microsoft.Build.Tasks.TaskExtension {
    public ConvertToAbsolutePath() { }
    [Microsoft.Build.Framework.OutputAttribute]
    public Microsoft.Build.Framework.ITaskItem[] AbsolutePaths { get { return default(Microsoft.Build.Framework.ITaskItem[]); } set { } }
    [Microsoft.Build.Framework.RequiredAttribute]
    public Microsoft.Build.Framework.ITaskItem[] Paths { get { return default(Microsoft.Build.Framework.ITaskItem[]); } set { } }
    public override bool Execute() { return default(bool); }
  }
  public partial class Copy : Microsoft.Build.Tasks.TaskExtension, Microsoft.Build.Framework.ICancelableTask, Microsoft.Build.Framework.ITask {
    public Copy() { }
    [Microsoft.Build.Framework.OutputAttribute]
    public Microsoft.Build.Framework.ITaskItem[] CopiedFiles { get { return default(Microsoft.Build.Framework.ITaskItem[]); } }
    [Microsoft.Build.Framework.OutputAttribute]
    public Microsoft.Build.Framework.ITaskItem[] DestinationFiles { get { return default(Microsoft.Build.Framework.ITaskItem[]); } set { } }
    public Microsoft.Build.Framework.ITaskItem DestinationFolder { get { return default(Microsoft.Build.Framework.ITaskItem); } set { } }
    public bool OverwriteReadOnlyFiles { get { return default(bool); } set { } }
    public int Retries { get { return default(int); } set { } }
    public int RetryDelayMilliseconds { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(int); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public bool SkipUnchangedFiles { get { return default(bool); } set { } }
    [Microsoft.Build.Framework.RequiredAttribute]
    public Microsoft.Build.Framework.ITaskItem[] SourceFiles { get { return default(Microsoft.Build.Framework.ITaskItem[]); } set { } }
    public bool UseHardlinksIfPossible { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public void Cancel() { }
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
    protected System.Collections.Generic.Dictionary<System.String, Microsoft.Build.Framework.ITaskItem> itemSpecToTaskitem;
    protected CreateManifestResourceName() { }
    [Microsoft.Build.Framework.OutputAttribute]
    public Microsoft.Build.Framework.ITaskItem[] ManifestResourceNames { get { return default(Microsoft.Build.Framework.ITaskItem[]); } }
    public bool PrependCultureAsDirectory { get { return default(bool); } set { } }
    [Microsoft.Build.Framework.RequiredAttribute]
    public Microsoft.Build.Framework.ITaskItem[] ResourceFiles { get { return default(Microsoft.Build.Framework.ITaskItem[]); } set { } }
    [Microsoft.Build.Framework.OutputAttribute]
    public Microsoft.Build.Framework.ITaskItem[] ResourceFilesWithManifestResourceNames { get { return default(Microsoft.Build.Framework.ITaskItem[]); } set { } }
    public string RootNamespace { get { return default(string); } set { } }
    protected abstract string CreateManifestName(string fileName, string linkFileName, string rootNamespaceName, string dependentUponFileName, System.IO.Stream binaryStream);
    public override bool Execute() { return default(bool); }
    protected abstract bool IsSourceFile(string fileName);
    public static string MakeValidEverettIdentifier(string name) { return default(string); }
  }
  public partial class CreateProperty : Microsoft.Build.Tasks.TaskExtension {
    public CreateProperty() { }
    [Microsoft.Build.Framework.OutputAttribute]
    public System.String[] Value { get { return default(System.String[]); } set { } }
    [Microsoft.Build.Framework.OutputAttribute]
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
    public string ApplicationConfiguration { get { return default(string); } set { } }
    public string BaseAddress { get { return default(string); } set { } }
    public bool CheckForOverflowUnderflow { get { return default(bool); } set { } }
    public string DisabledWarnings { get { return default(string); } set { } }
    public string DocumentationFile { get { return default(string); } set { } }
    public bool ErrorEndLocation { get { return default(bool); } set { } }
    public string ErrorReport { get { return default(string); } set { } }
    public bool GenerateFullPaths { get { return default(bool); } set { } }
    public string LangVersion { get { return default(string); } set { } }
    public string ModuleAssemblyName { get { return default(string); } set { } }
    public bool NoStandardLib { get { return default(bool); } set { } }
    public string PdbFile { get { return default(string); } set { } }
    public string PreferredUILang { get { return default(string); } set { } }
    protected override string ToolName { get { return default(string); } }
    public bool UseHostCompilerIfAvailable { get { return default(bool); } set { } }
    public int WarningLevel { get { return default(int); } set { } }
    public string WarningsAsErrors { get { return default(string); } set { } }
    public string WarningsNotAsErrors { get { return default(string); } set { } }
    protected internal override void AddResponseFileCommands(Microsoft.Build.Tasks.CommandLineBuilderExtension commandLine) { }
    protected override bool CallHostObjectToExecute() { return default(bool); }
    protected override string GenerateFullPathToTool() { return default(string); }
    protected override Microsoft.Build.Utilities.HostObjectInitializationStatus InitializeHostObject() { return default(Microsoft.Build.Utilities.HostObjectInitializationStatus); }
  }
  public sealed partial class Delete : Microsoft.Build.Tasks.TaskExtension, Microsoft.Build.Framework.ICancelableTask, Microsoft.Build.Framework.ITask {
    public Delete() { }
    [Microsoft.Build.Framework.OutputAttribute]
    public Microsoft.Build.Framework.ITaskItem[] DeletedFiles { get { return default(Microsoft.Build.Framework.ITaskItem[]); } set { } }
    [Microsoft.Build.Framework.RequiredAttribute]
    public Microsoft.Build.Framework.ITaskItem[] Files { get { return default(Microsoft.Build.Framework.ITaskItem[]); } set { } }
    public bool TreatErrorsAsWarnings { get { return default(bool); } set { } }
    public void Cancel() { }
    public override bool Execute() { return default(bool); }
  }
  public sealed partial class Error : Microsoft.Build.Tasks.TaskExtension {
    public Error() { }
    public string Code { get { return default(string); } set { } }
    public string File { get { return default(string); } set { } }
    public string HelpKeyword { get { return default(string); } set { } }
    public string Text { get { return default(string); } set { } }
    public override bool Execute() { return default(bool); }
  }
  public partial class Exec : Microsoft.Build.Tasks.ToolTaskExtension {
    public Exec() { }
    [Microsoft.Build.Framework.RequiredAttribute]
    public string Command { get { return default(string); } set { } }
    [Microsoft.Build.Framework.OutputAttribute]
    public Microsoft.Build.Framework.ITaskItem[] ConsoleOutput { get { return default(Microsoft.Build.Framework.ITaskItem[]); } set { } }
    public bool ConsoleToMSBuild { get { return default(bool); } set { } }
    public string CustomErrorRegularExpression { get { return default(string); } set { } }
    public string CustomWarningRegularExpression { get { return default(string); } set { } }
    public bool IgnoreExitCode { get { return default(bool); } set { } }
    public bool IgnoreStandardErrorWarningFormat { get { return default(bool); } set { } }
    [Microsoft.Build.Framework.OutputAttribute]
    public Microsoft.Build.Framework.ITaskItem[] Outputs { get { return default(Microsoft.Build.Framework.ITaskItem[]); } set { } }
    protected override System.Text.Encoding StandardErrorEncoding { get { return default(System.Text.Encoding); } }
    protected override Microsoft.Build.Framework.MessageImportance StandardErrorLoggingImportance { get { return default(Microsoft.Build.Framework.MessageImportance); } }
    protected override System.Text.Encoding StandardOutputEncoding { get { return default(System.Text.Encoding); } }
    protected override Microsoft.Build.Framework.MessageImportance StandardOutputLoggingImportance { get { return default(Microsoft.Build.Framework.MessageImportance); } }
    [Microsoft.Build.Framework.OutputAttribute]
    public string StdErrEncoding { get { return default(string); } set { } }
    [Microsoft.Build.Framework.OutputAttribute]
    public string StdOutEncoding { get { return default(string); } set { } }
    protected override string ToolName { get { return default(string); } }
    public string WorkingDirectory { get { return default(string); } set { } }
    protected internal override void AddCommandLineCommands(Microsoft.Build.Tasks.CommandLineBuilderExtension commandLine) { }
    protected override int ExecuteTool(string pathToTool, string responseFileCommands, string commandLineCommands) { return default(int); }
    protected override string GenerateFullPathToTool() { return default(string); }
    protected override string GetWorkingDirectory() { return default(string); }
    protected override bool HandleTaskExecutionErrors() { return default(bool); }
    protected override void LogEventsFromTextOutput(string singleLine, Microsoft.Build.Framework.MessageImportance messageImportance) { }
    protected override void LogPathToTool(string toolName, string pathToTool) { }
    protected override void LogToolCommand(string message) { }
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
    public Microsoft.Build.Framework.ITaskItem AppConfigFile { get { return default(Microsoft.Build.Framework.ITaskItem); } set { } }
    [Microsoft.Build.Framework.RequiredAttribute]
    public Microsoft.Build.Framework.ITaskItem[] PrimaryList { get { return default(Microsoft.Build.Framework.ITaskItem[]); } set { } }
    [Microsoft.Build.Framework.RequiredAttribute]
    public Microsoft.Build.Framework.ITaskItem[] SecondaryList { get { return default(Microsoft.Build.Framework.ITaskItem[]); } set { } }
    [Microsoft.Build.Framework.RequiredAttribute]
    public string TargetPath { get { return default(string); } set { } }
    public override bool Execute() { return default(bool); }
  }
  public partial class FindInList : Microsoft.Build.Tasks.TaskExtension {
    public FindInList() { }
    public bool CaseSensitive { get { return default(bool); } set { } }
    public bool FindLastMatch { get { return default(bool); } set { } }
    [Microsoft.Build.Framework.OutputAttribute]
    public Microsoft.Build.Framework.ITaskItem ItemFound { get { return default(Microsoft.Build.Framework.ITaskItem); } set { } }
    [Microsoft.Build.Framework.RequiredAttribute]
    public string ItemSpecToFind { get { return default(string); } set { } }
    [Microsoft.Build.Framework.RequiredAttribute]
    public Microsoft.Build.Framework.ITaskItem[] List { get { return default(Microsoft.Build.Framework.ITaskItem[]); } set { } }
    public bool MatchFileNameOnly { get { return default(bool); } set { } }
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
    public bool UpdateToAbsolutePaths { get { return default(bool); } set { } }
    public override bool Execute() { return default(bool); }
  }
  public sealed partial class FormatUrl : Microsoft.Build.Tasks.TaskExtension {
    public FormatUrl() { }
    public string InputUrl { get { return default(string); } set { } }
    [Microsoft.Build.Framework.OutputAttribute]
    public string OutputUrl { get { return default(string); } set { } }
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
    public string ErrorReportUrl { get { return default(string); } set { } }
    public Microsoft.Build.Framework.ITaskItem[] FileAssociations { get { return default(Microsoft.Build.Framework.ITaskItem[]); } set { } }
    public Microsoft.Build.Framework.ITaskItem[] Files { get { return default(Microsoft.Build.Framework.ITaskItem[]); } set { } }
    public bool HostInBrowser { get { return default(bool); } set { } }
    public Microsoft.Build.Framework.ITaskItem IconFile { get { return default(Microsoft.Build.Framework.ITaskItem); } set { } }
    public Microsoft.Build.Framework.ITaskItem[] IsolatedComReferences { get { return default(Microsoft.Build.Framework.ITaskItem[]); } set { } }
    public string ManifestType { get { return default(string); } set { } }
    public string OSVersion { get { return default(string); } set { } }
    public string Product { get { return default(string); } set { } }
    public string Publisher { get { return default(string); } set { } }
    public bool RequiresMinimumFramework35SP1 { get { return default(bool); } set { } }
    public string SuiteName { get { return default(string); } set { } }
    public string SupportUrl { get { return default(string); } set { } }
    public string TargetFrameworkProfile { get { return default(string); } set { } }
    public string TargetFrameworkSubset { get { return default(string); } set { } }
    public Microsoft.Build.Framework.ITaskItem TrustInfoFile { get { return default(Microsoft.Build.Framework.ITaskItem); } set { } }
    public bool UseApplicationTrust { get { return default(bool); } set { } }
    protected override System.Type GetObjectType() { return default(System.Type); }
    protected override bool OnManifestLoaded(Microsoft.Build.Tasks.Deployment.ManifestUtilities.Manifest manifest) { return default(bool); }
    protected override bool OnManifestResolved(Microsoft.Build.Tasks.Deployment.ManifestUtilities.Manifest manifest) { return default(bool); }
    protected internal override bool ValidateInputs() { return default(bool); }
  }
  public sealed partial class GenerateBootstrapper : Microsoft.Build.Tasks.TaskExtension {
    public GenerateBootstrapper() { }
    public string ApplicationFile { get { return default(string); } set { } }
    public string ApplicationName { get { return default(string); } set { } }
    public bool ApplicationRequiresElevation { get { return default(bool); } set { } }
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
    public string VisualStudioVersion { get { return default(string); } set { } }
    public override bool Execute() { return default(bool); }
  }
  public sealed partial class GenerateDeploymentManifest : Microsoft.Build.Tasks.GenerateManifestBase {
    public GenerateDeploymentManifest() { }
    public bool CreateDesktopShortcut { get { return default(bool); } set { } }
    public string DeploymentUrl { get { return default(string); } set { } }
    public bool DisallowUrlActivation { get { return default(bool); } set { } }
    public string ErrorReportUrl { get { return default(string); } set { } }
    public bool Install { get { return default(bool); } set { } }
    public bool MapFileExtensions { get { return default(bool); } set { } }
    public string MinimumRequiredVersion { get { return default(string); } set { } }
    public string Product { get { return default(string); } set { } }
    public string Publisher { get { return default(string); } set { } }
    public string SuiteName { get { return default(string); } set { } }
    public string SupportUrl { get { return default(string); } set { } }
    public bool TrustUrlParameters { get { return default(bool); } set { } }
    public bool UpdateEnabled { get { return default(bool); } set { } }
    public int UpdateInterval { get { return default(int); } set { } }
    public string UpdateMode { get { return default(string); } set { } }
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
    public string TargetFrameworkMoniker { get { return default(string); } set { } }
    public string TargetFrameworkVersion { get { return default(string); } set { } }
    protected internal Microsoft.Build.Tasks.Deployment.ManifestUtilities.AssemblyReference AddAssemblyFromItem(Microsoft.Build.Framework.ITaskItem item) { return default(Microsoft.Build.Tasks.Deployment.ManifestUtilities.AssemblyReference); }
    protected internal Microsoft.Build.Tasks.Deployment.ManifestUtilities.AssemblyReference AddAssemblyNameFromItem(Microsoft.Build.Framework.ITaskItem item, Microsoft.Build.Tasks.Deployment.ManifestUtilities.AssemblyReferenceType referenceType) { return default(Microsoft.Build.Tasks.Deployment.ManifestUtilities.AssemblyReference); }
    protected internal Microsoft.Build.Tasks.Deployment.ManifestUtilities.AssemblyReference AddEntryPointFromItem(Microsoft.Build.Framework.ITaskItem item, Microsoft.Build.Tasks.Deployment.ManifestUtilities.AssemblyReferenceType referenceType) { return default(Microsoft.Build.Tasks.Deployment.ManifestUtilities.AssemblyReference); }
    protected internal Microsoft.Build.Tasks.Deployment.ManifestUtilities.FileReference AddFileFromItem(Microsoft.Build.Framework.ITaskItem item) { return default(Microsoft.Build.Tasks.Deployment.ManifestUtilities.FileReference); }
    public override bool Execute() { return default(bool); }
    protected internal Microsoft.Build.Tasks.Deployment.ManifestUtilities.FileReference FindFileFromItem(Microsoft.Build.Framework.ITaskItem item) { return default(Microsoft.Build.Tasks.Deployment.ManifestUtilities.FileReference); }
    protected abstract System.Type GetObjectType();
    protected abstract bool OnManifestLoaded(Microsoft.Build.Tasks.Deployment.ManifestUtilities.Manifest manifest);
    protected abstract bool OnManifestResolved(Microsoft.Build.Tasks.Deployment.ManifestUtilities.Manifest manifest);
    protected internal virtual bool ValidateInputs() { return default(bool); }
    protected internal virtual bool ValidateOutput() { return default(bool); }
  }
  [Microsoft.Build.Framework.RequiredRuntimeAttribute("v2.0")]
  public sealed partial class GenerateResource : Microsoft.Build.Tasks.TaskExtension {
    public GenerateResource() { }
    public Microsoft.Build.Framework.ITaskItem[] AdditionalInputs { get { return default(Microsoft.Build.Framework.ITaskItem[]); } set { } }
    public System.String[] EnvironmentVariables { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.String[]); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public Microsoft.Build.Framework.ITaskItem[] ExcludedInputPaths { get { return default(Microsoft.Build.Framework.ITaskItem[]); } set { } }
    public bool ExecuteAsTool { get { return default(bool); } set { } }
    public bool ExtractResWFiles { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [Microsoft.Build.Framework.OutputAttribute]
    public Microsoft.Build.Framework.ITaskItem[] FilesWritten { get { return default(Microsoft.Build.Framework.ITaskItem[]); } }
    public bool MinimalRebuildFromTracking { get { return default(bool); } set { } }
    public bool NeverLockTypeAssemblies { get { return default(bool); } set { } }
    public string OutputDirectory { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [Microsoft.Build.Framework.OutputAttribute]
    public Microsoft.Build.Framework.ITaskItem[] OutputResources { get { return default(Microsoft.Build.Framework.ITaskItem[]); } set { } }
    public bool PublicClass { get { return default(bool); } set { } }
    public Microsoft.Build.Framework.ITaskItem[] References { get { return default(Microsoft.Build.Framework.ITaskItem[]); } set { } }
    public string SdkToolsPath { get { return default(string); } set { } }
    [Microsoft.Build.Framework.OutputAttribute]
    [Microsoft.Build.Framework.RequiredAttribute]
    public Microsoft.Build.Framework.ITaskItem[] Sources { get { return default(Microsoft.Build.Framework.ITaskItem[]); } set { } }
    public Microsoft.Build.Framework.ITaskItem StateFile { get { return default(Microsoft.Build.Framework.ITaskItem); } set { } }
    [Microsoft.Build.Framework.OutputAttribute]
    public string StronglyTypedClassName { get { return default(string); } set { } }
    [Microsoft.Build.Framework.OutputAttribute]
    public string StronglyTypedFileName { get { return default(string); } set { } }
    public string StronglyTypedLanguage { get { return default(string); } set { } }
    public string StronglyTypedManifestPrefix { get { return default(string); } set { } }
    public string StronglyTypedNamespace { get { return default(string); } set { } }
    public Microsoft.Build.Framework.ITaskItem[] TLogReadFiles { get { return default(Microsoft.Build.Framework.ITaskItem[]); } }
    public Microsoft.Build.Framework.ITaskItem[] TLogWriteFiles { get { return default(Microsoft.Build.Framework.ITaskItem[]); } }
    public string ToolArchitecture { get { return default(string); } set { } }
    public string TrackerFrameworkPath { get { return default(string); } set { } }
    public string TrackerLogDirectory { get { return default(string); } set { } }
    public string TrackerSdkPath { get { return default(string); } set { } }
    public bool TrackFileAccess { get { return default(bool); } set { } }
    public bool UseSourcePath { get { return default(bool); } set { } }
    public override bool Execute() { return default(bool); }
  }
  public sealed partial class GenerateTrustInfo : Microsoft.Build.Tasks.TaskExtension {
    public GenerateTrustInfo() { }
    public Microsoft.Build.Framework.ITaskItem[] ApplicationDependencies { get { return default(Microsoft.Build.Framework.ITaskItem[]); } set { } }
    public Microsoft.Build.Framework.ITaskItem BaseManifest { get { return default(Microsoft.Build.Framework.ITaskItem); } set { } }
    public string ExcludedPermissions { get { return default(string); } set { } }
    public string TargetFrameworkMoniker { get { return default(string); } set { } }
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
    public string FrameworkVersion45Path { get { return default(string); } }
    [Microsoft.Build.Framework.OutputAttribute]
    public string Path { get { return default(string); } set { } }
    public override bool Execute() { return default(bool); }
  }
  public partial class GetFrameworkSdkPath : Microsoft.Build.Tasks.TaskExtension {
    public GetFrameworkSdkPath() { }
    [Microsoft.Build.Framework.OutputAttribute]
    public string FrameworkSdkVersion20Path { get { return default(string); } }
    [Microsoft.Build.Framework.OutputAttribute]
    public string FrameworkSdkVersion35Path { get { return default(string); } }
    [Microsoft.Build.Framework.OutputAttribute]
    public string FrameworkSdkVersion40Path { get { return default(string); } }
    [Microsoft.Build.Framework.OutputAttribute]
    public string FrameworkSdkVersion45Path { get { return default(string); } }
    [Microsoft.Build.Framework.OutputAttribute]
    public string Path { get { return default(string); } set { } }
    public override bool Execute() { return default(bool); }
  }
  public partial class GetInstalledSDKLocations : Microsoft.Build.Tasks.TaskExtension {
    public GetInstalledSDKLocations() { }
    [Microsoft.Build.Framework.OutputAttribute]
    public Microsoft.Build.Framework.ITaskItem[] InstalledSDKs { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(Microsoft.Build.Framework.ITaskItem[]); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.String[] SDKDirectoryRoots { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.String[]); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public string SDKRegistryRoot { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [Microsoft.Build.Framework.RequiredAttribute]
    public string TargetPlatformIdentifier { get { return default(string); } set { } }
    [Microsoft.Build.Framework.RequiredAttribute]
    public string TargetPlatformVersion { get { return default(string); } set { } }
    public override bool Execute() { return default(bool); }
  }
  public partial class GetReferenceAssemblyPaths : Microsoft.Build.Tasks.TaskExtension {
    public GetReferenceAssemblyPaths() { }
    public bool BypassFrameworkInstallChecks { get { return default(bool); } set { } }
    [Microsoft.Build.Framework.OutputAttribute]
    public System.String[] FullFrameworkReferenceAssemblyPaths { get { return default(System.String[]); } }
    [Microsoft.Build.Framework.OutputAttribute]
    public System.String[] ReferenceAssemblyPaths { get { return default(System.String[]); } }
    public string RootPath { get { return default(string); } set { } }
    public string TargetFrameworkMoniker { get { return default(string); } set { } }
    [Microsoft.Build.Framework.OutputAttribute]
    public string TargetFrameworkMonikerDisplayName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public override bool Execute() { return default(bool); }
  }
  public partial class GetSDKReferenceFiles : Microsoft.Build.Tasks.TaskExtension {
    public GetSDKReferenceFiles() { }
    public string CacheFileFolderPath { get { return default(string); } set { } }
    [Microsoft.Build.Framework.OutputAttribute]
    public Microsoft.Build.Framework.ITaskItem[] CopyLocalFiles { get { return default(Microsoft.Build.Framework.ITaskItem[]); } }
    public bool LogCacheFileExceptions { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public bool LogRedistConflictBetweenSDKsAsWarning { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public bool LogRedistConflictWithinSDKAsWarning { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public bool LogRedistFilesList { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public bool LogReferenceConflictBetweenSDKsAsWarning { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public bool LogReferenceConflictWithinSDKAsWarning { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public bool LogReferencesList { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [Microsoft.Build.Framework.OutputAttribute]
    public Microsoft.Build.Framework.ITaskItem[] RedistFiles { get { return default(Microsoft.Build.Framework.ITaskItem[]); } }
    public System.String[] ReferenceExtensions { get { return default(System.String[]); } set { } }
    [Microsoft.Build.Framework.OutputAttribute]
    public Microsoft.Build.Framework.ITaskItem[] References { get { return default(Microsoft.Build.Framework.ITaskItem[]); } }
    public Microsoft.Build.Framework.ITaskItem[] ResolvedSDKReferences { get { return default(Microsoft.Build.Framework.ITaskItem[]); } set { } }
    public override bool Execute() { return default(bool); }
  }
  [System.Runtime.InteropServices.GuidAttribute("00020401-0000-0000-C000-000000000046")]
  [System.Runtime.InteropServices.InterfaceTypeAttribute((System.Runtime.InteropServices.ComInterfaceType)(1))]
  public partial interface IFixedTypeInfo {
    void AddressOfMember(int memid, System.Runtime.InteropServices.ComTypes.INVOKEKIND invKind, out System.IntPtr ppv);
    void CreateInstance(object pUnkOuter, ref System.Guid riid, out object ppvObj);
    void GetContainingTypeLib(out System.Runtime.InteropServices.ComTypes.ITypeLib ppTLB, out int pIndex);
    void GetDllEntry(int memid, System.Runtime.InteropServices.ComTypes.INVOKEKIND invKind, System.IntPtr pBstrDllName, System.IntPtr pBstrName, System.IntPtr pwOrdinal);
    void GetDocumentation(int index, out string strName, out string strDocString, out int dwHelpContext, out string strHelpFile);
    void GetFuncDesc(int index, out System.IntPtr ppFuncDesc);
    void GetIDsOfNames(System.String[] rgszNames, int cNames, System.Int32[] pMemId);
    void GetImplTypeFlags(int index, out System.Runtime.InteropServices.ComTypes.IMPLTYPEFLAGS pImplTypeFlags);
    void GetMops(int memid, out string pBstrMops);
    void GetNames(int memid, System.String[] rgBstrNames, int cMaxNames, out int pcNames);
    void GetRefTypeInfo(System.IntPtr hRef, out Microsoft.Build.Tasks.IFixedTypeInfo ppTI);
    void GetRefTypeOfImplType(int index, out System.IntPtr href);
    void GetTypeAttr(out System.IntPtr ppTypeAttr);
    void GetTypeComp(out System.Runtime.InteropServices.ComTypes.ITypeComp ppTComp);
    void GetVarDesc(int index, out System.IntPtr ppVarDesc);
    void Invoke(object pvInstance, int memid, short wFlags, ref System.Runtime.InteropServices.ComTypes.DISPPARAMS pDispParams, System.IntPtr pVarResult, System.IntPtr pExcepInfo, out int puArgErr);
    void ReleaseFuncDesc(System.IntPtr pFuncDesc);
    void ReleaseTypeAttr(System.IntPtr pTypeAttr);
    void ReleaseVarDesc(System.IntPtr pVarDesc);
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
    public string SdkToolsPath { get { return default(string); } set { } }
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
  [System.Security.Permissions.StrongNameIdentityPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, PublicKey="002400000480000094000000060200000024000052534131000400000100010007d1fa57c4aed9f0a32e84aa0faefd0de9e8fd6aec8f87fb03766c834c99921eb23be79ad9d5dcc1dd9ad236132102900b723cf980957fc4e177108fc607774f29e8320e92ea05ece4e821c0a5efe8f1645c4c0c93c1ab99285d622caa652c1dfad63d745d6f2de5f17e5eaf0fc4963d261c8a12436518206dc093344d5ad293")]
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
    public bool HighEntropyVA { get { return default(bool); } set { } }
    protected bool HostCompilerSupportsAllParameters { get { return default(bool); } set { } }
    public string KeyContainer { get { return default(string); } set { } }
    public string KeyFile { get { return default(string); } set { } }
    public Microsoft.Build.Framework.ITaskItem[] LinkResources { get { return default(Microsoft.Build.Framework.ITaskItem[]); } set { } }
    public string MainEntryPoint { get { return default(string); } set { } }
    public bool NoConfig { get { return default(bool); } set { } }
    public bool NoLogo { get { return default(bool); } set { } }
    public bool NoWin32Manifest { get { return default(bool); } set { } }
    public bool Optimize { get { return default(bool); } set { } }
    [Microsoft.Build.Framework.OutputAttribute]
    public Microsoft.Build.Framework.ITaskItem OutputAssembly { get { return default(Microsoft.Build.Framework.ITaskItem); } set { } }
    public string Platform { get { return default(string); } set { } }
    public bool Prefer32Bit { get { return default(bool); } set { } }
    public Microsoft.Build.Framework.ITaskItem[] References { get { return default(Microsoft.Build.Framework.ITaskItem[]); } set { } }
    public Microsoft.Build.Framework.ITaskItem[] Resources { get { return default(Microsoft.Build.Framework.ITaskItem[]); } set { } }
    public Microsoft.Build.Framework.ITaskItem[] ResponseFiles { get { return default(Microsoft.Build.Framework.ITaskItem[]); } set { } }
    public Microsoft.Build.Framework.ITaskItem[] Sources { get { return default(Microsoft.Build.Framework.ITaskItem[]); } set { } }
    protected override System.Text.Encoding StandardOutputEncoding { get { return default(System.Text.Encoding); } }
    public string SubsystemVersion { get { return default(string); } set { } }
    public string TargetType { get { return default(string); } set { } }
    public bool TreatWarningsAsErrors { get { return default(bool); } set { } }
    protected bool UsedCommandLineTool { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public bool Utf8Output { get { return default(bool); } set { } }
    public string Win32Icon { get { return default(string); } set { } }
    public string Win32Manifest { get { return default(string); } set { } }
    public string Win32Resource { get { return default(string); } set { } }
    protected internal override void AddCommandLineCommands(Microsoft.Build.Tasks.CommandLineBuilderExtension commandLine) { }
    protected internal override void AddResponseFileCommands(Microsoft.Build.Tasks.CommandLineBuilderExtension commandLine) { }
    protected bool CheckAllReferencesExistOnDisk() { return default(bool); }
    protected void CheckHostObjectSupport(string parameterName, bool resultFromHostObjectSetOperation) { }
    protected override bool HandleTaskExecutionErrors() { return default(bool); }
    protected bool ListHasNoDuplicateItems(Microsoft.Build.Framework.ITaskItem[] itemList, string parameterName) { return default(bool); }
    protected internal virtual bool UseAlternateCommandLineToolToExecute() { return default(bool); }
    protected override bool ValidateParameters() { return default(bool); }
  }
  public sealed partial class Message : Microsoft.Build.Tasks.TaskExtension {
    public Message() { }
    public string Code { get { return default(string); } set { } }
    public string File { get { return default(string); } set { } }
    public string HelpKeyword { get { return default(string); } set { } }
    public string Importance { get { return default(string); } set { } }
    public bool IsCritical { get { return default(bool); } set { } }
    public string Text { get { return default(string); } set { } }
    public override bool Execute() { return default(bool); }
  }
  public partial class Move : Microsoft.Build.Tasks.TaskExtension, Microsoft.Build.Framework.ICancelableTask, Microsoft.Build.Framework.ITask {
    public Move() { }
    [Microsoft.Build.Framework.OutputAttribute]
    public Microsoft.Build.Framework.ITaskItem[] DestinationFiles { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(Microsoft.Build.Framework.ITaskItem[]); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public Microsoft.Build.Framework.ITaskItem DestinationFolder { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(Microsoft.Build.Framework.ITaskItem); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [Microsoft.Build.Framework.OutputAttribute]
    public Microsoft.Build.Framework.ITaskItem[] MovedFiles { get { return default(Microsoft.Build.Framework.ITaskItem[]); } }
    public bool OverwriteReadOnlyFiles { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [Microsoft.Build.Framework.RequiredAttribute]
    public Microsoft.Build.Framework.ITaskItem[] SourceFiles { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(Microsoft.Build.Framework.ITaskItem[]); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public void Cancel() { }
    public override bool Execute() { return default(bool); }
  }
  [Microsoft.Build.Framework.RunInMTAAttribute]
  public partial class MSBuild : Microsoft.Build.Tasks.TaskExtension {
    public MSBuild() { }
    public bool BuildInParallel { get { return default(bool); } set { } }
    [Microsoft.Build.Framework.RequiredAttribute]
    public Microsoft.Build.Framework.ITaskItem[] Projects { get { return default(Microsoft.Build.Framework.ITaskItem[]); } set { } }
    public System.String[] Properties { get { return default(System.String[]); } set { } }
    public bool RebaseOutputs { get { return default(bool); } set { } }
    public string RemoveProperties { get { return default(string); } set { } }
    public bool RunEachTargetSeparately { get { return default(bool); } set { } }
    public string SkipNonexistentProjects { get { return default(string); } set { } }
    public bool StopOnFirstFailure { get { return default(bool); } set { } }
    public System.String[] TargetAndPropertyListSeparators { get { return default(System.String[]); } set { } }
    [Microsoft.Build.Framework.OutputAttribute]
    public Microsoft.Build.Framework.ITaskItem[] TargetOutputs { get { return default(Microsoft.Build.Framework.ITaskItem[]); } }
    public System.String[] Targets { get { return default(System.String[]); } set { } }
    public string ToolsVersion { get { return default(string); } set { } }
    public bool UnloadProjectsOnCompletion { get { return default(bool); } set { } }
    public bool UseResultsCache { get { return default(bool); } set { } }
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
    public override bool Execute() { return default(bool); }
  }
  public sealed partial class RequiresFramework35SP1Assembly : Microsoft.Build.Tasks.TaskExtension {
    public RequiresFramework35SP1Assembly() { }
    public Microsoft.Build.Framework.ITaskItem[] Assemblies { get { return default(Microsoft.Build.Framework.ITaskItem[]); } set { } }
    public bool CreateDesktopShortcut { get { return default(bool); } set { } }
    public Microsoft.Build.Framework.ITaskItem DeploymentManifestEntryPoint { get { return default(Microsoft.Build.Framework.ITaskItem); } set { } }
    public Microsoft.Build.Framework.ITaskItem EntryPoint { get { return default(Microsoft.Build.Framework.ITaskItem); } set { } }
    public string ErrorReportUrl { get { return default(string); } set { } }
    public Microsoft.Build.Framework.ITaskItem[] Files { get { return default(Microsoft.Build.Framework.ITaskItem[]); } set { } }
    public Microsoft.Build.Framework.ITaskItem[] ReferencedAssemblies { get { return default(Microsoft.Build.Framework.ITaskItem[]); } set { } }
    [Microsoft.Build.Framework.OutputAttribute]
    public bool RequiresMinimumFramework35SP1 { get { return default(bool); } set { } }
    public bool SigningManifests { get { return default(bool); } set { } }
    public string SuiteName { get { return default(string); } set { } }
    public string TargetFrameworkVersion { get { return default(string); } set { } }
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
    public bool CopyLocalDependenciesWhenParentReferenceInGac { get { return default(bool); } set { } }
    [Microsoft.Build.Framework.OutputAttribute]
    public Microsoft.Build.Framework.ITaskItem[] CopyLocalFiles { get { return default(Microsoft.Build.Framework.ITaskItem[]); } }
    [Microsoft.Build.Framework.OutputAttribute]
    public Microsoft.Build.Framework.ITaskItem[] FilesWritten { get { return default(Microsoft.Build.Framework.ITaskItem[]); } set { } }
    public bool FindDependencies { get { return default(bool); } set { } }
    public bool FindRelatedFiles { get { return default(bool); } set { } }
    public bool FindSatellites { get { return default(bool); } set { } }
    public bool FindSerializationAssemblies { get { return default(bool); } set { } }
    public Microsoft.Build.Framework.ITaskItem[] FullFrameworkAssemblyTables { get { return default(Microsoft.Build.Framework.ITaskItem[]); } set { } }
    public System.String[] FullFrameworkFolders { get { return default(System.String[]); } set { } }
    public System.String[] FullTargetFrameworkSubsetNames { get { return default(System.String[]); } set { } }
    public bool IgnoreDefaultInstalledAssemblySubsetTables { get { return default(bool); } set { } }
    public bool IgnoreDefaultInstalledAssemblyTables { get { return default(bool); } set { } }
    public bool IgnoreTargetFrameworkAttributeVersionMismatch { get { return default(bool); } set { } }
    public bool IgnoreVersionForFrameworkReferences { get { return default(bool); } set { } }
    public Microsoft.Build.Framework.ITaskItem[] InstalledAssemblySubsetTables { get { return default(Microsoft.Build.Framework.ITaskItem[]); } set { } }
    public Microsoft.Build.Framework.ITaskItem[] InstalledAssemblyTables { get { return default(Microsoft.Build.Framework.ITaskItem[]); } set { } }
    public System.String[] LatestTargetFrameworkDirectories { get { return default(System.String[]); } set { } }
    public string ProfileName { get { return default(string); } set { } }
    [Microsoft.Build.Framework.OutputAttribute]
    public Microsoft.Build.Framework.ITaskItem[] RelatedFiles { get { return default(Microsoft.Build.Framework.ITaskItem[]); } }
    [Microsoft.Build.Framework.OutputAttribute]
    public Microsoft.Build.Framework.ITaskItem[] ResolvedDependencyFiles { get { return default(Microsoft.Build.Framework.ITaskItem[]); } }
    [Microsoft.Build.Framework.OutputAttribute]
    public Microsoft.Build.Framework.ITaskItem[] ResolvedFiles { get { return default(Microsoft.Build.Framework.ITaskItem[]); } }
    public Microsoft.Build.Framework.ITaskItem[] ResolvedSDKReferences { get { return default(Microsoft.Build.Framework.ITaskItem[]); } set { } }
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
    public string TargetedRuntimeVersion { get { return default(string); } set { } }
    public System.String[] TargetFrameworkDirectories { get { return default(System.String[]); } set { } }
    public string TargetFrameworkMoniker { get { return default(string); } set { } }
    public string TargetFrameworkMonikerDisplayName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.String[] TargetFrameworkSubsets { get { return default(System.String[]); } set { } }
    public string TargetFrameworkVersion { get { return default(string); } set { } }
    public string TargetProcessorArchitecture { get { return default(string); } set { } }
    public string WarnOrErrorOnTargetArchitectureMismatch { get { return default(string); } set { } }
    public override bool Execute() { return default(bool); }
  }
  public sealed partial class ResolveComReference : Microsoft.Build.Tasks.AppDomainIsolatedTaskExtension {
    public ResolveComReference() { }
    public bool DelaySign { get { return default(bool); } set { } }
    public System.String[] EnvironmentVariables { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.String[]); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public bool ExecuteAsTool { get { return default(bool); } set { } }
    public bool IncludeVersionInInteropName { get { return default(bool); } set { } }
    public string KeyContainer { get { return default(string); } set { } }
    public string KeyFile { get { return default(string); } set { } }
    public bool NoClassMembers { get { return default(bool); } set { } }
    public Microsoft.Build.Framework.ITaskItem[] ResolvedAssemblyReferences { get { return default(Microsoft.Build.Framework.ITaskItem[]); } set { } }
    [Microsoft.Build.Framework.OutputAttribute]
    public Microsoft.Build.Framework.ITaskItem[] ResolvedFiles { get { return default(Microsoft.Build.Framework.ITaskItem[]); } set { } }
    [Microsoft.Build.Framework.OutputAttribute]
    public Microsoft.Build.Framework.ITaskItem[] ResolvedModules { get { return default(Microsoft.Build.Framework.ITaskItem[]); } set { } }
    public string SdkToolsPath { get { return default(string); } set { } }
    public bool Silent { get { return default(bool); } set { } }
    public string StateFile { get { return default(string); } set { } }
    public string TargetFrameworkVersion { get { return default(string); } set { } }
    public string TargetProcessorArchitecture { get { return default(string); } set { } }
    public Microsoft.Build.Framework.ITaskItem[] TypeLibFiles { get { return default(Microsoft.Build.Framework.ITaskItem[]); } set { } }
    public Microsoft.Build.Framework.ITaskItem[] TypeLibNames { get { return default(Microsoft.Build.Framework.ITaskItem[]); } set { } }
    public string WrapperOutputDirectory { get { return default(string); } set { } }
    public override bool Execute() { return default(bool); }
  }
  public partial class ResolveKeySource : Microsoft.Build.Tasks.TaskExtension {
    public ResolveKeySource() { }
    public int AutoClosePasswordPromptShow { get { return default(int); } set { } }
    public int AutoClosePasswordPromptTimeout { get { return default(int); } set { } }
    public string CertificateFile { get { return default(string); } set { } }
    public string CertificateThumbprint { get { return default(string); } set { } }
    public string KeyFile { get { return default(string); } set { } }
    [Microsoft.Build.Framework.OutputAttribute]
    public string ResolvedKeyContainer { get { return default(string); } set { } }
    [Microsoft.Build.Framework.OutputAttribute]
    public string ResolvedKeyFile { get { return default(string); } set { } }
    [Microsoft.Build.Framework.OutputAttribute]
    public string ResolvedThumbprint { get { return default(string); } set { } }
    public bool ShowImportDialogDespitePreviousFailures { get { return default(bool); } set { } }
    public bool SuppressAutoClosePasswordPrompt { get { return default(bool); } set { } }
    public override bool Execute() { return default(bool); }
  }
  public sealed partial class ResolveManifestFiles : Microsoft.Build.Tasks.TaskExtension {
    public ResolveManifestFiles() { }
    public Microsoft.Build.Framework.ITaskItem DeploymentManifestEntryPoint { get { return default(Microsoft.Build.Framework.ITaskItem); } set { } }
    public Microsoft.Build.Framework.ITaskItem EntryPoint { get { return default(Microsoft.Build.Framework.ITaskItem); } set { } }
    public Microsoft.Build.Framework.ITaskItem[] ExtraFiles { get { return default(Microsoft.Build.Framework.ITaskItem[]); } set { } }
    public Microsoft.Build.Framework.ITaskItem[] Files { get { return default(Microsoft.Build.Framework.ITaskItem[]); } set { } }
    public Microsoft.Build.Framework.ITaskItem[] ManagedAssemblies { get { return default(Microsoft.Build.Framework.ITaskItem[]); } set { } }
    public Microsoft.Build.Framework.ITaskItem[] NativeAssemblies { get { return default(Microsoft.Build.Framework.ITaskItem[]); } set { } }
    [Microsoft.Build.Framework.OutputAttribute]
    public Microsoft.Build.Framework.ITaskItem[] OutputAssemblies { get { return default(Microsoft.Build.Framework.ITaskItem[]); } set { } }
    [Microsoft.Build.Framework.OutputAttribute]
    public Microsoft.Build.Framework.ITaskItem OutputDeploymentManifestEntryPoint { get { return default(Microsoft.Build.Framework.ITaskItem); } set { } }
    [Microsoft.Build.Framework.OutputAttribute]
    public Microsoft.Build.Framework.ITaskItem OutputEntryPoint { get { return default(Microsoft.Build.Framework.ITaskItem); } set { } }
    [Microsoft.Build.Framework.OutputAttribute]
    public Microsoft.Build.Framework.ITaskItem[] OutputFiles { get { return default(Microsoft.Build.Framework.ITaskItem[]); } set { } }
    public Microsoft.Build.Framework.ITaskItem[] PublishFiles { get { return default(Microsoft.Build.Framework.ITaskItem[]); } set { } }
    public Microsoft.Build.Framework.ITaskItem[] SatelliteAssemblies { get { return default(Microsoft.Build.Framework.ITaskItem[]); } set { } }
    public bool SigningManifests { get { return default(bool); } set { } }
    public string TargetCulture { get { return default(string); } set { } }
    public string TargetFrameworkVersion { get { return default(string); } set { } }
    public override bool Execute() { return default(bool); }
  }
  public partial class ResolveNativeReference : Microsoft.Build.Tasks.TaskExtension {
    public ResolveNativeReference() { }
    [Microsoft.Build.Framework.RequiredAttribute]
    public System.String[] AdditionalSearchPaths { get { return default(System.String[]); } set { } }
    [Microsoft.Build.Framework.OutputAttribute]
    public Microsoft.Build.Framework.ITaskItem[] ContainedComComponents { get { return default(Microsoft.Build.Framework.ITaskItem[]); } set { } }
    [Microsoft.Build.Framework.OutputAttribute]
    public Microsoft.Build.Framework.ITaskItem[] ContainedLooseEtcFiles { get { return default(Microsoft.Build.Framework.ITaskItem[]); } set { } }
    [Microsoft.Build.Framework.OutputAttribute]
    public Microsoft.Build.Framework.ITaskItem[] ContainedLooseTlbFiles { get { return default(Microsoft.Build.Framework.ITaskItem[]); } set { } }
    [Microsoft.Build.Framework.OutputAttribute]
    public Microsoft.Build.Framework.ITaskItem[] ContainedPrerequisiteAssemblies { get { return default(Microsoft.Build.Framework.ITaskItem[]); } set { } }
    [Microsoft.Build.Framework.OutputAttribute]
    public Microsoft.Build.Framework.ITaskItem[] ContainedTypeLibraries { get { return default(Microsoft.Build.Framework.ITaskItem[]); } set { } }
    [Microsoft.Build.Framework.OutputAttribute]
    public Microsoft.Build.Framework.ITaskItem[] ContainingReferenceFiles { get { return default(Microsoft.Build.Framework.ITaskItem[]); } set { } }
    [Microsoft.Build.Framework.RequiredAttribute]
    public Microsoft.Build.Framework.ITaskItem[] NativeReferences { get { return default(Microsoft.Build.Framework.ITaskItem[]); } set { } }
    public override bool Execute() { return default(bool); }
  }
  public partial class ResolveNonMSBuildProjectOutput : Microsoft.Build.Tasks.ResolveProjectBase {
    public ResolveNonMSBuildProjectOutput() { }
    public string PreresolvedProjectOutputs { get { return default(string); } set { } }
    [Microsoft.Build.Framework.OutputAttribute]
    public Microsoft.Build.Framework.ITaskItem[] ResolvedOutputPaths { get { return default(Microsoft.Build.Framework.ITaskItem[]); } set { } }
    [Microsoft.Build.Framework.OutputAttribute]
    public Microsoft.Build.Framework.ITaskItem[] UnresolvedProjectReferences { get { return default(Microsoft.Build.Framework.ITaskItem[]); } set { } }
    public override bool Execute() { return default(bool); }
  }
  public abstract partial class ResolveProjectBase : Microsoft.Build.Tasks.TaskExtension {
    protected ResolveProjectBase() { }
    [Microsoft.Build.Framework.RequiredAttribute]
    public Microsoft.Build.Framework.ITaskItem[] ProjectReferences { get { return default(Microsoft.Build.Framework.ITaskItem[]); } set { } }
    protected void AddSyntheticProjectReferences(string currentProjectAbsolutePath) { }
    protected System.Xml.XmlElement GetProjectElement(Microsoft.Build.Framework.ITaskItem projectRef) { return default(System.Xml.XmlElement); }
    protected string GetProjectItem(Microsoft.Build.Framework.ITaskItem projectRef) { return default(string); }
  }
  public partial class ResolveSDKReference : Microsoft.Build.Tasks.TaskExtension {
    public ResolveSDKReference() { }
    [Microsoft.Build.Framework.RequiredAttribute]
    public Microsoft.Build.Framework.ITaskItem[] InstalledSDKs { get { return default(Microsoft.Build.Framework.ITaskItem[]); } set { } }
    public bool LogResolutionErrorsAsWarnings { get { return default(bool); } set { } }
    public bool Prefer32Bit { get { return default(bool); } set { } }
    public Microsoft.Build.Framework.ITaskItem[] References { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(Microsoft.Build.Framework.ITaskItem[]); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [Microsoft.Build.Framework.OutputAttribute]
    public Microsoft.Build.Framework.ITaskItem[] ResolvedSDKReferences { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(Microsoft.Build.Framework.ITaskItem[]); } }
    [Microsoft.Build.Framework.RequiredAttribute]
    public Microsoft.Build.Framework.ITaskItem[] SDKReferences { get { return default(Microsoft.Build.Framework.ITaskItem[]); } set { } }
    public string TargetedSDKArchitecture { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public string TargetedSDKConfiguration { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public override bool Execute() { return default(bool); }
  }
  public partial class SGen : Microsoft.Build.Tasks.ToolTaskExtension {
    public SGen() { }
    [Microsoft.Build.Framework.RequiredAttribute]
    public string BuildAssemblyName { get { return default(string); } set { } }
    [Microsoft.Build.Framework.RequiredAttribute]
    public string BuildAssemblyPath { get { return default(string); } set { } }
    public bool DelaySign { get { return default(bool); } set { } }
    public string KeyContainer { get { return default(string); } set { } }
    public string KeyFile { get { return default(string); } set { } }
    public string Platform { get { return default(string); } set { } }
    public System.String[] References { get { return default(System.String[]); } set { } }
    public string SdkToolsPath { get { return default(string); } set { } }
    [Microsoft.Build.Framework.OutputAttribute]
    public Microsoft.Build.Framework.ITaskItem[] SerializationAssembly { get { return default(Microsoft.Build.Framework.ITaskItem[]); } set { } }
    public string SerializationAssemblyName { get { return default(string); } }
    [Microsoft.Build.Framework.RequiredAttribute]
    public bool ShouldGenerateSerializer { get { return default(bool); } set { } }
    protected override string ToolName { get { return default(string); } }
    public System.String[] Types { get { return default(System.String[]); } set { } }
    [Microsoft.Build.Framework.RequiredAttribute]
    public bool UseProxyTypes { get { return default(bool); } set { } }
    protected override string GenerateCommandLineCommands() { return default(string); }
    protected override string GenerateFullPathToTool() { return default(string); }
    protected override bool SkipTaskExecution() { return default(bool); }
    protected override bool ValidateParameters() { return default(bool); }
  }
  public sealed partial class SignFile : Microsoft.Build.Utilities.Task {
    public SignFile() { }
    [Microsoft.Build.Framework.RequiredAttribute]
    public string CertificateThumbprint { get { return default(string); } set { } }
    [Microsoft.Build.Framework.RequiredAttribute]
    public Microsoft.Build.Framework.ITaskItem SigningTarget { get { return default(Microsoft.Build.Framework.ITaskItem); } set { } }
    public string TimestampUrl { get { return default(string); } set { } }
    public override bool Execute() { return default(bool); }
  }
  public abstract partial class TaskExtension : Microsoft.Build.Utilities.Task {
    internal TaskExtension() { }
    public new Microsoft.Build.Utilities.TaskLoggingHelper Log { get { return default(Microsoft.Build.Utilities.TaskLoggingHelper); } }
  }
  public partial class TaskLoggingHelperExtension : Microsoft.Build.Utilities.TaskLoggingHelper {
    public TaskLoggingHelperExtension(Microsoft.Build.Framework.ITask taskInstance, System.Resources.ResourceManager primaryResources, System.Resources.ResourceManager sharedResources, string helpKeywordPrefix) : base (default(Microsoft.Build.Framework.ITask)) { }
    public System.Resources.ResourceManager TaskSharedResources { get { return default(System.Resources.ResourceManager); } set { } }
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
    public UpdateManifest() { }
    [Microsoft.Build.Framework.RequiredAttribute]
    public Microsoft.Build.Framework.ITaskItem ApplicationManifest { get { return default(Microsoft.Build.Framework.ITaskItem); } set { } }
    [Microsoft.Build.Framework.RequiredAttribute]
    public string ApplicationPath { get { return default(string); } set { } }
    [Microsoft.Build.Framework.RequiredAttribute]
    public Microsoft.Build.Framework.ITaskItem InputManifest { get { return default(Microsoft.Build.Framework.ITaskItem); } set { } }
    [Microsoft.Build.Framework.OutputAttribute]
    public Microsoft.Build.Framework.ITaskItem OutputManifest { get { return default(Microsoft.Build.Framework.ITaskItem); } set { } }
    public string TargetFrameworkVersion { get { return default(string); } set { } }
    public override bool Execute() { return default(bool); }
  }
  public partial class Vbc : Microsoft.Build.Tasks.ManagedCompiler {
    public Vbc() { }
    public string BaseAddress { get { return default(string); } set { } }
    public string DisabledWarnings { get { return default(string); } set { } }
    public string DocumentationFile { get { return default(string); } set { } }
    public string ErrorReport { get { return default(string); } set { } }
    public bool GenerateDocumentation { get { return default(bool); } set { } }
    public Microsoft.Build.Framework.ITaskItem[] Imports { get { return default(Microsoft.Build.Framework.ITaskItem[]); } set { } }
    public string LangVersion { get { return default(string); } set { } }
    public string ModuleAssemblyName { get { return default(string); } set { } }
    public bool NoStandardLib { get { return default(bool); } set { } }
    public bool NoVBRuntimeReference { get { return default(bool); } set { } }
    public bool NoWarnings { get { return default(bool); } set { } }
    public string OptionCompare { get { return default(string); } set { } }
    public bool OptionExplicit { get { return default(bool); } set { } }
    public bool OptionInfer { get { return default(bool); } set { } }
    public bool OptionStrict { get { return default(bool); } set { } }
    public string OptionStrictType { get { return default(string); } set { } }
    public string PdbFile { get { return default(string); } set { } }
    public bool RemoveIntegerChecks { get { return default(bool); } set { } }
    public string RootNamespace { get { return default(string); } set { } }
    public string SdkPath { get { return default(string); } set { } }
    public bool TargetCompactFramework { get { return default(bool); } set { } }
    protected override string ToolName { get { return default(string); } }
    public bool UseHostCompilerIfAvailable { get { return default(bool); } set { } }
    public string VBRuntime { get { return default(string); } set { } }
    public string VBRuntimePath { get { return default(string); } set { } }
    public string Verbosity { get { return default(string); } set { } }
    public string WarningsAsErrors { get { return default(string); } set { } }
    public string WarningsNotAsErrors { get { return default(string); } set { } }
    protected internal override void AddResponseFileCommands(Microsoft.Build.Tasks.CommandLineBuilderExtension commandLine) { }
    protected override bool CallHostObjectToExecute() { return default(bool); }
    public override bool Execute() { return default(bool); }
    protected override string GenerateFullPathToTool() { return default(string); }
    protected override Microsoft.Build.Utilities.HostObjectInitializationStatus InitializeHostObject() { return default(Microsoft.Build.Utilities.HostObjectInitializationStatus); }
    protected override void LogEventsFromTextOutput(string singleLine, Microsoft.Build.Framework.MessageImportance messageImportance) { }
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
  public partial class WinMDExp : Microsoft.Build.Tasks.ToolTaskExtension {
    public WinMDExp() { }
    public string DisabledWarnings { get { return default(string); } set { } }
    public string InputDocumentationFile { get { return default(string); } set { } }
    public string InputPDBFile { get { return default(string); } set { } }
    public string OutputDocumentationFile { get { return default(string); } set { } }
    public string OutputPDBFile { get { return default(string); } set { } }
    [Microsoft.Build.Framework.OutputAttribute]
    public string OutputWindowsMetadataFile { get { return default(string); } set { } }
    [Microsoft.Build.Framework.RequiredAttribute]
    public Microsoft.Build.Framework.ITaskItem[] References { get { return default(Microsoft.Build.Framework.ITaskItem[]); } set { } }
    public string SdkToolsPath { get { return default(string); } set { } }
    protected override System.Text.Encoding StandardErrorEncoding { get { return default(System.Text.Encoding); } }
    protected override System.Text.Encoding StandardOutputEncoding { get { return default(System.Text.Encoding); } }
    protected override string ToolName { get { return default(string); } }
    public bool TreatWarningsAsErrors { get { return default(bool); } set { } }
    public bool UTF8Output { get { return default(bool); } set { } }
    [Microsoft.Build.Framework.RequiredAttribute]
    public string WinMDModule { get { return default(string); } set { } }
    protected internal override void AddCommandLineCommands(Microsoft.Build.Tasks.CommandLineBuilderExtension commandLine) { }
    protected override string GenerateFullPathToTool() { return default(string); }
    protected override bool SkipTaskExecution() { return default(bool); }
    protected override bool ValidateParameters() { return default(bool); }
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
    public string Encoding { get { return default(string); } set { } }
    [Microsoft.Build.Framework.RequiredAttribute]
    public Microsoft.Build.Framework.ITaskItem File { get { return default(Microsoft.Build.Framework.ITaskItem); } set { } }
    public Microsoft.Build.Framework.ITaskItem[] Lines { get { return default(Microsoft.Build.Framework.ITaskItem[]); } set { } }
    public bool Overwrite { get { return default(bool); } set { } }
    public override bool Execute() { return default(bool); }
  }
  public partial class XamlTaskFactory : Microsoft.Build.Framework.ITaskFactory {
    public XamlTaskFactory() { }
    public string FactoryName { get { return default(string); } }
    public string TaskElementContents { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
    public string TaskName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
    public string TaskNamespace { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
    public System.Type TaskType { get { return default(System.Type); } }
    public void CleanupTask(Microsoft.Build.Framework.ITask task) { }
    public Microsoft.Build.Framework.ITask CreateTask(Microsoft.Build.Framework.IBuildEngine taskFactoryLoggingHost) { return default(Microsoft.Build.Framework.ITask); }
    public Microsoft.Build.Framework.TaskPropertyInfo[] GetTaskParameters() { return default(Microsoft.Build.Framework.TaskPropertyInfo[]); }
    public bool Initialize(string taskName, System.Collections.Generic.IDictionary<System.String, Microsoft.Build.Framework.TaskPropertyInfo> taskParameters, string taskElementContents, Microsoft.Build.Framework.IBuildEngine taskFactoryLoggingHost) { return default(bool); }
  }
  public partial class XmlPeek : Microsoft.Build.Tasks.TaskExtension {
    public XmlPeek() { }
    public string Namespaces { get { return default(string); } set { } }
    public string Query { get { return default(string); } set { } }
    [Microsoft.Build.Framework.OutputAttribute]
    public Microsoft.Build.Framework.ITaskItem[] Result { get { return default(Microsoft.Build.Framework.ITaskItem[]); } }
    public string XmlContent { get { return default(string); } set { } }
    public Microsoft.Build.Framework.ITaskItem XmlInputPath { get { return default(Microsoft.Build.Framework.ITaskItem); } set { } }
    public override bool Execute() { return default(bool); }
  }
  public partial class XmlPoke : Microsoft.Build.Tasks.TaskExtension {
    public XmlPoke() { }
    public string Namespaces { get { return default(string); } set { } }
    public string Query { get { return default(string); } set { } }
    [Microsoft.Build.Framework.RequiredAttribute]
    public Microsoft.Build.Framework.ITaskItem Value { get { return default(Microsoft.Build.Framework.ITaskItem); } set { } }
    public Microsoft.Build.Framework.ITaskItem XmlInputPath { get { return default(Microsoft.Build.Framework.ITaskItem); } set { } }
    public override bool Execute() { return default(bool); }
  }
  public partial class XslTransformation : Microsoft.Build.Tasks.TaskExtension {
    public XslTransformation() { }
    [Microsoft.Build.Framework.RequiredAttribute]
    public Microsoft.Build.Framework.ITaskItem[] OutputPaths { get { return default(Microsoft.Build.Framework.ITaskItem[]); } set { } }
    public string Parameters { get { return default(string); } set { } }
    public string XmlContent { get { return default(string); } set { } }
    public Microsoft.Build.Framework.ITaskItem[] XmlInputPaths { get { return default(Microsoft.Build.Framework.ITaskItem[]); } set { } }
    public Microsoft.Build.Framework.ITaskItem XslCompiledDllPath { get { return default(Microsoft.Build.Framework.ITaskItem); } set { } }
    public string XslContent { get { return default(string); } set { } }
    public Microsoft.Build.Framework.ITaskItem XslInputPath { get { return default(Microsoft.Build.Framework.ITaskItem); } set { } }
    public override bool Execute() { return default(bool); }
  }
}
namespace Microsoft.Build.Tasks.Deployment.Bootstrapper {
  [System.Runtime.InteropServices.ClassInterfaceAttribute((System.Runtime.InteropServices.ClassInterfaceType)(0))]
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  [System.Runtime.InteropServices.GuidAttribute("1D9FE38A-0226-4b95-9C6B-6DFFA2236270")]
  public partial class BootstrapperBuilder : Microsoft.Build.Tasks.Deployment.Bootstrapper.IBootstrapperBuilder {
    public BootstrapperBuilder() { }
    public BootstrapperBuilder(string visualStudioVersion) { }
    public string Path { get { return default(string); } set { } }
    public Microsoft.Build.Tasks.Deployment.Bootstrapper.ProductCollection Products { get { return default(Microsoft.Build.Tasks.Deployment.Bootstrapper.ProductCollection); } }
    public Microsoft.Build.Tasks.Deployment.Bootstrapper.BuildResults Build(Microsoft.Build.Tasks.Deployment.Bootstrapper.BuildSettings settings) { return default(Microsoft.Build.Tasks.Deployment.Bootstrapper.BuildResults); }
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
    public bool ApplicationRequiresElevation { get { return default(bool); } set { } }
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
    [System.Runtime.InteropServices.DispIdAttribute(1)]
    string Path { get; set; }
    [System.Runtime.InteropServices.DispIdAttribute(4)]
    Microsoft.Build.Tasks.Deployment.Bootstrapper.ProductCollection Products { get; }
    [System.Runtime.InteropServices.DispIdAttribute(5)]
    Microsoft.Build.Tasks.Deployment.Bootstrapper.BuildResults Build(Microsoft.Build.Tasks.Deployment.Bootstrapper.BuildSettings settings);
  }
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  [System.Runtime.InteropServices.GuidAttribute("E3C981EA-99E6-4f48-8955-1AAFDFB5ACE4")]
  [System.Runtime.InteropServices.InterfaceTypeAttribute((System.Runtime.InteropServices.ComInterfaceType)(0))]
  public partial interface IBuildMessage {
    [System.Runtime.InteropServices.DispIdAttribute(4)]
    int HelpId { get; }
    [System.Runtime.InteropServices.DispIdAttribute(3)]
    string HelpKeyword { get; }
    [System.Runtime.InteropServices.DispIdAttribute(2)]
    string Message { get; }
    [System.Runtime.InteropServices.DispIdAttribute(1)]
    Microsoft.Build.Tasks.Deployment.Bootstrapper.BuildMessageSeverity Severity { get; }
  }
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  [System.Runtime.InteropServices.GuidAttribute("586B842C-D9C7-43b8-84E4-9CFC3AF9F13B")]
  [System.Runtime.InteropServices.InterfaceTypeAttribute((System.Runtime.InteropServices.ComInterfaceType)(0))]
  public partial interface IBuildResults {
    [System.Runtime.InteropServices.DispIdAttribute(3)]
    System.String[] ComponentFiles { get; }
    [System.Runtime.InteropServices.DispIdAttribute(2)]
    string KeyFile { get; }
    [System.Runtime.InteropServices.DispIdAttribute(4)]
    Microsoft.Build.Tasks.Deployment.Bootstrapper.BuildMessage[] Messages { get; }
    [System.Runtime.InteropServices.DispIdAttribute(1)]
    bool Succeeded { get; }
  }
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  [System.Runtime.InteropServices.GuidAttribute("87EEBC69-0948-4ce6-A2DE-819162B87CC6")]
  [System.Runtime.InteropServices.InterfaceTypeAttribute((System.Runtime.InteropServices.ComInterfaceType)(0))]
  public partial interface IBuildSettings {
    [System.Runtime.InteropServices.DispIdAttribute(2)]
    string ApplicationFile { get; set; }
    [System.Runtime.InteropServices.DispIdAttribute(1)]
    string ApplicationName { get; set; }
    [System.Runtime.InteropServices.DispIdAttribute(13)]
    bool ApplicationRequiresElevation { get; set; }
    [System.Runtime.InteropServices.DispIdAttribute(3)]
    string ApplicationUrl { get; set; }
    [System.Runtime.InteropServices.DispIdAttribute(11)]
    Microsoft.Build.Tasks.Deployment.Bootstrapper.ComponentsLocation ComponentsLocation { get; set; }
    [System.Runtime.InteropServices.DispIdAttribute(4)]
    string ComponentsUrl { get; set; }
    [System.Runtime.InteropServices.DispIdAttribute(5)]
    bool CopyComponents { get; set; }
    [System.Runtime.InteropServices.DispIdAttribute(7)]
    int FallbackLCID { get; set; }
    [System.Runtime.InteropServices.DispIdAttribute(6)]
    int LCID { get; set; }
    [System.Runtime.InteropServices.DispIdAttribute(8)]
    string OutputPath { get; set; }
    [System.Runtime.InteropServices.DispIdAttribute(9)]
    Microsoft.Build.Tasks.Deployment.Bootstrapper.ProductBuilderCollection ProductBuilders { get; }
    [System.Runtime.InteropServices.DispIdAttribute(12)]
    string SupportUrl { get; set; }
    [System.Runtime.InteropServices.DispIdAttribute(10)]
    bool Validate { get; set; }
  }
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  [System.Runtime.InteropServices.GuidAttribute("9E81BE3D-530F-4a10-8349-5D5947BA59AD")]
  [System.Runtime.InteropServices.InterfaceTypeAttribute((System.Runtime.InteropServices.ComInterfaceType)(0))]
  public partial interface IProduct {
    [System.Runtime.InteropServices.DispIdAttribute(4)]
    Microsoft.Build.Tasks.Deployment.Bootstrapper.ProductCollection Includes { get; }
    [System.Runtime.InteropServices.DispIdAttribute(2)]
    string Name { get; }
    [System.Runtime.InteropServices.DispIdAttribute(1)]
    Microsoft.Build.Tasks.Deployment.Bootstrapper.ProductBuilder ProductBuilder { get; }
    [System.Runtime.InteropServices.DispIdAttribute(3)]
    string ProductCode { get; }
  }
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  [System.Runtime.InteropServices.GuidAttribute("0777432F-A60D-48b3-83DB-90326FE8C96E")]
  [System.Runtime.InteropServices.InterfaceTypeAttribute((System.Runtime.InteropServices.ComInterfaceType)(0))]
  public partial interface IProductBuilder {
    [System.Runtime.InteropServices.DispIdAttribute(1)]
    Microsoft.Build.Tasks.Deployment.Bootstrapper.Product Product { get; }
  }
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  [System.Runtime.InteropServices.GuidAttribute("0D593FC0-E3F1-4dad-A674-7EA4D327F79B")]
  [System.Runtime.InteropServices.InterfaceTypeAttribute((System.Runtime.InteropServices.ComInterfaceType)(0))]
  public partial interface IProductBuilderCollection {
    [System.Runtime.InteropServices.DispIdAttribute(2)]
    void Add(Microsoft.Build.Tasks.Deployment.Bootstrapper.ProductBuilder builder);
  }
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  [System.Runtime.InteropServices.GuidAttribute("63F63663-8503-4875-814C-09168E595367")]
  [System.Runtime.InteropServices.InterfaceTypeAttribute((System.Runtime.InteropServices.ComInterfaceType)(0))]
  public partial interface IProductCollection {
    [System.Runtime.InteropServices.DispIdAttribute(1)]
    int Count { get; }
    [System.Runtime.InteropServices.DispIdAttribute(2)]
    Microsoft.Build.Tasks.Deployment.Bootstrapper.Product Item(int index);
    [System.Runtime.InteropServices.DispIdAttribute(3)]
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
    public void Add(Microsoft.Build.Tasks.Deployment.Bootstrapper.ProductBuilder builder) { }
    public System.Collections.IEnumerator GetEnumerator() { return default(System.Collections.IEnumerator); }
  }
  [System.Runtime.InteropServices.ClassInterfaceAttribute((System.Runtime.InteropServices.ClassInterfaceType)(0))]
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  [System.Runtime.InteropServices.GuidAttribute("EFFA164B-3E87-4195-88DB-8AC004DDFE2A")]
  public partial class ProductCollection : Microsoft.Build.Tasks.Deployment.Bootstrapper.IProductCollection, System.Collections.IEnumerable {
    internal ProductCollection() { }
    public int Count { get { return default(int); } }
    public System.Collections.IEnumerator GetEnumerator() { return default(System.Collections.IEnumerator); }
    public Microsoft.Build.Tasks.Deployment.Bootstrapper.Product Item(int index) { return default(Microsoft.Build.Tasks.Deployment.Bootstrapper.Product); }
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
  [System.Xml.Serialization.XmlRootAttribute("ApplicationManifest")]
  public sealed partial class ApplicationManifest : Microsoft.Build.Tasks.Deployment.ManifestUtilities.AssemblyManifest {
    public ApplicationManifest() { }
    public ApplicationManifest(string targetFrameworkVersion) { }
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public string ConfigFile { get { return default(string); } set { } }
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public override Microsoft.Build.Tasks.Deployment.ManifestUtilities.AssemblyReference EntryPoint { get { return default(Microsoft.Build.Tasks.Deployment.ManifestUtilities.AssemblyReference); } set { } }
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public string ErrorReportUrl { get { return default(string); } set { } }
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public Microsoft.Build.Tasks.Deployment.ManifestUtilities.FileAssociationCollection FileAssociations { get { return default(Microsoft.Build.Tasks.Deployment.ManifestUtilities.FileAssociationCollection); } }
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public bool HostInBrowser { get { return default(bool); } set { } }
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public string IconFile { get { return default(string); } set { } }
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public bool IsClickOnceManifest { get { return default(bool); } set { } }
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public int MaxTargetPath { get { return default(int); } set { } }
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public string OSDescription { get { return default(string); } set { } }
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public string OSSupportUrl { get { return default(string); } set { } }
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public string OSVersion { get { return default(string); } set { } }
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public string Product { get { return default(string); } set { } }
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public string Publisher { get { return default(string); } set { } }
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public string SuiteName { get { return default(string); } set { } }
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public string SupportUrl { get { return default(string); } set { } }
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public string TargetFrameworkVersion { get { return default(string); } set { } }
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public Microsoft.Build.Tasks.Deployment.ManifestUtilities.TrustInfo TrustInfo { get { return default(Microsoft.Build.Tasks.Deployment.ManifestUtilities.TrustInfo); } set { } }
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public bool UseApplicationTrust { get { return default(bool); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.Xml.Serialization.XmlAttributeAttribute("ConfigFile")]
    public string XmlConfigFile { get { return default(string); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.Xml.Serialization.XmlElementAttribute("EntryPointIdentity")]
    public Microsoft.Build.Tasks.Deployment.ManifestUtilities.AssemblyIdentity XmlEntryPointIdentity { get { return default(Microsoft.Build.Tasks.Deployment.ManifestUtilities.AssemblyIdentity); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.Xml.Serialization.XmlAttributeAttribute("EntryPointParameters")]
    public string XmlEntryPointParameters { get { return default(string); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.Xml.Serialization.XmlAttributeAttribute("EntryPointPath")]
    public string XmlEntryPointPath { get { return default(string); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.Xml.Serialization.XmlAttributeAttribute("ErrorReportUrl")]
    public string XmlErrorReportUrl { get { return default(string); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.Xml.Serialization.XmlArrayAttribute("FileAssociations")]
    public Microsoft.Build.Tasks.Deployment.ManifestUtilities.FileAssociation[] XmlFileAssociations { get { return default(Microsoft.Build.Tasks.Deployment.ManifestUtilities.FileAssociation[]); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.Xml.Serialization.XmlAttributeAttribute("HostInBrowser")]
    public string XmlHostInBrowser { get { return default(string); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.Xml.Serialization.XmlAttributeAttribute("IconFile")]
    public string XmlIconFile { get { return default(string); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.Xml.Serialization.XmlAttributeAttribute("IsClickOnceManifest")]
    public string XmlIsClickOnceManifest { get { return default(string); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.Xml.Serialization.XmlAttributeAttribute("OSBuild")]
    public string XmlOSBuild { get { return default(string); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.Xml.Serialization.XmlAttributeAttribute("OSDescription")]
    public string XmlOSDescription { get { return default(string); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.Xml.Serialization.XmlAttributeAttribute("OSMajor")]
    public string XmlOSMajor { get { return default(string); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.Xml.Serialization.XmlAttributeAttribute("OSMinor")]
    public string XmlOSMinor { get { return default(string); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.Xml.Serialization.XmlAttributeAttribute("OSRevision")]
    public string XmlOSRevision { get { return default(string); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.Xml.Serialization.XmlAttributeAttribute("OSSupportUrl")]
    public string XmlOSSupportUrl { get { return default(string); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.Xml.Serialization.XmlAttributeAttribute("Product")]
    public string XmlProduct { get { return default(string); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.Xml.Serialization.XmlAttributeAttribute("Publisher")]
    public string XmlPublisher { get { return default(string); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.Xml.Serialization.XmlAttributeAttribute("SuiteName")]
    public string XmlSuiteName { get { return default(string); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.Xml.Serialization.XmlAttributeAttribute("SupportUrl")]
    public string XmlSupportUrl { get { return default(string); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.Xml.Serialization.XmlAttributeAttribute("UseApplicationTrust")]
    public string XmlUseApplicationTrust { get { return default(string); } set { } }
    public override void Validate() { }
  }
  [System.Runtime.InteropServices.ComVisibleAttribute(false)]
  [System.Xml.Serialization.XmlRootAttribute("AssemblyIdentity")]
  public sealed partial class AssemblyIdentity {
    public AssemblyIdentity() { }
    public AssemblyIdentity(Microsoft.Build.Tasks.Deployment.ManifestUtilities.AssemblyIdentity identity) { }
    public AssemblyIdentity(string name) { }
    public AssemblyIdentity(string name, string version) { }
    public AssemblyIdentity(string name, string version, string publicKeyToken, string culture) { }
    public AssemblyIdentity(string name, string version, string publicKeyToken, string culture, string processorArchitecture) { }
    public AssemblyIdentity(string name, string version, string publicKeyToken, string culture, string processorArchitecture, string type) { }
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public string Culture { get { return default(string); } set { } }
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public bool IsFrameworkAssembly { get { return default(bool); } }
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public bool IsNeutralPlatform { get { return default(bool); } }
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public bool IsStrongName { get { return default(bool); } }
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public string Name { get { return default(string); } set { } }
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public string ProcessorArchitecture { get { return default(string); } set { } }
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public string PublicKeyToken { get { return default(string); } set { } }
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public string Type { get { return default(string); } set { } }
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public string Version { get { return default(string); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.Xml.Serialization.XmlAttributeAttribute("Culture")]
    public string XmlCulture { get { return default(string); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.Xml.Serialization.XmlAttributeAttribute("Name")]
    public string XmlName { get { return default(string); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.Xml.Serialization.XmlAttributeAttribute("ProcessorArchitecture")]
    public string XmlProcessorArchitecture { get { return default(string); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.Xml.Serialization.XmlAttributeAttribute("PublicKeyToken")]
    public string XmlPublicKeyToken { get { return default(string); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.Xml.Serialization.XmlAttributeAttribute("Type")]
    public string XmlType { get { return default(string); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.Xml.Serialization.XmlAttributeAttribute("Version")]
    public string XmlVersion { get { return default(string); } set { } }
    public static Microsoft.Build.Tasks.Deployment.ManifestUtilities.AssemblyIdentity FromAssemblyName(string assemblyName) { return default(Microsoft.Build.Tasks.Deployment.ManifestUtilities.AssemblyIdentity); }
    public static Microsoft.Build.Tasks.Deployment.ManifestUtilities.AssemblyIdentity FromFile(string path) { return default(Microsoft.Build.Tasks.Deployment.ManifestUtilities.AssemblyIdentity); }
    public static Microsoft.Build.Tasks.Deployment.ManifestUtilities.AssemblyIdentity FromManagedAssembly(string path) { return default(Microsoft.Build.Tasks.Deployment.ManifestUtilities.AssemblyIdentity); }
    public static Microsoft.Build.Tasks.Deployment.ManifestUtilities.AssemblyIdentity FromManifest(string path) { return default(Microsoft.Build.Tasks.Deployment.ManifestUtilities.AssemblyIdentity); }
    public static Microsoft.Build.Tasks.Deployment.ManifestUtilities.AssemblyIdentity FromNativeAssembly(string path) { return default(Microsoft.Build.Tasks.Deployment.ManifestUtilities.AssemblyIdentity); }
    public string GetFullName(Microsoft.Build.Tasks.Deployment.ManifestUtilities.AssemblyIdentity.FullNameFlags flags) { return default(string); }
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
  [System.Xml.Serialization.XmlRootAttribute("AssemblyManifest")]
  public partial class AssemblyManifest : Microsoft.Build.Tasks.Deployment.ManifestUtilities.Manifest {
    public AssemblyManifest() { }
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public Microsoft.Build.Tasks.Deployment.ManifestUtilities.ProxyStub[] ExternalProxyStubs { get { return default(Microsoft.Build.Tasks.Deployment.ManifestUtilities.ProxyStub[]); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.Xml.Serialization.XmlArrayAttribute("ExternalProxyStubs")]
    public Microsoft.Build.Tasks.Deployment.ManifestUtilities.ProxyStub[] XmlExternalProxyStubs { get { return default(Microsoft.Build.Tasks.Deployment.ManifestUtilities.ProxyStub[]); } set { } }
  }
  [System.Runtime.InteropServices.ComVisibleAttribute(false)]
  public sealed partial class AssemblyReference : Microsoft.Build.Tasks.Deployment.ManifestUtilities.BaseReference {
    public AssemblyReference() { }
    public AssemblyReference(string path) { }
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public Microsoft.Build.Tasks.Deployment.ManifestUtilities.AssemblyIdentity AssemblyIdentity { get { return default(Microsoft.Build.Tasks.Deployment.ManifestUtilities.AssemblyIdentity); } set { } }
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public bool IsPrerequisite { get { return default(bool); } set { } }
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public Microsoft.Build.Tasks.Deployment.ManifestUtilities.AssemblyReferenceType ReferenceType { get { return default(Microsoft.Build.Tasks.Deployment.ManifestUtilities.AssemblyReferenceType); } set { } }
    protected internal override string SortName { get { return default(string); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.Xml.Serialization.XmlElementAttribute("AssemblyIdentity")]
    public Microsoft.Build.Tasks.Deployment.ManifestUtilities.AssemblyIdentity XmlAssemblyIdentity { get { return default(Microsoft.Build.Tasks.Deployment.ManifestUtilities.AssemblyIdentity); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.Xml.Serialization.XmlAttributeAttribute("IsNative")]
    public string XmlIsNative { get { return default(string); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.Xml.Serialization.XmlAttributeAttribute("IsPrerequisite")]
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
    protected internal BaseReference() { }
    protected internal BaseReference(string path) { }
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public string Group { get { return default(string); } set { } }
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public string Hash { get { return default(string); } set { } }
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public bool IsOptional { get { return default(bool); } set { } }
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public string ResolvedPath { get { return default(string); } set { } }
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public long Size { get { return default(long); } set { } }
    protected internal abstract string SortName { get; }
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public string SourcePath { get { return default(string); } set { } }
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public string TargetPath { get { return default(string); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.Xml.Serialization.XmlAttributeAttribute("Group")]
    public string XmlGroup { get { return default(string); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.Xml.Serialization.XmlAttributeAttribute("Hash")]
    public string XmlHash { get { return default(string); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.Xml.Serialization.XmlAttributeAttribute("HashAlg")]
    public string XmlHashAlgorithm { get { return default(string); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.Xml.Serialization.XmlAttributeAttribute("IsOptional")]
    public string XmlIsOptional { get { return default(string); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.Xml.Serialization.XmlAttributeAttribute("Path")]
    public string XmlPath { get { return default(string); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.Xml.Serialization.XmlAttributeAttribute("Size")]
    public string XmlSize { get { return default(string); } set { } }
    public override string ToString() { return default(string); }
  }
  [System.Runtime.InteropServices.ComVisibleAttribute(false)]
  public partial class ComClass {
    public ComClass() { }
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public string ClsId { get { return default(string); } }
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public string Description { get { return default(string); } }
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public string ProgId { get { return default(string); } }
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public string ThreadingModel { get { return default(string); } }
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public string TlbId { get { return default(string); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.Xml.Serialization.XmlAttributeAttribute("Clsid")]
    public string XmlClsId { get { return default(string); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.Xml.Serialization.XmlAttributeAttribute("Description")]
    public string XmlDescription { get { return default(string); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.Xml.Serialization.XmlAttributeAttribute("Progid")]
    public string XmlProgId { get { return default(string); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.Xml.Serialization.XmlAttributeAttribute("ThreadingModel")]
    public string XmlThreadingModel { get { return default(string); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.Xml.Serialization.XmlAttributeAttribute("Tlbid")]
    public string XmlTlbId { get { return default(string); } set { } }
  }
  [System.Runtime.InteropServices.ComVisibleAttribute(false)]
  public sealed partial class CompatibleFramework {
    public CompatibleFramework() { }
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public string Profile { get { return default(string); } set { } }
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public string SupportedRuntime { get { return default(string); } set { } }
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public string Version { get { return default(string); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.Xml.Serialization.XmlAttributeAttribute("Profile")]
    public string XmlProfile { get { return default(string); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.Xml.Serialization.XmlAttributeAttribute("SupportedRuntime")]
    public string XmlSupportedRuntime { get { return default(string); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.Xml.Serialization.XmlAttributeAttribute("Version")]
    public string XmlVersion { get { return default(string); } set { } }
  }
  [System.Runtime.InteropServices.ComVisibleAttribute(false)]
  public sealed partial class CompatibleFrameworkCollection : System.Collections.IEnumerable {
    internal CompatibleFrameworkCollection() { }
    public int Count { get { return default(int); } }
    public Microsoft.Build.Tasks.Deployment.ManifestUtilities.CompatibleFramework this[int index] { get { return default(Microsoft.Build.Tasks.Deployment.ManifestUtilities.CompatibleFramework); } }
    public void Add(Microsoft.Build.Tasks.Deployment.ManifestUtilities.CompatibleFramework compatibleFramework) { }
    public void Clear() { }
    public System.Collections.IEnumerator GetEnumerator() { return default(System.Collections.IEnumerator); }
  }
  [System.Runtime.InteropServices.ComVisibleAttribute(false)]
  [System.Xml.Serialization.XmlRootAttribute("DeployManifest")]
  public sealed partial class DeployManifest : Microsoft.Build.Tasks.Deployment.ManifestUtilities.Manifest {
    public DeployManifest() { }
    public DeployManifest(string targetFrameworkMoniker) { }
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public Microsoft.Build.Tasks.Deployment.ManifestUtilities.CompatibleFrameworkCollection CompatibleFrameworks { get { return default(Microsoft.Build.Tasks.Deployment.ManifestUtilities.CompatibleFrameworkCollection); } }
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public bool CreateDesktopShortcut { get { return default(bool); } set { } }
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public string DeploymentUrl { get { return default(string); } set { } }
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public bool DisallowUrlActivation { get { return default(bool); } set { } }
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public override Microsoft.Build.Tasks.Deployment.ManifestUtilities.AssemblyReference EntryPoint { get { return default(Microsoft.Build.Tasks.Deployment.ManifestUtilities.AssemblyReference); } set { } }
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public string ErrorReportUrl { get { return default(string); } set { } }
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public bool Install { get { return default(bool); } set { } }
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public bool MapFileExtensions { get { return default(bool); } set { } }
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public string MinimumRequiredVersion { get { return default(string); } set { } }
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public string Product { get { return default(string); } set { } }
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public string Publisher { get { return default(string); } set { } }
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public string SuiteName { get { return default(string); } set { } }
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public string SupportUrl { get { return default(string); } set { } }
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public string TargetFrameworkMoniker { get { return default(string); } set { } }
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public bool TrustUrlParameters { get { return default(bool); } set { } }
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public bool UpdateEnabled { get { return default(bool); } set { } }
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public int UpdateInterval { get { return default(int); } set { } }
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public Microsoft.Build.Tasks.Deployment.ManifestUtilities.UpdateMode UpdateMode { get { return default(Microsoft.Build.Tasks.Deployment.ManifestUtilities.UpdateMode); } set { } }
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public Microsoft.Build.Tasks.Deployment.ManifestUtilities.UpdateUnit UpdateUnit { get { return default(Microsoft.Build.Tasks.Deployment.ManifestUtilities.UpdateUnit); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.Xml.Serialization.XmlArrayAttribute("CompatibleFrameworks")]
    public Microsoft.Build.Tasks.Deployment.ManifestUtilities.CompatibleFramework[] XmlCompatibleFrameworks { get { return default(Microsoft.Build.Tasks.Deployment.ManifestUtilities.CompatibleFramework[]); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.Xml.Serialization.XmlAttributeAttribute("CreateDesktopShortcut")]
    public string XmlCreateDesktopShortcut { get { return default(string); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.Xml.Serialization.XmlAttributeAttribute("DeploymentUrl")]
    public string XmlDeploymentUrl { get { return default(string); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.Xml.Serialization.XmlAttributeAttribute("DisallowUrlActivation")]
    public string XmlDisallowUrlActivation { get { return default(string); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.Xml.Serialization.XmlAttributeAttribute("ErrorReportUrl")]
    public string XmlErrorReportUrl { get { return default(string); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.Xml.Serialization.XmlAttributeAttribute("Install")]
    public string XmlInstall { get { return default(string); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.Xml.Serialization.XmlAttributeAttribute("MapFileExtensions")]
    public string XmlMapFileExtensions { get { return default(string); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.Xml.Serialization.XmlAttributeAttribute("MinimumRequiredVersion")]
    public string XmlMinimumRequiredVersion { get { return default(string); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.Xml.Serialization.XmlAttributeAttribute("Product")]
    public string XmlProduct { get { return default(string); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.Xml.Serialization.XmlAttributeAttribute("Publisher")]
    public string XmlPublisher { get { return default(string); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.Xml.Serialization.XmlAttributeAttribute("SuiteName")]
    public string XmlSuiteName { get { return default(string); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.Xml.Serialization.XmlAttributeAttribute("SupportUrl")]
    public string XmlSupportUrl { get { return default(string); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.Xml.Serialization.XmlAttributeAttribute("TrustUrlParameters")]
    public string XmlTrustUrlParameters { get { return default(string); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.Xml.Serialization.XmlAttributeAttribute("UpdateEnabled")]
    public string XmlUpdateEnabled { get { return default(string); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.Xml.Serialization.XmlAttributeAttribute("UpdateInterval")]
    public string XmlUpdateInterval { get { return default(string); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.Xml.Serialization.XmlAttributeAttribute("UpdateMode")]
    public string XmlUpdateMode { get { return default(string); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.Xml.Serialization.XmlAttributeAttribute("UpdateUnit")]
    public string XmlUpdateUnit { get { return default(string); } set { } }
    public override void Validate() { }
  }
  [System.Runtime.InteropServices.ComVisibleAttribute(false)]
  public sealed partial class FileAssociation {
    public FileAssociation() { }
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public string DefaultIcon { get { return default(string); } set { } }
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public string Description { get { return default(string); } set { } }
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public string Extension { get { return default(string); } set { } }
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public string ProgId { get { return default(string); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.Xml.Serialization.XmlAttributeAttribute("DefaultIcon")]
    public string XmlDefaultIcon { get { return default(string); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.Xml.Serialization.XmlAttributeAttribute("Description")]
    public string XmlDescription { get { return default(string); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.Xml.Serialization.XmlAttributeAttribute("Extension")]
    public string XmlExtension { get { return default(string); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.Xml.Serialization.XmlAttributeAttribute("Progid")]
    public string XmlProgId { get { return default(string); } set { } }
  }
  [System.Runtime.InteropServices.ComVisibleAttribute(false)]
  public sealed partial class FileAssociationCollection : System.Collections.IEnumerable {
    internal FileAssociationCollection() { }
    public int Count { get { return default(int); } }
    public Microsoft.Build.Tasks.Deployment.ManifestUtilities.FileAssociation this[int index] { get { return default(Microsoft.Build.Tasks.Deployment.ManifestUtilities.FileAssociation); } }
    public void Add(Microsoft.Build.Tasks.Deployment.ManifestUtilities.FileAssociation fileAssociation) { }
    public void Clear() { }
    public System.Collections.IEnumerator GetEnumerator() { return default(System.Collections.IEnumerator); }
  }
  [System.Runtime.InteropServices.ComVisibleAttribute(false)]
  public sealed partial class FileReference : Microsoft.Build.Tasks.Deployment.ManifestUtilities.BaseReference {
    public FileReference() { }
    public FileReference(string path) { }
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public Microsoft.Build.Tasks.Deployment.ManifestUtilities.ComClass[] ComClasses { get { return default(Microsoft.Build.Tasks.Deployment.ManifestUtilities.ComClass[]); } }
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public bool IsDataFile { get { return default(bool); } set { } }
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public Microsoft.Build.Tasks.Deployment.ManifestUtilities.ProxyStub[] ProxyStubs { get { return default(Microsoft.Build.Tasks.Deployment.ManifestUtilities.ProxyStub[]); } }
    protected internal override string SortName { get { return default(string); } }
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public Microsoft.Build.Tasks.Deployment.ManifestUtilities.TypeLib[] TypeLibs { get { return default(Microsoft.Build.Tasks.Deployment.ManifestUtilities.TypeLib[]); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.Xml.Serialization.XmlArrayAttribute("ComClasses")]
    public Microsoft.Build.Tasks.Deployment.ManifestUtilities.ComClass[] XmlComClasses { get { return default(Microsoft.Build.Tasks.Deployment.ManifestUtilities.ComClass[]); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.Xml.Serialization.XmlArrayAttribute("ProxyStubs")]
    public Microsoft.Build.Tasks.Deployment.ManifestUtilities.ProxyStub[] XmlProxyStubs { get { return default(Microsoft.Build.Tasks.Deployment.ManifestUtilities.ProxyStub[]); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.Xml.Serialization.XmlArrayAttribute("TypeLibs")]
    public Microsoft.Build.Tasks.Deployment.ManifestUtilities.TypeLib[] XmlTypeLibs { get { return default(Microsoft.Build.Tasks.Deployment.ManifestUtilities.TypeLib[]); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.Xml.Serialization.XmlAttributeAttribute("WriteableType")]
    public string XmlWriteableType { get { return default(string); } set { } }
  }
  [System.Runtime.InteropServices.ComVisibleAttribute(false)]
  public sealed partial class FileReferenceCollection : System.Collections.IEnumerable {
    internal FileReferenceCollection() { }
    public int Count { get { return default(int); } }
    public Microsoft.Build.Tasks.Deployment.ManifestUtilities.FileReference this[int index] { get { return default(Microsoft.Build.Tasks.Deployment.ManifestUtilities.FileReference); } }
    public Microsoft.Build.Tasks.Deployment.ManifestUtilities.FileReference Add(Microsoft.Build.Tasks.Deployment.ManifestUtilities.FileReference file) { return default(Microsoft.Build.Tasks.Deployment.ManifestUtilities.FileReference); }
    public Microsoft.Build.Tasks.Deployment.ManifestUtilities.FileReference Add(string path) { return default(Microsoft.Build.Tasks.Deployment.ManifestUtilities.FileReference); }
    public void Clear() { }
    public Microsoft.Build.Tasks.Deployment.ManifestUtilities.FileReference FindTargetPath(string targetPath) { return default(Microsoft.Build.Tasks.Deployment.ManifestUtilities.FileReference); }
    public System.Collections.IEnumerator GetEnumerator() { return default(System.Collections.IEnumerator); }
    public void Remove(Microsoft.Build.Tasks.Deployment.ManifestUtilities.FileReference file) { }
  }
  [System.Runtime.InteropServices.ComVisibleAttribute(false)]
  public abstract partial class Manifest {
    protected internal Manifest() { }
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public Microsoft.Build.Tasks.Deployment.ManifestUtilities.AssemblyIdentity AssemblyIdentity { get { return default(Microsoft.Build.Tasks.Deployment.ManifestUtilities.AssemblyIdentity); } set { } }
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public Microsoft.Build.Tasks.Deployment.ManifestUtilities.AssemblyReferenceCollection AssemblyReferences { get { return default(Microsoft.Build.Tasks.Deployment.ManifestUtilities.AssemblyReferenceCollection); } }
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public string Description { get { return default(string); } set { } }
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public virtual Microsoft.Build.Tasks.Deployment.ManifestUtilities.AssemblyReference EntryPoint { get { return default(Microsoft.Build.Tasks.Deployment.ManifestUtilities.AssemblyReference); } set { } }
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public Microsoft.Build.Tasks.Deployment.ManifestUtilities.FileReferenceCollection FileReferences { get { return default(Microsoft.Build.Tasks.Deployment.ManifestUtilities.FileReferenceCollection); } }
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.IO.Stream InputStream { get { return default(System.IO.Stream); } set { } }
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public Microsoft.Build.Tasks.Deployment.ManifestUtilities.OutputMessageCollection OutputMessages { get { return default(Microsoft.Build.Tasks.Deployment.ManifestUtilities.OutputMessageCollection); } }
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public bool ReadOnly { get { return default(bool); } set { } }
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public string SourcePath { get { return default(string); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.Xml.Serialization.XmlElementAttribute("AssemblyIdentity")]
    public Microsoft.Build.Tasks.Deployment.ManifestUtilities.AssemblyIdentity XmlAssemblyIdentity { get { return default(Microsoft.Build.Tasks.Deployment.ManifestUtilities.AssemblyIdentity); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.Xml.Serialization.XmlArrayAttribute("AssemblyReferences")]
    public Microsoft.Build.Tasks.Deployment.ManifestUtilities.AssemblyReference[] XmlAssemblyReferences { get { return default(Microsoft.Build.Tasks.Deployment.ManifestUtilities.AssemblyReference[]); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.Xml.Serialization.XmlAttributeAttribute("Description")]
    public string XmlDescription { get { return default(string); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.Xml.Serialization.XmlArrayAttribute("FileReferences")]
    public Microsoft.Build.Tasks.Deployment.ManifestUtilities.FileReference[] XmlFileReferences { get { return default(Microsoft.Build.Tasks.Deployment.ManifestUtilities.FileReference[]); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.Xml.Serialization.XmlAttributeAttribute("Schema")]
    public string XmlSchema { get { return default(string); } set { } }
    public void ResolveFiles() { }
    public void ResolveFiles(System.String[] searchPaths) { }
    public override string ToString() { return default(string); }
    public void UpdateFileInfo() { }
    public void UpdateFileInfo(string targetFrameworkVersion) { }
    public virtual void Validate() { }
    protected void ValidatePlatform() { }
  }
  [System.Runtime.InteropServices.ComVisibleAttribute(false)]
  public static partial class ManifestReader {
    public static Microsoft.Build.Tasks.Deployment.ManifestUtilities.Manifest ReadManifest(System.IO.Stream input, bool preserveStream) { return default(Microsoft.Build.Tasks.Deployment.ManifestUtilities.Manifest); }
    public static Microsoft.Build.Tasks.Deployment.ManifestUtilities.Manifest ReadManifest(string path, bool preserveStream) { return default(Microsoft.Build.Tasks.Deployment.ManifestUtilities.Manifest); }
    public static Microsoft.Build.Tasks.Deployment.ManifestUtilities.Manifest ReadManifest(string manifestType, System.IO.Stream input, bool preserveStream) { return default(Microsoft.Build.Tasks.Deployment.ManifestUtilities.Manifest); }
    public static Microsoft.Build.Tasks.Deployment.ManifestUtilities.Manifest ReadManifest(string manifestType, string path, bool preserveStream) { return default(Microsoft.Build.Tasks.Deployment.ManifestUtilities.Manifest); }
  }
  [System.Runtime.InteropServices.ComVisibleAttribute(false)]
  public static partial class ManifestWriter {
    public static void WriteManifest(Microsoft.Build.Tasks.Deployment.ManifestUtilities.Manifest manifest) { }
    public static void WriteManifest(Microsoft.Build.Tasks.Deployment.ManifestUtilities.Manifest manifest, System.IO.Stream output) { }
    public static void WriteManifest(Microsoft.Build.Tasks.Deployment.ManifestUtilities.Manifest manifest, string path) { }
    public static void WriteManifest(Microsoft.Build.Tasks.Deployment.ManifestUtilities.Manifest manifest, string path, string targetframeWorkVersion) { }
  }
  [System.Runtime.InteropServices.ComVisibleAttribute(false)]
  public sealed partial class OutputMessage {
    internal OutputMessage() { }
    public string Name { get { return default(string); } }
    public string Text { get { return default(string); } }
    public Microsoft.Build.Tasks.Deployment.ManifestUtilities.OutputMessageType Type { get { return default(Microsoft.Build.Tasks.Deployment.ManifestUtilities.OutputMessageType); } }
    public System.String[] GetArguments() { return default(System.String[]); }
  }
  [System.Runtime.InteropServices.ComVisibleAttribute(false)]
  public sealed partial class OutputMessageCollection : System.Collections.IEnumerable {
    internal OutputMessageCollection() { }
    public int ErrorCount { get { return default(int); } }
    public Microsoft.Build.Tasks.Deployment.ManifestUtilities.OutputMessage this[int index] { get { return default(Microsoft.Build.Tasks.Deployment.ManifestUtilities.OutputMessage); } }
    public int WarningCount { get { return default(int); } }
    public void Clear() { }
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
    public ProxyStub() { }
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public string BaseInterface { get { return default(string); } }
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public string IID { get { return default(string); } }
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public string Name { get { return default(string); } }
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public string NumMethods { get { return default(string); } }
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public string TlbId { get { return default(string); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.Xml.Serialization.XmlAttributeAttribute("BaseInterface")]
    public string XmlBaseInterface { get { return default(string); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.Xml.Serialization.XmlAttributeAttribute("Iid")]
    public string XmlIID { get { return default(string); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.Xml.Serialization.XmlAttributeAttribute("Name")]
    public string XmlName { get { return default(string); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.Xml.Serialization.XmlAttributeAttribute("NumMethods")]
    public string XmlNumMethods { get { return default(string); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.Xml.Serialization.XmlAttributeAttribute("Tlbid")]
    public string XmlTlbId { get { return default(string); } set { } }
  }
  [System.Runtime.InteropServices.ComVisibleAttribute(false)]
  public static partial class SecurityUtilities {
    public static System.Security.PermissionSet ComputeZonePermissionSet(string targetZone, System.Security.PermissionSet includedPermissionSet, System.String[] excludedPermissions) { return default(System.Security.PermissionSet); }
    public static System.Security.PermissionSet IdentityListToPermissionSet(System.String[] ids) { return default(System.Security.PermissionSet); }
    public static System.String[] PermissionSetToIdentityList(System.Security.PermissionSet permissionSet) { return default(System.String[]); }
    public static void SignFile(System.Security.Cryptography.X509Certificates.X509Certificate2 cert, System.Uri timestampUrl, string path) { }
    public static void SignFile(string certPath, System.Security.SecureString certPassword, System.Uri timestampUrl, string path) { }
    public static void SignFile(string certThumbprint, System.Uri timestampUrl, string path) { }
    public static System.Security.PermissionSet XmlToPermissionSet(System.Xml.XmlElement element) { return default(System.Security.PermissionSet); }
  }
  [System.Runtime.InteropServices.ComVisibleAttribute(false)]
  public sealed partial class TrustInfo {
    public TrustInfo() { }
    public bool HasUnmanagedCodePermission { get { return default(bool); } }
    public bool IsFullTrust { get { return default(bool); } set { } }
    public System.Security.PermissionSet PermissionSet { get { return default(System.Security.PermissionSet); } set { } }
    public bool PreserveFullTrustPermissionSet { get { return default(bool); } set { } }
    public string SameSiteAccess { get { return default(string); } set { } }
    public void Clear() { }
    public void Read(System.IO.Stream input) { }
    public void Read(string path) { }
    public void ReadManifest(System.IO.Stream input) { }
    public void ReadManifest(string path) { }
    public override string ToString() { return default(string); }
    public void Write(System.IO.Stream output) { }
    public void Write(string path) { }
    public void WriteManifest(System.IO.Stream output) { }
    public void WriteManifest(System.IO.Stream input, System.IO.Stream output) { }
    public void WriteManifest(string path) { }
  }
  [System.Runtime.InteropServices.ComVisibleAttribute(false)]
  public partial class TypeLib {
    public TypeLib() { }
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public string Flags { get { return default(string); } }
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public string HelpDirectory { get { return default(string); } }
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public string ResourceId { get { return default(string); } }
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public string TlbId { get { return default(string); } }
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public string Version { get { return default(string); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.Xml.Serialization.XmlAttributeAttribute("Flags")]
    public string XmlFlags { get { return default(string); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.Xml.Serialization.XmlAttributeAttribute("HelpDir")]
    public string XmlHelpDirectory { get { return default(string); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.Xml.Serialization.XmlAttributeAttribute("ResourceId")]
    public string XmlResourceId { get { return default(string); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.Xml.Serialization.XmlAttributeAttribute("Tlbid")]
    public string XmlTlbId { get { return default(string); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.Xml.Serialization.XmlAttributeAttribute("Version")]
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
    public WindowClass() { }
    public WindowClass(string name, bool versioned) { }
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public string Name { get { return default(string); } }
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public bool Versioned { get { return default(bool); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.Xml.Serialization.XmlAttributeAttribute("Name")]
    public string XmlName { get { return default(string); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.Xml.Serialization.XmlAttributeAttribute("Versioned")]
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
  [System.Runtime.InteropServices.GuidAttribute("D6D4E228-259A-4076-B5D0-0627338BCC10")]
  [System.Runtime.InteropServices.InterfaceTypeAttribute((System.Runtime.InteropServices.ComInterfaceType)(1))]
  public partial interface ICscHostObject2 : Microsoft.Build.Framework.ITaskHost, Microsoft.Build.Tasks.Hosting.ICscHostObject {
    bool SetWin32Manifest(string win32Manifest);
  }
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  [System.Runtime.InteropServices.GuidAttribute("F9353662-F1ED-4a23-A323-5F5047E85F5D")]
  [System.Runtime.InteropServices.InterfaceTypeAttribute((System.Runtime.InteropServices.ComInterfaceType)(1))]
  public partial interface ICscHostObject3 : Microsoft.Build.Framework.ITaskHost, Microsoft.Build.Tasks.Hosting.ICscHostObject, Microsoft.Build.Tasks.Hosting.ICscHostObject2 {
    bool SetApplicationConfiguration(string applicationConfiguration);
  }
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  [System.Runtime.InteropServices.GuidAttribute("0DDB496F-C93C-492C-87F1-90B6FDBAA833")]
  [System.Runtime.InteropServices.InterfaceTypeAttribute((System.Runtime.InteropServices.ComInterfaceType)(1))]
  public partial interface ICscHostObject4 : Microsoft.Build.Framework.ITaskHost, Microsoft.Build.Tasks.Hosting.ICscHostObject, Microsoft.Build.Tasks.Hosting.ICscHostObject2, Microsoft.Build.Tasks.Hosting.ICscHostObject3 {
    bool SetHighEntropyVA(bool highEntropyVA);
    bool SetPlatformWith32BitPreference(string platformWith32BitPreference);
    bool SetSubsystemVersion(string subsystemVersion);
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
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  [System.Runtime.InteropServices.GuidAttribute("f59afc84-d102-48b1-a090-1b90c79d3e09")]
  [System.Runtime.InteropServices.InterfaceTypeAttribute((System.Runtime.InteropServices.ComInterfaceType)(1))]
  public partial interface IVbcHostObject2 : Microsoft.Build.Framework.ITaskHost, Microsoft.Build.Tasks.Hosting.IVbcHostObject {
    bool SetModuleAssemblyName(string moduleAssemblyName);
    bool SetOptionInfer(bool optionInfer);
    bool SetWin32Manifest(string win32Manifest);
  }
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  [System.Runtime.InteropServices.GuidAttribute("1186fe8f-8aba-48d6-8ce3-32ca42f53728")]
  [System.Runtime.InteropServices.InterfaceTypeAttribute((System.Runtime.InteropServices.ComInterfaceType)(1))]
  public partial interface IVbcHostObject3 : Microsoft.Build.Framework.ITaskHost, Microsoft.Build.Tasks.Hosting.IVbcHostObject, Microsoft.Build.Tasks.Hosting.IVbcHostObject2 {
    bool SetLanguageVersion(string languageVersion);
  }
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  [System.Runtime.InteropServices.GuidAttribute("2AE3233C-8AB3-48A0-9ED9-6E3545B3C566")]
  [System.Runtime.InteropServices.InterfaceTypeAttribute((System.Runtime.InteropServices.ComInterfaceType)(1))]
  public partial interface IVbcHostObject4 : Microsoft.Build.Framework.ITaskHost, Microsoft.Build.Tasks.Hosting.IVbcHostObject, Microsoft.Build.Tasks.Hosting.IVbcHostObject2, Microsoft.Build.Tasks.Hosting.IVbcHostObject3 {
    bool SetVBRuntime(string VBRuntime);
  }
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  [System.Runtime.InteropServices.GuidAttribute("5ACF41FF-6F2B-4623-8146-740C89212B21")]
  [System.Runtime.InteropServices.InterfaceTypeAttribute((System.Runtime.InteropServices.ComInterfaceType)(1))]
  public partial interface IVbcHostObject5 : Microsoft.Build.Framework.ITaskHost, Microsoft.Build.Tasks.Hosting.IVbcHostObject, Microsoft.Build.Tasks.Hosting.IVbcHostObject2, Microsoft.Build.Tasks.Hosting.IVbcHostObject3, Microsoft.Build.Tasks.Hosting.IVbcHostObject4 {
    int CompileAsync(out System.IntPtr buildSucceededEvent, out System.IntPtr buildFailedEvent);
    int EndCompile(bool buildSuccess);
    Microsoft.Build.Tasks.Hosting.IVbcHostObjectFreeThreaded GetFreeThreadedHostObject();
    bool SetHighEntropyVA(bool highEntropyVA);
    bool SetPlatformWith32BitPreference(string platformWith32BitPreference);
    bool SetSubsystemVersion(string subsystemVersion);
  }
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  [System.Runtime.InteropServices.GuidAttribute("ECCF972F-8C2D-4F51-9746-9288661DE2CB")]
  [System.Runtime.InteropServices.InterfaceTypeAttribute((System.Runtime.InteropServices.ComInterfaceType)(1))]
  public partial interface IVbcHostObjectFreeThreaded {
    bool Compile();
  }
}
namespace Microsoft.Build.Tasks.Xaml {
  public partial class CommandLineArgumentRelation : Microsoft.Build.Tasks.Xaml.PropertyRelation {
    public CommandLineArgumentRelation(string argument, string value, bool required, string separator) { }
    public string Separator { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
  }
  public partial class CommandLineGenerator {
    public CommandLineGenerator(Microsoft.Build.Framework.XamlTypes.Rule rule, System.Collections.Generic.Dictionary<System.String, System.Object> parameterValues) { }
    public string AdditionalOptions { get { return default(string); } set { } }
    public string AlwaysAppend { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public string CommandLineTemplate { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public string GenerateCommandLine() { return default(string); }
  }
  public partial class CommandLineToolSwitch {
    public CommandLineToolSwitch() { }
    public CommandLineToolSwitch(Microsoft.Build.Tasks.Xaml.CommandLineToolSwitchType toolType) { }
    public bool AllowMultipleValues { get { return default(bool); } set { } }
    public bool ArgumentRequired { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Collections.Generic.ICollection<System.Tuple<System.String, System.Boolean>> Arguments { get { return default(System.Collections.Generic.ICollection<System.Tuple<System.String, System.Boolean>>); } set { } }
    public bool BooleanValue { get { return default(bool); } set { } }
    public string Description { get { return default(string); } set { } }
    public string DisplayName { get { return default(string); } set { } }
    public string FallbackArgumentParameter { get { return default(string); } set { } }
    public string FalseSuffix { get { return default(string); } set { } }
    public bool IncludeInCommandLine { get { return default(bool); } set { } }
    public bool IsValid { get { return default(bool); } set { } }
    public string Name { get { return default(string); } set { } }
    public int Number { get { return default(int); } set { } }
    public System.Collections.Generic.LinkedList<System.Collections.Generic.KeyValuePair<System.String, System.String>> Overrides { get { return default(System.Collections.Generic.LinkedList<System.Collections.Generic.KeyValuePair<System.String, System.String>>); } }
    public System.Collections.Generic.LinkedList<System.String> Parents { get { return default(System.Collections.Generic.LinkedList<System.String>); } }
    public bool Required { get { return default(bool); } set { } }
    public string ReverseSwitchValue { get { return default(string); } set { } }
    public bool Reversible { get { return default(bool); } set { } }
    public string Separator { get { return default(string); } set { } }
    public System.String[] StringList { get { return default(System.String[]); } set { } }
    public string SwitchValue { get { return default(string); } set { } }
    public Microsoft.Build.Framework.ITaskItem[] TaskItemArray { get { return default(Microsoft.Build.Framework.ITaskItem[]); } set { } }
    public string TrueSuffix { get { return default(string); } set { } }
    public Microsoft.Build.Tasks.Xaml.CommandLineToolSwitchType Type { get { return default(Microsoft.Build.Tasks.Xaml.CommandLineToolSwitchType); } set { } }
    public string Value { get { return default(string); } set { } }
  }
  public enum CommandLineToolSwitchType {
    Boolean = 0,
    Integer = 1,
    ITaskItemArray = 4,
    String = 2,
    StringArray = 3,
  }
  public partial class PropertyRelation {
    public PropertyRelation() { }
    public PropertyRelation(string argument, string value, bool required) { }
    public string Argument { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public bool Required { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public string Value { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
  }
  public abstract partial class XamlDataDrivenToolTask : Microsoft.Build.Utilities.ToolTask {
    protected XamlDataDrivenToolTask(System.String[] switchOrderList, System.Resources.ResourceManager taskResources) { }
    public virtual System.String[] AcceptableNonZeroExitCodes { get { return default(System.String[]); } set { } }
    protected internal System.Collections.Generic.Dictionary<System.String, Microsoft.Build.Tasks.Xaml.CommandLineToolSwitch> ActiveToolSwitches { get { return default(System.Collections.Generic.Dictionary<System.String, Microsoft.Build.Tasks.Xaml.CommandLineToolSwitch>); } }
    public System.Collections.Generic.Dictionary<System.String, Microsoft.Build.Tasks.Xaml.CommandLineToolSwitch> ActiveToolSwitchesValues { get { return default(System.Collections.Generic.Dictionary<System.String, Microsoft.Build.Tasks.Xaml.CommandLineToolSwitch>); } set { } }
    public string AdditionalOptions { get { return default(string); } set { } }
    public string CommandLineTemplate { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    protected override System.Text.Encoding ResponseFileEncoding { get { return default(System.Text.Encoding); } }
    public void AddActiveSwitchToolValue(Microsoft.Build.Tasks.Xaml.CommandLineToolSwitch switchToAdd) { }
    public string CreateSwitchValue(string propertyName, string baseSwitch, string separator, System.Tuple<System.String, System.Boolean>[] arguments) { return default(string); }
    public override bool Execute() { return default(bool); }
    protected override string GenerateCommandLineCommands() { return default(string); }
    protected override string GenerateFullPathToTool() { return default(string); }
    protected override string GenerateResponseFileCommands() { return default(string); }
    protected override bool HandleTaskExecutionErrors() { return default(bool); }
    public bool IsPropertySet(string propertyName) { return default(bool); }
    public string ReadSwitchMap(string propertyName, System.String[][] switchMap, string value) { return default(string); }
    public int ReadSwitchMap2(string propertyName, System.Tuple<System.String, System.String, System.Tuple<System.String, System.Boolean>[]>[] switchMap, string value) { return default(int); }
    public void ReplaceToolSwitch(Microsoft.Build.Tasks.Xaml.CommandLineToolSwitch switchToAdd) { }
    public bool ValidateInteger(string switchName, int min, int max, int value) { return default(bool); }
    protected override bool ValidateParameters() { return default(bool); }
  }
}
namespace System.Deployment.Internal.CodeSigning {
  public sealed partial class RSAPKCS1SHA256SignatureDescription : System.Security.Cryptography.SignatureDescription {
    public RSAPKCS1SHA256SignatureDescription() { }
    public override System.Security.Cryptography.AsymmetricSignatureDeformatter CreateDeformatter(System.Security.Cryptography.AsymmetricAlgorithm key) { return default(System.Security.Cryptography.AsymmetricSignatureDeformatter); }
    public override System.Security.Cryptography.AsymmetricSignatureFormatter CreateFormatter(System.Security.Cryptography.AsymmetricAlgorithm key) { return default(System.Security.Cryptography.AsymmetricSignatureFormatter); }
  }
}
