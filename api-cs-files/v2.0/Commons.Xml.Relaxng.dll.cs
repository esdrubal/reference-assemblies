namespace Commons.Xml {
  public partial class XmlDefaultReader : System.Xml.XmlReader, System.Xml.IXmlLineInfo {
    public XmlDefaultReader(System.Xml.XmlReader reader) { }
    public override int AttributeCount { get { return default(int); } }
    public override string BaseURI { get { return default(string); } }
    public override int Depth { get { return default(int); } }
    public override bool EOF { get { return default(bool); } }
    public override bool HasValue { get { return default(bool); } }
    public override bool IsDefault { get { return default(bool); } }
    public override bool IsEmptyElement { get { return default(bool); } }
    public override string this[int i] { get { return default(string); } }
    public override string this[string name] { get { return default(string); } }
    public override string this[string localName, string namespaceURI] { get { return default(string); } }
    public int LineNumber { get { return default(int); } }
    public int LinePosition { get { return default(int); } }
    public override string LocalName { get { return default(string); } }
    public override string Name { get { return default(string); } }
    public override string NamespaceURI { get { return default(string); } }
    public override System.Xml.XmlNameTable NameTable { get { return default(System.Xml.XmlNameTable); } }
    public override System.Xml.XmlNodeType NodeType { get { return default(System.Xml.XmlNodeType); } }
    public override string Prefix { get { return default(string); } }
    public override char QuoteChar { get { return default(char); } }
    public System.Xml.XmlReader Reader { get { return default(System.Xml.XmlReader); } }
    public override System.Xml.ReadState ReadState { get { return default(System.Xml.ReadState); } }
    public override string Value { get { return default(string); } }
    public override string XmlLang { get { return default(string); } }
    public override System.Xml.XmlSpace XmlSpace { get { return default(System.Xml.XmlSpace); } }
    public override void Close() { }
    public override string GetAttribute(int i) { return default(string); }
    public override string GetAttribute(string name) { return default(string); }
    public override string GetAttribute(string localName, string namespaceURI) { return default(string); }
    public bool HasLineInfo() { return default(bool); }
    public override string LookupNamespace(string prefix) { return default(string); }
    public override void MoveToAttribute(int i) { }
    public override bool MoveToAttribute(string name) { return default(bool); }
    public override bool MoveToAttribute(string localName, string namespaceURI) { return default(bool); }
    public override bool MoveToElement() { return default(bool); }
    public override bool MoveToFirstAttribute() { return default(bool); }
    public override bool MoveToNextAttribute() { return default(bool); }
    public override bool Read() { return default(bool); }
    public override bool ReadAttributeValue() { return default(bool); }
    public override void ResolveEntity() { }
  }
}
namespace Commons.Xml.Nvdl {
  public partial class Nvdl {
    internal Nvdl() { }
    public const string BuiltInValidationNamespace = "http://purl.oclc.org/dsdl/nvdl/ns/predefinedSchema/1.0";
    public const string InstanceNamespace = "http://purl.oclc.org/dsdl/nvdl/ns/instance/1.0";
    public const string Namespace = "http://purl.oclc.org/dsdl/nvdl/ns/structure/1.0";
  }
  public abstract partial class NvdlAction : Commons.Xml.Nvdl.NvdlAttributable {
    protected NvdlAction() { }
  }
  public partial class NvdlActionList : System.Collections.CollectionBase {
    public NvdlActionList() { }
    public Commons.Xml.Nvdl.NvdlAction this[int i] { get { return default(Commons.Xml.Nvdl.NvdlAction); } set { } }
    public void Add(Commons.Xml.Nvdl.NvdlAction item) { }
    public void Remove(Commons.Xml.Nvdl.NvdlAction item) { }
  }
  public partial class NvdlAllow : Commons.Xml.Nvdl.NvdlNoResultAction {
    public NvdlAllow() { }
  }
  public partial class NvdlAnyNamespace : Commons.Xml.Nvdl.NvdlRule {
    public NvdlAnyNamespace() { }
  }
  public partial class NvdlAttach : Commons.Xml.Nvdl.NvdlResultAction {
    public NvdlAttach() { }
    public override Commons.Xml.Nvdl.NvdlResultType ResultType { get { return default(Commons.Xml.Nvdl.NvdlResultType); } }
  }
  public partial class NvdlAttachPlaceholder : Commons.Xml.Nvdl.NvdlResultAction {
    public NvdlAttachPlaceholder() { }
    public override Commons.Xml.Nvdl.NvdlResultType ResultType { get { return default(Commons.Xml.Nvdl.NvdlResultType); } }
  }
  public partial class NvdlAttributable : Commons.Xml.Nvdl.NvdlElementBase {
    public NvdlAttributable() { }
    public System.Collections.ArrayList Foreign { get { return default(System.Collections.ArrayList); } }
  }
  public partial class NvdlBuiltInValidationProvider : Commons.Xml.Nvdl.NvdlValidationProvider {
    public NvdlBuiltInValidationProvider() { }
    public override Commons.Xml.Nvdl.NvdlValidatorGenerator CreateGenerator(System.Xml.XmlReader reader, Commons.Xml.Nvdl.NvdlConfig config) { return default(Commons.Xml.Nvdl.NvdlValidatorGenerator); }
  }
  public partial class NvdlCancelAction : Commons.Xml.Nvdl.NvdlAction {
    public NvdlCancelAction() { }
  }
  public partial class NvdlCompileException : Commons.Xml.Nvdl.NvdlException {
    public NvdlCompileException(string message, System.Exception inner, System.Xml.IXmlLineInfo source) : base (default(string)) { }
    public NvdlCompileException(string message, System.Xml.IXmlLineInfo source) : base (default(string)) { }
  }
  public partial class NvdlConfig {
    public NvdlConfig() { }
    public System.Xml.XmlResolver XmlResolver { set { } }
    public void AddProvider(Commons.Xml.Nvdl.NvdlValidationProvider provider) { }
    public Commons.Xml.Nvdl.NvdlValidatorGenerator GetGenerator(Commons.Xml.Nvdl.NvdlValidate validate, string inheritSchemaType) { return default(Commons.Xml.Nvdl.NvdlValidatorGenerator); }
  }
  public partial class NvdlContext : Commons.Xml.Nvdl.NvdlAttributable {
    public NvdlContext() { }
    public Commons.Xml.Nvdl.NvdlNestedMode NestedMode { get { return default(Commons.Xml.Nvdl.NvdlNestedMode); } set { } }
    public string Path { get { return default(string); } set { } }
    public string UseMode { get { return default(string); } set { } }
  }
  public partial class NvdlContextList : System.Collections.CollectionBase {
    public NvdlContextList() { }
    public Commons.Xml.Nvdl.NvdlContext this[int i] { get { return default(Commons.Xml.Nvdl.NvdlContext); } set { } }
    public void Add(Commons.Xml.Nvdl.NvdlContext item) { }
    public void Remove(Commons.Xml.Nvdl.NvdlContext item) { }
  }
  public partial class NvdlElementBase : System.Xml.IXmlLineInfo {
    public NvdlElementBase() { }
    public int LineNumber { get { return default(int); } set { } }
    public int LinePosition { get { return default(int); } set { } }
    public string SourceUri { get { return default(string); } set { } }
    public bool HasLineInfo() { return default(bool); }
  }
  public partial class NvdlException : System.Exception {
    public NvdlException(string message) { }
    public NvdlException(string message, System.Exception inner) { }
  }
  public partial class NvdlIncludedMode : Commons.Xml.Nvdl.NvdlModeBase {
    public NvdlIncludedMode() { }
    public string Name { get { return default(string); } set { } }
  }
  public partial class NvdlInstanceValidationException : Commons.Xml.Nvdl.NvdlException {
    public NvdlInstanceValidationException(string message, Commons.Xml.Nvdl.NvdlValidatorGenerator generator, string nvdlLocation) : base (default(string)) { }
    public NvdlInstanceValidationException(string message, System.Exception inner, Commons.Xml.Nvdl.NvdlValidatorGenerator generator, string nvdlLocation) : base (default(string)) { }
  }
  public partial class NvdlMessage : Commons.Xml.Nvdl.NvdlElementBase {
    public NvdlMessage() { }
    public System.Collections.ArrayList ForeignAttributes { get { return default(System.Collections.ArrayList); } }
    public string Text { get { return default(string); } set { } }
    public string XmlLang { get { return default(string); } set { } }
  }
  public partial class NvdlMessageEventArgs : System.EventArgs {
    public NvdlMessageEventArgs(string message) { }
    public string Message { get { return default(string); } }
  }
  public delegate void NvdlMessageEventHandler(object o, Commons.Xml.Nvdl.NvdlMessageEventArgs e);
  public partial class NvdlMessageList : System.Collections.CollectionBase {
    public NvdlMessageList() { }
    public Commons.Xml.Nvdl.NvdlMessage this[int i] { get { return default(Commons.Xml.Nvdl.NvdlMessage); } set { } }
    public void Add(Commons.Xml.Nvdl.NvdlMessage item) { }
    public void Remove(Commons.Xml.Nvdl.NvdlMessage item) { }
  }
  public partial class NvdlMode : Commons.Xml.Nvdl.NvdlModeBase {
    public NvdlMode() { }
    public string Name { get { return default(string); } set { } }
  }
  public abstract partial class NvdlModeBase : Commons.Xml.Nvdl.NvdlAttributable {
    protected NvdlModeBase() { }
    public Commons.Xml.Nvdl.NvdlModeList IncludedModes { get { return default(Commons.Xml.Nvdl.NvdlModeList); } }
    public Commons.Xml.Nvdl.NvdlRuleList Rules { get { return default(Commons.Xml.Nvdl.NvdlRuleList); } }
  }
  public partial class NvdlModeList : System.Collections.CollectionBase {
    public NvdlModeList() { }
    public Commons.Xml.Nvdl.NvdlModeBase this[int i] { get { return default(Commons.Xml.Nvdl.NvdlModeBase); } set { } }
    public void Add(Commons.Xml.Nvdl.NvdlModeBase item) { }
    public void Remove(Commons.Xml.Nvdl.NvdlModeBase item) { }
  }
  public partial class NvdlModeUsage {
    public NvdlModeUsage() { }
    public Commons.Xml.Nvdl.NvdlContextList Contexts { get { return default(Commons.Xml.Nvdl.NvdlContextList); } }
    public Commons.Xml.Nvdl.NvdlNestedMode NestedMode { get { return default(Commons.Xml.Nvdl.NvdlNestedMode); } set { } }
    public string UseMode { get { return default(string); } set { } }
  }
  public partial class NvdlNamespace : Commons.Xml.Nvdl.NvdlRule {
    public NvdlNamespace() { }
    public string NS { get { return default(string); } set { } }
    public string Wildcard { get { return default(string); } set { } }
  }
  public partial class NvdlNestedMode : Commons.Xml.Nvdl.NvdlModeBase {
    public NvdlNestedMode() { }
  }
  public abstract partial class NvdlNoCancelAction : Commons.Xml.Nvdl.NvdlAction {
    protected NvdlNoCancelAction() { }
    public Commons.Xml.Nvdl.NvdlMessageList Messages { get { return default(Commons.Xml.Nvdl.NvdlMessageList); } }
    public Commons.Xml.Nvdl.NvdlModeUsage ModeUsage { get { return default(Commons.Xml.Nvdl.NvdlModeUsage); } set { } }
    public string SimpleMessage { get { return default(string); } set { } }
  }
  public abstract partial class NvdlNoResultAction : Commons.Xml.Nvdl.NvdlNoCancelAction {
    protected NvdlNoResultAction() { }
  }
  public partial class NvdlOption : Commons.Xml.Nvdl.NvdlAttributable {
    public NvdlOption() { }
    public string Arg { get { return default(string); } set { } }
    public string MustSupport { get { return default(string); } set { } }
    public string Name { get { return default(string); } set { } }
  }
  public partial class NvdlOptionList : System.Collections.CollectionBase {
    public NvdlOptionList() { }
    public Commons.Xml.Nvdl.NvdlOption this[int i] { get { return default(Commons.Xml.Nvdl.NvdlOption); } set { } }
    public void Add(Commons.Xml.Nvdl.NvdlOption item) { }
    public void Remove(Commons.Xml.Nvdl.NvdlOption item) { }
  }
  public partial class NvdlReader {
    internal NvdlReader() { }
    public static Commons.Xml.Nvdl.NvdlRules Read(System.Xml.XmlReader reader) { return default(Commons.Xml.Nvdl.NvdlRules); }
  }
  public partial class NvdlReject : Commons.Xml.Nvdl.NvdlNoResultAction {
    public NvdlReject() { }
  }
  public partial class NvdlRelaxngValidatorProvider : Commons.Xml.Nvdl.NvdlValidationProvider {
    public const string RncMimeType = "application/vnd.oasis-open.relax-ng.rnc";
    public NvdlRelaxngValidatorProvider() { }
    public override Commons.Xml.Nvdl.NvdlValidatorGenerator CreateGenerator(Commons.Xml.Nvdl.NvdlValidate validate, string schemaType, Commons.Xml.Nvdl.NvdlConfig config) { return default(Commons.Xml.Nvdl.NvdlValidatorGenerator); }
    public override Commons.Xml.Nvdl.NvdlValidatorGenerator CreateGenerator(System.Xml.XmlReader reader, Commons.Xml.Nvdl.NvdlConfig config) { return default(Commons.Xml.Nvdl.NvdlValidatorGenerator); }
  }
  public abstract partial class NvdlResultAction : Commons.Xml.Nvdl.NvdlNoCancelAction {
    protected NvdlResultAction() { }
    public abstract Commons.Xml.Nvdl.NvdlResultType ResultType { get; }
  }
  public enum NvdlResultType {
    Attach = 0,
    AttachPlaceholder = 1,
    Unwrap = 2,
  }
  public abstract partial class NvdlRule : Commons.Xml.Nvdl.NvdlAttributable {
    protected NvdlRule() { }
    public Commons.Xml.Nvdl.NvdlActionList Actions { get { return default(Commons.Xml.Nvdl.NvdlActionList); } }
    public Commons.Xml.Nvdl.NvdlRuleTarget Match { get { return default(Commons.Xml.Nvdl.NvdlRuleTarget); } set { } }
  }
  public partial class NvdlRuleList : System.Collections.CollectionBase {
    public NvdlRuleList() { }
    public Commons.Xml.Nvdl.NvdlRule this[int i] { get { return default(Commons.Xml.Nvdl.NvdlRule); } set { } }
    public void Add(Commons.Xml.Nvdl.NvdlRule item) { }
    public void Remove(Commons.Xml.Nvdl.NvdlRule item) { }
  }
  public partial class NvdlRules : Commons.Xml.Nvdl.NvdlAttributable {
    public NvdlRules() { }
    public Commons.Xml.Nvdl.NvdlModeList Modes { get { return default(Commons.Xml.Nvdl.NvdlModeList); } }
    public Commons.Xml.Nvdl.NvdlRuleList Rules { get { return default(Commons.Xml.Nvdl.NvdlRuleList); } }
    public string SchemaType { get { return default(string); } set { } }
    public string StartMode { get { return default(string); } set { } }
    public Commons.Xml.Nvdl.NvdlTriggerList Triggers { get { return default(Commons.Xml.Nvdl.NvdlTriggerList); } }
  }
  public enum NvdlRuleTarget {
    Attributes = 2,
    Both = 3,
    Elements = 1,
    None = 0,
  }
  public partial class NvdlTrigger : Commons.Xml.Nvdl.NvdlAttributable {
    public NvdlTrigger() { }
    public string NameList { get { return default(string); } set { } }
    public string NS { get { return default(string); } set { } }
  }
  public partial class NvdlTriggerList : System.Collections.CollectionBase {
    public NvdlTriggerList() { }
    public Commons.Xml.Nvdl.NvdlTrigger this[int i] { get { return default(Commons.Xml.Nvdl.NvdlTrigger); } set { } }
    public void Add(Commons.Xml.Nvdl.NvdlTrigger item) { }
    public void Remove(Commons.Xml.Nvdl.NvdlTrigger item) { }
  }
  public partial class NvdlUnwrap : Commons.Xml.Nvdl.NvdlResultAction {
    public NvdlUnwrap() { }
    public override Commons.Xml.Nvdl.NvdlResultType ResultType { get { return default(Commons.Xml.Nvdl.NvdlResultType); } }
  }
  public partial class NvdlValidate : Commons.Xml.Nvdl.NvdlNoResultAction {
    public NvdlValidate() { }
    public Commons.Xml.Nvdl.NvdlOptionList Options { get { return default(Commons.Xml.Nvdl.NvdlOptionList); } }
    public System.Xml.XmlElement SchemaBody { get { return default(System.Xml.XmlElement); } set { } }
    public string SchemaType { get { return default(string); } set { } }
    public string SchemaUri { get { return default(string); } set { } }
  }
  public partial class NvdlValidatingReader : Commons.Xml.XmlDefaultReader {
    public NvdlValidatingReader(System.Xml.XmlReader reader, Commons.Xml.Nvdl.NvdlRules rules) : base (default(System.Xml.XmlReader)) { }
    public NvdlValidatingReader(System.Xml.XmlReader reader, Commons.Xml.Nvdl.NvdlRules rules, System.Xml.XmlResolver resolver) : base (default(System.Xml.XmlReader)) { }
    public NvdlValidatingReader(System.Xml.XmlReader reader, Commons.Xml.Nvdl.NvdlRules rules, System.Xml.XmlResolver resolver, Commons.Xml.Nvdl.NvdlConfig config) : base (default(System.Xml.XmlReader)) { }
    public event Commons.Xml.Nvdl.NvdlMessageEventHandler ActionStarted { add { } remove { } }
    public override bool Read() { return default(bool); }
  }
  public partial class NvdlValidationException : Commons.Xml.Nvdl.NvdlException {
    public NvdlValidationException(string message, System.Exception inner, System.Xml.IXmlLineInfo source) : base (default(string)) { }
    public NvdlValidationException(string message, System.Xml.IXmlLineInfo source) : base (default(string)) { }
  }
  public partial class NvdlValidationProvider {
    public NvdlValidationProvider() { }
    public Commons.Xml.Nvdl.NvdlConfig Config { get { return default(Commons.Xml.Nvdl.NvdlConfig); } }
    public string SchemaType { get { return default(string); } }
    public Commons.Xml.Nvdl.NvdlValidate ValidateAction { get { return default(Commons.Xml.Nvdl.NvdlValidate); } }
    public virtual Commons.Xml.Nvdl.NvdlValidatorGenerator CreateGenerator(Commons.Xml.Nvdl.NvdlValidate validate, string schemaType, Commons.Xml.Nvdl.NvdlConfig config) { return default(Commons.Xml.Nvdl.NvdlValidatorGenerator); }
    public virtual Commons.Xml.Nvdl.NvdlValidatorGenerator CreateGenerator(System.Xml.XmlReader schema, Commons.Xml.Nvdl.NvdlConfig config) { return default(Commons.Xml.Nvdl.NvdlValidatorGenerator); }
    public string GetSchemaUri(Commons.Xml.Nvdl.NvdlValidate validate) { return default(string); }
  }
  public abstract partial class NvdlValidatorGenerator {
    protected NvdlValidatorGenerator() { }
    public abstract bool AddOption(string name, string arg);
    public virtual System.Xml.XmlReader CreateAttributeValidator(System.Xml.XmlReader reader, System.Xml.XmlResolver resolver) { return default(System.Xml.XmlReader); }
    public abstract System.Xml.XmlReader CreateValidator(System.Xml.XmlReader reader, System.Xml.XmlResolver resolver);
    public virtual bool HandleError(System.Exception ex, System.Xml.XmlReader reader, string nvdlLocation) { return default(bool); }
  }
  public partial class NvdlXsdValidatorProvider : Commons.Xml.Nvdl.NvdlValidationProvider {
    public NvdlXsdValidatorProvider() { }
    public override Commons.Xml.Nvdl.NvdlValidatorGenerator CreateGenerator(System.Xml.XmlReader reader, Commons.Xml.Nvdl.NvdlConfig config) { return default(Commons.Xml.Nvdl.NvdlValidatorGenerator); }
  }
}
namespace Commons.Xml.Relaxng {
  public partial interface IGrammarContent {
  }
  public partial class RelaxngAnyName : Commons.Xml.Relaxng.RelaxngNameClass {
    public RelaxngAnyName() { }
    public Commons.Xml.Relaxng.RelaxngExceptNameClass Except { get { return default(Commons.Xml.Relaxng.RelaxngExceptNameClass); } set { } }
    public override void Write(System.Xml.XmlWriter writer) { }
  }
  public partial class RelaxngAttribute : Commons.Xml.Relaxng.RelaxngPattern {
    public RelaxngAttribute() { }
    public Commons.Xml.Relaxng.RelaxngNameClass NameClass { get { return default(Commons.Xml.Relaxng.RelaxngNameClass); } set { } }
    public Commons.Xml.Relaxng.RelaxngPattern Pattern { get { return default(Commons.Xml.Relaxng.RelaxngPattern); } set { } }
    public override Commons.Xml.Relaxng.RelaxngPatternType PatternType { get { return default(Commons.Xml.Relaxng.RelaxngPatternType); } }
    public override void Write(System.Xml.XmlWriter writer) { }
  }
  public abstract partial class RelaxngBinaryContentPattern : Commons.Xml.Relaxng.RelaxngPattern {
    protected RelaxngBinaryContentPattern() { }
    public Commons.Xml.Relaxng.RelaxngPatternList Patterns { get { return default(Commons.Xml.Relaxng.RelaxngPatternList); } }
  }
  public partial class RelaxngChoice : Commons.Xml.Relaxng.RelaxngBinaryContentPattern {
    public RelaxngChoice() { }
    public override Commons.Xml.Relaxng.RelaxngPatternType PatternType { get { return default(Commons.Xml.Relaxng.RelaxngPatternType); } }
    public override void Write(System.Xml.XmlWriter writer) { }
  }
  public partial class RelaxngData : Commons.Xml.Relaxng.RelaxngDataSupport {
    public RelaxngData() { }
    public Commons.Xml.Relaxng.RelaxngExcept Except { get { return default(Commons.Xml.Relaxng.RelaxngExcept); } set { } }
    public Commons.Xml.Relaxng.RelaxngParamList ParamList { get { return default(Commons.Xml.Relaxng.RelaxngParamList); } }
    public override Commons.Xml.Relaxng.RelaxngPatternType PatternType { get { return default(Commons.Xml.Relaxng.RelaxngPatternType); } }
    public override void Write(System.Xml.XmlWriter writer) { }
  }
  public abstract partial class RelaxngDataSupport : Commons.Xml.Relaxng.RelaxngPattern {
    protected RelaxngDataSupport() { }
    public string DatatypeLibrary { get { return default(string); } set { } }
    public string Type { get { return default(string); } set { } }
  }
  public abstract partial class RelaxngDatatype {
    protected RelaxngDatatype() { }
    public abstract string Name { get; }
    public abstract string NamespaceURI { get; }
    public virtual bool Compare(object o1, object o2) { return default(bool); }
    public virtual bool CompareString(string s1, string s2, System.Xml.XmlReader reader) { return default(bool); }
    public virtual bool IsValid(string text, System.Xml.XmlReader reader) { return default(bool); }
    public abstract object Parse(string text, System.Xml.XmlReader reader);
  }
  public abstract partial class RelaxngDatatypeProvider {
    protected RelaxngDatatypeProvider() { }
    public abstract Commons.Xml.Relaxng.RelaxngDatatype GetDatatype(string name, string ns, Commons.Xml.Relaxng.RelaxngParamList parameters);
  }
  public partial class RelaxngDefine : Commons.Xml.Relaxng.RelaxngElementBase, Commons.Xml.Relaxng.IGrammarContent {
    public RelaxngDefine() { }
    public string Combine { get { return default(string); } set { } }
    public string Name { get { return default(string); } set { } }
    public Commons.Xml.Relaxng.RelaxngPatternList Patterns { get { return default(Commons.Xml.Relaxng.RelaxngPatternList); } }
    public override void Write(System.Xml.XmlWriter writer) { }
  }
  public partial class RelaxngDiv : Commons.Xml.Relaxng.RelaxngElementBase, Commons.Xml.Relaxng.IGrammarContent {
    public RelaxngDiv() { }
    public Commons.Xml.Relaxng.RelaxngGrammarContentList Defines { get { return default(Commons.Xml.Relaxng.RelaxngGrammarContentList); } }
    public Commons.Xml.Relaxng.RelaxngGrammarContentList Divs { get { return default(Commons.Xml.Relaxng.RelaxngGrammarContentList); } }
    public Commons.Xml.Relaxng.RelaxngGrammarContentList Includes { get { return default(Commons.Xml.Relaxng.RelaxngGrammarContentList); } }
    public Commons.Xml.Relaxng.RelaxngGrammarContentList Starts { get { return default(Commons.Xml.Relaxng.RelaxngGrammarContentList); } }
    public override void Write(System.Xml.XmlWriter writer) { }
  }
  public partial class RelaxngElement : Commons.Xml.Relaxng.RelaxngSingleContentPattern {
    public RelaxngElement() { }
    public Commons.Xml.Relaxng.RelaxngNameClass NameClass { get { return default(Commons.Xml.Relaxng.RelaxngNameClass); } set { } }
    public override Commons.Xml.Relaxng.RelaxngPatternType PatternType { get { return default(Commons.Xml.Relaxng.RelaxngPatternType); } }
    public override void Write(System.Xml.XmlWriter writer) { }
  }
  public abstract partial class RelaxngElementBase {
    protected RelaxngElementBase() { }
    public string BaseUri { get { return default(string); } set { } }
    public int LineNumber { get { return default(int); } set { } }
    public int LinePosition { get { return default(int); } set { } }
    public Commons.Xml.Relaxng.RelaxngPattern ReadExternalResource(Commons.Xml.Relaxng.RelaxngGrammar grammar, System.Uri uri, string nsContext) { return default(Commons.Xml.Relaxng.RelaxngPattern); }
    public abstract void Write(System.Xml.XmlWriter writer);
  }
  public partial class RelaxngEmpty : Commons.Xml.Relaxng.RelaxngPattern {
    public RelaxngEmpty() { }
    public override Commons.Xml.Relaxng.RelaxngPatternType PatternType { get { return default(Commons.Xml.Relaxng.RelaxngPatternType); } }
    public override void Write(System.Xml.XmlWriter writer) { }
  }
  public partial class RelaxngExcept : Commons.Xml.Relaxng.RelaxngElementBase {
    public RelaxngExcept() { }
    public Commons.Xml.Relaxng.RelaxngPatternList Patterns { get { return default(Commons.Xml.Relaxng.RelaxngPatternList); } }
    public override void Write(System.Xml.XmlWriter writer) { }
  }
  public partial class RelaxngException : System.Exception {
    public RelaxngException() { }
    public RelaxngException(Commons.Xml.Relaxng.RelaxngElementBase source, string message) { }
    public RelaxngException(Commons.Xml.Relaxng.RelaxngElementBase source, string message, System.Exception innerException) { }
    public RelaxngException(string message) { }
    public RelaxngException(string message, System.Exception innerException) { }
  }
  public partial class RelaxngExceptNameClass : Commons.Xml.Relaxng.RelaxngElementBase {
    public RelaxngExceptNameClass() { }
    public Commons.Xml.Relaxng.RelaxngNameClassList Names { get { return default(Commons.Xml.Relaxng.RelaxngNameClassList); } }
    public override void Write(System.Xml.XmlWriter writer) { }
  }
  public partial class RelaxngExternalRef : Commons.Xml.Relaxng.RelaxngPattern {
    public RelaxngExternalRef() { }
    public string Href { get { return default(string); } set { } }
    public string NSContext { get { return default(string); } set { } }
    public override Commons.Xml.Relaxng.RelaxngPatternType PatternType { get { return default(Commons.Xml.Relaxng.RelaxngPatternType); } }
    public override void Write(System.Xml.XmlWriter writer) { }
  }
  public partial class RelaxngGrammar : Commons.Xml.Relaxng.RelaxngPattern {
    public static string NamespaceURI;
    public RelaxngGrammar() { }
    public string DefaultNamespace { get { return default(string); } set { } }
    public Commons.Xml.Relaxng.RelaxngGrammarContentList Defines { get { return default(Commons.Xml.Relaxng.RelaxngGrammarContentList); } }
    public Commons.Xml.Relaxng.RelaxngGrammarContentList Divs { get { return default(Commons.Xml.Relaxng.RelaxngGrammarContentList); } }
    public Commons.Xml.Relaxng.RelaxngGrammarContentList Includes { get { return default(Commons.Xml.Relaxng.RelaxngGrammarContentList); } }
    public override Commons.Xml.Relaxng.RelaxngPatternType PatternType { get { return default(Commons.Xml.Relaxng.RelaxngPatternType); } }
    public Commons.Xml.Relaxng.RelaxngGrammarContentList Starts { get { return default(Commons.Xml.Relaxng.RelaxngGrammarContentList); } }
    public override void Write(System.Xml.XmlWriter writer) { }
  }
  public partial class RelaxngGrammarContentList : System.Collections.CollectionBase {
    public RelaxngGrammarContentList() { }
    public Commons.Xml.Relaxng.IGrammarContent this[int i] { get { return default(Commons.Xml.Relaxng.IGrammarContent); } set { } }
    public void Add(Commons.Xml.Relaxng.IGrammarContent p) { }
    public void Insert(int pos, Commons.Xml.Relaxng.IGrammarContent p) { }
    public void Remove(Commons.Xml.Relaxng.IGrammarContent p) { }
  }
  public partial class RelaxngGroup : Commons.Xml.Relaxng.RelaxngBinaryContentPattern {
    public RelaxngGroup() { }
    public override Commons.Xml.Relaxng.RelaxngPatternType PatternType { get { return default(Commons.Xml.Relaxng.RelaxngPatternType); } }
    public override void Write(System.Xml.XmlWriter writer) { }
  }
  public partial class RelaxngInclude : Commons.Xml.Relaxng.RelaxngElementBase, Commons.Xml.Relaxng.IGrammarContent {
    public RelaxngInclude() { }
    public Commons.Xml.Relaxng.RelaxngGrammarContentList Defines { get { return default(Commons.Xml.Relaxng.RelaxngGrammarContentList); } }
    public Commons.Xml.Relaxng.RelaxngGrammarContentList Divs { get { return default(Commons.Xml.Relaxng.RelaxngGrammarContentList); } }
    public string Href { get { return default(string); } set { } }
    public string NSContext { get { return default(string); } set { } }
    public Commons.Xml.Relaxng.RelaxngGrammarContentList Starts { get { return default(Commons.Xml.Relaxng.RelaxngGrammarContentList); } }
    public override void Write(System.Xml.XmlWriter writer) { }
  }
  public partial class RelaxngInterleave : Commons.Xml.Relaxng.RelaxngBinaryContentPattern {
    public RelaxngInterleave() { }
    public override Commons.Xml.Relaxng.RelaxngPatternType PatternType { get { return default(Commons.Xml.Relaxng.RelaxngPatternType); } }
    public override void Write(System.Xml.XmlWriter writer) { }
  }
  public partial class RelaxngList : Commons.Xml.Relaxng.RelaxngSingleContentPattern {
    internal RelaxngList() { }
    public override Commons.Xml.Relaxng.RelaxngPatternType PatternType { get { return default(Commons.Xml.Relaxng.RelaxngPatternType); } }
    public override void Write(System.Xml.XmlWriter writer) { }
  }
  public partial class RelaxngMergedProvider : Commons.Xml.Relaxng.RelaxngDatatypeProvider {
    public RelaxngMergedProvider() { }
    public static Commons.Xml.Relaxng.RelaxngMergedProvider DefaultProvider { get { return default(Commons.Xml.Relaxng.RelaxngMergedProvider); } }
    public Commons.Xml.Relaxng.RelaxngDatatypeProvider this[string ns] { get { return default(Commons.Xml.Relaxng.RelaxngDatatypeProvider); } set { } }
    public override Commons.Xml.Relaxng.RelaxngDatatype GetDatatype(string name, string ns, Commons.Xml.Relaxng.RelaxngParamList parameters) { return default(Commons.Xml.Relaxng.RelaxngDatatype); }
  }
  public partial class RelaxngMixed : Commons.Xml.Relaxng.RelaxngSingleContentPattern {
    public RelaxngMixed() { }
    public override Commons.Xml.Relaxng.RelaxngPatternType PatternType { get { return default(Commons.Xml.Relaxng.RelaxngPatternType); } }
    public override void Write(System.Xml.XmlWriter writer) { }
  }
  public partial class RelaxngName : Commons.Xml.Relaxng.RelaxngNameClass {
    public RelaxngName() { }
    public RelaxngName(string ncname, string ns) { }
    public string LocalName { get { return default(string); } set { } }
    public string Namespace { get { return default(string); } set { } }
    public override void Write(System.Xml.XmlWriter writer) { }
  }
  public partial class RelaxngNameChoice : Commons.Xml.Relaxng.RelaxngNameClass {
    public RelaxngNameChoice() { }
    public Commons.Xml.Relaxng.RelaxngNameClassList Children { get { return default(Commons.Xml.Relaxng.RelaxngNameClassList); } set { } }
    public override void Write(System.Xml.XmlWriter writer) { }
  }
  public abstract partial class RelaxngNameClass : Commons.Xml.Relaxng.RelaxngElementBase {
    protected RelaxngNameClass() { }
  }
  public partial class RelaxngNameClassList : System.Collections.CollectionBase {
    public RelaxngNameClassList() { }
    public Commons.Xml.Relaxng.RelaxngNameClass this[int i] { get { return default(Commons.Xml.Relaxng.RelaxngNameClass); } set { } }
    public void Add(Commons.Xml.Relaxng.RelaxngNameClass p) { }
    public void Insert(int pos, Commons.Xml.Relaxng.RelaxngNameClass p) { }
    public void Remove(Commons.Xml.Relaxng.RelaxngNameClass p) { }
  }
  public partial class RelaxngNotAllowed : Commons.Xml.Relaxng.RelaxngPattern {
    public RelaxngNotAllowed() { }
    public override Commons.Xml.Relaxng.RelaxngPatternType PatternType { get { return default(Commons.Xml.Relaxng.RelaxngPatternType); } }
    public override void Write(System.Xml.XmlWriter writer) { }
  }
  public partial class RelaxngNsName : Commons.Xml.Relaxng.RelaxngNameClass {
    public RelaxngNsName() { }
    public Commons.Xml.Relaxng.RelaxngExceptNameClass Except { get { return default(Commons.Xml.Relaxng.RelaxngExceptNameClass); } set { } }
    public string Namespace { get { return default(string); } set { } }
    public override void Write(System.Xml.XmlWriter writer) { }
  }
  public partial class RelaxngOneOrMore : Commons.Xml.Relaxng.RelaxngSingleContentPattern {
    public RelaxngOneOrMore() { }
    public override Commons.Xml.Relaxng.RelaxngPatternType PatternType { get { return default(Commons.Xml.Relaxng.RelaxngPatternType); } }
    public override void Write(System.Xml.XmlWriter writer) { }
  }
  public partial class RelaxngOptional : Commons.Xml.Relaxng.RelaxngSingleContentPattern {
    public RelaxngOptional() { }
    public override Commons.Xml.Relaxng.RelaxngPatternType PatternType { get { return default(Commons.Xml.Relaxng.RelaxngPatternType); } }
    public override void Write(System.Xml.XmlWriter writer) { }
  }
  public partial class RelaxngParam : Commons.Xml.Relaxng.RelaxngElementBase {
    public RelaxngParam() { }
    public RelaxngParam(string name, string value) { }
    public string Name { get { return default(string); } set { } }
    public string Value { get { return default(string); } set { } }
    public override void Write(System.Xml.XmlWriter writer) { }
  }
  public partial class RelaxngParamList : System.Collections.CollectionBase {
    public RelaxngParamList() { }
    public Commons.Xml.Relaxng.RelaxngParam this[int i] { get { return default(Commons.Xml.Relaxng.RelaxngParam); } set { } }
    public void Add(Commons.Xml.Relaxng.RelaxngParam p) { }
    public void Insert(int pos, Commons.Xml.Relaxng.RelaxngParam p) { }
    public void Remove(Commons.Xml.Relaxng.RelaxngParam p) { }
  }
  public partial class RelaxngParentRef : Commons.Xml.Relaxng.RelaxngPattern {
    public RelaxngParentRef() { }
    public string Name { get { return default(string); } set { } }
    public override Commons.Xml.Relaxng.RelaxngPatternType PatternType { get { return default(Commons.Xml.Relaxng.RelaxngPatternType); } }
    public override void Write(System.Xml.XmlWriter writer) { }
  }
  public abstract partial class RelaxngPattern : Commons.Xml.Relaxng.RelaxngElementBase {
    protected RelaxngPattern() { }
    public Commons.Xml.Relaxng.RelaxngDatatypeProvider DataProvider { get { return default(Commons.Xml.Relaxng.RelaxngDatatypeProvider); } set { } }
    public abstract Commons.Xml.Relaxng.RelaxngPatternType PatternType { get; }
    public System.Xml.XmlResolver XmlResolver { set { } }
    public void Compile() { }
    public static Commons.Xml.Relaxng.RelaxngPattern Read(System.Xml.XmlReader xmlReader) { return default(Commons.Xml.Relaxng.RelaxngPattern); }
    public static Commons.Xml.Relaxng.RelaxngPattern Read(System.Xml.XmlReader xmlReader, Commons.Xml.Relaxng.RelaxngDatatypeProvider provider) { return default(Commons.Xml.Relaxng.RelaxngPattern); }
    public static Commons.Xml.Relaxng.RelaxngPattern Read(System.Xml.XmlReader xmlReader, Commons.Xml.Relaxng.RelaxngDatatypeProvider provider, System.Xml.XmlResolver xmlResolver) { return default(Commons.Xml.Relaxng.RelaxngPattern); }
    public void WriteCompact(System.IO.TextWriter writer) { }
    public void WriteCompact(System.IO.TextWriter writer, System.Xml.IXmlNamespaceResolver res) { }
  }
  public partial class RelaxngPatternList : System.Collections.CollectionBase {
    public RelaxngPatternList() { }
    public Commons.Xml.Relaxng.RelaxngPattern this[int i] { get { return default(Commons.Xml.Relaxng.RelaxngPattern); } set { } }
    public void Add(Commons.Xml.Relaxng.RelaxngPattern p) { }
    public void Insert(int pos, Commons.Xml.Relaxng.RelaxngPattern p) { }
    public void Remove(Commons.Xml.Relaxng.RelaxngPattern p) { }
  }
  public enum RelaxngPatternType {
    After = 14,
    Attribute = 12,
    Choice = 4,
    Data = 9,
    DataExcept = 10,
    Element = 13,
    Empty = 1,
    ExternalRef = 21,
    Grammar = 16,
    Group = 6,
    Interleave = 5,
    List = 8,
    Mixed = 18,
    NotAllowed = 2,
    OneOrMore = 7,
    Optional = 19,
    ParentRef = 22,
    Ref = 15,
    Text = 3,
    Value = 11,
    ZeroOrMore = 17,
  }
  public partial class RelaxngReader : Commons.Xml.XmlDefaultReader {
    [System.ObsoleteAttribute]
    public static string RelaxngNS;
    public RelaxngReader(System.Xml.XmlReader reader) : base (default(System.Xml.XmlReader)) { }
    public RelaxngReader(System.Xml.XmlReader reader, string ns) : base (default(System.Xml.XmlReader)) { }
    public RelaxngReader(System.Xml.XmlReader reader, string ns, System.Xml.XmlResolver resolver) : base (default(System.Xml.XmlReader)) { }
    public string ContextNamespace { get { return default(string); } }
    public string DatatypeLibrary { get { return default(string); } }
    public static Commons.Xml.Relaxng.RelaxngPattern GrammarForRelaxng { get { return default(Commons.Xml.Relaxng.RelaxngPattern); } }
    public System.Xml.XmlResolver XmlResolver { set { } }
    public override bool Read() { return default(bool); }
    public Commons.Xml.Relaxng.RelaxngPattern ReadPattern() { return default(Commons.Xml.Relaxng.RelaxngPattern); }
    public override string ReadString() { return default(string); }
  }
  public partial class RelaxngRef : Commons.Xml.Relaxng.RelaxngPattern {
    public RelaxngRef() { }
    public string Name { get { return default(string); } set { } }
    public override Commons.Xml.Relaxng.RelaxngPatternType PatternType { get { return default(Commons.Xml.Relaxng.RelaxngPatternType); } }
    public override void Write(System.Xml.XmlWriter writer) { }
  }
  public abstract partial class RelaxngSingleContentPattern : Commons.Xml.Relaxng.RelaxngPattern {
    protected RelaxngSingleContentPattern() { }
    public Commons.Xml.Relaxng.RelaxngPatternList Patterns { get { return default(Commons.Xml.Relaxng.RelaxngPatternList); } }
  }
  public partial class RelaxngStart : Commons.Xml.Relaxng.RelaxngElementBase, Commons.Xml.Relaxng.IGrammarContent {
    public RelaxngStart() { }
    public string Combine { get { return default(string); } set { } }
    public Commons.Xml.Relaxng.RelaxngPattern Pattern { get { return default(Commons.Xml.Relaxng.RelaxngPattern); } set { } }
    public override void Write(System.Xml.XmlWriter writer) { }
  }
  public partial class RelaxngString : Commons.Xml.Relaxng.RelaxngDatatype {
    public RelaxngString() { }
    public override string Name { get { return default(string); } }
    public override string NamespaceURI { get { return default(string); } }
    public override bool Compare(object o1, object o2) { return default(bool); }
    public override bool IsValid(string text, System.Xml.XmlReader reader) { return default(bool); }
    public override object Parse(string text, System.Xml.XmlReader reader) { return default(object); }
  }
  public partial class RelaxngText : Commons.Xml.Relaxng.RelaxngPattern {
    public RelaxngText() { }
    public override Commons.Xml.Relaxng.RelaxngPatternType PatternType { get { return default(Commons.Xml.Relaxng.RelaxngPatternType); } }
    public override void Write(System.Xml.XmlWriter writer) { }
  }
  public partial class RelaxngToken : Commons.Xml.Relaxng.RelaxngDatatype {
    public RelaxngToken() { }
    public override string Name { get { return default(string); } }
    public override string NamespaceURI { get { return default(string); } }
    public override bool Compare(object o1, object o2) { return default(bool); }
    public override bool CompareString(string s1, string s2, System.Xml.XmlReader reader) { return default(bool); }
    public override bool IsValid(string text, System.Xml.XmlReader reader) { return default(bool); }
    public override object Parse(string text, System.Xml.XmlReader reader) { return default(object); }
  }
  public partial class RelaxngValidatingReader : Commons.Xml.XmlDefaultReader {
    public static readonly Commons.Xml.Relaxng.RelaxngValidatingReader.RelaxngValidationEventHandler IgnoreError;
    public RelaxngValidatingReader(System.Xml.XmlReader reader) : base (default(System.Xml.XmlReader)) { }
    public RelaxngValidatingReader(System.Xml.XmlReader reader, Commons.Xml.Relaxng.RelaxngPattern pattern) : base (default(System.Xml.XmlReader)) { }
    public RelaxngValidatingReader(System.Xml.XmlReader reader, System.Xml.XmlReader grammarXml) : base (default(System.Xml.XmlReader)) { }
    public RelaxngValidatingReader(System.Xml.XmlReader reader, System.Xml.XmlReader grammarXml, Commons.Xml.Relaxng.RelaxngDatatypeProvider provider) : base (default(System.Xml.XmlReader)) { }
    public bool ReportDetails { get { return default(bool); } set { } }
    public bool RoughLabelCheck { get { return default(bool); } set { } }
    public event Commons.Xml.Relaxng.RelaxngValidatingReader.RelaxngValidationEventHandler InvalidNodeFound { add { } remove { } }
    public object AfterAttribute(object stateObject, string localName, string ns) { return default(object); }
    public object AfterCloseStartTag(object stateObject) { return default(object); }
    public object AfterEndTag(object stateObject) { return default(object); }
    public object AfterOpenStartTag(object stateObject, string localName, string ns) { return default(object); }
    public bool Attribute(object stateObject, string localName, string ns) { return default(bool); }
    public bool CloseStartTag(object stateObject) { return default(bool); }
    public bool Emptiable(object stateObject) { return default(bool); }
    public bool EndTag(object stateObject) { return default(bool); }
    public System.Collections.ICollection GetAttributeLabels(object stateObject) { return default(System.Collections.ICollection); }
    public object GetCurrentState() { return default(object); }
    public System.Collections.ICollection GetElementLabels(object stateObject) { return default(System.Collections.ICollection); }
    public bool OpenStartTag(object stateObject, string localName, string ns) { return default(bool); }
    public override bool Read() { return default(bool); }
    public delegate bool RelaxngValidationEventHandler(System.Xml.XmlReader source, string message);
  }
  public partial class RelaxngValue : Commons.Xml.Relaxng.RelaxngDataSupport {
    public RelaxngValue() { }
    public override Commons.Xml.Relaxng.RelaxngPatternType PatternType { get { return default(Commons.Xml.Relaxng.RelaxngPatternType); } }
    public string Value { get { return default(string); } set { } }
    public override void Write(System.Xml.XmlWriter writer) { }
  }
  public partial class RelaxngZeroOrMore : Commons.Xml.Relaxng.RelaxngSingleContentPattern {
    public RelaxngZeroOrMore() { }
    public override Commons.Xml.Relaxng.RelaxngPatternType PatternType { get { return default(Commons.Xml.Relaxng.RelaxngPatternType); } }
    public override void Write(System.Xml.XmlWriter writer) { }
  }
}
namespace Commons.Xml.Relaxng.Derivative {
  public abstract partial class RdpAbstractBinary : Commons.Xml.Relaxng.Derivative.RdpPattern {
    public RdpAbstractBinary(Commons.Xml.Relaxng.Derivative.RdpPattern l, Commons.Xml.Relaxng.Derivative.RdpPattern r) { }
    public override Commons.Xml.Relaxng.Derivative.RdpContentType ContentType { get { return default(Commons.Xml.Relaxng.Derivative.RdpContentType); } }
    public Commons.Xml.Relaxng.Derivative.RdpPattern LValue { get { return default(Commons.Xml.Relaxng.Derivative.RdpPattern); } set { } }
    public Commons.Xml.Relaxng.Derivative.RdpPattern RValue { get { return default(Commons.Xml.Relaxng.Derivative.RdpPattern); } set { } }
  }
  public abstract partial class RdpAbstractSingleContent : Commons.Xml.Relaxng.Derivative.RdpPattern {
    public RdpAbstractSingleContent(Commons.Xml.Relaxng.Derivative.RdpPattern p) { }
    public Commons.Xml.Relaxng.Derivative.RdpPattern Child { get { return default(Commons.Xml.Relaxng.Derivative.RdpPattern); } set { } }
  }
  public partial class RdpAfter : Commons.Xml.Relaxng.Derivative.RdpAbstractBinary {
    public RdpAfter(Commons.Xml.Relaxng.Derivative.RdpPattern l, Commons.Xml.Relaxng.Derivative.RdpPattern r) : base (default(Commons.Xml.Relaxng.Derivative.RdpPattern), default(Commons.Xml.Relaxng.Derivative.RdpPattern)) { }
    public override bool Nullable { get { return default(bool); } }
    public override Commons.Xml.Relaxng.RelaxngPatternType PatternType { get { return default(Commons.Xml.Relaxng.RelaxngPatternType); } }
    public override Commons.Xml.Relaxng.Derivative.RdpPattern ApplyAfter(Commons.Xml.Relaxng.Derivative.RdpApplyAfterHandler handler) { return default(Commons.Xml.Relaxng.Derivative.RdpPattern); }
    public override Commons.Xml.Relaxng.Derivative.RdpPattern AttDeriv(string name, string ns, string value, System.Xml.XmlReader reader) { return default(Commons.Xml.Relaxng.Derivative.RdpPattern); }
    public override Commons.Xml.Relaxng.Derivative.RdpPattern EndAttDeriv() { return default(Commons.Xml.Relaxng.Derivative.RdpPattern); }
    public override Commons.Xml.Relaxng.Derivative.RdpPattern EndTagDeriv() { return default(Commons.Xml.Relaxng.Derivative.RdpPattern); }
    public override void GetLabels(System.Collections.Hashtable elements, System.Collections.Hashtable attributes, bool collectNameClass) { }
    public override Commons.Xml.Relaxng.Derivative.RdpPattern StartAttDeriv(string name, string ns) { return default(Commons.Xml.Relaxng.Derivative.RdpPattern); }
    public override Commons.Xml.Relaxng.Derivative.RdpPattern StartTagCloseDeriv() { return default(Commons.Xml.Relaxng.Derivative.RdpPattern); }
    public override Commons.Xml.Relaxng.Derivative.RdpPattern StartTagOpenDeriv(string name, string ns) { return default(Commons.Xml.Relaxng.Derivative.RdpPattern); }
    public override Commons.Xml.Relaxng.Derivative.RdpPattern TextDeriv(string s, System.Xml.XmlReader reader) { return default(Commons.Xml.Relaxng.Derivative.RdpPattern); }
  }
  public partial class RdpAnyName : Commons.Xml.Relaxng.Derivative.RdpNameClass {
    internal RdpAnyName() { }
    public override bool HasInfiniteName { get { return default(bool); } }
    public static Commons.Xml.Relaxng.Derivative.RdpAnyName Instance { get { return default(Commons.Xml.Relaxng.Derivative.RdpAnyName); } }
    public override Commons.Xml.Relaxng.Derivative.RdpNameClassType NameClassType { get { return default(Commons.Xml.Relaxng.Derivative.RdpNameClassType); } }
    public override bool Contains(string name, string ns) { return default(bool); }
  }
  public partial class RdpAnyNameExcept : Commons.Xml.Relaxng.Derivative.RdpNameClass {
    public RdpAnyNameExcept(Commons.Xml.Relaxng.Derivative.RdpNameClass except) { }
    public Commons.Xml.Relaxng.Derivative.RdpNameClass ExceptNameClass { get { return default(Commons.Xml.Relaxng.Derivative.RdpNameClass); } }
    public override bool HasInfiniteName { get { return default(bool); } }
    public override Commons.Xml.Relaxng.Derivative.RdpNameClassType NameClassType { get { return default(Commons.Xml.Relaxng.Derivative.RdpNameClassType); } }
    public override bool Contains(string name, string ns) { return default(bool); }
  }
  public delegate Commons.Xml.Relaxng.Derivative.RdpPattern RdpApplyAfterHandler(Commons.Xml.Relaxng.Derivative.RdpPattern p);
  public partial class RdpAttribute : Commons.Xml.Relaxng.Derivative.RdpPattern {
    public RdpAttribute(Commons.Xml.Relaxng.Derivative.RdpNameClass nameClass, Commons.Xml.Relaxng.Derivative.RdpPattern p) { }
    public Commons.Xml.Relaxng.Derivative.RdpPattern Children { get { return default(Commons.Xml.Relaxng.Derivative.RdpPattern); } set { } }
    public override Commons.Xml.Relaxng.Derivative.RdpContentType ContentType { get { return default(Commons.Xml.Relaxng.Derivative.RdpContentType); } }
    public Commons.Xml.Relaxng.Derivative.RdpNameClass NameClass { get { return default(Commons.Xml.Relaxng.Derivative.RdpNameClass); } }
    public override bool Nullable { get { return default(bool); } }
    public override Commons.Xml.Relaxng.RelaxngPatternType PatternType { get { return default(Commons.Xml.Relaxng.RelaxngPatternType); } }
    public override Commons.Xml.Relaxng.Derivative.RdpPattern AttDeriv(string name, string ns, string value, System.Xml.XmlReader reader) { return default(Commons.Xml.Relaxng.Derivative.RdpPattern); }
    public override void GetLabels(System.Collections.Hashtable elements, System.Collections.Hashtable attributes, bool collectNameClass) { }
    public override Commons.Xml.Relaxng.Derivative.RdpPattern StartAttDeriv(string name, string ns) { return default(Commons.Xml.Relaxng.Derivative.RdpPattern); }
    public override Commons.Xml.Relaxng.Derivative.RdpPattern StartTagCloseDeriv() { return default(Commons.Xml.Relaxng.Derivative.RdpPattern); }
  }
  public delegate Commons.Xml.Relaxng.Derivative.RdpPattern RdpBinaryFunction(Commons.Xml.Relaxng.Derivative.RdpPattern p1, Commons.Xml.Relaxng.Derivative.RdpPattern p2);
  public partial class RdpChoice : Commons.Xml.Relaxng.Derivative.RdpAbstractBinary {
    public RdpChoice(Commons.Xml.Relaxng.Derivative.RdpPattern l, Commons.Xml.Relaxng.Derivative.RdpPattern r) : base (default(Commons.Xml.Relaxng.Derivative.RdpPattern), default(Commons.Xml.Relaxng.Derivative.RdpPattern)) { }
    public override Commons.Xml.Relaxng.Derivative.RdpContentType ContentType { get { return default(Commons.Xml.Relaxng.Derivative.RdpContentType); } }
    public override bool Nullable { get { return default(bool); } }
    public override Commons.Xml.Relaxng.RelaxngPatternType PatternType { get { return default(Commons.Xml.Relaxng.RelaxngPatternType); } }
    public override Commons.Xml.Relaxng.Derivative.RdpPattern ApplyAfter(Commons.Xml.Relaxng.Derivative.RdpApplyAfterHandler handler) { return default(Commons.Xml.Relaxng.Derivative.RdpPattern); }
    public override Commons.Xml.Relaxng.Derivative.RdpPattern AttDeriv(string name, string ns, string value, System.Xml.XmlReader reader) { return default(Commons.Xml.Relaxng.Derivative.RdpPattern); }
    public override Commons.Xml.Relaxng.Derivative.RdpPattern EndAttDeriv() { return default(Commons.Xml.Relaxng.Derivative.RdpPattern); }
    public override Commons.Xml.Relaxng.Derivative.RdpPattern EndTagDeriv() { return default(Commons.Xml.Relaxng.Derivative.RdpPattern); }
    public override void GetLabels(System.Collections.Hashtable elements, System.Collections.Hashtable attributes, bool collectNameClass) { }
    public override Commons.Xml.Relaxng.Derivative.RdpPattern StartAttDeriv(string name, string ns) { return default(Commons.Xml.Relaxng.Derivative.RdpPattern); }
    public override Commons.Xml.Relaxng.Derivative.RdpPattern StartTagCloseDeriv() { return default(Commons.Xml.Relaxng.Derivative.RdpPattern); }
    public override Commons.Xml.Relaxng.Derivative.RdpPattern StartTagOpenDeriv(string name, string ns) { return default(Commons.Xml.Relaxng.Derivative.RdpPattern); }
    public override Commons.Xml.Relaxng.Derivative.RdpPattern TextDeriv(string s, System.Xml.XmlReader reader) { return default(Commons.Xml.Relaxng.Derivative.RdpPattern); }
  }
  public enum RdpContentType {
    Complex = 2,
    Empty = 1,
    Invalid = 0,
    Simple = 4,
  }
  public partial class RdpData : Commons.Xml.Relaxng.Derivative.RdpPattern {
    public RdpData(Commons.Xml.Relaxng.Derivative.RdpDatatype dt) { }
    public override Commons.Xml.Relaxng.Derivative.RdpContentType ContentType { get { return default(Commons.Xml.Relaxng.Derivative.RdpContentType); } }
    public Commons.Xml.Relaxng.Derivative.RdpDatatype Datatype { get { return default(Commons.Xml.Relaxng.Derivative.RdpDatatype); } }
    public override bool Nullable { get { return default(bool); } }
    public override Commons.Xml.Relaxng.RelaxngPatternType PatternType { get { return default(Commons.Xml.Relaxng.RelaxngPatternType); } }
    public override void GetLabels(System.Collections.Hashtable elements, System.Collections.Hashtable attributes, bool collectNameClass) { }
    public override Commons.Xml.Relaxng.Derivative.RdpPattern TextDeriv(string s, System.Xml.XmlReader reader) { return default(Commons.Xml.Relaxng.Derivative.RdpPattern); }
  }
  public partial class RdpDataExcept : Commons.Xml.Relaxng.Derivative.RdpData {
    public RdpDataExcept(Commons.Xml.Relaxng.Derivative.RdpDatatype dt, Commons.Xml.Relaxng.Derivative.RdpPattern except) : base (default(Commons.Xml.Relaxng.Derivative.RdpDatatype)) { }
    public override Commons.Xml.Relaxng.Derivative.RdpContentType ContentType { get { return default(Commons.Xml.Relaxng.Derivative.RdpContentType); } }
    public Commons.Xml.Relaxng.Derivative.RdpPattern Except { get { return default(Commons.Xml.Relaxng.Derivative.RdpPattern); } set { } }
    public override Commons.Xml.Relaxng.RelaxngPatternType PatternType { get { return default(Commons.Xml.Relaxng.RelaxngPatternType); } }
    public override Commons.Xml.Relaxng.Derivative.RdpPattern TextDeriv(string s, System.Xml.XmlReader reader) { return default(Commons.Xml.Relaxng.Derivative.RdpPattern); }
  }
  public partial class RdpDatatype {
    public RdpDatatype(string ns, string localName, Commons.Xml.Relaxng.RelaxngParamList parameters, Commons.Xml.Relaxng.RelaxngDatatypeProvider provider) { }
    public bool IsContextDependent { get { return default(bool); } }
    public string LocalName { get { return default(string); } }
    public string NamespaceURI { get { return default(string); } }
    public virtual bool IsAllowed(string value, System.Xml.XmlReader reader) { return default(bool); }
    public virtual bool IsTypeEqual(string s1, string s2, System.Xml.XmlReader reader) { return default(bool); }
  }
  public partial class RdpElement : Commons.Xml.Relaxng.Derivative.RdpPattern {
    public RdpElement(Commons.Xml.Relaxng.Derivative.RdpNameClass nameClass, Commons.Xml.Relaxng.Derivative.RdpPattern p) { }
    public Commons.Xml.Relaxng.Derivative.RdpPattern Children { get { return default(Commons.Xml.Relaxng.Derivative.RdpPattern); } set { } }
    public override Commons.Xml.Relaxng.Derivative.RdpContentType ContentType { get { return default(Commons.Xml.Relaxng.Derivative.RdpContentType); } }
    public Commons.Xml.Relaxng.Derivative.RdpNameClass NameClass { get { return default(Commons.Xml.Relaxng.Derivative.RdpNameClass); } }
    public override bool Nullable { get { return default(bool); } }
    public override Commons.Xml.Relaxng.RelaxngPatternType PatternType { get { return default(Commons.Xml.Relaxng.RelaxngPatternType); } }
    public override void GetLabels(System.Collections.Hashtable elements, System.Collections.Hashtable attributes, bool collectNameClass) { }
    public override Commons.Xml.Relaxng.Derivative.RdpPattern StartTagOpenDeriv(string name, string ns) { return default(Commons.Xml.Relaxng.Derivative.RdpPattern); }
  }
  public partial class RdpEmpty : Commons.Xml.Relaxng.Derivative.RdpPattern {
    public RdpEmpty() { }
    public override Commons.Xml.Relaxng.Derivative.RdpContentType ContentType { get { return default(Commons.Xml.Relaxng.Derivative.RdpContentType); } }
    public static Commons.Xml.Relaxng.Derivative.RdpEmpty Instance { get { return default(Commons.Xml.Relaxng.Derivative.RdpEmpty); } }
    public override bool Nullable { get { return default(bool); } }
    public override Commons.Xml.Relaxng.RelaxngPatternType PatternType { get { return default(Commons.Xml.Relaxng.RelaxngPatternType); } }
    public override void GetLabels(System.Collections.Hashtable elements, System.Collections.Hashtable attributes, bool collectNameClass) { }
  }
  public partial class RdpGroup : Commons.Xml.Relaxng.Derivative.RdpAbstractBinary {
    public RdpGroup(Commons.Xml.Relaxng.Derivative.RdpPattern l, Commons.Xml.Relaxng.Derivative.RdpPattern r) : base (default(Commons.Xml.Relaxng.Derivative.RdpPattern), default(Commons.Xml.Relaxng.Derivative.RdpPattern)) { }
    public override bool Nullable { get { return default(bool); } }
    public override Commons.Xml.Relaxng.RelaxngPatternType PatternType { get { return default(Commons.Xml.Relaxng.RelaxngPatternType); } }
    public override Commons.Xml.Relaxng.Derivative.RdpPattern AttDeriv(string name, string ns, string value, System.Xml.XmlReader reader) { return default(Commons.Xml.Relaxng.Derivative.RdpPattern); }
    public override void GetLabels(System.Collections.Hashtable elements, System.Collections.Hashtable attributes, bool collectNameClass) { }
    public override Commons.Xml.Relaxng.Derivative.RdpPattern StartAttDeriv(string name, string ns) { return default(Commons.Xml.Relaxng.Derivative.RdpPattern); }
    public override Commons.Xml.Relaxng.Derivative.RdpPattern StartTagCloseDeriv() { return default(Commons.Xml.Relaxng.Derivative.RdpPattern); }
    public override Commons.Xml.Relaxng.Derivative.RdpPattern StartTagOpenDeriv(string name, string ns) { return default(Commons.Xml.Relaxng.Derivative.RdpPattern); }
    public override Commons.Xml.Relaxng.Derivative.RdpPattern TextDeriv(string s, System.Xml.XmlReader reader) { return default(Commons.Xml.Relaxng.Derivative.RdpPattern); }
  }
  public partial class RdpInterleave : Commons.Xml.Relaxng.Derivative.RdpAbstractBinary {
    public RdpInterleave(Commons.Xml.Relaxng.Derivative.RdpPattern l, Commons.Xml.Relaxng.Derivative.RdpPattern r) : base (default(Commons.Xml.Relaxng.Derivative.RdpPattern), default(Commons.Xml.Relaxng.Derivative.RdpPattern)) { }
    public override bool Nullable { get { return default(bool); } }
    public override Commons.Xml.Relaxng.RelaxngPatternType PatternType { get { return default(Commons.Xml.Relaxng.RelaxngPatternType); } }
    public override Commons.Xml.Relaxng.Derivative.RdpPattern AttDeriv(string name, string ns, string value, System.Xml.XmlReader reader) { return default(Commons.Xml.Relaxng.Derivative.RdpPattern); }
    public override void GetLabels(System.Collections.Hashtable elements, System.Collections.Hashtable attributes, bool collectNameClass) { }
    public override Commons.Xml.Relaxng.Derivative.RdpPattern StartAttDeriv(string name, string ns) { return default(Commons.Xml.Relaxng.Derivative.RdpPattern); }
    public override Commons.Xml.Relaxng.Derivative.RdpPattern StartTagCloseDeriv() { return default(Commons.Xml.Relaxng.Derivative.RdpPattern); }
    public override Commons.Xml.Relaxng.Derivative.RdpPattern StartTagOpenDeriv(string name, string ns) { return default(Commons.Xml.Relaxng.Derivative.RdpPattern); }
    public override Commons.Xml.Relaxng.Derivative.RdpPattern TextDeriv(string s, System.Xml.XmlReader reader) { return default(Commons.Xml.Relaxng.Derivative.RdpPattern); }
  }
  public partial class RdpList : Commons.Xml.Relaxng.Derivative.RdpAbstractSingleContent {
    public RdpList(Commons.Xml.Relaxng.Derivative.RdpPattern p) : base (default(Commons.Xml.Relaxng.Derivative.RdpPattern)) { }
    public override Commons.Xml.Relaxng.Derivative.RdpContentType ContentType { get { return default(Commons.Xml.Relaxng.Derivative.RdpContentType); } }
    public override bool Nullable { get { return default(bool); } }
    public override Commons.Xml.Relaxng.RelaxngPatternType PatternType { get { return default(Commons.Xml.Relaxng.RelaxngPatternType); } }
    public override void GetLabels(System.Collections.Hashtable elements, System.Collections.Hashtable attributes, bool collectNameClass) { }
    public override Commons.Xml.Relaxng.Derivative.RdpPattern TextDeriv(string s, System.Xml.XmlReader reader) { return default(Commons.Xml.Relaxng.Derivative.RdpPattern); }
  }
  public partial class RdpName : Commons.Xml.Relaxng.Derivative.RdpNameClass {
    public RdpName(string local, string ns) { }
    public override bool HasInfiniteName { get { return default(bool); } }
    public string LocalName { get { return default(string); } }
    public override Commons.Xml.Relaxng.Derivative.RdpNameClassType NameClassType { get { return default(Commons.Xml.Relaxng.Derivative.RdpNameClassType); } }
    public string NamespaceURI { get { return default(string); } }
    public override bool Contains(string name, string ns) { return default(bool); }
  }
  public abstract partial class RdpNameClass {
    protected RdpNameClass() { }
    public abstract bool HasInfiniteName { get; }
    public abstract Commons.Xml.Relaxng.Derivative.RdpNameClassType NameClassType { get; }
    public abstract bool Contains(string name, string ns);
  }
  public partial class RdpNameClassChoice : Commons.Xml.Relaxng.Derivative.RdpNameClass {
    public RdpNameClassChoice(Commons.Xml.Relaxng.Derivative.RdpNameClass l, Commons.Xml.Relaxng.Derivative.RdpNameClass r) { }
    public override bool HasInfiniteName { get { return default(bool); } }
    public Commons.Xml.Relaxng.Derivative.RdpNameClass LValue { get { return default(Commons.Xml.Relaxng.Derivative.RdpNameClass); } }
    public override Commons.Xml.Relaxng.Derivative.RdpNameClassType NameClassType { get { return default(Commons.Xml.Relaxng.Derivative.RdpNameClassType); } }
    public Commons.Xml.Relaxng.Derivative.RdpNameClass RValue { get { return default(Commons.Xml.Relaxng.Derivative.RdpNameClass); } }
    public override bool Contains(string name, string ns) { return default(bool); }
  }
  public enum RdpNameClassType {
    AnyName = 1,
    AnyNameExcept = 2,
    Name = 5,
    NameClassChoice = 6,
    None = 0,
    NsName = 3,
    NsNameExcept = 4,
  }
  public partial class RdpNotAllowed : Commons.Xml.Relaxng.Derivative.RdpPattern {
    public RdpNotAllowed() { }
    public override Commons.Xml.Relaxng.Derivative.RdpContentType ContentType { get { return default(Commons.Xml.Relaxng.Derivative.RdpContentType); } }
    public static Commons.Xml.Relaxng.Derivative.RdpNotAllowed Instance { get { return default(Commons.Xml.Relaxng.Derivative.RdpNotAllowed); } }
    public override bool Nullable { get { return default(bool); } }
    public override Commons.Xml.Relaxng.RelaxngPatternType PatternType { get { return default(Commons.Xml.Relaxng.RelaxngPatternType); } }
    public override Commons.Xml.Relaxng.Derivative.RdpPattern ApplyAfter(Commons.Xml.Relaxng.Derivative.RdpApplyAfterHandler h) { return default(Commons.Xml.Relaxng.Derivative.RdpPattern); }
    public override void GetLabels(System.Collections.Hashtable elements, System.Collections.Hashtable attributes, bool collectNameClass) { }
  }
  public partial class RdpNsName : Commons.Xml.Relaxng.Derivative.RdpNameClass {
    public RdpNsName(string ns) { }
    public override bool HasInfiniteName { get { return default(bool); } }
    public override Commons.Xml.Relaxng.Derivative.RdpNameClassType NameClassType { get { return default(Commons.Xml.Relaxng.Derivative.RdpNameClassType); } }
    public string NamespaceURI { get { return default(string); } }
    public override bool Contains(string name, string ns) { return default(bool); }
  }
  public partial class RdpNsNameExcept : Commons.Xml.Relaxng.Derivative.RdpNsName {
    public RdpNsNameExcept(string ns, Commons.Xml.Relaxng.Derivative.RdpNameClass except) : base (default(string)) { }
    public Commons.Xml.Relaxng.Derivative.RdpNameClass ExceptNameClass { get { return default(Commons.Xml.Relaxng.Derivative.RdpNameClass); } }
    public override bool HasInfiniteName { get { return default(bool); } }
    public override Commons.Xml.Relaxng.Derivative.RdpNameClassType NameClassType { get { return default(Commons.Xml.Relaxng.Derivative.RdpNameClassType); } }
    public override bool Contains(string name, string ns) { return default(bool); }
  }
  public partial class RdpOneOrMore : Commons.Xml.Relaxng.Derivative.RdpAbstractSingleContent {
    public RdpOneOrMore(Commons.Xml.Relaxng.Derivative.RdpPattern p) : base (default(Commons.Xml.Relaxng.Derivative.RdpPattern)) { }
    public override Commons.Xml.Relaxng.Derivative.RdpContentType ContentType { get { return default(Commons.Xml.Relaxng.Derivative.RdpContentType); } }
    public override bool Nullable { get { return default(bool); } }
    public override Commons.Xml.Relaxng.RelaxngPatternType PatternType { get { return default(Commons.Xml.Relaxng.RelaxngPatternType); } }
    public override Commons.Xml.Relaxng.Derivative.RdpPattern AttDeriv(string name, string ns, string value, System.Xml.XmlReader reader) { return default(Commons.Xml.Relaxng.Derivative.RdpPattern); }
    public override void GetLabels(System.Collections.Hashtable elements, System.Collections.Hashtable attributes, bool collectNameClass) { }
    public override Commons.Xml.Relaxng.Derivative.RdpPattern StartAttDeriv(string name, string ns) { return default(Commons.Xml.Relaxng.Derivative.RdpPattern); }
    public override Commons.Xml.Relaxng.Derivative.RdpPattern StartTagCloseDeriv() { return default(Commons.Xml.Relaxng.Derivative.RdpPattern); }
    public override Commons.Xml.Relaxng.Derivative.RdpPattern StartTagOpenDeriv(string name, string ns) { return default(Commons.Xml.Relaxng.Derivative.RdpPattern); }
    public override Commons.Xml.Relaxng.Derivative.RdpPattern TextDeriv(string s, System.Xml.XmlReader reader) { return default(Commons.Xml.Relaxng.Derivative.RdpPattern); }
  }
  public partial class RdpParam {
    public RdpParam(string localName, string value) { }
    public string LocalName { get { return default(string); } }
    public string Value { get { return default(string); } }
  }
  public partial class RdpParamList : System.Collections.ArrayList {
    public RdpParamList() { }
  }
  public abstract partial class RdpPattern {
    public static readonly Commons.Xml.Relaxng.Derivative.RdpPattern Anything;
    protected RdpPattern() { }
    public abstract Commons.Xml.Relaxng.Derivative.RdpContentType ContentType { get; }
    public abstract bool Nullable { get; }
    public abstract Commons.Xml.Relaxng.RelaxngPatternType PatternType { get; }
    public virtual Commons.Xml.Relaxng.Derivative.RdpPattern After(Commons.Xml.Relaxng.Derivative.RdpPattern p) { return default(Commons.Xml.Relaxng.Derivative.RdpPattern); }
    public virtual Commons.Xml.Relaxng.Derivative.RdpPattern ApplyAfter(Commons.Xml.Relaxng.Derivative.RdpApplyAfterHandler h) { return default(Commons.Xml.Relaxng.Derivative.RdpPattern); }
    public virtual Commons.Xml.Relaxng.Derivative.RdpPattern AttDeriv(string name, string ns, string value, System.Xml.XmlReader reader) { return default(Commons.Xml.Relaxng.Derivative.RdpPattern); }
    public virtual Commons.Xml.Relaxng.Derivative.RdpPattern Choice(Commons.Xml.Relaxng.Derivative.RdpPattern p) { return default(Commons.Xml.Relaxng.Derivative.RdpPattern); }
    public virtual Commons.Xml.Relaxng.Derivative.RdpPattern EndAttDeriv() { return default(Commons.Xml.Relaxng.Derivative.RdpPattern); }
    public virtual Commons.Xml.Relaxng.Derivative.RdpPattern EndTagDeriv() { return default(Commons.Xml.Relaxng.Derivative.RdpPattern); }
    public void GetLabels(System.Collections.Hashtable elements, System.Collections.Hashtable attributes) { }
    public abstract void GetLabels(System.Collections.Hashtable elements, System.Collections.Hashtable attributes, bool collectNameClass);
    public virtual Commons.Xml.Relaxng.Derivative.RdpPattern Group(Commons.Xml.Relaxng.Derivative.RdpPattern p) { return default(Commons.Xml.Relaxng.Derivative.RdpPattern); }
    public virtual Commons.Xml.Relaxng.Derivative.RdpPattern Interleave(Commons.Xml.Relaxng.Derivative.RdpPattern p) { return default(Commons.Xml.Relaxng.Derivative.RdpPattern); }
    public Commons.Xml.Relaxng.Derivative.RdpPattern ListDeriv(System.String[] list, int index, System.Xml.XmlReader reader) { return default(Commons.Xml.Relaxng.Derivative.RdpPattern); }
    public Commons.Xml.Relaxng.Derivative.RdpAfter MakeAfter(Commons.Xml.Relaxng.Derivative.RdpPattern p1, Commons.Xml.Relaxng.Derivative.RdpPattern p2) { return default(Commons.Xml.Relaxng.Derivative.RdpAfter); }
    public Commons.Xml.Relaxng.Derivative.RdpPattern MakeChoice(Commons.Xml.Relaxng.Derivative.RdpPattern p1, Commons.Xml.Relaxng.Derivative.RdpPattern p2) { return default(Commons.Xml.Relaxng.Derivative.RdpPattern); }
    public Commons.Xml.Relaxng.Derivative.RdpChoice MakeChoiceLeaf(Commons.Xml.Relaxng.Derivative.RdpPattern p) { return default(Commons.Xml.Relaxng.Derivative.RdpChoice); }
    public Commons.Xml.Relaxng.Derivative.RdpPattern MakeGroup(Commons.Xml.Relaxng.Derivative.RdpPattern p1, Commons.Xml.Relaxng.Derivative.RdpPattern p2) { return default(Commons.Xml.Relaxng.Derivative.RdpPattern); }
    public Commons.Xml.Relaxng.Derivative.RdpInterleave MakeInterleave(Commons.Xml.Relaxng.Derivative.RdpPattern p1, Commons.Xml.Relaxng.Derivative.RdpPattern p2) { return default(Commons.Xml.Relaxng.Derivative.RdpInterleave); }
    public Commons.Xml.Relaxng.Derivative.RdpOneOrMore MakeOneOrMore(Commons.Xml.Relaxng.Derivative.RdpPattern p) { return default(Commons.Xml.Relaxng.Derivative.RdpOneOrMore); }
    public Commons.Xml.Relaxng.Derivative.RdpPattern OneOrMore() { return default(Commons.Xml.Relaxng.Derivative.RdpPattern); }
    public virtual Commons.Xml.Relaxng.Derivative.RdpPattern StartAttDeriv(string name, string ns) { return default(Commons.Xml.Relaxng.Derivative.RdpPattern); }
    public virtual Commons.Xml.Relaxng.Derivative.RdpPattern StartTagCloseDeriv() { return default(Commons.Xml.Relaxng.Derivative.RdpPattern); }
    public virtual Commons.Xml.Relaxng.Derivative.RdpPattern StartTagOpenDeriv(string name, string ns) { return default(Commons.Xml.Relaxng.Derivative.RdpPattern); }
    public virtual Commons.Xml.Relaxng.Derivative.RdpPattern TextDeriv(string s, System.Xml.XmlReader reader) { return default(Commons.Xml.Relaxng.Derivative.RdpPattern); }
    public bool ValueMatch(string s, System.Xml.XmlReader reader) { return default(bool); }
  }
  public partial class RdpText : Commons.Xml.Relaxng.Derivative.RdpPattern {
    public RdpText() { }
    public override Commons.Xml.Relaxng.Derivative.RdpContentType ContentType { get { return default(Commons.Xml.Relaxng.Derivative.RdpContentType); } }
    public static Commons.Xml.Relaxng.Derivative.RdpText Instance { get { return default(Commons.Xml.Relaxng.Derivative.RdpText); } }
    public override bool Nullable { get { return default(bool); } }
    public override Commons.Xml.Relaxng.RelaxngPatternType PatternType { get { return default(Commons.Xml.Relaxng.RelaxngPatternType); } }
    public override void GetLabels(System.Collections.Hashtable elements, System.Collections.Hashtable attributes, bool collectNameClass) { }
    public override Commons.Xml.Relaxng.Derivative.RdpPattern TextDeriv(string s, System.Xml.XmlReader reader) { return default(Commons.Xml.Relaxng.Derivative.RdpPattern); }
  }
  public partial class RdpUtil {
    public static System.Char[] WhitespaceChars;
    public RdpUtil() { }
  }
  public partial class RdpValue : Commons.Xml.Relaxng.Derivative.RdpPattern {
    public RdpValue(Commons.Xml.Relaxng.Derivative.RdpDatatype dt, string value) { }
    public override Commons.Xml.Relaxng.Derivative.RdpContentType ContentType { get { return default(Commons.Xml.Relaxng.Derivative.RdpContentType); } }
    public Commons.Xml.Relaxng.Derivative.RdpDatatype Datatype { get { return default(Commons.Xml.Relaxng.Derivative.RdpDatatype); } }
    public override bool Nullable { get { return default(bool); } }
    public override Commons.Xml.Relaxng.RelaxngPatternType PatternType { get { return default(Commons.Xml.Relaxng.RelaxngPatternType); } }
    public string Value { get { return default(string); } }
    public override void GetLabels(System.Collections.Hashtable elements, System.Collections.Hashtable attributes, bool collectNameClass) { }
    public override Commons.Xml.Relaxng.Derivative.RdpPattern TextDeriv(string s, System.Xml.XmlReader reader) { return default(Commons.Xml.Relaxng.Derivative.RdpPattern); }
  }
}
namespace Commons.Xml.Relaxng.Inference {
  public partial class RelaxngInference {
    public RelaxngInference() { }
    public Commons.Xml.Relaxng.Inference.RelaxngInference.InferenceOption Occurrence { get { return default(Commons.Xml.Relaxng.Inference.RelaxngInference.InferenceOption); } set { } }
    public Commons.Xml.Relaxng.Inference.RelaxngInference.InferenceOption TypeInference { get { return default(Commons.Xml.Relaxng.Inference.RelaxngInference.InferenceOption); } set { } }
    public Commons.Xml.Relaxng.RelaxngGrammar InferSchema(System.Xml.XmlReader xmlReader) { return default(Commons.Xml.Relaxng.RelaxngGrammar); }
    public Commons.Xml.Relaxng.RelaxngGrammar InferSchema(System.Xml.XmlReader xmlReader, Commons.Xml.Relaxng.RelaxngGrammar grammar) { return default(Commons.Xml.Relaxng.RelaxngGrammar); }
    public enum InferenceOption {
      Relaxed = 1,
      Restricted = 0,
    }
  }
}
namespace Commons.Xml.Relaxng.Rnc {
  public partial class RncParser {
    public int eof_token;
    public System.IO.TextWriter ErrorOutput;
    protected bool use_global_stacks;
    protected static readonly System.Int16[] yyCheck;
    protected static readonly System.Int16[] yyDgoto;
    protected const int yyFinal = 4;
    protected static readonly System.Int16[] yyGindex;
    protected int yyMax;
    protected static readonly System.String[] yyNames;
    protected static readonly System.Int16[] yyRindex;
    protected static readonly System.Int16[] yySindex;
    protected static readonly System.Int16[] yyTable;
    public RncParser(System.Xml.XmlNameTable nameTable) { }
    public string BaseUri { get { return default(string); } }
    public int Column { get { return default(int); } }
    public int Line { get { return default(int); } }
    public Commons.Xml.Relaxng.RelaxngPattern Parse(System.IO.TextReader source) { return default(Commons.Xml.Relaxng.RelaxngPattern); }
    public Commons.Xml.Relaxng.RelaxngPattern Parse(System.IO.TextReader source, string baseUri) { return default(Commons.Xml.Relaxng.RelaxngPattern); }
    public Commons.Xml.Relaxng.RelaxngPattern Parse(System.IO.TextReader source, string baseUri, string defaultNamespace) { return default(Commons.Xml.Relaxng.RelaxngPattern); }
    public static Commons.Xml.Relaxng.RelaxngPattern ParseRnc(System.IO.TextReader reader) { return default(Commons.Xml.Relaxng.RelaxngPattern); }
    public static Commons.Xml.Relaxng.RelaxngPattern ParseRnc(System.IO.TextReader reader, System.Xml.XmlNameTable nameTable) { return default(Commons.Xml.Relaxng.RelaxngPattern); }
    public static Commons.Xml.Relaxng.RelaxngPattern ParseRnc(System.IO.TextReader reader, System.Xml.XmlNameTable nameTable, string baseUri) { return default(Commons.Xml.Relaxng.RelaxngPattern); }
    public static Commons.Xml.Relaxng.RelaxngPattern ParseRnc(System.IO.TextReader reader, System.Xml.XmlNameTable nameTable, string baseUri, string defaultNamespace) { return default(Commons.Xml.Relaxng.RelaxngPattern); }
    protected object yyDefault(object first) { return default(object); }
    public void yyerror(string message) { }
    public void yyerror(string message, System.String[] expected) { }
    protected System.String[] yyExpecting(int state) { return default(System.String[]); }
    protected System.Int32[] yyExpectingTokens(int state) { return default(System.Int32[]); }
    public static string yyname(int token) { return default(string); }
  }
}
namespace Commons.Xml.Relaxng.XmlSchema {
  public partial class XsdDatatypeProvider : Commons.Xml.Relaxng.RelaxngDatatypeProvider {
    internal XsdDatatypeProvider() { }
    public static Commons.Xml.Relaxng.XmlSchema.XsdDatatypeProvider Instance { get { return default(Commons.Xml.Relaxng.XmlSchema.XsdDatatypeProvider); } }
    public override Commons.Xml.Relaxng.RelaxngDatatype GetDatatype(string name, string ns, Commons.Xml.Relaxng.RelaxngParamList parameters) { return default(Commons.Xml.Relaxng.RelaxngDatatype); }
  }
  public partial class XsdPrimitiveType : Commons.Xml.Relaxng.RelaxngDatatype {
    public XsdPrimitiveType(string name, System.Xml.Schema.XmlSchemaDatatype xstype) { }
    public override string Name { get { return default(string); } }
    public override string NamespaceURI { get { return default(string); } }
    public override object Parse(string text, System.Xml.XmlReader reader) { return default(object); }
  }
  public partial class XsdQNameWrapper : Commons.Xml.Relaxng.RelaxngDatatype {
    public XsdQNameWrapper() { }
    public override string Name { get { return default(string); } }
    public override string NamespaceURI { get { return default(string); } }
    public override object Parse(string s, System.Xml.XmlReader reader) { return default(object); }
  }
  public partial class XsdSimpleRestrictionType : Commons.Xml.Relaxng.RelaxngDatatype {
    public XsdSimpleRestrictionType(Commons.Xml.Relaxng.RelaxngDatatype primitive, Commons.Xml.Relaxng.RelaxngParamList parameters) { }
    public override string Name { get { return default(string); } }
    public override string NamespaceURI { get { return default(string); } }
    public override object Parse(string value, System.Xml.XmlReader reader) { return default(object); }
  }
}
