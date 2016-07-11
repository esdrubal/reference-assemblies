Unable to resolve assembly 'Assembly(Name=mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089)' referenced by 'Assembly(Name=Microsoft.Build.Framework, Version=3.5.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a)'.
namespace Microsoft.Build.Framework {
  public delegate void AnyEventHandler(object sender, Microsoft.Build.Framework.BuildEventArgs e);
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct BuildEngineResult {
    public BuildEngineResult(bool result, System.Collections.Generic.List<System.Collections.Generic.IDictionary<System.String, Microsoft.Build.Framework.ITaskItem[]>> targetOutputsPerProject) { throw new System.NotImplementedException(); }
    public bool Result { get { return default(bool); } }
    public System.Collections.Generic.IList<System.Collections.Generic.IDictionary<System.String, Microsoft.Build.Framework.ITaskItem[]>> TargetOutputsPerProject { get { return default(System.Collections.Generic.IList<System.Collections.Generic.IDictionary<System.String, Microsoft.Build.Framework.ITaskItem[]>>); } }
  }
  public partial class BuildErrorEventArgs : Microsoft.Build.Framework.BuildEventArgs {
    protected BuildErrorEventArgs() { }
    public BuildErrorEventArgs(string subcategory, string code, string file, int lineNumber, int columnNumber, int endLineNumber, int endColumnNumber, string message, string helpKeyword, string senderName) { }
    public string Code { get { return default(string); } }
    public int ColumnNumber { get { return default(int); } }
    public int EndColumnNumber { get { return default(int); } }
    public int EndLineNumber { get { return default(int); } }
    public string File { get { return default(string); } }
    public int LineNumber { get { return default(int); } }
    public string Subcategory { get { return default(string); } }
  }
  public delegate void BuildErrorEventHandler(object sender, Microsoft.Build.Framework.BuildErrorEventArgs e);
  public abstract partial class BuildEventArgs : System.EventArgs {
    protected BuildEventArgs() { }
    protected BuildEventArgs(string message, string helpKeyword, string senderName) { }
    public Microsoft.Build.Framework.BuildEventContext BuildEventContext { get { return default(Microsoft.Build.Framework.BuildEventContext); } set { } }
    public string HelpKeyword { get { return default(string); } }
    public string Message { get { return default(string); } }
    public string SenderName { get { return default(string); } }
    public int ThreadId { get { return default(int); } }
    public System.DateTime Timestamp { get { return default(System.DateTime); } }
  }
  public partial class BuildEventContext {
    public static Microsoft.Build.Framework.BuildEventContext Invalid;
    public const int InvalidNodeId = -2;
    public const int InvalidProjectContextId = -2;
    public const int InvalidProjectInstanceId = -1;
    public const int InvalidSubmissionId = -1;
    public const int InvalidTargetId = -1;
    public const int InvalidTaskId = -1;
    public BuildEventContext(int nodeId, int targetId, int projectContextId, int taskId) { }
    public BuildEventContext(int nodeId, int projectInstanceId, int projectContextId, int targetId, int taskId) { }
    public BuildEventContext(int submissionId, int nodeId, int projectInstanceId, int projectContextId, int targetId, int taskId) { }
    public int NodeId { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(int); } }
    public int ProjectContextId { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(int); } }
    public int ProjectInstanceId { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(int); } }
    public int SubmissionId { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(int); } }
    public int TargetId { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(int); } }
    public int TaskId { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(int); } }
    public override bool Equals(object obj) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public static bool operator ==(Microsoft.Build.Framework.BuildEventContext left, Microsoft.Build.Framework.BuildEventContext right) { return default(bool); }
    public static bool operator !=(Microsoft.Build.Framework.BuildEventContext left, Microsoft.Build.Framework.BuildEventContext right) { return default(bool); }
  }
  public partial class BuildFinishedEventArgs : Microsoft.Build.Framework.BuildStatusEventArgs {
    protected BuildFinishedEventArgs() { }
    public BuildFinishedEventArgs(string message, string helpKeyword, bool succeeded) { }
    public bool Succeeded { get { return default(bool); } }
  }
  public delegate void BuildFinishedEventHandler(object sender, Microsoft.Build.Framework.BuildFinishedEventArgs e);
  public partial class BuildMessageEventArgs : Microsoft.Build.Framework.BuildEventArgs {
    protected BuildMessageEventArgs() { }
    public BuildMessageEventArgs(string message, string helpKeyword, string senderName, Microsoft.Build.Framework.MessageImportance importance) { }
    public Microsoft.Build.Framework.MessageImportance Importance { get { return default(Microsoft.Build.Framework.MessageImportance); } }
  }
  public delegate void BuildMessageEventHandler(object sender, Microsoft.Build.Framework.BuildMessageEventArgs e);
  public partial class BuildStartedEventArgs : Microsoft.Build.Framework.BuildStatusEventArgs {
    protected BuildStartedEventArgs() { }
    public BuildStartedEventArgs(string message, string helpKeyword) { }
  }
  public delegate void BuildStartedEventHandler(object sender, Microsoft.Build.Framework.BuildStartedEventArgs e);
  public abstract partial class BuildStatusEventArgs : Microsoft.Build.Framework.BuildEventArgs {
    protected BuildStatusEventArgs() { }
    protected BuildStatusEventArgs(string message, string helpKeyword, string senderName) { }
  }
  public delegate void BuildStatusEventHandler(object sender, Microsoft.Build.Framework.BuildStatusEventArgs e);
  public partial class BuildWarningEventArgs : Microsoft.Build.Framework.BuildEventArgs {
    protected BuildWarningEventArgs() { }
    public BuildWarningEventArgs(string subcategory, string code, string file, int lineNumber, int columnNumber, int endLineNumber, int endColumnNumber, string message, string helpKeyword, string senderName) { }
    public string Code { get { return default(string); } }
    public int ColumnNumber { get { return default(int); } }
    public int EndColumnNumber { get { return default(int); } }
    public int EndLineNumber { get { return default(int); } }
    public string File { get { return default(string); } }
    public int LineNumber { get { return default(int); } }
    public string Subcategory { get { return default(string); } }
  }
  public delegate void BuildWarningEventHandler(object sender, Microsoft.Build.Framework.BuildWarningEventArgs e);
  public abstract partial class CustomBuildEventArgs : Microsoft.Build.Framework.BuildEventArgs {
    protected CustomBuildEventArgs() { }
    protected CustomBuildEventArgs(string message, string helpKeyword, string senderName) { }
  }
  public delegate void CustomBuildEventHandler(object sender, Microsoft.Build.Framework.CustomBuildEventArgs e);
  public partial class ExternalProjectFinishedEventArgs : Microsoft.Build.Framework.CustomBuildEventArgs {
    protected ExternalProjectFinishedEventArgs() { }
    public ExternalProjectFinishedEventArgs(string message, string helpKeyword, string senderName, string projectFile, bool succeeded) { }
    public string ProjectFile { get { return default(string); } }
    public bool Succeeded { get { return default(bool); } }
  }
  public partial class ExternalProjectStartedEventArgs : Microsoft.Build.Framework.CustomBuildEventArgs {
    protected ExternalProjectStartedEventArgs() { }
    public ExternalProjectStartedEventArgs(string message, string helpKeyword, string senderName, string projectFile, string targetNames) { }
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
  [System.MonoTODOAttribute]
  public partial interface IBuildEngine3 : Microsoft.Build.Framework.IBuildEngine, Microsoft.Build.Framework.IBuildEngine2 {
    Microsoft.Build.Framework.BuildEngineResult BuildProjectFilesInParallel(System.String[] projectFileNames, System.String[] targetNames, System.Collections.IDictionary[] globalProperties, System.Collections.Generic.IList<System.String>[] removeGlobalProperties, System.String[] toolsVersion, bool returnTargetOutputs);
    void Reacquire();
    void Yield();
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
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public partial interface ILogger {
    string Parameters { get; set; }
    Microsoft.Build.Framework.LoggerVerbosity Verbosity { get; set; }
    void Initialize(Microsoft.Build.Framework.IEventSource eventSource);
    void Shutdown();
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
  [System.Runtime.InteropServices.InterfaceTypeAttribute(1)]
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
  [System.AttributeUsageAttribute(4, AllowMultiple=false, Inherited=true)]
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
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, SerializationFormatter=true)]
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
  [System.AttributeUsageAttribute(128, AllowMultiple=false, Inherited=false)]
  public sealed partial class OutputAttribute : System.Attribute {
    public OutputAttribute() { }
  }
  public partial class ProjectFinishedEventArgs : Microsoft.Build.Framework.BuildStatusEventArgs {
    protected ProjectFinishedEventArgs() { }
    public ProjectFinishedEventArgs(string message, string helpKeyword, string projectFile, bool succeeded) { }
    public string ProjectFile { get { return default(string); } }
    public bool Succeeded { get { return default(bool); } }
  }
  public delegate void ProjectFinishedEventHandler(object sender, Microsoft.Build.Framework.ProjectFinishedEventArgs e);
  public partial class ProjectStartedEventArgs : Microsoft.Build.Framework.BuildStatusEventArgs {
    protected ProjectStartedEventArgs() { }
    public ProjectStartedEventArgs(string message, string helpKeyword, string projectFile, string targetNames, System.Collections.IEnumerable properties, System.Collections.IEnumerable items) { }
    public System.Collections.IEnumerable Items { get { return default(System.Collections.IEnumerable); } }
    public string ProjectFile { get { return default(string); } }
    public System.Collections.IEnumerable Properties { get { return default(System.Collections.IEnumerable); } }
    public string TargetNames { get { return default(string); } }
  }
  public delegate void ProjectStartedEventHandler(object sender, Microsoft.Build.Framework.ProjectStartedEventArgs e);
  [System.AttributeUsageAttribute(128, AllowMultiple=false, Inherited=false)]
  public sealed partial class RequiredAttribute : System.Attribute {
    public RequiredAttribute() { }
  }
  public partial class TargetFinishedEventArgs : Microsoft.Build.Framework.BuildStatusEventArgs {
    protected TargetFinishedEventArgs() { }
    public TargetFinishedEventArgs(string message, string helpKeyword, string targetName, string projectFile, string targetFile, bool succeeded) { }
    public string ProjectFile { get { return default(string); } }
    public bool Succeeded { get { return default(bool); } }
    public string TargetFile { get { return default(string); } }
    public string TargetName { get { return default(string); } }
  }
  public delegate void TargetFinishedEventHandler(object sender, Microsoft.Build.Framework.TargetFinishedEventArgs e);
  public partial class TargetStartedEventArgs : Microsoft.Build.Framework.BuildStatusEventArgs {
    protected TargetStartedEventArgs() { }
    public TargetStartedEventArgs(string message, string helpKeyword, string targetName, string projectFile, string targetFile) { }
    public string ProjectFile { get { return default(string); } }
    public string TargetFile { get { return default(string); } }
    public string TargetName { get { return default(string); } }
  }
  public delegate void TargetStartedEventHandler(object sender, Microsoft.Build.Framework.TargetStartedEventArgs e);
  public partial class TaskCommandLineEventArgs : Microsoft.Build.Framework.BuildMessageEventArgs {
    protected TaskCommandLineEventArgs() { }
    public TaskCommandLineEventArgs(string commandLine, string taskName, Microsoft.Build.Framework.MessageImportance importance) { }
    public string CommandLine { get { return default(string); } }
    public string TaskName { get { return default(string); } }
  }
  public partial class TaskFinishedEventArgs : Microsoft.Build.Framework.BuildStatusEventArgs {
    protected TaskFinishedEventArgs() { }
    public TaskFinishedEventArgs(string message, string helpKeyword, string projectFile, string taskFile, string taskName, bool succeeded) { }
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
    public string ProjectFile { get { return default(string); } }
    public string TaskFile { get { return default(string); } }
    public string TaskName { get { return default(string); } }
  }
  public delegate void TaskStartedEventHandler(object sender, Microsoft.Build.Framework.TaskStartedEventArgs e);
}
