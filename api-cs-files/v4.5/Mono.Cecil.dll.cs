namespace Mono.Cecil {
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct ArrayDimension {
    public ArrayDimension(System.Nullable<System.Int32> lowerBound, System.Nullable<System.Int32> upperBound) { throw new System.NotImplementedException(); }
    public bool IsSized { get { return default(bool); } }
    public System.Nullable<System.Int32> LowerBound { get { return default(System.Nullable<System.Int32>); } set { } }
    public System.Nullable<System.Int32> UpperBound { get { return default(System.Nullable<System.Int32>); } set { } }
    public override string ToString() { return default(string); }
  }
  public sealed partial class ArrayMarshalInfo : Mono.Cecil.MarshalInfo {
    public ArrayMarshalInfo() : base (default(Mono.Cecil.NativeType)) { }
    public Mono.Cecil.NativeType ElementType { get { return default(Mono.Cecil.NativeType); } set { } }
    public int Size { get { return default(int); } set { } }
    public int SizeParameterIndex { get { return default(int); } set { } }
    public int SizeParameterMultiplier { get { return default(int); } set { } }
  }
  public sealed partial class ArrayType : Mono.Cecil.TypeSpecification {
    public ArrayType(Mono.Cecil.TypeReference type) { }
    public ArrayType(Mono.Cecil.TypeReference type, int rank) { }
    public Mono.Collections.Generic.Collection<Mono.Cecil.ArrayDimension> Dimensions { get { return default(Mono.Collections.Generic.Collection<Mono.Cecil.ArrayDimension>); } }
    public override string FullName { get { return default(string); } }
    public override bool IsArray { get { return default(bool); } }
    public override bool IsValueType { get { return default(bool); } set { } }
    public bool IsVector { get { return default(bool); } }
    public override string Name { get { return default(string); } }
    public int Rank { get { return default(int); } }
  }
  [System.FlagsAttribute]
  public enum AssemblyAttributes : uint {
    DisableJITCompileOptimizer = (uint)16384,
    EnableJITCompileTracking = (uint)32768,
    PublicKey = (uint)1,
    Retargetable = (uint)256,
    SideBySideCompatible = (uint)0,
    WindowsRuntime = (uint)512,
  }
  public sealed partial class AssemblyDefinition : Mono.Cecil.ICustomAttributeProvider, Mono.Cecil.IMetadataTokenProvider, Mono.Cecil.ISecurityDeclarationProvider {
    internal AssemblyDefinition() { }
    public Mono.Collections.Generic.Collection<Mono.Cecil.CustomAttribute> CustomAttributes { get { return default(Mono.Collections.Generic.Collection<Mono.Cecil.CustomAttribute>); } }
    public Mono.Cecil.MethodDefinition EntryPoint { get { return default(Mono.Cecil.MethodDefinition); } set { } }
    public string FullName { get { return default(string); } }
    public bool HasCustomAttributes { get { return default(bool); } }
    public bool HasSecurityDeclarations { get { return default(bool); } }
    public Mono.Cecil.ModuleDefinition MainModule { get { return default(Mono.Cecil.ModuleDefinition); } }
    public Mono.Cecil.MetadataToken MetadataToken { get { return default(Mono.Cecil.MetadataToken); } set { } }
    public Mono.Collections.Generic.Collection<Mono.Cecil.ModuleDefinition> Modules { get { return default(Mono.Collections.Generic.Collection<Mono.Cecil.ModuleDefinition>); } }
    public Mono.Cecil.AssemblyNameDefinition Name { get { return default(Mono.Cecil.AssemblyNameDefinition); } set { } }
    public Mono.Collections.Generic.Collection<Mono.Cecil.SecurityDeclaration> SecurityDeclarations { get { return default(Mono.Collections.Generic.Collection<Mono.Cecil.SecurityDeclaration>); } }
    public static Mono.Cecil.AssemblyDefinition CreateAssembly(Mono.Cecil.AssemblyNameDefinition assemblyName, string moduleName, Mono.Cecil.ModuleKind kind) { return default(Mono.Cecil.AssemblyDefinition); }
    public static Mono.Cecil.AssemblyDefinition CreateAssembly(Mono.Cecil.AssemblyNameDefinition assemblyName, string moduleName, Mono.Cecil.ModuleParameters parameters) { return default(Mono.Cecil.AssemblyDefinition); }
    public static Mono.Cecil.AssemblyDefinition ReadAssembly(System.IO.Stream stream) { return default(Mono.Cecil.AssemblyDefinition); }
    public static Mono.Cecil.AssemblyDefinition ReadAssembly(System.IO.Stream stream, Mono.Cecil.ReaderParameters parameters) { return default(Mono.Cecil.AssemblyDefinition); }
    public static Mono.Cecil.AssemblyDefinition ReadAssembly(string fileName) { return default(Mono.Cecil.AssemblyDefinition); }
    public static Mono.Cecil.AssemblyDefinition ReadAssembly(string fileName, Mono.Cecil.ReaderParameters parameters) { return default(Mono.Cecil.AssemblyDefinition); }
    public override string ToString() { return default(string); }
    public void Write(System.IO.Stream stream) { }
    public void Write(System.IO.Stream stream, Mono.Cecil.WriterParameters parameters) { }
    public void Write(string fileName) { }
    public void Write(string fileName, Mono.Cecil.WriterParameters parameters) { }
  }
  public enum AssemblyHashAlgorithm : uint {
    None = (uint)0,
    Reserved = (uint)32771,
    SHA1 = (uint)32772,
  }
  public sealed partial class AssemblyLinkedResource : Mono.Cecil.Resource {
    public AssemblyLinkedResource(string name, Mono.Cecil.ManifestResourceAttributes flags) { }
    public AssemblyLinkedResource(string name, Mono.Cecil.ManifestResourceAttributes flags, Mono.Cecil.AssemblyNameReference reference) { }
    public Mono.Cecil.AssemblyNameReference Assembly { get { return default(Mono.Cecil.AssemblyNameReference); } set { } }
    public override Mono.Cecil.ResourceType ResourceType { get { return default(Mono.Cecil.ResourceType); } }
  }
  public sealed partial class AssemblyNameDefinition : Mono.Cecil.AssemblyNameReference {
    public AssemblyNameDefinition(string name, System.Version version) : base (default(string), default(System.Version)) { }
    public override System.Byte[] Hash { get { return default(System.Byte[]); } }
  }
  public partial class AssemblyNameReference : Mono.Cecil.IMetadataScope, Mono.Cecil.IMetadataTokenProvider {
    public AssemblyNameReference(string name, System.Version version) { }
    public Mono.Cecil.AssemblyAttributes Attributes { get { return default(Mono.Cecil.AssemblyAttributes); } set { } }
    public string Culture { get { return default(string); } set { } }
    public string FullName { get { return default(string); } }
    public virtual System.Byte[] Hash { get { return default(System.Byte[]); } set { } }
    public Mono.Cecil.AssemblyHashAlgorithm HashAlgorithm { get { return default(Mono.Cecil.AssemblyHashAlgorithm); } set { } }
    public bool HasPublicKey { get { return default(bool); } set { } }
    public bool IsRetargetable { get { return default(bool); } set { } }
    public bool IsSideBySideCompatible { get { return default(bool); } set { } }
    public bool IsWindowsRuntime { get { return default(bool); } set { } }
    public virtual Mono.Cecil.MetadataScopeType MetadataScopeType { get { return default(Mono.Cecil.MetadataScopeType); } }
    public Mono.Cecil.MetadataToken MetadataToken { get { return default(Mono.Cecil.MetadataToken); } set { } }
    public string Name { get { return default(string); } set { } }
    public System.Byte[] PublicKey { get { return default(System.Byte[]); } set { } }
    public System.Byte[] PublicKeyToken { get { return default(System.Byte[]); } set { } }
    public System.Version Version { get { return default(System.Version); } set { } }
    public static Mono.Cecil.AssemblyNameReference Parse(string fullName) { return default(Mono.Cecil.AssemblyNameReference); }
    public override string ToString() { return default(string); }
  }
  public partial class AssemblyResolutionException : System.IO.FileNotFoundException {
    public AssemblyResolutionException(Mono.Cecil.AssemblyNameReference reference) { }
    protected AssemblyResolutionException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public Mono.Cecil.AssemblyNameReference AssemblyReference { get { return default(Mono.Cecil.AssemblyNameReference); } }
  }
  public sealed partial class AssemblyResolveEventArgs : System.EventArgs {
    public AssemblyResolveEventArgs(Mono.Cecil.AssemblyNameReference reference) { }
    public Mono.Cecil.AssemblyNameReference AssemblyReference { get { return default(Mono.Cecil.AssemblyNameReference); } }
  }
  public delegate Mono.Cecil.AssemblyDefinition AssemblyResolveEventHandler(object sender, Mono.Cecil.AssemblyNameReference reference);
  public abstract partial class BaseAssemblyResolver : Mono.Cecil.IAssemblyResolver {
    protected BaseAssemblyResolver() { }
    public event Mono.Cecil.AssemblyResolveEventHandler ResolveFailure { add { } remove { } }
    public void AddSearchDirectory(string directory) { }
    public System.String[] GetSearchDirectories() { return default(System.String[]); }
    public void RemoveSearchDirectory(string directory) { }
    public virtual Mono.Cecil.AssemblyDefinition Resolve(Mono.Cecil.AssemblyNameReference name) { return default(Mono.Cecil.AssemblyDefinition); }
    public virtual Mono.Cecil.AssemblyDefinition Resolve(Mono.Cecil.AssemblyNameReference name, Mono.Cecil.ReaderParameters parameters) { return default(Mono.Cecil.AssemblyDefinition); }
    public virtual Mono.Cecil.AssemblyDefinition Resolve(string fullName) { return default(Mono.Cecil.AssemblyDefinition); }
    public virtual Mono.Cecil.AssemblyDefinition Resolve(string fullName, Mono.Cecil.ReaderParameters parameters) { return default(Mono.Cecil.AssemblyDefinition); }
  }
  public sealed partial class ByReferenceType : Mono.Cecil.TypeSpecification {
    public ByReferenceType(Mono.Cecil.TypeReference type) { }
    public override string FullName { get { return default(string); } }
    public override bool IsByReference { get { return default(bool); } }
    public override bool IsValueType { get { return default(bool); } set { } }
    public override string Name { get { return default(string); } }
  }
  public sealed partial class CallSite : Mono.Cecil.IMetadataTokenProvider, Mono.Cecil.IMethodSignature {
    public CallSite(Mono.Cecil.TypeReference returnType) { }
    public Mono.Cecil.MethodCallingConvention CallingConvention { get { return default(Mono.Cecil.MethodCallingConvention); } set { } }
    public bool ExplicitThis { get { return default(bool); } set { } }
    public string FullName { get { return default(string); } }
    public bool HasParameters { get { return default(bool); } }
    public bool HasThis { get { return default(bool); } set { } }
    public Mono.Cecil.MetadataToken MetadataToken { get { return default(Mono.Cecil.MetadataToken); } set { } }
    public Mono.Cecil.MethodReturnType MethodReturnType { get { return default(Mono.Cecil.MethodReturnType); } }
    public Mono.Cecil.ModuleDefinition Module { get { return default(Mono.Cecil.ModuleDefinition); } }
    public string Name { get { return default(string); } set { } }
    public string Namespace { get { return default(string); } set { } }
    public Mono.Collections.Generic.Collection<Mono.Cecil.ParameterDefinition> Parameters { get { return default(Mono.Collections.Generic.Collection<Mono.Cecil.ParameterDefinition>); } }
    public Mono.Cecil.TypeReference ReturnType { get { return default(Mono.Cecil.TypeReference); } set { } }
    public Mono.Cecil.IMetadataScope Scope { get { return default(Mono.Cecil.IMetadataScope); } }
    public override string ToString() { return default(string); }
  }
  public sealed partial class CustomAttribute : Mono.Cecil.ICustomAttribute {
    public CustomAttribute(Mono.Cecil.MethodReference constructor) { }
    public CustomAttribute(Mono.Cecil.MethodReference constructor, System.Byte[] blob) { }
    public Mono.Cecil.TypeReference AttributeType { get { return default(Mono.Cecil.TypeReference); } }
    public Mono.Cecil.MethodReference Constructor { get { return default(Mono.Cecil.MethodReference); } set { } }
    public Mono.Collections.Generic.Collection<Mono.Cecil.CustomAttributeArgument> ConstructorArguments { get { return default(Mono.Collections.Generic.Collection<Mono.Cecil.CustomAttributeArgument>); } }
    public Mono.Collections.Generic.Collection<Mono.Cecil.CustomAttributeNamedArgument> Fields { get { return default(Mono.Collections.Generic.Collection<Mono.Cecil.CustomAttributeNamedArgument>); } }
    public bool HasConstructorArguments { get { return default(bool); } }
    public bool HasFields { get { return default(bool); } }
    public bool HasProperties { get { return default(bool); } }
    public bool IsResolved { get { return default(bool); } }
    public Mono.Collections.Generic.Collection<Mono.Cecil.CustomAttributeNamedArgument> Properties { get { return default(Mono.Collections.Generic.Collection<Mono.Cecil.CustomAttributeNamedArgument>); } }
    public System.Byte[] GetBlob() { return default(System.Byte[]); }
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct CustomAttributeArgument {
    public CustomAttributeArgument(Mono.Cecil.TypeReference type, object value) { throw new System.NotImplementedException(); }
    public Mono.Cecil.TypeReference Type { get { return default(Mono.Cecil.TypeReference); } }
    public object Value { get { return default(object); } }
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct CustomAttributeNamedArgument {
    public CustomAttributeNamedArgument(string name, Mono.Cecil.CustomAttributeArgument argument) { throw new System.NotImplementedException(); }
    public Mono.Cecil.CustomAttributeArgument Argument { get { return default(Mono.Cecil.CustomAttributeArgument); } }
    public string Name { get { return default(string); } }
  }
  public sealed partial class CustomMarshalInfo : Mono.Cecil.MarshalInfo {
    public CustomMarshalInfo() : base (default(Mono.Cecil.NativeType)) { }
    public string Cookie { get { return default(string); } set { } }
    public System.Guid Guid { get { return default(System.Guid); } set { } }
    public Mono.Cecil.TypeReference ManagedType { get { return default(Mono.Cecil.TypeReference); } set { } }
    public string UnmanagedType { get { return default(string); } set { } }
  }
  public partial class DefaultAssemblyResolver : Mono.Cecil.BaseAssemblyResolver {
    public DefaultAssemblyResolver() { }
    protected void RegisterAssembly(Mono.Cecil.AssemblyDefinition assembly) { }
    public override Mono.Cecil.AssemblyDefinition Resolve(Mono.Cecil.AssemblyNameReference name) { return default(Mono.Cecil.AssemblyDefinition); }
  }
  public sealed partial class EmbeddedResource : Mono.Cecil.Resource {
    public EmbeddedResource(string name, Mono.Cecil.ManifestResourceAttributes attributes, System.Byte[] data) { }
    public EmbeddedResource(string name, Mono.Cecil.ManifestResourceAttributes attributes, System.IO.Stream stream) { }
    public override Mono.Cecil.ResourceType ResourceType { get { return default(Mono.Cecil.ResourceType); } }
    public System.Byte[] GetResourceData() { return default(System.Byte[]); }
    public System.IO.Stream GetResourceStream() { return default(System.IO.Stream); }
  }
  [System.FlagsAttribute]
  public enum EventAttributes : ushort {
    None = (ushort)0,
    RTSpecialName = (ushort)1024,
    SpecialName = (ushort)512,
  }
  public sealed partial class EventDefinition : Mono.Cecil.EventReference, Mono.Cecil.ICustomAttributeProvider, Mono.Cecil.IMemberDefinition, Mono.Cecil.IMetadataTokenProvider {
    public EventDefinition(string name, Mono.Cecil.EventAttributes attributes, Mono.Cecil.TypeReference eventType) : base (default(string), default(Mono.Cecil.TypeReference)) { }
    public Mono.Cecil.MethodDefinition AddMethod { get { return default(Mono.Cecil.MethodDefinition); } set { } }
    public Mono.Cecil.EventAttributes Attributes { get { return default(Mono.Cecil.EventAttributes); } set { } }
    public Mono.Collections.Generic.Collection<Mono.Cecil.CustomAttribute> CustomAttributes { get { return default(Mono.Collections.Generic.Collection<Mono.Cecil.CustomAttribute>); } }
    public new Mono.Cecil.TypeDefinition DeclaringType { get { return default(Mono.Cecil.TypeDefinition); } set { } }
    public bool HasCustomAttributes { get { return default(bool); } }
    public bool HasOtherMethods { get { return default(bool); } }
    public Mono.Cecil.MethodDefinition InvokeMethod { get { return default(Mono.Cecil.MethodDefinition); } set { } }
    public override bool IsDefinition { get { return default(bool); } }
    public bool IsRuntimeSpecialName { get { return default(bool); } set { } }
    public bool IsSpecialName { get { return default(bool); } set { } }
    public Mono.Collections.Generic.Collection<Mono.Cecil.MethodDefinition> OtherMethods { get { return default(Mono.Collections.Generic.Collection<Mono.Cecil.MethodDefinition>); } }
    public Mono.Cecil.MethodDefinition RemoveMethod { get { return default(Mono.Cecil.MethodDefinition); } set { } }
    public override Mono.Cecil.EventDefinition Resolve() { return default(Mono.Cecil.EventDefinition); }
  }
  public abstract partial class EventReference : Mono.Cecil.MemberReference {
    protected EventReference(string name, Mono.Cecil.TypeReference eventType) { }
    public Mono.Cecil.TypeReference EventType { get { return default(Mono.Cecil.TypeReference); } set { } }
    public override string FullName { get { return default(string); } }
    public abstract Mono.Cecil.EventDefinition Resolve();
  }
  public partial class ExportedType : Mono.Cecil.IMetadataTokenProvider {
    public ExportedType(string @namespace, string name, Mono.Cecil.ModuleDefinition module, Mono.Cecil.IMetadataScope scope) { }
    public Mono.Cecil.TypeAttributes Attributes { get { return default(Mono.Cecil.TypeAttributes); } set { } }
    public Mono.Cecil.ExportedType DeclaringType { get { return default(Mono.Cecil.ExportedType); } set { } }
    public string FullName { get { return default(string); } }
    public bool HasSecurity { get { return default(bool); } set { } }
    public int Identifier { get { return default(int); } set { } }
    public bool IsAbstract { get { return default(bool); } set { } }
    public bool IsAnsiClass { get { return default(bool); } set { } }
    public bool IsAutoClass { get { return default(bool); } set { } }
    public bool IsAutoLayout { get { return default(bool); } set { } }
    public bool IsBeforeFieldInit { get { return default(bool); } set { } }
    public bool IsClass { get { return default(bool); } set { } }
    public bool IsExplicitLayout { get { return default(bool); } set { } }
    public bool IsForwarder { get { return default(bool); } set { } }
    public bool IsImport { get { return default(bool); } set { } }
    public bool IsInterface { get { return default(bool); } set { } }
    public bool IsNestedAssembly { get { return default(bool); } set { } }
    public bool IsNestedFamily { get { return default(bool); } set { } }
    public bool IsNestedFamilyAndAssembly { get { return default(bool); } set { } }
    public bool IsNestedFamilyOrAssembly { get { return default(bool); } set { } }
    public bool IsNestedPrivate { get { return default(bool); } set { } }
    public bool IsNestedPublic { get { return default(bool); } set { } }
    public bool IsNotPublic { get { return default(bool); } set { } }
    public bool IsPublic { get { return default(bool); } set { } }
    public bool IsRuntimeSpecialName { get { return default(bool); } set { } }
    public bool IsSealed { get { return default(bool); } set { } }
    public bool IsSequentialLayout { get { return default(bool); } set { } }
    public bool IsSerializable { get { return default(bool); } set { } }
    public bool IsSpecialName { get { return default(bool); } set { } }
    public bool IsUnicodeClass { get { return default(bool); } set { } }
    public Mono.Cecil.MetadataToken MetadataToken { get { return default(Mono.Cecil.MetadataToken); } set { } }
    public string Name { get { return default(string); } set { } }
    public string Namespace { get { return default(string); } set { } }
    public Mono.Cecil.IMetadataScope Scope { get { return default(Mono.Cecil.IMetadataScope); } }
    public Mono.Cecil.TypeDefinition Resolve() { return default(Mono.Cecil.TypeDefinition); }
    public override string ToString() { return default(string); }
  }
  [System.FlagsAttribute]
  public enum FieldAttributes : ushort {
    Assembly = (ushort)3,
    CompilerControlled = (ushort)0,
    FamANDAssem = (ushort)2,
    Family = (ushort)4,
    FamORAssem = (ushort)5,
    FieldAccessMask = (ushort)7,
    HasDefault = (ushort)32768,
    HasFieldMarshal = (ushort)4096,
    HasFieldRVA = (ushort)256,
    InitOnly = (ushort)32,
    Literal = (ushort)64,
    NotSerialized = (ushort)128,
    PInvokeImpl = (ushort)8192,
    Private = (ushort)1,
    Public = (ushort)6,
    RTSpecialName = (ushort)1024,
    SpecialName = (ushort)512,
    Static = (ushort)16,
  }
  public sealed partial class FieldDefinition : Mono.Cecil.FieldReference, Mono.Cecil.IConstantProvider, Mono.Cecil.ICustomAttributeProvider, Mono.Cecil.IMarshalInfoProvider, Mono.Cecil.IMemberDefinition, Mono.Cecil.IMetadataTokenProvider {
    public FieldDefinition(string name, Mono.Cecil.FieldAttributes attributes, Mono.Cecil.TypeReference fieldType) : base (default(string), default(Mono.Cecil.TypeReference)) { }
    public Mono.Cecil.FieldAttributes Attributes { get { return default(Mono.Cecil.FieldAttributes); } set { } }
    public object Constant { get { return default(object); } set { } }
    public Mono.Collections.Generic.Collection<Mono.Cecil.CustomAttribute> CustomAttributes { get { return default(Mono.Collections.Generic.Collection<Mono.Cecil.CustomAttribute>); } }
    public new Mono.Cecil.TypeDefinition DeclaringType { get { return default(Mono.Cecil.TypeDefinition); } set { } }
    public bool HasConstant { get { return default(bool); } set { } }
    public bool HasCustomAttributes { get { return default(bool); } }
    public bool HasDefault { get { return default(bool); } set { } }
    public bool HasLayoutInfo { get { return default(bool); } }
    public bool HasMarshalInfo { get { return default(bool); } }
    public System.Byte[] InitialValue { get { return default(System.Byte[]); } set { } }
    public bool IsAssembly { get { return default(bool); } set { } }
    public bool IsCompilerControlled { get { return default(bool); } set { } }
    public override bool IsDefinition { get { return default(bool); } }
    public bool IsFamily { get { return default(bool); } set { } }
    public bool IsFamilyAndAssembly { get { return default(bool); } set { } }
    public bool IsFamilyOrAssembly { get { return default(bool); } set { } }
    public bool IsInitOnly { get { return default(bool); } set { } }
    public bool IsLiteral { get { return default(bool); } set { } }
    public bool IsNotSerialized { get { return default(bool); } set { } }
    public bool IsPInvokeImpl { get { return default(bool); } set { } }
    public bool IsPrivate { get { return default(bool); } set { } }
    public bool IsPublic { get { return default(bool); } set { } }
    public bool IsRuntimeSpecialName { get { return default(bool); } set { } }
    public bool IsSpecialName { get { return default(bool); } set { } }
    public bool IsStatic { get { return default(bool); } set { } }
    public Mono.Cecil.MarshalInfo MarshalInfo { get { return default(Mono.Cecil.MarshalInfo); } set { } }
    public int Offset { get { return default(int); } set { } }
    public int RVA { get { return default(int); } }
    public override Mono.Cecil.FieldDefinition Resolve() { return default(Mono.Cecil.FieldDefinition); }
  }
  public partial class FieldReference : Mono.Cecil.MemberReference {
    public FieldReference(string name, Mono.Cecil.TypeReference fieldType) { }
    public FieldReference(string name, Mono.Cecil.TypeReference fieldType, Mono.Cecil.TypeReference declaringType) { }
    public Mono.Cecil.TypeReference FieldType { get { return default(Mono.Cecil.TypeReference); } set { } }
    public override string FullName { get { return default(string); } }
    public virtual Mono.Cecil.FieldDefinition Resolve() { return default(Mono.Cecil.FieldDefinition); }
  }
  public sealed partial class FixedArrayMarshalInfo : Mono.Cecil.MarshalInfo {
    public FixedArrayMarshalInfo() : base (default(Mono.Cecil.NativeType)) { }
    public Mono.Cecil.NativeType ElementType { get { return default(Mono.Cecil.NativeType); } set { } }
    public int Size { get { return default(int); } set { } }
  }
  public sealed partial class FixedSysStringMarshalInfo : Mono.Cecil.MarshalInfo {
    public FixedSysStringMarshalInfo() : base (default(Mono.Cecil.NativeType)) { }
    public int Size { get { return default(int); } set { } }
  }
  public sealed partial class FunctionPointerType : Mono.Cecil.TypeSpecification, Mono.Cecil.IMetadataTokenProvider, Mono.Cecil.IMethodSignature {
    public FunctionPointerType() { }
    public Mono.Cecil.MethodCallingConvention CallingConvention { get { return default(Mono.Cecil.MethodCallingConvention); } set { } }
    public bool ExplicitThis { get { return default(bool); } set { } }
    public override string FullName { get { return default(string); } }
    public bool HasParameters { get { return default(bool); } }
    public bool HasThis { get { return default(bool); } set { } }
    public override bool IsFunctionPointer { get { return default(bool); } }
    public Mono.Cecil.MethodReturnType MethodReturnType { get { return default(Mono.Cecil.MethodReturnType); } }
    public override Mono.Cecil.ModuleDefinition Module { get { return default(Mono.Cecil.ModuleDefinition); } }
    public override string Name { get { return default(string); } set { } }
    public override string Namespace { get { return default(string); } set { } }
    public Mono.Collections.Generic.Collection<Mono.Cecil.ParameterDefinition> Parameters { get { return default(Mono.Collections.Generic.Collection<Mono.Cecil.ParameterDefinition>); } }
    public Mono.Cecil.TypeReference ReturnType { get { return default(Mono.Cecil.TypeReference); } set { } }
    public override Mono.Cecil.IMetadataScope Scope { get { return default(Mono.Cecil.IMetadataScope); } set { } }
    public override Mono.Cecil.TypeReference GetElementType() { return default(Mono.Cecil.TypeReference); }
    public override Mono.Cecil.TypeDefinition Resolve() { return default(Mono.Cecil.TypeDefinition); }
  }
  public sealed partial class GenericInstanceMethod : Mono.Cecil.MethodSpecification, Mono.Cecil.IGenericInstance, Mono.Cecil.IMetadataTokenProvider {
    public GenericInstanceMethod(Mono.Cecil.MethodReference method) { }
    public override string FullName { get { return default(string); } }
    public Mono.Collections.Generic.Collection<Mono.Cecil.TypeReference> GenericArguments { get { return default(Mono.Collections.Generic.Collection<Mono.Cecil.TypeReference>); } }
    public bool HasGenericArguments { get { return default(bool); } }
    public override bool IsGenericInstance { get { return default(bool); } }
  }
  public sealed partial class GenericInstanceType : Mono.Cecil.TypeSpecification, Mono.Cecil.IGenericInstance, Mono.Cecil.IMetadataTokenProvider {
    public GenericInstanceType(Mono.Cecil.TypeReference type) { }
    public override Mono.Cecil.TypeReference DeclaringType { get { return default(Mono.Cecil.TypeReference); } set { } }
    public override string FullName { get { return default(string); } }
    public Mono.Collections.Generic.Collection<Mono.Cecil.TypeReference> GenericArguments { get { return default(Mono.Collections.Generic.Collection<Mono.Cecil.TypeReference>); } }
    public bool HasGenericArguments { get { return default(bool); } }
    public override bool IsGenericInstance { get { return default(bool); } }
  }
  public sealed partial class GenericParameter : Mono.Cecil.TypeReference, Mono.Cecil.ICustomAttributeProvider, Mono.Cecil.IMetadataTokenProvider {
    public GenericParameter(Mono.Cecil.IGenericParameterProvider owner) : base (default(string), default(string)) { }
    public GenericParameter(int position, Mono.Cecil.GenericParameterType type, Mono.Cecil.ModuleDefinition module) : base (default(string), default(string)) { }
    public GenericParameter(string name, Mono.Cecil.IGenericParameterProvider owner) : base (default(string), default(string)) { }
    public Mono.Cecil.GenericParameterAttributes Attributes { get { return default(Mono.Cecil.GenericParameterAttributes); } set { } }
    public Mono.Collections.Generic.Collection<Mono.Cecil.TypeReference> Constraints { get { return default(Mono.Collections.Generic.Collection<Mono.Cecil.TypeReference>); } }
    public Mono.Collections.Generic.Collection<Mono.Cecil.CustomAttribute> CustomAttributes { get { return default(Mono.Collections.Generic.Collection<Mono.Cecil.CustomAttribute>); } }
    public Mono.Cecil.MethodReference DeclaringMethod { get { return default(Mono.Cecil.MethodReference); } }
    public override Mono.Cecil.TypeReference DeclaringType { get { return default(Mono.Cecil.TypeReference); } set { } }
    public override string FullName { get { return default(string); } }
    public bool HasConstraints { get { return default(bool); } }
    public bool HasCustomAttributes { get { return default(bool); } }
    public bool HasDefaultConstructorConstraint { get { return default(bool); } set { } }
    public bool HasNotNullableValueTypeConstraint { get { return default(bool); } set { } }
    public bool HasReferenceTypeConstraint { get { return default(bool); } set { } }
    public bool IsContravariant { get { return default(bool); } set { } }
    public bool IsCovariant { get { return default(bool); } set { } }
    public override bool IsGenericParameter { get { return default(bool); } }
    public bool IsNonVariant { get { return default(bool); } set { } }
    public override Mono.Cecil.MetadataType MetadataType { get { return default(Mono.Cecil.MetadataType); } }
    public override Mono.Cecil.ModuleDefinition Module { get { return default(Mono.Cecil.ModuleDefinition); } }
    public override string Name { get { return default(string); } }
    public override string Namespace { get { return default(string); } set { } }
    public Mono.Cecil.IGenericParameterProvider Owner { get { return default(Mono.Cecil.IGenericParameterProvider); } }
    public int Position { get { return default(int); } }
    public override Mono.Cecil.IMetadataScope Scope { get { return default(Mono.Cecil.IMetadataScope); } set { } }
    public Mono.Cecil.GenericParameterType Type { get { return default(Mono.Cecil.GenericParameterType); } }
    public override Mono.Cecil.TypeDefinition Resolve() { return default(Mono.Cecil.TypeDefinition); }
  }
  [System.FlagsAttribute]
  public enum GenericParameterAttributes : ushort {
    Contravariant = (ushort)2,
    Covariant = (ushort)1,
    DefaultConstructorConstraint = (ushort)16,
    NonVariant = (ushort)0,
    NotNullableValueTypeConstraint = (ushort)8,
    ReferenceTypeConstraint = (ushort)4,
    SpecialConstraintMask = (ushort)28,
    VarianceMask = (ushort)3,
  }
  public enum GenericParameterType {
    Method = 1,
    Type = 0,
  }
  public partial interface IAssemblyResolver {
    Mono.Cecil.AssemblyDefinition Resolve(Mono.Cecil.AssemblyNameReference name);
    Mono.Cecil.AssemblyDefinition Resolve(Mono.Cecil.AssemblyNameReference name, Mono.Cecil.ReaderParameters parameters);
    Mono.Cecil.AssemblyDefinition Resolve(string fullName);
    Mono.Cecil.AssemblyDefinition Resolve(string fullName, Mono.Cecil.ReaderParameters parameters);
  }
  public partial interface IConstantProvider : Mono.Cecil.IMetadataTokenProvider {
    object Constant { get; set; }
    bool HasConstant { get; set; }
  }
  public partial interface ICustomAttribute {
    Mono.Cecil.TypeReference AttributeType { get; }
    Mono.Collections.Generic.Collection<Mono.Cecil.CustomAttributeNamedArgument> Fields { get; }
    bool HasFields { get; }
    bool HasProperties { get; }
    Mono.Collections.Generic.Collection<Mono.Cecil.CustomAttributeNamedArgument> Properties { get; }
  }
  public partial interface ICustomAttributeProvider : Mono.Cecil.IMetadataTokenProvider {
    Mono.Collections.Generic.Collection<Mono.Cecil.CustomAttribute> CustomAttributes { get; }
    bool HasCustomAttributes { get; }
  }
  public partial interface IGenericInstance : Mono.Cecil.IMetadataTokenProvider {
    Mono.Collections.Generic.Collection<Mono.Cecil.TypeReference> GenericArguments { get; }
    bool HasGenericArguments { get; }
  }
  public partial interface IGenericParameterProvider : Mono.Cecil.IMetadataTokenProvider {
    Mono.Collections.Generic.Collection<Mono.Cecil.GenericParameter> GenericParameters { get; }
    Mono.Cecil.GenericParameterType GenericParameterType { get; }
    bool HasGenericParameters { get; }
    bool IsDefinition { get; }
    Mono.Cecil.ModuleDefinition Module { get; }
  }
  public partial interface IMarshalInfoProvider : Mono.Cecil.IMetadataTokenProvider {
    bool HasMarshalInfo { get; }
    Mono.Cecil.MarshalInfo MarshalInfo { get; set; }
  }
  public partial interface IMemberDefinition : Mono.Cecil.ICustomAttributeProvider, Mono.Cecil.IMetadataTokenProvider {
    Mono.Cecil.TypeDefinition DeclaringType { get; set; }
    string FullName { get; }
    bool IsRuntimeSpecialName { get; set; }
    bool IsSpecialName { get; set; }
    string Name { get; set; }
  }
  public partial interface IMetadataResolver {
    Mono.Cecil.FieldDefinition Resolve(Mono.Cecil.FieldReference field);
    Mono.Cecil.MethodDefinition Resolve(Mono.Cecil.MethodReference method);
    Mono.Cecil.TypeDefinition Resolve(Mono.Cecil.TypeReference type);
  }
  public partial interface IMetadataScope : Mono.Cecil.IMetadataTokenProvider {
    Mono.Cecil.MetadataScopeType MetadataScopeType { get; }
    string Name { get; set; }
  }
  public partial interface IMetadataTokenProvider {
    Mono.Cecil.MetadataToken MetadataToken { get; set; }
  }
  public partial interface IMethodSignature : Mono.Cecil.IMetadataTokenProvider {
    Mono.Cecil.MethodCallingConvention CallingConvention { get; set; }
    bool ExplicitThis { get; set; }
    bool HasParameters { get; }
    bool HasThis { get; set; }
    Mono.Cecil.MethodReturnType MethodReturnType { get; }
    Mono.Collections.Generic.Collection<Mono.Cecil.ParameterDefinition> Parameters { get; }
    Mono.Cecil.TypeReference ReturnType { get; set; }
  }
  public partial interface IModifierType {
    Mono.Cecil.TypeReference ElementType { get; }
    Mono.Cecil.TypeReference ModifierType { get; }
  }
  public partial interface ISecurityDeclarationProvider : Mono.Cecil.IMetadataTokenProvider {
    bool HasSecurityDeclarations { get; }
    Mono.Collections.Generic.Collection<Mono.Cecil.SecurityDeclaration> SecurityDeclarations { get; }
  }
  public sealed partial class LinkedResource : Mono.Cecil.Resource {
    public LinkedResource(string name, Mono.Cecil.ManifestResourceAttributes flags) { }
    public LinkedResource(string name, Mono.Cecil.ManifestResourceAttributes flags, string file) { }
    public string File { get { return default(string); } set { } }
    public System.Byte[] Hash { get { return default(System.Byte[]); } }
    public override Mono.Cecil.ResourceType ResourceType { get { return default(Mono.Cecil.ResourceType); } }
  }
  [System.FlagsAttribute]
  public enum ManifestResourceAttributes : uint {
    Private = (uint)2,
    Public = (uint)1,
    VisibilityMask = (uint)7,
  }
  public partial class MarshalInfo {
    public MarshalInfo(Mono.Cecil.NativeType native) { }
    public Mono.Cecil.NativeType NativeType { get { return default(Mono.Cecil.NativeType); } set { } }
  }
  public abstract partial class MemberReference : Mono.Cecil.IMetadataTokenProvider {
    internal MemberReference() { }
    public virtual Mono.Cecil.TypeReference DeclaringType { get { return default(Mono.Cecil.TypeReference); } set { } }
    public abstract string FullName { get; }
    public virtual bool IsDefinition { get { return default(bool); } }
    public Mono.Cecil.MetadataToken MetadataToken { get { return default(Mono.Cecil.MetadataToken); } set { } }
    public virtual Mono.Cecil.ModuleDefinition Module { get { return default(Mono.Cecil.ModuleDefinition); } }
    public virtual string Name { get { return default(string); } set { } }
    public override string ToString() { return default(string); }
  }
  public partial class MetadataResolver : Mono.Cecil.IMetadataResolver {
    public MetadataResolver(Mono.Cecil.IAssemblyResolver assemblyResolver) { }
    public Mono.Cecil.IAssemblyResolver AssemblyResolver { get { return default(Mono.Cecil.IAssemblyResolver); } }
    public static Mono.Cecil.MethodDefinition GetMethod(Mono.Collections.Generic.Collection<Mono.Cecil.MethodDefinition> methods, Mono.Cecil.MethodReference reference) { return default(Mono.Cecil.MethodDefinition); }
    public virtual Mono.Cecil.FieldDefinition Resolve(Mono.Cecil.FieldReference field) { return default(Mono.Cecil.FieldDefinition); }
    public virtual Mono.Cecil.MethodDefinition Resolve(Mono.Cecil.MethodReference method) { return default(Mono.Cecil.MethodDefinition); }
    public virtual Mono.Cecil.TypeDefinition Resolve(Mono.Cecil.TypeReference type) { return default(Mono.Cecil.TypeDefinition); }
  }
  public enum MetadataScopeType {
    AssemblyNameReference = 0,
    ModuleDefinition = 2,
    ModuleReference = 1,
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct MetadataToken {
    public static readonly Mono.Cecil.MetadataToken Zero;
    public MetadataToken(Mono.Cecil.TokenType type) { throw new System.NotImplementedException(); }
    public MetadataToken(Mono.Cecil.TokenType type, int rid) { throw new System.NotImplementedException(); }
    public MetadataToken(Mono.Cecil.TokenType type, uint rid) { throw new System.NotImplementedException(); }
    public MetadataToken(uint token) { throw new System.NotImplementedException(); }
    public uint RID { get { return default(uint); } }
    public Mono.Cecil.TokenType TokenType { get { return default(Mono.Cecil.TokenType); } }
    public override bool Equals(object obj) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public static bool operator ==(Mono.Cecil.MetadataToken one, Mono.Cecil.MetadataToken other) { return default(bool); }
    public static bool operator !=(Mono.Cecil.MetadataToken one, Mono.Cecil.MetadataToken other) { return default(bool); }
    public int ToInt32() { return default(int); }
    public override string ToString() { return default(string); }
    public uint ToUInt32() { return default(uint); }
  }
  public enum MetadataType : byte {
    Array = (byte)20,
    Boolean = (byte)2,
    ByReference = (byte)16,
    Byte = (byte)5,
    Char = (byte)3,
    Class = (byte)18,
    Double = (byte)13,
    FunctionPointer = (byte)27,
    GenericInstance = (byte)21,
    Int16 = (byte)6,
    Int32 = (byte)8,
    Int64 = (byte)10,
    IntPtr = (byte)24,
    MVar = (byte)30,
    Object = (byte)28,
    OptionalModifier = (byte)32,
    Pinned = (byte)69,
    Pointer = (byte)15,
    RequiredModifier = (byte)31,
    SByte = (byte)4,
    Sentinel = (byte)65,
    Single = (byte)12,
    String = (byte)14,
    TypedByReference = (byte)22,
    UInt16 = (byte)7,
    UInt32 = (byte)9,
    UInt64 = (byte)11,
    UIntPtr = (byte)25,
    ValueType = (byte)17,
    Var = (byte)19,
    Void = (byte)1,
  }
  [System.FlagsAttribute]
  public enum MethodAttributes : ushort {
    Abstract = (ushort)1024,
    Assembly = (ushort)3,
    CheckAccessOnOverride = (ushort)512,
    CompilerControlled = (ushort)0,
    FamANDAssem = (ushort)2,
    Family = (ushort)4,
    FamORAssem = (ushort)5,
    Final = (ushort)32,
    HasSecurity = (ushort)16384,
    HideBySig = (ushort)128,
    MemberAccessMask = (ushort)7,
    NewSlot = (ushort)256,
    PInvokeImpl = (ushort)8192,
    Private = (ushort)1,
    Public = (ushort)6,
    RequireSecObject = (ushort)32768,
    ReuseSlot = (ushort)0,
    RTSpecialName = (ushort)4096,
    SpecialName = (ushort)2048,
    Static = (ushort)16,
    UnmanagedExport = (ushort)8,
    Virtual = (ushort)64,
    VtableLayoutMask = (ushort)256,
  }
  public enum MethodCallingConvention : byte {
    C = (byte)1,
    Default = (byte)0,
    FastCall = (byte)4,
    Generic = (byte)16,
    StdCall = (byte)2,
    ThisCall = (byte)3,
    VarArg = (byte)5,
  }
  public sealed partial class MethodDefinition : Mono.Cecil.MethodReference, Mono.Cecil.ICustomAttributeProvider, Mono.Cecil.IMemberDefinition, Mono.Cecil.IMetadataTokenProvider, Mono.Cecil.ISecurityDeclarationProvider {
    public MethodDefinition(string name, Mono.Cecil.MethodAttributes attributes, Mono.Cecil.TypeReference returnType) : base (default(string), default(Mono.Cecil.TypeReference)) { }
    public Mono.Cecil.MethodAttributes Attributes { get { return default(Mono.Cecil.MethodAttributes); } set { } }
    public Mono.Cecil.Cil.MethodBody Body { get { return default(Mono.Cecil.Cil.MethodBody); } set { } }
    public Mono.Collections.Generic.Collection<Mono.Cecil.CustomAttribute> CustomAttributes { get { return default(Mono.Collections.Generic.Collection<Mono.Cecil.CustomAttribute>); } }
    public new Mono.Cecil.TypeDefinition DeclaringType { get { return default(Mono.Cecil.TypeDefinition); } set { } }
    public override Mono.Collections.Generic.Collection<Mono.Cecil.GenericParameter> GenericParameters { get { return default(Mono.Collections.Generic.Collection<Mono.Cecil.GenericParameter>); } }
    public bool HasBody { get { return default(bool); } }
    public bool HasCustomAttributes { get { return default(bool); } }
    public override bool HasGenericParameters { get { return default(bool); } }
    public bool HasOverrides { get { return default(bool); } }
    public bool HasPInvokeInfo { get { return default(bool); } }
    public bool HasSecurity { get { return default(bool); } set { } }
    public bool HasSecurityDeclarations { get { return default(bool); } }
    public Mono.Cecil.MethodImplAttributes ImplAttributes { get { return default(Mono.Cecil.MethodImplAttributes); } set { } }
    public bool IsAbstract { get { return default(bool); } set { } }
    public bool IsAddOn { get { return default(bool); } set { } }
    public bool IsAssembly { get { return default(bool); } set { } }
    public bool IsCheckAccessOnOverride { get { return default(bool); } set { } }
    public bool IsCompilerControlled { get { return default(bool); } set { } }
    public bool IsConstructor { get { return default(bool); } }
    public override bool IsDefinition { get { return default(bool); } }
    public bool IsFamily { get { return default(bool); } set { } }
    public bool IsFamilyAndAssembly { get { return default(bool); } set { } }
    public bool IsFamilyOrAssembly { get { return default(bool); } set { } }
    public bool IsFinal { get { return default(bool); } set { } }
    public bool IsFire { get { return default(bool); } set { } }
    public bool IsForwardRef { get { return default(bool); } set { } }
    public bool IsGetter { get { return default(bool); } set { } }
    public bool IsHideBySig { get { return default(bool); } set { } }
    public bool IsIL { get { return default(bool); } set { } }
    public bool IsInternalCall { get { return default(bool); } set { } }
    public bool IsManaged { get { return default(bool); } set { } }
    public bool IsNative { get { return default(bool); } set { } }
    public bool IsNewSlot { get { return default(bool); } set { } }
    public bool IsOther { get { return default(bool); } set { } }
    public bool IsPInvokeImpl { get { return default(bool); } set { } }
    public bool IsPreserveSig { get { return default(bool); } set { } }
    public bool IsPrivate { get { return default(bool); } set { } }
    public bool IsPublic { get { return default(bool); } set { } }
    public bool IsRemoveOn { get { return default(bool); } set { } }
    public bool IsReuseSlot { get { return default(bool); } set { } }
    public bool IsRuntime { get { return default(bool); } set { } }
    public bool IsRuntimeSpecialName { get { return default(bool); } set { } }
    public bool IsSetter { get { return default(bool); } set { } }
    public bool IsSpecialName { get { return default(bool); } set { } }
    public bool IsStatic { get { return default(bool); } set { } }
    public bool IsSynchronized { get { return default(bool); } set { } }
    public bool IsUnmanaged { get { return default(bool); } set { } }
    public bool IsUnmanagedExport { get { return default(bool); } set { } }
    public bool IsVirtual { get { return default(bool); } set { } }
    public bool NoInlining { get { return default(bool); } set { } }
    public bool NoOptimization { get { return default(bool); } set { } }
    public Mono.Collections.Generic.Collection<Mono.Cecil.MethodReference> Overrides { get { return default(Mono.Collections.Generic.Collection<Mono.Cecil.MethodReference>); } }
    public Mono.Cecil.PInvokeInfo PInvokeInfo { get { return default(Mono.Cecil.PInvokeInfo); } set { } }
    public int RVA { get { return default(int); } }
    public Mono.Collections.Generic.Collection<Mono.Cecil.SecurityDeclaration> SecurityDeclarations { get { return default(Mono.Collections.Generic.Collection<Mono.Cecil.SecurityDeclaration>); } }
    public Mono.Cecil.MethodSemanticsAttributes SemanticsAttributes { get { return default(Mono.Cecil.MethodSemanticsAttributes); } set { } }
    public override Mono.Cecil.MethodDefinition Resolve() { return default(Mono.Cecil.MethodDefinition); }
  }
  [System.FlagsAttribute]
  public enum MethodImplAttributes : ushort {
    CodeTypeMask = (ushort)3,
    ForwardRef = (ushort)16,
    IL = (ushort)0,
    InternalCall = (ushort)4096,
    Managed = (ushort)0,
    ManagedMask = (ushort)4,
    Native = (ushort)1,
    NoInlining = (ushort)8,
    NoOptimization = (ushort)64,
    OPTIL = (ushort)2,
    PreserveSig = (ushort)128,
    Runtime = (ushort)3,
    Synchronized = (ushort)32,
    Unmanaged = (ushort)4,
  }
  public partial class MethodReference : Mono.Cecil.MemberReference, Mono.Cecil.IGenericParameterProvider, Mono.Cecil.IMetadataTokenProvider, Mono.Cecil.IMethodSignature {
    public MethodReference(string name, Mono.Cecil.TypeReference returnType) { }
    public MethodReference(string name, Mono.Cecil.TypeReference returnType, Mono.Cecil.TypeReference declaringType) { }
    public virtual Mono.Cecil.MethodCallingConvention CallingConvention { get { return default(Mono.Cecil.MethodCallingConvention); } set { } }
    public virtual bool ExplicitThis { get { return default(bool); } set { } }
    public override string FullName { get { return default(string); } }
    public virtual Mono.Collections.Generic.Collection<Mono.Cecil.GenericParameter> GenericParameters { get { return default(Mono.Collections.Generic.Collection<Mono.Cecil.GenericParameter>); } }
    public virtual bool HasGenericParameters { get { return default(bool); } }
    public virtual bool HasParameters { get { return default(bool); } }
    public virtual bool HasThis { get { return default(bool); } set { } }
    public virtual bool IsGenericInstance { get { return default(bool); } }
    public virtual Mono.Cecil.MethodReturnType MethodReturnType { get { return default(Mono.Cecil.MethodReturnType); } set { } }
    Mono.Cecil.GenericParameterType Mono.Cecil.IGenericParameterProvider.GenericParameterType { get { return default(Mono.Cecil.GenericParameterType); } }
    public virtual Mono.Collections.Generic.Collection<Mono.Cecil.ParameterDefinition> Parameters { get { return default(Mono.Collections.Generic.Collection<Mono.Cecil.ParameterDefinition>); } }
    public Mono.Cecil.TypeReference ReturnType { get { return default(Mono.Cecil.TypeReference); } set { } }
    public virtual Mono.Cecil.MethodReference GetElementMethod() { return default(Mono.Cecil.MethodReference); }
    public virtual Mono.Cecil.MethodDefinition Resolve() { return default(Mono.Cecil.MethodDefinition); }
  }
  public sealed partial class MethodReturnType : Mono.Cecil.IConstantProvider, Mono.Cecil.ICustomAttributeProvider, Mono.Cecil.IMarshalInfoProvider, Mono.Cecil.IMetadataTokenProvider {
    public MethodReturnType(Mono.Cecil.IMethodSignature method) { }
    public Mono.Cecil.ParameterAttributes Attributes { get { return default(Mono.Cecil.ParameterAttributes); } set { } }
    public object Constant { get { return default(object); } set { } }
    public Mono.Collections.Generic.Collection<Mono.Cecil.CustomAttribute> CustomAttributes { get { return default(Mono.Collections.Generic.Collection<Mono.Cecil.CustomAttribute>); } }
    public bool HasConstant { get { return default(bool); } set { } }
    public bool HasCustomAttributes { get { return default(bool); } }
    public bool HasDefault { get { return default(bool); } set { } }
    public bool HasFieldMarshal { get { return default(bool); } set { } }
    public bool HasMarshalInfo { get { return default(bool); } }
    public Mono.Cecil.MarshalInfo MarshalInfo { get { return default(Mono.Cecil.MarshalInfo); } set { } }
    public Mono.Cecil.MetadataToken MetadataToken { get { return default(Mono.Cecil.MetadataToken); } set { } }
    public Mono.Cecil.IMethodSignature Method { get { return default(Mono.Cecil.IMethodSignature); } }
    public Mono.Cecil.TypeReference ReturnType { get { return default(Mono.Cecil.TypeReference); } set { } }
  }
  [System.FlagsAttribute]
  public enum MethodSemanticsAttributes : ushort {
    AddOn = (ushort)8,
    Fire = (ushort)32,
    Getter = (ushort)2,
    None = (ushort)0,
    Other = (ushort)4,
    RemoveOn = (ushort)16,
    Setter = (ushort)1,
  }
  public abstract partial class MethodSpecification : Mono.Cecil.MethodReference {
    internal MethodSpecification() : base (default(string), default(Mono.Cecil.TypeReference)) { }
    public override Mono.Cecil.MethodCallingConvention CallingConvention { get { return default(Mono.Cecil.MethodCallingConvention); } set { } }
    public override Mono.Cecil.TypeReference DeclaringType { get { return default(Mono.Cecil.TypeReference); } set { } }
    public Mono.Cecil.MethodReference ElementMethod { get { return default(Mono.Cecil.MethodReference); } }
    public override bool ExplicitThis { get { return default(bool); } set { } }
    public override bool HasParameters { get { return default(bool); } }
    public override bool HasThis { get { return default(bool); } set { } }
    public override Mono.Cecil.MethodReturnType MethodReturnType { get { return default(Mono.Cecil.MethodReturnType); } set { } }
    public override Mono.Cecil.ModuleDefinition Module { get { return default(Mono.Cecil.ModuleDefinition); } }
    public override string Name { get { return default(string); } set { } }
    public override Mono.Collections.Generic.Collection<Mono.Cecil.ParameterDefinition> Parameters { get { return default(Mono.Collections.Generic.Collection<Mono.Cecil.ParameterDefinition>); } }
    public sealed override Mono.Cecil.MethodReference GetElementMethod() { return default(Mono.Cecil.MethodReference); }
  }
  [System.FlagsAttribute]
  public enum ModuleAttributes {
    ILOnly = 1,
    Preferred32Bit = 131072,
    Required32Bit = 2,
    StrongNameSigned = 8,
  }
  [System.FlagsAttribute]
  public enum ModuleCharacteristics {
    AppContainer = 4096,
    DynamicBase = 64,
    HighEntropyVA = 32,
    NoSEH = 1024,
    NXCompat = 256,
    TerminalServerAware = 32768,
  }
  public sealed partial class ModuleDefinition : Mono.Cecil.ModuleReference, Mono.Cecil.ICustomAttributeProvider, Mono.Cecil.IMetadataTokenProvider {
    internal ModuleDefinition() : base (default(string)) { }
    public Mono.Cecil.TargetArchitecture Architecture { get { return default(Mono.Cecil.TargetArchitecture); } set { } }
    public Mono.Cecil.AssemblyDefinition Assembly { get { return default(Mono.Cecil.AssemblyDefinition); } }
    public Mono.Collections.Generic.Collection<Mono.Cecil.AssemblyNameReference> AssemblyReferences { get { return default(Mono.Collections.Generic.Collection<Mono.Cecil.AssemblyNameReference>); } }
    public Mono.Cecil.IAssemblyResolver AssemblyResolver { get { return default(Mono.Cecil.IAssemblyResolver); } }
    public Mono.Cecil.ModuleAttributes Attributes { get { return default(Mono.Cecil.ModuleAttributes); } set { } }
    public Mono.Cecil.ModuleCharacteristics Characteristics { get { return default(Mono.Cecil.ModuleCharacteristics); } set { } }
    public Mono.Collections.Generic.Collection<Mono.Cecil.CustomAttribute> CustomAttributes { get { return default(Mono.Collections.Generic.Collection<Mono.Cecil.CustomAttribute>); } }
    public Mono.Cecil.MethodDefinition EntryPoint { get { return default(Mono.Cecil.MethodDefinition); } set { } }
    public Mono.Collections.Generic.Collection<Mono.Cecil.ExportedType> ExportedTypes { get { return default(Mono.Collections.Generic.Collection<Mono.Cecil.ExportedType>); } }
    public string FullyQualifiedName { get { return default(string); } }
    public bool HasAssemblyReferences { get { return default(bool); } }
    public bool HasCustomAttributes { get { return default(bool); } }
    public bool HasDebugHeader { get { return default(bool); } }
    public bool HasExportedTypes { get { return default(bool); } }
    public bool HasModuleReferences { get { return default(bool); } }
    public bool HasResources { get { return default(bool); } }
    public bool HasSymbols { get { return default(bool); } }
    public bool HasTypes { get { return default(bool); } }
    public bool IsMain { get { return default(bool); } }
    public Mono.Cecil.ModuleKind Kind { get { return default(Mono.Cecil.ModuleKind); } set { } }
    public Mono.Cecil.IMetadataResolver MetadataResolver { get { return default(Mono.Cecil.IMetadataResolver); } }
    public override Mono.Cecil.MetadataScopeType MetadataScopeType { get { return default(Mono.Cecil.MetadataScopeType); } }
    public Mono.Collections.Generic.Collection<Mono.Cecil.ModuleReference> ModuleReferences { get { return default(Mono.Collections.Generic.Collection<Mono.Cecil.ModuleReference>); } }
    public System.Guid Mvid { get { return default(System.Guid); } set { } }
    public Mono.Collections.Generic.Collection<Mono.Cecil.Resource> Resources { get { return default(Mono.Collections.Generic.Collection<Mono.Cecil.Resource>); } }
    public Mono.Cecil.TargetRuntime Runtime { get { return default(Mono.Cecil.TargetRuntime); } set { } }
    public Mono.Cecil.Cil.ISymbolReader SymbolReader { get { return default(Mono.Cecil.Cil.ISymbolReader); } }
    public Mono.Collections.Generic.Collection<Mono.Cecil.TypeDefinition> Types { get { return default(Mono.Collections.Generic.Collection<Mono.Cecil.TypeDefinition>); } }
    public Mono.Cecil.TypeSystem TypeSystem { get { return default(Mono.Cecil.TypeSystem); } }
    public static Mono.Cecil.ModuleDefinition CreateModule(string name, Mono.Cecil.ModuleKind kind) { return default(Mono.Cecil.ModuleDefinition); }
    public static Mono.Cecil.ModuleDefinition CreateModule(string name, Mono.Cecil.ModuleParameters parameters) { return default(Mono.Cecil.ModuleDefinition); }
    public Mono.Cecil.Cil.ImageDebugDirectory GetDebugHeader(out System.Byte[] header) { header = default(System.Byte[]); return default(Mono.Cecil.Cil.ImageDebugDirectory); }
    public System.Collections.Generic.IEnumerable<Mono.Cecil.MemberReference> GetMemberReferences() { return default(System.Collections.Generic.IEnumerable<Mono.Cecil.MemberReference>); }
    public Mono.Cecil.TypeDefinition GetType(string fullName) { return default(Mono.Cecil.TypeDefinition); }
    public Mono.Cecil.TypeReference GetType(string fullName, bool runtimeName) { return default(Mono.Cecil.TypeReference); }
    public Mono.Cecil.TypeDefinition GetType(string @namespace, string name) { return default(Mono.Cecil.TypeDefinition); }
    public System.Collections.Generic.IEnumerable<Mono.Cecil.TypeReference> GetTypeReferences() { return default(System.Collections.Generic.IEnumerable<Mono.Cecil.TypeReference>); }
    public System.Collections.Generic.IEnumerable<Mono.Cecil.TypeDefinition> GetTypes() { return default(System.Collections.Generic.IEnumerable<Mono.Cecil.TypeDefinition>); }
    public bool HasTypeReference(string fullName) { return default(bool); }
    public bool HasTypeReference(string scope, string fullName) { return default(bool); }
    public Mono.Cecil.FieldReference Import(Mono.Cecil.FieldReference field) { return default(Mono.Cecil.FieldReference); }
    public Mono.Cecil.FieldReference Import(Mono.Cecil.FieldReference field, Mono.Cecil.IGenericParameterProvider context) { return default(Mono.Cecil.FieldReference); }
    public Mono.Cecil.MethodReference Import(Mono.Cecil.MethodReference method) { return default(Mono.Cecil.MethodReference); }
    public Mono.Cecil.MethodReference Import(Mono.Cecil.MethodReference method, Mono.Cecil.IGenericParameterProvider context) { return default(Mono.Cecil.MethodReference); }
    public Mono.Cecil.TypeReference Import(Mono.Cecil.TypeReference type) { return default(Mono.Cecil.TypeReference); }
    public Mono.Cecil.TypeReference Import(Mono.Cecil.TypeReference type, Mono.Cecil.IGenericParameterProvider context) { return default(Mono.Cecil.TypeReference); }
    public Mono.Cecil.FieldReference Import(System.Reflection.FieldInfo field) { return default(Mono.Cecil.FieldReference); }
    public Mono.Cecil.FieldReference Import(System.Reflection.FieldInfo field, Mono.Cecil.IGenericParameterProvider context) { return default(Mono.Cecil.FieldReference); }
    public Mono.Cecil.MethodReference Import(System.Reflection.MethodBase method) { return default(Mono.Cecil.MethodReference); }
    public Mono.Cecil.MethodReference Import(System.Reflection.MethodBase method, Mono.Cecil.IGenericParameterProvider context) { return default(Mono.Cecil.MethodReference); }
    public Mono.Cecil.TypeReference Import(System.Type type) { return default(Mono.Cecil.TypeReference); }
    public Mono.Cecil.TypeReference Import(System.Type type, Mono.Cecil.IGenericParameterProvider context) { return default(Mono.Cecil.TypeReference); }
    public Mono.Cecil.IMetadataTokenProvider LookupToken(Mono.Cecil.MetadataToken token) { return default(Mono.Cecil.IMetadataTokenProvider); }
    public Mono.Cecil.IMetadataTokenProvider LookupToken(int token) { return default(Mono.Cecil.IMetadataTokenProvider); }
    public static Mono.Cecil.ModuleDefinition ReadModule(System.IO.Stream stream) { return default(Mono.Cecil.ModuleDefinition); }
    public static Mono.Cecil.ModuleDefinition ReadModule(System.IO.Stream stream, Mono.Cecil.ReaderParameters parameters) { return default(Mono.Cecil.ModuleDefinition); }
    public static Mono.Cecil.ModuleDefinition ReadModule(string fileName) { return default(Mono.Cecil.ModuleDefinition); }
    public static Mono.Cecil.ModuleDefinition ReadModule(string fileName, Mono.Cecil.ReaderParameters parameters) { return default(Mono.Cecil.ModuleDefinition); }
    public void ReadSymbols() { }
    public void ReadSymbols(Mono.Cecil.Cil.ISymbolReader reader) { }
    public bool TryGetTypeReference(string fullName, out Mono.Cecil.TypeReference type) { type = default(Mono.Cecil.TypeReference); return default(bool); }
    public bool TryGetTypeReference(string scope, string fullName, out Mono.Cecil.TypeReference type) { type = default(Mono.Cecil.TypeReference); return default(bool); }
    public void Write(System.IO.Stream stream) { }
    public void Write(System.IO.Stream stream, Mono.Cecil.WriterParameters parameters) { }
    public void Write(string fileName) { }
    public void Write(string fileName, Mono.Cecil.WriterParameters parameters) { }
  }
  public enum ModuleKind {
    Console = 1,
    Dll = 0,
    NetModule = 3,
    Windows = 2,
  }
  public sealed partial class ModuleParameters {
    public ModuleParameters() { }
    public Mono.Cecil.TargetArchitecture Architecture { get { return default(Mono.Cecil.TargetArchitecture); } set { } }
    public Mono.Cecil.IAssemblyResolver AssemblyResolver { get { return default(Mono.Cecil.IAssemblyResolver); } set { } }
    public Mono.Cecil.ModuleKind Kind { get { return default(Mono.Cecil.ModuleKind); } set { } }
    public Mono.Cecil.IMetadataResolver MetadataResolver { get { return default(Mono.Cecil.IMetadataResolver); } set { } }
    public Mono.Cecil.TargetRuntime Runtime { get { return default(Mono.Cecil.TargetRuntime); } set { } }
  }
  public partial class ModuleReference : Mono.Cecil.IMetadataScope, Mono.Cecil.IMetadataTokenProvider {
    public ModuleReference(string name) { }
    public virtual Mono.Cecil.MetadataScopeType MetadataScopeType { get { return default(Mono.Cecil.MetadataScopeType); } }
    public Mono.Cecil.MetadataToken MetadataToken { get { return default(Mono.Cecil.MetadataToken); } set { } }
    public string Name { get { return default(string); } set { } }
    public override string ToString() { return default(string); }
  }
  public enum NativeType {
    ANSIBStr = 35,
    Array = 42,
    ASAny = 40,
    Boolean = 2,
    BStr = 19,
    ByValStr = 34,
    Currency = 15,
    CustomMarshaler = 44,
    Error = 45,
    FixedArray = 30,
    FixedSysString = 23,
    Func = 38,
    I1 = 3,
    I2 = 5,
    I4 = 7,
    I8 = 9,
    IDispatch = 26,
    Int = 31,
    IntF = 28,
    IUnknown = 25,
    LPStr = 20,
    LPStruct = 43,
    LPTStr = 22,
    LPWStr = 21,
    Max = 80,
    None = 102,
    R4 = 11,
    R8 = 12,
    SafeArray = 29,
    Struct = 27,
    TBStr = 36,
    U1 = 4,
    U2 = 6,
    U4 = 8,
    U8 = 10,
    UInt = 32,
    VariantBool = 37,
  }
  public sealed partial class OptionalModifierType : Mono.Cecil.TypeSpecification, Mono.Cecil.IModifierType {
    public OptionalModifierType(Mono.Cecil.TypeReference modifierType, Mono.Cecil.TypeReference type) { }
    public override string FullName { get { return default(string); } }
    public override bool IsOptionalModifier { get { return default(bool); } }
    public override bool IsValueType { get { return default(bool); } set { } }
    public Mono.Cecil.TypeReference ModifierType { get { return default(Mono.Cecil.TypeReference); } set { } }
    public override string Name { get { return default(string); } }
  }
  [System.FlagsAttribute]
  public enum ParameterAttributes : ushort {
    HasDefault = (ushort)4096,
    HasFieldMarshal = (ushort)8192,
    In = (ushort)1,
    Lcid = (ushort)4,
    None = (ushort)0,
    Optional = (ushort)16,
    Out = (ushort)2,
    Retval = (ushort)8,
    Unused = (ushort)53216,
  }
  public sealed partial class ParameterDefinition : Mono.Cecil.ParameterReference, Mono.Cecil.IConstantProvider, Mono.Cecil.ICustomAttributeProvider, Mono.Cecil.IMarshalInfoProvider, Mono.Cecil.IMetadataTokenProvider {
    public ParameterDefinition(Mono.Cecil.TypeReference parameterType) { }
    public ParameterDefinition(string name, Mono.Cecil.ParameterAttributes attributes, Mono.Cecil.TypeReference parameterType) { }
    public Mono.Cecil.ParameterAttributes Attributes { get { return default(Mono.Cecil.ParameterAttributes); } set { } }
    public object Constant { get { return default(object); } set { } }
    public Mono.Collections.Generic.Collection<Mono.Cecil.CustomAttribute> CustomAttributes { get { return default(Mono.Collections.Generic.Collection<Mono.Cecil.CustomAttribute>); } }
    public bool HasConstant { get { return default(bool); } set { } }
    public bool HasCustomAttributes { get { return default(bool); } }
    public bool HasDefault { get { return default(bool); } set { } }
    public bool HasFieldMarshal { get { return default(bool); } set { } }
    public bool HasMarshalInfo { get { return default(bool); } }
    public bool IsIn { get { return default(bool); } set { } }
    public bool IsLcid { get { return default(bool); } set { } }
    public bool IsOptional { get { return default(bool); } set { } }
    public bool IsOut { get { return default(bool); } set { } }
    public bool IsReturnValue { get { return default(bool); } set { } }
    public Mono.Cecil.MarshalInfo MarshalInfo { get { return default(Mono.Cecil.MarshalInfo); } set { } }
    public Mono.Cecil.IMethodSignature Method { get { return default(Mono.Cecil.IMethodSignature); } }
    public int Sequence { get { return default(int); } }
    public override Mono.Cecil.ParameterDefinition Resolve() { return default(Mono.Cecil.ParameterDefinition); }
  }
  public abstract partial class ParameterReference : Mono.Cecil.IMetadataTokenProvider {
    internal ParameterReference() { }
    protected Mono.Cecil.TypeReference parameter_type;
    public int Index { get { return default(int); } }
    public Mono.Cecil.MetadataToken MetadataToken { get { return default(Mono.Cecil.MetadataToken); } set { } }
    public string Name { get { return default(string); } set { } }
    public Mono.Cecil.TypeReference ParameterType { get { return default(Mono.Cecil.TypeReference); } set { } }
    public abstract Mono.Cecil.ParameterDefinition Resolve();
    public override string ToString() { return default(string); }
  }
  public sealed partial class PinnedType : Mono.Cecil.TypeSpecification {
    public PinnedType(Mono.Cecil.TypeReference type) { }
    public override bool IsPinned { get { return default(bool); } }
    public override bool IsValueType { get { return default(bool); } set { } }
  }
  [System.FlagsAttribute]
  public enum PInvokeAttributes : ushort {
    BestFitDisabled = (ushort)32,
    BestFitEnabled = (ushort)16,
    BestFitMask = (ushort)48,
    CallConvCdecl = (ushort)512,
    CallConvFastcall = (ushort)1280,
    CallConvMask = (ushort)1792,
    CallConvStdCall = (ushort)768,
    CallConvThiscall = (ushort)1024,
    CallConvWinapi = (ushort)256,
    CharSetAnsi = (ushort)2,
    CharSetAuto = (ushort)6,
    CharSetMask = (ushort)6,
    CharSetNotSpec = (ushort)0,
    CharSetUnicode = (ushort)4,
    NoMangle = (ushort)1,
    SupportsLastError = (ushort)64,
    ThrowOnUnmappableCharDisabled = (ushort)8192,
    ThrowOnUnmappableCharEnabled = (ushort)4096,
    ThrowOnUnmappableCharMask = (ushort)12288,
  }
  public sealed partial class PInvokeInfo {
    public PInvokeInfo(Mono.Cecil.PInvokeAttributes attributes, string entryPoint, Mono.Cecil.ModuleReference module) { }
    public Mono.Cecil.PInvokeAttributes Attributes { get { return default(Mono.Cecil.PInvokeAttributes); } set { } }
    public string EntryPoint { get { return default(string); } set { } }
    public bool IsBestFitDisabled { get { return default(bool); } set { } }
    public bool IsBestFitEnabled { get { return default(bool); } set { } }
    public bool IsCallConvCdecl { get { return default(bool); } set { } }
    public bool IsCallConvFastcall { get { return default(bool); } set { } }
    public bool IsCallConvStdCall { get { return default(bool); } set { } }
    public bool IsCallConvThiscall { get { return default(bool); } set { } }
    public bool IsCallConvWinapi { get { return default(bool); } set { } }
    public bool IsCharSetAnsi { get { return default(bool); } set { } }
    public bool IsCharSetAuto { get { return default(bool); } set { } }
    public bool IsCharSetNotSpec { get { return default(bool); } set { } }
    public bool IsCharSetUnicode { get { return default(bool); } set { } }
    public bool IsNoMangle { get { return default(bool); } set { } }
    public bool IsThrowOnUnmappableCharDisabled { get { return default(bool); } set { } }
    public bool IsThrowOnUnmappableCharEnabled { get { return default(bool); } set { } }
    public Mono.Cecil.ModuleReference Module { get { return default(Mono.Cecil.ModuleReference); } set { } }
    public bool SupportsLastError { get { return default(bool); } set { } }
  }
  public sealed partial class PointerType : Mono.Cecil.TypeSpecification {
    public PointerType(Mono.Cecil.TypeReference type) { }
    public override string FullName { get { return default(string); } }
    public override bool IsPointer { get { return default(bool); } }
    public override bool IsValueType { get { return default(bool); } set { } }
    public override string Name { get { return default(string); } }
  }
  [System.FlagsAttribute]
  public enum PropertyAttributes : ushort {
    HasDefault = (ushort)4096,
    None = (ushort)0,
    RTSpecialName = (ushort)1024,
    SpecialName = (ushort)512,
    Unused = (ushort)59903,
  }
  public sealed partial class PropertyDefinition : Mono.Cecil.PropertyReference, Mono.Cecil.IConstantProvider, Mono.Cecil.ICustomAttributeProvider, Mono.Cecil.IMemberDefinition, Mono.Cecil.IMetadataTokenProvider {
    public PropertyDefinition(string name, Mono.Cecil.PropertyAttributes attributes, Mono.Cecil.TypeReference propertyType) { }
    public Mono.Cecil.PropertyAttributes Attributes { get { return default(Mono.Cecil.PropertyAttributes); } set { } }
    public object Constant { get { return default(object); } set { } }
    public Mono.Collections.Generic.Collection<Mono.Cecil.CustomAttribute> CustomAttributes { get { return default(Mono.Collections.Generic.Collection<Mono.Cecil.CustomAttribute>); } }
    public new Mono.Cecil.TypeDefinition DeclaringType { get { return default(Mono.Cecil.TypeDefinition); } set { } }
    public override string FullName { get { return default(string); } }
    public Mono.Cecil.MethodDefinition GetMethod { get { return default(Mono.Cecil.MethodDefinition); } set { } }
    public bool HasConstant { get { return default(bool); } set { } }
    public bool HasCustomAttributes { get { return default(bool); } }
    public bool HasDefault { get { return default(bool); } set { } }
    public bool HasOtherMethods { get { return default(bool); } }
    public bool HasParameters { get { return default(bool); } }
    public bool HasThis { get { return default(bool); } set { } }
    public override bool IsDefinition { get { return default(bool); } }
    public bool IsRuntimeSpecialName { get { return default(bool); } set { } }
    public bool IsSpecialName { get { return default(bool); } set { } }
    public Mono.Collections.Generic.Collection<Mono.Cecil.MethodDefinition> OtherMethods { get { return default(Mono.Collections.Generic.Collection<Mono.Cecil.MethodDefinition>); } }
    public override Mono.Collections.Generic.Collection<Mono.Cecil.ParameterDefinition> Parameters { get { return default(Mono.Collections.Generic.Collection<Mono.Cecil.ParameterDefinition>); } }
    public Mono.Cecil.MethodDefinition SetMethod { get { return default(Mono.Cecil.MethodDefinition); } set { } }
    public override Mono.Cecil.PropertyDefinition Resolve() { return default(Mono.Cecil.PropertyDefinition); }
  }
  public abstract partial class PropertyReference : Mono.Cecil.MemberReference {
    internal PropertyReference() { }
    public abstract Mono.Collections.Generic.Collection<Mono.Cecil.ParameterDefinition> Parameters { get; }
    public Mono.Cecil.TypeReference PropertyType { get { return default(Mono.Cecil.TypeReference); } set { } }
    public abstract Mono.Cecil.PropertyDefinition Resolve();
  }
  public sealed partial class ReaderParameters {
    public ReaderParameters() { }
    public ReaderParameters(Mono.Cecil.ReadingMode readingMode) { }
    public Mono.Cecil.IAssemblyResolver AssemblyResolver { get { return default(Mono.Cecil.IAssemblyResolver); } set { } }
    public Mono.Cecil.IMetadataResolver MetadataResolver { get { return default(Mono.Cecil.IMetadataResolver); } set { } }
    public Mono.Cecil.ReadingMode ReadingMode { get { return default(Mono.Cecil.ReadingMode); } set { } }
    public bool ReadSymbols { get { return default(bool); } set { } }
    public Mono.Cecil.Cil.ISymbolReaderProvider SymbolReaderProvider { get { return default(Mono.Cecil.Cil.ISymbolReaderProvider); } set { } }
    public System.IO.Stream SymbolStream { get { return default(System.IO.Stream); } set { } }
  }
  public enum ReadingMode {
    Deferred = 2,
    Immediate = 1,
  }
  public sealed partial class RequiredModifierType : Mono.Cecil.TypeSpecification, Mono.Cecil.IModifierType {
    public RequiredModifierType(Mono.Cecil.TypeReference modifierType, Mono.Cecil.TypeReference type) { }
    public override string FullName { get { return default(string); } }
    public override bool IsRequiredModifier { get { return default(bool); } }
    public override bool IsValueType { get { return default(bool); } set { } }
    public Mono.Cecil.TypeReference ModifierType { get { return default(Mono.Cecil.TypeReference); } set { } }
    public override string Name { get { return default(string); } }
  }
  public partial class ResolutionException : System.Exception {
    public ResolutionException(Mono.Cecil.MemberReference member) { }
    protected ResolutionException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public Mono.Cecil.MemberReference Member { get { return default(Mono.Cecil.MemberReference); } }
    public Mono.Cecil.IMetadataScope Scope { get { return default(Mono.Cecil.IMetadataScope); } }
  }
  public abstract partial class Resource {
    internal Resource() { }
    public Mono.Cecil.ManifestResourceAttributes Attributes { get { return default(Mono.Cecil.ManifestResourceAttributes); } set { } }
    public bool IsPrivate { get { return default(bool); } set { } }
    public bool IsPublic { get { return default(bool); } set { } }
    public string Name { get { return default(string); } set { } }
    public abstract Mono.Cecil.ResourceType ResourceType { get; }
  }
  public enum ResourceType {
    AssemblyLinked = 2,
    Embedded = 1,
    Linked = 0,
  }
  public sealed partial class SafeArrayMarshalInfo : Mono.Cecil.MarshalInfo {
    public SafeArrayMarshalInfo() : base (default(Mono.Cecil.NativeType)) { }
    public Mono.Cecil.VariantType ElementType { get { return default(Mono.Cecil.VariantType); } set { } }
  }
  public enum SecurityAction : ushort {
    Assert = (ushort)3,
    Demand = (ushort)2,
    Deny = (ushort)4,
    InheritDemand = (ushort)7,
    LinkDemand = (ushort)6,
    NonCasDemand = (ushort)13,
    NonCasInheritance = (ushort)15,
    NonCasLinkDemand = (ushort)14,
    PermitOnly = (ushort)5,
    PreJitDeny = (ushort)12,
    PreJitGrant = (ushort)11,
    Request = (ushort)1,
    RequestMinimum = (ushort)8,
    RequestOptional = (ushort)9,
    RequestRefuse = (ushort)10,
  }
  public sealed partial class SecurityAttribute : Mono.Cecil.ICustomAttribute {
    public SecurityAttribute(Mono.Cecil.TypeReference attributeType) { }
    public Mono.Cecil.TypeReference AttributeType { get { return default(Mono.Cecil.TypeReference); } set { } }
    public Mono.Collections.Generic.Collection<Mono.Cecil.CustomAttributeNamedArgument> Fields { get { return default(Mono.Collections.Generic.Collection<Mono.Cecil.CustomAttributeNamedArgument>); } }
    public bool HasFields { get { return default(bool); } }
    public bool HasProperties { get { return default(bool); } }
    public Mono.Collections.Generic.Collection<Mono.Cecil.CustomAttributeNamedArgument> Properties { get { return default(Mono.Collections.Generic.Collection<Mono.Cecil.CustomAttributeNamedArgument>); } }
  }
  public sealed partial class SecurityDeclaration {
    public SecurityDeclaration(Mono.Cecil.SecurityAction action) { }
    public SecurityDeclaration(Mono.Cecil.SecurityAction action, System.Byte[] blob) { }
    public Mono.Cecil.SecurityAction Action { get { return default(Mono.Cecil.SecurityAction); } set { } }
    public bool HasSecurityAttributes { get { return default(bool); } }
    public Mono.Collections.Generic.Collection<Mono.Cecil.SecurityAttribute> SecurityAttributes { get { return default(Mono.Collections.Generic.Collection<Mono.Cecil.SecurityAttribute>); } }
    public System.Byte[] GetBlob() { return default(System.Byte[]); }
  }
  public sealed partial class SentinelType : Mono.Cecil.TypeSpecification {
    public SentinelType(Mono.Cecil.TypeReference type) { }
    public override bool IsSentinel { get { return default(bool); } }
    public override bool IsValueType { get { return default(bool); } set { } }
  }
  public enum TargetArchitecture {
    AMD64 = 1,
    ARMv7 = 3,
    I386 = 0,
    IA64 = 2,
  }
  public enum TargetRuntime {
    Net_1_0 = 0,
    Net_1_1 = 1,
    Net_2_0 = 2,
    Net_4_0 = 3,
  }
  public enum TokenType : uint {
    Assembly = (uint)536870912,
    AssemblyRef = (uint)587202560,
    CustomAttribute = (uint)201326592,
    Event = (uint)335544320,
    ExportedType = (uint)654311424,
    Field = (uint)67108864,
    File = (uint)637534208,
    GenericParam = (uint)704643072,
    InterfaceImpl = (uint)150994944,
    ManifestResource = (uint)671088640,
    MemberRef = (uint)167772160,
    Method = (uint)100663296,
    MethodSpec = (uint)721420288,
    Module = (uint)0,
    ModuleRef = (uint)436207616,
    Param = (uint)134217728,
    Permission = (uint)234881024,
    Property = (uint)385875968,
    Signature = (uint)285212672,
    String = (uint)1879048192,
    TypeDef = (uint)33554432,
    TypeRef = (uint)16777216,
    TypeSpec = (uint)452984832,
  }
  [System.FlagsAttribute]
  public enum TypeAttributes : uint {
    Abstract = (uint)128,
    AnsiClass = (uint)0,
    AutoClass = (uint)131072,
    AutoLayout = (uint)0,
    BeforeFieldInit = (uint)1048576,
    Class = (uint)0,
    ClassSemanticMask = (uint)32,
    ExplicitLayout = (uint)16,
    Forwarder = (uint)2097152,
    HasSecurity = (uint)262144,
    Import = (uint)4096,
    Interface = (uint)32,
    LayoutMask = (uint)24,
    NestedAssembly = (uint)5,
    NestedFamANDAssem = (uint)6,
    NestedFamily = (uint)4,
    NestedFamORAssem = (uint)7,
    NestedPrivate = (uint)3,
    NestedPublic = (uint)2,
    NotPublic = (uint)0,
    Public = (uint)1,
    RTSpecialName = (uint)2048,
    Sealed = (uint)256,
    SequentialLayout = (uint)8,
    Serializable = (uint)8192,
    SpecialName = (uint)1024,
    StringFormatMask = (uint)196608,
    UnicodeClass = (uint)65536,
    VisibilityMask = (uint)7,
    WindowsRuntime = (uint)16384,
  }
  public sealed partial class TypeDefinition : Mono.Cecil.TypeReference, Mono.Cecil.ICustomAttributeProvider, Mono.Cecil.IMemberDefinition, Mono.Cecil.IMetadataTokenProvider, Mono.Cecil.ISecurityDeclarationProvider {
    public TypeDefinition(string @namespace, string name, Mono.Cecil.TypeAttributes attributes) : base (default(string), default(string)) { }
    public TypeDefinition(string @namespace, string name, Mono.Cecil.TypeAttributes attributes, Mono.Cecil.TypeReference baseType) : base (default(string), default(string)) { }
    public Mono.Cecil.TypeAttributes Attributes { get { return default(Mono.Cecil.TypeAttributes); } set { } }
    public Mono.Cecil.TypeReference BaseType { get { return default(Mono.Cecil.TypeReference); } set { } }
    public int ClassSize { get { return default(int); } set { } }
    public Mono.Collections.Generic.Collection<Mono.Cecil.CustomAttribute> CustomAttributes { get { return default(Mono.Collections.Generic.Collection<Mono.Cecil.CustomAttribute>); } }
    public new Mono.Cecil.TypeDefinition DeclaringType { get { return default(Mono.Cecil.TypeDefinition); } set { } }
    public Mono.Collections.Generic.Collection<Mono.Cecil.EventDefinition> Events { get { return default(Mono.Collections.Generic.Collection<Mono.Cecil.EventDefinition>); } }
    public Mono.Collections.Generic.Collection<Mono.Cecil.FieldDefinition> Fields { get { return default(Mono.Collections.Generic.Collection<Mono.Cecil.FieldDefinition>); } }
    public override Mono.Collections.Generic.Collection<Mono.Cecil.GenericParameter> GenericParameters { get { return default(Mono.Collections.Generic.Collection<Mono.Cecil.GenericParameter>); } }
    public bool HasCustomAttributes { get { return default(bool); } }
    public bool HasEvents { get { return default(bool); } }
    public bool HasFields { get { return default(bool); } }
    public override bool HasGenericParameters { get { return default(bool); } }
    public bool HasInterfaces { get { return default(bool); } }
    public bool HasLayoutInfo { get { return default(bool); } }
    public bool HasMethods { get { return default(bool); } }
    public bool HasNestedTypes { get { return default(bool); } }
    public bool HasProperties { get { return default(bool); } }
    public bool HasSecurity { get { return default(bool); } set { } }
    public bool HasSecurityDeclarations { get { return default(bool); } }
    public Mono.Collections.Generic.Collection<Mono.Cecil.TypeReference> Interfaces { get { return default(Mono.Collections.Generic.Collection<Mono.Cecil.TypeReference>); } }
    public bool IsAbstract { get { return default(bool); } set { } }
    public bool IsAnsiClass { get { return default(bool); } set { } }
    public bool IsAutoClass { get { return default(bool); } set { } }
    public bool IsAutoLayout { get { return default(bool); } set { } }
    public bool IsBeforeFieldInit { get { return default(bool); } set { } }
    public bool IsClass { get { return default(bool); } set { } }
    public override bool IsDefinition { get { return default(bool); } }
    public bool IsEnum { get { return default(bool); } }
    public bool IsExplicitLayout { get { return default(bool); } set { } }
    public bool IsImport { get { return default(bool); } set { } }
    public bool IsInterface { get { return default(bool); } set { } }
    public bool IsNestedAssembly { get { return default(bool); } set { } }
    public bool IsNestedFamily { get { return default(bool); } set { } }
    public bool IsNestedFamilyAndAssembly { get { return default(bool); } set { } }
    public bool IsNestedFamilyOrAssembly { get { return default(bool); } set { } }
    public bool IsNestedPrivate { get { return default(bool); } set { } }
    public bool IsNestedPublic { get { return default(bool); } set { } }
    public bool IsNotPublic { get { return default(bool); } set { } }
    public override bool IsPrimitive { get { return default(bool); } }
    public bool IsPublic { get { return default(bool); } set { } }
    public bool IsRuntimeSpecialName { get { return default(bool); } set { } }
    public bool IsSealed { get { return default(bool); } set { } }
    public bool IsSequentialLayout { get { return default(bool); } set { } }
    public bool IsSerializable { get { return default(bool); } set { } }
    public bool IsSpecialName { get { return default(bool); } set { } }
    public bool IsUnicodeClass { get { return default(bool); } set { } }
    public override bool IsValueType { get { return default(bool); } }
    public bool IsWindowsRuntime { get { return default(bool); } set { } }
    public override Mono.Cecil.MetadataType MetadataType { get { return default(Mono.Cecil.MetadataType); } }
    public Mono.Collections.Generic.Collection<Mono.Cecil.MethodDefinition> Methods { get { return default(Mono.Collections.Generic.Collection<Mono.Cecil.MethodDefinition>); } }
    public Mono.Collections.Generic.Collection<Mono.Cecil.TypeDefinition> NestedTypes { get { return default(Mono.Collections.Generic.Collection<Mono.Cecil.TypeDefinition>); } }
    public short PackingSize { get { return default(short); } set { } }
    public Mono.Collections.Generic.Collection<Mono.Cecil.PropertyDefinition> Properties { get { return default(Mono.Collections.Generic.Collection<Mono.Cecil.PropertyDefinition>); } }
    public Mono.Collections.Generic.Collection<Mono.Cecil.SecurityDeclaration> SecurityDeclarations { get { return default(Mono.Collections.Generic.Collection<Mono.Cecil.SecurityDeclaration>); } }
    public override Mono.Cecil.TypeDefinition Resolve() { return default(Mono.Cecil.TypeDefinition); }
  }
  public partial class TypeReference : Mono.Cecil.MemberReference, Mono.Cecil.IGenericParameterProvider, Mono.Cecil.IMetadataTokenProvider {
    protected Mono.Collections.Generic.Collection<Mono.Cecil.GenericParameter> generic_parameters;
    protected TypeReference(string @namespace, string name) { }
    public TypeReference(string @namespace, string name, Mono.Cecil.ModuleDefinition module, Mono.Cecil.IMetadataScope scope) { }
    public TypeReference(string @namespace, string name, Mono.Cecil.ModuleDefinition module, Mono.Cecil.IMetadataScope scope, bool valueType) { }
    public override Mono.Cecil.TypeReference DeclaringType { get { return default(Mono.Cecil.TypeReference); } set { } }
    public override string FullName { get { return default(string); } }
    public virtual Mono.Collections.Generic.Collection<Mono.Cecil.GenericParameter> GenericParameters { get { return default(Mono.Collections.Generic.Collection<Mono.Cecil.GenericParameter>); } }
    public virtual bool HasGenericParameters { get { return default(bool); } }
    public virtual bool IsArray { get { return default(bool); } }
    public virtual bool IsByReference { get { return default(bool); } }
    public virtual bool IsFunctionPointer { get { return default(bool); } }
    public virtual bool IsGenericInstance { get { return default(bool); } }
    public virtual bool IsGenericParameter { get { return default(bool); } }
    public bool IsNested { get { return default(bool); } }
    public virtual bool IsOptionalModifier { get { return default(bool); } }
    public virtual bool IsPinned { get { return default(bool); } }
    public virtual bool IsPointer { get { return default(bool); } }
    public virtual bool IsPrimitive { get { return default(bool); } }
    public virtual bool IsRequiredModifier { get { return default(bool); } }
    public virtual bool IsSentinel { get { return default(bool); } }
    public virtual bool IsValueType { get { return default(bool); } set { } }
    public virtual Mono.Cecil.MetadataType MetadataType { get { return default(Mono.Cecil.MetadataType); } }
    public override Mono.Cecil.ModuleDefinition Module { get { return default(Mono.Cecil.ModuleDefinition); } }
    Mono.Cecil.GenericParameterType Mono.Cecil.IGenericParameterProvider.GenericParameterType { get { return default(Mono.Cecil.GenericParameterType); } }
    public override string Name { get { return default(string); } set { } }
    public virtual string Namespace { get { return default(string); } set { } }
    public virtual Mono.Cecil.IMetadataScope Scope { get { return default(Mono.Cecil.IMetadataScope); } set { } }
    public virtual Mono.Cecil.TypeReference GetElementType() { return default(Mono.Cecil.TypeReference); }
    public virtual Mono.Cecil.TypeDefinition Resolve() { return default(Mono.Cecil.TypeDefinition); }
  }
  public abstract partial class TypeSpecification : Mono.Cecil.TypeReference {
    internal TypeSpecification() : base (default(string), default(string)) { }
    public Mono.Cecil.TypeReference ElementType { get { return default(Mono.Cecil.TypeReference); } }
    public override string FullName { get { return default(string); } }
    public override Mono.Cecil.MetadataType MetadataType { get { return default(Mono.Cecil.MetadataType); } }
    public override Mono.Cecil.ModuleDefinition Module { get { return default(Mono.Cecil.ModuleDefinition); } }
    public override string Name { get { return default(string); } set { } }
    public override string Namespace { get { return default(string); } set { } }
    public override Mono.Cecil.IMetadataScope Scope { get { return default(Mono.Cecil.IMetadataScope); } set { } }
    public override Mono.Cecil.TypeReference GetElementType() { return default(Mono.Cecil.TypeReference); }
  }
  public abstract partial class TypeSystem {
    internal TypeSystem() { }
    public Mono.Cecil.TypeReference Boolean { get { return default(Mono.Cecil.TypeReference); } }
    public Mono.Cecil.TypeReference Byte { get { return default(Mono.Cecil.TypeReference); } }
    public Mono.Cecil.TypeReference Char { get { return default(Mono.Cecil.TypeReference); } }
    public Mono.Cecil.IMetadataScope Corlib { get { return default(Mono.Cecil.IMetadataScope); } }
    public Mono.Cecil.TypeReference Double { get { return default(Mono.Cecil.TypeReference); } }
    public Mono.Cecil.TypeReference Int16 { get { return default(Mono.Cecil.TypeReference); } }
    public Mono.Cecil.TypeReference Int32 { get { return default(Mono.Cecil.TypeReference); } }
    public Mono.Cecil.TypeReference Int64 { get { return default(Mono.Cecil.TypeReference); } }
    public Mono.Cecil.TypeReference IntPtr { get { return default(Mono.Cecil.TypeReference); } }
    public Mono.Cecil.TypeReference Object { get { return default(Mono.Cecil.TypeReference); } }
    public Mono.Cecil.TypeReference SByte { get { return default(Mono.Cecil.TypeReference); } }
    public Mono.Cecil.TypeReference Single { get { return default(Mono.Cecil.TypeReference); } }
    public Mono.Cecil.TypeReference String { get { return default(Mono.Cecil.TypeReference); } }
    public Mono.Cecil.TypeReference TypedReference { get { return default(Mono.Cecil.TypeReference); } }
    public Mono.Cecil.TypeReference UInt16 { get { return default(Mono.Cecil.TypeReference); } }
    public Mono.Cecil.TypeReference UInt32 { get { return default(Mono.Cecil.TypeReference); } }
    public Mono.Cecil.TypeReference UInt64 { get { return default(Mono.Cecil.TypeReference); } }
    public Mono.Cecil.TypeReference UIntPtr { get { return default(Mono.Cecil.TypeReference); } }
    public Mono.Cecil.TypeReference Void { get { return default(Mono.Cecil.TypeReference); } }
  }
  public enum VariantType {
    Bool = 11,
    BStr = 8,
    CY = 6,
    Date = 7,
    Decimal = 14,
    Dispatch = 9,
    Error = 10,
    I1 = 16,
    I2 = 2,
    I4 = 3,
    Int = 22,
    None = 0,
    R4 = 4,
    R8 = 5,
    UI1 = 17,
    UI2 = 18,
    UI4 = 19,
    UInt = 23,
    Unknown = 13,
    Variant = 12,
  }
  public sealed partial class WriterParameters {
    public WriterParameters() { }
    public System.Reflection.StrongNameKeyPair StrongNameKeyPair { get { return default(System.Reflection.StrongNameKeyPair); } set { } }
    public System.IO.Stream SymbolStream { get { return default(System.IO.Stream); } set { } }
    public Mono.Cecil.Cil.ISymbolWriterProvider SymbolWriterProvider { get { return default(Mono.Cecil.Cil.ISymbolWriterProvider); } set { } }
    public bool WriteSymbols { get { return default(bool); } set { } }
  }
}
namespace Mono.Cecil.Cil {
  public enum Code {
    Add = 87,
    Add_Ovf = 180,
    Add_Ovf_Un = 181,
    And = 94,
    Arglist = 191,
    Beq = 58,
    Beq_S = 45,
    Bge = 59,
    Bge_S = 46,
    Bge_Un = 64,
    Bge_Un_S = 51,
    Bgt = 60,
    Bgt_S = 47,
    Bgt_Un = 65,
    Bgt_Un_S = 52,
    Ble = 61,
    Ble_S = 48,
    Ble_Un = 66,
    Ble_Un_S = 53,
    Blt = 62,
    Blt_S = 49,
    Blt_Un = 67,
    Blt_Un_S = 54,
    Bne_Un = 63,
    Bne_Un_S = 50,
    Box = 137,
    Br = 55,
    Br_S = 42,
    Break = 1,
    Brfalse = 56,
    Brfalse_S = 43,
    Brtrue = 57,
    Brtrue_S = 44,
    Call = 39,
    Calli = 40,
    Callvirt = 110,
    Castclass = 115,
    Ceq = 192,
    Cgt = 193,
    Cgt_Un = 194,
    Ckfinite = 172,
    Clt = 195,
    Clt_Un = 196,
    Constrained = 211,
    Conv_I = 177,
    Conv_I1 = 102,
    Conv_I2 = 103,
    Conv_I4 = 104,
    Conv_I8 = 105,
    Conv_Ovf_I = 178,
    Conv_Ovf_I_Un = 135,
    Conv_Ovf_I1 = 163,
    Conv_Ovf_I1_Un = 127,
    Conv_Ovf_I2 = 165,
    Conv_Ovf_I2_Un = 128,
    Conv_Ovf_I4 = 167,
    Conv_Ovf_I4_Un = 129,
    Conv_Ovf_I8 = 169,
    Conv_Ovf_I8_Un = 130,
    Conv_Ovf_U = 179,
    Conv_Ovf_U_Un = 136,
    Conv_Ovf_U1 = 164,
    Conv_Ovf_U1_Un = 131,
    Conv_Ovf_U2 = 166,
    Conv_Ovf_U2_Un = 132,
    Conv_Ovf_U4 = 168,
    Conv_Ovf_U4_Un = 133,
    Conv_Ovf_U8 = 170,
    Conv_Ovf_U8_Un = 134,
    Conv_R_Un = 117,
    Conv_R4 = 106,
    Conv_R8 = 107,
    Conv_U = 190,
    Conv_U1 = 176,
    Conv_U2 = 175,
    Conv_U4 = 108,
    Conv_U8 = 109,
    Cpblk = 212,
    Cpobj = 111,
    Div = 90,
    Div_Un = 91,
    Dup = 36,
    Endfilter = 206,
    Endfinally = 186,
    Initblk = 213,
    Initobj = 210,
    Isinst = 116,
    Jmp = 38,
    Ldarg = 199,
    Ldarg_0 = 2,
    Ldarg_1 = 3,
    Ldarg_2 = 4,
    Ldarg_3 = 5,
    Ldarg_S = 14,
    Ldarga = 200,
    Ldarga_S = 15,
    Ldc_I4 = 32,
    Ldc_I4_0 = 22,
    Ldc_I4_1 = 23,
    Ldc_I4_2 = 24,
    Ldc_I4_3 = 25,
    Ldc_I4_4 = 26,
    Ldc_I4_5 = 27,
    Ldc_I4_6 = 28,
    Ldc_I4_7 = 29,
    Ldc_I4_8 = 30,
    Ldc_I4_M1 = 21,
    Ldc_I4_S = 31,
    Ldc_I8 = 33,
    Ldc_R4 = 34,
    Ldc_R8 = 35,
    Ldelem_Any = 160,
    Ldelem_I = 148,
    Ldelem_I1 = 141,
    Ldelem_I2 = 143,
    Ldelem_I4 = 145,
    Ldelem_I8 = 147,
    Ldelem_R4 = 149,
    Ldelem_R8 = 150,
    Ldelem_Ref = 151,
    Ldelem_U1 = 142,
    Ldelem_U2 = 144,
    Ldelem_U4 = 146,
    Ldelema = 140,
    Ldfld = 120,
    Ldflda = 121,
    Ldftn = 197,
    Ldind_I = 76,
    Ldind_I1 = 69,
    Ldind_I2 = 71,
    Ldind_I4 = 73,
    Ldind_I8 = 75,
    Ldind_R4 = 77,
    Ldind_R8 = 78,
    Ldind_Ref = 79,
    Ldind_U1 = 70,
    Ldind_U2 = 72,
    Ldind_U4 = 74,
    Ldlen = 139,
    Ldloc = 202,
    Ldloc_0 = 6,
    Ldloc_1 = 7,
    Ldloc_2 = 8,
    Ldloc_3 = 9,
    Ldloc_S = 17,
    Ldloca = 203,
    Ldloca_S = 18,
    Ldnull = 20,
    Ldobj = 112,
    Ldsfld = 123,
    Ldsflda = 124,
    Ldstr = 113,
    Ldtoken = 174,
    Ldvirtftn = 198,
    Leave = 187,
    Leave_S = 188,
    Localloc = 205,
    Mkrefany = 173,
    Mul = 89,
    Mul_Ovf = 182,
    Mul_Ovf_Un = 183,
    Neg = 100,
    Newarr = 138,
    Newobj = 114,
    No = 214,
    Nop = 0,
    Not = 101,
    Or = 95,
    Pop = 37,
    Readonly = 218,
    Refanytype = 217,
    Refanyval = 171,
    Rem = 92,
    Rem_Un = 93,
    Ret = 41,
    Rethrow = 215,
    Shl = 97,
    Shr = 98,
    Shr_Un = 99,
    Sizeof = 216,
    Starg = 201,
    Starg_S = 16,
    Stelem_Any = 161,
    Stelem_I = 152,
    Stelem_I1 = 153,
    Stelem_I2 = 154,
    Stelem_I4 = 155,
    Stelem_I8 = 156,
    Stelem_R4 = 157,
    Stelem_R8 = 158,
    Stelem_Ref = 159,
    Stfld = 122,
    Stind_I = 189,
    Stind_I1 = 81,
    Stind_I2 = 82,
    Stind_I4 = 83,
    Stind_I8 = 84,
    Stind_R4 = 85,
    Stind_R8 = 86,
    Stind_Ref = 80,
    Stloc = 204,
    Stloc_0 = 10,
    Stloc_1 = 11,
    Stloc_2 = 12,
    Stloc_3 = 13,
    Stloc_S = 19,
    Stobj = 126,
    Stsfld = 125,
    Sub = 88,
    Sub_Ovf = 184,
    Sub_Ovf_Un = 185,
    Switch = 68,
    Tail = 209,
    Throw = 119,
    Unaligned = 207,
    Unbox = 118,
    Unbox_Any = 162,
    Volatile = 208,
    Xor = 96,
  }
  public sealed partial class Document {
    public Document(string url) { }
    public System.Byte[] Hash { get { return default(System.Byte[]); } set { } }
    public Mono.Cecil.Cil.DocumentHashAlgorithm HashAlgorithm { get { return default(Mono.Cecil.Cil.DocumentHashAlgorithm); } set { } }
    public Mono.Cecil.Cil.DocumentLanguage Language { get { return default(Mono.Cecil.Cil.DocumentLanguage); } set { } }
    public Mono.Cecil.Cil.DocumentLanguageVendor LanguageVendor { get { return default(Mono.Cecil.Cil.DocumentLanguageVendor); } set { } }
    public Mono.Cecil.Cil.DocumentType Type { get { return default(Mono.Cecil.Cil.DocumentType); } set { } }
    public string Url { get { return default(string); } set { } }
  }
  public enum DocumentHashAlgorithm {
    MD5 = 1,
    None = 0,
    SHA1 = 2,
  }
  public enum DocumentLanguage {
    Basic = 4,
    C = 1,
    Cil = 8,
    Cobol = 6,
    Cpp = 2,
    CSharp = 3,
    FSharp = 12,
    Java = 5,
    JScript = 9,
    MCpp = 11,
    Other = 0,
    Pascal = 7,
    Smc = 10,
  }
  public enum DocumentLanguageVendor {
    Microsoft = 1,
    Other = 0,
  }
  public enum DocumentType {
    Other = 0,
    Text = 1,
  }
  public sealed partial class ExceptionHandler {
    public ExceptionHandler(Mono.Cecil.Cil.ExceptionHandlerType handlerType) { }
    public Mono.Cecil.TypeReference CatchType { get { return default(Mono.Cecil.TypeReference); } set { } }
    public Mono.Cecil.Cil.Instruction FilterStart { get { return default(Mono.Cecil.Cil.Instruction); } set { } }
    public Mono.Cecil.Cil.Instruction HandlerEnd { get { return default(Mono.Cecil.Cil.Instruction); } set { } }
    public Mono.Cecil.Cil.Instruction HandlerStart { get { return default(Mono.Cecil.Cil.Instruction); } set { } }
    public Mono.Cecil.Cil.ExceptionHandlerType HandlerType { get { return default(Mono.Cecil.Cil.ExceptionHandlerType); } set { } }
    public Mono.Cecil.Cil.Instruction TryEnd { get { return default(Mono.Cecil.Cil.Instruction); } set { } }
    public Mono.Cecil.Cil.Instruction TryStart { get { return default(Mono.Cecil.Cil.Instruction); } set { } }
  }
  public enum ExceptionHandlerType {
    Catch = 0,
    Fault = 4,
    Filter = 1,
    Finally = 2,
  }
  public enum FlowControl {
    Branch = 0,
    Break = 1,
    Call = 2,
    Cond_Branch = 3,
    Meta = 4,
    Next = 5,
    Phi = 6,
    Return = 7,
    Throw = 8,
  }
  public sealed partial class ILProcessor {
    internal ILProcessor() { }
    public Mono.Cecil.Cil.MethodBody Body { get { return default(Mono.Cecil.Cil.MethodBody); } }
    public void Append(Mono.Cecil.Cil.Instruction instruction) { }
    public Mono.Cecil.Cil.Instruction Create(Mono.Cecil.Cil.OpCode opcode) { return default(Mono.Cecil.Cil.Instruction); }
    public Mono.Cecil.Cil.Instruction Create(Mono.Cecil.Cil.OpCode opcode, Mono.Cecil.CallSite site) { return default(Mono.Cecil.Cil.Instruction); }
    public Mono.Cecil.Cil.Instruction Create(Mono.Cecil.Cil.OpCode opcode, Mono.Cecil.Cil.Instruction target) { return default(Mono.Cecil.Cil.Instruction); }
    public Mono.Cecil.Cil.Instruction Create(Mono.Cecil.Cil.OpCode opcode, Mono.Cecil.Cil.Instruction[] targets) { return default(Mono.Cecil.Cil.Instruction); }
    public Mono.Cecil.Cil.Instruction Create(Mono.Cecil.Cil.OpCode opcode, Mono.Cecil.Cil.VariableDefinition variable) { return default(Mono.Cecil.Cil.Instruction); }
    public Mono.Cecil.Cil.Instruction Create(Mono.Cecil.Cil.OpCode opcode, Mono.Cecil.FieldReference field) { return default(Mono.Cecil.Cil.Instruction); }
    public Mono.Cecil.Cil.Instruction Create(Mono.Cecil.Cil.OpCode opcode, Mono.Cecil.MethodReference method) { return default(Mono.Cecil.Cil.Instruction); }
    public Mono.Cecil.Cil.Instruction Create(Mono.Cecil.Cil.OpCode opcode, Mono.Cecil.ParameterDefinition parameter) { return default(Mono.Cecil.Cil.Instruction); }
    public Mono.Cecil.Cil.Instruction Create(Mono.Cecil.Cil.OpCode opcode, Mono.Cecil.TypeReference type) { return default(Mono.Cecil.Cil.Instruction); }
    public Mono.Cecil.Cil.Instruction Create(Mono.Cecil.Cil.OpCode opcode, byte value) { return default(Mono.Cecil.Cil.Instruction); }
    public Mono.Cecil.Cil.Instruction Create(Mono.Cecil.Cil.OpCode opcode, double value) { return default(Mono.Cecil.Cil.Instruction); }
    public Mono.Cecil.Cil.Instruction Create(Mono.Cecil.Cil.OpCode opcode, int value) { return default(Mono.Cecil.Cil.Instruction); }
    public Mono.Cecil.Cil.Instruction Create(Mono.Cecil.Cil.OpCode opcode, long value) { return default(Mono.Cecil.Cil.Instruction); }
    public Mono.Cecil.Cil.Instruction Create(Mono.Cecil.Cil.OpCode opcode, sbyte value) { return default(Mono.Cecil.Cil.Instruction); }
    public Mono.Cecil.Cil.Instruction Create(Mono.Cecil.Cil.OpCode opcode, float value) { return default(Mono.Cecil.Cil.Instruction); }
    public Mono.Cecil.Cil.Instruction Create(Mono.Cecil.Cil.OpCode opcode, string value) { return default(Mono.Cecil.Cil.Instruction); }
    public void Emit(Mono.Cecil.Cil.OpCode opcode) { }
    public void Emit(Mono.Cecil.Cil.OpCode opcode, Mono.Cecil.CallSite site) { }
    public void Emit(Mono.Cecil.Cil.OpCode opcode, Mono.Cecil.Cil.Instruction target) { }
    public void Emit(Mono.Cecil.Cil.OpCode opcode, Mono.Cecil.Cil.Instruction[] targets) { }
    public void Emit(Mono.Cecil.Cil.OpCode opcode, Mono.Cecil.Cil.VariableDefinition variable) { }
    public void Emit(Mono.Cecil.Cil.OpCode opcode, Mono.Cecil.FieldReference field) { }
    public void Emit(Mono.Cecil.Cil.OpCode opcode, Mono.Cecil.MethodReference method) { }
    public void Emit(Mono.Cecil.Cil.OpCode opcode, Mono.Cecil.ParameterDefinition parameter) { }
    public void Emit(Mono.Cecil.Cil.OpCode opcode, Mono.Cecil.TypeReference type) { }
    public void Emit(Mono.Cecil.Cil.OpCode opcode, byte value) { }
    public void Emit(Mono.Cecil.Cil.OpCode opcode, double value) { }
    public void Emit(Mono.Cecil.Cil.OpCode opcode, int value) { }
    public void Emit(Mono.Cecil.Cil.OpCode opcode, long value) { }
    public void Emit(Mono.Cecil.Cil.OpCode opcode, sbyte value) { }
    public void Emit(Mono.Cecil.Cil.OpCode opcode, float value) { }
    public void Emit(Mono.Cecil.Cil.OpCode opcode, string value) { }
    public void InsertAfter(Mono.Cecil.Cil.Instruction target, Mono.Cecil.Cil.Instruction instruction) { }
    public void InsertBefore(Mono.Cecil.Cil.Instruction target, Mono.Cecil.Cil.Instruction instruction) { }
    public void Remove(Mono.Cecil.Cil.Instruction instruction) { }
    public void Replace(Mono.Cecil.Cil.Instruction target, Mono.Cecil.Cil.Instruction instruction) { }
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct ImageDebugDirectory {
    public int AddressOfRawData;
    public int Characteristics;
    public short MajorVersion;
    public short MinorVersion;
    public int PointerToRawData;
    public int SizeOfData;
    public int TimeDateStamp;
    public int Type;
  }
  public sealed partial class Instruction {
    internal Instruction() { }
    public Mono.Cecil.Cil.Instruction Next { get { return default(Mono.Cecil.Cil.Instruction); } set { } }
    public int Offset { get { return default(int); } set { } }
    public Mono.Cecil.Cil.OpCode OpCode { get { return default(Mono.Cecil.Cil.OpCode); } set { } }
    public object Operand { get { return default(object); } set { } }
    public Mono.Cecil.Cil.Instruction Previous { get { return default(Mono.Cecil.Cil.Instruction); } set { } }
    public Mono.Cecil.Cil.SequencePoint SequencePoint { get { return default(Mono.Cecil.Cil.SequencePoint); } set { } }
    public static Mono.Cecil.Cil.Instruction Create(Mono.Cecil.Cil.OpCode opcode) { return default(Mono.Cecil.Cil.Instruction); }
    public static Mono.Cecil.Cil.Instruction Create(Mono.Cecil.Cil.OpCode opcode, Mono.Cecil.CallSite site) { return default(Mono.Cecil.Cil.Instruction); }
    public static Mono.Cecil.Cil.Instruction Create(Mono.Cecil.Cil.OpCode opcode, Mono.Cecil.Cil.Instruction target) { return default(Mono.Cecil.Cil.Instruction); }
    public static Mono.Cecil.Cil.Instruction Create(Mono.Cecil.Cil.OpCode opcode, Mono.Cecil.Cil.Instruction[] targets) { return default(Mono.Cecil.Cil.Instruction); }
    public static Mono.Cecil.Cil.Instruction Create(Mono.Cecil.Cil.OpCode opcode, Mono.Cecil.Cil.VariableDefinition variable) { return default(Mono.Cecil.Cil.Instruction); }
    public static Mono.Cecil.Cil.Instruction Create(Mono.Cecil.Cil.OpCode opcode, Mono.Cecil.FieldReference field) { return default(Mono.Cecil.Cil.Instruction); }
    public static Mono.Cecil.Cil.Instruction Create(Mono.Cecil.Cil.OpCode opcode, Mono.Cecil.MethodReference method) { return default(Mono.Cecil.Cil.Instruction); }
    public static Mono.Cecil.Cil.Instruction Create(Mono.Cecil.Cil.OpCode opcode, Mono.Cecil.ParameterDefinition parameter) { return default(Mono.Cecil.Cil.Instruction); }
    public static Mono.Cecil.Cil.Instruction Create(Mono.Cecil.Cil.OpCode opcode, Mono.Cecil.TypeReference type) { return default(Mono.Cecil.Cil.Instruction); }
    public static Mono.Cecil.Cil.Instruction Create(Mono.Cecil.Cil.OpCode opcode, byte value) { return default(Mono.Cecil.Cil.Instruction); }
    public static Mono.Cecil.Cil.Instruction Create(Mono.Cecil.Cil.OpCode opcode, double value) { return default(Mono.Cecil.Cil.Instruction); }
    public static Mono.Cecil.Cil.Instruction Create(Mono.Cecil.Cil.OpCode opcode, int value) { return default(Mono.Cecil.Cil.Instruction); }
    public static Mono.Cecil.Cil.Instruction Create(Mono.Cecil.Cil.OpCode opcode, long value) { return default(Mono.Cecil.Cil.Instruction); }
    public static Mono.Cecil.Cil.Instruction Create(Mono.Cecil.Cil.OpCode opcode, sbyte value) { return default(Mono.Cecil.Cil.Instruction); }
    public static Mono.Cecil.Cil.Instruction Create(Mono.Cecil.Cil.OpCode opcode, float value) { return default(Mono.Cecil.Cil.Instruction); }
    public static Mono.Cecil.Cil.Instruction Create(Mono.Cecil.Cil.OpCode opcode, string value) { return default(Mono.Cecil.Cil.Instruction); }
    public int GetSize() { return default(int); }
    public override string ToString() { return default(string); }
  }
  public delegate Mono.Cecil.Cil.Instruction InstructionMapper(int offset);
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct InstructionSymbol {
    public readonly int Offset;
    public readonly Mono.Cecil.Cil.SequencePoint SequencePoint;
    public InstructionSymbol(int offset, Mono.Cecil.Cil.SequencePoint sequencePoint) { throw new System.NotImplementedException(); }
  }
  public partial interface ISymbolReader : System.IDisposable {
    bool ProcessDebugHeader(Mono.Cecil.Cil.ImageDebugDirectory directory, System.Byte[] header);
    void Read(Mono.Cecil.Cil.MethodBody body, Mono.Cecil.Cil.InstructionMapper mapper);
    void Read(Mono.Cecil.Cil.MethodSymbols symbols);
  }
  public partial interface ISymbolReaderProvider {
    Mono.Cecil.Cil.ISymbolReader GetSymbolReader(Mono.Cecil.ModuleDefinition module, System.IO.Stream symbolStream);
    Mono.Cecil.Cil.ISymbolReader GetSymbolReader(Mono.Cecil.ModuleDefinition module, string fileName);
  }
  public partial interface ISymbolWriter : System.IDisposable {
    bool GetDebugHeader(out Mono.Cecil.Cil.ImageDebugDirectory directory, out System.Byte[] header);
    void Write(Mono.Cecil.Cil.MethodBody body);
    void Write(Mono.Cecil.Cil.MethodSymbols symbols);
  }
  public partial interface ISymbolWriterProvider {
    Mono.Cecil.Cil.ISymbolWriter GetSymbolWriter(Mono.Cecil.ModuleDefinition module, System.IO.Stream symbolStream);
    Mono.Cecil.Cil.ISymbolWriter GetSymbolWriter(Mono.Cecil.ModuleDefinition module, string fileName);
  }
  public partial interface IVariableDefinitionProvider {
    bool HasVariables { get; }
    Mono.Collections.Generic.Collection<Mono.Cecil.Cil.VariableDefinition> Variables { get; }
  }
  public sealed partial class MethodBody : Mono.Cecil.Cil.IVariableDefinitionProvider {
    public MethodBody(Mono.Cecil.MethodDefinition method) { }
    public int CodeSize { get { return default(int); } }
    public Mono.Collections.Generic.Collection<Mono.Cecil.Cil.ExceptionHandler> ExceptionHandlers { get { return default(Mono.Collections.Generic.Collection<Mono.Cecil.Cil.ExceptionHandler>); } }
    public bool HasExceptionHandlers { get { return default(bool); } }
    public bool HasVariables { get { return default(bool); } }
    public bool InitLocals { get { return default(bool); } set { } }
    public Mono.Collections.Generic.Collection<Mono.Cecil.Cil.Instruction> Instructions { get { return default(Mono.Collections.Generic.Collection<Mono.Cecil.Cil.Instruction>); } }
    public Mono.Cecil.MetadataToken LocalVarToken { get { return default(Mono.Cecil.MetadataToken); } set { } }
    public int MaxStackSize { get { return default(int); } set { } }
    public Mono.Cecil.MethodDefinition Method { get { return default(Mono.Cecil.MethodDefinition); } }
    public Mono.Cecil.Cil.Scope Scope { get { return default(Mono.Cecil.Cil.Scope); } set { } }
    public Mono.Cecil.ParameterDefinition ThisParameter { get { return default(Mono.Cecil.ParameterDefinition); } }
    public Mono.Collections.Generic.Collection<Mono.Cecil.Cil.VariableDefinition> Variables { get { return default(Mono.Collections.Generic.Collection<Mono.Cecil.Cil.VariableDefinition>); } }
    public Mono.Cecil.Cil.ILProcessor GetILProcessor() { return default(Mono.Cecil.Cil.ILProcessor); }
  }
  public sealed partial class MethodSymbols {
    public MethodSymbols(Mono.Cecil.MetadataToken methodToken) { }
    public int CodeSize { get { return default(int); } }
    public bool HasVariables { get { return default(bool); } }
    public Mono.Collections.Generic.Collection<Mono.Cecil.Cil.InstructionSymbol> Instructions { get { return default(Mono.Collections.Generic.Collection<Mono.Cecil.Cil.InstructionSymbol>); } }
    public Mono.Cecil.MetadataToken LocalVarToken { get { return default(Mono.Cecil.MetadataToken); } }
    public string MethodName { get { return default(string); } }
    public Mono.Cecil.MetadataToken MethodToken { get { return default(Mono.Cecil.MetadataToken); } }
    public Mono.Collections.Generic.Collection<Mono.Cecil.Cil.VariableDefinition> Variables { get { return default(Mono.Collections.Generic.Collection<Mono.Cecil.Cil.VariableDefinition>); } }
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct OpCode {
    public Mono.Cecil.Cil.Code Code { get { return default(Mono.Cecil.Cil.Code); } }
    public Mono.Cecil.Cil.FlowControl FlowControl { get { return default(Mono.Cecil.Cil.FlowControl); } }
    public string Name { get { return default(string); } }
    public byte Op1 { get { return default(byte); } }
    public byte Op2 { get { return default(byte); } }
    public Mono.Cecil.Cil.OpCodeType OpCodeType { get { return default(Mono.Cecil.Cil.OpCodeType); } }
    public Mono.Cecil.Cil.OperandType OperandType { get { return default(Mono.Cecil.Cil.OperandType); } }
    public int Size { get { return default(int); } }
    public Mono.Cecil.Cil.StackBehaviour StackBehaviourPop { get { return default(Mono.Cecil.Cil.StackBehaviour); } }
    public Mono.Cecil.Cil.StackBehaviour StackBehaviourPush { get { return default(Mono.Cecil.Cil.StackBehaviour); } }
    public short Value { get { return default(short); } }
    public bool Equals(Mono.Cecil.Cil.OpCode opcode) { return default(bool); }
    public override bool Equals(object obj) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public static bool operator ==(Mono.Cecil.Cil.OpCode one, Mono.Cecil.Cil.OpCode other) { return default(bool); }
    public static bool operator !=(Mono.Cecil.Cil.OpCode one, Mono.Cecil.Cil.OpCode other) { return default(bool); }
    public override string ToString() { return default(string); }
  }
  public static partial class OpCodes {
    public static readonly Mono.Cecil.Cil.OpCode Add;
    public static readonly Mono.Cecil.Cil.OpCode Add_Ovf;
    public static readonly Mono.Cecil.Cil.OpCode Add_Ovf_Un;
    public static readonly Mono.Cecil.Cil.OpCode And;
    public static readonly Mono.Cecil.Cil.OpCode Arglist;
    public static readonly Mono.Cecil.Cil.OpCode Beq;
    public static readonly Mono.Cecil.Cil.OpCode Beq_S;
    public static readonly Mono.Cecil.Cil.OpCode Bge;
    public static readonly Mono.Cecil.Cil.OpCode Bge_S;
    public static readonly Mono.Cecil.Cil.OpCode Bge_Un;
    public static readonly Mono.Cecil.Cil.OpCode Bge_Un_S;
    public static readonly Mono.Cecil.Cil.OpCode Bgt;
    public static readonly Mono.Cecil.Cil.OpCode Bgt_S;
    public static readonly Mono.Cecil.Cil.OpCode Bgt_Un;
    public static readonly Mono.Cecil.Cil.OpCode Bgt_Un_S;
    public static readonly Mono.Cecil.Cil.OpCode Ble;
    public static readonly Mono.Cecil.Cil.OpCode Ble_S;
    public static readonly Mono.Cecil.Cil.OpCode Ble_Un;
    public static readonly Mono.Cecil.Cil.OpCode Ble_Un_S;
    public static readonly Mono.Cecil.Cil.OpCode Blt;
    public static readonly Mono.Cecil.Cil.OpCode Blt_S;
    public static readonly Mono.Cecil.Cil.OpCode Blt_Un;
    public static readonly Mono.Cecil.Cil.OpCode Blt_Un_S;
    public static readonly Mono.Cecil.Cil.OpCode Bne_Un;
    public static readonly Mono.Cecil.Cil.OpCode Bne_Un_S;
    public static readonly Mono.Cecil.Cil.OpCode Box;
    public static readonly Mono.Cecil.Cil.OpCode Br;
    public static readonly Mono.Cecil.Cil.OpCode Br_S;
    public static readonly Mono.Cecil.Cil.OpCode Break;
    public static readonly Mono.Cecil.Cil.OpCode Brfalse;
    public static readonly Mono.Cecil.Cil.OpCode Brfalse_S;
    public static readonly Mono.Cecil.Cil.OpCode Brtrue;
    public static readonly Mono.Cecil.Cil.OpCode Brtrue_S;
    public static readonly Mono.Cecil.Cil.OpCode Call;
    public static readonly Mono.Cecil.Cil.OpCode Calli;
    public static readonly Mono.Cecil.Cil.OpCode Callvirt;
    public static readonly Mono.Cecil.Cil.OpCode Castclass;
    public static readonly Mono.Cecil.Cil.OpCode Ceq;
    public static readonly Mono.Cecil.Cil.OpCode Cgt;
    public static readonly Mono.Cecil.Cil.OpCode Cgt_Un;
    public static readonly Mono.Cecil.Cil.OpCode Ckfinite;
    public static readonly Mono.Cecil.Cil.OpCode Clt;
    public static readonly Mono.Cecil.Cil.OpCode Clt_Un;
    public static readonly Mono.Cecil.Cil.OpCode Constrained;
    public static readonly Mono.Cecil.Cil.OpCode Conv_I;
    public static readonly Mono.Cecil.Cil.OpCode Conv_I1;
    public static readonly Mono.Cecil.Cil.OpCode Conv_I2;
    public static readonly Mono.Cecil.Cil.OpCode Conv_I4;
    public static readonly Mono.Cecil.Cil.OpCode Conv_I8;
    public static readonly Mono.Cecil.Cil.OpCode Conv_Ovf_I;
    public static readonly Mono.Cecil.Cil.OpCode Conv_Ovf_I_Un;
    public static readonly Mono.Cecil.Cil.OpCode Conv_Ovf_I1;
    public static readonly Mono.Cecil.Cil.OpCode Conv_Ovf_I1_Un;
    public static readonly Mono.Cecil.Cil.OpCode Conv_Ovf_I2;
    public static readonly Mono.Cecil.Cil.OpCode Conv_Ovf_I2_Un;
    public static readonly Mono.Cecil.Cil.OpCode Conv_Ovf_I4;
    public static readonly Mono.Cecil.Cil.OpCode Conv_Ovf_I4_Un;
    public static readonly Mono.Cecil.Cil.OpCode Conv_Ovf_I8;
    public static readonly Mono.Cecil.Cil.OpCode Conv_Ovf_I8_Un;
    public static readonly Mono.Cecil.Cil.OpCode Conv_Ovf_U;
    public static readonly Mono.Cecil.Cil.OpCode Conv_Ovf_U_Un;
    public static readonly Mono.Cecil.Cil.OpCode Conv_Ovf_U1;
    public static readonly Mono.Cecil.Cil.OpCode Conv_Ovf_U1_Un;
    public static readonly Mono.Cecil.Cil.OpCode Conv_Ovf_U2;
    public static readonly Mono.Cecil.Cil.OpCode Conv_Ovf_U2_Un;
    public static readonly Mono.Cecil.Cil.OpCode Conv_Ovf_U4;
    public static readonly Mono.Cecil.Cil.OpCode Conv_Ovf_U4_Un;
    public static readonly Mono.Cecil.Cil.OpCode Conv_Ovf_U8;
    public static readonly Mono.Cecil.Cil.OpCode Conv_Ovf_U8_Un;
    public static readonly Mono.Cecil.Cil.OpCode Conv_R_Un;
    public static readonly Mono.Cecil.Cil.OpCode Conv_R4;
    public static readonly Mono.Cecil.Cil.OpCode Conv_R8;
    public static readonly Mono.Cecil.Cil.OpCode Conv_U;
    public static readonly Mono.Cecil.Cil.OpCode Conv_U1;
    public static readonly Mono.Cecil.Cil.OpCode Conv_U2;
    public static readonly Mono.Cecil.Cil.OpCode Conv_U4;
    public static readonly Mono.Cecil.Cil.OpCode Conv_U8;
    public static readonly Mono.Cecil.Cil.OpCode Cpblk;
    public static readonly Mono.Cecil.Cil.OpCode Cpobj;
    public static readonly Mono.Cecil.Cil.OpCode Div;
    public static readonly Mono.Cecil.Cil.OpCode Div_Un;
    public static readonly Mono.Cecil.Cil.OpCode Dup;
    public static readonly Mono.Cecil.Cil.OpCode Endfilter;
    public static readonly Mono.Cecil.Cil.OpCode Endfinally;
    public static readonly Mono.Cecil.Cil.OpCode Initblk;
    public static readonly Mono.Cecil.Cil.OpCode Initobj;
    public static readonly Mono.Cecil.Cil.OpCode Isinst;
    public static readonly Mono.Cecil.Cil.OpCode Jmp;
    public static readonly Mono.Cecil.Cil.OpCode Ldarg;
    public static readonly Mono.Cecil.Cil.OpCode Ldarg_0;
    public static readonly Mono.Cecil.Cil.OpCode Ldarg_1;
    public static readonly Mono.Cecil.Cil.OpCode Ldarg_2;
    public static readonly Mono.Cecil.Cil.OpCode Ldarg_3;
    public static readonly Mono.Cecil.Cil.OpCode Ldarg_S;
    public static readonly Mono.Cecil.Cil.OpCode Ldarga;
    public static readonly Mono.Cecil.Cil.OpCode Ldarga_S;
    public static readonly Mono.Cecil.Cil.OpCode Ldc_I4;
    public static readonly Mono.Cecil.Cil.OpCode Ldc_I4_0;
    public static readonly Mono.Cecil.Cil.OpCode Ldc_I4_1;
    public static readonly Mono.Cecil.Cil.OpCode Ldc_I4_2;
    public static readonly Mono.Cecil.Cil.OpCode Ldc_I4_3;
    public static readonly Mono.Cecil.Cil.OpCode Ldc_I4_4;
    public static readonly Mono.Cecil.Cil.OpCode Ldc_I4_5;
    public static readonly Mono.Cecil.Cil.OpCode Ldc_I4_6;
    public static readonly Mono.Cecil.Cil.OpCode Ldc_I4_7;
    public static readonly Mono.Cecil.Cil.OpCode Ldc_I4_8;
    public static readonly Mono.Cecil.Cil.OpCode Ldc_I4_M1;
    public static readonly Mono.Cecil.Cil.OpCode Ldc_I4_S;
    public static readonly Mono.Cecil.Cil.OpCode Ldc_I8;
    public static readonly Mono.Cecil.Cil.OpCode Ldc_R4;
    public static readonly Mono.Cecil.Cil.OpCode Ldc_R8;
    public static readonly Mono.Cecil.Cil.OpCode Ldelem_Any;
    public static readonly Mono.Cecil.Cil.OpCode Ldelem_I;
    public static readonly Mono.Cecil.Cil.OpCode Ldelem_I1;
    public static readonly Mono.Cecil.Cil.OpCode Ldelem_I2;
    public static readonly Mono.Cecil.Cil.OpCode Ldelem_I4;
    public static readonly Mono.Cecil.Cil.OpCode Ldelem_I8;
    public static readonly Mono.Cecil.Cil.OpCode Ldelem_R4;
    public static readonly Mono.Cecil.Cil.OpCode Ldelem_R8;
    public static readonly Mono.Cecil.Cil.OpCode Ldelem_Ref;
    public static readonly Mono.Cecil.Cil.OpCode Ldelem_U1;
    public static readonly Mono.Cecil.Cil.OpCode Ldelem_U2;
    public static readonly Mono.Cecil.Cil.OpCode Ldelem_U4;
    public static readonly Mono.Cecil.Cil.OpCode Ldelema;
    public static readonly Mono.Cecil.Cil.OpCode Ldfld;
    public static readonly Mono.Cecil.Cil.OpCode Ldflda;
    public static readonly Mono.Cecil.Cil.OpCode Ldftn;
    public static readonly Mono.Cecil.Cil.OpCode Ldind_I;
    public static readonly Mono.Cecil.Cil.OpCode Ldind_I1;
    public static readonly Mono.Cecil.Cil.OpCode Ldind_I2;
    public static readonly Mono.Cecil.Cil.OpCode Ldind_I4;
    public static readonly Mono.Cecil.Cil.OpCode Ldind_I8;
    public static readonly Mono.Cecil.Cil.OpCode Ldind_R4;
    public static readonly Mono.Cecil.Cil.OpCode Ldind_R8;
    public static readonly Mono.Cecil.Cil.OpCode Ldind_Ref;
    public static readonly Mono.Cecil.Cil.OpCode Ldind_U1;
    public static readonly Mono.Cecil.Cil.OpCode Ldind_U2;
    public static readonly Mono.Cecil.Cil.OpCode Ldind_U4;
    public static readonly Mono.Cecil.Cil.OpCode Ldlen;
    public static readonly Mono.Cecil.Cil.OpCode Ldloc;
    public static readonly Mono.Cecil.Cil.OpCode Ldloc_0;
    public static readonly Mono.Cecil.Cil.OpCode Ldloc_1;
    public static readonly Mono.Cecil.Cil.OpCode Ldloc_2;
    public static readonly Mono.Cecil.Cil.OpCode Ldloc_3;
    public static readonly Mono.Cecil.Cil.OpCode Ldloc_S;
    public static readonly Mono.Cecil.Cil.OpCode Ldloca;
    public static readonly Mono.Cecil.Cil.OpCode Ldloca_S;
    public static readonly Mono.Cecil.Cil.OpCode Ldnull;
    public static readonly Mono.Cecil.Cil.OpCode Ldobj;
    public static readonly Mono.Cecil.Cil.OpCode Ldsfld;
    public static readonly Mono.Cecil.Cil.OpCode Ldsflda;
    public static readonly Mono.Cecil.Cil.OpCode Ldstr;
    public static readonly Mono.Cecil.Cil.OpCode Ldtoken;
    public static readonly Mono.Cecil.Cil.OpCode Ldvirtftn;
    public static readonly Mono.Cecil.Cil.OpCode Leave;
    public static readonly Mono.Cecil.Cil.OpCode Leave_S;
    public static readonly Mono.Cecil.Cil.OpCode Localloc;
    public static readonly Mono.Cecil.Cil.OpCode Mkrefany;
    public static readonly Mono.Cecil.Cil.OpCode Mul;
    public static readonly Mono.Cecil.Cil.OpCode Mul_Ovf;
    public static readonly Mono.Cecil.Cil.OpCode Mul_Ovf_Un;
    public static readonly Mono.Cecil.Cil.OpCode Neg;
    public static readonly Mono.Cecil.Cil.OpCode Newarr;
    public static readonly Mono.Cecil.Cil.OpCode Newobj;
    public static readonly Mono.Cecil.Cil.OpCode No;
    public static readonly Mono.Cecil.Cil.OpCode Nop;
    public static readonly Mono.Cecil.Cil.OpCode Not;
    public static readonly Mono.Cecil.Cil.OpCode Or;
    public static readonly Mono.Cecil.Cil.OpCode Pop;
    public static readonly Mono.Cecil.Cil.OpCode Readonly;
    public static readonly Mono.Cecil.Cil.OpCode Refanytype;
    public static readonly Mono.Cecil.Cil.OpCode Refanyval;
    public static readonly Mono.Cecil.Cil.OpCode Rem;
    public static readonly Mono.Cecil.Cil.OpCode Rem_Un;
    public static readonly Mono.Cecil.Cil.OpCode Ret;
    public static readonly Mono.Cecil.Cil.OpCode Rethrow;
    public static readonly Mono.Cecil.Cil.OpCode Shl;
    public static readonly Mono.Cecil.Cil.OpCode Shr;
    public static readonly Mono.Cecil.Cil.OpCode Shr_Un;
    public static readonly Mono.Cecil.Cil.OpCode Sizeof;
    public static readonly Mono.Cecil.Cil.OpCode Starg;
    public static readonly Mono.Cecil.Cil.OpCode Starg_S;
    public static readonly Mono.Cecil.Cil.OpCode Stelem_Any;
    public static readonly Mono.Cecil.Cil.OpCode Stelem_I;
    public static readonly Mono.Cecil.Cil.OpCode Stelem_I1;
    public static readonly Mono.Cecil.Cil.OpCode Stelem_I2;
    public static readonly Mono.Cecil.Cil.OpCode Stelem_I4;
    public static readonly Mono.Cecil.Cil.OpCode Stelem_I8;
    public static readonly Mono.Cecil.Cil.OpCode Stelem_R4;
    public static readonly Mono.Cecil.Cil.OpCode Stelem_R8;
    public static readonly Mono.Cecil.Cil.OpCode Stelem_Ref;
    public static readonly Mono.Cecil.Cil.OpCode Stfld;
    public static readonly Mono.Cecil.Cil.OpCode Stind_I;
    public static readonly Mono.Cecil.Cil.OpCode Stind_I1;
    public static readonly Mono.Cecil.Cil.OpCode Stind_I2;
    public static readonly Mono.Cecil.Cil.OpCode Stind_I4;
    public static readonly Mono.Cecil.Cil.OpCode Stind_I8;
    public static readonly Mono.Cecil.Cil.OpCode Stind_R4;
    public static readonly Mono.Cecil.Cil.OpCode Stind_R8;
    public static readonly Mono.Cecil.Cil.OpCode Stind_Ref;
    public static readonly Mono.Cecil.Cil.OpCode Stloc;
    public static readonly Mono.Cecil.Cil.OpCode Stloc_0;
    public static readonly Mono.Cecil.Cil.OpCode Stloc_1;
    public static readonly Mono.Cecil.Cil.OpCode Stloc_2;
    public static readonly Mono.Cecil.Cil.OpCode Stloc_3;
    public static readonly Mono.Cecil.Cil.OpCode Stloc_S;
    public static readonly Mono.Cecil.Cil.OpCode Stobj;
    public static readonly Mono.Cecil.Cil.OpCode Stsfld;
    public static readonly Mono.Cecil.Cil.OpCode Sub;
    public static readonly Mono.Cecil.Cil.OpCode Sub_Ovf;
    public static readonly Mono.Cecil.Cil.OpCode Sub_Ovf_Un;
    public static readonly Mono.Cecil.Cil.OpCode Switch;
    public static readonly Mono.Cecil.Cil.OpCode Tail;
    public static readonly Mono.Cecil.Cil.OpCode Throw;
    public static readonly Mono.Cecil.Cil.OpCode Unaligned;
    public static readonly Mono.Cecil.Cil.OpCode Unbox;
    public static readonly Mono.Cecil.Cil.OpCode Unbox_Any;
    public static readonly Mono.Cecil.Cil.OpCode Volatile;
    public static readonly Mono.Cecil.Cil.OpCode Xor;
  }
  public enum OpCodeType {
    Annotation = 0,
    Macro = 1,
    Nternal = 2,
    Objmodel = 3,
    Prefix = 4,
    Primitive = 5,
  }
  public enum OperandType {
    InlineArg = 14,
    InlineBrTarget = 0,
    InlineField = 1,
    InlineI = 2,
    InlineI8 = 3,
    InlineMethod = 4,
    InlineNone = 5,
    InlinePhi = 6,
    InlineR = 7,
    InlineSig = 8,
    InlineString = 9,
    InlineSwitch = 10,
    InlineTok = 11,
    InlineType = 12,
    InlineVar = 13,
    ShortInlineArg = 19,
    ShortInlineBrTarget = 15,
    ShortInlineI = 16,
    ShortInlineR = 17,
    ShortInlineVar = 18,
  }
  public sealed partial class Scope : Mono.Cecil.Cil.IVariableDefinitionProvider {
    public Scope() { }
    public Mono.Cecil.Cil.Instruction End { get { return default(Mono.Cecil.Cil.Instruction); } set { } }
    public bool HasScopes { get { return default(bool); } }
    public bool HasVariables { get { return default(bool); } }
    public Mono.Collections.Generic.Collection<Mono.Cecil.Cil.Scope> Scopes { get { return default(Mono.Collections.Generic.Collection<Mono.Cecil.Cil.Scope>); } }
    public Mono.Cecil.Cil.Instruction Start { get { return default(Mono.Cecil.Cil.Instruction); } set { } }
    public Mono.Collections.Generic.Collection<Mono.Cecil.Cil.VariableDefinition> Variables { get { return default(Mono.Collections.Generic.Collection<Mono.Cecil.Cil.VariableDefinition>); } }
  }
  public sealed partial class SequencePoint {
    public SequencePoint(Mono.Cecil.Cil.Document document) { }
    public Mono.Cecil.Cil.Document Document { get { return default(Mono.Cecil.Cil.Document); } set { } }
    public int EndColumn { get { return default(int); } set { } }
    public int EndLine { get { return default(int); } set { } }
    public int StartColumn { get { return default(int); } set { } }
    public int StartLine { get { return default(int); } set { } }
  }
  public enum StackBehaviour {
    Pop0 = 0,
    Pop1 = 1,
    Pop1_pop1 = 2,
    PopAll = 18,
    Popi = 3,
    Popi_pop1 = 4,
    Popi_popi = 5,
    Popi_popi_popi = 7,
    Popi_popi8 = 6,
    Popi_popr4 = 8,
    Popi_popr8 = 9,
    Popref = 10,
    Popref_pop1 = 11,
    Popref_popi = 12,
    Popref_popi_popi = 13,
    Popref_popi_popi8 = 14,
    Popref_popi_popr4 = 15,
    Popref_popi_popr8 = 16,
    Popref_popi_popref = 17,
    Push0 = 19,
    Push1 = 20,
    Push1_push1 = 21,
    Pushi = 22,
    Pushi8 = 23,
    Pushr4 = 24,
    Pushr8 = 25,
    Pushref = 26,
    Varpop = 27,
    Varpush = 28,
  }
  public sealed partial class VariableDefinition : Mono.Cecil.Cil.VariableReference {
    public VariableDefinition(Mono.Cecil.TypeReference variableType) { }
    public VariableDefinition(string name, Mono.Cecil.TypeReference variableType) { }
    public bool IsPinned { get { return default(bool); } }
    public override Mono.Cecil.Cil.VariableDefinition Resolve() { return default(Mono.Cecil.Cil.VariableDefinition); }
  }
  public abstract partial class VariableReference {
    internal VariableReference() { }
    protected Mono.Cecil.TypeReference variable_type;
    public int Index { get { return default(int); } }
    public string Name { get { return default(string); } set { } }
    public Mono.Cecil.TypeReference VariableType { get { return default(Mono.Cecil.TypeReference); } set { } }
    public abstract Mono.Cecil.Cil.VariableDefinition Resolve();
    public override string ToString() { return default(string); }
  }
}
namespace Mono.Collections.Generic {
  public partial class Collection<T> : System.Collections.Generic.ICollection<T>, System.Collections.Generic.IEnumerable<T>, System.Collections.Generic.IList<T>, System.Collections.ICollection, System.Collections.IEnumerable, System.Collections.IList {
    public Collection() { }
    public Collection(System.Collections.Generic.ICollection<T> items) { }
    public Collection(int capacity) { }
    public int Count { get { return default(int); } }
    public T this[int index] { get { return default(T); } set { } }
    bool System.Collections.Generic.ICollection<T>.IsReadOnly { get { return default(bool); } }
    int System.Collections.ICollection.Count { get { return default(int); } }
    bool System.Collections.ICollection.IsSynchronized { get { return default(bool); } }
    object System.Collections.ICollection.SyncRoot { get { return default(object); } }
    bool System.Collections.IList.IsFixedSize { get { return default(bool); } }
    bool System.Collections.IList.IsReadOnly { get { return default(bool); } }
    object System.Collections.IList.this[int index] { get { return default(object); } set { } }
    public void Add(T item) { }
    public void Clear() { }
    public bool Contains(T item) { return default(bool); }
    public void CopyTo(T[] array, int arrayIndex) { }
    public Mono.Collections.Generic.Collection<T>.Enumerator GetEnumerator() { return default(Mono.Collections.Generic.Collection<T>.Enumerator); }
    public int IndexOf(T item) { return default(int); }
    public void Insert(int index, T item) { }
    protected virtual void OnAdd(T item, int index) { }
    protected virtual void OnClear() { }
    protected virtual void OnInsert(T item, int index) { }
    protected virtual void OnRemove(T item, int index) { }
    protected virtual void OnSet(T item, int index) { }
    public bool Remove(T item) { return default(bool); }
    public void RemoveAt(int index) { }
    System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { return default(System.Collections.Generic.IEnumerator<T>); }
    void System.Collections.ICollection.CopyTo(System.Array array, int index) { }
    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { return default(System.Collections.IEnumerator); }
    int System.Collections.IList.Add(object value) { return default(int); }
    void System.Collections.IList.Clear() { }
    bool System.Collections.IList.Contains(object value) { return default(bool); }
    int System.Collections.IList.IndexOf(object value) { return default(int); }
    void System.Collections.IList.Insert(int index, object value) { }
    void System.Collections.IList.Remove(object value) { }
    void System.Collections.IList.RemoveAt(int index) { }
    public T[] ToArray() { return default(T[]); }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct Enumerator : System.Collections.Generic.IEnumerator<T>, System.Collections.IEnumerator, System.IDisposable {
      public T Current { get { return default(T); } }
      object System.Collections.IEnumerator.Current { get { return default(object); } }
      public void Dispose() { }
      public bool MoveNext() { return default(bool); }
      public void Reset() { }
    }
  }
  public sealed partial class ReadOnlyCollection<T> : Mono.Collections.Generic.Collection<T>, System.Collections.Generic.ICollection<T>, System.Collections.Generic.IEnumerable<T>, System.Collections.ICollection, System.Collections.IEnumerable, System.Collections.IList {
    public ReadOnlyCollection(T[] array) { }
    public ReadOnlyCollection(Mono.Collections.Generic.Collection<T> collection) { }
    public static Mono.Collections.Generic.ReadOnlyCollection<T> Empty { get { return default(Mono.Collections.Generic.ReadOnlyCollection<T>); } }
    bool System.Collections.Generic.ICollection<T>.IsReadOnly { get { return default(bool); } }
    bool System.Collections.IList.IsFixedSize { get { return default(bool); } }
    bool System.Collections.IList.IsReadOnly { get { return default(bool); } }
    protected override void OnAdd(T item, int index) { }
    protected override void OnClear() { }
    protected override void OnInsert(T item, int index) { }
    protected override void OnRemove(T item, int index) { }
    protected override void OnSet(T item, int index) { }
  }
}
