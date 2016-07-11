namespace Mono.Cecil.Mdb {
  public partial class MdbReader : Mono.Cecil.Cil.ISymbolReader, System.IDisposable {
    public MdbReader(Mono.Cecil.ModuleDefinition module, Mono.CompilerServices.SymbolWriter.MonoSymbolFile symFile) { }
    public void Dispose() { }
    public bool ProcessDebugHeader(Mono.Cecil.Cil.ImageDebugDirectory directory, System.Byte[] header) { return default(bool); }
    public void Read(Mono.Cecil.Cil.MethodBody body, Mono.Cecil.Cil.InstructionMapper mapper) { }
    public void Read(Mono.Cecil.Cil.MethodSymbols symbols) { }
  }
  public partial class MdbReaderProvider : Mono.Cecil.Cil.ISymbolReaderProvider {
    public MdbReaderProvider() { }
    public Mono.Cecil.Cil.ISymbolReader GetSymbolReader(Mono.Cecil.ModuleDefinition module, System.IO.Stream symbolStream) { return default(Mono.Cecil.Cil.ISymbolReader); }
    public Mono.Cecil.Cil.ISymbolReader GetSymbolReader(Mono.Cecil.ModuleDefinition module, string fileName) { return default(Mono.Cecil.Cil.ISymbolReader); }
  }
  public partial class MdbWriter : Mono.Cecil.Cil.ISymbolWriter, System.IDisposable {
    public MdbWriter(System.Guid mvid, string assembly) { }
    public void Dispose() { }
    public bool GetDebugHeader(out Mono.Cecil.Cil.ImageDebugDirectory directory, out System.Byte[] header) { directory = default(Mono.Cecil.Cil.ImageDebugDirectory); header = default(System.Byte[]); return default(bool); }
    public void Write(Mono.Cecil.Cil.MethodBody body) { }
    public void Write(Mono.Cecil.Cil.MethodSymbols symbols) { }
  }
  public partial class MdbWriterProvider : Mono.Cecil.Cil.ISymbolWriterProvider {
    public MdbWriterProvider() { }
    public Mono.Cecil.Cil.ISymbolWriter GetSymbolWriter(Mono.Cecil.ModuleDefinition module, System.IO.Stream symbolStream) { return default(Mono.Cecil.Cil.ISymbolWriter); }
    public Mono.Cecil.Cil.ISymbolWriter GetSymbolWriter(Mono.Cecil.ModuleDefinition module, string fileName) { return default(Mono.Cecil.Cil.ISymbolWriter); }
  }
}
namespace Mono.CompilerServices.SymbolWriter {
  public partial class AnonymousScopeEntry {
    public readonly int ID;
    public AnonymousScopeEntry(int id) { }
    public Mono.CompilerServices.SymbolWriter.CapturedScope[] CapturedScopes { get { return default(Mono.CompilerServices.SymbolWriter.CapturedScope[]); } }
    public Mono.CompilerServices.SymbolWriter.CapturedVariable[] CapturedVariables { get { return default(Mono.CompilerServices.SymbolWriter.CapturedVariable[]); } }
    public override string ToString() { return default(string); }
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct CapturedScope {
    public readonly string CapturedName;
    public readonly int Scope;
    public CapturedScope(int scope, string captured_name) { throw new System.NotImplementedException(); }
    public override string ToString() { return default(string); }
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct CapturedVariable {
    public readonly string CapturedName;
    public readonly Mono.CompilerServices.SymbolWriter.CapturedVariable.CapturedKind Kind;
    public readonly string Name;
    public CapturedVariable(string name, string captured_name, Mono.CompilerServices.SymbolWriter.CapturedVariable.CapturedKind kind) { throw new System.NotImplementedException(); }
    public override string ToString() { return default(string); }
    public enum CapturedKind : byte {
      Local = (byte)0,
      Parameter = (byte)1,
      This = (byte)2,
    }
  }
  public partial class CodeBlockEntry {
    public Mono.CompilerServices.SymbolWriter.CodeBlockEntry.Type BlockType;
    public int EndOffset;
    public int Index;
    public int Parent;
    public int StartOffset;
    public CodeBlockEntry(int index, int parent, Mono.CompilerServices.SymbolWriter.CodeBlockEntry.Type type, int start_offset) { }
    public void Close(int end_offset) { }
    public override string ToString() { return default(string); }
    public enum Type {
      CompilerGenerated = 2,
      IteratorBody = 3,
      IteratorDispatcher = 4,
      Lexical = 1,
    }
  }
  public partial class CompileUnitEntry : Mono.CompilerServices.SymbolWriter.ICompileUnit {
    public readonly int Index;
    public CompileUnitEntry(Mono.CompilerServices.SymbolWriter.MonoSymbolFile file, Mono.CompilerServices.SymbolWriter.SourceFileEntry source) { }
    public Mono.CompilerServices.SymbolWriter.SourceFileEntry[] IncludeFiles { get { return default(Mono.CompilerServices.SymbolWriter.SourceFileEntry[]); } }
    Mono.CompilerServices.SymbolWriter.CompileUnitEntry Mono.CompilerServices.SymbolWriter.ICompileUnit.Entry { get { return default(Mono.CompilerServices.SymbolWriter.CompileUnitEntry); } }
    public Mono.CompilerServices.SymbolWriter.NamespaceEntry[] Namespaces { get { return default(Mono.CompilerServices.SymbolWriter.NamespaceEntry[]); } }
    public static int Size { get { return default(int); } }
    public Mono.CompilerServices.SymbolWriter.SourceFileEntry SourceFile { get { return default(Mono.CompilerServices.SymbolWriter.SourceFileEntry); } }
    public void AddFile(Mono.CompilerServices.SymbolWriter.SourceFileEntry file) { }
    public int DefineNamespace(string name, System.String[] using_clauses, int parent) { return default(int); }
  }
  public partial interface ICompileUnit {
    Mono.CompilerServices.SymbolWriter.CompileUnitEntry Entry { get; }
  }
  public partial interface IMethodDef {
    string Name { get; }
    int Token { get; }
  }
  public partial interface ISourceFile {
    Mono.CompilerServices.SymbolWriter.SourceFileEntry Entry { get; }
  }
  public partial class LineNumberEntry {
    public readonly int File;
    public readonly bool IsHidden;
    public static Mono.CompilerServices.SymbolWriter.LineNumberEntry Null;
    public readonly int Offset;
    public static readonly System.Collections.Generic.IComparer<Mono.CompilerServices.SymbolWriter.LineNumberEntry> OffsetComparer;
    public readonly int Row;
    public static readonly System.Collections.Generic.IComparer<Mono.CompilerServices.SymbolWriter.LineNumberEntry> RowComparer;
    public LineNumberEntry(int file, int row, int offset) { }
    public LineNumberEntry(int file, int row, int offset, bool is_hidden) { }
    public override string ToString() { return default(string); }
  }
  public partial class LineNumberTable {
    protected Mono.CompilerServices.SymbolWriter.LineNumberEntry[] _line_numbers;
    public const int Default_LineBase = -1;
    public const int Default_LineRange = 8;
    public const byte Default_OpcodeBase = (byte)9;
    public const byte DW_LNE_end_sequence = (byte)1;
    public const byte DW_LNE_MONO_negate_is_hidden = (byte)64;
    public const byte DW_LNS_advance_line = (byte)3;
    public const byte DW_LNS_advance_pc = (byte)2;
    public const byte DW_LNS_const_add_pc = (byte)8;
    public const byte DW_LNS_copy = (byte)1;
    public const byte DW_LNS_set_file = (byte)4;
    public readonly int LineBase;
    public readonly int LineRange;
    public readonly int MaxAddressIncrement;
    public readonly byte OpcodeBase;
    public const bool SuppressDuplicates = true;
    protected LineNumberTable(Mono.CompilerServices.SymbolWriter.MonoSymbolFile file) { }
    public Mono.CompilerServices.SymbolWriter.LineNumberEntry[] LineNumbers { get { return default(Mono.CompilerServices.SymbolWriter.LineNumberEntry[]); } }
    public bool GetMethodBounds(out Mono.CompilerServices.SymbolWriter.LineNumberEntry start, out Mono.CompilerServices.SymbolWriter.LineNumberEntry end) { start = default(Mono.CompilerServices.SymbolWriter.LineNumberEntry); end = default(Mono.CompilerServices.SymbolWriter.LineNumberEntry); return default(bool); }
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct LocalVariableEntry {
    public readonly int BlockIndex;
    public readonly int Index;
    public readonly string Name;
    public LocalVariableEntry(int index, string name, int block) { throw new System.NotImplementedException(); }
    public override string ToString() { return default(string); }
  }
  public partial class MethodEntry : System.IComparable {
    internal MethodEntry() { }
    public readonly Mono.CompilerServices.SymbolWriter.CompileUnitEntry CompileUnit;
    public readonly int CompileUnitIndex;
    public readonly int NamespaceID;
    public const int Size = 12;
    public readonly Mono.CompilerServices.SymbolWriter.MonoSymbolFile SymbolFile;
    public readonly int Token;
    public int Index { get { return default(int); } set { } }
    public Mono.CompilerServices.SymbolWriter.MethodEntry.Flags MethodFlags { get { return default(Mono.CompilerServices.SymbolWriter.MethodEntry.Flags); } }
    public int CompareTo(object obj) { return default(int); }
    public Mono.CompilerServices.SymbolWriter.CodeBlockEntry[] GetCodeBlocks() { return default(Mono.CompilerServices.SymbolWriter.CodeBlockEntry[]); }
    public Mono.CompilerServices.SymbolWriter.LineNumberTable GetLineNumberTable() { return default(Mono.CompilerServices.SymbolWriter.LineNumberTable); }
    public Mono.CompilerServices.SymbolWriter.LocalVariableEntry[] GetLocals() { return default(Mono.CompilerServices.SymbolWriter.LocalVariableEntry[]); }
    public string GetRealName() { return default(string); }
    public Mono.CompilerServices.SymbolWriter.ScopeVariable[] GetScopeVariables() { return default(Mono.CompilerServices.SymbolWriter.ScopeVariable[]); }
    public override string ToString() { return default(string); }
    [System.FlagsAttribute]
    public enum Flags {
      LocalNamesAmbiguous = 1,
    }
  }
  public partial class MonoSymbolFile : System.IDisposable {
    public readonly string FileName;
    public readonly int MajorVersion;
    public readonly int MinorVersion;
    public int NumLineNumbers;
    protected MonoSymbolFile(string filename, Mono.Cecil.ModuleDefinition module) { }
    public int AnonymousScopeCount { get { return default(int); } }
    public int CompileUnitCount { get { return default(int); } }
    public Mono.CompilerServices.SymbolWriter.CompileUnitEntry[] CompileUnits { get { return default(Mono.CompilerServices.SymbolWriter.CompileUnitEntry[]); } }
    public System.Guid Guid { get { return default(System.Guid); } }
    public int MethodCount { get { return default(int); } }
    public Mono.CompilerServices.SymbolWriter.MethodEntry[] Methods { get { return default(Mono.CompilerServices.SymbolWriter.MethodEntry[]); } }
    public int NamespaceCount { get { return default(int); } }
    public Mono.CompilerServices.SymbolWriter.OffsetTable OffsetTable { get { return default(Mono.CompilerServices.SymbolWriter.OffsetTable); } }
    public int SourceCount { get { return default(int); } }
    public Mono.CompilerServices.SymbolWriter.SourceFileEntry[] Sources { get { return default(Mono.CompilerServices.SymbolWriter.SourceFileEntry[]); } }
    public int TypeCount { get { return default(int); } }
    public void CreateSymbolFile(System.Guid guid, System.IO.FileStream fs) { }
    public Mono.CompilerServices.SymbolWriter.MethodEntry DefineMethod(Mono.CompilerServices.SymbolWriter.CompileUnitEntry comp_unit, int token, Mono.CompilerServices.SymbolWriter.ScopeVariable[] scope_vars, Mono.CompilerServices.SymbolWriter.LocalVariableEntry[] locals, Mono.CompilerServices.SymbolWriter.LineNumberEntry[] lines, Mono.CompilerServices.SymbolWriter.CodeBlockEntry[] code_blocks, string real_name, Mono.CompilerServices.SymbolWriter.MethodEntry.Flags flags, int namespace_id) { return default(Mono.CompilerServices.SymbolWriter.MethodEntry); }
    public void Dispose() { }
    protected virtual void Dispose(bool disposing) { }
    public int FindSource(string file_name) { return default(int); }
    public Mono.CompilerServices.SymbolWriter.AnonymousScopeEntry GetAnonymousScope(int id) { return default(Mono.CompilerServices.SymbolWriter.AnonymousScopeEntry); }
    public Mono.CompilerServices.SymbolWriter.CompileUnitEntry GetCompileUnit(int index) { return default(Mono.CompilerServices.SymbolWriter.CompileUnitEntry); }
    public Mono.CompilerServices.SymbolWriter.MethodEntry GetMethod(int index) { return default(Mono.CompilerServices.SymbolWriter.MethodEntry); }
    public Mono.CompilerServices.SymbolWriter.MethodEntry GetMethodByToken(int token) { return default(Mono.CompilerServices.SymbolWriter.MethodEntry); }
    public Mono.CompilerServices.SymbolWriter.SourceFileEntry GetSourceFile(int index) { return default(Mono.CompilerServices.SymbolWriter.SourceFileEntry); }
    public static Mono.CompilerServices.SymbolWriter.MonoSymbolFile ReadSymbolFile(Mono.Cecil.ModuleDefinition module) { return default(Mono.CompilerServices.SymbolWriter.MonoSymbolFile); }
    public static Mono.CompilerServices.SymbolWriter.MonoSymbolFile ReadSymbolFile(Mono.Cecil.ModuleDefinition module, string filename) { return default(Mono.CompilerServices.SymbolWriter.MonoSymbolFile); }
    public static Mono.CompilerServices.SymbolWriter.MonoSymbolFile ReadSymbolFile(string mdbFilename) { return default(Mono.CompilerServices.SymbolWriter.MonoSymbolFile); }
  }
  public partial class MonoSymbolFileException : System.Exception {
    public MonoSymbolFileException() { }
    public MonoSymbolFileException(string message, params System.Object[] args) { }
  }
  public partial class MonoSymbolWriter {
    protected readonly Mono.CompilerServices.SymbolWriter.MonoSymbolFile file;
    public MonoSymbolWriter(string filename) { }
    public Mono.CompilerServices.SymbolWriter.MonoSymbolFile SymbolFile { get { return default(Mono.CompilerServices.SymbolWriter.MonoSymbolFile); } }
    public void CloseCompilerGeneratedBlock(int end_offset) { }
    public void CloseMethod() { }
    public void CloseNamespace() { }
    public void CloseScope(int end_offset) { }
    public void DefineAnonymousScope(int id) { }
    public void DefineCapturedLocal(int scope_id, string name, string captured_name) { }
    public void DefineCapturedParameter(int scope_id, string name, string captured_name) { }
    public void DefineCapturedScope(int scope_id, int id, string captured_name) { }
    public void DefineCapturedThis(int scope_id, string captured_name) { }
    public Mono.CompilerServices.SymbolWriter.CompileUnitEntry DefineCompilationUnit(Mono.CompilerServices.SymbolWriter.SourceFileEntry source) { return default(Mono.CompilerServices.SymbolWriter.CompileUnitEntry); }
    public Mono.CompilerServices.SymbolWriter.SourceFileEntry DefineDocument(string url) { return default(Mono.CompilerServices.SymbolWriter.SourceFileEntry); }
    public Mono.CompilerServices.SymbolWriter.SourceFileEntry DefineDocument(string url, System.Byte[] guid, System.Byte[] checksum) { return default(Mono.CompilerServices.SymbolWriter.SourceFileEntry); }
    public void DefineLocalVariable(int index, string name) { }
    public int DefineNamespace(string name, Mono.CompilerServices.SymbolWriter.CompileUnitEntry unit, System.String[] using_clauses, int parent) { return default(int); }
    public void DefineScopeVariable(int scope, int index) { }
    public void EndIteratorBody(int end_offset) { }
    public void EndIteratorDispatcher(int end_offset) { }
    public void MarkSequencePoint(int offset, Mono.CompilerServices.SymbolWriter.SourceFileEntry file, int line, int column, bool is_hidden) { }
    public void OpenCompilerGeneratedBlock(int start_offset) { }
    public Mono.CompilerServices.SymbolWriter.SourceMethodBuilder OpenMethod(Mono.CompilerServices.SymbolWriter.ICompileUnit file, int ns_id, Mono.CompilerServices.SymbolWriter.IMethodDef method) { return default(Mono.CompilerServices.SymbolWriter.SourceMethodBuilder); }
    public int OpenScope(int start_offset) { return default(int); }
    public void StartIteratorBody(int start_offset) { }
    public void StartIteratorDispatcher(int start_offset) { }
    public void WriteSymbolFile(System.Guid guid) { }
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct NamespaceEntry {
    public readonly int Index;
    public readonly string Name;
    public readonly int Parent;
    public readonly System.String[] UsingClauses;
    public NamespaceEntry(string name, int index, System.String[] using_clauses, int parent) { throw new System.NotImplementedException(); }
    public override string ToString() { return default(string); }
  }
  public partial class OffsetTable {
    internal OffsetTable() { }
    public int AnonymousScopeCount;
    public int AnonymousScopeTableOffset;
    public int AnonymousScopeTableSize;
    public int CompileUnitCount;
    public int CompileUnitTableOffset;
    public int CompileUnitTableSize;
    public int DataSectionOffset;
    public int DataSectionSize;
    public Mono.CompilerServices.SymbolWriter.OffsetTable.Flags FileFlags;
    public int LineNumberTable_LineBase;
    public int LineNumberTable_LineRange;
    public int LineNumberTable_OpcodeBase;
    public const long Magic = (long)5037318119232611860;
    public const int MajorVersion = 50;
    public int MethodCount;
    public int MethodTableOffset;
    public int MethodTableSize;
    public const int MinorVersion = 0;
    public int SourceCount;
    public int SourceTableOffset;
    public int SourceTableSize;
    public int TotalFileSize;
    public int TypeCount;
    public override string ToString() { return default(string); }
    [System.FlagsAttribute]
    public enum Flags {
      IsAspxSource = 1,
      WindowsFileNames = 2,
    }
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct ScopeVariable {
    public readonly int Index;
    public readonly int Scope;
    public ScopeVariable(int scope, int index) { throw new System.NotImplementedException(); }
    public override string ToString() { return default(string); }
  }
  public partial class SourceFileEntry {
    public readonly int Index;
    public SourceFileEntry(Mono.CompilerServices.SymbolWriter.MonoSymbolFile file, string file_name) { }
    public SourceFileEntry(Mono.CompilerServices.SymbolWriter.MonoSymbolFile file, string file_name, System.Byte[] guid, System.Byte[] checksum) { }
    public bool AutoGenerated { get { return default(bool); } }
    public string FileName { get { return default(string); } }
    public static int Size { get { return default(int); } }
    public bool CheckChecksum() { return default(bool); }
    public void SetAutoGenerated() { }
    public override string ToString() { return default(string); }
  }
  public partial class SourceMethodBuilder {
    public SourceMethodBuilder(Mono.CompilerServices.SymbolWriter.ICompileUnit comp_unit, int ns_id, Mono.CompilerServices.SymbolWriter.IMethodDef method) { }
    public Mono.CompilerServices.SymbolWriter.CodeBlockEntry[] Blocks { get { return default(Mono.CompilerServices.SymbolWriter.CodeBlockEntry[]); } }
    public Mono.CompilerServices.SymbolWriter.CodeBlockEntry CurrentBlock { get { return default(Mono.CompilerServices.SymbolWriter.CodeBlockEntry); } }
    public Mono.CompilerServices.SymbolWriter.LocalVariableEntry[] Locals { get { return default(Mono.CompilerServices.SymbolWriter.LocalVariableEntry[]); } }
    public Mono.CompilerServices.SymbolWriter.IMethodDef Method { get { return default(Mono.CompilerServices.SymbolWriter.IMethodDef); } }
    public string RealMethodName { get { return default(string); } }
    public Mono.CompilerServices.SymbolWriter.ScopeVariable[] ScopeVariables { get { return default(Mono.CompilerServices.SymbolWriter.ScopeVariable[]); } }
    public Mono.CompilerServices.SymbolWriter.ICompileUnit SourceFile { get { return default(Mono.CompilerServices.SymbolWriter.ICompileUnit); } }
    public void AddLocal(int index, string name) { }
    public void AddScopeVariable(int scope, int index) { }
    public void DefineMethod(Mono.CompilerServices.SymbolWriter.MonoSymbolFile file) { }
    public void EndBlock(int end_offset) { }
    public void MarkSequencePoint(int offset, Mono.CompilerServices.SymbolWriter.SourceFileEntry file, int line, int column, bool is_hidden) { }
    public void SetRealMethodName(string name) { }
    public void StartBlock(Mono.CompilerServices.SymbolWriter.CodeBlockEntry.Type type, int start_offset) { }
  }
  public partial class SymbolWriterImpl : System.Diagnostics.SymbolStore.ISymbolWriter {
    public SymbolWriterImpl(System.Guid guid) { }
    public void Close() { }
    public void CloseMethod() { }
    public void CloseNamespace() { }
    public void CloseScope(int endOffset) { }
    public System.Diagnostics.SymbolStore.ISymbolDocumentWriter DefineDocument(string url, System.Guid language, System.Guid languageVendor, System.Guid documentType) { return default(System.Diagnostics.SymbolStore.ISymbolDocumentWriter); }
    public void DefineField(System.Diagnostics.SymbolStore.SymbolToken parent, string name, System.Reflection.FieldAttributes attributes, System.Byte[] signature, System.Diagnostics.SymbolStore.SymAddressKind addrKind, int addr1, int addr2, int addr3) { }
    public void DefineGlobalVariable(string name, System.Reflection.FieldAttributes attributes, System.Byte[] signature, System.Diagnostics.SymbolStore.SymAddressKind addrKind, int addr1, int addr2, int addr3) { }
    public void DefineLocalVariable(string name, System.Reflection.FieldAttributes attributes, System.Byte[] signature, System.Diagnostics.SymbolStore.SymAddressKind addrKind, int addr1, int addr2, int addr3, int startOffset, int endOffset) { }
    public void DefineParameter(string name, System.Reflection.ParameterAttributes attributes, int sequence, System.Diagnostics.SymbolStore.SymAddressKind addrKind, int addr1, int addr2, int addr3) { }
    public void DefineSequencePoints(System.Diagnostics.SymbolStore.ISymbolDocumentWriter document, System.Int32[] offsets, System.Int32[] lines, System.Int32[] columns, System.Int32[] endLines, System.Int32[] endColumns) { }
    public void Initialize(System.IntPtr emitter, string filename, bool fFullBuild) { }
    public void OpenMethod(System.Diagnostics.SymbolStore.SymbolToken method) { }
    public void OpenNamespace(string name) { }
    public int OpenScope(int startOffset) { return default(int); }
    public void SetMethodSourceRange(System.Diagnostics.SymbolStore.ISymbolDocumentWriter startDoc, int startLine, int startColumn, System.Diagnostics.SymbolStore.ISymbolDocumentWriter endDoc, int endLine, int endColumn) { }
    public void SetScopeRange(int scopeID, int startOffset, int endOffset) { }
    public void SetSymAttribute(System.Diagnostics.SymbolStore.SymbolToken parent, string name, System.Byte[] data) { }
    public void SetUnderlyingWriter(System.IntPtr underlyingWriter) { }
    public void SetUserEntryPoint(System.Diagnostics.SymbolStore.SymbolToken entryMethod) { }
    public void UsingNamespace(string fullName) { }
  }
}
