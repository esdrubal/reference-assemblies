namespace Microsoft.Build.Framework {
  public delegate void AnyEventHandler(object sender, Microsoft.Build.Framework.BuildEventArgs e);
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct BuildEngineResult {
    public BuildEngineResult(bool result, System.Collections.Generic.List<System.Collections.Generic.IDictionary<System.String, Microsoft.Build.Framework.ITaskItem[]>> targetOutputsPerProject) { throw new System.NotImplementedException(); }
    public bool Result { get { return default(bool); } }
    public System.Collections.Generic.IList<System.Collections.Generic.IDictionary<System.String, Microsoft.Build.Framework.ITaskItem[]>> TargetOutputsPerProject { get { return default(System.Collections.Generic.IList<System.Collections.Generic.IDictionary<System.String, Microsoft.Build.Framework.ITaskItem[]>>); } }
  }
  public partial class BuildErrorEventArgs : Microsoft.Build.Framework.LazyFormattedBuildEventArgs {
    protected BuildErrorEventArgs() { }
    public BuildErrorEventArgs(string subcategory, string code, string file, int lineNumber, int columnNumber, int endLineNumber, int endColumnNumber, string message, string helpKeyword, string senderName) { }
    public BuildErrorEventArgs(string subcategory, string code, string file, int lineNumber, int columnNumber, int endLineNumber, int endColumnNumber, string message, string helpKeyword, string senderName, System.DateTime eventTimestamp) { }
    public BuildErrorEventArgs(string subcategory, string code, string file, int lineNumber, int columnNumber, int endLineNumber, int endColumnNumber, string message, string helpKeyword, string senderName, System.DateTime eventTimestamp, params System.Object[] messageArgs) { }
    public string Code { get { return default(string); } }
    public int ColumnNumber { get { return default(int); } }
    public int EndColumnNumber { get { return default(int); } }
    public int EndLineNumber { get { return default(int); } }
    public string File { get { return default(string); } }
    public int LineNumber { get { return default(int); } }
    public string ProjectFile { get { return default(string); } set { } }
    public string Subcategory { get { return default(string); } }
  }
  public delegate void BuildErrorEventHandler(object sender, Microsoft.Build.Framework.BuildErrorEventArgs e);
  public abstract partial class BuildEventArgs : System.EventArgs {
    protected BuildEventArgs() { }
    protected BuildEventArgs(string message, string helpKeyword, string senderName) { }
    protected BuildEventArgs(string message, string helpKeyword, string senderName, System.DateTime eventTimestamp) { }
    public Microsoft.Build.Framework.BuildEventContext BuildEventContext { get { return default(Microsoft.Build.Framework.BuildEventContext); } set { } }
    public string HelpKeyword { get { return default(string); } }
    public virtual string Message { get { return default(string); } protected set { } }
    public string SenderName { get { return default(string); } }
    public int ThreadId { get { return default(int); } }
    public System.DateTime Timestamp { get { return default(System.DateTime); } }
  }
  public partial class BuildEventContext {
    public const int InvalidNodeId = -2;
    public const int InvalidProjectContextId = -2;
    public const int InvalidProjectInstanceId = -1;
    public const int InvalidSubmissionId = -1;
    public const int InvalidTargetId = -1;
    public const int InvalidTaskId = -1;
    public BuildEventContext(int nodeId, int targetId, int projectContextId, int taskId) { }
    public BuildEventContext(int nodeId, int projectInstanceId, int projectContextId, int targetId, int taskId) { }
    public BuildEventContext(int submissionId, int nodeId, int projectInstanceId, int projectContextId, int targetId, int taskId) { }
    public long BuildRequestId { get { return default(long); } }
    public static Microsoft.Build.Framework.BuildEventContext Invalid { get { return default(Microsoft.Build.Framework.BuildEventContext); } }
    public int NodeId { get { return default(int); } }
    public int ProjectContextId { get { return default(int); } }
    public int ProjectInstanceId { get { return default(int); } }
    public int SubmissionId { get { return default(int); } }
    public int TargetId { get { return default(int); } }
    public int TaskId { get { return default(int); } }
    public override bool Equals(object obj) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public static bool operator ==(Microsoft.Build.Framework.BuildEventContext left, Microsoft.Build.Framework.BuildEventContext right) { return default(bool); }
    public static bool operator !=(Microsoft.Build.Framework.BuildEventContext left, Microsoft.Build.Framework.BuildEventContext right) { return default(bool); }
  }
  public partial class BuildFinishedEventArgs : Microsoft.Build.Framework.BuildStatusEventArgs {
    protected BuildFinishedEventArgs() { }
    public BuildFinishedEventArgs(string message, string helpKeyword, bool succeeded) { }
    public BuildFinishedEventArgs(string message, string helpKeyword, bool succeeded, System.DateTime eventTimestamp) { }
    public BuildFinishedEventArgs(string message, string helpKeyword, bool succeeded, System.DateTime eventTimestamp, params System.Object[] messageArgs) { }
    public bool Succeeded { get { return default(bool); } }
  }
  public delegate void BuildFinishedEventHandler(object sender, Microsoft.Build.Framework.BuildFinishedEventArgs e);
  public partial class BuildMessageEventArgs : Microsoft.Build.Framework.LazyFormattedBuildEventArgs {
    protected BuildMessageEventArgs() { }
    public BuildMessageEventArgs(string message, string helpKeyword, string senderName, Microsoft.Build.Framework.MessageImportance importance) { }
    public BuildMessageEventArgs(string message, string helpKeyword, string senderName, Microsoft.Build.Framework.MessageImportance importance, System.DateTime eventTimestamp) { }
    public BuildMessageEventArgs(string message, string helpKeyword, string senderName, Microsoft.Build.Framework.MessageImportance importance, System.DateTime eventTimestamp, params System.Object[] messageArgs) { }
    public BuildMessageEventArgs(string subcategory, string code, string file, int lineNumber, int columnNumber, int endLineNumber, int endColumnNumber, string message, string helpKeyword, string senderName, Microsoft.Build.Framework.MessageImportance importance) { }
    public BuildMessageEventArgs(string subcategory, string code, string file, int lineNumber, int columnNumber, int endLineNumber, int endColumnNumber, string message, string helpKeyword, string senderName, Microsoft.Build.Framework.MessageImportance importance, System.DateTime eventTimestamp) { }
    public BuildMessageEventArgs(string subcategory, string code, string file, int lineNumber, int columnNumber, int endLineNumber, int endColumnNumber, string message, string helpKeyword, string senderName, Microsoft.Build.Framework.MessageImportance importance, System.DateTime eventTimestamp, params System.Object[] messageArgs) { }
    public string Code { get { return default(string); } }
    public int ColumnNumber { get { return default(int); } }
    public int EndColumnNumber { get { return default(int); } }
    public int EndLineNumber { get { return default(int); } }
    public string File { get { return default(string); } }
    public Microsoft.Build.Framework.MessageImportance Importance { get { return default(Microsoft.Build.Framework.MessageImportance); } }
    public int LineNumber { get { return default(int); } }
    public string ProjectFile { get { return default(string); } set { } }
    public string Subcategory { get { return default(string); } }
  }
  public delegate void BuildMessageEventHandler(object sender, Microsoft.Build.Framework.BuildMessageEventArgs e);
  public partial class BuildStartedEventArgs : Microsoft.Build.Framework.BuildStatusEventArgs {
    protected BuildStartedEventArgs() { }
    public BuildStartedEventArgs(string message, string helpKeyword) { }
    public BuildStartedEventArgs(string message, string helpKeyword, System.Collections.Generic.IDictionary<System.String, System.String> environmentOfBuild) { }
    public BuildStartedEventArgs(string message, string helpKeyword, System.DateTime eventTimestamp) { }
    public BuildStartedEventArgs(string message, string helpKeyword, System.DateTime eventTimestamp, params System.Object[] messageArgs) { }
    public System.Collections.Generic.IDictionary<System.String, System.String> BuildEnvironment { get { return default(System.Collections.Generic.IDictionary<System.String, System.String>); } }
  }
  public delegate void BuildStartedEventHandler(object sender, Microsoft.Build.Framework.BuildStartedEventArgs e);
  public abstract partial class BuildStatusEventArgs : Microsoft.Build.Framework.LazyFormattedBuildEventArgs {
    protected BuildStatusEventArgs() { }
    protected BuildStatusEventArgs(string message, string helpKeyword, string senderName) { }
    protected BuildStatusEventArgs(string message, string helpKeyword, string senderName, System.DateTime eventTimestamp) { }
    protected BuildStatusEventArgs(string message, string helpKeyword, string senderName, System.DateTime eventTimestamp, params System.Object[] messageArgs) { }
  }
  public delegate void BuildStatusEventHandler(object sender, Microsoft.Build.Framework.BuildStatusEventArgs e);
  public partial class BuildWarningEventArgs : Microsoft.Build.Framework.LazyFormattedBuildEventArgs {
    protected BuildWarningEventArgs() { }
    public BuildWarningEventArgs(string subcategory, string code, string file, int lineNumber, int columnNumber, int endLineNumber, int endColumnNumber, string message, string helpKeyword, string senderName) { }
    public BuildWarningEventArgs(string subcategory, string code, string file, int lineNumber, int columnNumber, int endLineNumber, int endColumnNumber, string message, string helpKeyword, string senderName, System.DateTime eventTimestamp) { }
    public BuildWarningEventArgs(string subcategory, string code, string file, int lineNumber, int columnNumber, int endLineNumber, int endColumnNumber, string message, string helpKeyword, string senderName, System.DateTime eventTimestamp, params System.Object[] messageArgs) { }
    public string Code { get { return default(string); } }
    public int ColumnNumber { get { return default(int); } }
    public int EndColumnNumber { get { return default(int); } }
    public int EndLineNumber { get { return default(int); } }
    public string File { get { return default(string); } }
    public int LineNumber { get { return default(int); } }
    public string ProjectFile { get { return default(string); } set { } }
    public string Subcategory { get { return default(string); } }
  }
  public delegate void BuildWarningEventHandler(object sender, Microsoft.Build.Framework.BuildWarningEventArgs e);
  public partial class CriticalBuildMessageEventArgs : Microsoft.Build.Framework.BuildMessageEventArgs {
    protected CriticalBuildMessageEventArgs() { }
    public CriticalBuildMessageEventArgs(string subcategory, string code, string file, int lineNumber, int columnNumber, int endLineNumber, int endColumnNumber, string message, string helpKeyword, string senderName) { }
    public CriticalBuildMessageEventArgs(string subcategory, string code, string file, int lineNumber, int columnNumber, int endLineNumber, int endColumnNumber, string message, string helpKeyword, string senderName, System.DateTime eventTimestamp) { }
    public CriticalBuildMessageEventArgs(string subcategory, string code, string file, int lineNumber, int columnNumber, int endLineNumber, int endColumnNumber, string message, string helpKeyword, string senderName, System.DateTime eventTimestamp, params System.Object[] messageArgs) { }
  }
  public abstract partial class CustomBuildEventArgs : Microsoft.Build.Framework.LazyFormattedBuildEventArgs {
    protected CustomBuildEventArgs() { }
    protected CustomBuildEventArgs(string message, string helpKeyword, string senderName) { }
    protected CustomBuildEventArgs(string message, string helpKeyword, string senderName, System.DateTime eventTimestamp) { }
    protected CustomBuildEventArgs(string message, string helpKeyword, string senderName, System.DateTime eventTimestamp, params System.Object[] messageArgs) { }
  }
  public delegate void CustomBuildEventHandler(object sender, Microsoft.Build.Framework.CustomBuildEventArgs e);
  public partial class ExternalProjectFinishedEventArgs : Microsoft.Build.Framework.CustomBuildEventArgs {
    protected ExternalProjectFinishedEventArgs() { }
    public ExternalProjectFinishedEventArgs(string message, string helpKeyword, string senderName, string projectFile, bool succeeded) { }
    public ExternalProjectFinishedEventArgs(string message, string helpKeyword, string senderName, string projectFile, bool succeeded, System.DateTime eventTimestamp) { }
    public string ProjectFile { get { return default(string); } }
    public bool Succeeded { get { return default(bool); } }
  }
  public partial class ExternalProjectStartedEventArgs : Microsoft.Build.Framework.CustomBuildEventArgs {
    protected ExternalProjectStartedEventArgs() { }
    public ExternalProjectStartedEventArgs(string message, string helpKeyword, string senderName, string projectFile, string targetNames) { }
    public ExternalProjectStartedEventArgs(string message, string helpKeyword, string senderName, string projectFile, string targetNames, System.DateTime eventTimestamp) { }
    public string ProjectFile { get { return default(string); } }
    public string TargetNames { get { return default(string); } }
  }
  public partial interface IBuildEngine {
    int ColumnNumberOfTaskNode { get; }
    bool ContinueOnError { get; }
    int LineNumberOfTaskNode { get; }
    string ProjectFileOfTaskNode { get; }
    bool BuildProjectFile(string projectFileName, System.String[] targetNames, System.Collections.IDictionary globalProperties, System.Collections.IDictionary targetOutputs);
    void LogCustomEvent(Microsoft.Build.Framework.CustomBuildEventArgs e);
    void LogErrorEvent(Microsoft.Build.Framework.BuildErrorEventArgs e);
    void LogMessageEvent(Microsoft.Build.Framework.BuildMessageEventArgs e);
    void LogWarningEvent(Microsoft.Build.Framework.BuildWarningEventArgs e);
  }
  public partial interface IBuildEngine2 : Microsoft.Build.Framework.IBuildEngine {
    bool IsRunningMultipleNodes { get; }
    bool BuildProjectFile(string projectFileName, System.String[] targetNames, System.Collections.IDictionary globalProperties, System.Collections.IDictionary targetOutputs, string toolsVersion);
    bool BuildProjectFilesInParallel(System.String[] projectFileNames, System.String[] targetNames, System.Collections.IDictionary[] globalProperties, System.Collections.IDictionary[] targetOutputsPerProject, System.String[] toolsVersion, bool useResultsCache, bool unloadProjectsOnCompletion);
  }
  public partial interface IBuildEngine3 : Microsoft.Build.Framework.IBuildEngine, Microsoft.Build.Framework.IBuildEngine2 {
    Microsoft.Build.Framework.BuildEngineResult BuildProjectFilesInParallel(System.String[] projectFileNames, System.String[] targetNames, System.Collections.IDictionary[] globalProperties, System.Collections.Generic.IList<System.String>[] removeGlobalProperties, System.String[] toolsVersion, bool returnTargetOutputs);
    void Reacquire();
    void Yield();
  }
  public partial interface IBuildEngine4 : Microsoft.Build.Framework.IBuildEngine, Microsoft.Build.Framework.IBuildEngine2, Microsoft.Build.Framework.IBuildEngine3 {
    object GetRegisteredTaskObject(object key, Microsoft.Build.Framework.RegisteredTaskObjectLifetime lifetime);
    void RegisterTaskObject(object key, object obj, Microsoft.Build.Framework.RegisteredTaskObjectLifetime lifetime, bool allowEarlyCollection);
    object UnregisterTaskObject(object key, Microsoft.Build.Framework.RegisteredTaskObjectLifetime lifetime);
  }
  public partial interface ICancelableTask : Microsoft.Build.Framework.ITask {
    void Cancel();
  }
  public partial interface IEventRedirector {
    void ForwardEvent(Microsoft.Build.Framework.BuildEventArgs buildEvent);
  }
  public partial interface IEventSource {
    event Microsoft.Build.Framework.AnyEventHandler AnyEventRaised;
    event Microsoft.Build.Framework.BuildFinishedEventHandler BuildFinished;
    event Microsoft.Build.Framework.BuildStartedEventHandler BuildStarted;
    event Microsoft.Build.Framework.CustomBuildEventHandler CustomEventRaised;
    event Microsoft.Build.Framework.BuildErrorEventHandler ErrorRaised;
    event Microsoft.Build.Framework.BuildMessageEventHandler MessageRaised;
    event Microsoft.Build.Framework.ProjectFinishedEventHandler ProjectFinished;
    event Microsoft.Build.Framework.ProjectStartedEventHandler ProjectStarted;
    event Microsoft.Build.Framework.BuildStatusEventHandler StatusEventRaised;
    event Microsoft.Build.Framework.TargetFinishedEventHandler TargetFinished;
    event Microsoft.Build.Framework.TargetStartedEventHandler TargetStarted;
    event Microsoft.Build.Framework.TaskFinishedEventHandler TaskFinished;
    event Microsoft.Build.Framework.TaskStartedEventHandler TaskStarted;
    event Microsoft.Build.Framework.BuildWarningEventHandler WarningRaised;
  }
  public partial interface IForwardingLogger : Microsoft.Build.Framework.ILogger, Microsoft.Build.Framework.INodeLogger {
    Microsoft.Build.Framework.IEventRedirector BuildEventRedirector { get; set; }
    int NodeId { get; set; }
  }
  public partial interface IGeneratedTask : Microsoft.Build.Framework.ITask {
    object GetPropertyValue(Microsoft.Build.Framework.TaskPropertyInfo property);
    void SetPropertyValue(Microsoft.Build.Framework.TaskPropertyInfo property, object value);
  }
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public partial interface ILogger {
    string Parameters { get; set; }
    Microsoft.Build.Framework.LoggerVerbosity Verbosity { get; set; }
    void Initialize(Microsoft.Build.Framework.IEventSource eventSource);
    void Shutdown();
  }
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public partial interface INodeLogger : Microsoft.Build.Framework.ILogger {
    void Initialize(Microsoft.Build.Framework.IEventSource eventSource, int nodeCount);
  }
  public partial interface ITask {
    Microsoft.Build.Framework.IBuildEngine BuildEngine { get; set; }
    Microsoft.Build.Framework.ITaskHost HostObject { get; set; }
    bool Execute();
  }
  public partial interface ITaskFactory {
    string FactoryName { get; }
    System.Type TaskType { get; }
    void CleanupTask(Microsoft.Build.Framework.ITask task);
    Microsoft.Build.Framework.ITask CreateTask(Microsoft.Build.Framework.IBuildEngine taskFactoryLoggingHost);
    Microsoft.Build.Framework.TaskPropertyInfo[] GetTaskParameters();
    bool Initialize(string taskName, System.Collections.Generic.IDictionary<System.String, Microsoft.Build.Framework.TaskPropertyInfo> parameterGroup, string taskBody, Microsoft.Build.Framework.IBuildEngine taskFactoryLoggingHost);
  }
  public partial interface ITaskFactory2 : Microsoft.Build.Framework.ITaskFactory {
    Microsoft.Build.Framework.ITask CreateTask(Microsoft.Build.Framework.IBuildEngine taskFactoryLoggingHost, System.Collections.Generic.IDictionary<System.String, System.String> taskIdentityParameters);
    bool Initialize(string taskName, System.Collections.Generic.IDictionary<System.String, System.String> factoryIdentityParameters, System.Collections.Generic.IDictionary<System.String, Microsoft.Build.Framework.TaskPropertyInfo> parameterGroup, string taskBody, Microsoft.Build.Framework.IBuildEngine taskFactoryLoggingHost);
  }
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  [System.Runtime.InteropServices.GuidAttribute("9049A481-D0E9-414f-8F92-D4F67A0359A6")]
  [System.Runtime.InteropServices.InterfaceTypeAttribute((System.Runtime.InteropServices.ComInterfaceType)(1))]
  public partial interface ITaskHost {
  }
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  [System.Runtime.InteropServices.GuidAttribute("8661674F-2148-4F71-A92A-49875511C528")]
  public partial interface ITaskItem {
    string ItemSpec { get; set; }
    int MetadataCount { get; }
    System.Collections.ICollection MetadataNames { get; }
    System.Collections.IDictionary CloneCustomMetadata();
    void CopyMetadataTo(Microsoft.Build.Framework.ITaskItem destinationItem);
    string GetMetadata(string metadataName);
    void RemoveMetadata(string metadataName);
    void SetMetadata(string metadataName, string metadataValue);
  }
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  [System.Runtime.InteropServices.GuidAttribute("ac6d5a59-f877-461b-88e3-b2f06fce0cb9")]
  public partial interface ITaskItem2 : Microsoft.Build.Framework.ITaskItem {
    string EvaluatedIncludeEscaped { get; set; }
    System.Collections.IDictionary CloneCustomMetadataEscaped();
    string GetMetadataValueEscaped(string metadataName);
    void SetMetadataValueLiteral(string metadataName, string metadataValue);
  }
  public partial class LazyFormattedBuildEventArgs : Microsoft.Build.Framework.BuildEventArgs {
    protected LazyFormattedBuildEventArgs() { }
    public LazyFormattedBuildEventArgs(string message, string helpKeyword, string senderName) { }
    public LazyFormattedBuildEventArgs(string message, string helpKeyword, string senderName, System.DateTime eventTimestamp, params System.Object[] messageArgs) { }
    public override string Message { get { return default(string); } }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(4), AllowMultiple=false, Inherited=true)]
  public sealed partial class LoadInSeparateAppDomainAttribute : System.Attribute {
    public LoadInSeparateAppDomainAttribute() { }
  }
  public partial class LoggerException : System.Exception {
    public LoggerException() { }
    protected LoggerException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public LoggerException(string message) { }
    public LoggerException(string message, System.Exception innerException) { }
    public LoggerException(string message, System.Exception innerException, string errorCode, string helpKeyword) { }
    public string ErrorCode { get { return default(string); } }
    public string HelpKeyword { get { return default(string); } }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, SerializationFormatter=true)]
    public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
  }
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public enum LoggerVerbosity {
    Detailed = 3,
    Diagnostic = 4,
    Minimal = 1,
    Normal = 2,
    Quiet = 0,
  }
  public enum MessageImportance {
    High = 0,
    Low = 2,
    Normal = 1,
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(128), AllowMultiple=false, Inherited=false)]
  public sealed partial class OutputAttribute : System.Attribute {
    public OutputAttribute() { }
  }
  public partial class ProjectFinishedEventArgs : Microsoft.Build.Framework.BuildStatusEventArgs {
    protected ProjectFinishedEventArgs() { }
    public ProjectFinishedEventArgs(string message, string helpKeyword, string projectFile, bool succeeded) { }
    public ProjectFinishedEventArgs(string message, string helpKeyword, string projectFile, bool succeeded, System.DateTime eventTimestamp) { }
    public string ProjectFile { get { return default(string); } }
    public bool Succeeded { get { return default(bool); } }
  }
  public delegate void ProjectFinishedEventHandler(object sender, Microsoft.Build.Framework.ProjectFinishedEventArgs e);
  public partial class ProjectStartedEventArgs : Microsoft.Build.Framework.BuildStatusEventArgs {
    public const int InvalidProjectId = -1;
    protected ProjectStartedEventArgs() { }
    public ProjectStartedEventArgs(int projectId, string message, string helpKeyword, string projectFile, string targetNames, System.Collections.IEnumerable properties, System.Collections.IEnumerable items, Microsoft.Build.Framework.BuildEventContext parentBuildEventContext) { }
    public ProjectStartedEventArgs(int projectId, string message, string helpKeyword, string projectFile, string targetNames, System.Collections.IEnumerable properties, System.Collections.IEnumerable items, Microsoft.Build.Framework.BuildEventContext parentBuildEventContext, System.Collections.Generic.IDictionary<System.String, System.String> globalProperties, string toolsVersion) { }
    public ProjectStartedEventArgs(int projectId, string message, string helpKeyword, string projectFile, string targetNames, System.Collections.IEnumerable properties, System.Collections.IEnumerable items, Microsoft.Build.Framework.BuildEventContext parentBuildEventContext, System.DateTime eventTimestamp) { }
    public ProjectStartedEventArgs(string message, string helpKeyword, string projectFile, string targetNames, System.Collections.IEnumerable properties, System.Collections.IEnumerable items) { }
    public ProjectStartedEventArgs(string message, string helpKeyword, string projectFile, string targetNames, System.Collections.IEnumerable properties, System.Collections.IEnumerable items, System.DateTime eventTimestamp) { }
    public System.Collections.Generic.IDictionary<System.String, System.String> GlobalProperties { get { return default(System.Collections.Generic.IDictionary<System.String, System.String>); } }
    public System.Collections.IEnumerable Items { get { return default(System.Collections.IEnumerable); } }
    public Microsoft.Build.Framework.BuildEventContext ParentProjectBuildEventContext { get { return default(Microsoft.Build.Framework.BuildEventContext); } }
    public string ProjectFile { get { return default(string); } }
    public int ProjectId { get { return default(int); } }
    public System.Collections.IEnumerable Properties { get { return default(System.Collections.IEnumerable); } }
    public string TargetNames { get { return default(string); } }
    public string ToolsVersion { get { return default(string); } }
  }
  public delegate void ProjectStartedEventHandler(object sender, Microsoft.Build.Framework.ProjectStartedEventArgs e);
  public enum RegisteredTaskObjectLifetime {
    AppDomain = 1,
    Build = 0,
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(128), AllowMultiple=false, Inherited=false)]
  public sealed partial class RequiredAttribute : System.Attribute {
    public RequiredAttribute() { }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(4), AllowMultiple=false, Inherited=false)]
  public sealed partial class RequiredRuntimeAttribute : System.Attribute {
    public RequiredRuntimeAttribute(string runtimeVersion) { }
    public string RuntimeVersion { get { return default(string); } }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(4), AllowMultiple=false, Inherited=false)]
  public sealed partial class RunInMTAAttribute : System.Attribute {
    public RunInMTAAttribute() { }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(4), AllowMultiple=false, Inherited=false)]
  public sealed partial class RunInSTAAttribute : System.Attribute {
    public RunInSTAAttribute() { }
  }
  public partial class TargetFinishedEventArgs : Microsoft.Build.Framework.BuildStatusEventArgs {
    protected TargetFinishedEventArgs() { }
    public TargetFinishedEventArgs(string message, string helpKeyword, string targetName, string projectFile, string targetFile, bool succeeded) { }
    public TargetFinishedEventArgs(string message, string helpKeyword, string targetName, string projectFile, string targetFile, bool succeeded, System.Collections.IEnumerable targetOutputs) { }
    public TargetFinishedEventArgs(string message, string helpKeyword, string targetName, string projectFile, string targetFile, bool succeeded, System.DateTime eventTimestamp, System.Collections.IEnumerable targetOutputs) { }
    public string ProjectFile { get { return default(string); } }
    public bool Succeeded { get { return default(bool); } }
    public string TargetFile { get { return default(string); } }
    public string TargetName { get { return default(string); } }
    public System.Collections.IEnumerable TargetOutputs { get { return default(System.Collections.IEnumerable); } set { } }
  }
  public delegate void TargetFinishedEventHandler(object sender, Microsoft.Build.Framework.TargetFinishedEventArgs e);
  public partial class TargetStartedEventArgs : Microsoft.Build.Framework.BuildStatusEventArgs {
    protected TargetStartedEventArgs() { }
    public TargetStartedEventArgs(string message, string helpKeyword, string targetName, string projectFile, string targetFile) { }
    public TargetStartedEventArgs(string message, string helpKeyword, string targetName, string projectFile, string targetFile, string parentTarget, System.DateTime eventTimestamp) { }
    public string ParentTarget { get { return default(string); } }
    public string ProjectFile { get { return default(string); } }
    public string TargetFile { get { return default(string); } }
    public string TargetName { get { return default(string); } }
  }
  public delegate void TargetStartedEventHandler(object sender, Microsoft.Build.Framework.TargetStartedEventArgs e);
  public partial class TaskCommandLineEventArgs : Microsoft.Build.Framework.BuildMessageEventArgs {
    protected TaskCommandLineEventArgs() { }
    public TaskCommandLineEventArgs(string commandLine, string taskName, Microsoft.Build.Framework.MessageImportance importance) { }
    public TaskCommandLineEventArgs(string commandLine, string taskName, Microsoft.Build.Framework.MessageImportance importance, System.DateTime eventTimestamp) { }
    public string CommandLine { get { return default(string); } }
    public string TaskName { get { return default(string); } }
  }
  public partial class TaskFinishedEventArgs : Microsoft.Build.Framework.BuildStatusEventArgs {
    protected TaskFinishedEventArgs() { }
    public TaskFinishedEventArgs(string message, string helpKeyword, string projectFile, string taskFile, string taskName, bool succeeded) { }
    public TaskFinishedEventArgs(string message, string helpKeyword, string projectFile, string taskFile, string taskName, bool succeeded, System.DateTime eventTimestamp) { }
    public string ProjectFile { get { return default(string); } }
    public bool Succeeded { get { return default(bool); } }
    public string TaskFile { get { return default(string); } }
    public string TaskName { get { return default(string); } }
  }
  public delegate void TaskFinishedEventHandler(object sender, Microsoft.Build.Framework.TaskFinishedEventArgs e);
  public partial class TaskPropertyInfo {
    public TaskPropertyInfo(string name, System.Type typeOfParameter, bool output, bool required) { }
    public string Name { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
    public bool Output { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } }
    public System.Type PropertyType { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Type); } }
    public bool Required { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } }
  }
  public partial class TaskStartedEventArgs : Microsoft.Build.Framework.BuildStatusEventArgs {
    protected TaskStartedEventArgs() { }
    public TaskStartedEventArgs(string message, string helpKeyword, string projectFile, string taskFile, string taskName) { }
    public TaskStartedEventArgs(string message, string helpKeyword, string projectFile, string taskFile, string taskName, System.DateTime eventTimestamp) { }
    public string ProjectFile { get { return default(string); } }
    public string TaskFile { get { return default(string); } }
    public string TaskName { get { return default(string); } }
  }
  public delegate void TaskStartedEventHandler(object sender, Microsoft.Build.Framework.TaskStartedEventArgs e);
}
namespace Microsoft.Build.Framework.XamlTypes {
  public sealed partial class Argument : System.ComponentModel.ISupportInitialize {
    public Argument() { }
    public bool IsRequired { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public string Property { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public string Separator { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public void BeginInit() { }
    public void EndInit() { }
  }
  [System.Windows.Markup.ContentPropertyAttribute("Arguments")]
  public abstract partial class BaseProperty : System.ComponentModel.ISupportInitialize {
    protected BaseProperty() { }
    public System.Collections.Generic.List<Microsoft.Build.Framework.XamlTypes.Argument> Arguments { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Collections.Generic.List<Microsoft.Build.Framework.XamlTypes.Argument>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public string Category { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public Microsoft.Build.Framework.XamlTypes.Rule ContainingRule { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(Microsoft.Build.Framework.XamlTypes.Rule); } }
    public Microsoft.Build.Framework.XamlTypes.DataSource DataSource { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(Microsoft.Build.Framework.XamlTypes.DataSource); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.LocalizableAttribute(true)]
    public string Default { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.LocalizableAttribute(true)]
    public string Description { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.LocalizableAttribute(true)]
    public string DisplayName { get { return default(string); } set { } }
    [System.ComponentModel.LocalizableAttribute(false)]
    public string F1Keyword { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public int HelpContext { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(int); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.LocalizableAttribute(false)]
    public string HelpFile { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.LocalizableAttribute(false)]
    public string HelpUrl { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public bool IncludeInCommandLine { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public bool IsRequired { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Collections.Generic.List<Microsoft.Build.Framework.XamlTypes.NameValuePair> Metadata { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Collections.Generic.List<Microsoft.Build.Framework.XamlTypes.NameValuePair>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public bool MultipleValuesAllowed { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public string Name { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public bool ReadOnly { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public string Separator { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public string Subcategory { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public string Switch { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public string SwitchPrefix { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Collections.Generic.List<Microsoft.Build.Framework.XamlTypes.ValueEditor> ValueEditors { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Collections.Generic.List<Microsoft.Build.Framework.XamlTypes.ValueEditor>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public bool Visible { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public virtual void BeginInit() { }
    public virtual void EndInit() { }
  }
  public sealed partial class BoolProperty : Microsoft.Build.Framework.XamlTypes.BaseProperty {
    public BoolProperty() { }
    public string ReverseSwitch { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
  }
  public sealed partial class Category : Microsoft.Build.Framework.XamlTypes.CategorySchema, System.ComponentModel.ISupportInitialize {
    public Category() { }
    [System.ComponentModel.LocalizableAttribute(true)]
    public string Description { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.LocalizableAttribute(true)]
    public string DisplayName { get { return default(string); } set { } }
    [System.ComponentModel.LocalizableAttribute(true)]
    public string HelpString { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public string Name { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public string Subtype { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public void BeginInit() { }
    public void EndInit() { }
  }
  public abstract partial class CategorySchema {
    protected CategorySchema() { }
  }
  [System.Windows.Markup.ContentPropertyAttribute("Metadata")]
  public sealed partial class ContentType : Microsoft.Build.Framework.XamlTypes.IProjectSchemaNode, System.ComponentModel.ISupportInitialize {
    public ContentType() { }
    public bool DefaultContentTypeForItemType { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.LocalizableAttribute(true)]
    public string DisplayName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ObsoleteAttribute("Unused.  Use ItemType property instead.", true)]
    public string ItemGroupName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public string ItemType { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Collections.Generic.List<Microsoft.Build.Framework.XamlTypes.NameValuePair> Metadata { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Collections.Generic.List<Microsoft.Build.Framework.XamlTypes.NameValuePair>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public string Name { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public void BeginInit() { }
    public void EndInit() { }
    public string GetMetadata(string metadataName) { return default(string); }
    [System.Runtime.CompilerServices.IteratorStateMachineAttribute(typeof(Microsoft.Build.Framework.XamlTypes.ContentType.<GetSchemaObjects>d__30))]
    public System.Collections.Generic.IEnumerable<System.Object> GetSchemaObjects(System.Type type) { return default(System.Collections.Generic.IEnumerable<System.Object>); }
    [System.Runtime.CompilerServices.IteratorStateMachineAttribute(typeof(Microsoft.Build.Framework.XamlTypes.ContentType.<GetSchemaObjectTypes>d__29))]
    public System.Collections.Generic.IEnumerable<System.Type> GetSchemaObjectTypes() { return default(System.Collections.Generic.IEnumerable<System.Type>); }
  }
  public sealed partial class DataSource : System.ComponentModel.ISupportInitialize {
    public DataSource() { }
    public bool HasConfigurationCondition { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public string ItemType { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public string Label { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public string MSBuildTarget { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public string PersistedName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public string Persistence { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public Microsoft.Build.Framework.XamlTypes.DefaultValueSourceLocation SourceOfDefaultValue { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(Microsoft.Build.Framework.XamlTypes.DefaultValueSourceLocation); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public string SourceType { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public void BeginInit() { }
    public void EndInit() { }
  }
  public enum DefaultValueSourceLocation {
    AfterContext = 1,
    BeforeContext = 0,
  }
  public sealed partial class DynamicEnumProperty : Microsoft.Build.Framework.XamlTypes.BaseProperty {
    public DynamicEnumProperty() { }
    public string EnumProvider { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Collections.Generic.List<Microsoft.Build.Framework.XamlTypes.NameValuePair> ProviderSettings { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Collections.Generic.List<Microsoft.Build.Framework.XamlTypes.NameValuePair>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
  }
  [System.Windows.Markup.ContentPropertyAttribute("AdmissibleValues")]
  public sealed partial class EnumProperty : Microsoft.Build.Framework.XamlTypes.BaseProperty {
    public EnumProperty() { }
    public System.Collections.Generic.List<Microsoft.Build.Framework.XamlTypes.EnumValue> AdmissibleValues { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Collections.Generic.List<Microsoft.Build.Framework.XamlTypes.EnumValue>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public override void EndInit() { }
  }
  [System.Windows.Markup.ContentPropertyAttribute("Arguments")]
  public sealed partial class EnumValue {
    public EnumValue() { }
    public System.Collections.Generic.List<Microsoft.Build.Framework.XamlTypes.Argument> Arguments { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Collections.Generic.List<Microsoft.Build.Framework.XamlTypes.Argument>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.LocalizableAttribute(true)]
    public string Description { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.LocalizableAttribute(true)]
    public string DisplayName { get { return default(string); } set { } }
    [System.ComponentModel.LocalizableAttribute(true)]
    public string HelpString { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public bool IsDefault { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Collections.Generic.List<Microsoft.Build.Framework.XamlTypes.NameValuePair> Metadata { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Collections.Generic.List<Microsoft.Build.Framework.XamlTypes.NameValuePair>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public string Name { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public string Switch { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public string SwitchPrefix { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
  }
  public sealed partial class FileExtension : Microsoft.Build.Framework.XamlTypes.IProjectSchemaNode {
    public FileExtension() { }
    public string ContentType { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public string Name { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Runtime.CompilerServices.IteratorStateMachineAttribute(typeof(Microsoft.Build.Framework.XamlTypes.FileExtension.<GetSchemaObjects>d__10))]
    public System.Collections.Generic.IEnumerable<System.Object> GetSchemaObjects(System.Type type) { return default(System.Collections.Generic.IEnumerable<System.Object>); }
    [System.Runtime.CompilerServices.IteratorStateMachineAttribute(typeof(Microsoft.Build.Framework.XamlTypes.FileExtension.<GetSchemaObjectTypes>d__9))]
    public System.Collections.Generic.IEnumerable<System.Type> GetSchemaObjectTypes() { return default(System.Collections.Generic.IEnumerable<System.Type>); }
  }
  public sealed partial class IntProperty : Microsoft.Build.Framework.XamlTypes.BaseProperty {
    public IntProperty() { }
    public System.Nullable<System.Int32> MaxValue { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Nullable<System.Int32>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Nullable<System.Int32> MinValue { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Nullable<System.Int32>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public override void EndInit() { }
  }
  public partial interface IProjectSchemaNode {
    System.Collections.Generic.IEnumerable<System.Object> GetSchemaObjects(System.Type type);
    System.Collections.Generic.IEnumerable<System.Type> GetSchemaObjectTypes();
  }
  public sealed partial class ItemType : Microsoft.Build.Framework.XamlTypes.IProjectSchemaNode, System.ComponentModel.ISupportInitialize {
    public ItemType() { }
    public string DefaultContentType { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.LocalizableAttribute(true)]
    public string DisplayName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public string Name { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public bool UpToDateCheckInput { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public void BeginInit() { }
    public void EndInit() { }
    [System.Runtime.CompilerServices.IteratorStateMachineAttribute(typeof(Microsoft.Build.Framework.XamlTypes.ItemType.<GetSchemaObjects>d__20))]
    public System.Collections.Generic.IEnumerable<System.Object> GetSchemaObjects(System.Type type) { return default(System.Collections.Generic.IEnumerable<System.Object>); }
    [System.Runtime.CompilerServices.IteratorStateMachineAttribute(typeof(Microsoft.Build.Framework.XamlTypes.ItemType.<GetSchemaObjectTypes>d__19))]
    public System.Collections.Generic.IEnumerable<System.Type> GetSchemaObjectTypes() { return default(System.Collections.Generic.IEnumerable<System.Type>); }
  }
  public partial class NameValuePair {
    public NameValuePair() { }
    public string Name { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.LocalizableAttribute(true)]
    public string Value { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
  }
  [System.Windows.Markup.ContentPropertyAttribute("Nodes")]
  public sealed partial class ProjectSchemaDefinitions : Microsoft.Build.Framework.XamlTypes.IProjectSchemaNode {
    public ProjectSchemaDefinitions() { }
    public System.Collections.Generic.List<Microsoft.Build.Framework.XamlTypes.IProjectSchemaNode> Nodes { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Collections.Generic.List<Microsoft.Build.Framework.XamlTypes.IProjectSchemaNode>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Runtime.CompilerServices.IteratorStateMachineAttribute(typeof(Microsoft.Build.Framework.XamlTypes.ProjectSchemaDefinitions.<GetSchemaObjects>d__6))]
    public System.Collections.Generic.IEnumerable<System.Object> GetSchemaObjects(System.Type type) { return default(System.Collections.Generic.IEnumerable<System.Object>); }
    public System.Collections.Generic.IEnumerable<System.Type> GetSchemaObjectTypes() { return default(System.Collections.Generic.IEnumerable<System.Type>); }
  }
  [System.Diagnostics.DebuggerDisplayAttribute("Rule: {Name}")]
  [System.Windows.Markup.ContentPropertyAttribute("Properties")]
  public sealed partial class Rule : Microsoft.Build.Framework.XamlTypes.RuleSchema, Microsoft.Build.Framework.XamlTypes.IProjectSchemaNode, System.ComponentModel.ISupportInitialize {
    public Rule() { }
    public string AdditionalInputs { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Collections.Generic.List<Microsoft.Build.Framework.XamlTypes.Category> Categories { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Collections.Generic.List<Microsoft.Build.Framework.XamlTypes.Category>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public string CommandLine { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public Microsoft.Build.Framework.XamlTypes.DataSource DataSource { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(Microsoft.Build.Framework.XamlTypes.DataSource); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.LocalizableAttribute(true)]
    public string Description { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.LocalizableAttribute(true)]
    public string DisplayName { get { return default(string); } set { } }
    public System.Collections.Generic.List<Microsoft.Build.Framework.XamlTypes.Category> EvaluatedCategories { get { return default(System.Collections.Generic.List<Microsoft.Build.Framework.XamlTypes.Category>); } }
    public string ExecutionDescription { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public string FileExtension { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.LocalizableAttribute(true)]
    public string HelpString { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Collections.Generic.Dictionary<System.String, System.Object> Metadata { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Collections.Generic.Dictionary<System.String, System.Object>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public string Name { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public int Order { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(int); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public string Outputs { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public Microsoft.Build.Framework.XamlTypes.RuleOverrideMode OverrideMode { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(Microsoft.Build.Framework.XamlTypes.RuleOverrideMode); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public string PageTemplate { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Collections.Generic.List<Microsoft.Build.Framework.XamlTypes.BaseProperty> Properties { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Collections.Generic.List<Microsoft.Build.Framework.XamlTypes.BaseProperty>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public bool PropertyPagesHidden { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public string Separator { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public bool ShowOnlyRuleProperties { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public bool SupportsFileBatching { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public string SwitchPrefix { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public string ToolName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public void BeginInit() { }
    public void EndInit() { }
    public System.Collections.Specialized.OrderedDictionary GetPropertiesByCategory() { return default(System.Collections.Specialized.OrderedDictionary); }
    public System.Collections.Generic.IList<Microsoft.Build.Framework.XamlTypes.BaseProperty> GetPropertiesInCategory(string categoryName) { return default(System.Collections.Generic.IList<Microsoft.Build.Framework.XamlTypes.BaseProperty>); }
    public Microsoft.Build.Framework.XamlTypes.BaseProperty GetProperty(string propertyName) { return default(Microsoft.Build.Framework.XamlTypes.BaseProperty); }
    [System.Runtime.CompilerServices.IteratorStateMachineAttribute(typeof(Microsoft.Build.Framework.XamlTypes.Rule.<GetSchemaObjects>d__101))]
    public System.Collections.Generic.IEnumerable<System.Object> GetSchemaObjects(System.Type type) { return default(System.Collections.Generic.IEnumerable<System.Object>); }
    [System.Runtime.CompilerServices.IteratorStateMachineAttribute(typeof(Microsoft.Build.Framework.XamlTypes.Rule.<GetSchemaObjectTypes>d__100))]
    public System.Collections.Generic.IEnumerable<System.Type> GetSchemaObjectTypes() { return default(System.Collections.Generic.IEnumerable<System.Type>); }
  }
  [System.Windows.Markup.ContentPropertyAttribute("Rules")]
  public sealed partial class RuleBag : Microsoft.Build.Framework.XamlTypes.IProjectSchemaNode, System.ComponentModel.ISupportInitialize {
    public RuleBag() { }
    public System.Collections.Generic.List<Microsoft.Build.Framework.XamlTypes.Rule> Rules { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Collections.Generic.List<Microsoft.Build.Framework.XamlTypes.Rule>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public void BeginInit() { }
    public void EndInit() { }
    [System.Runtime.CompilerServices.IteratorStateMachineAttribute(typeof(Microsoft.Build.Framework.XamlTypes.RuleBag.<GetSchemaObjects>d__8))]
    public System.Collections.Generic.IEnumerable<System.Object> GetSchemaObjects(System.Type type) { return default(System.Collections.Generic.IEnumerable<System.Object>); }
    [System.Runtime.CompilerServices.IteratorStateMachineAttribute(typeof(Microsoft.Build.Framework.XamlTypes.RuleBag.<GetSchemaObjectTypes>d__7))]
    public System.Collections.Generic.IEnumerable<System.Type> GetSchemaObjectTypes() { return default(System.Collections.Generic.IEnumerable<System.Type>); }
  }
  public enum RuleOverrideMode {
    Extend = 1,
    Replace = 0,
  }
  public abstract partial class RuleSchema {
    protected RuleSchema() { }
  }
  public sealed partial class StringListProperty : Microsoft.Build.Framework.XamlTypes.BaseProperty {
    public StringListProperty() { }
    public string CommandLineValueSeparator { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public string RendererValueSeparator { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public string Subtype { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
  }
  public sealed partial class StringProperty : Microsoft.Build.Framework.XamlTypes.BaseProperty {
    public StringProperty() { }
    public string Subtype { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
  }
  [System.Windows.Markup.ContentPropertyAttribute("Metadata")]
  public sealed partial class ValueEditor : System.ComponentModel.ISupportInitialize {
    public ValueEditor() { }
    [System.ComponentModel.LocalizableAttribute(true)]
    public string DisplayName { get { return default(string); } set { } }
    public string EditorType { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Collections.Generic.List<Microsoft.Build.Framework.XamlTypes.NameValuePair> Metadata { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Collections.Generic.List<Microsoft.Build.Framework.XamlTypes.NameValuePair>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public void BeginInit() { }
    public void EndInit() { }
  }
}
