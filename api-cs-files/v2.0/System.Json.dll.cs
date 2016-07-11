namespace System.Json {
  public partial class JsonArray : System.Json.JsonValue, System.Collections.Generic.ICollection<System.Json.JsonValue>, System.Collections.Generic.IEnumerable<System.Json.JsonValue>, System.Collections.Generic.IList<System.Json.JsonValue>, System.Collections.IEnumerable {
    public JsonArray(System.Collections.Generic.IEnumerable<System.Json.JsonValue> items) { }
    public JsonArray(params System.Json.JsonValue[] items) { }
    public override int Count { get { return default(int); } }
    public bool IsReadOnly { get { return default(bool); } }
    public sealed override System.Json.JsonValue this[int index] { get { return default(System.Json.JsonValue); } set { } }
    public override System.Json.JsonType JsonType { get { return default(System.Json.JsonType); } }
    public void Add(System.Json.JsonValue item) { }
    public void AddRange(System.Collections.Generic.IEnumerable<System.Json.JsonValue> items) { }
    public void AddRange(params System.Json.JsonValue[] items) { }
    public void Clear() { }
    public bool Contains(System.Json.JsonValue item) { return default(bool); }
    public void CopyTo(System.Json.JsonValue[] array, int arrayIndex) { }
    public int IndexOf(System.Json.JsonValue item) { return default(int); }
    public void Insert(int index, System.Json.JsonValue item) { }
    public bool Remove(System.Json.JsonValue item) { return default(bool); }
    public void RemoveAt(int index) { }
    public override void Save(System.IO.Stream stream) { }
    System.Collections.Generic.IEnumerator<System.Json.JsonValue> System.Collections.Generic.IEnumerable<System.Json.JsonValue>.GetEnumerator() { return default(System.Collections.Generic.IEnumerator<System.Json.JsonValue>); }
    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { return default(System.Collections.IEnumerator); }
  }
  public partial class JsonObject : System.Json.JsonValue, System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String, System.Json.JsonValue>>, System.Collections.Generic.IDictionary<System.String, System.Json.JsonValue>, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Json.JsonValue>>, System.Collections.IEnumerable {
    public JsonObject(System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Json.JsonValue>> items) { }
    public JsonObject(params System.Collections.Generic.KeyValuePair<System.String, System.Json.JsonValue>[] items) { }
    public override int Count { get { return default(int); } }
    public sealed override System.Json.JsonValue this[string key] { get { return default(System.Json.JsonValue); } set { } }
    public override System.Json.JsonType JsonType { get { return default(System.Json.JsonType); } }
    public System.Collections.Generic.ICollection<System.String> Keys { get { return default(System.Collections.Generic.ICollection<System.String>); } }
    bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<string,System.Json.JsonValue>>.IsReadOnly { get { return default(bool); } }
    public System.Collections.Generic.ICollection<System.Json.JsonValue> Values { get { return default(System.Collections.Generic.ICollection<System.Json.JsonValue>); } }
    public void Add(System.Collections.Generic.KeyValuePair<System.String, System.Json.JsonValue> pair) { }
    public void Add(string key, System.Json.JsonValue value) { }
    public void AddRange(System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Json.JsonValue>> items) { }
    public void AddRange(params System.Collections.Generic.KeyValuePair<System.String, System.Json.JsonValue>[] items) { }
    public void Clear() { }
    public override bool ContainsKey(string key) { return default(bool); }
    public void CopyTo(System.Collections.Generic.KeyValuePair<System.String, System.Json.JsonValue>[] array, int arrayIndex) { }
    public System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String, System.Json.JsonValue>> GetEnumerator() { return default(System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String, System.Json.JsonValue>>); }
    public bool Remove(string key) { return default(bool); }
    public override void Save(System.IO.Stream stream) { }
    bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<string,System.Json.JsonValue>>.Contains(System.Collections.Generic.KeyValuePair<System.String, System.Json.JsonValue> item) { return default(bool); }
    bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<string,System.Json.JsonValue>>.Remove(System.Collections.Generic.KeyValuePair<System.String, System.Json.JsonValue> item) { return default(bool); }
    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { return default(System.Collections.IEnumerator); }
    public bool TryGetValue(string key, out System.Json.JsonValue value) { value = default(System.Json.JsonValue); return default(bool); }
  }
  public partial class JsonPrimitive : System.Json.JsonValue {
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
    public JsonPrimitive(sbyte value) { }
    public JsonPrimitive(float value) { }
    public JsonPrimitive(string value) { }
    public JsonPrimitive(System.TimeSpan value) { }
    public JsonPrimitive(ushort value) { }
    public JsonPrimitive(uint value) { }
    public JsonPrimitive(ulong value) { }
    public JsonPrimitive(System.Uri value) { }
    public override System.Json.JsonType JsonType { get { return default(System.Json.JsonType); } }
    public override void Save(System.IO.Stream stream) { }
  }
  public enum JsonType {
    Array = 3,
    Boolean = 4,
    Number = 1,
    Object = 2,
    String = 0,
  }
  public abstract partial class JsonValue : System.Collections.IEnumerable {
    protected JsonValue() { }
    public virtual int Count { get { return default(int); } }
    public virtual System.Json.JsonValue this[int index] { get { return default(System.Json.JsonValue); } set { } }
    public virtual System.Json.JsonValue this[string key] { get { return default(System.Json.JsonValue); } set { } }
    public abstract System.Json.JsonType JsonType { get; }
    public virtual bool ContainsKey(string key) { return default(bool); }
    public static System.Json.JsonValue Load(System.IO.Stream stream) { return default(System.Json.JsonValue); }
    public static System.Json.JsonValue Load(System.IO.TextReader textReader) { return default(System.Json.JsonValue); }
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
    public static implicit operator bool (System.Json.JsonValue value) { return default(bool); }
    public static implicit operator byte (System.Json.JsonValue value) { return default(byte); }
    public static implicit operator char (System.Json.JsonValue value) { return default(char); }
    public static implicit operator System.DateTime (System.Json.JsonValue value) { return default(System.DateTime); }
    public static implicit operator System.DateTimeOffset (System.Json.JsonValue value) { return default(System.DateTimeOffset); }
    public static implicit operator decimal (System.Json.JsonValue value) { return default(decimal); }
    public static implicit operator double (System.Json.JsonValue value) { return default(double); }
    public static implicit operator System.Guid (System.Json.JsonValue value) { return default(System.Guid); }
    public static implicit operator short (System.Json.JsonValue value) { return default(short); }
    public static implicit operator int (System.Json.JsonValue value) { return default(int); }
    public static implicit operator long (System.Json.JsonValue value) { return default(long); }
    public static implicit operator sbyte (System.Json.JsonValue value) { return default(sbyte); }
    public static implicit operator float (System.Json.JsonValue value) { return default(float); }
    public static implicit operator string (System.Json.JsonValue value) { return default(string); }
    public static implicit operator System.TimeSpan (System.Json.JsonValue value) { return default(System.TimeSpan); }
    public static implicit operator ushort (System.Json.JsonValue value) { return default(ushort); }
    public static implicit operator uint (System.Json.JsonValue value) { return default(uint); }
    public static implicit operator ulong (System.Json.JsonValue value) { return default(ulong); }
    public static implicit operator System.Uri (System.Json.JsonValue value) { return default(System.Uri); }
    public static implicit operator System.Json.JsonValue (sbyte value) { return default(System.Json.JsonValue); }
    public static implicit operator System.Json.JsonValue (float value) { return default(System.Json.JsonValue); }
    public static implicit operator System.Json.JsonValue (string value) { return default(System.Json.JsonValue); }
    public static implicit operator System.Json.JsonValue (System.TimeSpan value) { return default(System.Json.JsonValue); }
    public static implicit operator System.Json.JsonValue (ushort value) { return default(System.Json.JsonValue); }
    public static implicit operator System.Json.JsonValue (uint value) { return default(System.Json.JsonValue); }
    public static implicit operator System.Json.JsonValue (ulong value) { return default(System.Json.JsonValue); }
    public static implicit operator System.Json.JsonValue (System.Uri value) { return default(System.Json.JsonValue); }
    public static System.Json.JsonValue Parse(string jsonString) { return default(System.Json.JsonValue); }
    public virtual void Save(System.IO.Stream stream) { }
    public virtual void Save(System.IO.TextWriter textWriter) { }
    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { return default(System.Collections.IEnumerator); }
    public override string ToString() { return default(string); }
  }
}
