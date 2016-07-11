namespace Microsoft.Build.BuildEngine {
  public partial class BuildItem {
    public BuildItem(string itemName, Microsoft.Build.Framework.ITaskItem taskItem) { }
    public BuildItem(string itemName, string itemInclude) { }
    public string Condition { get { return default(string); } set { } }
    public string Exclude { get { return default(string); } set { } }
    public string FinalItemSpec { get { return default(string); } }
    public string Include { get { return default(string); } set { } }
    public bool IsImported { get { return default(bool); } }
    public string Name { get { return default(string); } set { } }
    [System.MonoTODOAttribute]
    public Microsoft.Build.BuildEngine.BuildItem Clone() { return default(Microsoft.Build.BuildEngine.BuildItem); }
    public void CopyCustomMetadataTo(Microsoft.Build.BuildEngine.BuildItem destinationItem) { }
    public string GetEvaluatedMetadata(string metadataName) { return default(string); }
    public string GetMetadata(string metadataName) { return default(string); }
    public bool HasMetadata(string metadataName) { return default(bool); }
    public void RemoveMetadata(string metadataName) { }
    public void SetMetadata(string metadataName, string metadataValue) { }
    public void SetMetadata(string metadataName, string metadataValue, bool treatMetadataValueAsLiteral) { }
  }
  public partial class BuildItemGroup : System.Collections.IEnumerable {
    public BuildItemGroup() { }
    public string Condition { get { return default(string); } set { } }
    public int Count { get { return default(int); } }
    public bool IsImported { get { return default(bool); } }
    [System.MonoTODOAttribute]
    public Microsoft.Build.BuildEngine.BuildItem this[int index] { get { return default(Microsoft.Build.BuildEngine.BuildItem); } }
    public Microsoft.Build.BuildEngine.BuildItem AddNewItem(string itemName, string itemInclude) { return default(Microsoft.Build.BuildEngine.BuildItem); }
    [System.MonoTODOAttribute]
    public Microsoft.Build.BuildEngine.BuildItem AddNewItem(string itemName, string itemInclude, bool treatItemIncludeAsLiteral) { return default(Microsoft.Build.BuildEngine.BuildItem); }
    public void Clear() { }
    [System.MonoTODOAttribute]
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
  public partial class BuildProperty {
    public BuildProperty(string propertyName, string propertyValue) { }
    public string Condition { get { return default(string); } set { } }
    public string FinalValue { get { return default(string); } }
    public bool IsImported { get { return default(bool); } }
    public string Name { get { return default(string); } }
    public string Value { get { return default(string); } set { } }
    [System.MonoTODOAttribute]
    public Microsoft.Build.BuildEngine.BuildProperty Clone(bool deepClone) { return default(Microsoft.Build.BuildEngine.BuildProperty); }
    public static explicit operator string (Microsoft.Build.BuildEngine.BuildProperty propertyToCast) { return default(string); }
    public override string ToString() { return default(string); }
  }
  public partial class BuildPropertyGroup : System.Collections.IEnumerable {
    public BuildPropertyGroup() { }
    public string Condition { get { return default(string); } set { } }
    public int Count { get { return default(int); } }
    public bool IsImported { get { return default(bool); } }
    public Microsoft.Build.BuildEngine.BuildProperty this[string propertyName] { get { return default(Microsoft.Build.BuildEngine.BuildProperty); } set { } }
    public Microsoft.Build.BuildEngine.BuildProperty AddNewProperty(string propertyName, string propertyValue) { return default(Microsoft.Build.BuildEngine.BuildProperty); }
    public Microsoft.Build.BuildEngine.BuildProperty AddNewProperty(string propertyName, string propertyValue, bool treatPropertyValueAsLiteral) { return default(Microsoft.Build.BuildEngine.BuildProperty); }
    public void Clear() { }
    [System.MonoTODOAttribute]
    public Microsoft.Build.BuildEngine.BuildPropertyGroup Clone(bool deepClone) { return default(Microsoft.Build.BuildEngine.BuildPropertyGroup); }
    [System.Diagnostics.DebuggerHiddenAttribute]
    public System.Collections.IEnumerator GetEnumerator() { return default(System.Collections.IEnumerator); }
    public void RemoveProperty(Microsoft.Build.BuildEngine.BuildProperty propertyToRemove) { }
    public void RemoveProperty(string propertyName) { }
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
    [System.MonoTODOAttribute]
    public bool ContinueOnError { get { return default(bool); } set { } }
    [System.MonoTODOAttribute]
    public Microsoft.Build.Framework.ITaskHost HostObject { get { return default(Microsoft.Build.Framework.ITaskHost); } set { } }
    public string Name { get { return default(string); } }
    [System.MonoTODOAttribute]
    public System.Type Type { get { return default(System.Type); } }
    [System.MonoTODOAttribute]
    public void AddOutputItem(string taskParameter, string itemName) { }
    [System.MonoTODOAttribute]
    public void AddOutputProperty(string taskParameter, string propertyName) { }
    public bool Execute() { return default(bool); }
    [System.Diagnostics.DebuggerHiddenAttribute]
    public System.Collections.Generic.IEnumerable<System.String> GetAttributes() { return default(System.Collections.Generic.IEnumerable<System.String>); }
    public System.String[] GetParameterNames() { return default(System.String[]); }
    public string GetParameterValue(string attributeName) { return default(string); }
    public void SetParameterValue(string parameterName, string parameterValue) { }
    public void SetParameterValue(string parameterName, string parameterValue, bool treatParameterValueAsLiteral) { }
  }
  public delegate void ColorResetter();
  public delegate void ColorSetter(System.ConsoleColor color);
  public partial class ConsoleLogger : Microsoft.Build.Framework.ILogger {
    public ConsoleLogger() { }
    public ConsoleLogger(Microsoft.Build.Framework.LoggerVerbosity verbosity) { }
    public ConsoleLogger(Microsoft.Build.Framework.LoggerVerbosity verbosity, Microsoft.Build.BuildEngine.WriteHandler write, Microsoft.Build.BuildEngine.ColorSetter colorSet, Microsoft.Build.BuildEngine.ColorResetter colorReset) { }
    public string Parameters { get { return default(string); } set { } }
    public bool ShowSummary { get { return default(bool); } set { } }
    public bool SkipProjectStartedText { get { return default(bool); } set { } }
    public Microsoft.Build.Framework.LoggerVerbosity Verbosity { get { return default(Microsoft.Build.Framework.LoggerVerbosity); } set { } }
    protected Microsoft.Build.BuildEngine.WriteHandler WriteHandler { get { return default(Microsoft.Build.BuildEngine.WriteHandler); } set { } }
    public void ApplyParameter(string parameterName, string parameterValue) { }
    public void BuildFinishedHandler(object sender, Microsoft.Build.Framework.BuildFinishedEventArgs args) { }
    public void BuildStartedHandler(object sender, Microsoft.Build.Framework.BuildStartedEventArgs args) { }
    [System.MonoTODOAttribute]
    public void CustomEventHandler(object sender, Microsoft.Build.Framework.CustomBuildEventArgs args) { }
    public void ErrorHandler(object sender, Microsoft.Build.Framework.BuildErrorEventArgs args) { }
    public virtual void Initialize(Microsoft.Build.Framework.IEventSource eventSource) { }
    public void MessageHandler(object sender, Microsoft.Build.Framework.BuildMessageEventArgs args) { }
    public void ProjectFinishedHandler(object sender, Microsoft.Build.Framework.ProjectFinishedEventArgs args) { }
    public void ProjectStartedHandler(object sender, Microsoft.Build.Framework.ProjectStartedEventArgs args) { }
    public virtual void Shutdown() { }
    public void TargetFinishedHandler(object sender, Microsoft.Build.Framework.TargetFinishedEventArgs args) { }
    public void TargetStartedHandler(object sender, Microsoft.Build.Framework.TargetStartedEventArgs args) { }
    public void TaskFinishedHandler(object sender, Microsoft.Build.Framework.TaskFinishedEventArgs args) { }
    public void TaskStartedHandler(object sender, Microsoft.Build.Framework.TaskStartedEventArgs args) { }
    public void WarningHandler(object sender, Microsoft.Build.Framework.BuildWarningEventArgs args) { }
  }
  public partial class Engine {
    public Engine() { }
    public Engine(Microsoft.Build.BuildEngine.BuildPropertyGroup globalProperties) { }
    public Engine(Microsoft.Build.BuildEngine.BuildPropertyGroup globalProperties, Microsoft.Build.BuildEngine.ToolsetDefinitionLocations locations) { }
    public Engine(Microsoft.Build.BuildEngine.ToolsetDefinitionLocations locations) { }
    public Engine(string binPath) { }
    public string BinPath { get { return default(string); } set { } }
    public bool BuildEnabled { get { return default(bool); } set { } }
    public string DefaultToolsVersion { get { return default(string); } set { } }
    public static Microsoft.Build.BuildEngine.Engine GlobalEngine { get { return default(Microsoft.Build.BuildEngine.Engine); } }
    public Microsoft.Build.BuildEngine.BuildPropertyGroup GlobalProperties { get { return default(Microsoft.Build.BuildEngine.BuildPropertyGroup); } set { } }
    public bool IsBuilding { get { return default(bool); } }
    public bool OnlyLogCriticalEvents { get { return default(bool); } set { } }
    public Microsoft.Build.BuildEngine.ToolsetCollection Toolsets { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(Microsoft.Build.BuildEngine.ToolsetCollection); } }
    public static System.Version Version { get { return default(System.Version); } }
    [System.MonoTODOAttribute]
    public bool BuildProject(Microsoft.Build.BuildEngine.Project project) { return default(bool); }
    [System.MonoTODOAttribute]
    public bool BuildProject(Microsoft.Build.BuildEngine.Project project, string targetName) { return default(bool); }
    [System.MonoTODOAttribute]
    public bool BuildProject(Microsoft.Build.BuildEngine.Project project, System.String[] targetNames) { return default(bool); }
    [System.MonoTODOAttribute]
    public bool BuildProject(Microsoft.Build.BuildEngine.Project project, System.String[] targetNames, System.Collections.IDictionary targetOutputs) { return default(bool); }
    public bool BuildProject(Microsoft.Build.BuildEngine.Project project, System.String[] targetNames, System.Collections.IDictionary targetOutputs, Microsoft.Build.BuildEngine.BuildSettings buildFlags) { return default(bool); }
    [System.MonoTODOAttribute]
    public bool BuildProjectFile(string projectFile) { return default(bool); }
    [System.MonoTODOAttribute]
    public bool BuildProjectFile(string projectFile, string targetName) { return default(bool); }
    [System.MonoTODOAttribute]
    public bool BuildProjectFile(string projectFile, System.String[] targetNames) { return default(bool); }
    [System.MonoTODOAttribute]
    public bool BuildProjectFile(string projectFile, System.String[] targetNames, Microsoft.Build.BuildEngine.BuildPropertyGroup globalProperties) { return default(bool); }
    [System.MonoTODOAttribute]
    public bool BuildProjectFile(string projectFile, System.String[] targetNames, Microsoft.Build.BuildEngine.BuildPropertyGroup globalProperties, System.Collections.IDictionary targetOutputs) { return default(bool); }
    public bool BuildProjectFile(string projectFile, System.String[] targetNames, Microsoft.Build.BuildEngine.BuildPropertyGroup globalProperties, System.Collections.IDictionary targetOutputs, Microsoft.Build.BuildEngine.BuildSettings buildFlags) { return default(bool); }
    public bool BuildProjectFile(string projectFile, System.String[] targetNames, Microsoft.Build.BuildEngine.BuildPropertyGroup globalProperties, System.Collections.IDictionary targetOutputs, Microsoft.Build.BuildEngine.BuildSettings buildFlags, string toolsVersion) { return default(bool); }
    public Microsoft.Build.BuildEngine.Project CreateNewProject() { return default(Microsoft.Build.BuildEngine.Project); }
    public Microsoft.Build.BuildEngine.Project GetLoadedProject(string projectFullFileName) { return default(Microsoft.Build.BuildEngine.Project); }
    [System.MonoTODOAttribute]
    public void RegisterLogger(Microsoft.Build.Framework.ILogger logger) { }
    public void UnloadAllProjects() { }
    public void UnloadProject(Microsoft.Build.BuildEngine.Project project) { }
    [System.MonoTODOAttribute]
    public void UnregisterAllLoggers() { }
  }
  public partial class FileLogger : Microsoft.Build.BuildEngine.ConsoleLogger {
    public FileLogger() { }
    public override void Initialize(Microsoft.Build.Framework.IEventSource eventSource) { }
    public override void Shutdown() { }
  }
  public partial class Import {
    internal Import() { }
    public string Condition { get { return default(string); } }
    public string EvaluatedProjectPath { get { return default(string); } }
    public bool IsImported { get { return default(bool); } }
    public string ProjectPath { get { return default(string); } }
  }
  public partial class ImportCollection : System.Collections.ICollection, System.Collections.IEnumerable {
    internal ImportCollection() { }
    public int Count { get { return default(int); } }
    public bool IsSynchronized { get { return default(bool); } }
    public object SyncRoot { get { return default(object); } }
    public void CopyTo(Microsoft.Build.BuildEngine.Import[] array, int index) { }
    public void CopyTo(System.Array array, int index) { }
    public System.Collections.IEnumerator GetEnumerator() { return default(System.Collections.IEnumerator); }
  }
  public sealed partial class InternalLoggerException : System.Exception {
    public InternalLoggerException() { }
    public InternalLoggerException(string message) { }
    public InternalLoggerException(string message, System.Exception innerException) { }
    public Microsoft.Build.Framework.BuildEventArgs BuildEventArgs { get { return default(Microsoft.Build.Framework.BuildEventArgs); } }
    public string ErrorCode { get { return default(string); } }
    public string HelpKeyword { get { return default(string); } }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, SerializationFormatter=true)]
    public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
  }
  public sealed partial class InvalidProjectFileException : System.Exception {
    public InvalidProjectFileException() { }
    public InvalidProjectFileException(string message) { }
    public InvalidProjectFileException(string message, System.Exception innerException) { }
    public InvalidProjectFileException(string projectFile, int lineNumber, int columnNumber, int endLineNumber, int endColumnNumber, string message, string errorSubcategory, string errorCode, string helpKeyword) { }
    [System.MonoTODOAttribute]
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
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, SerializationFormatter=true)]
    public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
  }
  public partial class Project {
    public Project() { }
    public Project(Microsoft.Build.BuildEngine.Engine engine) { }
    public Project(Microsoft.Build.BuildEngine.Engine engine, string toolsVersion) { }
    public bool BuildEnabled { get { return default(bool); } set { } }
    public string DefaultTargets { get { return default(string); } set { } }
    public string DefaultToolsVersion { get { return default(string); } set { } }
    [System.MonoTODOAttribute]
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
    public string ToolsVersion { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
    public Microsoft.Build.BuildEngine.UsingTaskCollection UsingTasks { get { return default(Microsoft.Build.BuildEngine.UsingTaskCollection); } }
    [System.MonoTODOAttribute]
    public string Xml { get { return default(string); } }
    [System.MonoTODOAttribute("Not tested")]
    public void AddNewImport(string importLocation, string importCondition) { }
    public Microsoft.Build.BuildEngine.BuildItem AddNewItem(string itemName, string itemInclude) { return default(Microsoft.Build.BuildEngine.BuildItem); }
    [System.MonoTODOAttribute("Adds item not in the same place as MS")]
    public Microsoft.Build.BuildEngine.BuildItem AddNewItem(string itemName, string itemInclude, bool treatItemIncludeAsLiteral) { return default(Microsoft.Build.BuildEngine.BuildItem); }
    [System.MonoTODOAttribute("Not tested")]
    public Microsoft.Build.BuildEngine.BuildItemGroup AddNewItemGroup() { return default(Microsoft.Build.BuildEngine.BuildItemGroup); }
    [System.MonoTODOAttribute("Ignores insertAtEndOfProject")]
    public Microsoft.Build.BuildEngine.BuildPropertyGroup AddNewPropertyGroup(bool insertAtEndOfProject) { return default(Microsoft.Build.BuildEngine.BuildPropertyGroup); }
    [System.MonoTODOAttribute("Not tested, isn't added to TaskDatabase (no reevaluation)")]
    public void AddNewUsingTaskFromAssemblyFile(string taskName, string assemblyFile) { }
    [System.MonoTODOAttribute("Not tested, isn't added to TaskDatabase (no reevaluation)")]
    public void AddNewUsingTaskFromAssemblyName(string taskName, string assemblyName) { }
    [System.MonoTODOAttribute("Not tested")]
    public bool Build() { return default(bool); }
    [System.MonoTODOAttribute("Not tested")]
    public bool Build(string targetName) { return default(bool); }
    [System.MonoTODOAttribute("Not tested")]
    public bool Build(System.String[] targetNames) { return default(bool); }
    [System.MonoTODOAttribute("Not tested")]
    public bool Build(System.String[] targetNames, System.Collections.IDictionary targetOutputs) { return default(bool); }
    [System.MonoTODOAttribute("Not tested")]
    public bool Build(System.String[] targetNames, System.Collections.IDictionary targetOutputs, Microsoft.Build.BuildEngine.BuildSettings buildFlags) { return default(bool); }
    [System.MonoTODOAttribute]
    public System.String[] GetConditionedPropertyValues(string propertyName) { return default(System.String[]); }
    public Microsoft.Build.BuildEngine.BuildItemGroup GetEvaluatedItemsByName(string itemName) { return default(Microsoft.Build.BuildEngine.BuildItemGroup); }
    public Microsoft.Build.BuildEngine.BuildItemGroup GetEvaluatedItemsByNameIgnoringCondition(string itemName) { return default(Microsoft.Build.BuildEngine.BuildItemGroup); }
    public string GetEvaluatedProperty(string propertyName) { return default(string); }
    [System.MonoTODOAttribute("We should remember that node and not use XPath to get it")]
    public string GetProjectExtensions(string id) { return default(string); }
    [System.MonoTODOAttribute("Not tested")]
    public void Load(System.IO.TextReader textReader) { }
    public void Load(System.IO.TextReader textReader, Microsoft.Build.BuildEngine.ProjectLoadSettings projectLoadSettings) { }
    public void Load(string projectFileName) { }
    public void Load(string projectFileName, Microsoft.Build.BuildEngine.ProjectLoadSettings settings) { }
    public void LoadXml(string projectXml) { }
    public void LoadXml(string projectXml, Microsoft.Build.BuildEngine.ProjectLoadSettings projectLoadSettings) { }
    public void MarkProjectAsDirty() { }
    [System.MonoTODOAttribute("Not tested")]
    public void RemoveAllItemGroups() { }
    [System.MonoTODOAttribute("Not tested")]
    public void RemoveAllPropertyGroups() { }
    [System.MonoTODOAttribute]
    public void RemoveItem(Microsoft.Build.BuildEngine.BuildItem itemToRemove) { }
    [System.MonoTODOAttribute("Not tested")]
    public void RemoveItemGroup(Microsoft.Build.BuildEngine.BuildItemGroup itemGroupToRemove) { }
    [System.MonoTODOAttribute]
    public void RemoveItemGroupsWithMatchingCondition(string matchingCondition) { }
    [System.MonoTODOAttribute]
    public void RemoveItemsByName(string itemName) { }
    [System.MonoTODOAttribute("Not tested")]
    public void RemovePropertyGroup(Microsoft.Build.BuildEngine.BuildPropertyGroup propertyGroupToRemove) { }
    [System.MonoTODOAttribute]
    public void RemovePropertyGroupsWithMatchingCondition(string matchCondition) { }
    [System.MonoTODOAttribute]
    public void ResetBuildStatus() { }
    public void Save(System.IO.TextWriter outTextWriter) { }
    public void Save(string projectFileName) { }
    [System.MonoTODOAttribute("Ignores encoding")]
    public void Save(string projectFileName, System.Text.Encoding encoding) { }
    public void SetImportedProperty(string propertyName, string propertyValue, string condition, Microsoft.Build.BuildEngine.Project importProject) { }
    public void SetImportedProperty(string propertyName, string propertyValue, string condition, Microsoft.Build.BuildEngine.Project importedProject, Microsoft.Build.BuildEngine.PropertyPosition position) { }
    [System.MonoTODOAttribute]
    public void SetImportedProperty(string propertyName, string propertyValue, string condition, Microsoft.Build.BuildEngine.Project importedProject, Microsoft.Build.BuildEngine.PropertyPosition position, bool treatPropertyValueAsLiteral) { }
    public void SetProjectExtensions(string id, string xmlText) { }
    public void SetProperty(string propertyName, string propertyValue) { }
    public void SetProperty(string propertyName, string propertyValue, string condition) { }
    public void SetProperty(string propertyName, string propertyValue, string condition, Microsoft.Build.BuildEngine.PropertyPosition position) { }
    [System.MonoTODOAttribute]
    public void SetProperty(string propertyName, string propertyValue, string condition, Microsoft.Build.BuildEngine.PropertyPosition position, bool treatPropertyValueAsLiteral) { }
  }
  public enum ProjectLoadSettings {
    IgnoreMissingImports = 1,
    None = 0,
  }
  public enum PropertyPosition {
    UseExistingOrCreateAfterLastImport = 1,
    UseExistingOrCreateAfterLastPropertyGroup = 0,
  }
  public partial class Target : System.Collections.IEnumerable {
    internal Target() { }
    public string Condition { get { return default(string); } set { } }
    public string DependsOnTargets { get { return default(string); } set { } }
    public bool IsImported { get { return default(bool); } }
    public string Name { get { return default(string); } }
    public string Outputs { get { return default(string); } set { } }
    [System.MonoTODOAttribute]
    public Microsoft.Build.BuildEngine.BuildTask AddNewTask(string taskName) { return default(Microsoft.Build.BuildEngine.BuildTask); }
    public System.Collections.IEnumerator GetEnumerator() { return default(System.Collections.IEnumerator); }
    public void RemoveTask(Microsoft.Build.BuildEngine.BuildTask buildTask) { }
  }
  public partial class TargetCollection : System.Collections.ICollection, System.Collections.IEnumerable {
    internal TargetCollection() { }
    public int Count { get { return default(int); } }
    public bool IsSynchronized { get { return default(bool); } }
    public Microsoft.Build.BuildEngine.Target this[string index] { get { return default(Microsoft.Build.BuildEngine.Target); } }
    public object SyncRoot { get { return default(object); } }
    [System.MonoTODOAttribute]
    public Microsoft.Build.BuildEngine.Target AddNewTarget(string targetName) { return default(Microsoft.Build.BuildEngine.Target); }
    public void CopyTo(System.Array array, int index) { }
    public bool Exists(string targetName) { return default(bool); }
    [System.Diagnostics.DebuggerHiddenAttribute]
    public System.Collections.IEnumerator GetEnumerator() { return default(System.Collections.IEnumerator); }
    public void RemoveTarget(Microsoft.Build.BuildEngine.Target targetToRemove) { }
  }
  public partial class Toolset {
    public Toolset(string toolsVersion, string toolsPath) { }
    public Toolset(string toolsVersion, string toolsPath, Microsoft.Build.BuildEngine.BuildPropertyGroup buildProperties) { }
    public Microsoft.Build.BuildEngine.BuildPropertyGroup BuildProperties { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(Microsoft.Build.BuildEngine.BuildPropertyGroup); } }
    public string ToolsPath { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
    public string ToolsVersion { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
  }
  public partial class ToolsetCollection : System.Collections.Generic.ICollection<Microsoft.Build.BuildEngine.Toolset>, System.Collections.Generic.IEnumerable<Microsoft.Build.BuildEngine.Toolset>, System.Collections.IEnumerable {
    internal ToolsetCollection() { }
    public int Count { get { return default(int); } }
    public bool IsReadOnly { get { return default(bool); } }
    public Microsoft.Build.BuildEngine.Toolset this[string toolsVersion] { get { return default(Microsoft.Build.BuildEngine.Toolset); } }
    public void Add(Microsoft.Build.BuildEngine.Toolset item) { }
    public void Clear() { }
    public bool Contains(Microsoft.Build.BuildEngine.Toolset item) { return default(bool); }
    public bool Contains(string toolsVersion) { return default(bool); }
    public void CopyTo(Microsoft.Build.BuildEngine.Toolset[] array, int arrayIndex) { }
    public System.Collections.Generic.IEnumerator<Microsoft.Build.BuildEngine.Toolset> GetEnumerator() { return default(System.Collections.Generic.IEnumerator<Microsoft.Build.BuildEngine.Toolset>); }
    public bool Remove(Microsoft.Build.BuildEngine.Toolset item) { return default(bool); }
    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { return default(System.Collections.IEnumerator); }
  }
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
    [System.Diagnostics.DebuggerHiddenAttribute]
    public System.Collections.IEnumerator GetEnumerator() { return default(System.Collections.IEnumerator); }
  }
  public static partial class Utilities {
    public static string Escape(string unescapedExpression) { return default(string); }
  }
  public delegate void WriteHandler(string message);
}
