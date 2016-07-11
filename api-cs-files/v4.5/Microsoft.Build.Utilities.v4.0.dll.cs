namespace Microsoft.Build.Utilities {
  [Microsoft.Build.Framework.LoadInSeparateAppDomainAttribute]
  [System.MonoTODOAttribute]
  public abstract partial class AppDomainIsolatedTask : System.MarshalByRefObject, Microsoft.Build.Framework.ITask {
    protected AppDomainIsolatedTask() { }
    protected AppDomainIsolatedTask(System.Resources.ResourceManager taskResources) { }
    protected AppDomainIsolatedTask(System.Resources.ResourceManager taskResources, string helpKeywordPrefix) { }
    public Microsoft.Build.Framework.IBuildEngine BuildEngine { get { return default(Microsoft.Build.Framework.IBuildEngine); } set { } }
    protected string HelpKeywordPrefix { get { return default(string); } set { } }
    public Microsoft.Build.Framework.ITaskHost HostObject { get { return default(Microsoft.Build.Framework.ITaskHost); } set { } }
    public Microsoft.Build.Utilities.TaskLoggingHelper Log { get { return default(Microsoft.Build.Utilities.TaskLoggingHelper); } }
    protected System.Resources.ResourceManager TaskResources { get { return default(System.Resources.ResourceManager); } set { } }
    public abstract bool Execute();
    public override object InitializeLifetimeService() { return default(object); }
  }
  public partial class CommandLineBuilder {
    public CommandLineBuilder() { }
    protected System.Text.StringBuilder CommandLine { get { return default(System.Text.StringBuilder); } }
    public void AppendFileNameIfNotNull(Microsoft.Build.Framework.ITaskItem fileItem) { }
    public void AppendFileNameIfNotNull(string fileName) { }
    public void AppendFileNamesIfNotNull(Microsoft.Build.Framework.ITaskItem[] fileItems, string delimiter) { }
    public void AppendFileNamesIfNotNull(System.String[] fileNames, string delimiter) { }
    protected void AppendFileNameWithQuoting(string fileName) { }
    protected void AppendSpaceIfNotEmpty() { }
    public void AppendSwitch(string switchName) { }
    public void AppendSwitchIfNotNull(string switchName, Microsoft.Build.Framework.ITaskItem parameter) { }
    public void AppendSwitchIfNotNull(string switchName, Microsoft.Build.Framework.ITaskItem[] parameters, string delimiter) { }
    public void AppendSwitchIfNotNull(string switchName, string parameter) { }
    public void AppendSwitchIfNotNull(string switchName, System.String[] parameters, string delimiter) { }
    public void AppendSwitchUnquotedIfNotNull(string switchName, Microsoft.Build.Framework.ITaskItem parameter) { }
    public void AppendSwitchUnquotedIfNotNull(string switchName, Microsoft.Build.Framework.ITaskItem[] parameters, string delimiter) { }
    public void AppendSwitchUnquotedIfNotNull(string switchName, string parameter) { }
    public void AppendSwitchUnquotedIfNotNull(string switchName, System.String[] parameters, string delimiter) { }
    public void AppendTextUnquoted(string textToAppend) { }
    protected void AppendTextWithQuoting(string textToAppend) { }
    protected virtual bool IsQuotingRequired(string parameter) { return default(bool); }
    public override string ToString() { return default(string); }
    protected virtual void VerifyThrowNoEmbeddedDoubleQuotes(string switchName, string parameter) { }
  }
  public enum HostObjectInitializationStatus {
    NoActionReturnFailure = 3,
    NoActionReturnSuccess = 2,
    UseAlternateToolToExecute = 1,
    UseHostObjectToExecute = 0,
  }
  public abstract partial class Logger : Microsoft.Build.Framework.ILogger {
    protected Logger() { }
    public virtual string Parameters { get { return default(string); } set { } }
    public virtual Microsoft.Build.Framework.LoggerVerbosity Verbosity { get { return default(Microsoft.Build.Framework.LoggerVerbosity); } set { } }
    public virtual string FormatErrorEvent(Microsoft.Build.Framework.BuildErrorEventArgs args) { return default(string); }
    public virtual string FormatWarningEvent(Microsoft.Build.Framework.BuildWarningEventArgs args) { return default(string); }
    public abstract void Initialize(Microsoft.Build.Framework.IEventSource eventSource);
    [System.MonoTODOAttribute]
    public bool IsVerbosityAtLeast(Microsoft.Build.Framework.LoggerVerbosity checkVerbosity) { return default(bool); }
    public virtual void Shutdown() { }
  }
  public enum TargetDotNetFrameworkVersion {
    Version11 = 0,
    Version20 = 1,
    Version30 = 2,
    Version35 = 3,
    Version40 = 4,
    Version45 = 5,
    VersionLatest = 5,
  }
  public abstract partial class Task : Microsoft.Build.Framework.ITask {
    protected Task() { }
    protected Task(System.Resources.ResourceManager taskResources) { }
    protected Task(System.Resources.ResourceManager taskResources, string helpKeywordPrefix) { }
    public Microsoft.Build.Framework.IBuildEngine BuildEngine { get { return default(Microsoft.Build.Framework.IBuildEngine); } set { } }
    public Microsoft.Build.Framework.IBuildEngine2 BuildEngine2 { get { return default(Microsoft.Build.Framework.IBuildEngine2); } }
    protected string HelpKeywordPrefix { get { return default(string); } set { } }
    public Microsoft.Build.Framework.ITaskHost HostObject { get { return default(Microsoft.Build.Framework.ITaskHost); } set { } }
    public Microsoft.Build.Utilities.TaskLoggingHelper Log { get { return default(Microsoft.Build.Utilities.TaskLoggingHelper); } }
    protected System.Resources.ResourceManager TaskResources { get { return default(System.Resources.ResourceManager); } set { } }
    public abstract bool Execute();
  }
  public sealed partial class TaskItem : System.MarshalByRefObject, Microsoft.Build.Framework.ITaskItem, Microsoft.Build.Framework.ITaskItem2 {
    public TaskItem() { }
    public TaskItem(Microsoft.Build.Framework.ITaskItem sourceItem) { }
    public TaskItem(string itemSpec) { }
    public TaskItem(string itemSpec, System.Collections.IDictionary itemMetadata) { }
    public string ItemSpec { get { return default(string); } set { } }
    public int MetadataCount { get { return default(int); } }
    public System.Collections.ICollection MetadataNames { get { return default(System.Collections.ICollection); } }
    string Microsoft.Build.Framework.ITaskItem2.EvaluatedIncludeEscaped { get { return default(string); } set { } }
    public System.Collections.IDictionary CloneCustomMetadata() { return default(System.Collections.IDictionary); }
    public void CopyMetadataTo(Microsoft.Build.Framework.ITaskItem destinationItem) { }
    public string GetMetadata(string metadataName) { return default(string); }
    public override object InitializeLifetimeService() { return default(object); }
    System.Collections.IDictionary Microsoft.Build.Framework.ITaskItem2.CloneCustomMetadataEscaped() { return default(System.Collections.IDictionary); }
    string Microsoft.Build.Framework.ITaskItem2.GetMetadataValueEscaped(string metadataName) { return default(string); }
    void Microsoft.Build.Framework.ITaskItem2.SetMetadataValueLiteral(string metadataName, string metadataValue) { }
    public static explicit operator string (Microsoft.Build.Utilities.TaskItem taskItemToCast) { return default(string); }
    public void RemoveMetadata(string metadataName) { }
    public void SetMetadata(string metadataName, string metadataValue) { }
    public override string ToString() { return default(string); }
  }
  public partial class TaskLoggingHelper : System.MarshalByRefObject {
    public TaskLoggingHelper(Microsoft.Build.Framework.ITask taskInstance) { }
    protected Microsoft.Build.Framework.IBuildEngine BuildEngine { get { return default(Microsoft.Build.Framework.IBuildEngine); } }
    public bool HasLoggedErrors { get { return default(bool); } }
    public string HelpKeywordPrefix { get { return default(string); } set { } }
    protected string TaskName { get { return default(string); } }
    public System.Resources.ResourceManager TaskResources { get { return default(System.Resources.ResourceManager); } set { } }
    [System.MonoTODOAttribute]
    public string ExtractMessageCode(string message, out string messageWithoutCodePrefix) { messageWithoutCodePrefix = default(string); return default(string); }
    [System.MonoTODOAttribute]
    public virtual string FormatResourceString(string resourceName, params System.Object[] args) { return default(string); }
    [System.MonoTODOAttribute]
    public virtual string FormatString(string unformatted, params System.Object[] args) { return default(string); }
    [System.MonoTODOAttribute]
    public void LogCommandLine(Microsoft.Build.Framework.MessageImportance importance, string commandLine) { }
    [System.MonoTODOAttribute]
    public void LogCommandLine(string commandLine) { }
    public void LogError(string message, params System.Object[] messageArgs) { }
    public void LogError(string subcategory, string errorCode, string helpKeyword, string file, int lineNumber, int columnNumber, int endLineNumber, int endColumnNumber, string message, params System.Object[] messageArgs) { }
    public void LogErrorFromException(System.Exception exception) { }
    public void LogErrorFromException(System.Exception exception, bool showStackTrace) { }
    [System.MonoTODOAttribute("Arguments @showDetail and @file are not honored")]
    public void LogErrorFromException(System.Exception exception, bool showStackTrace, bool showDetail, string file) { }
    public void LogErrorFromResources(string messageResourceName, params System.Object[] messageArgs) { }
    public void LogErrorFromResources(string subcategoryResourceName, string errorCode, string helpKeyword, string file, int lineNumber, int columnNumber, int endLineNumber, int endColumnNumber, string messageResourceName, params System.Object[] messageArgs) { }
    public void LogErrorWithCodeFromResources(string messageResourceName, params System.Object[] messageArgs) { }
    public void LogErrorWithCodeFromResources(string subcategoryResourceName, string file, int lineNumber, int columnNumber, int endLineNumber, int endColumnNumber, string messageResourceName, params System.Object[] messageArgs) { }
    [System.MonoTODOAttribute]
    public void LogExternalProjectFinished(string message, string helpKeyword, string projectFile, bool succeeded) { }
    [System.MonoTODOAttribute]
    public void LogExternalProjectStarted(string message, string helpKeyword, string projectFile, string targetNames) { }
    public void LogMessage(Microsoft.Build.Framework.MessageImportance importance, string message, params System.Object[] messageArgs) { }
    public void LogMessage(string message, params System.Object[] messageArgs) { }
    public void LogMessageFromResources(Microsoft.Build.Framework.MessageImportance importance, string messageResourceName, params System.Object[] messageArgs) { }
    public void LogMessageFromResources(string messageResourceName, params System.Object[] messageArgs) { }
    public bool LogMessageFromText(string lineOfText, Microsoft.Build.Framework.MessageImportance messageImportance) { return default(bool); }
    public bool LogMessagesFromFile(string fileName) { return default(bool); }
    public bool LogMessagesFromFile(string fileName, Microsoft.Build.Framework.MessageImportance messageImportance) { return default(bool); }
    public bool LogMessagesFromStream(System.IO.TextReader stream, Microsoft.Build.Framework.MessageImportance messageImportance) { return default(bool); }
    public void LogWarning(string message, params System.Object[] messageArgs) { }
    public void LogWarning(string subcategory, string warningCode, string helpKeyword, string file, int lineNumber, int columnNumber, int endLineNumber, int endColumnNumber, string message, params System.Object[] messageArgs) { }
    public void LogWarningFromException(System.Exception exception) { }
    public void LogWarningFromException(System.Exception exception, bool showStackTrace) { }
    public void LogWarningFromResources(string messageResourceName, params System.Object[] messageArgs) { }
    public void LogWarningFromResources(string subcategoryResourceName, string warningCode, string helpKeyword, string file, int lineNumber, int columnNumber, int endLineNumber, int endColumnNumber, string messageResourceName, params System.Object[] messageArgs) { }
    public void LogWarningWithCodeFromResources(string messageResourceName, params System.Object[] messageArgs) { }
    public void LogWarningWithCodeFromResources(string subcategoryResourceName, string file, int lineNumber, int columnNumber, int endLineNumber, int endColumnNumber, string messageResourceName, params System.Object[] messageArgs) { }
  }
  public static partial class ToolLocationHelper {
    [System.MonoTODOAttribute]
    public static string PathToSystem { get { return default(string); } }
    [System.MonoTODOAttribute]
    public static string GetDotNetFrameworkRootRegistryKey(Microsoft.Build.Utilities.TargetDotNetFrameworkVersion version) { return default(string); }
    [System.MonoTODOAttribute]
    public static string GetDotNetFrameworkSdkInstallKeyValue(Microsoft.Build.Utilities.TargetDotNetFrameworkVersion version) { return default(string); }
    [System.MonoTODOAttribute]
    public static string GetDotNetFrameworkVersionFolderPrefix(Microsoft.Build.Utilities.TargetDotNetFrameworkVersion version) { return default(string); }
    public static string GetPathToDotNetFramework(Microsoft.Build.Utilities.TargetDotNetFrameworkVersion version) { return default(string); }
    public static string GetPathToDotNetFrameworkFile(string fileName, Microsoft.Build.Utilities.TargetDotNetFrameworkVersion version) { return default(string); }
    public static string GetPathToDotNetFrameworkSdk(Microsoft.Build.Utilities.TargetDotNetFrameworkVersion version) { return default(string); }
    [System.MonoTODOAttribute]
    public static string GetPathToDotNetFrameworkSdkFile(string fileName, Microsoft.Build.Utilities.TargetDotNetFrameworkVersion version) { return default(string); }
    public static string GetPathToStandardLibraries(string targetFrameworkIdentifier, string targetFrameworkVersion, string targetFrameworkProfile) { return default(string); }
    [System.MonoTODOAttribute]
    public static string GetPathToSystemFile(string fileName) { return default(string); }
  }
  public abstract partial class ToolTask : Microsoft.Build.Utilities.Task, Microsoft.Build.Framework.ICancelableTask, Microsoft.Build.Framework.ITask {
    protected ToolTask() { }
    protected ToolTask(System.Resources.ResourceManager taskResources) { }
    protected ToolTask(System.Resources.ResourceManager taskResources, string helpKeywordPrefix) { }
    protected virtual System.Collections.Specialized.StringDictionary EnvironmentOverride { get { return default(System.Collections.Specialized.StringDictionary); } }
    public System.String[] EnvironmentVariables { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.String[]); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [Microsoft.Build.Framework.OutputAttribute]
    public int ExitCode { get { return default(int); } }
    protected virtual bool HasLoggedErrors { get { return default(bool); } }
    public bool LogStandardErrorAsError { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    protected virtual System.Text.Encoding ResponseFileEncoding { get { return default(System.Text.Encoding); } }
    protected virtual System.Text.Encoding StandardErrorEncoding { get { return default(System.Text.Encoding); } }
    protected Microsoft.Build.Framework.MessageImportance StandardErrorImportanceToUse { get { return default(Microsoft.Build.Framework.MessageImportance); } }
    protected virtual Microsoft.Build.Framework.MessageImportance StandardErrorLoggingImportance { get { return default(Microsoft.Build.Framework.MessageImportance); } }
    protected virtual System.Text.Encoding StandardOutputEncoding { get { return default(System.Text.Encoding); } }
    public string StandardOutputImportance { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    protected Microsoft.Build.Framework.MessageImportance StandardOutputImportanceToUse { get { return default(Microsoft.Build.Framework.MessageImportance); } }
    protected virtual Microsoft.Build.Framework.MessageImportance StandardOutputLoggingImportance { get { return default(Microsoft.Build.Framework.MessageImportance); } }
    public virtual int Timeout { get { return default(int); } set { } }
    protected System.Threading.ManualResetEvent ToolCanceled { get { return default(System.Threading.ManualResetEvent); } }
    public virtual string ToolExe { get { return default(string); } set { } }
    protected abstract string ToolName { get; }
    public string ToolPath { get { return default(string); } set { } }
    [System.MonoTODOAttribute]
    protected virtual bool CallHostObjectToExecute() { return default(bool); }
    public virtual void Cancel() { }
    protected void DeleteTempFile(string fileName) { }
    public override bool Execute() { return default(bool); }
    protected virtual int ExecuteTool(string pathToTool, string responseFileCommands, string commandLineCommands) { return default(int); }
    protected virtual string GenerateCommandLineCommands() { return default(string); }
    protected abstract string GenerateFullPathToTool();
    protected virtual string GenerateResponseFileCommands() { return default(string); }
    protected System.Diagnostics.ProcessStartInfo GetProcessStartInfo(string pathToTool, string commandLineCommands, string responseFileSwitch) { return default(System.Diagnostics.ProcessStartInfo); }
    protected virtual string GetResponseFileSwitch(string responseFilePath) { return default(string); }
    [System.MonoTODOAttribute]
    protected virtual string GetWorkingDirectory() { return default(string); }
    protected virtual bool HandleTaskExecutionErrors() { return default(bool); }
    protected virtual Microsoft.Build.Utilities.HostObjectInitializationStatus InitializeHostObject() { return default(Microsoft.Build.Utilities.HostObjectInitializationStatus); }
    protected virtual void LogEventsFromTextOutput(string singleLine, Microsoft.Build.Framework.MessageImportance messageImportance) { }
    [System.MonoTODOAttribute]
    protected virtual void LogPathToTool(string toolName, string pathToTool) { }
    protected virtual void LogToolCommand(string message) { }
    protected virtual bool SkipTaskExecution() { return default(bool); }
    protected virtual bool ValidateParameters() { return default(bool); }
  }
}
