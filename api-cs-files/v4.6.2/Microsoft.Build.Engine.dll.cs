namespace Microsoft.Build.BuildEngine {
  [System.Diagnostics.DebuggerDisplayAttribute("BuildItem (Name = { Name }, Include = { Include }, FinalItemSpec = { FinalItemSpec }, Condition = { Condition } )")]
  public partial class BuildItem {
    public BuildItem(string itemName, Microsoft.Build.Framework.ITaskItem taskItem) { }
    public BuildItem(string itemName, string itemInclude) { }
    public string Condition { get { return default(string); } set { } }
    public int CustomMetadataCount { get { return default(int); } }
    public System.Collections.ICollection CustomMetadataNames { get { return default(System.Collections.ICollection); } }
    public string Exclude { get { return default(string); } set { } }
    public string FinalItemSpec { get { return default(string); } }
    public string Include { get { return default(string); } set { } }
    public bool IsImported { get { return default(bool); } }
    public int MetadataCount { get { return default(int); } }
    public System.Collections.ICollection MetadataNames { get { return default(System.Collections.ICollection); } }
    public string Name { get { return default(string); } set { } }
    public Microsoft.Build.BuildEngine.BuildItem Clone() { return default(Microsoft.Build.BuildEngine.BuildItem); }
    public void CopyCustomMetadataTo(Microsoft.Build.BuildEngine.BuildItem destinationItem) { }
    public string GetEvaluatedMetadata(string metadataName) { return default(string); }
    public string GetMetadata(string metadataName) { return default(string); }
    public bool HasMetadata(string metadataName) { return default(bool); }
    public void RemoveMetadata(string metadataName) { }
    public void SetMetadata(string metadataName, string metadataValue) { }
    public void SetMetadata(string metadataName, string metadataValue, bool treatMetadataValueAsLiteral) { }
  }
  [System.Diagnostics.DebuggerDisplayAttribute("BuildItemGroup (Count = { Count }, Condition = { Condition })")]
  public partial class BuildItemGroup : System.Collections.IEnumerable {
    public BuildItemGroup() { }
    public string Condition { get { return default(string); } set { } }
    public int Count { get { return default(int); } }
    public bool IsImported { get { return default(bool); } }
    public Microsoft.Build.BuildEngine.BuildItem this[int index] { get { return default(Microsoft.Build.BuildEngine.BuildItem); } }
    public Microsoft.Build.BuildEngine.BuildItem AddNewItem(string itemName, string itemInclude) { return default(Microsoft.Build.BuildEngine.BuildItem); }
    public Microsoft.Build.BuildEngine.BuildItem AddNewItem(string itemName, string itemInclude, bool treatItemIncludeAsLiteral) { return default(Microsoft.Build.BuildEngine.BuildItem); }
    public void Clear() { }
    public Microsoft.Build.BuildEngine.BuildItemGroup Clone(bool deepClone) { return default(Microsoft.Build.BuildEngine.BuildItemGroup); }
    public System.Collections.IEnumerator GetEnumerator() { return default(System.Collections.IEnumerator); }
    public void RemoveItem(Microsoft.Build.BuildEngine.BuildItem itemToRemove) { }
    public void RemoveItemAt(int index) { }
    public Microsoft.Build.BuildEngine.BuildItem[] ToArray() { return default(Microsoft.Build.BuildEngine.BuildItem[]); }
  }
  public partial class BuildItemGroupCollection : System.Collections.ICollection, System.Collections.IEnumerable {
    internal BuildItemGroupCollection() { }
    public int Count { get { return default(int); } }
    public bool IsSynchronized { get { return default(bool); } }
    public object SyncRoot { get { return default(object); } }
    public void CopyTo(System.Array array, int index) { }
    public System.Collections.IEnumerator GetEnumerator() { return default(System.Collections.IEnumerator); }
  }
  [System.Diagnostics.DebuggerDisplayAttribute("BuildProperty (Name = { Name }, Value = { Value }, FinalValue = { FinalValue }, Condition = { Condition })")]
  public partial class BuildProperty {
    public BuildProperty(string propertyName, string propertyValue) { }
    public string Condition { get { return default(string); } set { } }
    public string FinalValue { get { return default(string); } }
    public bool IsImported { get { return default(bool); } }
    public string Name { get { return default(string); } }
    public string Value { get { return default(string); } set { } }
    public Microsoft.Build.BuildEngine.BuildProperty Clone(bool deepClone) { return default(Microsoft.Build.BuildEngine.BuildProperty); }
    public static explicit operator string (Microsoft.Build.BuildEngine.BuildProperty propertyToCast) { return default(string); }
    public override string ToString() { return default(string); }
  }
  [System.Diagnostics.DebuggerDisplayAttribute("BuildPropertyGroup (Count = { Count }, Condition = { Condition })")]
  public partial class BuildPropertyGroup : System.Collections.IEnumerable {
    public BuildPropertyGroup() { }
    public BuildPropertyGroup(Microsoft.Build.BuildEngine.Project parentProject) { }
    public string Condition { get { return default(string); } set { } }
    public int Count { get { return default(int); } }
    public bool IsImported { get { return default(bool); } }
    public Microsoft.Build.BuildEngine.BuildProperty this[string propertyName] { get { return default(Microsoft.Build.BuildEngine.BuildProperty); } set { } }
    public Microsoft.Build.BuildEngine.BuildProperty AddNewProperty(string propertyName, string propertyValue) { return default(Microsoft.Build.BuildEngine.BuildProperty); }
    public Microsoft.Build.BuildEngine.BuildProperty AddNewProperty(string propertyName, string propertyValue, bool treatPropertyValueAsLiteral) { return default(Microsoft.Build.BuildEngine.BuildProperty); }
    public void Clear() { }
    public Microsoft.Build.BuildEngine.BuildPropertyGroup Clone(bool deepClone) { return default(Microsoft.Build.BuildEngine.BuildPropertyGroup); }
    public System.Collections.IEnumerator GetEnumerator() { return default(System.Collections.IEnumerator); }
    public void RemoveProperty(Microsoft.Build.BuildEngine.BuildProperty property) { }
    public void RemoveProperty(string propertyName) { }
    public void SetImportedPropertyGroupCondition(string condition) { }
    public void SetProperty(string propertyName, string propertyValue) { }
    public void SetProperty(string propertyName, string propertyValue, bool treatPropertyValueAsLiteral) { }
  }
  public partial class BuildPropertyGroupCollection : System.Collections.ICollection, System.Collections.IEnumerable {
    internal BuildPropertyGroupCollection() { }
    public int Count { get { return default(int); } }
    public bool IsSynchronized { get { return default(bool); } }
    public object SyncRoot { get { return default(object); } }
    public void CopyTo(System.Array array, int index) { }
    public System.Collections.IEnumerator GetEnumerator() { return default(System.Collections.IEnumerator); }
  }
  [System.FlagsAttribute]
  public enum BuildSettings {
    DoNotResetPreviouslyBuiltTargets = 1,
    None = 0,
  }
  public partial class BuildTask {
    internal BuildTask() { }
    public string Condition { get { return default(string); } set { } }
    public bool ContinueOnError { get { return default(bool); } set { } }
    public Microsoft.Build.Framework.ITaskHost HostObject { get { return default(Microsoft.Build.Framework.ITaskHost); } set { } }
    public string Name { get { return default(string); } }
    public System.Type Type { get { return default(System.Type); } }
    public void AddOutputItem(string taskParameter, string itemName) { }
    public void AddOutputProperty(string taskParameter, string propertyName) { }
    public bool Execute() { return default(bool); }
    public System.String[] GetParameterNames() { return default(System.String[]); }
    public string GetParameterValue(string attributeName) { return default(string); }
    public void SetParameterValue(string parameterName, string parameterValue) { }
    public void SetParameterValue(string parameterName, string parameterValue, bool treatParameterValueAsLiteral) { }
  }
  public delegate void ColorResetter();
  public delegate void ColorSetter(System.ConsoleColor color);
  public partial class ConfigurableForwardingLogger : Microsoft.Build.Framework.IForwardingLogger, Microsoft.Build.Framework.ILogger, Microsoft.Build.Framework.INodeLogger {
    public ConfigurableForwardingLogger() { }
    public Microsoft.Build.Framework.IEventRedirector BuildEventRedirector { get { return default(Microsoft.Build.Framework.IEventRedirector); } set { } }
    public int NodeId { get { return default(int); } set { } }
    public string Parameters { get { return default(string); } set { } }
    public Microsoft.Build.Framework.LoggerVerbosity Verbosity { get { return default(Microsoft.Build.Framework.LoggerVerbosity); } set { } }
    protected virtual void ForwardToCentralLogger(Microsoft.Build.Framework.BuildEventArgs e) { }
    public virtual void Initialize(Microsoft.Build.Framework.IEventSource eventSource) { }
    public void Initialize(Microsoft.Build.Framework.IEventSource eventSource, int nodeCount) { }
    public virtual void Shutdown() { }
  }
  public partial class ConsoleLogger : Microsoft.Build.Framework.ILogger, Microsoft.Build.Framework.INodeLogger {
    public ConsoleLogger() { }
    public ConsoleLogger(Microsoft.Build.Framework.LoggerVerbosity verbosity) { }
    public ConsoleLogger(Microsoft.Build.Framework.LoggerVerbosity verbosity, Microsoft.Build.BuildEngine.WriteHandler write, Microsoft.Build.BuildEngine.ColorSetter colorSet, Microsoft.Build.BuildEngine.ColorResetter colorReset) { }
    public string Parameters { get { return default(string); } set { } }
    public bool ShowSummary { get { return default(bool); } set { } }
    public bool SkipProjectStartedText { get { return default(bool); } set { } }
    public Microsoft.Build.Framework.LoggerVerbosity Verbosity { get { return default(Microsoft.Build.Framework.LoggerVerbosity); } set { } }
    protected Microsoft.Build.BuildEngine.WriteHandler WriteHandler { get { return default(Microsoft.Build.BuildEngine.WriteHandler); } set { } }
    public void ApplyParameter(string parameterName, string parameterValue) { }
    public void BuildFinishedHandler(object sender, Microsoft.Build.Framework.BuildFinishedEventArgs e) { }
    public void BuildStartedHandler(object sender, Microsoft.Build.Framework.BuildStartedEventArgs e) { }
    public void CustomEventHandler(object sender, Microsoft.Build.Framework.CustomBuildEventArgs e) { }
    public void ErrorHandler(object sender, Microsoft.Build.Framework.BuildErrorEventArgs e) { }
    public virtual void Initialize(Microsoft.Build.Framework.IEventSource eventSource) { }
    public virtual void Initialize(Microsoft.Build.Framework.IEventSource eventSource, int nodeCount) { }
    public void MessageHandler(object sender, Microsoft.Build.Framework.BuildMessageEventArgs e) { }
    public void ProjectFinishedHandler(object sender, Microsoft.Build.Framework.ProjectFinishedEventArgs e) { }
    public void ProjectStartedHandler(object sender, Microsoft.Build.Framework.ProjectStartedEventArgs e) { }
    public virtual void Shutdown() { }
    public void TargetFinishedHandler(object sender, Microsoft.Build.Framework.TargetFinishedEventArgs e) { }
    public void TargetStartedHandler(object sender, Microsoft.Build.Framework.TargetStartedEventArgs e) { }
    public void TaskFinishedHandler(object sender, Microsoft.Build.Framework.TaskFinishedEventArgs e) { }
    public void TaskStartedHandler(object sender, Microsoft.Build.Framework.TaskStartedEventArgs e) { }
    public void WarningHandler(object sender, Microsoft.Build.Framework.BuildWarningEventArgs e) { }
  }
  public partial class DistributedFileLogger : Microsoft.Build.Framework.IForwardingLogger, Microsoft.Build.Framework.ILogger, Microsoft.Build.Framework.INodeLogger {
    public DistributedFileLogger() { }
    public Microsoft.Build.Framework.IEventRedirector BuildEventRedirector { get { return default(Microsoft.Build.Framework.IEventRedirector); } set { } }
    public int NodeId { get { return default(int); } set { } }
    public string Parameters { get { return default(string); } set { } }
    public Microsoft.Build.Framework.LoggerVerbosity Verbosity { get { return default(Microsoft.Build.Framework.LoggerVerbosity); } set { } }
    public void Initialize(Microsoft.Build.Framework.IEventSource eventSource) { }
    public void Initialize(Microsoft.Build.Framework.IEventSource eventSource, int nodeCount) { }
    public void Shutdown() { }
  }
  [System.ObsoleteAttribute("This class has been deprecated. Please use Microsoft.Build.Evaluation.ProjectCollection from the Microsoft.Build assembly instead.")]
  public partial class Engine {
    public Engine() { }
    public Engine(Microsoft.Build.BuildEngine.BuildPropertyGroup globalProperties) { }
    public Engine(Microsoft.Build.BuildEngine.BuildPropertyGroup globalProperties, Microsoft.Build.BuildEngine.ToolsetDefinitionLocations locations) { }
    public Engine(Microsoft.Build.BuildEngine.BuildPropertyGroup globalProperties, Microsoft.Build.BuildEngine.ToolsetDefinitionLocations locations, int numberOfCpus, string localNodeProviderParameters) { }
    public Engine(Microsoft.Build.BuildEngine.ToolsetDefinitionLocations locations) { }
    [System.ObsoleteAttribute("If you were simply passing in the .NET Framework location as the BinPath, just change to the parameterless Engine() constructor. Otherwise, you can define custom toolsets in the registry or config file, or by adding elements to the Engine's ToolsetCollection. Then use either the Engine() or Engine(ToolsetLocations) constructor instead.")]
    public Engine(string binPath) { }
    [System.ObsoleteAttribute("Avoid setting BinPath. If you were simply passing in the .NET Framework location as the BinPath, no other action is necessary. Otherwise, define Toolsets instead in the registry or config file, or by adding elements to the Engine's ToolsetCollection, in order to use a custom BinPath.")]
    public string BinPath { get { return default(string); } set { } }
    public bool BuildEnabled { get { return default(bool); } set { } }
    public string DefaultToolsVersion { get { return default(string); } set { } }
    public static Microsoft.Build.BuildEngine.Engine GlobalEngine { get { return default(Microsoft.Build.BuildEngine.Engine); } }
    public Microsoft.Build.BuildEngine.BuildPropertyGroup GlobalProperties { get { return default(Microsoft.Build.BuildEngine.BuildPropertyGroup); } set { } }
    public bool IsBuilding { get { return default(bool); } }
    public bool OnlyLogCriticalEvents { get { return default(bool); } set { } }
    public Microsoft.Build.BuildEngine.ToolsetCollection Toolsets { get { return default(Microsoft.Build.BuildEngine.ToolsetCollection); } }
    public static System.Version Version { get { return default(System.Version); } }
    public bool BuildProject(Microsoft.Build.BuildEngine.Project project) { return default(bool); }
    public bool BuildProject(Microsoft.Build.BuildEngine.Project project, string targetName) { return default(bool); }
    public bool BuildProject(Microsoft.Build.BuildEngine.Project project, System.String[] targetNames) { return default(bool); }
    public bool BuildProject(Microsoft.Build.BuildEngine.Project project, System.String[] targetNames, System.Collections.IDictionary targetOutputs) { return default(bool); }
    public bool BuildProject(Microsoft.Build.BuildEngine.Project project, System.String[] targetNames, System.Collections.IDictionary targetOutputs, Microsoft.Build.BuildEngine.BuildSettings buildFlags) { return default(bool); }
    public bool BuildProjectFile(string projectFile) { return default(bool); }
    public bool BuildProjectFile(string projectFile, string targetName) { return default(bool); }
    public bool BuildProjectFile(string projectFile, System.String[] targetNames) { return default(bool); }
    public bool BuildProjectFile(string projectFile, System.String[] targetNames, Microsoft.Build.BuildEngine.BuildPropertyGroup globalProperties) { return default(bool); }
    public bool BuildProjectFile(string projectFile, System.String[] targetNames, Microsoft.Build.BuildEngine.BuildPropertyGroup globalProperties, System.Collections.IDictionary targetOutputs) { return default(bool); }
    public bool BuildProjectFile(string projectFile, System.String[] targetNames, Microsoft.Build.BuildEngine.BuildPropertyGroup globalProperties, System.Collections.IDictionary targetOutputs, Microsoft.Build.BuildEngine.BuildSettings buildFlags) { return default(bool); }
    public bool BuildProjectFile(string projectFile, System.String[] targetNames, Microsoft.Build.BuildEngine.BuildPropertyGroup globalProperties, System.Collections.IDictionary targetOutputs, Microsoft.Build.BuildEngine.BuildSettings buildFlags, string toolsVersion) { return default(bool); }
    public bool BuildProjectFiles(System.String[] projectFiles, System.String[][] targetNamesPerProject, Microsoft.Build.BuildEngine.BuildPropertyGroup[] globalPropertiesPerProject, System.Collections.IDictionary[] targetOutputsPerProject, Microsoft.Build.BuildEngine.BuildSettings buildFlags, System.String[] toolsVersions) { return default(bool); }
    public Microsoft.Build.BuildEngine.Project CreateNewProject() { return default(Microsoft.Build.BuildEngine.Project); }
    public Microsoft.Build.BuildEngine.Project GetLoadedProject(string projectFullFileName) { return default(Microsoft.Build.BuildEngine.Project); }
    public void RegisterDistributedLogger(Microsoft.Build.Framework.ILogger centralLogger, Microsoft.Build.BuildEngine.LoggerDescription forwardingLogger) { }
    public void RegisterLogger(Microsoft.Build.Framework.ILogger logger) { }
    public void Shutdown() { }
    public void UnloadAllProjects() { }
    public void UnloadProject(Microsoft.Build.BuildEngine.Project project) { }
    public void UnregisterAllLoggers() { }
  }
  public partial class FileLogger : Microsoft.Build.BuildEngine.ConsoleLogger {
    public FileLogger() { }
    public override void Initialize(Microsoft.Build.Framework.IEventSource eventSource) { }
    public override void Initialize(Microsoft.Build.Framework.IEventSource eventSource, int nodeCount) { }
    public override void Shutdown() { }
  }
  public partial class Import {
    internal Import() { }
    public string Condition { get { return default(string); } set { } }
    public string EvaluatedProjectPath { get { return default(string); } }
    public bool IsImported { get { return default(bool); } }
    public string ProjectPath { get { return default(string); } set { } }
  }
  public partial class ImportCollection : System.Collections.ICollection, System.Collections.IEnumerable {
    internal ImportCollection() { }
    public int Count { get { return default(int); } }
    public bool IsSynchronized { get { return default(bool); } }
    public object SyncRoot { get { return default(object); } }
    public void AddNewImport(string projectFile, string condition) { }
    public void CopyTo(Microsoft.Build.BuildEngine.Import[] array, int index) { }
    public void CopyTo(System.Array array, int index) { }
    public System.Collections.IEnumerator GetEnumerator() { return default(System.Collections.IEnumerator); }
    public void RemoveImport(Microsoft.Build.BuildEngine.Import importToRemove) { }
  }
  public sealed partial class InternalLoggerException : System.Exception {
    public InternalLoggerException() { }
    public InternalLoggerException(string message) { }
    public InternalLoggerException(string message, System.Exception innerException) { }
    public Microsoft.Build.Framework.BuildEventArgs BuildEventArgs { get { return default(Microsoft.Build.Framework.BuildEventArgs); } }
    public string ErrorCode { get { return default(string); } }
    public string HelpKeyword { get { return default(string); } }
    public bool InitializationException { get { return default(bool); } }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, SerializationFormatter=true)]
    public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
  }
  public sealed partial class InvalidProjectFileException : System.Exception {
    public InvalidProjectFileException() { }
    public InvalidProjectFileException(string message) { }
    public InvalidProjectFileException(string message, System.Exception innerException) { }
    public InvalidProjectFileException(string projectFile, int lineNumber, int columnNumber, int endLineNumber, int endColumnNumber, string message, string errorSubcategory, string errorCode, string helpKeyword) { }
    public InvalidProjectFileException(System.Xml.XmlNode xmlNode, string message, string errorSubcategory, string errorCode, string helpKeyword) { }
    public string BaseMessage { get { return default(string); } }
    public int ColumnNumber { get { return default(int); } }
    public int EndColumnNumber { get { return default(int); } }
    public int EndLineNumber { get { return default(int); } }
    public string ErrorCode { get { return default(string); } }
    public string ErrorSubcategory { get { return default(string); } }
    public string HelpKeyword { get { return default(string); } }
    public int LineNumber { get { return default(int); } }
    public override string Message { get { return default(string); } }
    public string ProjectFile { get { return default(string); } }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, SerializationFormatter=true)]
    public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
  }
  public partial class InvalidToolsetDefinitionException : System.Exception {
    public InvalidToolsetDefinitionException() { }
    protected InvalidToolsetDefinitionException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public InvalidToolsetDefinitionException(string message) { }
    public InvalidToolsetDefinitionException(string message, System.Exception innerException) { }
    public InvalidToolsetDefinitionException(string message, string errorCode) { }
    public InvalidToolsetDefinitionException(string message, string errorCode, System.Exception innerException) { }
    public string ErrorCode { get { return default(string); } }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, SerializationFormatter=true)]
    public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
  }
  public partial class LocalNode {
    internal LocalNode() { }
    public static void StartLocalNodeServer(int nodeNumber) { }
  }
  public partial class LoggerDescription {
    public LoggerDescription(string loggerClassName, string loggerAssemblyName, string loggerAssemblyFile, string loggerSwitchParameters, Microsoft.Build.Framework.LoggerVerbosity verbosity) { }
    public string LoggerSwitchParameters { get { return default(string); } }
    public Microsoft.Build.Framework.LoggerVerbosity Verbosity { get { return default(Microsoft.Build.Framework.LoggerVerbosity); } }
  }
  [System.ObsoleteAttribute("This class has been deprecated. Please use Microsoft.Build.Evaluation.Project from the Microsoft.Build assembly instead.")]
  public partial class Project {
    public Project() { }
    public Project(Microsoft.Build.BuildEngine.Engine engine) { }
    public Project(Microsoft.Build.BuildEngine.Engine engine, string toolsVersion) { }
    public bool BuildEnabled { get { return default(bool); } set { } }
    public string DefaultTargets { get { return default(string); } set { } }
    public string DefaultToolsVersion { get { return default(string); } set { } }
    public System.Text.Encoding Encoding { get { return default(System.Text.Encoding); } }
    public Microsoft.Build.BuildEngine.BuildItemGroup EvaluatedItems { get { return default(Microsoft.Build.BuildEngine.BuildItemGroup); } }
    public Microsoft.Build.BuildEngine.BuildItemGroup EvaluatedItemsIgnoringCondition { get { return default(Microsoft.Build.BuildEngine.BuildItemGroup); } }
    public Microsoft.Build.BuildEngine.BuildPropertyGroup EvaluatedProperties { get { return default(Microsoft.Build.BuildEngine.BuildPropertyGroup); } }
    public string FullFileName { get { return default(string); } set { } }
    public Microsoft.Build.BuildEngine.BuildPropertyGroup GlobalProperties { get { return default(Microsoft.Build.BuildEngine.BuildPropertyGroup); } set { } }
    public bool HasToolsVersionAttribute { get { return default(bool); } }
    public Microsoft.Build.BuildEngine.ImportCollection Imports { get { return default(Microsoft.Build.BuildEngine.ImportCollection); } }
    public string InitialTargets { get { return default(string); } set { } }
    public bool IsDirty { get { return default(bool); } }
    public bool IsValidated { get { return default(bool); } set { } }
    public Microsoft.Build.BuildEngine.BuildItemGroupCollection ItemGroups { get { return default(Microsoft.Build.BuildEngine.BuildItemGroupCollection); } }
    public Microsoft.Build.BuildEngine.Engine ParentEngine { get { return default(Microsoft.Build.BuildEngine.Engine); } }
    public Microsoft.Build.BuildEngine.BuildPropertyGroupCollection PropertyGroups { get { return default(Microsoft.Build.BuildEngine.BuildPropertyGroupCollection); } }
    public string SchemaFile { get { return default(string); } set { } }
    public Microsoft.Build.BuildEngine.TargetCollection Targets { get { return default(Microsoft.Build.BuildEngine.TargetCollection); } }
    public System.DateTime TimeOfLastDirty { get { return default(System.DateTime); } }
    public string ToolsVersion { get { return default(string); } }
    public Microsoft.Build.BuildEngine.UsingTaskCollection UsingTasks { get { return default(Microsoft.Build.BuildEngine.UsingTaskCollection); } }
    public string Xml { get { return default(string); } }
    public void AddNewImport(string projectFile, string condition) { }
    public Microsoft.Build.BuildEngine.BuildItem AddNewItem(string itemName, string itemInclude) { return default(Microsoft.Build.BuildEngine.BuildItem); }
    public Microsoft.Build.BuildEngine.BuildItem AddNewItem(string itemName, string itemInclude, bool treatItemIncludeAsLiteral) { return default(Microsoft.Build.BuildEngine.BuildItem); }
    public Microsoft.Build.BuildEngine.BuildItemGroup AddNewItemGroup() { return default(Microsoft.Build.BuildEngine.BuildItemGroup); }
    public Microsoft.Build.BuildEngine.BuildPropertyGroup AddNewPropertyGroup(bool insertAtEndOfProject) { return default(Microsoft.Build.BuildEngine.BuildPropertyGroup); }
    public void AddNewUsingTaskFromAssemblyFile(string taskName, string assemblyFile) { }
    public void AddNewUsingTaskFromAssemblyName(string taskName, string assemblyName) { }
    public bool Build() { return default(bool); }
    public bool Build(string targetName) { return default(bool); }
    public bool Build(System.String[] targetNames) { return default(bool); }
    public bool Build(System.String[] targetNames, System.Collections.IDictionary targetOutputs) { return default(bool); }
    public bool Build(System.String[] targetNames, System.Collections.IDictionary targetOutputs, Microsoft.Build.BuildEngine.BuildSettings buildFlags) { return default(bool); }
    public System.String[] GetConditionedPropertyValues(string propertyName) { return default(System.String[]); }
    public Microsoft.Build.BuildEngine.BuildItemGroup GetEvaluatedItemsByName(string itemName) { return default(Microsoft.Build.BuildEngine.BuildItemGroup); }
    public Microsoft.Build.BuildEngine.BuildItemGroup GetEvaluatedItemsByNameIgnoringCondition(string itemName) { return default(Microsoft.Build.BuildEngine.BuildItemGroup); }
    public string GetEvaluatedProperty(string propertyName) { return default(string); }
    public string GetProjectExtensions(string id) { return default(string); }
    public void Load(System.IO.TextReader textReader) { }
    public void Load(System.IO.TextReader textReader, Microsoft.Build.BuildEngine.ProjectLoadSettings projectLoadSettings) { }
    public void Load(string projectFileName) { }
    public void Load(string projectFileName, Microsoft.Build.BuildEngine.ProjectLoadSettings projectLoadSettings) { }
    public void LoadXml(string projectXml) { }
    public void LoadXml(string projectXml, Microsoft.Build.BuildEngine.ProjectLoadSettings projectLoadSettings) { }
    public void MarkProjectAsDirty() { }
    public void RemoveAllItemGroups() { }
    public void RemoveAllPropertyGroups() { }
    public void RemoveImportedPropertyGroup(Microsoft.Build.BuildEngine.BuildPropertyGroup propertyGroupToRemove) { }
    public void RemoveItem(Microsoft.Build.BuildEngine.BuildItem itemToRemove) { }
    public void RemoveItemGroup(Microsoft.Build.BuildEngine.BuildItemGroup itemGroupToRemove) { }
    public void RemoveItemGroupsWithMatchingCondition(string matchCondition) { }
    public void RemoveItemsByName(string itemName) { }
    public void RemovePropertyGroup(Microsoft.Build.BuildEngine.BuildPropertyGroup propertyGroupToRemove) { }
    public void RemovePropertyGroupsWithMatchingCondition(string matchCondition) { }
    public void RemovePropertyGroupsWithMatchingCondition(string matchCondition, bool includeImportedPropertyGroups) { }
    public void ResetBuildStatus() { }
    public void Save(System.IO.TextWriter textWriter) { }
    public void Save(string projectFileName) { }
    public void Save(string projectFileName, System.Text.Encoding encoding) { }
    public void SetImportedProperty(string propertyName, string propertyValue, string condition, Microsoft.Build.BuildEngine.Project importProject) { }
    public void SetImportedProperty(string propertyName, string propertyValue, string condition, Microsoft.Build.BuildEngine.Project importedProject, Microsoft.Build.BuildEngine.PropertyPosition position) { }
    public void SetImportedProperty(string propertyName, string propertyValue, string condition, Microsoft.Build.BuildEngine.Project importedProject, Microsoft.Build.BuildEngine.PropertyPosition position, bool treatPropertyValueAsLiteral) { }
    public void SetProjectExtensions(string id, string content) { }
    public void SetProperty(string propertyName, string propertyValue) { }
    public void SetProperty(string propertyName, string propertyValue, string condition) { }
    public void SetProperty(string propertyName, string propertyValue, string condition, Microsoft.Build.BuildEngine.PropertyPosition position) { }
    public void SetProperty(string propertyName, string propertyValue, string condition, Microsoft.Build.BuildEngine.PropertyPosition position, bool treatPropertyValueAsLiteral) { }
  }
  [System.FlagsAttribute]
  public enum ProjectLoadSettings {
    IgnoreMissingImports = 1,
    None = 0,
  }
  public enum PropertyPosition {
    UseExistingOrCreateAfterLastImport = 1,
    UseExistingOrCreateAfterLastPropertyGroup = 0,
  }
  public sealed partial class RemoteErrorException : System.Exception {
    internal RemoteErrorException() { }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, SerializationFormatter=true)]
    public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
  }
  public static partial class SolutionWrapperProject {
    public static string Generate(string solutionPath, string toolsVersionOverride, Microsoft.Build.Framework.BuildEventContext projectBuildEventContext) { return default(string); }
  }
  [System.Diagnostics.DebuggerDisplayAttribute("Target (Name = { Name }, Condition = { Condition })")]
  public partial class Target : System.Collections.IEnumerable {
    internal Target() { }
    public string Condition { get { return default(string); } set { } }
    public string DependsOnTargets { get { return default(string); } set { } }
    public string Inputs { get { return default(string); } set { } }
    public bool IsImported { get { return default(bool); } }
    public string Name { get { return default(string); } }
    public string Outputs { get { return default(string); } set { } }
    public Microsoft.Build.BuildEngine.BuildTask AddNewTask(string taskName) { return default(Microsoft.Build.BuildEngine.BuildTask); }
    public System.Collections.IEnumerator GetEnumerator() { return default(System.Collections.IEnumerator); }
    public void RemoveTask(Microsoft.Build.BuildEngine.BuildTask taskElement) { }
  }
  public partial class TargetCollection : System.Collections.ICollection, System.Collections.IEnumerable {
    internal TargetCollection() { }
    public int Count { get { return default(int); } }
    public bool IsSynchronized { get { return default(bool); } }
    public Microsoft.Build.BuildEngine.Target this[string index] { get { return default(Microsoft.Build.BuildEngine.Target); } }
    public object SyncRoot { get { return default(object); } }
    public Microsoft.Build.BuildEngine.Target AddNewTarget(string targetName) { return default(Microsoft.Build.BuildEngine.Target); }
    public void CopyTo(System.Array array, int index) { }
    public bool Exists(string targetName) { return default(bool); }
    public System.Collections.IEnumerator GetEnumerator() { return default(System.Collections.IEnumerator); }
    public void RemoveTarget(Microsoft.Build.BuildEngine.Target targetToRemove) { }
  }
  public partial class Toolset {
    public Toolset(string toolsVersion, string toolsPath) { }
    public Toolset(string toolsVersion, string toolsPath, Microsoft.Build.BuildEngine.BuildPropertyGroup buildProperties) { }
    public Microsoft.Build.BuildEngine.BuildPropertyGroup BuildProperties { get { return default(Microsoft.Build.BuildEngine.BuildPropertyGroup); } }
    public string ToolsPath { get { return default(string); } }
    public string ToolsVersion { get { return default(string); } }
    public Microsoft.Build.BuildEngine.Toolset Clone() { return default(Microsoft.Build.BuildEngine.Toolset); }
  }
  public partial class ToolsetCollection : System.Collections.Generic.ICollection<Microsoft.Build.BuildEngine.Toolset>, System.Collections.Generic.IEnumerable<Microsoft.Build.BuildEngine.Toolset>, System.Collections.IEnumerable {
    internal ToolsetCollection() { }
    public int Count { get { return default(int); } }
    public bool IsReadOnly { get { return default(bool); } }
    public Microsoft.Build.BuildEngine.Toolset this[string toolsVersion] { get { return default(Microsoft.Build.BuildEngine.Toolset); } }
    public System.Collections.Generic.IEnumerable<System.String> ToolsVersions { get { return default(System.Collections.Generic.IEnumerable<System.String>); } }
    public void Add(Microsoft.Build.BuildEngine.Toolset item) { }
    public void Clear() { }
    public bool Contains(Microsoft.Build.BuildEngine.Toolset item) { return default(bool); }
    public bool Contains(string toolsVersion) { return default(bool); }
    public void CopyTo(Microsoft.Build.BuildEngine.Toolset[] array, int arrayIndex) { }
    public System.Collections.Generic.IEnumerator<Microsoft.Build.BuildEngine.Toolset> GetEnumerator() { return default(System.Collections.Generic.IEnumerator<Microsoft.Build.BuildEngine.Toolset>); }
    public bool Remove(Microsoft.Build.BuildEngine.Toolset item) { return default(bool); }
    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { return default(System.Collections.IEnumerator); }
  }
  [System.FlagsAttribute]
  public enum ToolsetDefinitionLocations {
    ConfigurationFile = 1,
    None = 0,
    Registry = 2,
  }
  public partial class UsingTask {
    internal UsingTask() { }
    public string AssemblyFile { get { return default(string); } }
    public string AssemblyName { get { return default(string); } }
    public string Condition { get { return default(string); } }
    public bool IsImported { get { return default(bool); } }
    public string TaskName { get { return default(string); } }
  }
  public partial class UsingTaskCollection : System.Collections.ICollection, System.Collections.IEnumerable {
    internal UsingTaskCollection() { }
    public int Count { get { return default(int); } }
    public bool IsSynchronized { get { return default(bool); } }
    public object SyncRoot { get { return default(object); } }
    public void CopyTo(Microsoft.Build.BuildEngine.UsingTask[] array, int index) { }
    public void CopyTo(System.Array array, int index) { }
    public System.Collections.IEnumerator GetEnumerator() { return default(System.Collections.IEnumerator); }
  }
  public static partial class Utilities {
    public static string Escape(string unescapedExpression) { return default(string); }
  }
  public delegate void WriteHandler(string message);
}
