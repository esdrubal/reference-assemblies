namespace Mono.Debugger.Soft {
  public partial class AbsentInformationException : System.Exception {
    public AbsentInformationException() { }
  }
  public partial class AppDomainCreateEvent : Mono.Debugger.Soft.Event {
    internal AppDomainCreateEvent() { }
    public Mono.Debugger.Soft.AppDomainMirror Domain { get { return default(Mono.Debugger.Soft.AppDomainMirror); } }
  }
  public partial class AppDomainMirror : Mono.Debugger.Soft.Mirror {
    internal AppDomainMirror() { }
    public Mono.Debugger.Soft.AssemblyMirror Corlib { get { return default(Mono.Debugger.Soft.AssemblyMirror); } }
    public string FriendlyName { get { return default(string); } }
    public Mono.Debugger.Soft.ObjectMirror CreateBoxedValue(Mono.Debugger.Soft.Value value) { return default(Mono.Debugger.Soft.ObjectMirror); }
    public Mono.Debugger.Soft.StringMirror CreateString(string s) { return default(Mono.Debugger.Soft.StringMirror); }
    public Mono.Debugger.Soft.AssemblyMirror[] GetAssemblies() { return default(Mono.Debugger.Soft.AssemblyMirror[]); }
    public Mono.Debugger.Soft.TypeMirror GetCorrespondingType(System.Type t) { return default(Mono.Debugger.Soft.TypeMirror); }
    public Mono.Debugger.Soft.AssemblyMirror GetEntryAssembly() { return default(Mono.Debugger.Soft.AssemblyMirror); }
  }
  public partial class AppDomainUnloadEvent : Mono.Debugger.Soft.Event {
    internal AppDomainUnloadEvent() { }
    public Mono.Debugger.Soft.AppDomainMirror Domain { get { return default(Mono.Debugger.Soft.AppDomainMirror); } }
  }
  public partial class ArrayMirror : Mono.Debugger.Soft.ObjectMirror, System.Collections.IEnumerable {
    internal ArrayMirror() { }
    public System.Int32[] lengths;
    public System.Int32[] lower_bounds;
    public int rank;
    public Mono.Debugger.Soft.Value this[int index] { get { return default(Mono.Debugger.Soft.Value); } set { } }
    public int Length { get { return default(int); } }
    public int Rank { get { return default(int); } }
    public int GetLength(int dimension) { return default(int); }
    public int GetLowerBound(int dimension) { return default(int); }
    public System.Collections.Generic.IList<Mono.Debugger.Soft.Value> GetValues(int index, int length) { return default(System.Collections.Generic.IList<Mono.Debugger.Soft.Value>); }
    public void SetValues(int index, Mono.Debugger.Soft.Value[] values) { }
    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { return default(System.Collections.IEnumerator); }
  }
  public partial class AssemblyLoadEvent : Mono.Debugger.Soft.Event {
    internal AssemblyLoadEvent() { }
    public Mono.Debugger.Soft.AssemblyMirror Assembly { get { return default(Mono.Debugger.Soft.AssemblyMirror); } }
  }
  public sealed partial class AssemblyLoadEventRequest : Mono.Debugger.Soft.EventRequest {
    internal AssemblyLoadEventRequest() { }
  }
  public partial class AssemblyMirror : Mono.Debugger.Soft.Mirror {
    internal AssemblyMirror() { }
    public Mono.Debugger.Soft.MethodMirror EntryPoint { get { return default(Mono.Debugger.Soft.MethodMirror); } }
    public string Location { get { return default(string); } }
    public Mono.Debugger.Soft.ModuleMirror ManifestModule { get { return default(Mono.Debugger.Soft.ModuleMirror); } }
    public Mono.Cecil.AssemblyDefinition Metadata { get { Unable to resolve assembly 'Assembly(Name=Mono.Cecil, Version=0.9.5.0, Culture=neutral, PublicKeyToken=0738eb9f132ed756)' referenced by 'Assembly(Name=Mono.Debugger.Soft, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0738eb9f132ed756)'.
return default(Mono.Cecil.AssemblyDefinition); } set { } }
    public Mono.Debugger.Soft.ObjectMirror GetAssemblyObject() { return default(Mono.Debugger.Soft.ObjectMirror); }
    public virtual System.Reflection.AssemblyName GetName() { return default(System.Reflection.AssemblyName); }
    public Mono.Debugger.Soft.TypeMirror GetType(string name) { return default(Mono.Debugger.Soft.TypeMirror); }
    public Mono.Debugger.Soft.TypeMirror GetType(string name, bool throwOnError) { return default(Mono.Debugger.Soft.TypeMirror); }
    public Mono.Debugger.Soft.TypeMirror GetType(string name, bool throwOnError, bool ignoreCase) { return default(Mono.Debugger.Soft.TypeMirror); }
  }
  public partial class AssemblyUnloadEvent : Mono.Debugger.Soft.Event {
    internal AssemblyUnloadEvent() { }
    public Mono.Debugger.Soft.AssemblyMirror Assembly { get { return default(Mono.Debugger.Soft.AssemblyMirror); } }
  }
  public partial class BreakpointEvent : Mono.Debugger.Soft.Event {
    internal BreakpointEvent() { }
    public Mono.Debugger.Soft.MethodMirror Method { get { return default(Mono.Debugger.Soft.MethodMirror); } }
  }
  public sealed partial class BreakpointEventRequest : Mono.Debugger.Soft.EventRequest {
    internal BreakpointEventRequest() { }
    public override void Enable() { }
  }
  public partial class CommandException : System.Exception {
    internal CommandException() { }
    public Mono.Debugger.Soft.ErrorCode ErrorCode { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(Mono.Debugger.Soft.ErrorCode); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
  }
  public abstract partial class Connection {
    protected Connection() { }
    public void ForceDisconnect() { }
    public void StartBuffering() { }
    public void StopBuffering() { }
    protected abstract void TransportClose();
    protected abstract int TransportReceive(System.Byte[] buf, int buf_offset, int len);
    protected abstract int TransportSend(System.Byte[] buf, int buf_offset, int len);
    protected abstract void TransportSetTimeouts(int send_timeout, int receive_timeout);
    public System.Int64[] Type_GetMethodsByNameFlags(long id, string name, int flags, bool ignoreCase) { return default(System.Int64[]); }
  }
  public sealed partial class CustomAttributeDataMirror {
    internal CustomAttributeDataMirror() { }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public Mono.Debugger.Soft.MethodMirror Constructor { get { return default(Mono.Debugger.Soft.MethodMirror); } }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public System.Collections.Generic.IList<Mono.Debugger.Soft.CustomAttributeTypedArgumentMirror> ConstructorArguments { get { return default(System.Collections.Generic.IList<Mono.Debugger.Soft.CustomAttributeTypedArgumentMirror>); } }
    public System.Collections.Generic.IList<Mono.Debugger.Soft.CustomAttributeNamedArgumentMirror> NamedArguments { get { return default(System.Collections.Generic.IList<Mono.Debugger.Soft.CustomAttributeNamedArgumentMirror>); } }
    public override string ToString() { return default(string); }
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct CustomAttributeNamedArgumentMirror {
    public Mono.Debugger.Soft.FieldInfoMirror Field { get { return default(Mono.Debugger.Soft.FieldInfoMirror); } }
    public Mono.Debugger.Soft.PropertyInfoMirror Property { get { return default(Mono.Debugger.Soft.PropertyInfoMirror); } }
    public Mono.Debugger.Soft.CustomAttributeTypedArgumentMirror TypedValue { get { return default(Mono.Debugger.Soft.CustomAttributeTypedArgumentMirror); } }
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct CustomAttributeTypedArgumentMirror {
    public System.Type ArgumentType { get { return default(System.Type); } }
    public object Value { get { return default(object); } }
    public override string ToString() { return default(string); }
  }
  public partial class EnumMirror : Mono.Debugger.Soft.StructMirror {
    internal EnumMirror() { }
    public string StringValue { get { return default(string); } }
    public object Value { get { return default(object); } set { } }
  }
  public enum ErrorCode {
    ABSENT_INFORMATION = 105,
    ERR_NO_INVOCATION = 104,
    ERR_UNLOADED = 103,
    INVALID_ARGUMENT = 102,
    INVALID_FIELDID = 25,
    INVALID_FRAMEID = 30,
    INVALID_OBJECT = 20,
    NO_SEQ_POINT_AT_IL_OFFSET = 106,
    NONE = 0,
    NOT_IMPLEMENTED = 100,
    NOT_SUSPENDED = 101,
  }
  public partial class ErrorHandlerEventArgs : System.EventArgs {
    public ErrorHandlerEventArgs() { }
    public Mono.Debugger.Soft.ErrorCode ErrorCode { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(Mono.Debugger.Soft.ErrorCode); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
  }
  public abstract partial class Event {
    internal Event() { }
    protected Mono.Debugger.Soft.VirtualMachine vm;
    public Mono.Debugger.Soft.EventType EventType { get { return default(Mono.Debugger.Soft.EventType); } }
    public Mono.Debugger.Soft.EventRequest Request { get { return default(Mono.Debugger.Soft.EventRequest); } }
    public Mono.Debugger.Soft.ThreadMirror Thread { get { return default(Mono.Debugger.Soft.ThreadMirror); } }
    public override string ToString() { return default(string); }
  }
  public abstract partial class EventRequest {
    internal EventRequest() { }
    protected System.Collections.Generic.IList<Mono.Debugger.Soft.AssemblyMirror> assembly_filter;
    protected int count;
    protected bool enabled;
    protected Mono.Debugger.Soft.EventType etype;
    protected int id;
    protected Mono.Debugger.Soft.SuspendPolicy suspend;
    protected Mono.Debugger.Soft.ThreadMirror thread;
    protected Mono.Debugger.Soft.VirtualMachine vm;
    public System.Collections.Generic.IList<Mono.Debugger.Soft.AssemblyMirror> AssemblyFilter { get { return default(System.Collections.Generic.IList<Mono.Debugger.Soft.AssemblyMirror>); } set { } }
    public int Count { get { return default(int); } set { } }
    public bool Enabled { get { return default(bool); } set { } }
    public Mono.Debugger.Soft.EventType EventType { get { return default(Mono.Debugger.Soft.EventType); } }
    public Mono.Debugger.Soft.ThreadMirror Thread { get { return default(Mono.Debugger.Soft.ThreadMirror); } set { } }
    protected void CheckDisabled() { }
    protected void CheckMirror(Mono.Debugger.Soft.VirtualMachine vm, Mono.Debugger.Soft.Mirror m) { }
    public void Disable() { }
    public virtual void Enable() { }
    protected void SetEnabled(int id) { }
  }
  public partial class EventSet {
    internal EventSet() { }
    protected Mono.Debugger.Soft.VirtualMachine vm;
    public Mono.Debugger.Soft.Event[] Events { get { return default(Mono.Debugger.Soft.Event[]); } }
    public Mono.Debugger.Soft.Event this[int index] { get { return default(Mono.Debugger.Soft.Event); } }
    public Mono.Debugger.Soft.SuspendPolicy SuspendPolicy { get { return default(Mono.Debugger.Soft.SuspendPolicy); } }
  }
  public enum EventType {
    AppDomainCreate = 4,
    AppDomainUnload = 5,
    AssemblyLoad = 8,
    AssemblyUnload = 9,
    Breakpoint = 10,
    Exception = 13,
    KeepAlive = 14,
    MethodEntry = 6,
    MethodExit = 7,
    Step = 11,
    ThreadDeath = 3,
    ThreadStart = 2,
    TypeLoad = 12,
    UserBreak = 15,
    UserLog = 16,
    VMDeath = 1,
    VMDisconnect = 99,
    VMStart = 0,
  }
  public partial class ExceptionEvent : Mono.Debugger.Soft.Event {
    internal ExceptionEvent() { }
    public Mono.Debugger.Soft.ObjectMirror Exception { get { return default(Mono.Debugger.Soft.ObjectMirror); } }
  }
  public sealed partial class ExceptionEventRequest : Mono.Debugger.Soft.EventRequest {
    internal ExceptionEventRequest() { }
    public Mono.Debugger.Soft.TypeMirror ExceptionType { get { return default(Mono.Debugger.Soft.TypeMirror); } }
    public bool IncludeSubclasses { get { return default(bool); } set { } }
    public override void Enable() { }
  }
  public partial class FieldInfoMirror : Mono.Debugger.Soft.Mirror {
    public FieldInfoMirror(Mono.Debugger.Soft.TypeMirror parent, long id, string name, Mono.Debugger.Soft.TypeMirror type, System.Reflection.FieldAttributes attrs) { }
    public FieldInfoMirror(Mono.Debugger.Soft.VirtualMachine vm, long id) { }
    public System.Reflection.FieldAttributes Attributes { get { return default(System.Reflection.FieldAttributes); } }
    public Mono.Debugger.Soft.TypeMirror DeclaringType { get { return default(Mono.Debugger.Soft.TypeMirror); } }
    public Mono.Debugger.Soft.TypeMirror FieldType { get { return default(Mono.Debugger.Soft.TypeMirror); } }
    public bool IsAssembly { get { return default(bool); } }
    public bool IsFamily { get { return default(bool); } }
    public bool IsFamilyAndAssembly { get { return default(bool); } }
    public bool IsFamilyOrAssembly { get { return default(bool); } }
    public bool IsInitOnly { get { return default(bool); } }
    public bool IsLiteral { get { return default(bool); } }
    public bool IsNotSerialized { get { return default(bool); } }
    public bool IsPinvokeImpl { get { return default(bool); } }
    public bool IsPrivate { get { return default(bool); } }
    public bool IsPublic { get { return default(bool); } }
    public bool IsSpecialName { get { return default(bool); } }
    public bool IsStatic { get { return default(bool); } }
    public Mono.Cecil.FieldDefinition Metadata { get { return default(Mono.Cecil.FieldDefinition); } }
    public string Name { get { return default(string); } }
    public Mono.Debugger.Soft.CustomAttributeDataMirror[] GetCustomAttributes(Mono.Debugger.Soft.TypeMirror attributeType, bool inherit) { return default(Mono.Debugger.Soft.CustomAttributeDataMirror[]); }
    public Mono.Debugger.Soft.CustomAttributeDataMirror[] GetCustomAttributes(bool inherit) { return default(Mono.Debugger.Soft.CustomAttributeDataMirror[]); }
  }
  public partial interface IInvokeAsyncResult : System.IAsyncResult {
    void Abort();
  }
  public partial class ILExceptionHandler {
    internal ILExceptionHandler() { }
    public Mono.Debugger.Soft.TypeMirror CatchType { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(Mono.Debugger.Soft.TypeMirror); } }
    public int FilterOffset { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(int); } }
    public int HandlerLength { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(int); } }
    public int HandlerOffset { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(int); } }
    public Mono.Debugger.Soft.ILExceptionHandlerType HandlerType { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(Mono.Debugger.Soft.ILExceptionHandlerType); } }
    public int TryLength { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(int); } }
    public int TryOffset { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(int); } }
  }
  public enum ILExceptionHandlerType {
    Catch = 0,
    Fault = 4,
    Filter = 1,
    Finally = 2,
  }
  public partial class ILInstruction {
    internal ILInstruction() { }
    public Mono.Debugger.Soft.ILInstruction Next { get { return default(Mono.Debugger.Soft.ILInstruction); } set { } }
    public int Offset { get { return default(int); } }
    public Mono.Cecil.Cil.OpCode OpCode { get { return default(Mono.Cecil.Cil.OpCode); } }
    public object Operand { get { return default(object); } set { } }
    public Mono.Debugger.Soft.ILInstruction Previous { get { return default(Mono.Debugger.Soft.ILInstruction); } set { } }
  }
  public partial interface IMirror {
    Mono.Debugger.Soft.VirtualMachine VirtualMachine { get; }
  }
  public partial class InterfaceMappingMirror : Mono.Debugger.Soft.Mirror {
    internal InterfaceMappingMirror() { }
    public Mono.Debugger.Soft.MethodMirror[] InterfaceMethods;
    public Mono.Debugger.Soft.TypeMirror InterfaceType;
    public Mono.Debugger.Soft.MethodMirror[] TargetMethods;
    public Mono.Debugger.Soft.TypeMirror TargetType;
  }
  public partial class InvalidStackFrameException : System.Exception {
    public InvalidStackFrameException() { }
  }
  public partial class InvocationException : System.Exception {
    public InvocationException(Mono.Debugger.Soft.ObjectMirror exception) { }
    public Mono.Debugger.Soft.ObjectMirror Exception { get { return default(Mono.Debugger.Soft.ObjectMirror); } }
  }
  [System.FlagsAttribute]
  public enum InvokeOptions {
    DisableBreakpoints = 1,
    None = 0,
    ReturnOutArgs = 8,
    ReturnOutThis = 4,
    SingleThreaded = 2,
  }
  public partial class InvokeResult {
    public InvokeResult() { }
    public Mono.Debugger.Soft.Value[] OutArgs { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(Mono.Debugger.Soft.Value[]); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public Mono.Debugger.Soft.Value OutThis { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(Mono.Debugger.Soft.Value); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public Mono.Debugger.Soft.Value Result { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(Mono.Debugger.Soft.Value); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
  }
  public partial interface ITargetProcess {
    bool HasExited { get; }
    int Id { get; }
    string ProcessName { get; }
    System.IO.StreamReader StandardError { get; }
    System.IO.StreamReader StandardOutput { get; }
    event System.EventHandler Exited;
    void Kill();
  }
  public partial class LaunchOptions {
    public LaunchOptions() { }
    public string AgentArgs { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public Mono.Debugger.Soft.LaunchOptions.ProcessLauncher CustomProcessLauncher { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(Mono.Debugger.Soft.LaunchOptions.ProcessLauncher); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public Mono.Debugger.Soft.LaunchOptions.TargetProcessLauncher CustomTargetProcessLauncher { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(Mono.Debugger.Soft.LaunchOptions.TargetProcessLauncher); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public bool Valgrind { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public delegate System.Diagnostics.Process ProcessLauncher(System.Diagnostics.ProcessStartInfo info);
    public delegate Mono.Debugger.Soft.ITargetProcess TargetProcessLauncher(System.Diagnostics.ProcessStartInfo info);
  }
  public partial class LocalVariable : Mono.Debugger.Soft.Mirror {
    internal LocalVariable() { }
    public int Index { get { return default(int); } }
    public bool IsArg { get { return default(bool); } }
    public Mono.Debugger.Soft.MethodMirror Method { get { return default(Mono.Debugger.Soft.MethodMirror); } }
    public string Name { get { return default(string); } }
    public Mono.Debugger.Soft.TypeMirror Type { get { return default(Mono.Debugger.Soft.TypeMirror); } }
  }
  public partial class Location : Mono.Debugger.Soft.Mirror {
    internal Location() { }
    public int ColumnNumber { get { return default(int); } }
    public int EndColumnNumber { get { return default(int); } }
    public int EndLineNumber { get { return default(int); } }
    public int ILOffset { get { return default(int); } }
    public int LineNumber { get { return default(int); } }
    public Mono.Debugger.Soft.MethodMirror Method { get { return default(Mono.Debugger.Soft.MethodMirror); } }
    public string SourceFile { get { return default(string); } }
    public System.Byte[] SourceFileHash { get { return default(System.Byte[]); } }
    public override string ToString() { return default(string); }
  }
  public partial class MethodBodyMirror : Mono.Debugger.Soft.Mirror {
    internal MethodBodyMirror() { }
    public System.Collections.Generic.List<Mono.Debugger.Soft.ILExceptionHandler> ExceptionHandlers { get { return default(System.Collections.Generic.List<Mono.Debugger.Soft.ILExceptionHandler>); } }
    public System.Collections.Generic.List<Mono.Debugger.Soft.ILInstruction> Instructions { get { return default(System.Collections.Generic.List<Mono.Debugger.Soft.ILInstruction>); } }
    public Mono.Debugger.Soft.MethodMirror Method { get { return default(Mono.Debugger.Soft.MethodMirror); } }
    public System.Byte[] GetILAsByteArray() { return default(System.Byte[]); }
  }
  public partial class MethodEntryEvent : Mono.Debugger.Soft.Event {
    internal MethodEntryEvent() { }
    public Mono.Debugger.Soft.MethodMirror Method { get { return default(Mono.Debugger.Soft.MethodMirror); } }
  }
  public sealed partial class MethodEntryEventRequest : Mono.Debugger.Soft.EventRequest {
    internal MethodEntryEventRequest() { }
  }
  public partial class MethodExitEvent : Mono.Debugger.Soft.Event {
    internal MethodExitEvent() { }
    public Mono.Debugger.Soft.MethodMirror Method { get { return default(Mono.Debugger.Soft.MethodMirror); } }
  }
  public sealed partial class MethodExitEventRequest : Mono.Debugger.Soft.EventRequest {
    internal MethodExitEventRequest() { }
  }
  public partial class MethodMirror : Mono.Debugger.Soft.Mirror {
    internal MethodMirror() { }
    public System.Reflection.MethodAttributes Attributes { get { return default(System.Reflection.MethodAttributes); } }
    public Mono.Debugger.Soft.TypeMirror DeclaringType { get { return default(Mono.Debugger.Soft.TypeMirror); } }
    public string FullName { get { return default(string); } }
    public System.Collections.Generic.IList<System.Int32> ILOffsets { get { return default(System.Collections.Generic.IList<System.Int32>); } }
    public bool IsAbstract { get { return default(bool); } }
    public bool IsAssembly { get { return default(bool); } }
    public bool IsConstructor { get { return default(bool); } }
    public bool IsFamily { get { return default(bool); } }
    public bool IsFamilyAndAssembly { get { return default(bool); } }
    public bool IsFamilyOrAssembly { get { return default(bool); } }
    public bool IsFinal { get { return default(bool); } }
    public bool IsGenericMethod { get { return default(bool); } }
    public bool IsGenericMethodDefinition { get { return default(bool); } }
    public bool IsHideBySig { get { return default(bool); } }
    public bool IsPrivate { get { return default(bool); } }
    public bool IsPublic { get { return default(bool); } }
    public bool IsSpecialName { get { return default(bool); } }
    public bool IsStatic { get { return default(bool); } }
    public bool IsVirtual { get { return default(bool); } }
    public System.Collections.Generic.IList<System.Int32> LineNumbers { get { return default(System.Collections.Generic.IList<System.Int32>); } }
    public System.Collections.Generic.IList<Mono.Debugger.Soft.Location> Locations { get { return default(System.Collections.Generic.IList<Mono.Debugger.Soft.Location>); } }
    public Mono.Cecil.MethodDefinition Metadata { get { return default(Mono.Cecil.MethodDefinition); } }
    public int MetadataToken { get { return default(int); } }
    public string Name { get { return default(string); } }
    public Mono.Debugger.Soft.ParameterInfoMirror ReturnParameter { get { return default(Mono.Debugger.Soft.ParameterInfoMirror); } }
    public Mono.Debugger.Soft.TypeMirror ReturnType { get { return default(Mono.Debugger.Soft.TypeMirror); } }
    public string SourceFile { get { return default(string); } }
    public Mono.Debugger.Soft.Value Evaluate(Mono.Debugger.Soft.Value this_val, Mono.Debugger.Soft.Value[] args) { return default(Mono.Debugger.Soft.Value); }
    public Mono.Debugger.Soft.CustomAttributeDataMirror[] GetCustomAttributes(Mono.Debugger.Soft.TypeMirror attributeType, bool inherit) { return default(Mono.Debugger.Soft.CustomAttributeDataMirror[]); }
    public Mono.Debugger.Soft.CustomAttributeDataMirror[] GetCustomAttributes(bool inherit) { return default(Mono.Debugger.Soft.CustomAttributeDataMirror[]); }
    public Mono.Debugger.Soft.TypeMirror[] GetGenericArguments() { return default(Mono.Debugger.Soft.TypeMirror[]); }
    public Mono.Debugger.Soft.MethodMirror GetGenericMethodDefinition() { return default(Mono.Debugger.Soft.MethodMirror); }
    public Mono.Debugger.Soft.LocalVariable GetLocal(string name) { return default(Mono.Debugger.Soft.LocalVariable); }
    public Mono.Debugger.Soft.LocalVariable[] GetLocals() { return default(Mono.Debugger.Soft.LocalVariable[]); }
    public Mono.Debugger.Soft.MethodBodyMirror GetMethodBody() { return default(Mono.Debugger.Soft.MethodBodyMirror); }
    public System.Reflection.MethodImplAttributes GetMethodImplementationFlags() { return default(System.Reflection.MethodImplAttributes); }
    public Mono.Debugger.Soft.ParameterInfoMirror[] GetParameters() { return default(Mono.Debugger.Soft.ParameterInfoMirror[]); }
    public Mono.Debugger.Soft.Location LocationAtILOffset(int il_offset) { return default(Mono.Debugger.Soft.Location); }
    public Mono.Debugger.Soft.MethodMirror MakeGenericMethod(Mono.Debugger.Soft.TypeMirror[] args) { return default(Mono.Debugger.Soft.MethodMirror); }
  }
  public abstract partial class Mirror : Mono.Debugger.Soft.IMirror {
    internal Mirror() { }
    protected long id;
    protected Mono.Debugger.Soft.VirtualMachine vm;
    public Mono.Debugger.Soft.VirtualMachine VirtualMachine { get { return default(Mono.Debugger.Soft.VirtualMachine); } }
    protected void CheckMirror(Mono.Debugger.Soft.Mirror m) { }
    protected void SetVirtualMachine(Mono.Debugger.Soft.VirtualMachine vm) { }
  }
  public partial class ModuleMirror : Mono.Debugger.Soft.Mirror {
    internal ModuleMirror() { }
    public Mono.Debugger.Soft.AssemblyMirror Assembly { get { return default(Mono.Debugger.Soft.AssemblyMirror); } }
    public string FullyQualifiedName { get { return default(string); } }
    public System.Guid ModuleVersionId { get { return default(System.Guid); } }
    public string Name { get { return default(string); } }
    public string ScopeName { get { return default(string); } }
  }
  public partial class ObjectCollectedException : System.Exception {
    public ObjectCollectedException() { }
  }
  public partial class ObjectMirror : Mono.Debugger.Soft.Value {
    internal ObjectMirror() { }
    public long Address { get { return default(long); } }
    public Mono.Debugger.Soft.AppDomainMirror Domain { get { return default(Mono.Debugger.Soft.AppDomainMirror); } }
    public bool IsCollected { get { return default(bool); } }
    public Mono.Debugger.Soft.TypeMirror Type { get { return default(Mono.Debugger.Soft.TypeMirror); } }
    public System.IAsyncResult BeginInvokeMethod(Mono.Debugger.Soft.ThreadMirror thread, Mono.Debugger.Soft.MethodMirror method, System.Collections.Generic.IList<Mono.Debugger.Soft.Value> arguments, Mono.Debugger.Soft.InvokeOptions options, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    [System.ObsoleteAttribute("Use the overload without the 'vm' argument")]
    public System.IAsyncResult BeginInvokeMethod(Mono.Debugger.Soft.VirtualMachine vm, Mono.Debugger.Soft.ThreadMirror thread, Mono.Debugger.Soft.MethodMirror method, System.Collections.Generic.IList<Mono.Debugger.Soft.Value> arguments, Mono.Debugger.Soft.InvokeOptions options, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    public System.IAsyncResult BeginInvokeMultiple(Mono.Debugger.Soft.ThreadMirror thread, Mono.Debugger.Soft.MethodMirror[] methods, System.Collections.Generic.IList<System.Collections.Generic.IList<Mono.Debugger.Soft.Value>> arguments, Mono.Debugger.Soft.InvokeOptions options, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    public Mono.Debugger.Soft.Value EndInvokeMethod(System.IAsyncResult asyncResult) { return default(Mono.Debugger.Soft.Value); }
    public Mono.Debugger.Soft.InvokeResult EndInvokeMethodWithResult(System.IAsyncResult asyncResult) { return default(Mono.Debugger.Soft.InvokeResult); }
    public void EndInvokeMultiple(System.IAsyncResult asyncResult) { }
    public Mono.Debugger.Soft.Value GetValue(Mono.Debugger.Soft.FieldInfoMirror field) { return default(Mono.Debugger.Soft.Value); }
    public Mono.Debugger.Soft.Value[] GetValues(System.Collections.Generic.IList<Mono.Debugger.Soft.FieldInfoMirror> fields) { return default(Mono.Debugger.Soft.Value[]); }
    public Mono.Debugger.Soft.Value InvokeMethod(Mono.Debugger.Soft.ThreadMirror thread, Mono.Debugger.Soft.MethodMirror method, System.Collections.Generic.IList<Mono.Debugger.Soft.Value> arguments) { return default(Mono.Debugger.Soft.Value); }
    public Mono.Debugger.Soft.Value InvokeMethod(Mono.Debugger.Soft.ThreadMirror thread, Mono.Debugger.Soft.MethodMirror method, System.Collections.Generic.IList<Mono.Debugger.Soft.Value> arguments, Mono.Debugger.Soft.InvokeOptions options) { return default(Mono.Debugger.Soft.Value); }
    public void SetValue(Mono.Debugger.Soft.FieldInfoMirror field, Mono.Debugger.Soft.Value value) { }
    public void SetValues(System.Collections.Generic.IList<Mono.Debugger.Soft.FieldInfoMirror> fields, Mono.Debugger.Soft.Value[] values) { }
  }
  public partial class ParameterInfoMirror : Mono.Debugger.Soft.Mirror {
    internal ParameterInfoMirror() { }
    public System.Reflection.ParameterAttributes Attributes { get { return default(System.Reflection.ParameterAttributes); } }
    public bool IsRetval { get { return default(bool); } }
    public Mono.Debugger.Soft.MethodMirror Method { get { return default(Mono.Debugger.Soft.MethodMirror); } }
    public string Name { get { return default(string); } }
    public Mono.Debugger.Soft.TypeMirror ParameterType { get { return default(Mono.Debugger.Soft.TypeMirror); } }
    public int Position { get { return default(int); } }
    public override string ToString() { return default(string); }
  }
  public partial class PointerValue : Mono.Debugger.Soft.Value {
    public PointerValue(Mono.Debugger.Soft.VirtualMachine vm, Mono.Debugger.Soft.TypeMirror type, long addr) { }
    public long Address { get { return default(long); } }
    public Mono.Debugger.Soft.TypeMirror Type { get { return default(Mono.Debugger.Soft.TypeMirror); } }
    public override bool Equals(object obj) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public override string ToString() { return default(string); }
  }
  public partial class PrimitiveValue : Mono.Debugger.Soft.Value {
    public PrimitiveValue(Mono.Debugger.Soft.VirtualMachine vm, object value) { }
    public object Value { get { return default(object); } }
    public System.IAsyncResult BeginInvokeMethod(Mono.Debugger.Soft.ThreadMirror thread, Mono.Debugger.Soft.MethodMirror method, System.Collections.Generic.IList<Mono.Debugger.Soft.Value> arguments, Mono.Debugger.Soft.InvokeOptions options, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    public Mono.Debugger.Soft.Value EndInvokeMethod(System.IAsyncResult asyncResult) { return default(Mono.Debugger.Soft.Value); }
    public Mono.Debugger.Soft.InvokeResult EndInvokeMethodWithResult(System.IAsyncResult asyncResult) { return default(Mono.Debugger.Soft.InvokeResult); }
    public override bool Equals(object obj) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public Mono.Debugger.Soft.Value InvokeMethod(Mono.Debugger.Soft.ThreadMirror thread, Mono.Debugger.Soft.MethodMirror method, System.Collections.Generic.IList<Mono.Debugger.Soft.Value> arguments) { return default(Mono.Debugger.Soft.Value); }
    public Mono.Debugger.Soft.Value InvokeMethod(Mono.Debugger.Soft.ThreadMirror thread, Mono.Debugger.Soft.MethodMirror method, System.Collections.Generic.IList<Mono.Debugger.Soft.Value> arguments, Mono.Debugger.Soft.InvokeOptions options) { return default(Mono.Debugger.Soft.Value); }
    public override string ToString() { return default(string); }
  }
  public partial class PropertyInfoMirror : Mono.Debugger.Soft.Mirror {
    public PropertyInfoMirror(Mono.Debugger.Soft.TypeMirror parent, long id, string name, Mono.Debugger.Soft.MethodMirror get_method, Mono.Debugger.Soft.MethodMirror set_method, System.Reflection.PropertyAttributes attrs) { }
    public System.Reflection.PropertyAttributes Attributes { get { return default(System.Reflection.PropertyAttributes); } }
    public Mono.Debugger.Soft.TypeMirror DeclaringType { get { return default(Mono.Debugger.Soft.TypeMirror); } }
    public bool IsSpecialName { get { return default(bool); } }
    public Mono.Cecil.PropertyDefinition Metadata { get { return default(Mono.Cecil.PropertyDefinition); } }
    public string Name { get { return default(string); } }
    public Mono.Debugger.Soft.TypeMirror PropertyType { get { return default(Mono.Debugger.Soft.TypeMirror); } }
    public Mono.Debugger.Soft.CustomAttributeDataMirror[] GetCustomAttributes(Mono.Debugger.Soft.TypeMirror attributeType, bool inherit) { return default(Mono.Debugger.Soft.CustomAttributeDataMirror[]); }
    public Mono.Debugger.Soft.CustomAttributeDataMirror[] GetCustomAttributes(bool inherit) { return default(Mono.Debugger.Soft.CustomAttributeDataMirror[]); }
    public Mono.Debugger.Soft.MethodMirror GetGetMethod() { return default(Mono.Debugger.Soft.MethodMirror); }
    public Mono.Debugger.Soft.MethodMirror GetGetMethod(bool nonPublic) { return default(Mono.Debugger.Soft.MethodMirror); }
    public Mono.Debugger.Soft.ParameterInfoMirror[] GetIndexParameters() { return default(Mono.Debugger.Soft.ParameterInfoMirror[]); }
    public Mono.Debugger.Soft.MethodMirror GetSetMethod() { return default(Mono.Debugger.Soft.MethodMirror); }
    public Mono.Debugger.Soft.MethodMirror GetSetMethod(bool nonPublic) { return default(Mono.Debugger.Soft.MethodMirror); }
  }
  public partial class StackFrame : Mono.Debugger.Soft.Mirror {
    internal StackFrame() { }
    public int ColumnNumber { get { return default(int); } }
    public string FileName { get { return default(string); } }
    public int ILOffset { get { return default(int); } }
    public bool IsDebuggerInvoke { get { return default(bool); } }
    public bool IsNativeTransition { get { return default(bool); } }
    public int LineNumber { get { return default(int); } }
    public Mono.Debugger.Soft.Location Location { get { return default(Mono.Debugger.Soft.Location); } }
    public Mono.Debugger.Soft.MethodMirror Method { get { return default(Mono.Debugger.Soft.MethodMirror); } }
    public Mono.Debugger.Soft.ThreadMirror Thread { get { return default(Mono.Debugger.Soft.ThreadMirror); } }
    public Mono.Debugger.Soft.Value GetArgument(int pos) { return default(Mono.Debugger.Soft.Value); }
    public Mono.Debugger.Soft.Value GetThis() { return default(Mono.Debugger.Soft.Value); }
    public Mono.Debugger.Soft.Value GetValue(Mono.Debugger.Soft.LocalVariable var) { return default(Mono.Debugger.Soft.Value); }
    public Mono.Debugger.Soft.Value GetValue(Mono.Debugger.Soft.ParameterInfoMirror param) { return default(Mono.Debugger.Soft.Value); }
    public Mono.Debugger.Soft.Value[] GetValues(Mono.Debugger.Soft.LocalVariable[] vars) { return default(Mono.Debugger.Soft.Value[]); }
    public Mono.Debugger.Soft.LocalVariable GetVisibleVariableByName(string name) { return default(Mono.Debugger.Soft.LocalVariable); }
    public System.Collections.Generic.IList<Mono.Debugger.Soft.LocalVariable> GetVisibleVariables() { return default(System.Collections.Generic.IList<Mono.Debugger.Soft.LocalVariable>); }
    public void SetValue(Mono.Debugger.Soft.LocalVariable var, Mono.Debugger.Soft.Value value) { }
    public void SetValue(Mono.Debugger.Soft.ParameterInfoMirror param, Mono.Debugger.Soft.Value value) { }
  }
  public enum StepDepth {
    Into = 0,
    Out = 2,
    Over = 1,
  }
  public partial class StepEvent : Mono.Debugger.Soft.Event {
    internal StepEvent() { }
    public long Location { get { return default(long); } }
    public Mono.Debugger.Soft.MethodMirror Method { get { return default(Mono.Debugger.Soft.MethodMirror); } }
  }
  public sealed partial class StepEventRequest : Mono.Debugger.Soft.EventRequest {
    internal StepEventRequest() { }
    public Mono.Debugger.Soft.StepDepth Depth { get { return default(Mono.Debugger.Soft.StepDepth); } set { } }
    public Mono.Debugger.Soft.StepFilter Filter { get { return default(Mono.Debugger.Soft.StepFilter); } set { } }
    public Mono.Debugger.Soft.StepSize Size { get { return default(Mono.Debugger.Soft.StepSize); } set { } }
    public new Mono.Debugger.Soft.ThreadMirror Thread { get { return default(Mono.Debugger.Soft.ThreadMirror); } }
    public override void Enable() { }
  }
  [System.FlagsAttribute]
  public enum StepFilter {
    DebuggerHidden = 2,
    DebuggerNonUserCode = 8,
    DebuggerStepThrough = 4,
    None = 0,
    StaticCtor = 1,
  }
  public enum StepSize {
    Line = 1,
    Min = 0,
  }
  public partial class StringMirror : Mono.Debugger.Soft.ObjectMirror {
    internal StringMirror() { }
    public int Length { get { return default(int); } }
    public string Value { get { return default(string); } }
    public System.Char[] GetChars(int index, int length) { return default(System.Char[]); }
  }
  public partial class StructMirror : Mono.Debugger.Soft.Value {
    internal StructMirror() { }
    public Mono.Debugger.Soft.Value[] Fields { get { return default(Mono.Debugger.Soft.Value[]); } }
    public Mono.Debugger.Soft.Value this[string field] { get { return default(Mono.Debugger.Soft.Value); } set { } }
    public Mono.Debugger.Soft.TypeMirror Type { get { return default(Mono.Debugger.Soft.TypeMirror); } }
    public System.IAsyncResult BeginInvokeMethod(Mono.Debugger.Soft.ThreadMirror thread, Mono.Debugger.Soft.MethodMirror method, System.Collections.Generic.IList<Mono.Debugger.Soft.Value> arguments, Mono.Debugger.Soft.InvokeOptions options, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    [System.ObsoleteAttribute("Use the overload without the 'vm' argument")]
    public System.IAsyncResult BeginInvokeMethod(Mono.Debugger.Soft.VirtualMachine vm, Mono.Debugger.Soft.ThreadMirror thread, Mono.Debugger.Soft.MethodMirror method, System.Collections.Generic.IList<Mono.Debugger.Soft.Value> arguments, Mono.Debugger.Soft.InvokeOptions options, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    public Mono.Debugger.Soft.Value EndInvokeMethod(System.IAsyncResult asyncResult) { return default(Mono.Debugger.Soft.Value); }
    public Mono.Debugger.Soft.InvokeResult EndInvokeMethodWithResult(System.IAsyncResult asyncResult) { return default(Mono.Debugger.Soft.InvokeResult); }
    public Mono.Debugger.Soft.Value InvokeMethod(Mono.Debugger.Soft.ThreadMirror thread, Mono.Debugger.Soft.MethodMirror method, System.Collections.Generic.IList<Mono.Debugger.Soft.Value> arguments) { return default(Mono.Debugger.Soft.Value); }
    public Mono.Debugger.Soft.Value InvokeMethod(Mono.Debugger.Soft.ThreadMirror thread, Mono.Debugger.Soft.MethodMirror method, System.Collections.Generic.IList<Mono.Debugger.Soft.Value> arguments, Mono.Debugger.Soft.InvokeOptions options) { return default(Mono.Debugger.Soft.Value); }
  }
  public enum SuspendPolicy {
    All = 2,
    EventThread = 1,
    None = 0,
  }
  public partial class ThreadDeathEvent : Mono.Debugger.Soft.Event {
    internal ThreadDeathEvent() { }
  }
  public partial class ThreadMirror : Mono.Debugger.Soft.ObjectMirror {
    internal ThreadMirror() { }
    public long Id { get { return default(long); } }
    public bool IsThreadPoolThread { get { return default(bool); } }
    public string Name { get { return default(string); } }
    public static bool NativeTransitions { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public long ThreadId { get { return default(long); } }
    public System.Threading.ThreadState ThreadState { get { return default(System.Threading.ThreadState); } }
    public long TID { get { return default(long); } }
    public static void FetchFrames(System.Collections.Generic.IList<Mono.Debugger.Soft.ThreadMirror> threads) { }
    public Mono.Debugger.Soft.StackFrame[] GetFrames() { return default(Mono.Debugger.Soft.StackFrame[]); }
    public void SetIP(Mono.Debugger.Soft.Location loc) { }
  }
  public partial class ThreadStartEvent : Mono.Debugger.Soft.Event {
    internal ThreadStartEvent() { }
  }
  public partial class TypeLoadEvent : Mono.Debugger.Soft.Event {
    internal TypeLoadEvent() { }
    public Mono.Debugger.Soft.TypeMirror Type { get { return default(Mono.Debugger.Soft.TypeMirror); } }
  }
  public sealed partial class TypeLoadEventRequest : Mono.Debugger.Soft.EventRequest {
    internal TypeLoadEventRequest() { }
    public System.String[] SourceFileFilter { get { return default(System.String[]); } set { } }
    public System.String[] TypeNameFilter { get { return default(System.String[]); } set { } }
    public override void Enable() { }
  }
  public partial class TypeMirror : Mono.Debugger.Soft.Mirror {
    internal TypeMirror() { }
    public Mono.Debugger.Soft.AssemblyMirror Assembly { get { return default(Mono.Debugger.Soft.AssemblyMirror); } }
    public System.Reflection.TypeAttributes Attributes { get { return default(System.Reflection.TypeAttributes); } }
    public Mono.Debugger.Soft.TypeMirror BaseType { get { return default(Mono.Debugger.Soft.TypeMirror); } }
    public string CSharpName { get { return default(string); } }
    public Mono.Debugger.Soft.TypeMirror EnumUnderlyingType { get { return default(Mono.Debugger.Soft.TypeMirror); } }
    public string FullName { get { return default(string); } }
    public bool HasElementType { get { return default(bool); } }
    public bool IsAbstract { get { return default(bool); } }
    public bool IsAnsiClass { get { return default(bool); } }
    public bool IsArray { get { return default(bool); } }
    public bool IsAutoClass { get { return default(bool); } }
    public bool IsAutoLayout { get { return default(bool); } }
    public bool IsByRef { get { return default(bool); } }
    public bool IsClass { get { return default(bool); } }
    public bool IsCOMObject { get { return default(bool); } }
    public bool IsContextful { get { return default(bool); } }
    public bool IsEnum { get { return default(bool); } }
    public bool IsExplicitLayout { get { return default(bool); } }
    public bool IsGenericType { get { return default(bool); } }
    public bool IsGenericTypeDefinition { get { return default(bool); } }
    public bool IsImport { get { return default(bool); } }
    public bool IsInitialized { get { return default(bool); } }
    public bool IsInterface { get { return default(bool); } }
    public bool IsLayoutSequential { get { return default(bool); } }
    public bool IsMarshalByRef { get { return default(bool); } }
    public bool IsNested { get { return default(bool); } }
    public bool IsNestedAssembly { get { return default(bool); } }
    public bool IsNestedFamANDAssem { get { return default(bool); } }
    public bool IsNestedFamily { get { return default(bool); } }
    public bool IsNestedFamORAssem { get { return default(bool); } }
    public bool IsNestedPrivate { get { return default(bool); } }
    public bool IsNestedPublic { get { return default(bool); } }
    public bool IsNotPublic { get { return default(bool); } }
    public bool IsPointer { get { return default(bool); } }
    public bool IsPrimitive { get { return default(bool); } }
    public bool IsPublic { get { return default(bool); } }
    public bool IsSealed { get { return default(bool); } }
    public bool IsSerializable { get { return default(bool); } }
    public bool IsSpecialName { get { return default(bool); } }
    public bool IsUnicodeClass { get { return default(bool); } }
    public bool IsValueType { get { return default(bool); } }
    public Mono.Cecil.TypeDefinition Metadata { get { return default(Mono.Cecil.TypeDefinition); } }
    public int MetadataToken { get { return default(int); } }
    public Mono.Debugger.Soft.ModuleMirror Module { get { return default(Mono.Debugger.Soft.ModuleMirror); } }
    public string Name { get { return default(string); } }
    public string Namespace { get { return default(string); } }
    public System.IAsyncResult BeginInvokeMethod(Mono.Debugger.Soft.ThreadMirror thread, Mono.Debugger.Soft.MethodMirror method, System.Collections.Generic.IList<Mono.Debugger.Soft.Value> arguments, Mono.Debugger.Soft.InvokeOptions options, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    [System.ObsoleteAttribute("Use the overload without the 'vm' argument")]
    public System.IAsyncResult BeginInvokeMethod(Mono.Debugger.Soft.VirtualMachine vm, Mono.Debugger.Soft.ThreadMirror thread, Mono.Debugger.Soft.MethodMirror method, System.Collections.Generic.IList<Mono.Debugger.Soft.Value> arguments, Mono.Debugger.Soft.InvokeOptions options, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    public Mono.Debugger.Soft.Value EndInvokeMethod(System.IAsyncResult asyncResult) { return default(Mono.Debugger.Soft.Value); }
    public Mono.Debugger.Soft.InvokeResult EndInvokeMethodWithResult(System.IAsyncResult asyncResult) { return default(Mono.Debugger.Soft.InvokeResult); }
    public int GetArrayRank() { return default(int); }
    protected virtual System.Reflection.TypeAttributes GetAttributeFlagsImpl() { return default(System.Reflection.TypeAttributes); }
    public Mono.Debugger.Soft.CustomAttributeDataMirror[] GetCustomAttributes(Mono.Debugger.Soft.TypeMirror attributeType, bool inherit) { return default(Mono.Debugger.Soft.CustomAttributeDataMirror[]); }
    public Mono.Debugger.Soft.CustomAttributeDataMirror[] GetCustomAttributes(bool inherit) { return default(Mono.Debugger.Soft.CustomAttributeDataMirror[]); }
    public Mono.Debugger.Soft.TypeMirror GetElementType() { return default(Mono.Debugger.Soft.TypeMirror); }
    public Mono.Debugger.Soft.FieldInfoMirror GetField(string name) { return default(Mono.Debugger.Soft.FieldInfoMirror); }
    public Mono.Debugger.Soft.FieldInfoMirror[] GetFields() { return default(Mono.Debugger.Soft.FieldInfoMirror[]); }
    public Mono.Debugger.Soft.TypeMirror[] GetGenericArguments() { return default(Mono.Debugger.Soft.TypeMirror[]); }
    public Mono.Debugger.Soft.TypeMirror GetGenericTypeDefinition() { return default(Mono.Debugger.Soft.TypeMirror); }
    public Mono.Debugger.Soft.InterfaceMappingMirror GetInterfaceMap(Mono.Debugger.Soft.TypeMirror interfaceType) { return default(Mono.Debugger.Soft.InterfaceMappingMirror); }
    public Mono.Debugger.Soft.TypeMirror[] GetInterfaces() { return default(Mono.Debugger.Soft.TypeMirror[]); }
    public Mono.Debugger.Soft.MethodMirror GetMethod(string name) { return default(Mono.Debugger.Soft.MethodMirror); }
    public Mono.Debugger.Soft.MethodMirror[] GetMethods() { return default(Mono.Debugger.Soft.MethodMirror[]); }
    public Mono.Debugger.Soft.MethodMirror[] GetMethodsByNameFlags(string name, System.Reflection.BindingFlags flags, bool ignoreCase) { return default(Mono.Debugger.Soft.MethodMirror[]); }
    public Mono.Debugger.Soft.TypeMirror[] GetNestedTypes() { return default(Mono.Debugger.Soft.TypeMirror[]); }
    public Mono.Debugger.Soft.TypeMirror[] GetNestedTypes(System.Reflection.BindingFlags bindingAttr) { return default(Mono.Debugger.Soft.TypeMirror[]); }
    public Mono.Debugger.Soft.PropertyInfoMirror[] GetProperties() { return default(Mono.Debugger.Soft.PropertyInfoMirror[]); }
    public Mono.Debugger.Soft.PropertyInfoMirror[] GetProperties(System.Reflection.BindingFlags bindingAttr) { return default(Mono.Debugger.Soft.PropertyInfoMirror[]); }
    public Mono.Debugger.Soft.PropertyInfoMirror GetProperty(string name) { return default(Mono.Debugger.Soft.PropertyInfoMirror); }
    public System.String[] GetSourceFiles() { return default(System.String[]); }
    public System.String[] GetSourceFiles(bool returnFullPaths) { return default(System.String[]); }
    public Mono.Debugger.Soft.ObjectMirror GetTypeObject() { return default(Mono.Debugger.Soft.ObjectMirror); }
    public Mono.Debugger.Soft.Value GetValue(Mono.Debugger.Soft.FieldInfoMirror field) { return default(Mono.Debugger.Soft.Value); }
    public Mono.Debugger.Soft.Value GetValue(Mono.Debugger.Soft.FieldInfoMirror field, Mono.Debugger.Soft.ThreadMirror thread) { return default(Mono.Debugger.Soft.Value); }
    public Mono.Debugger.Soft.Value[] GetValues(System.Collections.Generic.IList<Mono.Debugger.Soft.FieldInfoMirror> fields) { return default(Mono.Debugger.Soft.Value[]); }
    public Mono.Debugger.Soft.Value[] GetValues(System.Collections.Generic.IList<Mono.Debugger.Soft.FieldInfoMirror> fields, Mono.Debugger.Soft.ThreadMirror thread) { return default(Mono.Debugger.Soft.Value[]); }
    protected virtual bool HasElementTypeImpl() { return default(bool); }
    public Mono.Debugger.Soft.Value InvokeMethod(Mono.Debugger.Soft.ThreadMirror thread, Mono.Debugger.Soft.MethodMirror method, System.Collections.Generic.IList<Mono.Debugger.Soft.Value> arguments) { return default(Mono.Debugger.Soft.Value); }
    public Mono.Debugger.Soft.Value InvokeMethod(Mono.Debugger.Soft.ThreadMirror thread, Mono.Debugger.Soft.MethodMirror method, System.Collections.Generic.IList<Mono.Debugger.Soft.Value> arguments, Mono.Debugger.Soft.InvokeOptions options) { return default(Mono.Debugger.Soft.Value); }
    protected virtual bool IsArrayImpl() { return default(bool); }
    public virtual bool IsAssignableFrom(Mono.Debugger.Soft.TypeMirror c) { return default(bool); }
    protected virtual bool IsByRefImpl() { return default(bool); }
    protected virtual bool IsCOMObjectImpl() { return default(bool); }
    protected virtual bool IsContextfulImpl() { return default(bool); }
    protected virtual bool IsMarshalByRefImpl() { return default(bool); }
    protected virtual bool IsPointerImpl() { return default(bool); }
    protected virtual bool IsPrimitiveImpl() { return default(bool); }
    protected virtual bool IsValueTypeImpl() { return default(bool); }
    public Mono.Debugger.Soft.Value NewInstance() { return default(Mono.Debugger.Soft.Value); }
    public Mono.Debugger.Soft.Value NewInstance(Mono.Debugger.Soft.ThreadMirror thread, Mono.Debugger.Soft.MethodMirror method, System.Collections.Generic.IList<Mono.Debugger.Soft.Value> arguments) { return default(Mono.Debugger.Soft.Value); }
    public Mono.Debugger.Soft.Value NewInstance(Mono.Debugger.Soft.ThreadMirror thread, Mono.Debugger.Soft.MethodMirror method, System.Collections.Generic.IList<Mono.Debugger.Soft.Value> arguments, Mono.Debugger.Soft.InvokeOptions options) { return default(Mono.Debugger.Soft.Value); }
    public void SetValue(Mono.Debugger.Soft.FieldInfoMirror field, Mono.Debugger.Soft.Value value) { }
    public void SetValues(System.Collections.Generic.IList<Mono.Debugger.Soft.FieldInfoMirror> fields, Mono.Debugger.Soft.Value[] values) { }
  }
  public partial class UserBreakEvent : Mono.Debugger.Soft.Event {
    internal UserBreakEvent() { }
  }
  public partial class UserLogEvent : Mono.Debugger.Soft.Event {
    internal UserLogEvent() { }
    public string Category { get { return default(string); } }
    public int Level { get { return default(int); } }
    public string Message { get { return default(string); } }
  }
  public abstract partial class Value : Mono.Debugger.Soft.Mirror {
    internal Value() { }
  }
  public partial class VersionInfo {
    public VersionInfo() { }
    public int MajorVersion { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(int); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public int MinorVersion { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(int); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public string VMVersion { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public bool AtLeast(int major, int minor) { return default(bool); }
  }
  public partial class VirtualMachine : Mono.Debugger.Soft.Mirror {
    internal VirtualMachine() { }
    public System.Net.EndPoint EndPoint { get { return default(System.Net.EndPoint); } }
    public System.Diagnostics.Process Process { get { return default(System.Diagnostics.Process); } }
    public Mono.Debugger.Soft.AppDomainMirror RootDomain { get { return default(Mono.Debugger.Soft.AppDomainMirror); } }
    public System.IO.StreamReader StandardError { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.IO.StreamReader); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.IO.StreamReader StandardOutput { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.IO.StreamReader); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public Mono.Debugger.Soft.ITargetProcess TargetProcess { get { return default(Mono.Debugger.Soft.ITargetProcess); } }
    public Mono.Debugger.Soft.VersionInfo Version { get { return default(Mono.Debugger.Soft.VersionInfo); } }
    public void ClearAllBreakpoints() { }
    public Mono.Debugger.Soft.AssemblyLoadEventRequest CreateAssemblyLoadRequest() { return default(Mono.Debugger.Soft.AssemblyLoadEventRequest); }
    public Mono.Debugger.Soft.BreakpointEventRequest CreateBreakpointRequest(Mono.Debugger.Soft.Location loc) { return default(Mono.Debugger.Soft.BreakpointEventRequest); }
    public Mono.Debugger.Soft.BreakpointEventRequest CreateBreakpointRequest(Mono.Debugger.Soft.MethodMirror method, long il_offset) { return default(Mono.Debugger.Soft.BreakpointEventRequest); }
    public Mono.Debugger.Soft.EnumMirror CreateEnumMirror(Mono.Debugger.Soft.TypeMirror type, Mono.Debugger.Soft.PrimitiveValue value) { return default(Mono.Debugger.Soft.EnumMirror); }
    public Mono.Debugger.Soft.ExceptionEventRequest CreateExceptionRequest(Mono.Debugger.Soft.TypeMirror exc_type) { return default(Mono.Debugger.Soft.ExceptionEventRequest); }
    public Mono.Debugger.Soft.ExceptionEventRequest CreateExceptionRequest(Mono.Debugger.Soft.TypeMirror exc_type, bool caught, bool uncaught) { return default(Mono.Debugger.Soft.ExceptionEventRequest); }
    public Mono.Debugger.Soft.MethodEntryEventRequest CreateMethodEntryRequest() { return default(Mono.Debugger.Soft.MethodEntryEventRequest); }
    public Mono.Debugger.Soft.MethodExitEventRequest CreateMethodExitRequest() { return default(Mono.Debugger.Soft.MethodExitEventRequest); }
    public Mono.Debugger.Soft.StepEventRequest CreateStepRequest(Mono.Debugger.Soft.ThreadMirror thread) { return default(Mono.Debugger.Soft.StepEventRequest); }
    public Mono.Debugger.Soft.TypeLoadEventRequest CreateTypeLoadRequest() { return default(Mono.Debugger.Soft.TypeLoadEventRequest); }
    public Mono.Debugger.Soft.PrimitiveValue CreateValue(object value) { return default(Mono.Debugger.Soft.PrimitiveValue); }
    public void Detach() { }
    public void Disconnect() { }
    [System.ObsoleteAttribute("This method was poorly named; use the Detach() method instead")]
    public void Dispose() { }
    public void EnableEvents(params Mono.Debugger.Soft.EventType[] events) { }
    public void EnableEvents(Mono.Debugger.Soft.EventType[] events, Mono.Debugger.Soft.SuspendPolicy suspendPolicy) { }
    public void Exit(int exitCode) { }
    public void ForceDisconnect() { }
    [System.ObsoleteAttribute("Use GetNextEventSet () instead")]
    public Mono.Debugger.Soft.Event GetNextEvent() { return default(Mono.Debugger.Soft.Event); }
    public Mono.Debugger.Soft.Event GetNextEvent(int timeout) { return default(Mono.Debugger.Soft.Event); }
    [System.ObsoleteAttribute("Use GetNextEventSet () instead")]
    public T GetNextEvent<T>() where T : Mono.Debugger.Soft.Event { return default(T); }
    public Mono.Debugger.Soft.EventSet GetNextEventSet() { return default(Mono.Debugger.Soft.EventSet); }
    public System.Collections.Generic.IList<Mono.Debugger.Soft.ThreadMirror> GetThreads() { return default(System.Collections.Generic.IList<Mono.Debugger.Soft.ThreadMirror>); }
    public System.Collections.Generic.IList<Mono.Debugger.Soft.TypeMirror> GetTypes(string name, bool ignoreCase) { return default(System.Collections.Generic.IList<Mono.Debugger.Soft.TypeMirror>); }
    public System.Collections.Generic.IList<Mono.Debugger.Soft.TypeMirror> GetTypesForSourceFile(string fname, bool ignoreCase) { return default(System.Collections.Generic.IList<Mono.Debugger.Soft.TypeMirror>); }
    public void Resume() { }
    public Mono.Debugger.Soft.BreakpointEventRequest SetBreakpoint(Mono.Debugger.Soft.MethodMirror method, long il_offset) { return default(Mono.Debugger.Soft.BreakpointEventRequest); }
    public void SetSocketTimeouts(int send_timeout, int receive_timeout, int keepalive_interval) { }
    public void Suspend() { }
  }
  public partial class VirtualMachineManager {
    internal VirtualMachineManager() { }
    public static System.IAsyncResult BeginConnect(System.Net.IPEndPoint dbg_ep, System.AsyncCallback callback) { return default(System.IAsyncResult); }
    public static System.IAsyncResult BeginConnect(System.Net.IPEndPoint dbg_ep, System.Net.IPEndPoint con_ep, System.AsyncCallback callback) { return default(System.IAsyncResult); }
    public static System.IAsyncResult BeginLaunch(System.Diagnostics.ProcessStartInfo info, System.AsyncCallback callback) { return default(System.IAsyncResult); }
    public static System.IAsyncResult BeginLaunch(System.Diagnostics.ProcessStartInfo info, System.AsyncCallback callback, Mono.Debugger.Soft.LaunchOptions options) { return default(System.IAsyncResult); }
    public static System.IAsyncResult BeginListen(System.Net.IPEndPoint dbg_ep, System.AsyncCallback callback) { return default(System.IAsyncResult); }
    public static System.IAsyncResult BeginListen(System.Net.IPEndPoint dbg_ep, System.Net.IPEndPoint con_ep, System.AsyncCallback callback) { return default(System.IAsyncResult); }
    public static System.IAsyncResult BeginListen(System.Net.IPEndPoint dbg_ep, System.Net.IPEndPoint con_ep, System.AsyncCallback callback, out int dbg_port, out int con_port) { dbg_port = default(int); con_port = default(int); return default(System.IAsyncResult); }
    public static void CancelConnection(System.IAsyncResult asyncResult) { }
    public static Mono.Debugger.Soft.VirtualMachine Connect(Mono.Debugger.Soft.Connection transport, System.IO.StreamReader standardOutput, System.IO.StreamReader standardError) { return default(Mono.Debugger.Soft.VirtualMachine); }
    public static Mono.Debugger.Soft.VirtualMachine Connect(System.Net.IPEndPoint endpoint) { return default(Mono.Debugger.Soft.VirtualMachine); }
    public static Mono.Debugger.Soft.VirtualMachine Connect(System.Net.IPEndPoint endpoint, System.Net.IPEndPoint consoleEndpoint) { return default(Mono.Debugger.Soft.VirtualMachine); }
    public static Mono.Debugger.Soft.VirtualMachine ConnectInternal(System.Net.Sockets.Socket dbg_sock, System.Net.Sockets.Socket con_sock, System.Net.IPEndPoint dbg_ep, System.Net.IPEndPoint con_ep) { return default(Mono.Debugger.Soft.VirtualMachine); }
    public static Mono.Debugger.Soft.VirtualMachine EndConnect(System.IAsyncResult asyncResult) { return default(Mono.Debugger.Soft.VirtualMachine); }
    public static Mono.Debugger.Soft.VirtualMachine EndLaunch(System.IAsyncResult asyncResult) { return default(Mono.Debugger.Soft.VirtualMachine); }
    public static Mono.Debugger.Soft.VirtualMachine EndListen(System.IAsyncResult asyncResult) { return default(Mono.Debugger.Soft.VirtualMachine); }
    public static Mono.Debugger.Soft.VirtualMachine Launch(System.Diagnostics.ProcessStartInfo info) { return default(Mono.Debugger.Soft.VirtualMachine); }
    public static Mono.Debugger.Soft.VirtualMachine Launch(System.Diagnostics.ProcessStartInfo info, Mono.Debugger.Soft.LaunchOptions options) { return default(Mono.Debugger.Soft.VirtualMachine); }
    public static Mono.Debugger.Soft.VirtualMachine Launch(System.String[] args) { return default(Mono.Debugger.Soft.VirtualMachine); }
    public static Mono.Debugger.Soft.VirtualMachine Launch(System.String[] args, Mono.Debugger.Soft.LaunchOptions options) { return default(Mono.Debugger.Soft.VirtualMachine); }
    public static Mono.Debugger.Soft.VirtualMachine LaunchInternal(Mono.Debugger.Soft.ITargetProcess p, System.Diagnostics.ProcessStartInfo info, System.Net.Sockets.Socket socket) { return default(Mono.Debugger.Soft.VirtualMachine); }
    public static Mono.Debugger.Soft.VirtualMachine LaunchInternal(System.Diagnostics.Process p, System.Diagnostics.ProcessStartInfo info, System.Net.Sockets.Socket socket) { return default(Mono.Debugger.Soft.VirtualMachine); }
    public static Mono.Debugger.Soft.VirtualMachine Listen(System.Net.IPEndPoint dbg_ep) { return default(Mono.Debugger.Soft.VirtualMachine); }
    public static Mono.Debugger.Soft.VirtualMachine Listen(System.Net.IPEndPoint dbg_ep, System.Net.IPEndPoint con_ep) { return default(Mono.Debugger.Soft.VirtualMachine); }
    public static Mono.Debugger.Soft.VirtualMachine ListenInternal(System.Net.Sockets.Socket dbg_sock, System.Net.Sockets.Socket con_sock) { return default(Mono.Debugger.Soft.VirtualMachine); }
  }
  public partial class VMDeathEvent : Mono.Debugger.Soft.Event {
    public VMDeathEvent(Mono.Debugger.Soft.VirtualMachine vm, int req_id, int exit_code) { }
    public int ExitCode { get { return default(int); } }
  }
  public partial class VMDisconnectedException : System.Exception {
    public VMDisconnectedException() { }
  }
  public partial class VMDisconnectEvent : Mono.Debugger.Soft.Event {
    public VMDisconnectEvent(Mono.Debugger.Soft.VirtualMachine vm, int req_id) { }
  }
  public partial class VMMismatchException : System.Exception {
    public VMMismatchException() { }
  }
  public partial class VMNotSuspendedException : System.InvalidOperationException {
    public VMNotSuspendedException() { }
  }
  public partial class VMStartEvent : Mono.Debugger.Soft.Event {
    public VMStartEvent(Mono.Debugger.Soft.VirtualMachine vm, int req_id, long thread_id) { }
  }
}
