namespace System.Diagnostics.SymbolStore {
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, MayLeakOnAbort=true)]
  public partial class SymBinder : System.Diagnostics.SymbolStore.SymBinderBase, System.Diagnostics.SymbolStore.ISymbolBinder, System.Diagnostics.SymbolStore.ISymbolBinder1, System.IDisposable {
    public SymBinder() { }
    public sealed override void Dispose() { }
    [System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptionsAttribute]
    protected virtual void Dispose(bool A_0) { }
    ~SymBinder() { }
    [System.ObsoleteAttribute("The recommended alternative is SymBinder.GetReader(IntPtr, String). ISymbolBinder1.GetReader takes the importer interface pointer as an IntPtr instead of an Int32, and thus works on both 32-bit and 64-bit architectures. http://go.microsoft.com/fwlink/?linkid=14202")]
    public virtual System.Diagnostics.SymbolStore.ISymbolReader GetReader(int importer, string filename, string searchPath) { return default(System.Diagnostics.SymbolStore.ISymbolReader); }
    public virtual System.Diagnostics.SymbolStore.ISymbolReader GetReader(System.IntPtr importer, string filename, string searchPath) { return default(System.Diagnostics.SymbolStore.ISymbolReader); }
  }
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public partial class SymBinderBase {
    protected SymBinderBase() { }
    public void {dtor}() { }
  }
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, MayLeakOnAbort=true)]
  public partial class SymDocument : System.Diagnostics.SymbolStore.SymDocumentBase, System.Diagnostics.SymbolStore.ISymbolDocument, System.IDisposable {
    public unsafe SymDocument(System.Diagnostics.SymbolStore.Private.ISymUnmanagedDocument* pDocument) { }
    public virtual System.Guid CheckSumAlgorithmId { get { return default(System.Guid); } }
    public virtual System.Guid DocumentType { get { return default(System.Guid); } }
    public virtual bool HasEmbeddedSource { get { return default(bool); } }
    public virtual System.Guid Language { get { return default(System.Guid); } }
    public virtual System.Guid LanguageVendor { get { return default(System.Guid); } }
    public virtual int SourceLength { get { return default(int); } }
    public virtual string URL { get { return default(string); } }
    public sealed override void Dispose() { }
    [System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptionsAttribute]
    protected virtual void Dispose(bool A_0) { }
    ~SymDocument() { }
    public virtual int FindClosestLine(int line) { return default(int); }
    public virtual System.Byte[] GetCheckSum() { return default(System.Byte[]); }
    public virtual System.Byte[] GetSourceRange(int startLine, int startColumn, int endLine, int endColumn) { return default(System.Byte[]); }
    public unsafe System.Diagnostics.SymbolStore.Private.ISymUnmanagedDocument* GetUnmanaged() { return default(System.Diagnostics.SymbolStore.Private.ISymUnmanagedDocument*); }
  }
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public partial class SymDocumentBase {
    protected SymDocumentBase() { }
    public void {dtor}() { }
  }
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, MayLeakOnAbort=true)]
  public partial class SymDocumentWriter : System.Diagnostics.SymbolStore.SymDocumentWriterBase, System.Diagnostics.SymbolStore.ISymbolDocumentWriter, System.IDisposable {
    public unsafe SymDocumentWriter(System.Diagnostics.SymbolStore.Private.ISymUnmanagedDocumentWriter* pDocumentWriter) { }
    public sealed override void Dispose() { }
    [System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptionsAttribute]
    protected virtual void Dispose(bool A_0) { }
    ~SymDocumentWriter() { }
    public unsafe System.Diagnostics.SymbolStore.Private.ISymUnmanagedDocumentWriter* GetUnmanaged() { return default(System.Diagnostics.SymbolStore.Private.ISymUnmanagedDocumentWriter*); }
    public virtual void SetCheckSum(System.Guid algorithmId, System.Byte[] source) { }
    public virtual void SetSource(System.Byte[] source) { }
  }
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public partial class SymDocumentWriterBase {
    protected SymDocumentWriterBase() { }
    public void {dtor}() { }
  }
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, MayLeakOnAbort=true)]
  public partial class SymMethod : System.Diagnostics.SymbolStore.SymMethodBase, System.Diagnostics.SymbolStore.ISymbolMethod, System.IDisposable {
    public unsafe SymMethod(System.Diagnostics.SymbolStore.Private.ISymUnmanagedMethod* pMethod) { }
    public virtual System.Diagnostics.SymbolStore.ISymbolScope RootScope { get { return default(System.Diagnostics.SymbolStore.ISymbolScope); } }
    public virtual int SequencePointCount { get { return default(int); } }
    public virtual System.Diagnostics.SymbolStore.SymbolToken Token { get { return default(System.Diagnostics.SymbolStore.SymbolToken); } }
    public sealed override void Dispose() { }
    [System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptionsAttribute]
    protected virtual void Dispose(bool A_0) { }
    ~SymMethod() { }
    public virtual System.Diagnostics.SymbolStore.ISymbolNamespace GetNamespace() { return default(System.Diagnostics.SymbolStore.ISymbolNamespace); }
    public virtual int GetOffset(System.Diagnostics.SymbolStore.ISymbolDocument document, int line, int column) { return default(int); }
    public virtual System.Diagnostics.SymbolStore.ISymbolVariable[] GetParameters() { return default(System.Diagnostics.SymbolStore.ISymbolVariable[]); }
    public virtual System.Int32[] GetRanges(System.Diagnostics.SymbolStore.ISymbolDocument document, int line, int column) { return default(System.Int32[]); }
    public virtual System.Diagnostics.SymbolStore.ISymbolScope GetScope(int offset) { return default(System.Diagnostics.SymbolStore.ISymbolScope); }
    public virtual void GetSequencePoints(System.Int32[] offsets, System.Diagnostics.SymbolStore.ISymbolDocument[] documents, System.Int32[] lines, System.Int32[] columns, System.Int32[] endLines, System.Int32[] endColumns) { }
    public virtual bool GetSourceStartEnd(System.Diagnostics.SymbolStore.ISymbolDocument[] docs, System.Int32[] lines, System.Int32[] columns) { return default(bool); }
    public virtual System.Diagnostics.SymbolStore.ISymbolScope RootScopeInternal() { return default(System.Diagnostics.SymbolStore.ISymbolScope); }
  }
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public partial class SymMethodBase {
    protected SymMethodBase() { }
    public void {dtor}() { }
  }
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, MayLeakOnAbort=true)]
  public partial class SymReader : System.Diagnostics.SymbolStore.SymReaderBase, System.Diagnostics.SymbolStore.ISymbolReader, System.IDisposable {
    public unsafe SymReader(System.Diagnostics.SymbolStore.Private.ISymUnmanagedReader* pReader) { }
    public virtual System.Diagnostics.SymbolStore.SymbolToken UserEntryPoint { get { return default(System.Diagnostics.SymbolStore.SymbolToken); } }
    public sealed override void Dispose() { }
    [System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptionsAttribute]
    protected virtual void Dispose(bool A_0) { }
    ~SymReader() { }
    public virtual System.Diagnostics.SymbolStore.ISymbolDocument GetDocument(string url, System.Guid language, System.Guid languageVendor, System.Guid documentType) { return default(System.Diagnostics.SymbolStore.ISymbolDocument); }
    public virtual System.Diagnostics.SymbolStore.ISymbolDocument[] GetDocuments() { return default(System.Diagnostics.SymbolStore.ISymbolDocument[]); }
    public virtual System.Diagnostics.SymbolStore.ISymbolVariable[] GetGlobalVariables() { return default(System.Diagnostics.SymbolStore.ISymbolVariable[]); }
    public virtual System.Diagnostics.SymbolStore.ISymbolMethod GetMethod(System.Diagnostics.SymbolStore.SymbolToken method) { return default(System.Diagnostics.SymbolStore.ISymbolMethod); }
    public virtual System.Diagnostics.SymbolStore.ISymbolMethod GetMethod(System.Diagnostics.SymbolStore.SymbolToken method, int version) { return default(System.Diagnostics.SymbolStore.ISymbolMethod); }
    public virtual System.Diagnostics.SymbolStore.ISymbolMethod GetMethodFromDocumentPosition(System.Diagnostics.SymbolStore.ISymbolDocument document, int line, int column) { return default(System.Diagnostics.SymbolStore.ISymbolMethod); }
    public virtual System.Diagnostics.SymbolStore.ISymbolNamespace[] GetNamespaces() { return default(System.Diagnostics.SymbolStore.ISymbolNamespace[]); }
    public virtual System.Byte[] GetSymAttribute(System.Diagnostics.SymbolStore.SymbolToken parent, string name) { return default(System.Byte[]); }
    public virtual System.Diagnostics.SymbolStore.ISymbolVariable[] GetVariables(System.Diagnostics.SymbolStore.SymbolToken parent) { return default(System.Diagnostics.SymbolStore.ISymbolVariable[]); }
    public virtual void ReplaceSymbolStore(string fileName, System.IntPtr stream) { }
    public virtual void UpdateSymbolStore(string fileName, System.IntPtr stream) { }
  }
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public partial class SymReaderBase {
    protected SymReaderBase() { }
    public void {dtor}() { }
  }
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, MayLeakOnAbort=true)]
  public partial class SymScope : System.Diagnostics.SymbolStore.SymScopeBase, System.Diagnostics.SymbolStore.ISymbolScope, System.IDisposable {
    public unsafe SymScope(System.Diagnostics.SymbolStore.Private.ISymUnmanagedScope* pScope) { }
    public virtual int EndOffset { get { return default(int); } }
    public virtual System.Diagnostics.SymbolStore.ISymbolMethod Method { get { return default(System.Diagnostics.SymbolStore.ISymbolMethod); } }
    public virtual System.Diagnostics.SymbolStore.ISymbolScope Parent { get { return default(System.Diagnostics.SymbolStore.ISymbolScope); } }
    public virtual int StartOffset { get { return default(int); } }
    public sealed override void Dispose() { }
    [System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptionsAttribute]
    protected virtual void Dispose(bool A_0) { }
    ~SymScope() { }
    public virtual System.Diagnostics.SymbolStore.ISymbolScope[] GetChildren() { return default(System.Diagnostics.SymbolStore.ISymbolScope[]); }
    public virtual System.Diagnostics.SymbolStore.ISymbolVariable[] GetLocals() { return default(System.Diagnostics.SymbolStore.ISymbolVariable[]); }
    public virtual System.Diagnostics.SymbolStore.ISymbolNamespace[] GetNamespaces() { return default(System.Diagnostics.SymbolStore.ISymbolNamespace[]); }
  }
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public partial class SymScopeBase {
    protected SymScopeBase() { }
    public void {dtor}() { }
  }
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, MayLeakOnAbort=true)]
  public partial class SymVariable : System.Diagnostics.SymbolStore.SymVariableBase, System.Diagnostics.SymbolStore.ISymbolVariable, System.IDisposable {
    public unsafe SymVariable(System.Diagnostics.SymbolStore.Private.ISymUnmanagedVariable* pVariable) { }
    public virtual int AddressField1 { get { return default(int); } }
    public virtual int AddressField2 { get { return default(int); } }
    public virtual int AddressField3 { get { return default(int); } }
    public virtual System.Diagnostics.SymbolStore.SymAddressKind AddressKind { get { return default(System.Diagnostics.SymbolStore.SymAddressKind); } }
    public virtual object Attributes { get { return default(object); } }
    public virtual int EndOffset { get { return default(int); } }
    public virtual string Name { get { return default(string); } }
    public virtual int StartOffset { get { return default(int); } }
    public sealed override void Dispose() { }
    [System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptionsAttribute]
    protected virtual void Dispose(bool A_0) { }
    ~SymVariable() { }
    public virtual System.Byte[] GetSignature() { return default(System.Byte[]); }
  }
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public partial class SymVariableBase {
    protected SymVariableBase() { }
    public void {dtor}() { }
  }
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, MayLeakOnAbort=true)]
  public partial class SymWriter : System.Diagnostics.SymbolStore.SymWriterBase, System.Diagnostics.SymbolStore.ISymbolWriter, System.IDisposable {
    public SymWriter() { }
    public SymWriter(bool noUnderlyingWriter) { }
    public virtual void Close() { }
    public virtual void CloseMethod() { }
    public virtual void CloseNamespace() { }
    public virtual void CloseScope(int endOffset) { }
    public virtual System.Diagnostics.SymbolStore.ISymbolDocumentWriter DefineDocument(string url, System.Guid language, System.Guid languageVendor, System.Guid documentType) { return default(System.Diagnostics.SymbolStore.ISymbolDocumentWriter); }
    public virtual void DefineField(System.Diagnostics.SymbolStore.SymbolToken parent, string name, System.Reflection.FieldAttributes attributes, System.Byte[] signature, System.Diagnostics.SymbolStore.SymAddressKind addrKind, int addr1, int addr2, int addr3) { }
    public virtual void DefineGlobalVariable(string name, System.Reflection.FieldAttributes attributes, System.Byte[] signature, System.Diagnostics.SymbolStore.SymAddressKind addrKind, int addr1, int addr2, int addr3) { }
    public virtual void DefineLocalVariable(string name, System.Reflection.FieldAttributes attributes, System.Byte[] signature, System.Diagnostics.SymbolStore.SymAddressKind addrKind, int addr1, int addr2, int addr3, int startOffset, int endOffset) { }
    public virtual void DefineParameter(string name, System.Reflection.ParameterAttributes attributes, int sequence, System.Diagnostics.SymbolStore.SymAddressKind addrKind, int addr1, int addr2, int addr3) { }
    public virtual void DefineSequencePoints(System.Diagnostics.SymbolStore.ISymbolDocumentWriter document, System.Int32[] offsets, System.Int32[] lines, System.Int32[] columns, System.Int32[] endLines, System.Int32[] endColumns) { }
    public sealed override void Dispose() { }
    [System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptionsAttribute]
    protected virtual void Dispose(bool A_0) { }
    ~SymWriter() { }
    public unsafe System.Diagnostics.SymbolStore.Private.ISymUnmanagedWriter* GetWriter() { return default(System.Diagnostics.SymbolStore.Private.ISymUnmanagedWriter*); }
    public virtual void Initialize(System.IntPtr emitter, string filename, bool fFullBuild) { }
    public void InitWriter(bool noUnderlyingWriter) { }
    public virtual void OpenMethod(System.Diagnostics.SymbolStore.SymbolToken method) { }
    public virtual void OpenNamespace(string name) { }
    public virtual int OpenScope(int startOffset) { return default(int); }
    public virtual void SetMethodSourceRange(System.Diagnostics.SymbolStore.ISymbolDocumentWriter startDoc, int startLine, int startColumn, System.Diagnostics.SymbolStore.ISymbolDocumentWriter endDoc, int endLine, int endColumn) { }
    public virtual void SetScopeRange(int scopeID, int startOffset, int endOffset) { }
    public virtual void SetSymAttribute(System.Diagnostics.SymbolStore.SymbolToken parent, string name, System.Byte[] data) { }
    public virtual void SetUnderlyingWriter(System.IntPtr underlyingWriter) { }
    public virtual void SetUserEntryPoint(System.Diagnostics.SymbolStore.SymbolToken entryMethod) { }
    public virtual void UsingNamespace(string fullName) { }
  }
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public partial class SymWriterBase {
    protected SymWriterBase() { }
    public void {dtor}() { }
  }
}
