namespace Microsoft.JScript {
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public abstract partial class ActivationObject : Microsoft.JScript.ScriptObject, Microsoft.JScript.IActivationObject {
    internal ActivationObject() { }
    protected System.Collections.ArrayList field_table;
    protected virtual Microsoft.JScript.JSVariableField CreateField(string name, System.Reflection.FieldAttributes attributeFlags, object value) { return default(Microsoft.JScript.JSVariableField); }
    public virtual object GetDefaultThisObject() { return default(object); }
    public virtual System.Reflection.FieldInfo GetField(string name, int lexLevel) { return default(System.Reflection.FieldInfo); }
    public virtual Microsoft.JScript.GlobalScope GetGlobalScope() { return default(Microsoft.JScript.GlobalScope); }
    public virtual System.Reflection.FieldInfo GetLocalField(string name) { return default(System.Reflection.FieldInfo); }
    public override System.Reflection.MemberInfo[] GetMember(string name, System.Reflection.BindingFlags bindingAttr) { return default(System.Reflection.MemberInfo[]); }
    public override System.Reflection.MemberInfo[] GetMembers(System.Reflection.BindingFlags bindingAttr) { return default(System.Reflection.MemberInfo[]); }
    [System.Diagnostics.DebuggerHiddenAttribute]
    [System.Diagnostics.DebuggerStepThroughAttribute]
    public object GetMemberValue(string name, int lexlevel) { return default(object); }
  }
  public sealed partial class ActiveXObjectConstructor : Microsoft.JScript.ScriptFunction {
    internal ActiveXObjectConstructor() : base (default(Microsoft.JScript.ScriptObject), default(string)) { }
    [Microsoft.JScript.JSFunctionAttribute((Microsoft.JScript.JSFunctionAttributeEnum)(16))]
    public new object CreateInstance(params System.Object[] args) { return default(object); }
    public object Invoke() { return default(object); }
  }
  public sealed partial class ArgumentsObject : Microsoft.JScript.JSObject {
    internal ArgumentsObject() { }
    public object callee;
    public object caller;
    public object length;
  }
  public sealed partial class ArrayConstructor : Microsoft.JScript.ScriptFunction {
    internal ArrayConstructor() : base (default(Microsoft.JScript.ScriptObject), default(string)) { }
    public Microsoft.JScript.ArrayObject ConstructArray(System.Object[] args) { return default(Microsoft.JScript.ArrayObject); }
    [Microsoft.JScript.JSFunctionAttribute((Microsoft.JScript.JSFunctionAttributeEnum)(16))]
    public new Microsoft.JScript.ArrayObject CreateInstance(params System.Object[] args) { return default(Microsoft.JScript.ArrayObject); }
    [Microsoft.JScript.JSFunctionAttribute((Microsoft.JScript.JSFunctionAttributeEnum)(16))]
    public Microsoft.JScript.ArrayObject Invoke(params System.Object[] args) { return default(Microsoft.JScript.ArrayObject); }
  }
  public sealed partial class ArrayLiteral : Microsoft.JScript.AST {
    public ArrayLiteral(Microsoft.JScript.Context context, Microsoft.JScript.ASTList elements) { }
  }
  public partial class ArrayObject : Microsoft.JScript.JSObject {
    internal ArrayObject() { }
    public virtual object length { get { return default(object); } set { } }
    protected void SpliceSlowly(uint start, uint deleteCount, System.Object[] args, Microsoft.JScript.ArrayObject outArray, uint oldLength, uint newLength) { }
  }
  public partial class ArrayPrototype : Microsoft.JScript.ArrayObject {
    internal ArrayPrototype() { }
    public static Microsoft.JScript.ArrayConstructor constructor { get { return default(Microsoft.JScript.ArrayConstructor); } }
    [Microsoft.JScript.JSFunctionAttribute((Microsoft.JScript.JSFunctionAttributeEnum)(50), (Microsoft.JScript.JSBuiltin)(1))]
    public static Microsoft.JScript.ArrayObject concat(object thisob, Microsoft.JScript.Vsa.VsaEngine engine, params System.Object[] args) { return default(Microsoft.JScript.ArrayObject); }
    [Microsoft.JScript.JSFunctionAttribute((Microsoft.JScript.JSFunctionAttributeEnum)(2), (Microsoft.JScript.JSBuiltin)(2))]
    public static string join(object thisob, object separator) { return default(string); }
    [Microsoft.JScript.JSFunctionAttribute((Microsoft.JScript.JSFunctionAttributeEnum)(2), (Microsoft.JScript.JSBuiltin)(3))]
    public static object pop(object thisob) { return default(object); }
    [Microsoft.JScript.JSFunctionAttribute((Microsoft.JScript.JSFunctionAttributeEnum)(18), (Microsoft.JScript.JSBuiltin)(4))]
    public static long push(object thisob, params System.Object[] args) { return default(long); }
    [Microsoft.JScript.JSFunctionAttribute((Microsoft.JScript.JSFunctionAttributeEnum)(2), (Microsoft.JScript.JSBuiltin)(5))]
    public static object reverse(object thisob) { return default(object); }
    [Microsoft.JScript.JSFunctionAttribute((Microsoft.JScript.JSFunctionAttributeEnum)(2), (Microsoft.JScript.JSBuiltin)(6))]
    public static object shift(object thisob) { return default(object); }
    [Microsoft.JScript.JSFunctionAttribute((Microsoft.JScript.JSFunctionAttributeEnum)(34), (Microsoft.JScript.JSBuiltin)(7))]
    public static Microsoft.JScript.ArrayObject slice(object thisob, Microsoft.JScript.Vsa.VsaEngine engine, double start, object end) { return default(Microsoft.JScript.ArrayObject); }
    [Microsoft.JScript.JSFunctionAttribute((Microsoft.JScript.JSFunctionAttributeEnum)(2), (Microsoft.JScript.JSBuiltin)(8))]
    public static object sort(object thisob, object function) { return default(object); }
    [Microsoft.JScript.JSFunctionAttribute((Microsoft.JScript.JSFunctionAttributeEnum)(50), (Microsoft.JScript.JSBuiltin)(9))]
    public static Microsoft.JScript.ArrayObject splice(object thisob, Microsoft.JScript.Vsa.VsaEngine engine, double start, double deleteCnt, params System.Object[] args) { return default(Microsoft.JScript.ArrayObject); }
    [Microsoft.JScript.JSFunctionAttribute((Microsoft.JScript.JSFunctionAttributeEnum)(2), (Microsoft.JScript.JSBuiltin)(10))]
    public static string toLocaleString(object thisob) { return default(string); }
    [Microsoft.JScript.JSFunctionAttribute((Microsoft.JScript.JSFunctionAttributeEnum)(2), (Microsoft.JScript.JSBuiltin)(11))]
    public static string toString(object thisob) { return default(string); }
    [Microsoft.JScript.JSFunctionAttribute((Microsoft.JScript.JSFunctionAttributeEnum)(18), (Microsoft.JScript.JSBuiltin)(12))]
    public static object unshift(object thisob, params System.Object[] args) { return default(object); }
  }
  public partial class ArrayWrapper : Microsoft.JScript.ArrayObject {
    internal ArrayWrapper() { }
    public override object length { get { return default(object); } set { } }
    public new System.Type GetType() { return default(System.Type); }
  }
  public sealed partial class AssemblyCustomAttributeList : Microsoft.JScript.AST {
    internal AssemblyCustomAttributeList() { }
  }
  public abstract partial class AST {
    internal AST() { }
  }
  public sealed partial class ASTList : Microsoft.JScript.AST {
    internal ASTList() { }
  }
  public abstract partial class BinaryOp : Microsoft.JScript.AST {
    internal BinaryOp() { }
    protected Microsoft.JScript.AST operand1;
    protected Microsoft.JScript.AST operand2;
    protected System.Reflection.MethodInfo operatorMeth;
    protected Microsoft.JScript.JSToken operatorTok;
    protected System.Type type1;
    protected System.Type type2;
    protected System.Reflection.MethodInfo GetOperator(System.Reflection.IReflect ir1, System.Reflection.IReflect ir2) { return default(System.Reflection.MethodInfo); }
  }
  public abstract partial class Binding : Microsoft.JScript.AST {
    internal Binding() { }
    protected System.Reflection.MemberInfo defaultMember;
    protected bool isAssignmentToDefaultIndexedProperty;
    protected bool isFullyResolved;
    protected bool isNonVirtual;
    protected string name;
    protected abstract object GetObject();
    protected abstract void HandleNoSuchMemberError();
    public static bool IsMissing(object value) { return default(bool); }
    protected void ResolveRHValue() { }
    protected abstract void TranslateToILObject(System.Reflection.Emit.ILGenerator il, System.Type obtype, bool noValue);
    protected abstract void TranslateToILWithDupOfThisOb(System.Reflection.Emit.ILGenerator il);
  }
  public sealed partial class BitwiseBinary : Microsoft.JScript.BinaryOp {
    public BitwiseBinary(int operatorTok) { }
    [System.Diagnostics.DebuggerHiddenAttribute]
    [System.Diagnostics.DebuggerStepThroughAttribute]
    public object EvaluateBitwiseBinary(object v1, object v2) { return default(object); }
  }
  public sealed partial class Block : Microsoft.JScript.AST {
    internal Block() { }
  }
  public partial class BlockScope : Microsoft.JScript.ActivationObject {
    public BlockScope(Microsoft.JScript.ScriptObject parent, string name, int scopeId) { }
    protected override Microsoft.JScript.JSVariableField CreateField(string name, System.Reflection.FieldAttributes attributeFlags, object value) { return default(Microsoft.JScript.JSVariableField); }
  }
  public sealed partial class BooleanConstructor : Microsoft.JScript.ScriptFunction {
    internal BooleanConstructor() : base (default(Microsoft.JScript.ScriptObject), default(string)) { }
    [Microsoft.JScript.JSFunctionAttribute((Microsoft.JScript.JSFunctionAttributeEnum)(16))]
    public new Microsoft.JScript.BooleanObject CreateInstance(params System.Object[] args) { return default(Microsoft.JScript.BooleanObject); }
    public bool Invoke(object arg) { return default(bool); }
  }
  public partial class BooleanObject : Microsoft.JScript.JSObject {
    protected BooleanObject(Microsoft.JScript.ScriptObject prototype, System.Type subType) { }
    public new System.Type GetType() { return default(System.Type); }
  }
  public partial class BooleanPrototype : Microsoft.JScript.BooleanObject {
    protected BooleanPrototype(Microsoft.JScript.ObjectPrototype parent, System.Type baseType) : base (default(Microsoft.JScript.ScriptObject), default(System.Type)) { }
    public static Microsoft.JScript.BooleanConstructor constructor { get { return default(Microsoft.JScript.BooleanConstructor); } }
    [Microsoft.JScript.JSFunctionAttribute((Microsoft.JScript.JSFunctionAttributeEnum)(2), (Microsoft.JScript.JSBuiltin)(13))]
    public static string toString(object thisob) { return default(string); }
    [Microsoft.JScript.JSFunctionAttribute((Microsoft.JScript.JSFunctionAttributeEnum)(2), (Microsoft.JScript.JSBuiltin)(14))]
    public static object valueOf(object thisob) { return default(object); }
  }
  public sealed partial class BreakOutOfFinally : System.ApplicationException {
    public int target;
    public BreakOutOfFinally(int target) { }
    public BreakOutOfFinally(string m) { }
    public BreakOutOfFinally(string m, System.Exception e) { }
    [System.Security.SecurityCriticalAttribute]
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, SerializationFormatter=true)]
    public override void GetObjectData(System.Runtime.Serialization.SerializationInfo s, System.Runtime.Serialization.StreamingContext c) { }
  }
  public sealed partial class Closure : Microsoft.JScript.ScriptFunction {
    public object arguments;
    public object caller;
    public Closure(Microsoft.JScript.FunctionObject func) : base (default(Microsoft.JScript.ScriptObject), default(string)) { }
    public override string ToString() { return default(string); }
  }
  public enum CmdLineError {
    AssemblyNotFound = 2001,
    CannotCreateEngine = 2002,
    CompilerConstant = 2003,
    DuplicateFileAsSourceAndAssembly = 2004,
    DuplicateResourceFile = 2005,
    DuplicateResourceName = 2006,
    DuplicateSourceFile = 2007,
    ErrorSavingCompiledState = 2008,
    IncompatibleTargets = 2038,
    InvalidAssembly = 2009,
    InvalidCharacters = 2036,
    InvalidCodePage = 2010,
    InvalidDefinition = 2011,
    InvalidForCompilerOptions = 2037,
    InvalidLocaleID = 2012,
    InvalidPlatform = 2039,
    InvalidSourceFile = 2014,
    InvalidTarget = 2013,
    InvalidVersion = 2031,
    InvalidWarningLevel = 2015,
    LAST = 2039,
    ManagedResourceNotFound = 2022,
    MissingDefineArgument = 2018,
    MissingExtension = 2019,
    MissingLibArgument = 2020,
    MissingReference = 2034,
    MissingVersionInfo = 2021,
    MultipleOutputNames = 2016,
    MultipleTargets = 2017,
    MultipleWin32Resources = 2033,
    NestedResponseFiles = 2023,
    NoCodePage = 2024,
    NoError = 0,
    NoFileName = 2025,
    NoInputSourcesSpecified = 2026,
    NoLocaleID = 2027,
    NoWarningLevel = 2028,
    ResourceNotFound = 2029,
    SourceFileTooBig = 2032,
    SourceNotFound = 2035,
    UnknownOption = 2030,
    Unspecified = 2999,
  }
  public partial class CmdLineException : System.Exception {
    public CmdLineException() { }
    public CmdLineException(Microsoft.JScript.CmdLineError errorCode, System.Globalization.CultureInfo culture) { }
    public CmdLineException(Microsoft.JScript.CmdLineError errorCode, string context, System.Globalization.CultureInfo culture) { }
    protected CmdLineException(System.Runtime.Serialization.SerializationInfo s, System.Runtime.Serialization.StreamingContext c) { }
    public CmdLineException(string m) { }
    public CmdLineException(string m, System.Exception e) { }
    public override string Message { get { return default(string); } }
    [System.Security.SecurityCriticalAttribute]
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, SerializationFormatter=true)]
    public override void GetObjectData(System.Runtime.Serialization.SerializationInfo s, System.Runtime.Serialization.StreamingContext c) { }
    public string ResourceKey(Microsoft.JScript.CmdLineError errorCode) { return default(string); }
  }
  public partial class CmdLineOptionParser {
    public CmdLineOptionParser() { }
    public static string IsArgumentOption(string option, string prefix) { return default(string); }
    public static string IsArgumentOption(string option, string shortPrefix, string longPrefix) { return default(string); }
    public static object IsBooleanOption(string option, string prefix) { return default(object); }
    public static object IsBooleanOption(string option, string shortPrefix, string longPrefix) { return default(object); }
    public static bool IsSimpleOption(string option, string prefix) { return default(bool); }
  }
  public partial class COMCharStream : System.IO.Stream {
    public COMCharStream(Microsoft.JScript.IMessageReceiver messageReceiver) { }
    public override bool CanRead { get { return default(bool); } }
    public override bool CanSeek { get { return default(bool); } }
    public override bool CanWrite { get { return default(bool); } }
    public override long Length { get { return default(long); } }
    public override long Position { get { return default(long); } set { } }
    public override void Close() { }
    public override void Flush() { }
    public override int Read(System.Byte[] buffer, int offset, int count) { return default(int); }
    public override long Seek(long offset, System.IO.SeekOrigin origin) { return default(long); }
    public override void SetLength(long value) { }
    public override void Write(System.Byte[] buffer, int offset, int count) { }
  }
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  [System.Runtime.InteropServices.GuidAttribute("CA0F511A-FAF2-4942-B9A8-17D5E46514E8")]
  public partial class COMFieldInfo : System.Reflection.FieldInfo, Microsoft.JScript.MemberInfoInitializer {
    public COMFieldInfo() { }
    public override System.Reflection.FieldAttributes Attributes { get { return default(System.Reflection.FieldAttributes); } }
    public override System.Type DeclaringType { get { return default(System.Type); } }
    public override System.RuntimeFieldHandle FieldHandle { get { return default(System.RuntimeFieldHandle); } }
    public override System.Type FieldType { get { return default(System.Type); } }
    public override System.Reflection.MemberTypes MemberType { get { return default(System.Reflection.MemberTypes); } }
    public override string Name { get { return default(string); } }
    public override System.Type ReflectedType { get { return default(System.Type); } }
    public Microsoft.JScript.COMMemberInfo GetCOMMemberInfo() { return default(Microsoft.JScript.COMMemberInfo); }
    public override System.Object[] GetCustomAttributes(bool inherit) { return default(System.Object[]); }
    public override System.Object[] GetCustomAttributes(System.Type t, bool inherit) { return default(System.Object[]); }
    public override object GetValue(object obj) { return default(object); }
    public virtual void Initialize(string name, Microsoft.JScript.COMMemberInfo dispatch) { }
    public override bool IsDefined(System.Type t, bool inherit) { return default(bool); }
    public override void SetValue(object obj, object value, System.Reflection.BindingFlags invokeAttr, System.Reflection.Binder binder, System.Globalization.CultureInfo culture) { }
  }
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  [System.Runtime.InteropServices.GuidAttribute("84BCEB62-16EB-4e1c-975C-FCB40D331043")]
  public partial interface COMMemberInfo {
    object Call(System.Reflection.BindingFlags invokeAttr, System.Reflection.Binder binder, System.Object[] arguments, System.Globalization.CultureInfo culture);
    object GetValue(System.Reflection.BindingFlags invokeAttr, System.Reflection.Binder binder, System.Object[] index, System.Globalization.CultureInfo culture);
    void SetValue(object value, System.Reflection.BindingFlags invokeAttr, System.Reflection.Binder binder, System.Object[] index, System.Globalization.CultureInfo culture);
  }
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  [System.Runtime.InteropServices.GuidAttribute("C7B9C313-2FD4-4384-8571-7ABC08BD17E5")]
  public partial class COMMethodInfo : Microsoft.JScript.JSMethod, Microsoft.JScript.MemberInfoInitializer {
    protected Microsoft.JScript.COMMemberInfo _comObject;
    protected string _name;
    protected static readonly System.Reflection.ParameterInfo[] EmptyParams;
    public COMMethodInfo() { }
    public override System.Reflection.MethodAttributes Attributes { get { return default(System.Reflection.MethodAttributes); } }
    public override System.Type DeclaringType { get { return default(System.Type); } }
    public override System.Reflection.MemberTypes MemberType { get { return default(System.Reflection.MemberTypes); } }
    public override System.RuntimeMethodHandle MethodHandle { get { return default(System.RuntimeMethodHandle); } }
    public override string Name { get { return default(string); } }
    public override System.Type ReflectedType { get { return default(System.Type); } }
    public override System.Type ReturnType { get { return default(System.Type); } }
    public override System.Reflection.ICustomAttributeProvider ReturnTypeCustomAttributes { get { return default(System.Reflection.ICustomAttributeProvider); } }
    public override System.Reflection.MethodInfo GetBaseDefinition() { return default(System.Reflection.MethodInfo); }
    public Microsoft.JScript.COMMemberInfo GetCOMMemberInfo() { return default(Microsoft.JScript.COMMemberInfo); }
    public override System.Reflection.MethodImplAttributes GetMethodImplementationFlags() { return default(System.Reflection.MethodImplAttributes); }
    public override System.Reflection.ParameterInfo[] GetParameters() { return default(System.Reflection.ParameterInfo[]); }
    public virtual void Initialize(string name, Microsoft.JScript.COMMemberInfo dispatch) { }
    public override object Invoke(object obj, System.Reflection.BindingFlags invokeAttr, System.Reflection.Binder binder, System.Object[] parameters, System.Globalization.CultureInfo culture) { return default(object); }
    public override string ToString() { return default(string); }
  }
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  [System.Runtime.InteropServices.GuidAttribute("6A02951C-B129-4d26-AB92-B9CA19BDCA26")]
  public sealed partial class COMPropertyInfo : System.Reflection.PropertyInfo, Microsoft.JScript.MemberInfoInitializer {
    public COMPropertyInfo() { }
    public override System.Reflection.PropertyAttributes Attributes { get { return default(System.Reflection.PropertyAttributes); } }
    public override bool CanRead { get { return default(bool); } }
    public override bool CanWrite { get { return default(bool); } }
    public override System.Type DeclaringType { get { return default(System.Type); } }
    public override System.Reflection.MemberTypes MemberType { get { return default(System.Reflection.MemberTypes); } }
    public override string Name { get { return default(string); } }
    public override System.Type PropertyType { get { return default(System.Type); } }
    public override System.Type ReflectedType { get { return default(System.Type); } }
    public override System.Reflection.MethodInfo[] GetAccessors(bool nonPublic) { return default(System.Reflection.MethodInfo[]); }
    public Microsoft.JScript.COMMemberInfo GetCOMMemberInfo() { return default(Microsoft.JScript.COMMemberInfo); }
    public override System.Object[] GetCustomAttributes(bool inherit) { return default(System.Object[]); }
    public override System.Object[] GetCustomAttributes(System.Type t, bool inherit) { return default(System.Object[]); }
    public override System.Reflection.MethodInfo GetGetMethod(bool nonPublic) { return default(System.Reflection.MethodInfo); }
    public override System.Reflection.ParameterInfo[] GetIndexParameters() { return default(System.Reflection.ParameterInfo[]); }
    public override System.Reflection.MethodInfo GetSetMethod(bool nonPublic) { return default(System.Reflection.MethodInfo); }
    public override object GetValue(object obj, System.Reflection.BindingFlags invokeAttr, System.Reflection.Binder binder, System.Object[] index, System.Globalization.CultureInfo culture) { return default(object); }
    public void Initialize(string name, Microsoft.JScript.COMMemberInfo dispatch) { }
    public override bool IsDefined(System.Type t, bool inherit) { return default(bool); }
    public override void SetValue(object obj, object value, System.Reflection.BindingFlags invokeAttr, System.Reflection.Binder binder, System.Object[] index, System.Globalization.CultureInfo culture) { }
  }
  public partial class Context {
    internal Context() { }
    public int EndColumn { get { return default(int); } }
    public int EndLine { get { return default(int); } }
    public int EndPosition { get { return default(int); } }
    public int StartColumn { get { return default(int); } }
    public int StartLine { get { return default(int); } }
    public int StartPosition { get { return default(int); } }
    public string GetCode() { return default(string); }
    public Microsoft.JScript.JSToken GetToken() { return default(Microsoft.JScript.JSToken); }
  }
  public sealed partial class ContinueOutOfFinally : System.ApplicationException {
    public int target;
    public ContinueOutOfFinally() { }
    public ContinueOutOfFinally(int target) { }
    public ContinueOutOfFinally(string m) { }
    public ContinueOutOfFinally(string m, System.Exception e) { }
    [System.Security.SecurityCriticalAttribute]
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, SerializationFormatter=true)]
    public override void GetObjectData(System.Runtime.Serialization.SerializationInfo s, System.Runtime.Serialization.StreamingContext c) { }
  }
  public sealed partial class Convert {
    public Convert() { }
    public static double CheckIfDoubleIsInteger(double d) { return default(double); }
    public static float CheckIfSingleIsInteger(float s) { return default(float); }
    public static object Coerce(object value, object type) { return default(object); }
    public static object Coerce2(object value, System.TypeCode target, bool truncationPermitted) { return default(object); }
    public static object CoerceT(object value, System.Type t, bool explicitOK) { return default(object); }
    public static bool IsBadIndex(Microsoft.JScript.AST ast) { return default(bool); }
    [System.Diagnostics.DebuggerHiddenAttribute]
    [System.Diagnostics.DebuggerStepThroughAttribute]
    public static void ThrowTypeMismatch(object val) { }
    public static bool ToBoolean(double d) { return default(bool); }
    [System.Diagnostics.DebuggerHiddenAttribute]
    [System.Diagnostics.DebuggerStepThroughAttribute]
    public static bool ToBoolean(object value) { return default(bool); }
    [System.Diagnostics.DebuggerHiddenAttribute]
    [System.Diagnostics.DebuggerStepThroughAttribute]
    public static bool ToBoolean(object value, bool explicitConversion) { return default(bool); }
    public static object ToForInObject(object value, Microsoft.JScript.Vsa.VsaEngine engine) { return default(object); }
    public static int ToInt32(object value) { return default(int); }
    public static object ToNativeArray(object value, System.RuntimeTypeHandle handle) { return default(object); }
    public static double ToNumber(object value) { return default(double); }
    public static double ToNumber(string str) { return default(double); }
    public static object ToObject(object value, Microsoft.JScript.Vsa.VsaEngine engine) { return default(object); }
    public static object ToObject2(object value, Microsoft.JScript.Vsa.VsaEngine engine) { return default(object); }
    public static string ToString(bool b) { return default(string); }
    public static string ToString(double d) { return default(string); }
    [System.Diagnostics.DebuggerHiddenAttribute]
    [System.Diagnostics.DebuggerStepThroughAttribute]
    public static string ToString(object value, bool explicitOK) { return default(string); }
  }
  public partial class DateConstructor : Microsoft.JScript.ScriptFunction {
    internal DateConstructor() : base (default(Microsoft.JScript.ScriptObject), default(string)) { }
    [Microsoft.JScript.JSFunctionAttribute((Microsoft.JScript.JSFunctionAttributeEnum)(16))]
    public new Microsoft.JScript.DateObject CreateInstance(params System.Object[] args) { return default(Microsoft.JScript.DateObject); }
    public string Invoke() { return default(string); }
    [Microsoft.JScript.JSFunctionAttribute((Microsoft.JScript.JSFunctionAttributeEnum)(0), (Microsoft.JScript.JSBuiltin)(35))]
    public static double parse(string str) { return default(double); }
    [Microsoft.JScript.JSFunctionAttribute((Microsoft.JScript.JSFunctionAttributeEnum)(0), (Microsoft.JScript.JSBuiltin)(60))]
    public static double UTC(object year, object month, object date, object hours, object minutes, object seconds, object ms) { return default(double); }
  }
  public partial class DateObject : Microsoft.JScript.JSObject {
    internal DateObject() { }
  }
  public partial class DatePrototype : Microsoft.JScript.DateObject {
    internal DatePrototype() { }
    public static Microsoft.JScript.DateConstructor constructor { get { return default(Microsoft.JScript.DateConstructor); } }
    [Microsoft.JScript.JSFunctionAttribute((Microsoft.JScript.JSFunctionAttributeEnum)(2), (Microsoft.JScript.JSBuiltin)(15))]
    public static double getDate(object thisob) { return default(double); }
    [Microsoft.JScript.JSFunctionAttribute((Microsoft.JScript.JSFunctionAttributeEnum)(2), (Microsoft.JScript.JSBuiltin)(16))]
    public static double getDay(object thisob) { return default(double); }
    [Microsoft.JScript.JSFunctionAttribute((Microsoft.JScript.JSFunctionAttributeEnum)(2), (Microsoft.JScript.JSBuiltin)(17))]
    public static double getFullYear(object thisob) { return default(double); }
    [Microsoft.JScript.JSFunctionAttribute((Microsoft.JScript.JSFunctionAttributeEnum)(2), (Microsoft.JScript.JSBuiltin)(18))]
    public static double getHours(object thisob) { return default(double); }
    [Microsoft.JScript.JSFunctionAttribute((Microsoft.JScript.JSFunctionAttributeEnum)(2), (Microsoft.JScript.JSBuiltin)(19))]
    public static double getMilliseconds(object thisob) { return default(double); }
    [Microsoft.JScript.JSFunctionAttribute((Microsoft.JScript.JSFunctionAttributeEnum)(2), (Microsoft.JScript.JSBuiltin)(20))]
    public static double getMinutes(object thisob) { return default(double); }
    [Microsoft.JScript.JSFunctionAttribute((Microsoft.JScript.JSFunctionAttributeEnum)(2), (Microsoft.JScript.JSBuiltin)(21))]
    public static double getMonth(object thisob) { return default(double); }
    [Microsoft.JScript.JSFunctionAttribute((Microsoft.JScript.JSFunctionAttributeEnum)(2), (Microsoft.JScript.JSBuiltin)(22))]
    public static double getSeconds(object thisob) { return default(double); }
    [Microsoft.JScript.JSFunctionAttribute((Microsoft.JScript.JSFunctionAttributeEnum)(2), (Microsoft.JScript.JSBuiltin)(23))]
    public static double getTime(object thisob) { return default(double); }
    [Microsoft.JScript.JSFunctionAttribute((Microsoft.JScript.JSFunctionAttributeEnum)(2), (Microsoft.JScript.JSBuiltin)(24))]
    public static double getTimezoneOffset(object thisob) { return default(double); }
    [Microsoft.JScript.JSFunctionAttribute((Microsoft.JScript.JSFunctionAttributeEnum)(2), (Microsoft.JScript.JSBuiltin)(25))]
    public static double getUTCDate(object thisob) { return default(double); }
    [Microsoft.JScript.JSFunctionAttribute((Microsoft.JScript.JSFunctionAttributeEnum)(2), (Microsoft.JScript.JSBuiltin)(26))]
    public static double getUTCDay(object thisob) { return default(double); }
    [Microsoft.JScript.JSFunctionAttribute((Microsoft.JScript.JSFunctionAttributeEnum)(2), (Microsoft.JScript.JSBuiltin)(27))]
    public static double getUTCFullYear(object thisob) { return default(double); }
    [Microsoft.JScript.JSFunctionAttribute((Microsoft.JScript.JSFunctionAttributeEnum)(2), (Microsoft.JScript.JSBuiltin)(28))]
    public static double getUTCHours(object thisob) { return default(double); }
    [Microsoft.JScript.JSFunctionAttribute((Microsoft.JScript.JSFunctionAttributeEnum)(2), (Microsoft.JScript.JSBuiltin)(29))]
    public static double getUTCMilliseconds(object thisob) { return default(double); }
    [Microsoft.JScript.JSFunctionAttribute((Microsoft.JScript.JSFunctionAttributeEnum)(2), (Microsoft.JScript.JSBuiltin)(30))]
    public static double getUTCMinutes(object thisob) { return default(double); }
    [Microsoft.JScript.JSFunctionAttribute((Microsoft.JScript.JSFunctionAttributeEnum)(2), (Microsoft.JScript.JSBuiltin)(31))]
    public static double getUTCMonth(object thisob) { return default(double); }
    [Microsoft.JScript.JSFunctionAttribute((Microsoft.JScript.JSFunctionAttributeEnum)(2), (Microsoft.JScript.JSBuiltin)(32))]
    public static double getUTCSeconds(object thisob) { return default(double); }
    [Microsoft.JScript.JSFunctionAttribute((Microsoft.JScript.JSFunctionAttributeEnum)(2), (Microsoft.JScript.JSBuiltin)(33))]
    public static object getVarDate(object thisob) { return default(object); }
    [Microsoft.JScript.JSFunctionAttribute((Microsoft.JScript.JSFunctionAttributeEnum)(2), (Microsoft.JScript.JSBuiltin)(34))]
    [Microsoft.JScript.NotRecommended("getYear")]
    public static double getYear(object thisob) { return default(double); }
    [Microsoft.JScript.JSFunctionAttribute((Microsoft.JScript.JSFunctionAttributeEnum)(2), (Microsoft.JScript.JSBuiltin)(36))]
    public static double setDate(object thisob, double ddate) { return default(double); }
    [Microsoft.JScript.JSFunctionAttribute((Microsoft.JScript.JSFunctionAttributeEnum)(2), (Microsoft.JScript.JSBuiltin)(37))]
    public static double setFullYear(object thisob, double dyear, object month, object date) { return default(double); }
    [Microsoft.JScript.JSFunctionAttribute((Microsoft.JScript.JSFunctionAttributeEnum)(2), (Microsoft.JScript.JSBuiltin)(38))]
    public static double setHours(object thisob, double dhour, object min, object sec, object msec) { return default(double); }
    [Microsoft.JScript.JSFunctionAttribute((Microsoft.JScript.JSFunctionAttributeEnum)(2), (Microsoft.JScript.JSBuiltin)(40))]
    public static double setMilliseconds(object thisob, double dmsec) { return default(double); }
    [Microsoft.JScript.JSFunctionAttribute((Microsoft.JScript.JSFunctionAttributeEnum)(2), (Microsoft.JScript.JSBuiltin)(39))]
    public static double setMinutes(object thisob, double dmin, object sec, object msec) { return default(double); }
    [Microsoft.JScript.JSFunctionAttribute((Microsoft.JScript.JSFunctionAttributeEnum)(2), (Microsoft.JScript.JSBuiltin)(41))]
    public static double setMonth(object thisob, double dmonth, object date) { return default(double); }
    [Microsoft.JScript.JSFunctionAttribute((Microsoft.JScript.JSFunctionAttributeEnum)(2), (Microsoft.JScript.JSBuiltin)(42))]
    public static double setSeconds(object thisob, double dsec, object msec) { return default(double); }
    [Microsoft.JScript.JSFunctionAttribute((Microsoft.JScript.JSFunctionAttributeEnum)(2), (Microsoft.JScript.JSBuiltin)(43))]
    public static double setTime(object thisob, double time) { return default(double); }
    [Microsoft.JScript.JSFunctionAttribute((Microsoft.JScript.JSFunctionAttributeEnum)(2), (Microsoft.JScript.JSBuiltin)(44))]
    public static double setUTCDate(object thisob, double ddate) { return default(double); }
    [Microsoft.JScript.JSFunctionAttribute((Microsoft.JScript.JSFunctionAttributeEnum)(2), (Microsoft.JScript.JSBuiltin)(45))]
    public static double setUTCFullYear(object thisob, double dyear, object month, object date) { return default(double); }
    [Microsoft.JScript.JSFunctionAttribute((Microsoft.JScript.JSFunctionAttributeEnum)(2), (Microsoft.JScript.JSBuiltin)(46))]
    public static double setUTCHours(object thisob, double dhour, object min, object sec, object msec) { return default(double); }
    [Microsoft.JScript.JSFunctionAttribute((Microsoft.JScript.JSFunctionAttributeEnum)(2), (Microsoft.JScript.JSBuiltin)(48))]
    public static double setUTCMilliseconds(object thisob, double dmsec) { return default(double); }
    [Microsoft.JScript.JSFunctionAttribute((Microsoft.JScript.JSFunctionAttributeEnum)(2), (Microsoft.JScript.JSBuiltin)(47))]
    public static double setUTCMinutes(object thisob, double dmin, object sec, object msec) { return default(double); }
    [Microsoft.JScript.JSFunctionAttribute((Microsoft.JScript.JSFunctionAttributeEnum)(2), (Microsoft.JScript.JSBuiltin)(49))]
    public static double setUTCMonth(object thisob, double dmonth, object date) { return default(double); }
    [Microsoft.JScript.JSFunctionAttribute((Microsoft.JScript.JSFunctionAttributeEnum)(2), (Microsoft.JScript.JSBuiltin)(50))]
    public static double setUTCSeconds(object thisob, double dsec, object msec) { return default(double); }
    [Microsoft.JScript.JSFunctionAttribute((Microsoft.JScript.JSFunctionAttributeEnum)(2), (Microsoft.JScript.JSBuiltin)(51))]
    [Microsoft.JScript.NotRecommended("setYear")]
    public static double setYear(object thisob, double dyear) { return default(double); }
    [Microsoft.JScript.JSFunctionAttribute((Microsoft.JScript.JSFunctionAttributeEnum)(2), (Microsoft.JScript.JSBuiltin)(52))]
    public static string toDateString(object thisob) { return default(string); }
    [Microsoft.JScript.JSFunctionAttribute((Microsoft.JScript.JSFunctionAttributeEnum)(2), (Microsoft.JScript.JSBuiltin)(53))]
    [Microsoft.JScript.NotRecommended("toGMTString")]
    public static string toGMTString(object thisob) { return default(string); }
    [Microsoft.JScript.JSFunctionAttribute((Microsoft.JScript.JSFunctionAttributeEnum)(2), (Microsoft.JScript.JSBuiltin)(54))]
    public static string toLocaleDateString(object thisob) { return default(string); }
    [Microsoft.JScript.JSFunctionAttribute((Microsoft.JScript.JSFunctionAttributeEnum)(2), (Microsoft.JScript.JSBuiltin)(55))]
    public static string toLocaleString(object thisob) { return default(string); }
    [Microsoft.JScript.JSFunctionAttribute((Microsoft.JScript.JSFunctionAttributeEnum)(2), (Microsoft.JScript.JSBuiltin)(56))]
    public static string toLocaleTimeString(object thisob) { return default(string); }
    [Microsoft.JScript.JSFunctionAttribute((Microsoft.JScript.JSFunctionAttributeEnum)(2), (Microsoft.JScript.JSBuiltin)(57))]
    public static string toString(object thisob) { return default(string); }
    [Microsoft.JScript.JSFunctionAttribute((Microsoft.JScript.JSFunctionAttributeEnum)(2), (Microsoft.JScript.JSBuiltin)(58))]
    public static string toTimeString(object thisob) { return default(string); }
    [Microsoft.JScript.JSFunctionAttribute((Microsoft.JScript.JSFunctionAttributeEnum)(2), (Microsoft.JScript.JSBuiltin)(59))]
    public static string toUTCString(object thisob) { return default(string); }
    [Microsoft.JScript.JSFunctionAttribute((Microsoft.JScript.JSFunctionAttributeEnum)(2), (Microsoft.JScript.JSBuiltin)(61))]
    public static double valueOf(object thisob) { return default(double); }
  }
  public partial class DebugBreak : Microsoft.JScript.AST {
    internal DebugBreak() { }
  }
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  [System.Runtime.InteropServices.GuidAttribute("432D76CE-8C9E-4eed-ADDD-91737F27A8CB")]
  public partial class DebugConvert : Microsoft.JScript.IDebugConvert, Microsoft.JScript.IDebugConvert2 {
    public DebugConvert() { }
    public string BooleanToString(bool value) { return default(string); }
    public string ByteToString(byte value, int radix) { return default(string); }
    public string DecimalToString(decimal value) { return default(string); }
    public string DoubleToDateString(double value) { return default(string); }
    public string DoubleToString(double value) { return default(string); }
    public string GetErrorMessageForHR(int hr, Microsoft.JScript.Vsa.IJSVsaEngine engine) { return default(string); }
    public object GetManagedCharObject(ushort i) { return default(object); }
    public object GetManagedInt64Object(long i) { return default(object); }
    public object GetManagedObject(object value) { return default(object); }
    public object GetManagedUInt64Object(ulong i) { return default(object); }
    public string Int16ToString(short value, int radix) { return default(string); }
    public string Int32ToString(int value, int radix) { return default(string); }
    public string Int64ToString(long value, int radix) { return default(string); }
    public string RegexpToString(string source, bool ignoreCase, bool global, bool multiline) { return default(string); }
    public string SByteToString(sbyte value, int radix) { return default(string); }
    public string SingleToString(float value) { return default(string); }
    public string StringToPrintable(string source) { return default(string); }
    public object ToPrimitive(object value, System.TypeCode typeCode, bool truncationPermitted) { return default(object); }
    public string UInt16ToString(ushort value, int radix) { return default(string); }
    public string UInt32ToString(uint value, int radix) { return default(string); }
    public string UInt64ToString(ulong value, int radix) { return default(string); }
  }
  public partial class DocumentContext {
    internal DocumentContext() { }
  }
  public sealed partial class DynamicFieldInfo {
    public string fieldTypeName;
    public string name;
    public object value;
    public DynamicFieldInfo(string name, object value) { }
    public DynamicFieldInfo(string name, object value, string fieldTypeName) { }
  }
  public sealed partial class Empty {
    internal Empty() { }
    public static readonly Microsoft.JScript.Empty Value;
  }
  public partial class EndOfFile : Microsoft.JScript.ParserException {
    internal EndOfFile() { }
  }
  public sealed partial class EnumeratorConstructor : Microsoft.JScript.ScriptFunction {
    internal EnumeratorConstructor() : base (default(Microsoft.JScript.ScriptObject), default(string)) { }
    [Microsoft.JScript.JSFunctionAttribute((Microsoft.JScript.JSFunctionAttributeEnum)(16))]
    public new Microsoft.JScript.EnumeratorObject CreateInstance(params System.Object[] args) { return default(Microsoft.JScript.EnumeratorObject); }
    public object Invoke() { return default(object); }
  }
  public partial class EnumeratorObject : Microsoft.JScript.JSObject {
    internal EnumeratorObject() { }
    protected System.Collections.IEnumerator enumerator;
    protected void LoadObject() { }
  }
  public partial class EnumeratorPrototype : Microsoft.JScript.JSObject {
    internal EnumeratorPrototype() { }
    public static Microsoft.JScript.EnumeratorConstructor constructor { get { return default(Microsoft.JScript.EnumeratorConstructor); } }
    [Microsoft.JScript.JSFunctionAttribute((Microsoft.JScript.JSFunctionAttributeEnum)(2), (Microsoft.JScript.JSBuiltin)(62))]
    public static bool atEnd(object thisob) { return default(bool); }
    [Microsoft.JScript.JSFunctionAttribute((Microsoft.JScript.JSFunctionAttributeEnum)(2), (Microsoft.JScript.JSBuiltin)(63))]
    public static object item(object thisob) { return default(object); }
    [Microsoft.JScript.JSFunctionAttribute((Microsoft.JScript.JSFunctionAttributeEnum)(2), (Microsoft.JScript.JSBuiltin)(64))]
    public static void moveFirst(object thisob) { }
    [Microsoft.JScript.JSFunctionAttribute((Microsoft.JScript.JSFunctionAttributeEnum)(2), (Microsoft.JScript.JSBuiltin)(65))]
    public static void moveNext(object thisob) { }
  }
  public partial class Equality : Microsoft.JScript.BinaryOp {
    public Equality(int operatorTok) { }
    [System.Diagnostics.DebuggerHiddenAttribute]
    [System.Diagnostics.DebuggerStepThroughAttribute]
    public bool EvaluateEquality(object v1, object v2) { return default(bool); }
    public static bool JScriptEquals(object v1, object v2) { return default(bool); }
  }
  public sealed partial class ErrorConstructor : Microsoft.JScript.ScriptFunction {
    internal ErrorConstructor() : base (default(Microsoft.JScript.ScriptObject), default(string)) { }
    [Microsoft.JScript.JSFunctionAttribute((Microsoft.JScript.JSFunctionAttributeEnum)(16))]
    public new Microsoft.JScript.ErrorObject CreateInstance(params System.Object[] args) { return default(Microsoft.JScript.ErrorObject); }
    [Microsoft.JScript.JSFunctionAttribute((Microsoft.JScript.JSFunctionAttributeEnum)(16))]
    public object Invoke(params System.Object[] args) { return default(object); }
  }
  public partial class ErrorObject : Microsoft.JScript.JSObject {
    internal ErrorObject() { }
    public object description;
    public object message;
    public object number;
    public static explicit operator System.Exception (Microsoft.JScript.ErrorObject err) { return default(System.Exception); }
    public static System.Exception ToException(Microsoft.JScript.ErrorObject err) { return default(System.Exception); }
  }
  public partial class ErrorPrototype : Microsoft.JScript.JSObject {
    internal ErrorPrototype() { }
    public readonly string name;
    public Microsoft.JScript.ErrorConstructor constructor { get { return default(Microsoft.JScript.ErrorConstructor); } }
    [Microsoft.JScript.JSFunctionAttribute((Microsoft.JScript.JSFunctionAttributeEnum)(2), (Microsoft.JScript.JSBuiltin)(66))]
    public static string toString(object thisob) { return default(string); }
  }
  public enum ErrorType {
    EvalError = 1,
    OtherError = 0,
    RangeError = 2,
    ReferenceError = 3,
    SyntaxError = 4,
    TypeError = 5,
    URIError = 6,
  }
  public sealed partial class Eval : Microsoft.JScript.AST {
    internal Eval() { }
    public static object JScriptEvaluate(object source, Microsoft.JScript.Vsa.VsaEngine engine) { return default(object); }
    public static object JScriptEvaluate(object source, object unsafeOption, Microsoft.JScript.Vsa.VsaEngine engine) { return default(object); }
  }
  public sealed partial class EvalErrorObject : Microsoft.JScript.ErrorObject {
    internal EvalErrorObject() { }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(68), Inherited=true)]
  public partial class Expando : System.Attribute {
    public Expando() { }
  }
  public abstract partial class FieldAccessor {
    protected FieldAccessor() { }
    [System.Diagnostics.DebuggerHiddenAttribute]
    [System.Diagnostics.DebuggerStepThroughAttribute]
    public abstract object GetValue(object thisob);
    [System.Diagnostics.DebuggerHiddenAttribute]
    [System.Diagnostics.DebuggerStepThroughAttribute]
    public abstract void SetValue(object thisob, object value);
  }
  public sealed partial class ForIn : Microsoft.JScript.AST {
    internal ForIn() { }
    public static System.Collections.IEnumerator JScriptGetEnumerator(object coll) { return default(System.Collections.IEnumerator); }
  }
  public sealed partial class FunctionConstructor : Microsoft.JScript.ScriptFunction {
    internal FunctionConstructor() : base (default(Microsoft.JScript.ScriptObject), default(string)) { }
    [Microsoft.JScript.JSFunctionAttribute((Microsoft.JScript.JSFunctionAttributeEnum)(16))]
    public new Microsoft.JScript.ScriptFunction CreateInstance(params System.Object[] args) { return default(Microsoft.JScript.ScriptFunction); }
    [Microsoft.JScript.JSFunctionAttribute((Microsoft.JScript.JSFunctionAttributeEnum)(16))]
    public Microsoft.JScript.ScriptFunction Invoke(params System.Object[] args) { return default(Microsoft.JScript.ScriptFunction); }
  }
  public sealed partial class FunctionDeclaration : Microsoft.JScript.AST {
    internal FunctionDeclaration() { }
    public static Microsoft.JScript.Closure JScriptFunctionDeclaration(System.RuntimeTypeHandle handle, string name, string method_name, System.String[] formal_parameters, Microsoft.JScript.JSLocalField[] fields, bool must_save_stack_locals, bool hasArgumentsObject, string text, object declaringObject, Microsoft.JScript.Vsa.VsaEngine engine) { return default(Microsoft.JScript.Closure); }
  }
  public sealed partial class FunctionExpression : Microsoft.JScript.AST {
    internal FunctionExpression() { }
    public static Microsoft.JScript.FunctionObject JScriptFunctionExpression(System.RuntimeTypeHandle handle, string name, string method_name, System.String[] formal_params, Microsoft.JScript.JSLocalField[] fields, bool must_save_stack_locals, bool hasArgumentsObject, string text, Microsoft.JScript.Vsa.VsaEngine engine) { return default(Microsoft.JScript.FunctionObject); }
  }
  public sealed partial class FunctionObject : Microsoft.JScript.ScriptFunction {
    internal FunctionObject() : base (default(Microsoft.JScript.ScriptObject), default(string)) { }
    public override string ToString() { return default(string); }
  }
  public partial class FunctionPrototype : Microsoft.JScript.ScriptFunction {
    internal FunctionPrototype() : base (default(Microsoft.JScript.ScriptObject), default(string)) { }
    public static Microsoft.JScript.FunctionConstructor constructor { get { return default(Microsoft.JScript.FunctionConstructor); } }
    [Microsoft.JScript.JSFunctionAttribute((Microsoft.JScript.JSFunctionAttributeEnum)(2), (Microsoft.JScript.JSBuiltin)(67))]
    public static object apply(object thisob, object thisarg, object argArray) { return default(object); }
    [Microsoft.JScript.JSFunctionAttribute((Microsoft.JScript.JSFunctionAttributeEnum)(18), (Microsoft.JScript.JSBuiltin)(68))]
    public static object call(object thisob, object thisarg, params System.Object[] args) { return default(object); }
    [Microsoft.JScript.JSFunctionAttribute((Microsoft.JScript.JSFunctionAttributeEnum)(2), (Microsoft.JScript.JSBuiltin)(69))]
    public static string toString(object thisob) { return default(string); }
  }
  public sealed partial class FunctionWrapper : Microsoft.JScript.ScriptFunction {
    internal FunctionWrapper() : base (default(Microsoft.JScript.ScriptObject), default(string)) { }
    public override string ToString() { return default(string); }
  }
  public partial class GlobalObject {
    internal GlobalObject() { }
    public const double Infinity = 1.0 / 0.0;
    public const double NaN = 0.0 / 0.0;
    protected Microsoft.JScript.ActiveXObjectConstructor originalActiveXObjectField;
    protected Microsoft.JScript.ArrayConstructor originalArrayField;
    protected Microsoft.JScript.BooleanConstructor originalBooleanField;
    protected Microsoft.JScript.DateConstructor originalDateField;
    protected Microsoft.JScript.EnumeratorConstructor originalEnumeratorField;
    protected Microsoft.JScript.ErrorConstructor originalErrorField;
    protected Microsoft.JScript.ErrorConstructor originalEvalErrorField;
    protected Microsoft.JScript.FunctionConstructor originalFunctionField;
    protected Microsoft.JScript.NumberConstructor originalNumberField;
    protected Microsoft.JScript.ObjectConstructor originalObjectField;
    protected Microsoft.JScript.ObjectPrototype originalObjectPrototypeField;
    protected Microsoft.JScript.ErrorConstructor originalRangeErrorField;
    protected Microsoft.JScript.ErrorConstructor originalReferenceErrorField;
    protected Microsoft.JScript.RegExpConstructor originalRegExpField;
    protected Microsoft.JScript.StringConstructor originalStringField;
    protected Microsoft.JScript.ErrorConstructor originalSyntaxErrorField;
    protected Microsoft.JScript.ErrorConstructor originalTypeErrorField;
    protected Microsoft.JScript.ErrorConstructor originalURIErrorField;
    protected Microsoft.JScript.VBArrayConstructor originalVBArrayField;
    public static readonly Microsoft.JScript.Empty undefined;
    public static Microsoft.JScript.ActiveXObjectConstructor ActiveXObject { get { return default(Microsoft.JScript.ActiveXObjectConstructor); } }
    public static Microsoft.JScript.ArrayConstructor Array { get { return default(Microsoft.JScript.ArrayConstructor); } }
    public static System.Type boolean { get { return default(System.Type); } }
    public static Microsoft.JScript.BooleanConstructor Boolean { get { return default(Microsoft.JScript.BooleanConstructor); } }
    public static System.Type @byte { get { return default(System.Type); } }
    public static System.Type @char { get { return default(System.Type); } }
    public static Microsoft.JScript.DateConstructor Date { get { return default(Microsoft.JScript.DateConstructor); } }
    public static System.Type @decimal { get { return default(System.Type); } }
    public static System.Type @double { get { return default(System.Type); } }
    public static Microsoft.JScript.EnumeratorConstructor Enumerator { get { return default(Microsoft.JScript.EnumeratorConstructor); } }
    public static Microsoft.JScript.ErrorConstructor Error { get { return default(Microsoft.JScript.ErrorConstructor); } }
    public static Microsoft.JScript.ErrorConstructor EvalError { get { return default(Microsoft.JScript.ErrorConstructor); } }
    public static System.Type @float { get { return default(System.Type); } }
    public static Microsoft.JScript.FunctionConstructor Function { get { return default(Microsoft.JScript.FunctionConstructor); } }
    public static System.Type @int { get { return default(System.Type); } }
    public static System.Type @long { get { return default(System.Type); } }
    public static Microsoft.JScript.MathObject Math { get { return default(Microsoft.JScript.MathObject); } }
    public static Microsoft.JScript.NumberConstructor Number { get { return default(Microsoft.JScript.NumberConstructor); } }
    public static Microsoft.JScript.ObjectConstructor Object { get { return default(Microsoft.JScript.ObjectConstructor); } }
    public static Microsoft.JScript.ErrorConstructor RangeError { get { return default(Microsoft.JScript.ErrorConstructor); } }
    public static Microsoft.JScript.ErrorConstructor ReferenceError { get { return default(Microsoft.JScript.ErrorConstructor); } }
    public static Microsoft.JScript.RegExpConstructor RegExp { get { return default(Microsoft.JScript.RegExpConstructor); } }
    public static System.Type @sbyte { get { return default(System.Type); } }
    public static System.Type @short { get { return default(System.Type); } }
    public static Microsoft.JScript.StringConstructor String { get { return default(Microsoft.JScript.StringConstructor); } }
    public static Microsoft.JScript.ErrorConstructor SyntaxError { get { return default(Microsoft.JScript.ErrorConstructor); } }
    public static Microsoft.JScript.ErrorConstructor TypeError { get { return default(Microsoft.JScript.ErrorConstructor); } }
    public static System.Type @uint { get { return default(System.Type); } }
    public static System.Type @ulong { get { return default(System.Type); } }
    public static Microsoft.JScript.ErrorConstructor URIError { get { return default(Microsoft.JScript.ErrorConstructor); } }
    public static System.Type @ushort { get { return default(System.Type); } }
    public static Microsoft.JScript.VBArrayConstructor VBArray { get { return default(Microsoft.JScript.VBArrayConstructor); } }
    public static System.Type @void { get { return default(System.Type); } }
    [Microsoft.JScript.JSFunctionAttribute((Microsoft.JScript.JSFunctionAttributeEnum)(0), (Microsoft.JScript.JSBuiltin)(70))]
    public static void CollectGarbage() { }
    [Microsoft.JScript.JSFunctionAttribute((Microsoft.JScript.JSFunctionAttributeEnum)(0), (Microsoft.JScript.JSBuiltin)(71))]
    public static string decodeURI(object encodedURI) { return default(string); }
    [Microsoft.JScript.JSFunctionAttribute((Microsoft.JScript.JSFunctionAttributeEnum)(0), (Microsoft.JScript.JSBuiltin)(72))]
    public static string decodeURIComponent(object encodedURI) { return default(string); }
    [Microsoft.JScript.JSFunctionAttribute((Microsoft.JScript.JSFunctionAttributeEnum)(0), (Microsoft.JScript.JSBuiltin)(73))]
    public static string encodeURI(object uri) { return default(string); }
    [Microsoft.JScript.JSFunctionAttribute((Microsoft.JScript.JSFunctionAttributeEnum)(0), (Microsoft.JScript.JSBuiltin)(74))]
    public static string encodeURIComponent(object uriComponent) { return default(string); }
    [Microsoft.JScript.JSFunctionAttribute((Microsoft.JScript.JSFunctionAttributeEnum)(0), (Microsoft.JScript.JSBuiltin)(75))]
    [Microsoft.JScript.NotRecommended("escape")]
    public static string escape(object @string) { return default(string); }
    [Microsoft.JScript.JSFunctionAttribute((Microsoft.JScript.JSFunctionAttributeEnum)(0), (Microsoft.JScript.JSBuiltin)(76))]
    public static object eval(object x) { return default(object); }
    [Microsoft.JScript.JSFunctionAttribute((Microsoft.JScript.JSFunctionAttributeEnum)(0), (Microsoft.JScript.JSBuiltin)(77))]
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(2))]
    public static object GetObject(object moniker, object progId) { return default(object); }
    [Microsoft.JScript.JSFunctionAttribute((Microsoft.JScript.JSFunctionAttributeEnum)(0), (Microsoft.JScript.JSBuiltin)(79))]
    public static bool isFinite(double number) { return default(bool); }
    [Microsoft.JScript.JSFunctionAttribute((Microsoft.JScript.JSFunctionAttributeEnum)(0), (Microsoft.JScript.JSBuiltin)(78))]
    public static bool isNaN(object num) { return default(bool); }
    [Microsoft.JScript.JSFunctionAttribute((Microsoft.JScript.JSFunctionAttributeEnum)(0), (Microsoft.JScript.JSBuiltin)(80))]
    public static double parseFloat(object @string) { return default(double); }
    [Microsoft.JScript.JSFunctionAttribute((Microsoft.JScript.JSFunctionAttributeEnum)(0), (Microsoft.JScript.JSBuiltin)(81))]
    public static double parseInt(object @string, object radix) { return default(double); }
    [Microsoft.JScript.JSFunctionAttribute((Microsoft.JScript.JSFunctionAttributeEnum)(0), (Microsoft.JScript.JSBuiltin)(82))]
    public static string ScriptEngine() { return default(string); }
    [Microsoft.JScript.JSFunctionAttribute((Microsoft.JScript.JSFunctionAttributeEnum)(0), (Microsoft.JScript.JSBuiltin)(83))]
    public static int ScriptEngineBuildVersion() { return default(int); }
    [Microsoft.JScript.JSFunctionAttribute((Microsoft.JScript.JSFunctionAttributeEnum)(0), (Microsoft.JScript.JSBuiltin)(84))]
    public static int ScriptEngineMajorVersion() { return default(int); }
    [Microsoft.JScript.JSFunctionAttribute((Microsoft.JScript.JSFunctionAttributeEnum)(0), (Microsoft.JScript.JSBuiltin)(85))]
    public static int ScriptEngineMinorVersion() { return default(int); }
    [Microsoft.JScript.JSFunctionAttribute((Microsoft.JScript.JSFunctionAttributeEnum)(0), (Microsoft.JScript.JSBuiltin)(86))]
    [Microsoft.JScript.NotRecommended("unescape")]
    public static string unescape(object @string) { return default(string); }
  }
  public sealed partial class Globals {
    internal Globals() { }
    [System.ContextStaticAttribute]
    public static Microsoft.JScript.Vsa.VsaEngine contextEngine;
    [Microsoft.JScript.JSFunctionAttribute((Microsoft.JScript.JSFunctionAttributeEnum)(16))]
    public static Microsoft.JScript.ArrayObject ConstructArray(params System.Object[] args) { return default(Microsoft.JScript.ArrayObject); }
    public static Microsoft.JScript.ArrayObject ConstructArrayLiteral(System.Object[] args) { return default(Microsoft.JScript.ArrayObject); }
  }
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public partial class GlobalScope : Microsoft.JScript.ActivationObject, System.Reflection.IReflect, System.Runtime.InteropServices.Expando.IExpando {
    public GlobalScope(Microsoft.JScript.GlobalScope parent, Microsoft.JScript.Vsa.VsaEngine engine) { }
    public System.Reflection.FieldInfo AddField(string name) { return default(System.Reflection.FieldInfo); }
    public override object GetDefaultThisObject() { return default(object); }
    public override System.Reflection.FieldInfo GetField(string name, int lexLevel) { return default(System.Reflection.FieldInfo); }
    public override System.Reflection.FieldInfo[] GetFields(System.Reflection.BindingFlags bindingAttr) { return default(System.Reflection.FieldInfo[]); }
    public override Microsoft.JScript.GlobalScope GetGlobalScope() { return default(Microsoft.JScript.GlobalScope); }
    public override System.Reflection.FieldInfo GetLocalField(string name) { return default(System.Reflection.FieldInfo); }
    public override System.Reflection.MemberInfo[] GetMember(string name, System.Reflection.BindingFlags bindingAttr) { return default(System.Reflection.MemberInfo[]); }
    public override System.Reflection.MemberInfo[] GetMembers(System.Reflection.BindingFlags bindingAttr) { return default(System.Reflection.MemberInfo[]); }
    public override System.Reflection.MethodInfo[] GetMethods(System.Reflection.BindingFlags bindingAttr) { return default(System.Reflection.MethodInfo[]); }
    public override System.Reflection.PropertyInfo[] GetProperties(System.Reflection.BindingFlags bindingAttr) { return default(System.Reflection.PropertyInfo[]); }
    System.Reflection.MethodInfo System.Runtime.InteropServices.Expando.IExpando.AddMethod(string name, System.Delegate method) { return default(System.Reflection.MethodInfo); }
    System.Reflection.PropertyInfo System.Runtime.InteropServices.Expando.IExpando.AddProperty(string name) { return default(System.Reflection.PropertyInfo); }
    void System.Runtime.InteropServices.Expando.IExpando.RemoveMember(System.Reflection.MemberInfo m) { }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(320))]
  public partial class Hide : System.Attribute {
    public Hide() { }
  }
  public partial interface IActivationObject {
    object GetDefaultThisObject();
    System.Reflection.FieldInfo GetField(string name, int lexLevel);
    Microsoft.JScript.GlobalScope GetGlobalScope();
    System.Reflection.FieldInfo GetLocalField(string name);
    object GetMemberValue(string name, int lexlevel);
  }
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  [System.Runtime.InteropServices.GuidAttribute("9E2B453C-6EAA-4329-A619-62E4889C8C8A")]
  public partial interface IAuthorServices {
    [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Name="FullTrust")]
    Microsoft.JScript.IParseText GetCodeSense();
    [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Name="FullTrust")]
    Microsoft.JScript.IColorizeText GetColorizer();
  }
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  [System.Runtime.InteropServices.GuidAttribute("DB283E60-7ADB-4cf6-9758-2931893A12FC")]
  public partial interface IColorizeText {
    [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Name="FullTrust")]
    Microsoft.JScript.ITokenEnumerator Colorize(string sourceCode, Microsoft.JScript.SourceState state);
    [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Name="FullTrust")]
    Microsoft.JScript.SourceState GetStateForText(string sourceCode, Microsoft.JScript.SourceState currentState);
  }
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  [System.Runtime.InteropServices.GuidAttribute("AA51516D-C0F2-49fe-9D38-61D20456904C")]
  public partial interface IDebugConvert {
    string BooleanToString(bool value);
    string ByteToString(byte value, int radix);
    string DoubleToDateString(double value);
    string DoubleToString(double value);
    string GetErrorMessageForHR(int hr, Microsoft.JScript.Vsa.IJSVsaEngine engine);
    object GetManagedCharObject(ushort i);
    object GetManagedInt64Object(long i);
    object GetManagedObject(object value);
    object GetManagedUInt64Object(ulong i);
    string Int16ToString(short value, int radix);
    string Int32ToString(int value, int radix);
    string Int64ToString(long value, int radix);
    string RegexpToString(string source, bool ignoreCase, bool global, bool multiline);
    string SByteToString(sbyte value, int radix);
    string SingleToString(float value);
    string StringToPrintable(string source);
    object ToPrimitive(object value, System.TypeCode typeCode, bool truncationPermitted);
    string UInt16ToString(ushort value, int radix);
    string UInt32ToString(uint value, int radix);
    string UInt64ToString(ulong value, int radix);
  }
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  [System.Runtime.InteropServices.GuidAttribute("B370D709-72BD-4696-9825-C4EBADBF98CB")]
  public partial interface IDebugConvert2 {
    string DecimalToString(decimal value);
  }
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  [System.Runtime.InteropServices.GuidAttribute("8E93D770-6168-4b68-B896-A71B74C7076A")]
  public partial interface IDebuggerObject {
    bool HasEnumerableMember(string name);
    bool IsCOMObject();
    bool IsEqual(Microsoft.JScript.IDebuggerObject o);
    bool IsScriptFunction();
    bool IsScriptObject();
  }
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  [System.Runtime.InteropServices.GuidAttribute("59447635-3E26-4873-BF26-05F173B80F5E")]
  public partial interface IDebugScriptScope {
    [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Name="FullTrust")]
    void SetThisValue(object thisValue);
  }
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  [System.Runtime.InteropServices.GuidAttribute("613CC05D-05F4-4969-B369-5AEEF56E32D0")]
  public partial interface IDebugType {
    bool HasInstance(object o);
  }
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  [System.Runtime.InteropServices.GuidAttribute("6DFE759A-CB8B-4ca0-A973-1D04E0BF0B53")]
  public partial interface IDebugVsaScriptCodeItem {
    [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Name="FullTrust")]
    object Evaluate();
    [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Name="FullTrust")]
    bool ParseNamedBreakPoint(string input, out string functionName, out int nargs, out string arguments, out string returnType, out ulong offset);
  }
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  [System.Runtime.InteropServices.GuidAttribute("D1A19408-BB6B-43eb-BB6F-E7CF6AF047D7")]
  public partial interface IDefineEvent {
    object AddEvent(string code, int startLine);
  }
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  [System.Runtime.InteropServices.GuidAttribute("BFF6C97F-0705-4394-88B8-A03A4B8B4CD7")]
  public partial interface IEngine2 {
    [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Name="FullTrust")]
    Microsoft.JScript.Vsa.IJSVsaEngine Clone(System.AppDomain domain);
    bool CompileEmpty();
    [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Name="FullTrust")]
    void ConnectEvents();
    [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Name="FullTrust")]
    void DisconnectEvents();
    System.Reflection.Assembly GetAssembly();
    Microsoft.JScript.IVsaScriptScope GetGlobalScope();
    System.Reflection.Module GetModule();
    [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Name="FullTrust")]
    void InitVsaEngine(string rootMoniker, Microsoft.JScript.Vsa.IJSVsaSite site);
    [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Name="FullTrust")]
    void Interrupt();
    [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Name="FullTrust")]
    void RegisterEventSource(string name);
    [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Name="FullTrust")]
    void Restart();
    [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Name="FullTrust")]
    void Run(System.AppDomain domain);
    [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Name="FullTrust")]
    void RunEmpty();
  }
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  [System.Runtime.InteropServices.GuidAttribute("E93D012C-56BB-4f32-864F-7C75EDA17B14")]
  public partial interface IErrorHandler {
    bool OnCompilerError(Microsoft.JScript.IVsaFullErrorInfo error);
  }
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  [System.Runtime.InteropServices.GuidAttribute("F062C7FB-53BF-4f0d-B0F6-D66C5948E63F")]
  public partial interface IMessageReceiver {
    void Message(string strValue);
  }
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  [System.Runtime.InteropServices.GuidAttribute("E0BCF37B-1C24-451c-AC43-40FF86839117")]
  public partial interface IMethodsCompletionInfo {
  }
  public sealed partial class Import : Microsoft.JScript.AST {
    internal Import() { }
    public static void JScriptImport(string name, Microsoft.JScript.Vsa.VsaEngine engine) { }
  }
  public sealed partial class In : Microsoft.JScript.BinaryOp {
    internal In() { }
    public static bool JScriptIn(object v1, object v2) { return default(bool); }
  }
  public partial interface INeedEngine {
    Microsoft.JScript.Vsa.VsaEngine GetEngine();
    void SetEngine(Microsoft.JScript.Vsa.VsaEngine engine);
  }
  public sealed partial class Instanceof : Microsoft.JScript.BinaryOp {
    internal Instanceof() { }
    public static bool JScriptInstanceof(object v1, object v2) { return default(bool); }
  }
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  [System.Runtime.InteropServices.GuidAttribute("052019B5-704B-4b99-AEF8-25A11A922B2E")]
  public partial interface IObjectCompletionInfo {
  }
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  [System.Runtime.InteropServices.GuidAttribute("C1468187-3DA1-49df-ADF8-5F8600E59EA8")]
  public partial interface IParseText {
    [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Name="FullTrust")]
    void Parse(string code, Microsoft.JScript.IErrorHandler error);
  }
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  [System.Runtime.InteropServices.GuidAttribute("5B807FA1-00CD-46ee-A493-FD80AC944715")]
  public partial interface IRedirectOutput {
    void SetOutputStream(Microsoft.JScript.IMessageReceiver output);
  }
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  [System.Runtime.InteropServices.GuidAttribute("BFF6C980-0705-4394-88B8-A03A4B8B4CD7")]
  [System.Runtime.InteropServices.InterfaceTypeAttribute((System.Runtime.InteropServices.ComInterfaceType)(1))]
  public partial interface ISite2 {
    System.Object[] GetParentChain(object obj);
  }
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  [System.Runtime.InteropServices.GuidAttribute("0F20D5C8-CBDB-4b64-AB7F-10B158407323")]
  public partial interface ITokenColorInfo {
    Microsoft.JScript.TokenColor Color { get; }
    int EndPosition { get; }
    int StartPosition { get; }
  }
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  [System.Runtime.InteropServices.GuidAttribute("556BA9E0-BD6A-4837-89F0-C79B14759181")]
  public partial interface ITokenEnumerator {
    [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Name="FullTrust")]
    Microsoft.JScript.ITokenColorInfo GetNext();
    [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Name="FullTrust")]
    void Reset();
  }
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  [System.Runtime.InteropServices.GuidAttribute("DC3691BC-F188-4b67-8338-326671E0F3F6")]
  public partial interface IVsaFullErrorInfo : Microsoft.JScript.Vsa.IJSVsaError {
    int EndLine { get; }
  }
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  [System.Runtime.InteropServices.GuidAttribute("E0C0FFE8-7eea-4ee5-b7e4-0080c7eb0b74")]
  [System.Runtime.InteropServices.InterfaceTypeAttribute((System.Runtime.InteropServices.ComInterfaceType)(1))]
  public partial interface IVsaScriptCodeItem : Microsoft.JScript.Vsa.IJSVsaCodeItem, Microsoft.JScript.Vsa.IJSVsaItem {
    int StartColumn { get; set; }
    int StartLine { get; set; }
    [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Name="FullTrust")]
    object Execute();
  }
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  [System.Runtime.InteropServices.GuidAttribute("ED4BAE22-2F3C-419a-B487-CF869E716B95")]
  public partial interface IVsaScriptScope : Microsoft.JScript.Vsa.IJSVsaItem {
    Microsoft.JScript.IVsaScriptScope Parent { get; }
    Microsoft.JScript.Vsa.IJSVsaItem AddItem(string itemName, Microsoft.JScript.Vsa.JSVsaItemType type);
    Microsoft.JScript.Vsa.IJSVsaItem CreateDynamicItem(string itemName, Microsoft.JScript.Vsa.JSVsaItemType type);
    Microsoft.JScript.Vsa.IJSVsaItem GetItem(string itemName);
    Microsoft.JScript.Vsa.IJSVsaItem GetItemAtIndex(int index);
    int GetItemCount();
    object GetObject();
    void RemoveItem(Microsoft.JScript.Vsa.IJSVsaItem item);
    void RemoveItem(string itemName);
    void RemoveItemAtIndex(int index);
  }
  public partial interface IWrappedMember {
    object GetWrappedObject();
  }
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  [System.Runtime.InteropServices.GuidAttribute("0E4EFFC0-2387-11d3-B372-00105A98B7CE")]
  public partial class JSAuthor : Microsoft.JScript.IAuthorServices {
    public JSAuthor() { }
    [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Name="FullTrust")]
    public virtual Microsoft.JScript.IParseText GetCodeSense() { return default(Microsoft.JScript.IParseText); }
    [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Name="FullTrust")]
    public virtual Microsoft.JScript.IColorizeText GetColorizer() { return default(Microsoft.JScript.IColorizeText); }
  }
  public enum JSBuiltin {
    Array_concat = 1,
    Array_join = 2,
    Array_pop = 3,
    Array_push = 4,
    Array_reverse = 5,
    Array_shift = 6,
    Array_slice = 7,
    Array_sort = 8,
    Array_splice = 9,
    Array_toLocaleString = 10,
    Array_toString = 11,
    Array_unshift = 12,
    Boolean_toString = 13,
    Boolean_valueOf = 14,
    Date_getDate = 15,
    Date_getDay = 16,
    Date_getFullYear = 17,
    Date_getHours = 18,
    Date_getMilliseconds = 19,
    Date_getMinutes = 20,
    Date_getMonth = 21,
    Date_getSeconds = 22,
    Date_getTime = 23,
    Date_getTimezoneOffset = 24,
    Date_getUTCDate = 25,
    Date_getUTCDay = 26,
    Date_getUTCFullYear = 27,
    Date_getUTCHours = 28,
    Date_getUTCMilliseconds = 29,
    Date_getUTCMinutes = 30,
    Date_getUTCMonth = 31,
    Date_getUTCSeconds = 32,
    Date_getVarDate = 33,
    Date_getYear = 34,
    Date_parse = 35,
    Date_setDate = 36,
    Date_setFullYear = 37,
    Date_setHours = 38,
    Date_setMilliseconds = 40,
    Date_setMinutes = 39,
    Date_setMonth = 41,
    Date_setSeconds = 42,
    Date_setTime = 43,
    Date_setUTCDate = 44,
    Date_setUTCFullYear = 45,
    Date_setUTCHours = 46,
    Date_setUTCMilliseconds = 48,
    Date_setUTCMinutes = 47,
    Date_setUTCMonth = 49,
    Date_setUTCSeconds = 50,
    Date_setYear = 51,
    Date_toDateString = 52,
    Date_toGMTString = 53,
    Date_toLocaleDateString = 54,
    Date_toLocaleString = 55,
    Date_toLocaleTimeString = 56,
    Date_toString = 57,
    Date_toTimeString = 58,
    Date_toUTCString = 59,
    Date_UTC = 60,
    Date_valueOf = 61,
    Enumerator_atEnd = 62,
    Enumerator_item = 63,
    Enumerator_moveFirst = 64,
    Enumerator_moveNext = 65,
    Error_toString = 66,
    Function_apply = 67,
    Function_call = 68,
    Function_toString = 69,
    Global_CollectGarbage = 70,
    Global_decodeURI = 71,
    Global_decodeURIComponent = 72,
    Global_encodeURI = 73,
    Global_encodeURIComponent = 74,
    Global_escape = 75,
    Global_eval = 76,
    Global_GetObject = 77,
    Global_isFinite = 79,
    Global_isNaN = 78,
    Global_parseFloat = 80,
    Global_parseInt = 81,
    Global_ScriptEngine = 82,
    Global_ScriptEngineBuildVersion = 83,
    Global_ScriptEngineMajorVersion = 84,
    Global_ScriptEngineMinorVersion = 85,
    Global_unescape = 86,
    Math_abs = 87,
    Math_acos = 88,
    Math_asin = 89,
    Math_atan = 90,
    Math_atan2 = 91,
    Math_ceil = 92,
    Math_cos = 93,
    Math_exp = 94,
    Math_floor = 95,
    Math_log = 96,
    Math_max = 97,
    Math_min = 98,
    Math_pow = 99,
    Math_random = 100,
    Math_round = 101,
    Math_sin = 102,
    Math_sqrt = 103,
    Math_tan = 104,
    None = 0,
    Number_toExponential = 105,
    Number_toFixed = 106,
    Number_toLocaleString = 107,
    Number_toPrecision = 108,
    Number_toString = 109,
    Number_valueOf = 110,
    Object_hasOwnProperty = 111,
    Object_isPrototypeOf = 112,
    Object_propertyIsEnumerable = 113,
    Object_toLocaleString = 114,
    Object_toString = 115,
    Object_valueOf = 116,
    RegExp_compile = 117,
    RegExp_exec = 118,
    RegExp_test = 119,
    RegExp_toString = 120,
    String_anchor = 121,
    String_big = 122,
    String_blink = 123,
    String_bold = 124,
    String_charAt = 125,
    String_charCodeAt = 126,
    String_concat = 127,
    String_fixed = 128,
    String_fontcolor = 129,
    String_fontsize = 130,
    String_fromCharCode = 131,
    String_indexOf = 132,
    String_italics = 133,
    String_lastIndexOf = 134,
    String_link = 135,
    String_localeCompare = 136,
    String_match = 137,
    String_replace = 138,
    String_search = 139,
    String_slice = 140,
    String_small = 141,
    String_split = 142,
    String_strike = 143,
    String_sub = 144,
    String_substr = 145,
    String_substring = 146,
    String_sup = 147,
    String_toLocaleLowerCase = 148,
    String_toLocaleUpperCase = 149,
    String_toLowerCase = 150,
    String_toString = 151,
    String_toUpperCase = 152,
    String_valueOf = 153,
    VBArray_dimensions = 154,
    VBArray_getItem = 155,
    VBArray_lbound = 156,
    VBArray_toArray = 157,
    VBArray_ubound = 158,
  }
  public sealed partial class JSConstructor : System.Reflection.ConstructorInfo {
    internal JSConstructor() { }
    public override System.Reflection.MethodAttributes Attributes { get { return default(System.Reflection.MethodAttributes); } }
    public override System.Type DeclaringType { get { return default(System.Type); } }
    public override System.Reflection.MemberTypes MemberType { get { return default(System.Reflection.MemberTypes); } }
    public override System.RuntimeMethodHandle MethodHandle { get { return default(System.RuntimeMethodHandle); } }
    public override string Name { get { return default(string); } }
    public override System.Type ReflectedType { get { return default(System.Type); } }
    public override System.Object[] GetCustomAttributes(bool inherit) { return default(System.Object[]); }
    public override System.Object[] GetCustomAttributes(System.Type t, bool inherit) { return default(System.Object[]); }
    public override System.Reflection.MethodImplAttributes GetMethodImplementationFlags() { return default(System.Reflection.MethodImplAttributes); }
    public override System.Reflection.ParameterInfo[] GetParameters() { return default(System.Reflection.ParameterInfo[]); }
    [System.Diagnostics.DebuggerHiddenAttribute]
    [System.Diagnostics.DebuggerStepThroughAttribute]
    public override object Invoke(object obj, System.Reflection.BindingFlags options, System.Reflection.Binder binder, System.Object[] parameters, System.Globalization.CultureInfo culture) { return default(object); }
    [System.Diagnostics.DebuggerHiddenAttribute]
    [System.Diagnostics.DebuggerStepThroughAttribute]
    public override object Invoke(System.Reflection.BindingFlags options, System.Reflection.Binder binder, System.Object[] parameters, System.Globalization.CultureInfo culture) { return default(object); }
    public override bool IsDefined(System.Type type, bool inherit) { return default(bool); }
  }
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Name="FullTrust")]
  public sealed partial class JScriptCodeProvider : System.CodeDom.Compiler.CodeDomProvider {
    public JScriptCodeProvider() { }
    public override string FileExtension { get { return default(string); } }
    public override System.CodeDom.Compiler.ICodeCompiler CreateCompiler() { return default(System.CodeDom.Compiler.ICodeCompiler); }
    public override System.CodeDom.Compiler.ICodeGenerator CreateGenerator() { return default(System.CodeDom.Compiler.ICodeGenerator); }
  }
  public partial class JScriptException : System.ApplicationException, Microsoft.JScript.IVsaFullErrorInfo, Microsoft.JScript.Vsa.IJSVsaError {
    public JScriptException() { }
    public JScriptException(Microsoft.JScript.JSError errorNumber) { }
    protected JScriptException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public JScriptException(string m) { }
    public JScriptException(string m, System.Exception e) { }
    public int Column { get { return default(int); } }
    public string Description { get { return default(string); } }
    public int EndColumn { get { return default(int); } }
    public int EndLine { get { return default(int); } }
    public int ErrorNumber { get { return default(int); } }
    public int Line { get { return default(int); } }
    public string LineText { get { return default(string); } }
    public override string Message { get { return default(string); } }
    string Microsoft.JScript.Vsa.IJSVsaError.Description { get { return default(string); } }
    int Microsoft.JScript.Vsa.IJSVsaError.Number { get { return default(int); } }
    public int Number { get { return default(int); } }
    public int Severity { get { return default(int); } }
    public Microsoft.JScript.Vsa.IJSVsaItem SourceItem { get { return default(Microsoft.JScript.Vsa.IJSVsaItem); } }
    public string SourceMoniker { get { return default(string); } }
    public override string StackTrace { get { return default(string); } }
    public int StartColumn { get { return default(int); } }
    [System.Security.SecurityCriticalAttribute]
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, SerializationFormatter=true)]
    public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
  }
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  [System.Runtime.InteropServices.GuidAttribute("268CA962-2FEF-3152-BA46-E18658B7FA4F")]
  public enum JSError {
    AbstractCannotBePrivate = 1157,
    AbstractCannotBeStatic = 1216,
    AbstractWithBody = 1192,
    ActionNotSupported = 445,
    AmbiguousBindingBecauseOfEval = 1150,
    AmbiguousBindingBecauseOfWith = 1149,
    AmbiguousConstructorCall = 1184,
    AmbiguousMatch = 1183,
    ArrayLengthAssignIncorrect = 5030,
    ArrayLengthConstructIncorrect = 5029,
    ArrayMayBeCopied = 1215,
    AssemblyAttributesMustBeGlobal = 1249,
    AssignmentToReadOnly = 5040,
    BadBreak = 1019,
    BadContinue = 1020,
    BadFunctionDeclaration = 1199,
    BadHexDigit = 1023,
    BadLabel = 1025,
    BadModifierInInterface = 1224,
    BadOctalLiteral = 1242,
    BadPropertyDeclaration = 1200,
    BadReturn = 1018,
    BadSwitch = 1103,
    BadThrow = 1239,
    BadVariableDeclaration = 1198,
    BadWayToLeaveFinally = 1190,
    BaseClassIsExpandoAlready = 1156,
    BooleanExpected = 5010,
    CannotAssignToFunctionResult = 5003,
    CannotBeAbstract = 1212,
    CannotCallSecurityMethodLateBound = 5044,
    CannotChangeVisibility = 1171,
    CannotInstantiateAbstractClass = 1214,
    CannotNestPositionDirective = 1119,
    CannotReturnValueFromVoidFunction = 1182,
    CannotUseNameOfClass = 1124,
    CannotUseStaticSecurityAttribute = 5045,
    CantAssignThis = 5000,
    CantCreateObject = 429,
    CcInvalidElif = 1106,
    CcInvalidElse = 1105,
    CcInvalidEnd = 1104,
    CcInvalidInDebugger = 1256,
    CcOff = 1030,
    CircularDefinition = 1120,
    ClashWithProperty = 1177,
    ClassNotAllowed = 1109,
    ConstructorMayNotHaveReturnType = 1233,
    CustomAttributeUsedMoreThanOnce = 1236,
    DateExpected = 5006,
    DelegatesShouldNotBeExplicitlyConstructed = 1258,
    Deprecated = 1121,
    DifferentReturnTypeFromBase = 1176,
    DoesNotHaveAnAddress = 1203,
    DupDefault = 1027,
    DuplicateMethod = 1251,
    DuplicateName = 1111,
    DuplicateNamedParameter = 5036,
    DupVisibility = 1101,
    EnumeratorExpected = 5015,
    EnumNotAllowed = 1230,
    ErrEOF = 1107,
    ExceptionFromHResult = 6011,
    ExecutablesCannotBeLocalized = 1254,
    ExpandoClassShouldNotImpleEnumerable = 1162,
    ExpandoMustBePublic = 1257,
    ExpandoPrecludesAbstract = 1222,
    ExpandoPrecludesOverride = 1220,
    ExpandoPrecludesStatic = 1250,
    ExpectedAssembly = 1248,
    ExpressionExpected = 1195,
    FileNotFound = 53,
    FinalPrecludesAbstract = 1209,
    FractionOutOfRange = 5026,
    FuncEvalAborted = 6000,
    FuncEvalBadLocation = 6007,
    FuncEvalBadThreadNotStarted = 6005,
    FuncEvalBadThreadState = 6004,
    FuncEvalThreadSleepWaitJoin = 6003,
    FuncEvalThreadSuspended = 6002,
    FuncEvalTimedout = 6001,
    FuncEvalWebMethod = 6008,
    FunctionExpected = 5002,
    GetAndSetAreInconsistent = 1142,
    HidesAbstractInBase = 1172,
    HidesParentMember = 1170,
    IllegalAssignment = 5008,
    IllegalChar = 1014,
    IllegalEval = 5033,
    IllegalParamArrayAttribute = 1221,
    IllegalUseOfSuper = 1189,
    IllegalUseOfThis = 1122,
    IllegalVisibility = 1102,
    ImplicitlyReferencedAssemblyNotFound = 1259,
    ImpossibleConversion = 1208,
    IncompatibleAssemblyReference = 1267,
    IncompatibleVisibility = 1108,
    IncorrectNumberOfIndices = 5042,
    InstanceNotAccessibleFromStatic = 1243,
    InterfaceIllegalInInterface = 1227,
    InternalError = 51,
    InvalidAssemblyKeyFile = 1268,
    InvalidBaseTypeForEnum = 1213,
    InvalidCall = 5,
    InvalidCustomAttribute = 1143,
    InvalidCustomAttributeArgument = 1144,
    InvalidCustomAttributeClassOrCtor = 1146,
    InvalidCustomAttributeTarget = 1231,
    InvalidDebugDirective = 1235,
    InvalidElse = 1034,
    InvalidImport = 1229,
    InvalidLanguageOption = 1179,
    InvalidPositionDirective = 1114,
    InvalidPrototype = 5023,
    InvalidResource = 1262,
    ItemNotAllowedOnExpandoClass = 1152,
    KeywordUsedAsIdentifier = 1137,
    MemberInitializerCannotContainFuncExpr = 1270,
    MemberTypeCLSCompliantMismatch = 1265,
    MethodClashOnExpandoSuperClass = 1155,
    MethodInBaseIsNotVirtual = 1174,
    MethodNotAllowedOnExpandoClass = 1153,
    MissingConstructForAttributes = 1160,
    MissingNameParameter = 5037,
    MoreNamedParametersThanArguments = 5038,
    MustBeEOL = 1115,
    MustImplementMethod = 1128,
    MustProvideNameForNamedParameter = 5035,
    NeedArrayObject = 5031,
    NeedCompileTimeConstant = 1110,
    NeedInstance = 1210,
    NeedInterface = 1129,
    NeedObject = 424,
    NeedType = 1112,
    NestedInstanceTypeCannotBeExtendedByStatic = 1237,
    NewNotSpecifiedInMethodDeclaration = 1173,
    NoAt = 1032,
    NoCatch = 1033,
    NoCcEnd = 1029,
    NoColon = 1003,
    NoComma = 1100,
    NoCommaOrTypeDefinitionError = 1191,
    NoCommentEnd = 1016,
    NoConstructor = 5032,
    NoEqual = 1011,
    NoError = 0,
    NoFuncEvalAllowed = 6006,
    NoIdentifier = 1010,
    NoLabel = 1026,
    NoLeftCurly = 1008,
    NoLeftParen = 1005,
    NoMemberIdentifier = 1028,
    NoMethodInBaseToNew = 1175,
    NoMethodInBaseToOverride = 1180,
    NonCLSCompliantMember = 1163,
    NonCLSCompliantType = 1264,
    NonClsException = 5046,
    NonStaticWithTypeName = 1245,
    NonSupportedInDebugger = 5039,
    NoRightBracket = 1007,
    NoRightBracketOrComma = 1194,
    NoRightCurly = 1009,
    NoRightParen = 1006,
    NoRightParenOrComma = 1193,
    NoSemicolon = 1004,
    NoSuchMember = 1151,
    NoSuchStaticMember = 1246,
    NoSuchType = 1241,
    NotAccessible = 1123,
    NotAllowedInSuperConstructorCall = 1140,
    NotAnExpandoFunction = 1252,
    NotCollection = 451,
    NotConst = 1031,
    NotDeletable = 1164,
    NotIndexable = 1158,
    NotInsideClass = 1113,
    NotMeantToBeCalledDirectly = 1141,
    NotOKToCallSuper = 1188,
    NotValidForConstructor = 1181,
    NotValidVersionString = 1253,
    NotYetImplemented = 5034,
    NoVarInEnum = 1228,
    NoWhile = 1024,
    NumberExpected = 5001,
    ObjectExpected = 5007,
    OctalLiteralsAreDeprecated = 1186,
    OLENoPropOrMethod = 438,
    OnlyClassesAllowed = 1161,
    OnlyClassesAndPackagesAllowed = 1234,
    OutOfMemory = 7,
    OutOfStack = 28,
    OverrideAndHideUsedTogether = 1178,
    PackageExpected = 1165,
    PackageInWrongContext = 1232,
    ParamListNotLast = 1240,
    PossibleBadConversion = 1260,
    PossibleBadConversionFromString = 1261,
    PrecisionOutOfRange = 5027,
    PropertyLevelAttributesMustBeOnGetter = 1238,
    RefParamsNonSupportedInDebugger = 5043,
    RegExpExpected = 5016,
    RegExpSyntax = 5017,
    ShouldBeAbstract = 1223,
    SideEffectsDisallowed = 6012,
    StaticIsAlreadyFinal = 1217,
    StaticMethodsCannotHide = 1219,
    StaticMethodsCannotOverride = 1218,
    StaticMissingInStaticInit = 1159,
    StaticRequiresTypeName = 1244,
    StaticVarNotAvailable = 6009,
    StringConcatIsSlow = 1255,
    StringExpected = 5005,
    SuperClassConstructorNotAccessible = 1185,
    SuspectAssignment = 1206,
    SuspectLoopCondition = 1247,
    SuspectSemicolon = 1207,
    SyntaxError = 1002,
    TooFewParameters = 1204,
    TooManyParameters = 1148,
    TooManyTokensSkipped = 1197,
    TypeAssemblyCLSCompliantMismatch = 1266,
    TypeCannotBeExtended = 1134,
    TypeMismatch = 13,
    TypeNameTooLong = 1269,
    TypeObjectNotAvailable = 6010,
    UncaughtException = 5022,
    UndeclaredVariable = 1135,
    UndefinedIdentifier = 5009,
    UnexpectedSemicolon = 1196,
    UnreachableCatch = 1133,
    UnterminatedString = 1015,
    URIDecodeError = 5025,
    URIEncodeError = 5024,
    UselessAssignment = 1205,
    UselessExpression = 1169,
    VariableLeftUninitialized = 1136,
    VariableMightBeUnitialized = 1187,
    VarIllegalInInterface = 1226,
    VBArrayExpected = 5013,
    WriteOnlyProperty = 5041,
    WrongDirective = 1118,
    WrongUseOfAddressOf = 1263,
  }
  public abstract partial class JSField : System.Reflection.FieldInfo {
    protected JSField() { }
    public override System.Reflection.FieldAttributes Attributes { get { return default(System.Reflection.FieldAttributes); } }
    public override System.Type DeclaringType { get { return default(System.Type); } }
    public override System.RuntimeFieldHandle FieldHandle { get { return default(System.RuntimeFieldHandle); } }
    public override System.Type FieldType { get { return default(System.Type); } }
    public override System.Reflection.MemberTypes MemberType { get { return default(System.Reflection.MemberTypes); } }
    public override string Name { get { return default(string); } }
    public override System.Type ReflectedType { get { return default(System.Type); } }
    public override System.Object[] GetCustomAttributes(bool inherit) { return default(System.Object[]); }
    public override System.Object[] GetCustomAttributes(System.Type t, bool inherit) { return default(System.Object[]); }
    public override bool IsDefined(System.Type type, bool inherit) { return default(bool); }
  }
  public sealed partial class JSFieldInfo : System.Reflection.FieldInfo {
    internal JSFieldInfo() { }
    public override System.Reflection.FieldAttributes Attributes { get { return default(System.Reflection.FieldAttributes); } }
    public override System.Type DeclaringType { get { return default(System.Type); } }
    public override System.RuntimeFieldHandle FieldHandle { get { return default(System.RuntimeFieldHandle); } }
    public override System.Type FieldType { get { return default(System.Type); } }
    public override System.Reflection.MemberTypes MemberType { get { return default(System.Reflection.MemberTypes); } }
    public override string Name { get { return default(string); } }
    public override System.Type ReflectedType { get { return default(System.Type); } }
    public override System.Object[] GetCustomAttributes(bool inherit) { return default(System.Object[]); }
    public override System.Object[] GetCustomAttributes(System.Type t, bool inherit) { return default(System.Object[]); }
    public override object GetValue(object obj) { return default(object); }
    public override bool IsDefined(System.Type type, bool inherit) { return default(bool); }
    public new void SetValue(object obj, object value) { }
    public override void SetValue(object obj, object value, System.Reflection.BindingFlags invokeAttr, System.Reflection.Binder binder, System.Globalization.CultureInfo culture) { }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(96))]
  public partial class JSFunctionAttribute : System.Attribute {
    public JSFunctionAttribute(Microsoft.JScript.JSFunctionAttributeEnum value) { }
    public JSFunctionAttribute(Microsoft.JScript.JSFunctionAttributeEnum value, Microsoft.JScript.JSBuiltin builtinFunction) { }
    public Microsoft.JScript.JSFunctionAttributeEnum GetAttributeValue() { return default(Microsoft.JScript.JSFunctionAttributeEnum); }
  }
  [System.FlagsAttribute]
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  [System.Runtime.InteropServices.GuidAttribute("BA5ED019-F669-3C35-93AC-3ABF776B62B3")]
  public enum JSFunctionAttributeEnum {
    ClassicFunction = 35,
    ClassicNestedFunction = 47,
    HasArguments = 1,
    HasEngine = 32,
    HasStackFrame = 8,
    HasThisObject = 2,
    HasVarArgs = 16,
    IsExpandoMethod = 64,
    IsInstanceNestedClassConstructor = 128,
    IsNested = 4,
    NestedFunction = 44,
    None = 0,
  }
  public sealed partial class JSLocalField : Microsoft.JScript.JSVariableField {
    public JSLocalField(string name, System.RuntimeTypeHandle handle, int slotNumber) { }
    public override System.Type FieldType { get { return default(System.Type); } }
    public override object GetValue(object obj) { return default(object); }
    public override void SetValue(object obj, object value, System.Reflection.BindingFlags invokeAttr, System.Reflection.Binder binder, System.Globalization.CultureInfo locale) { }
  }
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  [System.Runtime.InteropServices.GuidAttribute("561AC104-8869-4368-902F-4E0D7DDEDDDD")]
  public abstract partial class JSMethod : System.Reflection.MethodInfo {
    internal JSMethod() { }
    public override System.Reflection.MemberTypes MemberType { get { return default(System.Reflection.MemberTypes); } }
    public override System.RuntimeMethodHandle MethodHandle { get { return default(System.RuntimeMethodHandle); } }
    public override System.Type ReflectedType { get { return default(System.Type); } }
    public override System.Reflection.ICustomAttributeProvider ReturnTypeCustomAttributes { get { return default(System.Reflection.ICustomAttributeProvider); } }
    public override System.Reflection.MethodInfo GetBaseDefinition() { return default(System.Reflection.MethodInfo); }
    public override System.Object[] GetCustomAttributes(bool inherit) { return default(System.Object[]); }
    public override System.Object[] GetCustomAttributes(System.Type t, bool inherit) { return default(System.Object[]); }
    public override System.Reflection.MethodImplAttributes GetMethodImplementationFlags() { return default(System.Reflection.MethodImplAttributes); }
    [System.Diagnostics.DebuggerHiddenAttribute]
    [System.Diagnostics.DebuggerStepThroughAttribute]
    public override object Invoke(object obj, System.Reflection.BindingFlags options, System.Reflection.Binder binder, System.Object[] parameters, System.Globalization.CultureInfo culture) { return default(object); }
    public sealed override bool IsDefined(System.Type type, bool inherit) { return default(bool); }
  }
  public sealed partial class JSMethodInfo : System.Reflection.MethodInfo {
    internal JSMethodInfo() { }
    public override System.Reflection.MethodAttributes Attributes { get { return default(System.Reflection.MethodAttributes); } }
    public override System.Type DeclaringType { get { return default(System.Type); } }
    public override System.Reflection.MemberTypes MemberType { get { return default(System.Reflection.MemberTypes); } }
    public override System.RuntimeMethodHandle MethodHandle { get { return default(System.RuntimeMethodHandle); } }
    public override string Name { get { return default(string); } }
    public override System.Type ReflectedType { get { return default(System.Type); } }
    public override System.Type ReturnType { get { return default(System.Type); } }
    public override System.Reflection.ICustomAttributeProvider ReturnTypeCustomAttributes { get { return default(System.Reflection.ICustomAttributeProvider); } }
    public override System.Reflection.MethodInfo GetBaseDefinition() { return default(System.Reflection.MethodInfo); }
    public sealed override System.Object[] GetCustomAttributes(bool inherit) { return default(System.Object[]); }
    public sealed override System.Object[] GetCustomAttributes(System.Type type, bool inherit) { return default(System.Object[]); }
    public override System.Reflection.MethodImplAttributes GetMethodImplementationFlags() { return default(System.Reflection.MethodImplAttributes); }
    public override System.Reflection.ParameterInfo[] GetParameters() { return default(System.Reflection.ParameterInfo[]); }
    [System.Diagnostics.DebuggerHiddenAttribute]
    [System.Diagnostics.DebuggerStepThroughAttribute]
    public override object Invoke(object obj, System.Reflection.BindingFlags options, System.Reflection.Binder binder, System.Object[] parameters, System.Globalization.CultureInfo culture) { return default(object); }
    public sealed override bool IsDefined(System.Type type, bool inherit) { return default(bool); }
    public override string ToString() { return default(string); }
  }
  public partial class JSObject : Microsoft.JScript.ScriptObject, System.Collections.IEnumerable, System.Reflection.IReflect, System.Runtime.InteropServices.Expando.IExpando {
    protected System.Collections.ArrayList field_table;
    public JSObject() { }
    public System.Reflection.FieldInfo AddField(string name) { return default(System.Reflection.FieldInfo); }
    public override System.Reflection.MemberInfo[] GetMember(string name, System.Reflection.BindingFlags bindingAttr) { return default(System.Reflection.MemberInfo[]); }
    public override System.Reflection.MemberInfo[] GetMembers(System.Reflection.BindingFlags bindingAttr) { return default(System.Reflection.MemberInfo[]); }
    public void SetMemberValue2(string name, object value) { }
    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { return default(System.Collections.IEnumerator); }
    System.Reflection.MethodInfo System.Runtime.InteropServices.Expando.IExpando.AddMethod(string name, System.Delegate method) { return default(System.Reflection.MethodInfo); }
    System.Reflection.PropertyInfo System.Runtime.InteropServices.Expando.IExpando.AddProperty(string name) { return default(System.Reflection.PropertyInfo); }
    void System.Runtime.InteropServices.Expando.IExpando.RemoveMember(System.Reflection.MemberInfo m) { }
    public override string ToString() { return default(string); }
  }
  [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Name="FullTrust")]
  public partial class JSParser {
    public JSParser(Microsoft.JScript.Context context) { }
    public Microsoft.JScript.ScriptBlock Parse() { return default(Microsoft.JScript.ScriptBlock); }
    public Microsoft.JScript.Block ParseEvalBody() { return default(Microsoft.JScript.Block); }
  }
  public partial class JSPrototypeObject : Microsoft.JScript.JSObject {
    internal JSPrototypeObject() { }
    public object constructor;
  }
  public sealed partial class JSScanner {
    public JSScanner() { }
    public JSScanner(Microsoft.JScript.Context sourceContext) { }
    public int GetCurrentLine() { return default(int); }
    public int GetCurrentPosition(bool absolute) { return default(int); }
    public void GetNextToken() { }
    public string GetSourceCode() { return default(string); }
    public int GetStartLinePosition() { return default(int); }
    public string GetStringLiteral() { return default(string); }
    public bool GotEndOfLine() { return default(bool); }
    public static bool IsKeyword(Microsoft.JScript.JSToken token) { return default(bool); }
    public static bool IsOperator(Microsoft.JScript.JSToken token) { return default(bool); }
    public void SetAuthoringMode(bool mode) { }
    public void SetSource(Microsoft.JScript.Context sourceContext) { }
    public int SkipMultiLineComment() { return default(int); }
  }
  public enum JSToken {
    Abstract = 15,
    AccessField = 38,
    Assert = 104,
    Assign = 69,
    BitwiseAnd = 52,
    BitwiseAndAssign = 74,
    BitwiseNot = 40,
    BitwiseOr = 50,
    BitwiseOrAssign = 75,
    BitwiseXor = 51,
    BitwiseXorAssign = 76,
    Boolean = 105,
    Break = 6,
    Byte = 106,
    Case = 84,
    Catch = 85,
    Char = 107,
    Class = 24,
    Colon = 82,
    Comma = 83,
    Comment = 102,
    ConditionalIf = 81,
    Const = 23,
    Continue = 5,
    Debugger = 86,
    Decimal = 108,
    Decrement = 45,
    Default = 87,
    Delete = 41,
    Divide = 65,
    DivideAssign = 73,
    Do = 3,
    Double = 109,
    DoubleColon = 110,
    Else = 88,
    EndOfFile = 0,
    EndOfLine = 132,
    Ensure = 112,
    Enum = 111,
    Equal = 53,
    Event = 21,
    Export = 89,
    Extends = 90,
    False = 30,
    Final = 20,
    Finally = 91,
    FirstBinaryOp = 46,
    FirstOp = 39,
    Float = 113,
    For = 2,
    Function = 25,
    Get = 92,
    Goto = 114,
    GreaterThan = 57,
    GreaterThanEqual = 60,
    Identifier = 32,
    If = 1,
    Implements = 93,
    Import = 8,
    In = 68,
    Increment = 44,
    Instanceof = 67,
    Int = 115,
    IntegerLiteral = 34,
    Interface = 94,
    Internal = 14,
    Invariant = 116,
    LastAssign = 80,
    LastBinaryOp = 80,
    LastOp = 83,
    LastPPOperator = 66,
    LeftBracket = 37,
    LeftCurly = 26,
    LeftParen = 36,
    LeftShift = 61,
    LeftShiftAssign = 78,
    LessThan = 58,
    LessThanEqual = 59,
    LogicalAnd = 49,
    LogicalNot = 39,
    LogicalOr = 48,
    Long = 117,
    Minus = 47,
    MinusAssign = 71,
    Modulo = 66,
    ModuloAssign = 77,
    Multiply = 64,
    MultiplyAssign = 72,
    Namespace = 118,
    Native = 119,
    New = 95,
    None = -1,
    NotEqual = 54,
    Null = 28,
    NumericLiteral = 35,
    Package = 13,
    ParamArray = 126,
    Plus = 46,
    PlusAssign = 70,
    PreProcessDirective = 133,
    PreProcessorConstant = 101,
    Private = 18,
    Protected = 19,
    Public = 16,
    Require = 120,
    Return = 7,
    RightBracket = 100,
    RightCurly = 99,
    RightParen = 98,
    RightShift = 62,
    RightShiftAssign = 79,
    Sbyte = 121,
    Semicolon = 27,
    Set = 96,
    Short = 122,
    Static = 17,
    StrictEqual = 55,
    StrictNotEqual = 56,
    StringLiteral = 33,
    Super = 97,
    Switch = 10,
    Synchronized = 123,
    This = 31,
    Throw = 11,
    Throws = 125,
    Transient = 124,
    True = 29,
    Try = 12,
    Typeof = 43,
    Uint = 129,
    Ulong = 130,
    UnsignedRightShift = 63,
    UnsignedRightShiftAssign = 80,
    UnterminatedComment = 103,
    Use = 131,
    Ushort = 128,
    Var = 22,
    Void = 42,
    Volatile = 127,
    While = 4,
    With = 9,
  }
  public abstract partial class JSVariableField : Microsoft.JScript.JSField {
    internal JSVariableField() { }
    public override System.Reflection.FieldAttributes Attributes { get { return default(System.Reflection.FieldAttributes); } }
    public override System.Type DeclaringType { get { return default(System.Type); } }
    public override System.Type FieldType { get { return default(System.Type); } }
    public override string Name { get { return default(string); } }
    public override System.Object[] GetCustomAttributes(bool inherit) { return default(System.Object[]); }
  }
  public sealed partial class LateBinding {
    public object obj;
    public LateBinding(string name) { }
    public LateBinding(string name, object obj) { }
    [System.Diagnostics.DebuggerHiddenAttribute]
    [System.Diagnostics.DebuggerStepThroughAttribute]
    public object Call(System.Object[] arguments, bool construct, bool brackets, Microsoft.JScript.Vsa.VsaEngine engine) { return default(object); }
    [System.Diagnostics.DebuggerHiddenAttribute]
    [System.Diagnostics.DebuggerStepThroughAttribute]
    public static object CallValue(object thisob, object val, System.Object[] arguments, bool construct, bool brackets, Microsoft.JScript.Vsa.VsaEngine engine) { return default(object); }
    [System.Diagnostics.DebuggerHiddenAttribute]
    [System.Diagnostics.DebuggerStepThroughAttribute]
    public static object CallValue2(object val, object thisob, System.Object[] arguments, bool construct, bool brackets, Microsoft.JScript.Vsa.VsaEngine engine) { return default(object); }
    public bool Delete() { return default(bool); }
    public static bool DeleteMember(object obj, string name) { return default(bool); }
    [System.Diagnostics.DebuggerHiddenAttribute]
    [System.Diagnostics.DebuggerStepThroughAttribute]
    public object GetNonMissingValue() { return default(object); }
    [System.Diagnostics.DebuggerHiddenAttribute]
    [System.Diagnostics.DebuggerStepThroughAttribute]
    public object GetValue2() { return default(object); }
    [System.Diagnostics.DebuggerHiddenAttribute]
    [System.Diagnostics.DebuggerStepThroughAttribute]
    public static void SetIndexedPropertyValueStatic(object obj, System.Object[] arguments, object value) { }
    [System.Diagnostics.DebuggerHiddenAttribute]
    [System.Diagnostics.DebuggerStepThroughAttribute]
    public void SetValue(object value) { }
  }
  public sealed partial class LenientArrayPrototype : Microsoft.JScript.ArrayPrototype {
    internal LenientArrayPrototype() { }
    public object concat;
    public object constructor;
    public object join;
    public object pop;
    public object push;
    public object reverse;
    public object shift;
    public object slice;
    public object sort;
    public object splice;
    public object toLocaleString;
    public object toString;
    public object unshift;
  }
  public sealed partial class LenientBooleanPrototype : Microsoft.JScript.BooleanPrototype {
    internal LenientBooleanPrototype() : base (default(Microsoft.JScript.ObjectPrototype), default(System.Type)) { }
    public object constructor;
    public object toString;
    public object valueOf;
  }
  public sealed partial class LenientDateConstructor : Microsoft.JScript.DateConstructor {
    internal LenientDateConstructor() { }
    public object parse;
    public object UTC;
  }
  public sealed partial class LenientDatePrototype : Microsoft.JScript.DatePrototype {
    internal LenientDatePrototype() { }
    public object constructor;
    public object getDate;
    public object getDay;
    public object getFullYear;
    public object getHours;
    public object getMilliseconds;
    public object getMinutes;
    public object getMonth;
    public object getSeconds;
    public object getTime;
    public object getTimezoneOffset;
    public object getUTCDate;
    public object getUTCDay;
    public object getUTCFullYear;
    public object getUTCHours;
    public object getUTCMilliseconds;
    public object getUTCMinutes;
    public object getUTCMonth;
    public object getUTCSeconds;
    public object getVarDate;
    [Microsoft.JScript.NotRecommended("getYear")]
    public object getYear;
    public object setDate;
    public object setFullYear;
    public object setHours;
    public object setMilliseconds;
    public object setMinutes;
    public object setMonth;
    public object setSeconds;
    public object setTime;
    public object setUTCDate;
    public object setUTCFullYear;
    public object setUTCHours;
    public object setUTCMilliseconds;
    public object setUTCMinutes;
    public object setUTCMonth;
    public object setUTCSeconds;
    [Microsoft.JScript.NotRecommended("setYear")]
    public object setYear;
    public object toDateString;
    [Microsoft.JScript.NotRecommended("toGMTString")]
    public object toGMTString;
    public object toLocaleDateString;
    public object toLocaleString;
    public object toLocaleTimeString;
    public object toString;
    public object toTimeString;
    public object toUTCString;
    public object valueOf;
  }
  public sealed partial class LenientEnumeratorPrototype : Microsoft.JScript.EnumeratorPrototype {
    internal LenientEnumeratorPrototype() { }
    public object atEnd;
    public object constructor;
    public object item;
    public object moveFirst;
    public object moveNext;
  }
  public sealed partial class LenientErrorPrototype : Microsoft.JScript.ErrorPrototype {
    internal LenientErrorPrototype() { }
    public object constructor;
    public new object name;
    public object toString;
  }
  public sealed partial class LenientFunctionPrototype : Microsoft.JScript.FunctionPrototype {
    internal LenientFunctionPrototype() { }
    public object apply;
    public object call;
    public object constructor;
    public object toString;
  }
  public sealed partial class LenientGlobalObject : Microsoft.JScript.GlobalObject {
    internal LenientGlobalObject() { }
    public object boolean;
    public object @byte;
    public object @char;
    public object @decimal;
    public object decodeURI;
    public object decodeURIComponent;
    public object @double;
    public object encodeURI;
    public object encodeURIComponent;
    [Microsoft.JScript.NotRecommended("escape")]
    public object escape;
    public object eval;
    public object @float;
    public object GetObject;
    public new object Infinity;
    public object @int;
    public object isFinite;
    public object isNaN;
    public object @long;
    public new object NaN;
    public object parseFloat;
    public object parseInt;
    public object @sbyte;
    public object ScriptEngine;
    public object ScriptEngineBuildVersion;
    public object ScriptEngineMajorVersion;
    public object ScriptEngineMinorVersion;
    public object @short;
    public object @uint;
    public object @ulong;
    public new object undefined;
    [Microsoft.JScript.NotRecommended("unescape")]
    public object unescape;
    public object @ushort;
    public object @void;
    public new object ActiveXObject { get { return default(object); } set { } }
    public new object Array { get { return default(object); } set { } }
    public new object Boolean { get { return default(object); } set { } }
    public new object Date { get { return default(object); } set { } }
    public new object Enumerator { get { return default(object); } set { } }
    public new object Error { get { return default(object); } set { } }
    public new object EvalError { get { return default(object); } set { } }
    public new object Function { get { return default(object); } set { } }
    public new object Math { get { return default(object); } set { } }
    public new object Number { get { return default(object); } set { } }
    public new object Object { get { return default(object); } set { } }
    public new object RangeError { get { return default(object); } set { } }
    public new object ReferenceError { get { return default(object); } set { } }
    public new object RegExp { get { return default(object); } set { } }
    public new object String { get { return default(object); } set { } }
    public new object SyntaxError { get { return default(object); } set { } }
    public new object TypeError { get { return default(object); } set { } }
    public new object URIError { get { return default(object); } set { } }
    public new object VBArray { get { return default(object); } set { } }
  }
  public sealed partial class LenientMathObject : Microsoft.JScript.MathObject {
    internal LenientMathObject() { }
    public object abs;
    public object acos;
    public object asin;
    public object atan;
    public object atan2;
    public object ceil;
    public object cos;
    public const double E = 2.7182818284590451;
    public object exp;
    public object floor;
    public const double LN10 = 2.3025850929940459;
    public const double LN2 = 0.69314718055994529;
    public object log;
    public const double LOG10E = 0.43429448190325182;
    public const double LOG2E = 1.4426950408889634;
    public object max;
    public object min;
    public const double PI = 3.1415926535897931;
    public object pow;
    public object random;
    public object round;
    public object sin;
    public object sqrt;
    public const double SQRT1_2 = 0.70710678118654757;
    public const double SQRT2 = 1.4142135623730951;
    public object tan;
  }
  public sealed partial class LenientNumberPrototype : Microsoft.JScript.NumberPrototype {
    internal LenientNumberPrototype() { }
    public object constructor;
    public object toExponential;
    public object toFixed;
    public object toLocaleString;
    public object toPrecision;
    public object toString;
    public object valueOf;
  }
  public partial class LenientObjectPrototype : Microsoft.JScript.ObjectPrototype {
    internal LenientObjectPrototype() { }
    public object constructor;
    public object hasOwnProperty;
    public object isPrototypeOf;
    public object propertyIsEnumerable;
    public object toLocaleString;
    public object toString;
    public object valueOf;
  }
  public sealed partial class LenientRegExpPrototype : Microsoft.JScript.RegExpPrototype {
    internal LenientRegExpPrototype() { }
    public object compile;
    public object constructor;
    public object exec;
    public object test;
    public object toString;
  }
  public partial class LenientStringConstructor : Microsoft.JScript.StringConstructor {
    internal LenientStringConstructor() { }
    public object fromCharCode;
  }
  public sealed partial class LenientStringPrototype : Microsoft.JScript.StringPrototype {
    internal LenientStringPrototype() { }
    public object anchor;
    public object big;
    public object blink;
    public object bold;
    public object charAt;
    public object charCodeAt;
    public object concat;
    public object constructor;
    public object @fixed;
    public object fontcolor;
    public object fontsize;
    public object indexOf;
    public object italics;
    public object lastIndexOf;
    public object link;
    public object localeCompare;
    public object match;
    public object replace;
    public object search;
    public object slice;
    public object small;
    public object split;
    public object strike;
    public object sub;
    [Microsoft.JScript.NotRecommended("substr")]
    public object substr;
    public object substring;
    public object sup;
    public object toLocaleLowerCase;
    public object toLocaleUpperCase;
    public object toLowerCase;
    public object toString;
    public object toUpperCase;
    public object valueOf;
  }
  public sealed partial class LenientVBArrayPrototype : Microsoft.JScript.VBArrayPrototype {
    internal LenientVBArrayPrototype() { }
    public object constructor;
    public object dimensions;
    public object getItem;
    public object lbound;
    public object toArray;
    public object ubound;
  }
  public partial class MathObject : Microsoft.JScript.JSObject {
    internal MathObject() { }
    public const double E = 2.7182818284590451;
    public const double LN10 = 2.3025850929940459;
    public const double LN2 = 0.69314718055994529;
    public const double LOG10E = 0.43429448190325182;
    public const double LOG2E = 1.4426950408889634;
    public const double PI = 3.1415926535897931;
    public const double SQRT1_2 = 0.70710678118654757;
    public const double SQRT2 = 1.4142135623730951;
    [Microsoft.JScript.JSFunctionAttribute((Microsoft.JScript.JSFunctionAttributeEnum)(0), (Microsoft.JScript.JSBuiltin)(87))]
    public static double abs(double d) { return default(double); }
    [Microsoft.JScript.JSFunctionAttribute((Microsoft.JScript.JSFunctionAttributeEnum)(0), (Microsoft.JScript.JSBuiltin)(88))]
    public static double acos(double x) { return default(double); }
    [Microsoft.JScript.JSFunctionAttribute((Microsoft.JScript.JSFunctionAttributeEnum)(0), (Microsoft.JScript.JSBuiltin)(89))]
    public static double asin(double x) { return default(double); }
    [Microsoft.JScript.JSFunctionAttribute((Microsoft.JScript.JSFunctionAttributeEnum)(0), (Microsoft.JScript.JSBuiltin)(90))]
    public static double atan(double x) { return default(double); }
    [Microsoft.JScript.JSFunctionAttribute((Microsoft.JScript.JSFunctionAttributeEnum)(0), (Microsoft.JScript.JSBuiltin)(91))]
    public static double atan2(double dy, double dx) { return default(double); }
    [Microsoft.JScript.JSFunctionAttribute((Microsoft.JScript.JSFunctionAttributeEnum)(0), (Microsoft.JScript.JSBuiltin)(92))]
    public static double ceil(double x) { return default(double); }
    [Microsoft.JScript.JSFunctionAttribute((Microsoft.JScript.JSFunctionAttributeEnum)(0), (Microsoft.JScript.JSBuiltin)(93))]
    public static double cos(double x) { return default(double); }
    [Microsoft.JScript.JSFunctionAttribute((Microsoft.JScript.JSFunctionAttributeEnum)(0), (Microsoft.JScript.JSBuiltin)(94))]
    public static double exp(double x) { return default(double); }
    [Microsoft.JScript.JSFunctionAttribute((Microsoft.JScript.JSFunctionAttributeEnum)(0), (Microsoft.JScript.JSBuiltin)(95))]
    public static double floor(double x) { return default(double); }
    [Microsoft.JScript.JSFunctionAttribute((Microsoft.JScript.JSFunctionAttributeEnum)(0), (Microsoft.JScript.JSBuiltin)(96))]
    public static double log(double x) { return default(double); }
    [Microsoft.JScript.JSFunctionAttribute((Microsoft.JScript.JSFunctionAttributeEnum)(16), (Microsoft.JScript.JSBuiltin)(97))]
    public static double max(object x, object y, params System.Object[] args) { return default(double); }
    [Microsoft.JScript.JSFunctionAttribute((Microsoft.JScript.JSFunctionAttributeEnum)(16), (Microsoft.JScript.JSBuiltin)(98))]
    public static double min(object x, object y, params System.Object[] args) { return default(double); }
    [Microsoft.JScript.JSFunctionAttribute((Microsoft.JScript.JSFunctionAttributeEnum)(0), (Microsoft.JScript.JSBuiltin)(99))]
    public static double pow(double dx, double dy) { return default(double); }
    [Microsoft.JScript.JSFunctionAttribute((Microsoft.JScript.JSFunctionAttributeEnum)(0), (Microsoft.JScript.JSBuiltin)(100))]
    public static double random() { return default(double); }
    [Microsoft.JScript.JSFunctionAttribute((Microsoft.JScript.JSFunctionAttributeEnum)(0), (Microsoft.JScript.JSBuiltin)(101))]
    public static double round(double d) { return default(double); }
    [Microsoft.JScript.JSFunctionAttribute((Microsoft.JScript.JSFunctionAttributeEnum)(0), (Microsoft.JScript.JSBuiltin)(102))]
    public static double sin(double x) { return default(double); }
    [Microsoft.JScript.JSFunctionAttribute((Microsoft.JScript.JSFunctionAttributeEnum)(0), (Microsoft.JScript.JSBuiltin)(103))]
    public static double sqrt(double x) { return default(double); }
    [Microsoft.JScript.JSFunctionAttribute((Microsoft.JScript.JSFunctionAttributeEnum)(0), (Microsoft.JScript.JSBuiltin)(104))]
    public static double tan(double x) { return default(double); }
  }
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  [System.Runtime.InteropServices.GuidAttribute("98A3BF0A-1B56-4f32-ACE0-594FEB27EC48")]
  public partial interface MemberInfoInitializer {
    Microsoft.JScript.COMMemberInfo GetCOMMemberInfo();
    void Initialize(string name, Microsoft.JScript.COMMemberInfo dispatch);
  }
  public sealed partial class MemberInfoList {
    internal MemberInfoList() { }
  }
  public abstract partial class MethodInvoker {
    protected MethodInvoker() { }
    [System.Diagnostics.DebuggerHiddenAttribute]
    [System.Diagnostics.DebuggerStepThroughAttribute]
    public abstract object Invoke(object thisob, System.Object[] parameters);
  }
  public sealed partial class Missing {
    internal Missing() { }
    public static readonly Microsoft.JScript.Missing Value;
  }
  public sealed partial class Namespace {
    internal Namespace() { }
    public static Microsoft.JScript.Namespace GetNamespace(string name, Microsoft.JScript.Vsa.VsaEngine engine) { return default(Microsoft.JScript.Namespace); }
  }
  public partial class NoContextException : System.ApplicationException {
    public NoContextException() { }
    protected NoContextException(System.Runtime.Serialization.SerializationInfo s, System.Runtime.Serialization.StreamingContext c) { }
    public NoContextException(string m) { }
    public NoContextException(string m, System.Exception e) { }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(320))]
  public partial class NotRecommended : System.Attribute {
    public NotRecommended(string message) { }
    public bool IsError { get { return default(bool); } }
    public string Message { get { return default(string); } }
  }
  public partial class NumberConstructor : Microsoft.JScript.ScriptFunction {
    internal NumberConstructor() : base (default(Microsoft.JScript.ScriptObject), default(string)) { }
    public const double MAX_VALUE = 1.7976931348623157E+308;
    public const double MIN_VALUE = 4.94065645841247E-324;
    public const double NaN = 0.0 / 0.0;
    public const double NEGATIVE_INFINITY = -1.0 / 0.0;
    public const double POSITIVE_INFINITY = 1.0 / 0.0;
    [Microsoft.JScript.JSFunctionAttribute((Microsoft.JScript.JSFunctionAttributeEnum)(16))]
    public new Microsoft.JScript.NumberObject CreateInstance(params System.Object[] args) { return default(Microsoft.JScript.NumberObject); }
    public double Invoke(object arg) { return default(double); }
  }
  public partial class NumberObject : Microsoft.JScript.JSObject {
    protected NumberObject(Microsoft.JScript.ScriptObject parent, object value) { }
    public new System.Type GetType() { return default(System.Type); }
  }
  public partial class NumberPrototype : Microsoft.JScript.NumberObject {
    internal NumberPrototype() : base (default(Microsoft.JScript.ScriptObject), default(object)) { }
    public static Microsoft.JScript.NumberConstructor constructor { get { return default(Microsoft.JScript.NumberConstructor); } }
    [Microsoft.JScript.JSFunctionAttribute((Microsoft.JScript.JSFunctionAttributeEnum)(2), (Microsoft.JScript.JSBuiltin)(105))]
    public static string toExponential(object thisob, object fractionDigits) { return default(string); }
    [Microsoft.JScript.JSFunctionAttribute((Microsoft.JScript.JSFunctionAttributeEnum)(2), (Microsoft.JScript.JSBuiltin)(106))]
    public static string toFixed(object thisob, double fractionDigits) { return default(string); }
    [Microsoft.JScript.JSFunctionAttribute((Microsoft.JScript.JSFunctionAttributeEnum)(2), (Microsoft.JScript.JSBuiltin)(107))]
    public static string toLocaleString(object thisob) { return default(string); }
    [Microsoft.JScript.JSFunctionAttribute((Microsoft.JScript.JSFunctionAttributeEnum)(2), (Microsoft.JScript.JSBuiltin)(108))]
    public static string toPrecision(object thisob, object precision) { return default(string); }
    [Microsoft.JScript.JSFunctionAttribute((Microsoft.JScript.JSFunctionAttributeEnum)(2), (Microsoft.JScript.JSBuiltin)(109))]
    public static string toString(object thisob, object radix) { return default(string); }
    [Microsoft.JScript.JSFunctionAttribute((Microsoft.JScript.JSFunctionAttributeEnum)(2), (Microsoft.JScript.JSBuiltin)(110))]
    public static object valueOf(object thisob) { return default(object); }
  }
  public sealed partial class NumericBinary : Microsoft.JScript.BinaryOp {
    public NumericBinary(int operatorTok) { }
    public static object DoOp(object v1, object v2, Microsoft.JScript.JSToken operatorTok) { return default(object); }
    [System.Diagnostics.DebuggerHiddenAttribute]
    [System.Diagnostics.DebuggerStepThroughAttribute]
    public object EvaluateNumericBinary(object v1, object v2) { return default(object); }
  }
  public sealed partial class NumericUnary : Microsoft.JScript.UnaryOp {
    public NumericUnary(int operatorTok) { }
    [System.Diagnostics.DebuggerHiddenAttribute]
    [System.Diagnostics.DebuggerStepThroughAttribute]
    public object EvaluateUnary(object v) { return default(object); }
  }
  public sealed partial class ObjectConstructor : Microsoft.JScript.ScriptFunction {
    internal ObjectConstructor() : base (default(Microsoft.JScript.ScriptObject), default(string)) { }
    public Microsoft.JScript.JSObject ConstructObject() { return default(Microsoft.JScript.JSObject); }
    [Microsoft.JScript.JSFunctionAttribute((Microsoft.JScript.JSFunctionAttributeEnum)(16))]
    public new object CreateInstance(params System.Object[] args) { return default(object); }
    [Microsoft.JScript.JSFunctionAttribute((Microsoft.JScript.JSFunctionAttributeEnum)(16))]
    public object Invoke(params System.Object[] args) { return default(object); }
  }
  public partial class ObjectPrototype : Microsoft.JScript.JSObject {
    internal ObjectPrototype() { }
    public static Microsoft.JScript.ObjectConstructor constructor { get { return default(Microsoft.JScript.ObjectConstructor); } }
    [Microsoft.JScript.JSFunctionAttribute((Microsoft.JScript.JSFunctionAttributeEnum)(2), (Microsoft.JScript.JSBuiltin)(111))]
    public static bool hasOwnProperty(object thisob, object name) { return default(bool); }
    [Microsoft.JScript.JSFunctionAttribute((Microsoft.JScript.JSFunctionAttributeEnum)(2), (Microsoft.JScript.JSBuiltin)(112))]
    public static bool isPrototypeOf(object thisob, object ob) { return default(bool); }
    [Microsoft.JScript.JSFunctionAttribute((Microsoft.JScript.JSFunctionAttributeEnum)(2), (Microsoft.JScript.JSBuiltin)(113))]
    public static bool propertyIsEnumerable(object thisob, object name) { return default(bool); }
    [Microsoft.JScript.JSFunctionAttribute((Microsoft.JScript.JSFunctionAttributeEnum)(2), (Microsoft.JScript.JSBuiltin)(114))]
    public static string toLocaleString(object thisob) { return default(string); }
    [Microsoft.JScript.JSFunctionAttribute((Microsoft.JScript.JSFunctionAttributeEnum)(2), (Microsoft.JScript.JSBuiltin)(115))]
    public static string toString(object thisob) { return default(string); }
    [Microsoft.JScript.JSFunctionAttribute((Microsoft.JScript.JSFunctionAttributeEnum)(2), (Microsoft.JScript.JSBuiltin)(116))]
    public static object valueOf(object thisob) { return default(object); }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(320))]
  public partial class Override : System.Attribute {
    public Override() { }
  }
  public sealed partial class Package : Microsoft.JScript.AST {
    internal Package() { }
    public static void JScriptPackage(string rootName, Microsoft.JScript.Vsa.VsaEngine engine) { }
  }
  public partial class ParserException : System.Exception {
    internal ParserException() { }
  }
  public sealed partial class Plus : Microsoft.JScript.BinaryOp {
    public Plus() { }
    public static object DoOp(object v1, object v2) { return default(object); }
    [System.Diagnostics.DebuggerHiddenAttribute]
    [System.Diagnostics.DebuggerStepThroughAttribute]
    public object EvaluatePlus(object v1, object v2) { return default(object); }
  }
  public partial class PostOrPrefixOperator : Microsoft.JScript.UnaryOp {
    public PostOrPrefixOperator(int operatorTok) { }
    [System.Diagnostics.DebuggerHiddenAttribute]
    [System.Diagnostics.DebuggerStepThroughAttribute]
    public object EvaluatePostOrPrefix(ref object v) { return default(object); }
  }
  public sealed partial class RangeErrorObject : Microsoft.JScript.ErrorObject {
    internal RangeErrorObject() { }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(1))]
  public partial class ReferenceAttribute : System.Attribute {
    public string reference;
    public ReferenceAttribute(string reference) { }
  }
  public sealed partial class ReferenceErrorObject : Microsoft.JScript.ErrorObject {
    internal ReferenceErrorObject() { }
  }
  public sealed partial class RegExpConstructor : Microsoft.JScript.ScriptFunction {
    internal RegExpConstructor() : base (default(Microsoft.JScript.ScriptObject), default(string)) { }
    public object index { get { return default(object); } }
    public object input { get { return default(object); } set { } }
    public object lastIndex { get { return default(object); } }
    public object lastMatch { get { return default(object); } }
    public object lastParen { get { return default(object); } }
    public object leftContext { get { return default(object); } }
    public object rightContext { get { return default(object); } }
    public object Construct(string pattern, bool ignoreCase, bool global, bool multiline) { return default(object); }
    [Microsoft.JScript.JSFunctionAttribute((Microsoft.JScript.JSFunctionAttributeEnum)(16))]
    public new Microsoft.JScript.RegExpObject CreateInstance(params System.Object[] args) { return default(Microsoft.JScript.RegExpObject); }
    [Microsoft.JScript.JSFunctionAttribute((Microsoft.JScript.JSFunctionAttributeEnum)(16))]
    public Microsoft.JScript.RegExpObject Invoke(params System.Object[] args) { return default(Microsoft.JScript.RegExpObject); }
  }
  public sealed partial class RegExpMatch : Microsoft.JScript.ArrayObject {
    internal RegExpMatch() { }
  }
  public sealed partial class RegExpObject : Microsoft.JScript.JSObject {
    internal RegExpObject() { }
    public bool global { get { return default(bool); } }
    public bool ignoreCase { get { return default(bool); } }
    public object lastIndex { get { return default(object); } set { } }
    public bool multiline { get { return default(bool); } }
    public string source { get { return default(string); } }
    public override string ToString() { return default(string); }
  }
  public partial class RegExpPrototype : Microsoft.JScript.JSObject {
    internal RegExpPrototype() { }
    public static Microsoft.JScript.RegExpConstructor constructor { get { return default(Microsoft.JScript.RegExpConstructor); } }
    [Microsoft.JScript.JSFunctionAttribute((Microsoft.JScript.JSFunctionAttributeEnum)(2), (Microsoft.JScript.JSBuiltin)(117))]
    public static Microsoft.JScript.RegExpObject compile(object thisob, object source, object flags) { return default(Microsoft.JScript.RegExpObject); }
    [Microsoft.JScript.JSFunctionAttribute((Microsoft.JScript.JSFunctionAttributeEnum)(2), (Microsoft.JScript.JSBuiltin)(118))]
    public static object exec(object thisob, object input) { return default(object); }
    [Microsoft.JScript.JSFunctionAttribute((Microsoft.JScript.JSFunctionAttributeEnum)(2), (Microsoft.JScript.JSBuiltin)(119))]
    public static bool test(object thisob, object input) { return default(bool); }
    [Microsoft.JScript.JSFunctionAttribute((Microsoft.JScript.JSFunctionAttributeEnum)(2), (Microsoft.JScript.JSBuiltin)(120))]
    public static string toString(object thisob) { return default(string); }
  }
  public partial class Relational : Microsoft.JScript.BinaryOp {
    public Relational(int operatorTok) { }
    [System.Diagnostics.DebuggerHiddenAttribute]
    [System.Diagnostics.DebuggerStepThroughAttribute]
    public double EvaluateRelational(object v1, object v2) { return default(double); }
    public static double JScriptCompare(object v1, object v2) { return default(double); }
  }
  public sealed partial class ReturnOutOfFinally : System.ApplicationException {
    public ReturnOutOfFinally() { }
    public ReturnOutOfFinally(string m) { }
    public ReturnOutOfFinally(string m, System.Exception e) { }
  }
  public static partial class Runtime {
    public static long DoubleToInt64(double val) { return default(long); }
    public static new bool Equals(object v1, object v2) { return default(bool); }
    public static long UncheckedDecimalToInt64(decimal val) { return default(long); }
  }
  public partial class ScriptBlock : Microsoft.JScript.AST {
    internal ScriptBlock() { }
  }
  public abstract partial class ScriptFunction : Microsoft.JScript.JSObject {
    protected int ilength;
    protected ScriptFunction(Microsoft.JScript.ScriptObject parent, string name) { }
    public virtual int length { get { return default(int); } set { } }
    public object prototype { get { return default(object); } set { } }
    [Microsoft.JScript.JSFunctionAttribute((Microsoft.JScript.JSFunctionAttributeEnum)(16))]
    [System.Diagnostics.DebuggerHiddenAttribute]
    [System.Diagnostics.DebuggerStepThroughAttribute]
    public object CreateInstance(params System.Object[] args) { return default(object); }
    protected Microsoft.JScript.ScriptObject GetPrototypeForConstructedObject() { return default(Microsoft.JScript.ScriptObject); }
    [Microsoft.JScript.JSFunctionAttribute((Microsoft.JScript.JSFunctionAttributeEnum)(18))]
    [System.Diagnostics.DebuggerHiddenAttribute]
    [System.Diagnostics.DebuggerStepThroughAttribute]
    public object Invoke(object thisob, params System.Object[] args) { return default(object); }
    [System.Diagnostics.DebuggerHiddenAttribute]
    [System.Diagnostics.DebuggerStepThroughAttribute]
    public override object InvokeMember(string name, System.Reflection.BindingFlags invokeAttr, System.Reflection.Binder binder, object target, System.Object[] args, System.Reflection.ParameterModifier[] modifiers, System.Globalization.CultureInfo culture, System.String[] namedParameters) { return default(object); }
    public override string ToString() { return default(string); }
  }
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public abstract partial class ScriptObject : System.Reflection.IReflect {
    internal ScriptObject() { }
    public Microsoft.JScript.Vsa.VsaEngine engine;
    protected Microsoft.JScript.ScriptObject parent;
    public object this[double index] { get { return default(object); } set { } }
    public object this[int index] { get { return default(object); } set { } }
    public object this[params System.Object[] pars] { get { return default(object); } set { } }
    public object this[string name] { get { return default(object); } set { } }
    public virtual System.Type UnderlyingSystemType { get { return default(System.Type); } }
    public System.Reflection.FieldInfo GetField(string name, System.Reflection.BindingFlags bindingAttr) { return default(System.Reflection.FieldInfo); }
    public virtual System.Reflection.FieldInfo[] GetFields(System.Reflection.BindingFlags bindingAttr) { return default(System.Reflection.FieldInfo[]); }
    public abstract System.Reflection.MemberInfo[] GetMember(string name, System.Reflection.BindingFlags bindingAttr);
    public abstract System.Reflection.MemberInfo[] GetMembers(System.Reflection.BindingFlags bindingAttr);
    public System.Reflection.MethodInfo GetMethod(string name, System.Reflection.BindingFlags bindingAttr) { return default(System.Reflection.MethodInfo); }
    public System.Reflection.MethodInfo GetMethod(string name, System.Reflection.BindingFlags bindingAttr, System.Reflection.Binder binder, System.Type[] types, System.Reflection.ParameterModifier[] modifiers) { return default(System.Reflection.MethodInfo); }
    public virtual System.Reflection.MethodInfo[] GetMethods(System.Reflection.BindingFlags bindingAttr) { return default(System.Reflection.MethodInfo[]); }
    public Microsoft.JScript.ScriptObject GetParent() { return default(Microsoft.JScript.ScriptObject); }
    public virtual System.Reflection.PropertyInfo[] GetProperties(System.Reflection.BindingFlags bindingAttr) { return default(System.Reflection.PropertyInfo[]); }
    public System.Reflection.PropertyInfo GetProperty(string name, System.Reflection.BindingFlags bindingAttr) { return default(System.Reflection.PropertyInfo); }
    public System.Reflection.PropertyInfo GetProperty(string name, System.Reflection.BindingFlags bindingAttr, System.Reflection.Binder binder, System.Type returnType, System.Type[] types, System.Reflection.ParameterModifier[] modifiers) { return default(System.Reflection.PropertyInfo); }
    [System.Diagnostics.DebuggerHiddenAttribute]
    [System.Diagnostics.DebuggerStepThroughAttribute]
    public virtual object InvokeMember(string name, System.Reflection.BindingFlags invokeAttr, System.Reflection.Binder binder, object target, System.Object[] args, System.Reflection.ParameterModifier[] modifiers, System.Globalization.CultureInfo locale, System.String[] namedParameters) { return default(object); }
    protected static System.Reflection.MemberInfo[] WrapMembers(System.Reflection.MemberInfo member, object obj) { return default(System.Reflection.MemberInfo[]); }
    protected static System.Reflection.MemberInfo[] WrapMembers(System.Reflection.MemberInfo[] members, object obj) { return default(System.Reflection.MemberInfo[]); }
    protected static System.Reflection.MemberInfo[] WrapMembers(System.Reflection.MemberInfo[] members, object obj, Microsoft.JScript.SimpleHashtable cache) { return default(System.Reflection.MemberInfo[]); }
  }
  public partial class ScriptStream {
    public static System.IO.TextWriter Error;
    public static System.IO.TextWriter Out;
    public ScriptStream() { }
    public static void PrintStackTrace() { }
    public static void PrintStackTrace(System.Exception e) { }
    public static void Write(string str) { }
    public static void WriteLine(string str) { }
  }
  public sealed partial class SimpleHashtable {
    public SimpleHashtable(uint threshold) { }
    public object this[object key] { get { return default(object); } set { } }
    public System.Collections.IDictionaryEnumerator GetEnumerator() { return default(System.Collections.IDictionaryEnumerator); }
    public void Remove(object key) { }
  }
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  [System.Runtime.InteropServices.GuidAttribute("BA731F6A-3D25-39AE-BE18-C2EF646AE58B")]
  public enum SourceState {
    STATE_COLOR_COMMENT = 1,
    STATE_COLOR_NORMAL = 0,
    STATE_COLOR_STRING = 2,
  }
  public sealed partial class StackFrame : Microsoft.JScript.ScriptObject, Microsoft.JScript.IActivationObject {
    internal StackFrame() { }
    public object closureInstance;
    public System.Object[] localVars;
    public object GetDefaultThisObject() { return default(object); }
    public System.Reflection.FieldInfo GetField(string name, int lexLevel) { return default(System.Reflection.FieldInfo); }
    public Microsoft.JScript.GlobalScope GetGlobalScope() { return default(Microsoft.JScript.GlobalScope); }
    public override System.Reflection.MemberInfo[] GetMember(string name, System.Reflection.BindingFlags bindingAttr) { return default(System.Reflection.MemberInfo[]); }
    public override System.Reflection.MemberInfo[] GetMembers(System.Reflection.BindingFlags bindingAttr) { return default(System.Reflection.MemberInfo[]); }
    [System.Diagnostics.DebuggerHiddenAttribute]
    [System.Diagnostics.DebuggerStepThroughAttribute]
    public object GetMemberValue(string name, int lexlevel) { return default(object); }
    System.Reflection.FieldInfo Microsoft.JScript.IActivationObject.GetLocalField(string name) { return default(System.Reflection.FieldInfo); }
    public static void PushStackFrameForMethod(object thisob, Microsoft.JScript.JSLocalField[] fields, Microsoft.JScript.Vsa.VsaEngine engine) { }
    public static void PushStackFrameForStaticMethod(System.RuntimeTypeHandle thisclass, Microsoft.JScript.JSLocalField[] fields, Microsoft.JScript.Vsa.VsaEngine engine) { }
  }
  public partial class StrictEquality : Microsoft.JScript.BinaryOp {
    internal StrictEquality() { }
    public static bool JScriptStrictEquals(object v1, object v2) { return default(bool); }
  }
  public partial class StringConstructor : Microsoft.JScript.ScriptFunction {
    internal StringConstructor() : base (default(Microsoft.JScript.ScriptObject), default(string)) { }
    [Microsoft.JScript.JSFunctionAttribute((Microsoft.JScript.JSFunctionAttributeEnum)(16))]
    public new Microsoft.JScript.StringObject CreateInstance(params System.Object[] args) { return default(Microsoft.JScript.StringObject); }
    [Microsoft.JScript.JSFunctionAttribute((Microsoft.JScript.JSFunctionAttributeEnum)(16), (Microsoft.JScript.JSBuiltin)(131))]
    public static string fromCharCode(params System.Object[] args) { return default(string); }
    public string Invoke(object arg) { return default(string); }
  }
  public partial class StringObject : Microsoft.JScript.JSObject {
    protected StringObject(Microsoft.JScript.ScriptObject prototype, string value) { }
    public int length { get { return default(int); } }
    public override bool Equals(object ob) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public new System.Type GetType() { return default(System.Type); }
  }
  public partial class StringPrototype : Microsoft.JScript.StringObject {
    internal StringPrototype() : base (default(Microsoft.JScript.ScriptObject), default(string)) { }
    public static Microsoft.JScript.StringConstructor constructor { get { return default(Microsoft.JScript.StringConstructor); } }
    [Microsoft.JScript.JSFunctionAttribute((Microsoft.JScript.JSFunctionAttributeEnum)(2), (Microsoft.JScript.JSBuiltin)(121))]
    public static string anchor(object thisob, object anchorName) { return default(string); }
    [Microsoft.JScript.JSFunctionAttribute((Microsoft.JScript.JSFunctionAttributeEnum)(2), (Microsoft.JScript.JSBuiltin)(122))]
    public static string big(object thisob) { return default(string); }
    [Microsoft.JScript.JSFunctionAttribute((Microsoft.JScript.JSFunctionAttributeEnum)(2), (Microsoft.JScript.JSBuiltin)(123))]
    public static string blink(object thisob) { return default(string); }
    [Microsoft.JScript.JSFunctionAttribute((Microsoft.JScript.JSFunctionAttributeEnum)(2), (Microsoft.JScript.JSBuiltin)(124))]
    public static string bold(object thisob) { return default(string); }
    [Microsoft.JScript.JSFunctionAttribute((Microsoft.JScript.JSFunctionAttributeEnum)(2), (Microsoft.JScript.JSBuiltin)(125))]
    public static string charAt(object thisob, double pos) { return default(string); }
    [Microsoft.JScript.JSFunctionAttribute((Microsoft.JScript.JSFunctionAttributeEnum)(2), (Microsoft.JScript.JSBuiltin)(126))]
    public static object charCodeAt(object thisob, double pos) { return default(object); }
    [Microsoft.JScript.JSFunctionAttribute((Microsoft.JScript.JSFunctionAttributeEnum)(18), (Microsoft.JScript.JSBuiltin)(127))]
    public static string concat(object thisob, params System.Object[] args) { return default(string); }
    [Microsoft.JScript.JSFunctionAttribute((Microsoft.JScript.JSFunctionAttributeEnum)(2), (Microsoft.JScript.JSBuiltin)(128))]
    public static string @fixed(object thisob) { return default(string); }
    [Microsoft.JScript.JSFunctionAttribute((Microsoft.JScript.JSFunctionAttributeEnum)(2), (Microsoft.JScript.JSBuiltin)(129))]
    public static string fontcolor(object thisob, object colorName) { return default(string); }
    [Microsoft.JScript.JSFunctionAttribute((Microsoft.JScript.JSFunctionAttributeEnum)(2), (Microsoft.JScript.JSBuiltin)(130))]
    public static string fontsize(object thisob, object fontSize) { return default(string); }
    [Microsoft.JScript.JSFunctionAttribute((Microsoft.JScript.JSFunctionAttributeEnum)(2), (Microsoft.JScript.JSBuiltin)(132))]
    public static int indexOf(object thisob, object searchString, double position) { return default(int); }
    [Microsoft.JScript.JSFunctionAttribute((Microsoft.JScript.JSFunctionAttributeEnum)(2), (Microsoft.JScript.JSBuiltin)(133))]
    public static string italics(object thisob) { return default(string); }
    [Microsoft.JScript.JSFunctionAttribute((Microsoft.JScript.JSFunctionAttributeEnum)(2), (Microsoft.JScript.JSBuiltin)(134))]
    public static int lastIndexOf(object thisob, object searchString, double position) { return default(int); }
    [Microsoft.JScript.JSFunctionAttribute((Microsoft.JScript.JSFunctionAttributeEnum)(2), (Microsoft.JScript.JSBuiltin)(135))]
    public static string link(object thisob, object linkRef) { return default(string); }
    [Microsoft.JScript.JSFunctionAttribute((Microsoft.JScript.JSFunctionAttributeEnum)(2), (Microsoft.JScript.JSBuiltin)(136))]
    public static int localeCompare(object thisob, object thatob) { return default(int); }
    [Microsoft.JScript.JSFunctionAttribute((Microsoft.JScript.JSFunctionAttributeEnum)(34), (Microsoft.JScript.JSBuiltin)(137))]
    public static object match(object thisob, Microsoft.JScript.Vsa.VsaEngine engine, object regExp) { return default(object); }
    [Microsoft.JScript.JSFunctionAttribute((Microsoft.JScript.JSFunctionAttributeEnum)(2), (Microsoft.JScript.JSBuiltin)(138))]
    public static string replace(object thisob, object regExp, object replacement) { return default(string); }
    [Microsoft.JScript.JSFunctionAttribute((Microsoft.JScript.JSFunctionAttributeEnum)(34), (Microsoft.JScript.JSBuiltin)(139))]
    public static int search(object thisob, Microsoft.JScript.Vsa.VsaEngine engine, object regExp) { return default(int); }
    [Microsoft.JScript.JSFunctionAttribute((Microsoft.JScript.JSFunctionAttributeEnum)(2), (Microsoft.JScript.JSBuiltin)(140))]
    public static string slice(object thisob, double start, object end) { return default(string); }
    [Microsoft.JScript.JSFunctionAttribute((Microsoft.JScript.JSFunctionAttributeEnum)(2), (Microsoft.JScript.JSBuiltin)(141))]
    public static string small(object thisob) { return default(string); }
    [Microsoft.JScript.JSFunctionAttribute((Microsoft.JScript.JSFunctionAttributeEnum)(34), (Microsoft.JScript.JSBuiltin)(142))]
    public static Microsoft.JScript.ArrayObject split(object thisob, Microsoft.JScript.Vsa.VsaEngine engine, object separator, object limit) { return default(Microsoft.JScript.ArrayObject); }
    [Microsoft.JScript.JSFunctionAttribute((Microsoft.JScript.JSFunctionAttributeEnum)(2), (Microsoft.JScript.JSBuiltin)(143))]
    public static string strike(object thisob) { return default(string); }
    [Microsoft.JScript.JSFunctionAttribute((Microsoft.JScript.JSFunctionAttributeEnum)(2), (Microsoft.JScript.JSBuiltin)(144))]
    public static string sub(object thisob) { return default(string); }
    [Microsoft.JScript.JSFunctionAttribute((Microsoft.JScript.JSFunctionAttributeEnum)(2), (Microsoft.JScript.JSBuiltin)(145))]
    [Microsoft.JScript.NotRecommended("substr")]
    public static string substr(object thisob, double start, object count) { return default(string); }
    [Microsoft.JScript.JSFunctionAttribute((Microsoft.JScript.JSFunctionAttributeEnum)(2), (Microsoft.JScript.JSBuiltin)(146))]
    public static string substring(object thisob, double start, object end) { return default(string); }
    [Microsoft.JScript.JSFunctionAttribute((Microsoft.JScript.JSFunctionAttributeEnum)(2), (Microsoft.JScript.JSBuiltin)(147))]
    public static string sup(object thisob) { return default(string); }
    [Microsoft.JScript.JSFunctionAttribute((Microsoft.JScript.JSFunctionAttributeEnum)(2), (Microsoft.JScript.JSBuiltin)(148))]
    public static string toLocaleLowerCase(object thisob) { return default(string); }
    [Microsoft.JScript.JSFunctionAttribute((Microsoft.JScript.JSFunctionAttributeEnum)(2), (Microsoft.JScript.JSBuiltin)(149))]
    public static string toLocaleUpperCase(object thisob) { return default(string); }
    [Microsoft.JScript.JSFunctionAttribute((Microsoft.JScript.JSFunctionAttributeEnum)(2), (Microsoft.JScript.JSBuiltin)(150))]
    public static string toLowerCase(object thisob) { return default(string); }
    [Microsoft.JScript.JSFunctionAttribute((Microsoft.JScript.JSFunctionAttributeEnum)(2), (Microsoft.JScript.JSBuiltin)(151))]
    public static string toString(object thisob) { return default(string); }
    [Microsoft.JScript.JSFunctionAttribute((Microsoft.JScript.JSFunctionAttributeEnum)(2), (Microsoft.JScript.JSBuiltin)(152))]
    public static string toUpperCase(object thisob) { return default(string); }
    [Microsoft.JScript.JSFunctionAttribute((Microsoft.JScript.JSFunctionAttributeEnum)(2), (Microsoft.JScript.JSBuiltin)(153))]
    public static object valueOf(object thisob) { return default(object); }
  }
  public sealed partial class SuperTypeMembersSorter {
    internal SuperTypeMembersSorter() { }
  }
  public sealed partial class SyntaxErrorObject : Microsoft.JScript.ErrorObject {
    internal SyntaxErrorObject() { }
  }
  public sealed partial class Throw : Microsoft.JScript.AST {
    internal Throw() { }
    public static System.Exception JScriptThrow(object value) { return default(System.Exception); }
  }
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  [System.Runtime.InteropServices.GuidAttribute("78008402-40D4-30BF-BD91-A61D8815625E")]
  public enum TokenColor {
    COLOR_COMMENT = 3,
    COLOR_CONDITIONAL_COMP = 7,
    COLOR_IDENTIFIER = 1,
    COLOR_KEYWORD = 2,
    COLOR_NUMBER = 5,
    COLOR_OPERATOR = 4,
    COLOR_STRING = 6,
    COLOR_TEXT = 0,
  }
  public sealed partial class Try : Microsoft.JScript.AST {
    internal Try() { }
    public static object JScriptExceptionValue(object e, Microsoft.JScript.Vsa.VsaEngine engine) { return default(object); }
    public static void PushHandlerScope(Microsoft.JScript.Vsa.VsaEngine engine, string id, int scopeId) { }
  }
  public sealed partial class TypedArray : System.Reflection.IReflect {
    public TypedArray(System.Reflection.IReflect elementType, int rank) { }
    public System.Type UnderlyingSystemType { get { return default(System.Type); } }
    public override bool Equals(object obj) { return default(bool); }
    public System.Reflection.FieldInfo GetField(string name, System.Reflection.BindingFlags bindingAttr) { return default(System.Reflection.FieldInfo); }
    public System.Reflection.FieldInfo[] GetFields(System.Reflection.BindingFlags bindingAttr) { return default(System.Reflection.FieldInfo[]); }
    public override int GetHashCode() { return default(int); }
    public System.Reflection.MemberInfo[] GetMember(string name, System.Reflection.BindingFlags bindingAttr) { return default(System.Reflection.MemberInfo[]); }
    public System.Reflection.MemberInfo[] GetMembers(System.Reflection.BindingFlags bindingAttr) { return default(System.Reflection.MemberInfo[]); }
    public System.Reflection.MethodInfo GetMethod(string name, System.Reflection.BindingFlags bindingAttr) { return default(System.Reflection.MethodInfo); }
    public System.Reflection.MethodInfo GetMethod(string name, System.Reflection.BindingFlags bindingAttr, System.Reflection.Binder binder, System.Type[] types, System.Reflection.ParameterModifier[] modifiers) { return default(System.Reflection.MethodInfo); }
    public System.Reflection.MethodInfo[] GetMethods(System.Reflection.BindingFlags bindingAttr) { return default(System.Reflection.MethodInfo[]); }
    public System.Reflection.PropertyInfo[] GetProperties(System.Reflection.BindingFlags bindingAttr) { return default(System.Reflection.PropertyInfo[]); }
    public System.Reflection.PropertyInfo GetProperty(string name, System.Reflection.BindingFlags bindingAttr) { return default(System.Reflection.PropertyInfo); }
    public System.Reflection.PropertyInfo GetProperty(string name, System.Reflection.BindingFlags bindingAttr, System.Reflection.Binder binder, System.Type returnType, System.Type[] types, System.Reflection.ParameterModifier[] modifiers) { return default(System.Reflection.PropertyInfo); }
    public object InvokeMember(string name, System.Reflection.BindingFlags flags, System.Reflection.Binder binder, object target, System.Object[] args, System.Reflection.ParameterModifier[] modifiers, System.Globalization.CultureInfo locale, System.String[] namedParameters) { return default(object); }
    public override string ToString() { return default(string); }
  }
  public sealed partial class TypeErrorObject : Microsoft.JScript.ErrorObject {
    internal TypeErrorObject() { }
  }
  public sealed partial class Typeof : Microsoft.JScript.UnaryOp {
    internal Typeof() { }
    public static string JScriptTypeof(object value) { return default(string); }
  }
  public sealed partial class TypeReflector : Microsoft.JScript.ScriptObject {
    internal TypeReflector() { }
    public override System.Reflection.MemberInfo[] GetMember(string name, System.Reflection.BindingFlags bindingAttr) { return default(System.Reflection.MemberInfo[]); }
    public override System.Reflection.MemberInfo[] GetMembers(System.Reflection.BindingFlags bindingAttr) { return default(System.Reflection.MemberInfo[]); }
  }
  public abstract partial class UnaryOp : Microsoft.JScript.AST {
    internal UnaryOp() { }
    protected Microsoft.JScript.AST operand;
  }
  public sealed partial class URIErrorObject : Microsoft.JScript.ErrorObject {
    internal URIErrorObject() { }
  }
  public sealed partial class VBArrayConstructor : Microsoft.JScript.ScriptFunction {
    internal VBArrayConstructor() : base (default(Microsoft.JScript.ScriptObject), default(string)) { }
    [Microsoft.JScript.JSFunctionAttribute((Microsoft.JScript.JSFunctionAttributeEnum)(16))]
    public new object CreateInstance(params System.Object[] args) { return default(object); }
  }
  public partial class VBArrayObject : Microsoft.JScript.JSObject {
    public VBArrayObject(Microsoft.JScript.VBArrayPrototype parent, System.Array array) { }
  }
  public partial class VBArrayPrototype : Microsoft.JScript.JSObject {
    internal VBArrayPrototype() { }
    public static Microsoft.JScript.VBArrayConstructor constructor { get { return default(Microsoft.JScript.VBArrayConstructor); } }
    [Microsoft.JScript.JSFunctionAttribute((Microsoft.JScript.JSFunctionAttributeEnum)(2), (Microsoft.JScript.JSBuiltin)(154))]
    public static int dimensions(object thisob) { return default(int); }
    [Microsoft.JScript.JSFunctionAttribute((Microsoft.JScript.JSFunctionAttributeEnum)(18), (Microsoft.JScript.JSBuiltin)(155))]
    public static object getItem(object thisob, params System.Object[] args) { return default(object); }
    [Microsoft.JScript.JSFunctionAttribute((Microsoft.JScript.JSFunctionAttributeEnum)(2), (Microsoft.JScript.JSBuiltin)(156))]
    public static int lbound(object thisob, object dimension) { return default(int); }
    [Microsoft.JScript.JSFunctionAttribute((Microsoft.JScript.JSFunctionAttributeEnum)(34), (Microsoft.JScript.JSBuiltin)(157))]
    public static Microsoft.JScript.ArrayObject toArray(object thisob, Microsoft.JScript.Vsa.VsaEngine engine) { return default(Microsoft.JScript.ArrayObject); }
    [Microsoft.JScript.JSFunctionAttribute((Microsoft.JScript.JSFunctionAttributeEnum)(2), (Microsoft.JScript.JSBuiltin)(158))]
    public static int ubound(object thisob, object dimension) { return default(int); }
  }
  public abstract partial class VsaItem : Microsoft.JScript.Vsa.IJSVsaItem {
    internal VsaItem() { }
    protected Microsoft.JScript.Vsa.JSVsaItemFlag flag;
    protected bool isDirty;
    protected string name;
    protected Microsoft.JScript.Vsa.JSVsaItemType type;
    public virtual bool IsDirty { get { return default(bool); } set { } }
    public Microsoft.JScript.Vsa.JSVsaItemType ItemType { get { return default(Microsoft.JScript.Vsa.JSVsaItemType); } }
    public virtual string Name { get { return default(string); } set { } }
    [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Name="FullTrust")]
    public virtual object GetOption(string name) { return default(object); }
    [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Name="FullTrust")]
    public virtual void SetOption(string name, object value) { }
  }
  public sealed partial class VsaItems : Microsoft.JScript.Vsa.IJSVsaItems, System.Collections.IEnumerable {
    public VsaItems(Microsoft.JScript.Vsa.VsaEngine engine) { }
    public int Count { get { return default(int); } }
    public Microsoft.JScript.Vsa.IJSVsaItem this[int index] { get { return default(Microsoft.JScript.Vsa.IJSVsaItem); } }
    public Microsoft.JScript.Vsa.IJSVsaItem this[string itemName] { get { return default(Microsoft.JScript.Vsa.IJSVsaItem); } }
    public void Close() { }
    [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Name="FullTrust")]
    public Microsoft.JScript.Vsa.IJSVsaItem CreateItem(string name, Microsoft.JScript.Vsa.JSVsaItemType itemType, Microsoft.JScript.Vsa.JSVsaItemFlag itemFlag) { return default(Microsoft.JScript.Vsa.IJSVsaItem); }
    public System.Collections.IEnumerator GetEnumerator() { return default(System.Collections.IEnumerator); }
    [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Name="FullTrust")]
    public void Remove(int itemIndex) { }
    [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Name="FullTrust")]
    public void Remove(string itemName) { }
  }
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  [System.Runtime.InteropServices.GuidAttribute("581AD3D9-2BAA-3770-B92B-38607E1B463A")]
  public enum VSAITEMTYPE2 {
    EXPRESSION = 22,
    HOSTOBJECT = 16,
    HOSTSCOPE = 17,
    HOSTSCOPEANDOBJECT = 18,
    None = 0,
    SCRIPTBLOCK = 20,
    SCRIPTSCOPE = 19,
    STATEMENT = 21,
  }
  public sealed partial class With : Microsoft.JScript.AST {
    internal With() { }
    public static object JScriptWith(object withOb, Microsoft.JScript.Vsa.VsaEngine engine) { return default(object); }
  }
}
namespace Microsoft.JScript.Vsa {
  [System.ObsoleteAttribute("Use of this type is not recommended because it is being deprecated in Visual Studio 2005; there will be no replacement for this feature. Please see the ICodeCompiler documentation for additional help.")]
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  [System.Runtime.InteropServices.GuidAttribute("F8932A50-9127-48B6-B115-2BFDC627CEE3")]
  public abstract partial class BaseVsaEngine : Microsoft.JScript.Vsa.IJSVsaEngine {
    internal BaseVsaEngine() { }
    protected string applicationPath;
    protected string assemblyVersion;
    protected string compiledRootNamespace;
    protected string engineMoniker;
    protected string engineName;
    protected Microsoft.JScript.Vsa.IJSVsaSite engineSite;
    protected int errorLocale;
    protected System.Security.Policy.Evidence executionEvidence;
    protected bool failedCompilation;
    protected bool genDebugInfo;
    protected bool haveCompiledState;
    protected bool isClosed;
    protected bool isDebugInfoSupported;
    protected bool isEngineCompiled;
    protected bool isEngineDirty;
    protected bool isEngineInitialized;
    protected bool isEngineRunning;
    protected System.Reflection.Assembly loadedAssembly;
    protected static System.Collections.Hashtable nameTable;
    protected string rootNamespace;
    protected string scriptLanguage;
    protected System.Type startupClass;
    protected Microsoft.JScript.Vsa.BaseVsaStartup startupInstance;
    protected Microsoft.JScript.Vsa.IJSVsaItems vsaItems;
    public System._AppDomain AppDomain { get { return default(System._AppDomain); } set { } }
    public string ApplicationBase { get { return default(string); } set { } }
    public System.Reflection.Assembly Assembly { get { return default(System.Reflection.Assembly); } }
    public System.Security.Policy.Evidence Evidence { get { return default(System.Security.Policy.Evidence); } set { } }
    public bool GenerateDebugInfo { get { return default(bool); } set { } }
    public bool IsCompiled { get { return default(bool); } }
    public bool IsDirty { get { return default(bool); } set { } }
    public bool IsRunning { get { return default(bool); } }
    public Microsoft.JScript.Vsa.IJSVsaItems Items { get { return default(Microsoft.JScript.Vsa.IJSVsaItems); } }
    public string Language { get { return default(string); } }
    public int LCID { get { return default(int); } set { } }
    public string Name { get { return default(string); } set { } }
    public string RootMoniker { get { return default(string); } set { } }
    public string RootNamespace { get { return default(string); } set { } }
    public Microsoft.JScript.Vsa.IJSVsaSite Site { get { return default(Microsoft.JScript.Vsa.IJSVsaSite); } set { } }
    public string Version { get { return default(string); } }
    [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Name="FullTrust")]
    public virtual void Close() { }
    [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.Demand, Name="FullTrust")]
    [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Name="FullTrust")]
    public virtual bool Compile() { return default(bool); }
    protected abstract void DoClose();
    protected abstract bool DoCompile();
    protected abstract void DoLoadSourceState(Microsoft.JScript.Vsa.IJSVsaPersistSite site);
    protected abstract void DoSaveCompiledState(out System.Byte[] pe, out System.Byte[] debugInfo);
    protected abstract void DoSaveSourceState(Microsoft.JScript.Vsa.IJSVsaPersistSite site);
    protected Microsoft.JScript.Vsa.JSVsaException Error(Microsoft.JScript.Vsa.JSVsaError vsaErrorNumber) { return default(Microsoft.JScript.Vsa.JSVsaException); }
    protected abstract object GetCustomOption(string name);
    [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Name="FullTrust")]
    public virtual object GetOption(string name) { return default(object); }
    [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Name="FullTrust")]
    public virtual void InitNew() { }
    [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Name="FullTrust")]
    public abstract bool IsValidIdentifier(string ident);
    protected abstract bool IsValidNamespaceName(string name);
    protected virtual System.Reflection.Assembly LoadCompiledState() { return default(System.Reflection.Assembly); }
    [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Name="FullTrust")]
    public virtual void LoadSourceState(Microsoft.JScript.Vsa.IJSVsaPersistSite site) { }
    protected void Preconditions(Microsoft.JScript.Vsa.BaseVsaEngine.Pre flags) { }
    [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Name="FullTrust")]
    public virtual void Reset() { }
    protected abstract void ResetCompiledState();
    [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Name="FullTrust")]
    public virtual void RevokeCache() { }
    [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.Demand, Name="FullTrust")]
    [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Name="FullTrust")]
    public virtual void Run() { }
    [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Name="FullTrust")]
    public virtual void SaveCompiledState(out System.Byte[] pe, out System.Byte[] debugInfo) { pe = default(System.Byte[]); debugInfo = default(System.Byte[]); }
    [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Name="FullTrust")]
    public virtual void SaveSourceState(Microsoft.JScript.Vsa.IJSVsaPersistSite site) { }
    protected abstract void SetCustomOption(string name, object value);
    [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Name="FullTrust")]
    public virtual void SetOption(string name, object value) { }
    [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Name="FullTrust")]
    protected virtual void ValidateRootMoniker(string rootMoniker) { }
    [System.FlagsAttribute]
    protected enum Pre {
      EngineCompiled = 4,
      EngineInitialised = 1024,
      EngineNotClosed = 1,
      EngineNotInitialised = 2048,
      EngineNotRunning = 16,
      EngineRunning = 8,
      None = 0,
      RootMonikerNotSet = 64,
      RootMonikerSet = 32,
      RootNamespaceSet = 128,
      SiteNotSet = 512,
      SiteSet = 256,
      SupportForDebug = 2,
    }
  }
  [System.ObsoleteAttribute("Use of this type is not recommended because it is being deprecated in Visual Studio 2005; there will be no replacement for this feature. Please see the ICodeCompiler documentation for additional help.")]
  public partial class BaseVsaSite : Microsoft.JScript.Vsa.IJSVsaSite {
    public BaseVsaSite() { }
    public virtual System.Byte[] Assembly { get { return default(System.Byte[]); } }
    public virtual System.Byte[] DebugInfo { get { return default(System.Byte[]); } }
    [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Name="FullTrust")]
    public virtual void GetCompiledState(out System.Byte[] pe, out System.Byte[] debugInfo) { pe = default(System.Byte[]); debugInfo = default(System.Byte[]); }
    public virtual object GetEventSourceInstance(string itemName, string eventSourceName) { return default(object); }
    public virtual object GetGlobalInstance(string name) { return default(object); }
    [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Name="FullTrust")]
    public virtual void Notify(string notify, object optional) { }
    [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Name="FullTrust")]
    public virtual bool OnCompilerError(Microsoft.JScript.Vsa.IJSVsaError error) { return default(bool); }
  }
  [System.ObsoleteAttribute("Use of this type is not recommended because it is being deprecated in Visual Studio 2005; there will be no replacement for this feature. Please see the ICodeCompiler documentation for additional help.")]
  public abstract partial class BaseVsaStartup {
    protected Microsoft.JScript.Vsa.IJSVsaSite site;
    protected BaseVsaStartup() { }
    public void SetSite(Microsoft.JScript.Vsa.IJSVsaSite site) { }
    public abstract void Shutdown();
    public abstract void Startup();
  }
  [System.ObsoleteAttribute("Use of this type is not recommended because it is being deprecated in Visual Studio 2005; there will be no replacement for this feature. Please see the ICodeCompiler documentation for additional help.")]
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  [System.Runtime.InteropServices.GuidAttribute("528BBC87-CCDC-4F07-B29C-9B10575DEB2F")]
  [System.Runtime.InteropServices.InterfaceTypeAttribute((System.Runtime.InteropServices.ComInterfaceType)(1))]
  public partial interface IJSVsaCodeItem : Microsoft.JScript.Vsa.IJSVsaItem {
    System.CodeDom.CodeObject CodeDOM { get; }
    string SourceText { get; set; }
    [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Name="FullTrust")]
    void AddEventSource(string eventSourceName, string eventSourceType);
    [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Name="FullTrust")]
    void AppendSourceText(string text);
    [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Name="FullTrust")]
    void RemoveEventSource(string eventSourceName);
  }
  [System.ObsoleteAttribute("Use of this type is not recommended because it is being deprecated in Visual Studio 2005; there will be no replacement for this feature. Please see the ICodeCompiler documentation for additional help.")]
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  [System.Runtime.InteropServices.GuidAttribute("8FA2C97B-47E4-4A31-A7F5-FF39D1195CD9")]
  [System.Runtime.InteropServices.InterfaceTypeAttribute((System.Runtime.InteropServices.ComInterfaceType)(1))]
  public partial interface IJSVsaEngine {
    System.Reflection.Assembly Assembly { get; }
    System.Security.Policy.Evidence Evidence { get; set; }
    bool GenerateDebugInfo { get; set; }
    bool IsCompiled { get; }
    bool IsDirty { get; }
    bool IsRunning { get; }
    Microsoft.JScript.Vsa.IJSVsaItems Items { get; }
    string Language { get; }
    int LCID { get; set; }
    string Name { get; set; }
    string RootMoniker { get; set; }
    string RootNamespace { get; set; }
    Microsoft.JScript.Vsa.IJSVsaSite Site { get; set; }
    string Version { get; }
    [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Name="FullTrust")]
    void Close();
    [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Name="FullTrust")]
    bool Compile();
    [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Name="FullTrust")]
    object GetOption(string name);
    [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Name="FullTrust")]
    void InitNew();
    [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Name="FullTrust")]
    bool IsValidIdentifier(string identifier);
    [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Name="FullTrust")]
    void LoadSourceState(Microsoft.JScript.Vsa.IJSVsaPersistSite site);
    [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Name="FullTrust")]
    void Reset();
    [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Name="FullTrust")]
    void RevokeCache();
    [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Name="FullTrust")]
    void Run();
    [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Name="FullTrust")]
    void SaveCompiledState(out System.Byte[] pe, out System.Byte[] pdb);
    [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Name="FullTrust")]
    void SaveSourceState(Microsoft.JScript.Vsa.IJSVsaPersistSite site);
    [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Name="FullTrust")]
    void SetOption(string name, object value);
  }
  [System.ObsoleteAttribute("Use of this type is not recommended because it is being deprecated in Visual Studio 2005; there will be no replacement for this feature. Please see the ICodeCompiler documentation for additional help.")]
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  [System.Runtime.InteropServices.GuidAttribute("425EA439-6417-4F3E-BCC9-1AFAC79E3F66")]
  [System.Runtime.InteropServices.InterfaceTypeAttribute((System.Runtime.InteropServices.ComInterfaceType)(1))]
  public partial interface IJSVsaError {
    string Description { get; }
    int EndColumn { get; }
    int Line { get; }
    string LineText { get; }
    int Number { get; }
    int Severity { get; }
    Microsoft.JScript.Vsa.IJSVsaItem SourceItem { get; }
    string SourceMoniker { get; }
    int StartColumn { get; }
  }
  [System.ObsoleteAttribute("Use of this type is not recommended because it is being deprecated in Visual Studio 2005; there will be no replacement for this feature. Please see the ICodeCompiler documentation for additional help.")]
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  [System.Runtime.InteropServices.GuidAttribute("15B2CCE5-D1EA-4EB9-9E06-8729C72D631B")]
  [System.Runtime.InteropServices.InterfaceTypeAttribute((System.Runtime.InteropServices.ComInterfaceType)(1))]
  public partial interface IJSVsaGlobalItem : Microsoft.JScript.Vsa.IJSVsaItem {
    bool ExposeMembers { get; set; }
    string TypeString { set; }
  }
  [System.ObsoleteAttribute("Use of this type is not recommended because it is being deprecated in Visual Studio 2005; there will be no replacement for this feature. Please see the ICodeCompiler documentation for additional help.")]
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  [System.Runtime.InteropServices.GuidAttribute("1F2377AC-8A09-417B-89DC-D146769F0B45")]
  [System.Runtime.InteropServices.InterfaceTypeAttribute((System.Runtime.InteropServices.ComInterfaceType)(1))]
  public partial interface IJSVsaItem {
    bool IsDirty { get; }
    Microsoft.JScript.Vsa.JSVsaItemType ItemType { get; }
    string Name { get; set; }
    [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Name="FullTrust")]
    object GetOption(string name);
    [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Name="FullTrust")]
    void SetOption(string name, object value);
  }
  [System.ObsoleteAttribute("Use of this type is not recommended because it is being deprecated in Visual Studio 2005; there will be no replacement for this feature. Please see the ICodeCompiler documentation for additional help.")]
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  [System.Runtime.InteropServices.GuidAttribute("172341E0-9B0D-43E6-9EFF-75E030A46461")]
  [System.Runtime.InteropServices.InterfaceTypeAttribute((System.Runtime.InteropServices.ComInterfaceType)(1))]
  public partial interface IJSVsaItems : System.Collections.IEnumerable {
    int Count { get; }
    Microsoft.JScript.Vsa.IJSVsaItem this[int index] { get; }
    Microsoft.JScript.Vsa.IJSVsaItem this[string name] { get; }
    [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Name="FullTrust")]
    Microsoft.JScript.Vsa.IJSVsaItem CreateItem(string name, Microsoft.JScript.Vsa.JSVsaItemType itemType, Microsoft.JScript.Vsa.JSVsaItemFlag itemFlag);
    [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Name="FullTrust")]
    void Remove(int index);
    [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Name="FullTrust")]
    void Remove(string name);
  }
  [System.ObsoleteAttribute("Use of this type is not recommended because it is being deprecated in Visual Studio 2005; there will be no replacement for this feature. Please see the ICodeCompiler documentation for additional help.")]
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  [System.Runtime.InteropServices.GuidAttribute("F901A1FF-8EBA-4C38-B6E0-E7E52606D325")]
  [System.Runtime.InteropServices.InterfaceTypeAttribute((System.Runtime.InteropServices.ComInterfaceType)(1))]
  public partial interface IJSVsaPersistSite {
    [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Name="FullTrust")]
    string LoadElement(string name);
    [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Name="FullTrust")]
    void SaveElement(string name, string source);
  }
  [System.ObsoleteAttribute("Use of this type is not recommended because it is being deprecated in Visual Studio 2005; there will be no replacement for this feature. Please see the ICodeCompiler documentation for additional help.")]
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  [System.Runtime.InteropServices.GuidAttribute("8EFD265B-677A-4B09-A471-E086787AA727")]
  [System.Runtime.InteropServices.InterfaceTypeAttribute((System.Runtime.InteropServices.ComInterfaceType)(1))]
  public partial interface IJSVsaReferenceItem : Microsoft.JScript.Vsa.IJSVsaItem {
    string AssemblyName { get; set; }
  }
  [System.ObsoleteAttribute("Use of this type is not recommended because it is being deprecated in Visual Studio 2005; there will be no replacement for this feature. Please see the ICodeCompiler documentation for additional help.")]
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  [System.Runtime.InteropServices.GuidAttribute("605A62B5-3BA8-49E0-A056-0A6A7A5846A3")]
  [System.Runtime.InteropServices.InterfaceTypeAttribute((System.Runtime.InteropServices.ComInterfaceType)(1))]
  public partial interface IJSVsaSite {
    [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Name="FullTrust")]
    void GetCompiledState(out System.Byte[] pe, out System.Byte[] debugInfo);
    object GetEventSourceInstance(string itemName, string eventSourceName);
    object GetGlobalInstance(string name);
    [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Name="FullTrust")]
    void Notify(string notify, object info);
    [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Name="FullTrust")]
    bool OnCompilerError(Microsoft.JScript.Vsa.IJSVsaError error);
  }
  [System.ObsoleteAttribute("Use of this type is not recommended because it is being deprecated in Visual Studio 2005; there will be no replacement for this feature. Please see the ICodeCompiler documentation for additional help.")]
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  [System.Runtime.InteropServices.GuidAttribute("7607D148-3AA5-4CC6-AED5-D4DB0ECBD992")]
  public enum JSVsaError {
    AppDomainCannotBeSet = -2146226176,
    AppDomainInvalid = -2146226175,
    ApplicationBaseCannotBeSet = -2146226174,
    ApplicationBaseInvalid = -2146226173,
    AssemblyExpected = -2146226172,
    AssemblyNameInvalid = -2146226171,
    BadAssembly = -2146226170,
    BrowserNotExist = -2146226115,
    CachedAssemblyInvalid = -2146226169,
    CallbackUnexpected = -2146226168,
    CannotAttachToWebServer = -2146226100,
    CodeDOMNotAvailable = -2146226167,
    CompiledStateNotFound = -2146226166,
    DebuggeeNotStarted = -2146226114,
    DebugInfoNotSupported = -2146226165,
    ElementNameInvalid = -2146226164,
    ElementNotFound = -2146226163,
    EngineBusy = -2146226162,
    EngineCannotClose = -2146226161,
    EngineCannotReset = -2146226160,
    EngineClosed = -2146226159,
    EngineEmpty = -2146226159,
    EngineInitialized = -2146226157,
    EngineNameInUse = -2146226156,
    EngineNameInvalid = -2146226113,
    EngineNameNotSet = -2146226099,
    EngineNotCompiled = -2146226155,
    EngineNotExist = -2146226112,
    EngineNotInitialized = -2146226154,
    EngineNotRunning = -2146226153,
    EngineRunning = -2146226152,
    EventSourceInvalid = -2146226151,
    EventSourceNameInUse = -2146226150,
    EventSourceNameInvalid = -2146226149,
    EventSourceNotFound = -2146226148,
    EventSourceTypeInvalid = -2146226147,
    FileFormatUnsupported = -2146226111,
    FileTypeUnknown = -2146226110,
    GetCompiledStateFailed = -2146226146,
    GlobalInstanceInvalid = -2146226145,
    GlobalInstanceTypeInvalid = -2146226144,
    InternalCompilerError = -2146226143,
    ItemCannotBeRemoved = -2146226142,
    ItemCannotBeRenamed = -2146226109,
    ItemFlagNotSupported = -2146226141,
    ItemNameInUse = -2146226140,
    ItemNameInvalid = -2146226139,
    ItemNotFound = -2146226138,
    ItemTypeNotSupported = -2146226137,
    LCIDNotSupported = -2146226136,
    LoadElementFailed = -2146226135,
    MissingPdb = -2146226102,
    MissingSource = -2146226108,
    NameTooLong = -2146226106,
    NotClientSideAndNoUrl = -2146226101,
    NotificationInvalid = -2146226134,
    NotInitCompleted = -2146226107,
    OptionInvalid = -2146226133,
    OptionNotSupported = -2146226132,
    ProcNameInUse = -2146226105,
    ProcNameInvalid = -2146226104,
    RevokeFailed = -2146226131,
    RootMonikerAlreadySet = -2146226130,
    RootMonikerInUse = -2146226129,
    RootMonikerInvalid = -2146226128,
    RootMonikerNotSet = -2146226127,
    RootMonikerProtocolInvalid = -2146226126,
    RootNamespaceInvalid = -2146226125,
    RootNamespaceNotSet = -2146226124,
    SaveCompiledStateFailed = -2146226123,
    SaveElementFailed = -2146226122,
    SiteAlreadySet = -2146226121,
    SiteInvalid = -2146226120,
    SiteNotSet = -2146226119,
    SourceItemNotAvailable = -2146226118,
    SourceMonikerNotAvailable = -2146226117,
    UnknownError = -2146225921,
    URLInvalid = -2146226116,
    VsaServerDown = -2146226103,
  }
  [System.ObsoleteAttribute("Use of this type is not recommended because it is being deprecated in Visual Studio 2005; there will be no replacement for this feature. Please see the ICodeCompiler documentation for additional help.")]
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  [System.Runtime.InteropServices.GuidAttribute("064C47AC-C9DF-4FCD-9009-E9299D620018")]
  [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.Demand, Name="FullTrust")]
  public sealed partial class JSVsaException : System.Runtime.InteropServices.ExternalException {
    public JSVsaException() { }
    public JSVsaException(Microsoft.JScript.Vsa.JSVsaError error) { }
    public JSVsaException(Microsoft.JScript.Vsa.JSVsaError error, string message) { }
    public JSVsaException(Microsoft.JScript.Vsa.JSVsaError error, string message, System.Exception innerException) { }
    public JSVsaException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public JSVsaException(string message) { }
    public JSVsaException(string message, System.Exception innerException) { }
    public new Microsoft.JScript.Vsa.JSVsaError ErrorCode { get { return default(Microsoft.JScript.Vsa.JSVsaError); } }
    [System.Security.SecurityCriticalAttribute]
    [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.Demand, Name="FullTrust")]
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, SerializationFormatter=true)]
    public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public override string ToString() { return default(string); }
  }
  [System.ObsoleteAttribute("Use of this type is not recommended because it is being deprecated in Visual Studio 2005; there will be no replacement for this feature. Please see the ICodeCompiler documentation for additional help.")]
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  [System.Runtime.InteropServices.GuidAttribute("55BB0B6C-7629-4824-97FF-78A6928E92A7")]
  public enum JSVsaItemFlag {
    Class = 2,
    Module = 1,
    None = 0,
  }
  [System.ObsoleteAttribute("Use of this type is not recommended because it is being deprecated in Visual Studio 2005; there will be no replacement for this feature. Please see the ICodeCompiler documentation for additional help.")]
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  [System.Runtime.InteropServices.GuidAttribute("97453226-34DD-4379-B658-005DF8F84EA1")]
  public enum JSVsaItemType {
    AppGlobal = 1,
    Code = 2,
    Reference = 0,
  }
  [System.ObsoleteAttribute("Use of this type is not recommended because it is being deprecated in Visual Studio 2005; there will be no replacement for this feature. Please see the ICodeCompiler documentation for additional help.")]
  public partial class ResInfo {
    public string filename;
    public string fullpath;
    public bool isLinked;
    public bool isPublic;
    public string name;
    public ResInfo(string resinfo, bool isLinked) { }
    public ResInfo(string filename, string name, bool isPublic, bool isLinked) { }
  }
  [System.ObsoleteAttribute("Use of this type is not recommended because it is being deprecated in Visual Studio 2005; there will be no replacement for this feature. Please see the ICodeCompiler documentation for additional help.")]
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  [System.Runtime.InteropServices.GuidAttribute("B71E484D-93ED-4b56-BFB9-CEED5134822B")]
  public sealed partial class VsaEngine : Microsoft.JScript.Vsa.BaseVsaEngine, Microsoft.JScript.IEngine2, Microsoft.JScript.IRedirectOutput {
    public VsaEngine() { }
    public VsaEngine(bool fast) { }
    public Microsoft.JScript.LenientGlobalObject LenientGlobalObject { get { return default(Microsoft.JScript.LenientGlobalObject); } }
    [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Name="FullTrust")]
    public Microsoft.JScript.Vsa.IJSVsaEngine Clone(System.AppDomain domain) { return default(Microsoft.JScript.Vsa.IJSVsaEngine); }
    [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.Demand, Name="FullTrust")]
    public bool CompileEmpty() { return default(bool); }
    [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Name="FullTrust")]
    public void ConnectEvents() { }
    public static Microsoft.JScript.Vsa.VsaEngine CreateEngine() { return default(Microsoft.JScript.Vsa.VsaEngine); }
    public static Microsoft.JScript.GlobalScope CreateEngineAndGetGlobalScope(bool fast, System.String[] assemblyNames) { return default(Microsoft.JScript.GlobalScope); }
    public static Microsoft.JScript.GlobalScope CreateEngineAndGetGlobalScopeWithType(bool fast, System.String[] assemblyNames, System.RuntimeTypeHandle callingTypeHandle) { return default(Microsoft.JScript.GlobalScope); }
    public static Microsoft.JScript.GlobalScope CreateEngineAndGetGlobalScopeWithTypeAndRootNamespace(bool fast, System.String[] assemblyNames, System.RuntimeTypeHandle callingTypeHandle, string rootNamespace) { return default(Microsoft.JScript.GlobalScope); }
    public static Microsoft.JScript.Vsa.VsaEngine CreateEngineWithType(System.RuntimeTypeHandle callingTypeHandle) { return default(Microsoft.JScript.Vsa.VsaEngine); }
    [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Name="FullTrust")]
    public void DisconnectEvents() { }
    protected override void DoClose() { }
    protected override bool DoCompile() { return default(bool); }
    protected override void DoLoadSourceState(Microsoft.JScript.Vsa.IJSVsaPersistSite site) { }
    protected override void DoSaveCompiledState(out System.Byte[] pe, out System.Byte[] pdb) { pe = default(System.Byte[]); pdb = default(System.Byte[]); }
    protected override void DoSaveSourceState(Microsoft.JScript.Vsa.IJSVsaPersistSite site) { }
    [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.Demand, Name="FullTrust")]
    public System.Reflection.Assembly GetAssembly() { return default(System.Reflection.Assembly); }
    protected override object GetCustomOption(string name) { return default(object); }
    public Microsoft.JScript.IVsaScriptScope GetGlobalScope() { return default(Microsoft.JScript.IVsaScriptScope); }
    [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Name="FullTrust")]
    public Microsoft.JScript.Vsa.IJSVsaItem GetItem(string itemName) { return default(Microsoft.JScript.Vsa.IJSVsaItem); }
    [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Name="FullTrust")]
    public Microsoft.JScript.Vsa.IJSVsaItem GetItemAtIndex(int index) { return default(Microsoft.JScript.Vsa.IJSVsaItem); }
    [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Name="FullTrust")]
    public int GetItemCount() { return default(int); }
    public Microsoft.JScript.GlobalScope GetMainScope() { return default(Microsoft.JScript.GlobalScope); }
    public System.Reflection.Module GetModule() { return default(System.Reflection.Module); }
    public Microsoft.JScript.ArrayConstructor GetOriginalArrayConstructor() { return default(Microsoft.JScript.ArrayConstructor); }
    public Microsoft.JScript.ObjectConstructor GetOriginalObjectConstructor() { return default(Microsoft.JScript.ObjectConstructor); }
    public Microsoft.JScript.RegExpConstructor GetOriginalRegExpConstructor() { return default(Microsoft.JScript.RegExpConstructor); }
    [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Name="FullTrust")]
    public void InitVsaEngine(string rootMoniker, Microsoft.JScript.Vsa.IJSVsaSite site) { }
    [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Name="FullTrust")]
    public void Interrupt() { }
    [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Name="FullTrust")]
    public override bool IsValidIdentifier(string ident) { return default(bool); }
    protected override bool IsValidNamespaceName(string name) { return default(bool); }
    protected override System.Reflection.Assembly LoadCompiledState() { return default(System.Reflection.Assembly); }
    public Microsoft.JScript.ScriptObject PopScriptObject() { return default(Microsoft.JScript.ScriptObject); }
    public void PushScriptObject(Microsoft.JScript.ScriptObject obj) { }
    [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Name="FullTrust")]
    public void RegisterEventSource(string name) { }
    [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Name="FullTrust")]
    public override void Reset() { }
    protected override void ResetCompiledState() { }
    [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Name="FullTrust")]
    public void Restart() { }
    [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Name="FullTrust")]
    public void Run(System.AppDomain domain) { }
    [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Name="FullTrust")]
    public void RunEmpty() { }
    public Microsoft.JScript.ScriptObject ScriptObjectStackTop() { return default(Microsoft.JScript.ScriptObject); }
    protected override void SetCustomOption(string name, object value) { }
    public void SetOutputStream(Microsoft.JScript.IMessageReceiver output) { }
    protected override void ValidateRootMoniker(string rootMoniker) { }
  }
}
