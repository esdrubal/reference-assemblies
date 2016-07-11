namespace Microsoft.Build.Construction {
  [System.Diagnostics.DebuggerDisplayAttribute("ProjectChooseElement (#Children={Count} HasOtherwise={OtherwiseElement != null})")]
  public partial class ProjectChooseElement : Microsoft.Build.Construction.ProjectElementContainer {
    internal ProjectChooseElement() { }
    public override string Condition { get { return default(string); } set { } }
    public Microsoft.Build.Construction.ProjectOtherwiseElement OtherwiseElement { get { return default(Microsoft.Build.Construction.ProjectOtherwiseElement); } }
    public System.Collections.Generic.ICollection<Microsoft.Build.Construction.ProjectWhenElement> WhenElements { get { return default(System.Collections.Generic.ICollection<Microsoft.Build.Construction.ProjectWhenElement>); } }
  }
  public abstract partial class ProjectElement {
    internal ProjectElement() { }
    public System.Collections.Generic.IEnumerable<Microsoft.Build.Construction.ProjectElementContainer> AllParents { get { return default(System.Collections.Generic.IEnumerable<Microsoft.Build.Construction.ProjectElementContainer>); } }
    public virtual string Condition { get { return default(string); } set { } }
    public Microsoft.Build.Construction.ProjectRootElement ContainingProject { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(Microsoft.Build.Construction.ProjectRootElement); } }
    public string Label { get { return default(string); } set { } }
    public Microsoft.Build.Construction.ProjectElement NextSibling { get { return default(Microsoft.Build.Construction.ProjectElement); } }
    public Microsoft.Build.Construction.ProjectElementContainer Parent { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(Microsoft.Build.Construction.ProjectElementContainer); } }
    public Microsoft.Build.Construction.ProjectElement PreviousSibling { get { return default(Microsoft.Build.Construction.ProjectElement); } }
  }
  public abstract partial class ProjectElementContainer : Microsoft.Build.Construction.ProjectElement {
    internal ProjectElementContainer() { }
    public System.Collections.Generic.IEnumerable<Microsoft.Build.Construction.ProjectElement> AllChildren { get { return default(System.Collections.Generic.IEnumerable<Microsoft.Build.Construction.ProjectElement>); } }
    public System.Collections.Generic.ICollection<Microsoft.Build.Construction.ProjectElement> Children { get { return default(System.Collections.Generic.ICollection<Microsoft.Build.Construction.ProjectElement>); } }
    public System.Collections.Generic.ICollection<Microsoft.Build.Construction.ProjectElement> ChildrenReversed { get { return default(System.Collections.Generic.ICollection<Microsoft.Build.Construction.ProjectElement>); } }
    public int Count { get { return default(int); } }
    public Microsoft.Build.Construction.ProjectElement FirstChild { get { return default(Microsoft.Build.Construction.ProjectElement); } }
    public Microsoft.Build.Construction.ProjectElement LastChild { get { return default(Microsoft.Build.Construction.ProjectElement); } }
    public void AppendChild(Microsoft.Build.Construction.ProjectElement child) { }
    public void InsertAfterChild(Microsoft.Build.Construction.ProjectElement child, Microsoft.Build.Construction.ProjectElement reference) { }
    public void InsertBeforeChild(Microsoft.Build.Construction.ProjectElement child, Microsoft.Build.Construction.ProjectElement reference) { }
    public void PrependChild(Microsoft.Build.Construction.ProjectElement child) { }
    public void RemoveAllChildren() { }
    public void RemoveChild(Microsoft.Build.Construction.ProjectElement child) { }
  }
  public partial class ProjectExtensionsElement : Microsoft.Build.Construction.ProjectElement {
    internal ProjectExtensionsElement() { }
    public override string Condition { get { return default(string); } set { } }
    public string Content { get { return default(string); } set { } }
    public string this[string name] { get { return default(string); } set { } }
  }
  [System.Diagnostics.DebuggerDisplayAttribute("Project={Project} Condition={Condition}")]
  public partial class ProjectImportElement : Microsoft.Build.Construction.ProjectElement {
    internal ProjectImportElement() { }
    public string Project { get { return default(string); } set { } }
  }
  [System.Diagnostics.DebuggerDisplayAttribute("#Imports={Count} Condition={Condition} Label={Label}")]
  public partial class ProjectImportGroupElement : Microsoft.Build.Construction.ProjectElementContainer {
    internal ProjectImportGroupElement() { }
    public System.Collections.Generic.ICollection<Microsoft.Build.Construction.ProjectImportElement> Imports { get { return default(System.Collections.Generic.ICollection<Microsoft.Build.Construction.ProjectImportElement>); } }
    public Microsoft.Build.Construction.ProjectImportElement AddImport(string project) { return default(Microsoft.Build.Construction.ProjectImportElement); }
  }
  [System.Diagnostics.DebuggerDisplayAttribute("{ItemType} #Metadata={Count} Condition={Condition}")]
  public partial class ProjectItemDefinitionElement : Microsoft.Build.Construction.ProjectElementContainer {
    internal ProjectItemDefinitionElement() { }
    public string ItemType { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
    public System.Collections.Generic.ICollection<Microsoft.Build.Construction.ProjectMetadataElement> Metadata { get { return default(System.Collections.Generic.ICollection<Microsoft.Build.Construction.ProjectMetadataElement>); } }
    public Microsoft.Build.Construction.ProjectMetadataElement AddMetadata(string name, string unevaluatedValue) { return default(Microsoft.Build.Construction.ProjectMetadataElement); }
  }
  [System.Diagnostics.DebuggerDisplayAttribute("#ItemDefinitions={Count} Condition={Condition} Label={Label}")]
  public partial class ProjectItemDefinitionGroupElement : Microsoft.Build.Construction.ProjectElementContainer {
    internal ProjectItemDefinitionGroupElement() { }
    public System.Collections.Generic.ICollection<Microsoft.Build.Construction.ProjectItemDefinitionElement> ItemDefinitions { get { return default(System.Collections.Generic.ICollection<Microsoft.Build.Construction.ProjectItemDefinitionElement>); } }
    public Microsoft.Build.Construction.ProjectItemDefinitionElement AddItemDefinition(string itemType) { return default(Microsoft.Build.Construction.ProjectItemDefinitionElement); }
  }
  [System.Diagnostics.DebuggerDisplayAttribute("{ItemType} Include={Include} Exclude={Exclude} #Metadata={Count} Condition={Condition}")]
  public partial class ProjectItemElement : Microsoft.Build.Construction.ProjectElementContainer {
    internal ProjectItemElement() { }
    public string Exclude { get { return default(string); } set { } }
    public bool HasMetadata { get { return default(bool); } }
    public string Include { get { return default(string); } set { } }
    public string ItemType { get { return default(string); } set { } }
    public System.Collections.Generic.ICollection<Microsoft.Build.Construction.ProjectMetadataElement> Metadata { get { return default(System.Collections.Generic.ICollection<Microsoft.Build.Construction.ProjectMetadataElement>); } }
    public string Remove { get { return default(string); } set { } }
    public Microsoft.Build.Construction.ProjectMetadataElement AddMetadata(string name, string unevaluatedValue) { return default(Microsoft.Build.Construction.ProjectMetadataElement); }
  }
  [System.Diagnostics.DebuggerDisplayAttribute("#Items={Count} Condition={Condition} Label={Label}")]
  public partial class ProjectItemGroupElement : Microsoft.Build.Construction.ProjectElementContainer {
    internal ProjectItemGroupElement() { }
    public System.Collections.Generic.ICollection<Microsoft.Build.Construction.ProjectItemElement> Items { get { return default(System.Collections.Generic.ICollection<Microsoft.Build.Construction.ProjectItemElement>); } }
    public Microsoft.Build.Construction.ProjectItemElement AddItem(string itemType, string include) { return default(Microsoft.Build.Construction.ProjectItemElement); }
    public Microsoft.Build.Construction.ProjectItemElement AddItem(string itemType, string include, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.String>> metadata) { return default(Microsoft.Build.Construction.ProjectItemElement); }
  }
  [System.Diagnostics.DebuggerDisplayAttribute("{Name} Value={Value} Condition={Condition}")]
  public partial class ProjectMetadataElement : Microsoft.Build.Construction.ProjectElement {
    internal ProjectMetadataElement() { }
    public string Name { get { return default(string); } set { } }
    public string Value { get { return default(string); } set { } }
  }
  [System.Diagnostics.DebuggerDisplayAttribute("ExecuteTargets={ExecuteTargets}")]
  public partial class ProjectOnErrorElement : Microsoft.Build.Construction.ProjectElement {
    internal ProjectOnErrorElement() { }
    public string ExecuteTargetsAttribute { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
  }
  [System.Diagnostics.DebuggerDisplayAttribute("#Children={Count}")]
  public partial class ProjectOtherwiseElement : Microsoft.Build.Construction.ProjectElementContainer {
    internal ProjectOtherwiseElement() { }
    public System.Collections.Generic.ICollection<Microsoft.Build.Construction.ProjectChooseElement> ChooseElements { get { return default(System.Collections.Generic.ICollection<Microsoft.Build.Construction.ProjectChooseElement>); } }
    public override string Condition { get { return default(string); } set { } }
    public System.Collections.Generic.ICollection<Microsoft.Build.Construction.ProjectItemGroupElement> ItemGroups { get { return default(System.Collections.Generic.ICollection<Microsoft.Build.Construction.ProjectItemGroupElement>); } }
    public System.Collections.Generic.ICollection<Microsoft.Build.Construction.ProjectPropertyGroupElement> PropertyGroups { get { return default(System.Collections.Generic.ICollection<Microsoft.Build.Construction.ProjectPropertyGroupElement>); } }
  }
  [System.Diagnostics.DebuggerDisplayAttribute("Name={Name} TaskParameter={TaskParameter} ItemName={ItemName} PropertyName={PropertyName} Condition={Condition}")]
  public partial class ProjectOutputElement : Microsoft.Build.Construction.ProjectElement {
    internal ProjectOutputElement() { }
    public bool IsOutputItem { get { return default(bool); } }
    public bool IsOutputProperty { get { return default(bool); } }
    public string ItemType { get { return default(string); } set { } }
    public string PropertyName { get { return default(string); } set { } }
    public string TaskParameter { get { return default(string); } set { } }
  }
  [System.Diagnostics.DebuggerDisplayAttribute("{Name} Value={Value} Condition={Condition}")]
  public partial class ProjectPropertyElement : Microsoft.Build.Construction.ProjectElement {
    internal ProjectPropertyElement() { }
    public string Name { get { return default(string); } set { } }
    public string Value { get { return default(string); } set { } }
  }
  [System.Diagnostics.DebuggerDisplayAttribute("#Properties={Count} Condition={Condition} Label={Label}")]
  public partial class ProjectPropertyGroupElement : Microsoft.Build.Construction.ProjectElementContainer {
    internal ProjectPropertyGroupElement() { }
    public System.Collections.Generic.ICollection<Microsoft.Build.Construction.ProjectPropertyElement> Properties { get { return default(System.Collections.Generic.ICollection<Microsoft.Build.Construction.ProjectPropertyElement>); } }
    public System.Collections.Generic.ICollection<Microsoft.Build.Construction.ProjectPropertyElement> PropertiesReversed { get { return default(System.Collections.Generic.ICollection<Microsoft.Build.Construction.ProjectPropertyElement>); } }
    public Microsoft.Build.Construction.ProjectPropertyElement AddProperty(string name, string unevaluatedValue) { return default(Microsoft.Build.Construction.ProjectPropertyElement); }
    public Microsoft.Build.Construction.ProjectPropertyElement SetProperty(string name, string unevaluatedValue) { return default(Microsoft.Build.Construction.ProjectPropertyElement); }
  }
  [System.Diagnostics.DebuggerDisplayAttribute("{FullPath} #Children={Count} DefaultTargets={DefaultTargets} ToolsVersion={ToolsVersion} InitialTargets={InitialTargets}")]
  public partial class ProjectRootElement : Microsoft.Build.Construction.ProjectElementContainer {
    internal ProjectRootElement() { }
    public System.Collections.Generic.ICollection<Microsoft.Build.Construction.ProjectChooseElement> ChooseElements { get { return default(System.Collections.Generic.ICollection<Microsoft.Build.Construction.ProjectChooseElement>); } }
    public override string Condition { get { return default(string); } set { } }
    public string DefaultTargets { get { return default(string); } set { } }
    public string DirectoryPath { get { return default(string); } set { } }
    public System.Text.Encoding Encoding { get { return default(System.Text.Encoding); } }
    public string FullPath { get { return default(string); } set { } }
    public bool HasUnsavedChanges { get { return default(bool); } }
    public System.Collections.Generic.ICollection<Microsoft.Build.Construction.ProjectImportGroupElement> ImportGroups { get { return default(System.Collections.Generic.ICollection<Microsoft.Build.Construction.ProjectImportGroupElement>); } }
    public System.Collections.Generic.ICollection<Microsoft.Build.Construction.ProjectImportGroupElement> ImportGroupsReversed { get { return default(System.Collections.Generic.ICollection<Microsoft.Build.Construction.ProjectImportGroupElement>); } }
    public System.Collections.Generic.ICollection<Microsoft.Build.Construction.ProjectImportElement> Imports { get { return default(System.Collections.Generic.ICollection<Microsoft.Build.Construction.ProjectImportElement>); } }
    public string InitialTargets { get { return default(string); } set { } }
    public System.Collections.Generic.ICollection<Microsoft.Build.Construction.ProjectItemDefinitionGroupElement> ItemDefinitionGroups { get { return default(System.Collections.Generic.ICollection<Microsoft.Build.Construction.ProjectItemDefinitionGroupElement>); } }
    public System.Collections.Generic.ICollection<Microsoft.Build.Construction.ProjectItemDefinitionGroupElement> ItemDefinitionGroupsReversed { get { return default(System.Collections.Generic.ICollection<Microsoft.Build.Construction.ProjectItemDefinitionGroupElement>); } }
    public System.Collections.Generic.ICollection<Microsoft.Build.Construction.ProjectItemDefinitionElement> ItemDefinitions { get { return default(System.Collections.Generic.ICollection<Microsoft.Build.Construction.ProjectItemDefinitionElement>); } }
    public System.Collections.Generic.ICollection<Microsoft.Build.Construction.ProjectItemGroupElement> ItemGroups { get { return default(System.Collections.Generic.ICollection<Microsoft.Build.Construction.ProjectItemGroupElement>); } }
    public System.Collections.Generic.ICollection<Microsoft.Build.Construction.ProjectItemGroupElement> ItemGroupsReversed { get { return default(System.Collections.Generic.ICollection<Microsoft.Build.Construction.ProjectItemGroupElement>); } }
    public System.Collections.Generic.ICollection<Microsoft.Build.Construction.ProjectItemElement> Items { get { return default(System.Collections.Generic.ICollection<Microsoft.Build.Construction.ProjectItemElement>); } }
    public System.DateTime LastWriteTimeWhenRead { get { return default(System.DateTime); } }
    public System.Collections.Generic.ICollection<Microsoft.Build.Construction.ProjectPropertyElement> Properties { get { return default(System.Collections.Generic.ICollection<Microsoft.Build.Construction.ProjectPropertyElement>); } }
    public System.Collections.Generic.ICollection<Microsoft.Build.Construction.ProjectPropertyGroupElement> PropertyGroups { get { return default(System.Collections.Generic.ICollection<Microsoft.Build.Construction.ProjectPropertyGroupElement>); } }
    public System.Collections.Generic.ICollection<Microsoft.Build.Construction.ProjectPropertyGroupElement> PropertyGroupsReversed { get { return default(System.Collections.Generic.ICollection<Microsoft.Build.Construction.ProjectPropertyGroupElement>); } }
    public string RawXml { get { return default(string); } }
    public System.Collections.Generic.ICollection<Microsoft.Build.Construction.ProjectTargetElement> Targets { get { return default(System.Collections.Generic.ICollection<Microsoft.Build.Construction.ProjectTargetElement>); } }
    public System.DateTime TimeLastChanged { get { return default(System.DateTime); } }
    public string ToolsVersion { get { return default(string); } set { } }
    public System.Collections.Generic.ICollection<Microsoft.Build.Construction.ProjectUsingTaskElement> UsingTasks { get { return default(System.Collections.Generic.ICollection<Microsoft.Build.Construction.ProjectUsingTaskElement>); } }
    public int Version { get { return default(int); } }
    public Microsoft.Build.Construction.ProjectImportElement AddImport(string project) { return default(Microsoft.Build.Construction.ProjectImportElement); }
    public Microsoft.Build.Construction.ProjectImportGroupElement AddImportGroup() { return default(Microsoft.Build.Construction.ProjectImportGroupElement); }
    public Microsoft.Build.Construction.ProjectItemElement AddItem(string itemType, string include) { return default(Microsoft.Build.Construction.ProjectItemElement); }
    public Microsoft.Build.Construction.ProjectItemElement AddItem(string itemType, string include, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.String>> metadata) { return default(Microsoft.Build.Construction.ProjectItemElement); }
    public Microsoft.Build.Construction.ProjectItemDefinitionElement AddItemDefinition(string itemType) { return default(Microsoft.Build.Construction.ProjectItemDefinitionElement); }
    public Microsoft.Build.Construction.ProjectItemDefinitionGroupElement AddItemDefinitionGroup() { return default(Microsoft.Build.Construction.ProjectItemDefinitionGroupElement); }
    public Microsoft.Build.Construction.ProjectItemGroupElement AddItemGroup() { return default(Microsoft.Build.Construction.ProjectItemGroupElement); }
    public Microsoft.Build.Construction.ProjectPropertyElement AddProperty(string name, string value) { return default(Microsoft.Build.Construction.ProjectPropertyElement); }
    public Microsoft.Build.Construction.ProjectPropertyGroupElement AddPropertyGroup() { return default(Microsoft.Build.Construction.ProjectPropertyGroupElement); }
    public Microsoft.Build.Construction.ProjectTargetElement AddTarget(string name) { return default(Microsoft.Build.Construction.ProjectTargetElement); }
    public Microsoft.Build.Construction.ProjectUsingTaskElement AddUsingTask(string name, string assemblyFile, string assemblyName) { return default(Microsoft.Build.Construction.ProjectUsingTaskElement); }
    public static Microsoft.Build.Construction.ProjectRootElement Create() { return default(Microsoft.Build.Construction.ProjectRootElement); }
    public static Microsoft.Build.Construction.ProjectRootElement Create(Microsoft.Build.Evaluation.ProjectCollection projectCollection) { return default(Microsoft.Build.Construction.ProjectRootElement); }
    public static Microsoft.Build.Construction.ProjectRootElement Create(string path) { return default(Microsoft.Build.Construction.ProjectRootElement); }
    public static Microsoft.Build.Construction.ProjectRootElement Create(string path, Microsoft.Build.Evaluation.ProjectCollection projectCollection) { return default(Microsoft.Build.Construction.ProjectRootElement); }
    public static Microsoft.Build.Construction.ProjectRootElement Create(System.Xml.XmlReader xmlReader) { return default(Microsoft.Build.Construction.ProjectRootElement); }
    public static Microsoft.Build.Construction.ProjectRootElement Create(System.Xml.XmlReader xmlReader, Microsoft.Build.Evaluation.ProjectCollection projectCollection) { return default(Microsoft.Build.Construction.ProjectRootElement); }
    public Microsoft.Build.Construction.ProjectChooseElement CreateChooseElement() { return default(Microsoft.Build.Construction.ProjectChooseElement); }
    public Microsoft.Build.Construction.ProjectImportElement CreateImportElement(string project) { return default(Microsoft.Build.Construction.ProjectImportElement); }
    public Microsoft.Build.Construction.ProjectImportGroupElement CreateImportGroupElement() { return default(Microsoft.Build.Construction.ProjectImportGroupElement); }
    public Microsoft.Build.Construction.ProjectItemDefinitionElement CreateItemDefinitionElement(string itemType) { return default(Microsoft.Build.Construction.ProjectItemDefinitionElement); }
    public Microsoft.Build.Construction.ProjectItemDefinitionGroupElement CreateItemDefinitionGroupElement() { return default(Microsoft.Build.Construction.ProjectItemDefinitionGroupElement); }
    public Microsoft.Build.Construction.ProjectItemElement CreateItemElement(string itemType) { return default(Microsoft.Build.Construction.ProjectItemElement); }
    public Microsoft.Build.Construction.ProjectItemElement CreateItemElement(string itemType, string include) { return default(Microsoft.Build.Construction.ProjectItemElement); }
    public Microsoft.Build.Construction.ProjectItemGroupElement CreateItemGroupElement() { return default(Microsoft.Build.Construction.ProjectItemGroupElement); }
    public Microsoft.Build.Construction.ProjectMetadataElement CreateMetadataElement(string name) { return default(Microsoft.Build.Construction.ProjectMetadataElement); }
    public Microsoft.Build.Construction.ProjectMetadataElement CreateMetadataElement(string name, string unevaluatedValue) { return default(Microsoft.Build.Construction.ProjectMetadataElement); }
    public Microsoft.Build.Construction.ProjectOnErrorElement CreateOnErrorElement(string executeTargets) { return default(Microsoft.Build.Construction.ProjectOnErrorElement); }
    public Microsoft.Build.Construction.ProjectOtherwiseElement CreateOtherwiseElement() { return default(Microsoft.Build.Construction.ProjectOtherwiseElement); }
    public Microsoft.Build.Construction.ProjectOutputElement CreateOutputElement(string taskParameter, string itemType, string propertyName) { return default(Microsoft.Build.Construction.ProjectOutputElement); }
    public Microsoft.Build.Construction.ProjectExtensionsElement CreateProjectExtensionsElement() { return default(Microsoft.Build.Construction.ProjectExtensionsElement); }
    public Microsoft.Build.Construction.ProjectPropertyElement CreatePropertyElement(string name) { return default(Microsoft.Build.Construction.ProjectPropertyElement); }
    public Microsoft.Build.Construction.ProjectPropertyGroupElement CreatePropertyGroupElement() { return default(Microsoft.Build.Construction.ProjectPropertyGroupElement); }
    public Microsoft.Build.Construction.ProjectTargetElement CreateTargetElement(string name) { return default(Microsoft.Build.Construction.ProjectTargetElement); }
    public Microsoft.Build.Construction.ProjectTaskElement CreateTaskElement(string name) { return default(Microsoft.Build.Construction.ProjectTaskElement); }
    public Microsoft.Build.Construction.ProjectUsingTaskBodyElement CreateUsingTaskBodyElement(string evaluate, string body) { return default(Microsoft.Build.Construction.ProjectUsingTaskBodyElement); }
    public Microsoft.Build.Construction.ProjectUsingTaskElement CreateUsingTaskElement(string taskName, string assemblyFile, string assemblyName) { return default(Microsoft.Build.Construction.ProjectUsingTaskElement); }
    public Microsoft.Build.Construction.ProjectUsingTaskParameterElement CreateUsingTaskParameterElement(string name, string output, string required, string parameterType) { return default(Microsoft.Build.Construction.ProjectUsingTaskParameterElement); }
    public Microsoft.Build.Construction.UsingTaskParameterGroupElement CreateUsingTaskParameterGroupElement() { return default(Microsoft.Build.Construction.UsingTaskParameterGroupElement); }
    public Microsoft.Build.Construction.ProjectWhenElement CreateWhenElement(string condition) { return default(Microsoft.Build.Construction.ProjectWhenElement); }
    public static Microsoft.Build.Construction.ProjectRootElement Open(string path) { return default(Microsoft.Build.Construction.ProjectRootElement); }
    public static Microsoft.Build.Construction.ProjectRootElement Open(string path, Microsoft.Build.Evaluation.ProjectCollection projectCollection) { return default(Microsoft.Build.Construction.ProjectRootElement); }
    public void Save() { }
    public void Save(System.IO.TextWriter writer) { }
    public void Save(string path) { }
    public void Save(string path, System.Text.Encoding encoding) { }
    public void Save(System.Text.Encoding saveEncoding) { }
    public static Microsoft.Build.Construction.ProjectRootElement TryOpen(string path) { return default(Microsoft.Build.Construction.ProjectRootElement); }
    public static Microsoft.Build.Construction.ProjectRootElement TryOpen(string path, Microsoft.Build.Evaluation.ProjectCollection projectCollection) { return default(Microsoft.Build.Construction.ProjectRootElement); }
  }
  [System.Diagnostics.DebuggerDisplayAttribute("Name={Name} #Children={Count} Condition={Condition}")]
  public partial class ProjectTargetElement : Microsoft.Build.Construction.ProjectElementContainer {
    internal ProjectTargetElement() { }
    public string AfterTargets { get { return default(string); } set { } }
    public string BeforeTargets { get { return default(string); } set { } }
    public string DependsOnTargets { get { return default(string); } set { } }
    public string Inputs { get { return default(string); } set { } }
    public System.Collections.Generic.ICollection<Microsoft.Build.Construction.ProjectItemGroupElement> ItemGroups { get { return default(System.Collections.Generic.ICollection<Microsoft.Build.Construction.ProjectItemGroupElement>); } }
    public string KeepDuplicateOutputs { get { return default(string); } set { } }
    public string Name { get { return default(string); } set { } }
    public System.Collections.Generic.ICollection<Microsoft.Build.Construction.ProjectOnErrorElement> OnErrors { get { return default(System.Collections.Generic.ICollection<Microsoft.Build.Construction.ProjectOnErrorElement>); } }
    public string Outputs { get { return default(string); } set { } }
    public System.Collections.Generic.ICollection<Microsoft.Build.Construction.ProjectPropertyGroupElement> PropertyGroups { get { return default(System.Collections.Generic.ICollection<Microsoft.Build.Construction.ProjectPropertyGroupElement>); } }
    public string Returns { get { return default(string); } set { } }
    public System.Collections.Generic.ICollection<Microsoft.Build.Construction.ProjectTaskElement> Tasks { get { return default(System.Collections.Generic.ICollection<Microsoft.Build.Construction.ProjectTaskElement>); } }
    public Microsoft.Build.Construction.ProjectItemGroupElement AddItemGroup() { return default(Microsoft.Build.Construction.ProjectItemGroupElement); }
    public Microsoft.Build.Construction.ProjectPropertyGroupElement AddPropertyGroup() { return default(Microsoft.Build.Construction.ProjectPropertyGroupElement); }
    public Microsoft.Build.Construction.ProjectTaskElement AddTask(string taskName) { return default(Microsoft.Build.Construction.ProjectTaskElement); }
  }
  [System.Diagnostics.DebuggerDisplayAttribute("{Name} Condition={Condition} ContinueOnError={ContinueOnError} #Outputs={Count}")]
  public partial class ProjectTaskElement : Microsoft.Build.Construction.ProjectElementContainer {
    internal ProjectTaskElement() { }
    public string ContinueOnError { get { return default(string); } set { } }
    public string ExecuteTargets { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public string Name { get { return default(string); } }
    public System.Collections.Generic.ICollection<Microsoft.Build.Construction.ProjectOutputElement> Outputs { get { return default(System.Collections.Generic.ICollection<Microsoft.Build.Construction.ProjectOutputElement>); } }
    public System.Collections.Generic.IDictionary<System.String, System.String> Parameters { get { return default(System.Collections.Generic.IDictionary<System.String, System.String>); } }
    public Microsoft.Build.Construction.ProjectOutputElement AddOutputItem(string taskParameter, string itemType) { return default(Microsoft.Build.Construction.ProjectOutputElement); }
    public Microsoft.Build.Construction.ProjectOutputElement AddOutputItem(string taskParameter, string itemType, string condition) { return default(Microsoft.Build.Construction.ProjectOutputElement); }
    public Microsoft.Build.Construction.ProjectOutputElement AddOutputProperty(string taskParameter, string propertyName) { return default(Microsoft.Build.Construction.ProjectOutputElement); }
    public Microsoft.Build.Construction.ProjectOutputElement AddOutputProperty(string taskParameter, string propertyName, string condition) { return default(Microsoft.Build.Construction.ProjectOutputElement); }
    public string GetParameter(string name) { return default(string); }
    public void RemoveAllParameters() { }
    public void RemoveParameter(string name) { }
    public void SetParameter(string name, string unevaluatedValue) { }
  }
  [System.Diagnostics.DebuggerDisplayAttribute("Evaluate={Evaluate} TaskBody={TaskBody}")]
  public partial class ProjectUsingTaskBodyElement : Microsoft.Build.Construction.ProjectElement {
    internal ProjectUsingTaskBodyElement() { }
    public override string Condition { get { return default(string); } set { } }
    public string Evaluate { get { return default(string); } set { } }
    public string TaskBody { get { return default(string); } set { } }
  }
  [System.Diagnostics.DebuggerDisplayAttribute("TaskName={TaskName} AssemblyName={AssemblyName} AssemblyFile={AssemblyFile} Condition={Condition} Runtime={RequiredRuntime} Platform={RequiredPlatform}")]
  public partial class ProjectUsingTaskElement : Microsoft.Build.Construction.ProjectElementContainer {
    internal ProjectUsingTaskElement() { }
    public string AssemblyFile { get { return default(string); } set { } }
    public string AssemblyName { get { return default(string); } set { } }
    public Microsoft.Build.Construction.UsingTaskParameterGroupElement ParameterGroup { get { return default(Microsoft.Build.Construction.UsingTaskParameterGroupElement); } }
    public Microsoft.Build.Construction.ProjectUsingTaskBodyElement TaskBody { get { return default(Microsoft.Build.Construction.ProjectUsingTaskBodyElement); } }
    public string TaskFactory { get { return default(string); } set { } }
    public string TaskName { get { return default(string); } set { } }
    public Microsoft.Build.Construction.UsingTaskParameterGroupElement AddParameterGroup() { return default(Microsoft.Build.Construction.UsingTaskParameterGroupElement); }
    public Microsoft.Build.Construction.ProjectUsingTaskBodyElement AddUsingTaskBody(string evaluate, string taskBody) { return default(Microsoft.Build.Construction.ProjectUsingTaskBodyElement); }
  }
  [System.Diagnostics.DebuggerDisplayAttribute("Name={Name} ParameterType={ParameterType} Output={Output}")]
  public partial class ProjectUsingTaskParameterElement : Microsoft.Build.Construction.ProjectElement {
    internal ProjectUsingTaskParameterElement() { }
    public override string Condition { get { return default(string); } set { } }
    public string Name { get { return default(string); } set { } }
    public string Output { get { return default(string); } set { } }
    public string ParameterType { get { return default(string); } set { } }
    public string Required { get { return default(string); } set { } }
  }
  [System.Diagnostics.DebuggerDisplayAttribute("#Children={Count} Condition={Condition}")]
  public partial class ProjectWhenElement : Microsoft.Build.Construction.ProjectElementContainer {
    internal ProjectWhenElement() { }
    public System.Collections.Generic.ICollection<Microsoft.Build.Construction.ProjectChooseElement> ChooseElements { get { return default(System.Collections.Generic.ICollection<Microsoft.Build.Construction.ProjectChooseElement>); } }
    public System.Collections.Generic.ICollection<Microsoft.Build.Construction.ProjectItemGroupElement> ItemGroups { get { return default(System.Collections.Generic.ICollection<Microsoft.Build.Construction.ProjectItemGroupElement>); } }
    public System.Collections.Generic.ICollection<Microsoft.Build.Construction.ProjectPropertyGroupElement> PropertyGroups { get { return default(System.Collections.Generic.ICollection<Microsoft.Build.Construction.ProjectPropertyGroupElement>); } }
  }
  [System.Diagnostics.DebuggerDisplayAttribute("#Parameters={Count}")]
  public partial class UsingTaskParameterGroupElement : Microsoft.Build.Construction.ProjectElementContainer {
    internal UsingTaskParameterGroupElement() { }
    public override string Condition { get { return default(string); } set { } }
    public System.Collections.Generic.ICollection<Microsoft.Build.Construction.ProjectUsingTaskParameterElement> Parameters { get { return default(System.Collections.Generic.ICollection<Microsoft.Build.Construction.ProjectUsingTaskParameterElement>); } }
    public Microsoft.Build.Construction.ProjectUsingTaskParameterElement AddParameter(string name) { return default(Microsoft.Build.Construction.ProjectUsingTaskParameterElement); }
    public Microsoft.Build.Construction.ProjectUsingTaskParameterElement AddParameter(string name, string output, string required, string parameterType) { return default(Microsoft.Build.Construction.ProjectUsingTaskParameterElement); }
  }
}
namespace Microsoft.Build.Evaluation {
  [System.Diagnostics.DebuggerDisplayAttribute("{FullPath} EffectiveToolsVersion={ToolsVersion} #GlobalProperties={data.globalProperties.Count} #Properties={data.Properties.Count} #ItemTypes={data.ItemTypes.Count} #ItemDefinitions={data.ItemDefinitions.Count} #Items={data.Items.Count} #Targets={data.Targets.Count}")]
  public partial class Project {
    public Project(Microsoft.Build.Construction.ProjectRootElement xml) { }
    public Project(Microsoft.Build.Construction.ProjectRootElement xml, System.Collections.Generic.IDictionary<System.String, System.String> globalProperties, string toolsVersion) { }
    public Project(Microsoft.Build.Construction.ProjectRootElement xml, System.Collections.Generic.IDictionary<System.String, System.String> globalProperties, string toolsVersion, Microsoft.Build.Evaluation.ProjectCollection projectCollection) { }
    public Project(Microsoft.Build.Construction.ProjectRootElement xml, System.Collections.Generic.IDictionary<System.String, System.String> globalProperties, string toolsVersion, Microsoft.Build.Evaluation.ProjectCollection projectCollection, Microsoft.Build.Evaluation.ProjectLoadSettings loadSettings) { }
    public Project(string projectFile) { }
    public Project(string projectFile, System.Collections.Generic.IDictionary<System.String, System.String> globalProperties, string toolsVersion) { }
    public Project(string projectFile, System.Collections.Generic.IDictionary<System.String, System.String> globalProperties, string toolsVersion, Microsoft.Build.Evaluation.ProjectCollection projectCollection) { }
    public Project(string projectFile, System.Collections.Generic.IDictionary<System.String, System.String> globalProperties, string toolsVersion, Microsoft.Build.Evaluation.ProjectCollection projectCollection, Microsoft.Build.Evaluation.ProjectLoadSettings loadSettings) { }
    public Project(System.Xml.XmlReader xml) { }
    public Project(System.Xml.XmlReader xml, System.Collections.Generic.IDictionary<System.String, System.String> globalProperties, string toolsVersion) { }
    public Project(System.Xml.XmlReader xml, System.Collections.Generic.IDictionary<System.String, System.String> globalProperties, string toolsVersion, Microsoft.Build.Evaluation.ProjectCollection projectCollection) { }
    public Project(System.Xml.XmlReader xml, System.Collections.Generic.IDictionary<System.String, System.String> globalProperties, string toolsVersion, Microsoft.Build.Evaluation.ProjectCollection projectCollection, Microsoft.Build.Evaluation.ProjectLoadSettings loadSettings) { }
    public System.Collections.Generic.ICollection<Microsoft.Build.Evaluation.ProjectMetadata> AllEvaluatedItemDefinitionMetadata { get { return default(System.Collections.Generic.ICollection<Microsoft.Build.Evaluation.ProjectMetadata>); } }
    public System.Collections.Generic.ICollection<Microsoft.Build.Evaluation.ProjectItem> AllEvaluatedItems { get { return default(System.Collections.Generic.ICollection<Microsoft.Build.Evaluation.ProjectItem>); } }
    public System.Collections.Generic.ICollection<Microsoft.Build.Evaluation.ProjectProperty> AllEvaluatedProperties { get { return default(System.Collections.Generic.ICollection<Microsoft.Build.Evaluation.ProjectProperty>); } }
    public System.Collections.Generic.IDictionary<System.String, System.Collections.Generic.List<System.String>> ConditionedProperties { get { return default(System.Collections.Generic.IDictionary<System.String, System.Collections.Generic.List<System.String>>); } }
    public string DirectoryPath { get { return default(string); } }
    public bool DisableMarkDirty { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public int EvaluationCounter { get { return default(int); } }
    public string FullPath { get { return default(string); } set { } }
    public System.Collections.Generic.IDictionary<System.String, System.String> GlobalProperties { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Collections.Generic.IDictionary<System.String, System.String>); } }
    public System.Collections.Generic.IList<Microsoft.Build.Evaluation.ResolvedImport> Imports { get { return default(System.Collections.Generic.IList<Microsoft.Build.Evaluation.ResolvedImport>); } }
    public System.Collections.Generic.IList<Microsoft.Build.Evaluation.ResolvedImport> ImportsIncludingDuplicates { get { return default(System.Collections.Generic.IList<Microsoft.Build.Evaluation.ResolvedImport>); } }
    public bool IsBuildEnabled { get { return default(bool); } }
    public bool IsDirty { get { return default(bool); } }
    public System.Collections.Generic.IDictionary<System.String, Microsoft.Build.Evaluation.ProjectItemDefinition> ItemDefinitions { get { return default(System.Collections.Generic.IDictionary<System.String, Microsoft.Build.Evaluation.ProjectItemDefinition>); } }
    [System.MonoTODOAttribute("should be different from AllEvaluatedItems")]
    public System.Collections.Generic.ICollection<Microsoft.Build.Evaluation.ProjectItem> Items { get { return default(System.Collections.Generic.ICollection<Microsoft.Build.Evaluation.ProjectItem>); } }
    public System.Collections.Generic.ICollection<Microsoft.Build.Evaluation.ProjectItem> ItemsIgnoringCondition { get { return default(System.Collections.Generic.ICollection<Microsoft.Build.Evaluation.ProjectItem>); } }
    public System.Collections.Generic.ICollection<System.String> ItemTypes { get { return default(System.Collections.Generic.ICollection<System.String>); } }
    public Microsoft.Build.Evaluation.ProjectCollection ProjectCollection { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(Microsoft.Build.Evaluation.ProjectCollection); } }
    [System.MonoTODOAttribute("should be different from AllEvaluatedProperties")]
    public System.Collections.Generic.ICollection<Microsoft.Build.Evaluation.ProjectProperty> Properties { get { return default(System.Collections.Generic.ICollection<Microsoft.Build.Evaluation.ProjectProperty>); } }
    public bool SkipEvaluation { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public string ToolsVersion { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
    public Microsoft.Build.Construction.ProjectRootElement Xml { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(Microsoft.Build.Construction.ProjectRootElement); } }
    public System.Collections.Generic.IList<Microsoft.Build.Evaluation.ProjectItem> AddItem(string itemType, string unevaluatedInclude) { return default(System.Collections.Generic.IList<Microsoft.Build.Evaluation.ProjectItem>); }
    public System.Collections.Generic.IList<Microsoft.Build.Evaluation.ProjectItem> AddItem(string itemType, string unevaluatedInclude, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.String>> metadata) { return default(System.Collections.Generic.IList<Microsoft.Build.Evaluation.ProjectItem>); }
    public System.Collections.Generic.IList<Microsoft.Build.Evaluation.ProjectItem> AddItemFast(string itemType, string unevaluatedInclude) { return default(System.Collections.Generic.IList<Microsoft.Build.Evaluation.ProjectItem>); }
    public System.Collections.Generic.IList<Microsoft.Build.Evaluation.ProjectItem> AddItemFast(string itemType, string unevaluatedInclude, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.String>> metadata) { return default(System.Collections.Generic.IList<Microsoft.Build.Evaluation.ProjectItem>); }
    public bool Build() { return default(bool); }
    public bool Build(Microsoft.Build.Framework.ILogger logger) { return default(bool); }
    public bool Build(System.Collections.Generic.IEnumerable<Microsoft.Build.Framework.ILogger> loggers) { return default(bool); }
    public bool Build(System.Collections.Generic.IEnumerable<Microsoft.Build.Framework.ILogger> loggers, System.Collections.Generic.IEnumerable<Microsoft.Build.Logging.ForwardingLoggerRecord> remoteLoggers) { return default(bool); }
    public bool Build(string target) { return default(bool); }
    public bool Build(string target, System.Collections.Generic.IEnumerable<Microsoft.Build.Framework.ILogger> loggers) { return default(bool); }
    public bool Build(string target, System.Collections.Generic.IEnumerable<Microsoft.Build.Framework.ILogger> loggers, System.Collections.Generic.IEnumerable<Microsoft.Build.Logging.ForwardingLoggerRecord> remoteLoggers) { return default(bool); }
    public bool Build(System.String[] targets) { return default(bool); }
    public bool Build(System.String[] targets, System.Collections.Generic.IEnumerable<Microsoft.Build.Framework.ILogger> loggers) { return default(bool); }
    public bool Build(System.String[] targets, System.Collections.Generic.IEnumerable<Microsoft.Build.Framework.ILogger> loggers, System.Collections.Generic.IEnumerable<Microsoft.Build.Logging.ForwardingLoggerRecord> remoteLoggers) { return default(bool); }
    public Microsoft.Build.Execution.ProjectInstance CreateProjectInstance() { return default(Microsoft.Build.Execution.ProjectInstance); }
    public string ExpandString(string unexpandedValue) { return default(string); }
    public static string GetEvaluatedItemIncludeEscaped(Microsoft.Build.Evaluation.ProjectItem item) { return default(string); }
    public static string GetEvaluatedItemIncludeEscaped(Microsoft.Build.Evaluation.ProjectItemDefinition item) { return default(string); }
    public System.Collections.Generic.ICollection<Microsoft.Build.Evaluation.ProjectItem> GetItems(string itemType) { return default(System.Collections.Generic.ICollection<Microsoft.Build.Evaluation.ProjectItem>); }
    public System.Collections.Generic.ICollection<Microsoft.Build.Evaluation.ProjectItem> GetItemsByEvaluatedInclude(string evaluatedInclude) { return default(System.Collections.Generic.ICollection<Microsoft.Build.Evaluation.ProjectItem>); }
    public System.Collections.Generic.ICollection<Microsoft.Build.Evaluation.ProjectItem> GetItemsIgnoringCondition(string itemType) { return default(System.Collections.Generic.ICollection<Microsoft.Build.Evaluation.ProjectItem>); }
    public System.Collections.Generic.IEnumerable<Microsoft.Build.Construction.ProjectElement> GetLogicalProject() { return default(System.Collections.Generic.IEnumerable<Microsoft.Build.Construction.ProjectElement>); }
    public static string GetMetadataValueEscaped(Microsoft.Build.Evaluation.ProjectItem item, string name) { return default(string); }
    public static string GetMetadataValueEscaped(Microsoft.Build.Evaluation.ProjectItemDefinition item, string name) { return default(string); }
    public static string GetMetadataValueEscaped(Microsoft.Build.Evaluation.ProjectMetadata metadatum) { return default(string); }
    public Microsoft.Build.Evaluation.ProjectProperty GetProperty(string name) { return default(Microsoft.Build.Evaluation.ProjectProperty); }
    public string GetPropertyValue(string name) { return default(string); }
    public static string GetPropertyValueEscaped(Microsoft.Build.Evaluation.ProjectProperty property) { return default(string); }
    public void MarkDirty() { }
    public void ReevaluateIfNecessary() { }
    public bool RemoveGlobalProperty(string name) { return default(bool); }
    public bool RemoveItem(Microsoft.Build.Evaluation.ProjectItem item) { return default(bool); }
    public void RemoveItems(System.Collections.Generic.IEnumerable<Microsoft.Build.Evaluation.ProjectItem> items) { }
    public bool RemoveProperty(Microsoft.Build.Evaluation.ProjectProperty property) { return default(bool); }
    public void Save() { }
    public void Save(System.IO.TextWriter writer) { }
    public void Save(string path) { }
    public void Save(string path, System.Text.Encoding encoding) { }
    public void Save(System.Text.Encoding encoding) { }
    public void SaveLogicalProject(System.IO.TextWriter writer) { }
    public bool SetGlobalProperty(string name, string escapedValue) { return default(bool); }
    public Microsoft.Build.Evaluation.ProjectProperty SetProperty(string name, string unevaluatedValue) { return default(Microsoft.Build.Evaluation.ProjectProperty); }
  }
  public partial class ProjectChangedEventArgs : System.EventArgs {
    internal ProjectChangedEventArgs() { }
    public Microsoft.Build.Evaluation.Project Project { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(Microsoft.Build.Evaluation.Project); } }
  }
  public partial class ProjectCollection : System.IDisposable {
    public ProjectCollection() { }
    public ProjectCollection(Microsoft.Build.Evaluation.ToolsetDefinitionLocations toolsetDefinitionLocations) { }
    public ProjectCollection(System.Collections.Generic.IDictionary<System.String, System.String> globalProperties) { }
    public ProjectCollection(System.Collections.Generic.IDictionary<System.String, System.String> globalProperties, System.Collections.Generic.IEnumerable<Microsoft.Build.Framework.ILogger> loggers, Microsoft.Build.Evaluation.ToolsetDefinitionLocations toolsetDefinitionLocations) { }
    public ProjectCollection(System.Collections.Generic.IDictionary<System.String, System.String> globalProperties, System.Collections.Generic.IEnumerable<Microsoft.Build.Framework.ILogger> loggers, System.Collections.Generic.IEnumerable<Microsoft.Build.Logging.ForwardingLoggerRecord> remoteLoggers, Microsoft.Build.Evaluation.ToolsetDefinitionLocations toolsetDefinitionLocations, int maxNodeCount, bool onlyLogCriticalEvents) { }
    public int Count { get { return default(int); } }
    public string DefaultToolsVersion { get { return default(string); } set { } }
    [System.MonoTODOAttribute]
    public bool DisableMarkDirty { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public static Microsoft.Build.Evaluation.ProjectCollection GlobalProjectCollection { get { return default(Microsoft.Build.Evaluation.ProjectCollection); } }
    public System.Collections.Generic.IDictionary<System.String, System.String> GlobalProperties { get { return default(System.Collections.Generic.IDictionary<System.String, System.String>); } }
    [System.MonoTODOAttribute]
    public Microsoft.Build.Execution.HostServices HostServices { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(Microsoft.Build.Execution.HostServices); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.MonoTODOAttribute]
    public bool IsBuildEnabled { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Collections.Generic.ICollection<Microsoft.Build.Evaluation.Project> LoadedProjects { get { return default(System.Collections.Generic.ICollection<Microsoft.Build.Evaluation.Project>); } }
    public System.Collections.Generic.ICollection<Microsoft.Build.Framework.ILogger> Loggers { get { return default(System.Collections.Generic.ICollection<Microsoft.Build.Framework.ILogger>); } }
    [System.MonoTODOAttribute]
    public bool OnlyLogCriticalEvents { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.MonoTODOAttribute]
    public bool SkipEvaluation { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public Microsoft.Build.Evaluation.ToolsetDefinitionLocations ToolsetLocations { get { return default(Microsoft.Build.Evaluation.ToolsetDefinitionLocations); } }
    public System.Collections.Generic.ICollection<Microsoft.Build.Evaluation.Toolset> Toolsets { get { return default(System.Collections.Generic.ICollection<Microsoft.Build.Evaluation.Toolset>); } }
    public static System.Version Version { get { return default(System.Version); } }
    [System.MonoTODOAttribute("not fired yet")]
    public event Microsoft.Build.Evaluation.ProjectCollection.ProjectAddedEventHandler ProjectAdded { add { } remove { } }
    [System.MonoTODOAttribute("not fired yet")]
    public event System.EventHandler<Microsoft.Build.Evaluation.ProjectChangedEventArgs> ProjectChanged { add { } remove { } }
    [System.MonoTODOAttribute("not fired yet")]
    public event System.EventHandler<Microsoft.Build.Evaluation.ProjectCollectionChangedEventArgs> ProjectCollectionChanged { add { } remove { } }
    [System.MonoTODOAttribute("not fired yet")]
    public event System.EventHandler<Microsoft.Build.Evaluation.ProjectXmlChangedEventArgs> ProjectXmlChanged { add { } remove { } }
    public void AddProject(Microsoft.Build.Evaluation.Project project) { }
    [System.MonoTODOAttribute("not verified at all")]
    public void AddToolset(Microsoft.Build.Evaluation.Toolset toolset) { }
    public void Dispose() { }
    protected virtual void Dispose(bool disposing) { }
    public static string Escape(string unescapedString) { return default(string); }
    public System.Collections.Generic.ICollection<Microsoft.Build.Evaluation.Project> GetLoadedProjects(string fullPath) { return default(System.Collections.Generic.ICollection<Microsoft.Build.Evaluation.Project>); }
    public Microsoft.Build.Evaluation.Toolset GetToolset(string toolsVersion) { return default(Microsoft.Build.Evaluation.Toolset); }
    public Microsoft.Build.Evaluation.Project LoadProject(string fileName) { return default(Microsoft.Build.Evaluation.Project); }
    public Microsoft.Build.Evaluation.Project LoadProject(string fileName, System.Collections.Generic.IDictionary<System.String, System.String> globalProperties, string toolsVersion) { return default(Microsoft.Build.Evaluation.Project); }
    public Microsoft.Build.Evaluation.Project LoadProject(string fileName, string toolsVersion) { return default(Microsoft.Build.Evaluation.Project); }
    public Microsoft.Build.Evaluation.Project LoadProject(System.Xml.XmlReader xmlReader) { return default(Microsoft.Build.Evaluation.Project); }
    public Microsoft.Build.Evaluation.Project LoadProject(System.Xml.XmlReader xmlReader, System.Collections.Generic.IDictionary<System.String, System.String> globalProperties, string toolsVersion) { return default(Microsoft.Build.Evaluation.Project); }
    public Microsoft.Build.Evaluation.Project LoadProject(System.Xml.XmlReader xmlReader, string toolsVersion) { return default(Microsoft.Build.Evaluation.Project); }
    public void RegisterLogger(Microsoft.Build.Framework.ILogger logger) { }
    public void RegisterLoggers(System.Collections.Generic.IEnumerable<Microsoft.Build.Framework.ILogger> loggers) { }
    [System.MonoTODOAttribute("not verified at all")]
    public void RemoveAllToolsets() { }
    public static string Unescape(string escapedString) { return default(string); }
    public void UnloadAllProjects() { }
    [System.MonoTODOAttribute("Not verified at all")]
    public void UnloadProject(Microsoft.Build.Construction.ProjectRootElement projectRootElement) { }
    [System.MonoTODOAttribute("Not verified at all")]
    public void UnloadProject(Microsoft.Build.Evaluation.Project project) { }
    public delegate void ProjectAddedEventHandler(object target, Microsoft.Build.Evaluation.ProjectCollection.ProjectAddedToProjectCollectionEventArgs args);
    public partial class ProjectAddedToProjectCollectionEventArgs : System.EventArgs {
      public ProjectAddedToProjectCollectionEventArgs(Microsoft.Build.Construction.ProjectRootElement project) { }
      public Microsoft.Build.Construction.ProjectRootElement ProjectRootElement { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(Microsoft.Build.Construction.ProjectRootElement); } }
    }
  }
  public partial class ProjectCollectionChangedEventArgs : System.EventArgs {
    public ProjectCollectionChangedEventArgs(Microsoft.Build.Evaluation.ProjectCollectionChangedState state) { }
    public Microsoft.Build.Evaluation.ProjectCollectionChangedState State { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(Microsoft.Build.Evaluation.ProjectCollectionChangedState); } }
  }
  public enum ProjectCollectionChangedState {
    DefaultToolsVersion = 0,
    DisableMarkDirty = 1,
    GlobalProperties = 2,
    HostServices = 3,
    IsBuildEnabled = 4,
    Loggers = 5,
    OnlyLogCriticalEvents = 6,
    SkipEvaluation = 7,
    Toolsets = 8,
  }
  [System.Diagnostics.DebuggerDisplayAttribute("{ItemType}={EvaluatedInclude} [{UnevaluatedInclude}] #DirectMetadata={DirectMetadataCount}")]
  public partial class ProjectItem {
    internal ProjectItem() { }
    public System.Collections.Generic.IEnumerable<Microsoft.Build.Evaluation.ProjectMetadata> DirectMetadata { get { return default(System.Collections.Generic.IEnumerable<Microsoft.Build.Evaluation.ProjectMetadata>); } }
    public int DirectMetadataCount { get { return default(int); } }
    public string EvaluatedInclude { get { return default(string); } }
    public bool IsImported { get { return default(bool); } }
    public string ItemType { get { return default(string); } set { } }
    public System.Collections.Generic.ICollection<Microsoft.Build.Evaluation.ProjectMetadata> Metadata { get { return default(System.Collections.Generic.ICollection<Microsoft.Build.Evaluation.ProjectMetadata>); } }
    public int MetadataCount { get { return default(int); } }
    public Microsoft.Build.Evaluation.Project Project { get { return default(Microsoft.Build.Evaluation.Project); } }
    public string UnevaluatedInclude { get { return default(string); } set { } }
    public Microsoft.Build.Construction.ProjectItemElement Xml { get { return default(Microsoft.Build.Construction.ProjectItemElement); } }
    public Microsoft.Build.Evaluation.ProjectMetadata GetMetadata(string name) { return default(Microsoft.Build.Evaluation.ProjectMetadata); }
    public string GetMetadataValue(string name) { return default(string); }
    public bool HasMetadata(string name) { return default(bool); }
    public bool RemoveMetadata(string name) { return default(bool); }
    public void Rename(string name) { }
    public Microsoft.Build.Evaluation.ProjectMetadata SetMetadataValue(string name, string unevaluatedValue) { return default(Microsoft.Build.Evaluation.ProjectMetadata); }
  }
  public partial class ProjectItemDefinition {
    internal ProjectItemDefinition() { }
    public string ItemType { get { return default(string); } }
    public System.Collections.Generic.IEnumerable<Microsoft.Build.Evaluation.ProjectMetadata> Metadata { get { return default(System.Collections.Generic.IEnumerable<Microsoft.Build.Evaluation.ProjectMetadata>); } }
    public int MetadataCount { get { return default(int); } }
    public Microsoft.Build.Evaluation.Project Project { get { return default(Microsoft.Build.Evaluation.Project); } }
  }
  [System.FlagsAttribute]
  public enum ProjectLoadSettings {
    Default = 0,
    IgnoreMissingImports = 1,
    RecordDuplicateButNotCircularImports = 2,
    RejectCircularImports = 4,
  }
  public partial class ProjectMetadata {
    internal ProjectMetadata() { }
    public string EvaluatedValue { get { return default(string); } }
    public bool IsImported { get { return default(bool); } }
    public string ItemType { get { return default(string); } }
    public string Name { get { return default(string); } }
    public Microsoft.Build.Evaluation.ProjectMetadata Predecessor { get { return default(Microsoft.Build.Evaluation.ProjectMetadata); } }
    public Microsoft.Build.Evaluation.Project Project { get { return default(Microsoft.Build.Evaluation.Project); } }
    public string UnevaluatedValue { get { return default(string); } }
    public Microsoft.Build.Construction.ProjectMetadataElement Xml { get { return default(Microsoft.Build.Construction.ProjectMetadataElement); } }
  }
  public abstract partial class ProjectProperty {
    internal ProjectProperty() { }
    public string EvaluatedValue { get { return default(string); } }
    public abstract bool IsEnvironmentProperty { get; }
    public abstract bool IsGlobalProperty { get; }
    [System.MonoTODOAttribute]
    public abstract bool IsImported { get; }
    public abstract bool IsReservedProperty { get; }
    public abstract string Name { get; }
    public abstract Microsoft.Build.Evaluation.ProjectProperty Predecessor { get; }
    public Microsoft.Build.Evaluation.Project Project { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(Microsoft.Build.Evaluation.Project); } }
    public abstract string UnevaluatedValue { get; set; }
    public abstract Microsoft.Build.Construction.ProjectPropertyElement Xml { get; }
  }
  public partial class ProjectXmlChangedEventArgs : System.EventArgs {
    internal ProjectXmlChangedEventArgs() { }
    public Microsoft.Build.Construction.ProjectRootElement ProjectXml { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(Microsoft.Build.Construction.ProjectRootElement); } }
    public string Reason { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct ResolvedImport {
    public Microsoft.Build.Construction.ProjectRootElement ImportedProject { get { return default(Microsoft.Build.Construction.ProjectRootElement); } }
    public Microsoft.Build.Construction.ProjectImportElement ImportingElement { get { return default(Microsoft.Build.Construction.ProjectImportElement); } }
    public bool IsImported { get { return default(bool); } }
  }
  public partial class Toolset {
    public Toolset(string toolsVersion, string toolsPath, Microsoft.Build.Evaluation.ProjectCollection projectCollection, string msbuildOverrideTasksPath) { }
    public Toolset(string toolsVersion, string toolsPath, System.Collections.Generic.IDictionary<System.String, System.String> buildProperties, Microsoft.Build.Evaluation.ProjectCollection projectCollection, string msbuildOverrideTasksPath) { }
    public System.Collections.Generic.IDictionary<System.String, Microsoft.Build.Execution.ProjectPropertyInstance> Properties { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Collections.Generic.IDictionary<System.String, Microsoft.Build.Execution.ProjectPropertyInstance>); } }
    public string ToolsPath { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
    public string ToolsVersion { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
  }
  [System.FlagsAttribute]
  public enum ToolsetDefinitionLocations {
    ConfigurationFile = 1,
    None = 0,
    Registry = 2,
  }
}
namespace Microsoft.Build.Exceptions {
  public partial class BuildAbortedException : System.Exception {
    public BuildAbortedException() { }
    protected BuildAbortedException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public BuildAbortedException(string message) { }
    public BuildAbortedException(string message, System.Exception innerException) { }
    public string ErrorCode { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
    public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
  }
  public partial class InternalLoggerException : System.Exception {
    public InternalLoggerException() { }
    public InternalLoggerException(string message) { }
    public InternalLoggerException(string message, System.Exception innerException) { }
    public Microsoft.Build.Framework.BuildEventArgs BuildEventArgs { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(Microsoft.Build.Framework.BuildEventArgs); } }
    public string ErrorCode { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
    public string HelpKeyword { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
    public bool InitializationException { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } }
    public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
  }
  public sealed partial class InvalidProjectFileException : System.Exception {
    public InvalidProjectFileException() { }
    public InvalidProjectFileException(string message) { }
    public InvalidProjectFileException(string message, System.Exception innerException) { }
    public InvalidProjectFileException(string projectFile, int lineNumber, int columnNumber, int endLineNumber, int endColumnNumber, string message, string errorSubcategory, string errorCode, string helpKeyword) { }
    public string BaseMessage { get { return default(string); } }
    public int ColumnNumber { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(int); } }
    public int EndColumnNumber { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(int); } }
    public int EndLineNumber { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(int); } }
    public string ErrorCode { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
    public string ErrorSubcategory { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
    public bool HasBeenLogged { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } }
    public string HelpKeyword { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
    public int LineNumber { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(int); } }
    public override string Message { get { return default(string); } }
    public string ProjectFile { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
    public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
  }
  public partial class InvalidToolsetDefinitionException : System.Exception {
    public InvalidToolsetDefinitionException() { }
    protected InvalidToolsetDefinitionException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public InvalidToolsetDefinitionException(string message) { }
    public InvalidToolsetDefinitionException(string message, System.Exception innerException) { }
    public string ErrorCode { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
    public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
  }
}
namespace Microsoft.Build.Execution {
  public partial class BuildManager {
    public BuildManager() { }
    public BuildManager(string hostName) { }
    public static Microsoft.Build.Execution.BuildManager DefaultBuildManager { get { return default(Microsoft.Build.Execution.BuildManager); } }
    public void BeginBuild(Microsoft.Build.Execution.BuildParameters parameters) { }
    public Microsoft.Build.Execution.BuildResult Build(Microsoft.Build.Execution.BuildParameters parameters, Microsoft.Build.Execution.BuildRequestData requestData) { return default(Microsoft.Build.Execution.BuildResult); }
    public Microsoft.Build.Execution.BuildResult BuildRequest(Microsoft.Build.Execution.BuildRequestData requestData) { return default(Microsoft.Build.Execution.BuildResult); }
    public void CancelAllSubmissions() { }
    public void Dispose() { }
    public void EndBuild() { }
    ~BuildManager() { }
    public Microsoft.Build.Execution.ProjectInstance GetProjectInstanceForBuild(Microsoft.Build.Evaluation.Project project) { return default(Microsoft.Build.Execution.ProjectInstance); }
    public Microsoft.Build.Execution.BuildSubmission PendBuildRequest(Microsoft.Build.Execution.BuildRequestData requestData) { return default(Microsoft.Build.Execution.BuildSubmission); }
    public void ResetCaches() { }
  }
  public partial class BuildParameters {
    public BuildParameters() { }
    public BuildParameters(Microsoft.Build.Evaluation.ProjectCollection projectCollection) { }
    [System.MonoTODOAttribute]
    public System.Threading.ThreadPriority BuildThreadPriority { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Threading.ThreadPriority); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.MonoTODOAttribute]
    public System.Globalization.CultureInfo Culture { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Globalization.CultureInfo); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public string DefaultToolsVersion { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.MonoTODOAttribute]
    public bool DetailedSummary { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public bool EnableNodeReuse { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.MonoTODOAttribute]
    public System.Collections.Generic.IDictionary<System.String, System.String> EnvironmentProperties { get { return default(System.Collections.Generic.IDictionary<System.String, System.String>); } }
    [System.MonoTODOAttribute]
    public System.Collections.Generic.IEnumerable<Microsoft.Build.Logging.ForwardingLoggerRecord> ForwardingLoggers { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Collections.Generic.IEnumerable<Microsoft.Build.Logging.ForwardingLoggerRecord>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.MonoTODOAttribute]
    public System.Collections.Generic.IDictionary<System.String, System.String> GlobalProperties { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Collections.Generic.IDictionary<System.String, System.String>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public Microsoft.Build.Execution.HostServices HostServices { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(Microsoft.Build.Execution.HostServices); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.MonoTODOAttribute]
    public bool LegacyThreadingSemantics { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.MonoTODOAttribute]
    public System.Collections.Generic.IEnumerable<Microsoft.Build.Framework.ILogger> Loggers { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Collections.Generic.IEnumerable<Microsoft.Build.Framework.ILogger>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.MonoTODOAttribute]
    public int MaxNodeCount { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(int); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.MonoTODOAttribute]
    public int MemoryUseLimit { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(int); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.MonoTODOAttribute]
    public string NodeExeLocation { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.MonoTODOAttribute]
    public bool OnlyLogCriticalEvents { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.MonoTODOAttribute]
    public bool ResetCaches { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.MonoTODOAttribute]
    public bool SaveOperatingEnvironment { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.MonoTODOAttribute]
    public Microsoft.Build.Evaluation.ToolsetDefinitionLocations ToolsetDefinitionLocations { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(Microsoft.Build.Evaluation.ToolsetDefinitionLocations); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.MonoTODOAttribute]
    public System.Collections.Generic.ICollection<Microsoft.Build.Evaluation.Toolset> Toolsets { get { return default(System.Collections.Generic.ICollection<Microsoft.Build.Evaluation.Toolset>); } }
    [System.MonoTODOAttribute]
    public System.Globalization.CultureInfo UICulture { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Globalization.CultureInfo); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.MonoTODOAttribute]
    public bool UseSynchronousLogging { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public Microsoft.Build.Execution.BuildParameters Clone() { return default(Microsoft.Build.Execution.BuildParameters); }
    public Microsoft.Build.Evaluation.Toolset GetToolset(string toolsVersion) { return default(Microsoft.Build.Evaluation.Toolset); }
  }
  public partial class BuildRequestData {
    public BuildRequestData(Microsoft.Build.Execution.ProjectInstance projectInstance, System.String[] targetsToBuild) { }
    public BuildRequestData(Microsoft.Build.Execution.ProjectInstance projectInstance, System.String[] targetsToBuild, Microsoft.Build.Execution.HostServices hostServices) { }
    public BuildRequestData(Microsoft.Build.Execution.ProjectInstance projectInstance, System.String[] targetsToBuild, Microsoft.Build.Execution.HostServices hostServices, Microsoft.Build.Execution.BuildRequestDataFlags flags) { }
    public BuildRequestData(string projectFullPath, System.Collections.Generic.IDictionary<System.String, System.String> globalProperties, string toolsVersion, System.String[] targetsToBuild, Microsoft.Build.Execution.HostServices hostServices) { }
    public BuildRequestData(string projectFullPath, System.Collections.Generic.IDictionary<System.String, System.String> globalProperties, string toolsVersion, System.String[] targetsToBuild, Microsoft.Build.Execution.HostServices hostServices, Microsoft.Build.Execution.BuildRequestDataFlags flags) { }
    public string ExplicitlySpecifiedToolsVersion { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
    [System.MonoTODOAttribute("unused")]
    public Microsoft.Build.Execution.BuildRequestDataFlags Flags { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(Microsoft.Build.Execution.BuildRequestDataFlags); } }
    [System.MonoTODOAttribute("unused")]
    public Microsoft.Build.Execution.HostServices HostServices { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(Microsoft.Build.Execution.HostServices); } }
    public string ProjectFullPath { get { return default(string); } }
    [System.MonoTODOAttribute("unused")]
    public Microsoft.Build.Execution.ProjectInstance ProjectInstance { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(Microsoft.Build.Execution.ProjectInstance); } }
    [System.MonoTODOAttribute]
    public System.Collections.Generic.IEnumerable<System.String> PropertiesToTransfer { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Collections.Generic.IEnumerable<System.String>); } }
    [System.MonoTODOAttribute]
    public System.Collections.Generic.ICollection<System.String> TargetNames { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Collections.Generic.ICollection<System.String>); } }
  }
  [System.FlagsAttribute]
  public enum BuildRequestDataFlags {
    None = 0,
    ReplaceExistingProjectInstance = 1,
  }
  public partial class BuildResult {
    public BuildResult() { }
    public bool CircularDependency { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } }
    public int ConfigurationId { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(int); } }
    public System.Exception Exception { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Exception); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public int GlobalRequestId { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(int); } }
    public Microsoft.Build.Execution.ITargetResult this[string target] { get { return default(Microsoft.Build.Execution.ITargetResult); } }
    public int NodeRequestId { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(int); } }
    public Microsoft.Build.Execution.BuildResultCode OverallResult { get { return default(Microsoft.Build.Execution.BuildResultCode); } }
    public int ParentGlobalRequestId { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(int); } }
    public System.Collections.Generic.IDictionary<System.String, Microsoft.Build.Execution.TargetResult> ResultsByTarget { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Collections.Generic.IDictionary<System.String, Microsoft.Build.Execution.TargetResult>); } }
    public int SubmissionId { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(int); } }
    public void AddResultsForTarget(string target, Microsoft.Build.Execution.TargetResult result) { }
    public bool HasResultsForTarget(string target) { return default(bool); }
    public void MergeResults(Microsoft.Build.Execution.BuildResult results) { }
  }
  public enum BuildResultCode {
    Failure = 1,
    Success = 0,
  }
  public partial class BuildSubmission {
    internal BuildSubmission() { }
    public object AsyncContext { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(object); } }
    public Microsoft.Build.Execution.BuildManager BuildManager { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(Microsoft.Build.Execution.BuildManager); } }
    public Microsoft.Build.Execution.BuildResult BuildResult { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(Microsoft.Build.Execution.BuildResult); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public bool IsCompleted { get { return default(bool); } }
    public int SubmissionId { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(int); } }
    public System.Threading.WaitHandle WaitHandle { get { return default(System.Threading.WaitHandle); } }
    public Microsoft.Build.Execution.BuildResult Execute() { return default(Microsoft.Build.Execution.BuildResult); }
    public void ExecuteAsync(Microsoft.Build.Execution.BuildSubmissionCompleteCallback callback, object context) { }
  }
  public delegate void BuildSubmissionCompleteCallback(Microsoft.Build.Execution.BuildSubmission submission);
  public partial class HostServices {
    public HostServices() { }
    public Microsoft.Build.Framework.ITaskHost GetHostObject(string projectFile, string targetName, string taskName) { return default(Microsoft.Build.Framework.ITaskHost); }
    public Microsoft.Build.Execution.NodeAffinity GetNodeAffinity(string projectFile) { return default(Microsoft.Build.Execution.NodeAffinity); }
    public void OnRenameProject(string oldFullPath, string newFullPath) { }
    public void RegisterHostObject(string projectFile, string targetName, string taskName, Microsoft.Build.Framework.ITaskHost hostObject) { }
    public void SetNodeAffinity(string projectFile, Microsoft.Build.Execution.NodeAffinity nodeAffinity) { }
    public void UnregisterProject(string projectFullPath) { }
  }
  public partial interface ITargetResult {
    System.Exception Exception { get; }
    Microsoft.Build.Framework.ITaskItem[] Items { get; }
    Microsoft.Build.Execution.TargetResultCode ResultCode { get; }
  }
  public enum NodeAffinity {
    Any = 2,
    InProc = 0,
    OutOfProc = 1,
  }
  public partial class ProjectInstance {
    public ProjectInstance(Microsoft.Build.Construction.ProjectRootElement xml) { }
    public ProjectInstance(Microsoft.Build.Construction.ProjectRootElement xml, System.Collections.Generic.IDictionary<System.String, System.String> globalProperties, string toolsVersion, Microsoft.Build.Evaluation.ProjectCollection projectCollection) { }
    public ProjectInstance(string projectFile) { }
    public ProjectInstance(string projectFile, System.Collections.Generic.IDictionary<System.String, System.String> globalProperties, string toolsVersion) { }
    public ProjectInstance(string projectFile, System.Collections.Generic.IDictionary<System.String, System.String> globalProperties, string toolsVersion, Microsoft.Build.Evaluation.ProjectCollection projectCollection) { }
    public System.Collections.Generic.List<System.String> DefaultTargets { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Collections.Generic.List<System.String>); } }
    public string Directory { get { return default(string); } }
    public string FullPath { get { return default(string); } }
    public System.Collections.Generic.IDictionary<System.String, System.String> GlobalProperties { get { return default(System.Collections.Generic.IDictionary<System.String, System.String>); } }
    public System.Collections.Generic.List<System.String> InitialTargets { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Collections.Generic.List<System.String>); } }
    public System.Collections.Generic.IDictionary<System.String, Microsoft.Build.Execution.ProjectItemDefinitionInstance> ItemDefinitions { get { return default(System.Collections.Generic.IDictionary<System.String, Microsoft.Build.Execution.ProjectItemDefinitionInstance>); } }
    public System.Collections.Generic.ICollection<Microsoft.Build.Execution.ProjectItemInstance> Items { get { return default(System.Collections.Generic.ICollection<Microsoft.Build.Execution.ProjectItemInstance>); } }
    public System.Collections.Generic.ICollection<System.String> ItemTypes { get { return default(System.Collections.Generic.ICollection<System.String>); } }
    public System.Collections.Generic.ICollection<Microsoft.Build.Execution.ProjectPropertyInstance> Properties { get { return default(System.Collections.Generic.ICollection<Microsoft.Build.Execution.ProjectPropertyInstance>); } }
    public string ToolsVersion { get { return default(string); } }
    public Microsoft.Build.Execution.ProjectItemInstance AddItem(string itemType, string evaluatedInclude) { return default(Microsoft.Build.Execution.ProjectItemInstance); }
    public Microsoft.Build.Execution.ProjectItemInstance AddItem(string itemType, string evaluatedInclude, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.String>> metadata) { return default(Microsoft.Build.Execution.ProjectItemInstance); }
    public bool Build() { return default(bool); }
    public bool Build(System.Collections.Generic.IEnumerable<Microsoft.Build.Framework.ILogger> loggers) { return default(bool); }
    public bool Build(System.Collections.Generic.IEnumerable<Microsoft.Build.Framework.ILogger> loggers, System.Collections.Generic.IEnumerable<Microsoft.Build.Logging.ForwardingLoggerRecord> remoteLoggers) { return default(bool); }
    public bool Build(string target, System.Collections.Generic.IEnumerable<Microsoft.Build.Framework.ILogger> loggers) { return default(bool); }
    public bool Build(string target, System.Collections.Generic.IEnumerable<Microsoft.Build.Framework.ILogger> loggers, System.Collections.Generic.IEnumerable<Microsoft.Build.Logging.ForwardingLoggerRecord> remoteLoggers) { return default(bool); }
    public bool Build(System.String[] targets, System.Collections.Generic.IEnumerable<Microsoft.Build.Framework.ILogger> loggers) { return default(bool); }
    public bool Build(System.String[] targets, System.Collections.Generic.IEnumerable<Microsoft.Build.Framework.ILogger> loggers, out System.Collections.Generic.IDictionary<System.String, Microsoft.Build.Execution.TargetResult> targetOutputs) { targetOutputs = default(System.Collections.Generic.IDictionary<System.String, Microsoft.Build.Execution.TargetResult>); return default(bool); }
    public bool Build(System.String[] targets, System.Collections.Generic.IEnumerable<Microsoft.Build.Framework.ILogger> loggers, System.Collections.Generic.IEnumerable<Microsoft.Build.Logging.ForwardingLoggerRecord> remoteLoggers) { return default(bool); }
    public bool Build(System.String[] targets, System.Collections.Generic.IEnumerable<Microsoft.Build.Framework.ILogger> loggers, System.Collections.Generic.IEnumerable<Microsoft.Build.Logging.ForwardingLoggerRecord> remoteLoggers, out System.Collections.Generic.IDictionary<System.String, Microsoft.Build.Execution.TargetResult> targetOutputs) { targetOutputs = default(System.Collections.Generic.IDictionary<System.String, Microsoft.Build.Execution.TargetResult>); return default(bool); }
    public Microsoft.Build.Execution.ProjectInstance DeepCopy() { return default(Microsoft.Build.Execution.ProjectInstance); }
    public Microsoft.Build.Execution.ProjectInstance DeepCopy(bool isImmutable) { return default(Microsoft.Build.Execution.ProjectInstance); }
    public bool EvaluateCondition(string condition) { return default(bool); }
    public string ExpandString(string unexpandedValue) { return default(string); }
    public static string GetEvaluatedItemIncludeEscaped(Microsoft.Build.Execution.ProjectItemDefinitionInstance item) { return default(string); }
    public static string GetEvaluatedItemIncludeEscaped(Microsoft.Build.Execution.ProjectItemInstance item) { return default(string); }
    public System.Collections.Generic.ICollection<Microsoft.Build.Execution.ProjectItemInstance> GetItems(string itemType) { return default(System.Collections.Generic.ICollection<Microsoft.Build.Execution.ProjectItemInstance>); }
    public System.Collections.Generic.IEnumerable<Microsoft.Build.Execution.ProjectItemInstance> GetItemsByItemTypeAndEvaluatedInclude(string itemType, string evaluatedInclude) { return default(System.Collections.Generic.IEnumerable<Microsoft.Build.Execution.ProjectItemInstance>); }
    public static string GetMetadataValueEscaped(Microsoft.Build.Execution.ProjectItemDefinitionInstance item, string name) { return default(string); }
    public static string GetMetadataValueEscaped(Microsoft.Build.Execution.ProjectItemInstance item, string name) { return default(string); }
    public static string GetMetadataValueEscaped(Microsoft.Build.Execution.ProjectMetadataInstance metadatum) { return default(string); }
    public Microsoft.Build.Execution.ProjectPropertyInstance GetProperty(string name) { return default(Microsoft.Build.Execution.ProjectPropertyInstance); }
    public string GetPropertyValue(string name) { return default(string); }
    public static string GetPropertyValueEscaped(Microsoft.Build.Execution.ProjectPropertyInstance property) { return default(string); }
    public bool RemoveItem(Microsoft.Build.Execution.ProjectItemInstance item) { return default(bool); }
    public bool RemoveProperty(string name) { return default(bool); }
    public Microsoft.Build.Execution.ProjectPropertyInstance SetProperty(string name, string evaluatedValue) { return default(Microsoft.Build.Execution.ProjectPropertyInstance); }
    public Microsoft.Build.Construction.ProjectRootElement ToProjectRootElement() { return default(Microsoft.Build.Construction.ProjectRootElement); }
  }
  public partial class ProjectItemDefinitionInstance {
    internal ProjectItemDefinitionInstance() { }
    public string ItemType { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
    public System.Collections.Generic.ICollection<Microsoft.Build.Execution.ProjectMetadataInstance> Metadata { get { return default(System.Collections.Generic.ICollection<Microsoft.Build.Execution.ProjectMetadataInstance>); } }
    public int MetadataCount { get { return default(int); } }
    public System.Collections.Generic.IEnumerable<System.String> MetadataNames { get { return default(System.Collections.Generic.IEnumerable<System.String>); } }
  }
  public sealed partial class ProjectItemGroupTaskInstance : Microsoft.Build.Execution.ProjectTargetInstanceChild {
    internal ProjectItemGroupTaskInstance() { }
    public override string Condition { get { return default(string); } }
    public System.Collections.Generic.ICollection<Microsoft.Build.Execution.ProjectItemGroupTaskItemInstance> Items { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Collections.Generic.ICollection<Microsoft.Build.Execution.ProjectItemGroupTaskItemInstance>); } }
  }
  public partial class ProjectItemGroupTaskItemInstance {
    internal ProjectItemGroupTaskItemInstance() { }
    public string Condition { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
    public string Exclude { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
    public string Include { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
    public string ItemType { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
    public string KeepDuplicates { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
    public string KeepMetadata { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
    public System.Collections.Generic.ICollection<Microsoft.Build.Execution.ProjectItemGroupTaskMetadataInstance> Metadata { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Collections.Generic.ICollection<Microsoft.Build.Execution.ProjectItemGroupTaskMetadataInstance>); } }
    public string Remove { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
    public string RemoveMetadata { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
  }
  public sealed partial class ProjectItemGroupTaskMetadataInstance {
    internal ProjectItemGroupTaskMetadataInstance() { }
    public string Condition { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
    public string Name { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
    public string Value { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
  }
  public partial class ProjectItemInstance : Microsoft.Build.Framework.ITaskItem, Microsoft.Build.Framework.ITaskItem2 {
    internal ProjectItemInstance() { }
    public int DirectMetadataCount { get { return default(int); } }
    public string EvaluatedInclude { get { return default(string); } set { } }
    public string ItemType { get { return default(string); } }
    public System.Collections.Generic.IEnumerable<Microsoft.Build.Execution.ProjectMetadataInstance> Metadata { get { return default(System.Collections.Generic.IEnumerable<Microsoft.Build.Execution.ProjectMetadataInstance>); } }
    public int MetadataCount { get { return default(int); } }
    public System.Collections.Generic.ICollection<System.String> MetadataNames { get { return default(System.Collections.Generic.ICollection<System.String>); } }
    string Microsoft.Build.Framework.ITaskItem.ItemSpec { get { return default(string); } set { } }
    int Microsoft.Build.Framework.ITaskItem.MetadataCount { get { return default(int); } }
    System.Collections.ICollection Microsoft.Build.Framework.ITaskItem.MetadataNames { get { return default(System.Collections.ICollection); } }
    string Microsoft.Build.Framework.ITaskItem2.EvaluatedIncludeEscaped { get { return default(string); } set { } }
    public Microsoft.Build.Execution.ProjectInstance Project { get { return default(Microsoft.Build.Execution.ProjectInstance); } }
    public Microsoft.Build.Execution.ProjectMetadataInstance GetMetadata(string name) { return default(Microsoft.Build.Execution.ProjectMetadataInstance); }
    public string GetMetadataValue(string name) { return default(string); }
    public bool HasMetadata(string name) { return default(bool); }
    System.Collections.IDictionary Microsoft.Build.Framework.ITaskItem.CloneCustomMetadata() { return default(System.Collections.IDictionary); }
    void Microsoft.Build.Framework.ITaskItem.CopyMetadataTo(Microsoft.Build.Framework.ITaskItem destinationItem) { }
    string Microsoft.Build.Framework.ITaskItem.GetMetadata(string metadataName) { return default(string); }
    void Microsoft.Build.Framework.ITaskItem.RemoveMetadata(string metadataName) { }
    void Microsoft.Build.Framework.ITaskItem.SetMetadata(string metadataName, string metadataValue) { }
    System.Collections.IDictionary Microsoft.Build.Framework.ITaskItem2.CloneCustomMetadataEscaped() { return default(System.Collections.IDictionary); }
    string Microsoft.Build.Framework.ITaskItem2.GetMetadataValueEscaped(string metadataName) { return default(string); }
    void Microsoft.Build.Framework.ITaskItem2.SetMetadataValueLiteral(string metadataName, string metadataValue) { }
    public void RemoveMetadata(string metadataName) { }
    public void SetMetadata(System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.String>> metadataDictionary) { }
    public Microsoft.Build.Execution.ProjectMetadataInstance SetMetadata(string name, string evaluatedValue) { return default(Microsoft.Build.Execution.ProjectMetadataInstance); }
  }
  public partial class ProjectMetadataInstance {
    internal ProjectMetadataInstance() { }
    public string EvaluatedValue { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
    public string Name { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
    public Microsoft.Build.Execution.ProjectMetadataInstance DeepClone() { return default(Microsoft.Build.Execution.ProjectMetadataInstance); }
    public override string ToString() { return default(string); }
  }
  public partial class ProjectOnErrorInstance : Microsoft.Build.Execution.ProjectTargetInstanceChild {
    internal ProjectOnErrorInstance() { }
    public override string Condition { get { return default(string); } }
    public string ExecuteTargets { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
  }
  public sealed partial class ProjectPropertyGroupTaskInstance : Microsoft.Build.Execution.ProjectTargetInstanceChild {
    internal ProjectPropertyGroupTaskInstance() { }
    public override string Condition { get { return default(string); } }
    public System.Collections.Generic.ICollection<Microsoft.Build.Execution.ProjectPropertyGroupTaskPropertyInstance> Properties { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Collections.Generic.ICollection<Microsoft.Build.Execution.ProjectPropertyGroupTaskPropertyInstance>); } }
  }
  public partial class ProjectPropertyGroupTaskPropertyInstance {
    internal ProjectPropertyGroupTaskPropertyInstance() { }
    public string Condition { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
    public string Name { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
    public string Value { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
  }
  public partial class ProjectPropertyInstance {
    internal ProjectPropertyInstance() { }
    public string EvaluatedValue { get { return default(string); } set { } }
    public virtual bool IsImmutable { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } }
    public string Name { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
    public override string ToString() { return default(string); }
  }
  public abstract partial class ProjectTargetInstanceChild {
    protected ProjectTargetInstanceChild() { }
    public abstract string Condition { get; }
    public string FullPath { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
  }
  public sealed partial class ProjectTaskInstance : Microsoft.Build.Execution.ProjectTargetInstanceChild {
    internal ProjectTaskInstance() { }
    public override string Condition { get { return default(string); } }
    public string ContinueOnError { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
    public string Name { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
    public System.Collections.Generic.IList<Microsoft.Build.Execution.ProjectTaskInstanceChild> Outputs { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Collections.Generic.IList<Microsoft.Build.Execution.ProjectTaskInstanceChild>); } }
    public System.Collections.Generic.IDictionary<System.String, System.String> Parameters { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Collections.Generic.IDictionary<System.String, System.String>); } }
  }
  public abstract partial class ProjectTaskInstanceChild {
    protected ProjectTaskInstanceChild() { }
    public abstract string Condition { get; }
  }
  public partial class ProjectTaskOutputItemInstance : Microsoft.Build.Execution.ProjectTaskInstanceChild {
    internal ProjectTaskOutputItemInstance() { }
    public override string Condition { get { return default(string); } }
    public string ItemType { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
    public string TaskParameter { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
  }
  public partial class ProjectTaskOutputPropertyInstance : Microsoft.Build.Execution.ProjectTaskInstanceChild {
    internal ProjectTaskOutputPropertyInstance() { }
    public override string Condition { get { return default(string); } }
    public string PropertyName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
    public string TaskParameter { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
  }
  public partial class TargetResult : Microsoft.Build.Execution.ITargetResult {
    internal TargetResult() { }
    public System.Exception Exception { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Exception); } }
    public Microsoft.Build.Framework.ITaskItem[] Items { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(Microsoft.Build.Framework.ITaskItem[]); } }
    public Microsoft.Build.Execution.TargetResultCode ResultCode { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(Microsoft.Build.Execution.TargetResultCode); } }
  }
  public enum TargetResultCode : byte {
    Failure = (byte)2,
    Skipped = (byte)0,
    Success = (byte)1,
  }
}
namespace Microsoft.Build.Internal {
  public enum NodeEngineShutdownReason {
    BuildComplete = 0,
    BuildCompleteReuse = 1,
    ConnectionFailed = 2,
    Error = 3,
  }
  public partial class OutOfProcNode {
    public OutOfProcNode() { }
    public Microsoft.Build.Internal.NodeEngineShutdownReason Run(out System.Exception shutdownException) { shutdownException = default(System.Exception); return default(Microsoft.Build.Internal.NodeEngineShutdownReason); }
  }
}
namespace Microsoft.Build.Logging {
  public delegate void ColorResetter();
  public delegate void ColorSetter(System.ConsoleColor color);
  public partial class ConfigurableForwardingLogger : Microsoft.Build.Framework.IForwardingLogger, Microsoft.Build.Framework.ILogger, Microsoft.Build.Framework.INodeLogger {
    public ConfigurableForwardingLogger() { }
    public Microsoft.Build.Framework.IEventRedirector BuildEventRedirector { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(Microsoft.Build.Framework.IEventRedirector); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public int NodeId { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(int); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public string Parameters { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public Microsoft.Build.Framework.LoggerVerbosity Verbosity { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(Microsoft.Build.Framework.LoggerVerbosity); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public void Initialize(Microsoft.Build.Framework.IEventSource eventSource) { }
    public void Initialize(Microsoft.Build.Framework.IEventSource eventSource, int nodeCount) { }
    public void Shutdown() { }
  }
  public partial class ConsoleLogger : Microsoft.Build.Framework.ILogger {
    public ConsoleLogger() { }
    public ConsoleLogger(Microsoft.Build.Framework.LoggerVerbosity verbosity) { }
    public ConsoleLogger(Microsoft.Build.Framework.LoggerVerbosity verbosity, Microsoft.Build.Logging.WriteHandler write, Microsoft.Build.Logging.ColorSetter colorSet, Microsoft.Build.Logging.ColorResetter colorReset) { }
    public string Parameters { get { return default(string); } set { } }
    public bool ShowSummary { get { return default(bool); } set { } }
    public bool SkipProjectStartedText { get { return default(bool); } set { } }
    public Microsoft.Build.Framework.LoggerVerbosity Verbosity { get { return default(Microsoft.Build.Framework.LoggerVerbosity); } set { } }
    protected Microsoft.Build.Logging.WriteHandler WriteHandler { get { return default(Microsoft.Build.Logging.WriteHandler); } set { } }
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
  public partial class FileLogger : Microsoft.Build.Logging.ConsoleLogger {
    public FileLogger() { }
    public override void Initialize(Microsoft.Build.Framework.IEventSource eventSource) { }
    public override void Shutdown() { }
  }
  public partial class ForwardingLoggerRecord {
    public ForwardingLoggerRecord(Microsoft.Build.Framework.ILogger centralLogger, Microsoft.Build.Logging.LoggerDescription forwardingLoggerDescription) { }
    public Microsoft.Build.Framework.ILogger CentralLogger { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(Microsoft.Build.Framework.ILogger); } }
    public Microsoft.Build.Logging.LoggerDescription ForwardingLoggerDescription { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(Microsoft.Build.Logging.LoggerDescription); } }
  }
  public partial class LoggerDescription {
    public LoggerDescription(string loggerClassName, string loggerAssemblyName, string loggerAssemblyFile, string loggerSwitchParameters, Microsoft.Build.Framework.LoggerVerbosity verbosity) { }
    public string LoggerSwitchParameters { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
    public Microsoft.Build.Framework.LoggerVerbosity Verbosity { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(Microsoft.Build.Framework.LoggerVerbosity); } }
    public Microsoft.Build.Framework.ILogger CreateLogger() { return default(Microsoft.Build.Framework.ILogger); }
  }
  public delegate void WriteHandler(string message);
}
