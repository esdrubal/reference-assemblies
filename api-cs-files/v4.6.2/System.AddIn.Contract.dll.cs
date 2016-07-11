namespace System.AddIn.Contract {
  public partial interface IContract {
    int AcquireLifetimeToken();
    int GetRemoteHashCode();
    System.AddIn.Contract.IContract QueryContract(string contractIdentifier);
    bool RemoteEquals(System.AddIn.Contract.IContract contract);
    string RemoteToString();
    void RevokeLifetimeToken(int token);
  }
  public partial interface IEnumeratorContract<T> : System.IDisposable {
    T GetCurrent();
    bool MoveNext();
    void Reset();
  }
  public partial interface IExecutorExtensionContract : System.AddIn.Contract.IContract {
    void AssemblyLoaded(string assemblyName);
    void AssemblyLoadedFrom(string assemblyFile);
    void AssemblyLoading(string assemblyName);
    void AssemblyLoadingFrom(string assemblyFile);
    void EntryPointStarted(System.AddIn.Contract.IContract entryPoint);
    void EntryPointStarting(string assemblyName, string startupClass, System.AddIn.Contract.Collections.IRemoteArgumentArrayContract initArgs);
    void ExecutorCreated();
  }
  public partial interface IListContract<T> : System.AddIn.Contract.IContract {
    void Add(T item);
    void Clear();
    bool Contains(T item);
    int GetCount();
    System.AddIn.Contract.IEnumeratorContract<T> GetEnumeratorContract();
    bool GetIsReadOnly();
    T GetItem(int index);
    int IndexOf(T item);
    void Insert(int index, T item);
    bool Remove(T item);
    void RemoveAt(int index);
    void SetItem(int index, T item);
  }
  public partial interface INativeHandleContract : System.AddIn.Contract.IContract {
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(2))]
    System.IntPtr GetHandle();
  }
  public partial interface IProfferServiceContract : System.AddIn.Contract.IContract {
    void ProfferService(string serviceIdentifier, System.AddIn.Contract.IServiceProviderContract service);
    void RevokeService(string serviceIdentifier);
  }
  public partial interface ISerializableObjectContract : System.AddIn.Contract.Collections.IRemoteArgumentCollectionContract, System.AddIn.Contract.Collections.IRemoteArgumentDictionaryContract, System.AddIn.Contract.Collections.IRemoteArgumentEnumerableContract, System.AddIn.Contract.IContract {
    string GetCanonicalName();
    System.AddIn.Contract.SerializableObjectData GetSerializableObjectData();
  }
  public partial interface IServiceProviderContract : System.AddIn.Contract.IContract {
    System.AddIn.Contract.IContract QueryService(string serviceIdentifier, string serviceContractIdentifier);
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct RemoteArgument {
    public RemoteArgument(System.AddIn.Contract.IContract value) { throw new System.NotImplementedException(); }
    public RemoteArgument(System.AddIn.Contract.IContract value, bool isByRef) { throw new System.NotImplementedException(); }
    public RemoteArgument(System.AddIn.Contract.RemoteArgumentKind remoteArgKind, System.TypeCode typeCode) { throw new System.NotImplementedException(); }
    public RemoteArgument(System.AddIn.Contract.RemoteArgumentKind remoteArgKind, System.TypeCode typeCode, bool isByRef) { throw new System.NotImplementedException(); }
    public RemoteArgument(System.Array array) { throw new System.NotImplementedException(); }
    public RemoteArgument(System.Array array, bool isByRef) { throw new System.NotImplementedException(); }
    public RemoteArgument(bool value) { throw new System.NotImplementedException(); }
    public RemoteArgument(bool value, bool isByRef) { throw new System.NotImplementedException(); }
    public RemoteArgument(byte value) { throw new System.NotImplementedException(); }
    public RemoteArgument(byte value, bool isByRef) { throw new System.NotImplementedException(); }
    public RemoteArgument(char value) { throw new System.NotImplementedException(); }
    public RemoteArgument(char value, bool isByRef) { throw new System.NotImplementedException(); }
    public RemoteArgument(System.DateTime value) { throw new System.NotImplementedException(); }
    public RemoteArgument(System.DateTime value, bool isByRef) { throw new System.NotImplementedException(); }
    public RemoteArgument(System.DBNull value) { throw new System.NotImplementedException(); }
    public RemoteArgument(System.DBNull value, bool isByRef) { throw new System.NotImplementedException(); }
    public RemoteArgument(decimal value) { throw new System.NotImplementedException(); }
    public RemoteArgument(decimal value, bool isByRef) { throw new System.NotImplementedException(); }
    public RemoteArgument(double value) { throw new System.NotImplementedException(); }
    public RemoteArgument(double value, bool isByRef) { throw new System.NotImplementedException(); }
    public RemoteArgument(short value) { throw new System.NotImplementedException(); }
    public RemoteArgument(short value, bool isByRef) { throw new System.NotImplementedException(); }
    public RemoteArgument(int value) { throw new System.NotImplementedException(); }
    public RemoteArgument(int value, bool isByRef) { throw new System.NotImplementedException(); }
    public RemoteArgument(long value) { throw new System.NotImplementedException(); }
    public RemoteArgument(long value, bool isByRef) { throw new System.NotImplementedException(); }
    [System.CLSCompliantAttribute(false)]
    public RemoteArgument(sbyte value) { throw new System.NotImplementedException(); }
    [System.CLSCompliantAttribute(false)]
    public RemoteArgument(sbyte value, bool isByRef) { throw new System.NotImplementedException(); }
    public RemoteArgument(float value) { throw new System.NotImplementedException(); }
    public RemoteArgument(float value, bool isByRef) { throw new System.NotImplementedException(); }
    public RemoteArgument(string value) { throw new System.NotImplementedException(); }
    public RemoteArgument(string value, bool isByRef) { throw new System.NotImplementedException(); }
    [System.CLSCompliantAttribute(false)]
    public RemoteArgument(ushort value) { throw new System.NotImplementedException(); }
    [System.CLSCompliantAttribute(false)]
    public RemoteArgument(ushort value, bool isByRef) { throw new System.NotImplementedException(); }
    [System.CLSCompliantAttribute(false)]
    public RemoteArgument(uint value) { throw new System.NotImplementedException(); }
    [System.CLSCompliantAttribute(false)]
    public RemoteArgument(uint value, bool isByRef) { throw new System.NotImplementedException(); }
    [System.CLSCompliantAttribute(false)]
    public RemoteArgument(ulong value) { throw new System.NotImplementedException(); }
    [System.CLSCompliantAttribute(false)]
    public RemoteArgument(ulong value, bool isByRef) { throw new System.NotImplementedException(); }
    public System.Array ArrayValue { get { return default(System.Array); } set { } }
    public bool BooleanValue { get { return default(bool); } set { } }
    public byte ByteValue { get { return default(byte); } set { } }
    public char CharValue { get { return default(char); } set { } }
    public System.AddIn.Contract.IContract ContractValue { get { return default(System.AddIn.Contract.IContract); } set { } }
    public System.DateTime DateTimeValue { get { return default(System.DateTime); } set { } }
    public System.DBNull DBNullValue { get { return default(System.DBNull); } set { } }
    public decimal DecimalValue { get { return default(decimal); } set { } }
    public double DoubleValue { get { return default(double); } set { } }
    public short Int16Value { get { return default(short); } set { } }
    public int Int32Value { get { return default(int); } set { } }
    public long Int64Value { get { return default(long); } set { } }
    public bool IsByRef { get { return default(bool); } set { } }
    public System.Reflection.Missing MissingValue { get { return default(System.Reflection.Missing); } }
    public System.AddIn.Contract.RemoteArgumentKind RemoteArgumentKind { get { return default(System.AddIn.Contract.RemoteArgumentKind); } }
    [System.CLSCompliantAttribute(false)]
    public sbyte SByteValue { get { return default(sbyte); } set { } }
    public float SingleValue { get { return default(float); } set { } }
    public string StringValue { get { return default(string); } set { } }
    public System.TypeCode TypeCode { get { return default(System.TypeCode); } }
    [System.CLSCompliantAttribute(false)]
    public ushort UInt16Value { get { return default(ushort); } set { } }
    [System.CLSCompliantAttribute(false)]
    public uint UInt32Value { get { return default(uint); } set { } }
    [System.CLSCompliantAttribute(false)]
    public ulong UInt64Value { get { return default(ulong); } set { } }
    public static System.AddIn.Contract.RemoteArgument CreateRemoteArgument(object value) { return default(System.AddIn.Contract.RemoteArgument); }
    public static System.AddIn.Contract.RemoteArgument CreateRemoteArgument(object value, bool isByRef) { return default(System.AddIn.Contract.RemoteArgument); }
    public static System.AddIn.Contract.RemoteArgument CreateRemoteArgument(object value, bool isByRef, System.TypeCode typeCodeToUse) { return default(System.AddIn.Contract.RemoteArgument); }
  }
  public enum RemoteArgumentKind {
    Contract = 3,
    Intrinsic = 1,
    IntrinsicArray = 2,
    Missing = 0,
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct SerializableObjectData {
    public System.Int32[] DimensionLengths;
    public System.Int32[] DimensionLowerBounds;
    public System.Int32[] ElementIndexes;
    public bool IsArray;
    public bool IsArrayElement;
    public string MemberName;
    public long ObjectId;
    public long ParentId;
  }
}
namespace System.AddIn.Contract.Automation {
  public partial interface IRemoteDelegateContract : System.AddIn.Contract.Automation.IRemoteObjectContract, System.AddIn.Contract.IContract {
    System.AddIn.Contract.RemoteArgument InvokeDelegate(System.AddIn.Contract.Collections.IRemoteArgumentArrayContract args);
  }
  public partial interface IRemoteEventInfoContract : System.AddIn.Contract.IContract {
    System.AddIn.Contract.Automation.IRemoteMethodInfoContract GetAddMethod();
    System.AddIn.Contract.Automation.RemoteMemberData GetMemberData();
    System.AddIn.Contract.Automation.IRemoteMethodInfoContract GetRemoveMethod();
  }
  public partial interface IRemoteFieldInfoContract : System.AddIn.Contract.IContract {
    System.AddIn.Contract.Automation.RemoteFieldData GetFieldData();
    System.AddIn.Contract.RemoteArgument GetValue(System.AddIn.Contract.Automation.IRemoteObjectContract obj);
    void SetValue(System.AddIn.Contract.Automation.IRemoteObjectContract obj, System.AddIn.Contract.RemoteArgument value, int localeId);
  }
  public partial interface IRemoteMethodInfoContract : System.AddIn.Contract.IContract {
    System.AddIn.Contract.Automation.RemoteMethodData GetMethodData();
    System.AddIn.Contract.RemoteArgument Invoke(System.AddIn.Contract.Automation.IRemoteObjectContract target, System.Reflection.BindingFlags bindingFlags, System.AddIn.Contract.Collections.IRemoteArgumentArrayContract parameters, int localeId);
  }
  public partial interface IRemoteObjectContract : System.AddIn.Contract.IContract {
    System.AddIn.Contract.Automation.IRemoteTypeContract GetRemoteType();
    System.AddIn.Contract.RemoteArgument RemoteCast(string canonicalName);
  }
  public partial interface IRemotePropertyInfoContract : System.AddIn.Contract.IContract {
    System.AddIn.Contract.Automation.IRemoteMethodInfoContract GetGetMethod();
    System.AddIn.Contract.Automation.RemotePropertyData GetPropertyData();
    System.AddIn.Contract.Automation.IRemoteMethodInfoContract GetSetMethod();
    System.AddIn.Contract.RemoteArgument GetValue(System.AddIn.Contract.Automation.IRemoteObjectContract obj, System.Reflection.BindingFlags bindingFlags, System.AddIn.Contract.Collections.IRemoteArgumentArrayContract index, int localeId);
    void SetValue(System.AddIn.Contract.Automation.IRemoteObjectContract target, ref System.AddIn.Contract.RemoteArgument value, System.Reflection.BindingFlags bindingFlags, System.AddIn.Contract.Collections.IRemoteArgumentArrayContract index, int localeId);
  }
  public partial interface IRemoteTypeContract : System.AddIn.Contract.IContract {
    string GetCanonicalName();
    System.AddIn.Contract.Automation.IRemoteEventInfoContract GetEvent(string name, System.Reflection.BindingFlags bindingFlags);
    System.AddIn.Contract.Collections.IArrayContract<System.AddIn.Contract.Automation.IRemoteEventInfoContract> GetEvents(System.Reflection.BindingFlags bindingFlags);
    System.AddIn.Contract.Automation.IRemoteFieldInfoContract GetField(string name, System.Reflection.BindingFlags bindingFlags);
    System.AddIn.Contract.Collections.IArrayContract<System.AddIn.Contract.Automation.IRemoteFieldInfoContract> GetFields(System.Reflection.BindingFlags bindingFlags);
    System.AddIn.Contract.Automation.IRemoteTypeContract GetInterface(string canonicalName);
    System.AddIn.Contract.Collections.IArrayContract<System.AddIn.Contract.Automation.IRemoteTypeContract> GetInterfaces();
    System.AddIn.Contract.Collections.IArrayContract<System.AddIn.Contract.IContract> GetMember(string name, System.Reflection.MemberTypes memberTypes, System.Reflection.BindingFlags bindingFlags);
    System.AddIn.Contract.Collections.IArrayContract<System.AddIn.Contract.IContract> GetMembers(System.Reflection.BindingFlags bindingFlags);
    System.AddIn.Contract.Automation.IRemoteMethodInfoContract GetMethod(string name, System.Reflection.BindingFlags bindingFlags, System.AddIn.Contract.Collections.IArrayContract<System.AddIn.Contract.Automation.IRemoteTypeContract> remoteTypes);
    System.AddIn.Contract.Collections.IArrayContract<System.AddIn.Contract.Automation.IRemoteMethodInfoContract> GetMethods(System.Reflection.BindingFlags bindingFlags);
    System.AddIn.Contract.Collections.IArrayContract<System.AddIn.Contract.Automation.IRemotePropertyInfoContract> GetProperties(System.Reflection.BindingFlags bindingFlags);
    System.AddIn.Contract.Automation.IRemotePropertyInfoContract GetProperty(string name, System.Reflection.BindingFlags bindingFlags, System.AddIn.Contract.Automation.IRemoteTypeContract remoteReturnType, System.AddIn.Contract.Collections.IArrayContract<System.AddIn.Contract.Automation.IRemoteTypeContract> remoteTypes);
    System.AddIn.Contract.Automation.RemoteTypeData GetTypeData();
    System.AddIn.Contract.RemoteArgument InvokeMember(string name, System.Reflection.BindingFlags bindingFlags, System.AddIn.Contract.Automation.IRemoteObjectContract target, System.AddIn.Contract.Collections.IRemoteArgumentArrayContract remoteArgs, System.Boolean[] remoteArgModifiers, int localeId);
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct RemoteFieldData {
    public System.Reflection.FieldAttributes Attributes;
    public System.AddIn.Contract.Automation.IRemoteTypeContract FieldType;
    public System.AddIn.Contract.Automation.RemoteMemberData MemberData;
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct RemoteMemberData {
    public System.AddIn.Contract.Automation.IRemoteTypeContract DeclaringType;
    public string Name;
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct RemoteMethodData {
    public System.Reflection.MethodAttributes Attributes;
    public System.AddIn.Contract.Automation.RemoteMemberData MemberData;
    public System.AddIn.Contract.Automation.RemoteParameterData[] Parameters;
    public System.AddIn.Contract.Automation.RemoteParameterData ReturnParameter;
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct RemoteParameterData {
    public System.Reflection.ParameterAttributes Attributes;
    public System.AddIn.Contract.RemoteArgument DefaultValue;
    public bool IsByRef;
    public bool IsParameterArray;
    public string Name;
    public System.AddIn.Contract.Automation.IRemoteTypeContract ParameterType;
    public int Position;
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct RemotePropertyData {
    public System.Reflection.PropertyAttributes Attributes;
    public bool CanRead;
    public bool CanWrite;
    public System.AddIn.Contract.Automation.RemoteParameterData[] IndexParameters;
    public System.AddIn.Contract.Automation.RemoteMemberData MemberData;
    public System.AddIn.Contract.Automation.IRemoteTypeContract PropertyType;
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct RemoteTypeData {
    public int ArrayRank;
    public string AssemblyName;
    public string AssemblyQualifiedName;
    public System.Reflection.TypeAttributes Attributes;
    public System.AddIn.Contract.Automation.IRemoteTypeContract BaseType;
    public System.AddIn.Contract.Automation.IRemoteTypeContract ElementType;
    public string FullName;
    public bool IsArray;
    public bool IsByRef;
    public System.AddIn.Contract.Automation.RemoteMemberData MemberData;
    public System.TypeCode TypeCode;
  }
}
namespace System.AddIn.Contract.Collections {
  public partial interface IArrayContract<C> : System.AddIn.Contract.Collections.IEnumerableContract<C>, System.AddIn.Contract.IContract where C : System.AddIn.Contract.IContract {
    int GetCount();
    C GetItem(int index);
    void SetItem(int index, C value);
  }
  public partial interface ICollectionContract<C> : System.AddIn.Contract.Collections.IEnumerableContract<C>, System.AddIn.Contract.IContract where C : System.AddIn.Contract.IContract {
    void Add(C item);
    void Clear();
    bool Contains(C item);
    void CopyTo(C[] array, int arrayIndex);
    int GetCount();
    bool GetIsReadOnly();
    bool Remove(C item);
  }
  public partial interface IEnumerableContract<C> : System.AddIn.Contract.IContract where C : System.AddIn.Contract.IContract {
    System.AddIn.Contract.Collections.IEnumeratorContract<C> GetEnumeratorContract();
  }
  public partial interface IEnumeratorContract<C> : System.AddIn.Contract.IContract where C : System.AddIn.Contract.IContract {
    C GetCurrent();
    bool MoveNext();
    void Reset();
  }
  public partial interface IListContract<C> : System.AddIn.Contract.Collections.ICollectionContract<C>, System.AddIn.Contract.Collections.IEnumerableContract<C>, System.AddIn.Contract.IContract where C : System.AddIn.Contract.IContract {
    C GetItem(int index);
    int IndexOf(C item);
    void Insert(int index, C item);
    void RemoveAt(int index);
    void SetItem(int index, C value);
  }
  public partial interface IRemoteArgumentArrayContract : System.AddIn.Contract.Collections.IRemoteArgumentCollectionContract, System.AddIn.Contract.Collections.IRemoteArgumentEnumerableContract, System.AddIn.Contract.IContract {
    System.AddIn.Contract.RemoteArgument GetItem(int index);
    void SetItem(int index, System.AddIn.Contract.RemoteArgument value);
  }
  public partial interface IRemoteArgumentArrayListContract : System.AddIn.Contract.Collections.IRemoteArgumentArrayContract, System.AddIn.Contract.Collections.IRemoteArgumentCollectionContract, System.AddIn.Contract.Collections.IRemoteArgumentEnumerableContract, System.AddIn.Contract.IContract {
    void Add(System.AddIn.Contract.RemoteArgument newItem);
    void Clear();
    bool Contains(System.AddIn.Contract.RemoteArgument item);
    int IndexOf(System.AddIn.Contract.RemoteArgument item);
    void Insert(int index, System.AddIn.Contract.RemoteArgument item);
    void Remove(System.AddIn.Contract.RemoteArgument item);
    void RemoveAt(int index);
  }
  public partial interface IRemoteArgumentCollectionContract : System.AddIn.Contract.Collections.IRemoteArgumentEnumerableContract, System.AddIn.Contract.IContract {
    int GetCount();
  }
  public partial interface IRemoteArgumentDictionaryContract : System.AddIn.Contract.Collections.IRemoteArgumentCollectionContract, System.AddIn.Contract.Collections.IRemoteArgumentEnumerableContract, System.AddIn.Contract.IContract {
    void Add(System.AddIn.Contract.RemoteArgument key, System.AddIn.Contract.RemoteArgument value);
    void Clear();
    bool ContainsKey(System.AddIn.Contract.RemoteArgument key);
    new System.AddIn.Contract.Collections.IRemoteArgumentDictionaryEnumeratorContract GetEnumeratorContract();
    System.AddIn.Contract.RemoteArgument GetItem(System.AddIn.Contract.RemoteArgument key);
    System.AddIn.Contract.Collections.IRemoteArgumentCollectionContract GetKeys();
    System.AddIn.Contract.Collections.IRemoteArgumentCollectionContract GetValues();
    bool Remove(System.AddIn.Contract.RemoteArgument key);
    void SetItem(System.AddIn.Contract.RemoteArgument key, System.AddIn.Contract.RemoteArgument value);
  }
  public partial interface IRemoteArgumentDictionaryEnumeratorContract : System.AddIn.Contract.Collections.IRemoteArgumentEnumeratorContract, System.AddIn.Contract.IContract {
    System.AddIn.Contract.Collections.RemoteArgumentDictionaryEntry GetEntry();
    System.AddIn.Contract.RemoteArgument GetKey();
    System.AddIn.Contract.RemoteArgument GetValue();
  }
  public partial interface IRemoteArgumentEnumerableContract : System.AddIn.Contract.IContract {
    System.AddIn.Contract.Collections.IRemoteArgumentEnumeratorContract GetEnumeratorContract();
  }
  public partial interface IRemoteArgumentEnumeratorContract : System.AddIn.Contract.IContract {
    System.AddIn.Contract.RemoteArgument GetCurrent();
    bool MoveNext();
    void Reset();
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct RemoteArgumentDictionaryEntry {
    public System.AddIn.Contract.RemoteArgument Key;
    public System.AddIn.Contract.RemoteArgument Value;
    public RemoteArgumentDictionaryEntry(System.AddIn.Contract.RemoteArgument key, System.AddIn.Contract.RemoteArgument value) { throw new System.NotImplementedException(); }
  }
}
namespace System.AddIn.Pipeline {
  [System.AttributeUsageAttribute((System.AttributeTargets)(1024))]
  public sealed partial class AddInContractAttribute : System.Attribute {
    public AddInContractAttribute() { }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(1028), AllowMultiple=true)]
  public sealed partial class QualificationDataAttribute : System.Attribute {
    public QualificationDataAttribute(string name, string value) { }
    public string Name { get { return default(string); } }
    public string Value { get { return default(string); } }
  }
}
