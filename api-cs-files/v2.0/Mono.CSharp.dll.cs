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
    public void ReadAll() { }
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
    public int Column;
    public int EndColumn;
    public int EndRow;
    public readonly int File;
    public readonly bool IsHidden;
    public static readonly Mono.CompilerServices.SymbolWriter.LineNumberEntry Null;
    public readonly int Offset;
    public readonly int Row;
    public LineNumberEntry(int file, int row, int offset) { }
    public LineNumberEntry(int file, int row, int column, int offset) { }
    public LineNumberEntry(int file, int row, int column, int offset, bool is_hidden) { }
    public LineNumberEntry(int file, int row, int column, int end_row, int end_column, int offset, bool is_hidden) { }
    public override string ToString() { return default(string); }
    public sealed partial class LocationComparer : System.Collections.Generic.IComparer<Mono.CompilerServices.SymbolWriter.LineNumberEntry> {
      public static readonly Mono.CompilerServices.SymbolWriter.LineNumberEntry.LocationComparer Default;
      public LocationComparer() { }
      public int Compare(Mono.CompilerServices.SymbolWriter.LineNumberEntry l1, Mono.CompilerServices.SymbolWriter.LineNumberEntry l2) { return default(int); }
    }
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
    public void ReadAll() { }
    public override string ToString() { return default(string); }
    [System.FlagsAttribute]
    public enum Flags {
      ColumnsInfoIncluded = 2,
      EndInfoIncluded = 4,
      LocalNamesAmbiguous = 1,
    }
  }
  public partial class MonoSymbolFile : System.IDisposable {
    public readonly int MajorVersion;
    public readonly int MinorVersion;
    public int NumLineNumbers;
    public MonoSymbolFile() { }
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
    public int AddCompileUnit(Mono.CompilerServices.SymbolWriter.CompileUnitEntry entry) { return default(int); }
    public void AddMethod(Mono.CompilerServices.SymbolWriter.MethodEntry entry) { }
    public int AddSource(Mono.CompilerServices.SymbolWriter.SourceFileEntry source) { return default(int); }
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
    public static Mono.CompilerServices.SymbolWriter.MonoSymbolFile ReadSymbolFile(System.IO.Stream stream) { return default(Mono.CompilerServices.SymbolWriter.MonoSymbolFile); }
    public static Mono.CompilerServices.SymbolWriter.MonoSymbolFile ReadSymbolFile(System.Reflection.Assembly assembly) { return default(Mono.CompilerServices.SymbolWriter.MonoSymbolFile); }
    public static Mono.CompilerServices.SymbolWriter.MonoSymbolFile ReadSymbolFile(string mdbFilename) { return default(Mono.CompilerServices.SymbolWriter.MonoSymbolFile); }
    public static Mono.CompilerServices.SymbolWriter.MonoSymbolFile ReadSymbolFile(string mdbFilename, System.Guid assemblyGuid) { return default(Mono.CompilerServices.SymbolWriter.MonoSymbolFile); }
  }
  public partial class MonoSymbolFileException : System.Exception {
    public MonoSymbolFileException() { }
    public MonoSymbolFileException(string message, System.Exception innerException) { }
    public MonoSymbolFileException(string message, params System.Object[] args) { }
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
    public System.Byte[] Checksum { get { return default(System.Byte[]); } }
    public string FileName { get { return default(string); } set { } }
    public static int Size { get { return default(int); } }
    public bool CheckChecksum() { return default(bool); }
    public void SetAutoGenerated() { }
    public override string ToString() { return default(string); }
  }
  public partial class SourceMethodBuilder {
    public SourceMethodBuilder(Mono.CompilerServices.SymbolWriter.ICompileUnit comp_unit) { }
    public SourceMethodBuilder(Mono.CompilerServices.SymbolWriter.ICompileUnit comp_unit, int ns_id, Mono.CompilerServices.SymbolWriter.IMethodDef method) { }
    public Mono.CompilerServices.SymbolWriter.CodeBlockEntry[] Blocks { get { return default(Mono.CompilerServices.SymbolWriter.CodeBlockEntry[]); } }
    public Mono.CompilerServices.SymbolWriter.CodeBlockEntry CurrentBlock { get { return default(Mono.CompilerServices.SymbolWriter.CodeBlockEntry); } }
    public Mono.CompilerServices.SymbolWriter.LocalVariableEntry[] Locals { get { return default(Mono.CompilerServices.SymbolWriter.LocalVariableEntry[]); } }
    public Mono.CompilerServices.SymbolWriter.ScopeVariable[] ScopeVariables { get { return default(Mono.CompilerServices.SymbolWriter.ScopeVariable[]); } }
    public Mono.CompilerServices.SymbolWriter.ICompileUnit SourceFile { get { return default(Mono.CompilerServices.SymbolWriter.ICompileUnit); } }
    public void AddLocal(int index, string name) { }
    public void AddScopeVariable(int scope, int index) { }
    public void DefineMethod(Mono.CompilerServices.SymbolWriter.MonoSymbolFile file) { }
    public void DefineMethod(Mono.CompilerServices.SymbolWriter.MonoSymbolFile file, int token) { }
    public void EndBlock(int end_offset) { }
    public void MarkSequencePoint(int offset, Mono.CompilerServices.SymbolWriter.SourceFileEntry file, int line, int column, bool is_hidden) { }
    public void MarkSequencePoint(int offset, Mono.CompilerServices.SymbolWriter.SourceFileEntry file, int line, int column, int end_line, int end_column, bool is_hidden) { }
    public void StartBlock(Mono.CompilerServices.SymbolWriter.CodeBlockEntry.Type type, int start_offset) { }
  }
}
namespace Mono.CSharp {
  public abstract partial class AbstractMessage {
    protected readonly int code;
    protected readonly Mono.CSharp.Location location;
    protected AbstractMessage(Mono.CSharp.AbstractMessage aMsg) { }
    protected AbstractMessage(int code, Mono.CSharp.Location loc, string msg, System.Collections.Generic.List<System.String> extraInfo) { }
    public int Code { get { return default(int); } }
    public abstract bool IsWarning { get; }
    public Mono.CSharp.Location Location { get { return default(Mono.CSharp.Location); } }
    public abstract string MessageType { get; }
    public System.String[] RelatedSymbols { get { return default(System.String[]); } }
    public string Text { get { return default(string); } }
    public override bool Equals(object obj) { return default(bool); }
    public override int GetHashCode() { return default(int); }
  }
  public abstract partial class AbstractPropertyEventMethod : Mono.CSharp.MemberCore, Mono.CSharp.IMemberContext, Mono.CSharp.IMemberDefinition, Mono.CSharp.IMethodData, Mono.CSharp.IMethodDefinition, Mono.CSharp.IModuleContext {
    protected Mono.CSharp.ToplevelBlock block;
    protected System.Collections.Generic.Dictionary<System.Security.Permissions.SecurityAction, System.Security.PermissionSet> declarative_security;
    protected Mono.CSharp.MethodData method_data;
    protected readonly string prefix;
    protected AbstractPropertyEventMethod(Mono.CSharp.InterfaceMemberBase member, string prefix, Mono.CSharp.Attributes attrs, Mono.CSharp.Location loc) : base (default(Mono.CSharp.TypeContainer), default(Mono.CSharp.MemberName), default(Mono.CSharp.Attributes)) { }
    public Mono.CSharp.ToplevelBlock Block { get { return default(Mono.CSharp.ToplevelBlock); } set { } }
    public System.Reflection.CallingConventions CallingConventions { get { return default(System.Reflection.CallingConventions); } }
    public override string DocCommentHeader { get { return default(string); } }
    public bool IsAccessor { get { return default(bool); } }
    public Mono.CSharp.MemberName MethodName { get { return default(Mono.CSharp.MemberName); } }
    System.Reflection.MethodBase Mono.CSharp.IMethodDefinition.Metadata { get { return default(System.Reflection.MethodBase); } }
    public abstract Mono.CSharp.ParametersCompiled ParameterInfo { get; }
    public Mono.CSharp.TypeSpec[] ParameterTypes { get { return default(Mono.CSharp.TypeSpec[]); } }
    public abstract Mono.CSharp.TypeSpec ReturnType { get; }
    public Mono.CSharp.MethodSpec Spec { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(Mono.CSharp.MethodSpec); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]protected set { } }
    public override void ApplyAttributeBuilder(Mono.CSharp.Attribute a, Mono.CSharp.MethodSpec ctor, System.Byte[] cdata, Mono.CSharp.PredefinedAttributes pa) { }
    protected virtual void ApplyToExtraTarget(Mono.CSharp.Attribute a, Mono.CSharp.MethodSpec ctor, System.Byte[] cdata, Mono.CSharp.PredefinedAttributes pa) { }
    public Mono.CSharp.EmitContext CreateEmitContext(System.Reflection.Emit.ILGenerator ig, Mono.CompilerServices.SymbolWriter.SourceMethodBuilder sourceMethod) { return default(Mono.CSharp.EmitContext); }
    public sealed override bool Define() { return default(bool); }
    public virtual void Emit(Mono.CSharp.TypeDefinition parent) { }
    public override bool EnableOverloadChecks(Mono.CSharp.MemberCore overload) { return default(bool); }
    public override string GetCallerMemberName() { return default(string); }
    public override string GetSignatureForDocumentation() { return default(string); }
    public override bool IsClsComplianceRequired() { return default(bool); }
    public void PrepareEmit() { }
    public void UpdateName(Mono.CSharp.InterfaceMemberBase member) { }
    public override void WriteDebugSymbol(Mono.CompilerServices.SymbolWriter.MonoSymbolFile file) { }
  }
  [System.FlagsAttribute]
  public enum AddressOp {
    Load = 2,
    LoadStore = 3,
    Store = 1,
  }
  public abstract partial class AnonymousExpression : Mono.CSharp.ExpressionStatement {
    protected readonly Mono.CSharp.ParametersBlock block;
    public Mono.CSharp.TypeSpec ReturnType;
    protected AnonymousExpression(Mono.CSharp.ParametersBlock block, Mono.CSharp.TypeSpec return_type, Mono.CSharp.Location loc) { }
    public Mono.CSharp.ParametersBlock Block { get { return default(Mono.CSharp.ParametersBlock); } }
    public abstract string ContainerType { get; }
    public abstract bool IsIterator { get; }
    public abstract Mono.CSharp.AnonymousMethodStorey Storey { get; }
    public Mono.CSharp.AnonymousExpression Compatible(Mono.CSharp.ResolveContext ec) { return default(Mono.CSharp.AnonymousExpression); }
    public Mono.CSharp.AnonymousExpression Compatible(Mono.CSharp.ResolveContext ec, Mono.CSharp.AnonymousExpression ae) { return default(Mono.CSharp.AnonymousExpression); }
    public override bool ContainsEmitWithAwait() { return default(bool); }
    public override void FlowAnalysis(Mono.CSharp.FlowAnalysisContext fc) { }
    public override void MarkReachable(Mono.CSharp.Reachability rc) { }
    public void SetHasThisAccess() { }
    protected partial class AnonymousMethodMethod : Mono.CSharp.Method {
      public readonly Mono.CSharp.AnonymousExpression AnonymousMethod;
      public readonly Mono.CSharp.AnonymousMethodStorey Storey;
      public AnonymousMethodMethod(Mono.CSharp.TypeDefinition parent, Mono.CSharp.AnonymousExpression am, Mono.CSharp.AnonymousMethodStorey storey, Mono.CSharp.TypeExpr return_type, Mono.CSharp.Modifiers mod, Mono.CSharp.MemberName name, Mono.CSharp.ParametersCompiled parameters) : base (default(Mono.CSharp.TypeDefinition), default(Mono.CSharp.FullNamedExpression), default(Mono.CSharp.Modifiers), default(Mono.CSharp.MemberName), default(Mono.CSharp.ParametersCompiled), default(Mono.CSharp.Attributes)) { }
      public override Mono.CSharp.EmitContext CreateEmitContext(System.Reflection.Emit.ILGenerator ig, Mono.CompilerServices.SymbolWriter.SourceMethodBuilder sourceMethod) { return default(Mono.CSharp.EmitContext); }
      protected override void DefineTypeParameters() { }
      public override void Emit() { }
      protected override bool ResolveMemberType() { return default(bool); }
    }
  }
  public partial class AnonymousMethodBody : Mono.CSharp.AnonymousExpression {
    protected readonly Mono.CSharp.ParametersCompiled parameters;
    public AnonymousMethodBody(Mono.CSharp.ParametersCompiled parameters, Mono.CSharp.ParametersBlock block, Mono.CSharp.TypeSpec return_type, Mono.CSharp.TypeSpec delegate_type, Mono.CSharp.Location loc) : base (default(Mono.CSharp.ParametersBlock), default(Mono.CSharp.TypeSpec), default(Mono.CSharp.Location)) { }
    public override string ContainerType { get { return default(string); } }
    public Mono.CSharp.MethodGroupExpr DirectMethodGroupConversion { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(Mono.CSharp.MethodGroupExpr); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public override bool IsIterator { get { return default(bool); } }
    public Mono.CSharp.ParametersCompiled Parameters { get { return default(Mono.CSharp.ParametersCompiled); } }
    public Mono.CSharp.TypeInferenceContext ReturnTypeInference { get { return default(Mono.CSharp.TypeInferenceContext); } set { } }
    public override Mono.CSharp.AnonymousMethodStorey Storey { get { return default(Mono.CSharp.AnonymousMethodStorey); } }
    public override Mono.CSharp.Expression CreateExpressionTree(Mono.CSharp.ResolveContext ec) { return default(Mono.CSharp.Expression); }
    protected override Mono.CSharp.Expression DoResolve(Mono.CSharp.ResolveContext ec) { return default(Mono.CSharp.Expression); }
    public override void Emit(Mono.CSharp.EmitContext ec) { }
    public override void EmitStatement(Mono.CSharp.EmitContext ec) { }
    public override string GetSignatureForError() { return default(string); }
  }
  public partial class AnonymousMethodExpression : Mono.CSharp.Expression {
    public Mono.CSharp.ParametersBlock Block;
    public AnonymousMethodExpression(Mono.CSharp.Location loc) { }
    public override string ExprClassName { get { return default(string); } }
    public virtual bool HasExplicitParameters { get { return default(bool); } }
    public override bool IsSideEffectFree { get { return default(bool); } }
    public Mono.CSharp.ParametersCompiled Parameters { get { return default(Mono.CSharp.ParametersCompiled); } }
    public Mono.CSharp.ReportPrinter TypeInferenceReportPrinter { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(Mono.CSharp.ReportPrinter); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public override object Accept(Mono.CSharp.StructuralVisitor visitor) { return default(object); }
    protected override void CloneTo(Mono.CSharp.CloneContext clonectx, Mono.CSharp.Expression t) { }
    public Mono.CSharp.Expression Compatible(Mono.CSharp.ResolveContext ec, Mono.CSharp.TypeSpec type) { return default(Mono.CSharp.Expression); }
    protected virtual Mono.CSharp.AnonymousMethodBody CompatibleMethodFactory(Mono.CSharp.TypeSpec return_type, Mono.CSharp.TypeSpec delegate_type, Mono.CSharp.ParametersCompiled p, Mono.CSharp.ParametersBlock b) { return default(Mono.CSharp.AnonymousMethodBody); }
    public override bool ContainsEmitWithAwait() { return default(bool); }
    public override Mono.CSharp.Expression CreateExpressionTree(Mono.CSharp.ResolveContext ec) { return default(Mono.CSharp.Expression); }
    protected virtual Mono.CSharp.Expression CreateExpressionTree(Mono.CSharp.ResolveContext ec, Mono.CSharp.TypeSpec delegate_type) { return default(Mono.CSharp.Expression); }
    protected override Mono.CSharp.Expression DoResolve(Mono.CSharp.ResolveContext rc) { return default(Mono.CSharp.Expression); }
    protected virtual bool DoResolveParameters(Mono.CSharp.ResolveContext rc) { return default(bool); }
    public override void Emit(Mono.CSharp.EmitContext ec) { }
    public static void Error_AddressOfCapturedVar(Mono.CSharp.ResolveContext rc, Mono.CSharp.IVariableReference var, Mono.CSharp.Location loc) { }
    public bool ExplicitTypeInference(Mono.CSharp.TypeInferenceContext type_inference, Mono.CSharp.TypeSpec delegate_type) { return default(bool); }
    public override string GetSignatureForError() { return default(string); }
    public bool ImplicitStandardConversionExists(Mono.CSharp.ResolveContext ec, Mono.CSharp.TypeSpec delegate_type) { return default(bool); }
    public Mono.CSharp.TypeSpec InferReturnType(Mono.CSharp.ResolveContext ec, Mono.CSharp.TypeInferenceContext tic, Mono.CSharp.TypeSpec delegate_type) { return default(Mono.CSharp.TypeSpec); }
    protected virtual Mono.CSharp.ParametersCompiled ResolveParameters(Mono.CSharp.ResolveContext ec, Mono.CSharp.TypeInferenceContext tic, Mono.CSharp.TypeSpec delegate_type) { return default(Mono.CSharp.ParametersCompiled); }
    protected bool VerifyExplicitParameters(Mono.CSharp.ResolveContext ec, Mono.CSharp.TypeInferenceContext tic, Mono.CSharp.TypeSpec delegate_type, Mono.CSharp.AParametersCollection parameters) { return default(bool); }
    protected bool VerifyParameterCompatibility(Mono.CSharp.ResolveContext ec, Mono.CSharp.TypeInferenceContext tic, Mono.CSharp.TypeSpec delegate_type, Mono.CSharp.AParametersCollection invoke_pd, bool ignore_errors) { return default(bool); }
  }
  public partial class AnonymousMethodStorey : Mono.CSharp.HoistedStoreyClass {
    protected System.Collections.Generic.List<Mono.CSharp.HoistedVariable> hoisted_locals;
    protected System.Collections.Generic.List<Mono.CSharp.HoistedParameter> hoisted_params;
    protected Mono.CSharp.HoistedThis hoisted_this;
    public readonly int ID;
    public Mono.CSharp.Expression Instance;
    public readonly Mono.CSharp.ExplicitBlock OriginalSourceBlock;
    public AnonymousMethodStorey(Mono.CSharp.ExplicitBlock block, Mono.CSharp.TypeDefinition parent, Mono.CSharp.MemberBase host, Mono.CSharp.TypeParameters tparams, string name, Mono.CSharp.MemberKind kind) : base (default(Mono.CSharp.TypeDefinition), default(Mono.CSharp.MemberName), default(Mono.CSharp.TypeParameters), default(Mono.CSharp.Modifiers), default(Mono.CSharp.MemberKind)) { }
    public Mono.CSharp.HoistedThis HoistedThis { get { return default(Mono.CSharp.HoistedThis); } set { } }
    public System.Collections.Generic.IList<Mono.CSharp.ExplicitBlock> ReferencesFromChildrenBlock { get { return default(System.Collections.Generic.IList<Mono.CSharp.ExplicitBlock>); } }
    public void AddCapturedThisField(Mono.CSharp.EmitContext ec, Mono.CSharp.AnonymousMethodStorey parent) { }
    public Mono.CSharp.Field AddCapturedVariable(string name, Mono.CSharp.TypeSpec type) { return default(Mono.CSharp.Field); }
    protected Mono.CSharp.Field AddCompilerGeneratedField(string name, Mono.CSharp.FullNamedExpression type) { return default(Mono.CSharp.Field); }
    protected Mono.CSharp.Field AddCompilerGeneratedField(string name, Mono.CSharp.FullNamedExpression type, bool privateAccess) { return default(Mono.CSharp.Field); }
    public void AddParentStoreyReference(Mono.CSharp.EmitContext ec, Mono.CSharp.AnonymousMethodStorey storey) { }
    public void AddReferenceFromChildrenBlock(Mono.CSharp.ExplicitBlock block) { }
    public void CaptureLocalVariable(Mono.CSharp.ResolveContext ec, Mono.CSharp.LocalVariable localVariable) { }
    public void CaptureParameter(Mono.CSharp.ResolveContext ec, Mono.CSharp.ParametersBlock.ParameterInfo parameterInfo, Mono.CSharp.ParameterReference parameterReference) { }
    protected override bool DoResolveTypeParameters() { return default(bool); }
    protected virtual void EmitHoistedParameters(Mono.CSharp.EmitContext ec, System.Collections.Generic.List<Mono.CSharp.HoistedParameter> hoisted) { }
    public void EmitStoreyInstantiation(Mono.CSharp.EmitContext ec, Mono.CSharp.ExplicitBlock block) { }
    public Mono.CSharp.Expression GetStoreyInstanceExpression(Mono.CSharp.EmitContext ec) { return default(Mono.CSharp.Expression); }
    protected virtual string GetVariableMangledName(Mono.CSharp.LocalVariable local_info) { return default(string); }
    public void SetNestedStoryParent(Mono.CSharp.AnonymousMethodStorey parentStorey) { }
  }
  public partial class AnonymousTypeClass : Mono.CSharp.CompilerGeneratedContainer {
    internal AnonymousTypeClass() : base (default(Mono.CSharp.TypeContainer), default(Mono.CSharp.MemberName), default(Mono.CSharp.Modifiers)) { }
    public const string ClassNamePrefix = "<>__AnonType";
    public const string SignatureForError = "anonymous type";
    public System.Collections.Generic.IList<Mono.CSharp.AnonymousTypeParameter> Parameters { get { return default(System.Collections.Generic.IList<Mono.CSharp.AnonymousTypeParameter>); } }
    public static Mono.CSharp.AnonymousTypeClass Create(Mono.CSharp.TypeContainer parent, System.Collections.Generic.IList<Mono.CSharp.AnonymousTypeParameter> parameters, Mono.CSharp.Location loc) { return default(Mono.CSharp.AnonymousTypeClass); }
    protected override bool DoDefineMembers() { return default(bool); }
    public override Mono.CSharp.CompilationSourceFile GetCompilationSourceFile() { return default(Mono.CSharp.CompilationSourceFile); }
    public override string GetSignatureForError() { return default(string); }
  }
  public partial class AnonymousTypeParameter : Mono.CSharp.ShimExpression {
    public readonly string Name;
    public AnonymousTypeParameter(Mono.CSharp.Expression initializer, string name, Mono.CSharp.Location loc) : base (default(Mono.CSharp.Expression)) { }
    public AnonymousTypeParameter(Mono.CSharp.Parameter parameter) : base (default(Mono.CSharp.Expression)) { }
    protected override Mono.CSharp.Expression DoResolve(Mono.CSharp.ResolveContext ec) { return default(Mono.CSharp.Expression); }
    public override bool Equals(object o) { return default(bool); }
    protected virtual void Error_InvalidInitializer(Mono.CSharp.ResolveContext ec, string initializer) { }
    public override int GetHashCode() { return default(int); }
  }
  public abstract partial class AParametersCollection {
    protected bool has_arglist;
    protected bool has_params;
    protected Mono.CSharp.IParameterData[] parameters;
    protected Mono.CSharp.TypeSpec[] types;
    protected AParametersCollection() { }
    public System.Reflection.CallingConventions CallingConvention { get { return default(System.Reflection.CallingConventions); } }
    public int Count { get { return default(int); } }
    public Mono.CSharp.TypeSpec ExtensionMethodType { get { return default(Mono.CSharp.TypeSpec); } }
    public Mono.CSharp.IParameterData[] FixedParameters { get { return default(Mono.CSharp.IParameterData[]); } }
    public bool HasArglist { get { return default(bool); } }
    public bool HasExtensionMethodType { get { return default(bool); } }
    public bool HasParams { get { return default(bool); } }
    public bool IsEmpty { get { return default(bool); } }
    public Mono.CSharp.TypeSpec[] Types { get { return default(Mono.CSharp.TypeSpec[]); } set { } }
    public System.Type[] GetMetaInfo() { return default(System.Type[]); }
    public static System.Reflection.ParameterAttributes GetParameterAttribute(Mono.CSharp.Parameter.Modifier modFlags) { return default(System.Reflection.ParameterAttributes); }
    public int GetParameterIndexByName(string name) { return default(int); }
    public string GetSignatureForDocumentation() { return default(string); }
    public string GetSignatureForError() { return default(string); }
    public string GetSignatureForError(string start, string end, int count) { return default(string); }
    public Mono.CSharp.AParametersCollection Inflate(Mono.CSharp.TypeParameterInflator inflator) { return default(Mono.CSharp.AParametersCollection); }
    public string ParameterDesc(int pos) { return default(string); }
  }
  public partial class Arglist : Mono.CSharp.Expression {
    public Arglist(Mono.CSharp.Arguments args, Mono.CSharp.Location l) { }
    public Arglist(Mono.CSharp.Location loc) { }
    public Mono.CSharp.Arguments Arguments { get { return default(Mono.CSharp.Arguments); } }
    public System.Type[] ArgumentTypes { get { return default(System.Type[]); } }
    public override object Accept(Mono.CSharp.StructuralVisitor visitor) { return default(object); }
    protected override void CloneTo(Mono.CSharp.CloneContext clonectx, Mono.CSharp.Expression t) { }
    public override bool ContainsEmitWithAwait() { return default(bool); }
    public override Mono.CSharp.Expression CreateExpressionTree(Mono.CSharp.ResolveContext ec) { return default(Mono.CSharp.Expression); }
    protected override Mono.CSharp.Expression DoResolve(Mono.CSharp.ResolveContext ec) { return default(Mono.CSharp.Expression); }
    public override void Emit(Mono.CSharp.EmitContext ec) { }
  }
  public partial class ArglistAccess : Mono.CSharp.Expression {
    public ArglistAccess(Mono.CSharp.Location loc) { }
    public override object Accept(Mono.CSharp.StructuralVisitor visitor) { return default(object); }
    protected override void CloneTo(Mono.CSharp.CloneContext clonectx, Mono.CSharp.Expression target) { }
    public override bool ContainsEmitWithAwait() { return default(bool); }
    public override Mono.CSharp.Expression CreateExpressionTree(Mono.CSharp.ResolveContext ec) { return default(Mono.CSharp.Expression); }
    protected override Mono.CSharp.Expression DoResolve(Mono.CSharp.ResolveContext ec) { return default(Mono.CSharp.Expression); }
    public override void Emit(Mono.CSharp.EmitContext ec) { }
  }
  public partial class ArglistParameter : Mono.CSharp.Parameter {
    public ArglistParameter(Mono.CSharp.Location loc) : base (default(Mono.CSharp.FullNamedExpression), default(string), default(Mono.CSharp.Parameter.Modifier), default(Mono.CSharp.Attributes), default(Mono.CSharp.Location)) { }
    public override void ApplyAttributes(System.Reflection.Emit.MethodBuilder mb, System.Reflection.Emit.ConstructorBuilder cb, int index, Mono.CSharp.PredefinedAttributes pa) { }
    public override bool CheckAccessibility(Mono.CSharp.InterfaceMemberBase member) { return default(bool); }
    public override Mono.CSharp.TypeSpec Resolve(Mono.CSharp.IMemberContext ec, int index) { return default(Mono.CSharp.TypeSpec); }
  }
  public partial class Argument {
    public readonly Mono.CSharp.Argument.AType ArgType;
    public Mono.CSharp.Expression Expr;
    public Argument(Mono.CSharp.Expression expr) { }
    public Argument(Mono.CSharp.Expression expr, Mono.CSharp.Argument.AType type) { }
    public bool IsByRef { get { return default(bool); } }
    public bool IsDefaultArgument { get { return default(bool); } }
    public bool IsExtensionType { get { return default(bool); } }
    public Mono.CSharp.Parameter.Modifier Modifier { get { return default(Mono.CSharp.Parameter.Modifier); } }
    public Mono.CSharp.TypeSpec Type { get { return default(Mono.CSharp.TypeSpec); } }
    public Mono.CSharp.Argument Clone(Mono.CSharp.CloneContext clonectx) { return default(Mono.CSharp.Argument); }
    public Mono.CSharp.Argument Clone(Mono.CSharp.Expression expr) { return default(Mono.CSharp.Argument); }
    public virtual Mono.CSharp.Expression CreateExpressionTree(Mono.CSharp.ResolveContext ec) { return default(Mono.CSharp.Expression); }
    public virtual void Emit(Mono.CSharp.EmitContext ec) { }
    public Mono.CSharp.Argument EmitToField(Mono.CSharp.EmitContext ec, bool cloneResult) { return default(Mono.CSharp.Argument); }
    public void FlowAnalysis(Mono.CSharp.FlowAnalysisContext fc) { }
    public string GetSignatureForError() { return default(string); }
    public void Resolve(Mono.CSharp.ResolveContext ec) { }
    public bool ResolveMethodGroup(Mono.CSharp.ResolveContext ec) { return default(bool); }
    public enum AType : byte {
      ConditionalAccessFlag = (byte)128,
      Default = (byte)3,
      DynamicTypeName = (byte)4,
      ExtensionType = (byte)5,
      ExtensionTypeConditionalAccess = (byte)133,
      None = (byte)0,
      Out = (byte)2,
      Ref = (byte)1,
    }
  }
  public partial class Arguments {
    public Arguments(int capacity) { }
    public int Count { get { return default(int); } }
    public bool HasDynamic { get { return default(bool); } }
    public bool HasNamed { get { return default(bool); } }
    public Mono.CSharp.Argument this[int index] { get { return default(Mono.CSharp.Argument); } set { } }
    public void Add(Mono.CSharp.Argument arg) { }
    public void AddRange(Mono.CSharp.Arguments args) { }
    public void CheckArrayAsAttribute(Mono.CSharp.CompilerContext ctx) { }
    public Mono.CSharp.Arguments Clone(Mono.CSharp.CloneContext ctx) { return default(Mono.CSharp.Arguments); }
    public bool ContainsEmitWithAwait() { return default(bool); }
    public Mono.CSharp.ArrayInitializer CreateDynamicBinderArguments(Mono.CSharp.ResolveContext rc) { return default(Mono.CSharp.ArrayInitializer); }
    public static Mono.CSharp.Arguments CreateForExpressionTree(Mono.CSharp.ResolveContext ec, Mono.CSharp.Arguments args, params Mono.CSharp.Expression[] e) { return default(Mono.CSharp.Arguments); }
    public void Emit(Mono.CSharp.EmitContext ec) { }
    public virtual Mono.CSharp.Arguments Emit(Mono.CSharp.EmitContext ec, bool dup_args, bool prepareAwait) { return default(Mono.CSharp.Arguments); }
    public virtual void FlowAnalysis(Mono.CSharp.FlowAnalysisContext fc, System.Collections.Generic.List<Mono.CSharp.MovableArgument> movable=null) { }
    public System.Collections.Generic.List<Mono.CSharp.Argument>.Enumerator GetEnumerator() { return default(System.Collections.Generic.List<Mono.CSharp.Argument>.Enumerator); }
    public void Insert(int index, Mono.CSharp.Argument arg) { }
    public static System.Linq.Expressions.Expression[] MakeExpression(Mono.CSharp.Arguments args, Mono.CSharp.BuilderContext ctx) { return default(System.Linq.Expressions.Expression[]); }
    public Mono.CSharp.Arguments MarkOrderedArgument(Mono.CSharp.NamedArgument a) { return default(Mono.CSharp.Arguments); }
    public void RemoveAt(int index) { }
    public void Resolve(Mono.CSharp.ResolveContext ec, out bool dynamic) { dynamic = default(bool); }
  }
  public partial class ArrayAccess : Mono.CSharp.Expression, Mono.CSharp.IAssignMethod, Mono.CSharp.IMemoryLocation {
    public ArrayAccess(Mono.CSharp.ElementAccess ea_data, Mono.CSharp.Location l) { }
    public bool ConditionalAccess { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public bool ConditionalAccessReceiver { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public void AddressOf(Mono.CSharp.EmitContext ec, Mono.CSharp.AddressOp mode) { }
    public override bool ContainsEmitWithAwait() { return default(bool); }
    public override Mono.CSharp.Expression CreateExpressionTree(Mono.CSharp.ResolveContext ec) { return default(Mono.CSharp.Expression); }
    protected override Mono.CSharp.Expression DoResolve(Mono.CSharp.ResolveContext ec) { return default(Mono.CSharp.Expression); }
    public override Mono.CSharp.Expression DoResolveLValue(Mono.CSharp.ResolveContext ec, Mono.CSharp.Expression right_side) { return default(Mono.CSharp.Expression); }
    public override void Emit(Mono.CSharp.EmitContext ec) { }
    public void Emit(Mono.CSharp.EmitContext ec, bool leave_copy) { }
    public void EmitAssign(Mono.CSharp.EmitContext ec, Mono.CSharp.Expression source, bool leave_copy, bool isCompound) { }
    public override Mono.CSharp.Expression EmitToField(Mono.CSharp.EmitContext ec) { return default(Mono.CSharp.Expression); }
    protected override void Error_NegativeArrayIndex(Mono.CSharp.ResolveContext ec, Mono.CSharp.Location loc) { }
    public override void FlowAnalysis(Mono.CSharp.FlowAnalysisContext fc) { }
    public System.Linq.Expressions.Expression MakeAssignExpression(Mono.CSharp.BuilderContext ctx, Mono.CSharp.Expression source) { return default(System.Linq.Expressions.Expression); }
    public override System.Linq.Expressions.Expression MakeExpression(Mono.CSharp.BuilderContext ctx) { return default(System.Linq.Expressions.Expression); }
  }
  public partial class ArrayContainer : Mono.CSharp.ElementTypeSpec {
    internal ArrayContainer() : base (default(Mono.CSharp.MemberKind), default(Mono.CSharp.TypeSpec), default(System.Type)) { }
    public int Rank { get { return default(int); } }
    public System.Reflection.MethodInfo GetAddressMethod() { return default(System.Reflection.MethodInfo); }
    public System.Reflection.MethodInfo GetConstructor() { return default(System.Reflection.MethodInfo); }
    public System.Reflection.MethodInfo GetGetMethod() { return default(System.Reflection.MethodInfo); }
    public override System.Type GetMetaInfo() { return default(System.Type); }
    protected override string GetPostfixSignature() { return default(string); }
    public static string GetPostfixSignature(int rank) { return default(string); }
    public System.Reflection.MethodInfo GetSetMethod() { return default(System.Reflection.MethodInfo); }
    public override string GetSignatureForDocumentation() { return default(string); }
    public static Mono.CSharp.ArrayContainer MakeType(Mono.CSharp.ModuleContainer module, Mono.CSharp.TypeSpec element) { return default(Mono.CSharp.ArrayContainer); }
    public static Mono.CSharp.ArrayContainer MakeType(Mono.CSharp.ModuleContainer module, Mono.CSharp.TypeSpec element, int rank) { return default(Mono.CSharp.ArrayContainer); }
    public override System.Collections.Generic.List<Mono.CSharp.MissingTypeSpecReference> ResolveMissingDependencies(Mono.CSharp.MemberSpec caller) { return default(System.Collections.Generic.List<Mono.CSharp.MissingTypeSpecReference>); }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct TypeRankPair : System.IEquatable<Mono.CSharp.ArrayContainer.TypeRankPair> {
      public TypeRankPair(Mono.CSharp.TypeSpec ts, int rank) { throw new System.NotImplementedException(); }
      public bool Equals(Mono.CSharp.ArrayContainer.TypeRankPair other) { return default(bool); }
      public override int GetHashCode() { return default(int); }
    }
  }
  public partial class ArrayCreation : Mono.CSharp.Expression {
    protected System.Collections.Generic.List<Mono.CSharp.Expression> arguments;
    protected System.Collections.Generic.List<Mono.CSharp.Expression> array_data;
    protected Mono.CSharp.TypeSpec array_element_type;
    protected int dimensions;
    protected readonly Mono.CSharp.ComposedTypeSpecifier rank;
    public ArrayCreation(Mono.CSharp.FullNamedExpression requested_base_type, Mono.CSharp.ArrayInitializer initializers) { }
    public ArrayCreation(Mono.CSharp.FullNamedExpression requested_base_type, Mono.CSharp.ArrayInitializer initializers, Mono.CSharp.Location loc) { }
    public ArrayCreation(Mono.CSharp.FullNamedExpression requested_base_type, Mono.CSharp.ComposedTypeSpecifier rank, Mono.CSharp.ArrayInitializer initializers, Mono.CSharp.Location loc) { }
    public ArrayCreation(Mono.CSharp.FullNamedExpression requested_base_type, System.Collections.Generic.List<Mono.CSharp.Expression> exprs, Mono.CSharp.ComposedTypeSpecifier rank, Mono.CSharp.ArrayInitializer initializers, Mono.CSharp.Location l) { }
    public Mono.CSharp.ArrayInitializer Initializers { get { return default(Mono.CSharp.ArrayInitializer); } }
    public Mono.CSharp.ComposedTypeSpecifier Rank { get { return default(Mono.CSharp.ComposedTypeSpecifier); } }
    public Mono.CSharp.FullNamedExpression TypeExpression { get { return default(Mono.CSharp.FullNamedExpression); } }
    public override object Accept(Mono.CSharp.StructuralVisitor visitor) { return default(object); }
    protected override void CloneTo(Mono.CSharp.CloneContext clonectx, Mono.CSharp.Expression t) { }
    public override bool ContainsEmitWithAwait() { return default(bool); }
    public override Mono.CSharp.Expression CreateExpressionTree(Mono.CSharp.ResolveContext ec) { return default(Mono.CSharp.Expression); }
    protected override Mono.CSharp.Expression DoResolve(Mono.CSharp.ResolveContext ec) { return default(Mono.CSharp.Expression); }
    public override void Emit(Mono.CSharp.EmitContext ec) { }
    protected sealed override Mono.CSharp.FieldExpr EmitToFieldSource(Mono.CSharp.EmitContext ec) { return default(Mono.CSharp.FieldExpr); }
    public override void EncodeAttributeValue(Mono.CSharp.IMemberContext rc, Mono.CSharp.AttributeEncoder enc, Mono.CSharp.TypeSpec targetType, Mono.CSharp.TypeSpec parameterType) { }
    protected override void Error_NegativeArrayIndex(Mono.CSharp.ResolveContext ec, Mono.CSharp.Location loc) { }
    public override void FlowAnalysis(Mono.CSharp.FlowAnalysisContext fc) { }
    protected virtual Mono.CSharp.Expression ResolveArrayElement(Mono.CSharp.ResolveContext ec, Mono.CSharp.Expression element) { return default(Mono.CSharp.Expression); }
    protected bool ResolveInitializers(Mono.CSharp.ResolveContext ec) { return default(bool); }
  }
  public partial class ArrayIndexCast : Mono.CSharp.TypeCast {
    public ArrayIndexCast(Mono.CSharp.Expression expr, Mono.CSharp.TypeSpec returnType) : base (default(Mono.CSharp.Expression), default(Mono.CSharp.TypeSpec)) { }
    public override Mono.CSharp.Expression CreateExpressionTree(Mono.CSharp.ResolveContext ec) { return default(Mono.CSharp.Expression); }
    public override void Emit(Mono.CSharp.EmitContext ec) { }
  }
  public partial class ArrayInitializer : Mono.CSharp.Expression {
    public ArrayInitializer(Mono.CSharp.Location loc) { }
    public ArrayInitializer(System.Collections.Generic.List<Mono.CSharp.Expression> init, Mono.CSharp.Location loc) { }
    public ArrayInitializer(int count, Mono.CSharp.Location loc) { }
    public int Count { get { return default(int); } }
    public System.Collections.Generic.List<Mono.CSharp.Expression> Elements { get { return default(System.Collections.Generic.List<Mono.CSharp.Expression>); } }
    public Mono.CSharp.Expression this[int index] { get { return default(Mono.CSharp.Expression); } }
    public Mono.CSharp.BlockVariable VariableDeclaration { get { return default(Mono.CSharp.BlockVariable); } set { } }
    public override object Accept(Mono.CSharp.StructuralVisitor visitor) { return default(object); }
    public void Add(Mono.CSharp.Expression expr) { }
    protected override void CloneTo(Mono.CSharp.CloneContext clonectx, Mono.CSharp.Expression t) { }
    public override bool ContainsEmitWithAwait() { return default(bool); }
    public override Mono.CSharp.Expression CreateExpressionTree(Mono.CSharp.ResolveContext ec) { return default(Mono.CSharp.Expression); }
    protected override Mono.CSharp.Expression DoResolve(Mono.CSharp.ResolveContext rc) { return default(Mono.CSharp.Expression); }
    public override void Emit(Mono.CSharp.EmitContext ec) { }
    public override void FlowAnalysis(Mono.CSharp.FlowAnalysisContext fc) { }
  }
  public partial class As : Mono.CSharp.Probe {
    public As(Mono.CSharp.Expression expr, Mono.CSharp.Expression probe_type, Mono.CSharp.Location l) : base (default(Mono.CSharp.Expression), default(Mono.CSharp.Expression), default(Mono.CSharp.Location)) { }
    protected override string OperatorName { get { return default(string); } }
    public override object Accept(Mono.CSharp.StructuralVisitor visitor) { return default(object); }
    public override Mono.CSharp.Expression CreateExpressionTree(Mono.CSharp.ResolveContext ec) { return default(Mono.CSharp.Expression); }
    protected override Mono.CSharp.Expression DoResolve(Mono.CSharp.ResolveContext ec) { return default(Mono.CSharp.Expression); }
    public override void Emit(Mono.CSharp.EmitContext ec) { }
  }
  public partial class AssemblyBuilderExtension {
    public AssemblyBuilderExtension(Mono.CSharp.CompilerContext ctx) { }
    public virtual System.Reflection.Module AddModule(string module) { return default(System.Reflection.Module); }
    public virtual void AddPermissionRequests(System.Security.PermissionSet[] permissions) { }
    public virtual void AddTypeForwarder(Mono.CSharp.TypeSpec type, Mono.CSharp.Location loc) { }
    public virtual void DefineWin32IconResource(string fileName) { }
    public virtual void SetAlgorithmId(uint value, Mono.CSharp.Location loc) { }
    public virtual void SetCulture(string culture, Mono.CSharp.Location loc) { }
    public virtual void SetFlags(uint flags, Mono.CSharp.Location loc) { }
    public virtual void SetVersion(System.Version version, Mono.CSharp.Location loc) { }
  }
  public abstract partial class AssemblyDefinition : Mono.CSharp.IAssemblyDefinition {
    protected System.Collections.Generic.List<Mono.CSharp.ImportedModuleDefinition> added_modules;
    public System.Reflection.Emit.AssemblyBuilder Builder;
    protected Mono.CSharp.AssemblyBuilderExtension builder_extra;
    protected readonly string file_name;
    protected Mono.CSharp.ModuleContainer module;
    protected AssemblyDefinition(Mono.CSharp.ModuleContainer module, string name) { }
    protected AssemblyDefinition(Mono.CSharp.ModuleContainer module, string name, string fileName) { }
    public Mono.CSharp.Attribute CLSCompliantAttribute { get { return default(Mono.CSharp.Attribute); } }
    public Mono.CSharp.CompilerContext Compiler { get { return default(Mono.CSharp.CompilerContext); } }
    public Mono.CSharp.Method EntryPoint { get { return default(Mono.CSharp.Method); } set { } }
    public string FullName { get { return default(string); } }
    public bool HasCLSCompliantAttribute { get { return default(bool); } }
    public Mono.CSharp.MetadataImporter Importer { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(Mono.CSharp.MetadataImporter); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public bool IsCLSCompliant { get { return default(bool); } }
    public bool IsSatelliteAssembly { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } }
    bool Mono.CSharp.IAssemblyDefinition.IsMissing { get { return default(bool); } }
    public string Name { get { return default(string); } }
    protected Mono.CSharp.Report Report { get { return default(Mono.CSharp.Report); } }
    public Mono.CompilerServices.SymbolWriter.MonoSymbolFile SymbolWriter { get { return default(Mono.CompilerServices.SymbolWriter.MonoSymbolFile); } }
    public bool WrapNonExceptionThrows { get { return default(bool); } }
    public void AddModule(Mono.CSharp.ImportedModuleDefinition module) { }
    public void ApplyAttributeBuilder(Mono.CSharp.Attribute a, Mono.CSharp.MethodSpec ctor, System.Byte[] cdata, Mono.CSharp.PredefinedAttributes pa) { }
    protected System.Reflection.AssemblyName CreateAssemblyName() { return default(System.Reflection.AssemblyName); }
    public virtual System.Reflection.Emit.ModuleBuilder CreateModuleBuilder() { return default(System.Reflection.Emit.ModuleBuilder); }
    public void EmbedResources() { }
    public virtual void Emit() { }
    public System.Byte[] GetPublicKeyToken() { return default(System.Byte[]); }
    public bool IsFriendAssemblyTo(Mono.CSharp.IAssemblyDefinition assembly) { return default(bool); }
    public void Resolve() { }
    protected void ResolveAssemblySecurityAttributes() { }
    public void Save() { }
    protected virtual void SaveModule(System.Reflection.PortableExecutableKinds pekind, System.Reflection.ImageFileMachine machine) { }
  }
  public partial class AssemblyDefinitionDynamic : Mono.CSharp.AssemblyDefinition {
    public AssemblyDefinitionDynamic(Mono.CSharp.ModuleContainer module, string name) : base (default(Mono.CSharp.ModuleContainer), default(string)) { }
    public AssemblyDefinitionDynamic(Mono.CSharp.ModuleContainer module, string name, string fileName) : base (default(Mono.CSharp.ModuleContainer), default(string)) { }
    public bool Create(System.AppDomain domain, System.Reflection.Emit.AssemblyBuilderAccess access) { return default(bool); }
    public override System.Reflection.Emit.ModuleBuilder CreateModuleBuilder() { return default(System.Reflection.Emit.ModuleBuilder); }
    public System.Reflection.Module IncludeModule(string moduleFile) { return default(System.Reflection.Module); }
    protected override void SaveModule(System.Reflection.PortableExecutableKinds pekind, System.Reflection.ImageFileMachine machine) { }
  }
  public partial class AssemblyResource : System.IEquatable<Mono.CSharp.AssemblyResource> {
    public AssemblyResource(string fileName, string name) { }
    public AssemblyResource(string fileName, string name, bool isPrivate) { }
    public System.Reflection.ResourceAttributes Attributes { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Reflection.ResourceAttributes); } }
    public string FileName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
    public bool IsEmbeded { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public string Name { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
    public bool Equals(Mono.CSharp.AssemblyResource other) { return default(bool); }
  }
  public abstract partial class Assign : Mono.CSharp.ExpressionStatement {
    protected Mono.CSharp.Expression source;
    protected Mono.CSharp.Expression target;
    protected Assign(Mono.CSharp.Expression target, Mono.CSharp.Expression source, Mono.CSharp.Location loc) { }
    public Mono.CSharp.Expression Source { get { return default(Mono.CSharp.Expression); } }
    public override Mono.CSharp.Location StartLocation { get { return default(Mono.CSharp.Location); } }
    public Mono.CSharp.Expression Target { get { return default(Mono.CSharp.Expression); } }
    public override object Accept(Mono.CSharp.StructuralVisitor visitor) { return default(object); }
    protected override void CloneTo(Mono.CSharp.CloneContext clonectx, Mono.CSharp.Expression t) { }
    public override bool ContainsEmitWithAwait() { return default(bool); }
    public override Mono.CSharp.Expression CreateExpressionTree(Mono.CSharp.ResolveContext ec) { return default(Mono.CSharp.Expression); }
    protected override Mono.CSharp.Expression DoResolve(Mono.CSharp.ResolveContext ec) { return default(Mono.CSharp.Expression); }
    public override void Emit(Mono.CSharp.EmitContext ec) { }
    public override void EmitStatement(Mono.CSharp.EmitContext ec) { }
    public override void FlowAnalysis(Mono.CSharp.FlowAnalysisContext fc) { }
    protected virtual Mono.CSharp.Expression ResolveConversions(Mono.CSharp.ResolveContext ec) { return default(Mono.CSharp.Expression); }
  }
  public partial class AsyncInitializer : Mono.CSharp.StateMachineInitializer {
    public AsyncInitializer(Mono.CSharp.ParametersBlock block, Mono.CSharp.TypeDefinition host, Mono.CSharp.TypeSpec returnType) : base (default(Mono.CSharp.ParametersBlock), default(Mono.CSharp.TypeDefinition), default(Mono.CSharp.TypeSpec)) { }
    public override string ContainerType { get { return default(string); } }
    public Mono.CSharp.TypeSpec DelegateType { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(Mono.CSharp.TypeSpec); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public Mono.CSharp.StackFieldExpr HoistedReturnState { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(Mono.CSharp.StackFieldExpr); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public override bool IsIterator { get { return default(bool); } }
    public Mono.CSharp.TypeInferenceContext ReturnTypeInference { get { return default(Mono.CSharp.TypeInferenceContext); } }
    protected override Mono.CSharp.BlockContext CreateBlockContext(Mono.CSharp.BlockContext bc) { return default(Mono.CSharp.BlockContext); }
    public override void Emit(Mono.CSharp.EmitContext ec) { }
    public void EmitCatchBlock(Mono.CSharp.EmitContext ec) { }
    protected override void EmitMoveNextEpilogue(Mono.CSharp.EmitContext ec) { }
    public override void EmitStatement(Mono.CSharp.EmitContext ec) { }
    public override void MarkReachable(Mono.CSharp.Reachability rc) { }
  }
  public abstract partial class Attributable {
    protected Mono.CSharp.Attributes attributes;
    protected Attributable() { }
    public abstract System.AttributeTargets AttributeTargets { get; }
    public Mono.CSharp.Attributes OptAttributes { get { return default(Mono.CSharp.Attributes); } set { } }
    public abstract System.String[] ValidAttributeTargets { get; }
    public void AddAttributes(Mono.CSharp.Attributes attrs, Mono.CSharp.IMemberContext context) { }
    public abstract void ApplyAttributeBuilder(Mono.CSharp.Attribute a, Mono.CSharp.MethodSpec ctor, System.Byte[] cdata, Mono.CSharp.PredefinedAttributes pa);
    public abstract bool IsClsComplianceRequired();
  }
  public partial class Attribute {
    public static readonly System.AttributeUsageAttribute DefaultUsageAttribute;
    public static readonly System.Object[] EmptyObject;
    public readonly string ExplicitTarget;
    public System.AttributeTargets Target;
    public Mono.CSharp.TypeSpec Type;
    public Attribute(string target, Mono.CSharp.ATypeNameExpression expr, Mono.CSharp.Arguments[] args, Mono.CSharp.Location loc, bool nameEscaped) { }
    public bool HasSecurityAttribute { get { return default(bool); } }
    public Mono.CSharp.Location Location { get { return default(Mono.CSharp.Location); } }
    public string Name { get { return default(string); } }
    public Mono.CSharp.Arguments NamedArguments { get { return default(Mono.CSharp.Arguments); } }
    public Mono.CSharp.Arguments PositionalArguments { get { return default(Mono.CSharp.Arguments); } }
    public Mono.CSharp.Report Report { get { return default(Mono.CSharp.Report); } }
    public bool ResolveError { get { return default(bool); } }
    public Mono.CSharp.ATypeNameExpression TypeExpression { get { return default(Mono.CSharp.ATypeNameExpression); } }
    public void AttachTo(Mono.CSharp.Attributable target, Mono.CSharp.IMemberContext context) { }
    public bool CheckTarget() { return default(bool); }
    public Mono.CSharp.Attribute Clone() { return default(Mono.CSharp.Attribute); }
    public Mono.CSharp.ResolveContext CreateResolveContext() { return default(Mono.CSharp.ResolveContext); }
    public void Emit(System.Collections.Generic.Dictionary<Mono.CSharp.Attribute, System.Collections.Generic.List<Mono.CSharp.Attribute>> allEmitted) { }
    public override bool Equals(object obj) { return default(bool); }
    public static void Error_AttributeArgumentIsDynamic(Mono.CSharp.IMemberContext context, Mono.CSharp.Location loc) { }
    public void Error_InvalidArgumentValue(Mono.CSharp.TypeSpec attributeType) { }
    public void Error_InvalidSecurityParent() { }
    public void Error_MissingGuidAttribute() { }
    public void Error_MisusedDynamicAttribute() { }
    public void Error_MisusedExtensionAttribute() { }
    public void ExtractSecurityPermissionSet(Mono.CSharp.MethodSpec ctor, ref System.Collections.Generic.Dictionary<System.Security.Permissions.SecurityAction, System.Security.PermissionSet> permissions) { }
    public Mono.CSharp.TypeSpec GetArgumentType() { return default(Mono.CSharp.TypeSpec); }
    public System.AttributeUsageAttribute GetAttributeUsageAttribute() { return default(System.AttributeUsageAttribute); }
    public bool GetBoolean() { return default(bool); }
    public System.Runtime.InteropServices.CharSet GetCharSetValue() { return default(System.Runtime.InteropServices.CharSet); }
    public bool GetClsCompliantAttributeValue() { return default(bool); }
    public Mono.CSharp.TypeSpec GetCoClassAttributeValue() { return default(Mono.CSharp.TypeSpec); }
    public string GetConditionalAttributeValue() { return default(string); }
    public override int GetHashCode() { return default(int); }
    public string GetIndexerAttributeValue() { return default(string); }
    public System.Runtime.CompilerServices.MethodImplOptions GetMethodImplOptions() { return default(System.Runtime.CompilerServices.MethodImplOptions); }
    public Mono.CSharp.Constant GetNamedValue(string name) { return default(Mono.CSharp.Constant); }
    public System.ObsoleteAttribute GetObsoleteAttribute() { return default(System.ObsoleteAttribute); }
    public Mono.CSharp.Expression GetParameterDefaultValue() { return default(Mono.CSharp.Expression); }
    public string GetSignatureForError() { return default(string); }
    public string GetString() { return default(string); }
    public string GetValidTargets() { return default(string); }
    public bool HasField(string fieldName) { return default(bool); }
    public bool IsExplicitLayoutKind() { return default(bool); }
    public bool IsInternalCall() { return default(bool); }
    public static bool IsValidArgumentType(Mono.CSharp.TypeSpec t) { return default(bool); }
    public bool IsValidSecurityAttribute() { return default(bool); }
    public Mono.CSharp.MethodSpec Resolve() { return default(Mono.CSharp.MethodSpec); }
    public Mono.CSharp.TypeSpec ResolveTypeForComparison() { return default(Mono.CSharp.TypeSpec); }
  }
  public sealed partial class AttributeEncoder {
    public static readonly System.Byte[] Empty;
    public AttributeEncoder() { }
    public Mono.CSharp.AttributeEncoder.EncodedTypeProperties Encode(Mono.CSharp.TypeSpec type) { return default(Mono.CSharp.AttributeEncoder.EncodedTypeProperties); }
    public void Encode(bool value) { }
    public void Encode(byte value) { }
    public void Encode(double value) { }
    public void Encode(short value) { }
    public void Encode(int value) { }
    public void Encode(long value) { }
    public void Encode(sbyte value) { }
    public void Encode(float value) { }
    public void Encode(string value) { }
    public void Encode(ushort value) { }
    public void Encode(uint value) { }
    public void Encode(ulong value) { }
    public void EncodeEmptyNamedArguments() { }
    public void EncodeNamedArguments<T>(T[] members, Mono.CSharp.Constant[] values) where T : Mono.CSharp.MemberSpec, Mono.CSharp.IInterfaceMemberSpec { }
    public void EncodeNamedFieldArgument(Mono.CSharp.FieldSpec field, Mono.CSharp.Constant value) { }
    public void EncodeNamedPropertyArgument(Mono.CSharp.PropertySpec property, Mono.CSharp.Constant value) { }
    public void EncodeTypeName(Mono.CSharp.TypeContainer type) { }
    public void EncodeTypeName(Mono.CSharp.TypeSpec type) { }
    public System.Byte[] ToArray() { return default(System.Byte[]); }
    [System.FlagsAttribute]
    public enum EncodedTypeProperties {
      DynamicType = 1,
      None = 0,
      TypeParameter = 2,
    }
  }
  public partial class Attributes {
    public readonly System.Collections.Generic.List<Mono.CSharp.Attribute> Attrs;
    public Attributes(Mono.CSharp.Attribute a) { }
    public Attributes(System.Collections.Generic.List<Mono.CSharp.Attribute> attrs) { }
    public void AddAttribute(Mono.CSharp.Attribute attr) { }
    public void AddAttributes(System.Collections.Generic.List<Mono.CSharp.Attribute> attrs) { }
    public void AttachTo(Mono.CSharp.Attributable attributable, Mono.CSharp.IMemberContext context) { }
    public bool CheckTargets() { return default(bool); }
    public Mono.CSharp.Attributes Clone() { return default(Mono.CSharp.Attributes); }
    public bool Contains(Mono.CSharp.PredefinedAttribute t) { return default(bool); }
    public void ConvertGlobalAttributes(Mono.CSharp.TypeContainer member, Mono.CSharp.NamespaceContainer currentNamespace, bool isGlobal) { }
    public void Emit() { }
    public bool HasResolveError() { return default(bool); }
    public Mono.CSharp.Attribute Search(Mono.CSharp.PredefinedAttribute t) { return default(Mono.CSharp.Attribute); }
    public Mono.CSharp.Attribute Search(string explicitTarget, Mono.CSharp.PredefinedAttribute t) { return default(Mono.CSharp.Attribute); }
    public Mono.CSharp.Attribute[] SearchMulti(Mono.CSharp.PredefinedAttribute t) { return default(Mono.CSharp.Attribute[]); }
  }
  public abstract partial class ATypeNameExpression : Mono.CSharp.FullNamedExpression {
    protected Mono.CSharp.TypeArguments targs;
    protected ATypeNameExpression(string name, Mono.CSharp.Location l) { }
    protected ATypeNameExpression(string name, Mono.CSharp.TypeArguments targs, Mono.CSharp.Location l) { }
    protected ATypeNameExpression(string name, int arity, Mono.CSharp.Location l) { }
    protected int Arity { get { return default(int); } }
    public bool HasTypeArguments { get { return default(bool); } }
    public string Name { get { return default(string); } set { } }
    public Mono.CSharp.TypeArguments TypeArguments { get { return default(Mono.CSharp.TypeArguments); } }
    public override bool Equals(object obj) { return default(bool); }
    protected void Error_OpenGenericTypeIsNotAllowed(Mono.CSharp.IMemberContext mc) { }
    public override int GetHashCode() { return default(int); }
    public static string GetMemberType(Mono.CSharp.MemberCore mc) { return default(string); }
    public override string GetSignatureForError() { return default(string); }
    public abstract Mono.CSharp.Expression LookupNameExpression(Mono.CSharp.ResolveContext rc, Mono.CSharp.Expression.MemberLookupRestrictions restriction);
  }
  public partial class Await : Mono.CSharp.ExpressionStatement {
    public Await(Mono.CSharp.Expression expr, Mono.CSharp.Location loc) { }
    public Mono.CSharp.Expression Expr { get { return default(Mono.CSharp.Expression); } }
    public Mono.CSharp.AwaitStatement Statement { get { return default(Mono.CSharp.AwaitStatement); } }
    public override object Accept(Mono.CSharp.StructuralVisitor visitor) { return default(object); }
    protected override void CloneTo(Mono.CSharp.CloneContext clonectx, Mono.CSharp.Expression target) { }
    public override bool ContainsEmitWithAwait() { return default(bool); }
    public override Mono.CSharp.Expression CreateExpressionTree(Mono.CSharp.ResolveContext ec) { return default(Mono.CSharp.Expression); }
    protected override Mono.CSharp.Expression DoResolve(Mono.CSharp.ResolveContext rc) { return default(Mono.CSharp.Expression); }
    public override void Emit(Mono.CSharp.EmitContext ec) { }
    public void EmitAssign(Mono.CSharp.EmitContext ec, Mono.CSharp.FieldExpr field) { }
    public override void EmitStatement(Mono.CSharp.EmitContext ec) { }
    public override Mono.CSharp.Expression EmitToField(Mono.CSharp.EmitContext ec) { return default(Mono.CSharp.Expression); }
    public override void FlowAnalysis(Mono.CSharp.FlowAnalysisContext fc) { }
    public override void MarkReachable(Mono.CSharp.Reachability rc) { }
  }
  public partial class AwaiterDefinition {
    public AwaiterDefinition() { }
    public Mono.CSharp.MethodSpec GetResult { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(Mono.CSharp.MethodSpec); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public bool INotifyCompletion { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public Mono.CSharp.PropertySpec IsCompleted { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(Mono.CSharp.PropertySpec); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public bool IsValidPattern { get { return default(bool); } }
  }
  public partial class AwaitStatement : Mono.CSharp.YieldStatement<Mono.CSharp.AsyncInitializer> {
    public AwaitStatement(Mono.CSharp.Expression expr, Mono.CSharp.Location loc) : base (default(Mono.CSharp.Expression), default(Mono.CSharp.Location)) { }
    public Mono.CSharp.TypeSpec ResultType { get { return default(Mono.CSharp.TypeSpec); } }
    protected override void DoEmit(Mono.CSharp.EmitContext ec) { }
    public void EmitPrologue(Mono.CSharp.EmitContext ec) { }
    public void EmitStatement(Mono.CSharp.EmitContext ec) { }
    public Mono.CSharp.Expression GetResultExpression(Mono.CSharp.EmitContext ec) { return default(Mono.CSharp.Expression); }
    public override bool Resolve(Mono.CSharp.BlockContext bc) { return default(bool); }
    public sealed partial class AwaitableMemberAccess : Mono.CSharp.MemberAccess {
      public AwaitableMemberAccess(Mono.CSharp.Expression expr) : base (default(Mono.CSharp.Expression), default(string)) { }
      public bool ProbingMode { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
      protected override void Error_OperatorCannotBeApplied(Mono.CSharp.ResolveContext rc, Mono.CSharp.TypeSpec type) { }
      protected override void Error_TypeDoesNotContainDefinition(Mono.CSharp.ResolveContext rc, Mono.CSharp.TypeSpec type, string name) { }
    }
  }
  public partial class BaseThis : Mono.CSharp.This {
    public BaseThis(Mono.CSharp.Location loc) : base (default(Mono.CSharp.Location)) { }
    public BaseThis(Mono.CSharp.TypeSpec type, Mono.CSharp.Location loc) : base (default(Mono.CSharp.Location)) { }
    public override string Name { get { return default(string); } }
    public override object Accept(Mono.CSharp.StructuralVisitor visitor) { return default(object); }
    public override Mono.CSharp.Expression CreateExpressionTree(Mono.CSharp.ResolveContext ec) { return default(Mono.CSharp.Expression); }
    public override void Emit(Mono.CSharp.EmitContext ec) { }
    protected override void Error_ThisNotAvailable(Mono.CSharp.ResolveContext ec) { }
    public override void ResolveBase(Mono.CSharp.ResolveContext ec) { }
  }
  public partial class Binary : Mono.CSharp.Expression {
    public Binary(Mono.CSharp.Binary.Operator oper, Mono.CSharp.Expression left, Mono.CSharp.Expression right) { }
    public Binary(Mono.CSharp.Binary.Operator oper, Mono.CSharp.Expression left, Mono.CSharp.Expression right, Mono.CSharp.Location loc) { }
    public Binary(Mono.CSharp.Binary.Operator oper, Mono.CSharp.Expression left, Mono.CSharp.Expression right, bool isCompound) { }
    public bool IsCompound { get { return default(bool); } }
    public Mono.CSharp.Expression Left { get { return default(Mono.CSharp.Expression); } }
    public Mono.CSharp.Binary.Operator Oper { get { return default(Mono.CSharp.Binary.Operator); } }
    public Mono.CSharp.Expression Right { get { return default(Mono.CSharp.Expression); } }
    public override Mono.CSharp.Location StartLocation { get { return default(Mono.CSharp.Location); } }
    public override object Accept(Mono.CSharp.StructuralVisitor visitor) { return default(object); }
    protected override void CloneTo(Mono.CSharp.CloneContext clonectx, Mono.CSharp.Expression t) { }
    public override bool ContainsEmitWithAwait() { return default(bool); }
    public Mono.CSharp.Expression CreateCallSiteBinder(Mono.CSharp.ResolveContext ec, Mono.CSharp.Arguments args) { return default(Mono.CSharp.Expression); }
    public static Mono.CSharp.Binary.PredefinedOperator[] CreateEqualityLiftedOperatorsTable(Mono.CSharp.ModuleContainer module) { return default(Mono.CSharp.Binary.PredefinedOperator[]); }
    public static Mono.CSharp.Binary.PredefinedOperator[] CreateEqualityOperatorsTable(Mono.CSharp.BuiltinTypes types) { return default(Mono.CSharp.Binary.PredefinedOperator[]); }
    public override Mono.CSharp.Expression CreateExpressionTree(Mono.CSharp.ResolveContext ec) { return default(Mono.CSharp.Expression); }
    public Mono.CSharp.Expression CreateExpressionTree(Mono.CSharp.ResolveContext ec, Mono.CSharp.Expression method) { return default(Mono.CSharp.Expression); }
    public Mono.CSharp.Expression CreateLiftedValueTypeResult(Mono.CSharp.ResolveContext rc, Mono.CSharp.TypeSpec valueType) { return default(Mono.CSharp.Expression); }
    public static Mono.CSharp.Binary.PredefinedOperator[] CreatePointerOperatorsTable(Mono.CSharp.BuiltinTypes types) { return default(Mono.CSharp.Binary.PredefinedOperator[]); }
    public static Mono.CSharp.Binary.PredefinedOperator[] CreateStandardLiftedOperatorsTable(Mono.CSharp.ModuleContainer module) { return default(Mono.CSharp.Binary.PredefinedOperator[]); }
    public static Mono.CSharp.Binary.PredefinedOperator[] CreateStandardOperatorsTable(Mono.CSharp.BuiltinTypes types) { return default(Mono.CSharp.Binary.PredefinedOperator[]); }
    protected override Mono.CSharp.Expression DoResolve(Mono.CSharp.ResolveContext ec) { return default(Mono.CSharp.Expression); }
    public override void Emit(Mono.CSharp.EmitContext ec) { }
    public override void EmitBranchable(Mono.CSharp.EmitContext ec, System.Reflection.Emit.Label target, bool on_true) { }
    public void EmitOperator(Mono.CSharp.EmitContext ec, Mono.CSharp.Expression left, Mono.CSharp.Expression right) { }
    public static void EmitOperatorOpcode(Mono.CSharp.EmitContext ec, Mono.CSharp.Binary.Operator oper, Mono.CSharp.TypeSpec l, Mono.CSharp.Expression right) { }
    public override void EmitSideEffect(Mono.CSharp.EmitContext ec) { }
    public override Mono.CSharp.Expression EmitToField(Mono.CSharp.EmitContext ec) { return default(Mono.CSharp.Expression); }
    public static void Error_OperatorCannotBeApplied(Mono.CSharp.ResolveContext ec, Mono.CSharp.Expression left, Mono.CSharp.Expression right, Mono.CSharp.Binary.Operator oper, Mono.CSharp.Location loc) { }
    public static void Error_OperatorCannotBeApplied(Mono.CSharp.ResolveContext ec, Mono.CSharp.Expression left, Mono.CSharp.Expression right, string oper, Mono.CSharp.Location loc) { }
    public override void FlowAnalysis(Mono.CSharp.FlowAnalysisContext fc) { }
    public override void FlowAnalysisConditional(Mono.CSharp.FlowAnalysisContext fc) { }
    public static Mono.CSharp.ConvCast.Mode GetEnumResultCast(Mono.CSharp.TypeSpec type) { return default(Mono.CSharp.ConvCast.Mode); }
    public override System.Linq.Expressions.Expression MakeExpression(Mono.CSharp.BuilderContext ctx) { return default(System.Linq.Expressions.Expression); }
    public System.Linq.Expressions.Expression MakeExpression(Mono.CSharp.BuilderContext ctx, Mono.CSharp.Expression left, Mono.CSharp.Expression right) { return default(System.Linq.Expressions.Expression); }
    public Mono.CSharp.Expression ResolveOperator(Mono.CSharp.ResolveContext rc) { return default(Mono.CSharp.Expression); }
    [System.FlagsAttribute]
    public enum Operator {
      Addition = 2083,
      AdditionMask = 2048,
      ArithmeticMask = 32,
      BitwiseAnd = 525,
      BitwiseMask = 512,
      BitwiseOr = 527,
      ComparisonMask = 128,
      DecomposedMask = 524288,
      Division = 33,
      Equality = 395,
      EqualityMask = 256,
      ExclusiveOr = 526,
      GreaterThan = 8328,
      GreaterThanOrEqual = 8330,
      Inequality = 396,
      LeftShift = 69,
      LessThan = 8327,
      LessThanOrEqual = 8329,
      LogicalAnd = 1040,
      LogicalMask = 1024,
      LogicalOr = 1041,
      Modulus = 34,
      Multiply = 32,
      NullableMask = 1048576,
      RelationalMask = 8192,
      RightShift = 70,
      ShiftMask = 64,
      Subtraction = 4132,
      SubtractionMask = 4096,
      ValuesOnlyMask = 31,
    }
    public partial class PredefinedOperator {
      protected readonly Mono.CSharp.TypeSpec left;
      protected readonly Mono.CSharp.TypeSpec left_unwrap;
      public readonly Mono.CSharp.Binary.Operator OperatorsMask;
      public Mono.CSharp.TypeSpec ReturnType;
      protected readonly Mono.CSharp.TypeSpec right;
      protected readonly Mono.CSharp.TypeSpec right_unwrap;
      public PredefinedOperator(Mono.CSharp.TypeSpec type, Mono.CSharp.Binary.Operator op_mask) { }
      public PredefinedOperator(Mono.CSharp.TypeSpec type, Mono.CSharp.Binary.Operator op_mask, Mono.CSharp.TypeSpec return_type) { }
      public PredefinedOperator(Mono.CSharp.TypeSpec ltype, Mono.CSharp.TypeSpec rtype, Mono.CSharp.Binary.Operator op_mask) { }
      public PredefinedOperator(Mono.CSharp.TypeSpec ltype, Mono.CSharp.TypeSpec rtype, Mono.CSharp.Binary.Operator op_mask, Mono.CSharp.TypeSpec return_type) { }
      public bool IsLifted { get { return default(bool); } }
      public virtual Mono.CSharp.Expression ConvertResult(Mono.CSharp.ResolveContext rc, Mono.CSharp.Binary b) { return default(Mono.CSharp.Expression); }
      public virtual bool IsApplicable(Mono.CSharp.ResolveContext ec, Mono.CSharp.Expression lexpr, Mono.CSharp.Expression rexpr) { return default(bool); }
      public bool IsPrimitiveApplicable(Mono.CSharp.TypeSpec ltype, Mono.CSharp.TypeSpec rtype) { return default(bool); }
      public Mono.CSharp.Binary.PredefinedOperator ResolveBetterOperator(Mono.CSharp.ResolveContext ec, Mono.CSharp.Binary.PredefinedOperator best_operator) { return default(Mono.CSharp.Binary.PredefinedOperator); }
    }
  }
  [System.FlagsAttribute]
  public enum BindingRestriction {
    DeclaredOnly = 2,
    InstanceOnly = 4,
    NoAccessors = 8,
    None = 0,
    OverrideOnly = 16,
  }
  public partial class Block : Mono.CSharp.Statement {
    public Mono.CSharp.Location EndLocation;
    public Mono.CSharp.ExplicitBlock Explicit;
    protected Mono.CSharp.Block.Flags flags;
    public Mono.CSharp.ParametersBlock ParametersBlock;
    public Mono.CSharp.Block Parent;
    protected System.Collections.Generic.List<Mono.CSharp.Statement> scope_initializers;
    public Mono.CSharp.Location StartLocation;
    protected System.Collections.Generic.List<Mono.CSharp.Statement> statements;
    public Block(Mono.CSharp.Block parent, Mono.CSharp.Block.Flags flags, Mono.CSharp.Location start, Mono.CSharp.Location end) { }
    public Block(Mono.CSharp.Block parent, Mono.CSharp.Location start, Mono.CSharp.Location end) { }
    public bool IsCatchBlock { get { return default(bool); } }
    public bool IsCompilerGenerated { get { return default(bool); } set { } }
    public bool IsFinallyBlock { get { return default(bool); } }
    public Mono.CSharp.Block Original { get { return default(Mono.CSharp.Block); } protected set { } }
    public System.Collections.Generic.List<Mono.CSharp.Statement> Statements { get { return default(System.Collections.Generic.List<Mono.CSharp.Statement>); } }
    public bool Unchecked { get { return default(bool); } set { } }
    public bool Unsafe { get { return default(bool); } set { } }
    public override object Accept(Mono.CSharp.StructuralVisitor visitor) { return default(object); }
    public void AddLabel(Mono.CSharp.LabeledStatement target) { }
    public void AddLocalName(Mono.CSharp.LocalVariable li) { }
    public void AddLocalName(string name, Mono.CSharp.INamedBlockVariable li) { }
    public void AddScopeStatement(Mono.CSharp.Statement s) { }
    public void AddStatement(Mono.CSharp.Statement s) { }
    protected override void CloneTo(Mono.CSharp.CloneContext clonectx, Mono.CSharp.Statement t) { }
    protected override void DoEmit(Mono.CSharp.EmitContext ec) { }
    protected override bool DoFlowAnalysis(Mono.CSharp.FlowAnalysisContext fc) { return default(bool); }
    public override void Emit(Mono.CSharp.EmitContext ec) { }
    protected void EmitScopeInitializers(Mono.CSharp.EmitContext ec) { }
    public virtual void Error_AlreadyDeclared(string name, Mono.CSharp.INamedBlockVariable variable) { }
    public virtual void Error_AlreadyDeclared(string name, Mono.CSharp.INamedBlockVariable variable, string reason) { }
    public virtual void Error_AlreadyDeclaredTypeParameter(string name, Mono.CSharp.Location loc) { }
    public void InsertStatement(int index, Mono.CSharp.Statement s) { }
    public Mono.CSharp.LabeledStatement LookupLabel(string name) { return default(Mono.CSharp.LabeledStatement); }
    public override Mono.CSharp.Reachability MarkReachable(Mono.CSharp.Reachability rc) { return default(Mono.CSharp.Reachability); }
    public void MarkReachableScope(Mono.CSharp.Reachability rc) { }
    public override bool Resolve(Mono.CSharp.BlockContext bc) { return default(bool); }
    public void ScanGotoJump(Mono.CSharp.Statement label) { }
    public void ScanGotoJump(Mono.CSharp.Statement label, Mono.CSharp.FlowAnalysisContext fc) { }
    public void SetEndLocation(Mono.CSharp.Location loc) { }
    [System.FlagsAttribute]
    public enum Flags {
      AwaitBlock = 8192,
      CatchBlock = 32768,
      CompilerGenerated = 512,
      FinallyBlock = 16384,
      HasAsyncModifier = 1024,
      HasCapturedThis = 128,
      HasCapturedVariable = 64,
      InitializationEmitted = 4194304,
      IsExpressionTree = 256,
      Iterator = 1048576,
      NoFlowAnalysis = 2097152,
      ReachableEnd = 8,
      Resolved = 2048,
      Unchecked = 1,
      Unsafe = 16,
      YieldBlock = 4096,
    }
  }
  public partial class BlockConstant : Mono.CSharp.BlockVariable {
    public BlockConstant(Mono.CSharp.FullNamedExpression type, Mono.CSharp.LocalVariable li) : base (default(Mono.CSharp.FullNamedExpression), default(Mono.CSharp.LocalVariable)) { }
    public override object Accept(Mono.CSharp.StructuralVisitor visitor) { return default(object); }
    public override void Emit(Mono.CSharp.EmitContext ec) { }
    protected override Mono.CSharp.Expression ResolveInitializer(Mono.CSharp.BlockContext bc, Mono.CSharp.LocalVariable li, Mono.CSharp.Expression initializer) { return default(Mono.CSharp.Expression); }
  }
  public partial class BlockContext : Mono.CSharp.ResolveContext {
    public int AssignmentInfoOffset;
    public BlockContext(Mono.CSharp.IMemberContext mc, Mono.CSharp.ExplicitBlock block, Mono.CSharp.TypeSpec returnType) : base (default(Mono.CSharp.IMemberContext)) { }
    public BlockContext(Mono.CSharp.ResolveContext rc, Mono.CSharp.ExplicitBlock block, Mono.CSharp.TypeSpec returnType) : base (default(Mono.CSharp.IMemberContext)) { }
    public Mono.CSharp.ExceptionStatement CurrentTryBlock { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(Mono.CSharp.ExceptionStatement); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public Mono.CSharp.LoopStatement EnclosingLoop { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(Mono.CSharp.LoopStatement); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public Mono.CSharp.LoopStatement EnclosingLoopOrSwitch { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(Mono.CSharp.LoopStatement); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public Mono.CSharp.TypeSpec ReturnType { get { return default(Mono.CSharp.TypeSpec); } }
    public Mono.CSharp.Switch Switch { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(Mono.CSharp.Switch); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
  }
  public partial class BlockVariable : Mono.CSharp.Statement {
    protected System.Collections.Generic.List<Mono.CSharp.BlockVariableDeclarator> declarators;
    protected Mono.CSharp.LocalVariable li;
    protected Mono.CSharp.FullNamedExpression type_expr;
    public BlockVariable(Mono.CSharp.FullNamedExpression type, Mono.CSharp.LocalVariable li) { }
    protected BlockVariable(Mono.CSharp.LocalVariable li) { }
    public System.Collections.Generic.List<Mono.CSharp.BlockVariableDeclarator> Declarators { get { return default(System.Collections.Generic.List<Mono.CSharp.BlockVariableDeclarator>); } }
    public Mono.CSharp.Expression Initializer { get { return default(Mono.CSharp.Expression); } set { } }
    public Mono.CSharp.FullNamedExpression TypeExpression { get { return default(Mono.CSharp.FullNamedExpression); } }
    public Mono.CSharp.LocalVariable Variable { get { return default(Mono.CSharp.LocalVariable); } }
    public override object Accept(Mono.CSharp.StructuralVisitor visitor) { return default(object); }
    public void AddDeclarator(Mono.CSharp.BlockVariableDeclarator decl) { }
    protected override void CloneTo(Mono.CSharp.CloneContext clonectx, Mono.CSharp.Statement target) { }
    protected override void DoEmit(Mono.CSharp.EmitContext ec) { }
    protected override bool DoFlowAnalysis(Mono.CSharp.FlowAnalysisContext fc) { return default(bool); }
    public override Mono.CSharp.Reachability MarkReachable(Mono.CSharp.Reachability rc) { return default(Mono.CSharp.Reachability); }
    public override bool Resolve(Mono.CSharp.BlockContext bc) { return default(bool); }
    public bool Resolve(Mono.CSharp.BlockContext bc, bool resolveDeclaratorInitializers) { return default(bool); }
    protected virtual Mono.CSharp.Expression ResolveInitializer(Mono.CSharp.BlockContext bc, Mono.CSharp.LocalVariable li, Mono.CSharp.Expression initializer) { return default(Mono.CSharp.Expression); }
  }
  public partial class BlockVariableDeclarator {
    public BlockVariableDeclarator(Mono.CSharp.LocalVariable li, Mono.CSharp.Expression initializer) { }
    public Mono.CSharp.Expression Initializer { get { return default(Mono.CSharp.Expression); } set { } }
    public Mono.CSharp.LocalVariable Variable { get { return default(Mono.CSharp.LocalVariable); } }
    public virtual Mono.CSharp.BlockVariableDeclarator Clone(Mono.CSharp.CloneContext cloneCtx) { return default(Mono.CSharp.BlockVariableDeclarator); }
  }
  public partial class BoolConstant : Mono.CSharp.Constant {
    public readonly bool Value;
    public BoolConstant(Mono.CSharp.BuiltinTypes types, bool val, Mono.CSharp.Location loc) : base (default(Mono.CSharp.Location)) { }
    public BoolConstant(Mono.CSharp.TypeSpec type, bool val, Mono.CSharp.Location loc) : base (default(Mono.CSharp.Location)) { }
    public override bool IsDefaultValue { get { return default(bool); } }
    public override bool IsNegative { get { return default(bool); } }
    public override bool IsZeroInteger { get { return default(bool); } }
    public override Mono.CSharp.Constant ConvertExplicitly(bool in_checked_context, Mono.CSharp.TypeSpec target_type) { return default(Mono.CSharp.Constant); }
    public override void Emit(Mono.CSharp.EmitContext ec) { }
    public override void EncodeAttributeValue(Mono.CSharp.IMemberContext rc, Mono.CSharp.AttributeEncoder enc, Mono.CSharp.TypeSpec targetType, Mono.CSharp.TypeSpec parameterType) { }
    public override object GetValue() { return default(object); }
    public override string GetValueAsLiteral() { return default(string); }
    public override long GetValueAsLong() { return default(long); }
  }
  public partial class BooleanExpression : Mono.CSharp.ShimExpression {
    public BooleanExpression(Mono.CSharp.Expression expr) : base (default(Mono.CSharp.Expression)) { }
    public override object Accept(Mono.CSharp.StructuralVisitor visitor) { return default(object); }
    public override Mono.CSharp.Expression CreateExpressionTree(Mono.CSharp.ResolveContext ec) { return default(Mono.CSharp.Expression); }
    protected override Mono.CSharp.Expression DoResolve(Mono.CSharp.ResolveContext ec) { return default(Mono.CSharp.Expression); }
  }
  public partial class BooleanExpressionFalse : Mono.CSharp.Unary {
    public BooleanExpressionFalse(Mono.CSharp.Expression expr) : base (default(Mono.CSharp.Unary.Operator), default(Mono.CSharp.Expression), default(Mono.CSharp.Location)) { }
    protected override Mono.CSharp.Expression ResolveOperator(Mono.CSharp.ResolveContext ec, Mono.CSharp.Expression expr) { return default(Mono.CSharp.Expression); }
  }
  public partial class BoolLiteral : Mono.CSharp.BoolConstant, Mono.CSharp.ILiteralConstant {
    public BoolLiteral(Mono.CSharp.BuiltinTypes types, bool val, Mono.CSharp.Location loc) : base (default(Mono.CSharp.BuiltinTypes), default(bool), default(Mono.CSharp.Location)) { }
    public override bool IsLiteral { get { return default(bool); } }
    public override object Accept(Mono.CSharp.StructuralVisitor visitor) { return default(object); }
  }
  public partial class BoxedCast : Mono.CSharp.TypeCast {
    public BoxedCast(Mono.CSharp.Expression expr, Mono.CSharp.TypeSpec target_type) : base (default(Mono.CSharp.Expression), default(Mono.CSharp.TypeSpec)) { }
    protected override Mono.CSharp.Expression DoResolve(Mono.CSharp.ResolveContext ec) { return default(Mono.CSharp.Expression); }
    public override void Emit(Mono.CSharp.EmitContext ec) { }
    public override void EmitSideEffect(Mono.CSharp.EmitContext ec) { }
    public override void EncodeAttributeValue(Mono.CSharp.IMemberContext rc, Mono.CSharp.AttributeEncoder enc, Mono.CSharp.TypeSpec targetType, Mono.CSharp.TypeSpec parameterType) { }
  }
  public partial class Break : Mono.CSharp.LocalExitStatement {
    public Break(Mono.CSharp.Location l) : base (default(Mono.CSharp.Location)) { }
    public override object Accept(Mono.CSharp.StructuralVisitor visitor) { return default(object); }
    protected override void DoEmit(Mono.CSharp.EmitContext ec) { }
    protected override bool DoFlowAnalysis(Mono.CSharp.FlowAnalysisContext fc) { return default(bool); }
    protected override bool DoResolve(Mono.CSharp.BlockContext bc) { return default(bool); }
    public override Mono.CSharp.Reachability MarkReachable(Mono.CSharp.Reachability rc) { return default(Mono.CSharp.Reachability); }
  }
  public partial class BuilderContext {
    protected Mono.CSharp.BuilderContext.Options flags;
    public BuilderContext() { }
    public bool HasSet(Mono.CSharp.BuilderContext.Options options) { return default(bool); }
    public Mono.CSharp.BuilderContext.FlagsHandle With(Mono.CSharp.BuilderContext.Options options, bool enable) { return default(Mono.CSharp.BuilderContext.FlagsHandle); }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct FlagsHandle : System.IDisposable {
      public FlagsHandle(Mono.CSharp.BuilderContext ec, Mono.CSharp.BuilderContext.Options flagsToSet) { throw new System.NotImplementedException(); }
      public void Dispose() { }
    }
    [System.FlagsAttribute]
    public enum Options {
      AccurateDebugInfo = 2,
      AsyncBody = 16,
      CheckedScope = 1,
      ConstructorScope = 8,
      OmitDebugInfo = 4,
    }
  }
  public partial class BuiltinTypes {
    public readonly Mono.CSharp.BuiltinTypeSpec Array;
    public readonly Mono.CSharp.BuiltinTypeSpec Attribute;
    public readonly Mono.CSharp.TypeSpec[] BinaryPromotionsTypes;
    public readonly Mono.CSharp.BuiltinTypeSpec Bool;
    public readonly Mono.CSharp.BuiltinTypeSpec Byte;
    public readonly Mono.CSharp.BuiltinTypeSpec Char;
    public readonly Mono.CSharp.BuiltinTypeSpec Decimal;
    public readonly Mono.CSharp.BuiltinTypeSpec Delegate;
    public readonly Mono.CSharp.BuiltinTypeSpec Double;
    public readonly Mono.CSharp.BuiltinTypeSpec Dynamic;
    public readonly Mono.CSharp.BuiltinTypeSpec Enum;
    public readonly Mono.CSharp.BuiltinTypeSpec Exception;
    public readonly Mono.CSharp.BuiltinTypeSpec Float;
    public readonly Mono.CSharp.BuiltinTypeSpec IDisposable;
    public readonly Mono.CSharp.BuiltinTypeSpec IEnumerable;
    public readonly Mono.CSharp.BuiltinTypeSpec IEnumerator;
    public readonly Mono.CSharp.BuiltinTypeSpec Int;
    public readonly Mono.CSharp.BuiltinTypeSpec IntPtr;
    public readonly Mono.CSharp.BuiltinTypeSpec Long;
    public readonly Mono.CSharp.BuiltinTypeSpec MulticastDelegate;
    public readonly Mono.CSharp.BuiltinTypeSpec Object;
    public readonly Mono.CSharp.Binary.PredefinedOperator[] OperatorsBinaryEquality;
    public readonly Mono.CSharp.Binary.PredefinedOperator[] OperatorsBinaryStandard;
    public readonly Mono.CSharp.Binary.PredefinedOperator[] OperatorsBinaryUnsafe;
    public readonly Mono.CSharp.TypeSpec[][] OperatorsUnary;
    public readonly Mono.CSharp.TypeSpec[] OperatorsUnaryMutator;
    public readonly Mono.CSharp.BuiltinTypeSpec RuntimeFieldHandle;
    public readonly Mono.CSharp.BuiltinTypeSpec RuntimeTypeHandle;
    public readonly Mono.CSharp.BuiltinTypeSpec SByte;
    public readonly Mono.CSharp.BuiltinTypeSpec Short;
    public readonly Mono.CSharp.BuiltinTypeSpec String;
    public readonly Mono.CSharp.BuiltinTypeSpec Type;
    public readonly Mono.CSharp.BuiltinTypeSpec UInt;
    public readonly Mono.CSharp.BuiltinTypeSpec UIntPtr;
    public readonly Mono.CSharp.BuiltinTypeSpec ULong;
    public readonly Mono.CSharp.BuiltinTypeSpec UShort;
    public readonly Mono.CSharp.BuiltinTypeSpec ValueType;
    public readonly Mono.CSharp.BuiltinTypeSpec Void;
    public BuiltinTypes() { }
    public Mono.CSharp.BuiltinTypeSpec[] AllTypes { get { return default(Mono.CSharp.BuiltinTypeSpec[]); } }
    public bool CheckDefinitions(Mono.CSharp.ModuleContainer module) { return default(bool); }
  }
  public sealed partial class BuiltinTypeSpec : Mono.CSharp.TypeSpec {
    public BuiltinTypeSpec(Mono.CSharp.MemberKind kind, string ns, string name, Mono.CSharp.BuiltinTypeSpec.Type builtinKind) : base (default(Mono.CSharp.MemberKind), default(Mono.CSharp.TypeSpec), default(Mono.CSharp.ITypeDefinition), default(System.Type), default(Mono.CSharp.Modifiers)) { }
    public BuiltinTypeSpec(string name, Mono.CSharp.BuiltinTypeSpec.Type builtinKind) : base (default(Mono.CSharp.MemberKind), default(Mono.CSharp.TypeSpec), default(Mono.CSharp.ITypeDefinition), default(System.Type), default(Mono.CSharp.Modifiers)) { }
    public override int Arity { get { return default(int); } }
    public override Mono.CSharp.BuiltinTypeSpec.Type BuiltinType { get { return default(Mono.CSharp.BuiltinTypeSpec.Type); } }
    public string FullName { get { return default(string); } }
    public override string Name { get { return default(string); } }
    public string Namespace { get { return default(string); } }
    public override string GetSignatureForError() { return default(string); }
    public static int GetSize(Mono.CSharp.TypeSpec type) { return default(int); }
    public static bool IsPrimitiveType(Mono.CSharp.TypeSpec type) { return default(bool); }
    public static bool IsPrimitiveTypeOrDecimal(Mono.CSharp.TypeSpec type) { return default(bool); }
    public void SetDefinition(Mono.CSharp.ITypeDefinition td, System.Type type, Mono.CSharp.Modifiers mod) { }
    public void SetDefinition(Mono.CSharp.TypeSpec ts) { }
    public enum Type {
      Array = 24,
      Attribute = 29,
      Bool = 1,
      Byte = 2,
      Char = 4,
      Decimal = 13,
      Delegate = 22,
      Double = 12,
      Dynamic = 17,
      Enum = 21,
      Exception = 28,
      FirstPrimitive = 1,
      Float = 11,
      IDisposable = 27,
      IEnumerable = 26,
      IEnumerator = 25,
      Int = 7,
      IntPtr = 14,
      LastPrimitive = 12,
      Long = 9,
      MulticastDelegate = 23,
      None = 0,
      Object = 16,
      Other = 30,
      SByte = 3,
      Short = 5,
      String = 18,
      Type = 19,
      UInt = 8,
      UIntPtr = 15,
      ULong = 10,
      UShort = 6,
      ValueType = 20,
    }
  }
  public partial class ByteConstant : Mono.CSharp.IntegralConstant {
    public readonly byte Value;
    public ByteConstant(Mono.CSharp.BuiltinTypes types, byte v, Mono.CSharp.Location loc) : base (default(Mono.CSharp.TypeSpec), default(Mono.CSharp.Location)) { }
    public ByteConstant(Mono.CSharp.TypeSpec type, byte v, Mono.CSharp.Location loc) : base (default(Mono.CSharp.TypeSpec), default(Mono.CSharp.Location)) { }
    public override bool IsDefaultValue { get { return default(bool); } }
    public override bool IsNegative { get { return default(bool); } }
    public override bool IsOneInteger { get { return default(bool); } }
    public override bool IsZeroInteger { get { return default(bool); } }
    public override Mono.CSharp.Constant ConvertExplicitly(bool in_checked_context, Mono.CSharp.TypeSpec target_type) { return default(Mono.CSharp.Constant); }
    public override void Emit(Mono.CSharp.EmitContext ec) { }
    public override void EncodeAttributeValue(Mono.CSharp.IMemberContext rc, Mono.CSharp.AttributeEncoder enc, Mono.CSharp.TypeSpec targetType, Mono.CSharp.TypeSpec parameterType) { }
    public override object GetValue() { return default(object); }
    public override long GetValueAsLong() { return default(long); }
    public override Mono.CSharp.Constant Increment() { return default(Mono.CSharp.Constant); }
  }
  public partial class Cast : Mono.CSharp.ShimExpression {
    public Cast(Mono.CSharp.Expression cast_type, Mono.CSharp.Expression expr, Mono.CSharp.Location loc) : base (default(Mono.CSharp.Expression)) { }
    public Mono.CSharp.Expression TargetType { get { return default(Mono.CSharp.Expression); } }
    public override object Accept(Mono.CSharp.StructuralVisitor visitor) { return default(object); }
    protected override void CloneTo(Mono.CSharp.CloneContext clonectx, Mono.CSharp.Expression t) { }
    protected override Mono.CSharp.Expression DoResolve(Mono.CSharp.ResolveContext ec) { return default(Mono.CSharp.Expression); }
  }
  public partial class Catch : Mono.CSharp.Statement {
    public Catch(Mono.CSharp.ExplicitBlock block, Mono.CSharp.Location loc) { }
    public Mono.CSharp.ExplicitBlock Block { get { return default(Mono.CSharp.ExplicitBlock); } }
    public Mono.CSharp.TypeSpec CatchType { get { return default(Mono.CSharp.TypeSpec); } }
    public Mono.CSharp.Expression Filter { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(Mono.CSharp.Expression); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public bool IsGeneral { get { return default(bool); } }
    public Mono.CSharp.FullNamedExpression TypeExpression { get { return default(Mono.CSharp.FullNamedExpression); } set { } }
    public Mono.CSharp.LocalVariable Variable { get { return default(Mono.CSharp.LocalVariable); } set { } }
    protected override void CloneTo(Mono.CSharp.CloneContext clonectx, Mono.CSharp.Statement t) { }
    protected override void DoEmit(Mono.CSharp.EmitContext ec) { }
    protected override bool DoFlowAnalysis(Mono.CSharp.FlowAnalysisContext fc) { return default(bool); }
    public override Mono.CSharp.Reachability MarkReachable(Mono.CSharp.Reachability rc) { return default(Mono.CSharp.Reachability); }
    public override bool Resolve(Mono.CSharp.BlockContext bc) { return default(bool); }
  }
  public partial class CatchFilterExpression : Mono.CSharp.BooleanExpression {
    public CatchFilterExpression(Mono.CSharp.Expression expr, Mono.CSharp.Location loc) : base (default(Mono.CSharp.Expression)) { }
  }
  public partial class CharConstant : Mono.CSharp.Constant {
    public readonly char Value;
    public CharConstant(Mono.CSharp.BuiltinTypes types, char v, Mono.CSharp.Location loc) : base (default(Mono.CSharp.Location)) { }
    public CharConstant(Mono.CSharp.TypeSpec type, char v, Mono.CSharp.Location loc) : base (default(Mono.CSharp.Location)) { }
    public override bool IsDefaultValue { get { return default(bool); } }
    public override bool IsNegative { get { return default(bool); } }
    public override bool IsZeroInteger { get { return default(bool); } }
    public override Mono.CSharp.Constant ConvertExplicitly(bool in_checked_context, Mono.CSharp.TypeSpec target_type) { return default(Mono.CSharp.Constant); }
    public override void Emit(Mono.CSharp.EmitContext ec) { }
    public override void EncodeAttributeValue(Mono.CSharp.IMemberContext rc, Mono.CSharp.AttributeEncoder enc, Mono.CSharp.TypeSpec targetType, Mono.CSharp.TypeSpec parameterType) { }
    public override object GetValue() { return default(object); }
    public override string GetValueAsLiteral() { return default(string); }
    public override long GetValueAsLong() { return default(long); }
  }
  public partial class CharLiteral : Mono.CSharp.CharConstant, Mono.CSharp.ILiteralConstant {
    public CharLiteral(Mono.CSharp.BuiltinTypes types, char c, Mono.CSharp.Location loc) : base (default(Mono.CSharp.BuiltinTypes), default(char), default(Mono.CSharp.Location)) { }
    public override bool IsLiteral { get { return default(bool); } }
    public override object Accept(Mono.CSharp.StructuralVisitor visitor) { return default(object); }
  }
  public partial class Checked : Mono.CSharp.Statement {
    public Mono.CSharp.Block Block;
    public Checked(Mono.CSharp.Block b, Mono.CSharp.Location loc) { }
    public override object Accept(Mono.CSharp.StructuralVisitor visitor) { return default(object); }
    protected override void CloneTo(Mono.CSharp.CloneContext clonectx, Mono.CSharp.Statement t) { }
    protected override void DoEmit(Mono.CSharp.EmitContext ec) { }
    protected override bool DoFlowAnalysis(Mono.CSharp.FlowAnalysisContext fc) { return default(bool); }
    public override Mono.CSharp.Reachability MarkReachable(Mono.CSharp.Reachability rc) { return default(Mono.CSharp.Reachability); }
    public override bool Resolve(Mono.CSharp.BlockContext ec) { return default(bool); }
  }
  public partial class CheckedExpr : Mono.CSharp.Expression {
    public Mono.CSharp.Expression Expr;
    public CheckedExpr(Mono.CSharp.Expression e, Mono.CSharp.Location l) { }
    public override object Accept(Mono.CSharp.StructuralVisitor visitor) { return default(object); }
    protected override void CloneTo(Mono.CSharp.CloneContext clonectx, Mono.CSharp.Expression t) { }
    public override bool ContainsEmitWithAwait() { return default(bool); }
    public override Mono.CSharp.Expression CreateExpressionTree(Mono.CSharp.ResolveContext ec) { return default(Mono.CSharp.Expression); }
    protected override Mono.CSharp.Expression DoResolve(Mono.CSharp.ResolveContext ec) { return default(Mono.CSharp.Expression); }
    public override void Emit(Mono.CSharp.EmitContext ec) { }
    public override void EmitBranchable(Mono.CSharp.EmitContext ec, System.Reflection.Emit.Label target, bool on_true) { }
    public override void FlowAnalysis(Mono.CSharp.FlowAnalysisContext fc) { }
    public override System.Linq.Expressions.Expression MakeExpression(Mono.CSharp.BuilderContext ctx) { return default(System.Linq.Expressions.Expression); }
  }
  public sealed partial class Class : Mono.CSharp.ClassOrStruct {
    public Class(Mono.CSharp.TypeContainer parent, Mono.CSharp.MemberName name, Mono.CSharp.Modifiers mod, Mono.CSharp.Attributes attrs) : base (default(Mono.CSharp.TypeContainer), default(Mono.CSharp.MemberName), default(Mono.CSharp.Attributes), default(Mono.CSharp.MemberKind)) { }
    public override System.AttributeTargets AttributeTargets { get { return default(System.AttributeTargets); } }
    public override void Accept(Mono.CSharp.StructuralVisitor visitor) { }
    public override void ApplyAttributeBuilder(Mono.CSharp.Attribute a, Mono.CSharp.MethodSpec ctor, System.Byte[] cdata, Mono.CSharp.PredefinedAttributes pa) { }
    public override System.String[] ConditionalConditions() { return default(System.String[]); }
    protected override bool DoDefineMembers() { return default(bool); }
    public override void Emit() { }
    public override void GetCompletionStartingWith(string prefix, System.Collections.Generic.List<System.String> results) { }
    protected override Mono.CSharp.TypeSpec[] ResolveBaseTypes(out Mono.CSharp.FullNamedExpression base_class) { base_class = default(Mono.CSharp.FullNamedExpression); return default(Mono.CSharp.TypeSpec[]); }
    public override void SetBaseTypes(System.Collections.Generic.List<Mono.CSharp.FullNamedExpression> baseTypes) { }
  }
  public sealed partial class ClassCast : Mono.CSharp.TypeCast {
    public ClassCast(Mono.CSharp.Expression child, Mono.CSharp.TypeSpec return_type) : base (default(Mono.CSharp.Expression), default(Mono.CSharp.TypeSpec)) { }
    public ClassCast(Mono.CSharp.Expression child, Mono.CSharp.TypeSpec return_type, bool forced) : base (default(Mono.CSharp.Expression), default(Mono.CSharp.TypeSpec)) { }
    public override void Emit(Mono.CSharp.EmitContext ec) { }
  }
  public abstract partial class ClassOrStruct : Mono.CSharp.TypeDefinition {
    protected Mono.CSharp.Constructor generated_primary_constructor;
    public const System.Reflection.TypeAttributes StaticClassAttribute = 384;
    protected ClassOrStruct(Mono.CSharp.TypeContainer parent, Mono.CSharp.MemberName name, Mono.CSharp.Attributes attrs, Mono.CSharp.MemberKind kind) : base (default(Mono.CSharp.TypeContainer), default(Mono.CSharp.MemberName), default(Mono.CSharp.Attributes), default(Mono.CSharp.MemberKind)) { }
    public Mono.CSharp.ToplevelBlock PrimaryConstructorBlock { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(Mono.CSharp.ToplevelBlock); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    protected override System.Reflection.TypeAttributes TypeAttr { get { return default(System.Reflection.TypeAttributes); } }
    public override void AddNameToContainer(Mono.CSharp.MemberCore symbol, string name) { }
    public override void ApplyAttributeBuilder(Mono.CSharp.Attribute a, Mono.CSharp.MethodSpec ctor, System.Byte[] cdata, Mono.CSharp.PredefinedAttributes pa) { }
    protected virtual Mono.CSharp.Constructor DefineDefaultConstructor(bool is_static) { return default(Mono.CSharp.Constructor); }
    protected override bool DoDefineMembers() { return default(bool); }
    public override void Emit() { }
  }
  public partial class CloneContext {
    public CloneContext() { }
    public void AddBlockMap(Mono.CSharp.Block from, Mono.CSharp.Block to) { }
    public Mono.CSharp.Block LookupBlock(Mono.CSharp.Block from) { return default(Mono.CSharp.Block); }
    public Mono.CSharp.Block RemapBlockCopy(Mono.CSharp.Block from) { return default(Mono.CSharp.Block); }
  }
  public partial class CollectionOrObjectInitializers : Mono.CSharp.ExpressionStatement {
    public CollectionOrObjectInitializers(Mono.CSharp.Location loc) { }
    public CollectionOrObjectInitializers(System.Collections.Generic.IList<Mono.CSharp.Expression> initializers, Mono.CSharp.Location loc) { }
    public System.Collections.Generic.IList<Mono.CSharp.Expression> Initializers { get { return default(System.Collections.Generic.IList<Mono.CSharp.Expression>); } }
    public bool IsCollectionInitializer { get { return default(bool); } }
    public bool IsEmpty { get { return default(bool); } }
    protected override void CloneTo(Mono.CSharp.CloneContext clonectx, Mono.CSharp.Expression target) { }
    public override bool ContainsEmitWithAwait() { return default(bool); }
    public override Mono.CSharp.Expression CreateExpressionTree(Mono.CSharp.ResolveContext ec) { return default(Mono.CSharp.Expression); }
    public Mono.CSharp.Expression CreateExpressionTree(Mono.CSharp.ResolveContext ec, bool inferType) { return default(Mono.CSharp.Expression); }
    protected override Mono.CSharp.Expression DoResolve(Mono.CSharp.ResolveContext ec) { return default(Mono.CSharp.Expression); }
    public override void Emit(Mono.CSharp.EmitContext ec) { }
    public override void EmitStatement(Mono.CSharp.EmitContext ec) { }
    public override void FlowAnalysis(Mono.CSharp.FlowAnalysisContext fc) { }
  }
  public partial class CommandLineParser {
    public CommandLineParser(System.IO.TextWriter errorOutput) { }
    public CommandLineParser(System.IO.TextWriter errorOutput, System.IO.TextWriter messagesOutput) { }
    public bool HasBeenStopped { get { return default(bool); } }
    public event System.Func<System.String[], System.Int32, System.Int32> UnknownOptionHandler { add { } remove { } }
    public bool ParseArguments(Mono.CSharp.CompilerSettings settings, System.String[] args) { return default(bool); }
    public Mono.CSharp.CompilerSettings ParseArguments(System.String[] args) { return default(Mono.CSharp.CompilerSettings); }
    public bool ProcessWarningsList(string text, System.Action<System.Int32> action) { return default(bool); }
  }
  public partial class Comparer : System.Collections.IComparer {
    internal Comparer() { }
    public int Compare(object a, object b) { return default(int); }
    public static System.Reflection.EventInfo[] Sort(System.Reflection.EventInfo[] inf) { return default(System.Reflection.EventInfo[]); }
    public static System.Reflection.MemberInfo[] Sort(System.Reflection.MemberInfo[] inf) { return default(System.Reflection.MemberInfo[]); }
    public static System.Reflection.MethodBase[] Sort(System.Reflection.MethodBase[] inf) { return default(System.Reflection.MethodBase[]); }
    public static System.Reflection.PropertyInfo[] Sort(System.Reflection.PropertyInfo[] inf) { return default(System.Reflection.PropertyInfo[]); }
  }
  public partial class CompilationSourceFile : Mono.CSharp.NamespaceContainer {
    public CompilationSourceFile(Mono.CSharp.ModuleContainer parent) : base (default(Mono.CSharp.MemberName), default(Mono.CSharp.NamespaceContainer)) { }
    public CompilationSourceFile(Mono.CSharp.ModuleContainer parent, Mono.CSharp.SourceFile sourceFile) : base (default(Mono.CSharp.MemberName), default(Mono.CSharp.NamespaceContainer)) { }
    public string FileName { get { return default(string); } }
    public Mono.CSharp.SourceFile SourceFile { get { return default(Mono.CSharp.SourceFile); } }
    public Mono.CompilerServices.SymbolWriter.CompileUnitEntry SymbolUnitEntry { get { return default(Mono.CompilerServices.SymbolWriter.CompileUnitEntry); } }
    public override void Accept(Mono.CSharp.StructuralVisitor visitor) { }
    public void AddDefine(string value) { }
    public void AddIncludeFile(Mono.CSharp.SourceFile file) { }
    public void AddUndefine(string value) { }
    public bool IsConditionalDefined(string value) { return default(bool); }
    public override void PrepareEmit() { }
  }
  public delegate void CompiledMethod(ref object retvalue);
  public partial class CompilerCallableEntryPoint : System.MarshalByRefObject {
    public CompilerCallableEntryPoint() { }
    public static System.Int32[] AllWarningNumbers { get { return default(System.Int32[]); } }
    public static bool InvokeCompiler(System.String[] args, System.IO.TextWriter error) { return default(bool); }
    public static void PartialReset() { }
    public static void Reset() { }
    public static void Reset(bool full_flag) { }
  }
  public partial class CompilerContext {
    public CompilerContext(Mono.CSharp.CompilerSettings settings, Mono.CSharp.ReportPrinter reportPrinter) { }
    public Mono.CSharp.BuiltinTypes BuiltinTypes { get { return default(Mono.CSharp.BuiltinTypes); } }
    public bool IsRuntimeBinder { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public Mono.CSharp.Report Report { get { return default(Mono.CSharp.Report); } }
    public Mono.CSharp.CompilerSettings Settings { get { return default(Mono.CSharp.CompilerSettings); } }
    public System.Collections.Generic.List<Mono.CSharp.SourceFile> SourceFiles { get { return default(System.Collections.Generic.List<Mono.CSharp.SourceFile>); } }
    public Mono.CSharp.SourceFile LookupFile(Mono.CSharp.CompilationSourceFile comp_unit, string name) { return default(Mono.CSharp.SourceFile); }
  }
  public abstract partial class CompilerGeneratedContainer : Mono.CSharp.ClassOrStruct {
    protected CompilerGeneratedContainer(Mono.CSharp.TypeContainer parent, Mono.CSharp.MemberName name, Mono.CSharp.Modifiers mod) : base (default(Mono.CSharp.TypeContainer), default(Mono.CSharp.MemberName), default(Mono.CSharp.Attributes), default(Mono.CSharp.MemberKind)) { }
    protected CompilerGeneratedContainer(Mono.CSharp.TypeContainer parent, Mono.CSharp.MemberName name, Mono.CSharp.Modifiers mod, Mono.CSharp.MemberKind kind) : base (default(Mono.CSharp.TypeContainer), default(Mono.CSharp.MemberName), default(Mono.CSharp.Attributes), default(Mono.CSharp.MemberKind)) { }
    protected void CheckMembersDefined() { }
    protected override bool DoDefineMembers() { return default(bool); }
    protected static Mono.CSharp.MemberName MakeMemberName(Mono.CSharp.MemberBase host, string name, int unique_id, Mono.CSharp.TypeParameters tparams, Mono.CSharp.Location loc) { return default(Mono.CSharp.MemberName); }
    public static string MakeName(string host, string typePrefix, string name, int id) { return default(string); }
    protected override Mono.CSharp.TypeSpec[] ResolveBaseTypes(out Mono.CSharp.FullNamedExpression base_class) { base_class = default(Mono.CSharp.FullNamedExpression); return default(Mono.CSharp.TypeSpec[]); }
  }
  public partial class CompilerSettings {
    public System.Collections.Generic.List<System.String> AssemblyReferences;
    public System.Collections.Generic.List<Mono.CSharp.Tuple<System.String, System.String>> AssemblyReferencesAliases;
    public bool BreakOnInternalError;
    public bool Checked;
    public int DebugFlags;
    public string DocumentationFile;
    public System.Text.Encoding Encoding;
    public bool EnhancedWarnings;
    public int FatalCounter;
    public bool GenerateDebugInfo;
    public bool LoadDefaultReferences;
    public string MainClass;
    public System.Collections.Generic.List<System.String> Modules;
    public bool Optimize;
    public string OutputFile;
    public bool ParseOnly;
    public Mono.CSharp.Platform Platform;
    public System.Collections.Generic.List<System.String> ReferencesLookupPaths;
    public System.Collections.Generic.List<Mono.CSharp.AssemblyResource> Resources;
    public string RuntimeMetadataVersion;
    public string SdkVersion;
    public bool ShowFullPaths;
    public bool Stacktrace;
    public bool StatementMode;
    public bool StdLib;
    public Mono.CSharp.RuntimeVersion StdLibRuntimeVersion;
    public bool StrongNameDelaySign;
    public string StrongNameKeyContainer;
    public string StrongNameKeyFile;
    public int TabSize;
    public Mono.CSharp.Target Target;
    public string TargetExt;
    public bool Timestamps;
    public bool TokenizeOnly;
    public bool Unsafe;
    public int VerboseParserFlag;
    public bool VerifyClsCompliance;
    public Mono.CSharp.LanguageVersion Version;
    public int WarningLevel;
    public bool WarningsAreErrors;
    public string Win32IconFile;
    public string Win32ResourceFile;
    public bool WriteMetadataOnly;
    public CompilerSettings() { }
    public Mono.CSharp.SourceFile FirstSourceFile { get { return default(Mono.CSharp.SourceFile); } }
    public bool HasKeyFileOrContainer { get { return default(bool); } }
    public bool NeedsEntryPoint { get { return default(bool); } }
    public System.Collections.Generic.List<Mono.CSharp.SourceFile> SourceFiles { get { return default(System.Collections.Generic.List<Mono.CSharp.SourceFile>); } }
    public void AddConditionalSymbol(string symbol) { }
    public void AddWarningAsError(int id) { }
    public void AddWarningOnly(int id) { }
    public bool IsConditionalSymbolDefined(string symbol) { return default(bool); }
    public bool IsWarningAsError(int code) { return default(bool); }
    public bool IsWarningDisabledGlobally(int code) { return default(bool); }
    public bool IsWarningEnabled(int code, int level) { return default(bool); }
    public void SetIgnoreWarning(int code) { }
  }
  public abstract partial class CompletingExpression : Mono.CSharp.ExpressionStatement {
    protected CompletingExpression() { }
    public static void AppendResults(System.Collections.Generic.List<System.String> results, string prefix, System.Collections.Generic.IEnumerable<System.String> names) { }
    public override bool ContainsEmitWithAwait() { return default(bool); }
    public override Mono.CSharp.Expression CreateExpressionTree(Mono.CSharp.ResolveContext ec) { return default(Mono.CSharp.Expression); }
    public override void Emit(Mono.CSharp.EmitContext ec) { }
    public override void EmitStatement(Mono.CSharp.EmitContext ec) { }
  }
  public partial class CompletionElementInitializer : Mono.CSharp.CompletingExpression {
    public CompletionElementInitializer(string partial_name, Mono.CSharp.Location l) { }
    protected override void CloneTo(Mono.CSharp.CloneContext clonectx, Mono.CSharp.Expression t) { }
    protected override Mono.CSharp.Expression DoResolve(Mono.CSharp.ResolveContext ec) { return default(Mono.CSharp.Expression); }
  }
  public partial class CompletionMemberAccess : Mono.CSharp.CompletingExpression {
    public CompletionMemberAccess(Mono.CSharp.Expression e, string partial_name, Mono.CSharp.Location l) { }
    public CompletionMemberAccess(Mono.CSharp.Expression e, string partial_name, Mono.CSharp.TypeArguments targs, Mono.CSharp.Location l) { }
    protected override void CloneTo(Mono.CSharp.CloneContext clonectx, Mono.CSharp.Expression t) { }
    protected override Mono.CSharp.Expression DoResolve(Mono.CSharp.ResolveContext rc) { return default(Mono.CSharp.Expression); }
  }
  public partial class CompletionResult : System.Exception {
    public CompletionResult(string base_text, System.String[] res) { }
    public string BaseText { get { return default(string); } }
    public System.String[] Result { get { return default(System.String[]); } }
  }
  public partial class CompletionSimpleName : Mono.CSharp.CompletingExpression {
    public string Prefix;
    public CompletionSimpleName(string prefix, Mono.CSharp.Location l) { }
    protected override void CloneTo(Mono.CSharp.CloneContext clonectx, Mono.CSharp.Expression t) { }
    protected override Mono.CSharp.Expression DoResolve(Mono.CSharp.ResolveContext ec) { return default(Mono.CSharp.Expression); }
  }
  public partial class ComposedCast : Mono.CSharp.TypeExpr {
    public ComposedCast(Mono.CSharp.FullNamedExpression left, Mono.CSharp.ComposedTypeSpecifier spec) { }
    public override object Accept(Mono.CSharp.StructuralVisitor visitor) { return default(object); }
    public override string GetSignatureForError() { return default(string); }
    public override Mono.CSharp.TypeSpec ResolveAsType(Mono.CSharp.IMemberContext ec, bool allowUnboundTypeArguments) { return default(Mono.CSharp.TypeSpec); }
  }
  public partial class ComposedTypeSpecifier {
    public readonly int Dimension;
    public readonly Mono.CSharp.Location Location;
    public static readonly Mono.CSharp.ComposedTypeSpecifier SingleDimension;
    public ComposedTypeSpecifier(int specifier, Mono.CSharp.Location loc) { }
    public bool IsNullable { get { return default(bool); } }
    public bool IsPointer { get { return default(bool); } }
    public Mono.CSharp.ComposedTypeSpecifier Next { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(Mono.CSharp.ComposedTypeSpecifier); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public static Mono.CSharp.ComposedTypeSpecifier CreateArrayDimension(int dimension, Mono.CSharp.Location loc) { return default(Mono.CSharp.ComposedTypeSpecifier); }
    public static Mono.CSharp.ComposedTypeSpecifier CreateNullable(Mono.CSharp.Location loc) { return default(Mono.CSharp.ComposedTypeSpecifier); }
    public static Mono.CSharp.ComposedTypeSpecifier CreatePointer(Mono.CSharp.Location loc) { return default(Mono.CSharp.ComposedTypeSpecifier); }
    public string GetSignatureForError() { return default(string); }
  }
  public abstract partial class CompositeExpression : Mono.CSharp.Expression {
    protected Mono.CSharp.Expression expr;
    protected CompositeExpression(Mono.CSharp.Expression expr) { }
    public Mono.CSharp.Expression Child { get { return default(Mono.CSharp.Expression); } }
    public override bool IsNull { get { return default(bool); } }
    public override bool ContainsEmitWithAwait() { return default(bool); }
    public override Mono.CSharp.Expression CreateExpressionTree(Mono.CSharp.ResolveContext rc) { return default(Mono.CSharp.Expression); }
    protected override Mono.CSharp.Expression DoResolve(Mono.CSharp.ResolveContext rc) { return default(Mono.CSharp.Expression); }
    public override void Emit(Mono.CSharp.EmitContext ec) { }
  }
  public partial class CompoundAssign : Mono.CSharp.Assign {
    public CompoundAssign(Mono.CSharp.Binary.Operator op, Mono.CSharp.Expression target, Mono.CSharp.Expression source) : base (default(Mono.CSharp.Expression), default(Mono.CSharp.Expression), default(Mono.CSharp.Location)) { }
    public CompoundAssign(Mono.CSharp.Binary.Operator op, Mono.CSharp.Expression target, Mono.CSharp.Expression source, Mono.CSharp.Expression left) : base (default(Mono.CSharp.Expression), default(Mono.CSharp.Expression), default(Mono.CSharp.Location)) { }
    public Mono.CSharp.Binary.Operator Operator { get { return default(Mono.CSharp.Binary.Operator); } }
    public override object Accept(Mono.CSharp.StructuralVisitor visitor) { return default(object); }
    protected override void CloneTo(Mono.CSharp.CloneContext clonectx, Mono.CSharp.Expression t) { }
    protected override Mono.CSharp.Expression DoResolve(Mono.CSharp.ResolveContext ec) { return default(Mono.CSharp.Expression); }
    public override void FlowAnalysis(Mono.CSharp.FlowAnalysisContext fc) { }
    protected override Mono.CSharp.Expression ResolveConversions(Mono.CSharp.ResolveContext ec) { return default(Mono.CSharp.Expression); }
    public sealed partial class TargetExpression : Mono.CSharp.Expression {
      public TargetExpression(Mono.CSharp.Expression child) { }
      public override bool ContainsEmitWithAwait() { return default(bool); }
      public override Mono.CSharp.Expression CreateExpressionTree(Mono.CSharp.ResolveContext ec) { return default(Mono.CSharp.Expression); }
      protected override Mono.CSharp.Expression DoResolve(Mono.CSharp.ResolveContext ec) { return default(Mono.CSharp.Expression); }
      public override void Emit(Mono.CSharp.EmitContext ec) { }
      public override Mono.CSharp.Expression EmitToField(Mono.CSharp.EmitContext ec) { return default(Mono.CSharp.Expression); }
    }
  }
  public partial class Conditional : Mono.CSharp.Expression {
    public Conditional(Mono.CSharp.Expression expr, Mono.CSharp.Expression true_expr, Mono.CSharp.Expression false_expr, Mono.CSharp.Location loc) { }
    public Mono.CSharp.Expression Expr { get { return default(Mono.CSharp.Expression); } }
    public Mono.CSharp.Expression FalseExpr { get { return default(Mono.CSharp.Expression); } }
    public Mono.CSharp.Expression TrueExpr { get { return default(Mono.CSharp.Expression); } }
    protected override void CloneTo(Mono.CSharp.CloneContext clonectx, Mono.CSharp.Expression t) { }
    public override bool ContainsEmitWithAwait() { return default(bool); }
    public override Mono.CSharp.Expression CreateExpressionTree(Mono.CSharp.ResolveContext ec) { return default(Mono.CSharp.Expression); }
    protected override Mono.CSharp.Expression DoResolve(Mono.CSharp.ResolveContext ec) { return default(Mono.CSharp.Expression); }
    public override void Emit(Mono.CSharp.EmitContext ec) { }
    public override void FlowAnalysis(Mono.CSharp.FlowAnalysisContext fc) { }
    public override void FlowAnalysisConditional(Mono.CSharp.FlowAnalysisContext fc) { }
  }
  public partial class ConditionalAccessContext {
    public ConditionalAccessContext(Mono.CSharp.TypeSpec type, System.Reflection.Emit.Label endLabel) { }
    public System.Reflection.Emit.Label EndLabel { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Reflection.Emit.Label); } }
    public bool Statement { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public Mono.CSharp.TypeSpec Type { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(Mono.CSharp.TypeSpec); } }
  }
  public partial class ConditionalLogicalOperator : Mono.CSharp.UserOperatorCall {
    public ConditionalLogicalOperator(Mono.CSharp.MethodSpec oper, Mono.CSharp.Arguments arguments, System.Func<Mono.CSharp.ResolveContext, Mono.CSharp.Expression, Mono.CSharp.Expression> expr_tree, bool is_and, Mono.CSharp.Location loc) : base (default(Mono.CSharp.MethodSpec), default(Mono.CSharp.Arguments), default(System.Func<Mono.CSharp.ResolveContext, Mono.CSharp.Expression, Mono.CSharp.Expression>), default(Mono.CSharp.Location)) { }
    protected override Mono.CSharp.Expression DoResolve(Mono.CSharp.ResolveContext ec) { return default(Mono.CSharp.Expression); }
    public override void Emit(Mono.CSharp.EmitContext ec) { }
  }
  public partial class ConditionalMemberAccess : Mono.CSharp.MemberAccess {
    public ConditionalMemberAccess(Mono.CSharp.Expression expr, string identifier, Mono.CSharp.TypeArguments args, Mono.CSharp.Location loc) : base (default(Mono.CSharp.Expression), default(string)) { }
    public override bool HasConditionalAccess() { return default(bool); }
  }
  public partial class ConsoleReportPrinter : Mono.CSharp.StreamReportPrinter {
    public ConsoleReportPrinter() : base (default(System.IO.TextWriter)) { }
    public ConsoleReportPrinter(System.IO.TextWriter writer) : base (default(System.IO.TextWriter)) { }
    protected override string FormatText(string txt) { return default(string); }
  }
  public partial class Const : Mono.CSharp.FieldBase {
    public Const(Mono.CSharp.TypeDefinition parent, Mono.CSharp.FullNamedExpression type, Mono.CSharp.Modifiers mod_flags, Mono.CSharp.MemberName name, Mono.CSharp.Attributes attrs) : base (default(Mono.CSharp.TypeDefinition), default(Mono.CSharp.FullNamedExpression), default(Mono.CSharp.Modifiers), default(Mono.CSharp.Modifiers), default(Mono.CSharp.MemberName), default(Mono.CSharp.Attributes)) { }
    public override void Accept(Mono.CSharp.StructuralVisitor visitor) { }
    public override bool Define() { return default(bool); }
    public void DefineValue() { }
    public override void Emit() { }
    public static void Error_InvalidConstantType(Mono.CSharp.TypeSpec t, Mono.CSharp.Location loc, Mono.CSharp.Report Report) { }
  }
  public abstract partial class Constant : Mono.CSharp.Expression {
    protected Constant(Mono.CSharp.Location loc) { }
    public abstract bool IsDefaultValue { get; }
    public virtual bool IsLiteral { get { return default(bool); } }
    public abstract bool IsNegative { get; }
    public virtual bool IsOneInteger { get { return default(bool); } }
    public override bool IsSideEffectFree { get { return default(bool); } }
    public virtual bool IsZeroInteger { get { return default(bool); } }
    public sealed override Mono.CSharp.Expression Clone(Mono.CSharp.CloneContext clonectx) { return default(Mono.CSharp.Expression); }
    protected override void CloneTo(Mono.CSharp.CloneContext clonectx, Mono.CSharp.Expression target) { }
    public override bool ContainsEmitWithAwait() { return default(bool); }
    public abstract Mono.CSharp.Constant ConvertExplicitly(bool in_checked_context, Mono.CSharp.TypeSpec target_type);
    public virtual Mono.CSharp.Constant ConvertImplicitly(Mono.CSharp.TypeSpec type) { return default(Mono.CSharp.Constant); }
    public static Mono.CSharp.Constant CreateConstantFromValue(Mono.CSharp.TypeSpec t, object v, Mono.CSharp.Location loc) { return default(Mono.CSharp.Constant); }
    public override Mono.CSharp.Expression CreateExpressionTree(Mono.CSharp.ResolveContext ec) { return default(Mono.CSharp.Expression); }
    protected override Mono.CSharp.Expression DoResolve(Mono.CSharp.ResolveContext rc) { return default(Mono.CSharp.Expression); }
    public override void EmitSideEffect(Mono.CSharp.EmitContext ec) { }
    public override void Error_ValueCannotBeConverted(Mono.CSharp.ResolveContext ec, Mono.CSharp.TypeSpec target, bool expl) { }
    public static Mono.CSharp.Constant ExtractConstantFromValue(Mono.CSharp.TypeSpec t, object v, Mono.CSharp.Location loc) { return default(Mono.CSharp.Constant); }
    public virtual object GetTypedValue() { return default(object); }
    public abstract object GetValue();
    public abstract string GetValueAsLiteral();
    public abstract long GetValueAsLong();
    public Mono.CSharp.Constant ImplicitConversionRequired(Mono.CSharp.ResolveContext ec, Mono.CSharp.TypeSpec type) { return default(Mono.CSharp.Constant); }
    public bool IsDefaultInitializer(Mono.CSharp.TypeSpec type) { return default(bool); }
    public override System.Linq.Expressions.Expression MakeExpression(Mono.CSharp.BuilderContext ctx) { return default(System.Linq.Expressions.Expression); }
    public Mono.CSharp.Constant Reduce(Mono.CSharp.ResolveContext ec, Mono.CSharp.TypeSpec target_type) { return default(Mono.CSharp.Constant); }
    public new bool Resolve(Mono.CSharp.ResolveContext rc) { return default(bool); }
    public override string ToString() { return default(string); }
    public Mono.CSharp.Constant TryReduce(Mono.CSharp.ResolveContext rc, Mono.CSharp.TypeSpec targetType) { return default(Mono.CSharp.Constant); }
  }
  public partial class ConstantExpr : Mono.CSharp.MemberExpr {
    public ConstantExpr(Mono.CSharp.ConstSpec constant, Mono.CSharp.Location loc) { }
    protected override Mono.CSharp.TypeSpec DeclaringType { get { return default(Mono.CSharp.TypeSpec); } }
    public override bool IsInstance { get { return default(bool); } }
    public override bool IsStatic { get { return default(bool); } }
    public override string KindName { get { return default(string); } }
    public override string Name { get { return default(string); } }
    public override Mono.CSharp.Expression CreateExpressionTree(Mono.CSharp.ResolveContext ec) { return default(Mono.CSharp.Expression); }
    protected override Mono.CSharp.Expression DoResolve(Mono.CSharp.ResolveContext rc) { return default(Mono.CSharp.Expression); }
    public override void Emit(Mono.CSharp.EmitContext ec) { }
    public override string GetSignatureForError() { return default(string); }
    public override void SetTypeArguments(Mono.CSharp.ResolveContext ec, Mono.CSharp.TypeArguments ta) { }
  }
  public static partial class ConstantFold {
    public static Mono.CSharp.Constant BinaryFold(Mono.CSharp.ResolveContext ec, Mono.CSharp.Binary.Operator oper, Mono.CSharp.Constant left, Mono.CSharp.Constant right, Mono.CSharp.Location loc) { return default(Mono.CSharp.Constant); }
    public static Mono.CSharp.TypeSpec[] CreateBinaryPromotionsTypes(Mono.CSharp.BuiltinTypes types) { return default(Mono.CSharp.TypeSpec[]); }
  }
  public partial class ConstInitializer : Mono.CSharp.ShimExpression {
    public ConstInitializer(Mono.CSharp.FieldBase field, Mono.CSharp.Expression value, Mono.CSharp.Location loc) : base (default(Mono.CSharp.Expression)) { }
    public string Name { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public override object Accept(Mono.CSharp.StructuralVisitor visitor) { return default(object); }
    protected override Mono.CSharp.Expression DoResolve(Mono.CSharp.ResolveContext unused) { return default(Mono.CSharp.Expression); }
    protected virtual Mono.CSharp.Expression DoResolveInitializer(Mono.CSharp.ResolveContext rc) { return default(Mono.CSharp.Expression); }
    public override string GetSignatureForError() { return default(string); }
  }
  public partial class Constraints {
    public Constraints(Mono.CSharp.SimpleMemberName tparam, System.Collections.Generic.List<Mono.CSharp.FullNamedExpression> constraints, Mono.CSharp.Location loc) { }
    public Mono.CSharp.Location Location { get { return default(Mono.CSharp.Location); } }
    public System.Collections.Generic.List<Mono.CSharp.FullNamedExpression> TypeExpressions { get { return default(System.Collections.Generic.List<Mono.CSharp.FullNamedExpression>); } }
    public Mono.CSharp.SimpleMemberName TypeParameter { get { return default(Mono.CSharp.SimpleMemberName); } }
    public static bool CheckConflictingInheritedConstraint(Mono.CSharp.TypeParameterSpec spec, Mono.CSharp.TypeSpec bb, Mono.CSharp.IMemberContext context, Mono.CSharp.Location loc) { return default(bool); }
    public void CheckGenericConstraints(Mono.CSharp.IMemberContext context, bool obsoleteCheck) { }
    public static void Error_ConflictingConstraints(Mono.CSharp.IMemberContext context, Mono.CSharp.TypeParameterSpec tp, Mono.CSharp.TypeSpec ba, Mono.CSharp.TypeSpec bb, Mono.CSharp.Location loc) { }
    public bool Resolve(Mono.CSharp.IMemberContext context, Mono.CSharp.TypeParameter tp) { return default(bool); }
    public void VerifyClsCompliance(Mono.CSharp.Report report) { }
  }
  public partial class Constructor : Mono.CSharp.MethodCore, Mono.CSharp.IMemberContext, Mono.CSharp.IMemberDefinition, Mono.CSharp.IMethodData, Mono.CSharp.IMethodDefinition, Mono.CSharp.IModuleContext {
    public const Mono.CSharp.Modifiers AllowedModifiers = 10383;
    public System.Reflection.Emit.ConstructorBuilder ConstructorBuilder;
    public static readonly string ConstructorName;
    public Mono.CSharp.ConstructorInitializer Initializer;
    public static readonly string TypeConstructorName;
    public Constructor(Mono.CSharp.TypeDefinition parent, string name, Mono.CSharp.Modifiers mod, Mono.CSharp.Attributes attrs, Mono.CSharp.ParametersCompiled args, Mono.CSharp.Location loc) : base (default(Mono.CSharp.TypeDefinition), default(Mono.CSharp.FullNamedExpression), default(Mono.CSharp.Modifiers), default(Mono.CSharp.Modifiers), default(Mono.CSharp.MemberName), default(Mono.CSharp.Attributes), default(Mono.CSharp.ParametersCompiled)) { }
    public override System.AttributeTargets AttributeTargets { get { return default(System.AttributeTargets); } }
    public bool HasCompliantArgs { get { return default(bool); } }
    public bool IsPrimaryConstructor { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public Mono.CSharp.MemberName MethodName { get { return default(Mono.CSharp.MemberName); } }
    bool Mono.CSharp.IMethodData.IsAccessor { get { return default(bool); } }
    System.Reflection.MethodBase Mono.CSharp.IMethodDefinition.Metadata { get { return default(System.Reflection.MethodBase); } }
    public Mono.CSharp.TypeSpec ReturnType { get { return default(Mono.CSharp.TypeSpec); } }
    public override System.String[] ValidAttributeTargets { get { return default(System.String[]); } }
    public override void Accept(Mono.CSharp.StructuralVisitor visitor) { }
    public override void ApplyAttributeBuilder(Mono.CSharp.Attribute a, Mono.CSharp.MethodSpec ctor, System.Byte[] cdata, Mono.CSharp.PredefinedAttributes pa) { }
    protected override bool CheckBase() { return default(bool); }
    public override bool Define() { return default(bool); }
    public override void Emit() { }
    protected override Mono.CSharp.MemberSpec FindBaseMember(out Mono.CSharp.MemberSpec bestCandidate, ref bool overrides) { bestCandidate = default(Mono.CSharp.MemberSpec); return default(Mono.CSharp.MemberSpec); }
    public override string GetCallerMemberName() { return default(string); }
    public override string GetSignatureForDocumentation() { return default(string); }
    public override string GetSignatureForError() { return default(string); }
    public bool IsDefault() { return default(bool); }
    Mono.CSharp.EmitContext Mono.CSharp.IMethodData.CreateEmitContext(System.Reflection.Emit.ILGenerator ig, Mono.CompilerServices.SymbolWriter.SourceMethodBuilder sourceMethod) { return default(Mono.CSharp.EmitContext); }
    protected override bool VerifyClsCompliance() { return default(bool); }
    public override void WriteDebugSymbol(Mono.CompilerServices.SymbolWriter.MonoSymbolFile file) { }
  }
  public partial class ConstructorBaseInitializer : Mono.CSharp.ConstructorInitializer {
    public ConstructorBaseInitializer(Mono.CSharp.Arguments argument_list, Mono.CSharp.Location l) : base (default(Mono.CSharp.Arguments), default(Mono.CSharp.Location)) { }
  }
  public abstract partial class ConstructorInitializer : Mono.CSharp.ExpressionStatement {
    protected ConstructorInitializer(Mono.CSharp.Arguments argument_list, Mono.CSharp.Location loc) { }
    public Mono.CSharp.Arguments Arguments { get { return default(Mono.CSharp.Arguments); } }
    public override bool ContainsEmitWithAwait() { return default(bool); }
    public override Mono.CSharp.Expression CreateExpressionTree(Mono.CSharp.ResolveContext ec) { return default(Mono.CSharp.Expression); }
    protected override Mono.CSharp.Expression DoResolve(Mono.CSharp.ResolveContext ec) { return default(Mono.CSharp.Expression); }
    public override void Emit(Mono.CSharp.EmitContext ec) { }
    public override void EmitStatement(Mono.CSharp.EmitContext ec) { }
    public override void FlowAnalysis(Mono.CSharp.FlowAnalysisContext fc) { }
  }
  public partial class ConstructorThisInitializer : Mono.CSharp.ConstructorInitializer {
    public ConstructorThisInitializer(Mono.CSharp.Arguments argument_list, Mono.CSharp.Location l) : base (default(Mono.CSharp.Arguments), default(Mono.CSharp.Location)) { }
  }
  public partial class ConstSpec : Mono.CSharp.FieldSpec {
    public ConstSpec(Mono.CSharp.TypeSpec declaringType, Mono.CSharp.IMemberDefinition definition, Mono.CSharp.TypeSpec memberType, System.Reflection.FieldInfo fi, Mono.CSharp.Modifiers mod, Mono.CSharp.Expression value) : base (default(Mono.CSharp.TypeSpec), default(Mono.CSharp.IMemberDefinition), default(Mono.CSharp.TypeSpec), default(System.Reflection.FieldInfo), default(Mono.CSharp.Modifiers)) { }
    public Mono.CSharp.Expression Value { get { return default(Mono.CSharp.Expression); } }
    public Mono.CSharp.Constant GetConstant(Mono.CSharp.ResolveContext rc) { return default(Mono.CSharp.Constant); }
  }
  public partial class ContextualReturn : Mono.CSharp.Return {
    public ContextualReturn(Mono.CSharp.Expression expr) : base (default(Mono.CSharp.Expression), default(Mono.CSharp.Location)) { }
    public override Mono.CSharp.Expression CreateExpressionTree(Mono.CSharp.ResolveContext ec) { return default(Mono.CSharp.Expression); }
    protected override void DoEmit(Mono.CSharp.EmitContext ec) { }
    protected override bool DoResolve(Mono.CSharp.BlockContext ec) { return default(bool); }
  }
  public partial class Continue : Mono.CSharp.LocalExitStatement {
    public Continue(Mono.CSharp.Location l) : base (default(Mono.CSharp.Location)) { }
    public override object Accept(Mono.CSharp.StructuralVisitor visitor) { return default(object); }
    protected override void DoEmit(Mono.CSharp.EmitContext ec) { }
    protected override bool DoResolve(Mono.CSharp.BlockContext bc) { return default(bool); }
    public override Mono.CSharp.Reachability MarkReachable(Mono.CSharp.Reachability rc) { return default(Mono.CSharp.Reachability); }
  }
  public partial class ConvCast : Mono.CSharp.TypeCast {
    public ConvCast(Mono.CSharp.Expression child, Mono.CSharp.TypeSpec return_type, Mono.CSharp.ConvCast.Mode m) : base (default(Mono.CSharp.Expression), default(Mono.CSharp.TypeSpec)) { }
    protected override Mono.CSharp.Expression DoResolve(Mono.CSharp.ResolveContext ec) { return default(Mono.CSharp.Expression); }
    public override void Emit(Mono.CSharp.EmitContext ec) { }
    public static void Emit(Mono.CSharp.EmitContext ec, Mono.CSharp.ConvCast.Mode mode) { }
    public override string ToString() { return default(string); }
    public enum Mode : byte {
      CH_I1 = (byte)48,
      CH_I2 = (byte)50,
      CH_U1 = (byte)49,
      I_I8 = (byte)70,
      I1_CH = (byte)4,
      I1_U1 = (byte)0,
      I1_U2 = (byte)1,
      I1_U4 = (byte)2,
      I1_U8 = (byte)3,
      I2_CH = (byte)12,
      I2_I1 = (byte)7,
      I2_U1 = (byte)8,
      I2_U2 = (byte)9,
      I2_U4 = (byte)10,
      I2_U8 = (byte)11,
      I4_CH = (byte)23,
      I4_I1 = (byte)17,
      I4_I2 = (byte)19,
      I4_U1 = (byte)18,
      I4_U2 = (byte)20,
      I4_U4 = (byte)21,
      I4_U8 = (byte)22,
      I8_CH = (byte)37,
      I8_I = (byte)38,
      I8_I1 = (byte)30,
      I8_I2 = (byte)32,
      I8_I4 = (byte)34,
      I8_U1 = (byte)31,
      I8_U2 = (byte)33,
      I8_U4 = (byte)35,
      I8_U8 = (byte)36,
      R4_CH = (byte)59,
      R4_I1 = (byte)51,
      R4_I2 = (byte)53,
      R4_I4 = (byte)55,
      R4_I8 = (byte)57,
      R4_U1 = (byte)52,
      R4_U2 = (byte)54,
      R4_U4 = (byte)56,
      R4_U8 = (byte)58,
      R8_CH = (byte)68,
      R8_I1 = (byte)60,
      R8_I2 = (byte)62,
      R8_I4 = (byte)64,
      R8_I8 = (byte)66,
      R8_R4 = (byte)69,
      R8_U1 = (byte)61,
      R8_U2 = (byte)63,
      R8_U4 = (byte)65,
      R8_U8 = (byte)67,
      U1_CH = (byte)6,
      U1_I1 = (byte)5,
      U2_CH = (byte)16,
      U2_I1 = (byte)13,
      U2_I2 = (byte)15,
      U2_U1 = (byte)14,
      U4_CH = (byte)29,
      U4_I1 = (byte)24,
      U4_I2 = (byte)26,
      U4_I4 = (byte)28,
      U4_U1 = (byte)25,
      U4_U2 = (byte)27,
      U8_CH = (byte)46,
      U8_I = (byte)47,
      U8_I1 = (byte)39,
      U8_I2 = (byte)41,
      U8_I4 = (byte)43,
      U8_I8 = (byte)45,
      U8_U1 = (byte)40,
      U8_U2 = (byte)42,
      U8_U4 = (byte)44,
    }
  }
  [System.FlagsAttribute]
  public enum CSharpBinderFlags {
    BinaryOperationLogical = 8,
    CheckedContext = 1,
    ConvertArrayIndex = 32,
    ConvertExplicit = 16,
    InvokeSimpleName = 2,
    InvokeSpecialName = 4,
    None = 0,
    ResultDiscarded = 256,
    ResultIndexed = 64,
    ValueFromCompoundAssignment = 128,
  }
  public partial class CSharpParser {
    public int eof_token;
    public System.IO.TextWriter ErrorOutput;
    public Mono.CSharp.Class InteractiveResult;
    public Mono.CSharp.Undo undo;
    public bool UnexpectedEOF;
    protected bool use_global_stacks;
    protected static readonly System.Int16[] yyCheck;
    protected static readonly System.Int16[] yyDgoto;
    protected const int yyFinal = 7;
    protected static readonly System.Int16[] yyGindex;
    protected int yyMax;
    protected static readonly System.String[] yyNames;
    protected static readonly System.Int16[] yyRindex;
    protected static readonly System.Int16[] yySindex;
    protected static readonly System.Int16[] yyTable;
    public CSharpParser(Mono.CSharp.SeekableStreamReader reader, Mono.CSharp.CompilationSourceFile file, Mono.CSharp.ParserSession session) { }
    public CSharpParser(Mono.CSharp.SeekableStreamReader reader, Mono.CSharp.CompilationSourceFile file, Mono.CSharp.Report report, Mono.CSharp.ParserSession session) { }
    public Mono.CSharp.Tokenizer Lexer { get { return default(Mono.CSharp.Tokenizer); } }
    public void parse() { }
    protected object yyDefault(object first) { return default(object); }
    public void yyerror(string message) { }
    public void yyerror(string message, System.String[] expected) { }
    protected System.String[] yyExpecting(int state) { return default(System.String[]); }
    protected System.Int32[] yyExpectingTokens(int state) { return default(System.Int32[]); }
  }
  public partial class DecimalConstant : Mono.CSharp.Constant {
    public readonly decimal Value;
    public DecimalConstant(Mono.CSharp.BuiltinTypes types, decimal d, Mono.CSharp.Location loc) : base (default(Mono.CSharp.Location)) { }
    public DecimalConstant(Mono.CSharp.TypeSpec type, decimal d, Mono.CSharp.Location loc) : base (default(Mono.CSharp.Location)) { }
    public override bool IsDefaultValue { get { return default(bool); } }
    public override bool IsNegative { get { return default(bool); } }
    public override Mono.CSharp.Constant ConvertExplicitly(bool in_checked_context, Mono.CSharp.TypeSpec target_type) { return default(Mono.CSharp.Constant); }
    public override void Emit(Mono.CSharp.EmitContext ec) { }
    public override object GetValue() { return default(object); }
    public override string GetValueAsLiteral() { return default(string); }
    public override long GetValueAsLong() { return default(long); }
  }
  public partial class DecimalLiteral : Mono.CSharp.DecimalConstant, Mono.CSharp.ILiteralConstant {
    public DecimalLiteral(Mono.CSharp.BuiltinTypes types, decimal d, Mono.CSharp.Location loc) : base (default(Mono.CSharp.BuiltinTypes), default(decimal), default(Mono.CSharp.Location)) { }
    public override bool IsLiteral { get { return default(bool); } }
    public override object Accept(Mono.CSharp.StructuralVisitor visitor) { return default(object); }
  }
  public partial class DeclarationExpression : Mono.CSharp.Expression, Mono.CSharp.IMemoryLocation {
    public DeclarationExpression(Mono.CSharp.FullNamedExpression variableType, Mono.CSharp.LocalVariable variable) { }
    public Mono.CSharp.Expression Initializer { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(Mono.CSharp.Expression); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public Mono.CSharp.LocalVariable Variable { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(Mono.CSharp.LocalVariable); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public Mono.CSharp.FullNamedExpression VariableType { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(Mono.CSharp.FullNamedExpression); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public void AddressOf(Mono.CSharp.EmitContext ec, Mono.CSharp.AddressOp mode) { }
    protected override void CloneTo(Mono.CSharp.CloneContext clonectx, Mono.CSharp.Expression t) { }
    public override Mono.CSharp.Expression CreateExpressionTree(Mono.CSharp.ResolveContext rc) { return default(Mono.CSharp.Expression); }
    protected override Mono.CSharp.Expression DoResolve(Mono.CSharp.ResolveContext rc) { return default(Mono.CSharp.Expression); }
    public override Mono.CSharp.Expression DoResolveLValue(Mono.CSharp.ResolveContext rc, Mono.CSharp.Expression right_side) { return default(Mono.CSharp.Expression); }
    public override void Emit(Mono.CSharp.EmitContext ec) { }
  }
  public partial class DefaultParameterValueExpression : Mono.CSharp.CompositeExpression {
    public DefaultParameterValueExpression(Mono.CSharp.Expression expr) : base (default(Mono.CSharp.Expression)) { }
    public override object Accept(Mono.CSharp.StructuralVisitor visitor) { return default(object); }
    public void Resolve(Mono.CSharp.ResolveContext rc, Mono.CSharp.Parameter p) { }
  }
  public partial class DefaultValueExpression : Mono.CSharp.Expression {
    public DefaultValueExpression(Mono.CSharp.Expression expr, Mono.CSharp.Location loc) { }
    public Mono.CSharp.Expression Expr { get { return default(Mono.CSharp.Expression); } }
    public override bool IsSideEffectFree { get { return default(bool); } }
    public override object Accept(Mono.CSharp.StructuralVisitor visitor) { return default(object); }
    protected override void CloneTo(Mono.CSharp.CloneContext clonectx, Mono.CSharp.Expression t) { }
    public override bool ContainsEmitWithAwait() { return default(bool); }
    public override Mono.CSharp.Expression CreateExpressionTree(Mono.CSharp.ResolveContext ec) { return default(Mono.CSharp.Expression); }
    protected override Mono.CSharp.Expression DoResolve(Mono.CSharp.ResolveContext ec) { return default(Mono.CSharp.Expression); }
    public override void Emit(Mono.CSharp.EmitContext ec) { }
  }
  public partial class DefiniteAssignmentBitSet {
    public static readonly Mono.CSharp.DefiniteAssignmentBitSet Empty;
    public DefiniteAssignmentBitSet(Mono.CSharp.DefiniteAssignmentBitSet source) { }
    public DefiniteAssignmentBitSet(int length) { }
    public bool this[int index] { get { return default(bool); } }
    public static Mono.CSharp.DefiniteAssignmentBitSet And(System.Collections.Generic.List<Mono.CSharp.DefiniteAssignmentBitSet> das) { return default(Mono.CSharp.DefiniteAssignmentBitSet); }
    public static Mono.CSharp.DefiniteAssignmentBitSet operator &(Mono.CSharp.DefiniteAssignmentBitSet a, Mono.CSharp.DefiniteAssignmentBitSet b) { return default(Mono.CSharp.DefiniteAssignmentBitSet); }
    public static Mono.CSharp.DefiniteAssignmentBitSet operator |(Mono.CSharp.DefiniteAssignmentBitSet a, Mono.CSharp.DefiniteAssignmentBitSet b) { return default(Mono.CSharp.DefiniteAssignmentBitSet); }
    public void Set(int index) { }
    public void Set(int index, int length) { }
    public override string ToString() { return default(string); }
  }
  public partial class Delegate : Mono.CSharp.TypeDefinition, Mono.CSharp.IInterfaceMemberSpec, Mono.CSharp.IParametersMember {
    public static readonly string InvokeMethodName;
    public Delegate(Mono.CSharp.TypeContainer parent, Mono.CSharp.FullNamedExpression type, Mono.CSharp.Modifiers mod_flags, Mono.CSharp.MemberName name, Mono.CSharp.ParametersCompiled param_list, Mono.CSharp.Attributes attrs) : base (default(Mono.CSharp.TypeContainer), default(Mono.CSharp.MemberName), default(Mono.CSharp.Attributes), default(Mono.CSharp.MemberKind)) { }
    public override System.AttributeTargets AttributeTargets { get { return default(System.AttributeTargets); } }
    public Mono.CSharp.Expression InstanceExpression { get { return default(Mono.CSharp.Expression); } set { } }
    public Mono.CSharp.TypeSpec MemberType { get { return default(Mono.CSharp.TypeSpec); } }
    public Mono.CSharp.AParametersCollection Parameters { get { return default(Mono.CSharp.AParametersCollection); } }
    protected override System.Reflection.TypeAttributes TypeAttr { get { return default(System.Reflection.TypeAttributes); } }
    public Mono.CSharp.FullNamedExpression TypExpression { get { return default(Mono.CSharp.FullNamedExpression); } }
    public override System.String[] ValidAttributeTargets { get { return default(System.String[]); } }
    public override void Accept(Mono.CSharp.StructuralVisitor visitor) { }
    public override void ApplyAttributeBuilder(Mono.CSharp.Attribute a, Mono.CSharp.MethodSpec ctor, System.Byte[] cdata, Mono.CSharp.PredefinedAttributes pa) { }
    protected override bool DoDefineMembers() { return default(bool); }
    public override void Emit() { }
    public static string FullDelegateDesc(Mono.CSharp.MethodSpec invoke_method) { return default(string); }
    public static Mono.CSharp.MethodSpec GetConstructor(Mono.CSharp.TypeSpec delType) { return default(Mono.CSharp.MethodSpec); }
    public static Mono.CSharp.MethodSpec GetInvokeMethod(Mono.CSharp.TypeSpec delType) { return default(Mono.CSharp.MethodSpec); }
    public static Mono.CSharp.AParametersCollection GetParameters(Mono.CSharp.TypeSpec delType) { return default(Mono.CSharp.AParametersCollection); }
    public static bool IsTypeCovariant(Mono.CSharp.ResolveContext rc, Mono.CSharp.TypeSpec a, Mono.CSharp.TypeSpec b) { return default(bool); }
    public override void PrepareEmit() { }
    protected override Mono.CSharp.TypeSpec[] ResolveBaseTypes(out Mono.CSharp.FullNamedExpression base_class) { base_class = default(Mono.CSharp.FullNamedExpression); return default(Mono.CSharp.TypeSpec[]); }
    protected override bool VerifyClsCompliance() { return default(bool); }
  }
  public abstract partial class DelegateCreation : Mono.CSharp.Expression, Mono.CSharp.OverloadResolver.IErrorHandler {
    protected Mono.CSharp.MethodSpec constructor_method;
    protected Mono.CSharp.MethodGroupExpr method_group;
    protected DelegateCreation() { }
    public bool AllowSpecialMethodsInvocation { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public override bool ContainsEmitWithAwait() { return default(bool); }
    public static Mono.CSharp.Arguments CreateDelegateMethodArguments(Mono.CSharp.ResolveContext rc, Mono.CSharp.AParametersCollection pd, Mono.CSharp.TypeSpec[] types, Mono.CSharp.Location loc) { return default(Mono.CSharp.Arguments); }
    public override Mono.CSharp.Expression CreateExpressionTree(Mono.CSharp.ResolveContext ec) { return default(Mono.CSharp.Expression); }
    protected override Mono.CSharp.Expression DoResolve(Mono.CSharp.ResolveContext ec) { return default(Mono.CSharp.Expression); }
    public override void Emit(Mono.CSharp.EmitContext ec) { }
    public override void FlowAnalysis(Mono.CSharp.FlowAnalysisContext fc) { }
    public static bool ImplicitStandardConversionExists(Mono.CSharp.ResolveContext ec, Mono.CSharp.MethodGroupExpr mg, Mono.CSharp.TypeSpec target_type) { return default(bool); }
    bool Mono.CSharp.OverloadResolver.IErrorHandler.AmbiguousCandidates(Mono.CSharp.ResolveContext ec, Mono.CSharp.MemberSpec best, Mono.CSharp.MemberSpec ambiguous) { return default(bool); }
    bool Mono.CSharp.OverloadResolver.IErrorHandler.ArgumentMismatch(Mono.CSharp.ResolveContext rc, Mono.CSharp.MemberSpec best, Mono.CSharp.Argument arg, int index) { return default(bool); }
    bool Mono.CSharp.OverloadResolver.IErrorHandler.NoArgumentMatch(Mono.CSharp.ResolveContext rc, Mono.CSharp.MemberSpec best) { return default(bool); }
    bool Mono.CSharp.OverloadResolver.IErrorHandler.TypeInferenceFailed(Mono.CSharp.ResolveContext rc, Mono.CSharp.MemberSpec best) { return default(bool); }
  }
  public partial class Destructor : Mono.CSharp.MethodOrOperator {
    public static readonly string MetadataName;
    public Destructor(Mono.CSharp.TypeDefinition parent, Mono.CSharp.Modifiers mod, Mono.CSharp.ParametersCompiled parameters, Mono.CSharp.Attributes attrs, Mono.CSharp.Location l) : base (default(Mono.CSharp.TypeDefinition), default(Mono.CSharp.FullNamedExpression), default(Mono.CSharp.Modifiers), default(Mono.CSharp.Modifiers), default(Mono.CSharp.MemberName), default(Mono.CSharp.Attributes), default(Mono.CSharp.ParametersCompiled)) { }
    public override System.String[] ValidAttributeTargets { get { return default(System.String[]); } }
    public override void Accept(Mono.CSharp.StructuralVisitor visitor) { }
    public override void ApplyAttributeBuilder(Mono.CSharp.Attribute a, Mono.CSharp.MethodSpec ctor, System.Byte[] cdata, Mono.CSharp.PredefinedAttributes pa) { }
    protected override bool CheckBase() { return default(bool); }
    public override bool Define() { return default(bool); }
    public override void Emit() { }
    public override string GetSignatureForError() { return default(string); }
    protected override bool ResolveMemberType() { return default(bool); }
  }
  public partial class Do : Mono.CSharp.LoopStatement {
    public Mono.CSharp.Expression expr;
    public Do(Mono.CSharp.Statement statement, Mono.CSharp.BooleanExpression bool_expr, Mono.CSharp.Location doLocation, Mono.CSharp.Location whileLocation) : base (default(Mono.CSharp.Statement)) { }
    public Mono.CSharp.Location WhileLocation { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(Mono.CSharp.Location); } }
    public override object Accept(Mono.CSharp.StructuralVisitor visitor) { return default(object); }
    protected override void CloneTo(Mono.CSharp.CloneContext clonectx, Mono.CSharp.Statement t) { }
    protected override void DoEmit(Mono.CSharp.EmitContext ec) { }
    protected override bool DoFlowAnalysis(Mono.CSharp.FlowAnalysisContext fc) { return default(bool); }
    public override Mono.CSharp.Reachability MarkReachable(Mono.CSharp.Reachability rc) { return default(Mono.CSharp.Reachability); }
    public override bool Resolve(Mono.CSharp.BlockContext bc) { return default(bool); }
    public override void SetEndReachable() { }
    public override void SetIteratorReachable() { }
  }
  public partial class DoubleConstant : Mono.CSharp.Constant {
    public readonly double Value;
    public DoubleConstant(Mono.CSharp.BuiltinTypes types, double v, Mono.CSharp.Location loc) : base (default(Mono.CSharp.Location)) { }
    public DoubleConstant(Mono.CSharp.TypeSpec type, double v, Mono.CSharp.Location loc) : base (default(Mono.CSharp.Location)) { }
    public override bool IsDefaultValue { get { return default(bool); } }
    public override bool IsNegative { get { return default(bool); } }
    public override Mono.CSharp.Constant ConvertExplicitly(bool in_checked_context, Mono.CSharp.TypeSpec target_type) { return default(Mono.CSharp.Constant); }
    public override void Emit(Mono.CSharp.EmitContext ec) { }
    public override void EncodeAttributeValue(Mono.CSharp.IMemberContext rc, Mono.CSharp.AttributeEncoder enc, Mono.CSharp.TypeSpec targetType, Mono.CSharp.TypeSpec parameterType) { }
    public override object GetValue() { return default(object); }
    public override string GetValueAsLiteral() { return default(string); }
    public override long GetValueAsLong() { return default(long); }
  }
  public partial class DoubleLiteral : Mono.CSharp.DoubleConstant, Mono.CSharp.ILiteralConstant {
    public DoubleLiteral(Mono.CSharp.BuiltinTypes types, double d, Mono.CSharp.Location loc) : base (default(Mono.CSharp.BuiltinTypes), default(double), default(Mono.CSharp.Location)) { }
    public override bool IsLiteral { get { return default(bool); } }
    public override object Accept(Mono.CSharp.StructuralVisitor visitor) { return default(object); }
    public override void Error_ValueCannotBeConverted(Mono.CSharp.ResolveContext ec, Mono.CSharp.TypeSpec target, bool expl) { }
  }
  public partial class DynamicResultCast : Mono.CSharp.ShimExpression {
    public DynamicResultCast(Mono.CSharp.TypeSpec type, Mono.CSharp.Expression expr) : base (default(Mono.CSharp.Expression)) { }
    protected override Mono.CSharp.Expression DoResolve(Mono.CSharp.ResolveContext ec) { return default(Mono.CSharp.Expression); }
  }
  public partial class ElementAccess : Mono.CSharp.Expression {
    public Mono.CSharp.Arguments Arguments;
    public Mono.CSharp.Expression Expr;
    public ElementAccess(Mono.CSharp.Expression e, Mono.CSharp.Arguments args, Mono.CSharp.Location loc) { }
    public bool ConditionalAccess { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public override Mono.CSharp.Location StartLocation { get { return default(Mono.CSharp.Location); } }
    public override object Accept(Mono.CSharp.StructuralVisitor visitor) { return default(object); }
    protected override void CloneTo(Mono.CSharp.CloneContext clonectx, Mono.CSharp.Expression t) { }
    public override bool ContainsEmitWithAwait() { return default(bool); }
    public override Mono.CSharp.Expression CreateExpressionTree(Mono.CSharp.ResolveContext ec) { return default(Mono.CSharp.Expression); }
    protected override Mono.CSharp.Expression DoResolve(Mono.CSharp.ResolveContext rc) { return default(Mono.CSharp.Expression); }
    public override Mono.CSharp.Expression DoResolveLValue(Mono.CSharp.ResolveContext ec, Mono.CSharp.Expression rhs) { return default(Mono.CSharp.Expression); }
    public override void Emit(Mono.CSharp.EmitContext ec) { }
    public static void Error_CannotApplyIndexing(Mono.CSharp.ResolveContext rc, Mono.CSharp.TypeSpec type, Mono.CSharp.Location loc) { }
    public static void Error_NamedArgument(Mono.CSharp.NamedArgument na, Mono.CSharp.Report Report) { }
    public override void FlowAnalysis(Mono.CSharp.FlowAnalysisContext fc) { }
    public override string GetSignatureForError() { return default(string); }
    public override bool HasConditionalAccess() { return default(bool); }
  }
  public partial class ElementInitializer : Mono.CSharp.Assign {
    public readonly string Name;
    public ElementInitializer(string name, Mono.CSharp.Expression initializer, Mono.CSharp.Location loc) : base (default(Mono.CSharp.Expression), default(Mono.CSharp.Expression), default(Mono.CSharp.Location)) { }
    public bool IsDictionaryInitializer { get { return default(bool); } }
    protected override void CloneTo(Mono.CSharp.CloneContext clonectx, Mono.CSharp.Expression t) { }
    public override Mono.CSharp.Expression CreateExpressionTree(Mono.CSharp.ResolveContext ec) { return default(Mono.CSharp.Expression); }
    protected override Mono.CSharp.Expression DoResolve(Mono.CSharp.ResolveContext ec) { return default(Mono.CSharp.Expression); }
    public override void EmitStatement(Mono.CSharp.EmitContext ec) { }
    protected virtual bool ResolveElement(Mono.CSharp.ResolveContext rc) { return default(bool); }
  }
  public abstract partial class ElementTypeSpec : Mono.CSharp.TypeSpec, Mono.CSharp.IMemberDefinition, Mono.CSharp.ITypeDefinition {
    protected ElementTypeSpec(Mono.CSharp.MemberKind kind, Mono.CSharp.TypeSpec element, System.Type info) : base (default(Mono.CSharp.MemberKind), default(Mono.CSharp.TypeSpec), default(Mono.CSharp.ITypeDefinition), default(System.Type), default(Mono.CSharp.Modifiers)) { }
    public Mono.CSharp.TypeSpec Element { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(Mono.CSharp.TypeSpec); } }
    public bool IsImported { get { return default(bool); } }
    System.Nullable<System.Boolean> Mono.CSharp.IMemberDefinition.CLSAttributeValue { get { return default(System.Nullable<System.Boolean>); } }
    Mono.CSharp.IAssemblyDefinition Mono.CSharp.ITypeDefinition.DeclaringAssembly { get { return default(Mono.CSharp.IAssemblyDefinition); } }
    bool Mono.CSharp.ITypeDefinition.IsComImport { get { return default(bool); } }
    bool Mono.CSharp.ITypeDefinition.IsCyclicTypeForwarder { get { return default(bool); } }
    bool Mono.CSharp.ITypeDefinition.IsPartial { get { return default(bool); } }
    bool Mono.CSharp.ITypeDefinition.IsTypeForwarder { get { return default(bool); } }
    public override string Name { get { return default(string); } }
    public string Namespace { get { return default(string); } }
    public Mono.CSharp.TypeParameterSpec[] TypeParameters { get { return default(Mono.CSharp.TypeParameterSpec[]); } }
    public int TypeParametersCount { get { return default(int); } }
    public System.String[] ConditionalConditions() { return default(System.String[]); }
    public Mono.CSharp.TypeSpec GetAttributeCoClass() { return default(Mono.CSharp.TypeSpec); }
    public string GetAttributeDefaultMember() { return default(string); }
    public override System.ObsoleteAttribute GetAttributeObsolete() { return default(System.ObsoleteAttribute); }
    protected virtual string GetPostfixSignature() { return default(string); }
    public override string GetSignatureForDocumentation() { return default(string); }
    public override string GetSignatureForError() { return default(string); }
    public void LoadMembers(Mono.CSharp.TypeSpec declaringType, bool onlyTypes, ref Mono.CSharp.MemberCache cache) { }
    bool Mono.CSharp.ITypeDefinition.IsInternalAsPublic(Mono.CSharp.IAssemblyDefinition assembly) { return default(bool); }
    public override Mono.CSharp.TypeSpec Mutate(Mono.CSharp.TypeParameterMutator mutator) { return default(Mono.CSharp.TypeSpec); }
    public void SetIsAssigned() { }
    public void SetIsUsed() { }
  }
  public partial class EmitContext : Mono.CSharp.BuilderContext {
    public Mono.CSharp.AnonymousExpression CurrentAnonymousMethod;
    public System.Reflection.Emit.Label DefaultTarget;
    public readonly System.Reflection.Emit.ILGenerator ig;
    public System.Reflection.Emit.Label LoopBegin;
    public System.Reflection.Emit.Label LoopEnd;
    public System.Reflection.Emit.LocalBuilder return_value;
    public Mono.CSharp.Switch Switch;
    public EmitContext(Mono.CSharp.IMemberContext rc, System.Reflection.Emit.ILGenerator ig, Mono.CSharp.TypeSpec return_type, Mono.CompilerServices.SymbolWriter.SourceMethodBuilder methodSymbols) { }
    public Mono.CSharp.LocalVariable AsyncThrowVariable { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(Mono.CSharp.LocalVariable); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public Mono.CSharp.BuiltinTypes BuiltinTypes { get { return default(Mono.CSharp.BuiltinTypes); } }
    public Mono.CSharp.ConditionalAccessContext ConditionalAccess { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(Mono.CSharp.ConditionalAccessContext); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public Mono.CSharp.TypeSpec CurrentType { get { return default(Mono.CSharp.TypeSpec); } }
    public Mono.CSharp.MemberCore CurrentTypeDefinition { get { return default(Mono.CSharp.MemberCore); } }
    public Mono.CSharp.TypeParameters CurrentTypeParameters { get { return default(Mono.CSharp.TypeParameters); } }
    public bool EmitAccurateDebugInfo { get { return default(bool); } }
    public bool HasMethodSymbolBuilder { get { return default(bool); } }
    public bool HasReturnLabel { get { return default(bool); } }
    public bool IsAnonymousStoreyMutateRequired { get { return default(bool); } }
    public bool IsStatic { get { return default(bool); } }
    public bool IsStaticConstructor { get { return default(bool); } }
    public Mono.CSharp.IMemberContext MemberContext { get { return default(Mono.CSharp.IMemberContext); } }
    public Mono.CSharp.ModuleContainer Module { get { return default(Mono.CSharp.ModuleContainer); } }
    public bool NotifyEvaluatorOnStore { get { return default(bool); } }
    public System.Reflection.Emit.Label RecursivePatternLabel { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Reflection.Emit.Label); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public Mono.CSharp.Report Report { get { return default(Mono.CSharp.Report); } }
    public System.Reflection.Emit.Label ReturnLabel { get { return default(System.Reflection.Emit.Label); } }
    public Mono.CSharp.TypeSpec ReturnType { get { return default(Mono.CSharp.TypeSpec); } }
    public System.Collections.Generic.List<Mono.CSharp.IExpressionCleanup> StatementEpilogue { get { return default(System.Collections.Generic.List<Mono.CSharp.IExpressionCleanup>); } }
    public System.Collections.Generic.List<Mono.CSharp.TryFinally> TryFinallyUnwind { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Collections.Generic.List<Mono.CSharp.TryFinally>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public void AddStatementEpilog(Mono.CSharp.IExpressionCleanup cleanupExpression) { }
    public void AssertEmptyStack() { }
    public void BeginCatchBlock(Mono.CSharp.TypeSpec type) { }
    public void BeginCompilerScope() { }
    public void BeginExceptionBlock() { }
    public void BeginExceptionFilterBlock() { }
    public void BeginFilterHandler() { }
    public void BeginFinallyBlock() { }
    public void BeginScope() { }
    public void CloseConditionalAccess(Mono.CSharp.TypeSpec type) { }
    public System.Reflection.Emit.Label CreateReturnLabel() { return default(System.Reflection.Emit.Label); }
    public System.Reflection.Emit.LocalBuilder DeclareLocal(Mono.CSharp.TypeSpec type, bool pinned) { return default(System.Reflection.Emit.LocalBuilder); }
    public System.Reflection.Emit.Label DefineLabel() { return default(System.Reflection.Emit.Label); }
    public void DefineLocalVariable(string name, System.Reflection.Emit.LocalBuilder builder) { }
    public void Emit(System.Reflection.Emit.OpCode opcode) { }
    public void Emit(System.Reflection.Emit.OpCode opcode, Mono.CSharp.FieldSpec field) { }
    public void Emit(System.Reflection.Emit.OpCode opcode, Mono.CSharp.MethodSpec method) { }
    public void Emit(System.Reflection.Emit.OpCode opcode, Mono.CSharp.MethodSpec method, System.Type[] vargs) { }
    public void Emit(System.Reflection.Emit.OpCode opcode, Mono.CSharp.TypeSpec type) { }
    public void Emit(System.Reflection.Emit.OpCode opcode, double arg) { }
    public void Emit(System.Reflection.Emit.OpCode opcode, System.Reflection.Emit.Label label) { }
    public void Emit(System.Reflection.Emit.OpCode opcode, System.Reflection.Emit.Label[] labels) { }
    public void Emit(System.Reflection.Emit.OpCode opcode, System.Reflection.Emit.LocalBuilder local) { }
    public void Emit(System.Reflection.Emit.OpCode opcode, System.Reflection.MethodInfo method) { }
    public void Emit(System.Reflection.Emit.OpCode opcode, float arg) { }
    public void Emit(System.Reflection.Emit.OpCode opcode, string arg) { }
    public void EmitArgumentAddress(int pos) { }
    public void EmitArgumentLoad(int pos) { }
    public void EmitArgumentStore(int pos) { }
    public void EmitArrayAddress(Mono.CSharp.ArrayContainer ac) { }
    public void EmitArrayLoad(Mono.CSharp.ArrayContainer ac) { }
    public void EmitArrayNew(Mono.CSharp.ArrayContainer ac) { }
    public void EmitArrayStore(Mono.CSharp.ArrayContainer ac) { }
    public void EmitEpilogue() { }
    public void EmitInt(int i) { }
    public void EmitLoadFromPtr(Mono.CSharp.TypeSpec type) { }
    public void EmitLong(long l) { }
    public void EmitNull() { }
    public void EmitStoreFromPtr(Mono.CSharp.TypeSpec type) { }
    public void EmitThis() { }
    public void EndExceptionBlock() { }
    public void EndScope() { }
    public void FreeTemporaryLocal(System.Reflection.Emit.LocalBuilder b, Mono.CSharp.TypeSpec t) { }
    public Mono.CSharp.StackFieldExpr GetTemporaryField(Mono.CSharp.TypeSpec type, bool initializedFieldRequired=false) { return default(Mono.CSharp.StackFieldExpr); }
    public System.Reflection.Emit.LocalBuilder GetTemporaryLocal(Mono.CSharp.TypeSpec t) { return default(System.Reflection.Emit.LocalBuilder); }
    public bool Mark(Mono.CSharp.Location loc) { return default(bool); }
    public void MarkCallEntry(Mono.CSharp.Location loc) { }
    public void MarkLabel(System.Reflection.Emit.Label label) { }
    public System.Reflection.Emit.LocalBuilder TemporaryReturn() { return default(System.Reflection.Emit.LocalBuilder); }
  }
  public partial class EmptyCast : Mono.CSharp.TypeCast {
    internal EmptyCast() : base (default(Mono.CSharp.Expression), default(Mono.CSharp.TypeSpec)) { }
    public static Mono.CSharp.Expression Create(Mono.CSharp.Expression child, Mono.CSharp.TypeSpec type) { return default(Mono.CSharp.Expression); }
    public override void EmitBranchable(Mono.CSharp.EmitContext ec, System.Reflection.Emit.Label label, bool on_true) { }
    public override void EmitSideEffect(Mono.CSharp.EmitContext ec) { }
  }
  public partial class EmptyCompletion : Mono.CSharp.CompletingExpression {
    public EmptyCompletion() { }
    protected override void CloneTo(Mono.CSharp.CloneContext clonectx, Mono.CSharp.Expression target) { }
    protected override Mono.CSharp.Expression DoResolve(Mono.CSharp.ResolveContext rc) { return default(Mono.CSharp.Expression); }
  }
  public partial class EmptyConstantCast : Mono.CSharp.Constant {
    public readonly Mono.CSharp.Constant child;
    public EmptyConstantCast(Mono.CSharp.Constant child, Mono.CSharp.TypeSpec type) : base (default(Mono.CSharp.Location)) { }
    public override bool IsDefaultValue { get { return default(bool); } }
    public override bool IsNegative { get { return default(bool); } }
    public override bool IsNull { get { return default(bool); } }
    public override bool IsOneInteger { get { return default(bool); } }
    public override bool IsSideEffectFree { get { return default(bool); } }
    public override bool IsZeroInteger { get { return default(bool); } }
    public override Mono.CSharp.Constant ConvertExplicitly(bool in_checked_context, Mono.CSharp.TypeSpec target_type) { return default(Mono.CSharp.Constant); }
    public override Mono.CSharp.Constant ConvertImplicitly(Mono.CSharp.TypeSpec target_type) { return default(Mono.CSharp.Constant); }
    public override Mono.CSharp.Expression CreateExpressionTree(Mono.CSharp.ResolveContext ec) { return default(Mono.CSharp.Expression); }
    public override void Emit(Mono.CSharp.EmitContext ec) { }
    public override void EmitBranchable(Mono.CSharp.EmitContext ec, System.Reflection.Emit.Label label, bool on_true) { }
    public override void EmitSideEffect(Mono.CSharp.EmitContext ec) { }
    public override object GetValue() { return default(object); }
    public override string GetValueAsLiteral() { return default(string); }
    public override long GetValueAsLong() { return default(long); }
  }
  public partial class EmptyExpression : Mono.CSharp.Expression {
    public static readonly Mono.CSharp.EmptyExpression EventAddition;
    public static readonly Mono.CSharp.EmptyExpression EventSubtraction;
    public static readonly Mono.CSharp.EmptyExpression LValueMemberAccess;
    public static readonly Mono.CSharp.EmptyExpression LValueMemberOutAccess;
    public static readonly Mono.CSharp.EmptyExpression MissingValue;
    public static readonly Mono.CSharp.Expression Null;
    public static readonly Mono.CSharp.EmptyExpression OutAccess;
    public static readonly Mono.CSharp.EmptyExpression UnaryAddress;
    public EmptyExpression(Mono.CSharp.TypeSpec t) { }
    public override object Accept(Mono.CSharp.StructuralVisitor visitor) { return default(object); }
    protected override void CloneTo(Mono.CSharp.CloneContext clonectx, Mono.CSharp.Expression target) { }
    public override bool ContainsEmitWithAwait() { return default(bool); }
    public override Mono.CSharp.Expression CreateExpressionTree(Mono.CSharp.ResolveContext ec) { return default(Mono.CSharp.Expression); }
    protected override Mono.CSharp.Expression DoResolve(Mono.CSharp.ResolveContext ec) { return default(Mono.CSharp.Expression); }
    public override void Emit(Mono.CSharp.EmitContext ec) { }
    public override void EmitBranchable(Mono.CSharp.EmitContext ec, System.Reflection.Emit.Label target, bool on_true) { }
    public override void EmitSideEffect(Mono.CSharp.EmitContext ec) { }
  }
  public sealed partial class EmptyExpressionStatement : Mono.CSharp.ExpressionStatement {
    internal EmptyExpressionStatement() { }
    public static readonly Mono.CSharp.EmptyExpressionStatement Instance;
    public override object Accept(Mono.CSharp.StructuralVisitor visitor) { return default(object); }
    public override bool ContainsEmitWithAwait() { return default(bool); }
    public override Mono.CSharp.Expression CreateExpressionTree(Mono.CSharp.ResolveContext ec) { return default(Mono.CSharp.Expression); }
    protected override Mono.CSharp.Expression DoResolve(Mono.CSharp.ResolveContext ec) { return default(Mono.CSharp.Expression); }
    public override void Emit(Mono.CSharp.EmitContext ec) { }
    public override void EmitStatement(Mono.CSharp.EmitContext ec) { }
  }
  public sealed partial class EmptyStatement : Mono.CSharp.Statement {
    public EmptyStatement(Mono.CSharp.Location loc) { }
    public override object Accept(Mono.CSharp.StructuralVisitor visitor) { return default(object); }
    protected override void CloneTo(Mono.CSharp.CloneContext clonectx, Mono.CSharp.Statement target) { }
    protected override void DoEmit(Mono.CSharp.EmitContext ec) { }
    protected override bool DoFlowAnalysis(Mono.CSharp.FlowAnalysisContext fc) { return default(bool); }
    public override void Emit(Mono.CSharp.EmitContext ec) { }
    public override bool Resolve(Mono.CSharp.BlockContext ec) { return default(bool); }
  }
  public partial class Enum : Mono.CSharp.TypeDefinition {
    public static readonly string UnderlyingValueField;
    public Enum(Mono.CSharp.TypeContainer parent, Mono.CSharp.FullNamedExpression type, Mono.CSharp.Modifiers mod_flags, Mono.CSharp.MemberName name, Mono.CSharp.Attributes attrs) : base (default(Mono.CSharp.TypeContainer), default(Mono.CSharp.MemberName), default(Mono.CSharp.Attributes), default(Mono.CSharp.MemberKind)) { }
    public override System.AttributeTargets AttributeTargets { get { return default(System.AttributeTargets); } }
    public Mono.CSharp.FullNamedExpression BaseTypeExpression { get { return default(Mono.CSharp.FullNamedExpression); } }
    protected override System.Reflection.TypeAttributes TypeAttr { get { return default(System.Reflection.TypeAttributes); } }
    public Mono.CSharp.TypeSpec UnderlyingType { get { return default(Mono.CSharp.TypeSpec); } }
    public override void Accept(Mono.CSharp.StructuralVisitor visitor) { }
    public void AddEnumMember(Mono.CSharp.EnumMember em) { }
    protected override void DoDefineContainer() { }
    protected override bool DoDefineMembers() { return default(bool); }
    public void Error_UnderlyingType(Mono.CSharp.Location loc) { }
    public override bool IsUnmanagedType() { return default(bool); }
    protected override Mono.CSharp.TypeSpec[] ResolveBaseTypes(out Mono.CSharp.FullNamedExpression base_class) { base_class = default(Mono.CSharp.FullNamedExpression); return default(Mono.CSharp.TypeSpec[]); }
    protected override bool VerifyClsCompliance() { return default(bool); }
  }
  public partial class EnumConstant : Mono.CSharp.Constant {
    public Mono.CSharp.Constant Child;
    public EnumConstant(Mono.CSharp.Constant child, Mono.CSharp.TypeSpec enum_type) : base (default(Mono.CSharp.Location)) { }
    protected EnumConstant(Mono.CSharp.Location loc) : base (default(Mono.CSharp.Location)) { }
    public override bool IsDefaultValue { get { return default(bool); } }
    public override bool IsNegative { get { return default(bool); } }
    public override bool IsSideEffectFree { get { return default(bool); } }
    public override bool IsZeroInteger { get { return default(bool); } }
    public override Mono.CSharp.Constant ConvertExplicitly(bool in_checked_context, Mono.CSharp.TypeSpec target_type) { return default(Mono.CSharp.Constant); }
    public override Mono.CSharp.Constant ConvertImplicitly(Mono.CSharp.TypeSpec type) { return default(Mono.CSharp.Constant); }
    public override void Emit(Mono.CSharp.EmitContext ec) { }
    public override void EmitBranchable(Mono.CSharp.EmitContext ec, System.Reflection.Emit.Label label, bool on_true) { }
    public override void EmitSideEffect(Mono.CSharp.EmitContext ec) { }
    public override void EncodeAttributeValue(Mono.CSharp.IMemberContext rc, Mono.CSharp.AttributeEncoder enc, Mono.CSharp.TypeSpec targetType, Mono.CSharp.TypeSpec parameterType) { }
    public override string GetSignatureForError() { return default(string); }
    public override object GetTypedValue() { return default(object); }
    public override object GetValue() { return default(object); }
    public override string GetValueAsLiteral() { return default(string); }
    public override long GetValueAsLong() { return default(long); }
    public Mono.CSharp.EnumConstant Increment() { return default(Mono.CSharp.EnumConstant); }
  }
  public partial class EnumMember : Mono.CSharp.Const {
    public EnumMember(Mono.CSharp.Enum parent, Mono.CSharp.MemberName name, Mono.CSharp.Attributes attrs) : base (default(Mono.CSharp.TypeDefinition), default(Mono.CSharp.FullNamedExpression), default(Mono.CSharp.Modifiers), default(Mono.CSharp.MemberName), default(Mono.CSharp.Attributes)) { }
    public override void Accept(Mono.CSharp.StructuralVisitor visitor) { }
    public override Mono.CSharp.Constant ConvertInitializer(Mono.CSharp.ResolveContext rc, Mono.CSharp.Constant expr) { return default(Mono.CSharp.Constant); }
    public override bool Define() { return default(bool); }
  }
  public partial class ErrorExpression : Mono.CSharp.EmptyExpression {
    internal ErrorExpression() : base (default(Mono.CSharp.TypeSpec)) { }
    public static readonly Mono.CSharp.ErrorExpression Instance;
    public override object Accept(Mono.CSharp.StructuralVisitor visitor) { return default(object); }
    public override Mono.CSharp.Expression CreateExpressionTree(Mono.CSharp.ResolveContext ec) { return default(Mono.CSharp.Expression); }
    public override Mono.CSharp.Expression DoResolveLValue(Mono.CSharp.ResolveContext rc, Mono.CSharp.Expression right_side) { return default(Mono.CSharp.Expression); }
    public override void Error_OperatorCannotBeApplied(Mono.CSharp.ResolveContext rc, Mono.CSharp.Location loc, string oper, Mono.CSharp.TypeSpec t) { }
    public override void Error_UnexpectedKind(Mono.CSharp.ResolveContext ec, Mono.CSharp.ResolveFlags flags, Mono.CSharp.Location loc) { }
    public override void Error_ValueAssignment(Mono.CSharp.ResolveContext rc, Mono.CSharp.Expression rhs) { }
    public override void Error_ValueCannotBeConverted(Mono.CSharp.ResolveContext ec, Mono.CSharp.TypeSpec target, bool expl) { }
  }
  public partial class Evaluator {
    public bool DescribeTypeExpressions;
    public bool Terse;
    public Evaluator(Mono.CSharp.CompilerContext ctx) { }
    public System.Type InteractiveBaseClass { get { return default(System.Type); } set { } }
    public Mono.CSharp.ValueModificationHandler ModificationListener { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(Mono.CSharp.ValueModificationHandler); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public bool WaitOnTask { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public Mono.CSharp.CompiledMethod Compile(string input) { return default(Mono.CSharp.CompiledMethod); }
    public string Compile(string input, out Mono.CSharp.CompiledMethod compiled) { compiled = default(Mono.CSharp.CompiledMethod); return default(string); }
    public object Evaluate(string input) { return default(object); }
    public string Evaluate(string input, out object result, out bool result_set) { result = default(object); result_set = default(bool); return default(string); }
    public System.String[] GetCompletions(string input, out string prefix) { prefix = default(string); return default(System.String[]); }
    public string GetUsing() { return default(string); }
    public string GetVars() { return default(string); }
    public void Interrupt() { }
    public void LoadAssembly(string file) { }
    public void ReferenceAssembly(System.Reflection.Assembly a) { }
    public bool Run(string statement) { return default(bool); }
  }
  public abstract partial class Event : Mono.CSharp.PropertyBasedMember {
    protected Mono.CSharp.EventSpec spec;
    protected Event(Mono.CSharp.TypeDefinition parent, Mono.CSharp.FullNamedExpression type, Mono.CSharp.Modifiers mod_flags, Mono.CSharp.MemberName name, Mono.CSharp.Attributes attrs) : base (default(Mono.CSharp.TypeDefinition), default(Mono.CSharp.FullNamedExpression), default(Mono.CSharp.Modifiers), default(Mono.CSharp.Modifiers), default(Mono.CSharp.MemberName), default(Mono.CSharp.Attributes)) { }
    public Mono.CSharp.Event.AEventAccessor Add { get { return default(Mono.CSharp.Event.AEventAccessor); } set { } }
    public override System.AttributeTargets AttributeTargets { get { return default(System.AttributeTargets); } }
    public override string DocCommentHeader { get { return default(string); } }
    public override Mono.CSharp.Variance ExpectedMemberTypeVariance { get { return default(Mono.CSharp.Variance); } }
    public Mono.CSharp.Event.AEventAccessor Remove { get { return default(Mono.CSharp.Event.AEventAccessor); } set { } }
    public override void ApplyAttributeBuilder(Mono.CSharp.Attribute a, Mono.CSharp.MethodSpec ctor, System.Byte[] cdata, Mono.CSharp.PredefinedAttributes pa) { }
    protected override bool CheckOverrideAgainstBase(Mono.CSharp.MemberSpec base_member) { return default(bool); }
    public override bool Define() { return default(bool); }
    public override void Emit() { }
    public override void PrepareEmit() { }
    public override void WriteDebugSymbol(Mono.CompilerServices.SymbolWriter.MonoSymbolFile file) { }
    public abstract partial class AEventAccessor : Mono.CSharp.AbstractPropertyEventMethod {
      public const string AddPrefix = "add_";
      protected readonly Mono.CSharp.Event method;
      public const string RemovePrefix = "remove_";
      protected AEventAccessor(Mono.CSharp.Event method, string prefix, Mono.CSharp.Attributes attrs, Mono.CSharp.Location loc) : base (default(Mono.CSharp.InterfaceMemberBase), default(string), default(Mono.CSharp.Attributes), default(Mono.CSharp.Location)) { }
      public override System.AttributeTargets AttributeTargets { get { return default(System.AttributeTargets); } }
      public bool IsInterfaceImplementation { get { return default(bool); } }
      public Mono.CSharp.MethodData MethodData { get { return default(Mono.CSharp.MethodData); } }
      public override Mono.CSharp.ParametersCompiled ParameterInfo { get { return default(Mono.CSharp.ParametersCompiled); } }
      public override Mono.CSharp.TypeSpec ReturnType { get { return default(Mono.CSharp.TypeSpec); } }
      public override System.String[] ValidAttributeTargets { get { return default(System.String[]); } }
      public override void ApplyAttributeBuilder(Mono.CSharp.Attribute a, Mono.CSharp.MethodSpec ctor, System.Byte[] cdata, Mono.CSharp.PredefinedAttributes pa) { }
      protected override void ApplyToExtraTarget(Mono.CSharp.Attribute a, Mono.CSharp.MethodSpec ctor, System.Byte[] cdata, Mono.CSharp.PredefinedAttributes pa) { }
      public virtual void Define(Mono.CSharp.TypeContainer parent) { }
      public override System.ObsoleteAttribute GetAttributeObsolete() { return default(System.ObsoleteAttribute); }
      public override bool IsClsComplianceRequired() { return default(bool); }
    }
  }
  public partial class EventExpr : Mono.CSharp.MemberExpr, Mono.CSharp.IAssignMethod {
    public EventExpr(Mono.CSharp.EventSpec spec, Mono.CSharp.Location loc) { }
    protected override Mono.CSharp.TypeSpec DeclaringType { get { return default(Mono.CSharp.TypeSpec); } }
    public override bool IsInstance { get { return default(bool); } }
    public override bool IsStatic { get { return default(bool); } }
    public override string KindName { get { return default(string); } }
    public override string Name { get { return default(string); } }
    public Mono.CSharp.MethodSpec Operator { get { return default(Mono.CSharp.MethodSpec); } }
    public override Mono.CSharp.Expression CreateExpressionTree(Mono.CSharp.ResolveContext ec) { return default(Mono.CSharp.Expression); }
    protected override Mono.CSharp.Expression DoResolve(Mono.CSharp.ResolveContext ec) { return default(Mono.CSharp.Expression); }
    public override Mono.CSharp.Expression DoResolveLValue(Mono.CSharp.ResolveContext ec, Mono.CSharp.Expression right_side) { return default(Mono.CSharp.Expression); }
    public override void Emit(Mono.CSharp.EmitContext ec) { }
    public void Emit(Mono.CSharp.EmitContext ec, bool leave_copy) { }
    public void EmitAssign(Mono.CSharp.EmitContext ec, Mono.CSharp.Expression source, bool leave_copy, bool isCompound) { }
    protected override void Error_CannotCallAbstractBase(Mono.CSharp.ResolveContext rc, string name) { }
    public override string GetSignatureForError() { return default(string); }
    public override Mono.CSharp.MemberExpr ResolveMemberAccess(Mono.CSharp.ResolveContext ec, Mono.CSharp.Expression left, Mono.CSharp.SimpleName original) { return default(Mono.CSharp.MemberExpr); }
    public override void SetTypeArguments(Mono.CSharp.ResolveContext ec, Mono.CSharp.TypeArguments ta) { }
  }
  public partial class EventField : Mono.CSharp.Event {
    public EventField(Mono.CSharp.TypeDefinition parent, Mono.CSharp.FullNamedExpression type, Mono.CSharp.Modifiers mod_flags, Mono.CSharp.MemberName name, Mono.CSharp.Attributes attrs) : base (default(Mono.CSharp.TypeDefinition), default(Mono.CSharp.FullNamedExpression), default(Mono.CSharp.Modifiers), default(Mono.CSharp.MemberName), default(Mono.CSharp.Attributes)) { }
    public System.Collections.Generic.List<Mono.CSharp.FieldDeclarator> Declarators { get { return default(System.Collections.Generic.List<Mono.CSharp.FieldDeclarator>); } }
    public Mono.CSharp.Expression Initializer { get { return default(Mono.CSharp.Expression); } set { } }
    public override System.String[] ValidAttributeTargets { get { return default(System.String[]); } }
    public override void Accept(Mono.CSharp.StructuralVisitor visitor) { }
    public void AddDeclarator(Mono.CSharp.FieldDeclarator declarator) { }
    public override void ApplyAttributeBuilder(Mono.CSharp.Attribute a, Mono.CSharp.MethodSpec ctor, System.Byte[] cdata, Mono.CSharp.PredefinedAttributes pa) { }
    public override bool Define() { return default(bool); }
  }
  public partial class EventProperty : Mono.CSharp.Event {
    public EventProperty(Mono.CSharp.TypeDefinition parent, Mono.CSharp.FullNamedExpression type, Mono.CSharp.Modifiers mod_flags, Mono.CSharp.MemberName name, Mono.CSharp.Attributes attrs) : base (default(Mono.CSharp.TypeDefinition), default(Mono.CSharp.FullNamedExpression), default(Mono.CSharp.Modifiers), default(Mono.CSharp.MemberName), default(Mono.CSharp.Attributes)) { }
    public override System.String[] ValidAttributeTargets { get { return default(System.String[]); } }
    public override void Accept(Mono.CSharp.StructuralVisitor visitor) { }
    public override bool Define() { return default(bool); }
    public sealed partial class AddDelegateMethod : Mono.CSharp.EventProperty.AEventPropertyAccessor {
      public AddDelegateMethod(Mono.CSharp.EventProperty method, Mono.CSharp.Attributes attrs, Mono.CSharp.Location loc) : base (default(Mono.CSharp.EventProperty), default(string), default(Mono.CSharp.Attributes), default(Mono.CSharp.Location)) { }
    }
    public abstract partial class AEventPropertyAccessor : Mono.CSharp.Event.AEventAccessor {
      protected AEventPropertyAccessor(Mono.CSharp.EventProperty method, string prefix, Mono.CSharp.Attributes attrs, Mono.CSharp.Location loc) : base (default(Mono.CSharp.Event), default(string), default(Mono.CSharp.Attributes), default(Mono.CSharp.Location)) { }
      public override void Define(Mono.CSharp.TypeContainer ds) { }
      public override string GetSignatureForError() { return default(string); }
    }
    public sealed partial class RemoveDelegateMethod : Mono.CSharp.EventProperty.AEventPropertyAccessor {
      public RemoveDelegateMethod(Mono.CSharp.EventProperty method, Mono.CSharp.Attributes attrs, Mono.CSharp.Location loc) : base (default(Mono.CSharp.EventProperty), default(string), default(Mono.CSharp.Attributes), default(Mono.CSharp.Location)) { }
    }
  }
  public partial class EventSpec : Mono.CSharp.MemberSpec, Mono.CSharp.IInterfaceMemberSpec {
    public EventSpec(Mono.CSharp.TypeSpec declaringType, Mono.CSharp.IMemberDefinition definition, Mono.CSharp.TypeSpec eventType, Mono.CSharp.Modifiers modifiers, Mono.CSharp.MethodSpec add, Mono.CSharp.MethodSpec remove) : base (default(Mono.CSharp.MemberKind), default(Mono.CSharp.TypeSpec), default(Mono.CSharp.IMemberDefinition), default(Mono.CSharp.Modifiers)) { }
    public Mono.CSharp.MethodSpec AccessorAdd { get { return default(Mono.CSharp.MethodSpec); } set { } }
    public Mono.CSharp.MethodSpec AccessorRemove { get { return default(Mono.CSharp.MethodSpec); } set { } }
    public Mono.CSharp.FieldSpec BackingField { get { return default(Mono.CSharp.FieldSpec); } set { } }
    public Mono.CSharp.TypeSpec MemberType { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(Mono.CSharp.TypeSpec); } }
    public override Mono.CSharp.MemberSpec InflateMember(Mono.CSharp.TypeParameterInflator inflator) { return default(Mono.CSharp.MemberSpec); }
    public override System.Collections.Generic.List<Mono.CSharp.MissingTypeSpecReference> ResolveMissingDependencies(Mono.CSharp.MemberSpec caller) { return default(System.Collections.Generic.List<Mono.CSharp.MissingTypeSpecReference>); }
  }
  public abstract partial class ExceptionStatement : Mono.CSharp.ResumableStatement {
    protected int first_resume_pc;
    protected Mono.CSharp.ExceptionStatement parent;
    protected System.Collections.Generic.List<Mono.CSharp.ResumableStatement> resume_points;
    protected ExceptionStatement(Mono.CSharp.Location loc) { }
    public virtual int AddResumePoint(Mono.CSharp.ResumableStatement stmt, int pc, Mono.CSharp.StateMachineInitializer stateMachine) { return default(int); }
    protected virtual void EmitTryBodyPrepare(Mono.CSharp.EmitContext ec) { }
  }
  public abstract partial class ExitStatement : Mono.CSharp.Statement {
    protected bool unwind_protect;
    protected ExitStatement() { }
    protected abstract bool IsLocalExit { get; }
    protected override bool DoFlowAnalysis(Mono.CSharp.FlowAnalysisContext fc) { return default(bool); }
    protected abstract bool DoResolve(Mono.CSharp.BlockContext bc);
    public override bool Resolve(Mono.CSharp.BlockContext bc) { return default(bool); }
  }
  public partial class ExplicitBlock : Mono.CSharp.Block {
    protected Mono.CSharp.AnonymousMethodStorey am_storey;
    public ExplicitBlock(Mono.CSharp.Block parent, Mono.CSharp.Block.Flags flags, Mono.CSharp.Location start, Mono.CSharp.Location end) : base (default(Mono.CSharp.Block), default(Mono.CSharp.Location), default(Mono.CSharp.Location)) { }
    public ExplicitBlock(Mono.CSharp.Block parent, Mono.CSharp.Location start, Mono.CSharp.Location end) : base (default(Mono.CSharp.Block), default(Mono.CSharp.Location), default(Mono.CSharp.Location)) { }
    public Mono.CSharp.AnonymousMethodStorey AnonymousMethodStorey { get { return default(Mono.CSharp.AnonymousMethodStorey); } }
    public bool HasAwait { get { return default(bool); } }
    public bool HasCapturedThis { get { return default(bool); } set { } }
    public bool HasCapturedVariable { get { return default(bool); } set { } }
    public bool HasReachableClosingBrace { get { return default(bool); } set { } }
    public bool HasYield { get { return default(bool); } }
    public Mono.CSharp.AnonymousMethodStorey CreateAnonymousMethodStorey(Mono.CSharp.ResolveContext ec) { return default(Mono.CSharp.AnonymousMethodStorey); }
    protected void DefineStoreyContainer(Mono.CSharp.EmitContext ec, Mono.CSharp.AnonymousMethodStorey storey) { }
    public override void Emit(Mono.CSharp.EmitContext ec) { }
    public void EmitScopeInitialization(Mono.CSharp.EmitContext ec) { }
    public void RegisterAsyncAwait() { }
    public void RegisterIteratorYield() { }
    public void SetCatchBlock() { }
    public void SetFinallyBlock() { }
    public void WrapIntoDestructor(Mono.CSharp.TryFinally tf, Mono.CSharp.ExplicitBlock tryBlock) { }
  }
  public enum ExprClass : byte {
    EventAccess = (byte)8,
    IndexerAccess = (byte)9,
    MethodGroup = (byte)6,
    Namespace = (byte)3,
    Nothing = (byte)10,
    PropertyAccess = (byte)7,
    Type = (byte)4,
    TypeParameter = (byte)5,
    Unresolved = (byte)0,
    Value = (byte)1,
    Variable = (byte)2,
  }
  public abstract partial class Expression {
    public Mono.CSharp.ExprClass eclass;
    protected Mono.CSharp.Location loc;
    protected Mono.CSharp.TypeSpec type;
    protected Expression() { }
    public virtual string ExprClassName { get { return default(string); } }
    public Mono.CSharp.ResolveFlags ExprClassToResolveFlags { get { return default(Mono.CSharp.ResolveFlags); } }
    public virtual bool IsNull { get { return default(bool); } }
    public virtual bool IsSideEffectFree { get { return default(bool); } }
    public Mono.CSharp.Location Location { get { return default(Mono.CSharp.Location); } }
    public virtual Mono.CSharp.Location StartLocation { get { return default(Mono.CSharp.Location); } }
    public Mono.CSharp.TypeSpec Type { get { return default(Mono.CSharp.TypeSpec); } set { } }
    public virtual object Accept(Mono.CSharp.StructuralVisitor visitor) { return default(object); }
    public virtual Mono.CSharp.MethodGroupExpr CanReduceLambda(Mono.CSharp.AnonymousMethodBody body) { return default(Mono.CSharp.MethodGroupExpr); }
    public virtual Mono.CSharp.Expression Clone(Mono.CSharp.CloneContext clonectx) { return default(Mono.CSharp.Expression); }
    protected virtual void CloneTo(Mono.CSharp.CloneContext clonectx, Mono.CSharp.Expression target) { }
    public static Mono.CSharp.MethodSpec ConstructorLookup(Mono.CSharp.ResolveContext rc, Mono.CSharp.TypeSpec type, ref Mono.CSharp.Arguments args, Mono.CSharp.Location loc) { return default(Mono.CSharp.MethodSpec); }
    public virtual bool ContainsEmitWithAwait() { return default(bool); }
    protected Mono.CSharp.Expression ConvertExpressionToArrayIndex(Mono.CSharp.ResolveContext ec, Mono.CSharp.Expression source, bool pointerArray=false) { return default(Mono.CSharp.Expression); }
    protected Mono.CSharp.Expression CreateExpressionFactoryCall(Mono.CSharp.ResolveContext ec, string name, Mono.CSharp.Arguments args) { return default(Mono.CSharp.Expression); }
    protected Mono.CSharp.Expression CreateExpressionFactoryCall(Mono.CSharp.ResolveContext ec, string name, Mono.CSharp.TypeArguments typeArguments, Mono.CSharp.Arguments args) { return default(Mono.CSharp.Expression); }
    public static Mono.CSharp.Expression CreateExpressionFactoryCall(Mono.CSharp.ResolveContext ec, string name, Mono.CSharp.TypeArguments typeArguments, Mono.CSharp.Arguments args, Mono.CSharp.Location loc) { return default(Mono.CSharp.Expression); }
    public abstract Mono.CSharp.Expression CreateExpressionTree(Mono.CSharp.ResolveContext ec);
    protected static Mono.CSharp.TypeExpr CreateExpressionTypeExpression(Mono.CSharp.ResolveContext ec, Mono.CSharp.Location loc) { return default(Mono.CSharp.TypeExpr); }
    protected abstract Mono.CSharp.Expression DoResolve(Mono.CSharp.ResolveContext rc);
    public virtual Mono.CSharp.Expression DoResolveLValue(Mono.CSharp.ResolveContext rc, Mono.CSharp.Expression right_side) { return default(Mono.CSharp.Expression); }
    public abstract void Emit(Mono.CSharp.EmitContext ec);
    public virtual void EmitBranchable(Mono.CSharp.EmitContext ec, System.Reflection.Emit.Label target, bool on_true) { }
    protected static void EmitExpressionsList(Mono.CSharp.EmitContext ec, System.Collections.Generic.List<Mono.CSharp.Expression> expressions) { }
    public virtual void EmitSideEffect(Mono.CSharp.EmitContext ec) { }
    public virtual Mono.CSharp.Expression EmitToField(Mono.CSharp.EmitContext ec) { return default(Mono.CSharp.Expression); }
    protected virtual Mono.CSharp.FieldExpr EmitToFieldSource(Mono.CSharp.EmitContext ec) { return default(Mono.CSharp.FieldExpr); }
    public virtual void EncodeAttributeValue(Mono.CSharp.IMemberContext rc, Mono.CSharp.AttributeEncoder enc, Mono.CSharp.TypeSpec targetType, Mono.CSharp.TypeSpec parameterType) { }
    public void Error_ConstantCanBeInitializedWithNullOnly(Mono.CSharp.ResolveContext rc, Mono.CSharp.TypeSpec type, Mono.CSharp.Location loc, string name) { }
    public void Error_ExpressionMustBeConstant(Mono.CSharp.ResolveContext rc, Mono.CSharp.Location loc, string e_name) { }
    public void Error_InvalidExpressionStatement(Mono.CSharp.BlockContext bc) { }
    public void Error_InvalidExpressionStatement(Mono.CSharp.Report report) { }
    protected virtual void Error_InvalidExpressionStatement(Mono.CSharp.Report report, Mono.CSharp.Location loc) { }
    protected virtual void Error_NegativeArrayIndex(Mono.CSharp.ResolveContext ec, Mono.CSharp.Location loc) { }
    protected void Error_NullShortCircuitInsideExpressionTree(Mono.CSharp.ResolveContext rc) { }
    public virtual void Error_OperatorCannotBeApplied(Mono.CSharp.ResolveContext rc, Mono.CSharp.Location loc, string oper, Mono.CSharp.TypeSpec t) { }
    protected void Error_PointerInsideExpressionTree(Mono.CSharp.ResolveContext ec) { }
    public void Error_TypeArgumentsCannotBeUsed(Mono.CSharp.IMemberContext context, Mono.CSharp.MemberSpec member, Mono.CSharp.Location loc) { }
    public static void Error_TypeArgumentsCannotBeUsed(Mono.CSharp.IMemberContext context, string exprType, string name, Mono.CSharp.Location loc) { }
    public static void Error_TypeDoesNotContainDefinition(Mono.CSharp.ResolveContext ec, Mono.CSharp.Location loc, Mono.CSharp.TypeSpec type, string name) { }
    protected virtual void Error_TypeDoesNotContainDefinition(Mono.CSharp.ResolveContext ec, Mono.CSharp.TypeSpec type, string name) { }
    public static void Error_UnexpectedKind(Mono.CSharp.IMemberContext ctx, Mono.CSharp.Expression memberExpr, string expected, string was, Mono.CSharp.Location loc) { }
    public virtual void Error_UnexpectedKind(Mono.CSharp.ResolveContext ec, Mono.CSharp.ResolveFlags flags, Mono.CSharp.Location loc) { }
    public virtual void Error_ValueAssignment(Mono.CSharp.ResolveContext rc, Mono.CSharp.Expression rhs) { }
    public virtual void Error_ValueCannotBeConverted(Mono.CSharp.ResolveContext ec, Mono.CSharp.TypeSpec target, bool expl) { }
    protected void Error_ValueCannotBeConvertedCore(Mono.CSharp.ResolveContext ec, Mono.CSharp.Location loc, Mono.CSharp.TypeSpec target, bool expl) { }
    public static void Error_VoidInvalidInTheContext(Mono.CSharp.Location loc, Mono.CSharp.Report Report) { }
    protected void Error_VoidPointerOperation(Mono.CSharp.ResolveContext rc) { }
    public static void ErrorIsInaccesible(Mono.CSharp.IMemberContext rc, string member, Mono.CSharp.Location loc) { }
    public virtual void FlowAnalysis(Mono.CSharp.FlowAnalysisContext fc) { }
    public virtual void FlowAnalysisConditional(Mono.CSharp.FlowAnalysisContext fc) { }
    protected static Mono.CSharp.Expression GetOperatorFalse(Mono.CSharp.ResolveContext ec, Mono.CSharp.Expression e, Mono.CSharp.Location loc) { return default(Mono.CSharp.Expression); }
    protected static Mono.CSharp.Expression GetOperatorTrue(Mono.CSharp.ResolveContext ec, Mono.CSharp.Expression e, Mono.CSharp.Location loc) { return default(Mono.CSharp.Expression); }
    public virtual string GetSignatureForError() { return default(string); }
    public virtual bool HasConditionalAccess() { return default(bool); }
    public static bool IsNeverNull(Mono.CSharp.Expression expr) { return default(bool); }
    protected static bool IsNullPropagatingValid(Mono.CSharp.TypeSpec type) { return default(bool); }
    protected static Mono.CSharp.TypeSpec LiftMemberType(Mono.CSharp.ResolveContext rc, Mono.CSharp.TypeSpec type) { return default(Mono.CSharp.TypeSpec); }
    public virtual System.Linq.Expressions.Expression MakeExpression(Mono.CSharp.BuilderContext ctx) { return default(System.Linq.Expressions.Expression); }
    public static Mono.CSharp.Expression MemberLookup(Mono.CSharp.IMemberContext rc, bool errorMode, Mono.CSharp.TypeSpec queried_type, string name, int arity, Mono.CSharp.Expression.MemberLookupRestrictions restrictions, Mono.CSharp.Location loc) { return default(Mono.CSharp.Expression); }
    public Mono.CSharp.Expression ProbeIdenticalTypeName(Mono.CSharp.ResolveContext rc, Mono.CSharp.Expression left, Mono.CSharp.SimpleName name) { return default(Mono.CSharp.Expression); }
    public Mono.CSharp.Expression Resolve(Mono.CSharp.ResolveContext rc) { return default(Mono.CSharp.Expression); }
    public Mono.CSharp.Expression Resolve(Mono.CSharp.ResolveContext ec, Mono.CSharp.ResolveFlags flags) { return default(Mono.CSharp.Expression); }
    public virtual Mono.CSharp.TypeSpec ResolveAsType(Mono.CSharp.IMemberContext mc, bool allowUnboundTypeArguments=false) { return default(Mono.CSharp.TypeSpec); }
    public Mono.CSharp.Constant ResolveLabelConstant(Mono.CSharp.ResolveContext rc) { return default(Mono.CSharp.Constant); }
    public Mono.CSharp.Expression ResolveLValue(Mono.CSharp.ResolveContext ec, Mono.CSharp.Expression right_side) { return default(Mono.CSharp.Expression); }
    public static void UnsafeError(Mono.CSharp.Report Report, Mono.CSharp.Location loc) { }
    public static void UnsafeError(Mono.CSharp.ResolveContext ec, Mono.CSharp.Location loc) { }
    public static void Warning_UnreachableExpression(Mono.CSharp.ResolveContext rc, Mono.CSharp.Location loc) { }
    [System.FlagsAttribute]
    public enum MemberLookupRestrictions {
      EmptyArguments = 16,
      ExactArity = 4,
      IgnoreAmbiguity = 64,
      IgnoreArity = 32,
      InvocableOnly = 1,
      None = 0,
      ReadAccess = 8,
    }
  }
  public abstract partial class ExpressionStatement : Mono.CSharp.Expression {
    protected ExpressionStatement() { }
    public override void EmitSideEffect(Mono.CSharp.EmitContext ec) { }
    public abstract void EmitStatement(Mono.CSharp.EmitContext ec);
    public virtual void MarkReachable(Mono.CSharp.Reachability rc) { }
    public Mono.CSharp.ExpressionStatement ResolveStatement(Mono.CSharp.BlockContext ec) { return default(Mono.CSharp.ExpressionStatement); }
  }
  public partial class ExtensionMethodCandidates {
    public ExtensionMethodCandidates(Mono.CSharp.IMemberContext context, System.Collections.Generic.IList<Mono.CSharp.MethodSpec> methods, Mono.CSharp.NamespaceContainer nsContainer, int lookupIndex) { }
    public Mono.CSharp.NamespaceContainer Container { get { return default(Mono.CSharp.NamespaceContainer); } }
    public Mono.CSharp.IMemberContext Context { get { return default(Mono.CSharp.IMemberContext); } }
    public int LookupIndex { get { return default(int); } }
    public System.Collections.Generic.IList<Mono.CSharp.MethodSpec> Methods { get { return default(System.Collections.Generic.IList<Mono.CSharp.MethodSpec>); } }
  }
  public partial class Field : Mono.CSharp.FieldBase {
    public Field(Mono.CSharp.TypeDefinition parent, Mono.CSharp.FullNamedExpression type, Mono.CSharp.Modifiers mod, Mono.CSharp.MemberName name, Mono.CSharp.Attributes attrs) : base (default(Mono.CSharp.TypeDefinition), default(Mono.CSharp.FullNamedExpression), default(Mono.CSharp.Modifiers), default(Mono.CSharp.Modifiers), default(Mono.CSharp.MemberName), default(Mono.CSharp.Attributes)) { }
    public override void Accept(Mono.CSharp.StructuralVisitor visitor) { }
    public override bool Define() { return default(bool); }
    protected override void DoMemberTypeDependentChecks() { }
    protected override bool VerifyClsCompliance() { return default(bool); }
  }
  public abstract partial class FieldBase : Mono.CSharp.MemberBase {
    protected System.Collections.Generic.List<Mono.CSharp.FieldDeclarator> declarators;
    protected System.Reflection.Emit.FieldBuilder FieldBuilder;
    protected Mono.CSharp.Expression initializer;
    protected Mono.CSharp.FieldSpec spec;
    public Mono.CSharp.FieldBase.Status status;
    protected FieldBase(Mono.CSharp.TypeDefinition parent, Mono.CSharp.FullNamedExpression type, Mono.CSharp.Modifiers mod, Mono.CSharp.Modifiers allowed_mod, Mono.CSharp.MemberName name, Mono.CSharp.Attributes attrs) : base (default(Mono.CSharp.TypeDefinition), default(Mono.CSharp.FullNamedExpression), default(Mono.CSharp.Modifiers), default(Mono.CSharp.Modifiers), default(Mono.CSharp.Modifiers), default(Mono.CSharp.MemberName), default(Mono.CSharp.Attributes)) { }
    public override System.AttributeTargets AttributeTargets { get { return default(System.AttributeTargets); } }
    public System.Collections.Generic.List<Mono.CSharp.FieldDeclarator> Declarators { get { return default(System.Collections.Generic.List<Mono.CSharp.FieldDeclarator>); } }
    public override string DocCommentHeader { get { return default(string); } }
    public Mono.CSharp.Expression Initializer { get { return default(Mono.CSharp.Expression); } set { } }
    public string Name { get { return default(string); } }
    public Mono.CSharp.FieldSpec Spec { get { return default(Mono.CSharp.FieldSpec); } }
    public override System.String[] ValidAttributeTargets { get { return default(System.String[]); } }
    public void AddDeclarator(Mono.CSharp.FieldDeclarator declarator) { }
    public override void ApplyAttributeBuilder(Mono.CSharp.Attribute a, Mono.CSharp.MethodSpec ctor, System.Byte[] cdata, Mono.CSharp.PredefinedAttributes pa) { }
    protected override bool CheckBase() { return default(bool); }
    public virtual Mono.CSharp.Constant ConvertInitializer(Mono.CSharp.ResolveContext rc, Mono.CSharp.Constant expr) { return default(Mono.CSharp.Constant); }
    protected override void DoMemberTypeDependentChecks() { }
    public override void Emit() { }
    public static void Error_VariableOfStaticClass(Mono.CSharp.Location loc, string variable_name, Mono.CSharp.TypeSpec static_class, Mono.CSharp.Report Report) { }
    public void SetCustomAttribute(Mono.CSharp.MethodSpec ctor, System.Byte[] data) { }
    protected override bool VerifyClsCompliance() { return default(bool); }
    [System.FlagsAttribute]
    public enum Status : byte {
      HAS_OFFSET = (byte)4,
    }
  }
  public partial class FieldDeclarator {
    public FieldDeclarator(Mono.CSharp.SimpleMemberName name, Mono.CSharp.Expression initializer) { }
    public Mono.CSharp.Expression Initializer { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(Mono.CSharp.Expression); } }
    public Mono.CSharp.SimpleMemberName Name { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(Mono.CSharp.SimpleMemberName); } }
    public virtual Mono.CSharp.FullNamedExpression GetFieldTypeExpression(Mono.CSharp.FieldBase field) { return default(Mono.CSharp.FullNamedExpression); }
  }
  public partial class FieldExpr : Mono.CSharp.MemberExpr, Mono.CSharp.IAssignMethod, Mono.CSharp.IFixedExpression, Mono.CSharp.IMemoryLocation, Mono.CSharp.IVariableReference {
    protected Mono.CSharp.FieldSpec spec;
    public FieldExpr(Mono.CSharp.FieldBase fi, Mono.CSharp.Location l) { }
    public FieldExpr(Mono.CSharp.FieldSpec spec, Mono.CSharp.Location loc) { }
    protected FieldExpr(Mono.CSharp.Location l) { }
    protected override Mono.CSharp.TypeSpec DeclaringType { get { return default(Mono.CSharp.TypeSpec); } }
    public bool IsFixed { get { return default(bool); } }
    public bool IsHoisted { get { return default(bool); } }
    public override bool IsInstance { get { return default(bool); } }
    public override bool IsStatic { get { return default(bool); } }
    public override string KindName { get { return default(string); } }
    public override string Name { get { return default(string); } }
    public Mono.CSharp.FieldSpec Spec { get { return default(Mono.CSharp.FieldSpec); } }
    public Mono.CSharp.VariableInfo VariableInfo { get { return default(Mono.CSharp.VariableInfo); } }
    public virtual void AddressOf(Mono.CSharp.EmitContext ec, Mono.CSharp.AddressOp mode) { }
    protected override void CloneTo(Mono.CSharp.CloneContext clonectx, Mono.CSharp.Expression target) { }
    public override Mono.CSharp.Expression CreateExpressionTree(Mono.CSharp.ResolveContext ec) { return default(Mono.CSharp.Expression); }
    public Mono.CSharp.Expression CreateExpressionTree(Mono.CSharp.ResolveContext ec, bool convertInstance) { return default(Mono.CSharp.Expression); }
    public Mono.CSharp.Expression CreateTypeOfExpression() { return default(Mono.CSharp.Expression); }
    protected override Mono.CSharp.Expression DoResolve(Mono.CSharp.ResolveContext ec) { return default(Mono.CSharp.Expression); }
    public override Mono.CSharp.Expression DoResolveLValue(Mono.CSharp.ResolveContext ec, Mono.CSharp.Expression right_side) { return default(Mono.CSharp.Expression); }
    public override void Emit(Mono.CSharp.EmitContext ec) { }
    public void Emit(Mono.CSharp.EmitContext ec, bool leave_copy) { }
    public void EmitAssign(Mono.CSharp.EmitContext ec, Mono.CSharp.Expression source, bool leave_copy, bool isCompound) { }
    public void EmitAssignFromStack(Mono.CSharp.EmitContext ec) { }
    public override void EmitSideEffect(Mono.CSharp.EmitContext ec) { }
    public override bool Equals(object obj) { return default(bool); }
    public override void FlowAnalysis(Mono.CSharp.FlowAnalysisContext fc) { }
    public override int GetHashCode() { return default(int); }
    public override string GetSignatureForError() { return default(string); }
    public bool IsMarshalByRefAccess(Mono.CSharp.ResolveContext rc) { return default(bool); }
    public System.Linq.Expressions.Expression MakeAssignExpression(Mono.CSharp.BuilderContext ctx, Mono.CSharp.Expression source) { return default(System.Linq.Expressions.Expression); }
    public override System.Linq.Expressions.Expression MakeExpression(Mono.CSharp.BuilderContext ctx) { return default(System.Linq.Expressions.Expression); }
    public void SetFieldAssigned(Mono.CSharp.FlowAnalysisContext fc) { }
    public void SetHasAddressTaken() { }
    public override void SetTypeArguments(Mono.CSharp.ResolveContext ec, Mono.CSharp.TypeArguments ta) { }
  }
  public partial class FieldInitializer : Mono.CSharp.Assign {
    public FieldInitializer(Mono.CSharp.FieldBase mc, Mono.CSharp.Expression expression, Mono.CSharp.Location loc) : base (default(Mono.CSharp.Expression), default(Mono.CSharp.Expression), default(Mono.CSharp.Location)) { }
    public int AssignmentOffset { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(int); } }
    public Mono.CSharp.FieldBase Field { get { return default(Mono.CSharp.FieldBase); } }
    public bool IsDefaultInitializer { get { return default(bool); } }
    public override bool IsSideEffectFree { get { return default(bool); } }
    public override Mono.CSharp.Location StartLocation { get { return default(Mono.CSharp.Location); } }
    protected override Mono.CSharp.Expression DoResolve(Mono.CSharp.ResolveContext rc) { return default(Mono.CSharp.Expression); }
    public override void EmitStatement(Mono.CSharp.EmitContext ec) { }
    public override void FlowAnalysis(Mono.CSharp.FlowAnalysisContext fc) { }
  }
  public partial class FieldSpec : Mono.CSharp.MemberSpec, Mono.CSharp.IInterfaceMemberSpec {
    public FieldSpec(Mono.CSharp.TypeSpec declaringType, Mono.CSharp.IMemberDefinition definition, Mono.CSharp.TypeSpec memberType, System.Reflection.FieldInfo info, Mono.CSharp.Modifiers modifiers) : base (default(Mono.CSharp.MemberKind), default(Mono.CSharp.TypeSpec), default(Mono.CSharp.IMemberDefinition), default(Mono.CSharp.Modifiers)) { }
    public bool IsReadOnly { get { return default(bool); } }
    public Mono.CSharp.TypeSpec MemberType { get { return default(Mono.CSharp.TypeSpec); } }
    public System.Reflection.FieldInfo GetMetaInfo() { return default(System.Reflection.FieldInfo); }
    public override Mono.CSharp.MemberSpec InflateMember(Mono.CSharp.TypeParameterInflator inflator) { return default(Mono.CSharp.MemberSpec); }
    public Mono.CSharp.FieldSpec Mutate(Mono.CSharp.TypeParameterMutator mutator) { return default(Mono.CSharp.FieldSpec); }
    public override System.Collections.Generic.List<Mono.CSharp.MissingTypeSpecReference> ResolveMissingDependencies(Mono.CSharp.MemberSpec caller) { return default(System.Collections.Generic.List<Mono.CSharp.MissingTypeSpecReference>); }
  }
  public partial class Fixed : Mono.CSharp.Statement {
    public Fixed(Mono.CSharp.Fixed.VariableDeclaration decl, Mono.CSharp.Statement stmt, Mono.CSharp.Location l) { }
    public Mono.CSharp.Statement Statement { get { return default(Mono.CSharp.Statement); } }
    public Mono.CSharp.BlockVariable Variables { get { return default(Mono.CSharp.BlockVariable); } }
    public override object Accept(Mono.CSharp.StructuralVisitor visitor) { return default(object); }
    protected override void CloneTo(Mono.CSharp.CloneContext clonectx, Mono.CSharp.Statement t) { }
    protected override void DoEmit(Mono.CSharp.EmitContext ec) { }
    protected override bool DoFlowAnalysis(Mono.CSharp.FlowAnalysisContext fc) { return default(bool); }
    public override Mono.CSharp.Reachability MarkReachable(Mono.CSharp.Reachability rc) { return default(Mono.CSharp.Reachability); }
    public override bool Resolve(Mono.CSharp.BlockContext bc) { return default(bool); }
    public partial class VariableDeclaration : Mono.CSharp.BlockVariable {
      public VariableDeclaration(Mono.CSharp.FullNamedExpression type, Mono.CSharp.LocalVariable li) : base (default(Mono.CSharp.FullNamedExpression), default(Mono.CSharp.LocalVariable)) { }
      protected override Mono.CSharp.Expression ResolveInitializer(Mono.CSharp.BlockContext bc, Mono.CSharp.LocalVariable li, Mono.CSharp.Expression initializer) { return default(Mono.CSharp.Expression); }
    }
  }
  public partial class FixedField : Mono.CSharp.FieldBase {
    public const string FixedElementName = "FixedElementField";
    public FixedField(Mono.CSharp.TypeDefinition parent, Mono.CSharp.FullNamedExpression type, Mono.CSharp.Modifiers mod, Mono.CSharp.MemberName name, Mono.CSharp.Attributes attrs) : base (default(Mono.CSharp.TypeDefinition), default(Mono.CSharp.FullNamedExpression), default(Mono.CSharp.Modifiers), default(Mono.CSharp.Modifiers), default(Mono.CSharp.MemberName), default(Mono.CSharp.Attributes)) { }
    public System.Nullable<System.Runtime.InteropServices.CharSet> CharSet { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Nullable<System.Runtime.InteropServices.CharSet>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public override Mono.CSharp.Constant ConvertInitializer(Mono.CSharp.ResolveContext rc, Mono.CSharp.Constant expr) { return default(Mono.CSharp.Constant); }
    public override bool Define() { return default(bool); }
    protected override void DoMemberTypeIndependentChecks() { }
    public override void Emit() { }
  }
  public partial class FloatConstant : Mono.CSharp.Constant {
    public readonly double DoubleValue;
    public FloatConstant(Mono.CSharp.BuiltinTypes types, double v, Mono.CSharp.Location loc) : base (default(Mono.CSharp.Location)) { }
    public FloatConstant(Mono.CSharp.TypeSpec type, double v, Mono.CSharp.Location loc) : base (default(Mono.CSharp.Location)) { }
    public override bool IsDefaultValue { get { return default(bool); } }
    public override bool IsNegative { get { return default(bool); } }
    public float Value { get { return default(float); } }
    public override Mono.CSharp.Constant ConvertExplicitly(bool in_checked_context, Mono.CSharp.TypeSpec target_type) { return default(Mono.CSharp.Constant); }
    public override Mono.CSharp.Constant ConvertImplicitly(Mono.CSharp.TypeSpec type) { return default(Mono.CSharp.Constant); }
    public override void Emit(Mono.CSharp.EmitContext ec) { }
    public override void EncodeAttributeValue(Mono.CSharp.IMemberContext rc, Mono.CSharp.AttributeEncoder enc, Mono.CSharp.TypeSpec targetType, Mono.CSharp.TypeSpec parameterType) { }
    public override object GetValue() { return default(object); }
    public override string GetValueAsLiteral() { return default(string); }
    public override long GetValueAsLong() { return default(long); }
  }
  public partial class FloatLiteral : Mono.CSharp.FloatConstant, Mono.CSharp.ILiteralConstant {
    public FloatLiteral(Mono.CSharp.BuiltinTypes types, float f, Mono.CSharp.Location loc) : base (default(Mono.CSharp.BuiltinTypes), default(double), default(Mono.CSharp.Location)) { }
    public override bool IsLiteral { get { return default(bool); } }
    public override object Accept(Mono.CSharp.StructuralVisitor visitor) { return default(object); }
  }
  public partial class FlowAnalysisContext {
    public FlowAnalysisContext(Mono.CSharp.CompilerContext ctx, Mono.CSharp.ParametersBlock parametersBlock, int definiteAssignmentLength) { }
    public Mono.CSharp.DefiniteAssignmentBitSet DefiniteAssignment { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(Mono.CSharp.DefiniteAssignmentBitSet); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public Mono.CSharp.DefiniteAssignmentBitSet DefiniteAssignmentOnFalse { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(Mono.CSharp.DefiniteAssignmentBitSet); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public Mono.CSharp.DefiniteAssignmentBitSet DefiniteAssignmentOnTrue { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(Mono.CSharp.DefiniteAssignmentBitSet); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Collections.Generic.List<Mono.CSharp.LabeledStatement> LabelStack { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Collections.Generic.List<Mono.CSharp.LabeledStatement>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public Mono.CSharp.ParametersBlock ParametersBlock { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(Mono.CSharp.ParametersBlock); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public Mono.CSharp.Report Report { get { return default(Mono.CSharp.Report); } }
    public Mono.CSharp.DefiniteAssignmentBitSet SwitchInitialDefinitiveAssignment { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(Mono.CSharp.DefiniteAssignmentBitSet); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public Mono.CSharp.TryFinally TryFinally { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(Mono.CSharp.TryFinally); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public bool UnreachableReported { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public void BranchConditionalAccessDefiniteAssignment() { }
    public Mono.CSharp.DefiniteAssignmentBitSet BranchDefiniteAssignment() { return default(Mono.CSharp.DefiniteAssignmentBitSet); }
    public void ConditionalAccessEnd() { }
    public bool IsDefinitelyAssigned(Mono.CSharp.VariableInfo variable) { return default(bool); }
    public bool IsStructFieldDefinitelyAssigned(Mono.CSharp.VariableInfo variable, string name) { return default(bool); }
    public void SetStructFieldAssigned(Mono.CSharp.VariableInfo variable, string name) { }
    public void SetVariableAssigned(Mono.CSharp.VariableInfo variable, bool generatedAssignment=false) { }
  }
  public partial class For : Mono.CSharp.LoopStatement {
    public For(Mono.CSharp.Location l) : base (default(Mono.CSharp.Statement)) { }
    public Mono.CSharp.Expression Condition { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(Mono.CSharp.Expression); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public Mono.CSharp.Statement Initializer { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(Mono.CSharp.Statement); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public Mono.CSharp.Statement Iterator { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(Mono.CSharp.Statement); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public override object Accept(Mono.CSharp.StructuralVisitor visitor) { return default(object); }
    public override void AddEndDefiniteAssignment(Mono.CSharp.FlowAnalysisContext fc) { }
    protected override void CloneTo(Mono.CSharp.CloneContext clonectx, Mono.CSharp.Statement t) { }
    protected override void DoEmit(Mono.CSharp.EmitContext ec) { }
    protected override bool DoFlowAnalysis(Mono.CSharp.FlowAnalysisContext fc) { return default(bool); }
    public override Mono.CSharp.Reachability MarkReachable(Mono.CSharp.Reachability rc) { return default(Mono.CSharp.Reachability); }
    public override bool Resolve(Mono.CSharp.BlockContext bc) { return default(bool); }
    public override void SetEndReachable() { }
    public override void SetIteratorReachable() { }
  }
  public partial class Foreach : Mono.CSharp.LoopStatement {
    public Foreach(Mono.CSharp.Expression type, Mono.CSharp.LocalVariable var, Mono.CSharp.Expression expr, Mono.CSharp.Statement stmt, Mono.CSharp.Block body, Mono.CSharp.Location l) : base (default(Mono.CSharp.Statement)) { }
    public Mono.CSharp.Expression Expr { get { return default(Mono.CSharp.Expression); } }
    public Mono.CSharp.Expression TypeExpression { get { return default(Mono.CSharp.Expression); } }
    public Mono.CSharp.LocalVariable Variable { get { return default(Mono.CSharp.LocalVariable); } }
    public override object Accept(Mono.CSharp.StructuralVisitor visitor) { return default(object); }
    protected override void CloneTo(Mono.CSharp.CloneContext clonectx, Mono.CSharp.Statement t) { }
    protected override void DoEmit(Mono.CSharp.EmitContext ec) { }
    protected override bool DoFlowAnalysis(Mono.CSharp.FlowAnalysisContext fc) { return default(bool); }
    public override Mono.CSharp.Reachability MarkReachable(Mono.CSharp.Reachability rc) { return default(Mono.CSharp.Reachability); }
    public override bool Resolve(Mono.CSharp.BlockContext ec) { return default(bool); }
  }
  public abstract partial class FullNamedExpression : Mono.CSharp.Expression {
    protected FullNamedExpression() { }
    protected override void CloneTo(Mono.CSharp.CloneContext clonectx, Mono.CSharp.Expression target) { }
    public override bool ContainsEmitWithAwait() { return default(bool); }
    public override Mono.CSharp.Expression CreateExpressionTree(Mono.CSharp.ResolveContext ec) { return default(Mono.CSharp.Expression); }
    public override void Emit(Mono.CSharp.EmitContext ec) { }
    public override Mono.CSharp.TypeSpec ResolveAsType(Mono.CSharp.IMemberContext mc, bool allowUnboundTypeArguments=false) { return default(Mono.CSharp.TypeSpec); }
    public abstract Mono.CSharp.FullNamedExpression ResolveAsTypeOrNamespace(Mono.CSharp.IMemberContext mc, bool allowUnboundTypeArguments);
  }
  public sealed partial class GlobalRootNamespace : Mono.CSharp.RootNamespace {
    public GlobalRootNamespace() : base (default(string)) { }
  }
  public partial class Goto : Mono.CSharp.ExitStatement {
    public Goto(string label, Mono.CSharp.Location l) { }
    protected override bool IsLocalExit { get { return default(bool); } }
    public string Target { get { return default(string); } }
    public override object Accept(Mono.CSharp.StructuralVisitor visitor) { return default(object); }
    protected override void CloneTo(Mono.CSharp.CloneContext clonectx, Mono.CSharp.Statement target) { }
    protected override void DoEmit(Mono.CSharp.EmitContext ec) { }
    protected override bool DoFlowAnalysis(Mono.CSharp.FlowAnalysisContext fc) { return default(bool); }
    protected override bool DoResolve(Mono.CSharp.BlockContext bc) { return default(bool); }
    public static void Error_UnknownLabel(Mono.CSharp.BlockContext bc, string label, Mono.CSharp.Location loc) { }
    public override Mono.CSharp.Reachability MarkReachable(Mono.CSharp.Reachability rc) { return default(Mono.CSharp.Reachability); }
  }
  public partial class GotoCase : Mono.CSharp.SwitchGoto {
    public GotoCase(Mono.CSharp.Expression e, Mono.CSharp.Location l) : base (default(Mono.CSharp.Location)) { }
    public Mono.CSharp.Expression Expr { get { return default(Mono.CSharp.Expression); } }
    public Mono.CSharp.SwitchLabel Label { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(Mono.CSharp.SwitchLabel); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public override object Accept(Mono.CSharp.StructuralVisitor visitor) { return default(object); }
    protected override void CloneTo(Mono.CSharp.CloneContext clonectx, Mono.CSharp.Statement t) { }
    protected override void DoEmit(Mono.CSharp.EmitContext ec) { }
    public override Mono.CSharp.Reachability MarkReachable(Mono.CSharp.Reachability rc) { return default(Mono.CSharp.Reachability); }
    public override bool Resolve(Mono.CSharp.BlockContext ec) { return default(bool); }
  }
  public partial class GotoDefault : Mono.CSharp.SwitchGoto {
    public GotoDefault(Mono.CSharp.Location l) : base (default(Mono.CSharp.Location)) { }
    public override object Accept(Mono.CSharp.StructuralVisitor visitor) { return default(object); }
    protected override void DoEmit(Mono.CSharp.EmitContext ec) { }
    public override Mono.CSharp.Reachability MarkReachable(Mono.CSharp.Reachability rc) { return default(Mono.CSharp.Reachability); }
    public override bool Resolve(Mono.CSharp.BlockContext bc) { return default(bool); }
  }
  public partial class HoistedParameter : Mono.CSharp.HoistedVariable {
    public HoistedParameter(Mono.CSharp.AnonymousMethodStorey scope, Mono.CSharp.ParameterReference par) : base (default(Mono.CSharp.AnonymousMethodStorey), default(string), default(Mono.CSharp.TypeSpec)) { }
    public HoistedParameter(Mono.CSharp.HoistedParameter hp, string name) : base (default(Mono.CSharp.AnonymousMethodStorey), default(string), default(Mono.CSharp.TypeSpec)) { }
    public bool IsAssigned { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public Mono.CSharp.ParameterReference Parameter { get { return default(Mono.CSharp.ParameterReference); } }
    public void EmitHoistingAssignment(Mono.CSharp.EmitContext ec) { }
  }
  public partial class HoistedStoreyClass : Mono.CSharp.CompilerGeneratedContainer {
    protected Mono.CSharp.TypeParameterMutator mutator;
    public HoistedStoreyClass(Mono.CSharp.TypeDefinition parent, Mono.CSharp.MemberName name, Mono.CSharp.TypeParameters tparams, Mono.CSharp.Modifiers mods, Mono.CSharp.MemberKind kind) : base (default(Mono.CSharp.TypeContainer), default(Mono.CSharp.MemberName), default(Mono.CSharp.Modifiers)) { }
    public Mono.CSharp.TypeParameterMutator Mutator { get { return default(Mono.CSharp.TypeParameterMutator); } set { } }
    public Mono.CSharp.HoistedStoreyClass GetGenericStorey() { return default(Mono.CSharp.HoistedStoreyClass); }
    public sealed partial class HoistedField : Mono.CSharp.Field {
      public HoistedField(Mono.CSharp.HoistedStoreyClass parent, Mono.CSharp.FullNamedExpression type, Mono.CSharp.Modifiers mod, string name, Mono.CSharp.Attributes attrs, Mono.CSharp.Location loc) : base (default(Mono.CSharp.TypeDefinition), default(Mono.CSharp.FullNamedExpression), default(Mono.CSharp.Modifiers), default(Mono.CSharp.MemberName), default(Mono.CSharp.Attributes)) { }
      protected override bool ResolveMemberType() { return default(bool); }
    }
  }
  public partial class HoistedThis : Mono.CSharp.HoistedVariable {
    public HoistedThis(Mono.CSharp.AnonymousMethodStorey storey, Mono.CSharp.Field field) : base (default(Mono.CSharp.AnonymousMethodStorey), default(string), default(Mono.CSharp.TypeSpec)) { }
  }
  public abstract partial class HoistedVariable {
    protected Mono.CSharp.Field field;
    protected readonly Mono.CSharp.AnonymousMethodStorey storey;
    protected HoistedVariable(Mono.CSharp.AnonymousMethodStorey storey, Mono.CSharp.Field field) { }
    protected HoistedVariable(Mono.CSharp.AnonymousMethodStorey storey, string name, Mono.CSharp.TypeSpec type) { }
    public Mono.CSharp.Field Field { get { return default(Mono.CSharp.Field); } }
    public Mono.CSharp.AnonymousMethodStorey Storey { get { return default(Mono.CSharp.AnonymousMethodStorey); } }
    public void AddressOf(Mono.CSharp.EmitContext ec, Mono.CSharp.AddressOp mode) { }
    public Mono.CSharp.Expression CreateExpressionTree() { return default(Mono.CSharp.Expression); }
    public void Emit(Mono.CSharp.EmitContext ec) { }
    public void Emit(Mono.CSharp.EmitContext ec, bool leave_copy) { }
    public void EmitAssign(Mono.CSharp.EmitContext ec, Mono.CSharp.Expression source, bool leave_copy, bool isCompound) { }
    public Mono.CSharp.Expression EmitToField(Mono.CSharp.EmitContext ec) { return default(Mono.CSharp.Expression); }
    protected virtual Mono.CSharp.FieldExpr GetFieldExpression(Mono.CSharp.EmitContext ec) { return default(Mono.CSharp.FieldExpr); }
  }
  public partial interface IAssemblyDefinition {
    string FullName { get; }
    bool IsCLSCompliant { get; }
    bool IsMissing { get; }
    string Name { get; }
    System.Byte[] GetPublicKeyToken();
    bool IsFriendAssemblyTo(Mono.CSharp.IAssemblyDefinition assembly);
  }
  public partial interface IAssignMethod {
    void Emit(Mono.CSharp.EmitContext ec, bool leave_copy);
    void EmitAssign(Mono.CSharp.EmitContext ec, Mono.CSharp.Expression source, bool leave_copy, bool isCompound);
  }
  public partial interface IExpressionCleanup {
    void EmitCleanup(Mono.CSharp.EmitContext ec);
  }
  public partial class If : Mono.CSharp.Statement {
    public Mono.CSharp.Statement FalseStatement;
    public Mono.CSharp.Statement TrueStatement;
    public If(Mono.CSharp.Expression bool_expr, Mono.CSharp.Statement true_statement, Mono.CSharp.Location l) { }
    public If(Mono.CSharp.Expression bool_expr, Mono.CSharp.Statement true_statement, Mono.CSharp.Statement false_statement, Mono.CSharp.Location l) { }
    public Mono.CSharp.Expression Expr { get { return default(Mono.CSharp.Expression); } }
    public override object Accept(Mono.CSharp.StructuralVisitor visitor) { return default(object); }
    protected override void CloneTo(Mono.CSharp.CloneContext clonectx, Mono.CSharp.Statement t) { }
    protected override void DoEmit(Mono.CSharp.EmitContext ec) { }
    protected override bool DoFlowAnalysis(Mono.CSharp.FlowAnalysisContext fc) { return default(bool); }
    public override Mono.CSharp.Reachability MarkReachable(Mono.CSharp.Reachability rc) { return default(Mono.CSharp.Reachability); }
    public override bool Resolve(Mono.CSharp.BlockContext ec) { return default(bool); }
  }
  public partial interface IFixedExpression {
    bool IsFixed { get; }
  }
  public partial interface IGenericMethodDefinition : Mono.CSharp.IMemberDefinition, Mono.CSharp.IMethodDefinition {
    Mono.CSharp.TypeParameterSpec[] TypeParameters { get; }
    int TypeParametersCount { get; }
  }
  public partial interface IInterfaceMemberSpec {
    Mono.CSharp.TypeSpec MemberType { get; }
  }
  public partial interface ILiteralConstant {
  }
  public partial interface ILocalVariable {
    void Emit(Mono.CSharp.EmitContext ec);
    void EmitAddressOf(Mono.CSharp.EmitContext ec);
    void EmitAssign(Mono.CSharp.EmitContext ec);
  }
  public partial interface IMemberContext : Mono.CSharp.IModuleContext {
    Mono.CSharp.MemberCore CurrentMemberDefinition { get; }
    Mono.CSharp.TypeSpec CurrentType { get; }
    Mono.CSharp.TypeParameters CurrentTypeParameters { get; }
    bool IsObsolete { get; }
    bool IsStatic { get; }
    bool IsUnsafe { get; }
    string GetSignatureForError();
    Mono.CSharp.ExtensionMethodCandidates LookupExtensionMethod(Mono.CSharp.TypeSpec extensionType, string name, int arity);
    Mono.CSharp.FullNamedExpression LookupNamespaceAlias(string name);
    Mono.CSharp.FullNamedExpression LookupNamespaceOrType(string name, int arity, Mono.CSharp.LookupMode mode, Mono.CSharp.Location loc);
  }
  public partial interface IMemberDefinition {
    System.Nullable<System.Boolean> CLSAttributeValue { get; }
    bool IsImported { get; }
    string Name { get; }
    System.String[] ConditionalConditions();
    System.ObsoleteAttribute GetAttributeObsolete();
    void SetIsAssigned();
    void SetIsUsed();
  }
  public partial interface IMemoryLocation {
    void AddressOf(Mono.CSharp.EmitContext ec, Mono.CSharp.AddressOp mode);
  }
  public partial interface IMethodData : Mono.CSharp.IMemberContext, Mono.CSharp.IModuleContext {
    Mono.CSharp.ToplevelBlock Block { get; set; }
    System.Reflection.CallingConventions CallingConventions { get; }
    bool IsAccessor { get; }
    Mono.CSharp.Location Location { get; }
    Mono.CSharp.MemberName MethodName { get; }
    Mono.CSharp.Attributes OptAttributes { get; }
    Mono.CSharp.ParametersCompiled ParameterInfo { get; }
    Mono.CSharp.TypeSpec ReturnType { get; }
    Mono.CSharp.MethodSpec Spec { get; }
    Mono.CSharp.EmitContext CreateEmitContext(System.Reflection.Emit.ILGenerator ig, Mono.CompilerServices.SymbolWriter.SourceMethodBuilder sourceMethod);
  }
  public partial interface IMethodDefinition : Mono.CSharp.IMemberDefinition {
    System.Reflection.MethodBase Metadata { get; }
  }
  public partial interface IModuleContext {
    Mono.CSharp.ModuleContainer Module { get; }
  }
  public partial class ImplicitCast : Mono.CSharp.ShimExpression {
    public ImplicitCast(Mono.CSharp.Expression expr, Mono.CSharp.TypeSpec target, bool arrayAccess) : base (default(Mono.CSharp.Expression)) { }
    protected override Mono.CSharp.Expression DoResolve(Mono.CSharp.ResolveContext ec) { return default(Mono.CSharp.Expression); }
  }
  public partial class ImplicitDelegateCreation : Mono.CSharp.DelegateCreation {
    public ImplicitDelegateCreation(Mono.CSharp.TypeSpec delegateType, Mono.CSharp.MethodGroupExpr mg, Mono.CSharp.Location loc) { }
    public static bool ContainsMethodTypeParameter(Mono.CSharp.TypeSpec type) { return default(bool); }
    protected override Mono.CSharp.Expression DoResolve(Mono.CSharp.ResolveContext ec) { return default(Mono.CSharp.Expression); }
    public override void Emit(Mono.CSharp.EmitContext ec) { }
  }
  public partial class ImplicitLambdaParameter : Mono.CSharp.Parameter {
    public ImplicitLambdaParameter(string name, Mono.CSharp.Location loc) : base (default(Mono.CSharp.FullNamedExpression), default(string), default(Mono.CSharp.Parameter.Modifier), default(Mono.CSharp.Attributes), default(Mono.CSharp.Location)) { }
    public override Mono.CSharp.TypeSpec Resolve(Mono.CSharp.IMemberContext ec, int index) { return default(Mono.CSharp.TypeSpec); }
    public void SetParameterType(Mono.CSharp.TypeSpec type) { }
  }
  public partial class ImportedAssemblyDefinition : Mono.CSharp.IAssemblyDefinition {
    public ImportedAssemblyDefinition(System.Reflection.Assembly assembly) { }
    public System.Reflection.Assembly Assembly { get { return default(System.Reflection.Assembly); } }
    public string FullName { get { return default(string); } }
    public bool HasStrongName { get { return default(bool); } }
    public bool IsCLSCompliant { get { return default(bool); } }
    public bool IsMissing { get { return default(bool); } }
    public string Location { get { return default(string); } }
    public string Name { get { return default(string); } }
    public System.Reflection.AssemblyName GetAssemblyVisibleToName(Mono.CSharp.IAssemblyDefinition assembly) { return default(System.Reflection.AssemblyName); }
    public System.Byte[] GetPublicKeyToken() { return default(System.Byte[]); }
    public bool IsFriendAssemblyTo(Mono.CSharp.IAssemblyDefinition assembly) { return default(bool); }
    public void ReadAttributes() { }
    public override string ToString() { return default(string); }
  }
  public partial class ImportedModuleDefinition {
    public ImportedModuleDefinition(System.Reflection.Module module) { }
    public bool IsCLSCompliant { get { return default(bool); } }
    public string Name { get { return default(string); } }
    public System.Collections.Generic.List<Mono.CSharp.Attribute> ReadAssemblyAttributes() { return default(System.Collections.Generic.List<Mono.CSharp.Attribute>); }
    public void ReadAttributes() { }
  }
  public partial interface INamedBlockVariable {
    Mono.CSharp.Block Block { get; }
    bool IsDeclared { get; }
    bool IsParameter { get; }
    Mono.CSharp.Location Location { get; }
    Mono.CSharp.Expression CreateReferenceExpression(Mono.CSharp.ResolveContext rc, Mono.CSharp.Location loc);
  }
  public partial class Indexer : Mono.CSharp.PropertyBase, Mono.CSharp.IInterfaceMemberSpec, Mono.CSharp.IParametersMember {
    public Indexer(Mono.CSharp.TypeDefinition parent, Mono.CSharp.FullNamedExpression type, Mono.CSharp.MemberName name, Mono.CSharp.Modifiers mod, Mono.CSharp.ParametersCompiled parameters, Mono.CSharp.Attributes attrs) : base (default(Mono.CSharp.TypeDefinition), default(Mono.CSharp.FullNamedExpression), default(Mono.CSharp.Modifiers), default(Mono.CSharp.Modifiers), default(Mono.CSharp.MemberName), default(Mono.CSharp.Attributes)) { }
    Mono.CSharp.AParametersCollection Mono.CSharp.IParametersMember.Parameters { get { return default(Mono.CSharp.AParametersCollection); } }
    public Mono.CSharp.ParametersCompiled ParameterInfo { get { return default(Mono.CSharp.ParametersCompiled); } }
    public override void Accept(Mono.CSharp.StructuralVisitor visitor) { }
    public override void ApplyAttributeBuilder(Mono.CSharp.Attribute a, Mono.CSharp.MethodSpec ctor, System.Byte[] cdata, Mono.CSharp.PredefinedAttributes pa) { }
    protected override bool CheckForDuplications() { return default(bool); }
    public override bool Define() { return default(bool); }
    public override void Emit() { }
    public override bool EnableOverloadChecks(Mono.CSharp.MemberCore overload) { return default(bool); }
    public override string GetSignatureForDocumentation() { return default(string); }
    public override string GetSignatureForError() { return default(string); }
    protected override bool VerifyClsCompliance() { return default(bool); }
    public partial class GetIndexerMethod : Mono.CSharp.PropertyBase.GetMethod, Mono.CSharp.IInterfaceMemberSpec, Mono.CSharp.IParametersMember {
      public GetIndexerMethod(Mono.CSharp.PropertyBase property, Mono.CSharp.Modifiers modifiers, Mono.CSharp.ParametersCompiled parameters, Mono.CSharp.Attributes attrs, Mono.CSharp.Location loc) : base (default(Mono.CSharp.PropertyBase), default(Mono.CSharp.Modifiers), default(Mono.CSharp.Attributes), default(Mono.CSharp.Location)) { }
      Mono.CSharp.TypeSpec Mono.CSharp.IInterfaceMemberSpec.MemberType { get { return default(Mono.CSharp.TypeSpec); } }
      Mono.CSharp.AParametersCollection Mono.CSharp.IParametersMember.Parameters { get { return default(Mono.CSharp.AParametersCollection); } }
      public override Mono.CSharp.ParametersCompiled ParameterInfo { get { return default(Mono.CSharp.ParametersCompiled); } }
      public override void Define(Mono.CSharp.TypeContainer parent) { }
    }
    public partial class SetIndexerMethod : Mono.CSharp.PropertyBase.SetMethod, Mono.CSharp.IInterfaceMemberSpec, Mono.CSharp.IParametersMember {
      public SetIndexerMethod(Mono.CSharp.PropertyBase property, Mono.CSharp.Modifiers modifiers, Mono.CSharp.ParametersCompiled parameters, Mono.CSharp.Attributes attrs, Mono.CSharp.Location loc) : base (default(Mono.CSharp.PropertyBase), default(Mono.CSharp.Modifiers), default(Mono.CSharp.ParametersCompiled), default(Mono.CSharp.Attributes), default(Mono.CSharp.Location)) { }
      Mono.CSharp.TypeSpec Mono.CSharp.IInterfaceMemberSpec.MemberType { get { return default(Mono.CSharp.TypeSpec); } }
      Mono.CSharp.AParametersCollection Mono.CSharp.IParametersMember.Parameters { get { return default(Mono.CSharp.AParametersCollection); } }
    }
  }
  public partial class IndexerSpec : Mono.CSharp.PropertySpec, Mono.CSharp.IInterfaceMemberSpec, Mono.CSharp.IParametersMember {
    public IndexerSpec(Mono.CSharp.TypeSpec declaringType, Mono.CSharp.IMemberDefinition definition, Mono.CSharp.TypeSpec memberType, Mono.CSharp.AParametersCollection parameters, System.Reflection.PropertyInfo info, Mono.CSharp.Modifiers modifiers) : base (default(Mono.CSharp.MemberKind), default(Mono.CSharp.TypeSpec), default(Mono.CSharp.IMemberDefinition), default(Mono.CSharp.TypeSpec), default(System.Reflection.PropertyInfo), default(Mono.CSharp.Modifiers)) { }
    public Mono.CSharp.AParametersCollection Parameters { get { return default(Mono.CSharp.AParametersCollection); } }
    public override string GetSignatureForDocumentation() { return default(string); }
    public override string GetSignatureForError() { return default(string); }
    public override Mono.CSharp.MemberSpec InflateMember(Mono.CSharp.TypeParameterInflator inflator) { return default(Mono.CSharp.MemberSpec); }
    public override System.Collections.Generic.List<Mono.CSharp.MissingTypeSpecReference> ResolveMissingDependencies(Mono.CSharp.MemberSpec caller) { return default(System.Collections.Generic.List<Mono.CSharp.MissingTypeSpecReference>); }
  }
  public partial class Indirection : Mono.CSharp.Expression, Mono.CSharp.IAssignMethod, Mono.CSharp.IFixedExpression, Mono.CSharp.IMemoryLocation {
    public Indirection(Mono.CSharp.Expression expr, Mono.CSharp.Location l) { }
    public Mono.CSharp.Expression Expr { get { return default(Mono.CSharp.Expression); } }
    public bool IsFixed { get { return default(bool); } }
    public override Mono.CSharp.Location StartLocation { get { return default(Mono.CSharp.Location); } }
    public override object Accept(Mono.CSharp.StructuralVisitor visitor) { return default(object); }
    public void AddressOf(Mono.CSharp.EmitContext ec, Mono.CSharp.AddressOp Mode) { }
    protected override void CloneTo(Mono.CSharp.CloneContext clonectx, Mono.CSharp.Expression t) { }
    public override bool ContainsEmitWithAwait() { return default(bool); }
    public override Mono.CSharp.Expression CreateExpressionTree(Mono.CSharp.ResolveContext ec) { return default(Mono.CSharp.Expression); }
    protected override Mono.CSharp.Expression DoResolve(Mono.CSharp.ResolveContext ec) { return default(Mono.CSharp.Expression); }
    public override Mono.CSharp.Expression DoResolveLValue(Mono.CSharp.ResolveContext ec, Mono.CSharp.Expression right_side) { return default(Mono.CSharp.Expression); }
    public override void Emit(Mono.CSharp.EmitContext ec) { }
    public void Emit(Mono.CSharp.EmitContext ec, bool leave_copy) { }
    public void EmitAssign(Mono.CSharp.EmitContext ec, Mono.CSharp.Expression source, bool leave_copy, bool isCompound) { }
  }
  public partial class InflatedTypeSpec : Mono.CSharp.TypeSpec {
    public InflatedTypeSpec(Mono.CSharp.IModuleContext context, Mono.CSharp.TypeSpec openType, Mono.CSharp.TypeSpec declaringType, Mono.CSharp.TypeSpec[] targs) : base (default(Mono.CSharp.MemberKind), default(Mono.CSharp.TypeSpec), default(Mono.CSharp.ITypeDefinition), default(System.Type), default(Mono.CSharp.Modifiers)) { }
    public override Mono.CSharp.TypeSpec BaseType { get { return default(Mono.CSharp.TypeSpec); } }
    public Mono.CSharp.TypeParameterSpec[] Constraints { get { return default(Mono.CSharp.TypeParameterSpec[]); } }
    public bool HasConstraintsChecked { get { return default(bool); } set { } }
    public override System.Collections.Generic.IList<Mono.CSharp.TypeSpec> Interfaces { get { return default(System.Collections.Generic.IList<Mono.CSharp.TypeSpec>); } }
    public override bool IsArrayGenericInterface { get { return default(bool); } }
    public override bool IsExpressionTreeType { get { return default(bool); } }
    public override bool IsGenericTask { get { return default(bool); } }
    public override bool IsNullableType { get { return default(bool); } }
    public override Mono.CSharp.TypeSpec[] TypeArguments { get { return default(Mono.CSharp.TypeSpec[]); } }
    public override bool AddInterface(Mono.CSharp.TypeSpec iface) { return default(bool); }
    public static bool ContainsTypeParameter(Mono.CSharp.TypeSpec type) { return default(bool); }
    public Mono.CSharp.TypeParameterInflator CreateLocalInflator(Mono.CSharp.IModuleContext context) { return default(Mono.CSharp.TypeParameterInflator); }
    public override System.ObsoleteAttribute GetAttributeObsolete() { return default(System.ObsoleteAttribute); }
    public override Mono.CSharp.TypeSpec GetDefinition() { return default(Mono.CSharp.TypeSpec); }
    public override System.Type GetMetaInfo() { return default(System.Type); }
    public override string GetSignatureForError() { return default(string); }
    protected override string GetTypeNameSignature() { return default(string); }
    public bool HasDynamicArgument() { return default(bool); }
    protected override void InitializeMemberCache(bool onlyTypes) { }
    protected override bool IsNotCLSCompliant(out bool attrValue) { attrValue = default(bool); return default(bool); }
    public override Mono.CSharp.TypeSpec Mutate(Mono.CSharp.TypeParameterMutator mutator) { return default(Mono.CSharp.TypeSpec); }
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct InstanceEmitter {
    public InstanceEmitter(Mono.CSharp.Expression instance, bool addressLoad) { throw new System.NotImplementedException(); }
    public void Emit(Mono.CSharp.EmitContext ec, bool conditionalAccess) { }
    public void EmitLoad(Mono.CSharp.EmitContext ec, bool boxInstance) { }
    public Mono.CSharp.TypeSpec GetStackType(Mono.CSharp.EmitContext ec) { return default(Mono.CSharp.TypeSpec); }
  }
  public partial class IntConstant : Mono.CSharp.IntegralConstant {
    public readonly int Value;
    public IntConstant(Mono.CSharp.BuiltinTypes types, int v, Mono.CSharp.Location loc) : base (default(Mono.CSharp.TypeSpec), default(Mono.CSharp.Location)) { }
    public IntConstant(Mono.CSharp.TypeSpec type, int v, Mono.CSharp.Location loc) : base (default(Mono.CSharp.TypeSpec), default(Mono.CSharp.Location)) { }
    public override bool IsDefaultValue { get { return default(bool); } }
    public override bool IsNegative { get { return default(bool); } }
    public override bool IsOneInteger { get { return default(bool); } }
    public override bool IsZeroInteger { get { return default(bool); } }
    public override Mono.CSharp.Constant ConvertExplicitly(bool in_checked_context, Mono.CSharp.TypeSpec target_type) { return default(Mono.CSharp.Constant); }
    public override Mono.CSharp.Constant ConvertImplicitly(Mono.CSharp.TypeSpec type) { return default(Mono.CSharp.Constant); }
    public override void Emit(Mono.CSharp.EmitContext ec) { }
    public override void EncodeAttributeValue(Mono.CSharp.IMemberContext rc, Mono.CSharp.AttributeEncoder enc, Mono.CSharp.TypeSpec targetType, Mono.CSharp.TypeSpec parameterType) { }
    public override object GetValue() { return default(object); }
    public override long GetValueAsLong() { return default(long); }
    public override Mono.CSharp.Constant Increment() { return default(Mono.CSharp.Constant); }
  }
  public abstract partial class IntegralConstant : Mono.CSharp.Constant {
    protected IntegralConstant(Mono.CSharp.TypeSpec type, Mono.CSharp.Location loc) : base (default(Mono.CSharp.Location)) { }
    public override void Error_ValueCannotBeConverted(Mono.CSharp.ResolveContext ec, Mono.CSharp.TypeSpec target, bool expl) { }
    public override string GetValueAsLiteral() { return default(string); }
    public abstract Mono.CSharp.Constant Increment();
  }
  public partial class InteractiveBase {
    public static string ContinuationPrompt;
    public static System.IO.TextWriter Error;
    public static Mono.CSharp.Evaluator Evaluator;
    public static System.IO.TextWriter Output;
    public static string Prompt;
    public static bool QuitRequested;
    public InteractiveBase() { }
    public static string help { get { return default(string); } }
    public static object quit { get { return default(object); } }
    public static string Describe(object x) { return default(string); }
    public static void LoadAssembly(string assembly) { }
    public static void LoadPackage(string pkg) { }
    public static void print(object obj) { }
    public static void print(string fmt, params System.Object[] args) { }
    public static void Quit() { }
    public static void ShowUsing() { }
    public static void ShowVars() { }
    public static System.TimeSpan Time(System.Action a) { return default(System.TimeSpan); }
  }
  public sealed partial class Interface : Mono.CSharp.TypeDefinition {
    public Interface(Mono.CSharp.TypeContainer parent, Mono.CSharp.MemberName name, Mono.CSharp.Modifiers mod, Mono.CSharp.Attributes attrs) : base (default(Mono.CSharp.TypeContainer), default(Mono.CSharp.MemberName), default(Mono.CSharp.Attributes), default(Mono.CSharp.MemberKind)) { }
    public override System.AttributeTargets AttributeTargets { get { return default(System.AttributeTargets); } }
    protected override System.Reflection.TypeAttributes TypeAttr { get { return default(System.Reflection.TypeAttributes); } }
    public override void Accept(Mono.CSharp.StructuralVisitor visitor) { }
    public override void ApplyAttributeBuilder(Mono.CSharp.Attribute a, Mono.CSharp.MethodSpec ctor, System.Byte[] cdata, Mono.CSharp.PredefinedAttributes pa) { }
    protected override bool VerifyClsCompliance() { return default(bool); }
  }
  public abstract partial class InterfaceMemberBase : Mono.CSharp.MemberBase {
    protected const Mono.CSharp.Modifiers AllowedModifiersClass = 12031;
    protected const Mono.CSharp.Modifiers AllowedModifiersInterface = 8208;
    protected const Mono.CSharp.Modifiers AllowedModifiersStruct = 11423;
    protected Mono.CSharp.MethodSpec base_method;
    public System.Reflection.MethodAttributes flags;
    public Mono.CSharp.TypeSpec InterfaceType;
    protected bool is_external_implementation;
    public readonly bool IsExplicitImpl;
    public bool IsInterface;
    protected InterfaceMemberBase(Mono.CSharp.TypeDefinition parent, Mono.CSharp.FullNamedExpression type, Mono.CSharp.Modifiers mod, Mono.CSharp.Modifiers allowed_mod, Mono.CSharp.MemberName name, Mono.CSharp.Attributes attrs) : base (default(Mono.CSharp.TypeDefinition), default(Mono.CSharp.FullNamedExpression), default(Mono.CSharp.Modifiers), default(Mono.CSharp.Modifiers), default(Mono.CSharp.Modifiers), default(Mono.CSharp.MemberName), default(Mono.CSharp.Attributes)) { }
    public abstract Mono.CSharp.Variance ExpectedMemberTypeVariance { get; }
    public override bool IsUsed { get { return default(bool); } }
    public string ShortName { get { return default(string); } }
    protected static bool CheckAccessModifiers(Mono.CSharp.MemberCore this_member, Mono.CSharp.MemberSpec base_member) { return default(bool); }
    protected override bool CheckBase() { return default(bool); }
    protected virtual bool CheckForDuplications() { return default(bool); }
    protected virtual bool CheckOverrideAgainstBase(Mono.CSharp.MemberSpec base_member) { return default(bool); }
    public override bool Define() { return default(bool); }
    protected bool DefineParameters(Mono.CSharp.ParametersCompiled parameters) { return default(bool); }
    protected override void DoMemberTypeDependentChecks() { }
    public override void Emit() { }
    public override bool EnableOverloadChecks(Mono.CSharp.MemberCore overload) { return default(bool); }
    protected void Error_CannotChangeAccessModifiers(Mono.CSharp.MemberCore member, Mono.CSharp.MemberSpec base_member) { }
    protected void Error_StaticReturnType() { }
    protected virtual Mono.CSharp.MemberSpec FindBaseMember(out Mono.CSharp.MemberSpec bestCandidate, ref bool overrides) { bestCandidate = default(Mono.CSharp.MemberSpec); return default(Mono.CSharp.MemberSpec); }
    public string GetFullName(Mono.CSharp.MemberName name) { return default(string); }
    public string GetFullName(string name) { return default(string); }
    public override string GetSignatureForDocumentation() { return default(string); }
    public override void SetConstraints(System.Collections.Generic.List<Mono.CSharp.Constraints> constraints_list) { }
  }
  public partial class InternalErrorException : System.Exception {
    public InternalErrorException() { }
    public InternalErrorException(Mono.CSharp.MemberCore mc, System.Exception e) { }
    public InternalErrorException(System.Exception e, Mono.CSharp.Location loc) { }
    public InternalErrorException(System.Exception exception, string message, params System.Object[] args) { }
    public InternalErrorException(string message) { }
    public InternalErrorException(string message, params System.Object[] args) { }
  }
  public partial class IntLiteral : Mono.CSharp.IntConstant, Mono.CSharp.ILiteralConstant {
    public IntLiteral(Mono.CSharp.BuiltinTypes types, int l, Mono.CSharp.Location loc) : base (default(Mono.CSharp.BuiltinTypes), default(int), default(Mono.CSharp.Location)) { }
    public override bool IsLiteral { get { return default(bool); } }
    public override object Accept(Mono.CSharp.StructuralVisitor visitor) { return default(object); }
    public override Mono.CSharp.Constant ConvertImplicitly(Mono.CSharp.TypeSpec type) { return default(Mono.CSharp.Constant); }
  }
  public partial class Invocation : Mono.CSharp.ExpressionStatement {
    protected Mono.CSharp.Arguments arguments;
    protected Mono.CSharp.Expression expr;
    protected Mono.CSharp.MethodGroupExpr mg;
    public Invocation(Mono.CSharp.Expression expr, Mono.CSharp.Arguments arguments) { }
    public Mono.CSharp.Arguments Arguments { get { return default(Mono.CSharp.Arguments); } }
    public Mono.CSharp.Expression Exp { get { return default(Mono.CSharp.Expression); } }
    public Mono.CSharp.MethodGroupExpr MethodGroup { get { return default(Mono.CSharp.MethodGroupExpr); } }
    public override Mono.CSharp.Location StartLocation { get { return default(Mono.CSharp.Location); } }
    public override object Accept(Mono.CSharp.StructuralVisitor visitor) { return default(object); }
    public override Mono.CSharp.MethodGroupExpr CanReduceLambda(Mono.CSharp.AnonymousMethodBody body) { return default(Mono.CSharp.MethodGroupExpr); }
    protected override void CloneTo(Mono.CSharp.CloneContext clonectx, Mono.CSharp.Expression t) { }
    public override bool ContainsEmitWithAwait() { return default(bool); }
    public override Mono.CSharp.Expression CreateExpressionTree(Mono.CSharp.ResolveContext ec) { return default(Mono.CSharp.Expression); }
    protected override Mono.CSharp.Expression DoResolve(Mono.CSharp.ResolveContext rc) { return default(Mono.CSharp.Expression); }
    protected virtual Mono.CSharp.Expression DoResolveDynamic(Mono.CSharp.ResolveContext ec, Mono.CSharp.Expression memberExpr) { return default(Mono.CSharp.Expression); }
    protected virtual Mono.CSharp.MethodGroupExpr DoResolveOverload(Mono.CSharp.ResolveContext ec) { return default(Mono.CSharp.MethodGroupExpr); }
    public override void Emit(Mono.CSharp.EmitContext ec) { }
    public override void EmitStatement(Mono.CSharp.EmitContext ec) { }
    public override void FlowAnalysis(Mono.CSharp.FlowAnalysisContext fc) { }
    public override string GetSignatureForError() { return default(string); }
    public override bool HasConditionalAccess() { return default(bool); }
    public static bool IsMemberInvocable(Mono.CSharp.MemberSpec member) { return default(bool); }
    public static bool IsSpecialMethodInvocation(Mono.CSharp.ResolveContext ec, Mono.CSharp.MethodSpec method, Mono.CSharp.Location loc) { return default(bool); }
    public override System.Linq.Expressions.Expression MakeExpression(Mono.CSharp.BuilderContext ctx) { return default(System.Linq.Expressions.Expression); }
    public static System.Linq.Expressions.Expression MakeExpression(Mono.CSharp.BuilderContext ctx, Mono.CSharp.Expression instance, Mono.CSharp.MethodSpec mi, Mono.CSharp.Arguments args) { return default(System.Linq.Expressions.Expression); }
    public partial class Predefined : Mono.CSharp.Invocation {
      public Predefined(Mono.CSharp.MethodGroupExpr expr, Mono.CSharp.Arguments arguments) : base (default(Mono.CSharp.Expression), default(Mono.CSharp.Arguments)) { }
      protected override Mono.CSharp.MethodGroupExpr DoResolveOverload(Mono.CSharp.ResolveContext rc) { return default(Mono.CSharp.MethodGroupExpr); }
    }
  }
  public partial interface IParameterData {
    Mono.CSharp.Expression DefaultValue { get; }
    bool HasDefaultValue { get; }
    bool HasExtensionMethodModifier { get; }
    Mono.CSharp.Parameter.Modifier ModFlags { get; }
    string Name { get; }
  }
  public partial interface IParametersMember : Mono.CSharp.IInterfaceMemberSpec {
    Mono.CSharp.AParametersCollection Parameters { get; }
  }
  public partial class Is : Mono.CSharp.Probe {
    public Is(Mono.CSharp.Expression expr, Mono.CSharp.Expression probe_type, Mono.CSharp.Location l) : base (default(Mono.CSharp.Expression), default(Mono.CSharp.Expression), default(Mono.CSharp.Location)) { }
    protected override string OperatorName { get { return default(string); } }
    public Mono.CSharp.LocalVariable Variable { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(Mono.CSharp.LocalVariable); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public override object Accept(Mono.CSharp.StructuralVisitor visitor) { return default(object); }
    public override Mono.CSharp.Expression CreateExpressionTree(Mono.CSharp.ResolveContext ec) { return default(Mono.CSharp.Expression); }
    protected override Mono.CSharp.Expression DoResolve(Mono.CSharp.ResolveContext rc) { return default(Mono.CSharp.Expression); }
    public override void Emit(Mono.CSharp.EmitContext ec) { }
    public override void EmitBranchable(Mono.CSharp.EmitContext ec, System.Reflection.Emit.Label target, bool on_true) { }
    public override void FlowAnalysis(Mono.CSharp.FlowAnalysisContext fc) { }
    protected override void ResolveProbeType(Mono.CSharp.ResolveContext rc) { }
  }
  public partial class Iterator : Mono.CSharp.StateMachineInitializer {
    public readonly bool IsEnumerable;
    public readonly Mono.CSharp.TypeSpec OriginalIteratorType;
    public readonly Mono.CSharp.IMethodData OriginalMethod;
    public Iterator(Mono.CSharp.ParametersBlock block, Mono.CSharp.IMethodData method, Mono.CSharp.TypeDefinition host, Mono.CSharp.TypeSpec iterator_type, bool is_enumerable) : base (default(Mono.CSharp.ParametersBlock), default(Mono.CSharp.TypeDefinition), default(Mono.CSharp.TypeSpec)) { }
    public Mono.CSharp.ToplevelBlock Container { get { return default(Mono.CSharp.ToplevelBlock); } }
    public override string ContainerType { get { return default(string); } }
    public override bool IsIterator { get { return default(bool); } }
    public Mono.CSharp.Method CreateFinallyHost(Mono.CSharp.TryFinallyBlock block) { return default(Mono.CSharp.Method); }
    public static void CreateIterator(Mono.CSharp.IMethodData method, Mono.CSharp.TypeDefinition parent, Mono.CSharp.Modifiers modifiers) { }
    public override void Emit(Mono.CSharp.EmitContext ec) { }
    public void EmitDispose(Mono.CSharp.EmitContext ec) { }
    public override void EmitStatement(Mono.CSharp.EmitContext ec) { }
    public void EmitYieldBreak(Mono.CSharp.EmitContext ec, bool unwind_protect) { }
    public override string GetSignatureForError() { return default(string); }
    public override void InjectYield(Mono.CSharp.EmitContext ec, Mono.CSharp.Expression expr, int resume_pc, bool unwind_protect, System.Reflection.Emit.Label resume_point) { }
  }
  public partial interface ITypeDefinition : Mono.CSharp.IMemberDefinition {
    Mono.CSharp.IAssemblyDefinition DeclaringAssembly { get; }
    bool IsComImport { get; }
    bool IsCyclicTypeForwarder { get; }
    bool IsPartial { get; }
    bool IsTypeForwarder { get; }
    string Namespace { get; }
    Mono.CSharp.TypeParameterSpec[] TypeParameters { get; }
    int TypeParametersCount { get; }
    Mono.CSharp.TypeSpec GetAttributeCoClass();
    string GetAttributeDefaultMember();
    System.AttributeUsageAttribute GetAttributeUsage(Mono.CSharp.PredefinedAttribute pa);
    bool IsInternalAsPublic(Mono.CSharp.IAssemblyDefinition assembly);
    void LoadMembers(Mono.CSharp.TypeSpec declaringType, bool onlyTypes, ref Mono.CSharp.MemberCache cache);
  }
  public partial interface IVariableReference : Mono.CSharp.IFixedExpression {
    bool IsHoisted { get; }
    string Name { get; }
    Mono.CSharp.VariableInfo VariableInfo { get; }
    void SetHasAddressTaken();
  }
  public partial class LabeledStatement : Mono.CSharp.Statement {
    public LabeledStatement(string name, Mono.CSharp.Block block, Mono.CSharp.Location l) { }
    public Mono.CSharp.Block Block { get { return default(Mono.CSharp.Block); } }
    public string Name { get { return default(string); } }
    public override object Accept(Mono.CSharp.StructuralVisitor visitor) { return default(object); }
    public void AddGotoReference(Mono.CSharp.Reachability rc, bool finalTarget) { }
    protected override void CloneTo(Mono.CSharp.CloneContext clonectx, Mono.CSharp.Statement target) { }
    protected override void DoEmit(Mono.CSharp.EmitContext ec) { }
    protected override bool DoFlowAnalysis(Mono.CSharp.FlowAnalysisContext fc) { return default(bool); }
    public System.Reflection.Emit.Label LabelTarget(Mono.CSharp.EmitContext ec) { return default(System.Reflection.Emit.Label); }
    public override Mono.CSharp.Reachability MarkReachable(Mono.CSharp.Reachability rc) { return default(Mono.CSharp.Reachability); }
    public override bool Resolve(Mono.CSharp.BlockContext bc) { return default(bool); }
  }
  public partial class LambdaExpression : Mono.CSharp.AnonymousMethodExpression {
    public LambdaExpression(Mono.CSharp.Location loc) : base (default(Mono.CSharp.Location)) { }
    public override bool HasExplicitParameters { get { return default(bool); } }
    public override object Accept(Mono.CSharp.StructuralVisitor visitor) { return default(object); }
    protected override Mono.CSharp.AnonymousMethodBody CompatibleMethodFactory(Mono.CSharp.TypeSpec returnType, Mono.CSharp.TypeSpec delegateType, Mono.CSharp.ParametersCompiled p, Mono.CSharp.ParametersBlock b) { return default(Mono.CSharp.AnonymousMethodBody); }
    protected override Mono.CSharp.Expression CreateExpressionTree(Mono.CSharp.ResolveContext ec, Mono.CSharp.TypeSpec delegate_type) { return default(Mono.CSharp.Expression); }
    protected override bool DoResolveParameters(Mono.CSharp.ResolveContext rc) { return default(bool); }
    public override string GetSignatureForError() { return default(string); }
    protected override Mono.CSharp.ParametersCompiled ResolveParameters(Mono.CSharp.ResolveContext ec, Mono.CSharp.TypeInferenceContext tic, Mono.CSharp.TypeSpec delegateType) { return default(Mono.CSharp.ParametersCompiled); }
  }
  public enum LanguageVersion {
    Default = 6,
    Experimental = 100,
    ISO_1 = 1,
    ISO_2 = 2,
    V_3 = 3,
    V_4 = 4,
    V_5 = 5,
    V_6 = 6,
  }
  public abstract partial class LocalExitStatement : Mono.CSharp.ExitStatement {
    protected Mono.CSharp.LoopStatement enclosing_loop;
    protected LocalExitStatement(Mono.CSharp.Location loc) { }
    protected override bool IsLocalExit { get { return default(bool); } }
    protected override void CloneTo(Mono.CSharp.CloneContext clonectx, Mono.CSharp.Statement t) { }
    protected override bool DoResolve(Mono.CSharp.BlockContext bc) { return default(bool); }
  }
  public partial class LocalTemporary : Mono.CSharp.Expression, Mono.CSharp.IAssignMethod, Mono.CSharp.IMemoryLocation {
    public LocalTemporary(Mono.CSharp.TypeSpec t) { }
    public LocalTemporary(System.Reflection.Emit.LocalBuilder b, Mono.CSharp.TypeSpec t) { }
    public System.Reflection.Emit.LocalBuilder Builder { get { return default(System.Reflection.Emit.LocalBuilder); } }
    public void AddressOf(Mono.CSharp.EmitContext ec, Mono.CSharp.AddressOp mode) { }
    public override bool ContainsEmitWithAwait() { return default(bool); }
    public override Mono.CSharp.Expression CreateExpressionTree(Mono.CSharp.ResolveContext ec) { return default(Mono.CSharp.Expression); }
    protected override Mono.CSharp.Expression DoResolve(Mono.CSharp.ResolveContext ec) { return default(Mono.CSharp.Expression); }
    public override Mono.CSharp.Expression DoResolveLValue(Mono.CSharp.ResolveContext ec, Mono.CSharp.Expression right_side) { return default(Mono.CSharp.Expression); }
    public override void Emit(Mono.CSharp.EmitContext ec) { }
    public void Emit(Mono.CSharp.EmitContext ec, bool leave_copy) { }
    public void EmitAssign(Mono.CSharp.EmitContext ec, Mono.CSharp.Expression source, bool leave_copy, bool isCompound) { }
    public void Release(Mono.CSharp.EmitContext ec) { }
    public void Store(Mono.CSharp.EmitContext ec) { }
  }
  public sealed partial class LocalVariable : Mono.CSharp.ILocalVariable, Mono.CSharp.INamedBlockVariable {
    public Mono.CSharp.VariableInfo VariableInfo;
    public LocalVariable(Mono.CSharp.Block block, string name, Mono.CSharp.LocalVariable.Flags flags, Mono.CSharp.Location loc) { }
    public LocalVariable(Mono.CSharp.Block block, string name, Mono.CSharp.Location loc) { }
    public LocalVariable(Mono.CSharp.LocalVariable li, string name, Mono.CSharp.Location loc) { }
    public bool AddressTaken { get { return default(bool); } }
    public Mono.CSharp.Block Block { get { return default(Mono.CSharp.Block); } }
    public Mono.CSharp.Constant ConstantValue { get { return default(Mono.CSharp.Constant); } set { } }
    public Mono.CSharp.HoistedVariable HoistedVariant { get { return default(Mono.CSharp.HoistedVariable); } set { } }
    public bool IsCompilerGenerated { get { return default(bool); } }
    public bool IsConstant { get { return default(bool); } }
    public bool IsDeclared { get { return default(bool); } }
    public bool IsFixed { get { return default(bool); } }
    public bool IsLocked { get { return default(bool); } set { } }
    public bool IsReadonly { get { return default(bool); } }
    public bool IsThis { get { return default(bool); } }
    public Mono.CSharp.Location Location { get { return default(Mono.CSharp.Location); } }
    bool Mono.CSharp.INamedBlockVariable.IsParameter { get { return default(bool); } }
    public string Name { get { return default(string); } }
    public Mono.CSharp.TypeSpec Type { get { return default(Mono.CSharp.TypeSpec); } set { } }
    public void CreateBuilder(Mono.CSharp.EmitContext ec) { }
    public static Mono.CSharp.LocalVariable CreateCompilerGenerated(Mono.CSharp.TypeSpec type, Mono.CSharp.Block block, Mono.CSharp.Location loc) { return default(Mono.CSharp.LocalVariable); }
    public Mono.CSharp.Expression CreateReferenceExpression(Mono.CSharp.ResolveContext rc, Mono.CSharp.Location loc) { return default(Mono.CSharp.Expression); }
    public void Emit(Mono.CSharp.EmitContext ec) { }
    public void EmitAddressOf(Mono.CSharp.EmitContext ec) { }
    public void EmitAssign(Mono.CSharp.EmitContext ec) { }
    public static string GetCompilerGeneratedName(Mono.CSharp.Block block) { return default(string); }
    public string GetReadOnlyContext() { return default(string); }
    public bool IsAssigned(Mono.CSharp.FlowAnalysisContext fc) { return default(bool); }
    public bool IsThisAssigned(Mono.CSharp.FlowAnalysisContext fc, Mono.CSharp.Block block) { return default(bool); }
    public void PrepareAssignmentAnalysis(Mono.CSharp.BlockContext bc) { }
    public void SetHasAddressTaken() { }
    public void SetIsUsed() { }
    public override string ToString() { return default(string); }
    [System.FlagsAttribute]
    public enum Flags {
      AddressTaken = 4,
      CompilerGenerated = 8,
      Constant = 16,
      FixedVariable = 64,
      ForeachVariable = 32,
      IsLocked = 256,
      IsThis = 2,
      ReadonlyMask = 224,
      Used = 1,
      UsingVariable = 128,
    }
  }
  public partial class LocalVariableReference : Mono.CSharp.VariableReference {
    public Mono.CSharp.LocalVariable local_info;
    public LocalVariableReference(Mono.CSharp.LocalVariable li, Mono.CSharp.Location l) { }
    public override bool IsFixed { get { return default(bool); } }
    public override bool IsLockedByStatement { get { return default(bool); } set { } }
    public override bool IsRef { get { return default(bool); } }
    public override string Name { get { return default(string); } }
    protected override Mono.CSharp.ILocalVariable Variable { get { return default(Mono.CSharp.ILocalVariable); } }
    public override Mono.CSharp.VariableInfo VariableInfo { get { return default(Mono.CSharp.VariableInfo); } }
    protected override void CloneTo(Mono.CSharp.CloneContext clonectx, Mono.CSharp.Expression t) { }
    protected override Mono.CSharp.Expression DoResolve(Mono.CSharp.ResolveContext ec) { return default(Mono.CSharp.Expression); }
    public override Mono.CSharp.Expression DoResolveLValue(Mono.CSharp.ResolveContext ec, Mono.CSharp.Expression rhs) { return default(Mono.CSharp.Expression); }
    public override bool Equals(object obj) { return default(bool); }
    public override void FlowAnalysis(Mono.CSharp.FlowAnalysisContext fc) { }
    public override int GetHashCode() { return default(int); }
    public override Mono.CSharp.HoistedVariable GetHoistedVariable(Mono.CSharp.AnonymousExpression ae) { return default(Mono.CSharp.HoistedVariable); }
    public override void SetHasAddressTaken() { }
    public override string ToString() { return default(string); }
  }
  public partial class LocatedToken {
    public int column;
    public Mono.CSharp.SourceFile file;
    public int row;
    public string value;
    public LocatedToken() { }
    public LocatedToken(string value, Mono.CSharp.Location loc) { }
    public Mono.CSharp.Location Location { get { return default(Mono.CSharp.Location); } }
    public string Value { get { return default(string); } }
    public override string ToString() { return default(string); }
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct Location : System.IEquatable<Mono.CSharp.Location> {
    public static bool InEmacs;
    public static readonly Mono.CSharp.Location Null;
    public Location(Mono.CSharp.SourceFile file, int row, int column) { throw new System.NotImplementedException(); }
    public int Column { get { return default(int); } }
    public int File { get { return default(int); } }
    public bool IsNull { get { return default(bool); } }
    public string Name { get { return default(string); } }
    public string NameFullPath { get { return default(string); } }
    public int Row { get { return default(int); } }
    public Mono.CSharp.SourceFile SourceFile { get { return default(Mono.CSharp.SourceFile); } }
    public static void AddFile(Mono.CSharp.SourceFile file) { }
    public bool Equals(Mono.CSharp.Location other) { return default(bool); }
    public static void Initialize(System.Collections.Generic.List<Mono.CSharp.SourceFile> files) { }
    public static Mono.CSharp.Location operator -(Mono.CSharp.Location loc, int columns) { return default(Mono.CSharp.Location); }
    public static void Reset() { }
    public override string ToString() { return default(string); }
    public string ToStringFullName() { return default(string); }
  }
  public partial class LocationsBag {
    public LocationsBag() { }
    [System.Diagnostics.ConditionalAttribute("FULL_AST")]
    public void AddLocation(object element, params Mono.CSharp.Location[] locations) { }
    [System.Diagnostics.ConditionalAttribute("FULL_AST")]
    public void AddMember(Mono.CSharp.MemberCore member, System.Collections.Generic.IList<Mono.CSharp.Tuple<Mono.CSharp.Modifiers, Mono.CSharp.Location>> modLocations) { }
    [System.Diagnostics.ConditionalAttribute("FULL_AST")]
    public void AddMember(Mono.CSharp.MemberCore member, System.Collections.Generic.IList<Mono.CSharp.Tuple<Mono.CSharp.Modifiers, Mono.CSharp.Location>> modLocations, Mono.CSharp.Location location) { }
    [System.Diagnostics.ConditionalAttribute("FULL_AST")]
    public void AddMember(Mono.CSharp.MemberCore member, System.Collections.Generic.IList<Mono.CSharp.Tuple<Mono.CSharp.Modifiers, Mono.CSharp.Location>> modLocations, params Mono.CSharp.Location[] locations) { }
    [System.Diagnostics.ConditionalAttribute("FULL_AST")]
    public void AddMember(Mono.CSharp.MemberCore member, System.Collections.Generic.IList<Mono.CSharp.Tuple<Mono.CSharp.Modifiers, Mono.CSharp.Location>> modLocations, System.Collections.Generic.List<Mono.CSharp.Location> locations) { }
    [System.Diagnostics.ConditionalAttribute("FULL_AST")]
    public void AddStatement(object element, params Mono.CSharp.Location[] locations) { }
    [System.Diagnostics.ConditionalAttribute("FULL_AST")]
    public void AppendTo(object element, Mono.CSharp.Location location) { }
    [System.Diagnostics.ConditionalAttribute("FULL_AST")]
    public void AppendToMember(Mono.CSharp.MemberCore existing, params Mono.CSharp.Location[] locations) { }
    public System.Collections.Generic.List<Mono.CSharp.Location> GetLocations(object element) { return default(System.Collections.Generic.List<Mono.CSharp.Location>); }
    public Mono.CSharp.LocationsBag.MemberLocations GetMemberLocation(Mono.CSharp.MemberCore element) { return default(Mono.CSharp.LocationsBag.MemberLocations); }
    [System.Diagnostics.ConditionalAttribute("FULL_AST")]
    public void InsertLocation(object element, int index, Mono.CSharp.Location location) { }
    public partial class MemberLocations {
      public readonly System.Collections.Generic.IList<Mono.CSharp.Tuple<Mono.CSharp.Modifiers, Mono.CSharp.Location>> Modifiers;
      public MemberLocations(System.Collections.Generic.IList<Mono.CSharp.Tuple<Mono.CSharp.Modifiers, Mono.CSharp.Location>> mods) { }
      public MemberLocations(System.Collections.Generic.IList<Mono.CSharp.Tuple<Mono.CSharp.Modifiers, Mono.CSharp.Location>> mods, Mono.CSharp.Location loc) { }
      public MemberLocations(System.Collections.Generic.IList<Mono.CSharp.Tuple<Mono.CSharp.Modifiers, Mono.CSharp.Location>> mods, Mono.CSharp.Location[] locs) { }
      public MemberLocations(System.Collections.Generic.IList<Mono.CSharp.Tuple<Mono.CSharp.Modifiers, Mono.CSharp.Location>> mods, System.Collections.Generic.List<Mono.CSharp.Location> locs) { }
      public int Count { get { return default(int); } }
      public Mono.CSharp.Location this[int index] { get { return default(Mono.CSharp.Location); } }
      public void AddLocations(Mono.CSharp.Location loc) { }
      public void AddLocations(params Mono.CSharp.Location[] additional) { }
    }
  }
  public partial class Lock : Mono.CSharp.TryFinallyBlock {
    public Lock(Mono.CSharp.Expression expr, Mono.CSharp.Statement stmt, Mono.CSharp.Location loc) : base (default(Mono.CSharp.Statement), default(Mono.CSharp.Location)) { }
    public Mono.CSharp.Expression Expr { get { return default(Mono.CSharp.Expression); } }
    public override object Accept(Mono.CSharp.StructuralVisitor visitor) { return default(object); }
    protected override void CloneTo(Mono.CSharp.CloneContext clonectx, Mono.CSharp.Statement t) { }
    protected override bool DoFlowAnalysis(Mono.CSharp.FlowAnalysisContext fc) { return default(bool); }
    public override void EmitFinallyBody(Mono.CSharp.EmitContext ec) { }
    protected override void EmitTryBody(Mono.CSharp.EmitContext ec) { }
    protected override void EmitTryBodyPrepare(Mono.CSharp.EmitContext ec) { }
    public override bool Resolve(Mono.CSharp.BlockContext ec) { return default(bool); }
  }
  public partial class LongConstant : Mono.CSharp.IntegralConstant {
    public readonly long Value;
    public LongConstant(Mono.CSharp.BuiltinTypes types, long v, Mono.CSharp.Location loc) : base (default(Mono.CSharp.TypeSpec), default(Mono.CSharp.Location)) { }
    public LongConstant(Mono.CSharp.TypeSpec type, long v, Mono.CSharp.Location loc) : base (default(Mono.CSharp.TypeSpec), default(Mono.CSharp.Location)) { }
    public override bool IsDefaultValue { get { return default(bool); } }
    public override bool IsNegative { get { return default(bool); } }
    public override bool IsOneInteger { get { return default(bool); } }
    public override bool IsZeroInteger { get { return default(bool); } }
    public override Mono.CSharp.Constant ConvertExplicitly(bool in_checked_context, Mono.CSharp.TypeSpec target_type) { return default(Mono.CSharp.Constant); }
    public override Mono.CSharp.Constant ConvertImplicitly(Mono.CSharp.TypeSpec type) { return default(Mono.CSharp.Constant); }
    public override void Emit(Mono.CSharp.EmitContext ec) { }
    public override void EncodeAttributeValue(Mono.CSharp.IMemberContext rc, Mono.CSharp.AttributeEncoder enc, Mono.CSharp.TypeSpec targetType, Mono.CSharp.TypeSpec parameterType) { }
    public override object GetValue() { return default(object); }
    public override long GetValueAsLong() { return default(long); }
    public override Mono.CSharp.Constant Increment() { return default(Mono.CSharp.Constant); }
  }
  public partial class LongLiteral : Mono.CSharp.LongConstant, Mono.CSharp.ILiteralConstant {
    public LongLiteral(Mono.CSharp.BuiltinTypes types, long l, Mono.CSharp.Location loc) : base (default(Mono.CSharp.BuiltinTypes), default(long), default(Mono.CSharp.Location)) { }
    public override bool IsLiteral { get { return default(bool); } }
    public override object Accept(Mono.CSharp.StructuralVisitor visitor) { return default(object); }
  }
  public enum LookupMode {
    IgnoreAccessibility = 2,
    NameOf = 3,
    Normal = 0,
    Probing = 1,
  }
  public abstract partial class LoopStatement : Mono.CSharp.Statement {
    protected LoopStatement(Mono.CSharp.Statement statement) { }
    public Mono.CSharp.Statement Statement { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(Mono.CSharp.Statement); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public virtual void AddEndDefiniteAssignment(Mono.CSharp.FlowAnalysisContext fc) { }
    public override bool Resolve(Mono.CSharp.BlockContext bc) { return default(bool); }
    public virtual void SetEndReachable() { }
    public virtual void SetIteratorReachable() { }
  }
  public partial class MakeRefExpr : Mono.CSharp.ShimExpression {
    public MakeRefExpr(Mono.CSharp.Expression expr, Mono.CSharp.Location loc) : base (default(Mono.CSharp.Expression)) { }
    public override object Accept(Mono.CSharp.StructuralVisitor visitor) { return default(object); }
    public override bool ContainsEmitWithAwait() { return default(bool); }
    protected override Mono.CSharp.Expression DoResolve(Mono.CSharp.ResolveContext rc) { return default(Mono.CSharp.Expression); }
    public override void Emit(Mono.CSharp.EmitContext ec) { }
  }
  public partial class MemberAccess : Mono.CSharp.ATypeNameExpression {
    protected Mono.CSharp.Expression expr;
    public MemberAccess(Mono.CSharp.Expression expr, string id) : base (default(string), default(Mono.CSharp.Location)) { }
    public MemberAccess(Mono.CSharp.Expression expr, string identifier, Mono.CSharp.Location loc) : base (default(string), default(Mono.CSharp.Location)) { }
    public MemberAccess(Mono.CSharp.Expression expr, string identifier, Mono.CSharp.TypeArguments args, Mono.CSharp.Location loc) : base (default(string), default(Mono.CSharp.Location)) { }
    public MemberAccess(Mono.CSharp.Expression expr, string identifier, int arity, Mono.CSharp.Location loc) : base (default(string), default(Mono.CSharp.Location)) { }
    public Mono.CSharp.Expression LeftExpression { get { return default(Mono.CSharp.Expression); } }
    public override Mono.CSharp.Location StartLocation { get { return default(Mono.CSharp.Location); } }
    public override object Accept(Mono.CSharp.StructuralVisitor visitor) { return default(object); }
    protected override void CloneTo(Mono.CSharp.CloneContext clonectx, Mono.CSharp.Expression t) { }
    protected override Mono.CSharp.Expression DoResolve(Mono.CSharp.ResolveContext rc) { return default(Mono.CSharp.Expression); }
    public override Mono.CSharp.Expression DoResolveLValue(Mono.CSharp.ResolveContext rc, Mono.CSharp.Expression rhs) { return default(Mono.CSharp.Expression); }
    public void Error_IdentifierNotFound(Mono.CSharp.IMemberContext rc, Mono.CSharp.TypeSpec expr_type) { }
    protected override void Error_InvalidExpressionStatement(Mono.CSharp.Report report, Mono.CSharp.Location loc) { }
    protected virtual void Error_OperatorCannotBeApplied(Mono.CSharp.ResolveContext rc, Mono.CSharp.TypeSpec type) { }
    protected override void Error_TypeDoesNotContainDefinition(Mono.CSharp.ResolveContext ec, Mono.CSharp.TypeSpec type, string name) { }
    public override string GetSignatureForError() { return default(string); }
    public override bool HasConditionalAccess() { return default(bool); }
    public static bool IsValidDotExpression(Mono.CSharp.TypeSpec type) { return default(bool); }
    public override Mono.CSharp.Expression LookupNameExpression(Mono.CSharp.ResolveContext rc, Mono.CSharp.Expression.MemberLookupRestrictions restrictions) { return default(Mono.CSharp.Expression); }
    public override Mono.CSharp.FullNamedExpression ResolveAsTypeOrNamespace(Mono.CSharp.IMemberContext rc, bool allowUnboundTypeArguments) { return default(Mono.CSharp.FullNamedExpression); }
  }
  public abstract partial class MemberBase : Mono.CSharp.MemberCore {
    protected Mono.CSharp.TypeSpec member_type;
    public new Mono.CSharp.TypeDefinition Parent;
    protected Mono.CSharp.FullNamedExpression type_expr;
    protected MemberBase(Mono.CSharp.TypeDefinition parent, Mono.CSharp.FullNamedExpression type, Mono.CSharp.Modifiers mod, Mono.CSharp.Modifiers allowed_mod, Mono.CSharp.Modifiers def_mod, Mono.CSharp.MemberName name, Mono.CSharp.Attributes attrs) : base (default(Mono.CSharp.TypeContainer), default(Mono.CSharp.MemberName), default(Mono.CSharp.Attributes)) { }
    public Mono.CSharp.TypeSpec MemberType { get { return default(Mono.CSharp.TypeSpec); } }
    public Mono.CSharp.FullNamedExpression TypeExpression { get { return default(Mono.CSharp.FullNamedExpression); } }
    protected virtual bool CheckBase() { return default(bool); }
    public override bool Define() { return default(bool); }
    protected virtual void DoMemberTypeDependentChecks() { }
    protected virtual void DoMemberTypeIndependentChecks() { }
    public override string GetSignatureForDocumentation() { return default(string); }
    protected void IsTypePermitted() { }
    protected virtual bool ResolveMemberType() { return default(bool); }
  }
  public partial class MemberCache {
    public static readonly Mono.CSharp.MemberCache Empty;
    public static readonly string IndexerNameAlias;
    public MemberCache() { }
    public MemberCache(Mono.CSharp.MemberCache cache) { }
    public MemberCache(Mono.CSharp.TypeContainer container) { }
    public MemberCache(int capacity) { }
    public void AddBaseType(Mono.CSharp.TypeSpec baseType) { }
    public void AddInterface(Mono.CSharp.TypeSpec iface) { }
    public void AddMember(Mono.CSharp.InterfaceMemberBase imb, string exlicitName, Mono.CSharp.MemberSpec ms) { }
    public void AddMember(Mono.CSharp.MemberSpec ms) { }
    public void AddMemberImported(Mono.CSharp.MemberSpec ms) { }
    public bool CheckExistingMembersOverloads(Mono.CSharp.MemberCore member, Mono.CSharp.AParametersCollection parameters) { return default(bool); }
    public bool CheckExistingMembersOverloads(Mono.CSharp.MemberCore member, string name, Mono.CSharp.AParametersCollection parameters) { return default(bool); }
    public static Mono.CSharp.MemberSpec FindBaseMember(Mono.CSharp.MemberCore member, out Mono.CSharp.MemberSpec bestCandidate, ref bool overrides) { bestCandidate = default(Mono.CSharp.MemberSpec); return default(Mono.CSharp.MemberSpec); }
    public System.Collections.Generic.List<Mono.CSharp.MethodSpec> FindExtensionMethods(Mono.CSharp.IMemberContext invocationContext, string name, int arity) { return default(System.Collections.Generic.List<Mono.CSharp.MethodSpec>); }
    public static Mono.CSharp.MemberSpec FindMember(Mono.CSharp.TypeSpec container, Mono.CSharp.MemberFilter filter, Mono.CSharp.BindingRestriction restrictions) { return default(Mono.CSharp.MemberSpec); }
    public static System.Collections.Generic.IList<Mono.CSharp.MemberSpec> FindMembers(Mono.CSharp.TypeSpec container, string name, bool declaredOnlyClass) { return default(System.Collections.Generic.IList<Mono.CSharp.MemberSpec>); }
    public static Mono.CSharp.TypeSpec FindNestedType(Mono.CSharp.TypeSpec container, string name, int arity) { return default(Mono.CSharp.TypeSpec); }
    public static System.Collections.Generic.List<Mono.CSharp.FieldSpec> GetAllFieldsForDefiniteAssignment(Mono.CSharp.TypeSpec container) { return default(System.Collections.Generic.List<Mono.CSharp.FieldSpec>); }
    public static System.Collections.Generic.IList<Mono.CSharp.MemberSpec> GetCompletitionMembers(Mono.CSharp.IMemberContext ctx, Mono.CSharp.TypeSpec container, string name) { return default(System.Collections.Generic.IList<Mono.CSharp.MemberSpec>); }
    public static System.Collections.Generic.List<Mono.CSharp.MethodSpec> GetInterfaceMethods(Mono.CSharp.TypeSpec iface) { return default(System.Collections.Generic.List<Mono.CSharp.MethodSpec>); }
    public static T GetMember<T>(Mono.CSharp.TypeSpec container, T spec) where T : Mono.CSharp.MemberSpec { return default(T); }
    public static System.Collections.Generic.IList<Mono.CSharp.MethodSpec> GetNotImplementedAbstractMethods(Mono.CSharp.TypeSpec type) { return default(System.Collections.Generic.IList<Mono.CSharp.MethodSpec>); }
    public static System.Collections.Generic.IList<Mono.CSharp.MemberSpec> GetUserOperator(Mono.CSharp.TypeSpec container, Mono.CSharp.Operator.OpType op, bool declaredOnly) { return default(System.Collections.Generic.IList<Mono.CSharp.MemberSpec>); }
    public void InflateMembers(Mono.CSharp.MemberCache cacheToInflate, Mono.CSharp.TypeSpec inflatedType, Mono.CSharp.TypeParameterInflator inflator) { }
    public void InflateTypes(Mono.CSharp.MemberCache inflated_cache, Mono.CSharp.TypeParameterInflator inflator) { }
    public void RemoveHiddenMembers(Mono.CSharp.TypeSpec container) { }
    public void VerifyClsCompliance(Mono.CSharp.TypeSpec container, Mono.CSharp.Report report) { }
  }
  [System.Diagnostics.DebuggerDisplayAttribute("{GetSignatureForError()}")]
  public abstract partial class MemberCore : Mono.CSharp.Attributable, Mono.CSharp.IMemberContext, Mono.CSharp.IMemberDefinition, Mono.CSharp.IModuleContext {
    protected string comment;
    public Mono.CSharp.TypeContainer Parent;
    protected MemberCore(Mono.CSharp.TypeContainer parent, Mono.CSharp.MemberName name, Mono.CSharp.Attributes attrs) { }
    public System.Nullable<System.Boolean> CLSAttributeValue { get { return default(System.Nullable<System.Boolean>); } }
    public virtual Mono.CSharp.CompilerContext Compiler { get { return default(Mono.CSharp.CompilerContext); } }
    public Mono.CSharp.MemberCore CurrentMemberDefinition { get { return default(Mono.CSharp.MemberCore); } }
    public virtual Mono.CSharp.TypeSpec CurrentType { get { return default(Mono.CSharp.TypeSpec); } }
    public virtual Mono.CSharp.TypeParameters CurrentTypeParameters { get { return default(Mono.CSharp.TypeParameters); } }
    public virtual string DocComment { get { return default(string); } set { } }
    public abstract string DocCommentHeader { get; }
    protected bool HasClsCompliantAttribute { get { return default(bool); } }
    public bool IsAvailableForReuse { get { return default(bool); } set { } }
    public bool IsCompilerGenerated { get { return default(bool); } }
    public bool IsImported { get { return default(bool); } }
    public bool IsObsolete { get { return default(bool); } }
    public bool IsStatic { get { return default(bool); } }
    public bool IsUnsafe { get { return default(bool); } }
    public virtual bool IsUsed { get { return default(bool); } }
    public Mono.CSharp.Location Location { get { return default(Mono.CSharp.Location); } }
    public Mono.CSharp.MemberName MemberName { get { return default(Mono.CSharp.MemberName); } }
    public Mono.CSharp.Modifiers ModFlags { get { return default(Mono.CSharp.Modifiers); } set { } }
    public virtual Mono.CSharp.ModuleContainer Module { get { return default(Mono.CSharp.ModuleContainer); } }
    string Mono.CSharp.IMemberDefinition.Name { get { return default(string); } }
    protected Mono.CSharp.Report Report { get { return default(Mono.CSharp.Report); } }
    public virtual void Accept(Mono.CSharp.StructuralVisitor visitor) { }
    protected bool CheckAbstractAndExtern(bool has_block) { return default(bool); }
    public virtual void CheckObsoleteness(Mono.CSharp.Location loc) { }
    protected void CheckProtectedModifier() { }
    public virtual System.String[] ConditionalConditions() { return default(System.String[]); }
    public abstract bool Define();
    public virtual void Emit() { }
    public virtual bool EnableOverloadChecks(Mono.CSharp.MemberCore overload) { return default(bool); }
    public virtual System.ObsoleteAttribute GetAttributeObsolete() { return default(System.ObsoleteAttribute); }
    public virtual string GetCallerMemberName() { return default(string); }
    public virtual void GetCompletionStartingWith(string prefix, System.Collections.Generic.List<System.String> results) { }
    public abstract string GetSignatureForDocumentation();
    public virtual string GetSignatureForError() { return default(string); }
    public bool IsAccessibleAs(Mono.CSharp.TypeSpec p) { return default(bool); }
    public override bool IsClsComplianceRequired() { return default(bool); }
    public bool IsExposedFromAssembly() { return default(bool); }
    public Mono.CSharp.ExtensionMethodCandidates LookupExtensionMethod(Mono.CSharp.TypeSpec extensionType, string name, int arity) { return default(Mono.CSharp.ExtensionMethodCandidates); }
    public virtual Mono.CSharp.FullNamedExpression LookupNamespaceAlias(string name) { return default(Mono.CSharp.FullNamedExpression); }
    public virtual Mono.CSharp.FullNamedExpression LookupNamespaceOrType(string name, int arity, Mono.CSharp.LookupMode mode, Mono.CSharp.Location loc) { return default(Mono.CSharp.FullNamedExpression); }
    public virtual void SetConstraints(System.Collections.Generic.List<Mono.CSharp.Constraints> constraints_list) { }
    public void SetIsAssigned() { }
    public void SetIsUsed() { }
    protected virtual void SetMemberName(Mono.CSharp.MemberName new_name) { }
    protected virtual bool VerifyClsCompliance() { return default(bool); }
    protected void Warning_IdentifierNotCompliant() { }
    public virtual void WriteDebugSymbol(Mono.CompilerServices.SymbolWriter.MonoSymbolFile file) { }
    [System.FlagsAttribute]
    public enum Flags {
      CanBeReused = 262144,
      CloseTypeCreated = 16,
      ClsCompliance_Undetected = 4,
      ClsCompliant = 8,
      ClsCompliantAttributeFalse = 128,
      Excluded = 512,
      Excluded_Undetected = 256,
      HasClsCompliantAttribute = 64,
      HasCompliantAttribute_Undetected = 32,
      HasExplicitLayout = 8192,
      HasInstanceConstructor = 65536,
      HasStructLayout = 32768,
      HasUserOperators = 131072,
      InterfacesExpanded = 524288,
      IsAssigned = 4096,
      IsUsed = 2048,
      MethodOverloadsExist = 1024,
      Obsolete = 2,
      Obsolete_Undetected = 1,
      PartialDefinitionExists = 16384,
    }
  }
  public abstract partial class MemberExpr : Mono.CSharp.Expression, Mono.CSharp.OverloadResolver.IInstanceQualifier {
    protected bool conditional_access_receiver;
    public Mono.CSharp.Expression InstanceExpression;
    protected MemberExpr() { }
    public bool ConditionalAccess { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    protected abstract Mono.CSharp.TypeSpec DeclaringType { get; }
    public bool IsBase { get { return default(bool); } }
    public abstract bool IsInstance { get; }
    public abstract bool IsStatic { get; }
    public abstract string KindName { get; }
    Mono.CSharp.TypeSpec Mono.CSharp.OverloadResolver.IInstanceQualifier.InstanceType { get { return default(Mono.CSharp.TypeSpec); } }
    public abstract string Name { get; }
    protected Mono.CSharp.MethodSpec CandidateToBaseOverride(Mono.CSharp.ResolveContext rc, Mono.CSharp.MethodSpec method) { return default(Mono.CSharp.MethodSpec); }
    protected void CheckProtectedMemberAccess(Mono.CSharp.ResolveContext rc, Mono.CSharp.MemberSpec member) { }
    public static bool CheckProtectedMemberAccess<T>(Mono.CSharp.ResolveContext rc, T member, Mono.CSharp.TypeSpec qualifier) where T : Mono.CSharp.MemberSpec { return default(bool); }
    public override bool ContainsEmitWithAwait() { return default(bool); }
    protected void DoBestMemberChecks<T>(Mono.CSharp.ResolveContext rc, T member) where T : Mono.CSharp.MemberSpec, Mono.CSharp.IInterfaceMemberSpec { }
    protected void EmitInstance(Mono.CSharp.EmitContext ec, bool prepare_for_load) { }
    protected virtual void Error_CannotCallAbstractBase(Mono.CSharp.ResolveContext rc, string name) { }
    public static void Error_ProtectedMemberAccess(Mono.CSharp.ResolveContext rc, Mono.CSharp.MemberSpec member, Mono.CSharp.TypeSpec qualifier, Mono.CSharp.Location loc) { }
    public override void FlowAnalysis(Mono.CSharp.FlowAnalysisContext fc) { }
    public override bool HasConditionalAccess() { return default(bool); }
    bool Mono.CSharp.OverloadResolver.IInstanceQualifier.CheckProtectedMemberAccess(Mono.CSharp.ResolveContext rc, Mono.CSharp.MemberSpec member) { return default(bool); }
    protected void ResolveConditionalAccessReceiver(Mono.CSharp.ResolveContext rc) { }
    public bool ResolveInstanceExpression(Mono.CSharp.ResolveContext rc, Mono.CSharp.Expression rhs) { return default(bool); }
    public virtual Mono.CSharp.MemberExpr ResolveMemberAccess(Mono.CSharp.ResolveContext ec, Mono.CSharp.Expression left, Mono.CSharp.SimpleName original) { return default(Mono.CSharp.MemberExpr); }
    public abstract void SetTypeArguments(Mono.CSharp.ResolveContext ec, Mono.CSharp.TypeArguments ta);
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct MemberFilter : System.IEquatable<Mono.CSharp.MemberSpec> {
    public readonly int Arity;
    public readonly Mono.CSharp.MemberKind Kind;
    public readonly Mono.CSharp.TypeSpec MemberType;
    public readonly string Name;
    public readonly Mono.CSharp.AParametersCollection Parameters;
    public MemberFilter(Mono.CSharp.MethodSpec m) { throw new System.NotImplementedException(); }
    public MemberFilter(string name, int arity, Mono.CSharp.MemberKind kind, Mono.CSharp.AParametersCollection param, Mono.CSharp.TypeSpec type) { throw new System.NotImplementedException(); }
    public static Mono.CSharp.MemberFilter Constructor(Mono.CSharp.AParametersCollection param) { return default(Mono.CSharp.MemberFilter); }
    public bool Equals(Mono.CSharp.MemberSpec other) { return default(bool); }
    public static Mono.CSharp.MemberFilter Field(string name, Mono.CSharp.TypeSpec type) { return default(Mono.CSharp.MemberFilter); }
    public static Mono.CSharp.MemberFilter Method(string name, int arity, Mono.CSharp.AParametersCollection param, Mono.CSharp.TypeSpec type) { return default(Mono.CSharp.MemberFilter); }
    public static Mono.CSharp.MemberFilter Property(string name, Mono.CSharp.TypeSpec type) { return default(Mono.CSharp.MemberFilter); }
  }
  [System.FlagsAttribute]
  public enum MemberKind {
    ArrayType = 524288,
    Class = 2048,
    Constructor = 1,
    Delegate = 8192,
    Destructor = 128,
    Enum = 16384,
    Event = 2,
    Field = 4,
    GenericMask = 47112,
    Indexer = 32,
    Interface = 32768,
    InternalCompilerType = 2097152,
    MaskType = 63743,
    Method = 8,
    MissingType = 4194304,
    Namespace = 16777216,
    NestedMask = 63488,
    Operator = 64,
    PointerType = 1048576,
    Property = 16,
    Struct = 4096,
    TypeParameter = 65536,
    Void = 8388608,
  }
  [System.Diagnostics.DebuggerDisplayAttribute("{GetSignatureForError()}")]
  public partial class MemberName {
    public readonly Mono.CSharp.FullNamedExpression ExplicitInterface;
    public readonly Mono.CSharp.MemberName Left;
    public readonly Mono.CSharp.Location Location;
    public readonly string Name;
    public static readonly Mono.CSharp.MemberName Null;
    public Mono.CSharp.TypeParameters TypeParameters;
    public MemberName(Mono.CSharp.MemberName left, Mono.CSharp.MemberName right) { }
    public MemberName(Mono.CSharp.MemberName left, string name, Mono.CSharp.FullNamedExpression explicitInterface, Mono.CSharp.Location loc) { }
    public MemberName(Mono.CSharp.MemberName left, string name, Mono.CSharp.Location loc) { }
    public MemberName(string name) { }
    public MemberName(string name, Mono.CSharp.Location loc) { }
    public MemberName(string name, Mono.CSharp.TypeParameters tparams, Mono.CSharp.FullNamedExpression explicitInterface, Mono.CSharp.Location loc) { }
    public MemberName(string name, Mono.CSharp.TypeParameters tparams, Mono.CSharp.Location loc) { }
    public int Arity { get { return default(int); } }
    public string Basename { get { return default(string); } }
    public bool IsGeneric { get { return default(bool); } }
    public void CreateMetadataName(System.Text.StringBuilder sb) { }
    public bool Equals(Mono.CSharp.MemberName other) { return default(bool); }
    public override bool Equals(object other) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public string GetSignatureForDocumentation() { return default(string); }
    public string GetSignatureForError() { return default(string); }
    public static string MakeName(string name, Mono.CSharp.TypeParameters args) { return default(string); }
  }
  public abstract partial class MemberSpec {
    protected Mono.CSharp.TypeSpec declaringType;
    protected Mono.CSharp.IMemberDefinition definition;
    public readonly Mono.CSharp.MemberKind Kind;
    protected Mono.CSharp.Modifiers modifiers;
    protected const Mono.CSharp.MemberSpec.StateFlags SharedStateFlags = 127;
    public Mono.CSharp.MemberSpec.StateFlags state;
    protected MemberSpec(Mono.CSharp.MemberKind kind, Mono.CSharp.TypeSpec declaringType, Mono.CSharp.IMemberDefinition definition, Mono.CSharp.Modifiers modifiers) { }
    public virtual int Arity { get { return default(int); } }
    public Mono.CSharp.TypeSpec DeclaringType { get { return default(Mono.CSharp.TypeSpec); } set { } }
    public bool IsAbstract { get { return default(bool); } }
    public bool IsAccessor { get { return default(bool); } set { } }
    public bool IsGeneric { get { return default(bool); } set { } }
    public bool IsNotCSharpCompatible { get { return default(bool); } set { } }
    public bool IsPrivate { get { return default(bool); } }
    public bool IsPublic { get { return default(bool); } }
    public bool IsStatic { get { return default(bool); } }
    public Mono.CSharp.IMemberDefinition MemberDefinition { get { return default(Mono.CSharp.IMemberDefinition); } }
    public Mono.CSharp.Modifiers Modifiers { get { return default(Mono.CSharp.Modifiers); } set { } }
    public virtual string Name { get { return default(string); } }
    public virtual System.ObsoleteAttribute GetAttributeObsolete() { return default(System.ObsoleteAttribute); }
    public System.Collections.Generic.List<Mono.CSharp.MissingTypeSpecReference> GetMissingDependencies() { return default(System.Collections.Generic.List<Mono.CSharp.MissingTypeSpecReference>); }
    public System.Collections.Generic.List<Mono.CSharp.MissingTypeSpecReference> GetMissingDependencies(Mono.CSharp.MemberSpec caller) { return default(System.Collections.Generic.List<Mono.CSharp.MissingTypeSpecReference>); }
    public virtual string GetSignatureForDocumentation() { return default(string); }
    public virtual string GetSignatureForError() { return default(string); }
    public virtual Mono.CSharp.MemberSpec InflateMember(Mono.CSharp.TypeParameterInflator inflator) { return default(Mono.CSharp.MemberSpec); }
    public bool IsAccessible(Mono.CSharp.IMemberContext ctx) { return default(bool); }
    public bool IsCLSCompliant() { return default(bool); }
    public bool IsConditionallyExcluded(Mono.CSharp.IMemberContext ctx) { return default(bool); }
    protected virtual bool IsNotCLSCompliant(out bool attrValue) { attrValue = default(bool); return default(bool); }
    public abstract System.Collections.Generic.List<Mono.CSharp.MissingTypeSpecReference> ResolveMissingDependencies(Mono.CSharp.MemberSpec caller);
    public override string ToString() { return default(string); }
    [System.FlagsAttribute]
    public enum StateFlags {
      CLSCompliant = 8,
      CLSCompliant_Undetected = 4,
      ConstraintsChecked = 128,
      GenericIterateInterface = 2097152,
      GenericTask = 4194304,
      HasDynamicElement = 64,
      InflatedExpressionType = 524288,
      InflatedNullableType = 1048576,
      InterfacesExpanded = 65536,
      InterfacesImported = 8388608,
      IsAccessor = 512,
      IsGeneric = 1024,
      IsNotCSharpCompatible = 131072,
      MissingDependency = 32,
      MissingDependency_Undetected = 16,
      Obsolete = 2,
      Obsolete_Undetected = 1,
      PendingBaseTypeInflate = 32768,
      PendingMakeMethod = 8192,
      PendingMemberCacheMembers = 16384,
      PendingMetaInflate = 4096,
      SpecialRuntimeType = 262144,
    }
  }
  public abstract partial class MetadataImporter {
    protected readonly System.Collections.Generic.Dictionary<System.Reflection.Assembly, Mono.CSharp.IAssemblyDefinition> assembly_2_definition;
    protected readonly System.Collections.Generic.Dictionary<System.Type, Mono.CSharp.TypeSpec> compiled_types;
    public static readonly string CompilerServicesNamespace;
    protected readonly System.Collections.Generic.Dictionary<System.Type, Mono.CSharp.TypeSpec> import_cache;
    protected readonly Mono.CSharp.ModuleContainer module;
    protected MetadataImporter(Mono.CSharp.ModuleContainer module) { }
    public System.Collections.Generic.ICollection<Mono.CSharp.IAssemblyDefinition> Assemblies { get { return default(System.Collections.Generic.ICollection<Mono.CSharp.IAssemblyDefinition>); } }
    public bool IgnorePrivateMembers { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public abstract void AddCompiledType(System.Reflection.Emit.TypeBuilder builder, Mono.CSharp.TypeSpec spec);
    public Mono.CSharp.EventSpec CreateEvent(System.Reflection.EventInfo ei, Mono.CSharp.TypeSpec declaringType, Mono.CSharp.MethodSpec add, Mono.CSharp.MethodSpec remove) { return default(Mono.CSharp.EventSpec); }
    public Mono.CSharp.FieldSpec CreateField(System.Reflection.FieldInfo fi, Mono.CSharp.TypeSpec declaringType) { return default(Mono.CSharp.FieldSpec); }
    public Mono.CSharp.MethodSpec CreateMethod(System.Reflection.MethodBase mb, Mono.CSharp.TypeSpec declaringType) { return default(Mono.CSharp.MethodSpec); }
    public Mono.CSharp.TypeSpec CreateNestedType(System.Type type, Mono.CSharp.TypeSpec declaringType) { return default(Mono.CSharp.TypeSpec); }
    public Mono.CSharp.PropertySpec CreateProperty(System.Reflection.PropertyInfo pi, Mono.CSharp.TypeSpec declaringType, Mono.CSharp.MethodSpec @get, Mono.CSharp.MethodSpec @set) { return default(Mono.CSharp.PropertySpec); }
    public Mono.CSharp.TypeSpec CreateType(System.Type type) { return default(Mono.CSharp.TypeSpec); }
    protected Mono.CSharp.TypeSpec CreateType(System.Type type, Mono.CSharp.TypeSpec declaringType, Mono.CSharp.MetadataImporter.DynamicTypeReader dtype, bool canImportBaseType) { return default(Mono.CSharp.TypeSpec); }
    protected abstract Mono.CSharp.MemberKind DetermineKindFromBaseType(System.Type baseType);
    public Mono.CSharp.IAssemblyDefinition GetAssemblyDefinition(System.Reflection.Assembly assembly) { return default(Mono.CSharp.IAssemblyDefinition); }
    public static bool HasAttribute(System.Collections.Generic.IList<System.Reflection.CustomAttributeData> attributesData, string attrName, string attrNamespace) { return default(bool); }
    protected abstract bool HasVolatileModifier(System.Type[] modifiers);
    public Mono.CSharp.TypeSpec ImportType(System.Type type) { return default(Mono.CSharp.TypeSpec); }
    public void ImportTypeBase(System.Type type) { }
    protected void ImportTypes(System.Type[] types, Mono.CSharp.Namespace targetNamespace, bool importExtensionTypes) { }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    protected partial struct DynamicTypeReader {
      public int Position;
      public DynamicTypeReader(object provider) { throw new System.NotImplementedException(); }
      public bool HasDynamicAttribute() { return default(bool); }
      public bool IsDynamicObject() { return default(bool); }
    }
  }
  public partial class Method : Mono.CSharp.MethodOrOperator, Mono.CSharp.IGenericMethodDefinition, Mono.CSharp.IMemberDefinition, Mono.CSharp.IMethodDefinition {
    public Method(Mono.CSharp.TypeDefinition parent, Mono.CSharp.FullNamedExpression return_type, Mono.CSharp.Modifiers mod, Mono.CSharp.MemberName name, Mono.CSharp.ParametersCompiled parameters, Mono.CSharp.Attributes attrs) : base (default(Mono.CSharp.TypeDefinition), default(Mono.CSharp.FullNamedExpression), default(Mono.CSharp.Modifiers), default(Mono.CSharp.Modifiers), default(Mono.CSharp.MemberName), default(Mono.CSharp.Attributes), default(Mono.CSharp.ParametersCompiled)) { }
    protected Method(Mono.CSharp.TypeDefinition parent, Mono.CSharp.FullNamedExpression return_type, Mono.CSharp.Modifiers mod, Mono.CSharp.Modifiers amod, Mono.CSharp.MemberName name, Mono.CSharp.ParametersCompiled parameters, Mono.CSharp.Attributes attrs) : base (default(Mono.CSharp.TypeDefinition), default(Mono.CSharp.FullNamedExpression), default(Mono.CSharp.Modifiers), default(Mono.CSharp.Modifiers), default(Mono.CSharp.MemberName), default(Mono.CSharp.Attributes), default(Mono.CSharp.ParametersCompiled)) { }
    public override Mono.CSharp.TypeParameters CurrentTypeParameters { get { return default(Mono.CSharp.TypeParameters); } }
    public Mono.CSharp.TypeParameterSpec[] TypeParameters { get { return default(Mono.CSharp.TypeParameterSpec[]); } }
    public int TypeParametersCount { get { return default(int); } }
    public override void Accept(Mono.CSharp.StructuralVisitor visitor) { }
    public override void ApplyAttributeBuilder(Mono.CSharp.Attribute a, Mono.CSharp.MethodSpec ctor, System.Byte[] cdata, Mono.CSharp.PredefinedAttributes pa) { }
    public static bool CheckImplementingMethodConstraints(Mono.CSharp.TypeContainer container, Mono.CSharp.MethodSpec method, Mono.CSharp.MethodSpec baseMethod) { return default(bool); }
    public static Mono.CSharp.Method Create(Mono.CSharp.TypeDefinition parent, Mono.CSharp.FullNamedExpression returnType, Mono.CSharp.Modifiers mod, Mono.CSharp.MemberName name, Mono.CSharp.ParametersCompiled parameters, Mono.CSharp.Attributes attrs) { return default(Mono.CSharp.Method); }
    public override bool Define() { return default(bool); }
    protected virtual void DefineTypeParameters() { }
    public override void Emit() { }
    public override bool EnableOverloadChecks(Mono.CSharp.MemberCore overload) { return default(bool); }
    public static void Error1599(Mono.CSharp.Location loc, Mono.CSharp.TypeSpec t, Mono.CSharp.Report Report) { }
    public override string GetSignatureForError() { return default(string); }
    public override Mono.CSharp.FullNamedExpression LookupNamespaceOrType(string name, int arity, Mono.CSharp.LookupMode mode, Mono.CSharp.Location loc) { return default(Mono.CSharp.FullNamedExpression); }
    public override void PrepareEmit() { }
    protected override bool ResolveMemberType() { return default(bool); }
    public void SetPartialDefinition(Mono.CSharp.Method methodDefinition) { }
  }
  public abstract partial class MethodCore : Mono.CSharp.InterfaceMemberBase, Mono.CSharp.IInterfaceMemberSpec, Mono.CSharp.IParametersMember {
    protected Mono.CSharp.ToplevelBlock block;
    protected Mono.CSharp.ParametersCompiled parameters;
    protected Mono.CSharp.MethodSpec spec;
    protected MethodCore(Mono.CSharp.TypeDefinition parent, Mono.CSharp.FullNamedExpression type, Mono.CSharp.Modifiers mod, Mono.CSharp.Modifiers allowed_mod, Mono.CSharp.MemberName name, Mono.CSharp.Attributes attrs, Mono.CSharp.ParametersCompiled parameters) : base (default(Mono.CSharp.TypeDefinition), default(Mono.CSharp.FullNamedExpression), default(Mono.CSharp.Modifiers), default(Mono.CSharp.Modifiers), default(Mono.CSharp.MemberName), default(Mono.CSharp.Attributes)) { }
    public Mono.CSharp.ToplevelBlock Block { get { return default(Mono.CSharp.ToplevelBlock); } set { } }
    public System.Reflection.CallingConventions CallingConventions { get { return default(System.Reflection.CallingConventions); } }
    public override string DocCommentHeader { get { return default(string); } }
    public override Mono.CSharp.Variance ExpectedMemberTypeVariance { get { return default(Mono.CSharp.Variance); } }
    Mono.CSharp.AParametersCollection Mono.CSharp.IParametersMember.Parameters { get { return default(Mono.CSharp.AParametersCollection); } }
    public Mono.CSharp.ParametersCompiled ParameterInfo { get { return default(Mono.CSharp.ParametersCompiled); } }
    public Mono.CSharp.TypeSpec[] ParameterTypes { get { return default(Mono.CSharp.TypeSpec[]); } }
    public Mono.CSharp.MethodSpec Spec { get { return default(Mono.CSharp.MethodSpec); } }
    protected override bool CheckBase() { return default(bool); }
    protected override bool CheckOverrideAgainstBase(Mono.CSharp.MemberSpec base_member) { return default(bool); }
    public override void Emit() { }
    public override bool EnableOverloadChecks(Mono.CSharp.MemberCore overload) { return default(bool); }
    public override string GetSignatureForDocumentation() { return default(string); }
    protected override bool VerifyClsCompliance() { return default(bool); }
  }
  public partial class MethodData {
    protected Mono.CSharp.TypeSpec declaring_type;
    protected System.Reflection.MethodAttributes flags;
    public Mono.CSharp.MethodSpec implementing;
    protected Mono.CSharp.InterfaceMemberBase member;
    public readonly Mono.CSharp.IMethodData method;
    protected Mono.CSharp.Modifiers modifiers;
    protected Mono.CSharp.MethodSpec parent_method;
    public MethodData(Mono.CSharp.InterfaceMemberBase member, Mono.CSharp.Modifiers modifiers, System.Reflection.MethodAttributes flags, Mono.CSharp.IMethodData method) { }
    public MethodData(Mono.CSharp.InterfaceMemberBase member, Mono.CSharp.Modifiers modifiers, System.Reflection.MethodAttributes flags, Mono.CSharp.IMethodData method, Mono.CSharp.MethodSpec parent_method) { }
    public Mono.CSharp.TypeSpec DeclaringType { get { return default(Mono.CSharp.TypeSpec); } }
    public string MetadataName { get { return default(string); } }
    public System.Reflection.Emit.MethodBuilder MethodBuilder { get { return default(System.Reflection.Emit.MethodBuilder); } }
    public bool Define(Mono.CSharp.TypeDefinition container, string method_full_name) { return default(bool); }
    public System.Reflection.Emit.MethodBuilder DefineMethodBuilder(Mono.CSharp.TypeDefinition container) { return default(System.Reflection.Emit.MethodBuilder); }
    public System.Reflection.Emit.MethodBuilder DefineMethodBuilder(Mono.CSharp.TypeDefinition container, Mono.CSharp.ParametersCompiled param) { return default(System.Reflection.Emit.MethodBuilder); }
    public void Emit(Mono.CSharp.TypeDefinition parent) { }
    public void WriteDebugSymbol(Mono.CompilerServices.SymbolWriter.MonoSymbolFile file) { }
  }
  public partial class MethodGroupExpr : Mono.CSharp.MemberExpr, Mono.CSharp.OverloadResolver.IBaseMembersProvider {
    protected System.Collections.Generic.IList<Mono.CSharp.MemberSpec> Methods;
    protected Mono.CSharp.TypeSpec queried_type;
    protected Mono.CSharp.TypeArguments type_arguments;
    public MethodGroupExpr(Mono.CSharp.MethodSpec m, Mono.CSharp.TypeSpec type, Mono.CSharp.Location loc) { }
    public MethodGroupExpr(System.Collections.Generic.IList<Mono.CSharp.MemberSpec> mi, Mono.CSharp.TypeSpec type, Mono.CSharp.Location loc) { }
    public Mono.CSharp.MethodSpec BestCandidate { get { return default(Mono.CSharp.MethodSpec); } }
    public Mono.CSharp.TypeSpec BestCandidateReturnType { get { return default(Mono.CSharp.TypeSpec); } }
    public System.Collections.Generic.IList<Mono.CSharp.MemberSpec> Candidates { get { return default(System.Collections.Generic.IList<Mono.CSharp.MemberSpec>); } }
    protected override Mono.CSharp.TypeSpec DeclaringType { get { return default(Mono.CSharp.TypeSpec); } }
    public bool IsConditionallyExcluded { get { return default(bool); } }
    public override bool IsInstance { get { return default(bool); } }
    public override bool IsSideEffectFree { get { return default(bool); } }
    public override bool IsStatic { get { return default(bool); } }
    public override string KindName { get { return default(string); } }
    public override string Name { get { return default(string); } }
    public override Mono.CSharp.Expression CreateExpressionTree(Mono.CSharp.ResolveContext ec) { return default(Mono.CSharp.Expression); }
    public static Mono.CSharp.MethodGroupExpr CreatePredefined(Mono.CSharp.MethodSpec best, Mono.CSharp.TypeSpec queriedType, Mono.CSharp.Location loc) { return default(Mono.CSharp.MethodGroupExpr); }
    protected override Mono.CSharp.Expression DoResolve(Mono.CSharp.ResolveContext ec) { return default(Mono.CSharp.Expression); }
    public override void Emit(Mono.CSharp.EmitContext ec) { }
    public void EmitCall(Mono.CSharp.EmitContext ec, Mono.CSharp.Arguments arguments, Mono.CSharp.TypeSpec conditionalAccessReceiver, bool statement) { }
    public void EmitCall(Mono.CSharp.EmitContext ec, Mono.CSharp.Arguments arguments, bool statement) { }
    public override void Error_ValueCannotBeConverted(Mono.CSharp.ResolveContext ec, Mono.CSharp.TypeSpec target, bool expl) { }
    public virtual System.Collections.Generic.IList<Mono.CSharp.MemberSpec> GetBaseMembers(Mono.CSharp.TypeSpec baseType) { return default(System.Collections.Generic.IList<Mono.CSharp.MemberSpec>); }
    public Mono.CSharp.IParametersMember GetOverrideMemberParameters(Mono.CSharp.MemberSpec member) { return default(Mono.CSharp.IParametersMember); }
    public override string GetSignatureForError() { return default(string); }
    public static bool IsExtensionMethodArgument(Mono.CSharp.Expression expr) { return default(bool); }
    public virtual Mono.CSharp.MethodGroupExpr LookupExtensionMethod(Mono.CSharp.ResolveContext rc) { return default(Mono.CSharp.MethodGroupExpr); }
    public virtual Mono.CSharp.MethodGroupExpr OverloadResolve(Mono.CSharp.ResolveContext ec, ref Mono.CSharp.Arguments args, Mono.CSharp.OverloadResolver.IErrorHandler cerrors, Mono.CSharp.OverloadResolver.Restrictions restr) { return default(Mono.CSharp.MethodGroupExpr); }
    public override Mono.CSharp.MemberExpr ResolveMemberAccess(Mono.CSharp.ResolveContext ec, Mono.CSharp.Expression left, Mono.CSharp.SimpleName original) { return default(Mono.CSharp.MemberExpr); }
    public override void SetTypeArguments(Mono.CSharp.ResolveContext ec, Mono.CSharp.TypeArguments ta) { }
  }
  public abstract partial class MethodOrOperator : Mono.CSharp.MethodCore, Mono.CSharp.IMemberContext, Mono.CSharp.IMemberDefinition, Mono.CSharp.IMethodData, Mono.CSharp.IMethodDefinition, Mono.CSharp.IModuleContext {
    protected Mono.CSharp.MethodData MethodData;
    protected MethodOrOperator(Mono.CSharp.TypeDefinition parent, Mono.CSharp.FullNamedExpression type, Mono.CSharp.Modifiers mod, Mono.CSharp.Modifiers allowed_mod, Mono.CSharp.MemberName name, Mono.CSharp.Attributes attrs, Mono.CSharp.ParametersCompiled parameters) : base (default(Mono.CSharp.TypeDefinition), default(Mono.CSharp.FullNamedExpression), default(Mono.CSharp.Modifiers), default(Mono.CSharp.Modifiers), default(Mono.CSharp.MemberName), default(Mono.CSharp.Attributes), default(Mono.CSharp.ParametersCompiled)) { }
    public override System.AttributeTargets AttributeTargets { get { return default(System.AttributeTargets); } }
    public bool IsPartialDefinition { get { return default(bool); } }
    public bool IsPartialImplementation { get { return default(bool); } }
    public System.Reflection.Emit.MethodBuilder MethodBuilder { get { return default(System.Reflection.Emit.MethodBuilder); } }
    public Mono.CSharp.MemberName MethodName { get { return default(Mono.CSharp.MemberName); } }
    bool Mono.CSharp.IMethodData.IsAccessor { get { return default(bool); } }
    System.Reflection.MethodBase Mono.CSharp.IMethodDefinition.Metadata { get { return default(System.Reflection.MethodBase); } }
    public Mono.CSharp.TypeSpec ReturnType { get { return default(Mono.CSharp.TypeSpec); } }
    public override System.String[] ValidAttributeTargets { get { return default(System.String[]); } }
    public override void ApplyAttributeBuilder(Mono.CSharp.Attribute a, Mono.CSharp.MethodSpec ctor, System.Byte[] cdata, Mono.CSharp.PredefinedAttributes pa) { }
    protected override bool CheckForDuplications() { return default(bool); }
    public override System.String[] ConditionalConditions() { return default(System.String[]); }
    public virtual Mono.CSharp.EmitContext CreateEmitContext(System.Reflection.Emit.ILGenerator ig, Mono.CompilerServices.SymbolWriter.SourceMethodBuilder sourceMethod) { return default(Mono.CSharp.EmitContext); }
    public override bool Define() { return default(bool); }
    protected override void DoMemberTypeDependentChecks() { }
    protected override void DoMemberTypeIndependentChecks() { }
    public override void Emit() { }
    protected void Error_ConditionalAttributeIsNotValid() { }
    public virtual void PrepareEmit() { }
    public override void WriteDebugSymbol(Mono.CompilerServices.SymbolWriter.MonoSymbolFile file) { }
  }
  public sealed partial class MethodSpec : Mono.CSharp.MemberSpec, Mono.CSharp.IInterfaceMemberSpec, Mono.CSharp.IParametersMember {
    public static readonly Mono.CSharp.MethodSpec Excluded;
    public MethodSpec(Mono.CSharp.MemberKind kind, Mono.CSharp.TypeSpec declaringType, Mono.CSharp.IMethodDefinition details, Mono.CSharp.TypeSpec returnType, Mono.CSharp.AParametersCollection parameters, Mono.CSharp.Modifiers modifiers) : base (default(Mono.CSharp.MemberKind), default(Mono.CSharp.TypeSpec), default(Mono.CSharp.IMemberDefinition), default(Mono.CSharp.Modifiers)) { }
    public override int Arity { get { return default(int); } }
    public Mono.CSharp.TypeParameterSpec[] Constraints { get { return default(Mono.CSharp.TypeParameterSpec[]); } }
    public Mono.CSharp.IGenericMethodDefinition GenericDefinition { get { return default(Mono.CSharp.IGenericMethodDefinition); } }
    public bool IsAsync { get { return default(bool); } }
    public bool IsConstructor { get { return default(bool); } }
    public bool IsExtensionMethod { get { return default(bool); } }
    public bool IsReservedMethod { get { return default(bool); } }
    public bool IsSealed { get { return default(bool); } }
    public bool IsVirtual { get { return default(bool); } }
    public new Mono.CSharp.IMethodDefinition MemberDefinition { get { return default(Mono.CSharp.IMethodDefinition); } }
    Mono.CSharp.TypeSpec Mono.CSharp.IInterfaceMemberSpec.MemberType { get { return default(Mono.CSharp.TypeSpec); } }
    public Mono.CSharp.AParametersCollection Parameters { get { return default(Mono.CSharp.AParametersCollection); } }
    public Mono.CSharp.TypeSpec ReturnType { get { return default(Mono.CSharp.TypeSpec); } }
    public Mono.CSharp.TypeSpec[] TypeArguments { get { return default(Mono.CSharp.TypeSpec[]); } }
    public Mono.CSharp.MethodSpec GetGenericMethodDefinition() { return default(Mono.CSharp.MethodSpec); }
    public System.Reflection.MethodBase GetMetaInfo() { return default(System.Reflection.MethodBase); }
    public override string GetSignatureForDocumentation() { return default(string); }
    public override string GetSignatureForError() { return default(string); }
    public override Mono.CSharp.MemberSpec InflateMember(Mono.CSharp.TypeParameterInflator inflator) { return default(Mono.CSharp.MemberSpec); }
    public Mono.CSharp.MethodSpec MakeGenericMethod(Mono.CSharp.IMemberContext context, params Mono.CSharp.TypeSpec[] targs) { return default(Mono.CSharp.MethodSpec); }
    public Mono.CSharp.MethodSpec Mutate(Mono.CSharp.TypeParameterMutator mutator) { return default(Mono.CSharp.MethodSpec); }
    public override System.Collections.Generic.List<Mono.CSharp.MissingTypeSpecReference> ResolveMissingDependencies(Mono.CSharp.MemberSpec caller) { return default(System.Collections.Generic.List<Mono.CSharp.MissingTypeSpecReference>); }
  }
  public partial class MissingTypeSpecReference {
    public MissingTypeSpecReference(Mono.CSharp.TypeSpec type, Mono.CSharp.MemberSpec caller) { }
    public Mono.CSharp.MemberSpec Caller { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(Mono.CSharp.MemberSpec); } }
    public Mono.CSharp.TypeSpec Type { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(Mono.CSharp.TypeSpec); } }
  }
  [System.FlagsAttribute]
  public enum Modifiers {
    ABSTRACT = 32,
    AccessibilityMask = 15,
    AllowedExplicitImplFlags = 10240,
    ASYNC = 16384,
    BACKING_FIELD = 2097152,
    COMPILER_GENERATED = 1048576,
    DEBUGGER_HIDDEN = 4194304,
    DEBUGGER_STEP_THROUGH = 8388608,
    DEFAULT_ACCESS_MODIFIER = 262144,
    EXTERN = 2048,
    INTERNAL = 8,
    METHOD_EXTENSION = 524288,
    NEW = 16,
    OVERRIDE = 1024,
    PARTIAL = 131072,
    PRIVATE = 4,
    PROPERTY_CUSTOM = 65536,
    PROTECTED = 1,
    PUBLIC = 2,
    READONLY = 256,
    SEALED = 64,
    STATIC = 128,
    TOP = 32768,
    UNSAFE = 8192,
    VIRTUAL = 512,
    VOLATILE = 4096,
  }
  public sealed partial class ModuleContainer : Mono.CSharp.TypeContainer {
    public System.Nullable<System.Runtime.InteropServices.CharSet> DefaultCharSet;
    public System.Reflection.TypeAttributes DefaultCharSetType;
    public Mono.CSharp.Binary.PredefinedOperator[] OperatorsBinaryEqualityLifted;
    public Mono.CSharp.Binary.PredefinedOperator[] OperatorsBinaryLifted;
    public ModuleContainer(Mono.CSharp.CompilerContext context) : base (default(Mono.CSharp.TypeContainer), default(Mono.CSharp.MemberName), default(Mono.CSharp.Attributes), default(Mono.CSharp.MemberKind)) { }
    public override System.AttributeTargets AttributeTargets { get { return default(System.AttributeTargets); } }
    public System.Reflection.Emit.ModuleBuilder Builder { get { return default(System.Reflection.Emit.ModuleBuilder); } }
    public override Mono.CSharp.CompilerContext Compiler { get { return default(Mono.CSharp.CompilerContext); } }
    public int CounterAnonymousTypes { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(int); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public Mono.CSharp.AssemblyDefinition DeclaringAssembly { get { return default(Mono.CSharp.AssemblyDefinition); } }
    public override string DocCommentHeader { get { return default(string); } }
    public Mono.CSharp.Evaluator Evaluator { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(Mono.CSharp.Evaluator); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public Mono.CSharp.RootNamespace GlobalRootNamespace { get { return default(Mono.CSharp.RootNamespace); } }
    public bool HasDefaultCharSet { get { return default(bool); } }
    public bool HasExtensionMethod { get { return default(bool); } set { } }
    public bool HasTypesFullyDefined { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public override Mono.CSharp.ModuleContainer Module { get { return default(Mono.CSharp.ModuleContainer); } }
    public override System.String[] ValidAttributeTargets { get { return default(System.String[]); } }
    public override void Accept(Mono.CSharp.StructuralVisitor visitor) { }
    public void AddAnonymousType(Mono.CSharp.AnonymousTypeClass type) { }
    public void AddAttribute(Mono.CSharp.Attribute attr, Mono.CSharp.IMemberContext context) { }
    public override void AddTypeContainer(Mono.CSharp.TypeContainer tc) { }
    public override void ApplyAttributeBuilder(Mono.CSharp.Attribute a, Mono.CSharp.MethodSpec ctor, System.Byte[] cdata, Mono.CSharp.PredefinedAttributes pa) { }
    public override void CloseContainer() { }
    public void Create(Mono.CSharp.AssemblyDefinition assembly, System.Reflection.Emit.ModuleBuilder moduleBuilder) { }
    public System.Reflection.Emit.TypeBuilder CreateBuilder(string name, System.Reflection.TypeAttributes attr, int typeSize) { return default(System.Reflection.Emit.TypeBuilder); }
    public Mono.CSharp.ModuleContainer.PatternMatchingHelper CreatePatterMatchingHelper() { return default(Mono.CSharp.ModuleContainer.PatternMatchingHelper); }
    public Mono.CSharp.RootNamespace CreateRootNamespace(string alias) { return default(Mono.CSharp.RootNamespace); }
    public override bool Define() { return default(bool); }
    public override bool DefineContainer() { return default(bool); }
    public override void EmitContainer() { }
    public void EnableRedefinition() { }
    public Mono.CSharp.AnonymousTypeClass GetAnonymousType(System.Collections.Generic.IList<Mono.CSharp.AnonymousTypeParameter> parameters) { return default(Mono.CSharp.AnonymousTypeClass); }
    public Mono.CSharp.AwaiterDefinition GetAwaiter(Mono.CSharp.TypeSpec type) { return default(Mono.CSharp.AwaiterDefinition); }
    public override void GetCompletionStartingWith(string prefix, System.Collections.Generic.List<System.String> results) { }
    public Mono.CSharp.Binary.PredefinedOperator[] GetPredefinedEnumAritmeticOperators(Mono.CSharp.TypeSpec enumType, bool nullable) { return default(Mono.CSharp.Binary.PredefinedOperator[]); }
    public Mono.CSharp.RootNamespace GetRootNamespace(string name) { return default(Mono.CSharp.RootNamespace); }
    public override string GetSignatureForError() { return default(string); }
    public void InitializePredefinedTypes() { }
    public override bool IsClsComplianceRequired() { return default(bool); }
    public Mono.CSharp.Attribute ResolveAssemblyAttribute(Mono.CSharp.PredefinedAttribute a_type) { return default(Mono.CSharp.Attribute); }
    public void SetDeclaringAssembly(Mono.CSharp.AssemblyDefinition assembly) { }
    public sealed partial class PatternMatchingHelper : Mono.CSharp.CompilerGeneratedContainer {
      public PatternMatchingHelper(Mono.CSharp.ModuleContainer module) : base (default(Mono.CSharp.TypeContainer), default(Mono.CSharp.MemberName), default(Mono.CSharp.Modifiers)) { }
      public Mono.CSharp.Method NumberMatcher { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(Mono.CSharp.Method); } }
      protected override bool DoDefineMembers() { return default(bool); }
    }
  }
  public partial class MovableArgument : Mono.CSharp.Argument {
    public MovableArgument(Mono.CSharp.Argument arg) : base (default(Mono.CSharp.Expression), default(Mono.CSharp.Argument.AType)) { }
    protected MovableArgument(Mono.CSharp.Expression expr, Mono.CSharp.Argument.AType modifier) : base (default(Mono.CSharp.Expression), default(Mono.CSharp.Argument.AType)) { }
    public override void Emit(Mono.CSharp.EmitContext ec) { }
    public void EmitToVariable(Mono.CSharp.EmitContext ec) { }
  }
  public partial class NamedArgument : Mono.CSharp.MovableArgument {
    public readonly string Name;
    public NamedArgument(string name, Mono.CSharp.Location loc, Mono.CSharp.Expression expr) : base (default(Mono.CSharp.Argument)) { }
    public NamedArgument(string name, Mono.CSharp.Location loc, Mono.CSharp.Expression expr, Mono.CSharp.Argument.AType modifier) : base (default(Mono.CSharp.Argument)) { }
    public Mono.CSharp.Location Location { get { return default(Mono.CSharp.Location); } }
    public override Mono.CSharp.Expression CreateExpressionTree(Mono.CSharp.ResolveContext ec) { return default(Mono.CSharp.Expression); }
  }
  public partial class Namespace {
    protected System.Collections.Generic.Dictionary<System.String, Mono.CSharp.Namespace> namespaces;
    protected System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.IList<Mono.CSharp.TypeSpec>> types;
    protected Namespace() { }
    public Namespace(Mono.CSharp.Namespace parent, string name) { }
    public string Name { get { return default(string); } }
    public Mono.CSharp.Namespace Parent { get { return default(Mono.CSharp.Namespace); } }
    public Mono.CSharp.Namespace AddNamespace(Mono.CSharp.MemberName name) { return default(Mono.CSharp.Namespace); }
    public void AddType(Mono.CSharp.ModuleContainer module, Mono.CSharp.TypeSpec ts) { }
    public System.Collections.Generic.IEnumerable<System.String> CompletionGetTypesStartingWith(string prefix) { return default(System.Collections.Generic.IEnumerable<System.String>); }
    public System.Collections.Generic.IList<Mono.CSharp.TypeSpec> GetAllTypes(string name) { return default(System.Collections.Generic.IList<Mono.CSharp.TypeSpec>); }
    public Mono.CSharp.Namespace GetNamespace(string name, bool create) { return default(Mono.CSharp.Namespace); }
    public virtual string GetSignatureForError() { return default(string); }
    public static Mono.CSharp.TypeSpec IsImportedTypeOverride(Mono.CSharp.ModuleContainer module, Mono.CSharp.TypeSpec ts, Mono.CSharp.TypeSpec found) { return default(Mono.CSharp.TypeSpec); }
    public System.Collections.Generic.List<Mono.CSharp.MethodSpec> LookupExtensionMethod(Mono.CSharp.IMemberContext invocationContext, string name, int arity) { return default(System.Collections.Generic.List<Mono.CSharp.MethodSpec>); }
    public Mono.CSharp.TypeSpec LookupType(Mono.CSharp.IMemberContext ctx, string name, int arity, Mono.CSharp.LookupMode mode, Mono.CSharp.Location loc) { return default(Mono.CSharp.TypeSpec); }
    public Mono.CSharp.FullNamedExpression LookupTypeOrNamespace(Mono.CSharp.IMemberContext ctx, string name, int arity, Mono.CSharp.LookupMode mode, Mono.CSharp.Location loc) { return default(Mono.CSharp.FullNamedExpression); }
    public void RemoveContainer(Mono.CSharp.TypeContainer tc) { }
    public void SetBuiltinType(Mono.CSharp.BuiltinTypeSpec pts) { }
    public bool TryGetNamespace(string name, out Mono.CSharp.Namespace ns) { ns = default(Mono.CSharp.Namespace); return default(bool); }
    public void VerifyClsCompliance() { }
  }
  public partial class NamespaceContainer : Mono.CSharp.TypeContainer, Mono.CSharp.IMemberContext, Mono.CSharp.IModuleContext {
    public bool DeclarationFound;
    public readonly new Mono.CSharp.NamespaceContainer Parent;
    public NamespaceContainer(Mono.CSharp.MemberName name, Mono.CSharp.NamespaceContainer parent) : base (default(Mono.CSharp.TypeContainer), default(Mono.CSharp.MemberName), default(Mono.CSharp.Attributes), default(Mono.CSharp.MemberKind)) { }
    protected NamespaceContainer(Mono.CSharp.ModuleContainer parent) : base (default(Mono.CSharp.TypeContainer), default(Mono.CSharp.MemberName), default(Mono.CSharp.Attributes), default(Mono.CSharp.MemberKind)) { }
    public override System.AttributeTargets AttributeTargets { get { return default(System.AttributeTargets); } }
    public override string DocCommentHeader { get { return default(string); } }
    public Mono.CSharp.Namespace NS { get { return default(Mono.CSharp.Namespace); } }
    public System.Collections.Generic.List<Mono.CSharp.UsingNamespace> Usings { get { return default(System.Collections.Generic.List<Mono.CSharp.UsingNamespace>); } }
    public override System.String[] ValidAttributeTargets { get { return default(System.String[]); } }
    public override void Accept(Mono.CSharp.StructuralVisitor visitor) { }
    public override void AddPartial(Mono.CSharp.TypeDefinition next_part) { }
    public override void AddTypeContainer(Mono.CSharp.TypeContainer tc) { }
    public void AddUsing(Mono.CSharp.UsingAliasNamespace un) { }
    public void AddUsing(Mono.CSharp.UsingNamespace un) { }
    public override void ApplyAttributeBuilder(Mono.CSharp.Attribute a, Mono.CSharp.MethodSpec ctor, System.Byte[] cdata, Mono.CSharp.PredefinedAttributes pa) { }
    protected override void DefineNamespace() { }
    public override void EmitContainer() { }
    public void EnableRedefinition() { }
    public override void GetCompletionStartingWith(string prefix, System.Collections.Generic.List<System.String> results) { }
    public override string GetSignatureForError() { return default(string); }
    public Mono.CSharp.ExtensionMethodCandidates LookupExtensionMethod(Mono.CSharp.IMemberContext invocationContext, Mono.CSharp.TypeSpec extensionType, string name, int arity, int position) { return default(Mono.CSharp.ExtensionMethodCandidates); }
    public Mono.CSharp.FullNamedExpression LookupExternAlias(string name) { return default(Mono.CSharp.FullNamedExpression); }
    public override Mono.CSharp.FullNamedExpression LookupNamespaceAlias(string name) { return default(Mono.CSharp.FullNamedExpression); }
    public override Mono.CSharp.FullNamedExpression LookupNamespaceOrType(string name, int arity, Mono.CSharp.LookupMode mode, Mono.CSharp.Location loc) { return default(Mono.CSharp.FullNamedExpression); }
    public static Mono.CSharp.MethodGroupExpr LookupStaticUsings(Mono.CSharp.IMemberContext mc, string name, int arity, Mono.CSharp.Location loc) { return default(Mono.CSharp.MethodGroupExpr); }
    public override void RemoveContainer(Mono.CSharp.TypeContainer cont) { }
    protected override bool VerifyClsCompliance() { return default(bool); }
  }
  public partial class NamespaceExpression : Mono.CSharp.FullNamedExpression {
    public NamespaceExpression(Mono.CSharp.Namespace ns, Mono.CSharp.Location loc) { }
    public Mono.CSharp.Namespace Namespace { get { return default(Mono.CSharp.Namespace); } }
    protected override Mono.CSharp.Expression DoResolve(Mono.CSharp.ResolveContext rc) { return default(Mono.CSharp.Expression); }
    public void Error_NamespaceDoesNotExist(Mono.CSharp.IMemberContext ctx, string name, int arity) { }
    public override string GetSignatureForError() { return default(string); }
    public Mono.CSharp.FullNamedExpression LookupTypeOrNamespace(Mono.CSharp.IMemberContext ctx, string name, int arity, Mono.CSharp.LookupMode mode, Mono.CSharp.Location loc) { return default(Mono.CSharp.FullNamedExpression); }
    public override Mono.CSharp.FullNamedExpression ResolveAsTypeOrNamespace(Mono.CSharp.IMemberContext mc, bool allowUnboundTypeArguments) { return default(Mono.CSharp.FullNamedExpression); }
  }
  public partial class New : Mono.CSharp.ExpressionStatement, Mono.CSharp.IMemoryLocation {
    protected Mono.CSharp.Arguments arguments;
    protected Mono.CSharp.MethodSpec method;
    protected Mono.CSharp.Expression RequestedType;
    public New(Mono.CSharp.Expression requested_type, Mono.CSharp.Arguments arguments, Mono.CSharp.Location l) { }
    public Mono.CSharp.Arguments Arguments { get { return default(Mono.CSharp.Arguments); } }
    public bool IsGeneratedStructConstructor { get { return default(bool); } }
    public Mono.CSharp.Expression TypeExpression { get { return default(Mono.CSharp.Expression); } }
    public override object Accept(Mono.CSharp.StructuralVisitor visitor) { return default(object); }
    public void AddressOf(Mono.CSharp.EmitContext ec, Mono.CSharp.AddressOp mode) { }
    public Mono.CSharp.Expression CheckComImport(Mono.CSharp.ResolveContext ec) { return default(Mono.CSharp.Expression); }
    protected override void CloneTo(Mono.CSharp.CloneContext clonectx, Mono.CSharp.Expression t) { }
    public static Mono.CSharp.Constant Constantify(Mono.CSharp.TypeSpec t, Mono.CSharp.Location loc) { return default(Mono.CSharp.Constant); }
    public override bool ContainsEmitWithAwait() { return default(bool); }
    public override Mono.CSharp.Expression CreateExpressionTree(Mono.CSharp.ResolveContext ec) { return default(Mono.CSharp.Expression); }
    protected override Mono.CSharp.Expression DoResolve(Mono.CSharp.ResolveContext ec) { return default(Mono.CSharp.Expression); }
    public override void Emit(Mono.CSharp.EmitContext ec) { }
    public virtual bool Emit(Mono.CSharp.EmitContext ec, Mono.CSharp.IMemoryLocation target) { return default(bool); }
    protected virtual Mono.CSharp.IMemoryLocation EmitAddressOf(Mono.CSharp.EmitContext ec, Mono.CSharp.AddressOp mode) { return default(Mono.CSharp.IMemoryLocation); }
    public override void EmitStatement(Mono.CSharp.EmitContext ec) { }
    public override void FlowAnalysis(Mono.CSharp.FlowAnalysisContext fc) { }
    public override System.Linq.Expressions.Expression MakeExpression(Mono.CSharp.BuilderContext ctx) { return default(System.Linq.Expressions.Expression); }
  }
  public partial class NewAnonymousType : Mono.CSharp.New {
    public NewAnonymousType(System.Collections.Generic.List<Mono.CSharp.AnonymousTypeParameter> parameters, Mono.CSharp.TypeContainer parent, Mono.CSharp.Location loc) : base (default(Mono.CSharp.Expression), default(Mono.CSharp.Arguments), default(Mono.CSharp.Location)) { }
    public System.Collections.Generic.List<Mono.CSharp.AnonymousTypeParameter> Parameters { get { return default(System.Collections.Generic.List<Mono.CSharp.AnonymousTypeParameter>); } }
    public override object Accept(Mono.CSharp.StructuralVisitor visitor) { return default(object); }
    protected override void CloneTo(Mono.CSharp.CloneContext clonectx, Mono.CSharp.Expression target) { }
    public override Mono.CSharp.Expression CreateExpressionTree(Mono.CSharp.ResolveContext ec) { return default(Mono.CSharp.Expression); }
    protected override Mono.CSharp.Expression DoResolve(Mono.CSharp.ResolveContext ec) { return default(Mono.CSharp.Expression); }
  }
  public partial class NewDelegate : Mono.CSharp.DelegateCreation {
    public Mono.CSharp.Arguments Arguments;
    public NewDelegate(Mono.CSharp.TypeSpec type, Mono.CSharp.Arguments Arguments, Mono.CSharp.Location loc) { }
    protected override Mono.CSharp.Expression DoResolve(Mono.CSharp.ResolveContext ec) { return default(Mono.CSharp.Expression); }
  }
  public partial class NewInitialize : Mono.CSharp.New {
    public NewInitialize(Mono.CSharp.FullNamedExpression requested_type, Mono.CSharp.Arguments arguments, Mono.CSharp.CollectionOrObjectInitializers initializers, Mono.CSharp.Location l) : base (default(Mono.CSharp.Expression), default(Mono.CSharp.Arguments), default(Mono.CSharp.Location)) { }
    public Mono.CSharp.CollectionOrObjectInitializers Initializers { get { return default(Mono.CSharp.CollectionOrObjectInitializers); } }
    public override object Accept(Mono.CSharp.StructuralVisitor visitor) { return default(object); }
    protected override void CloneTo(Mono.CSharp.CloneContext clonectx, Mono.CSharp.Expression t) { }
    public override bool ContainsEmitWithAwait() { return default(bool); }
    public override Mono.CSharp.Expression CreateExpressionTree(Mono.CSharp.ResolveContext ec) { return default(Mono.CSharp.Expression); }
    protected override Mono.CSharp.Expression DoResolve(Mono.CSharp.ResolveContext ec) { return default(Mono.CSharp.Expression); }
    public override void Emit(Mono.CSharp.EmitContext ec) { }
    public override bool Emit(Mono.CSharp.EmitContext ec, Mono.CSharp.IMemoryLocation target) { return default(bool); }
    protected override Mono.CSharp.IMemoryLocation EmitAddressOf(Mono.CSharp.EmitContext ec, Mono.CSharp.AddressOp Mode) { return default(Mono.CSharp.IMemoryLocation); }
    public override void FlowAnalysis(Mono.CSharp.FlowAnalysisContext fc) { }
  }
  public partial class NullConstant : Mono.CSharp.Constant {
    public NullConstant(Mono.CSharp.TypeSpec type, Mono.CSharp.Location loc) : base (default(Mono.CSharp.Location)) { }
    public override string ExprClassName { get { return default(string); } }
    public override bool IsDefaultValue { get { return default(bool); } }
    public override bool IsNegative { get { return default(bool); } }
    public override bool IsNull { get { return default(bool); } }
    public override bool IsZeroInteger { get { return default(bool); } }
    public override Mono.CSharp.Constant ConvertExplicitly(bool inCheckedContext, Mono.CSharp.TypeSpec targetType) { return default(Mono.CSharp.Constant); }
    public override Mono.CSharp.Constant ConvertImplicitly(Mono.CSharp.TypeSpec targetType) { return default(Mono.CSharp.Constant); }
    public override Mono.CSharp.Expression CreateExpressionTree(Mono.CSharp.ResolveContext ec) { return default(Mono.CSharp.Expression); }
    public override void Emit(Mono.CSharp.EmitContext ec) { }
    public override void EncodeAttributeValue(Mono.CSharp.IMemberContext rc, Mono.CSharp.AttributeEncoder enc, Mono.CSharp.TypeSpec targetType, Mono.CSharp.TypeSpec parameterType) { }
    public override string GetSignatureForError() { return default(string); }
    public override object GetValue() { return default(object); }
    public override string GetValueAsLiteral() { return default(string); }
    public override long GetValueAsLong() { return default(long); }
  }
  public partial class NullLiteral : Mono.CSharp.NullConstant {
    public NullLiteral(Mono.CSharp.Location loc) : base (default(Mono.CSharp.TypeSpec), default(Mono.CSharp.Location)) { }
    public override bool IsLiteral { get { return default(bool); } }
    public override void Error_ValueCannotBeConverted(Mono.CSharp.ResolveContext ec, Mono.CSharp.TypeSpec t, bool expl) { }
    public override string GetValueAsLiteral() { return default(string); }
    public override System.Linq.Expressions.Expression MakeExpression(Mono.CSharp.BuilderContext ctx) { return default(System.Linq.Expressions.Expression); }
  }
  public partial class Operator : Mono.CSharp.MethodOrOperator {
    public readonly Mono.CSharp.Operator.OpType OperatorType;
    public Operator(Mono.CSharp.TypeDefinition parent, Mono.CSharp.Operator.OpType type, Mono.CSharp.FullNamedExpression ret_type, Mono.CSharp.Modifiers mod_flags, Mono.CSharp.ParametersCompiled parameters, Mono.CSharp.ToplevelBlock block, Mono.CSharp.Attributes attrs, Mono.CSharp.Location loc) : base (default(Mono.CSharp.TypeDefinition), default(Mono.CSharp.FullNamedExpression), default(Mono.CSharp.Modifiers), default(Mono.CSharp.Modifiers), default(Mono.CSharp.MemberName), default(Mono.CSharp.Attributes), default(Mono.CSharp.ParametersCompiled)) { }
    public override void Accept(Mono.CSharp.StructuralVisitor visitor) { }
    public override void ApplyAttributeBuilder(Mono.CSharp.Attribute a, Mono.CSharp.MethodSpec ctor, System.Byte[] cdata, Mono.CSharp.PredefinedAttributes pa) { }
    public override bool Define() { return default(bool); }
    protected override Mono.CSharp.MemberSpec FindBaseMember(out Mono.CSharp.MemberSpec bestCandidate, ref bool overrides) { bestCandidate = default(Mono.CSharp.MemberSpec); return default(Mono.CSharp.MemberSpec); }
    public Mono.CSharp.Operator.OpType GetMatchingOperator() { return default(Mono.CSharp.Operator.OpType); }
    public static string GetMetadataName(Mono.CSharp.Operator.OpType ot) { return default(string); }
    public static string GetMetadataName(string name) { return default(string); }
    public static string GetName(Mono.CSharp.Operator.OpType ot) { return default(string); }
    public static string GetName(string metadata_name) { return default(string); }
    public override string GetSignatureForDocumentation() { return default(string); }
    public override string GetSignatureForError() { return default(string); }
    public static System.Nullable<Mono.CSharp.Operator.OpType> GetType(string metadata_name) { return default(System.Nullable<Mono.CSharp.Operator.OpType>); }
    protected override bool ResolveMemberType() { return default(bool); }
    public enum OpType : byte {
      Addition = (byte)6,
      BitwiseAnd = (byte)13,
      BitwiseOr = (byte)14,
      Decrement = (byte)3,
      Division = (byte)11,
      Equality = (byte)18,
      ExclusiveOr = (byte)15,
      Explicit = (byte)25,
      False = (byte)5,
      GreaterThan = (byte)20,
      GreaterThanOrEqual = (byte)22,
      Implicit = (byte)24,
      Increment = (byte)2,
      Inequality = (byte)19,
      Is = (byte)26,
      LeftShift = (byte)16,
      LessThan = (byte)21,
      LessThanOrEqual = (byte)23,
      LogicalNot = (byte)0,
      Modulus = (byte)12,
      Multiply = (byte)10,
      OnesComplement = (byte)1,
      RightShift = (byte)17,
      Subtraction = (byte)7,
      TOP = (byte)27,
      True = (byte)4,
      UnaryNegation = (byte)9,
      UnaryPlus = (byte)8,
    }
  }
  public partial class OperatorCast : Mono.CSharp.TypeCast {
    public OperatorCast(Mono.CSharp.Expression expr, Mono.CSharp.TypeSpec target_type) : base (default(Mono.CSharp.Expression), default(Mono.CSharp.TypeSpec)) { }
    public OperatorCast(Mono.CSharp.Expression expr, Mono.CSharp.TypeSpec declaringType, Mono.CSharp.TypeSpec returnType, bool isExplicit) : base (default(Mono.CSharp.Expression), default(Mono.CSharp.TypeSpec)) { }
    public OperatorCast(Mono.CSharp.Expression expr, Mono.CSharp.TypeSpec target_type, bool find_explicit) : base (default(Mono.CSharp.Expression), default(Mono.CSharp.TypeSpec)) { }
    public override void Emit(Mono.CSharp.EmitContext ec) { }
  }
  public partial class Outline {
    public Outline(System.Type t, System.IO.TextWriter output, bool declared_only, bool show_private, bool filter_obsolete) { }
    public void OutlineType() { }
    public static string RemoveGenericArity(string name) { return default(string); }
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct OverloadResolver {
    public OverloadResolver(System.Collections.Generic.IList<Mono.CSharp.MemberSpec> members, Mono.CSharp.OverloadResolver.Restrictions restrictions, Mono.CSharp.Location loc) { throw new System.NotImplementedException(); }
    public OverloadResolver(System.Collections.Generic.IList<Mono.CSharp.MemberSpec> members, Mono.CSharp.TypeArguments targs, Mono.CSharp.OverloadResolver.Restrictions restrictions, Mono.CSharp.Location loc) { throw new System.NotImplementedException(); }
    public Mono.CSharp.OverloadResolver.IBaseMembersProvider BaseMembersProvider { get { return default(Mono.CSharp.OverloadResolver.IBaseMembersProvider); } set { } }
    public bool BestCandidateIsDynamic { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public Mono.CSharp.MethodGroupExpr BestCandidateNewMethodGroup { get { return default(Mono.CSharp.MethodGroupExpr); } }
    public Mono.CSharp.TypeSpec BestCandidateReturnType { get { return default(Mono.CSharp.TypeSpec); } }
    public Mono.CSharp.OverloadResolver.IErrorHandler CustomErrors { get { return default(Mono.CSharp.OverloadResolver.IErrorHandler); } set { } }
    public Mono.CSharp.OverloadResolver.IInstanceQualifier InstanceQualifier { get { return default(Mono.CSharp.OverloadResolver.IInstanceQualifier); } set { } }
    public static int BetterTypeConversion(Mono.CSharp.ResolveContext ec, Mono.CSharp.TypeSpec p, Mono.CSharp.TypeSpec q) { return default(int); }
    public static void Error_ConstructorMismatch(Mono.CSharp.ResolveContext rc, Mono.CSharp.TypeSpec type, int argCount, Mono.CSharp.Location loc) { }
    public static Mono.CSharp.Expression ResolveDefaultValueArgument(Mono.CSharp.ResolveContext ec, Mono.CSharp.TypeSpec ptype, Mono.CSharp.Expression e, Mono.CSharp.Location loc) { return default(Mono.CSharp.Expression); }
    public T ResolveMember<T>(Mono.CSharp.ResolveContext rc, ref Mono.CSharp.Arguments args) where T : Mono.CSharp.MemberSpec, Mono.CSharp.IParametersMember { return default(T); }
    public Mono.CSharp.MethodSpec ResolveOperator(Mono.CSharp.ResolveContext rc, ref Mono.CSharp.Arguments args) { return default(Mono.CSharp.MethodSpec); }
    public partial interface IBaseMembersProvider {
      System.Collections.Generic.IList<Mono.CSharp.MemberSpec> GetBaseMembers(Mono.CSharp.TypeSpec baseType);
      Mono.CSharp.IParametersMember GetOverrideMemberParameters(Mono.CSharp.MemberSpec member);
      Mono.CSharp.MethodGroupExpr LookupExtensionMethod(Mono.CSharp.ResolveContext rc);
    }
    public partial interface IErrorHandler {
      bool AmbiguousCandidates(Mono.CSharp.ResolveContext rc, Mono.CSharp.MemberSpec best, Mono.CSharp.MemberSpec ambiguous);
      bool ArgumentMismatch(Mono.CSharp.ResolveContext rc, Mono.CSharp.MemberSpec best, Mono.CSharp.Argument a, int index);
      bool NoArgumentMatch(Mono.CSharp.ResolveContext rc, Mono.CSharp.MemberSpec best);
      bool TypeInferenceFailed(Mono.CSharp.ResolveContext rc, Mono.CSharp.MemberSpec best);
    }
    public partial interface IInstanceQualifier {
      Mono.CSharp.TypeSpec InstanceType { get; }
      bool CheckProtectedMemberAccess(Mono.CSharp.ResolveContext rc, Mono.CSharp.MemberSpec member);
    }
    [System.FlagsAttribute]
    public enum Restrictions {
      BaseMembersIncluded = 16,
      CovariantDelegate = 4,
      DelegateInvoke = 1,
      GetEnumeratorLookup = 32,
      NoBaseMembers = 8,
      None = 0,
      ProbingOnly = 2,
    }
  }
  public partial class Parameter : Mono.CSharp.ParameterBase, Mono.CSharp.ILocalVariable, Mono.CSharp.IParameterData {
    public bool HasAddressTaken;
    protected int idx;
    protected Mono.CSharp.TypeSpec parameter_type;
    public Parameter(Mono.CSharp.FullNamedExpression type, string name, Mono.CSharp.Parameter.Modifier mod, Mono.CSharp.Attributes attrs, Mono.CSharp.Location loc) { }
    public override System.AttributeTargets AttributeTargets { get { return default(System.AttributeTargets); } }
    public Mono.CSharp.Expression DefaultExpression { get { return default(Mono.CSharp.Expression); } }
    public Mono.CSharp.DefaultParameterValueExpression DefaultValue { get { return default(Mono.CSharp.DefaultParameterValueExpression); } set { } }
    public bool HasDefaultValue { get { return default(bool); } }
    public bool HasExtensionMethodModifier { get { return default(bool); } }
    public Mono.CSharp.HoistedParameter HoistedVariant { get { return default(Mono.CSharp.HoistedParameter); } set { } }
    public Mono.CSharp.Location Location { get { return default(Mono.CSharp.Location); } }
    public Mono.CSharp.Parameter.Modifier ModFlags { get { return default(Mono.CSharp.Parameter.Modifier); } }
    Mono.CSharp.Expression Mono.CSharp.IParameterData.DefaultValue { get { return default(Mono.CSharp.Expression); } }
    public string Name { get { return default(string); } set { } }
    public Mono.CSharp.Parameter.Modifier ParameterModifier { get { return default(Mono.CSharp.Parameter.Modifier); } }
    public Mono.CSharp.TypeSpec Type { get { return default(Mono.CSharp.TypeSpec); } set { } }
    public Mono.CSharp.FullNamedExpression TypeExpression { get { return default(Mono.CSharp.FullNamedExpression); } }
    public override System.String[] ValidAttributeTargets { get { return default(System.String[]); } }
    public override void ApplyAttributeBuilder(Mono.CSharp.Attribute a, Mono.CSharp.MethodSpec ctor, System.Byte[] cdata, Mono.CSharp.PredefinedAttributes pa) { }
    public virtual void ApplyAttributes(System.Reflection.Emit.MethodBuilder mb, System.Reflection.Emit.ConstructorBuilder cb, int index, Mono.CSharp.PredefinedAttributes pa) { }
    public virtual bool CheckAccessibility(Mono.CSharp.InterfaceMemberBase member) { return default(bool); }
    public Mono.CSharp.Parameter Clone() { return default(Mono.CSharp.Parameter); }
    public Mono.CSharp.ExpressionStatement CreateExpressionTreeVariable(Mono.CSharp.BlockContext ec) { return default(Mono.CSharp.ExpressionStatement); }
    public void Emit(Mono.CSharp.EmitContext ec) { }
    public void EmitAddressOf(Mono.CSharp.EmitContext ec) { }
    public void EmitAssign(Mono.CSharp.EmitContext ec) { }
    public void Error_DuplicateName(Mono.CSharp.Report r) { }
    public Mono.CSharp.TemporaryVariableReference ExpressionTreeVariableReference() { return default(Mono.CSharp.TemporaryVariableReference); }
    public static string GetModifierSignature(Mono.CSharp.Parameter.Modifier mod) { return default(string); }
    public virtual string GetSignatureForError() { return default(string); }
    public void IsClsCompliant(Mono.CSharp.IMemberContext ctx) { }
    public virtual Mono.CSharp.TypeSpec Resolve(Mono.CSharp.IMemberContext rc, int index) { return default(Mono.CSharp.TypeSpec); }
    public void ResolveDefaultValue(Mono.CSharp.ResolveContext rc) { }
    public static Mono.CSharp.TypeExpr ResolveParameterExpressionType(Mono.CSharp.IMemberContext ec, Mono.CSharp.Location location) { return default(Mono.CSharp.TypeExpr); }
    public void SetIndex(int index) { }
    public void Warning_UselessOptionalParameter(Mono.CSharp.Report Report) { }
    [System.FlagsAttribute]
    public enum Modifier : byte {
      CallerFilePath = (byte)64,
      CallerLineNumber = (byte)32,
      CallerMask = (byte)112,
      CallerMemberName = (byte)16,
      ModifierMask = (byte)15,
      NONE = (byte)0,
      OUT = (byte)4,
      PARAMS = (byte)1,
      REF = (byte)2,
      RefOutMask = (byte)6,
      This = (byte)8,
    }
  }
  public abstract partial class ParameterBase : Mono.CSharp.Attributable {
    protected System.Reflection.Emit.ParameterBuilder builder;
    protected ParameterBase() { }
    public System.Reflection.Emit.ParameterBuilder Builder { get { return default(System.Reflection.Emit.ParameterBuilder); } }
    public override void ApplyAttributeBuilder(Mono.CSharp.Attribute a, Mono.CSharp.MethodSpec ctor, System.Byte[] cdata, Mono.CSharp.PredefinedAttributes pa) { }
    public override bool IsClsComplianceRequired() { return default(bool); }
  }
  public partial class ParameterData : Mono.CSharp.IParameterData {
    public ParameterData(string name, Mono.CSharp.Parameter.Modifier modifiers) { }
    public ParameterData(string name, Mono.CSharp.Parameter.Modifier modifiers, Mono.CSharp.Expression defaultValue) { }
    public Mono.CSharp.Expression DefaultValue { get { return default(Mono.CSharp.Expression); } }
    public bool HasDefaultValue { get { return default(bool); } }
    public bool HasExtensionMethodModifier { get { return default(bool); } }
    public Mono.CSharp.Parameter.Modifier ModFlags { get { return default(Mono.CSharp.Parameter.Modifier); } }
    public string Name { get { return default(string); } }
  }
  public partial class ParameterReference : Mono.CSharp.VariableReference {
    protected Mono.CSharp.ParametersBlock.ParameterInfo pi;
    public ParameterReference(Mono.CSharp.ParametersBlock.ParameterInfo pi, Mono.CSharp.Location loc) { }
    public override bool IsFixed { get { return default(bool); } }
    public override bool IsLockedByStatement { get { return default(bool); } set { } }
    public override bool IsRef { get { return default(bool); } }
    public override string Name { get { return default(string); } }
    public Mono.CSharp.Parameter Parameter { get { return default(Mono.CSharp.Parameter); } }
    protected override Mono.CSharp.ILocalVariable Variable { get { return default(Mono.CSharp.ILocalVariable); } }
    public override Mono.CSharp.VariableInfo VariableInfo { get { return default(Mono.CSharp.VariableInfo); } }
    public override void AddressOf(Mono.CSharp.EmitContext ec, Mono.CSharp.AddressOp mode) { }
    protected override void CloneTo(Mono.CSharp.CloneContext clonectx, Mono.CSharp.Expression target) { }
    public override Mono.CSharp.Expression CreateExpressionTree(Mono.CSharp.ResolveContext ec) { return default(Mono.CSharp.Expression); }
    protected override Mono.CSharp.Expression DoResolve(Mono.CSharp.ResolveContext ec) { return default(Mono.CSharp.Expression); }
    public override Mono.CSharp.Expression DoResolveLValue(Mono.CSharp.ResolveContext ec, Mono.CSharp.Expression right_side) { return default(Mono.CSharp.Expression); }
    public override bool Equals(object obj) { return default(bool); }
    public override void FlowAnalysis(Mono.CSharp.FlowAnalysisContext fc) { }
    public override int GetHashCode() { return default(int); }
    public override Mono.CSharp.HoistedVariable GetHoistedVariable(Mono.CSharp.AnonymousExpression ae) { return default(Mono.CSharp.HoistedVariable); }
    public override void SetHasAddressTaken() { }
  }
  public partial class ParametersBlock : Mono.CSharp.ExplicitBlock {
    protected System.Collections.Generic.Dictionary<System.String, System.Object> labels;
    protected Mono.CSharp.ParametersBlock.ParameterInfo[] parameter_info;
    protected Mono.CSharp.ParametersCompiled parameters;
    protected bool resolved;
    protected Mono.CSharp.StateMachine state_machine;
    protected Mono.CSharp.ToplevelBlock top_block;
    public ParametersBlock(Mono.CSharp.Block parent, Mono.CSharp.ParametersCompiled parameters, Mono.CSharp.Location start, Mono.CSharp.Block.Flags flags=(Mono.CSharp.Block.Flags)(0)) : base (default(Mono.CSharp.Block), default(Mono.CSharp.Location), default(Mono.CSharp.Location)) { }
    protected ParametersBlock(Mono.CSharp.ParametersBlock source, Mono.CSharp.ParametersCompiled parameters) : base (default(Mono.CSharp.Block), default(Mono.CSharp.Location), default(Mono.CSharp.Location)) { }
    protected ParametersBlock(Mono.CSharp.ParametersCompiled parameters, Mono.CSharp.Location start) : base (default(Mono.CSharp.Block), default(Mono.CSharp.Location), default(Mono.CSharp.Location)) { }
    public bool IsAsync { get { return default(bool); } set { } }
    public bool IsExpressionTree { get { return default(bool); } }
    public Mono.CSharp.ParametersCompiled Parameters { get { return default(Mono.CSharp.ParametersCompiled); } }
    public bool Resolved { get { return default(bool); } }
    public Mono.CSharp.StateMachine StateMachine { get { return default(Mono.CSharp.StateMachine); } }
    public int TemporaryLocalsCount { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(int); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public Mono.CSharp.ToplevelBlock TopBlock { get { return default(Mono.CSharp.ToplevelBlock); } set { } }
    public void CheckControlExit(Mono.CSharp.FlowAnalysisContext fc) { }
    public virtual void CheckControlExit(Mono.CSharp.FlowAnalysisContext fc, Mono.CSharp.DefiniteAssignmentBitSet dat) { }
    protected override void CloneTo(Mono.CSharp.CloneContext clonectx, Mono.CSharp.Statement t) { }
    public Mono.CSharp.ParametersBlock ConvertToAsyncTask(Mono.CSharp.IMemberContext context, Mono.CSharp.TypeDefinition host, Mono.CSharp.ParametersCompiled parameters, Mono.CSharp.TypeSpec returnType, Mono.CSharp.TypeSpec delegateType, Mono.CSharp.Location loc) { return default(Mono.CSharp.ParametersBlock); }
    public Mono.CSharp.ToplevelBlock ConvertToIterator(Mono.CSharp.IMethodData method, Mono.CSharp.TypeDefinition host, Mono.CSharp.TypeSpec iterator_type, bool is_enumerable) { return default(Mono.CSharp.ToplevelBlock); }
    public override Mono.CSharp.Expression CreateExpressionTree(Mono.CSharp.ResolveContext ec) { return default(Mono.CSharp.Expression); }
    protected override bool DoFlowAnalysis(Mono.CSharp.FlowAnalysisContext fc) { return default(bool); }
    public override void Emit(Mono.CSharp.EmitContext ec) { }
    public void EmitEmbedded(Mono.CSharp.EmitContext ec) { }
    public Mono.CSharp.LabeledStatement GetLabel(string name, Mono.CSharp.Block block) { return default(Mono.CSharp.LabeledStatement); }
    public Mono.CSharp.ParametersBlock.ParameterInfo GetParameterInfo(Mono.CSharp.Parameter p) { return default(Mono.CSharp.ParametersBlock.ParameterInfo); }
    public Mono.CSharp.ParameterReference GetParameterReference(int index, Mono.CSharp.Location loc) { return default(Mono.CSharp.ParameterReference); }
    public Mono.CSharp.Statement PerformClone() { return default(Mono.CSharp.Statement); }
    protected void ProcessParameters() { }
    public override bool Resolve(Mono.CSharp.BlockContext bc) { return default(bool); }
    public partial class ParameterInfo : Mono.CSharp.INamedBlockVariable {
      public Mono.CSharp.VariableInfo VariableInfo;
      public ParameterInfo(Mono.CSharp.ParametersBlock block, int index) { }
      public Mono.CSharp.ParametersBlock Block { get { return default(Mono.CSharp.ParametersBlock); } }
      public bool IsDeclared { get { return default(bool); } }
      public bool IsLocked { get { return default(bool); } set { } }
      public bool IsParameter { get { return default(bool); } }
      public Mono.CSharp.Location Location { get { return default(Mono.CSharp.Location); } }
      Mono.CSharp.Block Mono.CSharp.INamedBlockVariable.Block { get { return default(Mono.CSharp.Block); } }
      public Mono.CSharp.Parameter Parameter { get { return default(Mono.CSharp.Parameter); } }
      public Mono.CSharp.TypeSpec ParameterType { get { return default(Mono.CSharp.TypeSpec); } }
      public Mono.CSharp.Expression CreateReferenceExpression(Mono.CSharp.ResolveContext rc, Mono.CSharp.Location loc) { return default(Mono.CSharp.Expression); }
    }
  }
  public partial class ParametersCompiled : Mono.CSharp.AParametersCollection {
    public static readonly Mono.CSharp.ParametersCompiled EmptyReadOnlyParameters;
    public static readonly Mono.CSharp.ParametersCompiled Undefined;
    public ParametersCompiled(params Mono.CSharp.Parameter[] parameters) { }
    public ParametersCompiled(Mono.CSharp.Parameter[] parameters, bool has_arglist) { }
    public Mono.CSharp.Parameter this[int pos] { get { return default(Mono.CSharp.Parameter); } }
    public void ApplyAttributes(Mono.CSharp.IMemberContext mc, System.Reflection.MethodBase builder) { }
    public void CheckConstraints(Mono.CSharp.IMemberContext mc) { }
    public void CheckParameters(Mono.CSharp.MemberCore member) { }
    public Mono.CSharp.ParametersCompiled Clone() { return default(Mono.CSharp.ParametersCompiled); }
    public Mono.CSharp.Expression CreateExpressionTree(Mono.CSharp.BlockContext ec, Mono.CSharp.Location loc) { return default(Mono.CSharp.Expression); }
    public static Mono.CSharp.ParametersCompiled CreateFullyResolved(Mono.CSharp.Parameter p, Mono.CSharp.TypeSpec type) { return default(Mono.CSharp.ParametersCompiled); }
    public static Mono.CSharp.ParametersCompiled CreateFullyResolved(Mono.CSharp.Parameter[] parameters, Mono.CSharp.TypeSpec[] types) { return default(Mono.CSharp.ParametersCompiled); }
    public static Mono.CSharp.AParametersCollection CreateFullyResolved(params Mono.CSharp.TypeSpec[] types) { return default(Mono.CSharp.AParametersCollection); }
    public static Mono.CSharp.ParametersCompiled CreateImplicitParameter(Mono.CSharp.FullNamedExpression texpr, Mono.CSharp.Location loc) { return default(Mono.CSharp.ParametersCompiled); }
    public static int IsSameClsSignature(Mono.CSharp.AParametersCollection a, Mono.CSharp.AParametersCollection b) { return default(int); }
    public static Mono.CSharp.ParametersCompiled MergeGenerated(Mono.CSharp.CompilerContext ctx, Mono.CSharp.ParametersCompiled userParams, bool checkConflicts, Mono.CSharp.Parameter compilerParams, Mono.CSharp.TypeSpec compilerTypes) { return default(Mono.CSharp.ParametersCompiled); }
    public static Mono.CSharp.ParametersCompiled MergeGenerated(Mono.CSharp.CompilerContext ctx, Mono.CSharp.ParametersCompiled userParams, bool checkConflicts, Mono.CSharp.Parameter[] compilerParams, Mono.CSharp.TypeSpec[] compilerTypes) { return default(Mono.CSharp.ParametersCompiled); }
    public static Mono.CSharp.ParametersCompiled Prefix(Mono.CSharp.ParametersCompiled parameters, Mono.CSharp.Parameter p, Mono.CSharp.TypeSpec type) { return default(Mono.CSharp.ParametersCompiled); }
    public bool Resolve(Mono.CSharp.IMemberContext ec) { return default(bool); }
    public void ResolveDefaultValues(Mono.CSharp.MemberCore m) { }
    public void VerifyClsCompliance(Mono.CSharp.IMemberContext ctx) { }
  }
  public partial class ParametersImported : Mono.CSharp.AParametersCollection {
    public ParametersImported(Mono.CSharp.IParameterData[] param, Mono.CSharp.TypeSpec[] types, bool hasParams) { }
    public ParametersImported(Mono.CSharp.IParameterData[] parameters, Mono.CSharp.TypeSpec[] types, bool hasArglist, bool hasParams) { }
  }
  public partial class ParamsParameter : Mono.CSharp.Parameter {
    public ParamsParameter(Mono.CSharp.FullNamedExpression type, string name, Mono.CSharp.Attributes attrs, Mono.CSharp.Location loc) : base (default(Mono.CSharp.FullNamedExpression), default(string), default(Mono.CSharp.Parameter.Modifier), default(Mono.CSharp.Attributes), default(Mono.CSharp.Location)) { }
    public override void ApplyAttributes(System.Reflection.Emit.MethodBuilder mb, System.Reflection.Emit.ConstructorBuilder cb, int index, Mono.CSharp.PredefinedAttributes pa) { }
    public override Mono.CSharp.TypeSpec Resolve(Mono.CSharp.IMemberContext ec, int index) { return default(Mono.CSharp.TypeSpec); }
  }
  public partial class ParenthesizedExpression : Mono.CSharp.ShimExpression {
    public ParenthesizedExpression(Mono.CSharp.Expression expr, Mono.CSharp.Location loc) : base (default(Mono.CSharp.Expression)) { }
    public override object Accept(Mono.CSharp.StructuralVisitor visitor) { return default(object); }
    protected override Mono.CSharp.Expression DoResolve(Mono.CSharp.ResolveContext ec) { return default(Mono.CSharp.Expression); }
    public override Mono.CSharp.Expression DoResolveLValue(Mono.CSharp.ResolveContext ec, Mono.CSharp.Expression right_side) { return default(Mono.CSharp.Expression); }
  }
  public partial class ParserSession {
    public readonly System.Char[] IDBuilder;
    public readonly System.Collections.Generic.Dictionary<System.Char[], System.String>[] Identifiers;
    public readonly System.Char[] NumberBuilder;
    public readonly System.Collections.Generic.List<Mono.CSharp.Parameter> ParametersStack;
    public readonly System.Char[] StreamReaderBuffer;
    public ParserSession() { }
    public Mono.CSharp.LocatedToken[] LocatedTokens { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(Mono.CSharp.LocatedToken[]); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public Mono.CSharp.LocationsBag LocationsBag { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(Mono.CSharp.LocationsBag); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public bool UseJayGlobalArrays { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Security.Cryptography.MD5 GetChecksumAlgorithm() { return default(System.Security.Cryptography.MD5); }
  }
  public partial class PendingImplementation {
    internal PendingImplementation() { }
    public static Mono.CSharp.PendingImplementation GetPendingImplementations(Mono.CSharp.TypeDefinition container) { return default(Mono.CSharp.PendingImplementation); }
    public void ImplementMethod(Mono.CSharp.MemberName name, Mono.CSharp.TypeSpec ifaceType, Mono.CSharp.MethodData method, bool clear_one, out Mono.CSharp.MethodSpec ambiguousCandidate, ref bool optional) { ambiguousCandidate = default(Mono.CSharp.MethodSpec); }
    public Mono.CSharp.MethodSpec InterfaceMethod(Mono.CSharp.MemberName name, Mono.CSharp.TypeSpec iType, Mono.CSharp.MethodData method, Mono.CSharp.PendingImplementation.Operation op, out Mono.CSharp.MethodSpec ambiguousCandidate, ref bool optional) { ambiguousCandidate = default(Mono.CSharp.MethodSpec); return default(Mono.CSharp.MethodSpec); }
    public Mono.CSharp.MethodSpec IsInterfaceMethod(Mono.CSharp.MemberName name, Mono.CSharp.TypeSpec ifaceType, Mono.CSharp.MethodData method, out Mono.CSharp.MethodSpec ambiguousCandidate, ref bool optional) { ambiguousCandidate = default(Mono.CSharp.MethodSpec); return default(Mono.CSharp.MethodSpec); }
    public bool VerifyPendingMethods() { return default(bool); }
    public enum Operation {
      ClearAll = 2,
      ClearOne = 1,
      Lookup = 0,
    }
  }
  public enum Platform {
    AnyCPU = 0,
    AnyCPU32Preferred = 1,
    Arm = 2,
    IA64 = 5,
    X64 = 4,
    X86 = 3,
  }
  public partial class PointerArithmetic : Mono.CSharp.Expression {
    public PointerArithmetic(Mono.CSharp.Binary.Operator op, Mono.CSharp.Expression l, Mono.CSharp.Expression r, Mono.CSharp.TypeSpec t, Mono.CSharp.Location loc) { }
    public override bool ContainsEmitWithAwait() { return default(bool); }
    public override Mono.CSharp.Expression CreateExpressionTree(Mono.CSharp.ResolveContext ec) { return default(Mono.CSharp.Expression); }
    protected override Mono.CSharp.Expression DoResolve(Mono.CSharp.ResolveContext ec) { return default(Mono.CSharp.Expression); }
    public override void Emit(Mono.CSharp.EmitContext ec) { }
  }
  public partial class PredefinedAttribute : Mono.CSharp.PredefinedType {
    protected Mono.CSharp.MethodSpec ctor;
    public PredefinedAttribute(Mono.CSharp.ModuleContainer module, string ns, string name) : base (default(Mono.CSharp.ModuleContainer), default(Mono.CSharp.MemberKind), default(string), default(string), default(int)) { }
    public Mono.CSharp.MethodSpec Constructor { get { return default(Mono.CSharp.MethodSpec); } }
    public void EmitAttribute(System.Reflection.Emit.AssemblyBuilder builder) { }
    public void EmitAttribute(System.Reflection.Emit.ConstructorBuilder builder) { }
    public void EmitAttribute(System.Reflection.Emit.FieldBuilder builder) { }
    public void EmitAttribute(System.Reflection.Emit.MethodBuilder builder) { }
    public void EmitAttribute(System.Reflection.Emit.ModuleBuilder builder) { }
    public void EmitAttribute(System.Reflection.Emit.ParameterBuilder builder) { }
    public void EmitAttribute(System.Reflection.Emit.PropertyBuilder builder) { }
    public void EmitAttribute(System.Reflection.Emit.TypeBuilder builder) { }
    public override bool Equals(object obj) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public static bool operator ==(Mono.CSharp.TypeSpec type, Mono.CSharp.PredefinedAttribute pa) { return default(bool); }
    public static bool operator !=(Mono.CSharp.TypeSpec type, Mono.CSharp.PredefinedAttribute pa) { return default(bool); }
    public bool ResolveBuilder() { return default(bool); }
  }
  public partial class PredefinedAttributes {
    public readonly Mono.CSharp.PredefinedAttribute AssemblyAlgorithmId;
    public readonly Mono.CSharp.PredefinedAttribute AssemblyCompany;
    public readonly Mono.CSharp.PredefinedAttribute AssemblyCopyright;
    public readonly Mono.CSharp.PredefinedAttribute AssemblyCulture;
    public readonly Mono.CSharp.PredefinedAttribute AssemblyDescription;
    public readonly Mono.CSharp.PredefinedAttribute AssemblyFileVersion;
    public readonly Mono.CSharp.PredefinedAttribute AssemblyFlags;
    public readonly Mono.CSharp.PredefinedAttribute AssemblyProduct;
    public readonly Mono.CSharp.PredefinedAttribute AssemblyTrademark;
    public readonly Mono.CSharp.PredefinedAttribute AssemblyVersion;
    public readonly Mono.CSharp.PredefinedStateMachineAttribute AsyncStateMachine;
    public readonly Mono.CSharp.PredefinedAttribute AttributeUsage;
    public readonly Mono.CSharp.PredefinedAttribute CallerFilePathAttribute;
    public readonly Mono.CSharp.PredefinedAttribute CallerLineNumberAttribute;
    public readonly Mono.CSharp.PredefinedAttribute CallerMemberNameAttribute;
    public readonly Mono.CSharp.PredefinedAttribute CLSCompliant;
    public readonly Mono.CSharp.PredefinedAttribute CoClass;
    public readonly Mono.CSharp.PredefinedAttribute ComImport;
    public readonly Mono.CSharp.PredefinedAttribute CompilerGenerated;
    public readonly Mono.CSharp.PredefinedAttribute Conditional;
    public readonly Mono.CSharp.PredefinedDebuggableAttribute Debuggable;
    public readonly Mono.CSharp.PredefinedDebuggerBrowsableAttribute DebuggerBrowsable;
    public readonly Mono.CSharp.PredefinedAttribute DebuggerHidden;
    public readonly Mono.CSharp.PredefinedAttribute DebuggerStepThrough;
    public readonly Mono.CSharp.PredefinedDecimalAttribute DecimalConstant;
    public readonly Mono.CSharp.PredefinedAttribute DefaultCharset;
    public readonly Mono.CSharp.PredefinedAttribute DefaultMember;
    public readonly Mono.CSharp.PredefinedAttribute DefaultParameterValue;
    public readonly Mono.CSharp.PredefinedAttribute DllImport;
    public readonly Mono.CSharp.PredefinedDynamicAttribute Dynamic;
    public readonly Mono.CSharp.PredefinedAttribute Extension;
    public readonly Mono.CSharp.PredefinedAttribute FieldOffset;
    public readonly Mono.CSharp.PredefinedAttribute FixedBuffer;
    public readonly Mono.CSharp.PredefinedAttribute Guid;
    public readonly Mono.CSharp.PredefinedAttribute HostProtection;
    public readonly Mono.CSharp.PredefinedAttribute In;
    public readonly Mono.CSharp.PredefinedAttribute IndexerName;
    public readonly Mono.CSharp.PredefinedAttribute InternalsVisibleTo;
    public readonly Mono.CSharp.PredefinedAttribute MarshalAs;
    public readonly Mono.CSharp.PredefinedAttribute MethodImpl;
    public readonly Mono.CSharp.PredefinedAttribute Obsolete;
    public readonly Mono.CSharp.PredefinedAttribute OptionalParameter;
    public readonly Mono.CSharp.PredefinedAttribute Out;
    public readonly Mono.CSharp.PredefinedAttribute ParamArray;
    public readonly Mono.CSharp.PredefinedAttribute Required;
    public readonly Mono.CSharp.PredefinedAttribute RuntimeCompatibility;
    public readonly Mono.CSharp.PredefinedAttribute Security;
    public readonly Mono.CSharp.PredefinedAttribute StructLayout;
    public readonly Mono.CSharp.PredefinedAttribute TypeForwarder;
    public readonly Mono.CSharp.PredefinedAttribute UnmanagedFunctionPointer;
    public readonly Mono.CSharp.PredefinedAttribute UnsafeValueType;
    public readonly Mono.CSharp.PredefinedAttribute UnverifiableCode;
    public PredefinedAttributes(Mono.CSharp.ModuleContainer module) { }
  }
  public partial class PredefinedDebuggableAttribute : Mono.CSharp.PredefinedAttribute {
    public PredefinedDebuggableAttribute(Mono.CSharp.ModuleContainer module, string ns, string name) : base (default(Mono.CSharp.ModuleContainer), default(string), default(string)) { }
    public void EmitAttribute(System.Reflection.Emit.AssemblyBuilder builder, System.Diagnostics.DebuggableAttribute.DebuggingModes modes) { }
  }
  public partial class PredefinedDebuggerBrowsableAttribute : Mono.CSharp.PredefinedAttribute {
    public PredefinedDebuggerBrowsableAttribute(Mono.CSharp.ModuleContainer module, string ns, string name) : base (default(Mono.CSharp.ModuleContainer), default(string), default(string)) { }
    public void EmitAttribute(System.Reflection.Emit.FieldBuilder builder, System.Diagnostics.DebuggerBrowsableState state) { }
  }
  public partial class PredefinedDecimalAttribute : Mono.CSharp.PredefinedAttribute {
    public PredefinedDecimalAttribute(Mono.CSharp.ModuleContainer module, string ns, string name) : base (default(Mono.CSharp.ModuleContainer), default(string), default(string)) { }
    public void EmitAttribute(System.Reflection.Emit.FieldBuilder builder, decimal value, Mono.CSharp.Location loc) { }
    public void EmitAttribute(System.Reflection.Emit.ParameterBuilder builder, decimal value, Mono.CSharp.Location loc) { }
  }
  public partial class PredefinedDynamicAttribute : Mono.CSharp.PredefinedAttribute {
    public PredefinedDynamicAttribute(Mono.CSharp.ModuleContainer module, string ns, string name) : base (default(Mono.CSharp.ModuleContainer), default(string), default(string)) { }
    public void EmitAttribute(System.Reflection.Emit.FieldBuilder builder, Mono.CSharp.TypeSpec type, Mono.CSharp.Location loc) { }
    public void EmitAttribute(System.Reflection.Emit.ParameterBuilder builder, Mono.CSharp.TypeSpec type, Mono.CSharp.Location loc) { }
    public void EmitAttribute(System.Reflection.Emit.PropertyBuilder builder, Mono.CSharp.TypeSpec type, Mono.CSharp.Location loc) { }
    public void EmitAttribute(System.Reflection.Emit.TypeBuilder builder, Mono.CSharp.TypeSpec type, Mono.CSharp.Location loc) { }
  }
  public partial class PredefinedMember<T> where T : Mono.CSharp.MemberSpec {
    public PredefinedMember(Mono.CSharp.ModuleContainer module, Mono.CSharp.BuiltinTypeSpec type, string name, params Mono.CSharp.TypeSpec[] types) { }
    public PredefinedMember(Mono.CSharp.ModuleContainer module, Mono.CSharp.PredefinedType type, Mono.CSharp.MemberFilter filter) { }
    public PredefinedMember(Mono.CSharp.ModuleContainer module, Mono.CSharp.PredefinedType type, string name, Mono.CSharp.MemberKind kind, params Mono.CSharp.PredefinedType[] types) { }
    public PredefinedMember(Mono.CSharp.ModuleContainer module, Mono.CSharp.PredefinedType type, string name, Mono.CSharp.MemberKind kind, System.Func<Mono.CSharp.TypeSpec[]> typesBuilder, Mono.CSharp.TypeSpec returnType) { }
    public PredefinedMember(Mono.CSharp.ModuleContainer module, Mono.CSharp.PredefinedType type, string name, params Mono.CSharp.TypeSpec[] types) { }
    public PredefinedMember(Mono.CSharp.ModuleContainer module, Mono.CSharp.TypeSpec type, Mono.CSharp.MemberFilter filter) { }
    public T Get() { return default(T); }
    public T Resolve(Mono.CSharp.Location loc) { return default(T); }
  }
  public partial class PredefinedStateMachineAttribute : Mono.CSharp.PredefinedAttribute {
    public PredefinedStateMachineAttribute(Mono.CSharp.ModuleContainer module, string ns, string name) : base (default(Mono.CSharp.ModuleContainer), default(string), default(string)) { }
    public void EmitAttribute(System.Reflection.Emit.MethodBuilder builder, Mono.CSharp.StateMachine type) { }
  }
  public partial class PredefinedType {
    protected readonly Mono.CSharp.ModuleContainer module;
    protected Mono.CSharp.TypeSpec type;
    public PredefinedType(Mono.CSharp.BuiltinTypeSpec type) { }
    public PredefinedType(Mono.CSharp.ModuleContainer module, Mono.CSharp.MemberKind kind, string ns, string name) { }
    public PredefinedType(Mono.CSharp.ModuleContainer module, Mono.CSharp.MemberKind kind, string ns, string name, int arity) { }
    public int Arity { get { return default(int); } }
    public bool IsDefined { get { return default(bool); } }
    public string Name { get { return default(string); } }
    public string Namespace { get { return default(string); } }
    public Mono.CSharp.TypeSpec TypeSpec { get { return default(Mono.CSharp.TypeSpec); } }
    public bool Define() { return default(bool); }
    public string GetSignatureForError() { return default(string); }
    public Mono.CSharp.TypeSpec Resolve() { return default(Mono.CSharp.TypeSpec); }
    public static Mono.CSharp.TypeSpec Resolve(Mono.CSharp.ModuleContainer module, Mono.CSharp.MemberKind kind, string ns, string name, int arity, bool required, bool reportErrors) { return default(Mono.CSharp.TypeSpec); }
  }
  public abstract partial class Probe : Mono.CSharp.Expression {
    protected Mono.CSharp.Expression expr;
    protected Mono.CSharp.TypeSpec probe_type_expr;
    public Mono.CSharp.Expression ProbeType;
    protected Probe(Mono.CSharp.Expression expr, Mono.CSharp.Expression probe_type, Mono.CSharp.Location l) { }
    public Mono.CSharp.Expression Expr { get { return default(Mono.CSharp.Expression); } }
    protected abstract string OperatorName { get; }
    protected override void CloneTo(Mono.CSharp.CloneContext clonectx, Mono.CSharp.Expression t) { }
    public override bool ContainsEmitWithAwait() { return default(bool); }
    public override void EmitSideEffect(Mono.CSharp.EmitContext ec) { }
    public override void FlowAnalysis(Mono.CSharp.FlowAnalysisContext fc) { }
    protected Mono.CSharp.Expression ResolveCommon(Mono.CSharp.ResolveContext rc) { return default(Mono.CSharp.Expression); }
    protected virtual void ResolveProbeType(Mono.CSharp.ResolveContext rc) { }
  }
  public partial class Property : Mono.CSharp.PropertyBase {
    public Property(Mono.CSharp.TypeDefinition parent, Mono.CSharp.FullNamedExpression type, Mono.CSharp.Modifiers mod, Mono.CSharp.MemberName name, Mono.CSharp.Attributes attrs) : base (default(Mono.CSharp.TypeDefinition), default(Mono.CSharp.FullNamedExpression), default(Mono.CSharp.Modifiers), default(Mono.CSharp.Modifiers), default(Mono.CSharp.MemberName), default(Mono.CSharp.Attributes)) { }
    public Mono.CSharp.Expression Initializer { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(Mono.CSharp.Expression); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public override System.String[] ValidAttributeTargets { get { return default(System.String[]); } }
    public override void Accept(Mono.CSharp.StructuralVisitor visitor) { }
    public override void ApplyAttributeBuilder(Mono.CSharp.Attribute a, Mono.CSharp.MethodSpec ctor, System.Byte[] cdata, Mono.CSharp.PredefinedAttributes pa) { }
    public override bool Define() { return default(bool); }
    public override void Emit() { }
    public sealed partial class BackingField : Mono.CSharp.Field {
      public BackingField(Mono.CSharp.Property p, bool readOnly) : base (default(Mono.CSharp.TypeDefinition), default(Mono.CSharp.FullNamedExpression), default(Mono.CSharp.Modifiers), default(Mono.CSharp.MemberName), default(Mono.CSharp.Attributes)) { }
      public Mono.CSharp.Property OriginalProperty { get { return default(Mono.CSharp.Property); } }
      public override string GetSignatureForError() { return default(string); }
    }
  }
  public abstract partial class PropertyBase : Mono.CSharp.PropertyBasedMember {
    protected PropertyBase(Mono.CSharp.TypeDefinition parent, Mono.CSharp.FullNamedExpression type, Mono.CSharp.Modifiers mod_flags, Mono.CSharp.Modifiers allowed_mod, Mono.CSharp.MemberName name, Mono.CSharp.Attributes attrs) : base (default(Mono.CSharp.TypeDefinition), default(Mono.CSharp.FullNamedExpression), default(Mono.CSharp.Modifiers), default(Mono.CSharp.Modifiers), default(Mono.CSharp.MemberName), default(Mono.CSharp.Attributes)) { }
    public Mono.CSharp.PropertyBase.PropertyMethod AccessorFirst { get { return default(Mono.CSharp.PropertyBase.PropertyMethod); } }
    public Mono.CSharp.PropertyBase.PropertyMethod AccessorSecond { get { return default(Mono.CSharp.PropertyBase.PropertyMethod); } }
    public override System.AttributeTargets AttributeTargets { get { return default(System.AttributeTargets); } }
    public override string DocCommentHeader { get { return default(string); } }
    public override Mono.CSharp.Variance ExpectedMemberTypeVariance { get { return default(Mono.CSharp.Variance); } }
    public Mono.CSharp.PropertyBase.PropertyMethod Get { get { return default(Mono.CSharp.PropertyBase.PropertyMethod); } set { } }
    public override bool IsUsed { get { return default(bool); } }
    public Mono.CSharp.PropertyBase.PropertyMethod Set { get { return default(Mono.CSharp.PropertyBase.PropertyMethod); } set { } }
    public override System.String[] ValidAttributeTargets { get { return default(System.String[]); } }
    public override void ApplyAttributeBuilder(Mono.CSharp.Attribute a, Mono.CSharp.MethodSpec ctor, System.Byte[] cdata, Mono.CSharp.PredefinedAttributes pa) { }
    protected override bool CheckOverrideAgainstBase(Mono.CSharp.MemberSpec base_member) { return default(bool); }
    protected bool DefineAccessors() { return default(bool); }
    protected void DefineBuilders(Mono.CSharp.MemberKind kind, Mono.CSharp.ParametersCompiled parameters) { }
    protected override void DoMemberTypeDependentChecks() { }
    protected override void DoMemberTypeIndependentChecks() { }
    public override void Emit() { }
    public override void PrepareEmit() { }
    protected override void SetMemberName(Mono.CSharp.MemberName new_name) { }
    public override void WriteDebugSymbol(Mono.CompilerServices.SymbolWriter.MonoSymbolFile file) { }
    public partial class GetMethod : Mono.CSharp.PropertyBase.PropertyMethod {
      public GetMethod(Mono.CSharp.PropertyBase method, Mono.CSharp.Modifiers modifiers, Mono.CSharp.Attributes attrs, Mono.CSharp.Location loc) : base (default(Mono.CSharp.PropertyBase), default(string), default(Mono.CSharp.Modifiers), default(Mono.CSharp.Attributes), default(Mono.CSharp.Location)) { }
      public override Mono.CSharp.ParametersCompiled ParameterInfo { get { return default(Mono.CSharp.ParametersCompiled); } }
      public override Mono.CSharp.TypeSpec ReturnType { get { return default(Mono.CSharp.TypeSpec); } }
      public override System.String[] ValidAttributeTargets { get { return default(System.String[]); } }
      public override void Define(Mono.CSharp.TypeContainer parent) { }
    }
    public abstract partial class PropertyMethod : Mono.CSharp.AbstractPropertyEventMethod {
      protected System.Reflection.MethodAttributes flags;
      protected readonly Mono.CSharp.PropertyBase method;
      public PropertyMethod(Mono.CSharp.PropertyBase method, string prefix, Mono.CSharp.Modifiers modifiers, Mono.CSharp.Attributes attrs, Mono.CSharp.Location loc) : base (default(Mono.CSharp.InterfaceMemberBase), default(string), default(Mono.CSharp.Attributes), default(Mono.CSharp.Location)) { }
      public override System.AttributeTargets AttributeTargets { get { return default(System.AttributeTargets); } }
      public bool HasCustomAccessModifier { get { return default(bool); } }
      public Mono.CSharp.PropertyBase Property { get { return default(Mono.CSharp.PropertyBase); } }
      public override void ApplyAttributeBuilder(Mono.CSharp.Attribute a, Mono.CSharp.MethodSpec ctor, System.Byte[] cdata, Mono.CSharp.PredefinedAttributes pa) { }
      public virtual void Define(Mono.CSharp.TypeContainer parent) { }
      public override System.ObsoleteAttribute GetAttributeObsolete() { return default(System.ObsoleteAttribute); }
      public override string GetSignatureForError() { return default(string); }
      public override bool IsClsComplianceRequired() { return default(bool); }
    }
    public partial class SetMethod : Mono.CSharp.PropertyBase.PropertyMethod {
      protected Mono.CSharp.ParametersCompiled parameters;
      public SetMethod(Mono.CSharp.PropertyBase method, Mono.CSharp.Modifiers modifiers, Mono.CSharp.ParametersCompiled parameters, Mono.CSharp.Attributes attrs, Mono.CSharp.Location loc) : base (default(Mono.CSharp.PropertyBase), default(string), default(Mono.CSharp.Modifiers), default(Mono.CSharp.Attributes), default(Mono.CSharp.Location)) { }
      public override Mono.CSharp.ParametersCompiled ParameterInfo { get { return default(Mono.CSharp.ParametersCompiled); } }
      public override Mono.CSharp.TypeSpec ReturnType { get { return default(Mono.CSharp.TypeSpec); } }
      public override System.String[] ValidAttributeTargets { get { return default(System.String[]); } }
      protected override void ApplyToExtraTarget(Mono.CSharp.Attribute a, Mono.CSharp.MethodSpec ctor, System.Byte[] cdata, Mono.CSharp.PredefinedAttributes pa) { }
      public override void Define(Mono.CSharp.TypeContainer parent) { }
    }
  }
  public abstract partial class PropertyBasedMember : Mono.CSharp.InterfaceMemberBase {
    protected PropertyBasedMember(Mono.CSharp.TypeDefinition parent, Mono.CSharp.FullNamedExpression type, Mono.CSharp.Modifiers mod, Mono.CSharp.Modifiers allowed_mod, Mono.CSharp.MemberName name, Mono.CSharp.Attributes attrs) : base (default(Mono.CSharp.TypeDefinition), default(Mono.CSharp.FullNamedExpression), default(Mono.CSharp.Modifiers), default(Mono.CSharp.Modifiers), default(Mono.CSharp.MemberName), default(Mono.CSharp.Attributes)) { }
    protected void CheckReservedNameConflict(string prefix, Mono.CSharp.MethodSpec accessor) { }
    public abstract void PrepareEmit();
    protected override bool VerifyClsCompliance() { return default(bool); }
  }
  public partial class PropertySpec : Mono.CSharp.MemberSpec, Mono.CSharp.IInterfaceMemberSpec {
    public PropertySpec(Mono.CSharp.MemberKind kind, Mono.CSharp.TypeSpec declaringType, Mono.CSharp.IMemberDefinition definition, Mono.CSharp.TypeSpec memberType, System.Reflection.PropertyInfo info, Mono.CSharp.Modifiers modifiers) : base (default(Mono.CSharp.MemberKind), default(Mono.CSharp.TypeSpec), default(Mono.CSharp.IMemberDefinition), default(Mono.CSharp.Modifiers)) { }
    public Mono.CSharp.MethodSpec Get { get { return default(Mono.CSharp.MethodSpec); } set { } }
    public bool HasDifferentAccessibility { get { return default(bool); } }
    public bool HasGet { get { return default(bool); } }
    public bool HasSet { get { return default(bool); } }
    public Mono.CSharp.TypeSpec MemberType { get { return default(Mono.CSharp.TypeSpec); } }
    public System.Reflection.PropertyInfo MetaInfo { get { return default(System.Reflection.PropertyInfo); } }
    public Mono.CSharp.MethodSpec Set { get { return default(Mono.CSharp.MethodSpec); } set { } }
    public override Mono.CSharp.MemberSpec InflateMember(Mono.CSharp.TypeParameterInflator inflator) { return default(Mono.CSharp.MemberSpec); }
    public override System.Collections.Generic.List<Mono.CSharp.MissingTypeSpecReference> ResolveMissingDependencies(Mono.CSharp.MemberSpec caller) { return default(System.Collections.Generic.List<Mono.CSharp.MissingTypeSpecReference>); }
  }
  public partial class QualifiedAliasMember : Mono.CSharp.MemberAccess {
    public static readonly string GlobalAlias;
    public QualifiedAliasMember(string alias, string identifier, Mono.CSharp.Location l) : base (default(Mono.CSharp.Expression), default(string)) { }
    public QualifiedAliasMember(string alias, string identifier, Mono.CSharp.TypeArguments targs, Mono.CSharp.Location l) : base (default(Mono.CSharp.Expression), default(string)) { }
    public QualifiedAliasMember(string alias, string identifier, int arity, Mono.CSharp.Location l) : base (default(Mono.CSharp.Expression), default(string)) { }
    public string Alias { get { return default(string); } }
    public override object Accept(Mono.CSharp.StructuralVisitor visitor) { return default(object); }
    protected override void CloneTo(Mono.CSharp.CloneContext clonectx, Mono.CSharp.Expression t) { }
    public Mono.CSharp.FullNamedExpression CreateExpressionFromAlias(Mono.CSharp.IMemberContext mc) { return default(Mono.CSharp.FullNamedExpression); }
    protected override Mono.CSharp.Expression DoResolve(Mono.CSharp.ResolveContext rc) { return default(Mono.CSharp.Expression); }
    public override string GetSignatureForError() { return default(string); }
    public override bool HasConditionalAccess() { return default(bool); }
    public override Mono.CSharp.Expression LookupNameExpression(Mono.CSharp.ResolveContext rc, Mono.CSharp.Expression.MemberLookupRestrictions restrictions) { return default(Mono.CSharp.Expression); }
    public override Mono.CSharp.FullNamedExpression ResolveAsTypeOrNamespace(Mono.CSharp.IMemberContext mc, bool allowUnboundTypeArguments) { return default(Mono.CSharp.FullNamedExpression); }
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct Reachability {
    public bool IsUnreachable { get { return default(bool); } }
    public static Mono.CSharp.Reachability CreateUnreachable() { return default(Mono.CSharp.Reachability); }
    public static Mono.CSharp.Reachability operator &(Mono.CSharp.Reachability a, Mono.CSharp.Reachability b) { return default(Mono.CSharp.Reachability); }
    public static Mono.CSharp.Reachability operator |(Mono.CSharp.Reachability a, Mono.CSharp.Reachability b) { return default(Mono.CSharp.Reachability); }
  }
  public partial class ReducedExpression : Mono.CSharp.Expression {
    internal ReducedExpression() { }
    public override bool IsSideEffectFree { get { return default(bool); } }
    public Mono.CSharp.Expression OriginalExpression { get { return default(Mono.CSharp.Expression); } }
    public override bool ContainsEmitWithAwait() { return default(bool); }
    public static Mono.CSharp.Constant Create(Mono.CSharp.Constant expr, Mono.CSharp.Expression original_expr) { return default(Mono.CSharp.Constant); }
    public static Mono.CSharp.Expression Create(Mono.CSharp.Expression expr, Mono.CSharp.Expression original_expr) { return default(Mono.CSharp.Expression); }
    public static Mono.CSharp.Expression Create(Mono.CSharp.Expression expr, Mono.CSharp.Expression original_expr, bool canBeConstant) { return default(Mono.CSharp.Expression); }
    public static Mono.CSharp.ExpressionStatement Create(Mono.CSharp.ExpressionStatement s, Mono.CSharp.Expression orig) { return default(Mono.CSharp.ExpressionStatement); }
    public override Mono.CSharp.Expression CreateExpressionTree(Mono.CSharp.ResolveContext ec) { return default(Mono.CSharp.Expression); }
    protected override Mono.CSharp.Expression DoResolve(Mono.CSharp.ResolveContext ec) { return default(Mono.CSharp.Expression); }
    public override void Emit(Mono.CSharp.EmitContext ec) { }
    public override void EmitBranchable(Mono.CSharp.EmitContext ec, System.Reflection.Emit.Label target, bool on_true) { }
    public override Mono.CSharp.Expression EmitToField(Mono.CSharp.EmitContext ec) { return default(Mono.CSharp.Expression); }
    public override void FlowAnalysis(Mono.CSharp.FlowAnalysisContext fc) { }
    public override System.Linq.Expressions.Expression MakeExpression(Mono.CSharp.BuilderContext ctx) { return default(System.Linq.Expressions.Expression); }
    public sealed partial class ReducedConstantExpression : Mono.CSharp.EmptyConstantCast {
      public ReducedConstantExpression(Mono.CSharp.Constant expr, Mono.CSharp.Expression orig_expr) : base (default(Mono.CSharp.Constant), default(Mono.CSharp.TypeSpec)) { }
      public Mono.CSharp.Expression OriginalExpression { get { return default(Mono.CSharp.Expression); } }
      public override Mono.CSharp.Constant ConvertExplicitly(bool in_checked_context, Mono.CSharp.TypeSpec target_type) { return default(Mono.CSharp.Constant); }
      public override Mono.CSharp.Constant ConvertImplicitly(Mono.CSharp.TypeSpec target_type) { return default(Mono.CSharp.Constant); }
      public override Mono.CSharp.Expression CreateExpressionTree(Mono.CSharp.ResolveContext ec) { return default(Mono.CSharp.Expression); }
      public override void EncodeAttributeValue(Mono.CSharp.IMemberContext rc, Mono.CSharp.AttributeEncoder enc, Mono.CSharp.TypeSpec targetType, Mono.CSharp.TypeSpec parameterType) { }
    }
  }
  public sealed partial class ReflectionImporter : Mono.CSharp.MetadataImporter {
    public ReflectionImporter(Mono.CSharp.ModuleContainer module, Mono.CSharp.BuiltinTypes builtin) : base (default(Mono.CSharp.ModuleContainer)) { }
    public override void AddCompiledType(System.Reflection.Emit.TypeBuilder builder, Mono.CSharp.TypeSpec spec) { }
    protected override Mono.CSharp.MemberKind DetermineKindFromBaseType(System.Type baseType) { return default(Mono.CSharp.MemberKind); }
    protected override bool HasVolatileModifier(System.Type[] modifiers) { return default(bool); }
    public void ImportAssembly(System.Reflection.Assembly assembly, Mono.CSharp.RootNamespace targetNamespace) { }
    public Mono.CSharp.ImportedModuleDefinition ImportModule(System.Reflection.Module module, Mono.CSharp.RootNamespace targetNamespace) { return default(Mono.CSharp.ImportedModuleDefinition); }
  }
  public partial class RefTypeExpr : Mono.CSharp.ShimExpression {
    public RefTypeExpr(Mono.CSharp.Expression expr, Mono.CSharp.Location loc) : base (default(Mono.CSharp.Expression)) { }
    public override object Accept(Mono.CSharp.StructuralVisitor visitor) { return default(object); }
    protected override Mono.CSharp.Expression DoResolve(Mono.CSharp.ResolveContext rc) { return default(Mono.CSharp.Expression); }
    public override void Emit(Mono.CSharp.EmitContext ec) { }
  }
  public partial class RefValueExpr : Mono.CSharp.ShimExpression, Mono.CSharp.IAssignMethod {
    public RefValueExpr(Mono.CSharp.Expression expr, Mono.CSharp.FullNamedExpression texpr, Mono.CSharp.Location loc) : base (default(Mono.CSharp.Expression)) { }
    public Mono.CSharp.FullNamedExpression TypeExpression { get { return default(Mono.CSharp.FullNamedExpression); } }
    public override object Accept(Mono.CSharp.StructuralVisitor visitor) { return default(object); }
    public override bool ContainsEmitWithAwait() { return default(bool); }
    protected override Mono.CSharp.Expression DoResolve(Mono.CSharp.ResolveContext rc) { return default(Mono.CSharp.Expression); }
    public override Mono.CSharp.Expression DoResolveLValue(Mono.CSharp.ResolveContext rc, Mono.CSharp.Expression right_side) { return default(Mono.CSharp.Expression); }
    public override void Emit(Mono.CSharp.EmitContext ec) { }
    public void Emit(Mono.CSharp.EmitContext ec, bool leave_copy) { }
    public void EmitAssign(Mono.CSharp.EmitContext ec, Mono.CSharp.Expression source, bool leave_copy, bool isCompound) { }
  }
  public partial class Report {
    public static readonly System.Int32[] AllWarnings;
    public const int RuntimeErrorId = 10000;
    public Report(Mono.CSharp.CompilerContext context, Mono.CSharp.ReportPrinter printer) { }
    public int Errors { get { return default(int); } }
    public bool IsDisabled { get { return default(bool); } }
    public Mono.CSharp.ReportPrinter Printer { get { return default(Mono.CSharp.ReportPrinter); } }
    public int Warnings { get { return default(int); } }
    public bool CheckWarningCode(int code, Mono.CSharp.Location loc) { return default(bool); }
    [System.Diagnostics.ConditionalAttribute("MCS_DEBUG")]
    public static void Debug(int category, string message, params System.Object[] args) { }
    [System.Diagnostics.ConditionalAttribute("MCS_DEBUG")]
    public static void Debug(string message, params System.Object[] args) { }
    public void DisableReporting() { }
    public void EnableReporting() { }
    public void Error(int code, Mono.CSharp.Location loc, string error) { }
    public void Error(int code, Mono.CSharp.Location loc, string format, string arg) { }
    public void Error(int code, Mono.CSharp.Location loc, string format, string arg1, string arg2) { }
    public void Error(int code, Mono.CSharp.Location loc, string format, params System.String[] args) { }
    public void Error(int code, string error) { }
    public void Error(int code, string format, string arg) { }
    public void Error(int code, string format, string arg1, string arg2) { }
    public void Error(int code, string format, params System.String[] args) { }
    public void ExtraInformation(Mono.CSharp.Location loc, string msg) { }
    public void FeatureIsNotAvailable(Mono.CSharp.CompilerContext compiler, Mono.CSharp.Location loc, string feature) { }
    public void FeatureIsNotSupported(Mono.CSharp.Location loc, string feature) { }
    public Mono.CSharp.WarningRegions RegisterWarningRegion(Mono.CSharp.Location location) { return default(Mono.CSharp.WarningRegions); }
    public void RuntimeMissingSupport(Mono.CSharp.Location loc, string feature) { }
    public Mono.CSharp.ReportPrinter SetPrinter(Mono.CSharp.ReportPrinter printer) { return default(Mono.CSharp.ReportPrinter); }
    public void SymbolRelatedToPreviousError(Mono.CSharp.Location loc, string symbol) { }
    public void SymbolRelatedToPreviousError(Mono.CSharp.MemberCore mc) { }
    public void SymbolRelatedToPreviousError(Mono.CSharp.MemberSpec ms) { }
    public void SymbolRelatedToPreviousError(string loc) { }
    public void Warning(int code, int level, Mono.CSharp.Location loc, string message) { }
    public void Warning(int code, int level, Mono.CSharp.Location loc, string format, params System.Object[] args) { }
    public void Warning(int code, int level, Mono.CSharp.Location loc, string format, string arg) { }
    public void Warning(int code, int level, Mono.CSharp.Location loc, string format, string arg1, string arg2) { }
    public void Warning(int code, int level, string message) { }
    public void Warning(int code, int level, string format, string arg) { }
    public void Warning(int code, int level, string format, string arg1, string arg2) { }
    public void Warning(int code, int level, string format, params System.String[] args) { }
  }
  public abstract partial class ReportPrinter {
    protected System.Collections.Generic.HashSet<Mono.CSharp.ITypeDefinition> reported_missing_definitions;
    protected ReportPrinter() { }
    public int ErrorsCount { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(int); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]protected set { } }
    public virtual bool HasRelatedSymbolSupport { get { return default(bool); } }
    public int WarningsCount { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(int); } }
    protected virtual string FormatText(string txt) { return default(string); }
    public bool MissingTypeReported(Mono.CSharp.ITypeDefinition typeDefinition) { return default(bool); }
    public virtual void Print(Mono.CSharp.AbstractMessage msg, bool showFullPath) { }
    protected void Print(Mono.CSharp.AbstractMessage msg, System.IO.TextWriter output, bool showFullPath) { }
    public void Reset() { }
  }
  public partial class ResolveContext : Mono.CSharp.IMemberContext, Mono.CSharp.IModuleContext {
    public Mono.CSharp.AnonymousExpression CurrentAnonymousMethod;
    public Mono.CSharp.Block CurrentBlock;
    public Mono.CSharp.Expression CurrentInitializerVariable;
    protected Mono.CSharp.ResolveContext.Options flags;
    public readonly Mono.CSharp.IMemberContext MemberContext;
    public ResolveContext(Mono.CSharp.IMemberContext mc) { }
    public ResolveContext(Mono.CSharp.IMemberContext mc, Mono.CSharp.ResolveContext.Options options) { }
    public Mono.CSharp.BuiltinTypes BuiltinTypes { get { return default(Mono.CSharp.BuiltinTypes); } }
    public bool ConstantCheckState { get { return default(bool); } }
    public virtual Mono.CSharp.ExplicitBlock ConstructorBlock { get { return default(Mono.CSharp.ExplicitBlock); } }
    public Mono.CSharp.Iterator CurrentIterator { get { return default(Mono.CSharp.Iterator); } }
    public Mono.CSharp.MemberCore CurrentMemberDefinition { get { return default(Mono.CSharp.MemberCore); } }
    public Mono.CSharp.TypeSpec CurrentType { get { return default(Mono.CSharp.TypeSpec); } }
    public Mono.CSharp.TypeParameters CurrentTypeParameters { get { return default(Mono.CSharp.TypeParameters); } }
    public bool IsInProbingMode { get { return default(bool); } }
    public bool IsObsolete { get { return default(bool); } }
    public bool IsRuntimeBinder { get { return default(bool); } }
    public bool IsStatic { get { return default(bool); } }
    public bool IsUnsafe { get { return default(bool); } }
    public bool IsVariableCapturingRequired { get { return default(bool); } }
    public Mono.CSharp.ModuleContainer Module { get { return default(Mono.CSharp.ModuleContainer); } }
    public Mono.CSharp.Report Report { get { return default(Mono.CSharp.Report); } }
    public string GetSignatureForError() { return default(string); }
    public bool HasAny(Mono.CSharp.ResolveContext.Options options) { return default(bool); }
    public bool HasSet(Mono.CSharp.ResolveContext.Options options) { return default(bool); }
    public Mono.CSharp.ExtensionMethodCandidates LookupExtensionMethod(Mono.CSharp.TypeSpec extensionType, string name, int arity) { return default(Mono.CSharp.ExtensionMethodCandidates); }
    public Mono.CSharp.FullNamedExpression LookupNamespaceAlias(string name) { return default(Mono.CSharp.FullNamedExpression); }
    public Mono.CSharp.FullNamedExpression LookupNamespaceOrType(string name, int arity, Mono.CSharp.LookupMode mode, Mono.CSharp.Location loc) { return default(Mono.CSharp.FullNamedExpression); }
    public bool MustCaptureVariable(Mono.CSharp.INamedBlockVariable local) { return default(bool); }
    public Mono.CSharp.ResolveContext.FlagsHandle Set(Mono.CSharp.ResolveContext.Options options) { return default(Mono.CSharp.ResolveContext.FlagsHandle); }
    public Mono.CSharp.ResolveContext.FlagsHandle With(Mono.CSharp.ResolveContext.Options options, bool enable) { return default(Mono.CSharp.ResolveContext.FlagsHandle); }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct FlagsHandle : System.IDisposable {
      public FlagsHandle(Mono.CSharp.ResolveContext ec, Mono.CSharp.ResolveContext.Options flagsToSet) { throw new System.NotImplementedException(); }
      public void Dispose() { }
    }
    [System.FlagsAttribute]
    public enum Options {
      AllCheckStateFlags = 3,
      BaseInitializer = 256,
      CatchScope = 8,
      CheckedScope = 1,
      CompoundAssignmentScope = 64,
      ConditionalAccessReceiver = 65536,
      ConstantCheckState = 2,
      ConstantScope = 1024,
      ConstructorScope = 2048,
      EnumScope = 512,
      ExpressionTreeConversion = 33554432,
      FieldInitializerScope = 32,
      FinallyScope = 16,
      FixedInitializerScope = 128,
      InferReturnType = 8388608,
      InvokeSpecialName = 67108864,
      LockScope = 8192,
      OmitDebuggingInfo = 16777216,
      ProbingMode = 4194304,
      TryScope = 16384,
      TryWithCatchScope = 32768,
      UnsafeScope = 4,
      UsingInitializerScope = 4096,
    }
  }
  [System.FlagsAttribute]
  public enum ResolveFlags {
    MaskExprClass = 15,
    MethodGroup = 4,
    Type = 2,
    TypeParameter = 8,
    VariableOrValue = 1,
  }
  public abstract partial class ResumableStatement : Mono.CSharp.Statement {
    protected System.Reflection.Emit.Label resume_point;
    protected ResumableStatement() { }
    public virtual void EmitForDispose(Mono.CSharp.EmitContext ec, System.Reflection.Emit.LocalBuilder pc, System.Reflection.Emit.Label end, bool have_dispatcher) { }
    public virtual System.Reflection.Emit.Label PrepareForDispose(Mono.CSharp.EmitContext ec, System.Reflection.Emit.Label end) { return default(System.Reflection.Emit.Label); }
    public System.Reflection.Emit.Label PrepareForEmit(Mono.CSharp.EmitContext ec) { return default(System.Reflection.Emit.Label); }
  }
  public partial class Return : Mono.CSharp.ExitStatement {
    public Return(Mono.CSharp.Expression expr, Mono.CSharp.Location l) { }
    public Mono.CSharp.Expression Expr { get { return default(Mono.CSharp.Expression); } protected set { } }
    protected override bool IsLocalExit { get { return default(bool); } }
    public override object Accept(Mono.CSharp.StructuralVisitor visitor) { return default(object); }
    protected override void CloneTo(Mono.CSharp.CloneContext clonectx, Mono.CSharp.Statement t) { }
    protected override void DoEmit(Mono.CSharp.EmitContext ec) { }
    protected override bool DoFlowAnalysis(Mono.CSharp.FlowAnalysisContext fc) { return default(bool); }
    protected override bool DoResolve(Mono.CSharp.BlockContext ec) { return default(bool); }
    public override Mono.CSharp.Reachability MarkReachable(Mono.CSharp.Reachability rc) { return default(Mono.CSharp.Reachability); }
  }
  public partial class ReturnParameter : Mono.CSharp.ParameterBase {
    public ReturnParameter(Mono.CSharp.MemberCore method, System.Reflection.Emit.MethodBuilder mb, Mono.CSharp.Location location) { }
    public override System.AttributeTargets AttributeTargets { get { return default(System.AttributeTargets); } }
    public override System.String[] ValidAttributeTargets { get { return default(System.String[]); } }
    public override void ApplyAttributeBuilder(Mono.CSharp.Attribute a, Mono.CSharp.MethodSpec ctor, System.Byte[] cdata, Mono.CSharp.PredefinedAttributes pa) { }
  }
  public partial class RootContext {
    public RootContext() { }
    public static Mono.CSharp.ModuleContainer ToplevelTypes { get { return default(Mono.CSharp.ModuleContainer); } set { } }
  }
  public partial class RootNamespace : Mono.CSharp.Namespace {
    public RootNamespace(string alias_name) { }
    public string Alias { get { return default(string); } }
    public static void Error_GlobalNamespaceRedefined(Mono.CSharp.Report report, Mono.CSharp.Location loc) { }
    public System.Collections.Generic.List<System.String> FindExtensionMethodNamespaces(Mono.CSharp.IMemberContext ctx, string name, int arity) { return default(System.Collections.Generic.List<System.String>); }
    public System.Collections.Generic.List<System.String> FindTypeNamespaces(Mono.CSharp.IMemberContext ctx, string name, int arity) { return default(System.Collections.Generic.List<System.String>); }
    public override string GetSignatureForError() { return default(string); }
    public void RegisterNamespace(Mono.CSharp.Namespace child) { }
  }
  public partial class RuntimeExplicitAssign : Mono.CSharp.Assign {
    public RuntimeExplicitAssign(Mono.CSharp.Expression target, Mono.CSharp.Expression source) : base (default(Mono.CSharp.Expression), default(Mono.CSharp.Expression), default(Mono.CSharp.Location)) { }
    protected override Mono.CSharp.Expression ResolveConversions(Mono.CSharp.ResolveContext ec) { return default(Mono.CSharp.Expression); }
  }
  public partial class RuntimeValueExpression : Mono.CSharp.Expression, Mono.CSharp.IAssignMethod, Mono.CSharp.IMemoryLocation {
    public RuntimeValueExpression(Mono.CSharp.RuntimeValueExpression.DynamicMetaObject obj, Mono.CSharp.TypeSpec type) { }
    public bool IsSuggestionOnly { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public Mono.CSharp.RuntimeValueExpression.DynamicMetaObject MetaObject { get { return default(Mono.CSharp.RuntimeValueExpression.DynamicMetaObject); } }
    public void AddressOf(Mono.CSharp.EmitContext ec, Mono.CSharp.AddressOp mode) { }
    public override bool ContainsEmitWithAwait() { return default(bool); }
    public override Mono.CSharp.Expression CreateExpressionTree(Mono.CSharp.ResolveContext ec) { return default(Mono.CSharp.Expression); }
    protected override Mono.CSharp.Expression DoResolve(Mono.CSharp.ResolveContext ec) { return default(Mono.CSharp.Expression); }
    public override Mono.CSharp.Expression DoResolveLValue(Mono.CSharp.ResolveContext ec, Mono.CSharp.Expression right_side) { return default(Mono.CSharp.Expression); }
    public override void Emit(Mono.CSharp.EmitContext ec) { }
    public void Emit(Mono.CSharp.EmitContext ec, bool leave_copy) { }
    public void EmitAssign(Mono.CSharp.EmitContext ec, Mono.CSharp.Expression source, bool leave_copy, bool isCompound) { }
    public System.Linq.Expressions.Expression MakeAssignExpression(Mono.CSharp.BuilderContext ctx, Mono.CSharp.Expression source) { return default(System.Linq.Expressions.Expression); }
    public override System.Linq.Expressions.Expression MakeExpression(Mono.CSharp.BuilderContext ctx) { return default(System.Linq.Expressions.Expression); }
    public partial class DynamicMetaObject {
      public System.Linq.Expressions.Expression Expression;
      public Mono.CSharp.TypeSpec LimitType;
      public Mono.CSharp.TypeSpec RuntimeType;
      public DynamicMetaObject() { }
    }
  }
  public enum RuntimeVersion {
    v1 = 0,
    v2 = 1,
    v4 = 2,
  }
  public partial class SByteConstant : Mono.CSharp.IntegralConstant {
    public readonly sbyte Value;
    public SByteConstant(Mono.CSharp.BuiltinTypes types, sbyte v, Mono.CSharp.Location loc) : base (default(Mono.CSharp.TypeSpec), default(Mono.CSharp.Location)) { }
    public SByteConstant(Mono.CSharp.TypeSpec type, sbyte v, Mono.CSharp.Location loc) : base (default(Mono.CSharp.TypeSpec), default(Mono.CSharp.Location)) { }
    public override bool IsDefaultValue { get { return default(bool); } }
    public override bool IsNegative { get { return default(bool); } }
    public override bool IsOneInteger { get { return default(bool); } }
    public override bool IsZeroInteger { get { return default(bool); } }
    public override Mono.CSharp.Constant ConvertExplicitly(bool in_checked_context, Mono.CSharp.TypeSpec target_type) { return default(Mono.CSharp.Constant); }
    public override void Emit(Mono.CSharp.EmitContext ec) { }
    public override void EncodeAttributeValue(Mono.CSharp.IMemberContext rc, Mono.CSharp.AttributeEncoder enc, Mono.CSharp.TypeSpec targetType, Mono.CSharp.TypeSpec parameterType) { }
    public override object GetValue() { return default(object); }
    public override long GetValueAsLong() { return default(long); }
    public override Mono.CSharp.Constant Increment() { return default(Mono.CSharp.Constant); }
  }
  public partial class SeekableStreamReader : System.IDisposable {
    public const int DefaultReadAheadSize = 2048;
    public SeekableStreamReader(System.IO.Stream stream, System.Text.Encoding encoding, System.Char[] sharedBuffer=null) { }
    public int Position { get { return default(int); } set { } }
    public void Dispose() { }
    public int Peek() { return default(int); }
    public int Read() { return default(int); }
    public System.Char[] ReadChars(int fromPosition, int toPosition) { return default(System.Char[]); }
  }
  public abstract partial class ShimExpression : Mono.CSharp.Expression {
    protected Mono.CSharp.Expression expr;
    protected ShimExpression(Mono.CSharp.Expression expr) { }
    public Mono.CSharp.Expression Expr { get { return default(Mono.CSharp.Expression); } }
    protected override void CloneTo(Mono.CSharp.CloneContext clonectx, Mono.CSharp.Expression t) { }
    public override bool ContainsEmitWithAwait() { return default(bool); }
    public override Mono.CSharp.Expression CreateExpressionTree(Mono.CSharp.ResolveContext ec) { return default(Mono.CSharp.Expression); }
    public override void Emit(Mono.CSharp.EmitContext ec) { }
  }
  public partial class ShortConstant : Mono.CSharp.IntegralConstant {
    public readonly short Value;
    public ShortConstant(Mono.CSharp.BuiltinTypes types, short v, Mono.CSharp.Location loc) : base (default(Mono.CSharp.TypeSpec), default(Mono.CSharp.Location)) { }
    public ShortConstant(Mono.CSharp.TypeSpec type, short v, Mono.CSharp.Location loc) : base (default(Mono.CSharp.TypeSpec), default(Mono.CSharp.Location)) { }
    public override bool IsDefaultValue { get { return default(bool); } }
    public override bool IsNegative { get { return default(bool); } }
    public override bool IsOneInteger { get { return default(bool); } }
    public override bool IsZeroInteger { get { return default(bool); } }
    public override Mono.CSharp.Constant ConvertExplicitly(bool in_checked_context, Mono.CSharp.TypeSpec target_type) { return default(Mono.CSharp.Constant); }
    public override void Emit(Mono.CSharp.EmitContext ec) { }
    public override void EncodeAttributeValue(Mono.CSharp.IMemberContext rc, Mono.CSharp.AttributeEncoder enc, Mono.CSharp.TypeSpec targetType, Mono.CSharp.TypeSpec parameterType) { }
    public override object GetValue() { return default(object); }
    public override long GetValueAsLong() { return default(long); }
    public override Mono.CSharp.Constant Increment() { return default(Mono.CSharp.Constant); }
  }
  public partial class SideEffectConstant : Mono.CSharp.Constant {
    public readonly Mono.CSharp.Constant value;
    public SideEffectConstant(Mono.CSharp.Constant value, Mono.CSharp.Expression side_effect, Mono.CSharp.Location loc) : base (default(Mono.CSharp.Location)) { }
    public override bool IsDefaultValue { get { return default(bool); } }
    public override bool IsNegative { get { return default(bool); } }
    public override bool IsSideEffectFree { get { return default(bool); } }
    public override bool IsZeroInteger { get { return default(bool); } }
    public override bool ContainsEmitWithAwait() { return default(bool); }
    public override Mono.CSharp.Constant ConvertExplicitly(bool in_checked_context, Mono.CSharp.TypeSpec target_type) { return default(Mono.CSharp.Constant); }
    public override void Emit(Mono.CSharp.EmitContext ec) { }
    public override void EmitSideEffect(Mono.CSharp.EmitContext ec) { }
    public override void FlowAnalysis(Mono.CSharp.FlowAnalysisContext fc) { }
    public override object GetValue() { return default(object); }
    public override string GetValueAsLiteral() { return default(string); }
    public override long GetValueAsLong() { return default(long); }
  }
  public partial class SimpleAssign : Mono.CSharp.Assign {
    public SimpleAssign(Mono.CSharp.Expression target, Mono.CSharp.Expression source) : base (default(Mono.CSharp.Expression), default(Mono.CSharp.Expression), default(Mono.CSharp.Location)) { }
    public SimpleAssign(Mono.CSharp.Expression target, Mono.CSharp.Expression source, Mono.CSharp.Location loc) : base (default(Mono.CSharp.Expression), default(Mono.CSharp.Expression), default(Mono.CSharp.Location)) { }
    protected override Mono.CSharp.Expression DoResolve(Mono.CSharp.ResolveContext ec) { return default(Mono.CSharp.Expression); }
    public override void FlowAnalysis(Mono.CSharp.FlowAnalysisContext fc) { }
    public override void MarkReachable(Mono.CSharp.Reachability rc) { }
  }
  public partial class SimpleMemberName {
    public Mono.CSharp.Location Location;
    public string Value;
    public SimpleMemberName(string name, Mono.CSharp.Location loc) { }
  }
  public partial class SimpleName : Mono.CSharp.ATypeNameExpression {
    public SimpleName(string name, Mono.CSharp.Location l) : base (default(string), default(Mono.CSharp.Location)) { }
    public SimpleName(string name, Mono.CSharp.TypeArguments args, Mono.CSharp.Location l) : base (default(string), default(Mono.CSharp.Location)) { }
    public SimpleName(string name, int arity, Mono.CSharp.Location l) : base (default(string), default(Mono.CSharp.Location)) { }
    public override object Accept(Mono.CSharp.StructuralVisitor visitor) { return default(object); }
    protected override Mono.CSharp.Expression DoResolve(Mono.CSharp.ResolveContext rc) { return default(Mono.CSharp.Expression); }
    public override Mono.CSharp.Expression DoResolveLValue(Mono.CSharp.ResolveContext ec, Mono.CSharp.Expression right_side) { return default(Mono.CSharp.Expression); }
    public void Error_NameDoesNotExist(Mono.CSharp.ResolveContext rc) { }
    protected virtual void Error_TypeOrNamespaceNotFound(Mono.CSharp.IMemberContext ctx) { }
    public Mono.CSharp.SimpleName GetMethodGroup() { return default(Mono.CSharp.SimpleName); }
    public bool IsPossibleTypeOrNamespace(Mono.CSharp.IMemberContext mc) { return default(bool); }
    public override Mono.CSharp.Expression LookupNameExpression(Mono.CSharp.ResolveContext rc, Mono.CSharp.Expression.MemberLookupRestrictions restrictions) { return default(Mono.CSharp.Expression); }
    public override Mono.CSharp.FullNamedExpression ResolveAsTypeOrNamespace(Mono.CSharp.IMemberContext mc, bool allowUnboundTypeArguments) { return default(Mono.CSharp.FullNamedExpression); }
  }
  public partial class SizeOf : Mono.CSharp.Expression {
    public SizeOf(Mono.CSharp.Expression queried_type, Mono.CSharp.Location l) { }
    public override bool IsSideEffectFree { get { return default(bool); } }
    public Mono.CSharp.Expression TypeExpression { get { return default(Mono.CSharp.Expression); } }
    public override object Accept(Mono.CSharp.StructuralVisitor visitor) { return default(object); }
    protected override void CloneTo(Mono.CSharp.CloneContext clonectx, Mono.CSharp.Expression t) { }
    public override bool ContainsEmitWithAwait() { return default(bool); }
    public override Mono.CSharp.Expression CreateExpressionTree(Mono.CSharp.ResolveContext ec) { return default(Mono.CSharp.Expression); }
    protected override Mono.CSharp.Expression DoResolve(Mono.CSharp.ResolveContext ec) { return default(Mono.CSharp.Expression); }
    public override void Emit(Mono.CSharp.EmitContext ec) { }
  }
  public partial class SourceFile : System.IEquatable<Mono.CSharp.SourceFile> {
    public bool AutoGenerated;
    public readonly string FullPathName;
    public readonly int Index;
    public readonly string Name;
    public SourceFile(string name, string path, int index) { }
    public System.Byte[] Checksum { get { return default(System.Byte[]); } }
    public bool HasChecksum { get { return default(bool); } }
    public Mono.CompilerServices.SymbolWriter.SourceFileEntry SourceFileEntry { get { return default(Mono.CompilerServices.SymbolWriter.SourceFileEntry); } }
    public Mono.CompilerServices.SymbolWriter.SourceFileEntry CreateSymbolInfo(Mono.CompilerServices.SymbolWriter.MonoSymbolFile symwriter) { return default(Mono.CompilerServices.SymbolWriter.SourceFileEntry); }
    public bool Equals(Mono.CSharp.SourceFile other) { return default(bool); }
    public bool IsHiddenLocation(Mono.CSharp.Location loc) { return default(bool); }
    public void RegisterHiddenScope(Mono.CSharp.Location start, Mono.CSharp.Location end) { }
    public void SetChecksum(System.Byte[] checksum) { }
    public void SetChecksum(System.Byte[] algorithmGuid, System.Byte[] checksum) { }
    public override string ToString() { return default(string); }
  }
  [System.FlagsAttribute]
  public enum SpecialConstraint {
    Class = 8,
    Constructor = 4,
    None = 0,
    Struct = 16,
  }
  public partial class SpecialContraintExpr : Mono.CSharp.FullNamedExpression {
    public SpecialContraintExpr(Mono.CSharp.SpecialConstraint constraint, Mono.CSharp.Location loc) { }
    public Mono.CSharp.SpecialConstraint Constraint { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(Mono.CSharp.SpecialConstraint); } }
    protected override Mono.CSharp.Expression DoResolve(Mono.CSharp.ResolveContext rc) { return default(Mono.CSharp.Expression); }
    public override Mono.CSharp.FullNamedExpression ResolveAsTypeOrNamespace(Mono.CSharp.IMemberContext mc, bool allowUnboundTypeArguments) { return default(Mono.CSharp.FullNamedExpression); }
  }
  public partial class StackAlloc : Mono.CSharp.Expression {
    public StackAlloc(Mono.CSharp.Expression type, Mono.CSharp.Expression count, Mono.CSharp.Location l) { }
    public Mono.CSharp.Expression CountExpression { get { return default(Mono.CSharp.Expression); } }
    public Mono.CSharp.Expression TypeExpression { get { return default(Mono.CSharp.Expression); } }
    public override object Accept(Mono.CSharp.StructuralVisitor visitor) { return default(object); }
    protected override void CloneTo(Mono.CSharp.CloneContext clonectx, Mono.CSharp.Expression t) { }
    public override bool ContainsEmitWithAwait() { return default(bool); }
    public override Mono.CSharp.Expression CreateExpressionTree(Mono.CSharp.ResolveContext ec) { return default(Mono.CSharp.Expression); }
    protected override Mono.CSharp.Expression DoResolve(Mono.CSharp.ResolveContext ec) { return default(Mono.CSharp.Expression); }
    public override void Emit(Mono.CSharp.EmitContext ec) { }
  }
  public partial class StackFieldExpr : Mono.CSharp.FieldExpr, Mono.CSharp.IExpressionCleanup {
    public StackFieldExpr(Mono.CSharp.Field field) : base (default(Mono.CSharp.Location)) { }
    public bool IsAvailableForReuse { get { return default(bool); } set { } }
    public override void AddressOf(Mono.CSharp.EmitContext ec, Mono.CSharp.AddressOp mode) { }
    public override void Emit(Mono.CSharp.EmitContext ec) { }
    public void EmitLoad(Mono.CSharp.EmitContext ec) { }
    void Mono.CSharp.IExpressionCleanup.EmitCleanup(Mono.CSharp.EmitContext ec) { }
    public void PrepareCleanup(Mono.CSharp.EmitContext ec) { }
  }
  public abstract partial class StateMachine : Mono.CSharp.AnonymousMethodStorey {
    protected StateMachine(Mono.CSharp.ParametersBlock block, Mono.CSharp.TypeDefinition parent, Mono.CSharp.MemberBase host, Mono.CSharp.TypeParameters tparams, string name, Mono.CSharp.MemberKind kind) : base (default(Mono.CSharp.ExplicitBlock), default(Mono.CSharp.TypeDefinition), default(Mono.CSharp.MemberBase), default(Mono.CSharp.TypeParameters), default(string), default(Mono.CSharp.MemberKind)) { }
    public Mono.CSharp.TypeParameters OriginalTypeParameters { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(Mono.CSharp.TypeParameters); } }
    public Mono.CSharp.Field PC { get { return default(Mono.CSharp.Field); } }
    public Mono.CSharp.StateMachineMethod StateMachineMethod { get { return default(Mono.CSharp.StateMachineMethod); } }
    public void AddEntryMethod(Mono.CSharp.StateMachineMethod method) { }
    protected override bool DoDefineMembers() { return default(bool); }
    protected override string GetVariableMangledName(Mono.CSharp.LocalVariable local_info) { return default(string); }
    public enum State {
      After = -1,
      Running = -3,
      Start = 0,
      Uninitialized = -2,
    }
  }
  public abstract partial class StateMachineInitializer : Mono.CSharp.AnonymousExpression {
    protected System.Reflection.Emit.LocalBuilder current_pc;
    public readonly Mono.CSharp.TypeDefinition Host;
    protected System.Reflection.Emit.Label move_next_error;
    protected System.Reflection.Emit.Label move_next_ok;
    protected System.Collections.Generic.List<Mono.CSharp.ResumableStatement> resume_points;
    protected Mono.CSharp.StateMachine storey;
    protected StateMachineInitializer(Mono.CSharp.ParametersBlock block, Mono.CSharp.TypeDefinition host, Mono.CSharp.TypeSpec returnType) : base (default(Mono.CSharp.ParametersBlock), default(Mono.CSharp.TypeSpec), default(Mono.CSharp.Location)) { }
    public System.Reflection.Emit.Label BodyEnd { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Reflection.Emit.Label); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Reflection.Emit.LocalBuilder CurrentPC { get { return default(System.Reflection.Emit.LocalBuilder); } }
    public System.Reflection.Emit.LocalBuilder SkipFinally { get { return default(System.Reflection.Emit.LocalBuilder); } }
    public override Mono.CSharp.AnonymousMethodStorey Storey { get { return default(Mono.CSharp.AnonymousMethodStorey); } }
    public int AddResumePoint(Mono.CSharp.ResumableStatement stmt) { return default(int); }
    protected virtual Mono.CSharp.BlockContext CreateBlockContext(Mono.CSharp.BlockContext bc) { return default(Mono.CSharp.BlockContext); }
    public override Mono.CSharp.Expression CreateExpressionTree(Mono.CSharp.ResolveContext ec) { return default(Mono.CSharp.Expression); }
    protected override Mono.CSharp.Expression DoResolve(Mono.CSharp.ResolveContext rc) { return default(Mono.CSharp.Expression); }
    public override void Emit(Mono.CSharp.EmitContext ec) { }
    public void EmitLeave(Mono.CSharp.EmitContext ec, bool unwind_protect) { }
    protected virtual void EmitMoveNextEpilogue(Mono.CSharp.EmitContext ec) { }
    public virtual void InjectYield(Mono.CSharp.EmitContext ec, Mono.CSharp.Expression expr, int resume_pc, bool unwind_protect, System.Reflection.Emit.Label resume_point) { }
    public void SetStateMachine(Mono.CSharp.StateMachine stateMachine) { }
  }
  public partial class StateMachineMethod : Mono.CSharp.Method {
    public StateMachineMethod(Mono.CSharp.StateMachine host, Mono.CSharp.StateMachineInitializer expr, Mono.CSharp.FullNamedExpression returnType, Mono.CSharp.Modifiers mod, Mono.CSharp.MemberName name, Mono.CSharp.Block.Flags blockFlags) : base (default(Mono.CSharp.TypeDefinition), default(Mono.CSharp.FullNamedExpression), default(Mono.CSharp.Modifiers), default(Mono.CSharp.MemberName), default(Mono.CSharp.ParametersCompiled), default(Mono.CSharp.Attributes)) { }
    public override Mono.CSharp.EmitContext CreateEmitContext(System.Reflection.Emit.ILGenerator ig, Mono.CompilerServices.SymbolWriter.SourceMethodBuilder sourceMethod) { return default(Mono.CSharp.EmitContext); }
  }
  public abstract partial class Statement {
    public Mono.CSharp.Location loc;
    protected bool reachable;
    protected Statement() { }
    public bool IsUnreachable { get { return default(bool); } }
    public virtual object Accept(Mono.CSharp.StructuralVisitor visitor) { return default(object); }
    protected void CheckExitBoundaries(Mono.CSharp.BlockContext bc, Mono.CSharp.Block scope) { }
    public Mono.CSharp.Statement Clone(Mono.CSharp.CloneContext clonectx) { return default(Mono.CSharp.Statement); }
    protected abstract void CloneTo(Mono.CSharp.CloneContext clonectx, Mono.CSharp.Statement target);
    public virtual Mono.CSharp.Expression CreateExpressionTree(Mono.CSharp.ResolveContext ec) { return default(Mono.CSharp.Expression); }
    protected abstract void DoEmit(Mono.CSharp.EmitContext ec);
    protected abstract bool DoFlowAnalysis(Mono.CSharp.FlowAnalysisContext fc);
    public virtual void Emit(Mono.CSharp.EmitContext ec) { }
    protected void Error_FinallyClauseExit(Mono.CSharp.BlockContext bc) { }
    public bool FlowAnalysis(Mono.CSharp.FlowAnalysisContext fc) { return default(bool); }
    public virtual Mono.CSharp.Reachability MarkReachable(Mono.CSharp.Reachability rc) { return default(Mono.CSharp.Reachability); }
    public virtual bool Resolve(Mono.CSharp.BlockContext bc) { return default(bool); }
  }
  public partial class StatementErrorExpression : Mono.CSharp.Statement {
    public StatementErrorExpression(Mono.CSharp.Expression expr) { }
    public Mono.CSharp.Expression Expr { get { return default(Mono.CSharp.Expression); } }
    public override object Accept(Mono.CSharp.StructuralVisitor visitor) { return default(object); }
    protected override void CloneTo(Mono.CSharp.CloneContext clonectx, Mono.CSharp.Statement target) { }
    protected override void DoEmit(Mono.CSharp.EmitContext ec) { }
    protected override bool DoFlowAnalysis(Mono.CSharp.FlowAnalysisContext fc) { return default(bool); }
    public override bool Resolve(Mono.CSharp.BlockContext bc) { return default(bool); }
  }
  public partial class StatementExpression : Mono.CSharp.Statement {
    public StatementExpression(Mono.CSharp.ExpressionStatement expr) { }
    public StatementExpression(Mono.CSharp.ExpressionStatement expr, Mono.CSharp.Location loc) { }
    public Mono.CSharp.ExpressionStatement Expr { get { return default(Mono.CSharp.ExpressionStatement); } }
    public override object Accept(Mono.CSharp.StructuralVisitor visitor) { return default(object); }
    protected override void CloneTo(Mono.CSharp.CloneContext clonectx, Mono.CSharp.Statement t) { }
    protected override void DoEmit(Mono.CSharp.EmitContext ec) { }
    protected override bool DoFlowAnalysis(Mono.CSharp.FlowAnalysisContext fc) { return default(bool); }
    public override Mono.CSharp.Reachability MarkReachable(Mono.CSharp.Reachability rc) { return default(Mono.CSharp.Reachability); }
    public override bool Resolve(Mono.CSharp.BlockContext ec) { return default(bool); }
  }
  public partial class StatementList : Mono.CSharp.Statement {
    public StatementList(Mono.CSharp.Statement first, Mono.CSharp.Statement second) { }
    public System.Collections.Generic.IList<Mono.CSharp.Statement> Statements { get { return default(System.Collections.Generic.IList<Mono.CSharp.Statement>); } }
    public override object Accept(Mono.CSharp.StructuralVisitor visitor) { return default(object); }
    public void Add(Mono.CSharp.Statement statement) { }
    protected override void CloneTo(Mono.CSharp.CloneContext clonectx, Mono.CSharp.Statement target) { }
    protected override void DoEmit(Mono.CSharp.EmitContext ec) { }
    protected override bool DoFlowAnalysis(Mono.CSharp.FlowAnalysisContext fc) { return default(bool); }
    public override Mono.CSharp.Reachability MarkReachable(Mono.CSharp.Reachability rc) { return default(Mono.CSharp.Reachability); }
    public override bool Resolve(Mono.CSharp.BlockContext ec) { return default(bool); }
  }
  public partial class StreamReportPrinter : Mono.CSharp.ReportPrinter {
    public StreamReportPrinter(System.IO.TextWriter writer) { }
    public override void Print(Mono.CSharp.AbstractMessage msg, bool showFullPath) { }
  }
  public partial class StringConcat : Mono.CSharp.Expression {
    internal StringConcat() { }
    public override bool ContainsEmitWithAwait() { return default(bool); }
    public static Mono.CSharp.StringConcat Create(Mono.CSharp.ResolveContext rc, Mono.CSharp.Expression left, Mono.CSharp.Expression right, Mono.CSharp.Location loc) { return default(Mono.CSharp.StringConcat); }
    public override Mono.CSharp.Expression CreateExpressionTree(Mono.CSharp.ResolveContext ec) { return default(Mono.CSharp.Expression); }
    protected override Mono.CSharp.Expression DoResolve(Mono.CSharp.ResolveContext ec) { return default(Mono.CSharp.Expression); }
    public override void Emit(Mono.CSharp.EmitContext ec) { }
    public override void FlowAnalysis(Mono.CSharp.FlowAnalysisContext fc) { }
    public override System.Linq.Expressions.Expression MakeExpression(Mono.CSharp.BuilderContext ctx) { return default(System.Linq.Expressions.Expression); }
  }
  public partial class StringConstant : Mono.CSharp.Constant {
    public StringConstant(Mono.CSharp.BuiltinTypes types, string s, Mono.CSharp.Location loc) : base (default(Mono.CSharp.Location)) { }
    protected StringConstant(Mono.CSharp.Location loc) : base (default(Mono.CSharp.Location)) { }
    public StringConstant(Mono.CSharp.TypeSpec type, string s, Mono.CSharp.Location loc) : base (default(Mono.CSharp.Location)) { }
    public override bool IsDefaultValue { get { return default(bool); } }
    public override bool IsNegative { get { return default(bool); } }
    public override bool IsNull { get { return default(bool); } }
    public string Value { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]protected set { } }
    public override Mono.CSharp.Constant ConvertExplicitly(bool in_checked_context, Mono.CSharp.TypeSpec target_type) { return default(Mono.CSharp.Constant); }
    public override Mono.CSharp.Constant ConvertImplicitly(Mono.CSharp.TypeSpec type) { return default(Mono.CSharp.Constant); }
    public override void Emit(Mono.CSharp.EmitContext ec) { }
    public override void EncodeAttributeValue(Mono.CSharp.IMemberContext rc, Mono.CSharp.AttributeEncoder enc, Mono.CSharp.TypeSpec targetType, Mono.CSharp.TypeSpec parameterType) { }
    public override object GetValue() { return default(object); }
    public override string GetValueAsLiteral() { return default(string); }
    public override long GetValueAsLong() { return default(long); }
  }
  public partial class StringLiteral : Mono.CSharp.StringConstant, Mono.CSharp.ILiteralConstant {
    public StringLiteral(Mono.CSharp.BuiltinTypes types, string s, Mono.CSharp.Location loc) : base (default(Mono.CSharp.BuiltinTypes), default(string), default(Mono.CSharp.Location)) { }
    public override bool IsLiteral { get { return default(bool); } }
    public override object Accept(Mono.CSharp.StructuralVisitor visitor) { return default(object); }
  }
  public sealed partial class Struct : Mono.CSharp.ClassOrStruct {
    public Struct(Mono.CSharp.TypeContainer parent, Mono.CSharp.MemberName name, Mono.CSharp.Modifiers mod, Mono.CSharp.Attributes attrs) : base (default(Mono.CSharp.TypeContainer), default(Mono.CSharp.MemberName), default(Mono.CSharp.Attributes), default(Mono.CSharp.MemberKind)) { }
    public override System.AttributeTargets AttributeTargets { get { return default(System.AttributeTargets); } }
    public override void Accept(Mono.CSharp.StructuralVisitor visitor) { }
    public override void ApplyAttributeBuilder(Mono.CSharp.Attribute a, Mono.CSharp.MethodSpec ctor, System.Byte[] cdata, Mono.CSharp.PredefinedAttributes pa) { }
    protected override bool DoDefineMembers() { return default(bool); }
    public override void Emit() { }
    public override bool IsUnmanagedType() { return default(bool); }
    protected override Mono.CSharp.TypeSpec[] ResolveBaseTypes(out Mono.CSharp.FullNamedExpression base_class) { base_class = default(Mono.CSharp.FullNamedExpression); return default(Mono.CSharp.TypeSpec[]); }
  }
  public abstract partial class StructuralVisitor {
    protected StructuralVisitor() { }
    public virtual object Visit(Mono.CSharp.AnonymousMethodExpression anonymousMethodExpression) { return default(object); }
    public virtual object Visit(Mono.CSharp.Arglist argListExpression) { return default(object); }
    public virtual object Visit(Mono.CSharp.ArglistAccess argListAccessExpression) { return default(object); }
    public virtual object Visit(Mono.CSharp.ArrayCreation arrayCreationExpression) { return default(object); }
    public virtual object Visit(Mono.CSharp.ArrayInitializer arrayInitializer) { return default(object); }
    public virtual object Visit(Mono.CSharp.As asExpression) { return default(object); }
    public virtual object Visit(Mono.CSharp.Await awaitExpr) { return default(object); }
    public virtual object Visit(Mono.CSharp.BaseThis baseAccessExpression) { return default(object); }
    public virtual object Visit(Mono.CSharp.Binary binaryExpression) { return default(object); }
    public virtual object Visit(Mono.CSharp.Block blockStatement) { return default(object); }
    public virtual object Visit(Mono.CSharp.BlockConstant blockConstantDeclaration) { return default(object); }
    public virtual object Visit(Mono.CSharp.BlockVariable blockVariableDeclaration) { return default(object); }
    public virtual object Visit(Mono.CSharp.BooleanExpression booleanExpression) { return default(object); }
    public virtual object Visit(Mono.CSharp.Break breakStatement) { return default(object); }
    public virtual object Visit(Mono.CSharp.Cast castExpression) { return default(object); }
    public virtual object Visit(Mono.CSharp.Checked checkedStatement) { return default(object); }
    public virtual object Visit(Mono.CSharp.CheckedExpr checkedExpression) { return default(object); }
    public virtual void Visit(Mono.CSharp.Class c) { }
    public virtual void Visit(Mono.CSharp.CompilationSourceFile csf) { }
    public virtual object Visit(Mono.CSharp.ComposedCast composedCast) { return default(object); }
    public virtual object Visit(Mono.CSharp.CompoundAssign compoundAssign) { return default(object); }
    public virtual object Visit(Mono.CSharp.Conditional conditionalExpression) { return default(object); }
    public virtual void Visit(Mono.CSharp.Const c) { }
    public virtual object Visit(Mono.CSharp.Constant constant) { return default(object); }
    public virtual object Visit(Mono.CSharp.ConstInitializer constInitializer) { return default(object); }
    public virtual void Visit(Mono.CSharp.Constructor c) { }
    public virtual object Visit(Mono.CSharp.Continue continueStatement) { return default(object); }
    public virtual object Visit(Mono.CSharp.DefaultParameterValueExpression defaultParameterValueExpression) { return default(object); }
    public virtual object Visit(Mono.CSharp.DefaultValueExpression defaultValueExpression) { return default(object); }
    public virtual void Visit(Mono.CSharp.Delegate d) { }
    public virtual void Visit(Mono.CSharp.Destructor d) { }
    public virtual object Visit(Mono.CSharp.Do doStatement) { return default(object); }
    public virtual object Visit(Mono.CSharp.ElementAccess elementAccessExpression) { return default(object); }
    public virtual object Visit(Mono.CSharp.EmptyExpression emptyExpression) { return default(object); }
    public virtual object Visit(Mono.CSharp.EmptyExpressionStatement emptyExpressionStatement) { return default(object); }
    public virtual object Visit(Mono.CSharp.EmptyStatement emptyStatement) { return default(object); }
    public virtual void Visit(Mono.CSharp.Enum e) { }
    public virtual void Visit(Mono.CSharp.EnumMember em) { }
    public virtual object Visit(Mono.CSharp.ErrorExpression errorExpression) { return default(object); }
    public virtual void Visit(Mono.CSharp.EventField e) { }
    public virtual void Visit(Mono.CSharp.EventProperty ep) { }
    public virtual object Visit(Mono.CSharp.Expression expression) { return default(object); }
    public virtual void Visit(Mono.CSharp.Field f) { }
    public virtual object Visit(Mono.CSharp.Fixed fixedStatement) { return default(object); }
    public virtual void Visit(Mono.CSharp.FixedField f) { }
    public virtual object Visit(Mono.CSharp.For forStatement) { return default(object); }
    public virtual object Visit(Mono.CSharp.Foreach foreachStatement) { return default(object); }
    public virtual object Visit(Mono.CSharp.Goto gotoStatement) { return default(object); }
    public virtual object Visit(Mono.CSharp.GotoCase gotoCase) { return default(object); }
    public virtual object Visit(Mono.CSharp.GotoDefault gotoDefault) { return default(object); }
    public virtual object Visit(Mono.CSharp.If ifStatement) { return default(object); }
    public virtual void Visit(Mono.CSharp.Indexer i) { }
    public virtual object Visit(Mono.CSharp.Indirection indirectionExpression) { return default(object); }
    public virtual void Visit(Mono.CSharp.Interface i) { }
    public virtual object Visit(Mono.CSharp.Invocation invocationExpression) { return default(object); }
    public virtual object Visit(Mono.CSharp.Is isExpression) { return default(object); }
    public virtual object Visit(Mono.CSharp.LabeledStatement labeledStatement) { return default(object); }
    public virtual object Visit(Mono.CSharp.LambdaExpression lambdaExpression) { return default(object); }
    public virtual object Visit(Mono.CSharp.Linq.GroupBy groupBy) { return default(object); }
    public virtual object Visit(Mono.CSharp.Linq.GroupJoin groupJoin) { return default(object); }
    public virtual object Visit(Mono.CSharp.Linq.Join join) { return default(object); }
    public virtual object Visit(Mono.CSharp.Linq.Let let) { return default(object); }
    public virtual object Visit(Mono.CSharp.Linq.OrderByAscending orderByAscending) { return default(object); }
    public virtual object Visit(Mono.CSharp.Linq.OrderByDescending orderByDescending) { return default(object); }
    public virtual object Visit(Mono.CSharp.Linq.QueryExpression queryExpression) { return default(object); }
    public virtual object Visit(Mono.CSharp.Linq.QueryStartClause queryExpression) { return default(object); }
    public virtual object Visit(Mono.CSharp.Linq.Select select) { return default(object); }
    public virtual object Visit(Mono.CSharp.Linq.SelectMany selectMany) { return default(object); }
    public virtual object Visit(Mono.CSharp.Linq.ThenByAscending thenByAscending) { return default(object); }
    public virtual object Visit(Mono.CSharp.Linq.ThenByDescending thenByDescending) { return default(object); }
    public virtual object Visit(Mono.CSharp.Linq.Where where) { return default(object); }
    public virtual object Visit(Mono.CSharp.LocalVariableReference localVariableReference) { return default(object); }
    public virtual object Visit(Mono.CSharp.Lock lockStatement) { return default(object); }
    public virtual object Visit(Mono.CSharp.MakeRefExpr makeRefExpr) { return default(object); }
    public virtual object Visit(Mono.CSharp.MemberAccess memberAccess) { return default(object); }
    public virtual void Visit(Mono.CSharp.MemberCore member) { }
    public virtual void Visit(Mono.CSharp.Method m) { }
    public virtual void Visit(Mono.CSharp.ModuleContainer module) { }
    public virtual void Visit(Mono.CSharp.NamespaceContainer ns) { }
    public virtual object Visit(Mono.CSharp.New newExpression) { return default(object); }
    public virtual object Visit(Mono.CSharp.NewAnonymousType newAnonymousType) { return default(object); }
    public virtual object Visit(Mono.CSharp.NewInitialize newInitializeExpression) { return default(object); }
    public virtual object Visit(Mono.CSharp.Nullable.NullCoalescingOperator nullCoalescingOperator) { return default(object); }
    public virtual void Visit(Mono.CSharp.Operator o) { }
    public virtual object Visit(Mono.CSharp.ParenthesizedExpression parenthesizedExpression) { return default(object); }
    public virtual void Visit(Mono.CSharp.Property p) { }
    public virtual object Visit(Mono.CSharp.QualifiedAliasMember qualifiedAliasMember) { return default(object); }
    public virtual object Visit(Mono.CSharp.RefTypeExpr refTypeExpr) { return default(object); }
    public virtual object Visit(Mono.CSharp.RefValueExpr refValueExpr) { return default(object); }
    public virtual object Visit(Mono.CSharp.Return returnStatement) { return default(object); }
    public virtual object Visit(Mono.CSharp.SimpleAssign simpleAssign) { return default(object); }
    public virtual object Visit(Mono.CSharp.SimpleName simpleName) { return default(object); }
    public virtual object Visit(Mono.CSharp.SizeOf sizeOfExpression) { return default(object); }
    public virtual object Visit(Mono.CSharp.StackAlloc stackAllocExpression) { return default(object); }
    public virtual object Visit(Mono.CSharp.Statement stmt) { return default(object); }
    public virtual object Visit(Mono.CSharp.StatementErrorExpression errorStatement) { return default(object); }
    public virtual object Visit(Mono.CSharp.StatementExpression statementExpression) { return default(object); }
    public virtual object Visit(Mono.CSharp.StatementList statementList) { return default(object); }
    public virtual void Visit(Mono.CSharp.Struct s) { }
    public virtual object Visit(Mono.CSharp.Switch switchStatement) { return default(object); }
    public virtual object Visit(Mono.CSharp.SwitchLabel switchLabel) { return default(object); }
    public virtual object Visit(Mono.CSharp.This thisExpression) { return default(object); }
    public virtual object Visit(Mono.CSharp.Throw throwStatement) { return default(object); }
    public virtual object Visit(Mono.CSharp.TryCatch tryCatchStatement) { return default(object); }
    public virtual object Visit(Mono.CSharp.TryFinally tryFinallyStatement) { return default(object); }
    public virtual object Visit(Mono.CSharp.TypeExpression typeExpression) { return default(object); }
    public virtual object Visit(Mono.CSharp.TypeOf typeOfExpression) { return default(object); }
    public virtual object Visit(Mono.CSharp.Unary unaryExpression) { return default(object); }
    public virtual object Visit(Mono.CSharp.UnaryMutator unaryMutatorExpression) { return default(object); }
    public virtual object Visit(Mono.CSharp.Unchecked uncheckedStatement) { return default(object); }
    public virtual object Visit(Mono.CSharp.UnCheckedExpr uncheckedExpression) { return default(object); }
    public virtual object Visit(Mono.CSharp.Unsafe unsafeStatement) { return default(object); }
    public virtual object Visit(Mono.CSharp.Using usingStatement) { return default(object); }
    public virtual void Visit(Mono.CSharp.UsingAliasNamespace uan) { }
    public virtual void Visit(Mono.CSharp.UsingExternAlias uea) { }
    public virtual void Visit(Mono.CSharp.UsingNamespace un) { }
    public virtual object Visit(Mono.CSharp.While whileStatement) { return default(object); }
    public virtual object Visit(Mono.CSharp.Yield yieldStatement) { return default(object); }
    public virtual object Visit(Mono.CSharp.YieldBreak yieldBreakStatement) { return default(object); }
  }
  public partial class Switch : Mono.CSharp.LoopStatement {
    public Mono.CSharp.Expression Expr;
    public Mono.CSharp.TypeSpec SwitchType;
    public Switch(Mono.CSharp.Expression e, Mono.CSharp.ExplicitBlock block, Mono.CSharp.Location l) : base (default(Mono.CSharp.Statement)) { }
    public Mono.CSharp.SwitchLabel ActiveLabel { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(Mono.CSharp.SwitchLabel); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public Mono.CSharp.ExplicitBlock Block { get { return default(Mono.CSharp.ExplicitBlock); } }
    public Mono.CSharp.SwitchLabel DefaultLabel { get { return default(Mono.CSharp.SwitchLabel); } }
    public Mono.CSharp.VariableReference ExpressionValue { get { return default(Mono.CSharp.VariableReference); } }
    public bool IsNullable { get { return default(bool); } }
    public bool IsPatternMatching { get { return default(bool); } }
    public System.Collections.Generic.List<Mono.CSharp.SwitchLabel> RegisteredLabels { get { return default(System.Collections.Generic.List<Mono.CSharp.SwitchLabel>); } }
    public override object Accept(Mono.CSharp.StructuralVisitor visitor) { return default(object); }
    public override void AddEndDefiniteAssignment(Mono.CSharp.FlowAnalysisContext fc) { }
    protected override void CloneTo(Mono.CSharp.CloneContext clonectx, Mono.CSharp.Statement t) { }
    public static Mono.CSharp.TypeSpec[] CreateSwitchUserTypes(Mono.CSharp.ModuleContainer module, Mono.CSharp.TypeSpec nullable) { return default(Mono.CSharp.TypeSpec[]); }
    protected override void DoEmit(Mono.CSharp.EmitContext ec) { }
    protected override bool DoFlowAnalysis(Mono.CSharp.FlowAnalysisContext fc) { return default(bool); }
    public Mono.CSharp.SwitchLabel FindLabel(Mono.CSharp.Constant value) { return default(Mono.CSharp.SwitchLabel); }
    public override Mono.CSharp.Reachability MarkReachable(Mono.CSharp.Reachability rc) { return default(Mono.CSharp.Reachability); }
    public void RegisterGotoCase(Mono.CSharp.GotoCase gotoCase, Mono.CSharp.Constant value) { }
    public void RegisterLabel(Mono.CSharp.BlockContext rc, Mono.CSharp.SwitchLabel sl) { }
    public override bool Resolve(Mono.CSharp.BlockContext ec) { return default(bool); }
    public override void SetEndReachable() { }
  }
  public abstract partial class SwitchGoto : Mono.CSharp.Statement {
    protected Mono.CSharp.Switch switch_statement;
    protected bool unwind_protect;
    protected SwitchGoto(Mono.CSharp.Location loc) { }
    protected override void CloneTo(Mono.CSharp.CloneContext clonectx, Mono.CSharp.Statement target) { }
    protected override bool DoFlowAnalysis(Mono.CSharp.FlowAnalysisContext fc) { return default(bool); }
    protected void Error_GotoCaseRequiresSwitchBlock(Mono.CSharp.BlockContext bc) { }
    public override Mono.CSharp.Reachability MarkReachable(Mono.CSharp.Reachability rc) { return default(Mono.CSharp.Reachability); }
    public override bool Resolve(Mono.CSharp.BlockContext bc) { return default(bool); }
  }
  public partial class SwitchLabel : Mono.CSharp.Statement {
    public SwitchLabel(Mono.CSharp.Expression expr, Mono.CSharp.Location l) { }
    public Mono.CSharp.Constant Converted { get { return default(Mono.CSharp.Constant); } set { } }
    public bool IsDefault { get { return default(bool); } }
    public Mono.CSharp.Expression Label { get { return default(Mono.CSharp.Expression); } }
    public Mono.CSharp.Location Location { get { return default(Mono.CSharp.Location); } }
    public bool PatternMatching { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public bool SectionStart { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public override object Accept(Mono.CSharp.StructuralVisitor visitor) { return default(object); }
    protected override void CloneTo(Mono.CSharp.CloneContext clonectx, Mono.CSharp.Statement target) { }
    protected override void DoEmit(Mono.CSharp.EmitContext ec) { }
    protected override bool DoFlowAnalysis(Mono.CSharp.FlowAnalysisContext fc) { return default(bool); }
    public void Error_AlreadyOccurs(Mono.CSharp.ResolveContext ec, Mono.CSharp.SwitchLabel collision_with) { }
    public System.Reflection.Emit.Label GetILLabel(Mono.CSharp.EmitContext ec) { return default(System.Reflection.Emit.Label); }
    public string GetSignatureForError() { return default(string); }
    public override bool Resolve(Mono.CSharp.BlockContext bc) { return default(bool); }
  }
  public enum Target {
    Exe = 1,
    Library = 0,
    Module = 2,
    WinExe = 3,
  }
  public partial class TemporaryVariableReference : Mono.CSharp.VariableReference {
    public TemporaryVariableReference(Mono.CSharp.LocalVariable li, Mono.CSharp.Location loc) { }
    public override bool IsFixed { get { return default(bool); } }
    public override bool IsLockedByStatement { get { return default(bool); } set { } }
    public override bool IsRef { get { return default(bool); } }
    public Mono.CSharp.LocalVariable LocalInfo { get { return default(Mono.CSharp.LocalVariable); } }
    public override string Name { get { return default(string); } }
    protected override Mono.CSharp.ILocalVariable Variable { get { return default(Mono.CSharp.ILocalVariable); } }
    public override Mono.CSharp.VariableInfo VariableInfo { get { return default(Mono.CSharp.VariableInfo); } }
    public static Mono.CSharp.TemporaryVariableReference Create(Mono.CSharp.TypeSpec type, Mono.CSharp.Block block, Mono.CSharp.Location loc) { return default(Mono.CSharp.TemporaryVariableReference); }
    protected override Mono.CSharp.Expression DoResolve(Mono.CSharp.ResolveContext ec) { return default(Mono.CSharp.Expression); }
    public override Mono.CSharp.Expression DoResolveLValue(Mono.CSharp.ResolveContext ec, Mono.CSharp.Expression right_side) { return default(Mono.CSharp.Expression); }
    public override void Emit(Mono.CSharp.EmitContext ec) { }
    public void EmitAssign(Mono.CSharp.EmitContext ec, Mono.CSharp.Expression source) { }
    public override Mono.CSharp.HoistedVariable GetHoistedVariable(Mono.CSharp.AnonymousExpression ae) { return default(Mono.CSharp.HoistedVariable); }
    public override void SetHasAddressTaken() { }
    public partial class Declarator : Mono.CSharp.Statement {
      public Declarator(Mono.CSharp.TemporaryVariableReference variable) { }
      protected override void CloneTo(Mono.CSharp.CloneContext clonectx, Mono.CSharp.Statement target) { }
      protected override void DoEmit(Mono.CSharp.EmitContext ec) { }
      protected override bool DoFlowAnalysis(Mono.CSharp.FlowAnalysisContext fc) { return default(bool); }
      public override void Emit(Mono.CSharp.EmitContext ec) { }
    }
  }
  public partial class This : Mono.CSharp.VariableReference {
    protected Mono.CSharp.VariableInfo variable_info;
    public This(Mono.CSharp.Location loc) { }
    public override bool IsFixed { get { return default(bool); } }
    public override bool IsLockedByStatement { get { return default(bool); } set { } }
    public override bool IsRef { get { return default(bool); } }
    public override bool IsSideEffectFree { get { return default(bool); } }
    public override string Name { get { return default(string); } }
    protected override Mono.CSharp.ILocalVariable Variable { get { return default(Mono.CSharp.ILocalVariable); } }
    public override Mono.CSharp.VariableInfo VariableInfo { get { return default(Mono.CSharp.VariableInfo); } }
    public override object Accept(Mono.CSharp.StructuralVisitor visitor) { return default(object); }
    protected override void CloneTo(Mono.CSharp.CloneContext clonectx, Mono.CSharp.Expression t) { }
    protected override Mono.CSharp.Expression DoResolve(Mono.CSharp.ResolveContext ec) { return default(Mono.CSharp.Expression); }
    public override Mono.CSharp.Expression DoResolveLValue(Mono.CSharp.ResolveContext ec, Mono.CSharp.Expression right_side) { return default(Mono.CSharp.Expression); }
    public override bool Equals(object obj) { return default(bool); }
    protected virtual void Error_ThisNotAvailable(Mono.CSharp.ResolveContext ec) { }
    public override void FlowAnalysis(Mono.CSharp.FlowAnalysisContext fc) { }
    public override int GetHashCode() { return default(int); }
    public override Mono.CSharp.HoistedVariable GetHoistedVariable(Mono.CSharp.AnonymousExpression ae) { return default(Mono.CSharp.HoistedVariable); }
    public static bool IsThisAvailable(Mono.CSharp.ResolveContext ec, bool ignoreAnonymous) { return default(bool); }
    public virtual void ResolveBase(Mono.CSharp.ResolveContext ec) { }
    public override void SetHasAddressTaken() { }
  }
  public partial class Throw : Mono.CSharp.Statement {
    public Throw(Mono.CSharp.Expression expr, Mono.CSharp.Location l) { }
    public Mono.CSharp.Expression Expr { get { return default(Mono.CSharp.Expression); } }
    public override object Accept(Mono.CSharp.StructuralVisitor visitor) { return default(object); }
    protected override void CloneTo(Mono.CSharp.CloneContext clonectx, Mono.CSharp.Statement t) { }
    protected override void DoEmit(Mono.CSharp.EmitContext ec) { }
    protected override bool DoFlowAnalysis(Mono.CSharp.FlowAnalysisContext fc) { return default(bool); }
    public override Mono.CSharp.Reachability MarkReachable(Mono.CSharp.Reachability rc) { return default(Mono.CSharp.Reachability); }
    public override bool Resolve(Mono.CSharp.BlockContext ec) { return default(bool); }
  }
  public partial class Tokenizer {
    public bool CompleteOnEOF;
    public const int DocumentationXref = 1048579;
    public const int EvalCompilationUnitParserCharacter = 1048577;
    public const int EvalStatementParserCharacter = 1048576;
    public const int EvalUsingDeclarationsParserCharacter = 1048578;
    public const int MaxIdentifierLength = 512;
    public const int MaxNumberLength = 512;
    public bool parsing_attribute_section;
    public int parsing_block;
    public int parsing_declaration;
    public bool parsing_generic_declaration;
    public bool parsing_generic_declaration_doc;
    public bool parsing_modifiers;
    public int parsing_type;
    public Tokenizer(Mono.CSharp.SeekableStreamReader input, Mono.CSharp.CompilationSourceFile file, Mono.CSharp.ParserSession session, Mono.CSharp.Report report) { }
    public bool ConstraintsParsing { get { return default(bool); } set { } }
    public Mono.CSharp.XmlCommentState doc_state { get { return default(Mono.CSharp.XmlCommentState); } set { } }
    public bool EventParsing { get { return default(bool); } set { } }
    public int Line { get { return default(int); } }
    public Mono.CSharp.Location Location { get { return default(Mono.CSharp.Location); } }
    public bool PropertyParsing { get { return default(bool); } set { } }
    public object Value { get { return default(object); } }
    public bool advance() { return default(bool); }
    public void check_incorrect_doc_comment() { }
    public void cleanup() { }
    public string consume_doc_comment() { return default(string); }
    public void DiscardPosition() { }
    public bool IsEscapedIdentifier(Mono.CSharp.ATypeNameExpression name) { return default(bool); }
    public static bool IsKeyword(string s) { return default(bool); }
    public static bool IsValidIdentifier(string s) { return default(bool); }
    public int peek_token() { return default(int); }
    public void PopPosition() { }
    public void PushPosition() { }
    public void putback(int c) { }
    public int token() { return default(int); }
    public object value() { return default(object); }
    public int xtoken() { return default(int); }
    public partial class LocatedTokenBuffer {
      public int pos;
      public LocatedTokenBuffer() { }
      public LocatedTokenBuffer(Mono.CSharp.LocatedToken[] buffer) { }
      public Mono.CSharp.LocatedToken Create(Mono.CSharp.SourceFile file, int row, int column) { return default(Mono.CSharp.LocatedToken); }
      public Mono.CSharp.LocatedToken Create(string value, Mono.CSharp.SourceFile file, int row, int column) { return default(Mono.CSharp.LocatedToken); }
      [System.Diagnostics.ConditionalAttribute("FULL_AST")]
      public void CreateOptional(Mono.CSharp.SourceFile file, int row, int col, ref object token) { }
    }
    public enum PreprocessorDirective {
      CustomArgumentsParsing = 1024,
      Define = 2055,
      Elif = 2053,
      Else = 6,
      Endif = 4,
      Endregion = 2,
      Error = 9,
      If = 2051,
      Invalid = 0,
      Line = 1036,
      Pragma = 1035,
      Region = 1,
      RequiresArgument = 2048,
      Undef = 2056,
      Warning = 10,
    }
  }
  public partial class ToplevelBlock : Mono.CSharp.ParametersBlock {
    public ToplevelBlock(Mono.CSharp.CompilerContext ctx, Mono.CSharp.Location loc) : base (default(Mono.CSharp.Block), default(Mono.CSharp.ParametersCompiled), default(Mono.CSharp.Location), default(Mono.CSharp.Block.Flags)) { }
    public ToplevelBlock(Mono.CSharp.CompilerContext ctx, Mono.CSharp.ParametersCompiled parameters, Mono.CSharp.Location start, Mono.CSharp.Block.Flags flags=(Mono.CSharp.Block.Flags)(0)) : base (default(Mono.CSharp.Block), default(Mono.CSharp.ParametersCompiled), default(Mono.CSharp.Location), default(Mono.CSharp.Block.Flags)) { }
    public ToplevelBlock(Mono.CSharp.ParametersBlock source, Mono.CSharp.ParametersCompiled parameters) : base (default(Mono.CSharp.Block), default(Mono.CSharp.ParametersCompiled), default(Mono.CSharp.Location), default(Mono.CSharp.Block.Flags)) { }
    public bool IsIterator { get { return default(bool); } set { } }
    public Mono.CSharp.Report Report { get { return default(Mono.CSharp.Report); } }
    public System.Collections.Generic.List<Mono.CSharp.ExplicitBlock> ThisReferencesFromChildrenBlock { get { return default(System.Collections.Generic.List<Mono.CSharp.ExplicitBlock>); } }
    public Mono.CSharp.LocalVariable ThisVariable { get { return default(Mono.CSharp.LocalVariable); } }
    public void AddLabel(string name, Mono.CSharp.LabeledStatement label) { }
    public void AddLocalName(string name, Mono.CSharp.INamedBlockVariable li, bool ignoreChildrenBlocks) { }
    public void AddThisReferenceFromChildrenBlock(Mono.CSharp.ExplicitBlock block) { }
    public void AddThisVariable(Mono.CSharp.BlockContext bc) { }
    public override void CheckControlExit(Mono.CSharp.FlowAnalysisContext fc, Mono.CSharp.DefiniteAssignmentBitSet dat) { }
    public override void Emit(Mono.CSharp.EmitContext ec) { }
    public Mono.CSharp.Arguments GetAllParametersArguments() { return default(Mono.CSharp.Arguments); }
    public bool GetLocalName(string name, Mono.CSharp.Block block, ref Mono.CSharp.INamedBlockVariable variable) { return default(bool); }
    public void IncludeBlock(Mono.CSharp.ParametersBlock pb, Mono.CSharp.ToplevelBlock block) { }
    public void RemoveThisReferenceFromChildrenBlock(Mono.CSharp.ExplicitBlock block) { }
    public bool Resolve(Mono.CSharp.BlockContext bc, Mono.CSharp.IMethodData md) { return default(bool); }
  }
  public partial class TryCatch : Mono.CSharp.ExceptionStatement {
    public Mono.CSharp.Block Block;
    public TryCatch(Mono.CSharp.Block block, System.Collections.Generic.List<Mono.CSharp.Catch> catch_clauses, Mono.CSharp.Location l, bool inside_try_finally) : base (default(Mono.CSharp.Location)) { }
    public System.Collections.Generic.List<Mono.CSharp.Catch> Clauses { get { return default(System.Collections.Generic.List<Mono.CSharp.Catch>); } }
    public bool IsTryCatchFinally { get { return default(bool); } }
    public override object Accept(Mono.CSharp.StructuralVisitor visitor) { return default(object); }
    protected override void CloneTo(Mono.CSharp.CloneContext clonectx, Mono.CSharp.Statement t) { }
    protected sealed override void DoEmit(Mono.CSharp.EmitContext ec) { }
    protected override bool DoFlowAnalysis(Mono.CSharp.FlowAnalysisContext fc) { return default(bool); }
    public override Mono.CSharp.Reachability MarkReachable(Mono.CSharp.Reachability rc) { return default(Mono.CSharp.Reachability); }
    public override bool Resolve(Mono.CSharp.BlockContext bc) { return default(bool); }
  }
  public partial class TryFinally : Mono.CSharp.TryFinallyBlock {
    public TryFinally(Mono.CSharp.Statement stmt, Mono.CSharp.ExplicitBlock fini, Mono.CSharp.Location loc) : base (default(Mono.CSharp.Statement), default(Mono.CSharp.Location)) { }
    public Mono.CSharp.ExplicitBlock FinallyBlock { get { return default(Mono.CSharp.ExplicitBlock); } }
    public override object Accept(Mono.CSharp.StructuralVisitor visitor) { return default(object); }
    protected override void CloneTo(Mono.CSharp.CloneContext clonectx, Mono.CSharp.Statement t) { }
    protected override bool DoFlowAnalysis(Mono.CSharp.FlowAnalysisContext fc) { return default(bool); }
    protected override bool EmitBeginFinallyBlock(Mono.CSharp.EmitContext ec) { return default(bool); }
    public override void EmitFinallyBody(Mono.CSharp.EmitContext ec) { }
    public static System.Reflection.Emit.Label EmitRedirectedJump(Mono.CSharp.EmitContext ec, Mono.CSharp.AsyncInitializer initializer, System.Reflection.Emit.Label label, Mono.CSharp.Block labelBlock) { return default(System.Reflection.Emit.Label); }
    public static System.Reflection.Emit.Label EmitRedirectedReturn(Mono.CSharp.EmitContext ec, Mono.CSharp.AsyncInitializer initializer) { return default(System.Reflection.Emit.Label); }
    protected override void EmitTryBody(Mono.CSharp.EmitContext ec) { }
    public override Mono.CSharp.Reachability MarkReachable(Mono.CSharp.Reachability rc) { return default(Mono.CSharp.Reachability); }
    public void RegisterForControlExitCheck(Mono.CSharp.DefiniteAssignmentBitSet vector) { }
    public override bool Resolve(Mono.CSharp.BlockContext bc) { return default(bool); }
  }
  public abstract partial class TryFinallyBlock : Mono.CSharp.ExceptionStatement {
    protected Mono.CSharp.Statement stmt;
    protected TryFinallyBlock(Mono.CSharp.Statement stmt, Mono.CSharp.Location loc) : base (default(Mono.CSharp.Location)) { }
    public Mono.CSharp.Statement Statement { get { return default(Mono.CSharp.Statement); } }
    protected sealed override void DoEmit(Mono.CSharp.EmitContext ec) { }
    protected override bool DoFlowAnalysis(Mono.CSharp.FlowAnalysisContext fc) { return default(bool); }
    protected virtual bool EmitBeginFinallyBlock(Mono.CSharp.EmitContext ec) { return default(bool); }
    public abstract void EmitFinallyBody(Mono.CSharp.EmitContext ec);
    public override void EmitForDispose(Mono.CSharp.EmitContext ec, System.Reflection.Emit.LocalBuilder pc, System.Reflection.Emit.Label end, bool have_dispatcher) { }
    protected abstract void EmitTryBody(Mono.CSharp.EmitContext ec);
    public override Mono.CSharp.Reachability MarkReachable(Mono.CSharp.Reachability rc) { return default(Mono.CSharp.Reachability); }
    public override System.Reflection.Emit.Label PrepareForDispose(Mono.CSharp.EmitContext ec, System.Reflection.Emit.Label end) { return default(System.Reflection.Emit.Label); }
    public override bool Resolve(Mono.CSharp.BlockContext bc) { return default(bool); }
  }
  public partial class Tuple<T1, T2> : System.IEquatable<Mono.CSharp.Tuple<T1, T2>> {
    public Tuple(T1 item1, T2 item2) { }
    public T1 Item1 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(T1); } }
    public T2 Item2 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(T2); } }
    public bool Equals(Mono.CSharp.Tuple<T1, T2> other) { return default(bool); }
    public override int GetHashCode() { return default(int); }
  }
  public partial class Tuple<T1, T2, T3> : System.IEquatable<Mono.CSharp.Tuple<T1, T2, T3>> {
    public Tuple(T1 item1, T2 item2, T3 item3) { }
    public T1 Item1 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(T1); } }
    public T2 Item2 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(T2); } }
    public T3 Item3 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(T3); } }
    public bool Equals(Mono.CSharp.Tuple<T1, T2, T3> other) { return default(bool); }
    public override int GetHashCode() { return default(int); }
  }
  public partial class TypeArguments {
    public TypeArguments(params Mono.CSharp.FullNamedExpression[] types) { }
    public Mono.CSharp.TypeSpec[] Arguments { get { return default(Mono.CSharp.TypeSpec[]); } set { } }
    public int Count { get { return default(int); } }
    public virtual bool IsEmpty { get { return default(bool); } }
    public System.Collections.Generic.List<Mono.CSharp.FullNamedExpression> TypeExpressions { get { return default(System.Collections.Generic.List<Mono.CSharp.FullNamedExpression>); } }
    public void Add(Mono.CSharp.FullNamedExpression type) { }
    public Mono.CSharp.TypeArguments Clone() { return default(Mono.CSharp.TypeArguments); }
    public string GetSignatureForError() { return default(string); }
    public virtual bool Resolve(Mono.CSharp.IMemberContext ec) { return default(bool); }
  }
  public abstract partial class TypeCast : Mono.CSharp.Expression {
    protected readonly Mono.CSharp.Expression child;
    protected TypeCast(Mono.CSharp.Expression child, Mono.CSharp.TypeSpec return_type) { }
    public Mono.CSharp.Expression Child { get { return default(Mono.CSharp.Expression); } }
    public override bool IsNull { get { return default(bool); } }
    protected override void CloneTo(Mono.CSharp.CloneContext clonectx, Mono.CSharp.Expression t) { }
    public override bool ContainsEmitWithAwait() { return default(bool); }
    public override Mono.CSharp.Expression CreateExpressionTree(Mono.CSharp.ResolveContext ec) { return default(Mono.CSharp.Expression); }
    protected override Mono.CSharp.Expression DoResolve(Mono.CSharp.ResolveContext ec) { return default(Mono.CSharp.Expression); }
    public override void Emit(Mono.CSharp.EmitContext ec) { }
    public override void FlowAnalysis(Mono.CSharp.FlowAnalysisContext fc) { }
    public override System.Linq.Expressions.Expression MakeExpression(Mono.CSharp.BuilderContext ctx) { return default(System.Linq.Expressions.Expression); }
  }
  public abstract partial class TypeContainer : Mono.CSharp.MemberCore {
    protected System.Collections.Generic.List<Mono.CSharp.TypeContainer> containers;
    protected System.Collections.Generic.Dictionary<System.String, Mono.CSharp.MemberCore> defined_names;
    protected bool is_defined;
    public readonly Mono.CSharp.MemberKind Kind;
    protected TypeContainer(Mono.CSharp.TypeContainer parent, Mono.CSharp.MemberName name, Mono.CSharp.Attributes attrs, Mono.CSharp.MemberKind kind) : base (default(Mono.CSharp.TypeContainer), default(Mono.CSharp.MemberName), default(Mono.CSharp.Attributes)) { }
    public System.Collections.Generic.IList<Mono.CSharp.TypeContainer> Containers { get { return default(System.Collections.Generic.IList<Mono.CSharp.TypeContainer>); } }
    public int CounterAnonymousContainers { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(int); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public int CounterAnonymousMethods { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(int); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public int CounterSwitchTypes { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(int); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public override Mono.CSharp.TypeSpec CurrentType { get { return default(Mono.CSharp.TypeSpec); } }
    public System.Collections.Generic.Dictionary<System.String, Mono.CSharp.MemberCore> DefinedNames { get { return default(System.Collections.Generic.Dictionary<System.String, Mono.CSharp.MemberCore>); } }
    public Mono.CSharp.TypeDefinition PartialContainer { get { return default(Mono.CSharp.TypeDefinition); } protected set { } }
    public Mono.CSharp.Attributes UnattachedAttributes { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(Mono.CSharp.Attributes); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public void AddCompilerGeneratedClass(Mono.CSharp.CompilerGeneratedContainer c) { }
    public virtual void AddPartial(Mono.CSharp.TypeDefinition next_part) { }
    protected void AddPartial(Mono.CSharp.TypeDefinition next_part, Mono.CSharp.TypeDefinition existing) { }
    public virtual void AddTypeContainer(Mono.CSharp.TypeContainer tc) { }
    protected virtual void AddTypeContainerMember(Mono.CSharp.TypeContainer tc) { }
    public virtual void CloseContainer() { }
    public virtual bool CreateContainer() { return default(bool); }
    public virtual void CreateMetadataName(System.Text.StringBuilder sb) { }
    public override bool Define() { return default(bool); }
    public virtual bool DefineContainer() { return default(bool); }
    protected virtual void DefineNamespace() { }
    protected virtual void DoDefineContainer() { }
    public virtual void EmitContainer() { }
    protected void Error_MissingPartialModifier(Mono.CSharp.MemberCore type) { }
    public virtual void ExpandBaseInterfaces() { }
    public override string GetSignatureForDocumentation() { return default(string); }
    public override string GetSignatureForError() { return default(string); }
    public string GetSignatureForMetadata() { return default(string); }
    public virtual void PrepareEmit() { }
    public virtual void RemoveContainer(Mono.CSharp.TypeContainer cont) { }
    public virtual void VerifyMembers() { }
    public override void WriteDebugSymbol(Mono.CompilerServices.SymbolWriter.MonoSymbolFile file) { }
  }
  public abstract partial class TypeDefinition : Mono.CSharp.TypeContainer, Mono.CSharp.IMemberDefinition, Mono.CSharp.ITypeDefinition {
    public int AnonymousMethodsCounter;
    protected Mono.CSharp.TypeSpec base_type;
    public const string DefaultIndexerName = "Item";
    public int DynamicSitesCounter;
    protected Mono.CSharp.FieldBase first_nonstatic_field;
    protected bool has_static_constructor;
    protected Mono.CSharp.TypeSpec[] iface_exprs;
    protected System.Collections.Generic.List<Mono.CSharp.FieldInitializer> initialized_fields;
    protected System.Collections.Generic.List<Mono.CSharp.FieldInitializer> initialized_static_fields;
    public int MethodGroupsCounter;
    protected bool requires_delayed_unmanagedtype_check;
    protected Mono.CSharp.TypeSpec spec;
    protected System.Collections.Generic.List<Mono.CSharp.FullNamedExpression> type_bases;
    public System.Reflection.Emit.TypeBuilder TypeBuilder;
    protected TypeDefinition(Mono.CSharp.TypeContainer parent, Mono.CSharp.MemberName name, Mono.CSharp.Attributes attrs, Mono.CSharp.MemberKind kind) : base (default(Mono.CSharp.TypeContainer), default(Mono.CSharp.MemberName), default(Mono.CSharp.Attributes), default(Mono.CSharp.MemberKind)) { }
    public override System.AttributeTargets AttributeTargets { get { return default(System.AttributeTargets); } }
    public Mono.CSharp.TypeSpec BaseType { get { return default(Mono.CSharp.TypeSpec); } }
    public System.Collections.Generic.List<Mono.CSharp.FullNamedExpression> BaseTypeExpressions { get { return default(System.Collections.Generic.List<Mono.CSharp.FullNamedExpression>); } }
    public override Mono.CSharp.TypeSpec CurrentType { get { return default(Mono.CSharp.TypeSpec); } }
    public override Mono.CSharp.TypeParameters CurrentTypeParameters { get { return default(Mono.CSharp.TypeParameters); } }
    public virtual Mono.CSharp.AssemblyDefinition DeclaringAssembly { get { return default(Mono.CSharp.AssemblyDefinition); } }
    public Mono.CSharp.TypeSpec Definition { get { return default(Mono.CSharp.TypeSpec); } }
    public override string DocComment { get { return default(string); } set { } }
    public override string DocCommentHeader { get { return default(string); } }
    public bool HasEquals { get { return default(bool); } }
    public bool HasExplicitLayout { get { return default(bool); } set { } }
    public bool HasGetHashCode { get { return default(bool); } }
    public bool HasInstanceConstructor { get { return default(bool); } set { } }
    public bool HasMembersDefined { get { return default(bool); } }
    public bool HasOperators { get { return default(bool); } set { } }
    public bool HasStaticFieldInitializer { get { return default(bool); } set { } }
    public bool HasStructLayout { get { return default(bool); } set { } }
    public Mono.CSharp.TypeSpec[] Interfaces { get { return default(Mono.CSharp.TypeSpec[]); } }
    public bool IsComImport { get { return default(bool); } }
    public bool IsGenericOrParentIsGeneric { get { return default(bool); } }
    public bool IsPartial { get { return default(bool); } }
    public bool IsTopLevel { get { return default(bool); } }
    public Mono.CSharp.MemberCache MemberCache { get { return default(Mono.CSharp.MemberCache); } }
    public System.Collections.Generic.List<Mono.CSharp.MemberCore> Members { get { return default(System.Collections.Generic.List<Mono.CSharp.MemberCore>); } }
    Mono.CSharp.IAssemblyDefinition Mono.CSharp.ITypeDefinition.DeclaringAssembly { get { return default(Mono.CSharp.IAssemblyDefinition); } }
    bool Mono.CSharp.ITypeDefinition.IsCyclicTypeForwarder { get { return default(bool); } }
    bool Mono.CSharp.ITypeDefinition.IsTypeForwarder { get { return default(bool); } }
    string Mono.CSharp.ITypeDefinition.Namespace { get { return default(string); } }
    Mono.CSharp.TypeParameterSpec[] Mono.CSharp.ITypeDefinition.TypeParameters { get { return default(Mono.CSharp.TypeParameterSpec[]); } }
    public Mono.CSharp.PendingImplementation PendingImplementations { get { return default(Mono.CSharp.PendingImplementation); } }
    public Mono.CSharp.Arguments PrimaryConstructorBaseArguments { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(Mono.CSharp.Arguments); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public Mono.CSharp.Location PrimaryConstructorBaseArgumentsStart { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(Mono.CSharp.Location); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public Mono.CSharp.ParametersCompiled PrimaryConstructorParameters { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(Mono.CSharp.ParametersCompiled); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    protected virtual System.Reflection.TypeAttributes TypeAttr { get { return default(System.Reflection.TypeAttributes); } }
    public Mono.CSharp.TypeParameters TypeParametersAll { get { return default(Mono.CSharp.TypeParameters); } }
    public int TypeParametersCount { get { return default(int); } }
    public override System.String[] ValidAttributeTargets { get { return default(System.String[]); } }
    public override void Accept(Mono.CSharp.StructuralVisitor visitor) { }
    public void AddConstructor(Mono.CSharp.Constructor c) { }
    public void AddConstructor(Mono.CSharp.Constructor c, bool isDefault) { }
    public bool AddField(Mono.CSharp.FieldBase field) { return default(bool); }
    public void AddIndexer(Mono.CSharp.Indexer i) { }
    public void AddMember(Mono.CSharp.MemberCore symbol) { }
    public virtual void AddNameToContainer(Mono.CSharp.MemberCore symbol, string name) { }
    public void AddOperator(Mono.CSharp.Operator op) { }
    public void AddPartialPart(Mono.CSharp.TypeDefinition part) { }
    public override void AddTypeContainer(Mono.CSharp.TypeContainer tc) { }
    protected override void AddTypeContainerMember(Mono.CSharp.TypeContainer tc) { }
    public override void ApplyAttributeBuilder(Mono.CSharp.Attribute a, Mono.CSharp.MethodSpec ctor, System.Byte[] cdata, Mono.CSharp.PredefinedAttributes pa) { }
    public override void CloseContainer() { }
    public override bool CreateContainer() { return default(bool); }
    public Mono.CSharp.MethodSpec CreateHoistedBaseCallProxy(Mono.CSharp.ResolveContext rc, Mono.CSharp.MethodSpec method) { return default(Mono.CSharp.MethodSpec); }
    public override void CreateMetadataName(System.Text.StringBuilder sb) { }
    public Mono.CompilerServices.SymbolWriter.SourceMethodBuilder CreateMethodSymbolEntry() { return default(Mono.CompilerServices.SymbolWriter.SourceMethodBuilder); }
    public sealed override bool Define() { return default(bool); }
    protected bool DefineBaseTypes() { return default(bool); }
    protected override void DoDefineContainer() { }
    protected virtual bool DoDefineMembers() { return default(bool); }
    public void DoExpandBaseInterfaces() { }
    protected virtual bool DoResolveTypeParameters() { return default(bool); }
    public override void Emit() { }
    public sealed override void EmitContainer() { }
    public override void ExpandBaseInterfaces() { }
    public static string FilterNestedName(string name) { return default(string); }
    public Mono.CSharp.TypeSpec GetAttributeCoClass() { return default(Mono.CSharp.TypeSpec); }
    public string GetAttributeDefaultMember() { return default(string); }
    public System.AttributeUsageAttribute GetAttributeUsage(Mono.CSharp.PredefinedAttribute pa) { return default(System.AttributeUsageAttribute); }
    public virtual Mono.CSharp.CompilationSourceFile GetCompilationSourceFile() { return default(Mono.CSharp.CompilationSourceFile); }
    public bool IsBaseTypeDefinition(Mono.CSharp.TypeSpec baseType) { return default(bool); }
    public override bool IsClsComplianceRequired() { return default(bool); }
    public virtual bool IsUnmanagedType() { return default(bool); }
    public void LoadMembers(Mono.CSharp.TypeSpec declaringType, bool onlyTypes, ref Mono.CSharp.MemberCache cache) { }
    public override Mono.CSharp.FullNamedExpression LookupNamespaceOrType(string name, int arity, Mono.CSharp.LookupMode mode, Mono.CSharp.Location loc) { return default(Mono.CSharp.FullNamedExpression); }
    public void Mark_HasEquals() { }
    public void Mark_HasGetHashCode() { }
    public bool MethodModifiersValid(Mono.CSharp.MemberCore mc) { return default(bool); }
    bool Mono.CSharp.ITypeDefinition.IsInternalAsPublic(Mono.CSharp.IAssemblyDefinition assembly) { return default(bool); }
    public override void PrepareEmit() { }
    public void RegisterFieldForInitialization(Mono.CSharp.MemberCore field, Mono.CSharp.FieldInitializer expression) { }
    public override void RemoveContainer(Mono.CSharp.TypeContainer cont) { }
    protected virtual Mono.CSharp.TypeSpec[] ResolveBaseTypes(out Mono.CSharp.FullNamedExpression base_class) { base_class = default(Mono.CSharp.FullNamedExpression); return default(Mono.CSharp.TypeSpec[]); }
    public void ResolveFieldInitializers(Mono.CSharp.BlockContext ec) { }
    public virtual void SetBaseTypes(System.Collections.Generic.List<Mono.CSharp.FullNamedExpression> baseTypes) { }
    public void SetPredefinedSpec(Mono.CSharp.BuiltinTypeSpec spec) { }
    protected override bool VerifyClsCompliance() { return default(bool); }
    public bool VerifyImplements(Mono.CSharp.InterfaceMemberBase mb) { return default(bool); }
    public override void VerifyMembers() { }
    public override void WriteDebugSymbol(Mono.CompilerServices.SymbolWriter.MonoSymbolFile file) { }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct BaseContext : Mono.CSharp.IMemberContext, Mono.CSharp.IModuleContext {
      public BaseContext(Mono.CSharp.TypeContainer tc) { throw new System.NotImplementedException(); }
      public Mono.CSharp.CompilerContext Compiler { get { return default(Mono.CSharp.CompilerContext); } }
      public Mono.CSharp.MemberCore CurrentMemberDefinition { get { return default(Mono.CSharp.MemberCore); } }
      public Mono.CSharp.TypeSpec CurrentType { get { return default(Mono.CSharp.TypeSpec); } }
      public Mono.CSharp.TypeParameters CurrentTypeParameters { get { return default(Mono.CSharp.TypeParameters); } }
      public bool IsObsolete { get { return default(bool); } }
      public bool IsStatic { get { return default(bool); } }
      public bool IsUnsafe { get { return default(bool); } }
      public Mono.CSharp.ModuleContainer Module { get { return default(Mono.CSharp.ModuleContainer); } }
      public string GetSignatureForError() { return default(string); }
      public Mono.CSharp.ExtensionMethodCandidates LookupExtensionMethod(Mono.CSharp.TypeSpec extensionType, string name, int arity) { return default(Mono.CSharp.ExtensionMethodCandidates); }
      public Mono.CSharp.FullNamedExpression LookupNamespaceAlias(string name) { return default(Mono.CSharp.FullNamedExpression); }
      public Mono.CSharp.FullNamedExpression LookupNamespaceOrType(string name, int arity, Mono.CSharp.LookupMode mode, Mono.CSharp.Location loc) { return default(Mono.CSharp.FullNamedExpression); }
    }
  }
  public abstract partial class TypeExpr : Mono.CSharp.FullNamedExpression {
    protected TypeExpr() { }
    protected sealed override Mono.CSharp.Expression DoResolve(Mono.CSharp.ResolveContext ec) { return default(Mono.CSharp.Expression); }
    public override bool Equals(object obj) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public sealed override Mono.CSharp.FullNamedExpression ResolveAsTypeOrNamespace(Mono.CSharp.IMemberContext mc, bool allowUnboundTypeArguments) { return default(Mono.CSharp.FullNamedExpression); }
  }
  public partial class TypeExpression : Mono.CSharp.TypeExpr {
    public TypeExpression(Mono.CSharp.TypeSpec t, Mono.CSharp.Location l) { }
    public sealed override Mono.CSharp.TypeSpec ResolveAsType(Mono.CSharp.IMemberContext mc, bool allowUnboundTypeArguments=false) { return default(Mono.CSharp.TypeSpec); }
  }
  public partial class TypeInferenceContext {
    public TypeInferenceContext() { }
    public TypeInferenceContext(Mono.CSharp.TypeSpec[] typeArguments) { }
    public Mono.CSharp.TypeSpec[] InferredTypeArguments { get { return default(Mono.CSharp.TypeSpec[]); } }
    public bool UnfixedVariableExists { get { return default(bool); } }
    public void AddCommonTypeBound(Mono.CSharp.TypeSpec type) { }
    public void AddCommonTypeBoundAsync(Mono.CSharp.TypeSpec type) { }
    public int ExactInference(Mono.CSharp.TypeSpec u, Mono.CSharp.TypeSpec v) { return default(int); }
    public bool FixAllTypes(Mono.CSharp.ResolveContext ec) { return default(bool); }
    public bool FixDependentTypes(Mono.CSharp.ResolveContext ec, ref bool fixed_any) { return default(bool); }
    public bool FixIndependentTypeArguments(Mono.CSharp.ResolveContext ec, Mono.CSharp.TypeSpec[] methodParameters, ref bool fixed_any) { return default(bool); }
    public bool FixType(Mono.CSharp.ResolveContext ec, int i) { return default(bool); }
    public bool HasBounds(int pos) { return default(bool); }
    public Mono.CSharp.TypeSpec InflateGenericArgument(Mono.CSharp.IModuleContext context, Mono.CSharp.TypeSpec parameter) { return default(Mono.CSharp.TypeSpec); }
    public bool IsReturnTypeNonDependent(Mono.CSharp.MethodSpec invoke, Mono.CSharp.TypeSpec returnType) { return default(bool); }
    public int LowerBoundInference(Mono.CSharp.TypeSpec u, Mono.CSharp.TypeSpec v) { return default(int); }
    public int OutputTypeInference(Mono.CSharp.ResolveContext ec, Mono.CSharp.Expression e, Mono.CSharp.TypeSpec t) { return default(int); }
    protected enum BoundKind {
      Exact = 0,
      Lower = 1,
      Upper = 2,
    }
  }
  public partial class TypeInfo {
    internal TypeInfo() { }
    public readonly bool IsStruct;
    public readonly int Length;
    public readonly int Offset;
    public Mono.CSharp.TypeInfo[] SubStructInfo;
    public readonly int TotalLength;
    public int GetFieldIndex(string name) { return default(int); }
    public Mono.CSharp.TypeInfo GetStructField(string name) { return default(Mono.CSharp.TypeInfo); }
    public static Mono.CSharp.TypeInfo GetTypeInfo(Mono.CSharp.TypeSpec type) { return default(Mono.CSharp.TypeInfo); }
    public bool IsFullyInitialized(Mono.CSharp.FlowAnalysisContext fc, Mono.CSharp.VariableInfo vi, Mono.CSharp.Location loc) { return default(bool); }
    public static void Reset() { }
    public override string ToString() { return default(string); }
  }
  public partial class TypeOf : Mono.CSharp.Expression {
    public TypeOf(Mono.CSharp.FullNamedExpression queried_type, Mono.CSharp.Location l) { }
    public TypeOf(Mono.CSharp.TypeSpec type, Mono.CSharp.Location loc) { }
    public override bool IsSideEffectFree { get { return default(bool); } }
    public Mono.CSharp.TypeSpec TypeArgument { get { return default(Mono.CSharp.TypeSpec); } }
    public Mono.CSharp.FullNamedExpression TypeExpression { get { return default(Mono.CSharp.FullNamedExpression); } }
    public override object Accept(Mono.CSharp.StructuralVisitor visitor) { return default(object); }
    protected override void CloneTo(Mono.CSharp.CloneContext clonectx, Mono.CSharp.Expression t) { }
    public override bool ContainsEmitWithAwait() { return default(bool); }
    public override Mono.CSharp.Expression CreateExpressionTree(Mono.CSharp.ResolveContext ec) { return default(Mono.CSharp.Expression); }
    protected override Mono.CSharp.Expression DoResolve(Mono.CSharp.ResolveContext ec) { return default(Mono.CSharp.Expression); }
    public override void Emit(Mono.CSharp.EmitContext ec) { }
    public override void EncodeAttributeValue(Mono.CSharp.IMemberContext rc, Mono.CSharp.AttributeEncoder enc, Mono.CSharp.TypeSpec targetType, Mono.CSharp.TypeSpec parameterType) { }
  }
  public partial class TypeParameter : Mono.CSharp.MemberCore, Mono.CSharp.IMemberDefinition, Mono.CSharp.ITypeDefinition {
    public TypeParameter(Mono.CSharp.MemberName name, Mono.CSharp.Attributes attrs, Mono.CSharp.VarianceDecl variance) : base (default(Mono.CSharp.TypeContainer), default(Mono.CSharp.MemberName), default(Mono.CSharp.Attributes)) { }
    public TypeParameter(Mono.CSharp.TypeParameterSpec spec, Mono.CSharp.TypeSpec parentSpec, Mono.CSharp.MemberName name, Mono.CSharp.Attributes attrs) : base (default(Mono.CSharp.TypeContainer), default(Mono.CSharp.MemberName), default(Mono.CSharp.Attributes)) { }
    public TypeParameter(int index, Mono.CSharp.MemberName name, Mono.CSharp.Constraints constraints, Mono.CSharp.Attributes attrs, Mono.CSharp.Variance Variance) : base (default(Mono.CSharp.TypeContainer), default(Mono.CSharp.MemberName), default(Mono.CSharp.Attributes)) { }
    public override System.AttributeTargets AttributeTargets { get { return default(System.AttributeTargets); } }
    public Mono.CSharp.Constraints Constraints { get { return default(Mono.CSharp.Constraints); } set { } }
    public Mono.CSharp.IAssemblyDefinition DeclaringAssembly { get { return default(Mono.CSharp.IAssemblyDefinition); } }
    public override string DocCommentHeader { get { return default(string); } }
    public bool IsMethodTypeParameter { get { return default(bool); } }
    bool Mono.CSharp.ITypeDefinition.IsComImport { get { return default(bool); } }
    bool Mono.CSharp.ITypeDefinition.IsCyclicTypeForwarder { get { return default(bool); } }
    bool Mono.CSharp.ITypeDefinition.IsPartial { get { return default(bool); } }
    bool Mono.CSharp.ITypeDefinition.IsTypeForwarder { get { return default(bool); } }
    public string Name { get { return default(string); } }
    public string Namespace { get { return default(string); } }
    public Mono.CSharp.TypeParameterSpec Type { get { return default(Mono.CSharp.TypeParameterSpec); } }
    public Mono.CSharp.TypeParameterSpec[] TypeParameters { get { return default(Mono.CSharp.TypeParameterSpec[]); } }
    public int TypeParametersCount { get { return default(int); } }
    public override System.String[] ValidAttributeTargets { get { return default(System.String[]); } }
    public Mono.CSharp.Variance Variance { get { return default(Mono.CSharp.Variance); } }
    public Mono.CSharp.VarianceDecl VarianceDecl { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(Mono.CSharp.VarianceDecl); } }
    public bool AddPartialConstraints(Mono.CSharp.TypeDefinition part, Mono.CSharp.TypeParameter tp) { return default(bool); }
    public override void ApplyAttributeBuilder(Mono.CSharp.Attribute a, Mono.CSharp.MethodSpec ctor, System.Byte[] cdata, Mono.CSharp.PredefinedAttributes pa) { }
    public void CheckGenericConstraints(bool obsoleteCheck) { }
    public void Create(Mono.CSharp.TypeSpec declaringType, Mono.CSharp.TypeContainer parent) { }
    public Mono.CSharp.TypeParameter CreateHoistedCopy(Mono.CSharp.TypeSpec declaringSpec) { return default(Mono.CSharp.TypeParameter); }
    public override bool Define() { return default(bool); }
    public void Define(Mono.CSharp.TypeParameter tp) { }
    public void Define(System.Reflection.Emit.GenericTypeParameterBuilder type) { }
    public override void Emit() { }
    public void EmitConstraints(System.Reflection.Emit.GenericTypeParameterBuilder builder) { }
    public void ErrorInvalidVariance(Mono.CSharp.IMemberContext mc, Mono.CSharp.Variance expected) { }
    public Mono.CSharp.TypeSpec GetAttributeCoClass() { return default(Mono.CSharp.TypeSpec); }
    public string GetAttributeDefaultMember() { return default(string); }
    public System.AttributeUsageAttribute GetAttributeUsage(Mono.CSharp.PredefinedAttribute pa) { return default(System.AttributeUsageAttribute); }
    public override string GetSignatureForDocumentation() { return default(string); }
    public override string GetSignatureForError() { return default(string); }
    public override bool IsClsComplianceRequired() { return default(bool); }
    public void LoadMembers(Mono.CSharp.TypeSpec declaringType, bool onlyTypes, ref Mono.CSharp.MemberCache cache) { }
    bool Mono.CSharp.ITypeDefinition.IsInternalAsPublic(Mono.CSharp.IAssemblyDefinition assembly) { return default(bool); }
    public bool ResolveConstraints(Mono.CSharp.IMemberContext context) { return default(bool); }
    public new void VerifyClsCompliance() { }
    public void WarningParentNameConflict(Mono.CSharp.TypeParameter conflict) { }
  }
  public partial class TypeParameterExpr : Mono.CSharp.TypeExpression {
    public TypeParameterExpr(Mono.CSharp.TypeParameter type_parameter, Mono.CSharp.Location loc) : base (default(Mono.CSharp.TypeSpec), default(Mono.CSharp.Location)) { }
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct TypeParameterInflator {
    public TypeParameterInflator(Mono.CSharp.IModuleContext context, Mono.CSharp.TypeSpec type, Mono.CSharp.TypeParameterSpec[] tparams, Mono.CSharp.TypeSpec[] targs) { throw new System.NotImplementedException(); }
    public TypeParameterInflator(Mono.CSharp.TypeParameterInflator nested, Mono.CSharp.TypeSpec type) { throw new System.NotImplementedException(); }
    public Mono.CSharp.IModuleContext Context { get { return default(Mono.CSharp.IModuleContext); } }
    public Mono.CSharp.TypeSpec TypeInstance { get { return default(Mono.CSharp.TypeSpec); } }
    public Mono.CSharp.TypeParameterSpec[] TypeParameters { get { return default(Mono.CSharp.TypeParameterSpec[]); } }
    public Mono.CSharp.TypeSpec Inflate(Mono.CSharp.TypeParameterSpec tp) { return default(Mono.CSharp.TypeSpec); }
    public Mono.CSharp.TypeSpec Inflate(Mono.CSharp.TypeSpec type) { return default(Mono.CSharp.TypeSpec); }
  }
  public partial class TypeParameterMutator {
    public TypeParameterMutator(Mono.CSharp.TypeParameters mvar, Mono.CSharp.TypeParameters var) { }
    public TypeParameterMutator(Mono.CSharp.TypeParameterSpec[] srcVar, Mono.CSharp.TypeParameters destVar) { }
    public Mono.CSharp.TypeParameters MethodTypeParameters { get { return default(Mono.CSharp.TypeParameters); } }
    public static Mono.CSharp.TypeSpec GetMemberDeclaringType(Mono.CSharp.TypeSpec type) { return default(Mono.CSharp.TypeSpec); }
    public Mono.CSharp.TypeParameterSpec Mutate(Mono.CSharp.TypeParameterSpec tp) { return default(Mono.CSharp.TypeParameterSpec); }
    public Mono.CSharp.TypeSpec Mutate(Mono.CSharp.TypeSpec ts) { return default(Mono.CSharp.TypeSpec); }
    public Mono.CSharp.TypeSpec[] Mutate(Mono.CSharp.TypeSpec[] targs) { return default(Mono.CSharp.TypeSpec[]); }
  }
  public partial class TypeParameters {
    public TypeParameters() { }
    public TypeParameters(int count) { }
    public int Count { get { return default(int); } }
    public Mono.CSharp.TypeParameter this[int index] { get { return default(Mono.CSharp.TypeParameter); } set { } }
    public Mono.CSharp.TypeParameterSpec[] Types { get { return default(Mono.CSharp.TypeParameterSpec[]); } }
    public void Add(Mono.CSharp.TypeParameter tparam) { }
    public void Add(Mono.CSharp.TypeParameters tparams) { }
    public void CheckPartialConstraints(Mono.CSharp.Method part) { }
    public void Create(Mono.CSharp.TypeSpec declaringType, int parentOffset, Mono.CSharp.TypeContainer parent) { }
    public void Define(System.Reflection.Emit.GenericTypeParameterBuilder[] builders) { }
    public Mono.CSharp.TypeParameter Find(string name) { return default(Mono.CSharp.TypeParameter); }
    public System.String[] GetAllNames() { return default(System.String[]); }
    public string GetSignatureForError() { return default(string); }
    public void UpdateConstraints(Mono.CSharp.TypeDefinition part) { }
    public void VerifyClsCompliance() { }
  }
  [System.Diagnostics.DebuggerDisplayAttribute("{DisplayDebugInfo()}")]
  public partial class TypeParameterSpec : Mono.CSharp.TypeSpec {
    public static readonly new Mono.CSharp.TypeParameterSpec[] EmptyTypes;
    public TypeParameterSpec(Mono.CSharp.TypeSpec declaringType, int index, Mono.CSharp.ITypeDefinition definition, Mono.CSharp.SpecialConstraint spec, Mono.CSharp.Variance variance, System.Type info) : base (default(Mono.CSharp.MemberKind), default(Mono.CSharp.TypeSpec), default(Mono.CSharp.ITypeDefinition), default(System.Type), default(Mono.CSharp.Modifiers)) { }
    public TypeParameterSpec(int index, Mono.CSharp.ITypeDefinition definition, Mono.CSharp.SpecialConstraint spec, Mono.CSharp.Variance variance, System.Type info) : base (default(Mono.CSharp.MemberKind), default(Mono.CSharp.TypeSpec), default(Mono.CSharp.ITypeDefinition), default(System.Type), default(Mono.CSharp.Modifiers)) { }
    public int DeclaredPosition { get { return default(int); } set { } }
    public bool HasAnyTypeConstraint { get { return default(bool); } }
    public bool HasSpecialClass { get { return default(bool); } }
    public bool HasSpecialConstructor { get { return default(bool); } }
    public bool HasSpecialStruct { get { return default(bool); } }
    public bool HasTypeConstraint { get { return default(bool); } }
    public override System.Collections.Generic.IList<Mono.CSharp.TypeSpec> Interfaces { get { return default(System.Collections.Generic.IList<Mono.CSharp.TypeSpec>); } }
    public Mono.CSharp.TypeSpec[] InterfacesDefined { get { return default(Mono.CSharp.TypeSpec[]); } set { } }
    public bool IsConstrained { get { return default(bool); } }
    public bool IsMethodOwned { get { return default(bool); } }
    public bool IsReferenceType { get { return default(bool); } }
    public bool IsValueType { get { return default(bool); } }
    public override string Name { get { return default(string); } }
    public Mono.CSharp.SpecialConstraint SpecialConstraint { get { return default(Mono.CSharp.SpecialConstraint); } set { } }
    public new Mono.CSharp.TypeSpec[] TypeArguments { get { return default(Mono.CSharp.TypeSpec[]); } set { } }
    public Mono.CSharp.Variance Variance { get { return default(Mono.CSharp.Variance); } }
    public string DisplayDebugInfo() { return default(string); }
    public Mono.CSharp.TypeSpec GetEffectiveBase() { return default(Mono.CSharp.TypeSpec); }
    public override string GetSignatureForDocumentation() { return default(string); }
    public override string GetSignatureForError() { return default(string); }
    public static bool HasAnyTypeParameterConstrained(Mono.CSharp.IGenericMethodDefinition md) { return default(bool); }
    public static bool HasAnyTypeParameterTypeConstrained(Mono.CSharp.IGenericMethodDefinition md) { return default(bool); }
    public bool HasDependencyOn(Mono.CSharp.TypeSpec type) { return default(bool); }
    public bool HasSameConstraintsDefinition(Mono.CSharp.TypeParameterSpec other) { return default(bool); }
    public bool HasSameConstraintsImplementation(Mono.CSharp.TypeParameterSpec other) { return default(bool); }
    public void InflateConstraints(Mono.CSharp.TypeParameterInflator inflator, Mono.CSharp.TypeParameterSpec tps) { }
    public static Mono.CSharp.TypeParameterSpec[] InflateConstraints(Mono.CSharp.TypeParameterInflator inflator, Mono.CSharp.TypeParameterSpec[] tparams) { return default(Mono.CSharp.TypeParameterSpec[]); }
    public static Mono.CSharp.TypeParameterSpec[] InflateConstraints<T>(Mono.CSharp.TypeParameterSpec[] tparams, System.Func<T, Mono.CSharp.TypeParameterInflator> inflatorFactory, T arg) { return default(Mono.CSharp.TypeParameterSpec[]); }
    public override Mono.CSharp.MemberSpec InflateMember(Mono.CSharp.TypeParameterInflator inflator) { return default(Mono.CSharp.MemberSpec); }
    protected override void InitializeMemberCache(bool onlyTypes) { }
    public bool IsConvertibleToInterface(Mono.CSharp.TypeSpec iface) { return default(bool); }
    public override Mono.CSharp.TypeSpec Mutate(Mono.CSharp.TypeParameterMutator mutator) { return default(Mono.CSharp.TypeSpec); }
  }
  public partial class TypeSpec : Mono.CSharp.MemberSpec {
    protected Mono.CSharp.MemberCache cache;
    public static readonly Mono.CSharp.TypeSpec[] EmptyTypes;
    protected System.Collections.Generic.IList<Mono.CSharp.TypeSpec> ifaces;
    protected System.Type info;
    public TypeSpec(Mono.CSharp.MemberKind kind, Mono.CSharp.TypeSpec declaringType, Mono.CSharp.ITypeDefinition definition, System.Type info, Mono.CSharp.Modifiers modifiers) : base (default(Mono.CSharp.MemberKind), default(Mono.CSharp.TypeSpec), default(Mono.CSharp.IMemberDefinition), default(Mono.CSharp.Modifiers)) { }
    public override int Arity { get { return default(int); } }
    public virtual Mono.CSharp.TypeSpec BaseType { get { return default(Mono.CSharp.TypeSpec); } set { } }
    public virtual Mono.CSharp.BuiltinTypeSpec.Type BuiltinType { get { return default(Mono.CSharp.BuiltinTypeSpec.Type); } }
    public bool HasDynamicElement { get { return default(bool); } }
    public virtual System.Collections.Generic.IList<Mono.CSharp.TypeSpec> Interfaces { get { return default(System.Collections.Generic.IList<Mono.CSharp.TypeSpec>); } set { } }
    public bool IsArray { get { return default(bool); } }
    public virtual bool IsArrayGenericInterface { get { return default(bool); } set { } }
    public bool IsAttribute { get { return default(bool); } }
    public bool IsClass { get { return default(bool); } }
    public bool IsConstantCompatible { get { return default(bool); } }
    public bool IsDelegate { get { return default(bool); } }
    public bool IsEnum { get { return default(bool); } }
    public virtual bool IsExpressionTreeType { get { return default(bool); } set { } }
    public bool IsGenericOrParentIsGeneric { get { return default(bool); } }
    public bool IsGenericParameter { get { return default(bool); } }
    public virtual bool IsGenericTask { get { return default(bool); } set { } }
    public bool IsInterface { get { return default(bool); } }
    public bool IsNested { get { return default(bool); } }
    public virtual bool IsNullableType { get { return default(bool); } set { } }
    public bool IsPointer { get { return default(bool); } }
    public bool IsSealed { get { return default(bool); } }
    public bool IsSpecialRuntimeType { get { return default(bool); } set { } }
    public bool IsStruct { get { return default(bool); } }
    public bool IsStructOrEnum { get { return default(bool); } }
    public bool IsTypeBuilder { get { return default(bool); } }
    public bool IsUnmanaged { get { return default(bool); } }
    public Mono.CSharp.MemberCache MemberCache { get { return default(Mono.CSharp.MemberCache); } set { } }
    public Mono.CSharp.MemberCache MemberCacheTypes { get { return default(Mono.CSharp.MemberCache); } }
    public new Mono.CSharp.ITypeDefinition MemberDefinition { get { return default(Mono.CSharp.ITypeDefinition); } }
    public virtual Mono.CSharp.TypeSpec[] TypeArguments { get { return default(Mono.CSharp.TypeSpec[]); } }
    public virtual bool AddInterface(Mono.CSharp.TypeSpec iface) { return default(bool); }
    public bool AddInterfaceDefined(Mono.CSharp.TypeSpec iface) { return default(bool); }
    public static Mono.CSharp.TypeSpec[] GetAllTypeArguments(Mono.CSharp.TypeSpec type) { return default(Mono.CSharp.TypeSpec[]); }
    public System.AttributeUsageAttribute GetAttributeUsage(Mono.CSharp.PredefinedAttribute pa) { return default(System.AttributeUsageAttribute); }
    public virtual Mono.CSharp.TypeSpec GetDefinition() { return default(Mono.CSharp.TypeSpec); }
    public string GetExplicitNameSignatureForDocumentation() { return default(string); }
    public virtual System.Type GetMetaInfo() { return default(System.Type); }
    public override string GetSignatureForDocumentation() { return default(string); }
    public override string GetSignatureForError() { return default(string); }
    public string GetSignatureForErrorIncludingAssemblyName() { return default(string); }
    protected virtual string GetTypeNameSignature() { return default(string); }
    public bool ImplementsInterface(Mono.CSharp.TypeSpec iface, bool variantly) { return default(bool); }
    public override Mono.CSharp.MemberSpec InflateMember(Mono.CSharp.TypeParameterInflator inflator) { return default(Mono.CSharp.MemberSpec); }
    protected virtual void InitializeMemberCache(bool onlyTypes) { }
    public static bool IsBaseClass(Mono.CSharp.TypeSpec type, Mono.CSharp.TypeSpec baseClass, bool dynamicIsObject) { return default(bool); }
    public static bool IsNonNullableValueType(Mono.CSharp.TypeSpec t) { return default(bool); }
    public static bool IsReferenceType(Mono.CSharp.TypeSpec t) { return default(bool); }
    public static bool IsValueType(Mono.CSharp.TypeSpec t) { return default(bool); }
    public Mono.CSharp.InflatedTypeSpec MakeGenericType(Mono.CSharp.IModuleContext context, Mono.CSharp.TypeSpec[] targs) { return default(Mono.CSharp.InflatedTypeSpec); }
    public virtual Mono.CSharp.TypeSpec Mutate(Mono.CSharp.TypeParameterMutator mutator) { return default(Mono.CSharp.TypeSpec); }
    public override System.Collections.Generic.List<Mono.CSharp.MissingTypeSpecReference> ResolveMissingDependencies(Mono.CSharp.MemberSpec caller) { return default(System.Collections.Generic.List<Mono.CSharp.MissingTypeSpecReference>); }
    public void SetExtensionMethodContainer() { }
    public void SetMetaInfo(System.Type info) { }
    public void UpdateInflatedInstancesBaseType() { }
  }
  public partial class UIntConstant : Mono.CSharp.IntegralConstant {
    public readonly uint Value;
    public UIntConstant(Mono.CSharp.BuiltinTypes types, uint v, Mono.CSharp.Location loc) : base (default(Mono.CSharp.TypeSpec), default(Mono.CSharp.Location)) { }
    public UIntConstant(Mono.CSharp.TypeSpec type, uint v, Mono.CSharp.Location loc) : base (default(Mono.CSharp.TypeSpec), default(Mono.CSharp.Location)) { }
    public override bool IsDefaultValue { get { return default(bool); } }
    public override bool IsNegative { get { return default(bool); } }
    public override bool IsOneInteger { get { return default(bool); } }
    public override bool IsZeroInteger { get { return default(bool); } }
    public override Mono.CSharp.Constant ConvertExplicitly(bool in_checked_context, Mono.CSharp.TypeSpec target_type) { return default(Mono.CSharp.Constant); }
    public override void Emit(Mono.CSharp.EmitContext ec) { }
    public override void EncodeAttributeValue(Mono.CSharp.IMemberContext rc, Mono.CSharp.AttributeEncoder enc, Mono.CSharp.TypeSpec targetType, Mono.CSharp.TypeSpec parameterType) { }
    public override object GetValue() { return default(object); }
    public override long GetValueAsLong() { return default(long); }
    public override Mono.CSharp.Constant Increment() { return default(Mono.CSharp.Constant); }
  }
  public partial class UIntLiteral : Mono.CSharp.UIntConstant, Mono.CSharp.ILiteralConstant {
    public UIntLiteral(Mono.CSharp.BuiltinTypes types, uint l, Mono.CSharp.Location loc) : base (default(Mono.CSharp.BuiltinTypes), default(uint), default(Mono.CSharp.Location)) { }
    public override bool IsLiteral { get { return default(bool); } }
    public override object Accept(Mono.CSharp.StructuralVisitor visitor) { return default(object); }
  }
  public partial class ULongConstant : Mono.CSharp.IntegralConstant {
    public readonly ulong Value;
    public ULongConstant(Mono.CSharp.BuiltinTypes types, ulong v, Mono.CSharp.Location loc) : base (default(Mono.CSharp.TypeSpec), default(Mono.CSharp.Location)) { }
    public ULongConstant(Mono.CSharp.TypeSpec type, ulong v, Mono.CSharp.Location loc) : base (default(Mono.CSharp.TypeSpec), default(Mono.CSharp.Location)) { }
    public override bool IsDefaultValue { get { return default(bool); } }
    public override bool IsNegative { get { return default(bool); } }
    public override bool IsOneInteger { get { return default(bool); } }
    public override bool IsZeroInteger { get { return default(bool); } }
    public override Mono.CSharp.Constant ConvertExplicitly(bool in_checked_context, Mono.CSharp.TypeSpec target_type) { return default(Mono.CSharp.Constant); }
    public override void Emit(Mono.CSharp.EmitContext ec) { }
    public override void EncodeAttributeValue(Mono.CSharp.IMemberContext rc, Mono.CSharp.AttributeEncoder enc, Mono.CSharp.TypeSpec targetType, Mono.CSharp.TypeSpec parameterType) { }
    public override object GetValue() { return default(object); }
    public override long GetValueAsLong() { return default(long); }
    public override Mono.CSharp.Constant Increment() { return default(Mono.CSharp.Constant); }
  }
  public partial class ULongLiteral : Mono.CSharp.ULongConstant, Mono.CSharp.ILiteralConstant {
    public ULongLiteral(Mono.CSharp.BuiltinTypes types, ulong l, Mono.CSharp.Location loc) : base (default(Mono.CSharp.BuiltinTypes), default(ulong), default(Mono.CSharp.Location)) { }
    public override bool IsLiteral { get { return default(bool); } }
    public override object Accept(Mono.CSharp.StructuralVisitor visitor) { return default(object); }
  }
  public partial class Unary : Mono.CSharp.Expression {
    public Mono.CSharp.Expression Expr;
    public readonly Mono.CSharp.Unary.Operator Oper;
    public Unary(Mono.CSharp.Unary.Operator op, Mono.CSharp.Expression expr, Mono.CSharp.Location loc) { }
    public override object Accept(Mono.CSharp.StructuralVisitor visitor) { return default(object); }
    protected override void CloneTo(Mono.CSharp.CloneContext clonectx, Mono.CSharp.Expression t) { }
    public override bool ContainsEmitWithAwait() { return default(bool); }
    public override Mono.CSharp.Expression CreateExpressionTree(Mono.CSharp.ResolveContext ec) { return default(Mono.CSharp.Expression); }
    public static Mono.CSharp.TypeSpec[][] CreatePredefinedOperatorsTable(Mono.CSharp.BuiltinTypes types) { return default(Mono.CSharp.TypeSpec[][]); }
    protected override Mono.CSharp.Expression DoResolve(Mono.CSharp.ResolveContext ec) { return default(Mono.CSharp.Expression); }
    public override Mono.CSharp.Expression DoResolveLValue(Mono.CSharp.ResolveContext ec, Mono.CSharp.Expression right) { return default(Mono.CSharp.Expression); }
    public override void Emit(Mono.CSharp.EmitContext ec) { }
    public override void EmitBranchable(Mono.CSharp.EmitContext ec, System.Reflection.Emit.Label target, bool on_true) { }
    protected void EmitOperator(Mono.CSharp.EmitContext ec, Mono.CSharp.TypeSpec type) { }
    public override void EmitSideEffect(Mono.CSharp.EmitContext ec) { }
    public static void Error_Ambiguous(Mono.CSharp.ResolveContext rc, string oper, Mono.CSharp.TypeSpec type, Mono.CSharp.Location loc) { }
    public override void FlowAnalysis(Mono.CSharp.FlowAnalysisContext fc) { }
    public override void FlowAnalysisConditional(Mono.CSharp.FlowAnalysisContext fc) { }
    public override System.Linq.Expressions.Expression MakeExpression(Mono.CSharp.BuilderContext ctx) { return default(System.Linq.Expressions.Expression); }
    public static string OperName(Mono.CSharp.Unary.Operator oper) { return default(string); }
    protected virtual Mono.CSharp.Expression ResolveEnumOperator(Mono.CSharp.ResolveContext ec, Mono.CSharp.Expression expr, Mono.CSharp.TypeSpec[] predefined) { return default(Mono.CSharp.Expression); }
    protected virtual Mono.CSharp.Expression ResolveOperator(Mono.CSharp.ResolveContext ec, Mono.CSharp.Expression expr) { return default(Mono.CSharp.Expression); }
    protected virtual Mono.CSharp.Expression ResolveUserOperator(Mono.CSharp.ResolveContext ec, Mono.CSharp.Expression expr) { return default(Mono.CSharp.Expression); }
    public enum Operator : byte {
      AddressOf = (byte)4,
      LogicalNot = (byte)2,
      OnesComplement = (byte)3,
      TOP = (byte)5,
      UnaryNegation = (byte)1,
      UnaryPlus = (byte)0,
    }
  }
  public partial class UnaryMutator : Mono.CSharp.ExpressionStatement {
    protected Mono.CSharp.Expression expr;
    public UnaryMutator(Mono.CSharp.UnaryMutator.Mode m, Mono.CSharp.Expression e, Mono.CSharp.Location loc) { }
    public Mono.CSharp.Expression Expr { get { return default(Mono.CSharp.Expression); } }
    public override Mono.CSharp.Location StartLocation { get { return default(Mono.CSharp.Location); } }
    public Mono.CSharp.UnaryMutator.Mode UnaryMutatorMode { get { return default(Mono.CSharp.UnaryMutator.Mode); } }
    public override object Accept(Mono.CSharp.StructuralVisitor visitor) { return default(object); }
    protected override void CloneTo(Mono.CSharp.CloneContext clonectx, Mono.CSharp.Expression t) { }
    public override bool ContainsEmitWithAwait() { return default(bool); }
    public override Mono.CSharp.Expression CreateExpressionTree(Mono.CSharp.ResolveContext ec) { return default(Mono.CSharp.Expression); }
    public static Mono.CSharp.TypeSpec[] CreatePredefinedOperatorsTable(Mono.CSharp.BuiltinTypes types) { return default(Mono.CSharp.TypeSpec[]); }
    protected override Mono.CSharp.Expression DoResolve(Mono.CSharp.ResolveContext ec) { return default(Mono.CSharp.Expression); }
    protected Mono.CSharp.Expression DoResolveOperation(Mono.CSharp.ResolveContext ec) { return default(Mono.CSharp.Expression); }
    public override void Emit(Mono.CSharp.EmitContext ec) { }
    protected virtual void EmitOperation(Mono.CSharp.EmitContext ec) { }
    public override void EmitStatement(Mono.CSharp.EmitContext ec) { }
    public override void FlowAnalysis(Mono.CSharp.FlowAnalysisContext fc) { }
    public static string OperName(Mono.CSharp.UnaryMutator.Mode oper) { return default(string); }
    [System.FlagsAttribute]
    public enum Mode : byte {
      IsDecrement = (byte)1,
      IsIncrement = (byte)0,
      IsPost = (byte)2,
      IsPre = (byte)0,
      PostDecrement = (byte)3,
      PostIncrement = (byte)2,
      PreDecrement = (byte)1,
      PreIncrement = (byte)0,
    }
  }
  public partial class UnboundTypeArguments : Mono.CSharp.TypeArguments {
    public UnboundTypeArguments(int arity) : base (default(Mono.CSharp.FullNamedExpression[])) { }
    public override bool IsEmpty { get { return default(bool); } }
    public override bool Resolve(Mono.CSharp.IMemberContext ec) { return default(bool); }
  }
  public partial class UnboxCast : Mono.CSharp.TypeCast {
    public UnboxCast(Mono.CSharp.Expression expr, Mono.CSharp.TypeSpec return_type) : base (default(Mono.CSharp.Expression), default(Mono.CSharp.TypeSpec)) { }
    protected override Mono.CSharp.Expression DoResolve(Mono.CSharp.ResolveContext ec) { return default(Mono.CSharp.Expression); }
    public override void Emit(Mono.CSharp.EmitContext ec) { }
  }
  public partial class Unchecked : Mono.CSharp.Statement {
    public Mono.CSharp.Block Block;
    public Unchecked(Mono.CSharp.Block b, Mono.CSharp.Location loc) { }
    public override object Accept(Mono.CSharp.StructuralVisitor visitor) { return default(object); }
    protected override void CloneTo(Mono.CSharp.CloneContext clonectx, Mono.CSharp.Statement t) { }
    protected override void DoEmit(Mono.CSharp.EmitContext ec) { }
    protected override bool DoFlowAnalysis(Mono.CSharp.FlowAnalysisContext fc) { return default(bool); }
    public override Mono.CSharp.Reachability MarkReachable(Mono.CSharp.Reachability rc) { return default(Mono.CSharp.Reachability); }
    public override bool Resolve(Mono.CSharp.BlockContext ec) { return default(bool); }
  }
  public partial class UnCheckedExpr : Mono.CSharp.Expression {
    public Mono.CSharp.Expression Expr;
    public UnCheckedExpr(Mono.CSharp.Expression e, Mono.CSharp.Location l) { }
    public override object Accept(Mono.CSharp.StructuralVisitor visitor) { return default(object); }
    protected override void CloneTo(Mono.CSharp.CloneContext clonectx, Mono.CSharp.Expression t) { }
    public override bool ContainsEmitWithAwait() { return default(bool); }
    public override Mono.CSharp.Expression CreateExpressionTree(Mono.CSharp.ResolveContext ec) { return default(Mono.CSharp.Expression); }
    protected override Mono.CSharp.Expression DoResolve(Mono.CSharp.ResolveContext ec) { return default(Mono.CSharp.Expression); }
    public override void Emit(Mono.CSharp.EmitContext ec) { }
    public override void EmitBranchable(Mono.CSharp.EmitContext ec, System.Reflection.Emit.Label target, bool on_true) { }
    public override void FlowAnalysis(Mono.CSharp.FlowAnalysisContext fc) { }
  }
  public partial class Undo {
    public Undo() { }
    public void AddTypeContainer(Mono.CSharp.TypeContainer current_container, Mono.CSharp.TypeDefinition tc) { }
    public void ExecuteUndo() { }
  }
  public partial class UnixUtils {
    public UnixUtils() { }
    public static bool isatty(int fd) { return default(bool); }
  }
  public partial class UnreachableExpression : Mono.CSharp.Expression {
    public UnreachableExpression(Mono.CSharp.Expression expr) { }
    public override Mono.CSharp.Expression CreateExpressionTree(Mono.CSharp.ResolveContext ec) { return default(Mono.CSharp.Expression); }
    protected override Mono.CSharp.Expression DoResolve(Mono.CSharp.ResolveContext rc) { return default(Mono.CSharp.Expression); }
    public override void Emit(Mono.CSharp.EmitContext ec) { }
    public override void EmitBranchable(Mono.CSharp.EmitContext ec, System.Reflection.Emit.Label target, bool on_true) { }
    public override void FlowAnalysis(Mono.CSharp.FlowAnalysisContext fc) { }
  }
  public partial class Unsafe : Mono.CSharp.Statement {
    public Mono.CSharp.Block Block;
    public Unsafe(Mono.CSharp.Block b, Mono.CSharp.Location loc) { }
    public override object Accept(Mono.CSharp.StructuralVisitor visitor) { return default(object); }
    protected override void CloneTo(Mono.CSharp.CloneContext clonectx, Mono.CSharp.Statement t) { }
    protected override void DoEmit(Mono.CSharp.EmitContext ec) { }
    protected override bool DoFlowAnalysis(Mono.CSharp.FlowAnalysisContext fc) { return default(bool); }
    public override Mono.CSharp.Reachability MarkReachable(Mono.CSharp.Reachability rc) { return default(Mono.CSharp.Reachability); }
    public override bool Resolve(Mono.CSharp.BlockContext ec) { return default(bool); }
  }
  public partial class UserCast : Mono.CSharp.Expression {
    public UserCast(Mono.CSharp.MethodSpec method, Mono.CSharp.Expression source, Mono.CSharp.Location l) { }
    public Mono.CSharp.Expression Source { get { return default(Mono.CSharp.Expression); } set { } }
    public override bool ContainsEmitWithAwait() { return default(bool); }
    public override Mono.CSharp.Expression CreateExpressionTree(Mono.CSharp.ResolveContext ec) { return default(Mono.CSharp.Expression); }
    protected override Mono.CSharp.Expression DoResolve(Mono.CSharp.ResolveContext ec) { return default(Mono.CSharp.Expression); }
    public override void Emit(Mono.CSharp.EmitContext ec) { }
    public override void FlowAnalysis(Mono.CSharp.FlowAnalysisContext fc) { }
    public override string GetSignatureForError() { return default(string); }
    public override System.Linq.Expressions.Expression MakeExpression(Mono.CSharp.BuilderContext ctx) { return default(System.Linq.Expressions.Expression); }
  }
  public partial class UserOperatorCall : Mono.CSharp.Expression {
    protected readonly Mono.CSharp.Arguments arguments;
    protected readonly Mono.CSharp.MethodSpec oper;
    public UserOperatorCall(Mono.CSharp.MethodSpec oper, Mono.CSharp.Arguments args, System.Func<Mono.CSharp.ResolveContext, Mono.CSharp.Expression, Mono.CSharp.Expression> expr_tree, Mono.CSharp.Location loc) { }
    protected override void CloneTo(Mono.CSharp.CloneContext context, Mono.CSharp.Expression target) { }
    public override bool ContainsEmitWithAwait() { return default(bool); }
    public override Mono.CSharp.Expression CreateExpressionTree(Mono.CSharp.ResolveContext ec) { return default(Mono.CSharp.Expression); }
    protected override Mono.CSharp.Expression DoResolve(Mono.CSharp.ResolveContext ec) { return default(Mono.CSharp.Expression); }
    public override void Emit(Mono.CSharp.EmitContext ec) { }
    public override void FlowAnalysis(Mono.CSharp.FlowAnalysisContext fc) { }
    public override System.Linq.Expressions.Expression MakeExpression(Mono.CSharp.BuilderContext ctx) { return default(System.Linq.Expressions.Expression); }
  }
  public partial class UShortConstant : Mono.CSharp.IntegralConstant {
    public readonly ushort Value;
    public UShortConstant(Mono.CSharp.BuiltinTypes types, ushort v, Mono.CSharp.Location loc) : base (default(Mono.CSharp.TypeSpec), default(Mono.CSharp.Location)) { }
    public UShortConstant(Mono.CSharp.TypeSpec type, ushort v, Mono.CSharp.Location loc) : base (default(Mono.CSharp.TypeSpec), default(Mono.CSharp.Location)) { }
    public override bool IsDefaultValue { get { return default(bool); } }
    public override bool IsNegative { get { return default(bool); } }
    public override bool IsOneInteger { get { return default(bool); } }
    public override bool IsZeroInteger { get { return default(bool); } }
    public override Mono.CSharp.Constant ConvertExplicitly(bool in_checked_context, Mono.CSharp.TypeSpec target_type) { return default(Mono.CSharp.Constant); }
    public override void Emit(Mono.CSharp.EmitContext ec) { }
    public override void EncodeAttributeValue(Mono.CSharp.IMemberContext rc, Mono.CSharp.AttributeEncoder enc, Mono.CSharp.TypeSpec targetType, Mono.CSharp.TypeSpec parameterType) { }
    public override object GetValue() { return default(object); }
    public override long GetValueAsLong() { return default(long); }
    public override Mono.CSharp.Constant Increment() { return default(Mono.CSharp.Constant); }
  }
  public partial class Using : Mono.CSharp.TryFinallyBlock {
    public Using(Mono.CSharp.Expression expr, Mono.CSharp.Statement stmt, Mono.CSharp.Location loc) : base (default(Mono.CSharp.Statement), default(Mono.CSharp.Location)) { }
    public Using(Mono.CSharp.Using.VariableDeclaration decl, Mono.CSharp.Statement stmt, Mono.CSharp.Location loc) : base (default(Mono.CSharp.Statement), default(Mono.CSharp.Location)) { }
    public Mono.CSharp.Expression Expr { get { return default(Mono.CSharp.Expression); } }
    public Mono.CSharp.BlockVariable Variables { get { return default(Mono.CSharp.BlockVariable); } }
    public override object Accept(Mono.CSharp.StructuralVisitor visitor) { return default(object); }
    protected override void CloneTo(Mono.CSharp.CloneContext clonectx, Mono.CSharp.Statement t) { }
    protected override bool DoFlowAnalysis(Mono.CSharp.FlowAnalysisContext fc) { return default(bool); }
    public override void Emit(Mono.CSharp.EmitContext ec) { }
    public override void EmitFinallyBody(Mono.CSharp.EmitContext ec) { }
    protected override void EmitTryBody(Mono.CSharp.EmitContext ec) { }
    protected override void EmitTryBodyPrepare(Mono.CSharp.EmitContext ec) { }
    public override Mono.CSharp.Reachability MarkReachable(Mono.CSharp.Reachability rc) { return default(Mono.CSharp.Reachability); }
    public override bool Resolve(Mono.CSharp.BlockContext ec) { return default(bool); }
    public partial class VariableDeclaration : Mono.CSharp.BlockVariable {
      public VariableDeclaration(Mono.CSharp.Expression expr) : base (default(Mono.CSharp.FullNamedExpression), default(Mono.CSharp.LocalVariable)) { }
      public VariableDeclaration(Mono.CSharp.FullNamedExpression type, Mono.CSharp.LocalVariable li) : base (default(Mono.CSharp.FullNamedExpression), default(Mono.CSharp.LocalVariable)) { }
      public VariableDeclaration(Mono.CSharp.LocalVariable li, Mono.CSharp.Location loc) : base (default(Mono.CSharp.FullNamedExpression), default(Mono.CSharp.LocalVariable)) { }
      public bool IsNested { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } }
      public override object Accept(Mono.CSharp.StructuralVisitor visitor) { return default(object); }
      protected virtual void CheckIDiposableConversion(Mono.CSharp.BlockContext bc, Mono.CSharp.LocalVariable li, Mono.CSharp.Expression initializer) { }
      protected virtual Mono.CSharp.Statement CreateDisposeCall(Mono.CSharp.BlockContext bc, Mono.CSharp.LocalVariable lv) { return default(Mono.CSharp.Statement); }
      public void EmitDispose(Mono.CSharp.EmitContext ec) { }
      public override bool Resolve(Mono.CSharp.BlockContext bc) { return default(bool); }
      public void ResolveDeclaratorInitializer(Mono.CSharp.BlockContext bc) { }
      public Mono.CSharp.Expression ResolveExpression(Mono.CSharp.BlockContext bc) { return default(Mono.CSharp.Expression); }
      protected override Mono.CSharp.Expression ResolveInitializer(Mono.CSharp.BlockContext bc, Mono.CSharp.LocalVariable li, Mono.CSharp.Expression initializer) { return default(Mono.CSharp.Expression); }
      public Mono.CSharp.Statement RewriteUsingDeclarators(Mono.CSharp.BlockContext bc, Mono.CSharp.Statement stmt) { return default(Mono.CSharp.Statement); }
    }
  }
  public partial class UsingAliasNamespace : Mono.CSharp.UsingNamespace {
    public UsingAliasNamespace(Mono.CSharp.SimpleMemberName alias, Mono.CSharp.ATypeNameExpression expr, Mono.CSharp.Location loc) : base (default(Mono.CSharp.ATypeNameExpression), default(Mono.CSharp.Location)) { }
    public override Mono.CSharp.SimpleMemberName Alias { get { return default(Mono.CSharp.SimpleMemberName); } }
    public override void Define(Mono.CSharp.NamespaceContainer ctx) { }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct AliasContext : Mono.CSharp.IMemberContext, Mono.CSharp.IModuleContext {
      public AliasContext(Mono.CSharp.NamespaceContainer ns) { throw new System.NotImplementedException(); }
      public Mono.CSharp.MemberCore CurrentMemberDefinition { get { return default(Mono.CSharp.MemberCore); } }
      public Mono.CSharp.TypeSpec CurrentType { get { return default(Mono.CSharp.TypeSpec); } }
      public Mono.CSharp.TypeParameters CurrentTypeParameters { get { return default(Mono.CSharp.TypeParameters); } }
      public bool IsObsolete { get { return default(bool); } }
      public bool IsStatic { get { return default(bool); } }
      public bool IsUnsafe { get { return default(bool); } }
      public Mono.CSharp.ModuleContainer Module { get { return default(Mono.CSharp.ModuleContainer); } }
      public string GetSignatureForError() { return default(string); }
      public Mono.CSharp.ExtensionMethodCandidates LookupExtensionMethod(Mono.CSharp.TypeSpec extensionType, string name, int arity) { return default(Mono.CSharp.ExtensionMethodCandidates); }
      public Mono.CSharp.FullNamedExpression LookupNamespaceAlias(string name) { return default(Mono.CSharp.FullNamedExpression); }
      public Mono.CSharp.FullNamedExpression LookupNamespaceOrType(string name, int arity, Mono.CSharp.LookupMode mode, Mono.CSharp.Location loc) { return default(Mono.CSharp.FullNamedExpression); }
    }
  }
  public partial class UsingExternAlias : Mono.CSharp.UsingAliasNamespace {
    public UsingExternAlias(Mono.CSharp.SimpleMemberName alias, Mono.CSharp.Location loc) : base (default(Mono.CSharp.SimpleMemberName), default(Mono.CSharp.ATypeNameExpression), default(Mono.CSharp.Location)) { }
    public override void Define(Mono.CSharp.NamespaceContainer ctx) { }
  }
  public partial class UsingNamespace {
    protected Mono.CSharp.FullNamedExpression resolved;
    public UsingNamespace(Mono.CSharp.ATypeNameExpression expr, Mono.CSharp.Location loc) { }
    public virtual Mono.CSharp.SimpleMemberName Alias { get { return default(Mono.CSharp.SimpleMemberName); } }
    public Mono.CSharp.Location Location { get { return default(Mono.CSharp.Location); } }
    public Mono.CSharp.ATypeNameExpression NamespaceExpression { get { return default(Mono.CSharp.ATypeNameExpression); } }
    public Mono.CSharp.FullNamedExpression ResolvedExpression { get { return default(Mono.CSharp.FullNamedExpression); } }
    public virtual void Define(Mono.CSharp.NamespaceContainer ctx) { }
    public string GetSignatureForError() { return default(string); }
    public override string ToString() { return default(string); }
  }
  public delegate void ValueModificationHandler(string variableName, int row, int column, object value);
  public partial class VariableInfo {
    internal VariableInfo() { }
    public bool IsParameter;
    public bool IsEverAssigned { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public static Mono.CSharp.VariableInfo Create(Mono.CSharp.BlockContext bc, Mono.CSharp.LocalVariable variable) { return default(Mono.CSharp.VariableInfo); }
    public static Mono.CSharp.VariableInfo Create(Mono.CSharp.BlockContext bc, Mono.CSharp.Parameter parameter) { return default(Mono.CSharp.VariableInfo); }
    public Mono.CSharp.VariableInfo GetStructFieldInfo(string fieldName) { return default(Mono.CSharp.VariableInfo); }
    public bool IsAssigned(Mono.CSharp.DefiniteAssignmentBitSet vector) { return default(bool); }
    public bool IsFullyInitialized(Mono.CSharp.FlowAnalysisContext fc, Mono.CSharp.Location loc) { return default(bool); }
    public bool IsStructFieldAssigned(Mono.CSharp.DefiniteAssignmentBitSet vector, string field_name) { return default(bool); }
    public void SetAssigned(Mono.CSharp.DefiniteAssignmentBitSet vector, bool generatedAssignment) { }
    public void SetStructFieldAssigned(Mono.CSharp.DefiniteAssignmentBitSet vector, string field_name) { }
    public override string ToString() { return default(string); }
  }
  public abstract partial class VariableReference : Mono.CSharp.Expression, Mono.CSharp.IAssignMethod, Mono.CSharp.IFixedExpression, Mono.CSharp.IMemoryLocation, Mono.CSharp.IVariableReference {
    protected VariableReference() { }
    public abstract bool IsFixed { get; }
    public bool IsHoisted { get { return default(bool); } }
    public abstract bool IsLockedByStatement { get; set; }
    public abstract bool IsRef { get; }
    public abstract string Name { get; }
    protected abstract Mono.CSharp.ILocalVariable Variable { get; }
    public abstract Mono.CSharp.VariableInfo VariableInfo { get; }
    public virtual void AddressOf(Mono.CSharp.EmitContext ec, Mono.CSharp.AddressOp mode) { }
    public override bool ContainsEmitWithAwait() { return default(bool); }
    public override Mono.CSharp.Expression CreateExpressionTree(Mono.CSharp.ResolveContext ec) { return default(Mono.CSharp.Expression); }
    public override Mono.CSharp.Expression DoResolveLValue(Mono.CSharp.ResolveContext rc, Mono.CSharp.Expression right_side) { return default(Mono.CSharp.Expression); }
    public override void Emit(Mono.CSharp.EmitContext ec) { }
    public void Emit(Mono.CSharp.EmitContext ec, bool leave_copy) { }
    public void EmitAssign(Mono.CSharp.EmitContext ec, Mono.CSharp.Expression source, bool leave_copy, bool prepare_for_load) { }
    public void EmitLoad(Mono.CSharp.EmitContext ec) { }
    public override void EmitSideEffect(Mono.CSharp.EmitContext ec) { }
    public override Mono.CSharp.Expression EmitToField(Mono.CSharp.EmitContext ec) { return default(Mono.CSharp.Expression); }
    public abstract Mono.CSharp.HoistedVariable GetHoistedVariable(Mono.CSharp.AnonymousExpression ae);
    public Mono.CSharp.HoistedVariable GetHoistedVariable(Mono.CSharp.EmitContext ec) { return default(Mono.CSharp.HoistedVariable); }
    public Mono.CSharp.HoistedVariable GetHoistedVariable(Mono.CSharp.ResolveContext rc) { return default(Mono.CSharp.HoistedVariable); }
    public override string GetSignatureForError() { return default(string); }
    public abstract void SetHasAddressTaken();
  }
  public enum Variance {
    Contravariant = -1,
    Covariant = 1,
    None = 0,
  }
  public partial class VarianceDecl {
    public VarianceDecl(Mono.CSharp.Variance variance, Mono.CSharp.Location loc) { }
    public Mono.CSharp.Location Location { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(Mono.CSharp.Location); } }
    public Mono.CSharp.Variance Variance { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(Mono.CSharp.Variance); } }
    public static Mono.CSharp.Variance CheckTypeVariance(Mono.CSharp.TypeSpec t, Mono.CSharp.Variance expected, Mono.CSharp.IMemberContext member) { return default(Mono.CSharp.Variance); }
  }
  public partial class WarningRegions {
    public WarningRegions() { }
    public bool IsWarningEnabled(int code, int src_line) { return default(bool); }
    public void WarningDisable(Mono.CSharp.Location location, int code, Mono.CSharp.Report Report) { }
    public void WarningDisable(int line) { }
    public void WarningEnable(Mono.CSharp.Location location, int code, Mono.CSharp.CompilerContext context) { }
    public void WarningEnable(int line) { }
  }
  public partial class While : Mono.CSharp.LoopStatement {
    public Mono.CSharp.Expression expr;
    public While(Mono.CSharp.BooleanExpression bool_expr, Mono.CSharp.Statement statement, Mono.CSharp.Location l) : base (default(Mono.CSharp.Statement)) { }
    public override object Accept(Mono.CSharp.StructuralVisitor visitor) { return default(object); }
    public override void AddEndDefiniteAssignment(Mono.CSharp.FlowAnalysisContext fc) { }
    protected override void CloneTo(Mono.CSharp.CloneContext clonectx, Mono.CSharp.Statement t) { }
    protected override void DoEmit(Mono.CSharp.EmitContext ec) { }
    protected override bool DoFlowAnalysis(Mono.CSharp.FlowAnalysisContext fc) { return default(bool); }
    public override Mono.CSharp.Reachability MarkReachable(Mono.CSharp.Reachability rc) { return default(Mono.CSharp.Reachability); }
    public override bool Resolve(Mono.CSharp.BlockContext bc) { return default(bool); }
    public override void SetEndReachable() { }
  }
  public enum XmlCommentState {
    Allowed = 0,
    Error = 2,
    NotAllowed = 1,
  }
  public partial class Yield : Mono.CSharp.YieldStatement<Mono.CSharp.Iterator> {
    public Yield(Mono.CSharp.Expression expr, Mono.CSharp.Location loc) : base (default(Mono.CSharp.Expression), default(Mono.CSharp.Location)) { }
    public override object Accept(Mono.CSharp.StructuralVisitor visitor) { return default(object); }
    public static bool CheckContext(Mono.CSharp.BlockContext bc, Mono.CSharp.Location loc) { return default(bool); }
    public override bool Resolve(Mono.CSharp.BlockContext bc) { return default(bool); }
  }
  public partial class YieldBreak : Mono.CSharp.ExitStatement {
    public YieldBreak(Mono.CSharp.Location l) { }
    protected override bool IsLocalExit { get { return default(bool); } }
    public override object Accept(Mono.CSharp.StructuralVisitor visitor) { return default(object); }
    protected override void CloneTo(Mono.CSharp.CloneContext clonectx, Mono.CSharp.Statement target) { }
    protected override void DoEmit(Mono.CSharp.EmitContext ec) { }
    protected override bool DoFlowAnalysis(Mono.CSharp.FlowAnalysisContext fc) { return default(bool); }
    protected override bool DoResolve(Mono.CSharp.BlockContext bc) { return default(bool); }
    public override Mono.CSharp.Reachability MarkReachable(Mono.CSharp.Reachability rc) { return default(Mono.CSharp.Reachability); }
  }
  public abstract partial class YieldStatement<T> : Mono.CSharp.ResumableStatement where T : Mono.CSharp.StateMachineInitializer {
    protected Mono.CSharp.Expression expr;
    protected T machine_initializer;
    protected bool unwind_protect;
    protected YieldStatement(Mono.CSharp.Expression expr, Mono.CSharp.Location l) { }
    public Mono.CSharp.Expression Expr { get { return default(Mono.CSharp.Expression); } }
    protected override void CloneTo(Mono.CSharp.CloneContext clonectx, Mono.CSharp.Statement t) { }
    protected override void DoEmit(Mono.CSharp.EmitContext ec) { }
    protected override bool DoFlowAnalysis(Mono.CSharp.FlowAnalysisContext fc) { return default(bool); }
    public void RegisterResumePoint() { }
    public override bool Resolve(Mono.CSharp.BlockContext bc) { return default(bool); }
  }
}
namespace Mono.CSharp.Linq {
  public abstract partial class AQueryClause : Mono.CSharp.ShimExpression {
    public Mono.CSharp.Linq.QueryBlock block;
    public Mono.CSharp.Linq.AQueryClause next;
    protected AQueryClause(Mono.CSharp.Linq.QueryBlock block, Mono.CSharp.Expression expr, Mono.CSharp.Location loc) : base (default(Mono.CSharp.Expression)) { }
    protected abstract string MethodName { get; }
    public Mono.CSharp.Linq.AQueryClause Next { set { } }
    public Mono.CSharp.Linq.AQueryClause Tail { get { return default(Mono.CSharp.Linq.AQueryClause); } }
    public virtual Mono.CSharp.Expression BuildQueryClause(Mono.CSharp.ResolveContext ec, Mono.CSharp.Expression lSide, Mono.CSharp.Parameter parameter) { return default(Mono.CSharp.Expression); }
    protected override void CloneTo(Mono.CSharp.CloneContext clonectx, Mono.CSharp.Expression target) { }
    protected virtual void CreateArguments(Mono.CSharp.ResolveContext ec, Mono.CSharp.Parameter parameter, ref Mono.CSharp.Arguments args) { }
    protected virtual Mono.CSharp.Parameter CreateChildrenParameters(Mono.CSharp.Parameter parameter) { return default(Mono.CSharp.Parameter); }
    protected Mono.CSharp.Invocation CreateQueryExpression(Mono.CSharp.Expression lSide, Mono.CSharp.Arguments arguments) { return default(Mono.CSharp.Invocation); }
    protected override Mono.CSharp.Expression DoResolve(Mono.CSharp.ResolveContext ec) { return default(Mono.CSharp.Expression); }
    protected partial class QueryExpressionAccess : Mono.CSharp.MemberAccess {
      public QueryExpressionAccess(Mono.CSharp.Expression expr, string methodName, Mono.CSharp.Location loc) : base (default(Mono.CSharp.Expression), default(string)) { }
      public QueryExpressionAccess(Mono.CSharp.Expression expr, string methodName, Mono.CSharp.TypeArguments typeArguments, Mono.CSharp.Location loc) : base (default(Mono.CSharp.Expression), default(string)) { }
      protected override void Error_TypeDoesNotContainDefinition(Mono.CSharp.ResolveContext ec, Mono.CSharp.TypeSpec type, string name) { }
    }
    protected partial class QueryExpressionInvocation : Mono.CSharp.Invocation, Mono.CSharp.OverloadResolver.IErrorHandler {
      public QueryExpressionInvocation(Mono.CSharp.Linq.AQueryClause.QueryExpressionAccess expr, Mono.CSharp.Arguments arguments) : base (default(Mono.CSharp.Expression), default(Mono.CSharp.Arguments)) { }
      protected override Mono.CSharp.Expression DoResolveDynamic(Mono.CSharp.ResolveContext ec, Mono.CSharp.Expression memberExpr) { return default(Mono.CSharp.Expression); }
      protected override Mono.CSharp.MethodGroupExpr DoResolveOverload(Mono.CSharp.ResolveContext ec) { return default(Mono.CSharp.MethodGroupExpr); }
      bool Mono.CSharp.OverloadResolver.IErrorHandler.AmbiguousCandidates(Mono.CSharp.ResolveContext ec, Mono.CSharp.MemberSpec best, Mono.CSharp.MemberSpec ambiguous) { return default(bool); }
      bool Mono.CSharp.OverloadResolver.IErrorHandler.ArgumentMismatch(Mono.CSharp.ResolveContext rc, Mono.CSharp.MemberSpec best, Mono.CSharp.Argument arg, int index) { return default(bool); }
      bool Mono.CSharp.OverloadResolver.IErrorHandler.NoArgumentMatch(Mono.CSharp.ResolveContext rc, Mono.CSharp.MemberSpec best) { return default(bool); }
      bool Mono.CSharp.OverloadResolver.IErrorHandler.TypeInferenceFailed(Mono.CSharp.ResolveContext rc, Mono.CSharp.MemberSpec best) { return default(bool); }
    }
  }
  public abstract partial class ARangeVariableQueryClause : Mono.CSharp.Linq.AQueryClause {
    protected Mono.CSharp.Linq.RangeVariable identifier;
    protected ARangeVariableQueryClause(Mono.CSharp.Linq.QueryBlock block, Mono.CSharp.Linq.RangeVariable identifier, Mono.CSharp.Expression expr, Mono.CSharp.Location loc) : base (default(Mono.CSharp.Linq.QueryBlock), default(Mono.CSharp.Expression), default(Mono.CSharp.Location)) { }
    public Mono.CSharp.Linq.RangeVariable Identifier { get { return default(Mono.CSharp.Linq.RangeVariable); } }
    public Mono.CSharp.FullNamedExpression IdentifierType { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(Mono.CSharp.FullNamedExpression); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    protected Mono.CSharp.Invocation CreateCastExpression(Mono.CSharp.Expression lSide) { return default(Mono.CSharp.Invocation); }
    protected override Mono.CSharp.Parameter CreateChildrenParameters(Mono.CSharp.Parameter parameter) { return default(Mono.CSharp.Parameter); }
    protected static Mono.CSharp.Expression CreateRangeVariableType(Mono.CSharp.ResolveContext rc, Mono.CSharp.Parameter parameter, Mono.CSharp.Linq.RangeVariable name, Mono.CSharp.Expression init) { return default(Mono.CSharp.Expression); }
    protected virtual Mono.CSharp.Linq.RangeVariable GetIntoVariable() { return default(Mono.CSharp.Linq.RangeVariable); }
  }
  public partial class GroupBy : Mono.CSharp.Linq.AQueryClause {
    public GroupBy(Mono.CSharp.Linq.QueryBlock block, Mono.CSharp.Expression elementSelector, Mono.CSharp.Linq.QueryBlock elementBlock, Mono.CSharp.Expression keySelector, Mono.CSharp.Location loc) : base (default(Mono.CSharp.Linq.QueryBlock), default(Mono.CSharp.Expression), default(Mono.CSharp.Location)) { }
    protected override string MethodName { get { return default(string); } }
    public Mono.CSharp.Expression SelectorExpression { get { return default(Mono.CSharp.Expression); } }
    public override object Accept(Mono.CSharp.StructuralVisitor visitor) { return default(object); }
    protected override void CloneTo(Mono.CSharp.CloneContext clonectx, Mono.CSharp.Expression target) { }
    protected override void CreateArguments(Mono.CSharp.ResolveContext ec, Mono.CSharp.Parameter parameter, ref Mono.CSharp.Arguments args) { }
  }
  public partial class GroupJoin : Mono.CSharp.Linq.Join {
    public GroupJoin(Mono.CSharp.Linq.QueryBlock block, Mono.CSharp.Linq.RangeVariable lt, Mono.CSharp.Expression inner, Mono.CSharp.Linq.QueryBlock outerSelector, Mono.CSharp.Linq.QueryBlock innerSelector, Mono.CSharp.Linq.RangeVariable into, Mono.CSharp.Location loc) : base (default(Mono.CSharp.Linq.QueryBlock), default(Mono.CSharp.Linq.RangeVariable), default(Mono.CSharp.Expression), default(Mono.CSharp.Linq.QueryBlock), default(Mono.CSharp.Linq.QueryBlock), default(Mono.CSharp.Location)) { }
    protected override string MethodName { get { return default(string); } }
    public override object Accept(Mono.CSharp.StructuralVisitor visitor) { return default(object); }
    protected override Mono.CSharp.Linq.RangeVariable GetIntoVariable() { return default(Mono.CSharp.Linq.RangeVariable); }
  }
  public partial class Join : Mono.CSharp.Linq.SelectMany {
    public Join(Mono.CSharp.Linq.QueryBlock block, Mono.CSharp.Linq.RangeVariable lt, Mono.CSharp.Expression inner, Mono.CSharp.Linq.QueryBlock outerSelector, Mono.CSharp.Linq.QueryBlock innerSelector, Mono.CSharp.Location loc) : base (default(Mono.CSharp.Linq.QueryBlock), default(Mono.CSharp.Linq.RangeVariable), default(Mono.CSharp.Expression), default(Mono.CSharp.Location)) { }
    public Mono.CSharp.Linq.QueryBlock InnerSelector { get { return default(Mono.CSharp.Linq.QueryBlock); } }
    protected override string MethodName { get { return default(string); } }
    public Mono.CSharp.Linq.QueryBlock OuterSelector { get { return default(Mono.CSharp.Linq.QueryBlock); } }
    public override object Accept(Mono.CSharp.StructuralVisitor visitor) { return default(object); }
    protected override void CloneTo(Mono.CSharp.CloneContext clonectx, Mono.CSharp.Expression target) { }
    protected override void CreateArguments(Mono.CSharp.ResolveContext ec, Mono.CSharp.Parameter parameter, ref Mono.CSharp.Arguments args) { }
  }
  public partial class Let : Mono.CSharp.Linq.ARangeVariableQueryClause {
    public Let(Mono.CSharp.Linq.QueryBlock block, Mono.CSharp.Linq.RangeVariable identifier, Mono.CSharp.Expression expr, Mono.CSharp.Location loc) : base (default(Mono.CSharp.Linq.QueryBlock), default(Mono.CSharp.Linq.RangeVariable), default(Mono.CSharp.Expression), default(Mono.CSharp.Location)) { }
    protected override string MethodName { get { return default(string); } }
    public override object Accept(Mono.CSharp.StructuralVisitor visitor) { return default(object); }
    protected override void CreateArguments(Mono.CSharp.ResolveContext ec, Mono.CSharp.Parameter parameter, ref Mono.CSharp.Arguments args) { }
  }
  public partial class OrderByAscending : Mono.CSharp.Linq.AQueryClause {
    public OrderByAscending(Mono.CSharp.Linq.QueryBlock block, Mono.CSharp.Expression expr) : base (default(Mono.CSharp.Linq.QueryBlock), default(Mono.CSharp.Expression), default(Mono.CSharp.Location)) { }
    protected override string MethodName { get { return default(string); } }
    public override object Accept(Mono.CSharp.StructuralVisitor visitor) { return default(object); }
  }
  public partial class OrderByDescending : Mono.CSharp.Linq.AQueryClause {
    public OrderByDescending(Mono.CSharp.Linq.QueryBlock block, Mono.CSharp.Expression expr) : base (default(Mono.CSharp.Linq.QueryBlock), default(Mono.CSharp.Expression), default(Mono.CSharp.Location)) { }
    protected override string MethodName { get { return default(string); } }
    public override object Accept(Mono.CSharp.StructuralVisitor visitor) { return default(object); }
  }
  public partial class QueryBlock : Mono.CSharp.ParametersBlock {
    public QueryBlock(Mono.CSharp.Block parent, Mono.CSharp.Location start) : base (default(Mono.CSharp.Block), default(Mono.CSharp.ParametersCompiled), default(Mono.CSharp.Location), default(Mono.CSharp.Block.Flags)) { }
    public void AddRangeVariable(Mono.CSharp.Linq.RangeVariable variable) { }
    public override void Error_AlreadyDeclared(string name, Mono.CSharp.INamedBlockVariable variable) { }
    public override void Error_AlreadyDeclared(string name, Mono.CSharp.INamedBlockVariable variable, string reason) { }
    public override void Error_AlreadyDeclaredTypeParameter(string name, Mono.CSharp.Location loc) { }
    public void SetParameter(Mono.CSharp.Parameter parameter) { }
    public void SetParameters(Mono.CSharp.Parameter first, Mono.CSharp.Parameter second) { }
    public sealed partial class TransparentParameter : Mono.CSharp.ImplicitLambdaParameter {
      public static int Counter;
      public readonly string Identifier;
      public readonly Mono.CSharp.Parameter Parent;
      public TransparentParameter(Mono.CSharp.Parameter parent, Mono.CSharp.Linq.RangeVariable identifier) : base (default(string), default(Mono.CSharp.Location)) { }
      public static void Reset() { }
    }
  }
  public partial class QueryExpression : Mono.CSharp.Linq.AQueryClause {
    public QueryExpression(Mono.CSharp.Linq.AQueryClause start) : base (default(Mono.CSharp.Linq.QueryBlock), default(Mono.CSharp.Expression), default(Mono.CSharp.Location)) { }
    protected override string MethodName { get { return default(string); } }
    public override Mono.CSharp.Expression BuildQueryClause(Mono.CSharp.ResolveContext ec, Mono.CSharp.Expression lSide, Mono.CSharp.Parameter parentParameter) { return default(Mono.CSharp.Expression); }
    protected override Mono.CSharp.Expression DoResolve(Mono.CSharp.ResolveContext ec) { return default(Mono.CSharp.Expression); }
  }
  public partial class QueryStartClause : Mono.CSharp.Linq.ARangeVariableQueryClause {
    public QueryStartClause(Mono.CSharp.Linq.QueryBlock block, Mono.CSharp.Expression expr, Mono.CSharp.Linq.RangeVariable identifier, Mono.CSharp.Location loc) : base (default(Mono.CSharp.Linq.QueryBlock), default(Mono.CSharp.Linq.RangeVariable), default(Mono.CSharp.Expression), default(Mono.CSharp.Location)) { }
    protected override string MethodName { get { return default(string); } }
    public override Mono.CSharp.Expression BuildQueryClause(Mono.CSharp.ResolveContext ec, Mono.CSharp.Expression lSide, Mono.CSharp.Parameter parameter) { return default(Mono.CSharp.Expression); }
    protected override Mono.CSharp.Expression DoResolve(Mono.CSharp.ResolveContext ec) { return default(Mono.CSharp.Expression); }
  }
  public sealed partial class RangeVariable : Mono.CSharp.INamedBlockVariable {
    public RangeVariable(string name, Mono.CSharp.Location loc) { }
    public Mono.CSharp.Block Block { get { return default(Mono.CSharp.Block); } set { } }
    public bool IsDeclared { get { return default(bool); } }
    public bool IsParameter { get { return default(bool); } }
    public Mono.CSharp.Location Location { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(Mono.CSharp.Location); } }
    public string Name { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
    public Mono.CSharp.Expression CreateReferenceExpression(Mono.CSharp.ResolveContext rc, Mono.CSharp.Location loc) { return default(Mono.CSharp.Expression); }
  }
  public partial class Select : Mono.CSharp.Linq.AQueryClause {
    public Select(Mono.CSharp.Linq.QueryBlock block, Mono.CSharp.Expression expr, Mono.CSharp.Location loc) : base (default(Mono.CSharp.Linq.QueryBlock), default(Mono.CSharp.Expression), default(Mono.CSharp.Location)) { }
    protected override string MethodName { get { return default(string); } }
    public override object Accept(Mono.CSharp.StructuralVisitor visitor) { return default(object); }
    public bool IsRequired(Mono.CSharp.Parameter parameter) { return default(bool); }
  }
  public partial class SelectMany : Mono.CSharp.Linq.ARangeVariableQueryClause {
    public SelectMany(Mono.CSharp.Linq.QueryBlock block, Mono.CSharp.Linq.RangeVariable identifier, Mono.CSharp.Expression expr, Mono.CSharp.Location loc) : base (default(Mono.CSharp.Linq.QueryBlock), default(Mono.CSharp.Linq.RangeVariable), default(Mono.CSharp.Expression), default(Mono.CSharp.Location)) { }
    protected override string MethodName { get { return default(string); } }
    public override object Accept(Mono.CSharp.StructuralVisitor visitor) { return default(object); }
    protected override void CreateArguments(Mono.CSharp.ResolveContext ec, Mono.CSharp.Parameter parameter, ref Mono.CSharp.Arguments args) { }
  }
  public partial class ThenByAscending : Mono.CSharp.Linq.OrderByAscending {
    public ThenByAscending(Mono.CSharp.Linq.QueryBlock block, Mono.CSharp.Expression expr) : base (default(Mono.CSharp.Linq.QueryBlock), default(Mono.CSharp.Expression)) { }
    protected override string MethodName { get { return default(string); } }
    public override object Accept(Mono.CSharp.StructuralVisitor visitor) { return default(object); }
  }
  public partial class ThenByDescending : Mono.CSharp.Linq.OrderByDescending {
    public ThenByDescending(Mono.CSharp.Linq.QueryBlock block, Mono.CSharp.Expression expr) : base (default(Mono.CSharp.Linq.QueryBlock), default(Mono.CSharp.Expression)) { }
    protected override string MethodName { get { return default(string); } }
    public override object Accept(Mono.CSharp.StructuralVisitor visitor) { return default(object); }
  }
  public partial class Where : Mono.CSharp.Linq.AQueryClause {
    public Where(Mono.CSharp.Linq.QueryBlock block, Mono.CSharp.Expression expr, Mono.CSharp.Location loc) : base (default(Mono.CSharp.Linq.QueryBlock), default(Mono.CSharp.Expression), default(Mono.CSharp.Location)) { }
    protected override string MethodName { get { return default(string); } }
    public override object Accept(Mono.CSharp.StructuralVisitor visitor) { return default(object); }
  }
}
namespace Mono.CSharp.Nullable {
  public partial class LiftedConversion : Mono.CSharp.Expression, Mono.CSharp.IMemoryLocation {
    public LiftedConversion(Mono.CSharp.Expression expr, Mono.CSharp.Expression unwrap, Mono.CSharp.TypeSpec type) { }
    public LiftedConversion(Mono.CSharp.Expression expr, Mono.CSharp.Nullable.Unwrap unwrap, Mono.CSharp.TypeSpec type) { }
    public override bool IsNull { get { return default(bool); } }
    public void AddressOf(Mono.CSharp.EmitContext ec, Mono.CSharp.AddressOp mode) { }
    public override bool ContainsEmitWithAwait() { return default(bool); }
    public override Mono.CSharp.Expression CreateExpressionTree(Mono.CSharp.ResolveContext ec) { return default(Mono.CSharp.Expression); }
    protected override Mono.CSharp.Expression DoResolve(Mono.CSharp.ResolveContext ec) { return default(Mono.CSharp.Expression); }
    public override void Emit(Mono.CSharp.EmitContext ec) { }
    public override void FlowAnalysis(Mono.CSharp.FlowAnalysisContext fc) { }
  }
  public partial class LiftedNull : Mono.CSharp.NullConstant, Mono.CSharp.IMemoryLocation {
    internal LiftedNull() : base (default(Mono.CSharp.TypeSpec), default(Mono.CSharp.Location)) { }
    public void AddressOf(Mono.CSharp.EmitContext ec, Mono.CSharp.AddressOp Mode) { }
    public static Mono.CSharp.Constant Create(Mono.CSharp.TypeSpec nullable, Mono.CSharp.Location loc) { return default(Mono.CSharp.Constant); }
    public static Mono.CSharp.Constant CreateFromExpression(Mono.CSharp.ResolveContext rc, Mono.CSharp.Expression e) { return default(Mono.CSharp.Constant); }
    public override void Emit(Mono.CSharp.EmitContext ec) { }
  }
  public partial class LiftedUnaryOperator : Mono.CSharp.Unary, Mono.CSharp.IMemoryLocation {
    public LiftedUnaryOperator(Mono.CSharp.Unary.Operator op, Mono.CSharp.Expression expr, Mono.CSharp.Location loc) : base (default(Mono.CSharp.Unary.Operator), default(Mono.CSharp.Expression), default(Mono.CSharp.Location)) { }
    public void AddressOf(Mono.CSharp.EmitContext ec, Mono.CSharp.AddressOp mode) { }
    public override Mono.CSharp.Expression CreateExpressionTree(Mono.CSharp.ResolveContext ec) { return default(Mono.CSharp.Expression); }
    protected override Mono.CSharp.Expression DoResolve(Mono.CSharp.ResolveContext ec) { return default(Mono.CSharp.Expression); }
    public override void Emit(Mono.CSharp.EmitContext ec) { }
    protected override Mono.CSharp.Expression ResolveEnumOperator(Mono.CSharp.ResolveContext ec, Mono.CSharp.Expression expr, Mono.CSharp.TypeSpec[] predefined) { return default(Mono.CSharp.Expression); }
    protected override Mono.CSharp.Expression ResolveUserOperator(Mono.CSharp.ResolveContext ec, Mono.CSharp.Expression expr) { return default(Mono.CSharp.Expression); }
  }
  public partial class NullableType : Mono.CSharp.TypeExpr {
    public NullableType(Mono.CSharp.TypeSpec type, Mono.CSharp.Location loc) { }
    public override Mono.CSharp.TypeSpec ResolveAsType(Mono.CSharp.IMemberContext ec, bool allowUnboundTypeArguments=false) { return default(Mono.CSharp.TypeSpec); }
  }
  public partial class NullCoalescingOperator : Mono.CSharp.Expression {
    public NullCoalescingOperator(Mono.CSharp.Expression left, Mono.CSharp.Expression right) { }
    public Mono.CSharp.Expression LeftExpression { get { return default(Mono.CSharp.Expression); } }
    public Mono.CSharp.Expression RightExpression { get { return default(Mono.CSharp.Expression); } }
    public override object Accept(Mono.CSharp.StructuralVisitor visitor) { return default(object); }
    protected override void CloneTo(Mono.CSharp.CloneContext clonectx, Mono.CSharp.Expression t) { }
    public override bool ContainsEmitWithAwait() { return default(bool); }
    public override Mono.CSharp.Expression CreateExpressionTree(Mono.CSharp.ResolveContext ec) { return default(Mono.CSharp.Expression); }
    protected override Mono.CSharp.Expression DoResolve(Mono.CSharp.ResolveContext ec) { return default(Mono.CSharp.Expression); }
    public override void Emit(Mono.CSharp.EmitContext ec) { }
    public override void FlowAnalysis(Mono.CSharp.FlowAnalysisContext fc) { }
  }
  public partial class Unwrap : Mono.CSharp.Expression, Mono.CSharp.IMemoryLocation {
    public Unwrap(Mono.CSharp.Expression expr, bool useDefaultValue=true) { }
    public override bool IsNull { get { return default(bool); } }
    public Mono.CSharp.Expression Original { get { return default(Mono.CSharp.Expression); } }
    public void AddressOf(Mono.CSharp.EmitContext ec, Mono.CSharp.AddressOp mode) { }
    public override bool ContainsEmitWithAwait() { return default(bool); }
    public static Mono.CSharp.Expression Create(Mono.CSharp.Expression expr) { return default(Mono.CSharp.Expression); }
    public static Mono.CSharp.Nullable.Unwrap Create(Mono.CSharp.Expression expr, bool useDefaultValue) { return default(Mono.CSharp.Nullable.Unwrap); }
    public override Mono.CSharp.Expression CreateExpressionTree(Mono.CSharp.ResolveContext ec) { return default(Mono.CSharp.Expression); }
    public static Mono.CSharp.Expression CreateUnwrapped(Mono.CSharp.Expression expr) { return default(Mono.CSharp.Expression); }
    protected override Mono.CSharp.Expression DoResolve(Mono.CSharp.ResolveContext ec) { return default(Mono.CSharp.Expression); }
    public override Mono.CSharp.Expression DoResolveLValue(Mono.CSharp.ResolveContext ec, Mono.CSharp.Expression right_side) { return default(Mono.CSharp.Expression); }
    public override void Emit(Mono.CSharp.EmitContext ec) { }
    public void EmitCheck(Mono.CSharp.EmitContext ec) { }
    public override void EmitSideEffect(Mono.CSharp.EmitContext ec) { }
    public override Mono.CSharp.Expression EmitToField(Mono.CSharp.EmitContext ec) { return default(Mono.CSharp.Expression); }
    public override bool Equals(object obj) { return default(bool); }
    public override void FlowAnalysis(Mono.CSharp.FlowAnalysisContext fc) { }
    public override int GetHashCode() { return default(int); }
    public void Load(Mono.CSharp.EmitContext ec) { }
    public override System.Linq.Expressions.Expression MakeExpression(Mono.CSharp.BuilderContext ctx) { return default(System.Linq.Expressions.Expression); }
    public void Store(Mono.CSharp.EmitContext ec) { }
  }
  public partial class UnwrapCall : Mono.CSharp.CompositeExpression {
    public UnwrapCall(Mono.CSharp.Expression expr) : base (default(Mono.CSharp.Expression)) { }
    protected override Mono.CSharp.Expression DoResolve(Mono.CSharp.ResolveContext rc) { return default(Mono.CSharp.Expression); }
    public override void Emit(Mono.CSharp.EmitContext ec) { }
  }
  public partial class Wrap : Mono.CSharp.TypeCast {
    internal Wrap() : base (default(Mono.CSharp.Expression), default(Mono.CSharp.TypeSpec)) { }
    public static Mono.CSharp.Expression Create(Mono.CSharp.Expression expr, Mono.CSharp.TypeSpec type) { return default(Mono.CSharp.Expression); }
    public override Mono.CSharp.Expression CreateExpressionTree(Mono.CSharp.ResolveContext ec) { return default(Mono.CSharp.Expression); }
    public override void Emit(Mono.CSharp.EmitContext ec) { }
  }
}
namespace Mono.Security.Cryptography {
  public sealed partial class CryptoConvert {
    internal CryptoConvert() { }
    public static System.Security.Cryptography.RSA FromCapiKeyBlob(System.Byte[] blob) { return default(System.Security.Cryptography.RSA); }
    public static System.Security.Cryptography.RSA FromCapiKeyBlob(System.Byte[] blob, int offset) { return default(System.Security.Cryptography.RSA); }
    public static System.Security.Cryptography.DSA FromCapiKeyBlobDSA(System.Byte[] blob) { return default(System.Security.Cryptography.DSA); }
    public static System.Security.Cryptography.DSA FromCapiKeyBlobDSA(System.Byte[] blob, int offset) { return default(System.Security.Cryptography.DSA); }
    public static System.Security.Cryptography.RSA FromCapiPrivateKeyBlob(System.Byte[] blob) { return default(System.Security.Cryptography.RSA); }
    public static System.Security.Cryptography.RSA FromCapiPrivateKeyBlob(System.Byte[] blob, int offset) { return default(System.Security.Cryptography.RSA); }
    public static System.Security.Cryptography.DSA FromCapiPrivateKeyBlobDSA(System.Byte[] blob) { return default(System.Security.Cryptography.DSA); }
    public static System.Security.Cryptography.DSA FromCapiPrivateKeyBlobDSA(System.Byte[] blob, int offset) { return default(System.Security.Cryptography.DSA); }
    public static System.Security.Cryptography.RSA FromCapiPublicKeyBlob(System.Byte[] blob) { return default(System.Security.Cryptography.RSA); }
    public static System.Security.Cryptography.RSA FromCapiPublicKeyBlob(System.Byte[] blob, int offset) { return default(System.Security.Cryptography.RSA); }
    public static System.Security.Cryptography.DSA FromCapiPublicKeyBlobDSA(System.Byte[] blob) { return default(System.Security.Cryptography.DSA); }
    public static System.Security.Cryptography.DSA FromCapiPublicKeyBlobDSA(System.Byte[] blob, int offset) { return default(System.Security.Cryptography.DSA); }
    public static System.Byte[] FromHex(string hex) { return default(System.Byte[]); }
    public static System.Byte[] ToCapiKeyBlob(System.Security.Cryptography.AsymmetricAlgorithm keypair, bool includePrivateKey) { return default(System.Byte[]); }
    public static System.Byte[] ToCapiKeyBlob(System.Security.Cryptography.DSA dsa, bool includePrivateKey) { return default(System.Byte[]); }
    public static System.Byte[] ToCapiKeyBlob(System.Security.Cryptography.RSA rsa, bool includePrivateKey) { return default(System.Byte[]); }
    public static System.Byte[] ToCapiPrivateKeyBlob(System.Security.Cryptography.DSA dsa) { return default(System.Byte[]); }
    public static System.Byte[] ToCapiPrivateKeyBlob(System.Security.Cryptography.RSA rsa) { return default(System.Byte[]); }
    public static System.Byte[] ToCapiPublicKeyBlob(System.Security.Cryptography.DSA dsa) { return default(System.Byte[]); }
    public static System.Byte[] ToCapiPublicKeyBlob(System.Security.Cryptography.RSA rsa) { return default(System.Byte[]); }
    public static string ToHex(System.Byte[] input) { return default(string); }
  }
}
