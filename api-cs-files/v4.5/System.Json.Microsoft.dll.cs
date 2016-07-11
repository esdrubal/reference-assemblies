namespace System.Json {
  [System.Runtime.Serialization.DataContractAttribute]
  public sealed partial class JsonArray : System.Json.JsonValue, System.Collections.Generic.ICollection<System.Json.JsonValue>, System.Collections.Generic.IEnumerable<System.Json.JsonValue>, System.Collections.Generic.IList<System.Json.JsonValue>, System.Collections.IEnumerable {
    public JsonArray(System.Collections.Generic.IEnumerable<System.Json.JsonValue> items) { }
    public JsonArray(params System.Json.JsonValue[] items) { }
    public override int Count { get { return default(int); } }
    public bool IsReadOnly { get { return default(bool); } }
    public override System.Json.JsonValue this[int index] { get { return default(System.Json.JsonValue); } set { } }
    public override System.Json.JsonType JsonType { get { return default(System.Json.JsonType); } }
    public void Add(System.Json.JsonValue item) { }
    public void AddRange(System.Collections.Generic.IEnumerable<System.Json.JsonValue> items) { }
    public void AddRange(params System.Json.JsonValue[] items) { }
    public void Clear() { }
    public bool Contains(System.Json.JsonValue item) { return default(bool); }
    public void CopyTo(System.Json.JsonValue[] array, int arrayIndex) { }
    public new System.Collections.Generic.IEnumerator<System.Json.JsonValue> GetEnumerator() { return default(System.Collections.Generic.IEnumerator<System.Json.JsonValue>); }
    [System.Diagnostics.DebuggerHiddenAttribute]
    protected override System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String, System.Json.JsonValue>> GetKeyValuePairEnumerator() { return default(System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String, System.Json.JsonValue>>); }
    public int IndexOf(System.Json.JsonValue item) { return default(int); }
    public void Insert(int index, System.Json.JsonValue item) { }
    public bool Remove(System.Json.JsonValue item) { return default(bool); }
    public void RemoveAt(int index) { }
    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { return default(System.Collections.IEnumerator); }
    public override System.Json.JsonValue ValueOrDefault(int index) { return default(System.Json.JsonValue); }
  }
  [System.Runtime.Serialization.DataContractAttribute]
  public sealed partial class JsonObject : System.Json.JsonValue, System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String, System.Json.JsonValue>>, System.Collections.Generic.IDictionary<System.String, System.Json.JsonValue>, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Json.JsonValue>>, System.Collections.IEnumerable {
    public JsonObject(System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Json.JsonValue>> items) { }
    public JsonObject(params System.Collections.Generic.KeyValuePair<System.String, System.Json.JsonValue>[] items) { }
    public override int Count { get { return default(int); } }
    public override System.Json.JsonValue this[string key] { get { return default(System.Json.JsonValue); } set { } }
    public override System.Json.JsonType JsonType { get { return default(System.Json.JsonType); } }
    public System.Collections.Generic.ICollection<System.String> Keys { get { return default(System.Collections.Generic.ICollection<System.String>); } }
    bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<string,System.Json.JsonValue>>.IsReadOnly { get { return default(bool); } }
    public System.Collections.Generic.ICollection<System.Json.JsonValue> Values { get { return default(System.Collections.Generic.ICollection<System.Json.JsonValue>); } }
    public void Add(System.Collections.Generic.KeyValuePair<System.String, System.Json.JsonValue> item) { }
    public void Add(string key, System.Json.JsonValue value) { }
    public void AddRange(System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Json.JsonValue>> items) { }
    public void AddRange(params System.Collections.Generic.KeyValuePair<System.String, System.Json.JsonValue>[] items) { }
    public void Clear() { }
    public override bool ContainsKey(string key) { return default(bool); }
    public void CopyTo(System.Collections.Generic.KeyValuePair<System.String, System.Json.JsonValue>[] array, int arrayIndex) { }
    protected override System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String, System.Json.JsonValue>> GetKeyValuePairEnumerator() { return default(System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String, System.Json.JsonValue>>); }
    protected override void OnSaveEnded() { }
    protected override void OnSaveStarted() { }
    public bool Remove(string key) { return default(bool); }
    bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<string,System.Json.JsonValue>>.Contains(System.Collections.Generic.KeyValuePair<System.String, System.Json.JsonValue> item) { return default(bool); }
    bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<string,System.Json.JsonValue>>.Remove(System.Collections.Generic.KeyValuePair<System.String, System.Json.JsonValue> item) { return default(bool); }
    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { return default(System.Collections.IEnumerator); }
    public bool TryGetValue(string key, out System.Json.JsonValue value) { value = default(System.Json.JsonValue); return default(bool); }
    public override System.Json.JsonValue ValueOrDefault(string key) { return default(System.Json.JsonValue); }
  }
  [System.Runtime.Serialization.DataContractAttribute]
  public sealed partial class JsonPrimitive : System.Json.JsonValue {
    public JsonPrimitive(bool value) { }
    public JsonPrimitive(byte value) { }
    public JsonPrimitive(char value) { }
    public JsonPrimitive(System.DateTime value) { }
    public JsonPrimitive(System.DateTimeOffset value) { }
    public JsonPrimitive(decimal value) { }
    public JsonPrimitive(double value) { }
    public JsonPrimitive(System.Guid value) { }
    public JsonPrimitive(short value) { }
    public JsonPrimitive(int value) { }
    public JsonPrimitive(long value) { }
    [System.CLSCompliantAttribute(false)]
    public JsonPrimitive(sbyte value) { }
    public JsonPrimitive(float value) { }
    public JsonPrimitive(string value) { }
    [System.CLSCompliantAttribute(false)]
    public JsonPrimitive(ushort value) { }
    [System.CLSCompliantAttribute(false)]
    public JsonPrimitive(uint value) { }
    [System.CLSCompliantAttribute(false)]
    public JsonPrimitive(ulong value) { }
    public JsonPrimitive(System.Uri value) { }
    public override System.Json.JsonType JsonType { get { return default(System.Json.JsonType); } }
    public object Value { get { return default(object); } }
    public override object ReadAs(System.Type type) { return default(object); }
    public static bool TryCreate(object value, out System.Json.JsonPrimitive result) { result = default(System.Json.JsonPrimitive); return default(bool); }
    public override bool TryReadAs(System.Type type, out object value) { value = default(object); return default(bool); }
  }
  public enum JsonType {
    Array = 3,
    Boolean = 4,
    Default = 5,
    Number = 1,
    Object = 2,
    String = 0,
  }
  [System.Runtime.Serialization.DataContractAttribute]
  public partial class JsonValue : System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Json.JsonValue>>, System.Collections.IEnumerable, System.Dynamic.IDynamicMetaObjectProvider {
    internal JsonValue() { }
    protected int ChangedListenersCount { get { return default(int); } }
    protected int ChangingListenersCount { get { return default(int); } }
    public virtual int Count { get { return default(int); } }
    public virtual System.Json.JsonValue this[int index] { get { return default(System.Json.JsonValue); } set { } }
    public virtual System.Json.JsonValue this[string key] { get { return default(System.Json.JsonValue); } set { } }
    public virtual System.Json.JsonType JsonType { get { return default(System.Json.JsonType); } }
    public event System.EventHandler<System.Json.JsonValueChangeEventArgs> Changed { add { } remove { } }
    public event System.EventHandler<System.Json.JsonValueChangeEventArgs> Changing { add { } remove { } }
    public dynamic AsDynamic() { return default(object); }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public static T CastValue<T>(System.Json.JsonValue value) { return default(T); }
    public virtual bool ContainsKey(string key) { return default(bool); }
    public System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String, System.Json.JsonValue>> GetEnumerator() { return default(System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String, System.Json.JsonValue>>); }
    [System.Diagnostics.DebuggerHiddenAttribute]
    protected virtual System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String, System.Json.JsonValue>> GetKeyValuePairEnumerator() { return default(System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String, System.Json.JsonValue>>); }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public virtual System.Json.JsonValue GetValue(int index) { return default(System.Json.JsonValue); }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public virtual System.Json.JsonValue GetValue(string key) { return default(System.Json.JsonValue); }
    public static System.Json.JsonValue Load(System.IO.Stream stream) { return default(System.Json.JsonValue); }
    public static System.Json.JsonValue Load(System.IO.TextReader textReader) { return default(System.Json.JsonValue); }
    protected virtual void OnSaveEnded() { }
    protected virtual void OnSaveStarted() { }
    public static explicit operator bool (System.Json.JsonValue value) { return default(bool); }
    public static explicit operator byte (System.Json.JsonValue value) { return default(byte); }
    public static explicit operator char (System.Json.JsonValue value) { return default(char); }
    public static explicit operator System.DateTime (System.Json.JsonValue value) { return default(System.DateTime); }
    public static explicit operator System.DateTimeOffset (System.Json.JsonValue value) { return default(System.DateTimeOffset); }
    public static explicit operator decimal (System.Json.JsonValue value) { return default(decimal); }
    public static explicit operator double (System.Json.JsonValue value) { return default(double); }
    public static explicit operator System.Guid (System.Json.JsonValue value) { return default(System.Guid); }
    public static explicit operator short (System.Json.JsonValue value) { return default(short); }
    public static explicit operator int (System.Json.JsonValue value) { return default(int); }
    public static explicit operator long (System.Json.JsonValue value) { return default(long); }
    [System.CLSCompliantAttribute(false)]
    public static explicit operator sbyte (System.Json.JsonValue value) { return default(sbyte); }
    public static explicit operator float (System.Json.JsonValue value) { return default(float); }
    public static explicit operator string (System.Json.JsonValue value) { return default(string); }
    [System.CLSCompliantAttribute(false)]
    public static explicit operator ushort (System.Json.JsonValue value) { return default(ushort); }
    [System.CLSCompliantAttribute(false)]
    public static explicit operator uint (System.Json.JsonValue value) { return default(uint); }
    [System.CLSCompliantAttribute(false)]
    public static explicit operator ulong (System.Json.JsonValue value) { return default(ulong); }
    public static explicit operator System.Uri (System.Json.JsonValue value) { return default(System.Uri); }
    public static implicit operator System.Json.JsonValue (bool value) { return default(System.Json.JsonValue); }
    public static implicit operator System.Json.JsonValue (byte value) { return default(System.Json.JsonValue); }
    public static implicit operator System.Json.JsonValue (char value) { return default(System.Json.JsonValue); }
    public static implicit operator System.Json.JsonValue (System.DateTime value) { return default(System.Json.JsonValue); }
    public static implicit operator System.Json.JsonValue (System.DateTimeOffset value) { return default(System.Json.JsonValue); }
    public static implicit operator System.Json.JsonValue (decimal value) { return default(System.Json.JsonValue); }
    public static implicit operator System.Json.JsonValue (double value) { return default(System.Json.JsonValue); }
    public static implicit operator System.Json.JsonValue (System.Guid value) { return default(System.Json.JsonValue); }
    public static implicit operator System.Json.JsonValue (short value) { return default(System.Json.JsonValue); }
    public static implicit operator System.Json.JsonValue (int value) { return default(System.Json.JsonValue); }
    public static implicit operator System.Json.JsonValue (long value) { return default(System.Json.JsonValue); }
    [System.CLSCompliantAttribute(false)]
    public static implicit operator System.Json.JsonValue (sbyte value) { return default(System.Json.JsonValue); }
    public static implicit operator System.Json.JsonValue (float value) { return default(System.Json.JsonValue); }
    public static implicit operator System.Json.JsonValue (string value) { return default(System.Json.JsonValue); }
    [System.CLSCompliantAttribute(false)]
    public static implicit operator System.Json.JsonValue (ushort value) { return default(System.Json.JsonValue); }
    [System.CLSCompliantAttribute(false)]
    public static implicit operator System.Json.JsonValue (uint value) { return default(System.Json.JsonValue); }
    [System.CLSCompliantAttribute(false)]
    public static implicit operator System.Json.JsonValue (ulong value) { return default(System.Json.JsonValue); }
    public static implicit operator System.Json.JsonValue (System.Uri value) { return default(System.Json.JsonValue); }
    public static System.Json.JsonValue Parse(string json) { return default(System.Json.JsonValue); }
    protected void RaiseChangedEvent(object sender, System.Json.JsonValueChangeEventArgs eventArgs) { }
    protected void RaiseChangingEvent(object sender, System.Json.JsonValueChangeEventArgs eventArgs) { }
    public virtual object ReadAs(System.Type type) { return default(object); }
    public object ReadAs(System.Type type, object fallback) { return default(object); }
    public T ReadAs<T>() { return default(T); }
    public T ReadAs<T>(T fallback) { return default(T); }
    public void Save(System.IO.Stream stream) { }
    public void Save(System.IO.TextWriter textWriter) { }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public virtual System.Json.JsonValue SetValue(int index, object value) { return default(System.Json.JsonValue); }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public virtual System.Json.JsonValue SetValue(string key, object value) { return default(System.Json.JsonValue); }
    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { return default(System.Collections.IEnumerator); }
    System.Dynamic.DynamicMetaObject System.Dynamic.IDynamicMetaObjectProvider.GetMetaObject(System.Linq.Expressions.Expression parameter) { return default(System.Dynamic.DynamicMetaObject); }
    public override string ToString() { return default(string); }
    public virtual bool TryReadAs(System.Type type, out object value) { value = default(object); return default(bool); }
    public bool TryReadAs<T>(out T valueOfT) { valueOfT = default(T); return default(bool); }
    public virtual System.Json.JsonValue ValueOrDefault(int index) { return default(System.Json.JsonValue); }
    public System.Json.JsonValue ValueOrDefault(params System.Object[] indexes) { return default(System.Json.JsonValue); }
    public virtual System.Json.JsonValue ValueOrDefault(string key) { return default(System.Json.JsonValue); }
  }
  public enum JsonValueChange {
    Add = 0,
    Clear = 3,
    Remove = 1,
    Replace = 2,
  }
  public partial class JsonValueChangeEventArgs : System.EventArgs {
    public JsonValueChangeEventArgs(System.Json.JsonValue child, System.Json.JsonValueChange change, int index) { }
    public JsonValueChangeEventArgs(System.Json.JsonValue child, System.Json.JsonValueChange change, string key) { }
    public System.Json.JsonValueChange Change { get { return default(System.Json.JsonValueChange); } }
    public System.Json.JsonValue Child { get { return default(System.Json.JsonValue); } }
    public int Index { get { return default(int); } }
    public string Key { get { return default(string); } }
  }
  [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
  public static partial class JsonValueLinqExtensions {
    public static System.Json.JsonArray ToJsonArray(this System.Collections.Generic.IEnumerable<System.Json.JsonValue> items) { return default(System.Json.JsonArray); }
    public static System.Json.JsonObject ToJsonObject(this System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Json.JsonValue>> items) { return default(System.Json.JsonObject); }
  }
}
namespace System.Runtime.Serialization.Json {
  [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
  public static partial class JsonValueExtensions {
    public static System.Json.JsonValue CreateFrom(object value) { return default(System.Json.JsonValue); }
    public static object ReadAsType(this System.Json.JsonValue jsonValue, System.Type type) { return default(object); }
    public static T ReadAsType<T>(this System.Json.JsonValue jsonValue) { return default(T); }
    public static T ReadAsType<T>(this System.Json.JsonValue jsonValue, T fallback) { return default(T); }
    public static bool TryReadAsType(this System.Json.JsonValue jsonValue, System.Type type, out object value) { value = default(object); return default(bool); }
    public static bool TryReadAsType<T>(this System.Json.JsonValue jsonValue, out T valueOfT) { valueOfT = default(T); return default(bool); }
  }
}
