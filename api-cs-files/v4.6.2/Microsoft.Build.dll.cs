namespace Microsoft.Build.Construction {
  public abstract partial class ElementLocation {
    protected ElementLocation() { }
    [System.Diagnostics.DebuggerBrowsableAttribute((System.Diagnostics.DebuggerBrowsableState)(0))]
    public abstract int Column { get; }
    [System.Diagnostics.DebuggerBrowsableAttribute((System.Diagnostics.DebuggerBrowsableState)(0))]
    public abstract string File { get; }
    [System.Diagnostics.DebuggerBrowsableAttribute((System.Diagnostics.DebuggerBrowsableState)(0))]
    public abstract int Line { get; }
    public string LocationString { get { return default(string); } }
    public override bool Equals(object obj) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public override string ToString() { return default(string); }
  }
  [System.Diagnostics.DebuggerDisplayAttribute("ProjectChooseElement (#Children={Count} HasOtherwise={OtherwiseElement != null})")]
  public partial class ProjectChooseElement : Microsoft.Build.Construction.ProjectElementContainer {
    internal ProjectChooseElement() { }
    public override string Condition { get { return default(string); } set { } }
    public override Microsoft.Build.Construction.ElementLocation ConditionLocation { get { return default(Microsoft.Build.Construction.ElementLocation); } }
    public Microsoft.Build.Construction.ProjectOtherwiseElement OtherwiseElement { get { return default(Microsoft.Build.Construction.ProjectOtherwiseElement); } }
    public System.Collections.Generic.ICollection<Microsoft.Build.Construction.ProjectWhenElement> WhenElements { get { return default(System.Collections.Generic.ICollection<Microsoft.Build.Construction.ProjectWhenElement>); } }
  }
  public abstract partial class ProjectElement {
    internal ProjectElement() { }
    public System.Collections.Generic.IEnumerable<Microsoft.Build.Construction.ProjectElementContainer> AllParents { [System.Runtime.CompilerServices.IteratorStateMachineAttribute(typeof(Microsoft.Build.Construction.ProjectElement.<get_AllParents>d__14))]get { return default(System.Collections.Generic.IEnumerable<Microsoft.Build.Construction.ProjectElementContainer>); } }
    public virtual string Condition { [System.Diagnostics.DebuggerStepThroughAttribute]get { return default(string); } [System.Diagnostics.DebuggerStepThroughAttribute]set { } }
    public virtual Microsoft.Build.Construction.ElementLocation ConditionLocation { get { return default(Microsoft.Build.Construction.ElementLocation); } }
    public Microsoft.Build.Construction.ProjectRootElement ContainingProject { get { return default(Microsoft.Build.Construction.ProjectRootElement); } }
    public string Label { [System.Diagnostics.DebuggerStepThroughAttribute]get { return default(string); } [System.Diagnostics.DebuggerStepThroughAttribute]set { } }
    public Microsoft.Build.Construction.ElementLocation LabelLocation { get { return default(Microsoft.Build.Construction.ElementLocation); } }
    public Microsoft.Build.Construction.ElementLocation Location { get { return default(Microsoft.Build.Construction.ElementLocation); } }
    public Microsoft.Build.Construction.ProjectElement NextSibling { [System.Diagnostics.DebuggerStepThroughAttribute, System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(Microsoft.Build.Construction.ProjectElement); } }
    public Microsoft.Build.Construction.ProjectElementContainer Parent { [System.Diagnostics.DebuggerStepThroughAttribute]get { return default(Microsoft.Build.Construction.ProjectElementContainer); } }
    public Microsoft.Build.Construction.ProjectElement PreviousSibling { [System.Diagnostics.DebuggerStepThroughAttribute, System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(Microsoft.Build.Construction.ProjectElement); } }
  }
  public abstract partial class ProjectElementContainer : Microsoft.Build.Construction.ProjectElement {
    internal ProjectElementContainer() { }
    public System.Collections.Generic.IEnumerable<Microsoft.Build.Construction.ProjectElement> AllChildren { get { return default(System.Collections.Generic.IEnumerable<Microsoft.Build.Construction.ProjectElement>); } }
    public System.Collections.Generic.ICollection<Microsoft.Build.Construction.ProjectElement> Children { [System.Diagnostics.DebuggerStepThroughAttribute]get { return default(System.Collections.Generic.ICollection<Microsoft.Build.Construction.ProjectElement>); } }
    public System.Collections.Generic.ICollection<Microsoft.Build.Construction.ProjectElement> ChildrenReversed { [System.Diagnostics.DebuggerStepThroughAttribute]get { return default(System.Collections.Generic.ICollection<Microsoft.Build.Construction.ProjectElement>); } }
    public int Count { [System.Diagnostics.DebuggerStepThroughAttribute]get { return default(int); } }
    public Microsoft.Build.Construction.ProjectElement FirstChild { [System.Diagnostics.DebuggerStepThroughAttribute, System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(Microsoft.Build.Construction.ProjectElement); } }
    public Microsoft.Build.Construction.ProjectElement LastChild { [System.Diagnostics.DebuggerStepThroughAttribute, System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(Microsoft.Build.Construction.ProjectElement); } }
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
    public override Microsoft.Build.Construction.ElementLocation ConditionLocation { get { return default(Microsoft.Build.Construction.ElementLocation); } }
    public string Content { [System.Diagnostics.DebuggerStepThroughAttribute]get { return default(string); } set { } }
    public string this[string name] { get { return default(string); } set { } }
  }
  [System.Diagnostics.DebuggerDisplayAttribute("Project={Project} Condition={Condition}")]
  public partial class ProjectImportElement : Microsoft.Build.Construction.ProjectElement {
    internal ProjectImportElement() { }
    public string Project { get { return default(string); } set { } }
    public Microsoft.Build.Construction.ElementLocation ProjectLocation { get { return default(Microsoft.Build.Construction.ElementLocation); } }
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
    public string ItemType { get { return default(string); } }
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
    public string Exclude { [System.Diagnostics.DebuggerStepThroughAttribute]get { return default(string); } set { } }
    public Microsoft.Build.Construction.ElementLocation ExcludeLocation { get { return default(Microsoft.Build.Construction.ElementLocation); } }
    public bool HasMetadata { get { return default(bool); } }
    public string Include { [System.Diagnostics.DebuggerStepThroughAttribute]get { return default(string); } set { } }
    public Microsoft.Build.Construction.ElementLocation IncludeLocation { get { return default(Microsoft.Build.Construction.ElementLocation); } }
    public string ItemType { [System.Diagnostics.DebuggerStepThroughAttribute]get { return default(string); } set { } }
    public string KeepDuplicates { [System.Diagnostics.DebuggerStepThroughAttribute]get { return default(string); } set { } }
    public Microsoft.Build.Construction.ElementLocation KeepDuplicatesLocation { get { return default(Microsoft.Build.Construction.ElementLocation); } }
    public string KeepMetadata { [System.Diagnostics.DebuggerStepThroughAttribute]get { return default(string); } set { } }
    public Microsoft.Build.Construction.ElementLocation KeepMetadataLocation { get { return default(Microsoft.Build.Construction.ElementLocation); } }
    public System.Collections.Generic.ICollection<Microsoft.Build.Construction.ProjectMetadataElement> Metadata { get { return default(System.Collections.Generic.ICollection<Microsoft.Build.Construction.ProjectMetadataElement>); } }
    public string Remove { [System.Diagnostics.DebuggerStepThroughAttribute]get { return default(string); } set { } }
    public Microsoft.Build.Construction.ElementLocation RemoveLocation { get { return default(Microsoft.Build.Construction.ElementLocation); } }
    public string RemoveMetadata { [System.Diagnostics.DebuggerStepThroughAttribute]get { return default(string); } set { } }
    public Microsoft.Build.Construction.ElementLocation RemoveMetadataLocation { get { return default(Microsoft.Build.Construction.ElementLocation); } }
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
    public string ExecuteTargetsAttribute { [System.Diagnostics.DebuggerStepThroughAttribute]get { return default(string); } set { } }
    public Microsoft.Build.Construction.ElementLocation ExecuteTargetsLocation { get { return default(Microsoft.Build.Construction.ElementLocation); } }
  }
  [System.Diagnostics.DebuggerDisplayAttribute("#Children={Count}")]
  public partial class ProjectOtherwiseElement : Microsoft.Build.Construction.ProjectElementContainer {
    internal ProjectOtherwiseElement() { }
    public System.Collections.Generic.ICollection<Microsoft.Build.Construction.ProjectChooseElement> ChooseElements { get { return default(System.Collections.Generic.ICollection<Microsoft.Build.Construction.ProjectChooseElement>); } }
    public override string Condition { get { return default(string); } set { } }
    public override Microsoft.Build.Construction.ElementLocation ConditionLocation { get { return default(Microsoft.Build.Construction.ElementLocation); } }
    public System.Collections.Generic.ICollection<Microsoft.Build.Construction.ProjectItemGroupElement> ItemGroups { get { return default(System.Collections.Generic.ICollection<Microsoft.Build.Construction.ProjectItemGroupElement>); } }
    public System.Collections.Generic.ICollection<Microsoft.Build.Construction.ProjectPropertyGroupElement> PropertyGroups { get { return default(System.Collections.Generic.ICollection<Microsoft.Build.Construction.ProjectPropertyGroupElement>); } }
  }
  [System.Diagnostics.DebuggerDisplayAttribute("Name={Name} TaskParameter={TaskParameter} ItemName={ItemName} PropertyName={PropertyName} Condition={Condition}")]
  public partial class ProjectOutputElement : Microsoft.Build.Construction.ProjectElement {
    internal ProjectOutputElement() { }
    public bool IsOutputItem { get { return default(bool); } }
    public bool IsOutputProperty { get { return default(bool); } }
    public string ItemType { [System.Diagnostics.DebuggerStepThroughAttribute]get { return default(string); } set { } }
    public Microsoft.Build.Construction.ElementLocation ItemTypeLocation { get { return default(Microsoft.Build.Construction.ElementLocation); } }
    public string PropertyName { [System.Diagnostics.DebuggerStepThroughAttribute]get { return default(string); } set { } }
    public Microsoft.Build.Construction.ElementLocation PropertyNameLocation { get { return default(Microsoft.Build.Construction.ElementLocation); } }
    public string TaskParameter { [System.Diagnostics.DebuggerStepThroughAttribute]get { return default(string); } [System.Diagnostics.DebuggerStepThroughAttribute]set { } }
    public Microsoft.Build.Construction.ElementLocation TaskParameterLocation { get { return default(Microsoft.Build.Construction.ElementLocation); } }
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
  [System.Diagnostics.DebuggerDisplayAttribute("{FullPath} #Children={Count} DefaultTargets={DefaultTargets} ToolsVersion={ToolsVersion} InitialTargets={InitialTargets} ExplicitlyLoaded={IsExplicitlyLoaded}")]
  public partial class ProjectRootElement : Microsoft.Build.Construction.ProjectElementContainer {
    internal ProjectRootElement() { }
    public System.Collections.Generic.ICollection<Microsoft.Build.Construction.ProjectChooseElement> ChooseElements { get { return default(System.Collections.Generic.ICollection<Microsoft.Build.Construction.ProjectChooseElement>); } }
    public override string Condition { get { return default(string); } set { } }
    public override Microsoft.Build.Construction.ElementLocation ConditionLocation { get { return default(Microsoft.Build.Construction.ElementLocation); } }
    public string DefaultTargets { [System.Diagnostics.DebuggerStepThroughAttribute]get { return default(string); } [System.Diagnostics.DebuggerStepThroughAttribute]set { } }
    public Microsoft.Build.Construction.ElementLocation DefaultTargetsLocation { get { return default(Microsoft.Build.Construction.ElementLocation); } }
    public string DirectoryPath { [System.Diagnostics.DebuggerStepThroughAttribute]get { return default(string); } }
    public System.Text.Encoding Encoding { get { return default(System.Text.Encoding); } }
    public string FullPath { get { return default(string); } set { } }
    public bool HasUnsavedChanges { get { return default(bool); } }
    public System.Collections.Generic.ICollection<Microsoft.Build.Construction.ProjectImportGroupElement> ImportGroups { get { return default(System.Collections.Generic.ICollection<Microsoft.Build.Construction.ProjectImportGroupElement>); } }
    public System.Collections.Generic.ICollection<Microsoft.Build.Construction.ProjectImportGroupElement> ImportGroupsReversed { get { return default(System.Collections.Generic.ICollection<Microsoft.Build.Construction.ProjectImportGroupElement>); } }
    public System.Collections.Generic.ICollection<Microsoft.Build.Construction.ProjectImportElement> Imports { get { return default(System.Collections.Generic.ICollection<Microsoft.Build.Construction.ProjectImportElement>); } }
    public string InitialTargets { [System.Diagnostics.DebuggerStepThroughAttribute]get { return default(string); } [System.Diagnostics.DebuggerStepThroughAttribute]set { } }
    public Microsoft.Build.Construction.ElementLocation InitialTargetsLocation { get { return default(Microsoft.Build.Construction.ElementLocation); } }
    public System.Collections.Generic.ICollection<Microsoft.Build.Construction.ProjectItemDefinitionGroupElement> ItemDefinitionGroups { get { return default(System.Collections.Generic.ICollection<Microsoft.Build.Construction.ProjectItemDefinitionGroupElement>); } }
    public System.Collections.Generic.ICollection<Microsoft.Build.Construction.ProjectItemDefinitionGroupElement> ItemDefinitionGroupsReversed { get { return default(System.Collections.Generic.ICollection<Microsoft.Build.Construction.ProjectItemDefinitionGroupElement>); } }
    public System.Collections.Generic.ICollection<Microsoft.Build.Construction.ProjectItemDefinitionElement> ItemDefinitions { get { return default(System.Collections.Generic.ICollection<Microsoft.Build.Construction.ProjectItemDefinitionElement>); } }
    public System.Collections.Generic.ICollection<Microsoft.Build.Construction.ProjectItemGroupElement> ItemGroups { get { return default(System.Collections.Generic.ICollection<Microsoft.Build.Construction.ProjectItemGroupElement>); } }
    public System.Collections.Generic.ICollection<Microsoft.Build.Construction.ProjectItemGroupElement> ItemGroupsReversed { get { return default(System.Collections.Generic.ICollection<Microsoft.Build.Construction.ProjectItemGroupElement>); } }
    public System.Collections.Generic.ICollection<Microsoft.Build.Construction.ProjectItemElement> Items { get { return default(System.Collections.Generic.ICollection<Microsoft.Build.Construction.ProjectItemElement>); } }
    public System.DateTime LastWriteTimeWhenRead { [System.Diagnostics.DebuggerStepThroughAttribute]get { return default(System.DateTime); } }
    public Microsoft.Build.Construction.ElementLocation ProjectFileLocation { get { return default(Microsoft.Build.Construction.ElementLocation); } }
    public System.Collections.Generic.ICollection<Microsoft.Build.Construction.ProjectPropertyElement> Properties { get { return default(System.Collections.Generic.ICollection<Microsoft.Build.Construction.ProjectPropertyElement>); } }
    public System.Collections.Generic.ICollection<Microsoft.Build.Construction.ProjectPropertyGroupElement> PropertyGroups { get { return default(System.Collections.Generic.ICollection<Microsoft.Build.Construction.ProjectPropertyGroupElement>); } }
    public System.Collections.Generic.ICollection<Microsoft.Build.Construction.ProjectPropertyGroupElement> PropertyGroupsReversed { get { return default(System.Collections.Generic.ICollection<Microsoft.Build.Construction.ProjectPropertyGroupElement>); } }
    public string RawXml { get { return default(string); } }
    public System.Collections.Generic.ICollection<Microsoft.Build.Construction.ProjectTargetElement> Targets { get { return default(System.Collections.Generic.ICollection<Microsoft.Build.Construction.ProjectTargetElement>); } }
    public System.DateTime TimeLastChanged { [System.Diagnostics.DebuggerStepThroughAttribute]get { return default(System.DateTime); } }
    public string ToolsVersion { [System.Diagnostics.DebuggerStepThroughAttribute]get { return default(string); } [System.Diagnostics.DebuggerStepThroughAttribute]set { } }
    public Microsoft.Build.Construction.ElementLocation ToolsVersionLocation { get { return default(Microsoft.Build.Construction.ElementLocation); } }
    public string TreatAsLocalProperty { [System.Diagnostics.DebuggerStepThroughAttribute]get { return default(string); } [System.Diagnostics.DebuggerStepThroughAttribute]set { } }
    public Microsoft.Build.Construction.ElementLocation TreatAsLocalPropertyLocation { get { return default(Microsoft.Build.Construction.ElementLocation); } }
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
    public Microsoft.Build.Construction.ProjectUsingTaskElement CreateUsingTaskElement(string taskName, string assemblyFile, string assemblyName, string runtime, string architecture) { return default(Microsoft.Build.Construction.ProjectUsingTaskElement); }
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
    public string AfterTargets { [System.Diagnostics.DebuggerStepThroughAttribute]get { return default(string); } set { } }
    public Microsoft.Build.Construction.ElementLocation AfterTargetsLocation { get { return default(Microsoft.Build.Construction.ElementLocation); } }
    public string BeforeTargets { [System.Diagnostics.DebuggerStepThroughAttribute]get { return default(string); } set { } }
    public Microsoft.Build.Construction.ElementLocation BeforeTargetsLocation { get { return default(Microsoft.Build.Construction.ElementLocation); } }
    public string DependsOnTargets { [System.Diagnostics.DebuggerStepThroughAttribute]get { return default(string); } set { } }
    public Microsoft.Build.Construction.ElementLocation DependsOnTargetsLocation { get { return default(Microsoft.Build.Construction.ElementLocation); } }
    public string Inputs { [System.Diagnostics.DebuggerStepThroughAttribute]get { return default(string); } set { } }
    public Microsoft.Build.Construction.ElementLocation InputsLocation { get { return default(Microsoft.Build.Construction.ElementLocation); } }
    public System.Collections.Generic.ICollection<Microsoft.Build.Construction.ProjectItemGroupElement> ItemGroups { get { return default(System.Collections.Generic.ICollection<Microsoft.Build.Construction.ProjectItemGroupElement>); } }
    public string KeepDuplicateOutputs { [System.Diagnostics.DebuggerStepThroughAttribute]get { return default(string); } set { } }
    public Microsoft.Build.Construction.ElementLocation KeepDuplicateOutputsLocation { get { return default(Microsoft.Build.Construction.ElementLocation); } }
    public string Name { [System.Diagnostics.DebuggerStepThroughAttribute]get { return default(string); } set { } }
    public Microsoft.Build.Construction.ElementLocation NameLocation { get { return default(Microsoft.Build.Construction.ElementLocation); } }
    public System.Collections.Generic.ICollection<Microsoft.Build.Construction.ProjectOnErrorElement> OnErrors { get { return default(System.Collections.Generic.ICollection<Microsoft.Build.Construction.ProjectOnErrorElement>); } }
    public string Outputs { [System.Diagnostics.DebuggerStepThroughAttribute]get { return default(string); } set { } }
    public Microsoft.Build.Construction.ElementLocation OutputsLocation { get { return default(Microsoft.Build.Construction.ElementLocation); } }
    public System.Collections.Generic.ICollection<Microsoft.Build.Construction.ProjectPropertyGroupElement> PropertyGroups { get { return default(System.Collections.Generic.ICollection<Microsoft.Build.Construction.ProjectPropertyGroupElement>); } }
    public string Returns { [System.Diagnostics.DebuggerStepThroughAttribute]get { return default(string); } set { } }
    public Microsoft.Build.Construction.ElementLocation ReturnsLocation { get { return default(Microsoft.Build.Construction.ElementLocation); } }
    public System.Collections.Generic.ICollection<Microsoft.Build.Construction.ProjectTaskElement> Tasks { get { return default(System.Collections.Generic.ICollection<Microsoft.Build.Construction.ProjectTaskElement>); } }
    public Microsoft.Build.Construction.ProjectItemGroupElement AddItemGroup() { return default(Microsoft.Build.Construction.ProjectItemGroupElement); }
    public Microsoft.Build.Construction.ProjectPropertyGroupElement AddPropertyGroup() { return default(Microsoft.Build.Construction.ProjectPropertyGroupElement); }
    public Microsoft.Build.Construction.ProjectTaskElement AddTask(string taskName) { return default(Microsoft.Build.Construction.ProjectTaskElement); }
  }
  [System.Diagnostics.DebuggerDisplayAttribute("{Name} Condition={Condition} ContinueOnError={ContinueOnError} MSBuildRuntime={MSBuildRuntime} MSBuildArchitecture={MSBuildArchitecture} #Outputs={Count}")]
  public partial class ProjectTaskElement : Microsoft.Build.Construction.ProjectElementContainer {
    internal ProjectTaskElement() { }
    public string ContinueOnError { [System.Diagnostics.DebuggerStepThroughAttribute]get { return default(string); } [System.Diagnostics.DebuggerStepThroughAttribute]set { } }
    public Microsoft.Build.Construction.ElementLocation ContinueOnErrorLocation { get { return default(Microsoft.Build.Construction.ElementLocation); } }
    public string MSBuildArchitecture { [System.Diagnostics.DebuggerStepThroughAttribute]get { return default(string); } [System.Diagnostics.DebuggerStepThroughAttribute]set { } }
    public Microsoft.Build.Construction.ElementLocation MSBuildArchitectureLocation { get { return default(Microsoft.Build.Construction.ElementLocation); } }
    public string MSBuildRuntime { [System.Diagnostics.DebuggerStepThroughAttribute]get { return default(string); } [System.Diagnostics.DebuggerStepThroughAttribute]set { } }
    public Microsoft.Build.Construction.ElementLocation MSBuildRuntimeLocation { get { return default(Microsoft.Build.Construction.ElementLocation); } }
    public string Name { get { return default(string); } }
    public System.Collections.Generic.ICollection<Microsoft.Build.Construction.ProjectOutputElement> Outputs { get { return default(System.Collections.Generic.ICollection<Microsoft.Build.Construction.ProjectOutputElement>); } }
    public System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, Microsoft.Build.Construction.ElementLocation>> ParameterLocations { get { return default(System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, Microsoft.Build.Construction.ElementLocation>>); } }
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
    public override Microsoft.Build.Construction.ElementLocation ConditionLocation { get { return default(Microsoft.Build.Construction.ElementLocation); } }
    public string Evaluate { get { return default(string); } set { } }
    public Microsoft.Build.Construction.ElementLocation EvaluateLocation { get { return default(Microsoft.Build.Construction.ElementLocation); } }
    public string TaskBody { get { return default(string); } set { } }
  }
  [System.Diagnostics.DebuggerDisplayAttribute("TaskName={TaskName} AssemblyName={AssemblyName} AssemblyFile={AssemblyFile} Condition={Condition} Runtime={Runtime} Architecture={Architecture}")]
  public partial class ProjectUsingTaskElement : Microsoft.Build.Construction.ProjectElementContainer {
    internal ProjectUsingTaskElement() { }
    public string Architecture { get { return default(string); } set { } }
    public Microsoft.Build.Construction.ElementLocation ArchitectureLocation { get { return default(Microsoft.Build.Construction.ElementLocation); } }
    public string AssemblyFile { get { return default(string); } set { } }
    public Microsoft.Build.Construction.ElementLocation AssemblyFileLocation { get { return default(Microsoft.Build.Construction.ElementLocation); } }
    public string AssemblyName { get { return default(string); } set { } }
    public Microsoft.Build.Construction.ElementLocation AssemblyNameLocation { get { return default(Microsoft.Build.Construction.ElementLocation); } }
    public Microsoft.Build.Construction.UsingTaskParameterGroupElement ParameterGroup { get { return default(Microsoft.Build.Construction.UsingTaskParameterGroupElement); } }
    public string Runtime { get { return default(string); } set { } }
    public Microsoft.Build.Construction.ElementLocation RuntimeLocation { get { return default(Microsoft.Build.Construction.ElementLocation); } }
    public Microsoft.Build.Construction.ProjectUsingTaskBodyElement TaskBody { get { return default(Microsoft.Build.Construction.ProjectUsingTaskBodyElement); } }
    public string TaskFactory { get { return default(string); } set { } }
    public Microsoft.Build.Construction.ElementLocation TaskFactoryLocation { get { return default(Microsoft.Build.Construction.ElementLocation); } }
    public string TaskName { get { return default(string); } set { } }
    public Microsoft.Build.Construction.ElementLocation TaskNameLocation { get { return default(Microsoft.Build.Construction.ElementLocation); } }
    public Microsoft.Build.Construction.UsingTaskParameterGroupElement AddParameterGroup() { return default(Microsoft.Build.Construction.UsingTaskParameterGroupElement); }
    public Microsoft.Build.Construction.ProjectUsingTaskBodyElement AddUsingTaskBody(string evaluate, string taskBody) { return default(Microsoft.Build.Construction.ProjectUsingTaskBodyElement); }
  }
  [System.Diagnostics.DebuggerDisplayAttribute("Name={Name} ParameterType={ParameterType} Output={Output} Required={Required}")]
  public partial class ProjectUsingTaskParameterElement : Microsoft.Build.Construction.ProjectElement {
    internal ProjectUsingTaskParameterElement() { }
    public override string Condition { get { return default(string); } set { } }
    public override Microsoft.Build.Construction.ElementLocation ConditionLocation { get { return default(Microsoft.Build.Construction.ElementLocation); } }
    public string Name { [System.Diagnostics.DebuggerStepThroughAttribute]get { return default(string); } set { } }
    public string Output { get { return default(string); } set { } }
    public Microsoft.Build.Construction.ElementLocation OutputLocation { get { return default(Microsoft.Build.Construction.ElementLocation); } }
    public string ParameterType { get { return default(string); } set { } }
    public Microsoft.Build.Construction.ElementLocation ParameterTypeLocation { get { return default(Microsoft.Build.Construction.ElementLocation); } }
    public string Required { get { return default(string); } set { } }
    public Microsoft.Build.Construction.ElementLocation RequiredLocation { get { return default(Microsoft.Build.Construction.ElementLocation); } }
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
    public override Microsoft.Build.Construction.ElementLocation ConditionLocation { get { return default(Microsoft.Build.Construction.ElementLocation); } }
    public System.Collections.Generic.ICollection<Microsoft.Build.Construction.ProjectUsingTaskParameterElement> Parameters { get { return default(System.Collections.Generic.ICollection<Microsoft.Build.Construction.ProjectUsingTaskParameterElement>); } }
    public Microsoft.Build.Construction.ProjectUsingTaskParameterElement AddParameter(string name) { return default(Microsoft.Build.Construction.ProjectUsingTaskParameterElement); }
    public Microsoft.Build.Construction.ProjectUsingTaskParameterElement AddParameter(string name, string output, string required, string parameterType) { return default(Microsoft.Build.Construction.ProjectUsingTaskParameterElement); }
  }
}
namespace Microsoft.Build.Debugging {
  public static partial class DebuggerManager {
    public sealed partial class IslandThread : System.IDisposable {
      internal IslandThread() { }
      public static void IslandWorker(Microsoft.Build.Debugging.DebuggerManager.IslandThread controller) { }
      void System.IDisposable.Dispose() { }
    }
  }
}
namespace Microsoft.Build.Evaluation {
  [System.Diagnostics.DebuggerDisplayAttribute("{FullPath} EffectiveToolsVersion={ToolsVersion} #GlobalProperties={data.globalProperties.Count} #Properties={data.Properties.Count} #ItemTypes={data.ItemTypes.Count} #ItemDefinitions={data.ItemDefinitions.Count} #Items={data.Items.Count} #Targets={data.Targets.Count}")]
  public partial class Project {
    public Project() { }
    public Project(Microsoft.Build.Construction.ProjectRootElement xml) { }
    public Project(Microsoft.Build.Construction.ProjectRootElement xml, System.Collections.Generic.IDictionary<System.String, System.String> globalProperties, string toolsVersion) { }
    public Project(Microsoft.Build.Construction.ProjectRootElement xml, System.Collections.Generic.IDictionary<System.String, System.String> globalProperties, string toolsVersion, Microsoft.Build.Evaluation.ProjectCollection projectCollection) { }
    public Project(Microsoft.Build.Construction.ProjectRootElement xml, System.Collections.Generic.IDictionary<System.String, System.String> globalProperties, string toolsVersion, Microsoft.Build.Evaluation.ProjectCollection projectCollection, Microsoft.Build.Evaluation.ProjectLoadSettings loadSettings) { }
    public Project(Microsoft.Build.Construction.ProjectRootElement xml, System.Collections.Generic.IDictionary<System.String, System.String> globalProperties, string toolsVersion, string subToolsetVersion, Microsoft.Build.Evaluation.ProjectCollection projectCollection, Microsoft.Build.Evaluation.ProjectLoadSettings loadSettings) { }
    public Project(Microsoft.Build.Evaluation.ProjectCollection projectCollection) { }
    public Project(System.Collections.Generic.IDictionary<System.String, System.String> globalProperties, string toolsVersion, Microsoft.Build.Evaluation.ProjectCollection projectCollection) { }
    public Project(string projectFile) { }
    public Project(string projectFile, System.Collections.Generic.IDictionary<System.String, System.String> globalProperties, string toolsVersion) { }
    public Project(string projectFile, System.Collections.Generic.IDictionary<System.String, System.String> globalProperties, string toolsVersion, Microsoft.Build.Evaluation.ProjectCollection projectCollection) { }
    public Project(string projectFile, System.Collections.Generic.IDictionary<System.String, System.String> globalProperties, string toolsVersion, Microsoft.Build.Evaluation.ProjectCollection projectCollection, Microsoft.Build.Evaluation.ProjectLoadSettings loadSettings) { }
    public Project(string projectFile, System.Collections.Generic.IDictionary<System.String, System.String> globalProperties, string toolsVersion, string subToolsetVersion, Microsoft.Build.Evaluation.ProjectCollection projectCollection, Microsoft.Build.Evaluation.ProjectLoadSettings loadSettings) { }
    public Project(System.Xml.XmlReader xmlReader) { }
    public Project(System.Xml.XmlReader xmlReader, System.Collections.Generic.IDictionary<System.String, System.String> globalProperties, string toolsVersion) { }
    public Project(System.Xml.XmlReader xmlReader, System.Collections.Generic.IDictionary<System.String, System.String> globalProperties, string toolsVersion, Microsoft.Build.Evaluation.ProjectCollection projectCollection) { }
    public Project(System.Xml.XmlReader xmlReader, System.Collections.Generic.IDictionary<System.String, System.String> globalProperties, string toolsVersion, Microsoft.Build.Evaluation.ProjectCollection projectCollection, Microsoft.Build.Evaluation.ProjectLoadSettings loadSettings) { }
    public Project(System.Xml.XmlReader xmlReader, System.Collections.Generic.IDictionary<System.String, System.String> globalProperties, string toolsVersion, string subToolsetVersion, Microsoft.Build.Evaluation.ProjectCollection projectCollection, Microsoft.Build.Evaluation.ProjectLoadSettings loadSettings) { }
    public System.Collections.Generic.ICollection<Microsoft.Build.Evaluation.ProjectMetadata> AllEvaluatedItemDefinitionMetadata { get { return default(System.Collections.Generic.ICollection<Microsoft.Build.Evaluation.ProjectMetadata>); } }
    public System.Collections.Generic.ICollection<Microsoft.Build.Evaluation.ProjectItem> AllEvaluatedItems { get { return default(System.Collections.Generic.ICollection<Microsoft.Build.Evaluation.ProjectItem>); } }
    public System.Collections.Generic.ICollection<Microsoft.Build.Evaluation.ProjectProperty> AllEvaluatedProperties { get { return default(System.Collections.Generic.ICollection<Microsoft.Build.Evaluation.ProjectProperty>); } }
    public System.Collections.Generic.IDictionary<System.String, System.Collections.Generic.List<System.String>> ConditionedProperties { [System.Diagnostics.DebuggerStepThroughAttribute]get { return default(System.Collections.Generic.IDictionary<System.String, System.Collections.Generic.List<System.String>>); } }
    public string DirectoryPath { [System.Diagnostics.DebuggerStepThroughAttribute]get { return default(string); } }
    public bool DisableMarkDirty { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public int EvaluationCounter { get { return default(int); } }
    public string FullPath { [System.Diagnostics.DebuggerStepThroughAttribute]get { return default(string); } [System.Diagnostics.DebuggerStepThroughAttribute]set { } }
    public System.Collections.Generic.IDictionary<System.String, System.String> GlobalProperties { [System.Diagnostics.DebuggerStepThroughAttribute]get { return default(System.Collections.Generic.IDictionary<System.String, System.String>); } }
    public System.Collections.Generic.IList<Microsoft.Build.Evaluation.ResolvedImport> Imports { get { return default(System.Collections.Generic.IList<Microsoft.Build.Evaluation.ResolvedImport>); } }
    public System.Collections.Generic.IList<Microsoft.Build.Evaluation.ResolvedImport> ImportsIncludingDuplicates { get { return default(System.Collections.Generic.IList<Microsoft.Build.Evaluation.ResolvedImport>); } }
    public bool IsBuildEnabled { get { return default(bool); } set { } }
    public bool IsDirty { get { return default(bool); } }
    public System.Collections.Generic.IDictionary<System.String, Microsoft.Build.Evaluation.ProjectItemDefinition> ItemDefinitions { [System.Diagnostics.DebuggerStepThroughAttribute]get { return default(System.Collections.Generic.IDictionary<System.String, Microsoft.Build.Evaluation.ProjectItemDefinition>); } }
    public System.Collections.Generic.ICollection<Microsoft.Build.Evaluation.ProjectItem> Items { [System.Diagnostics.DebuggerStepThroughAttribute]get { return default(System.Collections.Generic.ICollection<Microsoft.Build.Evaluation.ProjectItem>); } }
    public System.Collections.Generic.ICollection<Microsoft.Build.Evaluation.ProjectItem> ItemsIgnoringCondition { [System.Diagnostics.DebuggerStepThroughAttribute]get { return default(System.Collections.Generic.ICollection<Microsoft.Build.Evaluation.ProjectItem>); } }
    public System.Collections.Generic.ICollection<System.String> ItemTypes { [System.Diagnostics.DebuggerStepThroughAttribute]get { return default(System.Collections.Generic.ICollection<System.String>); } }
    public Microsoft.Build.Evaluation.ProjectCollection ProjectCollection { [System.Diagnostics.DebuggerStepThroughAttribute]get { return default(Microsoft.Build.Evaluation.ProjectCollection); } }
    public Microsoft.Build.Construction.ElementLocation ProjectFileLocation { get { return default(Microsoft.Build.Construction.ElementLocation); } }
    public System.Collections.Generic.ICollection<Microsoft.Build.Evaluation.ProjectProperty> Properties { [System.Diagnostics.DebuggerStepThroughAttribute]get { return default(System.Collections.Generic.ICollection<Microsoft.Build.Evaluation.ProjectProperty>); } }
    public bool SkipEvaluation { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public string SubToolsetVersion { get { return default(string); } }
    public System.Collections.Generic.IDictionary<System.String, Microsoft.Build.Execution.ProjectTargetInstance> Targets { [System.Diagnostics.DebuggerStepThroughAttribute]get { return default(System.Collections.Generic.IDictionary<System.String, Microsoft.Build.Execution.ProjectTargetInstance>); } }
    public string ToolsVersion { get { return default(string); } }
    public Microsoft.Build.Construction.ProjectRootElement Xml { [System.Diagnostics.DebuggerStepThroughAttribute]get { return default(Microsoft.Build.Construction.ProjectRootElement); } }
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
    public Microsoft.Build.Execution.ProjectInstance CreateProjectInstance(Microsoft.Build.Execution.ProjectInstanceSettings settings) { return default(Microsoft.Build.Execution.ProjectInstance); }
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
    [System.Diagnostics.DebuggerStepThroughAttribute]
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
    public ProjectCollection(Microsoft.Build.Evaluation.ToolsetDefinitionLocations toolsetLocations) { }
    public ProjectCollection(System.Collections.Generic.IDictionary<System.String, System.String> globalProperties) { }
    public ProjectCollection(System.Collections.Generic.IDictionary<System.String, System.String> globalProperties, System.Collections.Generic.IEnumerable<Microsoft.Build.Framework.ILogger> loggers, Microsoft.Build.Evaluation.ToolsetDefinitionLocations toolsetDefinitionLocations) { }
    public ProjectCollection(System.Collections.Generic.IDictionary<System.String, System.String> globalProperties, System.Collections.Generic.IEnumerable<Microsoft.Build.Framework.ILogger> loggers, System.Collections.Generic.IEnumerable<Microsoft.Build.Logging.ForwardingLoggerRecord> remoteLoggers, Microsoft.Build.Evaluation.ToolsetDefinitionLocations toolsetDefinitionLocations, int maxNodeCount, bool onlyLogCriticalEvents) { }
    public int Count { get { return default(int); } }
    public string DefaultToolsVersion { get { return default(string); } set { } }
    public bool DisableMarkDirty { get { return default(bool); } set { } }
    public static Microsoft.Build.Evaluation.ProjectCollection GlobalProjectCollection { get { return default(Microsoft.Build.Evaluation.ProjectCollection); } }
    public System.Collections.Generic.IDictionary<System.String, System.String> GlobalProperties { get { return default(System.Collections.Generic.IDictionary<System.String, System.String>); } }
    public Microsoft.Build.Execution.HostServices HostServices { get { return default(Microsoft.Build.Execution.HostServices); } set { } }
    public bool IsBuildEnabled { [System.Diagnostics.DebuggerStepThroughAttribute]get { return default(bool); } [System.Diagnostics.DebuggerStepThroughAttribute]set { } }
    public System.Collections.Generic.ICollection<Microsoft.Build.Evaluation.Project> LoadedProjects { get { return default(System.Collections.Generic.ICollection<Microsoft.Build.Evaluation.Project>); } }
    public System.Collections.Generic.ICollection<Microsoft.Build.Framework.ILogger> Loggers { [System.Diagnostics.DebuggerStepThroughAttribute]get { return default(System.Collections.Generic.ICollection<Microsoft.Build.Framework.ILogger>); } }
    public bool OnlyLogCriticalEvents { get { return default(bool); } set { } }
    public bool SkipEvaluation { get { return default(bool); } set { } }
    public Microsoft.Build.Evaluation.ToolsetDefinitionLocations ToolsetLocations { [System.Diagnostics.DebuggerStepThroughAttribute]get { return default(Microsoft.Build.Evaluation.ToolsetDefinitionLocations); } }
    public System.Collections.Generic.ICollection<Microsoft.Build.Evaluation.Toolset> Toolsets { get { return default(System.Collections.Generic.ICollection<Microsoft.Build.Evaluation.Toolset>); } }
    public static System.Version Version { get { return default(System.Version); } }
    public event Microsoft.Build.Evaluation.ProjectCollection.ProjectAddedEventHandler ProjectAdded { add { } remove { } }
    public event System.EventHandler<Microsoft.Build.Evaluation.ProjectChangedEventArgs> ProjectChanged { add { } remove { } }
    public event System.EventHandler<Microsoft.Build.Evaluation.ProjectCollectionChangedEventArgs> ProjectCollectionChanged { add { } remove { } }
    public event System.EventHandler<Microsoft.Build.Evaluation.ProjectXmlChangedEventArgs> ProjectXmlChanged { add { } remove { } }
    public void AddToolset(Microsoft.Build.Evaluation.Toolset toolset) { }
    public bool ContainsToolset(string toolsVersion) { return default(bool); }
    public void Dispose() { }
    protected virtual void Dispose(bool disposing) { }
    public static string Escape(string unescapedString) { return default(string); }
    public Microsoft.Build.Execution.ProjectPropertyInstance GetGlobalProperty(string name) { return default(Microsoft.Build.Execution.ProjectPropertyInstance); }
    public System.Collections.Generic.ICollection<Microsoft.Build.Evaluation.Project> GetLoadedProjects(string fullPath) { return default(System.Collections.Generic.ICollection<Microsoft.Build.Evaluation.Project>); }
    public Microsoft.Build.Evaluation.Toolset GetToolset(string toolsVersion) { return default(Microsoft.Build.Evaluation.Toolset); }
    public Microsoft.Build.Evaluation.Project LoadProject(string fileName) { return default(Microsoft.Build.Evaluation.Project); }
    public Microsoft.Build.Evaluation.Project LoadProject(string fileName, System.Collections.Generic.IDictionary<System.String, System.String> globalProperties, string toolsVersion) { return default(Microsoft.Build.Evaluation.Project); }
    public Microsoft.Build.Evaluation.Project LoadProject(string fileName, string toolsVersion) { return default(Microsoft.Build.Evaluation.Project); }
    public Microsoft.Build.Evaluation.Project LoadProject(System.Xml.XmlReader xmlReader) { return default(Microsoft.Build.Evaluation.Project); }
    public Microsoft.Build.Evaluation.Project LoadProject(System.Xml.XmlReader xmlReader, System.Collections.Generic.IDictionary<System.String, System.String> globalProperties, string toolsVersion) { return default(Microsoft.Build.Evaluation.Project); }
    public Microsoft.Build.Evaluation.Project LoadProject(System.Xml.XmlReader xmlReader, string toolsVersion) { return default(Microsoft.Build.Evaluation.Project); }
    public void RegisterForwardingLoggers(System.Collections.Generic.IEnumerable<Microsoft.Build.Logging.ForwardingLoggerRecord> remoteLoggers) { }
    public void RegisterLogger(Microsoft.Build.Framework.ILogger logger) { }
    public void RegisterLoggers(System.Collections.Generic.IEnumerable<Microsoft.Build.Framework.ILogger> loggers) { }
    public void RemoveAllToolsets() { }
    public bool RemoveGlobalProperty(string name) { return default(bool); }
    public bool RemoveToolset(string toolsVersion) { return default(bool); }
    public void SetGlobalProperty(string name, string value) { }
    public bool TryUnloadProject(Microsoft.Build.Construction.ProjectRootElement projectRootElement) { return default(bool); }
    public static string Unescape(string escapedString) { return default(string); }
    public void UnloadAllProjects() { }
    public void UnloadProject(Microsoft.Build.Construction.ProjectRootElement projectRootElement) { }
    public void UnloadProject(Microsoft.Build.Evaluation.Project project) { }
    public void UnregisterAllLoggers() { }
    public delegate void ProjectAddedEventHandler(object sender, Microsoft.Build.Evaluation.ProjectCollection.ProjectAddedToProjectCollectionEventArgs e);
    public partial class ProjectAddedToProjectCollectionEventArgs : System.EventArgs {
      public ProjectAddedToProjectCollectionEventArgs(Microsoft.Build.Construction.ProjectRootElement element) { }
      public Microsoft.Build.Construction.ProjectRootElement ProjectRootElement { get { return default(Microsoft.Build.Construction.ProjectRootElement); } }
    }
  }
  public partial class ProjectCollectionChangedEventArgs : System.EventArgs {
    internal ProjectCollectionChangedEventArgs() { }
    public Microsoft.Build.Evaluation.ProjectCollectionChangedState Changed { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(Microsoft.Build.Evaluation.ProjectCollectionChangedState); } }
  }
  public enum ProjectCollectionChangedState {
    DefaultToolsVersion = 0,
    DisableMarkDirty = 7,
    GlobalProperties = 3,
    HostServices = 6,
    IsBuildEnabled = 4,
    Loggers = 2,
    OnlyLogCriticalEvents = 5,
    SkipEvaluation = 8,
    Toolsets = 1,
  }
  [System.Diagnostics.DebuggerDisplayAttribute("{ItemType}={EvaluatedInclude} [{UnevaluatedInclude}] #DirectMetadata={DirectMetadataCount}")]
  public partial class ProjectItem {
    internal ProjectItem() { }
    public System.Collections.Generic.IEnumerable<Microsoft.Build.Evaluation.ProjectMetadata> DirectMetadata { get { return default(System.Collections.Generic.IEnumerable<Microsoft.Build.Evaluation.ProjectMetadata>); } }
    public int DirectMetadataCount { [System.Diagnostics.DebuggerStepThroughAttribute]get { return default(int); } }
    public string EvaluatedInclude { [System.Diagnostics.DebuggerStepThroughAttribute]get { return default(string); } }
    public bool IsImported { get { return default(bool); } }
    public string ItemType { [System.Diagnostics.DebuggerStepThroughAttribute]get { return default(string); } set { } }
    public System.Collections.Generic.ICollection<Microsoft.Build.Evaluation.ProjectMetadata> Metadata { [System.Diagnostics.DebuggerStepThroughAttribute]get { return default(System.Collections.Generic.ICollection<Microsoft.Build.Evaluation.ProjectMetadata>); } }
    public int MetadataCount { [System.Diagnostics.DebuggerStepThroughAttribute]get { return default(int); } }
    [System.Diagnostics.DebuggerBrowsableAttribute((System.Diagnostics.DebuggerBrowsableState)(0))]
    public Microsoft.Build.Evaluation.Project Project { [System.Diagnostics.DebuggerStepThroughAttribute]get { return default(Microsoft.Build.Evaluation.Project); } }
    public string UnevaluatedInclude { [System.Diagnostics.DebuggerStepThroughAttribute]get { return default(string); } set { } }
    [System.Diagnostics.DebuggerBrowsableAttribute((System.Diagnostics.DebuggerBrowsableState)(0))]
    public Microsoft.Build.Construction.ProjectItemElement Xml { [System.Diagnostics.DebuggerStepThroughAttribute]get { return default(Microsoft.Build.Construction.ProjectItemElement); } }
    public Microsoft.Build.Evaluation.ProjectMetadata GetMetadata(string name) { return default(Microsoft.Build.Evaluation.ProjectMetadata); }
    public string GetMetadataValue(string name) { return default(string); }
    public bool HasMetadata(string name) { return default(bool); }
    public bool RemoveMetadata(string name) { return default(bool); }
    public void Rename(string name) { }
    public Microsoft.Build.Evaluation.ProjectMetadata SetMetadataValue(string name, string unevaluatedValue) { return default(Microsoft.Build.Evaluation.ProjectMetadata); }
  }
  [System.Diagnostics.DebuggerDisplayAttribute("{itemType} #Metadata={MetadataCount}")]
  public partial class ProjectItemDefinition {
    internal ProjectItemDefinition() { }
    [System.Diagnostics.DebuggerBrowsableAttribute((System.Diagnostics.DebuggerBrowsableState)(0))]
    public string ItemType { [System.Diagnostics.DebuggerStepThroughAttribute]get { return default(string); } }
    public System.Collections.Generic.IEnumerable<Microsoft.Build.Evaluation.ProjectMetadata> Metadata { get { return default(System.Collections.Generic.IEnumerable<Microsoft.Build.Evaluation.ProjectMetadata>); } }
    public int MetadataCount { get { return default(int); } }
    [System.Diagnostics.DebuggerBrowsableAttribute((System.Diagnostics.DebuggerBrowsableState)(0))]
    public Microsoft.Build.Evaluation.Project Project { [System.Diagnostics.DebuggerStepThroughAttribute]get { return default(Microsoft.Build.Evaluation.Project); } }
    [System.Diagnostics.DebuggerStepThroughAttribute]
    public Microsoft.Build.Evaluation.ProjectMetadata GetMetadata(string name) { return default(Microsoft.Build.Evaluation.ProjectMetadata); }
    public string GetMetadataValue(string name) { return default(string); }
    public Microsoft.Build.Evaluation.ProjectMetadata SetMetadataValue(string name, string unevaluatedValue) { return default(Microsoft.Build.Evaluation.ProjectMetadata); }
  }
  [System.FlagsAttribute]
  public enum ProjectLoadSettings {
    Default = 0,
    IgnoreMissingImports = 1,
    RecordDuplicateButNotCircularImports = 2,
    RejectCircularImports = 4,
  }
  [System.Diagnostics.DebuggerDisplayAttribute("{Name}={EvaluatedValue} [{xml.Value}]")]
  public partial class ProjectMetadata : System.IEquatable<Microsoft.Build.Evaluation.ProjectMetadata> {
    internal ProjectMetadata() { }
    public Microsoft.Build.Construction.ElementLocation ConditionLocation { get { return default(Microsoft.Build.Construction.ElementLocation); } }
    public string EvaluatedValue { [System.Diagnostics.DebuggerStepThroughAttribute]get { return default(string); } }
    public bool IsImported { get { return default(bool); } }
    public string ItemType { get { return default(string); } }
    public Microsoft.Build.Construction.ElementLocation Location { get { return default(Microsoft.Build.Construction.ElementLocation); } }
    public string Name { [System.Diagnostics.DebuggerStepThroughAttribute]get { return default(string); } }
    public Microsoft.Build.Evaluation.ProjectMetadata Predecessor { [System.Diagnostics.DebuggerStepThroughAttribute]get { return default(Microsoft.Build.Evaluation.ProjectMetadata); } }
    public Microsoft.Build.Evaluation.Project Project { [System.Diagnostics.DebuggerStepThroughAttribute]get { return default(Microsoft.Build.Evaluation.Project); } }
    public string UnevaluatedValue { [System.Diagnostics.DebuggerStepThroughAttribute]get { return default(string); } [System.Diagnostics.DebuggerStepThroughAttribute]set { } }
    [System.Diagnostics.DebuggerBrowsableAttribute((System.Diagnostics.DebuggerBrowsableState)(0))]
    public Microsoft.Build.Construction.ProjectMetadataElement Xml { [System.Diagnostics.DebuggerStepThroughAttribute]get { return default(Microsoft.Build.Construction.ProjectMetadataElement); } }
    bool System.IEquatable<Microsoft.Build.Evaluation.ProjectMetadata>.Equals(Microsoft.Build.Evaluation.ProjectMetadata other) { return default(bool); }
  }
  [System.Diagnostics.DebuggerDisplayAttribute("{Name}={EvaluatedValue} [{UnevaluatedValue}]")]
  public abstract partial class ProjectProperty : System.IEquatable<Microsoft.Build.Evaluation.ProjectProperty> {
    internal ProjectProperty() { }
    public string EvaluatedValue { [System.Diagnostics.DebuggerStepThroughAttribute]get { return default(string); } }
    public abstract bool IsEnvironmentProperty { [System.Diagnostics.DebuggerStepThroughAttribute]get; }
    public abstract bool IsGlobalProperty { [System.Diagnostics.DebuggerStepThroughAttribute]get; }
    public abstract bool IsImported { get; }
    public abstract bool IsReservedProperty { [System.Diagnostics.DebuggerStepThroughAttribute]get; }
    [System.Diagnostics.DebuggerBrowsableAttribute((System.Diagnostics.DebuggerBrowsableState)(0))]
    public abstract string Name { [System.Diagnostics.DebuggerStepThroughAttribute]get; }
    public abstract Microsoft.Build.Evaluation.ProjectProperty Predecessor { [System.Diagnostics.DebuggerStepThroughAttribute]get; }
    [System.Diagnostics.DebuggerBrowsableAttribute((System.Diagnostics.DebuggerBrowsableState)(0))]
    public Microsoft.Build.Evaluation.Project Project { [System.Diagnostics.DebuggerStepThroughAttribute]get { return default(Microsoft.Build.Evaluation.Project); } }
    public abstract string UnevaluatedValue { [System.Diagnostics.DebuggerStepThroughAttribute]get; set; }
    [System.Diagnostics.DebuggerBrowsableAttribute((System.Diagnostics.DebuggerBrowsableState)(0))]
    public abstract Microsoft.Build.Construction.ProjectPropertyElement Xml { [System.Diagnostics.DebuggerStepThroughAttribute]get; }
    bool System.IEquatable<Microsoft.Build.Evaluation.ProjectProperty>.Equals(Microsoft.Build.Evaluation.ProjectProperty other) { return default(bool); }
  }
  public partial class ProjectXmlChangedEventArgs : System.EventArgs {
    internal ProjectXmlChangedEventArgs() { }
    public Microsoft.Build.Construction.ProjectRootElement ProjectXml { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(Microsoft.Build.Construction.ProjectRootElement); } }
    public string Reason { get { return default(string); } }
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct ResolvedImport {
    public Microsoft.Build.Construction.ProjectRootElement ImportedProject { get { return default(Microsoft.Build.Construction.ProjectRootElement); } }
    public Microsoft.Build.Construction.ProjectImportElement ImportingElement { get { return default(Microsoft.Build.Construction.ProjectImportElement); } }
    public bool IsImported { get { return default(bool); } }
  }
  [System.Diagnostics.DebuggerDisplayAttribute("SubToolsetVersion={SubToolsetVersion} #Properties={properties.Count}")]
  public partial class SubToolset {
    internal SubToolset() { }
    public System.Collections.Generic.IDictionary<System.String, Microsoft.Build.Execution.ProjectPropertyInstance> Properties { get { return default(System.Collections.Generic.IDictionary<System.String, Microsoft.Build.Execution.ProjectPropertyInstance>); } }
    public string SubToolsetVersion { get { return default(string); } }
  }
  [System.Diagnostics.DebuggerDisplayAttribute("ToolsVersion={ToolsVersion} ToolsPath={ToolsPath} #Properties={properties.Count}")]
  public partial class Toolset {
    public Toolset(string toolsVersion, string toolsPath, Microsoft.Build.Evaluation.ProjectCollection projectCollection, string msbuildOverrideTasksPath) { }
    public Toolset(string toolsVersion, string toolsPath, System.Collections.Generic.IDictionary<System.String, System.String> buildProperties, Microsoft.Build.Evaluation.ProjectCollection projectCollection, System.Collections.Generic.IDictionary<System.String, Microsoft.Build.Evaluation.SubToolset> subToolsets, string msbuildOverrideTasksPath) { }
    public Toolset(string toolsVersion, string toolsPath, System.Collections.Generic.IDictionary<System.String, System.String> buildProperties, Microsoft.Build.Evaluation.ProjectCollection projectCollection, string msbuildOverrideTasksPath) { }
    public string DefaultSubToolsetVersion { get { return default(string); } }
    public System.Collections.Generic.IDictionary<System.String, Microsoft.Build.Execution.ProjectPropertyInstance> Properties { get { return default(System.Collections.Generic.IDictionary<System.String, Microsoft.Build.Execution.ProjectPropertyInstance>); } }
    public System.Collections.Generic.IDictionary<System.String, Microsoft.Build.Evaluation.SubToolset> SubToolsets { get { return default(System.Collections.Generic.IDictionary<System.String, Microsoft.Build.Evaluation.SubToolset>); } }
    public string ToolsPath { get { return default(string); } }
    public string ToolsVersion { get { return default(string); } }
    public string GenerateSubToolsetVersion() { return default(string); }
    public string GenerateSubToolsetVersion(System.Collections.Generic.IDictionary<System.String, System.String> overrideGlobalProperties, int solutionVersion) { return default(string); }
    public Microsoft.Build.Execution.ProjectPropertyInstance GetProperty(string propertyName, string subToolsetVersion) { return default(Microsoft.Build.Execution.ProjectPropertyInstance); }
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
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, SerializationFormatter=true)]
    public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
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
    public string BaseMessage { get { return default(string); } }
    public int ColumnNumber { get { return default(int); } }
    public int EndColumnNumber { get { return default(int); } }
    public int EndLineNumber { get { return default(int); } }
    public string ErrorCode { get { return default(string); } }
    public string ErrorSubcategory { get { return default(string); } }
    public bool HasBeenLogged { get { return default(bool); } }
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
}
namespace Microsoft.Build.Execution {
  public partial class BuildManager : System.IDisposable {
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
    public System.Collections.Generic.IDictionary<System.String, System.String> BuildProcessEnvironment { get { return default(System.Collections.Generic.IDictionary<System.String, System.String>); } }
    public System.Threading.ThreadPriority BuildThreadPriority { get { return default(System.Threading.ThreadPriority); } set { } }
    public System.Globalization.CultureInfo Culture { get { return default(System.Globalization.CultureInfo); } set { } }
    public string DefaultToolsVersion { get { return default(string); } set { } }
    public bool DetailedSummary { get { return default(bool); } set { } }
    public bool DisableInProcNode { get { return default(bool); } set { } }
    public bool EnableNodeReuse { get { return default(bool); } set { } }
    public System.Collections.Generic.IDictionary<System.String, System.String> EnvironmentProperties { get { return default(System.Collections.Generic.IDictionary<System.String, System.String>); } }
    public System.Collections.Generic.IEnumerable<Microsoft.Build.Logging.ForwardingLoggerRecord> ForwardingLoggers { get { return default(System.Collections.Generic.IEnumerable<Microsoft.Build.Logging.ForwardingLoggerRecord>); } set { } }
    public System.Collections.Generic.IDictionary<System.String, System.String> GlobalProperties { get { return default(System.Collections.Generic.IDictionary<System.String, System.String>); } set { } }
    public Microsoft.Build.Execution.HostServices HostServices { get { return default(Microsoft.Build.Execution.HostServices); } set { } }
    public bool LegacyThreadingSemantics { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Collections.Generic.IEnumerable<Microsoft.Build.Framework.ILogger> Loggers { get { return default(System.Collections.Generic.IEnumerable<Microsoft.Build.Framework.ILogger>); } set { } }
    public bool LogInitialPropertiesAndItems { get { return default(bool); } set { } }
    public bool LogTaskInputs { get { return default(bool); } set { } }
    public int MaxNodeCount { get { return default(int); } set { } }
    public int MemoryUseLimit { get { return default(int); } set { } }
    public string NodeExeLocation { get { return default(string); } set { } }
    public bool OnlyLogCriticalEvents { get { return default(bool); } set { } }
    public bool ResetCaches { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public bool SaveOperatingEnvironment { get { return default(bool); } set { } }
    public bool ShutdownInProcNodeOnBuildFinish { get { return default(bool); } set { } }
    public Microsoft.Build.Evaluation.ToolsetDefinitionLocations ToolsetDefinitionLocations { get { return default(Microsoft.Build.Evaluation.ToolsetDefinitionLocations); } set { } }
    public System.Collections.Generic.ICollection<Microsoft.Build.Evaluation.Toolset> Toolsets { get { return default(System.Collections.Generic.ICollection<Microsoft.Build.Evaluation.Toolset>); } }
    public System.Globalization.CultureInfo UICulture { get { return default(System.Globalization.CultureInfo); } set { } }
    public bool UseSynchronousLogging { get { return default(bool); } set { } }
    public Microsoft.Build.Execution.BuildParameters Clone() { return default(Microsoft.Build.Execution.BuildParameters); }
    public Microsoft.Build.Evaluation.Toolset GetToolset(string toolsVersion) { return default(Microsoft.Build.Evaluation.Toolset); }
  }
  public partial class BuildRequestData {
    public BuildRequestData(Microsoft.Build.Execution.ProjectInstance projectInstance, System.String[] targetsToBuild) { }
    public BuildRequestData(Microsoft.Build.Execution.ProjectInstance projectInstance, System.String[] targetsToBuild, Microsoft.Build.Execution.HostServices hostServices) { }
    public BuildRequestData(Microsoft.Build.Execution.ProjectInstance projectInstance, System.String[] targetsToBuild, Microsoft.Build.Execution.HostServices hostServices, Microsoft.Build.Execution.BuildRequestDataFlags flags) { }
    public BuildRequestData(Microsoft.Build.Execution.ProjectInstance projectInstance, System.String[] targetsToBuild, Microsoft.Build.Execution.HostServices hostServices, Microsoft.Build.Execution.BuildRequestDataFlags flags, System.Collections.Generic.IEnumerable<System.String> propertiesToTransfer) { }
    public BuildRequestData(string projectFullPath, System.Collections.Generic.IDictionary<System.String, System.String> globalProperties, string toolsVersion, System.String[] targetsToBuild, Microsoft.Build.Execution.HostServices hostServices) { }
    public BuildRequestData(string projectFullPath, System.Collections.Generic.IDictionary<System.String, System.String> globalProperties, string toolsVersion, System.String[] targetsToBuild, Microsoft.Build.Execution.HostServices hostServices, Microsoft.Build.Execution.BuildRequestDataFlags flags) { }
    public string ExplicitlySpecifiedToolsVersion { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
    public Microsoft.Build.Execution.BuildRequestDataFlags Flags { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(Microsoft.Build.Execution.BuildRequestDataFlags); } }
    public System.Collections.Generic.ICollection<Microsoft.Build.Execution.ProjectPropertyInstance> GlobalProperties { get { return default(System.Collections.Generic.ICollection<Microsoft.Build.Execution.ProjectPropertyInstance>); } }
    public Microsoft.Build.Execution.HostServices HostServices { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(Microsoft.Build.Execution.HostServices); } }
    public string ProjectFullPath { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
    public Microsoft.Build.Execution.ProjectInstance ProjectInstance { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(Microsoft.Build.Execution.ProjectInstance); } }
    public System.Collections.Generic.IEnumerable<System.String> PropertiesToTransfer { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Collections.Generic.IEnumerable<System.String>); } }
    public System.Collections.Generic.ICollection<System.String> TargetNames { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Collections.Generic.ICollection<System.String>); } }
  }
  [System.FlagsAttribute]
  public enum BuildRequestDataFlags {
    IgnoreExistingProjectState = 4,
    None = 0,
    ProvideProjectStateAfterBuild = 2,
    ReplaceExistingProjectInstance = 1,
  }
  public partial class BuildResult {
    public BuildResult() { }
    public bool CircularDependency { [System.Diagnostics.DebuggerStepThroughAttribute]get { return default(bool); } }
    public int ConfigurationId { [System.Diagnostics.DebuggerStepThroughAttribute]get { return default(int); } }
    public System.Exception Exception { [System.Diagnostics.DebuggerStepThroughAttribute]get { return default(System.Exception); } }
    public int GlobalRequestId { [System.Diagnostics.DebuggerStepThroughAttribute]get { return default(int); } }
    public Microsoft.Build.Execution.ITargetResult this[string target] { [System.Diagnostics.DebuggerStepThroughAttribute]get { return default(Microsoft.Build.Execution.ITargetResult); } }
    public int NodeRequestId { [System.Diagnostics.DebuggerStepThroughAttribute]get { return default(int); } }
    public Microsoft.Build.Execution.BuildResultCode OverallResult { get { return default(Microsoft.Build.Execution.BuildResultCode); } }
    public int ParentGlobalRequestId { [System.Diagnostics.DebuggerStepThroughAttribute]get { return default(int); } }
    public Microsoft.Build.Execution.ProjectInstance ProjectStateAfterBuild { get { return default(Microsoft.Build.Execution.ProjectInstance); } set { } }
    public System.Collections.Generic.IDictionary<System.String, Microsoft.Build.Execution.TargetResult> ResultsByTarget { [System.Diagnostics.DebuggerStepThroughAttribute]get { return default(System.Collections.Generic.IDictionary<System.String, Microsoft.Build.Execution.TargetResult>); } }
    public int SubmissionId { [System.Diagnostics.DebuggerStepThroughAttribute]get { return default(int); } }
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
    public Microsoft.Build.Execution.BuildResult BuildResult { get { return default(Microsoft.Build.Execution.BuildResult); } set { } }
    public bool IsCompleted { get { return default(bool); } }
    public int SubmissionId { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(int); } }
    public System.Threading.WaitHandle WaitHandle { get { return default(System.Threading.WaitHandle); } }
    public Microsoft.Build.Execution.BuildResult Execute() { return default(Microsoft.Build.Execution.BuildResult); }
    public void ExecuteAsync(Microsoft.Build.Execution.BuildSubmissionCompleteCallback callback, object context) { }
  }
  public delegate void BuildSubmissionCompleteCallback(Microsoft.Build.Execution.BuildSubmission submission);
  [System.Diagnostics.DebuggerDisplayAttribute("#Entries={hostObjectMap.Count}")]
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
  public enum NodeEngineShutdownReason {
    BuildComplete = 0,
    BuildCompleteReuse = 1,
    ConnectionFailed = 2,
    Error = 3,
  }
  public partial class OutOfProcNode {
    public OutOfProcNode() { }
    public Microsoft.Build.Execution.NodeEngineShutdownReason Run(out System.Exception shutdownException) { shutdownException = default(System.Exception); return default(Microsoft.Build.Execution.NodeEngineShutdownReason); }
  }
  [System.Diagnostics.DebuggerDisplayAttribute("{FullPath} #Targets={TargetsCount} DefaultTargets={(DefaultTargets == null) ? System.String.Empty : System.String.Join(\";\", DefaultTargets.ToArray())} ToolsVersion={Toolset.ToolsVersion} InitialTargets={(InitialTargets == null) ? System.String.Empty : System.String.Join(\";\", InitialTargets.ToArray())} #GlobalProperties={globalProperties.Count} #Properties={properties.Count} #ItemTypes={items.ItemTypes.Count} #Items={items.Count}")]
  public partial class ProjectInstance {
    public ProjectInstance(Microsoft.Build.Construction.ProjectRootElement xml) { }
    public ProjectInstance(Microsoft.Build.Construction.ProjectRootElement xml, System.Collections.Generic.IDictionary<System.String, System.String> globalProperties, string toolsVersion, Microsoft.Build.Evaluation.ProjectCollection projectCollection) { }
    public ProjectInstance(Microsoft.Build.Construction.ProjectRootElement xml, System.Collections.Generic.IDictionary<System.String, System.String> globalProperties, string toolsVersion, string subToolsetVersion, Microsoft.Build.Evaluation.ProjectCollection projectCollection) { }
    public ProjectInstance(string projectFile) { }
    public ProjectInstance(string projectFile, System.Collections.Generic.IDictionary<System.String, System.String> globalProperties, string toolsVersion) { }
    public ProjectInstance(string projectFile, System.Collections.Generic.IDictionary<System.String, System.String> globalProperties, string toolsVersion, Microsoft.Build.Evaluation.ProjectCollection projectCollection) { }
    public ProjectInstance(string projectFile, System.Collections.Generic.IDictionary<System.String, System.String> globalProperties, string toolsVersion, string subToolsetVersion, Microsoft.Build.Evaluation.ProjectCollection projectCollection) { }
    public System.Collections.Generic.List<System.String> DefaultTargets { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Collections.Generic.List<System.String>); } }
    public string Directory { [System.Diagnostics.DebuggerStepThroughAttribute]get { return default(string); } }
    public string FullPath { [System.Diagnostics.DebuggerStepThroughAttribute]get { return default(string); } }
    public System.Collections.Generic.IDictionary<System.String, System.String> GlobalProperties { [System.Diagnostics.DebuggerStepThroughAttribute]get { return default(System.Collections.Generic.IDictionary<System.String, System.String>); } }
    public System.Collections.Generic.List<System.String> InitialTargets { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Collections.Generic.List<System.String>); } }
    public bool IsImmutable { get { return default(bool); } }
    public System.Collections.Generic.IDictionary<System.String, Microsoft.Build.Execution.ProjectItemDefinitionInstance> ItemDefinitions { [System.Diagnostics.DebuggerStepThroughAttribute]get { return default(System.Collections.Generic.IDictionary<System.String, Microsoft.Build.Execution.ProjectItemDefinitionInstance>); } }
    public System.Collections.Generic.ICollection<Microsoft.Build.Execution.ProjectItemInstance> Items { [System.Diagnostics.DebuggerStepThroughAttribute]get { return default(System.Collections.Generic.ICollection<Microsoft.Build.Execution.ProjectItemInstance>); } }
    public System.Collections.Generic.ICollection<System.String> ItemTypes { [System.Diagnostics.DebuggerStepThroughAttribute]get { return default(System.Collections.Generic.ICollection<System.String>); } }
    public Microsoft.Build.Construction.ElementLocation ProjectFileLocation { get { return default(Microsoft.Build.Construction.ElementLocation); } }
    public System.Collections.Generic.ICollection<Microsoft.Build.Execution.ProjectPropertyInstance> Properties { [System.Diagnostics.DebuggerStepThroughAttribute]get { return default(System.Collections.Generic.ICollection<Microsoft.Build.Execution.ProjectPropertyInstance>); } }
    public System.Collections.Generic.IDictionary<System.String, Microsoft.Build.Execution.ProjectTargetInstance> Targets { [System.Diagnostics.DebuggerStepThroughAttribute]get { return default(System.Collections.Generic.IDictionary<System.String, Microsoft.Build.Execution.ProjectTargetInstance>); } }
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
    [System.Diagnostics.DebuggerStepThroughAttribute]
    public Microsoft.Build.Execution.ProjectPropertyInstance GetProperty(string name) { return default(Microsoft.Build.Execution.ProjectPropertyInstance); }
    public string GetPropertyValue(string name) { return default(string); }
    public static string GetPropertyValueEscaped(Microsoft.Build.Execution.ProjectPropertyInstance property) { return default(string); }
    public bool RemoveItem(Microsoft.Build.Execution.ProjectItemInstance item) { return default(bool); }
    public bool RemoveProperty(string name) { return default(bool); }
    public Microsoft.Build.Execution.ProjectPropertyInstance SetProperty(string name, string evaluatedValue) { return default(Microsoft.Build.Execution.ProjectPropertyInstance); }
    public Microsoft.Build.Construction.ProjectRootElement ToProjectRootElement() { return default(Microsoft.Build.Construction.ProjectRootElement); }
    public void UpdateStateFrom(Microsoft.Build.Execution.ProjectInstance projectState) { }
  }
  [System.FlagsAttribute]
  public enum ProjectInstanceSettings {
    Immutable = 1,
    ImmutableWithFastItemLookup = 3,
    None = 0,
  }
  [System.Diagnostics.DebuggerDisplayAttribute("{itemType} #Metadata={MetadataCount}")]
  public partial class ProjectItemDefinitionInstance {
    internal ProjectItemDefinitionInstance() { }
    [System.Diagnostics.DebuggerBrowsableAttribute((System.Diagnostics.DebuggerBrowsableState)(0))]
    public string ItemType { [System.Diagnostics.DebuggerStepThroughAttribute]get { return default(string); } }
    public System.Collections.Generic.ICollection<Microsoft.Build.Execution.ProjectMetadataInstance> Metadata { get { return default(System.Collections.Generic.ICollection<Microsoft.Build.Execution.ProjectMetadataInstance>); } }
    public int MetadataCount { get { return default(int); } }
    public System.Collections.Generic.IEnumerable<System.String> MetadataNames { [System.Runtime.CompilerServices.IteratorStateMachineAttribute(typeof(Microsoft.Build.Execution.ProjectItemDefinitionInstance.<get_MetadataNames>d__11))]get { return default(System.Collections.Generic.IEnumerable<System.String>); } }
    [System.Diagnostics.DebuggerStepThroughAttribute]
    public Microsoft.Build.Execution.ProjectMetadataInstance GetMetadata(string name) { return default(Microsoft.Build.Execution.ProjectMetadataInstance); }
  }
  [System.Diagnostics.DebuggerDisplayAttribute("Condition={condition}")]
  public partial class ProjectItemGroupTaskInstance : Microsoft.Build.Execution.ProjectTargetInstanceChild {
    internal ProjectItemGroupTaskInstance() { }
    public override string Condition { [System.Diagnostics.DebuggerStepThroughAttribute]get { return default(string); } }
    public override Microsoft.Build.Construction.ElementLocation ConditionLocation { get { return default(Microsoft.Build.Construction.ElementLocation); } }
    public System.Collections.Generic.ICollection<Microsoft.Build.Execution.ProjectItemGroupTaskItemInstance> Items { [System.Diagnostics.DebuggerStepThroughAttribute]get { return default(System.Collections.Generic.ICollection<Microsoft.Build.Execution.ProjectItemGroupTaskItemInstance>); } }
    public override Microsoft.Build.Construction.ElementLocation Location { get { return default(Microsoft.Build.Construction.ElementLocation); } }
  }
  [System.Diagnostics.DebuggerDisplayAttribute("{itemType} Include={include} Exclude={exclude} Remove={remove} Condition={condition}")]
  public partial class ProjectItemGroupTaskItemInstance {
    internal ProjectItemGroupTaskItemInstance() { }
    public string Condition { [System.Diagnostics.DebuggerStepThroughAttribute]get { return default(string); } }
    public Microsoft.Build.Construction.ElementLocation ConditionLocation { [System.Diagnostics.DebuggerStepThroughAttribute]get { return default(Microsoft.Build.Construction.ElementLocation); } }
    public string Exclude { [System.Diagnostics.DebuggerStepThroughAttribute]get { return default(string); } }
    public Microsoft.Build.Construction.ElementLocation ExcludeLocation { [System.Diagnostics.DebuggerStepThroughAttribute]get { return default(Microsoft.Build.Construction.ElementLocation); } }
    public string Include { [System.Diagnostics.DebuggerStepThroughAttribute]get { return default(string); } }
    public Microsoft.Build.Construction.ElementLocation IncludeLocation { [System.Diagnostics.DebuggerStepThroughAttribute]get { return default(Microsoft.Build.Construction.ElementLocation); } }
    public string ItemType { [System.Diagnostics.DebuggerStepThroughAttribute]get { return default(string); } }
    public string KeepDuplicates { [System.Diagnostics.DebuggerStepThroughAttribute]get { return default(string); } }
    public Microsoft.Build.Construction.ElementLocation KeepDuplicatesLocation { [System.Diagnostics.DebuggerStepThroughAttribute]get { return default(Microsoft.Build.Construction.ElementLocation); } }
    public string KeepMetadata { [System.Diagnostics.DebuggerStepThroughAttribute]get { return default(string); } }
    public Microsoft.Build.Construction.ElementLocation KeepMetadataLocation { [System.Diagnostics.DebuggerStepThroughAttribute]get { return default(Microsoft.Build.Construction.ElementLocation); } }
    public Microsoft.Build.Construction.ElementLocation Location { [System.Diagnostics.DebuggerStepThroughAttribute]get { return default(Microsoft.Build.Construction.ElementLocation); } }
    public System.Collections.Generic.ICollection<Microsoft.Build.Execution.ProjectItemGroupTaskMetadataInstance> Metadata { [System.Diagnostics.DebuggerStepThroughAttribute]get { return default(System.Collections.Generic.ICollection<Microsoft.Build.Execution.ProjectItemGroupTaskMetadataInstance>); } }
    public string Remove { [System.Diagnostics.DebuggerStepThroughAttribute]get { return default(string); } }
    public Microsoft.Build.Construction.ElementLocation RemoveLocation { [System.Diagnostics.DebuggerStepThroughAttribute]get { return default(Microsoft.Build.Construction.ElementLocation); } }
    public string RemoveMetadata { [System.Diagnostics.DebuggerStepThroughAttribute]get { return default(string); } }
    public Microsoft.Build.Construction.ElementLocation RemoveMetadataLocation { [System.Diagnostics.DebuggerStepThroughAttribute]get { return default(Microsoft.Build.Construction.ElementLocation); } }
  }
  [System.Diagnostics.DebuggerDisplayAttribute("{name} Value={value} Condition={condition}")]
  public partial class ProjectItemGroupTaskMetadataInstance {
    internal ProjectItemGroupTaskMetadataInstance() { }
    public string Condition { [System.Diagnostics.DebuggerStepThroughAttribute]get { return default(string); } }
    public Microsoft.Build.Construction.ElementLocation ConditionLocation { [System.Diagnostics.DebuggerStepThroughAttribute]get { return default(Microsoft.Build.Construction.ElementLocation); } }
    public Microsoft.Build.Construction.ElementLocation Location { [System.Diagnostics.DebuggerStepThroughAttribute]get { return default(Microsoft.Build.Construction.ElementLocation); } }
    public string Name { [System.Diagnostics.DebuggerStepThroughAttribute]get { return default(string); } }
    public string Value { [System.Diagnostics.DebuggerStepThroughAttribute]get { return default(string); } }
  }
  [System.Diagnostics.DebuggerDisplayAttribute("{ItemType}={EvaluatedInclude} #DirectMetadata={DirectMetadataCount})")]
  public partial class ProjectItemInstance : Microsoft.Build.Framework.ITaskItem, Microsoft.Build.Framework.ITaskItem2 {
    internal ProjectItemInstance() { }
    public int DirectMetadataCount { get { return default(int); } }
    public string EvaluatedInclude { [System.Diagnostics.DebuggerStepThroughAttribute]get { return default(string); } [System.Diagnostics.DebuggerStepThroughAttribute]set { } }
    [System.Diagnostics.DebuggerBrowsableAttribute((System.Diagnostics.DebuggerBrowsableState)(0))]
    public string ItemType { [System.Diagnostics.DebuggerStepThroughAttribute]get { return default(string); } }
    public System.Collections.Generic.IEnumerable<Microsoft.Build.Execution.ProjectMetadataInstance> Metadata { get { return default(System.Collections.Generic.IEnumerable<Microsoft.Build.Execution.ProjectMetadataInstance>); } }
    public int MetadataCount { get { return default(int); } }
    public System.Collections.Generic.ICollection<System.String> MetadataNames { get { return default(System.Collections.Generic.ICollection<System.String>); } }
    string Microsoft.Build.Framework.ITaskItem.ItemSpec { get { return default(string); } set { } }
    System.Collections.ICollection Microsoft.Build.Framework.ITaskItem.MetadataNames { get { return default(System.Collections.ICollection); } }
    string Microsoft.Build.Framework.ITaskItem2.EvaluatedIncludeEscaped { [System.Diagnostics.DebuggerStepThroughAttribute]get { return default(string); } set { } }
    [System.Diagnostics.DebuggerBrowsableAttribute((System.Diagnostics.DebuggerBrowsableState)(0))]
    public Microsoft.Build.Execution.ProjectInstance Project { get { return default(Microsoft.Build.Execution.ProjectInstance); } }
    public Microsoft.Build.Execution.ProjectMetadataInstance GetMetadata(string name) { return default(Microsoft.Build.Execution.ProjectMetadataInstance); }
    public string GetMetadataValue(string name) { return default(string); }
    public bool HasMetadata(string name) { return default(bool); }
    System.Collections.IDictionary Microsoft.Build.Framework.ITaskItem.CloneCustomMetadata() { return default(System.Collections.IDictionary); }
    void Microsoft.Build.Framework.ITaskItem.CopyMetadataTo(Microsoft.Build.Framework.ITaskItem destinationItem) { }
    string Microsoft.Build.Framework.ITaskItem.GetMetadata(string metadataName) { return default(string); }
    void Microsoft.Build.Framework.ITaskItem.SetMetadata(string metadataName, string metadataValue) { }
    System.Collections.IDictionary Microsoft.Build.Framework.ITaskItem2.CloneCustomMetadataEscaped() { return default(System.Collections.IDictionary); }
    string Microsoft.Build.Framework.ITaskItem2.GetMetadataValueEscaped(string name) { return default(string); }
    void Microsoft.Build.Framework.ITaskItem2.SetMetadataValueLiteral(string metadataName, string metadataValue) { }
    public void RemoveMetadata(string metadataName) { }
    public void SetMetadata(System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.String>> metadataDictionary) { }
    public Microsoft.Build.Execution.ProjectMetadataInstance SetMetadata(string name, string evaluatedValue) { return default(Microsoft.Build.Execution.ProjectMetadataInstance); }
    public override string ToString() { return default(string); }
  }
  [System.Diagnostics.DebuggerDisplayAttribute("{name}={EvaluatedValue}")]
  public partial class ProjectMetadataInstance : System.IEquatable<Microsoft.Build.Execution.ProjectMetadataInstance> {
    internal ProjectMetadataInstance() { }
    public string EvaluatedValue { [System.Diagnostics.DebuggerStepThroughAttribute]get { return default(string); } }
    [System.Diagnostics.DebuggerBrowsableAttribute((System.Diagnostics.DebuggerBrowsableState)(0))]
    public string Name { [System.Diagnostics.DebuggerStepThroughAttribute]get { return default(string); } }
    public Microsoft.Build.Execution.ProjectMetadataInstance DeepClone() { return default(Microsoft.Build.Execution.ProjectMetadataInstance); }
    bool System.IEquatable<Microsoft.Build.Execution.ProjectMetadataInstance>.Equals(Microsoft.Build.Execution.ProjectMetadataInstance other) { return default(bool); }
    public override string ToString() { return default(string); }
  }
  [System.Diagnostics.DebuggerDisplayAttribute("ExecuteTargets={executeTargets} Condition={condition}")]
  public sealed partial class ProjectOnErrorInstance : Microsoft.Build.Execution.ProjectTargetInstanceChild {
    internal ProjectOnErrorInstance() { }
    public override string Condition { get { return default(string); } }
    public override Microsoft.Build.Construction.ElementLocation ConditionLocation { get { return default(Microsoft.Build.Construction.ElementLocation); } }
    public string ExecuteTargets { get { return default(string); } }
    public Microsoft.Build.Construction.ElementLocation ExecuteTargetsLocation { get { return default(Microsoft.Build.Construction.ElementLocation); } }
    public override Microsoft.Build.Construction.ElementLocation Location { get { return default(Microsoft.Build.Construction.ElementLocation); } }
  }
  [System.Diagnostics.DebuggerDisplayAttribute("Condition={condition}")]
  public partial class ProjectPropertyGroupTaskInstance : Microsoft.Build.Execution.ProjectTargetInstanceChild {
    internal ProjectPropertyGroupTaskInstance() { }
    public override string Condition { [System.Diagnostics.DebuggerStepThroughAttribute]get { return default(string); } }
    public override Microsoft.Build.Construction.ElementLocation ConditionLocation { get { return default(Microsoft.Build.Construction.ElementLocation); } }
    public override Microsoft.Build.Construction.ElementLocation Location { get { return default(Microsoft.Build.Construction.ElementLocation); } }
    public System.Collections.Generic.ICollection<Microsoft.Build.Execution.ProjectPropertyGroupTaskPropertyInstance> Properties { [System.Diagnostics.DebuggerStepThroughAttribute]get { return default(System.Collections.Generic.ICollection<Microsoft.Build.Execution.ProjectPropertyGroupTaskPropertyInstance>); } }
  }
  [System.Diagnostics.DebuggerDisplayAttribute("{name}={Value} Condition={condition}")]
  public partial class ProjectPropertyGroupTaskPropertyInstance {
    internal ProjectPropertyGroupTaskPropertyInstance() { }
    public string Condition { [System.Diagnostics.DebuggerStepThroughAttribute]get { return default(string); } }
    public Microsoft.Build.Construction.ElementLocation ConditionLocation { get { return default(Microsoft.Build.Construction.ElementLocation); } }
    public Microsoft.Build.Construction.ElementLocation Location { get { return default(Microsoft.Build.Construction.ElementLocation); } }
    public string Name { [System.Diagnostics.DebuggerStepThroughAttribute]get { return default(string); } }
    public string Value { [System.Diagnostics.DebuggerStepThroughAttribute]get { return default(string); } }
  }
  [System.Diagnostics.DebuggerDisplayAttribute("{name}={escapedValue}")]
  public partial class ProjectPropertyInstance : System.IEquatable<Microsoft.Build.Execution.ProjectPropertyInstance> {
    internal ProjectPropertyInstance() { }
    public string EvaluatedValue { [System.Diagnostics.DebuggerStepThroughAttribute]get { return default(string); } [System.Diagnostics.DebuggerStepThroughAttribute]set { } }
    public virtual bool IsImmutable { get { return default(bool); } }
    [System.Diagnostics.DebuggerBrowsableAttribute((System.Diagnostics.DebuggerBrowsableState)(0))]
    public string Name { [System.Diagnostics.DebuggerStepThroughAttribute]get { return default(string); } }
    bool System.IEquatable<Microsoft.Build.Execution.ProjectPropertyInstance>.Equals(Microsoft.Build.Execution.ProjectPropertyInstance other) { return default(bool); }
    public override string ToString() { return default(string); }
  }
  [System.Diagnostics.DebuggerDisplayAttribute("Name={name} Count={children.Count} Condition={condition} Inputs={inputs} Outputs={outputs} DependsOnTargets={dependsOnTargets}")]
  public sealed partial class ProjectTargetInstance {
    internal ProjectTargetInstance() { }
    public Microsoft.Build.Construction.ElementLocation AfterTargetsLocation { [System.Diagnostics.DebuggerStepThroughAttribute]get { return default(Microsoft.Build.Construction.ElementLocation); } }
    public Microsoft.Build.Construction.ElementLocation BeforeTargetsLocation { [System.Diagnostics.DebuggerStepThroughAttribute]get { return default(Microsoft.Build.Construction.ElementLocation); } }
    public System.Collections.Generic.IList<Microsoft.Build.Execution.ProjectTargetInstanceChild> Children { [System.Diagnostics.DebuggerStepThroughAttribute]get { return default(System.Collections.Generic.IList<Microsoft.Build.Execution.ProjectTargetInstanceChild>); } }
    public string Condition { [System.Diagnostics.DebuggerStepThroughAttribute]get { return default(string); } }
    public Microsoft.Build.Construction.ElementLocation ConditionLocation { [System.Diagnostics.DebuggerStepThroughAttribute]get { return default(Microsoft.Build.Construction.ElementLocation); } }
    public string DependsOnTargets { [System.Diagnostics.DebuggerStepThroughAttribute]get { return default(string); } }
    public Microsoft.Build.Construction.ElementLocation DependsOnTargetsLocation { [System.Diagnostics.DebuggerStepThroughAttribute]get { return default(Microsoft.Build.Construction.ElementLocation); } }
    public string FullPath { get { return default(string); } }
    public string Inputs { [System.Diagnostics.DebuggerStepThroughAttribute]get { return default(string); } }
    public Microsoft.Build.Construction.ElementLocation InputsLocation { [System.Diagnostics.DebuggerStepThroughAttribute]get { return default(Microsoft.Build.Construction.ElementLocation); } }
    public string KeepDuplicateOutputs { [System.Diagnostics.DebuggerStepThroughAttribute]get { return default(string); } }
    public Microsoft.Build.Construction.ElementLocation KeepDuplicateOutputsLocation { [System.Diagnostics.DebuggerStepThroughAttribute]get { return default(Microsoft.Build.Construction.ElementLocation); } }
    public Microsoft.Build.Construction.ElementLocation Location { [System.Diagnostics.DebuggerStepThroughAttribute]get { return default(Microsoft.Build.Construction.ElementLocation); } }
    public string Name { [System.Diagnostics.DebuggerStepThroughAttribute]get { return default(string); } }
    public System.Collections.Generic.IList<Microsoft.Build.Execution.ProjectOnErrorInstance> OnErrorChildren { [System.Diagnostics.DebuggerStepThroughAttribute]get { return default(System.Collections.Generic.IList<Microsoft.Build.Execution.ProjectOnErrorInstance>); } }
    public string Outputs { [System.Diagnostics.DebuggerStepThroughAttribute]get { return default(string); } }
    public Microsoft.Build.Construction.ElementLocation OutputsLocation { [System.Diagnostics.DebuggerStepThroughAttribute]get { return default(Microsoft.Build.Construction.ElementLocation); } }
    public string Returns { [System.Diagnostics.DebuggerStepThroughAttribute]get { return default(string); } }
    public Microsoft.Build.Construction.ElementLocation ReturnsLocation { [System.Diagnostics.DebuggerStepThroughAttribute]get { return default(Microsoft.Build.Construction.ElementLocation); } }
    public System.Collections.Generic.ICollection<Microsoft.Build.Execution.ProjectTaskInstance> Tasks { get { return default(System.Collections.Generic.ICollection<Microsoft.Build.Execution.ProjectTaskInstance>); } }
  }
  public abstract partial class ProjectTargetInstanceChild {
    protected ProjectTargetInstanceChild() { }
    public abstract string Condition { get; }
    public abstract Microsoft.Build.Construction.ElementLocation ConditionLocation { get; }
    public string FullPath { get { return default(string); } }
    public abstract Microsoft.Build.Construction.ElementLocation Location { get; }
  }
  [System.Diagnostics.DebuggerDisplayAttribute("Name={name} Condition={condition} ContinueOnError={continueOnError} MSBuildRuntime={MSBuildRuntime} MSBuildArchitecture={MSBuildArchitecture} #Parameters={parameters.Count} #Outputs={outputs.Count}")]
  public sealed partial class ProjectTaskInstance : Microsoft.Build.Execution.ProjectTargetInstanceChild {
    internal ProjectTaskInstance() { }
    public override string Condition { get { return default(string); } }
    public override Microsoft.Build.Construction.ElementLocation ConditionLocation { get { return default(Microsoft.Build.Construction.ElementLocation); } }
    public string ContinueOnError { get { return default(string); } }
    public Microsoft.Build.Construction.ElementLocation ContinueOnErrorLocation { get { return default(Microsoft.Build.Construction.ElementLocation); } }
    public override Microsoft.Build.Construction.ElementLocation Location { get { return default(Microsoft.Build.Construction.ElementLocation); } }
    public string MSBuildArchitecture { get { return default(string); } }
    public Microsoft.Build.Construction.ElementLocation MSBuildArchitectureLocation { get { return default(Microsoft.Build.Construction.ElementLocation); } }
    public string MSBuildRuntime { get { return default(string); } }
    public Microsoft.Build.Construction.ElementLocation MSBuildRuntimeLocation { get { return default(Microsoft.Build.Construction.ElementLocation); } }
    public string Name { get { return default(string); } }
    public System.Collections.Generic.IList<Microsoft.Build.Execution.ProjectTaskInstanceChild> Outputs { get { return default(System.Collections.Generic.IList<Microsoft.Build.Execution.ProjectTaskInstanceChild>); } }
    public System.Collections.Generic.IDictionary<System.String, System.String> Parameters { get { return default(System.Collections.Generic.IDictionary<System.String, System.String>); } }
  }
  public abstract partial class ProjectTaskInstanceChild {
    protected ProjectTaskInstanceChild() { }
    public abstract string Condition { get; }
    public abstract Microsoft.Build.Construction.ElementLocation ConditionLocation { get; }
    public abstract Microsoft.Build.Construction.ElementLocation Location { get; }
    public abstract Microsoft.Build.Construction.ElementLocation TaskParameterLocation { get; }
  }
  public sealed partial class ProjectTaskOutputItemInstance : Microsoft.Build.Execution.ProjectTaskInstanceChild {
    internal ProjectTaskOutputItemInstance() { }
    public override string Condition { get { return default(string); } }
    public override Microsoft.Build.Construction.ElementLocation ConditionLocation { get { return default(Microsoft.Build.Construction.ElementLocation); } }
    public string ItemType { get { return default(string); } }
    public Microsoft.Build.Construction.ElementLocation ItemTypeLocation { get { return default(Microsoft.Build.Construction.ElementLocation); } }
    public override Microsoft.Build.Construction.ElementLocation Location { get { return default(Microsoft.Build.Construction.ElementLocation); } }
    public string TaskParameter { get { return default(string); } }
    public override Microsoft.Build.Construction.ElementLocation TaskParameterLocation { get { return default(Microsoft.Build.Construction.ElementLocation); } }
  }
  public sealed partial class ProjectTaskOutputPropertyInstance : Microsoft.Build.Execution.ProjectTaskInstanceChild {
    internal ProjectTaskOutputPropertyInstance() { }
    public override string Condition { get { return default(string); } }
    public override Microsoft.Build.Construction.ElementLocation ConditionLocation { get { return default(Microsoft.Build.Construction.ElementLocation); } }
    public override Microsoft.Build.Construction.ElementLocation Location { get { return default(Microsoft.Build.Construction.ElementLocation); } }
    public string PropertyName { get { return default(string); } }
    public Microsoft.Build.Construction.ElementLocation PropertyNameLocation { get { return default(Microsoft.Build.Construction.ElementLocation); } }
    public string TaskParameter { get { return default(string); } }
    public override Microsoft.Build.Construction.ElementLocation TaskParameterLocation { get { return default(Microsoft.Build.Construction.ElementLocation); } }
  }
  public partial class TargetResult : Microsoft.Build.Execution.ITargetResult {
    internal TargetResult() { }
    public System.Exception Exception { [System.Diagnostics.DebuggerStepThroughAttribute]get { return default(System.Exception); } }
    public Microsoft.Build.Framework.ITaskItem[] Items { [System.Diagnostics.DebuggerStepThroughAttribute]get { return default(Microsoft.Build.Framework.ITaskItem[]); } }
    public Microsoft.Build.Execution.TargetResultCode ResultCode { [System.Diagnostics.DebuggerStepThroughAttribute]get { return default(Microsoft.Build.Execution.TargetResultCode); } }
  }
  public enum TargetResultCode : byte {
    Failure = (byte)2,
    Skipped = (byte)0,
    Success = (byte)1,
  }
}
namespace Microsoft.Build.Logging {
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
    public ConsoleLogger(Microsoft.Build.Framework.LoggerVerbosity verbosity, Microsoft.Build.Logging.WriteHandler write, Microsoft.Build.Logging.ColorSetter colorSet, Microsoft.Build.Logging.ColorResetter colorReset) { }
    public string Parameters { get { return default(string); } set { } }
    public bool ShowSummary { get { return default(bool); } set { } }
    public bool SkipProjectStartedText { get { return default(bool); } set { } }
    public Microsoft.Build.Framework.LoggerVerbosity Verbosity { get { return default(Microsoft.Build.Framework.LoggerVerbosity); } set { } }
    protected Microsoft.Build.Logging.WriteHandler WriteHandler { get { return default(Microsoft.Build.Logging.WriteHandler); } set { } }
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
  public partial class FileLogger : Microsoft.Build.Logging.ConsoleLogger {
    public FileLogger() { }
    public override void Initialize(Microsoft.Build.Framework.IEventSource eventSource) { }
    public override void Initialize(Microsoft.Build.Framework.IEventSource eventSource, int nodeCount) { }
    public override void Shutdown() { }
  }
  public partial class ForwardingLoggerRecord {
    public ForwardingLoggerRecord(Microsoft.Build.Framework.ILogger centralLogger, Microsoft.Build.Logging.LoggerDescription forwardingLoggerDescription) { }
    public Microsoft.Build.Framework.ILogger CentralLogger { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(Microsoft.Build.Framework.ILogger); } }
    public Microsoft.Build.Logging.LoggerDescription ForwardingLoggerDescription { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(Microsoft.Build.Logging.LoggerDescription); } }
  }
  public partial class LoggerDescription {
    public LoggerDescription(string loggerClassName, string loggerAssemblyName, string loggerAssemblyFile, string loggerSwitchParameters, Microsoft.Build.Framework.LoggerVerbosity verbosity) { }
    public string LoggerSwitchParameters { get { return default(string); } }
    public Microsoft.Build.Framework.LoggerVerbosity Verbosity { get { return default(Microsoft.Build.Framework.LoggerVerbosity); } }
    public Microsoft.Build.Framework.ILogger CreateLogger() { return default(Microsoft.Build.Framework.ILogger); }
  }
  public delegate void WriteHandler(string message);
}
