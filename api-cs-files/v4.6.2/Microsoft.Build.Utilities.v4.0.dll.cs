namespace Microsoft.Build.Utilities {
  [Microsoft.Build.Framework.LoadInSeparateAppDomainAttribute]
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
    [System.Security.SecurityCriticalAttribute]
    public override object InitializeLifetimeService() { return default(object); }
  }
  public partial class AssemblyFoldersExInfo {
    public AssemblyFoldersExInfo(Microsoft.Win32.RegistryHive hive, Microsoft.Win32.RegistryView view, string registryKey, string directoryPath, System.Version targetFrameworkVersion) { }
    public string DirectoryPath { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
    public Microsoft.Win32.RegistryHive Hive { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(Microsoft.Win32.RegistryHive); } }
    public string Key { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
    public System.Version TargetFrameworkVersion { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Version); } }
    public Microsoft.Win32.RegistryView View { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(Microsoft.Win32.RegistryView); } }
  }
  public partial class CanonicalTrackedInputFiles {
    public CanonicalTrackedInputFiles(Microsoft.Build.Framework.ITask ownerTask, Microsoft.Build.Framework.ITaskItem[] tlogFiles, Microsoft.Build.Framework.ITaskItem sourceFile, Microsoft.Build.Framework.ITaskItem[] excludedInputPaths, Microsoft.Build.Utilities.CanonicalTrackedOutputFiles outputs, bool useMinimalRebuildOptimization, bool maintainCompositeRootingMarkers) { }
    public CanonicalTrackedInputFiles(Microsoft.Build.Framework.ITask ownerTask, Microsoft.Build.Framework.ITaskItem[] tlogFiles, Microsoft.Build.Framework.ITaskItem[] sourceFiles, Microsoft.Build.Framework.ITaskItem[] excludedInputPaths, Microsoft.Build.Framework.ITaskItem[] outputs, bool useMinimalRebuildOptimization, bool maintainCompositeRootingMarkers) { }
    public CanonicalTrackedInputFiles(Microsoft.Build.Framework.ITask ownerTask, Microsoft.Build.Framework.ITaskItem[] tlogFiles, Microsoft.Build.Framework.ITaskItem[] sourceFiles, Microsoft.Build.Framework.ITaskItem[] excludedInputPaths, Microsoft.Build.Utilities.CanonicalTrackedOutputFiles outputs, bool useMinimalRebuildOptimization, bool maintainCompositeRootingMarkers) { }
    public CanonicalTrackedInputFiles(Microsoft.Build.Framework.ITaskItem[] tlogFiles, Microsoft.Build.Framework.ITaskItem[] sourceFiles, Microsoft.Build.Framework.ITaskItem[] excludedInputPaths, Microsoft.Build.Utilities.CanonicalTrackedOutputFiles outputs, bool useMinimalRebuildOptimization, bool maintainCompositeRootingMarkers) { }
    public CanonicalTrackedInputFiles(Microsoft.Build.Framework.ITaskItem[] tlogFiles, Microsoft.Build.Framework.ITaskItem[] sourceFiles, Microsoft.Build.Utilities.CanonicalTrackedOutputFiles outputs, bool useMinimalRebuildOptimization, bool maintainCompositeRootingMarkers) { }
    public System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.Dictionary<System.String, System.String>> DependencyTable { get { return default(System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.Dictionary<System.String, System.String>>); } }
    public Microsoft.Build.Framework.ITaskItem[] ComputeSourcesNeedingCompilation() { return default(Microsoft.Build.Framework.ITaskItem[]); }
    public Microsoft.Build.Framework.ITaskItem[] ComputeSourcesNeedingCompilation(bool searchForSubRootsInCompositeRootingMarkers) { return default(Microsoft.Build.Framework.ITaskItem[]); }
    public bool FileIsExcludedFromDependencyCheck(string fileName) { return default(bool); }
    public void RemoveDependenciesFromEntryIfMissing(Microsoft.Build.Framework.ITaskItem source) { }
    public void RemoveDependenciesFromEntryIfMissing(Microsoft.Build.Framework.ITaskItem source, Microsoft.Build.Framework.ITaskItem correspondingOutput) { }
    public void RemoveDependenciesFromEntryIfMissing(Microsoft.Build.Framework.ITaskItem[] source) { }
    public void RemoveDependenciesFromEntryIfMissing(Microsoft.Build.Framework.ITaskItem[] source, Microsoft.Build.Framework.ITaskItem[] correspondingOutputs) { }
    public void RemoveDependencyFromEntry(Microsoft.Build.Framework.ITaskItem source, Microsoft.Build.Framework.ITaskItem dependencyToRemove) { }
    public void RemoveDependencyFromEntry(Microsoft.Build.Framework.ITaskItem[] sources, Microsoft.Build.Framework.ITaskItem dependencyToRemove) { }
    public void RemoveEntriesForSource(Microsoft.Build.Framework.ITaskItem source) { }
    public void RemoveEntriesForSource(Microsoft.Build.Framework.ITaskItem[] source) { }
    public void RemoveEntryForSourceRoot(string rootingMarker) { }
    public void SaveTlog() { }
    public void SaveTlog(Microsoft.Build.Utilities.DependencyFilter includeInTLog) { }
  }
  public partial class CanonicalTrackedOutputFiles {
    public CanonicalTrackedOutputFiles(Microsoft.Build.Framework.ITask ownerTask, Microsoft.Build.Framework.ITaskItem[] tlogFiles) { }
    public CanonicalTrackedOutputFiles(Microsoft.Build.Framework.ITask ownerTask, Microsoft.Build.Framework.ITaskItem[] tlogFiles, bool constructOutputsFromTLogs) { }
    public CanonicalTrackedOutputFiles(Microsoft.Build.Framework.ITaskItem[] tlogFiles) { }
    public System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.Dictionary<System.String, System.DateTime>> DependencyTable { get { return default(System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.Dictionary<System.String, System.DateTime>>); } }
    public void AddComputedOutputForSourceRoot(string sourceKey, string computedOutput) { }
    public void AddComputedOutputsForSourceRoot(string sourceKey, Microsoft.Build.Framework.ITaskItem[] computedOutputs) { }
    public void AddComputedOutputsForSourceRoot(string sourceKey, System.String[] computedOutputs) { }
    public Microsoft.Build.Framework.ITaskItem[] OutputsForNonCompositeSource(params Microsoft.Build.Framework.ITaskItem[] sources) { return default(Microsoft.Build.Framework.ITaskItem[]); }
    public Microsoft.Build.Framework.ITaskItem[] OutputsForSource(params Microsoft.Build.Framework.ITaskItem[] sources) { return default(Microsoft.Build.Framework.ITaskItem[]); }
    public Microsoft.Build.Framework.ITaskItem[] OutputsForSource(Microsoft.Build.Framework.ITaskItem[] sources, bool searchForSubRootsInCompositeRootingMarkers) { return default(Microsoft.Build.Framework.ITaskItem[]); }
    public void RemoveDependenciesFromEntryIfMissing(Microsoft.Build.Framework.ITaskItem source) { }
    public void RemoveDependenciesFromEntryIfMissing(Microsoft.Build.Framework.ITaskItem source, Microsoft.Build.Framework.ITaskItem correspondingOutput) { }
    public void RemoveDependenciesFromEntryIfMissing(Microsoft.Build.Framework.ITaskItem[] source) { }
    public void RemoveDependenciesFromEntryIfMissing(Microsoft.Build.Framework.ITaskItem[] source, Microsoft.Build.Framework.ITaskItem[] correspondingOutputs) { }
    public void RemoveDependencyFromEntry(Microsoft.Build.Framework.ITaskItem source, Microsoft.Build.Framework.ITaskItem dependencyToRemove) { }
    public void RemoveDependencyFromEntry(Microsoft.Build.Framework.ITaskItem[] sources, Microsoft.Build.Framework.ITaskItem dependencyToRemove) { }
    public void RemoveEntriesForSource(Microsoft.Build.Framework.ITaskItem source) { }
    public void RemoveEntriesForSource(Microsoft.Build.Framework.ITaskItem source, Microsoft.Build.Framework.ITaskItem correspondingOutput) { }
    public void RemoveEntriesForSource(Microsoft.Build.Framework.ITaskItem[] source) { }
    public void RemoveEntriesForSource(Microsoft.Build.Framework.ITaskItem[] source, Microsoft.Build.Framework.ITaskItem[] correspondingOutputs) { }
    public bool RemoveOutputForSourceRoot(string sourceRoot, string outputPathToRemove) { return default(bool); }
    public System.String[] RemoveRootsWithSharedOutputs(Microsoft.Build.Framework.ITaskItem[] sources) { return default(System.String[]); }
    public void SaveTlog() { }
    public void SaveTlog(Microsoft.Build.Utilities.DependencyFilter includeInTLog) { }
  }
  public partial class CommandLineBuilder {
    public CommandLineBuilder() { }
    public CommandLineBuilder(bool quoteHyphensOnCommandLine) { }
    protected System.Text.StringBuilder CommandLine { get { return default(System.Text.StringBuilder); } }
    public int Length { get { return default(int); } }
    public void AppendFileNameIfNotNull(Microsoft.Build.Framework.ITaskItem fileItem) { }
    public void AppendFileNameIfNotNull(string fileName) { }
    public void AppendFileNamesIfNotNull(Microsoft.Build.Framework.ITaskItem[] fileItems, string delimiter) { }
    public void AppendFileNamesIfNotNull(System.String[] fileNames, string delimiter) { }
    protected void AppendFileNameWithQuoting(string fileName) { }
    protected void AppendQuotedTextToBuffer(System.Text.StringBuilder buffer, string unquotedTextToAppend) { }
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
  public delegate bool DependencyFilter(string fullPath);
  public enum DotNetFrameworkArchitecture {
    Bitness32 = 1,
    Bitness64 = 2,
    Current = 0,
  }
  public enum ExecutableType {
    Managed32Bit = 3,
    Managed64Bit = 4,
    ManagedIL = 2,
    Native32Bit = 0,
    Native64Bit = 1,
    SameAsCurrentProcess = 5,
  }
  public static partial class FileTracker {
    public static string CreateRootingMarkerResponseFile(Microsoft.Build.Framework.ITaskItem[] sources) { return default(string); }
    public static string CreateRootingMarkerResponseFile(string rootMarker) { return default(string); }
    public static void EndTrackingContext() { }
    public static string EnsureFileTrackerOnPath() { return default(string); }
    public static string EnsureFileTrackerOnPath(string rootPath) { return default(string); }
    public static bool FileIsExcludedFromDependencies(string fileName) { return default(bool); }
    public static bool FileIsUnderPath(string fileName, string path) { return default(bool); }
    public static string FindTrackerOnPath() { return default(string); }
    public static bool ForceOutOfProcTracking(Microsoft.Build.Utilities.ExecutableType toolType) { return default(bool); }
    public static bool ForceOutOfProcTracking(Microsoft.Build.Utilities.ExecutableType toolType, string dllName, string cancelEventName) { return default(bool); }
    public static string FormatRootingMarker(Microsoft.Build.Framework.ITaskItem source) { return default(string); }
    public static string FormatRootingMarker(Microsoft.Build.Framework.ITaskItem source, Microsoft.Build.Framework.ITaskItem output) { return default(string); }
    public static string FormatRootingMarker(Microsoft.Build.Framework.ITaskItem[] sources) { return default(string); }
    public static string FormatRootingMarker(Microsoft.Build.Framework.ITaskItem[] sources, Microsoft.Build.Framework.ITaskItem[] outputs) { return default(string); }
    public static string GetFileTrackerPath(Microsoft.Build.Utilities.ExecutableType toolType) { return default(string); }
    public static string GetFileTrackerPath(Microsoft.Build.Utilities.ExecutableType toolType, string rootPath) { return default(string); }
    public static string GetTrackerPath(Microsoft.Build.Utilities.ExecutableType toolType) { return default(string); }
    public static string GetTrackerPath(Microsoft.Build.Utilities.ExecutableType toolType, string rootPath) { return default(string); }
    public static void ResumeTracking() { }
    public static void SetThreadCount(int threadCount) { }
    public static System.Diagnostics.Process StartProcess(string command, string arguments, Microsoft.Build.Utilities.ExecutableType toolType) { return default(System.Diagnostics.Process); }
    public static System.Diagnostics.Process StartProcess(string command, string arguments, Microsoft.Build.Utilities.ExecutableType toolType, string rootFiles) { return default(System.Diagnostics.Process); }
    public static System.Diagnostics.Process StartProcess(string command, string arguments, Microsoft.Build.Utilities.ExecutableType toolType, string intermediateDirectory, string rootFiles) { return default(System.Diagnostics.Process); }
    public static System.Diagnostics.Process StartProcess(string command, string arguments, Microsoft.Build.Utilities.ExecutableType toolType, string dllName, string intermediateDirectory, string rootFiles) { return default(System.Diagnostics.Process); }
    public static System.Diagnostics.Process StartProcess(string command, string arguments, Microsoft.Build.Utilities.ExecutableType toolType, string dllName, string intermediateDirectory, string rootFiles, string cancelEventName) { return default(System.Diagnostics.Process); }
    public static void StartTrackingContext(string intermediateDirectory, string taskName) { }
    public static void StartTrackingContextWithRoot(string intermediateDirectory, string taskName, string rootMarkerResponseFile) { }
    public static void StopTrackingAndCleanup() { }
    public static void SuspendTracking() { }
    public static string TrackerArguments(string command, string arguments, string dllName, string intermediateDirectory, string rootFiles) { return default(string); }
    public static string TrackerArguments(string command, string arguments, string dllName, string intermediateDirectory, string rootFiles, string cancelEventName) { return default(string); }
    public static string TrackerCommandArguments(string command, string arguments) { return default(string); }
    public static string TrackerResponseFileArguments(string dllName, string intermediateDirectory, string rootFiles) { return default(string); }
    public static string TrackerResponseFileArguments(string dllName, string intermediateDirectory, string rootFiles, string cancelEventName) { return default(string); }
    public static void WriteAllTLogs(string intermediateDirectory, string taskName) { }
    public static void WriteContextTLogs(string intermediateDirectory, string taskName) { }
  }
  public partial class FlatTrackingData {
    public FlatTrackingData(Microsoft.Build.Framework.ITask ownerTask, Microsoft.Build.Framework.ITaskItem[] tlogFiles, bool skipMissingFiles) { }
    public FlatTrackingData(Microsoft.Build.Framework.ITask ownerTask, Microsoft.Build.Framework.ITaskItem[] tlogFiles, System.DateTime missingFileTimeUtc) { }
    public FlatTrackingData(Microsoft.Build.Framework.ITaskItem[] tlogFiles, Microsoft.Build.Framework.ITaskItem[] tlogFilesToIgnore, System.DateTime missingFileTimeUtc) { }
    public FlatTrackingData(Microsoft.Build.Framework.ITaskItem[] tlogFiles, Microsoft.Build.Framework.ITaskItem[] tlogFilesToIgnore, System.DateTime missingFileTimeUtc, System.String[] excludedInputPaths, System.Collections.Generic.IDictionary<System.String, System.DateTime> sharedLastWriteTimeUtcCache) { }
    public FlatTrackingData(Microsoft.Build.Framework.ITaskItem[] tlogFiles, bool skipMissingFiles) { }
    public FlatTrackingData(Microsoft.Build.Framework.ITaskItem[] tlogFiles, System.DateTime missingFileTimeUtc) { }
    public System.Collections.Generic.IDictionary<System.String, System.DateTime> DependencyTable { get { return default(System.Collections.Generic.IDictionary<System.String, System.DateTime>); } }
    public System.Collections.Generic.List<System.String> MissingFiles { get { return default(System.Collections.Generic.List<System.String>); } set { } }
    public string NewestFileName { get { return default(string); } set { } }
    public System.DateTime NewestFileTime { get { return default(System.DateTime); } set { } }
    public System.DateTime NewestFileTimeUtc { get { return default(System.DateTime); } set { } }
    public string NewestTLogFileName { get { return default(string); } set { } }
    public System.DateTime NewestTLogTime { get { return default(System.DateTime); } set { } }
    public System.DateTime NewestTLogTimeUtc { get { return default(System.DateTime); } set { } }
    public string OldestFileName { get { return default(string); } set { } }
    public System.DateTime OldestFileTime { get { return default(System.DateTime); } set { } }
    public System.DateTime OldestFileTimeUtc { get { return default(System.DateTime); } set { } }
    public bool SkipMissingFiles { get { return default(bool); } set { } }
    public Microsoft.Build.Framework.ITaskItem[] TlogFiles { get { return default(Microsoft.Build.Framework.ITaskItem[]); } set { } }
    public bool TlogsAvailable { get { return default(bool); } set { } }
    public bool TreatRootMarkersAsEntries { get { return default(bool); } set { } }
    public bool FileIsExcludedFromDependencyCheck(string fileName) { return default(bool); }
    public static void FinalizeTLogs(bool trackedOperationsSucceeded, Microsoft.Build.Framework.ITaskItem[] readTLogNames, Microsoft.Build.Framework.ITaskItem[] writeTLogNames, Microsoft.Build.Framework.ITaskItem[] trackedFilesToRemoveFromTLogs) { }
    public System.DateTime GetLastWriteTimeUtc(string file) { return default(System.DateTime); }
    public static bool IsUpToDate(Microsoft.Build.Utilities.Task hostTask, Microsoft.Build.Utilities.UpToDateCheckType upToDateCheckType, Microsoft.Build.Framework.ITaskItem[] readTLogNames, Microsoft.Build.Framework.ITaskItem[] writeTLogNames) { return default(bool); }
    public static bool IsUpToDate(Microsoft.Build.Utilities.TaskLoggingHelper Log, Microsoft.Build.Utilities.UpToDateCheckType upToDateCheckType, Microsoft.Build.Utilities.FlatTrackingData inputs, Microsoft.Build.Utilities.FlatTrackingData outputs) { return default(bool); }
    public void SaveTlog() { }
    public void SaveTlog(Microsoft.Build.Utilities.DependencyFilter includeInTLog) { }
    public void UpdateFileEntryDetails() { }
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
    public bool IsVerbosityAtLeast(Microsoft.Build.Framework.LoggerVerbosity checkVerbosity) { return default(bool); }
    public virtual void Shutdown() { }
  }
  public partial class MuxLogger : Microsoft.Build.Framework.ILogger, Microsoft.Build.Framework.INodeLogger {
    public MuxLogger() { }
    public string Parameters { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public Microsoft.Build.Framework.LoggerVerbosity Verbosity { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(Microsoft.Build.Framework.LoggerVerbosity); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public void Initialize(Microsoft.Build.Framework.IEventSource eventSource) { }
    public void Initialize(Microsoft.Build.Framework.IEventSource eventSource, int maxNodeCount) { }
    public void RegisterLogger(int submissionId, Microsoft.Build.Framework.ILogger logger) { }
    public void Shutdown() { }
    public bool UnregisterLoggers(int submissionId) { return default(bool); }
  }
  public static partial class ProcessorArchitecture {
    public const string AMD64 = "AMD64";
    public const string ARM = "ARM";
    public const string IA64 = "IA64";
    public const string MSIL = "MSIL";
    public const string X86 = "x86";
    public static string CurrentProcessArchitecture { get { return default(string); } }
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
  public partial class TargetPlatformSDK : System.IEquatable<Microsoft.Build.Utilities.TargetPlatformSDK> {
    public TargetPlatformSDK(string targetPlatformIdentifier, System.Version targetPlatformVersion, string path) { }
    public string Path { get { return default(string); } set { } }
    public string TargetPlatformIdentifier { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
    public System.Version TargetPlatformVersion { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Version); } }
    public bool Equals(Microsoft.Build.Utilities.TargetPlatformSDK other) { return default(bool); }
    public override bool Equals(object obj) { return default(bool); }
    public override int GetHashCode() { return default(int); }
  }
  public abstract partial class Task : Microsoft.Build.Framework.ITask {
    protected Task() { }
    protected Task(System.Resources.ResourceManager taskResources) { }
    protected Task(System.Resources.ResourceManager taskResources, string helpKeywordPrefix) { }
    public Microsoft.Build.Framework.IBuildEngine BuildEngine { get { return default(Microsoft.Build.Framework.IBuildEngine); } set { } }
    public Microsoft.Build.Framework.IBuildEngine2 BuildEngine2 { get { return default(Microsoft.Build.Framework.IBuildEngine2); } }
    public Microsoft.Build.Framework.IBuildEngine3 BuildEngine3 { get { return default(Microsoft.Build.Framework.IBuildEngine3); } }
    public Microsoft.Build.Framework.IBuildEngine4 BuildEngine4 { get { return default(Microsoft.Build.Framework.IBuildEngine4); } }
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
    [System.Security.SecurityCriticalAttribute]
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
    public TaskLoggingHelper(Microsoft.Build.Framework.IBuildEngine buildEngine, string taskName) { }
    public TaskLoggingHelper(Microsoft.Build.Framework.ITask taskInstance) { }
    protected Microsoft.Build.Framework.IBuildEngine BuildEngine { get { return default(Microsoft.Build.Framework.IBuildEngine); } }
    public bool HasLoggedErrors { get { return default(bool); } }
    public string HelpKeywordPrefix { get { return default(string); } set { } }
    protected string TaskName { get { return default(string); } }
    public System.Resources.ResourceManager TaskResources { get { return default(System.Resources.ResourceManager); } set { } }
    public string ExtractMessageCode(string message, out string messageWithoutCodePrefix) { messageWithoutCodePrefix = default(string); return default(string); }
    public virtual string FormatResourceString(string resourceName, params System.Object[] args) { return default(string); }
    public virtual string FormatString(string unformatted, params System.Object[] args) { return default(string); }
    public virtual string GetResourceMessage(string resourceName) { return default(string); }
    public override object InitializeLifetimeService() { return default(object); }
    public void LogCommandLine(Microsoft.Build.Framework.MessageImportance importance, string commandLine) { }
    public void LogCommandLine(string commandLine) { }
    public void LogCriticalMessage(string subcategory, string code, string helpKeyword, string file, int lineNumber, int columnNumber, int endLineNumber, int endColumnNumber, string message, params System.Object[] messageArgs) { }
    public void LogError(string message, params System.Object[] messageArgs) { }
    public void LogError(string subcategory, string errorCode, string helpKeyword, string file, int lineNumber, int columnNumber, int endLineNumber, int endColumnNumber, string message, params System.Object[] messageArgs) { }
    public void LogErrorFromException(System.Exception exception) { }
    public void LogErrorFromException(System.Exception exception, bool showStackTrace) { }
    public void LogErrorFromException(System.Exception exception, bool showStackTrace, bool showDetail, string file) { }
    public void LogErrorFromResources(string messageResourceName, params System.Object[] messageArgs) { }
    public void LogErrorFromResources(string subcategoryResourceName, string errorCode, string helpKeyword, string file, int lineNumber, int columnNumber, int endLineNumber, int endColumnNumber, string messageResourceName, params System.Object[] messageArgs) { }
    public void LogErrorWithCodeFromResources(string messageResourceName, params System.Object[] messageArgs) { }
    public void LogErrorWithCodeFromResources(string subcategoryResourceName, string file, int lineNumber, int columnNumber, int endLineNumber, int endColumnNumber, string messageResourceName, params System.Object[] messageArgs) { }
    public void LogExternalProjectFinished(string message, string helpKeyword, string projectFile, bool succeeded) { }
    public void LogExternalProjectStarted(string message, string helpKeyword, string projectFile, string targetNames) { }
    public void LogMessage(Microsoft.Build.Framework.MessageImportance importance, string message, params System.Object[] messageArgs) { }
    public void LogMessage(string message, params System.Object[] messageArgs) { }
    public void LogMessage(string subcategory, string code, string helpKeyword, string file, int lineNumber, int columnNumber, int endLineNumber, int endColumnNumber, Microsoft.Build.Framework.MessageImportance importance, string message, params System.Object[] messageArgs) { }
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
    public void MarkAsInactive() { }
  }
  public static partial class ToolLocationHelper {
    public static string PathToSystem { get { return default(string); } }
    public static void ClearSDKStaticCache() { }
    public static System.Collections.Generic.IList<Microsoft.Build.Utilities.AssemblyFoldersExInfo> GetAssemblyFoldersExInfo(string registryRoot, string targetFrameworkVersion, string registryKeySuffix, string osVersion, string platform, System.Reflection.ProcessorArchitecture targetProcessorArchitecture) { return default(System.Collections.Generic.IList<Microsoft.Build.Utilities.AssemblyFoldersExInfo>); }
    public static string GetDisplayNameForTargetFrameworkDirectory(string targetFrameworkDirectory, System.Runtime.Versioning.FrameworkName frameworkName) { return default(string); }
    public static string GetDotNetFrameworkRootRegistryKey(Microsoft.Build.Utilities.TargetDotNetFrameworkVersion version) { return default(string); }
    public static string GetDotNetFrameworkSdkInstallKeyValue(Microsoft.Build.Utilities.TargetDotNetFrameworkVersion version) { return default(string); }
    public static string GetDotNetFrameworkSdkInstallKeyValue(Microsoft.Build.Utilities.TargetDotNetFrameworkVersion version, Microsoft.Build.Utilities.VisualStudioVersion visualStudioVersion) { return default(string); }
    public static string GetDotNetFrameworkSdkRootRegistryKey(Microsoft.Build.Utilities.TargetDotNetFrameworkVersion version) { return default(string); }
    public static string GetDotNetFrameworkSdkRootRegistryKey(Microsoft.Build.Utilities.TargetDotNetFrameworkVersion version, Microsoft.Build.Utilities.VisualStudioVersion visualStudioVersion) { return default(string); }
    public static string GetDotNetFrameworkVersionFolderPrefix(Microsoft.Build.Utilities.TargetDotNetFrameworkVersion version) { return default(string); }
    public static string GetPathToDotNetFramework(Microsoft.Build.Utilities.TargetDotNetFrameworkVersion version) { return default(string); }
    public static string GetPathToDotNetFramework(Microsoft.Build.Utilities.TargetDotNetFrameworkVersion version, Microsoft.Build.Utilities.DotNetFrameworkArchitecture architecture) { return default(string); }
    public static string GetPathToDotNetFrameworkFile(string fileName, Microsoft.Build.Utilities.TargetDotNetFrameworkVersion version) { return default(string); }
    public static string GetPathToDotNetFrameworkFile(string fileName, Microsoft.Build.Utilities.TargetDotNetFrameworkVersion version, Microsoft.Build.Utilities.DotNetFrameworkArchitecture architecture) { return default(string); }
    public static string GetPathToDotNetFrameworkReferenceAssemblies(Microsoft.Build.Utilities.TargetDotNetFrameworkVersion version) { return default(string); }
    public static string GetPathToDotNetFrameworkSdk(Microsoft.Build.Utilities.TargetDotNetFrameworkVersion version) { return default(string); }
    public static string GetPathToDotNetFrameworkSdk(Microsoft.Build.Utilities.TargetDotNetFrameworkVersion version, Microsoft.Build.Utilities.VisualStudioVersion visualStudioVersion) { return default(string); }
    public static string GetPathToDotNetFrameworkSdkFile(string fileName, Microsoft.Build.Utilities.TargetDotNetFrameworkVersion version) { return default(string); }
    public static string GetPathToDotNetFrameworkSdkFile(string fileName, Microsoft.Build.Utilities.TargetDotNetFrameworkVersion version, Microsoft.Build.Utilities.DotNetFrameworkArchitecture architecture) { return default(string); }
    public static string GetPathToDotNetFrameworkSdkFile(string fileName, Microsoft.Build.Utilities.TargetDotNetFrameworkVersion version, Microsoft.Build.Utilities.VisualStudioVersion visualStudioVersion) { return default(string); }
    public static string GetPathToDotNetFrameworkSdkFile(string fileName, Microsoft.Build.Utilities.TargetDotNetFrameworkVersion version, Microsoft.Build.Utilities.VisualStudioVersion visualStudioVersion, Microsoft.Build.Utilities.DotNetFrameworkArchitecture architecture) { return default(string); }
    public static System.Collections.Generic.IList<System.String> GetPathToReferenceAssemblies(System.Runtime.Versioning.FrameworkName frameworkName) { return default(System.Collections.Generic.IList<System.String>); }
    public static System.Collections.Generic.IList<System.String> GetPathToReferenceAssemblies(string targetFrameworkRootPath, System.Runtime.Versioning.FrameworkName frameworkName) { return default(System.Collections.Generic.IList<System.String>); }
    public static System.Collections.Generic.IList<System.String> GetPathToReferenceAssemblies(string targetFrameworkIdentifier, string targetFrameworkVersion, string targetFrameworkProfile) { return default(System.Collections.Generic.IList<System.String>); }
    public static string GetPathToStandardLibraries(string targetFrameworkIdentifier, string targetFrameworkVersion, string targetFrameworkProfile) { return default(string); }
    public static string GetPathToStandardLibraries(string targetFrameworkIdentifier, string targetFrameworkVersion, string targetFrameworkProfile, string platformTarget) { return default(string); }
    public static string GetPathToSystemFile(string fileName) { return default(string); }
    public static string GetPathToWindowsSdk(Microsoft.Build.Utilities.TargetDotNetFrameworkVersion version, Microsoft.Build.Utilities.VisualStudioVersion visualStudioVersion) { return default(string); }
    public static string GetPathToWindowsSdkFile(string fileName, Microsoft.Build.Utilities.TargetDotNetFrameworkVersion version, Microsoft.Build.Utilities.VisualStudioVersion visualStudioVersion) { return default(string); }
    public static string GetPathToWindowsSdkFile(string fileName, Microsoft.Build.Utilities.TargetDotNetFrameworkVersion version, Microsoft.Build.Utilities.VisualStudioVersion visualStudioVersion, Microsoft.Build.Utilities.DotNetFrameworkArchitecture architecture) { return default(string); }
    public static string GetPlatformExtensionSDKLocation(string sdkMoniker, string targetPlatformIdentifier, string targetPlatformVersion) { return default(string); }
    public static string GetPlatformExtensionSDKLocation(string sdkMoniker, string targetPlatformIdentifier, string targetPlatformVersion, string diskRoots, string registryRoot) { return default(string); }
    public static string GetPlatformExtensionSDKLocation(string sdkMoniker, string targetPlatformIdentifier, System.Version targetPlatformVersion) { return default(string); }
    public static string GetPlatformExtensionSDKLocation(string sdkMoniker, string targetPlatformIdentifier, System.Version targetPlatformVersion, System.String[] diskRoots, string registryRoot) { return default(string); }
    public static System.Collections.Generic.IDictionary<System.String, System.String> GetPlatformExtensionSDKLocations(string targetPlatformIdentifier, System.Version targetPlatformVersion) { return default(System.Collections.Generic.IDictionary<System.String, System.String>); }
    public static System.Collections.Generic.IDictionary<System.String, System.String> GetPlatformExtensionSDKLocations(System.String[] diskRoots, string registryRoot, string targetPlatformIdentifier, System.Version targetPlatformVersion) { return default(System.Collections.Generic.IDictionary<System.String, System.String>); }
    public static string GetPlatformSDKLocation(string targetPlatformIdentifier, string targetPlatformVersion) { return default(string); }
    public static string GetPlatformSDKLocation(string targetPlatformIdentifier, string targetPlatformVersion, string diskRoots, string registryRoot) { return default(string); }
    public static string GetPlatformSDKLocation(string targetPlatformIdentifier, System.Version targetPlatformVersion) { return default(string); }
    public static string GetPlatformSDKLocation(string targetPlatformIdentifier, System.Version targetPlatformVersion, System.String[] diskRoots, string registryRoot) { return default(string); }
    public static string GetProgramFilesReferenceAssemblyRoot() { return default(string); }
    public static System.Collections.Generic.IList<System.String> GetSDKDesignTimeFolders(string sdkRoot) { return default(System.Collections.Generic.IList<System.String>); }
    public static System.Collections.Generic.IList<System.String> GetSDKDesignTimeFolders(string sdkRoot, string targetConfiguration, string targetArchitecture) { return default(System.Collections.Generic.IList<System.String>); }
    public static System.Collections.Generic.IList<System.String> GetSDKRedistFolders(string sdkRoot) { return default(System.Collections.Generic.IList<System.String>); }
    public static System.Collections.Generic.IList<System.String> GetSDKRedistFolders(string sdkRoot, string targetConfiguration, string targetArchitecture) { return default(System.Collections.Generic.IList<System.String>); }
    public static System.Collections.Generic.IList<System.String> GetSDKReferenceFolders(string sdkRoot) { return default(System.Collections.Generic.IList<System.String>); }
    public static System.Collections.Generic.IList<System.String> GetSDKReferenceFolders(string sdkRoot, string targetConfiguration, string targetArchitecture) { return default(System.Collections.Generic.IList<System.String>); }
    public static System.Collections.Generic.IList<System.String> GetSupportedTargetFrameworks() { return default(System.Collections.Generic.IList<System.String>); }
    public static System.Collections.Generic.IList<Microsoft.Build.Utilities.TargetPlatformSDK> GetTargetPlatformSdks() { return default(System.Collections.Generic.IList<Microsoft.Build.Utilities.TargetPlatformSDK>); }
    public static System.Collections.Generic.IList<Microsoft.Build.Utilities.TargetPlatformSDK> GetTargetPlatformSdks(System.String[] diskRoots, string registryRoot) { return default(System.Collections.Generic.IList<Microsoft.Build.Utilities.TargetPlatformSDK>); }
    public static System.Runtime.Versioning.FrameworkName HighestVersionOfTargetFrameworkIdentifier(string targetFrameworkRootDirectory, string frameworkIdentifier) { return default(System.Runtime.Versioning.FrameworkName); }
  }
  public abstract partial class ToolTask : Microsoft.Build.Utilities.Task, Microsoft.Build.Framework.ICancelableTask, Microsoft.Build.Framework.ITask {
    protected ToolTask() { }
    protected ToolTask(System.Resources.ResourceManager taskResources) { }
    protected ToolTask(System.Resources.ResourceManager taskResources, string helpKeywordPrefix) { }
    public bool EchoOff { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ObsoleteAttribute("Use EnvironmentVariables property")]
    protected virtual System.Collections.Specialized.StringDictionary EnvironmentOverride { get { return default(System.Collections.Specialized.StringDictionary); } }
    public System.String[] EnvironmentVariables { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.String[]); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [Microsoft.Build.Framework.OutputAttribute]
    public int ExitCode { get { return default(int); } }
    protected virtual bool HasLoggedErrors { get { return default(bool); } }
    public bool LogStandardErrorAsError { get { return default(bool); } set { } }
    protected virtual System.Text.Encoding ResponseFileEncoding { get { return default(System.Text.Encoding); } }
    protected virtual System.Text.Encoding StandardErrorEncoding { get { return default(System.Text.Encoding); } }
    public string StandardErrorImportance { get { return default(string); } set { } }
    protected Microsoft.Build.Framework.MessageImportance StandardErrorImportanceToUse { get { return default(Microsoft.Build.Framework.MessageImportance); } }
    protected virtual Microsoft.Build.Framework.MessageImportance StandardErrorLoggingImportance { get { return default(Microsoft.Build.Framework.MessageImportance); } }
    protected virtual System.Text.Encoding StandardOutputEncoding { get { return default(System.Text.Encoding); } }
    public string StandardOutputImportance { get { return default(string); } set { } }
    protected Microsoft.Build.Framework.MessageImportance StandardOutputImportanceToUse { get { return default(Microsoft.Build.Framework.MessageImportance); } }
    protected virtual Microsoft.Build.Framework.MessageImportance StandardOutputLoggingImportance { get { return default(Microsoft.Build.Framework.MessageImportance); } }
    protected int TaskProcessTerminationTimeout { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(int); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public virtual int Timeout { get { return default(int); } set { } }
    protected System.Threading.ManualResetEvent ToolCanceled { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Threading.ManualResetEvent); } }
    public virtual string ToolExe { get { return default(string); } set { } }
    protected abstract string ToolName { get; }
    public string ToolPath { get { return default(string); } set { } }
    public bool UseCommandProcessor { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public bool YieldDuringToolExecution { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
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
    protected virtual string GetWorkingDirectory() { return default(string); }
    protected virtual bool HandleTaskExecutionErrors() { return default(bool); }
    protected virtual Microsoft.Build.Utilities.HostObjectInitializationStatus InitializeHostObject() { return default(Microsoft.Build.Utilities.HostObjectInitializationStatus); }
    protected virtual void LogEventsFromTextOutput(string singleLine, Microsoft.Build.Framework.MessageImportance messageImportance) { }
    protected virtual void LogPathToTool(string toolName, string pathToTool) { }
    protected virtual void LogToolCommand(string message) { }
    protected virtual string ResponseFileEscape(string responseString) { return default(string); }
    protected virtual bool SkipTaskExecution() { return default(bool); }
    protected internal virtual bool ValidateParameters() { return default(bool); }
  }
  public static partial class TrackedDependencies {
    public static Microsoft.Build.Framework.ITaskItem[] ExpandWildcards(Microsoft.Build.Framework.ITaskItem[] expand) { return default(Microsoft.Build.Framework.ITaskItem[]); }
  }
  public enum UpToDateCheckType {
    InputNewerThanOutput = 0,
    InputNewerThanTracking = 2,
    InputOrOutputNewerThanTracking = 1,
  }
  public enum VisualStudioVersion {
    Version100 = 0,
    Version110 = 1,
    VersionLatest = 1,
  }
}
